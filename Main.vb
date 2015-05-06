Module Main

    Sub Main()
        '#Variables "Main Menu"
        Dim menù, quit As String
        Dim checkfolderinstallation, checklicense As Object

        '#Variables "Manage Servers"
        Dim nservers As Integer
        Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}

        Dim defaultservers As String

        Dim checknservers As Object

        Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkpath As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        '-------------------------------------------------------------------------------------------------------------------------------------------------
        Dim performancestatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkperformance As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        '#Variables Mechanical
        Dim dirservername, dirpath, dirdata, dirutils, dirperformance As Object

        'STARTUP
        Loader.Loader(checkperformance, checknameserver, nameservers, performancestatus, nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, _
                      dirperformance, dirutils, checklicense)
        quit = "N"

        While quit = "N"
            Console.ForegroundColor = ConsoleColor.Green
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("-------------------------------<Main Menù>--------------------------------------")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("                                                           Version: 1.0 #BUILD 3")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Install PocketMine-MP")
            Console.WriteLine("2- Manage Servers")
            Console.WriteLine("3- Programm Options")
            Console.WriteLine("4- Informations")
            Console.WriteLine("5- Exit")
            Console.WriteLine()
            Console.Write("What would you like to do?: ")
            menù = Console.ReadLine

            If menù = "1" Then
                Installator.Installator(nservers, checkpath, path, numberservers)

            End If

            If menù = "2" Then 'Manage Servers
                LoaderManager.LoaderManager(defaultservers)

            End If

            If menù = "3" Then 'Program Options
                Settings.Settings(nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, dirperformance)

            End If

            If menù = "4" Then
                Informations.Informations(checklicense)

            End If

            If menù = "5" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkGreen
                    Console.WriteLine("----------------------------------<Exit>----------------------------------------")
                    Console.ForegroundColor = ConsoleColor.White
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

    Sub Writing(ByRef nameservers As String(), ByRef nservers As Integer, ByRef path As String())
        For i = 1 To nservers
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm", nameservers(i - 1), True)

        Next
    End Sub

    Sub Reading(ByRef path As Object(), ByRef nservers As Integer, ByRef nameservers As String())
        For i = 1 To nservers
            path(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")

        Next

    End Sub

    Sub Checking(ByRef checknameserver As Object(), ByRef checkpath As Object())
        For i = 1 To 10
            checknameserver(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
            checkpath(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")

        Next
    End Sub

    Sub Selection(ByRef nservers As Integer, ByRef nameservers As String(), ByRef numberservers As String(), ByRef defaultservers As String)
        For i = 1 To nservers
            defaultservers = ("Server Minecraft PE_" + Convert.ToString(i))

            Console.Write("{0}) Name of {1} server?: ", i, numberservers(i - 1))
            nameservers(i - 1) = Console.ReadLine

            If nameservers(i - 1) = "" Then
                nameservers(i - 1) = defaultservers
            End If
        Next
    End Sub
End Module