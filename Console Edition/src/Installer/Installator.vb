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



    Sub Installator(ByRef checkpath As Object(), ByRef nservers As SByte, ByRef nameservers As String(), ByRef installationstatus As String(), ByRef versionstatus As String(), ByRef path As String(), ByRef numberservers As String(), _
                    ByRef back As String, ByRef menu1 As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, _
                    ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef installatortitle As String, ByRef installator1 As String, ByRef installator2 As String, _
                    ByRef installator3 As String, ByRef installator4 As String, ByRef installator5 As String, ByRef installator6 As String, ByRef installator7 As String, ByRef versions1 As String, ByRef versions2 As String, ByRef versions3 As String)

        Dim checkpocketmine, checkbeta, checkdev, checksoft As Object

        Dim checkphar1, checkphar2 As Object

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")

        checkbeta = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_BETA.phar")
        checkdev = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_DEV.phar")
        checksoft = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_SOFT.phar")

        Dim stable, beta, dev, soft, confirmphar As String
        Dim chooseserver As Object

        Do
            Do
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("{0}", installatortitle)
                Console.ForegroundColor = ConsoleColor.White
                For i = 1 To nservers
                    Console.WriteLine("{0}) {1} -> {2}: {3} -> {4}: {5}", i, nameservers(i - 1), version1, versionstatus(i - 1), status1, installationstatus(i - 1))

                Next
                Console.WriteLine("11) {0}", back)
                Console.WriteLine()
                Console.Write("{0} ", installator2)
                chooseserver = Console.ReadLine

                If chooseserver = "11" Then
                    Exit Sub
                End If
            Loop While chooseserver < "1" Or chooseserver > "10"

            If chooseserver >= "1" Or chooseserver <= "10" Then

                Dim version As String

                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("{0}", installatortitle)
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("1- {0} (Setup File)", versionstable1)
                Console.WriteLine("2- {0} (Phar File)", versionbeta1)
                Console.WriteLine("3- {0} (Phar File)", versiondev1)
                Console.WriteLine("4- {0} (Phar File)", versionsoft1)
                Console.WriteLine("5- {0}", back)
                Console.WriteLine()
                Console.Write("{0}", installator1)
                version = Console.ReadLine

                If version = "5" Then
                    Exit Do
                End If

                If version = "1" Then 'Stable
                    Do
                        Console.WriteLine()
                        Console.WriteLine("{0}", currentversion)
                        Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                        Console.WriteLine()
                        Console.Write("{0}", installator2)
                        stable = Console.ReadLine

                        If stable = "1" Then 'Stable
                            If chooseserver Then 'Stable
                                If checkpocketmine Then
                                    Console.WriteLine()
                                    Console.WriteLine("{0}", installator3)
                                    Process.Start("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")
                                    Console.WriteLine("{0}", installator4)
                                    Console.ReadLine()

                                Else
                                    Console.WriteLine("{0}", installator5)
                                    Console.ReadLine()

                                End If
                            End If

                            ChangeInstallationStatus(installationstatus, chooseserver, installator6, installator7)

                        End If
                    Loop While stable <> "1"
                End If

                If checkpath(chooseserver - 1) And path(chooseserver - 1) <> "" Then
                    If version = "2" Then 'Beta
                        Do
                            Console.WriteLine()
                            Console.WriteLine("{0}", currentversion)
                            Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                            Console.WriteLine()
                            Console.Write("{0}", installator2)
                            beta = Console.ReadLine

                            If beta = "1" Then
                                If checkbeta Then
                                    Do
                                        Console.WriteLine("{0} ", versions1)
                                        confirmphar = Console.ReadLine.ToUpper

                                        If confirmphar = "Y" Then
                                            ChangeInstallationFiles(path(chooseserver - 1), "BETA", checkphar1, checkphar2)

                                        End If
                                    Loop While confirmphar <> "Y" Or confirmphar <> "N"
                                Else
                                    Console.WriteLine("{0}", versions2)
                                    Console.WriteLine("{0}", versions3)
                                    Console.ReadLine()

                                End If
                            End If
                            ChangeInstallationStatus(installationstatus, chooseserver, installator6, installator7)
                        Loop While beta <> "1"
                    End If

                    If version = "3" Then 'Dev
                        Do
                            Console.WriteLine()
                            Console.WriteLine("{0}", currentversion)
                            Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1258]")
                            Console.WriteLine()
                            Console.Write("{0}", installator2)
                            dev = Console.ReadLine

                            If dev = "1" Then
                                If checkdev Then
                                    Do
                                        Console.WriteLine("{0} <Y/N>: ", versions1)
                                        confirmphar = Console.ReadLine.ToUpper

                                        If confirmphar = "Y" Then
                                            ChangeInstallationFiles(path(chooseserver - 1), "DEV", checkphar1, checkphar2)

                                        End If
                                    Loop While confirmphar <> "Y" Or confirmphar <> "N"

                                Else
                                    Console.WriteLine("{0}", versions2)
                                    Console.WriteLine("{0}", versions3)
                                    Console.ReadLine()

                                End If
                            End If
                        Loop While dev <> "1"
                    End If

                    If version = "4" Then 'Soft
                        Do
                            Console.WriteLine()
                            Console.WriteLine("{0}", currentversion)
                            Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu")
                            Console.WriteLine()
                            Console.Write("{0}", installator2)
                            soft = Console.ReadLine

                            If soft = "1" Then
                                If checksoft Then
                                    Console.WriteLine("{0} ", versions1)
                                    confirmphar = Console.ReadLine.ToUpper

                                    If confirmphar = "Y" Then
                                        ChangeInstallationFiles(path(chooseserver - 1), "SOFT", checkphar1, checkphar2)

                                    End If

                                Else
                                    Console.WriteLine("{0}", versions2)
                                    Console.WriteLine("{0}", versions3)
                                    Console.ReadLine()

                                End If
                            End If
                        Loop While soft <> "1"
                    End If


                Else
                    Do
                        Console.Write("{0} {1} {2} ", writepath1, nameservers(chooseserver - 1), writepath2)
                        path(chooseserver - 1) = Console.ReadLine

                        If path(chooseserver - 1) = "" Then
                            Console.WriteLine("{0}", writepath3)
                            Console.ReadLine()

                        End If
                    Loop While path(chooseserver - 1) = ""

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(chooseserver) + ".pm", path(chooseserver - 1), True)
                End If
            End If
        Loop While chooseserver <> 11
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

    Sub ChangeInstallationStatus(ByRef installationstatus As String(), ByRef chooseserver As String, ByRef installator6 As String, ByRef installator7 As String)
        installationstatus(chooseserver - 1) = installator6

        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_1" + Convert.ToString(chooseserver) + ".pm")
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(chooseserver) + ".pm", installationstatus(chooseserver - 1), True)

        installationstatus(chooseserver - 1) = installator7 'For security.

    End Sub
End Module
