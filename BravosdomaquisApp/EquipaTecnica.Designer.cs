namespace BravosdomaquisApp
{
    partial class EquipaTecnica
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
            this.DataGridViewListaTecnicos = new Guna.UI.WinForms.GunaDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIngressoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redesSociaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewImageColumn();
            this.sourceTecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVerListaDescrip = new System.Windows.Forms.Label();
            this.lblListaTecnicos = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelSuperior = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnAddTecnico = new Guna.UI.WinForms.GunaButton();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNumAdicionados = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescrCampeo = new System.Windows.Forms.Label();
            this.lblEquipaTecnica = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelViewAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaTecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTecnicosBindingSource)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewAll
            // 
            this.panelViewAll.BackColor = System.Drawing.Color.Transparent;
            this.panelViewAll.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelViewAll.Controls.Add(this.DataGridViewListaTecnicos);
            this.panelViewAll.Controls.Add(this.lblVerListaDescrip);
            this.panelViewAll.Controls.Add(this.lblListaTecnicos);
            this.panelViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewAll.Location = new System.Drawing.Point(10, 167);
            this.panelViewAll.Name = "panelViewAll";
            this.panelViewAll.Radius = 10;
            this.panelViewAll.ShadowColor = System.Drawing.Color.Black;
            this.panelViewAll.ShadowShift = 3;
            this.panelViewAll.Size = new System.Drawing.Size(962, 452);
            this.panelViewAll.TabIndex = 44;
            // 
            // DataGridViewListaTecnicos
            // 
            this.DataGridViewListaTecnicos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaTecnicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewListaTecnicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewListaTecnicos.AutoGenerateColumns = false;
            this.DataGridViewListaTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewListaTecnicos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewListaTecnicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaTecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewListaTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewListaTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.dataIngressoDataGridViewTextBoxColumn,
            this.nacionalidadeDataGridViewTextBoxColumn,
            this.redesSociaisDataGridViewTextBoxColumn,
            this.Detalhes});
            this.DataGridViewListaTecnicos.DataSource = this.sourceTecnicosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewListaTecnicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewListaTecnicos.EnableHeadersVisualStyles = false;
            this.DataGridViewListaTecnicos.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaTecnicos.Location = new System.Drawing.Point(27, 89);
            this.DataGridViewListaTecnicos.Name = "DataGridViewListaTecnicos";
            this.DataGridViewListaTecnicos.RowHeadersVisible = false;
            this.DataGridViewListaTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewListaTecnicos.Size = new System.Drawing.Size(911, 339);
            this.DataGridViewListaTecnicos.TabIndex = 5;
            this.DataGridViewListaTecnicos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewListaTecnicos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaTecnicos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewListaTecnicos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaTecnicos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewListaTecnicos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaTecnicos.ThemeStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaTecnicos.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaTecnicos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.DataGridViewListaTecnicos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewListaTecnicos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewListaTecnicos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewListaTecnicos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewListaTecnicos.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridViewListaTecnicos.ThemeStyle.ReadOnly = false;
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewListaTecnicos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaTecnicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewListaTecnicos_CellContentClick);
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
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            // 
            // dataIngressoDataGridViewTextBoxColumn
            // 
            this.dataIngressoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataIngressoDataGridViewTextBoxColumn.DataPropertyName = "DataIngresso";
            this.dataIngressoDataGridViewTextBoxColumn.HeaderText = "DataIngresso";
            this.dataIngressoDataGridViewTextBoxColumn.Name = "dataIngressoDataGridViewTextBoxColumn";
            this.dataIngressoDataGridViewTextBoxColumn.Width = 120;
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            this.nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
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
            // sourceTecnicosBindingSource
            // 
            this.sourceTecnicosBindingSource.DataSource = typeof(BravosdomaquisApp.sourceTecnicos);
            // 
            // lblVerListaDescrip
            // 
            this.lblVerListaDescrip.AutoSize = true;
            this.lblVerListaDescrip.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblVerListaDescrip.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVerListaDescrip.Location = new System.Drawing.Point(27, 57);
            this.lblVerListaDescrip.Name = "lblVerListaDescrip";
            this.lblVerListaDescrip.Size = new System.Drawing.Size(237, 32);
            this.lblVerListaDescrip.TabIndex = 4;
            this.lblVerListaDescrip.Text = "Veja abaixo a lista de todos os técnicos\r\n\r\n";
            // 
            // lblListaTecnicos
            // 
            this.lblListaTecnicos.AutoSize = true;
            this.lblListaTecnicos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaTecnicos.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblListaTecnicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblListaTecnicos.Location = new System.Drawing.Point(24, 21);
            this.lblListaTecnicos.Name = "lblListaTecnicos";
            this.lblListaTecnicos.Size = new System.Drawing.Size(227, 33);
            this.lblListaTecnicos.TabIndex = 3;
            this.lblListaTecnicos.Text = "Lista de técnicos";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 5);
            this.panel5.TabIndex = 45;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelSuperior.Controls.Add(this.btnAddTecnico);
            this.panelSuperior.Controls.Add(this.panelCard1);
            this.panelSuperior.Controls.Add(this.lblDescrCampeo);
            this.panelSuperior.Controls.Add(this.lblEquipaTecnica);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(10, 10);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Radius = 10;
            this.panelSuperior.ShadowColor = System.Drawing.Color.Black;
            this.panelSuperior.ShadowShift = 3;
            this.panelSuperior.Size = new System.Drawing.Size(962, 152);
            this.panelSuperior.TabIndex = 43;
            // 
            // btnAddTecnico
            // 
            this.btnAddTecnico.AnimationHoverSpeed = 0.07F;
            this.btnAddTecnico.AnimationSpeed = 0.03F;
            this.btnAddTecnico.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTecnico.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnAddTecnico.BorderColor = System.Drawing.Color.Black;
            this.btnAddTecnico.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddTecnico.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddTecnico.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTecnico.ForeColor = System.Drawing.Color.White;
            this.btnAddTecnico.Image = null;
            this.btnAddTecnico.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddTecnico.Location = new System.Drawing.Point(36, 100);
            this.btnAddTecnico.Name = "btnAddTecnico";
            this.btnAddTecnico.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnAddTecnico.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddTecnico.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddTecnico.OnHoverImage = null;
            this.btnAddTecnico.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddTecnico.Radius = 8;
            this.btnAddTecnico.Size = new System.Drawing.Size(262, 32);
            this.btnAddTecnico.TabIndex = 15;
            this.btnAddTecnico.Text = "Adicionar técnico";
            this.btnAddTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddTecnico.Click += new System.EventHandler(this.btnAddTecnico_Click);
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
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de técnicos\r\nadicionados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(9, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Técnicos";
            // 
            // lblDescrCampeo
            // 
            this.lblDescrCampeo.AutoSize = true;
            this.lblDescrCampeo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescrCampeo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrCampeo.Location = new System.Drawing.Point(33, 65);
            this.lblDescrCampeo.Name = "lblDescrCampeo";
            this.lblDescrCampeo.Size = new System.Drawing.Size(417, 16);
            this.lblDescrCampeo.TabIndex = 2;
            this.lblDescrCampeo.Text = "Adiciona, edita e visualiza as infor. dos técnicos do Bravos do Maquis";
            // 
            // lblEquipaTecnica
            // 
            this.lblEquipaTecnica.AutoSize = true;
            this.lblEquipaTecnica.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipaTecnica.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold);
            this.lblEquipaTecnica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEquipaTecnica.Location = new System.Drawing.Point(25, 15);
            this.lblEquipaTecnica.Name = "lblEquipaTecnica";
            this.lblEquipaTecnica.Size = new System.Drawing.Size(293, 48);
            this.lblEquipaTecnica.TabIndex = 1;
            this.lblEquipaTecnica.Text = "Equipa técnica";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(972, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 609);
            this.panel4.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 10);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 619);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 10);
            this.panel3.TabIndex = 41;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // EquipaTecnica
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
            this.Name = "EquipaTecnica";
            this.Size = new System.Drawing.Size(982, 629);
            this.panelViewAll.ResumeLayout(false);
            this.panelViewAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaTecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTecnicosBindingSource)).EndInit();
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
        private Guna.UI.WinForms.GunaDataGridView DataGridViewListaTecnicos;
        private System.Windows.Forms.Label lblVerListaDescrip;
        private System.Windows.Forms.Label lblListaTecnicos;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaShadowPanel panelSuperior;
        private Guna.UI.WinForms.GunaButton btnAddTecnico;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private System.Windows.Forms.Label lblNumAdicionados;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescrCampeo;
        private System.Windows.Forms.Label lblEquipaTecnica;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIngressoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redesSociaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Detalhes;
        private System.Windows.Forms.BindingSource sourceTecnicosBindingSource;
    }
}
