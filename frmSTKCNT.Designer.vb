<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSTKCNT
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
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboWhsCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboWhsCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmBarCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmBarCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents _optShow_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optShow_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents lblWhsCodeTo As System.Windows.Forms.Label
	Public WithEvents lblWhsCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmBarCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmBarCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeFr As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	Public WithEvents optShow As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSTKCNT))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboWhsCodeFr = New System.Windows.Forms.ComboBox
		Me.cboWhsCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmBarCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmBarCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmCodeTo = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._optShow_0 = New System.Windows.Forms.RadioButton
		Me._optShow_1 = New System.Windows.Forms.RadioButton
		Me.lblWhsCodeTo = New System.Windows.Forms.Label
		Me.lblWhsCodeFr = New System.Windows.Forms.Label
		Me.lblItmBarCodeFr = New System.Windows.Forms.Label
		Me.lblItmBarCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeFr = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me.lblDspItmDesc = New System.Windows.Forms.Label
		Me.optShow = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optShow, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Stock Reserve"
		Me.ClientSize = New System.Drawing.Size(794, 575)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmSTKCNT.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSTKCNT"
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
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(624, 200)
		Me.tblCommon.TabIndex = 7
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboWhsCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboWhsCodeFr.Location = New System.Drawing.Point(168, 88)
		Me.cboWhsCodeFr.TabIndex = 4
		Me.cboWhsCodeFr.Text = "Combo1"
		Me.cboWhsCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWhsCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboWhsCodeFr.CausesValidation = True
		Me.cboWhsCodeFr.Enabled = True
		Me.cboWhsCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWhsCodeFr.IntegralHeight = True
		Me.cboWhsCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWhsCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWhsCodeFr.Sorted = False
		Me.cboWhsCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWhsCodeFr.TabStop = True
		Me.cboWhsCodeFr.Visible = True
		Me.cboWhsCodeFr.Name = "cboWhsCodeFr"
		Me.cboWhsCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboWhsCodeTo.Location = New System.Drawing.Point(360, 88)
		Me.cboWhsCodeTo.TabIndex = 5
		Me.cboWhsCodeTo.Text = "Combo1"
		Me.cboWhsCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWhsCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboWhsCodeTo.CausesValidation = True
		Me.cboWhsCodeTo.Enabled = True
		Me.cboWhsCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWhsCodeTo.IntegralHeight = True
		Me.cboWhsCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWhsCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWhsCodeTo.Sorted = False
		Me.cboWhsCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWhsCodeTo.TabStop = True
		Me.cboWhsCodeTo.Visible = True
		Me.cboWhsCodeTo.Name = "cboWhsCodeTo"
		Me.cboItmBarCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmBarCodeFr.Location = New System.Drawing.Point(168, 64)
		Me.cboItmBarCodeFr.TabIndex = 2
		Me.cboItmBarCodeFr.Text = "Combo1"
		Me.cboItmBarCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmBarCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmBarCodeFr.CausesValidation = True
		Me.cboItmBarCodeFr.Enabled = True
		Me.cboItmBarCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmBarCodeFr.IntegralHeight = True
		Me.cboItmBarCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmBarCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmBarCodeFr.Sorted = False
		Me.cboItmBarCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmBarCodeFr.TabStop = True
		Me.cboItmBarCodeFr.Visible = True
		Me.cboItmBarCodeFr.Name = "cboItmBarCodeFr"
		Me.cboItmBarCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmBarCodeTo.Location = New System.Drawing.Point(360, 64)
		Me.cboItmBarCodeTo.TabIndex = 3
		Me.cboItmBarCodeTo.Text = "Combo1"
		Me.cboItmBarCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmBarCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmBarCodeTo.CausesValidation = True
		Me.cboItmBarCodeTo.Enabled = True
		Me.cboItmBarCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmBarCodeTo.IntegralHeight = True
		Me.cboItmBarCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmBarCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmBarCodeTo.Sorted = False
		Me.cboItmBarCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmBarCodeTo.TabStop = True
		Me.cboItmBarCodeTo.Visible = True
		Me.cboItmBarCodeTo.Name = "cboItmBarCodeTo"
		Me.cboItmCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeFr.Location = New System.Drawing.Point(168, 40)
		Me.cboItmCodeFr.TabIndex = 0
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
		Me.cboItmCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeTo.Location = New System.Drawing.Point(360, 40)
		Me.cboItmCodeTo.TabIndex = 1
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
		Me.Frame1.Size = New System.Drawing.Size(785, 113)
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
		Me.Frame2.Size = New System.Drawing.Size(289, 43)
		Me.Frame2.Location = New System.Drawing.Point(488, 16)
		Me.Frame2.TabIndex = 17
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me._optShow_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optShow_0.Text = "SN"
		Me._optShow_0.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optShow_0.Size = New System.Drawing.Size(105, 17)
		Me._optShow_0.Location = New System.Drawing.Point(8, 16)
		Me._optShow_0.TabIndex = 19
		Me._optShow_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optShow_0.BackColor = System.Drawing.SystemColors.Control
		Me._optShow_0.CausesValidation = True
		Me._optShow_0.Enabled = True
		Me._optShow_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optShow_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optShow_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optShow_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optShow_0.TabStop = True
		Me._optShow_0.Checked = False
		Me._optShow_0.Visible = True
		Me._optShow_0.Name = "_optShow_0"
		Me._optShow_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optShow_1.Text = "SN"
		Me._optShow_1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optShow_1.Size = New System.Drawing.Size(113, 17)
		Me._optShow_1.Location = New System.Drawing.Point(144, 16)
		Me._optShow_1.TabIndex = 18
		Me._optShow_1.Checked = True
		Me._optShow_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optShow_1.BackColor = System.Drawing.SystemColors.Control
		Me._optShow_1.CausesValidation = True
		Me._optShow_1.Enabled = True
		Me._optShow_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optShow_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optShow_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optShow_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optShow_1.TabStop = True
		Me._optShow_1.Visible = True
		Me._optShow_1.Name = "_optShow_1"
		Me.lblWhsCodeTo.Text = "To"
		Me.lblWhsCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblWhsCodeTo.Location = New System.Drawing.Point(304, 64)
		Me.lblWhsCodeTo.TabIndex = 16
		Me.lblWhsCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsCodeTo.Enabled = True
		Me.lblWhsCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsCodeTo.UseMnemonic = True
		Me.lblWhsCodeTo.Visible = True
		Me.lblWhsCodeTo.AutoSize = False
		Me.lblWhsCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsCodeTo.Name = "lblWhsCodeTo"
		Me.lblWhsCodeFr.Text = "ItmTypeCode From"
		Me.lblWhsCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblWhsCodeFr.Location = New System.Drawing.Point(8, 64)
		Me.lblWhsCodeFr.TabIndex = 15
		Me.lblWhsCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsCodeFr.Enabled = True
		Me.lblWhsCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsCodeFr.UseMnemonic = True
		Me.lblWhsCodeFr.Visible = True
		Me.lblWhsCodeFr.AutoSize = False
		Me.lblWhsCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsCodeFr.Name = "lblWhsCodeFr"
		Me.lblItmBarCodeFr.Text = "Itm Barcode From"
		Me.lblItmBarCodeFr.Size = New System.Drawing.Size(110, 15)
		Me.lblItmBarCodeFr.Location = New System.Drawing.Point(8, 41)
		Me.lblItmBarCodeFr.TabIndex = 12
		Me.lblItmBarCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmBarCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmBarCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmBarCodeFr.Enabled = True
		Me.lblItmBarCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmBarCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmBarCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmBarCodeFr.UseMnemonic = True
		Me.lblItmBarCodeFr.Visible = True
		Me.lblItmBarCodeFr.AutoSize = False
		Me.lblItmBarCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmBarCodeFr.Name = "lblItmBarCodeFr"
		Me.lblItmBarCodeTo.Text = "To"
		Me.lblItmBarCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmBarCodeTo.Location = New System.Drawing.Point(304, 42)
		Me.lblItmBarCodeTo.TabIndex = 11
		Me.lblItmBarCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmBarCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmBarCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmBarCodeTo.Enabled = True
		Me.lblItmBarCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmBarCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmBarCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmBarCodeTo.UseMnemonic = True
		Me.lblItmBarCodeTo.Visible = True
		Me.lblItmBarCodeTo.AutoSize = False
		Me.lblItmBarCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmBarCodeTo.Name = "lblItmBarCodeTo"
		Me.lblItmCodeTo.Text = "To"
		Me.lblItmCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmCodeTo.Location = New System.Drawing.Point(304, 17)
		Me.lblItmCodeTo.TabIndex = 10
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
		Me.lblItmCodeFr.Text = "Itm # From"
		Me.lblItmCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmCodeFr.Location = New System.Drawing.Point(8, 17)
		Me.lblItmCodeFr.TabIndex = 9
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
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(785, 401)
		Me.tblDetail.Location = New System.Drawing.Point(8, 144)
		Me.tblDetail.TabIndex = 6
		Me.tblDetail.Name = "tblDetail"
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
		Me._tbrProcess_Button2.Visible = 0
		Me._tbrProcess_Button2.Name = "OK"
		Me._tbrProcess_Button2.ToolTipText = "選取 (F2)"
		Me._tbrProcess_Button2.ImageIndex = 18
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Print"
		Me._tbrProcess_Button3.ImageIndex = 20
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Cancel"
		Me._tbrProcess_Button5.ToolTipText = "取消 (F3)"
		Me._tbrProcess_Button5.ImageIndex = 4
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Visible = 0
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.Name = "Exit"
		Me._tbrProcess_Button7.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button7.ImageIndex = 8
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.Name = "SAll"
		Me._tbrProcess_Button9.ImageIndex = 17
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.Name = "DAll"
		Me._tbrProcess_Button10.ImageIndex = 19
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "Refresh"
		Me._tbrProcess_Button12.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button12.ImageIndex = 7
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblDspItmDesc.Size = New System.Drawing.Size(777, 20)
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
		Me.Controls.Add(cboWhsCodeFr)
		Me.Controls.Add(cboWhsCodeTo)
		Me.Controls.Add(cboItmBarCodeFr)
		Me.Controls.Add(cboItmBarCodeTo)
		Me.Controls.Add(cboItmCodeFr)
		Me.Controls.Add(cboItmCodeTo)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspItmDesc)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame1.Controls.Add(lblWhsCodeTo)
		Me.Frame1.Controls.Add(lblWhsCodeFr)
		Me.Frame1.Controls.Add(lblItmBarCodeFr)
		Me.Frame1.Controls.Add(lblItmBarCodeTo)
		Me.Frame1.Controls.Add(lblItmCodeTo)
		Me.Frame1.Controls.Add(lblItmCodeFr)
		Me.Frame2.Controls.Add(_optShow_0)
		Me.Frame2.Controls.Add(_optShow_1)
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
		Me.optShow.SetIndex(_optShow_0, CType(0, Short))
		Me.optShow.SetIndex(_optShow_1, CType(1, Short))
		CType(Me.optShow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class