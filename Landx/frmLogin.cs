using Landx.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landx
{
	public partial class frmLogin : MaterialForm
	{
		bool loggedIn = false;
		string error = "";
		public frmLogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
				Primary.Green100, Accent.LightGreen200, TextShade.WHITE);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bwLogin.RunWorkerAsync();
		}

		private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtUsername.Text))
			{
				error = "The Username field is compulsory.";
			}
			else
			{
				if (string.IsNullOrWhiteSpace(txtPassword.Text))
				{
					error = "The Password field is compulsory.";
				}
				else
				{
					using (var db = new LandxEntities())
					{
						var user = db.Accounts.SingleOrDefault(x =>
							x.Username == txtUsername.Text.Trim()
							&& x.Password == txtPassword.Text.Trim()
							);
						if (user == null)
						{
							error = "No account exists with this username and password.";
						}
						else
						{
							loggedIn = true;
						}
					}
				}
			}
		}

		private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Cursor = Cursors.Arrow;

			if (loggedIn)
			{
				frmMain frm = new frmMain();

				frm.Show();
				Hide();
			}
			else
			{
				MessageBox.Show(error);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.ApplicationExitCall)
			{
				return;
			}
			else
			{
				DialogResult result = MessageBox.Show("Are you sure you want to close the program?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
		}
	}
}
