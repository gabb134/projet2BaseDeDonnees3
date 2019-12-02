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
    public partial class frmRapports : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmRapports()
        {
            InitializeComponent();
        }

        private void frmRapports_Load(object sender, EventArgs e)
        {

            DepenseParEmployeBindingSource.DataSource = from depense in dataContext.Depenses
                                                        select new DepenseParEmploye
                                                        {
                                                            montant = depense.Montant,
                                                            dateDepense = depense.DateDepense,
                                                            typeService = depense.Services.TypesService,
                                                            nomCompletEmploye = depense.Services.Employes.Prenom + ", " + depense.Services.Employes.Nom,
                                                            nomCompletAbonne = depense.Abonnements.Prenom + ", " + depense.Abonnements.Nom,
                                                            annee = depense.DateDepense.Year
                                                        };

            PartieJoueeParTerrainBindingSource.DataSource = from partieJouee in dataContext.PartiesJouees
                                                            select new PartieJoueeParTerrain
                                                            {
                                                                pointage = partieJouee.Pointage,
                                                                date = partieJouee.DatePartie,
                                                                nomTerrain = partieJouee.Terrains.Nom,
                                                                nomCompletAbonne = partieJouee.Abonnements.Prenom + ", " + partieJouee.Abonnements.Nom,
                                                                annee = partieJouee.DatePartie.Year
                                                            };

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }
    }
}
