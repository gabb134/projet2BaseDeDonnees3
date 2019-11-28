﻿using System;
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

namespace projet2BaseDeDonnees3
{
    public partial class frmAjoutEmployes : Form
    {
        public Regex ExprMotDePasse { get; }

        public DataClasses1DataContext dataContextajout;

        public Employes employeRecuperer;
        public frmAjoutEmployes()
        {

        }
        public frmAjoutEmployes(Employes employe, DataClasses1DataContext dataContextRecuperer)
        {
            InitializeComponent();
            this.dataContextajout = dataContextRecuperer;

            ExprMotDePasse = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$");

            employeRecuperer = (from unEmploye in dataContextRecuperer.Employes
                                where unEmploye.No == employe.No
                                select unEmploye).FirstOrDefault();


            //ramener les provinces
            this.employesBindingSource1.DataSource = from prov in dataContextRecuperer.Provinces
                                                     select prov;

            //ramener les types employes

            this.employesBindingSource2.DataSource = from noTypeEmploye in dataContextRecuperer.TypesEmploye
                                                     where noTypeEmploye.No != 1
                                                     select noTypeEmploye;


        }
        private void frmAjoutEmployes_Load(object sender, EventArgs e)
        {

            cbProvince.SelectedValue = employeRecuperer.Provinces.Id;

            if (employeRecuperer.Sexe == "H")
            {
                cbSexe.Text = "Homme";
            }
            else if (employeRecuperer.Sexe == "F")
            {
                cbSexe.Text = "Femme";
            }


         //   var max = dataContextajout.Employes.Max(em => em.No);

           // MessageBox.Show((max+1).ToString());
;        }



        private void btnConfirmerAjout_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "")
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
                    if (tbMotDePasse.Text == "")
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
                                                    if (tbSalaire.Text == "")
                                                    {
                                                        errMessage.SetError(tbSalaire, "Vous devez inserer un salaire");
                                                    }
                                                    else
                                                    {
                                                        errMessage.SetError(tbSalaire, "");

                                                        //Ajout d'un employe

                                                        Employes employeAjouter = new Employes();

                                                        employeAjouter.Nom = tbNom.Text;
                                                        employeAjouter.Prenom = tbPrenom.Text;
                                                        employeAjouter.MotDePasse = tbMotDePasse.Text;

                                                        if (cbSexe.Text == "Homme")
                                                            employeAjouter.Sexe = "H";
                                                        else if (cbSexe.Text == "Femme")
                                                            employeAjouter.Sexe = "F";

                                                        employeAjouter.Age = Convert.ToInt32(ndAge.Value);
                                                        employeAjouter.Courriel = tbCouriel.Text;
                                                        employeAjouter.NoCivique = Convert.ToInt32(ndNumeroCivique.Value);
                                                        employeAjouter.Rue = tbRue.Text;
                                                        employeAjouter.Ville = tbVille.Text;

                                                        //recuperer l'objet province
                                                        employeAjouter.Provinces = (from prov in dataContextajout.Provinces
                                                                                      where (string)prov.Id == cbProvince.SelectedValue.ToString()
                                                                                      select prov).FirstOrDefault();






                                                        employeAjouter.CodePostal = tbCodePostal.Text;
                                                        employeAjouter.Telephone = tbTelephone.Text;
                                                        employeAjouter.SalaireHoraire = Convert.ToInt32(tbSalaire.Text);

                                                        //employeAjouter.No = (dataContextajout.Employes.Aggregate(0, (plusGrand, numero) => (plusGrand < numero.No) ? numero.No : plusGrand))+1;
                                                        //va chercher l'employe le plus grand pour ajouter le nouveau
                                                        

                                                        var max = dataContextajout.Employes.Max(em => em.No) + 1;

                                                        employeAjouter.No = max;

                                                       // employesBindingSource.Add(employeAjouter);

                                                        

                                                        try
                                                        {
                                                            // dataContextajout.SubmitChanges(ConflictMode.ContinueOnConflict);

                                                            dataContextajout.Employes.InsertOnSubmit(employeAjouter);
                                                            employesBindingSource.EndEdit();
                                                            MessageBox.Show("L'employé a été ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                        catch (ChangeConflictException)
                                                        {
                                                            dataContextajout.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            MessageBox.Show(ex.Message, "Erreur lors de l'ajout");
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

        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

