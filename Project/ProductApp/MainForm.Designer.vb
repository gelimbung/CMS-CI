<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemUom = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribusiBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarungMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersediaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(701, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemUom, Me.ToolStripMenuItemProduct, Me.ToolStripSeparator1, Me.SupplierToolStripMenuItem, Me.RuangToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'ToolStripMenuItemUom
        '
        Me.ToolStripMenuItemUom.Name = "ToolStripMenuItemUom"
        Me.ToolStripMenuItemUom.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItemUom.Text = "Code UOM"
        '
        'ToolStripMenuItemProduct
        '
        Me.ToolStripMenuItemProduct.Name = "ToolStripMenuItemProduct"
        Me.ToolStripMenuItemProduct.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItemProduct.Text = "Product"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(130, 6)
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'RuangToolStripMenuItem
        '
        Me.RuangToolStripMenuItem.Name = "RuangToolStripMenuItem"
        Me.RuangToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RuangToolStripMenuItem.Text = "Room"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemMasukToolStripMenuItem, Me.ItemKeluarToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem1})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'ItemMasukToolStripMenuItem
        '
        Me.ItemMasukToolStripMenuItem.Name = "ItemMasukToolStripMenuItem"
        Me.ItemMasukToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemMasukToolStripMenuItem.Text = "Item Masuk"
        '
        'ItemKeluarToolStripMenuItem
        '
        Me.ItemKeluarToolStripMenuItem.Name = "ItemKeluarToolStripMenuItem"
        Me.ItemKeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemKeluarToolStripMenuItem.Text = "Item Keluar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Item Retur"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistribusiBarangToolStripMenuItem, Me.BarungMasukToolStripMenuItem, Me.PersediaanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DistribusiBarangToolStripMenuItem
        '
        Me.DistribusiBarangToolStripMenuItem.Name = "DistribusiBarangToolStripMenuItem"
        Me.DistribusiBarangToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DistribusiBarangToolStripMenuItem.Text = "Item Masuk"
        '
        'BarungMasukToolStripMenuItem
        '
        Me.BarungMasukToolStripMenuItem.Name = "BarungMasukToolStripMenuItem"
        Me.BarungMasukToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BarungMasukToolStripMenuItem.Text = "Item Keluar"
        '
        'PersediaanToolStripMenuItem
        '
        Me.PersediaanToolStripMenuItem.Name = "PersediaanToolStripMenuItem"
        Me.PersediaanToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PersediaanToolStripMenuItem.Text = "Persediaan"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Product App"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RuangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DistribusiBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarungMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemUom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PersediaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
