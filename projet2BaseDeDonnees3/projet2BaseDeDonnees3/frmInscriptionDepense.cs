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
    public partial class frmInscriptionDepense : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmInscriptionDepense()
        {
            InitializeComponent();
        }

        private void frmInscriptionDepense_Load(object sender, EventArgs e)
        {
            //si c'est admin (1) ou direction (2)
            //peut choisir le type de service
            //si c'est employe proshop , cest magasin proshop 
            //si cest employe restaurant cest restaurant
            //si cest prof de gold, cest lecon de golf

            //1. aller checher la personne qui sest connnecte
            //2. faire les verification des personnes
            //3. remplir le combobox

            //Employe qui sest connecte
            int noTypeEmploye = frmConnexion.noTypeEmploye;
           // MessageBox.Show(noTypeEmploye.ToString());

        

            //chargement des id et nomComplet
            this.abonnementIdEtNomCompletBindingSource.DataSource = from abonnement in dataContext.Abonnements

                                                                    select new { idAbonneePrincipal = abonnement.Id, idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom };


            //chargement de type service selon l'employe qui se connecte
          

            if (noTypeEmploye == 1 || noTypeEmploye == 2||noTypeEmploye==3) // admin, direction ou proprietaire d'un club
            {
                this.servicesBindingSource.DataSource = (from service in dataContext.Services
                                                         select service.TypesService);
                cbtypeService.Enabled = true;
            }
            else // les employes
            {

                this.servicesBindingSource.DataSource = (from service in dataContext.Services
                                                         where service.NoEmploye == noTypeEmploye
                                                         select service.TypesService);
                cbtypeService.Enabled = false;

            }



        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            //Avant d’ajouter la dépense dans la base de données, vérifiez si le type de service pour
            //cet employé existe déjà dans la base de données




        }
    }
}
