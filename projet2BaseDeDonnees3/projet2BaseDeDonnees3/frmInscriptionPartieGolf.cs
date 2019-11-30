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
    public partial class frmInscriptionPartieGolf : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmInscriptionPartieGolf()
        {
            InitializeComponent();
        }

        private void frmInscriptionPartieGolf_Load(object sender, EventArgs e)
        {

            //chargement des id et nomComplet
            this.abonnementIdEtNomCompletBindingSource.DataSource = from abonnement in dataContext.Abonnements
                                                               
                                                               select new { idAbonneePrincipal = abonnement.Id, idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom };

            //chargement des terrains = 
            this.terrainsBindingSource.DataSource = from noTerrain in dataContext.Terrains
                                         select noTerrain.Nom;
           

        }

        private void btnInscriptionPartie_Click(object sender, EventArgs e)
        {
            //ajouter la partie jouer

            PartiesJouees nouvellePartie = new PartiesJouees();


            //requete qui me permet d'aller chercher tout les personnes qui ont besoin de se reabonneee


            var abonnementReabonnee = (from abonnement in dataContext.Abonnements
                                       where !abonnement.Reabonnements.Any()
                                       where DateTime.Today > abonnement.DateAbonnement.AddYears(1)
                                       select new
                                       {
                                           idAbonneePrincipal = abonnement.Id,
                                           idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom
                                       }).Union(from abonnement in dataContext.Abonnements
                                                where abonnement.Reabonnements.Any()
                                                where abonnement.Reabonnements.All(x => DateTime.Today > x.DateRenouvellement.AddYears(1))
                                                select new
                                                {
                                                    idAbonneePrincipal = abonnement.Id,
                                                    idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom

                                                });


            foreach (var abonne in abonnementReabonnee) // tous les abonnemetn qui nont pas ete reabonnee
            MessageBox.Show(abonne.idNomEtPrenom);

            // a faire : 1. faire la comparaison pour ne pas permettre a un abonnemenert qui nest pas eabonner dajouter une paertie
            //2. ajouter la partie
            //MessageBox.Show(abonnementReabonnee);


            nouvellePartie.IdAbonnement = cbAbonnement.SelectedValue.ToString();

            nouvellePartie.Terrains = (from terrain in dataContext.Terrains
                                       where terrain.Nom == cbTerrain.SelectedValue.ToString()
                                       select terrain).FirstOrDefault();
            nouvellePartie.DatePartie = DateTime.Now;

            nouvellePartie.Pointage = Convert.ToInt32( ndPointage.Value);

            //MessageBox.Show("Id : " + cbAbonnement.SelectedValue.ToString() + "\nterrain : " + cbTerrain.SelectedValue.ToString() + "\ndate du jour : " + DateTime.Now + "\nPointage : " + ndPointage.Value);
        }
    }
}
