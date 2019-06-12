namespace Landx
{
	partial class frmLand
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLand));
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lstFPstatus = new System.Windows.Forms.ListBox();
			this.panLand = new System.Windows.Forms.Panel();
			this.btnSelectLand = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtTown = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
			this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
			this.lblDocument3 = new MaterialSkin.Controls.MaterialLabel();
			this.txtDocument3Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnDocument3 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
			this.lblDocument5 = new MaterialSkin.Controls.MaterialLabel();
			this.txtDocument5Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnDocument5 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
			this.lblDocument4 = new MaterialSkin.Controls.MaterialLabel();
			this.txtDocument4Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnDocument4 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
			this.lblDocument2 = new MaterialSkin.Controls.MaterialLabel();
			this.txtDocument2Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnDocument2 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
			this.lblDocument1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtDocument1Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.btnDocument1 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
			this.txtLeaseTerm = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
			this.radCustomaryOccupancy = new MaterialSkin.Controls.MaterialRadioButton();
			this.radStatutoryOccupancy = new MaterialSkin.Controls.MaterialRadioButton();
			this.txtVendoName = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
			this.txtLandDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
			this.txtVenorNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
			this.txtVendorAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
			this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
			this.panFprint = new System.Windows.Forms.Panel();
			this.lblDisplay = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
			this.btnCancelfp = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnNextFP = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panelAnim = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.picFp = new System.Windows.Forms.PictureBox();
			this.ucMap1 = new Landx.ucMap();
			this.panel2.SuspendLayout();
			this.panLand.SuspendLayout();
			this.panFprint.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFp)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.panel2.Controls.Add(this.lblStatus);
			this.panel2.Controls.Add(this.lstFPstatus);
			this.panelAnim.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 603);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1000, 72);
			this.panel2.TabIndex = 9;
			// 
			// lblStatus
			// 
			this.panelAnim.SetDecoration(this.lblStatus, BunifuAnimatorNS.DecorationType.None);
			this.lblStatus.Location = new System.Drawing.Point(12, 17);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(396, 45);
			this.lblStatus.TabIndex = 32;
			// 
			// lstFPstatus
			// 
			this.lstFPstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
			this.lstFPstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.panelAnim.SetDecoration(this.lstFPstatus, BunifuAnimatorNS.DecorationType.None);
			this.lstFPstatus.FormattingEnabled = true;
			this.lstFPstatus.Location = new System.Drawing.Point(426, 1);
			this.lstFPstatus.Name = "lstFPstatus";
			this.lstFPstatus.Size = new System.Drawing.Size(454, 65);
			this.lstFPstatus.TabIndex = 31;
			// 
			// panLand
			// 
			this.panLand.BackColor = System.Drawing.Color.LightGreen;
			this.panLand.Controls.Add(this.btnSelectLand);
			this.panLand.Controls.Add(this.materialLabel1);
			this.panLand.Controls.Add(this.txtTown);
			this.panLand.Controls.Add(this.materialLabel17);
			this.panLand.Controls.Add(this.btnCancel);
			this.panLand.Controls.Add(this.materialLabel29);
			this.panLand.Controls.Add(this.lblDocument3);
			this.panLand.Controls.Add(this.txtDocument3Name);
			this.panLand.Controls.Add(this.btnDocument3);
			this.panLand.Controls.Add(this.materialLabel27);
			this.panLand.Controls.Add(this.lblDocument5);
			this.panLand.Controls.Add(this.txtDocument5Name);
			this.panLand.Controls.Add(this.btnDocument5);
			this.panLand.Controls.Add(this.materialLabel25);
			this.panLand.Controls.Add(this.lblDocument4);
			this.panLand.Controls.Add(this.txtDocument4Name);
			this.panLand.Controls.Add(this.btnDocument4);
			this.panLand.Controls.Add(this.materialLabel19);
			this.panLand.Controls.Add(this.lblDocument2);
			this.panLand.Controls.Add(this.txtDocument2Name);
			this.panLand.Controls.Add(this.btnDocument2);
			this.panLand.Controls.Add(this.materialLabel18);
			this.panLand.Controls.Add(this.lblDocument1);
			this.panLand.Controls.Add(this.txtDocument1Name);
			this.panLand.Controls.Add(this.btnDocument1);
			this.panLand.Controls.Add(this.materialLabel16);
			this.panLand.Controls.Add(this.txtLeaseTerm);
			this.panLand.Controls.Add(this.materialLabel13);
			this.panLand.Controls.Add(this.radCustomaryOccupancy);
			this.panLand.Controls.Add(this.radStatutoryOccupancy);
			this.panLand.Controls.Add(this.txtVendoName);
			this.panLand.Controls.Add(this.materialLabel14);
			this.panLand.Controls.Add(this.txtLandDescription);
			this.panLand.Controls.Add(this.materialLabel15);
			this.panLand.Controls.Add(this.txtVenorNumber);
			this.panLand.Controls.Add(this.materialLabel20);
			this.panLand.Controls.Add(this.txtVendorAddress);
			this.panLand.Controls.Add(this.materialLabel21);
			this.panLand.Controls.Add(this.btnSubmit);
			this.panLand.Controls.Add(this.materialLabel24);
			this.panelAnim.SetDecoration(this.panLand, BunifuAnimatorNS.DecorationType.None);
			this.panLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panLand.Location = new System.Drawing.Point(146, 82);
			this.panLand.Name = "panLand";
			this.panLand.Size = new System.Drawing.Size(702, 511);
			this.panLand.TabIndex = 10;
			this.panLand.Visible = false;
			// 
			// btnSelectLand
			// 
			this.panelAnim.SetDecoration(this.btnSelectLand, BunifuAnimatorNS.DecorationType.None);
			this.btnSelectLand.Depth = 0;
			this.btnSelectLand.Location = new System.Drawing.Point(520, 158);
			this.btnSelectLand.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSelectLand.Name = "btnSelectLand";
			this.btnSelectLand.Primary = true;
			this.btnSelectLand.Size = new System.Drawing.Size(152, 30);
			this.btnSelectLand.TabIndex = 54;
			this.btnSelectLand.Text = "Select...";
			this.btnSelectLand.UseVisualStyleBackColor = true;
			this.btnSelectLand.Click += new System.EventHandler(this.btnSelectLand_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel1, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(516, 136);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(158, 18);
			this.materialLabel1.TabIndex = 53;
			this.materialLabel1.Text = "Select Land From Map";
			// 
			// txtTown
			// 
			this.panelAnim.SetDecoration(this.txtTown, BunifuAnimatorNS.DecorationType.None);
			this.txtTown.Depth = 0;
			this.txtTown.Hint = "State(Town)";
			this.txtTown.Location = new System.Drawing.Point(13, 245);
			this.txtTown.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtTown.Name = "txtTown";
			this.txtTown.PasswordChar = '\0';
			this.txtTown.SelectedText = "";
			this.txtTown.SelectionLength = 0;
			this.txtTown.SelectionStart = 0;
			this.txtTown.Size = new System.Drawing.Size(201, 23);
			this.txtTown.TabIndex = 52;
			this.txtTown.UseSystemPasswordChar = false;
			// 
			// materialLabel17
			// 
			this.materialLabel17.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel17, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel17.Depth = 0;
			this.materialLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel17.Location = new System.Drawing.Point(9, 225);
			this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel17.Name = "materialLabel17";
			this.materialLabel17.Size = new System.Drawing.Size(112, 18);
			this.materialLabel17.TabIndex = 51;
			this.materialLabel17.Text = "Land\'s Location";
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelAnim.SetDecoration(this.btnCancel, BunifuAnimatorNS.DecorationType.None);
			this.btnCancel.Depth = 0;
			this.btnCancel.Location = new System.Drawing.Point(378, 470);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Primary = false;
			this.btnCancel.Size = new System.Drawing.Size(64, 36);
			this.btnCancel.TabIndex = 50;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// materialLabel29
			// 
			this.materialLabel29.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel29, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel29.Depth = 0;
			this.materialLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel29.Location = new System.Drawing.Point(480, 326);
			this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel29.Name = "materialLabel29";
			this.materialLabel29.Size = new System.Drawing.Size(44, 18);
			this.materialLabel29.TabIndex = 49;
			this.materialLabel29.Text = "Type:";
			// 
			// lblDocument3
			// 
			this.lblDocument3.AutoSize = true;
			this.panelAnim.SetDecoration(this.lblDocument3, BunifuAnimatorNS.DecorationType.None);
			this.lblDocument3.Depth = 0;
			this.lblDocument3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblDocument3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDocument3.Location = new System.Drawing.Point(557, 359);
			this.lblDocument3.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDocument3.Name = "lblDocument3";
			this.lblDocument3.Size = new System.Drawing.Size(115, 18);
			this.lblDocument3.TabIndex = 48;
			this.lblDocument3.Text = "document name";
			// 
			// txtDocument3Name
			// 
			this.panelAnim.SetDecoration(this.txtDocument3Name, BunifuAnimatorNS.DecorationType.None);
			this.txtDocument3Name.Depth = 0;
			this.txtDocument3Name.Hint = "";
			this.txtDocument3Name.Location = new System.Drawing.Point(535, 322);
			this.txtDocument3Name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtDocument3Name.Name = "txtDocument3Name";
			this.txtDocument3Name.PasswordChar = '\0';
			this.txtDocument3Name.SelectedText = "";
			this.txtDocument3Name.SelectionLength = 0;
			this.txtDocument3Name.SelectionStart = 0;
			this.txtDocument3Name.Size = new System.Drawing.Size(139, 23);
			this.txtDocument3Name.TabIndex = 47;
			this.txtDocument3Name.UseSystemPasswordChar = false;
			// 
			// btnDocument3
			// 
			this.panelAnim.SetDecoration(this.btnDocument3, BunifuAnimatorNS.DecorationType.None);
			this.btnDocument3.Depth = 0;
			this.btnDocument3.Location = new System.Drawing.Point(477, 348);
			this.btnDocument3.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDocument3.Name = "btnDocument3";
			this.btnDocument3.Primary = true;
			this.btnDocument3.Size = new System.Drawing.Size(78, 30);
			this.btnDocument3.TabIndex = 46;
			this.btnDocument3.Text = "Select...";
			this.btnDocument3.UseVisualStyleBackColor = true;
			this.btnDocument3.Click += new System.EventHandler(this.btnDocument3_Click);
			// 
			// materialLabel27
			// 
			this.materialLabel27.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel27, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel27.Depth = 0;
			this.materialLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel27.Location = new System.Drawing.Point(249, 393);
			this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel27.Name = "materialLabel27";
			this.materialLabel27.Size = new System.Drawing.Size(44, 18);
			this.materialLabel27.TabIndex = 45;
			this.materialLabel27.Text = "Type:";
			// 
			// lblDocument5
			// 
			this.lblDocument5.AutoSize = true;
			this.panelAnim.SetDecoration(this.lblDocument5, BunifuAnimatorNS.DecorationType.None);
			this.lblDocument5.Depth = 0;
			this.lblDocument5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblDocument5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDocument5.Location = new System.Drawing.Point(326, 426);
			this.lblDocument5.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDocument5.Name = "lblDocument5";
			this.lblDocument5.Size = new System.Drawing.Size(115, 18);
			this.lblDocument5.TabIndex = 44;
			this.lblDocument5.Text = "document name";
			// 
			// txtDocument5Name
			// 
			this.panelAnim.SetDecoration(this.txtDocument5Name, BunifuAnimatorNS.DecorationType.None);
			this.txtDocument5Name.Depth = 0;
			this.txtDocument5Name.Hint = "";
			this.txtDocument5Name.Location = new System.Drawing.Point(304, 389);
			this.txtDocument5Name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtDocument5Name.Name = "txtDocument5Name";
			this.txtDocument5Name.PasswordChar = '\0';
			this.txtDocument5Name.SelectedText = "";
			this.txtDocument5Name.SelectionLength = 0;
			this.txtDocument5Name.SelectionStart = 0;
			this.txtDocument5Name.Size = new System.Drawing.Size(147, 23);
			this.txtDocument5Name.TabIndex = 43;
			this.txtDocument5Name.UseSystemPasswordChar = false;
			// 
			// btnDocument5
			// 
			this.panelAnim.SetDecoration(this.btnDocument5, BunifuAnimatorNS.DecorationType.None);
			this.btnDocument5.Depth = 0;
			this.btnDocument5.Location = new System.Drawing.Point(246, 415);
			this.btnDocument5.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDocument5.Name = "btnDocument5";
			this.btnDocument5.Primary = true;
			this.btnDocument5.Size = new System.Drawing.Size(78, 30);
			this.btnDocument5.TabIndex = 42;
			this.btnDocument5.Text = "Select...";
			this.btnDocument5.UseVisualStyleBackColor = true;
			this.btnDocument5.Click += new System.EventHandler(this.btnDocument5_Click);
			// 
			// materialLabel25
			// 
			this.materialLabel25.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel25, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel25.Depth = 0;
			this.materialLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel25.Location = new System.Drawing.Point(20, 393);
			this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel25.Name = "materialLabel25";
			this.materialLabel25.Size = new System.Drawing.Size(44, 18);
			this.materialLabel25.TabIndex = 41;
			this.materialLabel25.Text = "Type:";
			// 
			// lblDocument4
			// 
			this.lblDocument4.AutoSize = true;
			this.panelAnim.SetDecoration(this.lblDocument4, BunifuAnimatorNS.DecorationType.None);
			this.lblDocument4.Depth = 0;
			this.lblDocument4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblDocument4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDocument4.Location = new System.Drawing.Point(97, 426);
			this.lblDocument4.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDocument4.Name = "lblDocument4";
			this.lblDocument4.Size = new System.Drawing.Size(115, 18);
			this.lblDocument4.TabIndex = 40;
			this.lblDocument4.Text = "document name";
			// 
			// txtDocument4Name
			// 
			this.panelAnim.SetDecoration(this.txtDocument4Name, BunifuAnimatorNS.DecorationType.None);
			this.txtDocument4Name.Depth = 0;
			this.txtDocument4Name.Hint = "";
			this.txtDocument4Name.Location = new System.Drawing.Point(75, 389);
			this.txtDocument4Name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtDocument4Name.Name = "txtDocument4Name";
			this.txtDocument4Name.PasswordChar = '\0';
			this.txtDocument4Name.SelectedText = "";
			this.txtDocument4Name.SelectionLength = 0;
			this.txtDocument4Name.SelectionStart = 0;
			this.txtDocument4Name.Size = new System.Drawing.Size(146, 23);
			this.txtDocument4Name.TabIndex = 39;
			this.txtDocument4Name.UseSystemPasswordChar = false;
			// 
			// btnDocument4
			// 
			this.panelAnim.SetDecoration(this.btnDocument4, BunifuAnimatorNS.DecorationType.None);
			this.btnDocument4.Depth = 0;
			this.btnDocument4.Location = new System.Drawing.Point(17, 415);
			this.btnDocument4.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDocument4.Name = "btnDocument4";
			this.btnDocument4.Primary = true;
			this.btnDocument4.Size = new System.Drawing.Size(78, 30);
			this.btnDocument4.TabIndex = 38;
			this.btnDocument4.Text = "Select...";
			this.btnDocument4.UseVisualStyleBackColor = true;
			this.btnDocument4.Click += new System.EventHandler(this.btnDocument4_Click);
			// 
			// materialLabel19
			// 
			this.materialLabel19.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel19, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel19.Depth = 0;
			this.materialLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel19.Location = new System.Drawing.Point(249, 326);
			this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel19.Name = "materialLabel19";
			this.materialLabel19.Size = new System.Drawing.Size(44, 18);
			this.materialLabel19.TabIndex = 37;
			this.materialLabel19.Text = "Type:";
			// 
			// lblDocument2
			// 
			this.lblDocument2.AutoSize = true;
			this.panelAnim.SetDecoration(this.lblDocument2, BunifuAnimatorNS.DecorationType.None);
			this.lblDocument2.Depth = 0;
			this.lblDocument2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblDocument2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDocument2.Location = new System.Drawing.Point(326, 359);
			this.lblDocument2.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDocument2.Name = "lblDocument2";
			this.lblDocument2.Size = new System.Drawing.Size(115, 18);
			this.lblDocument2.TabIndex = 36;
			this.lblDocument2.Text = "document name";
			// 
			// txtDocument2Name
			// 
			this.panelAnim.SetDecoration(this.txtDocument2Name, BunifuAnimatorNS.DecorationType.None);
			this.txtDocument2Name.Depth = 0;
			this.txtDocument2Name.Hint = "";
			this.txtDocument2Name.Location = new System.Drawing.Point(304, 322);
			this.txtDocument2Name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtDocument2Name.Name = "txtDocument2Name";
			this.txtDocument2Name.PasswordChar = '\0';
			this.txtDocument2Name.SelectedText = "";
			this.txtDocument2Name.SelectionLength = 0;
			this.txtDocument2Name.SelectionStart = 0;
			this.txtDocument2Name.Size = new System.Drawing.Size(147, 23);
			this.txtDocument2Name.TabIndex = 35;
			this.txtDocument2Name.UseSystemPasswordChar = false;
			// 
			// btnDocument2
			// 
			this.panelAnim.SetDecoration(this.btnDocument2, BunifuAnimatorNS.DecorationType.None);
			this.btnDocument2.Depth = 0;
			this.btnDocument2.Location = new System.Drawing.Point(246, 348);
			this.btnDocument2.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDocument2.Name = "btnDocument2";
			this.btnDocument2.Primary = true;
			this.btnDocument2.Size = new System.Drawing.Size(78, 30);
			this.btnDocument2.TabIndex = 34;
			this.btnDocument2.Text = "Select...";
			this.btnDocument2.UseVisualStyleBackColor = true;
			this.btnDocument2.Click += new System.EventHandler(this.btnDocument2_Click);
			// 
			// materialLabel18
			// 
			this.materialLabel18.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel18, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel18.Depth = 0;
			this.materialLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel18.Location = new System.Drawing.Point(20, 326);
			this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel18.Name = "materialLabel18";
			this.materialLabel18.Size = new System.Drawing.Size(44, 18);
			this.materialLabel18.TabIndex = 33;
			this.materialLabel18.Text = "Type:";
			// 
			// lblDocument1
			// 
			this.lblDocument1.AutoSize = true;
			this.panelAnim.SetDecoration(this.lblDocument1, BunifuAnimatorNS.DecorationType.None);
			this.lblDocument1.Depth = 0;
			this.lblDocument1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblDocument1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDocument1.Location = new System.Drawing.Point(97, 359);
			this.lblDocument1.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDocument1.Name = "lblDocument1";
			this.lblDocument1.Size = new System.Drawing.Size(115, 18);
			this.lblDocument1.TabIndex = 32;
			this.lblDocument1.Text = "document name";
			// 
			// txtDocument1Name
			// 
			this.panelAnim.SetDecoration(this.txtDocument1Name, BunifuAnimatorNS.DecorationType.None);
			this.txtDocument1Name.Depth = 0;
			this.txtDocument1Name.Hint = "";
			this.txtDocument1Name.Location = new System.Drawing.Point(75, 322);
			this.txtDocument1Name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtDocument1Name.Name = "txtDocument1Name";
			this.txtDocument1Name.PasswordChar = '\0';
			this.txtDocument1Name.SelectedText = "";
			this.txtDocument1Name.SelectionLength = 0;
			this.txtDocument1Name.SelectionStart = 0;
			this.txtDocument1Name.Size = new System.Drawing.Size(146, 23);
			this.txtDocument1Name.TabIndex = 31;
			this.txtDocument1Name.UseSystemPasswordChar = false;
			// 
			// btnDocument1
			// 
			this.panelAnim.SetDecoration(this.btnDocument1, BunifuAnimatorNS.DecorationType.None);
			this.btnDocument1.Depth = 0;
			this.btnDocument1.Location = new System.Drawing.Point(17, 348);
			this.btnDocument1.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDocument1.Name = "btnDocument1";
			this.btnDocument1.Primary = true;
			this.btnDocument1.Size = new System.Drawing.Size(78, 30);
			this.btnDocument1.TabIndex = 30;
			this.btnDocument1.Text = "Select...";
			this.btnDocument1.UseVisualStyleBackColor = true;
			this.btnDocument1.Click += new System.EventHandler(this.btnDocument1_Click);
			// 
			// materialLabel16
			// 
			this.materialLabel16.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel16, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel16.Depth = 0;
			this.materialLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel16.Location = new System.Drawing.Point(286, 296);
			this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel16.Name = "materialLabel16";
			this.materialLabel16.Size = new System.Drawing.Size(139, 18);
			this.materialLabel16.TabIndex = 29;
			this.materialLabel16.Text = "Related Documents";
			// 
			// txtLeaseTerm
			// 
			this.panelAnim.SetDecoration(this.txtLeaseTerm, BunifuAnimatorNS.DecorationType.None);
			this.txtLeaseTerm.Depth = 0;
			this.txtLeaseTerm.Hint = "";
			this.txtLeaseTerm.Location = new System.Drawing.Point(515, 245);
			this.txtLeaseTerm.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtLeaseTerm.Name = "txtLeaseTerm";
			this.txtLeaseTerm.PasswordChar = '\0';
			this.txtLeaseTerm.SelectedText = "";
			this.txtLeaseTerm.SelectionLength = 0;
			this.txtLeaseTerm.SelectionStart = 0;
			this.txtLeaseTerm.Size = new System.Drawing.Size(157, 23);
			this.txtLeaseTerm.TabIndex = 28;
			this.txtLeaseTerm.UseSystemPasswordChar = false;
			// 
			// materialLabel13
			// 
			this.materialLabel13.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel13, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel13.Depth = 0;
			this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel13.Location = new System.Drawing.Point(511, 225);
			this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel13.Name = "materialLabel13";
			this.materialLabel13.Size = new System.Drawing.Size(172, 18);
			this.materialLabel13.TabIndex = 27;
			this.materialLabel13.Text = "Term of Lease (if leased)";
			// 
			// radCustomaryOccupancy
			// 
			this.radCustomaryOccupancy.AutoSize = true;
			this.panelAnim.SetDecoration(this.radCustomaryOccupancy, BunifuAnimatorNS.DecorationType.None);
			this.radCustomaryOccupancy.Depth = 0;
			this.radCustomaryOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.radCustomaryOccupancy.Location = new System.Drawing.Point(377, 248);
			this.radCustomaryOccupancy.Margin = new System.Windows.Forms.Padding(0);
			this.radCustomaryOccupancy.MouseLocation = new System.Drawing.Point(-1, -1);
			this.radCustomaryOccupancy.MouseState = MaterialSkin.MouseState.HOVER;
			this.radCustomaryOccupancy.Name = "radCustomaryOccupancy";
			this.radCustomaryOccupancy.Ripple = true;
			this.radCustomaryOccupancy.Size = new System.Drawing.Size(96, 30);
			this.radCustomaryOccupancy.TabIndex = 26;
			this.radCustomaryOccupancy.TabStop = true;
			this.radCustomaryOccupancy.Text = "Customary";
			this.radCustomaryOccupancy.UseVisualStyleBackColor = true;
			// 
			// radStatutoryOccupancy
			// 
			this.radStatutoryOccupancy.AutoSize = true;
			this.panelAnim.SetDecoration(this.radStatutoryOccupancy, BunifuAnimatorNS.DecorationType.None);
			this.radStatutoryOccupancy.Depth = 0;
			this.radStatutoryOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.radStatutoryOccupancy.Location = new System.Drawing.Point(288, 248);
			this.radStatutoryOccupancy.Margin = new System.Windows.Forms.Padding(0);
			this.radStatutoryOccupancy.MouseLocation = new System.Drawing.Point(-1, -1);
			this.radStatutoryOccupancy.MouseState = MaterialSkin.MouseState.HOVER;
			this.radStatutoryOccupancy.Name = "radStatutoryOccupancy";
			this.radStatutoryOccupancy.Ripple = true;
			this.radStatutoryOccupancy.Size = new System.Drawing.Size(85, 30);
			this.radStatutoryOccupancy.TabIndex = 25;
			this.radStatutoryOccupancy.TabStop = true;
			this.radStatutoryOccupancy.Text = "Statutory";
			this.radStatutoryOccupancy.UseVisualStyleBackColor = true;
			// 
			// txtVendoName
			// 
			this.panelAnim.SetDecoration(this.txtVendoName, BunifuAnimatorNS.DecorationType.None);
			this.txtVendoName.Depth = 0;
			this.txtVendoName.Hint = "";
			this.txtVendoName.Location = new System.Drawing.Point(13, 87);
			this.txtVendoName.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtVendoName.Name = "txtVendoName";
			this.txtVendoName.PasswordChar = '\0';
			this.txtVendoName.SelectedText = "";
			this.txtVendoName.SelectionLength = 0;
			this.txtVendoName.SelectionStart = 0;
			this.txtVendoName.Size = new System.Drawing.Size(235, 23);
			this.txtVendoName.TabIndex = 22;
			this.txtVendoName.UseSystemPasswordChar = false;
			// 
			// materialLabel14
			// 
			this.materialLabel14.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel14, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel14.Depth = 0;
			this.materialLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel14.Location = new System.Drawing.Point(9, 67);
			this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel14.Name = "materialLabel14";
			this.materialLabel14.Size = new System.Drawing.Size(170, 18);
			this.materialLabel14.TabIndex = 21;
			this.materialLabel14.Text = "Vendor/Guarantor Name";
			// 
			// txtLandDescription
			// 
			this.panelAnim.SetDecoration(this.txtLandDescription, BunifuAnimatorNS.DecorationType.None);
			this.txtLandDescription.Depth = 0;
			this.txtLandDescription.Hint = "exact location, land marks etc.";
			this.txtLandDescription.Location = new System.Drawing.Point(13, 165);
			this.txtLandDescription.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtLandDescription.Name = "txtLandDescription";
			this.txtLandDescription.PasswordChar = '\0';
			this.txtLandDescription.SelectedText = "";
			this.txtLandDescription.SelectionLength = 0;
			this.txtLandDescription.SelectionStart = 0;
			this.txtLandDescription.Size = new System.Drawing.Size(470, 23);
			this.txtLandDescription.TabIndex = 20;
			this.txtLandDescription.UseSystemPasswordChar = false;
			// 
			// materialLabel15
			// 
			this.materialLabel15.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel15, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel15.Depth = 0;
			this.materialLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel15.Location = new System.Drawing.Point(9, 145);
			this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel15.Name = "materialLabel15";
			this.materialLabel15.Size = new System.Drawing.Size(280, 18);
			this.materialLabel15.TabIndex = 19;
			this.materialLabel15.Text = "Description of Land for Easy Identification";
			// 
			// txtVenorNumber
			// 
			this.panelAnim.SetDecoration(this.txtVenorNumber, BunifuAnimatorNS.DecorationType.None);
			this.txtVenorNumber.Depth = 0;
			this.txtVenorNumber.Hint = "";
			this.txtVenorNumber.Location = new System.Drawing.Point(515, 87);
			this.txtVenorNumber.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtVenorNumber.Name = "txtVenorNumber";
			this.txtVenorNumber.PasswordChar = '\0';
			this.txtVenorNumber.SelectedText = "";
			this.txtVenorNumber.SelectionLength = 0;
			this.txtVenorNumber.SelectionStart = 0;
			this.txtVenorNumber.Size = new System.Drawing.Size(157, 23);
			this.txtVenorNumber.TabIndex = 10;
			this.txtVenorNumber.UseSystemPasswordChar = false;
			// 
			// materialLabel20
			// 
			this.materialLabel20.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel20, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel20.Depth = 0;
			this.materialLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel20.Location = new System.Drawing.Point(511, 67);
			this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel20.Name = "materialLabel20";
			this.materialLabel20.Size = new System.Drawing.Size(108, 18);
			this.materialLabel20.TabIndex = 9;
			this.materialLabel20.Text = "Phone Number";
			// 
			// txtVendorAddress
			// 
			this.panelAnim.SetDecoration(this.txtVendorAddress, BunifuAnimatorNS.DecorationType.None);
			this.txtVendorAddress.Depth = 0;
			this.txtVendorAddress.Hint = "";
			this.txtVendorAddress.Location = new System.Drawing.Point(290, 87);
			this.txtVendorAddress.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtVendorAddress.Name = "txtVendorAddress";
			this.txtVendorAddress.PasswordChar = '\0';
			this.txtVendorAddress.SelectedText = "";
			this.txtVendorAddress.SelectionLength = 0;
			this.txtVendorAddress.SelectionStart = 0;
			this.txtVendorAddress.Size = new System.Drawing.Size(193, 23);
			this.txtVendorAddress.TabIndex = 8;
			this.txtVendorAddress.UseSystemPasswordChar = false;
			// 
			// materialLabel21
			// 
			this.materialLabel21.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel21, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel21.Depth = 0;
			this.materialLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel21.Location = new System.Drawing.Point(286, 62);
			this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel21.Name = "materialLabel21";
			this.materialLabel21.Size = new System.Drawing.Size(184, 18);
			this.materialLabel21.TabIndex = 7;
			this.materialLabel21.Text = "Vendor/Guarantor Address";
			// 
			// btnSubmit
			// 
			this.panelAnim.SetDecoration(this.btnSubmit, BunifuAnimatorNS.DecorationType.None);
			this.btnSubmit.Depth = 0;
			this.btnSubmit.Location = new System.Drawing.Point(235, 469);
			this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Primary = true;
			this.btnSubmit.Size = new System.Drawing.Size(78, 39);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// materialLabel24
			// 
			this.materialLabel24.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel24, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel24.Depth = 0;
			this.materialLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel24.Location = new System.Drawing.Point(285, 225);
			this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel24.Name = "materialLabel24";
			this.materialLabel24.Size = new System.Drawing.Size(136, 18);
			this.materialLabel24.TabIndex = 0;
			this.materialLabel24.Text = "Type of Occupancy";
			// 
			// panFprint
			// 
			this.panFprint.BackColor = System.Drawing.Color.LightGreen;
			this.panFprint.Controls.Add(this.lblDisplay);
			this.panFprint.Controls.Add(this.picFp);
			this.panFprint.Controls.Add(this.materialLabel39);
			this.panFprint.Controls.Add(this.btnCancelfp);
			this.panFprint.Controls.Add(this.btnNextFP);
			this.panelAnim.SetDecoration(this.panFprint, BunifuAnimatorNS.DecorationType.None);
			this.panFprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panFprint.Location = new System.Drawing.Point(247, 146);
			this.panFprint.Name = "panFprint";
			this.panFprint.Size = new System.Drawing.Size(480, 382);
			this.panFprint.TabIndex = 11;
			// 
			// lblDisplay
			// 
			this.lblDisplay.AutoSize = true;
			this.panelAnim.SetDecoration(this.lblDisplay, BunifuAnimatorNS.DecorationType.None);
			this.lblDisplay.Depth = 0;
			this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDisplay.Location = new System.Drawing.Point(57, 301);
			this.lblDisplay.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(0, 18);
			this.lblDisplay.TabIndex = 28;
			// 
			// materialLabel39
			// 
			this.materialLabel39.AutoSize = true;
			this.panelAnim.SetDecoration(this.materialLabel39, BunifuAnimatorNS.DecorationType.None);
			this.materialLabel39.Depth = 0;
			this.materialLabel39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.materialLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel39.Location = new System.Drawing.Point(121, 62);
			this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel39.Name = "materialLabel39";
			this.materialLabel39.Size = new System.Drawing.Size(212, 18);
			this.materialLabel39.TabIndex = 4;
			this.materialLabel39.Text = "Input the Landlord\'s Fingerprint.";
			this.materialLabel39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelfp
			// 
			this.btnCancelfp.AutoSize = true;
			this.btnCancelfp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelAnim.SetDecoration(this.btnCancelfp, BunifuAnimatorNS.DecorationType.None);
			this.btnCancelfp.Depth = 0;
			this.btnCancelfp.Location = new System.Drawing.Point(135, 333);
			this.btnCancelfp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnCancelfp.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCancelfp.Name = "btnCancelfp";
			this.btnCancelfp.Primary = false;
			this.btnCancelfp.Size = new System.Drawing.Size(64, 36);
			this.btnCancelfp.TabIndex = 3;
			this.btnCancelfp.Text = "Cancel";
			this.btnCancelfp.UseVisualStyleBackColor = true;
			this.btnCancelfp.Click += new System.EventHandler(this.btnCancelfp_Click);
			// 
			// btnNextFP
			// 
			this.panelAnim.SetDecoration(this.btnNextFP, BunifuAnimatorNS.DecorationType.None);
			this.btnNextFP.Depth = 0;
			this.btnNextFP.Enabled = false;
			this.btnNextFP.Location = new System.Drawing.Point(262, 332);
			this.btnNextFP.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnNextFP.Name = "btnNextFP";
			this.btnNextFP.Primary = true;
			this.btnNextFP.Size = new System.Drawing.Size(78, 39);
			this.btnNextFP.TabIndex = 2;
			this.btnNextFP.Text = "Next";
			this.btnNextFP.UseVisualStyleBackColor = true;
			this.btnNextFP.Click += new System.EventHandler(this.btnNextFP_Click);
			// 
			// panelAnim
			// 
			this.panelAnim.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
			this.panelAnim.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
			animation2.LeafCoeff = 1F;
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
			this.panelAnim.DefaultAnimation = animation2;
			// 
			// picFp
			// 
			this.picFp.BackColor = System.Drawing.Color.White;
			this.panelAnim.SetDecoration(this.picFp, BunifuAnimatorNS.DecorationType.None);
			this.picFp.Location = new System.Drawing.Point(153, 119);
			this.picFp.Name = "picFp";
			this.picFp.Size = new System.Drawing.Size(148, 161);
			this.picFp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picFp.TabIndex = 25;
			this.picFp.TabStop = false;
			// 
			// ucMap1
			// 
			this.ucMap1.BackColor = System.Drawing.Color.White;
			this.ucMap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMap1.BackgroundImage")));
			this.ucMap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelAnim.SetDecoration(this.ucMap1, BunifuAnimatorNS.DecorationType.None);
			this.ucMap1.Enabled = false;
			this.ucMap1.Location = new System.Drawing.Point(0, 65);
			this.ucMap1.Mode = null;
			this.ucMap1.Name = "ucMap1";
			this.ucMap1.SelectedLand = -1;
			this.ucMap1.Size = new System.Drawing.Size(1000, 550);
			this.ucMap1.TabIndex = 12;
			this.ucMap1.Visible = false;
			this.ucMap1.VisibleChanged += new System.EventHandler(this.ucMap1_VisibleChanged);
			// 
			// frmLand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 675);
			this.Controls.Add(this.panLand);
			this.Controls.Add(this.panFprint);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.ucMap1);
			this.panelAnim.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.Name = "frmLand";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Land";
			this.Load += new System.EventHandler(this.frmLand_Load);
			this.panel2.ResumeLayout(false);
			this.panLand.ResumeLayout(false);
			this.panLand.PerformLayout();
			this.panFprint.ResumeLayout(false);
			this.panFprint.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lstFPstatus;
		private System.Windows.Forms.Panel panLand;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtTown;
		private MaterialSkin.Controls.MaterialLabel materialLabel17;
		private MaterialSkin.Controls.MaterialFlatButton btnCancel;
		private MaterialSkin.Controls.MaterialLabel materialLabel29;
		private MaterialSkin.Controls.MaterialLabel lblDocument3;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtDocument3Name;
		private MaterialSkin.Controls.MaterialRaisedButton btnDocument3;
		private MaterialSkin.Controls.MaterialLabel materialLabel27;
		private MaterialSkin.Controls.MaterialLabel lblDocument5;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtDocument5Name;
		private MaterialSkin.Controls.MaterialRaisedButton btnDocument5;
		private MaterialSkin.Controls.MaterialLabel materialLabel25;
		private MaterialSkin.Controls.MaterialLabel lblDocument4;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtDocument4Name;
		private MaterialSkin.Controls.MaterialRaisedButton btnDocument4;
		private MaterialSkin.Controls.MaterialLabel materialLabel19;
		private MaterialSkin.Controls.MaterialLabel lblDocument2;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtDocument2Name;
		private MaterialSkin.Controls.MaterialRaisedButton btnDocument2;
		private MaterialSkin.Controls.MaterialLabel materialLabel18;
		private MaterialSkin.Controls.MaterialLabel lblDocument1;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtDocument1Name;
		private MaterialSkin.Controls.MaterialRaisedButton btnDocument1;
		private MaterialSkin.Controls.MaterialLabel materialLabel16;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtLeaseTerm;
		private MaterialSkin.Controls.MaterialLabel materialLabel13;
		private MaterialSkin.Controls.MaterialRadioButton radCustomaryOccupancy;
		private MaterialSkin.Controls.MaterialRadioButton radStatutoryOccupancy;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtVendoName;
		private MaterialSkin.Controls.MaterialLabel materialLabel14;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtLandDescription;
		private MaterialSkin.Controls.MaterialLabel materialLabel15;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtVenorNumber;
		private MaterialSkin.Controls.MaterialLabel materialLabel20;
		private MaterialSkin.Controls.MaterialSingleLineTextField txtVendorAddress;
		private MaterialSkin.Controls.MaterialLabel materialLabel21;
		private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
		private MaterialSkin.Controls.MaterialLabel materialLabel24;
		private System.Windows.Forms.Panel panFprint;
		private MaterialSkin.Controls.MaterialLabel lblDisplay;
		private System.Windows.Forms.PictureBox picFp;
		private MaterialSkin.Controls.MaterialLabel materialLabel39;
		private MaterialSkin.Controls.MaterialFlatButton btnCancelfp;
		private MaterialSkin.Controls.MaterialRaisedButton btnNextFP;
		private BunifuAnimatorNS.BunifuTransition panelAnim;
		private MaterialSkin.Controls.MaterialRaisedButton btnSelectLand;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private ucMap ucMap1;
	}
}