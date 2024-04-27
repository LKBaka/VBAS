Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports Microsoft.Win32
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports PeNet
Imports System.Reflection
Public Class MainForm
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function TerminateProcess(ByVal hProcess As IntPtr, ByVal uExitCode As UInt32) As Boolean
    End Function
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
    Public NoInternetScanMode As String = "Yara"
    Public md5s As New List(Of String)
    Public configs As New List(Of String) From {}
    Public VirusFuncs As New List(Of String) From {}
    Public ScanedFile As New List(Of String) From {}
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
            GoToPageAnimation(Panel_isGoTo, Tools)
            PageCtrl.SelectedIndex = index - 1
        ElseIf index = 5 Then
            GoToPageAnimation(Panel_isGoTo, Settings_Btn)
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
    Public Sub EndProcessByName(ByVal processName As String)
        Try
            Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名
            ' 获取当前运行的所有进程  
            Dim processes() As Process = Process.GetProcessesByName(processName)

            ' 遍历所有找到的进程  
            For Each process As Process In processes
                ' 确保我们有足够的权限来结束进程  
                If Not process.HasExited Then
                    Try
                        ' 尝试以管理员权限结束进程  
                        Dim success As Boolean = TerminateProcess(process.Handle, 0)
                        If success Then
                            MsgBox($"成功结束进程{process.ProcessName}",, "VBAS")
                        Else
                            MsgBox($"结束{process.ProcessName}进程失败",, "VBAS")
                        End If
                    Catch ex As Exception
                        ' 处理可能出现的异常，比如访问被拒绝等  
                        MsgBox("拒绝访问", , "VBAS")
                    End Try
                End If
            Next
            FreeLibrary(NSudoDevilModeModuleHandle)
        Catch ex As Exception
            ' 处理获取进程列表时可能出现的异常  
            MsgBox("An error occurred while trying to get process list: {0}", ex.Message)
        End Try
    End Sub
    Public Async Function Scan(ByVal directoryPath As String, NoInternet As Boolean) As Task
        ScanedFile = {""}.ToList
        PBar.Value = 0
        MainPage_Btn.Enabled = False
        ScanMainPage_Btn.Enabled = False
        Tools.Enabled = False
        Settings_Btn.Enabled = False
        Dim s As New Scan
        'If MainForm.State = 0 Then
        Try


            Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  
            ' 添加当前目录中的文件到列表中  
            If NSudoDevilModeModuleHandle <> IntPtr.Zero Then

                Try
                    For Each file In Directory.GetFiles(directoryPath)
                        Await Task.Run(Async Sub()

                                           Dim ScanFileCount As Integer = 0
                                           Me.Invoke(Sub() Me.Scan_Tip.Text = "正在扫描:" & file)
                                           If Not NoInternet Then
                                               Try
                                                   ' 创建HttpClient实例  
                                                   Using client As New HttpClient()
                                                       ' 设置请求的URL  
                                                       Dim url As String = "http://cdn2.fileinfo.kolostudio.fun/FileInfo?" + s.getMD5(file)

                                                       ' 发送GET请求  
                                                       Dim response As HttpResponseMessage = Await client.GetAsync(url)

                                                       ' 确保请求成功  
                                                       If response.IsSuccessStatusCode Then
                                                           ' 读取响应内容  
                                                           Dim content As String = Await response.Content.ReadAsStringAsync()
                                                           'Console.WriteLine(content)
                                                           ' Debug.Print(content)

                                                           ' 解析JSON字符串为JObject  
                                                           Dim jObject As JObject = JObject.Parse(content)

                                                           ' 从result对象中获取Safe_Level的值  
                                                           Dim resultObject As JObject = jObject("result")
                                                           Dim safeLevel As Integer = CInt(resultObject("Safe_Level"))
                                                           If CInt(safeLevel) <= 40 Then
                                                               Me.Invoke(
                                                                   Sub()
                                                                       Me.ListView1.Items.Add(file)
                                                                       Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                                                       ScanFileCount += 1

                                                                   End Sub)
                                                           End If
                                                       Else
                                                           Me.Invoke(
                                                                   Sub()
                                                                       Me.ListView1.Items.Add("错误码:" & response.StatusCode)
                                                                       'Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                                                   End Sub)

                                                       End If
                                                   End Using
                                               Catch ex As Exception

                                               End Try

                                           Else
                                               If NoInternetScanMode = "Yara" Then
                                                   Dim taskYara = YaraScanFunc(file)
                                                   ScanFileCount += 1
                                               ElseIf NoInternetScanMode = "MD5" Then
                                                   Dim taskMD5 = MD5ScanFunc(file)
                                                   ScanFileCount += 1
                                               Else
                                                   Dim taskPE = PEFuncScanFunc(file)
                                                   ScanFileCount += 1
                                               End If
                                           End If
                                           'Me.Invoke(Sub() PBar.Value = ScanFileCount / 100)

                                           Me.Invoke(Sub() If ScanFileCount < 100 Then PBar.Value = ScanFileCount Else PBar.Value = ScanFileCount / 2)


                                       End Sub)


                        If ListView1.Items.Count = 0 Then VirusCount.Text = "威胁数量:0"
                    Next
                Catch e As Exception
                    Debug.Print(e.Message)
                End Try

            Else
                MsgBox("扫描失败！")
                MainPage_Btn.Enabled = True
                ScanMainPage_Btn.Enabled = True
                Tools.Enabled = True
                Settings_Btn.Enabled = True
                PBar.Value = 100
            End If


            For Each subDir In Directory.GetDirectories(directoryPath)
                FreeLibrary(NSudoDevilModeModuleHandle)
                Await Scan(subDir, NoInternet)
            Next

        Catch e As Exception
            Debug.Print(e.Message)

        End Try
        'End If
        MainPage_Btn.Enabled = True
        ScanMainPage_Btn.Enabled = True
        Tools.Enabled = True
        Settings_Btn.Enabled = True
        PBar.Value = 100
    End Function


    Public Async Function YaraScanFunc(file As String) As Task
        Await Task.Run(Async Function()
                           Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  
                           Dim startInfo As New ProcessStartInfo(Chr(34) + Application.StartupPath + "\yara64.exe" + Chr(34))
                           With startInfo
                               .UseShellExecute = False
                               .RedirectStandardOutput = True ' 重定向标准输出以便可以读取它  
                               .CreateNoWindow = True ' 如果不需要新窗口，可以设置为True  
                           End With
                           Dim fileExtension As String = Path.GetExtension(file).TrimStart(".")
                           Dim rulePath As String = ""

                           Select Case fileExtension
                               Case "exe"
                                   rulePath = Chr(34) + Application.StartupPath + "\yara_rules\Rule" + Chr(34)
                               Case "bat" Or "cmd"
                                   rulePath = Chr(34) + Application.StartupPath + "\yara_rules\Bat_Rule" + Chr(34)
                               Case Else
                                   ' 处理其他文件类型的情况s


                           End Select

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
                           FreeLibrary(NSudoDevilModeModuleHandle)
                       End Function)
    End Function

    Public Async Function MD5ScanFunc(file As String) As Task
        Await Task.Run(Async Function()
                           Try
                               Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  

                               Dim s As New Scan
                               ' Debug.Print(md5s.Contains(s.getMD5(file)))
                               If md5s.Contains(s.getMD5(file)) Then
                                   Me.Invoke(Sub()
                                                 Me.ListView1.Items.Add(file)
                                                 Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                             End Sub)
                               End If



                               FreeLibrary(NSudoDevilModeModuleHandle)
                           Catch ex As Exception
                               MsgBox(ex.Message)

                           End Try

                       End Function)
    End Function
    Public Async Function PEFuncScanFunc(file As String) As Task
        Await Task.Run(Async Function()
                           Try
                               Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  

                               Dim fileExtension As String = Path.GetExtension(file)
                               'If fileExtension = ".exe" AndAlso fileExtension IsNot Nothing Then
                               Dim peFile = New PeFile(file)

                               For Each f In peFile.ImportedFunctions
                                   Debug.Print(VirusFuncs.Contains(f.Name))

                                   If VirusFuncs.Contains(f.Name) Then

                                       Me.Invoke(Sub()
                                                     If ScanedFile.Contains(file) Then
                                                         Exit Sub
                                                     End If

                                                     Me.ListView1.Items.Add(file)
                                                     Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                                     ScanedFile.Add(file)
                                                 End Sub)
                                   End If
                               Next
                               Debug.Print(file)
                               ' End If

                               FreeLibrary(NSudoDevilModeModuleHandle)
                           Catch ex As Exception

                           End Try

                       End Function)
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

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PageCtrl.ItemSize = New Size(1, 1)
        PageCtrl.SizeMode = TabSizeMode.Fixed
        PageCtrl.Appearance = TabAppearance.FlatButtons

        'Process.Start(Application.StartupPath & "\VBASTray.exe")

        Panel1.Margin = New Padding(0, 0, 0, 0)

        ListView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic).SetValue(ListView1, True, Nothing)

        Await Task.Run(Async Sub()
                           Try

                               Dim md5sDir = Directory.GetFiles(Application.StartupPath + "\md5s\")
                               For Each md5sFile In md5sDir
                                   Using sr As New StreamReader(md5sFile)
                                       While Not sr.EndOfStream
                                           Dim RL = Await sr.ReadLineAsync
                                           If RL IsNot Nothing Then
                                               md5s.Add(RL)
                                           End If
                                       End While
                                   End Using
                               Next

                               '读配置文件
                               Using config As New StreamReader(Application.StartupPath + "\config.ini", Encoding.UTF8)
                                   While Not config.EndOfStream
                                       Dim Line = Await config.ReadLineAsync
                                       If Line IsNot Nothing Then
                                           configs.Add(Line)
                                       End If
                                   End While
                               End Using

                               Using funcsFile As New StreamReader(Application.StartupPath + "\PEFuncs_V", Encoding.UTF8)
                                   Dim tmp = funcsFile.ReadToEnd
                                   VirusFuncs = tmp.Split(",").ToList

                               End Using

                           Catch ex As Exception

                           End Try
                       End Sub)
        NoInternetScanMode = configs(1)

        If NoInternetScanMode = "MD5" Then
            MD5Scan.Checked = True
        ElseIf NoInternetScanMode = "Yara" Then
            YaraScan.Checked = True
        Else
            PEScan.Checked = True
        End If
    End Sub

    Private Async Sub ScaningPage_Btn_Click(sender As Object, e As EventArgs) Handles ScaningPage_Btn.Click
        MsgBox("目前无法使用",, "VBAS")
        Return
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

    Private Sub Fix_Click(sender As Object, e As EventArgs) Handles Tools.Click
        GoToPage(4)
    End Sub

    Private Sub FixTaskMgr_Click(sender As Object, e As EventArgs) Handles FixTaskMgr.Click
        Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")

        If registryKey IsNot Nothing Then
            registryKey.SetValue("DisableTaskMgr", 0)
            registryKey.Close()

        End If
        ' 读取并验证注册表值  
        Using OK As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
            If OK IsNot Nothing Then
                Dim readValue As Object = OK.GetValue("DisableTaskMgr")
                If readValue IsNot Nothing AndAlso readValue.ToString() = 0 Then
                    MsgBox("修改成功！",, "VBAS")
                Else
                    MsgBox("注册表值修改失败或读取的值不匹配。",, "VBAS")
                End If
            Else
                MsgBox("无法打开注册表键。",, "VBAS")
            End If
            OK.Close()
        End Using
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

    Private Sub MD5Scan_CheckedChanged(sender As Object, e As EventArgs) Handles MD5Scan.CheckedChanged
        If MD5Scan.Checked Then
            NoInternetScanMode = "MD5"
            If configs(1) <> "MD5" Then
                configs(1) = "MD5"
                IO.File.WriteAllLines(Application.StartupPath + "\config.ini", configs)
            End If
        End If
    End Sub

    Private Sub Settings_Btn_Click(sender As Object, e As EventArgs) Handles Settings_Btn.Click
        GoToPage(5)
    End Sub

    Private Sub YaraScan_CheckedChanged(sender As Object, e As EventArgs) Handles YaraScan.CheckedChanged
        If YaraScan.Checked Then
            NoInternetScanMode = "Yara"
            If configs(1) <> "Yara" Then
                configs(1) = "Yara"
                IO.File.WriteAllLines(Application.StartupPath + "\config.ini", configs)
            End If
        End If
    End Sub



    Private Sub PEFuncScan_CheckedChanged(sender As Object, e As EventArgs) Handles PEScan.CheckedChanged
        If PEScan.Checked Then
            NoInternetScanMode = "PEFuncScan"
            If configs(1) <> "PEFuncScan" Then
                configs(1) = "PEFuncScan"
                IO.File.WriteAllLines(Application.StartupPath + "\config.ini", configs)
            End If
        End If
    End Sub

    Private Sub Panel_Move_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Move.Paint

    End Sub

    Private Sub UpdBtn_Click(sender As Object, e As EventArgs)
        Process.Start(Application.StartupPath + "VBASUpdate.exe")
    End Sub

    Private Sub EndProcess_Click(sender As Object, e As EventArgs) Handles EndProcess.Click
        Dim result = InputBox("输入你想结束的进程", "结束进程")

        If result <> "" Then EndProcessByName(result) Else MsgBox("输入为空",, "VBAS")

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

            ' Using serviceController As New ServiceController(serviceName)
            ' Return serviceController.Status = ServiceControllerStatus.Running
            ' End Using
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
Public Class Person
    Public Property Safe_Level As String
End Class