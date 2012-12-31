<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPR001
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
	Public WithEvents cboPrcCode As System.Windows.Forms.ComboBox
	Public WithEvents txtPrcCode As System.Windows.Forms.TextBox
	Public WithEvents txtPrcDesc As System.Windows.Forms.TextBox
	Public WithEvents txtPricePort As System.Windows.Forms.TextBox
	Public WithEvents lblPrcLastUpd As System.Windows.Forms.Label
	Public WithEvents lblPrcLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspPrcLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspPrcLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblPrcCode As System.Windows.Forms.Label
	Public WithEvents lblPricePort As System.Windows.Forms.Label
	Public WithEvents lblPrcDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPR001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboPrcCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtPrcCode = New System.Windows.Forms.TextBox
		Me.txtPrcDesc = New System.Windows.Forms.TextBox
		Me.txtPricePort = New System.Windows.Forms.TextBox
		Me.lblPrcLastUpd = New System.Windows.Forms.Label
		Me.lblPrcLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspPrcLastUpd = New System.Windows.Forms.Label
		Me.lblDspPrcLastUpdDate = New System.Windows.Forms.Label
		Me.lblPrcCode = New System.Windows.Forms.Label
		Me.lblPricePort = New System.Windows.Forms.Label
		Me.lblPrcDesc = New System.Windows.Forms.Label
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
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmPR001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPR001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 12
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboPrcCode.Size = New System.Drawing.Size(78, 20)
		Me.cboPrcCode.Location = New System.Drawing.Point(144, 64)
		Me.cboPrcCode.TabIndex = 0
		Me.cboPrcCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPrcCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboPrcCode.CausesValidation = True
		Me.cboPrcCode.Enabled = True
		Me.cboPrcCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPrcCode.IntegralHeight = True
		Me.cboPrcCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPrcCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPrcCode.Sorted = False
		Me.cboPrcCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPrcCode.TabStop = True
		Me.cboPrcCode.Visible = True
		Me.cboPrcCode.Name = "cboPrcCode"
		Me.fraDetailInfo.Text = "會計版別"
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
		Me.txtPrcCode.AutoSize = False
		Me.txtPrcCode.Enabled = False
		Me.txtPrcCode.Size = New System.Drawing.Size(75, 20)
		Me.txtPrcCode.Location = New System.Drawing.Point(136, 40)
		Me.txtPrcCode.TabIndex = 13
		Me.txtPrcCode.Text = "01234567891"
		Me.txtPrcCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPrcCode.AcceptsReturn = True
		Me.txtPrcCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPrcCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtPrcCode.CausesValidation = True
		Me.txtPrcCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPrcCode.HideSelection = True
		Me.txtPrcCode.ReadOnly = False
		Me.txtPrcCode.Maxlength = 0
		Me.txtPrcCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPrcCode.MultiLine = False
		Me.txtPrcCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPrcCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPrcCode.TabStop = True
		Me.txtPrcCode.Visible = True
		Me.txtPrcCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPrcCode.Name = "txtPrcCode"
		Me.txtPrcDesc.AutoSize = False
		Me.txtPrcDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtPrcDesc.Enabled = False
		Me.txtPrcDesc.Size = New System.Drawing.Size(313, 20)
		Me.txtPrcDesc.Location = New System.Drawing.Point(136, 64)
		Me.txtPrcDesc.TabIndex = 1
		Me.txtPrcDesc.Text = "012345678911234567892123456789312345678941234567895"
		Me.txtPrcDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPrcDesc.AcceptsReturn = True
		Me.txtPrcDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPrcDesc.CausesValidation = True
		Me.txtPrcDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPrcDesc.HideSelection = True
		Me.txtPrcDesc.ReadOnly = False
		Me.txtPrcDesc.Maxlength = 0
		Me.txtPrcDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPrcDesc.MultiLine = False
		Me.txtPrcDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPrcDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPrcDesc.TabStop = True
		Me.txtPrcDesc.Visible = True
		Me.txtPrcDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPrcDesc.Name = "txtPrcDesc"
		Me.txtPricePort.AutoSize = False
		Me.txtPricePort.Enabled = False
		Me.txtPricePort.Size = New System.Drawing.Size(315, 20)
		Me.txtPricePort.Location = New System.Drawing.Point(136, 88)
		Me.txtPricePort.TabIndex = 2
		Me.txtPricePort.Text = "012345678911234567892123456789312345678941234567895"
		Me.txtPricePort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPricePort.AcceptsReturn = True
		Me.txtPricePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPricePort.BackColor = System.Drawing.SystemColors.Window
		Me.txtPricePort.CausesValidation = True
		Me.txtPricePort.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPricePort.HideSelection = True
		Me.txtPricePort.ReadOnly = False
		Me.txtPricePort.Maxlength = 0
		Me.txtPricePort.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPricePort.MultiLine = False
		Me.txtPricePort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPricePort.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPricePort.TabStop = True
		Me.txtPricePort.Visible = True
		Me.txtPricePort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPricePort.Name = "txtPricePort"
		Me.lblPrcLastUpd.Text = "最後修改人 :"
		Me.lblPrcLastUpd.Size = New System.Drawing.Size(108, 16)
		Me.lblPrcLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblPrcLastUpd.TabIndex = 11
		Me.lblPrcLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrcLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrcLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrcLastUpd.Enabled = True
		Me.lblPrcLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrcLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrcLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrcLastUpd.UseMnemonic = True
		Me.lblPrcLastUpd.Visible = True
		Me.lblPrcLastUpd.AutoSize = False
		Me.lblPrcLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrcLastUpd.Name = "lblPrcLastUpd"
		Me.lblPrcLastUpdDate.Text = "最後修改日期 :"
		Me.lblPrcLastUpdDate.Size = New System.Drawing.Size(116, 16)
		Me.lblPrcLastUpdDate.Location = New System.Drawing.Point(272, 163)
		Me.lblPrcLastUpdDate.TabIndex = 10
		Me.lblPrcLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrcLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrcLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrcLastUpdDate.Enabled = True
		Me.lblPrcLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrcLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrcLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrcLastUpdDate.UseMnemonic = True
		Me.lblPrcLastUpdDate.Visible = True
		Me.lblPrcLastUpdDate.AutoSize = False
		Me.lblPrcLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrcLastUpdDate.Name = "lblPrcLastUpdDate"
		Me.lblDspPrcLastUpd.Size = New System.Drawing.Size(127, 20)
		Me.lblDspPrcLastUpd.Location = New System.Drawing.Point(136, 160)
		Me.lblDspPrcLastUpd.TabIndex = 9
		Me.lblDspPrcLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPrcLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPrcLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPrcLastUpd.Enabled = True
		Me.lblDspPrcLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPrcLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPrcLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPrcLastUpd.UseMnemonic = True
		Me.lblDspPrcLastUpd.Visible = True
		Me.lblDspPrcLastUpd.AutoSize = False
		Me.lblDspPrcLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPrcLastUpd.Name = "lblDspPrcLastUpd"
		Me.lblDspPrcLastUpdDate.Size = New System.Drawing.Size(151, 20)
		Me.lblDspPrcLastUpdDate.Location = New System.Drawing.Point(392, 160)
		Me.lblDspPrcLastUpdDate.TabIndex = 8
		Me.lblDspPrcLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPrcLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPrcLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPrcLastUpdDate.Enabled = True
		Me.lblDspPrcLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPrcLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPrcLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPrcLastUpdDate.UseMnemonic = True
		Me.lblDspPrcLastUpdDate.Visible = True
		Me.lblDspPrcLastUpdDate.AutoSize = False
		Me.lblDspPrcLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPrcLastUpdDate.Name = "lblDspPrcLastUpdDate"
		Me.lblPrcCode.Text = "價錢編碼 :"
		Me.lblPrcCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblPrcCode.Size = New System.Drawing.Size(108, 16)
		Me.lblPrcCode.Location = New System.Drawing.Point(24, 44)
		Me.lblPrcCode.TabIndex = 7
		Me.lblPrcCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrcCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrcCode.Enabled = True
		Me.lblPrcCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrcCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrcCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrcCode.UseMnemonic = True
		Me.lblPrcCode.Visible = True
		Me.lblPrcCode.AutoSize = False
		Me.lblPrcCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrcCode.Name = "lblPrcCode"
		Me.lblPricePort.Text = "價錢註解 :"
		Me.lblPricePort.Size = New System.Drawing.Size(108, 16)
		Me.lblPricePort.Location = New System.Drawing.Point(24, 92)
		Me.lblPricePort.TabIndex = 6
		Me.lblPricePort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPricePort.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPricePort.BackColor = System.Drawing.SystemColors.Control
		Me.lblPricePort.Enabled = True
		Me.lblPricePort.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPricePort.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPricePort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPricePort.UseMnemonic = True
		Me.lblPricePort.Visible = True
		Me.lblPricePort.AutoSize = False
		Me.lblPricePort.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPricePort.Name = "lblPricePort"
		Me.lblPrcDesc.Text = "PrcDesc. :"
		Me.lblPrcDesc.Size = New System.Drawing.Size(108, 17)
		Me.lblPrcDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblPrcDesc.TabIndex = 5
		Me.lblPrcDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrcDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrcDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrcDesc.Enabled = True
		Me.lblPrcDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrcDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrcDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrcDesc.UseMnemonic = True
		Me.lblPrcDesc.Visible = True
		Me.lblPrcDesc.AutoSize = False
		Me.lblPrcDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrcDesc.Name = "lblPrcDesc"
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
		Me.tbrProcess.TabIndex = 4
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
		Me.Controls.Add(cboPrcCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtPrcCode)
		Me.fraDetailInfo.Controls.Add(txtPrcDesc)
		Me.fraDetailInfo.Controls.Add(txtPricePort)
		Me.fraDetailInfo.Controls.Add(lblPrcLastUpd)
		Me.fraDetailInfo.Controls.Add(lblPrcLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspPrcLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspPrcLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblPrcCode)
		Me.fraDetailInfo.Controls.Add(lblPricePort)
		Me.fraDetailInfo.Controls.Add(lblPrcDesc)
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