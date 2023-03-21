namespace DragDropRect
{
    public partial class Form1 : Form
    {
        public int rectWidth = 100;
        public int rectHeight = 100;
        bool isMouseDown = new();
        Point lastPoint = new Point(100, 100);
        Point start = new();
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, lastPoint.X, lastPoint.Y, rectWidth, rectHeight);
            //e.Graphics.FillRectangle(Brushes.BlueViolet, lastPoint.X, lastPoint.Y, rectWidth, rectHeight);
            base.OnPaint(e);
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            start = e.Location;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMouseDown)
                {
                    if(e.X < lastPoint.X+rectWidth && e.Y< lastPoint.Y + rectHeight) 
                    //if (lastPoint != Point.Empty && e.X < lastPoint.X+rectWidth && e.X>lastPoint.X && e.Y > lastPoint.Y && e.Y < lastPoint.Y + rectHeight)
                    {
                        Graphics grfx = this.CreateGraphics();
                        grfx.Clear(Color.WhiteSmoke);
                        grfx.FillRectangle(Brushes.BlueViolet, lastPoint.X + (e.X-start.X) , lastPoint.Y+(e.Y-start.Y), rectWidth, rectHeight);
                        grfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        start = lastPoint;
                        lastPoint = e.Location;
                    }
                }
            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            //lastPoint = Point.Empty;
        }
    }
}