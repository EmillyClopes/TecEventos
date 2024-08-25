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
    public partial class Login : Form
    {
        ConexaoBanco conexaoBanco;
        public Login()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void TextBox2(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        { // Defina a consulta SQL para verificar o login
            string query = @"
                SELECT a.usuario_id 
                FROM Adm a
                JOIN usuarios u ON a.usuario_id = u.id
                WHERE u.email = @username AND a.senha = @password";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open(); // Abre a conexão com o banco de dados

                    MySqlCommand command = new MySqlCommand(query, connection);
                    // Adiciona os valores dos parâmetros corretamente
                    command.Parameters.AddWithValue("@username", textBox1.Text); // Email
                    command.Parameters.AddWithValue("@password", textBox2.Text); // Senha

                    object result = command.ExecuteScalar(); // Executa a consulta e retorna o primeiro valor

                    if (result != null)
                    {
                        // Login correto, obtém o usuario_id
                        int usuarioId = Convert.ToInt32(result);

                        // Registrar o login na tabela LoginRegistro
                        RegistrarLogin(usuarioId);

                        // Abre o formulário Home
                        Home homeForm = new Home();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Exibe uma mensagem de erro se o login falhar
                        MessageBox.Show("Email ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Limpa os campos de senha e foca no campo de email
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistrarLogin(int usuarioId)
        {
            // Consulta SQL para inserir o registro de login
            string query = "INSERT INTO LoginRegistro (usuario_id, login_datetime) VALUES (@usuarioId, @loginDateTime)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@loginDateTime", DateTime.Now); // Define o timestamp do login

                    command.ExecuteNonQuery(); // Executa a inserção
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar o login: " + ex.Message, "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
                private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperar a senha, entre em contato com o administrador.", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

   
}
