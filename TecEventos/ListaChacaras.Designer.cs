namespace TecEventos
{
    partial class ListaChacaras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaChacaras));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFoto = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblChacarasCadastradas = new System.Windows.Forms.Label();
            this.GridViewChacarasCadastradas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasCadastradas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1487, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFoto);
            this.panel1.Controls.Add(this.picFoto);
            this.panel1.Controls.Add(this.lblChacarasCadastradas);
            this.panel1.Controls.Add(this.GridViewChacarasCadastradas);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(129, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 577);
            this.panel1.TabIndex = 78;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(772, 112);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(45, 23);
            this.lblFoto.TabIndex = 131;
            this.lblFoto.Text = "Foto";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.picFoto.Location = new System.Drawing.Point(776, 152);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(324, 269);
            this.picFoto.TabIndex = 130;
            this.picFoto.TabStop = false;
            // 
            // lblChacarasCadastradas
            // 
            this.lblChacarasCadastradas.AutoSize = true;
            this.lblChacarasCadastradas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChacarasCadastradas.Location = new System.Drawing.Point(20, 20);
            this.lblChacarasCadastradas.Name = "lblChacarasCadastradas";
            this.lblChacarasCadastradas.Size = new System.Drawing.Size(179, 23);
            this.lblChacarasCadastradas.TabIndex = 129;
            this.lblChacarasCadastradas.Text = "Chácaras Cadastradas";
            // 
            // GridViewChacarasCadastradas
            // 
            this.GridViewChacarasCadastradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewChacarasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChacarasCadastradas.Location = new System.Drawing.Point(24, 56);
            this.GridViewChacarasCadastradas.Name = "GridViewChacarasCadastradas";
            this.GridViewChacarasCadastradas.RowHeadersWidth = 51;
            this.GridViewChacarasCadastradas.Size = new System.Drawing.Size(646, 487);
            this.GridViewChacarasCadastradas.TabIndex = 125;
            // 
            // ListaChacaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaChacaras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaChacaras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasCadastradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblChacarasCadastradas;
        private System.Windows.Forms.DataGridView GridViewChacarasCadastradas;
        private System.Windows.Forms.Label lblFoto;
    }
}