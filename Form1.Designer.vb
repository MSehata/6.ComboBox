<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New Windows.Forms.ComboBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnRemoveSelected = New Button()
        btnClear = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Huawei", "Oppo"})
        ComboBox1.Location = New Point(289, 119)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(180, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(219, 287)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(76, 28)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(301, 287)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(76, 28)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveSelected
        ' 
        btnRemoveSelected.Location = New Point(383, 287)
        btnRemoveSelected.Name = "btnRemoveSelected"
        btnRemoveSelected.Size = New Size(76, 28)
        btnRemoveSelected.TabIndex = 1
        btnRemoveSelected.Text = "Remove Selected"
        btnRemoveSelected.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(465, 287)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(76, 28)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(333, 327)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnClear)
        Controls.Add(btnRemoveSelected)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "ComboBox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRemoveSelected As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
