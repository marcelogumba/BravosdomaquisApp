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
    public partial class Galeria : UserControl
    {
        bool modoEscuro;
        public Galeria()
        {
            InitializeComponent();
        }
        public void darkMode()
        {
            modoEscuro = true;
            this.BackColor = Color.FromArgb(5, 10, 26);

            panelGaleria.BaseColor = Color.FromArgb(4, 8, 20);

            lblGaleria.ForeColor = Color.Gainsboro;
        }
        public void lightMode()
        {
            modoEscuro = false;

            this.BackColor = Color.FromArgb(200, 200, 200);
            
            panelGaleria.BaseColor = Color.Gainsboro;

            lblGaleria.ForeColor = Color.FromArgb(27, 87, 165);
        }
        private void btnVerGaleria_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            VerGaleria VerGaleria = new VerGaleria(formModal, modoEscuro);
            VerGaleria.Show();
        }

        private void btnAddFotos_Click(object sender, EventArgs e)
        {
            FormBackgroudModal formModal = new FormBackgroudModal();
            formModal.Show();
            AddImagens addFotos = new AddImagens(formModal, modoEscuro);
            addFotos.Show();
        }
    }
}
