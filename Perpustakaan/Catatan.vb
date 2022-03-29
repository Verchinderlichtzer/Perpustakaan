Public Class Catatan

    Dim Query As String

    Dim EntitasTerpilih As String
    Dim TanggalTerpilih As String
    Dim StatusTerpilih As String

    Dim FilterEntitas As String
    Dim FilterTanggal As String
    Dim FilterStatus As String

    Private Sub Catatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDGV()
        TDari.Value = Today
        TSampai.Value = Today
        QRL("SELECT Username FROM TBLUser ORDER BY Username")
        Do While DR.Read
            TUser.Items.Add(DR(0))
        Loop
        QRL("SELECT ID_Anggota, Nama FROM TBLAnggota ORDER BY Nama")
        Do While DR.Read
            TAnggota.Items.Add(DR(0) & " - " & DR(1))
        Loop
        QRL("SELECT ID_Buku, Judul FROM TBLBuku ORDER BY Judul")
        Do While DR.Read
            TBuku.Items.Add(DR(0) & " - " & DR(1))
        Loop
    End Sub

#Region "DGV"
    ReadOnly Baris As New Collection
    Dim JumlahData As Integer

    Dim FetchData As Integer = 1
    Dim CurrentPage As Integer = 1

    Sub Paging()
        DGV.Rows.Clear()
        If JumlahData Mod 15 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(JumlahData / 15) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 14
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3), Baris(x)(4), Baris(x)(5), Baris(x)(6), Baris(x)(7), Baris(x)(8), Baris(x)(9), Baris(x)(10))
            If x = Baris.Count Then Exit For
        Next
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(JumlahData / 15) = 0, 1, Math.Ceiling(JumlahData / 15))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(JumlahData / 15) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 15
        DS.Clear()
        DA.Fill(DS, FetchData, 15, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 15
        DS.Clear()
        DA.Fill(DS, FetchData, 15, 0)
        CurrentPage += 1
        Paging()
    End Sub

    Sub TampilDGV()
        JumlahData = 0
        Baris.Clear()
        QRL("SELECT Nama, Judul, FORMAT(TglPinjam, 'dd-MM-yyyy'), FORMAT(TglKembali, 'dd-MM-yyyy'), Telat, Rusak, Hilang, Keterangan, Denda, Status, Username FROM TBLAnggota INNER JOIN TBLPinjam ON TBLAnggota.ID_Anggota = TBLPinjam.ID_Anggota INNER JOIN TBLBuku ON TBLPinjam.ID_Buku = TBLBuku.ID_Buku WHERE ID > 0" & EntitasTerpilih & TanggalTerpilih & StatusTerpilih & " ORDER BY ID DESC")
        Do While DR.Read
            JumlahData += 1
            Baris.Add({DR(0), DR(1), DR(2), DR(3), DR(4), DR(5), DR(6), DR(7), DR(8), DR(9), DR(10)})
        Loop
        If Baris.Count = 0 Then
            DGV.Rows.Clear()
            Exit Sub
        End If
        Paging()
    End Sub

    Sub Filter()
        If FilterEntitas Is Nothing And FilterTanggal Is Nothing And FilterStatus Is Nothing Then
            LBLFilter.Text = "Semua Peminjaman"
        Else
            If Not Microsoft.VisualBasic.Left(FilterEntitas, 5) = " pada" And (FilterTanggal IsNot Nothing Or FilterStatus IsNot Nothing) Then
                LBLFilter.Text = "Peminjaman" & FilterEntitas & " pada buku" & FilterTanggal & FilterStatus
            Else
                LBLFilter.Text = "Peminjaman" & FilterEntitas & FilterTanggal & FilterStatus
            End If
        End If
    End Sub

    Private Sub PilihEntitas(sender As Object, e As EventArgs) Handles TUser.SelectedIndexChanged, TBuku.SelectedIndexChanged, TAnggota.SelectedIndexChanged
        FilterEntitas = Nothing
        If sender Is TUser Then
            EntitasTerpilih = " AND Username = '" & sender.SelectedItem & "'"
            FilterEntitas = " yang ditangani oleh " & sender.SelectedItem
        ElseIf sender Is TAnggota Then
            EntitasTerpilih = " AND TBLPinjam.ID_Anggota = " & Val(sender.SelectedItem.Substring(0, sender.SelectedItem.IndexOf(" ")))
            FilterEntitas = " oleh " & sender.SelectedItem.Substring(sender.SelectedItem.IndexOf("-") + 2)
        Else 'Buku
            EntitasTerpilih = " AND TBLPinjam.ID_Buku = " & Val(sender.SelectedItem.Substring(0, sender.SelectedItem.IndexOf(" ")))
            FilterEntitas = " pada ''" & sender.SelectedItem.Substring(sender.SelectedItem.IndexOf("-") + 2) & "''"
        End If
        FetchData = 1
        CurrentPage = 1
        Filter()
        TampilDGV()
    End Sub

    Private Sub PilihTanggal(sender As Object, e As EventArgs) Handles CBTglPinjam.CheckedChanged, CBTglKembali.CheckedChanged, TDari.ValueChanged, TSampai.ValueChanged
        FilterTanggal = Nothing
        TanggalTerpilih = Nothing
        If sender Is TDari And TDari.Value > TSampai.Value Then
            TSampai.Value = TDari.Value
        ElseIf sender Is TSampai And TSampai.Value < TDari.Value Then
            TDari.Value = TSampai.Value
        End If
        If CBTglPinjam.Checked = False And CBTglKembali.Checked = False Then
            TDari.Enabled = 0
            TSampai.Enabled = 0
            GoTo 1
        Else
            TDari.Enabled = 1
            TSampai.Enabled = 1
        End If
        Dim Dari As String = Format(TDari.Value, "dd-MM-yyyy")
        Dim Sampai As String = Format(TSampai.Value, "dd-MM-yyyy")
        If CBTglPinjam.Checked = True And CBTglKembali.Checked = True Then
            TanggalTerpilih = " AND ((TglPinjam BETWEEN '" & Format(TDari.Value, "MM-dd-yyyy") & "' AND '" & Format(TSampai.Value, "MM-dd-yyyy") & "') OR (TglKembali BETWEEN '" & Format(TDari.Value, "MM-dd-yyyy") & "' AND '" & Format(TSampai.Value, "MM-dd-yyyy") & "'))"
            FilterTanggal = " yang dipinjam atau dikembalikan"
        ElseIf CBTglPinjam.Checked = True Then
            TanggalTerpilih = " AND (TglPinjam BETWEEN '" & Format(TDari.Value, "MM-dd-yyyy") & "' AND '" & Format(TSampai.Value, "MM-dd-yyyy") & "')"
            FilterTanggal = " yang dipinjam"
        ElseIf CBTglKembali.Checked = True Then
            TanggalTerpilih = " AND (TglKembali BETWEEN '" & Format(TDari.Value, "MM-dd-yyyy") & "' AND '" & Format(TSampai.Value, "MM-dd-yyyy") & "')"
            FilterTanggal = " yang dikembalikan"
        End If
        If Dari = Sampai Then
            FilterTanggal &= " pada tanggal " & Dari
        Else
            FilterTanggal &= " antara tanggal " & Dari & " sampai " & Sampai
        End If
1:      FetchData = 1
        CurrentPage = 1
        Filter()
        TampilDGV()
    End Sub

    Private Sub PilihStatus(sender As Object, e As EventArgs) Handles RBHilang.CheckedChanged, RBDipinjam.CheckedChanged, RBDikembalikan.CheckedChanged
        FilterStatus = Nothing
        If RBDipinjam.Checked = True Then
            StatusTerpilih = " AND Status = 0"
            FilterStatus = " yang sedang dipinjam"
        ElseIf RBDikembalikan.Checked = True Then
            StatusTerpilih = " AND Status = 1 AND Hilang = 0"
            FilterStatus = " yang telah kembali"
        ElseIf RBHilang.Checked = True Then
            StatusTerpilih = " AND Hilang = 1"
            FilterStatus = " yang hilang"
        End If
        FetchData = 1
        CurrentPage = 1
        Filter()
        TampilDGV()
    End Sub
#End Region

End Class