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

        Dim menu, quit, defaultservers As String
        Dim checkfolderinstallation, checklicense, checklanguage As Object
        Dim checklang As Boolean

        '#Variables "Install PocketMine-MP"
        Dim downloadstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim installationstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim versionstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkinstallations As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
        Dim checkdownloads As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        '#Variables "Manage Servers"
        Dim nservers As Integer
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

        '#Variables Mechanical
        Dim dirservername, dirpath, dirdata, dirutils, dirperformance, dirinstallations, dirlanguages, direrrors As Object

        'STARTUP

        Loader.Loader(checklanguage, versionstatus, dirinstallations, checkinstallations, checkdownloads, checkperformance, checknameserver, nameservers, performancestatus, nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, _
                      dirperformance, dirutils, checklicense, downloadstatus, installationstatus, dirlanguages, direrrors, checklang)

        quit = "N"

        CompleterLoader.CompleterLoader(defaultservers)

        nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        While quit = "N"
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("-------------------------------<Main Menu>--------------------------------------")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("                                                           Version: 1.1 #BUILD 1")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Install PocketMine-MP")
            Console.WriteLine("2- Manage Servers")
            Console.WriteLine("3- Programm Options")
            Console.WriteLine("4- Informations")
            Console.WriteLine("5- Exit")
            Console.WriteLine()
            Console.Write("What would you like to do?: ")
            menu = Console.ReadLine

            If menu = "1" Then
                ManagerInstaller.ManagerInstaller(path, nameservers, nservers, checkpath, numberservers, downloadstatus, installationstatus, versionstatus, checknameserver)

            End If

            If menu = "2" Then 'Manage Servers

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            End If

            If menu = "3" Then 'Program Options
                Settings.Settings(nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, dirperformance, dirinstallations, dirlanguages, direrrors, checklanguage)

            End If

            If menu = "4" Then
                Informations.Informations(checklicense)

            End If

            If menu = "5" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkGreen
                    Console.WriteLine("----------------------------------<Exit>----------------------------------------")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Write("Are you sure you want to quit? <Y/N>: ")
                    quit = Console.ReadLine.ToUpper
                Loop While quit <> "Y" And quit <> "N"

                If quit = "Y" Then
                    Console.WriteLine("See you soon!")
                    Console.ReadLine()
                    End

                End If
            End If
        End While
    End Sub

    Sub Writing(ByRef nameservers As String(), ByRef nservers As Integer, ByRef path As String())
        For i = 1 To nservers
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm", nameservers(i - 1), True)

        Next
    End Sub

    Sub Reading(ByRef path As Object(), ByRef nservers As Integer, ByRef nameservers As String())
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

    Sub Selection(ByRef nservers As Integer, ByRef nameservers As String(), ByRef numberservers As String(), ByRef defaultservers As String)
        For i = 1 To nservers
            defaultservers = ("Server Minecraft PE_" + Convert.ToString(i))

            Console.Write("{0}) Name of {1} server?: ", i, numberservers(i - 1))
            nameservers(i - 1) = Console.ReadLine

            If nameservers(i - 1) = "" Then
                nameservers(i - 1) = defaultservers
            End If
        Next
    End Sub
End Module