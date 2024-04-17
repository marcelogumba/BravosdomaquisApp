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
    public partial class CriarConta : Form
    {
        Form form;
        public CriarConta(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                txtNomeCompleto.BaseColor = txtNomeCompleto.FocusedBaseColor =
                txtTelefone.BaseColor = txtTelefone.FocusedBaseColor =
                txtemail.BaseColor = txtemail.FocusedBaseColor =
                txtPalavraPasse1.BaseColor = txtPalavraPasse1.FocusedBaseColor =
                txtPalavrapasse2.BaseColor = txtPalavrapasse2.FocusedBaseColor =
                txtNomeUtilizador.BaseColor = txtNomeUtilizador.FocusedBaseColor =
                panelCriarConta.BaseColor = Color.FromArgb(10, 19, 48);

                lblCriarConta.ForeColor = Color.Gainsboro;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
