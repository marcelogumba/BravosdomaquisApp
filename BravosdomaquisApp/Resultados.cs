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
    public partial class Resultados : UserControl
    {
        bool modoEscuro;
        public Resultados()
        {
            InitializeComponent();
        }

        private void btnVerPontuaçoes_Click(object sender, EventArgs e)
        {
         
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            infoResultados results = new infoResultados(formModal, modoEscuro, cbxCampeonato.SelectedItem.ToString(), cbxJornada.SelectedItem.ToString());
            results.Show();
            cbxCampeonato.SelectedIndex = cbxJornada.SelectedIndex = 0;
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelResultados.BaseColor = Color.FromArgb(4, 8, 20);

            lblResultados.ForeColor = lblSelectCampeo.ForeColor =
            lblSelectJornada.ForeColor = Color.Gainsboro;
        }
        public void lightMode() 
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelResultados.BaseColor = Color.Gainsboro;

            lblResultados.ForeColor = lblSelectCampeo.ForeColor =
            lblSelectJornada.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void cbxJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cbxJornada.SelectedIndex == 0)
                {
                    btnVerResultados.Enabled = false;
                }
                else
                {
                    btnVerResultados.Enabled = true;
                }
        }

        private void btnJogosAdecorrer_MouseHover(object sender, EventArgs e)
        {
            lblJogosAde.Visible = true;
        }

        private void btnJogosAdecorrer_MouseLeave(object sender, EventArgs e)
        {
            lblJogosAde.Visible = false;
        }

        private void btnJogosAdecorrer_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            VerJogosDecorrer verDecorr = new VerJogosDecorrer(formModal, modoEscuro);
            verDecorr.Show();
        }

        private void cbxCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCampeonato.SelectedIndex == 0)
            {
                cbxJornada.Enabled = false;
            }
            else
            {
                cbxJornada.Enabled = true;
            }
        }
    }
}
