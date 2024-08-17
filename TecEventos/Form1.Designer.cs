namespace TecEventos
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Nave = new System.Windows.Forms.Panel();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnHome = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.SubMenuUsuario = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnChacaras = new System.Windows.Forms.Button();
            this.SubMenuChacaras = new System.Windows.Forms.Panel();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LogoTxt = new System.Windows.Forms.PictureBox();
            this.PanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SubMenuUsuario.SuspendLayout();
            this.SubMenuChacaras.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // Nave
            // 
            this.Nave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Nave.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nave.Location = new System.Drawing.Point(188, 0);
            this.Nave.Margin = new System.Windows.Forms.Padding(2);
            this.Nave.Name = "Nave";
            this.Nave.Size = new System.Drawing.Size(1716, 81);
            this.Nave.TabIndex = 5;
            // 
            // PanelHome
            // 
            this.PanelHome.AutoScroll = true;
            this.PanelHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelHome.Controls.Add(this.pictureBox1);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(188, 0);
            this.PanelHome.Margin = new System.Windows.Forms.Padding(2);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(1716, 1041);
            this.PanelHome.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1319, 733);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.Location = new System.Drawing.Point(0, 81);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(188, 36);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // Menu
            // 
            this.Menu.AutoScroll = true;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Menu.Controls.Add(this.BtnHome);
            this.Menu.Controls.Add(this.SubMenuUsuario);
            this.Menu.Controls.Add(this.BtnUsuario);
            this.Menu.Controls.Add(this.BtnChacaras);
            this.Menu.Controls.Add(this.SubMenuChacaras);
            this.Menu.Controls.Add(this.PanelLogo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(188, 1041);
            this.Menu.TabIndex = 3;
            // 
            // SubMenuUsuario
            // 
            this.SubMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuUsuario.Controls.Add(this.BtnSair);
            this.SubMenuUsuario.Controls.Add(this.BtnPerfil);
            this.SubMenuUsuario.Location = new System.Drawing.Point(0, 337);
            this.SubMenuUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.SubMenuUsuario.Name = "SubMenuUsuario";
            this.SubMenuUsuario.Size = new System.Drawing.Size(188, 73);
            this.SubMenuUsuario.TabIndex = 4;
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSair.Location = new System.Drawing.Point(0, 32);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(188, 32);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.FlatAppearance.BorderSize = 0;
            this.BtnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnPerfil.Location = new System.Drawing.Point(0, 0);
            this.BtnPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnPerfil.Size = new System.Drawing.Size(188, 32);
            this.BtnPerfil.TabIndex = 0;
            this.BtnPerfil.Text = "Perfil";
            this.BtnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPerfil.UseVisualStyleBackColor = true;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUsuario.Location = new System.Drawing.Point(0, 301);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnUsuario.Size = new System.Drawing.Size(188, 36);
            this.BtnUsuario.TabIndex = 3;
            this.BtnUsuario.Text = "Usuário";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnChacaras
            // 
            this.BtnChacaras.FlatAppearance.BorderSize = 0;
            this.BtnChacaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChacaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChacaras.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnChacaras.Location = new System.Drawing.Point(0, 120);
            this.BtnChacaras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChacaras.Name = "BtnChacaras";
            this.BtnChacaras.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnChacaras.Size = new System.Drawing.Size(188, 36);
            this.BtnChacaras.TabIndex = 1;
            this.BtnChacaras.Text = "Chácaras";
            this.BtnChacaras.UseVisualStyleBackColor = true;
            // 
            // SubMenuChacaras
            // 
            this.SubMenuChacaras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuChacaras.Controls.Add(this.BtnAtualizar);
            this.SubMenuChacaras.Controls.Add(this.BtnExcluir);
            this.SubMenuChacaras.Controls.Add(this.BtnAdicionar);
            this.SubMenuChacaras.Controls.Add(this.BtnProcurar);
            this.SubMenuChacaras.Location = new System.Drawing.Point(0, 160);
            this.SubMenuChacaras.Margin = new System.Windows.Forms.Padding(2);
            this.SubMenuChacaras.Name = "SubMenuChacaras";
            this.SubMenuChacaras.Size = new System.Drawing.Size(188, 141);
            this.SubMenuChacaras.TabIndex = 2;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAtualizar.Location = new System.Drawing.Point(0, 96);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnAtualizar.Size = new System.Drawing.Size(188, 32);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnExcluir.Location = new System.Drawing.Point(0, 64);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnExcluir.Size = new System.Drawing.Size(188, 32);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.FlatAppearance.BorderSize = 0;
            this.BtnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAdicionar.Location = new System.Drawing.Point(0, 32);
            this.BtnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnAdicionar.Size = new System.Drawing.Size(188, 32);
            this.BtnAdicionar.TabIndex = 1;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.FlatAppearance.BorderSize = 0;
            this.BtnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcurar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProcurar.Location = new System.Drawing.Point(0, 0);
            this.BtnProcurar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnProcurar.Size = new System.Drawing.Size(188, 32);
            this.BtnProcurar.TabIndex = 0;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcurar.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.LogoTxt);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(188, 81);
            this.PanelLogo.TabIndex = 0;
            // 
            // LogoTxt
            // 
            this.LogoTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoTxt.Image = ((System.Drawing.Image)(resources.GetObject("LogoTxt.Image")));
            this.LogoTxt.Location = new System.Drawing.Point(0, 0);
            this.LogoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LogoTxt.Name = "LogoTxt";
            this.LogoTxt.Size = new System.Drawing.Size(188, 79);
            this.LogoTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoTxt.TabIndex = 0;
            this.LogoTxt.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Nave);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "TecEventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.SubMenuUsuario.ResumeLayout(false);
            this.SubMenuChacaras.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Nave;
        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel SubMenuUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnPerfil;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Panel SubMenuChacaras;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.Button BtnChacaras;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox LogoTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnHome;
    }
}

