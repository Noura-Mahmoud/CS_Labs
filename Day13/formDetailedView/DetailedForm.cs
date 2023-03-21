using BLL.Entities;
using BLL.Entities_Lists;
using BLL.Entities_Manager;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace formDetailedView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TitlesList tList = new();
        PublisherList pList = new();
        BindingSource titleDetailsBind;
        BindingNavigator bindingNavigator;

        private void Form1_Load(object sender, EventArgs e)
        {
            tList = TitleManager.selectAllTitles();
            pList = PublisherManager.selectAllPublishers();
            comboPub.DataSource = pList;
            comboPub.ValueMember = "pub_id";
            comboPub.DisplayMember = "pub_name";
            titleDetailsBind = new BindingSource(tList, "");

            this.btnDelete.Visible = false;

            txtID.DataBindings.Add("Text", titleDetailsBind, "title_id");
            numericPrice.DataBindings.Add("Value", titleDetailsBind, "price", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNotes.DataBindings.Add("Text", titleDetailsBind, "notes");
            dateTimeTitle.DataBindings.Add("Value", titleDetailsBind, "pubdate", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTitle.DataBindings.Add("Text", titleDetailsBind, "TitleName");

            numericAdvance.DataBindings.Add("Value", titleDetailsBind, "advance", true, DataSourceUpdateMode.OnPropertyChanged);
            numericRoyality.DataBindings.Add("Value", titleDetailsBind, "royalty", true, DataSourceUpdateMode.OnPropertyChanged);
            numericSales.DataBindings.Add("Value", titleDetailsBind, "ytd_sales", true, DataSourceUpdateMode.OnPropertyChanged);
            txtType.DataBindings.Add("Text", titleDetailsBind, "Type");

            bindingNavigator = new(titleDetailsBind);
            this.Controls.Add(bindingNavigator);
            titleDetailsBind.AddingNew += (sender, e) => e.NewObject = new Title() { State = EntityState.Added };
            bindingNavigator.DeleteItem.MouseDown += (sender, e) => {
                TitleManager.deleteTitle(txtID.Text);
                reloading();
            };
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(dateTimeTitle.Text, out DateTime dateTitle);
            foreach (var item in tList)
            {
                Trace.WriteLine(item.State);
                if(item.State == EntityState.Changed)
                    TitleManager.updateTitleByID(txtID.Text, txtTitle.Text, txtType.Text, (decimal)numericPrice.Value, (int)numericAdvance.Value, (int)numericSales.Value, (int)numericRoyality.Value, txtNotes.Text, dateTitle, comboPub.SelectedValue.ToString());
                else if (item.State == EntityState.Added)
                    TitleManager.insertTitle(txtID.Text, txtTitle.Text, txtType.Text, (decimal)numericPrice.Value, (int)numericAdvance.Value, (int)numericSales.Value, (int)numericRoyality.Value, txtNotes.Text, dateTitle, comboPub.SelectedValue.ToString());
            }
            reloading();
        }
        private void reloading()
        {
            tList = TitleManager.selectAllTitles();
            pList = PublisherManager.selectAllPublishers();
            titleDetailsBind.DataSource = tList;
            bindingNavigator.BindingSource = titleDetailsBind;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TitleManager.deleteTitle(txtID.Text);

            reloading();
        }
    }
}