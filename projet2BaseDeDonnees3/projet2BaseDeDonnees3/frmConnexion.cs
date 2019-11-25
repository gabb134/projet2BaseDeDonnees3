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
    public partial class frmConnexion : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmMenuPrincipal frmMenu = new frmMenuPrincipal();
        public Regex ExprMotDePasse { get; }

        public static String strNoUtilisateur = "";
        public static int noTypeEmploye =0;
        
        public frmConnexion()
        {
            InitializeComponent();

            tbUtilisateur.Text = "1";
            tbMotDePasse.Text ="Passwords%1";
            // ExprMotDePasse = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$");
            ExprMotDePasse = new Regex("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$");
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            // strNoUtilisateur = tbUtilisateur.Text;
            //string strMotDePasse = tbMotDePasse.Text;
            string strTypeEmploye = "";

            string strNoUtilisateurBD = "";
            string strMotDePasseBD ="" ;
            var employes = from unEmploye in monDataContext.Employes
                                               let noEmploye = unEmploye.No
                                               let motDePasse = unEmploye.MotDePasse
                                               let noTypeEmploye = unEmploye.NoTypeEmploye
                                               select new { noEmploye,motDePasse,noTypeEmploye};


            //pas sur si c'est la bonne facon pour aller chercher le premier employe(Administrateur)
            foreach (var emp in employes)
            {
              //  if (emp.noEmploye == 1)
              ////  {
                    strNoUtilisateurBD = emp.noEmploye.ToString();
                    strMotDePasseBD = emp.motDePasse.ToString();
                //   }
                if (tbUtilisateur.Text == "" && tbMotDePasse.Text == "")
                {
                    errMessage.SetError(tbUtilisateur, "Vous devez inserer un nom d'utilisatueur!");
                    errMessage.SetError(tbMotDePasse, "Vous devez inserer un mot de passe!");
                }
                else
                {
                    errMessage.SetError(tbUtilisateur, "");
                    errMessage.SetError(tbMotDePasse, "");
                    if (tbUtilisateur.Text == "")
                    {
                        errMessage.SetError(tbUtilisateur, "Vous devez inserer un nom d'utilisatueur!");
                    }
                    else
                    {
                        errMessage.SetError(tbUtilisateur, "");
                        if (tbMotDePasse.Text == "")
                        {
                            errMessage.SetError(tbMotDePasse, "Vous devez inserer un mot de passe!");

                        }
                        else
                        {
                            errMessage.SetError(tbMotDePasse, "");

                            if (!ExprMotDePasse.IsMatch(tbMotDePasse.Text))
                            {
                                errMessage.SetError(tbMotDePasse, "Le mot de passe doit avoir un minimum de 8 caractères, un moins une lettre, au moins un chiffre et au moins 1 caractère qui n’est ni une lettre, ni un chiffre.");
                            }
                            else {
                                errMessage.SetError(tbMotDePasse, "");
                                if (!tbUtilisateur.Text.Equals(strNoUtilisateurBD) || !tbMotDePasse.Text.Equals(strMotDePasseBD))
                                {
                                    errMessage.SetError(tbUtilisateur, "L'utilisateur ou le mot de passe est incorrect!");
                                }
                                else
                                { //Faire la validation pour le mot de passe( expression reguliere)
                                    errMessage.SetError(tbUtilisateur, "");

                                  
                                    noTypeEmploye = emp.noTypeEmploye;
                                    switch (noTypeEmploye)
                                    {
                                        case 1:
                                            strTypeEmploye = "Administrateur";
                                            break;
                                        case 2:
                                            strTypeEmploye = "Direction";
                                            break;
                                        case 3:
                                            strTypeEmploye = "Propriétaire d''un club";
                                            break;
                                        case 4:
                                            strTypeEmploye = "Employe d'un club";
                                            break;
                                        case 5:
                                            strTypeEmploye = "Employé Pro-Shop";
                                            break;
                                        case 6:
                                            strTypeEmploye = "Employe d'un restaurant";
                                            break;
                                        case 7:
                                            strTypeEmploye = "Professeur de golf";
                                            break;
                                    }
                                    MessageBox.Show("Bienvenue dans la gestion de golf !\n\nNo : " + strNoUtilisateurBD + "\nMot de passe : " + strMotDePasseBD+"\nType d'employé : "+strTypeEmploye);
                                    strNoUtilisateur = tbUtilisateur.Text;
                                   
                                    this.Hide();
                                    frmMenu.ShowDialog();
                                    this.Show();


                                }

                            }



                        }
                    }
                }



            }



        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            // this.ActiveControl = tbUtilisateur;
            //tbUtilisateur.Text = "";
            //tbMotDePasse.Text = "";
        }
    }
}
