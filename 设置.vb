Public Class 设置
    Public 波特率 As Integer = 9600
    Public 校验位 As IO.Ports.Parity = IO.Ports.Parity.None
    Public 数据位 As Integer = 8
    Public 停止位 As IO.Ports.StopBits = IO.Ports.StopBits.One
    Public TB As TextBox = Nothing
    Private 常用波特率() As String = "50、75、100、150、300、600、1200、2400、4800、9600、19200、38400、115200".Split("、")
    Private 常用数据位() As String = "7、8".Split("、")


    Private Sub 设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDS()
    End Sub
    Private Sub UpdateDS()
        DS标签1("波特率") = 波特率
        DS标签1("校验位") = 校验位
        DS标签1("数据位") = 数据位
        DS标签1("停止位") = 停止位
    End Sub
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()
        Me.Height = 0
        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub 设置_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DS标签1.SuspendLayout()
        For I As Integer = 0 To 63 Step 10
            Me.Height = I
            Threading.Thread.Sleep(30)
            Application.DoEvents()
        Next
        Me.Height = 63
        DS标签1.ResumeLayout()
        'DLAPI.控件.Form窗体.应用窗体投影(Me)
    End Sub

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Private Sub DS标签1_点击链接(sender As Object, Lk As DSControls.图形图像.彩色文字图像.链接) Handles DS标签1.点击链接
        Select Case Lk.标识信息
            Case "cancel"
                关闭自身()
            Case "app"
                If TB Is Nothing Then Exit Sub
                Dim Lst As New List(Of String)
                With Lst
                    .Add(波特率)
                    .Add(校验位.ToString.Substring(0, 1).ToLower)
                    .Add(数据位)
                    .Add(停止位)
                End With
                TB.Text = Join(Lst.ToArray, ",")
            Case Else
                ShowCbx(Lk)
        End Select
    End Sub
    Private Sub ShowCbx(Lk As DSControls.图形图像.彩色文字图像.链接)
        Try
            Dim Rct As Rectangle = Lk.RECTS(0)
            Rct.Width = GetWidth(Lk)
            If Rct.Width < 65 Then Rct.Width = 65
            Dim CB As ComboBox = Nothing
            Select Case Lk.标识信息
                Case "1"
                    CB = CMB2
                    CB.Items.Clear()
                    CB.Text = ""
                    CB.Tag = Lk.标识信息
                    CB.Items.AddRange(常用波特率)
                    CB.Text = 波特率
                Case "3"
                    CB = CMB2
                    CB.Items.Clear()
                    CB.Text = ""
                    CB.Tag = Lk.标识信息
                    CB.Items.AddRange(常用数据位)
                    CB.Text = 数据位

                Case "2"
                    CB = CMB
                    CB.Items.Clear()
                    CB.Text = ""
                    CB.Tag = Lk.标识信息

                    CB.Items.AddRange([Enum].GetNames(GetType(IO.Ports.Parity)))
                    If CB.Items.Contains(校验位.ToString) Then CB.Text = 校验位.ToString
                Case "4"
                    CB = CMB
                    CB.Items.Clear()
                    CB.Text = ""
                    CB.Tag = Lk.标识信息

                    CB.Items.AddRange([Enum].GetNames(GetType(IO.Ports.StopBits)))
                    If CB.Items.Contains(停止位.ToString) Then CB.Text = 停止位.ToString
                Case Else
                    If CB IsNot Nothing Then CB.Tag = Nothing
            End Select
            CB.Bounds = Rct
            CB.Show()
            CB.Focus()
        Catch
        End Try
    End Sub
    Private Function GetWidth(Lk As DSControls.图形图像.彩色文字图像.链接) As Integer
        Dim N As Integer = 0
        For Each R As Rectangle In Lk.RECTS
            Dim X As Integer = R.Right - Lk.RECTS(0).X
            If X > N Then N = X
        Next
        Return N
    End Function
    Private Sub CMB_LostFocus(sender As Object, e As EventArgs) Handles CMB2.LostFocus, CMB.LostFocus
        If sender.Tag Is Nothing Then Exit Sub
        Try
            Select Case sender.Tag.ToString
                Case "2"
                    校验位 = [Enum].Parse(GetType(IO.Ports.Parity), CMB.Text)
                Case "4"
                    停止位 = [Enum].Parse(GetType(IO.Ports.StopBits), CMB.Text)
                Case "1"
                    波特率 = CType(sender, ComboBox).Text
                Case "3"
                    数据位 = CType(sender, ComboBox).Text
            End Select
            UpdateDS()
            sender.tag = Nothing
        Catch
        End Try
        sender.Hide()
    End Sub
    Private Sub 关闭自身()
        DS标签1.SuspendLayout()
        For I As Integer = 63 To 0 Step -10
            Me.Height = I
            Threading.Thread.Sleep(30)
            Application.DoEvents()
        Next
        Me.Height = 0
        DS标签1.ResumeLayout()
        Me.Dispose()
    End Sub

    Private Sub CMB2_KeyDown(sender As Object, e As KeyEventArgs) Handles CMB2.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter, Keys.Return
                DS标签1.Focus()
        End Select
    End Sub
End Class