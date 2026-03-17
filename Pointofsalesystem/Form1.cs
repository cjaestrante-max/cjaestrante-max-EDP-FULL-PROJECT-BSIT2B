using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace WindowsFormsApp1

{

    public partial class frmHome : Form

    {

        public frmHome()

        {

            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)

        {



        }



        private void label3_Click(object sender, EventArgs e)

        {



        }



        private void label1_Click(object sender, EventArgs e)

        {



        }

        string[,] userCredentials =

        {

            {"admin","1234","Chris Joseph Estrante" },

            {"cashier","1234","Kevin Durant" }

        };



        private void button1_Click(object sender, EventArgs e)

        {

            if (tbUsername.Text == "")

            {

                MessageBox.Show("Please enter username!", "validation");

                tbUsername.Focus();

            }

            else if (tbPassword.Text == "")

            {

                MessageBox.Show("Please enter password!", "validation");

                tbPassword.Focus();

            }

            else

            {

                for (int x = 0; x < userCredentials.GetLength(0); x++)

                {

                    if (tbUsername.Text == userCredentials[x, 0])

                    {

                        if (tbPassword.Text == userCredentials[x, 1])

                        {

                            frmHome frm = new frmHome();

                            MessageBox.Show("Welcome " + userCredentials[x, 2]);

                            this.Hide();

                            frm.Show();

                            break;

                        }

                        else

                        {

                            MessageBox.Show("Invalid Username/Password");

                            break;

                        }

                    }

                }

            }

        }

    }

}