<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUSR001
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
	Public WithEvents cboUsrGrpCode As System.Windows.Forms.ComboBox
	Public WithEvents cboUsrCode As System.Windows.Forms.ComboBox
	Public WithEvents txtUsrPwd1 As System.Windows.Forms.TextBox
	Public WithEvents txtUsrPwd As System.Windows.Forms.TextBox
	Public WithEvents txtUsrCode As System.Windows.Forms.TextBox
	Public WithEvents txtUsrName As System.Windows.Forms.TextBox
	Public WithEvents lblUsrPwd1 As System.Windows.Forms.Label
	Public WithEvents lblUsrPwd As System.Windows.Forms.Label
	Public WithEvents lblUsrLastUpd As System.Windows.Forms.Label
	Public WithEvents lblUsrLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspUsrLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspUsrLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblUsrCode As System.Windows.Forms.Label
	Public WithEvents lblUsrGrpCode As System.Windows.Forms.Label
	Public WithEvents lblUsrName As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUSR001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboUsrGrpCode = New System.Windows.Forms.ComboBox
		Me.cboUsrCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtUsrPwd1 = New System.Windows.Forms.TextBox
		Me.txtUsrPwd = New System.Windows.Forms.TextBox
		Me.txtUsrCode = New System.Windows.Forms.TextBox
		Me.txtUsrName = New System.Windows.Forms.TextBox
		Me.lblUsrPwd1 = New System.Windows.Forms.Label
		Me.lblUsrPwd = New System.Windows.Forms.Label
		Me.lblUsrLastUpd = New System.Windows.Forms.Label
		Me.lblUsrLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspUsrLastUpd = New System.Windows.Forms.Label
		Me.lblDspUsrLastUpdDate = New System.Windows.Forms.Label
		Me.lblUsrCode = New System.Windows.Forms.Label
		Me.lblUsrGrpCode = New System.Windows.Forms.Label
		Me.lblUsrName = New System.Windows.Forms.Label
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
		Me.Text = "USR001"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmUSR001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmUSR001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 15
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboUsrGrpCode.Size = New System.Drawing.Size(182, 20)
		Me.cboUsrGrpCode.Location = New System.Drawing.Point(120, 112)
		Me.cboUsrGrpCode.TabIndex = 2
		Me.cboUsrGrpCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsrGrpCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboUsrGrpCode.CausesValidation = True
		Me.cboUsrGrpCode.Enabled = True
		Me.cboUsrGrpCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUsrGrpCode.IntegralHeight = True
		Me.cboUsrGrpCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUsrGrpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUsrGrpCode.Sorted = False
		Me.cboUsrGrpCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUsrGrpCode.TabStop = True
		Me.cboUsrGrpCode.Visible = True
		Me.cboUsrGrpCode.Name = "cboUsrGrpCode"
		Me.cboUsrCode.Size = New System.Drawing.Size(182, 20)
		Me.cboUsrCode.Location = New System.Drawing.Point(120, 64)
		Me.cboUsrCode.TabIndex = 0
		Me.cboUsrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboUsrCode.CausesValidation = True
		Me.cboUsrCode.Enabled = True
		Me.cboUsrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUsrCode.IntegralHeight = True
		Me.cboUsrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUsrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUsrCode.Sorted = False
		Me.cboUsrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUsrCode.TabStop = True
		Me.cboUsrCode.Visible = True
		Me.cboUsrCode.Name = "cboUsrCode"
		Me.fraDetailInfo.Text = "USRINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 201)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 6
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtUsrPwd1.AutoSize = False
		Me.txtUsrPwd1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtUsrPwd1.Enabled = False
		Me.txtUsrPwd1.Size = New System.Drawing.Size(185, 20)
		Me.txtUsrPwd1.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtUsrPwd1.Location = New System.Drawing.Point(112, 136)
		Me.txtUsrPwd1.PasswordChar = ChrW(42)
		Me.txtUsrPwd1.TabIndex = 4
		Me.txtUsrPwd1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsrPwd1.AcceptsReturn = True
		Me.txtUsrPwd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUsrPwd1.CausesValidation = True
		Me.txtUsrPwd1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUsrPwd1.HideSelection = True
		Me.txtUsrPwd1.ReadOnly = False
		Me.txtUsrPwd1.Maxlength = 0
		Me.txtUsrPwd1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsrPwd1.MultiLine = False
		Me.txtUsrPwd1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsrPwd1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsrPwd1.TabStop = True
		Me.txtUsrPwd1.Visible = True
		Me.txtUsrPwd1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUsrPwd1.Name = "txtUsrPwd1"
		Me.txtUsrPwd.AutoSize = False
		Me.txtUsrPwd.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtUsrPwd.Enabled = False
		Me.txtUsrPwd.Size = New System.Drawing.Size(185, 20)
		Me.txtUsrPwd.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtUsrPwd.Location = New System.Drawing.Point(112, 112)
		Me.txtUsrPwd.PasswordChar = ChrW(42)
		Me.txtUsrPwd.TabIndex = 3
		Me.txtUsrPwd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsrPwd.AcceptsReturn = True
		Me.txtUsrPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUsrPwd.CausesValidation = True
		Me.txtUsrPwd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUsrPwd.HideSelection = True
		Me.txtUsrPwd.ReadOnly = False
		Me.txtUsrPwd.Maxlength = 0
		Me.txtUsrPwd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsrPwd.MultiLine = False
		Me.txtUsrPwd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsrPwd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsrPwd.TabStop = True
		Me.txtUsrPwd.Visible = True
		Me.txtUsrPwd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUsrPwd.Name = "txtUsrPwd"
		Me.txtUsrCode.AutoSize = False
		Me.txtUsrCode.Enabled = False
		Me.txtUsrCode.Size = New System.Drawing.Size(182, 20)
		Me.txtUsrCode.Location = New System.Drawing.Point(112, 40)
		Me.txtUsrCode.TabIndex = 5
		Me.txtUsrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsrCode.AcceptsReturn = True
		Me.txtUsrCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUsrCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtUsrCode.CausesValidation = True
		Me.txtUsrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUsrCode.HideSelection = True
		Me.txtUsrCode.ReadOnly = False
		Me.txtUsrCode.Maxlength = 0
		Me.txtUsrCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsrCode.MultiLine = False
		Me.txtUsrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsrCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsrCode.TabStop = True
		Me.txtUsrCode.Visible = True
		Me.txtUsrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUsrCode.Name = "txtUsrCode"
		Me.txtUsrName.AutoSize = False
		Me.txtUsrName.Enabled = False
		Me.txtUsrName.Size = New System.Drawing.Size(185, 20)
		Me.txtUsrName.Location = New System.Drawing.Point(112, 64)
		Me.txtUsrName.TabIndex = 1
		Me.txtUsrName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsrName.AcceptsReturn = True
		Me.txtUsrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUsrName.BackColor = System.Drawing.SystemColors.Window
		Me.txtUsrName.CausesValidation = True
		Me.txtUsrName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUsrName.HideSelection = True
		Me.txtUsrName.ReadOnly = False
		Me.txtUsrName.Maxlength = 0
		Me.txtUsrName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsrName.MultiLine = False
		Me.txtUsrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsrName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsrName.TabStop = True
		Me.txtUsrName.Visible = True
		Me.txtUsrName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUsrName.Name = "txtUsrName"
		Me.lblUsrPwd1.Text = "USRPWD1"
		Me.lblUsrPwd1.Size = New System.Drawing.Size(92, 16)
		Me.lblUsrPwd1.Location = New System.Drawing.Point(24, 140)
		Me.lblUsrPwd1.TabIndex = 17
		Me.lblUsrPwd1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrPwd1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrPwd1.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrPwd1.Enabled = True
		Me.lblUsrPwd1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrPwd1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrPwd1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrPwd1.UseMnemonic = True
		Me.lblUsrPwd1.Visible = True
		Me.lblUsrPwd1.AutoSize = False
		Me.lblUsrPwd1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrPwd1.Name = "lblUsrPwd1"
		Me.lblUsrPwd.Text = "USRPWD"
		Me.lblUsrPwd.Size = New System.Drawing.Size(92, 16)
		Me.lblUsrPwd.Location = New System.Drawing.Point(24, 116)
		Me.lblUsrPwd.TabIndex = 16
		Me.lblUsrPwd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrPwd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrPwd.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrPwd.Enabled = True
		Me.lblUsrPwd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrPwd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrPwd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrPwd.UseMnemonic = True
		Me.lblUsrPwd.Visible = True
		Me.lblUsrPwd.AutoSize = False
		Me.lblUsrPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrPwd.Name = "lblUsrPwd"
		Me.lblUsrLastUpd.Text = "USRLASTUPD"
		Me.lblUsrLastUpd.Size = New System.Drawing.Size(100, 16)
		Me.lblUsrLastUpd.Location = New System.Drawing.Point(24, 171)
		Me.lblUsrLastUpd.TabIndex = 14
		Me.lblUsrLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrLastUpd.Enabled = True
		Me.lblUsrLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrLastUpd.UseMnemonic = True
		Me.lblUsrLastUpd.Visible = True
		Me.lblUsrLastUpd.AutoSize = False
		Me.lblUsrLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrLastUpd.Name = "lblUsrLastUpd"
		Me.lblUsrLastUpdDate.Text = "USRLASTUPDDATE"
		Me.lblUsrLastUpdDate.Size = New System.Drawing.Size(100, 16)
		Me.lblUsrLastUpdDate.Location = New System.Drawing.Point(288, 171)
		Me.lblUsrLastUpdDate.TabIndex = 13
		Me.lblUsrLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrLastUpdDate.Enabled = True
		Me.lblUsrLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrLastUpdDate.UseMnemonic = True
		Me.lblUsrLastUpdDate.Visible = True
		Me.lblUsrLastUpdDate.AutoSize = False
		Me.lblUsrLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrLastUpdDate.Name = "lblUsrLastUpdDate"
		Me.lblDspUsrLastUpd.Size = New System.Drawing.Size(151, 20)
		Me.lblDspUsrLastUpd.Location = New System.Drawing.Point(128, 168)
		Me.lblDspUsrLastUpd.TabIndex = 12
		Me.lblDspUsrLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspUsrLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspUsrLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspUsrLastUpd.Enabled = True
		Me.lblDspUsrLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspUsrLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspUsrLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspUsrLastUpd.UseMnemonic = True
		Me.lblDspUsrLastUpd.Visible = True
		Me.lblDspUsrLastUpd.AutoSize = False
		Me.lblDspUsrLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspUsrLastUpd.Name = "lblDspUsrLastUpd"
		Me.lblDspUsrLastUpdDate.Size = New System.Drawing.Size(151, 20)
		Me.lblDspUsrLastUpdDate.Location = New System.Drawing.Point(392, 168)
		Me.lblDspUsrLastUpdDate.TabIndex = 11
		Me.lblDspUsrLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspUsrLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspUsrLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspUsrLastUpdDate.Enabled = True
		Me.lblDspUsrLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspUsrLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspUsrLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspUsrLastUpdDate.UseMnemonic = True
		Me.lblDspUsrLastUpdDate.Visible = True
		Me.lblDspUsrLastUpdDate.AutoSize = False
		Me.lblDspUsrLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspUsrLastUpdDate.Name = "lblDspUsrLastUpdDate"
		Me.lblUsrCode.Text = "USRCODE"
		Me.lblUsrCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblUsrCode.Size = New System.Drawing.Size(84, 16)
		Me.lblUsrCode.Location = New System.Drawing.Point(24, 44)
		Me.lblUsrCode.TabIndex = 10
		Me.lblUsrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrCode.Enabled = True
		Me.lblUsrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrCode.UseMnemonic = True
		Me.lblUsrCode.Visible = True
		Me.lblUsrCode.AutoSize = False
		Me.lblUsrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrCode.Name = "lblUsrCode"
		Me.lblUsrGrpCode.Text = "USRGRPCODE"
		Me.lblUsrGrpCode.Size = New System.Drawing.Size(92, 16)
		Me.lblUsrGrpCode.Location = New System.Drawing.Point(24, 92)
		Me.lblUsrGrpCode.TabIndex = 9
		Me.lblUsrGrpCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrGrpCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrGrpCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrGrpCode.Enabled = True
		Me.lblUsrGrpCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrGrpCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrGrpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrGrpCode.UseMnemonic = True
		Me.lblUsrGrpCode.Visible = True
		Me.lblUsrGrpCode.AutoSize = False
		Me.lblUsrGrpCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrGrpCode.Name = "lblUsrGrpCode"
		Me.lblUsrName.Text = "USRNAME"
		Me.lblUsrName.Size = New System.Drawing.Size(81, 17)
		Me.lblUsrName.Location = New System.Drawing.Point(24, 68)
		Me.lblUsrName.TabIndex = 8
		Me.lblUsrName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrName.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrName.Enabled = True
		Me.lblUsrName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrName.UseMnemonic = True
		Me.lblUsrName.Visible = True
		Me.lblUsrName.AutoSize = False
		Me.lblUsrName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrName.Name = "lblUsrName"
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
		Me.tbrProcess.TabIndex = 7
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
		Me.Controls.Add(cboUsrGrpCode)
		Me.Controls.Add(cboUsrCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtUsrPwd1)
		Me.fraDetailInfo.Controls.Add(txtUsrPwd)
		Me.fraDetailInfo.Controls.Add(txtUsrCode)
		Me.fraDetailInfo.Controls.Add(txtUsrName)
		Me.fraDetailInfo.Controls.Add(lblUsrPwd1)
		Me.fraDetailInfo.Controls.Add(lblUsrPwd)
		Me.fraDetailInfo.Controls.Add(lblUsrLastUpd)
		Me.fraDetailInfo.Controls.Add(lblUsrLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspUsrLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspUsrLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblUsrCode)
		Me.fraDetailInfo.Controls.Add(lblUsrGrpCode)
		Me.fraDetailInfo.Controls.Add(lblUsrName)
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