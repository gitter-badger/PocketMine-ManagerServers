Public Class Informations

    Dim gitlink As String = "https://github.com/matcracker/PocketMine-ManagerServers"

    Dim twitterlink As String = "https://twitter.com/matcracker98"


    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        Main.Show()

    End Sub

    Private Sub btn_License_Click(sender As Object, e As EventArgs) Handles btn_License.Click
        Dim checklicense As Object = My.Computer.FileSystem.FileExists("C:\Program Files\PocketMine-ManagerServers[GUI]\LICENSE.pdf")

        If checklicense Then
            Process.Start("C:\Program Files\PocketMine-ManagerServers[GUI]\LICENSE.pdf")
        Else
            MsgBox("BAD INSTALLATION")
        End If

    End Sub

    Private Sub btn_Credits_Click(sender As Object, e As EventArgs) Handles btn_Credits.Click
        MsgBox("This program is free software made by matcracker: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or at your option) any later version." + vbCrLf +
               "This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details." + vbCrLf +
               "You should have received a copy of the GNU Lesser General Public License along with this program.  If not, see in this program in the section 'Informations ->  License'.")

    End Sub

    Private Sub btn_MoreInfo_Click(sender As Object, e As EventArgs) Handles btn_MoreInfo.Click
        MsgBox("GitHub: " + gitlink + vbCrLf + vbCrLf +
               "Twitter: " + twitterlink)
    End Sub

    Private Sub btn_Disclaimer_Click(sender As Object, e As EventArgs) Handles btn_Disclaimer.Click
        MsgBox("I do not assume responsibility for the use of this program if being deleted folders or files, for you, important. The use is personal and therefore the connections you supply will have to be primarily related to the creation program server 'PocketMine-MP' or relative.")
    End Sub
End Class