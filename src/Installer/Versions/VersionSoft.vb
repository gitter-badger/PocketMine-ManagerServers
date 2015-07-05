Module VersionSoft
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
    Sub VersionSoft(ByRef chooseserver As String, ByRef soft As String, ByRef checksoft As Object, ByRef checkphar1 As Object, ByRef checkphar2 As Object, ByRef path As String())

        Dim confirmphar As String

        If chooseserver = "1" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(0), "DEV", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "2" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(1), "DEV", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "3" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(2), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "4" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(3), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "5" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(4), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "6" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(5), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "7" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(6), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "8" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(7), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "9" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(8), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "10" And soft = "1" Then
            If checksoft Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(9), "SOFT", checkphar1, checkphar2)

                End If

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

    End Sub
End Module
