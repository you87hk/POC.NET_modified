<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPT001
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
	Public WithEvents cboPackTypeCode As System.Windows.Forms.ComboBox
	Public WithEvents txtPackTypeCode As System.Windows.Forms.TextBox
	Public WithEvents txtPackTypeDesc As System.Windows.Forms.TextBox
	Public WithEvents lblPackTypeLastUpd As System.Windows.Forms.Label
	Public WithEvents lblPackTypeLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspPackTypeLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspPackTypeLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblPackTypeCode As System.Windows.Forms.Label
	Public WithEvents lblPackTypeDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPT001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboPackTypeCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtPackTypeCode = New System.Windows.Forms.TextBox
		Me.txtPackTypeDesc = New System.Windows.Forms.TextBox
		Me.lblPackTypeLastUpd = New System.Windows.Forms.Label
		Me.lblPackTypeLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspPackTypeLastUpd = New System.Windows.Forms.Label
		Me.lblDspPackTypeLastUpdDate = New System.Windows.Forms.Label
		Me.lblPackTypeCode = New System.Windows.Forms.Label
		Me.lblPackTypeDesc = New System.Windows.Forms.Label
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
		Me.Text = "包裝資料"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmPT001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPT001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboPackTypeCode.Size = New System.Drawing.Size(134, 20)
		Me.cboPackTypeCode.Location = New System.Drawing.Point(168, 64)
		Me.cboPackTypeCode.TabIndex = 11
		Me.cboPackTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPackTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboPackTypeCode.CausesValidation = True
		Me.cboPackTypeCode.Enabled = True
		Me.cboPackTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPackTypeCode.IntegralHeight = True
		Me.cboPackTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPackTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPackTypeCode.Sorted = False
		Me.cboPackTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPackTypeCode.TabStop = True
		Me.cboPackTypeCode.Visible = True
		Me.cboPackTypeCode.Name = "cboPackTypeCode"
		Me.fraDetailInfo.Text = "包裝資料"
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
		Me.txtPackTypeCode.AutoSize = False
		Me.txtPackTypeCode.Size = New System.Drawing.Size(134, 20)
		Me.txtPackTypeCode.Location = New System.Drawing.Point(160, 40)
		Me.txtPackTypeCode.TabIndex = 0
		Me.txtPackTypeCode.Tag = "K"
		Me.txtPackTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPackTypeCode.AcceptsReturn = True
		Me.txtPackTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPackTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtPackTypeCode.CausesValidation = True
		Me.txtPackTypeCode.Enabled = True
		Me.txtPackTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPackTypeCode.HideSelection = True
		Me.txtPackTypeCode.ReadOnly = False
		Me.txtPackTypeCode.Maxlength = 0
		Me.txtPackTypeCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPackTypeCode.MultiLine = False
		Me.txtPackTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPackTypeCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPackTypeCode.TabStop = True
		Me.txtPackTypeCode.Visible = True
		Me.txtPackTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPackTypeCode.Name = "txtPackTypeCode"
		Me.txtPackTypeDesc.AutoSize = False
		Me.txtPackTypeDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtPackTypeDesc.Enabled = False
		Me.txtPackTypeDesc.Size = New System.Drawing.Size(385, 20)
		Me.txtPackTypeDesc.Location = New System.Drawing.Point(160, 64)
		Me.txtPackTypeDesc.TabIndex = 1
		Me.txtPackTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPackTypeDesc.AcceptsReturn = True
		Me.txtPackTypeDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPackTypeDesc.CausesValidation = True
		Me.txtPackTypeDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPackTypeDesc.HideSelection = True
		Me.txtPackTypeDesc.ReadOnly = False
		Me.txtPackTypeDesc.Maxlength = 0
		Me.txtPackTypeDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPackTypeDesc.MultiLine = False
		Me.txtPackTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPackTypeDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPackTypeDesc.TabStop = True
		Me.txtPackTypeDesc.Visible = True
		Me.txtPackTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPackTypeDesc.Name = "txtPackTypeDesc"
		Me.lblPackTypeLastUpd.Text = "最後修改人 :"
		Me.lblPackTypeLastUpd.Size = New System.Drawing.Size(148, 16)
		Me.lblPackTypeLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblPackTypeLastUpd.TabIndex = 8
		Me.lblPackTypeLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPackTypeLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPackTypeLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblPackTypeLastUpd.Enabled = True
		Me.lblPackTypeLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPackTypeLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPackTypeLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPackTypeLastUpd.UseMnemonic = True
		Me.lblPackTypeLastUpd.Visible = True
		Me.lblPackTypeLastUpd.AutoSize = False
		Me.lblPackTypeLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPackTypeLastUpd.Name = "lblPackTypeLastUpd"
		Me.lblPackTypeLastUpdDate.Text = "最後修改日期 :"
		Me.lblPackTypeLastUpdDate.Size = New System.Drawing.Size(148, 16)
		Me.lblPackTypeLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblPackTypeLastUpdDate.TabIndex = 7
		Me.lblPackTypeLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPackTypeLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPackTypeLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblPackTypeLastUpdDate.Enabled = True
		Me.lblPackTypeLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPackTypeLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPackTypeLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPackTypeLastUpdDate.UseMnemonic = True
		Me.lblPackTypeLastUpdDate.Visible = True
		Me.lblPackTypeLastUpdDate.AutoSize = False
		Me.lblPackTypeLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPackTypeLastUpdDate.Name = "lblPackTypeLastUpdDate"
		Me.lblDspPackTypeLastUpd.Size = New System.Drawing.Size(103, 20)
		Me.lblDspPackTypeLastUpd.Location = New System.Drawing.Point(176, 160)
		Me.lblDspPackTypeLastUpd.TabIndex = 6
		Me.lblDspPackTypeLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPackTypeLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPackTypeLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPackTypeLastUpd.Enabled = True
		Me.lblDspPackTypeLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPackTypeLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPackTypeLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPackTypeLastUpd.UseMnemonic = True
		Me.lblDspPackTypeLastUpd.Visible = True
		Me.lblDspPackTypeLastUpd.AutoSize = False
		Me.lblDspPackTypeLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPackTypeLastUpd.Name = "lblDspPackTypeLastUpd"
		Me.lblDspPackTypeLastUpdDate.Size = New System.Drawing.Size(103, 20)
		Me.lblDspPackTypeLastUpdDate.Location = New System.Drawing.Point(440, 160)
		Me.lblDspPackTypeLastUpdDate.TabIndex = 5
		Me.lblDspPackTypeLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPackTypeLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPackTypeLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPackTypeLastUpdDate.Enabled = True
		Me.lblDspPackTypeLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPackTypeLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPackTypeLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPackTypeLastUpdDate.UseMnemonic = True
		Me.lblDspPackTypeLastUpdDate.Visible = True
		Me.lblDspPackTypeLastUpdDate.AutoSize = False
		Me.lblDspPackTypeLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPackTypeLastUpdDate.Name = "lblDspPackTypeLastUpdDate"
		Me.lblPackTypeCode.Text = "包裝編碼 :"
		Me.lblPackTypeCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblPackTypeCode.Size = New System.Drawing.Size(132, 16)
		Me.lblPackTypeCode.Location = New System.Drawing.Point(24, 44)
		Me.lblPackTypeCode.TabIndex = 4
		Me.lblPackTypeCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPackTypeCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblPackTypeCode.Enabled = True
		Me.lblPackTypeCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPackTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPackTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPackTypeCode.UseMnemonic = True
		Me.lblPackTypeCode.Visible = True
		Me.lblPackTypeCode.AutoSize = False
		Me.lblPackTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPackTypeCode.Name = "lblPackTypeCode"
		Me.lblPackTypeDesc.Text = "包裝註解 :"
		Me.lblPackTypeDesc.Size = New System.Drawing.Size(132, 16)
		Me.lblPackTypeDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblPackTypeDesc.TabIndex = 3
		Me.lblPackTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPackTypeDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPackTypeDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblPackTypeDesc.Enabled = True
		Me.lblPackTypeDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPackTypeDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPackTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPackTypeDesc.UseMnemonic = True
		Me.lblPackTypeDesc.Visible = True
		Me.lblPackTypeDesc.AutoSize = False
		Me.lblPackTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPackTypeDesc.Name = "lblPackTypeDesc"
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
		Me.Controls.Add(cboPackTypeCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtPackTypeCode)
		Me.fraDetailInfo.Controls.Add(txtPackTypeDesc)
		Me.fraDetailInfo.Controls.Add(lblPackTypeLastUpd)
		Me.fraDetailInfo.Controls.Add(lblPackTypeLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspPackTypeLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspPackTypeLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblPackTypeCode)
		Me.fraDetailInfo.Controls.Add(lblPackTypeDesc)
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