﻿namespace projet2BaseDeDonnees3
{
    partial class frmInformationAjoutDepense
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
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.informationDepensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDepensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.Depenses);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 346);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information des dépenses";
            // 
            // informationDepensesBindingSource
            // 
            this.informationDepensesBindingSource.DataSource = typeof(projet2BaseDeDonnees3.InformationDepenses);
            // 
            // frmInformationAjoutDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 368);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInformationAjoutDepense";
            this.Text = "Information des dépenes";
            this.Load += new System.EventHandler(this.frmInformationAjoutDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationDepensesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource depensesBindingSource;
        private System.Windows.Forms.BindingSource informationDepensesBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}