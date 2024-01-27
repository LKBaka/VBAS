Imports System.Threading

Public Class ActiveDefense
    Private Async Sub ActiveDefense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New Scan()
        Await s.ProcessCheck()
    End Sub
End Class