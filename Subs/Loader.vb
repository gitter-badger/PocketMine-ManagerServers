Module Loader

    Sub Loader(ByRef checkperformance As Object, ByRef checknameserver As Object, ByRef nameservers As String(), ByRef performancestatus As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef checknservers As Object, ByRef checkfolderinstallation As Object, ByRef dirpath As Object, ByRef dirdata As Object, ByRef dirservername As Object, ByRef dirperformance As Object, ByRef dirutils As Object, ByRef checklicense As Object)

        Dim quit As String

        checklicense = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\LICENSE.pdf")

        checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        For i = 1 To 10
            checkperformance(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm")

        Next

        checkfolderinstallation = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers")
        dirpath = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Path")
        dirservername = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\ServersName")
        dirdata = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Data")
        dirperformance = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Performance")
        dirutils = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Utils")

        Checking(checknameserver, checkpath)

        If dirpath And dirservername And checkfolderinstallation And dirperformance And dirdata And dirutils And checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) _
             And checkperformance(0) And checkperformance(1) And checkperformance(2) And checkperformance(3) And checkperformance(4) And checkperformance(5) And checkperformance(6) And checkperformance(7) And checkperformance(8) And checkperformance(9) Then

            quit = "N"

            Reading(path, nservers, nameservers)

        Else
            Console.ForegroundColor = ConsoleColor.White
            Console.Clear()
            Console.WriteLine("Preparing the first start ... Press ENTER")
            Console.ReadLine()
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers") ' Create Installation Folder
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\ServersName") 'Create Folder Server Name
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Path") 'Create Folder Path
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Data") 'Create Folder Data
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Performance") 'Create Folder Performance
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Utils") 'Create Folder Utils

            For i = 1 To 10
                performancestatus(i - 1) = "Personal"
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm", performancestatus(i - 1), True)

            Next

            For i = 1 To 100
                Console.WriteLine("Loading resource {0}%", i)
            Next
            Console.WriteLine("Complete! Press ENTER to continue.")
            Console.ReadLine()
            quit = "N"

        End If
    End Sub

End Module
