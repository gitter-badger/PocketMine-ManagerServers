Module ItalianReader
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
    Sub ItalianReader(ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, _
                 ByRef menudev As String, ByRef menutitle As String, ByRef menu1 As String, ByRef menu2 As String, ByRef menu3 As String, ByRef menu4 As String, ByRef menu5 As String, ByRef menu6 As String, ByRef installertitle As String, ByRef installer1 As String, ByRef installer2 As String, ByRef installer3 As String, _
                 ByRef installator1 As String, ByRef installator2 As String, ByRef installator3 As String, ByRef installator4 As String, ByRef installator5 As String, ByRef installator6 As String, ByRef installator7 As String, ByRef downloadertitle As String, ByRef downloader1 As String, ByRef downloader2 As String, ByRef downloader3 As String, ByRef downloader4 As String, ByRef downloader5 As String, ByRef downloader6 As String, _
                 ByRef downloader7 As String, ByRef downloader8 As String, ByRef downloader9 As String, ByRef downloader10 As String, ByRef downloader11 As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef manager4 As String, ByRef openertitle As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, ByRef opener5 As String, ByRef opener6 As String, _
                 ByRef opener7 As String, ByRef opener8 As String, ByRef editortitle As String, ByRef editor1 As String, ByRef editor2 As String, ByRef editor3 As String, ByRef properties1 As String, ByRef properties2 As String, ByRef properties3 As String, ByRef properties4 As String, ByRef properties5 As String, ByRef properties6 As String, ByRef performancetitle As String, ByRef performance1 As String, _
                 ByRef performance2 As String, ByRef performance3 As String, ByRef performance4 As String, ByRef performance5 As String, ByRef performance6 As String, ByRef performance7 As String, ByRef performance8 As String, ByRef performance9 As String, ByRef performance10 As String, ByRef performance11 As String, _
                 ByRef performance12 As String, ByRef option1 As String, ByRef option2 As String, ByRef option3 As String, ByRef lang1 As String, ByRef resetp1 As String, ByRef resetp2 As String, ByRef resetp3 As String, ByRef resetp4 As String, ByRef resetp5 As String, ByRef resetp6 As String,
                 ByRef resetp7 As String, ByRef resetp8 As String, ByRef resetp9 As String, ByRef resetp10 As String, ByRef resetp11 As String, ByRef info1 As String, ByRef info2 As String, ByRef info3 As String, ByRef info4 As String, ByRef info5 As String, ByRef info6 As String, ByRef exit1 As String, ByRef exit2 As String)

        back = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords1.lang")
        changemade = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords2.lang")
        status1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords3.lang")
        version1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords4.lang")
        versionstable1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords5.lang")
        versionbeta1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords6.lang")
        versiondev1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords7.lang")
        versionsoft1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords8.lang")
        currentversion = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords9.lang")
        writepath1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords10.lang")
        writepath2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords11.lang")
        writepath3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\UniqueWords12.lang")

        menutitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu1.lang")
        menudev = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu2.lang")
        menu1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu3.lang")
        menu2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu4.lang")
        menu3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu5.lang")
        menu4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu6.lang")
        menu5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu7.lang")
        menu6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Menu8.lang")

        installertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install1.lang")
        installer1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install2.lang")
        installer2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install3.lang")
        installer3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Install4.lang")

        installator1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator1.lang")
        installator2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator2.lang")
        installator3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator3.lang")
        installator4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator4.lang")
        installator5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator5.lang")
        installator6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator6.lang")
        installator7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Installator7.lang")

        downloadertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader0.lang")
        downloader1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader1.lang")
        downloader2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader2.lang")
        downloader3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader3.lang")
        downloader4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader4.lang")
        downloader5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader5.lang")
        downloader6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader6.lang")
        downloader7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader7.lang")
        downloader8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader8.lang")
        downloader9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader9.lang")
        downloader10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader10.lang")
        downloader11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Downloader11.lang")

        manager1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager1.lang")
        manager2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager2.lang")
        manager3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager3.lang")
        manager4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Manager4.lang")

        openertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener0.lang")
        opener1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener1.lang")
        opener2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener2.lang")
        opener3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener3.lang")
        opener4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener4.lang")
        opener5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener5.lang")
        opener6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener6.lang")
        opener7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener7.lang")
        opener8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Opener8.lang")

        editortitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor0.lang")
        editor1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor1.lang")
        editor2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor2.lang")
        editor3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Editor3.lang")

        properties1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties1.lang")
        properties2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties2.lang")
        properties3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties3.lang")
        properties4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties4.lang")
        properties5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties5.lang")
        properties6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Properties6.lang")

        performancetitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance0.lang")
        performance1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance1.lang")
        performance2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance2.lang")
        performance3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance3.lang")
        performance4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance4.lang")
        performance5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance5.lang")
        performance6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance6.lang")
        performance7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance7.lang")
        performance8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance8.lang")
        performance9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance9.lang")
        performance10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance10.lang")
        performance11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance11.lang")
        performance12 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Performance12.lang")

        option1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option1.lang")
        option2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option2.lang")
        option3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Option3.lang")

        lang1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Lang1.lang")

        resetp1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp1.lang")
        resetp2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp2.lang")
        resetp3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp3.lang")
        resetp4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp4.lang")
        resetp5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp5.lang")
        resetp6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp6.lang")
        resetp7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp7.lang")
        resetp8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp8.lang")
        resetp9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp9.lang")
        resetp10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp10.lang")
        resetp11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Resetp11.lang")

        info1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info1.lang")
        info2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info2.lang")
        info3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info3.lang")
        info4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info4.lang")
        info5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info5.lang")
        info6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Info6.lang")

        exit1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Exit1.lang")
        exit2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\Italian\Exit2.lang")

    End Sub
End Module
