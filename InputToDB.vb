Public Module InputToDB
    Public Sub UserCheckData(purpose, inputs, outputs, tags, name, myimports, wholefunction)
        CheckDataForm.Show()
        CheckDataForm.nameBox.Text = name
        CheckDataForm.purposeBox.Text = purpose
        CheckDataForm.tagBox.Text = tags
        CheckDataForm.inputsBox.Text = inputs
        CheckDataForm.outputsBox.Text = outputs
        CheckDataForm.functionBox.Text = wholefunction
        CheckDataForm.importsBox.Text = myimports
    End Sub

    Public Sub addToDb(name, purpose, tags, inputs, outputs, wholefunction)

    End Sub

End Module
