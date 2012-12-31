<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWH001
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
	Public WithEvents cboWhsCode As System.Windows.Forms.ComboBox
	Public WithEvents txtWhsCode As System.Windows.Forms.TextBox
	Public WithEvents txtWhsDesc As System.Windows.Forms.TextBox
	Public WithEvents lblWhsLastUpd As System.Windows.Forms.Label
	Public WithEvents lblWhsLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspWhsLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspWhsLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblWhsCode As System.Windows.Forms.Label
	Public WithEvents lblWhsDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWH001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboWhsCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtWhsCode = New System.Windows.Forms.TextBox
		Me.txtWhsDesc = New System.Windows.Forms.TextBox
		Me.lblWhsLastUpd = New System.Windows.Forms.Label
		Me.lblWhsLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspWhsLastUpd = New System.Windows.Forms.Label
		Me.lblDspWhsLastUpdDate = New System.Windows.Forms.Label
		Me.lblWhsCode = New System.Windows.Forms.Label
		Me.lblWhsDesc = New System.Windows.Forms.Label
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
		Me.Icon = CType(resources.GetObject("frmWH001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmWH001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 9
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboWhsCode.Size = New System.Drawing.Size(78, 20)
		Me.cboWhsCode.Location = New System.Drawing.Point(160, 64)
		Me.cboWhsCode.TabIndex = 10
		Me.cboWhsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWhsCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWhsCode.CausesValidation = True
		Me.cboWhsCode.Enabled = True
		Me.cboWhsCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWhsCode.IntegralHeight = True
		Me.cboWhsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWhsCode.Sorted = False
		Me.cboWhsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWhsCode.TabStop = True
		Me.cboWhsCode.Visible = True
		Me.cboWhsCode.Name = "cboWhsCode"
		Me.fraDetailInfo.Text = "會計版別"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 201)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 1
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtWhsCode.AutoSize = False
		Me.txtWhsCode.Enabled = False
		Me.txtWhsCode.Size = New System.Drawing.Size(75, 20)
		Me.txtWhsCode.Location = New System.Drawing.Point(152, 40)
		Me.txtWhsCode.TabIndex = 11
		Me.txtWhsCode.Text = "01234567891"
		Me.txtWhsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWhsCode.AcceptsReturn = True
		Me.txtWhsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWhsCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtWhsCode.CausesValidation = True
		Me.txtWhsCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWhsCode.HideSelection = True
		Me.txtWhsCode.ReadOnly = False
		Me.txtWhsCode.Maxlength = 0
		Me.txtWhsCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWhsCode.MultiLine = False
		Me.txtWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWhsCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWhsCode.TabStop = True
		Me.txtWhsCode.Visible = True
		Me.txtWhsCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWhsCode.Name = "txtWhsCode"
		Me.txtWhsDesc.AutoSize = False
		Me.txtWhsDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtWhsDesc.Enabled = False
		Me.txtWhsDesc.Size = New System.Drawing.Size(313, 20)
		Me.txtWhsDesc.Location = New System.Drawing.Point(152, 64)
		Me.txtWhsDesc.TabIndex = 0
		Me.txtWhsDesc.Text = "012345678911234567892123456789312345678941234567895"
		Me.txtWhsDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWhsDesc.AcceptsReturn = True
		Me.txtWhsDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWhsDesc.CausesValidation = True
		Me.txtWhsDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWhsDesc.HideSelection = True
		Me.txtWhsDesc.ReadOnly = False
		Me.txtWhsDesc.Maxlength = 0
		Me.txtWhsDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWhsDesc.MultiLine = False
		Me.txtWhsDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWhsDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWhsDesc.TabStop = True
		Me.txtWhsDesc.Visible = True
		Me.txtWhsDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWhsDesc.Name = "txtWhsDesc"
		Me.lblWhsLastUpd.Text = "最後修改人 :"
		Me.lblWhsLastUpd.Size = New System.Drawing.Size(124, 16)
		Me.lblWhsLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblWhsLastUpd.TabIndex = 8
		Me.lblWhsLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsLastUpd.Enabled = True
		Me.lblWhsLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsLastUpd.UseMnemonic = True
		Me.lblWhsLastUpd.Visible = True
		Me.lblWhsLastUpd.AutoSize = False
		Me.lblWhsLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsLastUpd.Name = "lblWhsLastUpd"
		Me.lblWhsLastUpdDate.Text = "最後修改日期 :"
		Me.lblWhsLastUpdDate.Size = New System.Drawing.Size(148, 16)
		Me.lblWhsLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblWhsLastUpdDate.TabIndex = 7
		Me.lblWhsLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsLastUpdDate.Enabled = True
		Me.lblWhsLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsLastUpdDate.UseMnemonic = True
		Me.lblWhsLastUpdDate.Visible = True
		Me.lblWhsLastUpdDate.AutoSize = False
		Me.lblWhsLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsLastUpdDate.Name = "lblWhsLastUpdDate"
		Me.lblDspWhsLastUpd.Size = New System.Drawing.Size(111, 20)
		Me.lblDspWhsLastUpd.Location = New System.Drawing.Point(152, 160)
		Me.lblDspWhsLastUpd.TabIndex = 6
		Me.lblDspWhsLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWhsLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWhsLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWhsLastUpd.Enabled = True
		Me.lblDspWhsLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWhsLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWhsLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWhsLastUpd.UseMnemonic = True
		Me.lblDspWhsLastUpd.Visible = True
		Me.lblDspWhsLastUpd.AutoSize = False
		Me.lblDspWhsLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWhsLastUpd.Name = "lblDspWhsLastUpd"
		Me.lblDspWhsLastUpdDate.Size = New System.Drawing.Size(95, 20)
		Me.lblDspWhsLastUpdDate.Location = New System.Drawing.Point(448, 160)
		Me.lblDspWhsLastUpdDate.TabIndex = 5
		Me.lblDspWhsLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspWhsLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspWhsLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspWhsLastUpdDate.Enabled = True
		Me.lblDspWhsLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspWhsLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspWhsLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspWhsLastUpdDate.UseMnemonic = True
		Me.lblDspWhsLastUpdDate.Visible = True
		Me.lblDspWhsLastUpdDate.AutoSize = False
		Me.lblDspWhsLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspWhsLastUpdDate.Name = "lblDspWhsLastUpdDate"
		Me.lblWhsCode.Text = "WhsCode :"
		Me.lblWhsCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblWhsCode.Size = New System.Drawing.Size(124, 16)
		Me.lblWhsCode.Location = New System.Drawing.Point(24, 44)
		Me.lblWhsCode.TabIndex = 4
		Me.lblWhsCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsCode.Enabled = True
		Me.lblWhsCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsCode.UseMnemonic = True
		Me.lblWhsCode.Visible = True
		Me.lblWhsCode.AutoSize = False
		Me.lblWhsCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsCode.Name = "lblWhsCode"
		Me.lblWhsDesc.Text = "WhsDesc. :"
		Me.lblWhsDesc.Size = New System.Drawing.Size(121, 17)
		Me.lblWhsDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblWhsDesc.TabIndex = 3
		Me.lblWhsDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsDesc.Enabled = True
		Me.lblWhsDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsDesc.UseMnemonic = True
		Me.lblWhsDesc.Visible = True
		Me.lblWhsDesc.AutoSize = False
		Me.lblWhsDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsDesc.Name = "lblWhsDesc"
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
		Me.tbrProcess.TabIndex = 2
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
		Me.Controls.Add(cboWhsCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtWhsCode)
		Me.fraDetailInfo.Controls.Add(txtWhsDesc)
		Me.fraDetailInfo.Controls.Add(lblWhsLastUpd)
		Me.fraDetailInfo.Controls.Add(lblWhsLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspWhsLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspWhsLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblWhsCode)
		Me.fraDetailInfo.Controls.Add(lblWhsDesc)
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