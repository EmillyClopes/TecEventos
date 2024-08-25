using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetChacara
    {
        private string nome;
        private string rua;
        private string bairro;
        private string numero;
        private string telefone;
        private string regras;
        private string politicas;
        private string valorDiaria;

        public GetSetChacara()
        {
            nome = "";
            rua = "";
            bairro = "";
            numero = "";
            telefone = "";
            regras = "";
            politicas = "";
            valorDiaria = "";
        }
        public void setInfoChacara(string nome, string rua, string bairro, string numero, string telefone, string regras, string politicas, string valorDiaria)
        {
            this.nome = nome;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.telefone = telefone;
            this.regras = regras;
            this.politicas = politicas;
            this.valorDiaria = valorDiaria;
        }
        public string getNome()
        {
            return nome;
        }
        public string getEndereco()
        {
            return rua;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getNumero()
        {
            return numero;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public string getRegras()
        {
            return regras;
        }
        public string getPoliticas()
        {
            return politicas;
        }
        public string getValorDiaria()
        {
            return valorDiaria;
        }
    }
}
