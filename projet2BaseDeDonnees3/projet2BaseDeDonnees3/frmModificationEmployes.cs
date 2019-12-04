using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.Linq;
using System.Net.Mail;

namespace projet2BaseDeDonnees3
{
    public partial class frmModificationEmployes : Form
    {
        public Regex ExprMotDePasse { get; }
        /* public string strModificiation ;
         public string strNom;
         public string strPrenom;
         public string strMotDePasse;
         public string strSexe;
         public int intAge;
         public string strCouriel;
         public int intNoCivique;
         public string strRue;
         public string strVile;
         public string strProvince;
         public string strCodePostal;
         public string strTelephone;
         public int intSalaire;




         public string strNomModifier;
         public string strPrenomModifier;
         public string strMotDePasseModifier;
         public string strSexeModifier;
         public int intAgeModifier;
         public string strCourielModifier;
         public int intNoCiviqueModifier;
         public string strRueModifier;
         public string strVileModifier;
         public string strProvinceModifier;
         public string strCodePostalModifier;
         public string strTelephoneModifier;
         public int intSalaireModifier;*/

        Employes employeRecuperer;

        /*public frmModificationEmployes()
        {
            InitializeComponent();
            ExprMotDePasse = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$");
        }*/

        DataClasses1DataContext dataContexteModifier = new DataClasses1DataContext();

        public frmModificationEmployes(Employes emp, DataClasses1DataContext dataContextRecuperer)
        {
            InitializeComponent();

            this.dataContexteModifier = dataContextRecuperer;
            

            //ramener les provinces
            this.employesBindingSource.DataSource = from prov in dataContextRecuperer.Provinces
                                                    select prov;

           

            ExprMotDePasse = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$");
            employeRecuperer =  (from unEmploye in dataContextRecuperer.Employes
                                           where unEmploye.No == emp.No
                                           select unEmploye).FirstOrDefault();

           // MessageBox.Show(employeRecuperer.Nom);
        }

