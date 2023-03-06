using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance4
{
    public partial class ficPlateau : Form
    {
        private int[,] Plateau;
        int i = 0;
        int j = 0;
        bool tour = true;
        public ficPlateau()
        {
            InitializeComponent();
            this.Plateau = new int[6,7];
        }


        private void ficPlateau_Paint(object sender, PaintEventArgs e)
        {
            Matrice();
        }
        
        private void Matrice()
        {
            Graphics e = CreateGraphics();


           
            e.FillRectangle(Brushes.Blue, 24, 24, 340, 300);
            for (i = 0; i < 6; i++)
                for (j = 0; j < 7; j++)
                    switch (Plateau[i, j]) 
                    { 
                        case 0:
                            e.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                            break;
                        case 1:
                            e.FillEllipse(Brushes.Red, 32 + 48 * j, 32 + 48 * i, 32, 32);
                            break;
                        case 2:
                            e.FillEllipse(Brushes.Yellow, 32 + 48 * j, 32 + 48 * i, 32, 32);
                            break;
                        default:
                            e.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                            break;
                    }
        }

        private void ficPlateau_MouseClick(object sender, MouseEventArgs e)
        {
            int iColone = e.Location.X / 48;
            int i;
           
            if(tour==true)
            {
                for (i = 5; i >= 0; i--)
                {
                    if (Plateau[i, iColone] == 0)
                    {
                        break;
                    }
                }

                if (i >= 0)
                {

                    Plateau[i, iColone] = 1;
                    Matrice();
                }
                else
                {
                    MessageBox.Show("La colonne est pleine, veuillez choisir une autre colonne.");
                }
                tour = false;
                Console.WriteLine("Tour j1");
            }
            else
            {
                for (i = 5; i >= 0; i--)
                {
                    if (Plateau[i, iColone] == 0)
                    {
                        break;
                    }
                }

                if (i >= 0)
                {

                    Plateau[i, iColone] = 2;
                    Matrice();
                }
                else
                {
                    MessageBox.Show("La colonne est pleine, veuillez choisir une autre colonne.");
                }
                tour = true;
                Console.WriteLine("Tour j2");
            }
           




        }
    }
}
