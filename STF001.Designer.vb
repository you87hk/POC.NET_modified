<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSTF001
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
	Public WithEvents cboStaffCode As System.Windows.Forms.ComboBox
	Public WithEvents txtStaffCode As System.Windows.Forms.TextBox
	Public WithEvents txtStaffName As System.Windows.Forms.TextBox
	Public WithEvents lblDspStaffLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspStaffLastUpd As System.Windows.Forms.Label
	Public WithEvents lblStaffLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblStaffLastUpd As System.Windows.Forms.Label
	Public WithEvents lblStaffCode As System.Windows.Forms.Label
	Public WithEvents lblStaffName As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSTF001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboStaffCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtStaffCode = New System.Windows.Forms.TextBox
		Me.txtStaffName = New System.Windows.Forms.TextBox
		Me.lblDspStaffLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspStaffLastUpd = New System.Windows.Forms.Label
		Me.lblStaffLastUpdDate = New System.Windows.Forms.Label
		Me.lblStaffLastUpd = New System.Windows.Forms.Label
		Me.lblStaffCode = New System.Windows.Forms.Label
		Me.lblStaffName = New System.Windows.Forms.Label
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
		Me.Text = "STAFF"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmSTF001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSTF001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 11
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboStaffCode.Size = New System.Drawing.Size(182, 20)
		Me.cboStaffCode.Location = New System.Drawing.Point(120, 64)
		Me.cboStaffCode.TabIndex = 0
		Me.cboStaffCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStaffCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboStaffCode.CausesValidation = True
		Me.cboStaffCode.Enabled = True
		Me.cboStaffCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboStaffCode.IntegralHeight = True
		Me.cboStaffCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboStaffCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboStaffCode.Sorted = False
		Me.cboStaffCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboStaffCode.TabStop = True
		Me.cboStaffCode.Visible = True
		Me.cboStaffCode.Name = "cboStaffCode"
		Me.fraDetailInfo.Text = "STAFFINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 201)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 3
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtStaffCode.AutoSize = False
		Me.txtStaffCode.Size = New System.Drawing.Size(182, 20)
		Me.txtStaffCode.Location = New System.Drawing.Point(112, 40)
		Me.txtStaffCode.TabIndex = 1
		Me.txtStaffCode.Tag = "K"
		Me.txtStaffCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStaffCode.AcceptsReturn = True
		Me.txtStaffCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStaffCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtStaffCode.CausesValidation = True
		Me.txtStaffCode.Enabled = True
		Me.txtStaffCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStaffCode.HideSelection = True
		Me.txtStaffCode.ReadOnly = False
		Me.txtStaffCode.Maxlength = 0
		Me.txtStaffCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStaffCode.MultiLine = False
		Me.txtStaffCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStaffCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStaffCode.TabStop = True
		Me.txtStaffCode.Visible = True
		Me.txtStaffCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStaffCode.Name = "txtStaffCode"
		Me.txtStaffName.AutoSize = False
		Me.txtStaffName.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtStaffName.Enabled = False
		Me.txtStaffName.Size = New System.Drawing.Size(433, 20)
		Me.txtStaffName.Location = New System.Drawing.Point(112, 64)
		Me.txtStaffName.TabIndex = 2
		Me.txtStaffName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStaffName.AcceptsReturn = True
		Me.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStaffName.CausesValidation = True
		Me.txtStaffName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStaffName.HideSelection = True
		Me.txtStaffName.ReadOnly = False
		Me.txtStaffName.Maxlength = 0
		Me.txtStaffName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStaffName.MultiLine = False
		Me.txtStaffName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStaffName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStaffName.TabStop = True
		Me.txtStaffName.Visible = True
		Me.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStaffName.Name = "txtStaffName"
		Me.lblDspStaffLastUpdDate.Size = New System.Drawing.Size(167, 20)
		Me.lblDspStaffLastUpdDate.Location = New System.Drawing.Point(376, 160)
		Me.lblDspStaffLastUpdDate.TabIndex = 10
		Me.lblDspStaffLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStaffLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStaffLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStaffLastUpdDate.Enabled = True
		Me.lblDspStaffLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStaffLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStaffLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStaffLastUpdDate.UseMnemonic = True
		Me.lblDspStaffLastUpdDate.Visible = True
		Me.lblDspStaffLastUpdDate.AutoSize = False
		Me.lblDspStaffLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStaffLastUpdDate.Name = "lblDspStaffLastUpdDate"
		Me.lblDspStaffLastUpd.Size = New System.Drawing.Size(167, 20)
		Me.lblDspStaffLastUpd.Location = New System.Drawing.Point(112, 160)
		Me.lblDspStaffLastUpd.TabIndex = 9
		Me.lblDspStaffLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStaffLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStaffLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStaffLastUpd.Enabled = True
		Me.lblDspStaffLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStaffLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStaffLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStaffLastUpd.UseMnemonic = True
		Me.lblDspStaffLastUpd.Visible = True
		Me.lblDspStaffLastUpd.AutoSize = False
		Me.lblDspStaffLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStaffLastUpd.Name = "lblDspStaffLastUpd"
		Me.lblStaffLastUpdDate.Text = "最後修改日期 :"
		Me.lblStaffLastUpdDate.Size = New System.Drawing.Size(84, 16)
		Me.lblStaffLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblStaffLastUpdDate.TabIndex = 8
		Me.lblStaffLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffLastUpdDate.Enabled = True
		Me.lblStaffLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffLastUpdDate.UseMnemonic = True
		Me.lblStaffLastUpdDate.Visible = True
		Me.lblStaffLastUpdDate.AutoSize = False
		Me.lblStaffLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffLastUpdDate.Name = "lblStaffLastUpdDate"
		Me.lblStaffLastUpd.Text = "最後修改人 :"
		Me.lblStaffLastUpd.Size = New System.Drawing.Size(76, 16)
		Me.lblStaffLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblStaffLastUpd.TabIndex = 7
		Me.lblStaffLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffLastUpd.Enabled = True
		Me.lblStaffLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffLastUpd.UseMnemonic = True
		Me.lblStaffLastUpd.Visible = True
		Me.lblStaffLastUpd.AutoSize = False
		Me.lblStaffLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffLastUpd.Name = "lblStaffLastUpd"
		Me.lblStaffCode.Text = "STAFFCODE"
		Me.lblStaffCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblStaffCode.Size = New System.Drawing.Size(84, 16)
		Me.lblStaffCode.Location = New System.Drawing.Point(24, 44)
		Me.lblStaffCode.TabIndex = 5
		Me.lblStaffCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffCode.Enabled = True
		Me.lblStaffCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffCode.UseMnemonic = True
		Me.lblStaffCode.Visible = True
		Me.lblStaffCode.AutoSize = False
		Me.lblStaffCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffCode.Name = "lblStaffCode"
		Me.lblStaffName.Text = "STAFFNAME"
		Me.lblStaffName.Size = New System.Drawing.Size(92, 16)
		Me.lblStaffName.Location = New System.Drawing.Point(24, 68)
		Me.lblStaffName.TabIndex = 4
		Me.lblStaffName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffName.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffName.Enabled = True
		Me.lblStaffName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffName.UseMnemonic = True
		Me.lblStaffName.Visible = True
		Me.lblStaffName.AutoSize = False
		Me.lblStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffName.Name = "lblStaffName"
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
		Me.tbrProcess.TabIndex = 6
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
		Me.Controls.Add(cboStaffCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtStaffCode)
		Me.fraDetailInfo.Controls.Add(txtStaffName)
		Me.fraDetailInfo.Controls.Add(lblDspStaffLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspStaffLastUpd)
		Me.fraDetailInfo.Controls.Add(lblStaffLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblStaffLastUpd)
		Me.fraDetailInfo.Controls.Add(lblStaffCode)
		Me.fraDetailInfo.Controls.Add(lblStaffName)
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