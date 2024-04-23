Public Class Form2
    Private Function GetIcnt() As String
        Return icnt
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs, icnt As String) Handles Button1.Click
        Dim icnt As String
        For icnt = 1 To 20
            If icnt Mod 2 <> 8 Then
                ListBox1.Items.Add(icnt)
            ElseIf icnt Then
            End If
        Next

    End Sub
End Class