Module Installator
    Sub Installator(ByRef nservers As Integer, ByRef nameservers As String(), ByRef installerstatus As String())
        Dim chooseserver As String

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("========================<PocketMine Manager Servers>============================")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("---------------------------<Install PocketMine-MP>------------------------------")
        Console.ForegroundColor = ConsoleColor.White
        For i = 1 To nservers
            Console.WriteLine("{0}) {1}: {2}", i, nameservers(i - 1), installerstatus(i - 1))

        Next
        Console.WriteLine()
        Console.Write("Which server you want to download the server? ")
        chooseserver = Console.ReadLine

    End Sub
End Module
