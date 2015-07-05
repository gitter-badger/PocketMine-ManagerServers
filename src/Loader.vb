Module Loader
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
    Sub Loader(ByRef checklanguage As Object, ByRef versionstatus As String(), ByRef dirinstallations As Object, ByRef checkinstallations As Object(), ByRef checkdownloads As Object(), ByVal checkperformance As Object, ByRef checknameserver As Object, ByRef nameservers As String(), ByRef performancestatus As String(), ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef checknservers As Object, ByRef checkfolderinstallation As Object, _
               ByRef dirpath As Object, ByRef dirdata As Object, ByRef dirservername As Object, ByRef dirperformance As Object, ByRef dirutils As Object, ByRef checklicense As Object, ByRef downloadstatus As String(), ByRef installationstatus As String(), ByRef backupstatus As String(), ByRef dirlanguages As Object, ByRef dirbackups As Object, ByRef changelang As Boolean, ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable1 As String, ByRef versionbeta1 As String, ByRef versiondev1 As String, ByRef versionsoft1 As String, ByRef currentversion As String, ByRef writepath1 As String, ByRef writepath2 As String, ByRef writepath3 As String, _
                    ByRef menudev As String, ByRef menutitle As String, ByRef menu1 As String, ByRef menu2 As String, ByRef menu3 As String, ByRef menu4 As String, ByRef menu5 As String, ByRef menu6 As String, ByRef installertitle As String, ByRef installer1 As String, ByRef installer2 As String, ByRef installer3 As String, _
                    ByRef installatortitle As String, ByRef installator1 As String, ByRef installator2 As String, ByRef installator3 As String, ByRef installator4 As String, ByRef installator5 As String, ByRef installator6 As String, ByRef installator7 As String, ByRef downloadertitle As String, ByRef downloader1 As String, ByRef downloader2 As String, ByRef downloader3 As String, ByRef downloader4 As String, ByRef downloader5 As String, ByRef downloader6 As String, _
                    ByRef downloader7 As String, ByRef downloader8 As String, ByRef downloader9 As String, ByRef downloader10 As String, ByRef downloader11 As String, ByRef managertitle As String, ByRef manager1 As String, ByRef manager2 As String, ByRef manager3 As String, ByRef manager4 As String, ByRef openertitle As String, ByRef opener1 As String, ByRef opener2 As String, ByRef opener3 As String, ByRef opener4 As String, ByRef opener5 As String, ByRef opener6 As String, _
                    ByRef opener7 As String, ByRef opener8 As String, ByRef editortitle As String, ByRef editor1 As String, ByRef editor2 As String, ByRef editor3 As String, ByRef propertiestitle As String, ByRef properties1 As String, ByRef properties2 As String, ByRef properties3 As String, ByRef properties4 As String, ByRef properties5 As String, ByRef properties6 As String, ByRef performancetitle As String, ByRef performance1 As String, _
                    ByRef performance2 As String, ByRef performance3 As String, ByRef performance4 As String, ByRef performance5 As String, ByRef performance6 As String, ByRef performance7 As String, ByRef performance8 As String, ByRef performance9 As String, ByRef performance10 As String, ByRef performance11 As String, _
                    ByRef performance12 As String, ByRef rescuertitle As String, ByRef rescuer1 As String, ByRef rescuer2 As String, ByRef backuptitle As String, ByRef backup1 As String, ByRef backup2 As String, ByRef backup3 As String, ByRef restoretitle As String, ByRef restore1 As String, ByRef restore2 As String, ByRef restore3 As String, ByRef restore4 As String, ByRef optiontitle As String, _
                    ByRef option1 As String, ByRef option2 As String, ByRef option3 As String, ByRef lang1 As String, ByRef resettitle As String, ByRef resetp1 As String, ByRef resetp2 As String, ByRef resetp3 As String, ByRef resetp4 As String, ByRef resetp5 As String, ByRef resetp6 As String, _
                    ByRef resetp7 As String, ByRef resetp8 As String, ByRef resetp9 As String, ByRef resetp10 As String, ByRef resetp11 As String, ByRef infotitle As String, ByRef infocredits As String, ByRef infoinformations As String, ByRef infodisclaimer As String, ByRef info1 As String, _
                    ByRef info2 As String, ByRef info3 As String, ByRef info4 As String, ByRef info5 As String, ByRef info6 As String, ByRef exittitle As String, ByRef exit1 As String, ByRef exit2 As String, ByRef versions1 As String, ByRef versions2 As String, ByRef versions3 As String)

        Dim quit As String

        checklicense = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\LICENSE.pdf")

        checknservers = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

        checklanguage = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm")

        For i = 1 To 10
            checkperformance(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm")
            checkinstallations(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm")
            checkdownloads(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm")

        Next

        checkfolderinstallation = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers")
        dirpath = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Path")
        dirservername = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\ServersName")
        dirdata = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Data")
        dirperformance = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Performance")
        dirutils = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Utils")
        dirinstallations = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Installations")
        dirlanguages = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Languages")
        dirbackups = My.Computer.FileSystem.DirectoryExists("C:\Program Files\PocketMine-ManagerServers\Backups")
        Checking(checknameserver, checkpath)

        If dirpath And dirservername And checkfolderinstallation And dirperformance And dirdata And dirutils And dirlanguages And dirinstallations And dirbackups And checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) _
             And checkperformance(0) And checkperformance(1) And checkperformance(2) And checkperformance(3) And checkperformance(4) And checkperformance(5) And checkperformance(6) And checkperformance(7) And checkperformance(8) And checkperformance(9) And checkinstallations(0) _
             And checkinstallations(1) And checkinstallations(2) And checkinstallations(3) And checkinstallations(4) And checkinstallations(5) And checkinstallations(6) And checkinstallations(7) And checkinstallations(8) And checkinstallations(9) And checkdownloads(0) And checkdownloads(1) _
             And checkdownloads(2) And checkdownloads(3) And checkdownloads(4) And checkdownloads(5) And checkdownloads(6) And checkdownloads(7) And checkdownloads(8) And checkdownloads(9) Then

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
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Installations") 'Create Folder Installations
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages") 'Create Folder Languages
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Backups") 'Create Folder Backups
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Backups\Status") 'Create Folder Backups -> Status
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Backups\Servers") 'Create Folder Backups -> Servers

            For i = 1 To 10
                performancestatus(i - 1) = "Personal"
                downloadstatus(i - 1) = "Not Downloaded"
                installationstatus(i - 1) = "Not Installed"
                versionstatus(i - 1) = "No version"
                backupstatus(i - 1) = "Not Backuped"
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Performance\PerformanceStatus_" + Convert.ToString(i) + ".pm", performancestatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\DownloadStatus_" + Convert.ToString(i) + ".pm", downloadstatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\InstallationStatus_" + Convert.ToString(i) + ".pm", installationstatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Installations\VersionStatus_" + Convert.ToString(i) + ".pm", versionstatus(i - 1), True)
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Backups\Status\BackupStatus_" + Convert.ToString(i) + ".pm", backupstatus(i - 1), True)
            Next

            For i = 1 To 100
                Console.WriteLine("Loading resource {0}%", i)
            Next

            LanguageLoader.LanguageLoader()

        End If

        If checklanguage Then 'Language Selector
            quit = "N"

        Else

            changelang = False

            LanguagesSelector.LanguagesSelector(back, checklanguage, changelang, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3, menudev, menutitle, _
                              menu1, menu2, menu3, menu4, menu5, menu6, installertitle, installer1, installer2, installer3, installatortitle, installator1, installator2, installator3, installator4, _
                              installator5, installator6, installator7, downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11, managertitle, manager1, manager2, manager3, _
                              manager4, openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8, editortitle, editor1, editor2, editor3, propertiestitle, properties1, properties2, properties3, properties4, properties5, _
                              properties6, performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, _
                              performance12, rescuertitle, rescuer1, rescuer2, backuptitle, backup1, backup2, backup3, restoretitle, restore1, restore2, restore3, restore4, optiontitle, option1, option2, option3, lang1, _
                              resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11, _
                              infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6, exittitle, exit1, exit2, versions1, versions2, versions3)

        End If
    End Sub

End Module
