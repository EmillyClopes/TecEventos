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
    public partial class ControlePagamentos : Form
    {
        public ControlePagamentos()
        {
            InitializeComponent();
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
