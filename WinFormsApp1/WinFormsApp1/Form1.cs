using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush b1 = new SolidBrush(Color.Aquamarine);
            g.FillEllipse(b1, 40, 40, 80, 80) ;

            HatchBrush b2 = new HatchBrush(HatchStyle.ZigZag, Color.Red);
            g.FillEllipse(b2, 80, 80, 80, 80);

            RectangleF rect = new Rectangle(0, 0, 100, 100);
            LinearGradientBrush b3 = new LinearGradientBrush(rect, Color.Red, Color.Blue, LinearGradientMode.Horizontal);
            g.FillEllipse(b3, 120, 120, 80, 80);
            
        }
    }
}
