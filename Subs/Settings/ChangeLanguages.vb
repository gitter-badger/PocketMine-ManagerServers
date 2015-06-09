﻿Module ChangeLanguages
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
    Sub ChangeLanguages(ByRef checklanguage As Object, ByRef dirlanguages As Object, ByRef language As Integer, ByRef changelang As Boolean, ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, _
                 ByRef menudev As String, ByRef menutitle As String, ByRef menu1 As String, ByRef menu2 As String, ByRef menu3 As String, ByRef menu4 As String, ByRef menu5 As String, ByRef menu6 As String, ByRef installertitle As String, ByRef installer1 As String, ByRef installer2 As String, ByRef installer3 As String, _
                 ByRef installator1 As String, ByRef installator2 As String, ByRef installator3 As String, ByRef installator4 As String, ByRef installator5 As String, ByRef downloader1 As String, ByRef downloader2 As String, ByRef downloader3 As String, ByRef downloader4 As String, ByRef downloader5 As String, ByRef downloader6 As String, _
                 ByRef downloader7 As String, ByRef downloader8 As String, ByRef downloader9 As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, ByRef opener5 As String, ByRef opener6 As String, _
                 ByRef opener7 As String, ByRef editor1 As String, ByRef editor2 As String, ByRef editor3 As String, ByRef properties1 As String, ByRef properties2 As String, ByRef properties3 As String, ByRef properties4 As String, ByRef properties5 As String, ByRef properties6 As String, ByRef performance1 As String, _
                 ByRef performance2 As String, ByRef performance3 As String, ByRef performance4 As String, ByRef performance5 As String, ByRef performance6 As String, ByRef performance7 As String, ByRef performance8 As String, ByRef performance9 As String, ByRef performance10 As String, ByRef performance11 As String, _
                 ByRef performance12 As String, ByRef performance13 As String, ByRef option1 As String, ByRef option2 As String, ByRef option3 As String, ByRef lang1 As String, ByRef resetp1 As String, ByRef resetp2 As String, ByRef resetp3 As String, ByRef resetp4 As String, ByRef resetp5 As String, ByRef resetp6 As String, _
                 ByRef resetp7 As String, ByRef resetp8 As String, ByRef resetp9 As String, ByRef resetp10 As String, ByRef resetp11 As String, ByRef info1 As String, ByRef info2 As String, ByRef info3 As String, ByRef info4 As String, ByRef info5 As String, ByRef info6 As String, ByRef exit1 As String, ByRef exit2 As String)

        'Dim language As Integer
        'Dim changelang As Boolean

        Do
            Try
                Console.ForegroundColor = ConsoleColor.Green
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.DarkMagenta
                Console.WriteLine("----------------------------------<Languages>-----------------------------------")
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

            If checklanguage Then
                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm")
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm", language, True)

                changelang = True

                LanguagesSelector.LanguagesSelector(dirlanguages, changelang, back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menudev, menutitle, _
                              menu1, menu2, menu3, menu4, menu5, menu6, installertitle, installer1, installer2, installer3, installator1, installator2, installator3, installator4, _
                              installator5, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, manager1, manager2, manager3, _
                              opener1, opener2, opener3, opener4, opener5, opener6, opener7, editor1, editor2, editor3, properties1, properties2, properties3, properties4, properties5, _
                              properties6, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, _
                              performance12, performance13, option1, option2, option3, lang1, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11, _
                              info1, info2, info3, info4, info5, info6, exit1, exit2)

            Else
                Console.WriteLine("Bad error")

            End If

        Loop While language > 30 Or language <= 0



    End Sub
End Module
