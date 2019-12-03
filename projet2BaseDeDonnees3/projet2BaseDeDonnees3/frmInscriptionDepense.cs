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
using System.Transactions;

namespace projet2BaseDeDonnees3
{
    public partial class frmInscriptionDepense : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public int intNoEmployeDejaConnecte;

        public int intnoService;
        frmInformationAjoutDepense informationDepense = new frmInformationAjoutDepense();

        int noTypeEmploye ; // celui qui defini son service


         int intNoEmploye ; // celui sest connecte
        public frmInscriptionDepense()
        {
            InitializeComponent();
        }

        private void frmInscriptionDepense_Load(object sender, EventArgs e)
        {
             noTypeEmploye = frmConnexion.noTypeEmploye; // celui qui defini son service


            intNoEmploye = Convert.ToInt32(frmConnexion.strNoUtilisateur); // celui sest connecte



            //chargement des id et nomComplet
            this.abonnementIdEtNomCompletBindingSource.DataSource = from abonnement in dataContext.Abonnements

                                                                    select new { idAbonneePrincipal = abonnement.Id, idNomEtPrenom = abonnement.Id + "-" + abonnement.Nom + ", " + abonnement.Prenom };


            List<String> lstTypeServices = new List<string>(); // ne marche pas car l prend le contenu du combobox qui saffiche car on est dans le load

            lstTypeServices.Add("Magasin Pro-Shop");
            lstTypeServices.Add("Restaurant");
            lstTypeServices.Add("Leçon de golf");
            // this.servicesBindingSource.DataSource = (from service in dataContext.Services  
            //                                        select service.TypesService).Distinct();

            this.servicesBindingSource.DataSource = lstTypeServices;

            if (noTypeEmploye == 5)
            {
                cbtypeService.Text = "Magasin Pro-Shop";
                cbtypeService.Enabled = false;
            }
            else if (noTypeEmploye == 6)
            {
                cbtypeService.Text = "Restaurant";
                cbtypeService.Enabled = false;
            }
            else if (noTypeEmploye == 7)
            {
                cbtypeService.Text = "Leçon de golf";
                cbtypeService.Enabled = false;
            }



        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            /**************************************GESTION DES SERVICES****************************************/




            int intNoEmployebaseDeDonnes = (from employeService in dataContext.Services
                                            select employeService.NoEmploye).FirstOrDefault();


            //voir le nombre de services 
            int nombreService = (from employeService in dataContext.Services
                                 select employeService).Count();

            Services servicePourEmployeConnecter = new Services();

            if (noTypeEmploye == 1 || noTypeEmploye == 2 || noTypeEmploye == 3) // admin, direction ou proprietaire d'un club
            {


               


                cbtypeService.Enabled = true;

                if (nombreService == 0)
                    servicePourEmployeConnecter.No = 1;
                else
                {
                    var max = dataContext.Services.Max(em => em.No) + 1;



                    servicePourEmployeConnecter.No = max;

                }

                intnoService = servicePourEmployeConnecter.No;



                //MessageBox.Show(cbtypeService.Text);

                if (cbtypeService.Text == "Magasin Pro-Shop")
                {
                    servicePourEmployeConnecter.NoEmploye = 5;
                    servicePourEmployeConnecter.TypesService = cbtypeService.Text;
                }
                else if (cbtypeService.Text == "Restaurant")
                {
                    servicePourEmployeConnecter.NoEmploye = 6;
                    servicePourEmployeConnecter.TypesService = cbtypeService.Text;
                }
                else if (cbtypeService.Text == "Leçon de golf")
                {
                    servicePourEmployeConnecter.NoEmploye = 7;
                    servicePourEmployeConnecter.TypesService = cbtypeService.Text;
                }

                try
                {

                    dataContext.Services.InsertOnSubmit(servicePourEmployeConnecter);

                    dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                    //MessageBox.Show("Service ajoute a lemploye ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //affichage du service de lemploye connecte
                    //   this.servicesBindingSource.DataSource = (from service in dataContext.Services
                    //                                          where service.NoEmploye == noTypeEmploye
                    //                                        select service.TypesService);

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
            else if (intNoEmploye != intNoEmployebaseDeDonnes) //il faut faire la verification pour que quand le meme no employe rentre il le sache pour qul ne passe pas par la
            {
                MessageBox.Show("employe qui sest deja connecter : " + intNoEmployeDejaConnecte.ToString());
                intNoEmployeDejaConnecte = intNoEmploye;
                //  MessageBox.Show("employe premiere fois connecter : " + intNoEmploye.ToString());


                // MessageBox.Show("type employe :"+noTypeEmploye.ToString());
                // MessageBox.Show("Employe n'existe pas!");

                // MessageBox.Show(noTypeEmploye.ToString());
                //ajout des services a lemploye qui sest connecte


                //servicePourEmployeConnecter.Employes.

                //servicePourEmployeConnecter.No = 1;

                if (noTypeEmploye == 5)
                {
                    servicePourEmployeConnecter.TypesService = "Magasin Pro-Shop";

                    //il faut generer le numero a laide dune requete

                    if (nombreService == 0)
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



                servicePourEmployeConnecter.NoEmploye = intNoEmploye; // voir avec la prof si cest lemploye qui sest connecter ou cest le type demploye


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
                    intnoService = servicePourEmployeConnecter.No;
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






            /**************************************AJOUT DE LA DEPENSE****************************************/
            using (var porteeTransaction = new TransactionScope())
            {

                Depenses nouvelleDepense = new Depenses();

                //voir le nombre de Depense
                int nombreDepenses = (from depense in dataContext.Depenses
                                      select depense).Count();

                if (nombreDepenses == 0)
                    nouvelleDepense.No = 1;
                else
                {
                    var max = dataContext.Depenses.Max(em => em.No) + 1;

                    

                    nouvelleDepense.No = max;
                }
                 MessageBox.Show("nb depenses :"+ nombreDepenses.ToString());

                nouvelleDepense.IdAbonnement = cbClient.SelectedValue.ToString();

                nouvelleDepense.DateDepense = DateTime.Now;

                nouvelleDepense.Montant = Convert.ToInt32(ndMontant.Value);

                nouvelleDepense.NoService = intnoService;
                //  MessageBox.Show("Numero de service : " + intnoService.ToString());

                MessageBox.Show("Depense qui est ajoute\n\nNo: " + nouvelleDepense.No+"\nId abonnement: "+ nouvelleDepense.IdAbonnement+"\nDateDepense: " + nouvelleDepense.DateDepense+"\nMontant: "+ nouvelleDepense.Montant+"\nNoService :" + nouvelleDepense.NoService);
                try
                {

                    dataContext.Depenses.InsertOnSubmit(nouvelleDepense);
                    dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);

                  if((  MessageBox.Show("La dépense à été ajouté! Voulez-vous voir les dépenses efectués?", "Ajout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)){
                        informationDepense.ShowDialog();
                    }
                  
                    porteeTransaction.Complete();
                   // this.Hide();
                 
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
          
               

        }

        private void cbtypeService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void verificationUnDeuxTrois()
        {

        }
    }
}
