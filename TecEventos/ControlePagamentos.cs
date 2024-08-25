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
    public partial class ControlePagamentos : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetControlePagamentos pagamento;
        public ControlePagamentos()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            pagamento = new GetSetControlePagamentos();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento) VALUES" +
                "(SELECT id FROM usuarios WHERE nome = @nomeUsuario" +
                "SELECT id FROM chacara WHERE nome = @nomeChacara" +
                "(SELECT id FROM agendamento WHERE entrada_data = @entrada_data AND usuario_id = (SELECT id FROM usuarios WHERE nome = @nomeUsuario)," +
                "@valor_pago, @data_pagamento, @metodo_pagamento, status_pagamento)";

            using(MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    pagamento.setInfoPagamento(NomeClienteTxt.Text, int.Parse(NomeChacTxt.Text), double.Parse(ValorTotalTxt.Text), double.Parse(ValorPagoTxt.Text), int.Parse(TxtDia.Text), int.Parse(TxtMes.Text), int.Parse(TxtAno.Text), MetodoPag.ToString(), StatusPag.ToString());
                    DateTime data = new DateTime(pagamento.getAno(), pagamento.getMes(), pagamento.getAno());
                    DateTime dataPagamento = new DateTime(pagamento.getAno(), pagamento.getMes(), pagamento.getAno());
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nomeUsuario", pagamento.getNomeCliente());
                    command.Parameters.AddWithValue("@nomeChacara", pagamento.getChacaraID());
                    command.Parameters.AddWithValue("@entrada_data", data);
                    command.Parameters.AddWithValue("@valor_pago", pagamento.getValorPago());
                    command.Parameters.AddWithValue("@data_pagamaneto", dataPagamento);
                    command.Parameters.AddWithValue("@metodo_pagamento", pagamento.getMetodoPagamento());
                    command.Parameters.AddWithValue("@status_pagamento", pagamento.getStatusPagamento());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao inserir os dados!" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
