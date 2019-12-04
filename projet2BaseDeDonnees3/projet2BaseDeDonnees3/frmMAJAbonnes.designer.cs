namespace projet2BaseDeDonnees3
{
    partial class frmMAJAbonnes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMAJAbonnes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonnementsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.abonnementsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.abonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnEnregistrerModificatoon = new System.Windows.Forms.Button();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbIdAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDateAbonnementAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNomAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPrenomAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSexeAbonne = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbDateNaissanceAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNoCiviqueAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRueAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVilleAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProvinceAbonne = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbCodePostalAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTelAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCelAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCourrielAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTypeAbonnementAbonne = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbRemarqueAbonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIdDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNomDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPrenomDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSexeDependant = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbDateNaissanceDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAbonnementDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbRemarqueDependant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingNavigator)).BeginInit();
            this.abonnementsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementsBindingNavigator
            // 
            this.abonnementsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.abonnementsBindingNavigator.BindingSource = this.abonnementsBindingSource;
            this.abonnementsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.abonnementsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.abonnementsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.abonnementsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.abonnementsBindingNavigatorSaveItem});
            this.abonnementsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.abonnementsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.abonnementsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.abonnementsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.abonnementsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.abonnementsBindingNavigator.Name = "abonnementsBindingNavigator";
            this.abonnementsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.abonnementsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.abonnementsBindingNavigator.Size = new System.Drawing.Size(2564, 33);
            this.abonnementsBindingNavigator.TabIndex = 0;
            this.abonnementsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Abonnements);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(70, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // abonnementsBindingNavigatorSaveItem
            // 
            this.abonnementsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abonnementsBindingNavigatorSaveItem.Enabled = false;
            this.abonnementsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("abonnementsBindingNavigatorSaveItem.Image")));
            this.abonnementsBindingNavigatorSaveItem.Name = "abonnementsBindingNavigatorSaveItem";
            this.abonnementsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.abonnementsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // abonnementsDataGridView
            // 
            this.abonnementsDataGridView.AllowUserToAddRows = false;
            this.abonnementsDataGridView.AllowUserToDeleteRows = false;
            this.abonnementsDataGridView.AutoGenerateColumns = false;
            this.abonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbIdAbonne,
            this.tbDateAbonnementAbonne,
            this.tbNomAbonne,
            this.tbPrenomAbonne,
            this.cbSexeAbonne,
            this.tbDateNaissanceAbonne,
            this.tbNoCiviqueAbonne,
            this.tbRueAbonne,
            this.tbVilleAbonne,
            this.cbProvinceAbonne,
            this.tbCodePostalAbonne,
            this.tbTelAbonne,
            this.tbCelAbonne,
            this.tbCourrielAbonne,
            this.cbTypeAbonnementAbonne,
            this.tbRemarqueAbonne});
            this.abonnementsDataGridView.DataSource = this.abonnementsBindingSource;
            this.abonnementsDataGridView.Location = new System.Drawing.Point(13, 37);
            this.abonnementsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.abonnementsDataGridView.Name = "abonnementsDataGridView";
            this.abonnementsDataGridView.RowHeadersWidth = 62;
            this.abonnementsDataGridView.RowTemplate.Height = 28;
            this.abonnementsDataGridView.Size = new System.Drawing.Size(3373, 315);
            this.abonnementsDataGridView.TabIndex = 1;
            this.abonnementsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.abonnementsDataGridView_CellEndEdit);
            this.abonnementsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.abonnementsDataGridView_CellFormatting);
            this.abonnementsDataGridView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.abonnementsDataGridView_CellParsing);
            this.abonnementsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.abonnementsDataGridView_CellValidating);
            this.abonnementsDataGridView.SelectionChanged += new System.EventHandler(this.abonnementsDataGridView_SelectionChanged);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Provinces);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(projet2BaseDeDonnees3.TypesAbonnement);
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Dependants);
            // 
            // dependantsDataGridView
            // 
            this.dependantsDataGridView.AllowUserToAddRows = false;
            this.dependantsDataGridView.AllowUserToDeleteRows = false;
            this.dependantsDataGridView.AutoGenerateColumns = false;
            this.dependantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dependantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbIdDependant,
            this.tbNomDependant,
            this.tbPrenomDependant,
            this.cbSexeDependant,
            this.tbDateNaissanceDependant,
            this.tbAbonnementDependant,
            this.tbRemarqueDependant});
            this.dependantsDataGridView.DataSource = this.dependantsBindingSource;
            this.dependantsDataGridView.Location = new System.Drawing.Point(13, 390);
            this.dependantsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dependantsDataGridView.Name = "dependantsDataGridView";
            this.dependantsDataGridView.RowHeadersWidth = 62;
            this.dependantsDataGridView.RowTemplate.Height = 28;
            this.dependantsDataGridView.Size = new System.Drawing.Size(1833, 275);
            this.dependantsDataGridView.TabIndex = 2;
            this.dependantsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dependantsDataGridView_CellEndEdit);
            this.dependantsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dependantsDataGridView_CellValidating);
            // 
            // btnEnregistrerModificatoon
            // 
            this.btnEnregistrerModificatoon.Location = new System.Drawing.Point(488, 719);
            this.btnEnregistrerModificatoon.Name = "btnEnregistrerModificatoon";
            this.btnEnregistrerModificatoon.Size = new System.Drawing.Size(411, 70);
            this.btnEnregistrerModificatoon.TabIndex = 3;
            this.btnEnregistrerModificatoon.Text = "Enregistrer les modifications dans la base de donnée";
            this.btnEnregistrerModificatoon.UseVisualStyleBackColor = true;
            this.btnEnregistrerModificatoon.Click += new System.EventHandler(this.btnEnregistrerModificatoon_Click);
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Sexe);
            // 
            // tbIdAbonne
            // 
            this.tbIdAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbIdAbonne.DataPropertyName = "Id";
            this.tbIdAbonne.HeaderText = "Id";
            this.tbIdAbonne.MinimumWidth = 8;
            this.tbIdAbonne.Name = "tbIdAbonne";
            this.tbIdAbonne.ReadOnly = true;
            this.tbIdAbonne.Width = 66;
            // 
            // tbDateAbonnementAbonne
            // 
            this.tbDateAbonnementAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbDateAbonnementAbonne.DataPropertyName = "DateAbonnement";
            this.tbDateAbonnementAbonne.HeaderText = "Date d\'abonnement";
            this.tbDateAbonnementAbonne.MinimumWidth = 8;
            this.tbDateAbonnementAbonne.Name = "tbDateAbonnementAbonne";
            this.tbDateAbonnementAbonne.ReadOnly = true;
            this.tbDateAbonnementAbonne.Width = 215;
            // 
            // tbNomAbonne
            // 
            this.tbNomAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbNomAbonne.DataPropertyName = "Nom";
            this.tbNomAbonne.HeaderText = "Nom";
            this.tbNomAbonne.MinimumWidth = 8;
            this.tbNomAbonne.Name = "tbNomAbonne";
            this.tbNomAbonne.ReadOnly = true;
            this.tbNomAbonne.Width = 92;
            // 
            // tbPrenomAbonne
            // 
            this.tbPrenomAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbPrenomAbonne.DataPropertyName = "Prenom";
            this.tbPrenomAbonne.HeaderText = "Prenom";
            this.tbPrenomAbonne.MinimumWidth = 8;
            this.tbPrenomAbonne.Name = "tbPrenomAbonne";
            this.tbPrenomAbonne.Width = 122;
            // 
            // cbSexeAbonne
            // 
            this.cbSexeAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbSexeAbonne.DataPropertyName = "Sexe";
            this.cbSexeAbonne.DataSource = this.sexeBindingSource;
            this.cbSexeAbonne.DisplayMember = "Nom";
            this.cbSexeAbonne.HeaderText = "Sexe";
            this.cbSexeAbonne.MinimumWidth = 8;
            this.cbSexeAbonne.Name = "cbSexeAbonne";
            this.cbSexeAbonne.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbSexeAbonne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbSexeAbonne.ValueMember = "Id";
            this.cbSexeAbonne.Width = 98;
            // 
            // tbDateNaissanceAbonne
            // 
            this.tbDateNaissanceAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbDateNaissanceAbonne.DataPropertyName = "DateNaissance";
            this.tbDateNaissanceAbonne.HeaderText = "Date de naissance";
            this.tbDateNaissanceAbonne.MinimumWidth = 8;
            this.tbDateNaissanceAbonne.Name = "tbDateNaissanceAbonne";
            this.tbDateNaissanceAbonne.ReadOnly = true;
            this.tbDateNaissanceAbonne.Width = 207;
            // 
            // tbNoCiviqueAbonne
            // 
            this.tbNoCiviqueAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbNoCiviqueAbonne.DataPropertyName = "NoCivique";
            this.tbNoCiviqueAbonne.HeaderText = "No civique";
            this.tbNoCiviqueAbonne.MinimumWidth = 8;
            this.tbNoCiviqueAbonne.Name = "tbNoCiviqueAbonne";
            this.tbNoCiviqueAbonne.Width = 137;
            // 
            // tbRueAbonne
            // 
            this.tbRueAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbRueAbonne.DataPropertyName = "Rue";
            this.tbRueAbonne.HeaderText = "Rue";
            this.tbRueAbonne.MinimumWidth = 8;
            this.tbRueAbonne.Name = "tbRueAbonne";
            this.tbRueAbonne.Width = 86;
            // 
            // tbVilleAbonne
            // 
            this.tbVilleAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbVilleAbonne.DataPropertyName = "Ville";
            this.tbVilleAbonne.HeaderText = "Ville";
            this.tbVilleAbonne.MinimumWidth = 8;
            this.tbVilleAbonne.Name = "tbVilleAbonne";
            this.tbVilleAbonne.Width = 90;
            // 
            // cbProvinceAbonne
            // 
            this.cbProvinceAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbProvinceAbonne.DataPropertyName = "IdProvince";
            this.cbProvinceAbonne.DataSource = this.provincesBindingSource;
            this.cbProvinceAbonne.DisplayMember = "Nom";
            this.cbProvinceAbonne.HeaderText = "Province";
            this.cbProvinceAbonne.MinimumWidth = 8;
            this.cbProvinceAbonne.Name = "cbProvinceAbonne";
            this.cbProvinceAbonne.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbProvinceAbonne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbProvinceAbonne.ValueMember = "Id";
            this.cbProvinceAbonne.Width = 132;
            // 
            // tbCodePostalAbonne
            // 
            this.tbCodePostalAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbCodePostalAbonne.DataPropertyName = "CodePostal";
            this.tbCodePostalAbonne.HeaderText = "Code postal";
            this.tbCodePostalAbonne.MinimumWidth = 8;
            this.tbCodePostalAbonne.Name = "tbCodePostalAbonne";
            this.tbCodePostalAbonne.Width = 151;
            // 
            // tbTelAbonne
            // 
            this.tbTelAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbTelAbonne.DataPropertyName = "Telephone";
            dataGridViewCellStyle8.NullValue = "000-000-0000";
            this.tbTelAbonne.DefaultCellStyle = dataGridViewCellStyle8;
            this.tbTelAbonne.HeaderText = "Telephone";
            this.tbTelAbonne.MinimumWidth = 8;
            this.tbTelAbonne.Name = "tbTelAbonne";
            this.tbTelAbonne.Width = 151;
            // 
            // tbCelAbonne
            // 
            this.tbCelAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbCelAbonne.DataPropertyName = "Cellulaire";
            this.tbCelAbonne.HeaderText = "Cellulaire";
            this.tbCelAbonne.MinimumWidth = 8;
            this.tbCelAbonne.Name = "tbCelAbonne";
            this.tbCelAbonne.Width = 139;
            // 
            // tbCourrielAbonne
            // 
            this.tbCourrielAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbCourrielAbonne.DataPropertyName = "Courriel";
            this.tbCourrielAbonne.HeaderText = "Courriel";
            this.tbCourrielAbonne.MinimumWidth = 8;
            this.tbCourrielAbonne.Name = "tbCourrielAbonne";
            this.tbCourrielAbonne.Width = 124;
            // 
            // cbTypeAbonnementAbonne
            // 
            this.cbTypeAbonnementAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbTypeAbonnementAbonne.DataPropertyName = "NoTypeAbonnement";
            this.cbTypeAbonnementAbonne.DataSource = this.typesAbonnementBindingSource;
            this.cbTypeAbonnementAbonne.DisplayMember = "Description";
            this.cbTypeAbonnementAbonne.HeaderText = "Type d\'abonnement";
            this.cbTypeAbonnementAbonne.MinimumWidth = 8;
            this.cbTypeAbonnementAbonne.Name = "cbTypeAbonnementAbonne";
            this.cbTypeAbonnementAbonne.ReadOnly = true;
            this.cbTypeAbonnementAbonne.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbTypeAbonnementAbonne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbTypeAbonnementAbonne.ValueMember = "No";
            this.cbTypeAbonnementAbonne.Width = 218;
            // 
            // tbRemarqueAbonne
            // 
            this.tbRemarqueAbonne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbRemarqueAbonne.DataPropertyName = "Remarque";
            this.tbRemarqueAbonne.HeaderText = "Remarque";
            this.tbRemarqueAbonne.MinimumWidth = 8;
            this.tbRemarqueAbonne.Name = "tbRemarqueAbonne";
            this.tbRemarqueAbonne.Width = 146;
            // 
            // tbIdDependant
            // 
            this.tbIdDependant.DataPropertyName = "Id";
            this.tbIdDependant.HeaderText = "Id";
            this.tbIdDependant.MinimumWidth = 8;
            this.tbIdDependant.Name = "tbIdDependant";
            this.tbIdDependant.ReadOnly = true;
            this.tbIdDependant.Width = 150;
            // 
            // tbNomDependant
            // 
            this.tbNomDependant.DataPropertyName = "Nom";
            this.tbNomDependant.HeaderText = "Nom";
            this.tbNomDependant.MinimumWidth = 8;
            this.tbNomDependant.Name = "tbNomDependant";
            this.tbNomDependant.Width = 150;
            // 
            // tbPrenomDependant
            // 
            this.tbPrenomDependant.DataPropertyName = "Prenom";
            this.tbPrenomDependant.HeaderText = "Prenom";
            this.tbPrenomDependant.MinimumWidth = 8;
            this.tbPrenomDependant.Name = "tbPrenomDependant";
            this.tbPrenomDependant.Width = 150;
            // 
            // cbSexeDependant
            // 
            this.cbSexeDependant.DataPropertyName = "Sexe";
            this.cbSexeDependant.DataSource = this.sexeBindingSource;
            this.cbSexeDependant.DisplayMember = "Nom";
            this.cbSexeDependant.HeaderText = "Sexe";
            this.cbSexeDependant.MinimumWidth = 8;
            this.cbSexeDependant.Name = "cbSexeDependant";
            this.cbSexeDependant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbSexeDependant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbSexeDependant.ValueMember = "Id";
            this.cbSexeDependant.Width = 150;
            // 
            // tbDateNaissanceDependant
            // 
            this.tbDateNaissanceDependant.DataPropertyName = "DateNaissance";
            this.tbDateNaissanceDependant.HeaderText = "Date de naissance";
            this.tbDateNaissanceDependant.MinimumWidth = 8;
            this.tbDateNaissanceDependant.Name = "tbDateNaissanceDependant";
            this.tbDateNaissanceDependant.ReadOnly = true;
            this.tbDateNaissanceDependant.Width = 150;
            // 
            // tbAbonnementDependant
            // 
            this.tbAbonnementDependant.DataPropertyName = "IdAbonnement";
            this.tbAbonnementDependant.HeaderText = "Abonnement";
            this.tbAbonnementDependant.MinimumWidth = 8;
            this.tbAbonnementDependant.Name = "tbAbonnementDependant";
            this.tbAbonnementDependant.ReadOnly = true;
            this.tbAbonnementDependant.Width = 150;
            // 
            // tbRemarqueDependant
            // 
            this.tbRemarqueDependant.DataPropertyName = "Remarque";
            this.tbRemarqueDependant.HeaderText = "Remarque";
            this.tbRemarqueDependant.MinimumWidth = 8;
            this.tbRemarqueDependant.Name = "tbRemarqueDependant";
            this.tbRemarqueDependant.Width = 150;
            // 
            // frmMAJAbonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 905);
            this.Controls.Add(this.btnEnregistrerModificatoon);
            this.Controls.Add(this.dependantsDataGridView);
            this.Controls.Add(this.abonnementsDataGridView);
            this.Controls.Add(this.abonnementsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMAJAbonnes";
            this.Text = "frmMAJAbonnes";
            this.Load += new System.EventHandler(this.frmMAJAbonnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingNavigator)).EndInit();
            this.abonnementsBindingNavigator.ResumeLayout(false);
            this.abonnementsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.BindingNavigator abonnementsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton abonnementsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView abonnementsDataGridView;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.DataGridView dependantsDataGridView;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Button btnEnregistrerModificatoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbIdAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateAbonnementAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNomAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrenomAbonne;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbSexeAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateNaissanceAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNoCiviqueAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRueAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbVilleAbonne;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbProvinceAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCodePostalAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbTelAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCelAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCourrielAbonne;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbTypeAbonnementAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRemarqueAbonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbIdDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNomDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPrenomDependant;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbSexeDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDateNaissanceDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbAbonnementDependant;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbRemarqueDependant;
    }
}