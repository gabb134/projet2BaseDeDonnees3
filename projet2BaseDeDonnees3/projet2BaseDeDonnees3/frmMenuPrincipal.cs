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
    public partial class frmMenuPrincipal : Form
       
    {
        frmGestionDesEmployes gestionEmployes = new frmGestionDesEmployes();
        frmInscriptionPartieGolf inscriptionPartieGolf = new frmInscriptionPartieGolf();
        frmInscriptionDepense inscriptionDepense = new frmInscriptionDepense();
        string strNoUtilisateurConnexion = "";
        int noTypeEmploye ;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnGestionEmployes_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionEmployes.ShowDialog();
            this.Show();

            
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        { 
            
            
            //voir commment je peux reccuperer le noEmploye de la connexion
            strNoUtilisateurConnexion = frmConnexion.strNoUtilisateur;
            noTypeEmploye = frmConnexion.noTypeEmploye;


            if (noTypeEmploye == 1)
                lblTitre.Text = "Gestion de Clubs de golf\nAdministrateur!";
            else if (noTypeEmploye == 2)
                lblTitre.Text = "Gestion de Clubs de golf\nDirection!";
            else if (noTypeEmploye == 3)
                lblTitre.Text = "Gestion de Clubs de golf\nPropriétaire d'un club!";
            else if (noTypeEmploye == 4)
                lblTitre.Text = "Gestion de Clubs de golf\nEmploye d'un club!";
            else if (noTypeEmploye == 5)
                lblTitre.Text = "Gestion de Clubs de golf\nEmployé Pro-Shop!";
            else if (noTypeEmploye == 6)
                lblTitre.Text = "Gestion de Clubs de golf\nEmploye d'un restaurant!";
            else if (noTypeEmploye == 7)
                lblTitre.Text = "Gestion de Clubs de golf\nProfesseur de golf!";




            //  MessageBox.Show(noTypeEmploye.ToString());
            //Validation des buttons du menu principal selon l'employe qui se connecte
            if (noTypeEmploye == 1 || noTypeEmploye == 2)
            {
                btnGestionEmployes.Enabled = true;
                btnAbonnement.Enabled = true;
                btnReabonnement.Enabled = true;
                btnMiseAJourAbonnes.Enabled = true;
                btnInscriptionPartie.Enabled = true;
                btnModifPrix.Enabled = true;
                btnVisualisationRpports.Enabled = true;
                btnVisualisationStats.Enabled = true;
                btnInscriptionDepense.Enabled = true;
            }
            else if (noTypeEmploye == 3 )
            {
                btnGestionEmployes.Enabled = false;
               

                btnAbonnement.Enabled = true;
                btnReabonnement.Enabled = true;
                btnMiseAJourAbonnes.Enabled = true;
                btnModifPrix.Enabled = true;
                btnInscriptionPartie.Enabled = true;
                btnInscriptionDepense.Enabled = true;
                btnVisualisationRpports.Enabled = true;
                btnVisualisationStats.Enabled = true;
            }
            else if (noTypeEmploye == 4)
            {


                btnInscriptionDepense.Enabled = false;
                btnGestionEmployes.Enabled = false;
                btnModifPrix.Enabled = false;
                btnVisualisationRpports.Enabled = false;
                btnVisualisationStats.Enabled = false;

                btnAbonnement.Enabled = true;
                btnReabonnement.Enabled = true;
                btnMiseAJourAbonnes.Enabled = true;
                btnInscriptionPartie.Enabled = true;

            }
            else 
            {
                btnInscriptionDepense.Enabled = true;

                btnGestionEmployes.Enabled = false;
                btnAbonnement.Enabled = false;
                btnReabonnement.Enabled = false;
                btnMiseAJourAbonnes.Enabled = false;
                btnInscriptionPartie.Enabled = false;
                btnModifPrix.Enabled = false;
                btnVisualisationRpports.Enabled = false;
                btnVisualisationStats.Enabled = false;
            

            }
          
         
        }

        private void btnInscriptionPartie_Click(object sender, EventArgs e)
        {
            this.Hide();
            inscriptionPartieGolf.ShowDialog();
            this.Show();
        }

        private void btnInscriptionDepense_Click(object sender, EventArgs e)
        {
            this.Hide();
            inscriptionDepense.ShowDialog();
            this.Show();
        }
    }
}
