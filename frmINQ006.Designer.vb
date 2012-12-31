<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmINQ006
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
	Public WithEvents cboWhsCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboWhsCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents cboItmTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmAccTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmAccTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents lblWhsCodeTo As System.Windows.Forms.Label
	Public WithEvents lblWhsCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmAccTypeCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmAccTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeFr As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmINQ006))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboWhsCodeTo = New System.Windows.Forms.ComboBox
		Me.cboWhsCodeFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.cboItmTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmAccTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmAccTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmCodeTo = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblWhsCodeTo = New System.Windows.Forms.Label
		Me.lblWhsCodeFr = New System.Windows.Forms.Label
		Me.lblItmTypeCodeTo = New System.Windows.Forms.Label
		Me.lblItmTypeCodeFr = New System.Windows.Forms.Label
		Me.lblItmAccTypeCodeFr = New System.Windows.Forms.Label
		Me.lblItmAccTypeCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeFr = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripButton
		Me.lblDspItmDesc = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Stock Reserve"
		Me.ClientSize = New System.Drawing.Size(794, 575)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmINQ006.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmINQ006"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(624, 200)
		Me.tblCommon.TabIndex = 9
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboWhsCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboWhsCodeTo.Location = New System.Drawing.Point(360, 112)
		Me.cboWhsCodeTo.TabIndex = 7
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
		Me.cboWhsCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboWhsCodeFr.Location = New System.Drawing.Point(168, 112)
		Me.cboWhsCodeFr.TabIndex = 6
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
		Me.cboItmAccTypeCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmAccTypeCodeFr.Location = New System.Drawing.Point(168, 64)
		Me.cboItmAccTypeCodeFr.TabIndex = 2
		Me.cboItmAccTypeCodeFr.Text = "Combo1"
		Me.cboItmAccTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmAccTypeCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmAccTypeCodeFr.CausesValidation = True
		Me.cboItmAccTypeCodeFr.Enabled = True
		Me.cboItmAccTypeCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmAccTypeCodeFr.IntegralHeight = True
		Me.cboItmAccTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmAccTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmAccTypeCodeFr.Sorted = False
		Me.cboItmAccTypeCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmAccTypeCodeFr.TabStop = True
		Me.cboItmAccTypeCodeFr.Visible = True
		Me.cboItmAccTypeCodeFr.Name = "cboItmAccTypeCodeFr"
		Me.cboItmAccTypeCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmAccTypeCodeTo.Location = New System.Drawing.Point(360, 64)
		Me.cboItmAccTypeCodeTo.TabIndex = 3
		Me.cboItmAccTypeCodeTo.Text = "Combo1"
		Me.cboItmAccTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmAccTypeCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmAccTypeCodeTo.CausesValidation = True
		Me.cboItmAccTypeCodeTo.Enabled = True
		Me.cboItmAccTypeCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmAccTypeCodeTo.IntegralHeight = True
		Me.cboItmAccTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmAccTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmAccTypeCodeTo.Sorted = False
		Me.cboItmAccTypeCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmAccTypeCodeTo.TabStop = True
		Me.cboItmAccTypeCodeTo.Visible = True
		Me.cboItmAccTypeCodeTo.Name = "cboItmAccTypeCodeTo"
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
		Me.Frame1.TabIndex = 10
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.lblWhsCodeTo.Text = "To"
		Me.lblWhsCodeTo.Size = New System.Drawing.Size(41, 15)
		Me.lblWhsCodeTo.Location = New System.Drawing.Point(304, 90)
		Me.lblWhsCodeTo.TabIndex = 20
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
		Me.lblWhsCodeFr.Text = "Period From"
		Me.lblWhsCodeFr.Size = New System.Drawing.Size(102, 15)
		Me.lblWhsCodeFr.Location = New System.Drawing.Point(8, 90)
		Me.lblWhsCodeFr.TabIndex = 19
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
		Me.lblItmTypeCodeTo.Text = "To"
		Me.lblItmTypeCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmTypeCodeTo.Location = New System.Drawing.Point(304, 64)
		Me.lblItmTypeCodeTo.TabIndex = 18
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
		Me.lblItmTypeCodeFr.TabIndex = 17
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
		Me.lblItmAccTypeCodeFr.Text = "Itm Barcode From"
		Me.lblItmAccTypeCodeFr.Size = New System.Drawing.Size(110, 15)
		Me.lblItmAccTypeCodeFr.Location = New System.Drawing.Point(8, 41)
		Me.lblItmAccTypeCodeFr.TabIndex = 14
		Me.lblItmAccTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmAccTypeCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmAccTypeCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmAccTypeCodeFr.Enabled = True
		Me.lblItmAccTypeCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmAccTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmAccTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmAccTypeCodeFr.UseMnemonic = True
		Me.lblItmAccTypeCodeFr.Visible = True
		Me.lblItmAccTypeCodeFr.AutoSize = False
		Me.lblItmAccTypeCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmAccTypeCodeFr.Name = "lblItmAccTypeCodeFr"
		Me.lblItmAccTypeCodeTo.Text = "To"
		Me.lblItmAccTypeCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmAccTypeCodeTo.Location = New System.Drawing.Point(304, 42)
		Me.lblItmAccTypeCodeTo.TabIndex = 13
		Me.lblItmAccTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmAccTypeCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmAccTypeCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmAccTypeCodeTo.Enabled = True
		Me.lblItmAccTypeCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmAccTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmAccTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmAccTypeCodeTo.UseMnemonic = True
		Me.lblItmAccTypeCodeTo.Visible = True
		Me.lblItmAccTypeCodeTo.AutoSize = False
		Me.lblItmAccTypeCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmAccTypeCodeTo.Name = "lblItmAccTypeCodeTo"
		Me.lblItmCodeTo.Text = "To"
		Me.lblItmCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmCodeTo.Location = New System.Drawing.Point(304, 17)
		Me.lblItmCodeTo.TabIndex = 12
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
		Me.lblItmCodeFr.TabIndex = 11
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
		Me.tblDetail.TabIndex = 8
		Me.tblDetail.Name = "tblDetail"
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 16
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
		Me._tbrProcess_Button2.Name = "Print"
		Me._tbrProcess_Button2.ImageIndex = 20
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Cancel"
		Me._tbrProcess_Button4.ToolTipText = "取消 (F3)"
		Me._tbrProcess_Button4.ImageIndex = 4
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Visible = 0
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Exit"
		Me._tbrProcess_Button6.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button6.ImageIndex = 8
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Refresh"
		Me._tbrProcess_Button8.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button8.ImageIndex = 7
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblDspItmDesc.Size = New System.Drawing.Size(777, 20)
		Me.lblDspItmDesc.Location = New System.Drawing.Point(8, 552)
		Me.lblDspItmDesc.TabIndex = 15
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
		Me.Controls.Add(cboWhsCodeTo)
		Me.Controls.Add(cboWhsCodeFr)
		Me.Controls.Add(cboItmTypeCodeFr)
		Me.Controls.Add(cboItmTypeCodeTo)
		Me.Controls.Add(cboItmAccTypeCodeFr)
		Me.Controls.Add(cboItmAccTypeCodeTo)
		Me.Controls.Add(cboItmCodeFr)
		Me.Controls.Add(cboItmCodeTo)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspItmDesc)
		Me.Frame1.Controls.Add(lblWhsCodeTo)
		Me.Frame1.Controls.Add(lblWhsCodeFr)
		Me.Frame1.Controls.Add(lblItmTypeCodeTo)
		Me.Frame1.Controls.Add(lblItmTypeCodeFr)
		Me.Frame1.Controls.Add(lblItmAccTypeCodeFr)
		Me.Frame1.Controls.Add(lblItmAccTypeCodeTo)
		Me.Frame1.Controls.Add(lblItmCodeTo)
		Me.Frame1.Controls.Add(lblItmCodeFr)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
		Me.tbrProcess.Items.Add(_tbrProcess_Button7)
		Me.tbrProcess.Items.Add(_tbrProcess_Button8)
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class