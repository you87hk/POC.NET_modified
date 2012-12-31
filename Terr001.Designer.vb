<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTerr001
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
	Public WithEvents cboTerrCode As System.Windows.Forms.ComboBox
	Public WithEvents txtTerrCode As System.Windows.Forms.TextBox
	Public WithEvents txtTerrDesc As System.Windows.Forms.TextBox
	Public WithEvents lblTerrLastUpd As System.Windows.Forms.Label
	Public WithEvents lblTerrLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspTerrLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspTerrLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblTerrCode As System.Windows.Forms.Label
	Public WithEvents lblTerrDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTerr001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboTerrCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtTerrCode = New System.Windows.Forms.TextBox
		Me.txtTerrDesc = New System.Windows.Forms.TextBox
		Me.lblTerrLastUpd = New System.Windows.Forms.Label
		Me.lblTerrLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspTerrLastUpd = New System.Windows.Forms.Label
		Me.lblDspTerrLastUpdDate = New System.Windows.Forms.Label
		Me.lblTerrCode = New System.Windows.Forms.Label
		Me.lblTerrDesc = New System.Windows.Forms.Label
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
		Me.Text = "地區編碼"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmTerr001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmTerr001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboTerrCode.Size = New System.Drawing.Size(150, 20)
		Me.cboTerrCode.Location = New System.Drawing.Point(152, 64)
		Me.cboTerrCode.TabIndex = 11
		Me.cboTerrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTerrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboTerrCode.CausesValidation = True
		Me.cboTerrCode.Enabled = True
		Me.cboTerrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTerrCode.IntegralHeight = True
		Me.cboTerrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTerrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTerrCode.Sorted = False
		Me.cboTerrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboTerrCode.TabStop = True
		Me.cboTerrCode.Visible = True
		Me.cboTerrCode.Name = "cboTerrCode"
		Me.fraDetailInfo.Text = "地區"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 201)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 2
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtTerrCode.AutoSize = False
		Me.txtTerrCode.Size = New System.Drawing.Size(150, 20)
		Me.txtTerrCode.Location = New System.Drawing.Point(144, 40)
		Me.txtTerrCode.TabIndex = 0
		Me.txtTerrCode.Tag = "K"
		Me.txtTerrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTerrCode.AcceptsReturn = True
		Me.txtTerrCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTerrCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtTerrCode.CausesValidation = True
		Me.txtTerrCode.Enabled = True
		Me.txtTerrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTerrCode.HideSelection = True
		Me.txtTerrCode.ReadOnly = False
		Me.txtTerrCode.Maxlength = 0
		Me.txtTerrCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTerrCode.MultiLine = False
		Me.txtTerrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTerrCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTerrCode.TabStop = True
		Me.txtTerrCode.Visible = True
		Me.txtTerrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTerrCode.Name = "txtTerrCode"
		Me.txtTerrDesc.AutoSize = False
		Me.txtTerrDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtTerrDesc.Enabled = False
		Me.txtTerrDesc.Size = New System.Drawing.Size(401, 20)
		Me.txtTerrDesc.Location = New System.Drawing.Point(144, 64)
		Me.txtTerrDesc.TabIndex = 1
		Me.txtTerrDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTerrDesc.AcceptsReturn = True
		Me.txtTerrDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTerrDesc.CausesValidation = True
		Me.txtTerrDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTerrDesc.HideSelection = True
		Me.txtTerrDesc.ReadOnly = False
		Me.txtTerrDesc.Maxlength = 0
		Me.txtTerrDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTerrDesc.MultiLine = False
		Me.txtTerrDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTerrDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTerrDesc.TabStop = True
		Me.txtTerrDesc.Visible = True
		Me.txtTerrDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTerrDesc.Name = "txtTerrDesc"
		Me.lblTerrLastUpd.Text = "最後修改人 :"
		Me.lblTerrLastUpd.Size = New System.Drawing.Size(132, 16)
		Me.lblTerrLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblTerrLastUpd.TabIndex = 8
		Me.lblTerrLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTerrLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTerrLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblTerrLastUpd.Enabled = True
		Me.lblTerrLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTerrLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTerrLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTerrLastUpd.UseMnemonic = True
		Me.lblTerrLastUpd.Visible = True
		Me.lblTerrLastUpd.AutoSize = False
		Me.lblTerrLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTerrLastUpd.Name = "lblTerrLastUpd"
		Me.lblTerrLastUpdDate.Text = "最後修改日期 :"
		Me.lblTerrLastUpdDate.Size = New System.Drawing.Size(124, 16)
		Me.lblTerrLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblTerrLastUpdDate.TabIndex = 7
		Me.lblTerrLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTerrLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTerrLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblTerrLastUpdDate.Enabled = True
		Me.lblTerrLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTerrLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTerrLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTerrLastUpdDate.UseMnemonic = True
		Me.lblTerrLastUpdDate.Visible = True
		Me.lblTerrLastUpdDate.AutoSize = False
		Me.lblTerrLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTerrLastUpdDate.Name = "lblTerrLastUpdDate"
		Me.lblDspTerrLastUpd.Size = New System.Drawing.Size(111, 20)
		Me.lblDspTerrLastUpd.Location = New System.Drawing.Point(168, 160)
		Me.lblDspTerrLastUpd.TabIndex = 6
		Me.lblDspTerrLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspTerrLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspTerrLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspTerrLastUpd.Enabled = True
		Me.lblDspTerrLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspTerrLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspTerrLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspTerrLastUpd.UseMnemonic = True
		Me.lblDspTerrLastUpd.Visible = True
		Me.lblDspTerrLastUpd.AutoSize = False
		Me.lblDspTerrLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspTerrLastUpd.Name = "lblDspTerrLastUpd"
		Me.lblDspTerrLastUpdDate.Size = New System.Drawing.Size(119, 20)
		Me.lblDspTerrLastUpdDate.Location = New System.Drawing.Point(424, 160)
		Me.lblDspTerrLastUpdDate.TabIndex = 5
		Me.lblDspTerrLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspTerrLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspTerrLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspTerrLastUpdDate.Enabled = True
		Me.lblDspTerrLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspTerrLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspTerrLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspTerrLastUpdDate.UseMnemonic = True
		Me.lblDspTerrLastUpdDate.Visible = True
		Me.lblDspTerrLastUpdDate.AutoSize = False
		Me.lblDspTerrLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspTerrLastUpdDate.Name = "lblDspTerrLastUpdDate"
		Me.lblTerrCode.Text = "地區編碼 :"
		Me.lblTerrCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblTerrCode.Size = New System.Drawing.Size(116, 16)
		Me.lblTerrCode.Location = New System.Drawing.Point(24, 44)
		Me.lblTerrCode.TabIndex = 4
		Me.lblTerrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTerrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblTerrCode.Enabled = True
		Me.lblTerrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTerrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTerrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTerrCode.UseMnemonic = True
		Me.lblTerrCode.Visible = True
		Me.lblTerrCode.AutoSize = False
		Me.lblTerrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTerrCode.Name = "lblTerrCode"
		Me.lblTerrDesc.Text = "地區註解 :"
		Me.lblTerrDesc.Size = New System.Drawing.Size(116, 16)
		Me.lblTerrDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblTerrDesc.TabIndex = 3
		Me.lblTerrDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTerrDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTerrDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblTerrDesc.Enabled = True
		Me.lblTerrDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTerrDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTerrDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTerrDesc.UseMnemonic = True
		Me.lblTerrDesc.Visible = True
		Me.lblTerrDesc.AutoSize = False
		Me.lblTerrDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTerrDesc.Name = "lblTerrDesc"
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
		Me.Controls.Add(cboTerrCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtTerrCode)
		Me.fraDetailInfo.Controls.Add(txtTerrDesc)
		Me.fraDetailInfo.Controls.Add(lblTerrLastUpd)
		Me.fraDetailInfo.Controls.Add(lblTerrLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspTerrLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspTerrLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblTerrCode)
		Me.fraDetailInfo.Controls.Add(lblTerrDesc)
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