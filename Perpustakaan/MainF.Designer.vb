<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        Me.PaletPrimer = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.PaletSekunder = New Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Sidebar = New Krypton.Toolkit.KryptonPanel()
        Me.BTNLogout = New Krypton.Toolkit.KryptonButton()
        Me.BTNCatatan = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLLainnya = New Krypton.Toolkit.KryptonLabel()
        Me.BTNPinjam = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLPeminjaman = New Krypton.Toolkit.KryptonLabel()
        Me.BTNBuku = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNAnggota = New Krypton.Toolkit.KryptonCheckButton()
        Me.BTNUser = New Krypton.Toolkit.KryptonCheckButton()
        Me.LBLFile = New Krypton.Toolkit.KryptonLabel()
        Me.Thumbnail = New Krypton.Toolkit.KryptonButton()
        Me.Header = New System.Windows.Forms.Panel()
        Me.BTNClose = New Krypton.Toolkit.KryptonButton()
        Me.BTNMinimize = New Krypton.Toolkit.KryptonButton()
        Me.LBLTitle = New Krypton.Toolkit.KryptonLabel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        CType(Me.Sidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidebar.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
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
        'PaletSekunder
        '
        Me.PaletSekunder.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PaletSekunder.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.PaletSekunder.Images.CheckBox.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.Common = CType(resources.GetObject("resource.Common2"), System.Drawing.Image)
        Me.PaletSekunder.Images.CheckBox.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled2"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedDisabled = CType(resources.GetObject("resource.CheckedDisabled3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedNormal = CType(resources.GetObject("resource.CheckedNormal3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedPressed = CType(resources.GetObject("resource.CheckedPressed3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.CheckedTracking = CType(resources.GetObject("resource.CheckedTracking3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.Common = CType(resources.GetObject("resource.Common3"), System.Drawing.Image)
        Me.PaletSekunder.Images.RadioButton.UncheckedDisabled = CType(resources.GetObject("resource.UncheckedDisabled3"), System.Drawing.Image)
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
        'Sidebar
        '
        Me.Sidebar.Controls.Add(Me.BTNLogout)
        Me.Sidebar.Controls.Add(Me.BTNCatatan)
        Me.Sidebar.Controls.Add(Me.LBLLainnya)
        Me.Sidebar.Controls.Add(Me.BTNPinjam)
        Me.Sidebar.Controls.Add(Me.LBLPeminjaman)
        Me.Sidebar.Controls.Add(Me.BTNBuku)
        Me.Sidebar.Controls.Add(Me.BTNAnggota)
        Me.Sidebar.Controls.Add(Me.BTNUser)
        Me.Sidebar.Controls.Add(Me.LBLFile)
        Me.Sidebar.Controls.Add(Me.Thumbnail)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Sidebar.Size = New System.Drawing.Size(159, 678)
        Me.Sidebar.StateCommon.Color1 = System.Drawing.Color.White
        Me.Sidebar.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Sidebar.TabIndex = 8
        '
        'BTNLogout
        '
        Me.BTNLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNLogout.Location = New System.Drawing.Point(0, 394)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNLogout.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogout.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogout.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNLogout.Size = New System.Drawing.Size(159, 40)
        Me.BTNLogout.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.BTNLogout.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNLogout.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNLogout.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLogout.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNLogout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNLogout.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogout.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNLogout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNLogout.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLogout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNLogout.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNLogout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNLogout.TabIndex = 7
        Me.BTNLogout.Values.Image = Global.Perpustakaan.My.Resources.Resources.sidebar_logout_common
        Me.BTNLogout.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.BTNLogout.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.BTNLogout.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.BTNLogout.Values.ImageStates.ImagePressed = Global.Perpustakaan.My.Resources.Resources.sidebar_logout_checked
        Me.BTNLogout.Values.ImageStates.ImageTracking = Global.Perpustakaan.My.Resources.Resources.sidebar_logout_tracking
        Me.BTNLogout.Values.Text = "Logout"
        '
        'BTNCatatan
        '
        Me.BTNCatatan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCatatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNCatatan.Location = New System.Drawing.Point(0, 354)
        Me.BTNCatatan.Name = "BTNCatatan"
        Me.BTNCatatan.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCatatan.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNCatatan.Size = New System.Drawing.Size(159, 40)
        Me.BTNCatatan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNCatatan.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNCatatan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNCatatan.StateCommon.Border.Rounding = 0!
        Me.BTNCatatan.StateCommon.Border.Width = 2
        Me.BTNCatatan.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNCatatan.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCatatan.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNCatatan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCatatan.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCatatan.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNCatatan.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNCatatan.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNCatatan.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNCatatan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNCatatan.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StatePressed.Border.Rounding = 0!
        Me.BTNCatatan.StatePressed.Border.Width = 2
        Me.BTNCatatan.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCatatan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNCatatan.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNCatatan.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNCatatan.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNCatatan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNCatatan.TabIndex = 5
        Me.BTNCatatan.Values.Image = Global.Perpustakaan.My.Resources.Resources.sidebar_catatan_checked
        Me.BTNCatatan.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.sidebar_catatan_common
        Me.BTNCatatan.Values.ImageStates.ImageTracking = Global.Perpustakaan.My.Resources.Resources.sidebar_catatan_tracking
        Me.BTNCatatan.Values.Text = "Catatan"
        '
        'LBLLainnya
        '
        Me.LBLLainnya.AutoSize = False
        Me.LBLLainnya.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLLainnya.Location = New System.Drawing.Point(0, 324)
        Me.LBLLainnya.Name = "LBLLainnya"
        Me.LBLLainnya.Size = New System.Drawing.Size(159, 30)
        Me.LBLLainnya.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LBLLainnya.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLLainnya.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLainnya.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLLainnya.TabIndex = 31
        Me.LBLLainnya.Values.Text = "Lainnya"
        '
        'BTNPinjam
        '
        Me.BTNPinjam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPinjam.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNPinjam.Location = New System.Drawing.Point(0, 284)
        Me.BTNPinjam.Name = "BTNPinjam"
        Me.BTNPinjam.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNPinjam.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPinjam.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPinjam.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNPinjam.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNPinjam.Size = New System.Drawing.Size(159, 40)
        Me.BTNPinjam.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNPinjam.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPinjam.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNPinjam.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNPinjam.StateCommon.Border.Rounding = 0!
        Me.BTNPinjam.StateCommon.Border.Width = 2
        Me.BTNPinjam.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNPinjam.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNPinjam.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNPinjam.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNPinjam.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPinjam.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNPinjam.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNPinjam.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPinjam.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPinjam.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNPinjam.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNPinjam.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPinjam.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPinjam.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNPinjam.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNPinjam.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNPinjam.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPinjam.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPinjam.StatePressed.Border.Rounding = 0!
        Me.BTNPinjam.StatePressed.Border.Width = 2
        Me.BTNPinjam.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNPinjam.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNPinjam.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNPinjam.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNPinjam.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNPinjam.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNPinjam.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNPinjam.TabIndex = 4
        Me.BTNPinjam.Values.Image = Global.Perpustakaan.My.Resources.Resources.sidebar_pinjam_checked
        Me.BTNPinjam.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.sidebar_pinjam_common
        Me.BTNPinjam.Values.ImageStates.ImageTracking = Global.Perpustakaan.My.Resources.Resources.sidebar_pinjam_tracking
        Me.BTNPinjam.Values.Text = "Pinjam"
        '
        'LBLPeminjaman
        '
        Me.LBLPeminjaman.AutoSize = False
        Me.LBLPeminjaman.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLPeminjaman.Location = New System.Drawing.Point(0, 254)
        Me.LBLPeminjaman.Name = "LBLPeminjaman"
        Me.LBLPeminjaman.Size = New System.Drawing.Size(159, 30)
        Me.LBLPeminjaman.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LBLPeminjaman.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLPeminjaman.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPeminjaman.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLPeminjaman.TabIndex = 27
        Me.LBLPeminjaman.Values.Text = "Peminjaman"
        '
        'BTNBuku
        '
        Me.BTNBuku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNBuku.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNBuku.Location = New System.Drawing.Point(0, 214)
        Me.BTNBuku.Name = "BTNBuku"
        Me.BTNBuku.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNBuku.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBuku.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBuku.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBuku.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNBuku.Size = New System.Drawing.Size(159, 40)
        Me.BTNBuku.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNBuku.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBuku.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNBuku.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNBuku.StateCommon.Border.Rounding = 0!
        Me.BTNBuku.StateCommon.Border.Width = 2
        Me.BTNBuku.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNBuku.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNBuku.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNBuku.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNBuku.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBuku.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNBuku.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNBuku.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBuku.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBuku.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNBuku.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNBuku.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBuku.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBuku.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBuku.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNBuku.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNBuku.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBuku.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBuku.StatePressed.Border.Rounding = 0!
        Me.BTNBuku.StatePressed.Border.Width = 2
        Me.BTNBuku.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBuku.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNBuku.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNBuku.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNBuku.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNBuku.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNBuku.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNBuku.TabIndex = 3
        Me.BTNBuku.Values.Image = Global.Perpustakaan.My.Resources.Resources.sidebar_buku_checked
        Me.BTNBuku.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.sidebar_buku_common
        Me.BTNBuku.Values.ImageStates.ImageTracking = Global.Perpustakaan.My.Resources.Resources.sidebar_buku_tracking
        Me.BTNBuku.Values.Text = "Buku"
        '
        'BTNAnggota
        '
        Me.BTNAnggota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAnggota.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNAnggota.Location = New System.Drawing.Point(0, 174)
        Me.BTNAnggota.Name = "BTNAnggota"
        Me.BTNAnggota.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNAnggota.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNAnggota.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNAnggota.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNAnggota.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNAnggota.Size = New System.Drawing.Size(159, 40)
        Me.BTNAnggota.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNAnggota.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNAnggota.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNAnggota.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNAnggota.StateCommon.Border.Rounding = 0!
        Me.BTNAnggota.StateCommon.Border.Width = 2
        Me.BTNAnggota.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNAnggota.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNAnggota.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNAnggota.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNAnggota.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAnggota.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNAnggota.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNAnggota.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNAnggota.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNAnggota.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNAnggota.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNAnggota.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNAnggota.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNAnggota.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNAnggota.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNAnggota.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNAnggota.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNAnggota.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNAnggota.StatePressed.Border.Rounding = 0!
        Me.BTNAnggota.StatePressed.Border.Width = 2
        Me.BTNAnggota.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNAnggota.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNAnggota.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNAnggota.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNAnggota.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNAnggota.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNAnggota.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNAnggota.TabIndex = 2
        Me.BTNAnggota.Values.Image = Global.Perpustakaan.My.Resources.Resources.sidebar_anggota_checked
        Me.BTNAnggota.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.sidebar_anggota_common
        Me.BTNAnggota.Values.ImageStates.ImageTracking = Global.Perpustakaan.My.Resources.Resources.sidebar_anggota_tracking
        Me.BTNAnggota.Values.Text = "Anggota"
        '
        'BTNUser
        '
        Me.BTNUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNUser.Location = New System.Drawing.Point(0, 134)
        Me.BTNUser.Name = "BTNUser"
        Me.BTNUser.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.BTNUser.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNUser.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNUser.Size = New System.Drawing.Size(159, 40)
        Me.BTNUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNUser.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BTNUser.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.BTNUser.StateCommon.Border.Rounding = 0!
        Me.BTNUser.StateCommon.Border.Width = 2
        Me.BTNUser.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNUser.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNUser.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, -1, -1, -1)
        Me.BTNUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNUser.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUser.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.BTNUser.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.BTNUser.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BTNUser.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.BTNUser.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateNormal.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BTNUser.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StatePressed.Border.Rounding = 0!
        Me.BTNUser.StatePressed.Border.Width = 2
        Me.BTNUser.StatePressed.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BTNUser.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNUser.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNUser.StateTracking.Content.Padding = New System.Windows.Forms.Padding(6, -1, -1, -1)
        Me.BTNUser.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BTNUser.TabIndex = 1
        Me.BTNUser.Values.Image = Global.Perpustakaan.My.Resources.Resources.sidebar_user_checked
        Me.BTNUser.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.sidebar_user_common
        Me.BTNUser.Values.ImageStates.ImageTracking = Global.Perpustakaan.My.Resources.Resources.sidebar_user_tracking
        Me.BTNUser.Values.Text = "User"
        '
        'LBLFile
        '
        Me.LBLFile.AutoSize = False
        Me.LBLFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLFile.Location = New System.Drawing.Point(0, 104)
        Me.LBLFile.Name = "LBLFile"
        Me.LBLFile.Size = New System.Drawing.Size(159, 30)
        Me.LBLFile.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LBLFile.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.LBLFile.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFile.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.LBLFile.TabIndex = 21
        Me.LBLFile.Values.Text = "File"
        '
        'Thumbnail
        '
        Me.Thumbnail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Thumbnail.Dock = System.Windows.Forms.DockStyle.Top
        Me.Thumbnail.Location = New System.Drawing.Point(0, 0)
        Me.Thumbnail.Name = "Thumbnail"
        Me.Thumbnail.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.Thumbnail.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.Thumbnail.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Thumbnail.Size = New System.Drawing.Size(159, 104)
        Me.Thumbnail.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.Thumbnail.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.Thumbnail.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.Thumbnail.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Thumbnail.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.Thumbnail.TabIndex = 0
        Me.Thumbnail.Values.Image = Global.Perpustakaan.My.Resources.Resources.thumbnail_pressed
        Me.Thumbnail.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.Thumbnail.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.Thumbnail.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.Thumbnail.Values.ImageStates.ImageNormal = Global.Perpustakaan.My.Resources.Resources.thumbnail_common
        Me.Thumbnail.Values.Text = ""
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Header.Controls.Add(Me.BTNClose)
        Me.Header.Controls.Add(Me.BTNMinimize)
        Me.Header.Controls.Add(Me.LBLTitle)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(159, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1111, 40)
        Me.Header.TabIndex = 9
        '
        'BTNClose
        '
        Me.BTNClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNClose.Location = New System.Drawing.Point(1066, 0)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClose.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClose.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNClose.Size = New System.Drawing.Size(45, 29)
        Me.BTNClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNClose.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNClose.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNClose.StateCommon.Content.Padding = New System.Windows.Forms.Padding(4, 4, -1, -1)
        Me.BTNClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.BTNClose.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClose.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BTNClose.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BTNClose.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNClose.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.BTNClose.TabIndex = 131
        Me.BTNClose.Values.Text = "✕"
        '
        'BTNMinimize
        '
        Me.BTNMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMinimize.Location = New System.Drawing.Point(1021, 0)
        Me.BTNMinimize.Name = "BTNMinimize"
        Me.BTNMinimize.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNMinimize.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.OverrideFocus.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNMinimize.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.BTNMinimize.Size = New System.Drawing.Size(45, 29)
        Me.BTNMinimize.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BTNMinimize.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.BTNMinimize.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.[False]
        Me.BTNMinimize.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-1, -1, -1, 6)
        Me.BTNMinimize.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.BTNMinimize.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMinimize.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.BTNMinimize.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.BTNMinimize.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BTNMinimize.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.BTNMinimize.TabIndex = 134
        Me.BTNMinimize.Values.Text = "‒"
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = False
        Me.LBLTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLTitle.Location = New System.Drawing.Point(0, 0)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.LBLTitle.Size = New System.Drawing.Size(1111, 40)
        Me.LBLTitle.StateCommon.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.LBLTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.LBLTitle.TabIndex = 133
        Me.LBLTitle.Values.Text = "Title"
        '
        'PanelForm
        '
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(159, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1111, 638)
        Me.PanelForm.TabIndex = 135
        '
        'MainF
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1270, 678)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perpustakaan"
        CType(Me.Sidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidebar.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaletPrimer As Krypton.Toolkit.KryptonPalette
    Friend WithEvents PaletSekunder As Krypton.Toolkit.KryptonPalette
    Friend WithEvents Sidebar As Krypton.Toolkit.KryptonPanel
    Friend WithEvents BTNLogout As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNCatatan As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLLainnya As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNPinjam As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLPeminjaman As Krypton.Toolkit.KryptonLabel
    Friend WithEvents BTNBuku As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNAnggota As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents BTNUser As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents LBLFile As Krypton.Toolkit.KryptonLabel
    Friend WithEvents Thumbnail As Krypton.Toolkit.KryptonButton
    Friend WithEvents Header As Panel
    Friend WithEvents BTNClose As Krypton.Toolkit.KryptonButton
    Friend WithEvents BTNMinimize As Krypton.Toolkit.KryptonButton
    Friend WithEvents LBLTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelForm As Panel
End Class
