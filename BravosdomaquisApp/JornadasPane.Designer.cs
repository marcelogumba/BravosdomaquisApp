namespace BravosdomaquisApp
{
    partial class JornadasPane
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
            this.txtNºJornada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblPostar = new System.Windows.Forms.Label();
            this.lblJogossDispo = new System.Windows.Forms.Label();
            this.panelEquipaCasa = new System.Windows.Forms.Panel();
            this.txtTotalJogosDisputados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalJogosdaJornadas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPost = new BravosdomaquisApp.Controls.ButtunUI();
            this.btnEliminar = new BravosdomaquisApp.Controls.ButtunUI();
            this.panel1.SuspendLayout();
            this.panelEquipaCasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNºJornada
            // 
            this.txtNºJornada.AutoSize = true;
            this.txtNºJornada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtNºJornada.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNºJornada.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.txtNºJornada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNºJornada.Location = new System.Drawing.Point(0, 0);
            this.txtNºJornada.Name = "txtNºJornada";
            this.txtNºJornada.Size = new System.Drawing.Size(179, 41);
            this.txtNºJornada.TabIndex = 10;
            this.txtNºJornada.Text = "1ª Jornada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.lblEliminar);
            this.panel1.Controls.Add(this.lblPostar);
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 35);
            this.panel1.TabIndex = 12;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Font = new System.Drawing.Font("Montserrat", 8.3F);
            this.lblEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEliminar.Location = new System.Drawing.Point(190, 9);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(118, 16);
            this.lblEliminar.TabIndex = 11;
            this.lblEliminar.Text = "Eliminar resultado";
            this.lblEliminar.Visible = false;
            // 
            // lblPostar
            // 
            this.lblPostar.AutoSize = true;
            this.lblPostar.BackColor = System.Drawing.Color.Transparent;
            this.lblPostar.Font = new System.Drawing.Font("Montserrat", 8.3F);
            this.lblPostar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblPostar.Location = new System.Drawing.Point(401, 9);
            this.lblPostar.Name = "lblPostar";
            this.lblPostar.Size = new System.Drawing.Size(108, 16);
            this.lblPostar.TabIndex = 10;
            this.lblPostar.Text = "Postar resultado";
            this.lblPostar.Visible = false;
            // 
            // lblJogossDispo
            // 
            this.lblJogossDispo.AutoSize = true;
            this.lblJogossDispo.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.lblJogossDispo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblJogossDispo.Location = new System.Drawing.Point(19, 9);
            this.lblJogossDispo.Name = "lblJogossDispo";
            this.lblJogossDispo.Size = new System.Drawing.Size(189, 26);
            this.lblJogossDispo.TabIndex = 2;
            this.lblJogossDispo.Text = "Jogos disputados:";
            this.lblJogossDispo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelEquipaCasa
            // 
            this.panelEquipaCasa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelEquipaCasa.Controls.Add(this.label6);
            this.panelEquipaCasa.Controls.Add(this.txtStatus);
            this.panelEquipaCasa.Controls.Add(this.label4);
            this.panelEquipaCasa.Controls.Add(this.label2);
            this.panelEquipaCasa.Controls.Add(this.txtTotalJogosDisputados);
            this.panelEquipaCasa.Controls.Add(this.lblJogossDispo);
            this.panelEquipaCasa.Controls.Add(this.txtTotalJogosdaJornadas);
            this.panelEquipaCasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEquipaCasa.Location = new System.Drawing.Point(179, 0);
            this.panelEquipaCasa.Name = "panelEquipaCasa";
            this.panelEquipaCasa.Size = new System.Drawing.Size(558, 41);
            this.panelEquipaCasa.TabIndex = 11;
            // 
            // txtTotalJogosDisputados
            // 
            this.txtTotalJogosDisputados.AutoSize = true;
            this.txtTotalJogosDisputados.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.txtTotalJogosDisputados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtTotalJogosDisputados.Location = new System.Drawing.Point(205, 9);
            this.txtTotalJogosDisputados.Name = "txtTotalJogosDisputados";
            this.txtTotalJogosDisputados.Size = new System.Drawing.Size(34, 26);
            this.txtTotalJogosDisputados.TabIndex = 3;
            this.txtTotalJogosDisputados.Text = "23";
            this.txtTotalJogosDisputados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTotalJogosdaJornadas
            // 
            this.txtTotalJogosdaJornadas.AutoSize = true;
            this.txtTotalJogosdaJornadas.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalJogosdaJornadas.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.txtTotalJogosdaJornadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtTotalJogosdaJornadas.Location = new System.Drawing.Point(252, 9);
            this.txtTotalJogosdaJornadas.Name = "txtTotalJogosdaJornadas";
            this.txtTotalJogosdaJornadas.Size = new System.Drawing.Size(36, 26);
            this.txtTotalJogosdaJornadas.TabIndex = 5;
            this.txtTotalJogosdaJornadas.Text = "30";
            this.txtTotalJogosdaJornadas.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(317, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtStatus.Location = new System.Drawing.Point(394, 9);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(129, 26);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "Decorrendo";
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.label6.Location = new System.Drawing.Point(292, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "|";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnPost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnPost.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPost.BorderRadius = 10;
            this.btnPost.BorderSize = 0;
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Image = global::BravosdomaquisApp.Properties.Resources.post22;
            this.btnPost.Location = new System.Drawing.Point(357, -3);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(40, 40);
            this.btnPost.TabIndex = 9;
            this.btnPost.TextColor = System.Drawing.Color.White;
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.MouseLeave += new System.EventHandler(this.btnPost_MouseLeave);
            this.btnPost.MouseHover += new System.EventHandler(this.btnPost_MouseHover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::BravosdomaquisApp.Properties.Resources.apagarr;
            this.btnEliminar.Location = new System.Drawing.Point(307, -3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // JornadasPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEquipaCasa);
            this.Controls.Add(this.txtNºJornada);
            this.Controls.Add(this.panel1);
            this.Name = "JornadasPane";
            this.Size = new System.Drawing.Size(737, 76);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEquipaCasa.ResumeLayout(false);
            this.panelEquipaCasa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNºJornada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblPostar;
        private Controls.ButtunUI btnPost;
        private Controls.ButtunUI btnEliminar;
        private System.Windows.Forms.Label lblJogossDispo;
        private System.Windows.Forms.Panel panelEquipaCasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTotalJogosDisputados;
        private System.Windows.Forms.Label txtTotalJogosdaJornadas;
    }
}
