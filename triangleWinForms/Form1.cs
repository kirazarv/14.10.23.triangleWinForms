using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace triangleWinForms
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string sx, sy, sz, result;
        bool b,b2,b3;
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sz = textBox3.Text;
            b3 = double.TryParse(sz, out z);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double sumxy, sumxz, sumyz;
            bool exists;
            if (x != 0)
            {
                if (y != 0)
                {
                    if (z != 0)
                    {
                        sumxy = x + y;
                        sumxz = x + z;
                        sumyz = y + z;
                        if (sumxy > z)
                        {
                            if (sumxz > y)
                            {
                                if (sumyz > x)
                                {
                                    exists = true;
                                }
                                else
                                {
                                    exists = false;
                                    textBox4.Text = "Треугольник с такими длинами сторон не существует";
                                }
                            }
                            else
                            {
                                exists = false;
                                textBox4.Text = "Треугольник с такими длинами сторон не существует";
                            }
                            
                        }
                        else
                        {
                            exists = false;
                            textBox4.Text = "Треугольник с такими длинами сторон не существует";
                        }
                        if (exists)
                        {
                            if (x == y)
                            {
                                if (x == z)
                                {
                                    textBox4.Text = "Треугольник равносторонний";
                                }
                                else
                                {
                                    textBox4.Text = "Треугольник равнобедренный";
                                }

                            }
                            else
                            {
                                if (x == z) textBox4.Text = "Треугольник равнобедренный";
                                else
                                {
                                    if (y == z) textBox4.Text = "Треугольник равнобедренный";
                                    else
                                    {
                                        textBox4.Text = "Треугольник разносторонний";
                                    }
                                }
                            }
                        }
                    }
                    else textBox4.Text = "Треугольника не существует";

                }
                else textBox4.Text = "Треугольника не существует";

            }
            else textBox4.Text = "Треугольника не существует";
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = '.';
            if (e.KeyChar == ',')
            {
                if (textBox3.Text.Contains(","))
                    e.Handled = true;
                if (textBox3.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == 0)
            {
                if (textBox3.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sy = textBox2.Text;
            b2 = double.TryParse(sy, out y);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = '.';
            if (e.KeyChar == ',')
            {
                if (textBox2.Text.Contains(","))
                    e.Handled = true;
                if (textBox2.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == 0)
            {
                if (textBox2.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sx = textBox1.Text;
            b = double.TryParse(sx, out x);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar=='.') e.KeyChar= '.';
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.Contains(","))
                    e.Handled = true;
                if (textBox1.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == 0)
            {
                if (textBox1.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        public Form1()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        

        }
    }
}
