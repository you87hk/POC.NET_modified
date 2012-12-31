<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSOP020
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
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _optSel_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optSel_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optSel_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optSel_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optSel_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents cboCusNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboCusNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboAccTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboAccTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboLevelCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboLevelCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents txtPayYear As System.Windows.Forms.TextBox
	Public WithEvents txtPayQuarter As System.Windows.Forms.TextBox
	Public WithEvents txtPayMonth As System.Windows.Forms.TextBox
	Public WithEvents _optBy_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents fraRange As System.Windows.Forms.GroupBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents lblCusNoFr As System.Windows.Forms.Label
	Public WithEvents lblCusNoTo As System.Windows.Forms.Label
	Public WithEvents lblAccTypeCodeFr As System.Windows.Forms.Label
	Public WithEvents lblAccTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblLevelCodeFr As System.Windows.Forms.Label
	Public WithEvents lblLevelCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeFr As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents optBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optSel As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSOP020))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me._optSel_4 = New System.Windows.Forms.RadioButton
		Me._optSel_3 = New System.Windows.Forms.RadioButton
		Me._optSel_2 = New System.Windows.Forms.RadioButton
		Me._optSel_1 = New System.Windows.Forms.RadioButton
		Me._optSel_0 = New System.Windows.Forms.RadioButton
		Me.cboCusNoFr = New System.Windows.Forms.ComboBox
		Me.cboCusNoTo = New System.Windows.Forms.ComboBox
		Me.cboAccTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboAccTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboLevelCodeFr = New System.Windows.Forms.ComboBox
		Me.cboLevelCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeFr = New System.Windows.Forms.ComboBox
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.txtPayYear = New System.Windows.Forms.TextBox
		Me.txtPayQuarter = New System.Windows.Forms.TextBox
		Me.txtPayMonth = New System.Windows.Forms.TextBox
		Me._optBy_2 = New System.Windows.Forms.RadioButton
		Me._optBy_0 = New System.Windows.Forms.RadioButton
		Me._optBy_1 = New System.Windows.Forms.RadioButton
		Me.fraRange = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.lblCusNoFr = New System.Windows.Forms.Label
		Me.lblCusNoTo = New System.Windows.Forms.Label
		Me.lblAccTypeCodeFr = New System.Windows.Forms.Label
		Me.lblAccTypeCodeTo = New System.Windows.Forms.Label
		Me.lblLevelCodeFr = New System.Windows.Forms.Label
		Me.lblLevelCodeTo = New System.Windows.Forms.Label
		Me.lblItmTypeCodeFr = New System.Windows.Forms.Label
		Me.lblItmTypeCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeFr = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.optBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optSel = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraSelect.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optSel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "SOP020"
		Me.ClientSize = New System.Drawing.Size(613, 357)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.KeyPreview = True
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSOP020"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(464, 248)
		Me.tblCommon.TabIndex = 22
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.fraSelect.Size = New System.Drawing.Size(36, 129)
		Me.fraSelect.Location = New System.Drawing.Point(496, 72)
		Me.fraSelect.TabIndex = 38
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me._optSel_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_4.Size = New System.Drawing.Size(25, 17)
		Me._optSel_4.Location = New System.Drawing.Point(8, 104)
		Me._optSel_4.TabIndex = 15
		Me._optSel_4.Checked = True
		Me._optSel_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSel_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_4.BackColor = System.Drawing.SystemColors.Control
		Me._optSel_4.CausesValidation = True
		Me._optSel_4.Enabled = True
		Me._optSel_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSel_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSel_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSel_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSel_4.TabStop = True
		Me._optSel_4.Visible = True
		Me._optSel_4.Name = "_optSel_4"
		Me._optSel_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_3.Size = New System.Drawing.Size(25, 17)
		Me._optSel_3.Location = New System.Drawing.Point(8, 80)
		Me._optSel_3.TabIndex = 14
		Me._optSel_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSel_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_3.BackColor = System.Drawing.SystemColors.Control
		Me._optSel_3.CausesValidation = True
		Me._optSel_3.Enabled = True
		Me._optSel_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSel_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSel_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSel_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSel_3.TabStop = True
		Me._optSel_3.Checked = False
		Me._optSel_3.Visible = True
		Me._optSel_3.Name = "_optSel_3"
		Me._optSel_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_2.Size = New System.Drawing.Size(25, 17)
		Me._optSel_2.Location = New System.Drawing.Point(8, 56)
		Me._optSel_2.TabIndex = 13
		Me._optSel_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSel_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_2.BackColor = System.Drawing.SystemColors.Control
		Me._optSel_2.CausesValidation = True
		Me._optSel_2.Enabled = True
		Me._optSel_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSel_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSel_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSel_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSel_2.TabStop = True
		Me._optSel_2.Checked = False
		Me._optSel_2.Visible = True
		Me._optSel_2.Name = "_optSel_2"
		Me._optSel_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_1.Size = New System.Drawing.Size(25, 17)
		Me._optSel_1.Location = New System.Drawing.Point(8, 32)
		Me._optSel_1.TabIndex = 12
		Me._optSel_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSel_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_1.BackColor = System.Drawing.SystemColors.Control
		Me._optSel_1.CausesValidation = True
		Me._optSel_1.Enabled = True
		Me._optSel_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSel_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSel_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSel_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSel_1.TabStop = True
		Me._optSel_1.Checked = False
		Me._optSel_1.Visible = True
		Me._optSel_1.Name = "_optSel_1"
		Me._optSel_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_0.Size = New System.Drawing.Size(25, 17)
		Me._optSel_0.Location = New System.Drawing.Point(8, 8)
		Me._optSel_0.TabIndex = 11
		Me._optSel_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSel_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSel_0.BackColor = System.Drawing.SystemColors.Control
		Me._optSel_0.CausesValidation = True
		Me._optSel_0.Enabled = True
		Me._optSel_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSel_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSel_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSel_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSel_0.TabStop = True
		Me._optSel_0.Checked = False
		Me._optSel_0.Visible = True
		Me._optSel_0.Name = "_optSel_0"
		Me.cboCusNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoFr.Location = New System.Drawing.Point(184, 176)
		Me.cboCusNoFr.TabIndex = 9
		Me.cboCusNoFr.Text = "Combo1"
		Me.cboCusNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusNoFr.CausesValidation = True
		Me.cboCusNoFr.Enabled = True
		Me.cboCusNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusNoFr.IntegralHeight = True
		Me.cboCusNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusNoFr.Sorted = False
		Me.cboCusNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusNoFr.TabStop = True
		Me.cboCusNoFr.Visible = True
		Me.cboCusNoFr.Name = "cboCusNoFr"
		Me.cboCusNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoTo.Location = New System.Drawing.Point(366, 176)
		Me.cboCusNoTo.TabIndex = 10
		Me.cboCusNoTo.Text = "Combo1"
		Me.cboCusNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusNoTo.CausesValidation = True
		Me.cboCusNoTo.Enabled = True
		Me.cboCusNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusNoTo.IntegralHeight = True
		Me.cboCusNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusNoTo.Sorted = False
		Me.cboCusNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusNoTo.TabStop = True
		Me.cboCusNoTo.Visible = True
		Me.cboCusNoTo.Name = "cboCusNoTo"
		Me.cboAccTypeCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboAccTypeCodeFr.Location = New System.Drawing.Point(184, 152)
		Me.cboAccTypeCodeFr.TabIndex = 7
		Me.cboAccTypeCodeFr.Text = "Combo1"
		Me.cboAccTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccTypeCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccTypeCodeFr.CausesValidation = True
		Me.cboAccTypeCodeFr.Enabled = True
		Me.cboAccTypeCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccTypeCodeFr.IntegralHeight = True
		Me.cboAccTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccTypeCodeFr.Sorted = False
		Me.cboAccTypeCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccTypeCodeFr.TabStop = True
		Me.cboAccTypeCodeFr.Visible = True
		Me.cboAccTypeCodeFr.Name = "cboAccTypeCodeFr"
		Me.cboAccTypeCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboAccTypeCodeTo.Location = New System.Drawing.Point(366, 152)
		Me.cboAccTypeCodeTo.TabIndex = 8
		Me.cboAccTypeCodeTo.Text = "Combo1"
		Me.cboAccTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccTypeCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccTypeCodeTo.CausesValidation = True
		Me.cboAccTypeCodeTo.Enabled = True
		Me.cboAccTypeCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccTypeCodeTo.IntegralHeight = True
		Me.cboAccTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccTypeCodeTo.Sorted = False
		Me.cboAccTypeCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccTypeCodeTo.TabStop = True
		Me.cboAccTypeCodeTo.Visible = True
		Me.cboAccTypeCodeTo.Name = "cboAccTypeCodeTo"
		Me.cboLevelCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboLevelCodeFr.Location = New System.Drawing.Point(184, 128)
		Me.cboLevelCodeFr.TabIndex = 5
		Me.cboLevelCodeFr.Text = "Combo1"
		Me.cboLevelCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboLevelCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboLevelCodeFr.CausesValidation = True
		Me.cboLevelCodeFr.Enabled = True
		Me.cboLevelCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLevelCodeFr.IntegralHeight = True
		Me.cboLevelCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboLevelCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLevelCodeFr.Sorted = False
		Me.cboLevelCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboLevelCodeFr.TabStop = True
		Me.cboLevelCodeFr.Visible = True
		Me.cboLevelCodeFr.Name = "cboLevelCodeFr"
		Me.cboLevelCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboLevelCodeTo.Location = New System.Drawing.Point(366, 128)
		Me.cboLevelCodeTo.TabIndex = 6
		Me.cboLevelCodeTo.Text = "Combo1"
		Me.cboLevelCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboLevelCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboLevelCodeTo.CausesValidation = True
		Me.cboLevelCodeTo.Enabled = True
		Me.cboLevelCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLevelCodeTo.IntegralHeight = True
		Me.cboLevelCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboLevelCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLevelCodeTo.Sorted = False
		Me.cboLevelCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboLevelCodeTo.TabStop = True
		Me.cboLevelCodeTo.Visible = True
		Me.cboLevelCodeTo.Name = "cboLevelCodeTo"
		Me.cboItmTypeCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCodeFr.Location = New System.Drawing.Point(184, 104)
		Me.cboItmTypeCodeFr.TabIndex = 3
		Me.cboItmTypeCodeFr.Text = "Combo1"
		Me.cboItmTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeCodeFr.CausesValidation = True
		Me.cboItmTypeCodeFr.Enabled = True
		Me.cboItmTypeCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeCodeFr.IntegralHeight = True
		Me.cboItmTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeCodeFr.Sorted = False
		Me.cboItmTypeCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeCodeFr.TabStop = True
		Me.cboItmTypeCodeFr.Visible = True
		Me.cboItmTypeCodeFr.Name = "cboItmTypeCodeFr"
		Me.cboItmTypeCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCodeTo.Location = New System.Drawing.Point(366, 104)
		Me.cboItmTypeCodeTo.TabIndex = 4
		Me.cboItmTypeCodeTo.Text = "Combo1"
		Me.cboItmTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeCodeTo.CausesValidation = True
		Me.cboItmTypeCodeTo.Enabled = True
		Me.cboItmTypeCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeCodeTo.IntegralHeight = True
		Me.cboItmTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeCodeTo.Sorted = False
		Me.cboItmTypeCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeCodeTo.TabStop = True
		Me.cboItmTypeCodeTo.Visible = True
		Me.cboItmTypeCodeTo.Name = "cboItmTypeCodeTo"
		Me.cboItmCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeTo.Location = New System.Drawing.Point(366, 80)
		Me.cboItmCodeTo.TabIndex = 2
		Me.cboItmCodeTo.Text = "Combo1"
		Me.cboItmCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCodeTo.CausesValidation = True
		Me.cboItmCodeTo.Enabled = True
		Me.cboItmCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCodeTo.IntegralHeight = True
		Me.cboItmCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCodeTo.Sorted = False
		Me.cboItmCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCodeTo.TabStop = True
		Me.cboItmCodeTo.Visible = True
		Me.cboItmCodeTo.Name = "cboItmCodeTo"
		Me.cboItmCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeFr.Location = New System.Drawing.Point(184, 80)
		Me.cboItmCodeFr.TabIndex = 1
		Me.cboItmCodeFr.Text = "Combo1"
		Me.cboItmCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCodeFr.CausesValidation = True
		Me.cboItmCodeFr.Enabled = True
		Me.cboItmCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCodeFr.IntegralHeight = True
		Me.cboItmCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCodeFr.Sorted = False
		Me.cboItmCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCodeFr.TabStop = True
		Me.cboItmCodeFr.Visible = True
		Me.cboItmCodeFr.Name = "cboItmCodeFr"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(186, 48)
		Me.txtTitle.TabIndex = 0
		Me.txtTitle.Text = "01234567890123457890"
		Me.txtTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTitle.AcceptsReturn = True
		Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtTitle.CausesValidation = True
		Me.txtTitle.Enabled = True
		Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTitle.HideSelection = True
		Me.txtTitle.ReadOnly = False
		Me.txtTitle.Maxlength = 0
		Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTitle.MultiLine = False
		Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTitle.TabStop = True
		Me.txtTitle.Visible = True
		Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTitle.Name = "txtTitle"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.iglProcess.Images.SetKeyName(0, "")
		Me.iglProcess.Images.SetKeyName(1, "")
		Me.iglProcess.Images.SetKeyName(2, "")
		Me.iglProcess.Images.SetKeyName(3, "")
		Me.iglProcess.Images.SetKeyName(4, "")
		Me.iglProcess.Images.SetKeyName(5, "")
		Me.iglProcess.Images.SetKeyName(6, "")
		Me.iglProcess.Images.SetKeyName(7, "")
		Me.iglProcess.Images.SetKeyName(8, "")
		Me.iglProcess.Images.SetKeyName(9, "")
		Me.iglProcess.Images.SetKeyName(10, "")
		Me.iglProcess.Images.SetKeyName(11, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(613, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 24
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
		Me._tbrProcess_Button2.Name = "Go"
		Me._tbrProcess_Button2.ToolTipText = "Go (F9)"
		Me._tbrProcess_Button2.ImageIndex = 6
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Cancel"
		Me._tbrProcess_Button3.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button3.ImageIndex = 4
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Exit"
		Me._tbrProcess_Button4.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button4.ImageIndex = 8
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.txtPayYear.AutoSize = False
		Me.txtPayYear.Size = New System.Drawing.Size(59, 20)
		Me.txtPayYear.Location = New System.Drawing.Point(184, 312)
		Me.txtPayYear.TabIndex = 21
		Me.txtPayYear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayYear.AcceptsReturn = True
		Me.txtPayYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayYear.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayYear.CausesValidation = True
		Me.txtPayYear.Enabled = True
		Me.txtPayYear.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayYear.HideSelection = True
		Me.txtPayYear.ReadOnly = False
		Me.txtPayYear.Maxlength = 0
		Me.txtPayYear.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayYear.MultiLine = False
		Me.txtPayYear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayYear.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayYear.TabStop = True
		Me.txtPayYear.Visible = True
		Me.txtPayYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayYear.Name = "txtPayYear"
		Me.txtPayQuarter.AutoSize = False
		Me.txtPayQuarter.Size = New System.Drawing.Size(59, 20)
		Me.txtPayQuarter.Location = New System.Drawing.Point(184, 280)
		Me.txtPayQuarter.TabIndex = 19
		Me.txtPayQuarter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayQuarter.AcceptsReturn = True
		Me.txtPayQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayQuarter.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayQuarter.CausesValidation = True
		Me.txtPayQuarter.Enabled = True
		Me.txtPayQuarter.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayQuarter.HideSelection = True
		Me.txtPayQuarter.ReadOnly = False
		Me.txtPayQuarter.Maxlength = 0
		Me.txtPayQuarter.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayQuarter.MultiLine = False
		Me.txtPayQuarter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayQuarter.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayQuarter.TabStop = True
		Me.txtPayQuarter.Visible = True
		Me.txtPayQuarter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayQuarter.Name = "txtPayQuarter"
		Me.txtPayMonth.AutoSize = False
		Me.txtPayMonth.Size = New System.Drawing.Size(59, 20)
		Me.txtPayMonth.Location = New System.Drawing.Point(184, 248)
		Me.txtPayMonth.TabIndex = 17
		Me.txtPayMonth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayMonth.AcceptsReturn = True
		Me.txtPayMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayMonth.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayMonth.CausesValidation = True
		Me.txtPayMonth.Enabled = True
		Me.txtPayMonth.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayMonth.HideSelection = True
		Me.txtPayMonth.ReadOnly = False
		Me.txtPayMonth.Maxlength = 0
		Me.txtPayMonth.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayMonth.MultiLine = False
		Me.txtPayMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayMonth.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayMonth.TabStop = True
		Me.txtPayMonth.Visible = True
		Me.txtPayMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayMonth.Name = "txtPayMonth"
		Me._optBy_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_2.Text = "BYYEAR"
		Me._optBy_2.Size = New System.Drawing.Size(89, 17)
		Me._optBy_2.Location = New System.Drawing.Point(64, 312)
		Me._optBy_2.TabIndex = 20
		Me._optBy_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBy_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_2.BackColor = System.Drawing.SystemColors.Control
		Me._optBy_2.CausesValidation = True
		Me._optBy_2.Enabled = True
		Me._optBy_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBy_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBy_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBy_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optBy_2.TabStop = True
		Me._optBy_2.Checked = False
		Me._optBy_2.Visible = True
		Me._optBy_2.Name = "_optBy_2"
		Me._optBy_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_0.Text = "BYMONTH"
		Me._optBy_0.Size = New System.Drawing.Size(81, 17)
		Me._optBy_0.Location = New System.Drawing.Point(64, 248)
		Me._optBy_0.TabIndex = 16
		Me._optBy_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBy_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_0.BackColor = System.Drawing.SystemColors.Control
		Me._optBy_0.CausesValidation = True
		Me._optBy_0.Enabled = True
		Me._optBy_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBy_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBy_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBy_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optBy_0.TabStop = True
		Me._optBy_0.Checked = False
		Me._optBy_0.Visible = True
		Me._optBy_0.Name = "_optBy_0"
		Me._optBy_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.Text = "BYQUARTER"
		Me._optBy_1.Size = New System.Drawing.Size(97, 17)
		Me._optBy_1.Location = New System.Drawing.Point(64, 282)
		Me._optBy_1.TabIndex = 18
		Me._optBy_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBy_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.BackColor = System.Drawing.SystemColors.Control
		Me._optBy_1.CausesValidation = True
		Me._optBy_1.Enabled = True
		Me._optBy_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBy_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBy_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBy_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optBy_1.TabStop = True
		Me._optBy_1.Checked = False
		Me._optBy_1.Visible = True
		Me._optBy_1.Name = "_optBy_1"
		Me.fraRange.Text = "RANGE"
		Me.fraRange.Size = New System.Drawing.Size(212, 41)
		Me.fraRange.Location = New System.Drawing.Point(56, 232)
		Me.fraRange.TabIndex = 33
		Me.fraRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraRange.BackColor = System.Drawing.SystemColors.Control
		Me.fraRange.Enabled = True
		Me.fraRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraRange.Visible = True
		Me.fraRange.Padding = New System.Windows.Forms.Padding(0)
		Me.fraRange.Name = "fraRange"
		Me.Frame2.Size = New System.Drawing.Size(212, 41)
		Me.Frame2.Location = New System.Drawing.Point(56, 264)
		Me.Frame2.TabIndex = 34
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Frame3.Size = New System.Drawing.Size(212, 41)
		Me.Frame3.Location = New System.Drawing.Point(56, 296)
		Me.Frame3.TabIndex = 35
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.lblCusNoFr.Text = "CUSNOFR"
		Me.lblCusNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblCusNoFr.Location = New System.Drawing.Point(56, 180)
		Me.lblCusNoFr.TabIndex = 37
		Me.lblCusNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNoFr.Enabled = True
		Me.lblCusNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNoFr.UseMnemonic = True
		Me.lblCusNoFr.Visible = True
		Me.lblCusNoFr.AutoSize = False
		Me.lblCusNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNoFr.Name = "lblCusNoFr"
		Me.lblCusNoTo.Text = "CUSNOTO"
		Me.lblCusNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblCusNoTo.Location = New System.Drawing.Point(326, 180)
		Me.lblCusNoTo.TabIndex = 36
		Me.lblCusNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNoTo.Enabled = True
		Me.lblCusNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNoTo.UseMnemonic = True
		Me.lblCusNoTo.Visible = True
		Me.lblCusNoTo.AutoSize = False
		Me.lblCusNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNoTo.Name = "lblCusNoTo"
		Me.lblAccTypeCodeFr.Text = "ACCTYPECODEFR"
		Me.lblAccTypeCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblAccTypeCodeFr.Location = New System.Drawing.Point(56, 155)
		Me.lblAccTypeCodeFr.TabIndex = 32
		Me.lblAccTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeCodeFr.Enabled = True
		Me.lblAccTypeCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeCodeFr.UseMnemonic = True
		Me.lblAccTypeCodeFr.Visible = True
		Me.lblAccTypeCodeFr.AutoSize = False
		Me.lblAccTypeCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeCodeFr.Name = "lblAccTypeCodeFr"
		Me.lblAccTypeCodeTo.Text = "ACCTYPECODETO"
		Me.lblAccTypeCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblAccTypeCodeTo.Location = New System.Drawing.Point(326, 155)
		Me.lblAccTypeCodeTo.TabIndex = 31
		Me.lblAccTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeCodeTo.Enabled = True
		Me.lblAccTypeCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeCodeTo.UseMnemonic = True
		Me.lblAccTypeCodeTo.Visible = True
		Me.lblAccTypeCodeTo.AutoSize = False
		Me.lblAccTypeCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeCodeTo.Name = "lblAccTypeCodeTo"
		Me.lblLevelCodeFr.Text = "LEVELCODEFR"
		Me.lblLevelCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblLevelCodeFr.Location = New System.Drawing.Point(56, 131)
		Me.lblLevelCodeFr.TabIndex = 30
		Me.lblLevelCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLevelCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLevelCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblLevelCodeFr.Enabled = True
		Me.lblLevelCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLevelCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLevelCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLevelCodeFr.UseMnemonic = True
		Me.lblLevelCodeFr.Visible = True
		Me.lblLevelCodeFr.AutoSize = False
		Me.lblLevelCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLevelCodeFr.Name = "lblLevelCodeFr"
		Me.lblLevelCodeTo.Text = "LEVELCODETO"
		Me.lblLevelCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblLevelCodeTo.Location = New System.Drawing.Point(326, 131)
		Me.lblLevelCodeTo.TabIndex = 29
		Me.lblLevelCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLevelCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLevelCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblLevelCodeTo.Enabled = True
		Me.lblLevelCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLevelCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLevelCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLevelCodeTo.UseMnemonic = True
		Me.lblLevelCodeTo.Visible = True
		Me.lblLevelCodeTo.AutoSize = False
		Me.lblLevelCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLevelCodeTo.Name = "lblLevelCodeTo"
		Me.lblItmTypeCodeFr.Text = "ITMTYPECODEFR"
		Me.lblItmTypeCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmTypeCodeFr.Location = New System.Drawing.Point(56, 107)
		Me.lblItmTypeCodeFr.TabIndex = 28
		Me.lblItmTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeCodeFr.Enabled = True
		Me.lblItmTypeCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeCodeFr.UseMnemonic = True
		Me.lblItmTypeCodeFr.Visible = True
		Me.lblItmTypeCodeFr.AutoSize = False
		Me.lblItmTypeCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeCodeFr.Name = "lblItmTypeCodeFr"
		Me.lblItmTypeCodeTo.Text = "ITMTYPECODETO"
		Me.lblItmTypeCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmTypeCodeTo.Location = New System.Drawing.Point(326, 107)
		Me.lblItmTypeCodeTo.TabIndex = 27
		Me.lblItmTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeCodeTo.Enabled = True
		Me.lblItmTypeCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeCodeTo.UseMnemonic = True
		Me.lblItmTypeCodeTo.Visible = True
		Me.lblItmTypeCodeTo.AutoSize = False
		Me.lblItmTypeCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeCodeTo.Name = "lblItmTypeCodeTo"
		Me.lblItmCodeTo.Text = "ITMCODETO"
		Me.lblItmCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmCodeTo.Location = New System.Drawing.Point(326, 83)
		Me.lblItmCodeTo.TabIndex = 26
		Me.lblItmCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCodeTo.Enabled = True
		Me.lblItmCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCodeTo.UseMnemonic = True
		Me.lblItmCodeTo.Visible = True
		Me.lblItmCodeTo.AutoSize = False
		Me.lblItmCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCodeTo.Name = "lblItmCodeTo"
		Me.lblItmCodeFr.Text = "ITMCODEFR"
		Me.lblItmCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmCodeFr.Location = New System.Drawing.Point(56, 83)
		Me.lblItmCodeFr.TabIndex = 25
		Me.lblItmCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCodeFr.Enabled = True
		Me.lblItmCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCodeFr.UseMnemonic = True
		Me.lblItmCodeFr.Visible = True
		Me.lblItmCodeFr.AutoSize = False
		Me.lblItmCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCodeFr.Name = "lblItmCodeFr"
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(58, 51)
		Me.lblTitle.TabIndex = 23
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.Enabled = True
		Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(fraSelect)
		Me.Controls.Add(cboCusNoFr)
		Me.Controls.Add(cboCusNoTo)
		Me.Controls.Add(cboAccTypeCodeFr)
		Me.Controls.Add(cboAccTypeCodeTo)
		Me.Controls.Add(cboLevelCodeFr)
		Me.Controls.Add(cboLevelCodeTo)
		Me.Controls.Add(cboItmTypeCodeFr)
		Me.Controls.Add(cboItmTypeCodeTo)
		Me.Controls.Add(cboItmCodeTo)
		Me.Controls.Add(cboItmCodeFr)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(txtPayYear)
		Me.Controls.Add(txtPayQuarter)
		Me.Controls.Add(txtPayMonth)
		Me.Controls.Add(_optBy_2)
		Me.Controls.Add(_optBy_0)
		Me.Controls.Add(_optBy_1)
		Me.Controls.Add(fraRange)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(lblCusNoFr)
		Me.Controls.Add(lblCusNoTo)
		Me.Controls.Add(lblAccTypeCodeFr)
		Me.Controls.Add(lblAccTypeCodeTo)
		Me.Controls.Add(lblLevelCodeFr)
		Me.Controls.Add(lblLevelCodeTo)
		Me.Controls.Add(lblItmTypeCodeFr)
		Me.Controls.Add(lblItmTypeCodeTo)
		Me.Controls.Add(lblItmCodeTo)
		Me.Controls.Add(lblItmCodeFr)
		Me.Controls.Add(lblTitle)
		Me.fraSelect.Controls.Add(_optSel_4)
		Me.fraSelect.Controls.Add(_optSel_3)
		Me.fraSelect.Controls.Add(_optSel_2)
		Me.fraSelect.Controls.Add(_optSel_1)
		Me.fraSelect.Controls.Add(_optSel_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optBy.SetIndex(_optBy_2, CType(2, Short))
		Me.optBy.SetIndex(_optBy_0, CType(0, Short))
		Me.optBy.SetIndex(_optBy_1, CType(1, Short))
		Me.optSel.SetIndex(_optSel_4, CType(4, Short))
		Me.optSel.SetIndex(_optSel_3, CType(3, Short))
		Me.optSel.SetIndex(_optSel_2, CType(2, Short))
		Me.optSel.SetIndex(_optSel_1, CType(1, Short))
		Me.optSel.SetIndex(_optSel_0, CType(0, Short))
		CType(Me.optSel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraSelect.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class