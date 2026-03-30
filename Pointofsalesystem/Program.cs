using System;
using System.Windows.Forms;
using Pointofsalesystem;

namespace WindowsFormsApp1
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// LOGIN FORM ANG UNANG LALABAS
			Application.Run(new Form1());
		}
	}
}