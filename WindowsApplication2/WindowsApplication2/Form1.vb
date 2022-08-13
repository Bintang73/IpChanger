Imports System.Net
Imports System.Net.NetworkInformation

Public Class Form1


    Public Sub listAdapter()
        Dim foo As Integer
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
        If nics.Length < 0 Or nics Is Nothing Then
            MsgBox("Tidak ada Network Adapter..")
            Exit Sub
        End If
        foo = nics.Length - 1
        For i As Integer = 0 To foo
            boxNet.Items.Add(nics(i).Name.ToString)
        Next
        boxNet.Text = "Add Network Adapter"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If boxNet.Text.Contains("Add Network Adapter") Then
                MessageBox.Show("Tolong pilih Network Adapternya..")
            Else
                If TextIp.Text.Trim.Length < 5 Then
                    MessageBox.Show("Tolong isi bagian IP Addressnya..")
                Else
                    If TextMask.Text.Trim.Length < 5 Then
                        MessageBox.Show("Tolong isi bagian Subnet Masknya..")
                    Else
                        If TextGateway.Text.Trim.Length < 5 Then
                            MessageBox.Show("Tolong isi bagian Default Gatewaynya..")
                        Else
                            If TextDns.Text.Trim.Length < 5 Then
                                MessageBox.Show("Tolong isi bagian Dnsnya..")
                            Else
                                'MessageBox.Show(boxNet.Text)
                                Dim listNet As String
                                listNet = boxNet.Text

                                Dim listIp, listMask, listGateway As String
                                listIp = TextIp.Text
                                listMask = TextMask.Text
                                listGateway = TextGateway.Text
                                Process.Start("cmd", "/c Netsh Interface ip add address """ & listNet & """ " & listIp & " " & listMask & " " & listGateway)
                                'Process.Start("netsh", $"interface ip add address name=\""{listNet}\"" addr={listIp} mask={listMask} gateway={listGateway}")
                                'Dim Command, IpAddres, Gateway, Mask, Dns As String
                                'Dim Spls, Getnet As String
                                Dim listDns As String
                                listDns = TextDns.Text
                                Process.Start("cmd", "/c Netsh Interface ip set dns """ & listNet & """ static " & listDns)
                                MessageBox.Show("Ip Sukses Diganti!" & vbCr & vbCr & vbLf _
                                                & $"Network Adapter:  {listNet}" & vbCr & vbLf _
                                                & $"Ip Address:  {listIp}" & vbCr & vbLf _
                                                & $"Mask:  {listMask}" & vbCr & vbLf _
                                                & $"Default Gateway:  {listGateway}" & vbCr & vbCr & vbLf _
                                                & "By: Bintang Nur Pradana" & vbCr & vbLf _
                                                & "")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btInformation_Click(sender As Object, e As EventArgs) Handles bPing.Click
        MessageBox.Show("Network Interface" & vbCr & vbCr & vbLf _
                        & "Version:  1.1" & vbCr & vbLf _
                        & "By: Bintang Nur Pradana" & vbCr & vbLf _
                        & "", "About")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call listAdapter()
    End Sub

    Private Sub TextIp_TextChanged(sender As Object, e As EventArgs) Handles TextIp.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://instagram.com/bintang_nur_pradana")
    End Sub
End Class
