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
    public partial class frmInformationAjoutDepense : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmInformationAjoutDepense(Abonnements abonnee,Services service,Depenses depense)
        {
            InitializeComponent();



        }

        private void frmInformationAjoutDepense_Load(object sender, EventArgs e)
        {
           
        }
    }
}
