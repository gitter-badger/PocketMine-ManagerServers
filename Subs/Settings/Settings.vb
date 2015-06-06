Module Settings
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
    Sub Settings(ByRef nservers As Integer, ByRef checkpath As Object(), ByRef path As String(), ByRef checknservers As Object, ByRef checkfolderinstallation As Object, ByRef dirpath As Object, ByRef dirdata As Object, ByRef dirservername As Object, ByRef dirperformance As Object, ByRef dirinstallations As Object, ByRef dirlanguages As Object, ByRef direrrors As Object, ByRef checklanguage As Object)

        '#Variables "Program Options"
        Dim options As String

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("------------------------------<Program Options>---------------------------------")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- Language")
            Console.WriteLine("2- Reset Program")
            Console.WriteLine("3- Back")
            Console.WriteLine()
            Console.Write("Choose the option: ")
            options = Console.ReadLine

            If options = "1" Then
                ChangeLanguages.ChangeLanguages(checklanguage, dirlanguages)

            ElseIf options = "2" Then
                Resetter.Resetter(nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername, dirperformance, dirinstallations, dirlanguages, direrrors)

            End If

        Loop While options <> "3"


    End Sub

End Module
