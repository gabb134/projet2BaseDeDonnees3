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
    }
}
