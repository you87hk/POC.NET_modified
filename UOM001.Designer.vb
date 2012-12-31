<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUOM001
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
	Public WithEvents cboUOMCode As System.Windows.Forms.ComboBox
	Public WithEvents txtUOMCode As System.Windows.Forms.TextBox
	Public WithEvents txtUOMDesc As System.Windows.Forms.TextBox
	Public WithEvents lblUOMLastUpd As System.Windows.Forms.Label
	Public WithEvents lblUOMLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspUOMLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspUOMLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblUOMCode As System.Windows.Forms.Label
	Public WithEvents lblUOMDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUOM001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboUOMCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtUOMCode = New System.Windows.Forms.TextBox
		Me.txtUOMDesc = New System.Windows.Forms.TextBox
		Me.lblUOMLastUpd = New System.Windows.Forms.Label
		Me.lblUOMLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspUOMLastUpd = New System.Windows.Forms.Label
		Me.lblDspUOMLastUpdDate = New System.Windows.Forms.Label
		Me.lblUOMCode = New System.Windows.Forms.Label
		Me.lblUOMDesc = New System.Windows.Forms.Label
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
		Me.Text = "單位資料"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmUOM001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmUOM001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboUOMCode.Size = New System.Drawing.Size(182, 20)
		Me.cboUOMCode.Location = New System.Drawing.Point(120, 64)
		Me.cboUOMCode.TabIndex = 11
		Me.cboUOMCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUOMCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboUOMCode.CausesValidation = True
		Me.cboUOMCode.Enabled = True
		Me.cboUOMCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUOMCode.IntegralHeight = True
		Me.cboUOMCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUOMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUOMCode.Sorted = False
		Me.cboUOMCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUOMCode.TabStop = True
		Me.cboUOMCode.Visible = True
		Me.cboUOMCode.Name = "cboUOMCode"
		Me.fraDetailInfo.Text = "單位"
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
		Me.txtUOMCode.AutoSize = False
		Me.txtUOMCode.Size = New System.Drawing.Size(182, 20)
		Me.txtUOMCode.Location = New System.Drawing.Point(112, 40)
		Me.txtUOMCode.TabIndex = 0
		Me.txtUOMCode.Tag = "K"
		Me.txtUOMCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUOMCode.AcceptsReturn = True
		Me.txtUOMCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUOMCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtUOMCode.CausesValidation = True
		Me.txtUOMCode.Enabled = True
		Me.txtUOMCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUOMCode.HideSelection = True
		Me.txtUOMCode.ReadOnly = False
		Me.txtUOMCode.Maxlength = 0
		Me.txtUOMCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUOMCode.MultiLine = False
		Me.txtUOMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUOMCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUOMCode.TabStop = True
		Me.txtUOMCode.Visible = True
		Me.txtUOMCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUOMCode.Name = "txtUOMCode"
		Me.txtUOMDesc.AutoSize = False
		Me.txtUOMDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtUOMDesc.Enabled = False
		Me.txtUOMDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtUOMDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtUOMDesc.TabIndex = 1
		Me.txtUOMDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUOMDesc.AcceptsReturn = True
		Me.txtUOMDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUOMDesc.CausesValidation = True
		Me.txtUOMDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUOMDesc.HideSelection = True
		Me.txtUOMDesc.ReadOnly = False
		Me.txtUOMDesc.Maxlength = 0
		Me.txtUOMDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUOMDesc.MultiLine = False
		Me.txtUOMDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUOMDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUOMDesc.TabStop = True
		Me.txtUOMDesc.Visible = True
		Me.txtUOMDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUOMDesc.Name = "txtUOMDesc"
		Me.lblUOMLastUpd.Text = "最後修改人 :"
		Me.lblUOMLastUpd.Size = New System.Drawing.Size(132, 16)
		Me.lblUOMLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblUOMLastUpd.TabIndex = 8
		Me.lblUOMLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUOMLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUOMLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblUOMLastUpd.Enabled = True
		Me.lblUOMLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUOMLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUOMLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUOMLastUpd.UseMnemonic = True
		Me.lblUOMLastUpd.Visible = True
		Me.lblUOMLastUpd.AutoSize = False
		Me.lblUOMLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUOMLastUpd.Name = "lblUOMLastUpd"
		Me.lblUOMLastUpdDate.Text = "最後修改日期 :"
		Me.lblUOMLastUpdDate.Size = New System.Drawing.Size(132, 16)
		Me.lblUOMLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblUOMLastUpdDate.TabIndex = 7
		Me.lblUOMLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUOMLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUOMLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblUOMLastUpdDate.Enabled = True
		Me.lblUOMLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUOMLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUOMLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUOMLastUpdDate.UseMnemonic = True
		Me.lblUOMLastUpdDate.Visible = True
		Me.lblUOMLastUpdDate.AutoSize = False
		Me.lblUOMLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUOMLastUpdDate.Name = "lblUOMLastUpdDate"
		Me.lblDspUOMLastUpd.Size = New System.Drawing.Size(119, 20)
		Me.lblDspUOMLastUpd.Location = New System.Drawing.Point(160, 160)
		Me.lblDspUOMLastUpd.TabIndex = 6
		Me.lblDspUOMLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspUOMLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspUOMLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspUOMLastUpd.Enabled = True
		Me.lblDspUOMLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspUOMLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspUOMLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspUOMLastUpd.UseMnemonic = True
		Me.lblDspUOMLastUpd.Visible = True
		Me.lblDspUOMLastUpd.AutoSize = False
		Me.lblDspUOMLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspUOMLastUpd.Name = "lblDspUOMLastUpd"
		Me.lblDspUOMLastUpdDate.Size = New System.Drawing.Size(111, 20)
		Me.lblDspUOMLastUpdDate.Location = New System.Drawing.Point(432, 160)
		Me.lblDspUOMLastUpdDate.TabIndex = 5
		Me.lblDspUOMLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspUOMLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspUOMLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspUOMLastUpdDate.Enabled = True
		Me.lblDspUOMLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspUOMLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspUOMLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspUOMLastUpdDate.UseMnemonic = True
		Me.lblDspUOMLastUpdDate.Visible = True
		Me.lblDspUOMLastUpdDate.AutoSize = False
		Me.lblDspUOMLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspUOMLastUpdDate.Name = "lblDspUOMLastUpdDate"
		Me.lblUOMCode.Text = "單位編碼 :"
		Me.lblUOMCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblUOMCode.Size = New System.Drawing.Size(84, 16)
		Me.lblUOMCode.Location = New System.Drawing.Point(24, 44)
		Me.lblUOMCode.TabIndex = 4
		Me.lblUOMCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUOMCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblUOMCode.Enabled = True
		Me.lblUOMCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUOMCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUOMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUOMCode.UseMnemonic = True
		Me.lblUOMCode.Visible = True
		Me.lblUOMCode.AutoSize = False
		Me.lblUOMCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUOMCode.Name = "lblUOMCode"
		Me.lblUOMDesc.Text = "單位註解 :"
		Me.lblUOMDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblUOMDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblUOMDesc.TabIndex = 3
		Me.lblUOMDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUOMDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUOMDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblUOMDesc.Enabled = True
		Me.lblUOMDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUOMDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUOMDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUOMDesc.UseMnemonic = True
		Me.lblUOMDesc.Visible = True
		Me.lblUOMDesc.AutoSize = False
		Me.lblUOMDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUOMDesc.Name = "lblUOMDesc"
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
		Me.Controls.Add(cboUOMCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtUOMCode)
		Me.fraDetailInfo.Controls.Add(txtUOMDesc)
		Me.fraDetailInfo.Controls.Add(lblUOMLastUpd)
		Me.fraDetailInfo.Controls.Add(lblUOMLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspUOMLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspUOMLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblUOMCode)
		Me.fraDetailInfo.Controls.Add(lblUOMDesc)
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