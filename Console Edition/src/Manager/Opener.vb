Module Opener
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
    Sub Opener(ByRef nservers As SByte, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef performancestatus As String(), _
               ByRef back As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef openertitle As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, _
               ByRef opener5 As String, ByRef opener6 As String, ByRef opener7 As String, ByRef opener8 As String, ByRef opener9 As String, ByRef opener10 As String)

        Reading(path, nservers, nameservers)
        Dim chooseserver As SByte

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.DarkMagenta
            Console.WriteLine("{0}", openertitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("{0}:", opener1)
            Console.WriteLine("1- Servers")
            Console.WriteLine("2- {0}", opener8)
            Console.WriteLine("3- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", opener2)
            pathopener = Console.ReadLine

            If pathopener = "3" Then
                Exit Sub

            End If

            Console.WriteLine()
            For i = 1 To nservers
                Console.WriteLine("{0}) {1}", i, nameservers(i - 1))
            Next
            Console.WriteLine("11) {0}", back)

            Do
                Try

                    Console.WriteLine()
                    Console.Write("{0} server: ", opener1)
                    chooseserver = Console.ReadLine

                    If chooseserver = 11 Then
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try
            Loop While chooseserver < 1 Or chooseserver > 10

            If chooseserver <= nservers Then
                If checkpath(chooseserver - 1) And path(chooseserver - 1) <> "" And (pathopener = "1" Or pathopener = "2") Then

                    Console.WriteLine()
                    Console.WriteLine("{0}", opener3)
                    Console.WriteLine("{0}", opener4)

                    Console.WriteLine()
                    Console.WriteLine("{0}", opener5)

                    Dim allservers As String

                    If pathopener = "1" Then

                        Console.WriteLine()
                        Do
                            Console.Write("{0} <Y/N>: ", opener9)
                            allservers = Console.ReadLine.ToUpper

                        Loop While allservers <> "Y" And allservers <> "N"

                        If allservers = "Y" Then
                            For i = 1 To nservers
                                If nservers > 1 Then
                                    Console.WriteLine("{0} {1} server!", opener6, numberservers(i - 1))
                                    Try
                                        Process.Start(path(i - 1) + "\start.cmd")
                                    Catch ex As Exception
                                        Console.ForegroundColor = ConsoleColor.Red
                                        Console.WriteLine("Can't find the start.cmd")
                                        Console.ForegroundColor = ConsoleColor.White
                                    End Try

                                    Console.WriteLine("{0}", opener7)

                                    System.Threading.Thread.Sleep(3000)

                                Else
                                    Console.WriteLine("{0} {1} server!", opener6, numberservers(i - 1))
                                    Try
                                        Process.Start(path(i - 1) + "\start.cmd")
                                    Catch ex As Exception
                                        Console.ForegroundColor = ConsoleColor.Red
                                        Console.WriteLine("Can't find the start.cmd")
                                        Console.ForegroundColor = ConsoleColor.White
                                    End Try
                                End If
                            Next
                        ElseIf allservers = "N" Then
                            Console.WriteLine("{0} {1}", opener6, nameservers(chooseserver - 1))
                            Try
                                Process.Start(path(chooseserver - 1) + "\start.cmd")
                            Catch ex As Exception
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine("Can't find the start.cmd")
                                Console.ForegroundColor = ConsoleColor.White
                            End Try

                        End If
                    End If

                    If pathopener = "2" Then
                        Do
                            Console.Write("{0} <Y/N>: ", opener10)
                            allservers = Console.ReadLine.ToUpper

                        Loop While allservers <> "Y" And allservers <> "N"

                        If allservers = "Y" Then
                            For i = 1 To nservers
                                Try
                                    Process.Start(path(i - 1) + "\start.cmd")
                                Catch ex As Exception
                                    Console.ForegroundColor = ConsoleColor.Red
                                    Console.WriteLine("Can't find the start.cmd")
                                    Console.ForegroundColor = ConsoleColor.White
                                End Try
                            Next
                        ElseIf allservers = "N" Then
                            Try
                                Process.Start(path(chooseserver - 1) + "\start.cmd")
                            Catch ex As Exception
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine("Can't find the start.cmd")
                                Console.ForegroundColor = ConsoleColor.White
                            End Try
                        End If
                    End If

                Else

                    Do
                        Console.Write("{0} {1}{2} ", writepath1, nameservers(chooseserver - 1), writepath2)
                        path(chooseserver - 1) = Console.ReadLine

                        If path(chooseserver - 1) = "" Then
                            Console.ForegroundColor = ConsoleColor.DarkRed
                            Console.WriteLine("{0}", writepath3)
                            Console.ReadLine()

                        End If
                    Loop While path(chooseserver - 1) = ""

                    My.Computer.FileSystem.WriteAllText(System.IO.Directory.GetCurrentDirectory + "\Path\path_" + Convert.ToString(chooseserver) + ".pm", path(chooseserver - 1), True)
                End If
            Else
                Console.WriteLine("Select an avaible server!")
                Console.ReadLine()

            End If
        Loop While pathopener <> "1" Or pathopener <> "2"

    End Sub
End Module
