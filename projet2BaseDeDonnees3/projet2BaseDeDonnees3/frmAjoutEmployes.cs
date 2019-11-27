using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet2BaseDeDonnees3
{
    public partial class frmAjoutEmployes : Form
    {
        public frmAjoutEmployes()
        {
            InitializeComponent();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmerAjout_Click(object sender, EventArgs e)
        {

        }
    }
}
