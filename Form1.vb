Public Class Form1
    Private Const V As String = "done"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sInput As String
        sInput = InputBox("")
        Do While sInput.ToLower <>
            ListBox1.Items.Add(sInput)
            sInput = Input("")
        Loop
    End Sub

    Private Function Input(v As String) As String
        Throw New NotImplementedException()
    End Function
End Class
