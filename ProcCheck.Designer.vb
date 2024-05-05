<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcCheck))
        Panel_Move = New Panel()
        Btn_MinWindow = New Label()
        Btn_Close = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ProcNameText = New Label()
        Label1 = New Label()
        KillProcBtn = New Label()
        DelFileBtn = New Label()
        NotifyIcon1 = New NotifyIcon(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        退出程序ToolStripMenuItem = New ToolStripMenuItem()
        主界面ToolStripMenuItem = New ToolStripMenuItem()
        AddToWhiteList = New Label()
        Panel_Move.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Move
        ' 
        Panel_Move.BackColor = Color.DarkGray
        Panel_Move.Controls.Add(Btn_MinWindow)
        Panel_Move.Controls.Add(Btn_Close)
        Panel_Move.Location = New Point(0, 0)
        Panel_Move.Name = "Panel_Move"
        Panel_Move.Size = New Size(824, 51)
        Panel_Move.TabIndex = 5
        ' 
        ' Btn_MinWindow
        ' 
        Btn_MinWindow.AutoSize = True
        Btn_MinWindow.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_MinWindow.Location = New Point(743, 14)
        Btn_MinWindow.Name = "Btn_MinWindow"
        Btn_MinWindow.Size = New Size(22, 23)
        Btn_MinWindow.TabIndex = 1
        Btn_MinWindow.Text = "-"
        ' 
        ' Btn_Close
        ' 
        Btn_Close.AutoSize = True
        Btn_Close.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Close.Location = New Point(771, 14)
        Btn_Close.Name = "Btn_Close"
        Btn_Close.Size = New Size(34, 23)
        Btn_Close.TabIndex = 0
        Btn_Close.Text = "×"
        ' 
        ' ProcNameText
        ' 
        ProcNameText.AutoSize = True
        ProcNameText.Font = New Font("黑体", 25F, FontStyle.Regular, GraphicsUnit.Point)
        ProcNameText.Location = New Point(138, 195)
        ProcNameText.Name = "ProcNameText"
        ProcNameText.Size = New Size(417, 42)
        ProcNameText.TabIndex = 9
        ProcNameText.Text = "可疑进程:IA杀毒.exe"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("黑体", 25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(171, 260)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 42)
        Label1.TabIndex = 10
        ' 
        ' KillProcBtn
        ' 
        KillProcBtn.BackColor = Color.Gainsboro
        KillProcBtn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        KillProcBtn.Location = New Point(138, 325)
        KillProcBtn.Name = "KillProcBtn"
        KillProcBtn.Size = New Size(196, 67)
        KillProcBtn.TabIndex = 11
        KillProcBtn.Text = "结束进程"
        KillProcBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DelFileBtn
        ' 
        DelFileBtn.BackColor = Color.Gainsboro
        DelFileBtn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        DelFileBtn.Location = New Point(340, 325)
        DelFileBtn.Name = "DelFileBtn"
        DelFileBtn.Size = New Size(196, 67)
        DelFileBtn.TabIndex = 12
        DelFileBtn.Text = "删除病毒"
        DelFileBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.ContextMenuStrip = ContextMenuStrip1
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "VBAS"
        NotifyIcon1.Visible = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {退出程序ToolStripMenuItem, 主界面ToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(139, 52)
        ' 
        ' 退出程序ToolStripMenuItem
        ' 
        退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem"
        退出程序ToolStripMenuItem.Size = New Size(138, 24)
        退出程序ToolStripMenuItem.Text = "退出程序"
        ' 
        ' 主界面ToolStripMenuItem
        ' 
        主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem"
        主界面ToolStripMenuItem.Size = New Size(138, 24)
        主界面ToolStripMenuItem.Text = "主界面"
        ' 
        ' AddToWhiteList
        ' 
        AddToWhiteList.BackColor = Color.Gainsboro
        AddToWhiteList.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        AddToWhiteList.Location = New Point(542, 325)
        AddToWhiteList.Name = "AddToWhiteList"
        AddToWhiteList.Size = New Size(196, 67)
        AddToWhiteList.TabIndex = 13
        AddToWhiteList.Text = "信任程序"
        AddToWhiteList.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProcCheck
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(821, 560)
        Controls.Add(AddToWhiteList)
        Controls.Add(DelFileBtn)
        Controls.Add(KillProcBtn)
        Controls.Add(Label1)
        Controls.Add(ProcNameText)
        Controls.Add(Panel_Move)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ProcCheck"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProcCheck"
        Panel_Move.ResumeLayout(False)
        Panel_Move.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel_Move As Panel
    Friend WithEvents Btn_MinWindow As Label
    Friend WithEvents Btn_Close As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ProcNameText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KillProcBtn As Label
    Friend WithEvents DelFileBtn As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 退出程序ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 主界面ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToWhiteList As Label
End Class
