using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculator ca = new calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                int sum = number + number2;
                ca.add();
                MessageBox.Show(sum.ToString());
            }
            catch
            {
                MessageBox.Show("pless enter a number");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                ca.subtract();
                int sub = number - number2;
                MessageBox.Show(sub.ToString());
            }

            catch
            {
                MessageBox.Show("pless enter a number");
            }
        }
    }
    interface loperations
    {
        void add();
        void subtract();
    }

    class calculator : loperations
    {
        public void add()
        {
            

            MessageBox.Show("add shod");
        }

        public void subtract()
        {
            MessageBox.Show("kam shod");
        }
    }
}

