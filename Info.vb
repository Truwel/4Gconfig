Public Class 键值配置
    Public KeyValueList As New List(Of 键值对)
    Public Event Update()
    Public 串口状态 As 通讯状态 = 通讯状态.串口未连接
    Public Enum 通讯状态
        串口未连接
        正在通讯
        通讯失败
        返回错误
        操作成功
        未知
    End Enum
    Public Shared Function 获取状态颜色文本(Stack As 通讯状态) As String
        Dim Cl As Color = Color.DodgerBlue
        Select Case Stack
            Case 通讯状态.串口未连接
                Cl = Color.Black
            Case 通讯状态.操作成功
                Cl = Color.Green
            Case 通讯状态.正在通讯
                Cl = Color.DodgerBlue
            Case 通讯状态.返回错误
                Cl = Color.Red
            Case 通讯状态.通讯失败
                Cl = Color.Red
        End Select
        Return String.Concat("<color=", Cl.R, ",", Cl.G, ",", Cl.B, ">")
    End Function
    Public Shared Function 获取状态图像(ImgCode As String) As Bitmap
        Select Case [Enum].Parse(GetType(通讯状态), ImgCode)
            Case 通讯状态.串口未连接
                Return My.Resources.nolink.Clone
            Case 通讯状态.操作成功
                Return My.Resources.setok.Clone
            Case 通讯状态.正在通讯
                Return My.Resources.link.Clone
            Case 通讯状态.返回错误
                Return My.Resources.seterror.Clone
            Case 通讯状态.通讯失败
                Return My.Resources.linkerror.Clone
            Case Else
                Return Nothing
        End Select
    End Function
    Private Sub ItemSelectedChanged(Itm As 键值对)
        ' 透传服务器域名,透传服务器端口,数据服务器域名,数据服务器端口,数据上传协议选择,设备通讯串口配置
        For Each Itmd As 键值对 In KeyValueList
            If Itmd.Equals(Itm) Then Continue For
            Select Case Itm.Name
                Case "透传服务器域名"
                    设置键值选定或未选("透传服务器端口", Itm.Selected)
                    Exit Select
                Case "透传服务器端口"
                    设置键值选定或未选("透传服务器域名", Itm.Selected)
                    Exit Select
                Case "数据服务器域名"
                    设置键值选定或未选("数据服务器端口", Itm.Selected)
                    设置键值选定或未选("数据上传协议选择", Itm.Selected)
                    Exit Select
                Case "数据服务器端口"
                    设置键值选定或未选("数据服务器域名", Itm.Selected)
                    设置键值选定或未选("数据上传协议选择", Itm.Selected)
                    Exit Select
                Case "数据上传协议选择"
                    设置键值选定或未选("数据服务器域名", Itm.Selected)
                    设置键值选定或未选("数据服务器端口", Itm.Selected)
                    Exit Select
            End Select
        Next
        RaiseEvent Update()
    End Sub
    Public Function 获取键值(KeyName As String) As 键值对
        For Each Itm As 键值对 In KeyValueList
            If KeyName.ToLower = Itm.Name.ToLower Then Return Itm
        Next
        Return Nothing
    End Function
    Public Function 获取项(nIndex As Integer) As 键值对
        Return KeyValueList(nIndex)
    End Function
    Public Sub 设置键值禁用或启用(KeyName As String, Checked As Boolean)
        For Each Itm As 键值对 In KeyValueList
            If KeyName.ToLower = Itm.Name.ToLower Then
                Itm.Checked = Checked
                Exit Sub
            End If
        Next
    End Sub
    Public Function 获取键值禁用或启用(KeyName As String) As Boolean
        For Each Itm As 键值对 In KeyValueList
            If KeyName.ToLower = Itm.Name.ToLower Then Return Itm.Checked
        Next
        Return False
    End Function
    Public Function 获取键值选定或未选(KeyName As String) As Boolean
        For Each Itm As 键值对 In KeyValueList
            If KeyName.ToLower = Itm.Name.ToLower Then Return Itm.Selected
        Next
        Return False
    End Function

    Public Sub 设置键值选定或未选(KeyName As String, Selected As Boolean)
        For Each Itm As 键值对 In KeyValueList
            If KeyName.ToLower = Itm.Name.ToLower Then
                Itm.Selected = Selected
                Exit Sub
            End If
        Next
    End Sub
    Public Sub 设置键值禁用或启用(KeyIndex As Integer, Checked As Boolean)
        KeyValueList(KeyIndex).Checked = Checked
    End Sub
    Public Sub 设置键值选定或未选(KeyIndex As Integer, Selected As Boolean)
        KeyValueList(KeyIndex).Selected = Selected
    End Sub
    Public Function 获取键值禁用或启用(KeyIndex As Integer) As Boolean
        Return KeyValueList(KeyIndex).Checked
    End Function
    Public Function 获取键值选定或未选(KeyIndex As Integer) As Boolean
        Return KeyValueList(KeyIndex).Selected
    End Function
    Public Sub New()
        AddHandler 键值对.Create(KeyValueList, "IMEI号").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "设备型号").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "版本号").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "透传服务器域名").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "透传服务器端口").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "数据服务器域名").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "数据服务器端口").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "数据上传协议选择", "透传").SelectedChanged, AddressOf ItemSelectedChanged
        AddHandler 键值对.Create(KeyValueList, "设备通讯串口配置").SelectedChanged, AddressOf ItemSelectedChanged
    End Sub
    Public Class 键值对
        Public Name As String = ""
        Public Checked As Boolean = False
        Public Value As String = ""
        Private _Selected As Boolean = True
        Public Property Selected As Boolean
            Get
                Return _Selected
            End Get
            Set(value As Boolean)
                Dim Bl As Boolean = _Selected <> value
                _Selected = value
                If Bl Then RaiseEvent SelectedChanged(Me)
            End Set
        End Property
        Friend Event SelectedChanged(Itm As 键值对)
        Sub New()
        End Sub
        Sub New(_Name As String)
            Name = _Name
        End Sub
        Public Shared Function Create(Lst As List(Of 键值对), _Name As String， Optional _Value As String = "") As 键值对
            Dim Itm As New 键值对(_Name)
            Itm.Value = _Value
            Lst.Add(Itm)
            Return Itm
        End Function
    End Class
End Class
