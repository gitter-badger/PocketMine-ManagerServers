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

                checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Installer_1.4.1_x86.exe")

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
                                Console.Write("Which operating system are you using? <Windows/Mac> ")
                                OS = Console.ReadLine.ToUpper
                            Loop While OS <> "WINDOWS" And OS <> "MAC"

                            If OS = "WINDOWS" Then
                                Console.WriteLine()
                                If checkpocketmine Then
                                    Console.WriteLine("Starting the installation files")
                                    Process.Start("C:\Program Files\PocketMine-ManagerServers\Installer_1.4.1_x86.exe") 'Link to the installer
                                    Console.WriteLine("Press enter to return to the menu")
                                    Console.ReadLine()
                                Else
                                    Console.WriteLine("Installer not found.")
                                    Console.WriteLine("Downloading Installer...")
                                    Process.Start(link) 'Download Installer

                                    Console.WriteLine("Download Complete! Press enter to return to installation.")
                                    Console.ReadLine()
                                End If

                            ElseIf OS = "MAC" Then
                                Console.WriteLine()
                                Console.WriteLine("MAC Installer")
                                Console.ReadLine()

                            ElseIf OS <> "WINDOWS" Or OS <> "MAC" Then
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
                Dim nservers, i As Integer
                Dim nameservers1, nameservers2, nameservers3, nameservers4, nameservers5, nameservers6, nameservers7, nameservers8, nameservers9, nameservers10, defaultservers As String
                Dim checknameserver As Object

                'Do
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                Console.Write("How many servers do you want to manage? <1/2/3/.../10> : ")
                nservers = Console.ReadLine

                If nservers <= 0 Then
                    Console.WriteLine("ERROR! You have to manage one or more server! (MAX TEN!!)")
                    Console.ReadLine()

                ElseIf nservers > 10 Then
                    Console.WriteLine("ERROR! You have exceeded the maximum number of servers available. Please reduce the amount!")
                    Console.ReadLine()

                ElseIf nservers >= 1 Then

                    defaultservers = "'Server Minecraft PE'"
                    nameservers1 = defaultservers 'By default

                    'checknameserver = My.Computer.FileSystem.FileExists("C:\Users\Matteo\Desktop\ServerName.pm")

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
                        Console.Write("1) Name of first server?: ", i)
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ", i)
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ", i)
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ", i)
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ", i)
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ", i)
                        nameservers6 = Console.ReadLine

                    ElseIf nservers = 7 Then
                        Console.Write("1) Name of first server?: ", i)
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ", i)
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ", i)
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ", i)
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ", i)
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ", i)
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ", i)
                        nameservers7 = Console.ReadLine

                    ElseIf nservers = 8 Then
                        Console.Write("1) Name of first server?: ", i)
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ", i)
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ", i)
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ", i)
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ", i)
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ", i)
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ", i)
                        nameservers7 = Console.ReadLine
                        Console.Write("8) Name of eighth server?: ", i)
                        nameservers8 = Console.ReadLine

                    ElseIf nservers = 9 Then
                        Console.Write("1) Name of first server?: ", i)
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ", i)
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ", i)
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ", i)
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ", i)
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ", i)
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ", i)
                        nameservers7 = Console.ReadLine
                        Console.Write("8) Name of eighth server?: ", i)
                        nameservers8 = Console.ReadLine
                        Console.Write("9) Name of ninth server?: ", i)
                        nameservers9 = Console.ReadLine

                    ElseIf nservers = 10 Then
                        Console.Write("1) Name of first server?: ", i)
                        nameservers1 = Console.ReadLine
                        Console.Write("2) Name of second server?: ", i)
                        nameservers2 = Console.ReadLine
                        Console.Write("3) Name of third server?: ", i)
                        nameservers3 = Console.ReadLine
                        Console.Write("4) Name of fourth server?: ", i)
                        nameservers4 = Console.ReadLine
                        Console.Write("5) Name of fifth server?: ", i)
                        nameservers5 = Console.ReadLine
                        Console.Write("6) Name of sixth server?: ", i)
                        nameservers6 = Console.ReadLine
                        Console.Write("7) Name of seventh server?: ", i)
                        nameservers7 = Console.ReadLine
                        Console.Write("8) Name of eighth server?: ", i)
                        nameservers8 = Console.ReadLine
                        Console.Write("9) Name of ninth server?: ", i)
                        nameservers9 = Console.ReadLine
                        Console.Write("10) Name of tenth server?: ", i)
                        nameservers10 = Console.ReadLine

                    End If

                    'If checknameserver Then
                    '    My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServerName.pm")
                    '    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName.pm", nameservers1, True)
                    'Else
                    '    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName.pm", nameservers1, True)
                    'End If

                    If nameservers1 = "" Or nameservers1 = defaultservers Then 'Save default name of servers [NOT COMPLETE]
                        nameservers1 = defaultservers
                        'My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServerName.pm", defaultservers, True)

                    ElseIf nameservers1 <> "" Then '[NOT COMPLETE]
                        defaultservers = nameservers1

                    End If

                End If
            End If
                'Loop While nservers <> 10


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
