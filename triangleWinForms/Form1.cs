using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        
        private void workWithBtn(string str, ref double target)
        {
            Console.WriteLine(target);
            bool b = double.TryParse(str, out target);
            if (b || str == "")
            {
                button1.Enabled = true;
                textBox4.Text = "";
            }
            else
            {
                textBox4.Text = "incorrect input";
                button1.Enabled = false;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            workWithBtn(textBox3.Text, ref z);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string sideA = textBox1.Text;
            string sideB = textBox2.Text;
            string sideC = textBox3.Text;   
            if (sideA == "" && sideB == "" && sideC == "")
            {
                textBox4.Text = "all empty inputs";
                return;
            }
            if (sideA == "" || sideB == "" || sideC == "")
            {
                textBox4.Text = "some inputs are empty";
                return;
            }
            if (sideA == "0" && sideB == "0" && sideC == "0")
            {
                textBox4.Text = "0 0 0";
                return;
            }

            double sumxy, sumxz, sumyz;
            sumxy = x + y;
            sumxz = x + z;
            sumyz = y + z;
            
            if (sumxy > z && sumxz > y && sumyz > x)
            {
                 if (x == y && y == z)
                {
                    textBox4.Text = "equilateral";
                    return;
                }
                if (x == y || y == z || x == z)
                {
                    textBox4.Text = "isosceles";
                 
                    return;
                }
                textBox4.Text = "разносторонний";
             
            }
            else
            {
                textBox4.Text = "a triangle with these sides doesn't exist";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            workWithBtn(textBox2.Text, ref y);
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            workWithBtn(textBox1.Text, ref x);
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
