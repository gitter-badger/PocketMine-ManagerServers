Module CompleterLoader
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
    Sub CompleterLoader(ByRef defaultservers As String)

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

        checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        If checknservers Then
            nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        Else
            Do
                Try
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine("-------------------------<Complete the informations>----------------------------")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Write("How many servers do you want to manage? <1/2/3/.../10> : ")
                    nservers = Console.ReadLine

                    If nservers > 10 Then
                        Console.WriteLine("ERROR! You have exceeded the maximum number of servers available. Please reduce the amount!")
                        Console.ReadLine()

                    ElseIf nservers <= 0 Then
                        Console.WriteLine("ERROR! You have to manage one or more server! (MAX TEN!!)")
                        Console.ReadLine()

                    End If

                Catch ex As Exception
                    Console.WriteLine(ex)

                End Try
            Loop While nservers > 10 Or nservers <= 0

            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm", nservers, True)

        End If

        Checking(checknameserver, checkpath)

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("-------------------------<Complete the informations>----------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("If you do not enter a name for your server , by default it will be '{0}'", defaultservers)

        If nservers >= 1 Then
            If nservers = 1 And checknameserver(0) Then

                Exit Sub

            ElseIf nservers = 1 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 2 And checknameserver(0) And checknameserver(1) Then

                Exit Sub

            ElseIf nservers = 2 Then

                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 3 And checknameserver(0) And checknameserver(1) And checknameserver(2) Then

                Exit Sub

            ElseIf nservers = 3 Then

                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 4 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) Then

                Exit Sub

            ElseIf nservers = 4 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 5 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) Then

                Exit Sub

            ElseIf nservers = 5 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 6 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) Then

                Exit Sub

            ElseIf nservers = 6 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 7 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) Then

                Exit Sub

            ElseIf nservers = 7 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 8 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) Then

                Exit Sub

            ElseIf nservers = 8 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 9 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) Then

                Exit Sub

            ElseIf nservers = 9 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 10 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) And checknameserver(9) Then

                Exit Sub

            ElseIf nservers = 10 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If
        End If

    End Sub
End Module
