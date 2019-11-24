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
        string strNoUtilisateurConnexion = "";
       
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
        { //voir commment je peux reccuperer le noEmploye de la connexion
            strNoUtilisateurConnexion = frmConnexion.strNoUtilisateur;
            //Validation des buttons du menu principal selon l'employe qui se connecte
            if (strNoUtilisateurConnexion == "1" || strNoUtilisateurConnexion == "2")
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
            else if ( strNoUtilisateurConnexion == "3" )
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
            else if (strNoUtilisateurConnexion == "4")
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

            }
          
         
        }
    }
}
