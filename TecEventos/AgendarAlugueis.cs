using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CS0108.cs
// compile with: /W:2
using System;

namespace TecEventos
{
    public partial class AgendarAlugueis : Form
    {
        public AgendarAlugueis()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDiaSaida.Text = "";
            txtMesSaida.Text = "";
            txtAnoSaida.Text = "";
            txtNomeCliente.Text = "";
            txtContatoCliente.Text = "";
            comboBox1.Text = "";
            txtTotal.Text = "";
            txtDiaEntrada.Text = "";
            txtMesEntrada.Text = "";
            txtAnoEntrada.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Conectar com o banco
        }
    }
}
