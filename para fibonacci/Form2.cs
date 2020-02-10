using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace para_fibonacci
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i, cd = 0;
            n = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {
                    cd++;
                }
                if (cd != 2)
                {
                    label2.Text = " el numero ingresado no es primo";
                }
                else
                {
                    label2.Text = " el numero ingresado es primo";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}