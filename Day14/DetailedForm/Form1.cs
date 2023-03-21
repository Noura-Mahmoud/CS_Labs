using DetailedForm.Context;
using Microsoft.EntityFrameworkCore;

namespace DetailedForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        pubsContext Context = new();
        BindingSource titlesBindingSource;
        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Titles.Load();
            Context.Publishers.Load();
            titlesBindingSource = new BindingSource(Context.Titles.Local.ToBindingList(),"");
            txtID.DataBindings.Add("Text", titlesBindingSource, "TitleId");
            numericPrice.DataBindings.Add("Value", titlesBindingSource, "price", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNotes.DataBindings.Add("Text", titlesBindingSource, "notes");
            dateTimeTitle.DataBindings.Add("Value", titlesBindingSource, "pubdate", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTitle.DataBindings.Add("Text", titlesBindingSource, "Title1");

            numericAdvance.DataBindings.Add("Value", titlesBindingSource, "advance", true, DataSourceUpdateMode.OnPropertyChanged);
            numericRoyality.DataBindings.Add("Value", titlesBindingSource, "royalty", true, DataSourceUpdateMode.OnPropertyChanged);
            numericSales.DataBindings.Add("Value", titlesBindingSource, "YtdSales", true, DataSourceUpdateMode.OnPropertyChanged);
            txtType.DataBindings.Add("Text", titlesBindingSource, "Type");


            comboPub.DataSource = Context.Publishers.Local.ToBindingList();
            comboPub.ValueMember = "PubId";
            comboPub.DisplayMember = "PubName";

            BindingNavigator bindingNavigator = new(titlesBindingSource);
            this.Controls.Add(bindingNavigator);

            titlesBindingSource.AddingNew += (sender, e) =>
            {
                txtID.Text = "";
                txtTitle.Text = "Unknown";
                txtType.Text = "";
                comboPub.SelectedValue = "0736";
                txtNotes.Text = "";
                txtType.Text = "";

                numericAdvance.Value = 0m;
                numericPrice.Value = 0m;
                numericRoyality.Value = 0;
                numericSales.Value = 0;
                dateTimeTitle.Value = DateTime.Now;
            };

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Context.SaveChanges();
        }

    }
}