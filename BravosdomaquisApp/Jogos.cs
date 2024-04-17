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
    
    public partial class Jogos : UserControl
    {
        bool modoEscuro;
        public Jogos()
        {
            InitializeComponent();
        }

        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelCampeonato.BaseColor = Color.FromArgb(4, 8, 20);

            lblSelectJornada.ForeColor = lblSelectCampeo.ForeColor =
          lblJogos.ForeColor = Color.Gainsboro;
           
        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);

            panelCampeonato.BaseColor = Color.Gainsboro;
            
            panelCampeonato.BaseColor = Color.Gainsboro;

            lblSelectJornada.ForeColor = lblSelectCampeo.ForeColor =
            lblJogos.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void buttunUI1_Click(object sender, EventArgs e)
        {

        }

        private void gunaShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaVSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtJornadasPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
        }

        private void panelJogo4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelJogo5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lblMinuto_Click(object sender, EventArgs e)
        {

        }

        private void cbxJornadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxJornadas.SelectedIndex != 0)
            {
                btnAddJogos.Enabled = btnVerJogos.Enabled = true;
            }
            else
            {
                btnAddJogos.Enabled = btnVerJogos.Enabled = false;
            }
        }

        private void btnAddJogos_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            AddJogos AddJogos = new AddJogos(formModal, modoEscuro, cbxCampeonato.SelectedItem.ToString(), cbxJornadas.SelectedItem.ToString());
            AddJogos.Show();
        }

        private void btnVerJogos_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            VerJogos VerJogos = new VerJogos(formModal, modoEscuro, cbxCampeonato.SelectedItem.ToString(), cbxJornadas.SelectedItem.ToString());
            VerJogos.Show();
        }
        

        private void cbxCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCampeonato.SelectedIndex != 0)
            {
                cbxJornadas.Enabled = true;
            }
            else
            {
                cbxJornadas.Enabled = false;
                btnAddJogos.Enabled = btnVerJogos.Enabled = false;
                cbxJornadas.SelectedIndex = 0;
            }
        }
    }
}
