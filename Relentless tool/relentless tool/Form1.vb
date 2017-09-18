Imports System.Net
Imports SKYPE4COMLib

Public Class Form1

    Dim oSkype As New SKYPE4COMLib.Skype
    Dim WithEvents Skype As New SKYPE4COMLib.Skype

    Private Sub MephButton6_Click(sender As Object, e As EventArgs) Handles MephButton6.Click
        Try
            oSkype.Attach()
            MephTheme1.Text = "Welcome " + oSkype.CurrentUser.FullName + " to the tool!"
            For Each user As SKYPE4COMLib.User In oSkype.Friends
                ListBox1.Items.Add(user.Handle)
                ListBox1.Items.Add(user.Handle)
            Next
        Catch ex As Exception
            MessageBox.Show("Connection Failed!", "Connections", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Start()
        'premium()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        premium()
    End Sub

    Private Sub premium()
        Try


            Dim premium As New WebClient
            Dim window As String = premium.DownloadString("")
            If window.Contains("7") Then
                MessageBox.Show("Hello there!" + vbNewLine + "If you are enjoying the free tool then" + vbNewLine + " Please consider buying the premium version." + vbNewLine + "Premium Features: Built in Skypebot, Stresser and No ads!", "Premium", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start("") ' Screenshot here
            End If

        Catch ex As Exception
            premium()
        End Try
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        Process.Start("https://www.youtube.com/channel/UCABiN8ShS22mqtN__1sYrLQ")
    End Sub

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub MephButton9_Click(sender As Object, e As EventArgs) Handles MephButton9.Click
        Label1.Text = 0
        Timer2.Interval = MephTextBox4.Text
        Timer2.Start()
        Timer9.Interval = MephTextBox4.Text
        Timer9.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        oSkype.SendMessage(ListBox1.SelectedItem, MephTextBox3.Text)
    End Sub

    Private Sub MephButton10_Click(sender As Object, e As EventArgs) Handles MephButton10.Click
        oSkype.SendMessage(ListBox1.SelectedItem, MephTextBox5.Text)
    End Sub

    Private Sub MephButton8_Click(sender As Object, e As EventArgs) Handles MephButton8.Click
        oSkype.SendMessage(ListBox1.SelectedItem, MephTextBox1.Text)
    End Sub

    Private Sub MephButton13_Click(sender As Object, e As EventArgs) Handles MephButton13.Click
        MsgBox("This sends a message to the contact based on how many contacts you have")
    End Sub

    Private Sub MephButton12_Click(sender As Object, e As EventArgs) Handles MephButton12.Click
        For Each user As User In oSkype.Friends
            oSkype.SendMessage(ListBox1.SelectedItem, MephTextBox6.Text)
        Next
    End Sub
    Private Sub MephButton14_Click(sender As Object, e As EventArgs) Handles MephButton14.Click
        If MephComboBox1.SelectedIndex = 0 Then
            oSkype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" + MephTextBox7.Text + "</ZapButton>"
        End If
        If MephComboBox1.SelectedIndex = 1 Then
            oSkype.CurrentUserProfile.RichMoodText = "<blink>" + MephTextBox7.Text + "</blink>"
        End If
    End Sub

    Private Sub MephButton15_Click(sender As Object, e As EventArgs) Handles MephButton15.Click
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        oSkype.CurrentUserProfile.MoodText = MephTextBox8.Text
    End Sub

    Private Sub MephButton16_Click(sender As Object, e As EventArgs) Handles MephButton16.Click
        Timer3.Stop()
    End Sub

    Private Sub MephButton18_Click(sender As Object, e As EventArgs) Handles MephButton18.Click
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        oSkype.CurrentUserProfile.FullName = MephTextBox9.Text
    End Sub

    Private Sub MephButton17_Click(sender As Object, e As EventArgs) Handles MephButton17.Click
        Timer4.Stop()
    End Sub

    Private Sub MephButton20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MephButton19_Click(sender As Object, e As EventArgs) Handles MephButton19.Click
        Timer5.Start()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        oSkype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
        If oSkype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline = True Then
            oSkype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
        End If
        If oSkype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway = True Then
            oSkype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        End If
        If Timer5.Enabled = False Then
            Threading.Thread.Sleep(1000)
            oSkype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
        End If
    End Sub

    Private Sub MephButton21_Click(sender As Object, e As EventArgs) Handles MephButton21.Click
        Timer5.Stop()
    End Sub

    Private Sub MephButton22_Click(sender As Object, e As EventArgs) Handles MephButton22.Click
        If MephComboBox1.SelectedIndex = 0 Then
            oSkype.CurrentUserProfile.FullName = MephTextBox12.Text
        End If
        If MephComboBox1.SelectedIndex = 1 Then
            oSkype.CurrentUserProfile.MoodText = MephTextBox12.Text
        End If
    End Sub

    Private Sub MephButton4_Click(sender As Object, e As EventArgs) Handles MephButton4.Click
        oSkype.Client.Start()
    End Sub

    Private Sub MephButton5_Click(sender As Object, e As EventArgs) Handles MephButton5.Click
        oSkype.Client.Shutdown()
    End Sub

    Private Sub MephButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MephButton23_Click(sender As Object, e As EventArgs) Handles MephButton23.Click
        oSkype.PlaceCall(ListBox1.SelectedItem)
    End Sub

    Private Sub MephButton11_Click(sender As Object, e As EventArgs) Handles MephButton11.Click
        Timer2.Stop()
        Timer9.Stop()
    End Sub

    Private Sub MephButton20_Click_1(sender As Object, e As EventArgs) Handles MephButton20.Click
        If MephComboBox1.SelectedIndex = 0 Then
            oSkype.CurrentUserStatus = TUserStatus.cusOnline
        End If
        If MephComboBox1.SelectedIndex = 1 Then
            oSkype.CurrentUserStatus = TUserStatus.cusAway
        End If
        If MephComboBox1.SelectedIndex = 2 Then
            oSkype.CurrentUserStatus = TUserStatus.cusDoNotDisturb
        End If
        If MephComboBox1.SelectedIndex = 3 Then
            oSkype.CurrentUserStatus = TUserStatus.cusInvisible
        End If
        If MephComboBox1.SelectedIndex = 4 Then
            oSkype.CurrentUserStatus = TUserStatus.cusOffline
        End If
    End Sub

    Private Sub MephButton24_Click(sender As Object, e As EventArgs) Handles MephButton24.Click
        oSkype.ActiveCalls(1).Finish()
    End Sub

    Private Sub MephButton26_Click(sender As Object, e As EventArgs) Handles MephButton26.Click
        Timer6.start()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        oSkype.PlaceCall(ListBox1.SelectedItem)
        Timer2.Interval = 0.05
        oSkype.ActiveCalls(1).Finish()
    End Sub

    Private Sub MephButton25_Click(sender As Object, e As EventArgs) Handles MephButton25.Click
        Timer6.Stop()
    End Sub

    Private Sub MephButton28_Click(sender As Object, e As EventArgs) Handles MephButton28.Click
        Process.Start("https://infectedxbox.com")
    End Sub
    Private Sub oskype_UserAuthorizationRequestReceived(pUser As User) Handles Skype.UserAuthorizationRequestReceived
        If MephToggleSwitch1.Checked = True And pUser.IsAuthorized = False Then
            pUser.IsAuthorized = True
            oSkype.SendMessage(pUser.Handle, "Auto-Accepted!" + vbNewLine + "(monkey) Relentless Skype tool <3 (monkey)")
        End If
    End Sub

    Private Sub MephButton29_Click(sender As Object, e As EventArgs) Handles MephButton29.Click
        MsgBox("Auto Accept friend request!")
    End Sub


    Private Sub MephButton30_Click(sender As Object, e As EventArgs) Handles MephButton30.Click
        oSkype.CurrentUserProfile.MoodText = "<a href=" + MephTextBox19.Text + ">" + MephTextBox16.Text + "</a>"
    End Sub

    Private Sub MephButton31_Click(sender As Object, e As EventArgs) Handles MephButton31.Click
        Timer7.Start()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        oSkype.CurrentUserProfile.MoodText = MephTextBox15.Text
        Timer8.Start()
        Timer7.Stop()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        oSkype.CurrentUserProfile.MoodText = MephTextBox10.Text
        Timer7.Start()
        Timer8.Stop()
    End Sub

    Private Sub MephButton32_Click(sender As Object, e As EventArgs) Handles MephButton32.Click
        Timer7.Stop()
        Timer8.Stop()
    End Sub



    Private Sub MephButton34_Click(sender As Object, e As EventArgs) Handles MephButton34.Click
        MephTextBox21.Text = Skype.User(MephTextBox20.Text).FullName.ToString()
        MephTextBox22.Text = Skype.User(MephTextBox20.Text).MoodText.ToString()
        MephTextBox23.Text = Skype.User(MephTextBox20.Text).PhoneMobile.ToString()
        MephTextBox24.Text = Skype.User(MephTextBox20.Text).Sex.ToString()
        MephTextBox25.Text = Skype.User(MephTextBox20.Text).Province.ToString()
    End Sub

    Private Sub MephButton33_Click(sender As Object, e As EventArgs) Handles MephButton33.Click
        oSkype.CurrentUserProfile.FullName = MephTextBox20.Text
        oSkype.CurrentUserProfile.MoodText = MephTextBox22.Text
        oSkype.CurrentUserProfile.PhoneMobile = MephTextBox23.Text
        oSkype.CurrentUserProfile.Sex = MephTextBox24.Text
        oSkype.CurrentUserProfile.Province = MephTextBox25.Text
    End Sub

    Private Sub MephButton36_Click(sender As Object, e As EventArgs) Handles MephButton36.Click
        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://api.skype.com/users/" + MephTextBox26.Text + "/profile/avatar")))
    End Sub

    Private Sub MephButton35_Click(sender As Object, e As EventArgs) Handles MephButton35.Click
        If PictureBox1.Image IsNot Nothing Then
            Me.PictureBox1.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, MephTextBox26.Text + " Avatar.jpg"))
            MsgBox("Image saved to desktop!")
        End If
    End Sub

    Private Sub MephButton37_Click(sender As Object, e As EventArgs) Handles MephButton37.Click
        Dim webClient As New System.Net.WebClient
        Try
            Dim Resolve As String = webClient.DownloadString("http://api.predator.wtf/resolver/?arguments=" + MephTextBox27.Text)
            MephTextBox27.Text = (Resolve)
        Catch ex As Exception
            MephTextBox27.Text = "IP Not found"
        End Try

    End Sub

    Private Sub MephButton38_Click(sender As Object, e As EventArgs) Handles MephButton38.Click
        Dim webClient As New System.Net.WebClient
        Try
            Dim Resolve As String = webClient.DownloadString("http://api.predator.wtf/lookup/?arguments=" + MephTextBox27.Text)
            MephTextBox28.Text = (Resolve)
        Catch ex As Exception
            MephTextBox28.Text = "Skype Not Found"
        End Try
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Label1.Text = Label1.Text + 1
    End Sub

    Private Sub MephButton39_Click(sender As Object, e As EventArgs) Handles MephButton39.Click
        MessageBox.Show("WARNING: This spammer requires a decent pc to run!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        overkill.show()
    End Sub
End Class
