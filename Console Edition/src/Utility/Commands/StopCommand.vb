Module StopCommand
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
    Sub StopCommand(ByRef args As String(), ByRef command As String)

        Dim PMProcess() As Process = Process.GetProcessesByName("mintty") 'Process of PocketMine-MP
        If command = "stop" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /stop <servername|all>")

        ElseIf command = "stop " + args(1) Then
            If args(1) = "all" Then
                If PMProcess.Length > 0 Then
                    For Each p As Process In PMProcess 'TODO: Add /save-all and /stop command for security restart
                        p.Kill() 'This is so bad for the moment.
                    Next

                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Servers stopped!")

                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Any servers is turned on.")

                End If
            Else
                Console.ForegroundColor = ConsoleColor.Magenta
                Console.WriteLine("Sorry, but this fuction isn't implemented yet.")

            End If
        End If
    End Sub
End Module
