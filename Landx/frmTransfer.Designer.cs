namespace Landx
{
	partial class frmTransfer
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstFPstatus = new System.Windows.Forms.ListBox();
            this.panFprint = new System.Windows.Forms.Panel();
            this.lblDisplay = new MaterialSkin.Controls.MaterialLabel();
            this.picFp = new System.Windows.Forms.PictureBox();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelfp = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNextFP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panNew = new System.Windows.Forms.Panel();
            this.lblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.picNewOwnerFP = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnClose = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.animPan = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2.SuspendLayout();
            this.panFprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFp)).BeginInit();
            this.panNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewOwnerFP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lstFPstatus);
            this.animPan.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 72);
            this.panel2.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.animPan.SetDecoration(this.lblStatus, BunifuAnimatorNS.DecorationType.None);
            this.lblStatus.Location = new System.Drawing.Point(12, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(378, 45);
            this.lblStatus.TabIndex = 32;
            // 
            // lstFPstatus
            // 
            this.lstFPstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.lstFPstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animPan.SetDecoration(this.lstFPstatus, BunifuAnimatorNS.DecorationType.None);
            this.lstFPstatus.FormattingEnabled = true;
            this.lstFPstatus.Location = new System.Drawing.Point(396, 3);
            this.lstFPstatus.Name = "lstFPstatus";
            this.lstFPstatus.Size = new System.Drawing.Size(404, 65);
            this.lstFPstatus.TabIndex = 31;
            // 
            // panFprint
            // 
            this.panFprint.BackColor = System.Drawing.Color.LightGreen;
            this.panFprint.Controls.Add(this.lblDisplay);
            this.panFprint.Controls.Add(this.picFp);
            this.panFprint.Controls.Add(this.materialLabel39);
            this.panFprint.Controls.Add(this.btnCancelfp);
            this.panFprint.Controls.Add(this.btnNextFP);
            this.animPan.SetDecoration(this.panFprint, BunifuAnimatorNS.DecorationType.None);
            this.panFprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panFprint.Location = new System.Drawing.Point(190, 129);
            this.panFprint.Name = "panFprint";
            this.panFprint.Size = new System.Drawing.Size(420, 417);
            this.panFprint.TabIndex = 17;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.animPan.SetDecoration(this.lblDisplay, BunifuAnimatorNS.DecorationType.None);
            this.lblDisplay.Depth = 0;
            this.lblDisplay.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDisplay.Location = new System.Drawing.Point(79, 283);
            this.lblDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 19);
            this.lblDisplay.TabIndex = 28;
            // 
            // picFp
            // 
            this.picFp.BackColor = System.Drawing.Color.White;
            this.animPan.SetDecoration(this.picFp, BunifuAnimatorNS.DecorationType.None);
            this.picFp.Location = new System.Drawing.Point(131, 96);
            this.picFp.Name = "picFp";
            this.picFp.Size = new System.Drawing.Size(148, 161);
            this.picFp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFp.TabIndex = 25;
            this.picFp.TabStop = false;
            // 
            // materialLabel39
            // 
            this.materialLabel39.AutoSize = true;
            this.animPan.SetDecoration(this.materialLabel39, BunifuAnimatorNS.DecorationType.None);
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel39.Location = new System.Drawing.Point(138, 44);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(130, 19);
            this.materialLabel39.TabIndex = 4;
            this.materialLabel39.Text = "Verify Land Owner";
            this.materialLabel39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelfp
            // 
            this.btnCancelfp.AutoSize = true;
            this.btnCancelfp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.animPan.SetDecoration(this.btnCancelfp, BunifuAnimatorNS.DecorationType.None);
            this.btnCancelfp.Depth = 0;
            this.btnCancelfp.Location = new System.Drawing.Point(98, 338);
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
            this.animPan.SetDecoration(this.btnNextFP, BunifuAnimatorNS.DecorationType.None);
            this.btnNextFP.Depth = 0;
            this.btnNextFP.Enabled = false;
            this.btnNextFP.Location = new System.Drawing.Point(223, 338);
            this.btnNextFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextFP.Name = "btnNextFP";
            this.btnNextFP.Primary = true;
            this.btnNextFP.Size = new System.Drawing.Size(78, 39);
            this.btnNextFP.TabIndex = 2;
            this.btnNextFP.Text = "NEXT";
            this.btnNextFP.UseVisualStyleBackColor = true;
            this.btnNextFP.Click += new System.EventHandler(this.btnNextFP_Click);
            // 
            // panNew
            // 
            this.panNew.BackColor = System.Drawing.Color.LightGreen;
            this.panNew.Controls.Add(this.lblMsg);
            this.panNew.Controls.Add(this.picNewOwnerFP);
            this.panNew.Controls.Add(this.materialLabel2);
            this.panNew.Controls.Add(this.btnClose);
            this.panNew.Controls.Add(this.btnSave);
            this.animPan.SetDecoration(this.panNew, BunifuAnimatorNS.DecorationType.None);
            this.panNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panNew.Location = new System.Drawing.Point(190, 131);
            this.panNew.Name = "panNew";
            this.panNew.Size = new System.Drawing.Size(420, 417);
            this.panNew.TabIndex = 18;
            this.panNew.Visible = false;
            this.panNew.Paint += new System.Windows.Forms.PaintEventHandler(this.panNew_Paint);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.animPan.SetDecoration(this.lblMsg, BunifuAnimatorNS.DecorationType.None);
            this.lblMsg.Depth = 0;
            this.lblMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(79, 283);
            this.lblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 19);
            this.lblMsg.TabIndex = 28;
            // 
            // picNewOwnerFP
            // 
            this.picNewOwnerFP.BackColor = System.Drawing.Color.White;
            this.animPan.SetDecoration(this.picNewOwnerFP, BunifuAnimatorNS.DecorationType.None);
            this.picNewOwnerFP.Location = new System.Drawing.Point(131, 96);
            this.picNewOwnerFP.Name = "picNewOwnerFP";
            this.picNewOwnerFP.Size = new System.Drawing.Size(148, 161);
            this.picNewOwnerFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewOwnerFP.TabIndex = 25;
            this.picNewOwnerFP.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.animPan.SetDecoration(this.materialLabel2, BunifuAnimatorNS.DecorationType.None);
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(119, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(165, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Verify new Land Owner.";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.animPan.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Depth = 0;
            this.btnClose.Location = new System.Drawing.Point(98, 337);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Primary = false;
            this.btnClose.Size = new System.Drawing.Size(64, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.animPan.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnSave.Depth = 0;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(206, 336);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(78, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // animPan
            // 
            this.animPan.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animPan.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            animation1.TransparencyCoeff = 0F;
            this.animPan.DefaultAnimation = animation1;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panFprint);
            this.Controls.Add(this.panNew);
            this.animPan.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransfer_FormClosing);
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.panel2.ResumeLayout(false);
            this.panFprint.ResumeLayout(false);
            this.panFprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFp)).EndInit();
            this.panNew.ResumeLayout(false);
            this.panNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewOwnerFP)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lstFPstatus;
		private System.Windows.Forms.Panel panFprint;
		private MaterialSkin.Controls.MaterialLabel lblDisplay;
		private System.Windows.Forms.PictureBox picFp;
		private MaterialSkin.Controls.MaterialLabel materialLabel39;
		private MaterialSkin.Controls.MaterialFlatButton btnCancelfp;
		private MaterialSkin.Controls.MaterialRaisedButton btnNextFP;
		private System.Windows.Forms.Panel panNew;
		private MaterialSkin.Controls.MaterialLabel lblMsg;
		private System.Windows.Forms.PictureBox picNewOwnerFP;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialFlatButton btnClose;
		private MaterialSkin.Controls.MaterialRaisedButton btnSave;
		private BunifuAnimatorNS.BunifuTransition animPan;
	}
}