Module LanguageReader
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
    Sub LanguageReader(ByRef language As Integer, ByRef changelang As Boolean, ByRef back As String, ByRef changemade As String, ByRef status1 As String, ByRef version1 As String, ByRef versionstable As String, ByRef versionbeta As String)

        If language = 1 Then 'Afrikaans

        ElseIf language = 2 Then 'Arabic

        ElseIf language = 3 Then 'Catalan

        ElseIf language = 4 Then 'Chinese Simplified

        ElseIf language = 5 Then 'Chinese Traditional

        ElseIf language = 6 Then 'Czech

        ElseIf language = 7 Then 'Danish

        ElseIf language = 8 Then 'Dutch

        ElseIf language = 9 Then 'English
            EnglishR.EnglishR(back, changemade, status1, version1, versionstable, versionbeta)

        ElseIf language = 10 Then 'Finnish

        ElseIf language = 11 Then 'French

        ElseIf language = 12 Then 'German

        ElseIf language = 13 Then 'Greek

        ElseIf language = 14 Then 'Hebrew

        ElseIf language = 15 Then 'Hungarian

        ElseIf language = 16 Then 'Italian

        ElseIf language = 17 Then 'Japanese

        ElseIf language = 18 Then 'Korean

        ElseIf language = 19 Then 'Norwegian

        ElseIf language = 20 Then 'Polish

        ElseIf language = 21 Then 'Portuguese

        ElseIf language = 22 Then 'Portuguese(Brazilian)

        ElseIf language = 23 Then 'Romanian

        ElseIf language = 24 Then 'Russian

        ElseIf language = 25 Then 'Serbian(Cyrillic)

        ElseIf language = 26 Then 'Spanish

        ElseIf language = 27 Then 'Swedish

        ElseIf language = 28 Then 'Turkish

        ElseIf language = 29 Then 'Ukrainian

        ElseIf language = 30 Then 'Vietnamese

        End If

    End Sub
End Module
