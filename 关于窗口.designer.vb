<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 关于窗口
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(关于窗口))
        Me.DS分组容器1 = New DSControls.DS分组容器()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DS分组容器1.Panel.SuspendLayout()
        Me.DS分组容器1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DS分组容器1
        '
        Me.DS分组容器1._LastHeight = 138
        Me.DS分组容器1.BackColor = System.Drawing.Color.Transparent
        Me.DS分组容器1.BackgroundImage = CType(resources.GetObject("DS分组容器1.BackgroundImage"), System.Drawing.Image)
        Me.DS分组容器1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DS分组容器1.ForeColor = System.Drawing.Color.White
        Me.DS分组容器1.Location = New System.Drawing.Point(0, 0)
        Me.DS分组容器1.Name = "DS分组容器1"
        Me.DS分组容器1.Padding = New System.Windows.Forms.Padding(2, 23, 2, 0)
        '
        'DS分组容器1.Panel1
        '
        Me.DS分组容器1.Panel.BackColor = System.Drawing.Color.Transparent
        Me.DS分组容器1.Panel.Controls.Add(Me.Label3)
        Me.DS分组容器1.Panel.Controls.Add(Me.Label2)
        Me.DS分组容器1.Panel.Controls.Add(Me.Label4)
        Me.DS分组容器1.Panel.Controls.Add(Me.Label1)
        Me.DS分组容器1.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DS分组容器1.Panel.ForeColor = System.Drawing.Color.Black
        Me.DS分组容器1.Panel.Location = New System.Drawing.Point(2, 23)
        Me.DS分组容器1.Panel.Name = "Panel1"
        Me.DS分组容器1.Panel.Size = New System.Drawing.Size(267, 115)
        Me.DS分组容器1.Panel.TabIndex = 1
        Me.DS分组容器1.Panel.标题文本偏移 = New System.Drawing.Point(0, 0)
        Me.DS分组容器1.Panel.贴图 = Nothing
        Me.DS分组容器1.Panel.贴图切割边距.上 = 0
        Me.DS分组容器1.Panel.贴图切割边距.下 = 0
        Me.DS分组容器1.Panel.贴图切割边距.右 = 0
        Me.DS分组容器1.Panel.贴图切割边距.左 = 0
        Me.DS分组容器1.Panel.边栏颜色 = System.Drawing.Color.Empty
        Me.DS分组容器1.Panel.边框颜色 = System.Drawing.Color.Empty
        Me.DS分组容器1.Panel.透明度 = 1.0!
        Me.DS分组容器1.Size = New System.Drawing.Size(271, 138)
        Me.DS分组容器1.TabIndex = 0
        Me.DS分组容器1.Text = "关于软件"
        Me.DS分组容器1.可关闭 = True
        Me.DS分组容器1.右圆角 = 0!
        Me.DS分组容器1.填充色 = System.Drawing.Color.White
        Me.DS分组容器1.左圆角 = 0!
        Me.DS分组容器1.标题栏背景色 = System.Drawing.Color.SteelBlue
        Me.DS分组容器1.渐变强度百分比 = 0.1!
        Me.DS分组容器1.激活时显示边框色 = System.Drawing.Color.Empty
        Me.DS分组容器1.点击关闭时 = DSControls.DS分组容器.关闭操作.关闭当前窗体
        Me.DS分组容器1.背景色透明度 = 1.0!
        Me.DS分组容器1.边框色 = System.Drawing.Color.Empty
        Me.DS分组容器1.锚定另一个 = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DTU配置软件 V1.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "www.truwel.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "北京华益瑞科技有限公司"
        '
        'Label1
        '
        Me.Label1.Image = Global._4G_.My.Resources.Resources.PictureBox1_Image
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.MaximumSize = New System.Drawing.Size(75, 75)
        Me.Label1.MinimumSize = New System.Drawing.Size(75, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 75)
        Me.Label1.TabIndex = 0
        '
        '关于窗口
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.DS分组容器1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "关于窗口"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.DS分组容器1.Panel.ResumeLayout(False)
        Me.DS分组容器1.Panel.PerformLayout()
        Me.DS分组容器1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS分组容器1 As DSControls.DS分组容器
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
