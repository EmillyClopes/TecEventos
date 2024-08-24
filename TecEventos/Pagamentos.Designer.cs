namespace TecEventos
{
    partial class Pagamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCriarPag = new System.Windows.Forms.Button();
            this.btnVisuPag = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVisuPag);
            this.panel1.Controls.Add(this.BtnCriarPag);
            this.panel1.Location = new System.Drawing.Point(613, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 588);
            this.panel1.TabIndex = 0;
            // 
            // BtnCriarPag
            // 
            this.BtnCriarPag.Location = new System.Drawing.Point(52, 50);
            this.BtnCriarPag.Name = "BtnCriarPag";
            this.BtnCriarPag.Size = new System.Drawing.Size(349, 120);
            this.BtnCriarPag.TabIndex = 0;
            this.BtnCriarPag.Text = "Criar novo pagamento";
            this.BtnCriarPag.UseVisualStyleBackColor = true;
            this.BtnCriarPag.Click += new System.EventHandler(this.BtnCriarPag_Click);
            // 
            // btnVisuPag
            // 
            this.btnVisuPag.Location = new System.Drawing.Point(52, 412);
            this.btnVisuPag.Name = "btnVisuPag";
            this.btnVisuPag.Size = new System.Drawing.Size(349, 120);
            this.btnVisuPag.TabIndex = 1;
            this.btnVisuPag.Text = "Visualizar pagamentos";
            this.btnVisuPag.UseVisualStyleBackColor = true;
            this.btnVisuPag.Click += new System.EventHandler(this.btnVisuPag_Click);
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 759);
            this.Controls.Add(this.panel1);
            this.Name = "Pagamentos";
            this.Text = "Pagamentos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisuPag;
        private System.Windows.Forms.Button BtnCriarPag;
    }
}