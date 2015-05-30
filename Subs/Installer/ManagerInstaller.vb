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
    Sub ManagerInstaller(ByRef path As String(), ByRef nameservers As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef numberservers As String(), ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef versionstatus As String(), ByRef checknameserver As Object())

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
            Console.WriteLine("--------------------------<Initialize PocketMine-MP>----------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Download")
            Console.WriteLine("2- Install")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Choose what do you want to do: ")
            chooseinstallation = Console.ReadLine

            If chooseinstallation = "1" Then
                Downloader.Downloader(nameservers, nservers, checkpath, path, numberservers, downloadstatus, versionstatus, checknameserver)

            End If

            If chooseinstallation = "2" Then
                Installator.Installator(checkpath, nservers, nameservers, installationstatus, versionstatus, path, numberservers)

            End If

        Loop While chooseinstallation <> "3"
    End Sub

    Sub ChangeVersionStatus(ByRef version As String, ByRef chooseserver As String, ByRef versionstatus As String())

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
        Console.WriteLine("Changes made! Press ENTER to return to menu.")
        Console.ReadLine()
    End Sub
End Module
