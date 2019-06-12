using DPFP;
using Landx.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landx
{
	public partial class frmEditLand : MaterialForm, DPFP.Capture.EventHandler
	{
        private DPFP.Capture.Capture Capturer;
		private List<Template> Owners = new List<Template>();
		private DPFP.Verification.Verification Verificator;

		private delegate void updateForm(string s);
		private delegate void updateFormCtrl(Boolean s);
		private Person Dlandlord = new Person();

		string LLFPpath = Application.StartupPath + "/LandLordFP";
		string NoKFPpath = Application.StartupPath + "/NextOfKinFP";
		string docPath = Application.StartupPath + "/documents/";
		int LLId = 0;
        int psnId = 0;
		Land land = new Land();
		
		bool doc1changed = false, doc2changed = false, doc3changed = false, doc4changed = false, doc5changed = false;

		public frmEditLand()
		{
			InitializeComponent();
		}

		private void frmEditLand_Load(object sender, EventArgs e)
		{
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
				Primary.Green100, Accent.LightGreen200, TextShade.WHITE);

			LLId = ((Land)Tag).Id;
            psnId = (int)((Land)Tag).PersonId;

            FileInfo file = new FileInfo(LLFPpath + "/" + psnId.ToString() + ".fpt");

			using (FileStream f = file.OpenRead())
			{
				Template fpt = new Template(f);
				Owners.Add(fpt);
			}

			file = new FileInfo(NoKFPpath + "/" + psnId.ToString() + ".fpt");

			using (FileStream f = file.OpenRead())
			{
				Template fpt = new Template(f);
				Owners.Add(fpt);
			}
            Capturer = new DPFP.Capture.Capture();
            Verificator = new DPFP.Verification.Verification();
			Init();
			Start();
		}

		protected void Init()
		{
			Capturer = new DPFP.Capture.Capture();                  // Create a capture operation.
			Capturer.EventHandler = this;                           // Subscribe for capturing events.
		}

		protected void Start()
		{
			Capturer.StartCapture();
			SetPrompt("Using the fingerprint reader, scan your fingerprint.");
		}

		protected void Stop()
		{
			Capturer.StopCapture();
		}

		#region EventHandler Members:

		public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
		{
			MakeReport("The fingerprint sample was captured.");
			SetPrompt("Scan the same fingerprint again.");
			ProcessVerify(Sample);
		}

		public void OnFingerGone(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The finger was removed from the fingerprint reader.");
		}

		public void OnFingerTouch(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The fingerprint reader was touched.");
		}

		public void OnReaderConnect(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The fingerprint reader was connected.");
		}

		public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
		{
			MakeReport("The fingerprint reader was disconnected.");
		}

		public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
		{
			if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
				MakeReport("The quality of the fingerprint sample is good.");
			else
				MakeReport("The quality of the fingerprint sample is poor.");
		}
		#endregion


		#region FingerPrint Processes

		protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
		{
			DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
			Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
			Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
			return bitmap;
		}

		protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
		{
			DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
			DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
			DPFP.FeatureSet features = new DPFP.FeatureSet();
			Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
			if (feedback == DPFP.Capture.CaptureFeedback.Good)
				return features;
			else
				return null;
		}

		protected void SetStatus(string status)
        {
            try
            {
			this.Invoke(new Function(delegate ()
			{
				lblStatus.Text = status;
			}));
            }
            catch (Exception)
            {
            }
		}

		protected void SetPrompt(string prompt)
        {
            try
            {
			this.Invoke(new Function(delegate ()
			{
				lblStatus.Text = prompt;
			}));

            }
            catch (Exception)
            {
            }
		}
		protected void MakeReport(string message)
		{
                try
                {
			this.Invoke(new Function(delegate ()
            {
                    lstFPstatus.Items.Add(message);
				    lstFPstatus.TopIndex = lstFPstatus.Items.Count - 1;
			}));
                }
                catch (Exception)
                {
                    
                }
				
		}

		private void DrawPicture(Bitmap bitmap)
        {
            try
            {
			this.Invoke(new Function(delegate ()
			{
				picFp.Image = new Bitmap(bitmap, picFp.Size);   // fit the image into the picture box
			}));
            }
            catch (Exception)
            {
            }
		}

		protected void ProcessVerify(DPFP.Sample Sample)
		{
			try
			{
				// Draw fingerprint sample image.
				DrawPicture(ConvertSampleToBitmap(Sample));

				// Process the sample and create a feature set for the enrollment purpose.
				DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

				// Check quality of the sample and start verification if it's good
				// TODO: move to a separate task
				if (features != null)
				{
					DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
					bool found = false;
					int index = 0;
					// Compare the feature set with each of our template
					foreach (var llt in Owners)
					{

						Verificator.Verify(features, llt, ref result);

						if (result.Verified)
						{
							found = true;
							using (var db = new LandxEntities())
							{
								Dlandlord = db.People.Find(psnId);
							}
							MakeReport("The fingerprint was VERIFIED.");
							displayMsg("Welcome " + Dlandlord.ApplicantsFullname);
							enableNextFP();

							break;
						}
						index++;
					}
					if (!found)
					{
						MakeReport("The fingerprint was NOT VERIFIED.");
					}
				}

				Capturer.StartCapture();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occured while comparing with fingerprint database. \n\r\n\r" + ex.ToString());
			}
		}

		protected void displayMsg(string msg)
        {
            try
            {
			this.Invoke(new Function(delegate ()
			{
				lblDisplay.Text = msg;
			}));
            }
            catch (Exception)
            {
            }
		}

		protected void enableNextFP()
        {
            try
            {
			this.Invoke(new Function(delegate ()
			{
				btnNextFP.Enabled = true;
			}));
            }
            catch (Exception)
            {
            }
		}

		//private void UpdateStatus()
		//{
		//	// Show number of samples needed.
		//	SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
		//}


		#endregion

		private void btnCancelfp_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnNextFP_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
            Stop();
			land = (Models.Land)this.Tag;

			txtLandDescription.Text = land.LandDescription;
			txtLeaseTerm.Text = land.LeaseTerm;
			txtTown.Text = land.Town;

			if (land.TypeofOccupancy == "Customary") { radCustomaryOccupancy.Checked = true; }
			else if (land.TypeofOccupancy == "Statutory") { radStatutoryOccupancy.Checked = true; }

			txtVendorAddress.Text = land.VendorGuarantorAddress;
			txtVendoName.Text = land.VendorGuarantorName;
			txtVenorNumber.Text = land.VendorGuarantorPhone;

			if (!string.IsNullOrWhiteSpace(land.LandDoc1))
			{
				lblDoc1.Text = land.LandDoc1.Replace(land.LandDoc1.Substring(land.LandDoc1.IndexOf("_")), "");
				txtDocument1Name.Text = land.LandDoc1.Replace(land.LandDoc1.Substring(land.LandDoc1.IndexOf("_")), "");
			}

			if (!string.IsNullOrWhiteSpace(land.LandDoc2))
			{
				lblDoc2.Text = land.LandDoc2.Replace(land.LandDoc2.Substring(land.LandDoc2.IndexOf("_")), "");
				txtDocument2Name.Text = land.LandDoc2.Replace(land.LandDoc2.Substring(land.LandDoc2.IndexOf("_")), "");
			}

			if (!string.IsNullOrWhiteSpace(land.LandDoc3))
			{
				lblDoc3.Text = land.LandDoc3.Replace(land.LandDoc3.Substring(land.LandDoc3.IndexOf("_")), "");
				txtDocument3Name.Text = land.LandDoc3.Replace(land.LandDoc3.Substring(land.LandDoc3.IndexOf("_")), "");
			}

			if (!string.IsNullOrWhiteSpace(land.LandDoc4))
			{
				lblDoc4.Text = land.LandDoc4.Replace(land.LandDoc4.Substring(land.LandDoc4.IndexOf("_")), "");
				txtDocument4Name.Text = land.LandDoc4.Replace(land.LandDoc4.Substring(land.LandDoc4.IndexOf("_")), "");
			}

			if (!string.IsNullOrWhiteSpace(land.LandDoc5))
			{
				lblDoc5.Text = land.LandDoc5.Replace(land.LandDoc5.Substring(land.LandDoc5.IndexOf("_")), "");
				txtDocument5Name.Text = land.LandDoc5.Replace(land.LandDoc5.Substring(land.LandDoc5.IndexOf("_")), "");
			}
			panelAnim.HideSync(panFprint);
			panelAnim.ShowSync(panLand);

			Cursor = Cursors.Arrow;
		}

		private void btnEditDocs_Click(object sender, EventArgs e)
		{
			panelAnim.HideSync(panViewDocs);
			panelAnim.ShowSync(panEditDoc);
		}

		private void btnDocument1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument1.Tag = dlgDocs.FileName;
				lblDocument1.Text = dlgDocs.SafeFileName;
				doc1changed = true;
			}
		}

		private void btnDocument2_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument2.Tag = dlgDocs.FileName;
				lblDocument2.Text = dlgDocs.SafeFileName;
				doc2changed = true;
			}
		}

		private void btnDocument3_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument3.Tag = dlgDocs.FileName;
				lblDocument3.Text = dlgDocs.SafeFileName;
				doc3changed = true;
			}
		}

		private void btnDocument4_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument4.Tag = dlgDocs.FileName;
				lblDocument4.Text = dlgDocs.SafeFileName;
				doc4changed = true;
			}
		}

		private void btnDocument5_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument5.Tag = dlgDocs.FileName;
				lblDocument5.Text = dlgDocs.SafeFileName;
				doc5changed = true;
			}
		}

		private void btnOpenDoc1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(land.LandDoc1))
			{
				Process.Start(docPath + land.LandDoc1);
			}
		}

		private void btnOpenDoc2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(land.LandDoc2))
			{
				Process.Start(docPath + land.LandDoc2);
			}
		}

		private void btnOpenDoc3_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(land.LandDoc3))
			{
				Process.Start(docPath + land.LandDoc3);
			}
		}

        private void frmEditLand_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Capturer==null))
            {
                Stop();
            }
        }

        private void btnOpenDoc4_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(land.LandDoc4))
			{
				Process.Start(docPath + land.LandDoc4);
			}
		}

		private void btnOpenDoc5_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(land.LandDoc5))
			{
				Process.Start(docPath + land.LandDoc5);
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			using (var db = new LandxEntities())
			{
				land = db.Lands.Find(land.Id);
				if (doc1changed)
				{
					if (string.IsNullOrWhiteSpace(txtDocument1Name.Text) && lblDocument1.Tag == null)
					{

					}
					else if (string.IsNullOrWhiteSpace(txtDocument1Name.Text) && lblDocument1.Tag != null)
					{
						MessageBox.Show("Please enter the TYPE for Document 1.");
						return;
					}
					else if (!string.IsNullOrWhiteSpace(txtDocument1Name.Text) && lblDocument1.Tag == null)
					{
						MessageBox.Show("Please select the FILE for Document 1.");
						return;
					}
					else
					{
						string ext = lblDocument1.Tag.ToString().Split('.').Last();
						string ddate = DateTime.Now.ToShortDateString().Replace("/", "") + DateTime.Now.ToShortTimeString().Replace(":", "").Replace(" ", "");
						string newFileName = txtDocument1Name.Text.Trim() + "_" + ddate + "." + ext;
						File.Copy(lblDocument1.Tag.ToString(), docPath + newFileName);

						land.LandDoc1 = newFileName;
					}
				}


				if (doc2changed)
				{
					if (string.IsNullOrWhiteSpace(txtDocument2Name.Text) && lblDocument2.Tag == null)
					{

					}
					else if (string.IsNullOrWhiteSpace(txtDocument2Name.Text) && lblDocument2.Tag != null)
					{
						MessageBox.Show("Please enter the TYPE for Document 2.");
						return;
					}
					else if (!string.IsNullOrWhiteSpace(txtDocument2Name.Text) && lblDocument2.Tag == null)
					{
						MessageBox.Show("Please select the FILE for Document 2.");
						return;
					}
					else
					{
						string ext = lblDocument2.Tag.ToString().Split('.').Last();
						string ddate = DateTime.Now.ToShortDateString().Replace("/", "") + DateTime.Now.ToShortTimeString().Replace(":", "").Replace(" ", "");
						string newFileName = txtDocument2Name.Text.Trim() + "_" + ddate + "." + ext;
						File.Copy(lblDocument2.Tag.ToString(), docPath + newFileName);

						land.LandDoc2 = newFileName;
					}
				}


				if (doc3changed)
				{
					if (string.IsNullOrWhiteSpace(txtDocument3Name.Text) && lblDocument3.Tag == null)
					{

					}
					else if (string.IsNullOrWhiteSpace(txtDocument3Name.Text) && lblDocument3.Tag != null)
					{
						MessageBox.Show("Please enter the TYPE for Document 3.");
						return;
					}
					else if (!string.IsNullOrWhiteSpace(txtDocument3Name.Text) && lblDocument3.Tag == null)
					{
						MessageBox.Show("Please select the FILE for Document 3.");
						return;
					}
					else
					{
						string ext = lblDocument3.Tag.ToString().Split('.').Last();
						string ddate = DateTime.Now.ToShortDateString().Replace("/", "") + DateTime.Now.ToShortTimeString().Replace(":", "").Replace(" ", "");
						string newFileName = txtDocument3Name.Text.Trim() + "_" + ddate + "." + ext;
						File.Copy(lblDocument3.Tag.ToString(), docPath + newFileName);

						land.LandDoc3 = newFileName;
					}
				}


				if (doc4changed)
				{
					if (string.IsNullOrWhiteSpace(txtDocument4Name.Text) && lblDocument4.Tag == null)
					{

					}
					else if (string.IsNullOrWhiteSpace(txtDocument4Name.Text) && lblDocument4.Tag != null)
					{
						MessageBox.Show("Please enter the TYPE for Document 4.");
						return;
					}
					else if (!string.IsNullOrWhiteSpace(txtDocument4Name.Text) && lblDocument4.Tag == null)
					{
						MessageBox.Show("Please select the FILE for Document 4.");
						return;
					}
					else
					{
						string ext = lblDocument4.Tag.ToString().Split('.').Last();
						string ddate = DateTime.Now.ToShortDateString().Replace("/", "") + DateTime.Now.ToShortTimeString().Replace(":", "").Replace(" ", "");
						string newFileName = txtDocument4Name.Text.Trim() + "_" + ddate + "." + ext;
						File.Copy(lblDocument4.Tag.ToString(), docPath + newFileName);

						land.LandDoc4 = newFileName;
					}
				}


				if (doc5changed)
				{
					if (string.IsNullOrWhiteSpace(txtDocument5Name.Text) && lblDocument5.Tag == null)
					{

					}
					else if (string.IsNullOrWhiteSpace(txtDocument5Name.Text) && lblDocument5.Tag != null)
					{
						MessageBox.Show("Please enter the TYPE for Document 5.");
						return;
					}
					else if (!string.IsNullOrWhiteSpace(txtDocument5Name.Text) && lblDocument5.Tag == null)
					{
						MessageBox.Show("Please select the FILE for Document 5.");
						return;
					}
					else
					{
						string ext = lblDocument5.Tag.ToString().Split('.').Last();
						string ddate = DateTime.Now.ToShortDateString().Replace("/", "") + DateTime.Now.ToShortTimeString().Replace(":", "").Replace(" ", "");
						string newFileName = txtDocument5Name.Text.Trim() + "_" + ddate + "." + ext;
						File.Copy(lblDocument5.Tag.ToString(), docPath + newFileName, true);

						land.LandDoc5 = newFileName;
					}
				}

				land.LandDescription = txtLandDescription.Text;
				land.LeaseTerm = txtLeaseTerm.Text;
				land.Town = txtTown.Text;

				if (radCustomaryOccupancy.Checked) { land.TypeofOccupancy = "Customary"; }
				else if (radStatutoryOccupancy.Checked) { land.TypeofOccupancy = "Statutory"; }

				land.VendorGuarantorAddress = txtVendorAddress.Text;
				land.VendorGuarantorName = txtVendoName.Text;
				land.VendorGuarantorPhone = txtVenorNumber.Text;

				db.SaveChanges();

				MessageBox.Show("Changes were saved successfully.");
				Close();
			}
			}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
