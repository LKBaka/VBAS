Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.IO

Public Class ActiveDefense
    Public FileName_Show As String
    Public MalwareType_Show As String
    Public ProcessName

    Public NSudoPath = Application.StartupPath + "NSudoDM.dll"
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode)>
    Shared Function LoadLibrary(lpLibFileName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Shared Function FreeLibrary(hLibModule As IntPtr) As Boolean
    End Function
    'Public State As Int16 = 0



    Private Sub Btn_Close_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Btn_MinWindow_Click(sender As Object, e As EventArgs)
        MinWindow()
    End Sub
    Public Sub MinWindow()
        WindowState = FormWindowState.Minimized
    End Sub
    Public Function Receive_Messages(FileName, MalwareType, pname) As Task
        '  Await Task.Run(Sub()
        FileName_Show = FileName
                           MalwareType_Show = MalwareType
                           ProcessName = pname
        '              End Sub)
    End Function
    Private Async Sub ActiveDefense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 使用异步方法来避免阻塞UI线程  
        Await Task.Run(Sub()
                           ' 这里执行后台任务，但避免直接操作UI元素  
                           Shell("taskkill /f /t /im " + ProcessName + ".exe")
                           ' ...（其他后台处理逻辑）  
                       End Sub)

        ' 在UI线程上更新UI元素  
        UpdateUI()
    End Sub

    Private Sub UpdateUI()
        ' 确保这个方法在UI线程上执行  
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf UpdateUI))
            Return
        End If

        ' 更新UI元素  
        VirusPath.Text = "病毒路径: " & FileName_Show
        VirusName.Text = "病毒名称: " & MalwareType_Show
        ' 注意：这里不应该包含加载和卸载DLL的逻辑，除非这是必要的后台任务  
        ' ...（其他需要在UI线程上执行的更新操作）  
    End Sub
    Public Sub del()
        ' Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名
        IO.File.Delete(FileName_Show)
        MsgBox("删除成功！", , "VBAS")
        ' FreeLibrary(NSudoDevilModeModuleHandle)
    End Sub

    Private Sub SelPathScan_Btn_Click(sender As Object, e As EventArgs) Handles SelPathScan_Btn.Click
        ' 尝试删除文件，并在UI线程上显示结果  
        Try
            ' 使用Invoke确保在UI线程上更新UI  
            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf del))
            End If


        Catch ex As Exception
            ' 处理删除文件时可能发生的异常  
            MsgBox("删除失败：" & ex.Message, , "VBAS")
        End Try
    ' 注意：这里不应该包含加载和卸载DLL的逻辑，除非这是必要的后台任务  
    ' ...（其他需要在点击事件中执行的逻辑）  
    End Sub
End Class