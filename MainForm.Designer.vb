﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel_Move = New Panel()
        Btn_MinWindow = New Label()
        Btn_Close = New Label()
        PageCtrl = New TabControl()
        MainPgae = New TabPage()
        MainPage_Scan = New TabPage()
        DotDotdotdot = New Label()
        ScaningPage_Btn = New Label()
        Tip_0 = New Label()
        ScaningPage = New TabPage()
        VirusCount = New Label()
        Del = New Label()
        Scan_Tip = New Label()
        ListView1 = New ListView()
        FileName = New ColumnHeader()
        type = New ColumnHeader()
        CtrlPanel = New Panel()
        ScanMainPage_Btn = New PictureBox()
        MainPage_Btn = New PictureBox()
        Panel_isGoTo = New Panel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Panel_Move.SuspendLayout()
        PageCtrl.SuspendLayout()
        MainPage_Scan.SuspendLayout()
        ScaningPage.SuspendLayout()
        CtrlPanel.SuspendLayout()
        CType(ScanMainPage_Btn, ComponentModel.ISupportInitialize).BeginInit()
        CType(MainPage_Btn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel_Move
        ' 
        Panel_Move.BackColor = Color.FromArgb(CByte(125), CByte(200), CByte(247))
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
        ' PageCtrl
        ' 
        PageCtrl.Controls.Add(MainPgae)
        PageCtrl.Controls.Add(MainPage_Scan)
        PageCtrl.Controls.Add(ScaningPage)
        PageCtrl.ItemSize = New Size(1, 25)
        PageCtrl.Location = New Point(135, 49)
        PageCtrl.Name = "PageCtrl"
        PageCtrl.SelectedIndex = 0
        PageCtrl.Size = New Size(940, 662)
        PageCtrl.TabIndex = 3
        ' 
        ' MainPgae
        ' 
        MainPgae.BackColor = Color.LightSkyBlue
        MainPgae.Location = New Point(4, 29)
        MainPgae.Name = "MainPgae"
        MainPgae.Padding = New Padding(3)
        MainPgae.Size = New Size(932, 629)
        MainPgae.TabIndex = 0
        MainPgae.Text = "主界面"
        ' 
        ' MainPage_Scan
        ' 
        MainPage_Scan.BackColor = Color.LightSkyBlue
        MainPage_Scan.Controls.Add(DotDotdotdot)
        MainPage_Scan.Controls.Add(ScaningPage_Btn)
        MainPage_Scan.Controls.Add(Tip_0)
        MainPage_Scan.Location = New Point(4, 29)
        MainPage_Scan.Name = "MainPage_Scan"
        MainPage_Scan.Padding = New Padding(3)
        MainPage_Scan.Size = New Size(932, 629)
        MainPage_Scan.TabIndex = 1
        MainPage_Scan.Text = "查杀_主界面"
        ' 
        ' DotDotdotdot
        ' 
        DotDotdotdot.AutoSize = True
        DotDotdotdot.Location = New Point(6, 610)
        DotDotdotdot.Name = "DotDotdotdot"
        DotDotdotdot.Size = New Size(364, 20)
        DotDotdotdot.TabIndex = 3
        DotDotdotdot.Text = "感谢MIAIONE大佬送出的VB.NET 360杀毒模块一枚~" & vbCrLf
        ' 
        ' ScaningPage_Btn
        ' 
        ScaningPage_Btn.BackColor = Color.Silver
        ScaningPage_Btn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ScaningPage_Btn.Location = New Point(144, 316)
        ScaningPage_Btn.Name = "ScaningPage_Btn"
        ScaningPage_Btn.Size = New Size(196, 67)
        ScaningPage_Btn.TabIndex = 2
        ScaningPage_Btn.Text = "自定义查杀"
        ScaningPage_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tip_0
        ' 
        Tip_0.AutoSize = True
        Tip_0.Font = New Font("黑体", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Tip_0.ForeColor = SystemColors.ButtonHighlight
        Tip_0.Location = New Point(121, 172)
        Tip_0.Name = "Tip_0"
        Tip_0.Size = New Size(535, 120)
        Tip_0.TabIndex = 1
        Tip_0.Text = "查杀木马病毒,拦截" & vbCrLf & "可疑行为"
        ' 
        ' ScaningPage
        ' 
        ScaningPage.BackColor = Color.LightSkyBlue
        ScaningPage.Controls.Add(VirusCount)
        ScaningPage.Controls.Add(Del)
        ScaningPage.Controls.Add(Scan_Tip)
        ScaningPage.Controls.Add(ListView1)
        ScaningPage.Location = New Point(4, 29)
        ScaningPage.Name = "ScaningPage"
        ScaningPage.Padding = New Padding(3)
        ScaningPage.Size = New Size(932, 629)
        ScaningPage.TabIndex = 2
        ScaningPage.Text = "查杀_扫描中"
        ' 
        ' VirusCount
        ' 
        VirusCount.AutoSize = True
        VirusCount.Font = New Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VirusCount.Location = New Point(6, 43)
        VirusCount.Name = "VirusCount"
        VirusCount.Size = New Size(99, 20)
        VirusCount.TabIndex = 4
        VirusCount.Text = "威胁数量:"
        ' 
        ' Del
        ' 
        Del.BackColor = Color.Silver
        Del.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Del.Location = New Point(832, 22)
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
        Scan_Tip.Location = New Point(6, 10)
        Scan_Tip.Name = "Scan_Tip"
        Scan_Tip.Size = New Size(99, 20)
        Scan_Tip.TabIndex = 0
        Scan_Tip.Text = "正在扫描:"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.LightSkyBlue
        ListView1.Columns.AddRange(New ColumnHeader() {FileName, type})
        ListView1.Location = New Point(6, 77)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(920, 550)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' FileName
        ' 
        FileName.Text = "文件名"
        FileName.Width = 400
        ' 
        ' type
        ' 
        type.Text = "病毒类型"
        type.Width = 400
        ' 
        ' CtrlPanel
        ' 
        CtrlPanel.Controls.Add(ScanMainPage_Btn)
        CtrlPanel.Controls.Add(MainPage_Btn)
        CtrlPanel.Controls.Add(Panel_isGoTo)
        CtrlPanel.Location = New Point(0, 43)
        CtrlPanel.Name = "CtrlPanel"
        CtrlPanel.Size = New Size(133, 674)
        CtrlPanel.TabIndex = 0
        ' 
        ' ScanMainPage_Btn
        ' 
        ScanMainPage_Btn.Image = My.Resources.Resources.ScanPage
        ScanMainPage_Btn.Location = New Point(23, 91)
        ScanMainPage_Btn.Name = "ScanMainPage_Btn"
        ScanMainPage_Btn.Size = New Size(106, 50)
        ScanMainPage_Btn.SizeMode = PictureBoxSizeMode.StretchImage
        ScanMainPage_Btn.TabIndex = 7
        ScanMainPage_Btn.TabStop = False
        ' 
        ' MainPage_Btn
        ' 
        MainPage_Btn.Image = My.Resources.Resources.MainPage_Btn
        MainPage_Btn.Location = New Point(23, 35)
        MainPage_Btn.Name = "MainPage_Btn"
        MainPage_Btn.Size = New Size(106, 50)
        MainPage_Btn.SizeMode = PictureBoxSizeMode.StretchImage
        MainPage_Btn.TabIndex = 6
        MainPage_Btn.TabStop = False
        ' 
        ' Panel_isGoTo
        ' 
        Panel_isGoTo.BackColor = Color.DodgerBlue
        Panel_isGoTo.Location = New Point(12, 35)
        Panel_isGoTo.Name = "Panel_isGoTo"
        Panel_isGoTo.Size = New Size(5, 50)
        Panel_isGoTo.TabIndex = 5
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(1079, 717)
        Controls.Add(CtrlPanel)
        Controls.Add(PageCtrl)
        Controls.Add(Panel_Move)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainForm"
        Text = "Visual Basic Antivirus Software"
        Panel_Move.ResumeLayout(False)
        Panel_Move.PerformLayout()
        PageCtrl.ResumeLayout(False)
        MainPage_Scan.ResumeLayout(False)
        MainPage_Scan.PerformLayout()
        ScaningPage.ResumeLayout(False)
        ScaningPage.PerformLayout()
        CtrlPanel.ResumeLayout(False)
        CType(ScanMainPage_Btn, ComponentModel.ISupportInitialize).EndInit()
        CType(MainPage_Btn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Move As Panel
    Friend WithEvents Btn_Close As Label
    Friend WithEvents Btn_MinWindow As Label
    Friend WithEvents PageCtrl As TabControl
    Friend WithEvents MainPgae As TabPage
    Friend WithEvents MainPage_Scan As TabPage
    Friend WithEvents Tip_0 As Label
    Friend WithEvents CtrlPanel As Panel
    Friend WithEvents ScanMainPage_Btn As PictureBox
    Friend WithEvents MainPage_Btn As PictureBox
    Friend WithEvents Panel_isGoTo As Panel
    Friend WithEvents ScaningPage As TabPage
    Friend WithEvents Scan_Tip As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FileName As ColumnHeader
    Friend WithEvents type As ColumnHeader
    Friend WithEvents ScaningPage_Btn As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents DotDotdotdot As Label
    Friend WithEvents Del As Label
    Friend WithEvents VirusCount As Label
End Class