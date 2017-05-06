Imports SKYPE4COMLib
Public Class overkill

    Dim oSkype As New SKYPE4COMLib.Skype
    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Label1.Text = 0
        If MephTextBox1.Text = "t" Or MephTextBox2.Text = "live:jennye_77" Then
            MsgBox("This skype account is blacklisted!")
        Else

            Timer1.Start()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each user As User In oSkype.Friends
            oSkype.SendMessage(MephTextBox1.Text, MephTextBox2.Text)
        Next
        Label1.Text = Label1.Text + 150
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For Each user As User In oSkype.Friends
            oSkype.SendMessage(MephTextBox1.Text, MephTextBox2.Text)
        Next
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub overkill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oSkype.Attach()
    End Sub
End Class