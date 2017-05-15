Public Class CheckDataForm
    Private Sub dataConfirmButton_Click(sender As Object, e As EventArgs) Handles dataConfirmButton.Click

        'Add data to database, then loop for more data.
        addToDb(Me.nameBox.Text, Me.purposeBox.Text, Me.tagBox.Text, Me.importsBox.Text, Me.inputsBox.Text, Me.outputsBox.Text, Me.functionBox.Text)
        loopForFuncStart(GlobalVariables.fileForUpload, GlobalVariables.lastLineReferenced)
    End Sub

    Private Sub discardDataButton_Click(sender As Object, e As EventArgs) Handles discardDataButton.Click
        'Used as a switch to screen only one function at a time to user
        loopForFuncStart(GlobalVariables.fileForUpload, GlobalVariables.lastLineReferenced)
    End Sub

    Private Sub cancelUploadButton_Click(sender As Object, e As EventArgs) Handles cancelUploadButton.Click
        Me.Close()
    End Sub

    Private Sub CheckDataForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sur to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GlobalVariables.lastLineReferenced = 0
            Me.nameBox.Text = ""
            Me.purposeBox.Text = ""
            Me.tagBox.Text = ""
            Me.inputsBox.Text = ""
            Me.outputsBox.Text = ""
            Me.functionBox.Text = ""
            Me.importsBox.Text = ""
        Else
            e.Cancel = True
        End If
    End Sub
End Class