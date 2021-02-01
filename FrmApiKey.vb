Imports System.Runtime.InteropServices

Public Class FrmApiKey
    Dim Index As Integer = 1
    Sub New()
        InitializeComponent()
        SetSubText(txtApiKey, "a8fh6g259b5t2acer4ad2591b92b47f9")
        For Each Text As String In My.Settings.ListAPIKey
            Dim NewItem As New ListViewItem
            NewItem.Text = CInt(Index).ToString("D2")
            NewItem.SubItems.Add(Text)
            LvAPIKey.Items.Add(NewItem)
            Index += 1
        Next
    End Sub

    Private Sub FrmApiKey_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If LvAPIKey.Items.Count > 0 Then
            My.Settings.Save()
            FrmMain.Show()
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If txtApiKey.Text.Length > 1 Then
            Dim NewItem As New ListViewItem
            NewItem.Text = CInt(Index).ToString("D2")
            NewItem.SubItems.Add(txtApiKey.Text)
            LvAPIKey.Items.Add(NewItem)
            My.Settings.ListAPIKey.Add(txtApiKey.Text)
            txtApiKey.Text = Nothing
            Index += 1
        End If
    End Sub

    Private Sub CTXExcluir_Click(sender As Object, e As EventArgs) Handles CTXExcluir.Click
        For Each I As ListViewItem In LvAPIKey.SelectedItems
            My.Settings.ListAPIKey.RemoveAt(I.Index)
            I.Remove()
        Next
    End Sub

    Private Sub CriarAPIKey_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CriarAPIKey.LinkClicked
        Process.Start("https://go.opswat.com")
    End Sub

    Private Sub FrmApiKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Module SubText
    Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Public Sub SetSubText(ByRef TXT As TextBox, ByVal Text As String)
        SendMessage(TXT.Handle, EM_SETCUEBANNER, 1, Text)
    End Sub
End Module