using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;
namespace dot_info
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<Rectangle> kareler = new List<Rectangle>();
        //private bool isToolTipShown = false;
        private ToolTip toolTip = new ToolTip();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {

                CizimYap();
                //isToolTipShown = true;

            }
        }

        private void CizimYap()
        {
            //kareler.Clear();

            Graphics g = pictureBox1.CreateGraphics();

            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(0, pictureBox1.Width - 10);
                int y = random.Next(0, pictureBox1.Height - 10);

                int width = 10;
                int height = 10;


                using (Brush customBrush = new SolidBrush(Color.Black))
                {
                    Rectangle rectangle = new Rectangle(x, y, width, height);
                    kareler.Add(rectangle);
                    g.FillRectangle(customBrush, x, y, width, height);
                }
            }

            g.Dispose();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.Location;

            foreach (Rectangle rectangle in kareler)
            {
                if (rectangle.Contains(mousePosition))
                {
                    ShowInfo(rectangle, mousePosition);
                    return;
                }
            }
            HideInfo();
        }

        private void ShowInfo(Rectangle rectangle, Point position)
        {
            string message = $"Kare Konumu: X:{rectangle.X}, Y:{rectangle.Y}";
            toolTip.SetToolTip(pictureBox1, message);
        }

        private void HideInfo()
        {
            toolTip.SetToolTip(pictureBox1, string.Empty);
        }
    }
}
