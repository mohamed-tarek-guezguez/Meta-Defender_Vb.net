<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApiKey
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.CTX = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTXExcluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarAPIKey = New System.Windows.Forms.LinkLabel()
        Me.LvAPIKey = New MetaDefender.STListView()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTX.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "#"
        ColumnHeader1.Width = 20
        '
        'ColumnHeader2
        '
        ColumnHeader2.Text = "API Key Information and Limits"
        ColumnHeader2.Width = 267
        '
        'txtApiKey
        '
        Me.txtApiKey.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtApiKey.Location = New System.Drawing.Point(19, 25)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(234, 21)
        Me.txtApiKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "API Key"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnAdicionar.Location = New System.Drawing.Point(257, 23)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 25)
        Me.btnAdicionar.TabIndex = 1
        Me.btnAdicionar.Text = "Add"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'CTX
        '
        Me.CTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTXExcluir})
        Me.CTX.Name = "CTX"
        Me.CTX.ShowImageMargin = False
        Me.CTX.Size = New System.Drawing.Size(85, 26)
        '
        'CTXExcluir
        '
        Me.CTXExcluir.Name = "CTXExcluir"
        Me.CTXExcluir.Size = New System.Drawing.Size(84, 22)
        Me.CTXExcluir.Text = "Excluir"
        '
        'CriarAPIKey
        '
        Me.CriarAPIKey.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CriarAPIKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CriarAPIKey.AutoSize = True
        Me.CriarAPIKey.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CriarAPIKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CriarAPIKey.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CriarAPIKey.Location = New System.Drawing.Point(270, 207)
        Me.CriarAPIKey.Name = "CriarAPIKey"
        Me.CriarAPIKey.Size = New System.Drawing.Size(45, 13)
        Me.CriarAPIKey.TabIndex = 4
        Me.CriarAPIKey.TabStop = True
        Me.CriarAPIKey.Text = "API-Key"
        Me.CriarAPIKey.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LvAPIKey
        '
        Me.LvAPIKey.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, ColumnHeader2})
        Me.LvAPIKey.ContextMenuStrip = Me.CTX
        Me.LvAPIKey.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LvAPIKey.FullRowSelect = True
        Me.LvAPIKey.GridLines = True
        Me.LvAPIKey.HideSelection = False
        Me.LvAPIKey.Location = New System.Drawing.Point(19, 51)
        Me.LvAPIKey.Name = "LvAPIKey"
        Me.LvAPIKey.Size = New System.Drawing.Size(312, 149)
        Me.LvAPIKey.TabIndex = 3
        Me.LvAPIKey.TabStop = False
        Me.LvAPIKey.UseCompatibleStateImageBehavior = False
        Me.LvAPIKey.View = System.Windows.Forms.View.Details
        '
        'FrmApiKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 225)
        Me.Controls.Add(Me.CriarAPIKey)
        Me.Controls.Add(Me.LvAPIKey)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApiKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmApiKey"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meta Defender [API Key]"
        Me.CTX.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtApiKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents LvAPIKey As STListView
    Friend WithEvents CTX As ContextMenuStrip
    Friend WithEvents CTXExcluir As ToolStripMenuItem
    Friend WithEvents CriarAPIKey As LinkLabel
End Class
