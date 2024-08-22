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
        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void NomeCompTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void EnderecoTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
        }

        private void TelefoneTxt_TextChanged(object sender, EventArgs e)
        {
            //Conectar com o banco
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
            // Configurar a string de conexão
            string connectionString = "server=localhost;database=TecEventos;uid=root;pwd=9614206Gil@;"; // Atualize a senha conforme necessário

            // Definir a consulta SQL para inserção
            string query = "INSERT INTO Usuario (nome_completo, email, endereco_rua, endereco_numero, endereco_bairro, telefone, senha) " +
                           "VALUES (@nome_completo, @email, @endereco_rua, @endereco_numero, @endereco_bairro, @telefone, @senha)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome_completo", NomeCompTxt.Text);
                    command.Parameters.AddWithValue("@email", EmailTxt.Text);
                    command.Parameters.AddWithValue("@endereco_rua", EnderecoRuaTxt.Text.Split(',')[0]); // Supondo que EnderecoTxt tenha o formato "Rua, Numero, Bairro"
                    command.Parameters.AddWithValue("@endereco_numero", EnderecoRuaTxt.Text.Split(',').Length > 1 ? EnderecoRuaTxt.Text.Split(',')[1] : "");
                    command.Parameters.AddWithValue("@endereco_bairro", EnderecoRuaTxt.Text.Split(',').Length > 2 ? EnderecoRuaTxt.Text.Split(',')[2] : "");
                    command.Parameters.AddWithValue("@telefone", TelefoneTxt.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após o cadastro
                    NomeCompTxt.Text = "";
                    EmailTxt.Text = "";
                    EnderecoRuaTxt.Text = "";
                    TelefoneTxt.Text = "";
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
