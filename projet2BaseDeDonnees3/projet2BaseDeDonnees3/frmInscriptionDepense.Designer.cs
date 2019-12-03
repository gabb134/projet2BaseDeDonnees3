namespace projet2BaseDeDonnees3
{
    partial class frmInscriptionDepense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ndMontant = new System.Windows.Forms.NumericUpDown();
            this.cbtypeService = new System.Windows.Forms.ComboBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.abonnementIdEtNomCompletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnInscriptionDepense = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRestantAtteindre = new System.Windows.Forms.TextBox();
            this.tbMontanDejaEffectue = new System.Windows.Forms.TextBox();
            this.tbEmployeOffreService = new System.Windows.Forms.TextBox();
            this.tbMontantdepensee = new System.Windows.Forms.TextBox();
            this.tbTypeServicee = new System.Windows.Forms.TextBox();
            this.tbDateDepense = new System.Windows.Forms.TextBox();
            this.tbNomComplet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementIdEtNomCompletBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ndMontant);
            this.groupBox1.Controls.Add(this.cbtypeService);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInscriptionDepense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscription d\'une dépense";
            // 
            // ndMontant
            // 
            this.ndMontant.Location = new System.Drawing.Point(243, 74);
            this.ndMontant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndMontant.Name = "ndMontant";
            this.ndMontant.Size = new System.Drawing.Size(143, 26);
            this.ndMontant.TabIndex = 57;
            // 
            // cbtypeService
            // 
            this.cbtypeService.DataSource = this.servicesBindingSource;
            this.cbtypeService.DisplayMember = "TypesService";
            this.cbtypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtypeService.FormattingEnabled = true;
            this.cbtypeService.Location = new System.Drawing.Point(185, 117);
            this.cbtypeService.Name = "cbtypeService";
            this.cbtypeService.Size = new System.Drawing.Size(201, 28);
            this.cbtypeService.TabIndex = 56;
            this.cbtypeService.ValueMember = "No";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Services);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Type de service :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Montant de la dépense ($):";
            // 
            // cbClient
            // 
            this.cbClient.DataSource = this.abonnementIdEtNomCompletBindingSource;
            this.cbClient.DisplayMember = "idNomEtPrenom";
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(132, 34);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(254, 28);
            this.cbClient.TabIndex = 52;
            this.cbClient.ValueMember = "idAbonneePrincipal";
            // 
            // abonnementIdEtNomCompletBindingSource
            // 
            this.abonnementIdEtNomCompletBindingSource.DataSource = typeof(projet2BaseDeDonnees3.AbonnementIdEtNomComplet);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Client :";
            // 
            // btnInscriptionDepense
            // 
            this.btnInscriptionDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionDepense.Location = new System.Drawing.Point(100, 177);
            this.btnInscriptionDepense.Name = "btnInscriptionDepense";
            this.btnInscriptionDepense.Size = new System.Drawing.Size(224, 47);
            this.btnInscriptionDepense.TabIndex = 7;
            this.btnInscriptionDepense.Text = "Inscrire une dépense";
            this.btnInscriptionDepense.UseVisualStyleBackColor = true;
            this.btnInscriptionDepense.Click += new System.EventHandler(this.btnInscriptionDepense_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRestantAtteindre);
            this.groupBox2.Controls.Add(this.tbMontanDejaEffectue);
            this.groupBox2.Controls.Add(this.tbEmployeOffreService);
            this.groupBox2.Controls.Add(this.tbMontantdepensee);
            this.groupBox2.Controls.Add(this.tbTypeServicee);
            this.groupBox2.Controls.Add(this.tbDateDepense);
            this.groupBox2.Controls.Add(this.tbNomComplet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 322);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information sur la dépense";
            // 
            // tbRestantAtteindre
            // 
            this.tbRestantAtteindre.Location = new System.Drawing.Point(333, 253);
            this.tbRestantAtteindre.Name = "tbRestantAtteindre";
            this.tbRestantAtteindre.Size = new System.Drawing.Size(154, 26);
            this.tbRestantAtteindre.TabIndex = 69;
            // 
            // tbMontanDejaEffectue
            // 
            this.tbMontanDejaEffectue.Location = new System.Drawing.Point(333, 216);
            this.tbMontanDejaEffectue.Name = "tbMontanDejaEffectue";
            this.tbMontanDejaEffectue.Size = new System.Drawing.Size(154, 26);
            this.tbMontanDejaEffectue.TabIndex = 68;
            // 
            // tbEmployeOffreService
            // 
            this.tbEmployeOffreService.Location = new System.Drawing.Point(333, 182);
            this.tbEmployeOffreService.Name = "tbEmployeOffreService";
            this.tbEmployeOffreService.Size = new System.Drawing.Size(154, 26);
            this.tbEmployeOffreService.TabIndex = 67;
            // 
            // tbMontantdepensee
            // 
            this.tbMontantdepensee.Location = new System.Drawing.Point(333, 145);
            this.tbMontantdepensee.Name = "tbMontantdepensee";
            this.tbMontantdepensee.Size = new System.Drawing.Size(154, 26);
            this.tbMontantdepensee.TabIndex = 66;
            // 
            // tbTypeServicee
            // 
            this.tbTypeServicee.Location = new System.Drawing.Point(333, 109);
            this.tbTypeServicee.Name = "tbTypeServicee";
            this.tbTypeServicee.Size = new System.Drawing.Size(154, 26);
            this.tbTypeServicee.TabIndex = 65;
            // 
            // tbDateDepense
            // 
            this.tbDateDepense.Location = new System.Drawing.Point(333, 75);
            this.tbDateDepense.Name = "tbDateDepense";
            this.tbDateDepense.Size = new System.Drawing.Size(154, 26);
            this.tbDateDepense.TabIndex = 64;
            // 
            // tbNomComplet
            // 
            this.tbNomComplet.Location = new System.Drawing.Point(333, 38);
            this.tbNomComplet.Name = "tbNomComplet";
            this.tbNomComplet.Size = new System.Drawing.Size(154, 26);
            this.tbNomComplet.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 24);
            this.label10.TabIndex = 62;
            this.label10.Text = "Montant restant à atteindre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Montant des dépenses déjà effectué :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 24);
            this.label8.TabIndex = 60;
            this.label8.Text = "Employé qui à offert le service :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "Montant de la dépense ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Type de service :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Date de la dépense :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Nom de l\'employé principal :";
            // 
            // frmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInscriptionDepense";
            this.Text = "Inscription d\'une dépense";
            this.Load += new System.EventHandler(this.frmInscriptionDepense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementIdEtNomCompletBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInscriptionDepense;
        private System.Windows.Forms.ComboBox cbtypeService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.BindingSource abonnementIdEtNomCompletBindingSource;
        private System.Windows.Forms.NumericUpDown ndMontant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRestantAtteindre;
        private System.Windows.Forms.TextBox tbMontanDejaEffectue;
        private System.Windows.Forms.TextBox tbEmployeOffreService;
        private System.Windows.Forms.TextBox tbMontantdepensee;
        private System.Windows.Forms.TextBox tbTypeServicee;
        private System.Windows.Forms.TextBox tbDateDepense;
        private System.Windows.Forms.TextBox tbNomComplet;
    }
}