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
    public partial class frmGestionDesEmployes : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmAjoutEmployes frmAjout;
        frmModificationEmployes frmModif;

        public frmGestionDesEmployes()
        {
            InitializeComponent();
        }

        private void frmGestionDesEmployes_Load(object sender, EventArgs e)
        {
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion connexion = new frmConnexion();
            this.Hide();
            connexion.ShowDialog();
            this.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
           // Application.Exit();
           // this.Close();
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        { 


            int noEmployeConnecter = Convert.ToInt32(frmConnexion.strNoUtilisateur);

            //int intNoEmployeSelectionee = Convert.ToInt32(employesDataGridView.CurrentRow.Cells[0].Value.ToString());

           // string strTypeEmploySelectionee =employesDataGridView.CurrentRow.Cells[2].Value.ToString();

           // int noTypeEmploye = frmConnexion.noTypeEmploye;

            // un employe qui a un service
           /* var employeQuiADesServices = from unEmploye in monDataContext.Services
                                    let noEmploye = unEmploye.NoEmploye
                                    select new { noEmploye};

            int intEmployeQuiADesService = 0;

            foreach (var employeService in employeQuiADesServices)
            {
                 intEmployeQuiADesService = employeService.noEmploye;

                
            }*/
            if(employesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vous devez sélectionner un employé pour le supprimer", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employes Emp = (from unEmploye in monDataContext.Employes
                                where unEmploye.No == (int)employesDataGridView.CurrentRow.Cells[0].Value
                                select unEmploye).FirstOrDefault();

                if (Emp.Equals(null))
                {
                    MessageBox.Show("L'employé que vous voulez supprimer n'existe pas!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Emp.Services.Count > 0)
                {
                    MessageBox.Show("L'employé que vous voulez supprimer a des services", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Emp.No.Equals(noEmployeConnecter))
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer l'employé courant.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Emp.TypesEmploye.ToString().Equals("Administrateur"))
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer l'administrateur", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {



                    var employeASupprimer = from unEmploye in monDataContext.Employes
                                            where unEmploye.No == Emp.No
                                            select unEmploye;

                    if ((MessageBox.Show("Vous êtes sur le point de supprimer un employé. \nVous êtes sûr de vouloir le faire ?", "Suppression d'un employé",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        foreach (var unEmploye in employeASupprimer)
                            employesBindingSource.Remove(unEmploye);

                        employesBindingSource.EndEdit();

                        try
                        {
                            monDataContext.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur lors de la suppression");
                        }

                    }
                }
            }


           



            //MessageBox.Show(intEmployeQuiADesService.ToString());
            // MessageBox.Show(noTypeEmploye.ToString());


            /*  if (intNoEmployeSelectionee.Equals(noEmployeConnecter))
              {
                  MessageBox.Show("Vous ne pouvez pas supprimer l'employé courant.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else if (strTypeEmploySelectionee.Equals("Administrateur"))//a faire
              {
                  MessageBox.Show("Vous ne pouvez pas supprimer l'administrateur", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {



                  var employeASupprimer = from unEmploye in monDataContext.Employes
                                          where unEmploye.No == intNoEmployeSelectionee
                                          select unEmploye;

                  if ((MessageBox.Show("Vous êtes sur le point de supprimer un employé. \nVous êtes sûr de vouloir le faire ?", "Suppression d'un employé",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
          MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                  {
                      foreach (var unEmploye in employeASupprimer)
                          employesBindingSource.Remove(unEmploye);

                      employesBindingSource.EndEdit();

                      try
                      {
                          monDataContext.SubmitChanges();
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message, "Erreur lors de la suppression");
                      }

                  }
              }*/













        }

        private void btnAjout_Click(object sender, EventArgs e)
        {

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            frmModif = new frmModificationEmployes();

            frmModif.strModificiation = "modif";
            //Recupere les infos du datagridview
            frmModif.strMotDePasse = employesDataGridView.CurrentRow.Cells[2].Value.ToString();
            frmModif.strNom = employesDataGridView.CurrentRow.Cells[3].Value.ToString();
            frmModif.strPrenom = employesDataGridView.CurrentRow.Cells[4].Value.ToString();
            frmModif.strSexe = employesDataGridView.CurrentRow.Cells[5].Value.ToString();
            frmModif.intAge = Convert.ToInt32( employesDataGridView.CurrentRow.Cells[6].Value);
            frmModif.intNoCivique = Convert.ToInt32(employesDataGridView.CurrentRow.Cells[7].Value);
            frmModif.strRue = employesDataGridView.CurrentRow.Cells[8].Value.ToString();
            frmModif.strVile = employesDataGridView.CurrentRow.Cells[9].Value.ToString();
            frmModif.strProvince = employesDataGridView.CurrentRow.Cells[10].Value.ToString();
            frmModif.strCodePostal = employesDataGridView.CurrentRow.Cells[11].Value.ToString();
            frmModif.strTelephone = employesDataGridView.CurrentRow.Cells[12].Value.ToString();
            frmModif.strCouriel = employesDataGridView.CurrentRow.Cells[13].Value.ToString();
            frmModif.intSalaire = Convert.ToInt32(employesDataGridView.CurrentRow.Cells[14].Value);
            try
            {
                if (frmModif.ShowDialog() == DialogResult.OK)
                {
                    employesDataGridView.CurrentRow.Cells[2].Value = frmModif.strMotDePasseModifier;
                    employesDataGridView.CurrentRow.Cells[3].Value = frmModif.strNomModifier;
                    employesDataGridView.CurrentRow.Cells[4].Value = frmModif.strPrenomModifier;
                    employesDataGridView.CurrentRow.Cells[5].Value = frmModif.strSexeModifier;
                    employesDataGridView.CurrentRow.Cells[6].Value = frmModif.intAgeModifier;
                    employesDataGridView.CurrentRow.Cells[7].Value = frmModif.intNoCiviqueModifier;
                    employesDataGridView.CurrentRow.Cells[8].Value = frmModif.strRueModifier;
                    employesDataGridView.CurrentRow.Cells[9].Value = frmModif.strVileModifier;
                    employesDataGridView.CurrentRow.Cells[10].Value = frmModif.strProvinceModifier.ToString(); //voir comment regler ca, car province est un objet et ne peut pas le convertir en string
                    employesDataGridView.CurrentRow.Cells[11].Value = frmModif.strCodePostalModifier;
                    employesDataGridView.CurrentRow.Cells[12].Value = frmModif.strTelephoneModifier;
                    employesDataGridView.CurrentRow.Cells[13].Value = frmModif.strCourielModifier;
                    employesDataGridView.CurrentRow.Cells[14].Value = frmModif.intSalaireModifier;

                    employesBindingSource.EndEdit();


                    try
                    {
                        monDataContext.SubmitChanges();
                        MessageBox.Show("L'employé a été modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur lors de la suppression");
                    }

                }
            }
            catch(Exception ex1)
            {

            }
            
        }
    }
}
