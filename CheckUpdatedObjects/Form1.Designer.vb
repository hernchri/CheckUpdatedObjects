<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvObjectList = New System.Windows.Forms.DataGridView()
        Me.fileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.directory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fileDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtWorkspace = New System.Windows.Forms.TextBox()
        CType(Me.dgvObjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View Latest Objects"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvObjectList
        '
        Me.dgvObjectList.AllowUserToAddRows = False
        Me.dgvObjectList.AllowUserToDeleteRows = False
        Me.dgvObjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvObjectList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvObjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObjectList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fileName, Me.directory, Me.fileDate})
        Me.dgvObjectList.Location = New System.Drawing.Point(13, 87)
        Me.dgvObjectList.Name = "dgvObjectList"
        Me.dgvObjectList.ReadOnly = True
        Me.dgvObjectList.Size = New System.Drawing.Size(843, 341)
        Me.dgvObjectList.TabIndex = 2
        '
        'fileName
        '
        Me.fileName.HeaderText = "File Name"
        Me.fileName.Name = "fileName"
        Me.fileName.ReadOnly = True
        '
        'directory
        '
        Me.directory.HeaderText = "Directory"
        Me.directory.Name = "directory"
        Me.directory.ReadOnly = True
        '
        'fileDate
        '
        Me.fileDate.HeaderText = "Date"
        Me.fileDate.Name = "fileDate"
        Me.fileDate.ReadOnly = True
        '
        'txtWorkspace
        '
        Me.txtWorkspace.Location = New System.Drawing.Point(375, 13)
        Me.txtWorkspace.Name = "txtWorkspace"
        Me.txtWorkspace.Size = New System.Drawing.Size(419, 20)
        Me.txtWorkspace.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 440)
        Me.Controls.Add(Me.txtWorkspace)
        Me.Controls.Add(Me.dgvObjectList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Workspace Checker - "
        CType(Me.dgvObjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvObjectList As System.Windows.Forms.DataGridView
    Friend WithEvents fileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents directory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fileDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtWorkspace As System.Windows.Forms.TextBox

End Class
