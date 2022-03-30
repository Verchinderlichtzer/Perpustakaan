Public Class Dashboard

    Sub TampilProfil()
        QR("SELECT * FROM TBLInfo")
        TNama.Text = DR(0)
        TAlamat.Text = DR(1)
        TTelepon.Text = DR(2)
        TFax.Text = DR(3)
        TEmail.Text = DR(4)
        TWebsite.Text = DR(5)
        TPengurus.Text = DR(6)
        TJabatan.Text = DR(7)
        TBatasBuku.Text = DR(8)
        TBatasHari.Text = DR(9)
        BatasBuku = DR(8)
        BatasHari = DR(9)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilProfil()
        TampilDGV()
        Dim Lebar() As Integer = {5, 359, 69, 69, 69}
        Dim i = 0
        For Each x In DGV.Columns
            x.SortMode = DataGridViewColumnSortMode.NotSortable
            x.Width = Lebar(i)
            i += 1
        Next
        DGV.Columns(0).Visible = 0
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        LBLUserAktif.Text = UserAktif
        If UserAktif = "Admin" Then
            LBLBackupDB.Visible = 1
            LBLHapusPeminjaman.Visible = 1
            TNama.ReadOnly = 0
            TAlamat.ReadOnly = 0
            TTelepon.ReadOnly = 0
            TFax.ReadOnly = 0
            TEmail.ReadOnly = 0
            TWebsite.ReadOnly = 0
            TPengurus.ReadOnly = 0
            TJabatan.ReadOnly = 0
            TBatasBuku.ReadOnly = 0
            TBatasHari.ReadOnly = 0
        Else
            LBLBackupDB.Visible = 0
            LBLHapusPeminjaman.Visible = 0
            TNama.ReadOnly = 1
            TAlamat.ReadOnly = 1
            TTelepon.ReadOnly = 1
            TFax.ReadOnly = 1
            TEmail.ReadOnly = 1
            TWebsite.ReadOnly = 1
            TPengurus.ReadOnly = 1
            TJabatan.ReadOnly = 1
            TBatasBuku.ReadOnly = 1
            TBatasHari.ReadOnly = 1
        End If
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        QN("UPDATE TBLInfo SET Nama = '" & TNama.Text & "', Alamat = '" & TAlamat.Text & "', Telepon = '" & TTelepon.Text & "', Fax = '" & TFax.Text & "', Email = '" & TEmail.Text & "', Website = '" & TWebsite.Text & "', Pengurus = '" & TPengurus.Text & "', Jabatan = '" & TJabatan.Text & "'")
        Pesan("Info Perpustakaan berhasil diubah", 1)
    End Sub

    Private Sub BTNGantiPw_Click(sender As Object, e As EventArgs) Handles BTNGantiPw.Click
        QR("SELECT Pw FROM TBLUser WHERE Username = '" & UserAktif & "'")
        If TPwLama.Text <> DR(0) Then
            Pesan("Password salah.", 0)
        Else
            QN("UPDATE TBLUser SET Pw = '" & TPwBaru.Text & "' WHERE Username = '" & UserAktif & "'")
            Pesan("Password berhasil diubah.", 1)
            PanelGantiPw.Visible = 0
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef Msg As Message, Koentji As Keys) As Boolean
        If Koentji = Keys.Enter Then
            If TPwLama.Text <> "" And TPwBaru.Text <> "" Then BTNGantiPw.PerformClick() Else BTNSimpan.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(Msg, Koentji)
    End Function

    Private Sub CBGantiPw_CheckedChanged(sender As Object, e As EventArgs) Handles CBGantiPw.CheckedChanged
        TPwLama.Clear()
        TPwBaru.Clear()
        If CBGantiPw.Checked = True Then PanelGantiPw.Visible = 1 Else PanelGantiPw.Visible = 0
        TPwLama.Focus()
    End Sub

    Private Sub LBLBackupDB_Click(sender As Object, e As EventArgs) Handles LBLBackupDB.Click
        With SaveFileDialog1
            .FileName = "Perpustakaan" & Format(Today, "yyMMdd") & ".bak"
            .Filter = "Database SQL Server(*.bak)|*.bak"
            .FilterIndex = 1
        End With
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            QN("BACKUP DATABASE Perpustakaan TO DISK = '" & SaveFileDialog1.FileName & "'")
            Pesan("Database berhasil dibackup", 1)
        End If
    End Sub

    Private Sub LBLAuthor_Click(sender As Object, e As EventArgs) Handles LBLAuthor.Click
        Process.Start("https://www.facebook.com/Verchinderlichtzer/")
    End Sub

    Private Sub LBLHapusPeminjaman_Click(sender As Object, e As EventArgs) Handles LBLHapusPeminjaman.Click
        Dim Confirm As New Konfirmasi("Konfirmasi", "Hapus SEMUA data peminjaman?")
        If UserAktif = "Admin" AndAlso Confirm.ShowDialog() = DialogResult.Yes Then
            QN("DELETE FROM TBLPinjam")
            FetchData = 0
            CurrentPage = 1
            TampilDGV()
            Pesan("Semua data peminjaman berhasil dihapus.", 1)
        End If
    End Sub

    Private Sub Batas(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TBatasHari.Validating, TBatasBuku.Validating
        QN("UPDATE TBLInfo SET BatasBuku = " & Val(TBatasBuku.Text))
        QN("UPDATE TBLInfo SET BatasHari = " & Val(TBatasHari.Text))
    End Sub

    Private Sub Batas1(sender As Object, e As EventArgs) Handles TBatasHari.TextChanged, TBatasBuku.TextChanged
        If Val(sender.Text) = 0 Then sender.Text = 1
    End Sub

#Region "DGV"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(ID_Buku) FROM TBLBuku WHERE Judul LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Pengarang LIKE '%" & TCariData.Text & "%' OR Penerbit LIKE '%" & TCariData.Text & "%' OR Lokasi LIKE '%" & TCariData.Text & "%'")
        If DR(0) Mod 17 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 17) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 17) = 0, 1, Math.Ceiling(DR(0) / 17))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 17) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        QDGV("SELECT TBLPinjam.ID_Buku, MAX(Judul) AS [Judul Buku], COUNT(TBLPinjam.ID_Buku) AS Total, SUM(CAST(~Status AS INT)) AS Pinjam, SUM(CAST(Hilang AS INT)) AS Hilang FROM TBLBuku INNER JOIN TBLPinjam ON TBLBuku.ID_Buku = TBLPinjam.ID_Buku WHERE Judul LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Pengarang LIKE '%" & TCariData.Text & "%' OR Penerbit LIKE '%" & TCariData.Text & "%' OR Lokasi LIKE '%" & TCariData.Text & "%' GROUP BY TBLPinjam.ID_Buku ORDER BY 2", DGV, FetchData, 17, 0)
        Paging()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 17
        DS.Clear()
        DA.Fill(DS, FetchData, 17, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 17
        DS.Clear()
        DA.Fill(DS, FetchData, 17, 0)
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class
