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
    Sub Performances(ByRef checkpath As Object(), ByRef checknameservers As Object(), ByRef performance As String, ByRef nameservers As String(), ByRef nservers As Integer, ByRef selectperformance As String, ByRef performancestatus As String(), ByRef path As Object(), ByRef numberservers As String(), _
                     ByRef changemade As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef performancetitle As String, ByRef performance11 As String, ByRef performance12 As String)

        Dim checkyml, checkyml2 As Object

        Checking(checknameservers, checkpath)

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("{0}", performancetitle)
            For i = 1 To nservers
                Console.WriteLine("{0}) {1}", i, nameservers(i - 1))

            Next

            Try
                Console.WriteLine()
                Console.Write("{0}", performance11)
                selectperformance = Console.ReadLine

                If selectperformance >= 1 Then
                    Console.WriteLine("{0}", performance12)


                    If selectperformance = "1" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(0), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(0), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(0), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "2" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(1), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(1), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(1), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "3" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(2), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(2), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(2), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "4" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(3), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(3), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(3), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "5" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(4), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(4), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(4), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "6" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(5), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(5), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(5), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "7" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(6), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(6), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(6), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "8" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(7), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(7), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(7), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "9" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(8), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(8), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(8), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If

                    If selectperformance = "10" Then

                        If performance = "1" Then 'High
                            ChangePerformance(path(9), "HIGH", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "2" Then 'Medium
                            ChangePerformance(path(9), "MEDIUM", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If

                        If performance = "3" Then
                            ChangePerformance(path(9), "LOW", checkyml, checkyml2)
                            ChoosePerformance(selectperformance, performancestatus, performance, changemade)

                        End If
                    End If
                End If
            Catch ex As Exception

            End Try

        Else

            For i = 1 To nservers
                Do
                    Console.Write("{0} {1} {2}", writepath1, numberservers(i - 1), writepath2)
                    path(i - 1) = Console.ReadLine

                    If path(i - 1) = "" Then
                        Console.WriteLine("{0}", writepath3)
                        Console.ReadLine()

                    End If
                Loop While path(i - 1) = ""

                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next
        End If

    End Sub

    Sub ChangePerformance(ByRef path As String, ByRef priority As String, ByRef checkyml As Boolean, ByRef checkyml2 As Boolean)

        checkyml = My.Computer.FileSystem.FileExists(path + "\pocketmine.yml")
        checkyml2 = My.Computer.FileSystem.FileExists(path + "\pocketmine_OLD.yml")

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

        Dim index As Integer
        Dim indexstatus As Integer = -1
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

            Console.WriteLine()
            Console.WriteLine("{0}", changemade)
            Console.ReadLine()

        End While
    End Sub

End Module
