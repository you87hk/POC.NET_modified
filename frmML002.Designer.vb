<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmML002
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
	Public WithEvents _optMLType_5 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_0 As System.Windows.Forms.RadioButton
	Public WithEvents FraMLType As System.Windows.Forms.GroupBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboMLCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboMLCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboCOAAccCode As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblMLCodeFr As System.Windows.Forms.Label
	Public WithEvents lblMLCodeTo As System.Windows.Forms.Label
	Public WithEvents lblCOAAccCode As System.Windows.Forms.Label
	Public WithEvents optMLType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmML002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.FraMLType = New System.Windows.Forms.GroupBox
		Me._optMLType_5 = New System.Windows.Forms.RadioButton
		Me._optMLType_4 = New System.Windows.Forms.RadioButton
		Me._optMLType_3 = New System.Windows.Forms.RadioButton
		Me._optMLType_2 = New System.Windows.Forms.RadioButton
		Me._optMLType_1 = New System.Windows.Forms.RadioButton
		Me._optMLType_0 = New System.Windows.Forms.RadioButton
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboMLCodeFr = New System.Windows.Forms.ComboBox
		Me.cboMLCodeTo = New System.Windows.Forms.ComboBox
		Me.cboCOAAccCode = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblMLCodeFr = New System.Windows.Forms.Label
		Me.lblMLCodeTo = New System.Windows.Forms.Label
		Me.lblCOAAccCode = New System.Windows.Forms.Label
		Me.optMLType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.FraMLType.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optMLType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "IP0021"
		Me.ClientSize = New System.Drawing.Size(613, 229)
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
		Me.Name = "frmML002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(568, 24)
		Me.tblCommon.TabIndex = 11
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.FraMLType.Text = "MLTYPE"
		Me.FraMLType.Size = New System.Drawing.Size(537, 89)
		Me.FraMLType.Location = New System.Drawing.Point(40, 128)
		Me.FraMLType.TabIndex = 16
		Me.FraMLType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraMLType.BackColor = System.Drawing.SystemColors.Control
		Me.FraMLType.Enabled = True
		Me.FraMLType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraMLType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraMLType.Visible = True
		Me.FraMLType.Padding = New System.Windows.Forms.Padding(0)
		Me.FraMLType.Name = "FraMLType"
		Me._optMLType_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_5.Text = "BANK"
		Me._optMLType_5.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_5.Location = New System.Drawing.Point(392, 56)
		Me._optMLType_5.TabIndex = 9
		Me._optMLType_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optMLType_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_5.BackColor = System.Drawing.SystemColors.Control
		Me._optMLType_5.CausesValidation = True
		Me._optMLType_5.Enabled = True
		Me._optMLType_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optMLType_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._optMLType_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optMLType_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optMLType_5.TabStop = True
		Me._optMLType_5.Checked = False
		Me._optMLType_5.Visible = True
		Me._optMLType_5.Name = "_optMLType_5"
		Me._optMLType_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_4.Text = "CHEQUE"
		Me._optMLType_4.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_4.Location = New System.Drawing.Point(192, 56)
		Me._optMLType_4.TabIndex = 8
		Me._optMLType_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optMLType_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_4.BackColor = System.Drawing.SystemColors.Control
		Me._optMLType_4.CausesValidation = True
		Me._optMLType_4.Enabled = True
		Me._optMLType_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optMLType_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optMLType_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optMLType_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optMLType_4.TabStop = True
		Me._optMLType_4.Checked = False
		Me._optMLType_4.Visible = True
		Me._optMLType_4.Name = "_optMLType_4"
		Me._optMLType_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_3.Text = "A/P"
		Me._optMLType_3.Size = New System.Drawing.Size(81, 17)
		Me._optMLType_3.Location = New System.Drawing.Point(16, 56)
		Me._optMLType_3.TabIndex = 7
		Me._optMLType_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optMLType_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_3.BackColor = System.Drawing.SystemColors.Control
		Me._optMLType_3.CausesValidation = True
		Me._optMLType_3.Enabled = True
		Me._optMLType_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optMLType_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optMLType_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optMLType_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optMLType_3.TabStop = True
		Me._optMLType_3.Checked = False
		Me._optMLType_3.Visible = True
		Me._optMLType_3.Name = "_optMLType_3"
		Me._optMLType_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_2.Text = "A/R"
		Me._optMLType_2.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_2.Location = New System.Drawing.Point(392, 24)
		Me._optMLType_2.TabIndex = 6
		Me._optMLType_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optMLType_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_2.BackColor = System.Drawing.SystemColors.Control
		Me._optMLType_2.CausesValidation = True
		Me._optMLType_2.Enabled = True
		Me._optMLType_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optMLType_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optMLType_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optMLType_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optMLType_2.TabStop = True
		Me._optMLType_2.Checked = False
		Me._optMLType_2.Visible = True
		Me._optMLType_2.Name = "_optMLType_2"
		Me._optMLType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_1.Text = "PURCHASE"
		Me._optMLType_1.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_1.Location = New System.Drawing.Point(192, 24)
		Me._optMLType_1.TabIndex = 5
		Me._optMLType_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optMLType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optMLType_1.CausesValidation = True
		Me._optMLType_1.Enabled = True
		Me._optMLType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optMLType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optMLType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optMLType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optMLType_1.TabStop = True
		Me._optMLType_1.Checked = False
		Me._optMLType_1.Visible = True
		Me._optMLType_1.Name = "_optMLType_1"
		Me._optMLType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_0.Text = "SALES"
		Me._optMLType_0.Size = New System.Drawing.Size(81, 17)
		Me._optMLType_0.Location = New System.Drawing.Point(16, 24)
		Me._optMLType_0.TabIndex = 4
		Me._optMLType_0.Checked = True
		Me._optMLType_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optMLType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optMLType_0.CausesValidation = True
		Me._optMLType_0.Enabled = True
		Me._optMLType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optMLType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optMLType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optMLType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optMLType_0.TabStop = True
		Me._optMLType_0.Visible = True
		Me._optMLType_0.Name = "_optMLType_0"
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
		Me.cboMLCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboMLCodeFr.Location = New System.Drawing.Point(186, 74)
		Me.cboMLCodeFr.TabIndex = 1
		Me.cboMLCodeFr.Text = "Combo1"
		Me.cboMLCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMLCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboMLCodeFr.CausesValidation = True
		Me.cboMLCodeFr.Enabled = True
		Me.cboMLCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMLCodeFr.IntegralHeight = True
		Me.cboMLCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMLCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMLCodeFr.Sorted = False
		Me.cboMLCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboMLCodeFr.TabStop = True
		Me.cboMLCodeFr.Visible = True
		Me.cboMLCodeFr.Name = "cboMLCodeFr"
		Me.cboMLCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboMLCodeTo.Location = New System.Drawing.Point(372, 74)
		Me.cboMLCodeTo.TabIndex = 2
		Me.cboMLCodeTo.Text = "Combo1"
		Me.cboMLCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMLCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboMLCodeTo.CausesValidation = True
		Me.cboMLCodeTo.Enabled = True
		Me.cboMLCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMLCodeTo.IntegralHeight = True
		Me.cboMLCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMLCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMLCodeTo.Sorted = False
		Me.cboMLCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboMLCodeTo.TabStop = True
		Me.cboMLCodeTo.Visible = True
		Me.cboMLCodeTo.Name = "cboMLCodeTo"
		Me.cboCOAAccCode.Size = New System.Drawing.Size(121, 20)
		Me.cboCOAAccCode.Location = New System.Drawing.Point(186, 101)
		Me.cboCOAAccCode.TabIndex = 3
		Me.cboCOAAccCode.Text = "Combo1"
		Me.cboCOAAccCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCOAAccCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCOAAccCode.CausesValidation = True
		Me.cboCOAAccCode.Enabled = True
		Me.cboCOAAccCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCOAAccCode.IntegralHeight = True
		Me.cboCOAAccCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCOAAccCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCOAAccCode.Sorted = False
		Me.cboCOAAccCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCOAAccCode.TabStop = True
		Me.cboCOAAccCode.Visible = True
		Me.cboCOAAccCode.Name = "cboCOAAccCode"
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
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(58, 51)
		Me.lblTitle.TabIndex = 15
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
		Me.lblMLCodeFr.Text = "MLCODEFR"
		Me.lblMLCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblMLCodeFr.Location = New System.Drawing.Point(58, 77)
		Me.lblMLCodeFr.TabIndex = 13
		Me.lblMLCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMLCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMLCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblMLCodeFr.Enabled = True
		Me.lblMLCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMLCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMLCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMLCodeFr.UseMnemonic = True
		Me.lblMLCodeFr.Visible = True
		Me.lblMLCodeFr.AutoSize = False
		Me.lblMLCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMLCodeFr.Name = "lblMLCodeFr"
		Me.lblMLCodeTo.Text = "MLCODETO"
		Me.lblMLCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblMLCodeTo.Location = New System.Drawing.Point(348, 77)
		Me.lblMLCodeTo.TabIndex = 12
		Me.lblMLCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMLCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMLCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblMLCodeTo.Enabled = True
		Me.lblMLCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMLCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMLCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMLCodeTo.UseMnemonic = True
		Me.lblMLCodeTo.Visible = True
		Me.lblMLCodeTo.AutoSize = False
		Me.lblMLCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMLCodeTo.Name = "lblMLCodeTo"
		Me.lblCOAAccCode.Text = "COAACCCODE"
		Me.lblCOAAccCode.Size = New System.Drawing.Size(126, 15)
		Me.lblCOAAccCode.Location = New System.Drawing.Point(58, 103)
		Me.lblCOAAccCode.TabIndex = 10
		Me.lblCOAAccCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCOAAccCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOAAccCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOAAccCode.Enabled = True
		Me.lblCOAAccCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOAAccCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOAAccCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOAAccCode.UseMnemonic = True
		Me.lblCOAAccCode.Visible = True
		Me.lblCOAAccCode.AutoSize = False
		Me.lblCOAAccCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOAAccCode.Name = "lblCOAAccCode"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(FraMLType)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboMLCodeFr)
		Me.Controls.Add(cboMLCodeTo)
		Me.Controls.Add(cboCOAAccCode)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblMLCodeFr)
		Me.Controls.Add(lblMLCodeTo)
		Me.Controls.Add(lblCOAAccCode)
		Me.FraMLType.Controls.Add(_optMLType_5)
		Me.FraMLType.Controls.Add(_optMLType_4)
		Me.FraMLType.Controls.Add(_optMLType_3)
		Me.FraMLType.Controls.Add(_optMLType_2)
		Me.FraMLType.Controls.Add(_optMLType_1)
		Me.FraMLType.Controls.Add(_optMLType_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optMLType.SetIndex(_optMLType_5, CType(5, Short))
		Me.optMLType.SetIndex(_optMLType_4, CType(4, Short))
		Me.optMLType.SetIndex(_optMLType_3, CType(3, Short))
		Me.optMLType.SetIndex(_optMLType_2, CType(2, Short))
		Me.optMLType.SetIndex(_optMLType_1, CType(1, Short))
		Me.optMLType.SetIndex(_optMLType_0, CType(0, Short))
		CType(Me.optMLType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FraMLType.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class