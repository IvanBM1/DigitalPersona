Public Class MainForm

    Private Data As AppData
    Private Enroller As EnrollmentForm
    Private Verifier As VerificationForm
    Public WithEvents AppData As AppData

	Sub New()
		InitializeComponent()

		Data = New AppData()
		AddHandler Data.OnChange, AddressOf OnDataChange
		Enroller = New EnrollmentForm(Data)
		Verifier = New VerificationForm(Data)
		ExchangeData(False)
	End Sub

	Private Sub OnDataChange()
		ExchangeData(False)
	End Sub

	Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Close()
	End Sub

	Private Sub ExchangeData(ByVal read As Boolean)
		If (read) Then
            If (Mask.Text.Length > 0) Then
                Data.EnrolledFingersMask = Mask.Value
            Else
                Data.EnrolledFingersMask = 0
            End If

            If (MaxFingers.Text.Length > 0) Then
                Data.MaxEnrollFingerCount = MaxFingers.Value
            Else
                Data.MaxEnrollFingerCount = 0
            End If

			Data.IsEventHandlerSucceeds = IsSuccess.Checked
			Data.Update()
		Else
			Mask.Value = Data.EnrolledFingersMask
			MaxFingers.Value = Data.MaxEnrollFingerCount
			IsSuccess.Checked = Data.IsEventHandlerSucceeds
			IsFailure.Checked = Not IsSuccess.Checked
			IsFeatureSetMatched.Checked = Data.IsFeatureSetMatched
			FalseAcceptRate.Text = Data.FalseAcceptRate.ToString()
			VerifyButton.Enabled = Data.EnrolledFingersMask > 0
		End If
	End Sub

	Private Sub EnrollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollButton.Click
		ExchangeData(True)
		Enroller.ShowDialog()
	End Sub

	Private Sub VerifyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyButton.Click
		ExchangeData(True)
		Verifier.ShowDialog()
	End Sub

End Class
