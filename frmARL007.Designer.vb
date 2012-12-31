<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmARL007
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
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents _optByDay_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optByDay_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _optByDate_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optByDate_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents chkSummary As System.Windows.Forms.CheckBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents medAsAt As System.Windows.Forms.MaskedTextBox
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblByDay As System.Windows.Forms.Label
	Public WithEvents lblByDate As System.Windows.Forms.Label
	Public WithEvents lblSummary As System.Windows.Forms.Label
	Public WithEvents lblAsAt As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents optByDate As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optByDay As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmARL007))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._optByDay_0 = New System.Windows.Forms.RadioButton
		Me._optByDay_1 = New System.Windows.Forms.RadioButton
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optByDate_1 = New System.Windows.Forms.RadioButton
		Me._optByDate_0 = New System.Windows.Forms.RadioButton
		Me.chkSummary = New System.Windows.Forms.CheckBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.medAsAt = New System.Windows.Forms.MaskedTextBox
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblByDay = New System.Windows.Forms.Label
		Me.lblByDate = New System.Windows.Forms.Label
		Me.lblSummary = New System.Windows.Forms.Label
		Me.lblAsAt = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.optByDate = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optByDay = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optByDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optByDay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Material Master List"
		Me.ClientSize = New System.Drawing.Size(613, 273)
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
		Me.Name = "frmARL007"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(552, 208)
		Me.tblCommon.TabIndex = 5
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(184, 40)
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
		Me.Frame2.Size = New System.Drawing.Size(297, 33)
		Me.Frame2.Location = New System.Drawing.Point(184, 176)
		Me.Frame2.TabIndex = 15
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me._optByDay_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDay_0.Text = "BYDAY"
		Me._optByDay_0.Size = New System.Drawing.Size(89, 19)
		Me._optByDay_0.Location = New System.Drawing.Point(8, 10)
		Me._optByDay_0.TabIndex = 17
		Me._optByDay_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optByDay_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDay_0.BackColor = System.Drawing.SystemColors.Control
		Me._optByDay_0.CausesValidation = True
		Me._optByDay_0.Enabled = True
		Me._optByDay_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optByDay_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optByDay_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optByDay_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optByDay_0.TabStop = True
		Me._optByDay_0.Checked = False
		Me._optByDay_0.Visible = True
		Me._optByDay_0.Name = "_optByDay_0"
		Me._optByDay_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDay_1.Text = "BYMONTH"
		Me._optByDay_1.Size = New System.Drawing.Size(102, 19)
		Me._optByDay_1.Location = New System.Drawing.Point(168, 10)
		Me._optByDay_1.TabIndex = 16
		Me._optByDay_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optByDay_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDay_1.BackColor = System.Drawing.SystemColors.Control
		Me._optByDay_1.CausesValidation = True
		Me._optByDay_1.Enabled = True
		Me._optByDay_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optByDay_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optByDay_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optByDay_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optByDay_1.TabStop = True
		Me._optByDay_1.Checked = False
		Me._optByDay_1.Visible = True
		Me._optByDay_1.Name = "_optByDay_1"
		Me.Frame1.Size = New System.Drawing.Size(297, 33)
		Me.Frame1.Location = New System.Drawing.Point(184, 136)
		Me.Frame1.TabIndex = 10
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optByDate_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDate_1.Text = "DOCDATE"
		Me._optByDate_1.Size = New System.Drawing.Size(102, 19)
		Me._optByDate_1.Location = New System.Drawing.Point(168, 10)
		Me._optByDate_1.TabIndex = 12
		Me._optByDate_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optByDate_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDate_1.BackColor = System.Drawing.SystemColors.Control
		Me._optByDate_1.CausesValidation = True
		Me._optByDate_1.Enabled = True
		Me._optByDate_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optByDate_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optByDate_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optByDate_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optByDate_1.TabStop = True
		Me._optByDate_1.Checked = False
		Me._optByDate_1.Visible = True
		Me._optByDate_1.Name = "_optByDate_1"
		Me._optByDate_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDate_0.Text = "DUEDATE"
		Me._optByDate_0.Size = New System.Drawing.Size(89, 19)
		Me._optByDate_0.Location = New System.Drawing.Point(8, 10)
		Me._optByDate_0.TabIndex = 11
		Me._optByDate_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optByDate_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optByDate_0.BackColor = System.Drawing.SystemColors.Control
		Me._optByDate_0.CausesValidation = True
		Me._optByDate_0.Enabled = True
		Me._optByDate_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optByDate_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optByDate_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optByDate_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optByDate_0.TabStop = True
		Me._optByDate_0.Checked = False
		Me._optByDate_0.Visible = True
		Me._optByDate_0.Name = "_optByDate_0"
		Me.chkSummary.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkSummary.Size = New System.Drawing.Size(25, 12)
		Me.chkSummary.Location = New System.Drawing.Point(171, 120)
		Me.chkSummary.TabIndex = 4
		Me.chkSummary.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSummary.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkSummary.BackColor = System.Drawing.SystemColors.Control
		Me.chkSummary.Text = ""
		Me.chkSummary.CausesValidation = True
		Me.chkSummary.Enabled = True
		Me.chkSummary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkSummary.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSummary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSummary.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkSummary.TabStop = True
		Me.chkSummary.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkSummary.Visible = True
		Me.chkSummary.Name = "chkSummary"
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(184, 66)
		Me.cboDocNoFr.TabIndex = 1
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
		Me.cboDocNoTo.Location = New System.Drawing.Point(372, 66)
		Me.cboDocNoTo.TabIndex = 2
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
		Me.medAsAt.AllowPromptAsInput = False
		Me.medAsAt.Size = New System.Drawing.Size(89, 19)
		Me.medAsAt.Location = New System.Drawing.Point(184, 91)
		Me.medAsAt.TabIndex = 3
		Me.medAsAt.MaxLength = 10
		Me.medAsAt.Mask = "##/##/####"
		Me.medAsAt.PromptChar = "_"
		Me.medAsAt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medAsAt.Name = "medAsAt"
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(613, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 14
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
		Me.lblTitle.Text = "SHIPPER"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(56, 40)
		Me.lblTitle.TabIndex = 19
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
		Me.lblByDay.Text = "BYDAY"
		Me.lblByDay.Size = New System.Drawing.Size(120, 41)
		Me.lblByDay.Location = New System.Drawing.Point(56, 189)
		Me.lblByDay.TabIndex = 18
		Me.lblByDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblByDay.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblByDay.BackColor = System.Drawing.SystemColors.Control
		Me.lblByDay.Enabled = True
		Me.lblByDay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblByDay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblByDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblByDay.UseMnemonic = True
		Me.lblByDay.Visible = True
		Me.lblByDay.AutoSize = False
		Me.lblByDay.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblByDay.Name = "lblByDay"
		Me.lblByDate.Text = "BYDATE"
		Me.lblByDate.Size = New System.Drawing.Size(128, 33)
		Me.lblByDate.Location = New System.Drawing.Point(56, 149)
		Me.lblByDate.TabIndex = 13
		Me.lblByDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblByDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblByDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblByDate.Enabled = True
		Me.lblByDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblByDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblByDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblByDate.UseMnemonic = True
		Me.lblByDate.Visible = True
		Me.lblByDate.AutoSize = False
		Me.lblByDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblByDate.Name = "lblByDate"
		Me.lblSummary.Text = "SUMMARY"
		Me.lblSummary.Size = New System.Drawing.Size(112, 17)
		Me.lblSummary.Location = New System.Drawing.Point(56, 121)
		Me.lblSummary.TabIndex = 9
		Me.lblSummary.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSummary.BackColor = System.Drawing.SystemColors.Control
		Me.lblSummary.Enabled = True
		Me.lblSummary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSummary.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSummary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSummary.UseMnemonic = True
		Me.lblSummary.Visible = True
		Me.lblSummary.AutoSize = False
		Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSummary.Name = "lblSummary"
		Me.lblAsAt.Text = "ASAT"
		Me.lblAsAt.Size = New System.Drawing.Size(104, 17)
		Me.lblAsAt.Location = New System.Drawing.Point(56, 95)
		Me.lblAsAt.TabIndex = 8
		Me.lblAsAt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAsAt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAsAt.BackColor = System.Drawing.SystemColors.Control
		Me.lblAsAt.Enabled = True
		Me.lblAsAt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAsAt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAsAt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAsAt.UseMnemonic = True
		Me.lblAsAt.Visible = True
		Me.lblAsAt.AutoSize = False
		Me.lblAsAt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAsAt.Name = "lblAsAt"
		Me.lblDocNoFr.Text = "Customer"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNoFr.Location = New System.Drawing.Point(56, 67)
		Me.lblDocNoFr.TabIndex = 7
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
		Me.lblDocNoTo.Text = "To"
		Me.lblDocNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblDocNoTo.Location = New System.Drawing.Point(348, 67)
		Me.lblDocNoTo.TabIndex = 6
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
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(chkSummary)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(medAsAt)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblByDay)
		Me.Controls.Add(lblByDate)
		Me.Controls.Add(lblSummary)
		Me.Controls.Add(lblAsAt)
		Me.Controls.Add(lblDocNoFr)
		Me.Controls.Add(lblDocNoTo)
		Me.Frame2.Controls.Add(_optByDay_0)
		Me.Frame2.Controls.Add(_optByDay_1)
		Me.Frame1.Controls.Add(_optByDate_1)
		Me.Frame1.Controls.Add(_optByDate_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optByDate.SetIndex(_optByDate_1, CType(1, Short))
		Me.optByDate.SetIndex(_optByDate_0, CType(0, Short))
		Me.optByDay.SetIndex(_optByDay_0, CType(0, Short))
		Me.optByDay.SetIndex(_optByDay_1, CType(1, Short))
		CType(Me.optByDay, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optByDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class