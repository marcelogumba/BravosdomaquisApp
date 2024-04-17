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
    public partial class Inicio : UserControl
    {
        bool modoEscuro;
        public Inicio()
        {
            InitializeComponent();
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);
          
            panelSuperior.BaseColor = panelBase.BaseColor = Color.FromArgb(14, 18, 30);

            panelInfoBravo.BaseColor = Color.FromArgb(24, 28, 40);

            lblInfoBravos.ForeColor = 
            lblCTitulo.ForeColor = Color.Gainsboro;

        }
        public void lightMode()
        {
            modoEscuro = false;
            this.BackColor = Color.FromArgb(200, 200, 200);
           
            panelSuperior.BaseColor = panelBase.BaseColor = 
            panelInfoBravo.BaseColor = Color.Gainsboro;

            lblInfoBravos.ForeColor = 
            lblCTitulo.ForeColor = Color.FromArgb(27, 87, 165);

        }
        private void btnInfoClube_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            InfoClubes InfoClubes = new InfoClubes(formModal, modoEscuro, "");
            InfoClubes.Show();
        }

        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInfoBravos_Click(object sender, EventArgs e)
        {

        }
    }
}
