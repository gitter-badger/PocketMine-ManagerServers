Imports Ionic.Zip

Module BackupCommand
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
    Sub BackupCommand(ByRef args As String(), ByRef command As String, ByRef nservers As SByte, ByRef path As String(), ByRef checkpath As Object(), ByRef nameservers As String(), ByRef backupstatus As String())

        If command = "backup" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /backup <servername|all>")

        ElseIf command = "backup " + args(1) Then
            If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then

                If args(1) = nameservers(0) Or args(1) = nameservers(1) Or args(1) = nameservers(2) Or args(1) = nameservers(3) _
                    Or args(1) = nameservers(4) Or args(1) = nameservers(5) Or args(1) = nameservers(6) Or args(1) = nameservers(7) _
                    Or args(1) = nameservers(8) Or args(1) = nameservers(9) Or args(1) = "all" Then

                    Console.WriteLine("I'm doing the backup...")
                End If

                If args(1) = "all" Then
                    For i = 1 To nservers
                        Using Zip As ZipFile = New ZipFile()
                            Zip.AddDirectory(path(i - 1))
                            Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(i) + ".zip")

                            backupstatus(i - 1) = "Backuped"
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm")
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm", backupstatus(i - 1), True)
                        End Using
                    Next
                ElseIf args(1) = nameservers(0) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(0))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(0) + ".zip")
                        Console.ForegroundColor = ConsoleColor.Green

                        backupstatus(0) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_1.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_1.pm", backupstatus(0), True)
                    End Using

                ElseIf args(1) = nameservers(1) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(1))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(1) + ".zip")
                        Console.ForegroundColor = ConsoleColor.Green

                        backupstatus(1) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_2.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_2.pm", backupstatus(1), True)
                    End Using

                ElseIf args(1) = nameservers(2) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(2))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(2) + ".zip")
                        Console.ForegroundColor = ConsoleColor.Green

                        backupstatus(2) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_3.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_3.pm", backupstatus(2), True)
                    End Using

                ElseIf args(1) = nameservers(3) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(3))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(3) + ".zip")
                        Console.ForegroundColor = ConsoleColor.Green

                        backupstatus(3) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_4.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_4.pm", backupstatus(3), True)
                    End Using

                ElseIf args(1) = nameservers(4) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(4))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(4) + ".zip")

                        backupstatus(4) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_5.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_5.pm", backupstatus(4), True)
                    End Using

                ElseIf args(1) = nameservers(5) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(5))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(5) + ".zip")

                        backupstatus(5) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_6.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_6.pm", backupstatus(5), True)
                    End Using

                ElseIf args(1) = nameservers(6) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(6))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(6) + ".zip")

                        backupstatus(6) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_7.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_7.pm", backupstatus(6), True)
                    End Using

                ElseIf args(1) = nameservers(7) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(7))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(7) + ".zip")

                        backupstatus(7) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_8.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_8.pm", backupstatus(7), True)
                    End Using

                ElseIf args(1) = nameservers(8) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(8))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(8) + ".zip")

                        backupstatus(8) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_9.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_9.pm", backupstatus(8), True)
                    End Using

                ElseIf args(1) = nameservers(9) Then
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(9))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(9) + ".zip")

                        backupstatus(9) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_10.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_10.pm", backupstatus(9), True)
                    End Using
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Any server with this name exist!")

                End If

                Console.ForegroundColor = ConsoleColor.Blue
                If args(1) = "all" Then

                    Console.Write("Succefully backuped: ")
                    For i = 1 To nservers
                        Console.Write("{0}, ", nameservers(i - 1))
                    Next

                ElseIf args(1) = nameservers(0) Or args(1) = nameservers(1) Or args(1) = nameservers(2) Or args(1) = nameservers(3) _
                    Or args(1) = nameservers(4) Or args(1) = nameservers(5) Or args(1) = nameservers(6) Or args(1) = nameservers(7) _
                    Or args(1) = nameservers(8) Or args(1) = nameservers(9) Then

                    Console.WriteLine("Succefully backuped " + args(1))

                End If
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("You must define the path of your servers!")
            End If
        End If
    End Sub
End Module
