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
        public Login()
        {
            InitializeComponent();
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
        {
            // Configure a string de conexão com as informações corretas
            string connectionString = "server=localhost;database=TecEventos;uid=root;pwd=9614206Gil@;"; // ALTERE A SENHA CASO NECESSÁRIO

            // Defina a consulta SQL com parâmetros
            string query = "SELECT * FROM Usuario WHERE email = @username AND senha = @password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre a conexão com o banco de dados

                    MySqlCommand command = new MySqlCommand(query, connection);
                    // Adiciona os valores dos parâmetros corretamente
                    command.Parameters.AddWithValue("@username", textBox1.Text); // Nome de usuário
                    command.Parameters.AddWithValue("@password", textBox2.Text); // Senha

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Login correto, abre o formulário Home
                        Home homeForm = new Home();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Exibe uma mensagem de erro se o login falhar
                        MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Limpa os campos de senha e foca no campo de usuário
                        textBox2.Clear();
                        textBox1.Focus();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperar a senha, entre em contato com o administrador.", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

   
}
