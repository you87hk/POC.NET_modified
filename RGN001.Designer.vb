<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRGN001
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
	Public WithEvents cboRgnCode As System.Windows.Forms.ComboBox
	Public WithEvents txtRgnCode As System.Windows.Forms.TextBox
	Public WithEvents txtRgnDesc As System.Windows.Forms.TextBox
	Public WithEvents lblRgnLastUpd As System.Windows.Forms.Label
	Public WithEvents lblRgnLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspRgnLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspRgnLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblRgnCode As System.Windows.Forms.Label
	Public WithEvents lblRgnDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRGN001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboRgnCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtRgnCode = New System.Windows.Forms.TextBox
		Me.txtRgnDesc = New System.Windows.Forms.TextBox
		Me.lblRgnLastUpd = New System.Windows.Forms.Label
		Me.lblRgnLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspRgnLastUpd = New System.Windows.Forms.Label
		Me.lblDspRgnLastUpdDate = New System.Windows.Forms.Label
		Me.lblRgnCode = New System.Windows.Forms.Label
		Me.lblRgnDesc = New System.Windows.Forms.Label
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
		Me.Text = "REGION"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmRGN001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmRGN001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboRgnCode.Size = New System.Drawing.Size(182, 20)
		Me.cboRgnCode.Location = New System.Drawing.Point(152, 64)
		Me.cboRgnCode.TabIndex = 11
		Me.cboRgnCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboRgnCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboRgnCode.CausesValidation = True
		Me.cboRgnCode.Enabled = True
		Me.cboRgnCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboRgnCode.IntegralHeight = True
		Me.cboRgnCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboRgnCode.Sorted = False
		Me.cboRgnCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboRgnCode.TabStop = True
		Me.cboRgnCode.Visible = True
		Me.cboRgnCode.Name = "cboRgnCode"
		Me.fraDetailInfo.Text = "REGION"
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
		Me.txtRgnCode.AutoSize = False
		Me.txtRgnCode.Size = New System.Drawing.Size(182, 20)
		Me.txtRgnCode.Location = New System.Drawing.Point(144, 40)
		Me.txtRgnCode.TabIndex = 0
		Me.txtRgnCode.Tag = "K"
		Me.txtRgnCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRgnCode.AcceptsReturn = True
		Me.txtRgnCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRgnCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtRgnCode.CausesValidation = True
		Me.txtRgnCode.Enabled = True
		Me.txtRgnCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRgnCode.HideSelection = True
		Me.txtRgnCode.ReadOnly = False
		Me.txtRgnCode.Maxlength = 0
		Me.txtRgnCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRgnCode.MultiLine = False
		Me.txtRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRgnCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRgnCode.TabStop = True
		Me.txtRgnCode.Visible = True
		Me.txtRgnCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRgnCode.Name = "txtRgnCode"
		Me.txtRgnDesc.AutoSize = False
		Me.txtRgnDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtRgnDesc.Enabled = False
		Me.txtRgnDesc.Size = New System.Drawing.Size(401, 20)
		Me.txtRgnDesc.Location = New System.Drawing.Point(144, 64)
		Me.txtRgnDesc.TabIndex = 1
		Me.txtRgnDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRgnDesc.AcceptsReturn = True
		Me.txtRgnDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRgnDesc.CausesValidation = True
		Me.txtRgnDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRgnDesc.HideSelection = True
		Me.txtRgnDesc.ReadOnly = False
		Me.txtRgnDesc.Maxlength = 0
		Me.txtRgnDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRgnDesc.MultiLine = False
		Me.txtRgnDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRgnDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRgnDesc.TabStop = True
		Me.txtRgnDesc.Visible = True
		Me.txtRgnDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRgnDesc.Name = "txtRgnDesc"
		Me.lblRgnLastUpd.Text = "最後修改人 :"
		Me.lblRgnLastUpd.Size = New System.Drawing.Size(116, 16)
		Me.lblRgnLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblRgnLastUpd.TabIndex = 8
		Me.lblRgnLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRgnLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRgnLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblRgnLastUpd.Enabled = True
		Me.lblRgnLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRgnLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRgnLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRgnLastUpd.UseMnemonic = True
		Me.lblRgnLastUpd.Visible = True
		Me.lblRgnLastUpd.AutoSize = False
		Me.lblRgnLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRgnLastUpd.Name = "lblRgnLastUpd"
		Me.lblRgnLastUpdDate.Text = "最後修改日期 :"
		Me.lblRgnLastUpdDate.Size = New System.Drawing.Size(124, 16)
		Me.lblRgnLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblRgnLastUpdDate.TabIndex = 7
		Me.lblRgnLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRgnLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRgnLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblRgnLastUpdDate.Enabled = True
		Me.lblRgnLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRgnLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRgnLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRgnLastUpdDate.UseMnemonic = True
		Me.lblRgnLastUpdDate.Visible = True
		Me.lblRgnLastUpdDate.AutoSize = False
		Me.lblRgnLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRgnLastUpdDate.Name = "lblRgnLastUpdDate"
		Me.lblDspRgnLastUpd.Size = New System.Drawing.Size(135, 20)
		Me.lblDspRgnLastUpd.Location = New System.Drawing.Point(144, 160)
		Me.lblDspRgnLastUpd.TabIndex = 6
		Me.lblDspRgnLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspRgnLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspRgnLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspRgnLastUpd.Enabled = True
		Me.lblDspRgnLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspRgnLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspRgnLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspRgnLastUpd.UseMnemonic = True
		Me.lblDspRgnLastUpd.Visible = True
		Me.lblDspRgnLastUpd.AutoSize = False
		Me.lblDspRgnLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspRgnLastUpd.Name = "lblDspRgnLastUpd"
		Me.lblDspRgnLastUpdDate.Size = New System.Drawing.Size(119, 20)
		Me.lblDspRgnLastUpdDate.Location = New System.Drawing.Point(424, 160)
		Me.lblDspRgnLastUpdDate.TabIndex = 5
		Me.lblDspRgnLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspRgnLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspRgnLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspRgnLastUpdDate.Enabled = True
		Me.lblDspRgnLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspRgnLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspRgnLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspRgnLastUpdDate.UseMnemonic = True
		Me.lblDspRgnLastUpdDate.Visible = True
		Me.lblDspRgnLastUpdDate.AutoSize = False
		Me.lblDspRgnLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspRgnLastUpdDate.Name = "lblDspRgnLastUpdDate"
		Me.lblRgnCode.Text = "RGNCODE"
		Me.lblRgnCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblRgnCode.Size = New System.Drawing.Size(116, 16)
		Me.lblRgnCode.Location = New System.Drawing.Point(24, 44)
		Me.lblRgnCode.TabIndex = 4
		Me.lblRgnCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRgnCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblRgnCode.Enabled = True
		Me.lblRgnCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRgnCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRgnCode.UseMnemonic = True
		Me.lblRgnCode.Visible = True
		Me.lblRgnCode.AutoSize = False
		Me.lblRgnCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRgnCode.Name = "lblRgnCode"
		Me.lblRgnDesc.Text = "RGNDESC"
		Me.lblRgnDesc.Size = New System.Drawing.Size(116, 16)
		Me.lblRgnDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblRgnDesc.TabIndex = 3
		Me.lblRgnDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRgnDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRgnDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblRgnDesc.Enabled = True
		Me.lblRgnDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRgnDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRgnDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRgnDesc.UseMnemonic = True
		Me.lblRgnDesc.Visible = True
		Me.lblRgnDesc.AutoSize = False
		Me.lblRgnDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRgnDesc.Name = "lblRgnDesc"
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
		Me.Controls.Add(cboRgnCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtRgnCode)
		Me.fraDetailInfo.Controls.Add(txtRgnDesc)
		Me.fraDetailInfo.Controls.Add(lblRgnLastUpd)
		Me.fraDetailInfo.Controls.Add(lblRgnLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspRgnLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspRgnLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblRgnCode)
		Me.fraDetailInfo.Controls.Add(lblRgnDesc)
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