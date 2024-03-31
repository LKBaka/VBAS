Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.ServiceProcess
Imports Qihoo.CloudEngine
Imports Microsoft.Win32

Public Class MainForm

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode)>
    Shared Function LoadLibrary(lpLibFileName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Shared Function FreeLibrary(hLibModule As IntPtr) As Boolean
    End Function
    Declare Function ReleaseCapture Lib "user32" () As Long
    Declare Function SendMessage Lib "user32" _
    Alias "SendMessageA" (
    ByVal hwnd As Long, ByVal wMsg As Long,
    ByVal wParam As Long, lParam As Int32) As Long
    Public Const HTCAPTION = 2
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public NSudoPath = Application.StartupPath + "NSudoDM.dll"
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Public IsShow_ScanPanel
    'Public State As Int16 = 0

    Private Sub Panel_Move_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Move.MouseDown
        ReleaseCapture
        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        For i = 0 To 20
            Width -= 20
            Height -= 20
            Left += 10
            Top += 10
            Opacity -= 0.22
        Next
        Application.Exit()
    End Sub

    Private Sub Btn_MinWindow_Click(sender As Object, e As EventArgs) Handles Btn_MinWindow.Click
        MinWindow()
    End Sub
    Public Sub MinWindow()

        WindowState = FormWindowState.Minimized
    End Sub
    Public Sub GoToPage(index As Int32)
        If index = 1 Then
            GoToPageAnimation(Panel_isGoTo, MainPage_Btn)
            PageCtrl.SelectedIndex = index - 1
        ElseIf index = 2 Then
            GoToPageAnimation(Panel_isGoTo, ScanMainPage_Btn)
            PageCtrl.SelectedIndex = index - 1
        ElseIf index = 3 Then
            PageCtrl.SelectedIndex = index - 1
        ElseIf index = 4 Then
            GoToPageAnimation(Panel_isGoTo, Fix)
            PageCtrl.SelectedIndex = index - 1
        End If
    End Sub
    Public Sub GoToPageAnimation(Obj As Object, obj2 As Object)
        While Not (Obj.top = obj2.top)
            If Obj.top >= obj2.top Then
                Obj.top -= 1
            Else
                Obj.top += 1
            End If
        End While
    End Sub
    Private Sub MainPage_Btn_Click(sender As Object, e As EventArgs) Handles MainPage_Btn.Click
        GoToPage(1)
    End Sub

    Private Sub ScanPage_Btn_Click(sender As Object, e As EventArgs) Handles ScanMainPage_Btn.Click
        GoToPage(2)
    End Sub

    Private Sub __ScaningPage_Btn_Click(sender As Object, e As EventArgs)

    End Sub
    Public Async Function Scan(ByVal directoryPath As String, NoInternet As Boolean) As Task
        Dim s As New Scan
        'If MainForm.State = 0 Then
        Try


            Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  
            ' 添加当前目录中的文件到列表中  
            If NSudoDevilModeModuleHandle <> IntPtr.Zero Then

                Try
                    For Each file In Directory.GetFiles(directoryPath)
                        Await Task.Run(Sub()
                                           Me.Invoke(Sub() Me.Scan_Tip.Text = "正在扫描:" & file)
                                           If Not NoInternet Then
                                               Dim result As FileHealthResult = FileHealth.CheckAsync(s.getMD5(file)).Result
                                               If result IsNot Nothing AndAlso result.IsOperationSuccess Then
                                                   If CInt(result.Level) > 50 Then
                                                       Try
                                                           Me.Invoke(Sub()
                                                                         Me.ListView1.Items.Add(file)
                                                                         Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                                                     End Sub)

                                                       Catch ex As Exception

                                                       End Try
                                                   End If
                                               End If

                                           Else
                                               Dim startInfo As New ProcessStartInfo("yara64.exe")
                                               With startInfo
                                                   .UseShellExecute = False
                                                   .RedirectStandardOutput = True ' 重定向标准输出以便可以读取它  
                                                   .CreateNoWindow = True ' 如果不需要新窗口，可以设置为True  
                                               End With
                                               If Path.GetExtension(file).TrimStart(".") = "exe" Then
                                                   startInfo.Arguments = """" + Application.StartupPath + "\yara_rules\Rule" + """" + " " & file
                                               ElseIf Path.GetExtension(file).TrimStart(".") = "bat" Or Path.GetExtension(file).TrimStart(".") = "cmd" Then
                                                   startInfo.Arguments = """" + Application.StartupPath + "\yara_rules\Bat_Rule" + """" + " " & file
                                               End If
                                               ' 替换为你的控制台程序路径  
                                               ' 创建并启动Process对象  
                                               Dim process As New Process()
                                               process.StartInfo = startInfo
                                               process.Start()

                                               ' 读取进程的标准输出  
                                               Using reader As StreamReader = process.StandardOutput
                                                   Dim output As String = reader.ReadToEnd()
                                                   If output <> "" Then
                                                       Try
                                                           Me.Invoke(
                                                           Sub()
                                                               Me.ListView1.Items.Add(file)
                                                               Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                                           End Sub)
                                                       Catch ex As Exception
                                                       End Try
                                                   End If
                                               End Using

                                               ' 等待进程结束  
                                               process.WaitForExit()
                                           End If
                                       End Sub)


                        If ListView1.Items.Count = 0 Then VirusCount.Text = "威胁数量:0"
                    Next
                Catch e As Exception
                    Debug.Print(e.Message)
                End Try

            Else
                MsgBox("扫描失败！")
            End If

            FreeLibrary(NSudoDevilModeModuleHandle)
            For Each subDir In Directory.GetDirectories(directoryPath)
                Await Scan(subDir, NoInternet)
            Next

        Catch e As Exception
            Debug.Print(e.Message)
        End Try
        'End If
    End Function




    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        Dim NSudoPath = Application.StartupPath + "NSudoDM.dll"

        Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  
        Try
            For iI = ListView1.Items.Count - 1 To 0 Step -1
                IO.File.Delete(ListView1.Items(iI).Text)
                ListView1.Items.RemoveAt(iI)
            Next

            ' 更新威胁数量  
            Me.VirusCount.Text = "威胁数量:" & ListView1.Items.Count
        Catch ex As Exception
            MsgBox("失败！",, "删除病毒失败！")
        End Try
        MsgBox("完成！",, "删除病毒成功！")

        FreeLibrary(NSudoDevilModeModuleHandle)

    End Sub

    Private Sub MainPgae_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PageCtrl.ItemSize = New Size(1, 1)
        PageCtrl.SizeMode = TabSizeMode.Fixed
        PageCtrl.Appearance = TabAppearance.FlatButtons

        Process.Start(Application.StartupPath & "\VBASTray.exe")

        Panel1.Margin = New Padding(0, 0, 0, 0)

    End Sub

    Private Async Sub ScaningPage_Btn_Click(sender As Object, e As EventArgs) Handles ScaningPage_Btn.Click

        GoToPage(3)
        Await Scan("C:\", False)


    End Sub



    Private Sub MainPage_Scan_Click(sender As Object, e As EventArgs) Handles MainPage_Scan.Click

    End Sub



    Private Async Sub SelPathScan_Btn_Click(sender As Object, e As EventArgs) Handles SelPathScan_Btn.Click




        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            '  State = 0
            GoToPage(3)
            '  Dim s As New Scan

            Await Scan(FolderBrowserDialog1.SelectedPath, False)

        End If
    End Sub


    Private Sub Show_ScanPanel_Click_2(sender As Object, e As EventArgs) Handles Show_ScanPanel.Click
        If ScanPanel.Visible Then
            ScanPanel.Visible = False
            Show_ScanPanel.Text = "⬇"
        Else
            ScanPanel.Visible = True
            Show_ScanPanel.Text = "⬆️"
        End If
    End Sub

    Private Sub Fix_Click(sender As Object, e As EventArgs) Handles Fix.Click
        GoToPage(4)
    End Sub

    Private Sub FixTaskMgr_Click(sender As Object, e As EventArgs) Handles FixTaskMgr.Click
        Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        If registryKey IsNot Nothing Then
            registryKey.SetValue("DisableTaskMgr", 0)
            registryKey.Close()

        End If
    End Sub

    Private Async Sub NoInternetScan_Btn_Click(sender As Object, e As EventArgs) Handles NoInternetScan_Btn.Click



        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            '  State = 0
            GoToPage(3)
            '  Dim s As New Scan

            Await Scan(FolderBrowserDialog1.SelectedPath, True)

        End If
    End Sub

    Private Sub PageCtrl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PageCtrl.SelectedIndexChanged
        If PageCtrl.SelectedIndex = 2 Then
            ListView1.Items.Clear()
            VirusCount.Text = "威胁数量:0"
            Scan_Tip.Text = "正在扫描"
        End If
    End Sub
End Class

Public Class Scan
    '已废弃
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode)>
    Shared Function LoadLibrary(lpLibFileName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Shared Function FreeLibrary(hLibModule As IntPtr) As Boolean
    End Function


    Function IsServiceRunning(serviceName As String) As Boolean
        Try

            Using serviceController As New ServiceController(serviceName)
                Return serviceController.Status = ServiceControllerStatus.Running
            End Using
        Catch ex As Exception When (TypeOf ex Is InvalidOperationException)
            ' 服务可能不存在，忽略异常并返回False  
            Console.WriteLine("The service does not exist or is not accessible.")
            Return False
        Catch ex As Exception
            ' 处理其他异常  
            Console.WriteLine("An error occurred while checking the service status: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function getMD5(ByVal strSource As String) As String
        Dim r As String = ""
        ' If MainForm.State = 0 Then
        Try

            Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
            Dim dataToHash(fstream.Length - 1) As Byte
            fstream.Read(dataToHash, 0, fstream.Length)
            fstream.Close()
            Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(dataToHash)
            Dim i As Integer
            For i = 0 To hashvalue.Length - 1
                r += Microsoft.VisualBasic.Right("00" + Hex(hashvalue(i)).ToLower, 2)
            Next
            Return r
        Catch ex As Exception

            Return r
        End Try
        ' End If
    End Function







End Class