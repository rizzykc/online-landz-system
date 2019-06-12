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
    public partial class frmTransfer : MaterialForm, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        private List<Template> LLtemplates = new List<Template>();
        private List<Template> Owners = new List<Template>();
        private DPFP.Verification.Verification Verificator;

        private delegate void updateForm(string s);
        private delegate void updateFormCtrl(Boolean s);
        private Person Dlandlord = new Person();
        private Person NewOwner = new Person();
        FileInfo[] direc;

        string LLFPpath = Application.StartupPath + "/LandLordFP";
        string NoKFPpath = Application.StartupPath + "/NextOfKinFP";
        string docPaths = Application.StartupPath + "/documents/";

        string action = "";
        int LLId = 0;

        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700,
                Primary.Green100, Accent.LightGreen200, TextShade.WHITE);

            LLId = (int)((Land)Tag).PersonId;

            FileInfo file = new FileInfo(LLFPpath + "/" + LLId.ToString() + ".fpt");

            using (FileStream f = file.OpenRead())
            {
                Template fpt = new Template(f);
                Owners.Add(fpt);
            }

            file = new FileInfo(NoKFPpath + "/" + LLId.ToString() + ".fpt");

            using (FileStream f = file.OpenRead())
            {
                Template fpt = new Template(f);
                Owners.Add(fpt);
            }
            Verificator = new DPFP.Verification.Verification();
            Init();
            Start();
            action = "verify old owner";
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

            if (action == "verify old owner") { ProcessVerify(Sample, Owners); }
            else { ProcessVerify(Sample, LLtemplates); }
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
                    if (action == "verify old owner") { picFp.Image = new Bitmap(bitmap, picFp.Size); }   // fit the image into the picture box 
                    else { picNewOwnerFP.Image = new Bitmap(bitmap, picFp.Size); }
                }));
            }
            catch (Exception)
            {
            }
        }

        protected void ProcessVerify(DPFP.Sample Sample, List<Template> lt)
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
                    foreach (var llt in lt)
                    {

                        Verificator.Verify(features, llt, ref result);

                        if (result.Verified)
                        {
                            found = true;

                            if (action == "verify old owner")
                            {
                                using (var db = new LandxEntities())
                                {
                                    Dlandlord = db.People.Find(LLId);
                                    displayMsg("Welcome " + Dlandlord.ApplicantsFullname);
                                }
                            }
                            else
                            {
                                LLId = Convert.ToInt32(direc[index].ToString().Split('.')[0]);
                                using (var db = new LandxEntities())
                                {
                                    NewOwner = db.People.Find(LLId);
                                    displayMsg("Welcome " + NewOwner.ApplicantsFullname);
                                }
                            }
                            MakeReport("The fingerprint was VERIFIED.");
                            enableFPBtn();
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
                    if (action == "verify old owner") { lblDisplay.Text = msg; }
                    else { lblMsg.Text = msg; }
                }));
            }
            catch { }
        }

        protected void enableFPBtn()
        {
            try
            {
                this.Invoke(new Function(delegate ()
                {
                    if (action == "verify old owner") { btnNextFP.Enabled = true; }
                    else { btnSave.Enabled = true; }
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

        private void btnNextFP_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DirectoryInfo dir = new DirectoryInfo(LLFPpath);
            direc = dir.GetFiles("*fpt");

            if (direc.Length < 1)
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
            Start();
            action = "verify new owner";

            animPan.HideSync(panFprint);
            animPan.ShowSync(panNew);

            Cursor = Cursors.Arrow;
        }

        private void btnCancelfp_Click(object sender, EventArgs e)
        {
            Stop();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Stop();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult rtn = MessageBox.Show("Are you sure you want to transfer ownership of this Land from " + Dlandlord.ApplicantsFullname + " to " + NewOwner.ApplicantsFullname + "?", "Transfer Ownership", MessageBoxButtons.YesNo);
            if (rtn == DialogResult.Yes)
            {
                Land land = (Land)Tag;

                using (var db = new LandxEntities())
                {
                    land = db.Lands.Find(land.Id);
                    land.PersonId = NewOwner.Id;
                    db.SaveChanges();

                    MessageBox.Show("Ownership of this land has been transfered to " + NewOwner.ApplicantsFullname + ".");

                }
            }
        }

        private void panNew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Capturer==null))
            {
                Stop();
            }
        }
    }
}
