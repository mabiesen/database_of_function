<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ofdButton = New System.Windows.Forms.Button()
        Me.dbSearchButton = New System.Windows.Forms.Button()
        Me.dbBrowseButton = New System.Windows.Forms.Button()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.ofdHidden = New System.Windows.Forms.OpenFileDialog()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ofdButton
        '
        Me.ofdButton.Location = New System.Drawing.Point(117, 177)
        Me.ofdButton.Name = "ofdButton"
        Me.ofdButton.Size = New System.Drawing.Size(528, 77)
        Me.ofdButton.TabIndex = 0
        Me.ofdButton.Text = "Log New File"
        Me.ofdButton.UseVisualStyleBackColor = True
        '
        'dbSearchButton
        '
        Me.dbSearchButton.Location = New System.Drawing.Point(117, 306)
        Me.dbSearchButton.Name = "dbSearchButton"
        Me.dbSearchButton.Size = New System.Drawing.Size(528, 77)
        Me.dbSearchButton.TabIndex = 1
        Me.dbSearchButton.Text = "Search For Function"
        Me.dbSearchButton.UseVisualStyleBackColor = True
        '
        'dbBrowseButton
        '
        Me.dbBrowseButton.Location = New System.Drawing.Point(117, 431)
        Me.dbBrowseButton.Name = "dbBrowseButton"
        Me.dbBrowseButton.Size = New System.Drawing.Size(528, 77)
        Me.dbBrowseButton.TabIndex = 2
        Me.dbBrowseButton.Text = "Browse Database"
        Me.dbBrowseButton.UseVisualStyleBackColor = True
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.welcomeLabel.Location = New System.Drawing.Point(43, 65)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(682, 54)
        Me.welcomeLabel.TabIndex = 3
        Me.welcomeLabel.Text = "Select an Option to Get Started!"
        '
        'ofdHidden
        '
        Me.ofdHidden.FileName = "ofdHidden"
        '
        'quitButton
        '
        Me.quitButton.Location = New System.Drawing.Point(117, 561)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(528, 77)
        Me.quitButton.TabIndex = 4
        Me.quitButton.Text = "Quit Program"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 688)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.dbBrowseButton)
        Me.Controls.Add(Me.dbSearchButton)
        Me.Controls.Add(Me.ofdButton)
        Me.Name = "MainForm"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofdButton As Button
    Friend WithEvents dbSearchButton As Button
    Friend WithEvents dbBrowseButton As Button
    Friend WithEvents welcomeLabel As Label
    Friend WithEvents ofdHidden As OpenFileDialog
    Friend WithEvents quitButton As Button
End Class
