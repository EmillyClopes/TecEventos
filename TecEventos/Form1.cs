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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent(); 
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            /*Fecha a tela*/
        }

        private void AbreForm(Form AdicionarChacara)
        {
            
            AdicionarChacara.Show(); /*abre*/
            this.Hide(); /*fecha*/

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            AbreForm(new AdicionarChacara()); /*abre o outro formulário*/

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            AbreForm(new Home());
        }
    }
}
