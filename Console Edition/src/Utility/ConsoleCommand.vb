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
    Sub ConsoleCommand(ByRef nameservers As String(), ByRef nservers As SByte, ByRef path As String(), ByRef checkpath As Object(), ByRef language As SByte, ByRef checklanguage As Object)

        Dim command As String = ""
        Dim args As String()
        Dim commandstart As Boolean

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.WriteLine("====================<PocketMine Manager Servers Commander>======================")
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("Write a command with or not '/', example /help for list of avaiable commands.")
        Console.WriteLine()

        While command <> "menu"
            Console.ForegroundColor = ConsoleColor.White
            Console.Write(">")
            command = Console.ReadLine.Replace("/", "").ToLower
            Console.WriteLine()

            args = command.Split(New Char() {" "})

            Try
                If command = "help" Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("/help : Show help page")
                    Console.WriteLine("/backup <servername|all> : Create a backup of one or all servers")
                    Console.WriteLine("/edit <performance|properties> : Edit your server's performace or properties")
                    Console.WriteLine("/language <languagename|list> : Change language of program.")
                    Console.WriteLine("/menu : Return in the main menu")
                    Console.WriteLine("/restart <servername|all> : Restart one or all servers.")
                    Console.WriteLine("/restore <servername|all> : Restore a backup of one or all servers")
                    Console.WriteLine("/set start <commander|menu> : Set the initial interface when the program starts")
                    Console.WriteLine("/start <servername|all> : Start one or all servers")
                    Console.WriteLine("/stop <servername|all> : Stop one or all servers")
                    Console.WriteLine("/exit : Leave the program.")

                ElseIf command = "" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Command not valid, write /help for a list of avaible commands")

                ElseIf command = "set" Or command = "set start" Or command = "set start commander" Or command = "set start menu" Then
                    SetCommand.SetCommand(args, command)

                ElseIf command = "exit" Then
                    Console.WriteLine("See you soon!")
                    Console.ReadLine()
                    End

                ElseIf command = "language" Or command = "language list" Then
                    LanguageCommand.LanguageCommand(args, command, language, checklanguage)

                ElseIf command = "start" Then
                    StartCommand.StartCommand(command, args, checkpath, path, nservers, nameservers)

                ElseIf command = "stop" Then
                    StopCommand.StopCommand()

                End If

                If args.Length > 1 Then
                    If command = "start " + args(1) Then
                        StartCommand.StartCommand(command, args, checkpath, path, nservers, nameservers)

                    ElseIf command = "stop " + args(1) Then
                        StopCommand.StopCommand() 'TODO: Add command functions

                    ElseIf command = "language " + args(1) Then
                        LanguageCommand.LanguageCommand(args, command, language, checklanguage)
                    End If
                End If

            Catch ex As Exception
                'MsgBox(Convert.ToString(ex))
            End Try
            Console.WriteLine()
        End While

    End Sub
End Module
