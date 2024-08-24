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
    public partial class AdicionarChacara : Form
    {
        ConexaoBanco conexaoBanco;
        public AdicionarChacara()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
        }

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

       private void btnCadastrarChacara_Click(object sender, EventArgs e)
       {
            string nomeChacara = txtNomeChacara.Text;
            /*string queryValorDiaria = "SELECT valor FROM ValorDiaria WHERE " +
                "(SELECT valor_diaria_id, id FROM Chacara JOIN valores_diarias ON id.valores_diarias = valor_diaria_id.Chacara)";*/
            double valorDiaria = double.Parse(txtValor.Text);
            string enderecoRua = txtRua.Text;
            string enderecoNum = txtNumChacara.Text;
            string bairro = txtBairro.Text;
            string regras = txtRegras.Text;
            string descricao = txtDescricao.Text;

            /*using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand commandValorDiaria = new MySqlCommand(queryValorDiaria, connection);
                    using (MySqlDataReader reader = commandValorDiaria.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var valor = reader["valor"];
                                Console.WriteLine(valor);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valor não encontrado.", "Valor não encontrado no banco de dados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/


            string query = "INSERT INTO Chacara(nome, valor_diaria, endereco_rua, endereco_numero, endereco_bairro, regras_politicas, descricao) VALUES" +
                "(@nome, @valor_diaria, @endereco_rua, @endereco_numero, @endereco_bairro, @regras_politicas, @descricao)";
            MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString());

            using(MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@nome", nomeChacara);
                    command.Parameters.AddWithValue("@valor_diaria", valorDiaria);
                    command.Parameters.AddWithValue("@endereco_rua", enderecoRua);
                    command.Parameters.AddWithValue("@endereco_numero", enderecoNum);
                    command.Parameters.AddWithValue("@endereco_bairro", bairro);
                    command.Parameters.AddWithValue("@regras_politicas", regras);
                    command.Parameters.AddWithValue("@descricao", descricao);

                    connection.Open();

                    int linhasAfetadas = command.ExecuteNonQuery();
                    if(linhasAfetadas > 0)
                    {
                        MessageBox.Show("Chácara cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma linha afetada. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar a chácara: " + ex.Message, "Conexão com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
            }
        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }
    }
}
