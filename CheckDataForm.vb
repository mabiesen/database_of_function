Public Class CheckDataForm
    Private Sub dataConfirmButton_Click(sender As Object, e As EventArgs) Handles dataConfirmButton.Click

        'Used as a switch to screen only one function at a time to user
        loopForFuncStart(GlobalVariables.fileForUpload, GlobalVariables.lastLineReferenced)
    End Sub

    Private Sub discardDataButton_Click(sender As Object, e As EventArgs) Handles discardDataButton.Click
        'Used as a switch to screen only one function at a time to user
        loopForFuncStart(GlobalVariables.fileForUpload, GlobalVariables.lastLineReferenced)
    End Sub

    Private Sub CheckDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cancelUploadButton_Click(sender As Object, e As EventArgs) Handles cancelUploadButton.Click
        GlobalVariables.lastLineReferenced = 0
        Me.Close()
    End Sub
End Class