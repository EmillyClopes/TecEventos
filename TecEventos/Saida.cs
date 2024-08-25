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
    public partial class Saida : Form
    {
        private int usuarioId; // Armazena o ID do usuário que está saindo
        ConexaoBanco conexaoBanco;
        public Saida()
        {
            InitializeComponent();
            usuarioId = userId; // Inicializa o ID do usuário
            conexaoBanco = new ConexaoBanco();

        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            RegistrarLogout(usuarioId); // Registra o logout antes de fechar a aplicação
            this.DialogResult = DialogResult.Yes; // Retorna "Yes" para fechar a aplicação
            Application.Exit();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Retorna "Cancel" para cancelar a ação
            this.Close();
        }
        private void RegistrarLogout(int usuarioId)
        {
            // Consulta SQL para inserir o registro de logout
            string query = "INSERT INTO LogoutRegistro (usuario_id, logout_datetime) VALUES (@usuarioId, @logoutDateTime)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@logoutDateTime", DateTime.Now); // Define o timestamp do logout

                    command.ExecuteNonQuery(); // Executa a inserção
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar o logout: " + ex.Message, "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
