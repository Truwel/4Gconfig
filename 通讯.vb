Imports System.Reflection
Module 通讯
    Public 配置文件 As New 配置
    Public WithEvents RS As New DLAPI.串口通讯
    Public MainForm As Form2 = Nothing
    Private _串口连接信息 As String = ""
    Private _显示消息 As String = ""
    Private _状态 As 图标状态 = 图标状态.设备未连接

    Public Enum 图标状态
        设备未连接
        设备已连接
        设备连接失败
        设置出错
        设置成功
    End Enum
    Public Sub 设置图标状态(Value As 图标状态)
        _状态 = Value
    End Sub
    Public Sub 初始化()
        串口连接信息 = "串口未连接"
    End Sub
    Public WriteOnly Property 显示消息 As String
        Set(value As String)
            _显示消息 = value
            刷新DS标签5()
        End Set
    End Property
    Private WriteOnly Property 串口连接信息 As String
        Set(value As String)
            _串口连接信息 = value
            刷新DS标签5()
        End Set
    End Property
    Sub SetOutText()
        If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
        Dim Lst As New List(Of String)
        With Lst
            Dim Sta As String = "nolink"
            Select Case _状态
                Case 图标状态.设备已连接
                    Sta = "link"
                Case 图标状态.设备未连接
                    Sta = "nolink"
                Case 图标状态.设备连接失败
                    Sta = "linkerror"
                Case 图标状态.设置出错
                    Sta = "seterror"
                Case 图标状态.设置成功
                    Sta = "setok"
            End Select
            .Add(String.Concat("<img=", Sta, ">"))
            If _串口连接信息.Length <> 0 Then .Add(_串口连接信息)
            If _显示消息.Length <> 0 Then .Add(_显示消息)
        End With
        MainForm.DS标签5.Text = Join(Lst.ToArray, " <color=200,200,200>|</color> ")
    End Sub
    Private Sub 刷新DS标签5()
        MainForm.BeginInvoke(New CrossAppDomainDelegate(AddressOf SetOutText))
    End Sub
    Private Sub RS_串口被关闭(ComName As String) Handles RS.串口被关闭
        串口连接信息 = "串口未连接"
    End Sub

    Private Sub RS_串口打开成功(ComName As String) Handles RS.串口打开成功
        串口连接信息 = "<color=0,200,0>串口已连接</color>"
    End Sub

    Private Sub RS_收到数据(ComName As String, e() As Byte) Handles RS.收到数据

    End Sub

    Private Sub RS_串口打开失败(ComName As String) Handles RS.串口打开失败
        串口连接信息 = "<color=200,0,0>串口连接失败</color>"
    End Sub
    Private Delegate Sub _给控件赋值(Ct As Control, Value As String)
    Private Sub 给控件赋值(Ct As Control, Value As Object)
        Ct.Text = Value
    End Sub
    Public Enum 返回值
        [OK]
        [Error]
        [NA]
    End Enum
    <Serializable>
    Public Class 配置
        Public 设备通讯串口 As String = ""
        Public 数据服务器端口 As String = 0
        Public 数据上传协议 As String = ""
        Public 数据服务器域名 As String = ""
        Public 透传服务器端口 As String = 0
        Public 透传服务器域名 As String = ""
        Public 设备型号 As String = ""
        Public IMEI As String = ""
        Public 固件版本 As String = ""
        Public Overrides Function ToString() As String
            Dim Lst As New List(Of String)
            With Lst
                .Add("IMEI=" & IMEI)
                .Add("设备型号=" & 设备型号)
                .Add("固件版本=" & 固件版本)
                .Add("设备通讯串口=" & 设备通讯串口)
                .Add("数据服务器端口=" & 数据服务器端口)
                .Add("数据上传协议=" & 数据上传协议)
                .Add("数据服务器域名=" & 数据服务器域名)
                .Add("透传服务器端口=" & 透传服务器端口)
                .Add("透传服务器域名=" & 透传服务器域名)
            End With
            Return Join(Lst.ToArray, vbCrLf)
        End Function
        Public Sub 从窗体自动读取配置()
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
            Dim Tp As Type = Me.GetType
            For Each Fd As FieldInfo In Tp.GetFields
                Try
                    Dim Obj() As Control = MainForm.Controls.Find(Fd.Name, True)
                    If Obj IsNot Nothing Then
                        Fd.SetValue(Me, Obj(0).Text)
                    End If
                Catch
                End Try
            Next
        End Sub
        Public Sub 从文件自动读取配置(S As String)
            Dim Tp As Type = Me.GetType
            For Each Fd As FieldInfo In Tp.GetFields
                Try
                    Dim M As String = DLAPI.字串提取.提取指定字符串开头的行(S, Fd.Name & "=", "=")
                    Try
                        Fd.SetValue(Me, M)
                    Catch
                    End Try
                Catch
                End Try
            Next
        End Sub
        Public Sub 将数据填写到窗体控件()
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
            Dim Tp As Type = Me.GetType
            For Each Fd As FieldInfo In Tp.GetFields
                Try
                    Dim Obj() As Control = MainForm.Controls.Find(Fd.Name, True)
                    If Obj IsNot Nothing Then
                        MainForm.BeginInvoke(New _给控件赋值(AddressOf 给控件赋值), Obj(0), Fd.GetValue(Me))
                    End If
                Catch
                End Try
            Next
            MainForm.DS标签1.变量值("设备型号") = 设备型号
            MainForm.DS标签1.变量值("版本号") = 固件版本
        End Sub
    End Class
