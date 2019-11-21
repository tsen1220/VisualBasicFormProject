Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '判斷是否有網路
        If My.Computer.Network.IsAvailable = False Then
            Exit Sub

        End If


        '取得機器名稱
        Dim hostName As String = System.Net.Dns.GetHostName
        '列舉出所有網卡IP
        For Each item As System.Net.IPAddress In System.Net.Dns.GetHostEntry(hostName).AddressList
            '顯示IP 將item轉換成string (To string)
            MsgBox(item.ToString)
        Next



        MsgBox("機器名稱:" & hostName)
    End Sub
End Class
