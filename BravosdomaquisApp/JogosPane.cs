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
    public partial class JogosPane : UserControl
    {
        bool flagA = true;
        int numJoogo;
        Label txtNumJogos;
        public JogosPane(Label txtNuJogos, int numjogos, int CampeonatoID, int jornadaId, int estadioID, string emblemaEqCasa, string EquipaCasa, string emblemaEqVisitante, string EquipaVisitante, string dataHora, int status)
        {
            InitializeComponent();
            //emblemaEquipaCasa.Image = Properties.Resources.clubes;
            //txtEquipaCasa.Text = EquipaCasa;
            //emblemaEquipaCasa.Image = Properties.Resources.emblemaEquipa2;
            //txtEquipaVisitante.Text = EquipaVisitante;
            //txtDataHora.Text = dataHora;
            //txtNumJogos = txtNuJogos;
            //numJoogo = numjogos;

            if (status == 1)
            {
                txtAdiadoOUTerminado.Visible = true;
                txtAdiadoOUTerminado.Text = "Terminado";
            }
            else if (status == 2)
            {
                txtAdiadoOUTerminado.Visible = true;
                txtAdiadoOUTerminado.Text = "Cancelado";
            }
            else
            {
                txtAdiadoOUTerminado.Visible = false;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            txtNumJogos.Text = (numJoogo - 1).ToString();
        }

        private void btnJogosAtuali_Click(object sender, EventArgs e)
        {
            if (flagA)
            {
                txtAdiadoOUTerminado.Visible = true;
                txtAdiadoOUTerminado.Text = "Terminado";
                flagA = false;
            }
            else
            {
                txtAdiadoOUTerminado.Visible = true;
                txtAdiadoOUTerminado.Text = "Cancelado";
                flagA = true;
            }
        }
    }
}
