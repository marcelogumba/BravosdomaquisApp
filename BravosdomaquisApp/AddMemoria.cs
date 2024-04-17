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
    public partial class AddMemoria : Form
    {
        Form form;
        public AddMemoria(Form formy, bool darkMode)
        {
          
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                DarkMode();
            }
        }
        public void DarkMode()
        {
            txtNome.BaseColor = txtNome.FocusedBaseColor =
               txtFuncao.BaseColor = txtFuncao.FocusedBaseColor =
          txtNome.BaseColor = txtNome.FocusedBaseColor =
            dtpSelectDataNascim.BaseColor = dtpSelectDataNascim.OnHoverBaseColor =
               dtpSelectDataMorte.BaseColor = dtpSelectDataMorte.OnHoverBaseColor =
               btnVerAnexo1.BaseColor=
            panelAddMemorial.BaseColor = Color.FromArgb(14, 18, 30);

            dtpSelectDataMorte.ForeColor =
            dtpSelectDataNascim.ForeColor =
            lblAnexo1.ForeColor = txtAnexo1.ForeColor =
            lblTituloPanel.ForeColor = Color.Gainsboro;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
