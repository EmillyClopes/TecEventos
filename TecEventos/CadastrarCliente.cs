using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class CadastrarClientes : Form
    {
        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void NomeCompTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnderecoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenhaTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (var confirmExit = new Saida()) // Substituímos "ConfirmExit" por "Saida"
            {
                var result = confirmExit.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    Application.Exit(); // Fecha a aplicação
                }
                // Se o resultado for "No" ou qualquer outro, nada acontece e volta para a tela atual.
            }
        }
     
    }
}
