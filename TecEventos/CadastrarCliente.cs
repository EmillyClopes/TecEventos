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
            //Conectar com o banco
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void EnderecoTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void TelefoneTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void SenhaTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            NomeCompTxt.Text = "";
            EmailTxt.Text = "";
            EnderecoTxt.Text = "";
            TelefoneTxt.Text = "";
            SenhaTxt.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Conectar com o banco
        }
    }
}
