Imports System.Text

Module EditorCommand
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
    Sub EditCommand(ByRef args As String(), ByRef command As String, ByRef nservers As SByte, ByRef path As String(), ByRef checkpath As Object(), ByRef nameservers As String())
        If command = "edit" Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Correct command is /edit <properties|performance> [PerformanceType] [ServerName]")
            Console.WriteLine()
            Console.WriteLine("<PerformanceType>")
            Console.WriteLine("1 <=> High")
            Console.WriteLine("2 <=> Medium")
            Console.WriteLine("3 <=> Low")

        ElseIf command = "edit properties" Then
            PropertiesCommand()

        ElseIf command = "edit performance" Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Correct command is /edit performance <PerformanceType> <ServerName>")
                Console.WriteLine()
                Console.WriteLine("<PerformanceType>")
                Console.WriteLine("1 <=> High")
                Console.WriteLine("2 <=> Medium")
                Console.WriteLine("3 <=> Low")

        Else

            PerformanceCommand(args, path, nameservers)

        End If
    End Sub
    Sub PropertiesCommand()
        Dim motd, serverport, whitelist, achievent, spawn, maxplayers, flight, animals, mobs, gamemode, forcegamemode, _
            hardcore, pvp, difficulty, generator, levelname, levelseed, leveltype, enablequery, enablercon, _
            autosave As String

        'Random Generation (Casual Variables)
        Dim rcongenerator As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        '-------------------------------------

        Dim propertiesfile, confirmedit As String

        Do
            Console.WriteLine()
            Console.WriteLine("#Properties Config file")
            Console.WriteLine(Today.DayOfWeek.ToString.Remove(3) + " " + MonthName(Date.Now.Month, True) + " " + Date.Now.Day.ToString + " " +
                              Date.Now.Hour.ToString + ":" + Date.Now.Minute.ToString + ":" + Date.Now.Second.ToString + " UTC " + Date.Today.Year.ToString)
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
                            Dim idx As SByte = r.Next(0, 35)
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

                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("Server.properties has been created!")

                End If
            Loop While confirmedit <> "Y" And confirmedit <> "N"
        Loop While confirmedit <> "Y" And confirmedit <> "N"
    End Sub

    Sub PerformanceCommand(ByRef args As String(), ByRef path As String(), ByRef nameservers As String())
        Dim performance As String = args(2)
        Dim completed As Boolean = False

        If performance = "1" Or performance.ToUpper = "HIGH" Or performance = "2" Or performance.ToUpper = "MEDIUM" Or performance = "3" Or performance.ToUpper = "LOW" Then
            If performance = "1" Or performance.ToUpper = "HIGH" Then
                performance = "HIGH"
            ElseIf performance = "2" Or performance.ToUpper = "MEDIUM" Then
                performance = "MEDIUM"
            ElseIf performance = "3" Or performance.ToUpper = "LOW" Then
                performance = "LOW"
            End If

            If args(3) = nameservers(0) Then
                ChangePerformance(path(0), performance)
                completed = True

            ElseIf args(3) = nameservers(1) Then
                ChangePerformance(path(1), performance)
                completed = True

            ElseIf args(3) = nameservers(2) Then
                ChangePerformance(path(2), performance)
                completed = True

            ElseIf args(3) = nameservers(3) Then
                ChangePerformance(path(3), performance)
                completed = True

            ElseIf args(3) = nameservers(4) Then
                ChangePerformance(path(4), performance)
                completed = True

            ElseIf args(3) = nameservers(5) Then
                ChangePerformance(path(5), performance)
                completed = True

            ElseIf args(3) = nameservers(6) Then
                ChangePerformance(path(6), performance)
                completed = True

            ElseIf args(3) = nameservers(7) Then
                ChangePerformance(path(7), performance)
                completed = True

            ElseIf args(3) = nameservers(8) Then
                ChangePerformance(path(8), performance)
                completed = True

            ElseIf args(3) = nameservers(9) Then
                ChangePerformance(path(9), performance)
                completed = True

            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Any server with this name exist!")

            End If

            If completed = True Then
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Performances edited!")
            End If
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Select a correct performance type!")
        End If
    End Sub
End Module
