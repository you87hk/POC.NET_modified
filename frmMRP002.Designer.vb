<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMRP002
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
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	Public WithEvents cboStaffNo As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents lblDspName As System.Windows.Forms.Label
	Public WithEvents lblStaffNo As System.Windows.Forms.Label
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents lblDspJobRef3 As System.Windows.Forms.Label
	Public WithEvents lblDspJobRef2 As System.Windows.Forms.Label
	Public WithEvents lblDspJobRef1 As System.Windows.Forms.Label
	Public WithEvents lblJobRef As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button13 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMRP002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.cboStaffNo = New System.Windows.Forms.ComboBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me.lblDspName = New System.Windows.Forms.Label
		Me.lblStaffNo = New System.Windows.Forms.Label
		Me.lblDspJobRef3 = New System.Windows.Forms.Label
		Me.lblDspJobRef2 = New System.Windows.Forms.Label
		Me.lblDspJobRef1 = New System.Windows.Forms.Label
		Me.lblJobRef = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button13 = New System.Windows.Forms.ToolStripButton
		Me.lblDspItmDesc = New System.Windows.Forms.Label
		Me.tabDetailInfo.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraSelect.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Stock Reserve"
		Me.ClientSize = New System.Drawing.Size(794, 575)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmMRP002.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMRP002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(624, 200)
		Me.tblCommon.TabIndex = 2
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(753, 361)
		Me.tblDetail.Location = New System.Drawing.Point(24, 176)
		Me.tblDetail.TabIndex = 13
		Me.tblDetail.Name = "tblDetail"
		Me.tabDetailInfo.Size = New System.Drawing.Size(785, 401)
		Me.tabDetailInfo.Location = New System.Drawing.Point(8, 144)
		Me.tabDetailInfo.TabIndex = 14
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "Tab 0"
		Me._tabDetailInfo_TabPage1.Text = "Tab 1"
		Me.cboStaffNo.Size = New System.Drawing.Size(121, 20)
		Me.cboStaffNo.Location = New System.Drawing.Point(624, 48)
		Me.cboStaffNo.TabIndex = 1
		Me.cboStaffNo.Text = "Combo1"
		Me.cboStaffNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStaffNo.BackColor = System.Drawing.SystemColors.Window
		Me.cboStaffNo.CausesValidation = True
		Me.cboStaffNo.Enabled = True
		Me.cboStaffNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboStaffNo.IntegralHeight = True
		Me.cboStaffNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboStaffNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboStaffNo.Sorted = False
		Me.cboStaffNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboStaffNo.TabStop = True
		Me.cboStaffNo.Visible = True
		Me.cboStaffNo.Name = "cboStaffNo"
		Me.cboDocNoFr.Size = New System.Drawing.Size(129, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(120, 40)
		Me.cboDocNoFr.TabIndex = 0
		Me.cboDocNoFr.Text = "Combo1"
		Me.cboDocNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNoFr.CausesValidation = True
		Me.cboDocNoFr.Enabled = True
		Me.cboDocNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNoFr.IntegralHeight = True
		Me.cboDocNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNoFr.Sorted = False
		Me.cboDocNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNoFr.TabStop = True
		Me.cboDocNoFr.Visible = True
		Me.cboDocNoFr.Name = "cboDocNoFr"
		Me.Frame1.Size = New System.Drawing.Size(785, 113)
		Me.Frame1.Location = New System.Drawing.Point(0, 24)
		Me.Frame1.TabIndex = 3
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.fraSelect.Size = New System.Drawing.Size(281, 99)
		Me.fraSelect.Location = New System.Drawing.Point(488, 8)
		Me.fraSelect.TabIndex = 7
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me.lblDspName.Size = New System.Drawing.Size(257, 20)
		Me.lblDspName.Location = New System.Drawing.Point(8, 40)
		Me.lblDspName.TabIndex = 15
		Me.lblDspName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspName.Enabled = True
		Me.lblDspName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspName.UseMnemonic = True
		Me.lblDspName.Visible = True
		Me.lblDspName.AutoSize = False
		Me.lblDspName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspName.Name = "lblDspName"
		Me.lblStaffNo.Text = "Customer Code From"
		Me.lblStaffNo.Size = New System.Drawing.Size(110, 15)
		Me.lblStaffNo.Location = New System.Drawing.Point(8, 16)
		Me.lblStaffNo.TabIndex = 8
		Me.lblStaffNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffNo.Enabled = True
		Me.lblStaffNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffNo.UseMnemonic = True
		Me.lblStaffNo.Visible = True
		Me.lblStaffNo.AutoSize = False
		Me.lblStaffNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffNo.Name = "lblStaffNo"
		Me.lblDspJobRef3.Size = New System.Drawing.Size(361, 20)
		Me.lblDspJobRef3.Location = New System.Drawing.Point(120, 88)
		Me.lblDspJobRef3.TabIndex = 12
		Me.lblDspJobRef3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspJobRef3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspJobRef3.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspJobRef3.Enabled = True
		Me.lblDspJobRef3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspJobRef3.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspJobRef3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspJobRef3.UseMnemonic = True
		Me.lblDspJobRef3.Visible = True
		Me.lblDspJobRef3.AutoSize = False
		Me.lblDspJobRef3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspJobRef3.Name = "lblDspJobRef3"
		Me.lblDspJobRef2.Size = New System.Drawing.Size(361, 20)
		Me.lblDspJobRef2.Location = New System.Drawing.Point(120, 64)
		Me.lblDspJobRef2.TabIndex = 11
		Me.lblDspJobRef2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspJobRef2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspJobRef2.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspJobRef2.Enabled = True
		Me.lblDspJobRef2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspJobRef2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspJobRef2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspJobRef2.UseMnemonic = True
		Me.lblDspJobRef2.Visible = True
		Me.lblDspJobRef2.AutoSize = False
		Me.lblDspJobRef2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspJobRef2.Name = "lblDspJobRef2"
		Me.lblDspJobRef1.Size = New System.Drawing.Size(361, 20)
		Me.lblDspJobRef1.Location = New System.Drawing.Point(120, 40)
		Me.lblDspJobRef1.TabIndex = 10
		Me.lblDspJobRef1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspJobRef1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspJobRef1.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspJobRef1.Enabled = True
		Me.lblDspJobRef1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspJobRef1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspJobRef1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspJobRef1.UseMnemonic = True
		Me.lblDspJobRef1.Visible = True
		Me.lblDspJobRef1.AutoSize = False
		Me.lblDspJobRef1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspJobRef1.Name = "lblDspJobRef1"
		Me.lblJobRef.Text = "CUSNAME"
		Me.lblJobRef.Size = New System.Drawing.Size(81, 17)
		Me.lblJobRef.Location = New System.Drawing.Point(8, 44)
		Me.lblJobRef.TabIndex = 9
		Me.lblJobRef.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobRef.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblJobRef.BackColor = System.Drawing.SystemColors.Control
		Me.lblJobRef.Enabled = True
		Me.lblJobRef.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblJobRef.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblJobRef.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblJobRef.UseMnemonic = True
		Me.lblJobRef.Visible = True
		Me.lblJobRef.AutoSize = False
		Me.lblJobRef.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblJobRef.Name = "lblJobRef"
		Me.lblDocNoFr.Text = "Document # From"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNoFr.Location = New System.Drawing.Point(8, 17)
		Me.lblDocNoFr.TabIndex = 4
		Me.lblDocNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNoFr.Enabled = True
		Me.lblDocNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNoFr.UseMnemonic = True
		Me.lblDocNoFr.Visible = True
		Me.lblDocNoFr.AutoSize = False
		Me.lblDocNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNoFr.Name = "lblDocNoFr"
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
		Me.iglProcess.Images.SetKeyName(12, "")
		Me.iglProcess.Images.SetKeyName(13, "")
		Me.iglProcess.Images.SetKeyName(14, "")
		Me.iglProcess.Images.SetKeyName(15, "")
		Me.iglProcess.Images.SetKeyName(16, "")
		Me.iglProcess.Images.SetKeyName(17, "")
		Me.iglProcess.Images.SetKeyName(18, "")
		Me.iglProcess.Images.SetKeyName(19, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 6
		Me.tbrProcess.ImageList = iglProcess
		Me.tbrProcess.Name = "tbrProcess"
		Me._tbrProcess_Button1.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button1.AutoSize = False
		Me._tbrProcess_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button1.ImageIndex = 4
		Me._tbrProcess_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button2.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button2.AutoSize = False
		Me._tbrProcess_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button2.Name = "Convert"
		Me._tbrProcess_Button2.ImageIndex = 14
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Visible = 0
		Me._tbrProcess_Button3.Name = "Pick"
		Me._tbrProcess_Button3.ImageIndex = 13
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Visible = 0
		Me._tbrProcess_Button4.Name = "Finish"
		Me._tbrProcess_Button4.ImageIndex = 19
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Cancel"
		Me._tbrProcess_Button6.ToolTipText = "取消 (F3)"
		Me._tbrProcess_Button6.ImageIndex = 4
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.Visible = 0
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Exit"
		Me._tbrProcess_Button8.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button8.ImageIndex = 8
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
		Me._tbrProcess_Button10.Name = "SAll"
		Me._tbrProcess_Button10.ImageIndex = 17
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Name = "DAll"
		Me._tbrProcess_Button11.ImageIndex = 18
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button13.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button13.AutoSize = False
		Me._tbrProcess_Button13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button13.Name = "Refresh"
		Me._tbrProcess_Button13.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button13.ImageIndex = 7
		Me._tbrProcess_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblDspItmDesc.Size = New System.Drawing.Size(777, 20)
		Me.lblDspItmDesc.Location = New System.Drawing.Point(8, 552)
		Me.lblDspItmDesc.TabIndex = 5
		Me.lblDspItmDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmDesc.Enabled = True
		Me.lblDspItmDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmDesc.UseMnemonic = True
		Me.lblDspItmDesc.Visible = True
		Me.lblDspItmDesc.AutoSize = False
		Me.lblDspItmDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmDesc.Name = "lblDspItmDesc"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tabDetailInfo)
		Me.Controls.Add(cboStaffNo)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspItmDesc)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.Frame1.Controls.Add(fraSelect)
		Me.Frame1.Controls.Add(lblDspJobRef3)
		Me.Frame1.Controls.Add(lblDspJobRef2)
		Me.Frame1.Controls.Add(lblDspJobRef1)
		Me.Frame1.Controls.Add(lblJobRef)
		Me.Frame1.Controls.Add(lblDocNoFr)
		Me.fraSelect.Controls.Add(lblDspName)
		Me.fraSelect.Controls.Add(lblStaffNo)
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
		Me.tbrProcess.Items.Add(_tbrProcess_Button13)
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabDetailInfo.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraSelect.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class