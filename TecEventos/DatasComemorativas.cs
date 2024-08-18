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
    public partial class DatasComemorativas : Form
    {
        public DatasComemorativas()
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (homeForm != null)
            {
                this.Hide(); // Oculta o formulário atual (FormularioX)
                homeForm.Show(); // Exibe o formulário Home
            }
            else
            {
                // Se o formulário Home não estiver aberto, você pode criá-lo e mostrar
                var newHomeForm = new Home();
                this.Hide(); // Oculta o formulário atual (FormularioX)
                newHomeForm.Show(); // Exibe o novo formulário Home
            }
        }
    }
}
