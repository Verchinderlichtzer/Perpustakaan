Public Class User

    Sub Clear()
        TUsername.Clear()
        TPassword.Clear()
        TCariData.Clear()
        TampilDGV()
        TUsername.Focus()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub Valid(sender As Object, e As EventArgs) Handles TUsername.TextChanged, TPassword.TextChanged
        If TUsername.Text = "" Or TUsername.Text.Equals("Admin", StringComparison.OrdinalIgnoreCase) Or TPassword.Text = "" Then BTNSimpan.Enabled = 0 Else BTNSimpan.Enabled = 1
        CariID()
        If Not DR.HasRows Then
            BTNSimpan.Values.Image = My.Resources.crud_simpan_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_simpan_common
        Else
            BTNSimpan.Values.Image = My.Resources.crud_edit_pressed
            BTNSimpan.Values.ImageStates.ImageNormal = My.Resources.crud_edit_common
        End If
    End Sub

#Region "CRUD"
    Sub CariID()
        QR("SELECT Username FROM TBLUser WHERE Username = '" & TUsername.Text & "'")
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        CariID()
        If Not DR.HasRows Then
            QN("INSERT INTO TBLUser VALUES('" & TUsername.Text & "','" & TPassword.Text & "', 0, 0, 0)")
            Pesan("User berhasil ditambah", 1)
        Else
            QN("UPDATE TBLUser SET Pw = '" & TPassword.Text & "' WHERE Username = '" & TUsername.Text & "'")
            Pesan("User berhasil diubah", 1)
        End If
        Clear()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        QR("SELECT Username FROM TBLPinjam WHERE Username = '" & TUsername.Text & "'")
        If DR.HasRows Then
            Pesan("User pernah terlibat dalam transaksi", 0)
            Exit Sub
        End If
        CariID()
        If Not DR.HasRows Then
            Pesan("Username tidak valid", 0)
        Else
            Dim Confirm As New Konfirmasi("Konfirmasi Hapus", "Hapus " & DR(0) & "?")
            If Confirm.ShowDialog() = DialogResult.Yes Then
                QN("DELETE FROM TBLUser WHERE Username = '" & TUsername.Text & "'")
                Pesan("User berhasil dihapus", 1)
                Clear()
            End If
        End If
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        FetchData = 1
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
    ReadOnly Baris As New Collection
    Dim JumlahData As Integer

    Dim FetchData As Integer = 1
    Dim CurrentPage As Integer = 1

    Sub Paging()
        DGV.Rows.Clear()
        If JumlahData Mod 14 = 0 And CurrentPage > 1 And CurrentPage = Math.Ceiling(JumlahData / 14) + 1 Then DGVPrev.PerformClick()
        For x = FetchData To FetchData + 13
            DGV.Rows.Add(Baris(x)(0), Baris(x)(1), Baris(x)(2), Baris(x)(3))
            If x = Baris.Count Then Exit For
        Next
        DGVPageCounter.Text = CurrentPage & " / " & IIf(Math.Ceiling(JumlahData / 14) = 0, 1, Math.Ceiling(JumlahData / 14))
        If CurrentPage = 1 Then DGVPrev.Enabled = 0 Else DGVPrev.Enabled = 1
        If CurrentPage >= Math.Ceiling(JumlahData / 14) Then DGVNext.Enabled = 0 Else DGVNext.Enabled = 1
    End Sub

    Sub TampilDGV()
        JumlahData = 0
        Baris.Clear()
        QRL("SELECT Username, Anggota, Buku, Pinjam FROM TBLUser WHERE NOT Username = 'Admin' AND Username LIKE '%" & TCariData.Text & "%' ORDER BY Username ASC")
        Do While DR.Read
            JumlahData += 1
            Baris.Add({DR(0), DR(1), DR(2), DR(3)})
        Loop
        If Baris.Count = 0 Then
            DGV.Rows.Clear()
            Exit Sub
        End If
        Paging()
    End Sub

    Private Sub TCariData_TextChanged(sender As Object, e As EventArgs) Handles TCariData.TextChanged
        FetchData = 1
        CurrentPage = 1
        TampilDGV()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        TPassword.Clear()
        If e.ColumnIndex = 0 Then TUsername.Text = DGV.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        DGV.CommitEdit(DataGridViewDataErrorContexts.Commit)
        QN("UPDATE TBLUser SET Anggota = " & Val(DGV.Rows(e.RowIndex).Cells(1).Value) & ", Buku = " & Val(DGV.Rows(e.RowIndex).Cells(2).Value) & ", Pinjam = " & Val(DGV.Rows(e.RowIndex).Cells(3).Value) & " WHERE Username = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'")
    End Sub

    Private Sub DGVPrev_Click(sender As Object, e As EventArgs) Handles DGVPrev.Click
        FetchData -= 14
        CurrentPage -= 1
        Paging()
    End Sub

    Private Sub DGVNext_Click(sender As Object, e As EventArgs) Handles DGVNext.Click
        FetchData += 14
        CurrentPage += 1
        Paging()
    End Sub
#End Region

End Class