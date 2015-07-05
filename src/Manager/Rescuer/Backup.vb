Imports Ionic.Zip

Module Backup
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
    Sub Backup(ByRef nservers As Integer, ByRef nameservers As String(), ByRef back As String, ByRef backupstatus As String(), ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef backuptitle As String, _
               ByRef backup1 As String, ByRef backup2 As String, ByRef backup3 As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String)

        Dim choosebackup As String

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("{0}", backuptitle)
            Console.ForegroundColor = ConsoleColor.White

            For i = 1 To nservers
                Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), backupstatus(i - 1))

            Next
            Console.WriteLine("11) {0}", back)

            Console.WriteLine()
            Console.Write("{0}", backup1)
            choosebackup = Console.ReadLine

            If choosebackup = "11" Then
                Exit Sub
            End If

        Loop While choosebackup = "0"

        Console.WriteLine()

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then

            Dim i As Integer
            'TODO: Move zip file into folder "Backup/Servers"
            If choosebackup = "1" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(0))
                    Zip.Save(nameservers(0) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(0) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_1.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_1.pm", backupstatus(0), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "2" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(1))
                    Zip.Save(nameservers(1) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(1) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_2.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_2.pm", backupstatus(1), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "3" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(2))
                    Zip.Save(nameservers(2) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(2) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_3.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_3.pm", backupstatus(2), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "4" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(3))
                    Zip.Save(nameservers(3) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(3) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_4.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_4.pm", backupstatus(3), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "5" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(4))
                    Zip.Save(nameservers(4) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(4) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_5.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_5.pm", backupstatus(4), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "6" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(5))
                    Zip.Save(nameservers(5) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(5) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_6.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_6.pm", backupstatus(5), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "7" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(6))
                    Zip.Save(nameservers(6) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(6) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_7.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_7.pm", backupstatus(6), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "8" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(7))
                    Zip.Save(nameservers(7) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(7) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_8.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_8.pm", backupstatus(7), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "9" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(8))
                    Zip.Save(nameservers(8) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(8) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_9.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_9.pm", backupstatus(8), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            ElseIf choosebackup = "10" Then
                Console.WriteLine("{0}", backup2)
                Using Zip As ZipFile = New ZipFile()
                    Zip.AddDirectory(path(9))
                    Zip.Save(nameservers(9) + ".zip")
                    Console.ForegroundColor = ConsoleColor.Green

                    backupstatus(9) = "Backuped"
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_10.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_10.pm", backupstatus(9), True)

                    Console.WriteLine("{0}", backup3)
                End Using
                Console.ReadLine()

            End If
        Else
            For i = 1 To nservers
                Do
                    Console.Write("{0} {1} {2} ", writepath1, numberservers(i - 1), writepath2)
                    path(i - 1) = Console.ReadLine

                    If path(i - 1) = "" Then
                        Console.WriteLine("{0}", writepath3)
                        Console.ReadLine()

                    End If
                Loop While path(i - 1) = ""

                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next
        End If

    End Sub
End Module
