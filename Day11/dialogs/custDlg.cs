using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogs
{
    public partial class custDlg : Form
    {
        public custDlg()
        {
            InitializeComponent();
        }
        public string txt { get =>txtBox.Text;  set => txtBox.Text = value; }

    }
}
