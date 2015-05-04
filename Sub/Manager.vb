Module Manager

    Sub Manager(ByRef nservers As Integer, ByRef varmanager As String, ByRef performance As String, ByRef performancestatus As String(), ByRef confirmperfomance As String, ByRef nameservers As String(), ByRef numberservers_2 As String(), ByRef numberservers As String(), ByRef checknameserver As Object(), ByRef path As String(), ByRef pathopener As String, ByRef checkpath As Object(), ByRef checkperformance As Object(), ByRef selectperformance As String)

        Reading(path, nservers, nameservers)

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("-------------------------------<Manage Servers>---------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Open [Server/Folder]")
            Console.WriteLine("2- Edit server performance.")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Select Option: ")
            varmanager = Console.ReadLine

            If varmanager = "1" Then 'Work
                Opener.Opener(nservers, nameservers, numberservers_2, numberservers, checknameserver, path, pathopener, checkpath, performancestatus)

            End If

            If varmanager = "2" Then
                Editor.Editor(confirmperfomance, checkpath, checknameserver, performance, nameservers, nservers, selectperformance, performancestatus, path, numberservers)

            End If

        Loop While varmanager <> "3"
    End Sub

End Module
