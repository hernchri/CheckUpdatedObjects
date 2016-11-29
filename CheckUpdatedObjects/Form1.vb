Imports System.IO

Public Class Form1
    Private fileType As String = ".class"

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtWorkspace.Text = "D:\SCWS\SMART_CONSOLE\SmartConsoleWebServiceAtp"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim workSpace As New DirectoryInfo(txtWorkspace.Text)
        dgvObjectList.Rows.Clear()
        Button1.Enabled = False

        If Not workSpace.Exists Then
            MessageBox.Show("Incorrect Directory")
            Exit Sub
        End If

        For Each folders As DirectoryInfo In workSpace.GetDirectories()
            Dim objectList As FileInfo() = folders.GetFiles()
            For Each objectFile As FileInfo In objectList
                'If DateTime.Compare(objectFile.LastWriteTime.Day, Date.Today.Day) Then

                'End If
                Dim objectVo As New ObjectVo

                'dgvObjectList.Rows.Add(objectVo.FileName, objectVo.FileDirectory, objectVo.FileDate)
                'If objectFile.Extension.ToString = ".class" Or objectFile.Extension.ToString = ".java" Then
                If objectFile.Extension.Trim = ".java" Then

                    objectVo.FileName = objectFile.Name
                    objectVo.FileDate = objectFile.LastWriteTime
                    objectVo.FileDirectory = objectFile.Directory.ToString

                    Me.dgvObjectList.Rows.Add(objectVo.FileName, objectVo.FileDirectory, objectVo.FileDate)
                End If


            Next

            handleSubDirectory(folders.FullName.ToString)
        Next

        dgvObjectList.Sort(fileDate, System.ComponentModel.ListSortDirection.Descending)

        Button1.Enabled = True


    End Sub

    Private Sub handleSubDirectory(ByRef path As String)
        Dim dir As New DirectoryInfo(path)

        For Each objectFile As FileInfo In dir.GetFiles()
            'If DateTime.Compare(objectFile.LastWriteTime.Day, Date.Today.Day) Then

            'End If
            Dim objectVo As New ObjectVo
            objectVo.FileName = objectFile.Name
            objectVo.FileDate = objectFile.LastWriteTime
            objectVo.FileDirectory = objectFile.Directory.ToString

            'dgvObjectList.Rows.Add(objectVo.FileName, objectVo.FileDirectory, objectVo.FileDate)
            If objectFile.Extension.ToString = ".java" Then
                Me.dgvObjectList.Rows.Add(objectVo.FileName, objectVo.FileDirectory, objectVo.FileDate)
            End If

        Next

        For Each subDir As DirectoryInfo In dir.GetDirectories
            handleSubDirectory(subDir.FullName.ToString)
        Next
    End Sub

End Class
