namespace TecEventos
{
    partial class Agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.lblAgendamento = new System.Windows.Forms.Label();
            this.GridViewAgendamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1848, 837);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnExluir);
            this.panel1.Controls.Add(this.lblAgendamento);
            this.panel1.Controls.Add(this.GridViewAgendamentos);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(213, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 685);
            this.panel1.TabIndex = 80;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Azure;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(1269, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 31);
            this.btnHome.TabIndex = 155;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtualizar.Location = new System.Drawing.Point(1137, 608);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(164, 48);
            this.btnAtualizar.TabIndex = 131;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExluir
            // 
            this.btnExluir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExluir.Location = new System.Drawing.Point(1137, 516);
            this.btnExluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(164, 48);
            this.btnExluir.TabIndex = 130;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = false;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // lblAgendamento
            // 
            this.lblAgendamento.AutoSize = true;
            this.lblAgendamento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamento.Location = new System.Drawing.Point(27, 25);
            this.lblAgendamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgendamento.Name = "lblAgendamento";
            this.lblAgendamento.Size = new System.Drawing.Size(162, 29);
            this.lblAgendamento.TabIndex = 129;
            this.lblAgendamento.Text = "Agendamentos";
            // 
            // GridViewAgendamentos
            // 
            this.GridViewAgendamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAgendamentos.Location = new System.Drawing.Point(32, 57);
            this.GridViewAgendamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridViewAgendamentos.Name = "GridViewAgendamentos";
            this.GridViewAgendamentos.RowHeadersWidth = 51;
            this.GridViewAgendamentos.Size = new System.Drawing.Size(1072, 599);
            this.GridViewAgendamentos.TabIndex = 125;
            this.GridViewAgendamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAgendamentos_CellContentClick);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAgendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.DataGridView GridViewAgendamentos;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnHome;
    }
}