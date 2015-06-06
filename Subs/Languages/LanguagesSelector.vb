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

    Sub LanguagesSelector(ByRef dirlanguages As Object, ByRef changelang As Boolean)

        Dim language As Integer

        Do
            If changelang = True Then
                Exit Do

            Else
                Try
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

                    If language > 30 Or language <= 0 Then
                        Console.WriteLine("Please select an avaiable language!")

                    End If

                Catch ex As Exception
                    Console.WriteLine(ex)

                End Try
            End If

        Loop While language > 30 Or language <= 0

        If changelang = False Then
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm", language, True)

        End If

        If language = 1 Then 'Afrikaans
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Afrikaans")

            changelang = False

        ElseIf language = 2 Then 'Arabic
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Arabic")

            changelang = False

        ElseIf language = 3 Then 'Catalan
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Catalan")

            changelang = False

        ElseIf language = 4 Then 'Chinese Simplified
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Chinese(Simplified)")

            changelang = False

        ElseIf language = 5 Then 'Chinese Traditional
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Chinese(Traditional)")

            changelang = False

        ElseIf language = 6 Then 'Czech
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Czech")

            changelang = False

        ElseIf language = 7 Then 'Danish
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Danish")

            changelang = False

        ElseIf language = 8 Then 'Dutch
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Dutch")

            changelang = False

        ElseIf language = 9 Then 'English
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\English")
            English.English()

            changelang = False

        ElseIf language = 10 Then 'Finnish
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Finnish")

            changelang = False

        ElseIf language = 11 Then 'French
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\French")

            changelang = False

        ElseIf language = 12 Then 'German
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\German")

            changelang = False

        ElseIf language = 13 Then 'Greek
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Greek")

            changelang = False

        ElseIf language = 14 Then 'Hebrew
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Hebrew")

            changelang = False

        ElseIf language = 15 Then 'Hungarian
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Hungarian")

            changelang = False

        ElseIf language = 16 Then 'Italian
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Italian")

            changelang = False

        ElseIf language = 17 Then 'Japanese
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Japanese")

            changelang = False

        ElseIf language = 18 Then 'Korean
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Korean")

            changelang = False

        ElseIf language = 19 Then 'Norwegian
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Norwegian")

            changelang = False

        ElseIf language = 20 Then 'Polish
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Polish")

            changelang = False

        ElseIf language = 21 Then 'Portuguese
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Portuguese")

            changelang = False

        ElseIf language = 22 Then 'Portuguese(Brazilian)
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Portuguese(Brazilian)")

            changelang = False

        ElseIf language = 23 Then 'Romanian
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Romanian")

            changelang = False

        ElseIf language = 24 Then 'Russian
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Russian")

            changelang = False

        ElseIf language = 25 Then 'Serbian(Cyrillic)
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Serbian(Cyrillic)")

            changelang = False

        ElseIf language = 26 Then 'Spanish
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Spanish")

            changelang = False

        ElseIf language = 27 Then 'Swedish
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Swedish")

            changelang = False

        ElseIf language = 28 Then 'Turkish
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Turkish")

            changelang = False

        ElseIf language = 29 Then 'Ukrainian
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Ukrainian")

            changelang = False

        ElseIf language = 30 Then 'Vietnamese
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Vietnamese")

            changelang = False

        End If

        LanguageReader.LanguageReader(language, changelang)
    End Sub
End Module
