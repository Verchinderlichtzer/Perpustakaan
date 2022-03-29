Imports System.IO
Public Class Buku
    Sub Notis()
        BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
        TID.Text = 1
        Dim x = 0
        QRL("SELECT ID_Buku FROM TBLBuku ORDER BY ID_Buku ASC")
        Do While DR.Read
            x += 1
            If DR.HasRows Then
                If DR(0) = x Then
                    TID.Text = x + 1
                Else
                    TID.Text = x
                    Exit Sub
                End If
            End If
        Loop
    End Sub

    Sub TampilDaftar()
        TKategori.AutoCompleteCustomSource.Clear()
        TPengarang.AutoCompleteCustomSource.Clear()
        TPenerbit.AutoCompleteCustomSource.Clear()
        QRL("SELECT DISTINCT Kategori FROM TBLBuku ORDER BY Kategori")
        Do While DR.Read
            TKategori.AutoCompleteCustomSource.Add(DR(0))
        Loop
        QRL("SELECT DISTINCT Pengarang FROM TBLBuku ORDER BY Pengarang")
        Do While DR.Read
            TPengarang.AutoCompleteCustomSource.Add(DR(0))
        Loop
        QRL("SELECT DISTINCT Penerbit FROM TBLBuku ORDER BY Penerbit")
        Do While DR.Read
            TPenerbit.AutoCompleteCustomSource.Add(DR(0))
        Loop
    End Sub

    Sub Clear()
        Notis()
        TJudul.Clear()
        TampilDaftar()
        TKategori.Clear()
        TPengarang.Clear()
        TPenerbit.Clear()
        TTahun.Clear()
        THarga.Clear()
        TStok.Clear()
        TLokasi.Clear()
        PBBuku.Image = Nothing
        TCariData.Clear()
        TampilDGV()
        TJudul.Focus()
    End Sub

    Private Sub Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Dim Lebar() As Integer = {69, 306, 119, 142, 112, 54, 85, 54, 153}
        Dim i = 0
        For Each x In DGV.Columns
            x.SortMode = DataGridViewColumnSortMode.NotSortable
            x.Width = Lebar(i)
            i += 1
        Next
        DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(6).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub InputAngka(sender As Object, e As KeyPressEventArgs) Handles TTahun.KeyPress, TStok.KeyPress, THarga.KeyPress
        Angka(e)
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TJudul.TextChanged, THarga.TextChanged
        If TJudul.Text = "" Or THarga.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
    End Sub

    Private Sub PBBuku_Click(sender As Object, e As EventArgs) Handles PBBuku.Click
        Try
            With OpenFileDialog1
                .Filter = "Format Gambar(*.jpg; *.png; *.jpeg; *.gif)|*.jpg; *.png; *.jpeg; *.gif"
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PBBuku.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

