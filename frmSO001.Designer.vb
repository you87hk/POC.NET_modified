<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSO001
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
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button13 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button14 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button15 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button16 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents cboJobNo As System.Windows.Forms.ComboBox
	Public WithEvents cboCRML As System.Windows.Forms.ComboBox
	Public WithEvents cboCurr As System.Windows.Forms.ComboBox
	Public WithEvents txtDisAmt As System.Windows.Forms.TextBox
	Public WithEvents btnGetDisAmt As System.Windows.Forms.Button
	Public WithEvents txtSpecDis As System.Windows.Forms.TextBox
	Public WithEvents cboDocNo As System.Windows.Forms.ComboBox
	Public WithEvents cboCusCode As System.Windows.Forms.ComboBox
	Public WithEvents cboPayCode As System.Windows.Forms.ComboBox
	Public WithEvents cboPrcCode As System.Windows.Forms.ComboBox
	Public WithEvents cboMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents medReserveDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents medExpiryDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblExpiryDate As System.Windows.Forms.Label
	Public WithEvents lblReserveDate As System.Windows.Forms.Label
	Public WithEvents FraDate As System.Windows.Forms.GroupBox
	Public WithEvents txtJobCost As System.Windows.Forms.TextBox
	Public WithEvents txtShipFrom As System.Windows.Forms.TextBox
	Public WithEvents txtShipVia As System.Windows.Forms.TextBox
	Public WithEvents txtShipTo As System.Windows.Forms.TextBox
	Public WithEvents txtLcNo As System.Windows.Forms.TextBox
	Public WithEvents txtPortNo As System.Windows.Forms.TextBox
	Public WithEvents txtCusPo As System.Windows.Forms.TextBox
	Public WithEvents lblJobCost As System.Windows.Forms.Label
	Public WithEvents lblJobNo As System.Windows.Forms.Label
	Public WithEvents lblLcNo As System.Windows.Forms.Label
	Public WithEvents lblPortNo As System.Windows.Forms.Label
	Public WithEvents lblCusPo As System.Windows.Forms.Label
	Public WithEvents lblShipTo As System.Windows.Forms.Label
	Public WithEvents lblShipVia As System.Windows.Forms.Label
	Public WithEvents lblShipFrom As System.Windows.Forms.Label
	Public WithEvents fraInfo As System.Windows.Forms.GroupBox
	Public WithEvents lblDspCRMLDesc As System.Windows.Forms.Label
	Public WithEvents lblCRMl As System.Windows.Forms.Label
	Public WithEvents lblMlCode As System.Windows.Forms.Label
	Public WithEvents lblDspMLDesc As System.Windows.Forms.Label
	Public WithEvents lblPrcCode As System.Windows.Forms.Label
	Public WithEvents lblDspPrcDesc As System.Windows.Forms.Label
	Public WithEvents lblPayCode As System.Windows.Forms.Label
	Public WithEvents lblDspPayDesc As System.Windows.Forms.Label
	Public WithEvents lblSaleCode As System.Windows.Forms.Label
	Public WithEvents lblDspSaleDesc As System.Windows.Forms.Label
	Public WithEvents fraCode As System.Windows.Forms.GroupBox
	Public WithEvents txtExcr As System.Windows.Forms.TextBox
	Public WithEvents medDocDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblRefNo As System.Windows.Forms.Label
	Public WithEvents lblDspRefNo As System.Windows.Forms.Label
	Public WithEvents lblDspCusEMail As System.Windows.Forms.Label
	Public WithEvents lblCusEMail As System.Windows.Forms.Label
	Public WithEvents lblRevNo As System.Windows.Forms.Label
	Public WithEvents lblDspRevNo As System.Windows.Forms.Label
	Public WithEvents lblCusCode As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	Public WithEvents lblDocDate As System.Windows.Forms.Label
	Public WithEvents lblDspCusName As System.Windows.Forms.Label
	Public WithEvents LblCurr As System.Windows.Forms.Label
	Public WithEvents lblExcr As System.Windows.Forms.Label
	Public WithEvents lblDspCusTel As System.Windows.Forms.Label
	Public WithEvents lblCusName As System.Windows.Forms.Label
	Public WithEvents lblDspCusFax As System.Windows.Forms.Label
	Public WithEvents lblCusFax As System.Windows.Forms.Label
	Public WithEvents lblCusTel As System.Windows.Forms.Label
	Public WithEvents fraKey As System.Windows.Forms.GroupBox
	Public WithEvents lblDisAmt As System.Windows.Forms.Label
	Public WithEvents lblSpecDis As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents lblDspNetAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspGrsAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspTotalQty As System.Windows.Forms.Label
	Public WithEvents lblNetAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblGrsAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblTotalQty As System.Windows.Forms.Label
	Public WithEvents lblDisAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspDisAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspCstAmtOrg As System.Windows.Forms.Label
	Public WithEvents _lblCol_9 As System.Windows.Forms.Label
	Public WithEvents _lblCol_2 As System.Windows.Forms.Label
	Public WithEvents _lblCol_1 As System.Windows.Forms.Label
	Public WithEvents _lblCol_4 As System.Windows.Forms.Label
	Public WithEvents _lblCol_6 As System.Windows.Forms.Label
	Public WithEvents _lblCol_10 As System.Windows.Forms.Label
	Public WithEvents _lblCol_8 As System.Windows.Forms.Label
	Public WithEvents _lblCol_7 As System.Windows.Forms.Label
	Public WithEvents _lblCol_5 As System.Windows.Forms.Label
	Public WithEvents _lblCol_3 As System.Windows.Forms.Label
	Public WithEvents _lblCol_0 As System.Windows.Forms.Label
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblDeleteLine As System.Windows.Forms.Label
	Public WithEvents lblInsertLine As System.Windows.Forms.Label
	Public WithEvents lblComboPrompt As System.Windows.Forms.Label
	Public WithEvents lblKeyDesc As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents cboShipCode As System.Windows.Forms.ComboBox
	Public WithEvents txtShipAdr4 As System.Windows.Forms.TextBox
	Public WithEvents txtShipAdr3 As System.Windows.Forms.TextBox
	Public WithEvents txtShipAdr2 As System.Windows.Forms.TextBox
	Public WithEvents txtShipAdr1 As System.Windows.Forms.TextBox
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents txtShipName As System.Windows.Forms.TextBox
	Public WithEvents txtShipPer As System.Windows.Forms.TextBox
	Public WithEvents lblShipCode As System.Windows.Forms.Label
	Public WithEvents lblShipName As System.Windows.Forms.Label
	Public WithEvents lblShipPer As System.Windows.Forms.Label
	Public WithEvents lblShipAdr As System.Windows.Forms.Label
	Public WithEvents fraShip As System.Windows.Forms.GroupBox
	Public WithEvents cboRmkCode As System.Windows.Forms.ComboBox
	Public WithEvents _txtRmk_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_7 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_8 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_9 As System.Windows.Forms.TextBox
	Public WithEvents _txtRmk_10 As System.Windows.Forms.TextBox
	Public WithEvents picRmk As System.Windows.Forms.Panel
	Public WithEvents lblRmkCode As System.Windows.Forms.Label
	Public WithEvents lblRmk As System.Windows.Forms.Label
	Public WithEvents fraRmk As System.Windows.Forms.GroupBox
	Public WithEvents _tabDetailInfo_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	Public WithEvents lblCol As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents txtRmk As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSO001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button13 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button14 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button15 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button16 = New System.Windows.Forms.ToolStripButton
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.cboJobNo = New System.Windows.Forms.ComboBox
		Me.cboCRML = New System.Windows.Forms.ComboBox
		Me.cboCurr = New System.Windows.Forms.ComboBox
		Me.txtDisAmt = New System.Windows.Forms.TextBox
		Me.btnGetDisAmt = New System.Windows.Forms.Button
		Me.txtSpecDis = New System.Windows.Forms.TextBox
		Me.cboDocNo = New System.Windows.Forms.ComboBox
		Me.cboCusCode = New System.Windows.Forms.ComboBox
		Me.cboPayCode = New System.Windows.Forms.ComboBox
		Me.cboPrcCode = New System.Windows.Forms.ComboBox
		Me.cboMLCode = New System.Windows.Forms.ComboBox
		Me.cboSaleCode = New System.Windows.Forms.ComboBox
		Me.FraDate = New System.Windows.Forms.GroupBox
		Me.medReserveDate = New System.Windows.Forms.MaskedTextBox
		Me.medExpiryDate = New System.Windows.Forms.MaskedTextBox
		Me.lblExpiryDate = New System.Windows.Forms.Label
		Me.lblReserveDate = New System.Windows.Forms.Label
		Me.fraInfo = New System.Windows.Forms.GroupBox
		Me.txtJobCost = New System.Windows.Forms.TextBox
		Me.txtShipFrom = New System.Windows.Forms.TextBox
		Me.txtShipVia = New System.Windows.Forms.TextBox
		Me.txtShipTo = New System.Windows.Forms.TextBox
		Me.txtLcNo = New System.Windows.Forms.TextBox
		Me.txtPortNo = New System.Windows.Forms.TextBox
		Me.txtCusPo = New System.Windows.Forms.TextBox
		Me.lblJobCost = New System.Windows.Forms.Label
		Me.lblJobNo = New System.Windows.Forms.Label
		Me.lblLcNo = New System.Windows.Forms.Label
		Me.lblPortNo = New System.Windows.Forms.Label
		Me.lblCusPo = New System.Windows.Forms.Label
		Me.lblShipTo = New System.Windows.Forms.Label
		Me.lblShipVia = New System.Windows.Forms.Label
		Me.lblShipFrom = New System.Windows.Forms.Label
		Me.fraCode = New System.Windows.Forms.GroupBox
		Me.lblDspCRMLDesc = New System.Windows.Forms.Label
		Me.lblCRMl = New System.Windows.Forms.Label
		Me.lblMlCode = New System.Windows.Forms.Label
		Me.lblDspMLDesc = New System.Windows.Forms.Label
		Me.lblPrcCode = New System.Windows.Forms.Label
		Me.lblDspPrcDesc = New System.Windows.Forms.Label
		Me.lblPayCode = New System.Windows.Forms.Label
		Me.lblDspPayDesc = New System.Windows.Forms.Label
		Me.lblSaleCode = New System.Windows.Forms.Label
		Me.lblDspSaleDesc = New System.Windows.Forms.Label
		Me.fraKey = New System.Windows.Forms.GroupBox
		Me.txtExcr = New System.Windows.Forms.TextBox
		Me.medDocDate = New System.Windows.Forms.MaskedTextBox
		Me.lblRefNo = New System.Windows.Forms.Label
		Me.lblDspRefNo = New System.Windows.Forms.Label
		Me.lblDspCusEMail = New System.Windows.Forms.Label
		Me.lblCusEMail = New System.Windows.Forms.Label
		Me.lblRevNo = New System.Windows.Forms.Label
		Me.lblDspRevNo = New System.Windows.Forms.Label
		Me.lblCusCode = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.lblDocDate = New System.Windows.Forms.Label
		Me.lblDspCusName = New System.Windows.Forms.Label
		Me.LblCurr = New System.Windows.Forms.Label
		Me.lblExcr = New System.Windows.Forms.Label
		Me.lblDspCusTel = New System.Windows.Forms.Label
		Me.lblCusName = New System.Windows.Forms.Label
		Me.lblDspCusFax = New System.Windows.Forms.Label
		Me.lblCusFax = New System.Windows.Forms.Label
		Me.lblCusTel = New System.Windows.Forms.Label
		Me.lblDisAmt = New System.Windows.Forms.Label
		Me.lblSpecDis = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.lblDspNetAmtOrg = New System.Windows.Forms.Label
		Me.lblDspGrsAmtOrg = New System.Windows.Forms.Label
		Me.lblDspTotalQty = New System.Windows.Forms.Label
		Me.lblNetAmtOrg = New System.Windows.Forms.Label
		Me.lblGrsAmtOrg = New System.Windows.Forms.Label
		Me.lblTotalQty = New System.Windows.Forms.Label
		Me.lblDisAmtOrg = New System.Windows.Forms.Label
		Me.lblDspDisAmtOrg = New System.Windows.Forms.Label
		Me.lblDspCstAmtOrg = New System.Windows.Forms.Label
		Me._lblCol_9 = New System.Windows.Forms.Label
		Me._lblCol_2 = New System.Windows.Forms.Label
		Me._lblCol_1 = New System.Windows.Forms.Label
		Me._lblCol_4 = New System.Windows.Forms.Label
		Me._lblCol_6 = New System.Windows.Forms.Label
		Me._lblCol_10 = New System.Windows.Forms.Label
		Me._lblCol_8 = New System.Windows.Forms.Label
		Me._lblCol_7 = New System.Windows.Forms.Label
		Me._lblCol_5 = New System.Windows.Forms.Label
		Me._lblCol_3 = New System.Windows.Forms.Label
		Me._lblCol_0 = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblDeleteLine = New System.Windows.Forms.Label
		Me.lblInsertLine = New System.Windows.Forms.Label
		Me.lblComboPrompt = New System.Windows.Forms.Label
		Me.lblKeyDesc = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage2 = New System.Windows.Forms.TabPage
		Me.cboShipCode = New System.Windows.Forms.ComboBox
		Me.fraShip = New System.Windows.Forms.GroupBox
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.txtShipAdr4 = New System.Windows.Forms.TextBox
		Me.txtShipAdr3 = New System.Windows.Forms.TextBox
		Me.txtShipAdr2 = New System.Windows.Forms.TextBox
		Me.txtShipAdr1 = New System.Windows.Forms.TextBox
		Me.txtShipName = New System.Windows.Forms.TextBox
		Me.txtShipPer = New System.Windows.Forms.TextBox
		Me.lblShipCode = New System.Windows.Forms.Label
		Me.lblShipName = New System.Windows.Forms.Label
		Me.lblShipPer = New System.Windows.Forms.Label
		Me.lblShipAdr = New System.Windows.Forms.Label
		Me.cboRmkCode = New System.Windows.Forms.ComboBox
		Me.fraRmk = New System.Windows.Forms.GroupBox
		Me.picRmk = New System.Windows.Forms.Panel
		Me._txtRmk_2 = New System.Windows.Forms.TextBox
		Me._txtRmk_1 = New System.Windows.Forms.TextBox
		Me._txtRmk_3 = New System.Windows.Forms.TextBox
		Me._txtRmk_6 = New System.Windows.Forms.TextBox
		Me._txtRmk_4 = New System.Windows.Forms.TextBox
		Me._txtRmk_5 = New System.Windows.Forms.TextBox
		Me._txtRmk_7 = New System.Windows.Forms.TextBox
		Me._txtRmk_8 = New System.Windows.Forms.TextBox
		Me._txtRmk_9 = New System.Windows.Forms.TextBox
		Me._txtRmk_10 = New System.Windows.Forms.TextBox
		Me.lblRmkCode = New System.Windows.Forms.Label
		Me.lblRmk = New System.Windows.Forms.Label
		Me.lblCol = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.txtRmk = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me.FraDate.SuspendLayout()
		Me.fraInfo.SuspendLayout()
		Me.fraCode.SuspendLayout()
		Me.fraKey.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._tabDetailInfo_TabPage2.SuspendLayout()
		Me.fraShip.SuspendLayout()
		Me.Picture1.SuspendLayout()
		Me.fraRmk.SuspendLayout()
		Me.picRmk.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCol, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRmk, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "訂貨單"
		Me.ClientSize = New System.Drawing.Size(792, 597)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmSO001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSO001"
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
		Me.tblCommon.Location = New System.Drawing.Point(728, 192)
		Me.tblCommon.TabIndex = 41
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
		Me.iglProcess.Images.SetKeyName(12, "")
		Me.iglProcess.Images.SetKeyName(13, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(792, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 24)
		Me.tbrProcess.TabIndex = 42
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
		Me._tbrProcess_Button5.Name = "Delete"
		Me._tbrProcess_Button5.ToolTipText = "Delete (F3)"
		Me._tbrProcess_Button5.ImageIndex = 2
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Revise"
		Me._tbrProcess_Button6.ImageIndex = 13
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Save"
		Me._tbrProcess_Button8.ToolTipText = "Save (F10)"
		Me._tbrProcess_Button8.ImageIndex = 3
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.Name = "Cancel"
		Me._tbrProcess_Button9.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button9.ImageIndex = 4
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Visible = 0
		Me._tbrProcess_Button11.Name = "Find"
		Me._tbrProcess_Button11.ToolTipText = "Find (F9)"
		Me._tbrProcess_Button11.ImageIndex = 6
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "Refresh"
		Me._tbrProcess_Button12.ImageIndex = 7
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button13.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button13.AutoSize = False
		Me._tbrProcess_Button13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button13.Name = "Print"
		Me._tbrProcess_Button13.ImageIndex = 12
		Me._tbrProcess_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button14.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button14.AutoSize = False
		Me._tbrProcess_Button14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button14.Name = "Appendix"
		Me._tbrProcess_Button14.ImageIndex = 9
		Me._tbrProcess_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button15.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button15.AutoSize = False
		Me._tbrProcess_Button15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button16.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button16.AutoSize = False
		Me._tbrProcess_Button16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button16.Name = "Exit"
		Me._tbrProcess_Button16.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button16.ImageIndex = 8
		Me._tbrProcess_Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tabDetailInfo.Size = New System.Drawing.Size(793, 537)
		Me.tabDetailInfo.Location = New System.Drawing.Point(0, 56)
		Me.tabDetailInfo.TabIndex = 43
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.SelectedIndex = 1
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "Header Information"
		Me.cboJobNo.Size = New System.Drawing.Size(134, 20)
		Me.cboJobNo.Location = New System.Drawing.Point(416, 320)
		Me.cboJobNo.TabIndex = 14
		Me.cboJobNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboJobNo.BackColor = System.Drawing.SystemColors.Window
		Me.cboJobNo.CausesValidation = True
		Me.cboJobNo.Enabled = True
		Me.cboJobNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboJobNo.IntegralHeight = True
		Me.cboJobNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboJobNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboJobNo.Sorted = False
		Me.cboJobNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboJobNo.TabStop = True
		Me.cboJobNo.Visible = True
		Me.cboJobNo.Name = "cboJobNo"
		Me.cboCRML.Size = New System.Drawing.Size(158, 20)
		Me.cboCRML.Location = New System.Drawing.Point(120, 264)
		Me.cboCRML.TabIndex = 8
		Me.cboCRML.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCRML.BackColor = System.Drawing.SystemColors.Window
		Me.cboCRML.CausesValidation = True
		Me.cboCRML.Enabled = True
		Me.cboCRML.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCRML.IntegralHeight = True
		Me.cboCRML.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCRML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCRML.Sorted = False
		Me.cboCRML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCRML.TabStop = True
		Me.cboCRML.Visible = True
		Me.cboCRML.Name = "cboCRML"
		Me.cboCurr.Size = New System.Drawing.Size(89, 20)
		Me.cboCurr.Location = New System.Drawing.Point(632, 87)
		Me.cboCurr.TabIndex = 106
		Me.cboCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCurr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCurr.CausesValidation = True
		Me.cboCurr.Enabled = True
		Me.cboCurr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCurr.IntegralHeight = True
		Me.cboCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCurr.Sorted = False
		Me.cboCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCurr.TabStop = True
		Me.cboCurr.Visible = True
		Me.cboCurr.Name = "cboCurr"
		Me.txtDisAmt.AutoSize = False
		Me.txtDisAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDisAmt.Size = New System.Drawing.Size(137, 20)
		Me.txtDisAmt.Location = New System.Drawing.Point(128, 400)
		Me.txtDisAmt.Maxlength = 20
		Me.txtDisAmt.TabIndex = 12
		Me.txtDisAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDisAmt.AcceptsReturn = True
		Me.txtDisAmt.BackColor = System.Drawing.SystemColors.Window
		Me.txtDisAmt.CausesValidation = True
		Me.txtDisAmt.Enabled = True
		Me.txtDisAmt.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDisAmt.HideSelection = True
		Me.txtDisAmt.ReadOnly = False
		Me.txtDisAmt.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDisAmt.MultiLine = False
		Me.txtDisAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDisAmt.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDisAmt.TabStop = True
		Me.txtDisAmt.Visible = True
		Me.txtDisAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDisAmt.Name = "txtDisAmt"
		Me.btnGetDisAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnGetDisAmt.Text = "Command1"
		Me.btnGetDisAmt.Size = New System.Drawing.Size(129, 25)
		Me.btnGetDisAmt.Location = New System.Drawing.Point(128, 424)
		Me.btnGetDisAmt.Image = CType(resources.GetObject("btnGetDisAmt.Image"), System.Drawing.Image)
		Me.btnGetDisAmt.TabIndex = 13
		Me.btnGetDisAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGetDisAmt.BackColor = System.Drawing.SystemColors.Control
		Me.btnGetDisAmt.CausesValidation = True
		Me.btnGetDisAmt.Enabled = True
		Me.btnGetDisAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnGetDisAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnGetDisAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnGetDisAmt.TabStop = True
		Me.btnGetDisAmt.Name = "btnGetDisAmt"
		Me.txtSpecDis.AutoSize = False
		Me.txtSpecDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtSpecDis.Size = New System.Drawing.Size(89, 20)
		Me.txtSpecDis.Location = New System.Drawing.Point(128, 376)
		Me.txtSpecDis.Maxlength = 20
		Me.txtSpecDis.TabIndex = 11
		Me.txtSpecDis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSpecDis.AcceptsReturn = True
		Me.txtSpecDis.BackColor = System.Drawing.SystemColors.Window
		Me.txtSpecDis.CausesValidation = True
		Me.txtSpecDis.Enabled = True
		Me.txtSpecDis.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSpecDis.HideSelection = True
		Me.txtSpecDis.ReadOnly = False
		Me.txtSpecDis.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSpecDis.MultiLine = False
		Me.txtSpecDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSpecDis.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSpecDis.TabStop = True
		Me.txtSpecDis.Visible = True
		Me.txtSpecDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSpecDis.Name = "txtSpecDis"
		Me.cboDocNo.Size = New System.Drawing.Size(129, 20)
		Me.cboDocNo.Location = New System.Drawing.Point(120, 28)
		Me.cboDocNo.TabIndex = 0
		Me.cboDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNo.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNo.CausesValidation = True
		Me.cboDocNo.Enabled = True
		Me.cboDocNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNo.IntegralHeight = True
		Me.cboDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNo.Sorted = False
		Me.cboDocNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNo.TabStop = True
		Me.cboDocNo.Visible = True
		Me.cboDocNo.Name = "cboDocNo"
		Me.cboCusCode.Size = New System.Drawing.Size(129, 20)
		Me.cboCusCode.Location = New System.Drawing.Point(120, 52)
		Me.cboCusCode.TabIndex = 2
		Me.cboCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusCode.CausesValidation = True
		Me.cboCusCode.Enabled = True
		Me.cboCusCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusCode.IntegralHeight = True
		Me.cboCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusCode.Sorted = False
		Me.cboCusCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusCode.TabStop = True
		Me.cboCusCode.Visible = True
		Me.cboCusCode.Name = "cboCusCode"
		Me.cboPayCode.Size = New System.Drawing.Size(158, 20)
		Me.cboPayCode.Location = New System.Drawing.Point(120, 192)
		Me.cboPayCode.TabIndex = 5
		Me.cboPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPayCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboPayCode.CausesValidation = True
		Me.cboPayCode.Enabled = True
		Me.cboPayCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPayCode.IntegralHeight = True
		Me.cboPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPayCode.Sorted = False
		Me.cboPayCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPayCode.TabStop = True
		Me.cboPayCode.Visible = True
		Me.cboPayCode.Name = "cboPayCode"
		Me.cboPrcCode.Size = New System.Drawing.Size(158, 20)
		Me.cboPrcCode.Location = New System.Drawing.Point(120, 216)
		Me.cboPrcCode.TabIndex = 6
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
		Me.cboMLCode.Size = New System.Drawing.Size(158, 20)
		Me.cboMLCode.Location = New System.Drawing.Point(120, 240)
		Me.cboMLCode.TabIndex = 7
		Me.cboMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboMLCode.CausesValidation = True
		Me.cboMLCode.Enabled = True
		Me.cboMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMLCode.IntegralHeight = True
		Me.cboMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMLCode.Sorted = False
		Me.cboMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboMLCode.TabStop = True
		Me.cboMLCode.Visible = True
		Me.cboMLCode.Name = "cboMLCode"
		Me.cboSaleCode.Size = New System.Drawing.Size(158, 20)
		Me.cboSaleCode.Location = New System.Drawing.Point(120, 168)
		Me.cboSaleCode.TabIndex = 4
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
		Me.FraDate.Size = New System.Drawing.Size(265, 73)
		Me.FraDate.Location = New System.Drawing.Point(8, 296)
		Me.FraDate.TabIndex = 51
		Me.FraDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraDate.BackColor = System.Drawing.SystemColors.Control
		Me.FraDate.Enabled = True
		Me.FraDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraDate.Visible = True
		Me.FraDate.Padding = New System.Windows.Forms.Padding(0)
		Me.FraDate.Name = "FraDate"
		Me.medReserveDate.AllowPromptAsInput = False
		Me.medReserveDate.Size = New System.Drawing.Size(81, 19)
		Me.medReserveDate.Location = New System.Drawing.Point(120, 20)
		Me.medReserveDate.TabIndex = 9
		Me.medReserveDate.MaxLength = 10
		Me.medReserveDate.Mask = "##/##/####"
		Me.medReserveDate.PromptChar = "_"
		Me.medReserveDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medReserveDate.Name = "medReserveDate"
		Me.medExpiryDate.AllowPromptAsInput = False
		Me.medExpiryDate.Size = New System.Drawing.Size(81, 19)
		Me.medExpiryDate.Location = New System.Drawing.Point(120, 44)
		Me.medExpiryDate.TabIndex = 10
		Me.medExpiryDate.MaxLength = 10
		Me.medExpiryDate.Mask = "##/##/####"
		Me.medExpiryDate.PromptChar = "_"
		Me.medExpiryDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medExpiryDate.Name = "medExpiryDate"
		Me.lblExpiryDate.Text = "ETADATE"
		Me.lblExpiryDate.Size = New System.Drawing.Size(96, 17)
		Me.lblExpiryDate.Location = New System.Drawing.Point(16, 44)
		Me.lblExpiryDate.TabIndex = 53
		Me.lblExpiryDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblExpiryDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblExpiryDate.Enabled = True
		Me.lblExpiryDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblExpiryDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblExpiryDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblExpiryDate.UseMnemonic = True
		Me.lblExpiryDate.Visible = True
		Me.lblExpiryDate.AutoSize = False
		Me.lblExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblExpiryDate.Name = "lblExpiryDate"
		Me.lblReserveDate.Text = "ONDATE"
		Me.lblReserveDate.Size = New System.Drawing.Size(96, 17)
		Me.lblReserveDate.Location = New System.Drawing.Point(16, 20)
		Me.lblReserveDate.TabIndex = 52
		Me.lblReserveDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblReserveDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblReserveDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblReserveDate.Enabled = True
		Me.lblReserveDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblReserveDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblReserveDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblReserveDate.UseMnemonic = True
		Me.lblReserveDate.Visible = True
		Me.lblReserveDate.AutoSize = False
		Me.lblReserveDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblReserveDate.Name = "lblReserveDate"
		Me.fraInfo.Size = New System.Drawing.Size(505, 209)
		Me.fraInfo.Location = New System.Drawing.Point(280, 296)
		Me.fraInfo.TabIndex = 44
		Me.fraInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraInfo.Enabled = True
		Me.fraInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraInfo.Visible = True
		Me.fraInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraInfo.Name = "fraInfo"
		Me.txtJobCost.AutoSize = False
		Me.txtJobCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtJobCost.Size = New System.Drawing.Size(113, 20)
		Me.txtJobCost.Location = New System.Drawing.Point(376, 24)
		Me.txtJobCost.Maxlength = 20
		Me.txtJobCost.TabIndex = 15
		Me.txtJobCost.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtJobCost.AcceptsReturn = True
		Me.txtJobCost.BackColor = System.Drawing.SystemColors.Window
		Me.txtJobCost.CausesValidation = True
		Me.txtJobCost.Enabled = True
		Me.txtJobCost.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtJobCost.HideSelection = True
		Me.txtJobCost.ReadOnly = False
		Me.txtJobCost.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtJobCost.MultiLine = False
		Me.txtJobCost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtJobCost.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtJobCost.TabStop = True
		Me.txtJobCost.Visible = True
		Me.txtJobCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtJobCost.Name = "txtJobCost"
		Me.txtShipFrom.AutoSize = False
		Me.txtShipFrom.Enabled = False
		Me.txtShipFrom.Size = New System.Drawing.Size(351, 20)
		Me.txtShipFrom.Location = New System.Drawing.Point(136, 56)
		Me.txtShipFrom.TabIndex = 16
		Me.txtShipFrom.Text = "0123456789012345789"
		Me.txtShipFrom.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipFrom.AcceptsReturn = True
		Me.txtShipFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipFrom.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipFrom.CausesValidation = True
		Me.txtShipFrom.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipFrom.HideSelection = True
		Me.txtShipFrom.ReadOnly = False
		Me.txtShipFrom.Maxlength = 0
		Me.txtShipFrom.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipFrom.MultiLine = False
		Me.txtShipFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipFrom.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipFrom.TabStop = True
		Me.txtShipFrom.Visible = True
		Me.txtShipFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipFrom.Name = "txtShipFrom"
		Me.txtShipVia.AutoSize = False
		Me.txtShipVia.Enabled = False
		Me.txtShipVia.Size = New System.Drawing.Size(351, 20)
		Me.txtShipVia.Location = New System.Drawing.Point(136, 96)
		Me.txtShipVia.TabIndex = 18
		Me.txtShipVia.Text = "0123456789012345789"
		Me.txtShipVia.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipVia.AcceptsReturn = True
		Me.txtShipVia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipVia.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipVia.CausesValidation = True
		Me.txtShipVia.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipVia.HideSelection = True
		Me.txtShipVia.ReadOnly = False
		Me.txtShipVia.Maxlength = 0
		Me.txtShipVia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipVia.MultiLine = False
		Me.txtShipVia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipVia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipVia.TabStop = True
		Me.txtShipVia.Visible = True
		Me.txtShipVia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipVia.Name = "txtShipVia"
		Me.txtShipTo.AutoSize = False
		Me.txtShipTo.Enabled = False
		Me.txtShipTo.Size = New System.Drawing.Size(351, 20)
		Me.txtShipTo.Location = New System.Drawing.Point(136, 76)
		Me.txtShipTo.TabIndex = 17
		Me.txtShipTo.Text = "0123456789012345789"
		Me.txtShipTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipTo.AcceptsReturn = True
		Me.txtShipTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipTo.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipTo.CausesValidation = True
		Me.txtShipTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipTo.HideSelection = True
		Me.txtShipTo.ReadOnly = False
		Me.txtShipTo.Maxlength = 0
		Me.txtShipTo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipTo.MultiLine = False
		Me.txtShipTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipTo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipTo.TabStop = True
		Me.txtShipTo.Visible = True
		Me.txtShipTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipTo.Name = "txtShipTo"
		Me.txtLcNo.AutoSize = False
		Me.txtLcNo.Enabled = False
		Me.txtLcNo.Size = New System.Drawing.Size(351, 20)
		Me.txtLcNo.Location = New System.Drawing.Point(136, 152)
		Me.txtLcNo.TabIndex = 20
		Me.txtLcNo.Text = "0123456789012345789"
		Me.txtLcNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLcNo.AcceptsReturn = True
		Me.txtLcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtLcNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtLcNo.CausesValidation = True
		Me.txtLcNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLcNo.HideSelection = True
		Me.txtLcNo.ReadOnly = False
		Me.txtLcNo.Maxlength = 0
		Me.txtLcNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLcNo.MultiLine = False
		Me.txtLcNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLcNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLcNo.TabStop = True
		Me.txtLcNo.Visible = True
		Me.txtLcNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLcNo.Name = "txtLcNo"
		Me.txtPortNo.AutoSize = False
		Me.txtPortNo.Enabled = False
		Me.txtPortNo.Size = New System.Drawing.Size(351, 20)
		Me.txtPortNo.Location = New System.Drawing.Point(136, 176)
		Me.txtPortNo.TabIndex = 21
		Me.txtPortNo.Text = "0123456789012345789"
		Me.txtPortNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPortNo.AcceptsReturn = True
		Me.txtPortNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPortNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtPortNo.CausesValidation = True
		Me.txtPortNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPortNo.HideSelection = True
		Me.txtPortNo.ReadOnly = False
		Me.txtPortNo.Maxlength = 0
		Me.txtPortNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPortNo.MultiLine = False
		Me.txtPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPortNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPortNo.TabStop = True
		Me.txtPortNo.Visible = True
		Me.txtPortNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPortNo.Name = "txtPortNo"
		Me.txtCusPo.AutoSize = False
		Me.txtCusPo.Enabled = False
		Me.txtCusPo.Size = New System.Drawing.Size(351, 20)
		Me.txtCusPo.Location = New System.Drawing.Point(136, 128)
		Me.txtCusPo.TabIndex = 19
		Me.txtCusPo.Text = "0123456789012345789"
		Me.txtCusPo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusPo.AcceptsReturn = True
		Me.txtCusPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusPo.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusPo.CausesValidation = True
		Me.txtCusPo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusPo.HideSelection = True
		Me.txtCusPo.ReadOnly = False
		Me.txtCusPo.Maxlength = 0
		Me.txtCusPo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusPo.MultiLine = False
		Me.txtCusPo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusPo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusPo.TabStop = True
		Me.txtCusPo.Visible = True
		Me.txtCusPo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusPo.Name = "txtCusPo"
		Me.lblJobCost.Text = "PORTNO"
		Me.lblJobCost.Size = New System.Drawing.Size(92, 16)
		Me.lblJobCost.Location = New System.Drawing.Point(280, 24)
		Me.lblJobCost.TabIndex = 122
		Me.lblJobCost.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobCost.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblJobCost.BackColor = System.Drawing.SystemColors.Control
		Me.lblJobCost.Enabled = True
		Me.lblJobCost.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblJobCost.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblJobCost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblJobCost.UseMnemonic = True
		Me.lblJobCost.Visible = True
		Me.lblJobCost.AutoSize = False
		Me.lblJobCost.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblJobCost.Name = "lblJobCost"
		Me.lblJobNo.Text = "MLCODE"
		Me.lblJobNo.Size = New System.Drawing.Size(103, 16)
		Me.lblJobNo.Location = New System.Drawing.Point(8, 24)
		Me.lblJobNo.TabIndex = 121
		Me.lblJobNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblJobNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblJobNo.Enabled = True
		Me.lblJobNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblJobNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblJobNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblJobNo.UseMnemonic = True
		Me.lblJobNo.Visible = True
		Me.lblJobNo.AutoSize = False
		Me.lblJobNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblJobNo.Name = "lblJobNo"
		Me.lblLcNo.Text = "LCNO"
		Me.lblLcNo.Size = New System.Drawing.Size(140, 16)
		Me.lblLcNo.Location = New System.Drawing.Point(8, 152)
		Me.lblLcNo.TabIndex = 50
		Me.lblLcNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLcNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLcNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblLcNo.Enabled = True
		Me.lblLcNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLcNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLcNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLcNo.UseMnemonic = True
		Me.lblLcNo.Visible = True
		Me.lblLcNo.AutoSize = False
		Me.lblLcNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLcNo.Name = "lblLcNo"
		Me.lblPortNo.Text = "PORTNO"
		Me.lblPortNo.Size = New System.Drawing.Size(140, 16)
		Me.lblPortNo.Location = New System.Drawing.Point(8, 176)
		Me.lblPortNo.TabIndex = 49
		Me.lblPortNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPortNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPortNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblPortNo.Enabled = True
		Me.lblPortNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPortNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPortNo.UseMnemonic = True
		Me.lblPortNo.Visible = True
		Me.lblPortNo.AutoSize = False
		Me.lblPortNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPortNo.Name = "lblPortNo"
		Me.lblCusPo.Text = "CUSPO"
		Me.lblCusPo.Size = New System.Drawing.Size(140, 16)
		Me.lblCusPo.Location = New System.Drawing.Point(8, 128)
		Me.lblCusPo.TabIndex = 48
		Me.lblCusPo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusPo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusPo.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusPo.Enabled = True
		Me.lblCusPo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusPo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusPo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusPo.UseMnemonic = True
		Me.lblCusPo.Visible = True
		Me.lblCusPo.AutoSize = False
		Me.lblCusPo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusPo.Name = "lblCusPo"
		Me.lblShipTo.Text = "SHIPTO"
		Me.lblShipTo.Size = New System.Drawing.Size(140, 16)
		Me.lblShipTo.Location = New System.Drawing.Point(8, 80)
		Me.lblShipTo.TabIndex = 47
		Me.lblShipTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipTo.Enabled = True
		Me.lblShipTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipTo.UseMnemonic = True
		Me.lblShipTo.Visible = True
		Me.lblShipTo.AutoSize = False
		Me.lblShipTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipTo.Name = "lblShipTo"
		Me.lblShipVia.Text = "SHIPVIA"
		Me.lblShipVia.Size = New System.Drawing.Size(140, 16)
		Me.lblShipVia.Location = New System.Drawing.Point(8, 104)
		Me.lblShipVia.TabIndex = 46
		Me.lblShipVia.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipVia.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipVia.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipVia.Enabled = True
		Me.lblShipVia.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipVia.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipVia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipVia.UseMnemonic = True
		Me.lblShipVia.Visible = True
		Me.lblShipVia.AutoSize = False
		Me.lblShipVia.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipVia.Name = "lblShipVia"
		Me.lblShipFrom.Text = "SHIPFROM"
		Me.lblShipFrom.Size = New System.Drawing.Size(140, 16)
		Me.lblShipFrom.Location = New System.Drawing.Point(8, 56)
		Me.lblShipFrom.TabIndex = 45
		Me.lblShipFrom.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipFrom.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipFrom.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipFrom.Enabled = True
		Me.lblShipFrom.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipFrom.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipFrom.UseMnemonic = True
		Me.lblShipFrom.Visible = True
		Me.lblShipFrom.AutoSize = False
		Me.lblShipFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipFrom.Name = "lblShipFrom"
		Me.fraCode.Size = New System.Drawing.Size(777, 137)
		Me.fraCode.Location = New System.Drawing.Point(8, 152)
		Me.fraCode.TabIndex = 60
		Me.fraCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCode.BackColor = System.Drawing.SystemColors.Control
		Me.fraCode.Enabled = True
		Me.fraCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCode.Visible = True
		Me.fraCode.Padding = New System.Windows.Forms.Padding(0)
		Me.fraCode.Name = "fraCode"
		Me.lblDspCRMLDesc.Size = New System.Drawing.Size(489, 20)
		Me.lblDspCRMLDesc.Location = New System.Drawing.Point(272, 112)
		Me.lblDspCRMLDesc.TabIndex = 108
		Me.lblDspCRMLDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCRMLDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCRMLDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCRMLDesc.Enabled = True
		Me.lblDspCRMLDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCRMLDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCRMLDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCRMLDesc.UseMnemonic = True
		Me.lblDspCRMLDesc.Visible = True
		Me.lblDspCRMLDesc.AutoSize = False
		Me.lblDspCRMLDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCRMLDesc.Name = "lblDspCRMLDesc"
		Me.lblCRMl.Text = "MLCODE"
		Me.lblCRMl.Size = New System.Drawing.Size(103, 16)
		Me.lblCRMl.Location = New System.Drawing.Point(8, 116)
		Me.lblCRMl.TabIndex = 107
		Me.lblCRMl.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCRMl.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCRMl.BackColor = System.Drawing.SystemColors.Control
		Me.lblCRMl.Enabled = True
		Me.lblCRMl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCRMl.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCRMl.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCRMl.UseMnemonic = True
		Me.lblCRMl.Visible = True
		Me.lblCRMl.AutoSize = False
		Me.lblCRMl.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCRMl.Name = "lblCRMl"
		Me.lblMlCode.Text = "MLCODE"
		Me.lblMlCode.Size = New System.Drawing.Size(103, 16)
		Me.lblMlCode.Location = New System.Drawing.Point(8, 92)
		Me.lblMlCode.TabIndex = 68
		Me.lblMlCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMlCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMlCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblMlCode.Enabled = True
		Me.lblMlCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMlCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMlCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMlCode.UseMnemonic = True
		Me.lblMlCode.Visible = True
		Me.lblMlCode.AutoSize = False
		Me.lblMlCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMlCode.Name = "lblMlCode"
		Me.lblDspMLDesc.Size = New System.Drawing.Size(489, 20)
		Me.lblDspMLDesc.Location = New System.Drawing.Point(272, 88)
		Me.lblDspMLDesc.TabIndex = 67
		Me.lblDspMLDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspMLDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspMLDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspMLDesc.Enabled = True
		Me.lblDspMLDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspMLDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspMLDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspMLDesc.UseMnemonic = True
		Me.lblDspMLDesc.Visible = True
		Me.lblDspMLDesc.AutoSize = False
		Me.lblDspMLDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspMLDesc.Name = "lblDspMLDesc"
		Me.lblPrcCode.Text = "PRCCODE"
		Me.lblPrcCode.Size = New System.Drawing.Size(103, 16)
		Me.lblPrcCode.Location = New System.Drawing.Point(8, 68)
		Me.lblPrcCode.TabIndex = 66
		Me.lblPrcCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.lblDspPrcDesc.Size = New System.Drawing.Size(489, 20)
		Me.lblDspPrcDesc.Location = New System.Drawing.Point(272, 64)
		Me.lblDspPrcDesc.TabIndex = 65
		Me.lblDspPrcDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPrcDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPrcDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPrcDesc.Enabled = True
		Me.lblDspPrcDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPrcDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPrcDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPrcDesc.UseMnemonic = True
		Me.lblDspPrcDesc.Visible = True
		Me.lblDspPrcDesc.AutoSize = False
		Me.lblDspPrcDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPrcDesc.Name = "lblDspPrcDesc"
		Me.lblPayCode.Text = "PAYCODE"
		Me.lblPayCode.Size = New System.Drawing.Size(103, 16)
		Me.lblPayCode.Location = New System.Drawing.Point(8, 44)
		Me.lblPayCode.TabIndex = 64
		Me.lblPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayCode.Enabled = True
		Me.lblPayCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayCode.UseMnemonic = True
		Me.lblPayCode.Visible = True
		Me.lblPayCode.AutoSize = False
		Me.lblPayCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayCode.Name = "lblPayCode"
		Me.lblDspPayDesc.Size = New System.Drawing.Size(489, 20)
		Me.lblDspPayDesc.Location = New System.Drawing.Point(272, 40)
		Me.lblDspPayDesc.TabIndex = 63
		Me.lblDspPayDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPayDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPayDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPayDesc.Enabled = True
		Me.lblDspPayDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPayDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPayDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPayDesc.UseMnemonic = True
		Me.lblDspPayDesc.Visible = True
		Me.lblDspPayDesc.AutoSize = False
		Me.lblDspPayDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPayDesc.Name = "lblDspPayDesc"
		Me.lblSaleCode.Text = "SALECODE"
		Me.lblSaleCode.Size = New System.Drawing.Size(103, 16)
		Me.lblSaleCode.Location = New System.Drawing.Point(8, 20)
		Me.lblSaleCode.TabIndex = 62
		Me.lblSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.lblDspSaleDesc.Size = New System.Drawing.Size(489, 20)
		Me.lblDspSaleDesc.Location = New System.Drawing.Point(272, 16)
		Me.lblDspSaleDesc.TabIndex = 61
		Me.lblDspSaleDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspSaleDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspSaleDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspSaleDesc.Enabled = True
		Me.lblDspSaleDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspSaleDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspSaleDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspSaleDesc.UseMnemonic = True
		Me.lblDspSaleDesc.Visible = True
		Me.lblDspSaleDesc.AutoSize = False
		Me.lblDspSaleDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspSaleDesc.Name = "lblDspSaleDesc"
		Me.fraKey.Size = New System.Drawing.Size(729, 145)
		Me.fraKey.Location = New System.Drawing.Point(8, 8)
		Me.fraKey.TabIndex = 79
		Me.fraKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraKey.BackColor = System.Drawing.SystemColors.Control
		Me.fraKey.Enabled = True
		Me.fraKey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraKey.Visible = True
		Me.fraKey.Padding = New System.Windows.Forms.Padding(0)
		Me.fraKey.Name = "fraKey"
		Me.txtExcr.AutoSize = False
		Me.txtExcr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtExcr.Size = New System.Drawing.Size(89, 20)
		Me.txtExcr.Location = New System.Drawing.Point(624, 104)
		Me.txtExcr.Maxlength = 20
		Me.txtExcr.TabIndex = 3
		Me.txtExcr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExcr.AcceptsReturn = True
		Me.txtExcr.BackColor = System.Drawing.SystemColors.Window
		Me.txtExcr.CausesValidation = True
		Me.txtExcr.Enabled = True
		Me.txtExcr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExcr.HideSelection = True
		Me.txtExcr.ReadOnly = False
		Me.txtExcr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExcr.MultiLine = False
		Me.txtExcr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExcr.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExcr.TabStop = True
		Me.txtExcr.Visible = True
		Me.txtExcr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExcr.Name = "txtExcr"
		Me.medDocDate.AllowPromptAsInput = False
		Me.medDocDate.Size = New System.Drawing.Size(89, 19)
		Me.medDocDate.Location = New System.Drawing.Point(624, 52)
		Me.medDocDate.TabIndex = 1
		Me.medDocDate.MaxLength = 10
		Me.medDocDate.Mask = "##/##/####"
		Me.medDocDate.PromptChar = "_"
		Me.medDocDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDocDate.Name = "medDocDate"
		Me.lblRefNo.Text = "CUSTEL"
		Me.lblRefNo.Size = New System.Drawing.Size(113, 17)
		Me.lblRefNo.Location = New System.Drawing.Point(464, 24)
		Me.lblRefNo.TabIndex = 105
		Me.lblRefNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRefNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRefNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblRefNo.Enabled = True
		Me.lblRefNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRefNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRefNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRefNo.UseMnemonic = True
		Me.lblRefNo.Visible = True
		Me.lblRefNo.AutoSize = False
		Me.lblRefNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRefNo.Name = "lblRefNo"
		Me.lblDspRefNo.Size = New System.Drawing.Size(129, 20)
		Me.lblDspRefNo.Location = New System.Drawing.Point(584, 24)
		Me.lblDspRefNo.TabIndex = 104
		Me.lblDspRefNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspRefNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspRefNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspRefNo.Enabled = True
		Me.lblDspRefNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspRefNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspRefNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspRefNo.UseMnemonic = True
		Me.lblDspRefNo.Visible = True
		Me.lblDspRefNo.AutoSize = False
		Me.lblDspRefNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspRefNo.Name = "lblDspRefNo"
		Me.lblDspCusEMail.Size = New System.Drawing.Size(369, 20)
		Me.lblDspCusEMail.Location = New System.Drawing.Point(112, 120)
		Me.lblDspCusEMail.TabIndex = 102
		Me.lblDspCusEMail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusEMail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusEMail.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusEMail.Enabled = True
		Me.lblDspCusEMail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusEMail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusEMail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusEMail.UseMnemonic = True
		Me.lblDspCusEMail.Visible = True
		Me.lblDspCusEMail.AutoSize = False
		Me.lblDspCusEMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusEMail.Name = "lblDspCusEMail"
		Me.lblCusEMail.Text = "CUSNAME"
		Me.lblCusEMail.Size = New System.Drawing.Size(105, 17)
		Me.lblCusEMail.Location = New System.Drawing.Point(8, 124)
		Me.lblCusEMail.TabIndex = 101
		Me.lblCusEMail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusEMail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusEMail.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusEMail.Enabled = True
		Me.lblCusEMail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusEMail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusEMail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusEMail.UseMnemonic = True
		Me.lblCusEMail.Visible = True
		Me.lblCusEMail.AutoSize = False
		Me.lblCusEMail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusEMail.Name = "lblCusEMail"
		Me.lblRevNo.Text = "CUSFAX"
		Me.lblRevNo.Size = New System.Drawing.Size(49, 17)
		Me.lblRevNo.Location = New System.Drawing.Point(248, 24)
		Me.lblRevNo.TabIndex = 100
		Me.lblRevNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRevNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRevNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblRevNo.Enabled = True
		Me.lblRevNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRevNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRevNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRevNo.UseMnemonic = True
		Me.lblRevNo.Visible = True
		Me.lblRevNo.AutoSize = False
		Me.lblRevNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRevNo.Name = "lblRevNo"
		Me.lblDspRevNo.Size = New System.Drawing.Size(25, 20)
		Me.lblDspRevNo.Location = New System.Drawing.Point(312, 24)
		Me.lblDspRevNo.TabIndex = 99
		Me.lblDspRevNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspRevNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspRevNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspRevNo.Enabled = True
		Me.lblDspRevNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspRevNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspRevNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspRevNo.UseMnemonic = True
		Me.lblDspRevNo.Visible = True
		Me.lblDspRevNo.AutoSize = False
		Me.lblDspRevNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspRevNo.Name = "lblDspRevNo"
		Me.lblCusCode.Text = "CUSCODE"
		Me.lblCusCode.Size = New System.Drawing.Size(105, 17)
		Me.lblCusCode.Location = New System.Drawing.Point(8, 48)
		Me.lblCusCode.TabIndex = 90
		Me.lblCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCode.Enabled = True
		Me.lblCusCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCode.UseMnemonic = True
		Me.lblCusCode.Visible = True
		Me.lblCusCode.AutoSize = False
		Me.lblCusCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCode.Name = "lblCusCode"
		Me.lblDocNo.Text = "DOCNO"
		Me.lblDocNo.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDocNo.Size = New System.Drawing.Size(105, 17)
		Me.lblDocNo.Location = New System.Drawing.Point(8, 24)
		Me.lblDocNo.TabIndex = 89
		Me.lblDocNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNo.Enabled = True
		Me.lblDocNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNo.UseMnemonic = True
		Me.lblDocNo.Visible = True
		Me.lblDocNo.AutoSize = False
		Me.lblDocNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNo.Name = "lblDocNo"
		Me.lblDocDate.Text = "DOCDATE"
		Me.lblDocDate.Size = New System.Drawing.Size(112, 17)
		Me.lblDocDate.Location = New System.Drawing.Point(491, 56)
		Me.lblDocDate.TabIndex = 88
		Me.lblDocDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocDate.Enabled = True
		Me.lblDocDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocDate.UseMnemonic = True
		Me.lblDocDate.Visible = True
		Me.lblDocDate.AutoSize = False
		Me.lblDocDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocDate.Name = "lblDocDate"
		Me.lblDspCusName.Size = New System.Drawing.Size(369, 20)
		Me.lblDspCusName.Location = New System.Drawing.Point(112, 68)
		Me.lblDspCusName.TabIndex = 87
		Me.lblDspCusName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusName.Enabled = True
		Me.lblDspCusName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusName.UseMnemonic = True
		Me.lblDspCusName.Visible = True
		Me.lblDspCusName.AutoSize = False
		Me.lblDspCusName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusName.Name = "lblDspCusName"
		Me.LblCurr.Text = "CURR"
		Me.LblCurr.Size = New System.Drawing.Size(112, 17)
		Me.LblCurr.Location = New System.Drawing.Point(491, 80)
		Me.LblCurr.TabIndex = 86
		Me.LblCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LblCurr.BackColor = System.Drawing.SystemColors.Control
		Me.LblCurr.Enabled = True
		Me.LblCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.LblCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblCurr.UseMnemonic = True
		Me.LblCurr.Visible = True
		Me.LblCurr.AutoSize = False
		Me.LblCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LblCurr.Name = "LblCurr"
		Me.lblExcr.Text = "EXCR"
		Me.lblExcr.Size = New System.Drawing.Size(120, 17)
		Me.lblExcr.Location = New System.Drawing.Point(491, 104)
		Me.lblExcr.TabIndex = 85
		Me.lblExcr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExcr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblExcr.BackColor = System.Drawing.SystemColors.Control
		Me.lblExcr.Enabled = True
		Me.lblExcr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblExcr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblExcr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblExcr.UseMnemonic = True
		Me.lblExcr.Visible = True
		Me.lblExcr.AutoSize = False
		Me.lblExcr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblExcr.Name = "lblExcr"
		Me.lblDspCusTel.Size = New System.Drawing.Size(129, 20)
		Me.lblDspCusTel.Location = New System.Drawing.Point(112, 92)
		Me.lblDspCusTel.TabIndex = 84
		Me.lblDspCusTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusTel.Enabled = True
		Me.lblDspCusTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusTel.UseMnemonic = True
		Me.lblDspCusTel.Visible = True
		Me.lblDspCusTel.AutoSize = False
		Me.lblDspCusTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusTel.Name = "lblDspCusTel"
		Me.lblCusName.Text = "CUSNAME"
		Me.lblCusName.Size = New System.Drawing.Size(105, 17)
		Me.lblCusName.Location = New System.Drawing.Point(8, 72)
		Me.lblCusName.TabIndex = 83
		Me.lblCusName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusName.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusName.Enabled = True
		Me.lblCusName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusName.UseMnemonic = True
		Me.lblCusName.Visible = True
		Me.lblCusName.AutoSize = False
		Me.lblCusName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusName.Name = "lblCusName"
		Me.lblDspCusFax.Size = New System.Drawing.Size(137, 20)
		Me.lblDspCusFax.Location = New System.Drawing.Point(344, 92)
		Me.lblDspCusFax.TabIndex = 82
		Me.lblDspCusFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusFax.Enabled = True
		Me.lblDspCusFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusFax.UseMnemonic = True
		Me.lblDspCusFax.Visible = True
		Me.lblDspCusFax.AutoSize = False
		Me.lblDspCusFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusFax.Name = "lblDspCusFax"
		Me.lblCusFax.Text = "CUSFAX"
		Me.lblCusFax.Size = New System.Drawing.Size(81, 17)
		Me.lblCusFax.Location = New System.Drawing.Point(256, 96)
		Me.lblCusFax.TabIndex = 81
		Me.lblCusFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusFax.Enabled = True
		Me.lblCusFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusFax.UseMnemonic = True
		Me.lblCusFax.Visible = True
		Me.lblCusFax.AutoSize = False
		Me.lblCusFax.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusFax.Name = "lblCusFax"
		Me.lblCusTel.Text = "CUSTEL"
		Me.lblCusTel.Size = New System.Drawing.Size(105, 17)
		Me.lblCusTel.Location = New System.Drawing.Point(8, 96)
		Me.lblCusTel.TabIndex = 80
		Me.lblCusTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusTel.Enabled = True
		Me.lblCusTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusTel.UseMnemonic = True
		Me.lblCusTel.Visible = True
		Me.lblCusTel.AutoSize = False
		Me.lblCusTel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusTel.Name = "lblCusTel"
		Me.lblDisAmt.Text = "EXCR"
		Me.lblDisAmt.Size = New System.Drawing.Size(96, 33)
		Me.lblDisAmt.Location = New System.Drawing.Point(24, 400)
		Me.lblDisAmt.TabIndex = 103
		Me.lblDisAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDisAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDisAmt.Enabled = True
		Me.lblDisAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDisAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDisAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDisAmt.UseMnemonic = True
		Me.lblDisAmt.Visible = True
		Me.lblDisAmt.AutoSize = False
		Me.lblDisAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDisAmt.Name = "lblDisAmt"
		Me.lblSpecDis.Text = "EXCR"
		Me.lblSpecDis.Size = New System.Drawing.Size(96, 17)
		Me.lblSpecDis.Location = New System.Drawing.Point(24, 376)
		Me.lblSpecDis.TabIndex = 96
		Me.lblSpecDis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSpecDis.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSpecDis.BackColor = System.Drawing.SystemColors.Control
		Me.lblSpecDis.Enabled = True
		Me.lblSpecDis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSpecDis.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSpecDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSpecDis.UseMnemonic = True
		Me.lblSpecDis.Visible = True
		Me.lblSpecDis.AutoSize = False
		Me.lblSpecDis.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSpecDis.Name = "lblSpecDis"
		Me._tabDetailInfo_TabPage1.Text = "Shipment "
		Me.lblDspNetAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspNetAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspNetAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspNetAmtOrg.ForeColor = System.Drawing.Color.Blue
		Me.lblDspNetAmtOrg.Size = New System.Drawing.Size(166, 23)
		Me.lblDspNetAmtOrg.Location = New System.Drawing.Point(616, 36)
		Me.lblDspNetAmtOrg.TabIndex = 54
		Me.lblDspNetAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspNetAmtOrg.Enabled = True
		Me.lblDspNetAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspNetAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspNetAmtOrg.UseMnemonic = True
		Me.lblDspNetAmtOrg.Visible = True
		Me.lblDspNetAmtOrg.AutoSize = False
		Me.lblDspNetAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspNetAmtOrg.Name = "lblDspNetAmtOrg"
		Me.lblDspGrsAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspGrsAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspGrsAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspGrsAmtOrg.Size = New System.Drawing.Size(166, 23)
		Me.lblDspGrsAmtOrg.Location = New System.Drawing.Point(280, 36)
		Me.lblDspGrsAmtOrg.TabIndex = 55
		Me.lblDspGrsAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspGrsAmtOrg.Enabled = True
		Me.lblDspGrsAmtOrg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspGrsAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspGrsAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspGrsAmtOrg.UseMnemonic = True
		Me.lblDspGrsAmtOrg.Visible = True
		Me.lblDspGrsAmtOrg.AutoSize = False
		Me.lblDspGrsAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspGrsAmtOrg.Name = "lblDspGrsAmtOrg"
		Me.lblDspTotalQty.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDspTotalQty.Text = "9.999.999.999.99"
		Me.lblDspTotalQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspTotalQty.ForeColor = System.Drawing.Color.Blue
		Me.lblDspTotalQty.Size = New System.Drawing.Size(94, 23)
		Me.lblDspTotalQty.Location = New System.Drawing.Point(184, 36)
		Me.lblDspTotalQty.TabIndex = 56
		Me.lblDspTotalQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspTotalQty.Enabled = True
		Me.lblDspTotalQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspTotalQty.UseMnemonic = True
		Me.lblDspTotalQty.Visible = True
		Me.lblDspTotalQty.AutoSize = False
		Me.lblDspTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspTotalQty.Name = "lblDspTotalQty"
		Me.lblNetAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblNetAmtOrg.Text = "NETAMTORG"
		Me.lblNetAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNetAmtOrg.Size = New System.Drawing.Size(165, 17)
		Me.lblNetAmtOrg.Location = New System.Drawing.Point(616, 16)
		Me.lblNetAmtOrg.TabIndex = 57
		Me.lblNetAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblNetAmtOrg.Enabled = True
		Me.lblNetAmtOrg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNetAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNetAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNetAmtOrg.UseMnemonic = True
		Me.lblNetAmtOrg.Visible = True
		Me.lblNetAmtOrg.AutoSize = False
		Me.lblNetAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNetAmtOrg.Name = "lblNetAmtOrg"
		Me.lblGrsAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblGrsAmtOrg.Text = "GRSAMTORG"
		Me.lblGrsAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrsAmtOrg.Size = New System.Drawing.Size(165, 17)
		Me.lblGrsAmtOrg.Location = New System.Drawing.Point(280, 16)
		Me.lblGrsAmtOrg.TabIndex = 58
		Me.lblGrsAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblGrsAmtOrg.Enabled = True
		Me.lblGrsAmtOrg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGrsAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGrsAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGrsAmtOrg.UseMnemonic = True
		Me.lblGrsAmtOrg.Visible = True
		Me.lblGrsAmtOrg.AutoSize = False
		Me.lblGrsAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGrsAmtOrg.Name = "lblGrsAmtOrg"
		Me.lblTotalQty.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblTotalQty.Text = "NETAMTORG"
		Me.lblTotalQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotalQty.Size = New System.Drawing.Size(85, 17)
		Me.lblTotalQty.Location = New System.Drawing.Point(192, 16)
		Me.lblTotalQty.TabIndex = 59
		Me.lblTotalQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblTotalQty.Enabled = True
		Me.lblTotalQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTotalQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTotalQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTotalQty.UseMnemonic = True
		Me.lblTotalQty.Visible = True
		Me.lblTotalQty.AutoSize = False
		Me.lblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTotalQty.Name = "lblTotalQty"
		Me.lblDisAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDisAmtOrg.Text = "GRSAMTORG"
		Me.lblDisAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisAmtOrg.Size = New System.Drawing.Size(165, 17)
		Me.lblDisAmtOrg.Location = New System.Drawing.Point(448, 16)
		Me.lblDisAmtOrg.TabIndex = 97
		Me.lblDisAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDisAmtOrg.Enabled = True
		Me.lblDisAmtOrg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDisAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDisAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDisAmtOrg.UseMnemonic = True
		Me.lblDisAmtOrg.Visible = True
		Me.lblDisAmtOrg.AutoSize = False
		Me.lblDisAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDisAmtOrg.Name = "lblDisAmtOrg"
		Me.lblDspDisAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspDisAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspDisAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspDisAmtOrg.Size = New System.Drawing.Size(166, 23)
		Me.lblDspDisAmtOrg.Location = New System.Drawing.Point(448, 36)
		Me.lblDspDisAmtOrg.TabIndex = 98
		Me.lblDspDisAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspDisAmtOrg.Enabled = True
		Me.lblDspDisAmtOrg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspDisAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspDisAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspDisAmtOrg.UseMnemonic = True
		Me.lblDspDisAmtOrg.Visible = True
		Me.lblDspDisAmtOrg.AutoSize = False
		Me.lblDspDisAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspDisAmtOrg.Name = "lblDspDisAmtOrg"
		Me.lblDspCstAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspCstAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspCstAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCstAmtOrg.ForeColor = System.Drawing.Color.Blue
		Me.lblDspCstAmtOrg.Size = New System.Drawing.Size(166, 23)
		Me.lblDspCstAmtOrg.Location = New System.Drawing.Point(16, 32)
		Me.lblDspCstAmtOrg.TabIndex = 109
		Me.lblDspCstAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCstAmtOrg.Enabled = True
		Me.lblDspCstAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCstAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCstAmtOrg.UseMnemonic = True
		Me.lblDspCstAmtOrg.Visible = True
		Me.lblDspCstAmtOrg.AutoSize = False
		Me.lblDspCstAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCstAmtOrg.Name = "lblDspCstAmtOrg"
		Me._lblCol_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_9.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_9.Size = New System.Drawing.Size(33, 23)
		Me._lblCol_9.Location = New System.Drawing.Point(274, 64)
		Me._lblCol_9.TabIndex = 110
		Me._lblCol_9.Enabled = True
		Me._lblCol_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_9.UseMnemonic = True
		Me._lblCol_9.Visible = True
		Me._lblCol_9.AutoSize = False
		Me._lblCol_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_9.Name = "_lblCol_9"
		Me._lblCol_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_2.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_2.Size = New System.Drawing.Size(53, 23)
		Me._lblCol_2.Location = New System.Drawing.Point(360, 64)
		Me._lblCol_2.TabIndex = 111
		Me._lblCol_2.Enabled = True
		Me._lblCol_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_2.UseMnemonic = True
		Me._lblCol_2.Visible = True
		Me._lblCol_2.AutoSize = False
		Me._lblCol_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_2.Name = "_lblCol_2"
		Me._lblCol_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_1.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_1.Size = New System.Drawing.Size(53, 23)
		Me._lblCol_1.Location = New System.Drawing.Point(566, 64)
		Me._lblCol_1.TabIndex = 112
		Me._lblCol_1.Enabled = True
		Me._lblCol_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_1.UseMnemonic = True
		Me._lblCol_1.Visible = True
		Me._lblCol_1.AutoSize = False
		Me._lblCol_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_1.Name = "_lblCol_1"
		Me._lblCol_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_4.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_4.Size = New System.Drawing.Size(67, 23)
		Me._lblCol_4.Location = New System.Drawing.Point(446, 64)
		Me._lblCol_4.TabIndex = 113
		Me._lblCol_4.Enabled = True
		Me._lblCol_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_4.UseMnemonic = True
		Me._lblCol_4.Visible = True
		Me._lblCol_4.AutoSize = False
		Me._lblCol_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_4.Name = "_lblCol_4"
		Me._lblCol_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_6.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_6.Size = New System.Drawing.Size(67, 23)
		Me._lblCol_6.Location = New System.Drawing.Point(619, 64)
		Me._lblCol_6.TabIndex = 114
		Me._lblCol_6.Enabled = True
		Me._lblCol_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_6.UseMnemonic = True
		Me._lblCol_6.Visible = True
		Me._lblCol_6.AutoSize = False
		Me._lblCol_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_6.Name = "_lblCol_6"
		Me._lblCol_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_10.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_10.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_10.Size = New System.Drawing.Size(33, 23)
		Me._lblCol_10.Location = New System.Drawing.Point(413, 64)
		Me._lblCol_10.TabIndex = 115
		Me._lblCol_10.Enabled = True
		Me._lblCol_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_10.UseMnemonic = True
		Me._lblCol_10.Visible = True
		Me._lblCol_10.AutoSize = False
		Me._lblCol_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_10.Name = "_lblCol_10"
		Me._lblCol_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_8.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_8.Size = New System.Drawing.Size(233, 23)
		Me._lblCol_8.Location = New System.Drawing.Point(41, 64)
		Me._lblCol_8.TabIndex = 116
		Me._lblCol_8.Enabled = True
		Me._lblCol_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_8.UseMnemonic = True
		Me._lblCol_8.Visible = True
		Me._lblCol_8.AutoSize = False
		Me._lblCol_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_8.Name = "_lblCol_8"
		Me._lblCol_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_7.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_7.Size = New System.Drawing.Size(87, 23)
		Me._lblCol_7.Location = New System.Drawing.Point(686, 64)
		Me._lblCol_7.TabIndex = 117
		Me._lblCol_7.Enabled = True
		Me._lblCol_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_7.UseMnemonic = True
		Me._lblCol_7.Visible = True
		Me._lblCol_7.AutoSize = False
		Me._lblCol_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_7.Name = "_lblCol_7"
		Me._lblCol_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_5.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_5.Size = New System.Drawing.Size(53, 23)
		Me._lblCol_5.Location = New System.Drawing.Point(513, 64)
		Me._lblCol_5.TabIndex = 118
		Me._lblCol_5.Enabled = True
		Me._lblCol_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_5.UseMnemonic = True
		Me._lblCol_5.Visible = True
		Me._lblCol_5.AutoSize = False
		Me._lblCol_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_5.Name = "_lblCol_5"
		Me._lblCol_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_3.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_3.Size = New System.Drawing.Size(53, 23)
		Me._lblCol_3.Location = New System.Drawing.Point(307, 64)
		Me._lblCol_3.TabIndex = 119
		Me._lblCol_3.Enabled = True
		Me._lblCol_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_3.UseMnemonic = True
		Me._lblCol_3.Visible = True
		Me._lblCol_3.AutoSize = False
		Me._lblCol_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_3.Name = "_lblCol_3"
		Me._lblCol_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lblCol_0.BackColor = System.Drawing.Color.Transparent
		Me._lblCol_0.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblCol_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._lblCol_0.Size = New System.Drawing.Size(33, 23)
		Me._lblCol_0.Location = New System.Drawing.Point(8, 64)
		Me._lblCol_0.TabIndex = 120
		Me._lblCol_0.Enabled = True
		Me._lblCol_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblCol_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblCol_0.UseMnemonic = True
		Me._lblCol_0.Visible = True
		Me._lblCol_0.AutoSize = False
		Me._lblCol_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._lblCol_0.Name = "_lblCol_0"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(769, 393)
		Me.tblDetail.Location = New System.Drawing.Point(8, 84)
		Me.tblDetail.TabIndex = 22
		Me.tblDetail.Name = "tblDetail"
		Me.Frame1.Size = New System.Drawing.Size(409, 30)
		Me.Frame1.Location = New System.Drawing.Point(8, 480)
		Me.Frame1.TabIndex = 91
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.lblDeleteLine.Text = "REMARK"
		Me.lblDeleteLine.Size = New System.Drawing.Size(81, 15)
		Me.lblDeleteLine.Location = New System.Drawing.Point(320, 12)
		Me.lblDeleteLine.TabIndex = 95
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
		Me.lblInsertLine.Text = "REMARK"
		Me.lblInsertLine.Size = New System.Drawing.Size(81, 15)
		Me.lblInsertLine.Location = New System.Drawing.Point(224, 12)
		Me.lblInsertLine.TabIndex = 94
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
		Me.lblComboPrompt.Text = "REMARK"
		Me.lblComboPrompt.Size = New System.Drawing.Size(81, 15)
		Me.lblComboPrompt.Location = New System.Drawing.Point(128, 12)
		Me.lblComboPrompt.TabIndex = 93
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
		Me.lblKeyDesc.Text = "REMARK"
		Me.lblKeyDesc.Size = New System.Drawing.Size(81, 15)
		Me.lblKeyDesc.Location = New System.Drawing.Point(24, 12)
		Me.lblKeyDesc.TabIndex = 92
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
		Me._tabDetailInfo_TabPage2.Text = "Item Information"
		Me.cboShipCode.Size = New System.Drawing.Size(134, 20)
		Me.cboShipCode.Location = New System.Drawing.Point(120, 32)
		Me.cboShipCode.TabIndex = 23
		Me.cboShipCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboShipCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboShipCode.CausesValidation = True
		Me.cboShipCode.Enabled = True
		Me.cboShipCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboShipCode.IntegralHeight = True
		Me.cboShipCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboShipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboShipCode.Sorted = False
		Me.cboShipCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboShipCode.TabStop = True
		Me.cboShipCode.Visible = True
		Me.cboShipCode.Name = "cboShipCode"
		Me.fraShip.Size = New System.Drawing.Size(769, 209)
		Me.fraShip.Location = New System.Drawing.Point(8, 8)
		Me.fraShip.TabIndex = 69
		Me.fraShip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraShip.BackColor = System.Drawing.SystemColors.Control
		Me.fraShip.Enabled = True
		Me.fraShip.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraShip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraShip.Visible = True
		Me.fraShip.Padding = New System.Windows.Forms.Padding(0)
		Me.fraShip.Name = "fraShip"
		Me.Picture1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Picture1.Size = New System.Drawing.Size(641, 97)
		Me.Picture1.Location = New System.Drawing.Point(112, 96)
		Me.Picture1.TabIndex = 70
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.txtShipAdr4.AutoSize = False
		Me.txtShipAdr4.Enabled = False
		Me.txtShipAdr4.Size = New System.Drawing.Size(391, 20)
		Me.txtShipAdr4.Location = New System.Drawing.Point(0, 72)
		Me.txtShipAdr4.TabIndex = 29
		Me.txtShipAdr4.Text = "012345678901234578901234567890123457890123456789"
		Me.txtShipAdr4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipAdr4.AcceptsReturn = True
		Me.txtShipAdr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipAdr4.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipAdr4.CausesValidation = True
		Me.txtShipAdr4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipAdr4.HideSelection = True
		Me.txtShipAdr4.ReadOnly = False
		Me.txtShipAdr4.Maxlength = 0
		Me.txtShipAdr4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipAdr4.MultiLine = False
		Me.txtShipAdr4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipAdr4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipAdr4.TabStop = True
		Me.txtShipAdr4.Visible = True
		Me.txtShipAdr4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtShipAdr4.Name = "txtShipAdr4"
		Me.txtShipAdr3.AutoSize = False
		Me.txtShipAdr3.Enabled = False
		Me.txtShipAdr3.Size = New System.Drawing.Size(391, 20)
		Me.txtShipAdr3.Location = New System.Drawing.Point(0, 48)
		Me.txtShipAdr3.TabIndex = 28
		Me.txtShipAdr3.Text = "012345678901234578901234567890123457890123456789"
		Me.txtShipAdr3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipAdr3.AcceptsReturn = True
		Me.txtShipAdr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipAdr3.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipAdr3.CausesValidation = True
		Me.txtShipAdr3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipAdr3.HideSelection = True
		Me.txtShipAdr3.ReadOnly = False
		Me.txtShipAdr3.Maxlength = 0
		Me.txtShipAdr3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipAdr3.MultiLine = False
		Me.txtShipAdr3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipAdr3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipAdr3.TabStop = True
		Me.txtShipAdr3.Visible = True
		Me.txtShipAdr3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtShipAdr3.Name = "txtShipAdr3"
		Me.txtShipAdr2.AutoSize = False
		Me.txtShipAdr2.Enabled = False
		Me.txtShipAdr2.Size = New System.Drawing.Size(391, 20)
		Me.txtShipAdr2.Location = New System.Drawing.Point(0, 24)
		Me.txtShipAdr2.TabIndex = 27
		Me.txtShipAdr2.Text = "012345678901234578901234567890123457890123456789"
		Me.txtShipAdr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipAdr2.AcceptsReturn = True
		Me.txtShipAdr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipAdr2.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipAdr2.CausesValidation = True
		Me.txtShipAdr2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipAdr2.HideSelection = True
		Me.txtShipAdr2.ReadOnly = False
		Me.txtShipAdr2.Maxlength = 0
		Me.txtShipAdr2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipAdr2.MultiLine = False
		Me.txtShipAdr2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipAdr2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipAdr2.TabStop = True
		Me.txtShipAdr2.Visible = True
		Me.txtShipAdr2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtShipAdr2.Name = "txtShipAdr2"
		Me.txtShipAdr1.AutoSize = False
		Me.txtShipAdr1.Enabled = False
		Me.txtShipAdr1.Size = New System.Drawing.Size(391, 20)
		Me.txtShipAdr1.Location = New System.Drawing.Point(0, 0)
		Me.txtShipAdr1.TabIndex = 26
		Me.txtShipAdr1.Text = "012345678901234578901234567890123457890123456789"
		Me.txtShipAdr1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipAdr1.AcceptsReturn = True
		Me.txtShipAdr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipAdr1.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipAdr1.CausesValidation = True
		Me.txtShipAdr1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipAdr1.HideSelection = True
		Me.txtShipAdr1.ReadOnly = False
		Me.txtShipAdr1.Maxlength = 0
		Me.txtShipAdr1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipAdr1.MultiLine = False
		Me.txtShipAdr1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipAdr1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipAdr1.TabStop = True
		Me.txtShipAdr1.Visible = True
		Me.txtShipAdr1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtShipAdr1.Name = "txtShipAdr1"
		Me.txtShipName.AutoSize = False
		Me.txtShipName.Enabled = False
		Me.txtShipName.Size = New System.Drawing.Size(287, 20)
		Me.txtShipName.Location = New System.Drawing.Point(112, 72)
		Me.txtShipName.TabIndex = 25
		Me.txtShipName.Text = "012345678901234578901234567890123457890123456789"
		Me.txtShipName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipName.AcceptsReturn = True
		Me.txtShipName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipName.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipName.CausesValidation = True
		Me.txtShipName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipName.HideSelection = True
		Me.txtShipName.ReadOnly = False
		Me.txtShipName.Maxlength = 0
		Me.txtShipName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipName.MultiLine = False
		Me.txtShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipName.TabStop = True
		Me.txtShipName.Visible = True
		Me.txtShipName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipName.Name = "txtShipName"
		Me.txtShipPer.AutoSize = False
		Me.txtShipPer.Enabled = False
		Me.txtShipPer.Size = New System.Drawing.Size(287, 20)
		Me.txtShipPer.Location = New System.Drawing.Point(112, 48)
		Me.txtShipPer.TabIndex = 24
		Me.txtShipPer.Text = "01234567890123457890"
		Me.txtShipPer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipPer.AcceptsReturn = True
		Me.txtShipPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipPer.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipPer.CausesValidation = True
		Me.txtShipPer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipPer.HideSelection = True
		Me.txtShipPer.ReadOnly = False
		Me.txtShipPer.Maxlength = 0
		Me.txtShipPer.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipPer.MultiLine = False
		Me.txtShipPer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipPer.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipPer.TabStop = True
		Me.txtShipPer.Visible = True
		Me.txtShipPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipPer.Name = "txtShipPer"
		Me.lblShipCode.Text = "SHIPCODE"
		Me.lblShipCode.Size = New System.Drawing.Size(100, 16)
		Me.lblShipCode.Location = New System.Drawing.Point(8, 24)
		Me.lblShipCode.TabIndex = 74
		Me.lblShipCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipCode.Enabled = True
		Me.lblShipCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipCode.UseMnemonic = True
		Me.lblShipCode.Visible = True
		Me.lblShipCode.AutoSize = False
		Me.lblShipCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipCode.Name = "lblShipCode"
		Me.lblShipName.Text = "SHIPNAME"
		Me.lblShipName.Size = New System.Drawing.Size(92, 16)
		Me.lblShipName.Location = New System.Drawing.Point(8, 72)
		Me.lblShipName.TabIndex = 73
		Me.lblShipName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipName.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipName.Enabled = True
		Me.lblShipName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipName.UseMnemonic = True
		Me.lblShipName.Visible = True
		Me.lblShipName.AutoSize = False
		Me.lblShipName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipName.Name = "lblShipName"
		Me.lblShipPer.Text = "SHIPPER"
		Me.lblShipPer.Size = New System.Drawing.Size(100, 16)
		Me.lblShipPer.Location = New System.Drawing.Point(8, 48)
		Me.lblShipPer.TabIndex = 72
		Me.lblShipPer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipPer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipPer.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipPer.Enabled = True
		Me.lblShipPer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipPer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipPer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipPer.UseMnemonic = True
		Me.lblShipPer.Visible = True
		Me.lblShipPer.AutoSize = False
		Me.lblShipPer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipPer.Name = "lblShipPer"
		Me.lblShipAdr.Text = "SHIPADR"
		Me.lblShipAdr.Size = New System.Drawing.Size(100, 16)
		Me.lblShipAdr.Location = New System.Drawing.Point(8, 96)
		Me.lblShipAdr.TabIndex = 71
		Me.lblShipAdr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipAdr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipAdr.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipAdr.Enabled = True
		Me.lblShipAdr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipAdr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipAdr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipAdr.UseMnemonic = True
		Me.lblShipAdr.Visible = True
		Me.lblShipAdr.AutoSize = False
		Me.lblShipAdr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipAdr.Name = "lblShipAdr"
		Me.cboRmkCode.Size = New System.Drawing.Size(126, 20)
		Me.cboRmkCode.Location = New System.Drawing.Point(120, 240)
		Me.cboRmkCode.TabIndex = 30
		Me.cboRmkCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboRmkCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboRmkCode.CausesValidation = True
		Me.cboRmkCode.Enabled = True
		Me.cboRmkCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboRmkCode.IntegralHeight = True
		Me.cboRmkCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboRmkCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboRmkCode.Sorted = False
		Me.cboRmkCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboRmkCode.TabStop = True
		Me.cboRmkCode.Visible = True
		Me.cboRmkCode.Name = "cboRmkCode"
		Me.fraRmk.Size = New System.Drawing.Size(769, 281)
		Me.fraRmk.Location = New System.Drawing.Point(8, 224)
		Me.fraRmk.TabIndex = 75
		Me.fraRmk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraRmk.BackColor = System.Drawing.SystemColors.Control
		Me.fraRmk.Enabled = True
		Me.fraRmk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraRmk.Visible = True
		Me.fraRmk.Padding = New System.Windows.Forms.Padding(0)
		Me.fraRmk.Name = "fraRmk"
		Me.picRmk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.picRmk.Size = New System.Drawing.Size(641, 233)
		Me.picRmk.Location = New System.Drawing.Point(112, 40)
		Me.picRmk.TabIndex = 76
		Me.picRmk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picRmk.Dock = System.Windows.Forms.DockStyle.None
		Me.picRmk.CausesValidation = True
		Me.picRmk.Enabled = True
		Me.picRmk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picRmk.Cursor = System.Windows.Forms.Cursors.Default
		Me.picRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picRmk.TabStop = True
		Me.picRmk.Visible = True
		Me.picRmk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picRmk.Name = "picRmk"
		Me._txtRmk_2.AutoSize = False
		Me._txtRmk_2.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_2.Location = New System.Drawing.Point(0, 24)
		Me._txtRmk_2.TabIndex = 32
		Me._txtRmk_2.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_2.AcceptsReturn = True
		Me._txtRmk_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_2.CausesValidation = True
		Me._txtRmk_2.Enabled = True
		Me._txtRmk_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_2.HideSelection = True
		Me._txtRmk_2.ReadOnly = False
		Me._txtRmk_2.Maxlength = 0
		Me._txtRmk_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_2.MultiLine = False
		Me._txtRmk_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_2.TabStop = True
		Me._txtRmk_2.Visible = True
		Me._txtRmk_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_2.Name = "_txtRmk_2"
		Me._txtRmk_1.AutoSize = False
		Me._txtRmk_1.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_1.Location = New System.Drawing.Point(0, 0)
		Me._txtRmk_1.TabIndex = 31
		Me._txtRmk_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_1.AcceptsReturn = True
		Me._txtRmk_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_1.CausesValidation = True
		Me._txtRmk_1.Enabled = True
		Me._txtRmk_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_1.HideSelection = True
		Me._txtRmk_1.ReadOnly = False
		Me._txtRmk_1.Maxlength = 0
		Me._txtRmk_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_1.MultiLine = False
		Me._txtRmk_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_1.TabStop = True
		Me._txtRmk_1.Visible = True
		Me._txtRmk_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_1.Name = "_txtRmk_1"
		Me._txtRmk_3.AutoSize = False
		Me._txtRmk_3.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_3.Location = New System.Drawing.Point(0, 46)
		Me._txtRmk_3.TabIndex = 33
		Me._txtRmk_3.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_3.AcceptsReturn = True
		Me._txtRmk_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_3.CausesValidation = True
		Me._txtRmk_3.Enabled = True
		Me._txtRmk_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_3.HideSelection = True
		Me._txtRmk_3.ReadOnly = False
		Me._txtRmk_3.Maxlength = 0
		Me._txtRmk_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_3.MultiLine = False
		Me._txtRmk_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_3.TabStop = True
		Me._txtRmk_3.Visible = True
		Me._txtRmk_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_3.Name = "_txtRmk_3"
		Me._txtRmk_6.AutoSize = False
		Me._txtRmk_6.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_6.Location = New System.Drawing.Point(0, 116)
		Me._txtRmk_6.TabIndex = 36
		Me._txtRmk_6.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_6.AcceptsReturn = True
		Me._txtRmk_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_6.CausesValidation = True
		Me._txtRmk_6.Enabled = True
		Me._txtRmk_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_6.HideSelection = True
		Me._txtRmk_6.ReadOnly = False
		Me._txtRmk_6.Maxlength = 0
		Me._txtRmk_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_6.MultiLine = False
		Me._txtRmk_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_6.TabStop = True
		Me._txtRmk_6.Visible = True
		Me._txtRmk_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_6.Name = "_txtRmk_6"
		Me._txtRmk_4.AutoSize = False
		Me._txtRmk_4.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_4.Location = New System.Drawing.Point(0, 69)
		Me._txtRmk_4.TabIndex = 34
		Me._txtRmk_4.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_4.AcceptsReturn = True
		Me._txtRmk_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_4.CausesValidation = True
		Me._txtRmk_4.Enabled = True
		Me._txtRmk_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_4.HideSelection = True
		Me._txtRmk_4.ReadOnly = False
		Me._txtRmk_4.Maxlength = 0
		Me._txtRmk_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_4.MultiLine = False
		Me._txtRmk_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_4.TabStop = True
		Me._txtRmk_4.Visible = True
		Me._txtRmk_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_4.Name = "_txtRmk_4"
		Me._txtRmk_5.AutoSize = False
		Me._txtRmk_5.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_5.Location = New System.Drawing.Point(0, 93)
		Me._txtRmk_5.TabIndex = 35
		Me._txtRmk_5.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_5.AcceptsReturn = True
		Me._txtRmk_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_5.CausesValidation = True
		Me._txtRmk_5.Enabled = True
		Me._txtRmk_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_5.HideSelection = True
		Me._txtRmk_5.ReadOnly = False
		Me._txtRmk_5.Maxlength = 0
		Me._txtRmk_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_5.MultiLine = False
		Me._txtRmk_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_5.TabStop = True
		Me._txtRmk_5.Visible = True
		Me._txtRmk_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_5.Name = "_txtRmk_5"
		Me._txtRmk_7.AutoSize = False
		Me._txtRmk_7.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_7.Location = New System.Drawing.Point(0, 139)
		Me._txtRmk_7.TabIndex = 37
		Me._txtRmk_7.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_7.AcceptsReturn = True
		Me._txtRmk_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_7.CausesValidation = True
		Me._txtRmk_7.Enabled = True
		Me._txtRmk_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_7.HideSelection = True
		Me._txtRmk_7.ReadOnly = False
		Me._txtRmk_7.Maxlength = 0
		Me._txtRmk_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_7.MultiLine = False
		Me._txtRmk_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_7.TabStop = True
		Me._txtRmk_7.Visible = True
		Me._txtRmk_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_7.Name = "_txtRmk_7"
		Me._txtRmk_8.AutoSize = False
		Me._txtRmk_8.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_8.Location = New System.Drawing.Point(0, 162)
		Me._txtRmk_8.TabIndex = 38
		Me._txtRmk_8.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_8.AcceptsReturn = True
		Me._txtRmk_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_8.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_8.CausesValidation = True
		Me._txtRmk_8.Enabled = True
		Me._txtRmk_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_8.HideSelection = True
		Me._txtRmk_8.ReadOnly = False
		Me._txtRmk_8.Maxlength = 0
		Me._txtRmk_8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_8.MultiLine = False
		Me._txtRmk_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_8.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_8.TabStop = True
		Me._txtRmk_8.Visible = True
		Me._txtRmk_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_8.Name = "_txtRmk_8"
		Me._txtRmk_9.AutoSize = False
		Me._txtRmk_9.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_9.Location = New System.Drawing.Point(0, 185)
		Me._txtRmk_9.TabIndex = 39
		Me._txtRmk_9.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_9.AcceptsReturn = True
		Me._txtRmk_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_9.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_9.CausesValidation = True
		Me._txtRmk_9.Enabled = True
		Me._txtRmk_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_9.HideSelection = True
		Me._txtRmk_9.ReadOnly = False
		Me._txtRmk_9.Maxlength = 0
		Me._txtRmk_9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_9.MultiLine = False
		Me._txtRmk_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_9.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_9.TabStop = True
		Me._txtRmk_9.Visible = True
		Me._txtRmk_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_9.Name = "_txtRmk_9"
		Me._txtRmk_10.AutoSize = False
		Me._txtRmk_10.Size = New System.Drawing.Size(503, 20)
		Me._txtRmk_10.Location = New System.Drawing.Point(0, 208)
		Me._txtRmk_10.TabIndex = 40
		Me._txtRmk_10.Text = "012345678901234578901234567890123457890123456789"
		Me._txtRmk_10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRmk_10.AcceptsReturn = True
		Me._txtRmk_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRmk_10.BackColor = System.Drawing.SystemColors.Window
		Me._txtRmk_10.CausesValidation = True
		Me._txtRmk_10.Enabled = True
		Me._txtRmk_10.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRmk_10.HideSelection = True
		Me._txtRmk_10.ReadOnly = False
		Me._txtRmk_10.Maxlength = 0
		Me._txtRmk_10.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRmk_10.MultiLine = False
		Me._txtRmk_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRmk_10.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRmk_10.TabStop = True
		Me._txtRmk_10.Visible = True
		Me._txtRmk_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtRmk_10.Name = "_txtRmk_10"
		Me.lblRmkCode.Text = "RMKCODE"
		Me.lblRmkCode.Size = New System.Drawing.Size(100, 16)
		Me.lblRmkCode.Location = New System.Drawing.Point(8, 16)
		Me.lblRmkCode.TabIndex = 78
		Me.lblRmkCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRmkCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRmkCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblRmkCode.Enabled = True
		Me.lblRmkCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRmkCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRmkCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRmkCode.UseMnemonic = True
		Me.lblRmkCode.Visible = True
		Me.lblRmkCode.AutoSize = False
		Me.lblRmkCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRmkCode.Name = "lblRmkCode"
		Me.lblRmk.Text = "RMK"
		Me.lblRmk.Size = New System.Drawing.Size(100, 16)
		Me.lblRmk.Location = New System.Drawing.Point(8, 40)
		Me.lblRmk.TabIndex = 77
		Me.lblRmk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRmk.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRmk.BackColor = System.Drawing.SystemColors.Control
		Me.lblRmk.Enabled = True
		Me.lblRmk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRmk.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRmk.UseMnemonic = True
		Me.lblRmk.Visible = True
		Me.lblRmk.AutoSize = False
		Me.lblRmk.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRmk.Name = "lblRmk"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tabDetailInfo)
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
		Me.tbrProcess.Items.Add(_tbrProcess_Button15)
		Me.tbrProcess.Items.Add(_tbrProcess_Button16)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage2)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboJobNo)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboCRML)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboCurr)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtDisAmt)
		Me._tabDetailInfo_TabPage0.Controls.Add(btnGetDisAmt)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtSpecDis)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboDocNo)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboCusCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboPayCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboPrcCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboMLCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboSaleCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(FraDate)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraInfo)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraKey)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblDisAmt)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblSpecDis)
		Me.FraDate.Controls.Add(medReserveDate)
		Me.FraDate.Controls.Add(medExpiryDate)
		Me.FraDate.Controls.Add(lblExpiryDate)
		Me.FraDate.Controls.Add(lblReserveDate)
		Me.fraInfo.Controls.Add(txtJobCost)
		Me.fraInfo.Controls.Add(txtShipFrom)
		Me.fraInfo.Controls.Add(txtShipVia)
		Me.fraInfo.Controls.Add(txtShipTo)
		Me.fraInfo.Controls.Add(txtLcNo)
		Me.fraInfo.Controls.Add(txtPortNo)
		Me.fraInfo.Controls.Add(txtCusPo)
		Me.fraInfo.Controls.Add(lblJobCost)
		Me.fraInfo.Controls.Add(lblJobNo)
		Me.fraInfo.Controls.Add(lblLcNo)
		Me.fraInfo.Controls.Add(lblPortNo)
		Me.fraInfo.Controls.Add(lblCusPo)
		Me.fraInfo.Controls.Add(lblShipTo)
		Me.fraInfo.Controls.Add(lblShipVia)
		Me.fraInfo.Controls.Add(lblShipFrom)
		Me.fraCode.Controls.Add(lblDspCRMLDesc)
		Me.fraCode.Controls.Add(lblCRMl)
		Me.fraCode.Controls.Add(lblMlCode)
		Me.fraCode.Controls.Add(lblDspMLDesc)
		Me.fraCode.Controls.Add(lblPrcCode)
		Me.fraCode.Controls.Add(lblDspPrcDesc)
		Me.fraCode.Controls.Add(lblPayCode)
		Me.fraCode.Controls.Add(lblDspPayDesc)
		Me.fraCode.Controls.Add(lblSaleCode)
		Me.fraCode.Controls.Add(lblDspSaleDesc)
		Me.fraKey.Controls.Add(txtExcr)
		Me.fraKey.Controls.Add(medDocDate)
		Me.fraKey.Controls.Add(lblRefNo)
		Me.fraKey.Controls.Add(lblDspRefNo)
		Me.fraKey.Controls.Add(lblDspCusEMail)
		Me.fraKey.Controls.Add(lblCusEMail)
		Me.fraKey.Controls.Add(lblRevNo)
		Me.fraKey.Controls.Add(lblDspRevNo)
		Me.fraKey.Controls.Add(lblCusCode)
		Me.fraKey.Controls.Add(lblDocNo)
		Me.fraKey.Controls.Add(lblDocDate)
		Me.fraKey.Controls.Add(lblDspCusName)
		Me.fraKey.Controls.Add(LblCurr)
		Me.fraKey.Controls.Add(lblExcr)
		Me.fraKey.Controls.Add(lblDspCusTel)
		Me.fraKey.Controls.Add(lblCusName)
		Me.fraKey.Controls.Add(lblDspCusFax)
		Me.fraKey.Controls.Add(lblCusFax)
		Me.fraKey.Controls.Add(lblCusTel)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspNetAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspGrsAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspTotalQty)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblNetAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblGrsAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblTotalQty)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDisAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspDisAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspCstAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_9)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_2)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_1)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_4)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_6)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_10)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_8)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_7)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_5)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_3)
		Me._tabDetailInfo_TabPage1.Controls.Add(_lblCol_0)
		Me._tabDetailInfo_TabPage1.Controls.Add(tblDetail)
		Me._tabDetailInfo_TabPage1.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(lblDeleteLine)
		Me.Frame1.Controls.Add(lblInsertLine)
		Me.Frame1.Controls.Add(lblComboPrompt)
		Me.Frame1.Controls.Add(lblKeyDesc)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboShipCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(fraShip)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboRmkCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(fraRmk)
		Me.fraShip.Controls.Add(Picture1)
		Me.fraShip.Controls.Add(txtShipName)
		Me.fraShip.Controls.Add(txtShipPer)
		Me.fraShip.Controls.Add(lblShipCode)
		Me.fraShip.Controls.Add(lblShipName)
		Me.fraShip.Controls.Add(lblShipPer)
		Me.fraShip.Controls.Add(lblShipAdr)
		Me.Picture1.Controls.Add(txtShipAdr4)
		Me.Picture1.Controls.Add(txtShipAdr3)
		Me.Picture1.Controls.Add(txtShipAdr2)
		Me.Picture1.Controls.Add(txtShipAdr1)
		Me.fraRmk.Controls.Add(picRmk)
		Me.fraRmk.Controls.Add(lblRmkCode)
		Me.fraRmk.Controls.Add(lblRmk)
		Me.picRmk.Controls.Add(_txtRmk_2)
		Me.picRmk.Controls.Add(_txtRmk_1)
		Me.picRmk.Controls.Add(_txtRmk_3)
		Me.picRmk.Controls.Add(_txtRmk_6)
		Me.picRmk.Controls.Add(_txtRmk_4)
		Me.picRmk.Controls.Add(_txtRmk_5)
		Me.picRmk.Controls.Add(_txtRmk_7)
		Me.picRmk.Controls.Add(_txtRmk_8)
		Me.picRmk.Controls.Add(_txtRmk_9)
		Me.picRmk.Controls.Add(_txtRmk_10)
		Me.lblCol.SetIndex(_lblCol_0, CType(0, Short))
		Me.lblCol.SetIndex(_lblCol_3, CType(3, Short))
		Me.lblCol.SetIndex(_lblCol_5, CType(5, Short))
		Me.lblCol.SetIndex(_lblCol_7, CType(7, Short))
		Me.lblCol.SetIndex(_lblCol_8, CType(8, Short))
		Me.lblCol.SetIndex(_lblCol_10, CType(10, Short))
		Me.lblCol.SetIndex(_lblCol_6, CType(6, Short))
		Me.lblCol.SetIndex(_lblCol_4, CType(4, Short))
		Me.lblCol.SetIndex(_lblCol_1, CType(1, Short))
		Me.lblCol.SetIndex(_lblCol_2, CType(2, Short))
		Me.lblCol.SetIndex(_lblCol_9, CType(9, Short))
		Me.mnuPopUpSub.SetIndex(_mnuPopUpSub_0, CType(0, Short))
		Me.txtRmk.SetIndex(_txtRmk_2, CType(2, Short))
		Me.txtRmk.SetIndex(_txtRmk_1, CType(1, Short))
		Me.txtRmk.SetIndex(_txtRmk_3, CType(3, Short))
		Me.txtRmk.SetIndex(_txtRmk_6, CType(6, Short))
		Me.txtRmk.SetIndex(_txtRmk_4, CType(4, Short))
		Me.txtRmk.SetIndex(_txtRmk_5, CType(5, Short))
		Me.txtRmk.SetIndex(_txtRmk_7, CType(7, Short))
		Me.txtRmk.SetIndex(_txtRmk_8, CType(8, Short))
		Me.txtRmk.SetIndex(_txtRmk_9, CType(9, Short))
		Me.txtRmk.SetIndex(_txtRmk_10, CType(10, Short))
		CType(Me.txtRmk, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCol, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPopUp})
		mnuPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuPopUpSub_0})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me.FraDate.ResumeLayout(False)
		Me.fraInfo.ResumeLayout(False)
		Me.fraCode.ResumeLayout(False)
		Me.fraKey.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._tabDetailInfo_TabPage2.ResumeLayout(False)
		Me.fraShip.ResumeLayout(False)
		Me.Picture1.ResumeLayout(False)
		Me.fraRmk.ResumeLayout(False)
		Me.picRmk.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class