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

namespace TecEventos
{
    public partial class CadastrarClientes : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetCadastrarCliente cliente;
        public CadastrarClientes()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            cliente = new GetSetCadastrarCliente();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            NomeCompTxt.Text = "";
            EmailTxt.Text = "";
            EnderecoRuaTxt.Text = "";
            TelefoneTxt.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cliente.setInfoCliente(NomeCompTxt.Text, EmailTxt.Text, EnderecoRuaTxt.Text, EnderecoBairroTxt.Text, EnderecoNumeroTxt.Text, TelefoneTxt.Text);

            // Definir a consulta SQL para inserção
            string query = "INSERT INTO Usuario (nome_completo, email, endereco_rua, endereco_numero, endereco_bairro, telefone) " +
                           "VALUES (@nome_completo, @email, @endereco_rua, @endereco_numero, @endereco_bairro, @telefone)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome_completo", cliente.getNome());
                    command.Parameters.AddWithValue("@email", cliente.getEmail());
                    command.Parameters.AddWithValue("@endereco_rua", cliente.getRua());
                    command.Parameters.AddWithValue("@endereco_numero", cliente.getNumero());
                    command.Parameters.AddWithValue("@endereco_bairro", cliente.getBairro());
                    command.Parameters.AddWithValue("@telefone", cliente.getTelefone());

                    connection.Open();

                    int LinhasAfetadas = command.ExecuteNonQuery();

                    if (LinhasAfetadas > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Limpar os campos após o cadastro
                    /*NomeCompTxt.Text = "";
                    EmailTxt.Text = "";
                    EnderecoRuaTxt.Text = "";
                    TelefoneTxt.Text = "";*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
