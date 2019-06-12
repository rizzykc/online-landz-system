namespace Landx
{
	partial class frmMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
			this.ucMap1 = new Landx.ucMap();
			this.SuspendLayout();
			// 
			// ucMap1
			// 
			this.ucMap1.BackColor = System.Drawing.Color.White;
			this.ucMap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMap1.BackgroundImage")));
			this.ucMap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ucMap1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ucMap1.Enabled = false;
			this.ucMap1.Location = new System.Drawing.Point(0, 70);
			this.ucMap1.Mode = null;
			this.ucMap1.Name = "ucMap1";
			this.ucMap1.SelectedLand = 0;
			this.ucMap1.Size = new System.Drawing.Size(1000, 550);
			this.ucMap1.TabIndex = 0;
			// 
			// frmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 650);
			this.Controls.Add(this.ucMap1);
			this.MaximumSize = new System.Drawing.Size(1000, 650);
			this.MinimumSize = new System.Drawing.Size(1000, 650);
			this.Name = "frmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MAP";
			this.Load += new System.EventHandler(this.frmMap_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ucMap ucMap1;
	}
}