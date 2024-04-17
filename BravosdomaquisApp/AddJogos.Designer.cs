namespace BravosdomaquisApp
{
    partial class AddJogos
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
            this.panelInsercaoJogo = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblDescriAddParceiro = new System.Windows.Forms.Label();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtSelectMinuto = new Guna.UI.WinForms.GunaTextBox();
            this.txtSelectHora = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.btnInserirJogo = new Guna.UI.WinForms.GunaButton();
            this.dtpSelectData = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEstádio = new System.Windows.Forms.Label();
            this.cbxSelectEstadio = new Guna.UI.WinForms.GunaComboBox();
            this.lblEqVisitante = new System.Windows.Forms.Label();
            this.cbxSelectVisitante = new Guna.UI.WinForms.GunaComboBox();
            this.lblEqCasa = new System.Windows.Forms.Label();
            this.cbxSelectEqCasa = new Guna.UI.WinForms.GunaComboBox();
            this.txtNumJornada = new System.Windows.Forms.Label();
            this.lblJornada = new System.Windows.Forms.Label();
            this.txtNomeCampeonato = new System.Windows.Forms.Label();
            this.lblCampeo = new System.Windows.Forms.Label();
            this.panelInsercaoJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInsercaoJogo
            // 
            this.panelInsercaoJogo.BackColor = System.Drawing.Color.Transparent;
            this.panelInsercaoJogo.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelInsercaoJogo.Controls.Add(this.lblDescriAddParceiro);
            this.panelInsercaoJogo.Controls.Add(this.lblTituloPanel);
            this.panelInsercaoJogo.Controls.Add(this.lblMinuto);
            this.panelInsercaoJogo.Controls.Add(this.lblHora);
            this.panelInsercaoJogo.Controls.Add(this.txtSelectMinuto);
            this.panelInsercaoJogo.Controls.Add(this.txtSelectHora);
            this.panelInsercaoJogo.Controls.Add(this.label1);
            this.panelInsercaoJogo.Controls.Add(this.btnCancelar);
            this.panelInsercaoJogo.Controls.Add(this.btnInserirJogo);
            this.panelInsercaoJogo.Controls.Add(this.dtpSelectData);
            this.panelInsercaoJogo.Controls.Add(this.lblData);
            this.panelInsercaoJogo.Controls.Add(this.lblEstádio);
            this.panelInsercaoJogo.Controls.Add(this.cbxSelectEstadio);
            this.panelInsercaoJogo.Controls.Add(this.lblEqVisitante);
            this.panelInsercaoJogo.Controls.Add(this.cbxSelectVisitante);
            this.panelInsercaoJogo.Controls.Add(this.lblEqCasa);
            this.panelInsercaoJogo.Controls.Add(this.cbxSelectEqCasa);
            this.panelInsercaoJogo.Controls.Add(this.txtNumJornada);
            this.panelInsercaoJogo.Controls.Add(this.lblJornada);
            this.panelInsercaoJogo.Controls.Add(this.txtNomeCampeonato);
            this.panelInsercaoJogo.Controls.Add(this.lblCampeo);
            this.panelInsercaoJogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsercaoJogo.Location = new System.Drawing.Point(0, 0);
            this.panelInsercaoJogo.Name = "panelInsercaoJogo";
            this.panelInsercaoJogo.Radius = 10;
            this.panelInsercaoJogo.ShadowColor = System.Drawing.Color.Black;
            this.panelInsercaoJogo.ShadowDepth = 5;
            this.panelInsercaoJogo.ShadowShift = 3;
            this.panelInsercaoJogo.Size = new System.Drawing.Size(481, 573);
            this.panelInsercaoJogo.TabIndex = 9;
            // 
            // lblDescriAddParceiro
            // 
            this.lblDescriAddParceiro.AutoSize = true;
            this.lblDescriAddParceiro.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescriAddParceiro.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescriAddParceiro.Location = new System.Drawing.Point(38, 62);
            this.lblDescriAddParceiro.Name = "lblDescriAddParceiro";
            this.lblDescriAddParceiro.Size = new System.Drawing.Size(304, 16);
            this.lblDescriAddParceiro.TabIndex = 44;
            this.lblDescriAddParceiro.Text = "Adicione os jogos a esta jornada do campeonato!";
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPanel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTituloPanel.Location = new System.Drawing.Point(35, 26);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(238, 33);
            this.lblTituloPanel.TabIndex = 0;
            this.lblTituloPanel.Text = "Inserção de jogos";
            this.lblTituloPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblMinuto.Location = new System.Drawing.Point(178, 454);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(43, 22);
            this.lblMinuto.TabIndex = 43;
            this.lblMinuto.Text = "min";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHora.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblHora.Location = new System.Drawing.Point(99, 452);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(24, 28);
            this.lblHora.TabIndex = 42;
            this.lblHora.Text = "h";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSelectMinuto
            // 
            this.txtSelectMinuto.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectMinuto.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtSelectMinuto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtSelectMinuto.BorderSize = 1;
            this.txtSelectMinuto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectMinuto.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txtSelectMinuto.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtSelectMinuto.FocusedForeColor = System.Drawing.Color.Gainsboro;
            this.txtSelectMinuto.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtSelectMinuto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSelectMinuto.Location = new System.Drawing.Point(100, 451);
            this.txtSelectMinuto.MaxLength = 2;
            this.txtSelectMinuto.Name = "txtSelectMinuto";
            this.txtSelectMinuto.PasswordChar = '\0';
            this.txtSelectMinuto.Radius = 8;
            this.txtSelectMinuto.SelectedText = "";
            this.txtSelectMinuto.Size = new System.Drawing.Size(124, 30);
            this.txtSelectMinuto.TabIndex = 41;
            this.txtSelectMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSelectMinuto.TextOffsetX = 6;
            // 
            // txtSelectHora
            // 
            this.txtSelectHora.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectHora.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtSelectHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtSelectHora.BorderSize = 1;
            this.txtSelectHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectHora.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtSelectHora.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtSelectHora.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.txtSelectHora.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtSelectHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSelectHora.Location = new System.Drawing.Point(41, 451);
            this.txtSelectHora.MaxLength = 2;
            this.txtSelectHora.Name = "txtSelectHora";
            this.txtSelectHora.PasswordChar = '\0';
            this.txtSelectHora.Radius = 8;
            this.txtSelectHora.SelectedText = "";
            this.txtSelectHora.Size = new System.Drawing.Size(70, 30);
            this.txtSelectHora.TabIndex = 40;
            this.txtSelectHora.TextOffsetX = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(47, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(290, 511);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnCancelar.Radius = 5;
            this.btnCancelar.Size = new System.Drawing.Size(143, 30);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserirJogo
            // 
            this.btnInserirJogo.AnimationHoverSpeed = 0.07F;
            this.btnInserirJogo.AnimationSpeed = 0.03F;
            this.btnInserirJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnInserirJogo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnInserirJogo.BorderColor = System.Drawing.Color.Black;
            this.btnInserirJogo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInserirJogo.FocusedColor = System.Drawing.Color.Empty;
            this.btnInserirJogo.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInserirJogo.ForeColor = System.Drawing.Color.White;
            this.btnInserirJogo.Image = null;
            this.btnInserirJogo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInserirJogo.Location = new System.Drawing.Point(41, 511);
            this.btnInserirJogo.Name = "btnInserirJogo";
            this.btnInserirJogo.OnHoverBaseColor = System.Drawing.Color.SteelBlue;
            this.btnInserirJogo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInserirJogo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInserirJogo.OnHoverImage = null;
            this.btnInserirJogo.OnPressedColor = System.Drawing.Color.Black;
            this.btnInserirJogo.Radius = 5;
            this.btnInserirJogo.Size = new System.Drawing.Size(233, 30);
            this.btnInserirJogo.TabIndex = 37;
            this.btnInserirJogo.Text = "Inserir jogo";
            this.btnInserirJogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpSelectData
            // 
            this.dtpSelectData.BackColor = System.Drawing.Color.Transparent;
            this.dtpSelectData.BaseColor = System.Drawing.Color.Gainsboro;
            this.dtpSelectData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.dtpSelectData.BorderSize = 1;
            this.dtpSelectData.CustomFormat = null;
            this.dtpSelectData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpSelectData.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpSelectData.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpSelectData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.dtpSelectData.Location = new System.Drawing.Point(41, 386);
            this.dtpSelectData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSelectData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSelectData.Name = "dtpSelectData";
            this.dtpSelectData.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.dtpSelectData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpSelectData.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpSelectData.OnPressedColor = System.Drawing.Color.Black;
            this.dtpSelectData.Radius = 5;
            this.dtpSelectData.Size = new System.Drawing.Size(392, 30);
            this.dtpSelectData.TabIndex = 36;
            this.dtpSelectData.Text = "sábado, 17 de fevereiro de 2024";
            this.dtpSelectData.Value = new System.DateTime(2024, 2, 17, 13, 18, 33, 48);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblData.Location = new System.Drawing.Point(47, 361);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 22);
            this.lblData.TabIndex = 35;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstádio
            // 
            this.lblEstádio.AutoSize = true;
            this.lblEstádio.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstádio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEstádio.Location = new System.Drawing.Point(47, 296);
            this.lblEstádio.Name = "lblEstádio";
            this.lblEstádio.Size = new System.Drawing.Size(72, 22);
            this.lblEstádio.TabIndex = 34;
            this.lblEstádio.Text = "Estádio";
            this.lblEstádio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSelectEstadio
            // 
            this.cbxSelectEstadio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSelectEstadio.BackColor = System.Drawing.Color.Transparent;
            this.cbxSelectEstadio.BaseColor = System.Drawing.Color.Gainsboro;
            this.cbxSelectEstadio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectEstadio.BorderSize = 1;
            this.cbxSelectEstadio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSelectEstadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectEstadio.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSelectEstadio.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectEstadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectEstadio.FormattingEnabled = true;
            this.cbxSelectEstadio.Items.AddRange(new object[] {
            "Selecione",
            "11 de Novembro",
            "Outro"});
            this.cbxSelectEstadio.Location = new System.Drawing.Point(41, 321);
            this.cbxSelectEstadio.Name = "cbxSelectEstadio";
            this.cbxSelectEstadio.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSelectEstadio.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSelectEstadio.Radius = 5;
            this.cbxSelectEstadio.Size = new System.Drawing.Size(392, 27);
            this.cbxSelectEstadio.StartIndex = 0;
            this.cbxSelectEstadio.TabIndex = 33;
            // 
            // lblEqVisitante
            // 
            this.lblEqVisitante.AutoSize = true;
            this.lblEqVisitante.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblEqVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEqVisitante.Location = new System.Drawing.Point(47, 230);
            this.lblEqVisitante.Name = "lblEqVisitante";
            this.lblEqVisitante.Size = new System.Drawing.Size(145, 22);
            this.lblEqVisitante.TabIndex = 32;
            this.lblEqVisitante.Text = "Equipa visitante";
            this.lblEqVisitante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSelectVisitante
            // 
            this.cbxSelectVisitante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSelectVisitante.BackColor = System.Drawing.Color.Transparent;
            this.cbxSelectVisitante.BaseColor = System.Drawing.Color.Gainsboro;
            this.cbxSelectVisitante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectVisitante.BorderSize = 1;
            this.cbxSelectVisitante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSelectVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectVisitante.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSelectVisitante.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectVisitante.FormattingEnabled = true;
            this.cbxSelectVisitante.Items.AddRange(new object[] {
            "Selecione",
            "1ª D´Agosto",
            "Petro de Luanda",
            "Bravos do Maquis",
            "Kabuscorp do Palanca",
            "..."});
            this.cbxSelectVisitante.Location = new System.Drawing.Point(41, 255);
            this.cbxSelectVisitante.Name = "cbxSelectVisitante";
            this.cbxSelectVisitante.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSelectVisitante.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSelectVisitante.Radius = 5;
            this.cbxSelectVisitante.Size = new System.Drawing.Size(392, 27);
            this.cbxSelectVisitante.StartIndex = 0;
            this.cbxSelectVisitante.TabIndex = 31;
            // 
            // lblEqCasa
            // 
            this.lblEqCasa.AutoSize = true;
            this.lblEqCasa.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblEqCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEqCasa.Location = new System.Drawing.Point(47, 165);
            this.lblEqCasa.Name = "lblEqCasa";
            this.lblEqCasa.Size = new System.Drawing.Size(135, 22);
            this.lblEqCasa.TabIndex = 30;
            this.lblEqCasa.Text = "Equipa da casa";
            this.lblEqCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSelectEqCasa
            // 
            this.cbxSelectEqCasa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSelectEqCasa.BackColor = System.Drawing.Color.Transparent;
            this.cbxSelectEqCasa.BaseColor = System.Drawing.Color.Gainsboro;
            this.cbxSelectEqCasa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectEqCasa.BorderSize = 1;
            this.cbxSelectEqCasa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSelectEqCasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectEqCasa.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSelectEqCasa.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectEqCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.cbxSelectEqCasa.FormattingEnabled = true;
            this.cbxSelectEqCasa.Items.AddRange(new object[] {
            "Selecione",
            "1ª D´Agosto",
            "Pretro de Luanda",
            "Bravos do Maquis",
            "Kabuscorp do Palanca"});
            this.cbxSelectEqCasa.Location = new System.Drawing.Point(41, 191);
            this.cbxSelectEqCasa.Name = "cbxSelectEqCasa";
            this.cbxSelectEqCasa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSelectEqCasa.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSelectEqCasa.Radius = 5;
            this.cbxSelectEqCasa.Size = new System.Drawing.Size(392, 27);
            this.cbxSelectEqCasa.StartIndex = 0;
            this.cbxSelectEqCasa.TabIndex = 29;
            // 
            // txtNumJornada
            // 
            this.txtNumJornada.AutoSize = true;
            this.txtNumJornada.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtNumJornada.Location = new System.Drawing.Point(183, 127);
            this.txtNumJornada.Name = "txtNumJornada";
            this.txtNumJornada.Size = new System.Drawing.Size(46, 22);
            this.txtNumJornada.TabIndex = 28;
            this.txtNumJornada.Text = "------";
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblJornada.Location = new System.Drawing.Point(71, 127);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(103, 22);
            this.lblJornada.TabIndex = 27;
            this.lblJornada.Text = "Jornada nº:";
            // 
            // txtNomeCampeonato
            // 
            this.txtNomeCampeonato.AutoSize = true;
            this.txtNomeCampeonato.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCampeonato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtNomeCampeonato.Location = new System.Drawing.Point(183, 97);
            this.txtNomeCampeonato.Name = "txtNomeCampeonato";
            this.txtNomeCampeonato.Size = new System.Drawing.Size(46, 22);
            this.txtNomeCampeonato.TabIndex = 26;
            this.txtNomeCampeonato.Text = "------";
            // 
            // lblCampeo
            // 
            this.lblCampeo.AutoSize = true;
            this.lblCampeo.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCampeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblCampeo.Location = new System.Drawing.Point(52, 97);
            this.lblCampeo.Name = "lblCampeo";
            this.lblCampeo.Size = new System.Drawing.Size(122, 22);
            this.lblCampeo.TabIndex = 25;
            this.lblCampeo.Text = "Campeonato:";
            // 
            // AddJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(481, 573);
            this.Controls.Add(this.panelInsercaoJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddJogos";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelInsercaoJogo.ResumeLayout(false);
            this.panelInsercaoJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelInsercaoJogo;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblHora;
        private Guna.UI.WinForms.GunaTextBox txtSelectMinuto;
        private Guna.UI.WinForms.GunaTextBox txtSelectHora;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private Guna.UI.WinForms.GunaButton btnInserirJogo;
        private Guna.UI.WinForms.GunaDateTimePicker dtpSelectData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEstádio;
        private Guna.UI.WinForms.GunaComboBox cbxSelectEstadio;
        private System.Windows.Forms.Label lblEqVisitante;
        private Guna.UI.WinForms.GunaComboBox cbxSelectVisitante;
        private System.Windows.Forms.Label lblEqCasa;
        private Guna.UI.WinForms.GunaComboBox cbxSelectEqCasa;
        private System.Windows.Forms.Label txtNumJornada;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Label txtNomeCampeonato;
        private System.Windows.Forms.Label lblCampeo;
        private System.Windows.Forms.Label lblDescriAddParceiro;
    }
}