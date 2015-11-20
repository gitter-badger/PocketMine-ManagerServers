Module Editor

    Sub Editor(ByRef confirmperfomance As String, ByRef checkpath As Object(), ByRef checknameserver As Object(), ByRef performance As String, ByRef nameservers As String(), ByRef nservers As SByte, ByRef performancestatus As String(), ByRef path As Object(), ByRef numberservers As String(), _
               ByRef back As String, ByRef changemade As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, ByRef editortitle As String, ByRef editor1 As String, ByRef editor2 As String, ByRef editor3 As String, ByRef propertiestitle As String, ByRef properties1 As String, ByRef properties2 As String, ByRef properties3 As String, ByRef properties4 As String, ByRef properties5 As String, ByRef properties6 As String, ByRef properties7 As String, _
               ByRef performancetitle As String, ByRef performance1 As String, ByRef performance2 As String, ByRef performance3 As String, ByRef performance4 As String, ByRef performance5 As String, ByRef performance6 As String, ByRef performance7 As String, ByRef performance8 As String, ByRef performance9 As String, ByRef performance10 As String, ByRef performance11 As String, _
               ByRef performance12 As String)

        Dim choosedit As String

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("{0}", editortitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", editor1)
            Console.WriteLine("2- {0}", editor2)
            Console.WriteLine("3- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", editor3)
            choosedit = Console.ReadLine

            If choosedit = "1" Then
                Properties.Properties(checkpath, path, nservers, nameservers, checknameserver, back, writepath1, writepath2, writepath3, _
                                      propertiestitle, properties1, properties2, properties3, properties4, properties5, properties6, properties7, performance11)

            End If

            If choosedit = "2" Then
                For i = 1 To nservers
                    performancestatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm")

                Next

                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.Gray
                    Console.WriteLine("{0}", performancetitle)
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("{0}", performance1)
                    For i = 1 To nservers
                        Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), performancestatus(i - 1))

                    Next

                    Console.WriteLine()
                    Console.WriteLine("{0}", performance2)
                    Console.WriteLine("1- {0}", performance3)
                    Console.WriteLine("2- {0}", performance4)
                    Console.WriteLine("3- {0}", performance5)
                    Console.WriteLine("4- {0}", back)
                    Console.WriteLine()
                    Console.Write("{0}", performance6)
                    performance = Console.ReadLine

                    If performance = "1" Then
                        Console.WriteLine()
                        Console.WriteLine("{0}", performance7)
                        Console.Write("{0}", performance8)
                        confirmperfomance = Console.ReadLine.ToUpper

                        If confirmperfomance = "Y" Then
                            Performances.Performances(checkpath, checknameserver, performance, nameservers, nservers, performancestatus, path, back, changemade, writepath1, _
                                                      writepath2, writepath3, performancetitle, performance11, performance12)

                        End If
                    End If

                    If performance = "2" Then
                        Console.WriteLine()
                        Console.WriteLine("{0}", performance9)
                        Console.Write("{0}", performance8)
                        confirmperfomance = Console.ReadLine.ToUpper

                        If confirmperfomance = "Y" Then
                            Performances.Performances(checkpath, checknameserver, performance, nameservers, nservers, performancestatus, path, back, changemade, writepath1, _
                                                      writepath2, writepath3, performancetitle, performance11, performance12)
                        End If
                    End If

                    If performance = "3" Then
                        Console.WriteLine()
                        Console.WriteLine("{0}", performance10)
                        Console.Write("{0}", performance8)
                        confirmperfomance = Console.ReadLine.ToUpper

                        If confirmperfomance = "Y" Then
                            Performances.Performances(checkpath, checknameserver, performance, nameservers, nservers, performancestatus, path, back, changemade, writepath1, _
                                                      writepath2, writepath3, performancetitle, performance11, performance12)

                        End If
                    End If

                Loop While performance <> "4"
            End If

        Loop While choosedit <> "3"
    End Sub
End Module
