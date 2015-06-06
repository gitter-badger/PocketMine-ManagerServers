Module EnglishR
    Sub EnglishR()

        Dim back, changemade, status1, version1, versionstable, versionbeta, versiondev, versionsoft, currentversion, writepath1, writepath2 As String

        back = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords1.lang")
        changemade = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords2.lang")
        status1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords3.lang")
        version1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords4.lang")
        versionstable = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords5.lang")
        versionbeta = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords6.lang")
        versiondev = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords7.lang")
        versionsoft = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords8.lang")
        currentversion = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords9.lang")
        writepath1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords10.lang")
        writepath2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords11.lang")

        Dim menudev, menutitle, menu1, menu2, menu3, menu4, menu5, menu6 As String

        menudev = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu1.lang")
        menutitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu2.lang")
        menu1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu3.lang")
        menu2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu4.lang")
        menu3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu5.lang")
        menu4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu6.lang")
        menu5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu7.lang")
        menu6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu8.lang")

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install1.lang", installertitle, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install2.lang", installer1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install3.lang", installer2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install4.lang", installer3, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator1.lang", installator1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator2.lang", installator2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator3.lang", installator3, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator4.lang", installator4, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator5.lang", installator5, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader1.lang", downloader1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader2.lang", downloader2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader3.lang", downloader3, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader4.lang", downloader4, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader5.lang", downloader5, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader6.lang", downloader6, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader7.lang", downloader7, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader8.lang", downloader8, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader9.lang", downloader9, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager1.lang", manager1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager2.lang", manager2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager3.lang", manager3, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener1.lang", opener1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener2.lang", opener2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener3.lang", opener3, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener4.lang", opener4, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener5.lang", opener5, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener6.lang", opener6, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener7.lang", opener7, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor1.lang", editor1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor2.lang", editor2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor3.lang", editor3, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties1.lang", properties1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties2.lang", properties2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties3.lang", properties3, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties4.lang", properties4, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties5.lang", properties5, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties6.lang", properties6, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance1.lang", performance1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance2.lang", performance2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance3.lang", performance3, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance4.lang", performance4, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance5.lang", performance5, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance6.lang", performance6, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance7.lang", performance7, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance8.lang", performance8, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance9.lang", performance9, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance10.lang", performance10, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance11.lang", performance11, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance12.lang", performance12, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance13.lang", performance13, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option1.lang", option1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option2.lang", option2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option3.lang", option3, True)

        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp1.lang", resetp1, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp2.lang", resetp2, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp3.lang", resetp3, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp4.lang", resetp4, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp5.lang", resetp5, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp6.lang", resetp6, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp7.lang", resetp7, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp8.lang", resetp8, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp9.lang", resetp9, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp10.lang", resetp10, True)
        'My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp11.lang", resetp11, True)

    End Sub
End Module
