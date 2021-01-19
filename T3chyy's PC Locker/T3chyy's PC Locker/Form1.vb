''Coded by T3chyy

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If setPassBox.Text = "" Then
            ''If password box is empty it throws an error.
            MsgBox("You must set a password!", 0 + 16, "T3chyy's PC Locker")
        Else
            ''If text is present in password box. Opens the lock screen and hides the form.
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
