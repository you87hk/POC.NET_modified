<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrint
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents btnSavePath As System.Windows.Forms.Button
	Public WithEvents lblDspSavePath As System.Windows.Forms.Label
	Public WithEvents lblNoOfRecords As System.Windows.Forms.Label
	Public WithEvents lblSavePath As System.Windows.Forms.GroupBox
	Public cdPrinterPrint As System.Windows.Forms.PrintDialog
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public cdSaveAsSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents picStatus As System.Windows.Forms.PictureBox
	Public WithEvents _lstSelect_1 As System.Windows.Forms.ListView
	Public WithEvents _lstSelect_0 As System.Windows.Forms.ListView
	Public WithEvents _cmdSelect_0 As System.Windows.Forms.Button
	Public WithEvents _cmdSelect_1 As System.Windows.Forms.Button
	Public WithEvents _cmdSelect_2 As System.Windows.Forms.Button
	Public WithEvents _cmdSelect_3 As System.Windows.Forms.Button
	Public WithEvents _cmdSelect_4 As System.Windows.Forms.Button
	Public WithEvents _cmdSelect_5 As System.Windows.Forms.Button
	Public WithEvents chkOnScreen As System.Windows.Forms.CheckBox
	Public WithEvents _tabFieldSelect_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents txtTopN As System.Windows.Forms.TextBox
	Public WithEvents _cmdSort_5 As System.Windows.Forms.Button
	Public WithEvents _cmdSort_4 As System.Windows.Forms.Button
	Public WithEvents _cmdSort_3 As System.Windows.Forms.Button
	Public WithEvents _cmdSort_2 As System.Windows.Forms.Button
	Public WithEvents _cmdSort_1 As System.Windows.Forms.Button
	Public WithEvents _cmdSort_0 As System.Windows.Forms.Button
	Public WithEvents _lstSort_0 As System.Windows.Forms.ListView
	Public WithEvents _lstSort_1 As System.Windows.Forms.ListView
	Public WithEvents lblTopN As System.Windows.Forms.Label
	Public WithEvents _tabFieldSelect_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tabFieldSelect As System.Windows.Forms.TabControl
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents cmdSelect As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents cmdSort As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lstSelect As Microsoft.VisualBasic.Compatibility.VB6.ListViewArray
	Public WithEvents lstSort As Microsoft.VisualBasic.Compatibility.VB6.ListViewArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrint))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.lblSavePath = New System.Windows.Forms.GroupBox
		Me.btnSavePath = New System.Windows.Forms.Button
		Me.lblDspSavePath = New System.Windows.Forms.Label
		Me.lblNoOfRecords = New System.Windows.Forms.Label
		Me.cdPrinterPrint = New System.Windows.Forms.PrintDialog
		Me.cdPrinterPrint.PrinterSettings = New System.Drawing.Printing.PrinterSettings
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.cdSaveAsSave = New System.Windows.Forms.SaveFileDialog
		Me.picStatus = New System.Windows.Forms.PictureBox
		Me.tabFieldSelect = New System.Windows.Forms.TabControl
		Me._tabFieldSelect_TabPage0 = New System.Windows.Forms.TabPage
		Me._lstSelect_1 = New System.Windows.Forms.ListView
		Me._lstSelect_0 = New System.Windows.Forms.ListView
		Me._cmdSelect_0 = New System.Windows.Forms.Button
		Me._cmdSelect_1 = New System.Windows.Forms.Button
		Me._cmdSelect_2 = New System.Windows.Forms.Button
		Me._cmdSelect_3 = New System.Windows.Forms.Button
		Me._cmdSelect_4 = New System.Windows.Forms.Button
		Me._cmdSelect_5 = New System.Windows.Forms.Button
		Me.chkOnScreen = New System.Windows.Forms.CheckBox
		Me._tabFieldSelect_TabPage1 = New System.Windows.Forms.TabPage
		Me.txtTopN = New System.Windows.Forms.TextBox
		Me._cmdSort_5 = New System.Windows.Forms.Button
		Me._cmdSort_4 = New System.Windows.Forms.Button
		Me._cmdSort_3 = New System.Windows.Forms.Button
		Me._cmdSort_2 = New System.Windows.Forms.Button
		Me._cmdSort_1 = New System.Windows.Forms.Button
		Me._cmdSort_0 = New System.Windows.Forms.Button
		Me._lstSort_0 = New System.Windows.Forms.ListView
		Me._lstSort_1 = New System.Windows.Forms.ListView
		Me.lblTopN = New System.Windows.Forms.Label
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripButton
		Me.cmdSelect = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.cmdSort = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.lstSelect = New Microsoft.VisualBasic.Compatibility.VB6.ListViewArray(components)
		Me.lstSort = New Microsoft.VisualBasic.Compatibility.VB6.ListViewArray(components)
		Me.lblSavePath.SuspendLayout()
		Me.tabFieldSelect.SuspendLayout()
		Me._tabFieldSelect_TabPage0.SuspendLayout()
		Me._tabFieldSelect_TabPage1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdSort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Report Printing"
		Me.ClientSize = New System.Drawing.Size(650, 504)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmPrint.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPrint"
		Me.lblSavePath.Text = "Frame1"
		Me.lblSavePath.Size = New System.Drawing.Size(585, 89)
		Me.lblSavePath.Location = New System.Drawing.Point(16, 64)
		Me.lblSavePath.TabIndex = 22
		Me.lblSavePath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSavePath.BackColor = System.Drawing.SystemColors.Control
		Me.lblSavePath.Enabled = True
		Me.lblSavePath.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSavePath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSavePath.Visible = True
		Me.lblSavePath.Padding = New System.Windows.Forms.Padding(0)
		Me.lblSavePath.Name = "lblSavePath"
		Me.btnSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSavePath.Text = "..."
		Me.btnSavePath.Font = New System.Drawing.Font("Times New Roman", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSavePath.Size = New System.Drawing.Size(17, 20)
		Me.btnSavePath.Location = New System.Drawing.Point(461, 24)
		Me.btnSavePath.TabIndex = 23
		Me.btnSavePath.Tag = "K"
		Me.btnSavePath.BackColor = System.Drawing.SystemColors.Control
		Me.btnSavePath.CausesValidation = True
		Me.btnSavePath.Enabled = True
		Me.btnSavePath.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSavePath.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSavePath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSavePath.TabStop = True
		Me.btnSavePath.Name = "btnSavePath"
		Me.lblDspSavePath.Text = "\\SPSRV0\STEPPRO\REPORTPATH"
		Me.lblDspSavePath.Size = New System.Drawing.Size(426, 17)
		Me.lblDspSavePath.Location = New System.Drawing.Point(32, 27)
		Me.lblDspSavePath.TabIndex = 25
		Me.lblDspSavePath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspSavePath.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspSavePath.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspSavePath.Enabled = True
		Me.lblDspSavePath.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspSavePath.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspSavePath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspSavePath.UseMnemonic = True
		Me.lblDspSavePath.Visible = True
		Me.lblDspSavePath.AutoSize = False
		Me.lblDspSavePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspSavePath.Name = "lblDspSavePath"
		Me.lblNoOfRecords.BackColor = System.Drawing.SystemColors.Window
		Me.lblNoOfRecords.Text = "Records"
		Me.lblNoOfRecords.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblNoOfRecords.Size = New System.Drawing.Size(175, 15)
		Me.lblNoOfRecords.Location = New System.Drawing.Point(32, 56)
		Me.lblNoOfRecords.TabIndex = 24
		Me.lblNoOfRecords.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNoOfRecords.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNoOfRecords.Enabled = True
		Me.lblNoOfRecords.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNoOfRecords.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNoOfRecords.UseMnemonic = True
		Me.lblNoOfRecords.Visible = True
		Me.lblNoOfRecords.AutoSize = False
		Me.lblNoOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblNoOfRecords.Name = "lblNoOfRecords"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1000
		Me.picStatus.BackColor = System.Drawing.Color.White
		Me.picStatus.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatus.Size = New System.Drawing.Size(612, 28)
		Me.picStatus.Location = New System.Drawing.Point(18, 27)
		Me.picStatus.TabIndex = 16
		Me.picStatus.TabStop = False
		Me.picStatus.Dock = System.Windows.Forms.DockStyle.None
		Me.picStatus.CausesValidation = True
		Me.picStatus.Enabled = True
		Me.picStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.picStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picStatus.Visible = True
		Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picStatus.Name = "picStatus"
		Me.tabFieldSelect.Size = New System.Drawing.Size(615, 308)
		Me.tabFieldSelect.Location = New System.Drawing.Point(19, 184)
		Me.tabFieldSelect.TabIndex = 17
		Me.tabFieldSelect.ItemSize = New System.Drawing.Size(42, 14)
		Me.tabFieldSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabFieldSelect.Name = "tabFieldSelect"
		Me._tabFieldSelect_TabPage0.Text = "Field Selection"
		Me._lstSelect_1.Size = New System.Drawing.Size(224, 232)
		Me._lstSelect_1.Location = New System.Drawing.Point(333, 20)
		Me._lstSelect_1.TabIndex = 5
		Me._lstSelect_1.View = System.Windows.Forms.View.Details
		Me._lstSelect_1.LabelWrap = True
		Me._lstSelect_1.HideSelection = True
		Me._lstSelect_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lstSelect_1.BackColor = System.Drawing.SystemColors.Window
		Me._lstSelect_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lstSelect_1.LabelEdit = True
		Me._lstSelect_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._lstSelect_1.Name = "_lstSelect_1"
		Me._lstSelect_0.Size = New System.Drawing.Size(224, 232)
		Me._lstSelect_0.Location = New System.Drawing.Point(20, 20)
		Me._lstSelect_0.TabIndex = 0
		Me._lstSelect_0.View = System.Windows.Forms.View.Details
		Me._lstSelect_0.LabelWrap = True
		Me._lstSelect_0.HideSelection = True
		Me._lstSelect_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lstSelect_0.BackColor = System.Drawing.SystemColors.Window
		Me._lstSelect_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lstSelect_0.LabelEdit = True
		Me._lstSelect_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._lstSelect_0.Name = "_lstSelect_0"
		Me._cmdSelect_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelect_0.Text = ">"
		Me._cmdSelect_0.Size = New System.Drawing.Size(70, 36)
		Me._cmdSelect_0.Location = New System.Drawing.Point(253, 37)
		Me._cmdSelect_0.TabIndex = 1
		Me._cmdSelect_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelect_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelect_0.CausesValidation = True
		Me._cmdSelect_0.Enabled = True
		Me._cmdSelect_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelect_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelect_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelect_0.TabStop = True
		Me._cmdSelect_0.Name = "_cmdSelect_0"
		Me._cmdSelect_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelect_1.Text = ">>"
		Me._cmdSelect_1.Size = New System.Drawing.Size(70, 36)
		Me._cmdSelect_1.Location = New System.Drawing.Point(253, 80)
		Me._cmdSelect_1.TabIndex = 2
		Me._cmdSelect_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelect_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelect_1.CausesValidation = True
		Me._cmdSelect_1.Enabled = True
		Me._cmdSelect_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelect_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelect_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelect_1.TabStop = True
		Me._cmdSelect_1.Name = "_cmdSelect_1"
		Me._cmdSelect_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelect_2.Text = "<"
		Me._cmdSelect_2.Size = New System.Drawing.Size(70, 36)
		Me._cmdSelect_2.Location = New System.Drawing.Point(253, 168)
		Me._cmdSelect_2.TabIndex = 3
		Me._cmdSelect_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelect_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelect_2.CausesValidation = True
		Me._cmdSelect_2.Enabled = True
		Me._cmdSelect_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelect_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelect_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelect_2.TabStop = True
		Me._cmdSelect_2.Name = "_cmdSelect_2"
		Me._cmdSelect_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelect_3.Text = "<<"
		Me._cmdSelect_3.Size = New System.Drawing.Size(70, 36)
		Me._cmdSelect_3.Location = New System.Drawing.Point(253, 212)
		Me._cmdSelect_3.TabIndex = 4
		Me._cmdSelect_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelect_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelect_3.CausesValidation = True
		Me._cmdSelect_3.Enabled = True
		Me._cmdSelect_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelect_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelect_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelect_3.TabStop = True
		Me._cmdSelect_3.Name = "_cmdSelect_3"
		Me._cmdSelect_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelect_4.Size = New System.Drawing.Size(39, 23)
		Me._cmdSelect_4.Location = New System.Drawing.Point(565, 120)
		Me._cmdSelect_4.TabIndex = 6
		Me._cmdSelect_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelect_4.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelect_4.CausesValidation = True
		Me._cmdSelect_4.Enabled = True
		Me._cmdSelect_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelect_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelect_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelect_4.TabStop = True
		Me._cmdSelect_4.Name = "_cmdSelect_4"
		Me._cmdSelect_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelect_5.Size = New System.Drawing.Size(39, 23)
		Me._cmdSelect_5.Location = New System.Drawing.Point(565, 151)
		Me._cmdSelect_5.TabIndex = 7
		Me._cmdSelect_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelect_5.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelect_5.CausesValidation = True
		Me._cmdSelect_5.Enabled = True
		Me._cmdSelect_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelect_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelect_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelect_5.TabStop = True
		Me._cmdSelect_5.Name = "_cmdSelect_5"
		Me.chkOnScreen.Text = "View on Screen"
		Me.chkOnScreen.Size = New System.Drawing.Size(224, 22)
		Me.chkOnScreen.Location = New System.Drawing.Point(21, 258)
		Me.chkOnScreen.TabIndex = 20
		Me.chkOnScreen.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkOnScreen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkOnScreen.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkOnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkOnScreen.BackColor = System.Drawing.SystemColors.Control
		Me.chkOnScreen.CausesValidation = True
		Me.chkOnScreen.Enabled = True
		Me.chkOnScreen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkOnScreen.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkOnScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkOnScreen.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkOnScreen.TabStop = True
		Me.chkOnScreen.Visible = True
		Me.chkOnScreen.Name = "chkOnScreen"
		Me._tabFieldSelect_TabPage1.Text = "Sorting"
		Me.txtTopN.AutoSize = False
		Me.txtTopN.Size = New System.Drawing.Size(68, 20)
		Me.txtTopN.Location = New System.Drawing.Point(112, 258)
		Me.txtTopN.TabIndex = 19
		Me.txtTopN.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTopN.AcceptsReturn = True
		Me.txtTopN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTopN.BackColor = System.Drawing.SystemColors.Window
		Me.txtTopN.CausesValidation = True
		Me.txtTopN.Enabled = True
		Me.txtTopN.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTopN.HideSelection = True
		Me.txtTopN.ReadOnly = False
		Me.txtTopN.Maxlength = 0
		Me.txtTopN.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTopN.MultiLine = False
		Me.txtTopN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTopN.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTopN.TabStop = True
		Me.txtTopN.Visible = True
		Me.txtTopN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTopN.Name = "txtTopN"
		Me._cmdSort_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSort_5.Size = New System.Drawing.Size(39, 23)
		Me._cmdSort_5.Location = New System.Drawing.Point(565, 151)
		Me._cmdSort_5.TabIndex = 15
		Me._cmdSort_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSort_5.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSort_5.CausesValidation = True
		Me._cmdSort_5.Enabled = True
		Me._cmdSort_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSort_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSort_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSort_5.TabStop = True
		Me._cmdSort_5.Name = "_cmdSort_5"
		Me._cmdSort_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSort_4.Size = New System.Drawing.Size(39, 23)
		Me._cmdSort_4.Location = New System.Drawing.Point(565, 120)
		Me._cmdSort_4.TabIndex = 14
		Me._cmdSort_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSort_4.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSort_4.CausesValidation = True
		Me._cmdSort_4.Enabled = True
		Me._cmdSort_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSort_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSort_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSort_4.TabStop = True
		Me._cmdSort_4.Name = "_cmdSort_4"
		Me._cmdSort_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSort_3.Text = "<<"
		Me._cmdSort_3.Size = New System.Drawing.Size(70, 36)
		Me._cmdSort_3.Location = New System.Drawing.Point(253, 212)
		Me._cmdSort_3.TabIndex = 12
		Me._cmdSort_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSort_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSort_3.CausesValidation = True
		Me._cmdSort_3.Enabled = True
		Me._cmdSort_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSort_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSort_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSort_3.TabStop = True
		Me._cmdSort_3.Name = "_cmdSort_3"
		Me._cmdSort_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSort_2.Text = "<"
		Me._cmdSort_2.Size = New System.Drawing.Size(70, 36)
		Me._cmdSort_2.Location = New System.Drawing.Point(253, 168)
		Me._cmdSort_2.TabIndex = 11
		Me._cmdSort_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSort_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSort_2.CausesValidation = True
		Me._cmdSort_2.Enabled = True
		Me._cmdSort_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSort_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSort_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSort_2.TabStop = True
		Me._cmdSort_2.Name = "_cmdSort_2"
		Me._cmdSort_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSort_1.Text = ">>"
		Me._cmdSort_1.Size = New System.Drawing.Size(70, 36)
		Me._cmdSort_1.Location = New System.Drawing.Point(253, 80)
		Me._cmdSort_1.TabIndex = 10
		Me._cmdSort_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSort_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSort_1.CausesValidation = True
		Me._cmdSort_1.Enabled = True
		Me._cmdSort_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSort_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSort_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSort_1.TabStop = True
		Me._cmdSort_1.Name = "_cmdSort_1"
		Me._cmdSort_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSort_0.Text = ">"
		Me._cmdSort_0.Size = New System.Drawing.Size(70, 36)
		Me._cmdSort_0.Location = New System.Drawing.Point(253, 37)
		Me._cmdSort_0.TabIndex = 9
		Me._cmdSort_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSort_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSort_0.CausesValidation = True
		Me._cmdSort_0.Enabled = True
		Me._cmdSort_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSort_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSort_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSort_0.TabStop = True
		Me._cmdSort_0.Name = "_cmdSort_0"
		Me._lstSort_0.Size = New System.Drawing.Size(224, 232)
		Me._lstSort_0.Location = New System.Drawing.Point(20, 20)
		Me._lstSort_0.TabIndex = 8
		Me._lstSort_0.View = System.Windows.Forms.View.Details
		Me._lstSort_0.LabelWrap = True
		Me._lstSort_0.HideSelection = True
		Me._lstSort_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lstSort_0.BackColor = System.Drawing.SystemColors.Window
		Me._lstSort_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lstSort_0.LabelEdit = True
		Me._lstSort_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._lstSort_0.Name = "_lstSort_0"
		Me._lstSort_1.Size = New System.Drawing.Size(224, 232)
		Me._lstSort_1.Location = New System.Drawing.Point(333, 20)
		Me._lstSort_1.TabIndex = 13
		Me._lstSort_1.View = System.Windows.Forms.View.Details
		Me._lstSort_1.LabelWrap = True
		Me._lstSort_1.HideSelection = True
		Me._lstSort_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lstSort_1.BackColor = System.Drawing.SystemColors.Window
		Me._lstSort_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lstSort_1.LabelEdit = True
		Me._lstSort_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._lstSort_1.Name = "_lstSort_1"
		Me.lblTopN.Text = "Top N Records:"
		Me.lblTopN.Size = New System.Drawing.Size(78, 17)
		Me.lblTopN.Location = New System.Drawing.Point(26, 258)
		Me.lblTopN.TabIndex = 18
		Me.lblTopN.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTopN.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTopN.BackColor = System.Drawing.SystemColors.Control
		Me.lblTopN.Enabled = True
		Me.lblTopN.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTopN.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTopN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTopN.UseMnemonic = True
		Me.lblTopN.Visible = True
		Me.lblTopN.AutoSize = False
		Me.lblTopN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTopN.Name = "lblTopN"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.iglProcess.ImageStream = CType(resources.GetObject("iglProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.iglProcess.Images.SetKeyName(0, "")
		Me.iglProcess.Images.SetKeyName(1, "")
		Me.iglProcess.Images.SetKeyName(2, "")
		Me.iglProcess.Images.SetKeyName(3, "")
		Me.iglProcess.Images.SetKeyName(4, "")
		Me.iglProcess.Images.SetKeyName(5, "")
		Me.iglProcess.Images.SetKeyName(6, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(650, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 21
		Me.tbrProcess.ImageList = iglProcess
		Me.tbrProcess.Name = "tbrProcess"
		Me._tbrProcess_Button1.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button1.AutoSize = False
		Me._tbrProcess_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button2.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button2.AutoSize = False
		Me._tbrProcess_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button2.Name = "Preview"
		Me._tbrProcess_Button2.ToolTipText = "Preview (F2)"
		Me._tbrProcess_Button2.ImageIndex = 0
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Print"
		Me._tbrProcess_Button3.ToolTipText = "Print (F3)"
		Me._tbrProcess_Button3.ImageIndex = 4
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Excel"
		Me._tbrProcess_Button4.ToolTipText = "Excel (F5)"
		Me._tbrProcess_Button4.ImageIndex = 3
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Browse"
		Me._tbrProcess_Button5.ToolTipText = "Browse (F6)"
		Me._tbrProcess_Button5.ImageIndex = 2
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Printer"
		Me._tbrProcess_Button6.ToolTipText = "Printer Setup (F9)"
		Me._tbrProcess_Button6.ImageIndex = 5
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.Name = "Detail"
		Me._tbrProcess_Button7.ToolTipText = "Detail (F10)"
		Me._tbrProcess_Button7.ImageIndex = 6
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Exit"
		Me._tbrProcess_Button8.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button8.ImageIndex = 1
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Controls.Add(lblSavePath)
		Me.Controls.Add(picStatus)
		Me.Controls.Add(tabFieldSelect)
		Me.Controls.Add(tbrProcess)
		Me.lblSavePath.Controls.Add(btnSavePath)
		Me.lblSavePath.Controls.Add(lblDspSavePath)
		Me.lblSavePath.Controls.Add(lblNoOfRecords)
		Me.tabFieldSelect.Controls.Add(_tabFieldSelect_TabPage0)
		Me.tabFieldSelect.Controls.Add(_tabFieldSelect_TabPage1)
		Me._tabFieldSelect_TabPage0.Controls.Add(_lstSelect_1)
		Me._tabFieldSelect_TabPage0.Controls.Add(_lstSelect_0)
		Me._tabFieldSelect_TabPage0.Controls.Add(_cmdSelect_0)
		Me._tabFieldSelect_TabPage0.Controls.Add(_cmdSelect_1)
		Me._tabFieldSelect_TabPage0.Controls.Add(_cmdSelect_2)
		Me._tabFieldSelect_TabPage0.Controls.Add(_cmdSelect_3)
		Me._tabFieldSelect_TabPage0.Controls.Add(_cmdSelect_4)
		Me._tabFieldSelect_TabPage0.Controls.Add(_cmdSelect_5)
		Me._tabFieldSelect_TabPage0.Controls.Add(chkOnScreen)
		Me._tabFieldSelect_TabPage1.Controls.Add(txtTopN)
		Me._tabFieldSelect_TabPage1.Controls.Add(_cmdSort_5)
		Me._tabFieldSelect_TabPage1.Controls.Add(_cmdSort_4)
		Me._tabFieldSelect_TabPage1.Controls.Add(_cmdSort_3)
		Me._tabFieldSelect_TabPage1.Controls.Add(_cmdSort_2)
		Me._tabFieldSelect_TabPage1.Controls.Add(_cmdSort_1)
		Me._tabFieldSelect_TabPage1.Controls.Add(_cmdSort_0)
		Me._tabFieldSelect_TabPage1.Controls.Add(_lstSort_0)
		Me._tabFieldSelect_TabPage1.Controls.Add(_lstSort_1)
		Me._tabFieldSelect_TabPage1.Controls.Add(lblTopN)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
		Me.tbrProcess.Items.Add(_tbrProcess_Button7)
		Me.tbrProcess.Items.Add(_tbrProcess_Button8)
		Me.cmdSelect.SetIndex(_cmdSelect_5, CType(5, Short))
		Me.cmdSelect.SetIndex(_cmdSelect_4, CType(4, Short))
		Me.cmdSelect.SetIndex(_cmdSelect_3, CType(3, Short))
		Me.cmdSelect.SetIndex(_cmdSelect_2, CType(2, Short))
		Me.cmdSelect.SetIndex(_cmdSelect_1, CType(1, Short))
		Me.cmdSelect.SetIndex(_cmdSelect_0, CType(0, Short))
		Me.cmdSort.SetIndex(_cmdSort_5, CType(5, Short))
		Me.cmdSort.SetIndex(_cmdSort_4, CType(4, Short))
		Me.cmdSort.SetIndex(_cmdSort_3, CType(3, Short))
		Me.cmdSort.SetIndex(_cmdSort_2, CType(2, Short))
		Me.cmdSort.SetIndex(_cmdSort_1, CType(1, Short))
		Me.cmdSort.SetIndex(_cmdSort_0, CType(0, Short))
		Me.lstSelect.SetIndex(_lstSelect_0, CType(0, Short))
		Me.lstSelect.SetIndex(_lstSelect_1, CType(1, Short))
		Me.lstSort.SetIndex(_lstSort_0, CType(0, Short))
		Me.lstSort.SetIndex(_lstSort_1, CType(1, Short))
		CType(Me.cmdSort, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lblSavePath.ResumeLayout(False)
		Me.tabFieldSelect.ResumeLayout(False)
		Me._tabFieldSelect_TabPage0.ResumeLayout(False)
		Me._tabFieldSelect_TabPage1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class