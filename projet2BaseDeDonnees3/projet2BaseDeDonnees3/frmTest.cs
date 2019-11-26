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
    public partial class frmTest : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }
    }
}
