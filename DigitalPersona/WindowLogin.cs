using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DPFP;
using DPFP.Capture;

namespace DigitalPersona
{
    public partial class WindowLogin : Form, DPFP.Capture.EventHandler
    {
        
        private DPFP.Verification.Verification verification;
        private DPFP.Capture.Capture capture;
        private DPFP.Template template;

        private MySqlAdapter mySqlAdapter;

        public WindowLogin()
        {
            InitializeComponent();
        }

        private void WindowLogin_Load(object sender, EventArgs e)
        {
            mySqlAdapter = new MySqlAdapter("localhost", "root", "", "digitalpersona");

            Init();
            InitCapture();
        }
        
        
        public void Init()
        {
            try
            {
                capture = new DPFP.Capture.Capture();

                if (capture != null)
                {
                    capture.EventHandler = this;
                    template = new DPFP.Template();
                    verification = new DPFP.Verification.Verification();
                }
                else
                {
                    MessageBox.Show("ERROR AL INICIAR DIGITAL-PERSONA");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL INICIAR DIGITAL-PERSONA");
                Debug.Write(e);
            }
        }

        public void InitCapture()
        {
            if (capture != null)
            {
                try
                {
                    capture.StartCapture();
                }
                catch (Exception e)
                {
                    Debug.Write(e);
                    MessageBox.Show("ERROR AL INICIAR LA CAPTURA CON DIGITAL-PERSONA");
                }
            }
        }

        public void StopCapture()
        {
            if (capture != null)
            {
                try
                {
                    capture.StopCapture();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR AL DETENER DIGITAL-PERSONA");
                }
            }
        }

        public void SetImagePawprint(DPFP.Sample sample)
        {
            DPFP.Capture.SampleConversion converter = new DPFP.Capture.SampleConversion();
            Bitmap bitMap = null;

            converter.ConvertToPicture(sample, ref bitMap);
            imagePawprint.Image = bitMap;
        }

        public DPFP.FeatureSet CreateFeatureSet(DPFP.Sample sample, DPFP.Processing.DataPurpose purpose)
        {
            DPFP.Processing.FeatureExtraction featureExtraction = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback captureFeedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet featureSet = new DPFP.FeatureSet();

            featureExtraction.CreateFeatureSet(sample, purpose, ref captureFeedback, ref featureSet);

            return (captureFeedback == DPFP.Capture.CaptureFeedback.Good) ? featureSet : null;
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            SetImagePawprint(Sample);
            DPFP.FeatureSet featureSet = CreateFeatureSet(Sample, DPFP.Processing.DataPurpose.Verification);

            if(featureSet != null)
            {
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                List<User> ListUser = mySqlAdapter.GetAllUsers();
                
                ListUser.ForEach(delegate (User user) {

                    MemoryStream ms = new MemoryStream(user.Pawprint);
                    template.DeSerialize(ms.ToArray());

                    verification.Verify(featureSet, template, ref result);
                    if (result.Verified)
                    {
                        MessageBox.Show("Hola: " + user.Name);
                    }
                });
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
        }

        private void WindowLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        private void WindowLogin_Leave(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void WindowLogin_Activated(object sender, EventArgs e)
        {
        }

        private void imagePawprint_Click(object sender, EventArgs e)
        {
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            StopCapture();
            WindowSignUp windowSignUp = new WindowSignUp();
            windowSignUp.Show();

            this.Close();
        }
    }
}
