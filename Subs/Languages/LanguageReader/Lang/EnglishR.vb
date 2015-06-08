Module EnglishR
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
    Sub EnglishR(ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable As String, ByRef versionbeta As String)

        Dim versiondev, versionsoft, currentversion, writepath1, writepath2 As String

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

        Dim installertitle, installer1, installer2, installer3 As String

        installertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install1.lang")
        installer1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install2.lang")
        installer2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install3.lang")
        installer3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install4.lang")

        Dim installator1, installator2, installator3, installator4, installator5 As String

        installator1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator1.lang")
        installator2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator2.lang")
        installator3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator3.lang")
        installator4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator4.lang")
        installator5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator5.lang")

        Dim downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9 As String

        downloader1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader1.lang")
        downloader2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader2.lang")
        downloader3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader3.lang")
        downloader4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader4.lang")
        downloader5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader5.lang")
        downloader6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader6.lang")
        downloader7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader7.lang")
        downloader8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader8.lang")
        downloader9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader9.lang")

        Dim manager1, manager2, manager3 As String

        manager1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager1.lang")
        manager2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager2.lang")
        manager3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager3.lang")

        Dim opener1, opener2, opener3, opener4, opener5, opener6, opener7 As String

        opener1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener1.lang")
        opener2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener2.lang")
        opener3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener3.lang")
        opener4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener4.lang")
        opener5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener5.lang")
        opener6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener6.lang")
        opener7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener7.lang")

        Dim editor1, editor2, editor3 As String

        editor1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor1.lang")
        editor2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor2.lang")
        editor3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor3.lang")

        Dim properties1, properties2, properties3, properties4, properties5, properties6 As String

        properties1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties1.lang")
        properties2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties2.lang")
        properties3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties3.lang")
        properties4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties4.lang")
        properties5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties5.lang")
        properties6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties6.lang")

        Dim performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, performance12, performance13 As String

        performance1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance1.lang")
        performance2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance2.lang")
        performance3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance3.lang")
        performance4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance4.lang")
        performance5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance5.lang")
        performance6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance6.lang")
        performance7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance7.lang")
        performance8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance8.lang")
        performance9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance9.lang")
        performance10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance10.lang")
        performance11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance11.lang")
        performance12 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance12.lang")
        performance13 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance13.lang")

        Dim option1, option2, option3 As String

        option1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option1.lang")
        option2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option2.lang")
        option3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option3.lang")

        Dim lang1 As String

        lang1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Lang1.lang")

        Dim resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11 As String

        resetp1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp1.lang")
        resetp2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp2.lang")
        resetp3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp3.lang")
        resetp4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp4.lang")
        resetp5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp5.lang")
        resetp6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp6.lang")
        resetp7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp7.lang")
        resetp8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp8.lang")
        resetp9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp9.lang")
        resetp10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp10.lang")
        resetp11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp11.lang")

        Dim info1, info2, info3, info4, info5, info6 As String

        info1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info1.lang")
        info2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info2.lang")
        info3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info3.lang")
        info4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info4.lang")
        info5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info5.lang")
        info6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info6.lang")

        Dim exit1, exit2 As String

        exit1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit1.lang")
        exit2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit2.lang")

    End Sub
End Module
