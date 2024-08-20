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

        public Form ativarForm = null;

        public void AbreForm(Form novoForm)
        {
            if (ativarForm != null) ativarForm.Close();
            ativarForm = novoForm;
            ativarForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;
            PanelHome.Controls.Add(novoForm);
            PanelHome.Tag = novoForm;
            novoForm.BringToFront();
            novoForm.Show();
        }

        /* abrirNovoForm(new Form3()); /*abre outro formulario*/


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

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            AbreForm(new ListaChacaras());
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            AbreForm(new AdicionarChacara());
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            AbreForm(new Agendamento());
        }

        private void btnDisponibilidade_Click(object sender, EventArgs e)
        {
            AbreForm(new Disponibilidade());
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            AbreForm(new PerfilUser());
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            AbreForm(new Agendamento());
        }

        private void btnPerfilAdm_Click(object sender, EventArgs e)
        {
            AbreForm(new PerfilAdm());
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastrarClientes());
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            AbreForm(new ControlePagamentos());
        }

        private void btnDatasComemorativas_Click(object sender, EventArgs e)
        {
            AbreForm(new DatasComemorativas());
        }

    }
}
