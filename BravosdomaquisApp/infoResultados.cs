using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravosdomaquisApp
{
    public partial class infoResultados : Form
    {
        Form form;
        bool addmode;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        public infoResultados(Form formy, bool darkMode, string idCampeonato, string idJornada)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                DarkMode();
            }

            txtCampeonato.Text = idCampeonato;
            txtJornada.Text = idJornada;

            createResultsPanes(10, "", "11", "Petro de Luanda", "    Terminado", "90:00", "Bravos do Maquis", "00");
        }
        public void DarkMode()
        {
            panelResults.BackColor = Color.FromArgb(14, 18, 30);
            flowLayoutPanel.BackColor = Color.FromArgb(24, 28, 40);
            lblResultados.ForeColor = Color.Gainsboro;
        }
        public void createResultsPanes(int numJogos, string id, string GolsEquipaCasa, string EquipaCasa, string ControlTempo, string tempo, string EquipaVisitante, string GolsEquipaVisitante)
        {
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            for(int i = 0; i < numJogos; i++)
            {
                ResultadoPane resu = new ResultadoPane(id, GolsEquipaCasa, EquipaCasa, ControlTempo, tempo, EquipaVisitante, GolsEquipaVisitante);
                flowLayoutPanel.Controls.Add(resu);
            }
        
        }
    }
}
