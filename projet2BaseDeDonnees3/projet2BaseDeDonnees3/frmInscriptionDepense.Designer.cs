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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ndPointage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInscriptionDepense = new System.Windows.Forms.Button();
            this.cbtypeService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPointage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtypeService);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ndPointage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInscriptionDepense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscription d\'une dépense";
            // 
            // ndPointage
            // 
            this.ndPointage.Location = new System.Drawing.Point(238, 76);
            this.ndPointage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ndPointage.Name = "ndPointage";
            this.ndPointage.Size = new System.Drawing.Size(96, 26);
            this.ndPointage.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Montant de la dépense :";
            // 
            // cbClient
            // 
            this.cbClient.DisplayMember = "idNomEtPrenom";
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(127, 33);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(207, 28);
            this.cbClient.TabIndex = 52;
            this.cbClient.ValueMember = "idAbonneePrincipal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Client :";
            // 
            // btnInscriptionDepense
            // 
            this.btnInscriptionDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionDepense.Location = new System.Drawing.Point(64, 174);
            this.btnInscriptionDepense.Name = "btnInscriptionDepense";
            this.btnInscriptionDepense.Size = new System.Drawing.Size(224, 47);
            this.btnInscriptionDepense.TabIndex = 7;
            this.btnInscriptionDepense.Text = "Inscrire une dépense";
            this.btnInscriptionDepense.UseVisualStyleBackColor = true;
            // 
            // cbtypeService
            // 
            this.cbtypeService.DisplayMember = "idNomEtPrenom";
            this.cbtypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtypeService.FormattingEnabled = true;
            this.cbtypeService.Location = new System.Drawing.Point(180, 116);
            this.cbtypeService.Name = "cbtypeService";
            this.cbtypeService.Size = new System.Drawing.Size(154, 28);
            this.cbtypeService.TabIndex = 56;
            this.cbtypeService.ValueMember = "idAbonneePrincipal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Type de service :";
            // 
            // frmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInscriptionDepense";
            this.Text = "Inscription d\'une dépense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndPointage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ndPointage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInscriptionDepense;
        private System.Windows.Forms.ComboBox cbtypeService;
        private System.Windows.Forms.Label label3;
    }
}