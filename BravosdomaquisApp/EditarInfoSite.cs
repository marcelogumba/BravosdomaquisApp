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
    public partial class EditarInfoSite : Form
    {
        Form form;
        public EditarInfoSite(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                txtEmail.BaseColor = txtEmail.FocusedBaseColor =
                txtTelefone.BaseColor = txtTelefone.FocusedBaseColor =
                txtEndereco1.BaseColor = txtEndereco1.FocusedBaseColor =
                txtEndereco2.BaseColor = txtEndereco2.FocusedBaseColor =
                txtInstagram.BaseColor = txtInstagram.FocusedBaseColor =
                txtLinkFacebook.BaseColor = txtLinkFacebook.FocusedBaseColor =
                txtLinkGMaps.BaseColor = txtLinkGMaps.FocusedBaseColor =
                txtLinkLinkedin.BaseColor = txtLinkLinkedin.FocusedBaseColor =
                txtLinkTwitter.BaseColor = txtLinkTwitter.FocusedBaseColor =
                txtLinkYoutube.BaseColor = txtLinkYoutube.FocusedBaseColor =
                panelAllThinks.BaseColor = Color.FromArgb(14, 18, 30);


                lblSubTitulo.ForeColor = Color.Gainsboro;
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
