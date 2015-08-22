Public Class Main
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
    '#Variables Main Menu and other (Loader, etc..)

    Dim quit, defaultservers As String
    Dim checkfolderinstallation, checklicense, checklanguage As Object
    Dim checklang, changelang As Boolean
    Dim language As Integer

    Dim devmode As Boolean
    Dim checkdevmode As Object

    '#Variables "Install PocketMine-MP"
    Dim downloadstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
    Dim installationstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
    Dim versionstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

    Dim checkinstallations As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
    Dim checkdownloads As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

    '#Variables "Manage Servers"
    Dim nservers As Integer
    Dim nameservers As String() = New String() {"", "", "", "", "", "", "", "", "", ""}
    Dim numberservers As String() = New String() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"}
    Dim numberservers_2 As String() = New String() {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"}

    Dim checknservers As Object

    Dim checknameserver As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}

    Dim pathopener As String
    Dim path As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

    Dim checkpath As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
    '-------------------------------------------------------------------------------------------------------------------------------------------------
    Dim varmanager As String

    '-------------------------------------------------------------------------------------------------------------------------------------------------
    Dim performance, confirmperfomance, selectperformance As String

    Dim performancestatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

    Dim checkperformance As Object() = New Object() {False, False, False, False, False, False, False, False, False, False}
    '--------------#Variables Rescuer(Backup)
    Dim backupstatus As String() = New String() {"", "", "", "", "", "", "", "", "", ""}

    '#Variables Mechanical
    Dim dirservername, dirpath, dirdata, dirutils, dirperformance, dirinstallations, dirlanguages, direrrors As Object

    Private Sub btn_Esci_Click(sender As System.Object, e As System.EventArgs) Handles btn_Leave.Click

        If MsgBox("Are you sure to leave the program?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_InstallerPM_Click(sender As System.Object, e As System.EventArgs) Handles btn_InstallerPM.Click
        ManagerInstaller.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loader.Loader(checklanguage, versionstatus, dirinstallations, checkinstallations, checkdownloads, checkperformance, checknameserver, nameservers, performancestatus, nservers, checkpath, path, checknservers, checkfolderinstallation, dirpath, dirdata, dirservername,
                      dirperformance, dirutils, checklicense, downloadstatus, installationstatus, backupstatus, dirlanguages, direrrors)

    End Sub


    'Sub Selection(ByRef nservers As Integer, ByRef nameservers As String(), ByRef numberservers As String(), ByRef defaultservers As String)
    '    For i = 1 To nservers
    '        defaultservers = ("Server Minecraft PE_" + Convert.ToString(i))

    '        Console.Write("{0}) Name of {1} server?: ", i, numberservers(i - 1))
    '        nameservers(i - 1) = Console.ReadLine

    '        If nameservers(i - 1) = "" Then
    '            nameservers(i - 1) = defaultservers
    '        End If
    '    Next
    'End Sub
End Class

Public Module CollectionOfUtility
    Sub Writing(ByRef nameservers As String(), ByRef nservers As Integer, ByRef path As String())
        For i = 1 To nservers
            My.Computer.FileSystem.WriteAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\ServersName\ServerName_" + Convert.ToString(i) + ".pm", nameservers(i - 1), True)

        Next
    End Sub

    Public Sub Reading(ByRef path As Object(), ByRef nservers As Integer, ByRef nameservers As String())
        For i = 1 To nservers
            path(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\Path\path_" + Convert.ToString(i) + ".pm")
            nameservers(i - 1) = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers[GUI]\ServersName\ServerName_" + Convert.ToString(i) + ".pm")

        Next

    End Sub

    Sub Checking(ByRef checknameserver As Object(), ByRef checkpath As Object())
        For i = 1 To 10
            checknameserver(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\ServersName\ServerName_" + Convert.ToString(i) + ".pm")
            checkpath(i - 1) = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\Path\path_" + Convert.ToString(i) + ".pm")

        Next
    End Sub
End Module
