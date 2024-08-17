using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CS0108.cs
// compile with: /W:2
using System;

namespace TecEventos
{
    public partial class AgendarAlugueis : Form
    {
        public AgendarAlugueis()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /*Encerra o programa*/
        }

   
    }
}
