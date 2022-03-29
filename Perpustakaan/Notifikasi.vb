Public Class Notifikasi
    Enum AlertTypeEnum
        Gagal
        Berhasil
    End Enum

    Dim x, y As Integer
    Public Sub SetAlert(msg As String, type As AlertTypeEnum)
        Opacity = 0
        StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 30
            fname = "Peringatan " & i.ToString
            Dim f As Notifikasi = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i
                Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5
        Select Case type
            Case AlertTypeEnum.Berhasil
                Notif.Values.Image = My.Resources.berhasil
                BackColor = Color.ForestGreen
            Case AlertTypeEnum.Gagal
                Notif.Values.Image = My.Resources.gagal
                BackColor = Color.Firebrick
        End Select
        Notif.Text = msg
        TopMost = 1
        ShowIcon = 0
        ShowInTaskbar = 0
        Show()
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Enum ActionEnum
        Wait
        Start
        Close
    End Enum

    Private Action As ActionEnum = ActionEnum.Start

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case Action
            Case ActionEnum.Start
                Timer1.Interval = 1
                Opacity += 0.1
                If x < Location.X Then
                    Left -= 1
                ElseIf Opacity = 1 Then
                    Action = ActionEnum.Wait
                End If
            Case ActionEnum.Wait
                Timer1.Interval = 2500
                Action = ActionEnum.Close
            Case ActionEnum.Close
                Timer1.Interval = 1
                Opacity -= 0.1
                Left -= 3
                If Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property
End Class