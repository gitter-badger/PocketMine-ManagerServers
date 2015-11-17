Module Performances
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
    Sub Performances(ByRef checkpath As Object(), ByRef checknameservers As Object(), ByRef performance As String, ByRef nameservers As String(), ByRef nservers As SByte, ByRef performancestatus As String(), ByRef path As Object(), ByRef back As String, _
                     ByRef changemade As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef performancetitle As String, ByRef performance11 As String, ByRef performance12 As String)

        Dim selectperformance, checkyml, checkyml2 As Object

        Checking(checknameservers, checkpath)

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
            Do
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("{0}", performancetitle)
                For i = 1 To nservers
                    Console.WriteLine("{0}) {1}", i, nameservers(i - 1))

                Next
                Console.WriteLine("11) {0}", back)
                Console.WriteLine()
                Console.Write("{0}", performance11)
                selectperformance = Console.ReadLine

                If selectperformance = "11" Then
                    Exit Sub
                End If

            Loop While selectperformance < "1" Or selectperformance > "10"

            If selectperformance >= 1 Then
                Console.WriteLine("{0}", performance12)

                If performance = "1" Then 'High
                    ChangePerformance(path(selectperformance - 1), "HIGH")
                    ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                End If

                If performance = "2" Then 'Medium
                    ChangePerformance(path(selectperformance - 1), "MEDIUM")
                    ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                End If

                If performance = "3" Then
                    ChangePerformance(path(selectperformance - 1), "LOW")
                    ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                End If
            End If

        Else
            Do
                Console.Write("{0} {1} {2}", writepath1, nameservers(selectperformance - 1), writepath2)
                path(selectperformance - 1) = Console.ReadLine

                If path(selectperformance - 1) = "" Then
                    Console.WriteLine("{0}", writepath3)
                    Console.ReadLine()

                End If
            Loop While path(selectperformance - 1) = ""

            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(selectperformance) + ".pm", path(selectperformance - 1), True)

        End If

    End Sub

    Sub ChangePerformance(ByRef path As String, ByRef priority As String)

        Dim checkyml As Boolean = My.Computer.FileSystem.FileExists(path + "\pocketmine.yml")
        Dim checkyml2 As Boolean = My.Computer.FileSystem.FileExists(path + "\pocketmine_OLD.yml")

        If checkyml Then
            If checkyml2 Then
                My.Computer.FileSystem.DeleteFile(path + "\pocketmine_OLD.yml")
                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_" + priority + ".yml", path + "\pocketmine_" + priority + ".yml", overwrite:=True)
                My.Computer.FileSystem.RenameFile(path + "\pocketmine.yml", "pocketmine_OLD.yml")
                My.Computer.FileSystem.RenameFile(path + "\pocketmine_" + priority + ".yml", "pocketmine.yml")

            Else
                My.Computer.FileSystem.RenameFile(path + "\pocketmine.yml", "pocketmine_OLD.yml")
                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_" + priority + ".yml", path + "\pocketmine_" + priority + ".yml", overwrite:=True)
                My.Computer.FileSystem.RenameFile(path + "\pocketmine_" + priority + ".yml", "pocketmine.yml")

            End If
        Else
            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_" + priority + ".yml", path + "\pocketmine_" + priority + ".yml", overwrite:=True)
            My.Computer.FileSystem.RenameFile(path + "\pocketmine_" + priority + ".yml", "pocketmine.yml")

        End If
    End Sub

    Sub ChoosePerformance(ByRef selectperformance As String, ByRef performancestatus As String(), ByRef performance As String, ByRef changemade As String)

        Dim index As SByte
        Dim indexstatus As SByte = -1
        Dim status As String() = New String() {"High", "Medium", "Low"}
        Dim verified As Boolean = False

        While verified = False
            index = Convert.ToInt32(selectperformance)
            indexstatus += 1

            If performance = Convert.ToString(indexstatus) Then
                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(index) + ".pm")
                performancestatus(index - 1) = status(indexstatus - 1)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(index) + ".pm", performancestatus(index - 1), True)
                verified = True
            End If
        End While

        Console.WriteLine()
        Console.WriteLine("{0}", changemade)
        Console.ReadLine()
    End Sub

End Module
