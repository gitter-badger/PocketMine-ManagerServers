Module Installator
    Sub Installator(ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String())

        '#Variables "Install PocketMine-MP"
        Dim version, choosephar, pharpath, stable, beta, dev, soft, linkstable, linkbeta, linkdev, linksoft As String
        Dim checkpocketmine As Object


        linkstable = "http://sourceforge.net/projects/pocketmine/files/windows/PocketMine-MP_Installer_1.4.1_x86.exe/download"
        linkbeta = "https://github.com/PocketMine/PocketMine-MP/releases/download/1.4.1dev-936/PocketMine-MP_1.4.1dev-936.phar"
        linkdev = "http://jenkins.pocketmine.net/job/PocketMine-MP/1116/artifact/PocketMine-MP_1.5dev-1116_f718d06a_API-1.12.0.phar"
        linksoft = "http://jenkins.pocketmine.net/job/PocketMine-Soft/lastSuccessfulBuild/artifact/PocketMine-Soft_1.4.1-240_7ebde536_API-1.11.0.phar"

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\PocketMine-MP_Installer_1.4.1_x86.exe")

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("--------------------------<Install PocketMine-MP>-------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Version Stable (Setup File)")
            Console.WriteLine("2- Version Beta (Phar File)")
            Console.WriteLine("3- Version Dev (Phar File)")
            Console.WriteLine("4- Version Soft (Phar File)")
            Console.WriteLine("5- Back")
            Console.WriteLine()
            Console.Write("What kind of version you want to install? ")
            version = Console.ReadLine

            If version = "1" Then 'Stable Version" 
                Do
                    Console.WriteLine()
                    Console.WriteLine("Current Versions:")
                    Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                    Console.WriteLine()
                    Console.Write("Which version do you want to install?: ")
                    stable = Console.ReadLine

                Loop While stable <> "1"

                If stable = "1" Then
                    Console.WriteLine()
                    If checkpocketmine Then
                        Console.WriteLine("Starting the installation files")
                        Process.Start("C:\Program Files\PocketMine-ManagerServers\PocketMine-MP_Installer_1.4.1_x86.exe") 'Link to the installer
                        Console.WriteLine()
                        Console.WriteLine("Installation complete!")
                        Console.WriteLine("Press enter to return to the menu")
                        Console.ReadLine()
                    Else
                        Console.WriteLine("Installer not found.")
                        Console.WriteLine("Downloading Installer...")
                        Process.Start(linkstable) 'Download Installer

                        Console.WriteLine("Download Complete! Press enter to return to installation.")
                        Console.ReadLine()
                    End If

                ElseIf stable <> "1" Then
                    Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")

                End If
            End If

            If version = "2" Then 'Beta Version
                Do
                    Console.WriteLine()
                    Console.WriteLine("Current Versions:")
                    Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                    Console.WriteLine()
                    Console.Write("Which version do you want to install?: ")
                    beta = Console.ReadLine

                    If beta = "1" Then
                        Console.WriteLine("Downloading Phar File...")
                        Process.Start(linkbeta)
                        Console.WriteLine("Download Complete! Press enter to return to installation.")
                        Console.ReadLine()
                    ElseIf beta <> "1" Then
                        Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")
                    End If

                Loop While beta <> "1"
            End If

            If version = "3" Then 'Dev Version
                Do
                    Console.WriteLine()
                    Console.WriteLine("Current Versions:")
                    Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1116]")
                    Console.WriteLine()
                    Console.Write("Which version do you want to install?: ")
                    dev = Console.ReadLine

                    If dev = "1" Then
                        Console.WriteLine("Downloading Phar File...")
                        Process.Start(linkdev)
                        Console.WriteLine("Download Complete! Press enter to return to installation.")
                        Console.ReadLine()
                    ElseIf dev <> "1" Then
                        Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")
                    End If

                Loop While dev <> "1"
            End If

            If version = "4" Then 'Soft Version
                Do
                    Console.WriteLine()
                    Console.WriteLine("Current Versions:")
                    Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                    Console.WriteLine()
                    Console.Write("Which version do you want to install?: ")
                    soft = Console.ReadLine

                    If soft = "1" Then
                        Console.WriteLine("Downloading Phar File...")
                        Process.Start(linksoft)
                        Console.WriteLine("Download Complete! Press enter to return to installation.")
                        Console.ReadLine()
                    ElseIf soft <> "1" Then
                        Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")
                    End If

                Loop While soft <> "1"

            ElseIf version <> "1" Or version <> "2" Or version <> "3" Or version <> "4" Then
                Console.WriteLine("PLEASE SELECT AN AVAIABLE VERSION OF POCKETMINE!!")
                Console.ReadLine()

            End If

            If version = "2" Or version = "3" Or version = "4" Then
                Console.Write("Do you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                choosephar = Console.ReadLine.ToUpper

                If choosephar = "Y" Then

                    pharpath = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\pharpath.pm")

                    If pharpath And checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then

                        For i = 1 To nservers
                            If version = "2" Then
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\PocketMine-MP.phar", "PocketMine-MP_OLD.phar")
                                My.Computer.FileSystem.CopyFile(pharpath + "\PocketMine-MP_1.4.1dev-936.phar", path(i - 1), overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\PocketMine-MP_1.4.1dev-936.phar", "PocketMine-MP.phar")
                            End If

                            If version = "3" Then
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\PocketMine-MP.phar", "PocketMine-MP_OLD.phar")
                                My.Computer.FileSystem.CopyFile(pharpath + "\PocketMine-MP_1.5dev-1116_f718d06a_API-1.12.0.phar", path(i - 1), overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\PocketMine-MP_1.5dev-1116_f718d06a_API-1.12.0.phar", "PocketMine-MP.phar")
                            End If

                            If version = "4" Then
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\PocketMine-MP.phar", "PocketMine-MP_OLD.phar")
                                My.Computer.FileSystem.CopyFile(pharpath + "\PocketMine-Soft_1.4.1-240_7ebde536_API-1.11.0.phar", path(i - 1), overwrite:=True)
                                My.Computer.FileSystem.RenameFile(path(i - 1) + "\PocketMine-Soft_1.4.1-240_7ebde536_API-1.11.0.phar", "PocketMine-MP.phar")
                            End If

                        Next


                    Else
                        Do
                            Console.Write("Please, indicate the folder you downloaded the phar, example 'C:\Users\PC\Download': ")
                            pharpath = Console.ReadLine
                            Console.WriteLine()

                            If pharpath = "" Then
                                Console.ForegroundColor = ConsoleColor.DarkRed
                                Console.WriteLine("ERROR! Insert a valid path!")
                                Console.ReadLine()
                            End If
                        Loop While pharpath = ""

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\pharpath.pm", pharpath, True)

                        Console.Write("How many servers do you want to manage? <1/2/3/.../10>: ")
                        nservers = Console.ReadLine

                        For i = 1 To nservers
                            Do
                                Console.Write("Write the folder path of the {0} server, example 'C:\PocketMine-MP': ", numberservers(i - 1))
                                path(i - 1) = Console.ReadLine

                                If path(i - 1) = "" Then
                                    Console.ForegroundColor = ConsoleColor.DarkRed
                                    Console.WriteLine("ERROR! Insert a valid path!")
                                    Console.ReadLine()

                                End If
                            Loop While path(i - 1) = ""

                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

                        Next
                    End If
                End If
            End If
        Loop While version <> "5"

    End Sub
End Module
