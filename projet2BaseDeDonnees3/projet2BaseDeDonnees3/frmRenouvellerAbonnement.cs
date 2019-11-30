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
    public partial class frmRenouvellerAbonnement : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmRenouvellerAbonnement()
        {
            InitializeComponent();
        }

        private void frmRenouvellerAbonnement_Load(object sender, EventArgs e)
        {
            abonnementsBindingSource.DataSource =
                (from abonnement in dataContext.Abonnements
                 where !abonnement.Reabonnements.Any()
                 where DateTime.Today > abonnement.DateAbonnement.AddYears(1)
                 select abonnement).Union(from abonnement in dataContext.Abonnements
                                          where abonnement.Reabonnements.Any()
                                          where abonnement.Reabonnements.All(reabonnement =>
                                          DateTime.Today > reabonnement.DateRenouvellement.AddYears(1))
                                          select abonnement);
        }
    }
}
