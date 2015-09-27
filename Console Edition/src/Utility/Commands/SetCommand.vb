Module SetCommand
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
    Sub SetCommand(ByRef args As String(), ByRef command As String)

        Dim commandstart As Boolean
        Dim checkcommand As Object = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm")

        If command = "set start" Or command = "set" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /set start <commander|menu>")

        End If

        Console.ForegroundColor = ConsoleColor.Blue
        If command = "set start commander" Then
            commandstart = True

            If checkcommand Then
                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm")

            End If

            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm", commandstart, True)
            Console.WriteLine("Set program start on commander!")

        ElseIf command = "set start menu" Then
            commandstart = False

            If checkcommand Then
                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm")

            End If

            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm", commandstart, True)
            Console.WriteLine("Set program start on menu!")

        End If
    End Sub
End Module
