Module ManagerInstaller
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
    Sub ManagerInstaller(ByRef path As String(), ByRef nameservers As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef numberservers As String(), ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef versionstatus As String(), ByRef checknameserver As Object(), _
                         ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, _
                         ByRef writepath2 As String, ByRef writepath3 As String, ByRef menu1 As String, ByRef installertitle As String, ByRef installer1 As String, ByRef installer2 As String, ByRef installer3 As String, ByRef installatortitle As String, ByRef installator1 As String, ByRef installator2 As String, ByRef installator3 As String, ByRef installator4 As String, ByRef installator5 As String, _
                         ByRef installator6 As String, ByRef installator7 As String, ByRef downloadertitle As String, ByRef downloader1 As String, ByRef downloader2 As String, ByRef downloader3 As String, ByRef downloader4 As String, ByRef downloader5 As String, ByRef downloader6 As String, ByRef downloader7 As String, ByRef downloader8 As String, _
                         ByRef downloader9 As String, ByRef downloader10 As String, ByRef downloader11 As String, ByRef versions1 As String, ByRef versions2 As String, ByRef versions3 As String)

        '#Variables "Install PocketMine-MP"
        Dim chooseinstallation As String

        Checking(checknameserver, checkpath)

        nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        For i = 1 To nservers
            installationstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm")
            downloadstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm")
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
            versionstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\VersionStatus_" + Convert.ToString(i) + ".pm")
        Next

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("{0}", installertitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", installer1)
            Console.WriteLine("2- {0}", installer2)
            Console.WriteLine("3- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", installer3)
            chooseinstallation = Console.ReadLine

            If chooseinstallation = "1" Then
                Downloader.Downloader(nameservers, nservers, checkpath, path, numberservers, downloadstatus, versionstatus, checknameserver, back, changemade, status1, version1, versionstable1, versionbeta1, _
                                        versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, _
                                        downloader8, downloader9, downloader10, downloader11)

            End If

            If chooseinstallation = "2" Then
                Installator.Installator(checkpath, nservers, nameservers, installationstatus, versionstatus, path, numberservers, back, changemade, status1, version1, versionstable1, versionbeta1, _
                                        versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menu1, installatortitle, installator1, installator2, installator3, installator4, installator5, installator6, _
                                        installator7, versions1, versions2, versions3)

            End If

        Loop While chooseinstallation <> "3"
    End Sub

    Sub ChangeVersionStatus(ByRef version As String, ByRef chooseserver As String, ByRef versionstatus As String(), ByRef changemade As String)

        Dim index As Integer
        Dim indexstatus As Integer = -1
        Dim status As String() = New String() {"Stable", "Beta", "Dev", "Soft"}
        Dim verified As Boolean = False

        While verified = False
            index = Convert.ToInt32(chooseserver)
            indexstatus += 1

            If version = Convert.ToString(indexstatus) Then
                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\VersionStatus_" + Convert.ToString(index) + ".pm")
                versionstatus(index - 1) = status(indexstatus - 1)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\VersionStatus_" + Convert.ToString(index) + ".pm", versionstatus(index - 1), True)
                verified = True

            End If
        End While

        Console.WriteLine()
        Console.WriteLine("{0}", changemade)
        Console.ReadLine()
    End Sub
End Module
