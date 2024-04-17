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
    public partial class Bilhete : UserControl
    {
        bool modoEscuro;
        public Bilhete()
        {
            InitializeComponent();

            panelBilhetes.Dock = DockStyle.Fill;
            panelBilhetes.Visible = true;

            panelBilhetesNor.Dock = DockStyle.None;
            panelBilhetesNor.Visible = false;

            panelAdicionarBilhete.Dock = DockStyle.None;
            panelAdicionarBilhete.Visible = false;

            panelReservados.Dock = DockStyle.None;
            panelReservados.Visible = false;
        }
        public void darkMode()
        {
            modoEscuro = true;

            this.BackColor = Color.FromArgb(5, 10, 26);

            panelReservados.BaseColor =
            panelBilhetesNor.BaseColor =
            panelAdicionarBilhete.BaseColor =
            panelBilhetes.BaseColor = Color.FromArgb(4, 8, 20);
            
            panelSubReservados.BaseColor =
            panelSubReservados.BaseColor = 
            panelBnor.BaseColor = Color.FromArgb(14, 18, 30);

            panelCategoriasBilhetes.BaseColor = Color.FromArgb(24, 28, 40);

            cbxSelectJogoBVIP.BaseColor = cbxSelectJogoBVIP.FocusedColor =
            cbxSeletcJogoBNormal.BaseColor = cbxSeletcJogoBNormal.FocusedColor =
            txtPrecoNormal.BaseColor = txtPrecoNormal.FocusedBaseColor =
            txtPrecoVIP.BaseColor = txtPrecoVIP.FocusedBaseColor =
            panelBilheteVIP.BaseColor =
            panelBilheteNormal.BaseColor = Color.FromArgb(34, 38, 50);


            cbxSelectJogoBVIP.BorderColor = cbxSelectJogoBVIP.ForeColor =
            cbxSeletcJogoBNormal.BorderColor = cbxSeletcJogoBNormal.ForeColor =
            txtPrecoNormal.BorderColor = txtPrecoNormal.ForeColor =
            txtPrecoVIP.BorderColor = txtPrecoVIP.ForeColor =
            lblBilheteNormal.ForeColor =
            lblVIP.ForeColor = 
            lblReservados.ForeColor =
            lblBilhetesNor.ForeColor =
            lblBilhetesReservados.ForeColor = 
            lblBilhetes.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);


            cbxSelectJogoBVIP.BaseColor = cbxSelectJogoBVIP.FocusedColor =
            cbxSeletcJogoBNormal.BaseColor = cbxSeletcJogoBNormal.FocusedColor =
            txtPrecoNormal.BaseColor = txtPrecoNormal.FocusedBaseColor =
            txtPrecoVIP.BaseColor = txtPrecoVIP.FocusedBaseColor =
            panelCategoriasBilhetes.BaseColor =
            panelSubReservados.BaseColor =
            panelBilheteNormal.BaseColor =
            panelBilheteVIP.BaseColor =
            panelReservados.BaseColor =
            panelCategoriasBilhetes.BaseColor =
            panelBnor.BaseColor =
            panelBilhetesNor.BaseColor =
            panelAdicionarBilhete.BaseColor =
            panelBilhetes.BaseColor = Color.Gainsboro;

            cbxSelectJogoBVIP.BorderColor = cbxSelectJogoBVIP.ForeColor =
            cbxSeletcJogoBNormal.BorderColor = cbxSeletcJogoBNormal.ForeColor =
            txtPrecoNormal.BorderColor = txtPrecoNormal.ForeColor =
            txtPrecoVIP.BorderColor = txtPrecoVIP.ForeColor =
            lblBilheteNormal.ForeColor =
            lblVIP.ForeColor =
            lblBilhetesNor.ForeColor =
            lblBilhetesReservados.ForeColor = 
            lblBilhetes.ForeColor = Color.FromArgb(27, 87, 165);
        }
      

        private void btnVoltarr_Click(object sender, EventArgs e)
        {
            panelBilhetes.Dock = DockStyle.Fill;
            panelBilhetes.Visible = true;

            panelBilhetesNor.Dock = DockStyle.None;
            panelBilhetesNor.Visible = false;

            panelAdicionarBilhete.Dock = DockStyle.None;
            panelAdicionarBilhete.Visible = false;

            panelReservados.Dock = DockStyle.None;
            panelReservados.Visible = false;
        }

        private void btnVerGaleria_Click(object sender, EventArgs e)
        {
            panelReservados.Dock = DockStyle.Fill;
            panelReservados.Visible = true;

            panelBilhetes.Dock = DockStyle.None;
            panelBilhetes.Visible = false;

            panelBilhetesNor.Dock = DockStyle.None;
            panelBilhetesNor.Visible = false;

            panelAdicionarBilhete.Dock = DockStyle.None;
            panelAdicionarBilhete.Visible = false;
        }

        private void btnBilhetesNor_Click(object sender, EventArgs e)
        {
            panelBilhetesNor.Dock = DockStyle.Fill;
            panelBilhetesNor.Visible = true;

            panelAdicionarBilhete.Dock = DockStyle.None;
            panelAdicionarBilhete.Visible = false;

            panelBilhetes.Dock = DockStyle.None;
            panelBilhetes.Visible = false;

            panelReservados.Dock = DockStyle.None;
            panelReservados.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelBilhetes.Dock = DockStyle.Fill;
            panelBilhetes.Visible = true;

            panelBilhetesNor.Dock = DockStyle.None;
            panelBilhetesNor.Visible = false;

            panelAdicionarBilhete.Dock = DockStyle.None;
            panelAdicionarBilhete.Visible = false;

            panelReservados.Dock = DockStyle.None;
            panelReservados.Visible = false;
        }

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            lblVoltar.Visible = true;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.Visible = false;
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltarrr_MouseHover(object sender, EventArgs e)
        {
            lblVoltarrr.Visible = true;
        }

        private void btnVoltarrr_MouseLeave(object sender, EventArgs e)
        {
            lblVoltarrr.Visible = false;
        }

        private void btnAdicionarBilhete_Click(object sender, EventArgs e)
        {
            panelBilhetes.Dock = DockStyle.None;
            panelBilhetes.Visible = false;

            panelBilhetesNor.Dock = DockStyle.None;
            panelBilhetesNor.Visible = false;

            panelAdicionarBilhete.Dock = DockStyle.Fill;
            panelAdicionarBilhete.Visible = true;

            panelReservados.Dock = DockStyle.None;
            panelReservados.Visible = false;
        }

        private void btnVoltarR_MouseHover(object sender, EventArgs e)
        {
            lblVoltarR.Visible = true;
        }

        private void btnVoltarR_MouseLeave(object sender, EventArgs e)
        {
            lblVoltarR.Visible = false;
        }

        private void btnVoltarR_Click_1(object sender, EventArgs e)
        {
            panelBilhetes.Dock = DockStyle.Fill;
            panelBilhetes.Visible = true;

            panelBilhetesNor.Dock = DockStyle.None;
            panelBilhetesNor.Visible = false;

            panelAdicionarBilhete.Dock = DockStyle.None;
            panelAdicionarBilhete.Visible = false;

            panelReservados.Dock = DockStyle.None;
            panelReservados.Visible = false;
        }

        private void panelBilhetes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
