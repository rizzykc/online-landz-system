using Landx.Models;
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
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.IO;

namespace Landx
{
	public partial class frmNewLandLord : MaterialForm, DPFP.Capture.EventHandler
	{
		private DPFP.Capture.Capture Capturer = new DPFP.Capture.Capture();
		private DPFP.Template NoKTemplate;
		private DPFP.Template LLTemplate;
		private DPFP.Processing.Enrollment Enroller;

		private Emgu.CV.Capture imgCapture;
		private delegate void updateForm(string s);
		private delegate void updateFormCtrl(Boolean s);
		private List<Person> landlords = new List<Person>();
		private Person Dlandlord = new Person();

		string action;
		string LLFPpath = Application.StartupPath + "\\LandLordFP";
		string NoKFPpath = Application.StartupPath + "\\NextOfKinFP";
		public frmNewLandLord()
		{
			InitializeComponent();
		}

		private void frmNewLandLord_Load(object sender, EventArgs e)
		{
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
				Primary.Green100, Accent.LightGreen200, TextShade.WHITE);
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
			ProcessEnrol(Sample);
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
				if (action == "enrolPerson")
				{
					picPersonFP.Image = new Bitmap(bitmap, picPersonFP.Size);   // fit the image into the picture box
				}
				else if (action == "enrolNOK")
				{
					picNoKFP.Image = new Bitmap(bitmap, picNoKFP.Size);   // fit the image into the picture box
				}
			}));
		}
		
		protected void ProcessEnrol(DPFP.Sample Sample)
		{
			// Draw fingerprint sample image.
			DrawPicture(ConvertSampleToBitmap(Sample));

			// Process the sample and create a feature set for the enrollment purpose.
			DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

			// Check quality of the sample and add to enroller if it's good
			if (features != null)
			{
				try
				{
					MakeReport("The fingerprint feature set was created.");
					Enroller.AddFeatures(features);     // Add feature set to template.
				}
				finally
				{
					UpdateStatus();

					// Check if template has been created.
					switch (Enroller.TemplateStatus)
					{
						case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
							OnTemplate(Enroller.Template);
							SetPrompt("Fingerprint registration was successful.");

							Stop();
							break;

						case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
							Enroller.Clear();
							Stop();
							UpdateStatus();
							OnTemplate(null);
							Start();
							break;
					}
				}
			}
		}

		private void OnTemplate(DPFP.Template template)
		{
			this.Invoke(new Function(delegate ()
			{
				if (template != null)
				{
					if (action == "enrolPerson")
					{
						LLTemplate = template;

						btnCapturePersonFP.Enabled = false;
						btnCapturePersonFP.Text = "Captured";
					}
					else if (action == "enrolNOK")
					{
						NoKTemplate = template;

						btnCaptureNokFP.Enabled = false;
						btnCaptureNokFP.Text = "Captured";
					}
					MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
				}
				else MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
			}));
		}
		private void UpdateStatus()
		{
			// Show number of samples needed.
			SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
		}

		#endregion


		private void btnCapturePersonFP_Click(object sender, EventArgs e)
		{
			Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
			lstFPstatus.Items.Clear();
			action = "enrolPerson";
			UpdateStatus();
			Init();
			Start();
		}

		private void btnCaptureNokFP_Click(object sender, EventArgs e)
		{
			Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
			lstFPstatus.Items.Clear();
			action = "enrolNOK";
			UpdateStatus();
			Init();
			Start();
		}

		private void btnUploadPic_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlgDocs = new OpenFileDialog();

			dlgDocs.Filter = "Images|*.jpg;*.png";

			if (dlgDocs.ShowDialog() == DialogResult.OK)
			{
				picProfile.ImageLocation = dlgDocs.FileName;
			}
			
		}

		private void btnWebcam_Click(object sender, EventArgs e)
		{
			if (btnWebcam.Text == "WEBCAM")
			{
				Cursor = Cursors.WaitCursor;
				imgCapture = new Emgu.CV.Capture();
				timImage.Enabled = true;
				btnWebcam.Text = "CAPTURE";
				Cursor = Cursors.Arrow;
			}
			else
			{
				timImage.Enabled = false;
				btnWebcam.Text = "WEBCAM";
				imgCapture.Dispose();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (LLTemplate == null)
			{
				MessageBox.Show("Enrol the Landlord's Fingerprint.");
				return;
			}

			if (NoKTemplate == null)
			{
				MessageBox.Show("Enrol the Next of Kin's Fingerprint.");
				return;
			}

			if (picProfile.Image == null)
			{
				MessageBox.Show("Select a Profile Picture.");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtFullName.Text))
			{
				MessageBox.Show("The Fullname Field is Compulsory.");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtNokName.Text))
			{
				MessageBox.Show("The Next of Kin's Name Field is Compulsory.");
				return;
			}

			if (!Directory.Exists(LLFPpath))
			{
				Directory.CreateDirectory(LLFPpath);
			}

			if (!Directory.Exists(NoKFPpath))
			{
				Directory.CreateDirectory(NoKFPpath);
			}
			
			using (var db = new LandxEntities())
			{
				
				Person person = new Person();


				person.Address = txtAddress.Text;
				person.ApplicantsFullname = txtFullName.Text;
				person.DoB = txtDob.Text;
				person.Email = txtEmail.Text;
				person.LGA = txtLGA.Text;
				person.Nationality = txtNationality.Text;
				person.NoKName = txtNokName.Text;
				person.NoKPhone = txtNokPhone.Text;
				person.Occupation = txtOccupation.Text;
				person.PhoneNumber = txtPhone.Text;
				person.TypeofCompany = txtCompanytype.Text;

				using (MemoryStream ms = new MemoryStream())
				{
					picProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					person.Pic = ms.ToArray();
				}

				person = db.People.Add(person);

				db.SaveChanges();


				using (FileStream fs = new FileStream(LLFPpath + "/" + person.Id.ToString() + ".fpt", FileMode.Create, FileAccess.Write))
				{
					LLTemplate.Serialize(fs);
				}
				using (FileStream fs = new FileStream(NoKFPpath + "/" + person.Id.ToString() + ".fpt", FileMode.Create, FileAccess.Write))
				{
					NoKTemplate.Serialize(fs);
				}

				MessageBox.Show(string.Format("Landlord was Added Successfully.\n The Person ID is psn{0}", person.Id.ToString("d4")));

			}
		}

		private void timImage_Tick(object sender, EventArgs e)
		{
			Emgu.CV.Image<Bgr, Byte> photo = imgCapture.QueryFrame();
			picProfile.Image = photo.ToBitmap();
		}
	}
}
