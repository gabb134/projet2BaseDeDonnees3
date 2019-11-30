namespace projet2BaseDeDonnees3
{
    partial class frmInscriptionPartieGolf
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
            this.ndPointage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAbonnement = new System.Windows.Forms.ComboBox();
            this.abonnementIdEtNomCompletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            this.terrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInscriptionPartie = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPointage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementIdEtNomCompletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ndPointage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAbonnement);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTerrain);
            this.groupBox1.Controls.Add(this.btnInscriptionPartie);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 241);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscription d\'une partie de golf";
            // 
            // ndPointage
            // 
            this.ndPointage.Location = new System.Drawing.Point(207, 117);
            this.ndPointage.Name = "ndPointage";
            this.ndPointage.Size = new System.Drawing.Size(207, 26);
            this.ndPointage.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Pointage :";
            // 
            // cbAbonnement
            // 
            this.cbAbonnement.DataSource = this.abonnementIdEtNomCompletBindingSource;
            this.cbAbonnement.DisplayMember = "idNomEtPrenom";
            this.cbAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbonnement.FormattingEnabled = true;
            this.cbAbonnement.Location = new System.Drawing.Point(207, 33);
            this.cbAbonnement.Name = "cbAbonnement";
            this.cbAbonnement.Size = new System.Drawing.Size(207, 28);
            this.cbAbonnement.TabIndex = 52;
            this.cbAbonnement.ValueMember = "idAbonneePrincipal";
            // 
            // abonnementIdEtNomCompletBindingSource
            // 
            this.abonnementIdEtNomCompletBindingSource.DataSource = typeof(projet2BaseDeDonnees3.AbonnementIdEtNomComplet);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Abonnement :";
            // 
            // cbTerrain
            // 
            this.cbTerrain.DataSource = this.terrainsBindingSource;
            this.cbTerrain.DisplayMember = "No";
            this.cbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(207, 73);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(207, 28);
            this.cbTerrain.TabIndex = 38;
            this.cbTerrain.ValueMember = "Nom";
            // 
            // terrainsBindingSource
            // 
            this.terrainsBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Terrains);
            // 
            // btnInscriptionPartie
            // 
            this.btnInscriptionPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionPartie.Location = new System.Drawing.Point(110, 178);
            this.btnInscriptionPartie.Name = "btnInscriptionPartie";
            this.btnInscriptionPartie.Size = new System.Drawing.Size(224, 47);
            this.btnInscriptionPartie.TabIndex = 7;
            this.btnInscriptionPartie.Text = "Inscrire une partie de golf";
            this.btnInscriptionPartie.UseVisualStyleBackColor = true;
            this.btnInscriptionPartie.Click += new System.EventHandler(this.btnInscriptionPartie_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Terrain :";
            // 
            // frmInscriptionPartieGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 265);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInscriptionPartieGolf";
            this.Text = "Inscription à une partie de golf";
            this.Load += new System.EventHandler(this.frmInscriptionPartieGolf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPointage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementIdEtNomCompletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAbonnement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTerrain;
        private System.Windows.Forms.Button btnInscriptionPartie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource abonnementIdEtNomCompletBindingSource;
        private System.Windows.Forms.BindingSource terrainsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndPointage;
    }
}