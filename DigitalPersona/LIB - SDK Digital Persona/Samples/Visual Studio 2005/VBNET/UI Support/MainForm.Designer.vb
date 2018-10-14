<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim QuitButton As System.Windows.Forms.Button
        Dim gbEnrollment As System.Windows.Forms.GroupBox
        Dim gbEventHandlerStatus As System.Windows.Forms.GroupBox
        Dim lblMaxFingers As System.Windows.Forms.Label
        Dim lblMask As System.Windows.Forms.Label
        Dim gbVerification As System.Windows.Forms.GroupBox
        Dim gbReturnValues As System.Windows.Forms.GroupBox
        Dim lblFalseAcceptRate As System.Windows.Forms.Label
        Me.MaxFingers = New System.Windows.Forms.NumericUpDown
        Me.Mask = New System.Windows.Forms.NumericUpDown
        Me.EnrollButton = New System.Windows.Forms.Button
        Me.IsFailure = New System.Windows.Forms.RadioButton
        Me.IsSuccess = New System.Windows.Forms.RadioButton
        Me.VerifyButton = New System.Windows.Forms.Button
        Me.FalseAcceptRate = New System.Windows.Forms.TextBox
        Me.IsFeatureSetMatched = New System.Windows.Forms.CheckBox
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        QuitButton = New System.Windows.Forms.Button
        gbEnrollment = New System.Windows.Forms.GroupBox
        gbEventHandlerStatus = New System.Windows.Forms.GroupBox
        lblMaxFingers = New System.Windows.Forms.Label
        lblMask = New System.Windows.Forms.Label
        gbVerification = New System.Windows.Forms.GroupBox
        gbReturnValues = New System.Windows.Forms.GroupBox
        lblFalseAcceptRate = New System.Windows.Forms.Label
        gbEnrollment.SuspendLayout()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).BeginInit()
        gbEventHandlerStatus.SuspendLayout()
        gbVerification.SuspendLayout()
        gbReturnValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        QuitButton.Location = New System.Drawing.Point(199, 443)
        QuitButton.Name = "QuitButton"
        QuitButton.Size = New System.Drawing.Size(75, 23)
        QuitButton.TabIndex = 2
        QuitButton.Text = "Quit"
        Me.ToolTips.SetToolTip(QuitButton, "Close the sample application")
        QuitButton.UseVisualStyleBackColor = True
        AddHandler QuitButton.Click, AddressOf Me.QuitButton_Click
        '
        'gbEnrollment
        '
        gbEnrollment.Controls.Add(Me.MaxFingers)
        gbEnrollment.Controls.Add(Me.Mask)
        gbEnrollment.Controls.Add(Me.EnrollButton)
        gbEnrollment.Controls.Add(gbEventHandlerStatus)
        gbEnrollment.Controls.Add(lblMaxFingers)
        gbEnrollment.Controls.Add(lblMask)
        gbEnrollment.Location = New System.Drawing.Point(12, 11)
        gbEnrollment.Name = "gbEnrollment"
        gbEnrollment.Size = New System.Drawing.Size(266, 201)
        gbEnrollment.TabIndex = 0
        gbEnrollment.TabStop = False
        gbEnrollment.Text = "Enrollment"
        '
        'MaxFingers
        '
        Me.MaxFingers.Location = New System.Drawing.Point(160, 52)
        Me.MaxFingers.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Name = "MaxFingers"
        Me.MaxFingers.Size = New System.Drawing.Size(94, 20)
        Me.MaxFingers.TabIndex = 3
        Me.ToolTips.SetToolTip(Me.MaxFingers, "Enter a number from 1 to 10")
        Me.MaxFingers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Mask
        '
        Me.Mask.Location = New System.Drawing.Point(160, 26)
        Me.Mask.Maximum = New Decimal(New Integer() {1023, 0, 0, 0})
        Me.Mask.Name = "Mask"
        Me.Mask.Size = New System.Drawing.Size(94, 20)
        Me.Mask.TabIndex = 1
        Me.ToolTips.SetToolTip(Me.Mask, "Enter a number from 0 to 1023")
        '
        'EnrollButton
        '
        Me.EnrollButton.Location = New System.Drawing.Point(73, 162)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(107, 23)
        Me.EnrollButton.TabIndex = 5
        Me.EnrollButton.Text = "Enroll Fingerprints"
        Me.ToolTips.SetToolTip(Me.EnrollButton, "Start fingerprint enrollment")
        Me.EnrollButton.UseVisualStyleBackColor = True
        '
        'gbEventHandlerStatus
        '
        gbEventHandlerStatus.Controls.Add(Me.IsFailure)
        gbEventHandlerStatus.Controls.Add(Me.IsSuccess)
        gbEventHandlerStatus.Location = New System.Drawing.Point(9, 79)
        gbEventHandlerStatus.Name = "gbEventHandlerStatus"
        gbEventHandlerStatus.Size = New System.Drawing.Size(251, 60)
        gbEventHandlerStatus.TabIndex = 4
        gbEventHandlerStatus.TabStop = False
        gbEventHandlerStatus.Text = "Event handler status"
        '
        'IsFailure
        '
        Me.IsFailure.AutoSize = True
        Me.IsFailure.Location = New System.Drawing.Point(151, 29)
        Me.IsFailure.Name = "IsFailure"
        Me.IsFailure.Size = New System.Drawing.Size(56, 17)
        Me.IsFailure.TabIndex = 1
        Me.IsFailure.TabStop = True
        Me.IsFailure.Text = "Failure"
        Me.ToolTips.SetToolTip(Me.IsFailure, "Force an enrollment failure")
        Me.IsFailure.UseVisualStyleBackColor = True
        '
        'IsSuccess
        '
        Me.IsSuccess.AutoSize = True
        Me.IsSuccess.Location = New System.Drawing.Point(26, 29)
        Me.IsSuccess.Name = "IsSuccess"
        Me.IsSuccess.Size = New System.Drawing.Size(66, 17)
        Me.IsSuccess.TabIndex = 0
        Me.IsSuccess.TabStop = True
        Me.IsSuccess.Text = "Success"
        Me.ToolTips.SetToolTip(Me.IsSuccess, "Allow a successful enrollment")
        Me.IsSuccess.UseVisualStyleBackColor = True
        '
        'lblMaxFingers
        '
        lblMaxFingers.Location = New System.Drawing.Point(6, 53)
        lblMaxFingers.Name = "lblMaxFingers"
        lblMaxFingers.Size = New System.Drawing.Size(148, 20)
        lblMaxFingers.TabIndex = 2
        lblMaxFingers.Text = "Max. enrolled fingers count"
        lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMask
        '
        lblMask.Location = New System.Drawing.Point(6, 27)
        lblMask.Name = "lblMask"
        lblMask.Size = New System.Drawing.Size(148, 20)
        lblMask.TabIndex = 0
        lblMask.Text = "Fingerprint Mask"
        lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbVerification
        '
        gbVerification.Controls.Add(Me.VerifyButton)
        gbVerification.Controls.Add(gbReturnValues)
        gbVerification.Location = New System.Drawing.Point(12, 218)
        gbVerification.Name = "gbVerification"
        gbVerification.Size = New System.Drawing.Size(266, 205)
        gbVerification.TabIndex = 1
        gbVerification.TabStop = False
        gbVerification.Text = "Verification"
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(73, 161)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(107, 23)
        Me.VerifyButton.TabIndex = 1
        Me.VerifyButton.Text = "Verify Fingerprints"
        Me.ToolTips.SetToolTip(Me.VerifyButton, "Start fingerprint verification")
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'gbReturnValues
        '
        gbReturnValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        gbReturnValues.Controls.Add(Me.FalseAcceptRate)
        gbReturnValues.Controls.Add(lblFalseAcceptRate)
        gbReturnValues.Controls.Add(Me.IsFeatureSetMatched)
        gbReturnValues.Location = New System.Drawing.Point(9, 40)
        gbReturnValues.Name = "gbReturnValues"
        gbReturnValues.Size = New System.Drawing.Size(251, 100)
        gbReturnValues.TabIndex = 0
        gbReturnValues.TabStop = False
        gbReturnValues.Text = "Return values"
        '
        'FalseAcceptRate
        '
        Me.FalseAcceptRate.Location = New System.Drawing.Point(132, 62)
        Me.FalseAcceptRate.Name = "FalseAcceptRate"
        Me.FalseAcceptRate.ReadOnly = True
        Me.FalseAcceptRate.Size = New System.Drawing.Size(113, 20)
        Me.FalseAcceptRate.TabIndex = 2
        Me.ToolTips.SetToolTip(Me.FalseAcceptRate, "Displays the false accept rate (FAR)")
        '
        'lblFalseAcceptRate
        '
        lblFalseAcceptRate.Location = New System.Drawing.Point(6, 62)
        lblFalseAcceptRate.Name = "lblFalseAcceptRate"
        lblFalseAcceptRate.Size = New System.Drawing.Size(120, 20)
        lblFalseAcceptRate.TabIndex = 1
        lblFalseAcceptRate.Text = "False accept rate"
        lblFalseAcceptRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IsFeatureSetMatched
        '
        Me.IsFeatureSetMatched.AutoCheck = False
        Me.IsFeatureSetMatched.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsFeatureSetMatched.Location = New System.Drawing.Point(6, 32)
        Me.IsFeatureSetMatched.Name = "IsFeatureSetMatched"
        Me.IsFeatureSetMatched.Size = New System.Drawing.Size(139, 24)
        Me.IsFeatureSetMatched.TabIndex = 0
        Me.IsFeatureSetMatched.Text = "Feature set matched?"
        Me.ToolTips.SetToolTip(Me.IsFeatureSetMatched, "Displays a match result")
        Me.IsFeatureSetMatched.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = QuitButton
        Me.ClientSize = New System.Drawing.Size(286, 478)
        Me.Controls.Add(QuitButton)
        Me.Controls.Add(gbEnrollment)
        Me.Controls.Add(gbVerification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET UI Demo"
        gbEnrollment.ResumeLayout(False)
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).EndInit()
        gbEventHandlerStatus.ResumeLayout(False)
        gbEventHandlerStatus.PerformLayout()
        gbVerification.ResumeLayout(False)
        gbReturnValues.ResumeLayout(False)
        gbReturnValues.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents EnrollButton As System.Windows.Forms.Button
    Private WithEvents IsFailure As System.Windows.Forms.RadioButton
    Private WithEvents IsSuccess As System.Windows.Forms.RadioButton
	Private WithEvents VerifyButton As System.Windows.Forms.Button
    Private WithEvents FalseAcceptRate As System.Windows.Forms.TextBox
	Private WithEvents IsFeatureSetMatched As System.Windows.Forms.CheckBox
	Friend WithEvents MaxFingers As System.Windows.Forms.NumericUpDown
	Friend WithEvents Mask As System.Windows.Forms.NumericUpDown
	Friend WithEvents ToolTips As System.Windows.Forms.ToolTip

End Class
