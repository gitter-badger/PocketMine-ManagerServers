Module Installator
    Sub Installator(ByRef nameservers As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef numberservers As String(), ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef checknameserver As Object())
        '#Variables "Install PocketMine-MP"
        Dim version, choosephar, pharpath, stable, beta, dev, soft, linkstable, linkbeta, linkdev, linksoft, chooseinstallation As String
        Dim pharbeta, phardev, pharsoft As Object
        Dim checkpocketmine, checkpharpath As Object

        linkstable = "http://sourceforge.net/projects/pocketmine/files/windows/PocketMine-MP_Installer_1.4.1_x86.exe/download"
        linkbeta = "https://github.com/PocketMine/PocketMine-MP/releases/download/1.4.1dev-936/PocketMine-MP_1.4.1dev-936.phar"
        linkdev = "http://jenkins.pocketmine.net/job/PocketMine-MP/1116/artifact/PocketMine-MP_1.5dev-1116_f718d06a_API-1.12.0.phar"
        linksoft = "http://jenkins.pocketmine.net/job/PocketMine-Soft/lastSuccessfulBuild/artifact/PocketMine-Soft_1.4.1-240_7ebde536_API-1.11.0.phar"

        checkpocketmine = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\PocketMine-MP_Installer_1.4.1_x86.exe")
        checkpharpath = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\pharpath.pm")

        Checking(checknameserver, checkpath)

        nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        For i = 1 To nservers
            installationstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm")
            downloadstatus(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm")
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\ServersName\ServerName_" + Convert.ToString(i) + ".pm")

        Next

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("--------------------------<Initialize PocketMine-MP>-------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Download")
            Console.WriteLine("2- Installed")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Choose what do you want to do: ")
            chooseinstallation = Console.ReadLine

            If chooseinstallation = "1" Then
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine("--------------------------<Download PocketMine-MP>-------------------------------")
                Console.ForegroundColor = ConsoleColor.White
                For i = 1 To nservers
                    Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), downloadstatus(i - 1))

                Next
                'Console.WriteLine("1- Version Stable (Setup File): {0}")
                'Console.WriteLine("2- Version Beta (Phar File): {0}")
                'Console.WriteLine("3- Version Dev (Phar File): {0}")
                'Console.WriteLine("4- Version Soft (Phar File): {0}")
                'Console.WriteLine("5- Back")
                Console.WriteLine()
                Console.Write("What kind of version you want to install? ")
                version = Console.ReadLine
            End If

        Loop While chooseinstallation <> "3"
    End Sub

End Module
