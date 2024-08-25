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
        GetSetChacara chacara;
        public AdicionarChacara()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            chacara = new GetSetChacara();
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
            chacara.setInfoChacara(txtNomeChacara.Text, txtRua.Text, txtBairro.Text, txtNumChacara.Text, txtRegras.Text, txtRegras.Text, txtValor.Text, txtDescricao.Text);

            string query = "INSERT INTO chacara(nome, endereco_id, regras_id) VALUES" +
                "(@nome, @endereco_id, @regras_id)";
            string queryEnderecoID = "SELECT id FROM enderecos WHERE numero = @numero AND bairro = @bairro";
            string queryRegrasID = "SELECT id FROM regras WHERE descricao = @descricao";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    // Obter o ID do endereço
                    int enderecoId = 0; // Inicializa com um valor padrão
                    using (MySqlCommand commandEndereco = new MySqlCommand(queryEnderecoID, connection))
                    {
                        commandEndereco.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        commandEndereco.Parameters.AddWithValue("@numero", txtNumChacara.Text);

                        using (MySqlDataReader reader = commandEndereco.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                enderecoId = Convert.ToInt32(reader["id"]);
                            }
                        }
                    }

                    // Obter o ID das regras
                    int regrasId = 0; // Inicializa com um valor padrão
                    using (MySqlCommand commandRegras = new MySqlCommand(queryRegrasID, connection))
                    {
                        commandRegras.Parameters.AddWithValue("@descricao", txtRegras.Text);

                        using (MySqlDataReader reader = commandRegras.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                regrasId = Convert.ToInt32(reader["id"]); // Converte para inteiro
                            }
                        }
                    }

                    if (enderecoId == 0 || regrasId == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar o endereço ou as regras. Verifique os dados fornecidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Inserir a chácara
                    using (MySqlCommand commandInserir = new MySqlCommand(query, connection))
                    {
                        commandInserir.Parameters.AddWithValue("@nome", txtNomeChacara.Text);
                        commandInserir.Parameters.AddWithValue("@endereco_id", enderecoId);
                        commandInserir.Parameters.AddWithValue("@regras_id", regrasId);

                        int linhasAfetadas = commandInserir.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Chácara cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha afetada. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
