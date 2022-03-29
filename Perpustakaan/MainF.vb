Imports MadMilkman.Ini
Public Class MainF
    Friend Uc As UserControl
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub LBLTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub LBLTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseMove
        If MoveForm Then Location += e.Location - MoveForm_MousePosition
    End Sub

    Public Sub LBLTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles LBLTitle.MouseUp
        If e.Button = MouseButtons.Left Then MoveForm = 0
    End Sub

    Sub HakAkses()
        Dim Kolom = 0
        If UserAktif.ToString.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then BTNUser.Enabled = 1 Else BTNUser.Enabled = 0
        QR("SELECT Anggota, Buku, Pinjam FROM TBLUser WHERE Username = '" & UserAktif & "'")
        Dim BTNMenuAkses() As Object = {BTNAnggota, BTNBuku, BTNPinjam} 'Semua BTNMenu, kecuali User dan Kategori Lain
        For Each BTN In BTNMenuAkses
            If DR(Kolom) = 0 Then
                BTN.Enabled = 0
                BTN.Checked = 0
            Else
                BTN.Enabled = 1
            End If
            Kolom += 1
        Next
    End Sub

    Private Sub BTNForm(sender As Object, e As EventArgs) Handles Thumbnail.Click, BTNUser.Click, BTNPinjam.Click, BTNCatatan.Click, BTNBuku.Click, BTNAnggota.Click
        PanelForm.Controls.Clear()
        HakAkses()
        Dim BTNMenu() As Object = {BTNUser, BTNAnggota, BTNBuku, BTNPinjam, BTNCatatan} 'Semua BTNMenu
        For Each x In BTNMenu
            x.Checked = 0
            If x Is sender Then x.Checked = 1
        Next
        If sender Is Thumbnail Then
            LBLTitle.Text = "Dashboard"
            LBLTitle.Values.Image = My.Resources.title_home
            Uc = New Dashboard
        ElseIf sender Is BTNUser Then
            LBLTitle.Text = "User"
            LBLTitle.Values.Image = My.Resources.title_user
            Uc = New User
        ElseIf sender Is BTNAnggota Then
            LBLTitle.Text = "Anggota"
            LBLTitle.Values.Image = My.Resources.title_anggota
            Uc = New Anggota
        ElseIf sender Is BTNBuku Then
            LBLTitle.Text = "Buku"
            LBLTitle.Values.Image = My.Resources.title_buku
            Uc = New Buku
        ElseIf sender Is BTNPinjam Then
            LBLTitle.Text = "Pinjam"
            LBLTitle.Values.Image = My.Resources.title_pinjam
            Uc = New Pinjam
        ElseIf sender Is BTNCatatan Then
            LBLTitle.Text = "Catatan"
            LBLTitle.Values.Image = My.Resources.title_catatan
            Uc = New Catatan
        End If
        PanelForm.Controls.Add(Uc)
    End Sub

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HakAkses()
        Thumbnail.PerformClick()
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Dim Ini As New IniFile
        Ini.Load(Path & "\Rdt.ini")
        Ini.Sections("konfigurasi").Keys("cookies").Value = 0
        Ini.Save(Path & "\Rdt.ini")
        Visible = 0
        Login.Show()
        Login.TUsername.Clear()
        Login.TPassword.Clear()
        Login.CBCookies.Checked = 0
        Login.TUsername.Focus()
    End Sub

    Private Sub BTNMinimize_Click(sender As Object, e As EventArgs) Handles BTNMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNClose_Click(sender As Object, e As EventArgs) Handles BTNClose.Click
        Application.ExitThread()
    End Sub

    Private Sub MainF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property
End Class