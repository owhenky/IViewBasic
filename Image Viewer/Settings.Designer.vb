<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.dflt = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DC = New System.Windows.Forms.LinkLabel()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.GH = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rmv = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dflt
        '
        Me.dflt.Location = New System.Drawing.Point(12, 19)
        Me.dflt.Name = "dflt"
        Me.dflt.Size = New System.Drawing.Size(129, 23)
        Me.dflt.TabIndex = 0
        Me.dflt.Text = "Set as default program"
        Me.dflt.UseVisualStyleBackColor = True
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
        Me.Panel3.TabIndex = 12
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
        Me.Label4.Size = New System.Drawing.Size(10, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "|"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(-1, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 1)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 1)
        Me.Panel1.TabIndex = 5
        '
        'rmv
        '
        Me.rmv.Location = New System.Drawing.Point(12, 48)
        Me.rmv.Name = "rmv"
        Me.rmv.Size = New System.Drawing.Size(129, 23)
        Me.rmv.TabIndex = 0
        Me.rmv.Text = "Remove"
        Me.rmv.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dflt)
        Me.GroupBox1.Controls.Add(Me.rmv)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(17, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 98)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Default program"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is not working"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(355, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 253)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dflt As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DC As LinkLabel
    Friend WithEvents AppIcon As PictureBox
    Friend WithEvents GH As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rmv As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
