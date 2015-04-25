Module Module1

    Sub Main()

        '#Variables "Main Menu"
        Dim menù, quit As String
        Dim checkfolderinstallation As Object

        '#Variables "Install PocketMine-MP
        Dim version, stable, beta, dev, soft, link As String
        Dim checkpocketmine As Object


        '#Variables "Manage Servers"
        Dim nservers As String
        Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}
        Dim checknservers As Object

        Dim defaultservers As String

        Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        Dim opener, path As String
        Dim checkpath As Object

        '#Variables "Program Options"
        Dim options, choosereset, reset As String


        '#Variables Mechanical
        Dim dirservername, dirpath, dirdata As Object

        'STARTUP

        defaultservers = "'Server Minecraft PE'"

        checkfolderinstallation = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers")
        dirpath = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Path")
        dirservername = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\ServersName")
        dirdata = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Data")

        checkpath = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Path\path.pm")

        If dirpath And dirservername And checkfolderinstallation And checkpath And dirdata Then
            quit = "N"

        Else
            path = ""
            Console.WriteLine("Preparing the first start ...")
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers") ' Create Installation Folder
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\ServersName") 'Create Folder Server Name
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Path") 'Create Folder Path
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Data") 'Create Folder Data
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path.pm", path, True) 'Create Initial path file
            Console.WriteLine("Complete! Press ENTER to continue.")
            Console.ReadLine()
            quit = "N"

        End If

        While quit = "N"
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("-------------------------------<Main Menù>--------------------------------------")
            Console.WriteLine("1- Install PocketMine-MP")
            Console.WriteLine("2- Manage Servers")
            Console.WriteLine("3- Maintenance Servers")
            Console.WriteLine("4- Programm Options")
            Console.WriteLine("5- Credits")
            Console.WriteLine("6- Exit")
            Console.WriteLine()
            Console.Write("What would you like to do?: ")
            menù = Console.ReadLine

            If menù = "1" Then

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

            If menù = "2" Then 'Manage Servers [NOT COMPLETE THEREFORE DOESN'T WORK]

                checkpath = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Path\path.pm")
                checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

                Checking(checknameserver)
                If checknservers Then
                    nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")
                    Convert.ToInt16(nservers)
                Else
                    Do
                        Console.Clear()
                        Console.WriteLine("========================<PocketMine Manager Servers>============================")
                        Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                        Console.Write("How many servers do you want to manage? <1/2/3/.../10> : ")
                        nservers = Console.ReadLine

                        If nservers = "" Then
                            Console.WriteLine("ERROR! Please select a number of servers.")
                            Console.ReadLine()
                        End If

                    Loop While nservers = ""

                    My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm", nservers, True)

                    If nservers = "1" Or nservers = "2" Or nservers = "3" Or nservers = "4" Or nservers = "5" Or nservers = "6" Or nservers = "7" Or nservers = "8" Or nservers = "9" Or nservers = "10" Then
                        Convert.ToInt16(nservers)
                    Else
                        Convert.ToString(nservers)
                    End If
                End If

                If nservers > 10 Then
                    Console.WriteLine("ERROR! You have exceeded the maximum number of servers available. Please reduce the amount!")
                    Console.ReadLine()

                ElseIf nservers <= 0 Then
                    Console.WriteLine("ERROR! You have to manage one or more server! (MAX TEN!!)")
                    Console.ReadLine()

                ElseIf nservers >= 1 Then
                    Console.WriteLine()
                    Console.WriteLine("If you do not enter a name for your server , by default it will be {0}", defaultservers)

                    If nservers = 1 And checknameserver(0) Then
                        nameservers(0) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_1.pm")
                        path = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Path\path.pm")

                        Do
                            Console.Clear()
                            Console.WriteLine("========================<PocketMine Manager Servers>============================")
                            Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                            Console.WriteLine("First server: {0}", nameservers(0))
                            Console.WriteLine()
                            Console.Write("What do you want to do? <Open [Server/Folder]>: ")
                            opener = Console.ReadLine.ToUpper
                        Loop While opener <> "SERVER" And opener <> "FOLDER"

                        If checkpath And path <> "" And opener = "SERVER" Or opener = "FOLDER" Then
                            Console.WriteLine()
                            Console.WriteLine("Reading your file...")
                            Console.WriteLine("File succefully read!")
                            Console.ReadLine()

                            Console.WriteLine()
                            Console.WriteLine("Opening your server...")

                            If opener = "SERVER" Then
                                Process.Start(path + "\start.cmd")
                            End If

                            If opener = "FOLDER" Then
                                Process.Start(path)
                            End If
                        Else

                            Do
                                Console.Write("Write the folder path of the server, example 'C:\PocketMine-MP': ")
                                path = Console.ReadLine

                                If path = "" Then
                                    Console.WriteLine("ERROR! Please write a correct path of the server!")
                                End If
                            Loop While path = ""

                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path.pm", path, True)

                        End If

                        If opener <> "SERVER" Or opener <> "FOLDER" Then
                            Console.WriteLine("Please, select a correct option")
                            Console.ReadLine()
                        End If

                    ElseIf nservers = 1 Then
                        Console.Write("1) Name of first server?: ")
                        nameservers(0) = Console.ReadLine

                        If nameservers(0) = "" Then
                            nameservers(0) = defaultservers
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_1.pm", nameservers(0), True)
                        Else
                            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_1.pm", nameservers(0), True)
                            nameservers(0) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_1.pm")

                        End If
                    End If

                    If nservers = 2 And checknameserver(0) And checknameserver(1) Then
                        Reading(nameservers, nservers)
                        Do

                            Console.Clear()
                            Console.WriteLine("========================<PocketMine Manager Servers>============================")
                            Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                            Console.WriteLine("First server: {0}", nameservers(0))
                            Console.WriteLine("Second server: {0}", nameservers(1))
                            Console.WriteLine()
                            Console.Write("What do you want to do? <Open [Server/Folder]>: ")
                            opener = Console.ReadLine.ToUpper

                        Loop While opener <> "SERVER" And opener <> "FOLDER"

                    ElseIf nservers = 2 Then
                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 3 And checknameserver(0) And checknameserver(1) And checknameserver(2) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 3 Then

                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 4 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 4 Then
                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 5 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 5 Then
                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 6 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 6 Then

                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 7 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 7 Then

                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 8 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 8 Then

                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 9 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 9 Then

                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If

                    If nservers = 10 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) And checknameserver(9) Then
                        Reading(nameservers, nservers)

                    ElseIf nservers = 10 Then

                        Selection(nservers, nameservers, numberservers)

                        Writing(nameservers, nservers)

                    End If
                End If
            End If

            If menù = "3" Then
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("Coming Soon")
                Console.ReadLine()
            End If

            If menù = "4" Then 'Program Options
                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.WriteLine("------------------------------<Program Options>---------------------------------")
                    Console.WriteLine("1- Language [COMING SOON]")
                    Console.WriteLine("2- Reset Program")
                    Console.WriteLine("3- Back")
                    Console.WriteLine()
                    Console.Write("Choose the option: ")
                    options = Console.ReadLine

                    If options = "1" Then
                        Console.WriteLine("Coming Soon")
                        Console.ReadLine()

                    ElseIf options = "2" Then
                        Do
                            Console.Clear()
                            Console.WriteLine("========================<PocketMine Manager Servers>============================")
                            Console.WriteLine("-------------------------------<Reset Program>----------------------------------")
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
                                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                                    Console.Write("Are you sure to want to reset data of servers (Only Program)? <Y/N>: ")
                                    reset = Console.ReadLine.ToUpper
                                Loop While reset <> "Y" And reset <> "N"

                                If reset = "Y" Then
                                    If dirpath And dirservername And dirdata Then
                                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Path", FileIO.DeleteDirectoryOption.DeleteAllContents)
                                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\ServersName", FileIO.DeleteDirectoryOption.DeleteAllContents)
                                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Data", FileIO.DeleteDirectoryOption.DeleteAllContents)
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
                                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                                    Console.Write("Are you sure to want to reset data of servers (Only your specified server)? <Y/N>: ")
                                    reset = Console.ReadLine.ToUpper

                                    If reset = "Y" Then
                                        Console.WriteLine("Coming Soon")
                                        Console.ReadLine()
                                    End If

                                Loop While reset <> "Y" And reset <> "N"

                            ElseIf choosereset = "3" Then
                                Do
                                    Console.Clear()
                                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                                    Console.Write("Are you sure to want to reset all data/folders of program (It delete folders of program)? <Y/N>: ")
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
                    End If

                Loop While options <> "3"
            End If

            If menù = "5" Then
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.WriteLine("Coming Soon")
                Console.ReadLine()
            End If

            If menù = "6" Then
                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.WriteLine("----------------------------------<Exit>----------------------------------------")
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

    Sub Reading(ByRef nameservers As String(), ByRef nservers As Integer)
        For i = 1 To nservers
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
        Next
    End Sub

    Sub Writing(ByRef nameservers As String(), ByRef nservers As Integer)
        For i = 1 To nservers
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm", nameservers(i - 1), True)
        Next
    End Sub

    Sub Checking(ByRef checknameserver As Object())
        For i = 1 To 10
            checknameserver(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
        Next
    End Sub

    Sub Selection(ByVal nservers As Integer, ByRef nameservers As String(), ByVal numberservers As String())
        For i = 1 To nservers
            Console.Write("{0}) Name of {1} server?: ", i, numberservers(i - 1))
            nameservers(i - 1) = Console.ReadLine
        Next
    End Sub

End Module
