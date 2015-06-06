Module Resetter
    Sub Resetter(ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef checknservers As Object, ByRef checkfolderinstallation As Object, ByRef dirpath As Object, ByRef dirdata As Object, ByRef dirservername As Object, ByRef dirperformance As Object, ByRef dirinstallations As Object, ByRef dirlanguages As Object, ByRef direrrors As Object)

        Dim choosereset, reset As String

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("-------------------------------<Reset Program>----------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Reset data of servers (Only Programm)")
            Console.WriteLine("2- Reset data of servers (Only your specified server)")
            Console.WriteLine("3- Reset all data/folders of programm")
            Console.WriteLine("4- Back")
            Console.WriteLine()
            Console.Write("Choose what do you want to reset: ")
            choosereset = Console.ReadLine

            If choosereset = "1" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("Are you sure to want to reset data of servers (Only Program)? <Y/N>: ")
                    Console.ForegroundColor = ConsoleColor.White
                    reset = Console.ReadLine.ToUpper
                Loop While reset <> "Y" And reset <> "N"

                If reset = "Y" Then
                    If dirpath And dirservername And dirdata And dirperformance And dirinstallations And dirlanguages And direrrors Then
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Path", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\ServersName", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Data", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Performance", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Installations", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Languages", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Errors", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Console.WriteLine("Closing program...")
                        End
                    Else
                        Console.WriteLine("There are no files to be deleted!")
                        Console.ReadLine()

                    End If
                End If

            ElseIf choosereset = "2" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("WARNING! Are you sure to want to reset data of servers (Only your specified server)? <Y/N>: ")
                    Console.ForegroundColor = ConsoleColor.White
                    reset = Console.ReadLine.ToUpper

                    If reset = "Y" Then
                        If checkpath(0) Or checkpath(1) Or checkpath(2) Or checkpath(3) Or checkpath(4) Or checkpath(5) Or checkpath(6) Or checkpath(7) Or checkpath(8) Or checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                            If checknservers Then

                                nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

                                For i = 1 To nservers
                                    My.Computer.FileSystem.DeleteDirectory(path(i - 1), path(i - 1), True)

                                Next

                                Console.WriteLine("Closing Program...")
                                End

                            Else
                                Console.WriteLine("Please, before configuring the server(s).")
                                Console.ReadLine()

                            End If
                        Else
                            Console.WriteLine("There is no path to be deleted!")
                            Console.ReadLine()

                        End If
                    End If

                Loop While reset <> "Y" And reset <> "N"

            ElseIf choosereset = "3" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("Are you sure to want to reset all data/folders of program (It delete folders of program)? <Y/N>: ")
                    Console.ForegroundColor = ConsoleColor.White
                    reset = Console.ReadLine.ToUpper

                    If reset = "Y" Then
                        If checkfolderinstallation Then
                            My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers", FileIO.DeleteDirectoryOption.DeleteAllContents)
                            Console.WriteLine("Closing program...")
                            End
                        Else
                            Console.WriteLine("There are no files to be deleted!")
                            Console.ReadLine()

                        End If

                    End If
                Loop While reset <> "Y" And reset <> "N"

            End If
        Loop While choosereset <> "4"
    End Sub
End Module
