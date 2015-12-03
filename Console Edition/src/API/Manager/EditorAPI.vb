Namespace EditorAPI
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
    Friend Class Editor
        Public Shared Function getProperties(ByVal propertiesname As String, Optional ByVal allproperties As Boolean = False)
            Dim motd, serverport, whitelist, achievent, spawn, maxplayers, flight, animals, mobs, gamemode, forcegamemode, _
            hardcore, pvp, difficulty, generator, levelname, levelseed, leveltype, enablequery, enablercon, _
            autosave As String

            Dim properties As Object = My.Computer.FileSystem.ReadAllText(System.IO.Directory.GetCurrentDirectory + "\Utils\server.properties")

            If My.Computer.FileSystem.FileExists(System.IO.Directory.GetCurrentDirectory + "\Utils\server.properties") Then
                motd = properties.ToString.Replace("motd=", "")
                serverport = properties.ToString.Replace("server-port=", "")
                whitelist = properties.ToString.Replace("white-list=", "")
                achievent = properties.ToString.Replace("announce-player-achievements=", "")
                spawn = properties.ToString.Replace("spawn-protection=", "")
                maxplayers = properties.ToString.Replace("max-players=", "")
                flight = properties.ToString.Replace("allow-flight=", "")
                animals = properties.ToString.Replace("spawn-animals=", "")
                mobs = properties.ToString.Replace("spawn-mobs=", "")
                gamemode = properties.ToString.Replace("gamemode=", "")
                forcegamemode = properties.ToString.Replace("force-gamemode=", "")
                hardcore = properties.ToString.Replace("hardcore=", "")
                pvp = properties.ToString.Replace("pvp=", "")
                difficulty = properties.ToString.Replace("difficulty=", "")
                generator = properties.ToString.Replace("generator-settings=", "")
                levelname = properties.ToString.Replace("level-name=", "")
                levelseed = properties.ToString.Replace("level-seed=", "")
                leveltype = properties.ToString.Replace("level-type=", "")
                enablequery = properties.ToString.Replace("enable-query=", "")
                enablercon = properties.ToString.Replace("enable-rcon=", "")
                rconpassword = properties.ToString.Replace("rcon.password=", "")
                autosave = properties.ToString.Replace("auto-save=", "")

            Else
                MsgBox("You can't use this function, because file doesn't exitst.", MsgBoxStyle.Critical)

            End If

            Return EditorAPI.Editor.getProperties(properties, allproperties)
        End Function

        Public Shared Function changePerformanceStatus()



            Return EditorAPI.Editor.changePerformanceStatus()
        End Function

    End Class

End Namespace