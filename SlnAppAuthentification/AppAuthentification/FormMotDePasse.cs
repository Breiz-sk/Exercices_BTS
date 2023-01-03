using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAuthentification
{
    public partial class FormMotDePasse : Form
    {
        public FormMotDePasse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e) // bouton fermer
        {
            this.Close();
        }

        private void validerBTn_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(nomTB.Text) && String.IsNullOrEmpty(mdpTB.Text) )
            {
                FormBienvenue uneFenetreDeBienvenue = new FormBienvenue(nomTB.Text);
                uneFenetreDeBienvenue.Show();
            }
        }
    }
}
