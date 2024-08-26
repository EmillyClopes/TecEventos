using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TecEventos
{
    public partial class VisualizacaoPag : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetControlePagamentos pagamento;
        private void VisualizacaoPag_Load(object sender, EventArgs e)
        {
            LoadPagamentos();
        }
        public VisualizacaoPag()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            pagamento = new GetSetControlePagamentos();
            this.Load += VisualizacaoPag_Load;
        }
        private void LoadPagamentos()
        {
            string query = "SELECT u.nome as Nome,   c.nome as Chacara,    cp.valor_pago as 'Valor Pago',    cp.data_pagamento as 'Data de Pagamento',    cp.metodo_pagamento as 'Método de Pagamento',   cp.status_pagamento as 'Status do Pagamento'\r\n FROM controle_pagamentos cp join usuarios u on cp.usuario_id = u.id join chacara c on cp.chacara_id = c.id join agendamento a on cp.agendamento_id = a.id;";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;

                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.Enabled = false;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum pagamento disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeChacara = TxtChacara.Text.Trim();
            string nomeCliente = txtCliente.Text.Trim();

            if (string.IsNullOrEmpty(nomeChacara) && string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Por favor, preencha o nome da chácara ou do cliente para realizar a pesquisa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nomeChacara))
            {
                PesquisarPorCliente();
            }
            else if (string.IsNullOrEmpty(nomeCliente))
            {
                PesquisarPorChacara();
            }
            else
            {
                PesquisarPorChacaraCliente();
            }
        }

        void PesquisarPorCliente()
        {
            string query = "SELECT u.nome as Nome,    c.nome as Chacara,     cp.valor_pago as 'Valor Pago',    cp.data_pagamento as 'Data de Pagamento',    cp.metodo_pagamento as 'Método de Pagamento',    cp.status_pagamento as 'Status do Pagamento' FROM controle_pagamentos cp join usuarios u on cp.usuario_id = u.id join chacara c on cp.chacara_id = c.id join agendamento a on cp.agendamento_id = a.id where u.nome  LIKE '@nomeCliente'";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeChacara", TxtChacara.Text);
                    command.Parameters.AddWithValue("@nomeCliente", txtCliente.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void PesquisarPorChacara()
        {
            string query = "SELECT u.nome as Nome,    c.nome as Chacara,     cp.valor_pago as 'Valor Pago',    cp.data_pagamento as 'Data de Pagamento',    cp.metodo_pagamento as 'Método de Pagamento',    cp.status_pagamento as 'Status do Pagamento' FROM controle_pagamentos cp join usuarios u on cp.usuario_id = u.id join chacara c on cp.chacara_id = c.id join agendamento a on cp.agendamento_id = a.id where c.nome  LIKE '@nomeChacara'";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeChacara", TxtChacara.Text);
                    command.Parameters.AddWithValue("@nomeCliente", txtCliente.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void PesquisarPorChacaraCliente()
        {
            string query = "SELECT u.nome as Nome,    c.nome as Chacara,     cp.valor_pago as 'Valor Pago',    cp.data_pagamento as 'Data de Pagamento',    cp.metodo_pagamento as 'Método de Pagamento',    cp.status_pagamento as 'Status do Pagamento' FROM controle_pagamentos cp join usuarios u on cp.usuario_id = u.id join chacara c on cp.chacara_id = c.id join agendamento a on cp.agendamento_id = a.id where c.nome  LIKE '@nomeChacara' and u.nome  LIKE '@nomeCliente'";
            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomeChacara", TxtChacara.Text);
                    command.Parameters.AddWithValue("@nomeCliente", txtCliente.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
