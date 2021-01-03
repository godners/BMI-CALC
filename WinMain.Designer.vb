<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NudStt = New System.Windows.Forms.NumericUpDown()
        Me.NudWgt = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblBMI = New System.Windows.Forms.Label()
        CType(Me.NudStt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudWgt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Stature:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Weight:"
        '
        'NudStt
        '
        Me.NudStt.Location = New System.Drawing.Point(127, 13)
        Me.NudStt.Margin = New System.Windows.Forms.Padding(4)
        Me.NudStt.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NudStt.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NudStt.Name = "NudStt"
        Me.NudStt.Size = New System.Drawing.Size(87, 32)
        Me.NudStt.TabIndex = 1
        Me.NudStt.Tag = "1"
        Me.NudStt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NudStt.Value = New Decimal(New Integer() {170, 0, 0, 0})
        '
        'NudWgt
        '
        Me.NudWgt.DecimalPlaces = 1
        Me.NudWgt.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NudWgt.Location = New System.Drawing.Point(127, 53)
        Me.NudWgt.Margin = New System.Windows.Forms.Padding(4)
        Me.NudWgt.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NudWgt.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NudWgt.Name = "NudWgt"
        Me.NudWgt.Size = New System.Drawing.Size(87, 32)
        Me.NudWgt.TabIndex = 2
        Me.NudWgt.Tag = "2"
        Me.NudWgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NudWgt.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 24)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "CM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "KG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "BMI:"
        '
        'LblBMI
        '
        Me.LblBMI.AutoSize = True
        Me.LblBMI.Location = New System.Drawing.Point(126, 93)
        Me.LblBMI.Margin = New System.Windows.Forms.Padding(4)
        Me.LblBMI.Name = "LblBMI"
        Me.LblBMI.Size = New System.Drawing.Size(130, 24)
        Me.LblBMI.TabIndex = 94
        Me.LblBMI.Text = "20.8 KG/M2"
        '
        'WinMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 130)
        Me.Controls.Add(Me.LblBMI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NudWgt)
        Me.Controls.Add(Me.NudStt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI CALC"
        CType(Me.NudStt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudWgt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NudStt As NumericUpDown
    Friend WithEvents NudWgt As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblBMI As Label
End Class
