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
            this.Menu = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatasComemorativas = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnPerfilAdm = new System.Windows.Forms.Button();
            this.SubMenuUsuario = new System.Windows.Forms.Panel();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnChacaras = new System.Windows.Forms.Button();
            this.SubMenuChacaras = new System.Windows.Forms.Panel();
            this.btnDisponibilidade = new System.Windows.Forms.Button();
            this.BtnAgendar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LogoTxt = new System.Windows.Forms.PictureBox();
            this.PanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.Nave.Location = new System.Drawing.Point(193, 0);
            this.Nave.Margin = new System.Windows.Forms.Padding(2);
            this.Nave.Name = "Nave";
            this.Nave.Size = new System.Drawing.Size(1727, 81);
            this.Nave.TabIndex = 5;
            // 
            // PanelHome
            // 
            this.PanelHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelHome.Controls.Add(this.pictureBox1);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(193, 0);
            this.PanelHome.Margin = new System.Windows.Forms.Padding(2);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(1727, 1080);
            this.PanelHome.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1335, 772);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1335, 772);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Menu.Controls.Add(this.BtnSair);
            this.Menu.Controls.Add(this.btnAdm);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.SubMenuUsuario);
            this.Menu.Controls.Add(this.BtnUsuario);
            this.Menu.Controls.Add(this.BtnChacaras);
            this.Menu.Controls.Add(this.SubMenuChacaras);
            this.Menu.Controls.Add(this.PanelLogo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(193, 1080);
            this.Menu.TabIndex = 3;
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSair.Location = new System.Drawing.Point(0, 1048);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(193, 32);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdm.Location = new System.Drawing.Point(1, 396);
            this.btnAdm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAdm.Size = new System.Drawing.Size(188, 36);
            this.btnAdm.TabIndex = 15;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnDatasComemorativas);
            this.panel1.Controls.Add(this.btnPagamentos);
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.btnPerfilAdm);
            this.panel1.Location = new System.Drawing.Point(3, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 150);
            this.panel1.TabIndex = 14;
            // 
            // btnDatasComemorativas
            // 
            this.btnDatasComemorativas.FlatAppearance.BorderSize = 0;
            this.btnDatasComemorativas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDatasComemorativas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDatasComemorativas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatasComemorativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatasComemorativas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDatasComemorativas.Location = new System.Drawing.Point(0, 108);
            this.btnDatasComemorativas.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatasComemorativas.Name = "btnDatasComemorativas";
            this.btnDatasComemorativas.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnDatasComemorativas.Size = new System.Drawing.Size(188, 32);
            this.btnDatasComemorativas.TabIndex = 5;
            this.btnDatasComemorativas.Text = "Datas Comemorativas";
            this.btnDatasComemorativas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatasComemorativas.UseVisualStyleBackColor = true;
            this.btnDatasComemorativas.Click += new System.EventHandler(this.btnDatasComemorativas_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.FlatAppearance.BorderSize = 0;
            this.btnPagamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPagamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagamentos.Location = new System.Drawing.Point(-2, 72);
            this.btnPagamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnPagamentos.Size = new System.Drawing.Size(188, 32);
            this.btnPagamentos.TabIndex = 4;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCadastrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(1, 36);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCadastrarCliente.Size = new System.Drawing.Size(188, 32);
            this.btnCadastrarCliente.TabIndex = 3;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnPerfilAdm
            // 
            this.btnPerfilAdm.FlatAppearance.BorderSize = 0;
            this.btnPerfilAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPerfilAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPerfilAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilAdm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerfilAdm.Location = new System.Drawing.Point(0, 0);
            this.btnPerfilAdm.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerfilAdm.Name = "btnPerfilAdm";
            this.btnPerfilAdm.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnPerfilAdm.Size = new System.Drawing.Size(188, 32);
            this.btnPerfilAdm.TabIndex = 0;
            this.btnPerfilAdm.Text = "Perfil";
            this.btnPerfilAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilAdm.UseVisualStyleBackColor = true;
            this.btnPerfilAdm.Click += new System.EventHandler(this.btnPerfilAdm_Click);
            // 
            // SubMenuUsuario
            // 
            this.SubMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuUsuario.Controls.Add(this.btnAgendamentos);
            this.SubMenuUsuario.Controls.Add(this.BtnPerfil);
            this.SubMenuUsuario.Location = new System.Drawing.Point(3, 312);
            this.SubMenuUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.SubMenuUsuario.Name = "SubMenuUsuario";
            this.SubMenuUsuario.Size = new System.Drawing.Size(191, 80);
            this.SubMenuUsuario.TabIndex = 9;
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.FlatAppearance.BorderSize = 0;
            this.btnAgendamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgendamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgendamentos.Location = new System.Drawing.Point(-1, 36);
            this.btnAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnAgendamentos.Size = new System.Drawing.Size(188, 32);
            this.btnAgendamentos.TabIndex = 1;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
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
            this.BtnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUsuario.Location = new System.Drawing.Point(3, 276);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnUsuario.Size = new System.Drawing.Size(188, 36);
            this.BtnUsuario.TabIndex = 8;
            this.BtnUsuario.Text = "Usuário";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnChacaras
            // 
            this.BtnChacaras.FlatAppearance.BorderSize = 0;
            this.BtnChacaras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnChacaras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnChacaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChacaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChacaras.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnChacaras.Location = new System.Drawing.Point(3, 84);
            this.BtnChacaras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChacaras.Name = "BtnChacaras";
            this.BtnChacaras.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnChacaras.Size = new System.Drawing.Size(188, 36);
            this.BtnChacaras.TabIndex = 6;
            this.BtnChacaras.Text = "Chácaras";
            this.BtnChacaras.UseVisualStyleBackColor = true;
            // 
            // SubMenuChacaras
            // 
            this.SubMenuChacaras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuChacaras.Controls.Add(this.btnDisponibilidade);
            this.SubMenuChacaras.Controls.Add(this.BtnAgendar);
            this.SubMenuChacaras.Controls.Add(this.BtnAdicionar);
            this.SubMenuChacaras.Controls.Add(this.BtnProcurar);
            this.SubMenuChacaras.Location = new System.Drawing.Point(3, 124);
            this.SubMenuChacaras.Margin = new System.Windows.Forms.Padding(2);
            this.SubMenuChacaras.Name = "SubMenuChacaras";
            this.SubMenuChacaras.Size = new System.Drawing.Size(191, 148);
            this.SubMenuChacaras.TabIndex = 7;
            // 
            // btnDisponibilidade
            // 
            this.btnDisponibilidade.FlatAppearance.BorderSize = 0;
            this.btnDisponibilidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDisponibilidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDisponibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidade.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDisponibilidade.Location = new System.Drawing.Point(-1, 100);
            this.btnDisponibilidade.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisponibilidade.Name = "btnDisponibilidade";
            this.btnDisponibilidade.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnDisponibilidade.Size = new System.Drawing.Size(188, 32);
            this.btnDisponibilidade.TabIndex = 3;
            this.btnDisponibilidade.Text = "Disponibilidade";
            this.btnDisponibilidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibilidade.UseVisualStyleBackColor = true;
            this.btnDisponibilidade.Click += new System.EventHandler(this.btnDisponibilidade_Click);
            // 
            // BtnAgendar
            // 
            this.BtnAgendar.FlatAppearance.BorderSize = 0;
            this.BtnAgendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAgendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAgendar.Location = new System.Drawing.Point(0, 64);
            this.BtnAgendar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgendar.Name = "BtnAgendar";
            this.BtnAgendar.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.BtnAgendar.Size = new System.Drawing.Size(188, 32);
            this.BtnAgendar.TabIndex = 2;
            this.BtnAgendar.Text = "Agendar";
            this.BtnAgendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgendar.UseVisualStyleBackColor = true;
            this.BtnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
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
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.LogoTxt);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(193, 81);
            this.PanelLogo.TabIndex = 0;
            // 
            // LogoTxt
            // 
            this.LogoTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoTxt.Image = ((System.Drawing.Image)(resources.GetObject("LogoTxt.Image")));
            this.LogoTxt.Location = new System.Drawing.Point(0, 0);
            this.LogoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LogoTxt.Name = "LogoTxt";
            this.LogoTxt.Size = new System.Drawing.Size(193, 81);
            this.LogoTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoTxt.TabIndex = 0;
            this.LogoTxt.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Nave);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecEventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox LogoTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SubMenuUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnPerfil;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnChacaras;
        private System.Windows.Forms.Panel SubMenuChacaras;
        private System.Windows.Forms.Button BtnAgendar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnPerfilAdm;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnDatasComemorativas;
        private System.Windows.Forms.Button btnDisponibilidade;
    }
}

