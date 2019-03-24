<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DC = New System.Windows.Forms.LinkLabel()
        Me.GH = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IViewBasic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 0.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by owhenky - 2019"
        '
        'AppIcon
        '
        Me.AppIcon.Image = Global.IViewBasic.My.Resources.Resources.IViewBasicIcon
        Me.AppIcon.Location = New System.Drawing.Point(97, 0)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(58, 58)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIcon.TabIndex = 4
        Me.AppIcon.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IViewBasic"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 1)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IViewBasic.My.Resources.Resources.IViewBasicIcon
        Me.PictureBox1.Location = New System.Drawing.Point(11, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(-1, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 1)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "The IViewBasic program is an Image Viewer made for fast image opening, it has a b" &
    "asic interface. It was made by owhenky"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DC
        '
        Me.DC.AutoSize = True
        Me.DC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DC.Location = New System.Drawing.Point(218, 38)
        Me.DC.Name = "DC"
        Me.DC.Size = New System.Drawing.Size(53, 17)
        Me.DC.TabIndex = 10
        Me.DC.TabStop = True
        Me.DC.Text = "Discord"
        '
        'GH
        '
        Me.GH.AutoSize = True
        Me.GH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GH.Location = New System.Drawing.Point(164, 38)
        Me.GH.Name = "GH"
        Me.GH.Size = New System.Drawing.Size(46, 17)
        Me.GH.TabIndex = 9
        Me.GH.TabStop = True
        Me.GH.Text = "Github"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "|"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DC)
        Me.Panel3.Controls.Add(Me.AppIcon)
        Me.Panel3.Controls.Add(Me.GH)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(17, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 73)
        Me.Panel3.TabIndex = 11
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 235)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AppIcon As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DC As LinkLabel
    Friend WithEvents GH As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
End Class
