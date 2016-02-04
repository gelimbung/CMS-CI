<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProductInput
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxUom = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDownQttStock = New System.Windows.Forms.NumericUpDown()
        Me.ButtonSearachUom = New System.Windows.Forms.Button()
        Me.NumericUpDownPrice = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDownQttStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UOM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(67, 16)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxId.TabIndex = 4
        '
        'TextBoxUom
        '
        Me.TextBoxUom.Location = New System.Drawing.Point(67, 42)
        Me.TextBoxUom.Name = "TextBoxUom"
        Me.TextBoxUom.ReadOnly = True
        Me.TextBoxUom.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxUom.TabIndex = 5
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(67, 68)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxName.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Qtt "
        '
        'NumericUpDownQttStock
        '
        Me.NumericUpDownQttStock.Location = New System.Drawing.Point(68, 95)
        Me.NumericUpDownQttStock.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        Me.NumericUpDownQttStock.Name = "NumericUpDownQttStock"
        Me.NumericUpDownQttStock.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownQttStock.TabIndex = 11
        Me.NumericUpDownQttStock.ThousandsSeparator = True
        '
        'ButtonSearachUom
        '
        Me.ButtonSearachUom.Location = New System.Drawing.Point(277, 40)
        Me.ButtonSearachUom.Name = "ButtonSearachUom"
        Me.ButtonSearachUom.Size = New System.Drawing.Size(35, 23)
        Me.ButtonSearachUom.TabIndex = 12
        Me.ButtonSearachUom.Text = "..."
        Me.ButtonSearachUom.UseVisualStyleBackColor = True
        '
        'NumericUpDownPrice
        '
        Me.NumericUpDownPrice.Location = New System.Drawing.Point(68, 125)
        Me.NumericUpDownPrice.Maximum = New Decimal(New Integer() {-559939585, 902409669, 54, 0})
        Me.NumericUpDownPrice.Name = "NumericUpDownPrice"
        Me.NumericUpDownPrice.Size = New System.Drawing.Size(203, 20)
        Me.NumericUpDownPrice.TabIndex = 13
        Me.NumericUpDownPrice.ThousandsSeparator = True
        '
        'UserControlProductInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NumericUpDownPrice)
        Me.Controls.Add(Me.ButtonSearachUom)
        Me.Controls.Add(Me.NumericUpDownQttStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxUom)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserControlProductInput"
        Me.Size = New System.Drawing.Size(515, 342)
        CType(Me.NumericUpDownQttStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownQttStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonSearachUom As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownPrice As System.Windows.Forms.NumericUpDown

End Class
