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

                picturePagamento.Image = Properties.Resources.cartao;

                if (MessageBox.Show($"Total:{total:c}", "Pagamento Em Cartão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    MessageBox.Show("Confirme os dados da venda!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboPagamento.BackColor = Color.Red;
                }
                else
                {
                    cboPagamento.Enabled = false;
                }
            }
            else if (cboPagamento.SelectedIndex == 2)
            {
                total = valor * quantidade - (valor * quantidade * 10 / 100);

                picturePagamento.Image = Properties.Resources.dinheiro;

                if (MessageBox.Show($"Total:{total:c}", "Pagamento Em Dinheiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    MessageBox.Show("Confirme os dados da venda!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboPagamento.BackColor = Color.Red;
                }
                else
                {
                    cboPagamento.Enabled = false;
                }
            }
            else if (cboPagamento.SelectedIndex == 3)
            {
                total = valor * quantidade;
                double parcela = total / 2;


                if (MessageBox.Show($"Total:{parcela:c}", "Pagamento Em Crediario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    MessageBox.Show("Confirme os dados da venda!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboPagamento.BackColor = Color.Red;
                }
                else
                {
                    cboPagamento.Enabled = false;
                }

            }
            lblTotal.Text = $"Total: {total:c}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picturePagamento_Click(object sender, EventArgs e)
        {
           
        }
    }
}
