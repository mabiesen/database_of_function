<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckDataForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.functionBox = New System.Windows.Forms.TextBox()
        Me.dataConfirmButton = New System.Windows.Forms.Button()
        Me.discardDataButton = New System.Windows.Forms.Button()
        Me.cancelUploadButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tagBox = New System.Windows.Forms.TextBox()
        Me.purposeBox = New System.Windows.Forms.TextBox()
        Me.outputsBox = New System.Windows.Forms.TextBox()
        Me.inputsBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.importsBox = New System.Windows.Forms.TextBox()
        Me.languageBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'functionBox
        '
        Me.functionBox.AcceptsReturn = True
        Me.functionBox.AcceptsTab = True
        Me.functionBox.Location = New System.Drawing.Point(12, 549)
        Me.functionBox.Multiline = True
        Me.functionBox.Name = "functionBox"
        Me.functionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.functionBox.Size = New System.Drawing.Size(1170, 383)
        Me.functionBox.TabIndex = 0
        '
        'dataConfirmButton
        '
        Me.dataConfirmButton.Location = New System.Drawing.Point(27, 446)
        Me.dataConfirmButton.Name = "dataConfirmButton"
        Me.dataConfirmButton.Size = New System.Drawing.Size(343, 46)
        Me.dataConfirmButton.TabIndex = 1
        Me.dataConfirmButton.Text = "Confirm Data"
        Me.dataConfirmButton.UseVisualStyleBackColor = True
        '
        'discardDataButton
        '
        Me.discardDataButton.Location = New System.Drawing.Point(429, 446)
        Me.discardDataButton.Name = "discardDataButton"
        Me.discardDataButton.Size = New System.Drawing.Size(343, 46)
        Me.discardDataButton.TabIndex = 2
        Me.discardDataButton.Text = "Discard Function"
        Me.discardDataButton.UseVisualStyleBackColor = True
        '
        'cancelUploadButton
        '
        Me.cancelUploadButton.Location = New System.Drawing.Point(829, 446)
        Me.cancelUploadButton.Name = "cancelUploadButton"
        Me.cancelUploadButton.Size = New System.Drawing.Size(343, 46)
        Me.cancelUploadButton.TabIndex = 3
        Me.cancelUploadButton.Text = "Cancel ALL"
        Me.cancelUploadButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(493, 514)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Whole Function"
        '
        'tagBox
        '
        Me.tagBox.Location = New System.Drawing.Point(698, 175)
        Me.tagBox.Name = "tagBox"
        Me.tagBox.Size = New System.Drawing.Size(474, 38)
        Me.tagBox.TabIndex = 5
        '
        'purposeBox
        '
        Me.purposeBox.Location = New System.Drawing.Point(27, 175)
        Me.purposeBox.Multiline = True
        Me.purposeBox.Name = "purposeBox"
        Me.purposeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.purposeBox.Size = New System.Drawing.Size(474, 109)
        Me.purposeBox.TabIndex = 6
        '
        'outputsBox
        '
        Me.outputsBox.Location = New System.Drawing.Point(698, 363)
        Me.outputsBox.Name = "outputsBox"
        Me.outputsBox.Size = New System.Drawing.Size(474, 38)
        Me.outputsBox.TabIndex = 8
        '
        'inputsBox
        '
        Me.inputsBox.Location = New System.Drawing.Point(698, 271)
        Me.inputsBox.Name = "inputsBox"
        Me.inputsBox.Size = New System.Drawing.Size(474, 38)
        Me.inputsBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(149, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 54)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Function Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Function Purpose"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(888, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Inputs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(888, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Outputs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(823, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Function Tags"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(30, 67)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(560, 38)
        Me.nameBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 32)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Function Imports"
        '
        'importsBox
        '
        Me.importsBox.Location = New System.Drawing.Point(27, 325)
        Me.importsBox.Multiline = True
        Me.importsBox.Name = "importsBox"
        Me.importsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.importsBox.Size = New System.Drawing.Size(474, 109)
        Me.importsBox.TabIndex = 15
        '
        'languageBox
        '
        Me.languageBox.Location = New System.Drawing.Point(698, 67)
        Me.languageBox.Name = "languageBox"
        Me.languageBox.Size = New System.Drawing.Size(474, 38)
        Me.languageBox.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(888, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 32)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Language"
        '
        'CheckDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1211, 1012)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.languageBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.importsBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.outputsBox)
        Me.Controls.Add(Me.inputsBox)
        Me.Controls.Add(Me.purposeBox)
        Me.Controls.Add(Me.tagBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelUploadButton)
        Me.Controls.Add(Me.discardDataButton)
        Me.Controls.Add(Me.dataConfirmButton)
        Me.Controls.Add(Me.functionBox)
        Me.Name = "CheckDataForm"
        Me.Text = "Please Confirm Function Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents functionBox As TextBox
    Friend WithEvents dataConfirmButton As Button
    Friend WithEvents discardDataButton As Button
    Friend WithEvents cancelUploadButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tagBox As TextBox
    Friend WithEvents purposeBox As TextBox
    Friend WithEvents outputsBox As TextBox
    Friend WithEvents inputsBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents importsBox As TextBox
    Friend WithEvents languageBox As TextBox
    Friend WithEvents Label8 As Label
End Class
