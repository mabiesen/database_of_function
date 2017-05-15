'Module used to prepare VB input for database
'We loop through all filedata looking for the start of our functions
'When the start of a function is found, loopforfunction is called
'When the end of the function has been found, inputintodatabase is called


Module VBPrepareInputModule
    Public Sub loopForFuncStart(filedata, Optional mycounter = 0)
        Dim temptuple As Tuple(Of String, String, String, String, String, String, String)
        While mycounter < filedata.length()
            If filedata(mycounter).contains("Func Purpose") Then
                temptuple = loopForFuncInfo(filedata, mycounter)
                UserCheckData(temptuple.Item1, temptuple.Item2, temptuple.Item3, temptuple.Item4, temptuple.Item5, temptuple.Item6, temptuple.Item7)
                Exit Sub
            End If
            mycounter = mycounter + 1
        End While
        MessageBox.Show("You have reached the end of the file, there are no more identified functions.")
    End Sub

    Public Function loopForFuncInfo(filedata, startline) As Tuple(Of String, String, String, String, String, String, String)
        Dim tempstore, purpose, inputs, outputs, tags, name, myimports, wholefunction As String
        Dim purposeprompt As String = "Func Purpose: "
        Dim inputsprompt As String = "Func Inputs: "
        Dim outputsprompt As String = "Func Outputs: "
        Dim tagsprompt As String = "Func Tags: "
        Dim nameprompt As String = "Func Name: "
        Dim myimportsprompt As String = "Func Imports: "

        wholefunction = ""
        While startline < filedata.length()
            tempstore = filedata(startline)
            wholefunction = wholefunction & vbCrLf & filedata(startline)
            If tempstore.Contains("End Function") Then
                Exit While
            ElseIf tempstore.Contains(purposeprompt) Then
                purpose = removeFuncLabels(tempstore, purposeprompt)
            ElseIf tempstore.Contains(inputsprompt) Then
                inputs = removeFuncLabels(tempstore, inputsprompt)
            ElseIf tempstore.Contains(outputsprompt) Then
                outputs = removeFuncLabels(tempstore, outputsprompt)
            ElseIf tempstore.Contains(tagsprompt) Then
                tags = removeFuncLabels(tempstore, tagsprompt)
            ElseIf tempstore.Contains(nameprompt) Then
                name = removeFuncLabels(tempstore, nameprompt)
            ElseIf tempstore.Contains(myimportsprompt) Then
                myimports = removeFuncLabels(tempstore, myimportsprompt)
            End If
            startline = startline + 1
        End While
        GlobalVariables.lastLineReferenced = startline
        Return Tuple.Create(name, purpose, tags, myimports, inputs, outputs, wholefunction)
    End Function

    Public Sub UserCheckData(name, purpose, tags, myimports, inputs, outputs, wholefunction)
        CheckDataForm.Show()
        CheckDataForm.nameBox.Text = name
        CheckDataForm.purposeBox.Text = purpose
        CheckDataForm.tagBox.Text = tags
        CheckDataForm.inputsBox.Text = inputs
        CheckDataForm.outputsBox.Text = outputs
        CheckDataForm.functionBox.Text = wholefunction
        CheckDataForm.importsBox.Text = myimports
    End Sub

    Public Function removeFuncLabels(line, label) As String
        removeFuncLabels = Replace(line, label, "")
    End Function
End Module
