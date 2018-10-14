Public Class VerificationForm

    Public Data As AppData

	Sub New(ByVal data As AppData)
		InitializeComponent()
		Me.Data = data
	End Sub

	Sub OnComplete(ByVal Control As Object, ByVal FeatureSet As DPFP.FeatureSet, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles VerificationControl.OnComplete
		Dim ver As New DPFP.Verification.Verification()
		Dim res As New DPFP.Verification.Verification.Result()

		For Each template As DPFP.Template In Data.Templates	' Compare feature set with all stored templates:
			If Not template Is Nothing Then						'   Get template from storage.
				ver.Verify(FeatureSet, template, res)			'   Compare feature set with particular template.
				Data.IsFeatureSetMatched = res.Verified			'   Check the result of the comparison
				Data.FalseAcceptRate = res.FARAchieved			'   Determine the current False Accept Rate
				If res.Verified Then
					EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Success
					Exit For ' success
				End If
			End If
		Next
		If Not res.Verified Then EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
		Data.Update()
	End Sub

End Class