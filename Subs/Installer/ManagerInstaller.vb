Module ManagerInstaller
    Sub ManagerInstaller(ByRef path As String(), ByRef nameservers As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef numberservers As String(), ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef versionstatus As String(), ByRef checknameserver As Object())

        '#Variables "Install PocketMine-MP"
        Dim chooseinstallation As String

        Checking(checknameserver, checkpath)

        nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        For i = 1 To nservers
            installationstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm")
            downloadstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm")
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
            versionstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\VersionStatus_" + Convert.ToString(i) + ".pm")
        Next

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("--------------------------<Initialize PocketMine-MP>----------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Download")
            Console.WriteLine("2- Install")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Choose what do you want to do: ")
            chooseinstallation = Console.ReadLine

            If chooseinstallation = "1" Then
                Downloader.Downloader(nameservers, nservers, checkpath, path, numberservers, downloadstatus, versionstatus, checknameserver)

            End If

            If chooseinstallation = "2" Then
                Installator.Installator(checkpath, nservers, nameservers, installationstatus, versionstatus, path, numberservers)

            End If

        Loop While chooseinstallation <> "3"
    End Sub
End Module
