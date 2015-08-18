Module LanguageLoader
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
    Sub LanguageLoader()

        'Language Folders
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Afrikaans")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Arabic")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Catalan")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Chinese(Traditional)")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Czech")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Danish")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Dutch")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\English")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Finnish")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\French")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\German")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Greek")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Hebrew")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Hungarian")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Italian")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Japanese")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Korean")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Norwegian")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Polish")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Portuguese")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Portuguese(Brazilian)")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Romanian")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Russian")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Serbian(Cyrillic)")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Spanish")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Swedish")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Turkish")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Ukrainian")
        My.Computer.FileSystem.CreateDirectory("C:\Program Files\PocketMine-ManagerServers\Languages\Vietnamese")

        'Language File's
        English.English()
        Italian.Italian()

    End Sub
End Module
