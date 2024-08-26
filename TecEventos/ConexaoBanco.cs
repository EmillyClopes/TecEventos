using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class ConexaoBanco
    {
        private string connectionString;

        public ConexaoBanco()
        {
            connectionString = "server=localhost;database=teceventos;uid=root;pwd=9614206Gil@";
        }
        public string getConnectionString()
        {
            return connectionString;
        }
    }
}