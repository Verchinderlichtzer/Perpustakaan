<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buku
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.TJudul = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLJudul = New Krypton.Toolkit.KryptonLabel()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.TPengarang = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLPengarang = New Krypton.Toolkit.KryptonLabel()
        Me.TKategori = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLKategori = New Krypton.Toolkit.KryptonLabel()
        Me.TID = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLID = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPenerbit = New Krypton.Toolkit.KryptonLabel()
        Me.TPenerbit = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTahun = New Krypton.Toolkit.KryptonLabel()
        Me.TTahun = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLHarga = New Krypton.Toolkit.KryptonLabel()
        Me.THarga = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLLokasi = New Krypton.Toolkit.KryptonLabel()
        Me.TLokasi = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLStok = New Krypton.Toolkit.KryptonLabel()
        Me.TStok = New Krypton.Toolkit.KryptonTextBox()
        Me.PBBuku = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.Enabled = False
        Me.BTNSimpan.Location = New System.Drawing.Point(761, 520)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNSimpan.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.OverrideDefault.Border.Rounding = 0!
        Me.BTNSimpan.OverrideDefault.Border.Width = 3
        Me.BTNSimpan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNSimpan.Size = New System.Drawing.Size(110, 110)
        Me.BTNSimpan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNSimpan.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StateCommon.Border.Rounding = 0!
        Me.BTNSimpan.StateCommon.Border.Width = 3
        Me.BTNSimpan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNSimpan.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNSimpan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNSimpan.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNSimpan.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNSimpan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNSimpan.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNSimpan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNSimpan.TabIndex = 10
        Me.BTNSimpan.Values.Image = Global.Perpustakaan.My.Resources.Resources.crud_simpan_pressed
        Me.BTNSimpan.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNSimpan.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.crud_simpan_common
        Me.BTNSimpan.Values.Text = ""
        '
        'BTNHapus
        '
        Me.BTNHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHapus.Location = New System.Drawing.Point(877, 520)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNHapus.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNHapus.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.OverrideDefault.Border.Rounding = 0!
        Me.BTNHapus.OverrideDefault.Border.Width = 3
        Me.BTNHapus.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNHapus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNHapus.Size = New System.Drawing.Size(110, 110)
        Me.BTNHapus.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNHapus.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNHapus.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StateCommon.Border.Rounding = 0!
        Me.BTNHapus.StateCommon.Border.Width = 3
        Me.BTNHapus.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNHapus.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNHapus.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNHapus.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNHapus.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNHapus.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNHapus.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNHapus.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNHapus.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNHapus.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNHapus.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNHapus.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNHapus.TabIndex = 11
        Me.BTNHapus.Values.Image = Global.Perpustakaan.My.Resources.Resources.crud_hapus_pressed
        Me.BTNHapus.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNHapus.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNHapus.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNHapus.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.crud_hapus_common
        Me.BTNHapus.Values.Text = ""
        '
        'BTNClear
        '
        Me.BTNClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNClear.Location = New System.Drawing.Point(993, 520)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNClear.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.OverrideDefault.Border.Rounding = 0!
        Me.BTNClear.OverrideDefault.Border.Width = 3
        Me.BTNClear.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNClear.Size = New System.Drawing.Size(110, 110)
        Me.BTNClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClear.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNClear.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StateCommon.Border.Rounding = 0!
        Me.BTNClear.StateCommon.Border.Width = 3
        Me.BTNClear.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClear.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNClear.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNClear.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClear.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNClear.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNClear.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNClear.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNClear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNClear.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNClear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClear.TabIndex = 12
        Me.BTNClear.Values.Image = Global.Perpustakaan.My.Resources.Resources.crud_refresh_pressed
        Me.BTNClear.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNClear.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.crud_refresh_common
        Me.BTNClear.Values.Text = ""
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari buku..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(8, 520)
        Me.TCariData.MaxLength = 255
        Me.TCariData.Name = "TCariData"
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TCariData.Size = New System.Drawing.Size(747, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariData.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TCariData.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateCommon.Border.Rounding = 0!
        Me.TCariData.StateCommon.Border.Width = 1
        Me.TCariData.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCariData.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TCariData.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TCariData.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateDisabled.Border.Rounding = 0!
        Me.TCariData.StateDisabled.Border.Width = 0
        Me.TCariData.TabIndex = 8
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(510, 488)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 186
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(478, 488)
        Me.DGVPrev.Name = "DGVPrev"
        Me.DGVPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPrev.Size = New System.Drawing.Size(26, 26)
        Me.DGVPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPrev.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVPrev.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVPrev.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVPrev.TabIndex = 184
        Me.DGVPrev.Values.Text = "◄"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(606, 488)
        Me.DGVNext.Name = "DGVNext"
        Me.DGVNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVNext.Size = New System.Drawing.Size(26, 26)
        Me.DGVNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVNext.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVNext.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVNext.TabIndex = 185
        Me.DGVNext.Values.Text = "►"
        '
        'TJudul
        '
        Me.TJudul.AlwaysActive = False
        Me.TJudul.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TJudul.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TJudul.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TJudul.Location = New System.Drawing.Point(109, 40)
        Me.TJudul.MaxLength = 100
        Me.TJudul.Name = "TJudul"
        Me.TJudul.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TJudul.Size = New System.Drawing.Size(869, 29)
        Me.TJudul.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TJudul.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TJudul.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJudul.StateActive.Border.Rounding = 0!
        Me.TJudul.StateActive.Border.Width = 1
        Me.TJudul.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TJudul.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TJudul.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TJudul.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TJudul.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJudul.StateCommon.Border.Rounding = 0!
        Me.TJudul.StateCommon.Border.Width = 1
        Me.TJudul.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TJudul.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TJudul.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TJudul.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJudul.StateDisabled.Border.Rounding = 0!
        Me.TJudul.StateDisabled.Border.Width = 0
        Me.TJudul.TabIndex = 0
        '
        'LBLJudul
        '
        Me.LBLJudul.AutoSize = False
        Me.LBLJudul.Location = New System.Drawing.Point(8, 40)
        Me.LBLJudul.Name = "LBLJudul"
        Me.LBLJudul.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLJudul.Size = New System.Drawing.Size(95, 26)
        Me.LBLJudul.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLJudul.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLJudul.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLJudul.TabIndex = 182
        Me.LBLJudul.Values.Text = "Judul"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 185)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(1095, 297)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGV.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGV.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGV.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGV.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGV.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGV.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DGV.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGV.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGV.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DGV.TabIndex = 9
        '
        'TPengarang
        '
        Me.TPengarang.AlwaysActive = False
        Me.TPengarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TPengarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TPengarang.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPengarang.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPengarang.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPengarang.Location = New System.Drawing.Point(109, 104)
        Me.TPengarang.MaxLength = 100
        Me.TPengarang.Name = "TPengarang"
        Me.TPengarang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPengarang.Size = New System.Drawing.Size(278, 29)
        Me.TPengarang.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPengarang.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPengarang.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengarang.StateActive.Border.Rounding = 0!
        Me.TPengarang.StateActive.Border.Width = 1
        Me.TPengarang.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPengarang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPengarang.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPengarang.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPengarang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengarang.StateCommon.Border.Rounding = 0!
        Me.TPengarang.StateCommon.Border.Width = 1
        Me.TPengarang.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPengarang.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPengarang.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPengarang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengarang.StateDisabled.Border.Rounding = 0!
        Me.TPengarang.StateDisabled.Border.Width = 0
        Me.TPengarang.TabIndex = 2
        '
        'LBLPengarang
        '
        Me.LBLPengarang.AutoSize = False
        Me.LBLPengarang.Location = New System.Drawing.Point(8, 104)
        Me.LBLPengarang.Name = "LBLPengarang"
        Me.LBLPengarang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLPengarang.Size = New System.Drawing.Size(95, 26)
        Me.LBLPengarang.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPengarang.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPengarang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPengarang.TabIndex = 177
        Me.LBLPengarang.Values.Text = "Pengarang"
        '
        'TKategori
        '
        Me.TKategori.AlwaysActive = False
        Me.TKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TKategori.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TKategori.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TKategori.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TKategori.Location = New System.Drawing.Point(109, 72)
        Me.TKategori.MaxLength = 100
        Me.TKategori.Name = "TKategori"
        Me.TKategori.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TKategori.Size = New System.Drawing.Size(278, 29)
        Me.TKategori.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TKategori.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKategori.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKategori.StateActive.Border.Rounding = 0!
        Me.TKategori.StateActive.Border.Width = 1
        Me.TKategori.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TKategori.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKategori.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TKategori.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKategori.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKategori.StateCommon.Border.Rounding = 0!
        Me.TKategori.StateCommon.Border.Width = 1
        Me.TKategori.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TKategori.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TKategori.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKategori.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKategori.StateDisabled.Border.Rounding = 0!
        Me.TKategori.StateDisabled.Border.Width = 0
        Me.TKategori.TabIndex = 1
        '
        'LBLKategori
        '
        Me.LBLKategori.AutoSize = False
        Me.LBLKategori.Location = New System.Drawing.Point(8, 72)
        Me.LBLKategori.Name = "LBLKategori"
        Me.LBLKategori.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLKategori.Size = New System.Drawing.Size(95, 26)
        Me.LBLKategori.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLKategori.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLKategori.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLKategori.TabIndex = 176
        Me.LBLKategori.Values.Text = "Kategori"
        '
        'TID
        '
        Me.TID.AlwaysActive = False
        Me.TID.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TID.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TID.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TID.Enabled = False
        Me.TID.Location = New System.Drawing.Point(109, 8)
        Me.TID.MaxLength = 5
        Me.TID.Name = "TID"
        Me.TID.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TID.Size = New System.Drawing.Size(60, 29)
        Me.TID.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TID.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TID.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateActive.Border.Rounding = 0!
        Me.TID.StateActive.Border.Width = 1
        Me.TID.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TID.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TID.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateCommon.Border.Rounding = 0!
        Me.TID.StateCommon.Border.Width = 1
        Me.TID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TID.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TID.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TID.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TID.StateDisabled.Border.Rounding = 0!
        Me.TID.StateDisabled.Border.Width = 0
        Me.TID.TabIndex = 175
        Me.TID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLID
        '
        Me.LBLID.AutoSize = False
        Me.LBLID.Location = New System.Drawing.Point(8, 8)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLID.Size = New System.Drawing.Size(95, 26)
        Me.LBLID.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLID.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLID.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLID.TabIndex = 179
        Me.LBLID.Values.Text = "ID Buku"
        '
        'LBLPenerbit
        '
        Me.LBLPenerbit.AutoSize = False
        Me.LBLPenerbit.Location = New System.Drawing.Point(414, 72)
        Me.LBLPenerbit.Name = "LBLPenerbit"
        Me.LBLPenerbit.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLPenerbit.Size = New System.Drawing.Size(81, 26)
        Me.LBLPenerbit.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPenerbit.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPenerbit.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPenerbit.TabIndex = 176
        Me.LBLPenerbit.Values.Text = "Penerbit"
        '
        'TPenerbit
        '
        Me.TPenerbit.AlwaysActive = False
        Me.TPenerbit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TPenerbit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TPenerbit.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPenerbit.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPenerbit.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPenerbit.Location = New System.Drawing.Point(501, 72)
        Me.TPenerbit.MaxLength = 100
        Me.TPenerbit.Name = "TPenerbit"
        Me.TPenerbit.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPenerbit.Size = New System.Drawing.Size(278, 29)
        Me.TPenerbit.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPenerbit.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPenerbit.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPenerbit.StateActive.Border.Rounding = 0!
        Me.TPenerbit.StateActive.Border.Width = 1
        Me.TPenerbit.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPenerbit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPenerbit.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPenerbit.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPenerbit.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPenerbit.StateCommon.Border.Rounding = 0!
        Me.TPenerbit.StateCommon.Border.Width = 1
        Me.TPenerbit.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPenerbit.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPenerbit.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPenerbit.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPenerbit.StateDisabled.Border.Rounding = 0!
        Me.TPenerbit.StateDisabled.Border.Width = 0
        Me.TPenerbit.TabIndex = 3
        '
        'LBLTahun
        '
        Me.LBLTahun.AutoSize = False
        Me.LBLTahun.Location = New System.Drawing.Point(414, 104)
        Me.LBLTahun.Name = "LBLTahun"
        Me.LBLTahun.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTahun.Size = New System.Drawing.Size(62, 26)
        Me.LBLTahun.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTahun.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTahun.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTahun.TabIndex = 177
        Me.LBLTahun.Values.Text = "Tahun"
        '
        'TTahun
        '
        Me.TTahun.AlwaysActive = False
        Me.TTahun.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTahun.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTahun.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTahun.Location = New System.Drawing.Point(501, 104)
        Me.TTahun.MaxLength = 4
        Me.TTahun.Name = "TTahun"
        Me.TTahun.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TTahun.Size = New System.Drawing.Size(50, 29)
        Me.TTahun.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TTahun.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTahun.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTahun.StateActive.Border.Rounding = 0!
        Me.TTahun.StateActive.Border.Width = 1
        Me.TTahun.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTahun.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTahun.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TTahun.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTahun.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTahun.StateCommon.Border.Rounding = 0!
        Me.TTahun.StateCommon.Border.Width = 1
        Me.TTahun.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTahun.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTahun.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTahun.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTahun.StateDisabled.Border.Rounding = 0!
        Me.TTahun.StateDisabled.Border.Width = 0
        Me.TTahun.TabIndex = 4
        Me.TTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLHarga
        '
        Me.LBLHarga.AutoSize = False
        Me.LBLHarga.Location = New System.Drawing.Point(816, 72)
        Me.LBLHarga.Name = "LBLHarga"
        Me.LBLHarga.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLHarga.Size = New System.Drawing.Size(62, 26)
        Me.LBLHarga.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHarga.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLHarga.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLHarga.TabIndex = 176
        Me.LBLHarga.Values.Text = "Harga"
        '
        'THarga
        '
        Me.THarga.AlwaysActive = False
        Me.THarga.CueHint.Color1 = System.Drawing.Color.Gray
        Me.THarga.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.THarga.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.THarga.Location = New System.Drawing.Point(884, 72)
        Me.THarga.MaxLength = 8
        Me.THarga.Name = "THarga"
        Me.THarga.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.THarga.Size = New System.Drawing.Size(94, 29)
        Me.THarga.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.THarga.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.THarga.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THarga.StateActive.Border.Rounding = 0!
        Me.THarga.StateActive.Border.Width = 1
        Me.THarga.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.THarga.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.THarga.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.THarga.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.THarga.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THarga.StateCommon.Border.Rounding = 0!
        Me.THarga.StateCommon.Border.Width = 1
        Me.THarga.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.THarga.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.THarga.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.THarga.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THarga.StateDisabled.Border.Rounding = 0!
        Me.THarga.StateDisabled.Border.Width = 0
        Me.THarga.TabIndex = 5
        '
        'LBLLokasi
        '
        Me.LBLLokasi.AutoSize = False
        Me.LBLLokasi.Location = New System.Drawing.Point(8, 136)
        Me.LBLLokasi.Name = "LBLLokasi"
        Me.LBLLokasi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLLokasi.Size = New System.Drawing.Size(62, 26)
        Me.LBLLokasi.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLLokasi.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLokasi.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLLokasi.TabIndex = 176
        Me.LBLLokasi.Values.Text = "Lokasi"
        '
        'TLokasi
        '
        Me.TLokasi.AlwaysActive = False
        Me.TLokasi.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TLokasi.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TLokasi.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TLokasi.Location = New System.Drawing.Point(109, 136)
        Me.TLokasi.MaxLength = 100
        Me.TLokasi.Name = "TLokasi"
        Me.TLokasi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TLokasi.Size = New System.Drawing.Size(869, 29)
        Me.TLokasi.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TLokasi.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TLokasi.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TLokasi.StateActive.Border.Rounding = 0!
        Me.TLokasi.StateActive.Border.Width = 1
        Me.TLokasi.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TLokasi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TLokasi.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TLokasi.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TLokasi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TLokasi.StateCommon.Border.Rounding = 0!
        Me.TLokasi.StateCommon.Border.Width = 1
        Me.TLokasi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TLokasi.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TLokasi.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TLokasi.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TLokasi.StateDisabled.Border.Rounding = 0!
        Me.TLokasi.StateDisabled.Border.Width = 0
        Me.TLokasi.TabIndex = 7
        '
        'LBLStok
        '
        Me.LBLStok.AutoSize = False
        Me.LBLStok.Location = New System.Drawing.Point(816, 104)
        Me.LBLStok.Name = "LBLStok"
        Me.LBLStok.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLStok.Size = New System.Drawing.Size(62, 26)
        Me.LBLStok.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLStok.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLStok.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLStok.TabIndex = 177
        Me.LBLStok.Values.Text = "Stok"
        '
        'TStok
        '
        Me.TStok.AlwaysActive = False
        Me.TStok.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TStok.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TStok.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TStok.Location = New System.Drawing.Point(884, 104)
        Me.TStok.MaxLength = 4
        Me.TStok.Name = "TStok"
        Me.TStok.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TStok.Size = New System.Drawing.Size(50, 29)
        Me.TStok.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TStok.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TStok.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TStok.StateActive.Border.Rounding = 0!
        Me.TStok.StateActive.Border.Width = 1
        Me.TStok.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TStok.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TStok.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TStok.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TStok.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TStok.StateCommon.Border.Rounding = 0!
        Me.TStok.StateCommon.Border.Width = 1
        Me.TStok.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TStok.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TStok.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TStok.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TStok.StateDisabled.Border.Rounding = 0!
        Me.TStok.StateDisabled.Border.Width = 0
        Me.TStok.TabIndex = 6
        Me.TStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PBBuku
        '
        Me.PBBuku.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PBBuku.Cursor = System.Windows.Forms.Cursors.Help
        Me.PBBuku.Location = New System.Drawing.Point(984, 8)
        Me.PBBuku.Name = "PBBuku"
        Me.PBBuku.Size = New System.Drawing.Size(119, 168)
        Me.PBBuku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBBuku.TabIndex = 187
        Me.PBBuku.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Buku
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.TJudul)
        Me.Controls.Add(Me.PBBuku)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.LBLJudul)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TTahun)
        Me.Controls.Add(Me.TStok)
        Me.Controls.Add(Me.TPengarang)
        Me.Controls.Add(Me.LBLTahun)
        Me.Controls.Add(Me.LBLStok)
        Me.Controls.Add(Me.LBLPengarang)
        Me.Controls.Add(Me.TLokasi)
        Me.Controls.Add(Me.TPenerbit)
        Me.Controls.Add(Me.LBLLokasi)
        Me.Controls.Add(Me.LBLPenerbit)
        Me.Controls.Add(Me.THarga)
        Me.Controls.Add(Me.LBLHarga)
        Me.Controls.Add(Me.TKategori)
        Me.Controls.Add(Me.LBLKategori)
        Me.Controls.Add(Me.TID)
        Me.Controls.Add(Me.LBLID)
        Me.Name = "Buku"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents TJudul As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLJudul As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TPengarang As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLPengarang As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TKategori As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLKategori As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TID As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLID As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLPenerbit As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TPenerbit As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTahun As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TTahun As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLHarga As Krypton.Toolkit.KryptonLabel
    Friend WithEvents THarga As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLLokasi As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TLokasi As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLStok As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TStok As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PBBuku As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
