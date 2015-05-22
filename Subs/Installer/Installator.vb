Module Installator
    Sub Installator(ByRef checkpath As Object(), ByRef nservers As Integer, ByRef nameservers As String(), ByRef installerstatus As String(), ByRef versionstatus As String(), ByRef path As String(), ByRef numberservers As String())
        Dim chooseserver, version, stable, beta, dev, soft, confirmphar As String

        Dim checkpocketmine, checkbeta, checkdev, checksoft As Object

        Dim checkphar1, checkphar2 As Object

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")

        checkbeta = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_BETA.phar")
        checkdev = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_DEV.phar")
        checksoft = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_SOFT.phar")

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("---------------------------<Install PocketMine-MP>------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("1- Version Stable (Setup File)")
        Console.WriteLine("2- Version Beta (Phar File)")
        Console.WriteLine("3- Version Dev-1553 (Phar File)")
        Console.WriteLine("4- Version Soft (Phar File)")
        Console.WriteLine("5- Back")
        Console.WriteLine()
        Console.WriteLine("What kind of version you want to install?")
        version = Console.ReadLine

        If version = "1" Then
            Console.WriteLine()
            Console.WriteLine("Current Versions:")
            Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
            Console.WriteLine()
            Console.Write("Which version do you want to install?: ")
            stable = Console.ReadLine

        ElseIf version = "2" Then
            Console.WriteLine()
            Console.WriteLine("Current Versions:")
            Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
            Console.WriteLine()
            Console.Write("Which version do you want to install?: ")
            beta = Console.ReadLine

        ElseIf version = "3" Then
            Console.WriteLine()
            Console.WriteLine("Current Versions:")
            Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1153]")
            Console.WriteLine()
            Console.Write("Which version do you want to install?: ")
            dev = Console.ReadLine

        ElseIf version = "4" Then
            Console.WriteLine()
            Console.WriteLine("Current Versions:")
            Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu")
            Console.WriteLine()
            Console.Write("Which version do you want to install?: ")
            soft = Console.ReadLine

        End If

        If stable = "1" Or beta = "1" Or dev = "1" Or soft = "1" Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("---------------------------<Install PocketMine-MP>------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            For i = 1 To nservers
                Console.WriteLine("{0}) {1} -> Version: {2} -> Status: {3}", i, nameservers(i - 1), versionstatus(i - 1), installerstatus(i - 1))

            Next
            Console.WriteLine()
            Console.Write("Which server you want to download the server? ")
            chooseserver = Console.ReadLine

            If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                If chooseserver And stable = "1" Then 'Stable
                    If checkpocketmine Then
                        Console.WriteLine()
                        Console.WriteLine("Starting installation...")
                        Process.Start("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")
                        Console.WriteLine("Installation complete")
                        Console.ReadLine()

                        'TODO: Change Singular "Installation Status"

                    Else
                        Console.WriteLine("Installer not found!")
                        Console.WriteLine("Please download the installer!")
                        Console.ReadLine()

                    End If
                End If

                '===============================================BETA===================================================
                If chooseserver = "1" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(0), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "2" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(1), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "3" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(2), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "4" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(3), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "5" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(4), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "6" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(5), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "7" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(6), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "8" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(7), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "9" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(8), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "10" And beta = "1" Then
                    If checkbeta Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(9), "BETA", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                '===============================================DEV===================================================
                If chooseserver = "1" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(0), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "2" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(1), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "3" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(2), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "4" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(3), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "5" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(4), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "6" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(5), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "7" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(6), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "8" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(7), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "9" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(8), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "10" And dev = "1" Then
                    If checkdev Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(9), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                '===============================================SOFT===================================================
                If chooseserver = "1" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(0), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "2" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(1), "DEV", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "3" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(2), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "4" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(3), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "5" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(4), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "6" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(5), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "7" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(6), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "8" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(7), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "9" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(8), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

                If chooseserver = "10" And soft = "1" Then
                    If checksoft Then
                        Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                        confirmphar = Console.ReadLine.ToUpper

                        If confirmphar = "Y" Then
                            ChangeInstallationFiles(path(9), "SOFT", checkphar1, checkphar2)

                        End If

                        'TODO: Change Singular "Download Status"

                    Else
                        Console.WriteLine("Phar file not found!")
                        Console.WriteLine("Please download the file.")
                        Console.ReadLine()

                    End If
                End If

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
        End If
    End Sub

    Sub ChangeInstallationFiles(ByRef path As String, ByRef priority As String, ByRef checkphar1 As Object, ByRef checkphar2 As Object)

        checkphar1 = My.Computer.FileSystem.FileExists(path + "\PocketMine-MP.phar")
        checkphar2 = My.Computer.FileSystem.FileExists(path + "\PocketMine-MP_OLD.phar")

        If checkphar1 Then
            If checkphar2 Then
                My.Computer.FileSystem.DeleteFile(path + "\PocketMine-MP_OLD.phar")
                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_" + priority + ".phar", path + "\PocketMine-MP_" + priority + ".phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP.phar", "PocketMine-MP_OLD.yml")
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP_" + priority + ".phar", "PocketMine-MP.phar")
            Else
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP.phar", "PocketMine-MP_OLD.yml")
                My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_" + priority + ".phar", path + "\PocketMine-MP_" + priority + ".phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP_" + priority + ".phar", "PocketMine-MP.phar")

            End If
        Else
            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_" + priority + ".phar", path + "\PocketMine-MP_" + priority + ".phar", overwrite:=True)
            My.Computer.FileSystem.RenameFile(path + "\PocketMine-MP_" + priority + ".phar", "PocketMine-MP.phar")

        End If
    End Sub

    'Sub ChangeInstallationStatus(ByRef selectperformance As String, ByRef performancestatus As String(), ByRef performance As String) 'TODO

    'End Sub
End Module
