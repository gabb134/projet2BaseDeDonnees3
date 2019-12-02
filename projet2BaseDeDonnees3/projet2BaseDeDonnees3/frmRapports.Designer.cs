namespace projet2BaseDeDonnees3
{
    partial class frmRapports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDepenseParEmploye = new System.Windows.Forms.TabPage();
            this.tabDepenseParAbonne = new System.Windows.Forms.TabPage();
            this.tabDepenseParAnnee = new System.Windows.Forms.TabPage();
            this.tabPartieJouesParTerrain = new System.Windows.Forms.TabPage();
            this.tabPartieJouesParAbonnement = new System.Windows.Forms.TabPage();
            this.tabPartieJouesParAnnee = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DepenseParEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PartieJoueeParTerrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabDepenseParEmploye.SuspendLayout();
            this.tabDepenseParAbonne.SuspendLayout();
            this.tabDepenseParAnnee.SuspendLayout();
            this.tabPartieJouesParTerrain.SuspendLayout();
            this.tabPartieJouesParAbonnement.SuspendLayout();
            this.tabPartieJouesParAnnee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepenseParEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartieJoueeParTerrainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDepenseParEmploye);
            this.tabControl1.Controls.Add(this.tabDepenseParAbonne);
            this.tabControl1.Controls.Add(this.tabDepenseParAnnee);
            this.tabControl1.Controls.Add(this.tabPartieJouesParTerrain);
            this.tabControl1.Controls.Add(this.tabPartieJouesParAbonnement);
            this.tabControl1.Controls.Add(this.tabPartieJouesParAnnee);
            this.tabControl1.Location = new System.Drawing.Point(17, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2287, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDepenseParEmploye
            // 
            this.tabDepenseParEmploye.Controls.Add(this.reportViewer1);
            this.tabDepenseParEmploye.Location = new System.Drawing.Point(4, 34);
            this.tabDepenseParEmploye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDepenseParEmploye.Name = "tabDepenseParEmploye";
            this.tabDepenseParEmploye.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDepenseParEmploye.Size = new System.Drawing.Size(2279, 464);
            this.tabDepenseParEmploye.TabIndex = 0;
            this.tabDepenseParEmploye.Text = "Rapport des dépenses par employés";
            this.tabDepenseParEmploye.UseVisualStyleBackColor = true;
            // 
            // tabDepenseParAbonne
            // 
            this.tabDepenseParAbonne.Controls.Add(this.reportViewer2);
            this.tabDepenseParAbonne.Location = new System.Drawing.Point(4, 34);
            this.tabDepenseParAbonne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDepenseParAbonne.Name = "tabDepenseParAbonne";
            this.tabDepenseParAbonne.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDepenseParAbonne.Size = new System.Drawing.Size(2279, 464);
            this.tabDepenseParAbonne.TabIndex = 1;
            this.tabDepenseParAbonne.Text = "Rapport des dépenses par abonnement";
            this.tabDepenseParAbonne.UseVisualStyleBackColor = true;
            // 
            // tabDepenseParAnnee
            // 
            this.tabDepenseParAnnee.Controls.Add(this.reportViewer3);
            this.tabDepenseParAnnee.Location = new System.Drawing.Point(4, 34);
            this.tabDepenseParAnnee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDepenseParAnnee.Name = "tabDepenseParAnnee";
            this.tabDepenseParAnnee.Size = new System.Drawing.Size(2279, 464);
            this.tabDepenseParAnnee.TabIndex = 2;
            this.tabDepenseParAnnee.Text = "Rapport des dépenses par année";
            this.tabDepenseParAnnee.UseVisualStyleBackColor = true;
            // 
            // tabPartieJouesParTerrain
            // 
            this.tabPartieJouesParTerrain.Controls.Add(this.reportViewer4);
            this.tabPartieJouesParTerrain.Location = new System.Drawing.Point(4, 34);
            this.tabPartieJouesParTerrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPartieJouesParTerrain.Name = "tabPartieJouesParTerrain";
            this.tabPartieJouesParTerrain.Size = new System.Drawing.Size(2279, 464);
            this.tabPartieJouesParTerrain.TabIndex = 3;
            this.tabPartieJouesParTerrain.Text = "Rapport des parties jouées par terrain";
            this.tabPartieJouesParTerrain.UseVisualStyleBackColor = true;
            // 
            // tabPartieJouesParAbonnement
            // 
            this.tabPartieJouesParAbonnement.Controls.Add(this.reportViewer5);
            this.tabPartieJouesParAbonnement.Location = new System.Drawing.Point(4, 34);
            this.tabPartieJouesParAbonnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPartieJouesParAbonnement.Name = "tabPartieJouesParAbonnement";
            this.tabPartieJouesParAbonnement.Size = new System.Drawing.Size(2279, 464);
            this.tabPartieJouesParAbonnement.TabIndex = 4;
            this.tabPartieJouesParAbonnement.Text = "Rapport des parties jouées par abonnement";
            this.tabPartieJouesParAbonnement.UseVisualStyleBackColor = true;
            // 
            // tabPartieJouesParAnnee
            // 
            this.tabPartieJouesParAnnee.Controls.Add(this.reportViewer6);
            this.tabPartieJouesParAnnee.Location = new System.Drawing.Point(4, 34);
            this.tabPartieJouesParAnnee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPartieJouesParAnnee.Name = "tabPartieJouesParAnnee";
            this.tabPartieJouesParAnnee.Size = new System.Drawing.Size(2279, 464);
            this.tabPartieJouesParAnnee.TabIndex = 5;
            this.tabPartieJouesParAnnee.Text = "Rapport des parties jouées par année";
            this.tabPartieJouesParAnnee.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DepenseParEmployeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projet2BaseDeDonnees3.RapportDepenseParEmploye.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(2238, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DepenseParEmployeBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "projet2BaseDeDonnees3.RapportDepenseParAbonnement.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(7, 7);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(2256, 450);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DepenseParEmployeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "projet2BaseDeDonnees3.RapportDepenseParAnnee.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(17, 12);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(2243, 433);
            this.reportViewer3.TabIndex = 0;
            // 
            // DepenseParEmployeBindingSource
            // 
            this.DepenseParEmployeBindingSource.DataSource = typeof(projet2BaseDeDonnees3.DepenseParEmploye);
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.PartieJoueeParTerrainBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "projet2BaseDeDonnees3.RapportPartieJoueParTerrain.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(23, 16);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(2238, 395);
            this.reportViewer4.TabIndex = 0;
            // 
            // PartieJoueeParTerrainBindingSource
            // 
            this.PartieJoueeParTerrainBindingSource.DataSource = typeof(projet2BaseDeDonnees3.PartieJoueeParTerrain);
            // 
            // reportViewer5
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.PartieJoueeParTerrainBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "projet2BaseDeDonnees3.RapportPartieJoueParAbonnement.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(2260, 444);
            this.reportViewer5.TabIndex = 0;
            // 
            // reportViewer6
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.PartieJoueeParTerrainBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "projet2BaseDeDonnees3.RapportPartieJoueParAnnee.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(15, 14);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(2246, 447);
            this.reportViewer6.TabIndex = 0;
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2306, 562);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRapports";
            this.Text = "frmRapports";
            this.Load += new System.EventHandler(this.frmRapports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDepenseParEmploye.ResumeLayout(false);
            this.tabDepenseParAbonne.ResumeLayout(false);
            this.tabDepenseParAnnee.ResumeLayout(false);
            this.tabPartieJouesParTerrain.ResumeLayout(false);
            this.tabPartieJouesParAbonnement.ResumeLayout(false);
            this.tabPartieJouesParAnnee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DepenseParEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartieJoueeParTerrainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDepenseParEmploye;
        private System.Windows.Forms.TabPage tabDepenseParAbonne;
        private System.Windows.Forms.TabPage tabDepenseParAnnee;
        private System.Windows.Forms.TabPage tabPartieJouesParTerrain;
        private System.Windows.Forms.TabPage tabPartieJouesParAnnee;
        private System.Windows.Forms.TabPage tabPartieJouesParAbonnement;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DepenseParEmployeBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource PartieJoueeParTerrainBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
    }
}