Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If setPassBox.Text = "" Then
            MsgBox("You must set a password!", 0 + 16, "T3chyy's PC Locker")
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
