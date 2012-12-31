<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmIT001
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
	Public WithEvents cboItmTypeCode As System.Windows.Forms.ComboBox
	Public WithEvents txtItmTypeCode As System.Windows.Forms.TextBox
	Public WithEvents txtItmTypeEngDesc As System.Windows.Forms.TextBox
	Public WithEvents txtItmTypeChiDesc As System.Windows.Forms.TextBox
	Public WithEvents lblItmTypeLastUpd As System.Windows.Forms.Label
	Public WithEvents lblItmTypeLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspItmTypeLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspItmTypeLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCode As System.Windows.Forms.Label
	Public WithEvents lblItmTypeEngDesc As System.Windows.Forms.Label
	Public WithEvents lblItmTypeChiDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIT001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItmTypeCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtItmTypeCode = New System.Windows.Forms.TextBox
		Me.txtItmTypeEngDesc = New System.Windows.Forms.TextBox
		Me.txtItmTypeChiDesc = New System.Windows.Forms.TextBox
		Me.lblItmTypeLastUpd = New System.Windows.Forms.Label
		Me.lblItmTypeLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspItmTypeLastUpd = New System.Windows.Forms.Label
		Me.lblDspItmTypeLastUpdDate = New System.Windows.Forms.Label
		Me.lblItmTypeCode = New System.Windows.Forms.Label
		Me.lblItmTypeEngDesc = New System.Windows.Forms.Label
		Me.lblItmTypeChiDesc = New System.Windows.Forms.Label
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
		Me.Text = "圖書分類"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmIT001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmIT001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 13
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItmTypeCode.Size = New System.Drawing.Size(182, 20)
		Me.cboItmTypeCode.Location = New System.Drawing.Point(120, 64)
		Me.cboItmTypeCode.TabIndex = 0
		Me.cboItmTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeCode.CausesValidation = True
		Me.cboItmTypeCode.Enabled = True
		Me.cboItmTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeCode.IntegralHeight = True
		Me.cboItmTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeCode.Sorted = False
		Me.cboItmTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeCode.TabStop = True
		Me.cboItmTypeCode.Visible = True
		Me.cboItmTypeCode.Name = "cboItmTypeCode"
		Me.fraDetailInfo.Text = "圖書分類"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 201)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 4
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtItmTypeCode.AutoSize = False
		Me.txtItmTypeCode.Size = New System.Drawing.Size(182, 20)
		Me.txtItmTypeCode.Location = New System.Drawing.Point(112, 40)
		Me.txtItmTypeCode.TabIndex = 3
		Me.txtItmTypeCode.Tag = "K"
		Me.txtItmTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmTypeCode.AcceptsReturn = True
		Me.txtItmTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmTypeCode.CausesValidation = True
		Me.txtItmTypeCode.Enabled = True
		Me.txtItmTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmTypeCode.HideSelection = True
		Me.txtItmTypeCode.ReadOnly = False
		Me.txtItmTypeCode.Maxlength = 0
		Me.txtItmTypeCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmTypeCode.MultiLine = False
		Me.txtItmTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmTypeCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmTypeCode.TabStop = True
		Me.txtItmTypeCode.Visible = True
		Me.txtItmTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmTypeCode.Name = "txtItmTypeCode"
		Me.txtItmTypeEngDesc.AutoSize = False
		Me.txtItmTypeEngDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtItmTypeEngDesc.Enabled = False
		Me.txtItmTypeEngDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtItmTypeEngDesc.Location = New System.Drawing.Point(112, 88)
		Me.txtItmTypeEngDesc.TabIndex = 2
		Me.txtItmTypeEngDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmTypeEngDesc.AcceptsReturn = True
		Me.txtItmTypeEngDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmTypeEngDesc.CausesValidation = True
		Me.txtItmTypeEngDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmTypeEngDesc.HideSelection = True
		Me.txtItmTypeEngDesc.ReadOnly = False
		Me.txtItmTypeEngDesc.Maxlength = 0
		Me.txtItmTypeEngDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmTypeEngDesc.MultiLine = False
		Me.txtItmTypeEngDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmTypeEngDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmTypeEngDesc.TabStop = True
		Me.txtItmTypeEngDesc.Visible = True
		Me.txtItmTypeEngDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmTypeEngDesc.Name = "txtItmTypeEngDesc"
		Me.txtItmTypeChiDesc.AutoSize = False
		Me.txtItmTypeChiDesc.Enabled = False
		Me.txtItmTypeChiDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtItmTypeChiDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtItmTypeChiDesc.TabIndex = 1
		Me.txtItmTypeChiDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmTypeChiDesc.AcceptsReturn = True
		Me.txtItmTypeChiDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmTypeChiDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmTypeChiDesc.CausesValidation = True
		Me.txtItmTypeChiDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmTypeChiDesc.HideSelection = True
		Me.txtItmTypeChiDesc.ReadOnly = False
		Me.txtItmTypeChiDesc.Maxlength = 0
		Me.txtItmTypeChiDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmTypeChiDesc.MultiLine = False
		Me.txtItmTypeChiDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmTypeChiDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmTypeChiDesc.TabStop = True
		Me.txtItmTypeChiDesc.Visible = True
		Me.txtItmTypeChiDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmTypeChiDesc.Name = "txtItmTypeChiDesc"
		Me.lblItmTypeLastUpd.Text = "最後修改人 :"
		Me.lblItmTypeLastUpd.Size = New System.Drawing.Size(76, 16)
		Me.lblItmTypeLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblItmTypeLastUpd.TabIndex = 11
		Me.lblItmTypeLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeLastUpd.Enabled = True
		Me.lblItmTypeLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeLastUpd.UseMnemonic = True
		Me.lblItmTypeLastUpd.Visible = True
		Me.lblItmTypeLastUpd.AutoSize = False
		Me.lblItmTypeLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeLastUpd.Name = "lblItmTypeLastUpd"
		Me.lblItmTypeLastUpdDate.Text = "最後修改日期 :"
		Me.lblItmTypeLastUpdDate.Size = New System.Drawing.Size(84, 16)
		Me.lblItmTypeLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblItmTypeLastUpdDate.TabIndex = 10
		Me.lblItmTypeLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeLastUpdDate.Enabled = True
		Me.lblItmTypeLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeLastUpdDate.UseMnemonic = True
		Me.lblItmTypeLastUpdDate.Visible = True
		Me.lblItmTypeLastUpdDate.AutoSize = False
		Me.lblItmTypeLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeLastUpdDate.Name = "lblItmTypeLastUpdDate"
		Me.lblDspItmTypeLastUpd.Size = New System.Drawing.Size(167, 20)
		Me.lblDspItmTypeLastUpd.Location = New System.Drawing.Point(112, 160)
		Me.lblDspItmTypeLastUpd.TabIndex = 9
		Me.lblDspItmTypeLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmTypeLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmTypeLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmTypeLastUpd.Enabled = True
		Me.lblDspItmTypeLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmTypeLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmTypeLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmTypeLastUpd.UseMnemonic = True
		Me.lblDspItmTypeLastUpd.Visible = True
		Me.lblDspItmTypeLastUpd.AutoSize = False
		Me.lblDspItmTypeLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmTypeLastUpd.Name = "lblDspItmTypeLastUpd"
		Me.lblDspItmTypeLastUpdDate.Size = New System.Drawing.Size(167, 20)
		Me.lblDspItmTypeLastUpdDate.Location = New System.Drawing.Point(376, 160)
		Me.lblDspItmTypeLastUpdDate.TabIndex = 8
		Me.lblDspItmTypeLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmTypeLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmTypeLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmTypeLastUpdDate.Enabled = True
		Me.lblDspItmTypeLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmTypeLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmTypeLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmTypeLastUpdDate.UseMnemonic = True
		Me.lblDspItmTypeLastUpdDate.Visible = True
		Me.lblDspItmTypeLastUpdDate.AutoSize = False
		Me.lblDspItmTypeLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmTypeLastUpdDate.Name = "lblDspItmTypeLastUpdDate"
		Me.lblItmTypeCode.Text = "分類編碼 :"
		Me.lblItmTypeCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblItmTypeCode.Size = New System.Drawing.Size(84, 16)
		Me.lblItmTypeCode.Location = New System.Drawing.Point(24, 44)
		Me.lblItmTypeCode.TabIndex = 7
		Me.lblItmTypeCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeCode.Enabled = True
		Me.lblItmTypeCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeCode.UseMnemonic = True
		Me.lblItmTypeCode.Visible = True
		Me.lblItmTypeCode.AutoSize = False
		Me.lblItmTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeCode.Name = "lblItmTypeCode"
		Me.lblItmTypeEngDesc.Text = "英文註解 :"
		Me.lblItmTypeEngDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblItmTypeEngDesc.Location = New System.Drawing.Point(24, 92)
		Me.lblItmTypeEngDesc.TabIndex = 6
		Me.lblItmTypeEngDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeEngDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeEngDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeEngDesc.Enabled = True
		Me.lblItmTypeEngDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeEngDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeEngDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeEngDesc.UseMnemonic = True
		Me.lblItmTypeEngDesc.Visible = True
		Me.lblItmTypeEngDesc.AutoSize = False
		Me.lblItmTypeEngDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeEngDesc.Name = "lblItmTypeEngDesc"
		Me.lblItmTypeChiDesc.Text = "中文註解 :"
		Me.lblItmTypeChiDesc.Size = New System.Drawing.Size(81, 17)
		Me.lblItmTypeChiDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblItmTypeChiDesc.TabIndex = 5
		Me.lblItmTypeChiDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeChiDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeChiDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeChiDesc.Enabled = True
		Me.lblItmTypeChiDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeChiDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeChiDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeChiDesc.UseMnemonic = True
		Me.lblItmTypeChiDesc.Visible = True
		Me.lblItmTypeChiDesc.AutoSize = False
		Me.lblItmTypeChiDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeChiDesc.Name = "lblItmTypeChiDesc"
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
		Me.tbrProcess.TabIndex = 12
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
		Me.Controls.Add(cboItmTypeCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtItmTypeCode)
		Me.fraDetailInfo.Controls.Add(txtItmTypeEngDesc)
		Me.fraDetailInfo.Controls.Add(txtItmTypeChiDesc)
		Me.fraDetailInfo.Controls.Add(lblItmTypeLastUpd)
		Me.fraDetailInfo.Controls.Add(lblItmTypeLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspItmTypeLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspItmTypeLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblItmTypeCode)
		Me.fraDetailInfo.Controls.Add(lblItmTypeEngDesc)
		Me.fraDetailInfo.Controls.Add(lblItmTypeChiDesc)
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