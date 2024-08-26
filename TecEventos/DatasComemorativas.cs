using MySql.Data.MySqlClient;
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
        ConexaoBanco conexaoBanco;
        GetSetDatasComemorativas data;

        private void DatasComemorativas_Load(object sender, EventArgs e)
        {
            LoadDatasComemorativas();
        }
        public DatasComemorativas()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            data = new GetSetDatasComemorativas();
            this.Load += DatasComemorativas_Load;
        }

        private void LoadDatasComemorativas()
        {
            string query = "SELECT dc.data_comemorativa as Data, dc.descricao as Descrição, vd.valor as Valor  FROM datas_comemorativas dc\r\njoin valores_diarias vd on vd.id = dc.valor_promocional_id;";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    GridViewDatasComemorativas.DataSource = datatable;

                    GridViewDatasComemorativas.ReadOnly = true;
                    GridViewDatasComemorativas.AllowUserToAddRows = false;
                    GridViewDatasComemorativas.AllowUserToDeleteRows = false;
                    GridViewDatasComemorativas.MultiSelect = false;
                    GridViewDatasComemorativas.Enabled = false;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma data comemorativa disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewDatasComemorativas.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Validar entradas antes de salvar
            if (string.IsNullOrWhiteSpace(txtNomeDataComemorativo.Text) ||
                string.IsNullOrWhiteSpace(txtPromocao.Text) ||
                !int.TryParse(txtDiaComemorativo.Text, out int dia) ||
                !int.TryParse(txtMesComemorativo.Text, out int mes) ||
                !int.TryParse(txtAnoComemorativo.Text, out int ano))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            data.setDiaMesAno(dia, mes, ano);

            string query = "INSERT INTO datas_comemorativas(descricao, valor_promocional_id, data_comemorativa) " +
                           "VALUES (@descricao, @valor_promocional_id, @data_comemorativa)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@descricao", data.getDescricao());
                    command.Parameters.AddWithValue("@data_comemorativa", new DateTime(data.getAno(), data.getMes(), data.getDia()).ToString("yyyy-MM-dd")); // Formata a data

                    try
                    {
                        connection.Open();

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Data comemorativa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma data comemorativa cadastrada. Verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar data comemorativa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Função para verificar se o valor promocional existe
        private bool ValorPromocionalExists(int valorPromocionalId, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM valores_diarias WHERE id = @valorPromocionalId";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@valorPromocionalId", valorPromocionalId);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeDataComemorativo.Text = "";
            txtPromocao.Text = "";
            txtDiaComemorativo.Text = "";
            txtMesComemorativo.Text = "";
            txtAnoComemorativo.Text = "";
        }
    }
}
