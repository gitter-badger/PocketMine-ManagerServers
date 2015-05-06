Module LoaderManager

    Sub LoaderManager(ByRef defaultservers As String)

        '#Variables "Manage Servers"
        Dim nservers As Integer
        Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
        Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}
        Dim numberservers_2 As String() = New String() {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"}

        Dim checknservers As Object

        Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        Dim pathopener As String
        Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkpath As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
        '-------------------------------------------------------------------------------------------------------------------------------------------------
        Dim varmanager As String

        '-------------------------------------------------------------------------------------------------------------------------------------------------
        Dim performance, confirmperfomance, selectperformance As String

        Dim performancestatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

        Dim checkperformance As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

        checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        If checknservers Then
            nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        Else
            Do
                Try
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Write("How many servers do you want to manage? <1/2/3/.../10> : ")
                    nservers = Console.ReadLine

                    If nservers > 10 Then
                        Console.WriteLine("ERROR! You have exceeded the maximum number of servers available. Please reduce the amount!")
                        Console.ReadLine()

                    ElseIf nservers <= 0 Then
                        Console.WriteLine("ERROR! You have to manage one or more server! (MAX TEN!!)")
                        Console.ReadLine()

                    End If

                Catch ex As Exception
                    Console.WriteLine(ex)

                End Try
            Loop While nservers > 10 Or nservers <= 0

            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm", nservers, True)

        End If

        Checking(checknameserver, checkpath)

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("If you do not enter a name for your server , by default it will be '{0}'", defaultservers)

        If nservers >= 1 Then
            If nservers = 1 And checknameserver(0) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 1 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 2 And checknameserver(0) And checknameserver(1) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 2 Then

                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 3 And checknameserver(0) And checknameserver(1) And checknameserver(2) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 3 Then

                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 4 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 4 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 5 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 5 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 6 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 6 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 7 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 7 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 8 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 8 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 9 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 9 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 10 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) And checknameserver(9) Then

                Manager.Manager(nservers, varmanager, performance, performancestatus, confirmperfomance, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, checkperformance, selectperformance)

            ElseIf nservers = 10 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If
        End If

    End Sub
End Module
