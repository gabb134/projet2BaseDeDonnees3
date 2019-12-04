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
            this.btnRenouvellerAbonnement.Location = new System.Drawing.Point(137, 216);
            this.btnRenouvellerAbonnement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRenouvellerAbonnement.Name = "btnRenouvellerAbonnement";
            this.btnRenouvellerAbonnement.Size = new System.Drawing.Size(289, 101);
            this.btnRenouvellerAbonnement.TabIndex = 42;
            this.btnRenouvellerAbonnement.Text = "Renouveller cet abonnement";
            this.btnRenouvellerAbonnement.UseVisualStyleBackColor = true;
            this.btnRenouvellerAbonnement.Click += new System.EventHandler(this.btnRenouvellerAbonnement_Click);
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarque.Location = new System.Drawing.Point(33, 122);
            this.lblRemarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(123, 25);
            this.lblRemarque.TabIndex = 41;
            this.lblRemarque.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarque.Location = new System.Drawing.Point(214, 100);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRemarque.MaxLength = 500;
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRemarque.Size = new System.Drawing.Size(298, 75);
            this.tbRemarque.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
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
            this.ddlAbonnements.Location = new System.Drawing.Point(214, 48);
            this.ddlAbonnements.Name = "ddlAbonnements";
            this.ddlAbonnements.Size = new System.Drawing.Size(298, 33);
            this.ddlAbonnements.TabIndex = 38;
            this.ddlAbonnements.ValueMember = "idAbonnePrincipal";
            // 
            // idNomPrenomAbonnePrincipalBindingSource
            // 
            this.idNomPrenomAbonnePrincipalBindingSource.DataSource = typeof(projet2BaseDeDonnees3.idNomPrenomAbonnePrincipal);
            // 
            // frmRenouvellerAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 410);
            this.Controls.Add(this.btnRenouvellerAbonnement);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlAbonnements);
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