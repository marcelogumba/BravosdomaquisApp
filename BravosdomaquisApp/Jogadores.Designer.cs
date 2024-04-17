namespace BravosdomaquisApp
{
    partial class Jogadores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelViewAll = new Guna.UI.WinForms.GunaShadowPanel();
            this.DataGridViewListaJogadores = new Guna.UI.WinForms.GunaDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAtleticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCamisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redesSociaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewImageColumn();
            this.sourceJogadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVerListaDescrip = new System.Windows.Forms.Label();
            this.lblVerListaJogadores = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelSuperior = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnAddEstadios = new Guna.UI.WinForms.GunaButton();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNumAdicionados = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescrCampeo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelViewAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaJogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceJogadoresBindingSource)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewAll
            // 
            this.panelViewAll.BackColor = System.Drawing.Color.Transparent;
            this.panelViewAll.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelViewAll.Controls.Add(this.DataGridViewListaJogadores);
            this.panelViewAll.Controls.Add(this.lblVerListaDescrip);
            this.panelViewAll.Controls.Add(this.lblVerListaJogadores);
            this.panelViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewAll.Location = new System.Drawing.Point(10, 167);
            this.panelViewAll.Name = "panelViewAll";
            this.panelViewAll.Radius = 10;
            this.panelViewAll.ShadowColor = System.Drawing.Color.Black;
            this.panelViewAll.ShadowShift = 3;
            this.panelViewAll.Size = new System.Drawing.Size(962, 452);
            this.panelViewAll.TabIndex = 37;
            // 
            // DataGridViewListaJogadores
            // 
            this.DataGridViewListaJogadores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaJogadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewListaJogadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewListaJogadores.AutoGenerateColumns = false;
            this.DataGridViewListaJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewListaJogadores.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewListaJogadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaJogadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewListaJogadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewListaJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.nomeAtleticoDataGridViewTextBoxColumn,
            this.numeroCamisaDataGridViewTextBoxColumn,
            this.posicaoDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.redesSociaisDataGridViewTextBoxColumn,
            this.Detalhes});
            this.DataGridViewListaJogadores.DataSource = this.sourceJogadoresBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewListaJogadores.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewListaJogadores.EnableHeadersVisualStyles = false;
            this.DataGridViewListaJogadores.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaJogadores.Location = new System.Drawing.Point(27, 89);
            this.DataGridViewListaJogadores.Name = "DataGridViewListaJogadores";
            this.DataGridViewListaJogadores.RowHeadersVisible = false;
            this.DataGridViewListaJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewListaJogadores.Size = new System.Drawing.Size(911, 339);
            this.DataGridViewListaJogadores.TabIndex = 5;
            this.DataGridViewListaJogadores.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewListaJogadores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaJogadores.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewListaJogadores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaJogadores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewListaJogadores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaJogadores.ThemeStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaJogadores.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaJogadores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.DataGridViewListaJogadores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewListaJogadores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewListaJogadores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewListaJogadores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewListaJogadores.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridViewListaJogadores.ThemeStyle.ReadOnly = false;
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewListaJogadores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaJogadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewListaJogadores_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            // 
            // nomeAtleticoDataGridViewTextBoxColumn
            // 
            this.nomeAtleticoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeAtleticoDataGridViewTextBoxColumn.DataPropertyName = "NomeAtletico";
            this.nomeAtleticoDataGridViewTextBoxColumn.HeaderText = "NomeAtletico";
            this.nomeAtleticoDataGridViewTextBoxColumn.Name = "nomeAtleticoDataGridViewTextBoxColumn";
            this.nomeAtleticoDataGridViewTextBoxColumn.Width = 120;
            // 
            // numeroCamisaDataGridViewTextBoxColumn
            // 
            this.numeroCamisaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCamisa";
            this.numeroCamisaDataGridViewTextBoxColumn.HeaderText = "NumeroCamisa";
            this.numeroCamisaDataGridViewTextBoxColumn.Name = "numeroCamisaDataGridViewTextBoxColumn";
            // 
            // posicaoDataGridViewTextBoxColumn
            // 
            this.posicaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.posicaoDataGridViewTextBoxColumn.DataPropertyName = "Posicao";
            this.posicaoDataGridViewTextBoxColumn.HeaderText = "Posicao";
            this.posicaoDataGridViewTextBoxColumn.Name = "posicaoDataGridViewTextBoxColumn";
            this.posicaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // redesSociaisDataGridViewTextBoxColumn
            // 
            this.redesSociaisDataGridViewTextBoxColumn.DataPropertyName = "RedesSociais";
            this.redesSociaisDataGridViewTextBoxColumn.HeaderText = "RedesSociais";
            this.redesSociaisDataGridViewTextBoxColumn.Name = "redesSociaisDataGridViewTextBoxColumn";
            // 
            // Detalhes
            // 
            this.Detalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalhes.HeaderText = "";
            this.Detalhes.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Width = 50;
            // 
            // sourceJogadoresBindingSource
            // 
            this.sourceJogadoresBindingSource.DataSource = typeof(BravosdomaquisApp.sourceJogadores);
            // 
            // lblVerListaDescrip
            // 
            this.lblVerListaDescrip.AutoSize = true;
            this.lblVerListaDescrip.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblVerListaDescrip.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVerListaDescrip.Location = new System.Drawing.Point(27, 57);
            this.lblVerListaDescrip.Name = "lblVerListaDescrip";
            this.lblVerListaDescrip.Size = new System.Drawing.Size(246, 16);
            this.lblVerListaDescrip.TabIndex = 4;
            this.lblVerListaDescrip.Text = "Veja abaixo a lista de todos os jogadores\r\n";
            // 
            // lblVerListaJogadores
            // 
            this.lblVerListaJogadores.AutoSize = true;
            this.lblVerListaJogadores.BackColor = System.Drawing.Color.Transparent;
            this.lblVerListaJogadores.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblVerListaJogadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblVerListaJogadores.Location = new System.Drawing.Point(24, 21);
            this.lblVerListaJogadores.Name = "lblVerListaJogadores";
            this.lblVerListaJogadores.Size = new System.Drawing.Size(247, 33);
            this.lblVerListaJogadores.TabIndex = 3;
            this.lblVerListaJogadores.Text = "Lista de jogadores";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 5);
            this.panel5.TabIndex = 38;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelSuperior.Controls.Add(this.btnAddEstadios);
            this.panelSuperior.Controls.Add(this.panelCard1);
            this.panelSuperior.Controls.Add(this.lblDescrCampeo);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(10, 10);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Radius = 10;
            this.panelSuperior.ShadowColor = System.Drawing.Color.Black;
            this.panelSuperior.ShadowShift = 3;
            this.panelSuperior.Size = new System.Drawing.Size(962, 152);
            this.panelSuperior.TabIndex = 36;
            // 
            // btnAddEstadios
            // 
            this.btnAddEstadios.AnimationHoverSpeed = 0.07F;
            this.btnAddEstadios.AnimationSpeed = 0.03F;
            this.btnAddEstadios.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEstadios.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnAddEstadios.BorderColor = System.Drawing.Color.Black;
            this.btnAddEstadios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddEstadios.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddEstadios.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEstadios.ForeColor = System.Drawing.Color.White;
            this.btnAddEstadios.Image = null;
            this.btnAddEstadios.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddEstadios.Location = new System.Drawing.Point(36, 98);
            this.btnAddEstadios.Name = "btnAddEstadios";
            this.btnAddEstadios.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnAddEstadios.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddEstadios.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddEstadios.OnHoverImage = null;
            this.btnAddEstadios.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddEstadios.Radius = 8;
            this.btnAddEstadios.Size = new System.Drawing.Size(215, 34);
            this.btnAddEstadios.TabIndex = 15;
            this.btnAddEstadios.Text = "Adicionar jogador";
            this.btnAddEstadios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddEstadios.Click += new System.EventHandler(this.btnAddJogadores_Click);
            // 
            // panelCard1
            // 
            this.panelCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.lblNumAdicionados);
            this.panelCard1.Controls.Add(this.gunaShadowPanel1);
            this.panelCard1.Location = new System.Drawing.Point(666, 28);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 0;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(272, 89);
            this.panelCard1.TabIndex = 10;
            // 
            // lblNumAdicionados
            // 
            this.lblNumAdicionados.AutoSize = true;
            this.lblNumAdicionados.BackColor = System.Drawing.Color.Transparent;
            this.lblNumAdicionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumAdicionados.Font = new System.Drawing.Font("Montserrat", 42F, System.Drawing.FontStyle.Bold);
            this.lblNumAdicionados.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumAdicionados.Location = new System.Drawing.Point(179, 0);
            this.lblNumAdicionados.Name = "lblNumAdicionados";
            this.lblNumAdicionados.Size = new System.Drawing.Size(93, 77);
            this.lblNumAdicionados.TabIndex = 9;
            this.lblNumAdicionados.Text = "01";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaShadowPanel1.Controls.Add(this.label4);
            this.gunaShadowPanel1.Controls.Add(this.label11);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 0;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(168, 89);
            this.gunaShadowPanel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de jogadores\r\n adicionados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(9, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Jogadores";
            // 
            // lblDescrCampeo
            // 
            this.lblDescrCampeo.AutoSize = true;
            this.lblDescrCampeo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescrCampeo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrCampeo.Location = new System.Drawing.Point(33, 65);
            this.lblDescrCampeo.Name = "lblDescrCampeo";
            this.lblDescrCampeo.Size = new System.Drawing.Size(297, 16);
            this.lblDescrCampeo.TabIndex = 2;
            this.lblDescrCampeo.Text = "Adiciona, edita e visualiza as infor. dos jogadores";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Jogadores";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(972, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 609);
            this.panel4.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 10);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 619);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 10);
            this.panel3.TabIndex = 34;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // Jogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.panelViewAll);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Jogadores";
            this.Size = new System.Drawing.Size(982, 629);
            this.panelViewAll.ResumeLayout(false);
            this.panelViewAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaJogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceJogadoresBindingSource)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelViewAll;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewListaJogadores;
        private System.Windows.Forms.Label lblVerListaDescrip;
        private System.Windows.Forms.Label lblVerListaJogadores;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaShadowPanel panelSuperior;
        private Guna.UI.WinForms.GunaButton btnAddEstadios;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private System.Windows.Forms.Label lblNumAdicionados;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescrCampeo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAtleticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCamisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redesSociaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Detalhes;
        private System.Windows.Forms.BindingSource sourceJogadoresBindingSource;
    }
}
