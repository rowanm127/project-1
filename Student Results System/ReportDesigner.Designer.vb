<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportDesigner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDesigner))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbReportType = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblAdaptive = New System.Windows.Forms.Label()
        Me.cmbAdaptive = New System.Windows.Forms.ComboBox()
        Me.lblAdaptive2 = New System.Windows.Forms.Label()
        Me.cmbAdaptive2 = New System.Windows.Forms.ComboBox()
        Me.lblAdaptive3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Report Type"
        '
        'cmbReportType
        '
        Me.cmbReportType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Items.AddRange(New Object() {"Module", "Unit", "Student"})
        Me.cmbReportType.Location = New System.Drawing.Point(16, 47)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(147, 21)
        Me.cmbReportType.TabIndex = 3
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPrint.Image = Global.Student_Results_System.My.Resources.Resources.printer_grey
        Me.btnPrint.Location = New System.Drawing.Point(21, 527)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(3)
        Me.btnPrint.Size = New System.Drawing.Size(92, 91)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Student_Results_System.My.Resources.Resources.ReportPreviewPlaceholder
        Me.PictureBox1.Location = New System.Drawing.Point(274, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 606)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.Image = Global.Student_Results_System.My.Resources.Resources.save_grey
        Me.btnSave.Location = New System.Drawing.Point(139, 527)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSave.Size = New System.Drawing.Size(92, 91)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblAdaptive
        '
        Me.lblAdaptive.AutoSize = True
        Me.lblAdaptive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdaptive.Location = New System.Drawing.Point(13, 107)
        Me.lblAdaptive.Name = "lblAdaptive"
        Me.lblAdaptive.Size = New System.Drawing.Size(100, 15)
        Me.lblAdaptive.TabIndex = 6
        Me.lblAdaptive.Text = "You can't see me"
        Me.lblAdaptive.Visible = False
        '
        'cmbAdaptive
        '
        Me.cmbAdaptive.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAdaptive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdaptive.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAdaptive.FormattingEnabled = True
        Me.cmbAdaptive.Location = New System.Drawing.Point(116, 133)
        Me.cmbAdaptive.Name = "cmbAdaptive"
        Me.cmbAdaptive.Size = New System.Drawing.Size(147, 21)
        Me.cmbAdaptive.TabIndex = 7
        Me.cmbAdaptive.Visible = False
        '
        'lblAdaptive2
        '
        Me.lblAdaptive2.AutoSize = True
        Me.lblAdaptive2.Location = New System.Drawing.Point(5, 136)
        Me.lblAdaptive2.Name = "lblAdaptive2"
        Me.lblAdaptive2.Size = New System.Drawing.Size(105, 13)
        Me.lblAdaptive2.TabIndex = 10
        Me.lblAdaptive2.Text = "Can't see me either"
        Me.lblAdaptive2.Visible = False
        '
        'cmbAdaptive2
        '
        Me.cmbAdaptive2.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAdaptive2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdaptive2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAdaptive2.FormattingEnabled = True
        Me.cmbAdaptive2.Location = New System.Drawing.Point(116, 178)
        Me.cmbAdaptive2.Name = "cmbAdaptive2"
        Me.cmbAdaptive2.Size = New System.Drawing.Size(147, 21)
        Me.cmbAdaptive2.TabIndex = 11
        Me.cmbAdaptive2.Visible = False
        '
        'lblAdaptive3
        '
        Me.lblAdaptive3.AutoSize = True
        Me.lblAdaptive3.Location = New System.Drawing.Point(5, 181)
        Me.lblAdaptive3.Name = "lblAdaptive3"
        Me.lblAdaptive3.Size = New System.Drawing.Size(105, 13)
        Me.lblAdaptive3.TabIndex = 12
        Me.lblAdaptive3.Text = "Can't see me either"
        Me.lblAdaptive3.Visible = False
        '
        'ReportDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(673, 630)
        Me.Controls.Add(Me.lblAdaptive3)
        Me.Controls.Add(Me.cmbAdaptive2)
        Me.Controls.Add(Me.lblAdaptive2)
        Me.Controls.Add(Me.cmbAdaptive)
        Me.Controls.Add(Me.lblAdaptive)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbReportType)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(689, 704)
        Me.MinimizeBox = False
        Me.Name = "ReportDesigner"
        Me.ShowIcon = False
        Me.Text = "Report Designer Beta 5.1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblAdaptive As System.Windows.Forms.Label
    Friend WithEvents cmbAdaptive As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdaptive2 As System.Windows.Forms.Label
    Friend WithEvents cmbAdaptive2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdaptive3 As System.Windows.Forms.Label
End Class
