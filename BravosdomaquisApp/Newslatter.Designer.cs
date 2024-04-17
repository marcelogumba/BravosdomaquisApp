namespace BravosdomaquisApp
{
    partial class Newslatter
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNewslatter = new System.Windows.Forms.Panel();
            this.DataGridViewInscritos = new Guna.UI.WinForms.GunaDataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelCard1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNumInscritos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new Guna.UI.WinForms.GunaButton();
            this.lblDescriNewslatter = new System.Windows.Forms.Label();
            this.lblNewsLatter = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceEmailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelNewslatter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInscritos)).BeginInit();
            this.panelCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEmailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNewslatter
            // 
            this.panelNewslatter.BackColor = System.Drawing.Color.Gainsboro;
            this.panelNewslatter.Controls.Add(this.DataGridViewInscritos);
            this.panelNewslatter.Controls.Add(this.panelCard1);
            this.panelNewslatter.Controls.Add(this.pictureBox3);
            this.panelNewslatter.Controls.Add(this.btnFechar);
            this.panelNewslatter.Controls.Add(this.lblDescriNewslatter);
            this.panelNewslatter.Controls.Add(this.lblNewsLatter);
            this.panelNewslatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewslatter.Location = new System.Drawing.Point(0, 0);
            this.panelNewslatter.Name = "panelNewslatter";
            this.panelNewslatter.Size = new System.Drawing.Size(627, 760);
            this.panelNewslatter.TabIndex = 1;
            this.panelNewslatter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DataGridViewInscritos
            // 
            this.DataGridViewInscritos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewInscritos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewInscritos.AutoGenerateColumns = false;
            this.DataGridViewInscritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInscritos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewInscritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewInscritos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInscritos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInscritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Eliminar});
            this.DataGridViewInscritos.DataSource = this.sourceEmailBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInscritos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewInscritos.EnableHeadersVisualStyles = false;
            this.DataGridViewInscritos.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewInscritos.Location = new System.Drawing.Point(33, 111);
            this.DataGridViewInscritos.Name = "DataGridViewInscritos";
            this.DataGridViewInscritos.RowHeadersVisible = false;
            this.DataGridViewInscritos.RowTemplate.Height = 35;
            this.DataGridViewInscritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInscritos.Size = new System.Drawing.Size(560, 599);
            this.DataGridViewInscritos.TabIndex = 34;
            this.DataGridViewInscritos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridViewInscritos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewInscritos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewInscritos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInscritos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewInscritos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInscritos.ThemeStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewInscritos.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewInscritos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.DataGridViewInscritos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewInscritos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewInscritos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewInscritos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewInscritos.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridViewInscritos.ThemeStyle.ReadOnly = false;
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewInscritos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewInscritos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInscritos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.FillWeight = 50F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::BravosdomaquisApp.Properties.Resources.apagarr;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // panelCard1
            // 
            this.panelCard1.AutoSize = true;
            this.panelCard1.BackColor = System.Drawing.Color.Transparent;
            this.panelCard1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.panelCard1.Controls.Add(this.label4);
            this.panelCard1.Controls.Add(this.label11);
            this.panelCard1.Controls.Add(this.lblNumInscritos);
            this.panelCard1.Location = new System.Drawing.Point(347, 22);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 5;
            this.panelCard1.ShadowColor = System.Drawing.Color.Black;
            this.panelCard1.ShadowShift = 2;
            this.panelCard1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.panelCard1.Size = new System.Drawing.Size(246, 72);
            this.panelCard1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de inscritos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(9, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "Inscritos";
            // 
            // lblNumInscritos
            // 
            this.lblNumInscritos.AutoSize = true;
            this.lblNumInscritos.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInscritos.Font = new System.Drawing.Font("Montserrat", 32F, System.Drawing.FontStyle.Bold);
            this.lblNumInscritos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumInscritos.Location = new System.Drawing.Point(102, -3);
            this.lblNumInscritos.Name = "lblNumInscritos";
            this.lblNumInscritos.Size = new System.Drawing.Size(129, 60);
            this.lblNumInscritos.TabIndex = 9;
            this.lblNumInscritos.Text = "1000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.newslatter;
            this.pictureBox3.Location = new System.Drawing.Point(33, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.AnimationHoverSpeed = 0.07F;
            this.btnFechar.AnimationSpeed = 0.03F;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFechar.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFechar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = null;
            this.btnFechar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFechar.Location = new System.Drawing.Point(230, 721);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFechar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechar.OnHoverImage = null;
            this.btnFechar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechar.Radius = 8;
            this.btnFechar.Size = new System.Drawing.Size(167, 30);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDescriNewslatter
            // 
            this.lblDescriNewslatter.AutoSize = true;
            this.lblDescriNewslatter.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescriNewslatter.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescriNewslatter.Location = new System.Drawing.Point(30, 66);
            this.lblDescriNewslatter.Name = "lblDescriNewslatter";
            this.lblDescriNewslatter.Size = new System.Drawing.Size(287, 16);
            this.lblDescriNewslatter.TabIndex = 1;
            this.lblDescriNewslatter.Text = "Veja abaixo a lista de dos inscritos a Newslatter";
            // 
            // lblNewsLatter
            // 
            this.lblNewsLatter.AutoSize = true;
            this.lblNewsLatter.BackColor = System.Drawing.Color.Transparent;
            this.lblNewsLatter.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold);
            this.lblNewsLatter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblNewsLatter.Location = new System.Drawing.Point(66, 20);
            this.lblNewsLatter.Name = "lblNewsLatter";
            this.lblNewsLatter.Size = new System.Drawing.Size(204, 44);
            this.lblNewsLatter.TabIndex = 53;
            this.lblNewsLatter.Text = "Newslatter";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BravosdomaquisApp.Properties.Resources.apagarr;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 55F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 55;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sourceEmailBindingSource
            // 
            this.sourceEmailBindingSource.DataSource = typeof(BravosdomaquisApp.sourceEmail);
            // 
            // Newslatter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(627, 760);
            this.Controls.Add(this.panelNewslatter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Newslatter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newslatter";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelNewslatter.ResumeLayout(false);
            this.panelNewslatter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInscritos)).EndInit();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEmailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewslatter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaButton btnFechar;
        private System.Windows.Forms.Label lblDescriNewslatter;
        private System.Windows.Forms.Label lblNewsLatter;
        private Guna.UI.WinForms.GunaShadowPanel panelCard1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNumInscritos;
        private Guna.UI.WinForms.GunaDataGridView DataGridViewInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.BindingSource sourceEmailBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}