<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetStarted
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
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GH = New System.Windows.Forms.LinkLabel()
        Me.DC = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileBtn.Location = New System.Drawing.Point(35, 224)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(533, 74)
        Me.OpenFileBtn.TabIndex = 0
        Me.OpenFileBtn.Text = "Open from File"
        Me.OpenFileBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(35, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(533, 74)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Open from URL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to IViewBasic!"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(35, 384)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 74)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Or drop a file here"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 34)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "|"
        '
        'GH
        '
        Me.GH.AutoSize = True
        Me.GH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GH.Location = New System.Drawing.Point(238, 110)
        Me.GH.Name = "GH"
        Me.GH.Size = New System.Drawing.Size(69, 25)
        Me.GH.TabIndex = 4
        Me.GH.TabStop = True
        Me.GH.Text = "Github"
        '
        'DC
        '
        Me.DC.AutoSize = True
        Me.DC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DC.Location = New System.Drawing.Point(321, 111)
        Me.DC.Name = "DC"
        Me.DC.Size = New System.Drawing.Size(76, 25)
        Me.DC.TabIndex = 4
        Me.DC.TabStop = True
        Me.DC.Text = "Discord"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 57)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "An Image Viewer made for fast image opening"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(308, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 84)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(35, 481)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 84)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Close this Window"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AppIcon
        '
        Me.AppIcon.Image = Global.IViewBasic.My.Resources.Resources.IViewBasicIcon
        Me.AppIcon.Location = New System.Drawing.Point(35, 21)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(196, 197)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIcon.TabIndex = 2
        Me.AppIcon.TabStop = False
        '
        'GetStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 584)
        Me.Controls.Add(Me.DC)
        Me.Controls.Add(Me.GH)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AppIcon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetStarted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Started"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AppIcon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GH As LinkLabel
    Friend WithEvents DC As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