#Region "CRUD"
    Sub CariID()
        QR("SELECT * FROM TBLBuku WHERE ID_Buku = " & Val(TID.Text))
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        Dim MS As New MemoryStream
        If PBBuku.Image IsNot Nothing Then PBBuku.Image.Save(MS, PBBuku.Image.RawFormat)
        QR("SELECT ID_Buku FROM TBLBuku WHERE ID_Buku = " & TID.Text)
        If Not DR.HasRows Then
            CMD = New SqlClient.SqlCommand("INSERT INTO TBLBuku VALUES(" & Val(TID.Text) & ",'" & TJudul.Text & "','" & TKategori.Text & "','" & TPengarang.Text & "','" & TPenerbit.Text & "','" & TTahun.Text & "'," & Val(THarga.Text) & "," & Val(TStok.Text) & ",'" & TLokasi.Text & "'," & IIf(PBBuku.Image Is Nothing, "NULL", "@gambar") & ")", CONN)
            If PBBuku.Image IsNot Nothing Then CMD.Parameters.Add("@gambar", SqlDbType.VarBinary).Value = MS.ToArray()
            CMD.ExecuteNonQuery()
            Pesan("Buku berhasil ditambah", 1)
        Else
            CMD = New SqlClient.SqlCommand("UPDATE TBLBuku SET Judul = '" & TJudul.Text & "', Kategori = '" & TKategori.Text & "', Pengarang = '" & TPengarang.Text & "', Penerbit = '" & TPenerbit.Text & "', Tahun = '" & TTahun.Text & "', Harga = " & Val(THarga.Text) & ", Stok = " & Val(TStok.Text) & ", Lokasi = '" & TLokasi.Text & "', Gambar = " & IIf(PBBuku.Image Is Nothing, "NULL", "@gambar") & " WHERE ID_Buku = " & TID.Text, CONN)
            If PBBuku.Image IsNot Nothing Then CMD.Parameters.Add("@gambar", SqlDbType.VarBinary).Value = MS.ToArray()
            CMD.ExecuteNonQuery()
            Pesan("Buku berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT ID_Buku FROM TBLPinjam WHERE ID_Buku = " & Val(TID.Text))
        If DR.HasRows Then
            Pesan("Buku pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        CariID()
        If Not DR.HasRows Then
            Pesan("ID Buku tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & DR(1) & "?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLBuku WHERE ID_Buku = " & Val(TID.Text) & "")
                Pesan("Buku berhasil dihapus", 1)
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 0
        CurrentPage = 1
        Clear()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef Msg As Message, Koentji As Keys) As Boolean
        If Koentji = Keys.Enter Then
            BTNSimpan.PerformClick()
            Return True
        ElseIf Koentji = Keys.Escape Then
            BTNHapus.PerformClick()
            Return True
        ElseIf Koentji = Keys.Oemtilde Then
            BTNClear.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(Msg, Koentji)
    End Function
#End Region

#Region "DGV"
    Dim FetchData As Integer
    Dim CurrentPage As Integer = 1

    Sub Paging()
        QR("SELECT COUNT(ID_Buku) FROM TBLBuku WHERE Judul LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Pengarang LIKE '%" & TCariData.Text & "%' OR Penerbit LIKE '%" & TCariData.Text & "%' OR Lokasi LIKE '%" & TCariData.Text & "%'")
        If DR(0) Mod 10 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(DR(0) / 10) + 1 Then DGVPrev.PerformClick()
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(DR(0) / 10) = 0, 1, Math.Ceiling(DR(0) / 10))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(DR(0) / 10) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        QDGV("SELECT ID_Buku AS [ID Buku], Judul, Kategori, Pengarang, Penerbit, Tahun, Harga, Stok, Lokasi FROM TBLBuku WHERE Judul LIKE '%" & TCariData.Text & "%' OR Kategori LIKE '%" & TCariData.Text & "%' OR Pengarang LIKE '%" & TCariData.Text & "%' OR Penerbit LIKE '%" & TCariData.Text & "%' OR Lokasi LIKE '%" & TCariData.Text & "%' ORDER BY ID_Buku", DGV, FetchData, 10, 0)
        Paging()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchData = 0
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
        BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
        TID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CariID()
        TJudul.Text = DR(1)
        TKategori.Text = DR(2)
        TPengarang.Text = DR(3)
        TPenerbit.Text = DR(4)
        TTahun.Text = DR(5)
        THarga.Text = DR(6)
        TStok.Text = DR(7)
        TLokasi.Text = DR(8)
        If IsDBNull(DR(9)) Then
            PBBuku.Image = Nothing
            Exit Sub
        End If
        Dim Gambar As Byte()
        Gambar = DR(9)
        Dim MS As New MemoryStream(Gambar)
        PBBuku.Image = Image.FromStream(MS)
    End Sub

    Private Sub DGVPrevClick(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 10
        DS.Clear()
        DA.Fill(DS, FetchData, 10, 0)
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNextClick(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 10
        DS.Clear()
        DA.Fill(DS, FetchData, 10, 0)
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class
