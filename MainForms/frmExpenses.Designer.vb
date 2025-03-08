<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpenses
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddExpense = New Guna.UI2.WinForms.Guna2Button()
        Me.txtItem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgExpenses = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddExpense
        '
        Me.btnAddExpense.Animated = True
        Me.btnAddExpense.BorderRadius = 15
        Me.btnAddExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddExpense.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnAddExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddExpense.ForeColor = System.Drawing.Color.White
        Me.btnAddExpense.IndicateFocus = True
        Me.btnAddExpense.Location = New System.Drawing.Point(9, 152)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.Size = New System.Drawing.Size(112, 45)
        Me.btnAddExpense.TabIndex = 5
        Me.btnAddExpense.Text = "Add"
        '
        'txtItem
        '
        Me.txtItem.Animated = True
        Me.txtItem.BorderRadius = 10
        Me.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItem.DefaultText = ""
        Me.txtItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItem.Location = New System.Drawing.Point(9, 9)
        Me.txtItem.Margin = New System.Windows.Forms.Padding(0)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtItem.PlaceholderText = "Item"
        Me.txtItem.SelectedText = ""
        Me.txtItem.Size = New System.Drawing.Size(260, 35)
        Me.txtItem.TabIndex = 6
        '
        'txtCategory
        '
        Me.txtCategory.Animated = True
        Me.txtCategory.BorderRadius = 10
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.DefaultText = ""
        Me.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(9, 44)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtCategory.PlaceholderText = "Category"
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.Size = New System.Drawing.Size(260, 35)
        Me.txtCategory.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Animated = True
        Me.txtDescription.BorderRadius = 10
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(9, 79)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtDescription.PlaceholderText = "Description"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(260, 35)
        Me.txtDescription.TabIndex = 8
        '
        'txtCost
        '
        Me.txtCost.Animated = True
        Me.txtCost.BorderRadius = 10
        Me.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCost.DefaultText = ""
        Me.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCost.Location = New System.Drawing.Point(9, 114)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtCost.PlaceholderText = "Cost"
        Me.txtCost.SelectedText = ""
        Me.txtCost.Size = New System.Drawing.Size(260, 35)
        Me.txtCost.TabIndex = 9
        '
        'dgExpenses
        '
        Me.dgExpenses.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgExpenses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgExpenses.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgExpenses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgExpenses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgExpenses.ColumnHeadersHeight = 22
        Me.dgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgExpenses.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgExpenses.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgExpenses.Location = New System.Drawing.Point(272, 0)
        Me.dgExpenses.Name = "dgExpenses"
        Me.dgExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgExpenses.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgExpenses.RowHeadersVisible = False
        Me.dgExpenses.RowHeadersWidth = 51
        Me.dgExpenses.Size = New System.Drawing.Size(528, 450)
        Me.dgExpenses.TabIndex = 16
        Me.dgExpenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgExpenses.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgExpenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgExpenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgExpenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgExpenses.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.dgExpenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgExpenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgExpenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgExpenses.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgExpenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgExpenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgExpenses.ThemeStyle.HeaderStyle.Height = 22
        Me.dgExpenses.ThemeStyle.ReadOnly = False
        Me.dgExpenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgExpenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgExpenses.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgExpenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgExpenses.ThemeStyle.RowsStyle.Height = 22
        Me.dgExpenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgExpenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnExport
        '
        Me.btnExport.Animated = True
        Me.btnExport.BorderRadius = 15
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Inter", 12.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.IndicateFocus = True
        Me.btnExport.Location = New System.Drawing.Point(127, 152)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 45)
        Me.btnExport.TabIndex = 19
        Me.btnExport.Text = "Export"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dgExpenses)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnAddExpense)
        Me.Name = "frmExpenses"
        Me.Text = "frmExpenses"
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnAddExpense As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtItem As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtCategory As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgExpenses As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
End Class
