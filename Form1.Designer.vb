<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            Try
                g_AllCategories.Save()
            Catch ex As Exception

            End Try
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnLoad = New System.Windows.Forms.Button
        Me.grdCategories = New System.Windows.Forms.DataGridView
        Me.lblSum = New System.Windows.Forms.Label
        Me.lblSummary = New System.Windows.Forms.Label
        Me.btnPlusMonth = New System.Windows.Forms.Button
        Me.btnMinusMonth = New System.Windows.Forms.Button
        Me.btnPlusWeek = New System.Windows.Forms.Button
        Me.btnMinusWeek = New System.Windows.Forms.Button
        Me.btnProcessDetail = New System.Windows.Forms.Button
        Me.btnProcess = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CategoriesContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grdCardHolders = New System.Windows.Forms.DataGridView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriesContextMenuStrip.SuspendLayout()
        CType(Me.grdCardHolders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdCardHolders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLoad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdCategories)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSummary)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPlusMonth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMinusMonth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPlusWeek)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMinusWeek)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnProcessDetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnProcess)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(639, 449)
        Me.SplitContainer1.SplitterDistance = 180
        Me.SplitContainer1.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(12, 55)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(49, 23)
        Me.btnLoad.TabIndex = 22
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'grdCategories
        '
        Me.grdCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCategories.Location = New System.Drawing.Point(282, 3)
        Me.grdCategories.Name = "grdCategories"
        Me.grdCategories.Size = New System.Drawing.Size(354, 174)
        Me.grdCategories.TabIndex = 21
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(73, 85)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 13)
        Me.lblSum.TabIndex = 20
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(12, 85)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(50, 13)
        Me.lblSummary.TabIndex = 19
        Me.lblSummary.Text = "Summary"
        '
        'btnPlusMonth
        '
        Me.btnPlusMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnPlusMonth.Location = New System.Drawing.Point(38, 26)
        Me.btnPlusMonth.Name = "btnPlusMonth"
        Me.btnPlusMonth.Size = New System.Drawing.Size(29, 23)
        Me.btnPlusMonth.TabIndex = 18
        Me.btnPlusMonth.Text = "+M"
        Me.btnPlusMonth.UseVisualStyleBackColor = True
        '
        'btnMinusMonth
        '
        Me.btnMinusMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnMinusMonth.Location = New System.Drawing.Point(38, 2)
        Me.btnMinusMonth.Name = "btnMinusMonth"
        Me.btnMinusMonth.Size = New System.Drawing.Size(29, 23)
        Me.btnMinusMonth.TabIndex = 17
        Me.btnMinusMonth.Text = "-M"
        Me.btnMinusMonth.UseVisualStyleBackColor = True
        '
        'btnPlusWeek
        '
        Me.btnPlusWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnPlusWeek.Location = New System.Drawing.Point(3, 26)
        Me.btnPlusWeek.Name = "btnPlusWeek"
        Me.btnPlusWeek.Size = New System.Drawing.Size(29, 23)
        Me.btnPlusWeek.TabIndex = 16
        Me.btnPlusWeek.Text = "+W"
        Me.btnPlusWeek.UseVisualStyleBackColor = True
        '
        'btnMinusWeek
        '
        Me.btnMinusWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnMinusWeek.Location = New System.Drawing.Point(3, 2)
        Me.btnMinusWeek.Name = "btnMinusWeek"
        Me.btnMinusWeek.Size = New System.Drawing.Size(29, 23)
        Me.btnMinusWeek.TabIndex = 15
        Me.btnMinusWeek.Text = "-W"
        Me.btnMinusWeek.UseVisualStyleBackColor = True
        '
        'btnProcessDetail
        '
        Me.btnProcessDetail.Location = New System.Drawing.Point(192, 55)
        Me.btnProcessDetail.Name = "btnProcessDetail"
        Me.btnProcessDetail.Size = New System.Drawing.Size(84, 23)
        Me.btnProcessDetail.TabIndex = 1
        Me.btnProcessDetail.Text = "Process Detail"
        Me.btnProcessDetail.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(76, 55)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(83, 23)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(76, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 265)
        Me.DataGridView1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CategoriesContextMenuStrip
        '
        Me.CategoriesContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.CategoriesContextMenuStrip.Name = "CategoriesContextMenuStrip"
        Me.CategoriesContextMenuStrip.Size = New System.Drawing.Size(125, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'grdCardHolders
        '
        Me.grdCardHolders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdCardHolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCardHolders.Location = New System.Drawing.Point(12, 101)
        Me.grdCardHolders.Name = "grdCardHolders"
        Me.grdCardHolders.Size = New System.Drawing.Size(264, 76)
        Me.grdCardHolders.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 449)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriesContextMenuStrip.ResumeLayout(False)
        CType(Me.grdCardHolders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcessDetail As System.Windows.Forms.Button
    Friend WithEvents btnPlusWeek As System.Windows.Forms.Button
    Friend WithEvents btnMinusWeek As System.Windows.Forms.Button
    Friend WithEvents btnPlusMonth As System.Windows.Forms.Button
    Friend WithEvents btnMinusMonth As System.Windows.Forms.Button
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grdCategories As System.Windows.Forms.DataGridView
    Friend WithEvents CategoriesContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents grdCardHolders As System.Windows.Forms.DataGridView

End Class
