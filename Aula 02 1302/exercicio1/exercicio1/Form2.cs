using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor1, valor2, total;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            if (comboBox1.SelectedIndex == 0){
                total = valor1 + valor2;
                label3.Text = "Total: " + total;
            }
            else if (comboBox1.SelectedIndex == 1) {
                total = valor1 - valor2;
                label3.Text = "Total: " + total;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                total = valor1 * valor2;
                label3.Text = "Total: " + total;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                total = valor1 / valor2;
                label3.Text = "Total: " + total;
            }
        }
    }
}
