<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVOU001
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
	Public WithEvents cboVouType As System.Windows.Forms.ComboBox
	Public WithEvents cboVouPrefix As System.Windows.Forms.ComboBox
	Public WithEvents txtVouSpa As System.Windows.Forms.TextBox
	Public WithEvents chkVouYrFlg As System.Windows.Forms.CheckBox
	Public WithEvents chkVouMnFlg As System.Windows.Forms.CheckBox
	Public WithEvents txtVouDesc As System.Windows.Forms.TextBox
	Public WithEvents txtVouLastKey As System.Windows.Forms.TextBox
	Public WithEvents txtVouLen As System.Windows.Forms.TextBox
	Public WithEvents txtVouPrefix As System.Windows.Forms.TextBox
	Public WithEvents lblVouSpa As System.Windows.Forms.Label
	Public WithEvents lblVouType As System.Windows.Forms.Label
	Public WithEvents lblVouDesc As System.Windows.Forms.Label
	Public WithEvents lblVouLastKey As System.Windows.Forms.Label
	Public WithEvents lblVouLen As System.Windows.Forms.Label
	Public WithEvents lblVouPrefix As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVOU001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboVouType = New System.Windows.Forms.ComboBox
		Me.cboVouPrefix = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtVouSpa = New System.Windows.Forms.TextBox
		Me.chkVouYrFlg = New System.Windows.Forms.CheckBox
		Me.chkVouMnFlg = New System.Windows.Forms.CheckBox
		Me.txtVouDesc = New System.Windows.Forms.TextBox
		Me.txtVouLastKey = New System.Windows.Forms.TextBox
		Me.txtVouLen = New System.Windows.Forms.TextBox
		Me.txtVouPrefix = New System.Windows.Forms.TextBox
		Me.lblVouSpa = New System.Windows.Forms.Label
		Me.lblVouType = New System.Windows.Forms.Label
		Me.lblVouDesc = New System.Windows.Forms.Label
		Me.lblVouLastKey = New System.Windows.Forms.Label
		Me.lblVouLen = New System.Windows.Forms.Label
		Me.lblVouPrefix = New System.Windows.Forms.Label
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
		Me.Text = "憑單"
		Me.ClientSize = New System.Drawing.Size(572, 296)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmVOU001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmVOU001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 12
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboVouType.Size = New System.Drawing.Size(182, 20)
		Me.cboVouType.Location = New System.Drawing.Point(120, 236)
		Me.cboVouType.TabIndex = 7
		Me.cboVouType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVouType.BackColor = System.Drawing.SystemColors.Window
		Me.cboVouType.CausesValidation = True
		Me.cboVouType.Enabled = True
		Me.cboVouType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVouType.IntegralHeight = True
		Me.cboVouType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVouType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVouType.Sorted = False
		Me.cboVouType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVouType.TabStop = True
		Me.cboVouType.Visible = True
		Me.cboVouType.Name = "cboVouType"
		Me.cboVouPrefix.Size = New System.Drawing.Size(182, 20)
		Me.cboVouPrefix.Location = New System.Drawing.Point(120, 64)
		Me.cboVouPrefix.TabIndex = 0
		Me.cboVouPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVouPrefix.BackColor = System.Drawing.SystemColors.Window
		Me.cboVouPrefix.CausesValidation = True
		Me.cboVouPrefix.Enabled = True
		Me.cboVouPrefix.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVouPrefix.IntegralHeight = True
		Me.cboVouPrefix.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVouPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVouPrefix.Sorted = False
		Me.cboVouPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVouPrefix.TabStop = True
		Me.cboVouPrefix.Visible = True
		Me.cboVouPrefix.Name = "cboVouPrefix"
		Me.fraDetailInfo.Text = "憑單"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 265)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 9
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtVouSpa.AutoSize = False
		Me.txtVouSpa.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtVouSpa.Enabled = False
		Me.txtVouSpa.Size = New System.Drawing.Size(38, 20)
		Me.txtVouSpa.Location = New System.Drawing.Point(112, 184)
		Me.txtVouSpa.TabIndex = 6
		Me.txtVouSpa.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVouSpa.AcceptsReturn = True
		Me.txtVouSpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVouSpa.CausesValidation = True
		Me.txtVouSpa.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVouSpa.HideSelection = True
		Me.txtVouSpa.ReadOnly = False
		Me.txtVouSpa.Maxlength = 0
		Me.txtVouSpa.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVouSpa.MultiLine = False
		Me.txtVouSpa.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVouSpa.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVouSpa.TabStop = True
		Me.txtVouSpa.Visible = True
		Me.txtVouSpa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVouSpa.Name = "txtVouSpa"
		Me.chkVouYrFlg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkVouYrFlg.Text = "VOUYRFLG"
		Me.chkVouYrFlg.Size = New System.Drawing.Size(102, 12)
		Me.chkVouYrFlg.Location = New System.Drawing.Point(23, 144)
		Me.chkVouYrFlg.TabIndex = 4
		Me.chkVouYrFlg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkVouYrFlg.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkVouYrFlg.BackColor = System.Drawing.SystemColors.Control
		Me.chkVouYrFlg.CausesValidation = True
		Me.chkVouYrFlg.Enabled = True
		Me.chkVouYrFlg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkVouYrFlg.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkVouYrFlg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkVouYrFlg.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkVouYrFlg.TabStop = True
		Me.chkVouYrFlg.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkVouYrFlg.Visible = True
		Me.chkVouYrFlg.Name = "chkVouYrFlg"
		Me.chkVouMnFlg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkVouMnFlg.Text = "VOUMNFLG"
		Me.chkVouMnFlg.Size = New System.Drawing.Size(102, 12)
		Me.chkVouMnFlg.Location = New System.Drawing.Point(23, 168)
		Me.chkVouMnFlg.TabIndex = 5
		Me.chkVouMnFlg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkVouMnFlg.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkVouMnFlg.BackColor = System.Drawing.SystemColors.Control
		Me.chkVouMnFlg.CausesValidation = True
		Me.chkVouMnFlg.Enabled = True
		Me.chkVouMnFlg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkVouMnFlg.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkVouMnFlg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkVouMnFlg.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkVouMnFlg.TabStop = True
		Me.chkVouMnFlg.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkVouMnFlg.Visible = True
		Me.chkVouMnFlg.Name = "chkVouMnFlg"
		Me.txtVouDesc.AutoSize = False
		Me.txtVouDesc.Enabled = False
		Me.txtVouDesc.Size = New System.Drawing.Size(430, 20)
		Me.txtVouDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtVouDesc.TabIndex = 1
		Me.txtVouDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVouDesc.AcceptsReturn = True
		Me.txtVouDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVouDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtVouDesc.CausesValidation = True
		Me.txtVouDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVouDesc.HideSelection = True
		Me.txtVouDesc.ReadOnly = False
		Me.txtVouDesc.Maxlength = 0
		Me.txtVouDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVouDesc.MultiLine = False
		Me.txtVouDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVouDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVouDesc.TabStop = True
		Me.txtVouDesc.Visible = True
		Me.txtVouDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVouDesc.Name = "txtVouDesc"
		Me.txtVouLastKey.AutoSize = False
		Me.txtVouLastKey.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtVouLastKey.Enabled = False
		Me.txtVouLastKey.Size = New System.Drawing.Size(54, 20)
		Me.txtVouLastKey.Location = New System.Drawing.Point(112, 112)
		Me.txtVouLastKey.TabIndex = 3
		Me.txtVouLastKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVouLastKey.AcceptsReturn = True
		Me.txtVouLastKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVouLastKey.CausesValidation = True
		Me.txtVouLastKey.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVouLastKey.HideSelection = True
		Me.txtVouLastKey.ReadOnly = False
		Me.txtVouLastKey.Maxlength = 0
		Me.txtVouLastKey.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVouLastKey.MultiLine = False
		Me.txtVouLastKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVouLastKey.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVouLastKey.TabStop = True
		Me.txtVouLastKey.Visible = True
		Me.txtVouLastKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVouLastKey.Name = "txtVouLastKey"
		Me.txtVouLen.AutoSize = False
		Me.txtVouLen.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtVouLen.Enabled = False
		Me.txtVouLen.Size = New System.Drawing.Size(54, 20)
		Me.txtVouLen.Location = New System.Drawing.Point(112, 88)
		Me.txtVouLen.TabIndex = 2
		Me.txtVouLen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVouLen.AcceptsReturn = True
		Me.txtVouLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVouLen.CausesValidation = True
		Me.txtVouLen.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVouLen.HideSelection = True
		Me.txtVouLen.ReadOnly = False
		Me.txtVouLen.Maxlength = 0
		Me.txtVouLen.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVouLen.MultiLine = False
		Me.txtVouLen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVouLen.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVouLen.TabStop = True
		Me.txtVouLen.Visible = True
		Me.txtVouLen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVouLen.Name = "txtVouLen"
		Me.txtVouPrefix.AutoSize = False
		Me.txtVouPrefix.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtVouPrefix.Enabled = False
		Me.txtVouPrefix.Size = New System.Drawing.Size(182, 20)
		Me.txtVouPrefix.Location = New System.Drawing.Point(112, 40)
		Me.txtVouPrefix.TabIndex = 8
		Me.txtVouPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVouPrefix.AcceptsReturn = True
		Me.txtVouPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVouPrefix.CausesValidation = True
		Me.txtVouPrefix.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVouPrefix.HideSelection = True
		Me.txtVouPrefix.ReadOnly = False
		Me.txtVouPrefix.Maxlength = 0
		Me.txtVouPrefix.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVouPrefix.MultiLine = False
		Me.txtVouPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVouPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVouPrefix.TabStop = True
		Me.txtVouPrefix.Visible = True
		Me.txtVouPrefix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVouPrefix.Name = "txtVouPrefix"
		Me.lblVouSpa.Text = "VOUSPA"
		Me.lblVouSpa.Size = New System.Drawing.Size(92, 16)
		Me.lblVouSpa.Location = New System.Drawing.Point(24, 190)
		Me.lblVouSpa.TabIndex = 17
		Me.lblVouSpa.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVouSpa.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVouSpa.BackColor = System.Drawing.SystemColors.Control
		Me.lblVouSpa.Enabled = True
		Me.lblVouSpa.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVouSpa.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVouSpa.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVouSpa.UseMnemonic = True
		Me.lblVouSpa.Visible = True
		Me.lblVouSpa.AutoSize = False
		Me.lblVouSpa.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVouSpa.Name = "lblVouSpa"
		Me.lblVouType.Text = "VOUTYPE"
		Me.lblVouType.Size = New System.Drawing.Size(92, 16)
		Me.lblVouType.Location = New System.Drawing.Point(26, 216)
		Me.lblVouType.TabIndex = 16
		Me.lblVouType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVouType.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVouType.BackColor = System.Drawing.SystemColors.Control
		Me.lblVouType.Enabled = True
		Me.lblVouType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVouType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVouType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVouType.UseMnemonic = True
		Me.lblVouType.Visible = True
		Me.lblVouType.AutoSize = False
		Me.lblVouType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVouType.Name = "lblVouType"
		Me.lblVouDesc.Text = "DOCTYPEDESC"
		Me.lblVouDesc.Size = New System.Drawing.Size(81, 17)
		Me.lblVouDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblVouDesc.TabIndex = 15
		Me.lblVouDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVouDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVouDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblVouDesc.Enabled = True
		Me.lblVouDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVouDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVouDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVouDesc.UseMnemonic = True
		Me.lblVouDesc.Visible = True
		Me.lblVouDesc.AutoSize = False
		Me.lblVouDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVouDesc.Name = "lblVouDesc"
		Me.lblVouLastKey.Text = "VOULASTKEY"
		Me.lblVouLastKey.Size = New System.Drawing.Size(92, 16)
		Me.lblVouLastKey.Location = New System.Drawing.Point(24, 116)
		Me.lblVouLastKey.TabIndex = 14
		Me.lblVouLastKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVouLastKey.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVouLastKey.BackColor = System.Drawing.SystemColors.Control
		Me.lblVouLastKey.Enabled = True
		Me.lblVouLastKey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVouLastKey.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVouLastKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVouLastKey.UseMnemonic = True
		Me.lblVouLastKey.Visible = True
		Me.lblVouLastKey.AutoSize = False
		Me.lblVouLastKey.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVouLastKey.Name = "lblVouLastKey"
		Me.lblVouLen.Text = "VOULEN"
		Me.lblVouLen.Size = New System.Drawing.Size(92, 16)
		Me.lblVouLen.Location = New System.Drawing.Point(24, 92)
		Me.lblVouLen.TabIndex = 13
		Me.lblVouLen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVouLen.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVouLen.BackColor = System.Drawing.SystemColors.Control
		Me.lblVouLen.Enabled = True
		Me.lblVouLen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVouLen.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVouLen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVouLen.UseMnemonic = True
		Me.lblVouLen.Visible = True
		Me.lblVouLen.AutoSize = False
		Me.lblVouLen.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVouLen.Name = "lblVouLen"
		Me.lblVouPrefix.Text = "VOUPREFIX"
		Me.lblVouPrefix.Size = New System.Drawing.Size(92, 16)
		Me.lblVouPrefix.Location = New System.Drawing.Point(24, 44)
		Me.lblVouPrefix.TabIndex = 11
		Me.lblVouPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVouPrefix.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVouPrefix.BackColor = System.Drawing.SystemColors.Control
		Me.lblVouPrefix.Enabled = True
		Me.lblVouPrefix.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVouPrefix.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVouPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVouPrefix.UseMnemonic = True
		Me.lblVouPrefix.Visible = True
		Me.lblVouPrefix.AutoSize = False
		Me.lblVouPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVouPrefix.Name = "lblVouPrefix"
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
		Me.Controls.Add(cboVouType)
		Me.Controls.Add(cboVouPrefix)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtVouSpa)
		Me.fraDetailInfo.Controls.Add(chkVouYrFlg)
		Me.fraDetailInfo.Controls.Add(chkVouMnFlg)
		Me.fraDetailInfo.Controls.Add(txtVouDesc)
		Me.fraDetailInfo.Controls.Add(txtVouLastKey)
		Me.fraDetailInfo.Controls.Add(txtVouLen)
		Me.fraDetailInfo.Controls.Add(txtVouPrefix)
		Me.fraDetailInfo.Controls.Add(lblVouSpa)
		Me.fraDetailInfo.Controls.Add(lblVouType)
		Me.fraDetailInfo.Controls.Add(lblVouDesc)
		Me.fraDetailInfo.Controls.Add(lblVouLastKey)
		Me.fraDetailInfo.Controls.Add(lblVouLen)
		Me.fraDetailInfo.Controls.Add(lblVouPrefix)
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