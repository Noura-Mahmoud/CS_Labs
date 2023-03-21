using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace demo
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new SqlConnection();

            #region read from configuration file
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
            #endregion
            //sqlCn.ConnectionString = @"Data Source=MIKASA;initial Catalog = Northwind; Integrated Security = true; Encrypt = false";
            //sqlCn.ConnectionString = @"Data Source=MIKASA;initial Catalog=Northwind;Integrated Security=true;TrustServerCertificate=true"; //Encrypt = false";
            sqlCn.StateChange += (sender, e)=> this.Text = $"state was {e.OriginalState}, cuurent state {e.CurrentState}";
            sqlCmd = new SqlCommand();  
            sqlCmd.Connection = sqlCn;
            //sqlCmd.CommandType = CommandType.Text; // default
            sqlCmd.CommandText = "select * from Products"; // return scalar
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (sqlCn.State ==  ConnectionState.Closed)
            {
                sqlCn.Open();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(sqlCn.State == ConnectionState.Open)
            {
                sqlCn.Close();
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (sqlCn.State == ConnectionState.Closed)
                sqlCn.Open();
            SqlDataReader dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                this.lstProdName.Items.Add(dr.GetString("ProductName"));
            }
            //this.Text = sqlCmd.ExecuteScalar()?.ToString()??"-1";
            sqlCn.Close();
        }
    }
}