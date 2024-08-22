using System;
using System.Windows.Forms;

namespace TecEventos
{
    public class AbrirForms
    {
        private Form formAtivo = null;
        private Panel painel;

        public AbrirForms(Panel painel)
        {
            this.painel = painel;
        }

        public void AbreForm(Form novoForm)
        {
            if (formAtivo != null) formAtivo.Close();
            formAtivo = novoForm;
            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;
            painel.Controls.Add(novoForm);
            painel.Tag = novoForm;
            novoForm.BringToFront();
            novoForm.Show();
        }
    }
}
