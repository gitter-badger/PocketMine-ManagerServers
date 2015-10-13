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
        Friend Class Installer
            'Shared Function getVersion(ByVal version As String)
            '    If version.ToLower = "stable" Then
            '        version = "1"

            '    ElseIf version.ToLower = "beta" Then
            '        version = "2"

            '    ElseIf version.ToLower = "dev" Then
            '        version = "3"

            '    ElseIf version.ToLower = "soft" Then
            '        version = "4"

            '    End If

            '    If version.ToLower = "1" Then
            '        version = "stable"

            '    ElseIf version.ToLower = "2" Then
            '        version = "beta"

            '    ElseIf version.ToLower = "3" Then
            '        version = "dev"

            '    ElseIf version.ToLower = "4" Then
            '        version = "soft"

            '    End If

            '    If version = "1" Then

            '    End If

            '    Return InstallerAPI.getInstaller.Installer.getVersion(version)
            'End Function

            Shared Function getInstallationStatus(ByVal installationstatus As String(), ByVal nservers As SByte)

                If nservers > 10 Or nservers < 1 Then
                    MsgBox("The number of servers cannot be > 10 or < 1")

                Else
                    For i = 1 To nservers
                        'Get the status
                    Next
                End If

                Return InstallerAPI.getInstaller.Installer.getInstallationStatus(installationstatus, nservers)
            End Function
        End Class

        Friend Class Downloader
            Shared Function getLinks(ByVal links As String)
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

            Shared Function getDownloadStatus()

                Return InstallerAPI.getInstaller.Downloader.getDownloadStatus
            End Function
        End Class
    End Class



End Namespace
