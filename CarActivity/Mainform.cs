using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarActivity
{
    public partial class Mainform : Form
    {
        //Defining the objects
        
        BMW B1;
        Mercedes M1;
        Lexus L1;
        Toyota T1;
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            B1 = new BMW("BMW",BMWPicture);

            M1 = new Mercedes("Mercedes",MercedesPicture);

            L1 = new Lexus("Lexus",LexusPicture);

            T1 = new Toyota("Toyota",ToyotaPicture);


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (B1.Picture.Location.Y < 600 &&
               M1.Picture.Location.Y < 600 &&
               L1.Picture.Location.Y < 600 &&
               T1.Picture.Location.Y < 600)
            {
                B1.Move(rand.Next(2, 20));
                M1.Move(rand.Next(2, 20));
                L1.Move(rand.Next(2, 20));
                T1.Move(rand.Next(2, 20));
            }
            else
            {
                string winner = "";
                for (int i = 0; i < 4; i++)
                {
                    if (B1.Picture.Location.Y >= 600)
                    {
                        winner = B1.Name;
                    }
                    else if (M1.Picture.Location.Y >= 600)
                    {
                        winner = M1.Name;
                    }
                    else if (L1.Picture.Location.Y >= 600)
                    {
                        winner = L1.Name;
                    }
                    else if (T1.Picture.Location.Y >= 600)
                    {
                        winner = T1.Name;
                    }
                    else
                    {
                        winner = "Something wents wrong!";
                    }

                }
                MessageBox.Show("The race is finished and the winner is " + winner);
            }
            B1.Move(rand.Next(2, 20));
            M1.Move(rand.Next(2, 20));
            L1.Move(rand.Next(2, 20));
            T1.Move(rand.Next(2, 20));
        }
    }
}
     
    
       
