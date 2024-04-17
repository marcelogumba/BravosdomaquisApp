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
    public partial class Jornadas : UserControl
    {
        bool modoEscuro;
        public Jornadas()
        {
            InitializeComponent();
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelJornadas.BaseColor  = Color.FromArgb(4, 8, 20);
            
            lblSelectCampeo.ForeColor = 
            lblJornadas.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelJornadas.BaseColor = Color.Gainsboro;

            lblSelectCampeo.ForeColor =
            lblJornadas.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void cbxCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCampeonato.SelectedIndex != 0)
            {
                btnAddJornadas.Enabled = btnVerJornadas.Enabled = true;
            }
            else
            {
                btnAddJornadas.Enabled = btnVerJornadas.Enabled = false;
            }
        }

        private void btnVerJornadas_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            infoJornada infoJornada = new infoJornada(formModal, modoEscuro, cbxCampeonato.SelectedItem.ToString());
            infoJornada.Show();
        }

        private void btnAddJornadas_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            AddJornadas AddJornadas = new AddJornadas(formModal, modoEscuro, cbxCampeonato.SelectedItem.ToString());
            AddJornadas.Show();
        }

        private void panelModalPontuacao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
