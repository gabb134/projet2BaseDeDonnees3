using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet2BaseDeDonnees3
{
    public partial class frmGestionDesEmployes : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();

        public frmGestionDesEmployes()
        {
            InitializeComponent();
        }

        private void frmGestionDesEmployes_Load(object sender, EventArgs e)
        {
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion connexion = new frmConnexion();
            this.Hide();
            connexion.ShowDialog();
            this.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
           // Application.Exit();
           // this.Close();
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            dynamic EmployeSelectionnee = employesBindingSource.Current;

           // string strNoEmployeSelectionee = EmployeSelectionnee["No"];
            //employesDataGridView.Rows[DataGridView.SelectedRows[0].Index].Cells["No"].Value.ToString();
          
          // MessageBox.Show(strNoEmployeSelectionee);
        }
    }
}
