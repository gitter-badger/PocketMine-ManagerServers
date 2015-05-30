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
        Dim back, changemade As String

        back = "Back"
        changemade = "Changes made! Press ENTER to return to menu."

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

        '-----#Installtor
        Dim installator1, installator2, installator3, installator4, installatorversion, installatorstatus, installatorstable, installatorbeta, installatordev, installatorsoft As String

        installatorstatus = "Status"
        installatorversion = "Version"
        installatorstable = "Version Stable"
        installatorbeta = "Version Beta"
        installatordev = "Version Dev"
        installatorsoft = "Version Soft"
        installator1 = "What kind of version you want to install?"
        installator2 = "Which version do you want to install?:"
        installator3 = "Starting installation..."
        installator4 = "Installation complete"


        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Languages\English\langeng.pm", langeng, True)

    End Sub
End Module
