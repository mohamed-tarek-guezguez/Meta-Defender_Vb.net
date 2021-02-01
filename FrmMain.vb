Imports System.IO

Public Class FrmMain

    Private ListScans As New Dictionary(Of MetaDefenderAPI, STListViewItem)

    Sub New()
        InitializeComponent()
        For Each FPath As String In Environment.GetCommandLineArgs
            If FPath = Application.ExecutablePath And (New FileInfo(FPath).Length = New FileInfo(Application.ExecutablePath).Length) Then
                Continue For
            End If
            ScanFile(FPath)
        Next
    End Sub

    Private Sub LVArquivos_DragEnter(sender As Object, e As DragEventArgs) Handles LVArquivos.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub LVArquivos_DragDrop(sender As Object, e As DragEventArgs) Handles LVArquivos.DragDrop
        For Each FPath As String In e.Data.GetData(DataFormats.FileDrop)
            If Directory.Exists(FPath) = True Then
                For Each I As String In Directory.GetFiles(FPath, "*.*", SearchOption.AllDirectories)
                    ScanFile(I)
                Next
            Else
                ScanFile(FPath)
            End If
        Next
    End Sub

    Private Sub ScanFile(ByVal File As String)
        Dim NewItem As New STListViewItem
        NewItem.UseItemStyleForSubItems = False
        NewItem.Text = Path.GetFileName(File)
        NewItem.SubItems.Add("Analyzing...")
        GList.Images.Add(Icon.ExtractAssociatedIcon(File))
        NewItem.ImageIndex = GList.Images.Count - 1
        LVArquivos.Items.Add(NewItem)
        Dim X As New MetaDefenderAPI
        X.Arquivo = File
        AddHandler X.UploadProgressChanged, AddressOf X_UploadProgressChanged
        AddHandler X.ScannerCompleted, AddressOf X_ScannerCompleted
        X.ScanFileAsync(File)
        ListScans.Add(X, NewItem)
    End Sub

    Private Sub X_ScannerCompleted(sender As Object, e As JScanInfo.Rootobject)
        ListScans(sender).Tag = e
        ListScans(sender).SubItems(1).ForeColor = CheckColor(e.scan_results.total_detected_avs)
        ListScans(sender).Detected = e.scan_results.total_detected_avs
        ListScans(sender).ShowColor = True
        LVArquivos.Invalidate()
        AddScan(e)
    End Sub

    Private Sub X_UploadProgressChanged(sender As Object, Status As String)
        ListScans(sender).SubItems(1).Text = Status
    End Sub

    Private Sub LVArquivos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LVArquivos.MouseDoubleClick
        If LVArquivos.SelectedItems.Count > 0 Then
            If LVArquivos.SelectedItems(0).Tag IsNot Nothing Then
                Process.Start(String.Format("https://metadefender.opswat.com/results#!/file/{0}/regular", CType(LVArquivos.SelectedItems(0).Tag, JScanInfo.Rootobject).data_id))
            End If
        End If
    End Sub

    Private Function CheckColor(ByVal ID As Integer) As Color
        Return IIf(ID = 0, Color.FromArgb(108, 191, 109), Color.FromArgb(219, 100, 96))
    End Function

    Private Function F(ByVal ID As String) As String
        Return IIf(ID = Nothing Or ID = " ", "OK", ID)
    End Function

    Private Function C(ByVal ID As String) As Color
        Return IIf(ID = "OK", Color.FromArgb(108, 191, 109), Color.FromArgb(219, 100, 96))
    End Function

    Private Sub LVArquivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVArquivos.SelectedIndexChanged
        If LVArquivos.SelectedItems.Count > 0 Then
            If LVArquivos.SelectedItems(0).Tag IsNot Nothing Then
                AddScan(CType(LVArquivos.SelectedItems(0).Tag, JScanInfo.Rootobject))
            End If
        End If
    End Sub

    Private Sub AddScan(ByVal e As JScanInfo.Rootobject)
        On Error Resume Next
        LVResult.Items.Clear()
        Dim ListItem As New List(Of ListViewItem)
        Dim NewItem As New ListViewItem
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Zoner" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Zoner.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Zillya!" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Zillya.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "VirusBlokAda" : NewItem.SubItems.Add(F(e.scan_results.scan_details.VirusBlokAda.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "TrendMicro House Call" : NewItem.SubItems.Add(F(e.scan_results.scan_details.TrendMicroHouseCall.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "TrendMicro" : NewItem.SubItems.Add(F(e.scan_results.scan_details.TrendMicro.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Total Defense" : NewItem.SubItems.Add(F(e.scan_results.scan_details.TotalDefense.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "ThreatTrack" : NewItem.SubItems.Add(F(e.scan_results.scan_details.ThreatTrack.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "SUPERAntiSpyware" : NewItem.SubItems.Add(F(e.scan_results.scan_details.SUPERAntiSpyware.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Sophos" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Sophos.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Quick Heal" : NewItem.SubItems.Add(F(e.scan_results.scan_details.QuickHeal.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Preventon" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Preventon.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "nProtect" : NewItem.SubItems.Add(F(e.scan_results.scan_details.nProtect.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "NANOAV" : NewItem.SubItems.Add(F(e.scan_results.scan_details.NANOAV.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "McAfee" : NewItem.SubItems.Add(F(e.scan_results.scan_details.McAfee.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "K7" : NewItem.SubItems.Add(F(e.scan_results.scan_details.K7.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Jiangmin" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Jiangmin.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Ikarus" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Ikarus.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Hauri" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Hauri.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Fortinet" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Fortinet.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Filseclab" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Filseclab.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "F-secure" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Fsecure.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "F-prot" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Fprot.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "ESET" : NewItem.SubItems.Add(F(e.scan_results.scan_details.ESET.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Emsisoft" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Emsisoft.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Cyren" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Cyren.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "ClamAV" : NewItem.SubItems.Add(F(e.scan_results.scan_details.ClamAV.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "ByteHero" : NewItem.SubItems.Add(F(e.scan_results.scan_details.ByteHero.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "BitDefender" : NewItem.SubItems.Add(F(e.scan_results.scan_details.BitDefender.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Avira" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Avira.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "AVG" : NewItem.SubItems.Add(F(e.scan_results.scan_details.AVG.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Antiy" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Antiy.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Ahnlab" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Ahnlab.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Agnitum" : NewItem.SubItems.Add(F(e.scan_results.scan_details.Agnitum.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "AegisLab" : NewItem.SubItems.Add(F(e.scan_results.scan_details.AegisLab.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Vir.IT eXplorer" : NewItem.SubItems.Add(F(e.scan_results.scan_details.VirITeXplorer.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        NewItem = New ListViewItem() : NewItem.UseItemStyleForSubItems = False : NewItem.Text = "Dr.Web Gateway" : NewItem.SubItems.Add(F(e.scan_results.scan_details.DrWebGateway.threat_found)) : NewItem.SubItems(1).ForeColor = C(NewItem.SubItems(1).Text) : ListItem.Add(NewItem)
        LVResult.Items.AddRange(ListItem.ToArray)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class