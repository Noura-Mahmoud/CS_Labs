using GridView.Context;
using GridView.Models;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public partial class formGrid : Form
    {
        public formGrid()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context.Dispose();
        }
        pubsContext Context = new();
        private void formGrid_Load(object sender, EventArgs e)
        {
            Context.Titles.Load();
            Context.Publishers.Load();
            loadingForm(sender, e);

            DataGridViewComboBoxColumn publishers = new();
            publishers.HeaderText = "publisher";
            publishers.DataSource = Context.Publishers.Local.ToBindingList();
            publishers.DisplayMember = "PubName";
            publishers.ValueMember = "PubId";
            publishers.DataPropertyName = "PubId";
            GridViewTitles.Columns.Add(publishers);
        }

        private void loadingForm(object sender, EventArgs e)
        {
            GridViewTitles.DataSource = Context.Titles.Local.ToBindingList();

            GridViewTitles.UserAddedRow += (sender, e) =>
            {
                var added = GridViewTitles.Rows.SharedRow(GridViewTitles.RowCount - 2);
                added.Cells["TitleId"].Value ??= "";
                added.Cells["Title1"].Value ??= "";
                added.Cells["type"].Value ??= "";
                added.Cells["PubId"].Value ??= "0736";
                added.Cells["price"].Value ??= 0m;
                added.Cells["advance"].Value ??= 0m;
                added.Cells["royalty"].Value ??= 0;
                added.Cells["YtdSales"].Value ??= 0;
                added.Cells["notes"].Value ??= "";
                added.Cells["pubdate"].Value ??= DateTime.Now;
            };

            GridViewTitles.Columns["Pub"].Visible = false;
            GridViewTitles.Columns["PubId"].Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();
            loadingForm(sender, e);
        }
    }
}