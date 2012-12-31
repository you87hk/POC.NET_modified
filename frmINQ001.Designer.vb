<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmINQ001
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
	Public WithEvents cboItemNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItemNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboCusNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboCusNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents _optDocType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optDocType_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents lblItemNoTo As System.Windows.Forms.Label
	Public WithEvents lblItemNoFr As System.Windows.Forms.Label
	Public WithEvents lblCusNoFr As System.Windows.Forms.Label
	Public WithEvents lblCusNoTo As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspNetAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspGrsAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspTotalQty As System.Windows.Forms.Label
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	Public WithEvents optDocType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmINQ001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItemNoFr = New System.Windows.Forms.ComboBox
		Me.cboItemNoTo = New System.Windows.Forms.ComboBox
		Me.cboCusNoFr = New System.Windows.Forms.ComboBox
		Me.cboCusNoTo = New System.Windows.Forms.ComboBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me._optDocType_1 = New System.Windows.Forms.RadioButton
		Me._optDocType_0 = New System.Windows.Forms.RadioButton
		Me.lblItemNoTo = New System.Windows.Forms.Label
		Me.lblItemNoFr = New System.Windows.Forms.Label
		Me.lblCusNoFr = New System.Windows.Forms.Label
		Me.lblCusNoTo = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me.lblDspNetAmtOrg = New System.Windows.Forms.Label
		Me.lblDspGrsAmtOrg = New System.Windows.Forms.Label
		Me.lblDspTotalQty = New System.Windows.Forms.Label
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
		Me.Icon = CType(resources.GetObject("frmINQ001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmINQ001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(624, 200)
		Me.tblCommon.TabIndex = 7
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItemNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItemNoFr.Location = New System.Drawing.Point(136, 88)
		Me.cboItemNoFr.TabIndex = 19
		Me.cboItemNoFr.Text = "Combo1"
		Me.cboItemNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItemNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItemNoFr.CausesValidation = True
		Me.cboItemNoFr.Enabled = True
		Me.cboItemNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItemNoFr.IntegralHeight = True
		Me.cboItemNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItemNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItemNoFr.Sorted = False
		Me.cboItemNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItemNoFr.TabStop = True
		Me.cboItemNoFr.Visible = True
		Me.cboItemNoFr.Name = "cboItemNoFr"
		Me.cboItemNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItemNoTo.Location = New System.Drawing.Point(368, 88)
		Me.cboItemNoTo.TabIndex = 18
		Me.cboItemNoTo.Text = "Combo1"
		Me.cboItemNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItemNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItemNoTo.CausesValidation = True
		Me.cboItemNoTo.Enabled = True
		Me.cboItemNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItemNoTo.IntegralHeight = True
		Me.cboItemNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItemNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItemNoTo.Sorted = False
		Me.cboItemNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItemNoTo.TabStop = True
		Me.cboItemNoTo.Visible = True
		Me.cboItemNoTo.Name = "cboItemNoTo"
		Me.cboCusNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoFr.Location = New System.Drawing.Point(136, 64)
		Me.cboCusNoFr.TabIndex = 2
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
		Me.cboCusNoTo.Location = New System.Drawing.Point(368, 64)
		Me.cboCusNoTo.TabIndex = 3
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
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(136, 40)
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
		Me.cboDocNoTo.Location = New System.Drawing.Point(368, 40)
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
		Me.Frame1.Size = New System.Drawing.Size(785, 97)
		Me.Frame1.Location = New System.Drawing.Point(8, 24)
		Me.Frame1.TabIndex = 8
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.fraSelect.Size = New System.Drawing.Size(265, 35)
		Me.fraSelect.Location = New System.Drawing.Point(488, 8)
		Me.fraSelect.TabIndex = 15
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me._optDocType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_1.Text = "SO"
		Me._optDocType_1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optDocType_1.Size = New System.Drawing.Size(89, 17)
		Me._optDocType_1.Location = New System.Drawing.Point(136, 14)
		Me._optDocType_1.TabIndex = 5
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
		Me._optDocType_0.Size = New System.Drawing.Size(97, 17)
		Me._optDocType_0.Location = New System.Drawing.Point(8, 14)
		Me._optDocType_0.TabIndex = 4
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
		Me.lblItemNoTo.Text = "To"
		Me.lblItemNoTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItemNoTo.Location = New System.Drawing.Point(272, 65)
		Me.lblItemNoTo.TabIndex = 17
		Me.lblItemNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItemNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItemNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItemNoTo.Enabled = True
		Me.lblItemNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItemNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItemNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItemNoTo.UseMnemonic = True
		Me.lblItemNoTo.Visible = True
		Me.lblItemNoTo.AutoSize = False
		Me.lblItemNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItemNoTo.Name = "lblItemNoTo"
		Me.lblItemNoFr.Text = "Customer Code From"
		Me.lblItemNoFr.Size = New System.Drawing.Size(110, 15)
		Me.lblItemNoFr.Location = New System.Drawing.Point(8, 64)
		Me.lblItemNoFr.TabIndex = 16
		Me.lblItemNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItemNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItemNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItemNoFr.Enabled = True
		Me.lblItemNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItemNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItemNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItemNoFr.UseMnemonic = True
		Me.lblItemNoFr.Visible = True
		Me.lblItemNoFr.AutoSize = False
		Me.lblItemNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItemNoFr.Name = "lblItemNoFr"
		Me.lblCusNoFr.Text = "Customer Code From"
		Me.lblCusNoFr.Size = New System.Drawing.Size(110, 15)
		Me.lblCusNoFr.Location = New System.Drawing.Point(8, 41)
		Me.lblCusNoFr.TabIndex = 12
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
		Me.lblCusNoTo.Text = "To"
		Me.lblCusNoTo.Size = New System.Drawing.Size(73, 15)
		Me.lblCusNoTo.Location = New System.Drawing.Point(272, 42)
		Me.lblCusNoTo.TabIndex = 11
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
		Me.lblDocNoTo.Text = "To"
		Me.lblDocNoTo.Size = New System.Drawing.Size(73, 15)
		Me.lblDocNoTo.Location = New System.Drawing.Point(272, 17)
		Me.lblDocNoTo.TabIndex = 10
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
		Me.lblDocNoFr.TabIndex = 9
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
		Me.tblDetail.Size = New System.Drawing.Size(785, 417)
		Me.tblDetail.Location = New System.Drawing.Point(8, 128)
		Me.tblDetail.TabIndex = 6
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
		Me.iglProcess.Images.SetKeyName(22, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 14
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
		Me._tbrProcess_Button2.Name = "Cancel"
		Me._tbrProcess_Button2.ToolTipText = "取消 (F3)"
		Me._tbrProcess_Button2.ImageIndex = 4
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Visible = 0
		Me._tbrProcess_Button3.Name = "Print"
		Me._tbrProcess_Button3.ImageIndex = 9
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Exit"
		Me._tbrProcess_Button4.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button4.ImageIndex = 8
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Refresh"
		Me._tbrProcess_Button6.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button6.ImageIndex = 7
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblDspNetAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspNetAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspNetAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspNetAmtOrg.ForeColor = System.Drawing.Color.Blue
		Me.lblDspNetAmtOrg.Size = New System.Drawing.Size(94, 23)
		Me.lblDspNetAmtOrg.Location = New System.Drawing.Point(696, 552)
		Me.lblDspNetAmtOrg.TabIndex = 22
		Me.lblDspNetAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspNetAmtOrg.Enabled = True
		Me.lblDspNetAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspNetAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspNetAmtOrg.UseMnemonic = True
		Me.lblDspNetAmtOrg.Visible = True
		Me.lblDspNetAmtOrg.AutoSize = False
		Me.lblDspNetAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspNetAmtOrg.Name = "lblDspNetAmtOrg"
		Me.lblDspGrsAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspGrsAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspGrsAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspGrsAmtOrg.Size = New System.Drawing.Size(86, 23)
		Me.lblDspGrsAmtOrg.Location = New System.Drawing.Point(608, 552)
		Me.lblDspGrsAmtOrg.TabIndex = 21
		Me.lblDspGrsAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspGrsAmtOrg.Enabled = True
		Me.lblDspGrsAmtOrg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspGrsAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspGrsAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspGrsAmtOrg.UseMnemonic = True
		Me.lblDspGrsAmtOrg.Visible = True
		Me.lblDspGrsAmtOrg.AutoSize = False
		Me.lblDspGrsAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspGrsAmtOrg.Name = "lblDspGrsAmtOrg"
		Me.lblDspTotalQty.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDspTotalQty.Text = "9.999.999.999.99"
		Me.lblDspTotalQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspTotalQty.ForeColor = System.Drawing.Color.Blue
		Me.lblDspTotalQty.Size = New System.Drawing.Size(54, 23)
		Me.lblDspTotalQty.Location = New System.Drawing.Point(552, 552)
		Me.lblDspTotalQty.TabIndex = 20
		Me.lblDspTotalQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspTotalQty.Enabled = True
		Me.lblDspTotalQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspTotalQty.UseMnemonic = True
		Me.lblDspTotalQty.Visible = True
		Me.lblDspTotalQty.AutoSize = False
		Me.lblDspTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspTotalQty.Name = "lblDspTotalQty"
		Me.lblDspItmDesc.Size = New System.Drawing.Size(543, 23)
		Me.lblDspItmDesc.Location = New System.Drawing.Point(8, 552)
		Me.lblDspItmDesc.TabIndex = 13
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
		Me.Controls.Add(cboItemNoFr)
		Me.Controls.Add(cboItemNoTo)
		Me.Controls.Add(cboCusNoFr)
		Me.Controls.Add(cboCusNoTo)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspNetAmtOrg)
		Me.Controls.Add(lblDspGrsAmtOrg)
		Me.Controls.Add(lblDspTotalQty)
		Me.Controls.Add(lblDspItmDesc)
		Me.Frame1.Controls.Add(fraSelect)
		Me.Frame1.Controls.Add(lblItemNoTo)
		Me.Frame1.Controls.Add(lblItemNoFr)
		Me.Frame1.Controls.Add(lblCusNoFr)
		Me.Frame1.Controls.Add(lblCusNoTo)
		Me.Frame1.Controls.Add(lblDocNoTo)
		Me.Frame1.Controls.Add(lblDocNoFr)
		Me.fraSelect.Controls.Add(_optDocType_1)
		Me.fraSelect.Controls.Add(_optDocType_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
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