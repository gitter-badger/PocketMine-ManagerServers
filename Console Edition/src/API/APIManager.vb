Imports PocketMine_ManagerServers.InstallerAPI

Namespace APIManager
    Friend Class APIManager
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

        Const API_Version As String = "1.0"
        Public Shared this As PocketMine_ManagerServers.APIManager.APIManager 'Yes, you can use "this" as "me", for example, "this.FunctionName" equals "me.FunctionName"

        Public Function getProperties()
            '    Dim motd, serverport, whitelist, achievent, spawn, maxplayers, flight, animals, mobs, gamemode, forcegamemode, _
            '    hardcore, pvp, difficulty, generator, levelname, levelseed, leveltype, enablequery, enablercon, _
            '    autosave As String

            '    Dim properties As Object = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Utils\server.properties")

            '    If My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers\Utils\server.properties") Then
            '        motd = properties.ToString.Replace("motd=", "")
            '        serverport = properties.ToString.Replace("serverport=", "")


            '    Else
            '        MsgBox("You can't use this function, because file doesn't exitst.", MsgBoxStyle.Critical)

            '    End If

            '    Return this.getProperties
            Return this.getProperties
        End Function
    End Class
End Namespace