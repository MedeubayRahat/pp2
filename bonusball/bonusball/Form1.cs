using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bonusball
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.White, 30);
        int x = 500;
        int x1 = 500;
        int y = 10;
        int z = 110;
        public Form1()
        {
            InitializeComponent();
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 3;
            z += 3;
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, y, x, z, x1 );
            pen.EndCap.GetTypeCode();
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x1 -= 10;
            x -= 7;
            Refresh();
        }
    }
}
