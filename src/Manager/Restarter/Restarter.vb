﻿Module Restarter
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
    Sub Restarter(ByRef nservers As Integer, ByRef nameservers As String(), ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String)

        Dim chooserestart, choosetime, chooserestart2 As String
        Dim checktime, checkchoosetime, checkchooseserver As Object

        checktime = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\Time.pm")
        checkchoosetime = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\ChooseTime.pm")
        checkchooseserver = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\ChooseServer.pm")

        Do
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("=============================<Server Restarter>=================================")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Define restarter timer")
            Console.WriteLine("2- Restart your server")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Choose one option: ")
            chooserestart = Console.ReadLine

            If chooserestart = "1" Then
                Dim chooseserver As Integer

                Console.WriteLine()
                For i = 1 To nservers
                    Console.WriteLine("{0}- {1}", i, nameservers(i - 1))

                Next

                Console.WriteLine()
                Console.Write("Choose the server that do you want to apply the restarter: ")
                chooseserver = Console.ReadLine

                If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then

                    If checkchooseserver Then
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\ChooseServer.pm")

                    End If

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\ChooseServer.pm", chooseserver, True)

                    Console.WriteLine()
                    Console.WriteLine("1- Day")
                    Console.WriteLine("2- Hour")
                    Console.WriteLine("3- Minute")
                    Console.Write("Choose the time that do you want to restart your server: ")
                    choosetime = Console.ReadLine

                    If choosetime = "1" Or choosetime = "2" Or choosetime = "3" Then

                        If checkchoosetime Then
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\ChooseTime.pm")

                        End If

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\ChooseTime.pm", choosetime, True)

                        Dim time As Integer

                        Console.Write("How many ")
                        If choosetime = "1" Then
                            Console.Write("days? ")

                        ElseIf choosetime = "2" Then
                            Console.Write("hours? ")

                        ElseIf choosetime = "3" Then
                            Console.Write("minutes? ")

                        End If
                        time = Console.ReadLine

                        If checktime Then
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\Time.pm")

                        End If

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\Time.pm", time, True)

                        Process.Start("C:\Program Files\PocketMine-ManagerServers\PM-MS(BackgroudTask).exe")

                    End If

                    Else

                    Do
                        Console.Write("{0} {1} {2}", writepath1, nameservers(chooseserver - 1), writepath2)
                        path(chooseserver - 1) = Console.ReadLine

                        If path(chooseserver - 1) = "" Then
                            Console.WriteLine("{0}", writepath3)
                            Console.ReadLine()

                        End If
                    Loop While path(chooseserver - 1) = ""

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(chooseserver) + ".pm", path(chooseserver - 1), True)

                    End If
            End If

            If chooserestart = "2" Then
                Dim chooseserver As Integer
                Dim PMProcess() As Process = Process.GetProcessesByName("mintty") 'Process of PocketMine-MP

                Console.WriteLine()
                For i = 1 To nservers
                    Console.WriteLine("{0}- {1}", i, nameservers(i - 1))

                Next
                Console.Write("Choose the server that you want to restart: ")
                chooseserver = Console.ReadLine

                Console.WriteLine("Restarting {0}...", nameservers(chooseserver - 1))
                For Each p As Process In PMProcess 'TODO: Add /save-all and /stop command for security restart
                    p.Kill() 'This is so bad for the moment.
                Next

                Console.WriteLine()
                Console.WriteLine("Wait 3 seconds...")
                System.Threading.Thread.Sleep(3000)
                Process.Start(path(chooseserver - 1) + "\start.cmd")

                Console.WriteLine()
                Console.WriteLine("Server Restarted!")
                Console.ReadLine()

            End If
        Loop While chooserestart <> "3"
    End Sub

End Module
