<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvSearch
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblStuSearch = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblResultSearch = New System.Windows.Forms.Label()
        Me.lblModule = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.btnAdvSearch = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbModule = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(94, 48)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(145, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(31, 51)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblStuSearch
        '
        Me.lblStuSearch.AutoSize = True
        Me.lblStuSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuSearch.Location = New System.Drawing.Point(12, 23)
        Me.lblStuSearch.Name = "lblStuSearch"
        Me.lblStuSearch.Size = New System.Drawing.Size(95, 13)
        Me.lblStuSearch.TabIndex = 2
        Me.lblStuSearch.Text = "Student Search"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(31, 83)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(94, 80)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(145, 20)
        Me.txtLastName.TabIndex = 4
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(31, 117)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblResultSearch
        '
        Me.lblResultSearch.AutoSize = True
        Me.lblResultSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultSearch.Location = New System.Drawing.Point(12, 146)
        Me.lblResultSearch.Name = "lblResultSearch"
        Me.lblResultSearch.Size = New System.Drawing.Size(87, 13)
        Me.lblResultSearch.TabIndex = 7
        Me.lblResultSearch.Text = "Result Search"
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Location = New System.Drawing.Point(31, 201)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(45, 13)
        Me.lblModule.TabIndex = 8
        Me.lblModule.Text = "Module:"
        Me.lblModule.Visible = False
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(31, 231)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(29, 13)
        Me.lblUnit.TabIndex = 10
        Me.lblUnit.Text = "Unit:"
        Me.lblUnit.Visible = False
        '
        'btnAdvSearch
        '
        Me.btnAdvSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdvSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdvSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdvSearch.Location = New System.Drawing.Point(94, 240)
        Me.btnAdvSearch.Name = "btnAdvSearch"
        Me.btnAdvSearch.Size = New System.Drawing.Size(145, 23)
        Me.btnAdvSearch.TabIndex = 12
        Me.btnAdvSearch.Text = "Search"
        Me.btnAdvSearch.UseVisualStyleBackColor = False
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {" ", "1", "2"})
        Me.cmbYear.Location = New System.Drawing.Point(94, 114)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(145, 21)
        Me.cmbYear.TabIndex = 13
        '
        'cmbModule
        '
        Me.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModule.FormattingEnabled = True
        Me.cmbModule.Items.AddRange(New Object() {"4001", "4002", "4003", "4004", "4005", "5001", "5002", "5003", "5004", "5005", "5006", "5007"})
        Me.cmbModule.Location = New System.Drawing.Point(94, 198)
        Me.cmbModule.Name = "cmbModule"
        Me.cmbModule.Size = New System.Drawing.Size(145, 21)
        Me.cmbModule.TabIndex = 14
        Me.cmbModule.Visible = False
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"4002:001", "4002:002", "4002:003", "4002:004", "4003:001", "4003:002", "4003:003", "4003:004", "4004:001", "4004:002", "4004:003", "5002:001", "5002:002", "5002:003", "5002:004", "5003:001", "5003:002"})
        Me.cmbUnit.Location = New System.Drawing.Point(94, 228)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(145, 21)
        Me.cmbUnit.TabIndex = 15
        Me.cmbUnit.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Module", "Unit"})
        Me.cmbType.Location = New System.Drawing.Point(94, 167)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(145, 21)
        Me.cmbType.TabIndex = 16
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(31, 170)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 17
        Me.lblType.Text = "Type:"
        '
        'AdvSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(278, 275)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.cmbModule)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.btnAdvSearch)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblModule)
        Me.Controls.Add(Me.lblResultSearch)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblStuSearch)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdvSearch"
        Me.ShowIcon = False
        Me.Text = "Advanced Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblStuSearch As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblResultSearch As Label
    Friend WithEvents lblModule As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents btnAdvSearch As Button
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModule As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblType As Label
End Class
