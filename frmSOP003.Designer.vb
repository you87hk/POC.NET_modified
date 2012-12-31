<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSOP003
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
	Public WithEvents cboItmTypeCode As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboCusCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents txtPayYear As System.Windows.Forms.TextBox
	Public WithEvents txtPayQuarter As System.Windows.Forms.TextBox
	Public WithEvents txtPayMonth As System.Windows.Forms.TextBox
	Public WithEvents _optBy_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents fraRange As System.Windows.Forms.GroupBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboCusCode As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents lblItmTypeCode As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblCusCodeTo As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblCusCode As System.Windows.Forms.Label
	Public WithEvents optBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSOP003))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItmTypeCode = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboCusCodeTo = New System.Windows.Forms.ComboBox
		Me.txtPayYear = New System.Windows.Forms.TextBox
		Me.txtPayQuarter = New System.Windows.Forms.TextBox
		Me.txtPayMonth = New System.Windows.Forms.TextBox
		Me._optBy_2 = New System.Windows.Forms.RadioButton
		Me._optBy_0 = New System.Windows.Forms.RadioButton
		Me._optBy_1 = New System.Windows.Forms.RadioButton
		Me.fraRange = New System.Windows.Forms.GroupBox
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboCusCode = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.lblItmTypeCode = New System.Windows.Forms.Label
		Me.lblItmTypeCodeTo = New System.Windows.Forms.Label
		Me.lblCusCodeTo = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblCusCode = New System.Windows.Forms.Label
		Me.optBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "SOP003"
		Me.ClientSize = New System.Drawing.Size(613, 258)
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
		Me.Name = "frmSOP003"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(528, 32)
		Me.tblCommon.TabIndex = 12
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItmTypeCode.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCode.Location = New System.Drawing.Point(184, 104)
		Me.cboItmTypeCode.TabIndex = 3
		Me.cboItmTypeCode.Text = "Combo1"
		Me.cboItmTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeCode.CausesValidation = True
		Me.cboItmTypeCode.Enabled = True
		Me.cboItmTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeCode.IntegralHeight = True
		Me.cboItmTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeCode.Sorted = False
		Me.cboItmTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeCode.TabStop = True
		Me.cboItmTypeCode.Visible = True
		Me.cboItmTypeCode.Name = "cboItmTypeCode"
		Me.cboItmTypeCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCodeTo.Location = New System.Drawing.Point(374, 104)
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
		Me.cboCusCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboCusCodeTo.Location = New System.Drawing.Point(376, 77)
		Me.cboCusCodeTo.TabIndex = 2
		Me.cboCusCodeTo.Text = "Combo1"
		Me.cboCusCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusCodeTo.CausesValidation = True
		Me.cboCusCodeTo.Enabled = True
		Me.cboCusCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusCodeTo.IntegralHeight = True
		Me.cboCusCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusCodeTo.Sorted = False
		Me.cboCusCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusCodeTo.TabStop = True
		Me.cboCusCodeTo.Visible = True
		Me.cboCusCodeTo.Name = "cboCusCodeTo"
		Me.txtPayYear.AutoSize = False
		Me.txtPayYear.Size = New System.Drawing.Size(59, 20)
		Me.txtPayYear.Location = New System.Drawing.Point(184, 224)
		Me.txtPayYear.TabIndex = 10
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
		Me.txtPayQuarter.Location = New System.Drawing.Point(184, 192)
		Me.txtPayQuarter.TabIndex = 9
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
		Me.txtPayMonth.Location = New System.Drawing.Point(184, 160)
		Me.txtPayMonth.TabIndex = 8
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
		Me._optBy_2.Location = New System.Drawing.Point(64, 224)
		Me._optBy_2.TabIndex = 7
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
		Me._optBy_0.Location = New System.Drawing.Point(64, 160)
		Me._optBy_0.TabIndex = 5
		Me._optBy_0.Checked = True
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
		Me._optBy_0.Visible = True
		Me._optBy_0.Name = "_optBy_0"
		Me._optBy_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.Text = "BYQUARTER"
		Me._optBy_1.Size = New System.Drawing.Size(97, 17)
		Me._optBy_1.Location = New System.Drawing.Point(64, 194)
		Me._optBy_1.TabIndex = 6
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
		Me.fraRange.Location = New System.Drawing.Point(56, 144)
		Me.fraRange.TabIndex = 15
		Me.fraRange.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraRange.BackColor = System.Drawing.SystemColors.Control
		Me.fraRange.Enabled = True
		Me.fraRange.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraRange.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraRange.Visible = True
		Me.fraRange.Padding = New System.Windows.Forms.Padding(0)
		Me.fraRange.Name = "fraRange"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(184, 48)
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
		Me.cboCusCode.Size = New System.Drawing.Size(121, 20)
		Me.cboCusCode.Location = New System.Drawing.Point(184, 77)
		Me.cboCusCode.TabIndex = 1
		Me.cboCusCode.Text = "Combo1"
		Me.cboCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusCode.CausesValidation = True
		Me.cboCusCode.Enabled = True
		Me.cboCusCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusCode.IntegralHeight = True
		Me.cboCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusCode.Sorted = False
		Me.cboCusCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusCode.TabStop = True
		Me.cboCusCode.Visible = True
		Me.cboCusCode.Name = "cboCusCode"
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
		Me.tbrProcess.TabIndex = 13
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
		Me.Frame2.Size = New System.Drawing.Size(212, 41)
		Me.Frame2.Location = New System.Drawing.Point(56, 176)
		Me.Frame2.TabIndex = 16
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Frame3.Size = New System.Drawing.Size(212, 41)
		Me.Frame3.Location = New System.Drawing.Point(56, 208)
		Me.Frame3.TabIndex = 17
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.lblItmTypeCode.Text = "METHODCODEFR"
		Me.lblItmTypeCode.Size = New System.Drawing.Size(126, 15)
		Me.lblItmTypeCode.Location = New System.Drawing.Point(56, 109)
		Me.lblItmTypeCode.TabIndex = 20
		Me.lblItmTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeCode.Enabled = True
		Me.lblItmTypeCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeCode.UseMnemonic = True
		Me.lblItmTypeCode.Visible = True
		Me.lblItmTypeCode.AutoSize = False
		Me.lblItmTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeCode.Name = "lblItmTypeCode"
		Me.lblItmTypeCodeTo.Text = "METHODCODETO"
		Me.lblItmTypeCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmTypeCodeTo.Location = New System.Drawing.Point(350, 109)
		Me.lblItmTypeCodeTo.TabIndex = 19
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
		Me.lblCusCodeTo.Text = "METHODCODETO"
		Me.lblCusCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblCusCodeTo.Location = New System.Drawing.Point(352, 82)
		Me.lblCusCodeTo.TabIndex = 18
		Me.lblCusCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCodeTo.Enabled = True
		Me.lblCusCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCodeTo.UseMnemonic = True
		Me.lblCusCodeTo.Visible = True
		Me.lblCusCodeTo.AutoSize = False
		Me.lblCusCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCodeTo.Name = "lblCusCodeTo"
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(58, 51)
		Me.lblTitle.TabIndex = 14
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
		Me.lblCusCode.Text = "METHODCODEFR"
		Me.lblCusCode.Size = New System.Drawing.Size(126, 15)
		Me.lblCusCode.Location = New System.Drawing.Point(58, 82)
		Me.lblCusCode.TabIndex = 11
		Me.lblCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCode.Enabled = True
		Me.lblCusCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCode.UseMnemonic = True
		Me.lblCusCode.Visible = True
		Me.lblCusCode.AutoSize = False
		Me.lblCusCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCode.Name = "lblCusCode"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboItmTypeCode)
		Me.Controls.Add(cboItmTypeCodeTo)
		Me.Controls.Add(cboCusCodeTo)
		Me.Controls.Add(txtPayYear)
		Me.Controls.Add(txtPayQuarter)
		Me.Controls.Add(txtPayMonth)
		Me.Controls.Add(_optBy_2)
		Me.Controls.Add(_optBy_0)
		Me.Controls.Add(_optBy_1)
		Me.Controls.Add(fraRange)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboCusCode)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(lblItmTypeCode)
		Me.Controls.Add(lblItmTypeCodeTo)
		Me.Controls.Add(lblCusCodeTo)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblCusCode)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optBy.SetIndex(_optBy_2, CType(2, Short))
		Me.optBy.SetIndex(_optBy_0, CType(0, Short))
		Me.optBy.SetIndex(_optBy_1, CType(1, Short))
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class