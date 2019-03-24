Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dflt.Click
        My.Computer.Registry.ClassesRoot.CreateSubKey(".jpg").SetValue("", "Joint Photographic Experts Group", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.ClassesRoot.CreateSubKey("Joint Photographic Experts Group\shell\open\command").SetValue("", Application.ExecutablePath & " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IViewBasicApp.Enabled = True
    End Sub
End Class