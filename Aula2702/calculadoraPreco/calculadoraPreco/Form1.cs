using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPreco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

            
        }

        private void cboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            float valor, quantidade, total = 0;
            valor = float.Parse(txtPreco.Text);
            quantidade = float.Parse(txtQtde.Text);

            if (cboPagamento.SelectedIndex == 0 || cboPagamento.SelectedIndex == 1)
            {
                total = valor * quantidade;
            }
            else if (cboPagamento.SelectedIndex == 2)
            {
                total = valor * quantidade - (valor * quantidade * 10 / 100);
            }
            else if (cboPagamento.SelectedIndex == 3)
            {
                total = valor * quantidade + (valor * quantidade * 10 / 100);
               
            }
            lblTotal.Text = $"Total: {total:c}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