#Region "读取或保存配置"
    Public Sub 读取配置文件()
        Try
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
            Dim Ofd As New OpenFileDialog
            With Ofd
                .Filter = "ml文件|*.ml|所有文件|*.*"
                .DefaultExt = ".ml"
                If .ShowDialog = DialogResult.OK Then
                    配置文件 = New DLAPI.反射.序列化().反序列化(.FileName)
                End If
            End With
        Catch
            MsgBox("配置文件已损坏!", vbOKOnly + vbCritical)
        End Try
    End Sub
    Public Sub 读取默认配置文件()
        Try
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
            Dim Pth As String = String.Concat(Application.StartupPath, "\config.ml").Replace("\\", "\")
            If IO.File.Exists(Pth) = False Then Exit Sub
            Dim Ofd As New OpenFileDialog
            配置文件 = New DLAPI.反射.序列化().反序列化(Pth)

        Catch
        End Try
    End Sub
    Public Sub 保存默认配置文件()
        Try
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
            Dim Pth As String = String.Concat(Application.StartupPath, "\config.ml").Replace("\\", "\")
            If IO.File.Exists(Pth) = False Then Exit Sub
            Dim Sz As New DLAPI.反射.序列化
            Sz.序列化(Pth, 配置文件)
        Catch
        End Try

        'Try
        '    If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
        '    Dim Ofd As New SaveFileDialog
        '    With Ofd
        '        .Title = "保存"
        '        .Filter = "ml文件|*.ml|所有文件|*.*"
        '        If .ShowDialog = DialogResult.OK Then
        '            Dim Sz As New DSAPI.反射.序列化
        '            Sz.序列化(.FileName, 配置文件)
        '        End If
        '    End With
        'Catch
        '    MsgBox("配置文件已损坏!", vbOKOnly + vbCritical)
        'End Try
    End Sub
    Private Sub 保存到IMEI文件()
        Try
            Dim Pth As String = Application.StartupPath & "\IMEIs\"
            Pth = Pth.Replace("\\", "\")
            If IO.Directory.Exists(Pth) = False Then
                IO.Directory.CreateDirectory(Pth)
            End If
            IO.File.WriteAllText(Pth & 配置文件.IMEI & ".txt", 配置文件.ToString, System.Text.Encoding.UTF8)
        Catch
        End Try
    End Sub
    Public Sub 保存配置文件()
        Try
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub
            Dim Ofd As New SaveFileDialog
            With Ofd

                .Filter = "ml文件|*.ml|所有文件|*.*"
                If .ShowDialog = DialogResult.OK Then
                    Dim Sz As New DLAPI.反射.序列化
                    Sz.序列化(.FileName, 配置文件)
                End If
            End With
        Catch
            MsgBox("配置文件已损坏!", vbOKOnly + vbCritical)
        End Try
    End Sub
#End Region
#Region "流程"
    Public Sub 启动配置流程()
        Try
            Dim T As New Threading.Thread(AddressOf _配置线程)
            T.IsBackground = True
            T.Start()
        Catch
        End Try
    End Sub
    Public Sub 读取设备信息()
        Try
            Dim T As New Threading.Thread(AddressOf _读取线程)
            T.IsBackground = True
            T.Start()
        Catch
        End Try
    End Sub
    Private Delegate Sub _SetDS3Enabled(T As Boolean, T2 As Boolean)
    Private Sub SetDS3Enabled(T As Boolean, T2 As Boolean)
        MainForm.DS按钮3.Enabled = T
        MainForm.DS按钮1.Enabled = T2
    End Sub
    Private Sub _配置线程()
        Dim 操作成功 As Boolean = False
        Try
            显示消息 = "正在和设备通讯..."
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Try
            Dim Rtn As 返回值 = 握手()
            'Console.WriteLine(Rtn.ToString)
            If Rtn <> 返回值.OK Then 显示消息 = "设备握手超时..." : Exit Try
            With 配置文件

                If 设置IMEI(.IMEI) <> 返回值.OK Then 设置图标状态(图标状态.设置出错) : Exit Try  '内部版本

                If 设置透传域名(.透传服务器域名) <> 返回值.OK Then 设置图标状态(图标状态.设置出错) : Exit Try
                If 设置透传端口(.透传服务器端口) <> 返回值.OK Then 设置图标状态(图标状态.设置出错) : Exit Try
                If 设置串口配置(.设备通讯串口) <> 返回值.OK Then 设置图标状态(图标状态.设置出错) : Exit Try

            End With
            If 结束() <> 返回值.OK Then 设置图标状态(图标状态.设置出错) : Exit Try
            操作成功 = True
        Catch
        End Try
        设置图标状态(图标状态.设置成功)
        Select Case 操作成功
            Case True
                显示消息 = "操作成功完成"
                设置图标状态(图标状态.设置成功)

            Case False
                显示消息 = "操作失败"
                设置图标状态(图标状态.设置出错)
        End Select
        保存到IMEI文件()
        '可以写入 = False
        MainForm.Invoke(New _SetDS3Enabled(AddressOf SetDS3Enabled), False, True)
        MainForm.Invoke(New _SetDS3Enabled(AddressOf SetDS3Enabled), True, False)

    End Sub
    Sub _读取线程()
        Try
            If MainForm Is Nothing OrElse MainForm.IsDisposed Then Exit Sub

            显示消息 = "正在读取..."
            While True
                Threading.Thread.Sleep(1000)
                Dim Rtn As 返回值 = 握手()
                If Rtn <> 返回值.OK Then 显示消息 = "设备握手超时..." : Continue While
                    With 配置文件
                        Dim VER() As String = 读取设备型号和版本()
                        .固件版本 = VER(1)
                        .设备型号 = VER(0)
                        .透传服务器域名 = 读取透传服务器域名()
                        .透传服务器端口 = 读取透传服务器端口()
                        .设备通讯串口 = 读取串口配置()
                        .IMEI = 读取IMEI()
                    End With
                    '结束()
                    配置文件.将数据填写到窗体控件()
                    显示消息 = "设备已连接"
                    设置图标状态(图标状态.设备已连接)


                Exit While

            End While
            MainForm.Invoke(New _SetDS3Enabled(AddressOf SetDS3Enabled), True, True)
            MainForm.Invoke(New _SetDS3Enabled(AddressOf SetDS3Enabled), False, True)
        Catch ex As Exception
            Console.WriteLine(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Private Function 结束() As 返回值
        Return 发送信息("-finish")
    End Function
    Public Function 设置IMEI(IMEI As String) As 返回值
        输出当前步骤()
        Return 发送信息("-set imei " & IMEI)
    End Function
    Private Function 读取IMEI() As String
        Return 获取信息("-get imei")
    End Function
    Private Function 设置透传域名(Url As String) As 返回值
        输出当前步骤()
        Return 发送信息("-set server1 domain " & Url)
    End Function

    Private Function 读取串口配置() As String
        Return 获取信息("-get uart")
    End Function
    Private Function 设置串口配置(S As String) As 返回值
        输出当前步骤()
        Return 发送信息("-set uart " & S.Trim)
    End Function
    Private Function 读取透传服务器域名() As String
        Return 获取信息("-get server1 domain")
    End Function
    Private Function 设置透传端口(Port As Integer) As 返回值
        Return 发送信息("-set server1 port " & Port)
    End Function
    Private Function 读取透传服务器端口() As Integer
        Return 获取信息("-get server1 port")
    End Function
    Private Function 读取设备型号和版本() As String()
        Dim S As String = 获取信息("-get type")
        Return New String() {S.Substring(0, S.IndexOf(" ")), S.Substring(S.IndexOf(" ") + 1)}
    End Function
    ' Private Function 读取固件版本() As String
    '     Return 获取信息("-get version") -get type
    ' End Function
    Private Sub 输出当前步骤()
        Dim Stk As New StackTrace(True)
        显示消息 = "<b>执行操作：" & Stk.GetFrame(1).GetMethod.Name & "...</b>"
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
    End Sub
    Private Function 握手() As 返回值
        If RS.串口已经打开 = False Then Return 返回值.NA
        Dim Stp As New Stopwatch
        Stp.Start()
        While Stp.ElapsedMilliseconds < 60000
            Threading.Thread.Sleep(200)
            Dim 返回字串 As String = RS.读取数据_String("-handshake", 2000)
            If 返回字串 Is Nothing Then Continue While
            Dim M As String = 返回字串.Replace(vbCr, "").Replace(vbLf, "").Trim
            Console.WriteLine(M)
            Select Case M.ToLower
                Case "ok"
                    Return 返回值.OK
                Case "error"
                    Return 返回值.Error
                    'Case Else
                    '   Return 返回值.NA
            End Select
        End While
        Return 返回值.NA
    End Function
    Private Function 发送信息(信息 As String) As 返回值
        If RS.串口已经打开 = False Then Return 返回值.NA
        Dim 返回字串 As String = RS.读取数据_String(信息, 200)
        If 返回字串 Is Nothing Then Return 返回值.NA
        Dim M As String = 返回字串.Replace(vbCr, "").Replace(vbLf, "").Trim
        Select Case M.ToLower
            Case "ok"
                Return 返回值.OK
            Case "error"
                Return 返回值.Error
            Case Else
                Return 返回值.NA
        End Select
        Return 返回值.NA
    End Function
    Private Function 获取信息(信息 As String) As String
        If RS.串口已经打开 = False Then Return ""
        Dim 返回字串 As String = RS.读取数据_String(信息, 200)
        If 返回字串 Is Nothing Then Return ""
        Dim M As String = 返回字串.Replace(vbCr, "").Replace(vbLf, "").Trim
        Return M
    End Function
#End Region
End Module
