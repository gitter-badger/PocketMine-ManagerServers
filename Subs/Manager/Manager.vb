﻿Module Manager
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
    Sub Manager(ByRef nservers As Integer, ByRef varmanager As String, ByRef performance As String, ByRef performancestatus As String(), ByRef confirmperfomance As String, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef checkperformance As Object(), ByRef selectperformance As String)

        Reading(path, nservers, nameservers)

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Open [Server/Folder]")
            Console.WriteLine("2- Edit server performance.")
            Console.WriteLine("3- Backup/Restore servers.")
            Console.WriteLine("4- Back")
            Console.WriteLine()
            Console.Write("Select Option: ")
            varmanager = Console.ReadLine

            If varmanager = "1" Then 'Work
                Opener.Opener(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, performancestatus)

            End If

            If varmanager = "2" Then
                Editor.Editor(confirmperfomance, checkpath, checknameserver, performance, nameservers, nservers, selectperformance, performancestatus, path, numberservers)

            End If

            If varmanager = "3" Then
                Rescuer.Rescuer()

            End If

        Loop While varmanager <> "4"
    End Sub

End Module
