namespace projet2BaseDeDonnees3
{
    partial class frmNouvelAbonnement
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
            System.Windows.Forms.Label lblTelephone;
            System.Windows.Forms.Label lblCourriel;
            System.Windows.Forms.Label lblCellulaire;
            System.Windows.Forms.Label lblProvince;
            System.Windows.Forms.Label lblCodePostal;
            System.Windows.Forms.Label lblVille;
            System.Windows.Forms.Label lblRue;
            System.Windows.Forms.Label lblNoCivique;
            System.Windows.Forms.Label lblSexe;
            System.Windows.Forms.Label lblDateNaissance;
            System.Windows.Forms.Label lblNom;
            System.Windows.Forms.Label lblPrenom;
            System.Windows.Forms.Label lblRemarqueConjoint;
            System.Windows.Forms.Label lblDateNaissanceConjoint;
            System.Windows.Forms.Label lblSexeConjoint;
            System.Windows.Forms.Label lblNomConjoint;
            System.Windows.Forms.Label lblPrenomConjoint;
            System.Windows.Forms.Label lblRemarqueEnfant;
            System.Windows.Forms.Label lblDateNaissanceEnfant;
            System.Windows.Forms.Label lblSexeEnfant;
            System.Windows.Forms.Label lblNomEnfant;
            System.Windows.Forms.Label lblPrenomEnfant;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouvelAbonnement));
            this.lblRemarque = new System.Windows.Forms.Label();
            this.btnAjouterAbonnement = new System.Windows.Forms.Button();
            this.lblTypeAbonnement = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.numNoCivique = new System.Windows.Forms.NumericUpDown();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.ddlTypesAbonnement = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ddlSexes = new System.Windows.Forms.ComboBox();
            this.sexeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.ddlProvinces = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.gbConjoint = new System.Windows.Forms.GroupBox();
            this.btnAjouterConjoint = new System.Windows.Forms.Button();
            this.ddlSexeConjoint = new System.Windows.Forms.ComboBox();
            this.tbRemarqueConjoint = new System.Windows.Forms.TextBox();
            this.dtpDateNaissanceConjoint = new System.Windows.Forms.DateTimePicker();
            this.tbNomConjoint = new System.Windows.Forms.TextBox();
            this.tbPrenomConjoint = new System.Windows.Forms.TextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.nupNbEnfant = new System.Windows.Forms.NumericUpDown();
            this.gbEnfant = new System.Windows.Forms.GroupBox();
            this.btnAjouterEnfant = new System.Windows.Forms.Button();
            this.ddlSexeEnfant = new System.Windows.Forms.ComboBox();
            this.tbRemarqueEnfant = new System.Windows.Forms.TextBox();
            this.dtpDateDeNaissanceEnfant = new System.Windows.Forms.DateTimePicker();
            this.tbNomEnfant = new System.Windows.Forms.TextBox();
            this.tbPrenomEnfant = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.gbAbonnePrincipale = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            lblCourriel = new System.Windows.Forms.Label();
            lblCellulaire = new System.Windows.Forms.Label();
            lblProvince = new System.Windows.Forms.Label();
            lblCodePostal = new System.Windows.Forms.Label();
            lblVille = new System.Windows.Forms.Label();
            lblRue = new System.Windows.Forms.Label();
            lblNoCivique = new System.Windows.Forms.Label();
            lblSexe = new System.Windows.Forms.Label();
            lblDateNaissance = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblPrenom = new System.Windows.Forms.Label();
            lblRemarqueConjoint = new System.Windows.Forms.Label();
            lblDateNaissanceConjoint = new System.Windows.Forms.Label();
            lblSexeConjoint = new System.Windows.Forms.Label();
            lblNomConjoint = new System.Windows.Forms.Label();
            lblPrenomConjoint = new System.Windows.Forms.Label();
            lblRemarqueEnfant = new System.Windows.Forms.Label();
            lblDateNaissanceEnfant = new System.Windows.Forms.Label();
            lblSexeEnfant = new System.Windows.Forms.Label();
            lblNomEnfant = new System.Windows.Forms.Label();
            lblPrenomEnfant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            this.gbConjoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbEnfant)).BeginInit();
            this.gbEnfant.SuspendLayout();
            this.gbAbonnePrincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(20, 350);
            lblTelephone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(95, 17);
            lblTelephone.TabIndex = 62;
            lblTelephone.Text = "Téléphone :";
            // 
            // lblCourriel
            // 
            lblCourriel.AutoSize = true;
            lblCourriel.Location = new System.Drawing.Point(20, 434);
            lblCourriel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblCourriel.Name = "lblCourriel";
            lblCourriel.Size = new System.Drawing.Size(75, 17);
            lblCourriel.TabIndex = 61;
            lblCourriel.Text = "Courriel :";
            // 
            // lblCellulaire
            // 
            lblCellulaire.AutoSize = true;
            lblCellulaire.Location = new System.Drawing.Point(20, 392);
            lblCellulaire.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblCellulaire.Name = "lblCellulaire";
            lblCellulaire.Size = new System.Drawing.Size(86, 17);
            lblCellulaire.TabIndex = 60;
            lblCellulaire.Text = "Cellulaire :";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Location = new System.Drawing.Point(20, 269);
            lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new System.Drawing.Size(81, 17);
            lblProvince.TabIndex = 58;
            lblProvince.Text = "Province :";
            // 
            // lblCodePostal
            // 
            lblCodePostal.AutoSize = true;
            lblCodePostal.Location = new System.Drawing.Point(20, 310);
            lblCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCodePostal.Name = "lblCodePostal";
            lblCodePostal.Size = new System.Drawing.Size(104, 17);
            lblCodePostal.TabIndex = 57;
            lblCodePostal.Text = "Code postal :";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new System.Drawing.Point(20, 231);
            lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVille.Name = "lblVille";
            lblVille.Size = new System.Drawing.Size(49, 17);
            lblVille.TabIndex = 53;
            lblVille.Text = "Ville :";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new System.Drawing.Point(400, 191);
            lblRue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRue.Name = "lblRue";
            lblRue.Size = new System.Drawing.Size(47, 17);
            lblRue.TabIndex = 50;
            lblRue.Text = "Rue :";
            // 
            // lblNoCivique
            // 
            lblNoCivique.AutoSize = true;
            lblNoCivique.Location = new System.Drawing.Point(20, 191);
            lblNoCivique.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNoCivique.Name = "lblNoCivique";
            lblNoCivique.Size = new System.Drawing.Size(92, 17);
            lblNoCivique.TabIndex = 47;
            lblNoCivique.Text = "N° civique :";
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Location = new System.Drawing.Point(20, 115);
            lblSexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new System.Drawing.Size(53, 17);
            lblSexe.TabIndex = 44;
            lblSexe.Text = "Sexe :";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(20, 152);
            lblDateNaissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(153, 17);
            lblDateNaissance.TabIndex = 41;
            lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(20, 76);
            lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(50, 17);
            lblNom.TabIndex = 38;
            lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new System.Drawing.Point(20, 39);
            lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(68, 17);
            lblPrenom.TabIndex = 37;
            lblPrenom.Text = "Prénom:";
            // 
            // lblRemarqueConjoint
            // 
            lblRemarqueConjoint.AutoSize = true;
            lblRemarqueConjoint.Location = new System.Drawing.Point(81, 188);
            lblRemarqueConjoint.Name = "lblRemarqueConjoint";
            lblRemarqueConjoint.Size = new System.Drawing.Size(92, 17);
            lblRemarqueConjoint.TabIndex = 27;
            lblRemarqueConjoint.Text = "Remarque :";
            // 
            // lblDateNaissanceConjoint
            // 
            lblDateNaissanceConjoint.AutoSize = true;
            lblDateNaissanceConjoint.Location = new System.Drawing.Point(81, 152);
            lblDateNaissanceConjoint.Name = "lblDateNaissanceConjoint";
            lblDateNaissanceConjoint.Size = new System.Drawing.Size(153, 17);
            lblDateNaissanceConjoint.TabIndex = 25;
            lblDateNaissanceConjoint.Text = "Date de naissance :";
            // 
            // lblSexeConjoint
            // 
            lblSexeConjoint.AutoSize = true;
            lblSexeConjoint.Location = new System.Drawing.Point(81, 113);
            lblSexeConjoint.Name = "lblSexeConjoint";
            lblSexeConjoint.Size = new System.Drawing.Size(53, 17);
            lblSexeConjoint.TabIndex = 24;
            lblSexeConjoint.Text = "Sexe :";
            // 
            // lblNomConjoint
            // 
            lblNomConjoint.AutoSize = true;
            lblNomConjoint.Location = new System.Drawing.Point(81, 76);
            lblNomConjoint.Name = "lblNomConjoint";
            lblNomConjoint.Size = new System.Drawing.Size(50, 17);
            lblNomConjoint.TabIndex = 21;
            lblNomConjoint.Text = "Nom :";
            // 
            // lblPrenomConjoint
            // 
            lblPrenomConjoint.AutoSize = true;
            lblPrenomConjoint.Location = new System.Drawing.Point(81, 39);
            lblPrenomConjoint.Name = "lblPrenomConjoint";
            lblPrenomConjoint.Size = new System.Drawing.Size(73, 17);
            lblPrenomConjoint.TabIndex = 20;
            lblPrenomConjoint.Text = "Prénom :";
            // 
            // lblRemarqueEnfant
            // 
            lblRemarqueEnfant.AutoSize = true;
            lblRemarqueEnfant.Location = new System.Drawing.Point(81, 188);
            lblRemarqueEnfant.Name = "lblRemarqueEnfant";
            lblRemarqueEnfant.Size = new System.Drawing.Size(92, 17);
            lblRemarqueEnfant.TabIndex = 27;
            lblRemarqueEnfant.Text = "Remarque :";
            // 
            // lblDateNaissanceEnfant
            // 
            lblDateNaissanceEnfant.AutoSize = true;
            lblDateNaissanceEnfant.Location = new System.Drawing.Point(81, 152);
            lblDateNaissanceEnfant.Name = "lblDateNaissanceEnfant";
            lblDateNaissanceEnfant.Size = new System.Drawing.Size(153, 17);
            lblDateNaissanceEnfant.TabIndex = 25;
            lblDateNaissanceEnfant.Text = "Date de naissance :";
            // 
            // lblSexeEnfant
            // 
            lblSexeEnfant.AutoSize = true;
            lblSexeEnfant.Location = new System.Drawing.Point(81, 113);
            lblSexeEnfant.Name = "lblSexeEnfant";
            lblSexeEnfant.Size = new System.Drawing.Size(53, 17);
            lblSexeEnfant.TabIndex = 24;
            lblSexeEnfant.Text = "Sexe :";
            // 
            // lblNomEnfant
            // 
            lblNomEnfant.AutoSize = true;
            lblNomEnfant.Location = new System.Drawing.Point(81, 76);
            lblNomEnfant.Name = "lblNomEnfant";
            lblNomEnfant.Size = new System.Drawing.Size(50, 17);
            lblNomEnfant.TabIndex = 21;
            lblNomEnfant.Text = "Nom :";
            // 
            // lblPrenomEnfant
            // 
            lblPrenomEnfant.AutoSize = true;
            lblPrenomEnfant.Location = new System.Drawing.Point(81, 39);
            lblPrenomEnfant.Name = "lblPrenomEnfant";
            lblPrenomEnfant.Size = new System.Drawing.Size(73, 17);
            lblPrenomEnfant.TabIndex = 20;
            lblPrenomEnfant.Text = "Prénom :";
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(20, 571);
            this.lblRemarque.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(92, 17);
            this.lblRemarque.TabIndex = 64;
            this.lblRemarque.Text = "Remarque :";
            // 
            // btnAjouterAbonnement
            // 
            this.btnAjouterAbonnement.Location = new System.Drawing.Point(132, 669);
            this.btnAjouterAbonnement.Margin = new System.Windows.Forms.Padding(6);
            this.btnAjouterAbonnement.Name = "btnAjouterAbonnement";
            this.btnAjouterAbonnement.Size = new System.Drawing.Size(308, 65);
            this.btnAjouterAbonnement.TabIndex = 56;
            this.btnAjouterAbonnement.Text = "Ajouter l\'abonnement";
            this.btnAjouterAbonnement.UseVisualStyleBackColor = true;
            this.btnAjouterAbonnement.Click += new System.EventHandler(this.btnAjouterAbonnement_Click);
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Location = new System.Drawing.Point(20, 474);
            this.lblTypeAbonnement.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(161, 17);
            this.lblTypeAbonnement.TabIndex = 63;
            this.lblTypeAbonnement.Text = "Type d\'abonnement :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(265, 555);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(6);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(429, 93);
            this.tbRemarque.TabIndex = 55;
            // 
            // numNoCivique
            // 
            this.numNoCivique.Location = new System.Drawing.Point(265, 189);
            this.numNoCivique.Margin = new System.Windows.Forms.Padding(6);
            this.numNoCivique.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numNoCivique.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNoCivique.Name = "numNoCivique";
            this.numNoCivique.Size = new System.Drawing.Size(108, 23);
            this.numNoCivique.TabIndex = 42;
            this.numNoCivique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Location = new System.Drawing.Point(265, 389);
            this.mtbCellulaire.Margin = new System.Windows.Forms.Padding(6);
            this.mtbCellulaire.Mask = "(000) 000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(212, 23);
            this.mtbCellulaire.TabIndex = 51;
            this.mtbCellulaire.Text = "1234567890";
            this.mtbCellulaire.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCellulaire_Validating);
            this.mtbCellulaire.Validated += new System.EventHandler(this.mtbCellulaire_Validated);
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(265, 347);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(6);
            this.mtbTelephone.Mask = "(000) 000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(212, 23);
            this.mtbTelephone.TabIndex = 49;
            this.mtbTelephone.Text = "1234567890";
            this.mtbTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTelephone_Validating);
            this.mtbTelephone.Validated += new System.EventHandler(this.mtbTelephone_Validated);
            // 
            // ddlTypesAbonnement
            // 
            this.ddlTypesAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.ddlTypesAbonnement.DisplayMember = "Description";
            this.ddlTypesAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTypesAbonnement.FormattingEnabled = true;
            this.ddlTypesAbonnement.Location = new System.Drawing.Point(265, 471);
            this.ddlTypesAbonnement.Margin = new System.Windows.Forms.Padding(4);
            this.ddlTypesAbonnement.Name = "ddlTypesAbonnement";
            this.ddlTypesAbonnement.Size = new System.Drawing.Size(429, 24);
            this.ddlTypesAbonnement.TabIndex = 54;
            this.ddlTypesAbonnement.ValueMember = "No";
            this.ddlTypesAbonnement.SelectedIndexChanged += new System.EventHandler(this.ddlTypesAbonnement_SelectedIndexChanged);
            this.ddlTypesAbonnement.Validating += new System.ComponentModel.CancelEventHandler(this.ddlTypesAbonnement_Validating);
            this.ddlTypesAbonnement.Validated += new System.EventHandler(this.ddlTypesAbonnement_Validated);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(projet2BaseDeDonnees3.TypesAbonnement);
            // 
            // ddlSexes
            // 
            this.ddlSexes.DataSource = this.sexeBindingSource;
            this.ddlSexes.DisplayMember = "Nom";
            this.ddlSexes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexes.FormattingEnabled = true;
            this.ddlSexes.Location = new System.Drawing.Point(265, 110);
            this.ddlSexes.Margin = new System.Windows.Forms.Padding(4);
            this.ddlSexes.Name = "ddlSexes";
            this.ddlSexes.Size = new System.Drawing.Size(212, 24);
            this.ddlSexes.TabIndex = 39;
            this.ddlSexes.ValueMember = "Id";
            // 
            // sexeBindingSource
            // 
            this.sexeBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Sexe);
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Location = new System.Drawing.Point(265, 307);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(104, 23);
            this.mtbCodePostal.TabIndex = 48;
            this.mtbCodePostal.Text = "q1w2e3";
            this.mtbCodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCodePostal_Validating);
            this.mtbCodePostal.Validated += new System.EventHandler(this.mtbCodePostal_Validated);
            // 
            // ddlProvinces
            // 
            this.ddlProvinces.DataSource = this.provincesBindingSource;
            this.ddlProvinces.DisplayMember = "Nom";
            this.ddlProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProvinces.FormattingEnabled = true;
            this.ddlProvinces.Location = new System.Drawing.Point(265, 266);
            this.ddlProvinces.Margin = new System.Windows.Forms.Padding(4);
            this.ddlProvinces.Name = "ddlProvinces";
            this.ddlProvinces.Size = new System.Drawing.Size(320, 24);
            this.ddlProvinces.TabIndex = 46;
            this.ddlProvinces.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Provinces);
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(265, 228);
            this.tbVille.Margin = new System.Windows.Forms.Padding(4);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(429, 23);
            this.tbVille.TabIndex = 45;
            this.tbVille.Text = "Montréal";
            this.tbVille.Validating += new System.ComponentModel.CancelEventHandler(this.tbVille_Validating);
            this.tbVille.Validated += new System.EventHandler(this.tbVille_Validated);
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(482, 188);
            this.tbRue.Margin = new System.Windows.Forms.Padding(4);
            this.tbRue.MaxLength = 50;
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(212, 23);
            this.tbRue.TabIndex = 43;
            this.tbRue.Text = "ok";
            this.tbRue.Validating += new System.ComponentModel.CancelEventHandler(this.tbRue_Validating);
            this.tbRue.Validated += new System.EventHandler(this.tbRue_Validated);
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(265, 151);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(320, 23);
            this.dtpDateNaissance.TabIndex = 40;
            this.dtpDateNaissance.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateNaissance_Validating);
            this.dtpDateNaissance.Validated += new System.EventHandler(this.dtpDateNaissance_Validated);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(265, 73);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(212, 23);
            this.tbNom.TabIndex = 36;
            this.tbNom.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            this.tbNom.Validated += new System.EventHandler(this.tbNom_Validated);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(265, 35);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(212, 23);
            this.tbPrenom.TabIndex = 35;
            this.tbPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            this.tbPrenom.Validated += new System.EventHandler(this.tbPrenom_Validated);
            // 
            // gbConjoint
            // 
            this.gbConjoint.Controls.Add(this.btnAjouterConjoint);
            this.gbConjoint.Controls.Add(this.ddlSexeConjoint);
            this.gbConjoint.Controls.Add(lblRemarqueConjoint);
            this.gbConjoint.Controls.Add(this.tbRemarqueConjoint);
            this.gbConjoint.Controls.Add(lblDateNaissanceConjoint);
            this.gbConjoint.Controls.Add(this.dtpDateNaissanceConjoint);
            this.gbConjoint.Controls.Add(lblSexeConjoint);
            this.gbConjoint.Controls.Add(lblNomConjoint);
            this.gbConjoint.Controls.Add(this.tbNomConjoint);
            this.gbConjoint.Controls.Add(lblPrenomConjoint);
            this.gbConjoint.Controls.Add(this.tbPrenomConjoint);
            this.gbConjoint.Enabled = false;
            this.gbConjoint.Location = new System.Drawing.Point(772, 12);
            this.gbConjoint.Name = "gbConjoint";
            this.gbConjoint.Size = new System.Drawing.Size(634, 337);
            this.gbConjoint.TabIndex = 65;
            this.gbConjoint.TabStop = false;
            this.gbConjoint.Text = "Conjoint(e)";
            // 
            // btnAjouterConjoint
            // 
            this.btnAjouterConjoint.Location = new System.Drawing.Point(171, 269);
            this.btnAjouterConjoint.Margin = new System.Windows.Forms.Padding(6);
            this.btnAjouterConjoint.Name = "btnAjouterConjoint";
            this.btnAjouterConjoint.Size = new System.Drawing.Size(308, 65);
            this.btnAjouterConjoint.TabIndex = 57;
            this.btnAjouterConjoint.Text = "Ajouter Conjoint(e)";
            this.btnAjouterConjoint.UseVisualStyleBackColor = true;
            this.btnAjouterConjoint.Click += new System.EventHandler(this.btnAjouterConjoint_Click);
            // 
            // ddlSexeConjoint
            // 
            this.ddlSexeConjoint.DataSource = this.sexeBindingSource;
            this.ddlSexeConjoint.DisplayMember = "Nom";
            this.ddlSexeConjoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexeConjoint.FormattingEnabled = true;
            this.ddlSexeConjoint.Location = new System.Drawing.Point(296, 112);
            this.ddlSexeConjoint.Name = "ddlSexeConjoint";
            this.ddlSexeConjoint.Size = new System.Drawing.Size(148, 24);
            this.ddlSexeConjoint.TabIndex = 29;
            this.ddlSexeConjoint.ValueMember = "Id";
            // 
            // tbRemarqueConjoint
            // 
            this.tbRemarqueConjoint.Location = new System.Drawing.Point(296, 188);
            this.tbRemarqueConjoint.MaxLength = 500;
            this.tbRemarqueConjoint.Multiline = true;
            this.tbRemarqueConjoint.Name = "tbRemarqueConjoint";
            this.tbRemarqueConjoint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarqueConjoint.Size = new System.Drawing.Size(298, 75);
            this.tbRemarqueConjoint.TabIndex = 28;
            // 
            // dtpDateNaissanceConjoint
            // 
            this.dtpDateNaissanceConjoint.Location = new System.Drawing.Point(296, 151);
            this.dtpDateNaissanceConjoint.Name = "dtpDateNaissanceConjoint";
            this.dtpDateNaissanceConjoint.Size = new System.Drawing.Size(223, 23);
            this.dtpDateNaissanceConjoint.TabIndex = 26;
            // 
            // tbNomConjoint
            // 
            this.tbNomConjoint.Location = new System.Drawing.Point(296, 76);
            this.tbNomConjoint.MaxLength = 50;
            this.tbNomConjoint.Name = "tbNomConjoint";
            this.tbNomConjoint.Size = new System.Drawing.Size(148, 23);
            this.tbNomConjoint.TabIndex = 23;
            this.tbNomConjoint.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            this.tbNomConjoint.Validated += new System.EventHandler(this.tbNom_Validated);
            // 
            // tbPrenomConjoint
            // 
            this.tbPrenomConjoint.Location = new System.Drawing.Point(296, 39);
            this.tbPrenomConjoint.MaxLength = 50;
            this.tbPrenomConjoint.Name = "tbPrenomConjoint";
            this.tbPrenomConjoint.Size = new System.Drawing.Size(148, 23);
            this.tbPrenomConjoint.TabIndex = 22;
            this.tbPrenomConjoint.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            this.tbPrenomConjoint.Validated += new System.EventHandler(this.tbPrenom_Validated);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // nupNbEnfant
            // 
            this.nupNbEnfant.Enabled = false;
            this.nupNbEnfant.Location = new System.Drawing.Point(265, 513);
            this.nupNbEnfant.Margin = new System.Windows.Forms.Padding(6);
            this.nupNbEnfant.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupNbEnfant.Name = "nupNbEnfant";
            this.nupNbEnfant.Size = new System.Drawing.Size(108, 23);
            this.nupNbEnfant.TabIndex = 66;
            this.nupNbEnfant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNbEnfant.ValueChanged += new System.EventHandler(this.nupNbEnfant_ValueChanged);
            // 
            // gbEnfant
            // 
            this.gbEnfant.Controls.Add(this.btnAjouterEnfant);
            this.gbEnfant.Controls.Add(this.ddlSexeEnfant);
            this.gbEnfant.Controls.Add(lblRemarqueEnfant);
            this.gbEnfant.Controls.Add(this.tbRemarqueEnfant);
            this.gbEnfant.Controls.Add(lblDateNaissanceEnfant);
            this.gbEnfant.Controls.Add(this.dtpDateDeNaissanceEnfant);
            this.gbEnfant.Controls.Add(lblSexeEnfant);
            this.gbEnfant.Controls.Add(lblNomEnfant);
            this.gbEnfant.Controls.Add(this.tbNomEnfant);
            this.gbEnfant.Controls.Add(lblPrenomEnfant);
            this.gbEnfant.Controls.Add(this.tbPrenomEnfant);
            this.gbEnfant.Enabled = false;
            this.gbEnfant.Location = new System.Drawing.Point(772, 362);
            this.gbEnfant.Name = "gbEnfant";
            this.gbEnfant.Size = new System.Drawing.Size(634, 347);
            this.gbEnfant.TabIndex = 66;
            this.gbEnfant.TabStop = false;
            this.gbEnfant.Text = "Enfant(s)";
            // 
            // btnAjouterEnfant
            // 
            this.btnAjouterEnfant.Location = new System.Drawing.Point(171, 272);
            this.btnAjouterEnfant.Margin = new System.Windows.Forms.Padding(6);
            this.btnAjouterEnfant.Name = "btnAjouterEnfant";
            this.btnAjouterEnfant.Size = new System.Drawing.Size(308, 65);
            this.btnAjouterEnfant.TabIndex = 57;
            this.btnAjouterEnfant.Text = "Ajouter Enfant 1";
            this.btnAjouterEnfant.UseVisualStyleBackColor = true;
            this.btnAjouterEnfant.Click += new System.EventHandler(this.btnAjouterEnfant_Click);
            // 
            // ddlSexeEnfant
            // 
            this.ddlSexeEnfant.DataSource = this.sexeBindingSource;
            this.ddlSexeEnfant.DisplayMember = "Nom";
            this.ddlSexeEnfant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSexeEnfant.FormattingEnabled = true;
            this.ddlSexeEnfant.Location = new System.Drawing.Point(296, 112);
            this.ddlSexeEnfant.Name = "ddlSexeEnfant";
            this.ddlSexeEnfant.Size = new System.Drawing.Size(148, 24);
            this.ddlSexeEnfant.TabIndex = 29;
            this.ddlSexeEnfant.ValueMember = "Id";
            // 
            // tbRemarqueEnfant
            // 
            this.tbRemarqueEnfant.Location = new System.Drawing.Point(296, 188);
            this.tbRemarqueEnfant.MaxLength = 500;
            this.tbRemarqueEnfant.Multiline = true;
            this.tbRemarqueEnfant.Name = "tbRemarqueEnfant";
            this.tbRemarqueEnfant.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarqueEnfant.Size = new System.Drawing.Size(298, 75);
            this.tbRemarqueEnfant.TabIndex = 28;
            // 
            // dtpDateDeNaissanceEnfant
            // 
            this.dtpDateDeNaissanceEnfant.Location = new System.Drawing.Point(296, 151);
            this.dtpDateDeNaissanceEnfant.Name = "dtpDateDeNaissanceEnfant";
            this.dtpDateDeNaissanceEnfant.Size = new System.Drawing.Size(223, 23);
            this.dtpDateDeNaissanceEnfant.TabIndex = 26;
            // 
            // tbNomEnfant
            // 
            this.tbNomEnfant.Location = new System.Drawing.Point(296, 76);
            this.tbNomEnfant.MaxLength = 50;
            this.tbNomEnfant.Name = "tbNomEnfant";
            this.tbNomEnfant.Size = new System.Drawing.Size(148, 23);
            this.tbNomEnfant.TabIndex = 23;
            this.tbNomEnfant.Validating += new System.ComponentModel.CancelEventHandler(this.tbNom_Validating);
            this.tbNomEnfant.Validated += new System.EventHandler(this.tbNom_Validated);
            // 
            // tbPrenomEnfant
            // 
            this.tbPrenomEnfant.Location = new System.Drawing.Point(296, 39);
            this.tbPrenomEnfant.MaxLength = 50;
            this.tbPrenomEnfant.Name = "tbPrenomEnfant";
            this.tbPrenomEnfant.Size = new System.Drawing.Size(148, 23);
            this.tbPrenomEnfant.TabIndex = 22;
            this.tbPrenomEnfant.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenom_Validating);
            this.tbPrenomEnfant.Validated += new System.EventHandler(this.tbPrenom_Validated);
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(265, 431);
            this.tbCourriel.Margin = new System.Windows.Forms.Padding(6);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(429, 23);
            this.tbCourriel.TabIndex = 52;
            this.tbCourriel.Text = "test@gmail.com";
            this.tbCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.tbCourriel_Validating);
            this.tbCourriel.Validated += new System.EventHandler(this.tbCourriel_Validated);
            // 
            // gbAbonnePrincipale
            // 
            this.gbAbonnePrincipale.Controls.Add(this.label1);
            this.gbAbonnePrincipale.Controls.Add(lblPrenom);
            this.gbAbonnePrincipale.Controls.Add(this.nupNbEnfant);
            this.gbAbonnePrincipale.Controls.Add(this.tbPrenom);
            this.gbAbonnePrincipale.Controls.Add(this.tbNom);
            this.gbAbonnePrincipale.Controls.Add(lblNom);
            this.gbAbonnePrincipale.Controls.Add(this.lblRemarque);
            this.gbAbonnePrincipale.Controls.Add(this.dtpDateNaissance);
            this.gbAbonnePrincipale.Controls.Add(this.btnAjouterAbonnement);
            this.gbAbonnePrincipale.Controls.Add(lblDateNaissance);
            this.gbAbonnePrincipale.Controls.Add(this.lblTypeAbonnement);
            this.gbAbonnePrincipale.Controls.Add(lblSexe);
            this.gbAbonnePrincipale.Controls.Add(this.tbRemarque);
            this.gbAbonnePrincipale.Controls.Add(lblNoCivique);
            this.gbAbonnePrincipale.Controls.Add(this.numNoCivique);
            this.gbAbonnePrincipale.Controls.Add(this.tbRue);
            this.gbAbonnePrincipale.Controls.Add(this.mtbCellulaire);
            this.gbAbonnePrincipale.Controls.Add(lblRue);
            this.gbAbonnePrincipale.Controls.Add(this.mtbTelephone);
            this.gbAbonnePrincipale.Controls.Add(this.tbVille);
            this.gbAbonnePrincipale.Controls.Add(lblTelephone);
            this.gbAbonnePrincipale.Controls.Add(lblVille);
            this.gbAbonnePrincipale.Controls.Add(lblCourriel);
            this.gbAbonnePrincipale.Controls.Add(this.ddlProvinces);
            this.gbAbonnePrincipale.Controls.Add(this.tbCourriel);
            this.gbAbonnePrincipale.Controls.Add(lblCodePostal);
            this.gbAbonnePrincipale.Controls.Add(lblCellulaire);
            this.gbAbonnePrincipale.Controls.Add(this.mtbCodePostal);
            this.gbAbonnePrincipale.Controls.Add(this.ddlTypesAbonnement);
            this.gbAbonnePrincipale.Controls.Add(this.ddlSexes);
            this.gbAbonnePrincipale.Controls.Add(lblProvince);
            this.gbAbonnePrincipale.Location = new System.Drawing.Point(12, 12);
            this.gbAbonnePrincipale.Name = "gbAbonnePrincipale";
            this.gbAbonnePrincipale.Size = new System.Drawing.Size(706, 745);
            this.gbAbonnePrincipale.TabIndex = 68;
            this.gbAbonnePrincipale.TabStop = false;
            this.gbAbonnePrincipale.Text = "Abonné(e) principal(e)";
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblNbEnfants";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nb d\'enfants";
            // 
            // frmNouvelAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 766);
            this.Controls.Add(this.gbEnfant);
            this.Controls.Add(this.gbConjoint);
            this.Controls.Add(this.gbAbonnePrincipale);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmNouvelAbonnement";
            this.Text = "NouvelAbonnement";
            this.Load += new System.EventHandler(this.NouvelAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            this.gbConjoint.ResumeLayout(false);
            this.gbConjoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbEnfant)).EndInit();
            this.gbEnfant.ResumeLayout(false);
            this.gbEnfant.PerformLayout();
            this.gbAbonnePrincipale.ResumeLayout(false);
            this.gbAbonnePrincipale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.Button btnAjouterAbonnement;
        private System.Windows.Forms.Label lblTypeAbonnement;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.NumericUpDown numNoCivique;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.ComboBox ddlTypesAbonnement;
        private System.Windows.Forms.ComboBox ddlSexes;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.ComboBox ddlProvinces;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.BindingSource sexeBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.GroupBox gbConjoint;
        private System.Windows.Forms.Button btnAjouterConjoint;
        private System.Windows.Forms.ComboBox ddlSexeConjoint;
        private System.Windows.Forms.TextBox tbRemarqueConjoint;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceConjoint;
        private System.Windows.Forms.TextBox tbNomConjoint;
        private System.Windows.Forms.TextBox tbPrenomConjoint;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.NumericUpDown nupNbEnfant;
        private System.Windows.Forms.GroupBox gbEnfant;
        private System.Windows.Forms.Button btnAjouterEnfant;
        private System.Windows.Forms.ComboBox ddlSexeEnfant;
        private System.Windows.Forms.TextBox tbRemarqueEnfant;
        private System.Windows.Forms.DateTimePicker dtpDateDeNaissanceEnfant;
        private System.Windows.Forms.TextBox tbNomEnfant;
        private System.Windows.Forms.TextBox tbPrenomEnfant;
        private System.Windows.Forms.GroupBox gbAbonnePrincipale;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.Label label1;
    }
}