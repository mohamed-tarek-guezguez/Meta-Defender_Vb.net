<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CHNome As System.Windows.Forms.ColumnHeader
        Dim CHStatus As System.Windows.Forms.ColumnHeader
        Dim CHENGINE As System.Windows.Forms.ColumnHeader
        Dim CHRESULT As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.GList = New System.Windows.Forms.ImageList(Me.components)
        Me.LVArquivos = New MetaDefender.STListView()
        Me.LVResult = New MetaDefender.STListView()
        CHNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CHStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CHENGINE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CHRESULT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'CHNome
        '
        CHNome.Text = "NOME"
        CHNome.Width = 210
        '
        'CHStatus
        '
        CHStatus.Text = "STATUS"
        CHStatus.Width = 198
        '
        'CHENGINE
        '
        CHENGINE.Text = "ENGINE"
        CHENGINE.Width = 207
        '
        'CHRESULT
        '
        CHRESULT.Text = "RESULT"
        CHRESULT.Width = 198
        '
        'GList
        '
        Me.GList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.GList.ImageSize = New System.Drawing.Size(16, 16)
        Me.GList.TransparentColor = System.Drawing.Color.Transparent
        '
        'LVArquivos
        '
        Me.LVArquivos.AllowDrop = True
        Me.LVArquivos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LVArquivos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {CHNome, CHStatus})
        Me.LVArquivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVArquivos.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LVArquivos.FullRowSelect = True
        Me.LVArquivos.GridLines = True
        Me.LVArquivos.HideSelection = False
        Me.LVArquivos.Location = New System.Drawing.Point(0, 333)
        Me.LVArquivos.MultiSelect = False
        Me.LVArquivos.Name = "LVArquivos"
        Me.LVArquivos.OwnerDraw = True
        Me.LVArquivos.Size = New System.Drawing.Size(428, 155)
        Me.LVArquivos.SmallImageList = Me.GList
        Me.LVArquivos.TabIndex = 1
        Me.LVArquivos.UseCompatibleStateImageBehavior = False
        Me.LVArquivos.View = System.Windows.Forms.View.Details
        '
        'LVResult
        '
        Me.LVResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {CHENGINE, CHRESULT})
        Me.LVResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.LVResult.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVResult.FullRowSelect = True
        Me.LVResult.GridLines = True
        Me.LVResult.HideSelection = False
        Me.LVResult.Location = New System.Drawing.Point(0, 0)
        Me.LVResult.Name = "LVResult"
        Me.LVResult.Size = New System.Drawing.Size(428, 333)
        Me.LVResult.TabIndex = 0
        Me.LVResult.TabStop = False
        Me.LVResult.UseCompatibleStateImageBehavior = False
        Me.LVResult.View = System.Windows.Forms.View.Details
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 488)
        Me.Controls.Add(Me.LVArquivos)
        Me.Controls.Add(Me.LVResult)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meta Defender"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LVResult As STListView
    Friend WithEvents LVArquivos As STListView
    Friend WithEvents GList As ImageList
End Class
