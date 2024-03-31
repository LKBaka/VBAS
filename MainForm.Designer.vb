<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel_Move = New Panel()
        Btn_MinWindow = New Label()
        Btn_Close = New Label()
        CtrlPanel = New Panel()
        MainPage_Btn = New Label()
        ScanMainPage_Btn = New Label()
        Fix = New Label()
        Panel_isGoTo = New Panel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Panel1 = New Panel()
        PageCtrl = New TabControl()
        MainPgae = New TabPage()
        MainPage_Scan = New TabPage()
        ScanPanel = New Panel()
        NoInternetScan_Btn = New Label()
        SelPathScan_Btn = New Label()
        Show_ScanPanel = New Label()
        ScaningPage_Btn = New Label()
        Tip_0 = New Label()
        ScaningPage = New TabPage()
        VirusCount = New Label()
        Del = New Label()
        Scan_Tip = New Label()
        ListView1 = New ListView()
        FileName = New ColumnHeader()
        修复 = New TabPage()
        FixTaskMgr = New Label()
        Panel_Move.SuspendLayout()
        CtrlPanel.SuspendLayout()
        Panel1.SuspendLayout()
        PageCtrl.SuspendLayout()
        MainPage_Scan.SuspendLayout()
        ScanPanel.SuspendLayout()
        ScaningPage.SuspendLayout()
        修复.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Move
        ' 
        Panel_Move.BackColor = Color.DarkGray
        Panel_Move.Controls.Add(Btn_MinWindow)
        Panel_Move.Controls.Add(Btn_Close)
        Panel_Move.Location = New Point(0, -3)
        Panel_Move.Name = "Panel_Move"
        Panel_Move.Size = New Size(1086, 51)
        Panel_Move.TabIndex = 0
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
        CtrlPanel.Controls.Add(MainPage_Btn)
        CtrlPanel.Controls.Add(ScanMainPage_Btn)
        CtrlPanel.Controls.Add(Fix)
        CtrlPanel.Controls.Add(Panel_isGoTo)
        CtrlPanel.Location = New Point(0, 43)
        CtrlPanel.Name = "CtrlPanel"
        CtrlPanel.Size = New Size(133, 674)
        CtrlPanel.TabIndex = 0
        ' 
        ' MainPage_Btn
        ' 
        MainPage_Btn.BackColor = Color.Gainsboro
        MainPage_Btn.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        MainPage_Btn.Location = New Point(23, 35)
        MainPage_Btn.Name = "MainPage_Btn"
        MainPage_Btn.Size = New Size(106, 49)
        MainPage_Btn.TabIndex = 10
        MainPage_Btn.Text = "主页"
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
        ScanMainPage_Btn.Text = "查杀"
        ScanMainPage_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Fix
        ' 
        Fix.BackColor = Color.Gainsboro
        Fix.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        Fix.Location = New Point(23, 142)
        Fix.Name = "Fix"
        Fix.Size = New Size(106, 49)
        Fix.TabIndex = 8
        Fix.Text = "修复"
        Fix.TextAlign = ContentAlignment.MiddleCenter
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
        Panel1.Controls.Add(PageCtrl)
        Panel1.Location = New Point(135, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 674)
        Panel1.TabIndex = 4
        ' 
        ' PageCtrl
        ' 
        PageCtrl.Controls.Add(MainPgae)
        PageCtrl.Controls.Add(MainPage_Scan)
        PageCtrl.Controls.Add(ScaningPage)
        PageCtrl.Controls.Add(修复)
        PageCtrl.ItemSize = New Size(1, 25)
        PageCtrl.Location = New Point(-10, -8)
        PageCtrl.Name = "PageCtrl"
        PageCtrl.SelectedIndex = 0
        PageCtrl.Size = New Size(961, 687)
        PageCtrl.TabIndex = 4
        ' 
        ' MainPgae
        ' 
        MainPgae.BackColor = Color.Silver
        MainPgae.Location = New Point(4, 29)
        MainPgae.Name = "MainPgae"
        MainPgae.Padding = New Padding(3)
        MainPgae.Size = New Size(953, 654)
        MainPgae.TabIndex = 0
        MainPgae.Text = "主界面"
        ' 
        ' MainPage_Scan
        ' 
        MainPage_Scan.BackColor = Color.Silver
        MainPage_Scan.Controls.Add(ScanPanel)
        MainPage_Scan.Controls.Add(Show_ScanPanel)
        MainPage_Scan.Controls.Add(ScaningPage_Btn)
        MainPage_Scan.Controls.Add(Tip_0)
        MainPage_Scan.Location = New Point(4, 29)
        MainPage_Scan.Name = "MainPage_Scan"
        MainPage_Scan.Padding = New Padding(3)
        MainPage_Scan.Size = New Size(953, 654)
        MainPage_Scan.TabIndex = 1
        MainPage_Scan.Text = "查杀_主界面"
        ' 
        ' ScanPanel
        ' 
        ScanPanel.Controls.Add(NoInternetScan_Btn)
        ScanPanel.Controls.Add(SelPathScan_Btn)
        ScanPanel.Location = New Point(144, 386)
        ScanPanel.Name = "ScanPanel"
        ScanPanel.Size = New Size(196, 169)
        ScanPanel.TabIndex = 4
        ScanPanel.Visible = False
        ' 
        ' NoInternetScan_Btn
        ' 
        NoInternetScan_Btn.BackColor = Color.Gainsboro
        NoInternetScan_Btn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        NoInternetScan_Btn.Location = New Point(0, 67)
        NoInternetScan_Btn.Name = "NoInternetScan_Btn"
        NoInternetScan_Btn.Size = New Size(199, 63)
        NoInternetScan_Btn.TabIndex = 4
        NoInternetScan_Btn.Text = "离线查杀"
        NoInternetScan_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SelPathScan_Btn
        ' 
        SelPathScan_Btn.BackColor = Color.Gainsboro
        SelPathScan_Btn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        SelPathScan_Btn.Location = New Point(-3, 0)
        SelPathScan_Btn.Name = "SelPathScan_Btn"
        SelPathScan_Btn.Size = New Size(199, 63)
        SelPathScan_Btn.TabIndex = 3
        SelPathScan_Btn.Text = "自定义查杀"
        SelPathScan_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Show_ScanPanel
        ' 
        Show_ScanPanel.BackColor = Color.Gainsboro
        Show_ScanPanel.Font = New Font("黑体", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Show_ScanPanel.Location = New Point(343, 316)
        Show_ScanPanel.Name = "Show_ScanPanel"
        Show_ScanPanel.Size = New Size(43, 67)
        Show_ScanPanel.TabIndex = 3
        Show_ScanPanel.Text = "⬇️"
        Show_ScanPanel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ScaningPage_Btn
        ' 
        ScaningPage_Btn.BackColor = Color.Gainsboro
        ScaningPage_Btn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ScaningPage_Btn.Location = New Point(144, 316)
        ScaningPage_Btn.Name = "ScaningPage_Btn"
        ScaningPage_Btn.Size = New Size(196, 67)
        ScaningPage_Btn.TabIndex = 2
        ScaningPage_Btn.Text = "全盘查杀"
        ScaningPage_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tip_0
        ' 
        Tip_0.AutoSize = True
        Tip_0.Font = New Font("黑体", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Tip_0.ForeColor = Color.WhiteSmoke
        Tip_0.Location = New Point(124, 175)
        Tip_0.Name = "Tip_0"
        Tip_0.Size = New Size(535, 120)
        Tip_0.TabIndex = 1
        Tip_0.Text = "查杀木马病毒,拦截" & vbCrLf & "可疑行为"
        ' 
        ' ScaningPage
        ' 
        ScaningPage.BackColor = Color.Silver
        ScaningPage.Controls.Add(VirusCount)
        ScaningPage.Controls.Add(Del)
        ScaningPage.Controls.Add(Scan_Tip)
        ScaningPage.Controls.Add(ListView1)
        ScaningPage.Location = New Point(4, 29)
        ScaningPage.Name = "ScaningPage"
        ScaningPage.Padding = New Padding(3)
        ScaningPage.Size = New Size(953, 654)
        ScaningPage.TabIndex = 2
        ScaningPage.Text = "查杀_扫描中"
        ' 
        ' VirusCount
        ' 
        VirusCount.AutoSize = True
        VirusCount.Font = New Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VirusCount.Location = New Point(9, 46)
        VirusCount.Name = "VirusCount"
        VirusCount.Size = New Size(99, 20)
        VirusCount.TabIndex = 4
        VirusCount.Text = "威胁数量:"
        ' 
        ' Del
        ' 
        Del.BackColor = Color.Gainsboro
        Del.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Del.Location = New Point(840, 22)
        Del.Name = "Del"
        Del.Size = New Size(94, 41)
        Del.TabIndex = 3
        Del.Text = "删除"
        Del.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Scan_Tip
        ' 
        Scan_Tip.AutoSize = True
        Scan_Tip.Font = New Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Scan_Tip.Location = New Point(9, 13)
        Scan_Tip.Name = "Scan_Tip"
        Scan_Tip.Size = New Size(99, 20)
        Scan_Tip.TabIndex = 0
        Scan_Tip.Text = "正在扫描:"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.Silver
        ListView1.Columns.AddRange(New ColumnHeader() {FileName})
        ListView1.Location = New Point(6, 77)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(941, 577)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' FileName
        ' 
        FileName.Text = "文件名"
        FileName.Width = 8000
        ' 
        ' 修复
        ' 
        修复.BackColor = Color.Silver
        修复.Controls.Add(FixTaskMgr)
        修复.Location = New Point(4, 29)
        修复.Name = "修复"
        修复.Padding = New Padding(3)
        修复.Size = New Size(953, 654)
        修复.TabIndex = 3
        修复.Text = "修复"
        ' 
        ' FixTaskMgr
        ' 
        FixTaskMgr.BackColor = Color.Gainsboro
        FixTaskMgr.Font = New Font("黑体", 13.5F, FontStyle.Regular, GraphicsUnit.Point)
        FixTaskMgr.Location = New Point(27, 39)
        FixTaskMgr.Name = "FixTaskMgr"
        FixTaskMgr.Size = New Size(196, 49)
        FixTaskMgr.TabIndex = 9
        FixTaskMgr.Text = "修复任务管理器"
        FixTaskMgr.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1079, 717)
        Controls.Add(Panel1)
        Controls.Add(CtrlPanel)
        Controls.Add(Panel_Move)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainForm"
        Text = "Visual Basic Antivirus Software"
        Panel_Move.ResumeLayout(False)
        Panel_Move.PerformLayout()
        CtrlPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        PageCtrl.ResumeLayout(False)
        MainPage_Scan.ResumeLayout(False)
        MainPage_Scan.PerformLayout()
        ScanPanel.ResumeLayout(False)
        ScaningPage.ResumeLayout(False)
        ScaningPage.PerformLayout()
        修复.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Move As Panel
    Friend WithEvents Btn_Close As Label
    Friend WithEvents Btn_MinWindow As Label
    Friend WithEvents CtrlPanel As Panel
    Friend WithEvents Panel_isGoTo As Panel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PageCtrl As TabControl
    Friend WithEvents MainPgae As TabPage
    Friend WithEvents MainPage_Scan As TabPage
    Friend WithEvents ScaningPage_Btn As Label
    Friend WithEvents Tip_0 As Label
    Friend WithEvents ScaningPage As TabPage
    Friend WithEvents VirusCount As Label
    Friend WithEvents Del As Label
    Friend WithEvents Scan_Tip As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FileName As ColumnHeader
    Friend WithEvents Show_ScanPanel As Label
    Friend WithEvents ScanPanel As Panel
    Friend WithEvents SelPathScan_Btn As Label
    Friend WithEvents Fix As Label
    Friend WithEvents 修复 As TabPage
    Friend WithEvents FixTaskMgr As Label
    Friend WithEvents NoInternetScan_Btn As Label
    Friend WithEvents ScanMainPage_Btn As Label
    Friend WithEvents MainPage_Btn As Label
End Class
