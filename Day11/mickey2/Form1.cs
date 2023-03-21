using System.Drawing.Drawing2D;

namespace mickey
{
    public partial class Form1 : Form
    {
        bool isMouseDown = new();
        Point start =new Point(50,50);
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //this.Location = start;
            GraphicsPath path = new();
            path.AddEllipse(50, 50, this.ClientSize.Height -100, this.ClientSize.Height-100);
            path.AddEllipse(0, 0, 150, 150);
            path.AddEllipse(this.ClientSize.Height - 150, 0, 150, 150);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);

            Graphics grfx = this.CreateGraphics();
            grfx.DrawEllipse(new Pen(Brushes.Black, 2), 150, 120, 50, 100);
            grfx.DrawEllipse(new Pen(Brushes.Black, 2), 250, 120, 50, 100);

            grfx.FillEllipse(Brushes.RosyBrown, 155, 155, 40, 60);
            grfx.FillEllipse(Brushes.RosyBrown, 255, 155, 40, 60);

            grfx.DrawArc(new Pen(Brushes.Brown, 5), 180, 250, 100, 70, 0, 180);

            base.OnPaint(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnDrag_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
        }

        //private void btnDrag_MouseDown(object sender, MouseEventArgs e)
        //{
        //    isMouseDown = true;
        //}
        //private void btnDrag_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isMouseDown)
        //    {
        //        if (e.Button == MouseButtons.Left)
        //        {
        //            this.Location = new Point(e.X, e.Y);
        //            //start = new Point(e.X, e.Y);
        //        }
        //    }
        //}
        //private void btnDrag_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isMouseDown= false;
        //}
    }
}