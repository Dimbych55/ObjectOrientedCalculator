using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        Operationscalculate C;
        public Form1()
        {
            InitializeComponent();
            C = new Operationscalculate();
        }
        double  b;
        private void buttonsquare_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(C.square(Convert.ToDouble(textBox1.Text)));
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(C.Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void buttonminus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(C.razn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void buttonumn_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(C.umnog(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox2.Text);
            if ( b == 0)
            {
                MessageBox.Show("Деление на ноль невозможно");
                textBox2.Clear();
            } else

            textBox3.Text = Convert.ToString(C.del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void buttonpow_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(C.step(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

    }
}
