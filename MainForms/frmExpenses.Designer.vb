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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtItem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgExpenses = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnAddExpense = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateExpenses = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteExpense = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtDescription.Location = New System.Drawing.Point(9, 86)
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
        Me.txtCost.Location = New System.Drawing.Point(9, 124)
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgExpenses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgExpenses.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgExpenses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgExpenses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgExpenses.ColumnHeadersHeight = 22
        Me.dgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgExpenses.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgExpenses.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgExpenses.Location = New System.Drawing.Point(275, 0)
        Me.dgExpenses.Name = "dgExpenses"
        Me.dgExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgExpenses.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgExpenses.RowHeadersVisible = False
        Me.dgExpenses.RowHeadersWidth = 51
        Me.dgExpenses.Size = New System.Drawing.Size(525, 450)
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
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Location = New System.Drawing.Point(9, 47)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(260, 36)
        Me.cmbCategory.TabIndex = 20
        '
        'btnAddExpense
        '
        Me.btnAddExpense.Animated = True
        Me.btnAddExpense.BorderRadius = 15
        Me.btnAddExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddExpense.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddExpense.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddExpense.ForeColor = System.Drawing.Color.Black
        Me.btnAddExpense.IndicateFocus = True
        Me.btnAddExpense.Location = New System.Drawing.Point(9, 172)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.Size = New System.Drawing.Size(112, 35)
        Me.btnAddExpense.TabIndex = 21
        Me.btnAddExpense.Text = "Add"
        '
        'btnExport
        '
        Me.btnExport.Animated = True
        Me.btnExport.BorderRadius = 15
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.IndicateFocus = True
        Me.btnExport.Location = New System.Drawing.Point(9, 213)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 35)
        Me.btnExport.TabIndex = 22
        Me.btnExport.Text = "Export"
        '
        'btnUpdateExpenses
        '
        Me.btnUpdateExpenses.Animated = True
        Me.btnUpdateExpenses.BorderRadius = 15
        Me.btnUpdateExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateExpenses.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateExpenses.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateExpenses.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateExpenses.IndicateFocus = True
        Me.btnUpdateExpenses.Location = New System.Drawing.Point(157, 172)
        Me.btnUpdateExpenses.Name = "btnUpdateExpenses"
        Me.btnUpdateExpenses.Size = New System.Drawing.Size(112, 35)
        Me.btnUpdateExpenses.TabIndex = 23
        Me.btnUpdateExpenses.Text = "Update"
        '
        'btnDeleteExpense
        '
        Me.btnDeleteExpense.Animated = True
        Me.btnDeleteExpense.BorderRadius = 15
        Me.btnDeleteExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteExpense.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnDeleteExpense.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteExpense.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteExpense.IndicateFocus = True
        Me.btnDeleteExpense.Location = New System.Drawing.Point(157, 213)
        Me.btnDeleteExpense.Name = "btnDeleteExpense"
        Me.btnDeleteExpense.Size = New System.Drawing.Size(112, 35)
        Me.btnDeleteExpense.TabIndex = 24
        Me.btnDeleteExpense.Text = "Delete"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDeleteExpense)
        Me.Controls.Add(Me.btnUpdateExpenses)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnAddExpense)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.dgExpenses)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItem)
        Me.Name = "frmExpenses"
        Me.Text = "frmExpenses"
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtItem As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgExpenses As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents btnAddExpense As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnUpdateExpenses As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnDeleteExpense As Guna.UI2.WinForms.Guna2Button
End Class
