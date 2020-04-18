Public Class Form2
    Private WithEvents 文件拖放 As New DLAPI.控件.文件拖放助手
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged, CheckBox4.CheckedChanged
        If Me.Created = False Then Exit Sub
        For Each Ct As Control In sender.parent.controls
            If Ct.Equals(sender) Then Continue For
            Ct.Enabled = Not CType(sender, CheckBox).Checked
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm = Me
        初始化()
        文件拖放.支持扩展名.Clear()
        文件拖放.支持扩展名.Add("txt")
        GetCt(Me, 文件拖放.绑定控件列表)
        文件拖放.初始化()
        DS标签1.变量值("设备型号") = ""
        DS标签1.变量值("版本号") = ""

    End Sub
    Private Sub GetCt(Ct As Control, ByRef Lst As List(Of Control))
        Lst.Add(Ct)
        If Ct.HasChildren Then
            For Each C As Control In Ct.Controls
                GetCt(C, Lst)
            Next
        End If
    End Sub
    Private Sub 串口设置SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 串口设置SToolStripMenuItem.Click

    End Sub

    Private Sub 关于AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AToolStripMenuItem.Click
        Dim F As New 关于窗口
        F.ShowDialog()
    End Sub

    Private Sub 打开串口OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开串口OToolStripMenuItem.Click
        Dim 串口名称 As String = DLAPI.串口通讯.显示串口选择界面.选择的串口名称("串口设置", True)
        If 串口名称 Is Nothing Then Exit Sub
        If 串口名称 = "关闭串口" Then
            RS.关闭串口()
            显示消息 = ""
            Exit Sub
        End If
        连接串口(串口名称)
    End Sub
    Private Sub 连接串口(COMNAME As String)
        With RS.配置
            .编码 = System.Text.Encoding.ASCII
            .波特率 = 115200
            SaveSetting(Application.ProductName, "serialport", "comname", COMNAME)
            SaveSetting(Application.ProductName, "serialport", "encoding", .编码.BodyName)
            SaveSetting(Application.ProductName, "serialport", "bitr", .波特率)
        End With
        RS.打开串口(COMNAME)
        If RS.串口已经打开 Then
            显示消息 = "<color=50,50,255>正在等待和设备握手通讯</color>"
            '读取设备信息()
            ' DS按钮3.Enabled = True
        End If
    End Sub

    Private Sub 关闭串口CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭串口CToolStripMenuItem.Click
        RS.关闭串口()
    End Sub

    Private Sub 打开串口OToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles 打开串口OToolStripMenuItem.DropDownOpening
        关闭串口CToolStripMenuItem.Enabled = RS.串口已经打开
        显示消息 = ""
    End Sub

    Private Sub DS按钮1_ButtonClick(Sender As Object) Handles DS按钮1.ButtonClick
        '------------
        Dim SP() As String = New String() {"240305204"， "240305504"}
        If IMEI.Text.StartsWith(SP(0)) = False AndAlso IMEI.Text.StartsWith(SP(1)) = False Then
            DLAPI.控件.Form窗体.显示窗体遮罩(Me, "输入的<color=255,100,0>IMEI号</color>不正确", Color.White, Color.Black, Me.Font,, 0.5, True, True)
            Exit Sub
        End If
        '-------------
        '启动配置流程()
        ' 可以写入 = True
        Sender.enabled = False
        Sender.refresh
        配置文件.从窗体自动读取配置()
        保存默认配置文件()
        启动配置流程()



    End Sub



    Private Sub DS标签5_点击链接(sender As Object, Lk As DSControls.图形图像.彩色文字图像.链接) Handles DS标签5.点击链接

    End Sub

    Private Sub DS标签5_请求图像(sender As Object, ImgCode As String, ByRef 返回图像 As Bitmap) Handles DS标签5.请求图像
        Dim B As Bitmap = My.Resources.ResourceManager.GetObject(ImgCode)
        If B IsNot Nothing Then 返回图像 = B.Clone
    End Sub

    Private Sub DS按钮2_ButtonClick(Sender As Object) Handles DS按钮2.ButtonClick

    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Dim ComName, Enc, Bitr As String
            ComName = GetSetting(Application.ProductName, "serialport", "comname")
            Enc = GetSetting(Application.ProductName, "serialport", "encoding")
            Bitr = GetSetting(Application.ProductName, "serialport", "bitr")
            If ComName.Length = 0 Then Exit Try
            If Enc.Length = 0 Then Exit Try
            If IsNumeric(Bitr) = False Then Exit Try
            Dim Encd As System.Text.Encoding = System.Text.Encoding.GetEncoding(Enc)
            RS.配置.编码 = Encd
            RS.配置.波特率 = Bitr
            RS.应用配置()
            连接串口(ComName)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'Dim T As New Threading.Thread(AddressOf 串口检测线程)
        'T.IsBackground = True
        'T.Start()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        ' 可以写入 = CheckBox8.Checked
        If CheckBox8.Checked Then
            配置文件.从窗体自动读取配置()
            保存默认配置文件()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            透传服务器域名.ReadOnly = False
        Else
            透传服务器域名.ReadOnly = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            透传服务器端口.ReadOnly = False
        Else
            透传服务器端口.ReadOnly = True
        End If
    End Sub

    Private Sub DS按钮2_选定状态更改(Checked As Boolean) Handles DS按钮2.选定状态更改
        Select Case Checked
            Case True
                ' 可以写入 = True
                配置文件.从窗体自动读取配置()
                保存默认配置文件()
                DS按钮2.Text = "停止更新配置<color=255,200,0>(&U)</color>"
            Case False
                '  可以写入 = False
                DS按钮2.Text = "开始更新配置<color=255,200,0>(&U)</color>"
                显示消息 = "停止更新配置状态"
        End Select
    End Sub

    Private Sub 文件拖放_拖入文件(控件 As Control, 文件路径() As String) Handles 文件拖放.拖入文件
        If 文件路径.Length = 0 Then Exit Sub
        Dim F As String = 文件路径(0)
        Dim S As String = IO.File.ReadAllText(F, System.Text.Encoding.UTF8)
        If S.Contains("IMEI=") = False AndAlso S.Contains("设备型号=") = False Then Exit Sub
        Try
            配置文件.从文件自动读取配置(S)
            配置文件.将数据填写到窗体控件()
        Catch
        End Try
    End Sub


    Private Sub 打开文件FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开文件FToolStripMenuItem.Click
        Dim OFD As New OpenFileDialog
        With OFD
            .InitialDirectory = Application.StartupPath
            .Filter = "文本文件|*.txt|所有文件|*.*"
            If .ShowDialog = DialogResult.OK Then
                Dim S As String = IO.File.ReadAllText(.FileName, System.Text.Encoding.UTF8)
                If S.Contains("IMEI=") = False AndAlso S.Contains("设备型号=") = False Then Exit Sub
                Try
                    配置文件.从文件自动读取配置(S)
                    配置文件.将数据填写到窗体控件()
                Catch
                End Try
            End If
        End With
    End Sub

    Private Sub 设备通讯串口_TextChanged(sender As Object, e As EventArgs) Handles 设备通讯串口.TextChanged

    End Sub

    Private Sub 设备通讯串口_MouseClick(sender As Object, e As MouseEventArgs) Handles 设备通讯串口.MouseClick
        '  If e.Button <> MouseButtons.Left Then Exit Sub
        '  显示串口配置()
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        ' 通讯.设置IMEI("0000")
        IMEI.ReadOnly = Not CheckBox9.Checked
    End Sub

    Private Sub IMEI_TextChanged(sender As Object, e As EventArgs) Handles IMEI.TextChanged
        ' If IMEI.TextLength < 9 Then
        '     If DS按钮1.Enabled <> False Then DS按钮1.Enabled = False
        '     Exit Sub
        ' End If
        ' Dim SP() As String = New String() {"240305204"， "240305504"}
        ' If IMEI.Text.StartsWith(SP(0)) = False AndAlso IMEI.Text.StartsWith(SP(1)) = False Then
        '     If DS按钮1.Enabled <> False Then DS按钮1.Enabled = False
        '     DLAPI.Win7特性.设置TextBox控件水印文本(IMEI, "IMEI号有误")
        '     IMEI.Text = ""
        ' Elseif IMEI.TextLength=15 then 
        '     If DS按钮1.Enabled <> True Then DS按钮1.Enabled = True
        '     DLAPI.Win7特性.清除TextBox控件水印文本(IMEI)
        ' End If
    End Sub

    Private Sub 显示串口配置()
        Try
            Dim Fms As FormCollection = Application.OpenForms
            For Each F As Form In Fms
                If TypeOf (F) Is 设置 Then Exit Sub
            Next
            Dim Ff As New 设置
            Ff.TB = 设备通讯串口
            Ff.Show()
            Dim Rct As Rectangle = Me.RectangleToScreen(Me.ClientRectangle)
            Ff.Location = New Point(Rct.X, Rct.Bottom)
            Ff.Width = Me.ClientRectangle.Width
            DLAPI.控件.Form窗体.设置窗体跟随宿主窗体移动(Ff, Me, DLAPI.控件.Form窗体.锚定方向.左下)
        Catch
        End Try
    End Sub

    Private Sub DS按钮4_ButtonClick(Sender As Object) Handles DS按钮3.ButtonClick
        Sender.enabled = False
        Sender.refresh
        读取设备信息()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            显示串口配置()
        Else
            For Each F As Form In Application.OpenForms
                If TypeOf (F) Is 设置 Then
                    F.Dispose()
                    Exit Sub
                End If
            Next

            ' 设置.Dispose()
        End If

    End Sub
End Class