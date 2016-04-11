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
        Me.lblModule.Location = New System.Drawing.Point(31, 170)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(45, 13)
        Me.lblModule.TabIndex = 8
        Me.lblModule.Text = "Module:"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(31, 200)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(29, 13)
        Me.lblUnit.TabIndex = 10
        Me.lblUnit.Text = "Unit:"
        '
        'btnAdvSearch
        '
        Me.btnAdvSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdvSearch.Location = New System.Drawing.Point(94, 240)
        Me.btnAdvSearch.Name = "btnAdvSearch"
        Me.btnAdvSearch.Size = New System.Drawing.Size(145, 23)
        Me.btnAdvSearch.TabIndex = 12
        Me.btnAdvSearch.Text = "Search"
        Me.btnAdvSearch.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(94, 114)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(145, 21)
        Me.cmbYear.TabIndex = 13
        '
        'cmbModule
        '
        Me.cmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModule.FormattingEnabled = True
        Me.cmbModule.Location = New System.Drawing.Point(94, 167)
        Me.cmbModule.Name = "cmbModule"
        Me.cmbModule.Size = New System.Drawing.Size(145, 21)
        Me.cmbModule.TabIndex = 14
        '
        'cmbUnit
        '
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(94, 197)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(145, 21)
        Me.cmbUnit.TabIndex = 15
        '
        'AdvSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(278, 275)
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
End Class
