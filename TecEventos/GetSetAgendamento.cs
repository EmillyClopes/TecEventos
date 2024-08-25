using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetAgendamento
    {
        private string entrada_data;
        private string saida_data;
        private int usuario_id;
        private int chacara_id;
        private double valor_agendamento;
        private enum status
        {
            Confirmada,
            Pendente,
            Cancelada,
        }
        public GetSetAgendamento()
        {
            entrada_data = "";
            saida_data = "";
            usuario_id = 0;
            chacara_id = 0;
            valor_agendamento = 0.0;
        }
        public void setInfoAgendamento(string entrada_data, string saida_data, int usuario_id, int chacara_id, double valor_agendamento)
        {
            this.entrada_data = entrada_data;
            this.saida_data = saida_data;
            this.usuario_id = usuario_id;
            this.chacara_id = chacara_id;
            this.valor_agendamento = valor_agendamento;
        }
        public string getEntradaData()
        {
            return entrada_data;
        }
        public string getSaidaData()
        {
            return saida_data;
        }
        public int getUsuarioID()
        {
            return usuario_id;
        }
        public int getChacaraID()
        {
            return chacara_id;
        }
        public double getValorAgendamento()
        {
            return valor_agendamento;
        }

    }
}
