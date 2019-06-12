namespace Landx
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
			this.panSearch = new System.Windows.Forms.Panel();
			this.lstFound = new System.Windows.Forms.ListBox();
			this.picCloseSearch = new System.Windows.Forms.PictureBox();
			this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panSideBar = new System.Windows.Forms.Panel();
			this.btnNewLandLord = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnTransfer = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnNewLand = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panOwner = new System.Windows.Forms.Panel();
			this.panLands4Owner = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.picCloseOwner = new System.Windows.Forms.PictureBox();
			this.lblOwnerNumber = new MaterialSkin.Controls.MaterialLabel();
			this.lblOwnerName = new MaterialSkin.Controls.MaterialLabel();
			this.picOwner = new System.Windows.Forms.PictureBox();
			this.panLand = new System.Windows.Forms.Panel();
			this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnLandDetails = new Bunifu.Framework.UI.BunifuFlatButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.picCloseLand = new System.Windows.Forms.PictureBox();
			this.lblLandOwnerNumber = new MaterialSkin.Controls.MaterialLabel();
			this.lblLandOwnerName = new MaterialSkin.Controls.MaterialLabel();
			this.lblLandLocation = new MaterialSkin.Controls.MaterialLabel();
			this.lblLandDescription = new MaterialSkin.Controls.MaterialLabel();
			this.picProfile = new System.Windows.Forms.PictureBox();
			this.animSlide = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.picFind = new System.Windows.Forms.PictureBox();
			this.picMenu = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnOwnerDetail = new Bunifu.Framework.UI.BunifuFlatButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.animMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.animPan = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.btnMap = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseSearch)).BeginInit();
			this.panSideBar.SuspendLayout();
			this.panOwner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseOwner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
			this.panLand.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseLand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// panSearch
			// 
			this.panSearch.BackColor = System.Drawing.Color.LightGreen;
			this.panSearch.Controls.Add(this.lstFound);
			this.panSearch.Controls.Add(this.picCloseSearch);
			this.panSearch.Controls.Add(this.txtSearch);
			this.panSearch.Controls.Add(this.btnSearch);
			this.animSlide.SetDecoration(this.panSearch, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panSearch, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panSearch, BunifuAnimatorNS.DecorationType.None);
			this.panSearch.Location = new System.Drawing.Point(298, 93);
			this.panSearch.Name = "panSearch";
			this.panSearch.Size = new System.Drawing.Size(406, 297);
			this.panSearch.TabIndex = 12;
			this.panSearch.Visible = false;
			this.panSearch.VisibleChanged += new System.EventHandler(this.panSearch_VisibleChanged);
			// 
			// lstFound
			// 
			this.lstFound.BackColor = System.Drawing.Color.LightGreen;
			this.lstFound.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.animMenu.SetDecoration(this.lstFound, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.lstFound, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lstFound, BunifuAnimatorNS.DecorationType.None);
			this.lstFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstFound.FormattingEnabled = true;
			this.lstFound.ItemHeight = 16;
			this.lstFound.Location = new System.Drawing.Point(24, 118);
			this.lstFound.Name = "lstFound";
			this.lstFound.Size = new System.Drawing.Size(359, 160);
			this.lstFound.TabIndex = 10;
			this.lstFound.SelectedIndexChanged += new System.EventHandler(this.lstFound_SelectedIndexChanged);
			// 
			// picCloseSearch
			// 
			this.picCloseSearch.BackColor = System.Drawing.Color.Red;
			this.animPan.SetDecoration(this.picCloseSearch, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picCloseSearch, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picCloseSearch, BunifuAnimatorNS.DecorationType.None);
			this.picCloseSearch.Image = global::Landx.Properties.Resources.close;
			this.picCloseSearch.Location = new System.Drawing.Point(385, 0);
			this.picCloseSearch.Name = "picCloseSearch";
			this.picCloseSearch.Size = new System.Drawing.Size(20, 20);
			this.picCloseSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloseSearch.TabIndex = 9;
			this.picCloseSearch.TabStop = false;
			this.picCloseSearch.Click += new System.EventHandler(this.picCloseSearch_Click);
			// 
			// txtSearch
			// 
			this.animSlide.SetDecoration(this.txtSearch, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.txtSearch, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.txtSearch, BunifuAnimatorNS.DecorationType.None);
			this.txtSearch.Depth = 0;
			this.txtSearch.Hint = "search by PersonID, LandID or Name";
			this.txtSearch.Location = new System.Drawing.Point(24, 91);
			this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.SelectedText = "";
			this.txtSearch.SelectionLength = 0;
			this.txtSearch.SelectionStart = 0;
			this.txtSearch.Size = new System.Drawing.Size(264, 23);
			this.txtSearch.TabIndex = 8;
			this.txtSearch.UseSystemPasswordChar = false;
			// 
			// btnSearch
			// 
			this.animSlide.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
			this.btnSearch.Depth = 0;
			this.btnSearch.Location = new System.Drawing.Point(294, 88);
			this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Primary = true;
			this.btnSearch.Size = new System.Drawing.Size(89, 30);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.animPan.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(197, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(525, 25);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ministry of Lands, Physical Planning and Rural Development";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panSideBar
			// 
			this.panSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panSideBar.Controls.Add(this.btnMap);
			this.panSideBar.Controls.Add(this.btnNewLandLord);
			this.panSideBar.Controls.Add(this.btnTransfer);
			this.panSideBar.Controls.Add(this.btnEdit);
			this.panSideBar.Controls.Add(this.btnNewLand);
			this.animSlide.SetDecoration(this.panSideBar, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panSideBar, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panSideBar, BunifuAnimatorNS.DecorationType.None);
			this.panSideBar.Location = new System.Drawing.Point(0, 63);
			this.panSideBar.Name = "panSideBar";
			this.panSideBar.Size = new System.Drawing.Size(197, 471);
			this.panSideBar.TabIndex = 10;
			// 
			// btnNewLandLord
			// 
			this.btnNewLandLord.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnNewLandLord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnNewLandLord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNewLandLord.BorderRadius = 0;
			this.btnNewLandLord.ButtonText = "New Landlord";
			this.btnNewLandLord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnNewLandLord, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnNewLandLord, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnNewLandLord, BunifuAnimatorNS.DecorationType.None);
			this.btnNewLandLord.DisabledColor = System.Drawing.Color.Gray;
			this.btnNewLandLord.Iconcolor = System.Drawing.Color.Transparent;
			this.btnNewLandLord.Iconimage = null;
			this.btnNewLandLord.Iconimage_right = null;
			this.btnNewLandLord.Iconimage_right_Selected = null;
			this.btnNewLandLord.Iconimage_Selected = null;
			this.btnNewLandLord.IconMarginLeft = 0;
			this.btnNewLandLord.IconMarginRight = 0;
			this.btnNewLandLord.IconRightVisible = true;
			this.btnNewLandLord.IconRightZoom = 0D;
			this.btnNewLandLord.IconVisible = true;
			this.btnNewLandLord.IconZoom = 90D;
			this.btnNewLandLord.IsTab = false;
			this.btnNewLandLord.Location = new System.Drawing.Point(0, 139);
			this.btnNewLandLord.Name = "btnNewLandLord";
			this.btnNewLandLord.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnNewLandLord.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnNewLandLord.OnHoverTextColor = System.Drawing.Color.White;
			this.btnNewLandLord.selected = false;
			this.btnNewLandLord.Size = new System.Drawing.Size(197, 48);
			this.btnNewLandLord.TabIndex = 11;
			this.btnNewLandLord.Text = "New Landlord";
			this.btnNewLandLord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNewLandLord.Textcolor = System.Drawing.Color.White;
			this.btnNewLandLord.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewLandLord.Click += new System.EventHandler(this.btnNewLandLord_Click);
			// 
			// btnTransfer
			// 
			this.btnTransfer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTransfer.BorderRadius = 0;
			this.btnTransfer.ButtonText = "Transfer of Ownership";
			this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnTransfer, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnTransfer, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnTransfer, BunifuAnimatorNS.DecorationType.None);
			this.btnTransfer.DisabledColor = System.Drawing.Color.Gray;
			this.btnTransfer.Iconcolor = System.Drawing.Color.Transparent;
			this.btnTransfer.Iconimage = null;
			this.btnTransfer.Iconimage_right = null;
			this.btnTransfer.Iconimage_right_Selected = null;
			this.btnTransfer.Iconimage_Selected = null;
			this.btnTransfer.IconMarginLeft = 0;
			this.btnTransfer.IconMarginRight = 0;
			this.btnTransfer.IconRightVisible = true;
			this.btnTransfer.IconRightZoom = 0D;
			this.btnTransfer.IconVisible = true;
			this.btnTransfer.IconZoom = 90D;
			this.btnTransfer.IsTab = false;
			this.btnTransfer.Location = new System.Drawing.Point(0, 283);
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnTransfer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnTransfer.OnHoverTextColor = System.Drawing.Color.White;
			this.btnTransfer.selected = false;
			this.btnTransfer.Size = new System.Drawing.Size(197, 48);
			this.btnTransfer.TabIndex = 10;
			this.btnTransfer.Text = "Transfer of Ownership";
			this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnTransfer.Textcolor = System.Drawing.Color.White;
			this.btnTransfer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEdit.BorderRadius = 0;
			this.btnEdit.ButtonText = "Edit Owner Details";
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnEdit, BunifuAnimatorNS.DecorationType.None);
			this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
			this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
			this.btnEdit.Iconimage = null;
			this.btnEdit.Iconimage_right = null;
			this.btnEdit.Iconimage_right_Selected = null;
			this.btnEdit.Iconimage_Selected = null;
			this.btnEdit.IconMarginLeft = 0;
			this.btnEdit.IconMarginRight = 0;
			this.btnEdit.IconRightVisible = true;
			this.btnEdit.IconRightZoom = 0D;
			this.btnEdit.IconVisible = true;
			this.btnEdit.IconZoom = 90D;
			this.btnEdit.IsTab = false;
			this.btnEdit.Location = new System.Drawing.Point(0, 235);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
			this.btnEdit.selected = false;
			this.btnEdit.Size = new System.Drawing.Size(197, 48);
			this.btnEdit.TabIndex = 9;
			this.btnEdit.Text = "Edit Owner Details";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnEdit.Textcolor = System.Drawing.Color.White;
			this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnNewLand
			// 
			this.btnNewLand.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnNewLand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnNewLand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNewLand.BorderRadius = 0;
			this.btnNewLand.ButtonText = "New Land";
			this.btnNewLand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnNewLand, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnNewLand, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnNewLand, BunifuAnimatorNS.DecorationType.None);
			this.btnNewLand.DisabledColor = System.Drawing.Color.Gray;
			this.btnNewLand.Iconcolor = System.Drawing.Color.Transparent;
			this.btnNewLand.Iconimage = null;
			this.btnNewLand.Iconimage_right = null;
			this.btnNewLand.Iconimage_right_Selected = null;
			this.btnNewLand.Iconimage_Selected = null;
			this.btnNewLand.IconMarginLeft = 0;
			this.btnNewLand.IconMarginRight = 0;
			this.btnNewLand.IconRightVisible = true;
			this.btnNewLand.IconRightZoom = 0D;
			this.btnNewLand.IconVisible = true;
			this.btnNewLand.IconZoom = 90D;
			this.btnNewLand.IsTab = false;
			this.btnNewLand.Location = new System.Drawing.Point(0, 187);
			this.btnNewLand.Name = "btnNewLand";
			this.btnNewLand.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnNewLand.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnNewLand.OnHoverTextColor = System.Drawing.Color.White;
			this.btnNewLand.selected = false;
			this.btnNewLand.Size = new System.Drawing.Size(197, 48);
			this.btnNewLand.TabIndex = 8;
			this.btnNewLand.Text = "New Land";
			this.btnNewLand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNewLand.Textcolor = System.Drawing.Color.White;
			this.btnNewLand.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewLand.Click += new System.EventHandler(this.btnNewLand_Click);
			// 
			// panOwner
			// 
			this.panOwner.BackColor = System.Drawing.Color.LightGreen;
			this.panOwner.Controls.Add(this.panLands4Owner);
			this.panOwner.Controls.Add(this.label8);
			this.panOwner.Controls.Add(this.label9);
			this.panOwner.Controls.Add(this.label12);
			this.panOwner.Controls.Add(this.label13);
			this.panOwner.Controls.Add(this.picCloseOwner);
			this.panOwner.Controls.Add(this.lblOwnerNumber);
			this.panOwner.Controls.Add(this.lblOwnerName);
			this.panOwner.Controls.Add(this.picOwner);
			this.animSlide.SetDecoration(this.panOwner, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panOwner, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panOwner, BunifuAnimatorNS.DecorationType.None);
			this.panOwner.Location = new System.Drawing.Point(238, 92);
			this.panOwner.Name = "panOwner";
			this.panOwner.Size = new System.Drawing.Size(578, 344);
			this.panOwner.TabIndex = 15;
			this.panOwner.Visible = false;
			// 
			// panLands4Owner
			// 
			this.panLands4Owner.AutoScroll = true;
			this.animSlide.SetDecoration(this.panLands4Owner, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panLands4Owner, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panLands4Owner, BunifuAnimatorNS.DecorationType.None);
			this.panLands4Owner.Location = new System.Drawing.Point(59, 203);
			this.panLands4Owner.Name = "panLands4Owner";
			this.panLands4Owner.Size = new System.Drawing.Size(450, 137);
			this.panLands4Owner.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.animPan.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(161, 106);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 18);
			this.label8.TabIndex = 18;
			this.label8.Text = "Phone Number:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.animPan.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(194, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 18);
			this.label9.TabIndex = 17;
			this.label9.Text = "Full Name:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.animPan.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(176, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(157, 22);
			this.label12.TabIndex = 14;
			this.label12.Text = "Land Owner Info";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.animPan.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(222, 174);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 22);
			this.label13.TabIndex = 13;
			this.label13.Text = "Lands";
			// 
			// picCloseOwner
			// 
			this.picCloseOwner.BackColor = System.Drawing.Color.Red;
			this.animPan.SetDecoration(this.picCloseOwner, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picCloseOwner, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picCloseOwner, BunifuAnimatorNS.DecorationType.None);
			this.picCloseOwner.Image = global::Landx.Properties.Resources.close;
			this.picCloseOwner.Location = new System.Drawing.Point(558, 0);
			this.picCloseOwner.Name = "picCloseOwner";
			this.picCloseOwner.Size = new System.Drawing.Size(20, 20);
			this.picCloseOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloseOwner.TabIndex = 12;
			this.picCloseOwner.TabStop = false;
			this.picCloseOwner.Click += new System.EventHandler(this.picCloseOwner_Click);
			// 
			// lblOwnerNumber
			// 
			this.animSlide.SetDecoration(this.lblOwnerNumber, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.lblOwnerNumber, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lblOwnerNumber, BunifuAnimatorNS.DecorationType.None);
			this.lblOwnerNumber.Depth = 0;
			this.lblOwnerNumber.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblOwnerNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblOwnerNumber.Location = new System.Drawing.Point(297, 106);
			this.lblOwnerNumber.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblOwnerNumber.Name = "lblOwnerNumber";
			this.lblOwnerNumber.Size = new System.Drawing.Size(266, 21);
			this.lblOwnerNumber.TabIndex = 10;
			this.lblOwnerNumber.Text = "materialLabel7";
			// 
			// lblOwnerName
			// 
			this.animSlide.SetDecoration(this.lblOwnerName, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.lblOwnerName, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lblOwnerName, BunifuAnimatorNS.DecorationType.None);
			this.lblOwnerName.Depth = 0;
			this.lblOwnerName.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblOwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblOwnerName.Location = new System.Drawing.Point(297, 62);
			this.lblOwnerName.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblOwnerName.Name = "lblOwnerName";
			this.lblOwnerName.Size = new System.Drawing.Size(266, 26);
			this.lblOwnerName.TabIndex = 7;
			this.lblOwnerName.Text = "materialLabel10";
			// 
			// picOwner
			// 
			this.animPan.SetDecoration(this.picOwner, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picOwner, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picOwner, BunifuAnimatorNS.DecorationType.None);
			this.picOwner.Location = new System.Drawing.Point(12, 6);
			this.picOwner.Name = "picOwner";
			this.picOwner.Size = new System.Drawing.Size(143, 159);
			this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picOwner.TabIndex = 0;
			this.picOwner.TabStop = false;
			// 
			// panLand
			// 
			this.panLand.BackColor = System.Drawing.Color.LightGreen;
			this.panLand.Controls.Add(this.bunifuFlatButton3);
			this.panLand.Controls.Add(this.btnLandDetails);
			this.panLand.Controls.Add(this.label7);
			this.panLand.Controls.Add(this.label6);
			this.panLand.Controls.Add(this.label5);
			this.panLand.Controls.Add(this.label4);
			this.panLand.Controls.Add(this.label3);
			this.panLand.Controls.Add(this.label2);
			this.panLand.Controls.Add(this.picCloseLand);
			this.panLand.Controls.Add(this.lblLandOwnerNumber);
			this.panLand.Controls.Add(this.lblLandOwnerName);
			this.panLand.Controls.Add(this.lblLandLocation);
			this.panLand.Controls.Add(this.lblLandDescription);
			this.panLand.Controls.Add(this.picProfile);
			this.animSlide.SetDecoration(this.panLand, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panLand, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panLand, BunifuAnimatorNS.DecorationType.None);
			this.panLand.Location = new System.Drawing.Point(242, 93);
			this.panLand.Name = "panLand";
			this.panLand.Size = new System.Drawing.Size(578, 344);
			this.panLand.TabIndex = 14;
			this.panLand.Visible = false;
			// 
			// bunifuFlatButton3
			// 
			this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "Transfer Owner";
			this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
			this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = null;
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0D;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 90D;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new System.Drawing.Point(374, 295);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(136, 30);
			this.bunifuFlatButton3.TabIndex = 21;
			this.bunifuFlatButton3.Text = "Transfer Owner";
			this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
			// 
			// btnLandDetails
			// 
			this.btnLandDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnLandDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnLandDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLandDetails.BorderRadius = 0;
			this.btnLandDetails.ButtonText = "View Details";
			this.btnLandDetails.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnLandDetails, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnLandDetails, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnLandDetails, BunifuAnimatorNS.DecorationType.None);
			this.btnLandDetails.DisabledColor = System.Drawing.Color.Gray;
			this.btnLandDetails.Iconcolor = System.Drawing.Color.Transparent;
			this.btnLandDetails.Iconimage = null;
			this.btnLandDetails.Iconimage_right = null;
			this.btnLandDetails.Iconimage_right_Selected = null;
			this.btnLandDetails.Iconimage_Selected = null;
			this.btnLandDetails.IconMarginLeft = 0;
			this.btnLandDetails.IconMarginRight = 0;
			this.btnLandDetails.IconRightVisible = true;
			this.btnLandDetails.IconRightZoom = 0D;
			this.btnLandDetails.IconVisible = true;
			this.btnLandDetails.IconZoom = 90D;
			this.btnLandDetails.IsTab = false;
			this.btnLandDetails.Location = new System.Drawing.Point(225, 295);
			this.btnLandDetails.Name = "btnLandDetails";
			this.btnLandDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnLandDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnLandDetails.OnHoverTextColor = System.Drawing.Color.White;
			this.btnLandDetails.selected = false;
			this.btnLandDetails.Size = new System.Drawing.Size(132, 30);
			this.btnLandDetails.TabIndex = 20;
			this.btnLandDetails.Text = "View Details";
			this.btnLandDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnLandDetails.Textcolor = System.Drawing.Color.White;
			this.btnLandDetails.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLandDetails.Click += new System.EventHandler(this.btnLandDetails_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.animPan.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(161, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "Phone Number:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.animPan.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(194, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 18);
			this.label6.TabIndex = 17;
			this.label6.Text = "Full Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.animPan.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 18);
			this.label5.TabIndex = 16;
			this.label5.Text = "Land Location:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.animPan.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 18);
			this.label4.TabIndex = 15;
			this.label4.Text = "Land Description:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.animPan.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(176, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 22);
			this.label3.TabIndex = 14;
			this.label3.Text = "Land Owner Info";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.animPan.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(193, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 22);
			this.label2.TabIndex = 13;
			this.label2.Text = "Land Info";
			// 
			// picCloseLand
			// 
			this.picCloseLand.BackColor = System.Drawing.Color.Red;
			this.animPan.SetDecoration(this.picCloseLand, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picCloseLand, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picCloseLand, BunifuAnimatorNS.DecorationType.None);
			this.picCloseLand.Image = global::Landx.Properties.Resources.close;
			this.picCloseLand.Location = new System.Drawing.Point(558, 0);
			this.picCloseLand.Name = "picCloseLand";
			this.picCloseLand.Size = new System.Drawing.Size(20, 20);
			this.picCloseLand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picCloseLand.TabIndex = 12;
			this.picCloseLand.TabStop = false;
			this.picCloseLand.Click += new System.EventHandler(this.picCloseLand_Click);
			// 
			// lblLandOwnerNumber
			// 
			this.animSlide.SetDecoration(this.lblLandOwnerNumber, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.lblLandOwnerNumber, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lblLandOwnerNumber, BunifuAnimatorNS.DecorationType.None);
			this.lblLandOwnerNumber.Depth = 0;
			this.lblLandOwnerNumber.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblLandOwnerNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblLandOwnerNumber.Location = new System.Drawing.Point(297, 240);
			this.lblLandOwnerNumber.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblLandOwnerNumber.Name = "lblLandOwnerNumber";
			this.lblLandOwnerNumber.Size = new System.Drawing.Size(266, 21);
			this.lblLandOwnerNumber.TabIndex = 10;
			this.lblLandOwnerNumber.Text = "materialLabel7";
			// 
			// lblLandOwnerName
			// 
			this.animSlide.SetDecoration(this.lblLandOwnerName, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.lblLandOwnerName, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lblLandOwnerName, BunifuAnimatorNS.DecorationType.None);
			this.lblLandOwnerName.Depth = 0;
			this.lblLandOwnerName.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblLandOwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblLandOwnerName.Location = new System.Drawing.Point(297, 196);
			this.lblLandOwnerName.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblLandOwnerName.Name = "lblLandOwnerName";
			this.lblLandOwnerName.Size = new System.Drawing.Size(266, 26);
			this.lblLandOwnerName.TabIndex = 7;
			this.lblLandOwnerName.Text = "materialLabel10";
			// 
			// lblLandLocation
			// 
			this.animSlide.SetDecoration(this.lblLandLocation, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.lblLandLocation, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lblLandLocation, BunifuAnimatorNS.DecorationType.None);
			this.lblLandLocation.Depth = 0;
			this.lblLandLocation.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblLandLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblLandLocation.Location = new System.Drawing.Point(141, 106);
			this.lblLandLocation.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblLandLocation.Name = "lblLandLocation";
			this.lblLandLocation.Size = new System.Drawing.Size(422, 21);
			this.lblLandLocation.TabIndex = 5;
			this.lblLandLocation.Text = "materialLabel5";
			// 
			// lblLandDescription
			// 
			this.animSlide.SetDecoration(this.lblLandDescription, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.lblLandDescription, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.lblLandDescription, BunifuAnimatorNS.DecorationType.None);
			this.lblLandDescription.Depth = 0;
			this.lblLandDescription.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblLandDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblLandDescription.Location = new System.Drawing.Point(141, 40);
			this.lblLandDescription.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblLandDescription.Name = "lblLandDescription";
			this.lblLandDescription.Size = new System.Drawing.Size(422, 58);
			this.lblLandDescription.TabIndex = 2;
			this.lblLandDescription.Text = "materialLabel2";
			// 
			// picProfile
			// 
			this.animPan.SetDecoration(this.picProfile, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picProfile, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picProfile, BunifuAnimatorNS.DecorationType.None);
			this.picProfile.Location = new System.Drawing.Point(12, 164);
			this.picProfile.Name = "picProfile";
			this.picProfile.Size = new System.Drawing.Size(143, 159);
			this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picProfile.TabIndex = 0;
			this.picProfile.TabStop = false;
			// 
			// animSlide
			// 
			this.animSlide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.animSlide.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
			animation2.LeafCoeff = 0F;
			animation2.MaxTime = 1F;
			animation2.MinTime = 0F;
			animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
			animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
			animation2.MosaicSize = 0;
			animation2.Padding = new System.Windows.Forms.Padding(0);
			animation2.RotateCoeff = 0F;
			animation2.RotateLimit = 0F;
			animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
			animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
			animation2.TimeCoeff = 0F;
			animation2.TransparencyCoeff = 0F;
			this.animSlide.DefaultAnimation = animation2;
			this.animSlide.MaxAnimationTime = 2000;
			// 
			// picFind
			// 
			this.picFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picFind.BackColor = System.Drawing.Color.Transparent;
			this.animPan.SetDecoration(this.picFind, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picFind, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picFind, BunifuAnimatorNS.DecorationType.None);
			this.picFind.Image = global::Landx.Properties.Resources.search_3;
			this.picFind.Location = new System.Drawing.Point(831, 26);
			this.picFind.Name = "picFind";
			this.picFind.Size = new System.Drawing.Size(30, 30);
			this.picFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picFind.TabIndex = 13;
			this.picFind.TabStop = false;
			this.picFind.Click += new System.EventHandler(this.picFind_Click);
			this.picFind.MouseLeave += new System.EventHandler(this.picFind_MouseLeave);
			this.picFind.MouseHover += new System.EventHandler(this.picFind_MouseHover);
			// 
			// picMenu
			// 
			this.picMenu.BackColor = System.Drawing.Color.Transparent;
			this.animPan.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
			this.picMenu.Image = global::Landx.Properties.Resources.menu;
			this.picMenu.Location = new System.Drawing.Point(0, 24);
			this.picMenu.Name = "picMenu";
			this.picMenu.Size = new System.Drawing.Size(40, 40);
			this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picMenu.TabIndex = 9;
			this.picMenu.TabStop = false;
			this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
			this.picMenu.MouseLeave += new System.EventHandler(this.picMenu_MouseLeave);
			this.picMenu.MouseHover += new System.EventHandler(this.picMenu_MouseHover);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGreen;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.btnOwnerDetail);
			this.panel1.Controls.Add(this.materialLabel1);
			this.panel1.Controls.Add(this.materialLabel2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.animSlide.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
			this.panel1.Location = new System.Drawing.Point(249, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(578, 344);
			this.panel1.TabIndex = 16;
			this.panel1.Visible = false;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.animSlide.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.panel2.Location = new System.Drawing.Point(59, 203);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(450, 137);
			this.panel2.TabIndex = 20;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.animPan.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(161, 106);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(125, 18);
			this.label10.TabIndex = 18;
			this.label10.Text = "Phone Number:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.animPan.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(194, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(89, 18);
			this.label11.TabIndex = 17;
			this.label11.Text = "Full Name:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.animPan.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(176, 8);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(157, 22);
			this.label14.TabIndex = 14;
			this.label14.Text = "Land Owner Info";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.animPan.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(222, 174);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 22);
			this.label15.TabIndex = 13;
			this.label15.Text = "Lands";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Red;
			this.animPan.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
			this.pictureBox2.Image = global::Landx.Properties.Resources.close;
			this.pictureBox2.Location = new System.Drawing.Point(558, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// btnOwnerDetail
			// 
			this.btnOwnerDetail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnOwnerDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnOwnerDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnOwnerDetail.BorderRadius = 0;
			this.btnOwnerDetail.ButtonText = "View Details";
			this.btnOwnerDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnOwnerDetail, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnOwnerDetail, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnOwnerDetail, BunifuAnimatorNS.DecorationType.None);
			this.btnOwnerDetail.DisabledColor = System.Drawing.Color.Gray;
			this.btnOwnerDetail.Iconcolor = System.Drawing.Color.Transparent;
			this.btnOwnerDetail.Iconimage = null;
			this.btnOwnerDetail.Iconimage_right = null;
			this.btnOwnerDetail.Iconimage_right_Selected = null;
			this.btnOwnerDetail.Iconimage_Selected = null;
			this.btnOwnerDetail.IconMarginLeft = 0;
			this.btnOwnerDetail.IconMarginRight = 0;
			this.btnOwnerDetail.IconRightVisible = true;
			this.btnOwnerDetail.IconRightZoom = 0D;
			this.btnOwnerDetail.IconVisible = true;
			this.btnOwnerDetail.IconZoom = 90D;
			this.btnOwnerDetail.IsTab = false;
			this.btnOwnerDetail.Location = new System.Drawing.Point(377, 137);
			this.btnOwnerDetail.Name = "btnOwnerDetail";
			this.btnOwnerDetail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnOwnerDetail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnOwnerDetail.OnHoverTextColor = System.Drawing.Color.White;
			this.btnOwnerDetail.selected = false;
			this.btnOwnerDetail.Size = new System.Drawing.Size(132, 30);
			this.btnOwnerDetail.TabIndex = 11;
			this.btnOwnerDetail.Text = "View Details";
			this.btnOwnerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnOwnerDetail.Textcolor = System.Drawing.Color.White;
			this.btnOwnerDetail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// materialLabel1
			// 
			this.animSlide.SetDecoration(this.materialLabel1, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.materialLabel1, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.materialLabel1, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(297, 106);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(266, 21);
			this.materialLabel1.TabIndex = 10;
			this.materialLabel1.Text = "materialLabel7";
			// 
			// materialLabel2
			// 
			this.animSlide.SetDecoration(this.materialLabel2, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.materialLabel2, BunifuAnimatorNS.DecorationType.None);
			this.animPan.SetDecoration(this.materialLabel2, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(297, 62);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(266, 26);
			this.materialLabel2.TabIndex = 7;
			this.materialLabel2.Text = "materialLabel10";
			// 
			// pictureBox3
			// 
			this.animPan.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
			this.pictureBox3.Location = new System.Drawing.Point(12, 6);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(143, 159);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// animMenu
			// 
			this.animMenu.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
			this.animMenu.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 1F;
			this.animMenu.DefaultAnimation = animation1;
			this.animMenu.MaxAnimationTime = 1000;
			this.animMenu.AnimationCompleted += new System.EventHandler<BunifuAnimatorNS.AnimationCompletedEventArg>(this.animMenu_AnimationCompleted);
			// 
			// animPan
			// 
			this.animPan.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
			this.animPan.Cursor = null;
			animation3.AnimateOnlyDifferences = true;
			animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
			animation3.LeafCoeff = 0F;
			animation3.MaxTime = 1F;
			animation3.MinTime = 0F;
			animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
			animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
			animation3.MosaicSize = 20;
			animation3.Padding = new System.Windows.Forms.Padding(30);
			animation3.RotateCoeff = 0F;
			animation3.RotateLimit = 0F;
			animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
			animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
			animation3.TimeCoeff = 0F;
			animation3.TransparencyCoeff = 0F;
			this.animPan.DefaultAnimation = animation3;
			// 
			// btnMap
			// 
			this.btnMap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMap.BorderRadius = 0;
			this.btnMap.ButtonText = "MAP";
			this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnMap, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this.btnMap, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this.btnMap, BunifuAnimatorNS.DecorationType.None);
			this.btnMap.DisabledColor = System.Drawing.Color.Gray;
			this.btnMap.Iconcolor = System.Drawing.Color.Transparent;
			this.btnMap.Iconimage = null;
			this.btnMap.Iconimage_right = null;
			this.btnMap.Iconimage_right_Selected = null;
			this.btnMap.Iconimage_Selected = null;
			this.btnMap.IconMarginLeft = 0;
			this.btnMap.IconMarginRight = 0;
			this.btnMap.IconRightVisible = true;
			this.btnMap.IconRightZoom = 0D;
			this.btnMap.IconVisible = true;
			this.btnMap.IconZoom = 90D;
			this.btnMap.IsTab = false;
			this.btnMap.Location = new System.Drawing.Point(0, 91);
			this.btnMap.Name = "btnMap";
			this.btnMap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
			this.btnMap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.btnMap.OnHoverTextColor = System.Drawing.Color.White;
			this.btnMap.selected = false;
			this.btnMap.Size = new System.Drawing.Size(197, 48);
			this.btnMap.TabIndex = 12;
			this.btnMap.Text = "MAP";
			this.btnMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnMap.Textcolor = System.Drawing.Color.White;
			this.btnMap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 533);
			this.Controls.Add(this.picFind);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panSideBar);
			this.Controls.Add(this.picMenu);
			this.Controls.Add(this.panSearch);
			this.Controls.Add(this.panLand);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panOwner);
			this.animPan.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.animSlide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.animMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.Name = "frmMain";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.panSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picCloseSearch)).EndInit();
			this.panSideBar.ResumeLayout(false);
			this.panOwner.ResumeLayout(false);
			this.panOwner.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseOwner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
			this.panLand.ResumeLayout(false);
			this.panLand.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseLand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picFind;
		private System.Windows.Forms.Panel panSearch;
		private System.Windows.Forms.ListBox lstFound;
		private System.Windows.Forms.PictureBox picCloseSearch;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
		private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panSideBar;
		private System.Windows.Forms.PictureBox picMenu;
		private System.Windows.Forms.Panel panOwner;
		private System.Windows.Forms.Panel panLands4Owner;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox picCloseOwner;
		private MaterialSkin.Controls.MaterialLabel lblOwnerNumber;
		private MaterialSkin.Controls.MaterialLabel lblOwnerName;
		private System.Windows.Forms.PictureBox picOwner;
		private System.Windows.Forms.Panel panLand;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox picCloseLand;
		private MaterialSkin.Controls.MaterialLabel lblLandOwnerNumber;
		private MaterialSkin.Controls.MaterialLabel lblLandOwnerName;
		private MaterialSkin.Controls.MaterialLabel lblLandLocation;
		private MaterialSkin.Controls.MaterialLabel lblLandDescription;
		private System.Windows.Forms.PictureBox picProfile;
		private BunifuAnimatorNS.BunifuTransition animSlide;
		private BunifuAnimatorNS.BunifuTransition animMenu;
		private Bunifu.Framework.UI.BunifuFlatButton btnNewLandLord;
		private Bunifu.Framework.UI.BunifuFlatButton btnTransfer;
		private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
		private Bunifu.Framework.UI.BunifuFlatButton btnNewLand;
		private BunifuAnimatorNS.BunifuTransition animPan;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Bunifu.Framework.UI.BunifuFlatButton btnOwnerDetail;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
		private Bunifu.Framework.UI.BunifuFlatButton btnLandDetails;
		private Bunifu.Framework.UI.BunifuFlatButton btnMap;
	}
}