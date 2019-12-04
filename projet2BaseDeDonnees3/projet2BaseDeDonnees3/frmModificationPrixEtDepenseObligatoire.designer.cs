namespace projet2BaseDeDonnees3
{
    partial class frmModificationPrixEtDepenseObligatoire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixDepensesAbonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnregistrerModification = new System.Windows.Forms.Button();
            this.cbTypeAbonnement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDepenseObligatoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataSource = typeof(projet2BaseDeDonnees3.PrixDepensesAbonnements);
            // 
            // prixDepensesAbonnementsDataGridView
            // 
            this.prixDepensesAbonnementsDataGridView.AllowUserToAddRows = false;
            this.prixDepensesAbonnementsDataGridView.AllowUserToDeleteRows = false;
            this.prixDepensesAbonnementsDataGridView.AutoGenerateColumns = false;
            this.prixDepensesAbonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prixDepensesAbonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbTypeAbonnement,
            this.tbPrix,
            this.tbDepenseObligatoire,
            this.tbAnnee});
            this.prixDepensesAbonnementsDataGridView.DataSource = this.prixDepensesAbonnementsBindingSource;
            this.prixDepensesAbonnementsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.prixDepensesAbonnementsDataGridView.Name = "prixDepensesAbonnementsDataGridView";
            this.prixDepensesAbonnementsDataGridView.RowHeadersWidth = 62;
            this.prixDepensesAbonnementsDataGridView.RowTemplate.Height = 28;
            this.prixDepensesAbonnementsDataGridView.Size = new System.Drawing.Size(617, 220);
            this.prixDepensesAbonnementsDataGridView.TabIndex = 1;
            this.prixDepensesAbonnementsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.prixDepensesAbonnementsDataGridView_CellEndEdit);
            this.prixDepensesAbonnementsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.prixDepensesAbonnementsDataGridView_CellValidating);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(projet2BaseDeDonnees3.TypesAbonnement);
            // 
            // btnEnregistrerModification
            // 
            this.btnEnregistrerModification.Location = new System.Drawing.Point(204, 254);
            this.btnEnregistrerModification.Name = "btnEnregistrerModification";
            this.btnEnregistrerModification.Size = new System.Drawing.Size(256, 78);
            this.btnEnregistrerModification.TabIndex = 2;
            this.btnEnregistrerModification.Text = "Enregistrer les modifications";
            this.btnEnregistrerModification.UseVisualStyleBackColor = true;
            this.btnEnregistrerModification.Click += new System.EventHandler(this.btnEnregistrerModification_Click);
            // 
            // cbTypeAbonnement
            // 
            this.cbTypeAbonnement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbTypeAbonnement.DataPropertyName = "NoTypeAbonnement";
            this.cbTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.cbTypeAbonnement.DisplayMember = "Description";
            this.cbTypeAbonnement.HeaderText = "Type d\'abonnement";
            this.cbTypeAbonnement.MinimumWidth = 8;
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.ReadOnly = true;
            this.cbTypeAbonnement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbTypeAbonnement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbTypeAbonnement.ValueMember = "No";
            this.cbTypeAbonnement.Width = 218;
            // 
            // tbPrix
            // 
            this.tbPrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbPrix.DataPropertyName = "Prix";
            this.tbPrix.HeaderText = "Prix";
            this.tbPrix.MinimumWidth = 8;
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Width = 85;
            // 
            // tbDepenseObligatoire
            // 
            this.tbDepenseObligatoire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbDepenseObligatoire.DataPropertyName = "DepensesObligatoires";
            this.tbDepenseObligatoire.HeaderText = "Depenses obligatoires";
            this.tbDepenseObligatoire.MinimumWidth = 8;
            this.tbDepenseObligatoire.Name = "tbDepenseObligatoire";
            this.tbDepenseObligatoire.Width = 239;
            // 
            // tbAnnee
            // 
            this.tbAnnee.DataPropertyName = "Annee";
            this.tbAnnee.HeaderText = "Annee";
            this.tbAnnee.MinimumWidth = 8;
            this.tbAnnee.Name = "tbAnnee";
            this.tbAnnee.Visible = false;
            this.tbAnnee.Width = 150;
            // 
            // frmModificationPrixEtDepenseObligatoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 375);
            this.Controls.Add(this.btnEnregistrerModification);
            this.Controls.Add(this.prixDepensesAbonnementsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificationPrixEtDepenseObligatoire";
            this.Text = "frmModificationPrixEtDepenseObligatoire";
            this.Load += new System.EventHandler(this.frmModificationPrixEtDepenseObligatoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private System.Windows.Forms.DataGridView prixDepensesAbonnementsDataGridView;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Button btnEnregistrerModification;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbTypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDepenseObligatoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbAnnee;
    }
}