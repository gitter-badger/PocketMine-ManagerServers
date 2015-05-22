Module Downloader
    Sub Downloader(ByRef nameservers As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef checknameserver As Object())

        Dim chooseserver, version, stable, beta, dev, soft, linkstable, linkbeta, linkdev, linksoft, downloadpath As String

        Dim checkpocketmine, checkdownloadpath, checkbeta, checkdev, checksoft As Object

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_Installer_1.4.1_x86.exe")
        checkdownloadpath = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\PathDownload.pm")

        checkbeta = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_BETA.phar")
        checkdev = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_DEV.phar")
        checksoft = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_SOFT.phar")

        linkstable = "http://sourceforge.net/projects/pocketmine/files/windows/PocketMine-MP_Installer_1.4.1_x86.exe/download"
        linkbeta = "https://github.com/PocketMine/PocketMine-MP/releases/download/1.4.1dev-936/PocketMine-MP_1.4.1dev-936.phar"
        linkdev = "http://jenkins.pocketmine.net/job/PocketMine-MP/lastSuccessfulBuild/artifact/PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar"
        linksoft = "http://jenkins.pocketmine.net/job/PocketMine-Soft/lastSuccessfulBuild/artifact/PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar"

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("---------------------------<Download PocketMine-MP>-----------------------------")
            Console.ForegroundColor = ConsoleColor.White
            For i = 1 To nservers
                Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), downloadstatus(i - 1))

            Next
            Console.WriteLine()
            Console.Write("Which server you want to download the server? ")
            chooseserver = Console.ReadLine

            If chooseserver Then
                Console.WriteLine()
                Console.WriteLine("1- Version Stable (Setup File)")
                Console.WriteLine("2- Version Beta (Phar File)")
                Console.WriteLine("3- Version Dev-1553 (Phar File)")
                Console.WriteLine("4- Version Soft (Phar File)")
                Console.WriteLine("5- Back")
                Console.WriteLine()
                Console.Write("What kind of version you want to install?")
                version = Console.ReadLine

                If version = "1" Then
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        stable = Console.ReadLine

                        If stable = "1" Then 'Stable
                            If checkpocketmine Then
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this installer!")
                                Console.ReadLine()

                            Else
                                Console.WriteLine("Downloading Installer...!")
                                Process.Start(linkstable)
                                Console.WriteLine("Installer downloaded! Press ENTER to continue.")
                                Console.ReadLine()

                                'TODO: Change Singular "Download Status"

                            End If
                        End If
                    Loop While stable <> "1"
                End If

                If version = "2" Then 'Beta
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        beta = Console.ReadLine

                        If beta = "1" Then
                            If checkbeta Then
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this file!")
                                Console.ReadLine()

                            Else
                                Console.WriteLine("Downloading Phar File...!")
                                Process.Start(linkbeta)
                                Console.WriteLine("Phar file downloaded! Press ENTER to continue.")
                                Console.ReadLine()

                                'TODO: Change Singular "Download Status"

                            End If
                        End If
                    Loop While beta <> "1"
                End If

                If version = "3" Then 'Dev
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1153]")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        dev = Console.ReadLine

                        If dev = "1" Then
                            If checkdev Then
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this file!")
                                Console.ReadLine()

                            Else
                                Console.WriteLine("Downloading Phar File...!")
                                Process.Start(linkdev)
                                Console.WriteLine("Phar file downloaded! Press ENTER to continue.")
                                Console.ReadLine()

                                'TODO: Change Singular "Download Status"

                            End If
                        End If
                    Loop While dev <> "1"
                End If

                If version = "4" Then 'Soft
                    Do
                        Console.WriteLine()
                        Console.WriteLine("Current Versions:")
                        Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu")
                        Console.WriteLine()
                        Console.Write("Which version do you want to install?: ")
                        soft = Console.ReadLine

                        If soft = "1" Then
                            If checksoft Then
                                Console.WriteLine()
                                Console.WriteLine("You have already downloaded this file!")
                                Console.ReadLine()

                            Else
                                Console.WriteLine("Downloading Phar File...!")
                                Process.Start(linksoft)
                                Console.WriteLine("Phar file downloaded! Press ENTER to continue.")
                                Console.ReadLine()

                                'TODO: Change Singular "Download Status"

                            End If
                        End If
                    Loop While soft <> "1"
                End If

                If checkdownloadpath = True Or checkbeta = False Or checkpocketmine = False Or checkdev = False Or checksoft = False Then
                    downloadpath = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\PathDownload.pm")

                    MoveDownloadedFile(checkpocketmine, downloadpath, checkbeta, checkdev, checksoft)

                Else
                    Do
                        Console.Write("Please indicate what the link to the folder where you downloaded the installer , example 'C:\PocketMine-MP': ")
                        downloadpath = Console.ReadLine

                    Loop While downloadpath = ""

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\PathDownload.pm", downloadpath, True)

                    MoveDownloadedFile(checkpocketmine, downloadpath, checkbeta, checkdev, checksoft)

                End If
            End If
        Loop While chooseserver <> ""
    End Sub

    Sub MoveDownloadedFile(ByRef checkpocketmine As Object, ByRef downloadpath As String, ByRef checkbeta As Object, ByRef checkdev As Object, ByRef checksoft As Object)
        If checkbeta Or checkdev Or checksoft Then
            Console.WriteLine("You have already downloaded this file!")
            Console.ReadLine()

        ElseIf checkpocketmine Then
            Console.WriteLine("You have already downloaded this installer!")
            Console.ReadLine()

        Else
            If checkbeta Then
                My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-MP_1.4.1dev-936.phar", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.4.1dev-936.phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.4.1dev-936.phar", "PocketMine-MP_BETA.phar")

            ElseIf checkdev Then
                My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-MP_1.5dev-1153_8d4abe2f_API-1.12.0.phar", "PocketMine-MP_DEV.phar")

            ElseIf checksoft Then
                My.Computer.FileSystem.CopyFile(downloadpath + "\PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar", "C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar", overwrite:=True)
                My.Computer.FileSystem.RenameFile("C:\Program Files\PocketMine-ManagerServers\Utils\PocketMine-Soft_1.5dev-243_3a09c50b_API-1.12.0.phar", "PocketMine-MP_SOFT.phar")

            End If
        End If
    End Sub
End Module
