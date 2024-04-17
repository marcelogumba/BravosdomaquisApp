namespace BravosdomaquisApp
{
    partial class FotosPane
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
            this.panelDescri = new System.Windows.Forms.Panel();
            this.btnBaixar = new BravosdomaquisApp.Controls.ButtunUI();
            this.btnEliminar = new BravosdomaquisApp.Controls.ButtunUI();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescriImagem = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panelDescri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDescri
            // 
            this.panelDescri.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelDescri.Controls.Add(this.btnBaixar);
            this.panelDescri.Controls.Add(this.btnEliminar);
            this.panelDescri.Controls.Add(this.label2);
            this.panelDescri.Controls.Add(this.txtDescriImagem);
            this.panelDescri.Location = new System.Drawing.Point(100, 0);
            this.panelDescri.Name = "panelDescri";
            this.panelDescri.Size = new System.Drawing.Size(560, 100);
            this.panelDescri.TabIndex = 1;
            // 
            // btnBaixar
            // 
            this.btnBaixar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBaixar.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btnBaixar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBaixar.BorderRadius = 10;
            this.btnBaixar.BorderSize = 0;
            this.btnBaixar.FlatAppearance.BorderSize = 0;
            this.btnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixar.ForeColor = System.Drawing.Color.White;
            this.btnBaixar.Image = global::BravosdomaquisApp.Properties.Resources.post333;
            this.btnBaixar.Location = new System.Drawing.Point(515, 16);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(40, 40);
            this.btnBaixar.TabIndex = 84;
            this.btnBaixar.TextColor = System.Drawing.Color.White;
            this.btnBaixar.UseVisualStyleBackColor = false;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            this.btnBaixar.MouseLeave += new System.EventHandler(this.btnBaixar_MouseLeave);
            this.btnBaixar.MouseHover += new System.EventHandler(this.btnBaixar_MouseHover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::BravosdomaquisApp.Properties.Resources.apagarr;
            this.btnEliminar.Location = new System.Drawing.Point(515, 53);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 83;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Descrição";
            // 
            // txtDescriImagem
            // 
            this.txtDescriImagem.BackColor = System.Drawing.Color.Transparent;
            this.txtDescriImagem.BaseColor = System.Drawing.Color.DarkSlateGray;
            this.txtDescriImagem.BorderColor = System.Drawing.Color.White;
            this.txtDescriImagem.BorderSize = 1;
            this.txtDescriImagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriImagem.FocusedBaseColor = System.Drawing.Color.DarkSlateGray;
            this.txtDescriImagem.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDescriImagem.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescriImagem.Font = new System.Drawing.Font("Montserrat", 9F);
            this.txtDescriImagem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescriImagem.Location = new System.Drawing.Point(15, 16);
            this.txtDescriImagem.Multiline = true;
            this.txtDescriImagem.Name = "txtDescriImagem";
            this.txtDescriImagem.PasswordChar = '\0';
            this.txtDescriImagem.Radius = 8;
            this.txtDescriImagem.ReadOnly = true;
            this.txtDescriImagem.SelectedText = "";
            this.txtDescriImagem.Size = new System.Drawing.Size(496, 75);
            this.txtDescriImagem.TabIndex = 81;
            this.txtDescriImagem.TextOffsetX = 6;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxImage.Image = global::BravosdomaquisApp.Properties.Resources.banner;
            this.pictureBoxImage.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // FotosPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.panelDescri);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "FotosPane";
            this.Size = new System.Drawing.Size(660, 100);
            this.panelDescri.ResumeLayout(false);
            this.panelDescri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Panel panelDescri;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtDescriImagem;
        private Controls.ButtunUI btnBaixar;
        private Controls.ButtunUI btnEliminar;
    }
}
