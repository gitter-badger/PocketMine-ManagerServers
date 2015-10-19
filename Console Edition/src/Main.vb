Module Main
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
    Sub Main()
        '#Variables languages
        Dim back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3 As String
        Dim menudev, menutitle, menu1, menu2, menu3, menu4, menu5, menu6 As String
        Dim installertitle, installer1, installer2, installer3 As String
        Dim installatortitle, installator1, installator2, installator3, installator4, installator5, installator6, installator7 As String
        Dim versions1, versions2, versions3 As String
        Dim downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11 As String
        Dim managertitle, manager1, manager2, manager3, manager4, manager5 As String
        Dim openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8 As String
        Dim editortitle, editor1, editor2, editor3 As String
        Dim propertiestitle, properties1, properties2, properties3, properties4, properties5, properties6 As String
        Dim performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, performance12 As String
        Dim rescuertitle, rescuer1, rescuer2 As String
        Dim backuptitle, backup1, backup2, backup3, backup4, backup5 As String
        Dim restoretitle, restore1, restore2, restore3, restore4, restore5 As String
        Dim restartertitle, restarter1, restarter2, restarter3, restarter4, restarter5, restarter6, restarter7, restarter8, restarter9, restarter10, restarter11, restarter12 As String
        Dim optiontitle, option1, option2, option3 As String
        Dim lang1 As String
        Dim resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11 As String
        Dim infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6 As String
        Dim exittitle, exit1, exit2 As String

        '#Variables Main Menu and other (Loader, etc..)
        Dim menu, quit, defaultservers As String
        Dim checkfolderinstallation, checklicense, checklanguage As Object
        Dim checklang, changelang As Boolean
        Dim language As SByte

        Dim devmode As Boolean
        Dim checkdevmode As Object

        '#Variables "Install PocketMine-MP"
        Dim downloadstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim installationstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim versionstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkinstallations As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
        Dim checkdownloads As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        '#Variables "Manage Servers"
        Dim nservers As SByte
        Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}
        Dim numberservers_2 As String() = New String() {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"}

        Dim checknservers As Object

        Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        Dim pathopener As String
        Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkpath As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
        '-------------------------------------------------------------------------------------------------------------------------------------------------
        Dim varmanager As String

        '-------------------------------------------------------------------------------------------------------------------------------------------------
        Dim performance, confirmperfomance, selectperformance As String

        Dim performancestatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkperformance As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
        '--------------#Variables Rescuer(Backup)
        Dim backupstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        '#Variables Mechanical
        Dim dirservername, dirpath, dirdata, dirutils, dirperformance, dirinstallations, dirlanguages, direrrors As Object

        Const version_pm As String = "1.3"
        Const build_pm As String = "BUILD 1"

        Dim commandstart As Boolean
        Dim checkcommand As Object = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm")

        'STARTUP
        'Console.Title = "PocketMine-ManagerServers v" + version_pm
        Console.Title = "PocketMine-ManagerServers v" + version_pm + " [" + build_pm + "]"

        Loader.Loader(checklanguage, versionstatus, dirinstallations, checkinstallations, checkdownloads, checkperformance, checknameserver, nameservers, performancestatus, nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, _
                      dirperformance, dirutils, checklicense, downloadstatus, installationstatus, backupstatus, dirlanguages, direrrors, changelang, back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menudev, menutitle, _
                      menu1, menu2, menu3, menu4, menu5, menu6, installertitle, installer1, installer2, installer3, installatortitle, installator1, installator2, installator3, installator4, _
                      installator5, installator6, installator7, downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11, managertitle, manager1, manager2, manager3, _
                      manager4, manager5, openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8, editortitle, editor1, editor2, editor3, propertiestitle, properties1, properties2, properties3, properties4, properties5, _
                      properties6, performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, _
                      performance12, rescuertitle, rescuer1, rescuer2, backuptitle, backup1, backup2, backup3, backup4, backup5, restoretitle, restore1, restore2, restore3, restore4, restore5, optiontitle, option1, option2, option3, lang1, _
                      resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11, _
                      infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6, exittitle, exit1, exit2, versions1, versions2, versions3, restartertitle, restarter1, restarter2, restarter3, restarter4, restarter5, _
                      restarter6, restarter7, restarter8, restarter9, restarter10, restarter11, restarter12)

        quit = "N"

        CompleterLoader.CompleterLoader(defaultservers)

        Console.Clear()
        Console.WriteLine("Loading resource...")
        System.Threading.Thread.Sleep(500)

        nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")
        language = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm")

        checkdevmode = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")

        If checkdevmode Then
            devmode = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")
        End If

        If checkcommand Then
            commandstart = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\Starter.pm")

        Else
            commandstart = False

        End If

        If commandstart = True Then
            ConsoleCommand.ConsoleCommand(nameservers, nservers, path, checkpath, language, checklanguage, backupstatus, checknameserver)

        End If

        LanguageReader.LanguageReader(language, back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menudev, menutitle, _
                              menu1, menu2, menu3, menu4, menu5, menu6, installertitle, installer1, installer2, installer3, installatortitle, installator1, installator2, installator3, installator4, _
                              installator5, installator6, installator7, downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11, managertitle, manager1, manager2, manager3, _
                              manager4, manager5, openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8, editortitle, editor1, editor2, editor3, propertiestitle, properties1, properties2, properties3, properties4, properties5, _
                              properties6, performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, _
                              performance12, rescuertitle, rescuer1, rescuer2, backuptitle, backup1, backup2, backup3, backup4, backup5, restoretitle, restore1, restore2, restore3, restore4, restore5, optiontitle, option1, option2, option3, lang1, _
                              resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11, _
                              infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6, exittitle, exit1, exit2, versions1, versions2, versions3, restartertitle, restarter1, restarter2, restarter3, _
                              restarter4, restarter5, restarter6, restarter7, restarter8, restarter9, restarter10, restarter11, restarter12)

        While quit = "N"
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("{0}", menutitle)
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Developed by matcracker                                     Version: " + version_pm + " " + build_pm)
            'Console.WriteLine("Developed by matcracker                                             Version: " + version_pm)
            If devmode = True Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("                                                                  DEVMODE ACTIVE")
            End If
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", menu1)
            Console.WriteLine("2- {0}", menu2)
            Console.WriteLine("3- {0}", menu3)
            Console.WriteLine("4- {0}", menu4)
            Console.WriteLine("5- {0}", menu5)

            If devmode = True Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("=={DEVMODE MENU}==")
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("6- Memory Usage")
                Console.WriteLine("7- Server Restarter (BackgroundTask)")
                Console.WriteLine("8- Commands Mode (Not server, only software)")
                Console.ForegroundColor = ConsoleColor.White

            End If
            Console.WriteLine()
            Console.Write("{0}", menu6)
            menu = Console.ReadLine.ToLower


            If menu = "1" Then 'Install PocketMine
                ManagerInstaller.ManagerInstaller(path, nameservers, nservers, checkpath, numberservers, downloadstatus, installationstatus, versionstatus, checknameserver, back, changemade, status1, version1, versionstable1, versionbeta1, _
                                        versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menu1, installertitle, installer1, installer2, installer3, installatortitle, installator1, installator2, installator3, installator4, installator5, _
                                        installator6, installator7, downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11, versions1, versions2, versions3)

            End If

            If menu = "2" Then 'Manage Servers
                Manager.Manager(nservers, varmanager, performance, performancestatus, backupstatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance, _
                                back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, managertitle, manager1, manager2, manager3, manager4, manager5, openertitle, opener1, opener2, opener3, _
                                opener4, opener5, opener6, opener7, opener8, editortitle, editor1, editor2, editor3, propertiestitle, properties1, properties2, properties3, properties4, properties5, properties6, performancetitle, performance1, performance2, performance3, performance4, performance5, _
                                performance6, performance7, performance8, performance9, performance10, performance11, performance12, rescuertitle, rescuer1, rescuer2, backuptitle, backup1, backup2, backup3, backup4, backup5, restoretitle, restore1, restore2, restore3, restore4, _
                                restartertitle, restarter1, restarter2, restarter3, restarter4, restarter5, restarter6, restarter7, restarter8, restarter9, restarter10, restarter11, restarter12, installer3)

            End If

            If menu = "3" Then 'Program Options
                Settings.Settings(nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, dirperformance, dirinstallations, dirlanguages, direrrors, checklanguage, _
                                  language, changelang, back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menudev, menutitle, _
                              menu1, menu2, menu3, menu4, menu5, menu6, installertitle, installer1, installer2, installer3, installatortitle, installator1, installator2, installator3, installator4, _
                              installator5, installator6, installator7, downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11, managertitle, manager1, manager2, manager3, _
                              manager4, manager5, openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8, editortitle, editor1, editor2, editor3, propertiestitle, properties1, properties2, properties3, properties4, properties5, _
                              properties6, performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, _
                              performance12, rescuertitle, rescuer1, rescuer2, backuptitle, backup1, backup2, backup3, backup4, backup5, restoretitle, restore1, restore2, restore3, restore4, restore5, optiontitle, option1, option2, option3, lang1, _
                              resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11, _
                              infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6, exittitle, exit1, exit2, versions1, versions2, versions3, devmode, checkdevmode, restartertitle, restarter1, restarter2, restarter3, restarter4, _
                              restarter5, restarter6, restarter7, restarter8, restarter9, restarter10, restarter11, restarter12)

            End If

            If menu = "4" Then 'Informations
                Informations.Informations(checklicense, back, menu4, info1, info2, info3, info4, info5, info6, infotitle, infocredits, infoinformations, infodisclaimer)

            End If

            If menu = "5" Then 'Exit
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkGreen
                    Console.WriteLine("{0}", exittitle)
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Write("{0}", exit1)
                    quit = Console.ReadLine.ToUpper
                Loop While quit <> "Y" And quit <> "N"

                If quit = "Y" Then
                    Console.WriteLine("{0}", exit2)
                    Console.ReadLine()
                    End

                End If
            End If

            Dim i As SByte

            If i >= 3 Then
                i = 0
            End If

            If menu = "devon" Or menu = "devoff" Or menu = "6" Or menu = "7" Or menu = "8" Then
                i += 1
                DevMenu.DevMenu(menu, devmode, checkdevmode, i, nameservers, nservers, path, checkpath, language, checklanguage, backupstatus, checknameserver)
            End If

        End While
    End Sub

    Sub Writing(ByRef nameservers As String(), ByRef nservers As SByte, ByRef path As String())
        For i = 1 To nservers
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm", nameservers(i - 1), True)

        Next
    End Sub

    Sub Reading(ByRef path As Object(), ByRef nservers As SByte, ByRef nameservers As String())
        For i = 1 To nservers
            path(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")

        Next

    End Sub

    Sub Checking(ByRef checknameserver As Object(), ByRef checkpath As Object())
        For i = 1 To 10
            checknameserver(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
            checkpath(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")

        Next
    End Sub

    Sub Selection(ByRef nservers As SByte, ByRef nameservers As String(), ByRef numberservers As String(), ByRef defaultservers As String)
        For i = 1 To nservers
            defaultservers = ("Server_Minecraft_PE_" + Convert.ToString(i))

            Console.Write("{0}) Name of {1} server?: ", i, numberservers(i - 1))
            nameservers(i - 1) = Console.ReadLine

            If nameservers(i - 1).Contains(" ") Then
                Console.WriteLine("Sorry, but you can't insert space from name")
                Console.ReadLine()
                CompleterLoader.CompleterLoader(defaultservers)

            Else
                If nameservers(i - 1) = "" Then
                    nameservers(i - 1) = defaultservers
                End If
            End If
        Next
    End Sub
End Module