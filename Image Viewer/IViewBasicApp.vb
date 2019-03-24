Public Class IViewBasicApp
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub AboutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem2.Click
        About.Show()
        Enabled = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SquaresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SquaresToolStripMenuItem1.Click
        If Dev.DMTB.Text = "1" Then
            IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.pngbgdark
        ElseIf Dev.DMTB.Text = "0" Then
            IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.pngbg
        End If
        Dev.BGTB.Text = "1"
        SquaresToolStripMenuItem1.Checked = True
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click
        Dev.BGTB.Text = "0"
        IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.none
        SquaresToolStripMenuItem1.Checked = False
        NoneToolStripMenuItem.Checked = True
    End Sub

    Private Sub OpenFromURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFromURLToolStripMenuItem.Click
        Enabled = False
        URL.URLTextB.Text = ""
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
            Text = "IViewBasic - " & GetFileName(OpenFileDialog1.FileName)
            SaveToolStripMenuItem.Enabled = False
            Dev.ResTxt.Text = "Image Viewer is " & IViewerBox.Width & "x" & IViewerBox.Height
            IViewerBox.Location = New Point(0, 0)
            IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
            IViewerBox.Enabled = True
            namef.Text = "Name: " & GetFileName(OpenFileDialog1.FileName)
            pathtxt.Text = GetFilePath(OpenFileDialog1.FileName)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BottomBarZoomToolStripMenuItem.Checked = False Then
            Panel2.Visible = True
            BottomBarZoomToolStripMenuItem.Checked = True
            IViewerBox.Enabled = False
        End If
        GetStarted.Show()
        IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
        If IViewerBox.Image IsNot Nothing Then
            IViewerBox.Size = Panel1.Size
            _originalSize = Panel1.Size
        End If
        If Application.OpenForms().OfType(Of GetStarted).Any Then
            Enabled = False
        End If
        If Application.OpenForms().OfType(Of About).Any Then
            Enabled = False
        End If
        If Application.OpenForms().OfType(Of URL).Any Then
            Enabled = False
        End If
        IViewerBox.MaximumSize = New Size(11890, 6686)
        AllowDrop = True
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
            With ZoomIn
                .BackColor = SystemColors.Control
                .ForeColor = SystemColors.ControlText
                .FlatStyle = FlatStyle.System
            End With
            With ZoomOut
                .BackColor = SystemColors.Control
                .ForeColor = SystemColors.ControlText
                .FlatStyle = FlatStyle.System
            End With
            With Panel2
                .BackColor = SystemColors.Control
                .ForeColor = SystemColors.ControlText
            End With
            Dev.DMTB.Text = "0"
            Panel1.BackColor = SystemColors.Control
            ForeColor = SystemColors.ControlText
            MSWhiteThemeToolStripMenuItem1.Checked = True
            MSBlackThemeToolStripMenuItem1.Checked = False
            If Dev.BGTB.Text = "1" Then
                IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.pngbg
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
            With ZoomIn
                .FlatStyle = FlatStyle.Flat
                .ForeColor = Color.White
                .BackColor = Color.Black
            End With
            With ZoomOut
                .FlatStyle = FlatStyle.Flat
                .ForeColor = Color.White
                .BackColor = Color.Black
            End With
            With Panel2
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
                IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.pngbgdark
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
        With ZoomIn
            .BackColor = SystemColors.Control
            .ForeColor = SystemColors.ControlText
            .FlatStyle = FlatStyle.System
        End With
        With ZoomOut
            .BackColor = SystemColors.Control
            .ForeColor = SystemColors.ControlText
            .FlatStyle = FlatStyle.System
        End With
        With Panel2
            .BackColor = SystemColors.Control
            .ForeColor = SystemColors.ControlText
        End With
        Dev.DMTB.Text = "0"
        Panel1.BackColor = SystemColors.Control
        ForeColor = SystemColors.ControlText
        MSWhiteThemeToolStripMenuItem1.Checked = True
        MSBlackThemeToolStripMenuItem1.Checked = False
        If Dev.BGTB.Text = "1" Then
            IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.pngbg
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
        With ZoomIn
            .FlatStyle = FlatStyle.Flat
            .ForeColor = Color.White
            .BackColor = Color.Black
        End With
        With ZoomOut
            .FlatStyle = FlatStyle.Flat
            .ForeColor = Color.White
            .BackColor = Color.Black
        End With
        With Panel2
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
            IViewerBox.BackgroundImage = IViewBasic.My.Resources.Resources.pngbgdark
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

    Private Sub ImageViewer_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ImageViewer_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        For Each file In droppedFiles
            Dim filepath As String = GetFilePath(file)
            Dim filename As String = GetFileName(file)
            Text = "IViewBasic - " & (filename) & " (" & (filepath) & ")"
            Dev.ResTxt.Text = "Image Viewer is " & IViewerBox.Width & "x" & IViewerBox.Height
            IViewerBox.Location = New Point(0, 0)
            IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
            IViewerBox.Image = Image.FromFile(file)
        Next
    End Sub

    Public Function GetFilePath(path As String)
        Return System.IO.Path.GetFullPath(path)
    End Function

    Public Function GetFileName(path As String)
        Return System.IO.Path.GetFileName(path)
    End Function

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        Dev.ResTxt.Visible = False
        IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
        IViewerBox.Image = IViewBasic.My.Resources.Resources.none
        IViewerBox.Enabled = False
        Text = "IViewBasic"
    End Sub

    Private Sub IViewerBox_Click(sender As Object, e As EventArgs) Handles IViewerBox.Click
        IViewerBox.Top = Cursor.Position.Y - mousey
    End Sub

    Private Sub IViewerBox_MouseDown(sender As Object, e As MouseEventArgs) Handles IViewerBox.MouseDown
        drag = True
        mousex = Cursor.Position.X - IViewerBox.Left
        mousey = Cursor.Position.Y - IViewerBox.Top
        IViewerBox.Dock = DockStyle.None
        IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub IViewerBox_MouseUp(sender As Object, e As MouseEventArgs) Handles IViewerBox.MouseUp
        drag = False
    End Sub

    Private Sub IViewerBox_MouseMove(sender As Object, e As MouseEventArgs) Handles IViewerBox.MouseMove
        If drag Then
            IViewerBox.Top = Cursor.Position.Y - mousey
            IViewerBox.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ZoomIn.Click
        Dev.ResTxt.Text = "Image Viewer is " & IViewerBox.Width & "x" & IViewerBox.Height
        IViewerBox.Width *= 1.2
        IViewerBox.Height *= 1.2
        IViewerBox.Dock = DockStyle.None
        IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionToolStripMenuItem.Click
        IViewerBox.Location = New Point(0, 0)
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        IViewerBox.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ZoomOut.Click
        Dev.ResTxt.Text = "Image Viewer is " & IViewerBox.Width & "x" & IViewerBox.Height
        IViewerBox.Width -= 120
        IViewerBox.Height -= 120
        IViewerBox.Dock = DockStyle.None
        IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub FitScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FitScreenToolStripMenuItem.Click
        IViewerBox.Dock = DockStyle.Fill
        IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub IViewerBox_MouseEnter(sender As Object, e As EventArgs) Handles IViewerBox.MouseEnter
        IViewerBox.Focus()
    End Sub

    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005

    Private Sub ImageViewer_MouseWheel(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseWheel
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
        If e.Delta < 0 Then
            Dev.ResTxt.Text = "Image Viewer is " & IViewerBox.Width & "x" & IViewerBox.Height
            IViewerBox.Width -= 120
            IViewerBox.Height -= 120
            IViewerBox.Dock = DockStyle.None
            IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf e.Delta > 0 Then
            Dev.ResTxt.Text = "Image Viewer is " & IViewerBox.Width & "x" & IViewerBox.Height
            IViewerBox.Width *= 1.2
            IViewerBox.Height *= 1.2
            IViewerBox.Dock = DockStyle.None
            IViewerBox.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Enabled = False
        Settings.Show()
    End Sub

    Private Sub hideinfo_Click(sender As Object, e As EventArgs) Handles hideinfo.Click
        If hideinfo.Text = ">" Then
            imginfo.Width = 30
            hideinfo.Text = "<"
        Else
            imginfo.Width = 256
            hideinfo.Text = ">"
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        If imginfo.Visible = False Then
            imginfo.Visible = True
            PropertiesToolStripMenuItem.Checked = True
        Else
            imginfo.Visible = False
            PropertiesToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub BottomBarZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomBarZoomToolStripMenuItem.Click
        If BottomBarZoomToolStripMenuItem.Checked = False Then
            Panel2.Visible = True
            BottomBarZoomToolStripMenuItem.Checked = True
        Else
            Panel2.Visible = False
            BottomBarZoomToolStripMenuItem.Checked = False
        End If
    End Sub
End Class
