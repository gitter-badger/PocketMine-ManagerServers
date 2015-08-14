Module Manager
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
    Sub Manager(ByRef nservers As Integer, ByRef varmanager As String, ByRef performance As String, ByRef performancestatus As String(), ByRef backupstatus As String(), ByRef confirmperfomance As String, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef checkperformance As Object(), ByRef selectperformance As String, _
                ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef managertitle As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef manager4 As String, _
                ByRef openertitle As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, ByRef opener5 As String, ByRef opener6 As String, ByRef opener7 As String, ByRef opener8 As String, ByRef editortitle As String, ByRef editor1 As String, ByRef editor2 As String, ByRef editor3 As String, ByRef propertiestitle As String, ByRef properties1 As String, ByRef properties2 As String, ByRef properties3 As String, ByRef properties4 As String, ByRef properties5 As String, ByRef properties6 As String, _
                ByRef performance0 As String, ByRef performance1 As String, ByRef performance2 As String, ByRef performance3 As String, ByRef performance4 As String, ByRef performance5 As String, ByRef performance6 As String, ByRef performance7 As String, ByRef performance8 As String, ByRef performance9 As String, ByRef performance10 As String, ByRef performance11 As String, ByRef performance12 As String, ByRef rescuertitle As String, ByRef rescuer1 As String, ByRef rescuer2 As String, ByRef backuptitle As String, _
                ByRef backup1 As String, ByRef backup2 As String, ByRef backup3 As String, ByRef backup4 As String, ByRef backup5 As String, ByRef restoretitle As String, ByRef restore1 As String, ByRef restore2 As String, ByRef restore3 As String, ByRef restore4 As String)

        Reading(path, nservers, nameservers)

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("{0}", managertitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", manager1)
            Console.WriteLine("2- {0}", manager2)
            Console.WriteLine("3- {0}", manager3)
            Console.WriteLine("4- Server Restarter")
            Console.WriteLine("5- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", manager4)
            varmanager = Console.ReadLine

            If varmanager = "1" Then 'Work
                Opener.Opener(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, performancestatus, back, writepath1, writepath2, writepath3, manager1, manager2, manager3, _
                              openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8)

            End If

            If varmanager = "2" Then
                Editor.Editor(confirmperfomance, checkpath, checknameserver, performance, nameservers, nservers, performancestatus, path, numberservers, back, changemade, writepath1, writepath2, writepath3, editortitle, editor1, _
                              editor2, editor3, propertiestitle, properties1, properties2, properties3, properties4, properties5, properties6, performance0, performance1, performance2, performance3, performance4, performance5, performance6, performance7, _
                              performance8, performance9, performance10, performance11, performance12)

            End If

            If varmanager = "3" Then
                Rescuer.Rescuer(nservers, nameservers, backupstatus, checkpath, path, numberservers, back, writepath1, writepath2, writepath3, manager4, rescuertitle, rescuer1, rescuer2, backuptitle, backup1, backup2, backup3, backup4, backup5, restoretitle, restore1, restore2, restore3, restore4)

            End If

            If varmanager = "4" Then
                Restarter.Restarter(nservers, nameservers, checkpath, path, numberservers, writepath1, writepath2, writepath3)

            End If

        Loop While varmanager <> "5"
    End Sub

End Module
