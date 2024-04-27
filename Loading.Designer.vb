<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        components = New ComponentModel.Container()
        Panel_Move = New Panel()
        Btn_MinWindow = New Label()
        Btn_Close = New Label()
        CtrlPanel = New Panel()
        Settings_Btn = New Label()
        MainPage_Btn = New Label()
        ScanMainPage_Btn = New Label()
        Tools = New Label()
        Panel_isGoTo = New Panel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Panel1 = New Panel()
        Title = New Label()
        LoadingText = New Label()
        Timer1 = New Timer(components)
        Panel_Move.SuspendLayout()
        CtrlPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Move
        ' 
        Panel_Move.BackColor = Color.DarkGray
        Panel_Move.Controls.Add(Btn_MinWindow)
        Panel_Move.Controls.Add(Btn_Close)
        Panel_Move.Location = New Point(-143, -135)
        Panel_Move.Name = "Panel_Move"
        Panel_Move.Size = New Size(1086, 51)
        Panel_Move.TabIndex = 5
        ' 
        ' Btn_MinWindow
        ' 
        Btn_MinWindow.AutoSize = True
        Btn_MinWindow.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_MinWindow.Location = New Point(1010, 12)
        Btn_MinWindow.Name = "Btn_MinWindow"
        Btn_MinWindow.Size = New Size(22, 23)
        Btn_MinWindow.TabIndex = 1
        Btn_MinWindow.Text = "-"
        ' 
        ' Btn_Close
        ' 
        Btn_Close.AutoSize = True
        Btn_Close.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Close.Location = New Point(1038, 12)
        Btn_Close.Name = "Btn_Close"
        Btn_Close.Size = New Size(34, 23)
        Btn_Close.TabIndex = 0
        Btn_Close.Text = "×"
        ' 
        ' CtrlPanel
        ' 
        CtrlPanel.BackColor = Color.Silver
        CtrlPanel.Controls.Add(Settings_Btn)
        CtrlPanel.Controls.Add(MainPage_Btn)
        CtrlPanel.Controls.Add(ScanMainPage_Btn)
        CtrlPanel.Controls.Add(Tools)
        CtrlPanel.Controls.Add(Panel_isGoTo)
        CtrlPanel.Location = New Point(-143, -89)
        CtrlPanel.Name = "CtrlPanel"
        CtrlPanel.Size = New Size(133, 674)
        CtrlPanel.TabIndex = 6
        ' 
        ' Settings_Btn
        ' 
        Settings_Btn.BackColor = Color.Gainsboro
        Settings_Btn.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        Settings_Btn.Location = New Point(24, 196)
        Settings_Btn.Name = "Settings_Btn"
        Settings_Btn.Size = New Size(106, 49)
        Settings_Btn.TabIndex = 11
        Settings_Btn.Text = "⚙设置"
        Settings_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainPage_Btn
        ' 
        MainPage_Btn.BackColor = Color.Gainsboro
        MainPage_Btn.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        MainPage_Btn.Location = New Point(23, 35)
        MainPage_Btn.Name = "MainPage_Btn"
        MainPage_Btn.Size = New Size(106, 49)
        MainPage_Btn.TabIndex = 10
        MainPage_Btn.Text = "🏠主页"
        MainPage_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ScanMainPage_Btn
        ' 
        ScanMainPage_Btn.BackColor = Color.Gainsboro
        ScanMainPage_Btn.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        ScanMainPage_Btn.Location = New Point(23, 88)
        ScanMainPage_Btn.Name = "ScanMainPage_Btn"
        ScanMainPage_Btn.Size = New Size(106, 49)
        ScanMainPage_Btn.TabIndex = 9
        ScanMainPage_Btn.Text = "🔍查杀"
        ScanMainPage_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tools
        ' 
        Tools.BackColor = Color.Gainsboro
        Tools.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        Tools.Location = New Point(23, 142)
        Tools.Name = "Tools"
        Tools.Size = New Size(106, 49)
        Tools.TabIndex = 8
        Tools.Text = "🛠️工具"
        Tools.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel_isGoTo
        ' 
        Panel_isGoTo.BackColor = Color.DodgerBlue
        Panel_isGoTo.Location = New Point(12, 35)
        Panel_isGoTo.Name = "Panel_isGoTo"
        Panel_isGoTo.Size = New Size(5, 50)
        Panel_isGoTo.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(Title)
        Panel1.Location = New Point(2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(835, 51)
        Panel1.TabIndex = 7
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Title.Location = New Point(10, 12)
        Title.Name = "Title"
        Title.Size = New Size(58, 23)
        Title.TabIndex = 0
        Title.Text = "VBAS"
        ' 
        ' LoadingText
        ' 
        LoadingText.AutoSize = True
        LoadingText.Font = New Font("黑体", 42F, FontStyle.Regular, GraphicsUnit.Point)
        LoadingText.Location = New Point(230, 233)
        LoadingText.Name = "LoadingText"
        LoadingText.Size = New Size(380, 70)
        LoadingText.TabIndex = 8
        LoadingText.Text = "Loading..."
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Loading
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(840, 569)
        Controls.Add(LoadingText)
        Controls.Add(Panel1)
        Controls.Add(Panel_Move)
        Controls.Add(CtrlPanel)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Loading"
        Text = "Loading"
        Panel_Move.ResumeLayout(False)
        Panel_Move.PerformLayout()
        CtrlPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel_Move As Panel
    Friend WithEvents Btn_MinWindow As Label
    Friend WithEvents Btn_Close As Label
    Friend WithEvents CtrlPanel As Panel
    Friend WithEvents Settings_Btn As Label
    Friend WithEvents MainPage_Btn As Label
    Friend WithEvents ScanMainPage_Btn As Label
    Friend WithEvents Tools As Label
    Friend WithEvents Panel_isGoTo As Panel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents LoadingText As Label
    Friend WithEvents Timer1 As Timer
End Class
