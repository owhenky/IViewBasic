Public Class URL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles openbtn.Click
        Try
            With IViewBasic.IViewerBox
                .Load(URLTextB.Text)
                .Text = "Image Viewer - " & URLTextB.Text
            End With
            Close()
            URLTextB.Text = ""
            IViewBasic.SaveToolStripMenuItem.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Close()
    End Sub
End Class