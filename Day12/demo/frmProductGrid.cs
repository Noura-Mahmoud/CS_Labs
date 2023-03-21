using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace demo
{
    public partial class frmProductGrid : Form
    {
        public frmProductGrid()
        {
            InitializeComponent();
        }

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlAdap;
        DataTable dtProd;

        SqlCommand sqlCmdAllCat;
        SqlDataAdapter DACat;
        DataTable DTCat;

        SqlCommand sqlCmdAllSup;
        SqlDataAdapter DASup;
        DataTable DTSup;

        private void frmProductGrid_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString);
            sqlCmd = new SqlCommand("select * from Products", sqlCn);
            sqlAdap = new SqlDataAdapter(sqlCmd);
            dtProd = new DataTable();

            sqlCmdAllCat = new SqlCommand("select CategoryID as CID , CategoryName As CName from Categories", sqlCn);
            DACat = new SqlDataAdapter(sqlCmdAllCat);
            DTCat = new();

            sqlCmdAllSup = new SqlCommand("select SupplierID as SupID , CompanyName As SupName from Suppliers", sqlCn);
            DASup = new SqlDataAdapter(sqlCmdAllSup);
            DTSup = new();

            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sqlAdap);
            sqlAdap.InsertCommand = cmdBuilder.GetInsertCommand();
            sqlAdap.UpdateCommand = cmdBuilder.GetUpdateCommand();
            sqlAdap.DeleteCommand = cmdBuilder.GetDeleteCommand();
        }
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            sqlAdap.Fill(dtProd);
            DACat.Fill(DTCat);
            DASup.Fill(DTSup);

            DataGridViewComboBoxColumn catCol = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn supCol = new DataGridViewComboBoxColumn();
            catCol.DataSource = DTCat;
            catCol.DisplayMember = "CName";
            catCol.ValueMember = "CID";
            catCol.DataPropertyName= "CategoryID";
            catCol.HeaderText = "Category";

            supCol.DataSource = DTSup;
            supCol.DisplayMember = "SupName";
            supCol.ValueMember = "SupID";
            supCol.DataPropertyName = "SupplierID";
            supCol.HeaderText = "Supplier";

            this.gridProd.DataSource = dtProd;
            gridProd.Columns.Add(catCol);
            gridProd.Columns.Add(supCol);
            gridProd.Columns[0].ReadOnly = true;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridProd.EndEdit();
            sqlAdap.Update(dtProd);
            frmProductGrid_Load(this, EventArgs.Empty);
            gridProd.DataSource = null;
            readToolStripMenuItem_Click(this, EventArgs.Empty);


        }

        #region cat
        //SELECT Products.ProductName, Products.ProductID, Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.Discontinued, Products.SupplierID, Products.CategoryID,
        //Categories.CategoryName, Suppliers.CompanyName
        //FROM     Categories INNER JOIN
        //                  Products ON Categories.CategoryID = Products.CategoryID INNER JOIN
        //                  Suppliers ON Products.SupplierID = Suppliers.SupplierID
        //WHERE  (Products.CategoryID = @CatID)
        #endregion

        #region supp
        //SELECT Products.ProductName, Products.ProductID, Products.QuantityPerUnit, Products.UnitPrice, Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.Discontinued, Products.SupplierID, Products.CategoryID,
        //          Categories.CategoryName, Suppliers.CompanyName
        //FROM     Categories INNER JOIN
        //                  Products ON Categories.CategoryID = Products.CategoryID INNER JOIN
        //                  Suppliers ON Products.SupplierID = Suppliers.SupplierID
        //WHERE  (Products.SupplierID = @SupplierID)
        #endregion
    }
}
