<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddResult
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
        Me.lblMark = New System.Windows.Forms.Label()
        Me.btnAddResult = New System.Windows.Forms.Button()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblResultType = New System.Windows.Forms.Label()
        Me.cmbResultType = New System.Windows.Forms.ComboBox()
        Me.lblModule = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.cmbModule = New System.Windows.Forms.ComboBox()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.lblSId = New System.Windows.Forms.Label()
        Me.cmbSId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblMark.Location = New System.Drawing.Point(46, 115)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(41, 17)
        Me.lblMark.TabIndex = 13
        Me.lblMark.Text = "Mark:"
        Me.lblMark.Visible = False
        '
        'btnAddResult
        '
        Me.btnAddResult.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddResult.Location = New System.Drawing.Point(82, 194)
        Me.btnAddResult.Name = "btnAddResult"
        Me.btnAddResult.Size = New System.Drawing.Size(182, 39)
        Me.btnAddResult.TabIndex = 12
        Me.btnAddResult.Text = "Add Result"
        Me.btnAddResult.UseVisualStyleBackColor = False
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblUnit.Location = New System.Drawing.Point(46, 87)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(34, 17)
        Me.lblUnit.TabIndex = 11
        Me.lblUnit.Text = "Unit:"
        Me.lblUnit.Visible = False
        '
        'lblResultType
        '
        Me.lblResultType.AutoSize = True
        Me.lblResultType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultType.Location = New System.Drawing.Point(46, 61)
        Me.lblResultType.Name = "lblResultType"
        Me.lblResultType.Size = New System.Drawing.Size(75, 17)
        Me.lblResultType.TabIndex = 10
        Me.lblResultType.Text = "Result type:"
        '
        'cmbResultType
        '
        Me.cmbResultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResultType.FormattingEnabled = True
        Me.cmbResultType.Items.AddRange(New Object() {"Unit", "Module"})
        Me.cmbResultType.Location = New System.Drawing.Point(125, 60)
        Me.cmbResultType.Name = "cmbResultType"
        Me.cmbResultType.Size = New System.Drawing.Size(182, 21)
        Me.cmbResultType.TabIndex = 15
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblModule.Location = New System.Drawing.Point(46, 151)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(56, 17)
        Me.lblModule.TabIndex = 16
        Me.lblModule.Text = "Module:"
        Me.lblModule.Visible = False
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"4002:001", "4002:002", "4002:003", "4002:004"})
        Me.cmbUnit.Location = New System.Drawing.Point(125, 88)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(182, 21)
        Me.cmbUnit.TabIndex = 17
        Me.cmbUnit.Visible = False
        '
        'cmbModule
        '
        Me.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModule.FormattingEnabled = True
        Me.cmbModule.Items.AddRange(New Object() {"4001", "4002", "4003", "4004", "4005"})
        Me.cmbModule.Location = New System.Drawing.Point(125, 151)
        Me.cmbModule.Name = "cmbModule"
        Me.cmbModule.Size = New System.Drawing.Size(182, 21)
        Me.cmbModule.TabIndex = 18
        Me.cmbModule.Visible = False
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(125, 115)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(182, 22)
        Me.txtMark.TabIndex = 19
        Me.txtMark.Visible = False
        '
        'lblSId
        '
        Me.lblSId.AutoSize = True
        Me.lblSId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSId.Location = New System.Drawing.Point(46, 34)
        Me.lblSId.Name = "lblSId"
        Me.lblSId.Size = New System.Drawing.Size(71, 17)
        Me.lblSId.TabIndex = 20
        Me.lblSId.Text = "Student ID:"
        '
        'cmbSId
        '
        Me.cmbSId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSId.FormattingEnabled = True
        Me.cmbSId.Location = New System.Drawing.Point(125, 34)
        Me.cmbSId.Name = "cmbSId"
        Me.cmbSId.Size = New System.Drawing.Size(182, 21)
        Me.cmbSId.TabIndex = 21
        '
        'AddResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(351, 245)
        Me.Controls.Add(Me.cmbSId)
        Me.Controls.Add(Me.lblSId)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.cmbModule)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.lblModule)
        Me.Controls.Add(Me.cmbResultType)
        Me.Controls.Add(Me.lblMark)
        Me.Controls.Add(Me.btnAddResult)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblResultType)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddResult"
        Me.Text = "AddResult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMark As System.Windows.Forms.Label
    Friend WithEvents btnAddResult As System.Windows.Forms.Button
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblResultType As System.Windows.Forms.Label
    Friend WithEvents cmbResultType As System.Windows.Forms.ComboBox
    Friend WithEvents lblModule As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModule As System.Windows.Forms.ComboBox
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents lblSId As System.Windows.Forms.Label
    Friend WithEvents cmbSId As System.Windows.Forms.ComboBox
End Class
