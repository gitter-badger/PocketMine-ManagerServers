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
               ByRef backup1 As String, ByRef backup2 As String, ByRef backup3 As String, ByRef backup4 As String, ByRef backup5 As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String)

        Dim choosebackup As Integer
        Dim openbackup, overwrite As String

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

            If choosebackup = 11 Then
                Exit Sub
            End If

        Loop While choosebackup = 0 Or choosebackup > 11

        Console.WriteLine()

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then

            If choosebackup > 0 Or choosebackup <= 10 Then
                If backupstatus(choosebackup - 1) = "Backuped" Then
                    Do
                        Console.Write("{0} <Y/N>: ", backup4)
                        overwrite = Console.ReadLine.ToUpper

                        If overwrite = "Y" Then
                            GoTo Overwrite

                        End If

                    Loop While overwrite <> "Y" And overwrite <> "N"
                Else
Overwrite:
                    Console.WriteLine("{0}", backup2)
                    Using Zip As ZipFile = New ZipFile()
                        Zip.AddDirectory(path(choosebackup - 1))
                        Zip.Save("C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(choosebackup - 1) + ".zip")
                        Console.ForegroundColor = ConsoleColor.Green

                        backupstatus(choosebackup - 1) = "Backuped"
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(choosebackup) + ".pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(choosebackup) + ".pm", backupstatus(choosebackup - 1), True)

                        Console.WriteLine("{0}", backup3)

                    End Using
                    Console.ReadLine()

                    Do
                        Console.ForegroundColor = ConsoleColor.White
                        Console.Write("{0} <Y/N>: ", backup5)
                        openbackup = Console.ReadLine.ToUpper

                        If openbackup = "Y" Then
                            Process.Start("C:\Program Files\PocketMine-ManagerServers\Backups")

                        End If

                    Loop While openbackup <> "Y" And openbackup <> "N"
                End If
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
