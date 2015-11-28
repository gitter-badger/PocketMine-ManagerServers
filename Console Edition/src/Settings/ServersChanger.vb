Module ServersChanger
    ' _____           _        _   __  __ _                   __  __                                   _____                              
    '|  __ \         | |      | | |  \/  (_)                 |  \/  |                                 / ____|                             
    '| |__) |__   ___| | _____| |_| \  / |_ _ __   ___ ______| \  / | __ _ _ __   __ _  __ _  ___ _ _| (___   ___ _ ____   _____ _ __ ___ 
    '|  ___/ _ \ / __| |/ / _ \ __| |\/| | | '_ \ / _ \______| |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__\___ \ / _ \ '__\ \ / / _ \ '__/ __|
    '| |  | (_) | (__|   <  __/ |_| |  | | | | | |  __/      | |  | | (_| | | | | (_| | (_| |  __/ |  ____) |  __/ |   \ V /  __/ |  \__ \
    '|_|   \___/ \___|_|\_\___|\__|_|  |_|_|_| |_|\___|      |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_____/ \___|_|    \_/ \___|_|  |___/
    '                                                                                   __/ |                                             
    '                                                                                  |___/                                              
    'Copyright (C) 2015  matcracker

    'This program is free software: you can redistribute it and/or modify 
    'it under the terms of the GNU Lesser General Public License as published by 
    'the Free Software Foundation, either version 3 of the License, or 
    '(at your option) any later version. 
    Sub ServersChanger(ByRef nservers As SByte, ByRef path As String(), ByRef nameservers As String(), ByRef checknameservers As Object(), ByRef back As String)

        Dim chooseserver, chooseoption As Integer

        Reading(path, nservers, nameservers)

        Do
            Try
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("===========================<Change/Delete servers>==============================")
                Console.ForegroundColor = ConsoleColor.White
                For i = 1 To nservers
                    Console.WriteLine("{0}) {1}", i, nameservers(i - 1))

                Next
                Console.WriteLine("11) {0}", back)
                Console.WriteLine()
                Console.Write("Which server do you want to edit? ")
                chooseserver = Console.ReadLine

                If chooseserver = 11 Then
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

        Loop While chooseserver < 1 Or chooseserver > 10

        If checknameservers(chooseserver - 1) Then
            Do
                Console.WriteLine("1) Change server name")
                Console.WriteLine("2) Delete server")
                Console.WriteLine()
                Console.Write("Choose one option: ")
                chooseoption = Console.ReadLine

            Loop While chooseoption <> 1 And chooseoption <> 2

            Dim newname As String

            If chooseoption = 1 Then
                Do
                    newname = ""
                    Console.WriteLine("Current name: {0}", nameservers(chooseserver - 1))
                    Console.Write("New name: ")
                    newname = Console.ReadLine

                    If newname.Contains(" ") Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("The new name mustn't contain space!")
                        Console.ReadLine()
                        Console.ForegroundColor = ConsoleColor.White

                    ElseIf newname = nameservers(chooseserver - 1) Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("The name are the same!")
                        Console.ReadLine()
                        Console.ForegroundColor = ConsoleColor.White

                    End If
                Loop While newname.Contains(" ") Or newname = nameservers(chooseserver - 1)

                If newname = "" Then
                    Dim defaultserver As String = "Server_Minecraft_PE"
                    newname = defaultserver + "_" + Convert.ToString(chooseserver)
                End If

                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(chooseserver) + ".pm")
                nameservers(chooseserver - 1) = newname
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(chooseserver) + ".pm", nameservers(chooseserver - 1), True)
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Changed name succefully!")
                Console.ReadLine()


            ElseIf chooseoption = 2 Then
                Dim confirmdelete As Char

                Do
                    Console.Write("Are you sure to delete {0}? <Y/N>: ", nameservers(chooseserver - 1))
                    confirmdelete = Console.ReadLine.ToUpper

                    If confirmdelete = "Y" Then
                        'TODO: Deleting server and change order of next (Like a bubble sort algorithm)

                    End If
                Loop While confirmdelete <> "Y" And confirmdelete <> "N"

            End If

        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("This server don't exist!")
            Console.ReadLine()
        End If
    End Sub
End Module
