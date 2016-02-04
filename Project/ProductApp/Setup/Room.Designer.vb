<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonRoomAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRoomEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRoomDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRoom = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonRoomAdd, Me.ToolStripButtonRoomEdit, Me.ToolStripButtonRoomDelete, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(647, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonRoomAdd
        '
        Me.ToolStripButtonRoomAdd.Image = CType(resources.GetObject("ToolStripButtonRoomAdd.Image"), System.Drawing.Image)
        Me.ToolStripButtonRoomAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRoomAdd.Name = "ToolStripButtonRoomAdd"
        Me.ToolStripButtonRoomAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButtonRoomAdd.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButtonRoomAdd.Text = "Add"
        '
        'ToolStripButtonRoomEdit
        '
        Me.ToolStripButtonRoomEdit.Image = CType(resources.GetObject("ToolStripButtonRoomEdit.Image"), System.Drawing.Image)
        Me.ToolStripButtonRoomEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRoomEdit.Name = "ToolStripButtonRoomEdit"
        Me.ToolStripButtonRoomEdit.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButtonRoomEdit.Text = "Edit"
        '
        'ToolStripButtonRoomDelete
        '
        Me.ToolStripButtonRoomDelete.Image = CType(resources.GetObject("ToolStripButtonRoomDelete.Image"), System.Drawing.Image)
        Me.ToolStripButtonRoomDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRoomDelete.Name = "ToolStripButtonRoomDelete"
        Me.ToolStripButtonRoomDelete.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButtonRoomDelete.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton4.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 25)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setup >> Room"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvRoom
        '
        Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRoom.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRoom.Location = New System.Drawing.Point(0, 50)
        Me.dgvRoom.Name = "dgvRoom"
        Me.dgvRoom.Size = New System.Drawing.Size(647, 211)
        Me.dgvRoom.TabIndex = 2
        '
        'Room
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(647, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvRoom)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Room"
        Me.ShowIcon = False
        Me.Text = "Room"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonRoomAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRoomEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRoomDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvRoom As System.Windows.Forms.DataGridView
End Class
