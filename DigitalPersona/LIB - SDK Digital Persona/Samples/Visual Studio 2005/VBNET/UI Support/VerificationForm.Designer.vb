<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificationForm
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
		Dim lblPrompt As System.Windows.Forms.Label
		Dim CloseButton As System.Windows.Forms.Button
		Me.VerificationControl = New DPFP.Gui.Verification.VerificationControl
		lblPrompt = New System.Windows.Forms.Label
		CloseButton = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'lblPrompt
		'
		lblPrompt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		lblPrompt.Location = New System.Drawing.Point(67, 17)
		lblPrompt.Name = "lblPrompt"
		lblPrompt.Size = New System.Drawing.Size(233, 50)
		lblPrompt.TabIndex = 5
		lblPrompt.Text = "To verify your identity, touch fingerprint reader with any enrolled finger."
		'
		'CloseButton
		'
		CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK
		CloseButton.Location = New System.Drawing.Point(225, 70)
		CloseButton.Name = "CloseButton"
		CloseButton.Size = New System.Drawing.Size(75, 23)
		CloseButton.TabIndex = 4
		CloseButton.Text = "Close"
		CloseButton.UseVisualStyleBackColor = True
		'
		'VerificationControl
		'
		Me.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.VerificationControl.Location = New System.Drawing.Point(13, 17)
		Me.VerificationControl.Name = "VerificationControl"
		Me.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
		Me.VerificationControl.Size = New System.Drawing.Size(48, 47)
		Me.VerificationControl.TabIndex = 6
		'
		'VerificationForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(312, 105)
		Me.Controls.Add(Me.VerificationControl)
		Me.Controls.Add(lblPrompt)
		Me.Controls.Add(CloseButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "VerificationForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Verify Your Identity"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents VerificationControl As DPFP.Gui.Verification.VerificationControl
End Class
