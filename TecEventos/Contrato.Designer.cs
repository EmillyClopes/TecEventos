namespace TecEventos
{
    partial class Contrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contrato));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVisu = new System.Windows.Forms.Button();
            this.BtnGerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1393, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnVisu);
            this.panel2.Controls.Add(this.BtnGerar);
            this.panel2.Location = new System.Drawing.Point(181, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 522);
            this.panel2.TabIndex = 3;
            // 
            // btnVisu
            // 
            this.btnVisu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVisu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVisu.Location = new System.Drawing.Point(377, 321);
            this.btnVisu.Name = "btnVisu";
            this.btnVisu.Size = new System.Drawing.Size(262, 79);
            this.btnVisu.TabIndex = 73;
            this.btnVisu.Text = "Visualizar contratos";
            this.btnVisu.UseVisualStyleBackColor = false;
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGerar.Location = new System.Drawing.Point(377, 138);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(262, 79);
            this.BtnGerar.TabIndex = 72;
            this.BtnGerar.Text = "Gerar contrato";
            this.BtnGerar.UseVisualStyleBackColor = false;
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contrato";
            this.Text = "Contrato";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVisu;
        private System.Windows.Forms.Button BtnGerar;
    }
}