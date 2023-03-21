using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo
{
    public partial class frmDetailedView : Form
    {
        public frmDetailedView()
        {
            InitializeComponent();
        }

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlAdap;
        DataTable dtProd;

        SqlCommand updateUnitPrice;
        BindingSource prodBinding;

        private void frmDetailedView_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString);
            sqlCmd = new SqlCommand("SelectAllProducts", sqlCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlAdap = new SqlDataAdapter(sqlCmd);
            dtProd = new DataTable();


            //ex
            SqlCommandBuilder builder = new(sqlAdap);
            sqlAdap.InsertCommand = builder.GetInsertCommand();
            sqlAdap.UpdateCommand = builder.GetUpdateCommand();
            sqlAdap.DeleteCommand = builder.GetDeleteCommand();

            sqlAdap.Fill(dtProd);
            
            prodBinding = new BindingSource(dtProd, "");
            
            this.lblID.DataBindings.Add("Text", prodBinding, "ProductID");
            this.txtName.DataBindings.Add("Text", prodBinding, "ProductName");
            this.numUnitPrice.DataBindings.Add("Text", prodBinding, "UnitPrice");
            this.numUnitsInStock.DataBindings.Add("Text", prodBinding, "UnitsInStock");

            SqlCommand sqlCmdAllCat;
            SqlDataAdapter DACat;
            DataTable DTCat;
            sqlCmdAllCat = new SqlCommand("select CategoryID as CID , CategoryName As CName from Categories", sqlCn);
            DACat = new SqlDataAdapter(sqlCmdAllCat);
            DTCat = new();
            DACat.Fill(DTCat);

            this.comboCat.DataSource = DTCat;
            this.comboCat.ValueMember = "CID";
            this.comboCat.DisplayMember = "CName";
            this.comboCat.DataBindings.Add("SelectedValue", prodBinding, "CategoryID");

            SqlCommand sqlCmdAllSup;
            SqlDataAdapter DASup;
            DataTable DTSup;
            sqlCmdAllSup = new SqlCommand("select SupplierID as SupID , CompanyName As SupName from Suppliers", sqlCn);
            DASup = new SqlDataAdapter(sqlCmdAllSup);
            DTSup = new();
            DASup.Fill(DTSup);

            this.comboSup.DataSource = DTSup;
            this.comboSup.ValueMember = "SupID";
            this.comboSup.DisplayMember = "SupName";
            this.comboSup.DataBindings.Add("SelectedValue", prodBinding, "SupplierID");

            BindingNavigator bindingNav = new BindingNavigator(prodBinding);
            this.Controls.Add(bindingNav);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //prodBinding.EndEdit();
            sqlAdap.Update(dtProd);
        }

    }
}
