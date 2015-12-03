Module RestartCommand
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
    Sub RestartCommand(ByRef args As String(), ByRef command As String, ByRef path As String(), ByRef nservers As SByte, ByRef checkpath As Object())

        If command = "restart" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct usage is /restart <servername|all>")

        ElseIf command = "restart " + args(1) Then
            If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                If args(1) = "all" Then

                    Dim PMProcess() As Process = Process.GetProcessesByName("mintty") 'Process of PocketMine-MP

                    For Each p As Process In PMProcess 'TODO: Add /save-all and /stop command for security restart
                        p.Kill() 'This is so bad for the moment.
                    Next

                    For i = 1 To nservers
                        Try
                            Process.Start(path(i - 1) + "\start.cmd")
                        Catch ex As Exception
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Can't find the start.cmd")
                            Console.ForegroundColor = ConsoleColor.White
                        End Try
                    Next
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("All servers are restarted!")

                ElseIf args(1) = "pocketmine" Or args(1) = "pm" Then
                    Try
                        Process.Start(System.IO.Directory.GetCurrentDirectory + "\PocketMine-ManagerServers.exe")
                        End
                    Catch ex As Exception
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Error! Bad Installation!")
                        Console.ReadLine()
                    End Try
                Else
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine("Sorry but this fuction isn't implemented yet.")
                End If
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("You must define the path of your servers!")
            End If
        End If
    End Sub
End Module
