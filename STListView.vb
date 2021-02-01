Public Class STListView
    Inherits ListView

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnDrawColumnHeader(e As DrawListViewColumnHeaderEventArgs)
        e.DrawDefault = True
        MyBase.OnDrawColumnHeader(e)
    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawListViewItemEventArgs)
        e.DrawDefault = False
        MyBase.OnDrawItem(e)
    End Sub

    Protected Overrides Sub OnDrawSubItem(e As DrawListViewSubItemEventArgs)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Near

        If e.ItemState And ListViewItemStates.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(51, 153, 255)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        If e.ColumnIndex = 1 Then
            Dim INFO As STListViewItem = CType(e.Item, STListViewItem)

            If INFO.ShowColor = True Then
                Dim II As Integer = CInt((INFO.Detected - 0) / (INFO.Maximum - 0) * (e.Bounds.Width))
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(219, 100, 96)), e.Bounds.X, e.Bounds.Y + e.Bounds.Height - 4, II, 4)
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(108, 191, 109)), e.Bounds.X + II, e.Bounds.Y + e.Bounds.Height - 4, e.Bounds.Width - II, 4)
            End If
            e.Graphics.DrawString(e.SubItem.Text, Me.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y, StringFormat.GenericDefault)
        ElseIf e.ColumnIndex = 0 Then
            If SmallImageList IsNot Nothing Then
                e.Graphics.DrawImage(SmallImageList.Images(e.Item.ImageIndex), e.Bounds.X + 1, e.Bounds.Y, 16, 16)
                e.Graphics.DrawString(e.SubItem.Text, Me.Font, Brushes.Black, New Rectangle(e.Bounds.X + 16, e.Bounds.Y, e.Bounds.Width - 30, e.Bounds.Height - 1), New StringFormat() With {.Trimming = StringTrimming.EllipsisWord})
            End If
        End If
    End Sub

End Class

Public Class STListViewItem
    Inherits ListViewItem

    Private _Maximum As Integer = 36
    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            _Maximum = value
        End Set
    End Property

    Private _Detected As Integer = 0
    Property Detected() As Integer
        Get
            Return _Detected
        End Get
        Set(ByVal value As Integer)
            _Detected = value
        End Set
    End Property

    Private _ShowColor As Boolean = False
    Property ShowColor As Boolean
        Get
            Return _ShowColor
        End Get
        Set(ByVal value As Boolean)
            _ShowColor = value
        End Set
    End Property

End Class