<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSYS002
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
	Public WithEvents cboDocType As System.Windows.Forms.ComboBox
	Public WithEvents txtDocLastYr As System.Windows.Forms.TextBox
	Public WithEvents chkDocYear As System.Windows.Forms.CheckBox
	Public WithEvents txtDocLastKey As System.Windows.Forms.TextBox
	Public WithEvents txtDocLen As System.Windows.Forms.TextBox
	Public WithEvents txtDocType As System.Windows.Forms.TextBox
	Public WithEvents txtDocPrefix As System.Windows.Forms.TextBox
	Public WithEvents txtDocTypeDesc As System.Windows.Forms.TextBox
	Public WithEvents lblDocLastYr As System.Windows.Forms.Label
	Public WithEvents lblDocLastKey As System.Windows.Forms.Label
	Public WithEvents lblDocLen As System.Windows.Forms.Label
	Public WithEvents lblDocType As System.Windows.Forms.Label
	Public WithEvents lblDocPrefix As System.Windows.Forms.Label
	Public WithEvents lblDocTypeDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSYS002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboDocType = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtDocLastYr = New System.Windows.Forms.TextBox
		Me.chkDocYear = New System.Windows.Forms.CheckBox
		Me.txtDocLastKey = New System.Windows.Forms.TextBox
		Me.txtDocLen = New System.Windows.Forms.TextBox
		Me.txtDocType = New System.Windows.Forms.TextBox
		Me.txtDocPrefix = New System.Windows.Forms.TextBox
		Me.txtDocTypeDesc = New System.Windows.Forms.TextBox
		Me.lblDocLastYr = New System.Windows.Forms.Label
		Me.lblDocLastKey = New System.Windows.Forms.Label
		Me.lblDocLen = New System.Windows.Forms.Label
		Me.lblDocType = New System.Windows.Forms.Label
		Me.lblDocPrefix = New System.Windows.Forms.Label
		Me.lblDocTypeDesc = New System.Windows.Forms.Label
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
		Me.Text = "文件號"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmSYS002.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSYS002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 13
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboDocType.Size = New System.Drawing.Size(182, 20)
		Me.cboDocType.Location = New System.Drawing.Point(120, 64)
		Me.cboDocType.TabIndex = 1
		Me.cboDocType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocType.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocType.CausesValidation = True
		Me.cboDocType.Enabled = True
		Me.cboDocType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocType.IntegralHeight = True
		Me.cboDocType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocType.Sorted = False
		Me.cboDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocType.TabStop = True
		Me.cboDocType.Visible = True
		Me.cboDocType.Name = "cboDocType"
		Me.fraDetailInfo.Text = "文件號"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 201)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 8
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtDocLastYr.AutoSize = False
		Me.txtDocLastYr.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtDocLastYr.Enabled = False
		Me.txtDocLastYr.Size = New System.Drawing.Size(46, 20)
		Me.txtDocLastYr.Location = New System.Drawing.Point(248, 160)
		Me.txtDocLastYr.TabIndex = 7
		Me.txtDocLastYr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocLastYr.AcceptsReturn = True
		Me.txtDocLastYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDocLastYr.CausesValidation = True
		Me.txtDocLastYr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocLastYr.HideSelection = True
		Me.txtDocLastYr.ReadOnly = False
		Me.txtDocLastYr.Maxlength = 0
		Me.txtDocLastYr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocLastYr.MultiLine = False
		Me.txtDocLastYr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDocLastYr.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocLastYr.TabStop = True
		Me.txtDocLastYr.Visible = True
		Me.txtDocLastYr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocLastYr.Name = "txtDocLastYr"
		Me.chkDocYear.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkDocYear.Text = "DOCYEAR"
		Me.chkDocYear.Size = New System.Drawing.Size(161, 12)
		Me.chkDocYear.Location = New System.Drawing.Point(24, 166)
		Me.chkDocYear.TabIndex = 6
		Me.chkDocYear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDocYear.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkDocYear.BackColor = System.Drawing.SystemColors.Control
		Me.chkDocYear.CausesValidation = True
		Me.chkDocYear.Enabled = True
		Me.chkDocYear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkDocYear.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkDocYear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkDocYear.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkDocYear.TabStop = True
		Me.chkDocYear.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkDocYear.Visible = True
		Me.chkDocYear.Name = "chkDocYear"
		Me.txtDocLastKey.AutoSize = False
		Me.txtDocLastKey.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtDocLastKey.Enabled = False
		Me.txtDocLastKey.Size = New System.Drawing.Size(182, 20)
		Me.txtDocLastKey.Location = New System.Drawing.Point(112, 136)
		Me.txtDocLastKey.TabIndex = 5
		Me.txtDocLastKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocLastKey.AcceptsReturn = True
		Me.txtDocLastKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDocLastKey.CausesValidation = True
		Me.txtDocLastKey.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocLastKey.HideSelection = True
		Me.txtDocLastKey.ReadOnly = False
		Me.txtDocLastKey.Maxlength = 0
		Me.txtDocLastKey.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocLastKey.MultiLine = False
		Me.txtDocLastKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDocLastKey.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocLastKey.TabStop = True
		Me.txtDocLastKey.Visible = True
		Me.txtDocLastKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocLastKey.Name = "txtDocLastKey"
		Me.txtDocLen.AutoSize = False
		Me.txtDocLen.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtDocLen.Enabled = False
		Me.txtDocLen.Size = New System.Drawing.Size(182, 20)
		Me.txtDocLen.Location = New System.Drawing.Point(112, 112)
		Me.txtDocLen.TabIndex = 4
		Me.txtDocLen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocLen.AcceptsReturn = True
		Me.txtDocLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDocLen.CausesValidation = True
		Me.txtDocLen.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocLen.HideSelection = True
		Me.txtDocLen.ReadOnly = False
		Me.txtDocLen.Maxlength = 0
		Me.txtDocLen.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocLen.MultiLine = False
		Me.txtDocLen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDocLen.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocLen.TabStop = True
		Me.txtDocLen.Visible = True
		Me.txtDocLen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocLen.Name = "txtDocLen"
		Me.txtDocType.AutoSize = False
		Me.txtDocType.Enabled = False
		Me.txtDocType.Size = New System.Drawing.Size(182, 20)
		Me.txtDocType.Location = New System.Drawing.Point(112, 40)
		Me.txtDocType.TabIndex = 0
		Me.txtDocType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocType.AcceptsReturn = True
		Me.txtDocType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDocType.BackColor = System.Drawing.SystemColors.Window
		Me.txtDocType.CausesValidation = True
		Me.txtDocType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocType.HideSelection = True
		Me.txtDocType.ReadOnly = False
		Me.txtDocType.Maxlength = 0
		Me.txtDocType.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocType.MultiLine = False
		Me.txtDocType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDocType.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocType.TabStop = True
		Me.txtDocType.Visible = True
		Me.txtDocType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocType.Name = "txtDocType"
		Me.txtDocPrefix.AutoSize = False
		Me.txtDocPrefix.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtDocPrefix.Enabled = False
		Me.txtDocPrefix.Size = New System.Drawing.Size(182, 20)
		Me.txtDocPrefix.Location = New System.Drawing.Point(112, 88)
		Me.txtDocPrefix.TabIndex = 3
		Me.txtDocPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocPrefix.AcceptsReturn = True
		Me.txtDocPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDocPrefix.CausesValidation = True
		Me.txtDocPrefix.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocPrefix.HideSelection = True
		Me.txtDocPrefix.ReadOnly = False
		Me.txtDocPrefix.Maxlength = 0
		Me.txtDocPrefix.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocPrefix.MultiLine = False
		Me.txtDocPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDocPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocPrefix.TabStop = True
		Me.txtDocPrefix.Visible = True
		Me.txtDocPrefix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocPrefix.Name = "txtDocPrefix"
		Me.txtDocTypeDesc.AutoSize = False
		Me.txtDocTypeDesc.Enabled = False
		Me.txtDocTypeDesc.Size = New System.Drawing.Size(430, 20)
		Me.txtDocTypeDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtDocTypeDesc.TabIndex = 2
		Me.txtDocTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDocTypeDesc.AcceptsReturn = True
		Me.txtDocTypeDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDocTypeDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtDocTypeDesc.CausesValidation = True
		Me.txtDocTypeDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocTypeDesc.HideSelection = True
		Me.txtDocTypeDesc.ReadOnly = False
		Me.txtDocTypeDesc.Maxlength = 0
		Me.txtDocTypeDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocTypeDesc.MultiLine = False
		Me.txtDocTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDocTypeDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocTypeDesc.TabStop = True
		Me.txtDocTypeDesc.Visible = True
		Me.txtDocTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocTypeDesc.Name = "txtDocTypeDesc"
		Me.lblDocLastYr.Text = "DOCLASTYR"
		Me.lblDocLastYr.Size = New System.Drawing.Size(52, 12)
		Me.lblDocLastYr.Location = New System.Drawing.Point(192, 165)
		Me.lblDocLastYr.TabIndex = 16
		Me.lblDocLastYr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocLastYr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocLastYr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocLastYr.Enabled = True
		Me.lblDocLastYr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocLastYr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocLastYr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocLastYr.UseMnemonic = True
		Me.lblDocLastYr.Visible = True
		Me.lblDocLastYr.AutoSize = False
		Me.lblDocLastYr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocLastYr.Name = "lblDocLastYr"
		Me.lblDocLastKey.Text = "DOCLASTKEY"
		Me.lblDocLastKey.Size = New System.Drawing.Size(92, 16)
		Me.lblDocLastKey.Location = New System.Drawing.Point(24, 140)
		Me.lblDocLastKey.TabIndex = 15
		Me.lblDocLastKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocLastKey.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocLastKey.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocLastKey.Enabled = True
		Me.lblDocLastKey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocLastKey.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocLastKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocLastKey.UseMnemonic = True
		Me.lblDocLastKey.Visible = True
		Me.lblDocLastKey.AutoSize = False
		Me.lblDocLastKey.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocLastKey.Name = "lblDocLastKey"
		Me.lblDocLen.Text = "DOCLEN"
		Me.lblDocLen.Size = New System.Drawing.Size(92, 16)
		Me.lblDocLen.Location = New System.Drawing.Point(24, 116)
		Me.lblDocLen.TabIndex = 14
		Me.lblDocLen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocLen.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocLen.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocLen.Enabled = True
		Me.lblDocLen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocLen.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocLen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocLen.UseMnemonic = True
		Me.lblDocLen.Visible = True
		Me.lblDocLen.AutoSize = False
		Me.lblDocLen.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocLen.Name = "lblDocLen"
		Me.lblDocType.Text = "DOCTYPE"
		Me.lblDocType.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDocType.Size = New System.Drawing.Size(84, 16)
		Me.lblDocType.Location = New System.Drawing.Point(24, 44)
		Me.lblDocType.TabIndex = 12
		Me.lblDocType.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocType.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocType.Enabled = True
		Me.lblDocType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocType.UseMnemonic = True
		Me.lblDocType.Visible = True
		Me.lblDocType.AutoSize = False
		Me.lblDocType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocType.Name = "lblDocType"
		Me.lblDocPrefix.Text = "DOCPREFIX"
		Me.lblDocPrefix.Size = New System.Drawing.Size(92, 16)
		Me.lblDocPrefix.Location = New System.Drawing.Point(24, 92)
		Me.lblDocPrefix.TabIndex = 11
		Me.lblDocPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocPrefix.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocPrefix.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocPrefix.Enabled = True
		Me.lblDocPrefix.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocPrefix.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocPrefix.UseMnemonic = True
		Me.lblDocPrefix.Visible = True
		Me.lblDocPrefix.AutoSize = False
		Me.lblDocPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocPrefix.Name = "lblDocPrefix"
		Me.lblDocTypeDesc.Text = "DOCTYPEDESC"
		Me.lblDocTypeDesc.Size = New System.Drawing.Size(81, 17)
		Me.lblDocTypeDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblDocTypeDesc.TabIndex = 10
		Me.lblDocTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocTypeDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocTypeDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocTypeDesc.Enabled = True
		Me.lblDocTypeDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocTypeDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocTypeDesc.UseMnemonic = True
		Me.lblDocTypeDesc.Visible = True
		Me.lblDocTypeDesc.AutoSize = False
		Me.lblDocTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocTypeDesc.Name = "lblDocTypeDesc"
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
		Me.tbrProcess.TabIndex = 9
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
		Me.Controls.Add(cboDocType)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtDocLastYr)
		Me.fraDetailInfo.Controls.Add(chkDocYear)
		Me.fraDetailInfo.Controls.Add(txtDocLastKey)
		Me.fraDetailInfo.Controls.Add(txtDocLen)
		Me.fraDetailInfo.Controls.Add(txtDocType)
		Me.fraDetailInfo.Controls.Add(txtDocPrefix)
		Me.fraDetailInfo.Controls.Add(txtDocTypeDesc)
		Me.fraDetailInfo.Controls.Add(lblDocLastYr)
		Me.fraDetailInfo.Controls.Add(lblDocLastKey)
		Me.fraDetailInfo.Controls.Add(lblDocLen)
		Me.fraDetailInfo.Controls.Add(lblDocType)
		Me.fraDetailInfo.Controls.Add(lblDocPrefix)
		Me.fraDetailInfo.Controls.Add(lblDocTypeDesc)
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