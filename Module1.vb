Module Module1

    Sub Main()

        '#Variables
        Dim menù, quit As String

        quit = "N"

        While quit = "N"
            Console.Clear()
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.WriteLine("-------------------------------<Main Menù>--------------------------------------")
            Console.WriteLine("1- Install PocketMine-MP")
            Console.WriteLine("2- Manage Server")
            Console.WriteLine("3- Maintenance Server")
            Console.WriteLine("4- Programm Options")
            Console.WriteLine("5- Exit")
            Console.WriteLine()
            Console.Write("What would you like to do?: ")
            menù = Console.ReadLine

            If menù = "5" Then
                Do
                    Console.Clear()
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.Write("Are you sure you want to quit? <Y/N>: ")
                    quit = Console.ReadLine.ToUpper
                Loop While quit <> "Y" And quit <> "N"

                If quit = "Y" Then
                    Console.WriteLine("See you soon!")
                    Console.ReadLine()
                    End
                End If


            End If
        End While


    End Sub

End Module
