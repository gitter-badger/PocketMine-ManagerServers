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
            Console.WriteLine("2- Manage Server")
            Console.WriteLine("3- Maintenance Server")
            Console.WriteLine("4- Programm Options")
            Console.WriteLine("5- Exit")
            Console.WriteLine()
            Console.Write("What would you like to do?: ")
            menù = Console.ReadLine

            If menù = "1" Then

                Dim version, stable, beta, dev, OS As String

                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.Write("What kind of version you want to install? <Stable/Beta/Dev>: ")
                    version = Console.ReadLine.ToUpper
                Loop While version <> "STABLE" And version <> "BETA" And version <> "DEV"

                If version = "STABLE" Then 'Stable Version
                    Console.WriteLine()
                    Console.WriteLine("Current Versions:")
                    Console.WriteLine("1) 1.4.1 API 1.11.0 Zekkou-Cake")
                    Console.WriteLine()
                    Console.Write("Which version do you want to install?: ")
                    stable = Console.ReadLine

                    If stable = "1" Then
                        Console.WriteLine()
                        Console.Write("Which operating system are you using? <Windows/Mac> ")
                        OS = Console.ReadLine.ToUpper

                        If OS = "WINDOWS" Then
                            Console.WriteLine()
                            Console.WriteLine("Starting the installation files")
                            'Process.Start() 'Link to the installer
                            Console.WriteLine("Press enter to return to the menu")
                            Console.ReadLine()
                        ElseIf OS = "MAC" Then
                            Console.WriteLine()
                            Console.WriteLine("MAC Installer")
                            Console.ReadLine()
                        End If
                    End If

                End If

                If version = "BETA" Then 'Beta Version
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
                    End If

                End If

                If version = "DEV" Then 'Dev Version
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
                    End If
                End If
            End If

            If menù = "2" Then
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("Coming Soon")
                Console.ReadLine()
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
