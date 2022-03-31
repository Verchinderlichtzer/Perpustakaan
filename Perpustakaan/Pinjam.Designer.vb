<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjam
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pinjam))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TAnggota = New Krypton.Toolkit.KryptonComboBox()
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.LBLRusak = New Krypton.Toolkit.KryptonLabel()
        Me.LBLHilang = New Krypton.Toolkit.KryptonLabel()
        Me.LBLTelat = New Krypton.Toolkit.KryptonLabel()
        Me.TCariData = New Krypton.Toolkit.KryptonTextBox()
        Me.THilang = New Krypton.Toolkit.KryptonTextBox()
        Me.TRusak = New Krypton.Toolkit.KryptonTextBox()
        Me.TTelat = New Krypton.Toolkit.KryptonTextBox()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CJudul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTglPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTglKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTelat = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CRusak = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CHilang = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVBuku = New Krypton.Toolkit.KryptonDataGridView()
        Me.LBLAnggota = New Krypton.Toolkit.KryptonLabel()
        Me.TTotal = New Krypton.Toolkit.KryptonTextBox()
        Me.TKembali = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLTotal = New Krypton.Toolkit.KryptonLabel()
        Me.LBLKembali = New Krypton.Toolkit.KryptonLabel()
        Me.TDipinjam = New Krypton.Toolkit.KryptonTextBox()
        Me.LBLDipinjam = New Krypton.Toolkit.KryptonLabel()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVBukuNext = New Krypton.Toolkit.KryptonButton()
        Me.DGVBukuPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVBukuPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.BTNHapus = New Krypton.Toolkit.KryptonButton()
        Me.BTNClear = New Krypton.Toolkit.KryptonButton()
        Me.BTNPrint = New Krypton.Toolkit.KryptonButton()
        Me.Rdt = New Perpustakaan.Rdt()
        Me.TBLPinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPinjamTableAdapter = New Perpustakaan.RdtTableAdapters.TBLPinjamTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rdt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TAnggota
        '
        Me.TAnggota.AlwaysActive = False
        Me.TAnggota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TAnggota.DropDownHeight = 500
        Me.TAnggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TAnggota.DropDownWidth = 119
        Me.TAnggota.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TAnggota.IntegralHeight = False
        Me.TAnggota.Location = New System.Drawing.Point(90, 8)
        Me.TAnggota.MaxDropDownItems = 20
        Me.TAnggota.Name = "TAnggota"
        Me.TAnggota.Palette = Me.PaletPrimer
        Me.TAnggota.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TAnggota.Size = New System.Drawing.Size(781, 26)
        Me.TAnggota.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TAnggota.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TAnggota.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAnggota.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TAnggota.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TAnggota.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TAnggota.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TAnggota.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TAnggota.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TAnggota.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TAnggota.TabIndex = 0
        '
        'PaletPrimer
        '
        Me.PaletPrimer.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletPrimer.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.Common = CType(resources.GetObject("resource.Common"), System.Drawing.Image)
        Me.PaletPrimer.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.Common = CType(resources.GetObject("resource.Common1"), System.Drawing.Image)
        Me.PaletPrimer.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled1"), System.Drawing.Image)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateActive.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Border.Width = 1
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Rounding = 0!
        Me.PaletPrimer.InputControlStyles.InputControlCustom3.StateDisabled.Border.Width = 1
        '
        'LBLRusak
        '
        Me.LBLRusak.AutoSize = False
        Me.LBLRusak.Location = New System.Drawing.Point(253, 548)
        Me.LBLRusak.Name = "LBLRusak"
        Me.LBLRusak.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLRusak.Size = New System.Drawing.Size(73, 26)
        Me.LBLRusak.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLRusak.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLRusak.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLRusak.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLRusak.TabIndex = 194
        Me.LBLRusak.Values.Text = "Rusak :"
        '
        'LBLHilang
        '
        Me.LBLHilang.AutoSize = False
        Me.LBLHilang.Location = New System.Drawing.Point(106, 604)
        Me.LBLHilang.Name = "LBLHilang"
        Me.LBLHilang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLHilang.Size = New System.Drawing.Size(73, 26)
        Me.LBLHilang.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLHilang.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLHilang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLHilang.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLHilang.TabIndex = 193
        Me.LBLHilang.Values.Text = "Hilang :"
        '
        'LBLTelat
        '
        Me.LBLTelat.AutoSize = False
        Me.LBLTelat.Location = New System.Drawing.Point(252, 520)
        Me.LBLTelat.Name = "LBLTelat"
        Me.LBLTelat.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTelat.Size = New System.Drawing.Size(73, 26)
        Me.LBLTelat.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTelat.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTelat.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTelat.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTelat.TabIndex = 197
        Me.LBLTelat.Values.Text = "Telat :"
        '
        'TCariData
        '
        Me.TCariData.AlwaysActive = False
        Me.TCariData.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TCariData.CueHint.CueHintText = "Cari buku..."
        Me.TCariData.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCariData.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TCariData.Location = New System.Drawing.Point(877, 8)
        Me.TCariData.MaxLength = 255
        Me.TCariData.Name = "TCariData"
        Me.TCariData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TCariData.Size = New System.Drawing.Size(226, 29)
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
        Me.TCariData.TabIndex = 1
        '
        'THilang
        '
        Me.THilang.AlwaysActive = False
        Me.THilang.CueHint.Color1 = System.Drawing.Color.Gray
        Me.THilang.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.THilang.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.THilang.Enabled = False
        Me.THilang.Location = New System.Drawing.Point(186, 604)
        Me.THilang.MaxLength = 4
        Me.THilang.Name = "THilang"
        Me.THilang.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.THilang.Size = New System.Drawing.Size(50, 29)
        Me.THilang.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.THilang.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.THilang.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THilang.StateActive.Border.Rounding = 0!
        Me.THilang.StateActive.Border.Width = 1
        Me.THilang.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.THilang.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.THilang.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.THilang.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.THilang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THilang.StateCommon.Border.Rounding = 0!
        Me.THilang.StateCommon.Border.Width = 1
        Me.THilang.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.THilang.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.THilang.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.THilang.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.THilang.StateDisabled.Border.Rounding = 0!
        Me.THilang.StateDisabled.Border.Width = 0
        Me.THilang.TabIndex = 178
        '
        'TRusak
        '
        Me.TRusak.AlwaysActive = False
        Me.TRusak.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TRusak.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TRusak.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TRusak.Enabled = False
        Me.TRusak.Location = New System.Drawing.Point(331, 548)
        Me.TRusak.MaxLength = 4
        Me.TRusak.Name = "TRusak"
        Me.TRusak.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TRusak.Size = New System.Drawing.Size(50, 29)
        Me.TRusak.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TRusak.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TRusak.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TRusak.StateActive.Border.Rounding = 0!
        Me.TRusak.StateActive.Border.Width = 1
        Me.TRusak.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TRusak.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TRusak.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TRusak.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TRusak.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TRusak.StateCommon.Border.Rounding = 0!
        Me.TRusak.StateCommon.Border.Width = 1
        Me.TRusak.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TRusak.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TRusak.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TRusak.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TRusak.StateDisabled.Border.Rounding = 0!
        Me.TRusak.StateDisabled.Border.Width = 0
        Me.TRusak.TabIndex = 185
        '
        'TTelat
        '
        Me.TTelat.AlwaysActive = False
        Me.TTelat.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTelat.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTelat.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTelat.Enabled = False
        Me.TTelat.Location = New System.Drawing.Point(331, 520)
        Me.TTelat.MaxLength = 4
        Me.TTelat.Name = "TTelat"
        Me.TTelat.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TTelat.Size = New System.Drawing.Size(50, 29)
        Me.TTelat.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TTelat.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelat.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelat.StateActive.Border.Rounding = 0!
        Me.TTelat.StateActive.Border.Width = 1
        Me.TTelat.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTelat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTelat.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TTelat.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTelat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelat.StateCommon.Border.Rounding = 0!
        Me.TTelat.StateCommon.Border.Width = 1
        Me.TTelat.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTelat.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTelat.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTelat.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTelat.StateDisabled.Border.Rounding = 0!
        Me.TTelat.StateDisabled.Border.Width = 0
        Me.TTelat.TabIndex = 184
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.ColumnHeadersHeight = 27
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.CIDBuku, Me.CJudul, Me.CTglPinjam, Me.CTglKembali, Me.CTelat, Me.CRusak, Me.CHilang, Me.CKeterangan, Me.CDenda, Me.CStatus, Me.CHarga})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 40)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DGV.Size = New System.Drawing.Size(863, 432)
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
        Me.DGV.TabIndex = 3
        '
        'CID
        '
        Me.CID.HeaderText = "ID"
        Me.CID.Name = "CID"
        Me.CID.ReadOnly = True
        Me.CID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CID.Visible = False
        '
        'CIDBuku
        '
        Me.CIDBuku.HeaderText = "ID Buku"
        Me.CIDBuku.Name = "CIDBuku"
        Me.CIDBuku.ReadOnly = True
        Me.CIDBuku.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CIDBuku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CIDBuku.Visible = False
        '
        'CJudul
        '
        Me.CJudul.HeaderText = "Judul"
        Me.CJudul.Name = "CJudul"
        Me.CJudul.ReadOnly = True
        Me.CJudul.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CJudul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CJudul.Width = 170
        '
        'CTglPinjam
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTglPinjam.DefaultCellStyle = DataGridViewCellStyle7
        Me.CTglPinjam.HeaderText = "Tgl Pinjam"
        Me.CTglPinjam.MaxInputLength = 10
        Me.CTglPinjam.Name = "CTglPinjam"
        Me.CTglPinjam.ReadOnly = True
        Me.CTglPinjam.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTglPinjam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTglPinjam.Width = 107
        '
        'CTglKembali
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTglKembali.DefaultCellStyle = DataGridViewCellStyle8
        Me.CTglKembali.HeaderText = "Tgl Kembali"
        Me.CTglKembali.MaxInputLength = 10
        Me.CTglKembali.Name = "CTglKembali"
        Me.CTglKembali.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTglKembali.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTglKembali.Width = 107
        '
        'CTelat
        '
        Me.CTelat.FalseValue = "0"
        Me.CTelat.HeaderText = "Telat"
        Me.CTelat.Name = "CTelat"
        Me.CTelat.ReadOnly = True
        Me.CTelat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTelat.TrueValue = "1"
        Me.CTelat.Width = 60
        '
        'CRusak
        '
        Me.CRusak.FalseValue = "0"
        Me.CRusak.HeaderText = "Rusak"
        Me.CRusak.Name = "CRusak"
        Me.CRusak.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CRusak.TrueValue = "1"
        Me.CRusak.Width = 60
        '
        'CHilang
        '
        Me.CHilang.FalseValue = "0"
        Me.CHilang.HeaderText = "Hilang"
        Me.CHilang.Name = "CHilang"
        Me.CHilang.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CHilang.TrueValue = "1"
        Me.CHilang.Width = 60
        '
        'CKeterangan
        '
        Me.CKeterangan.HeaderText = "Keterangan"
        Me.CKeterangan.MaxInputLength = 200
        Me.CKeterangan.Name = "CKeterangan"
        Me.CKeterangan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CKeterangan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CKeterangan.Width = 151
        '
        'CDenda
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "#,##0"
        Me.CDenda.DefaultCellStyle = DataGridViewCellStyle9
        Me.CDenda.HeaderText = "Denda"
        Me.CDenda.MaxInputLength = 6
        Me.CDenda.Name = "CDenda"
        Me.CDenda.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CDenda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CDenda.Width = 87
        '
        'CStatus
        '
        Me.CStatus.FalseValue = "0"
        Me.CStatus.HeaderText = "Status"
        Me.CStatus.Name = "CStatus"
        Me.CStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CStatus.TrueValue = "1"
        Me.CStatus.Width = 60
        '
        'CHarga
        '
        Me.CHarga.HeaderText = "Harga"
        Me.CHarga.Name = "CHarga"
        Me.CHarga.ReadOnly = True
        Me.CHarga.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CHarga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHarga.Visible = False
        '
        'DGVBuku
        '
        Me.DGVBuku.AllowUserToAddRows = False
        Me.DGVBuku.AllowUserToDeleteRows = False
        Me.DGVBuku.AllowUserToResizeColumns = False
        Me.DGVBuku.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVBuku.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBuku.ColumnHeadersHeight = 27
        Me.DGVBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVBuku.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGVBuku.HideOuterBorders = True
        Me.DGVBuku.Location = New System.Drawing.Point(877, 40)
        Me.DGVBuku.Name = "DGVBuku"
        Me.DGVBuku.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBuku.ReadOnly = True
        Me.DGVBuku.RowHeadersVisible = False
        Me.DGVBuku.RowTemplate.Height = 27
        Me.DGVBuku.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVBuku.Size = New System.Drawing.Size(226, 432)
        Me.DGVBuku.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVBuku.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.DGVBuku.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DGVBuku.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DGVBuku.StateCommon.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.DGVBuku.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVBuku.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBuku.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVBuku.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBuku.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBuku.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.DGVBuku.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBuku.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBuku.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.DGVBuku.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DGVBuku.StateSelected.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBuku.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.DGVBuku.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DGVBuku.TabIndex = 2
        '
        'LBLAnggota
        '
        Me.LBLAnggota.AutoSize = False
        Me.LBLAnggota.Location = New System.Drawing.Point(8, 8)
        Me.LBLAnggota.Name = "LBLAnggota"
        Me.LBLAnggota.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLAnggota.Size = New System.Drawing.Size(76, 26)
        Me.LBLAnggota.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAnggota.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAnggota.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAnggota.TabIndex = 189
        Me.LBLAnggota.Values.Text = "Anggota"
        '
        'TTotal
        '
        Me.TTotal.AlwaysActive = False
        Me.TTotal.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TTotal.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TTotal.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TTotal.Enabled = False
        Me.TTotal.Location = New System.Drawing.Point(186, 520)
        Me.TTotal.MaxLength = 4
        Me.TTotal.Name = "TTotal"
        Me.TTotal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TTotal.Size = New System.Drawing.Size(50, 29)
        Me.TTotal.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TTotal.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTotal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotal.StateActive.Border.Rounding = 0!
        Me.TTotal.StateActive.Border.Width = 1
        Me.TTotal.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TTotal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTotal.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TTotal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotal.StateCommon.Border.Rounding = 0!
        Me.TTotal.StateCommon.Border.Width = 1
        Me.TTotal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTotal.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TTotal.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TTotal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TTotal.StateDisabled.Border.Rounding = 0!
        Me.TTotal.StateDisabled.Border.Width = 0
        Me.TTotal.TabIndex = 182
        '
        'TKembali
        '
        Me.TKembali.AlwaysActive = False
        Me.TKembali.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TKembali.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TKembali.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TKembali.Enabled = False
        Me.TKembali.Location = New System.Drawing.Point(186, 576)
        Me.TKembali.MaxLength = 4
        Me.TKembali.Name = "TKembali"
        Me.TKembali.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TKembali.Size = New System.Drawing.Size(50, 29)
        Me.TKembali.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TKembali.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKembali.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKembali.StateActive.Border.Rounding = 0!
        Me.TKembali.StateActive.Border.Width = 1
        Me.TKembali.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TKembali.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKembali.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TKembali.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TKembali.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKembali.StateCommon.Border.Rounding = 0!
        Me.TKembali.StateCommon.Border.Width = 1
        Me.TKembali.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TKembali.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TKembali.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TKembali.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TKembali.StateDisabled.Border.Rounding = 0!
        Me.TKembali.StateDisabled.Border.Width = 0
        Me.TKembali.TabIndex = 183
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = False
        Me.LBLTotal.Location = New System.Drawing.Point(11, 520)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTotal.Size = New System.Drawing.Size(169, 26)
        Me.LBLTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTotal.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLTotal.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLTotal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLTotal.TabIndex = 190
        Me.LBLTotal.Values.Text = "Total Peminjaman :"
        '
        'LBLKembali
        '
        Me.LBLKembali.AutoSize = False
        Me.LBLKembali.Location = New System.Drawing.Point(11, 576)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLKembali.Size = New System.Drawing.Size(169, 26)
        Me.LBLKembali.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLKembali.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLKembali.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLKembali.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLKembali.TabIndex = 192
        Me.LBLKembali.Values.Text = "Telah Kembali :"
        '
        'TDipinjam
        '
        Me.TDipinjam.AlwaysActive = False
        Me.TDipinjam.CueHint.Color1 = System.Drawing.Color.Gray
        Me.TDipinjam.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.TDipinjam.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.TDipinjam.Enabled = False
        Me.TDipinjam.Location = New System.Drawing.Point(186, 548)
        Me.TDipinjam.MaxLength = 4
        Me.TDipinjam.Name = "TDipinjam"
        Me.TDipinjam.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TDipinjam.Size = New System.Drawing.Size(50, 29)
        Me.TDipinjam.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TDipinjam.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDipinjam.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDipinjam.StateActive.Border.Rounding = 0!
        Me.TDipinjam.StateActive.Border.Width = 1
        Me.TDipinjam.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.TDipinjam.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDipinjam.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.TDipinjam.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.TDipinjam.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDipinjam.StateCommon.Border.Rounding = 0!
        Me.TDipinjam.StateCommon.Border.Width = 1
        Me.TDipinjam.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TDipinjam.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.TDipinjam.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TDipinjam.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.TDipinjam.StateDisabled.Border.Rounding = 0!
        Me.TDipinjam.StateDisabled.Border.Width = 0
        Me.TDipinjam.TabIndex = 183
        '
        'LBLDipinjam
        '
        Me.LBLDipinjam.AutoSize = False
        Me.LBLDipinjam.Location = New System.Drawing.Point(11, 548)
        Me.LBLDipinjam.Name = "LBLDipinjam"
        Me.LBLDipinjam.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLDipinjam.Size = New System.Drawing.Size(169, 26)
        Me.LBLDipinjam.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDipinjam.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDipinjam.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDipinjam.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.LBLDipinjam.TabIndex = 192
        Me.LBLDipinjam.Values.Text = "Sedang Dipinjam :"
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(389, 478)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 204
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(357, 478)
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
        Me.DGVPrev.TabIndex = 202
        Me.DGVPrev.Values.Text = "◄"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(485, 478)
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
        Me.DGVNext.TabIndex = 203
        Me.DGVNext.Values.Text = "►"
        '
        'DGVBukuNext
        '
        Me.DGVBukuNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBukuNext.Enabled = False
        Me.DGVBukuNext.Location = New System.Drawing.Point(1041, 478)
        Me.DGVBukuNext.Name = "DGVBukuNext"
        Me.DGVBukuNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBukuNext.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBukuNext.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBukuNext.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBukuNext.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBukuNext.Size = New System.Drawing.Size(26, 26)
        Me.DGVBukuNext.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBukuNext.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBukuNext.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBukuNext.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBukuNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVBukuNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBukuNext.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVBukuNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBukuNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBukuNext.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBukuNext.TabIndex = 200
        Me.DGVBukuNext.Values.Text = "►"
        '
        'DGVBukuPrev
        '
        Me.DGVBukuPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVBukuPrev.Enabled = False
        Me.DGVBukuPrev.Location = New System.Drawing.Point(913, 478)
        Me.DGVBukuPrev.Name = "DGVBukuPrev"
        Me.DGVBukuPrev.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBukuPrev.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBukuPrev.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBukuPrev.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBukuPrev.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBukuPrev.Size = New System.Drawing.Size(26, 26)
        Me.DGVBukuPrev.StateCommon.Back.Color1 = System.Drawing.Color.Transparent
        Me.DGVBukuPrev.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.DGVBukuPrev.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBukuPrev.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.DGVBukuPrev.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.DGVBukuPrev.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBukuPrev.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.DGVBukuPrev.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gray
        Me.DGVBukuPrev.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBukuPrev.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.DGVBukuPrev.TabIndex = 199
        Me.DGVBukuPrev.Values.Text = "◄"
        '
        'DGVBukuPageCounter
        '
        Me.DGVBukuPageCounter.AlwaysActive = False
        Me.DGVBukuPageCounter.Enabled = False
        Me.DGVBukuPageCounter.Location = New System.Drawing.Point(945, 478)
        Me.DGVBukuPageCounter.MaxLength = 255
        Me.DGVBukuPageCounter.Name = "DGVBukuPageCounter"
        Me.DGVBukuPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVBukuPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVBukuPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVBukuPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVBukuPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVBukuPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBukuPageCounter.TabIndex = 201
        Me.DGVBukuPageCounter.Tag = ""
        Me.DGVBukuPageCounter.Text = "1 / 1"
        Me.DGVBukuPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BTNHapus.TabIndex = 5
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
        Me.BTNClear.TabIndex = 6
        Me.BTNClear.Values.Image = Global.Perpustakaan.My.Resources.Resources.crud_refresh_pressed
        Me.BTNClear.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNClear.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNClear.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.crud_refresh_common
        Me.BTNClear.Values.Text = ""
        '
        'BTNPrint
        '
        Me.BTNPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPrint.Enabled = False
        Me.BTNPrint.Location = New System.Drawing.Point(761, 520)
        Me.BTNPrint.Name = "BTNPrint"
        Me.BTNPrint.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNPrint.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPrint.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNPrint.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNPrint.OverrideDefault.Border.Rounding = 0!
        Me.BTNPrint.OverrideDefault.Border.Width = 3
        Me.BTNPrint.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNPrint.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNPrint.Size = New System.Drawing.Size(110, 110)
        Me.BTNPrint.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNPrint.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPrint.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.BTNPrint.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNPrint.StateCommon.Border.Rounding = 0!
        Me.BTNPrint.StateCommon.Border.Width = 3
        Me.BTNPrint.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNPrint.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNPrint.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNPrint.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNPrint.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPrint.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNPrint.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNPrint.StatePressed.Back.Color1 = System.Drawing.Color.White
        Me.BTNPrint.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNPrint.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNPrint.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNPrint.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BTNPrint.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNPrint.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.BTNPrint.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNPrint.TabIndex = 4
        Me.BTNPrint.Values.Image = Global.Perpustakaan.My.Resources.Resources.crud_print_pressed
        Me.BTNPrint.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNPrint.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNPrint.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNPrint.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.crud_print_common
        Me.BTNPrint.Values.Text = ""
        '
        'Rdt
        '
        Me.Rdt.DataSetName = "Rdt"
        Me.Rdt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLPinjamBindingSource
        '
        Me.TBLPinjamBindingSource.DataMember = "TBLPinjam"
        Me.TBLPinjamBindingSource.DataSource = Me.Rdt
        '
        'TBLPinjamTableAdapter
        '
        Me.TBLPinjamTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Pinjam
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.BTNPrint)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.THilang)
        Me.Controls.Add(Me.TAnggota)
        Me.Controls.Add(Me.DGVBukuPageCounter)
        Me.Controls.Add(Me.DGVBukuPrev)
        Me.Controls.Add(Me.DGVBukuNext)
        Me.Controls.Add(Me.LBLRusak)
        Me.Controls.Add(Me.LBLHilang)
        Me.Controls.Add(Me.LBLDipinjam)
        Me.Controls.Add(Me.LBLKembali)
        Me.Controls.Add(Me.LBLTelat)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.TCariData)
        Me.Controls.Add(Me.TRusak)
        Me.Controls.Add(Me.TDipinjam)
        Me.Controls.Add(Me.TTelat)
        Me.Controls.Add(Me.TKembali)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DGVBuku)
        Me.Controls.Add(Me.LBLAnggota)
        Me.Name = "Pinjam"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.TAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rdt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TAnggota As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LBLRusak As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLHilang As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLTelat As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TCariData As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents THilang As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TRusak As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TTelat As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DGVBuku As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LBLAnggota As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents TTotal As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TKembali As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLTotal As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLKembali As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TDipinjam As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LBLDipinjam As Krypton.Toolkit.KryptonLabel
    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBukuNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBukuPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVBukuPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BTNHapus As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNPrint As Krypton.Toolkit.KryptonButton
    Friend WithEvents Rdt As Rdt
    Friend WithEvents TBLPinjamBindingSource As BindingSource
    Friend WithEvents TBLPinjamTableAdapter As RdtTableAdapters.TBLPinjamTableAdapter
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents CIDBuku As DataGridViewTextBoxColumn
    Friend WithEvents CJudul As DataGridViewTextBoxColumn
    Friend WithEvents CTglPinjam As DataGridViewTextBoxColumn
    Friend WithEvents CTglKembali As DataGridViewTextBoxColumn
    Friend WithEvents CTelat As DataGridViewCheckBoxColumn
    Friend WithEvents CRusak As DataGridViewCheckBoxColumn
    Friend WithEvents CHilang As DataGridViewCheckBoxColumn
    Friend WithEvents CKeterangan As DataGridViewTextBoxColumn
    Friend WithEvents CDenda As DataGridViewTextBoxColumn
    Friend WithEvents CStatus As DataGridViewCheckBoxColumn
    Friend WithEvents CHarga As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
