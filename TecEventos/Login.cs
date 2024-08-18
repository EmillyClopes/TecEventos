using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Usuário e senha padrão
            string username = "admin";
            string password = "admin";

            // Verifica se os campos correspondem ao usuário e senha corretos
            if (textBox1.Text == username && textBox2.Text == password)
            {
                // Se correto, abre o formulário Home
                Home homeForm = new Home();
                homeForm.Show();

                // Fecha o formulário de login
                this.Hide();
            }
            else
            {
                // Exibe uma mensagem de erro se o login falhar
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpa os campos de senha e foco no usuário
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
