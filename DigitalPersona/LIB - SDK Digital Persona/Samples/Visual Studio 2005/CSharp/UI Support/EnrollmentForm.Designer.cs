namespace UI_Support
{
    partial class EnrollmentForm
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
            System.Windows.Forms.Button CloseButton;
            this.EnrollmentControl = new DPFP.Gui.Enrollment.EnrollmentControl();
            this.GroupEvents = new System.Windows.Forms.GroupBox();
            this.ListEvents = new System.Windows.Forms.ListBox();
            CloseButton = new System.Windows.Forms.Button();
            this.GroupEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            CloseButton.Location = new System.Drawing.Point(410, 474);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(75, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // EnrollmentControl
            // 
            this.EnrollmentControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnrollmentControl.EnrolledFingerMask = 0;
            this.EnrollmentControl.Location = new System.Drawing.Point(1, -3);
            this.EnrollmentControl.MaxEnrollFingerCount = 10;
            this.EnrollmentControl.Name = "EnrollmentControl";
            this.EnrollmentControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.EnrollmentControl.Size = new System.Drawing.Size(492, 314);
            this.EnrollmentControl.TabIndex = 2;
            this.EnrollmentControl.OnDelete += new DPFP.Gui.Enrollment.EnrollmentControl._OnDelete(this.EnrollmentControl_OnDelete);
            this.EnrollmentControl.OnSampleQuality += new DPFP.Gui.Enrollment.EnrollmentControl._OnSampleQuality(this.EnrollmentControl_OnSampleQuality);
            this.EnrollmentControl.OnComplete += new DPFP.Gui.Enrollment.EnrollmentControl._OnComplete(this.EnrollmentControl_OnComplete);
            this.EnrollmentControl.OnFingerRemove += new DPFP.Gui.Enrollment.EnrollmentControl._OnFingerRemove(this.EnrollmentControl_OnFingerRemove);
            this.EnrollmentControl.OnReaderConnect += new DPFP.Gui.Enrollment.EnrollmentControl._OnReaderConnect(this.EnrollmentControl_OnReaderConnect);
            this.EnrollmentControl.OnStartEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnStartEnroll(this.EnrollmentControl_OnStartEnroll);
            this.EnrollmentControl.OnEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnEnroll(this.EnrollmentControl_OnEnroll);
            this.EnrollmentControl.OnFingerTouch += new DPFP.Gui.Enrollment.EnrollmentControl._OnFingerTouch(this.EnrollmentControl_OnFingerTouch);
            this.EnrollmentControl.OnReaderDisconnect += new DPFP.Gui.Enrollment.EnrollmentControl._OnReaderDisconnect(this.EnrollmentControl_OnReaderDisconnect);
            this.EnrollmentControl.OnCancelEnroll += new DPFP.Gui.Enrollment.EnrollmentControl._OnCancelEnroll(this.EnrollmentControl_OnCancelEnroll);
            // 
            // GroupEvents
            // 
            this.GroupEvents.Controls.Add(this.ListEvents);
            this.GroupEvents.Location = new System.Drawing.Point(12, 311);
            this.GroupEvents.Name = "GroupEvents";
            this.GroupEvents.Size = new System.Drawing.Size(473, 146);
            this.GroupEvents.TabIndex = 3;
            this.GroupEvents.TabStop = false;
            this.GroupEvents.Text = "Events";
            // 
            // ListEvents
            // 
            this.ListEvents.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.Location = new System.Drawing.Point(16, 19);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(440, 108);
            this.ListEvents.TabIndex = 0;
            // 
            // EnrollmentForm
            // 
            this.AcceptButton = CloseButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = CloseButton;
            this.ClientSize = new System.Drawing.Size(497, 509);
            this.Controls.Add(this.GroupEvents);
            this.Controls.Add(CloseButton);
            this.Controls.Add(this.EnrollmentControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fingerprint Enrollment";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            this.GroupEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DPFP.Gui.Enrollment.EnrollmentControl EnrollmentControl;
        private System.Windows.Forms.GroupBox GroupEvents;
        private System.Windows.Forms.ListBox ListEvents;
    }
}