Imports System.Globalization, System.IO, MadMilkman.Ini
Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not Directory.Exists(Path) Then
                Directory.CreateDirectory(Path)
            End If
            If Not File.Exists(Path & "\Rdt.ini") Then
                FileOpen(1, Path & "\Rdt.ini", OpenMode.Output)
                PrintLine(1, "[konfigurasi]")
                PrintLine(1, "cookies=")
                FileClose(1)
            End If
            Koneksi()
            Dim id = New CultureInfo("id-ID")
            CultureInfo.DefaultThreadCurrentCulture = id
            CultureInfo.DefaultThreadCurrentUICulture = id

            Dim Ini As New IniFile
            Ini.Load(Path & "\Rdt.ini")
            QR("SELECT Username FROM TBLUser WHERE Username = '" & Ini.Sections("konfigurasi").Keys("cookies").Value & "'")
            If DR.HasRows AndAlso DR(0) <> "Admin" Then
                UserAktif = DR(0)
                Application.MainForm = MainF
            Else
                Application.MainForm = Login
            End If
        End Sub
    End Class
End Namespace
