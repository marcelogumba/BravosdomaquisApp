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
    public partial class Pontuação : UserControl
    {
        bool modoEscuro;
        public Pontuação()
        {
            InitializeComponent();
            panelModalPontuacao.Visible = true;
            panelModalPontuacao.Dock = DockStyle.Fill;

            panelVerPontuacoes.Visible = false;
            panelVerPontuacoes.Dock = DockStyle.None;
            
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelEditar.BaseColor = Color.FromArgb(24, 28, 40);
            panelModalPontuacao.BaseColor = panelVerPontuacoes.BaseColor = Color.FromArgb(4, 8, 20);

            
            lblCampeonatoSelecionado.BackColor = 
            panelCentralVerPontuacoes.BaseColor = Color.FromArgb(14, 18, 30);

            lblCampeonatoSelecionado.ForeColor = lblPostarPontuacoes.ForeColor =

            lblPontuaçao.ForeColor = lblSelectCampeo.ForeColor =
            //panel5.BackColor = panel4.BackColor =
            lblInfoSelectCampeo.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);
            
            panelModalPontuacao.BaseColor = panelVerPontuacoes.BaseColor = Color.Gainsboro;

            lblCampeonatoSelecionado.BackColor = panelEditar.BaseColor = 
            panelCentralVerPontuacoes.BaseColor = Color.Gainsboro;

            lblCampeonatoSelecionado.ForeColor = lblPostarPontuacoes.ForeColor =
            lblPontuaçao.ForeColor = lblSelectCampeo.ForeColor = Color.FromArgb(27, 87, 165);

            //panel5.BackColor = panel4.BackColor =
            lblInfoSelectCampeo.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void timerAtualiza_Tick(object sender, EventArgs e)
        {

            if (cbxCampeonato.SelectedItem.ToString() == "Selecione")
            {
               btnVerPontuaçoes.Enabled = false;
            }
            else
            {
                 btnVerPontuaçoes.Enabled = true;
            }
        }

        private void panelModalPontuacao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            lblVoltar.Visible = true;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelModalPontuacao.Visible = true;
            panelModalPontuacao.Dock = DockStyle.Fill;

            panelVerPontuacoes.Visible = false;
            panelVerPontuacoes.Dock = DockStyle.None;
        }

        private void btnVerPontuaçoes_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            VerPontuacoes pont = new VerPontuacoes(formModal, modoEscuro, 1);
            pont.Show();

            //panelModalPontuacao.Visible = false;
            //panelModalPontuacao.Dock = DockStyle.None;

            //panelVerPontuacoes.Visible = true;
            //panelVerPontuacoes.Dock = DockStyle.Fill;

            //lblCampeonatoSelecionado.Text = cbxCampeonato.SelectedItem.ToString();
        }
        
        private void panelVerPontuacoes_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void DataGridViewPontuacoes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int linhaEmCausa = DataGridViewPontuacoes.HitTest(e.X, e.Y).RowIndex;
                if(linhaEmCausa >= 0)
                {
                    contextMenuDataGrid.Show(DataGridViewPontuacoes, new Point(e.X, e.Y));
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
     

     
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DataGridViewPontuacoes.Width = 858;
        }

        private void btnCancelar_MouseHover_1(object sender, EventArgs e)
        {
            lblBtnCancelar.Visible = true;
        }

        private void btnCancelar_MouseLeave_1(object sender, EventArgs e)
        {
            lblBtnCancelar.Visible = false;
        }

        private void editarPontuacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewPontuacoes.Width = 460;
        }
    }
}
