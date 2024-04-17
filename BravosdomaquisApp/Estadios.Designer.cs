namespace BravosdomaquisApp
{
    partial class Estadios
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
            this.DataGridViewListaEstadios = new Guna.UI.WinForms.GunaDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFundaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagensDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewImageColumn();
            this.sourceEstadiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVerListaDescrip = new System.Windows.Forms.Label();
            this.lblVerListaEstadios = new System.Windows.Forms.Label();
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
            this.panelViewAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaEstadios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEstadiosBindingSource)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewAll
            // 
            this.panelViewAll.BackColor = System.Drawing.Color.Transparent;
            this.panelViewAll.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelViewAll.Controls.Add(this.DataGridViewListaEstadios);
            this.panelViewAll.Controls.Add(this.lblVerListaDescrip);
            this.panelViewAll.Controls.Add(this.lblVerListaEstadios);
            this.panelViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewAll.Location = new System.Drawing.Point(10, 167);
            this.panelViewAll.Name = "panelViewAll";
            this.panelViewAll.Radius = 10;
            this.panelViewAll.ShadowColor = System.Drawing.Color.Black;
            this.panelViewAll.ShadowShift = 3;
            this.panelViewAll.Size = new System.Drawing.Size(962, 452);
            this.panelViewAll.TabIndex = 23;
            // 
            // DataGridViewListaEstadios
            // 
            this.DataGridViewListaEstadios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaEstadios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewListaEstadios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewListaEstadios.AutoGenerateColumns = false;
            this.DataGridViewListaEstadios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewListaEstadios.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaEstadios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewListaEstadios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaEstadios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewListaEstadios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewListaEstadios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataFundaçãoDataGridViewTextBoxColumn,
            this.historiaDataGridViewTextBoxColumn,
            this.imagensDataGridViewTextBoxColumn,
            this.Detalhes});
            this.DataGridViewListaEstadios.DataSource = this.sourceEstadiosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewListaEstadios.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewListaEstadios.EnableHeadersVisualStyles = false;
            this.DataGridViewListaEstadios.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaEstadios.Location = new System.Drawing.Point(27, 85);
            this.DataGridViewListaEstadios.Name = "DataGridViewListaEstadios";
            this.DataGridViewListaEstadios.RowHeadersVisible = false;
            this.DataGridViewListaEstadios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewListaEstadios.Size = new System.Drawing.Size(911, 339);
            this.DataGridViewListaEstadios.TabIndex = 5;
            this.DataGridViewListaEstadios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewListaEstadios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaEstadios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewListaEstadios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaEstadios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewListaEstadios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewListaEstadios.ThemeStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaEstadios.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewListaEstadios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.DataGridViewListaEstadios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewListaEstadios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewListaEstadios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewListaEstadios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewListaEstadios.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridViewListaEstadios.ThemeStyle.ReadOnly = false;
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewListaEstadios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewListaEstadios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewListaEstadios_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataFundaçãoDataGridViewTextBoxColumn
            // 
            this.dataFundaçãoDataGridViewTextBoxColumn.DataPropertyName = "DataFundação";
            this.dataFundaçãoDataGridViewTextBoxColumn.HeaderText = "DataFundação";
            this.dataFundaçãoDataGridViewTextBoxColumn.Name = "dataFundaçãoDataGridViewTextBoxColumn";
            // 
            // historiaDataGridViewTextBoxColumn
            // 
            this.historiaDataGridViewTextBoxColumn.DataPropertyName = "Historia";
            this.historiaDataGridViewTextBoxColumn.HeaderText = "Historia";
            this.historiaDataGridViewTextBoxColumn.Name = "historiaDataGridViewTextBoxColumn";
            // 
            // imagensDataGridViewTextBoxColumn
            // 
            this.imagensDataGridViewTextBoxColumn.DataPropertyName = "Imagens";
            this.imagensDataGridViewTextBoxColumn.HeaderText = "Imagens";
            this.imagensDataGridViewTextBoxColumn.Name = "imagensDataGridViewTextBoxColumn";
            // 
            // Detalhes
            // 
            this.Detalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalhes.HeaderText = "";
            this.Detalhes.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Width = 50;
            // 
            // sourceEstadiosBindingSource
            // 
            this.sourceEstadiosBindingSource.DataSource = typeof(BravosdomaquisApp.sourceEstadios);
            // 
            // lblVerListaDescrip
            // 
            this.lblVerListaDescrip.AutoSize = true;
            this.lblVerListaDescrip.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblVerListaDescrip.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVerListaDescrip.Location = new System.Drawing.Point(27, 57);
            this.lblVerListaDescrip.Name = "lblVerListaDescrip";
            this.lblVerListaDescrip.Size = new System.Drawing.Size(312, 16);
            this.lblVerListaDescrip.TabIndex = 4;
            this.lblVerListaDescrip.Text = "Veja abaixo a lista de todos os estádios adicionados";
            // 
            // lblVerListaEstadios
            // 
            this.lblVerListaEstadios.AutoSize = true;
            this.lblVerListaEstadios.BackColor = System.Drawing.Color.Transparent;
            this.lblVerListaEstadios.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.lblVerListaEstadios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblVerListaEstadios.Location = new System.Drawing.Point(24, 21);
            this.lblVerListaEstadios.Name = "lblVerListaEstadios";
            this.lblVerListaEstadios.Size = new System.Drawing.Size(227, 33);
            this.lblVerListaEstadios.TabIndex = 3;
            this.lblVerListaEstadios.Text = "Lista de estádios";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 5);
            this.panel5.TabIndex = 24;
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
            this.panelSuperior.TabIndex = 22;
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
            this.btnAddEstadios.Text = "Adicionar estádio";
            this.btnAddEstadios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddEstadios.Click += new System.EventHandler(this.btnSalvarAlteracoes_Click);
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
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de estádios \r\nadicionados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(5, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Adicionados";
            // 
            // lblDescrCampeo
            // 
            this.lblDescrCampeo.AutoSize = true;
            this.lblDescrCampeo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescrCampeo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrCampeo.Location = new System.Drawing.Point(33, 65);
            this.lblDescrCampeo.Name = "lblDescrCampeo";
            this.lblDescrCampeo.Size = new System.Drawing.Size(287, 16);
            this.lblDescrCampeo.TabIndex = 2;
            this.lblDescrCampeo.Text = "Adiciona, edita e visualiza as infor. dos estádios";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Estádios";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(972, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 609);
            this.panel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 10);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 619);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 10);
            this.panel3.TabIndex = 20;
            // 
            // Estadios
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
            this.Name = "Estadios";
            this.Size = new System.Drawing.Size(982, 629);
            this.panelViewAll.ResumeLayout(false);
            this.panelViewAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewListaEstadios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEstadiosBindingSource)).EndInit();
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
        private Guna.UI.WinForms.GunaDataGridView DataGridViewListaEstadios;
        private System.Windows.Forms.Label lblVerListaDescrip;
        private System.Windows.Forms.Label lblVerListaEstadios;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaShadowPanel panelSuperior;
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
        private Guna.UI.WinForms.GunaButton btnAddEstadios;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFundaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Detalhes;
        private System.Windows.Forms.BindingSource sourceEstadiosBindingSource;
    }
}
