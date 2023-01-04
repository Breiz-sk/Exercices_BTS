using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFicheClient
{
    public partial class FormFiche : Form
    {
        public FormFiche()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ville_Click(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            FormAffichage uneFormAffichage = new FormAffichage();
            uneFormAffichage.Show();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void FormFiche_Load(object sender, EventArgs e)
        {

        }

        private void CiviliteTB_LostFocus(object sender, EventArgs e)
        {
            this.CiviliteTB.Location = new System.Drawing.Point(120, 14);
            //this.Civilite
        }
    }
}
