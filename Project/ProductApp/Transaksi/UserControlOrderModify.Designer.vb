<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlOrderModify
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxSupplierName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSearchSupplier = New System.Windows.Forms.Button()
        Me.TextBoxSupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerOrder = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProdTransact = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxProduct = New System.Windows.Forms.TextBox()
        Me.NumericUpDownQtt = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonSearchProduct = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxProductName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProdTransact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownQtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxSupplierName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.ButtonSearchSupplier)
        Me.Panel1.Controls.Add(Me.TextBoxSupplier)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePickerOrder)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 105)
        Me.Panel1.TabIndex = 4
        '
        'TextBoxSupplierName
        '
        Me.TextBoxSupplierName.Location = New System.Drawing.Point(426, 38)
        Me.TextBoxSupplierName.Name = "TextBoxSupplierName"
        Me.TextBoxSupplierName.ReadOnly = True
        Me.TextBoxSupplierName.Size = New System.Drawing.Size(182, 20)
        Me.TextBoxSupplierName.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(346, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Supplier Name"
        '
        'ButtonSearchSupplier
        '
        Me.ButtonSearchSupplier.Location = New System.Drawing.Point(265, 38)
        Me.ButtonSearchSupplier.Name = "ButtonSearchSupplier"
        Me.ButtonSearchSupplier.Size = New System.Drawing.Size(38, 23)
        Me.ButtonSearchSupplier.TabIndex = 6
        Me.ButtonSearchSupplier.Text = "..."
        Me.ButtonSearchSupplier.UseVisualStyleBackColor = True
        '
        'TextBoxSupplier
        '
        Me.TextBoxSupplier.Location = New System.Drawing.Point(91, 39)
        Me.TextBoxSupplier.Name = "TextBoxSupplier"
        Me.TextBoxSupplier.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxSupplier.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Supplier ID"
        '
        'DateTimePickerOrder
        '
        Me.DateTimePickerOrder.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOrder.Location = New System.Drawing.Point(426, 10)
        Me.DateTimePickerOrder.Name = "DateTimePickerOrder"
        Me.DateTimePickerOrder.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePickerOrder.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "AUTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Number"
        '
        'dgvProdTransact
        '
        Me.dgvProdTransact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdTransact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProdTransact.Location = New System.Drawing.Point(0, 105)
        Me.dgvProdTransact.Name = "dgvProdTransact"
        Me.dgvProdTransact.Size = New System.Drawing.Size(909, 264)
        Me.dgvProdTransact.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 329)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(909, 40)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Product Id"
        '
        'TextBoxProduct
        '
        Me.TextBoxProduct.Location = New System.Drawing.Point(90, 8)
        Me.TextBoxProduct.Name = "TextBoxProduct"
        Me.TextBoxProduct.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxProduct.TabIndex = 1
        '
        'NumericUpDownQtt
        '
        Me.NumericUpDownQtt.Location = New System.Drawing.Point(665, 8)
        Me.NumericUpDownQtt.Name = "NumericUpDownQtt"
        Me.NumericUpDownQtt.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDownQtt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(639, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Qtt"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(763, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Save To List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonSearchProduct
        '
        Me.ButtonSearchProduct.Location = New System.Drawing.Point(265, 7)
        Me.ButtonSearchProduct.Name = "ButtonSearchProduct"
        Me.ButtonSearchProduct.Size = New System.Drawing.Size(38, 23)
        Me.ButtonSearchProduct.TabIndex = 7
        Me.ButtonSearchProduct.Text = "..."
        Me.ButtonSearchProduct.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(346, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Product Name"
        '
        'TextBoxProductName
        '
        Me.TextBoxProductName.Location = New System.Drawing.Point(425, 9)
        Me.TextBoxProductName.Name = "TextBoxProductName"
        Me.TextBoxProductName.ReadOnly = True
        Me.TextBoxProductName.Size = New System.Drawing.Size(182, 20)
        Me.TextBoxProductName.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBoxProductName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ButtonSearchProduct)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.NumericUpDownQtt)
        Me.Panel3.Controls.Add(Me.TextBoxProduct)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(909, 38)
        Me.Panel3.TabIndex = 7
        Me.Panel3.Visible = False
        '
        'UserControlOrderModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvProdTransact)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControlOrderModify"
        Me.Size = New System.Drawing.Size(909, 369)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProdTransact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownQtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonSearchSupplier As System.Windows.Forms.Button
    Friend WithEvents TextBoxSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvProdTransact As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonSearchProduct As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownQtt As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
