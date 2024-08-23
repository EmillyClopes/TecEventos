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
    { //ConexaoBanco conexaoBanco;
        public AdicionarChacara()
        {
            InitializeComponent();
            //conexaoBanco = new ConexaoBanco();
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
            string queryValorDiaria = "SELECT valor FROM ValorDiaria WHERE " +
                "(SELECT valor_diaria_id, id FROM Chacara JOIN ValorDiaria ON id.ValorDiaria = valor_diaria_id.Chacara)";
            string enderecoRua = txtRua.Text;
            string enderecoNum = txtNumChacara.Text;
            string bairro = txtBairro.Text;
            string regras = txtRegras.Text;
            string descricao = txtDescricao.Text;

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(queryValorDiaria, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
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
            }


            string query = "INSERT INTO Chacara(nome, valor_diaria_id, endereco_rua, endereco_numero, endereco_bairro, regras_politicas, descricao) VALUES" +
                "(" + nomeChacara + queryValorDiaria + enderecoRua + enderecoNum + bairro + regras + descricao + ")";
        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }
    }
}
