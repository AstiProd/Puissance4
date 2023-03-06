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
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            var fp = new ficPlayer();
           
            fp.Closed += (s, args) => this.Close();
            fp.Show();
        }
    }
}
