Module Module1

    Sub Main()

        '#Variables "Main Menu"
        Dim menù, quit As String
        Dim checkfolderinstallation, checklicense As Object

        '#Variables "Install PocketMine-MP
        Dim version, stable, beta, dev, soft, link As String
        Dim checkpocketmine As Object

        '#Variables "Manage Servers"
        Dim nservers As Integer
        Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}
        Dim numberservers_2 As String() = New String() {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"}

        Dim checknservers As Object

        Dim defaultservers As String

        Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        Dim opener As String
        Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkpath As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        '#Variables "Program Options"
        Dim options, choosereset, reset As String


        '#Variables Mechanical
        Dim dirservername, dirpath, dirdata As Object

        'STARTUP
        checklicense = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\LICENSE.pdf")

        checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        defaultservers = "Server Minecraft PE"

        checkfolderinstallation = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers")
        dirpath = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Path")
        dirservername = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\ServersName")
        dirdata = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Data")

        For i = 1 To 10
            checkpath(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm")

        Next

        Checking(checknameserver, checkpath)

        If dirpath And dirservername And checkfolderinstallation And dirdata And checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) Then
            quit = "N"
            Reading(path, nservers, nameservers)

        Else
            Console.Clear()
            Console.WriteLine("Preparing the first start ... Press ENTER")
            Console.ReadLine()
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers") ' Create Installation Folder
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\ServersName") 'Create Folder Server Name
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Path") 'Create Folder Path
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Data") 'Create Folder Data

            For i = 1 To 10
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next

            For i = 1 To 100
                Console.WriteLine("Loading resource {0}%", i)
            Next
            Console.WriteLine("Complete! Press ENTER to continue.")
            Console.ReadLine()
            quit = "N"

        End If

        While quit = "N"
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("-------------------------------<Main Menù>--------------------------------------")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("                                                           Version: 1.0 #BUILD 1")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("1- Install PocketMine-MP")
            Console.WriteLine("2- Manage Servers")
            Console.WriteLine("3- Maintenance Servers")
            Console.WriteLine("4- Programm Options")
            Console.WriteLine("5- Informations")
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

            If menù = "2" Then 'Manage Servers

                Checking(checknameserver, checkpath)

                If checknservers Then
                    nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

                Else
                    Do
                        Console.Clear()
                        Console.WriteLine("========================<PocketMine Manager Servers>============================")
                        Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                        Console.Write("How many servers do you want to manage? <1/2/3/.../10> : ")
                        nservers = Console.ReadLine

                        If nservers > 10 Then
                            Console.WriteLine("ERROR! You have exceeded the maximum number of servers available. Please reduce the amount!")
                            Console.ReadLine()

                        ElseIf nservers <= 0 Then
                            Console.WriteLine("ERROR! You have to manage one or more server! (MAX TEN!!)")
                            Console.ReadLine()
                        End If
                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm", nservers, True)

                    Loop While nservers > 10 Or nservers <= 0
                End If

                Console.WriteLine()
                Console.WriteLine("If you do not enter a name for your server , by default it will be '{0}'", defaultservers)

                If nservers >= 1 Then

                    If nservers = 1 And checknameserver(0) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 1 Then
                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 2 And checknameserver(0) And checknameserver(1) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 2 Then
                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 3 And checknameserver(0) And checknameserver(1) And checknameserver(2) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 3 Then

                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 4 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 4 Then
                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 5 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 5 Then
                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 6 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 6 Then

                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 7 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 7 Then

                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 8 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 8 Then

                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 9 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 9 Then

                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

                    End If

                    If nservers = 10 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) And checknameserver(9) Then

                        Managers(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, opener, checkpath)

                    ElseIf nservers = 10 Then

                        Selection(nservers, nameservers, numberservers, defaultservers)

                        Writing(nameservers, nservers, path)

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
                                    Console.Write("WARNING! Are you sure to want to reset data of servers (Only your specified server)? <Y/N>: ")
                                    reset = Console.ReadLine.ToUpper

                                    If reset = "Y" Then
                                        If checkpath(0) Or checkpath(1) Or checkpath(2) Or checkpath(3) Or checkpath(4) Or checkpath(5) Or checkpath(6) Or checkpath(7) Or checkpath(8) Or checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                                            If checknservers Then

                                                nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

                                                For i = 1 To nservers
                                                    My.Computer.FileSystem.DeleteDirectory(path(i - 1), path(i - 1), True)

                                                Next

                                                Console.WriteLine("Closing Program")
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

                Dim information, moreinfo, gitlink, twitterlink As String

                gitlink = "https://github.com/matcracker/PocketMine-ManagerServers"

                twitterlink = "https://twitter.com/matcracker98"

                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.WriteLine("--------------------------------<Informations>----------------------------------")
                    Console.WriteLine("1- License")
                    Console.WriteLine("2- Credits")
                    Console.WriteLine("3- More Information")
                    Console.WriteLine("4- Disclaimer")
                    Console.WriteLine("5- Back")
                    Console.WriteLine()
                    Console.Write("Choose information: ")
                    information = Console.ReadLine

                    If information = "1" Then

                        If checklicense Then
                            Process.Start("C:\Program Files\PocketMine-ManagerServers\LICENSE.pdf")
                        Else
                            Console.WriteLine("ERROR! Bad Installation! License not found!")
                            Console.ReadLine()
                        End If
                    End If

                    If information = "2" Then
                        Console.Clear()
                        Console.WriteLine("========================<PocketMine Manager Servers>============================")
                        Console.WriteLine("--------------------------------<Informations>----------------------------------")
                        Console.WriteLine("This program is free software made by matcracker: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 2 of the License, or at your option) any later version.")
                        Console.WriteLine()
                        Console.WriteLine("This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.")
                        Console.WriteLine()
                        Console.WriteLine("You should have received a copy of the GNU Lesser General Public License along with this program.  If not, see in this program in the section 'Informations ->  License'.")
                        Console.WriteLine()
                        Console.WriteLine("Press ENTER to go back")
                        Console.ReadLine()

                    End If

                    If information = "3" Then
                        Do
                            Console.Clear()
                            Console.WriteLine("========================<PocketMine Manager Servers>============================")
                            Console.WriteLine("-----------------------------<More Informations>--------------------------------")
                            Console.WriteLine("1- GitHub")
                            Console.WriteLine("2- Twitter")
                            Console.WriteLine("3- Back")
                            Console.WriteLine()
                            Console.Write("Choose information: ")
                            moreinfo = Console.ReadLine

                            If moreinfo = "1" Then
                                Process.Start(gitlink)

                            ElseIf moreinfo = "2" Then
                                Process.Start(twitterlink)

                            End If

                        Loop While moreinfo <> "3"
                    End If

                    If information = "4" Then
                        Console.Clear()
                        Console.WriteLine("========================<PocketMine Manager Servers>============================")
                        Console.WriteLine("---------------------------------<Disclaimer>-----------------------------------")
                        Console.WriteLine()
                        Console.WriteLine("I do not assume responsibility for the use of this program if being deleted folders or files, for you, important. The use is personal and therefore the connections you supply will have to be primarily related to the creation program server 'PocketMine-MP' or relative.")
                        Console.ReadLine()

                    End If

                Loop While information <> "5"


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

    Sub Selection(ByVal nservers As Integer, ByRef nameservers As String(), ByVal numberservers As String(), ByVal defaultservers As String)
        For i = 1 To nservers
            defaultservers = ("Server Minecraft PE_" + Convert.ToString(i))

            Console.Write("{0}) Name of {1} server?: ", i, numberservers(i - 1))
            nameservers(i - 1) = Console.ReadLine

            If nameservers(i - 1) = "" Then
                nameservers(i - 1) = defaultservers
            End If

        Next
    End Sub

    Sub Managers(ByVal nservers As Integer, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByVal path As String(), ByRef opener As String, ByVal checkpath As Object())
        
        Reading(path, nservers, nameservers)

        Do

            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
            For i = 1 To nservers
                Console.WriteLine("{0} server: {1}", numberservers_2(i - 1), nameservers(i - 1))
            Next
            Console.WriteLine()
            Console.Write("What do you want to do? <Open [Server/Folder]>: ")
            opener = Console.ReadLine.ToUpper

            If opener <> "SERVER" And opener <> "FOLDER" Then
                Console.WriteLine("Please, select a correct option")
                Console.ReadLine()

            End If

        Loop While opener <> "SERVER" And opener <> "FOLDER"

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" And opener = "SERVER" Or opener = "FOLDER" Then
            Console.WriteLine()
            Console.WriteLine("Reading your file(s)...")
            Console.WriteLine("File(s) succefully read!")
            Console.ReadLine()

            Console.WriteLine()
            Console.WriteLine("Opening your server(s)...")

            If opener = "SERVER" Then

                For i = 1 To nservers
                    If nservers > 1 Then
                        Console.WriteLine("Loading {0} server!", numberservers(i - 1))
                        Process.Start(path(i - 1) + "\start.cmd")

                        Console.WriteLine("Wait 3 seconds to load each server!")
                        For index = 1 To 10000 ^ 2.1 'Small Timer xD
                            index = index + 0.1
                        Next
                    Else
                        Console.WriteLine("Loading {0} server!", numberservers(i - 1))
                        Process.Start(path(i - 1) + "\start.cmd")
                    End If
                Next

            End If

            If opener = "FOLDER" Then
                For i = 1 To nservers
                    Process.Start(path(i - 1))

                Next
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
    End Sub
End Module