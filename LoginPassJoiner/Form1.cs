using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassJoiner
{
    public partial class Form1 : Form
    {
        Point last;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Lines.Length; i++) 
            {
                for (int x = 0; x < textBox2.Lines.Length; x++) 
                textBox3.Text += textBox1.Lines[i] + ";" + textBox2.Lines[x] + "\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < textBox4.Lines.Length; x++)
            {
                for (int y = 0; y < textBox4.Lines[x].Length; y++) 
                {
                    if (textBox4.Lines[x][y] != '@')
                    {
                        textBox5.Text += textBox4.Lines[x][y];
                    }
                    else if (textBox4.Lines[x][y] == '@')
                    {
                        y = textBox4.Lines[x].Length;
                    }
                }
                textBox5.Text += "\r\n";
            }
        }
    }
}
