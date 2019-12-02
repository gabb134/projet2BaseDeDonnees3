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
    public partial class frmInscriptionDepense : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public int intNoEmployeDejaConnecte;
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

         
            int noTypeEmploye = frmConnexion.noTypeEmploye; // celui qui defini son service
           

            int intNoEmploye = Convert.ToInt32(frmConnexion.strNoUtilisateur); // celui sest connecte


            

            //chargement des id et nomComplet
            this.abonnementIdEtNomCompletBindingSource.DataSource = from abonnement in dataContext.Abonnements

                                                                    select new { idAbonneePrincipal = abonnement.Id, idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom };

            //voir le nombre de services 
            int nombreService = (from employeService in dataContext.Services
                                       select employeService).Count();
            //   MessageBox.Show("nb services : " + nombreService.ToString());






            //chargement de type service selon l'employe qui se connecte

            
            if (noTypeEmploye == 1 || noTypeEmploye == 2||noTypeEmploye==3) // admin, direction ou proprietaire d'un club
            {


                this.servicesBindingSource.DataSource = (from service in dataContext.Services
                                                         select service.TypesService).Distinct();
                cbtypeService.Enabled = true;
            }
            else if(intNoEmploye != intNoEmployeDejaConnecte) //il faut faire la verification pour que quand le meme no employe rentre il le sache pour qul ne passe pas par la
            {
                MessageBox.Show("employe qui sest deja connecter : " + intNoEmployeDejaConnecte.ToString());
                intNoEmployeDejaConnecte = intNoEmploye;
              //  MessageBox.Show("employe premiere fois connecter : " + intNoEmploye.ToString());
               
               
                // MessageBox.Show("type employe :"+noTypeEmploye.ToString());
                // MessageBox.Show("Employe n'existe pas!");

                // MessageBox.Show(noTypeEmploye.ToString());
                //ajout des services a lemploye qui sest connecte
                Services servicePourEmployeConnecter = new Services();

                //servicePourEmployeConnecter.Employes.

                //servicePourEmployeConnecter.No = 1;

                 if (noTypeEmploye == 5)
                {
                    servicePourEmployeConnecter.TypesService = "Magasin Pro-Shop";

                    //il faut generer le numero a laide dune requete

                    if (nombreService==0)
                        servicePourEmployeConnecter.No = 1;
                    else
                    {
                        var max = dataContext.Services.Max(em => em.No) + 1;

                     

                        servicePourEmployeConnecter.No = max;
                    }

                       
                   // servicePourEmployeConnecter.No = 1;
                }
                
                 else if (noTypeEmploye == 6)
                {
                    servicePourEmployeConnecter.TypesService = "Restaurant";
                    // servicePourEmployeConnecter.No = 2;

                    if (nombreService == 0)
                        servicePourEmployeConnecter.No = 1;
                    else
                    {
                        var max = dataContext.Services.Max(em => em.No) + 1;

                      

                        servicePourEmployeConnecter.No = max;
                    }
                }
                     
                 else if (noTypeEmploye == 7)
                {
                    servicePourEmployeConnecter.TypesService = "Leçon de golf";
                    // servicePourEmployeConnecter.No = 3;

                    if (nombreService == 0)
                        servicePourEmployeConnecter.No = 1;
                    else
                    {
                        var max = dataContext.Services.Max(em => em.No) + 1;

                      //  MessageBox.Show("Maximum :"+max.ToString());

                        servicePourEmployeConnecter.No = max;
                    }
                }
                   


                servicePourEmployeConnecter.NoEmploye = noTypeEmploye;


                try
                {
                    
                    dataContext.Services.InsertOnSubmit(servicePourEmployeConnecter);

                    dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                     //MessageBox.Show("Service ajoute a lemploye ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    //affichage du service de lemploye connecte
                    this.servicesBindingSource.DataSource = (from service in dataContext.Services
                                                             where service.NoEmploye == noTypeEmploye
                                                             select service.TypesService);
                    cbtypeService.Enabled = false;
                }
                catch (ChangeConflictException)
                {
                    dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de l'ajout");
                }

              
            }
            else 
            {
                this.servicesBindingSource.DataSource = (from service in dataContext.Services
                                                         where service.NoEmploye == noTypeEmploye
                                                         select service.TypesService);
                cbtypeService.Enabled = false;
                MessageBox.Show("le else, quand le service existe deja");
            }



        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            

          

          
               

        }
    }
}
