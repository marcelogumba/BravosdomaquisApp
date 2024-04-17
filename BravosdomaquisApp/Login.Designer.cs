namespace BravosdomaquisApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblDescrTitulo = new System.Windows.Forms.Label();
            this.btnSair = new BravosdomaquisApp.Controls.ButtunUI();
            this.btnCriarConta = new BravosdomaquisApp.Controls.ButtunUI();
            this.lblDescriNewslatter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEsqueceuPasse = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new BravosdomaquisApp.Controls.ButtunUI();
            this.txtPassword = new BravosdomaquisApp.Controls.TextBoxUI();
            this.txtUsername = new BravosdomaquisApp.Controls.TextBoxUI();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModoEscuro = new BravosdomaquisApp.Controls.ToogleButton();
            this.panelSplash = new System.Windows.Forms.Panel();
            this.lblinfoSplash = new System.Windows.Forms.Label();
            this.progress = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.pictureBoxSplash = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat ExtraBold", 40F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 114);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblDescrTitulo);
            this.panelLogin.Controls.Add(this.btnSair);
            this.panelLogin.Controls.Add(this.btnCriarConta);
            this.panelLogin.Controls.Add(this.lblDescriNewslatter);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.lblEsqueceuPasse);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.btnModoEscuro);
            this.panelLogin.Location = new System.Drawing.Point(556, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(444, 600);
            this.panelLogin.TabIndex = 5;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // lblDescrTitulo
            // 
            this.lblDescrTitulo.AutoSize = true;
            this.lblDescrTitulo.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescrTitulo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescrTitulo.Location = new System.Drawing.Point(29, 190);
            this.lblDescrTitulo.Name = "lblDescrTitulo";
            this.lblDescrTitulo.Size = new System.Drawing.Size(334, 16);
            this.lblDescrTitulo.TabIndex = 64;
            this.lblDescrTitulo.Text = "Entre com as suas credencias para acessar ao sistema!";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.BorderRadius = 13;
            this.btnSair.BorderSize = 0;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnSair.Location = new System.Drawing.Point(25, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(338, 36);
            this.btnSair.TabIndex = 63;
            this.btnSair.Text = "Sair do sistema";
            this.btnSair.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseHover += new System.EventHandler(this.btnSair_MouseHover);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarConta.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCriarConta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCriarConta.BorderRadius = 13;
            this.btnCriarConta.BorderSize = 0;
            this.btnCriarConta.FlatAppearance.BorderSize = 0;
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarConta.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnCriarConta.Location = new System.Drawing.Point(100, 537);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(180, 31);
            this.btnCriarConta.TabIndex = 62;
            this.btnCriarConta.Text = "Criar uma conta";
            this.btnCriarConta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnCriarConta.UseVisualStyleBackColor = false;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            this.btnCriarConta.MouseLeave += new System.EventHandler(this.btnCriarConta_MouseLeave);
            this.btnCriarConta.MouseHover += new System.EventHandler(this.btnCriarConta_MouseHover);
            // 
            // lblDescriNewslatter
            // 
            this.lblDescriNewslatter.AutoSize = true;
            this.lblDescriNewslatter.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblDescriNewslatter.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblDescriNewslatter.Location = new System.Drawing.Point(100, 572);
            this.lblDescriNewslatter.Name = "lblDescriNewslatter";
            this.lblDescriNewslatter.Size = new System.Drawing.Size(185, 16);
            this.lblDescriNewslatter.TabIndex = 61;
            this.lblDescriNewslatter.Text = "Todos os direitos resevados ©";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BravosdomaquisApp.Properties.Resources.darklight3;
            this.pictureBox1.Location = new System.Drawing.Point(410, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblEsqueceuPasse
            // 
            this.lblEsqueceuPasse.AutoSize = true;
            this.lblEsqueceuPasse.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuPasse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEsqueceuPasse.Location = new System.Drawing.Point(109, 340);
            this.lblEsqueceuPasse.Name = "lblEsqueceuPasse";
            this.lblEsqueceuPasse.Size = new System.Drawing.Size(168, 16);
            this.lblEsqueceuPasse.TabIndex = 7;
            this.lblEsqueceuPasse.TabStop = true;
            this.lblEsqueceuPasse.Text = "Esqueceu a palavra-passe?";
            this.lblEsqueceuPasse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceuPasse_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnEntrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEntrar.BorderRadius = 13;
            this.btnEntrar.BorderSize = 0;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrar.Location = new System.Drawing.Point(25, 375);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(338, 33);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            this.btnEntrar.MouseHover += new System.EventHandler(this.btnEntrar_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.BorderRadius = 13;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintText = "Palavra-passe";
            this.txtPassword.IsFocused = false;
            this.txtPassword.IsPasswordChar = false;
            this.txtPassword.IsPlaceholder = false;
            this.txtPassword.Location = new System.Drawing.Point(7, 289);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Palavra-passe";
            this.txtPassword.Size = new System.Drawing.Size(378, 37);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword._TextChanged += new System.EventHandler(this.textBoxUI2__TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtUsername.BorderRadius = 13;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintText = "Nome de utilizador";
            this.txtUsername.IsFocused = false;
            this.txtUsername.IsPasswordChar = false;
            this.txtUsername.IsPlaceholder = false;
            this.txtUsername.Location = new System.Drawing.Point(7, 233);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Nome de utilizador";
            this.txtUsername.Size = new System.Drawing.Size(378, 37);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(331, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ativar modo escuro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnModoEscuro
            // 
            this.btnModoEscuro.BackColor = System.Drawing.Color.Transparent;
            this.btnModoEscuro.Location = new System.Drawing.Point(444, 580);
            this.btnModoEscuro.MinimumSize = new System.Drawing.Size(15, 10);
            this.btnModoEscuro.Name = "btnModoEscuro";
            this.btnModoEscuro.OffBackColor = System.Drawing.Color.Gray;
            this.btnModoEscuro.OffToogleColor = System.Drawing.Color.Gainsboro;
            this.btnModoEscuro.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnModoEscuro.OnTooglekColor = System.Drawing.Color.WhiteSmoke;
            this.btnModoEscuro.Size = new System.Drawing.Size(40, 20);
            this.btnModoEscuro.TabIndex = 1;
            this.btnModoEscuro.UseVisualStyleBackColor = false;
            this.btnModoEscuro.Visible = false;
            this.btnModoEscuro.CheckedChanged += new System.EventHandler(this.btnModoEscuro_CheckedChanged);
            // 
            // panelSplash
            // 
            this.panelSplash.Controls.Add(this.lblinfoSplash);
            this.panelSplash.Controls.Add(this.progress);
            this.panelSplash.Controls.Add(this.pictureBoxSplash);
            this.panelSplash.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSplash.Location = new System.Drawing.Point(0, 0);
            this.panelSplash.Name = "panelSplash";
            this.panelSplash.Size = new System.Drawing.Size(98, 600);
            this.panelSplash.TabIndex = 6;
            // 
            // lblinfoSplash
            // 
            this.lblinfoSplash.AutoSize = true;
            this.lblinfoSplash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.lblinfoSplash.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblinfoSplash.Location = new System.Drawing.Point(358, 554);
            this.lblinfoSplash.Name = "lblinfoSplash";
            this.lblinfoSplash.Size = new System.Drawing.Size(298, 26);
            this.lblinfoSplash.TabIndex = 2;
            this.lblinfoSplash.Text = "Carregando as informaçoes...";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.progress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.progress.Location = new System.Drawing.Point(326, 553);
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progress.Size = new System.Drawing.Size(30, 30);
            this.progress.TabIndex = 1;
            // 
            // pictureBoxSplash
            // 
            this.pictureBoxSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSplash.Image = global::BravosdomaquisApp.Properties.Resources.splash1;
            this.pictureBoxSplash.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSplash.Name = "pictureBoxSplash";
            this.pictureBoxSplash.Size = new System.Drawing.Size(98, 600);
            this.pictureBoxSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSplash.TabIndex = 0;
            this.pictureBoxSplash.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(0, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(1000, 600);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelSplash);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSplash.ResumeLayout(false);
            this.panelSplash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Controls.ToogleButton toogleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private Controls.ToogleButton btnModoEscuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLogin;
        private Controls.TextBoxUI txtPassword;
        private Controls.TextBoxUI txtUsername;
        private Controls.ButtunUI btnEntrar;
        private System.Windows.Forms.LinkLabel lblEsqueceuPasse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescriNewslatter;
        private System.Windows.Forms.Panel panelSplash;
        private System.Windows.Forms.PictureBox pictureBoxSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblinfoSplash;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator progress;
        private Controls.ButtunUI btnCriarConta;
        private Controls.ButtunUI btnSair;
        private System.Windows.Forms.Label lblDescrTitulo;
    }
}

