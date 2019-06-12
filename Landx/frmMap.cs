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
	public partial class frmMap : MaterialForm
	{
		public frmMap(string mode)
		{
			InitializeComponent();
		}

		private void frmMap_Load(object sender, EventArgs e)
		{
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
				Primary.Green100, Accent.LightGreen200, TextShade.WHITE);

		}
	}
}
