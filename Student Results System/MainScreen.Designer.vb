<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReportDesigner = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHideToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSidebarToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMassEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtabQuick = New System.Windows.Forms.TabControl()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdvSearch = New System.Windows.Forms.Button()
        Me.txtWaterSearch = New Student_Results_System.TextboxWatermark()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnAddResult = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.mtabHome = New System.Windows.Forms.TabControl()
        Me.tabStudents = New System.Windows.Forms.TabPage()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.SIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DefaultDataSet2 = New Student_Results_System.DefaultDataSet()
        Me.tabWB4001 = New System.Windows.Forms.TabPage()
        Me.dgv4001 = New System.Windows.Forms.DataGridView()
        Me.dgv4001FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv4001LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv4001ModulePass = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabWB4002 = New System.Windows.Forms.TabPage()
        Me.mtabWB4002 = New System.Windows.Forms.TabControl()
        Me.tab4002 = New System.Windows.Forms.TabPage()
        Me.dgv4002 = New System.Windows.Forms.DataGridView()
        Me.dgv4002FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv4002LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv4002ModuleResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4002001 = New System.Windows.Forms.TabPage()
        Me.dgv4002001 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4002002 = New System.Windows.Forms.TabPage()
        Me.dgv4002002 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4002003 = New System.Windows.Forms.TabPage()
        Me.dgv4002003 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4002004 = New System.Windows.Forms.TabPage()
        Me.dgv4002004 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB4003 = New System.Windows.Forms.TabPage()
        Me.mtabWB4003 = New System.Windows.Forms.TabControl()
        Me.tab4003 = New System.Windows.Forms.TabPage()
        Me.dgv4003 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4003001 = New System.Windows.Forms.TabPage()
        Me.dgv4003001 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4003002 = New System.Windows.Forms.TabPage()
        Me.dgv4003002 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4003003 = New System.Windows.Forms.TabPage()
        Me.dgv4003003 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4003004 = New System.Windows.Forms.TabPage()
        Me.dgv4003004 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB4004 = New System.Windows.Forms.TabPage()
        Me.mtab4004 = New System.Windows.Forms.TabControl()
        Me.tab4004 = New System.Windows.Forms.TabPage()
        Me.dgv4004 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4004001 = New System.Windows.Forms.TabPage()
        Me.dgv4004001 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4004002 = New System.Windows.Forms.TabPage()
        Me.dgv4004002 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab4004003 = New System.Windows.Forms.TabPage()
        Me.dgv4004003 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB4005 = New System.Windows.Forms.TabPage()
        Me.dgv4005 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB5001 = New System.Windows.Forms.TabPage()
        Me.dgv5001 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabWB5002 = New System.Windows.Forms.TabPage()
        Me.mtabWB5002 = New System.Windows.Forms.TabControl()
        Me.tab5002 = New System.Windows.Forms.TabPage()
        Me.dgv5002 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab5002001 = New System.Windows.Forms.TabPage()
        Me.dgv5002001 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab5002002 = New System.Windows.Forms.TabPage()
        Me.dgv5002002 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab5002003 = New System.Windows.Forms.TabPage()
        Me.dgv5002003 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab5002004 = New System.Windows.Forms.TabPage()
        Me.dgv5002004 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB5003 = New System.Windows.Forms.TabPage()
        Me.mtabWB5003 = New System.Windows.Forms.TabControl()
        Me.tab5003 = New System.Windows.Forms.TabPage()
        Me.dgv5003 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab5003001 = New System.Windows.Forms.TabPage()
        Me.dgv5003001 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab5003002 = New System.Windows.Forms.TabPage()
        Me.dgv5003002 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB5004 = New System.Windows.Forms.TabPage()
        Me.dgv5004 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB5005 = New System.Windows.Forms.TabPage()
        Me.dgv5005 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB5006 = New System.Windows.Forms.TabPage()
        Me.dgv5006 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabWB5007 = New System.Windows.Forms.TabPage()
        Me.dgv5007 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabSearchResults = New System.Windows.Forms.TabPage()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.StudentsTableAdapter = New Student_Results_System.DefaultDataSetTableAdapters.StudentsTableAdapter()
        Me.tsbNewFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbFileOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbCut = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tsbPaste = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddStudent = New System.Windows.Forms.ToolStripButton()
        Me.tsbReportDesigner = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddResult = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.mtabQuick.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.mtabHome.SuspendLayout()
        Me.tabStudents.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB4001.SuspendLayout()
        CType(Me.dgv4001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB4002.SuspendLayout()
        Me.mtabWB4002.SuspendLayout()
        Me.tab4002.SuspendLayout()
        CType(Me.dgv4002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4002001.SuspendLayout()
        CType(Me.dgv4002001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4002002.SuspendLayout()
        CType(Me.dgv4002002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4002003.SuspendLayout()
        CType(Me.dgv4002003, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4002004.SuspendLayout()
        CType(Me.dgv4002004, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB4003.SuspendLayout()
        Me.mtabWB4003.SuspendLayout()
        Me.tab4003.SuspendLayout()
        CType(Me.dgv4003, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4003001.SuspendLayout()
        CType(Me.dgv4003001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4003002.SuspendLayout()
        CType(Me.dgv4003002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4003003.SuspendLayout()
        CType(Me.dgv4003003, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4003004.SuspendLayout()
        CType(Me.dgv4003004, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB4004.SuspendLayout()
        Me.mtab4004.SuspendLayout()
        Me.tab4004.SuspendLayout()
        CType(Me.dgv4004, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4004001.SuspendLayout()
        CType(Me.dgv4004001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4004002.SuspendLayout()
        CType(Me.dgv4004002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab4004003.SuspendLayout()
        CType(Me.dgv4004003, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB4005.SuspendLayout()
        CType(Me.dgv4005, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5001.SuspendLayout()
        CType(Me.dgv5001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5002.SuspendLayout()
        Me.mtabWB5002.SuspendLayout()
        Me.tab5002.SuspendLayout()
        CType(Me.dgv5002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab5002001.SuspendLayout()
        CType(Me.dgv5002001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab5002002.SuspendLayout()
        CType(Me.dgv5002002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab5002003.SuspendLayout()
        CType(Me.dgv5002003, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab5002004.SuspendLayout()
        CType(Me.dgv5002004, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5003.SuspendLayout()
        Me.mtabWB5003.SuspendLayout()
        Me.tab5003.SuspendLayout()
        CType(Me.dgv5003, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab5003001.SuspendLayout()
        CType(Me.dgv5003001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab5003002.SuspendLayout()
        CType(Me.dgv5003002, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5004.SuspendLayout()
        CType(Me.dgv5004, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5005.SuspendLayout()
        CType(Me.dgv5005, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5006.SuspendLayout()
        CType(Me.dgv5006, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWB5007.SuspendLayout()
        CType(Me.dgv5007, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearchResults.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuDatabase})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(758, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.ToolStripSeparator1, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuPrint, Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.White
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(134, 22)
        Me.mnuNew.Text = "&New..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(134, 22)
        Me.mnuOpen.Text = "&Open..."
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(134, 22)
        Me.mnuSave.Text = "&Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(134, 22)
        Me.mnuSaveAs.Text = "Save &As"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(134, 22)
        Me.mnuPrint.Text = "Print"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(134, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.mnuRedo, Me.ToolStripMenuItem1, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.ToolStripMenuItem2, Me.mnuReportDesigner})
        Me.mnuEdit.ForeColor = System.Drawing.Color.White
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(158, 22)
        Me.mnuUndo.Text = "Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.Size = New System.Drawing.Size(158, 22)
        Me.mnuRedo.Text = "Redo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(155, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 6)
        '
        'mnuReportDesigner
        '
        Me.mnuReportDesigner.Name = "mnuReportDesigner"
        Me.mnuReportDesigner.Size = New System.Drawing.Size(158, 22)
        Me.mnuReportDesigner.Text = "Report Designer"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHideToolbar, Me.mnuSidebarToggle})
        Me.mnuView.ForeColor = System.Drawing.Color.White
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        '
        'mnuHideToolbar
        '
        Me.mnuHideToolbar.Name = "mnuHideToolbar"
        Me.mnuHideToolbar.Size = New System.Drawing.Size(142, 22)
        Me.mnuHideToolbar.Text = "Hide Toolbar"
        '
        'mnuSidebarToggle
        '
        Me.mnuSidebarToggle.CheckOnClick = True
        Me.mnuSidebarToggle.Name = "mnuSidebarToggle"
        Me.mnuSidebarToggle.Size = New System.Drawing.Size(142, 22)
        Me.mnuSidebarToggle.Text = "Hide Sidebar"
        '
        'mnuDatabase
        '
        Me.mnuDatabase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddStudent, Me.mnuMassEdit})
        Me.mnuDatabase.ForeColor = System.Drawing.Color.White
        Me.mnuDatabase.Name = "mnuDatabase"
        Me.mnuDatabase.Size = New System.Drawing.Size(67, 20)
        Me.mnuDatabase.Text = "Database"
        '
        'mnuAddStudent
        '
        Me.mnuAddStudent.Name = "mnuAddStudent"
        Me.mnuAddStudent.Size = New System.Drawing.Size(149, 22)
        Me.mnuAddStudent.Text = "Add Student..."
        '
        'mnuMassEdit
        '
        Me.mnuMassEdit.Name = "mnuMassEdit"
        Me.mnuMassEdit.Size = New System.Drawing.Size(149, 22)
        Me.mnuMassEdit.Text = "Mass Edit..."
        '
        'mtabQuick
        '
        Me.mtabQuick.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtabQuick.Controls.Add(Me.tabSearch)
        Me.mtabQuick.Location = New System.Drawing.Point(0, 319)
        Me.mtabQuick.Name = "mtabQuick"
        Me.mtabQuick.SelectedIndex = 0
        Me.mtabQuick.Size = New System.Drawing.Size(151, 230)
        Me.mtabQuick.TabIndex = 2
        '
        'tabSearch
        '
        Me.tabSearch.BackColor = System.Drawing.Color.White
        Me.tabSearch.Controls.Add(Me.btnSearch)
        Me.tabSearch.Controls.Add(Me.btnAdvSearch)
        Me.tabSearch.Controls.Add(Me.txtWaterSearch)
        Me.tabSearch.Controls.Add(Me.cmbSearch)
        Me.tabSearch.Controls.Add(Me.lblSearchType)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(143, 204)
        Me.tabSearch.TabIndex = 0
        Me.tabSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(6, 78)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 26)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdvSearch
        '
        Me.btnAdvSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdvSearch.Location = New System.Drawing.Point(6, 171)
        Me.btnAdvSearch.Name = "btnAdvSearch"
        Me.btnAdvSearch.Size = New System.Drawing.Size(129, 27)
        Me.btnAdvSearch.TabIndex = 9
        Me.btnAdvSearch.Text = "Advanced Search"
        Me.btnAdvSearch.UseVisualStyleBackColor = True
        '
        'txtWaterSearch
        '
        Me.txtWaterSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWaterSearch.Location = New System.Drawing.Point(7, 50)
        Me.txtWaterSearch.Name = "txtWaterSearch"
        Me.txtWaterSearch.Size = New System.Drawing.Size(128, 22)
        Me.txtWaterSearch.TabIndex = 8
        '
        'cmbSearch
        '
        Me.cmbSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"First Name", "Last Name", "Year", "Module", "Unit"})
        Me.cmbSearch.Location = New System.Drawing.Point(6, 23)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(129, 21)
        Me.cmbSearch.TabIndex = 1
        '
        'lblSearchType
        '
        Me.lblSearchType.AutoSize = True
        Me.lblSearchType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchType.Location = New System.Drawing.Point(3, 3)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(83, 17)
        Me.lblSearchType.TabIndex = 0
        Me.lblSearchType.Text = "Search Type:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddResult)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnReport)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddStudent)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mtabQuick)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.mtabHome)
        Me.SplitContainer1.Size = New System.Drawing.Size(758, 548)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.SplitterWidth = 7
        Me.SplitContainer1.TabIndex = 3
        '
        'btnAddResult
        '
        Me.btnAddResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddResult.BackColor = System.Drawing.Color.White
        Me.btnAddResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddResult.Location = New System.Drawing.Point(4, 59)
        Me.btnAddResult.Name = "btnAddResult"
        Me.btnAddResult.Size = New System.Drawing.Size(143, 28)
        Me.btnAddResult.TabIndex = 6
        Me.btnAddResult.Text = "Add Result"
        Me.btnAddResult.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.BackColor = System.Drawing.Color.White
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Location = New System.Drawing.Point(4, 93)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(143, 28)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "Report Designer"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Recently Used:"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddStudent.BackColor = System.Drawing.Color.White
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Location = New System.Drawing.Point(4, 25)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(143, 28)
        Me.btnAddStudent.TabIndex = 3
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'mtabHome
        '
        Me.mtabHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtabHome.Controls.Add(Me.tabStudents)
        Me.mtabHome.Controls.Add(Me.tabWB4001)
        Me.mtabHome.Controls.Add(Me.tabWB4002)
        Me.mtabHome.Controls.Add(Me.tabWB4003)
        Me.mtabHome.Controls.Add(Me.tabWB4004)
        Me.mtabHome.Controls.Add(Me.tabWB4005)
        Me.mtabHome.Controls.Add(Me.tabWB5001)
        Me.mtabHome.Controls.Add(Me.tabWB5002)
        Me.mtabHome.Controls.Add(Me.tabWB5003)
        Me.mtabHome.Controls.Add(Me.tabWB5004)
        Me.mtabHome.Controls.Add(Me.tabWB5005)
        Me.mtabHome.Controls.Add(Me.tabWB5006)
        Me.mtabHome.Controls.Add(Me.tabWB5007)
        Me.mtabHome.Controls.Add(Me.tabSearchResults)
        Me.mtabHome.Location = New System.Drawing.Point(3, 0)
        Me.mtabHome.Name = "mtabHome"
        Me.mtabHome.SelectedIndex = 0
        Me.mtabHome.Size = New System.Drawing.Size(542, 548)
        Me.mtabHome.TabIndex = 1
        '
        'tabStudents
        '
        Me.tabStudents.Controls.Add(Me.dgvStudents)
        Me.tabStudents.Location = New System.Drawing.Point(4, 22)
        Me.tabStudents.Name = "tabStudents"
        Me.tabStudents.Size = New System.Drawing.Size(534, 522)
        Me.tabStudents.TabIndex = 5
        Me.tabStudents.Text = "Students"
        Me.tabStudents.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.AutoGenerateColumns = False
        Me.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SIdDataGridViewTextBoxColumn, Me.SFirstNameDataGridViewTextBoxColumn, Me.SLastNameDataGridViewTextBoxColumn, Me.SYearDataGridViewTextBoxColumn})
        Me.dgvStudents.DataSource = Me.StudentsBindingSource
        Me.dgvStudents.Location = New System.Drawing.Point(0, 0)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(579, 522)
        Me.dgvStudents.TabIndex = 0
        '
        'SIdDataGridViewTextBoxColumn
        '
        Me.SIdDataGridViewTextBoxColumn.DataPropertyName = "SId"
        Me.SIdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.SIdDataGridViewTextBoxColumn.Name = "SIdDataGridViewTextBoxColumn"
        '
        'SFirstNameDataGridViewTextBoxColumn
        '
        Me.SFirstNameDataGridViewTextBoxColumn.DataPropertyName = "SFirstName"
        Me.SFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.SFirstNameDataGridViewTextBoxColumn.Name = "SFirstNameDataGridViewTextBoxColumn"
        '
        'SLastNameDataGridViewTextBoxColumn
        '
        Me.SLastNameDataGridViewTextBoxColumn.DataPropertyName = "SLastName"
        Me.SLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.SLastNameDataGridViewTextBoxColumn.Name = "SLastNameDataGridViewTextBoxColumn"
        '
        'SYearDataGridViewTextBoxColumn
        '
        Me.SYearDataGridViewTextBoxColumn.DataPropertyName = "SYear"
        Me.SYearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.SYearDataGridViewTextBoxColumn.Name = "SYearDataGridViewTextBoxColumn"
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.DefaultDataSet2
        '
        'DefaultDataSet2
        '
        Me.DefaultDataSet2.DataSetName = "DefaultDataSet"
        Me.DefaultDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabWB4001
        '
        Me.tabWB4001.Controls.Add(Me.dgv4001)
        Me.tabWB4001.Location = New System.Drawing.Point(4, 22)
        Me.tabWB4001.Name = "tabWB4001"
        Me.tabWB4001.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWB4001.Size = New System.Drawing.Size(534, 522)
        Me.tabWB4001.TabIndex = 1
        Me.tabWB4001.Text = "WB4001"
        Me.tabWB4001.UseVisualStyleBackColor = True
        '
        'dgv4001
        '
        Me.dgv4001.AllowUserToAddRows = False
        Me.dgv4001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv4001FirstName, Me.dgv4001LastName, Me.dgv4001ModulePass})
        Me.dgv4001.Location = New System.Drawing.Point(0, 0)
        Me.dgv4001.Name = "dgv4001"
        Me.dgv4001.Size = New System.Drawing.Size(579, 522)
        Me.dgv4001.TabIndex = 0
        '
        'dgv4001FirstName
        '
        Me.dgv4001FirstName.DataPropertyName = "SFirstName"
        Me.dgv4001FirstName.HeaderText = "First Name"
        Me.dgv4001FirstName.Name = "dgv4001FirstName"
        '
        'dgv4001LastName
        '
        Me.dgv4001LastName.DataPropertyName = "SLastName"
        Me.dgv4001LastName.HeaderText = "Last Name"
        Me.dgv4001LastName.Name = "dgv4001LastName"
        '
        'dgv4001ModulePass
        '
        Me.dgv4001ModulePass.DataPropertyName = "ModulePass"
        Me.dgv4001ModulePass.HeaderText = "Module Pass"
        Me.dgv4001ModulePass.MinimumWidth = 10
        Me.dgv4001ModulePass.Name = "dgv4001ModulePass"
        Me.dgv4001ModulePass.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv4001ModulePass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgv4001ModulePass.Width = 110
        '
        'tabWB4002
        '
        Me.tabWB4002.Controls.Add(Me.mtabWB4002)
        Me.tabWB4002.Location = New System.Drawing.Point(4, 22)
        Me.tabWB4002.Name = "tabWB4002"
        Me.tabWB4002.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWB4002.Size = New System.Drawing.Size(534, 522)
        Me.tabWB4002.TabIndex = 0
        Me.tabWB4002.Text = "WB4002"
        Me.tabWB4002.UseVisualStyleBackColor = True
        '
        'mtabWB4002
        '
        Me.mtabWB4002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtabWB4002.Controls.Add(Me.tab4002)
        Me.mtabWB4002.Controls.Add(Me.tab4002001)
        Me.mtabWB4002.Controls.Add(Me.tab4002002)
        Me.mtabWB4002.Controls.Add(Me.tab4002003)
        Me.mtabWB4002.Controls.Add(Me.tab4002004)
        Me.mtabWB4002.Location = New System.Drawing.Point(-4, 0)
        Me.mtabWB4002.Name = "mtabWB4002"
        Me.mtabWB4002.SelectedIndex = 0
        Me.mtabWB4002.Size = New System.Drawing.Size(548, 526)
        Me.mtabWB4002.TabIndex = 1
        '
        'tab4002
        '
        Me.tab4002.Controls.Add(Me.dgv4002)
        Me.tab4002.Location = New System.Drawing.Point(4, 22)
        Me.tab4002.Name = "tab4002"
        Me.tab4002.Size = New System.Drawing.Size(540, 500)
        Me.tab4002.TabIndex = 4
        Me.tab4002.Text = "Module"
        Me.tab4002.UseVisualStyleBackColor = True
        '
        'dgv4002
        '
        Me.dgv4002.AllowUserToAddRows = False
        Me.dgv4002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv4002FirstName, Me.dgv4002LastName, Me.dgv4002ModuleResult})
        Me.dgv4002.Location = New System.Drawing.Point(0, 0)
        Me.dgv4002.Name = "dgv4002"
        Me.dgv4002.Size = New System.Drawing.Size(540, 500)
        Me.dgv4002.TabIndex = 1
        '
        'dgv4002FirstName
        '
        Me.dgv4002FirstName.DataPropertyName = "SFirstName"
        Me.dgv4002FirstName.HeaderText = "FirstName"
        Me.dgv4002FirstName.Name = "dgv4002FirstName"
        '
        'dgv4002LastName
        '
        Me.dgv4002LastName.DataPropertyName = "SLastName"
        Me.dgv4002LastName.HeaderText = "Last Name"
        Me.dgv4002LastName.Name = "dgv4002LastName"
        '
        'dgv4002ModuleResult
        '
        Me.dgv4002ModuleResult.DataPropertyName = "ModuleResult"
        Me.dgv4002ModuleResult.HeaderText = "Module Result"
        Me.dgv4002ModuleResult.Name = "dgv4002ModuleResult"
        Me.dgv4002ModuleResult.Width = 110
        '
        'tab4002001
        '
        Me.tab4002001.Controls.Add(Me.dgv4002001)
        Me.tab4002001.Location = New System.Drawing.Point(4, 22)
        Me.tab4002001.Name = "tab4002001"
        Me.tab4002001.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4002001.Size = New System.Drawing.Size(540, 500)
        Me.tab4002001.TabIndex = 0
        Me.tab4002001.Text = "001"
        Me.tab4002001.UseVisualStyleBackColor = True
        '
        'dgv4002001
        '
        Me.dgv4002001.AllowUserToAddRows = False
        Me.dgv4002001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4002001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4002001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4002001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgv4002001.Location = New System.Drawing.Point(0, 0)
        Me.dgv4002001.Name = "dgv4002001"
        Me.dgv4002001.Size = New System.Drawing.Size(540, 500)
        Me.dgv4002001.TabIndex = 2
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'tab4002002
        '
        Me.tab4002002.Controls.Add(Me.dgv4002002)
        Me.tab4002002.Location = New System.Drawing.Point(4, 22)
        Me.tab4002002.Name = "tab4002002"
        Me.tab4002002.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4002002.Size = New System.Drawing.Size(540, 500)
        Me.tab4002002.TabIndex = 1
        Me.tab4002002.Text = "002"
        Me.tab4002002.UseVisualStyleBackColor = True
        '
        'dgv4002002
        '
        Me.dgv4002002.AllowUserToAddRows = False
        Me.dgv4002002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4002002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4002002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4002002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgv4002002.Location = New System.Drawing.Point(0, 0)
        Me.dgv4002002.Name = "dgv4002002"
        Me.dgv4002002.Size = New System.Drawing.Size(540, 500)
        Me.dgv4002002.TabIndex = 3
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 110
        '
        'tab4002003
        '
        Me.tab4002003.Controls.Add(Me.dgv4002003)
        Me.tab4002003.Location = New System.Drawing.Point(4, 22)
        Me.tab4002003.Name = "tab4002003"
        Me.tab4002003.Size = New System.Drawing.Size(540, 500)
        Me.tab4002003.TabIndex = 2
        Me.tab4002003.Text = "003"
        Me.tab4002003.UseVisualStyleBackColor = True
        '
        'dgv4002003
        '
        Me.dgv4002003.AllowUserToAddRows = False
        Me.dgv4002003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4002003.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4002003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4002003.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgv4002003.Location = New System.Drawing.Point(0, 0)
        Me.dgv4002003.Name = "dgv4002003"
        Me.dgv4002003.Size = New System.Drawing.Size(540, 500)
        Me.dgv4002003.TabIndex = 4
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 110
        '
        'tab4002004
        '
        Me.tab4002004.Controls.Add(Me.dgv4002004)
        Me.tab4002004.Location = New System.Drawing.Point(4, 22)
        Me.tab4002004.Name = "tab4002004"
        Me.tab4002004.Size = New System.Drawing.Size(540, 500)
        Me.tab4002004.TabIndex = 3
        Me.tab4002004.Text = "004"
        Me.tab4002004.UseVisualStyleBackColor = True
        '
        'dgv4002004
        '
        Me.dgv4002004.AllowUserToAddRows = False
        Me.dgv4002004.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4002004.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4002004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4002004.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.dgv4002004.Location = New System.Drawing.Point(0, 0)
        Me.dgv4002004.Name = "dgv4002004"
        Me.dgv4002004.Size = New System.Drawing.Size(540, 500)
        Me.dgv4002004.TabIndex = 5
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 110
        '
        'tabWB4003
        '
        Me.tabWB4003.Controls.Add(Me.mtabWB4003)
        Me.tabWB4003.Location = New System.Drawing.Point(4, 22)
        Me.tabWB4003.Name = "tabWB4003"
        Me.tabWB4003.Size = New System.Drawing.Size(534, 522)
        Me.tabWB4003.TabIndex = 2
        Me.tabWB4003.Text = "WB4003"
        Me.tabWB4003.UseVisualStyleBackColor = True
        '
        'mtabWB4003
        '
        Me.mtabWB4003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtabWB4003.Controls.Add(Me.tab4003)
        Me.mtabWB4003.Controls.Add(Me.tab4003001)
        Me.mtabWB4003.Controls.Add(Me.tab4003002)
        Me.mtabWB4003.Controls.Add(Me.tab4003003)
        Me.mtabWB4003.Controls.Add(Me.tab4003004)
        Me.mtabWB4003.Location = New System.Drawing.Point(-4, 0)
        Me.mtabWB4003.Name = "mtabWB4003"
        Me.mtabWB4003.SelectedIndex = 0
        Me.mtabWB4003.Size = New System.Drawing.Size(587, 526)
        Me.mtabWB4003.TabIndex = 2
        '
        'tab4003
        '
        Me.tab4003.Controls.Add(Me.dgv4003)
        Me.tab4003.Location = New System.Drawing.Point(4, 22)
        Me.tab4003.Name = "tab4003"
        Me.tab4003.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4003.Size = New System.Drawing.Size(579, 500)
        Me.tab4003.TabIndex = 4
        Me.tab4003.Text = "Module"
        Me.tab4003.UseVisualStyleBackColor = True
        '
        'dgv4003
        '
        Me.dgv4003.AllowUserToAddRows = False
        Me.dgv4003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4003.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4003.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.dgv4003.Location = New System.Drawing.Point(0, 0)
        Me.dgv4003.Name = "dgv4003"
        Me.dgv4003.Size = New System.Drawing.Size(579, 500)
        Me.dgv4003.TabIndex = 2
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 110
        '
        'tab4003001
        '
        Me.tab4003001.Controls.Add(Me.dgv4003001)
        Me.tab4003001.Location = New System.Drawing.Point(4, 22)
        Me.tab4003001.Name = "tab4003001"
        Me.tab4003001.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4003001.Size = New System.Drawing.Size(579, 500)
        Me.tab4003001.TabIndex = 0
        Me.tab4003001.Text = "001"
        Me.tab4003001.UseVisualStyleBackColor = True
        '
        'dgv4003001
        '
        Me.dgv4003001.AllowUserToAddRows = False
        Me.dgv4003001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4003001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4003001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4003001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.dgv4003001.Location = New System.Drawing.Point(0, 0)
        Me.dgv4003001.Name = "dgv4003001"
        Me.dgv4003001.Size = New System.Drawing.Size(579, 500)
        Me.dgv4003001.TabIndex = 3
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 110
        '
        'tab4003002
        '
        Me.tab4003002.Controls.Add(Me.dgv4003002)
        Me.tab4003002.Location = New System.Drawing.Point(4, 22)
        Me.tab4003002.Name = "tab4003002"
        Me.tab4003002.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4003002.Size = New System.Drawing.Size(579, 500)
        Me.tab4003002.TabIndex = 1
        Me.tab4003002.Text = "002"
        Me.tab4003002.UseVisualStyleBackColor = True
        '
        'dgv4003002
        '
        Me.dgv4003002.AllowUserToAddRows = False
        Me.dgv4003002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4003002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4003002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4003002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.dgv4003002.Location = New System.Drawing.Point(0, 0)
        Me.dgv4003002.Name = "dgv4003002"
        Me.dgv4003002.Size = New System.Drawing.Size(579, 500)
        Me.dgv4003002.TabIndex = 3
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn22.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 110
        '
        'tab4003003
        '
        Me.tab4003003.Controls.Add(Me.dgv4003003)
        Me.tab4003003.Location = New System.Drawing.Point(4, 22)
        Me.tab4003003.Name = "tab4003003"
        Me.tab4003003.Size = New System.Drawing.Size(579, 500)
        Me.tab4003003.TabIndex = 2
        Me.tab4003003.Text = "003"
        Me.tab4003003.UseVisualStyleBackColor = True
        '
        'dgv4003003
        '
        Me.dgv4003003.AllowUserToAddRows = False
        Me.dgv4003003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4003003.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4003003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4003003.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.dgv4003003.Location = New System.Drawing.Point(0, 0)
        Me.dgv4003003.Name = "dgv4003003"
        Me.dgv4003003.Size = New System.Drawing.Size(579, 500)
        Me.dgv4003003.TabIndex = 3
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn25.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 110
        '
        'tab4003004
        '
        Me.tab4003004.Controls.Add(Me.dgv4003004)
        Me.tab4003004.Location = New System.Drawing.Point(4, 22)
        Me.tab4003004.Name = "tab4003004"
        Me.tab4003004.Size = New System.Drawing.Size(579, 500)
        Me.tab4003004.TabIndex = 3
        Me.tab4003004.Text = "004"
        Me.tab4003004.UseVisualStyleBackColor = True
        '
        'dgv4003004
        '
        Me.dgv4003004.AllowUserToAddRows = False
        Me.dgv4003004.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4003004.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4003004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4003004.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.dgv4003004.Location = New System.Drawing.Point(0, 0)
        Me.dgv4003004.Name = "dgv4003004"
        Me.dgv4003004.Size = New System.Drawing.Size(579, 500)
        Me.dgv4003004.TabIndex = 3
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn28.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 110
        '
        'tabWB4004
        '
        Me.tabWB4004.Controls.Add(Me.mtab4004)
        Me.tabWB4004.Location = New System.Drawing.Point(4, 22)
        Me.tabWB4004.Name = "tabWB4004"
        Me.tabWB4004.Size = New System.Drawing.Size(534, 522)
        Me.tabWB4004.TabIndex = 3
        Me.tabWB4004.Text = "WB4004"
        Me.tabWB4004.UseVisualStyleBackColor = True
        '
        'mtab4004
        '
        Me.mtab4004.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtab4004.Controls.Add(Me.tab4004)
        Me.mtab4004.Controls.Add(Me.tab4004001)
        Me.mtab4004.Controls.Add(Me.tab4004002)
        Me.mtab4004.Controls.Add(Me.tab4004003)
        Me.mtab4004.Location = New System.Drawing.Point(-4, 0)
        Me.mtab4004.Name = "mtab4004"
        Me.mtab4004.SelectedIndex = 0
        Me.mtab4004.Size = New System.Drawing.Size(587, 526)
        Me.mtab4004.TabIndex = 3
        '
        'tab4004
        '
        Me.tab4004.Controls.Add(Me.dgv4004)
        Me.tab4004.Location = New System.Drawing.Point(4, 22)
        Me.tab4004.Name = "tab4004"
        Me.tab4004.Size = New System.Drawing.Size(579, 500)
        Me.tab4004.TabIndex = 3
        Me.tab4004.Text = "Module"
        Me.tab4004.UseVisualStyleBackColor = True
        '
        'dgv4004
        '
        Me.dgv4004.AllowUserToAddRows = False
        Me.dgv4004.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4004.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4004.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42})
        Me.dgv4004.Location = New System.Drawing.Point(0, 0)
        Me.dgv4004.Name = "dgv4004"
        Me.dgv4004.Size = New System.Drawing.Size(579, 500)
        Me.dgv4004.TabIndex = 3
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn40.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 110
        '
        'tab4004001
        '
        Me.tab4004001.Controls.Add(Me.dgv4004001)
        Me.tab4004001.Location = New System.Drawing.Point(4, 22)
        Me.tab4004001.Name = "tab4004001"
        Me.tab4004001.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4004001.Size = New System.Drawing.Size(579, 500)
        Me.tab4004001.TabIndex = 0
        Me.tab4004001.Text = "001"
        Me.tab4004001.UseVisualStyleBackColor = True
        '
        'dgv4004001
        '
        Me.dgv4004001.AllowUserToAddRows = False
        Me.dgv4004001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4004001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4004001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4004001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.dgv4004001.Location = New System.Drawing.Point(0, 0)
        Me.dgv4004001.Name = "dgv4004001"
        Me.dgv4004001.Size = New System.Drawing.Size(579, 500)
        Me.dgv4004001.TabIndex = 4
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn31.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 110
        '
        'tab4004002
        '
        Me.tab4004002.Controls.Add(Me.dgv4004002)
        Me.tab4004002.Location = New System.Drawing.Point(4, 22)
        Me.tab4004002.Name = "tab4004002"
        Me.tab4004002.Padding = New System.Windows.Forms.Padding(3)
        Me.tab4004002.Size = New System.Drawing.Size(579, 500)
        Me.tab4004002.TabIndex = 1
        Me.tab4004002.Text = "002"
        Me.tab4004002.UseVisualStyleBackColor = True
        '
        'dgv4004002
        '
        Me.dgv4004002.AllowUserToAddRows = False
        Me.dgv4004002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4004002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4004002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4004002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36})
        Me.dgv4004002.Location = New System.Drawing.Point(0, 0)
        Me.dgv4004002.Name = "dgv4004002"
        Me.dgv4004002.Size = New System.Drawing.Size(579, 500)
        Me.dgv4004002.TabIndex = 5
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn34.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 110
        '
        'tab4004003
        '
        Me.tab4004003.Controls.Add(Me.dgv4004003)
        Me.tab4004003.Location = New System.Drawing.Point(4, 22)
        Me.tab4004003.Name = "tab4004003"
        Me.tab4004003.Size = New System.Drawing.Size(579, 500)
        Me.tab4004003.TabIndex = 2
        Me.tab4004003.Text = "003"
        Me.tab4004003.UseVisualStyleBackColor = True
        '
        'dgv4004003
        '
        Me.dgv4004003.AllowUserToAddRows = False
        Me.dgv4004003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4004003.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4004003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4004003.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39})
        Me.dgv4004003.Location = New System.Drawing.Point(0, 0)
        Me.dgv4004003.Name = "dgv4004003"
        Me.dgv4004003.Size = New System.Drawing.Size(579, 500)
        Me.dgv4004003.TabIndex = 6
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn37.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 110
        '
        'tabWB4005
        '
        Me.tabWB4005.Controls.Add(Me.dgv4005)
        Me.tabWB4005.Location = New System.Drawing.Point(4, 22)
        Me.tabWB4005.Name = "tabWB4005"
        Me.tabWB4005.Size = New System.Drawing.Size(534, 522)
        Me.tabWB4005.TabIndex = 4
        Me.tabWB4005.Text = "WB4005"
        Me.tabWB4005.UseVisualStyleBackColor = True
        '
        'dgv4005
        '
        Me.dgv4005.AllowUserToAddRows = False
        Me.dgv4005.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv4005.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv4005.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv4005.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45})
        Me.dgv4005.Location = New System.Drawing.Point(0, 0)
        Me.dgv4005.Name = "dgv4005"
        Me.dgv4005.Size = New System.Drawing.Size(540, 522)
        Me.dgv4005.TabIndex = 4
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn43.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 110
        '
        'tabWB5001
        '
        Me.tabWB5001.Controls.Add(Me.dgv5001)
        Me.tabWB5001.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5001.Name = "tabWB5001"
        Me.tabWB5001.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5001.TabIndex = 8
        Me.tabWB5001.Text = "WB5001"
        Me.tabWB5001.UseVisualStyleBackColor = True
        '
        'dgv5001
        '
        Me.dgv5001.AllowUserToAddRows = False
        Me.dgv5001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewCheckBoxColumn1})
        Me.dgv5001.Location = New System.Drawing.Point(0, 0)
        Me.dgv5001.Name = "dgv5001"
        Me.dgv5001.Size = New System.Drawing.Size(540, 522)
        Me.dgv5001.TabIndex = 1
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn46.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "ModulePass"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Module Pass"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 10
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 110
        '
        'tabWB5002
        '
        Me.tabWB5002.Controls.Add(Me.mtabWB5002)
        Me.tabWB5002.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5002.Name = "tabWB5002"
        Me.tabWB5002.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5002.TabIndex = 9
        Me.tabWB5002.Text = "WB5002"
        Me.tabWB5002.UseVisualStyleBackColor = True
        '
        'mtabWB5002
        '
        Me.mtabWB5002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtabWB5002.Controls.Add(Me.tab5002)
        Me.mtabWB5002.Controls.Add(Me.tab5002001)
        Me.mtabWB5002.Controls.Add(Me.tab5002002)
        Me.mtabWB5002.Controls.Add(Me.tab5002003)
        Me.mtabWB5002.Controls.Add(Me.tab5002004)
        Me.mtabWB5002.Location = New System.Drawing.Point(-4, 0)
        Me.mtabWB5002.Name = "mtabWB5002"
        Me.mtabWB5002.SelectedIndex = 0
        Me.mtabWB5002.Size = New System.Drawing.Size(548, 524)
        Me.mtabWB5002.TabIndex = 2
        '
        'tab5002
        '
        Me.tab5002.Controls.Add(Me.dgv5002)
        Me.tab5002.Location = New System.Drawing.Point(4, 22)
        Me.tab5002.Name = "tab5002"
        Me.tab5002.Size = New System.Drawing.Size(540, 498)
        Me.tab5002.TabIndex = 4
        Me.tab5002.Text = "Module"
        Me.tab5002.UseVisualStyleBackColor = True
        '
        'dgv5002
        '
        Me.dgv5002.AllowUserToAddRows = False
        Me.dgv5002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50})
        Me.dgv5002.Location = New System.Drawing.Point(0, 0)
        Me.dgv5002.Name = "dgv5002"
        Me.dgv5002.Size = New System.Drawing.Size(540, 498)
        Me.dgv5002.TabIndex = 1
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn48.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 110
        '
        'tab5002001
        '
        Me.tab5002001.Controls.Add(Me.dgv5002001)
        Me.tab5002001.Location = New System.Drawing.Point(4, 22)
        Me.tab5002001.Name = "tab5002001"
        Me.tab5002001.Padding = New System.Windows.Forms.Padding(3)
        Me.tab5002001.Size = New System.Drawing.Size(540, 498)
        Me.tab5002001.TabIndex = 0
        Me.tab5002001.Text = "001"
        Me.tab5002001.UseVisualStyleBackColor = True
        '
        'dgv5002001
        '
        Me.dgv5002001.AllowUserToAddRows = False
        Me.dgv5002001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5002001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5002001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5002001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53})
        Me.dgv5002001.Location = New System.Drawing.Point(0, 0)
        Me.dgv5002001.Name = "dgv5002001"
        Me.dgv5002001.Size = New System.Drawing.Size(540, 498)
        Me.dgv5002001.TabIndex = 2
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn51.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 110
        '
        'tab5002002
        '
        Me.tab5002002.Controls.Add(Me.dgv5002002)
        Me.tab5002002.Location = New System.Drawing.Point(4, 22)
        Me.tab5002002.Name = "tab5002002"
        Me.tab5002002.Padding = New System.Windows.Forms.Padding(3)
        Me.tab5002002.Size = New System.Drawing.Size(540, 498)
        Me.tab5002002.TabIndex = 1
        Me.tab5002002.Text = "002"
        Me.tab5002002.UseVisualStyleBackColor = True
        '
        'dgv5002002
        '
        Me.dgv5002002.AllowUserToAddRows = False
        Me.dgv5002002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5002002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5002002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5002002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56})
        Me.dgv5002002.Location = New System.Drawing.Point(0, 0)
        Me.dgv5002002.Name = "dgv5002002"
        Me.dgv5002002.Size = New System.Drawing.Size(540, 498)
        Me.dgv5002002.TabIndex = 3
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn54.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 110
        '
        'tab5002003
        '
        Me.tab5002003.Controls.Add(Me.dgv5002003)
        Me.tab5002003.Location = New System.Drawing.Point(4, 22)
        Me.tab5002003.Name = "tab5002003"
        Me.tab5002003.Size = New System.Drawing.Size(540, 498)
        Me.tab5002003.TabIndex = 2
        Me.tab5002003.Text = "003"
        Me.tab5002003.UseVisualStyleBackColor = True
        '
        'dgv5002003
        '
        Me.dgv5002003.AllowUserToAddRows = False
        Me.dgv5002003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5002003.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5002003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5002003.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59})
        Me.dgv5002003.Location = New System.Drawing.Point(0, 0)
        Me.dgv5002003.Name = "dgv5002003"
        Me.dgv5002003.Size = New System.Drawing.Size(540, 498)
        Me.dgv5002003.TabIndex = 4
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn57.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.Width = 110
        '
        'tab5002004
        '
        Me.tab5002004.Controls.Add(Me.dgv5002004)
        Me.tab5002004.Location = New System.Drawing.Point(4, 22)
        Me.tab5002004.Name = "tab5002004"
        Me.tab5002004.Size = New System.Drawing.Size(540, 498)
        Me.tab5002004.TabIndex = 3
        Me.tab5002004.Text = "004"
        Me.tab5002004.UseVisualStyleBackColor = True
        '
        'dgv5002004
        '
        Me.dgv5002004.AllowUserToAddRows = False
        Me.dgv5002004.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5002004.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5002004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5002004.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62})
        Me.dgv5002004.Location = New System.Drawing.Point(0, 0)
        Me.dgv5002004.Name = "dgv5002004"
        Me.dgv5002004.Size = New System.Drawing.Size(540, 498)
        Me.dgv5002004.TabIndex = 5
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn60.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.Width = 110
        '
        'tabWB5003
        '
        Me.tabWB5003.Controls.Add(Me.mtabWB5003)
        Me.tabWB5003.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5003.Name = "tabWB5003"
        Me.tabWB5003.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5003.TabIndex = 10
        Me.tabWB5003.Text = "WB5003"
        Me.tabWB5003.UseVisualStyleBackColor = True
        '
        'mtabWB5003
        '
        Me.mtabWB5003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtabWB5003.Controls.Add(Me.tab5003)
        Me.mtabWB5003.Controls.Add(Me.tab5003001)
        Me.mtabWB5003.Controls.Add(Me.tab5003002)
        Me.mtabWB5003.Location = New System.Drawing.Point(-4, 0)
        Me.mtabWB5003.Name = "mtabWB5003"
        Me.mtabWB5003.SelectedIndex = 0
        Me.mtabWB5003.Size = New System.Drawing.Size(548, 523)
        Me.mtabWB5003.TabIndex = 3
        '
        'tab5003
        '
        Me.tab5003.Controls.Add(Me.dgv5003)
        Me.tab5003.Location = New System.Drawing.Point(4, 22)
        Me.tab5003.Name = "tab5003"
        Me.tab5003.Size = New System.Drawing.Size(540, 497)
        Me.tab5003.TabIndex = 4
        Me.tab5003.Text = "Module"
        Me.tab5003.UseVisualStyleBackColor = True
        '
        'dgv5003
        '
        Me.dgv5003.AllowUserToAddRows = False
        Me.dgv5003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5003.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5003.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5003.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65})
        Me.dgv5003.Location = New System.Drawing.Point(0, 0)
        Me.dgv5003.Name = "dgv5003"
        Me.dgv5003.Size = New System.Drawing.Size(540, 497)
        Me.dgv5003.TabIndex = 1
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn63.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.Width = 110
        '
        'tab5003001
        '
        Me.tab5003001.Controls.Add(Me.dgv5003001)
        Me.tab5003001.Location = New System.Drawing.Point(4, 22)
        Me.tab5003001.Name = "tab5003001"
        Me.tab5003001.Padding = New System.Windows.Forms.Padding(3)
        Me.tab5003001.Size = New System.Drawing.Size(540, 497)
        Me.tab5003001.TabIndex = 0
        Me.tab5003001.Text = "001"
        Me.tab5003001.UseVisualStyleBackColor = True
        '
        'dgv5003001
        '
        Me.dgv5003001.AllowUserToAddRows = False
        Me.dgv5003001.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5003001.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5003001.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5003001.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68})
        Me.dgv5003001.Location = New System.Drawing.Point(0, 0)
        Me.dgv5003001.Name = "dgv5003001"
        Me.dgv5003001.Size = New System.Drawing.Size(540, 497)
        Me.dgv5003001.TabIndex = 2
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn66.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.Width = 110
        '
        'tab5003002
        '
        Me.tab5003002.Controls.Add(Me.dgv5003002)
        Me.tab5003002.Location = New System.Drawing.Point(4, 22)
        Me.tab5003002.Name = "tab5003002"
        Me.tab5003002.Padding = New System.Windows.Forms.Padding(3)
        Me.tab5003002.Size = New System.Drawing.Size(540, 497)
        Me.tab5003002.TabIndex = 1
        Me.tab5003002.Text = "002"
        Me.tab5003002.UseVisualStyleBackColor = True
        '
        'dgv5003002
        '
        Me.dgv5003002.AllowUserToAddRows = False
        Me.dgv5003002.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5003002.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5003002.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5003002.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71})
        Me.dgv5003002.Location = New System.Drawing.Point(0, 0)
        Me.dgv5003002.Name = "dgv5003002"
        Me.dgv5003002.Size = New System.Drawing.Size(540, 497)
        Me.dgv5003002.TabIndex = 3
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn69.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "UnitResult"
        Me.DataGridViewTextBoxColumn71.HeaderText = "Unit Result"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.Width = 110
        '
        'tabWB5004
        '
        Me.tabWB5004.Controls.Add(Me.dgv5004)
        Me.tabWB5004.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5004.Name = "tabWB5004"
        Me.tabWB5004.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5004.TabIndex = 11
        Me.tabWB5004.Text = "WB5004"
        Me.tabWB5004.UseVisualStyleBackColor = True
        '
        'dgv5004
        '
        Me.dgv5004.AllowUserToAddRows = False
        Me.dgv5004.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5004.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5004.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5004.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74})
        Me.dgv5004.Location = New System.Drawing.Point(0, 0)
        Me.dgv5004.Name = "dgv5004"
        Me.dgv5004.Size = New System.Drawing.Size(540, 522)
        Me.dgv5004.TabIndex = 5
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn72.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn73.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn74.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        Me.DataGridViewTextBoxColumn74.Width = 110
        '
        'tabWB5005
        '
        Me.tabWB5005.Controls.Add(Me.dgv5005)
        Me.tabWB5005.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5005.Name = "tabWB5005"
        Me.tabWB5005.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5005.TabIndex = 12
        Me.tabWB5005.Text = "WB5005"
        Me.tabWB5005.UseVisualStyleBackColor = True
        '
        'dgv5005
        '
        Me.dgv5005.AllowUserToAddRows = False
        Me.dgv5005.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5005.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5005.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5005.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn77})
        Me.dgv5005.Location = New System.Drawing.Point(0, 0)
        Me.dgv5005.Name = "dgv5005"
        Me.dgv5005.Size = New System.Drawing.Size(540, 522)
        Me.dgv5005.TabIndex = 5
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn75.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn76.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn77.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        Me.DataGridViewTextBoxColumn77.Width = 110
        '
        'tabWB5006
        '
        Me.tabWB5006.Controls.Add(Me.dgv5006)
        Me.tabWB5006.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5006.Name = "tabWB5006"
        Me.tabWB5006.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5006.TabIndex = 13
        Me.tabWB5006.Text = "WB5006"
        Me.tabWB5006.UseVisualStyleBackColor = True
        '
        'dgv5006
        '
        Me.dgv5006.AllowUserToAddRows = False
        Me.dgv5006.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5006.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5006.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5006.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79, Me.DataGridViewTextBoxColumn80})
        Me.dgv5006.Location = New System.Drawing.Point(0, 0)
        Me.dgv5006.Name = "dgv5006"
        Me.dgv5006.Size = New System.Drawing.Size(540, 522)
        Me.dgv5006.TabIndex = 6
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn78.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn79.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn80.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        Me.DataGridViewTextBoxColumn80.Width = 110
        '
        'tabWB5007
        '
        Me.tabWB5007.Controls.Add(Me.dgv5007)
        Me.tabWB5007.Location = New System.Drawing.Point(4, 22)
        Me.tabWB5007.Name = "tabWB5007"
        Me.tabWB5007.Size = New System.Drawing.Size(534, 522)
        Me.tabWB5007.TabIndex = 14
        Me.tabWB5007.Text = "WB5007"
        Me.tabWB5007.UseVisualStyleBackColor = True
        '
        'dgv5007
        '
        Me.dgv5007.AllowUserToAddRows = False
        Me.dgv5007.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5007.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv5007.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5007.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn81, Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn83})
        Me.dgv5007.Location = New System.Drawing.Point(0, 0)
        Me.dgv5007.Name = "dgv5007"
        Me.dgv5007.Size = New System.Drawing.Size(540, 522)
        Me.dgv5007.TabIndex = 6
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "SFirstName"
        Me.DataGridViewTextBoxColumn81.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "SLastName"
        Me.DataGridViewTextBoxColumn82.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.DataPropertyName = "ModuleResult"
        Me.DataGridViewTextBoxColumn83.HeaderText = "Module Result"
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        Me.DataGridViewTextBoxColumn83.Width = 110
        '
        'tabSearchResults
        '
        Me.tabSearchResults.Controls.Add(Me.dgvSearch)
        Me.tabSearchResults.Location = New System.Drawing.Point(4, 22)
        Me.tabSearchResults.Name = "tabSearchResults"
        Me.tabSearchResults.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearchResults.Size = New System.Drawing.Size(534, 522)
        Me.tabSearchResults.TabIndex = 7
        Me.tabSearchResults.Text = "Search Reults"
        Me.tabSearchResults.UseVisualStyleBackColor = True
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(579, 522)
        Me.dgvSearch.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNewFile, Me.tsbFileOpen, Me.tsbSave, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.ToolStripSeparator6, Me.tsbAddStudent, Me.tsbReportDesigner, Me.tsbAddResult})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(758, 27)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWelcome.Location = New System.Drawing.Point(372, 24)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(63, 15)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Welcome "
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'tsbNewFile
        '
        Me.tsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNewFile.Image = Global.Student_Results_System.My.Resources.Resources.file
        Me.tsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNewFile.Name = "tsbNewFile"
        Me.tsbNewFile.Size = New System.Drawing.Size(24, 24)
        Me.tsbNewFile.Text = "ToolStripButton1"
        Me.tsbNewFile.ToolTipText = "New File"
        '
        'tsbFileOpen
        '
        Me.tsbFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFileOpen.Image = Global.Student_Results_System.My.Resources.Resources.folder
        Me.tsbFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFileOpen.Name = "tsbFileOpen"
        Me.tsbFileOpen.Size = New System.Drawing.Size(24, 24)
        Me.tsbFileOpen.Text = "ToolStripButton1"
        Me.tsbFileOpen.ToolTipText = "Open File"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = Global.Student_Results_System.My.Resources.Resources.save
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(24, 24)
        Me.tsbSave.Text = "ToolStripButton1"
        Me.tsbSave.ToolTipText = "Save"
        '
        'tsbCut
        '
        Me.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCut.Image = Global.Student_Results_System.My.Resources.Resources.cut
        Me.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCut.Name = "tsbCut"
        Me.tsbCut.Size = New System.Drawing.Size(24, 24)
        Me.tsbCut.Text = "ToolStripButton2"
        Me.tsbCut.ToolTipText = "Cut"
        '
        'tsbCopy
        '
        Me.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopy.Image = Global.Student_Results_System.My.Resources.Resources.copy
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.Size = New System.Drawing.Size(24, 24)
        Me.tsbCopy.Text = "ToolStripButton3"
        Me.tsbCopy.ToolTipText = "Copy"
        '
        'tsbPaste
        '
        Me.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPaste.Image = Global.Student_Results_System.My.Resources.Resources.paste
        Me.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPaste.Name = "tsbPaste"
        Me.tsbPaste.Size = New System.Drawing.Size(24, 24)
        Me.tsbPaste.Text = "ToolStripButton4"
        Me.tsbPaste.ToolTipText = "Paste"
        '
        'tsbAddStudent
        '
        Me.tsbAddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddStudent.Image = Global.Student_Results_System.My.Resources.Resources.add_student
        Me.tsbAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddStudent.Name = "tsbAddStudent"
        Me.tsbAddStudent.Size = New System.Drawing.Size(24, 24)
        Me.tsbAddStudent.Text = "Add Student"
        Me.tsbAddStudent.ToolTipText = "Add Student"
        '
        'tsbReportDesigner
        '
        Me.tsbReportDesigner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReportDesigner.Image = Global.Student_Results_System.My.Resources.Resources.printpreview
        Me.tsbReportDesigner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReportDesigner.Name = "tsbReportDesigner"
        Me.tsbReportDesigner.Size = New System.Drawing.Size(24, 24)
        Me.tsbReportDesigner.Text = "Report Designer"
        '
        'tsbAddResult
        '
        Me.tsbAddResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddResult.Image = Global.Student_Results_System.My.Resources.Resources.plus_box
        Me.tsbAddResult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddResult.Name = "tsbAddResult"
        Me.tsbAddResult.Size = New System.Drawing.Size(24, 24)
        Me.tsbAddResult.Text = "Add Result"
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(758, 601)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainScreen"
        Me.Text = "TINE Beta 6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mtabQuick.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.tabSearch.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.mtabHome.ResumeLayout(False)
        Me.tabStudents.ResumeLayout(False)
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB4001.ResumeLayout(False)
        CType(Me.dgv4001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB4002.ResumeLayout(False)
        Me.mtabWB4002.ResumeLayout(False)
        Me.tab4002.ResumeLayout(False)
        CType(Me.dgv4002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4002001.ResumeLayout(False)
        CType(Me.dgv4002001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4002002.ResumeLayout(False)
        CType(Me.dgv4002002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4002003.ResumeLayout(False)
        CType(Me.dgv4002003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4002004.ResumeLayout(False)
        CType(Me.dgv4002004, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB4003.ResumeLayout(False)
        Me.mtabWB4003.ResumeLayout(False)
        Me.tab4003.ResumeLayout(False)
        CType(Me.dgv4003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4003001.ResumeLayout(False)
        CType(Me.dgv4003001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4003002.ResumeLayout(False)
        CType(Me.dgv4003002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4003003.ResumeLayout(False)
        CType(Me.dgv4003003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4003004.ResumeLayout(False)
        CType(Me.dgv4003004, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB4004.ResumeLayout(False)
        Me.mtab4004.ResumeLayout(False)
        Me.tab4004.ResumeLayout(False)
        CType(Me.dgv4004, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4004001.ResumeLayout(False)
        CType(Me.dgv4004001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4004002.ResumeLayout(False)
        CType(Me.dgv4004002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab4004003.ResumeLayout(False)
        CType(Me.dgv4004003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB4005.ResumeLayout(False)
        CType(Me.dgv4005, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5001.ResumeLayout(False)
        CType(Me.dgv5001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5002.ResumeLayout(False)
        Me.mtabWB5002.ResumeLayout(False)
        Me.tab5002.ResumeLayout(False)
        CType(Me.dgv5002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab5002001.ResumeLayout(False)
        CType(Me.dgv5002001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab5002002.ResumeLayout(False)
        CType(Me.dgv5002002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab5002003.ResumeLayout(False)
        CType(Me.dgv5002003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab5002004.ResumeLayout(False)
        CType(Me.dgv5002004, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5003.ResumeLayout(False)
        Me.mtabWB5003.ResumeLayout(False)
        Me.tab5003.ResumeLayout(False)
        CType(Me.dgv5003, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab5003001.ResumeLayout(False)
        CType(Me.dgv5003001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab5003002.ResumeLayout(False)
        CType(Me.dgv5003002, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5004.ResumeLayout(False)
        CType(Me.dgv5004, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5005.ResumeLayout(False)
        CType(Me.dgv5005, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5006.ResumeLayout(False)
        CType(Me.dgv5006, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWB5007.ResumeLayout(False)
        CType(Me.dgv5007, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearchResults.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private mnuDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtabQuick As System.Windows.Forms.TabControl
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents lblSearchType As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents mnuSidebarToggle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents txtWaterSearch As Student_Results_System.TextboxWatermark
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNewFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFileOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuHideToolbar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbReportDesigner As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCut As ToolStripButton
    Friend WithEvents tsbCopy As ToolStripButton
    Friend WithEvents tsbPaste As ToolStripButton
    Friend WithEvents mnuAddStudent As ToolStripMenuItem
    Friend WithEvents mnuMassEdit As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefaultDataSet As Student_Results_System.DefaultDataSet
    Private WithEvents btnAdvSearch As Button
    Friend WithEvents DefaultDataSet1 As DefaultDataSet
    Friend WithEvents DefaultDataSet2 As Student_Results_System.DefaultDataSet
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuReportDesigner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents mtabHome As System.Windows.Forms.TabControl
    Friend WithEvents tabWB4002 As System.Windows.Forms.TabPage
    Friend WithEvents tabWB4001 As System.Windows.Forms.TabPage
    Friend WithEvents mtabWB4002 As System.Windows.Forms.TabControl
    Friend WithEvents tab4002001 As System.Windows.Forms.TabPage
    Friend WithEvents tab4002002 As System.Windows.Forms.TabPage
    Friend WithEvents tabWB4003 As System.Windows.Forms.TabPage
    Friend WithEvents tabWB4004 As System.Windows.Forms.TabPage
    Friend WithEvents tabWB4005 As System.Windows.Forms.TabPage
    Friend WithEvents tabStudents As System.Windows.Forms.TabPage
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsTableAdapter As Student_Results_System.DefaultDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents SIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SLastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabSearchResults As System.Windows.Forms.TabPage
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents tab4002003 As System.Windows.Forms.TabPage
    Friend WithEvents tab4002004 As System.Windows.Forms.TabPage
    Friend WithEvents dgv4001 As System.Windows.Forms.DataGridView
    Friend WithEvents mtabWB4003 As System.Windows.Forms.TabControl
    Friend WithEvents tab4003001 As System.Windows.Forms.TabPage
    Friend WithEvents tab4003002 As System.Windows.Forms.TabPage
    Friend WithEvents tab4003003 As System.Windows.Forms.TabPage
    Friend WithEvents tab4003004 As System.Windows.Forms.TabPage
    Friend WithEvents mtab4004 As System.Windows.Forms.TabControl
    Friend WithEvents tab4004001 As System.Windows.Forms.TabPage
    Friend WithEvents tab4004002 As System.Windows.Forms.TabPage
    Friend WithEvents tab4004003 As System.Windows.Forms.TabPage
    Friend WithEvents tab4002 As System.Windows.Forms.TabPage
    Friend WithEvents dgv4002 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv4002FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4002LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4002ModuleResult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4002001 As System.Windows.Forms.DataGridView
    Friend WithEvents tab4003 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4002002 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4002003 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4002004 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv4003 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddResult As System.Windows.Forms.Button
    Friend WithEvents dgv4003001 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4003002 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4003003 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4003004 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4004001 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4004002 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4004003 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents tab4004 As TabPage
    Friend WithEvents dgv4004 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents dgv4005 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbAddStudent As ToolStripButton
    Friend WithEvents tabWB5001 As TabPage
    Friend WithEvents tabWB5002 As TabPage
    Friend WithEvents tabWB5003 As TabPage
    Friend WithEvents tabWB5004 As TabPage
    Friend WithEvents tabWB5005 As TabPage
    Friend WithEvents tabWB5006 As TabPage
    Friend WithEvents tabWB5007 As TabPage
    Friend WithEvents dgv4001FirstName As DataGridViewTextBoxColumn
    Friend WithEvents dgv4001LastName As DataGridViewTextBoxColumn
    Friend WithEvents dgv4001ModulePass As DataGridViewCheckBoxColumn
    Friend WithEvents dgv5001 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents mtabWB5002 As TabControl
    Friend WithEvents tab5002 As TabPage
    Friend WithEvents dgv5002 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents tab5002001 As TabPage
    Friend WithEvents dgv5002001 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents tab5002002 As TabPage
    Friend WithEvents dgv5002002 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents tab5002003 As TabPage
    Friend WithEvents dgv5002003 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents tab5002004 As TabPage
    Friend WithEvents dgv5002004 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents mtabWB5003 As TabControl
    Friend WithEvents tab5003 As TabPage
    Friend WithEvents dgv5003 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents tab5003001 As TabPage
    Friend WithEvents dgv5003001 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents tab5003002 As TabPage
    Friend WithEvents dgv5003002 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn69 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As DataGridViewTextBoxColumn
    Friend WithEvents dgv5004 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn72 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As DataGridViewTextBoxColumn
    Friend WithEvents dgv5005 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn75 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As DataGridViewTextBoxColumn
    Friend WithEvents dgv5006 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn78 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As DataGridViewTextBoxColumn
    Friend WithEvents dgv5007 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn81 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn82 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn83 As DataGridViewTextBoxColumn
    Friend WithEvents tsbAddResult As ToolStripButton
End Class
