Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "456" Then
            MsgBox("cracked")
        Else
            MsgBox("wrong")
        End If
    End Sub
End Class
