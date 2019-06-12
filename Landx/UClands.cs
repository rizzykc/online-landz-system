using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landx
{
	public partial class UClands : UserControl
	{
		public UClands()
		{
			InitializeComponent();
		}

		private void btnLandDetails_Click(object sender, EventArgs e)
		{
			frmEditLand frm = new frmEditLand();
			frm.Tag = Tag;
			frm.Show();
		}

		private void UClands_Load(object sender, EventArgs e)
		{
			Models.Land land = (Models.Land)this.Tag;
			lblLandDescription.Text = land.LandDescription;
			lblLandLocation.Text = land.Town;
		}

		private void btnChangeOwner_Click(object sender, EventArgs e)
		{
			frmTransfer frm = new frmTransfer();
			frm.Tag = Tag;
			frm.Show();
		}
	}
}
