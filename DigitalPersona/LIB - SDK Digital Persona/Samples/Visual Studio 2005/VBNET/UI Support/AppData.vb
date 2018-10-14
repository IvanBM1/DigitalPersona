Public Class AppData
	' constants 
	Public Const MaxFingers As Integer = 10
	' members
	Public EnrolledFingersMask As Integer = 0
	Public MaxEnrollFingerCount As Integer = MaxFingers
	Public IsEventHandlerSucceeds As Boolean = True
	Public IsFeatureSetMatched As Boolean = False
	Public FalseAcceptRate As Integer = 0
	Public Templates(MaxFingers - 1) As DPFP.Template

	Public Sub Update()
		RaiseEvent OnChange()
	End Sub
	Public Event OnChange()

End Class
