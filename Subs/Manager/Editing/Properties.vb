Imports System.Text

Module Properties
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

    Public rconpassword As String

    Sub Properties(ByRef checkpath As Object(), ByRef path As String(), ByRef nservers As Integer, ByRef numberservers As String(), ByRef checknameserver As Object())

        Dim motd, serverport, whitelist, achievent, spawn, maxplayers, flight, animals, mobs, gamemode, forcegamemode, _
            hardcore, pvp, difficulty, generator, levelname, levelseed, leveltype, enablequery, enablercon, _
            autosave As String

        'Random Generation (Casual Variables)
        Dim rcongenerator As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        '-------------------------------------

        Dim propertiesfile, confirmedit, replaceproperty As String

        Dim checkproperty, checkproperty2 As Object

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.WriteLine("--------------------------<Edit Server Properties>------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Checking path(s)...")

        Checking(checknameserver, checkpath)

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
            Do
                Console.WriteLine("Path(s) found!")
                Console.WriteLine("#Properties Config file")
                Console.WriteLine("Sun May 3 13:20:31 AZOST 2015")

                Console.Write("Motd <by default Server Minecraft PE>: ")
                motd = Console.ReadLine.ToLower

                If motd = "" Then
                    motd = "Server Minecraft PE"
                End If

                Console.Write("Server port <by default 19132>: ")
                serverport = Console.ReadLine.ToLower

                If serverport = "" Then
                    serverport = "19132"
                End If

                Do
                    Console.Write("White-list <on/off>: ")
                    whitelist = Console.ReadLine.ToLower

                    If whitelist = "" Then
                        whitelist = "on"
                    End If

                Loop While whitelist <> "on" And whitelist <> "off"

                Do
                    Console.Write("Announce player achivements <on/off>: ")
                    achievent = Console.ReadLine.ToLower

                    If achievent = "" Then
                        achievent = "on"
                    End If

                Loop While achievent <> "on" And achievent <> "off"

                Console.Write("Spawn Protection <by default is 20>: ")
                spawn = Console.ReadLine.ToLower

                If spawn = "" Then
                    spawn = "20"
                End If

                Console.Write("Max Players <by default is 20>: ")
                maxplayers = Console.ReadLine.ToLower

                If maxplayers = "" Then
                    maxplayers = "20"
                End If

                Do
                    Console.Write("Allow flight <on/off>: ")
                    flight = Console.ReadLine.ToLower

                    If flight = "" Then
                        flight = "off"
                    End If

                Loop While flight <> "on" And flight <> "off"

                Do
                    Console.Write("Spawn Animals <on/off>: ")
                    animals = Console.ReadLine.ToLower

                    If animals = "" Then
                        animals = "off"
                    End If

                Loop While animals <> "on" And animals <> "off"

                Do
                    Console.Write("Spawn mobs <on/off>: ")
                    mobs = Console.ReadLine.ToLower

                    If mobs = "" Then
                        mobs = "off"
                    End If

                Loop While mobs <> "on" And mobs <> "off"

                Console.Write("Gamemode [0/1/2] <by default is 0>: ")
                gamemode = Console.ReadLine.ToLower

                If gamemode = "" Then
                    gamemode = "0"
                End If

                Do
                    Console.Write("Force gamemode <on/off>: ")
                    forcegamemode = Console.ReadLine.ToLower

                    If forcegamemode = "" Then
                        forcegamemode = "off"
                    End If

                Loop While forcegamemode <> "on" And forcegamemode <> "off"

                Do
                    Console.Write("Hardcore <on/off>: ")
                    hardcore = Console.ReadLine.ToLower

                    If hardcore = "" Then
                        hardcore = "off"
                    End If

                Loop While hardcore <> "on" And hardcore <> "off"

                Do
                    Console.Write("Pvp <on/off>: ")
                    pvp = Console.ReadLine.ToLower

                    If pvp = "" Then
                        pvp = "on"
                    End If

                Loop While pvp <> "on" And pvp <> "off"

                Console.Write("Difficulty [0/1/2] <by default is 1>: ")
                difficulty = Console.ReadLine.ToLower

                If difficulty = "" Then
                    difficulty = "1"
                End If

                Console.Write("Generator-Settings: ")
                generator = Console.ReadLine

                Console.Write("Level name <by default is world>: ")
                levelname = Console.ReadLine

                If levelname = "" Then
                    levelname = "world"
                End If

                Console.Write("Level seed: ")
                levelseed = Console.ReadLine.ToLower

                Console.Write("Level type <by default is DEFAULT>: ")
                leveltype = Console.ReadLine.ToUpper

                If leveltype = "" Then
                    leveltype = "DEFAULT"
                End If

                Do
                    Console.Write("Enable query <on/off>: ")
                    enablequery = Console.ReadLine.ToLower

                    If enablequery = "" Then
                        enablequery = "off"
                    End If

                Loop While enablequery <> "on" And enablequery <> "off"

                Do
                    Console.Write("Enable rcon <on/off>: ")
                    enablercon = Console.ReadLine.ToLower

                    If enablercon = "" Then
                        enablercon = "on"

                    End If

                    If enablercon = "on" Then
                        Console.Write("Rcon password: ")
                        rconpassword = Console.ReadLine.ToLower

                        If rconpassword = "" Then
                            For i = 1 To 10
                                Dim idx As Integer = r.Next(0, 35)
                                sb.Append(rcongenerator.Substring(idx, 1))

                            Next

                            rconpassword = sb.ToString()

                        End If

                    End If
                Loop While enablercon <> "on" And enablercon <> "off"

                Do
                    Console.Write("Auto-Save <on/off>: ")
                    autosave = Console.ReadLine.ToLower

                    If autosave = "" Then
                        autosave = "on"
                    End If

                Loop While autosave <> "on" And autosave <> "off"

                Do
                    Console.Write("Do you want to confirm your choices? <Y/N>: ")
                    confirmedit = Console.ReadLine.ToUpper

                    If confirmedit = "Y" Then
                        Console.Clear()
                        Console.Clear()
                        Console.WriteLine("========================<PocketMine Manager Servers>============================")
                        Console.WriteLine("--------------------------<Edit Server Properties>------------------------------")
                        Console.WriteLine("I'm making your server.properties, wait...")

                        propertiesfile =
                        "#Properties Config file" + vbCrLf + _
                        "Sun May 3 17:16:00 AZOST 2015" + vbCrLf + _
                        "motd=" + motd + vbCrLf + _
                        "server-port=" + serverport + vbCrLf + _
                        "white-list=" + whitelist + vbCrLf + _
                        "announce-player-achievements=" + achievent + vbCrLf + _
                        "spawn-protection=" + spawn + vbCrLf + _
                        "max-players=" + maxplayers + vbCrLf + _
                        "allow-flight=" + flight + vbCrLf + _
                        "spawn-animals=" + animals + vbCrLf + _
                        "spawn-mobs=" + mobs + vbCrLf + _
                        "gamemode=" + gamemode + vbCrLf + _
                        "force-gamemode=" + forcegamemode + vbCrLf + _
                        "hardcore=" + hardcore + vbCrLf + _
                        "pvp=" + pvp + vbCrLf + _
                        "difficulty=" + difficulty + vbCrLf + _
                        "generator-settings=" + generator + vbCrLf + _
                        "level-name=" + levelname + vbCrLf + _
                        "level-seed=" + levelseed + vbCrLf + _
                        "level-type=" + leveltype + vbCrLf + _
                        "enable-query=" + enablequery + vbCrLf + _
                        "enable-rcon=" + enablercon + vbCrLf + _
                        "rcon.password=" + rconpassword + vbCrLf + _
                        "auto-save=" + autosave

                        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Utils\server.properties", propertiesfile, True)

                        Console.WriteLine()
                        Console.WriteLine("Server.properties created!")

                        Do
                            Console.Write("Do you want to replace the old and new properties? (This will create a backup file) <Y/N>: ")
                            replaceproperty = Console.ReadLine.ToUpper


                            If replaceproperty = "Y" Then
                                For i = 1 To nservers

                                    checkproperty = My.Computer.FileSystem.FileExists(path(i - 1) + "\servers.properties")
                                    checkproperty2 = My.Computer.FileSystem.FileExists(path(i - 1) + "\servers.properties_OLD")

                                    If checkproperty Then
                                        If checkproperty2 Then
                                            My.Computer.FileSystem.DeleteFile(path(i - 1) + "\server.properties_OLD.yml")
                                            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\server.properties", path(i - 1) + "\server.properties", overwrite:=True)
                                            My.Computer.FileSystem.RenameFile(path(i - 1) + "\server.properties", "server.properties_OLD.yml")

                                        Else
                                            My.Computer.FileSystem.RenameFile(path(i - 1) + "\server.properties", "server.properties_OLD")
                                            My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\server.properties", path(i - 1) + "\server.properties", overwrite:=True)

                                        End If

                                    Else
                                        My.Computer.FileSystem.CopyFile("C:\Program Files\PocketMine-ManagerServers\Utils\server.properties", path(i - 1) + "\server.properties", overwrite:=True)

                                    End If
                                Next

                            End If

                        Loop While replaceproperty <> "Y" And replaceproperty <> "N"
                    End If
                Loop While confirmedit <> "Y" And confirmedit <> "N"
            Loop While confirmedit = "N"

        Else
            Console.WriteLine("Path(s) not found!")

            For i = 1 To nservers
                Do
                    Console.Write("Write the folder path of the {0} server, example 'C:\PocketMine-MP': ", numberservers(i - 1))
                    path(i - 1) = Console.ReadLine

                    If path(i - 1) = "" Then
                        Console.WriteLine("ERROR! Insert a valid path!")
                        Console.ReadLine()

                    End If
                Loop While path(i - 1) = ""

                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Path\path_" + Convert.ToString(i) + ".pm", path(i - 1), True)

            Next

        End If
    End Sub
End Module
