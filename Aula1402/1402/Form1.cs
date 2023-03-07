using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVenda_Click(object sender, EventArgs e)
        {
            float valor, quantidade, total=0;
            valor = float.Parse(txtPreco.Text);
            quantidade = float.Parse(txtPreco.Text);

            if (cboPagamento.SelectedIndex == 0)
            {

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
