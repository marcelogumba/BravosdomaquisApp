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
    public partial class AddJogos : Form
    {
        Form form;
        bool darkmode;
        public AddJogos(Form formy, bool darkMode, string idCampeonato, string numJornada)
        {
            darkmode = darkMode;
            form = formy;
            InitializeComponent();

            txtNomeCampeonato.Text = idCampeonato;
            txtNumJornada.Text = numJornada;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