        private void frmModificationEmployes_Load(object sender, EventArgs e)
        {


           

            tbNom.Text = employeRecuperer.Nom;
            tbPrenom.Text = employeRecuperer.Prenom;
            tbMotDePasse.Text = employeRecuperer.MotDePasse;

            //cbSexe.Text = employeRecuperer.Sexe;

            if(employeRecuperer.Sexe == "H")
            {
                cbSexe.Text = "Homme";
            }
            else if(employeRecuperer.Sexe == "F")
            {
                cbSexe.Text = "Femme";
            }


            ndAge.Value = employeRecuperer.Age;
            tbCouriel.Text = employeRecuperer.Courriel;
            ndNumeroCivique.Value = employeRecuperer.NoCivique;
            tbRue.Text = employeRecuperer.Rue;
            tbVille.Text = employeRecuperer.Ville;
            //tbProvince.Text = employeRecuperer.IdProvince;
            cbProvince.SelectedValue = employeRecuperer.Provinces.Id; // voir comment faire en sorte que ca affiche dans le combobox et que le combobox ait le nom complet des provinces 
            tbCodePostal.Text = employeRecuperer.CodePostal;
            tbTelephone.Text = employeRecuperer.Telephone;
            ndSalaire.Text =employeRecuperer.SalaireHoraire.ToString();

            /*if (strModificiation == "modif") //recupère l'information du formulaire gestion des employés
            {
                //tbNumeroEmploye.Enabled = false;
                // cbTypeEmploye.Enabled = false;
                // cbSexe.Text = "H";

                tbNom.Text = strNom;
                tbPrenom.Text = strPrenom;
                tbMotDePasse.Text = strMotDePasse;
                cbSexe.Text = strSexe;
                ndAge.Value = intAge;
                tbCouriel.Text = strCouriel;
                ndNumeroCivique.Value = intNoCivique;
                tbRue.Text = strRue;
                tbVille.Text = strVile;
                tbProvince.Text = strProvince;
                tbCodePostal.Text = strCodePostal;
                tbTelephone.Text = strTelephone;
                tbSalaire.Text = intSalaire.ToString();

            }*/
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        public bool courielValide(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }




        private void btnConfirmerModification_Click(object sender, EventArgs e)
        {



            if(tbNom.Text == "")
            {
                errMessage.SetError(tbNom, "Vous devez inserer un nom");
            }
            else
            {
                errMessage.SetError(tbNom, "");
                if (tbPrenom.Text == "")
                {
                    errMessage.SetError(tbPrenom, "Vous devez inserer un prénom");
                }
                else
                {
                    errMessage.SetError(tbPrenom, "");
                    if(tbMotDePasse.Text == "")
                    {
                        errMessage.SetError(tbMotDePasse, "Vous devez inserer un mot de passe");
                    }
                    else
                    {
                        errMessage.SetError(tbMotDePasse, "");
                        if (!ExprMotDePasse.IsMatch(tbMotDePasse.Text))
                        {
                            errMessage.SetError(tbMotDePasse, "Le mot de passe doit avoir un minimum de 8 caractères, un moins une lettre, au moins un chiffre et au moins 1 caractère qui n’est ni une lettre, ni un chiffre");
                        }
                        else
                        {
                            errMessage.SetError(tbMotDePasse, "");
                            if (tbCouriel.Text == "")
                            {
                                errMessage.SetError(tbCouriel, "Vous devez inserer un couriel");

                            }
                            else
                            {
                                errMessage.SetError(tbCouriel, "");
                                if (!courielValide(tbCouriel.Text))
                                {
                                    errMessage.SetError(tbCouriel, "Vous devez inserer un couriel dans un format valide");
                                }
                                else
                                {
                                    errMessage.SetError(tbCouriel, "");
                                    if (tbRue.Text == "")
                                    {
                                        errMessage.SetError(tbRue, "Vous devez inserer une rue");
                                    }
                                    else
                                    {
                                        errMessage.SetError(tbRue, "");
                                        if (tbVille.Text == "")
                                        {
                                            errMessage.SetError(tbVille, "Vous devez inserer une ville");
                                        }
                                        else
                                        {
                                            errMessage.SetError(tbVille, "");
                                            if (cbProvince.Text == "")
                                            {
                                                errMessage.SetError(cbProvince, "Vous devez inserer une province");
                                            }
                                            else
                                            {
                                                errMessage.SetError(cbProvince, "");
                                                if (!tbCodePostal.MaskCompleted)
                                                {
                                                    errMessage.SetError(tbCodePostal, "Vous devez inserer un code postal");
                                                }
                                                else
                                                {
                                                    errMessage.SetError(tbCodePostal, "");
                                                    if (!tbTelephone.MaskCompleted)
                                                    {
                                                        errMessage.SetError(tbTelephone, "Vous devez inserer un numéro de téléphone");
                                                    }
                                                    else
                                                    {
                                                        errMessage.SetError(tbTelephone, "");
                                                        if (ndSalaire.Text == "")
                                                        {
                                                            errMessage.SetError(ndSalaire, "Vous devez inserer un salaire");
                                                        }
                                                        else
                                                        {

                                                            errMessage.SetError(ndSalaire, "");


                                                            employeRecuperer = (from unEmploye in dataContexteModifier.Employes
                                                                                where unEmploye.No == this.employeRecuperer.No
                                                                                select unEmploye).FirstOrDefault();

                                                            //regler les conflits de modification
                                                            //confirmation de la modification
                                                            //DialogResult = DialogResult.OK;
                                                            employeRecuperer.Nom = tbNom.Text;
                                                            employeRecuperer.Prenom = tbPrenom.Text;
                                                            employeRecuperer.MotDePasse = tbMotDePasse.Text;

                                                            if (cbSexe.Text == "Homme")
                                                                employeRecuperer.Sexe = "H";
                                                            else if (cbSexe.Text == "Femme")
                                                                employeRecuperer.Sexe = "F";

                                                            employeRecuperer.Age = Convert.ToInt32(ndAge.Value);
                                                            employeRecuperer.Courriel = tbCouriel.Text;
                                                            employeRecuperer.NoCivique = Convert.ToInt32(ndNumeroCivique.Value);
                                                            employeRecuperer.Rue = tbRue.Text;
                                                            employeRecuperer.Ville = tbVille.Text;

                                                            //recuperer l'objet province
                                                            employeRecuperer.Provinces = (from prov in dataContexteModifier.Provinces
                                                                                          where (string)prov.Id == cbProvince.SelectedValue.ToString()
                                                                                          select prov).FirstOrDefault();






                                                            employeRecuperer.CodePostal = tbCodePostal.Text;
                                                            employeRecuperer.Telephone = tbTelephone.Text;
                                                            employeRecuperer.SalaireHoraire = Convert.ToInt32(ndSalaire.Text);

                                                            employesBindingSource.EndEdit();


                                                            try
                                                            {
                                                                dataContexteModifier.SubmitChanges(ConflictMode.ContinueOnConflict);
                                                                MessageBox.Show("L'employé a été modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            }
                                                            catch (ChangeConflictException)
                                                            {
                                                                dataContexteModifier.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                                                                MessageBox.Show("La valeur de la base de donnée est gardée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                MessageBox.Show(ex.Message, "Erreur lors de la suppression");
                                                            }


                                                            this.Close();

                                                        }

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }
                               
                            }

                        }



                    }
                }
               
                
                

            }
                                                      
        }

     
    }
}
