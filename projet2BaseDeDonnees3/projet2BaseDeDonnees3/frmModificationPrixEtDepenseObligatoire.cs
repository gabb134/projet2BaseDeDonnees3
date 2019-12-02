using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace projet2BaseDeDonnees3
{
    public partial class frmModificationPrixEtDepenseObligatoire : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmModificationPrixEtDepenseObligatoire()
        {
            InitializeComponent();
        }

        private void frmModificationPrixEtDepenseObligatoire_Load(object sender, EventArgs e)
        {
            // typeAbonnementPrixEtDepenseObligatoireBindingSource.DataSource = dataContext.TypesAbonnement;

            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;

            prixDepensesAbonnementsBindingSource.DataSource = from typeAbonnement in dataContext.TypesAbonnement.AsEnumerable()
                                                              let derniereAnneePrixDepensesAbonnements = typeAbonnement.PrixDepensesAbonnements.Max(prixDepensesAbonnement => prixDepensesAbonnement.Annee)
                                                              let prixDepensesAbonnement = typeAbonnement.PrixDepensesAbonnements.
                                                                      Where(prixDepensesAbonnement => prixDepensesAbonnement.Annee == derniereAnneePrixDepensesAbonnements).Single()
                                                              select new PrixDepensesAbonnements
                                                              {
                                                                  NoTypeAbonnement = prixDepensesAbonnement.NoTypeAbonnement,
                                                                  Annee = DateTime.Today.Year,
                                                                  Prix = prixDepensesAbonnement.Prix,
                                                                  DepensesObligatoires = prixDepensesAbonnement.DepensesObligatoires,
                                                                  TypesAbonnement = typeAbonnement
                                                              };
        }

        private void prixDepensesAbonnementsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = "";

            if (prixDepensesAbonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbPrix")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le prix de l'abonnement ne peut pas être vide";
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        decimal.Parse(e.FormattedValue.ToString().Trim());
                    }
                    catch
                    {
                        prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le montant des dépenses obligatoires d'abonnement doit être un nombre";
                        e.Cancel = true;
                    }
                }
            }
            else if (prixDepensesAbonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbDepensesObligatoires_PrixDepensesAbonnements")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le montant des dépenses obligatoires d'abonnement ne peut pas être vide";
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        decimal.Parse(e.FormattedValue.ToString().Trim());
                    }
                    catch
                    {
                        prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le montant des dépenses obligatoires d'abonnement doit être un nombre";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void prixDepensesAbonnementsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void btnEnregistrerModification_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes vous sur de vouloir enregistrer ces modifications ?\nCette opération sera irréversible", "Confirmation", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            dataContext.SubmitChanges();
                            transaction.Complete();
                            MessageBox.Show("Les modifications ont été enregistrés dans la base de données", "Enregistrement des données");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                        }
                    }
                    break;
                case DialogResult.No:
                    break;
            }


            this.Close();
        }
    }
}
