using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pointofsalesystem;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		MyDatabase db = new MyDatabase();
		string[,] userCredentials =
		{
			{"admin","1234","Chris Joseph Estrante" },
			{"cashier","1234","Kevin Durant" }
		};

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (tbUsername.Text == "" || tbPassword.Text == "")
			{
				if (tbUsername.Text == "admin" && tbPassword.Text == "1234")
				{
					MessageBox.Show("Login Successful");

					frmHome home = new frmHome();
					home.Show();      

					this.Hide();
                    MessageBox.Show("Invalid Username or Password");
                }
				else
				{
					DataTable dt = db.ExecuteReturnQuery("select * from tblLoginCredentials where  use_username = @uname and user_password = @pword",
					new MySqlParameter("@uname", tbUsername.Text),
					new MySqlParameter("@pword", tbPassword.Text));	

					if(dt.Rows.Count > 1)
					{
						frmHome frm = new frmHome();
						this.Hide();
						frm.Show();

					}
					
				}
			}

			for (int x = 0; x < userCredentials.GetLength(0); x++)
			{
				if (tbUsername.Text == userCredentials[x, 0] &&
					tbPassword.Text == userCredentials[x, 1])
				{
					MessageBox.Show("Welcome " + userCredentials[x, 2]);

					frmHome home = new frmHome();
					home.Show();

					this.Hide();
					return;
				}
			}

			MessageBox.Show("Invalid Username/Password");
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
            if (db.TestConnection() == true)
			{
				MessageBox.Show("Connected Succesfuly");
			}
			else
			{
				MessageBox.Show("Mali ka");
			}
		  
				
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}