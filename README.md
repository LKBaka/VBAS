# VBAS —— 一个Visual Basic制作的自制杀软
## 附言
> 首先,这是个自制杀软项目,不要指望着这是什么很高级的杀软.<br>
> 然后,这是使用了.net 6.0的项目.如果你想要编译项目，请先安装好Visual Studio和.net 6.0<br>
> 最后,这个杀软误报极高!!!需要一定的电脑能力.接下来就是放代码了<br>
#### 导入表查杀代码(代码写的有点烂,别介意)
```
Public Async Function PEFuncScanFunc(file As String) As Task
    Await Task.Run(Async Function()
                       Try
                           Dim NSudoDevilModeModuleHandle As IntPtr = LoadLibrary(NSudoPath) ' DLL文件名  

                           Dim fileExtension As String = Path.GetExtension(file)
                           'If fileExtension = ".exe" AndAlso fileExtension IsNot Nothing Then
                           Dim peFile = New PeFile(file)
                           Dim score = 0
                           For Each f In peFile.ImportedFunctions
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
                                       score += 150
                                   Else
                                       score += 50
                                   End If
                               End If
                               Debug.Print($"分数:{score}")
                               ' End If
                           Next

                           If score >= 120 Then
                               Me.Invoke(Sub()
                                             If ScanedFile.Contains(file) Then
                                                 Exit Sub
                                             End If

                                             Me.ListView1.Items.Add(file)
                                             Me.VirusCount.Text = "威胁数量:" & Me.ListView1.Items.Count
                                             ScanedFile.Add(file)
                                         End Sub)
                           End If




                           ' End If

                           FreeLibrary(NSudoDevilModeModuleHandle)
                       Catch ex As Exception
                           Debug.Print("")
                       End Try

                   End Function)
End Function
```
