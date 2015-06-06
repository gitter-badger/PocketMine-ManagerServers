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

        Dim langeng As String

        '#UniqueWords
        Dim back, changemade, status, version, versionstable, versionbeta, versiondev, versionsoft, currentversion, writepath1, writepath2 As String

        back = "Back"
        changemade = "Changes made! Press ENTER to return to menu."
        status = "Status"
        version = "Version"
        versionstable = "Version Stable"
        versionbeta = "Version Beta"
        versiondev = "Version Dev"
        versionsoft = "Version Soft"
        currentversion = "Current Versions:"
        writepath1 = "Write the folder path of the {0} server, example 'C:\PocketMine-MP': "
        writepath2 = "ERROR! Insert a valid path!"

        '#Main Menu
        Dim menudev, menutitle, menu1, menu2, menu3, menu4, menu5, menu6 As String

        menutitle = "Main Menu"
        menudev = "                                                           Version: {0} #BUILD {1}"
        menu1 = "Install PocketMine-MP"
        menu2 = "Manage Servers"
        menu3 = "Program Options"
        menu4 = "Informations"
        menu5 = "Exit"
        menu6 = "What would you like to do?: "

        '#Install PocketMine-MP
        Dim installertitle, installer1, installer2, installer3 As String

        installertitle = "Initialize PocketMine-MP"
        installer1 = "Download"
        installer2 = "Install"
        installer3 = "Choose what do you want to do: "

        '--------#ManagerInstaller
        '-----------------#Installator
        Dim installator1, installator2, installator3, installator4, installator5 As String

        installator1 = "What kind of version you want to install?"
        installator2 = "Which version do you want to install?:"
        installator3 = "Starting installation..."
        installator4 = "Installation complete"
        installator5 = "Installer not found! Please download the installer!"

        '-----------------#Downloader
        Dim downloader1, downloader2, downloader3, downloader4, downloader5, downloader6, downloader7, downloader8, downloader9 As String

        downloader1 = "What kind of version you want to download?"
        downloader2 = "Which version do you want to download?:"
        downloader3 = "You have already downloaded this installer!"
        downloader4 = "Downloading Installer...!"
        downloader5 = "Installer downloaded! Press ENTER to continue."
        downloader6 = "You have already downloaded this file!"
        downloader7 = "Downloading Phar File...!"
        downloader8 = "Phar file downloaded! Press ENTER to continue."
        downloader9 = "Please indicate what the link to the folder where you downloaded the downloader , example 'C:\PocketMine-MP': "

        '#ManageServers
        Dim manager1, manager2, manager3 As String
        manager1 = "Open [Server/Folder]"
        manager2 = "Edit server performance."
        manager3 = "Backup/Restore servers."

        '-----------#Opener
        Dim opener1, opener2, opener3, opener4, opener5, opener6, opener7 As String
        opener1 = "Open"
        opener2 = "What do you want to do? "
        opener3 = "Reading your file(s)..."
        opener4 = "File(s) succefully read!"
        opener5 = "Opening your server(s)..."
        opener6 = "Loading {0} server!"
        opener7 = "Wait 3 seconds to load each server!"

        '-----------#Editor
        Dim editor1, editor2, editor3 As String

        editor1 = "Edit Server Properties"
        editor2 = "Edit Performance Server"
        editor3 = "What do you want to edit? "

        '-----------------#EditProperties
        Dim properties1, properties2, properties3, properties4, properties5, properties6, properties7 As String

        properties1 = "Checking path(s)..."
        properties2 = "Path(s) found!"
        properties3 = "I'm making your server.properties, wait..."
        properties4 = "Server.properties created!"
        properties5 = "Do you want to replace the old and new properties? (This will create a backup file) <Y/N>: "
        properties6 = "Path(s) not found!"

        '----------------#EditPerformance
        Dim performance1, performance2, performance3, performance4, performance5, performance6, performance7, performance8, performance9, performance10, performance11, performance12, performance13 As String

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
        performance13 = "Changes made! Press ENTER to return to menu."

        '#Options
        Dim option1, option2, option3 As String

        option1 = "Language"
        option2 = "Reset Program"
        option3 = "Choose the option: "

        '------------#ChangeLanguages
        Dim lang1 As String

        lang1 = "Please select an avaiable language!"

        '------------#ResetProgram
        Dim resetp1, resetp2, resetp3, resetp4, resetp5, resetp6, resetp7, resetp8, resetp9, resetp10, resetp11 As String

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

        '#Informations
        Dim info1, info2, info3, info4, info5, info6 As String

        info1 = "License"
        info2 = "Credits"
        info3 = "More Informations"
        info4 = "Disclaimer"
        info5 = "Choose information: "
        info6 = "ERROR! Bad Installation! License not found!"

        '#Exit
        Dim exit1, exit2 As String

        exit1 = "Are you sure you want to quit? <Y/N>: "
        exit2 = "See you soon!"

        'My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\langeng.lang", langeng, True)

    End Sub
End Module
