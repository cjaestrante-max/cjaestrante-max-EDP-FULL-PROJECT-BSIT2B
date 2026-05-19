using MySql.Data.MySqlClient;
using System;
using System.Data;
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

		int selectedUserID = 0;

		private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
		{
			frmHome frm = new frmHome();
			frm.Show();
		}

		private void frmUsers_Load(object sender, EventArgs e)
		{
			string query = "SELECT " +
							"tbluserinformation.userID, " +
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
				string query1 = "INSERT INTO tbluserinformation " +
								"(firstname, middlename, lastname, emailAddress, homeAddress, birthDate) " +
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

				string query2 = "INSERT INTO tbllogincredentials " +
								"(userID, user_username, user_password) " +
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string query1 = "UPDATE tbluserinformation SET " +
								"firstname=@fname, " +
								"middlename=@mname, " +
								"lastname=@lname, " +
								"emailAddress=@email, " +
								"homeAddress=@hadd, " +
								"birthDate=@bdate " +
								"WHERE userID=@uid";

				db.ExecuteNoReturnQuery(query1,
					new MySqlParameter("@fname", tbFname.Text),
					new MySqlParameter("@mname", tbMname.Text),
					new MySqlParameter("@lname", tbLname.Text),
					new MySqlParameter("@email", tbEmailAdd.Text),
					new MySqlParameter("@hadd", tbHomeAdd.Text),
					new MySqlParameter("@bdate", dtpBirthDate.Value),
					new MySqlParameter("@uid", selectedUserID)
				);

				string query2 = "UPDATE tbllogincredentials SET " +
								"user_username=@username, " +
								"user_password=@password " +
								"WHERE userID=@uid";

				db.ExecuteNoReturnQuery(query2,
					new MySqlParameter("@username", tbUsername.Text),
					new MySqlParameter("@password", tbPassword.Text),
					new MySqlParameter("@uid", selectedUserID)
				);

				MessageBox.Show("Updated Successfully!");

				frmUsers_Load(null, null);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnDeactivate_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "DELETE FROM tbllogincredentials WHERE userID=@uid";

				db.ExecuteNoReturnQuery(query,
					new MySqlParameter("@uid", selectedUserID)
				);

				string query2 = "DELETE FROM tbluserinformation WHERE userID=@uid";

				db.ExecuteNoReturnQuery(query2,
					new MySqlParameter("@uid", selectedUserID)
				);

				MessageBox.Show("User Deactivated!");

				frmUsers_Load(null, null);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedUserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

			tbFname.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
			tbMname.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
			tbLname.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
			tbEmailAdd.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
			tbHomeAdd.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
			dtpBirthDate.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
			tbUsername.Text = dgvUsers.CurrentRow.Cells[7].Value.ToString();
		}

		private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedUserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

			tbFname.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
			tbMname.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
			tbLname.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
			tbEmailAdd.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
			tbHomeAdd.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
			dtpBirthDate.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
			tbUsername.Text = dgvUsers.CurrentRow.Cells[7].Value.ToString();
		}

		private void btnUpdate_Click_1(object sender, EventArgs e)
		{
			btnUpdate_Click(sender, e);
		}

		private void btnDeactivate_Click_1(object sender, EventArgs e)
		{
			btnDeactivate_Click(sender, e);
		}

		private void btnDeactivate_Click_2(object sender, EventArgs e)
		{
			btnDeactivate_Click(sender, e);
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
	}
}