using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
    public partial class frmMAJAbonnes : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();

        public frmMAJAbonnes()
        {
            InitializeComponent();
        }

        private void frmMAJAbonnes_Load(object sender, EventArgs e)
        {
            List<Sexe> sexes = new List<Sexe>();
            sexes.Add(new Sexe("H", "Homme"));
            sexes.Add(new Sexe("F", "Femme"));


            sexeBindingSource.DataSource = sexes;
            provincesBindingSource.DataSource = dataContext.Provinces;
            typesAbonnementBindingSource.DataSource = dataContext.TypesAbonnement;
            abonnementsBindingSource.DataSource = dataContext.Abonnements;
            dependantsBindingSource.DataSource = ((Abonnements)abonnementsBindingSource.Current).Dependants;
        }

        private void abonnementsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dependantsBindingSource.DataSource = ((Abonnements)abonnementsBindingSource.Current).Dependants;
        }

        private void abonnementsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCodePostalAbonne")
                {
                    e.Value = e.Value.ToString().Insert(3, " ");
                    e.FormattingApplied = true;
                }
                else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbTelAbonne")
                {
                    e.Value = string.Format("({0}) {1}-{2}",
                                            e.Value.ToString().Substring(0, 3),
                                            e.Value.ToString().Substring(3, 3),
                                            e.Value.ToString().Substring(6, 4));
                    e.FormattingApplied = true;
                }
                else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCelAbonne")
                {
                    e.Value = e.Value.ToString() != "" ?
                              string.Format("({0}) {1}-{2}",
                                            e.Value.ToString().Substring(0, 3),
                                            e.Value.ToString().Substring(3, 3),
                                            e.Value.ToString().Substring(6, 4)) :
                              e.Value.ToString();
                    e.FormattingApplied = true;
                }
            }
        }

        private void abonnementsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "";

            if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbPrenomAbonne")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le prénom ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le prénom doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbNoCiviqueAbonne")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le numéro civique ne peut pas être vide";
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        int.Parse(e.FormattedValue.ToString().Trim());
                    }
                    catch
                    {
                        abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le numéro civique doit être un nombre entier";
                        e.Cancel = true;
                    }
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbRueAbonne")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "La rue ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^(\\d{1,3}(e|th) )?\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "La rue doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbVille_dgAbonnes")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "La ville ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "La ville doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCodePostalAbonne")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le code postal ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^[a-zA-Z]\\d[a-zA-Z] ?\\d[a-zA-Z]\\d$"))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le code postal doit respecter le format @#@ #@# ou @#@#@#";
                    e.Cancel = true;
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbTelAbonne")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le téléphone ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^(\\(\\d{3}\\) ?\\d{3}-\\d{4}|\\d{3}-\\d{3}-\\d{4}|" +
                                        "\\d{10})$"))
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le téléphone doit respecter le format (###) ###-### ou (###)###-### " +
                        "ou ###-###-#### ou ##########";
                    e.Cancel = true;
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCelAbonne")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                       "^(\\(\\d{3}\\) ?\\d{3}-\\d{4}|\\d{3}-\\d{3}-\\d{4}|" +
                                       "\\d{10})$"))
                    {
                        abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                            "Le cellulaire doit respecter le format (###) ###-### " +
                            "ou (###)###-### ou ###-###-#### ou ##########";
                        e.Cancel = true;
                    }
                }
            }
            else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCourrielAbonne")
            {
                try
                {
                    new MailAddress(e.FormattedValue.ToString().Trim());
                }
                catch (ArgumentException)
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "Le courriel ne peut pas être vide";
                    e.Cancel = true;
                }
                catch (FormatException)
                {
                    abonnementsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le courriel n'est pas dans un format valide";
                    e.Cancel = true;
                }
            }
        }

        private void abonnementsDataGridView_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value != null)
            {
                if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCodePostalAbonne")
                {
                    if (e.Value.ToString().Count() == 6)
                    {
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 7)
                    {
                        e.Value = e.Value.ToString().Remove(3, 1);
                        e.ParsingApplied = true;
                    }
                }
                else if (abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbTelAbonne" ||
                         abonnementsDataGridView.Columns[e.ColumnIndex].Name == "tbCelAbonne")
                {
                    if (e.Value.ToString().Count() == 10)
                    {
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 12)
                    {
                        e.Value = e.Value.ToString().Remove(3, 1).Remove(6, 1);
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 13)
                    {
                        e.Value = e.Value.ToString().Remove(0, 1).Remove(3, 1).Remove(6, 1);
                        e.ParsingApplied = true;
                    }
                    else if (e.Value.ToString().Count() == 14)
                    {
                        e.Value = e.Value.ToString().Remove(0, 1).Remove(3, 2).Remove(6, 1);
                        e.ParsingApplied = true;
                    }
                }
            }
        }

        private void abonnementsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            abonnementsDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void dependantsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dependantsDataGridView.Rows[e.RowIndex].ErrorText = "";

            if (dependantsDataGridView.Columns[e.ColumnIndex].Name == "tbPrenomDependant")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dependantsDataGridView.Rows[e.RowIndex].ErrorText = "Le prénom ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dependantsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le prénom doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
            else if (dependantsDataGridView.Columns[e.ColumnIndex].Name == "tbNomDependant")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    dependantsDataGridView.Rows[e.RowIndex].ErrorText = "Le nom ne peut pas être vide";
                    e.Cancel = true;
                }
                else if (!Regex.IsMatch(e.FormattedValue.ToString().Trim(),
                                        "^\\p{L}+(([-' ]\\p{L})|\\p{L})*$"))
                {
                    dependantsDataGridView.Rows[e.RowIndex].ErrorText =
                        "Le nom doit débuter par une lettre suivi d'un tiret, apostrophe, " +
                        "espace ou lettre et se terminer par une lettre";
                    e.Cancel = true;
                }
            }
        }

        private void dependantsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dependantsDataGridView.Rows[e.RowIndex].ErrorText = "";

        }

        private void btnEnregistrerModificatoon_Click(object sender, EventArgs e)
        {
            using (TransactionScope transaction = new TransactionScope())
            {

                DialogResult dr = MessageBox.Show("Etes vous sur de vouloir enregistrer ces modifications ?\nCette opération sera irréversible", "Confirmation", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        try
                        {
                            dataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                            transaction.Complete();
                            MessageBox.Show("Les modifications ont été enregistrés dans la base de données", "Enregistrement des données");
                        }
                        catch (ChangeConflictException)
                        {
                            dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
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
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                        }
                        break;
                    case DialogResult.No:
                        break;
                }

            }
        }
    }
}
