<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmML001
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
	Public WithEvents cboCOAAccCode As System.Windows.Forms.ComboBox
	Public WithEvents cboMLCode As System.Windows.Forms.ComboBox
	Public WithEvents _optMLType_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optMLType_5 As System.Windows.Forms.RadioButton
	Public WithEvents FraMLType As System.Windows.Forms.GroupBox
	Public WithEvents txtMLCode As System.Windows.Forms.TextBox
	Public WithEvents txtMLDesc As System.Windows.Forms.TextBox
	Public WithEvents lblDspCOADesc As System.Windows.Forms.Label
	Public WithEvents lblCOAAccCode As System.Windows.Forms.Label
	Public WithEvents lblMLLastUpd As System.Windows.Forms.Label
	Public WithEvents lblMLLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspMLLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspMLLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblMLCode As System.Windows.Forms.Label
	Public WithEvents lblMLDesc As System.Windows.Forms.Label
	Public WithEvents fraDetailInfo As System.Windows.Forms.GroupBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents optMLType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmML001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboCOAAccCode = New System.Windows.Forms.ComboBox
		Me.cboMLCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.FraMLType = New System.Windows.Forms.GroupBox
		Me._optMLType_0 = New System.Windows.Forms.RadioButton
		Me._optMLType_1 = New System.Windows.Forms.RadioButton
		Me._optMLType_2 = New System.Windows.Forms.RadioButton
		Me._optMLType_3 = New System.Windows.Forms.RadioButton
		Me._optMLType_4 = New System.Windows.Forms.RadioButton
		Me._optMLType_5 = New System.Windows.Forms.RadioButton
		Me.txtMLCode = New System.Windows.Forms.TextBox
		Me.txtMLDesc = New System.Windows.Forms.TextBox
		Me.lblDspCOADesc = New System.Windows.Forms.Label
		Me.lblCOAAccCode = New System.Windows.Forms.Label
		Me.lblMLLastUpd = New System.Windows.Forms.Label
		Me.lblMLLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspMLLastUpd = New System.Windows.Forms.Label
		Me.lblDspMLLastUpdDate = New System.Windows.Forms.Label
		Me.lblMLCode = New System.Windows.Forms.Label
		Me.lblMLDesc = New System.Windows.Forms.Label
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me.optMLType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.FraMLType.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optMLType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "frmML001"
		Me.ClientSize = New System.Drawing.Size(572, 305)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmML001.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmML001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 18
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboCOAAccCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCOAAccCode.Location = New System.Drawing.Point(136, 88)
		Me.cboCOAAccCode.TabIndex = 2
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
		Me.cboMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboMLCode.Location = New System.Drawing.Point(136, 64)
		Me.cboMLCode.TabIndex = 1
		Me.cboMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboMLCode.CausesValidation = True
		Me.cboMLCode.Enabled = True
		Me.cboMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMLCode.IntegralHeight = True
		Me.cboMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMLCode.Sorted = False
		Me.cboMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboMLCode.TabStop = True
		Me.cboMLCode.Visible = True
		Me.cboMLCode.Name = "cboMLCode"
		Me.fraDetailInfo.Text = "FRADETAILINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 273)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 10
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.FraMLType.Text = "MLTYPE"
		Me.FraMLType.Size = New System.Drawing.Size(537, 89)
		Me.FraMLType.Location = New System.Drawing.Point(8, 88)
		Me.FraMLType.TabIndex = 20
		Me.FraMLType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraMLType.BackColor = System.Drawing.SystemColors.Control
		Me.FraMLType.Enabled = True
		Me.FraMLType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraMLType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraMLType.Visible = True
		Me.FraMLType.Padding = New System.Windows.Forms.Padding(0)
		Me.FraMLType.Name = "FraMLType"
		Me._optMLType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_0.Text = "SALES"
		Me._optMLType_0.Size = New System.Drawing.Size(81, 17)
		Me._optMLType_0.Location = New System.Drawing.Point(16, 24)
		Me._optMLType_0.TabIndex = 3
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
		Me._optMLType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_1.Text = "PURCHASE"
		Me._optMLType_1.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_1.Location = New System.Drawing.Point(192, 24)
		Me._optMLType_1.TabIndex = 4
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
		Me._optMLType_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_2.Text = "A/R"
		Me._optMLType_2.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_2.Location = New System.Drawing.Point(392, 24)
		Me._optMLType_2.TabIndex = 5
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
		Me._optMLType_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_3.Text = "A/P"
		Me._optMLType_3.Size = New System.Drawing.Size(81, 17)
		Me._optMLType_3.Location = New System.Drawing.Point(16, 56)
		Me._optMLType_3.TabIndex = 6
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
		Me._optMLType_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_4.Text = "CHEQUE"
		Me._optMLType_4.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_4.Location = New System.Drawing.Point(192, 56)
		Me._optMLType_4.TabIndex = 7
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
		Me._optMLType_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optMLType_5.Text = "BANK"
		Me._optMLType_5.Size = New System.Drawing.Size(89, 17)
		Me._optMLType_5.Location = New System.Drawing.Point(392, 56)
		Me._optMLType_5.TabIndex = 8
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
		Me.txtMLCode.AutoSize = False
		Me.txtMLCode.Size = New System.Drawing.Size(102, 20)
		Me.txtMLCode.Location = New System.Drawing.Point(128, 40)
		Me.txtMLCode.TabIndex = 0
		Me.txtMLCode.Tag = "K"
		Me.txtMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMLCode.AcceptsReturn = True
		Me.txtMLCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtMLCode.CausesValidation = True
		Me.txtMLCode.Enabled = True
		Me.txtMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMLCode.HideSelection = True
		Me.txtMLCode.ReadOnly = False
		Me.txtMLCode.Maxlength = 0
		Me.txtMLCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMLCode.MultiLine = False
		Me.txtMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMLCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMLCode.TabStop = True
		Me.txtMLCode.Visible = True
		Me.txtMLCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMLCode.Name = "txtMLCode"
		Me.txtMLDesc.AutoSize = False
		Me.txtMLDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtMLDesc.Enabled = False
		Me.txtMLDesc.Size = New System.Drawing.Size(417, 20)
		Me.txtMLDesc.Location = New System.Drawing.Point(128, 192)
		Me.txtMLDesc.TabIndex = 9
		Me.txtMLDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMLDesc.AcceptsReturn = True
		Me.txtMLDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMLDesc.CausesValidation = True
		Me.txtMLDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMLDesc.HideSelection = True
		Me.txtMLDesc.ReadOnly = False
		Me.txtMLDesc.Maxlength = 0
		Me.txtMLDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMLDesc.MultiLine = False
		Me.txtMLDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMLDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMLDesc.TabStop = True
		Me.txtMLDesc.Visible = True
		Me.txtMLDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMLDesc.Name = "txtMLDesc"
		Me.lblDspCOADesc.Size = New System.Drawing.Size(311, 20)
		Me.lblDspCOADesc.Location = New System.Drawing.Point(232, 64)
		Me.lblDspCOADesc.TabIndex = 21
		Me.lblDspCOADesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCOADesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCOADesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCOADesc.Enabled = True
		Me.lblDspCOADesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCOADesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCOADesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCOADesc.UseMnemonic = True
		Me.lblDspCOADesc.Visible = True
		Me.lblDspCOADesc.AutoSize = False
		Me.lblDspCOADesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCOADesc.Name = "lblDspCOADesc"
		Me.lblCOAAccCode.Text = "COAACCCODE"
		Me.lblCOAAccCode.Size = New System.Drawing.Size(116, 16)
		Me.lblCOAAccCode.Location = New System.Drawing.Point(8, 69)
		Me.lblCOAAccCode.TabIndex = 19
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
		Me.lblMLLastUpd.Text = "MLLASTUPD"
		Me.lblMLLastUpd.Size = New System.Drawing.Size(132, 16)
		Me.lblMLLastUpd.Location = New System.Drawing.Point(24, 243)
		Me.lblMLLastUpd.TabIndex = 16
		Me.lblMLLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMLLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMLLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblMLLastUpd.Enabled = True
		Me.lblMLLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMLLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMLLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMLLastUpd.UseMnemonic = True
		Me.lblMLLastUpd.Visible = True
		Me.lblMLLastUpd.AutoSize = False
		Me.lblMLLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMLLastUpd.Name = "lblMLLastUpd"
		Me.lblMLLastUpdDate.Text = "MLLASTUPDDATE"
		Me.lblMLLastUpdDate.Size = New System.Drawing.Size(148, 16)
		Me.lblMLLastUpdDate.Location = New System.Drawing.Point(288, 243)
		Me.lblMLLastUpdDate.TabIndex = 15
		Me.lblMLLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMLLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMLLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblMLLastUpdDate.Enabled = True
		Me.lblMLLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMLLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMLLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMLLastUpdDate.UseMnemonic = True
		Me.lblMLLastUpdDate.Visible = True
		Me.lblMLLastUpdDate.AutoSize = False
		Me.lblMLLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMLLastUpdDate.Name = "lblMLLastUpdDate"
		Me.lblDspMLLastUpd.Size = New System.Drawing.Size(111, 20)
		Me.lblDspMLLastUpd.Location = New System.Drawing.Point(168, 240)
		Me.lblDspMLLastUpd.TabIndex = 14
		Me.lblDspMLLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspMLLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspMLLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspMLLastUpd.Enabled = True
		Me.lblDspMLLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspMLLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspMLLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspMLLastUpd.UseMnemonic = True
		Me.lblDspMLLastUpd.Visible = True
		Me.lblDspMLLastUpd.AutoSize = False
		Me.lblDspMLLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspMLLastUpd.Name = "lblDspMLLastUpd"
		Me.lblDspMLLastUpdDate.Size = New System.Drawing.Size(103, 20)
		Me.lblDspMLLastUpdDate.Location = New System.Drawing.Point(440, 240)
		Me.lblDspMLLastUpdDate.TabIndex = 13
		Me.lblDspMLLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspMLLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspMLLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspMLLastUpdDate.Enabled = True
		Me.lblDspMLLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspMLLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspMLLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspMLLastUpdDate.UseMnemonic = True
		Me.lblDspMLLastUpdDate.Visible = True
		Me.lblDspMLLastUpdDate.AutoSize = False
		Me.lblDspMLLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspMLLastUpdDate.Name = "lblDspMLLastUpdDate"
		Me.lblMLCode.Text = "MLCODE"
		Me.lblMLCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblMLCode.Size = New System.Drawing.Size(116, 16)
		Me.lblMLCode.Location = New System.Drawing.Point(8, 44)
		Me.lblMLCode.TabIndex = 12
		Me.lblMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblMLCode.Enabled = True
		Me.lblMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMLCode.UseMnemonic = True
		Me.lblMLCode.Visible = True
		Me.lblMLCode.AutoSize = False
		Me.lblMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMLCode.Name = "lblMLCode"
		Me.lblMLDesc.Text = "MLDESC"
		Me.lblMLDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblMLDesc.Location = New System.Drawing.Point(24, 197)
		Me.lblMLDesc.TabIndex = 11
		Me.lblMLDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMLDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMLDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblMLDesc.Enabled = True
		Me.lblMLDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMLDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMLDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMLDesc.UseMnemonic = True
		Me.lblMLDesc.Visible = True
		Me.lblMLDesc.AutoSize = False
		Me.lblMLDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMLDesc.Name = "lblMLDesc"
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
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(572, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 17
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
		Me._tbrProcess_Button2.Name = "Open"
		Me._tbrProcess_Button2.ToolTipText = "開新視窗 (F6)"
		Me._tbrProcess_Button2.ImageIndex = 11
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Add"
		Me._tbrProcess_Button3.ToolTipText = "新增 (F2)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Edit"
		Me._tbrProcess_Button4.ToolTipText = "修改 (F5)"
		Me._tbrProcess_Button4.ImageIndex = 1
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Delete"
		Me._tbrProcess_Button5.ToolTipText = "刪除 (F3)"
		Me._tbrProcess_Button5.ImageIndex = 2
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
		Me._tbrProcess_Button7.Name = "Save"
		Me._tbrProcess_Button7.ToolTipText = "儲存 (F10)"
		Me._tbrProcess_Button7.ImageIndex = 3
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Cancel"
		Me._tbrProcess_Button8.ToolTipText = "取消 (F11)"
		Me._tbrProcess_Button8.ImageIndex = 4
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.Name = "Find"
		Me._tbrProcess_Button10.ToolTipText = "尋找 (F9)"
		Me._tbrProcess_Button10.ImageIndex = 6
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
		Me._tbrProcess_Button12.Name = "Exit"
		Me._tbrProcess_Button12.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button12.ImageIndex = 8
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboCOAAccCode)
		Me.Controls.Add(cboMLCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(FraMLType)
		Me.fraDetailInfo.Controls.Add(txtMLCode)
		Me.fraDetailInfo.Controls.Add(txtMLDesc)
		Me.fraDetailInfo.Controls.Add(lblDspCOADesc)
		Me.fraDetailInfo.Controls.Add(lblCOAAccCode)
		Me.fraDetailInfo.Controls.Add(lblMLLastUpd)
		Me.fraDetailInfo.Controls.Add(lblMLLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspMLLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspMLLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblMLCode)
		Me.fraDetailInfo.Controls.Add(lblMLDesc)
		Me.FraMLType.Controls.Add(_optMLType_0)
		Me.FraMLType.Controls.Add(_optMLType_1)
		Me.FraMLType.Controls.Add(_optMLType_2)
		Me.FraMLType.Controls.Add(_optMLType_3)
		Me.FraMLType.Controls.Add(_optMLType_4)
		Me.FraMLType.Controls.Add(_optMLType_5)
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
		Me.optMLType.SetIndex(_optMLType_0, CType(0, Short))
		Me.optMLType.SetIndex(_optMLType_1, CType(1, Short))
		Me.optMLType.SetIndex(_optMLType_2, CType(2, Short))
		Me.optMLType.SetIndex(_optMLType_3, CType(3, Short))
		Me.optMLType.SetIndex(_optMLType_4, CType(4, Short))
		Me.optMLType.SetIndex(_optMLType_5, CType(5, Short))
		CType(Me.optMLType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.FraMLType.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class