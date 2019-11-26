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

namespace projet2BaseDeDonnees3
{
    public partial class frmModificationEmployes : Form
    {
        public Regex ExprMotDePasse { get; }
        public string strModificiation ;
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
        public int intSalaireModifier;



        public frmModificationEmployes()
        {
            InitializeComponent();
            ExprMotDePasse = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$");
        }

        private void frmModificationEmployes_Load(object sender, EventArgs e)
        {
            if (strModificiation == "modif") //recupère l'information du formulaire gestion des employés
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

            }
        }

       

        private void btnModif_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
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
                                if(tbRue.Text == "")
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
                                        if (tbProvince.Text == "")
                                        {
                                            errMessage.SetError(tbProvince, "Vous devez inserer une province");
                                        }
                                        else
                                        {
                                            errMessage.SetError(tbProvince, "");
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
                                                    if (tbSalaire.Text=="")
                                                    {
                                                        errMessage.SetError(tbSalaire, "Vous devez inserer un salaire");
                                                    }
                                                    else
                                                    {
                                                        errMessage.SetError(tbSalaire, "");
                                                        //confirmation de la modification
                                                        DialogResult = DialogResult.OK;
                                                        strNomModifier = tbNom.Text;
                                                        strPrenomModifier = tbPrenom.Text;
                                                        strMotDePasseModifier = tbMotDePasse.Text;
                                                        strSexeModifier = cbSexe.Text;
                                                        intAgeModifier = Convert.ToInt32( ndAge.Value);
                                                        strCourielModifier = tbCouriel.Text;
                                                        intNoCiviqueModifier = Convert.ToInt32( ndNumeroCivique.Value);
                                                        strRueModifier = tbRue.Text;
                                                        strVileModifier = tbVille.Text;
                                                        strProvinceModifier = tbProvince.Text;
                                                        strCodePostalModifier = tbCodePostal.Text;
                                                        strTelephoneModifier = tbTelephone.Text;
                                                        intSalaireModifier = Convert.ToInt32( tbSalaire.Text);

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
