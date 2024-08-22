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
    public partial class AdicionarChacara : Form
    {
        public AdicionarChacara()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeChacara.Text = "";
            txtValor.Text = "";
            txtRua.Text = "";
            txtNumChacara.Text = "";
            txtBairro.Text = "";
            txtRegras.Text = "";
            txtDescricao.Text = "";
        }

        private void btnCadastrarChacara_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }
    }
}
