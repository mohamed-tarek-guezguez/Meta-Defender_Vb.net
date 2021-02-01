Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization
Imports System.Threading

Public Class MetaDefenderAPI

    Private Index As Integer = 0

    Sub New()
        Control.CheckForIllegalCrossThreadCalls = False
        Index = My.Settings.ListAPIKey.Count - 1
    End Sub

    Public Event ScannerCompleted(sender As Object, Result As JScanInfo.Rootobject)
    Public Event UploadProgressChanged(sender As Object, Status As String)

    Private _Arquivo As String
    Public Property Arquivo As String
        Get
            Return _Arquivo
        End Get
        Set(value As String)
            _Arquivo = value
        End Set
    End Property

    Public Sub ScanFileAsync(ByVal Arquivo As String)
        Dim thread As New Thread(New ThreadStart(Sub() ScanFile(Arquivo)))
        thread.Start()
    End Sub

    Private Sub ScanFile(ByVal Arquivo As String)
        Using X As New WebClient
            X.Proxy = Nothing
            X.Headers.Add("apikey", My.Settings.ListAPIKey(Index))
            X.Headers.Add("filename", Path.GetFileName(Arquivo))
            X.Encoding = Encoding.UTF8
            AddHandler X.UploadProgressChanged, AddressOf CARREGANDO
            AddHandler X.UploadFileCompleted, AddressOf COMPLETO
            X.UploadFileTaskAsync(New Uri("https://api.metadefender.com/v2/file"), Arquivo)
        End Using
    End Sub

    Private Sub CARREGANDO(ByVal sender As Object, ByVal e As UploadProgressChangedEventArgs)
        RaiseEvent UploadProgressChanged(Me, e.ProgressPercentage & "%")
    End Sub

    Private Sub COMPLETO(ByVal sender As Object, ByVal e As UploadFileCompletedEventArgs)
        Try
            If e.Result IsNot Nothing Then
                Application.DoEvents()
                Dim INFO As JScanInfo.PrimaryInfo = New JavaScriptSerializer().Deserialize(Of JScanInfo.PrimaryInfo)(Encoding.UTF8.GetString(e.Result))
                Using X As New WebClient
                    X.Proxy = Nothing
                    X.Headers.Add("file_metadata", "1")
                    X.Headers.Add("apikey", My.Settings.ListAPIKey(Index))
                    X.Encoding = Encoding.UTF8
VT:
                    Dim Result As String = X.DownloadString(New Uri("https://api.metadefender.com/v2/file/" & INFO.data_id)).Replace("Zillya!", "Zillya").Replace("TrendMicro House Call", "TrendMicroHouseCall").Replace("Total Defense", "TotalDefense").Replace("Quick Heal", "QuickHeal").Replace("F-secure", "Fsecure").Replace("F-prot", "Fprot").Replace("Vir.IT eXplorer", "VirITeXplorer").Replace("Dr.Web Gateway", "DrWebGateway")
                    Dim ResultScan As JScanInfo.Rootobject = New JavaScriptSerializer().Deserialize(Of JScanInfo.Rootobject)(Result)
                    If ResultScan.scan_results.progress_percentage = 100 Then
                        RaiseEvent UploadProgressChanged(Me, String.Format("{0}/{1}", ResultScan.scan_results.total_detected_avs, ResultScan.scan_results.total_avs))
                    Else
                        RaiseEvent UploadProgressChanged(Me, String.Format("Analyzing, {0}...", ResultScan.scan_results.in_queue))
                        Thread.Sleep(1500)
                        GoTo VT
                    End If

                    RaiseEvent ScannerCompleted(Me, ResultScan)
                End Using
            ElseIf e.Error IsNot Nothing Then
                MsgBox(e.Error.Message)
            End If
        Catch ex As Exception
            RaiseEvent UploadProgressChanged(Me, "API-Key #" & Index.ToString("D2") & " Atingiu seu Limite.")

            If (Index - 1) = -1 Then
                Index = My.Settings.ListAPIKey.Count - 1
            Else
                Index -= 1
            End If

            Using X As New WebClient
                X.Proxy = Nothing
                X.Headers.Add("apikey", My.Settings.ListAPIKey(Index))
                X.Headers.Add("filename", Path.GetFileName(Arquivo))
                X.Encoding = Encoding.UTF8
                AddHandler X.UploadProgressChanged, AddressOf CARREGANDO
                AddHandler X.UploadFileCompleted, AddressOf COMPLETO
                X.UploadFileTaskAsync(New Uri("https://api.metadefender.com/v2/file"), Arquivo)
            End Using
        End Try
    End Sub
End Class
