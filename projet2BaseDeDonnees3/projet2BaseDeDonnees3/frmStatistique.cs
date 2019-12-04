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
    public partial class frmStatistique : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmStatistique()
        {
            InitializeComponent();
        }

        private void frmStatistique_Load(object sender, EventArgs e)
        {
            IEnumerable<int> moisAnneeCourante = Enumerable.Range(1, 12);

            AbonnementParTypeEtParAnneeBindingSource.DataSource = from typeAbonnement in dataContext.TypesAbonnement
                                                                  from annee in dataContext.Abonnements.Select(abonnement => abonnement.DateAbonnement.Year).Distinct()
                                                                  select new AbonnementParTypeEtParAnnee
                                                                  {
                                                                      no = typeAbonnement.No,
                                                                      description = typeAbonnement.Description,
                                                                      annee = annee,
                                                                      nbAbonnements = typeAbonnement.Abonnements.Where(abonnement => abonnement.DateAbonnement.Year == annee).Count()
                                                                  };

            AbonnementParMoisCourantEtTypeAbonnementBindingSource.DataSource = from typeAbonnement in dataContext.TypesAbonnement.AsEnumerable()
                                                                               from mois in Enumerable.Range(1, 12)
                                                                               select new AbonnementParMoisCourantEtTypeAbonnement
                                                                               {
                                                                                   no = typeAbonnement.No,
                                                                                   description = typeAbonnement.Description,
                                                                                   mois = mois,
                                                                                   nbAbonnements = typeAbonnement.Abonnements.Where(abonnement => abonnement.DateAbonnement.Month == mois && abonnement.DateAbonnement.Year == DateTime.Now.Year).Count()
                                                                               };


            PartieJoueeParAnneEtParTerrainBindingSource.DataSource = from terrains in dataContext.Terrains
                                                                     from annee in dataContext.PartiesJouees.Select(partieJouee => partieJouee.DatePartie.Year).Distinct()
                                                                     select new PartieJoueeParAnneEtParTerrain
                                                                     {
                                                                         no = terrains.No,
                                                                         annee = annee,
                                                                         nom = terrains.Nom,
                                                                         nbPartiesJouees = terrains.PartiesJouees.Where(partieJouee => partieJouee.DatePartie.Year == annee).Count()
                                                                     };


            PartieJoueParMoisCOurantEtTerrainBindingSource.DataSource = from terrains in dataContext.Terrains.AsEnumerable()
                                                                        from mois in Enumerable.Range(1, 12)
                                                                        select new PartieJoueParMoisCOurantEtTerrain
                                                                        {
                                                                            no = terrains.No,
                                                                            mois = mois,
                                                                            nom = terrains.Nom,
                                                                            nbPartiesJouees = terrains.PartiesJouees.Where(partieJoue => partieJoue.DatePartie.Month == mois && partieJoue.DatePartie.Year == DateTime.Now.Year).Count()
                                                                        };

            DepensesParAnneeEtParAbonnementBindingSource.DataSource = from abonnements in dataContext.Abonnements
                                                                      from annee in dataContext.Depenses.Select(depenses => depenses.DateDepense.Year).Distinct()
                                                                      select new DepensesParAnneeEtParAbonnement
                                                                      {
                                                                          no = abonnements.Id,
                                                                          idEtNomComplet = abonnements.Id + " - " + abonnements.Nom + ", " + abonnements.Prenom,
                                                                          annee = annee,
                                                                          sumDepenses = abonnements.Depenses.Where(depense => depense.DateDepense.Year == annee).Count()
                                                                      };

            DepenseParMoisCourantEtParAbonnementBindingSource.DataSource = from abonnements in dataContext.Abonnements.AsEnumerable()
                                                                           from mois in Enumerable.Range(1, 12)
                                                                           select new DepenseParMoisCourantEtParAbonnement
                                                                           {
                                                                               no = abonnements.Id,
                                                                               idEtNomComplet = abonnements.Id + " - " + abonnements.Nom + ", " + abonnements.Prenom,
                                                                               mois = mois,
                                                                               sumDepenses = abonnements.Depenses.Where(depense => depense.DateDepense.Year == DateTime.Now.Year && depense.DateDepense.Month == mois).Count()
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
