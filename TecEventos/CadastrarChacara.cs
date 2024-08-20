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
            form.AbreForm(new Home());
        }

        Home form = new Home();

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

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            form.AbreForm(new AgendarAlugueis());
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            form.AbreForm(new CadastrarClientes());
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            form.AbreForm(new ListaChacaras());
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            form.AbreForm(new ControlePagamentos());
        }

        private void btnDisponibilidade_Click(object sender, EventArgs e)
        {
            form.AbreForm(new Disponibilidade());
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            form.AbreForm(new PerfilUser());
        }

        private void btnDatasComemorativas_Click(object sender, EventArgs e)
        {
            form.AbreForm(new DatasComemorativas());
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            form.AbreForm(new Agendamento());
        }

        private void btnPerfilAdm_Click(object sender, EventArgs e)
        {
            form.AbreForm(new PerfilAdm());
        }
    }
}
