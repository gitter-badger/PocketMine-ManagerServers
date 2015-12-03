Module Rescuer
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
    Sub Rescuer(ByRef nservers As SByte, ByRef nameservers As String(), ByRef backupstatus As String(), ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef back As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, _
                ByRef manager4 As String, ByRef rescuertitle As String, ByRef rescuer1 As String, ByRef rescuer2 As String, ByRef backuptitle As String, ByRef backup1 As String, ByRef backup2 As String, ByRef backup3 As String, ByRef backup4 As String, ByRef backup5 As String, ByRef restoretitle As String, ByRef restore1 As String, ByRef restore2 As String, _
                ByRef restore3 As String, ByRef restore4 As String, ByRef restore5 As String)

        Dim rescuer As String

        For i = 1 To nservers
            backupstatus(i - 1) = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory + "\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm")

        Next

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("{0}", rescuertitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", rescuer1)
            Console.WriteLine("2- {0}", rescuer2)
            Console.WriteLine("3- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", manager4)
            rescuer = Console.ReadLine

            If rescuer = "1" Then
                Backup.Backup(nservers, nameservers, back, backupstatus, checkpath, path, numberservers, backuptitle, backup1, backup2, backup3, backup4, backup5, writepath1, writepath2, writepath3)

            End If

            If rescuer = "2" Then
                Restore.Restore(nservers, nameservers, backupstatus, checkpath, path, back, restoretitle, restore1, restore2, restore3, restore4, restore5)

            End If
        Loop While rescuer <> "3"
    End Sub
End Module
