Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports PeNet


Public Class ProcCheck
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode)>
    Shared Function LoadLibrary(lpLibFileName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Shared Function FreeLibrary(hLibModule As IntPtr) As Boolean
    End Function
    Public VirusFuncs
    Public Kill, Del
    Public WhiteListApp
    Public WhiteList As New List(Of String) From {}
    Private Async Sub ProcCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Visible = False
        Await Task.Run(Async Sub()
                           Invoke(Sub() Hide())
                           Dim existingProcesses As New HashSet(Of Integer)

                           ' 获取当前所有进程的ID并添加到集合中
                           For Each proc As Process In Process.GetProcesses()
                               existingProcesses.Add(proc.Id)
                           Next
                           Using funcsFile As New StreamReader(Application.StartupPath + "\PEFuncs_V", Encoding.UTF8)
                               Dim tmp = funcsFile.ReadToEnd
                               VirusFuncs = tmp.Split(",").ToList

                           End Using
                           '读配置文件
                           Using WhiteListFile As New StreamReader(Application.StartupPath + "\WhiteList", Encoding.UTF8)
                               While Not WhiteListFile.EndOfStream
                                   Dim Line = Await WhiteListFile.ReadLineAsync
                                   If Line IsNot Nothing Then
                                       WhiteList.Add(Line)
                                   End If
                               End While
                           End Using

                           ' 无限循环，检测新进程
                           While True
                               Thread.Sleep(1)

                               ' 再次获取所有进程
                               For Each proc As Process In Process.GetProcesses()
                                   Try
                                       ' 如果进程ID不在集合中，则它是新启动的进程
                                       If existingProcesses.Contains(proc.Id) Then
                                           Continue For
                                       End If
                                       existingProcesses.Add(proc.Id)
                                       Dim name As String = proc.ProcessName
                                       Dim file As String = proc.MainModule.FileName
                                       Dim pid As Integer = proc.Id


                                       Dim virus = Await PEFuncScanFunc(file)
                                       If virus Then

                                           Invoke(Sub()
                                                      ProcNameText.Text = $"可疑进程:{name}"
                                                      TopMost = True
                                                      Visible = True
                                                      Kill = name
                                                      Del = file
                                                      WhiteListApp = file

                                                  End Sub)

                                       End If
                                   Catch ex As Exception
                                       ' 忽略任何异常，继续检查下一个进程
                                       Debug.Print(ex.Message)
                                   End Try
                               Next
                           End While

                       End Sub)
    End Sub


    Public Async Function PEFuncScanFunc(file As String) As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  'Debug.Print($"sw:{file.StartsWith("C:\Windows\")}")

                                  Try
                                      Dim windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
                                      If file.StartsWith(windowsPath) Then Return False
                                      If WhiteList.Contains(file) Then Return False

                                      Dim nsudopath = Application.StartupPath + "\NSudoDM.dll"
                                      Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(nsudopath) ' DLL文件名  

                                      Dim peFile = New PeFile(file)
                                      Dim score = 0

                                      ' Dim VirusFuncs = MainForm.VirusFuncs
                                      For Each f In peFile.ImportedFunctions
                                          'Debug.Print($"{f.Name}-{file}")

                                          If VirusFuncs.Contains(f.Name) Then
                                              If f.Name = "VirtualProtect" Then
                                                  score += 100
                                              ElseIf f.Name = "VirtualFree" Then
                                                  score += 85
                                              ElseIf f.Name = "SetWindowsHookEx" Then
                                                  score += 100
                                              ElseIf f.Name = "SetWindowsHook" Then
                                                  score += 100
                                              ElseIf f.Name = "TerminateProcess" Then
                                                  score += 70
                                              ElseIf f.Name = "FrostCrashedWindow" Then
                                                  Return True
                                              Else
                                                  score += 55
                                              End If
                                              Debug.Print($"分数:{score}")
                                          End If

                                          'FreeLibrary(NSudoDevilModeModuleHandle)
                                          FreeLibrary(NSudoDevilModeModuleHandle)

                                      Next

                                      If score >= 120 Then Return True
                                  Catch ex As Exception

                                  End Try

                              End Function)
    End Function

    Private Sub KillProcBtn_Click(sender As Object, e As EventArgs) Handles KillProcBtn.Click
        MainForm.EndProcessByName(Kill)
        Invoke(Sub() Hide())
    End Sub

    Private Sub DelFileBtn_Click(sender As Object, e As EventArgs) Handles DelFileBtn.Click
        MainForm.EndProcessByName(Kill)

        IO.File.Delete(Del)
        Invoke(Sub() Hide())
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Hide()
    End Sub

    Private Sub Btn_MinWindow_Click(sender As Object, e As EventArgs) Handles Btn_MinWindow.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub 退出程序ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出程序ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub 主界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 主界面ToolStripMenuItem.Click
        MainForm.Show()
    End Sub

    Private Sub AddToWhiteList_Click(sender As Object, e As EventArgs) Handles AddToWhiteList.Click
        If Not WhiteList.Contains(WhiteListApp) Then WhiteList.Add(WhiteListApp)
        IO.File.WriteAllLines(Application.StartupPath + "\WhiteList", WhiteList)

        Hide()
    End Sub
End Class