<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMRP001
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
	Public WithEvents cboItmTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmBarCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmBarCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents txtQtyLvlTo As System.Windows.Forms.TextBox
	Public WithEvents txtQtyLvlFr As System.Windows.Forms.TextBox
	Public WithEvents _optType_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optType_1 As System.Windows.Forms.RadioButton
	Public WithEvents lblQtyLvlTo As System.Windows.Forms.Label
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents lblItmTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeFr As System.Windows.Forms.Label
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
	Public WithEvents optType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMRP001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItmTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmBarCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmBarCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmCodeTo = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me.txtQtyLvlTo = New System.Windows.Forms.TextBox
		Me.txtQtyLvlFr = New System.Windows.Forms.TextBox
		Me._optType_0 = New System.Windows.Forms.RadioButton
		Me._optType_1 = New System.Windows.Forms.RadioButton
		Me.lblQtyLvlTo = New System.Windows.Forms.Label
		Me.lblItmTypeCodeTo = New System.Windows.Forms.Label
		Me.lblItmTypeCodeFr = New System.Windows.Forms.Label
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
		Me.optType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.fraSelect.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Stock Reserve"
		Me.ClientSize = New System.Drawing.Size(794, 575)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmMRP001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmMRP001"
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
		Me.cboItmTypeCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCodeFr.Location = New System.Drawing.Point(168, 88)
		Me.cboItmTypeCodeFr.TabIndex = 4
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
		Me.cboItmTypeCodeTo.Location = New System.Drawing.Point(360, 88)
		Me.cboItmTypeCodeTo.TabIndex = 5
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
		Me.fraSelect.Size = New System.Drawing.Size(289, 83)
		Me.fraSelect.Location = New System.Drawing.Point(488, 8)
		Me.fraSelect.TabIndex = 17
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me.txtQtyLvlTo.AutoSize = False
		Me.txtQtyLvlTo.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtQtyLvlTo.Enabled = False
		Me.txtQtyLvlTo.Size = New System.Drawing.Size(49, 20)
		Me.txtQtyLvlTo.Location = New System.Drawing.Point(232, 48)
		Me.txtQtyLvlTo.TabIndex = 21
		Me.txtQtyLvlTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQtyLvlTo.AcceptsReturn = True
		Me.txtQtyLvlTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtQtyLvlTo.CausesValidation = True
		Me.txtQtyLvlTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQtyLvlTo.HideSelection = True
		Me.txtQtyLvlTo.ReadOnly = False
		Me.txtQtyLvlTo.Maxlength = 0
		Me.txtQtyLvlTo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQtyLvlTo.MultiLine = False
		Me.txtQtyLvlTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQtyLvlTo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQtyLvlTo.TabStop = True
		Me.txtQtyLvlTo.Visible = True
		Me.txtQtyLvlTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQtyLvlTo.Name = "txtQtyLvlTo"
		Me.txtQtyLvlFr.AutoSize = False
		Me.txtQtyLvlFr.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtQtyLvlFr.Enabled = False
		Me.txtQtyLvlFr.Size = New System.Drawing.Size(49, 20)
		Me.txtQtyLvlFr.Location = New System.Drawing.Point(144, 48)
		Me.txtQtyLvlFr.TabIndex = 20
		Me.txtQtyLvlFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQtyLvlFr.AcceptsReturn = True
		Me.txtQtyLvlFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtQtyLvlFr.CausesValidation = True
		Me.txtQtyLvlFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQtyLvlFr.HideSelection = True
		Me.txtQtyLvlFr.ReadOnly = False
		Me.txtQtyLvlFr.Maxlength = 0
		Me.txtQtyLvlFr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQtyLvlFr.MultiLine = False
		Me.txtQtyLvlFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQtyLvlFr.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQtyLvlFr.TabStop = True
		Me.txtQtyLvlFr.Visible = True
		Me.txtQtyLvlFr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQtyLvlFr.Name = "txtQtyLvlFr"
		Me._optType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optType_0.Text = "SN"
		Me._optType_0.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optType_0.Size = New System.Drawing.Size(209, 17)
		Me._optType_0.Location = New System.Drawing.Point(8, 16)
		Me._optType_0.TabIndex = 19
		Me._optType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optType_0.CausesValidation = True
		Me._optType_0.Enabled = True
		Me._optType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optType_0.TabStop = True
		Me._optType_0.Checked = False
		Me._optType_0.Visible = True
		Me._optType_0.Name = "_optType_0"
		Me._optType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optType_1.Text = "SO"
		Me._optType_1.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optType_1.Size = New System.Drawing.Size(129, 17)
		Me._optType_1.Location = New System.Drawing.Point(8, 48)
		Me._optType_1.TabIndex = 18
		Me._optType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optType_1.CausesValidation = True
		Me._optType_1.Enabled = True
		Me._optType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optType_1.TabStop = True
		Me._optType_1.Checked = False
		Me._optType_1.Visible = True
		Me._optType_1.Name = "_optType_1"
		Me.lblQtyLvlTo.Text = "To"
		Me.lblQtyLvlTo.Size = New System.Drawing.Size(25, 15)
		Me.lblQtyLvlTo.Location = New System.Drawing.Point(200, 48)
		Me.lblQtyLvlTo.TabIndex = 22
		Me.lblQtyLvlTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQtyLvlTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblQtyLvlTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblQtyLvlTo.Enabled = True
		Me.lblQtyLvlTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblQtyLvlTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblQtyLvlTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblQtyLvlTo.UseMnemonic = True
		Me.lblQtyLvlTo.Visible = True
		Me.lblQtyLvlTo.AutoSize = False
		Me.lblQtyLvlTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblQtyLvlTo.Name = "lblQtyLvlTo"
		Me.lblItmTypeCodeTo.Text = "To"
		Me.lblItmTypeCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmTypeCodeTo.Location = New System.Drawing.Point(304, 64)
		Me.lblItmTypeCodeTo.TabIndex = 16
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
		Me.lblItmTypeCodeFr.Text = "ItmTypeCode From"
		Me.lblItmTypeCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmTypeCodeFr.Location = New System.Drawing.Point(8, 64)
		Me.lblItmTypeCodeFr.TabIndex = 15
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
		Me.tblDetail.Size = New System.Drawing.Size(785, 417)
		Me.tblDetail.Location = New System.Drawing.Point(8, 128)
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
		Me.Controls.Add(cboItmTypeCodeFr)
		Me.Controls.Add(cboItmTypeCodeTo)
		Me.Controls.Add(cboItmBarCodeFr)
		Me.Controls.Add(cboItmBarCodeTo)
		Me.Controls.Add(cboItmCodeFr)
		Me.Controls.Add(cboItmCodeTo)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspItmDesc)
		Me.Frame1.Controls.Add(fraSelect)
		Me.Frame1.Controls.Add(lblItmTypeCodeTo)
		Me.Frame1.Controls.Add(lblItmTypeCodeFr)
		Me.Frame1.Controls.Add(lblItmBarCodeFr)
		Me.Frame1.Controls.Add(lblItmBarCodeTo)
		Me.Frame1.Controls.Add(lblItmCodeTo)
		Me.Frame1.Controls.Add(lblItmCodeFr)
		Me.fraSelect.Controls.Add(txtQtyLvlTo)
		Me.fraSelect.Controls.Add(txtQtyLvlFr)
		Me.fraSelect.Controls.Add(_optType_0)
		Me.fraSelect.Controls.Add(_optType_1)
		Me.fraSelect.Controls.Add(lblQtyLvlTo)
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
		Me.optType.SetIndex(_optType_0, CType(0, Short))
		Me.optType.SetIndex(_optType_1, CType(1, Short))
		CType(Me.optType, System.ComponentModel.ISupportInitialize).EndInit()
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