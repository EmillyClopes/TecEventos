namespace TecEventos
{
    partial class Disponibilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disponibilidade));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblDatasdiponiveiseIndiponiveis = new System.Windows.Forms.Label();
            this.lblChacarasDisponiveis = new System.Windows.Forms.Label();
            this.GridViewChacarasDisponiveis = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasDisponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1848, 849);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.lblDatasdiponiveiseIndiponiveis);
            this.panel1.Controls.Add(this.lblChacarasDisponiveis);
            this.panel1.Controls.Add(this.GridViewChacarasDisponiveis);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(196, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.MaximumSize = new System.Drawing.Size(1583, 715);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 685);
            this.panel1.TabIndex = 79;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Azure;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(1352, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 31);
            this.btnHome.TabIndex = 154;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblDatasdiponiveiseIndiponiveis
            // 
            this.lblDatasdiponiveiseIndiponiveis.AutoSize = true;
            this.lblDatasdiponiveiseIndiponiveis.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasdiponiveiseIndiponiveis.Location = new System.Drawing.Point(1029, 138);
            this.lblDatasdiponiveiseIndiponiveis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatasdiponiveiseIndiponiveis.Name = "lblDatasdiponiveiseIndiponiveis";
            this.lblDatasdiponiveiseIndiponiveis.Size = new System.Drawing.Size(69, 29);
            this.lblDatasdiponiveiseIndiponiveis.TabIndex = 131;
            this.lblDatasdiponiveiseIndiponiveis.Text = "Datas";
            // 
            // lblChacarasDisponiveis
            // 
            this.lblChacarasDisponiveis.AutoSize = true;
            this.lblChacarasDisponiveis.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChacarasDisponiveis.Location = new System.Drawing.Point(27, 25);
            this.lblChacarasDisponiveis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChacarasDisponiveis.Name = "lblChacarasDisponiveis";
            this.lblChacarasDisponiveis.Size = new System.Drawing.Size(220, 29);
            this.lblChacarasDisponiveis.TabIndex = 129;
            this.lblChacarasDisponiveis.Text = "Chácaras Disponíveis";
            // 
            // GridViewChacarasDisponiveis
            // 
            this.GridViewChacarasDisponiveis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewChacarasDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChacarasDisponiveis.Location = new System.Drawing.Point(32, 69);
            this.GridViewChacarasDisponiveis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridViewChacarasDisponiveis.Name = "GridViewChacarasDisponiveis";
            this.GridViewChacarasDisponiveis.RowHeadersWidth = 51;
            this.GridViewChacarasDisponiveis.Size = new System.Drawing.Size(861, 599);
            this.GridViewChacarasDisponiveis.TabIndex = 125;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1035, 177);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 134;
            // 
            // Disponibilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 849);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Disponibilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disponibilidade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasDisponiveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatasdiponiveiseIndiponiveis;
        private System.Windows.Forms.Label lblChacarasDisponiveis;
        private System.Windows.Forms.DataGridView GridViewChacarasDisponiveis;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}