Imports Ionic.Zip
Module EnglishReader
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
    Sub EnglishReader(ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, _
                    ByRef menudev As String, ByRef menutitle As String, ByRef menu1 As String, ByRef menu2 As String, ByRef menu3 As String, ByRef menu4 As String, ByRef menu5 As String, ByRef menu6 As String, ByRef installertitle As String, ByRef installer1 As String, ByRef installer2 As String, ByRef installer3 As String, _
                    ByRef installatortitle As String, ByRef installator1 As String, ByRef installator2 As String, ByRef installator3 As String, ByRef installator4 As String, ByRef installator5 As String, ByRef installator6 As String, ByRef installator7 As String, ByRef downloadertitle As String, ByRef downloader1 As String, ByRef downloader2 As String, ByRef downloader3 As String, ByRef downloader4 As String, ByRef downloader5 As String, ByRef downloader6 As String, _
                    ByRef downloader7 As String, ByRef downloader8 As String, ByRef downloader9 As String, ByRef downloader10 As String, ByRef downloader11 As String, ByRef managertitle As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef manager4 As String, ByRef manager5 As String, ByRef openertitle As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, ByRef opener5 As String, ByRef opener6 As String, _
                    ByRef opener7 As String, ByRef opener8 As String, ByRef editortitle As String, ByRef editor1 As String, ByRef editor2 As String, ByRef editor3 As String, ByRef propertiestitle As String, ByRef properties1 As String, ByRef properties2 As String, ByRef properties3 As String, ByRef properties4 As String, ByRef properties5 As String, ByRef properties6 As String, ByRef performancetitle As String, ByRef performance1 As String, _
                    ByRef performance2 As String, ByRef performance3 As String, ByRef performance4 As String, ByRef performance5 As String, ByRef performance6 As String, ByRef performance7 As String, ByRef performance8 As String, ByRef performance9 As String, ByRef performance10 As String, ByRef performance11 As String, _
                    ByRef performance12 As String, ByRef rescuertitle As String, ByRef rescuer1 As String, ByRef rescuer2 As String, ByRef backuptitle As String, ByRef backup1 As String, ByRef backup2 As String, ByRef backup3 As String, ByRef backup4 As String, ByRef backup5 As String, ByRef restoretitle As String, ByRef restore1 As String, ByRef restore2 As String, ByRef restore3 As String, ByRef restore4 As String, ByRef restore5 As String, ByRef optiontitle As String, _
                    ByRef option1 As String, ByRef option2 As String, ByRef option3 As String, ByRef lang1 As String, ByRef resettitle As String, ByRef resetp1 As String, ByRef resetp2 As String, ByRef resetp3 As String, ByRef resetp4 As String, ByRef resetp5 As String, ByRef resetp6 As String, _
                    ByRef resetp7 As String, ByRef resetp8 As String, ByRef resetp9 As String, ByRef resetp10 As String, ByRef resetp11 As String, ByRef infotitle As String, ByRef infocredits As String, ByRef infoinformations As String, ByRef infodisclaimer As String, ByRef info1 As String, _
                    ByRef info2 As String, ByRef info3 As String, ByRef info4 As String, ByRef info5 As String, ByRef info6 As String, ByRef exittitle As String, ByRef exit1 As String, ByRef exit2 As String, ByRef versions1 As String, ByRef versions2 As String, ByRef versions3 As String, _
                    ByRef restartertitle As String, ByRef restarter1 As String, ByRef restarter2 As String, ByRef restarter3 As String, ByRef restarter4 As String, ByRef restarter5 As String, ByRef restarter6 As String, ByRef restarter7 As String, ByRef restarter8 As String, ByRef restarter9 As String, _
                    ByRef restarter10 As String, ByRef restarter11 As String, ByRef restarter12 As String)

        Dim ZipToUnpack As String = "C:\Program Files\PocketMine-ManagerServers\Languages\English\English.lang"
        Dim UnpackDirectory As String = "C:\Program Files\PocketMine-ManagerServers\Languages\English"

        Using lang As ZipFile = ZipFile.Read(ZipToUnpack)
            Dim extraction As ZipEntry
            lang.Password = "PocketMine-ManagerServers".GetHashCode
            For Each extraction In lang
                Try
                    extraction.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                Catch ex As Exception

                End Try

            Next
        End Using

        back = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords1.lang")
        changemade = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords2.lang")
        status1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords3.lang")
        version1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords4.lang")
        versionstable1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords5.lang")
        versionbeta1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords6.lang")
        versiondev1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords7.lang")
        versionsoft1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords8.lang")
        currentversion = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords9.lang")
        writepath1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords10.lang")
        writepath2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords11.lang")
        writepath3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords12.lang")

        menutitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu1.lang")
        menudev = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu2.lang")
        menu1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu3.lang")
        menu2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu4.lang")
        menu3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu5.lang")
        menu4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu6.lang")
        menu5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu7.lang")
        menu6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu8.lang")

        installertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install1.lang")
        installer1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install2.lang")
        installer2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install3.lang")
        installer3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install4.lang")

        installatortitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator0.lang")
        installator1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator1.lang")
        installator2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator2.lang")
        installator3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator3.lang")
        installator4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator4.lang")
        installator5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator5.lang")
        installator6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator6.lang")
        installator7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator7.lang")

        versions1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Versions1.lang")
        versions2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Versions2.lang")
        versions3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Versions3.lang")

        downloadertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader0.lang")
        downloader1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader1.lang")
        downloader2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader2.lang")
        downloader3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader3.lang")
        downloader4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader4.lang")
        downloader5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader5.lang")
        downloader6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader6.lang")
        downloader7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader7.lang")
        downloader8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader8.lang")
        downloader9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader9.lang")
        downloader10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader10.lang")
        downloader11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader11.lang")

        managertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager0.lang")
        manager1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager1.lang")
        manager2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager2.lang")
        manager3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager3.lang")
        manager4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager4.lang")
        manager5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager5.lang")

        openertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener0.lang")
        opener1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener1.lang")
        opener2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener2.lang")
        opener3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener3.lang")
        opener4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener4.lang")
        opener5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener5.lang")
        opener6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener6.lang")
        opener7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener7.lang")
        opener8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener8.lang")

        editortitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor0.lang")
        editor1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor1.lang")
        editor2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor2.lang")
        editor3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor3.lang")

        propertiestitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties0.lang")
        properties1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties1.lang")
        properties2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties2.lang")
        properties3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties3.lang")
        properties4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties4.lang")
        properties5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties5.lang")
        properties6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties6.lang")

        performancetitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance0.lang")
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

        rescuertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Rescuer0.lang")
        rescuer1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Rescuer1.lang")
        rescuer2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Rescuer2.lang")

        backuptitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup0.lang")
        backup1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup1.lang")
        backup2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup2.lang")
        backup3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup3.lang")
        backup4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup4.lang")
        backup5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup5.lang")

        restoretitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore0.lang")
        restore1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore1.lang")
        restore2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore2.lang")
        restore3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore3.lang")
        restore4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore4.lang")
        restore5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore5.lang")

        restartertitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter0.lang")
        restarter1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter1.lang")
        restarter2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter2.lang")
        restarter3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter3.lang")
        restarter4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter4.lang")
        restarter5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter5.lang")
        restarter6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter6.lang")
        restarter7 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter7.lang")
        restarter8 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter8.lang")
        restarter9 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter9.lang")
        restarter10 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter10.lang")
        restarter11 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter11.lang")
        restarter12 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restarter12.lang")

        optiontitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option0.lang")
        option1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option1.lang")
        option2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option2.lang")
        option3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option3.lang")

        lang1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Lang1.lang")

        resettitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp0.lang")
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

        infotitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info0.lang")
        info1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info1.lang")
        info2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info2.lang")
        info3 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info3.lang")
        info4 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info4.lang")
        info5 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info5.lang")
        info6 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info6.lang")
        infocredits = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info7.lang")
        infoinformations = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info8.lang")
        infodisclaimer = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info9.lang")

        exittitle = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit0.lang")
        exit1 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit1.lang")
        exit2 = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit2.lang")

        Using lang As New ZipFile
            lang.Password = "PocketMine-ManagerServers".GetHashCode
            lang.AddDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\English")
            lang.Save("C:\Program Files\PocketMine-ManagerServers\Languages\English\English.lang")
        End Using

        English.LanguageDeletor()

    End Sub
End Module
