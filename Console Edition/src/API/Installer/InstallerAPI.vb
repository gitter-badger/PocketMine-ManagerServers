Namespace InstallerAPI
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
    Friend Class getInstaller

        Public Shared Function getVersion(ByVal version As String)
            If version.ToUpper = "STABLE" Or version = "1" Then
                version = "1.4.1 API 1.11.0 Zekkou-Cake" 'TODO: Separate PocketMine API's version from getVersion("version") --> getAPI("api")

            ElseIf version.ToUpper = "BETA" Or version = "2" Then
                version = "1.4.1 API 1.11.0 Zekkou-Cake"

            ElseIf version.ToUpper = "DEV" Or version = "3" Then
                version = "1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1258]"

            ElseIf version.ToUpper = "SOFT" Or version = "4" Then
                version = "1.5 API 1.12.0 Kappatsu-Fugu"

            End If

            Return InstallerAPI.getInstaller.getVersion(version)
        End Function

        Friend Class Installer
            Public Shared Function installVersion(ByVal version As String, Optional ByVal path As String() = Nothing, Optional ByVal nservers As SByte = -1)

                If path Is Nothing Then
                    path = New String() {"", "", "", "", "", "", "", "", "", ""}
                End If

                If version.ToUpper = "STABLE" Or version = "1" Then
                    Process.Start("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")

                ElseIf version.ToUpper = "BETA" Or version = "2" Then
                    ChangeInstallationFiles(path(nservers - 1), version, My.Computer.FileSystem.FileExists(path(nservers - 1) + "\PocketMine-MP.phar"), My.Computer.FileSystem.FileExists(path(nservers - 1) + "\PocketMine-MP.phar"))

                ElseIf version.ToUpper = "DEV" Or version = "3" Then
                    ChangeInstallationFiles(path(nservers - 1), version, My.Computer.FileSystem.FileExists(path(nservers - 1) + "\PocketMine-MP.phar"), My.Computer.FileSystem.FileExists(path(nservers - 1) + "\PocketMine-MP.phar"))

                ElseIf version.ToUpper = "SOFT" Or version = "4" Then
                    ChangeInstallationFiles(path(nservers - 1), version, My.Computer.FileSystem.FileExists(path(nservers - 1) + "\PocketMine-MP.phar"), My.Computer.FileSystem.FileExists(path(nservers - 1) + "\PocketMine-MP.phar"))

                End If

                Return InstallerAPI.getInstaller.Installer.installVersion(version, path, nservers)
            End Function

            Public Shared Function getInstallationStatus(ByVal nservers As SByte)

                If nservers > 10 Or nservers < 1 Then
                    MsgBox("The number of servers cannot be > 10 or < 1", MsgBoxStyle.Critical)

                Else
                    My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(nservers - 1) + ".pm")

                End If

                Return InstallerAPI.getInstaller.Installer.getInstallationStatus(nservers)
            End Function

            Public Shared Function changeInstallationStatus()


                Return InstallerAPI.getInstaller.Installer.changeInstallationStatus()
            End Function

        End Class

        Friend Class Downloader
            Public Shared Function getLinks(ByVal links As String)
                Dim linkstable, linkbeta, linkdev, linksoft As String

                linkstable = "https://github.com/PocketMine/PocketMine-MP/releases/download/1.4.1/PocketMine-MP_Installer_1.4.1_x86.exe"
                linkbeta = "https://github.com/PocketMine/PocketMine-MP/releases/download/1.4.1dev-936/PocketMine-MP_1.4.1dev-936.phar"
                linkdev = "http://jenkins.pocketmine.net/job/PocketMine-MP/1258/artifact/PocketMine-MP_1.5dev-1258_0380e900_API-1.12.0.phar"
                linksoft = "http://jenkins.pocketmine.net/job/PocketMine-Soft/lastSuccessfulBuild/artifact/PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar"

                If links.ToLower = "stable" Or links = "1" Then
                    links = linkstable

                ElseIf links.ToLower = "beta" Or links = "2" Then
                    links = linkbeta

                ElseIf links.ToLower = "dev" Or links = "3" Then
                    links = linkdev

                ElseIf links.ToLower = "soft" Or links = "4" Then
                    links = linksoft
                End If

                Return InstallerAPI.getInstaller.Downloader.getLinks(links)
            End Function

            Public Shared Function getDownloadStatus(ByVal nservers As SByte)
                If nservers > 10 Or nservers < 1 Then
                    MsgBox("The number of servers cannot be > 10 or < 1", MsgBoxStyle.Critical)

                Else
                    My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_" + Convert.ToString(nservers - 1) + ".pm")

                End If

                Return InstallerAPI.getInstaller.Downloader.getDownloadStatus(nservers)
            End Function

            Public Shared Function changeDownloadStatus()


                Return InstallerAPI.getInstaller.Installer.changeInstallationStatus()
            End Function

        End Class
    End Class
End Namespace
