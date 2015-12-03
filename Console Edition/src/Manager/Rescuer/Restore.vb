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
    Sub Restore(ByRef nservers As SByte, ByRef nameservers As String(), ByRef backupstatus As String(), ByRef checkpath As Object(), ByRef path As String(), ByRef back As String, ByRef restoretitle As String, _
                ByRef restore1 As String, ByRef restore2 As String, ByRef restore3 As String, ByRef restore4 As String, ByRef restore5 As String)

        Dim chooserestore As SByte
        Dim openrestore As String

Restore:
        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("{0}", restoretitle)
            Console.ForegroundColor = ConsoleColor.White

            For i = 1 To nservers
                Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), backupstatus(i - 1))

            Next
            Console.WriteLine("11) {0}", back)

            Console.WriteLine()
            Console.Write("{0}", restore1)
            chooserestore = Console.ReadLine

            If chooserestore = 11 Then
                Exit Sub

            End If

        Loop While chooserestore = 0 Or chooserestore > 11

        Console.WriteLine()

        If (chooserestore > 0 Or chooserestore <= 10) And backupstatus(chooserestore - 1) = "Backuped" Then

            Dim ZipToUnpack As String = System.IO.Directory.GetCurrentDirectory + "\Backups\Servers\" + nameservers(chooserestore - 1) + ".zip"
            Dim UnpackDirectory As String = System.IO.Directory.GetCurrentDirectory + "\Backups\Servers\Extracted " + nameservers(chooserestore - 1)

            Console.WriteLine("{0}", restore2)
            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                Dim e As ZipEntry

                For Each e In zip1
                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Next
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("{0}", restore3)
            End Using
            Console.ReadLine()

            Do
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("{0} <Y/N>: ", restore5)
                openrestore = Console.ReadLine.ToUpper

                If openrestore = "Y" Then
                    Process.Start(System.IO.Directory.GetCurrentDirectory + "\Backups")

                End If

            Loop While openrestore <> "Y" And openrestore <> "N"

        Else
            Console.WriteLine("{0}", restore4)
            Console.ReadLine()

            GoTo Restore

        End If

    End Sub
End Module
