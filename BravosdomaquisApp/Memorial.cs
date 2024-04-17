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
    public partial class Memorial : UserControl
    {
        bool modoEscuro;
        public Memorial()
        {
            InitializeComponent();
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelMemorial.BaseColor = Color.FromArgb(4, 8, 20);

            lblMemorial.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);

            panelMemorial.BaseColor = Color.Gainsboro;

            lblMemorial.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void btnAddMemorial_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            AddMemoria AddMemoria = new AddMemoria(formModal, modoEscuro);
            AddMemoria.ShowDialog();
        }

        private void btnVerGaleria_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            VerMemorial VerMemorial = new VerMemorial(formModal, modoEscuro);
            VerMemorial.Show();
        }
    }
}
