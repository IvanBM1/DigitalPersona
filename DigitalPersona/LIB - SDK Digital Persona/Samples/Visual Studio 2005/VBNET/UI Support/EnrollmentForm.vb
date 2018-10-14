Public Class EnrollmentForm

    Public Data As AppData

	Sub New(ByVal data As AppData)
		InitializeComponent()
		Me.Data = data
		ExchangeData(False)
		AddHandler Data.OnChange, AddressOf OnDataChange
	End Sub

	Private Sub OnDataChange()
		ExchangeData(False)
	End Sub

	Public Sub ExchangeData(ByVal read As Boolean)
		If (read) Then
			Data.EnrolledFingersMask = EnrollmentControl.EnrolledFingerMask
			Data.MaxEnrollFingerCount = EnrollmentControl.MaxEnrollFingerCount
			Data.Update()
		Else
			EnrollmentControl.EnrolledFingerMask = Data.EnrolledFingersMask
			EnrollmentControl.MaxEnrollFingerCount = Data.MaxEnrollFingerCount
		End If
	End Sub

    Sub EnrollmentControl_OnEnroll(ByVal Control As Object, ByVal Finger As Integer, ByVal Template As DPFP.Template, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles EnrollmentControl.OnEnroll
        If (Data.IsEventHandlerSucceeds) Then
            Data.Templates(Finger - 1) = Template
            ExchangeData(True)
            ListEvents.Items.Insert(0, String.Format("OnEnroll: finger {0}", Finger))
        Else
            EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
        End If
    End Sub

    Sub EnrollmentControl_OnDelete(ByVal Control As Object, ByVal Finger As Integer, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles EnrollmentControl.OnDelete
        If (Data.IsEventHandlerSucceeds) Then
            Data.Templates(Finger - 1) = Nothing
            ExchangeData(True)
            ListEvents.Items.Insert(0, String.Format("OnDelete: finger {0}", Finger))
        Else
            EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
        End If
    End Sub

    Private Sub EnrollmentControl_OnCancelEnroll(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnCancelEnroll
        ListEvents.Items.Insert(0, String.Format("OnCancelEnroll: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnComplete(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnComplete
        ListEvents.Items.Insert(0, String.Format("OnComplete: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnFingerRemove(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnFingerRemove
        ListEvents.Items.Insert(0, String.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnFingerTouch(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnFingerTouch
        ListEvents.Items.Insert(0, String.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnReaderConnect(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnReaderConnect
        ListEvents.Items.Insert(0, String.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnReaderDisconnect(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnReaderDisconnect
        ListEvents.Items.Insert(0, String.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnSampleQuality(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Handles EnrollmentControl.OnSampleQuality
        ListEvents.Items.Insert(0, String.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback))
    End Sub

    Private Sub EnrollmentControl_OnStartEnroll(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnStartEnroll
        ListEvents.Items.Insert(0, String.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListEvents.Items.Clear()
    End Sub
End Class