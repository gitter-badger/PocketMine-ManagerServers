Module VersionDev
    Sub VersionDev(ByRef chooseserver As String, ByRef dev As String, ByRef checkdev As Object, ByRef checkphar1 As Object, ByRef checkphar2 As Object, ByRef path As String())

        Dim confirmphar As String

        If chooseserver = "1" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(0), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "2" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(1), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "3" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(2), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "4" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(3), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "5" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(4), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "6" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(5), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "7" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(6), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "8" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(7), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "9" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(8), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "10" And dev = "1" Then
            If checkdev Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(9), "DEV", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

    End Sub
End Module
