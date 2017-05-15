Imports System
Imports System.IO
Public Class MainForm
    Private Sub ofdButton_Click(sender As Object, e As EventArgs) Handles ofdButton.Click
        Dim fullfile As String
        Dim parts() As String

        If ofdHidden.ShowDialog = DialogResult.OK Then
            Try
                Console.WriteLine("opening file...")
                ' Open the file using a stream reader.
                Using sr As New StreamReader(ofdHidden.FileName)
                    fullfile = sr.ReadToEnd()
                End Using

                'split the file by line into an array called parts
                parts = fullfile.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)
                GlobalVariables.fileForUpload = parts
                loopForFuncStart(parts)
            Catch f As Exception
                Console.WriteLine("The file could not be read:")
                Console.WriteLine(f.Message)
            End Try
        End If
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Me.Close()
    End Sub
End Class
