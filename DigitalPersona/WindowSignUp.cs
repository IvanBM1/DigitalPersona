using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using System.IO;

namespace DigitalPersona
{
    public partial class WindowSignUp : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Processing.Enrollment enrollment;
        private DPFP.Capture.Capture capture;
        private DPFP.Template template;

        private MySqlAdapter mySqlAdaptor;

        public WindowSignUp()
        {
            InitializeComponent();
        }

        private void WindowSignUp_Load(object sender, EventArgs e)
        {
            mySqlAdaptor = new MySqlAdapter("localhost","root","","digitalpersona");

            Init();
            InitCapture();
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (inputName.Text.ToString().Equals(""))
            {
                MessageBox.Show("EL NOMBRE NO DEBE ESTAR VACIO");
                return;
            }

            User user = new User();
            user.Name = inputName.Text.ToString();
            user.Pawprint = template.Bytes;
            user.Pawprint_length = template.Bytes.Length;

            mySqlAdaptor.CreateUser(user);

            MessageBox.Show("USUARIO GUARDADO");
            buttonSave.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            enrollment.Clear();
            StopCapture();
            InitCapture();

            imagePawprint.Image = DigitalPersona.Properties.Resources.pawprint;
            labelCount.Text = "Necesitas pasar el dedo 4 veces";
            inputName.Text = "";

            MessageBox.Show("REGISTRA AL NUEVO USUARIO");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            StopCapture();
            WindowLogin windowLogin = new WindowLogin();
            windowLogin.Show();

            this.Close();
        }

        public void Init()
        {
            try
            {
                capture = new DPFP.Capture.Capture();

                if (capture != null)
                {
                    capture.EventHandler = this;
                    enrollment = new DPFP.Processing.Enrollment();
                }
                else
                {
                    MessageBox.Show("ERROR AL INICIAR DIGITAL-PERSONA");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL INICIAR DIGITAL-PERSONA");
            }
        }

        public void InitCapture()
        {
            if(capture != null)
            {
                try
                {
                    capture.StartCapture();
                }catch(Exception e)
                {
                    MessageBox.Show("ERROR AL INICIAR LA CAPTURA CON DIGITAL-PERSONA");
                }
            }
        }

        public void StopCapture()
        {
            if(capture != null)
            {
                try
                {
                    capture.StopCapture();
                }catch(Exception e)
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


        public void SetFeaturesEnrollment(DPFP.Sample sample)
        {
            DPFP.FeatureSet featureSet = CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Enrollment);
            if( featureSet != null)
            {
                try
                {
                    enrollment.AddFeatures(featureSet);
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR AL EXTRAER LAS CARACTERISTICAS DE LA HUELLA");
                }
                finally
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendFormat("Necesitas pasar el dedo {0} veces", enrollment.FeaturesNeeded);
                    SetLabelCount(stringBuilder.ToString());

                    switch (enrollment.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                                template = enrollment.Template;
                                EnableButtonSave();
                                StopCapture();
                                break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                                enrollment.Clear();
                                StopCapture();
                                InitCapture();
                                break;
                    }
                }
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            SetImagePawprint(Sample);
            SetFeaturesEnrollment(Sample);
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

        /// DELEGADOS - ASEGURA QUE EL CONTEXTO SEA EL DEL HILO PRINCIPAL ///
        delegate void delegateLabelCount(String text);
        private void SetLabelCount(String text)
        {
            if (this.labelCount.InvokeRequired)
            {
                delegateLabelCount deleg = new delegateLabelCount(SetLabelCount);
                this.Invoke(deleg, new Object[] { text });
            }
            else
            {
                this.labelCount.Text = text;
            }
        }

        delegate void delegateButtonEnable();
        private void EnableButtonSave()
        {
            if (this.buttonSave.InvokeRequired)
            {
                delegateButtonEnable deleg = new delegateButtonEnable(EnableButtonSave);
                this.Invoke(deleg, new Object[] { });
            }
            else
            {
                this.buttonSave.Enabled = true;
            }
        }

        private void WindowSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        private void WindowSignUp_Leave(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void WindowSignUp_Activated(object sender, EventArgs e)
        {
        }
    }
}
