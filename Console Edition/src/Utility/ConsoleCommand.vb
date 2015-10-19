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
    Sub ConsoleCommand(ByRef nameservers As String(), ByRef nservers As SByte, ByRef path As String(), ByRef checkpath As Object(), ByRef language As SByte, ByRef checklanguage As Object, _
                       ByRef backupstatus As String(), ByRef checknameserver As Object())

        Dim command As String = ""
        Dim args As String()
        Dim commandstart As Boolean

        Checking(checknameserver, checkpath)
        Reading(path, nservers, nameservers)

Clear:
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.WriteLine("===============================<Commands Mode>==================================")
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("Write a command with or not '/', example /help for list of avaiable commands.")
        Console.WriteLine()

        While command <> "menu"
            Console.ForegroundColor = ConsoleColor.White
            Console.Write(">")
            command = Console.ReadLine.Replace("/", "")
            Console.WriteLine()

            args = command.Split(New Char() {" "})

            Try
                command.ToLower()
                If command.ToLower = "help" Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("/backup <servername|all> : Create a backup of one or all servers")
                    Console.WriteLine("/clear : Clean the console.")
                    Console.WriteLine("/edit <performance|properties> : Edit your server's performace or properties")
                    Console.WriteLine("/exit : Leave the program.")
                    Console.WriteLine("/help : Show help page")
                    Console.WriteLine("/language <languagename|list> : Change language of program.")
                    Console.WriteLine("/menu : Return in the main menu")
                    Console.WriteLine("/restart <servername|all> : Restart one or all servers.")
                    Console.WriteLine("/restore <servername|all> : Restore a backup of one or all servers")
                    Console.WriteLine("/set start <commander|menu> : Set the initial interface when the program starts")
                    Console.WriteLine("/start <servername|all> : Start one or all servers")
                    Console.WriteLine("/stop <servername|all> : Stop one or all servers")

                ElseIf command = "" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Command not valid, write /help for a list of avaible commands")

                ElseIf command.ToLower = "set" Or command.ToLower = "set start" Or command.ToLower = "set start commander" Or command.ToLower = "set start menu" Then
                    SetCommand.SetCommand(args, command)

                ElseIf command.ToLower = "clear" Then
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Console cleaned")
                    System.Threading.Thread.Sleep(350)
                    GoTo Clear

                ElseIf command.ToLower = "exit" Then
                    Console.WriteLine("See you soon!")
                    Console.ReadLine()
                    End

                ElseIf command.ToLower = "language" Or command.ToLower = "language list" Then
                    LanguageCommand.LanguageCommand(args, command, language, checklanguage)

                ElseIf command.ToLower = "start" Then
                    StartCommand.StartCommand(command, args, checkpath, path, nservers, nameservers)

                ElseIf command.ToLower = "stop" Then
                    StopCommand.StopCommand(args, command)

                ElseIf command.ToLower = "backup" Then
                    BackupCommand.BackupCommand(args, command, nservers, path, checkpath, nameservers, backupstatus)

                ElseIf command.ToLower = "restore" Then
                    RestoreCommand.RestoreCommand(args, command, nservers, path, checkpath, nameservers, backupstatus)

                ElseIf command.ToLower = "edit" Or command.ToLower = "edit properties" Or command.ToLower = "edit performance" Then
                    If command.ToLower = "edit" Or command.ToLower = "edit properties" Then
                        EditorCommand.PropertiesCommand(args, command, nservers, path, checkpath, nameservers)
                    Else
                        EditorCommand.PerformanceCommand(args, command, nservers, path, checkpath, nameservers)
                    End If

                ElseIf command.ToLower = "restart" Then
                    RestartCommand.RestartCommand(args, command, path, nservers, checkpath)
                End If

                If args.Length > 1 Then
                    If command = "start " + args(1) Then
                        StartCommand.StartCommand(command, args, checkpath, path, nservers, nameservers)

                    ElseIf command = "stop " + args(1) Then
                        StopCommand.StopCommand(args, command) 'TODO: To complete

                    ElseIf command = "language " + args(1) And args(1) <> "list" Then
                        LanguageCommand.LanguageCommand(args, command, language, checklanguage)

                    ElseIf command = "backup " + args(1) Then
                        BackupCommand.BackupCommand(args, command, nservers, path, checkpath, nameservers, backupstatus)

                    ElseIf command = "restore " + args(1) Then
                        RestoreCommand.RestoreCommand(args, command, nservers, path, checkpath, nameservers, backupstatus)

                    ElseIf command = "restart " + args(1) Then
                        RestartCommand.RestartCommand(args, command, path, nservers, checkpath) 'TODO: To complete

                    End If
                End If

            Catch ex As Exception
                'MsgBox(Convert.ToString(ex))
            End Try
            Console.WriteLine()
        End While

    End Sub
End Module
