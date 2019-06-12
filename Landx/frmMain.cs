using Landx.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landx
{
	delegate void Function();   // a simple delegate for marshalling calls from event handlers to the GUI thread

	public partial class frmMain : MaterialForm
	{
		string sidebarVisible = "hidden";
		Image imgMenu = Properties.Resources.menu;
		Image imgBack = Properties.Resources.back;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
				Primary.Green100, Accent.LightGreen200, TextShade.WHITE);

			panSideBar.BackColor = Color.FromArgb(102, 187, 106);
			panSideBar.Visible = false;
		}

		private void picMenu_Click(object sender, EventArgs e)
		{
			if (!panSideBar.Visible)
			{
				sidebarVisible = "showing";
				animSlide.Show(panSideBar);
				animMenu.Hide(picMenu);
			}
			else
			{
				sidebarVisible = "hiding";
				animSlide.Hide(panSideBar);
				animMenu.Hide(picMenu);
			}
		}

		private void picMenu_MouseHover(object sender, EventArgs e)
		{
			picMenu.BackColor = Color.FromArgb(56, 142, 60);
		}

		private void picMenu_MouseLeave(object sender, EventArgs e)
		{
			picMenu.BackColor = Color.FromArgb(102, 187, 106);
		}

		private void animMenu_AnimationCompleted(object sender, BunifuAnimatorNS.AnimationCompletedEventArg e)
		{
			if (sidebarVisible == "showing")
			{
				sidebarVisible = "shown";
				picMenu.Image = imgBack;
				animMenu.Show(picMenu);
			}
			else if (sidebarVisible == "hiding")
			{
				picMenu.Image = imgMenu;
				animMenu.Show(picMenu);
				sidebarVisible = "hidden";
			}
		}

		private void picFind_Click(object sender, EventArgs e)
		{
			if (panSearch.Visible)
			{
				animPan.HideSync(panSearch);
			}
			else
			{
				if (panOwner.Visible) animPan.HideSync(panOwner);
				if (panLand.Visible) animPan.HideSync(panLand);
				animPan.ShowSync(panSearch);
			}
		}

		private void picFind_MouseHover(object sender, EventArgs e)
		{
			picFind.BackColor = Color.FromArgb(56, 142, 60);
		}

		private void picFind_MouseLeave(object sender, EventArgs e)
		{
			picFind.BackColor = Color.FromArgb(102, 187, 106);
		}

		private void btnNewLandLord_Click(object sender, EventArgs e)
		{
			frmNewLandLord frm = new frmNewLandLord();
			frm.ShowDialog();
		}

		private void picCloseSearch_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panSearch);
		}

		private void btnNewLand_Click(object sender, EventArgs e)
		{
			frmLand frm = new frmLand();
			frm.ShowDialog();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			using (var db = new LandxEntities())
			{
				if (txtSearch.Text.Trim().ToLower().StartsWith("land"))
				{
					int id;
					try
					{
						id = Convert.ToInt32(txtSearch.Text.Replace("land", "").Trim());
					}
					catch (Exception)
					{
						MessageBox.Show("The Input text is not a valid ID.");
						return;
					}
					Models.Land land = db.Lands.Find(id);
					if (land == null)
					{
						MessageBox.Show("No land was found with this ID.");
						return;
					}
					else
					{
						lstFound.Items.Add(string.Format("land{0} ({1})", land.Id.ToString("d4"), land.Person.ApplicantsFullname));
					}
				}
				else if (txtSearch.Text.Trim().ToLower().StartsWith("psn"))
				{
					int id;
					try
					{
						id = Convert.ToInt32(txtSearch.Text.Replace("psn", "").Trim());
					}
					catch (Exception)
					{
						MessageBox.Show("The Input text is not a valid ID.");
						return;
					}
					Models.Person psn = db.People.Find(id);
					if (psn == null)
					{
						MessageBox.Show("No Person was found with this ID.");
						return;
					}
					else
					{
						lstFound.Items.Add(string.Format("psn{0} ({1})", psn.Id.ToString("d4"), psn.ApplicantsFullname));
					}
				}
				else
				{
					List<Person> ppl = db.People.Where(x => x.ApplicantsFullname.Contains(txtSearch.Text.Trim().ToLower())).ToList();
					if (ppl.Count < 1)
					{
						MessageBox.Show("No Person was found with this Name.");
						return;
					}
					else
					{
						foreach (var psn in ppl)
						{
							lstFound.Items.Add(string.Format("psn{0} ({1})", psn.Id.ToString("d4"), psn.ApplicantsFullname));
						}

					}
				}
			}
		}

		private void lstFound_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string selectedString = lstFound.SelectedItem.ToString();
				string selectedId = selectedString.Replace(selectedString.Substring(selectedString.IndexOf(' ')), "");
				using (var db = new LandxEntities())
				{
					if (selectedId.Trim().StartsWith("land"))
					{
						int id = Convert.ToInt32(selectedId.Replace("land", "").Trim());

						Models.Land land = db.Lands.Find(id);
						if (land == null)
						{
							MessageBox.Show("No land was found with this ID.");
							return;
						}
						else
						{
							lblLandDescription.Text = land.LandDescription;
							lblLandLocation.Text = land.Town;
							lblLandOwnerName.Text = land.Person.ApplicantsFullname;
							lblLandOwnerNumber.Text = land.Person.PhoneNumber; //08157026571

							btnLandDetails.Tag = land;

							var ms = new MemoryStream(land.Person.Pic);
							picProfile.Image = Image.FromStream(ms);

							animPan.HideSync(panSearch);
							animPan.ShowSync(panLand);
						}
					}
					else if (selectedId.Trim().StartsWith("psn"))
					{
						int id = Convert.ToInt32(selectedId.Replace("psn", "").Trim());

						Models.Person psn = db.People.Find(id);
						if (psn == null)
						{
							MessageBox.Show("No Person was found with this ID.");
							return;
						}
						else
						{
							lblOwnerName.Text = psn.ApplicantsFullname;
							lblOwnerNumber.Text = psn.PhoneNumber;

							btnOwnerDetail.Tag = psn;

							var ms = new MemoryStream(psn.Pic);
							picOwner.Image = Image.FromStream(ms);

							panLands4Owner.Controls.Clear();

							Models.Land[] land = psn.Lands.ToArray();

							for (int i = 0; i < land.Count(); i++)
							{
								UClands pLand = new UClands();

								pLand.Tag = land[i];
								pLand.Top = (i * pLand.Height) + ((i + 1) * 10);
								panLands4Owner.Controls.Add(pLand);

							}

							animPan.HideSync(panSearch);
							animPan.ShowSync(panOwner);
						}
					}
				}
			}

			catch (Exception)
			{
			}

		}

		private void btnLandDetails_Click(object sender, EventArgs e)
		{
			frmEditLand frm = new frmEditLand();
			frm.Tag = btnLandDetails.Tag;

			frm.Show();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (!panSearch.Visible)
			{
				animPan.ShowSync(panSearch);
			}
		}

		private void btnTransfer_Click(object sender, EventArgs e)
		{
			if (!panSearch.Visible)
			{
				animPan.ShowSync(panSearch);
			}
		}

		private void picCloseLand_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panLand);
		}

		private void panSearch_VisibleChanged(object sender, EventArgs e)
		{
			if (panSearch.Visible)
			{
				lstFound.Items.Clear();
			}
		}

		private void picCloseOwner_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panOwner);
		}

		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			frmTransfer frm = new frmTransfer();
			frm.Tag = btnLandDetails.Tag;
			frm.Show();
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnMap_Click(object sender, EventArgs e)
		{
			frmMap frm = new frmMap("View");
			frm.ShowDialog();
		}
	}
}
