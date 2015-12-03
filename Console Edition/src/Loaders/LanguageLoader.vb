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
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Afrikaans")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Arabic")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Catalan")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Chinese(Traditional)")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Czech")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Danish")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Dutch")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\English")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Finnish")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\French")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\German")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Greek")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Hebrew")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Hungarian")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Italian")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Japanese")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Korean")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Norwegian")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Polish")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Portuguese")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Portuguese(Brazilian)")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Romanian")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Russian")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Serbian(Cyrillic)")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Spanish")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Swedish")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Turkish")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Ukrainian")
        My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\Languages\Vietnamese")

        'Language File's
        English.English()
        Italian.Italian()

    End Sub
End Module
