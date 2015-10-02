Imports Ionic.Zip

Module RestoreCommand
    Sub RestoreCommand(ByRef args As String(), ByRef command As String, ByRef nservers As SByte, ByRef path As String(), ByRef checkpath As Object(), ByRef nameservers As String(), ByRef backupstatus As String())

        For i = 1 To 10
            backupstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm")
        Next

        If command = "restore" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /restore <servername|all>")

        ElseIf command = "restore " + args(1) Then
            If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then

                If args(1) = nameservers(0) Or args(1) = nameservers(1) Or args(1) = nameservers(2) Or args(1) = nameservers(3) _
                    Or args(1) = nameservers(4) Or args(1) = nameservers(5) Or args(1) = nameservers(6) Or args(1) = nameservers(7) _
                    Or args(1) = nameservers(8) Or args(1) = nameservers(9) Or args(1) = "all" Then

                    Console.WriteLine("I'm restoring your backup(s)...")
                End If

                If args(1) = "all" Then
                    For i = 1 To nservers
                        If backupstatus(i - 1) = "Backuped" Then
                            Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(i - 1) + ".zip"
                            Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(i - 1)

                            Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                                Dim e As ZipEntry

                                For Each e In zip1
                                    e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                                Next
                            End Using
                        Else
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("You must first do a backup of your servers.")
                        End If
                    Next

                ElseIf args(1) = nameservers(0) And backupstatus(0) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(0) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(0)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(1) And backupstatus(1) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(1) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(1)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(2) And backupstatus(2) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(2) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(2)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(3) And backupstatus(3) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(3) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(3)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(4) And backupstatus(4) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(4) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(4)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(5) And backupstatus(5) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(5) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(5)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(6) And backupstatus(6) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(6) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(6)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(7) And backupstatus(7) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(7) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(7)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(8) And backupstatus(8) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(8) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(8)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using

                ElseIf args(1) = nameservers(9) And backupstatus(9) = "Backuped" Then
                    Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\" + nameservers(9) + ".zip"
                    Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Backups\Servers\Extracted " + nameservers(9)

                    Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                        Dim e As ZipEntry

                        For Each e In zip1
                            e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Any server with this name exist!")

                End If

                Console.ForegroundColor = ConsoleColor.Blue
                If args(1) = "all" Then

                    Console.Write("Succefully restored: ")
                    For i = 1 To nservers
                        Console.Write("{0}, ", nameservers(i - 1))
                    Next

                ElseIf args(1) = nameservers(0) Or args(1) = nameservers(1) Or args(1) = nameservers(2) Or args(1) = nameservers(3) _
                    Or args(1) = nameservers(4) Or args(1) = nameservers(5) Or args(1) = nameservers(6) Or args(1) = nameservers(7) _
                    Or args(1) = nameservers(8) Or args(1) = nameservers(9) Then

                    Console.WriteLine("Succefully restored " + args(1))

                End If
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("You must define the path of your servers!")
            End If
        End If
    End Sub
End Module
