<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim 进度条1 As DSControls.DS按钮.进度条 = New DSControls.DS按钮.进度条()
        Dim 进度条2 As DSControls.DS按钮.进度条 = New DSControls.DS按钮.进度条()
        Dim 进度条3 As DSControls.DS按钮.进度条 = New DSControls.DS按钮.进度条()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.打开文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.串口设置SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开串口OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭串口CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DS容器1 = New DSControls.DS容器()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.IMEI = New System.Windows.Forms.TextBox()
        Me.DS标签1 = New DSControls.DS标签()
        Me.DS容器2 = New DSControls.DS容器()
        Me.透传服务器端口 = New DSControls.DS数字输入框()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.透传服务器域名 = New System.Windows.Forms.TextBox()
        Me.DS标签2 = New DSControls.DS标签()
        Me.DS容器3 = New DSControls.DS容器()
        Me.数据服务器端口 = New DSControls.DS数字输入框()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.数据上传协议 = New System.Windows.Forms.TextBox()
        Me.数据服务器域名 = New System.Windows.Forms.TextBox()
        Me.DS标签3 = New DSControls.DS标签()
        Me.DS容器4 = New DSControls.DS容器()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.设备通讯串口 = New System.Windows.Forms.TextBox()
        Me.DS标签4 = New DSControls.DS标签()
        Me.DS按钮1 = New DSControls.DS按钮()
        Me.DS标签5 = New DSControls.DS标签()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.DS按钮2 = New DSControls.DS按钮()
        Me.DS按钮3 = New DSControls.DS按钮()
        Me.MenuStrip1.SuspendLayout()
        Me.DS容器1.SuspendLayout()
        Me.DS容器2.SuspendLayout()
        Me.DS容器3.SuspendLayout()
        Me.DS容器4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开文件FToolStripMenuItem, Me.串口设置SToolStripMenuItem, Me.关于AToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '打开文件FToolStripMenuItem
        '
        Me.打开文件FToolStripMenuItem.Name = "打开文件FToolStripMenuItem"
        Me.打开文件FToolStripMenuItem.Size = New System.Drawing.Size(83, 18)
        Me.打开文件FToolStripMenuItem.Text = "打开文件(&F)"
        '
        '串口设置SToolStripMenuItem
        '
        Me.串口设置SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开串口OToolStripMenuItem, Me.关闭串口CToolStripMenuItem})
        Me.串口设置SToolStripMenuItem.Name = "串口设置SToolStripMenuItem"
        Me.串口设置SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.串口设置SToolStripMenuItem.Size = New System.Drawing.Size(83, 18)
        Me.串口设置SToolStripMenuItem.Text = "串口设置(&R)"
        '
        '打开串口OToolStripMenuItem
        '
        Me.打开串口OToolStripMenuItem.Name = "打开串口OToolStripMenuItem"
        Me.打开串口OToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.打开串口OToolStripMenuItem.Text = "打开串口(&O)"
        '
        '关闭串口CToolStripMenuItem
        '
        Me.关闭串口CToolStripMenuItem.Name = "关闭串口CToolStripMenuItem"
        Me.关闭串口CToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.关闭串口CToolStripMenuItem.Text = "关闭串口(&C)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(59, 18)
        Me.关于AToolStripMenuItem.Text = "关于(&A)"
        '
        'DS容器1
        '
        Me.DS容器1.BackColor = System.Drawing.Color.White
        Me.DS容器1.Controls.Add(Me.CheckBox9)
        Me.DS容器1.Controls.Add(Me.IMEI)
        Me.DS容器1.Controls.Add(Me.DS标签1)
        Me.DS容器1.Location = New System.Drawing.Point(36, 42)
        Me.DS容器1.Name = "DS容器1"
        Me.DS容器1.Padding = New System.Windows.Forms.Padding(1)
        Me.DS容器1.Size = New System.Drawing.Size(440, 38)
        Me.DS容器1.TabIndex = 1
        Me.DS容器1.标题文本偏移 = New System.Drawing.Point(0, 0)
        Me.DS容器1.贴图 = Nothing
        Me.DS容器1.贴图切割边距.上 = 0
        Me.DS容器1.贴图切割边距.下 = 0
        Me.DS容器1.贴图切割边距.右 = 0
        Me.DS容器1.贴图切割边距.左 = 0
        Me.DS容器1.边栏颜色 = System.Drawing.Color.Empty
        Me.DS容器1.边框颜色 = System.Drawing.Color.DodgerBlue
        Me.DS容器1.透明度 = 1.0!
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(382, 12)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox9.TabIndex = 1
        Me.CheckBox9.Text = "内部"
        Me.CheckBox9.UseVisualStyleBackColor = True
        Me.CheckBox9.Visible = False
        '
        'IMEI
        '
        Me.IMEI.Location = New System.Drawing.Point(50, 8)
        Me.IMEI.MaxLength = 15
        Me.IMEI.Name = "IMEI"
        Me.IMEI.ReadOnly = True
        Me.IMEI.Size = New System.Drawing.Size(118, 21)
        Me.IMEI.TabIndex = 0
        '
        'DS标签1
        '
        Me.DS标签1.BackColor = System.Drawing.Color.Transparent
        Me.DS标签1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DS标签1.Location = New System.Drawing.Point(1, 1)
        Me.DS标签1.Name = "DS标签1"
        Me.DS标签1.Size = New System.Drawing.Size(438, 36)
        Me.DS标签1.TabIndex = 0
        Me.DS标签1.Text = "IMEI:                         设备型号:<%设备型号%>   版本号:<%版本号%>"
        Me.DS标签1.偏移 = New System.Drawing.Point(10, 12)
        '
        'DS容器2
        '
        Me.DS容器2.BackColor = System.Drawing.Color.White
        Me.DS容器2.Controls.Add(Me.透传服务器端口)
        Me.DS容器2.Controls.Add(Me.CheckBox3)
        Me.DS容器2.Controls.Add(Me.CheckBox2)
        Me.DS容器2.Controls.Add(Me.CheckBox1)
        Me.DS容器2.Controls.Add(Me.透传服务器域名)
        Me.DS容器2.Controls.Add(Me.DS标签2)
        Me.DS容器2.Location = New System.Drawing.Point(36, 85)
        Me.DS容器2.Name = "DS容器2"
        Me.DS容器2.Padding = New System.Windows.Forms.Padding(1)
        Me.DS容器2.Size = New System.Drawing.Size(441, 67)
        Me.DS容器2.TabIndex = 2
        Me.DS容器2.标题文本偏移 = New System.Drawing.Point(0, 0)
        Me.DS容器2.贴图 = Nothing
        Me.DS容器2.贴图切割边距.上 = 0
        Me.DS容器2.贴图切割边距.下 = 0
        Me.DS容器2.贴图切割边距.右 = 0
        Me.DS容器2.贴图切割边距.左 = 0
        Me.DS容器2.边栏颜色 = System.Drawing.Color.Empty
        Me.DS容器2.边框颜色 = System.Drawing.Color.DodgerBlue
        Me.DS容器2.透明度 = 1.0!
        '
        '透传服务器端口
        '
        Me.透传服务器端口.Location = New System.Drawing.Point(122, 36)
        Me.透传服务器端口.Name = "透传服务器端口"
        Me.透传服务器端口.ReadOnly = True
        Me.透传服务器端口.Size = New System.Drawing.Size(153, 21)
        Me.透传服务器端口.TabIndex = 6
        Me.透传服务器端口.Text = "0"
        Me.透传服务器端口.最大值 = 65535
        '
        'CheckBox3
        '
        Me.CheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox3.Location = New System.Drawing.Point(382, 1)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(58, 65)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "禁用"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.Location = New System.Drawing.Point(14, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Location = New System.Drawing.Point(14, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        '透传服务器域名
        '
        Me.透传服务器域名.Location = New System.Drawing.Point(122, 10)
        Me.透传服务器域名.Name = "透传服务器域名"
        Me.透传服务器域名.ReadOnly = True
        Me.透传服务器域名.Size = New System.Drawing.Size(153, 21)
        Me.透传服务器域名.TabIndex = 2
        '
        'DS标签2
        '
        Me.DS标签2.BackColor = System.Drawing.Color.Transparent
        Me.DS标签2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DS标签2.Location = New System.Drawing.Point(1, 1)
        Me.DS标签2.Name = "DS标签2"
        Me.DS标签2.Size = New System.Drawing.Size(381, 65)
        Me.DS标签2.TabIndex = 0
        Me.DS标签2.Text = "透传服务器域名:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "透传服务器端口:"
        Me.DS标签2.偏移 = New System.Drawing.Point(26, 12)
        Me.DS标签2.行间距 = 14
        '
        'DS容器3
        '
        Me.DS容器3.BackColor = System.Drawing.Color.White
        Me.DS容器3.Controls.Add(Me.数据服务器端口)
        Me.DS容器3.Controls.Add(Me.CheckBox4)
        Me.DS容器3.Controls.Add(Me.CheckBox7)
        Me.DS容器3.Controls.Add(Me.CheckBox5)
        Me.DS容器3.Controls.Add(Me.CheckBox6)
        Me.DS容器3.Controls.Add(Me.数据上传协议)
        Me.DS容器3.Controls.Add(Me.数据服务器域名)
        Me.DS容器3.Controls.Add(Me.DS标签3)
        Me.DS容器3.Location = New System.Drawing.Point(36, 158)
        Me.DS容器3.Name = "DS容器3"
        Me.DS容器3.Padding = New System.Windows.Forms.Padding(1)
        Me.DS容器3.Size = New System.Drawing.Size(441, 90)
        Me.DS容器3.TabIndex = 2
        Me.DS容器3.标题文本偏移 = New System.Drawing.Point(0, 0)
        Me.DS容器3.贴图 = Nothing
        Me.DS容器3.贴图切割边距.上 = 0
        Me.DS容器3.贴图切割边距.下 = 0
        Me.DS容器3.贴图切割边距.右 = 0
        Me.DS容器3.贴图切割边距.左 = 0
        Me.DS容器3.边栏颜色 = System.Drawing.Color.Empty
        Me.DS容器3.边框颜色 = System.Drawing.Color.DodgerBlue
        Me.DS容器3.透明度 = 1.0!
        '
        '数据服务器端口
        '
        Me.数据服务器端口.Enabled = False
        Me.数据服务器端口.Location = New System.Drawing.Point(122, 36)
        Me.数据服务器端口.Name = "数据服务器端口"
        Me.数据服务器端口.ReadOnly = True
        Me.数据服务器端口.Size = New System.Drawing.Size(153, 21)
        Me.数据服务器端口.TabIndex = 6
        Me.数据服务器端口.Text = "0"
        Me.数据服务器端口.最大值 = 65535
        '
        'CheckBox4
        '
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(382, 1)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(58, 88)
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.Text = "禁用"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox7.Enabled = False
        Me.CheckBox7.Location = New System.Drawing.Point(13, 66)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 10
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(14, 40)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 8
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(14, 13)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        '数据上传协议
        '
        Me.数据上传协议.Enabled = False
        Me.数据上传协议.Location = New System.Drawing.Point(122, 62)
        Me.数据上传协议.Name = "数据上传协议"
        Me.数据上传协议.ReadOnly = True
        Me.数据上传协议.Size = New System.Drawing.Size(153, 21)
        Me.数据上传协议.TabIndex = 11
        Me.数据上传协议.Text = "透传"
        '
        '数据服务器域名
        '
        Me.数据服务器域名.Enabled = False
        Me.数据服务器域名.Location = New System.Drawing.Point(122, 10)
        Me.数据服务器域名.Name = "数据服务器域名"
        Me.数据服务器域名.ReadOnly = True
        Me.数据服务器域名.Size = New System.Drawing.Size(153, 21)
        Me.数据服务器域名.TabIndex = 7
        '
        'DS标签3
        '
        Me.DS标签3.BackColor = System.Drawing.Color.Transparent
        Me.DS标签3.Dock = System.Windows.Forms.DockStyle.Left
        Me.DS标签3.Enabled = False
        Me.DS标签3.Location = New System.Drawing.Point(1, 1)
        Me.DS标签3.Name = "DS标签3"
        Me.DS标签3.Size = New System.Drawing.Size(381, 88)
        Me.DS标签3.TabIndex = 0
        Me.DS标签3.Text = "数据服务器域名:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "数据服务器端口:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "数据上传协议:"
        Me.DS标签3.偏移 = New System.Drawing.Point(26, 12)
        Me.DS标签3.行间距 = 14
        '
        'DS容器4
        '
        Me.DS容器4.BackColor = System.Drawing.Color.White
        Me.DS容器4.Controls.Add(Me.CheckBox11)
        Me.DS容器4.Controls.Add(Me.设备通讯串口)
        Me.DS容器4.Controls.Add(Me.DS标签4)
        Me.DS容器4.Location = New System.Drawing.Point(36, 254)
        Me.DS容器4.Name = "DS容器4"
        Me.DS容器4.Padding = New System.Windows.Forms.Padding(1)
        Me.DS容器4.Size = New System.Drawing.Size(441, 41)
        Me.DS容器4.TabIndex = 2
        Me.DS容器4.标题文本偏移 = New System.Drawing.Point(0, 0)
        Me.DS容器4.贴图 = Nothing
        Me.DS容器4.贴图切割边距.上 = 0
        Me.DS容器4.贴图切割边距.下 = 0
        Me.DS容器4.贴图切割边距.右 = 0
        Me.DS容器4.贴图切割边距.左 = 0
        Me.DS容器4.边栏颜色 = System.Drawing.Color.Empty
        Me.DS容器4.边框颜色 = System.Drawing.Color.DodgerBlue
        Me.DS容器4.透明度 = 1.0!
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox11.Location = New System.Drawing.Point(14, 13)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox11.TabIndex = 13
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        '设备通讯串口
        '
        Me.设备通讯串口.Cursor = System.Windows.Forms.Cursors.Hand
        Me.设备通讯串口.Location = New System.Drawing.Point(122, 10)
        Me.设备通讯串口.Name = "设备通讯串口"
        Me.设备通讯串口.ReadOnly = True
        Me.设备通讯串口.Size = New System.Drawing.Size(153, 21)
        Me.设备通讯串口.TabIndex = 14
        '
        'DS标签4
        '
        Me.DS标签4.BackColor = System.Drawing.Color.Transparent
        Me.DS标签4.Dock = System.Windows.Forms.DockStyle.Left
        Me.DS标签4.Location = New System.Drawing.Point(1, 1)
        Me.DS标签4.Name = "DS标签4"
        Me.DS标签4.Size = New System.Drawing.Size(381, 39)
        Me.DS标签4.TabIndex = 0
        Me.DS标签4.Text = "设备通讯串口:"
        Me.DS标签4.偏移 = New System.Drawing.Point(26, 12)
        Me.DS标签4.行间距 = 14
        '
        'DS按钮1
        '
        Me.DS按钮1.BackColor = System.Drawing.Color.Transparent
        Me.DS按钮1.BackgroundImage = CType(resources.GetObject("DS按钮1.BackgroundImage"), System.Drawing.Image)
        Me.DS按钮1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DS按钮1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DS按钮1.Enabled = False
        Me.DS按钮1.ForeColor = System.Drawing.Color.White
        Me.DS按钮1.Location = New System.Drawing.Point(368, 308)
        Me.DS按钮1.Margin = New System.Windows.Forms.Padding(1)
        Me.DS按钮1.Name = "DS按钮1"
        Me.DS按钮1.Size = New System.Drawing.Size(109, 26)
        Me.DS按钮1.TabIndex = 3
        Me.DS按钮1.Text = "更新配置<color=255,200,0>(&P)</color>"
        Me.DS按钮1.图像 = Nothing
        Me.DS按钮1.圆角角度 = 0
        Me.DS按钮1.异形透明度采样百分比 = 0.1!
        进度条1.指示进度 = 0!
        进度条1.进度条颜色 = System.Drawing.Color.DodgerBlue
        Me.DS按钮1.指示进度条 = 进度条1
        Me.DS按钮1.文本 = "更新配置<color=255,200,0>(&P)</color>"
        Me.DS按钮1.禁用时透明度 = 0.3!
        Me.DS按钮1.自动尺寸扩展 = New System.Drawing.Size(20, 20)
        Me.DS按钮1.自定义图像.按下 = Nothing
        Me.DS按钮1.自定义图像.禁用 = Nothing
        Me.DS按钮1.自定义图像.高亮 = Nothing
        Me.DS按钮1.自定义图像.默认 = Nothing
        Me.DS按钮1.贴图 = Nothing
        Me.DS按钮1.贴图切割边距.上 = 0
        Me.DS按钮1.贴图切割边距.下 = 0
        Me.DS按钮1.贴图切割边距.右 = 0
        Me.DS按钮1.贴图切割边距.左 = 0
        Me.DS按钮1.透明度 = 1.0!
        Me.DS按钮1.附加内容字体 = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DS按钮1.颜色 = System.Drawing.Color.DodgerBlue
        '
        'DS标签5
        '
        Me.DS标签5.BackColor = System.Drawing.Color.AliceBlue
        Me.DS标签5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DS标签5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DS标签5.Location = New System.Drawing.Point(0, 344)
        Me.DS标签5.Name = "DS标签5"
        Me.DS标签5.Size = New System.Drawing.Size(515, 24)
        Me.DS标签5.TabIndex = 4
        Me.DS标签5.Text = "DS标签5"
        Me.DS标签5.偏移 = New System.Drawing.Point(10, 5)
        Me.DS标签5.链接下划线 = DSControls.图形图像.彩色文字图像._下划线.鼠标悬浮时显示
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(37, 300)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox8.TabIndex = 6
        Me.CheckBox8.Text = "应用更改"
        Me.CheckBox8.UseVisualStyleBackColor = True
        Me.CheckBox8.Visible = False
        '
        'DS按钮2
        '
        Me.DS按钮2.BackColor = System.Drawing.Color.Transparent
        Me.DS按钮2.BackgroundImage = CType(resources.GetObject("DS按钮2.BackgroundImage"), System.Drawing.Image)
        Me.DS按钮2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DS按钮2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DS按钮2.ForeColor = System.Drawing.Color.White
        Me.DS按钮2.Location = New System.Drawing.Point(139, 308)
        Me.DS按钮2.Margin = New System.Windows.Forms.Padding(1)
        Me.DS按钮2.Name = "DS按钮2"
        Me.DS按钮2.Size = New System.Drawing.Size(65, 26)
        Me.DS按钮2.TabIndex = 3
        Me.DS按钮2.Text = "开始读取<color=255,200,0>(&U)</color>"
        Me.DS按钮2.Visible = False
        Me.DS按钮2.图像 = Nothing
        Me.DS按钮2.圆角角度 = 0
        Me.DS按钮2.异形透明度采样百分比 = 0.1!
        进度条2.指示进度 = 0!
        进度条2.进度条颜色 = System.Drawing.Color.DodgerBlue
        Me.DS按钮2.指示进度条 = 进度条2
        Me.DS按钮2.文本 = "开始读取<color=255,200,0>(&U)</color>"
        Me.DS按钮2.禁用时透明度 = 0.3!
        Me.DS按钮2.自动尺寸扩展 = New System.Drawing.Size(20, 20)
        Me.DS按钮2.自定义图像.按下 = Nothing
        Me.DS按钮2.自定义图像.禁用 = Nothing
        Me.DS按钮2.自定义图像.高亮 = Nothing
        Me.DS按钮2.自定义图像.默认 = Nothing
        Me.DS按钮2.贴图 = Nothing
        Me.DS按钮2.贴图切割边距.上 = 0
        Me.DS按钮2.贴图切割边距.下 = 0
        Me.DS按钮2.贴图切割边距.右 = 0
        Me.DS按钮2.贴图切割边距.左 = 0
        Me.DS按钮2.选定模式 = True
        Me.DS按钮2.选定颜色 = System.Drawing.Color.DodgerBlue
        Me.DS按钮2.透明度 = 1.0!
        Me.DS按钮2.附加内容字体 = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DS按钮2.颜色 = System.Drawing.Color.DodgerBlue
        '
        'DS按钮3
        '
        Me.DS按钮3.BackColor = System.Drawing.Color.Transparent
        Me.DS按钮3.BackgroundImage = CType(resources.GetObject("DS按钮3.BackgroundImage"), System.Drawing.Image)
        Me.DS按钮3.Cursor = System.Windows.Forms.Cursors.Default
        Me.DS按钮3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DS按钮3.ForeColor = System.Drawing.Color.White
        Me.DS按钮3.Location = New System.Drawing.Point(249, 308)
        Me.DS按钮3.Margin = New System.Windows.Forms.Padding(1)
        Me.DS按钮3.Name = "DS按钮3"
        Me.DS按钮3.Size = New System.Drawing.Size(101, 26)
        Me.DS按钮3.TabIndex = 8
        Me.DS按钮3.Text = "开始配置<color=255,200,0>(&U)</color>"
        Me.DS按钮3.图像 = Nothing
        Me.DS按钮3.圆角角度 = 0
        Me.DS按钮3.异形透明度采样百分比 = 0.1!
        进度条3.指示进度 = 0!
        进度条3.进度条颜色 = System.Drawing.Color.DodgerBlue
        Me.DS按钮3.指示进度条 = 进度条3
        Me.DS按钮3.文本 = "开始配置<color=255,200,0>(&U)</color>"
        Me.DS按钮3.禁用时透明度 = 0.3!
        Me.DS按钮3.自动尺寸扩展 = New System.Drawing.Size(20, 20)
        Me.DS按钮3.自定义图像.按下 = Nothing
        Me.DS按钮3.自定义图像.禁用 = Nothing
        Me.DS按钮3.自定义图像.高亮 = Nothing
        Me.DS按钮3.自定义图像.默认 = Nothing
        Me.DS按钮3.贴图 = Nothing
        Me.DS按钮3.贴图切割边距.上 = 0
        Me.DS按钮3.贴图切割边距.下 = 0
        Me.DS按钮3.贴图切割边距.右 = 0
        Me.DS按钮3.贴图切割边距.左 = 0
        Me.DS按钮3.透明度 = 1.0!
        Me.DS按钮3.附加内容字体 = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DS按钮3.颜色 = System.Drawing.Color.DodgerBlue
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(515, 368)
        Me.Controls.Add(Me.DS按钮3)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.DS标签5)
        Me.Controls.Add(Me.DS按钮2)
        Me.Controls.Add(Me.DS按钮1)
        Me.Controls.Add(Me.DS容器4)
        Me.Controls.Add(Me.DS容器3)
        Me.Controls.Add(Me.DS容器2)
        Me.Controls.Add(Me.DS容器1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DTU配置软件"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DS容器1.ResumeLayout(False)
        Me.DS容器1.PerformLayout()
        Me.DS容器2.ResumeLayout(False)
        Me.DS容器2.PerformLayout()
        Me.DS容器3.ResumeLayout(False)
        Me.DS容器3.PerformLayout()
        Me.DS容器4.ResumeLayout(False)
        Me.DS容器4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 串口设置SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DS容器1 As DSControls.DS容器
    Friend WithEvents IMEI As TextBox
    Friend WithEvents DS标签1 As DSControls.DS标签
    Friend WithEvents DS容器2 As DSControls.DS容器
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents 透传服务器域名 As TextBox
    Friend WithEvents DS标签2 As DSControls.DS标签
    Friend WithEvents DS容器3 As DSControls.DS容器
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents 数据服务器域名 As TextBox
    Friend WithEvents DS标签3 As DSControls.DS标签
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents DS容器4 As DSControls.DS容器
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents 设备通讯串口 As TextBox
    Friend WithEvents DS标签4 As DSControls.DS标签
    Friend WithEvents 数据上传协议 As TextBox
    Friend WithEvents DS按钮1 As DSControls.DS按钮
    Friend WithEvents DS标签5 As DSControls.DS标签
    Friend WithEvents 打开串口OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关闭串口CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 透传服务器端口 As DSControls.DS数字输入框
    Friend WithEvents 数据服务器端口 As DSControls.DS数字输入框
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents 打开文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents DS按钮2 As DSControls.DS按钮
    Friend WithEvents DS按钮3 As DSControls.DS按钮
End Class
