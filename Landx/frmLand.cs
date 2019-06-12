using DPFP;
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
	public partial class frmLand : MaterialForm, DPFP.Capture.EventHandler
	{
		private DPFP.Capture.Capture Capturer = new DPFP.Capture.Capture();
		private List<Template> LLtemplates = new List<Template>();
		private DPFP.Verification.Verification Verificator;
		
		private delegate void updateForm(string s);
		private delegate void updateFormCtrl(Boolean s);
		private Person Dlandlord = new Person();
		FileInfo[] direc;

		string LLFPpath = Application.StartupPath + "\\LandLordFP";
		string docPaths = Application.StartupPath + "/documents/";
		int LLId = 0;

		public frmLand()
		{
			InitializeComponent();
		}

		private void frmLand_Load(object sender, EventArgs e)
		{
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
				Primary.Green100, Accent.LightGreen200, TextShade.WHITE);

			if (!Directory.Exists(LLFPpath))
			{                            //check if the fingerprints folder exist for that course
				Directory.CreateDirectory(LLFPpath);                                           //else, create the directory, display messagebox n exit.
				MessageBox.Show("No Landlord in the database. Add Landlord first.");
				return;
			}

			DirectoryInfo dir = new DirectoryInfo(LLFPpath);
			direc = dir.GetFiles("*fpt");

			if (direc.Length <1)
			{
				MessageBox.Show("No Landlord in the database. Add Landlord first.");
				return;
			}

			foreach (var file in direc)
			{
				using (FileStream f = file.OpenRead())
				{
					Template fpt = new Template(f);
					LLtemplates.Add(fpt);
				}
			}

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
			this.Invoke(new Function(delegate ()
			{
				lblStatus.Text = status;
			}));
		}

		protected void SetPrompt(string prompt)
		{
			this.Invoke(new Function(delegate ()
			{
				lblStatus.Text = prompt;
			}));
		}
		protected void MakeReport(string message)
		{
			this.Invoke(new Function(delegate ()
			{
				lstFPstatus.Items.Add(message);
				lstFPstatus.TopIndex = lstFPstatus.Items.Count - 1;
			}));
		}

		private void DrawPicture(Bitmap bitmap)
		{
			this.Invoke(new Function(delegate ()
			{
				picFp.Image = new Bitmap(bitmap, picFp.Size);   // fit the image into the picture box
			}));
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
					foreach (var llt in LLtemplates)
					{
						
						Verificator.Verify(features, llt, ref result);

						if (result.Verified)
						{
							found = true;
							LLId = Convert.ToInt32(direc[index].ToString().Split('.')[0]);
							using (var db = new LandxEntities())
							{
								Dlandlord = db.People.Find(LLId);
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
			this.Invoke(new Function(delegate ()
			{
				lblDisplay.Text = msg;
			}));
		}

		protected void enableNextFP()
		{
			this.Invoke(new Function(delegate ()
			{
				btnNextFP.Enabled = true;
			}));
		}

		//private void UpdateStatus()
		//{
		//	// Show number of samples needed.
		//	SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
		//}


		#endregion

		private void btnNextFP_Click(object sender, EventArgs e)
		{
			Stop();
			panelAnim.HideSync(panFprint);
			panelAnim.ShowSync(panLand);
		}

		private void btnDocument1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument1.Tag = dlgDocs.FileName;
				lblDocument1.Text = dlgDocs.SafeFileName;
			}
		}

		private void btnDocument2_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument2.Tag = dlgDocs.FileName;
				lblDocument2.Text = dlgDocs.SafeFileName;
			}
		}

		private void btnDocument3_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument3.Tag = dlgDocs.FileName;
				lblDocument3.Text = dlgDocs.SafeFileName;
			}
		}

		private void btnDocument4_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument4.Tag = dlgDocs.FileName;
				lblDocument4.Text = dlgDocs.SafeFileName;
			}
		}

		private void btnDocument5_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				lblDocument5.Tag = dlgDocs.FileName;
				lblDocument5.Text = dlgDocs.SafeFileName;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (btnSelectLand.Text.ToUpper() != "SELECTED")
			{
				MessageBox.Show("Select Land from the Map.");
				return;
			}

			if (!Directory.Exists(docPaths))
			{
				Directory.CreateDirectory(docPaths);
			}

			Models.Land land = new Models.Land();


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
				File.Copy(lblDocument1.Tag.ToString(), docPaths + newFileName, true);

				land.LandDoc1 = newFileName;
			}

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
				File.Copy(lblDocument2.Tag.ToString(), docPaths + newFileName, true);

				land.LandDoc2 = newFileName;
			}

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
				File.Copy(lblDocument3.Tag.ToString(), docPaths + newFileName,true);

				land.LandDoc3 = newFileName;
			}

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
				File.Copy(lblDocument4.Tag.ToString(), docPaths+ newFileName, true);

				land.LandDoc4 = newFileName;
			}

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
				File.Copy(lblDocument5.Tag.ToString(), docPaths + newFileName, true);

				land.LandDoc5 = newFileName;
			}


			land.Approved = false;
			land.LandDescription = txtLandDescription.Text;
			land.LeaseTerm = txtLeaseTerm.Text;
			land.Town = txtTown.Text;

			if (radCustomaryOccupancy.Checked) { land.TypeofOccupancy = "Customary"; }
			else if (radStatutoryOccupancy.Checked) { land.TypeofOccupancy = "Statutory"; }

			land.VendorGuarantorAddress = txtVendorAddress.Text;
			land.VendorGuarantorName = txtVendoName.Text;
			land.VendorGuarantorPhone = txtVenorNumber.Text;
			land.LandIndex = (int)btnSelectLand.Tag;

			using (LandxEntities db = new LandxEntities())
			{
				land.PersonId = LLId;
				land = db.Lands.Add(land);
				db.SaveChanges();

				MessageBox.Show(string.Format("Your application was sent successfully. \n The Land ID is land{0}.", land.Id.ToString("d4")));
			}
		}

		private void btnCancelfp_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSelectLand_Click(object sender, EventArgs e)
		{
			ucMap1.Mode = "select";
			ucMap1.Visible = true;
			ucMap1.SelectedLand = -1;
			ucMap1.BringToFront();
		}

		private void ucMap1_VisibleChanged(object sender, EventArgs e)
		{
			if (ucMap1.Mode == "select" && !ucMap1.Visible)
			{
				btnSelectLand.Text = "selected";
				btnSelectLand.Enabled = false;
				btnSelectLand.Tag = ucMap1.SelectedLand;
			}
		}
	}
}
