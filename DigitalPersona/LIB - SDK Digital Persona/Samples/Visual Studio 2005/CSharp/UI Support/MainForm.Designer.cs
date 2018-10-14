namespace UI_Support
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox gbEnrollment;
            System.Windows.Forms.GroupBox gbEventHandlerStatus;
            System.Windows.Forms.Label lblMaxFingers;
            System.Windows.Forms.Label lblMask;
            System.Windows.Forms.GroupBox gbVerification;
            System.Windows.Forms.GroupBox gbReturnValues;
            System.Windows.Forms.Label lblFalseAcceptRate;
            System.Windows.Forms.Button QuitButton;
            this.MaxFingers = new System.Windows.Forms.NumericUpDown();
            this.Mask = new System.Windows.Forms.NumericUpDown();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.IsFailure = new System.Windows.Forms.RadioButton();
            this.IsSuccess = new System.Windows.Forms.RadioButton();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.FalseAcceptRate = new System.Windows.Forms.TextBox();
            this.IsFeatureSetMatched = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            gbEnrollment = new System.Windows.Forms.GroupBox();
            gbEventHandlerStatus = new System.Windows.Forms.GroupBox();
            lblMaxFingers = new System.Windows.Forms.Label();
            lblMask = new System.Windows.Forms.Label();
            gbVerification = new System.Windows.Forms.GroupBox();
            gbReturnValues = new System.Windows.Forms.GroupBox();
            lblFalseAcceptRate = new System.Windows.Forms.Label();
            QuitButton = new System.Windows.Forms.Button();
            gbEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFingers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mask)).BeginInit();
            gbEventHandlerStatus.SuspendLayout();
            gbVerification.SuspendLayout();
            gbReturnValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEnrollment
            // 
            gbEnrollment.Controls.Add(this.MaxFingers);
            gbEnrollment.Controls.Add(this.Mask);
            gbEnrollment.Controls.Add(this.EnrollButton);
            gbEnrollment.Controls.Add(gbEventHandlerStatus);
            gbEnrollment.Controls.Add(lblMaxFingers);
            gbEnrollment.Controls.Add(lblMask);
            gbEnrollment.Location = new System.Drawing.Point(12, 12);
            gbEnrollment.Name = "gbEnrollment";
            gbEnrollment.Size = new System.Drawing.Size(266, 201);
            gbEnrollment.TabIndex = 0;
            gbEnrollment.TabStop = false;
            gbEnrollment.Text = "Enrollment";
            // 
            // MaxFingers
            // 
            this.MaxFingers.Location = new System.Drawing.Point(160, 52);
            this.MaxFingers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxFingers.Name = "MaxFingers";
            this.MaxFingers.Size = new System.Drawing.Size(94, 20);
            this.MaxFingers.TabIndex = 3;
            this.ToolTip.SetToolTip(this.MaxFingers, "Enter a number from 1 to 10");
            this.MaxFingers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Mask
            // 
            this.Mask.Location = new System.Drawing.Point(160, 27);
            this.Mask.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(94, 20);
            this.Mask.TabIndex = 1;
            this.ToolTip.SetToolTip(this.Mask, "Enter a number from 0 to 1023");
            // 
            // EnrollButton
            // 
            this.EnrollButton.Location = new System.Drawing.Point(73, 162);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(107, 23);
            this.EnrollButton.TabIndex = 5;
            this.EnrollButton.Text = "Enroll Fingerprints";
            this.ToolTip.SetToolTip(this.EnrollButton, "Start fingerprint enrollment");
            this.EnrollButton.UseVisualStyleBackColor = true;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // gbEventHandlerStatus
            // 
            gbEventHandlerStatus.Controls.Add(this.IsFailure);
            gbEventHandlerStatus.Controls.Add(this.IsSuccess);
            gbEventHandlerStatus.Location = new System.Drawing.Point(9, 79);
            gbEventHandlerStatus.Name = "gbEventHandlerStatus";
            gbEventHandlerStatus.Size = new System.Drawing.Size(251, 60);
            gbEventHandlerStatus.TabIndex = 4;
            gbEventHandlerStatus.TabStop = false;
            gbEventHandlerStatus.Text = "Event handler status";
            // 
            // IsFailure
            // 
            this.IsFailure.AutoSize = true;
            this.IsFailure.Location = new System.Drawing.Point(151, 29);
            this.IsFailure.Name = "IsFailure";
            this.IsFailure.Size = new System.Drawing.Size(56, 17);
            this.IsFailure.TabIndex = 1;
            this.IsFailure.TabStop = true;
            this.IsFailure.Text = "Failure";
            this.ToolTip.SetToolTip(this.IsFailure, "Force an enrollment failure");
            this.IsFailure.UseVisualStyleBackColor = true;
            // 
            // IsSuccess
            // 
            this.IsSuccess.AutoSize = true;
            this.IsSuccess.Location = new System.Drawing.Point(26, 29);
            this.IsSuccess.Name = "IsSuccess";
            this.IsSuccess.Size = new System.Drawing.Size(66, 17);
            this.IsSuccess.TabIndex = 0;
            this.IsSuccess.TabStop = true;
            this.IsSuccess.Text = "Success";
            this.ToolTip.SetToolTip(this.IsSuccess, "Allow a successful enrollment");
            this.IsSuccess.UseVisualStyleBackColor = true;
            // 
            // lblMaxFingers
            // 
            lblMaxFingers.Location = new System.Drawing.Point(6, 53);
            lblMaxFingers.Name = "lblMaxFingers";
            lblMaxFingers.Size = new System.Drawing.Size(148, 20);
            lblMaxFingers.TabIndex = 2;
            lblMaxFingers.Text = "Max. enrolled fingers count";
            lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMask
            // 
            lblMask.Location = new System.Drawing.Point(6, 27);
            lblMask.Name = "lblMask";
            lblMask.Size = new System.Drawing.Size(148, 20);
            lblMask.TabIndex = 0;
            lblMask.Text = "Fingerprint Mask";
            lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbVerification
            // 
            gbVerification.Controls.Add(this.VerifyButton);
            gbVerification.Controls.Add(gbReturnValues);
            gbVerification.Location = new System.Drawing.Point(12, 219);
            gbVerification.Name = "gbVerification";
            gbVerification.Size = new System.Drawing.Size(266, 205);
            gbVerification.TabIndex = 1;
            gbVerification.TabStop = false;
            gbVerification.Text = "Verification";
            // 
            // VerifyButton
            // 
            this.VerifyButton.Location = new System.Drawing.Point(73, 161);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(107, 23);
            this.VerifyButton.TabIndex = 1;
            this.VerifyButton.Text = "Verify Fingerprints";
            this.ToolTip.SetToolTip(this.VerifyButton, "Start fingerprint verification");
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // gbReturnValues
            // 
            gbReturnValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gbReturnValues.Controls.Add(this.FalseAcceptRate);
            gbReturnValues.Controls.Add(lblFalseAcceptRate);
            gbReturnValues.Controls.Add(this.IsFeatureSetMatched);
            gbReturnValues.Location = new System.Drawing.Point(9, 40);
            gbReturnValues.Name = "gbReturnValues";
            gbReturnValues.Size = new System.Drawing.Size(251, 100);
            gbReturnValues.TabIndex = 0;
            gbReturnValues.TabStop = false;
            gbReturnValues.Text = "Return values";
            // 
            // FalseAcceptRate
            // 
            this.FalseAcceptRate.Location = new System.Drawing.Point(132, 62);
            this.FalseAcceptRate.Name = "FalseAcceptRate";
            this.FalseAcceptRate.ReadOnly = true;
            this.FalseAcceptRate.Size = new System.Drawing.Size(113, 20);
            this.FalseAcceptRate.TabIndex = 2;
            this.ToolTip.SetToolTip(this.FalseAcceptRate, "Displays the false accept rate (FAR)");
            // 
            // lblFalseAcceptRate
            // 
            lblFalseAcceptRate.Location = new System.Drawing.Point(6, 62);
            lblFalseAcceptRate.Name = "lblFalseAcceptRate";
            lblFalseAcceptRate.Size = new System.Drawing.Size(120, 20);
            lblFalseAcceptRate.TabIndex = 1;
            lblFalseAcceptRate.Text = "False accept rate";
            lblFalseAcceptRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IsFeatureSetMatched
            // 
            this.IsFeatureSetMatched.AutoCheck = false;
            this.IsFeatureSetMatched.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsFeatureSetMatched.Location = new System.Drawing.Point(6, 32);
            this.IsFeatureSetMatched.Name = "IsFeatureSetMatched";
            this.IsFeatureSetMatched.Size = new System.Drawing.Size(139, 24);
            this.IsFeatureSetMatched.TabIndex = 0;
            this.IsFeatureSetMatched.Text = "Feature set matched?";
            this.ToolTip.SetToolTip(this.IsFeatureSetMatched, "Displays a match result");
            this.IsFeatureSetMatched.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            QuitButton.Location = new System.Drawing.Point(203, 441);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new System.Drawing.Size(75, 23);
            QuitButton.TabIndex = 2;
            QuitButton.Text = "Quit";
            this.ToolTip.SetToolTip(QuitButton, "Close the sample application");
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = QuitButton;
            this.ClientSize = new System.Drawing.Size(287, 476);
            this.Controls.Add(QuitButton);
            this.Controls.Add(gbVerification);
            this.Controls.Add(gbEnrollment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp UI Sample";
            gbEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaxFingers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mask)).EndInit();
            gbEventHandlerStatus.ResumeLayout(false);
            gbEventHandlerStatus.PerformLayout();
            gbVerification.ResumeLayout(false);
            gbReturnValues.ResumeLayout(false);
            gbReturnValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.RadioButton IsFailure;
        private System.Windows.Forms.RadioButton IsSuccess;
        private System.Windows.Forms.TextBox FalseAcceptRate;
        private System.Windows.Forms.CheckBox IsFeatureSetMatched;
		private System.Windows.Forms.Button VerifyButton;
		private System.Windows.Forms.NumericUpDown MaxFingers;
		private System.Windows.Forms.NumericUpDown Mask;
		private System.Windows.Forms.ToolTip ToolTip;
    }
}

