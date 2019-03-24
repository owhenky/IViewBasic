<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class URL
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
        Me.URLTextB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.openbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'URLTextB
        '
        Me.URLTextB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.URLTextB.Location = New System.Drawing.Point(32, 54)
        Me.URLTextB.Name = "URLTextB"
        Me.URLTextB.Size = New System.Drawing.Size(292, 20)
        Me.URLTextB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter an URL to view the image"
        '
        'openbtn
        '
        Me.openbtn.Location = New System.Drawing.Point(249, 89)
        Me.openbtn.Name = "openbtn"
        Me.openbtn.Size = New System.Drawing.Size(75, 23)
        Me.openbtn.TabIndex = 2
        Me.openbtn.Text = "Open"
        Me.openbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(168, 89)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 2
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'URL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 127)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.openbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.URLTextB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "URL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open from URL..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents URLTextB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents openbtn As Button
    Friend WithEvents cancelbtn As Button
End Class
