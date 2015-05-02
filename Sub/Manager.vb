Module Manager

    Sub Manager(ByRef nservers As Integer, ByRef varmanager As String, ByRef performance As String, ByRef performancestatus As String(), ByRef confirmperfomance As String, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef checkperformance As Object(), ByRef selectperformance As String)
        Dim i As Integer

        Reading(path, nservers, nameservers)

        Do
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
            Console.WriteLine("1- Open [Server/Folder]")
            Console.WriteLine("2- Edit server performance.")
            Console.WriteLine("3- Clean unnecessary files.")
            Console.WriteLine("4- Back")
            Console.WriteLine()
            Console.Write("Select Option: ")
            varmanager = Console.ReadLine

            If varmanager = "1" Then 'Work
                Opener.Opener(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, performancestatus)

            End If

            If varmanager = "2" Then
                For i = 1 To 10
                    performancestatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm")

                Next
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("--------------------------------<Performance>-----------------------------------")
                Console.WriteLine("Your current performance are: ")
                For i = 1 To nservers
                    Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), performancestatus(i - 1))

                Next

                Console.WriteLine()
                Console.WriteLine("What features do you want to assign to your servers?")
                Console.WriteLine("1- High")
                Console.WriteLine("2- Medium")
                Console.WriteLine("3- Low")
                Console.WriteLine("4- Back")
                Console.WriteLine()
                Console.Write("Choose features: ")
                performance = Console.ReadLine

                If performance = "1" Then
                    Console.WriteLine()
                    Console.WriteLine("If you choose this option, you'll need to have a PC that supports it, so if you do not own it is strongly advised not to use it.")
                    Console.Write("Do you want to continue? <Y/N>: ")
                    confirmperfomance = Console.ReadLine.ToUpper

                    If confirmperfomance = "Y" Then
                        Performances.Performances(checkpath, checknameserver, performance, nameservers, nservers, selectperformance, performancestatus, path, numberservers)

                    End If
                End If

                If performance = "2" Then
                    Console.WriteLine()
                    Console.WriteLine("If you choose this option, you'll need a PC not too handsome, it is suitable for handling small servers.")
                    Console.Write("Do you want to continue? <Y/N>: ")
                    confirmperfomance = Console.ReadLine.ToUpper

                    If confirmperfomance = "Y" Then
                        Performances.Performances(checkpath, checknameserver, performance, nameservers, nservers, selectperformance, performancestatus, path, numberservers)

                    End If
                End If

                If performance = "3" Then
                    Console.WriteLine()
                    Console.WriteLine("If you choose this option, you'll need a PC not too handsome, it is suitable to manage servers with friends.")
                    Console.Write("Do you want to continue? <Y/N>: ")
                    confirmperfomance = Console.ReadLine.ToUpper

                    If confirmperfomance = "Y" Then
                        Performances.Performances(checkpath, checknameserver, performance, nameservers, nservers, selectperformance, performancestatus, path, numberservers)

                    End If
                End If
            End If

            If varmanager = "3" Then
                Console.WriteLine("Coming Soon")
                Console.ReadLine()

            End If
        Loop While varmanager <> "4"
    End Sub

End Module
