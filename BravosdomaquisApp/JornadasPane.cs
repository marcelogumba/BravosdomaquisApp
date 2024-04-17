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
    public partial class JornadasPane : UserControl
    {
        public JornadasPane(string idJornada, string NumJornada, string JogosDisputados, string TotalJogos, bool Status)
        {
            InitializeComponent();
            txtNºJornada.Text = NumJornada;
            txtTotalJogosDisputados.Text = JogosDisputados;
            txtTotalJogosdaJornadas.Text = TotalJogos;
            if (Status)
            {
                txtStatus.Text = "Finalizada";
            }
            else
            {
                txtStatus.Text = "Decorrendo";
            }
            
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            lblEliminar.Visible = true;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            lblEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnPost_MouseHover(object sender, EventArgs e)
        {
            lblPostar.Visible = true;
        }

        private void btnPost_MouseLeave(object sender, EventArgs e)
        {
            lblPostar.Visible = false;
        }
    }
}
