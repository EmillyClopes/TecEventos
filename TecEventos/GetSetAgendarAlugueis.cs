using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetAgendarAlugueis
    {
        private int diaEntrada;
        private int mesEntrada;
        private int anoEntrada;
        private int diaSaida;
        private int mesSaida;
        private int anoSaida;
        private string nomeCliente;
        private string contatoCliente;
        private double valorTotal;

        public GetSetAgendarAlugueis()
        {
            diaEntrada = 0;
            mesEntrada = 0;
            anoEntrada = 0;
            diaSaida = 0;
            mesSaida = 0;
            anoSaida = 0;
            nomeCliente = "";
            contatoCliente = "";
            valorTotal = 0.0;
        }
        public void setDiaMesAno(int diaEntrada, int mesEntrada, int anoEntrada, int diaSaida, int mesSaida, int anoSaida)
        {
            this.diaEntrada = diaEntrada;
            this.mesEntrada = mesEntrada;
            this.anoEntrada = anoEntrada;
            this.diaSaida = diaSaida;
            this.mesSaida = diaSaida;
            this.anoSaida = anoSaida;
        }
        public void setInfoCliente(string nomeCliente, string contatoCliente)
        {
            this.nomeCliente = nomeCliente;
            this.contatoCliente = contatoCliente;
        }
        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }
        public int getDiaEntrada()
        {
            return diaEntrada;
        }
        public int getMesEntrada()
        {
            return mesEntrada;
        }
        public int getAnoEntrada()
        {
            return anoEntrada;
        }
        public int getDiaSaida()
        {
            return diaSaida;
        }
        public int getMesSaida()
        {
            return mesSaida;
        }
        public int getAnoSaida()
        {
            return anoSaida;
        }
        public string getNomeCliente()
        {
            return nomeCliente;
        }
        public string getContatoCliente()
        {
            return contatoCliente;
        }
        public double getValorTotal()
        {
            return valorTotal;
        }
    }
}
