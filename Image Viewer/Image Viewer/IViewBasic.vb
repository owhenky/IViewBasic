Public Class IViewBasic
    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        About.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SquaresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SquaresToolStripMenuItem1.Click
        If Dev.DMTB.Text = "1" Then
            IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.pngbgdark
        ElseIf Dev.DMTB.Text = "0" Then
            IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.pngbg
        End If
        Dev.BGTB.Text = "1"
        SquaresToolStripMenuItem1.Checked = True
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click
        Dev.BGTB.Text = "0"
        IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.none
        SquaresToolStripMenuItem1.Checked = False
        NoneToolStripMenuItem.Checked = True
    End Sub

    Private Sub OpenFromURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFromURLToolStripMenuItem.Click
        URL.Show()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Try
            With OpenFileDialog1
                .Title = "Choose an Image..."
                .FileName = "No Image Opened"
                .Filter = "All Files |*.*"
                .ShowDialog()
            End With
            IViewerBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            Text = "Image Viewer - " & (OpenFileDialog1.FileName)
            SaveToolStripMenuItem.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dev.DMTB.Text = "0" Then
            With URL
                .BackColor = SystemColors.Control
                .ForeColor = SystemColors.ControlText
                .openbtn.FlatStyle = FlatStyle.System
                .openbtn.ForeColor = SystemColors.Control
                .openbtn.BackColor = SystemColors.ControlText
                .cancelbtn.FlatStyle = FlatStyle.System
                .cancelbtn.ForeColor = SystemColors.Control
                .cancelbtn.BackColor = SystemColors.ControlText
                .URLTextB.BackColor = SystemColors.Window
                .URLTextB.ForeColor = SystemColors.ControlText
            End With
            With About
                .BackColor = SystemColors.Control
                .ForeColor = SystemColors.ControlText
            End With
            With MenuStrip1
                .BackColor = SystemColors.Control
                .ForeColor = SystemColors.ControlText
            End With
            Dev.DMTB.Text = "0"
            Panel1.BackColor = SystemColors.Control
            ForeColor = SystemColors.ControlText
            MSWhiteThemeToolStripMenuItem1.Checked = True
            MSBlackThemeToolStripMenuItem1.Checked = False
            If Dev.BGTB.Text = "1" Then
                IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.pngbg
            End If
        End If
        If Dev.DMTB.Text = "1" Then
            With URL
                .BackColor = Color.FromArgb(24, 24, 24)
                .ForeColor = Color.White
                .openbtn.FlatStyle = FlatStyle.Flat
                .openbtn.ForeColor = Color.White
                .openbtn.BackColor = Color.Black
                .cancelbtn.FlatStyle = FlatStyle.Flat
                .cancelbtn.ForeColor = Color.White
                .cancelbtn.BackColor = Color.Black
                .URLTextB.BackColor = Color.Black
                .URLTextB.ForeColor = Color.White
            End With
            With About
                .BackColor = Color.FromArgb(24, 24, 24)
                .ForeColor = Color.White
            End With
            With MenuStrip1
                .BackColor = Color.Black
                .ForeColor = Color.White
            End With
            Dev.DMTB.Text = "1"
            Panel1.BackColor = Color.FromArgb(24, 24, 24)
            BackColor = Color.Black
            ForeColor = Color.White
            MSWhiteThemeToolStripMenuItem1.Checked = False
            MSBlackThemeToolStripMenuItem1.Checked = True
            If Dev.BGTB.Text = "1" Then
                IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.pngbgdark
            End If
        End If
    End Sub

    Private Sub MSWhiteThemeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MSWhiteThemeToolStripMenuItem1.Click
        With URL
            .BackColor = SystemColors.Control
            .ForeColor = SystemColors.ControlText
            .openbtn.FlatStyle = FlatStyle.System
            .openbtn.ForeColor = SystemColors.Control
            .openbtn.BackColor = SystemColors.ControlText
            .cancelbtn.FlatStyle = FlatStyle.System
            .cancelbtn.ForeColor = SystemColors.Control
            .cancelbtn.BackColor = SystemColors.ControlText
            .URLTextB.BackColor = SystemColors.Window
            .URLTextB.ForeColor = SystemColors.ControlText
        End With
        With About
            .BackColor = SystemColors.Control
            .ForeColor = SystemColors.ControlText
        End With
        With MenuStrip1
            .BackColor = SystemColors.Control
            .ForeColor = SystemColors.ControlText
        End With
        Dev.DMTB.Text = "0"
        Panel1.BackColor = SystemColors.Control
        ForeColor = SystemColors.ControlText
        MSWhiteThemeToolStripMenuItem1.Checked = True
        MSBlackThemeToolStripMenuItem1.Checked = False
        If Dev.BGTB.Text = "1" Then
            IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.pngbg
        End If
    End Sub

    Private Sub MSBlackThemeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MSBlackThemeToolStripMenuItem1.Click
        With URL
            .BackColor = Color.FromArgb(24, 24, 24)
            .ForeColor = Color.White
            .openbtn.FlatStyle = FlatStyle.Flat
            .openbtn.ForeColor = Color.White
            .openbtn.BackColor = Color.Black
            .cancelbtn.FlatStyle = FlatStyle.Flat
            .cancelbtn.ForeColor = Color.White
            .cancelbtn.BackColor = Color.Black
            .URLTextB.BackColor = Color.Black
            .URLTextB.ForeColor = Color.White
        End With
        With About
            .BackColor = Color.FromArgb(24, 24, 24)
            .ForeColor = Color.White
        End With
        With MenuStrip1
            .BackColor = Color.Black
            .ForeColor = Color.White
        End With
        Dev.DMTB.Text = "1"
        Panel1.BackColor = Color.FromArgb(24, 24, 24)
        BackColor = Color.Black
        ForeColor = Color.White
        MSWhiteThemeToolStripMenuItem1.Checked = False
        MSBlackThemeToolStripMenuItem1.Checked = True
        If Dev.BGTB.Text = "1" Then
            IViewerBox.BackgroundImage = Image_Viewer.My.Resources.Resources.pngbgdark
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim local As String
        Dim img = New Bitmap(IViewerBox.Image)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Jpeg Image|*.jpg"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            local = saveFileDialog1.FileName
            img.Save(local, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub ImageViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F12 Then
            Dev.Show()
        End If
    End Sub
End Class
