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
    public partial class AddJornadas : Form
    {
        Form form;
        bool darkmode;
        public AddJornadas(Form formy, bool darkMode, string idCampeonato)
        {
            darkmode = darkMode;
            form = formy;
            InitializeComponent();
            txtCampeonato.Text = idCampeonato;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
