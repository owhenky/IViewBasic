Public Class URL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles openbtn.Click
        Try
            With IViewBasicApp.IViewerBox
                .Load(URLTextB.Text)
                .Text = "IViewBasic - " & URLTextB.Text
            End With
            IViewBasicApp.namef.Text = "Name: " & "URL Image, can't check the name"
            IViewBasicApp.pathtxt.Text = URLTextB.Text
            Dev.ResTxt.Text = "Image Viewer is " & IViewBasicApp.IViewerBox.Width & "x" & IViewBasicApp.IViewerBox.Height
            IViewBasicApp.IViewerBox.Location = New Point(0, 0)
            IViewBasicApp.IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
            Close()
            IViewBasicApp.SaveToolStripMenuItem.Enabled = True
            IViewBasicApp.IViewerBox.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Close()
    End Sub

    Private Sub URL_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IViewBasicApp.Enabled = True
    End Sub
End Class