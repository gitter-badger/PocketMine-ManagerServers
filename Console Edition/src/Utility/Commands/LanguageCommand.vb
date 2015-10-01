Module LanguageCommand
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
    Sub LanguageCommand(ByRef args As String(), ByRef command As String, ByRef language As Integer, ByRef checklanguage As Object)

        If command = "language" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /language <languagename>")

        ElseIf command = "language list" Then

            Console.WriteLine("1) Afrikaans" + vbTab + vbTab + vbTab + "16) Italian")
            Console.WriteLine("2) Arabic" + vbTab + vbTab + vbTab + "17) Japanese")
            Console.WriteLine("3) Catalan" + vbTab + vbTab + vbTab + "18) Korean")
            Console.WriteLine("4) Chinese Simplified" + vbTab + vbTab + "19) Norwegian")
            Console.WriteLine("5) Chinese Traditional" + vbTab + vbTab + "20) Polish")
            Console.WriteLine("6) Czech" + vbTab + vbTab + vbTab + "21) Portuguese")
            Console.WriteLine("7) Danish" + vbTab + vbTab + vbTab + "22) Portuguese, Brazilian")
            Console.WriteLine("8) Dutch" + vbTab + vbTab + vbTab + "23) Romanian")
            Console.WriteLine("9) English" + vbTab + vbTab + vbTab + "24) Russian")
            Console.WriteLine("10) Finnish" + vbTab + vbTab + vbTab + "25) Serbian(Cyrillic)")
            Console.WriteLine("11) French" + vbTab + vbTab + vbTab + "26) Spanish")
            Console.WriteLine("12) German" + vbTab + vbTab + vbTab + "27) Swedish")
            Console.WriteLine("13) Greek" + vbTab + vbTab + vbTab + "28) Turkish")
            Console.WriteLine("14) Hebrew" + vbTab + vbTab + vbTab + "29) Ukrainian")
            Console.WriteLine("15) Hungarian" + vbTab + vbTab + vbTab + "30) Vietnamese")
        Else
            If command.ToLower = "language " + args(1) Then
                If args(1) = "italian" Or args(1) = "16" Then
                    language = 16
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Languange set to Italian")

                ElseIf args(1) = "english" Or args(1) = "9" Then
                    language = 9
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Languange set to English")

                End If

                If checklanguage Then
                    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm")
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm", language, True)

                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("An error occured")

                End If

            End If
        End If
    End Sub

End Module
