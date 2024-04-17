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
    public partial class AddImagens : Form
    {
        Form form;
        public AddImagens(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                DarkMode();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
        public void DarkMode()
        {
            btnVerAnexo1.BaseColor =
            txtDescricao.BaseColor = txtDescricao.FocusedBaseColor =
            panelAddImagens.BaseColor = Color.FromArgb(14, 18, 30);

            txtAnexo1.ForeColor = lblAnexo1.ForeColor =
            lblTituloPanel.ForeColor = Color.Gainsboro;
        }
    }
}
