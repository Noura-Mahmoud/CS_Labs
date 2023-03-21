namespace dialogs
{
    public partial class RTFNotePad : Form
    {
        public RTFNotePad()
        {
            InitializeComponent();
        }

        private void btnOpen(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Rich text file|*.rtf| Text files|*.txt";
            //dlgOpen.ShowDialog();
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                switch (dlgOpen.FilterIndex) // starting from 1
                {
                    case 1:
                        rtfBox.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        rtfBox.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }

        private void btnSave(object sender, EventArgs e)
        {
            dlgSave.Filter = "Rich text file|*.rtf| Text files|*.txt";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                rtfBox.SaveFile(dlgSave.FileName, (RichTextBoxStreamType)dlgSave.FilterIndex - 1);  // 0 for rtf, 1 for txt
            }
        }
        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFont(object sender, EventArgs e)
        {
            dlgFont.Font = rtfBox.SelectionFont;
            if(dlgFont.ShowDialog() == DialogResult.OK) 
            {
                rtfBox.SelectionFont = dlgFont.Font;
            }
        }

        private void btnColor(object sender, EventArgs e)
        {
            dlgColor.Color = rtfBox.SelectionColor;
            if (dlgColor.ShowDialog()==DialogResult.OK) 
            {
                rtfBox.SelectionColor = dlgColor.Color;
            }
        }

        custDlg dlgCust= new();
        private void btnCust(object sender, EventArgs e)
        {
            dlgCust.txt = "";
            if (dlgCust.ShowDialog() == DialogResult.OK)
                this.rtfBox.AppendText(dlgCust.txt.ToUpper());
        }

        private void btnClose(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}