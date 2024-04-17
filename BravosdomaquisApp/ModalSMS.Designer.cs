namespace BravosdomaquisApp
{
    partial class ModalSMS
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
            this.panelSMS = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblFecharSMS = new System.Windows.Forms.Label();
            this.lblInfoNotify = new System.Windows.Forms.Label();
            this.lblEnviarNotify = new System.Windows.Forms.Label();
            this.btnEnviar = new Guna.UI.WinForms.GunaButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMensagem = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFecharSMS = new Guna.UI.WinForms.GunaButton();
            this.panelSMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSMS
            // 
            this.panelSMS.BackColor = System.Drawing.Color.Transparent;
            this.panelSMS.BaseColor = System.Drawing.Color.Gainsboro;
            this.panelSMS.Controls.Add(this.pictureBox3);
            this.panelSMS.Controls.Add(this.btnFecharSMS);
            this.panelSMS.Controls.Add(this.lblFecharSMS);
            this.panelSMS.Controls.Add(this.lblInfoNotify);
            this.panelSMS.Controls.Add(this.lblEnviarNotify);
            this.panelSMS.Controls.Add(this.btnEnviar);
            this.panelSMS.Controls.Add(this.label11);
            this.panelSMS.Controls.Add(this.txtMensagem);
            this.panelSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSMS.Location = new System.Drawing.Point(0, 0);
            this.panelSMS.Name = "panelSMS";
            this.panelSMS.Radius = 10;
            this.panelSMS.ShadowColor = System.Drawing.Color.Black;
            this.panelSMS.ShadowShift = 8;
            this.panelSMS.Size = new System.Drawing.Size(672, 466);
            this.panelSMS.TabIndex = 39;
            this.panelSMS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSMS_Paint);
            // 
            // lblFecharSMS
            // 
            this.lblFecharSMS.AutoSize = true;
            this.lblFecharSMS.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lblFecharSMS.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblFecharSMS.Location = new System.Drawing.Point(599, 68);
            this.lblFecharSMS.Name = "lblFecharSMS";
            this.lblFecharSMS.Size = new System.Drawing.Size(44, 15);
            this.lblFecharSMS.TabIndex = 49;
            this.lblFecharSMS.Text = "Fechar";
            this.lblFecharSMS.Visible = false;
            // 
            // lblInfoNotify
            // 
            this.lblInfoNotify.AutoSize = true;
            this.lblInfoNotify.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblInfoNotify.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblInfoNotify.Location = new System.Drawing.Point(30, 74);
            this.lblInfoNotify.Name = "lblInfoNotify";
            this.lblInfoNotify.Size = new System.Drawing.Size(487, 16);
            this.lblInfoNotify.TabIndex = 48;
            this.lblInfoNotify.Text = "Ao aprovar, reprovar ou notificar a subscrição de sócios, envia uma mensagem.";
            // 
            // lblEnviarNotify
            // 
            this.lblEnviarNotify.AutoSize = true;
            this.lblEnviarNotify.BackColor = System.Drawing.Color.Transparent;
            this.lblEnviarNotify.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.lblEnviarNotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEnviarNotify.Location = new System.Drawing.Point(62, 31);
            this.lblEnviarNotify.Name = "lblEnviarNotify";
            this.lblEnviarNotify.Size = new System.Drawing.Size(349, 37);
            this.lblEnviarNotify.TabIndex = 47;
            this.lblEnviarNotify.Text = "Enviar uma notificação";
            // 
            // btnEnviar
            // 
            this.btnEnviar.AnimationHoverSpeed = 0.07F;
            this.btnEnviar.AnimationSpeed = 0.03F;
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.btnEnviar.BorderColor = System.Drawing.Color.Black;
            this.btnEnviar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnviar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnviar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Image = null;
            this.btnEnviar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEnviar.Location = new System.Drawing.Point(261, 404);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnEnviar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnviar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnviar.OnHoverImage = null;
            this.btnEnviar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnviar.Radius = 8;
            this.btnEnviar.Size = new System.Drawing.Size(150, 30);
            this.btnEnviar.TabIndex = 46;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(40, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.Transparent;
            this.txtMensagem.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtMensagem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtMensagem.BorderSize = 1;
            this.txtMensagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensagem.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtMensagem.FocusedBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtMensagem.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.txtMensagem.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtMensagem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMensagem.Location = new System.Drawing.Point(32, 124);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PasswordChar = '\0';
            this.txtMensagem.Radius = 8;
            this.txtMensagem.SelectedText = "";
            this.txtMensagem.Size = new System.Drawing.Size(605, 255);
            this.txtMensagem.TabIndex = 44;
            this.txtMensagem.TextOffsetX = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BravosdomaquisApp.Properties.Resources.comentarios;
            this.pictureBox3.Location = new System.Drawing.Point(33, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // btnFecharSMS
            // 
            this.btnFecharSMS.AnimationHoverSpeed = 0.07F;
            this.btnFecharSMS.AnimationSpeed = 0.03F;
            this.btnFecharSMS.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharSMS.BaseColor = System.Drawing.Color.LightSlateGray;
            this.btnFecharSMS.BorderColor = System.Drawing.Color.Black;
            this.btnFecharSMS.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFecharSMS.FocusedColor = System.Drawing.Color.Empty;
            this.btnFecharSMS.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharSMS.ForeColor = System.Drawing.Color.White;
            this.btnFecharSMS.Image = global::BravosdomaquisApp.Properties.Resources.x;
            this.btnFecharSMS.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFecharSMS.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFecharSMS.Location = new System.Drawing.Point(605, 36);
            this.btnFecharSMS.Name = "btnFecharSMS";
            this.btnFecharSMS.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(145)))));
            this.btnFecharSMS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFecharSMS.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFecharSMS.OnHoverImage = null;
            this.btnFecharSMS.OnPressedColor = System.Drawing.Color.Black;
            this.btnFecharSMS.Radius = 8;
            this.btnFecharSMS.Size = new System.Drawing.Size(30, 30);
            this.btnFecharSMS.TabIndex = 50;
            this.btnFecharSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFecharSMS.Click += new System.EventHandler(this.btnFecharSMS_Click);
            this.btnFecharSMS.MouseLeave += new System.EventHandler(this.btnFecharSMS_MouseLeave);
            this.btnFecharSMS.MouseHover += new System.EventHandler(this.btnFecharSMS_MouseHover);
            // 
            // ModalSMS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(672, 466);
            this.Controls.Add(this.panelSMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalSMS";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelSMS.ResumeLayout(false);
            this.panelSMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelSMS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaButton btnFecharSMS;
        private System.Windows.Forms.Label lblFecharSMS;
        private System.Windows.Forms.Label lblInfoNotify;
        private System.Windows.Forms.Label lblEnviarNotify;
        private Guna.UI.WinForms.GunaButton btnEnviar;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox txtMensagem;
    }
}