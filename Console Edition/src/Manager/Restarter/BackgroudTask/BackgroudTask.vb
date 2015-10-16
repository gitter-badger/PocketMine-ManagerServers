Imports System.Runtime.InteropServices
Module BackgroudTask
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

    Private Declare Auto Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    Private Declare Auto Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 5

    Sub Main()

        Console.Title = "PocketMine-ManagerServers(BackgroudTask)"

        Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim devmode As Boolean
        Dim checkdevmode As Object

        Dim choosetime, chooserestart2 As String
        Dim nservers, time, chooseserver As Integer
        Dim autorestart As Boolean = False

        Dim hWndConsole As IntPtr

        Dim checktime, checkchoosetime, checkchooseserver As Object

        checktime = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\Time.pm")
        checkchoosetime = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\ChooseTime.pm")
        checkchooseserver = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\ChooseServer.pm")

        checkdevmode = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")

        If checktime And checkchooseserver And checkchoosetime Then
            time = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\Time.pm")
            choosetime = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\ChooseTime.pm")
            nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")
            chooseserver = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\ChooseServer.pm")

            hWndConsole = GetConsoleWindow()

            For i = 1 To nservers
                path(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")
            Next

            If checkdevmode Then
                devmode = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")
            End If

            Do
                Console.Clear()
                If devmode = True Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("                                                                  DEVMODE ACTIVE")
                End If

                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("This program run in background in 5 seconds...")
                System.Threading.Thread.Sleep(5000)
                Console.WriteLine("Starting timer...")
                Console.WriteLine()

                If devmode = False Then
                    ShowWindow(hWndConsole, SW_HIDE)

                ElseIf devmode = True Then
                    ShowWindow(hWndConsole, SW_SHOW)

                End If

                If choosetime = "1" Then
                    System.Threading.Thread.Sleep(time * 24 * 3600 * 1000)

                ElseIf choosetime = "2" Then
                    System.Threading.Thread.Sleep(time * 3600 * 1000)

                ElseIf choosetime = "3" Then
                    System.Threading.Thread.Sleep(time * 60 * 1000)

                End If

                'SERVER RESTARTING
                Dim PMProcess() As Process = Process.GetProcessesByName("mintty") 'Process of PocketMine-MP
                Console.WriteLine("Restarting...")
                For Each p As Process In PMProcess 'TODO: Add /save-all and /stop command for security restart
                    p.Kill() 'This is so bad for the moment.
                Next

                Console.WriteLine()
                Console.WriteLine("Wait 3 seconds...")
                System.Threading.Thread.Sleep(3000)
                Process.Start(path(chooseserver - 1) + "\start.cmd")

                Console.WriteLine("Server Restarted!")
                Console.WriteLine()

                If devmode = True Then
                    Console.Write("Do you want to restart again? <Y/N>: ")
                    chooserestart2 = Console.ReadLine().ToUpper
                Else
                    Console.WriteLine("Rerun timer...")
                    System.Threading.Thread.Sleep(2000)
                    autorestart = True
                End If
                'END

                If chooserestart2 = "N" Then
                    Try
                        Process.Start("C:\Program Files\PocketMine-ManagerServers\PocketMine-ManagerServers.exe")
                    Catch ex As Exception
                        Console.WriteLine("BAD INSTALLATION")
                    End Try
                End If

            Loop While chooserestart2 = "Y" Or autorestart = True
        Else
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("You must first enter the values for the restart of servers")
            Console.ReadLine()
        End If
    End Sub

End Module
