namespace BravosdomaquisApp
{
    partial class JogosPane
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
            this.txtDataHora = new System.Windows.Forms.Label();
            this.txtEquipaVisitante = new System.Windows.Forms.Label();
            this.txtEquipaCasa = new System.Windows.Forms.Label();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaVSeparator2 = new Guna.UI.WinForms.GunaVSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstadio = new System.Windows.Forms.Label();
            this.btnJogosAtuali = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new BravosdomaquisApp.Controls.ButtunUI();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.emblemaEquisaVisitante = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.emblemaEquipaCasa = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaVSeparator3 = new Guna.UI.WinForms.GunaVSeparator();
            this.txtCampeonato = new System.Windows.Forms.Label();
            this.txtJornada = new System.Windows.Forms.Label();
            this.gunaVSeparator4 = new Guna.UI.WinForms.GunaVSeparator();
            this.txtAdiadoOUTerminado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emblemaEquisaVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emblemaEquipaCasa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataHora
            // 
            this.txtDataHora.AutoSize = true;
            this.txtDataHora.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtDataHora.Location = new System.Drawing.Point(440, 48);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(84, 60);
            this.txtDataHora.TabIndex = 11;
            this.txtDataHora.Text = "Domingo, \r\n25/02/24\r\n16:00";
            this.txtDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEquipaVisitante
            // 
            this.txtEquipaVisitante.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipaVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtEquipaVisitante.Location = new System.Drawing.Point(59, 94);
            this.txtEquipaVisitante.Name = "txtEquipaVisitante";
            this.txtEquipaVisitante.Size = new System.Drawing.Size(350, 22);
            this.txtEquipaVisitante.TabIndex = 10;
            this.txtEquipaVisitante.Text = "Equipa de fora";
            // 
            // txtEquipaCasa
            // 
            this.txtEquipaCasa.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipaCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtEquipaCasa.Location = new System.Drawing.Point(59, 61);
            this.txtEquipaCasa.Name = "txtEquipaCasa";
            this.txtEquipaCasa.Size = new System.Drawing.Size(350, 22);
            this.txtEquipaCasa.TabIndex = 9;
            this.txtEquipaCasa.Text = "Equipa da casa";
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaVSeparator1.Location = new System.Drawing.Point(415, 48);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 81);
            this.gunaVSeparator1.TabIndex = 8;
            // 
            // gunaVSeparator2
            // 
            this.gunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.gunaVSeparator2.Location = new System.Drawing.Point(537, 48);
            this.gunaVSeparator2.Name = "gunaVSeparator2";
            this.gunaVSeparator2.Size = new System.Drawing.Size(10, 81);
            this.gunaVSeparator2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJogosAtuali);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 93);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.gunaVSeparator4);
            this.panel2.Controls.Add(this.txtJornada);
            this.panel2.Controls.Add(this.txtCampeonato);
            this.panel2.Controls.Add(this.gunaVSeparator3);
            this.panel2.Controls.Add(this.gunaCirclePictureBox1);
            this.panel2.Controls.Add(this.txtEstadio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 42);
            this.panel2.TabIndex = 16;
            // 
            // txtEstadio
            // 
            this.txtEstadio.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtEstadio.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEstadio.Location = new System.Drawing.Point(49, 9);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(263, 22);
            this.txtEstadio.TabIndex = 17;
            this.txtEstadio.Text = "Nome estádio";
            // 
            // btnJogosAtuali
            // 
            this.btnJogosAtuali.AnimationHoverSpeed = 0.07F;
            this.btnJogosAtuali.AnimationSpeed = 0.03F;
            this.btnJogosAtuali.BackColor = System.Drawing.Color.Transparent;
            this.btnJogosAtuali.BaseColor = System.Drawing.Color.LightGray;
            this.btnJogosAtuali.BorderColor = System.Drawing.Color.Black;
            this.btnJogosAtuali.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnJogosAtuali.FocusedColor = System.Drawing.Color.Empty;
            this.btnJogosAtuali.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnJogosAtuali.ForeColor = System.Drawing.Color.White;
            this.btnJogosAtuali.Image = global::BravosdomaquisApp.Properties.Resources.troca;
            this.btnJogosAtuali.ImageSize = new System.Drawing.Size(25, 25);
            this.btnJogosAtuali.Location = new System.Drawing.Point(5, 10);
            this.btnJogosAtuali.Name = "btnJogosAtuali";
            this.btnJogosAtuali.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btnJogosAtuali.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnJogosAtuali.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnJogosAtuali.OnHoverImage = null;
            this.btnJogosAtuali.OnPressedColor = System.Drawing.Color.Black;
            this.btnJogosAtuali.Radius = 8;
            this.btnJogosAtuali.Size = new System.Drawing.Size(40, 32);
            this.btnJogosAtuali.TabIndex = 35;
            this.btnJogosAtuali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnJogosAtuali.Click += new System.EventHandler(this.btnJogosAtuali_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::BravosdomaquisApp.Properties.Resources.apagarr;
            this.btnEliminar.Location = new System.Drawing.Point(7, 45);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::BravosdomaquisApp.Properties.Resources.estdadioWhite;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(16, 5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 17;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // emblemaEquisaVisitante
            // 
            this.emblemaEquisaVisitante.BaseColor = System.Drawing.Color.White;
            this.emblemaEquisaVisitante.Image = global::BravosdomaquisApp.Properties.Resources.emblemaEquipa2;
            this.emblemaEquisaVisitante.Location = new System.Drawing.Point(18, 92);
            this.emblemaEquisaVisitante.Name = "emblemaEquisaVisitante";
            this.emblemaEquisaVisitante.Size = new System.Drawing.Size(30, 30);
            this.emblemaEquisaVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emblemaEquisaVisitante.TabIndex = 13;
            this.emblemaEquisaVisitante.TabStop = false;
            this.emblemaEquisaVisitante.UseTransfarantBackground = false;
            // 
            // emblemaEquipaCasa
            // 
            this.emblemaEquipaCasa.BaseColor = System.Drawing.Color.White;
            this.emblemaEquipaCasa.Image = global::BravosdomaquisApp.Properties.Resources.clubes;
            this.emblemaEquipaCasa.Location = new System.Drawing.Point(18, 56);
            this.emblemaEquipaCasa.Name = "emblemaEquipaCasa";
            this.emblemaEquipaCasa.Size = new System.Drawing.Size(30, 30);
            this.emblemaEquipaCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emblemaEquipaCasa.TabIndex = 12;
            this.emblemaEquipaCasa.TabStop = false;
            this.emblemaEquipaCasa.UseTransfarantBackground = false;
            // 
            // gunaVSeparator3
            // 
            this.gunaVSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator3.LineColor = System.Drawing.Color.WhiteSmoke;
            this.gunaVSeparator3.Location = new System.Drawing.Point(319, 6);
            this.gunaVSeparator3.Name = "gunaVSeparator3";
            this.gunaVSeparator3.Size = new System.Drawing.Size(10, 28);
            this.gunaVSeparator3.TabIndex = 17;
            // 
            // txtCampeonato
            // 
            this.txtCampeonato.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtCampeonato.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampeonato.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCampeonato.Location = new System.Drawing.Point(334, 9);
            this.txtCampeonato.Name = "txtCampeonato";
            this.txtCampeonato.Size = new System.Drawing.Size(160, 22);
            this.txtCampeonato.TabIndex = 18;
            this.txtCampeonato.Text = "Girabola";
            // 
            // txtJornada
            // 
            this.txtJornada.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtJornada.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJornada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtJornada.Location = new System.Drawing.Point(505, 9);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(108, 22);
            this.txtJornada.TabIndex = 19;
            this.txtJornada.Text = "1º Jornada";
            // 
            // gunaVSeparator4
            // 
            this.gunaVSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator4.LineColor = System.Drawing.Color.WhiteSmoke;
            this.gunaVSeparator4.Location = new System.Drawing.Point(489, 6);
            this.gunaVSeparator4.Name = "gunaVSeparator4";
            this.gunaVSeparator4.Size = new System.Drawing.Size(10, 28);
            this.gunaVSeparator4.TabIndex = 20;
            // 
            // txtAdiadoOUTerminado
            // 
            this.txtAdiadoOUTerminado.AutoSize = true;
            this.txtAdiadoOUTerminado.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdiadoOUTerminado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtAdiadoOUTerminado.Location = new System.Drawing.Point(434, 106);
            this.txtAdiadoOUTerminado.Name = "txtAdiadoOUTerminado";
            this.txtAdiadoOUTerminado.Size = new System.Drawing.Size(100, 20);
            this.txtAdiadoOUTerminado.TabIndex = 17;
            this.txtAdiadoOUTerminado.Text = "Não iniciado";
            // 
            // JogosPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.txtAdiadoOUTerminado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaVSeparator2);
            this.Controls.Add(this.emblemaEquisaVisitante);
            this.Controls.Add(this.emblemaEquipaCasa);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.txtEquipaVisitante);
            this.Controls.Add(this.txtEquipaCasa);
            this.Controls.Add(this.gunaVSeparator1);
            this.Name = "JogosPane";
            this.Size = new System.Drawing.Size(613, 135);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emblemaEquisaVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emblemaEquipaCasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox emblemaEquisaVisitante;
        private Guna.UI.WinForms.GunaCirclePictureBox emblemaEquipaCasa;
        private System.Windows.Forms.Label txtDataHora;
        private System.Windows.Forms.Label txtEquipaVisitante;
        private System.Windows.Forms.Label txtEquipaCasa;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator2;
        private System.Windows.Forms.Panel panel1;
        private Controls.ButtunUI btnEliminar;
        private Guna.UI.WinForms.GunaButton btnJogosAtuali;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label txtEstadio;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator4;
        private System.Windows.Forms.Label txtJornada;
        private System.Windows.Forms.Label txtCampeonato;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator3;
        private System.Windows.Forms.Label txtAdiadoOUTerminado;
    }
}
