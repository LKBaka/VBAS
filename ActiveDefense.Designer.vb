<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveDefense
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
        Panel_Move = New Panel()
        Btn_MinWindow = New Label()
        Btn_Close = New Label()
        Tip_0 = New Label()
        SelPathScan_Btn = New Label()
        Label1 = New Label()
        VirusPath = New Label()
        VirusName = New Label()
        Panel_Move.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Move
        ' 
        Panel_Move.BackColor = Color.FromArgb(CByte(125), CByte(200), CByte(247))
        Panel_Move.Controls.Add(Btn_MinWindow)
        Panel_Move.Controls.Add(Btn_Close)
        Panel_Move.Location = New Point(1, 0)
        Panel_Move.Name = "Panel_Move"
        Panel_Move.Size = New Size(777, 40)
        Panel_Move.TabIndex = 1
        ' 
        ' Btn_MinWindow
        ' 
        Btn_MinWindow.AutoSize = True
        Btn_MinWindow.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_MinWindow.Location = New Point(700, 9)
        Btn_MinWindow.Name = "Btn_MinWindow"
        Btn_MinWindow.Size = New Size(22, 23)
        Btn_MinWindow.TabIndex = 1
        Btn_MinWindow.Text = "-"
        ' 
        ' Btn_Close
        ' 
        Btn_Close.AutoSize = True
        Btn_Close.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Close.Location = New Point(728, 9)
        Btn_Close.Name = "Btn_Close"
        Btn_Close.Size = New Size(34, 23)
        Btn_Close.TabIndex = 0
        Btn_Close.Text = "×"
        ' 
        ' Tip_0
        ' 
        Tip_0.AutoSize = True
        Tip_0.Font = New Font("黑体", 26F, FontStyle.Regular, GraphicsUnit.Point)
        Tip_0.ForeColor = Color.White
        Tip_0.Location = New Point(234, 95)
        Tip_0.Name = "Tip_0"
        Tip_0.Size = New Size(305, 44)
        Tip_0.TabIndex = 2
        Tip_0.Text = "成功拦截木马!"
        ' 
        ' SelPathScan_Btn
        ' 
        SelPathScan_Btn.BackColor = Color.Silver
        SelPathScan_Btn.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        SelPathScan_Btn.Location = New Point(234, 311)
        SelPathScan_Btn.Name = "SelPathScan_Btn"
        SelPathScan_Btn.Size = New Size(157, 55)
        SelPathScan_Btn.TabIndex = 4
        SelPathScan_Btn.Text = "删除病毒"
        SelPathScan_Btn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Silver
        Label1.Font = New Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(399, 311)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 55)
        Label1.TabIndex = 5
        Label1.Text = "我知道了"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VirusPath
        ' 
        VirusPath.AutoSize = True
        VirusPath.Font = New Font("黑体", 16F, FontStyle.Regular, GraphicsUnit.Point)
        VirusPath.ForeColor = Color.White
        VirusPath.Location = New Point(174, 168)
        VirusPath.Name = "VirusPath"
        VirusPath.Size = New Size(124, 27)
        VirusPath.TabIndex = 6
        VirusPath.Text = "病毒路径"
        ' 
        ' VirusName
        ' 
        VirusName.AutoSize = True
        VirusName.Font = New Font("黑体", 16F, FontStyle.Regular, GraphicsUnit.Point)
        VirusName.ForeColor = Color.White
        VirusName.Location = New Point(174, 208)
        VirusName.Name = "VirusName"
        VirusName.Size = New Size(124, 27)
        VirusName.TabIndex = 7
        VirusName.Text = "病毒名称"
        ' 
        ' ActiveDefense
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(780, 468)
        Controls.Add(VirusName)
        Controls.Add(VirusPath)
        Controls.Add(Label1)
        Controls.Add(SelPathScan_Btn)
        Controls.Add(Tip_0)
        Controls.Add(Panel_Move)
        FormBorderStyle = FormBorderStyle.None
        Name = "ActiveDefense"
        Panel_Move.ResumeLayout(False)
        Panel_Move.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel_Move As Panel
    Friend WithEvents Btn_MinWindow As Label
    Friend WithEvents Btn_Close As Label
    Friend WithEvents Tip_0 As Label
    Friend WithEvents SelPathScan_Btn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents VirusPath As Label
    Friend WithEvents VirusName As Label
End Class
