<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IViewBasicApp
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IViewBasicApp))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFromURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSWhiteThemeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSBlackThemeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquaresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FitScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomBarZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ZoomIn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IViewerBox = New System.Windows.Forms.PictureBox()
        Me.imginfo = New System.Windows.Forms.Panel()
        Me.pathtxt = New System.Windows.Forms.TextBox()
        Me.path = New System.Windows.Forms.Label()
        Me.namef = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hideinfo = New System.Windows.Forms.Button()
        Me.ZoomOut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IViewerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.imginfo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(873, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem1, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.OpenFromURLToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open from File"
        '
        'OpenFromURLToolStripMenuItem
        '
        Me.OpenFromURLToolStripMenuItem.Name = "OpenFromURLToolStripMenuItem"
        Me.OpenFromURLToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenFromURLToolStripMenuItem.Text = "Open from URL"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem1.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ViewToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "View"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.BackgroundToolStripMenuItem})
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MSWhiteThemeToolStripMenuItem1, Me.MSBlackThemeToolStripMenuItem1})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'MSWhiteThemeToolStripMenuItem1
        '
        Me.MSWhiteThemeToolStripMenuItem1.Name = "MSWhiteThemeToolStripMenuItem1"
        Me.MSWhiteThemeToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.MSWhiteThemeToolStripMenuItem1.Text = "MS White Theme"
        '
        'MSBlackThemeToolStripMenuItem1
        '
        Me.MSBlackThemeToolStripMenuItem1.Name = "MSBlackThemeToolStripMenuItem1"
        Me.MSBlackThemeToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.MSBlackThemeToolStripMenuItem1.Text = "MS Black Theme"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SquaresToolStripMenuItem1, Me.NoneToolStripMenuItem})
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'SquaresToolStripMenuItem1
        '
        Me.SquaresToolStripMenuItem1.Name = "SquaresToolStripMenuItem1"
        Me.SquaresToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.SquaresToolStripMenuItem1.Text = "Squares"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Checked = True
        Me.NoneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.NoneToolStripMenuItem.Text = "None"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionToolStripMenuItem, Me.SizeToolStripMenuItem})
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FitScreenToolStripMenuItem, Me.RestoreToolStripMenuItem1})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ViewToolStripMenuItem.Text = "Image View"
        '
        'FitScreenToolStripMenuItem
        '
        Me.FitScreenToolStripMenuItem.Name = "FitScreenToolStripMenuItem"
        Me.FitScreenToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.FitScreenToolStripMenuItem.Text = "Fit Screen"
        '
        'RestoreToolStripMenuItem1
        '
        Me.RestoreToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem1, Me.PositionToolStripMenuItem1})
        Me.RestoreToolStripMenuItem1.Name = "RestoreToolStripMenuItem1"
        Me.RestoreToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.RestoreToolStripMenuItem1.Text = "Restore"
        '
        'SizeToolStripMenuItem1
        '
        Me.SizeToolStripMenuItem1.Name = "SizeToolStripMenuItem1"
        Me.SizeToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.SizeToolStripMenuItem1.Text = "Size"
        '
        'PositionToolStripMenuItem1
        '
        Me.PositionToolStripMenuItem1.Name = "PositionToolStripMenuItem1"
        Me.PositionToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.PositionToolStripMenuItem1.Text = "Position"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropertiesToolStripMenuItem, Me.BottomBarZoomToolStripMenuItem})
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'BottomBarZoomToolStripMenuItem
        '
        Me.BottomBarZoomToolStripMenuItem.Checked = True
        Me.BottomBarZoomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BottomBarZoomToolStripMenuItem.Name = "BottomBarZoomToolStripMenuItem"
        Me.BottomBarZoomToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BottomBarZoomToolStripMenuItem.Text = "Bottom bar (Zoom)"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem2})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem1.Text = "Help"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(113, 6)
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem2.Text = "About..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ZoomIn
        '
        Me.ZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomIn.Location = New System.Drawing.Point(847, 5)
        Me.ZoomIn.Name = "ZoomIn"
        Me.ZoomIn.Size = New System.Drawing.Size(23, 23)
        Me.ZoomIn.TabIndex = 4
        Me.ZoomIn.Text = "+"
        Me.ZoomIn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.IViewerBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 489)
        Me.Panel1.TabIndex = 9
        '
        'IViewerBox
        '
        Me.IViewerBox.BackgroundImage = Global.IViewBasic.My.Resources.Resources.none
        Me.IViewerBox.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.IViewerBox.Location = New System.Drawing.Point(0, 0)
        Me.IViewerBox.Name = "IViewerBox"
        Me.IViewerBox.Size = New System.Drawing.Size(617, 489)
        Me.IViewerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IViewerBox.TabIndex = 3
        Me.IViewerBox.TabStop = False
        '
        'imginfo
        '
        Me.imginfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imginfo.Controls.Add(Me.pathtxt)
        Me.imginfo.Controls.Add(Me.path)
        Me.imginfo.Controls.Add(Me.namef)
        Me.imginfo.Controls.Add(Me.Panel3)
        Me.imginfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.imginfo.Location = New System.Drawing.Point(617, 24)
        Me.imginfo.Name = "imginfo"
        Me.imginfo.Size = New System.Drawing.Size(256, 489)
        Me.imginfo.TabIndex = 4
        Me.imginfo.Visible = False
        '
        'pathtxt
        '
        Me.pathtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pathtxt.Location = New System.Drawing.Point(43, 69)
        Me.pathtxt.Multiline = True
        Me.pathtxt.Name = "pathtxt"
        Me.pathtxt.ReadOnly = True
        Me.pathtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pathtxt.Size = New System.Drawing.Size(200, 82)
        Me.pathtxt.TabIndex = 3
        '
        'path
        '
        Me.path.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.path.AutoSize = True
        Me.path.Location = New System.Drawing.Point(8, 69)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(32, 13)
        Me.path.TabIndex = 2
        Me.path.Text = "Path:"
        '
        'namef
        '
        Me.namef.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.namef.AutoSize = True
        Me.namef.Location = New System.Drawing.Point(8, 47)
        Me.namef.Name = "namef"
        Me.namef.Size = New System.Drawing.Size(38, 13)
        Me.namef.TabIndex = 2
        Me.namef.Text = "Name:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.hideinfo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(254, 30)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Image Properties"
        '
        'hideinfo
        '
        Me.hideinfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hideinfo.Location = New System.Drawing.Point(228, 3)
        Me.hideinfo.Name = "hideinfo"
        Me.hideinfo.Size = New System.Drawing.Size(23, 23)
        Me.hideinfo.TabIndex = 0
        Me.hideinfo.Text = ">"
        Me.hideinfo.UseVisualStyleBackColor = True
        '
        'ZoomOut
        '
        Me.ZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZoomOut.Location = New System.Drawing.Point(818, 5)
        Me.ZoomOut.Name = "ZoomOut"
        Me.ZoomOut.Size = New System.Drawing.Size(23, 23)
        Me.ZoomOut.TabIndex = 4
        Me.ZoomOut.Text = "-"
        Me.ZoomOut.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ZoomOut)
        Me.Panel2.Controls.Add(Me.ZoomIn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 32)
        Me.Panel2.TabIndex = 11
        '
        'IViewBasicApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imginfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IViewBasicApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IViewBasic"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IViewerBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.imginfo.ResumeLayout(False)
        Me.imginfo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFromURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSWhiteThemeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MSBlackThemeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SquaresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents IViewerBox As PictureBox
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CloseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZoomIn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOut As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FitScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents imginfo As Panel
    Friend WithEvents hideinfo As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents path As Label
    Friend WithEvents namef As Label
    Friend WithEvents RestoreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BottomBarZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pathtxt As TextBox
End Class
