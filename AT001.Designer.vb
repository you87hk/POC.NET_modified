<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAT001
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
	Public WithEvents cboAccTypeSALML As System.Windows.Forms.ComboBox
	Public WithEvents cboAccTypeINVML As System.Windows.Forms.ComboBox
	Public WithEvents cboAccTypeCOSML As System.Windows.Forms.ComboBox
	Public WithEvents cboAccTypeCode As System.Windows.Forms.ComboBox
	Public WithEvents txtAccTypeCode As System.Windows.Forms.TextBox
	Public WithEvents txtAccTypeDesc As System.Windows.Forms.TextBox
	Public WithEvents lblAccTypeSALML As System.Windows.Forms.Label
	Public WithEvents lblAccTypeINVML As System.Windows.Forms.Label
	Public WithEvents lblAccTypeCOSML As System.Windows.Forms.Label
	Public WithEvents lblAccTypeLastUpd As System.Windows.Forms.Label
	Public WithEvents lblAccTypeLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspAccTypeLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspAccTypeLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblAccTypeCode As System.Windows.Forms.Label
	Public WithEvents lblAccTypeDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAT001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboAccTypeSALML = New System.Windows.Forms.ComboBox
		Me.cboAccTypeINVML = New System.Windows.Forms.ComboBox
		Me.cboAccTypeCOSML = New System.Windows.Forms.ComboBox
		Me.cboAccTypeCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtAccTypeCode = New System.Windows.Forms.TextBox
		Me.txtAccTypeDesc = New System.Windows.Forms.TextBox
		Me.lblAccTypeSALML = New System.Windows.Forms.Label
		Me.lblAccTypeINVML = New System.Windows.Forms.Label
		Me.lblAccTypeCOSML = New System.Windows.Forms.Label
		Me.lblAccTypeLastUpd = New System.Windows.Forms.Label
		Me.lblAccTypeLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspAccTypeLastUpd = New System.Windows.Forms.Label
		Me.lblDspAccTypeLastUpdDate = New System.Windows.Forms.Label
		Me.lblAccTypeCode = New System.Windows.Forms.Label
		Me.lblAccTypeDesc = New System.Windows.Forms.Label
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
		Me.Text = "會計碼"
		Me.ClientSize = New System.Drawing.Size(572, 261)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmAT001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmAT001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 14
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboAccTypeSALML.Size = New System.Drawing.Size(182, 20)
		Me.cboAccTypeSALML.Location = New System.Drawing.Point(192, 160)
		Me.cboAccTypeSALML.TabIndex = 5
		Me.cboAccTypeSALML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccTypeSALML.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccTypeSALML.CausesValidation = True
		Me.cboAccTypeSALML.Enabled = True
		Me.cboAccTypeSALML.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccTypeSALML.IntegralHeight = True
		Me.cboAccTypeSALML.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccTypeSALML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccTypeSALML.Sorted = False
		Me.cboAccTypeSALML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccTypeSALML.TabStop = True
		Me.cboAccTypeSALML.Visible = True
		Me.cboAccTypeSALML.Name = "cboAccTypeSALML"
		Me.cboAccTypeINVML.Size = New System.Drawing.Size(182, 20)
		Me.cboAccTypeINVML.Location = New System.Drawing.Point(192, 136)
		Me.cboAccTypeINVML.TabIndex = 4
		Me.cboAccTypeINVML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccTypeINVML.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccTypeINVML.CausesValidation = True
		Me.cboAccTypeINVML.Enabled = True
		Me.cboAccTypeINVML.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccTypeINVML.IntegralHeight = True
		Me.cboAccTypeINVML.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccTypeINVML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccTypeINVML.Sorted = False
		Me.cboAccTypeINVML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccTypeINVML.TabStop = True
		Me.cboAccTypeINVML.Visible = True
		Me.cboAccTypeINVML.Name = "cboAccTypeINVML"
		Me.cboAccTypeCOSML.Size = New System.Drawing.Size(182, 20)
		Me.cboAccTypeCOSML.Location = New System.Drawing.Point(192, 112)
		Me.cboAccTypeCOSML.TabIndex = 3
		Me.cboAccTypeCOSML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccTypeCOSML.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccTypeCOSML.CausesValidation = True
		Me.cboAccTypeCOSML.Enabled = True
		Me.cboAccTypeCOSML.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccTypeCOSML.IntegralHeight = True
		Me.cboAccTypeCOSML.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccTypeCOSML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccTypeCOSML.Sorted = False
		Me.cboAccTypeCOSML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccTypeCOSML.TabStop = True
		Me.cboAccTypeCOSML.Visible = True
		Me.cboAccTypeCOSML.Name = "cboAccTypeCOSML"
		Me.cboAccTypeCode.Size = New System.Drawing.Size(182, 20)
		Me.cboAccTypeCode.Location = New System.Drawing.Point(192, 64)
		Me.cboAccTypeCode.TabIndex = 0
		Me.cboAccTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccTypeCode.CausesValidation = True
		Me.cboAccTypeCode.Enabled = True
		Me.cboAccTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccTypeCode.IntegralHeight = True
		Me.cboAccTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccTypeCode.Sorted = False
		Me.cboAccTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccTypeCode.TabStop = True
		Me.cboAccTypeCode.Visible = True
		Me.cboAccTypeCode.Name = "cboAccTypeCode"
		Me.fraDetailInfo.Text = "會計版別"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 233)
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
		Me.txtAccTypeCode.AutoSize = False
		Me.txtAccTypeCode.Enabled = False
		Me.txtAccTypeCode.Size = New System.Drawing.Size(182, 20)
		Me.txtAccTypeCode.Location = New System.Drawing.Point(184, 40)
		Me.txtAccTypeCode.TabIndex = 1
		Me.txtAccTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccTypeCode.AcceptsReturn = True
		Me.txtAccTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtAccTypeCode.CausesValidation = True
		Me.txtAccTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccTypeCode.HideSelection = True
		Me.txtAccTypeCode.ReadOnly = False
		Me.txtAccTypeCode.Maxlength = 0
		Me.txtAccTypeCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccTypeCode.MultiLine = False
		Me.txtAccTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccTypeCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccTypeCode.TabStop = True
		Me.txtAccTypeCode.Visible = True
		Me.txtAccTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccTypeCode.Name = "txtAccTypeCode"
		Me.txtAccTypeDesc.AutoSize = False
		Me.txtAccTypeDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtAccTypeDesc.Enabled = False
		Me.txtAccTypeDesc.Size = New System.Drawing.Size(361, 20)
		Me.txtAccTypeDesc.Location = New System.Drawing.Point(184, 64)
		Me.txtAccTypeDesc.TabIndex = 2
		Me.txtAccTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccTypeDesc.AcceptsReturn = True
		Me.txtAccTypeDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccTypeDesc.CausesValidation = True
		Me.txtAccTypeDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccTypeDesc.HideSelection = True
		Me.txtAccTypeDesc.ReadOnly = False
		Me.txtAccTypeDesc.Maxlength = 0
		Me.txtAccTypeDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccTypeDesc.MultiLine = False
		Me.txtAccTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccTypeDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccTypeDesc.TabStop = True
		Me.txtAccTypeDesc.Visible = True
		Me.txtAccTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccTypeDesc.Name = "txtAccTypeDesc"
		Me.lblAccTypeSALML.Text = "ACCTYPEINVML"
		Me.lblAccTypeSALML.Size = New System.Drawing.Size(148, 16)
		Me.lblAccTypeSALML.Location = New System.Drawing.Point(24, 142)
		Me.lblAccTypeSALML.TabIndex = 17
		Me.lblAccTypeSALML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeSALML.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeSALML.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeSALML.Enabled = True
		Me.lblAccTypeSALML.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeSALML.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeSALML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeSALML.UseMnemonic = True
		Me.lblAccTypeSALML.Visible = True
		Me.lblAccTypeSALML.AutoSize = False
		Me.lblAccTypeSALML.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeSALML.Name = "lblAccTypeSALML"
		Me.lblAccTypeINVML.Text = "ACCTYPEINVML"
		Me.lblAccTypeINVML.Size = New System.Drawing.Size(148, 16)
		Me.lblAccTypeINVML.Location = New System.Drawing.Point(24, 117)
		Me.lblAccTypeINVML.TabIndex = 16
		Me.lblAccTypeINVML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeINVML.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeINVML.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeINVML.Enabled = True
		Me.lblAccTypeINVML.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeINVML.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeINVML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeINVML.UseMnemonic = True
		Me.lblAccTypeINVML.Visible = True
		Me.lblAccTypeINVML.AutoSize = False
		Me.lblAccTypeINVML.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeINVML.Name = "lblAccTypeINVML"
		Me.lblAccTypeCOSML.Text = "ACCTYPECOSML"
		Me.lblAccTypeCOSML.Size = New System.Drawing.Size(148, 16)
		Me.lblAccTypeCOSML.Location = New System.Drawing.Point(24, 93)
		Me.lblAccTypeCOSML.TabIndex = 15
		Me.lblAccTypeCOSML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeCOSML.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeCOSML.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeCOSML.Enabled = True
		Me.lblAccTypeCOSML.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeCOSML.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeCOSML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeCOSML.UseMnemonic = True
		Me.lblAccTypeCOSML.Visible = True
		Me.lblAccTypeCOSML.AutoSize = False
		Me.lblAccTypeCOSML.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeCOSML.Name = "lblAccTypeCOSML"
		Me.lblAccTypeLastUpd.Text = "最後修改人 :"
		Me.lblAccTypeLastUpd.Size = New System.Drawing.Size(148, 16)
		Me.lblAccTypeLastUpd.Location = New System.Drawing.Point(24, 195)
		Me.lblAccTypeLastUpd.TabIndex = 13
		Me.lblAccTypeLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeLastUpd.Enabled = True
		Me.lblAccTypeLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeLastUpd.UseMnemonic = True
		Me.lblAccTypeLastUpd.Visible = True
		Me.lblAccTypeLastUpd.AutoSize = False
		Me.lblAccTypeLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeLastUpd.Name = "lblAccTypeLastUpd"
		Me.lblAccTypeLastUpdDate.Text = "最後修改日期 :"
		Me.lblAccTypeLastUpdDate.Size = New System.Drawing.Size(140, 16)
		Me.lblAccTypeLastUpdDate.Location = New System.Drawing.Point(288, 195)
		Me.lblAccTypeLastUpdDate.TabIndex = 12
		Me.lblAccTypeLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeLastUpdDate.Enabled = True
		Me.lblAccTypeLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeLastUpdDate.UseMnemonic = True
		Me.lblAccTypeLastUpdDate.Visible = True
		Me.lblAccTypeLastUpdDate.AutoSize = False
		Me.lblAccTypeLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeLastUpdDate.Name = "lblAccTypeLastUpdDate"
		Me.lblDspAccTypeLastUpd.Size = New System.Drawing.Size(95, 20)
		Me.lblDspAccTypeLastUpd.Location = New System.Drawing.Point(184, 192)
		Me.lblDspAccTypeLastUpd.TabIndex = 11
		Me.lblDspAccTypeLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAccTypeLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAccTypeLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAccTypeLastUpd.Enabled = True
		Me.lblDspAccTypeLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAccTypeLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAccTypeLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAccTypeLastUpd.UseMnemonic = True
		Me.lblDspAccTypeLastUpd.Visible = True
		Me.lblDspAccTypeLastUpd.AutoSize = False
		Me.lblDspAccTypeLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAccTypeLastUpd.Name = "lblDspAccTypeLastUpd"
		Me.lblDspAccTypeLastUpdDate.Size = New System.Drawing.Size(103, 20)
		Me.lblDspAccTypeLastUpdDate.Location = New System.Drawing.Point(440, 192)
		Me.lblDspAccTypeLastUpdDate.TabIndex = 10
		Me.lblDspAccTypeLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAccTypeLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAccTypeLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAccTypeLastUpdDate.Enabled = True
		Me.lblDspAccTypeLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAccTypeLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAccTypeLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAccTypeLastUpdDate.UseMnemonic = True
		Me.lblDspAccTypeLastUpdDate.Visible = True
		Me.lblDspAccTypeLastUpdDate.AutoSize = False
		Me.lblDspAccTypeLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAccTypeLastUpdDate.Name = "lblDspAccTypeLastUpdDate"
		Me.lblAccTypeCode.Text = "會計編碼 :"
		Me.lblAccTypeCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblAccTypeCode.Size = New System.Drawing.Size(148, 16)
		Me.lblAccTypeCode.Location = New System.Drawing.Point(24, 44)
		Me.lblAccTypeCode.TabIndex = 9
		Me.lblAccTypeCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeCode.Enabled = True
		Me.lblAccTypeCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeCode.UseMnemonic = True
		Me.lblAccTypeCode.Visible = True
		Me.lblAccTypeCode.AutoSize = False
		Me.lblAccTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeCode.Name = "lblAccTypeCode"
		Me.lblAccTypeDesc.Text = "會計註解 :"
		Me.lblAccTypeDesc.Size = New System.Drawing.Size(148, 16)
		Me.lblAccTypeDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblAccTypeDesc.TabIndex = 8
		Me.lblAccTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccTypeDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccTypeDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccTypeDesc.Enabled = True
		Me.lblAccTypeDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccTypeDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccTypeDesc.UseMnemonic = True
		Me.lblAccTypeDesc.Visible = True
		Me.lblAccTypeDesc.AutoSize = False
		Me.lblAccTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccTypeDesc.Name = "lblAccTypeDesc"
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
		Me.Controls.Add(cboAccTypeSALML)
		Me.Controls.Add(cboAccTypeINVML)
		Me.Controls.Add(cboAccTypeCOSML)
		Me.Controls.Add(cboAccTypeCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtAccTypeCode)
		Me.fraDetailInfo.Controls.Add(txtAccTypeDesc)
		Me.fraDetailInfo.Controls.Add(lblAccTypeSALML)
		Me.fraDetailInfo.Controls.Add(lblAccTypeINVML)
		Me.fraDetailInfo.Controls.Add(lblAccTypeCOSML)
		Me.fraDetailInfo.Controls.Add(lblAccTypeLastUpd)
		Me.fraDetailInfo.Controls.Add(lblAccTypeLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspAccTypeLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspAccTypeLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblAccTypeCode)
		Me.fraDetailInfo.Controls.Add(lblAccTypeDesc)
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