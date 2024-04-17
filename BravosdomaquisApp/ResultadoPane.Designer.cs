namespace BravosdomaquisApp
{
    partial class ResultadoPane
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
            this.txtEquipaCasa = new System.Windows.Forms.Label();
            this.txtEquipaVisitante = new System.Windows.Forms.Label();
            this.txtGolsEquipaCasa = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.Label();
            this.txtGolsEquipaVisitante = new System.Windows.Forms.Label();
            this.panelEquipaVisitante = new System.Windows.Forms.Panel();
            this.panelEquipaCasa = new System.Windows.Forms.Panel();
            this.panelTempo = new System.Windows.Forms.Panel();
            this.txtControlTempo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblPostar = new System.Windows.Forms.Label();
            this.btnPost = new BravosdomaquisApp.Controls.ButtunUI();
            this.btnEliminar = new BravosdomaquisApp.Controls.ButtunUI();
            this.panelEquipaVisitante.SuspendLayout();
            this.panelEquipaCasa.SuspendLayout();
            this.panelTempo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEquipaCasa
            // 
            this.txtEquipaCasa.AutoSize = true;
            this.txtEquipaCasa.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.txtEquipaCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtEquipaCasa.Location = new System.Drawing.Point(2, 17);
            this.txtEquipaCasa.Name = "txtEquipaCasa";
            this.txtEquipaCasa.Size = new System.Drawing.Size(162, 26);
            this.txtEquipaCasa.TabIndex = 2;
            this.txtEquipaCasa.Text = "Equipa da casa";
            this.txtEquipaCasa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtEquipaVisitante
            // 
            this.txtEquipaVisitante.AutoSize = true;
            this.txtEquipaVisitante.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.txtEquipaVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtEquipaVisitante.Location = new System.Drawing.Point(2, 15);
            this.txtEquipaVisitante.Name = "txtEquipaVisitante";
            this.txtEquipaVisitante.Size = new System.Drawing.Size(173, 26);
            this.txtEquipaVisitante.TabIndex = 3;
            this.txtEquipaVisitante.Text = "Equipa visitante";
            // 
            // txtGolsEquipaCasa
            // 
            this.txtGolsEquipaCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtGolsEquipaCasa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtGolsEquipaCasa.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Bold);
            this.txtGolsEquipaCasa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtGolsEquipaCasa.Location = new System.Drawing.Point(0, 0);
            this.txtGolsEquipaCasa.Name = "txtGolsEquipaCasa";
            this.txtGolsEquipaCasa.Size = new System.Drawing.Size(82, 65);
            this.txtGolsEquipaCasa.TabIndex = 4;
            this.txtGolsEquipaCasa.Text = "00";
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtTempo.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.txtTempo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTempo.Location = new System.Drawing.Point(0, 22);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(137, 42);
            this.txtTempo.TabIndex = 5;
            this.txtTempo.Text = "00:00";
            this.txtTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGolsEquipaVisitante
            // 
            this.txtGolsEquipaVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtGolsEquipaVisitante.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtGolsEquipaVisitante.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Bold);
            this.txtGolsEquipaVisitante.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtGolsEquipaVisitante.Location = new System.Drawing.Point(649, 0);
            this.txtGolsEquipaVisitante.Name = "txtGolsEquipaVisitante";
            this.txtGolsEquipaVisitante.Size = new System.Drawing.Size(78, 65);
            this.txtGolsEquipaVisitante.TabIndex = 6;
            this.txtGolsEquipaVisitante.Text = "00";
            // 
            // panelEquipaVisitante
            // 
            this.panelEquipaVisitante.Controls.Add(this.txtEquipaVisitante);
            this.panelEquipaVisitante.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEquipaVisitante.Location = new System.Drawing.Point(434, 0);
            this.panelEquipaVisitante.Name = "panelEquipaVisitante";
            this.panelEquipaVisitante.Size = new System.Drawing.Size(215, 65);
            this.panelEquipaVisitante.TabIndex = 7;
            // 
            // panelEquipaCasa
            // 
            this.panelEquipaCasa.Controls.Add(this.txtEquipaCasa);
            this.panelEquipaCasa.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEquipaCasa.Location = new System.Drawing.Point(82, 0);
            this.panelEquipaCasa.Name = "panelEquipaCasa";
            this.panelEquipaCasa.Size = new System.Drawing.Size(215, 65);
            this.panelEquipaCasa.TabIndex = 8;
            // 
            // panelTempo
            // 
            this.panelTempo.Controls.Add(this.txtControlTempo);
            this.panelTempo.Controls.Add(this.txtTempo);
            this.panelTempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTempo.Location = new System.Drawing.Point(297, 0);
            this.panelTempo.Name = "panelTempo";
            this.panelTempo.Size = new System.Drawing.Size(137, 65);
            this.panelTempo.TabIndex = 8;
            // 
            // txtControlTempo
            // 
            this.txtControlTempo.AutoSize = true;
            this.txtControlTempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtControlTempo.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControlTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.txtControlTempo.Location = new System.Drawing.Point(0, 0);
            this.txtControlTempo.Name = "txtControlTempo";
            this.txtControlTempo.Size = new System.Drawing.Size(129, 22);
            this.txtControlTempo.TabIndex = 9;
            this.txtControlTempo.Text = "    Não iniciado";
            this.txtControlTempo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.lblEliminar);
            this.panel1.Controls.Add(this.lblPostar);
            this.panel1.Controls.Add(this.btnPost);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 35);
            this.panel1.TabIndex = 9;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Font = new System.Drawing.Font("Montserrat", 8.3F);
            this.lblEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblEliminar.Location = new System.Drawing.Point(204, 9);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(118, 16);
            this.lblEliminar.TabIndex = 11;
            this.lblEliminar.Text = "Eliminar resultado";
            this.lblEliminar.Visible = false;
            this.lblEliminar.MouseLeave += new System.EventHandler(this.lblEliminar_MouseLeave);
            this.lblEliminar.MouseHover += new System.EventHandler(this.lblEliminar_MouseHover);
            // 
            // lblPostar
            // 
            this.lblPostar.AutoSize = true;
            this.lblPostar.BackColor = System.Drawing.Color.Transparent;
            this.lblPostar.Font = new System.Drawing.Font("Montserrat", 8.3F);
            this.lblPostar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(165)))));
            this.lblPostar.Location = new System.Drawing.Point(415, 9);
            this.lblPostar.Name = "lblPostar";
            this.lblPostar.Size = new System.Drawing.Size(108, 16);
            this.lblPostar.TabIndex = 10;
            this.lblPostar.Text = "Postar resultado";
            this.lblPostar.Visible = false;
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
            this.btnPost.Location = new System.Drawing.Point(371, -2);
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
            this.btnEliminar.Location = new System.Drawing.Point(321, -2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // ResultadoPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panelTempo);
            this.Controls.Add(this.panelEquipaCasa);
            this.Controls.Add(this.panelEquipaVisitante);
            this.Controls.Add(this.txtGolsEquipaVisitante);
            this.Controls.Add(this.txtGolsEquipaCasa);
            this.Controls.Add(this.panel1);
            this.Name = "ResultadoPane";
            this.Size = new System.Drawing.Size(727, 100);
            this.panelEquipaVisitante.ResumeLayout(false);
            this.panelEquipaVisitante.PerformLayout();
            this.panelEquipaCasa.ResumeLayout(false);
            this.panelEquipaCasa.PerformLayout();
            this.panelTempo.ResumeLayout(false);
            this.panelTempo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtEquipaCasa;
        private System.Windows.Forms.Label txtEquipaVisitante;
        private System.Windows.Forms.Label txtGolsEquipaCasa;
        private System.Windows.Forms.Label txtTempo;
        private System.Windows.Forms.Label txtGolsEquipaVisitante;
        private System.Windows.Forms.Panel panelEquipaVisitante;
        private System.Windows.Forms.Panel panelEquipaCasa;
        private System.Windows.Forms.Panel panelTempo;
        private System.Windows.Forms.Label txtControlTempo;
        private System.Windows.Forms.Panel panel1;
        private Controls.ButtunUI btnEliminar;
        private Controls.ButtunUI btnPost;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblPostar;
    }
}
