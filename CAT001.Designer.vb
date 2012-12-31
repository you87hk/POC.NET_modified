<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCAT001
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
	Public WithEvents cboCatCode As System.Windows.Forms.ComboBox
	Public WithEvents txtCatCode As System.Windows.Forms.TextBox
	Public WithEvents txtCatDesc As System.Windows.Forms.TextBox
	Public WithEvents lblCatLastUpd As System.Windows.Forms.Label
	Public WithEvents lblCatLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspCatLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspCatLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblCatCode As System.Windows.Forms.Label
	Public WithEvents lblCatDesc As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCAT001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboCatCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtCatCode = New System.Windows.Forms.TextBox
		Me.txtCatDesc = New System.Windows.Forms.TextBox
		Me.lblCatLastUpd = New System.Windows.Forms.Label
		Me.lblCatLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspCatLastUpd = New System.Windows.Forms.Label
		Me.lblDspCatLastUpdDate = New System.Windows.Forms.Label
		Me.lblCatCode = New System.Windows.Forms.Label
		Me.lblCatDesc = New System.Windows.Forms.Label
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
		Me.Text = "杜威分類資料"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmCAT001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmCAT001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboCatCode.Size = New System.Drawing.Size(182, 20)
		Me.cboCatCode.Location = New System.Drawing.Point(120, 64)
		Me.cboCatCode.TabIndex = 11
		Me.cboCatCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCatCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCatCode.CausesValidation = True
		Me.cboCatCode.Enabled = True
		Me.cboCatCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCatCode.IntegralHeight = True
		Me.cboCatCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCatCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCatCode.Sorted = False
		Me.cboCatCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCatCode.TabStop = True
		Me.cboCatCode.Visible = True
		Me.cboCatCode.Name = "cboCatCode"
		Me.fraDetailInfo.Text = "杜威分類資料"
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
		Me.txtCatCode.AutoSize = False
		Me.txtCatCode.Size = New System.Drawing.Size(182, 20)
		Me.txtCatCode.Location = New System.Drawing.Point(112, 40)
		Me.txtCatCode.TabIndex = 0
		Me.txtCatCode.Tag = "K"
		Me.txtCatCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCatCode.AcceptsReturn = True
		Me.txtCatCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCatCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtCatCode.CausesValidation = True
		Me.txtCatCode.Enabled = True
		Me.txtCatCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCatCode.HideSelection = True
		Me.txtCatCode.ReadOnly = False
		Me.txtCatCode.Maxlength = 0
		Me.txtCatCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCatCode.MultiLine = False
		Me.txtCatCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCatCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCatCode.TabStop = True
		Me.txtCatCode.Visible = True
		Me.txtCatCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCatCode.Name = "txtCatCode"
		Me.txtCatDesc.AutoSize = False
		Me.txtCatDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCatDesc.Enabled = False
		Me.txtCatDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtCatDesc.Location = New System.Drawing.Point(112, 64)
		Me.txtCatDesc.TabIndex = 1
		Me.txtCatDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCatDesc.AcceptsReturn = True
		Me.txtCatDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCatDesc.CausesValidation = True
		Me.txtCatDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCatDesc.HideSelection = True
		Me.txtCatDesc.ReadOnly = False
		Me.txtCatDesc.Maxlength = 0
		Me.txtCatDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCatDesc.MultiLine = False
		Me.txtCatDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCatDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCatDesc.TabStop = True
		Me.txtCatDesc.Visible = True
		Me.txtCatDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCatDesc.Name = "txtCatDesc"
		Me.lblCatLastUpd.Text = "最後修改人 :"
		Me.lblCatLastUpd.Size = New System.Drawing.Size(76, 16)
		Me.lblCatLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblCatLastUpd.TabIndex = 8
		Me.lblCatLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCatLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCatLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCatLastUpd.Enabled = True
		Me.lblCatLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCatLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCatLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCatLastUpd.UseMnemonic = True
		Me.lblCatLastUpd.Visible = True
		Me.lblCatLastUpd.AutoSize = False
		Me.lblCatLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCatLastUpd.Name = "lblCatLastUpd"
		Me.lblCatLastUpdDate.Text = "最後修改日期 :"
		Me.lblCatLastUpdDate.Size = New System.Drawing.Size(84, 16)
		Me.lblCatLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblCatLastUpdDate.TabIndex = 7
		Me.lblCatLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCatLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCatLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblCatLastUpdDate.Enabled = True
		Me.lblCatLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCatLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCatLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCatLastUpdDate.UseMnemonic = True
		Me.lblCatLastUpdDate.Visible = True
		Me.lblCatLastUpdDate.AutoSize = False
		Me.lblCatLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCatLastUpdDate.Name = "lblCatLastUpdDate"
		Me.lblDspCatLastUpd.Size = New System.Drawing.Size(167, 20)
		Me.lblDspCatLastUpd.Location = New System.Drawing.Point(112, 160)
		Me.lblDspCatLastUpd.TabIndex = 6
		Me.lblDspCatLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCatLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCatLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCatLastUpd.Enabled = True
		Me.lblDspCatLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCatLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCatLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCatLastUpd.UseMnemonic = True
		Me.lblDspCatLastUpd.Visible = True
		Me.lblDspCatLastUpd.AutoSize = False
		Me.lblDspCatLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCatLastUpd.Name = "lblDspCatLastUpd"
		Me.lblDspCatLastUpdDate.Size = New System.Drawing.Size(167, 20)
		Me.lblDspCatLastUpdDate.Location = New System.Drawing.Point(376, 160)
		Me.lblDspCatLastUpdDate.TabIndex = 5
		Me.lblDspCatLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCatLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCatLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCatLastUpdDate.Enabled = True
		Me.lblDspCatLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCatLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCatLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCatLastUpdDate.UseMnemonic = True
		Me.lblDspCatLastUpdDate.Visible = True
		Me.lblDspCatLastUpdDate.AutoSize = False
		Me.lblDspCatLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCatLastUpdDate.Name = "lblDspCatLastUpdDate"
		Me.lblCatCode.Text = "杜威分類編碼 :"
		Me.lblCatCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblCatCode.Size = New System.Drawing.Size(84, 16)
		Me.lblCatCode.Location = New System.Drawing.Point(24, 44)
		Me.lblCatCode.TabIndex = 4
		Me.lblCatCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCatCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCatCode.Enabled = True
		Me.lblCatCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCatCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCatCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCatCode.UseMnemonic = True
		Me.lblCatCode.Visible = True
		Me.lblCatCode.AutoSize = False
		Me.lblCatCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCatCode.Name = "lblCatCode"
		Me.lblCatDesc.Text = "註解 :"
		Me.lblCatDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblCatDesc.Location = New System.Drawing.Point(24, 68)
		Me.lblCatDesc.TabIndex = 3
		Me.lblCatDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCatDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCatDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblCatDesc.Enabled = True
		Me.lblCatDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCatDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCatDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCatDesc.UseMnemonic = True
		Me.lblCatDesc.Visible = True
		Me.lblCatDesc.AutoSize = False
		Me.lblCatDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCatDesc.Name = "lblCatDesc"
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
		Me.Controls.Add(cboCatCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtCatCode)
		Me.fraDetailInfo.Controls.Add(txtCatDesc)
		Me.fraDetailInfo.Controls.Add(lblCatLastUpd)
		Me.fraDetailInfo.Controls.Add(lblCatLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspCatLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspCatLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblCatCode)
		Me.fraDetailInfo.Controls.Add(lblCatDesc)
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