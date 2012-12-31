<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAPV001
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
	Public WithEvents cboVdrNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents _optDocType_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optDocType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optDocType_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents medPrdTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblVdrNoFr As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents lblVdrNoTo As System.Windows.Forms.Label
	Public WithEvents lblPrdTo As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button13 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button14 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	Public WithEvents optDocType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAPV001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboVdrNoFr = New System.Windows.Forms.ComboBox
		Me.cboVdrNoTo = New System.Windows.Forms.ComboBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me._optDocType_2 = New System.Windows.Forms.RadioButton
		Me._optDocType_1 = New System.Windows.Forms.RadioButton
		Me._optDocType_0 = New System.Windows.Forms.RadioButton
		Me.medPrdTo = New System.Windows.Forms.MaskedTextBox
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.lblVdrNoFr = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.lblVdrNoTo = New System.Windows.Forms.Label
		Me.lblPrdTo = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button13 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button14 = New System.Windows.Forms.ToolStripButton
		Me.lblDspItmDesc = New System.Windows.Forms.Label
		Me.optDocType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.fraSelect.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optDocType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Stock Reserve"
		Me.ClientSize = New System.Drawing.Size(794, 575)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmAPV001.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAPV001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(624, 200)
		Me.tblCommon.TabIndex = 9
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboVdrNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoFr.Location = New System.Drawing.Point(120, 64)
		Me.cboVdrNoFr.TabIndex = 2
		Me.cboVdrNoFr.Text = "Combo1"
		Me.cboVdrNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoFr.CausesValidation = True
		Me.cboVdrNoFr.Enabled = True
		Me.cboVdrNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoFr.IntegralHeight = True
		Me.cboVdrNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoFr.Sorted = False
		Me.cboVdrNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoFr.TabStop = True
		Me.cboVdrNoFr.Visible = True
		Me.cboVdrNoFr.Name = "cboVdrNoFr"
		Me.cboVdrNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoTo.Location = New System.Drawing.Point(352, 64)
		Me.cboVdrNoTo.TabIndex = 3
		Me.cboVdrNoTo.Text = "Combo1"
		Me.cboVdrNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoTo.CausesValidation = True
		Me.cboVdrNoTo.Enabled = True
		Me.cboVdrNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoTo.IntegralHeight = True
		Me.cboVdrNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoTo.Sorted = False
		Me.cboVdrNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoTo.TabStop = True
		Me.cboVdrNoTo.Visible = True
		Me.cboVdrNoTo.Name = "cboVdrNoTo"
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(120, 40)
		Me.cboDocNoFr.TabIndex = 0
		Me.cboDocNoFr.Text = "Combo1"
		Me.cboDocNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNoFr.CausesValidation = True
		Me.cboDocNoFr.Enabled = True
		Me.cboDocNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNoFr.IntegralHeight = True
		Me.cboDocNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNoFr.Sorted = False
		Me.cboDocNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNoFr.TabStop = True
		Me.cboDocNoFr.Visible = True
		Me.cboDocNoFr.Name = "cboDocNoFr"
		Me.cboDocNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoTo.Location = New System.Drawing.Point(352, 40)
		Me.cboDocNoTo.TabIndex = 1
		Me.cboDocNoTo.Text = "Combo1"
		Me.cboDocNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNoTo.CausesValidation = True
		Me.cboDocNoTo.Enabled = True
		Me.cboDocNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNoTo.IntegralHeight = True
		Me.cboDocNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNoTo.Sorted = False
		Me.cboDocNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNoTo.TabStop = True
		Me.cboDocNoTo.Visible = True
		Me.cboDocNoTo.Name = "cboDocNoTo"
		Me.Frame1.Size = New System.Drawing.Size(785, 89)
		Me.Frame1.Location = New System.Drawing.Point(0, 24)
		Me.Frame1.TabIndex = 10
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.fraSelect.Size = New System.Drawing.Size(289, 35)
		Me.fraSelect.Location = New System.Drawing.Point(488, 8)
		Me.fraSelect.TabIndex = 19
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me._optDocType_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_2.Text = "SO"
		Me._optDocType_2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optDocType_2.Size = New System.Drawing.Size(81, 17)
		Me._optDocType_2.Location = New System.Drawing.Point(200, 14)
		Me._optDocType_2.TabIndex = 20
		Me._optDocType_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_2.BackColor = System.Drawing.SystemColors.Control
		Me._optDocType_2.CausesValidation = True
		Me._optDocType_2.Enabled = True
		Me._optDocType_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optDocType_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optDocType_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optDocType_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optDocType_2.TabStop = True
		Me._optDocType_2.Checked = False
		Me._optDocType_2.Visible = True
		Me._optDocType_2.Name = "_optDocType_2"
		Me._optDocType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_1.Text = "SO"
		Me._optDocType_1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optDocType_1.Size = New System.Drawing.Size(81, 17)
		Me._optDocType_1.Location = New System.Drawing.Point(104, 14)
		Me._optDocType_1.TabIndex = 7
		Me._optDocType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optDocType_1.CausesValidation = True
		Me._optDocType_1.Enabled = True
		Me._optDocType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optDocType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optDocType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optDocType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optDocType_1.TabStop = True
		Me._optDocType_1.Checked = False
		Me._optDocType_1.Visible = True
		Me._optDocType_1.Name = "_optDocType_1"
		Me._optDocType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_0.Text = "SN"
		Me._optDocType_0.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optDocType_0.Size = New System.Drawing.Size(89, 17)
		Me._optDocType_0.Location = New System.Drawing.Point(8, 14)
		Me._optDocType_0.TabIndex = 6
		Me._optDocType_0.Checked = True
		Me._optDocType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optDocType_0.CausesValidation = True
		Me._optDocType_0.Enabled = True
		Me._optDocType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optDocType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optDocType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optDocType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optDocType_0.TabStop = True
		Me._optDocType_0.Visible = True
		Me._optDocType_0.Name = "_optDocType_0"
		Me.medPrdTo.AllowPromptAsInput = False
		Me.medPrdTo.Size = New System.Drawing.Size(73, 19)
		Me.medPrdTo.Location = New System.Drawing.Point(352, 62)
		Me.medPrdTo.TabIndex = 5
		Me.medPrdTo.MaxLength = 7
		Me.medPrdTo.Mask = "####/##"
		Me.medPrdTo.PromptChar = "_"
		Me.medPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdTo.Name = "medPrdTo"
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(120, 62)
		Me.medPrdFr.TabIndex = 4
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.lblVdrNoFr.Text = "Customer Code From"
		Me.lblVdrNoFr.Size = New System.Drawing.Size(110, 15)
		Me.lblVdrNoFr.Location = New System.Drawing.Point(8, 41)
		Me.lblVdrNoFr.TabIndex = 16
		Me.lblVdrNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoFr.Enabled = True
		Me.lblVdrNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoFr.UseMnemonic = True
		Me.lblVdrNoFr.Visible = True
		Me.lblVdrNoFr.AutoSize = False
		Me.lblVdrNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoFr.Name = "lblVdrNoFr"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(126, 15)
		Me.lblPrdFr.Location = New System.Drawing.Point(8, 66)
		Me.lblPrdFr.TabIndex = 15
		Me.lblPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdFr.Enabled = True
		Me.lblPrdFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdFr.UseMnemonic = True
		Me.lblPrdFr.Visible = True
		Me.lblPrdFr.AutoSize = False
		Me.lblPrdFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdFr.Name = "lblPrdFr"
		Me.lblVdrNoTo.Text = "To"
		Me.lblVdrNoTo.Size = New System.Drawing.Size(73, 15)
		Me.lblVdrNoTo.Location = New System.Drawing.Point(272, 42)
		Me.lblVdrNoTo.TabIndex = 14
		Me.lblVdrNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoTo.Enabled = True
		Me.lblVdrNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoTo.UseMnemonic = True
		Me.lblVdrNoTo.Visible = True
		Me.lblVdrNoTo.AutoSize = False
		Me.lblVdrNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoTo.Name = "lblVdrNoTo"
		Me.lblPrdTo.Text = "To"
		Me.lblPrdTo.Size = New System.Drawing.Size(73, 15)
		Me.lblPrdTo.Location = New System.Drawing.Point(272, 66)
		Me.lblPrdTo.TabIndex = 13
		Me.lblPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdTo.Enabled = True
		Me.lblPrdTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdTo.UseMnemonic = True
		Me.lblPrdTo.Visible = True
		Me.lblPrdTo.AutoSize = False
		Me.lblPrdTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdTo.Name = "lblPrdTo"
		Me.lblDocNoTo.Text = "To"
		Me.lblDocNoTo.Size = New System.Drawing.Size(73, 15)
		Me.lblDocNoTo.Location = New System.Drawing.Point(272, 17)
		Me.lblDocNoTo.TabIndex = 12
		Me.lblDocNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNoTo.Enabled = True
		Me.lblDocNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNoTo.UseMnemonic = True
		Me.lblDocNoTo.Visible = True
		Me.lblDocNoTo.AutoSize = False
		Me.lblDocNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNoTo.Name = "lblDocNoTo"
		Me.lblDocNoFr.Text = "Document # From"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNoFr.Location = New System.Drawing.Point(8, 17)
		Me.lblDocNoFr.TabIndex = 11
		Me.lblDocNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNoFr.Enabled = True
		Me.lblDocNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNoFr.UseMnemonic = True
		Me.lblDocNoFr.Visible = True
		Me.lblDocNoFr.AutoSize = False
		Me.lblDocNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNoFr.Name = "lblDocNoFr"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(785, 425)
		Me.tblDetail.Location = New System.Drawing.Point(8, 120)
		Me.tblDetail.TabIndex = 8
		Me.tblDetail.Name = "tblDetail"
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
		Me.iglProcess.Images.SetKeyName(7, "")
		Me.iglProcess.Images.SetKeyName(8, "")
		Me.iglProcess.Images.SetKeyName(9, "")
		Me.iglProcess.Images.SetKeyName(10, "")
		Me.iglProcess.Images.SetKeyName(11, "")
		Me.iglProcess.Images.SetKeyName(12, "")
		Me.iglProcess.Images.SetKeyName(13, "")
		Me.iglProcess.Images.SetKeyName(14, "")
		Me.iglProcess.Images.SetKeyName(15, "")
		Me.iglProcess.Images.SetKeyName(16, "")
		Me.iglProcess.Images.SetKeyName(17, "")
		Me.iglProcess.Images.SetKeyName(18, "")
		Me.iglProcess.Images.SetKeyName(19, "")
		Me.iglProcess.Images.SetKeyName(20, "")
		Me.iglProcess.Images.SetKeyName(21, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 18
		Me.tbrProcess.ImageList = iglProcess
		Me.tbrProcess.Name = "tbrProcess"
		Me._tbrProcess_Button1.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button1.AutoSize = False
		Me._tbrProcess_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button1.ImageIndex = 4
		Me._tbrProcess_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button2.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button2.AutoSize = False
		Me._tbrProcess_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button2.Name = "Can"
		Me._tbrProcess_Button2.ImageIndex = 15
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Copy"
		Me._tbrProcess_Button3.ImageIndex = 16
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Finish"
		Me._tbrProcess_Button4.ImageIndex = 20
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Export"
		Me._tbrProcess_Button5.ImageIndex = 21
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.Name = "Cancel"
		Me._tbrProcess_Button7.ToolTipText = "取消 (F3)"
		Me._tbrProcess_Button7.ImageIndex = 4
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Visible = 0
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.Name = "Exit"
		Me._tbrProcess_Button9.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button9.ImageIndex = 8
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Name = "SAll"
		Me._tbrProcess_Button11.ImageIndex = 17
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "DAll"
		Me._tbrProcess_Button12.ImageIndex = 18
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button13.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button13.AutoSize = False
		Me._tbrProcess_Button13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button14.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button14.AutoSize = False
		Me._tbrProcess_Button14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button14.Name = "Refresh"
		Me._tbrProcess_Button14.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button14.ImageIndex = 7
		Me._tbrProcess_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblDspItmDesc.Size = New System.Drawing.Size(777, 20)
		Me.lblDspItmDesc.Location = New System.Drawing.Point(8, 552)
		Me.lblDspItmDesc.TabIndex = 17
		Me.lblDspItmDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmDesc.Enabled = True
		Me.lblDspItmDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmDesc.UseMnemonic = True
		Me.lblDspItmDesc.Visible = True
		Me.lblDspItmDesc.AutoSize = False
		Me.lblDspItmDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmDesc.Name = "lblDspItmDesc"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboVdrNoFr)
		Me.Controls.Add(cboVdrNoTo)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspItmDesc)
		Me.Frame1.Controls.Add(fraSelect)
		Me.Frame1.Controls.Add(medPrdTo)
		Me.Frame1.Controls.Add(medPrdFr)
		Me.Frame1.Controls.Add(lblVdrNoFr)
		Me.Frame1.Controls.Add(lblPrdFr)
		Me.Frame1.Controls.Add(lblVdrNoTo)
		Me.Frame1.Controls.Add(lblPrdTo)
		Me.Frame1.Controls.Add(lblDocNoTo)
		Me.Frame1.Controls.Add(lblDocNoFr)
		Me.fraSelect.Controls.Add(_optDocType_2)
		Me.fraSelect.Controls.Add(_optDocType_1)
		Me.fraSelect.Controls.Add(_optDocType_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
		Me.tbrProcess.Items.Add(_tbrProcess_Button7)
		Me.tbrProcess.Items.Add(_tbrProcess_Button8)
		Me.tbrProcess.Items.Add(_tbrProcess_Button9)
		Me.tbrProcess.Items.Add(_tbrProcess_Button10)
		Me.tbrProcess.Items.Add(_tbrProcess_Button11)
		Me.tbrProcess.Items.Add(_tbrProcess_Button12)
		Me.tbrProcess.Items.Add(_tbrProcess_Button13)
		Me.tbrProcess.Items.Add(_tbrProcess_Button14)
		Me.optDocType.SetIndex(_optDocType_2, CType(2, Short))
		Me.optDocType.SetIndex(_optDocType_1, CType(1, Short))
		Me.optDocType.SetIndex(_optDocType_0, CType(0, Short))
		CType(Me.optDocType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.fraSelect.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class