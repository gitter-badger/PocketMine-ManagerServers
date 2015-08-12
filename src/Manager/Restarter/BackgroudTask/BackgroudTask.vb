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

    Sub Main()
        Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim devmode As Boolean
        Dim checkdevmode As Object

        Dim choosetime, chooserestart2 As String
        Dim nservers, time, chooseserver As Integer
        Dim autorestart As Boolean

        checkdevmode = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")

        time = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\Time.pm")
        choosetime = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\ChooseTime.pm")
        nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")
        chooseserver = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\ChooseServer.pm")

        For i = 1 To nservers
            path(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")
        Next

        Console.Title = "PocketMine-ManagerServers(BackgroudTask)"

        If checkdevmode Then
            devmode = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")
        End If

        If devmode = True Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("                                                                  DEVMODE ACTIVE")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Don't turn off this program")
        Console.WriteLine("Wait 3 seconds...")
        System.Threading.Thread.Sleep(3000)
        Console.WriteLine("Starting timer...")

        If devmode = False Then
            Dim hWndConsole As IntPtr
            hWndConsole = GetConsoleWindow()
            ShowWindow(hWndConsole, SW_HIDE)
        End If

        Do
            If choosetime = "1" Then
                System.Threading.Thread.Sleep(time * 24 * 3600 * 1000)

            ElseIf choosetime = "2" Then
                System.Threading.Thread.Sleep(time * 3600 * 1000)

            ElseIf choosetime = "3" Then
                System.Threading.Thread.Sleep(time * 60 * 1000)

            End If

            'SERVER RESTARTING
            Dim PMProcess() As Process = System.Diagnostics.Process.GetProcessesByName("mintty") 'Process of PocketMine-MP

            Console.WriteLine("Restarting...")
            For Each p As Process In PMProcess 'TODO: Add /save-all and /stop command for security restart
                p.Kill() 'This is so bad for the moment.
            Next

            Console.WriteLine("Wait 3 seconds...")
            System.Threading.Thread.Sleep(3000)
            Process.Start(path(chooseserver - 1) + "\start.cmd")

            Console.WriteLine("Server Restarted!")
            Console.WriteLine()

            If devmode = True Then
                Console.Write("Do you want to restart again? <Y/N>: ") 'TODO: Remove and do a continue cycle that can be stopped by string
                chooserestart2 = Console.ReadLine().ToUpper
            Else
                autorestart = True
            End If
            'END

        Loop While chooserestart2 = "Y" Or autorestart = True


        Console.ReadLine()
    End Sub

End Module
