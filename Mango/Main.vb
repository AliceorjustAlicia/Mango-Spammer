Imports System.Threading
Public Class Main

    Private WithEvents kbHook As New KeyboardHook

    Function SpamIt()
        Thread.Sleep(5000)
        timerSpamInterval.Enabled = True
        lblState.Text = "ON"
        lblState.ForeColor = Color.Green
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    Function StopIt()
        timerSpamInterval.Enabled = False
        lblState.Text = "OFF"
        lblState.ForeColor = Color.Red
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function

    Private Sub kbHook_KeyDown(ByVal Key As Keys) Handles kbHook.KeyDown
        If Key.ToString = "F2" And txtInput.Text = "" Or Key.ToString = "F2" And txtInterval.Text = "" Then
            MsgBox("Please fill the required fields before activating the spammer")

        ElseIf Key.ToString = "F2" And Not txtLoops.Text = "" And Not IsNumeric(txtLoops.Text) Then
            MsgBox("The value in loops is not a number")

        ElseIf Key.ToString = "F2" Then
            SpamIt()

        ElseIf Key.ToString = "F3" Then
            StopIt()
        End If
    End Sub

    Private Sub timerSpamInterval_Tick(sender As Object, e As EventArgs) Handles timerSpamInterval.Tick
        If txtLoops.Text = "" Then
            SendKeys.Send(txtInput.Text)
            SendKeys.Send("{ENTER}")
        Else
            For index As Integer = 1 To txtLoops.Text
                SendKeys.Send(txtInput.Text)
                SendKeys.Send("{ENTER}")
                StopIt()

            Next
        End If

    End Sub

    Private Sub btnContrast_Click(sender As Object, e As EventArgs) Handles btnContrast.Click
        If Me.Theme = MetroFramework.MetroThemeStyle.Light Then
            Me.Theme = MetroFramework.MetroThemeStyle.Dark
            btnContrast.Image = My.Resources.light
            iconInterval.Image = My.Resources.lightinterval
            iconLoops.Image = My.Resources.lightloop
            iconInput.Image = My.Resources.lightinput
            lblInfo.ForeColor = Color.White
            Me.Refresh()
        Else Me.Theme = MetroFramework.MetroThemeStyle.Light
            btnContrast.Image = My.Resources.dark
            iconInterval.Image = My.Resources.darkinterval
            iconLoops.Image = My.Resources.darkloop
            iconInput.Image = My.Resources.darkinput
            lblInfo.ForeColor = Color.Black
            Me.Refresh()
        End If


    End Sub
End Class