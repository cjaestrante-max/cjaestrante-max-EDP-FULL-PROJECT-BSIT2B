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
	public partial class frmHome : Form
	{
		public frmHome()
		{

				InitializeComponent();

				// CONNECT BUTTON EVENTS
				btnRegister.Click += btnRegister_Click;
				btnStore.Click += btnStore_Click;
				btnPricebook.Click += btnPricebook_Click;
				btnVendors.Click += btnVendors_Click;
				btnUsers.Click += btnUsers_Click;
				btnTime.Click += btnTime_Click;

			}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			frmRegister frm = new frmRegister();
			frm.Show();
		}

		private void btnStore_Click(object sender, EventArgs e)
		{
			frmStoreStatus frm = new frmStoreStatus();
			frm.Show();
		}

		private void btnPricebook_Click(object sender, EventArgs e)
		{
			frmPricebook frm = new frmPricebook();
			frm.Show();
		}

		private void btnVendors_Click(object sender, EventArgs e)
		{
			frmVendors frm = new frmVendors();
			frm.Show();
		}

		private void btnUsers_Click(object sender, EventArgs e)
		{
			frmUsers frm = new frmUsers();
			frm.Show();
		}

		private void btnTime_Click(object sender, EventArgs e)
		{
			frmTimeClock frm = new frmTimeClock();
			frm.Show();
		}

		private void frmHome_Load(object sender, EventArgs e)
		{

		}
	}
}
