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
    public partial class ResultadoPane : UserControl
    {
        public ResultadoPane(string id, string GolsEquipaCasa, string EquipaCasa, string ControlTempo, string tempo, string EquipaVisitante, string GolsEquipaVisitante)
        {
            InitializeComponent();
            txtGolsEquipaCasa.Text = GolsEquipaCasa;
            txtEquipaCasa.Text = EquipaCasa;
            txtControlTempo.Text = ControlTempo;
            txtTempo.Text = tempo;
            txtEquipaVisitante.Text = EquipaVisitante;
            txtGolsEquipaVisitante.Text = GolsEquipaVisitante; ;
        }

        private void btnPost_MouseHover(object sender, EventArgs e)
        {
            lblPostar.Visible = true;
        }

        private void btnPost_MouseLeave(object sender, EventArgs e)
        {
            lblPostar.Visible = false;
        }

        private void lblEliminar_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblEliminar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            lblEliminar.Visible = true;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            lblEliminar.Visible = false;
        }
    }
}
