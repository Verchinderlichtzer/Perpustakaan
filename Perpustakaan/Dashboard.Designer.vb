<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PanelRiwayatTransaksi = New Krypton.Toolkit.KryptonGroup()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.LBLRiwayatPeminjaman = New Krypton.Toolkit.KryptonLabel()
        Me.PanelPengaturan = New Krypton.Toolkit.KryptonGroup()
        Me.TBatasHari = New Krypton.Toolkit.KryptonTextBox()
        Me.TBatasBuku = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLBatasHari = New Krypton.Toolkit.KryptonLabel()
        Me.LBLBatasBuku = New Krypton.Toolkit.KryptonLabel()
        Me.LBLHapusPeminjaman = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPengaturan = New Krypton.Toolkit.KryptonLabel()
        Me.CBGantiPw = New Krypton.Toolkit.KryptonCheckBox()
        Me.PanelGantiPw = New Krypton.Toolkit.KryptonGroup()
        Me.BTNGantiPw = New Krypton.Toolkit.KryptonButton()
        Me.TPwBaru = New Krypton.Toolkit.KryptonTextBox()
        Me.TPwLama = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLBackupDB = New Krypton.Toolkit.KryptonLabel()
        Me.PanelFooter = New Krypton.Toolkit.KryptonGroup()
        Me.LBLUserAktif = New Krypton.Toolkit.KryptonLabel()
        Me.LBLAuthor = New Krypton.Toolkit.KryptonLabel()
        Me.PanelProfil = New Krypton.Toolkit.KryptonGroup()
        Me.BTNSimpan = New Krypton.Toolkit.KryptonButton()
        Me.LBLProfil = New Krypton.Toolkit.KryptonLabel()
        Me.LBLJabatan = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTeleponFax = New Krypton.Toolkit.KryptonLabel()
        Me.LBLPengurus = New Krypton.Toolkit.KryptonLabel()
        Me.TPengurus = New Krypton.Toolkit.KryptonTextBox()
        Me.TJabatan = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLWebsite = New Krypton.Toolkit.KryptonLabel()
        Me.LBLAlamat = New Krypton.Toolkit.KryptonLabel()
        Me.LBLEmail = New Krypton.Toolkit.KryptonLabel()
        Me.LBLNama = New Krypton.Toolkit.KryptonLabel()
        Me.TFax = New Krypton.Toolkit.KryptonTextBox()
        Me.TTelepon = New Krypton.Toolkit.KryptonTextBox()
        Me.TWebsite = New Krypton.Toolkit.KryptonTextBox()
        Me.TAlamat = New Krypton.Toolkit.KryptonTextBox()
        Me.TEmail = New Krypton.Toolkit.KryptonTextBox()
        Me.TNama = New Krypton.Toolkit.KryptonTextBox()
        CType(Me.PanelRiwayatTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelRiwayatTransaksi.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRiwayatTransaksi.Panel.SuspendLayout()
        Me.PanelRiwayatTransaksi.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelPengaturan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelPengaturan.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPengaturan.Panel.SuspendLayout()
        Me.PanelPengaturan.SuspendLayout()
        CType(Me.PanelGantiPw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelGantiPw.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGantiPw.Panel.SuspendLayout()
        Me.PanelGantiPw.SuspendLayout()
        CType(Me.PanelFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFooter.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooter.Panel.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        CType(Me.PanelProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelProfil.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProfil.Panel.SuspendLayout()
        Me.PanelProfil.SuspendLayout()
        Me.SuspendLayout()
        '
        'PaletSekunder
        '
        Me.PaletSekunder.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletSekunder.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletSekunder.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Title = "Jangan simpan di Local Disk C:"
        '
        'PanelRiwayatTransaksi
        '
        Me.PanelRiwayatTransaksi.Location = New System.Drawing.Point(524, 8)
        Me.PanelRiwayatTransaksi.Name = "PanelRiwayatTransaksi"
        Me.PanelRiwayatTransaksi.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelRiwayatTransaksi.Panel
        '
        Me.PanelRiwayatTransaksi.Panel.Controls.Add(Me.TCariData)
        Me.PanelRiwayatTransaksi.Panel.Controls.Add(Me.DGVPageCounter)
        Me.PanelRiwayatTransaksi.Panel.Controls.Add(Me.DGVPrev)
        Me.PanelRiwayatTransaksi.Panel.Controls.Add(Me.DGVNext)
        Me.PanelRiwayatTransaksi.Panel.Controls.Add(Me.DGV)
        Me.PanelRiwayatTransaksi.Panel.Controls.Add(Me.LBLRiwayatPeminjaman)
        Me.PanelRiwayatTransaksi.Size = New System.Drawing.Size(579, 584)
        Me.PanelRiwayatTransaksi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelRiwayatTransaksi.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelRiwayatTransaksi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelRiwayatTransaksi.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelRiwayatTransaksi.StateCommon.Border.Width = 3
        Me.PanelRiwayatTransaksi.TabIndex = 115
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari buku..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(3, 27)
        Me.TCariData.MaxLength = 255
        Me.TCariData.Name = "TCariData"
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TCariData.Size = New System.Drawing.Size(567, 29)
        Me.TCariData.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TCariData.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TCariData.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TCariData.StateActive.Border.Rounding = 0!
        Me.TCariData.StateActive.Border.Width = 1
        Me.TCariData.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TCariData.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.TCariData.TabIndex = 0
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(241, 548)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 189
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(209, 548)
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
        Me.DGVPrev.TabIndex = 187
        Me.DGVPrev.Values.Text = "◄"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(337, 548)
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
        Me.DGVNext.TabIndex = 188
        Me.DGVNext.Values.Text = "►"
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
        Me.DGV.Location = New System.Drawing.Point(3, 57)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(567, 486)
        Me.DGV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.DGV.TabIndex = 1
        '
        'LBLRiwayatPeminjaman
        '
        Me.LBLRiwayatPeminjaman.AutoSize = False
        Me.LBLRiwayatPeminjaman.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLRiwayatPeminjaman.Location = New System.Drawing.Point(0, 0)
        Me.LBLRiwayatPeminjaman.Name = "LBLRiwayatPeminjaman"
        Me.LBLRiwayatPeminjaman.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLRiwayatPeminjaman.Size = New System.Drawing.Size(573, 25)
        Me.LBLRiwayatPeminjaman.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLRiwayatPeminjaman.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLRiwayatPeminjaman.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLRiwayatPeminjaman.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRiwayatPeminjaman.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLRiwayatPeminjaman.TabIndex = 13
        Me.LBLRiwayatPeminjaman.Values.Text = "Rekapitulasi"
        '
        'PanelPengaturan
        '
        Me.PanelPengaturan.Location = New System.Drawing.Point(8, 350)
        Me.PanelPengaturan.Name = "PanelPengaturan"
        Me.PanelPengaturan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelPengaturan.Panel
        '
        Me.PanelPengaturan.Panel.Controls.Add(Me.TBatasHari)
        Me.PanelPengaturan.Panel.Controls.Add(Me.TBatasBuku)
        Me.PanelPengaturan.Panel.Controls.Add(Me.LBLBatasHari)
        Me.PanelPengaturan.Panel.Controls.Add(Me.LBLBatasBuku)
        Me.PanelPengaturan.Panel.Controls.Add(Me.LBLHapusPeminjaman)
        Me.PanelPengaturan.Panel.Controls.Add(Me.LBLPengaturan)
        Me.PanelPengaturan.Panel.Controls.Add(Me.CBGantiPw)
        Me.PanelPengaturan.Panel.Controls.Add(Me.PanelGantiPw)
        Me.PanelPengaturan.Panel.Controls.Add(Me.LBLBackupDB)
        Me.PanelPengaturan.Size = New System.Drawing.Size(510, 242)
        Me.PanelPengaturan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelPengaturan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelPengaturan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelPengaturan.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelPengaturan.StateCommon.Border.Width = 3
        Me.PanelPengaturan.TabIndex = 116
        '
        'TBatasHari
        '
        Me.TBatasHari.AlwaysActive = False
        Me.TBatasHari.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TBatasHari.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TBatasHari.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TBatasHari.Location = New System.Drawing.Point(114, 96)
        Me.TBatasHari.MaxLength = 4
        Me.TBatasHari.Name = "TBatasHari"
        Me.TBatasHari.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TBatasHari.Size = New System.Drawing.Size(52, 29)
        Me.TBatasHari.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TBatasHari.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBatasHari.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBatasHari.StateActive.Border.Rounding = 0!
        Me.TBatasHari.StateActive.Border.Width = 1
        Me.TBatasHari.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TBatasHari.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TBatasHari.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TBatasHari.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBatasHari.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBatasHari.StateCommon.Border.Rounding = 0!
        Me.TBatasHari.StateCommon.Border.Width = 1
        Me.TBatasHari.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBatasHari.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TBatasHari.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBatasHari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBatasHari.StateDisabled.Border.Rounding = 0!
        Me.TBatasHari.StateDisabled.Border.Width = 0
        Me.TBatasHari.TabIndex = 1
        Me.TBatasHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBatasBuku
        '
        Me.TBatasBuku.AlwaysActive = False
        Me.TBatasBuku.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TBatasBuku.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TBatasBuku.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TBatasBuku.Location = New System.Drawing.Point(120, 64)
        Me.TBatasBuku.MaxLength = 2
        Me.TBatasBuku.Name = "TBatasBuku"
        Me.TBatasBuku.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TBatasBuku.Size = New System.Drawing.Size(34, 29)
        Me.TBatasBuku.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TBatasBuku.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBatasBuku.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBatasBuku.StateActive.Border.Rounding = 0!
        Me.TBatasBuku.StateActive.Border.Width = 1
        Me.TBatasBuku.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TBatasBuku.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TBatasBuku.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TBatasBuku.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TBatasBuku.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBatasBuku.StateCommon.Border.Rounding = 0!
        Me.TBatasBuku.StateCommon.Border.Width = 1
        Me.TBatasBuku.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBatasBuku.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TBatasBuku.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TBatasBuku.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TBatasBuku.StateDisabled.Border.Rounding = 0!
        Me.TBatasBuku.StateDisabled.Border.Width = 0
        Me.TBatasBuku.TabIndex = 0
        Me.TBatasBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLBatasHari
        '
        Me.LBLBatasHari.Location = New System.Drawing.Point(3, 96)
        Me.LBLBatasHari.Name = "LBLBatasHari"
        Me.LBLBatasHari.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLBatasHari.Size = New System.Drawing.Size(105, 26)
        Me.LBLBatasHari.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBatasHari.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBatasHari.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBatasHari.TabIndex = 126
        Me.LBLBatasHari.Values.Text = "Batas Hari :"
        '
        'LBLBatasBuku
        '
        Me.LBLBatasBuku.Location = New System.Drawing.Point(3, 64)
        Me.LBLBatasBuku.Name = "LBLBatasBuku"
        Me.LBLBatasBuku.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLBatasBuku.Size = New System.Drawing.Size(111, 26)
        Me.LBLBatasBuku.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBatasBuku.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBatasBuku.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBatasBuku.TabIndex = 126
        Me.LBLBatasBuku.Values.Text = "Batas Buku :"
        '
        'LBLHapusPeminjaman
        '
        Me.LBLHapusPeminjaman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLHapusPeminjaman.Location = New System.Drawing.Point(3, 160)
        Me.LBLHapusPeminjaman.Name = "LBLHapusPeminjaman"
        Me.LBLHapusPeminjaman.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLHapusPeminjaman.Size = New System.Drawing.Size(223, 26)
        Me.LBLHapusPeminjaman.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHapusPeminjaman.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLHapusPeminjaman.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLHapusPeminjaman.TabIndex = 13
        Me.LBLHapusPeminjaman.Values.Text = "Hapus Semua Peminjaman"
        '
        'LBLPengaturan
        '
        Me.LBLPengaturan.AutoSize = False
        Me.LBLPengaturan.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLPengaturan.Location = New System.Drawing.Point(0, 0)
        Me.LBLPengaturan.Name = "LBLPengaturan"
        Me.LBLPengaturan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLPengaturan.Size = New System.Drawing.Size(504, 25)
        Me.LBLPengaturan.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLPengaturan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPengaturan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPengaturan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPengaturan.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLPengaturan.TabIndex = 13
        Me.LBLPengaturan.Values.Text = "Pengaturan"
        '
        'CBGantiPw
        '
        Me.CBGantiPw.Location = New System.Drawing.Point(7, 32)
        Me.CBGantiPw.Name = "CBGantiPw"
        Me.CBGantiPw.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBGantiPw.Palette = Me.PaletSekunder
        Me.CBGantiPw.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBGantiPw.Size = New System.Drawing.Size(152, 26)
        Me.CBGantiPw.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBGantiPw.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBGantiPw.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.CBGantiPw.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBGantiPw.TabIndex = 3
        Me.CBGantiPw.Values.Text = "Ganti Password"
        '
        'PanelGantiPw
        '
        Me.PanelGantiPw.Location = New System.Drawing.Point(200, 45)
        Me.PanelGantiPw.Name = "PanelGantiPw"
        Me.PanelGantiPw.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelGantiPw.Panel
        '
        Me.PanelGantiPw.Panel.Controls.Add(Me.BTNGantiPw)
        Me.PanelGantiPw.Panel.Controls.Add(Me.TPwBaru)
        Me.PanelGantiPw.Panel.Controls.Add(Me.TPwLama)
        Me.PanelGantiPw.Size = New System.Drawing.Size(293, 106)
        Me.PanelGantiPw.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelGantiPw.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelGantiPw.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.PanelGantiPw.TabIndex = 113
        Me.PanelGantiPw.Visible = False
        '
        'BTNGantiPw
        '
        Me.BTNGantiPw.Location = New System.Drawing.Point(65, 73)
        Me.BTNGantiPw.Name = "BTNGantiPw"
        Me.BTNGantiPw.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNGantiPw.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGantiPw.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNGantiPw.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNGantiPw.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNGantiPw.Size = New System.Drawing.Size(163, 26)
        Me.BTNGantiPw.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNGantiPw.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGantiPw.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNGantiPw.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNGantiPw.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNGantiPw.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGantiPw.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNGantiPw.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNGantiPw.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNGantiPw.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGantiPw.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNGantiPw.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNGantiPw.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNGantiPw.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNGantiPw.TabIndex = 2
        Me.BTNGantiPw.Values.Text = "Ganti Password"
        '
        'TPwBaru
        '
        Me.TPwBaru.AlwaysActive = False
        Me.TPwBaru.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPwBaru.CueHint.CueHintText = "Password Baru..."
        Me.TPwBaru.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPwBaru.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPwBaru.Location = New System.Drawing.Point(3, 38)
        Me.TPwBaru.MaxLength = 100
        Me.TPwBaru.Name = "TPwBaru"
        Me.TPwBaru.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPwBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TPwBaru.Size = New System.Drawing.Size(287, 29)
        Me.TPwBaru.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPwBaru.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPwBaru.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPwBaru.StateActive.Border.Rounding = 0!
        Me.TPwBaru.StateActive.Border.Width = 1
        Me.TPwBaru.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPwBaru.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TPwBaru.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPwBaru.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPwBaru.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPwBaru.StateCommon.Border.Rounding = 0!
        Me.TPwBaru.StateCommon.Border.Width = 1
        Me.TPwBaru.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPwBaru.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPwBaru.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPwBaru.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPwBaru.StateDisabled.Border.Rounding = 0!
        Me.TPwBaru.StateDisabled.Border.Width = 0
        Me.TPwBaru.TabIndex = 1
        Me.TPwBaru.UseSystemPasswordChar = True
        '
        'TPwLama
        '
        Me.TPwLama.AlwaysActive = False
        Me.TPwLama.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPwLama.CueHint.CueHintText = "Password Lama..."
        Me.TPwLama.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPwLama.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPwLama.Location = New System.Drawing.Point(3, 3)
        Me.TPwLama.MaxLength = 100
        Me.TPwLama.Name = "TPwLama"
        Me.TPwLama.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPwLama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TPwLama.Size = New System.Drawing.Size(287, 29)
        Me.TPwLama.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPwLama.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPwLama.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPwLama.StateActive.Border.Rounding = 0!
        Me.TPwLama.StateActive.Border.Width = 1
        Me.TPwLama.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPwLama.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TPwLama.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPwLama.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPwLama.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPwLama.StateCommon.Border.Rounding = 0!
        Me.TPwLama.StateCommon.Border.Width = 1
        Me.TPwLama.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPwLama.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPwLama.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPwLama.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPwLama.StateDisabled.Border.Rounding = 0!
        Me.TPwLama.StateDisabled.Border.Width = 0
        Me.TPwLama.TabIndex = 0
        Me.TPwLama.UseSystemPasswordChar = True
        '
        'LBLBackupDB
        '
        Me.LBLBackupDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLBackupDB.Location = New System.Drawing.Point(3, 128)
        Me.LBLBackupDB.Name = "LBLBackupDB"
        Me.LBLBackupDB.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLBackupDB.Size = New System.Drawing.Size(147, 26)
        Me.LBLBackupDB.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBackupDB.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBackupDB.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBackupDB.TabIndex = 13
        Me.LBLBackupDB.Values.Text = "Backup Database"
        '
        'PanelFooter
        '
        Me.PanelFooter.Location = New System.Drawing.Point(8, 598)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelFooter.Panel
        '
        Me.PanelFooter.Panel.Controls.Add(Me.LBLUserAktif)
        Me.PanelFooter.Panel.Controls.Add(Me.LBLAuthor)
        Me.PanelFooter.Size = New System.Drawing.Size(1095, 32)
        Me.PanelFooter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelFooter.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelFooter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelFooter.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelFooter.StateCommon.Border.Width = 3
        Me.PanelFooter.TabIndex = 117
        '
        'LBLUserAktif
        '
        Me.LBLUserAktif.Dock = System.Windows.Forms.DockStyle.Right
        Me.LBLUserAktif.Location = New System.Drawing.Point(1071, 0)
        Me.LBLUserAktif.Name = "LBLUserAktif"
        Me.LBLUserAktif.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLUserAktif.Size = New System.Drawing.Size(18, 26)
        Me.LBLUserAktif.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUserAktif.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUserAktif.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUserAktif.TabIndex = 13
        Me.LBLUserAktif.Values.Text = "-"
        '
        'LBLAuthor
        '
        Me.LBLAuthor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLAuthor.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBLAuthor.Location = New System.Drawing.Point(0, 0)
        Me.LBLAuthor.Name = "LBLAuthor"
        Me.LBLAuthor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLAuthor.Size = New System.Drawing.Size(400, 26)
        Me.LBLAuthor.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAuthor.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAuthor.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAuthor.TabIndex = 13
        Me.LBLAuthor.Values.Text = "Aplikasi Perpustakaan (dibuat oleh Sujudi Hanif)"
        '
        'PanelProfil
        '
        Me.PanelProfil.Location = New System.Drawing.Point(8, 8)
        Me.PanelProfil.Name = "PanelProfil"
        Me.PanelProfil.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'PanelProfil.Panel
        '
        Me.PanelProfil.Panel.Controls.Add(Me.BTNSimpan)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLProfil)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLJabatan)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLTeleponFax)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLPengurus)
        Me.PanelProfil.Panel.Controls.Add(Me.TPengurus)
        Me.PanelProfil.Panel.Controls.Add(Me.TJabatan)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLWebsite)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLAlamat)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLEmail)
        Me.PanelProfil.Panel.Controls.Add(Me.LBLNama)
        Me.PanelProfil.Panel.Controls.Add(Me.TFax)
        Me.PanelProfil.Panel.Controls.Add(Me.TTelepon)
        Me.PanelProfil.Panel.Controls.Add(Me.TWebsite)
        Me.PanelProfil.Panel.Controls.Add(Me.TAlamat)
        Me.PanelProfil.Panel.Controls.Add(Me.TEmail)
        Me.PanelProfil.Panel.Controls.Add(Me.TNama)
        Me.PanelProfil.Size = New System.Drawing.Size(510, 336)
        Me.PanelProfil.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelProfil.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PanelProfil.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PanelProfil.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.PanelProfil.StateCommon.Border.Width = 3
        Me.PanelProfil.TabIndex = 118
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Location = New System.Drawing.Point(171, 299)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSimpan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSimpan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNSimpan.Size = New System.Drawing.Size(163, 26)
        Me.BTNSimpan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSimpan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNSimpan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNSimpan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSimpan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNSimpan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BTNSimpan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNSimpan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNSimpan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNSimpan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNSimpan.TabIndex = 8
        Me.BTNSimpan.Values.Text = "Simpan Perubahan"
        '
        'LBLProfil
        '
        Me.LBLProfil.AutoSize = False
        Me.LBLProfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLProfil.Location = New System.Drawing.Point(0, 0)
        Me.LBLProfil.Name = "LBLProfil"
        Me.LBLProfil.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLProfil.Size = New System.Drawing.Size(504, 25)
        Me.LBLProfil.StateCommon.Padding = New System.Windows.Forms.Padding(-1, 5, -1, -1)
        Me.LBLProfil.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLProfil.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLProfil.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProfil.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLProfil.TabIndex = 13
        Me.LBLProfil.Values.Text = "Profil Perpustakaan"
        '
        'LBLJabatan
        '
        Me.LBLJabatan.AutoSize = False
        Me.LBLJabatan.Location = New System.Drawing.Point(3, 268)
        Me.LBLJabatan.Name = "LBLJabatan"
        Me.LBLJabatan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLJabatan.Size = New System.Drawing.Size(123, 26)
        Me.LBLJabatan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLJabatan.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLJabatan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLJabatan.TabIndex = 13
        Me.LBLJabatan.Values.Text = "Jabatan"
        '
        'LBLTeleponFax
        '
        Me.LBLTeleponFax.AutoSize = False
        Me.LBLTeleponFax.Location = New System.Drawing.Point(3, 140)
        Me.LBLTeleponFax.Name = "LBLTeleponFax"
        Me.LBLTeleponFax.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTeleponFax.Size = New System.Drawing.Size(123, 26)
        Me.LBLTeleponFax.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTeleponFax.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTeleponFax.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTeleponFax.TabIndex = 13
        Me.LBLTeleponFax.Values.Text = "Telepon / Fax"
        '
        'LBLPengurus
        '
        Me.LBLPengurus.AutoSize = False
        Me.LBLPengurus.Location = New System.Drawing.Point(3, 236)
        Me.LBLPengurus.Name = "LBLPengurus"
        Me.LBLPengurus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLPengurus.Size = New System.Drawing.Size(123, 26)
        Me.LBLPengurus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPengurus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPengurus.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPengurus.TabIndex = 13
        Me.LBLPengurus.Values.Text = "Pengurus"
        '
        'TPengurus
        '
        Me.TPengurus.AlwaysActive = False
        Me.TPengurus.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TPengurus.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TPengurus.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TPengurus.Location = New System.Drawing.Point(132, 236)
        Me.TPengurus.MaxLength = 100
        Me.TPengurus.Name = "TPengurus"
        Me.TPengurus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TPengurus.Size = New System.Drawing.Size(369, 29)
        Me.TPengurus.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TPengurus.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPengurus.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengurus.StateActive.Border.Rounding = 0!
        Me.TPengurus.StateActive.Border.Width = 1
        Me.TPengurus.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TPengurus.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TPengurus.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TPengurus.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TPengurus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengurus.StateCommon.Border.Rounding = 0!
        Me.TPengurus.StateCommon.Border.Width = 1
        Me.TPengurus.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPengurus.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TPengurus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TPengurus.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TPengurus.StateDisabled.Border.Rounding = 0!
        Me.TPengurus.StateDisabled.Border.Width = 0
        Me.TPengurus.TabIndex = 6
        '
        'TJabatan
        '
        Me.TJabatan.AlwaysActive = False
        Me.TJabatan.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TJabatan.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TJabatan.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TJabatan.Location = New System.Drawing.Point(132, 268)
        Me.TJabatan.MaxLength = 100
        Me.TJabatan.Name = "TJabatan"
        Me.TJabatan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TJabatan.Size = New System.Drawing.Size(369, 29)
        Me.TJabatan.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TJabatan.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TJabatan.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJabatan.StateActive.Border.Rounding = 0!
        Me.TJabatan.StateActive.Border.Width = 1
        Me.TJabatan.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TJabatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TJabatan.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TJabatan.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TJabatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJabatan.StateCommon.Border.Rounding = 0!
        Me.TJabatan.StateCommon.Border.Width = 1
        Me.TJabatan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TJabatan.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TJabatan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TJabatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TJabatan.StateDisabled.Border.Rounding = 0!
        Me.TJabatan.StateDisabled.Border.Width = 0
        Me.TJabatan.TabIndex = 7
        '
        'LBLWebsite
        '
        Me.LBLWebsite.AutoSize = False
        Me.LBLWebsite.Location = New System.Drawing.Point(3, 204)
        Me.LBLWebsite.Name = "LBLWebsite"
        Me.LBLWebsite.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLWebsite.Size = New System.Drawing.Size(123, 26)
        Me.LBLWebsite.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLWebsite.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLWebsite.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLWebsite.TabIndex = 13
        Me.LBLWebsite.Values.Text = "Website"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.AutoSize = False
        Me.LBLAlamat.Location = New System.Drawing.Point(3, 63)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLAlamat.Size = New System.Drawing.Size(123, 26)
        Me.LBLAlamat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAlamat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAlamat.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAlamat.TabIndex = 13
        Me.LBLAlamat.Values.Text = "Alamat"
        '
        'LBLEmail
        '
        Me.LBLEmail.AutoSize = False
        Me.LBLEmail.Location = New System.Drawing.Point(3, 172)
        Me.LBLEmail.Name = "LBLEmail"
        Me.LBLEmail.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLEmail.Size = New System.Drawing.Size(123, 26)
        Me.LBLEmail.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLEmail.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLEmail.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLEmail.TabIndex = 13
        Me.LBLEmail.Values.Text = "E-mail"
        '
        'LBLNama
        '
        Me.LBLNama.AutoSize = False
        Me.LBLNama.Location = New System.Drawing.Point(3, 31)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLNama.Size = New System.Drawing.Size(123, 26)
        Me.LBLNama.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLNama.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLNama.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLNama.TabIndex = 13
        Me.LBLNama.Values.Text = "Nama"
        '
        'TFax
        '
        Me.TFax.AlwaysActive = False
        Me.TFax.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TFax.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TFax.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TFax.Location = New System.Drawing.Point(322, 140)
        Me.TFax.MaxLength = 100
        Me.TFax.Name = "TFax"
        Me.TFax.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TFax.Size = New System.Drawing.Size(179, 29)
        Me.TFax.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TFax.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TFax.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TFax.StateActive.Border.Rounding = 0!
        Me.TFax.StateActive.Border.Width = 1
        Me.TFax.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TFax.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TFax.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TFax.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TFax.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TFax.StateCommon.Border.Rounding = 0!
        Me.TFax.StateCommon.Border.Width = 1
        Me.TFax.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TFax.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TFax.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TFax.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TFax.StateDisabled.Border.Rounding = 0!
        Me.TFax.StateDisabled.Border.Width = 0
        Me.TFax.TabIndex = 3
        '
        'TTelepon
        '
        Me.TTelepon.AlwaysActive = False
        Me.TTelepon.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTelepon.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTelepon.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTelepon.Location = New System.Drawing.Point(132, 140)
        Me.TTelepon.MaxLength = 100
        Me.TTelepon.Name = "TTelepon"
        Me.TTelepon.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TTelepon.Size = New System.Drawing.Size(184, 29)
        Me.TTelepon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TTelepon.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelepon.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateActive.Border.Rounding = 0!
        Me.TTelepon.StateActive.Border.Width = 1
        Me.TTelepon.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTelepon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TTelepon.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TTelepon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelepon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateCommon.Border.Rounding = 0!
        Me.TTelepon.StateCommon.Border.Width = 1
        Me.TTelepon.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTelepon.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTelepon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTelepon.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelepon.StateDisabled.Border.Rounding = 0!
        Me.TTelepon.StateDisabled.Border.Width = 0
        Me.TTelepon.TabIndex = 2
        '
        'TWebsite
        '
        Me.TWebsite.AlwaysActive = False
        Me.TWebsite.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TWebsite.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TWebsite.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TWebsite.Location = New System.Drawing.Point(132, 204)
        Me.TWebsite.MaxLength = 100
        Me.TWebsite.Name = "TWebsite"
        Me.TWebsite.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TWebsite.Size = New System.Drawing.Size(369, 29)
        Me.TWebsite.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TWebsite.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TWebsite.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TWebsite.StateActive.Border.Rounding = 0!
        Me.TWebsite.StateActive.Border.Width = 1
        Me.TWebsite.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TWebsite.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TWebsite.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TWebsite.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TWebsite.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TWebsite.StateCommon.Border.Rounding = 0!
        Me.TWebsite.StateCommon.Border.Width = 1
        Me.TWebsite.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TWebsite.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TWebsite.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TWebsite.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TWebsite.StateDisabled.Border.Rounding = 0!
        Me.TWebsite.StateDisabled.Border.Width = 0
        Me.TWebsite.TabIndex = 5
        '
        'TAlamat
        '
        Me.TAlamat.AlwaysActive = False
        Me.TAlamat.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TAlamat.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TAlamat.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TAlamat.Location = New System.Drawing.Point(132, 63)
        Me.TAlamat.MaxLength = 100
        Me.TAlamat.Multiline = True
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TAlamat.Size = New System.Drawing.Size(369, 74)
        Me.TAlamat.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TAlamat.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TAlamat.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateActive.Border.Rounding = 0!
        Me.TAlamat.StateActive.Border.Width = 1
        Me.TAlamat.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TAlamat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TAlamat.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TAlamat.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TAlamat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateCommon.Border.Rounding = 0!
        Me.TAlamat.StateCommon.Border.Width = 1
        Me.TAlamat.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TAlamat.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TAlamat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TAlamat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TAlamat.StateDisabled.Border.Rounding = 0!
        Me.TAlamat.StateDisabled.Border.Width = 0
        Me.TAlamat.TabIndex = 1
        '
        'TEmail
        '
        Me.TEmail.AlwaysActive = False
        Me.TEmail.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TEmail.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TEmail.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TEmail.Location = New System.Drawing.Point(132, 172)
        Me.TEmail.MaxLength = 100
        Me.TEmail.Name = "TEmail"
        Me.TEmail.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TEmail.Size = New System.Drawing.Size(369, 29)
        Me.TEmail.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TEmail.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TEmail.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TEmail.StateActive.Border.Rounding = 0!
        Me.TEmail.StateActive.Border.Width = 1
        Me.TEmail.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TEmail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TEmail.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TEmail.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TEmail.StateCommon.Border.Rounding = 0!
        Me.TEmail.StateCommon.Border.Width = 1
        Me.TEmail.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TEmail.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TEmail.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TEmail.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TEmail.StateDisabled.Border.Rounding = 0!
        Me.TEmail.StateDisabled.Border.Width = 0
        Me.TEmail.TabIndex = 4
        '
        'TNama
        '
        Me.TNama.AlwaysActive = False
        Me.TNama.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TNama.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TNama.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TNama.Location = New System.Drawing.Point(132, 31)
        Me.TNama.MaxLength = 100
        Me.TNama.Name = "TNama"
        Me.TNama.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TNama.Size = New System.Drawing.Size(369, 29)
        Me.TNama.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TNama.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNama.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateActive.Border.Rounding = 0!
        Me.TNama.StateActive.Border.Width = 1
        Me.TNama.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TNama.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TNama.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TNama.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TNama.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateCommon.Border.Rounding = 0!
        Me.TNama.StateCommon.Border.Width = 1
        Me.TNama.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TNama.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TNama.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TNama.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TNama.StateDisabled.Border.Rounding = 0!
        Me.TNama.StateDisabled.Border.Width = 0
        Me.TNama.TabIndex = 0
        '
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.PanelRiwayatTransaksi)
        Me.Controls.Add(Me.PanelPengaturan)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelProfil)
        Me.Name = "Dashboard"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.PanelRiwayatTransaksi.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRiwayatTransaksi.Panel.ResumeLayout(False)
        Me.PanelRiwayatTransaksi.Panel.PerformLayout()
        CType(Me.PanelRiwayatTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRiwayatTransaksi.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelPengaturan.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPengaturan.Panel.ResumeLayout(False)
        Me.PanelPengaturan.Panel.PerformLayout()
        CType(Me.PanelPengaturan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPengaturan.ResumeLayout(False)
        CType(Me.PanelGantiPw.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGantiPw.Panel.ResumeLayout(False)
        Me.PanelGantiPw.Panel.PerformLayout()
        CType(Me.PanelGantiPw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGantiPw.ResumeLayout(False)
        CType(Me.PanelFooter.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooter.Panel.ResumeLayout(False)
        Me.PanelFooter.Panel.PerformLayout()
        CType(Me.PanelFooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooter.ResumeLayout(False)
        CType(Me.PanelProfil.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfil.Panel.ResumeLayout(False)
        Me.PanelProfil.Panel.PerformLayout()
        CType(Me.PanelProfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfil.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PanelRiwayatTransaksi As Krypton.Toolkit.KryptonGroup
    Friend WithEvents LBLRiwayatPeminjaman As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelPengaturan As Krypton.Toolkit.KryptonGroup
    Friend WithEvents LBLHapusPeminjaman As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLPengaturan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CBGantiPw As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents PanelGantiPw As Krypton.Toolkit.KryptonGroup
    Friend WithEvents BTNGantiPw As Krypton.Toolkit.KryptonButton
    Friend WithEvents TPwBaru As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TPwLama As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLBackupDB As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelFooter As Krypton.Toolkit.KryptonGroup
    Friend WithEvents LBLUserAktif As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLAuthor As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelProfil As Krypton.Toolkit.KryptonGroup
    Friend WithEvents BTNSimpan As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLProfil As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLJabatan As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLTeleponFax As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLPengurus As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TPengurus As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TJabatan As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLWebsite As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLAlamat As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLEmail As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLNama As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TFax As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTelepon As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TWebsite As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TAlamat As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TEmail As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TNama As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TBatasHari As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TBatasBuku As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLBatasHari As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBatasBuku As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
End Class
