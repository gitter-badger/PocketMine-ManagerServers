Imports Ionic.Zip

Module Restore
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
    Sub Restore(ByRef nservers As Integer, ByRef nameservers As String(), ByRef backupstatus As String(), ByRef checkpath As Object(), ByRef path As String())

        Dim chooserestore As String

        Dim i As Integer
Restore:
        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("-------------------------------<Restore Server>---------------------------------")
            Console.ForegroundColor = ConsoleColor.White

            For i = 1 To nservers
                Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), backupstatus(i - 1))

            Next
            Console.WriteLine("11) Back")

            Console.WriteLine()
            Console.Write("Choose which server do you want to backup: ")
            chooserestore = Console.ReadLine

            If chooserestore = "11" Then
                Exit Sub

            End If

        Loop While chooserestore = "0"

        Console.WriteLine()

        If chooserestore = "1" And backupstatus(0) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(0) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(0)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "2" And backupstatus(1) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(1) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(1)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "3" And backupstatus(2) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(2) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(2)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "4" And backupstatus(3) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(3) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(3)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "5" And backupstatus(4) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(4) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(4)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "6" And backupstatus(5) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(5) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(5)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "7" And backupstatus(6) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(6) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(6)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "8" And backupstatus(7) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(7) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(7)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "9" And backupstatus(8) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(8) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(8)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()

        ElseIf chooserestore = "10" And backupstatus(9) = "Backuped" Then

            Dim ZipToUnpack As String = nameservers(9) + ".zip"
            Dim UnpackDirectory As String = "Extracted " + nameservers(9)

            Console.WriteLine("I'm extracting your server, please wait!")
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("DONE! Press ENTER to continue.")
            End Using
            Console.ReadLine()
        Else
            Console.WriteLine("Error, first do a backup of a your server!")
            Console.ReadLine()

            GoTo Restore

        End If

    End Sub
End Module
