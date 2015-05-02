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
