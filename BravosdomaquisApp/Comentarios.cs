using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class Comentarios : Form
    {
        Form form;
        bool darkmode;
        int numComent = 1;
        Object[] labelCom;
        Object[] txtCom;
        Object[] lbLinkElim;

        Label lbComent;
        Label lbEliminar;
        Guna.UI.WinForms.GunaTextBox txtComent;

        public Comentarios(Form formy, bool darkMode)
        {
            form = formy;
            darkmode = darkMode;
            InitializeComponent();
            if(darkmode){
                panelComentario.BackColor = Color.FromArgb(5, 10, 26);
                flowLayoutPanel.BackColor = Color.FromArgb(4, 8, 20);
                lblComentario.ForeColor = Color.Gainsboro;
            }
            CreateComponentes(20, "Comentador", "Coloque aqui o comentario! ");
   
            lblNumComentarios.Text = 20.ToString();
        }

        public void CreateComponentes(int numComponentes, string Comentador, string comentario)
        {
            labelCom = new Object[numComponentes];
            txtCom = new Object[numComponentes];
            lbLinkElim = new Object[numComponentes];

            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numComponentes; i++)
            {
                Label lblComentador = new Label();
                lblComentador.Text = Comentador;
                lblComentador.Font = new Font("Montserrat", 10);
                lblComentador.ForeColor = Color.LightSlateGray;
                lblComentador.TabIndex = i;
                labelCom[i] = lblComentador;

                Guna.UI.WinForms.GunaTextBox txtComentario = new Guna.UI.WinForms.GunaTextBox();
                txtComentario.Multiline = true;
                txtComentario.ReadOnly = true;
                txtComentario.BaseColor = Color.Gainsboro;
                txtComentario.FocusedBaseColor = Color.Gainsboro;
                txtComentario.BorderColor = Color.LightSlateGray;
                txtComentario.FocusedForeColor = Color.LightSlateGray;
                txtComentario.BorderSize = 1;
                txtComentario.Radius = 8;
                txtComentario.Width = 580;
                txtComentario.Height = 50;
                txtComentario.ForeColor = Color.LightSlateGray;
                txtComentario.Text = comentario + i;
                txtCom[i] = txtComentario;

                LinkLabel lblEliminar = new LinkLabel()
                {
                    Text = "Eliminar",
                    Font = new Font("Montserrat", 9),
                    TabIndex = i,
                    ForeColor = Color.LightSlateGray
                };
                lblEliminar.Click += new EventHandler(this.lblEliminar_Click);
                lbLinkElim[i] = lblEliminar;

                if (darkmode)
                {
                    txtComentario.BaseColor =
                    txtComentario.FocusedBaseColor = Color.FromArgb(4, 8, 20);
                }

                flowLayoutPanel.Controls.Add(lblComentador);
                flowLayoutPanel.Controls.Add(txtComentario);
                flowLayoutPanel.Controls.Add(lblEliminar);
            }
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        void lblEliminar_Click(object sender, EventArgs e)
        {
            showNotify(3, "Eliminado!");

            LinkLabel labelComent = sender as LinkLabel;
            labelComent.Visible = false;

            Guna.UI.WinForms.GunaTextBox txtComentario = (Guna.UI.WinForms.GunaTextBox)txtCom[labelComent.TabIndex];
            txtComentario.Visible = false;

            Label labelComentador = (Label)labelCom[labelComent.TabIndex];
            labelComentador.Visible = false;


            int num;
            int.TryParse(lblNumComentarios.Text, out num);
            num = num - 1;
            lblNumComentarios.Text = num.ToString();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
        
        }
    }
}
