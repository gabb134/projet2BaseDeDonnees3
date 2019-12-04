using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace projet2BaseDeDonnees3
{
    public partial class frmNouvelAbonnement : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        List<Dependants> dependants = new List<Dependants>();
        int intNombreEnfant = 1;
        int intNoEnfantAjoute = 0;
        public frmNouvelAbonnement()
        {
            InitializeComponent();
        }

        private void NouvelAbonnement_Load(object sender, EventArgs e)
        {
            nupNbEnfant.Minimum = 0;
            nupNbEnfant.Value = 0;
            List<Sexe> sexes = new List<Sexe>();
            sexes.Add(new Sexe("H", "Homme"));
            sexes.Add(new Sexe("F", "Femme"));


            sexeBindingSource.DataSource = sexes;
            provincesBindingSource.DataSource = dataContext.Provinces;
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;

        }

        private void ddlTypesAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupNbEnfant.Minimum = 0;
            tbNomConjoint.Text = "";
            tbPrenomConjoint.Text = "";
            tbRemarqueConjoint.Text = "";
            dtpDateNaissanceConjoint.Value = DateTime.Now;

            tbNomEnfant.Text = "";
            tbPrenomEnfant.Text = "";
            tbRemarqueEnfant.Text = "";
            dtpDateDeNaissanceEnfant.Value = DateTime.Now;
            

            dependants.Clear();


            DateTime dateActuelle = DateTime.Today;
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            int age = dateActuelle.Year - dateNaissance.Year;
            if (dateNaissance > dateActuelle.AddYears(-age)) age--;
            switch (ddlTypesAbonnement.SelectedValue)
            {
                case 1:
                    nupNbEnfant.Value = 0;
                    intNombreEnfant = 0;
                    gbConjoint.Enabled = false;
                    gbEnfant.Enabled = false;
                    if (age < 18)
                    {
                        errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal doit etre de 18 ans");
                    }
                    else
                    {
                        errMessage.SetError(dtpDateNaissance, String.Empty);
                    }
                    break;
                case 2:
                    nupNbEnfant.Value = 0;
                    intNombreEnfant = 0;
                    gbConjoint.Enabled = false;
                    gbEnfant.Enabled = false;
                    if (age < 60)
                    {
                        errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal doit etre de 60 ans pour les personnes de l’âge d’or");
                    }
                    else
                    {
                        errMessage.SetError(dtpDateNaissance, String.Empty);
                    }
                    break;
                case 3:
                    nupNbEnfant.Value = 0;
                    intNombreEnfant = 0;
                    if (age < 18)
                    {
                        errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal doit etre de 18 ans");
                    }
                    else
                    {
                        errMessage.SetError(dtpDateNaissance, String.Empty);
                    }
                    gbConjoint.Enabled = true;
                    gbEnfant.Enabled = false;
                    break;
                case 4:
                    nupNbEnfant.Value = 1;
                    intNombreEnfant = 1;
                    gbConjoint.Enabled = true;
                    gbEnfant.Enabled = true;
                    if (age < 18)
                    {
                        errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal doit etre de 18 ans");
                    }
                    else
                    {
                        errMessage.SetError(dtpDateNaissance, String.Empty);
                    }
                    break;
                case 5:
                    nupNbEnfant.Value = 2;
                    intNombreEnfant = 2;
                    gbConjoint.Enabled = true;
                    gbEnfant.Enabled = true;
                    if (age < 18)
                    {
                        errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 18 ans");
                    }
                    else
                    {
                        errMessage.SetError(dtpDateNaissance, String.Empty);
                    }
                    break;
                case 6:
                    nupNbEnfant.Value = 3;
                    nupNbEnfant.Minimum = 3;
                    //lbl.Enabled = true;
                    nupNbEnfant.Enabled = true;
                    intNombreEnfant = int.Parse(nupNbEnfant.Value.ToString());
                    gbConjoint.Enabled = true;
                    gbEnfant.Enabled = true;
                    if (age < 18)
                    {
                        errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 18 ans");
                    }
                    else
                    {
                        errMessage.SetError(dtpDateNaissance, String.Empty);
                    }
                    break;
                default:
                    errMessage.SetError(dtpDateNaissance, String.Empty);
                    break;

            }
        }

        private void tbPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrenom.Text.Trim()))
            {
                errMessage.SetError(tbPrenom, "Le prénom ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tbPrenom.Text.Trim(), "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
            {
                errMessage.SetError(tbPrenom, "Le prénom doit débuter par une lettre suivi d'un tiret, apostrophe, espace ou lettre et se terminer par une lettre");
                e.Cancel = true;
            }
        }

        private void tbPrenom_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbPrenom, string.Empty);
        }

        private void tbNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNom.Text.Trim()))
            {
                errMessage.SetError(tbNom, "Le nom ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tbNom.Text.Trim(), "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
            {
                errMessage.SetError(tbNom, "Le nom doit débuter par une lettre suivi d'un tiret, apostrophe, espace ou lettre et se terminer par une lettre");
                e.Cancel = true;
            }
        }

        private void tbNom_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbNom, string.Empty);
        }

        private void dtpDateNaissance_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateActuelle = DateTime.Today;
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            int age = dateActuelle.Year - dateNaissance.Year;
            if (dateNaissance > dateActuelle.AddYears(-age)) age--;

            if ((int)ddlTypesAbonnement.SelectedValue == 2)
            {
                if (age < 60)
                {
                    errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or");
                    e.Cancel = true;
                }
            }
            else
            {
                if (age < 18)
                {
                    errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 18 ans");
                    e.Cancel = true;
                }
            }
        }

        private void dtpDateNaissance_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(dtpDateNaissance, string.Empty);
        }

        private void tbRue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRue.Text.Trim()))
            {
                errMessage.SetError(tbRue, "La rue ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tbRue.Text.Trim(), "^(\\d{1,3}(e|th) )?\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
            {
                errMessage.SetError(tbRue, "La rue doit débuter par une lettre suivi d'un tiret, apostrophe, espace ou lettre et se terminer par une lettre");
                e.Cancel = true;
            }
        }

        private void tbRue_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbRue, string.Empty);
        }

        private void tbVille_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbVille.Text.Trim()))
            {
                errMessage.SetError(tbVille, "La ville ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tbVille.Text.Trim(), "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
            {
                errMessage.SetError(tbNom, "La ville doit débuter par une lettre suivi d'un tiret, apostrophe, espace ou lettre et se terminer par une lettre");
                e.Cancel = true;
            }
            else errMessage.SetError(tbVille, string.Empty);
        }

        private void tbVille_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbVille, string.Empty);
        }

        private void mtbCodePostal_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtbCodePostal.Text.Trim()))
            {
                errMessage.SetError(mtbCodePostal, "Le code postal ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!mtbCodePostal.MaskCompleted)
            {
                errMessage.SetError(mtbCodePostal, "Le code postal doit respecter le masque de saisie");
                e.Cancel = true;
            }
        }

        private void mtbCodePostal_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(mtbCodePostal, string.Empty);
        }

        private void mtbTelephone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtbTelephone.Text.Trim('(', ')', '-', ' ')))
            {
                errMessage.SetError(mtbTelephone, "Le téléphone ne peut pas être vide");
                e.Cancel = true;
            }
            else if (!mtbTelephone.MaskCompleted)
            {
                errMessage.SetError(mtbTelephone, "Le téléphone doit respecter le masque de saisie");
                e.Cancel = true;
            }
        }

        private void mtbTelephone_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(mtbTelephone, string.Empty);
        }

        private void mtbCellulaire_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbCellulaire.Text.Trim('(', ')', '-', ' ')) && !mtbCellulaire.MaskCompleted)
            {
                errMessage.SetError(mtbCellulaire, "Le cellulaire doit respecter le masque de saisie");
                e.Cancel = true;
            }
        }

        private void mtbCellulaire_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(mtbCellulaire, string.Empty);
        }

        private void tbCourriel_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                new MailAddress(tbCourriel.Text.Trim());
                errMessage.SetError(tbCourriel, string.Empty);
            }
            catch (ArgumentException)
            {
                errMessage.SetError(tbCourriel, "Le courriel ne peut pas être vide");
                e.Cancel = true;
            }
            catch (FormatException)
            {
                errMessage.SetError(tbCourriel, "Le courriel n'est pas dans un format valide");
                e.Cancel = true;
            }
        }

        private void tbCourriel_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(tbCourriel, string.Empty);
        }

        private void btnAjouterConjoint_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                String strId = $"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P";
                dependants.Add(creerDependant(strId, true, 1));
                gbConjoint.Enabled = false;
            }
        }

        private void btnAjouterAbonnement_Click(object sender, EventArgs e)
        {

          //  MessageBox.Show(((int)ddlTypesAbonnement.SelectedValue).ToString());
            if (dependants.Count < nupNbEnfant.Value + 1 && ((int)ddlTypesAbonnement.SelectedValue > 2))
            {
                MessageBox.Show("Veuillez ajouter les enfants avant de créer cet abonnement");
            }



            else
            {

                if (ValidateChildren())
                {

                    Abonnements abonnement = new Abonnements();
                    //  MessageBox.Show($"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P");
                    abonnement.Id = $"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P";
                    abonnement.DateAbonnement = DateTime.Today;
                    abonnement.Nom = tbNom.Text.Trim();
                    abonnement.Prenom = tbPrenom.Text.Trim();
                    abonnement.Sexe = ddlSexes.SelectedValue.ToString();
                    abonnement.DateNaissance = dtpDateNaissance.Value.Date;
                    abonnement.NoCivique = (int)numNoCivique.Value;
                    abonnement.Rue = tbRue.Text.Trim();
                    abonnement.Ville = tbVille.Text.Trim();
                    abonnement.IdProvince = ddlProvinces.SelectedValue.ToString();
                    abonnement.CodePostal = mtbCodePostal.Text.Remove(3, 1);
                    abonnement.Telephone = new string(mtbTelephone.Text.Where(c => char.IsDigit(c)).ToArray());
                    if (mtbCellulaire.MaskCompleted)
                        abonnement.Cellulaire = new string(mtbCellulaire.Text.Where(c => char.IsDigit(c)).ToArray());
                    abonnement.Courriel = tbCourriel.Text.Trim();
                    abonnement.NoTypeAbonnement = (int)ddlTypesAbonnement.SelectedValue;
                    if (!string.IsNullOrEmpty(tbRemarque.Text.Trim())) abonnement.Remarque = tbRemarque.Text.Trim();

                    foreach (Dependants dependant in dependants)
                        abonnement.Dependants.Add(dependant);

                    // foreach (Control controle in lstControlesDynamiques)
                    //  if (controle is SaisieDependant)
                    //    abonnement.Dependants.Add(((SaisieDependant)controle).creerDependant(abonnement.Id));

                    dataContext.Abonnements.InsertOnSubmit(abonnement);

                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            while (abonnement.Id != $"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P")
                            {
                                abonnement.Id = $"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P";
                                abonnement.Dependants.Clear();
                                foreach (Dependants dependant in dependants)
                                    abonnement.Dependants.Add(dependant);
                                //foreach (Control controle in lstControlesDynamiques)
                                //   if (controle is SaisieDependant)
                                //      abonnement.Dependants.Add(((SaisieDependant)controle).creerDependant(abonnement.Id));
                            }

                            dataContext.SubmitChanges();
                            transaction.Complete();
                            MessageBox.Show("L'abonnement a été enregistré dans la base de données.", "Enregistrement des données");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                        }
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Vous devez vous assurez que toutes les données saisies sont correct");
                }
            }

        }



        public Dependants creerDependant(string idAbonnement, Boolean conjoint, int noEnfant)
        {

            Dependants dependant = new Dependants();
            if (conjoint)
            {
                dependant.Id = idAbonnement.Substring(0, idAbonnement.Length - 1) + $"{ddlSexes.SelectedValue}0";
                dependant.Nom = tbNomConjoint.Text.Trim();
                dependant.Prenom = tbPrenomConjoint.Text.Trim();
                dependant.Sexe = ddlSexeConjoint.SelectedValue.ToString();
                dependant.DateNaissance = dtpDateNaissanceConjoint.Value.Date;
                dependant.IdAbonnement = idAbonnement;
                if (!string.IsNullOrEmpty(tbRemarqueConjoint.Text.Trim())) dependant.Remarque = tbRemarqueConjoint.Text.Trim();
               // MessageBox.Show(dependant.Id);
                return dependant;
            }
            else
            {
                dependant.Id = idAbonnement.Substring(0, idAbonnement.Length - 1) + $"E{noEnfant+1}";
                dependant.Nom = tbNomEnfant.Text.Trim();
                dependant.Prenom = tbPrenomEnfant.Text.Trim();
                dependant.Sexe = ddlSexeEnfant.SelectedValue.ToString();
                dependant.DateNaissance = dtpDateDeNaissanceEnfant.Value.Date;
                dependant.IdAbonnement = idAbonnement;
                if (!string.IsNullOrEmpty(tbRemarqueEnfant.Text.Trim())) dependant.Remarque = tbRemarqueEnfant.Text.Trim();
             //   MessageBox.Show(dependant.Id);
                return dependant;
            }

        }

        private void btnAjouterEnfant_Click(object sender, EventArgs e)
        {
            if (intNombreEnfant > 0)
            {
                String strId = $"{tbNom.Text.Trim()}{dataContext.Abonnements.Count() + 1}P";
                dependants.Add(creerDependant(strId, false, intNoEnfantAjoute));

                intNombreEnfant--;
                intNoEnfantAjoute++;
                btnAjouterEnfant.Text = "Ajouter Enfant " + intNoEnfantAjoute;

                tbNomEnfant.Text = "";
                tbPrenomEnfant.Text = "";
                tbRemarqueEnfant.Text = "";
                dtpDateDeNaissanceEnfant.Value = DateTime.Now;

            }


            else gbEnfant.Enabled = false;

            if (intNombreEnfant == 0)
            {
                gbEnfant.Enabled = false;
            }

        }

        private void nupNbEnfant_ValueChanged(object sender, EventArgs e)
        {
            intNombreEnfant = (int)nupNbEnfant.Value;
        }

        private void ddlTypesAbonnement_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateActuelle = DateTime.Today;
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            int age = dateActuelle.Year - dateNaissance.Year;
            if (dateNaissance > dateActuelle.AddYears(-age)) age--;

            if ((int)ddlTypesAbonnement.SelectedValue == 2)
            {
                if (age < 60)
                {
                    errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or");
                    // e.Cancel = true;
                }
            }
            else
            {
                if (age < 18)
                {
                    errMessage.SetError(dtpDateNaissance, "L’âge minimum de l’abonné principal est de 18 ans");
                    //  e.Cancel = true;
                }
            }
        }

        private void ddlTypesAbonnement_Validated(object sender, EventArgs e)
        {
            errMessage.SetError(dtpDateNaissance, string.Empty);
        }
    }
}
