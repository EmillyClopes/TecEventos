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
    public partial class Saida : Form
    {
        public Saida()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes; // Retorna "Yes" para fechar a aplicação
            Application.Exit();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Retorna "Cancel" para cancelar a ação
            this.Close();
        }
    }
}
