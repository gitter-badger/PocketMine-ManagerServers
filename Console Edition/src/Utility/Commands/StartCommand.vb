Module StartCommand
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
    Sub StartCommand(ByRef command As String, ByRef args As String(), ByRef checkpath As Object(), ByRef path As String(), ByRef nservers As SByte, ByRef nameservers As String())

        If command = "start" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /start <servername|all>")

        ElseIf command = "start " + args(1) Then
            If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                Try
                    If args(1) = "all" Then
                        For i = 1 To nservers
                            Process.Start(path(i - 1) + "\start.cmd")

                        Next

                    ElseIf args(1) = nameservers(0) Then
                        Process.Start(path(0) + "\start.cmd")

                    ElseIf args(1) = nameservers(1) Then
                        Process.Start(path(1) + "\start.cmd")

                    ElseIf args(1) = nameservers(2) Then
                        Process.Start(path(2) + "\start.cmd")

                    ElseIf args(1) = nameservers(3) Then
                        Process.Start(path(3) + "\start.cmd")

                    ElseIf args(1) = nameservers(4) Then
                        Process.Start(path(4) + "\start.cmd")

                    ElseIf args(1) = nameservers(5) Then
                        Process.Start(path(5) + "\start.cmd")

                    ElseIf args(1) = nameservers(6) Then
                        Process.Start(path(6) + "\start.cmd")

                    ElseIf args(1) = nameservers(7) Then
                        Process.Start(path(7) + "\start.cmd")

                    ElseIf args(1) = nameservers(8) Then
                        Process.Start(path(8) + "\start.cmd")

                    ElseIf args(1) = nameservers(9) Then
                        Process.Start(path(9) + "\start.cmd")

                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Any server with this name exist!")

                    End If
                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Can't find the start.cmd")
                    Console.ForegroundColor = ConsoleColor.White
                End Try
            End If
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("You must define the path of your servers!")

        End If
    End Sub
End Module
