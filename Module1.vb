Module Module1

    Sub Main()

        '#Variables
        Dim menù, quit As String

        quit = "N"

        While quit = "N"
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("-------------------------------<Main Menù>--------------------------------------")
            Console.WriteLine("1- Install PocketMine-MP")
            Console.WriteLine("2- Manage Servers")
            Console.WriteLine("3- Maintenance Servers")
            Console.WriteLine("4- Programm Options")
            Console.WriteLine("5- Exit")
            Console.WriteLine()
            Console.Write("What would you like to do?: ")
            menù = Console.ReadLine

            If menù = "1" Then
                '#Variables
                Dim version, stable, beta, dev, soft, OS, link As String
                Dim checkpocketmine As Object

                link = "http://sourceforge.net/projects/pocketmine/files/windows/PocketMine-MP_Installer_1.4.1_x86.exe/download"

                checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\PocketMine-MP_Installer_1.4.1_x86.exe")

                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.WriteLine("---------------------------<Install PocketMine-MP>------------------------------")
                    Console.Write("What kind of version you want to install? <Stable/Beta/Dev/Soft>: ")
                    version = Console.ReadLine.ToUpper

                    If version = "STABLE" Then 'Stable Version
                        Do
                            Console.WriteLine()
                            Console.WriteLine("Current Versions:")
                            Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                            Console.WriteLine()
                            Console.Write("Which version do you want to install?: ")
                            stable = Console.ReadLine

                        Loop While stable <> "1"

                        If stable = "1" Then
                            Do
                                Console.WriteLine()
                                Console.Write("Which operating system are you using? <Windows/MacOS> ")
                                OS = Console.ReadLine.ToUpper
                            Loop While OS <> "WINDOWS" And OS <> "MACOS"

                            If OS = "WINDOWS" Then '[WORK]
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
                                    Process.Start(link) 'Download Installer

                                    Console.WriteLine("Download Complete! Press enter to return to installation.")
                                    Console.ReadLine()
                                End If

                            ElseIf OS = "MACOS" Then '[Don't Work]
                                Console.WriteLine()
                                Console.WriteLine("MAC Installer")
                                Console.ReadLine()

                            ElseIf OS <> "WINDOWS" Or OS <> "MACOS" Then
                                Console.WriteLine("PLEASE, SELECT AN AVAIABLE OPERATIVE SYSTEM!!")
                            End If

                        ElseIf stable <> "1" Then
                            Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")

                        End If

                    ElseIf version = "BETA" Then 'Beta Version
                        Do
                            Console.WriteLine()
                            Console.WriteLine("Current Versions:")
                            Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                            Console.WriteLine()
                            Console.Write("Which version do you want to install?: ")
                            beta = Console.ReadLine

                            If beta = "1" Then
                                Console.WriteLine()
                                Console.WriteLine("Coming Soon")
                                Console.ReadLine()
                            ElseIf beta <> "1" Then
                                Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")
                            End If

                        Loop While beta <> "1"

                    ElseIf version = "DEV" Then 'Dev Version
                        Do
                            Console.WriteLine()
                            Console.WriteLine("Current Versions:")
                            Console.WriteLine("1) 1.5 API 1.12.0 Kappatsu-Fugu [#Dev Build 1066]")
                            Console.WriteLine()
                            Console.Write("Which version do you want to install?: ")
                            dev = Console.ReadLine

                            If dev = "1" Then
                                Console.WriteLine()
                                Console.WriteLine("Coming Soon")
                                Console.ReadLine()
                            ElseIf dev <> "1" Then
                                Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")
                            End If

                        Loop While dev <> "1"

                    ElseIf version = "SOFT" Then 'Soft Version
                        Do
                            Console.WriteLine()
                            Console.WriteLine("Current Versions:")
                            Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                            Console.WriteLine()
                            Console.Write("Which version do you want to install?: ")
                            soft = Console.ReadLine

                            If soft = "1" Then
                                Console.WriteLine()
                                Console.WriteLine("Coming Soon")
                                Console.ReadLine()
                            ElseIf soft <> "1" Then
                                Console.WriteLine("PLEASE, SELECT AN AVAIABLE VERSION!!")
                            End If

                        Loop While soft <> "1"

                    ElseIf version <> "STABLE" Or version <> "BETA" Or version <> "DEV" Or version <> "SOFT" Then
                        Console.WriteLine("PLEASE SELECT AN AVAIABLE VERSION OF POCKETMINE!!")
                        Console.ReadLine()
                    End If
                Loop While version <> "STABLE" And version <> "BETA" And version <> "DEV" And version <> "SOFT"
            End If

            If menù = "2" Then 'Manage Servers [NOT COMPLETE]
                '#Variables
                Dim nservers As Integer
                Dim errorservers As String
                Dim nameservers1, nameservers2, nameservers3, nameservers4, nameservers5, nameservers6, nameservers7, nameservers8, nameservers9, nameservers10, defaultservers As String
                Dim checknameserver1, checknameserver2, checknameserver3, checknameserver4, checknameserver5, checknameserver6, checknameserver7, checknameserver8, checknameserver9, checknameserver10 As Object

                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                    Console.Write("How many servers do you want to manage? <1/2/3/.../10> : ")
                    errorservers = Console.ReadLine

                    If errorservers <> "10" Then 'Converting Integer to String

                        If nservers > 10 Then
                            Console.WriteLine("ERROR! You have exceeded the maximum number of servers available. Please reduce the amount!")
                            Console.ReadLine()

                        ElseIf nservers <= 10 Then
                            Console.WriteLine("ERROR! You have to manage one or more server! (MAX TEN!!)")
                            Console.ReadLine()

                        End If
                    End If

                Loop While errorservers <> "10"

                If nservers >= 1 Then

                    defaultservers = "'Server Minecraft PE'"
                    nameservers1 = defaultservers 'By default
                    nameservers2 = defaultservers 'By default
                    nameservers3 = defaultservers 'By default
                    nameservers4 = defaultservers 'By default
                    nameservers5 = defaultservers 'By default
                    nameservers6 = defaultservers 'By default
                    nameservers7 = defaultservers 'By default
                    nameservers8 = defaultservers 'By default
                    nameservers9 = defaultservers 'By default
                    nameservers10 = defaultservers 'By default


                    checknameserver1 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_1.pm")
                    checknameserver2 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_2.pm")
                    checknameserver3 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_3.pm")
                    checknameserver4 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_4.pm")
                    checknameserver5 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_5.pm")
                    checknameserver6 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_6.pm")
                    checknameserver7 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_7.pm")
                    checknameserver8 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_8.pm")
                    checknameserver9 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_9.pm")
                    checknameserver10 = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServerName_10.pm")

                    Console.WriteLine()
                    Console.WriteLine("If you do not enter a name for your server , by default it will be {0}", defaultservers)

                    If nservers = 1 Then 'This isn't the best way but for the moment I use this. 
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine

                    ElseIf nservers = 2 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine

                    ElseIf nservers = 3 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine

                    ElseIf nservers = 4 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine

                    ElseIf nservers = 5 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ")
                        nameservers5 = Console.ReadLine

                    ElseIf nservers = 6 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ")
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ")
                        nameservers6 = Console.ReadLine

                    ElseIf nservers = 7 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ")
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ")
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ")
                        nameservers7 = Console.ReadLine

                    ElseIf nservers = 8 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ")
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ")
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ")
                        nameservers7 = Console.ReadLine
                        Console.Write("8) Name of eighth server?: ")
                        nameservers8 = Console.ReadLine

                    ElseIf nservers = 9 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ")
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ")
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ")
                        nameservers7 = Console.ReadLine
                        Console.Write("8) Name of eighth server?: ")
                        nameservers8 = Console.ReadLine
                        Console.Write("9) Name of ninth server?: ")
                        nameservers9 = Console.ReadLine

                    ElseIf nservers = 10 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ")
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ")
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ")
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ")
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ")
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ")
                        nameservers7 = Console.ReadLine
                        Console.Write("8) Name of eighth server?: ")
                        nameservers8 = Console.ReadLine
                        Console.Write("9) Name of ninth server?: ")
                        nameservers9 = Console.ReadLine
                        Console.Write("10) Name of tenth server?: ")
                        nameservers10 = Console.ReadLine

                    End If

                    If checknameserver1 Or checknameserver2 Or checknameserver3 Or checknameserver4 Or checknameserver5 Or checknameserver6 Or checknameserver7 Or checknameserver8 Or checknameserver9 Or checknameserver10 Then
                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_1.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_1.pm", nameservers1, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_2.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_2.pm", nameservers2, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_3.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_3.pm", nameservers3, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_4.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_4.pm", nameservers4, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_5.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_6.pm", nameservers5, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_6.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_6.pm", nameservers6, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_7.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_7.pm", nameservers7, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_8.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_8.pm", nameservers8, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_9.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_9.pm", nameservers9, True)

                        My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName_10.pm")
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_10.pm", nameservers10, True)
                    Else
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_1.pm", nameservers1, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_2.pm", nameservers2, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_3.pm", nameservers3, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_4.pm", nameservers4, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_5.pm", nameservers5, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_6.pm", nameservers6, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_7.pm", nameservers7, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_8.pm", nameservers8, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_9.pm", nameservers9, True)

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName_10.pm", nameservers10, True)

                    End If

                End If

            End If



            If menù = "3" Then
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("Coming Soon")
                Console.ReadLine()
            End If

            If menù = "4" Then
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("Coming Soon")
                Console.ReadLine()
            End If

            If menù = "5" Then
                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.Write("Are you sure you want to quit? <Y/N>: ")
                    quit = Console.ReadLine.ToUpper
                Loop While quit <> "Y" And quit <> "N"

                If quit = "Y" Then
                    Console.WriteLine("See you soon!")
                    Console.ReadLine()
                    End
                End If
            End If

        End While

    End Sub

End Module
