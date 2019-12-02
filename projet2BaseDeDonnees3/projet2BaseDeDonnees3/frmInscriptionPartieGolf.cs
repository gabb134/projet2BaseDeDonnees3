using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
            Boolean booTrouver = false;
            PartiesJouees nouvellePartie = new PartiesJouees();


            //requete qui me permet d'aller chercher tout les personnes qui ont besoin de se reabonneee


            var abonnementReabonnee = (from abonnement in dataContext.Abonnements
                                       where !abonnement.Reabonnements.Any()
                                       where DateTime.Now > abonnement.DateAbonnement.AddYears(1)
                                       select new
                                       {
                                           idAbonneePrincipal = abonnement.Id,
                                           idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom
                                       }).Union(from abonnement in dataContext.Abonnements
                                                where abonnement.Reabonnements.Any()
                                                where abonnement.Reabonnements.All(x => DateTime.Now > x.DateRenouvellement.AddYears(1))
                                                select new
                                                {
                                                    idAbonneePrincipal = abonnement.Id,
                                                    idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom

                                                });
            

            foreach (var abonne in abonnementReabonnee)// tous les abonnemetn qui nont pas ete reabonnee
            {
                if (abonne.idNomEtPrenom.Equals(cbAbonnement.Text.ToString()))
                    booTrouver = true;

            }



            if (booTrouver)
                MessageBox.Show("Vous ne pouvez pas inscrire une partie à un abonnement qui ne s'est pas réabonné.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                nouvellePartie.IdAbonnement = cbAbonnement.SelectedValue.ToString();
                nouvellePartie.Terrains = (from terrain in dataContext.Terrains
                                           where terrain.Nom == cbTerrain.SelectedValue.ToString()
                                           select terrain).FirstOrDefault();
                nouvellePartie.DatePartie = DateTime.Now;

                nouvellePartie.Pointage = Convert.ToInt32(ndPointage.Value);
                try
                {
                    

                    dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                    MessageBox.Show("La partie à été ajouté!","Ajout",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (ChangeConflictException)
                {
                    dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'ajout");
                }





                //MessageBox.Show("Id : " + cbAbonnement.SelectedValue.ToString() + "\nterrain : " + cbTerrain.SelectedValue.ToString() + "\ndate du jour : " + DateTime.Now + "\nPointage : " + ndPointage.Value);
            }
        }
    }
}
