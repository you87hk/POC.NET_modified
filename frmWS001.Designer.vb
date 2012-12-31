<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWS001
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
	Public WithEvents cboWsSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents cboWsVdrCode As System.Windows.Forms.ComboBox
	Public WithEvents cboWsCusCode As System.Windows.Forms.ComboBox
	Public WithEvents cboWSWhsCode As System.Windows.Forms.ComboBox
	Public WithEvents cboWSMethodCode As System.Windows.Forms.ComboBox
	Public WithEvents cboWSPayCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCurr As System.Windows.Forms.ComboBox
	Public WithEvents cboWSID As System.Windows.Forms.ComboBox
	Public WithEvents txtWSExcr As System.Windows.Forms.TextBox
	Public WithEvents txtWSID As System.Windows.Forms.TextBox
	Public WithEvents lblDspWsSaleName As System.Windows.Forms.Label
	Public WithEvents lblWSSale As System.Windows.Forms.Label
	Public WithEvents lblDspWsVdrName As System.Windows.Forms.Label
	Public WithEvents lblWSVdr As System.Windows.Forms.Label
	Public WithEvents lblDspWsCusName As System.Windows.Forms.Label
	Public WithEvents lblWSCus As System.Windows.Forms.Label
	Public WithEvents lblDspWSWhsDesc As System.Windows.Forms.Label
	Public WithEvents lblWSWhsCode As System.Windows.Forms.Label
	Public WithEvents lblDspWSMethodDesc As System.Windows.Forms.Label
	Public WithEvents lblWSMethodCode As System.Windows.Forms.Label
	Public WithEvents lblDspWSPayDesc As System.Windows.Forms.Label
	Public WithEvents lblWSPayCode As System.Windows.Forms.Label
	Public WithEvents lblWSExcr As System.Windows.Forms.Label
	Public WithEvents lblCurr As System.Windows.Forms.Label
	Public WithEvents lblWSLastUpd As System.Windows.Forms.Label
	Public WithEvents lblWSLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspWSLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspWSLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblWSID As System.Windows.Forms.Label
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
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWS001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboWsSaleCode = New System.Windows.Forms.ComboBox
		Me.cboWsVdrCode = New System.Windows.Forms.ComboBox
		Me.cboWsCusCode = New System.Windows.Forms.ComboBox
		Me.cboWSWhsCode = New System.Windows.Forms.ComboBox
		Me.cboWSMethodCode = New System.Windows.Forms.ComboBox
		Me.cboWSPayCode = New System.Windows.Forms.ComboBox
		Me.cboCurr = New System.Windows.Forms.ComboBox
		Me.cboWSID = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtWSExcr = New System.Windows.Forms.TextBox
		Me.txtWSID = New System.Windows.Forms.TextBox
		Me.lblDspWsSaleName = New System.Windows.Forms.Label
		Me.lblWSSale = New System.Windows.Forms.Label
		Me.lblDspWsVdrName = New System.Windows.Forms.Label
		Me.lblWSVdr = New System.Windows.Forms.Label
		Me.lblDspWsCusName = New System.Windows.Forms.Label
		Me.lblWSCus = New System.Windows.Forms.Label
		Me.lblDspWSWhsDesc = New System.Windows.Forms.Label
		Me.lblWSWhsCode = New System.Windows.Forms.Label
		Me.lblDspWSMethodDesc = New System.Windows.Forms.Label
		Me.lblWSMethodCode = New System.Windows.Forms.Label
		Me.lblDspWSPayDesc = New System.Windows.Forms.Label
		Me.lblWSPayCode = New System.Windows.Forms.Label
		Me.lblWSExcr = New System.Windows.Forms.Label
		Me.lblCurr = New System.Windows.Forms.Label
		Me.lblWSLastUpd = New System.Windows.Forms.Label
		Me.lblWSLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspWSLastUpd = New System.Windows.Forms.Label
		Me.lblDspWSLastUpdDate = New System.Windows.Forms.Label
		Me.lblWSID = New System.Windows.Forms.Label
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
		Me.fraDetailInfo.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "WSINFO"
		Me.ClientSize = New System.Drawing.Size(572, 378)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmWS001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmWS001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 11
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboWsSaleCode.Size = New System.Drawing.Size(89, 20)
		Me.cboWsSaleCode.Location = New System.Drawing.Point(160, 256)
		Me.cboWsSaleCode.TabIndex = 1
		Me.cboWsSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWsSaleCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWsSaleCode.CausesValidation = True
		Me.cboWsSaleCode.Enabled = True
		Me.cboWsSaleCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWsSaleCode.IntegralHeight = True
		Me.cboWsSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWsSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWsSaleCode.Sorted = False
		Me.cboWsSaleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWsSaleCode.TabStop = True
		Me.cboWsSaleCode.Visible = True
		Me.cboWsSaleCode.Name = "cboWsSaleCode"
		Me.cboWsVdrCode.Size = New System.Drawing.Size(89, 20)
		Me.cboWsVdrCode.Location = New System.Drawing.Point(160, 232)
		Me.cboWsVdrCode.TabIndex = 31
		Me.cboWsVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWsVdrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWsVdrCode.CausesValidation = True
		Me.cboWsVdrCode.Enabled = True
		Me.cboWsVdrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWsVdrCode.IntegralHeight = True
		Me.cboWsVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWsVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWsVdrCode.Sorted = False
		Me.cboWsVdrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWsVdrCode.TabStop = True
		Me.cboWsVdrCode.Visible = True
		Me.cboWsVdrCode.Name = "cboWsVdrCode"
		Me.cboWsCusCode.Size = New System.Drawing.Size(89, 20)
		Me.cboWsCusCode.Location = New System.Drawing.Point(160, 208)
		Me.cboWsCusCode.TabIndex = 30
		Me.cboWsCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWsCusCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWsCusCode.CausesValidation = True
		Me.cboWsCusCode.Enabled = True
		Me.cboWsCusCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWsCusCode.IntegralHeight = True
		Me.cboWsCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWsCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWsCusCode.Sorted = False
		Me.cboWsCusCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWsCusCode.TabStop = True
		Me.cboWsCusCode.Visible = True
		Me.cboWsCusCode.Name = "cboWsCusCode"
		Me.cboWSWhsCode.Size = New System.Drawing.Size(89, 20)
		Me.cboWSWhsCode.Location = New System.Drawing.Point(160, 184)
		Me.cboWSWhsCode.TabIndex = 23
		Me.cboWSWhsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWSWhsCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWSWhsCode.CausesValidation = True
		Me.cboWSWhsCode.Enabled = True
		Me.cboWSWhsCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWSWhsCode.IntegralHeight = True
		Me.cboWSWhsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWSWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWSWhsCode.Sorted = False
		Me.cboWSWhsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWSWhsCode.TabStop = True
		Me.cboWSWhsCode.Visible = True
		Me.cboWSWhsCode.Name = "cboWSWhsCode"
		Me.cboWSMethodCode.Size = New System.Drawing.Size(89, 20)
		Me.cboWSMethodCode.Location = New System.Drawing.Point(160, 160)
		Me.cboWSMethodCode.TabIndex = 20
		Me.cboWSMethodCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWSMethodCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWSMethodCode.CausesValidation = True
		Me.cboWSMethodCode.Enabled = True
		Me.cboWSMethodCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWSMethodCode.IntegralHeight = True
		Me.cboWSMethodCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWSMethodCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWSMethodCode.Sorted = False
		Me.cboWSMethodCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWSMethodCode.TabStop = True
		Me.cboWSMethodCode.Visible = True
		Me.cboWSMethodCode.Name = "cboWSMethodCode"
		Me.cboWSPayCode.Size = New System.Drawing.Size(89, 20)
		Me.cboWSPayCode.Location = New System.Drawing.Point(160, 136)
		Me.cboWSPayCode.TabIndex = 17
		Me.cboWSPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWSPayCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWSPayCode.CausesValidation = True
		Me.cboWSPayCode.Enabled = True
		Me.cboWSPayCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWSPayCode.IntegralHeight = True
		Me.cboWSPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWSPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWSPayCode.Sorted = False
		Me.cboWSPayCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWSPayCode.TabStop = True
		Me.cboWSPayCode.Visible = True
		Me.cboWSPayCode.Name = "cboWSPayCode"
		Me.cboCurr.Size = New System.Drawing.Size(89, 20)
		Me.cboCurr.Location = New System.Drawing.Point(160, 88)
		Me.cboCurr.TabIndex = 3
		Me.cboCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCurr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCurr.CausesValidation = True
		Me.cboCurr.Enabled = True
		Me.cboCurr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCurr.IntegralHeight = True
		Me.cboCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCurr.Sorted = False
		Me.cboCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCurr.TabStop = True
		Me.cboCurr.Visible = True
		Me.cboCurr.Name = "cboCurr"
		Me.cboWSID.Size = New System.Drawing.Size(89, 20)
		Me.cboWSID.Location = New System.Drawing.Point(160, 64)
		Me.cboWSID.TabIndex = 2
		Me.cboWSID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWSID.BackColor = System.Drawing.SystemColors.Window
		Me.cboWSID.CausesValidation = True
		Me.cboWSID.Enabled = True
		Me.cboWSID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWSID.IntegralHeight = True
		Me.cboWSID.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWSID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWSID.Sorted = False
		Me.cboWSID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWSID.TabStop = True
		Me.cboWSID.Visible = True
		Me.cboWSID.Name = "cboWSID"
		Me.fraDetailInfo.Text = "FRADETAILINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 345)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 4
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtWSExcr.AutoSize = False
		Me.txtWSExcr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtWSExcr.Size = New System.Drawing.Size(89, 20)
		Me.txtWSExcr.Location = New System.Drawing.Point(152, 88)
		Me.txtWSExcr.Maxlength = 20
		Me.txtWSExcr.TabIndex = 13
		Me.txtWSExcr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWSExcr.AcceptsReturn = True
		Me.txtWSExcr.BackColor = System.Drawing.SystemColors.Window
		Me.txtWSExcr.CausesValidation = True
		Me.txtWSExcr.Enabled = True
		Me.txtWSExcr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWSExcr.HideSelection = True
		Me.txtWSExcr.ReadOnly = False
		Me.txtWSExcr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWSExcr.MultiLine = False
		Me.txtWSExcr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWSExcr.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWSExcr.TabStop = True
		Me.txtWSExcr.Visible = True
		Me.txtWSExcr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWSExcr.Name = "txtWSExcr"
		Me.txtWSID.AutoSize = False
		Me.txtWSID.Size = New System.Drawing.Size(89, 20)
		Me.txtWSID.Location = New System.Drawing.Point(152, 40)
		Me.txtWSID.TabIndex = 0
		Me.txtWSID.Tag = "K"
		Me.txtWSID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWSID.AcceptsReturn = True
		Me.txtWSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWSID.BackColor = System.Drawing.SystemColors.Window
		Me.txtWSID.CausesValidation = True
		Me.txtWSID.Enabled = True
		Me.txtWSID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWSID.HideSelection = True
		Me.txtWSID.ReadOnly = False
		Me.txtWSID.Maxlength = 0
		Me.txtWSID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWSID.MultiLine = False
		Me.txtWSID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWSID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWSID.TabStop = True
		Me.txtWSID.Visible = True
		Me.txtWSID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWSID.Name = "txtWSID"
		Me.lblDspWsSaleName.Size = New System.Drawing.Size(289, 20)
		Me.lblDspWsSaleName.Location = New System.Drawing.Point(256, 232)
		Me.lblDspWsSaleName.TabIndex = 29
		Me.lblDspWsSaleName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWsSaleName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWsSaleName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWsSaleName.Enabled = True
		Me.lblDspWsSaleName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWsSaleName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWsSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWsSaleName.UseMnemonic = True
		Me.lblDspWsSaleName.Visible = True
		Me.lblDspWsSaleName.AutoSize = False
		Me.lblDspWsSaleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWsSaleName.Name = "lblDspWsSaleName"
		Me.lblWSSale.Text = "WSSALE"
		Me.lblWSSale.Size = New System.Drawing.Size(140, 16)
		Me.lblWSSale.Location = New System.Drawing.Point(8, 236)
		Me.lblWSSale.TabIndex = 28
		Me.lblWSSale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSSale.Enabled = True
		Me.lblWSSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSSale.UseMnemonic = True
		Me.lblWSSale.Visible = True
		Me.lblWSSale.AutoSize = False
		Me.lblWSSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSSale.Name = "lblWSSale"
		Me.lblDspWsVdrName.Size = New System.Drawing.Size(289, 20)
		Me.lblDspWsVdrName.Location = New System.Drawing.Point(256, 208)
		Me.lblDspWsVdrName.TabIndex = 27
		Me.lblDspWsVdrName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWsVdrName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWsVdrName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWsVdrName.Enabled = True
		Me.lblDspWsVdrName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWsVdrName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWsVdrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWsVdrName.UseMnemonic = True
		Me.lblDspWsVdrName.Visible = True
		Me.lblDspWsVdrName.AutoSize = False
		Me.lblDspWsVdrName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWsVdrName.Name = "lblDspWsVdrName"
		Me.lblWSVdr.Text = "WSVDR"
		Me.lblWSVdr.Size = New System.Drawing.Size(140, 16)
		Me.lblWSVdr.Location = New System.Drawing.Point(8, 212)
		Me.lblWSVdr.TabIndex = 26
		Me.lblWSVdr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSVdr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSVdr.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSVdr.Enabled = True
		Me.lblWSVdr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSVdr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSVdr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSVdr.UseMnemonic = True
		Me.lblWSVdr.Visible = True
		Me.lblWSVdr.AutoSize = False
		Me.lblWSVdr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSVdr.Name = "lblWSVdr"
		Me.lblDspWsCusName.Size = New System.Drawing.Size(289, 20)
		Me.lblDspWsCusName.Location = New System.Drawing.Point(256, 184)
		Me.lblDspWsCusName.TabIndex = 25
		Me.lblDspWsCusName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWsCusName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWsCusName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWsCusName.Enabled = True
		Me.lblDspWsCusName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWsCusName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWsCusName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWsCusName.UseMnemonic = True
		Me.lblDspWsCusName.Visible = True
		Me.lblDspWsCusName.AutoSize = False
		Me.lblDspWsCusName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWsCusName.Name = "lblDspWsCusName"
		Me.lblWSCus.Text = "WSCUS"
		Me.lblWSCus.Size = New System.Drawing.Size(140, 16)
		Me.lblWSCus.Location = New System.Drawing.Point(8, 188)
		Me.lblWSCus.TabIndex = 24
		Me.lblWSCus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSCus.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSCus.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSCus.Enabled = True
		Me.lblWSCus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSCus.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSCus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSCus.UseMnemonic = True
		Me.lblWSCus.Visible = True
		Me.lblWSCus.AutoSize = False
		Me.lblWSCus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSCus.Name = "lblWSCus"
		Me.lblDspWSWhsDesc.Size = New System.Drawing.Size(289, 20)
		Me.lblDspWSWhsDesc.Location = New System.Drawing.Point(256, 160)
		Me.lblDspWSWhsDesc.TabIndex = 22
		Me.lblDspWSWhsDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWSWhsDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWSWhsDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWSWhsDesc.Enabled = True
		Me.lblDspWSWhsDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWSWhsDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWSWhsDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWSWhsDesc.UseMnemonic = True
		Me.lblDspWSWhsDesc.Visible = True
		Me.lblDspWSWhsDesc.AutoSize = False
		Me.lblDspWSWhsDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWSWhsDesc.Name = "lblDspWSWhsDesc"
		Me.lblWSWhsCode.Text = "WHSCODE"
		Me.lblWSWhsCode.Size = New System.Drawing.Size(140, 16)
		Me.lblWSWhsCode.Location = New System.Drawing.Point(8, 164)
		Me.lblWSWhsCode.TabIndex = 21
		Me.lblWSWhsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSWhsCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSWhsCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSWhsCode.Enabled = True
		Me.lblWSWhsCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSWhsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSWhsCode.UseMnemonic = True
		Me.lblWSWhsCode.Visible = True
		Me.lblWSWhsCode.AutoSize = False
		Me.lblWSWhsCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSWhsCode.Name = "lblWSWhsCode"
		Me.lblDspWSMethodDesc.Size = New System.Drawing.Size(289, 20)
		Me.lblDspWSMethodDesc.Location = New System.Drawing.Point(256, 136)
		Me.lblDspWSMethodDesc.TabIndex = 19
		Me.lblDspWSMethodDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWSMethodDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWSMethodDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWSMethodDesc.Enabled = True
		Me.lblDspWSMethodDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWSMethodDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWSMethodDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWSMethodDesc.UseMnemonic = True
		Me.lblDspWSMethodDesc.Visible = True
		Me.lblDspWSMethodDesc.AutoSize = False
		Me.lblDspWSMethodDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWSMethodDesc.Name = "lblDspWSMethodDesc"
		Me.lblWSMethodCode.Text = "METHODCODE"
		Me.lblWSMethodCode.Size = New System.Drawing.Size(140, 16)
		Me.lblWSMethodCode.Location = New System.Drawing.Point(8, 140)
		Me.lblWSMethodCode.TabIndex = 18
		Me.lblWSMethodCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSMethodCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSMethodCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSMethodCode.Enabled = True
		Me.lblWSMethodCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSMethodCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSMethodCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSMethodCode.UseMnemonic = True
		Me.lblWSMethodCode.Visible = True
		Me.lblWSMethodCode.AutoSize = False
		Me.lblWSMethodCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSMethodCode.Name = "lblWSMethodCode"
		Me.lblDspWSPayDesc.Size = New System.Drawing.Size(289, 20)
		Me.lblDspWSPayDesc.Location = New System.Drawing.Point(256, 112)
		Me.lblDspWSPayDesc.TabIndex = 16
		Me.lblDspWSPayDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWSPayDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWSPayDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWSPayDesc.Enabled = True
		Me.lblDspWSPayDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWSPayDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWSPayDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWSPayDesc.UseMnemonic = True
		Me.lblDspWSPayDesc.Visible = True
		Me.lblDspWSPayDesc.AutoSize = False
		Me.lblDspWSPayDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWSPayDesc.Name = "lblDspWSPayDesc"
		Me.lblWSPayCode.Text = "PAYCODE"
		Me.lblWSPayCode.Size = New System.Drawing.Size(140, 16)
		Me.lblWSPayCode.Location = New System.Drawing.Point(8, 116)
		Me.lblWSPayCode.TabIndex = 15
		Me.lblWSPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSPayCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSPayCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSPayCode.Enabled = True
		Me.lblWSPayCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSPayCode.UseMnemonic = True
		Me.lblWSPayCode.Visible = True
		Me.lblWSPayCode.AutoSize = False
		Me.lblWSPayCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSPayCode.Name = "lblWSPayCode"
		Me.lblWSExcr.Text = "EXCR"
		Me.lblWSExcr.Size = New System.Drawing.Size(140, 17)
		Me.lblWSExcr.Location = New System.Drawing.Point(8, 92)
		Me.lblWSExcr.TabIndex = 14
		Me.lblWSExcr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSExcr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSExcr.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSExcr.Enabled = True
		Me.lblWSExcr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSExcr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSExcr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSExcr.UseMnemonic = True
		Me.lblWSExcr.Visible = True
		Me.lblWSExcr.AutoSize = False
		Me.lblWSExcr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSExcr.Name = "lblWSExcr"
		Me.lblCurr.Text = "CURR"
		Me.lblCurr.Size = New System.Drawing.Size(140, 16)
		Me.lblCurr.Location = New System.Drawing.Point(8, 69)
		Me.lblCurr.TabIndex = 12
		Me.lblCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCurr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCurr.Enabled = True
		Me.lblCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCurr.UseMnemonic = True
		Me.lblCurr.Visible = True
		Me.lblCurr.AutoSize = False
		Me.lblCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCurr.Name = "lblCurr"
		Me.lblWSLastUpd.Text = "WSLASTUPD"
		Me.lblWSLastUpd.Size = New System.Drawing.Size(156, 16)
		Me.lblWSLastUpd.Location = New System.Drawing.Point(8, 315)
		Me.lblWSLastUpd.TabIndex = 9
		Me.lblWSLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSLastUpd.Enabled = True
		Me.lblWSLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSLastUpd.UseMnemonic = True
		Me.lblWSLastUpd.Visible = True
		Me.lblWSLastUpd.AutoSize = False
		Me.lblWSLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSLastUpd.Name = "lblWSLastUpd"
		Me.lblWSLastUpdDate.Text = "WSLASTUPDDATE"
		Me.lblWSLastUpdDate.Size = New System.Drawing.Size(164, 16)
		Me.lblWSLastUpdDate.Location = New System.Drawing.Point(272, 315)
		Me.lblWSLastUpdDate.TabIndex = 8
		Me.lblWSLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWSLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSLastUpdDate.Enabled = True
		Me.lblWSLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSLastUpdDate.UseMnemonic = True
		Me.lblWSLastUpdDate.Visible = True
		Me.lblWSLastUpdDate.AutoSize = False
		Me.lblWSLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSLastUpdDate.Name = "lblWSLastUpdDate"
		Me.lblDspWSLastUpd.Size = New System.Drawing.Size(87, 20)
		Me.lblDspWSLastUpd.Location = New System.Drawing.Point(168, 312)
		Me.lblDspWSLastUpd.TabIndex = 7
		Me.lblDspWSLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWSLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWSLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWSLastUpd.Enabled = True
		Me.lblDspWSLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWSLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWSLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWSLastUpd.UseMnemonic = True
		Me.lblDspWSLastUpd.Visible = True
		Me.lblDspWSLastUpd.AutoSize = False
		Me.lblDspWSLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWSLastUpd.Name = "lblDspWSLastUpd"
		Me.lblDspWSLastUpdDate.Size = New System.Drawing.Size(87, 20)
		Me.lblDspWSLastUpdDate.Location = New System.Drawing.Point(456, 312)
		Me.lblDspWSLastUpdDate.TabIndex = 6
		Me.lblDspWSLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWSLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWSLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWSLastUpdDate.Enabled = True
		Me.lblDspWSLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWSLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWSLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWSLastUpdDate.UseMnemonic = True
		Me.lblDspWSLastUpdDate.Visible = True
		Me.lblDspWSLastUpdDate.AutoSize = False
		Me.lblDspWSLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWSLastUpdDate.Name = "lblDspWSLastUpdDate"
		Me.lblWSID.Text = "WSID"
		Me.lblWSID.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblWSID.Size = New System.Drawing.Size(140, 16)
		Me.lblWSID.Location = New System.Drawing.Point(8, 44)
		Me.lblWSID.TabIndex = 5
		Me.lblWSID.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWSID.BackColor = System.Drawing.SystemColors.Control
		Me.lblWSID.Enabled = True
		Me.lblWSID.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWSID.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWSID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWSID.UseMnemonic = True
		Me.lblWSID.Visible = True
		Me.lblWSID.AutoSize = False
		Me.lblWSID.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWSID.Name = "lblWSID"
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
		Me.tbrProcess.TabIndex = 10
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
		Me.Controls.Add(cboWsSaleCode)
		Me.Controls.Add(cboWsVdrCode)
		Me.Controls.Add(cboWsCusCode)
		Me.Controls.Add(cboWSWhsCode)
		Me.Controls.Add(cboWSMethodCode)
		Me.Controls.Add(cboWSPayCode)
		Me.Controls.Add(cboCurr)
		Me.Controls.Add(cboWSID)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtWSExcr)
		Me.fraDetailInfo.Controls.Add(txtWSID)
		Me.fraDetailInfo.Controls.Add(lblDspWsSaleName)
		Me.fraDetailInfo.Controls.Add(lblWSSale)
		Me.fraDetailInfo.Controls.Add(lblDspWsVdrName)
		Me.fraDetailInfo.Controls.Add(lblWSVdr)
		Me.fraDetailInfo.Controls.Add(lblDspWsCusName)
		Me.fraDetailInfo.Controls.Add(lblWSCus)
		Me.fraDetailInfo.Controls.Add(lblDspWSWhsDesc)
		Me.fraDetailInfo.Controls.Add(lblWSWhsCode)
		Me.fraDetailInfo.Controls.Add(lblDspWSMethodDesc)
		Me.fraDetailInfo.Controls.Add(lblWSMethodCode)
		Me.fraDetailInfo.Controls.Add(lblDspWSPayDesc)
		Me.fraDetailInfo.Controls.Add(lblWSPayCode)
		Me.fraDetailInfo.Controls.Add(lblWSExcr)
		Me.fraDetailInfo.Controls.Add(lblCurr)
		Me.fraDetailInfo.Controls.Add(lblWSLastUpd)
		Me.fraDetailInfo.Controls.Add(lblWSLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspWSLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspWSLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblWSID)
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
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class