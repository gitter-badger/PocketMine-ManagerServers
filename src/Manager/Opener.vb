Module Opener
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
    Sub Opener(ByRef nservers As Integer, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef performancestatus As String(), _
               ByRef back As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef opener0 As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, _
               ByRef opener5 As String, ByRef opener6 As String, ByRef opener7 As String, ByRef opener8 As String)

        Reading(path, nservers, nameservers)

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.DarkMagenta
            Console.WriteLine("-----------------------------------<{0}>-------------------------------------", opener0)
            Console.ForegroundColor = ConsoleColor.White
            For i = 1 To nservers
                Console.WriteLine("{0} server: {1}", numberservers_2(i - 1), nameservers(i - 1))
            Next
            Console.WriteLine()
            Console.WriteLine("{0}:", opener1)
            Console.WriteLine("1- Servers")
            Console.WriteLine("2- {0}", opener8)
            Console.WriteLine("3- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", opener2)
            pathopener = Console.ReadLine

            If pathopener = "1" Or pathopener = "2" Then
                Exit Do

            ElseIf pathopener = "3" Then
                Exit Sub

            End If

        Loop While pathopener <> ""

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" And pathopener = "1" And pathopener = "2" Then
            Console.WriteLine()
            Console.WriteLine("{0}", opener3)
            Console.WriteLine("{0}", opener4)

            Console.WriteLine()
            Console.WriteLine("{0}", opener5)

            If pathopener = "1" Then

                For i = 1 To nservers
                    If nservers > 1 Then
                        Console.WriteLine("{0} {1} server!", opener6, numberservers(i - 1))
                        Process.Start(path(i - 1) + "\start.cmd")

                        Console.WriteLine("{0}", opener7)

                        System.Threading.Thread.Sleep(3000)

                    Else
                        Console.WriteLine("{0} {1} server!", opener6, numberservers(i - 1))
                        Process.Start(path(i - 1) + "\start.cmd")
                    End If
                Next

            End If

            If pathopener = "2" Then
                For i = 1 To nservers
                    Process.Start(path(i - 1))

                Next
            End If

        Else
            For i = 1 To nservers
                Do
                    Console.Write("{0} {1} {2} ", writepath1, numberservers(i - 1), writepath2)
                    path(i - 1) = Console.ReadLine

                    If path(i - 1) = "" Then
                        Console.ForegroundColor = ConsoleColor.DarkRed
                        Console.WriteLine("{0}", writepath3)
                        Console.ReadLine()

                    End If
                Loop While path(i - 1) = ""

                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next
        End If
    End Sub
End Module
