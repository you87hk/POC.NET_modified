<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSLM001
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
	Public WithEvents cboSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents _optSaleType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optSaleType_0 As System.Windows.Forms.RadioButton
	Public WithEvents FraSaleType As System.Windows.Forms.GroupBox
	Public WithEvents txtSaleCode As System.Windows.Forms.TextBox
	Public WithEvents txtSaleName As System.Windows.Forms.TextBox
	Public WithEvents lblDspSaleLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspSaleLastUpd As System.Windows.Forms.Label
	Public WithEvents lblSaleLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblSaleLastUpd As System.Windows.Forms.Label
	Public WithEvents lblSaleCode As System.Windows.Forms.Label
	Public WithEvents lblSaleName As System.Windows.Forms.Label
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
	Public WithEvents optSaleType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSLM001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboSaleCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.FraSaleType = New System.Windows.Forms.GroupBox
		Me._optSaleType_1 = New System.Windows.Forms.RadioButton
		Me._optSaleType_0 = New System.Windows.Forms.RadioButton
		Me.txtSaleCode = New System.Windows.Forms.TextBox
		Me.txtSaleName = New System.Windows.Forms.TextBox
		Me.lblDspSaleLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspSaleLastUpd = New System.Windows.Forms.Label
		Me.lblSaleLastUpdDate = New System.Windows.Forms.Label
		Me.lblSaleLastUpd = New System.Windows.Forms.Label
		Me.lblSaleCode = New System.Windows.Forms.Label
		Me.lblSaleName = New System.Windows.Forms.Label
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
		Me.optSaleType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.FraSaleType.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optSaleType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "營業員資料"
		Me.ClientSize = New System.Drawing.Size(572, 230)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmSLM001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSLM001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 10
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboSaleCode.Size = New System.Drawing.Size(182, 20)
		Me.cboSaleCode.Location = New System.Drawing.Point(120, 64)
		Me.cboSaleCode.TabIndex = 11
		Me.cboSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboSaleCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboSaleCode.CausesValidation = True
		Me.cboSaleCode.Enabled = True
		Me.cboSaleCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSaleCode.IntegralHeight = True
		Me.cboSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSaleCode.Sorted = False
		Me.cboSaleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboSaleCode.TabStop = True
		Me.cboSaleCode.Visible = True
		Me.cboSaleCode.Name = "cboSaleCode"
		Me.fraDetailInfo.Text = "營業員"
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
		Me.FraSaleType.Text = "MLTYPE"
		Me.FraSaleType.Size = New System.Drawing.Size(369, 57)
		Me.FraSaleType.Location = New System.Drawing.Point(8, 88)
		Me.FraSaleType.TabIndex = 12
		Me.FraSaleType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraSaleType.BackColor = System.Drawing.SystemColors.Control
		Me.FraSaleType.Enabled = True
		Me.FraSaleType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraSaleType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraSaleType.Visible = True
		Me.FraSaleType.Padding = New System.Windows.Forms.Padding(0)
		Me.FraSaleType.Name = "FraSaleType"
		Me._optSaleType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSaleType_1.Text = "PURCHASE"
		Me._optSaleType_1.Size = New System.Drawing.Size(105, 17)
		Me._optSaleType_1.Location = New System.Drawing.Point(192, 24)
		Me._optSaleType_1.TabIndex = 14
		Me._optSaleType_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSaleType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSaleType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optSaleType_1.CausesValidation = True
		Me._optSaleType_1.Enabled = True
		Me._optSaleType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSaleType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSaleType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSaleType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSaleType_1.TabStop = True
		Me._optSaleType_1.Checked = False
		Me._optSaleType_1.Visible = True
		Me._optSaleType_1.Name = "_optSaleType_1"
		Me._optSaleType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSaleType_0.Text = "SALES"
		Me._optSaleType_0.Size = New System.Drawing.Size(121, 17)
		Me._optSaleType_0.Location = New System.Drawing.Point(16, 24)
		Me._optSaleType_0.TabIndex = 13
		Me._optSaleType_0.Checked = True
		Me._optSaleType_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSaleType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSaleType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optSaleType_0.CausesValidation = True
		Me._optSaleType_0.Enabled = True
		Me._optSaleType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSaleType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSaleType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSaleType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSaleType_0.TabStop = True
		Me._optSaleType_0.Visible = True
		Me._optSaleType_0.Name = "_optSaleType_0"
		Me.txtSaleCode.AutoSize = False
		Me.txtSaleCode.Size = New System.Drawing.Size(182, 20)
		Me.txtSaleCode.Location = New System.Drawing.Point(112, 40)
		Me.txtSaleCode.TabIndex = 0
		Me.txtSaleCode.Tag = "K"
		Me.txtSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaleCode.AcceptsReturn = True
		Me.txtSaleCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSaleCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtSaleCode.CausesValidation = True
		Me.txtSaleCode.Enabled = True
		Me.txtSaleCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSaleCode.HideSelection = True
		Me.txtSaleCode.ReadOnly = False
		Me.txtSaleCode.Maxlength = 0
		Me.txtSaleCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSaleCode.MultiLine = False
		Me.txtSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSaleCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSaleCode.TabStop = True
		Me.txtSaleCode.Visible = True
		Me.txtSaleCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSaleCode.Name = "txtSaleCode"
		Me.txtSaleName.AutoSize = False
		Me.txtSaleName.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtSaleName.Enabled = False
		Me.txtSaleName.Size = New System.Drawing.Size(433, 20)
		Me.txtSaleName.Location = New System.Drawing.Point(112, 64)
		Me.txtSaleName.TabIndex = 1
		Me.txtSaleName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaleName.AcceptsReturn = True
		Me.txtSaleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSaleName.CausesValidation = True
		Me.txtSaleName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSaleName.HideSelection = True
		Me.txtSaleName.ReadOnly = False
		Me.txtSaleName.Maxlength = 0
		Me.txtSaleName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSaleName.MultiLine = False
		Me.txtSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSaleName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSaleName.TabStop = True
		Me.txtSaleName.Visible = True
		Me.txtSaleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSaleName.Name = "txtSaleName"
		Me.lblDspSaleLastUpdDate.Size = New System.Drawing.Size(119, 20)
		Me.lblDspSaleLastUpdDate.Location = New System.Drawing.Point(424, 160)
		Me.lblDspSaleLastUpdDate.TabIndex = 9
		Me.lblDspSaleLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspSaleLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspSaleLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspSaleLastUpdDate.Enabled = True
		Me.lblDspSaleLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspSaleLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspSaleLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspSaleLastUpdDate.UseMnemonic = True
		Me.lblDspSaleLastUpdDate.Visible = True
		Me.lblDspSaleLastUpdDate.AutoSize = False
		Me.lblDspSaleLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspSaleLastUpdDate.Name = "lblDspSaleLastUpdDate"
		Me.lblDspSaleLastUpd.Size = New System.Drawing.Size(119, 20)
		Me.lblDspSaleLastUpd.Location = New System.Drawing.Point(160, 160)
		Me.lblDspSaleLastUpd.TabIndex = 8
		Me.lblDspSaleLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspSaleLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspSaleLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspSaleLastUpd.Enabled = True
		Me.lblDspSaleLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspSaleLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspSaleLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspSaleLastUpd.UseMnemonic = True
		Me.lblDspSaleLastUpd.Visible = True
		Me.lblDspSaleLastUpd.AutoSize = False
		Me.lblDspSaleLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspSaleLastUpd.Name = "lblDspSaleLastUpd"
		Me.lblSaleLastUpdDate.Text = "最後修改日期 :"
		Me.lblSaleLastUpdDate.Size = New System.Drawing.Size(124, 16)
		Me.lblSaleLastUpdDate.Location = New System.Drawing.Point(288, 163)
		Me.lblSaleLastUpdDate.TabIndex = 7
		Me.lblSaleLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSaleLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSaleLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblSaleLastUpdDate.Enabled = True
		Me.lblSaleLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSaleLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSaleLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSaleLastUpdDate.UseMnemonic = True
		Me.lblSaleLastUpdDate.Visible = True
		Me.lblSaleLastUpdDate.AutoSize = False
		Me.lblSaleLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSaleLastUpdDate.Name = "lblSaleLastUpdDate"
		Me.lblSaleLastUpd.Text = "最後修改人 :"
		Me.lblSaleLastUpd.Size = New System.Drawing.Size(132, 16)
		Me.lblSaleLastUpd.Location = New System.Drawing.Point(24, 163)
		Me.lblSaleLastUpd.TabIndex = 6
		Me.lblSaleLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSaleLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSaleLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblSaleLastUpd.Enabled = True
		Me.lblSaleLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSaleLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSaleLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSaleLastUpd.UseMnemonic = True
		Me.lblSaleLastUpd.Visible = True
		Me.lblSaleLastUpd.AutoSize = False
		Me.lblSaleLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSaleLastUpd.Name = "lblSaleLastUpd"
		Me.lblSaleCode.Text = "編碼 :"
		Me.lblSaleCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblSaleCode.Size = New System.Drawing.Size(84, 16)
		Me.lblSaleCode.Location = New System.Drawing.Point(24, 44)
		Me.lblSaleCode.TabIndex = 4
		Me.lblSaleCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSaleCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblSaleCode.Enabled = True
		Me.lblSaleCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSaleCode.UseMnemonic = True
		Me.lblSaleCode.Visible = True
		Me.lblSaleCode.AutoSize = False
		Me.lblSaleCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSaleCode.Name = "lblSaleCode"
		Me.lblSaleName.Text = "姓名 :"
		Me.lblSaleName.Size = New System.Drawing.Size(92, 16)
		Me.lblSaleName.Location = New System.Drawing.Point(24, 68)
		Me.lblSaleName.TabIndex = 3
		Me.lblSaleName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSaleName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSaleName.BackColor = System.Drawing.SystemColors.Control
		Me.lblSaleName.Enabled = True
		Me.lblSaleName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSaleName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSaleName.UseMnemonic = True
		Me.lblSaleName.Visible = True
		Me.lblSaleName.AutoSize = False
		Me.lblSaleName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSaleName.Name = "lblSaleName"
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
		Me.tbrProcess.TabIndex = 5
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
		Me.Controls.Add(cboSaleCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(FraSaleType)
		Me.fraDetailInfo.Controls.Add(txtSaleCode)
		Me.fraDetailInfo.Controls.Add(txtSaleName)
		Me.fraDetailInfo.Controls.Add(lblDspSaleLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspSaleLastUpd)
		Me.fraDetailInfo.Controls.Add(lblSaleLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblSaleLastUpd)
		Me.fraDetailInfo.Controls.Add(lblSaleCode)
		Me.fraDetailInfo.Controls.Add(lblSaleName)
		Me.FraSaleType.Controls.Add(_optSaleType_1)
		Me.FraSaleType.Controls.Add(_optSaleType_0)
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
		Me.optSaleType.SetIndex(_optSaleType_1, CType(1, Short))
		Me.optSaleType.SetIndex(_optSaleType_0, CType(0, Short))
		CType(Me.optSaleType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.FraSaleType.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class