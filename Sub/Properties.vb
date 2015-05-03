Module Properties

    Sub Properties(ByRef checkpath As Object(), ByRef path As String(), ByRef nservers As Integer, ByRef numberservers As String(), ByRef checknameserver As Object())

        Dim motd, serverport, whitelist, achievent, spawn, maxplayers, flight, animals, mobs, gamemode, forcegamemode, _
            hardcore, pvp, difficulty, generator, levelname, levelseed, leveltype, enablequery, enablercon, rconpassword, _
            autosave As String
            


        Console.Clear()
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.WriteLine("--------------------------<Edit Server Properties>------------------------------")
        Console.WriteLine("Checking path(s)...")

        Checking(checknameserver, checkpath)

        If checkpath(0) And checkpath(1) And checkpath(2) And checkpath(3) And checkpath(4) And checkpath(5) And checkpath(6) And checkpath(7) And checkpath(8) And checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
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
                serverport ="19132"
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
                    enablercon = "off"
                End If

                If enablercon = "on" Then
                    'Random Generation
                    'Console.Write("Rcon password: ")
                    'rconpassword = Console.ReadLine.ToLower

                End If
            Loop While enablercon <> "on" And enablercon <> "off"
            
            Do
                Console.Write("Auto-Save <on/off>: ")
                autosave = Console.ReadLine.ToLower

                If autosave = "" Then
                    autosave = "on"
                End If

            Loop While autosave <> "on" And autosave <> "off"

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
