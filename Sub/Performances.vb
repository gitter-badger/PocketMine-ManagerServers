Module Performances

    Sub Performances(ByRef checkpath As Object(), ByRef checknameservers As Object(), ByRef performance As String, ByRef nameservers As String(), ByRef nservers As Integer, ByRef selectperformance As String, ByRef performancestatus As String(), ByRef path As Object(), ByRef numberservers As String())

        Dim checkyml, checkyml2 As Object

        Checking(checknameservers, checkpath)

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("--------------------------------<Performance>-----------------------------------")
            For i = 1 To nservers
                Console.WriteLine("{0}) {1}", i, nameservers(i - 1))

            Next

            Console.WriteLine()
            Console.Write("On which server you want to apply this setting? ")
            selectperformance = Console.ReadLine

            If selectperformance >= 1 Then
                Console.WriteLine("I'm making the changes...")
                For i = 1 To nservers
                    checkyml = My.Computer.FileSystem.FileExists(path(i - 1) + "\pocketmine.yml")
                    checkyml2 = My.Computer.FileSystem.FileExists(path(i - 1) + "\pocketmine_OLD.yml")

                    If performance = "1" Then 'High
                        If checkyml Then
                            If checkyml2 Then
                                My.Computer.FileSystem.DeleteFile(path(i - 1) + "\pocketmine_OLD.yml")
                                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_HIGH.yml", path(i - 1) + "\pocketmine_HIGH.yml", overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine.yml", "pocketmine_OLD.yml")
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_HIGH.yml", "pocketmine.yml")

                            Else
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine.yml", "pocketmine_OLD.yml")
                                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_HIGH.yml", path(i - 1) + "\pocketmine_HIGH.yml", overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_HIGH.yml", "pocketmine.yml")

                            End If
                        Else
                            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_HIGH.yml", path(i - 1) + "\pocketmine_HIGH.yml", overwrite:=True)
                            My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_HIGH.yml", "pocketmine.yml")

                        End If
                    End If

                    If performance = "2" Then 'Medium
                        If checkyml Then
                            If checkyml2 Then
                                My.Computer.FileSystem.DeleteFile(path(i - 1) + "\pocketmine_OLD.yml")
                                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_MEDIUM.yml", path(i - 1) + "\pocketmine_MEDIUM.yml", overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine.yml", "pocketmine_OLD.yml")
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_MEDIUM.yml", "pocketmine.yml")

                            Else
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine.yml", "pocketmine_OLD.yml")
                                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_MEDIUM.yml", path(i - 1) + "\pocketmine_MEDIUM.yml", overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_MEDIUM.yml", "pocketmine.yml")

                            End If

                        Else
                            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_MEDIUM.yml", path(i - 1) + "\pocketmine_MEDIUM.yml", overwrite:=True)
                            My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_MEDIUM.yml", "pocketmine.yml")
                        End If
                    End If

                    If performance = "3" Then 'Low
                        If checkyml Then
                            If checkyml2 Then
                                My.Computer.FileSystem.DeleteFile(path(i - 1) + "\pocketmine_OLD.yml")
                                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_LOW.yml", path(i - 1) + "\pocketmine_LOW.yml", overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine.yml", "pocketmine_OLD.yml")
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_LOW.yml", "pocketmine.yml")

                            Else
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine.yml", "pocketmine_OLD.yml")
                                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_LOW.yml", path(i - 1) + "\pocketmine_LOW.yml", overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_LOW.yml", "pocketmine.yml")

                            End If

                        Else
                            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\pocketmine_LOW.yml", path(i - 1) + "\pocketmine_LOW.yml", overwrite:=True)
                            My.Computer.FileSystem.RenameFile(path(i - 1) + "\pocketmine_LOW.yml", "pocketmine.yml")

                        End If
                    End If
                Next
                'This isn't the best way, but for the moment I use it.

                If selectperformance = "1" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_1.pm")
                        performancestatus(0) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_1.pm", performancestatus(0), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_1.pm")
                            performancestatus(0) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_1.pm", performancestatus(0), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_1.pm")
                            performancestatus(0) = "Low"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_1.pm", performancestatus(0), True)
                        Next
                    End If
                End If

                If selectperformance = "2" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_2.pm")
                        performancestatus(1) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_2.pm", performancestatus(1), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_2.pm")
                            performancestatus(1) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_2.pm", performancestatus(1), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_2.pm")
                            performancestatus(1) = "Low"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_2.pm", performancestatus(1), True)
                        Next
                    End If
                End If

                If selectperformance = "3" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_3.pm")
                        performancestatus(2) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_3.pm", performancestatus(2), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_3.pm")
                            performancestatus(2) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_3.pm", performancestatus(2), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_3.pm")
                            performancestatus(2) = "Low"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_3.pm", performancestatus(2), True)
                        Next
                    End If
                End If

                If selectperformance = "4" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_4.pm")
                        performancestatus(3) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_4.pm", performancestatus(3), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_4.pm")
                            performancestatus(3) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_4.pm", performancestatus(3), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_4.pm")
                            performancestatus(3) = "Low"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_4.pm", performancestatus(3), True)
                        Next
                    End If
                End If

                If selectperformance = "5" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_5.pm")
                        performancestatus(4) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_5.pm", performancestatus(4), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_5.pm")
                            performancestatus(4) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_5.pm", performancestatus(4), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_5.pm")
                            performancestatus(4) = "Low"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_5.pm", performancestatus(4), True)
                        Next
                    End If
                End If

                If selectperformance = "6" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_6.pm")
                        performancestatus(5) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_6.pm", performancestatus(5), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_6.pm")
                            performancestatus(5) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_6.pm", performancestatus(5), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_6.pm")
                            performancestatus(5) = "Low"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_6.pm", performancestatus(5), True)
                        Next
                    End If
                End If

                If selectperformance = "7" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_7.pm")
                        performancestatus(6) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_7.pm", performancestatus(6), True)

                    End If

                    If performance = "2" Then 'Medium
                        For index = 1 To 10
                            My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_7.pm")
                            performancestatus(6) = "Medium"
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_7.pm", performancestatus(6), True)
                        Next
                    End If

                    If performance = "3" Then 'Low
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_7.pm")
                        performancestatus(6) = "Low"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_7.pm", performancestatus(6), True)

                    End If
                End If

                If selectperformance = "8" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_8.pm")
                        performancestatus(7) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_8.pm", performancestatus(7), True)

                    End If

                    If performance = "2" Then 'Medium
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_8.pm")
                        performancestatus(7) = "Medium"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_8.pm", performancestatus(7), True)

                    End If

                    If performance = "3" Then 'Low
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_8.pm")
                        performancestatus(7) = "Low"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_8.pm", performancestatus(7), True)

                    End If
                End If

                If selectperformance = "9" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_9.pm")
                        performancestatus(8) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_9.pm", performancestatus(8), True)

                    End If

                    If performance = "2" Then 'Medium
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_9.pm")
                        performancestatus(8) = "Medium"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_9.pm", performancestatus(8), True)

                    End If

                    If performance = "3" Then 'Low

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_9.pm")
                        performancestatus(8) = "Low"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_9.pm", performancestatus(8), True)

                    End If
                End If

                If selectperformance = "10" Then
                    If performance = "1" Then 'High
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_10.pm")
                        performancestatus(9) = "High"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_10.pm", performancestatus(9), True)

                    End If

                    If performance = "2" Then 'Medium
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_10.pm")
                        performancestatus(9) = "Medium"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_10.pm", performancestatus(9), True)

                    End If

                    If performance = "3" Then 'Low
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_10.pm")
                        performancestatus(9) = "Low"
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_10.pm", performancestatus(9), True)

                    End If
                End If

            End If

            Console.WriteLine()
            Console.WriteLine("Changes made! Press ENTER to return to menu.")
            Console.ReadLine()
        Else

            For i = 1 To nservers
                Do
                    Console.Write("Write the folder path of the {0} server, example 'C:\PocketMine-MP': ", numberservers(i - 1))
                    path(i - 1) = Console.ReadLine

                    If path(i - 1) = "" Then
                        Console.WriteLine("ERROR! Insert a valid path!")
                        Console.ReadLine()

                    End If
                Loop While path(i - 1) = ""

                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next
        End If
    End Sub

End Module
