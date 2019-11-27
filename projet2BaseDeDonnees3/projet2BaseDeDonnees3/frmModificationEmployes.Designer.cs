namespace projet2BaseDeDonnees3
{
    partial class frmModificationEmployes
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
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmerModification = new System.Windows.Forms.Button();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.ndAge = new System.Windows.Forms.NumericUpDown();
            this.ndNumeroCivique = new System.Windows.Forms.NumericUpDown();
            this.tbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNom = new System.Windows.Forms.MaskedTextBox();
            this.tbPrenom = new System.Windows.Forms.MaskedTextBox();
            this.tbMotDePasse = new System.Windows.Forms.MaskedTextBox();
            this.tbCouriel = new System.Windows.Forms.MaskedTextBox();
            this.tbRue = new System.Windows.Forms.MaskedTextBox();
            this.tbVille = new System.Windows.Forms.MaskedTextBox();
            this.tbSalaire = new System.Windows.Forms.MaskedTextBox();
            this.tbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndNumeroCivique)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Employes);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ville :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Province :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Rue :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Code postal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Téléphone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Courriel :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Âge :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(21, 238);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(154, 24);
            this.label27.TabIndex = 16;
            this.label27.Text = "Numéro civique :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 437);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Salaire :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(208, 490);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(163, 47);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmerModification
            // 
            this.btnConfirmerModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerModification.Location = new System.Drawing.Point(39, 490);
            this.btnConfirmerModification.Name = "btnConfirmerModification";
            this.btnConfirmerModification.Size = new System.Drawing.Size(163, 47);
            this.btnConfirmerModification.TabIndex = 7;
            this.btnConfirmerModification.Text = "Confimer";
            this.btnConfirmerModification.UseVisualStyleBackColor = true;
            this.btnConfirmerModification.Click += new System.EventHandler(this.btnConfirmerModification_Click);
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cbSexe.Location = new System.Drawing.Point(209, 137);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(163, 28);
            this.cbSexe.TabIndex = 38;
            // 
            // ndAge
            // 
            this.ndAge.Location = new System.Drawing.Point(209, 173);
            this.ndAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ndAge.Name = "ndAge";
            this.ndAge.Size = new System.Drawing.Size(163, 26);
            this.ndAge.TabIndex = 39;
            this.ndAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // ndNumeroCivique
            // 
            this.ndNumeroCivique.Location = new System.Drawing.Point(209, 239);
            this.ndNumeroCivique.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.ndNumeroCivique.Name = "ndNumeroCivique";
            this.ndNumeroCivique.Size = new System.Drawing.Size(163, 26);
            this.ndNumeroCivique.TabIndex = 40;
            this.ndNumeroCivique.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(209, 408);
            this.tbTelephone.Mask = "(000) 000-0000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(163, 26);
            this.tbTelephone.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProvince);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.tbMotDePasse);
            this.groupBox1.Controls.Add(this.tbCouriel);
            this.groupBox1.Controls.Add(this.tbRue);
            this.groupBox1.Controls.Add(this.tbVille);
            this.groupBox1.Controls.Add(this.tbSalaire);
            this.groupBox1.Controls.Add(this.tbCodePostal);
            this.groupBox1.Controls.Add(this.tbTelephone);
            this.groupBox1.Controls.Add(this.ndNumeroCivique);
            this.groupBox1.Controls.Add(this.ndAge);
            this.groupBox1.Controls.Add(this.cbSexe);
            this.groupBox1.Controls.Add(this.btnConfirmerModification);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 553);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification d\'un employé";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(209, 35);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(163, 26);
            this.tbNom.TabIndex = 50;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(209, 67);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(163, 26);
            this.tbPrenom.TabIndex = 49;
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(209, 101);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(163, 26);
            this.tbMotDePasse.TabIndex = 48;
            // 
            // tbCouriel
            // 
            this.tbCouriel.Location = new System.Drawing.Point(209, 207);
            this.tbCouriel.Name = "tbCouriel";
            this.tbCouriel.Size = new System.Drawing.Size(163, 26);
            this.tbCouriel.TabIndex = 47;
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(209, 271);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(163, 26);
            this.tbRue.TabIndex = 46;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(209, 304);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(163, 26);
            this.tbVille.TabIndex = 45;
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(209, 444);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.Size = new System.Drawing.Size(163, 26);
            this.tbSalaire.TabIndex = 43;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(209, 373);
            this.tbCodePostal.Mask = "L0L-0L0";
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(163, 26);
            this.tbCodePostal.TabIndex = 42;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // cbProvince
            // 
            this.cbProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provincesBindingSource, "Nom", true));
            this.cbProvince.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.provincesBindingSource, "Nom", true));
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(208, 335);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(163, 28);
            this.cbProvince.TabIndex = 51;
            this.cbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Provinces);
            // 
            // frmModificationEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 593);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModificationEmployes";
            this.Text = "Modification d\'un employé";
            this.Load += new System.EventHandler(this.frmModificationEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndNumeroCivique)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource employesBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmerModification;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.NumericUpDown ndAge;
        private System.Windows.Forms.NumericUpDown ndNumeroCivique;
        private System.Windows.Forms.MaskedTextBox tbTelephone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbSalaire;
        private System.Windows.Forms.MaskedTextBox tbCodePostal;
        private System.Windows.Forms.MaskedTextBox tbNom;
        private System.Windows.Forms.MaskedTextBox tbPrenom;
        private System.Windows.Forms.MaskedTextBox tbMotDePasse;
        private System.Windows.Forms.MaskedTextBox tbCouriel;
        private System.Windows.Forms.MaskedTextBox tbRue;
        private System.Windows.Forms.MaskedTextBox tbVille;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.BindingSource provincesBindingSource;
    }
}