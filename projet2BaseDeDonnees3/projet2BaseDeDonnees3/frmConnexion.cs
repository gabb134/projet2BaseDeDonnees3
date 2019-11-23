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
    public partial class frmConnexion : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmMenuPrincipal frmMenu = new frmMenuPrincipal();

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string strNoUtilisateurBD = "";
            string strMotDePasseBD = "";
            //string strNoUtilisateur = tbUtilisateur.Text;
            //string strMotDePasse = tbMotDePasse.Text;

            var employes = from unEmploye in monDataContext.Employes
                                               let noEmploye = unEmploye.No
                                               let motDePasse = unEmploye.MotDePasse
                                               select new { noEmploye,motDePasse};


            //pas sur si c'est la bonne facon pour aller chercher le premier employe(Administrateur)
            foreach (var emp in employes)
            {
                if (emp.noEmploye == 1)
                {
                    strNoUtilisateurBD = emp.noEmploye.ToString();
                    strMotDePasseBD = emp.motDePasse.ToString();
                }
               

            }

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

                        if(!tbUtilisateur.Text.Equals(strNoUtilisateurBD))
                        {
                            errMessage.SetError(tbUtilisateur, "L'utilisateur ou le mot de passe et incorrect!");
                        }
                        else if (!tbMotDePasse.Text.Equals(strMotDePasseBD))
                        {
                            errMessage.SetError(tbUtilisateur, "L'utilisateur ou le mot de passe et incorrect!");

                        }
                        else
                        {
                            errMessage.SetError(tbUtilisateur, "");
                            MessageBox.Show("Bienvenue dans la gestion de golf !\n\nNo : " + strNoUtilisateurBD + "\nMot de passe : " + strMotDePasseBD);
                            this.Hide();
                            frmMenu.ShowDialog();
                            this.Show();
                        }

                       
                    }
                }
            }

         
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
           // this.ActiveControl = tbUtilisateur;
           
        }
    }
}
