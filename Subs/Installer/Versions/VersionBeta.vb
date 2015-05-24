Module VersionBeta
    Sub VersionBeta(ByRef chooseserver As String, ByRef beta As String, ByRef checkbeta As Object, ByRef checkphar1 As Object, ByRef checkphar2 As Object, ByRef path As String())

        Dim confirmphar As String

        If chooseserver = "1" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(0), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "2" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(1), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "3" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(2), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "4" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(3), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "5" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(4), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "6" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(5), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "7" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(6), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "8" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(7), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "9" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(8), "BETA", checkphar1, checkphar2)

                End If

                'TODO: Change Singular "Download Status"

            Else
                Console.WriteLine("Phar file not found!")
                Console.WriteLine("Please download the file.")
                Console.ReadLine()

            End If
        End If

        If chooseserver = "10" And beta = "1" Then
            If checkbeta Then
                Console.WriteLine("Are you sure you want to replace the file phar with the current one? (This will create a copy) <Y/N>: ")
                confirmphar = Console.ReadLine.ToUpper

                If confirmphar = "Y" Then
                    ChangeInstallationFiles(path(9), "BETA", checkphar1, checkphar2)

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
