<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dev
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
        Me.DMTB = New System.Windows.Forms.TextBox()
        Me.DML = New System.Windows.Forms.Label()
        Me.BGTB = New System.Windows.Forms.TextBox()
        Me.BGL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DMTB
        '
        Me.DMTB.Location = New System.Drawing.Point(264, 12)
        Me.DMTB.Name = "DMTB"
        Me.DMTB.Size = New System.Drawing.Size(21, 20)
        Me.DMTB.TabIndex = 0
        Me.DMTB.Text = "0"
        '
        'DML
        '
        Me.DML.AutoSize = True
        Me.DML.Location = New System.Drawing.Point(12, 15)
        Me.DML.Name = "DML"
        Me.DML.Size = New System.Drawing.Size(60, 13)
        Me.DML.TabIndex = 1
        Me.DML.Text = "Dark Mode"
        '
        'BGTB
        '
        Me.BGTB.Location = New System.Drawing.Point(264, 38)
        Me.BGTB.Name = "BGTB"
        Me.BGTB.Size = New System.Drawing.Size(21, 20)
        Me.BGTB.TabIndex = 0
        Me.BGTB.Text = "0"
        '
        'BGL
        '
        Me.BGL.AutoSize = True
        Me.BGL.Location = New System.Drawing.Point(12, 41)
        Me.BGL.Name = "BGL"
        Me.BGL.Size = New System.Drawing.Size(65, 13)
        Me.BGL.TabIndex = 1
        Me.BGL.Text = "Background"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "0 - None"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1 - Squares"
        '
        'Dev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 101)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BGL)
        Me.Controls.Add(Me.BGTB)
        Me.Controls.Add(Me.DML)
        Me.Controls.Add(Me.DMTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dev"
        Me.Text = "DevForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DMTB As TextBox
    Friend WithEvents DML As Label
    Friend WithEvents BGTB As TextBox
    Friend WithEvents BGL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
