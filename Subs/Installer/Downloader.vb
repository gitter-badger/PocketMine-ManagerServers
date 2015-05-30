Module Downloader
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
    Sub Downloader(ByRef nameservers As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef downloadstatus As String(), ByRef versionstatus As String(), ByRef checknameserver As Object())

        Dim chooseserver, version, stable, beta, dev, soft, linkstable, linkbeta, linkdev, linksoft, downloadpath As String

        Dim checkpocketmine, checkdownloadpath, checkbeta, checkdev, checksoft As Object

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")
        checkdownloadpath = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\PathDownload.pm")

        checkbeta = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_BETA.phar")
        checkdev = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_DEV.phar")
        checksoft = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_SOFT.phar")

        linkstable = "http://sourceforge.net/projects/pocketmine/files/windows/PocketMine-MP_Installer_1.4.1_x86.exe/download"
        linkbeta = "https://github.com/PocketMine/PocketMine-MP/releases/download/1.4.1dev-936/PocketMine-MP_1.4.1dev-936.phar"
        linkdev = "http://jenkins.pocketmine.net/job/PocketMine-MP/lastSuccessfulBuild/artifact/PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar"
        linksoft = "http://jenkins.pocketmine.net/job/PocketMine-Soft/lastSuccessfulBuild/artifact/PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar"

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("---------------------------<Download PocketMine-MP>-----------------------------")
            Console.ForegroundColor = ConsoleColor.White
            For i = 1 To nservers
                Console.WriteLine("{0}) {1} -> Version: {2} -> Status: {3}", i, nameservers(i - 1), versionstatus(i - 1), downloadstatus(i - 1))

            Next
            Console.WriteLine("11) Back")
            Console.WriteLine()
            Console.Write("Which server you want to download the server? ")
            chooseserver = Console.ReadLine

            If chooseserver = "1" Or chooseserver = "2" Or chooseserver = "3" Or chooseserver = "4" Or chooseserver = "5" Or chooseserver = "6" Or chooseserver = "7" Or chooseserver = "8" Or chooseserver = "9" Or chooseserver = "10" Then
                Console.WriteLine()
                Console.WriteLine("1- Version Stable (Setup File)")
                Console.WriteLine("2- Version Beta (Phar File)")
                Console.WriteLine("3- Version Dev-1170 (Phar File)")
                Console.WriteLine("4- Version Soft (Phar File)")
                Console.WriteLine("5- Back")
                Console.WriteLine()
                Console.Write("What kind of version you want to install?")
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
                            If checkpocketmine Then
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this installer!")
                                Console.ReadLine()

                                Exit Sub

                            Else
                                Console.WriteLine("Downloading Installer...!")
                                Process.Start(linkstable)
                                Console.WriteLine("Installer downloaded! Press ENTER to continue.")
                                Console.ReadLine()

                            End If
                        End If
                    Loop While stable <> "1"
                End If

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
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this file!")
                                Console.ReadLine()

                                Exit Sub

                            Else
                                Console.WriteLine("Downloading Phar File...!")
                                Process.Start(linkbeta)
                                Console.WriteLine("Phar file downloaded! Press ENTER to continue.")
                                Console.ReadLine()

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
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this file!")
                                Console.ReadLine()

                                Exit Sub

                            Else
                                Console.WriteLine("Downloading Phar File...!")
                                Process.Start(linkdev)
                                Console.WriteLine("Phar file downloaded! Press ENTER to continue.")
                                Console.ReadLine()

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
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this file!")
                                Console.ReadLine()

                                Exit Sub

                            Else
                                Console.WriteLine("Downloading Phar File...!")
                                Process.Start(linksoft)
                                Console.WriteLine("Phar file downloaded! Press ENTER to continue.")
                                Console.ReadLine()

                            End If
                        End If
                    Loop While soft <> "1"
                End If

                If checkdownloadpath Then
                    If checkbeta = False Or checkdev = False Or checksoft = False Then
                        downloadpath = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\PathDownload.pm")

                        MoveDownloadedFile(checkpocketmine, downloadpath, checkbeta, checkdev, checksoft, version)

                        ManagerInstaller.ChangeVersionStatus(version, chooseserver, versionstatus)

                        ChangeDownloadStatus(nservers, downloadstatus, chooseserver)
                    End If
                Else
                    Do
                        Console.Write("Please indicate what the link to the folder where you downloaded the installer , example 'C:\PocketMine-MP': ")
                        downloadpath = Console.ReadLine

                    Loop While downloadpath = ""

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\PathDownload.pm", downloadpath, True)

                End If
            End If
        Loop While chooseserver <> "11"
    End Sub

    Sub MoveDownloadedFile(ByRef checkpocketmine As Object, ByRef downloadpath As String, ByRef checkbeta As Object, ByRef checkdev As Object, ByRef checksoft As Object, ByRef version As String)
        If version = "2" And checkbeta = False Then
            My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-MP_1.4.1dev-936.phar", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.4.1dev-936.phar", overwrite:=True)
            My.Computer.FileSystem.RenameFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.4.1dev-936.phar", "PocketMine-MP_BETA.phar")

        ElseIf version = "3" And checkdev = False Then
            My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar", overwrite:=True)
            My.Computer.FileSystem.RenameFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar", "PocketMine-MP_DEV.phar")

        ElseIf version = "4" And checksoft = False Then
            My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar", overwrite:=True)
            My.Computer.FileSystem.RenameFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar", "PocketMine-MP_SOFT.phar")

        ElseIf version = "1" And checkpocketmine = False Then
            My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-MP_Installer_1.4.1_x86.exe", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe", overwrite:=True)

        End If
    End Sub

    Sub ChangeDownloadStatus(ByRef nservers As Integer, ByRef downloadstatus As String(), ByRef chooseserver As String) 'It is not the best way. I currently use this then I'll change.
        For i = 1 To nservers
            downloadstatus(i - 1) = "Downloaded"

        Next

        If chooseserver = "1" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_1.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_1.pm", downloadstatus(0), True)

        ElseIf chooseserver = "2" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_2.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_2.pm", downloadstatus(1), True)

        ElseIf chooseserver = "3" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_3.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_3.pm", downloadstatus(2), True)

        ElseIf chooseserver = "4" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_4.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_4.pm", downloadstatus(3), True)

        ElseIf chooseserver = "5" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_5.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_5.pm", downloadstatus(4), True)

        ElseIf chooseserver = "6" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_6.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_6.pm", downloadstatus(5), True)

        ElseIf chooseserver = "7" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_7.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_7.pm", downloadstatus(6), True)

        ElseIf chooseserver = "8" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_8.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_8.pm", downloadstatus(7), True)

        ElseIf chooseserver = "9" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_9.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_9.pm", downloadstatus(8), True)

        ElseIf chooseserver = "10" Then
            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_10.pm")
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_10.pm", downloadstatus(9), True)

        End If

        For i = 1 To nservers 'For security.
            downloadstatus(i - 1) = "Not Downloaded"

        Next

    End Sub
End Module
