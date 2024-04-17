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
    public partial class TelaProgress : Form
    {
        Form form;
        public TelaProgress(Form formy, bool darkMode)
        {
            form = formy;
            InitializeComponent();
            progressCircle.Show();
            if (darkMode)
            {
                this.BackColor = Color.FromArgb(14, 18, 30);
                progressCircle.ProgressColor = Color.Gainsboro;
            }
        }
    }
}
