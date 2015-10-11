Module DevMenu
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
    Sub DevMenu(ByRef menu As String, ByRef devmode As Boolean, ByRef checkdevmode As Object, ByRef i As SByte, ByRef nameservers As String(), ByRef nservers As SByte, ByRef path As String(), _
                ByRef checkpath As Object(), ByRef language As SByte, ByRef checklanguage As Object, ByRef backupstatus As String(), ByRef checknameserver As Object())

        If menu = "devon" Then
            If i = 3 And devmode = True Then
                Console.WriteLine("DEV MODE is already active")
                Console.ReadLine()

            Else
                If i = 3 Then
                    If devmode = False And checkdevmode Then
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")

                    End If

                    devmode = True
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm", devmode, True)
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("DEV MODE ENABLED")
                    Console.ReadLine()
                End If
            End If


        ElseIf menu = "devoff" Then
            If i = 3 And devmode = False Then
                Console.WriteLine("DEV MODE is already disable")
                Console.ReadLine()

            Else
                If i = 3 Then
                    If devmode = True And checkdevmode Then
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm")

                    End If

                    devmode = False
                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\DevMode.pm", devmode, True)
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("DEV MODE DISABLED")
                    Console.ReadLine()
                End If
            End If
        End If

        If menu = "6" And devmode = True Then

            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Current Memory Usage:")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine()

            'Memory process
            Dim c As Process = Process.GetCurrentProcess()

            For index = 1 To 5

                Console.WriteLine("Mem Usage (Working Set): " & (c.WorkingSet64 / 1024).ToString & " K" & vbCrLf _
                & "VM Size (Private Bytes): " & (c.PagedMemorySize64 / 1024).ToString & " K" & vbCrLf _
                & "GC TotalMemory: " & GC.GetTotalMemory(True) & " bytes")

                System.Threading.Thread.Sleep(2000)

                Console.WriteLine()
            Next
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("DONE! Press ENTER to continue.")

            Console.ReadLine()

        End If

        If menu = "7" And devmode = True Then
            Try
                Process.Start("C:\Program Files\PocketMine-ManagerServers\PM-MS(BackgroudTask).exe")

            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! Bad Installation!")
                Console.ReadLine()
            End Try

        End If

        If menu = "8" And devmode = True Then
            ConsoleCommand.ConsoleCommand(nameservers, nservers, path, checkpath, language, checklanguage, backupstatus, checknameserver)

        End If

    End Sub
End Module
