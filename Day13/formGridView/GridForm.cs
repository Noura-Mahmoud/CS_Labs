using BLL.Entities;
using BLL.Entities_Lists;
using BLL.Entities_Manager;
using System;
using System.Diagnostics;

namespace formGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TitlesList titles;
        List<string> deletedItems;
        private void Form1_Load(object sender, EventArgs e)
        {
            loading(sender, e);
            #region loading
            //deletedItems = new List<string>();
            //titles = TitleManager.selectAllTitles();
            //BindingSource gridTitlesBinding = new(titles, "");
            //gridViewTitles.DataSource = gridTitlesBinding;

            //DataGridViewComboBoxColumn publisherCol = new();
            //publisherCol.HeaderText = "Publisher";
            //publisherCol.DataSource = PublisherManager.selectAllPublishers();
            //publisherCol.DisplayMember = "pub_name";
            //publisherCol.ValueMember = "pub_id";
            //publisherCol.DataPropertyName= "pub_id";
            //gridViewTitles.Columns.Add(publisherCol); 

            ////gridTitlesBinding.AddingNew += (sender, e) => new Title { State = EntityState.Added };
            //gridViewTitles.UserAddedRow += (sender, e) =>
            //{
            //    Debug.WriteLine($"before {gridViewTitles.Rows.SharedRow(gridViewTitles.Rows.Count - 2).Cells["State"].Value}");
            //    gridViewTitles.Rows.SharedRow(gridViewTitles.Rows.Count - 2).Cells["State"].Value = EntityState.Added;
            //    Debug.WriteLine($"after {gridViewTitles.Rows.SharedRow(gridViewTitles.Rows.Count - 2).Cells["State"].Value}");
            //};

            //gridViewTitles.UserDeletingRow += (sender, e) =>
            //{
            //    e.Row.Cells["State"].Value = EntityState.Deleted;
            //    deletedItems.Add(e.Row.Cells["title_id"].Value.ToString());
            //    gridTitlesBinding.RemoveCurrent();   
            //};
            #endregion

            DataGridViewComboBoxColumn publisherCol = new();
            publisherCol.HeaderText = "Publisher";
            publisherCol.DataSource = PublisherManager.selectAllPublishers();
            publisherCol.DisplayMember = "pub_name";
            publisherCol.ValueMember = "pub_id";
            publisherCol.DataPropertyName = "pub_id";
            gridViewTitles.Columns.Add(publisherCol);
        }

        private void loading(object sender, EventArgs e)
        {
            gridViewTitles.Rows.Clear();
            deletedItems = new List<string>();
            titles = TitleManager.selectAllTitles();
            BindingSource gridTitlesBinding = new(titles, "");
            gridViewTitles.DataSource = gridTitlesBinding;
            
            gridViewTitles.UserAddedRow += (sender, e) =>
            {
                gridViewTitles.Rows.SharedRow(gridViewTitles.Rows.Count - 2).Cells["State"].Value = EntityState.Added;
            };

            gridViewTitles.UserDeletingRow += (sender, e) =>
            {
                deleteToolStripMenuItem_Click(sender, e);
            };
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gridViewTitles.EndEdit();
            foreach (var item in titles)
            {
                Debug.WriteLine(item.Pubdate);
                if (item.Pubdate.Year < 1990)
                {
                    item.Pubdate = DateTime.Today;
                    //item.Pubdate = DateTime.Now;
                }
                Debug.WriteLine(item.Pub_id);
                Debug.WriteLine(item.Pubdate);
                Debug.WriteLine(item.State);
                if (item.State == EntityState.Changed)
                    TitleManager.updateTitleByID(item.Title_id??"", item.TitleName??"", item.Type??"", (decimal)(item.Price??0m), (decimal)(item.Advance??0m), (int)(item.Royalty??0), (int)(item.Ytd_sales??0), item.Notes??"", (DateTime)(item.Pubdate), item.Pub_id ?? "0736");
                else if (item.State == EntityState.Added)
                    TitleManager.insertTitle(item.Title_id ?? "", item.TitleName ?? "", item.Type ?? "", (decimal)(item.Price ?? 0m), (decimal)(item.Advance ?? 0m), (int)(item.Royalty ?? 0), (int)(item.Ytd_sales ?? 0), item.Notes ?? "", item.Pubdate, item.Pub_id ?? "0736");
            }
            foreach(var title in deletedItems)
            {
                TitleManager.deleteTitle(title);
            }
            deletedItems.Clear();
            this.Refresh();
            loading(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in gridViewTitles.SelectedRows)
            {
                string idDelete = row.Cells["title_id"].Value.ToString();
                //Debug.WriteLine(idDelete);
                deletedItems.Add(idDelete);
            }
            saveToolStripMenuItem_Click(sender, e);
            loading(sender, e);
        }
    }
}