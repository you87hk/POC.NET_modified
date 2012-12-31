<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmN001
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
	Public WithEvents cboNatureCode As System.Windows.Forms.ComboBox
	Public WithEvents txtNatureCode As System.Windows.Forms.TextBox
	Public WithEvents txtNatureDesc As System.Windows.Forms.TextBox
	Public WithEvents lblNatureLastUpd As System.Windows.Forms.Label
	Public WithEvents lblNatureLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspNatureLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspNatureLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblNatureCode As System.Windows.Forms.Label
	Public WithEvents lblNatureDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmN001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboNatureCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtNatureCode = New System.Windows.Forms.TextBox
		Me.txtNatureDesc = New System.Windows.Forms.TextBox
		Me.lblNatureLastUpd = New System.Windows.Forms.Label
		Me.lblNatureLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspNatureLastUpd = New System.Windows.Forms.Label
		Me.lblDspNatureLastUpdDate = New System.Windows.Forms.Label
		Me.lblNatureCode = New System.Windows.Forms.Label
		Me.lblNatureDesc = New System.Windows.Forms.Label
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
		Me.Text = "性質"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmN001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmN001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboNatureCode.Size = New System.Drawing.Size(182, 20)
		Me.cboNatureCode.Location = New System.Drawing.Point(120, 64)
		Me.cboNatureCode.TabIndex = 11
		Me.cboNatureCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboNatureCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboNatureCode.CausesValidation = True
		Me.cboNatureCode.Enabled = True
		Me.cboNatureCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboNatureCode.IntegralHeight = True
		Me.cboNatureCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboNatureCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboNatureCode.Sorted = False
		Me.cboNatureCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboNatureCode.TabStop = True
		Me.cboNatureCode.Visible = True
		Me.cboNatureCode.Name = "cboNatureCode"
		Me.fraDetailInfo.Text = "性質"
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
		Me.txtNatureCode.AutoSize = False
		Me.txtNatureCode.Size = New System.Drawing.Size(182, 20)
		Me.txtNatureCode.Location = New System.Drawing.Point(112, 40)
		Me.txtNatureCode.TabIndex = 0
		Me.txtNatureCode.Tag = "K"
		Me.txtNatureCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNatureCode.AcceptsReturn = True
		Me.txtNatureCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNatureCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtNatureCode.CausesValidation = True
		Me.txtNatureCode.Enabled = True
		Me.txtNatureCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNatureCode.HideSelection = True
		Me.txtNatureCode.ReadOnly = False
		Me.txtNatureCode.Maxlength = 0
		Me.txtNatureCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNatureCode.MultiLine = False
		Me.txtNatureCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNatureCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNatureCode.TabStop = True
		Me.txtNatureCode.Visible = True
		Me.txtNatureCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNatureCode.Name = "txtNatureCode"
		Me.txtNatureDesc.AutoSize = False
		Me.txtNatureDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtNatureDesc.Enabled = False
		Me.txtNatureDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtNatureDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtNatureDesc.TabIndex = 1
		Me.txtNatureDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNatureDesc.AcceptsReturn = True
		Me.txtNatureDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNatureDesc.CausesValidation = True
		Me.txtNatureDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNatureDesc.HideSelection = True
		Me.txtNatureDesc.ReadOnly = False
		Me.txtNatureDesc.Maxlength = 0
		Me.txtNatureDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNatureDesc.MultiLine = False
		Me.txtNatureDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNatureDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNatureDesc.TabStop = True
		Me.txtNatureDesc.Visible = True
		Me.txtNatureDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNatureDesc.Name = "txtNatureDesc"
		Me.lblNatureLastUpd.Text = "最後修改人 :"
		Me.lblNatureLastUpd.Size = New System.Drawing.Size(76, 16)
		Me.lblNatureLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblNatureLastUpd.TabIndex = 8
		Me.lblNatureLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNatureLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNatureLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblNatureLastUpd.Enabled = True
		Me.lblNatureLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNatureLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNatureLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNatureLastUpd.UseMnemonic = True
		Me.lblNatureLastUpd.Visible = True
		Me.lblNatureLastUpd.AutoSize = False
		Me.lblNatureLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNatureLastUpd.Name = "lblNatureLastUpd"
		Me.lblNatureLastUpdDate.Text = "最後修改日期 :"
		Me.lblNatureLastUpdDate.Size = New System.Drawing.Size(84, 16)
		Me.lblNatureLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblNatureLastUpdDate.TabIndex = 7
		Me.lblNatureLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNatureLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNatureLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblNatureLastUpdDate.Enabled = True
		Me.lblNatureLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNatureLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNatureLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNatureLastUpdDate.UseMnemonic = True
		Me.lblNatureLastUpdDate.Visible = True
		Me.lblNatureLastUpdDate.AutoSize = False
		Me.lblNatureLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNatureLastUpdDate.Name = "lblNatureLastUpdDate"
		Me.lblDspNatureLastUpd.Size = New System.Drawing.Size(167, 20)
		Me.lblDspNatureLastUpd.Location = New System.Drawing.Point(112, 160)
		Me.lblDspNatureLastUpd.TabIndex = 6
		Me.lblDspNatureLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspNatureLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspNatureLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspNatureLastUpd.Enabled = True
		Me.lblDspNatureLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspNatureLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspNatureLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspNatureLastUpd.UseMnemonic = True
		Me.lblDspNatureLastUpd.Visible = True
		Me.lblDspNatureLastUpd.AutoSize = False
		Me.lblDspNatureLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspNatureLastUpd.Name = "lblDspNatureLastUpd"
		Me.lblDspNatureLastUpdDate.Size = New System.Drawing.Size(167, 20)
		Me.lblDspNatureLastUpdDate.Location = New System.Drawing.Point(376, 160)
		Me.lblDspNatureLastUpdDate.TabIndex = 5
		Me.lblDspNatureLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspNatureLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspNatureLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspNatureLastUpdDate.Enabled = True
		Me.lblDspNatureLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspNatureLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspNatureLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspNatureLastUpdDate.UseMnemonic = True
		Me.lblDspNatureLastUpdDate.Visible = True
		Me.lblDspNatureLastUpdDate.AutoSize = False
		Me.lblDspNatureLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspNatureLastUpdDate.Name = "lblDspNatureLastUpdDate"
		Me.lblNatureCode.Text = "性質編碼 :"
		Me.lblNatureCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblNatureCode.Size = New System.Drawing.Size(84, 16)
		Me.lblNatureCode.Location = New System.Drawing.Point(24, 44)
		Me.lblNatureCode.TabIndex = 4
		Me.lblNatureCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNatureCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblNatureCode.Enabled = True
		Me.lblNatureCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNatureCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNatureCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNatureCode.UseMnemonic = True
		Me.lblNatureCode.Visible = True
		Me.lblNatureCode.AutoSize = False
		Me.lblNatureCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNatureCode.Name = "lblNatureCode"
		Me.lblNatureDesc.Text = "性質註解 :"
		Me.lblNatureDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblNatureDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblNatureDesc.TabIndex = 3
		Me.lblNatureDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNatureDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNatureDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblNatureDesc.Enabled = True
		Me.lblNatureDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNatureDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNatureDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNatureDesc.UseMnemonic = True
		Me.lblNatureDesc.Visible = True
		Me.lblNatureDesc.AutoSize = False
		Me.lblNatureDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNatureDesc.Name = "lblNatureDesc"
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
		Me.Controls.Add(cboNatureCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtNatureCode)
		Me.fraDetailInfo.Controls.Add(txtNatureDesc)
		Me.fraDetailInfo.Controls.Add(lblNatureLastUpd)
		Me.fraDetailInfo.Controls.Add(lblNatureLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspNatureLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspNatureLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblNatureCode)
		Me.fraDetailInfo.Controls.Add(lblNatureDesc)
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