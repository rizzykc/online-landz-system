using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Landx.Models;

namespace Landx
{
	public partial class ucMap : UserControl
	{
		public string Mode { get; set; }
		public int SelectedLand { get; set; }

		Panel[] panLands = new Panel[50];
		List<Land> AllLands = new List<Land>();

		public ucMap()
		{
			InitializeComponent();
		}

		private void ucMap_Load(object sender, EventArgs e)
		{
			int count = 0;
			foreach (var item in this.Controls)
			{
				if (item is Panel)
				{
					panLands[count] = (Panel)item;
					panLands[count].Tag = count;
					panLands[count].BackColor = Color.Transparent;
					count++;
				}
			}


		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			using (var db = new LandxEntities())
			{
				AllLands = db.Lands.Include("Person").ToList();
			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Enabled = true;
			this.Cursor = Cursors.Arrow;
		}

		private void ucMap_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				this.Enabled = false;
				this.Cursor = Cursors.WaitCursor;

				backgroundWorker1.RunWorkerAsync();
			}
		}

		private void panel_Click(object sender, EventArgs e)
		{
			if (Mode.ToLower() == "select")
			{
				Panel pan = (Panel)sender;
				var land = AllLands.Where(x => x.LandIndex == (int)pan.Tag).FirstOrDefault();

				if (land==null)
				{
					if (MessageBox.Show("Are you sure you want to select this land?", "Select Land", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						SelectedLand = (int)pan.Tag;
						Visible = false;
					}
				}
				else
				{
					MessageBox.Show("This Land already belongs to someone.");
				}
			}
		}

		private void Panel_Hover(object sender, EventArgs e)
		{
			//this.SuspendLayout();
			Panel pan = (Panel)sender;
			var land = AllLands.Where(x => x.LandIndex == (int)pan.Tag).FirstOrDefault();

			pan.BackColor = Color.FromArgb(180, Color.LightBlue);

			if (land!=null)
			{
				lblOwnerName.Text = land.Person.ApplicantsFullname;
				lblOwnerPhone.Text = land.Person.PhoneNumber;
			}
			else
			{
				lblOwnerName.Text = "Not Assigned";
				lblOwnerPhone.Text = "Not Assigned";
			}

			grpLandOwner.Location = new Point()
			{
				X = (pan.Location.X + (pan.Width / 2)),
				Y = (pan.Location.Y + (pan.Height / 2))
			};
			grpLandOwner.Visible = true;
			//this.ResumeLayout();
		}

		private void Panel_Leave(object sender, EventArgs e)
		{
			Panel pan = (Panel)sender;
			pan.BackColor = Color.Transparent;

			grpLandOwner.Visible = false;
		}
	}
}
