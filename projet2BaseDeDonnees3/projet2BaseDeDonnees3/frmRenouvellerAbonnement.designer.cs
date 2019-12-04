namespace projet2BaseDeDonnees3
{
    partial class frmRenouvellerAbonnement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenouvellerAbonnement));
            this.btnRenouvellerAbonnement = new System.Windows.Forms.Button();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlAbonnements = new System.Windows.Forms.ComboBox();
            this.idNomPrenomAbonnePrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.idNomPrenomAbonnePrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenouvellerAbonnement
            // 
            this.btnRenouvellerAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenouvellerAbonnement.Location = new System.Drawing.Point(91, 140);
            this.btnRenouvellerAbonnement.Name = "btnRenouvellerAbonnement";
            this.btnRenouvellerAbonnement.Size = new System.Drawing.Size(193, 66);
            this.btnRenouvellerAbonnement.TabIndex = 42;
            this.btnRenouvellerAbonnement.Text = "Renouveller cet abonnement";
            this.btnRenouvellerAbonnement.UseVisualStyleBackColor = true;
            this.btnRenouvellerAbonnement.Click += new System.EventHandler(this.btnRenouvellerAbonnement_Click);
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(22, 79);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(92, 17);
            this.lblRemarque.TabIndex = 41;
            this.lblRemarque.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(143, 65);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(200, 50);
            this.tbRemarque.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Abonnement :";
            // 
            // ddlAbonnements
            // 
            this.ddlAbonnements.DataSource = this.idNomPrenomAbonnePrincipalBindingSource;
            this.ddlAbonnements.DisplayMember = "idNomPrenomAbonne";
            this.ddlAbonnements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAbonnements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAbonnements.FormattingEnabled = true;
            this.ddlAbonnements.Location = new System.Drawing.Point(143, 31);
            this.ddlAbonnements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlAbonnements.Name = "ddlAbonnements";
            this.ddlAbonnements.Size = new System.Drawing.Size(200, 24);
            this.ddlAbonnements.TabIndex = 38;
            this.ddlAbonnements.ValueMember = "idAbonnePrincipal";
            // 
            // idNomPrenomAbonnePrincipalBindingSource
            // 
            this.idNomPrenomAbonnePrincipalBindingSource.DataSource = typeof(projet2BaseDeDonnees3.idNomPrenomAbonnePrincipal);
            // 
            // frmRenouvellerAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 266);
            this.Controls.Add(this.btnRenouvellerAbonnement);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlAbonnements);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRenouvellerAbonnement";
            this.Text = "frmRenouvellerAbonnement";
            this.Load += new System.EventHandler(this.frmRenouvellerAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNomPrenomAbonnePrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenouvellerAbonnement;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlAbonnements;
        private System.Windows.Forms.BindingSource idNomPrenomAbonnePrincipalBindingSource;
    }
}