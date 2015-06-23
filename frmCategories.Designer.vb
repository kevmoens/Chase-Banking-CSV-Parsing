<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
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
        Me.components = New System.ComponentModel.Container
        Me.grdConditions = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.ConditionsContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.grdConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConditionsContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdConditions
        '
        Me.grdConditions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdConditions.Location = New System.Drawing.Point(232, 2)
        Me.grdConditions.Name = "grdConditions"
        Me.grdConditions.Size = New System.Drawing.Size(362, 298)
        Me.grdConditions.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(12, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(117, 266)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(54, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 20)
        Me.txtName.TabIndex = 4
        '
        'ConditionsContextMenuStrip
        '
        Me.ConditionsContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ConditionsContextMenuStrip.Name = "CategoriesContextMenuStrip"
        Me.ConditionsContextMenuStrip.Size = New System.Drawing.Size(118, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'frmCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 301)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grdConditions)
        Me.Name = "frmCategories"
        Me.Text = "Category"
        CType(Me.grdConditions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConditionsContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdConditions As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents ConditionsContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
