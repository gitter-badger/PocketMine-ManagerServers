Module Opener
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
    Sub Opener(ByRef nservers As Integer, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef performancestatus As String())

        Reading(path, nservers, nameservers)

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.DarkMagenta
            Console.WriteLine("-----------------------------------<Opener>-------------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            For i = 1 To nservers
                Console.WriteLine("{0} server: {1}", numberservers_2(i - 1), nameservers(i - 1))
            Next
            Console.WriteLine()
            Console.Write("What do you want to do? <Open [Server/Folder]>: ")
            pathopener = Console.ReadLine.ToUpper

            If pathopener <> "SERVER" And pathopener <> "FOLDER" Then
                Console.WriteLine("Please, select a correct option")
                Console.ReadLine()

            End If

        Loop While pathopener <> "SERVER" And pathopener <> "FOLDER"

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" And pathopener = "SERVER" Or pathopener = "FOLDER" Then
            Console.WriteLine()
            Console.WriteLine("Reading your file(s)...")
            Console.WriteLine("File(s) succefully read!")

            Console.WriteLine()
            Console.WriteLine("Opening your server(s)...")

            If pathopener = "SERVER" Then

                For i = 1 To nservers
                    If nservers > 1 Then
                        Console.WriteLine("Loading {0} server!", numberservers(i - 1))
                        Process.Start(path(i - 1) + "\start.cmd")

                        Console.WriteLine("Wait 3 seconds to load each server!")
                        For index = 1 To 10000 ^ 2.1 'Small Timer xD
                            index = index + 0.1
                        Next
                    Else
                        Console.WriteLine("Loading {0} server!", numberservers(i - 1))
                        Process.Start(path(i - 1) + "\start.cmd")
                    End If
                Next

            End If

            If pathopener = "FOLDER" Then
                For i = 1 To nservers
                    Process.Start(path(i - 1))

                Next
            End If

        Else
            For i = 1 To nservers
                Do
                    Console.Write("Write the folder path of the {0} server, example 'C:\PocketMine-MP': ", numberservers(i - 1))
                    path(i - 1) = Console.ReadLine

                    If path(i - 1) = "" Then
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        Console.WriteLine("ERROR! Insert a valid path!")
                        Console.ReadLine()

                    End If
                Loop While path(i - 1) = ""

                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next
        End If
    End Sub
End Module
