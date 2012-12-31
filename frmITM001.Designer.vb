<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmITM001
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
	Public WithEvents _mnuPopUpSub_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPopUp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboItemClassCode As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCode As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents txtItmEngName As System.Windows.Forms.TextBox
	Public WithEvents txtItmChiName As System.Windows.Forms.TextBox
	Public WithEvents txtItmCode As System.Windows.Forms.TextBox
	Public WithEvents lblDspItemClassCode As System.Windows.Forms.Label
	Public WithEvents lblItemClassCode As System.Windows.Forms.Label
	Public WithEvents lblItmEngName As System.Windows.Forms.Label
	Public WithEvents lblItmChiName As System.Windows.Forms.Label
	Public WithEvents lblItmCode As System.Windows.Forms.Label
	Public WithEvents fraHeaderInfo As System.Windows.Forms.GroupBox
	Public cdlgDirOpen As System.Windows.Forms.OpenFileDialog
	Public cdlgDirSave As System.Windows.Forms.SaveFileDialog
	Public cdlgDirFont As System.Windows.Forms.FontDialog
	Public cdlgDirColor As System.Windows.Forms.ColorDialog
	Public cdlgDirPrint As System.Windows.Forms.PrintDialog
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
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button13 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button14 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents txtItmBarCode As System.Windows.Forms.TextBox
	Public WithEvents txtItmBinNo As System.Windows.Forms.TextBox
	Public WithEvents txtItmSeriesNo As System.Windows.Forms.TextBox
	Public WithEvents lblDspItmUomDesc As System.Windows.Forms.Label
	Public WithEvents lblItmBarCode As System.Windows.Forms.Label
	Public WithEvents lblItmBinNo As System.Windows.Forms.Label
	Public WithEvents lblItmUomCode As System.Windows.Forms.Label
	Public WithEvents lblDspItmAccTypeDesc As System.Windows.Forms.Label
	Public WithEvents lblItmSeriesNo As System.Windows.Forms.Label
	Public WithEvents lblDspItmTypeDesc As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCode As System.Windows.Forms.Label
	Public WithEvents lblItmAccTypeCode As System.Windows.Forms.Label
	Public WithEvents fraInfo As System.Windows.Forms.GroupBox
	Public WithEvents txtItmUnitPrice As System.Windows.Forms.TextBox
	Public WithEvents txtItmDefaultPrice As System.Windows.Forms.TextBox
	Public WithEvents txtItmDiscount As System.Windows.Forms.TextBox
	Public WithEvents txtItmMarkUp As System.Windows.Forms.TextBox
	Public WithEvents txtItmBottomPrice As System.Windows.Forms.TextBox
	Public WithEvents btnItemPrice As System.Windows.Forms.Button
	Public WithEvents lblItmDefaultPrice As System.Windows.Forms.Label
	Public WithEvents lblItmDiscount As System.Windows.Forms.Label
	Public WithEvents lblItmPVdrCode As System.Windows.Forms.Label
	Public WithEvents lblItmMarkUp As System.Windows.Forms.Label
	Public WithEvents lblUnitPrice As System.Windows.Forms.Label
	Public WithEvents lblItmCurrCode As System.Windows.Forms.Label
	Public WithEvents lblItmBottomPrice As System.Windows.Forms.Label
	Public WithEvents fraPrice As System.Windows.Forms.GroupBox
	Public WithEvents cboItmAccTypeCode As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCurr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmUOMCode As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCode As System.Windows.Forms.ComboBox
	Public WithEvents cboItmPVdrCode As System.Windows.Forms.ComboBox
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents txtItmMaxQty As System.Windows.Forms.TextBox
	Public WithEvents txtItmPORepuQty As System.Windows.Forms.TextBox
	Public WithEvents chkItmReorderInd As System.Windows.Forms.CheckBox
	Public WithEvents chkItmInvItemFlg As System.Windows.Forms.CheckBox
	Public WithEvents chkItmInActive As System.Windows.Forms.CheckBox
	Public WithEvents txtItmReorderQty As System.Windows.Forms.TextBox
	Public WithEvents lblDspStkOnHand As System.Windows.Forms.Label
	Public WithEvents lblStkOnHand As System.Windows.Forms.Label
	Public WithEvents lblDspStkIndent As System.Windows.Forms.Label
	Public WithEvents lblStkIndent As System.Windows.Forms.Label
	Public WithEvents lblDspStkOnOrder As System.Windows.Forms.Label
	Public WithEvents lblStkOnOrder As System.Windows.Forms.Label
	Public WithEvents lblDspStkAllocated As System.Windows.Forms.Label
	Public WithEvents lblStkAllocated As System.Windows.Forms.Label
	Public WithEvents lblDspStkAvailable As System.Windows.Forms.Label
	Public WithEvents lblStkAvailable As System.Windows.Forms.Label
	Public WithEvents lblItmMaxQty As System.Windows.Forms.Label
	Public WithEvents lblItmPORepuQty As System.Windows.Forms.Label
	Public WithEvents lblItmReorderQty As System.Windows.Forms.Label
	Public WithEvents fraContent As System.Windows.Forms.GroupBox
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents lblKeyDesc As System.Windows.Forms.Label
	Public WithEvents lblComboPrompt As System.Windows.Forms.Label
	Public WithEvents lblInsertLine As System.Windows.Forms.Label
	Public WithEvents lblDeleteLine As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents chkOwnEdition As System.Windows.Forms.CheckBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tabDetailInfo_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	Public WithEvents lblItmLastUpd As System.Windows.Forms.Label
	Public WithEvents lblItmLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspItmLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspItmLastUpdDate As System.Windows.Forms.Label
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmITM001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItemClassCode = New System.Windows.Forms.ComboBox
		Me.cboItmCode = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.fraHeaderInfo = New System.Windows.Forms.GroupBox
		Me.txtItmEngName = New System.Windows.Forms.TextBox
		Me.txtItmChiName = New System.Windows.Forms.TextBox
		Me.txtItmCode = New System.Windows.Forms.TextBox
		Me.lblDspItemClassCode = New System.Windows.Forms.Label
		Me.lblItemClassCode = New System.Windows.Forms.Label
		Me.lblItmEngName = New System.Windows.Forms.Label
		Me.lblItmChiName = New System.Windows.Forms.Label
		Me.lblItmCode = New System.Windows.Forms.Label
		Me.cdlgDirOpen = New System.Windows.Forms.OpenFileDialog
		Me.cdlgDirSave = New System.Windows.Forms.SaveFileDialog
		Me.cdlgDirFont = New System.Windows.Forms.FontDialog
		Me.cdlgDirColor = New System.Windows.Forms.ColorDialog
		Me.cdlgDirPrint = New System.Windows.Forms.PrintDialog
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
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button13 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button14 = New System.Windows.Forms.ToolStripButton
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.fraInfo = New System.Windows.Forms.GroupBox
		Me.txtItmBarCode = New System.Windows.Forms.TextBox
		Me.txtItmBinNo = New System.Windows.Forms.TextBox
		Me.txtItmSeriesNo = New System.Windows.Forms.TextBox
		Me.lblDspItmUomDesc = New System.Windows.Forms.Label
		Me.lblItmBarCode = New System.Windows.Forms.Label
		Me.lblItmBinNo = New System.Windows.Forms.Label
		Me.lblItmUomCode = New System.Windows.Forms.Label
		Me.lblDspItmAccTypeDesc = New System.Windows.Forms.Label
		Me.lblItmSeriesNo = New System.Windows.Forms.Label
		Me.lblDspItmTypeDesc = New System.Windows.Forms.Label
		Me.lblItmTypeCode = New System.Windows.Forms.Label
		Me.lblItmAccTypeCode = New System.Windows.Forms.Label
		Me.fraPrice = New System.Windows.Forms.GroupBox
		Me.txtItmUnitPrice = New System.Windows.Forms.TextBox
		Me.txtItmDefaultPrice = New System.Windows.Forms.TextBox
		Me.txtItmDiscount = New System.Windows.Forms.TextBox
		Me.txtItmMarkUp = New System.Windows.Forms.TextBox
		Me.txtItmBottomPrice = New System.Windows.Forms.TextBox
		Me.btnItemPrice = New System.Windows.Forms.Button
		Me.lblItmDefaultPrice = New System.Windows.Forms.Label
		Me.lblItmDiscount = New System.Windows.Forms.Label
		Me.lblItmPVdrCode = New System.Windows.Forms.Label
		Me.lblItmMarkUp = New System.Windows.Forms.Label
		Me.lblUnitPrice = New System.Windows.Forms.Label
		Me.lblItmCurrCode = New System.Windows.Forms.Label
		Me.lblItmBottomPrice = New System.Windows.Forms.Label
		Me.cboItmAccTypeCode = New System.Windows.Forms.ComboBox
		Me.cboItmCurr = New System.Windows.Forms.ComboBox
		Me.cboItmUOMCode = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCode = New System.Windows.Forms.ComboBox
		Me.cboItmPVdrCode = New System.Windows.Forms.ComboBox
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.fraContent = New System.Windows.Forms.GroupBox
		Me.txtItmMaxQty = New System.Windows.Forms.TextBox
		Me.txtItmPORepuQty = New System.Windows.Forms.TextBox
		Me.chkItmReorderInd = New System.Windows.Forms.CheckBox
		Me.chkItmInvItemFlg = New System.Windows.Forms.CheckBox
		Me.chkItmInActive = New System.Windows.Forms.CheckBox
		Me.txtItmReorderQty = New System.Windows.Forms.TextBox
		Me.lblDspStkOnHand = New System.Windows.Forms.Label
		Me.lblStkOnHand = New System.Windows.Forms.Label
		Me.lblDspStkIndent = New System.Windows.Forms.Label
		Me.lblStkIndent = New System.Windows.Forms.Label
		Me.lblDspStkOnOrder = New System.Windows.Forms.Label
		Me.lblStkOnOrder = New System.Windows.Forms.Label
		Me.lblDspStkAllocated = New System.Windows.Forms.Label
		Me.lblStkAllocated = New System.Windows.Forms.Label
		Me.lblDspStkAvailable = New System.Windows.Forms.Label
		Me.lblStkAvailable = New System.Windows.Forms.Label
		Me.lblItmMaxQty = New System.Windows.Forms.Label
		Me.lblItmPORepuQty = New System.Windows.Forms.Label
		Me.lblItmReorderQty = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage2 = New System.Windows.Forms.TabPage
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.lblKeyDesc = New System.Windows.Forms.Label
		Me.lblComboPrompt = New System.Windows.Forms.Label
		Me.lblInsertLine = New System.Windows.Forms.Label
		Me.lblDeleteLine = New System.Windows.Forms.Label
		Me.chkOwnEdition = New System.Windows.Forms.CheckBox
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.lblItmLastUpd = New System.Windows.Forms.Label
		Me.lblItmLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspItmLastUpd = New System.Windows.Forms.Label
		Me.lblDspItmLastUpdDate = New System.Windows.Forms.Label
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.fraHeaderInfo.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me.fraInfo.SuspendLayout()
		Me.fraPrice.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.fraContent.SuspendLayout()
		Me._tabDetailInfo_TabPage2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "ITEM"
		Me.ClientSize = New System.Drawing.Size(725, 497)
		Me.Location = New System.Drawing.Point(11, 30)
		Me.Icon = CType(resources.GetObject("frmITM001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmITM001"
		Me.mnuPopUp.Name = "mnuPopUp"
		Me.mnuPopUp.Text = "Pop Up"
		Me.mnuPopUp.Visible = False
		Me.mnuPopUp.Checked = False
		Me.mnuPopUp.Enabled = True
		Me._mnuPopUpSub_0.Name = "_mnuPopUpSub_0"
		Me._mnuPopUpSub_0.Text = ""
		Me._mnuPopUpSub_0.Checked = False
		Me._mnuPopUpSub_0.Enabled = True
		Me._mnuPopUpSub_0.Visible = True
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(720, 56)
		Me.tblCommon.TabIndex = 25
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItemClassCode.Size = New System.Drawing.Size(95, 20)
		Me.cboItemClassCode.Location = New System.Drawing.Point(368, 64)
		Me.cboItemClassCode.TabIndex = 2
		Me.cboItemClassCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItemClassCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItemClassCode.CausesValidation = True
		Me.cboItemClassCode.Enabled = True
		Me.cboItemClassCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItemClassCode.IntegralHeight = True
		Me.cboItemClassCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItemClassCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItemClassCode.Sorted = False
		Me.cboItemClassCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItemClassCode.TabStop = True
		Me.cboItemClassCode.Visible = True
		Me.cboItemClassCode.Name = "cboItemClassCode"
		Me.cboItmCode.Enabled = False
		Me.cboItmCode.Size = New System.Drawing.Size(174, 20)
		Me.cboItmCode.Location = New System.Drawing.Point(112, 64)
		Me.cboItmCode.TabIndex = 1
		Me.cboItmCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCode.CausesValidation = True
		Me.cboItmCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCode.IntegralHeight = True
		Me.cboItmCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCode.Sorted = False
		Me.cboItmCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCode.TabStop = True
		Me.cboItmCode.Visible = True
		Me.cboItmCode.Name = "cboItmCode"
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
		Me.fraHeaderInfo.Text = "HEADERINFO"
		Me.fraHeaderInfo.Size = New System.Drawing.Size(713, 105)
		Me.fraHeaderInfo.Location = New System.Drawing.Point(8, 48)
		Me.fraHeaderInfo.TabIndex = 26
		Me.fraHeaderInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraHeaderInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraHeaderInfo.Enabled = True
		Me.fraHeaderInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraHeaderInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraHeaderInfo.Visible = True
		Me.fraHeaderInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraHeaderInfo.Name = "fraHeaderInfo"
		Me.txtItmEngName.AutoSize = False
		Me.txtItmEngName.Enabled = False
		Me.txtItmEngName.Size = New System.Drawing.Size(601, 20)
		Me.txtItmEngName.Location = New System.Drawing.Point(104, 64)
		Me.txtItmEngName.TabIndex = 4
		Me.txtItmEngName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmEngName.AcceptsReturn = True
		Me.txtItmEngName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmEngName.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmEngName.CausesValidation = True
		Me.txtItmEngName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmEngName.HideSelection = True
		Me.txtItmEngName.ReadOnly = False
		Me.txtItmEngName.Maxlength = 0
		Me.txtItmEngName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmEngName.MultiLine = False
		Me.txtItmEngName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmEngName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmEngName.TabStop = True
		Me.txtItmEngName.Visible = True
		Me.txtItmEngName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmEngName.Name = "txtItmEngName"
		Me.txtItmChiName.AutoSize = False
		Me.txtItmChiName.Enabled = False
		Me.txtItmChiName.Size = New System.Drawing.Size(601, 20)
		Me.txtItmChiName.Location = New System.Drawing.Point(104, 40)
		Me.txtItmChiName.TabIndex = 3
		Me.txtItmChiName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmChiName.AcceptsReturn = True
		Me.txtItmChiName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmChiName.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmChiName.CausesValidation = True
		Me.txtItmChiName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmChiName.HideSelection = True
		Me.txtItmChiName.ReadOnly = False
		Me.txtItmChiName.Maxlength = 0
		Me.txtItmChiName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmChiName.MultiLine = False
		Me.txtItmChiName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmChiName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmChiName.TabStop = True
		Me.txtItmChiName.Visible = True
		Me.txtItmChiName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmChiName.Name = "txtItmChiName"
		Me.txtItmCode.AutoSize = False
		Me.txtItmCode.Size = New System.Drawing.Size(174, 20)
		Me.txtItmCode.Location = New System.Drawing.Point(104, 16)
		Me.txtItmCode.TabIndex = 0
		Me.txtItmCode.Tag = "K"
		Me.txtItmCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmCode.AcceptsReturn = True
		Me.txtItmCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmCode.CausesValidation = True
		Me.txtItmCode.Enabled = True
		Me.txtItmCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmCode.HideSelection = True
		Me.txtItmCode.ReadOnly = False
		Me.txtItmCode.Maxlength = 0
		Me.txtItmCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmCode.MultiLine = False
		Me.txtItmCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmCode.TabStop = True
		Me.txtItmCode.Visible = True
		Me.txtItmCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmCode.Name = "txtItmCode"
		Me.lblDspItemClassCode.Size = New System.Drawing.Size(247, 20)
		Me.lblDspItemClassCode.Location = New System.Drawing.Point(459, 16)
		Me.lblDspItemClassCode.TabIndex = 41
		Me.lblDspItemClassCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItemClassCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItemClassCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItemClassCode.Enabled = True
		Me.lblDspItemClassCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItemClassCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItemClassCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItemClassCode.UseMnemonic = True
		Me.lblDspItemClassCode.Visible = True
		Me.lblDspItemClassCode.AutoSize = False
		Me.lblDspItemClassCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItemClassCode.Name = "lblDspItemClassCode"
		Me.lblItemClassCode.Text = "ITEMCLASSCODE"
		Me.lblItemClassCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblItemClassCode.Size = New System.Drawing.Size(68, 16)
		Me.lblItemClassCode.Location = New System.Drawing.Point(288, 20)
		Me.lblItemClassCode.TabIndex = 40
		Me.lblItemClassCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItemClassCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItemClassCode.Enabled = True
		Me.lblItemClassCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItemClassCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItemClassCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItemClassCode.UseMnemonic = True
		Me.lblItemClassCode.Visible = True
		Me.lblItemClassCode.AutoSize = False
		Me.lblItemClassCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItemClassCode.Name = "lblItemClassCode"
		Me.lblItmEngName.Text = "ITMENGNAME"
		Me.lblItmEngName.Size = New System.Drawing.Size(92, 16)
		Me.lblItmEngName.Location = New System.Drawing.Point(8, 67)
		Me.lblItmEngName.TabIndex = 29
		Me.lblItmEngName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmEngName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmEngName.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmEngName.Enabled = True
		Me.lblItmEngName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmEngName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmEngName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmEngName.UseMnemonic = True
		Me.lblItmEngName.Visible = True
		Me.lblItmEngName.AutoSize = False
		Me.lblItmEngName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmEngName.Name = "lblItmEngName"
		Me.lblItmChiName.Text = "ITMCHINAME"
		Me.lblItmChiName.Size = New System.Drawing.Size(87, 16)
		Me.lblItmChiName.Location = New System.Drawing.Point(8, 43)
		Me.lblItmChiName.TabIndex = 28
		Me.lblItmChiName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmChiName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmChiName.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmChiName.Enabled = True
		Me.lblItmChiName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmChiName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmChiName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmChiName.UseMnemonic = True
		Me.lblItmChiName.Visible = True
		Me.lblItmChiName.AutoSize = False
		Me.lblItmChiName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmChiName.Name = "lblItmChiName"
		Me.lblItmCode.Text = "國際書號 :"
		Me.lblItmCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblItmCode.Size = New System.Drawing.Size(92, 16)
		Me.lblItmCode.Location = New System.Drawing.Point(8, 20)
		Me.lblItmCode.TabIndex = 27
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
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(725, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 24)
		Me.tbrProcess.TabIndex = 30
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
		Me._tbrProcess_Button2.ToolTipText = "開新視窗 (F8)"
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
		Me._tbrProcess_Button11.Name = "Key"
		Me._tbrProcess_Button11.ToolTipText = "Change Key (F8)"
		Me._tbrProcess_Button11.ImageIndex = 12
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "Copy"
		Me._tbrProcess_Button12.ToolTipText = "Copy"
		Me._tbrProcess_Button12.ImageIndex = 13
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button13.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button13.AutoSize = False
		Me._tbrProcess_Button13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button14.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button14.AutoSize = False
		Me._tbrProcess_Button14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button14.Name = "Exit"
		Me._tbrProcess_Button14.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button14.ImageIndex = 8
		Me._tbrProcess_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tabDetailInfo.Size = New System.Drawing.Size(713, 305)
		Me.tabDetailInfo.Location = New System.Drawing.Point(8, 160)
		Me.tabDetailInfo.TabIndex = 31
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "索書資料"
		Me.fraInfo.Size = New System.Drawing.Size(337, 257)
		Me.fraInfo.Location = New System.Drawing.Point(16, 8)
		Me.fraInfo.TabIndex = 42
		Me.fraInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraInfo.Enabled = True
		Me.fraInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraInfo.Visible = True
		Me.fraInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraInfo.Name = "fraInfo"
		Me.txtItmBarCode.AutoSize = False
		Me.txtItmBarCode.Size = New System.Drawing.Size(246, 20)
		Me.txtItmBarCode.Location = New System.Drawing.Point(80, 119)
		Me.txtItmBarCode.TabIndex = 7
		Me.txtItmBarCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmBarCode.AcceptsReturn = True
		Me.txtItmBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmBarCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmBarCode.CausesValidation = True
		Me.txtItmBarCode.Enabled = True
		Me.txtItmBarCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmBarCode.HideSelection = True
		Me.txtItmBarCode.ReadOnly = False
		Me.txtItmBarCode.Maxlength = 0
		Me.txtItmBarCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmBarCode.MultiLine = False
		Me.txtItmBarCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmBarCode.TabStop = True
		Me.txtItmBarCode.Visible = True
		Me.txtItmBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmBarCode.Name = "txtItmBarCode"
		Me.txtItmBinNo.AutoSize = False
		Me.txtItmBinNo.Enabled = False
		Me.txtItmBinNo.Size = New System.Drawing.Size(246, 20)
		Me.txtItmBinNo.Location = New System.Drawing.Point(80, 167)
		Me.txtItmBinNo.TabIndex = 9
		Me.txtItmBinNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmBinNo.AcceptsReturn = True
		Me.txtItmBinNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmBinNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmBinNo.CausesValidation = True
		Me.txtItmBinNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmBinNo.HideSelection = True
		Me.txtItmBinNo.ReadOnly = False
		Me.txtItmBinNo.Maxlength = 0
		Me.txtItmBinNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmBinNo.MultiLine = False
		Me.txtItmBinNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmBinNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmBinNo.TabStop = True
		Me.txtItmBinNo.Visible = True
		Me.txtItmBinNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmBinNo.Name = "txtItmBinNo"
		Me.txtItmSeriesNo.AutoSize = False
		Me.txtItmSeriesNo.Enabled = False
		Me.txtItmSeriesNo.Size = New System.Drawing.Size(247, 20)
		Me.txtItmSeriesNo.Location = New System.Drawing.Point(80, 143)
		Me.txtItmSeriesNo.TabIndex = 8
		Me.txtItmSeriesNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmSeriesNo.AcceptsReturn = True
		Me.txtItmSeriesNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmSeriesNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmSeriesNo.CausesValidation = True
		Me.txtItmSeriesNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmSeriesNo.HideSelection = True
		Me.txtItmSeriesNo.ReadOnly = False
		Me.txtItmSeriesNo.Maxlength = 0
		Me.txtItmSeriesNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmSeriesNo.MultiLine = False
		Me.txtItmSeriesNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmSeriesNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmSeriesNo.TabStop = True
		Me.txtItmSeriesNo.Visible = True
		Me.txtItmSeriesNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmSeriesNo.Name = "txtItmSeriesNo"
		Me.lblDspItmUomDesc.Size = New System.Drawing.Size(319, 20)
		Me.lblDspItmUomDesc.Location = New System.Drawing.Point(8, 96)
		Me.lblDspItmUomDesc.TabIndex = 51
		Me.lblDspItmUomDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmUomDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmUomDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmUomDesc.Enabled = True
		Me.lblDspItmUomDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmUomDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmUomDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmUomDesc.UseMnemonic = True
		Me.lblDspItmUomDesc.Visible = True
		Me.lblDspItmUomDesc.AutoSize = False
		Me.lblDspItmUomDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmUomDesc.Name = "lblDspItmUomDesc"
		Me.lblItmBarCode.Text = "條碼編號 :"
		Me.lblItmBarCode.Size = New System.Drawing.Size(73, 17)
		Me.lblItmBarCode.Location = New System.Drawing.Point(8, 122)
		Me.lblItmBarCode.TabIndex = 50
		Me.lblItmBarCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmBarCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmBarCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmBarCode.Enabled = True
		Me.lblItmBarCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmBarCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmBarCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmBarCode.UseMnemonic = True
		Me.lblItmBarCode.Visible = True
		Me.lblItmBarCode.AutoSize = False
		Me.lblItmBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmBarCode.Name = "lblItmBarCode"
		Me.lblItmBinNo.Text = "ITMBINNO"
		Me.lblItmBinNo.Size = New System.Drawing.Size(60, 16)
		Me.lblItmBinNo.Location = New System.Drawing.Point(8, 171)
		Me.lblItmBinNo.TabIndex = 49
		Me.lblItmBinNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmBinNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmBinNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmBinNo.Enabled = True
		Me.lblItmBinNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmBinNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmBinNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmBinNo.UseMnemonic = True
		Me.lblItmBinNo.Visible = True
		Me.lblItmBinNo.AutoSize = False
		Me.lblItmBinNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmBinNo.Name = "lblItmBinNo"
		Me.lblItmUomCode.Text = "PACKTYPE"
		Me.lblItmUomCode.Size = New System.Drawing.Size(77, 16)
		Me.lblItmUomCode.Location = New System.Drawing.Point(8, 72)
		Me.lblItmUomCode.TabIndex = 48
		Me.lblItmUomCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmUomCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmUomCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmUomCode.Enabled = True
		Me.lblItmUomCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmUomCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmUomCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmUomCode.UseMnemonic = True
		Me.lblItmUomCode.Visible = True
		Me.lblItmUomCode.AutoSize = False
		Me.lblItmUomCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmUomCode.Name = "lblItmUomCode"
		Me.lblDspItmAccTypeDesc.Size = New System.Drawing.Size(319, 20)
		Me.lblDspItmAccTypeDesc.Location = New System.Drawing.Point(8, 216)
		Me.lblDspItmAccTypeDesc.TabIndex = 47
		Me.lblDspItmAccTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmAccTypeDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmAccTypeDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmAccTypeDesc.Enabled = True
		Me.lblDspItmAccTypeDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmAccTypeDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmAccTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmAccTypeDesc.UseMnemonic = True
		Me.lblDspItmAccTypeDesc.Visible = True
		Me.lblDspItmAccTypeDesc.AutoSize = False
		Me.lblDspItmAccTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmAccTypeDesc.Name = "lblDspItmAccTypeDesc"
		Me.lblItmSeriesNo.Text = "ITMSERIESNO"
		Me.lblItmSeriesNo.Size = New System.Drawing.Size(68, 16)
		Me.lblItmSeriesNo.Location = New System.Drawing.Point(8, 148)
		Me.lblItmSeriesNo.TabIndex = 46
		Me.lblItmSeriesNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmSeriesNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmSeriesNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmSeriesNo.Enabled = True
		Me.lblItmSeriesNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmSeriesNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmSeriesNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmSeriesNo.UseMnemonic = True
		Me.lblItmSeriesNo.Visible = True
		Me.lblItmSeriesNo.AutoSize = False
		Me.lblItmSeriesNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmSeriesNo.Name = "lblItmSeriesNo"
		Me.lblDspItmTypeDesc.Size = New System.Drawing.Size(319, 20)
		Me.lblDspItmTypeDesc.Location = New System.Drawing.Point(8, 48)
		Me.lblDspItmTypeDesc.TabIndex = 45
		Me.lblDspItmTypeDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmTypeDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmTypeDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmTypeDesc.Enabled = True
		Me.lblDspItmTypeDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmTypeDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmTypeDesc.UseMnemonic = True
		Me.lblDspItmTypeDesc.Visible = True
		Me.lblDspItmTypeDesc.AutoSize = False
		Me.lblDspItmTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmTypeDesc.Name = "lblDspItmTypeDesc"
		Me.lblItmTypeCode.Text = "ITMTYPE"
		Me.lblItmTypeCode.Size = New System.Drawing.Size(68, 16)
		Me.lblItmTypeCode.Location = New System.Drawing.Point(8, 28)
		Me.lblItmTypeCode.TabIndex = 44
		Me.lblItmTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.lblItmAccTypeCode.Text = "ITMACCTYPE"
		Me.lblItmAccTypeCode.Size = New System.Drawing.Size(84, 16)
		Me.lblItmAccTypeCode.Location = New System.Drawing.Point(8, 192)
		Me.lblItmAccTypeCode.TabIndex = 43
		Me.lblItmAccTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmAccTypeCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmAccTypeCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmAccTypeCode.Enabled = True
		Me.lblItmAccTypeCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmAccTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmAccTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmAccTypeCode.UseMnemonic = True
		Me.lblItmAccTypeCode.Visible = True
		Me.lblItmAccTypeCode.AutoSize = False
		Me.lblItmAccTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmAccTypeCode.Name = "lblItmAccTypeCode"
		Me.fraPrice.Size = New System.Drawing.Size(337, 257)
		Me.fraPrice.Location = New System.Drawing.Point(360, 8)
		Me.fraPrice.TabIndex = 52
		Me.fraPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraPrice.BackColor = System.Drawing.SystemColors.Control
		Me.fraPrice.Enabled = True
		Me.fraPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraPrice.Visible = True
		Me.fraPrice.Padding = New System.Windows.Forms.Padding(0)
		Me.fraPrice.Name = "fraPrice"
		Me.txtItmUnitPrice.AutoSize = False
		Me.txtItmUnitPrice.Enabled = False
		Me.txtItmUnitPrice.Size = New System.Drawing.Size(119, 20)
		Me.txtItmUnitPrice.Location = New System.Drawing.Point(96, 88)
		Me.txtItmUnitPrice.TabIndex = 13
		Me.txtItmUnitPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmUnitPrice.AcceptsReturn = True
		Me.txtItmUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmUnitPrice.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmUnitPrice.CausesValidation = True
		Me.txtItmUnitPrice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmUnitPrice.HideSelection = True
		Me.txtItmUnitPrice.ReadOnly = False
		Me.txtItmUnitPrice.Maxlength = 0
		Me.txtItmUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmUnitPrice.MultiLine = False
		Me.txtItmUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmUnitPrice.TabStop = True
		Me.txtItmUnitPrice.Visible = True
		Me.txtItmUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmUnitPrice.Name = "txtItmUnitPrice"
		Me.txtItmDefaultPrice.AutoSize = False
		Me.txtItmDefaultPrice.Enabled = False
		Me.txtItmDefaultPrice.Size = New System.Drawing.Size(119, 20)
		Me.txtItmDefaultPrice.Location = New System.Drawing.Point(96, 215)
		Me.txtItmDefaultPrice.TabIndex = 17
		Me.txtItmDefaultPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmDefaultPrice.AcceptsReturn = True
		Me.txtItmDefaultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmDefaultPrice.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmDefaultPrice.CausesValidation = True
		Me.txtItmDefaultPrice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmDefaultPrice.HideSelection = True
		Me.txtItmDefaultPrice.ReadOnly = False
		Me.txtItmDefaultPrice.Maxlength = 0
		Me.txtItmDefaultPrice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmDefaultPrice.MultiLine = False
		Me.txtItmDefaultPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmDefaultPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmDefaultPrice.TabStop = True
		Me.txtItmDefaultPrice.Visible = True
		Me.txtItmDefaultPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmDefaultPrice.Name = "txtItmDefaultPrice"
		Me.txtItmDiscount.AutoSize = False
		Me.txtItmDiscount.Enabled = False
		Me.txtItmDiscount.Size = New System.Drawing.Size(119, 20)
		Me.txtItmDiscount.Location = New System.Drawing.Point(96, 120)
		Me.txtItmDiscount.TabIndex = 14
		Me.txtItmDiscount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmDiscount.AcceptsReturn = True
		Me.txtItmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmDiscount.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmDiscount.CausesValidation = True
		Me.txtItmDiscount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmDiscount.HideSelection = True
		Me.txtItmDiscount.ReadOnly = False
		Me.txtItmDiscount.Maxlength = 0
		Me.txtItmDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmDiscount.MultiLine = False
		Me.txtItmDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmDiscount.TabStop = True
		Me.txtItmDiscount.Visible = True
		Me.txtItmDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmDiscount.Name = "txtItmDiscount"
		Me.txtItmMarkUp.AutoSize = False
		Me.txtItmMarkUp.Enabled = False
		Me.txtItmMarkUp.Size = New System.Drawing.Size(119, 20)
		Me.txtItmMarkUp.Location = New System.Drawing.Point(96, 183)
		Me.txtItmMarkUp.TabIndex = 16
		Me.txtItmMarkUp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmMarkUp.AcceptsReturn = True
		Me.txtItmMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmMarkUp.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmMarkUp.CausesValidation = True
		Me.txtItmMarkUp.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmMarkUp.HideSelection = True
		Me.txtItmMarkUp.ReadOnly = False
		Me.txtItmMarkUp.Maxlength = 0
		Me.txtItmMarkUp.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmMarkUp.MultiLine = False
		Me.txtItmMarkUp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmMarkUp.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmMarkUp.TabStop = True
		Me.txtItmMarkUp.Visible = True
		Me.txtItmMarkUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmMarkUp.Name = "txtItmMarkUp"
		Me.txtItmBottomPrice.AutoSize = False
		Me.txtItmBottomPrice.Enabled = False
		Me.txtItmBottomPrice.Size = New System.Drawing.Size(119, 20)
		Me.txtItmBottomPrice.Location = New System.Drawing.Point(96, 151)
		Me.txtItmBottomPrice.TabIndex = 15
		Me.txtItmBottomPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmBottomPrice.AcceptsReturn = True
		Me.txtItmBottomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmBottomPrice.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmBottomPrice.CausesValidation = True
		Me.txtItmBottomPrice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmBottomPrice.HideSelection = True
		Me.txtItmBottomPrice.ReadOnly = False
		Me.txtItmBottomPrice.Maxlength = 0
		Me.txtItmBottomPrice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmBottomPrice.MultiLine = False
		Me.txtItmBottomPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmBottomPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmBottomPrice.TabStop = True
		Me.txtItmBottomPrice.Visible = True
		Me.txtItmBottomPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmBottomPrice.Name = "txtItmBottomPrice"
		Me.btnItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnItemPrice.Text = "ITEMPRICE"
		Me.btnItemPrice.Enabled = False
		Me.btnItemPrice.Size = New System.Drawing.Size(97, 37)
		Me.btnItemPrice.Location = New System.Drawing.Point(224, 24)
		Me.btnItemPrice.TabIndex = 18
		Me.btnItemPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnItemPrice.BackColor = System.Drawing.SystemColors.Control
		Me.btnItemPrice.CausesValidation = True
		Me.btnItemPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnItemPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnItemPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnItemPrice.TabStop = True
		Me.btnItemPrice.Name = "btnItemPrice"
		Me.lblItmDefaultPrice.Text = "ITMDEFAULTPRICE"
		Me.lblItmDefaultPrice.Size = New System.Drawing.Size(68, 16)
		Me.lblItmDefaultPrice.Location = New System.Drawing.Point(24, 220)
		Me.lblItmDefaultPrice.TabIndex = 59
		Me.lblItmDefaultPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmDefaultPrice.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmDefaultPrice.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmDefaultPrice.Enabled = True
		Me.lblItmDefaultPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmDefaultPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmDefaultPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmDefaultPrice.UseMnemonic = True
		Me.lblItmDefaultPrice.Visible = True
		Me.lblItmDefaultPrice.AutoSize = False
		Me.lblItmDefaultPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmDefaultPrice.Name = "lblItmDefaultPrice"
		Me.lblItmDiscount.Text = "ITMDISCOUNT"
		Me.lblItmDiscount.Size = New System.Drawing.Size(68, 16)
		Me.lblItmDiscount.Location = New System.Drawing.Point(24, 124)
		Me.lblItmDiscount.TabIndex = 58
		Me.lblItmDiscount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmDiscount.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmDiscount.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmDiscount.Enabled = True
		Me.lblItmDiscount.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmDiscount.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmDiscount.UseMnemonic = True
		Me.lblItmDiscount.Visible = True
		Me.lblItmDiscount.AutoSize = False
		Me.lblItmDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmDiscount.Name = "lblItmDiscount"
		Me.lblItmPVdrCode.Text = "ITMPVDRID"
		Me.lblItmPVdrCode.Size = New System.Drawing.Size(68, 16)
		Me.lblItmPVdrCode.Location = New System.Drawing.Point(24, 59)
		Me.lblItmPVdrCode.TabIndex = 57
		Me.lblItmPVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmPVdrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmPVdrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmPVdrCode.Enabled = True
		Me.lblItmPVdrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmPVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmPVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmPVdrCode.UseMnemonic = True
		Me.lblItmPVdrCode.Visible = True
		Me.lblItmPVdrCode.AutoSize = False
		Me.lblItmPVdrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmPVdrCode.Name = "lblItmPVdrCode"
		Me.lblItmMarkUp.Text = "ITMMARKUP"
		Me.lblItmMarkUp.Size = New System.Drawing.Size(68, 16)
		Me.lblItmMarkUp.Location = New System.Drawing.Point(24, 187)
		Me.lblItmMarkUp.TabIndex = 56
		Me.lblItmMarkUp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmMarkUp.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmMarkUp.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmMarkUp.Enabled = True
		Me.lblItmMarkUp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmMarkUp.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmMarkUp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmMarkUp.UseMnemonic = True
		Me.lblItmMarkUp.Visible = True
		Me.lblItmMarkUp.AutoSize = False
		Me.lblItmMarkUp.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmMarkUp.Name = "lblItmMarkUp"
		Me.lblUnitPrice.Text = "UNITPRICE"
		Me.lblUnitPrice.Size = New System.Drawing.Size(68, 16)
		Me.lblUnitPrice.Location = New System.Drawing.Point(24, 91)
		Me.lblUnitPrice.TabIndex = 55
		Me.lblUnitPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUnitPrice.BackColor = System.Drawing.SystemColors.Control
		Me.lblUnitPrice.Enabled = True
		Me.lblUnitPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUnitPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUnitPrice.UseMnemonic = True
		Me.lblUnitPrice.Visible = True
		Me.lblUnitPrice.AutoSize = False
		Me.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUnitPrice.Name = "lblUnitPrice"
		Me.lblItmCurrCode.Text = "貨幣 :"
		Me.lblItmCurrCode.Size = New System.Drawing.Size(68, 16)
		Me.lblItmCurrCode.Location = New System.Drawing.Point(24, 28)
		Me.lblItmCurrCode.TabIndex = 54
		Me.lblItmCurrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCurrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCurrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCurrCode.Enabled = True
		Me.lblItmCurrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCurrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCurrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCurrCode.UseMnemonic = True
		Me.lblItmCurrCode.Visible = True
		Me.lblItmCurrCode.AutoSize = False
		Me.lblItmCurrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCurrCode.Name = "lblItmCurrCode"
		Me.lblItmBottomPrice.Text = "BOTTOMPRICE"
		Me.lblItmBottomPrice.Size = New System.Drawing.Size(68, 16)
		Me.lblItmBottomPrice.Location = New System.Drawing.Point(24, 157)
		Me.lblItmBottomPrice.TabIndex = 53
		Me.lblItmBottomPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmBottomPrice.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmBottomPrice.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmBottomPrice.Enabled = True
		Me.lblItmBottomPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmBottomPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmBottomPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmBottomPrice.UseMnemonic = True
		Me.lblItmBottomPrice.Visible = True
		Me.lblItmBottomPrice.AutoSize = False
		Me.lblItmBottomPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmBottomPrice.Name = "lblItmBottomPrice"
		Me.cboItmAccTypeCode.Size = New System.Drawing.Size(247, 20)
		Me.cboItmAccTypeCode.Location = New System.Drawing.Point(96, 200)
		Me.cboItmAccTypeCode.TabIndex = 10
		Me.cboItmAccTypeCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmAccTypeCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmAccTypeCode.CausesValidation = True
		Me.cboItmAccTypeCode.Enabled = True
		Me.cboItmAccTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmAccTypeCode.IntegralHeight = True
		Me.cboItmAccTypeCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmAccTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmAccTypeCode.Sorted = False
		Me.cboItmAccTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmAccTypeCode.TabStop = True
		Me.cboItmAccTypeCode.Visible = True
		Me.cboItmAccTypeCode.Name = "cboItmAccTypeCode"
		Me.cboItmCurr.Enabled = False
		Me.cboItmCurr.Size = New System.Drawing.Size(119, 20)
		Me.cboItmCurr.Location = New System.Drawing.Point(456, 32)
		Me.cboItmCurr.TabIndex = 11
		Me.cboItmCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCurr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCurr.CausesValidation = True
		Me.cboItmCurr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCurr.IntegralHeight = True
		Me.cboItmCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCurr.Sorted = False
		Me.cboItmCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCurr.TabStop = True
		Me.cboItmCurr.Visible = True
		Me.cboItmCurr.Name = "cboItmCurr"
		Me.cboItmUOMCode.Size = New System.Drawing.Size(247, 20)
		Me.cboItmUOMCode.Location = New System.Drawing.Point(96, 80)
		Me.cboItmUOMCode.TabIndex = 6
		Me.cboItmUOMCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmUOMCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmUOMCode.CausesValidation = True
		Me.cboItmUOMCode.Enabled = True
		Me.cboItmUOMCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmUOMCode.IntegralHeight = True
		Me.cboItmUOMCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmUOMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmUOMCode.Sorted = False
		Me.cboItmUOMCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmUOMCode.TabStop = True
		Me.cboItmUOMCode.Visible = True
		Me.cboItmUOMCode.Name = "cboItmUOMCode"
		Me.cboItmTypeCode.Size = New System.Drawing.Size(247, 20)
		Me.cboItmTypeCode.Location = New System.Drawing.Point(96, 32)
		Me.cboItmTypeCode.TabIndex = 5
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
		Me.cboItmPVdrCode.Enabled = False
		Me.cboItmPVdrCode.Size = New System.Drawing.Size(119, 20)
		Me.cboItmPVdrCode.Location = New System.Drawing.Point(456, 63)
		Me.cboItmPVdrCode.TabIndex = 12
		Me.cboItmPVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmPVdrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmPVdrCode.CausesValidation = True
		Me.cboItmPVdrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmPVdrCode.IntegralHeight = True
		Me.cboItmPVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmPVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmPVdrCode.Sorted = False
		Me.cboItmPVdrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmPVdrCode.TabStop = True
		Me.cboItmPVdrCode.Visible = True
		Me.cboItmPVdrCode.Name = "cboItmPVdrCode"
		Me._tabDetailInfo_TabPage1.Text = "附加資料"
		Me.fraContent.Size = New System.Drawing.Size(657, 177)
		Me.fraContent.Location = New System.Drawing.Point(8, 16)
		Me.fraContent.TabIndex = 32
		Me.fraContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraContent.BackColor = System.Drawing.SystemColors.Control
		Me.fraContent.Enabled = True
		Me.fraContent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraContent.Visible = True
		Me.fraContent.Padding = New System.Windows.Forms.Padding(0)
		Me.fraContent.Name = "fraContent"
		Me.txtItmMaxQty.AutoSize = False
		Me.txtItmMaxQty.Enabled = False
		Me.txtItmMaxQty.Size = New System.Drawing.Size(63, 20)
		Me.txtItmMaxQty.Location = New System.Drawing.Point(232, 40)
		Me.txtItmMaxQty.TabIndex = 23
		Me.txtItmMaxQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmMaxQty.AcceptsReturn = True
		Me.txtItmMaxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmMaxQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmMaxQty.CausesValidation = True
		Me.txtItmMaxQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmMaxQty.HideSelection = True
		Me.txtItmMaxQty.ReadOnly = False
		Me.txtItmMaxQty.Maxlength = 0
		Me.txtItmMaxQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmMaxQty.MultiLine = False
		Me.txtItmMaxQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmMaxQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmMaxQty.TabStop = True
		Me.txtItmMaxQty.Visible = True
		Me.txtItmMaxQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmMaxQty.Name = "txtItmMaxQty"
		Me.txtItmPORepuQty.AutoSize = False
		Me.txtItmPORepuQty.Enabled = False
		Me.txtItmPORepuQty.Size = New System.Drawing.Size(63, 20)
		Me.txtItmPORepuQty.Location = New System.Drawing.Point(232, 64)
		Me.txtItmPORepuQty.TabIndex = 24
		Me.txtItmPORepuQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmPORepuQty.AcceptsReturn = True
		Me.txtItmPORepuQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmPORepuQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmPORepuQty.CausesValidation = True
		Me.txtItmPORepuQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmPORepuQty.HideSelection = True
		Me.txtItmPORepuQty.ReadOnly = False
		Me.txtItmPORepuQty.Maxlength = 0
		Me.txtItmPORepuQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmPORepuQty.MultiLine = False
		Me.txtItmPORepuQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmPORepuQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmPORepuQty.TabStop = True
		Me.txtItmPORepuQty.Visible = True
		Me.txtItmPORepuQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmPORepuQty.Name = "txtItmPORepuQty"
		Me.chkItmReorderInd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkItmReorderInd.Text = "再版指標 :"
		Me.chkItmReorderInd.Size = New System.Drawing.Size(97, 12)
		Me.chkItmReorderInd.Location = New System.Drawing.Point(16, 68)
		Me.chkItmReorderInd.TabIndex = 21
		Me.chkItmReorderInd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkItmReorderInd.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkItmReorderInd.BackColor = System.Drawing.SystemColors.Control
		Me.chkItmReorderInd.CausesValidation = True
		Me.chkItmReorderInd.Enabled = True
		Me.chkItmReorderInd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkItmReorderInd.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkItmReorderInd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkItmReorderInd.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkItmReorderInd.TabStop = True
		Me.chkItmReorderInd.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkItmReorderInd.Visible = True
		Me.chkItmReorderInd.Name = "chkItmReorderInd"
		Me.chkItmInvItemFlg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkItmInvItemFlg.Text = "非存貨 :"
		Me.chkItmInvItemFlg.Size = New System.Drawing.Size(97, 12)
		Me.chkItmInvItemFlg.Location = New System.Drawing.Point(16, 44)
		Me.chkItmInvItemFlg.TabIndex = 20
		Me.chkItmInvItemFlg.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkItmInvItemFlg.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkItmInvItemFlg.BackColor = System.Drawing.SystemColors.Control
		Me.chkItmInvItemFlg.CausesValidation = True
		Me.chkItmInvItemFlg.Enabled = True
		Me.chkItmInvItemFlg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkItmInvItemFlg.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkItmInvItemFlg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkItmInvItemFlg.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkItmInvItemFlg.TabStop = True
		Me.chkItmInvItemFlg.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkItmInvItemFlg.Visible = True
		Me.chkItmInvItemFlg.Name = "chkItmInvItemFlg"
		Me.chkItmInActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkItmInActive.Text = "暫停發貨 :"
		Me.chkItmInActive.Size = New System.Drawing.Size(97, 12)
		Me.chkItmInActive.Location = New System.Drawing.Point(16, 20)
		Me.chkItmInActive.TabIndex = 19
		Me.chkItmInActive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkItmInActive.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkItmInActive.BackColor = System.Drawing.SystemColors.Control
		Me.chkItmInActive.CausesValidation = True
		Me.chkItmInActive.Enabled = True
		Me.chkItmInActive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkItmInActive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkItmInActive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkItmInActive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkItmInActive.TabStop = True
		Me.chkItmInActive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkItmInActive.Visible = True
		Me.chkItmInActive.Name = "chkItmInActive"
		Me.txtItmReorderQty.AutoSize = False
		Me.txtItmReorderQty.Enabled = False
		Me.txtItmReorderQty.Size = New System.Drawing.Size(63, 20)
		Me.txtItmReorderQty.Location = New System.Drawing.Point(232, 16)
		Me.txtItmReorderQty.TabIndex = 22
		Me.txtItmReorderQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmReorderQty.AcceptsReturn = True
		Me.txtItmReorderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmReorderQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmReorderQty.CausesValidation = True
		Me.txtItmReorderQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmReorderQty.HideSelection = True
		Me.txtItmReorderQty.ReadOnly = False
		Me.txtItmReorderQty.Maxlength = 0
		Me.txtItmReorderQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmReorderQty.MultiLine = False
		Me.txtItmReorderQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmReorderQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmReorderQty.TabStop = True
		Me.txtItmReorderQty.Visible = True
		Me.txtItmReorderQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmReorderQty.Name = "txtItmReorderQty"
		Me.lblDspStkOnHand.Size = New System.Drawing.Size(71, 20)
		Me.lblDspStkOnHand.Location = New System.Drawing.Point(560, 16)
		Me.lblDspStkOnHand.TabIndex = 76
		Me.lblDspStkOnHand.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStkOnHand.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStkOnHand.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStkOnHand.Enabled = True
		Me.lblDspStkOnHand.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStkOnHand.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStkOnHand.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStkOnHand.UseMnemonic = True
		Me.lblDspStkOnHand.Visible = True
		Me.lblDspStkOnHand.AutoSize = False
		Me.lblDspStkOnHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStkOnHand.Name = "lblDspStkOnHand"
		Me.lblStkOnHand.Text = "ICTRNQTY"
		Me.lblStkOnHand.Size = New System.Drawing.Size(141, 16)
		Me.lblStkOnHand.Location = New System.Drawing.Point(400, 16)
		Me.lblStkOnHand.TabIndex = 75
		Me.lblStkOnHand.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStkOnHand.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStkOnHand.BackColor = System.Drawing.SystemColors.Control
		Me.lblStkOnHand.Enabled = True
		Me.lblStkOnHand.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStkOnHand.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStkOnHand.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStkOnHand.UseMnemonic = True
		Me.lblStkOnHand.Visible = True
		Me.lblStkOnHand.AutoSize = False
		Me.lblStkOnHand.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStkOnHand.Name = "lblStkOnHand"
		Me.lblDspStkIndent.Size = New System.Drawing.Size(71, 20)
		Me.lblDspStkIndent.Location = New System.Drawing.Point(560, 88)
		Me.lblDspStkIndent.TabIndex = 74
		Me.lblDspStkIndent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStkIndent.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStkIndent.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStkIndent.Enabled = True
		Me.lblDspStkIndent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStkIndent.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStkIndent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStkIndent.UseMnemonic = True
		Me.lblDspStkIndent.Visible = True
		Me.lblDspStkIndent.AutoSize = False
		Me.lblDspStkIndent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStkIndent.Name = "lblDspStkIndent"
		Me.lblStkIndent.Text = "ICTRNQTY"
		Me.lblStkIndent.Size = New System.Drawing.Size(141, 16)
		Me.lblStkIndent.Location = New System.Drawing.Point(400, 88)
		Me.lblStkIndent.TabIndex = 73
		Me.lblStkIndent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStkIndent.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStkIndent.BackColor = System.Drawing.SystemColors.Control
		Me.lblStkIndent.Enabled = True
		Me.lblStkIndent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStkIndent.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStkIndent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStkIndent.UseMnemonic = True
		Me.lblStkIndent.Visible = True
		Me.lblStkIndent.AutoSize = False
		Me.lblStkIndent.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStkIndent.Name = "lblStkIndent"
		Me.lblDspStkOnOrder.Size = New System.Drawing.Size(71, 20)
		Me.lblDspStkOnOrder.Location = New System.Drawing.Point(560, 64)
		Me.lblDspStkOnOrder.TabIndex = 72
		Me.lblDspStkOnOrder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStkOnOrder.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStkOnOrder.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStkOnOrder.Enabled = True
		Me.lblDspStkOnOrder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStkOnOrder.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStkOnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStkOnOrder.UseMnemonic = True
		Me.lblDspStkOnOrder.Visible = True
		Me.lblDspStkOnOrder.AutoSize = False
		Me.lblDspStkOnOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStkOnOrder.Name = "lblDspStkOnOrder"
		Me.lblStkOnOrder.Text = "ICTRNQTY"
		Me.lblStkOnOrder.Size = New System.Drawing.Size(141, 16)
		Me.lblStkOnOrder.Location = New System.Drawing.Point(400, 64)
		Me.lblStkOnOrder.TabIndex = 71
		Me.lblStkOnOrder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStkOnOrder.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStkOnOrder.BackColor = System.Drawing.SystemColors.Control
		Me.lblStkOnOrder.Enabled = True
		Me.lblStkOnOrder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStkOnOrder.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStkOnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStkOnOrder.UseMnemonic = True
		Me.lblStkOnOrder.Visible = True
		Me.lblStkOnOrder.AutoSize = False
		Me.lblStkOnOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStkOnOrder.Name = "lblStkOnOrder"
		Me.lblDspStkAllocated.Size = New System.Drawing.Size(71, 20)
		Me.lblDspStkAllocated.Location = New System.Drawing.Point(560, 40)
		Me.lblDspStkAllocated.TabIndex = 70
		Me.lblDspStkAllocated.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStkAllocated.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStkAllocated.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStkAllocated.Enabled = True
		Me.lblDspStkAllocated.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStkAllocated.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStkAllocated.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStkAllocated.UseMnemonic = True
		Me.lblDspStkAllocated.Visible = True
		Me.lblDspStkAllocated.AutoSize = False
		Me.lblDspStkAllocated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStkAllocated.Name = "lblDspStkAllocated"
		Me.lblStkAllocated.Text = "ICTRNQTY"
		Me.lblStkAllocated.Size = New System.Drawing.Size(141, 16)
		Me.lblStkAllocated.Location = New System.Drawing.Point(400, 40)
		Me.lblStkAllocated.TabIndex = 69
		Me.lblStkAllocated.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStkAllocated.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStkAllocated.BackColor = System.Drawing.SystemColors.Control
		Me.lblStkAllocated.Enabled = True
		Me.lblStkAllocated.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStkAllocated.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStkAllocated.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStkAllocated.UseMnemonic = True
		Me.lblStkAllocated.Visible = True
		Me.lblStkAllocated.AutoSize = False
		Me.lblStkAllocated.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStkAllocated.Name = "lblStkAllocated"
		Me.lblDspStkAvailable.Size = New System.Drawing.Size(71, 20)
		Me.lblDspStkAvailable.Location = New System.Drawing.Point(560, 112)
		Me.lblDspStkAvailable.TabIndex = 68
		Me.lblDspStkAvailable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspStkAvailable.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspStkAvailable.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspStkAvailable.Enabled = True
		Me.lblDspStkAvailable.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspStkAvailable.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspStkAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspStkAvailable.UseMnemonic = True
		Me.lblDspStkAvailable.Visible = True
		Me.lblDspStkAvailable.AutoSize = False
		Me.lblDspStkAvailable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspStkAvailable.Name = "lblDspStkAvailable"
		Me.lblStkAvailable.Text = "ICTRNQTY"
		Me.lblStkAvailable.Size = New System.Drawing.Size(141, 16)
		Me.lblStkAvailable.Location = New System.Drawing.Point(400, 112)
		Me.lblStkAvailable.TabIndex = 67
		Me.lblStkAvailable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStkAvailable.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStkAvailable.BackColor = System.Drawing.SystemColors.Control
		Me.lblStkAvailable.Enabled = True
		Me.lblStkAvailable.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStkAvailable.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStkAvailable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStkAvailable.UseMnemonic = True
		Me.lblStkAvailable.Visible = True
		Me.lblStkAvailable.AutoSize = False
		Me.lblStkAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStkAvailable.Name = "lblStkAvailable"
		Me.lblItmMaxQty.Text = "再版指標 :"
		Me.lblItmMaxQty.Size = New System.Drawing.Size(76, 16)
		Me.lblItmMaxQty.Location = New System.Drawing.Point(144, 43)
		Me.lblItmMaxQty.TabIndex = 39
		Me.lblItmMaxQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmMaxQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmMaxQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmMaxQty.Enabled = True
		Me.lblItmMaxQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmMaxQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmMaxQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmMaxQty.UseMnemonic = True
		Me.lblItmMaxQty.Visible = True
		Me.lblItmMaxQty.AutoSize = False
		Me.lblItmMaxQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmMaxQty.Name = "lblItmMaxQty"
		Me.lblItmPORepuQty.Text = "再版數量 :"
		Me.lblItmPORepuQty.Size = New System.Drawing.Size(76, 16)
		Me.lblItmPORepuQty.Location = New System.Drawing.Point(144, 64)
		Me.lblItmPORepuQty.TabIndex = 34
		Me.lblItmPORepuQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmPORepuQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmPORepuQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmPORepuQty.Enabled = True
		Me.lblItmPORepuQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmPORepuQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmPORepuQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmPORepuQty.UseMnemonic = True
		Me.lblItmPORepuQty.Visible = True
		Me.lblItmPORepuQty.AutoSize = False
		Me.lblItmPORepuQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmPORepuQty.Name = "lblItmPORepuQty"
		Me.lblItmReorderQty.Text = "再版指標 :"
		Me.lblItmReorderQty.Size = New System.Drawing.Size(76, 16)
		Me.lblItmReorderQty.Location = New System.Drawing.Point(144, 21)
		Me.lblItmReorderQty.TabIndex = 33
		Me.lblItmReorderQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmReorderQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmReorderQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmReorderQty.Enabled = True
		Me.lblItmReorderQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmReorderQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmReorderQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmReorderQty.UseMnemonic = True
		Me.lblItmReorderQty.Visible = True
		Me.lblItmReorderQty.AutoSize = False
		Me.lblItmReorderQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmReorderQty.Name = "lblItmReorderQty"
		Me._tabDetailInfo_TabPage2.Text = "BOM"
		Me.Frame3.Size = New System.Drawing.Size(409, 30)
		Me.Frame3.Location = New System.Drawing.Point(8, 8)
		Me.Frame3.TabIndex = 62
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.lblKeyDesc.Text = "REMARK"
		Me.lblKeyDesc.Size = New System.Drawing.Size(81, 15)
		Me.lblKeyDesc.Location = New System.Drawing.Point(24, 12)
		Me.lblKeyDesc.TabIndex = 66
		Me.lblKeyDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKeyDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblKeyDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblKeyDesc.Enabled = True
		Me.lblKeyDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblKeyDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblKeyDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblKeyDesc.UseMnemonic = True
		Me.lblKeyDesc.Visible = True
		Me.lblKeyDesc.AutoSize = False
		Me.lblKeyDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblKeyDesc.Name = "lblKeyDesc"
		Me.lblComboPrompt.Text = "REMARK"
		Me.lblComboPrompt.Size = New System.Drawing.Size(81, 15)
		Me.lblComboPrompt.Location = New System.Drawing.Point(128, 12)
		Me.lblComboPrompt.TabIndex = 65
		Me.lblComboPrompt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblComboPrompt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblComboPrompt.BackColor = System.Drawing.SystemColors.Control
		Me.lblComboPrompt.Enabled = True
		Me.lblComboPrompt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblComboPrompt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblComboPrompt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblComboPrompt.UseMnemonic = True
		Me.lblComboPrompt.Visible = True
		Me.lblComboPrompt.AutoSize = False
		Me.lblComboPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblComboPrompt.Name = "lblComboPrompt"
		Me.lblInsertLine.Text = "REMARK"
		Me.lblInsertLine.Size = New System.Drawing.Size(81, 15)
		Me.lblInsertLine.Location = New System.Drawing.Point(224, 12)
		Me.lblInsertLine.TabIndex = 64
		Me.lblInsertLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInsertLine.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInsertLine.BackColor = System.Drawing.SystemColors.Control
		Me.lblInsertLine.Enabled = True
		Me.lblInsertLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInsertLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInsertLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInsertLine.UseMnemonic = True
		Me.lblInsertLine.Visible = True
		Me.lblInsertLine.AutoSize = False
		Me.lblInsertLine.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInsertLine.Name = "lblInsertLine"
		Me.lblDeleteLine.Text = "REMARK"
		Me.lblDeleteLine.Size = New System.Drawing.Size(81, 15)
		Me.lblDeleteLine.Location = New System.Drawing.Point(320, 12)
		Me.lblDeleteLine.TabIndex = 63
		Me.lblDeleteLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDeleteLine.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDeleteLine.BackColor = System.Drawing.SystemColors.Control
		Me.lblDeleteLine.Enabled = True
		Me.lblDeleteLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDeleteLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDeleteLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDeleteLine.UseMnemonic = True
		Me.lblDeleteLine.Visible = True
		Me.lblDeleteLine.AutoSize = False
		Me.lblDeleteLine.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDeleteLine.Name = "lblDeleteLine"
		Me.chkOwnEdition.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkOwnEdition.Text = "OWNEDITION"
		Me.chkOwnEdition.Size = New System.Drawing.Size(129, 12)
		Me.chkOwnEdition.Location = New System.Drawing.Point(576, 16)
		Me.chkOwnEdition.TabIndex = 60
		Me.chkOwnEdition.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkOwnEdition.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkOwnEdition.BackColor = System.Drawing.SystemColors.Control
		Me.chkOwnEdition.CausesValidation = True
		Me.chkOwnEdition.Enabled = True
		Me.chkOwnEdition.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkOwnEdition.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkOwnEdition.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkOwnEdition.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkOwnEdition.TabStop = True
		Me.chkOwnEdition.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkOwnEdition.Visible = True
		Me.chkOwnEdition.Name = "chkOwnEdition"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(697, 225)
		Me.tblDetail.Location = New System.Drawing.Point(8, 48)
		Me.tblDetail.TabIndex = 61
		Me.tblDetail.Name = "tblDetail"
		Me.lblItmLastUpd.Text = "最後修改人 :"
		Me.lblItmLastUpd.Size = New System.Drawing.Size(92, 16)
		Me.lblItmLastUpd.Location = New System.Drawing.Point(8, 472)
		Me.lblItmLastUpd.TabIndex = 38
		Me.lblItmLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmLastUpd.Enabled = True
		Me.lblItmLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmLastUpd.UseMnemonic = True
		Me.lblItmLastUpd.Visible = True
		Me.lblItmLastUpd.AutoSize = False
		Me.lblItmLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmLastUpd.Name = "lblItmLastUpd"
		Me.lblItmLastUpdDate.Text = "最後修改日期 :"
		Me.lblItmLastUpdDate.Size = New System.Drawing.Size(92, 16)
		Me.lblItmLastUpdDate.Location = New System.Drawing.Point(408, 472)
		Me.lblItmLastUpdDate.TabIndex = 37
		Me.lblItmLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmLastUpdDate.Enabled = True
		Me.lblItmLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmLastUpdDate.UseMnemonic = True
		Me.lblItmLastUpdDate.Visible = True
		Me.lblItmLastUpdDate.AutoSize = False
		Me.lblItmLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmLastUpdDate.Name = "lblItmLastUpdDate"
		Me.lblDspItmLastUpd.Size = New System.Drawing.Size(201, 20)
		Me.lblDspItmLastUpd.Location = New System.Drawing.Point(112, 472)
		Me.lblDspItmLastUpd.TabIndex = 36
		Me.lblDspItmLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmLastUpd.Enabled = True
		Me.lblDspItmLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmLastUpd.UseMnemonic = True
		Me.lblDspItmLastUpd.Visible = True
		Me.lblDspItmLastUpd.AutoSize = False
		Me.lblDspItmLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmLastUpd.Name = "lblDspItmLastUpd"
		Me.lblDspItmLastUpdDate.Size = New System.Drawing.Size(193, 20)
		Me.lblDspItmLastUpdDate.Location = New System.Drawing.Point(512, 472)
		Me.lblDspItmLastUpdDate.TabIndex = 35
		Me.lblDspItmLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmLastUpdDate.Enabled = True
		Me.lblDspItmLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmLastUpdDate.UseMnemonic = True
		Me.lblDspItmLastUpdDate.Visible = True
		Me.lblDspItmLastUpdDate.AutoSize = False
		Me.lblDspItmLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmLastUpdDate.Name = "lblDspItmLastUpdDate"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboItemClassCode)
		Me.Controls.Add(cboItmCode)
		Me.Controls.Add(fraHeaderInfo)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tabDetailInfo)
		Me.Controls.Add(lblItmLastUpd)
		Me.Controls.Add(lblItmLastUpdDate)
		Me.Controls.Add(lblDspItmLastUpd)
		Me.Controls.Add(lblDspItmLastUpdDate)
		Me.fraHeaderInfo.Controls.Add(txtItmEngName)
		Me.fraHeaderInfo.Controls.Add(txtItmChiName)
		Me.fraHeaderInfo.Controls.Add(txtItmCode)
		Me.fraHeaderInfo.Controls.Add(lblDspItemClassCode)
		Me.fraHeaderInfo.Controls.Add(lblItemClassCode)
		Me.fraHeaderInfo.Controls.Add(lblItmEngName)
		Me.fraHeaderInfo.Controls.Add(lblItmChiName)
		Me.fraHeaderInfo.Controls.Add(lblItmCode)
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
		Me.tbrProcess.Items.Add(_tbrProcess_Button14)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage2)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraInfo)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraPrice)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboItmAccTypeCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboItmCurr)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboItmUOMCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboItmTypeCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboItmPVdrCode)
		Me.fraInfo.Controls.Add(txtItmBarCode)
		Me.fraInfo.Controls.Add(txtItmBinNo)
		Me.fraInfo.Controls.Add(txtItmSeriesNo)
		Me.fraInfo.Controls.Add(lblDspItmUomDesc)
		Me.fraInfo.Controls.Add(lblItmBarCode)
		Me.fraInfo.Controls.Add(lblItmBinNo)
		Me.fraInfo.Controls.Add(lblItmUomCode)
		Me.fraInfo.Controls.Add(lblDspItmAccTypeDesc)
		Me.fraInfo.Controls.Add(lblItmSeriesNo)
		Me.fraInfo.Controls.Add(lblDspItmTypeDesc)
		Me.fraInfo.Controls.Add(lblItmTypeCode)
		Me.fraInfo.Controls.Add(lblItmAccTypeCode)
		Me.fraPrice.Controls.Add(txtItmUnitPrice)
		Me.fraPrice.Controls.Add(txtItmDefaultPrice)
		Me.fraPrice.Controls.Add(txtItmDiscount)
		Me.fraPrice.Controls.Add(txtItmMarkUp)
		Me.fraPrice.Controls.Add(txtItmBottomPrice)
		Me.fraPrice.Controls.Add(btnItemPrice)
		Me.fraPrice.Controls.Add(lblItmDefaultPrice)
		Me.fraPrice.Controls.Add(lblItmDiscount)
		Me.fraPrice.Controls.Add(lblItmPVdrCode)
		Me.fraPrice.Controls.Add(lblItmMarkUp)
		Me.fraPrice.Controls.Add(lblUnitPrice)
		Me.fraPrice.Controls.Add(lblItmCurrCode)
		Me.fraPrice.Controls.Add(lblItmBottomPrice)
		Me._tabDetailInfo_TabPage1.Controls.Add(fraContent)
		Me.fraContent.Controls.Add(txtItmMaxQty)
		Me.fraContent.Controls.Add(txtItmPORepuQty)
		Me.fraContent.Controls.Add(chkItmReorderInd)
		Me.fraContent.Controls.Add(chkItmInvItemFlg)
		Me.fraContent.Controls.Add(chkItmInActive)
		Me.fraContent.Controls.Add(txtItmReorderQty)
		Me.fraContent.Controls.Add(lblDspStkOnHand)
		Me.fraContent.Controls.Add(lblStkOnHand)
		Me.fraContent.Controls.Add(lblDspStkIndent)
		Me.fraContent.Controls.Add(lblStkIndent)
		Me.fraContent.Controls.Add(lblDspStkOnOrder)
		Me.fraContent.Controls.Add(lblStkOnOrder)
		Me.fraContent.Controls.Add(lblDspStkAllocated)
		Me.fraContent.Controls.Add(lblStkAllocated)
		Me.fraContent.Controls.Add(lblDspStkAvailable)
		Me.fraContent.Controls.Add(lblStkAvailable)
		Me.fraContent.Controls.Add(lblItmMaxQty)
		Me.fraContent.Controls.Add(lblItmPORepuQty)
		Me.fraContent.Controls.Add(lblItmReorderQty)
		Me._tabDetailInfo_TabPage2.Controls.Add(Frame3)
		Me._tabDetailInfo_TabPage2.Controls.Add(chkOwnEdition)
		Me._tabDetailInfo_TabPage2.Controls.Add(tblDetail)
		Me.Frame3.Controls.Add(lblKeyDesc)
		Me.Frame3.Controls.Add(lblComboPrompt)
		Me.Frame3.Controls.Add(lblInsertLine)
		Me.Frame3.Controls.Add(lblDeleteLine)
		Me.mnuPopUpSub.SetIndex(_mnuPopUpSub_0, CType(0, Short))
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPopUp})
		mnuPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuPopUpSub_0})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.fraHeaderInfo.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me.fraInfo.ResumeLayout(False)
		Me.fraPrice.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.fraContent.ResumeLayout(False)
		Me._tabDetailInfo_TabPage2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class