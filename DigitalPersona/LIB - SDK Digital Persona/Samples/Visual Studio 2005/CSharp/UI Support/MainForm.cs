using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support {

  // The main application form.
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      Data = new AppData();								// Create the application data object
      Data.OnChange += delegate { ExchangeData(false); };	// Track data changes to keep the form synchronized
      Enroller = new EnrollmentForm(Data);
      Verifier = new VerificationForm(Data);
      ExchangeData(false);								// fill data with default values from controls
    }

    // Simple dialog data exchange (DDX) implementation.
    private void ExchangeData(bool read) {
      if (read) {	// read values from the form's controls to the data object
        Data.EnrolledFingersMask = Mask.Text.Length == 0 ? 0 : (int)Mask.Value;
        Data.MaxEnrollFingerCount = MaxFingers.Text.Length == 0 ? 0 : (int)MaxFingers.Value;
        Data.IsEventHandlerSucceeds = IsSuccess.Checked;
        Data.Update();
      } else {	// read valuse from the data object to the form's controls
        Mask.Value = Data.EnrolledFingersMask;
        MaxFingers.Value = Data.MaxEnrollFingerCount;
        IsSuccess.Checked = Data.IsEventHandlerSucceeds;
        IsFailure.Checked = !IsSuccess.Checked;
        IsFeatureSetMatched.Checked = Data.IsFeatureSetMatched;
        FalseAcceptRate.Text = Data.FalseAcceptRate.ToString();
        VerifyButton.Enabled = Data.EnrolledFingersMask > 0;
      }
    }

    private void EnrollButton_Click(object sender, EventArgs e) {
      ExchangeData(true);		// transfer values from the main form to the data object
      Enroller.ShowDialog();	// process enrollment
    }

    private void VerifyButton_Click(object sender, EventArgs e) {
      ExchangeData(true);		// transfer values from the main form to the data object
      Verifier.ShowDialog();	// process verification
    }

    private void QuitButton_Click(object sender, EventArgs e) {
      this.Close();
    }

    private AppData Data;					// keeps application-wide data
    private EnrollmentForm Enroller;
    private VerificationForm Verifier;

  }
}