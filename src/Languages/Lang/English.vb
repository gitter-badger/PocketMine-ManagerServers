Module English
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

    Sub English()

        '#UniqueWords
        Dim back, changemade, status1, version1, versionstable1, versionbeta1, versiondev1, versionsoft1, currentversion, writepath1, writepath2, writepath3 As String

        back = "Back"
        changemade = "Changes made! Press ENTER to return to menu."
        status1 = "Status"
        version1 = "Version"
        versionstable1 = "Version Stable"
        versionbeta1 = "Version Beta"
        versiondev1 = "Version Dev"
        versionsoft1 = "Version Soft"
        currentversion = "Current Versions:"
        writepath1 = "Write the folder path of"
        writepath2 = ", example 'C:\PocketMine-MP': "
        writepath3 = "ERROR! Insert a valid path!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords1.lang", back, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords2.lang", changemade, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords3.lang", status1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords4.lang", version1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords5.lang", versionstable1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords6.lang", versionbeta1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords7.lang", versiondev1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords8.lang", versionsoft1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords9.lang", currentversion, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords10.lang", writepath1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords11.lang", writepath2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\UniqueWords12.lang", writepath3, True)

        '#Main Menu
        Dim menudev, menutitle, menu1, menu2, menu3, menu4, menu5, menu6 As String

        menutitle = "-------------------------------<Main Menu>--------------------------------------" '80 characters
        menudev = "                                                           Version: 1.2 #BUILD 2"
        menu1 = "Install PocketMine-MP"
        menu2 = "Manage Servers"
        menu3 = "Program Options"
        menu4 = "Informations"
        menu5 = "Exit"
        menu6 = "What would you like to do?: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu1.lang", menutitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu2.lang", menudev, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu3.lang", menu1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu4.lang", menu2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu5.lang", menu3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu6.lang", menu4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu7.lang", menu5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Menu8.lang", menu6, True)

        '#Install PocketMine-MP
        Dim installertitle, installer1, installer2, installer3 As String

        installertitle = "--------------------------<Initialize PocketMine-MP>----------------------------"
        installer1 = "Download"
        installer2 = "Install"
        installer3 = "Choose what do you want to do: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install1.lang", installertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install2.lang", installer1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install3.lang", installer2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Install4.lang", installer3, True)

        '--------#ManagerInstaller
        '-----------------#Installator
        Dim installatortitle, installator1, installator2, installator3, installator4, installator5, installator6, installator7 As String

        installatortitle = "---------------------------<Install PocketMine-MP>------------------------------"
        installator1 = "What kind of version you want to install? "
        installator2 = "Which version do you want to install?: "
        installator3 = "Starting installation..."
        installator4 = "Installation complete"
        installator5 = "Installer not found! Please download the installer!"
        installator6 = "Installed"
        installator7 = "Not Installed"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator0.lang", installatortitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator1.lang", installator1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator2.lang", installator2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator3.lang", installator3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator4.lang", installator4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator5.lang", installator5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator6.lang", installator6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Installator7.lang", installator7, True)

        '------------------------#Versions(Beta, Dev, Soft)

        Dim versions1, versions2, versions3 As String

        versions1 = "Are you sure you want to replace the file phar with the current one? (This will create a copy)"
        versions2 = "Phar file not found!"
        versions3 = "Please download the file."

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Versions1.lang", versions1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Versions2.lang", versions2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Versions3.lang", versions3, True)

        '-----------------#Downloader
        Dim downloadertitle, downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9, downloader10, downloader11 As String

        downloadertitle = "---------------------------<Download PocketMine-MP>-----------------------------"
        downloader1 = "What kind of version you want to download?"
        downloader2 = "Which version do you want to download?:"
        downloader3 = "You have already downloaded this installer!"
        downloader4 = "Downloading Installer...!"
        downloader5 = "Installer downloaded! Press ENTER to continue."
        downloader6 = "You have already downloaded this file!"
        downloader7 = "Downloading Phar File...!"
        downloader8 = "Phar file downloaded! Press ENTER to continue."
        downloader9 = "Please indicate what the link to the folder where you downloaded the installer , example 'C:\PocketMine-MP': "
        downloader10 = "Downloaded"
        downloader11 = "Not Downloaded"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader0.lang", downloadertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader1.lang", downloader1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader2.lang", downloader2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader3.lang", downloader3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader4.lang", downloader4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader5.lang", downloader5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader6.lang", downloader6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader7.lang", downloader7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader8.lang", downloader8, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader9.lang", downloader9, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader10.lang", downloader10, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Downloader11.lang", downloader11, True)


        '#ManageServers
        Dim managertitle, manager1, manager2, manager3, manager4 As String

        managertitle = "-------------------------------<Manage Servers>---------------------------------"
        manager1 = "Open [Server/Folder]"
        manager2 = "Edit server performance."
        manager3 = "Backup/Restore servers."
        manager4 = "Select option: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager0.lang", managertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager1.lang", manager1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager2.lang", manager2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager3.lang", manager3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Manager4.lang", manager4, True)

        '-----------#Opener
        Dim openertitle, opener1, opener2, opener3, opener4, opener5, opener6, opener7, opener8 As String

        openertitle = "-----------------------------------<Opener>-------------------------------------"
        opener1 = "Open"
        opener2 = "What do you want to do? "
        opener3 = "Reading your file(s)..."
        opener4 = "File(s) succefully read!"
        opener5 = "Opening your server(s)..."
        opener6 = "Loading"
        opener7 = "Wait 3 seconds to load each server!"
        opener8 = "Folders"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener0.lang", openertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener1.lang", opener1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener2.lang", opener2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener3.lang", opener3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener4.lang", opener4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener5.lang", opener5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener6.lang", opener6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener7.lang", opener7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Opener8.lang", opener8, True)

        '-----------#Editor
        Dim editortitle, editor1, editor2, editor3 As String

        editortitle = "------------------------------------<Editor>------------------------------------"
        editor1 = "Edit Server Properties"
        editor2 = "Edit Performance Server"
        editor3 = "What do you want to edit? "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor0.lang", editortitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor1.lang", editor1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor2.lang", editor2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Editor3.lang", editor3, True)

        '-----------------#EditProperties
        Dim propertiestitle, properties1, properties2, properties3, properties4, properties5, properties6 As String

        propertiestitle = "--------------------------<Edit Server Properties>------------------------------"
        properties1 = "Checking path(s)..."
        properties2 = "Path(s) found!"
        properties3 = "I'm making your server.properties, wait..."
        properties4 = "Server.properties created!"
        properties5 = "Do you want to replace the old and new properties? (This will create a backup file) <Y/N>: "
        properties6 = "Path(s) not found!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties0.lang", propertiestitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties1.lang", properties1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties2.lang", properties2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties3.lang", properties3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties4.lang", properties4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties5.lang", properties5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Properties6.lang", properties6, True)

        '----------------#EditPerformance
        Dim performancetitle, performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, performance12 As String

        performancetitle = "--------------------------------<Performance>-----------------------------------"
        performance1 = "Your current performance are: "
        performance2 = "What features do you want to assign to your servers?"
        performance3 = "High"
        performance4 = "Medium"
        performance5 = "Low"
        performance6 = "Choose features: "
        performance7 = "If you choose this option, you'll need to have a PC that supports it, so if you do not own it is strongly advised not to use it."
        performance8 = "Do you want to continue? <Y/N>: "
        performance9 = "If you choose this option, you'll need a PC not too handsome, it is suitable for handling small servers."
        performance10 = "If you choose this option, you'll need a PC not too handsome, it is suitable to manage servers with friends."
        performance11 = "On which server you want to apply this setting? "
        performance12 = "I'm making the changes..."

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance0.lang", performancetitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance1.lang", performance1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance2.lang", performance2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance3.lang", performance3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance4.lang", performance4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance5.lang", performance5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance6.lang", performance6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance7.lang", performance7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance8.lang", performance8, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance9.lang", performance9, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance10.lang", performance10, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance11.lang", performance11, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Performance12.lang", performance12, True)

        '-----------#Rescuer
        Dim rescuertitle, rescuer1, rescuer2 As String

        rescuertitle = "--------------------------<Backup/Restore Servers>------------------------------"
        rescuer1 = "Backup servers"
        rescuer2 = "Restore servers"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Rescuer0.lang", rescuertitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Rescuer1.lang", rescuer1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Rescuer2.lang", rescuer2, True)

        '----------------#Backup
        Dim backuptitle, backup1, backup2, backup3, backup4, backup5 As String

        backuptitle = "--------------------------------<Backup Server>---------------------------------"
        backup1 = "Choose which server do you want to backup: "
        backup2 = "I'm doing the backup, please wait!"
        backup3 = "DONE! Press ENTER to continue."
        backup4 = "There is already another backup of this server, do you want to overwrite it? "
        backup5 = "You can find your backup in 'C:\Program Files\PocketMine-ManagerServers\Backups\', do you want to open this folder?"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup0.lang", backuptitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup1.lang", backup1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup2.lang", backup2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup3.lang", backup3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup4.lang", backup4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Backup5.lang", backup5, True)

        '----------------#Restore
        Dim restoretitle, restore1, restore2, restore3, restore4, restore5 As String

        restoretitle = "-------------------------------<Restore Server>---------------------------------"
        restore1 = "Choose which server do you want to restore: "
        restore2 = "I'm extracting your server, please wait!"
        restore3 = "DONE! Press ENTER to continue."
        restore4 = "Error, first do a backup of a your server!"
        restore5 = "You can find your backup in 'C:\Program Files\PocketMine-ManagerServers\Backups\', do you want to open this folder?"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore0.lang", restoretitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore1.lang", restore1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore2.lang", restore2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore3.lang", restore3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore4.lang", restore4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Restore5.lang", restore5, True)

        '#Options
        Dim optiontitle, option1, option2, option3 As String

        optiontitle = "------------------------------<Program Options>---------------------------------"
        option1 = "Language"
        option2 = "Reset Program"
        option3 = "Choose the option: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option0.lang", optiontitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option1.lang", option1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option2.lang", option2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Option3.lang", option3, True)

        '------------#ChangeLanguages
        Dim lang1 As String

        lang1 = "Please select an avaiable language!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Lang1.lang", lang1, True)

        '------------#ResetProgram
        Dim resettitle, resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11 As String

        resettitle = "-------------------------------<Reset Program>----------------------------------"
        resetp1 = "Reset data of servers (Only Programm)"
        resetp2 = "Reset data of servers (Only your specified server)"
        resetp3 = "Reset all data/folders of programm"
        resetp4 = "Choose what do you want to reset: "
        resetp5 = "Are you sure to want to reset data of servers (Only Program)? <Y/N>: "
        resetp6 = "Closing program..."
        resetp7 = "There are no files to be deleted!"
        resetp8 = "WARNING! Are you sure to want to reset data of servers (Only your specified server)? <Y/N>: "
        resetp9 = "Please, before configuring the server(s)."
        resetp10 = "There is no path to be deleted!"
        resetp11 = "Are you sure to want to reset all data/folders of program (It delete folders of program)? <Y/N>: "

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp0.lang", resettitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp1.lang", resetp1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp2.lang", resetp2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp3.lang", resetp3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp4.lang", resetp4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp5.lang", resetp5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp6.lang", resetp6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp7.lang", resetp7, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp8.lang", resetp8, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp9.lang", resetp9, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp10.lang", resetp10, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Resetp11.lang", resetp11, True)

        '#Informations
        Dim infotitle, infocredits, infoinformations, infodisclaimer, info1, info2, info3, info4, info5, info6 As String

        infotitle = "--------------------------------<Informations>----------------------------------"
        infocredits = "-----------------------------------<Credits>------------------------------------"
        infoinformations = "-----------------------------<More Informations>--------------------------------"
        infodisclaimer = "---------------------------------<Disclaimer>-----------------------------------"
        info1 = "License"
        info2 = "Credits"
        info3 = "More Informations"
        info4 = "Disclaimer"
        info5 = "Choose information: "
        info6 = "ERROR! Bad Installation! License not found!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info0.lang", infotitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info1.lang", info1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info2.lang", info2, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info3.lang", info3, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info4.lang", info4, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info5.lang", info5, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info6.lang", info6, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info7.lang", infocredits, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info8.lang", infoinformations, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Info9.lang", infodisclaimer, True)

        '#Exit
        Dim exittitle, exit1, exit2 As String

        exittitle = "----------------------------------<Exit>----------------------------------------"
        exit1 = "Are you sure you want to quit? <Y/N>: "
        exit2 = "See you soon!"

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit0.lang", exittitle, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit1.lang", exit1, True)
        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\Exit2.lang", exit2, True)

    End Sub
End Module
