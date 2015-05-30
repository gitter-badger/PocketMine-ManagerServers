Module LanguagesSelector
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

    Sub LanguagesSelector()

        Dim language As String

        Do
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("----------------------------<Selection Languages>-------------------------------")
            Console.ForegroundColor = ConsoleColor.White
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
            Console.WriteLine()
            Console.Write("Choose language: ")
            language = Console.ReadLine

        Loop While language = ""

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm", language, True)

        If language = "1" Then

        ElseIf language = "2" Then

        ElseIf language = "3" Then

        ElseIf language = "4" Then

        ElseIf language = "5" Then

        ElseIf language = "6" Then

        ElseIf language = "7" Then

        ElseIf language = "8" Then

        ElseIf language = "9" Then 'English
            'English.English()

        ElseIf language = "10" Then

        ElseIf language = "11" Then

        ElseIf language = "12" Then

        ElseIf language = "13" Then

        ElseIf language = "14" Then

        ElseIf language = "" Then

        ElseIf language = "15" Then

        ElseIf language = "16" Then

        ElseIf language = "17" Then

        ElseIf language = "18" Then

        ElseIf language = "19" Then

        ElseIf language = "20" Then

        ElseIf language = "21" Then

        ElseIf language = "22" Then

        ElseIf language = "23" Then

        ElseIf language = "24" Then

        ElseIf language = "25" Then

        ElseIf language = "26" Then

        ElseIf language = "27" Then

        ElseIf language = "28" Then

        ElseIf language = "29" Then

        ElseIf language = "30" Then

        End If
    End Sub
End Module
