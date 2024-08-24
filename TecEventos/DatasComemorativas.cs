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
        public DatasComemorativas()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            data = new GetSetDatasComemorativas();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            data.setInfoDataComemorativa(txtNomeDataComemorativo.Text, txtDescricao.Text, txtPromocao.Text, txtPromocao.Text);
            data.setDiaMesAno(int.Parse(txtDiaComemorativo.Text), int.Parse(txtMesComemorativo.Text), int.Parse(txtAnoComemorativo.Text));

            string query = "INSERT INTO DatasComemorativas(nome_data, dia, mes, ano, descricao, promocoes, pacotes) VALUES" +
                "(@nome_data, @dia, @mes, @ano, @descricao, @promocoes, @pacotes)";

            using(MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome_data", data.getNomeDataComemorativa());
                    command.Parameters.AddWithValue("@dia", data.getDia());
                    command.Parameters.AddWithValue("@mes", data.getMes());
                    command.Parameters.AddWithValue("@ano", data.getAno());
                    command.Parameters.AddWithValue("@descricao", data.getDescricao());
                    command.Parameters.AddWithValue("@promocoes", data.getPromocoes());
                    command.Parameters.AddWithValue("@pacotes", data.getPacote());

                    connection.Open();

                    int linhasAfetadas = command.ExecuteNonQuery();

                    if(linhasAfetadas > 0)
                    {
                        MessageBox.Show("Data comemorativa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar data comemorativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
