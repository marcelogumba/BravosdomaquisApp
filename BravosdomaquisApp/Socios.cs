using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class Socios : UserControl
    {
        bool modoEscuro;
        public Socios()
        {
            InitializeComponent();

            personalizarBindingSource.Add(new Personalizar() { ID = "1", Nome = "Margareth de Souza", Tipo_Socio = "Sócio majoritário" });
            personalizarBindingSource.Add(new Personalizar() { ID = "2", Nome = "João Luís da Costa", Tipo_Socio = "Sócio minoritário" });

            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;

            panelAprovReproNotify.Width = 919; ;
        }

        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }

        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelVerSociosExistentes.BaseColor = panelVerSociosInscritos.BaseColor =
            panelSocios.BaseColor = Color.FromArgb(4, 8, 20);

            panelSociosInscritos.BaseColor =
            panelSociosExistentes.BaseColor = Color.FromArgb(14, 18, 30);

            txtMensagemMotivacao.FocusedBaseColor =
            btnVerAnexo1.BaseColor = btnVerAnexo2.BaseColor = txtMensagemMotivacao.BaseColor = 
            panelAprovReproNotify.BaseColor = Color.FromArgb(24, 28, 40);

            txtNomeSocioInscri.ForeColor = txtAnexo1.ForeColor =
            txtAnexo2.ForeColor = txtEmailSocioInscri.ForeColor =
            txtTelefoneSocioInscri.ForeColor = txtTipoSocio.ForeColor =

            lblTipoSocio.ForeColor =
            lblNome.ForeColor = lblAnexo1.ForeColor = lblAnexo2.ForeColor =
            lblTelefone.ForeColor = lblemail.ForeColor =

            lblFecharMensagemMot.ForeColor =
            lblDetalhesInscri.ForeColor = lblSMSMotivacao.ForeColor = 
            lblSociosexis.ForeColor = lblSocIncri.ForeColor =
            lblSocios.ForeColor = lblDesciSocios.ForeColor 
            = Color.Gainsboro;
        }

        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            btnVerAnexo1.BaseColor = btnVerAnexo2.BaseColor =
            panelVerSociosExistentes.BaseColor = panelVerSociosInscritos.BaseColor =
            panelSocios.BaseColor = 

            panelSociosInscritos.BaseColor =
            panelSociosExistentes.BaseColor =

            txtMensagemMotivacao.BaseColor = txtMensagemMotivacao.FocusedBaseColor =
            panelAprovReproNotify.BaseColor = Color.Gainsboro;


            txtNomeSocioInscri.ForeColor = txtAnexo1.ForeColor =
            txtAnexo2.ForeColor = txtEmailSocioInscri.ForeColor =
            txtTelefoneSocioInscri.ForeColor = txtTipoSocio.ForeColor =

            lblTipoSocio.ForeColor =
            lblNome.ForeColor = lblAnexo1.ForeColor = lblAnexo2.ForeColor =
            lblTelefone.ForeColor = lblemail.ForeColor = 

            lblFecharMensagemMot.ForeColor =
            lblDetalhesInscri.ForeColor = lblSMSMotivacao.ForeColor =
            lblSociosexis.ForeColor = lblSocIncri.ForeColor =
            lblSocios.ForeColor = lblDesciSocios.ForeColor
            = Color.FromArgb(27, 87, 165);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalhesInscricaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSociosInscritos.Visible = false;
            panelAprovReproNotify.Visible = true;
        }

        private void lblBtnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblVoltarr_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnVoltarr_MouseHover(object sender, EventArgs e)
        {
            lblVoltarr.Visible = true;
        }

        private void btnVoltarr_MouseLeave(object sender, EventArgs e)
        {
            lblVoltarr.Visible = false;
        }

        private void btnVoltarr_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;
            
            panelAprovReproNotify.Visible = false;
            DataGridViewSociosInscritos.Visible = true;
        }

        private void btnVerSociosInscritos_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = true;
            panelVerSociosInscritos.Dock = DockStyle.Fill;

            panelSocios.Visible = false;
            panelSocios.Dock = DockStyle.None;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;
        }

        private void DataGridViewPontuacoes_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void DataGridViewSociosInscritos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int linhaEmCausa = DataGridViewSociosInscritos.HitTest(e.X, e.Y).RowIndex;
                if (linhaEmCausa >= 0)
                {
                    contextMenuDataGrid.Show(DataGridViewSociosInscritos, new Point(e.X, e.Y));
                }
            }
        }

        private void btnCancelarr_MouseHover(object sender, EventArgs e)
        {
            lblCancelarr.Visible = true;
        }

        private void btnCancelarr_MouseLeave(object sender, EventArgs e)
        {
            lblCancelarr.Visible = false;
        }

        private void btnCancelarr_Click(object sender, EventArgs e)
        {
            DataGridViewSociosInscritos.Visible = true;
            panelAprovReproNotify.Visible = false;
        }

        private void btnVoltarSocios_MouseHover(object sender, EventArgs e)
        {
            lblVoltarSoc.Visible = true;
        }

        private void btnVoltarSocios_MouseLeave(object sender, EventArgs e)
        {
            lblVoltarSoc.Visible = false;
        }

        private void btnVoltarSocios_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;
        }

        private void btnVerSocios_Click(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = false;
            panelSocios.Dock = DockStyle.None;

            panelVerSociosExistentes.Visible = true;
            panelVerSociosExistentes.Dock = DockStyle.Fill;
        }


       

        private void btnAprovar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            if (modoEscuro)
            {
                ModalSMS sms = new ModalSMS(formModal, true);
                sms.Show();
            }
            else
            {
                ModalSMS sms = new ModalSMS(formModal, false);
                sms.Show();
            }
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            showNotify(1, "Mensagem enviada");
        }

        private void Socios_Load(object sender, EventArgs e)
        {
           
        }

        private void Socios_VisibleChanged(object sender, EventArgs e)
        {
            panelVerSociosInscritos.Visible = false;
            panelVerSociosInscritos.Dock = DockStyle.None;

            panelSocios.Visible = true;
            panelSocios.Dock = DockStyle.Fill;

            panelVerSociosExistentes.Visible = false;
            panelVerSociosExistentes.Dock = DockStyle.None;

            lblInfoListaSociosInscri.Visible = lblSocIncri.Visible =
          DataGridViewSociosInscritos.Visible = true;
            panelAprovReproNotify.Visible = false;
        }

        private void DataGridViewSociosInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridViewSociosInscritos.Columns[e.ColumnIndex].Name == "ViewDetail")
            {
                panelAprovReproNotify.Visible = true;
                lblInfoListaSociosInscri.Visible = lblSocIncri.Visible = true;

                txtTipoSocio.Text = DataGridViewSociosInscritos.CurrentRow.Cells[2].Value.ToString();
                txtNomeSocioInscri.Text = DataGridViewSociosInscritos.CurrentRow.Cells[1].Value.ToString();
             
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            showNotify(3, "Sem nenhum documento!");
        }

        private void btnVerAnexo2_Click(object sender, EventArgs e)
        {
            showNotify(3, "Sem nenhum documento!");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBoxImagSocio.Visible = true;
           txtMensagemMotivacao.Visible = lblFecharMensagemMot.Visible =
           lblDaTxtSMSMotivcacao.Visible = false;
           
        }

        private void lbLinkSMSMotivacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxImagSocio.Visible = false;
            txtMensagemMotivacao.Visible = lblFecharMensagemMot.Visible =
             lblDaTxtSMSMotivcacao.Visible = true;
        }

        private void panelVerSociosInscritos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSociosInscritos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 