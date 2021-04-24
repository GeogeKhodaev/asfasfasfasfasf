using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button2.Location = new Point(button2.Location.X - 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.D)
            {
                button2.Location = new Point(button2.Location.X + 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Space)
            {
                button2.Visible = false;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button2.Location = new Point(button2.Location.X - 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
            }

            else if (e.KeyCode == Keys.D)
            {
                button2.Location = new Point(button2.Location.X + 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Space)
            {
                button2.Visible = true;
            }
        }
        Button button;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            button = new Button();
            button.Location = new Point(r.Next(16, 1315), 0);
            button.BackgroundImage = WinFormsApp2.Properties.Resources.Meteor;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Size = new Size(98, 95);
            this.Controls.Add(button);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c.Name != "button1" && c.Name != "button2")
                {
                    if (c is Button)
                    {
                        ((Button)c).Location = new Point(c.Location.X, c.Location.Y + 10);
                        
                    }
                }
            }
           
        }
        //хз что делать ниже
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (button != null )
                {
                    if (button.Location.Y > 278 && button.Location.Y < 388 || button.Location.X < 709 && button.Location.X > 638)
                    {
                        button.Visible = false;
                    }
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
