Imports System.Data.SqlClient, Microsoft.Reporting.WinForms
Public Class Pinjam

    Dim ID As Integer = 1
    Dim RowTerpilih As Integer
    Dim Before As String

    Dim Total As Integer
    Dim Kembali As Integer
    Dim Dipinjam As Integer
    Dim Telat As Integer
    Dim Rusak As Integer
    Dim Hilang As Integer

    Dim TampilNama As ReportParameter
    Dim TampilAlamat As ReportParameter
    Dim TampilTelepon As ReportParameter
    Dim TampilFax As ReportParameter
    Dim TampilEmail As ReportParameter
    Dim TampilWebsite As ReportParameter
    Dim TampilPengurus As ReportParameter
    Dim TampilJabatan As ReportParameter
    Dim Params As ReportParameter()

    Sub Notis()
        QR("SELECT ID FROM TBLPinjam ORDER BY ID DESC")
        If DR.HasRows Then ID = DR(0) + 1
    End Sub

    Sub Clear()
        TAnggota.SelectedIndex = -1
        TCariData.Clear()
        TampilDGVBuku()
        DGV.Rows.Clear()
        DGVPageCounter.Text = "1 / 1"
        DGVPrev.Enabled = 0
        DGVNext.Enabled = 0
        Total = 0
        Kembali = 0
        Dipinjam = 0
        Telat = 0
        Rusak = 0
        Hilang = 0
        BTNPrint.Enabled = 0
        Isi()
    End Sub

    Private Sub Pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        TAnggota.Items.Clear()
        QRL("SELECT ID_Anggota, Nama FROM TBLAnggota ORDER BY Nama")
        Do While DR.Read
            TAnggota.Items.Add(DR(0) & " - " & DR(1))
        Loop
        DGVBuku.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVBuku.Columns(0).Visible = 0
        DGVBuku.Columns(2).Visible = 0
        DGVBuku.Columns(3).Visible = 0

        QR("SELECT * FROM TBLInfo")
        TampilNama = New ReportParameter("Nama", DR(0).ToString)
        TampilAlamat = New ReportParameter("Alamat", DR(1).ToString)
        TampilTelepon = New ReportParameter("Telepon", DR(2).ToString)
        TampilFax = New ReportParameter("Fax", DR(3).ToString)
        TampilEmail = New ReportParameter("Email", DR(4).ToString)
        TampilWebsite = New ReportParameter("Website", DR(5).ToString)
        TampilPengurus = New ReportParameter("Pengurus", DR(6).ToString)
        TampilJabatan = New ReportParameter("Jabatan", DR(7).ToString)
        Params = {TampilNama, TampilAlamat, TampilTelepon, TampilFax, TampilEmail, TampilWebsite, TampilPengurus, TampilJabatan}
    End Sub

    Private Sub TAnggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TAnggota.SelectedIndexChanged
        If TAnggota.SelectedIndex = -1 Then
            DGV.Rows.Clear()
            Exit Sub
        End If
        BTNPrint.Enabled = 1
        TampilDGV()
        Hitung()
        Isi()
    End Sub

    Sub Hitung()
        QR("SELECT COUNT(ID) FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))))
        Total = DR(0)
        QR("SELECT COUNT(ID) FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " AND Status = 1 AND Hilang = 0")
        Kembali = DR(0)
        QR("SELECT COUNT(ID) FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " AND Status = 0")
        Dipinjam = DR(0)
        QR("SELECT COUNT(ID) FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " AND Telat = 1")
        Telat = DR(0)
        QR("SELECT COUNT(ID) FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " AND Rusak = 1")
        Rusak = DR(0)
        QR("SELECT COUNT(ID) FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " AND Hilang = 1")
        Hilang = DR(0)
    End Sub

    Sub Isi()
        TTotal.Text = Total
        TKembali.Text = Kembali
        TDipinjam.Text = Dipinjam
        TTelat.Text = Telat
        TRusak.Text = Rusak
        THilang.Text = Hilang
    End Sub

#Region "Print / Delete / Clear"
    Private Sub BTNPrint_Click(sender As Object, e As EventArgs) Handles BTNPrint.Click
        Dim CurrentReportDataSource = New ReportDataSource()
        Rdt.Clear()
        Terlapor.Show()
        Terlapor.RV.LocalReport.ReportEmbeddedResource = "Perpustakaan.LaporanPinjam.rdlc"
        CurrentReportDataSource.Name = "DataPinjam"
        CurrentReportDataSource.Value = TBLPinjamBindingSource
        Terlapor.RV.LocalReport.DataSources.Add(CurrentReportDataSource)
        DA = New SqlDataAdapter("SELECT Nama, Alamat, Telepon, Email, Judul, TglPinjam, TglKembali, Keterangan FROM TBLAnggota INNER JOIN TBLPinjam ON TBLAnggota.ID_Anggota = TBLPinjam.ID_Anggota INNER JOIN TBLBuku ON TBLPinjam.ID_Buku = TBLBuku.ID_Buku WHERE TBLPinjam.ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " ORDER BY ID DESC", CONN)
        DA.Fill(Rdt.TBLPinjam)
        For Each param As ReportParameter In Params
            Terlapor.RV.LocalReport.SetParameters(param)
        Next
        Terlapor.RV.SetDisplayMode(DisplayMode.PrintLayout)
        Terlapor.RV.ZoomMode = ZoomMode.Percent
        Terlapor.RV.ZoomPercent = 100
        Terlapor.RV.RefreshReport()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT ID FROM TBLPinjam WHERE ID = " & DGV.Rows(RowTerpilih).Cells(0).Value)
        If Not DR.HasRows Then
            Pesan("Pilih peminjaman di atas.", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus peminjaman buku terpilih?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLPinjam WHERE ID = " & DGV.Rows(RowTerpilih).Cells(0).Value)
                If DGV.Rows(RowTerpilih).Cells(7).Value = 0 Then 'Masih Utuh
                    QN("UPDATE TBLBuku SET Stok += 1 WHERE ID_Buku = " & DGV.Rows(RowTerpilih).Cells(1).Value)
                End If
                Pesan("Berhasil dihapus", 1)
                TampilDGV()
                TampilDGVBuku()
                Hitung()
                Isi()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 1
        CurrentPage = 1
        FetchData = 0
        CurrentPageBuku = 1
        Clear()
    End Sub
#End Region

#Region "DGVBarang"
    Dim FetchBuku As Integer
    Dim CurrentPageBuku As Integer = 1
    Sub PagingBuku()
        QR("SELECT COUNT(ID_Buku) FROM TBLBuku WHERE Judul LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Pengarang LIKE '%" & TCariData.Text & "%' OR Penerbit LIKE '%" & TCariData.Text & "%'")
        If DR(0) Mod 15 = 0 And CurrentPageBuku > 1 And CurrentPageBuku = Math.Ceiling(DR(0) / 15) + 1 Then DGVBukuPrev.PerformClick()
        DGVBukuPageCounter.Text = CurrentPageBuku & " / " & IIf(Math.Ceiling(DR(0) / 15) = 0, 1, Math.Ceiling(DR(0) / 15))
        If CurrentPageBuku = 1 Then DGVBukuPrev.Enabled = 0 Else DGVBukuPrev.Enabled = 1
        If CurrentPageBuku >= Math.Ceiling(DR(0) / 15) Then DGVBukuNext.Enabled = 0 Else DGVBukuNext.Enabled = 1
    End Sub

    Sub TampilDGVBuku()
        FetchData = 0
        CurrentPageBuku = 1
        QDGV("SELECT ID_Buku, Judul AS [Daftar Buku], Harga, Stok FROM TBLBuku WHERE (Judul LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Pengarang LIKE '%" & TCariData.Text & "%' OR Penerbit LIKE '%" & TCariData.Text & "%') AND Stok > 0 ORDER BY Judul", DGVBuku, FetchBuku, 15, 0)
        PagingBuku()
    End Sub

    Private Sub TCariBarang_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchBuku = 0
        CurrentPageBuku = 1
        TampilDGVBuku()
    End Sub

    Private Sub DGVBuku_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVBuku.CellMouseClick
        If e.RowIndex < 0 Or TAnggota.SelectedIndex = -1 Then Exit Sub
        QR("SELECT ID_Buku FROM TBLPinjam WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " AND ID_Buku = " & DGVBuku.Rows(e.RowIndex).Cells(0).Value & " AND Status = 0")
        If Dipinjam > BatasBuku Then
            Pesan("Peminjaman melampaui batas", 0)
            Exit Sub
        ElseIf Dipinjam = BatasBuku Then
            Pesan("Peminjaman mencapai batas", 0)
            Exit Sub
        ElseIf DR.HasRows Then
            Pesan("Buku sedang dipinjam", 0)
            Exit Sub
        End If
        Notis()
        QN("INSERT INTO TBLPinjam VALUES(" & ID & "," & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & "," & DGVBuku.Rows(e.RowIndex).Cells(0).Value & ",GETDATE(),DATEADD(DAY, " & BatasHari & ", GETDATE()),0,0,0,NULL,0,0,'" & UserAktif & "')")
        QN("UPDATE TBLBuku SET Stok -= 1 WHERE ID_Buku = " & DGVBuku.Rows(e.RowIndex).Cells(0).Value)
        Total += 1
        Dipinjam += 1
        If DGVBuku.Rows(e.RowIndex).Cells(3).Value = 1 Then DGVBuku.Rows.Remove(DGVBuku.CurrentRow)
        Isi()
        TampilDGV()
    End Sub

    Private Sub DGVBukuPrevClick(sender As Object, e As EventArgs) Handles DGVBukuPrev.Click
        FetchBuku -= 15
        DS.Clear()
        DA.Fill(DS, FetchBuku, 15, 0)
        CurrentPageBuku -= 1
        PagingBuku()
    End Sub

    Private Sub DGVBukuNextClick(sender As Object, e As EventArgs) Handles DGVBukuNext.Click
        FetchBuku += 15
        DS.Clear()
        DA.Fill(DS, FetchBuku, 15, 0)
        CurrentPageBuku += 1
        PagingBuku()
    End Sub
#End Region

#Region "DGV"
    ReadOnly Baris As New Collection
    Dim JumlahData As Integer

    Dim FetchData As Integer = 1
    Dim CurrentPage As Integer = 1

    Sub Paging()
        DGV.Rows.Clear()
        If JumlahData Mod 15 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(JumlahData / 15) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 14
            If x = Baris.Count + 1 Then Exit For
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4), Baris(x)(5), Baris(x)(6), Baris(x)(7), Baris(x)(8), Baris(x)(9), Baris(x)(10), Baris(x)(11))
            If IsDBNull(Baris(x)(4)) Then
                DGV.Rows(x - 1).Cells(6).ReadOnly = 1
                DGV.Rows(x - 1).Cells(7).ReadOnly = 1
                DGV.Rows(x - 1).Cells(8).ReadOnly = 1
                DGV.Rows(x - 1).Cells(9).ReadOnly = 1
                DGV.Rows(x - 1).Cells(10).ReadOnly = 1
                Continue For
            End If
            If Baris(x)(7) = True Then
                DGV.Rows(x - 1).Cells(6).ReadOnly = 1
            ElseIf Baris(x)(7) = False Then
                DGV.Rows(x - 1).Cells(6).ReadOnly = 0
            End If
            If Baris(x)(10) = True Then
                DGV.Rows(x - 1).Cells(6).ReadOnly = 1
                DGV.Rows(x - 1).Cells(7).ReadOnly = 1
            ElseIf Baris(x)(10) = False Then
                DGV.Rows(x - 1).Cells(6).ReadOnly = 0
                DGV.Rows(x - 1).Cells(7).ReadOnly = 0
            End If
            If Baris(x)(7) = False And Baris(x)(10) = False And CDate(Baris(x)(4)) < Today Then
                DGV.Rows(x - 1).Cells(4).Style.ForeColor = Color.FromArgb(220, 53, 69)
                DGV.Rows(x - 1).Cells(4).Style.SelectionForeColor = Color.FromArgb(220, 53, 69)
                DGV.Rows(x - 1).Cells(5).Value = 1
                QN("UPDATE TBLPinjam SET Telat = 1 WHERE ID = " & DGV.Rows(x - 1).Cells(0).Value)
            Else
                DGV.Rows(x - 1).Cells(4).Style.ForeColor = Color.FromArgb(64, 64, 64)
                DGV.Rows(x - 1).Cells(4).Style.SelectionForeColor = Color.FromArgb(64, 64, 64)
            End If
        Next
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(JumlahData / 15) = 0, 1, Math.Ceiling(JumlahData / 15))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(JumlahData / 15) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        FetchData = 1
        CurrentPage = 1
        JumlahData = 0
        Baris.Clear()
        QRL("SELECT ID, TBLPinjam.ID_Buku, Judul, FORMAT(TglPinjam, 'dd-MM-yyyy'), FORMAT(TglKembali, 'dd-MM-yyyy'), Telat, Rusak, Hilang, Keterangan, Denda, Status, Harga FROM TBLPinjam INNER JOIN TBLBuku ON TBLPinjam.ID_Buku = TBLBuku.ID_Buku WHERE ID_Anggota = " & Val(TAnggota.SelectedItem.Substring(0, TAnggota.SelectedItem.IndexOf(" "))) & " ORDER BY ID DESC")
        Do While DR.Read
            JumlahData += 1
            Baris.Add({DR(0), DR(1), DR(2), DR(3), DR(4), DR(5), DR(6), DR(7), DR(8), DR(9), DR(10), DR(11)})
        Loop
        If Baris.Count = 0 Then
            DGV.Rows.Clear()
            Exit Sub
        End If
        Paging()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        RowTerpilih = DGV.Rows(e.RowIndex).Index
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If TAnggota.SelectedIndex = -1 Or e.RowIndex < 0 OrElse IsDBNull(DGV.Rows(e.RowIndex).Cells(4).Value) Then Exit Sub
        DGV.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If e.ColumnIndex = 6 Then 'Rusak
            If DGV.Rows(e.RowIndex).Cells(6).ReadOnly = True Then Exit Sub
            QN("UPDATE TBLPinjam SET Rusak = " & DGV.Rows(e.RowIndex).Cells(6).Value & " WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
            If DGV.Rows(e.RowIndex).Cells(6).Value = 1 Then Rusak += 1 Else Rusak -= 1
        ElseIf e.ColumnIndex = 7 Then 'Hilang
            If DGV.Rows(e.RowIndex).Cells(7).ReadOnly = True Then Exit Sub
            QN("UPDATE TBLPinjam SET Hilang = " & DGV.Rows(e.RowIndex).Cells(7).Value & " WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
            If DGV.Rows(e.RowIndex).Cells(7).Value = 1 Then
                Hilang += 1
                DGV.Rows(e.RowIndex).Cells(9).Value = DGV.Rows(e.RowIndex).Cells(11).Value
                QN("UPDATE TBLPinjam SET Denda = " & DGV.Rows(e.RowIndex).Cells(11).Value & " WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
                If DGV.Rows(e.RowIndex).Cells(5).Value = 1 Then
                    QN("UPDATE TBLPinjam SET Telat = 0 WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
                    DGV.Rows(e.RowIndex).Cells(5).Value = 0
                    Telat -= 1
                End If
                If DGV.Rows(e.RowIndex).Cells(6).Value = 1 Then
                    QN("UPDATE TBLPinjam SET Rusak = 0 WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
                    DGV.Rows(e.RowIndex).Cells(6).Value = 0
                    Rusak -= 1
                End If
                DGV.Rows(e.RowIndex).Cells(6).ReadOnly = 1
            Else
                Hilang -= 1
                DGV.Rows(e.RowIndex).Cells(9).Value = 0
                QN("UPDATE TBLPinjam SET Denda = 0 WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
                If CDate(DGV.Rows(e.RowIndex).Cells(4).Value) < Today Then
                    QN("UPDATE TBLPinjam SET Telat = 1 WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
                    DGV.Rows(e.RowIndex).Cells(5).Value = 1
                    Telat += 1
                End If
                DGV.Rows(e.RowIndex).Cells(6).ReadOnly = 0
            End If
        ElseIf e.ColumnIndex = 10 Then 'Status
            If DGV.Rows(e.RowIndex).Cells(10).ReadOnly = True Then Exit Sub
            QN("UPDATE TBLPinjam SET Status = " & DGV.Rows(e.RowIndex).Cells(10).Value & " WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
            If DGV.Rows(e.RowIndex).Cells(10).Value = 1 Then
                DGV.Rows(e.RowIndex).Cells(6).ReadOnly = 1
                DGV.Rows(e.RowIndex).Cells(7).ReadOnly = 1
                Dipinjam -= 1
                If DGV.Rows(e.RowIndex).Cells(7).Value = 0 Then
                    QN("UPDATE TBLBuku SET Stok += 1 WHERE ID_Buku = " & DGV.Rows(e.RowIndex).Cells(1).Value)
                    Kembali += 1
                End If
            ElseIf DGV.Rows(e.RowIndex).Cells(10).Value = 0 Then
                DGV.Rows(e.RowIndex).Cells(6).ReadOnly = 0
                DGV.Rows(e.RowIndex).Cells(7).ReadOnly = 0
                Dipinjam += 1
                If DGV.Rows(e.RowIndex).Cells(7).Value = 0 Then
                    QN("UPDATE TBLBuku SET Stok -= 1 WHERE ID_Buku = " & DGV.Rows(e.RowIndex).Cells(1).Value)
                    Kembali -= 1
                End If
            End If
            TampilDGVBuku()
        End If
        If DGV.Rows(e.RowIndex).Cells(7).Value = 0 And DGV.Rows(e.RowIndex).Cells(10).Value = 0 And CDate(DGV.Rows(e.RowIndex).Cells(4).Value) < Today Then
            DGV.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.FromArgb(220, 53, 69)
            DGV.Rows(e.RowIndex).Cells(4).Style.SelectionForeColor = Color.FromArgb(220, 53, 69)
        Else
            DGV.Rows(e.RowIndex).Cells(4).Style.ForeColor = Color.FromArgb(64, 64, 64)
            DGV.Rows(e.RowIndex).Cells(4).Style.SelectionForeColor = Color.FromArgb(64, 64, 64)
        End If
        Isi()
    End Sub

    Private Sub DGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        Dim Angka As TextBox = CType(e.Control, TextBox)
        Dim Tanggal As TextBox = CType(e.Control, TextBox)
        RemoveHandler Tanggal.KeyPress, AddressOf Tanggal_KeyPress
        RemoveHandler Angka.KeyPress, AddressOf Angka_KeyPress
        If DGV.CurrentCell.ColumnIndex = 4 Then
            AddHandler Tanggal.KeyPress, AddressOf Tanggal_KeyPress
        ElseIf DGV.CurrentCell.ColumnIndex = 9 Then
            AddHandler Angka.KeyPress, AddressOf Angka_KeyPress
        End If
    End Sub

    Private Sub DGV_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGV.CellBeginEdit
        Before = Nothing
        If IsDBNull(DGV.CurrentCell.Value) Then Exit Sub
        Before = DGV.CurrentCell.Value
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If Not (e.ColumnIndex = 4 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9) Then Exit Sub
        If (e.ColumnIndex = 4 AndAlso IsDate(DGV.CurrentCell.Value) AndAlso CDate(DGV.Rows(e.RowIndex).Cells(4).Value) > CDate(DGV.Rows(e.RowIndex).Cells(3).Value) And (DGV.CurrentCell.Value Like "##-##-####" Or DGV.CurrentCell.Value Like "##-#-####" Or DGV.CurrentCell.Value Like "#-##-####" Or DGV.CurrentCell.Value Like "#-#-####")) Or (Not e.ColumnIndex = 4 And True) Then GoTo 2 Else GoTo 1
1:      DGV.CurrentCell.Value = Before
        Pesan("Data tidak valid", 0)
        Exit Sub
2:      If e.ColumnIndex = 4 Then
            QN("EXEC UpdateKembali '" & DGV.Rows(e.RowIndex).Cells(4).Value & "'," & DGV.Rows(e.RowIndex).Cells(0).Value)
            DGV.Rows(e.RowIndex).Cells(6).ReadOnly = 0
            DGV.Rows(e.RowIndex).Cells(7).ReadOnly = 0
            DGV.Rows(e.RowIndex).Cells(8).ReadOnly = 0
            DGV.Rows(e.RowIndex).Cells(9).ReadOnly = 0
            DGV.Rows(e.RowIndex).Cells(10).ReadOnly = 0
        ElseIf e.ColumnIndex = 8 Then
            QN("UPDATE TBLPinjam SET Keterangan = '" & DGV.Rows(e.RowIndex).Cells(8).Value & "' WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
        ElseIf e.ColumnIndex = 9 Then
            QN("UPDATE TBLPinjam SET Denda = " & Val(DGV.Rows(e.RowIndex).Cells(9).Value) & " WHERE ID = " & DGV.Rows(e.RowIndex).Cells(0).Value)
        End If
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 15
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 15
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class
