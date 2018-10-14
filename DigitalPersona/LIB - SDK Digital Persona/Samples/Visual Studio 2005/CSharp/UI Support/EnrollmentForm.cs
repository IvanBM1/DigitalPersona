using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support {
  public partial class EnrollmentForm : Form {
    // Constructor
    public EnrollmentForm(AppData data) {
      InitializeComponent();
      Data = data;										// Keep reference to the data
      ExchangeData(true);									// Init data with default control values;
      Data.OnChange += delegate { ExchangeData(false); };	// Track data changes to keep the form synchronized
    }

    // Simple dialog data exchange (DDX) implementation.
    public void ExchangeData(bool read) {
      if (read) {	// read values from the form's controls to the data object
        Data.EnrolledFingersMask = EnrollmentControl.EnrolledFingerMask;
        Data.MaxEnrollFingerCount = EnrollmentControl.MaxEnrollFingerCount;
        Data.Update();
      } else {	// read values from the data object to the form's controls
        EnrollmentControl.EnrolledFingerMask = Data.EnrolledFingersMask;
        EnrollmentControl.MaxEnrollFingerCount = Data.MaxEnrollFingerCount;
      }
    }

    // event handling
    public void EnrollmentControl_OnEnroll(Object Control, int Finger, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus Status) {
      if (Data.IsEventHandlerSucceeds) {
        Data.Templates[Finger - 1] = Template;		    // store a finger template
        ExchangeData(true);								// update other data

        ListEvents.Items.Insert(0, String.Format("OnEnroll: finger {0}", Finger));
      } else
        Status = DPFP.Gui.EventHandlerStatus.Failure;	// force a "failure" status
    }

    public void EnrollmentControl_OnDelete(Object Control, int Finger, ref DPFP.Gui.EventHandlerStatus Status) {
      if (Data.IsEventHandlerSucceeds) {
        Data.Templates[Finger - 1] = null;			    // clear the finger template
        ExchangeData(true);								// update other data

        ListEvents.Items.Insert(0, String.Format("OnDelete: finger {0}", Finger));
      } else
        Status = DPFP.Gui.EventHandlerStatus.Failure;	// force a "failure" status
    }

    private void EnrollmentControl_OnCancelEnroll(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnCancelEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private void EnrollmentControl_OnReaderConnect(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private void EnrollmentControl_OnReaderDisconnect(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private void EnrollmentControl_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private void EnrollmentControl_OnFingerRemove(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private void EnrollmentControl_OnFingerTouch(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private void EnrollmentControl_OnSampleQuality(object Control, string ReaderSerialNumber, int Finger, DPFP.Capture.CaptureFeedback CaptureFeedback) {
      ListEvents.Items.Insert(0, String.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback));
    }

    private void EnrollmentControl_OnComplete(object Control, string ReaderSerialNumber, int Finger) {
      ListEvents.Items.Insert(0, String.Format("OnComplete: {0}, finger {1}", ReaderSerialNumber, Finger));
    }

    private AppData Data;

    private void EnrollmentForm_Load(object sender, EventArgs e) {
      this.ListEvents.Items.Clear();
    }
  }
}