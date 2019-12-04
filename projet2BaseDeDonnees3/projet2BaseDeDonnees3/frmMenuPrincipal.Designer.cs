namespace projet2BaseDeDonnees3
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMiseAJourAbonnes = new System.Windows.Forms.Button();
            this.btnAbonnement = new System.Windows.Forms.Button();
            this.btnModifPrix = new System.Windows.Forms.Button();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.btnGestionEmployes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisualisationRpports = new System.Windows.Forms.Button();
            this.btnInscriptionDepense = new System.Windows.Forms.Button();
            this.btnVisualisationStats = new System.Windows.Forms.Button();
            this.btnInscriptionPartie = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMiseAJourAbonnes);
            this.groupBox1.Controls.Add(this.btnAbonnement);
            this.groupBox1.Controls.Add(this.btnModifPrix);
            this.groupBox1.Controls.Add(this.btnReabonnement);
            this.groupBox1.Controls.Add(this.btnGestionEmployes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(760, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestions et abonnements";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMiseAJourAbonnes
            // 
            this.btnMiseAJourAbonnes.Location = new System.Drawing.Point(404, 178);
            this.btnMiseAJourAbonnes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMiseAJourAbonnes.Name = "btnMiseAJourAbonnes";
            this.btnMiseAJourAbonnes.Size = new System.Drawing.Size(326, 62);
            this.btnMiseAJourAbonnes.TabIndex = 4;
            this.btnMiseAJourAbonnes.Text = "Mise à jour des abonnés";
            this.btnMiseAJourAbonnes.UseVisualStyleBackColor = true;
            this.btnMiseAJourAbonnes.Click += new System.EventHandler(this.btnMiseAJourAbonnes_Click);
            // 
            // btnAbonnement
            // 
            this.btnAbonnement.Location = new System.Drawing.Point(404, 77);
            this.btnAbonnement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbonnement.Name = "btnAbonnement";
            this.btnAbonnement.Size = new System.Drawing.Size(326, 62);
            this.btnAbonnement.TabIndex = 3;
            this.btnAbonnement.Text = "Abonnement";
            this.btnAbonnement.UseVisualStyleBackColor = true;
            this.btnAbonnement.Click += new System.EventHandler(this.btnAbonnement_Click);
            // 
            // btnModifPrix
            // 
            this.btnModifPrix.Location = new System.Drawing.Point(219, 274);
            this.btnModifPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifPrix.Name = "btnModifPrix";
            this.btnModifPrix.Size = new System.Drawing.Size(322, 62);
            this.btnModifPrix.TabIndex = 2;
            this.btnModifPrix.Text = "Modification des prix";
            this.btnModifPrix.UseVisualStyleBackColor = true;
            this.btnModifPrix.Click += new System.EventHandler(this.btnModifPrix_Click);
            // 
            // btnReabonnement
            // 
            this.btnReabonnement.Location = new System.Drawing.Point(32, 178);
            this.btnReabonnement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(326, 62);
            this.btnReabonnement.TabIndex = 1;
            this.btnReabonnement.Text = "Réabonnement";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // btnGestionEmployes
            // 
            this.btnGestionEmployes.Location = new System.Drawing.Point(34, 77);
            this.btnGestionEmployes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionEmployes.Name = "btnGestionEmployes";
            this.btnGestionEmployes.Size = new System.Drawing.Size(322, 62);
            this.btnGestionEmployes.TabIndex = 0;
            this.btnGestionEmployes.Text = "Gestion des employes";
            this.btnGestionEmployes.UseVisualStyleBackColor = true;
            this.btnGestionEmployes.Click += new System.EventHandler(this.btnGestionEmployes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVisualisationRpports);
            this.groupBox2.Controls.Add(this.btnInscriptionDepense);
            this.groupBox2.Controls.Add(this.btnVisualisationStats);
            this.groupBox2.Controls.Add(this.btnInscriptionPartie);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(852, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(760, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inscriptions et visualisations";
            // 
            // btnVisualisationRpports
            // 
            this.btnVisualisationRpports.Location = new System.Drawing.Point(398, 209);
            this.btnVisualisationRpports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisualisationRpports.Name = "btnVisualisationRpports";
            this.btnVisualisationRpports.Size = new System.Drawing.Size(342, 62);
            this.btnVisualisationRpports.TabIndex = 4;
            this.btnVisualisationRpports.Text = "Visualisation des rapports";
            this.btnVisualisationRpports.UseVisualStyleBackColor = true;
            this.btnVisualisationRpports.Click += new System.EventHandler(this.btnVisualisationRpports_Click);
            // 
            // btnInscriptionDepense
            // 
            this.btnInscriptionDepense.Location = new System.Drawing.Point(398, 94);
            this.btnInscriptionDepense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInscriptionDepense.Name = "btnInscriptionDepense";
            this.btnInscriptionDepense.Size = new System.Drawing.Size(342, 62);
            this.btnInscriptionDepense.TabIndex = 3;
            this.btnInscriptionDepense.Text = "Inscription dépense";
            this.btnInscriptionDepense.UseVisualStyleBackColor = true;
            // 
            // btnVisualisationStats
            // 
            this.btnVisualisationStats.Location = new System.Drawing.Point(26, 209);
            this.btnVisualisationStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisualisationStats.Name = "btnVisualisationStats";
            this.btnVisualisationStats.Size = new System.Drawing.Size(339, 62);
            this.btnVisualisationStats.TabIndex = 2;
            this.btnVisualisationStats.Text = "Visualisation des stats";
            this.btnVisualisationStats.UseVisualStyleBackColor = true;
            this.btnVisualisationStats.Click += new System.EventHandler(this.btnVisualisationStats_Click);
            // 
            // btnInscriptionPartie
            // 
            this.btnInscriptionPartie.Location = new System.Drawing.Point(26, 94);
            this.btnInscriptionPartie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInscriptionPartie.Name = "btnInscriptionPartie";
            this.btnInscriptionPartie.Size = new System.Drawing.Size(339, 62);
            this.btnInscriptionPartie.TabIndex = 1;
            this.btnInscriptionPartie.Text = "Inscription partie de golf";
            this.btnInscriptionPartie.UseVisualStyleBackColor = true;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(585, 560);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(224, 82);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(852, 560);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(224, 82);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de Clubs de golf";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGestionEmployes;
        private System.Windows.Forms.Button btnMiseAJourAbonnes;
        private System.Windows.Forms.Button btnAbonnement;
        private System.Windows.Forms.Button btnModifPrix;
        private System.Windows.Forms.Button btnReabonnement;
        private System.Windows.Forms.Button btnVisualisationStats;
        private System.Windows.Forms.Button btnInscriptionPartie;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnVisualisationRpports;
        private System.Windows.Forms.Button btnInscriptionDepense;
        private System.Windows.Forms.Label label1;
    }
}