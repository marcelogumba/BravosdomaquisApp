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
    public partial class FormBackgroudModal : Form
    {
        public FormBackgroudModal()
        {
            InitializeComponent();
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBackgroudModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
