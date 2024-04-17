namespace BravosdomaquisApp
{
    partial class Banner
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContactos = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnaddConteudo = new Guna.UI.WinForms.GunaButton();
            this.panelViewAllContacto = new Guna.UI.WinForms.GunaShadowPanel();
            this.DataGridViewContactos = new Guna.UI.WinForms.GunaDataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblVerListaContatosDescrip = new System.Windows.Forms.Label();
            this.lblVerListaContatos = new System.Windows.Forms.Label();
            this.lblDescriContatos = new System.Windows.Forms.Label();
            this.lblContactos = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceBannerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourceContactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelContactos.SuspendLayout();
            this.panelViewAllContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBannerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceContactosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 619);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(962, 10);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(972, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 619);
            this.panel3.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 619);
            this.panel2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 10);
            this.panel1.TabIndex = 34;
            // 
            // panelContactos
            // 
            this.panelContactos.BackColor = System.Drawing.Color.Transparent;
            this.panelContactos.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelContactos.Controls.Add(this.btnaddConteudo);
            this.panelContactos.Controls.Add(this.panelViewAllContacto);
            this.panelContactos.Controls.Add(this.lblDescriContatos);
            this.panelContactos.Controls.Add(this.lblContactos);
            this.panelContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContactos.Location = new System.Drawing.Point(10, 10);
            this.panelContactos.Name = "panelContactos";
            this.panelContactos.Radius = 10;
            this.panelContactos.ShadowColor = System.Drawing.Color.Black;
            this.panelContactos.ShadowShift = 3;
            this.panelContactos.Size = new System.Drawing.Size(962, 609);
            this.panelContactos.TabIndex = 38;
            this.panelContactos.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // btnaddConteudo
            // 
            this.btnaddConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddConteudo.AnimationHoverSpeed = 0.07F;
            this.btnaddConteudo.AnimationSpeed = 0.03F;
            this.btnaddConteudo.BackColor = System.Drawing.Color.Transparent;
            this.btnaddConteudo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnaddConteudo.BorderColor = System.Drawing.Color.Black;
            this.btnaddConteudo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddConteudo.FocusedColor = System.Drawing.Color.Empty;
            this.btnaddConteudo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddConteudo.ForeColor = System.Drawing.Color.White;
            this.btnaddConteudo.Image = null;
            this.btnaddConteudo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnaddConteudo.Location = new System.Drawing.Point(657, 43);
            this.btnaddConteudo.Name = "btnaddConteudo";
            this.btnaddConteudo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnaddConteudo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnaddConteudo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnaddConteudo.OnHoverImage = null;
            this.btnaddConteudo.OnPressedColor = System.Drawing.Color.Black;
            this.btnaddConteudo.Radius = 8;
            this.btnaddConteudo.Size = new System.Drawing.Size(271, 30);
            this.btnaddConteudo.TabIndex = 80;
            this.btnaddConteudo.Text = "Adicionar novo conteúdo";
            this.btnaddConteudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnaddConteudo.Click += new System.EventHandler(this.btnaddConteudo_Click);
            // 
            // panelViewAllContacto
            // 
            this.panelViewAllContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelViewAllContacto.BackColor = System.Drawing.Color.Transparent;
            this.panelViewAllContacto.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelViewAllContacto.Controls.Add(this.DataGridViewContactos);
            this.panelViewAllContacto.Controls.Add(this.lblVerListaContatosDescrip);
            this.panelViewAllContacto.Controls.Add(this.lblVerListaContatos);
            this.panelViewAllContacto.Location = new System.Drawing.Point(0, 84);
            this.panelViewAllContacto.Name = "panelViewAllContacto";
            this.panelViewAllContacto.Radius = 10;
            this.panelViewAllContacto.ShadowColor = System.Drawing.Color.Black;
            this.panelViewAllContacto.ShadowShift = 4;
            this.panelViewAllContacto.Size = new System.Drawing.Size(962, 525);
            this.panelViewAllContacto.TabIndex = 34;
            // 
            // DataGridViewContactos
            // 
            this.DataGridViewContactos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewContactos.AutoGenerateColumns = false;
            this.DataGridViewContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewContactos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Titulo,
            this.Principal,
            this.Status,
            this.Editar,
            this.Apagar});
            this.DataGridViewContactos.DataSource = this.sourceBannerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewContactos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewContactos.EnableHeadersVisualStyles = false;
            this.DataGridViewContactos.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewContactos.Location = new System.Drawing.Point(31, 63);
            this.DataGridViewContactos.Name = "DataGridViewContactos";
            this.DataGridViewContactos.ReadOnly = true;
            this.DataGridViewContactos.RowHeadersVisible = false;
            this.DataGridViewContactos.RowTemplate.Height = 35;
            this.DataGridViewContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewContactos.Size = new System.Drawing.Size(897, 441);
            this.DataGridViewContactos.TabIndex = 34;
            this.DataGridViewContactos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewContactos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewContactos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewContactos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewContactos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewContactos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewContactos.ThemeStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewContactos.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewContactos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.DataGridViewContactos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewContactos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewContactos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewContactos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewContactos.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridViewContactos.ThemeStyle.ReadOnly = true;
            this.DataGridViewContactos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewContactos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewContactos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewContactos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewContactos.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridViewContactos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewContactos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewContactos_CellContentClick);
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Principal
            // 
            this.Principal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Principal.DataPropertyName = "Principal";
            this.Principal.HeaderText = "Principal";
            this.Principal.Name = "Principal";
            this.Principal.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 80;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.FillWeight = 30F;
            this.Editar.HeaderText = "";
            this.Editar.Image = global::BravosdomaquisApp.Properties.Resources.editGrid;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 40;
            // 
            // Apagar
            // 
            this.Apagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apagar.FillWeight = 30F;
            this.Apagar.HeaderText = "";
            this.Apagar.Image = global::BravosdomaquisApp.Properties.Resources.apagarr;
            this.Apagar.Name = "Apagar";
            this.Apagar.ReadOnly = true;
            this.Apagar.Width = 40;
            // 
            // lblVerListaContatosDescrip
            // 
            this.lblVerListaContatosDescrip.AutoSize = true;
            this.lblVerListaContatosDescrip.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblVerListaContatosDescrip.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblVerListaContatosDescrip.Location = new System.Drawing.Point(28, 37);
            this.lblVerListaContatosDescrip.Name = "lblVerListaContatosDescrip";
            this.lblVerListaContatosDescrip.Size = new System.Drawing.Size(376, 16);
            this.lblVerListaContatosDescrip.TabIndex = 4;
            this.lblVerListaContatosDescrip.Text = "Veja abaixo a lista de todos os contactos do Bravos do Maquis";
            // 
            // lblVerListaContatos
            // 
            this.lblVerListaContatos.AutoSize = true;
            this.lblVerListaContatos.BackColor = System.Drawing.Color.Transparent;
            this.lblVerListaContatos.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.lblVerListaContatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblVerListaContatos.Location = new System.Drawing.Point(27, 12);
            this.lblVerListaContatos.Name = "lblVerListaContatos";
            this.lblVerListaContatos.Size = new System.Drawing.Size(198, 26);
            this.lblVerListaContatos.TabIndex = 3;
            this.lblVerListaContatos.Text = "Lista de conteúdos";
            // 
            // lblDescriContatos
            // 
            this.lblDescriContatos.AutoSize = true;
            this.lblDescriContatos.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescriContatos.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescriContatos.Location = new System.Drawing.Point(29, 57);
            this.lblDescriContatos.Name = "lblDescriContatos";
            this.lblDescriContatos.Size = new System.Drawing.Size(280, 16);
            this.lblDescriContatos.TabIndex = 33;
            this.lblDescriContatos.Text = "Visualiza, adiciona ou edita os contactos aqui!";
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold);
            this.lblContactos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblContactos.Location = new System.Drawing.Point(22, 16);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(141, 44);
            this.lblContactos.TabIndex = 2;
            this.lblContactos.Text = "Banner";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Description = "Ver detalhes";
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BravosdomaquisApp.Properties.Resources.icons8_ver_detalhes_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::BravosdomaquisApp.Properties.Resources.apagar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 102.0408F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // sourceBannerBindingSource
            // 
            this.sourceBannerBindingSource.DataSource = typeof(BravosdomaquisApp.sourceBanner);
            // 
            // sourceContactosBindingSource
            // 
            this.sourceContactosBindingSource.DataSource = typeof(BravosdomaquisApp.SourceContactos);
            // 
            // Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.panelContactos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Banner";
            this.Size = new System.Drawing.Size(982, 629);
            this.panelContactos.ResumeLayout(false);
            this.panelContactos.PerformLayout();
            this.panelViewAllContacto.ResumeLayout(false);
            this.panelViewAllContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBannerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceContactosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaShadowPanel panelContactos;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.Label lblDescriContatos;
        private Guna.UI.WinForms.GunaShadowPanel panelViewAllContacto;
        private System.Windows.Forms.Label lblVerListaContatosDescrip;
        private System.Windows.Forms.Label lblVerListaContatos;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewContactos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource sourceContactosBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaButton btnaddConteudo;
        private System.Windows.Forms.BindingSource sourceBannerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Principal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Apagar;
    }
}
