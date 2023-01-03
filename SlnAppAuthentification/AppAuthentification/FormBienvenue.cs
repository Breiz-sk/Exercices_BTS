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
    public partial class FormBienvenue : Form
    {
        public FormBienvenue(string UnNom)
        {
            InitializeComponent();
            msgLb.Text = "Bienvenido a la siete y cuarto " + UnNom;
        }
    }
}
