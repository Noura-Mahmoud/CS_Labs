namespace football
{
    public partial class Form1 : Form
    {
        int xPosition = 150;
        PaintEventArgs? ev = null;
        public Form1()
        {
            InitializeComponent();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ev = e;
            draw(ev);
            base.OnPaint(e);
        }

        void draw (PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            e.Graphics.DrawEllipse(new Pen(Brushes.Black, 2), 50, 50, 100, 100);
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(100, 150), new Point(100, 300));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(100, 175), new Point(50, 225));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(100, 175), new Point(150, 225));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(100, 300), new Point(50, 350));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(100, 300), new Point(150, 350));

            e.Graphics.DrawEllipse(new Pen(Brushes.Black, 2), 600, 50, 100, 100);
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(650, 150), new Point(650, 300));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(650, 175), new Point(600, 225));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(650, 175), new Point(700, 225));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(650, 300), new Point(600, 350));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(650, 300), new Point(700, 350));


            e.Graphics.FillEllipse(Brushes.GreenYellow, xPosition, 300, 80, 80);
        }

        public System.Windows.Forms.Timer myTimer = new();
        bool direction = false;
        private void TimerProcess(object sender, EventArgs e)
        {
            if (xPosition < 160)
                direction = false;
            else if (xPosition > 530)
                direction = true;
            move();
            if (ev != null)
                this.Invalidate();
        }

        void move()
        {
            if (!direction)
                xPosition += 10;
            else
                xPosition -= 10;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myTimer.Interval = 100;
            myTimer.Tick += new EventHandler(TimerProcess);
            myTimer.Start();
        }
    }
}