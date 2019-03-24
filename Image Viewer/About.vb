Public Class About
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub GH_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GH.LinkClicked
        Process.Start("https://github.com/owhenky/IViewBasic")
    End Sub

    Private Sub DC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DC.LinkClicked
        Process.Start("https://discord.gg/uMe7S9Q")
    End Sub

    Private Sub About_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IViewBasicApp.Enabled = True
    End Sub
End Class