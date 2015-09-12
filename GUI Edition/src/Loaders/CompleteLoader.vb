Public Class CompleteLoader
    Dim nservers As String
    Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
    Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}
    Dim numberservers_2 As String() = New String() {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"}

    Dim checknservers As Object = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Data\servers.pm")

    Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

    Dim pathopener As String
    Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

    Dim checkpath As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
    '-------------------------------------------------------------------------------------------------------------------------------------------------
    Dim varmanager As String

    '-------------------------------------------------------------------------------------------------------------------------------------------------
    Dim performance, confirmperfomance, selectperformance As String

    Dim performancestatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

    Const defaultservers As String = "Server Minecraft PE"

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        Do
            nservers = txt_NumberServers.Text

            If nservers = "" Then
                MsgBox("You must enter a number from 1 to 10")
                nservers = "."
            End If
        Loop While nservers = ""

        My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Data\servers.pm", nservers, True)

        CompleteLoader_Load(sender, e)

    End Sub

    Dim checkperformance As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

    Public Sub CompleteLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Hide()
        Me.Show()

        If checknservers Then
            nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Data\servers.pm")

        Else
            Me.btn_Next_Click(sender, e)
        End If

        Checking(checknameserver, checkpath)

        If Val(nservers) >= 1 Then
            If nservers = 1 And checknameserver(0) Then

                Exit Sub

            ElseIf nservers = 1 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 2 And checknameserver(0) And checknameserver(1) Then

                Exit Sub

            ElseIf nservers = 2 Then

                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 3 And checknameserver(0) And checknameserver(1) And checknameserver(2) Then

                Exit Sub

            ElseIf nservers = 3 Then

                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 4 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) Then

                Exit Sub

            ElseIf nservers = 4 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 5 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) Then

                Exit Sub

            ElseIf nservers = 5 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 6 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) Then

                Exit Sub

            ElseIf nservers = 6 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 7 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) Then

                Exit Sub

            ElseIf nservers = 7 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 8 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) Then

                Exit Sub

            ElseIf nservers = 8 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 9 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) Then

                Exit Sub

            ElseIf nservers = 9 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If

            If nservers = 10 And checknameserver(0) And checknameserver(1) And checknameserver(2) And checknameserver(3) And checknameserver(4) And checknameserver(5) And checknameserver(6) And checknameserver(7) And checknameserver(8) And checknameserver(9) Then

                Exit Sub

            ElseIf nservers = 10 Then
                Selection(nservers, nameservers, numberservers, defaultservers)

                Writing(nameservers, nservers, path)

            End If
        End If
    End Sub
End Class