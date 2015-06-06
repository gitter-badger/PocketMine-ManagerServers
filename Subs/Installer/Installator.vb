Module Installator
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
    Sub Installator(ByRef checkpath As Object(), ByRef nservers As Integer, ByRef nameservers As String(), ByRef installationstatus As String(), ByRef versionstatus As String(), ByRef path As String(), ByRef numberservers As String())
        Dim chooseserver, version, stable, beta, dev, soft As String

        Dim checkpocketmine, checkbeta, checkdev, checksoft As Object

        Dim checkphar1, checkphar2 As Object

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")

        checkbeta = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_BETA.phar")
        checkdev = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_DEV.phar")
        checksoft = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_SOFT.phar")

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("---------------------------<Install PocketMine-MP>------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        For i = 1 To nservers
            Console.WriteLine("{0}) {1} -> Version: {2} -> Status: {3}", i, nameservers(i - 1), versionstatus(i - 1), installationstatus(i - 1))

        Next
        Console.WriteLine()
        Console.Write("Which server you want to download the server? ")
        chooseserver = Console.ReadLine

        If chooseserver = "1" Or chooseserver = "2" Or chooseserver = "3" Or chooseserver = "4" Or chooseserver = "5" Or chooseserver = "6" Or chooseserver = "7" Or chooseserver = "8" Or chooseserver = "9" Or chooseserver = "10" Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("---------------------------<Install PocketMine-MP>------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Version Stable (Setup File)")
            Console.WriteLine("2- Version Beta (Phar File)")
            Console.WriteLine("3- Version Dev-1170 (Phar File)")
            Console.WriteLine("4- Version Soft (Phar File)")
            Console.WriteLine("5- Back")
            Console.WriteLine()
            Console.WriteLine("What kind of version you want to install?")
            version = Console.ReadLine

            If version = "1" Then 'Stable
                Do
                    Console.WriteLine()
                    Console.WriteLine("Current Versions:")
                    Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                    Console.WriteLine()
                    Console.Write("Which version do you want to install?: ")
                    stable = Console.ReadLine

                    If stable = "1" Then 'Stable
                        If chooseserver Then 'Stable
                            If checkpocketmine Then
                                Console.WriteLine()
                                Console.WriteLine("Starting installation...")
                                Process.Start("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")
                                Console.WriteLine("Installation complete")
                                Console.ReadLine()

                            Else
                                Console.WriteLine("Installer not found! Please download the installer!")
                                Console.ReadLine()

                            End If
                        End If

                        ChangeInstallationStatus(nservers, installationstatus, chooseserver)

                    End If
                Loop While stable <> "1"
            End If

            If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                If version = "2" Then 'Beta
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        beta = Console.ReadLine

                        If beta = "1" Then
                            If checkbeta Then

                                VersionBeta.VersionBeta(chooseserver, beta, checkbeta, checkphar1, checkphar2, path) 'BETA
                                ChangeInstallationStatus(nservers, installationstatus, chooseserver)

                            End If
                        End If
                    Loop While beta <> "1"
                End If

                If version = "3" Then 'Dev
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1153]")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        dev = Console.ReadLine

                        If dev = "1" Then
                            If checkdev Then

                                VersionDev.VersionDev(chooseserver, dev, checkdev, checkphar1, checkphar2, path) 'DEV
                                ChangeInstallationStatus(nservers, installationstatus, chooseserver)

                            End If
                        End If
                    Loop While dev <> "1"
                End If

                If version = "4" Then 'Soft
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        soft = Console.ReadLine

                        If soft = "1" Then
                            If checksoft Then

                                VersionSoft.VersionSoft(chooseserver, soft, checksoft, checkphar1, checkphar2, path) 'SOFT
                                ChangeInstallationStatus(nservers, installationstatus, chooseserver)

                            End If
                        End If
                    Loop While soft <> "1"
                End If

            Else
                For i = 1 To nservers
                    Do
                        Console.Write("Write the folder path of the {0} server, example 'C:\PocketMine-MP': ", numberservers(i - 1))
                        path(i - 1) = Console.ReadLine

                        If path(i - 1) = "" Then
                            Console.WriteLine("ERROR! Insert a valid path!")
                            Console.ReadLine()

                        End If
                    Loop While path(i - 1) = ""

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

                Next
            End If
        End If
    End Sub

    Sub ChangeInstallationFiles(ByRef path As String, ByRef priority As String, ByRef checkphar1 As Object, ByRef checkphar2 As Object)

        checkphar1 = My.Computer.FileSystem.FileExists(path + "\PocketMine-MP.phar")
        checkphar2 = My.Computer.FileSystem.FileExists(path + "\PocketMine-MP_OLD.phar")

        If checkphar1 Then
            If checkphar2 Then
                My.Computer.FileSystem.DeleteFile(path + "\PocketMine-MP_OLD.phar")
                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_" + priority + ".phar", path + "\PocketMine-MP_" + priority + ".phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP.phar", "PocketMine-MP_OLD.yml")
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP_" + priority + ".phar", "PocketMine-MP.phar")
            Else
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP.phar", "PocketMine-MP_OLD.yml")
                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_" + priority + ".phar", path + "\PocketMine-MP_" + priority + ".phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP_" + priority + ".phar", "PocketMine-MP.phar")

            End If
        Else
            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_" + priority + ".phar", path + "\PocketMine-MP_" + priority + ".phar", overwrite:=True)
            My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP_" + priority + ".phar", "PocketMine-MP.phar")

        End If

    End Sub

    Sub ChangeInstallationStatus(ByRef nservers As Integer, ByRef installationstatus As String(), ByRef chooseserver As String) 'It is not the best way. I currently use this then I'll change.
        For i = 1 To nservers
            installationstatus(i - 1) = "Installed"

        Next

        If chooseserver = "1" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_1.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_1.pm", installationstatus(0), True)

        ElseIf chooseserver = "2" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_2.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_2.pm", installationstatus(1), True)

        ElseIf chooseserver = "3" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_3.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_3.pm", installationstatus(2), True)

        ElseIf chooseserver = "4" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_4.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_4.pm", installationstatus(3), True)

        ElseIf chooseserver = "5" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_5.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_5.pm", installationstatus(4), True)

        ElseIf chooseserver = "6" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_6.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_6.pm", installationstatus(5), True)

        ElseIf chooseserver = "7" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_7.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_7.pm", installationstatus(6), True)

        ElseIf chooseserver = "8" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_8.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_8.pm", installationstatus(7), True)

        ElseIf chooseserver = "9" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_9.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_9.pm", installationstatus(8), True)

        ElseIf chooseserver = "10" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_10.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_10.pm", installationstatus(9), True)

        End If

        For i = 1 To nservers 'For security.
            installationstatus(i - 1) = "Not Installed"

        Next

    End Sub
End Module
