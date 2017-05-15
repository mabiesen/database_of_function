'Module used to prepare VB input for database
'We loop through all filedata looking for the start of our functions
'When the start of a function is found, loopforfunction is called
'When the end of the function has been found, inputintodatabase is called


Module VBPrepareInputModule
    Public Sub loopForFuncStart(filedata, Optional mycounter = 0)
        While mycounter < filedata.length()
            If filedata(mycounter).contains("Func Purpose") Then
                loopForFuncInfo(filedata, mycounter)
                Exit Sub
            End If
            mycounter = mycounter + 1
        End While
    End Sub

    Public Sub loopForFuncInfo(filedata, startline)
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
        UserCheckData(purpose, inputs, outputs, tags, name, myimports, wholefunction)
    End Sub

    Public Function removeFuncLabels(line, label) As String
        removeFuncLabels = Replace(line, label, "")
    End Function
End Module
