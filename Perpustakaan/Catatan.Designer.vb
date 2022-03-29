<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catatan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catatan))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVPageCounter = New Krypton.Toolkit.KryptonTextBox()
        Me.DGVPrev = New Krypton.Toolkit.KryptonButton()
        Me.DGVNext = New Krypton.Toolkit.KryptonButton()
        Me.DGV = New Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TAnggota = New Krypton.Toolkit.KryptonComboBox()
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.LBLEntitas = New Krypton.Toolkit.KryptonLabel()
        Me.TBuku = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLBuku = New Krypton.Toolkit.KryptonLabel()
        Me.TUser = New Krypton.Toolkit.KryptonComboBox()
        Me.LBLAnggota = New Krypton.Toolkit.KryptonLabel()
        Me.LBLUser = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLRencana = New Krypton.Toolkit.KryptonLabel()
        Me.CBTglKembali = New Krypton.Toolkit.KryptonCheckBox()
        Me.CBTglPinjam = New Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBLPeriodik = New Krypton.Toolkit.KryptonLabel()
        Me.TDari = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.TSampai = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.LBLSampai = New Krypton.Toolkit.KryptonLabel()
        Me.LBLDari = New Krypton.Toolkit.KryptonLabel()
        Me.PemisahV = New Krypton.Toolkit.KryptonBorderEdge()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBDikembalikan = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBHilang = New Krypton.Toolkit.KryptonRadioButton()
        Me.RBDipinjam = New Krypton.Toolkit.KryptonRadioButton()
        Me.LBLStatus = New Krypton.Toolkit.KryptonLabel()
        Me.LBLFilter = New Krypton.Toolkit.KryptonTextBox()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CJudul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTglPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTglKembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTelat = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CRusak = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CHilang = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.TAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVPageCounter
        '
        Me.DGVPageCounter.AlwaysActive = False
        Me.DGVPageCounter.Enabled = False
        Me.DGVPageCounter.Location = New System.Drawing.Point(510, 610)
        Me.DGVPageCounter.MaxLength = 255
        Me.DGVPageCounter.Name = "DGVPageCounter"
        Me.DGVPageCounter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGVPageCounter.Size = New System.Drawing.Size(90, 26)
        Me.DGVPageCounter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.DGVPageCounter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVPageCounter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPageCounter.TabIndex = 173
        Me.DGVPageCounter.Tag = ""
        Me.DGVPageCounter.Text = "1 / 1"
        Me.DGVPageCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVPrev
        '
        Me.DGVPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVPrev.Enabled = False
        Me.DGVPrev.Location = New System.Drawing.Point(478, 610)
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
        Me.DGVPrev.TabIndex = 171
        Me.DGVPrev.Values.Text = "◄"
        '
        'DGVNext
        '
        Me.DGVNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVNext.Enabled = False
        Me.DGVNext.Location = New System.Drawing.Point(606, 610)
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
        Me.DGVNext.TabIndex = 172
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNama, Me.CJudul, Me.CTglPinjam, Me.CTglKembali, Me.CTelat, Me.CRusak, Me.CHilang, Me.CKeterangan, Me.CDenda, Me.CStatus, Me.CUsername})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV.HideOuterBorders = True
        Me.DGV.Location = New System.Drawing.Point(8, 172)
        Me.DGV.Name = "DGV"
        Me.DGV.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 27
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV.Size = New System.Drawing.Size(1095, 432)
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
        Me.DGV.TabIndex = 1
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(8, 8)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        Me.KryptonGroup1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel4)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonBorderEdge2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.PemisahV)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel2)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1095, 115)
        Me.KryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.KryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonGroup1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonGroup1.StateCommon.Border.Width = 3
        Me.KryptonGroup1.TabIndex = 169
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TAnggota)
        Me.Panel4.Controls.Add(Me.LBLEntitas)
        Me.Panel4.Controls.Add(Me.TBuku)
        Me.Panel4.Controls.Add(Me.LBLBuku)
        Me.Panel4.Controls.Add(Me.TUser)
        Me.Panel4.Controls.Add(Me.LBLAnggota)
        Me.Panel4.Controls.Add(Me.LBLUser)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(547, 109)
        Me.Panel4.TabIndex = 28
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
        Me.TAnggota.Location = New System.Drawing.Point(85, 54)
        Me.TAnggota.MaxDropDownItems = 20
        Me.TAnggota.Name = "TAnggota"
        Me.TAnggota.Palette = Me.PaletSekunder
        Me.TAnggota.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TAnggota.Size = New System.Drawing.Size(456, 26)
        Me.TAnggota.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TAnggota.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TAnggota.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAnggota.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TAnggota.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TAnggota.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TAnggota.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TAnggota.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TAnggota.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TAnggota.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TAnggota.TabIndex = 1
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
        'LBLEntitas
        '
        Me.LBLEntitas.AutoSize = False
        Me.LBLEntitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLEntitas.Location = New System.Drawing.Point(0, 0)
        Me.LBLEntitas.Name = "LBLEntitas"
        Me.LBLEntitas.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLEntitas.Size = New System.Drawing.Size(547, 26)
        Me.LBLEntitas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLEntitas.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLEntitas.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLEntitas.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLEntitas.TabIndex = 13
        Me.LBLEntitas.Values.Text = "Entitas"
        '
        'TBuku
        '
        Me.TBuku.AlwaysActive = False
        Me.TBuku.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TBuku.DropDownHeight = 500
        Me.TBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TBuku.DropDownWidth = 119
        Me.TBuku.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TBuku.IntegralHeight = False
        Me.TBuku.Location = New System.Drawing.Point(85, 81)
        Me.TBuku.MaxDropDownItems = 20
        Me.TBuku.Name = "TBuku"
        Me.TBuku.Palette = Me.PaletSekunder
        Me.TBuku.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TBuku.Size = New System.Drawing.Size(456, 26)
        Me.TBuku.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TBuku.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBuku.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuku.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TBuku.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TBuku.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TBuku.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBuku.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TBuku.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TBuku.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TBuku.TabIndex = 2
        '
        'LBLBuku
        '
        Me.LBLBuku.AutoSize = False
        Me.LBLBuku.Location = New System.Drawing.Point(3, 81)
        Me.LBLBuku.Name = "LBLBuku"
        Me.LBLBuku.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLBuku.Size = New System.Drawing.Size(76, 26)
        Me.LBLBuku.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLBuku.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLBuku.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLBuku.TabIndex = 13
        Me.LBLBuku.Values.Text = "Buku"
        '
        'TUser
        '
        Me.TUser.AlwaysActive = False
        Me.TUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.TUser.DropDownHeight = 500
        Me.TUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TUser.DropDownWidth = 119
        Me.TUser.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TUser.IntegralHeight = False
        Me.TUser.Location = New System.Drawing.Point(85, 27)
        Me.TUser.MaxDropDownItems = 20
        Me.TUser.Name = "TUser"
        Me.TUser.Palette = Me.PaletSekunder
        Me.TUser.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TUser.Size = New System.Drawing.Size(456, 26)
        Me.TUser.StateActive.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!)
        Me.TUser.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUser.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Trebuchet MS", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUser.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.TUser.StateCommon.DropBack.Color1 = System.Drawing.Color.White
        Me.TUser.StateCommon.Item.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TUser.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUser.StateCommon.Item.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.TUser.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TUser.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.TUser.TabIndex = 0
        '
        'LBLAnggota
        '
        Me.LBLAnggota.AutoSize = False
        Me.LBLAnggota.Location = New System.Drawing.Point(3, 54)
        Me.LBLAnggota.Name = "LBLAnggota"
        Me.LBLAnggota.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLAnggota.Size = New System.Drawing.Size(76, 26)
        Me.LBLAnggota.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLAnggota.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLAnggota.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLAnggota.TabIndex = 13
        Me.LBLAnggota.Values.Text = "Anggota"
        '
        'LBLUser
        '
        Me.LBLUser.AutoSize = False
        Me.LBLUser.Location = New System.Drawing.Point(3, 27)
        Me.LBLUser.Name = "LBLUser"
        Me.LBLUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLUser.Size = New System.Drawing.Size(76, 26)
        Me.LBLUser.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLUser.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLUser.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLUser.TabIndex = 13
        Me.LBLUser.Values.Text = "User"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(547, 0)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(3, 109)
        Me.KryptonBorderEdge2.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge2.StateCommon.Width = 3
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge4"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLRencana)
        Me.Panel1.Controls.Add(Me.CBTglKembali)
        Me.Panel1.Controls.Add(Me.CBTglPinjam)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(550, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 109)
        Me.Panel1.TabIndex = 24
        '
        'LBLRencana
        '
        Me.LBLRencana.AutoSize = False
        Me.LBLRencana.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLRencana.Location = New System.Drawing.Point(0, 0)
        Me.LBLRencana.Name = "LBLRencana"
        Me.LBLRencana.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLRencana.Size = New System.Drawing.Size(170, 26)
        Me.LBLRencana.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLRencana.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLRencana.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLRencana.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLRencana.TabIndex = 13
        Me.LBLRencana.Values.Text = "Rencana Tanggal"
        '
        'CBTglKembali
        '
        Me.CBTglKembali.Location = New System.Drawing.Point(7, 70)
        Me.CBTglKembali.Name = "CBTglKembali"
        Me.CBTglKembali.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTglKembali.Palette = Me.PaletSekunder
        Me.CBTglKembali.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBTglKembali.Size = New System.Drawing.Size(91, 26)
        Me.CBTglKembali.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTglKembali.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBTglKembali.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!)
        Me.CBTglKembali.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBTglKembali.TabIndex = 1
        Me.CBTglKembali.Values.Text = "Kembali"
        '
        'CBTglPinjam
        '
        Me.CBTglPinjam.Location = New System.Drawing.Point(7, 38)
        Me.CBTglPinjam.Name = "CBTglPinjam"
        Me.CBTglPinjam.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTglPinjam.Palette = Me.PaletSekunder
        Me.CBTglPinjam.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.CBTglPinjam.Size = New System.Drawing.Size(82, 26)
        Me.CBTglPinjam.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.CBTglPinjam.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBTglPinjam.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!)
        Me.CBTglPinjam.StateDisabled.ShortText.Color1 = System.Drawing.Color.Gray
        Me.CBTglPinjam.TabIndex = 0
        Me.CBTglPinjam.Values.Text = "Pinjam"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Right
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(720, 0)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(3, 109)
        Me.KryptonBorderEdge1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonBorderEdge1.StateCommon.Width = 3
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge4"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LBLPeriodik)
        Me.Panel3.Controls.Add(Me.TDari)
        Me.Panel3.Controls.Add(Me.TSampai)
        Me.Panel3.Controls.Add(Me.LBLSampai)
        Me.Panel3.Controls.Add(Me.LBLDari)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(723, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 109)
        Me.Panel3.TabIndex = 18
        '
        'LBLPeriodik
        '
        Me.LBLPeriodik.AutoSize = False
        Me.LBLPeriodik.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLPeriodik.Location = New System.Drawing.Point(0, 0)
        Me.LBLPeriodik.Name = "LBLPeriodik"
        Me.LBLPeriodik.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLPeriodik.Size = New System.Drawing.Size(193, 26)
        Me.LBLPeriodik.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLPeriodik.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPeriodik.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLPeriodik.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLPeriodik.TabIndex = 14
        Me.LBLPeriodik.Values.Text = "Periodik"
        '
        'TDari
        '
        Me.TDari.AlwaysActive = False
        Me.TDari.CustomFormat = "dd/MM/yyyy"
        Me.TDari.Enabled = False
        Me.TDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TDari.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TDari.Location = New System.Drawing.Point(87, 38)
        Me.TDari.Name = "TDari"
        Me.TDari.Palette = Me.PaletSekunder
        Me.TDari.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TDari.Size = New System.Drawing.Size(101, 26)
        Me.TDari.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TDari.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDari.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TDari.TabIndex = 0
        Me.TDari.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'TSampai
        '
        Me.TSampai.AlwaysActive = False
        Me.TSampai.CustomFormat = "dd/MM/yyyy"
        Me.TSampai.Enabled = False
        Me.TSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TSampai.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3
        Me.TSampai.Location = New System.Drawing.Point(87, 70)
        Me.TSampai.Name = "TSampai"
        Me.TSampai.Palette = Me.PaletSekunder
        Me.TSampai.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.TSampai.Size = New System.Drawing.Size(101, 26)
        Me.TSampai.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TSampai.StateCommon.Content.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSampai.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.TSampai.TabIndex = 1
        Me.TSampai.ValueNullable = New Date(2022, 1, 16, 16, 43, 0, 0)
        '
        'LBLSampai
        '
        Me.LBLSampai.AutoSize = False
        Me.LBLSampai.Location = New System.Drawing.Point(3, 70)
        Me.LBLSampai.Name = "LBLSampai"
        Me.LBLSampai.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLSampai.Size = New System.Drawing.Size(70, 26)
        Me.LBLSampai.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLSampai.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLSampai.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLSampai.TabIndex = 13
        Me.LBLSampai.Values.Text = "Sampai"
        '
        'LBLDari
        '
        Me.LBLDari.AutoSize = False
        Me.LBLDari.Location = New System.Drawing.Point(3, 38)
        Me.LBLDari.Name = "LBLDari"
        Me.LBLDari.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLDari.Size = New System.Drawing.Size(70, 26)
        Me.LBLDari.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDari.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLDari.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLDari.TabIndex = 13
        Me.LBLDari.Values.Text = "Dari"
        '
        'PemisahV
        '
        Me.PemisahV.Dock = System.Windows.Forms.DockStyle.Right
        Me.PemisahV.Location = New System.Drawing.Point(916, 0)
        Me.PemisahV.Name = "PemisahV"
        Me.PemisahV.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PemisahV.Size = New System.Drawing.Size(3, 109)
        Me.PemisahV.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PemisahV.StateCommon.Width = 3
        Me.PemisahV.Text = "KryptonBorderEdge4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel2.Controls.Add(Me.RBDikembalikan)
        Me.Panel2.Controls.Add(Me.RBHilang)
        Me.Panel2.Controls.Add(Me.RBDipinjam)
        Me.Panel2.Controls.Add(Me.LBLStatus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(919, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 109)
        Me.Panel2.TabIndex = 15
        '
        'RBDikembalikan
        '
        Me.RBDikembalikan.Location = New System.Drawing.Point(3, 54)
        Me.RBDikembalikan.Name = "RBDikembalikan"
        Me.RBDikembalikan.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBDikembalikan.Palette = Me.PaletSekunder
        Me.RBDikembalikan.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBDikembalikan.Size = New System.Drawing.Size(138, 26)
        Me.RBDikembalikan.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBDikembalikan.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDikembalikan.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBDikembalikan.TabIndex = 1
        Me.RBDikembalikan.Values.Text = "Telah Kembali"
        '
        'RBHilang
        '
        Me.RBHilang.Location = New System.Drawing.Point(3, 81)
        Me.RBHilang.Name = "RBHilang"
        Me.RBHilang.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBHilang.Palette = Me.PaletSekunder
        Me.RBHilang.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBHilang.Size = New System.Drawing.Size(77, 26)
        Me.RBHilang.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBHilang.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBHilang.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBHilang.TabIndex = 2
        Me.RBHilang.Values.Text = "Hilang"
        '
        'RBDipinjam
        '
        Me.RBDipinjam.Location = New System.Drawing.Point(3, 27)
        Me.RBDipinjam.Name = "RBDipinjam"
        Me.RBDipinjam.OverrideFocus.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBDipinjam.Palette = Me.PaletSekunder
        Me.RBDipinjam.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.RBDipinjam.Size = New System.Drawing.Size(156, 26)
        Me.RBDipinjam.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.RBDipinjam.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDipinjam.StateDisabled.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.RBDipinjam.TabIndex = 0
        Me.RBDipinjam.Values.Text = "Sedang Dipinjam"
        '
        'LBLStatus
        '
        Me.LBLStatus.AutoSize = False
        Me.LBLStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLStatus.Location = New System.Drawing.Point(0, 0)
        Me.LBLStatus.Name = "LBLStatus"
        Me.LBLStatus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLStatus.Size = New System.Drawing.Size(170, 26)
        Me.LBLStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLStatus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLStatus.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 12.5!, System.Drawing.FontStyle.Bold)
        Me.LBLStatus.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLStatus.TabIndex = 13
        Me.LBLStatus.Values.Text = "Status"
        '
        'LBLFilter
        '
        Me.LBLFilter.AlwaysActive = False
        Me.LBLFilter.CueHint.Color1 = System.Drawing.Color.Gray
        Me.LBLFilter.CueHint.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Italic)
        Me.LBLFilter.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.LBLFilter.Enabled = False
        Me.LBLFilter.Location = New System.Drawing.Point(8, 123)
        Me.LBLFilter.MaxLength = 100
        Me.LBLFilter.Multiline = True
        Me.LBLFilter.Name = "LBLFilter"
        Me.LBLFilter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLFilter.Size = New System.Drawing.Size(1095, 50)
        Me.LBLFilter.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LBLFilter.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilter.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.LBLFilter.StateActive.Border.Rounding = 0!
        Me.LBLFilter.StateActive.Border.Width = 1
        Me.LBLFilter.StateActive.Content.Color1 = System.Drawing.Color.Black
        Me.LBLFilter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LBLFilter.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.LBLFilter.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFilter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.LBLFilter.StateCommon.Border.Rounding = 0!
        Me.LBLFilter.StateCommon.Border.Width = 1
        Me.LBLFilter.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLFilter.StateCommon.Content.Font = New System.Drawing.Font("Verdana", 13.75!)
        Me.LBLFilter.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.LBLFilter.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.LBLFilter.StateDisabled.Border.Rounding = 0!
        Me.LBLFilter.StateDisabled.Border.Width = 0
        Me.LBLFilter.TabIndex = 0
        Me.LBLFilter.Text = "Semua Peminjaman"
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama Anggota"
        Me.CNama.Name = "CNama"
        Me.CNama.ReadOnly = True
        Me.CNama.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CNama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CNama.Width = 140
        '
        'CJudul
        '
        Me.CJudul.HeaderText = "Judul Buku"
        Me.CJudul.Name = "CJudul"
        Me.CJudul.ReadOnly = True
        Me.CJudul.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CJudul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CJudul.Width = 163
        '
        'CTglPinjam
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTglPinjam.DefaultCellStyle = DataGridViewCellStyle2
        Me.CTglPinjam.HeaderText = "Tgl Pinjam"
        Me.CTglPinjam.Name = "CTglPinjam"
        Me.CTglPinjam.ReadOnly = True
        Me.CTglPinjam.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTglPinjam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTglPinjam.Width = 107
        '
        'CTglKembali
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CTglKembali.DefaultCellStyle = DataGridViewCellStyle3
        Me.CTglKembali.HeaderText = "Tgl Kembali"
        Me.CTglKembali.Name = "CTglKembali"
        Me.CTglKembali.ReadOnly = True
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
        Me.CRusak.ReadOnly = True
        Me.CRusak.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CRusak.TrueValue = "1"
        Me.CRusak.Width = 60
        '
        'CHilang
        '
        Me.CHilang.FalseValue = "0"
        Me.CHilang.HeaderText = "Hilang"
        Me.CHilang.Name = "CHilang"
        Me.CHilang.ReadOnly = True
        Me.CHilang.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CHilang.TrueValue = "1"
        Me.CHilang.Width = 60
        '
        'CKeterangan
        '
        Me.CKeterangan.HeaderText = "Keterangan"
        Me.CKeterangan.Name = "CKeterangan"
        Me.CKeterangan.ReadOnly = True
        Me.CKeterangan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CKeterangan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CKeterangan.Width = 150
        '
        'CDenda
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,##0"
        Me.CDenda.DefaultCellStyle = DataGridViewCellStyle4
        Me.CDenda.HeaderText = "Denda"
        Me.CDenda.Name = "CDenda"
        Me.CDenda.ReadOnly = True
        Me.CDenda.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CDenda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CDenda.Width = 86
        '
        'CStatus
        '
        Me.CStatus.FalseValue = "0"
        Me.CStatus.HeaderText = "Status"
        Me.CStatus.Name = "CStatus"
        Me.CStatus.ReadOnly = True
        Me.CStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CStatus.TrueValue = "1"
        Me.CStatus.Width = 60
        '
        'CUsername
        '
        Me.CUsername.HeaderText = "Username"
        Me.CUsername.Name = "CUsername"
        Me.CUsername.ReadOnly = True
        Me.CUsername.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CUsername.Width = 101
        '
        'Catatan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.KryptonGroup1)
        Me.Controls.Add(Me.LBLFilter)
        Me.Controls.Add(Me.DGVPageCounter)
        Me.Controls.Add(Me.DGVPrev)
        Me.Controls.Add(Me.DGVNext)
        Me.Controls.Add(Me.DGV)
        Me.Name = "Catatan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1111, 638)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.TAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVPageCounter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DGVPrev As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGVNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TDari As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents TSampai As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents LBLSampai As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLDari As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PemisahV As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBLStatus As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLBuku As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLAnggota As Krypton.Toolkit.KryptonLabel
    Friend WithEvents LBLUser As Krypton.Toolkit.KryptonLabel
    Friend WithEvents TBuku As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TAnggota As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TUser As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents LBLPeriodik As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LBLEntitas As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLRencana As Krypton.Toolkit.KryptonLabel
    Friend WithEvents CBTglKembali As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents CBTglPinjam As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents RBDikembalikan As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBHilang As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RBDipinjam As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents LBLFilter As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents CNama As DataGridViewTextBoxColumn
    Friend WithEvents CJudul As DataGridViewTextBoxColumn
    Friend WithEvents CTglPinjam As DataGridViewTextBoxColumn
    Friend WithEvents CTglKembali As DataGridViewTextBoxColumn
    Friend WithEvents CTelat As DataGridViewCheckBoxColumn
    Friend WithEvents CRusak As DataGridViewCheckBoxColumn
    Friend WithEvents CHilang As DataGridViewCheckBoxColumn
    Friend WithEvents CKeterangan As DataGridViewTextBoxColumn
    Friend WithEvents CDenda As DataGridViewTextBoxColumn
    Friend WithEvents CStatus As DataGridViewCheckBoxColumn
    Friend WithEvents CUsername As DataGridViewTextBoxColumn
End Class
