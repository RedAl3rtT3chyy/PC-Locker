Imports Microsoft.Win32

Public Class Form2
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim systemRegistry As RegistryKey =
        Registry.CurrentUser.CreateSubKey(“Software\Microsoft\Windows\CurrentVersion\Policies\System”)
        systemRegistry.SetValue(“DisableTaskMgr”, 1)
        systemRegistry.Close()

    End Sub

    Private Sub Unlock_Click(sender As Object, e As EventArgs) Handles Unlock.Click
        If TextBox1.Text = Form1.setPassBox.Text Then
            MsgBox("Correct Password/PIN! Press OK to close.", 0 + 64, "T3chyy's PC Locker")
            Dim systemRegistry As RegistryKey =
            Registry.CurrentUser.CreateSubKey(“Software\Microsoft\Windows\CurrentVersion\Policies\System”)
            systemRegistry.SetValue(“DisableTaskMgr”, 0)
            systemRegistry.Close()
            Me.Close()
            Form1.Close()
        Else
            MsgBox("Wrong Password/PIN! Try again.", 0 + 16, "T3chyy's PC Locker")
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class