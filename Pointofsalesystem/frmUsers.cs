using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointofsalesystem
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        MyDatabase db = new MyDatabase();

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
			string query = "SELECT " +
					"tbluserinformation.firstname AS 'Firstname', " +
					"tbluserinformation.middlename AS 'Middlename', " +
					"tbluserinformation.lastname AS 'Lastname', " +
					"tbluserinformation.emailAddress AS 'Email Address', " +
					"tbluserinformation.homeAddress AS 'Home Address', " +
					"tbluserinformation.birthDate AS 'Birth Date', " +
					"tbllogincredentials.user_username AS 'Username' " +
					"FROM tbllogincredentials " +
					"INNER JOIN tbluserinformation " +
					"ON tbllogincredentials.userID = tbluserinformation.userID;";

			dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvUsers.DataSource = db.ExecuteReturnQuery(query);
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			try
			{
				
				string query1 = "INSERT INTO tbluserinformation (firstname, middlename, lastname, emailAddress, homeAddress, birthDate) " +
								"VALUES (@fname, @mname, @lname, @email, @hadd, @bDate);";

				db.ExecuteNoReturnQuery(query1,
					new MySqlParameter("@fname", tbFname.Text),
					new MySqlParameter("@mname", tbMname.Text),
					new MySqlParameter("@lname", tbLname.Text),
					new MySqlParameter("@email", tbEmailAdd.Text),
					new MySqlParameter("@hadd", tbHomeAdd.Text),
					new MySqlParameter("@bDate", dtpBirthDate.Value)
				);

				
				DataTable dt = db.ExecuteReturnQuery("SELECT LAST_INSERT_ID();");
				int userID = Convert.ToInt32(dt.Rows[0][0]);

				
				string query2 = "INSERT INTO tbllogincredentials (userID, user_username, user_password) " +
								"VALUES (@uid, @username, @password);";

				db.ExecuteNoReturnQuery(query2,
					new MySqlParameter("@uid", userID),
					new MySqlParameter("@username", tbUsername.Text),
					new MySqlParameter("@password", tbPassword.Text)
				);

				MessageBox.Show("Saved Successfully!");
				frmUsers_Load(null, null);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}


		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void tbFname_TextChanged(object sender, EventArgs e)
		{

		}

		private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}

		private void btnDeactivate_Click(object sender, EventArgs e)
		{

		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
