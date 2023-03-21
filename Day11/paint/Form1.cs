namespace paint
{
    public partial class Form1 : Form
    {
        //Graphics grfx;
        Point lastPoint = Point.Empty;
        bool isMouseDown = new();
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            this.Resize += (sender, e) => Invalidate();
        }

        Pen myPen = new Pen(Color.Black, 5);
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (Point p in points) 
            {
                e.Graphics.DrawEllipse(myPen, p.X-2, p.Y-2, 5, 5);
                e.Graphics.FillEllipse(Brushes.Aqua, p.X - 2, p.Y - 2, 5, 5);
            }
            base.OnPaint(e);
        }


        private void mouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastPoint = e.Location;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { myPen.Color = dlgColor.Color; }
            else { myPen.Color = this.BackColor; }
            if (isMouseDown)
            {
                if (lastPoint != Point.Empty)
                {
                    Graphics grfx = this.CreateGraphics();
                    grfx.DrawLine(myPen, lastPoint, e.Location);
                    grfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    lastPoint = e.Location;
                    points.Add(lastPoint);
                }
            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog() == DialogResult.OK)
                myPen.Color = dlgColor.Color;
        }

    }
}