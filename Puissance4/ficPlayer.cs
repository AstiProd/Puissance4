using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance4
{
    public partial class ficPlayer : Form
    {
        public ficPlayer()
        {
            InitializeComponent();
        }
        public string nomJ1;
        
        public string nomJ2;
        
        private void btnPStart_Click(object sender, EventArgs e)
        {
            nomJ1=tbPseudo1.Text; 
            nomJ2=tbPseudo2.Text;

            this.Hide();
            var fpl = new ficPlateau();

            fpl.Closed += (s, args) => this.Close();
            fpl.Show();


           
        }
    }
}
