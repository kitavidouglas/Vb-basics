Option Strict On
Option Explicit On

Namespace My

    'NOTE: This file is auto-generated; avoid direct modifications. To edit,
    ' or resolve build errors, access the Project Designer
    ' (navigate to Project Properties or double-click the My Project node in
    ' Solution Explorer), and make adjustments on the Application tab.
    '
    Partial Friend Class MyApplication

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Form1
        End Sub
    End Class
End Namespace
