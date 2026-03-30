using System;
using System.Windows.Forms;
using Pointofsalesystem;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

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
					home.Show();      // lalabas ang Home

					this.Hide();      // mawawala ang Login
				}
				else
				{
					MessageBox.Show("Invalid Username or Password");
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
	}
}