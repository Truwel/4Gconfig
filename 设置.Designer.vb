<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 设置
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(设置))
        Me.DS标签1 = New DSControls.DS标签()
        Me.CMB2 = New System.Windows.Forms.ComboBox()
        Me.CMB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DS标签1
        '
        Me.DS标签1.BackColor = System.Drawing.Color.Transparent
        Me.DS标签1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DS标签1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DS标签1.Location = New System.Drawing.Point(0, 0)
        Me.DS标签1.Name = "DS标签1"
        Me.DS标签1.Size = New System.Drawing.Size(514, 66)
        Me.DS标签1.TabIndex = 0
        Me.DS标签1.Text = resources.GetString("DS标签1.Text")
        Me.DS标签1.偏移 = New System.Drawing.Point(10, 10)
        Me.DS标签1.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.鼠标悬浮时显示
        '
        'CMB2
        '
        Me.CMB2.FormattingEnabled = True
        Me.CMB2.Location = New System.Drawing.Point(116, 41)
        Me.CMB2.Name = "CMB2"
        Me.CMB2.Size = New System.Drawing.Size(121, 20)
        Me.CMB2.TabIndex = 2
        Me.CMB2.Visible = False
        '
        'CMB
        '
        Me.CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB.FormattingEnabled = True
        Me.CMB.Location = New System.Drawing.Point(243, 34)
        Me.CMB.Name = "CMB"
        Me.CMB.Size = New System.Drawing.Size(76, 20)
        Me.CMB.TabIndex = 1
        Me.CMB.Visible = False
        '
        '设置
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(514, 66)
        Me.Controls.Add(Me.CMB2)
        Me.Controls.Add(Me.CMB)
        Me.Controls.Add(Me.DS标签1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "设置"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS标签1 As DSControls.DS标签
    Friend WithEvents CMB2 As ComboBox
    Friend WithEvents CMB As ComboBox
End Class
