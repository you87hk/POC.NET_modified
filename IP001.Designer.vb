<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmIP001
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
	Public WithEvents _mnuCPopUpSub_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCPopUp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _mnuVPopUpSub_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuVPopUp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents cboITMCODE As System.Windows.Forms.ComboBox
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents tblCusItem As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
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
	Public WithEvents lblPrice As System.Windows.Forms.Label
	Public WithEvents lblDspPrice As System.Windows.Forms.Label
	Public WithEvents lblCurr As System.Windows.Forms.Label
	Public WithEvents lblDspCurr As System.Windows.Forms.Label
	Public WithEvents lblDspUOMCode As System.Windows.Forms.Label
	Public WithEvents lblDspItmName As System.Windows.Forms.Label
	Public WithEvents lblVdrItemChiName As System.Windows.Forms.Label
	Public WithEvents lblUOMCode As System.Windows.Forms.Label
	Public WithEvents lblItmCode As System.Windows.Forms.Label
	Public WithEvents mnuCPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents mnuVPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIP001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuCPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuCPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.mnuVPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuVPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.cboITMCODE = New System.Windows.Forms.ComboBox
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.tblCusItem = New AxTrueDBGrid60.AxTDBGrid
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
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
		Me.lblPrice = New System.Windows.Forms.Label
		Me.lblDspPrice = New System.Windows.Forms.Label
		Me.lblCurr = New System.Windows.Forms.Label
		Me.lblDspCurr = New System.Windows.Forms.Label
		Me.lblDspUOMCode = New System.Windows.Forms.Label
		Me.lblDspItmName = New System.Windows.Forms.Label
		Me.lblVdrItemChiName = New System.Windows.Forms.Label
		Me.lblUOMCode = New System.Windows.Forms.Label
		Me.lblItmCode = New System.Windows.Forms.Label
		Me.mnuCPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.mnuVPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblCusItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuCPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuVPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "書本對換價"
		Me.ClientSize = New System.Drawing.Size(653, 465)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmIP001.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
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
		Me.Name = "frmIP001"
		Me.mnuCPopUp.Name = "mnuCPopUp"
		Me.mnuCPopUp.Text = "Pop Up"
		Me.mnuCPopUp.Visible = False
		Me.mnuCPopUp.Checked = False
		Me.mnuCPopUp.Enabled = True
		Me._mnuCPopUpSub_0.Name = "_mnuCPopUpSub_0"
		Me._mnuCPopUpSub_0.Text = ""
		Me._mnuCPopUpSub_0.Checked = False
		Me._mnuCPopUpSub_0.Enabled = True
		Me._mnuCPopUpSub_0.Visible = True
		Me.mnuVPopUp.Name = "mnuVPopUp"
		Me.mnuVPopUp.Text = "PoP Up"
		Me.mnuVPopUp.Visible = False
		Me.mnuVPopUp.Checked = False
		Me.mnuVPopUp.Enabled = True
		Me._mnuVPopUpSub_0.Name = "_mnuVPopUpSub_0"
		Me._mnuVPopUpSub_0.Text = ""
		Me._mnuVPopUpSub_0.Checked = False
		Me._mnuVPopUpSub_0.Enabled = True
		Me._mnuVPopUpSub_0.Visible = True
		Me.cboITMCODE.Size = New System.Drawing.Size(233, 20)
		Me.cboITMCODE.Location = New System.Drawing.Point(112, 56)
		Me.cboITMCODE.TabIndex = 5
		Me.cboITMCODE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboITMCODE.BackColor = System.Drawing.SystemColors.Window
		Me.cboITMCODE.CausesValidation = True
		Me.cboITMCODE.Enabled = True
		Me.cboITMCODE.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboITMCODE.IntegralHeight = True
		Me.cboITMCODE.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboITMCODE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboITMCODE.Sorted = False
		Me.cboITMCODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboITMCODE.TabStop = True
		Me.cboITMCODE.Visible = True
		Me.cboITMCODE.Name = "cboITMCODE"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(656, 40)
		Me.tblCommon.TabIndex = 2
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
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
		Me.tabDetailInfo.Size = New System.Drawing.Size(649, 329)
		Me.tabDetailInfo.Location = New System.Drawing.Point(0, 128)
		Me.tabDetailInfo.TabIndex = 4
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "Customer Pricing"
		tblCusItem.OcxState = CType(resources.GetObject("tblCusItem.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCusItem.Size = New System.Drawing.Size(633, 289)
		Me.tblCusItem.Location = New System.Drawing.Point(8, 8)
		Me.tblCusItem.TabIndex = 6
		Me.tblCusItem.Name = "tblCusItem"
		Me._tabDetailInfo_TabPage1.Text = "Vendor Pricing"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(633, 289)
		Me.tblDetail.Location = New System.Drawing.Point(8, 8)
		Me.tblDetail.TabIndex = 7
		Me.tblDetail.Name = "tblDetail"
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(653, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 24)
		Me.tbrProcess.TabIndex = 10
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
		Me._tbrProcess_Button2.ToolTipText = "Open (F6)"
		Me._tbrProcess_Button2.ImageIndex = 11
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Visible = 0
		Me._tbrProcess_Button3.Name = "Add"
		Me._tbrProcess_Button3.ToolTipText = "Add (F2)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Visible = 0
		Me._tbrProcess_Button4.Name = "Edit"
		Me._tbrProcess_Button4.ToolTipText = "Edit (F5)"
		Me._tbrProcess_Button4.ImageIndex = 1
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Visible = 0
		Me._tbrProcess_Button5.Name = "Delete"
		Me._tbrProcess_Button5.ToolTipText = "Delete (F3)"
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
		Me._tbrProcess_Button7.ToolTipText = "Save (F10)"
		Me._tbrProcess_Button7.ImageIndex = 3
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Cancel"
		Me._tbrProcess_Button8.ToolTipText = "Cancel (F11)"
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
		Me._tbrProcess_Button10.ToolTipText = "Find (F9)"
		Me._tbrProcess_Button10.ImageIndex = 6
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Visible = 0
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "Exit"
		Me._tbrProcess_Button12.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button12.ImageIndex = 8
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblPrice.Text = "UOMCODE"
		Me.lblPrice.Size = New System.Drawing.Size(73, 17)
		Me.lblPrice.Location = New System.Drawing.Point(192, 80)
		Me.lblPrice.TabIndex = 14
		Me.lblPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrice.Enabled = True
		Me.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrice.UseMnemonic = True
		Me.lblPrice.Visible = True
		Me.lblPrice.AutoSize = False
		Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrice.Name = "lblPrice"
		Me.lblDspPrice.Size = New System.Drawing.Size(73, 20)
		Me.lblDspPrice.Location = New System.Drawing.Point(272, 80)
		Me.lblDspPrice.TabIndex = 13
		Me.lblDspPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPrice.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPrice.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPrice.Enabled = True
		Me.lblDspPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPrice.UseMnemonic = True
		Me.lblDspPrice.Visible = True
		Me.lblDspPrice.AutoSize = False
		Me.lblDspPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPrice.Name = "lblDspPrice"
		Me.lblCurr.Text = "UOMCODE"
		Me.lblCurr.Size = New System.Drawing.Size(105, 17)
		Me.lblCurr.Location = New System.Drawing.Point(8, 80)
		Me.lblCurr.TabIndex = 12
		Me.lblCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCurr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCurr.Enabled = True
		Me.lblCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCurr.UseMnemonic = True
		Me.lblCurr.Visible = True
		Me.lblCurr.AutoSize = False
		Me.lblCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCurr.Name = "lblCurr"
		Me.lblDspCurr.Size = New System.Drawing.Size(73, 20)
		Me.lblDspCurr.Location = New System.Drawing.Point(112, 80)
		Me.lblDspCurr.TabIndex = 11
		Me.lblDspCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCurr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCurr.Enabled = True
		Me.lblDspCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCurr.UseMnemonic = True
		Me.lblDspCurr.Visible = True
		Me.lblDspCurr.AutoSize = False
		Me.lblDspCurr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCurr.Name = "lblDspCurr"
		Me.lblDspUOMCode.Size = New System.Drawing.Size(57, 20)
		Me.lblDspUOMCode.Location = New System.Drawing.Point(424, 80)
		Me.lblDspUOMCode.TabIndex = 9
		Me.lblDspUOMCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspUOMCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspUOMCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspUOMCode.Enabled = True
		Me.lblDspUOMCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspUOMCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspUOMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspUOMCode.UseMnemonic = True
		Me.lblDspUOMCode.Visible = True
		Me.lblDspUOMCode.AutoSize = False
		Me.lblDspUOMCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspUOMCode.Name = "lblDspUOMCode"
		Me.lblDspItmName.Size = New System.Drawing.Size(537, 20)
		Me.lblDspItmName.Location = New System.Drawing.Point(112, 104)
		Me.lblDspItmName.TabIndex = 8
		Me.lblDspItmName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmName.Enabled = True
		Me.lblDspItmName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmName.UseMnemonic = True
		Me.lblDspItmName.Visible = True
		Me.lblDspItmName.AutoSize = False
		Me.lblDspItmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmName.Name = "lblDspItmName"
		Me.lblVdrItemChiName.Text = "VDRITEMCHINAME"
		Me.lblVdrItemChiName.Size = New System.Drawing.Size(97, 17)
		Me.lblVdrItemChiName.Location = New System.Drawing.Point(8, 108)
		Me.lblVdrItemChiName.TabIndex = 3
		Me.lblVdrItemChiName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrItemChiName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrItemChiName.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrItemChiName.Enabled = True
		Me.lblVdrItemChiName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrItemChiName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrItemChiName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrItemChiName.UseMnemonic = True
		Me.lblVdrItemChiName.Visible = True
		Me.lblVdrItemChiName.AutoSize = False
		Me.lblVdrItemChiName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrItemChiName.Name = "lblVdrItemChiName"
		Me.lblUOMCode.Text = "UOMCODE"
		Me.lblUOMCode.Size = New System.Drawing.Size(65, 17)
		Me.lblUOMCode.Location = New System.Drawing.Point(352, 84)
		Me.lblUOMCode.TabIndex = 1
		Me.lblUOMCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.lblItmCode.Text = "ITMCODE"
		Me.lblItmCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblItmCode.Size = New System.Drawing.Size(97, 17)
		Me.lblItmCode.Location = New System.Drawing.Point(8, 60)
		Me.lblItmCode.TabIndex = 0
		Me.lblItmCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCode.Enabled = True
		Me.lblItmCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCode.UseMnemonic = True
		Me.lblItmCode.Visible = True
		Me.lblItmCode.AutoSize = False
		Me.lblItmCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCode.Name = "lblItmCode"
		Me.Controls.Add(cboITMCODE)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(tabDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblPrice)
		Me.Controls.Add(lblDspPrice)
		Me.Controls.Add(lblCurr)
		Me.Controls.Add(lblDspCurr)
		Me.Controls.Add(lblDspUOMCode)
		Me.Controls.Add(lblDspItmName)
		Me.Controls.Add(lblVdrItemChiName)
		Me.Controls.Add(lblUOMCode)
		Me.Controls.Add(lblItmCode)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me._tabDetailInfo_TabPage0.Controls.Add(tblCusItem)
		Me._tabDetailInfo_TabPage1.Controls.Add(tblDetail)
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
		Me.mnuCPopUpSub.SetIndex(_mnuCPopUpSub_0, CType(0, Short))
		Me.mnuVPopUpSub.SetIndex(_mnuVPopUpSub_0, CType(0, Short))
		CType(Me.mnuVPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mnuCPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCusItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuCPopUp, Me.mnuVPopUp})
		mnuCPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuCPopUpSub_0})
		mnuVPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuVPopUpSub_0})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class