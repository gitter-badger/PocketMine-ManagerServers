Public Class Loader
    ' _____           _        _   __  __ _                   __  __                                   _____                              
    '|  __ \         | |      | | |  \/  (_)                 |  \/  |                                 / ____|                             
    '| |__) |__   ___| | _____| |_| \  / |_ _ __   ___ ______| \  / | __ _ _ __   __ _  __ _  ___ _ _| (___   ___ _ ____   _____ _ __ ___ 
    '|  ___/ _ \ / __| |/ / _ \ __| |\/| | | '_ \ / _ \______| |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__\___ \ / _ \ '__\ \ / / _ \ '__/ __|
    '| |  | (_) | (__|   <  __/ |_| |  | | | | | |  __/      | |  | | (_| | | | | (_| | (_| |  __/ |  ____) |  __/ |   \ V /  __/ |  \__ \
    '|_|   \___/ \___|_|\_\___|\__|_|  |_|_|_| |_|\___|      |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_____/ \___|_|    \_/ \___|_|  |___/
    '                                                                                   __/ |                                             
    '                                                                                  |___/                                              
    'Copyright (C) 2015  matcracker

    'This program is free software: you can redistribute it and/or modify 
    'it under the terms of the GNU Lesser General Public License as published by 
    'the Free Software Foundation, either version 3 of the License, or 
    '(at your option) any later version. 
    Public Sub Loader(ByRef checklanguage As Object, ByRef versionstatus As String(), ByRef dirinstallations As Object, ByRef checkinstallations As Object(), ByRef checkdownloads As Object(), ByVal checkperformance As Object, ByRef checknameserver As Object, ByRef nameservers As String(), ByRef performancestatus As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef checknservers As Object, ByRef checkfolderinstallation As Object,
               ByRef dirpath As Object, ByRef dirdata As Object, ByRef dirservername As Object, ByRef dirperformance As Object, ByRef dirutils As Object, ByRef checklicense As Object, ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef backupstatus As String(), ByRef dirlanguages As Object, ByRef dirbackups As Object)
        Dim LoaderProgressBar As ProgressBar

        Dim quit As String = "N"

        checklicense = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\LICENSE.pdf")

        checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Data\servers.pm")

        checklanguage = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Data\langselection.pm")

        For i = 1 To 10
            checkperformance(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm")
            checkinstallations(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm")
            checkdownloads(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm")

        Next

        checkfolderinstallation = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]")
        dirpath = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Path")
        dirservername = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\ServersName")
        dirdata = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Data")
        dirperformance = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Performance")
        dirutils = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Utils")
        dirinstallations = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations")
        dirlanguages = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Languages")
        dirbackups = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Backups")
        Checking(checknameserver, checkpath)

        If dirpath And dirservername And checkfolderinstallation And dirperformance And dirdata And dirutils And dirlanguages And dirinstallations And dirbackups And checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) _
             And checkperformance(0) And checkperformance(1) And checkperformance(2) And checkperformance(3) And checkperformance(4) And checkperformance(5) And checkperformance(6) And checkperformance(7) And checkperformance(8) And checkperformance(9) And checkinstallations(0) _
             And checkinstallations(1) And checkinstallations(2) And checkinstallations(3) And checkinstallations(4) And checkinstallations(5) And checkinstallations(6) And checkinstallations(7) And checkinstallations(8) And checkinstallations(9) And checkdownloads(0) And checkdownloads(1) _
             And checkdownloads(2) And checkdownloads(3) And checkdownloads(4) And checkdownloads(5) And checkdownloads(6) And checkdownloads(7) And checkdownloads(8) And checkdownloads(9) Then

            Reading(path, nservers, nameservers)

        Else
            Main.Hide()
            Me.Show()

            LoaderProgressBar = New ProgressBar()

            LoaderProgressBar.Location = New Point(12, 65)
            LoaderProgressBar.Size = New Point(348, 23)
            LoaderProgressBar.Minimum = 0
            LoaderProgressBar.Maximum = 100

            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]") ' Create Installation Folder
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\ServersName") 'Create Folder Server Name
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Path") 'Create Folder Path
            LoaderProgressBar.Value = 27
            Me.Controls.Add(LoaderProgressBar)
            System.Threading.Thread.Sleep(500)
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Data") 'Create Folder Data
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Performance") 'Create Folder Performance
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Utils") 'Create Folder Utils
            LoaderProgressBar.Value = 54
            Me.Controls.Add(LoaderProgressBar)
            System.Threading.Thread.Sleep(500)
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations") 'Create Folder Installations
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Languages") 'Create Folder Languages
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Backups") 'Create Folder Backups
            LoaderProgressBar.Value = 81
            Me.Controls.Add(LoaderProgressBar)
            System.Threading.Thread.Sleep(500)
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Backups\Status") 'Create Folder Backups -> Status
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers[GUI]\Backups\Servers") 'Create Folder Backups -> Servers
            LoaderProgressBar.Value = 100
            Me.Controls.Add(LoaderProgressBar)

            For i = 1 To 10
                performancestatus(i - 1) = "Personal"
                downloadstatus(i - 1) = "Not Downloaded"
                installationstatus(i - 1) = "Not Installed"
                versionstatus(i - 1) = "No version"
                backupstatus(i - 1) = "Not Backuped"
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm", performancestatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm", downloadstatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm", installationstatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Installations\VersionStatus_" + Convert.ToString(i) + ".pm", versionstatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm", backupstatus(i - 1), True)
            Next
            Me.Close()
            CompleteLoader.CompleteLoader()


        End If
    End Sub
End Class