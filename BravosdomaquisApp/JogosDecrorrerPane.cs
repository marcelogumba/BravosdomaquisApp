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
    public partial class JogosDecrorrerPane : UserControl
    {
        int golsCasa = 0, golsFora = 0;
        public JogosDecrorrerPane(int campeonatoID, int jornadaID, int estadioID, string EquipaCasa, int golsEquipaCasa, string estadoJogo, string tempo, string EquipaVisitante, int golsVisitante)
        {
            InitializeComponent();

            txtGolsEquipaCasa.Text = "0" + golsCasa;
            TxtGolsEquipaVisitante.Text = "0" + golsFora;
        }

        public JogosDecrorrerPane()
        {
            InitializeComponent();

            txtGolsEquipaCasa.Text = "0" + golsCasa;
            TxtGolsEquipaVisitante.Text = "0" + golsFora;
        }
        private void btnMenosFora_Click(object sender, EventArgs e)
        {
            if(golsFora >= 1)
            {
                if (golsFora >= 9)
                {
                    golsFora -= 1;
                    TxtGolsEquipaVisitante.Text = golsFora.ToString();
                }
                else
                {
                    golsFora -= 1;
                    TxtGolsEquipaVisitante.Text = "0" + golsFora.ToString();
                }
            }           
        }

        private void btnMaisCasa_Click(object sender, EventArgs e)
        {
            if (golsCasa >= 9)
            {
                golsCasa += 1;
                txtGolsEquipaCasa.Text = golsCasa.ToString();
            }
            else
            {
                golsCasa += 1;
                txtGolsEquipaCasa.Text = "0" + golsCasa.ToString();
            }
    }

        private void btnMenosCasa_Click(object sender, EventArgs e)
        {
            if (golsCasa >= 1)
            {
                if (golsCasa >= 9)
                {
                    golsCasa -= 1;
                    txtGolsEquipaCasa.Text = golsCasa.ToString();
                }
                else
                {
                    golsCasa -= 1;
                    txtGolsEquipaCasa.Text = "0" + golsCasa.ToString();
                }
            }
        }

        private void btnPost_MouseHover(object sender, EventArgs e)
        {
            lblAtualizar.Visible = true;
        }

        private void btnPost_MouseLeave(object sender, EventArgs e)
        {
            lblAtualizar.Visible = false;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            lblEliminar.Visible = true;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            lblEliminar.Visible = false;
        }

        private void btnMaisFora_Click(object sender, EventArgs e)
        {
            if(golsFora  >= 9)
            {
                golsFora += 1;
                TxtGolsEquipaVisitante.Text = golsFora.ToString();
            }
            else
            {
                golsFora += 1;
                TxtGolsEquipaVisitante.Text = "0"+ golsFora.ToString();
            }
        }
    }
}
