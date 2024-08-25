using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class Agendamento : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetAgendamento agendamento;
        private int chacaraIdSelecionado;
        private void Agendamento_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }
        public Agendamento()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            agendamento = new GetSetAgendamento();
            this.Load += Agendamento_Load;
        }
        private void LoadChacarasDisponiveis()
        {
            string query = "SELECT entrada_data, saida_data, usuario_id, chacara_id, valor_pagamento" +
                "FROM agendamento";
            
            using(MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    GridViewAgendamentos.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum agendamento disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewAgendamentos.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {

        }

        private void GridViewAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = GridViewAgendamentos.Rows[e.RowIndex];
                // Supondo que o ID da chácara está na primeira coluna (ajuste o índice da coluna conforme necessário)
                chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value);
            }
        }
    }
    
}
