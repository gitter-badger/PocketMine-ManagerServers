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
    Sub Rescuer(ByRef nservers As Integer, ByRef nameservers As String(), ByRef backupstatus As String(), ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String)

        Dim rescuer As String

        For i = 1 To nservers
            backupstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm")

        Next

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("--------------------------<Backup/Restore Servers>------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Backup servers")
            Console.WriteLine("2- Restore servers")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Select option: ")
            rescuer = Console.ReadLine

            If rescuer = "1" Then
                Backup.Backup(nservers, nameservers, backupstatus, checkpath, path, numberservers, writepath1, writepath2, writepath3)

            End If

            If rescuer = "2" Then
                Restore.Restore(nservers, nameservers, backupstatus, checkpath, path)

            End If
        Loop While rescuer <> "3"
    End Sub
End Module
