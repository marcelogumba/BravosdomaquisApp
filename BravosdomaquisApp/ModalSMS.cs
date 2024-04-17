using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BravosdomaquisApp
{
    public partial class ModalSMS : Form
    {
        Form form;
       
        public ModalSMS(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();

            if (darkMode)
            {
                txtMensagem.BaseColor = txtMensagem.FocusedBaseColor =
                panelSMS.BaseColor = Color.FromArgb(24, 28, 40);
                lblEnviarNotify.ForeColor =
                    Color.Gainsboro;
            }
            else
            {
                txtMensagem.BaseColor = txtMensagem.FocusedBaseColor =
               panelSMS.BaseColor = Color.Gainsboro;
                lblEnviarNotify.ForeColor = Color.FromArgb(27, 87, 165);
               
            }
        }
        public void showNotify(int tipo, string mensagem)
        {
            // tipo : 1 - seucesso, 2 - Info, 3 - Aviso
            Notification notify = new Notification(tipo, mensagem);
            notify.Show();
        }
        private void panelSMS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFecharSMS_MouseHover(object sender, EventArgs e)
        {
            lblFecharSMS.Visible = true;

        }

        private void btnFecharSMS_MouseLeave(object sender, EventArgs e)
        {
            lblFecharSMS.Visible = false;
        }

        private void btnFecharSMS_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            showNotify(1, "Mensagem enviada");
        }
    }
}
