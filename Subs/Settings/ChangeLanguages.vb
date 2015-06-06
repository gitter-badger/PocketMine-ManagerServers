Module ChangeLanguages
    Sub ChangeLanguages(ByRef checklanguage As Object, ByRef dirlanguages As Object)

        Dim language As Integer
        Dim changelang As Boolean

        Do
            Try
                Console.ForegroundColor = ConsoleColor.Green
                Console.Clear()
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.DarkMagenta
                Console.WriteLine("----------------------------<Selection Languages>-------------------------------")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("1) Afrikaans" + vbTab + vbTab + vbTab + "16) Italian")
                Console.WriteLine("2) Arabic" + vbTab + vbTab + vbTab + "17) Japanese")
                Console.WriteLine("3) Catalan" + vbTab + vbTab + vbTab + "18) Korean")
                Console.WriteLine("4) Chinese Simplified" + vbTab + vbTab + "19) Norwegian")
                Console.WriteLine("5) Chinese Traditional" + vbTab + vbTab + "20) Polish")
                Console.WriteLine("6) Czech" + vbTab + vbTab + vbTab + "21) Portuguese")
                Console.WriteLine("7) Danish" + vbTab + vbTab + vbTab + "22) Portuguese, Brazilian")
                Console.WriteLine("8) Dutch" + vbTab + vbTab + vbTab + "23) Romanian")
                Console.WriteLine("9) English" + vbTab + vbTab + vbTab + "24) Russian")
                Console.WriteLine("10) Finnish" + vbTab + vbTab + vbTab + "25) Serbian(Cyrillic)")
                Console.WriteLine("11) French" + vbTab + vbTab + vbTab + "26) Spanish")
                Console.WriteLine("12) German" + vbTab + vbTab + vbTab + "27) Swedish")
                Console.WriteLine("13) Greek" + vbTab + vbTab + vbTab + "28) Turkish")
                Console.WriteLine("14) Hebrew" + vbTab + vbTab + vbTab + "29) Ukrainian")
                Console.WriteLine("15) Hungarian" + vbTab + vbTab + vbTab + "30) Vietnamese")
                Console.WriteLine()
                Console.Write("Choose language: ")
                language = Console.ReadLine

                If language > 30 Or language <= 0 Then
                    Console.WriteLine("Please select an avaiable language!")

                End If

            Catch ex As Exception
                Console.WriteLine(ex)

            End Try

            If checklanguage Then
                My.Computer.FileSystem.DeleteFile("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm")
                My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers\Data\langselection.pm", language, True)

                changelang = True

                LanguagesSelector.LanguagesSelector(dirlanguages, changelang)

            Else
                Console.WriteLine("Bad error")

            End If

        Loop While language > 30 Or language <= 0

        

    End Sub
End Module
