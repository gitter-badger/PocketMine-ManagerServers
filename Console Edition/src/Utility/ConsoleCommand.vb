Module ConsoleCommand
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
    Sub ConsoleCommand(ByRef nameservers As String(), ByRef nservers As Integer, ByRef path As String(), ByRef checkpath As Object())

        Dim command As String = ""
        Dim args As String()
        Dim i As Integer

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.WriteLine("====================<PocketMine Manager Servers Commander>======================")

        While command <> "exit"
            Console.ForegroundColor = ConsoleColor.White
            Console.Write(">/")
            command = Console.ReadLine.Replace("/", "").ToLower
            Console.WriteLine()

            args = command.Split(New Char() {" "c})

            Try
                If command = "help" Or command = "" Then
                    If args(0) = "help" Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                        Console.WriteLine(">/help : Show help page")
                        Console.WriteLine(">/start <servername|all> : Start one or all servers")
                        Console.WriteLine(">/stop <servername|all> : Stop one or all servers")
                        Console.WriteLine(">/exit : Return in the main menu")

                    ElseIf args(0) = "" Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Command not valid, write /help for a list of avaible commands")

                    End If

                ElseIf args.Length >= 1 Then
                    If (args(0) = "start") Then
                        StartCommand.StartCommand(command, args, checkpath, path, nservers, nameservers)

                    ElseIf (args(0) = "start " + args(1)) Then
                        StartCommand.StartCommand(command, args, checkpath, path, nservers, nameservers)

                    End If

                    If (args(0) = "stop") Then
                        StopCommand.StopCommand()

                    ElseIf (args(0) = "start " + args(1)) Then
                        StopCommand.StopCommand()

                    End If
                End If
            Catch ex As Exception

            End Try
            Console.WriteLine()
        End While

    End Sub
End Module
