<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmM001
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
	Public WithEvents cboMethodCode As System.Windows.Forms.ComboBox
	Public WithEvents txtMethodCode As System.Windows.Forms.TextBox
	Public WithEvents txtMethodDesc As System.Windows.Forms.TextBox
	Public WithEvents lblMethodLastUpd As System.Windows.Forms.Label
	Public WithEvents lblMethodLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspMethodLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspMethodLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblMethodCode As System.Windows.Forms.Label
	Public WithEvents lblMethodDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmM001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboMethodCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtMethodCode = New System.Windows.Forms.TextBox
		Me.txtMethodDesc = New System.Windows.Forms.TextBox
		Me.lblMethodLastUpd = New System.Windows.Forms.Label
		Me.lblMethodLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspMethodLastUpd = New System.Windows.Forms.Label
		Me.lblDspMethodLastUpdDate = New System.Windows.Forms.Label
		Me.lblMethodCode = New System.Windows.Forms.Label
		Me.lblMethodDesc = New System.Windows.Forms.Label
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
		Me.Text = "銷售渠道"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmM001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmM001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboMethodCode.Size = New System.Drawing.Size(182, 20)
		Me.cboMethodCode.Location = New System.Drawing.Point(120, 64)
		Me.cboMethodCode.TabIndex = 11
		Me.cboMethodCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMethodCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboMethodCode.CausesValidation = True
		Me.cboMethodCode.Enabled = True
		Me.cboMethodCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMethodCode.IntegralHeight = True
		Me.cboMethodCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMethodCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMethodCode.Sorted = False
		Me.cboMethodCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboMethodCode.TabStop = True
		Me.cboMethodCode.Visible = True
		Me.cboMethodCode.Name = "cboMethodCode"
		Me.fraDetailInfo.Text = "銷售渠道"
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
		Me.txtMethodCode.AutoSize = False
		Me.txtMethodCode.Size = New System.Drawing.Size(182, 20)
		Me.txtMethodCode.Location = New System.Drawing.Point(112, 40)
		Me.txtMethodCode.TabIndex = 0
		Me.txtMethodCode.Tag = "K"
		Me.txtMethodCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMethodCode.AcceptsReturn = True
		Me.txtMethodCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMethodCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtMethodCode.CausesValidation = True
		Me.txtMethodCode.Enabled = True
		Me.txtMethodCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMethodCode.HideSelection = True
		Me.txtMethodCode.ReadOnly = False
		Me.txtMethodCode.Maxlength = 0
		Me.txtMethodCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMethodCode.MultiLine = False
		Me.txtMethodCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMethodCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMethodCode.TabStop = True
		Me.txtMethodCode.Visible = True
		Me.txtMethodCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMethodCode.Name = "txtMethodCode"
		Me.txtMethodDesc.AutoSize = False
		Me.txtMethodDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtMethodDesc.Enabled = False
		Me.txtMethodDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtMethodDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtMethodDesc.TabIndex = 1
		Me.txtMethodDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMethodDesc.AcceptsReturn = True
		Me.txtMethodDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMethodDesc.CausesValidation = True
		Me.txtMethodDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMethodDesc.HideSelection = True
		Me.txtMethodDesc.ReadOnly = False
		Me.txtMethodDesc.Maxlength = 0
		Me.txtMethodDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMethodDesc.MultiLine = False
		Me.txtMethodDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMethodDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMethodDesc.TabStop = True
		Me.txtMethodDesc.Visible = True
		Me.txtMethodDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMethodDesc.Name = "txtMethodDesc"
		Me.lblMethodLastUpd.Text = "最後修改人 :"
		Me.lblMethodLastUpd.Size = New System.Drawing.Size(76, 16)
		Me.lblMethodLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblMethodLastUpd.TabIndex = 8
		Me.lblMethodLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMethodLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMethodLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblMethodLastUpd.Enabled = True
		Me.lblMethodLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMethodLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMethodLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMethodLastUpd.UseMnemonic = True
		Me.lblMethodLastUpd.Visible = True
		Me.lblMethodLastUpd.AutoSize = False
		Me.lblMethodLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMethodLastUpd.Name = "lblMethodLastUpd"
		Me.lblMethodLastUpdDate.Text = "最後修改日期 :"
		Me.lblMethodLastUpdDate.Size = New System.Drawing.Size(84, 16)
		Me.lblMethodLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblMethodLastUpdDate.TabIndex = 7
		Me.lblMethodLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMethodLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMethodLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblMethodLastUpdDate.Enabled = True
		Me.lblMethodLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMethodLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMethodLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMethodLastUpdDate.UseMnemonic = True
		Me.lblMethodLastUpdDate.Visible = True
		Me.lblMethodLastUpdDate.AutoSize = False
		Me.lblMethodLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMethodLastUpdDate.Name = "lblMethodLastUpdDate"
		Me.lblDspMethodLastUpd.Size = New System.Drawing.Size(167, 20)
		Me.lblDspMethodLastUpd.Location = New System.Drawing.Point(112, 160)
		Me.lblDspMethodLastUpd.TabIndex = 6
		Me.lblDspMethodLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspMethodLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspMethodLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspMethodLastUpd.Enabled = True
		Me.lblDspMethodLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspMethodLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspMethodLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspMethodLastUpd.UseMnemonic = True
		Me.lblDspMethodLastUpd.Visible = True
		Me.lblDspMethodLastUpd.AutoSize = False
		Me.lblDspMethodLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspMethodLastUpd.Name = "lblDspMethodLastUpd"
		Me.lblDspMethodLastUpdDate.Size = New System.Drawing.Size(167, 20)
		Me.lblDspMethodLastUpdDate.Location = New System.Drawing.Point(376, 160)
		Me.lblDspMethodLastUpdDate.TabIndex = 5
		Me.lblDspMethodLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspMethodLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspMethodLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspMethodLastUpdDate.Enabled = True
		Me.lblDspMethodLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspMethodLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspMethodLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspMethodLastUpdDate.UseMnemonic = True
		Me.lblDspMethodLastUpdDate.Visible = True
		Me.lblDspMethodLastUpdDate.AutoSize = False
		Me.lblDspMethodLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspMethodLastUpdDate.Name = "lblDspMethodLastUpdDate"
		Me.lblMethodCode.Text = "銷售渠道編碼 :"
		Me.lblMethodCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblMethodCode.Size = New System.Drawing.Size(84, 16)
		Me.lblMethodCode.Location = New System.Drawing.Point(24, 44)
		Me.lblMethodCode.TabIndex = 4
		Me.lblMethodCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMethodCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblMethodCode.Enabled = True
		Me.lblMethodCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMethodCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMethodCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMethodCode.UseMnemonic = True
		Me.lblMethodCode.Visible = True
		Me.lblMethodCode.AutoSize = False
		Me.lblMethodCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMethodCode.Name = "lblMethodCode"
		Me.lblMethodDesc.Text = "銷售渠道註解 :"
		Me.lblMethodDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblMethodDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblMethodDesc.TabIndex = 3
		Me.lblMethodDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMethodDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMethodDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblMethodDesc.Enabled = True
		Me.lblMethodDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMethodDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMethodDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMethodDesc.UseMnemonic = True
		Me.lblMethodDesc.Visible = True
		Me.lblMethodDesc.AutoSize = False
		Me.lblMethodDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMethodDesc.Name = "lblMethodDesc"
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
		Me.Controls.Add(cboMethodCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtMethodCode)
		Me.fraDetailInfo.Controls.Add(txtMethodDesc)
		Me.fraDetailInfo.Controls.Add(lblMethodLastUpd)
		Me.fraDetailInfo.Controls.Add(lblMethodLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspMethodLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspMethodLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblMethodCode)
		Me.fraDetailInfo.Controls.Add(lblMethodDesc)
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