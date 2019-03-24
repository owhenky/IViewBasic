Public Class GetStarted
    Private Sub GetStarted_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IViewBasicApp.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GH.LinkClicked
        Process.Start("https://github.com/owhenky/IViewBasic")
    End Sub

    Private Sub DC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DC.LinkClicked
        Process.Start("https://discord.gg/uMe7S9Q")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        URL.Show()
        IViewBasicApp.Enabled = False
        IViewBasicApp.Refresh()
    End Sub

    Private Sub GetStarted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllowDrop = True
        Panel1.AllowDrop = True
        TopMost = True
    End Sub

    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        For Each file In droppedFiles
            Dim filepath As String = GetFilePath(file)
            Dim filename As String = GetFileName(file)
            IViewBasicApp.Text = "IViewBasic - " & (filename) & " (" & (filepath) & ")"
            Dev.ResTxt.Text = "Image Viewer is " & IViewBasicApp.IViewerBox.Width & "x" & IViewBasicApp.IViewerBox.Height
            IViewBasicApp.IViewerBox.Location = New Point(0, 0)
            IViewBasicApp.IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
            IViewBasicApp.IViewerBox.Image = Image.FromFile(file)
            Close()
        Next
    End Sub

    Public Function GetFilePath(path As String)
        Return System.IO.Path.GetFullPath(path)
    End Function

    Public Function GetFileName(path As String)
        Return System.IO.Path.GetFileName(path)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IViewBasicApp.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub OpenFileBtn_Click(sender As Object, e As EventArgs) Handles OpenFileBtn.Click
        Try
            With IViewBasicApp.OpenFileDialog1
                .Title = "Choose an Image..."
                .FileName = "No Image Opened"
                .Filter = "All Files |*.*"
                .ShowDialog()
            End With
            'IViewBasicApp.res.Text = IViewBasicApp.IViewerBox.Height & "x" & IViewBasicApp.IViewerBox.Width
            IViewBasicApp.IViewerBox.Image = System.Drawing.Image.FromFile(IViewBasicApp.OpenFileDialog1.FileName)
            IViewBasicApp.Text = "IViewBasic - " & GetFileName(IViewBasicApp.OpenFileDialog1.FileName)
            IViewBasicApp.SaveToolStripMenuItem.Enabled = False
            Dev.ResTxt.Visible = True
            Dev.ResTxt.Text = "Image Viewer is " & IViewBasicApp.IViewerBox.Width & "x" & IViewBasicApp.IViewerBox.Height
            IViewBasicApp.IViewerBox.Location = New Point(0, 0)
            IViewBasicApp.IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
            Close()
            IViewBasicApp.IViewerBox.Enabled = True
            IViewBasicApp.namef.Text = "Name: " & GetFileName(IViewBasicApp.OpenFileDialog1.FileName)
            IViewBasicApp.pathtxt.Text = GetFilePath(IViewBasicApp.OpenFileDialog1.FileName)
        Catch ex As Exception
        End Try
    End Sub
End Class