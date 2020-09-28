using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Di

        {

            public static int D;

            public static int s = 2;

        }

        void Add_food()

        {

            Label label = new Label();

            label.Name = "Lab" + Di.s;

            label.BackColor = System.Drawing.Color.Red;

            label.Size = new System.Drawing.Size(10, 10);

            label.Margin = new System.Windows.Forms.Padding(0);

            label.ForeColor = System.Drawing.Color.Red;

            label.AutoSize = false;

            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Random rd = new Random();

        tag1:

            label.Location = new System.Drawing.Point(rd.Next(0, 30) * 10, rd.Next(0, 30) * 10);

            for (int i = 1; i < Di.s; i++)

            {

                Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; if (label.Location == lo.Location) goto tag1;

            }

            this.Controls.Add(label);

            label.SendToBack();

            panel1.SendToBack();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_food();

            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Di.D == 1) { System.Windows.Forms.SendKeys.Send("{DOWN}"); return; };

            if (Di.D == 2) { System.Windows.Forms.SendKeys.Send("{UP}"); return; };

            if (Di.D == 3) { System.Windows.Forms.SendKeys.Send("{LEFT}"); return; };

            if (Di.D == 4) { System.Windows.Forms.SendKeys.Send("{RIGHT}"); return; };
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && Di.D != 2)

            {

                timer1.Enabled = false;

                Di.D = 1;

                Label lb = (Label)this.Controls.Find("Lab" + Di.s, true)[0];

                Label lbl = (Label)this.Controls.Find("Lab" + (Di.s - 1), true)[0];

                Point[,] Lo = new Point[101, 101];

                for (int i = 1; i <= Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; Lo[i, i] = new Point(lo.Location.X, lo.Location.Y);

                }

                Label le = new Label();

                le.Visible = false;

                if (e.KeyCode == Keys.Down && Di.s > 2 && lbl.BackColor != System.Drawing.Color.Red && Lab1.Location.Y != 340)

                {

                    for (int i = 2; i < Di.s; i++)

                    {

                        Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; lo.Location = Lo[i - 1, i - 1];

                    }

                }

                if (lb.Location == new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y + 10))

                {

                    lb.BackColor = System.Drawing.Color.Black;

                    le.Location = new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y);

                    Lab1.Location = new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y + 10);

                    lb.Location = le.Location;

                    this.Controls.Remove(le);

                    Di.s++;

                    Add_food();

                    timer1.Enabled = true;

                    return;

                }

                for (int i = 1; i < Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; if (lo.Location == new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y + 10)) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; }; ;

                }

                if (e.KeyCode == Keys.Down && Lab1.Location.Y == 340) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; };

                Lab1.Top = Lab1.Top + 10;

                timer1.Enabled = true;

            }

            if (e.KeyCode == Keys.Up && Di.D != 1)

            {

                timer1.Enabled = false;

                Di.D = 2;

                Label lb = (Label)this.Controls.Find("Lab" + Di.s, true)[0];

                Label lbl = (Label)this.Controls.Find("Lab" + (Di.s - 1), true)[0];

                Point[,] Lo = new Point[101, 101];

                for (int i = 1; i <= Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; Lo[i, i] = new Point(lo.Location.X, lo.Location.Y);

                }

                Label le = new Label();

                le.Visible = false;

                if (e.KeyCode == Keys.Up && Di.s > 2 && lbl.BackColor != System.Drawing.Color.Red && Lab1.Location.Y != 0)

                {

                    for (int i = 2; i < Di.s; i++)

                    {

                        Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; lo.Location = Lo[i - 1, i - 1];

                    }

                }

                if (lb.Location == new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y - 10))

                {

                    lb.BackColor = System.Drawing.Color.Black;

                    le.Location = new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y);

                    Lab1.Location = new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y - 10);

                    lb.Location = le.Location;

                    this.Controls.Remove(le);

                    Di.s++;

                    Add_food();

                    timer1.Enabled = true;

                    return;

                }

                for (int i = 1; i < Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; if (lo.Location == new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y - 10)) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; }; ;

                }

                if (e.KeyCode == Keys.Up && Lab1.Location.Y == 0) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; };

                Lab1.Top = Lab1.Top - 10;

                timer1.Enabled = true;

            }

            if (e.KeyCode == Keys.Left && Di.D != 4)

            {

                timer1.Enabled = false;

                Di.D = 3;

                Label lb = (Label)this.Controls.Find("Lab" + Di.s, true)[0];

                Label lbl = (Label)this.Controls.Find("Lab" + (Di.s - 1), true)[0];

                Point[,] Lo = new Point[101, 101];

                for (int i = 1; i <= Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; Lo[i, i] = new Point(lo.Location.X, lo.Location.Y);

                }

                Label le = new Label();

                le.Visible = false;

                if (e.KeyCode == Keys.Left && Di.s > 2 && lbl.BackColor != System.Drawing.Color.Red && Lab1.Location.X != 0)

                {

                    for (int i = 2; i < Di.s; i++)

                    {

                        Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; lo.Location = Lo[i - 1, i - 1];

                    }

                }

                if (lb.Location == new System.Drawing.Point(Lab1.Location.X - 10, Lab1.Location.Y))

                {

                    lb.BackColor = System.Drawing.Color.Black;

                    le.Location = new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y);

                    Lab1.Location = new System.Drawing.Point(Lab1.Location.X - 10, Lab1.Location.Y);

                    lb.Location = le.Location;

                    this.Controls.Remove(le);

                    Di.s++;

                    Add_food();

                    timer1.Enabled = true;

                    return;

                }

                for (int i = 1; i < Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; if (lo.Location == new System.Drawing.Point(Lab1.Location.X - 10, Lab1.Location.Y)) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; }; ;

                }

                if (e.KeyCode == Keys.Left && Lab1.Location.X == 0) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; };

                Lab1.Left = Lab1.Left - 10;

                timer1.Enabled = true;

            }

            if (e.KeyCode == Keys.Right && Di.D != 3)

            {

                timer1.Enabled = false;

                Di.D = 4;

                Label lb = (Label)this.Controls.Find("Lab" + Di.s, true)[0];

                Label lbl = (Label)this.Controls.Find("Lab" + (Di.s - 1), true)[0];

                Point[,] Lo = new Point[101, 101];

                for (int i = 1; i <= Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; Lo[i, i] = new Point(lo.Location.X, lo.Location.Y);

                }

                Label le = new Label();

                le.Visible = false;

                if (e.KeyCode == Keys.Right && Di.s > 2 && lbl.BackColor != System.Drawing.Color.Red && Lab1.Location.X != 410)

                {

                    for (int i = 2; i < Di.s; i++)

                    {

                        Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; lo.Location = Lo[i - 1, i - 1];

                    }

                }

                if (lb.Location == new System.Drawing.Point(Lab1.Location.X + 10, Lab1.Location.Y))

                {

                    lb.BackColor = System.Drawing.Color.Black;

                    le.Location = new System.Drawing.Point(Lab1.Location.X, Lab1.Location.Y);

                    Lab1.Location = new System.Drawing.Point(Lab1.Location.X + 10, Lab1.Location.Y);

                    lb.Location = le.Location;

                    this.Controls.Remove(le);

                    Di.s++;

                    Add_food();

                    timer1.Enabled = true;

                    return;

                }

                for (int i = 1; i < Di.s; i++)

                {

                    Label lo = (Label)this.Controls.Find("Lab" + i, true)[0]; if (lo.Location == new System.Drawing.Point(Lab1.Location.X + 10, Lab1.Location.Y)) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; }; ;

                }

                if (e.KeyCode == Keys.Right && Lab1.Location.X == 410) { timer1.Enabled = false; MessageBox.Show("游戏结束！", "提示"); return; };

                Lab1.Left = Lab1.Left + 10;

                timer1.Enabled = true;

            }
        }

       
       
    }
}
