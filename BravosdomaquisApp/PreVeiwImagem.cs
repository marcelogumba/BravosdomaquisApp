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
    public partial class PreVeiwImagem : Form
    {
        Form form;
        bool darkmode;
        public PreVeiwImagem(Form formy, bool darkMode, string caminhoIMG)
        {
            darkmode = darkMode;
            form = formy;
           
;           InitializeComponent();
            pictureBox1.ImageLocation = caminhoIMG;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }
    }
}
