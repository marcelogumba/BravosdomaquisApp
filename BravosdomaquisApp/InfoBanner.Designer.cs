namespace BravosdomaquisApp
{
    partial class InfoBanner
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
            this.lblFecharInfoMembro = new System.Windows.Forms.Label();
            this.lblDescrTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelInfoConteudo = new Guna.UI.WinForms.GunaShadowPanel();
            this.checkAtivo = new Guna.UI.WinForms.GunaCheckBox();
            this.checkAddPrincipal = new Guna.UI.WinForms.GunaCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.linkLabelVerImagem = new System.Windows.Forms.LinkLabel();
            this.btnVerAnexo1 = new Guna.UI.WinForms.GunaButton();
            this.lblAnexo1 = new System.Windows.Forms.Label();
            this.txtAnexo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConteudo = new Guna.UI.WinForms.GunaTextBox();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.btnSalvarAlteraçoes = new Guna.UI.WinForms.GunaButton();
            this.lblDaTxtSMSDescricao = new System.Windows.Forms.Label();
            this.txtTituloConteudo = new Guna.UI.WinForms.GunaTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new Guna.UI.WinForms.GunaTextBox();
            this.cbxSelectURL = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTituloURL = new Guna.UI.WinForms.GunaTextBox();
            this.btnFecharInfoMembro = new Guna.UI.WinForms.GunaButton();
            this.panelInfoConteudo.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecharInfoMembro
            // 
            this.lblFecharInfoMembro.AutoSize = true;
            this.lblFecharInfoMembro.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lblFecharInfoMembro.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblFecharInfoMembro.Location = new System.Drawing.Point(825, 65);
            this.lblFecharInfoMembro.Name = "lblFecharInfoMembro";
            this.lblFecharInfoMembro.Size = new System.Drawing.Size(54, 15);
            this.lblFecharInfoMembro.TabIndex = 40;
            this.lblFecharInfoMembro.Text = "Cancelar";
            this.lblFecharInfoMembro.Visible = false;
            // 
            // lblDescrTitulo
            // 
            this.lblDescrTitulo.AutoSize = true;
            this.lblDescrTitulo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescrTitulo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrTitulo.Location = new System.Drawing.Point(37, 61);
            this.lblDescrTitulo.Name = "lblDescrTitulo";
            this.lblDescrTitulo.Size = new System.Drawing.Size(271, 16);
            this.lblDescrTitulo.TabIndex = 38;
            this.lblDescrTitulo.Text = "Confira abaixo as informações do conteúdo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(34, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(295, 33);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Detalhes do conteúdo";
            // 
            // panelInfoConteudo
            // 
            this.panelInfoConteudo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoConteudo.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelInfoConteudo.Controls.Add(this.checkAtivo);
            this.panelInfoConteudo.Controls.Add(this.checkAddPrincipal);
            this.panelInfoConteudo.Controls.Add(this.label5);
            this.panelInfoConteudo.Controls.Add(this.gunaLinePanel2);
            this.panelInfoConteudo.Controls.Add(this.label1);
            this.panelInfoConteudo.Controls.Add(this.txtConteudo);
            this.panelInfoConteudo.Controls.Add(this.btnCancelar);
            this.panelInfoConteudo.Controls.Add(this.btnSalvarAlteraçoes);
            this.panelInfoConteudo.Controls.Add(this.lblDaTxtSMSDescricao);
            this.panelInfoConteudo.Controls.Add(this.txtTituloConteudo);
            this.panelInfoConteudo.Controls.Add(this.label14);
            this.panelInfoConteudo.Controls.Add(this.gunaLinePanel3);
            this.panelInfoConteudo.Controls.Add(this.btnFecharInfoMembro);
            this.panelInfoConteudo.Controls.Add(this.lblFecharInfoMembro);
            this.panelInfoConteudo.Controls.Add(this.lblDescrTitulo);
            this.panelInfoConteudo.Controls.Add(this.lblTitulo);
            this.panelInfoConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelInfoConteudo.Name = "panelInfoConteudo";
            this.panelInfoConteudo.Radius = 10;
            this.panelInfoConteudo.ShadowColor = System.Drawing.Color.Black;
            this.panelInfoConteudo.ShadowShift = 0;
            this.panelInfoConteudo.Size = new System.Drawing.Size(502, 727);
            this.panelInfoConteudo.TabIndex = 40;
            // 
            // checkAtivo
            // 
            this.checkAtivo.BaseColor = System.Drawing.Color.White;
            this.checkAtivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkAtivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkAtivo.FillColor = System.Drawing.Color.White;
            this.checkAtivo.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.checkAtivo.Location = new System.Drawing.Point(354, 624);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(84, 24);
            this.checkAtivo.TabIndex = 96;
            this.checkAtivo.Text = "Activo";
            // 
            // checkAddPrincipal
            // 
            this.checkAddPrincipal.BaseColor = System.Drawing.Color.White;
            this.checkAddPrincipal.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkAddPrincipal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkAddPrincipal.FillColor = System.Drawing.Color.White;
            this.checkAddPrincipal.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAddPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.checkAddPrincipal.Location = new System.Drawing.Point(50, 624);
            this.checkAddPrincipal.Name = "checkAddPrincipal";
            this.checkAddPrincipal.Size = new System.Drawing.Size(242, 24);
            this.checkAddPrincipal.TabIndex = 95;
            this.checkAddPrincipal.Text = "Adicionar como principal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(48, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "Imagem de capa";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.linkLabelVerImagem);
            this.gunaLinePanel2.Controls.Add(this.btnVerAnexo1);
            this.gunaLinePanel2.Controls.Add(this.lblAnexo1);
            this.gunaLinePanel2.Controls.Add(this.txtAnexo1);
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.LineTop = 1;
            this.gunaLinePanel2.Location = new System.Drawing.Point(40, 366);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(421, 71);
            this.gunaLinePanel2.TabIndex = 85;
            // 
            // linkLabelVerImagem
            // 
            this.linkLabelVerImagem.AutoSize = true;
            this.linkLabelVerImagem.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabelVerImagem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(195)))));
            this.linkLabelVerImagem.Location = new System.Drawing.Point(289, 41);
            this.linkLabelVerImagem.Name = "linkLabelVerImagem";
            this.linkLabelVerImagem.Size = new System.Drawing.Size(99, 20);
            this.linkLabelVerImagem.TabIndex = 63;
            this.linkLabelVerImagem.TabStop = true;
            this.linkLabelVerImagem.Text = "Ver imagem";
            this.linkLabelVerImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnVerAnexo1
            // 
            this.btnVerAnexo1.AnimationHoverSpeed = 0.07F;
            this.btnVerAnexo1.AnimationSpeed = 0.03F;
            this.btnVerAnexo1.BackColor = System.Drawing.Color.Transparent;
            this.btnVerAnexo1.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnVerAnexo1.BorderColor = System.Drawing.Color.Black;
            this.btnVerAnexo1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerAnexo1.FocusedColor = System.Drawing.Color.Empty;
            this.btnVerAnexo1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAnexo1.ForeColor = System.Drawing.Color.White;
            this.btnVerAnexo1.Image = global::BravosdomaquisApp.Properties.Resources.DocUpload;
            this.btnVerAnexo1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerAnexo1.ImageSize = new System.Drawing.Size(24, 24);
            this.btnVerAnexo1.Location = new System.Drawing.Point(25, 15);
            this.btnVerAnexo1.Name = "btnVerAnexo1";
            this.btnVerAnexo1.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btnVerAnexo1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVerAnexo1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVerAnexo1.OnHoverImage = null;
            this.btnVerAnexo1.OnPressedColor = System.Drawing.Color.Black;
            this.btnVerAnexo1.Radius = 4;
            this.btnVerAnexo1.Size = new System.Drawing.Size(24, 24);
            this.btnVerAnexo1.TabIndex = 62;
            this.btnVerAnexo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnexo1
            // 
            this.lblAnexo1.AutoSize = true;
            this.lblAnexo1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnexo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblAnexo1.Location = new System.Drawing.Point(56, 17);
            this.lblAnexo1.Name = "lblAnexo1";
            this.lblAnexo1.Size = new System.Drawing.Size(76, 22);
            this.lblAnexo1.TabIndex = 57;
            this.lblAnexo1.Text = "Anexo 1:";
            // 
            // txtAnexo1
            // 
            this.txtAnexo1.AutoSize = true;
            this.txtAnexo1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAnexo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtAnexo1.Location = new System.Drawing.Point(132, 17);
            this.txtAnexo1.Name = "txtAnexo1";
            this.txtAnexo1.Size = new System.Drawing.Size(46, 22);
            this.txtAnexo1.TabIndex = 47;
            this.txtAnexo1.Text = "------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(55, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Conteúdo";
            // 
            // txtConteudo
            // 
            this.txtConteudo.BackColor = System.Drawing.Color.Transparent;
            this.txtConteudo.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtConteudo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtConteudo.BorderSize = 1;
            this.txtConteudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConteudo.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtConteudo.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtConteudo.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.txtConteudo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtConteudo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConteudo.Location = new System.Drawing.Point(40, 144);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.PasswordChar = '\0';
            this.txtConteudo.Radius = 8;
            this.txtConteudo.SelectedText = "";
            this.txtConteudo.Size = new System.Drawing.Size(421, 198);
            this.txtConteudo.TabIndex = 83;
            this.txtConteudo.TextOffsetX = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(290, 667);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 8;
            this.btnCancelar.Size = new System.Drawing.Size(171, 30);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvarAlteraçoes
            // 
            this.btnSalvarAlteraçoes.AnimationHoverSpeed = 0.07F;
            this.btnSalvarAlteraçoes.AnimationSpeed = 0.03F;
            this.btnSalvarAlteraçoes.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarAlteraçoes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnSalvarAlteraçoes.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarAlteraçoes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvarAlteraçoes.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalvarAlteraçoes.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteraçoes.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAlteraçoes.Image = null;
            this.btnSalvarAlteraçoes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalvarAlteraçoes.Location = new System.Drawing.Point(40, 667);
            this.btnSalvarAlteraçoes.Name = "btnSalvarAlteraçoes";
            this.btnSalvarAlteraçoes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnSalvarAlteraçoes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalvarAlteraçoes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalvarAlteraçoes.OnHoverImage = null;
            this.btnSalvarAlteraçoes.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalvarAlteraçoes.Radius = 8;
            this.btnSalvarAlteraçoes.Size = new System.Drawing.Size(244, 30);
            this.btnSalvarAlteraçoes.TabIndex = 79;
            this.btnSalvarAlteraçoes.Text = "Salvar alterações";
            this.btnSalvarAlteraçoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDaTxtSMSDescricao
            // 
            this.lblDaTxtSMSDescricao.AutoSize = true;
            this.lblDaTxtSMSDescricao.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDaTxtSMSDescricao.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDaTxtSMSDescricao.Location = new System.Drawing.Point(55, 89);
            this.lblDaTxtSMSDescricao.Name = "lblDaTxtSMSDescricao";
            this.lblDaTxtSMSDescricao.Size = new System.Drawing.Size(42, 16);
            this.lblDaTxtSMSDescricao.TabIndex = 65;
            this.lblDaTxtSMSDescricao.Text = "Título";
            // 
            // txtTituloConteudo
            // 
            this.txtTituloConteudo.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloConteudo.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtTituloConteudo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtTituloConteudo.BorderSize = 1;
            this.txtTituloConteudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTituloConteudo.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtTituloConteudo.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtTituloConteudo.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.txtTituloConteudo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtTituloConteudo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTituloConteudo.Location = new System.Drawing.Point(40, 100);
            this.txtTituloConteudo.Name = "txtTituloConteudo";
            this.txtTituloConteudo.PasswordChar = '\0';
            this.txtTituloConteudo.Radius = 8;
            this.txtTituloConteudo.SelectedText = "";
            this.txtTituloConteudo.Size = new System.Drawing.Size(421, 30);
            this.txtTituloConteudo.TabIndex = 62;
            this.txtTituloConteudo.TextOffsetX = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label14.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label14.Location = new System.Drawing.Point(50, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 78;
            this.label14.Text = "Hiperligação";
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Controls.Add(this.label3);
            this.gunaLinePanel3.Controls.Add(this.txtURL);
            this.gunaLinePanel3.Controls.Add(this.cbxSelectURL);
            this.gunaLinePanel3.Controls.Add(this.label2);
            this.gunaLinePanel3.Controls.Add(this.txtTituloURL);
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaLinePanel3.LineLeft = 1;
            this.gunaLinePanel3.LineRight = 1;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 1;
            this.gunaLinePanel3.Location = new System.Drawing.Point(40, 456);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(421, 151);
            this.gunaLinePanel3.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.Transparent;
            this.txtURL.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtURL.BorderSize = 1;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtURL.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtURL.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.txtURL.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtURL.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtURL.Location = new System.Drawing.Point(30, 108);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.Radius = 8;
            this.txtURL.SelectedText = "";
            this.txtURL.Size = new System.Drawing.Size(353, 30);
            this.txtURL.TabIndex = 69;
            this.txtURL.TextOffsetX = 6;
            // 
            // cbxSelectURL
            // 
            this.cbxSelectURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSelectURL.BackColor = System.Drawing.Color.Transparent;
            this.cbxSelectURL.BaseColor = System.Drawing.Color.Gainsboro;
            this.cbxSelectURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectURL.BorderSize = 1;
            this.cbxSelectURL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSelectURL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectURL.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSelectURL.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectURL.FormattingEnabled = true;
            this.cbxSelectURL.Items.AddRange(new object[] {
            "Selecione a URL",
            ".....",
            ".....",
            "...."});
            this.cbxSelectURL.Location = new System.Drawing.Point(30, 18);
            this.cbxSelectURL.Name = "cbxSelectURL";
            this.cbxSelectURL.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSelectURL.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSelectURL.Radius = 5;
            this.cbxSelectURL.Size = new System.Drawing.Size(353, 27);
            this.cbxSelectURL.StartIndex = 0;
            this.cbxSelectURL.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Título";
            // 
            // txtTituloURL
            // 
            this.txtTituloURL.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloURL.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtTituloURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtTituloURL.BorderSize = 1;
            this.txtTituloURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTituloURL.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtTituloURL.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtTituloURL.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.txtTituloURL.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtTituloURL.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTituloURL.Location = new System.Drawing.Point(30, 60);
            this.txtTituloURL.Name = "txtTituloURL";
            this.txtTituloURL.PasswordChar = '\0';
            this.txtTituloURL.Radius = 8;
            this.txtTituloURL.SelectedText = "";
            this.txtTituloURL.Size = new System.Drawing.Size(353, 30);
            this.txtTituloURL.TabIndex = 66;
            this.txtTituloURL.TextOffsetX = 6;
            // 
            // btnFecharInfoMembro
            // 
            this.btnFecharInfoMembro.AnimationHoverSpeed = 0.07F;
            this.btnFecharInfoMembro.AnimationSpeed = 0.03F;
            this.btnFecharInfoMembro.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharInfoMembro.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFecharInfoMembro.BorderColor = System.Drawing.Color.Black;
            this.btnFecharInfoMembro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFecharInfoMembro.FocusedColor = System.Drawing.Color.Empty;
            this.btnFecharInfoMembro.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharInfoMembro.ForeColor = System.Drawing.Color.White;
            this.btnFecharInfoMembro.Image = global::BravosdomaquisApp.Properties.Resources.x;
            this.btnFecharInfoMembro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFecharInfoMembro.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFecharInfoMembro.Location = new System.Drawing.Point(836, 33);
            this.btnFecharInfoMembro.Name = "btnFecharInfoMembro";
            this.btnFecharInfoMembro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFecharInfoMembro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFecharInfoMembro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFecharInfoMembro.OnHoverImage = null;
            this.btnFecharInfoMembro.OnPressedColor = System.Drawing.Color.Black;
            this.btnFecharInfoMembro.Radius = 8;
            this.btnFecharInfoMembro.Size = new System.Drawing.Size(30, 30);
            this.btnFecharInfoMembro.TabIndex = 41;
            this.btnFecharInfoMembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(502, 727);
            this.Controls.Add(this.panelInfoConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoBanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoBanner";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Leave += new System.EventHandler(this.InfoBanner_Leave);
            this.panelInfoConteudo.ResumeLayout(false);
            this.panelInfoConteudo.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnFecharInfoMembro;
        private System.Windows.Forms.Label lblFecharInfoMembro;
        private System.Windows.Forms.Label lblDescrTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI.WinForms.GunaShadowPanel panelInfoConteudo;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtConteudo;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private Guna.UI.WinForms.GunaButton btnSalvarAlteraçoes;
        private System.Windows.Forms.Label lblDaTxtSMSDescricao;
        private Guna.UI.WinForms.GunaTextBox txtTituloConteudo;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private Guna.UI.WinForms.GunaComboBox cbxSelectURL;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtTituloURL;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.LinkLabel linkLabelVerImagem;
        private Guna.UI.WinForms.GunaButton btnVerAnexo1;
        private System.Windows.Forms.Label lblAnexo1;
        private System.Windows.Forms.Label txtAnexo1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtURL;
        private Guna.UI.WinForms.GunaCheckBox checkAtivo;
        private Guna.UI.WinForms.GunaCheckBox checkAddPrincipal;
    }
}