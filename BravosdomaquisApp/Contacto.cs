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
    public partial class Contacto : Form
    {
        Form form;
        bool darkmode;
        Object[] panelCont;
        Object[] labelNome;
        Object[] labelEmail;
        Object[] labelAssunto;
        Object[] txtConteudo;
        Object[] lbLinkElim;

        public Contacto(Form formy, bool darkMode)
        {
            darkmode = darkMode;
            form = formy;
            InitializeComponent();
            if (darkmode)
            {
                panelContacto.BackColor = Color.FromArgb(5, 10, 26);
                flowLayoutPanel.BackColor = Color.FromArgb(4, 8, 20);
                lblContactos.ForeColor = Color.Gainsboro;
            }
            CreateComponentes(10, "Marcelo", "marcelogumba80@gmail.com", "Info", "Este é um exemplo de conteudo");
            lblNumEnviadas.Text = 10.ToString();
        }

        public void CreateComponentes(int numComponentes, string Nome, string Email, string Assunto, string Conteudo)
        {
            panelCont = new Object[numComponentes];
            labelNome = new Object[numComponentes];
            labelEmail = new Object[numComponentes];
            labelAssunto = new Object[numComponentes];
            txtConteudo = new Object[numComponentes];
            lbLinkElim = new Object[numComponentes];

            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for (int i = 0; i < numComponentes; i++)
            {
                FlowLayoutPanel flowCont = new FlowLayoutPanel();
                flowCont.FlowDirection = FlowDirection.TopDown;
                flowCont.BackColor = Color.Gainsboro;
                flowCont.Width = 550;
                flowCont.Height = 200;
                flowCont.TabIndex = i;
                flowCont.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
                this.panelCont[i] = flowCont;
                

                Label lblNome = new Label();
                lblNome.Text = "Nome: " + Nome;
                lblNome.Font = new Font("Montserrat", 10);
                lblNome.ForeColor = Color.LightSlateGray;
                lblNome.TabIndex = i;
                lblNome.AutoSize = true;
                this.labelNome[i] = lblNome;

                Label lblEmail = new Label();
                lblEmail.Text = "Email: " +Email;
                lblEmail.Font = new Font("Montserrat", 10);
                lblEmail.ForeColor = Color.LightSlateGray;
                lblEmail.TabIndex = i;
                lblEmail.AutoSize = true;
                this.labelEmail[i] = lblEmail;

                Label lblAssunto = new Label();
                lblAssunto.Text = "Assunto: " + Assunto;
                lblAssunto.Font = new Font("Montserrat", 10);
                lblAssunto.ForeColor = Color.LightSlateGray;
                lblAssunto.TabIndex = i;
                lblAssunto.AutoSize = true;
                this.labelAssunto[i] = lblAssunto;

                Guna.UI.WinForms.GunaTextBox txtConteudo = new Guna.UI.WinForms.GunaTextBox();
                txtConteudo.Multiline = true;
                txtConteudo.ReadOnly = true;
                txtConteudo.ForeColor = Color.LightSlateGray;
                txtConteudo.BaseColor = Color.Gainsboro;
                txtConteudo.FocusedBaseColor = Color.Gainsboro;
                txtConteudo.BorderColor = Color.LightSlateGray;
                txtConteudo.FocusedForeColor = Color.LightSlateGray;
                txtConteudo.BorderSize = 1;
                txtConteudo.Radius = 8;
                txtConteudo.Width = 500;
                txtConteudo.Height = 90;
                txtConteudo.Text = Conteudo + i;
                txtConteudo.TabIndex = i;
                txtConteudo.SetOnLostFocus();
                this.txtConteudo[i] = txtConteudo;

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
                    txtConteudo.BaseColor = 
                    txtConteudo.FocusedBaseColor = 
                    flowCont.BackColor = Color.FromArgb(14, 18, 30);
                }

                flowCont.Controls.Add(lblNome);
                flowCont.Controls.Add(lblEmail);
                flowCont.Controls.Add(lblAssunto);
                flowCont.Controls.Add(txtConteudo);
                flowCont.Controls.Add(lblEliminar);
                flowLayoutPanel.Controls.Add(flowCont);
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

            LinkLabel labelEliminar = sender as LinkLabel;
            labelEliminar.Visible = false;

            Guna.UI.WinForms.GunaTextBox txtConteudo = (Guna.UI.WinForms.GunaTextBox)this.txtConteudo[labelEliminar.TabIndex];
            txtConteudo.Visible = false;

            Label lblNome = (Label)labelNome[labelEliminar.TabIndex];
            lblNome.Visible = false;

            Label lblEmail = (Label)labelEmail[labelEliminar.TabIndex];
            lblEmail.Visible = false;

            Label lblAssunto = (Label)labelAssunto[labelEliminar.TabIndex];
            lblAssunto.Visible = false;

            FlowLayoutPanel flow = (FlowLayoutPanel)this.panelCont[labelEliminar.TabIndex];
            flow.Visible = false;

            int num;
            int.TryParse(lblNumEnviadas.Text, out num);
            num = num - 1;
            lblNumEnviadas.Text = num.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
