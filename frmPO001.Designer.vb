<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPO001
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
	Public WithEvents _tbrProcess_Button14 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button15 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents cboRefDocNo As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrCode As System.Windows.Forms.ComboBox
	Public WithEvents cboDelCode As System.Windows.Forms.ComboBox
	Public WithEvents btnGetDisAmt As System.Windows.Forms.Button
	Public WithEvents txtDisAmt As System.Windows.Forms.TextBox
	Public WithEvents txtSpecDis As System.Windows.Forms.TextBox
	Public WithEvents lblDisAmt As System.Windows.Forms.Label
	Public WithEvents lblSpecDis As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cboCurr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNo As System.Windows.Forms.ComboBox
	Public WithEvents cboPayCode As System.Windows.Forms.ComboBox
	Public WithEvents cboPrcCode As System.Windows.Forms.ComboBox
	Public WithEvents cboMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents medDueDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents medExpiryDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblExpiryDate As System.Windows.Forms.Label
	Public WithEvents lblDueDate As System.Windows.Forms.Label
	Public WithEvents FraDate As System.Windows.Forms.GroupBox
	Public WithEvents txtDelAdr4 As System.Windows.Forms.TextBox
	Public WithEvents txtDelAdr3 As System.Windows.Forms.TextBox
	Public WithEvents txtLcNo As System.Windows.Forms.TextBox
	Public WithEvents txtPortNo As System.Windows.Forms.TextBox
	Public WithEvents txtCusPo As System.Windows.Forms.TextBox
	Public WithEvents txtDelAdr1 As System.Windows.Forms.TextBox
	Public WithEvents txtDelAdr2 As System.Windows.Forms.TextBox
	Public WithEvents txtDelName As System.Windows.Forms.TextBox
	Public WithEvents lblLcNo As System.Windows.Forms.Label
	Public WithEvents lblPortNo As System.Windows.Forms.Label
	Public WithEvents lblCusPo As System.Windows.Forms.Label
	Public WithEvents lblDelAdr1 As System.Windows.Forms.Label
	Public WithEvents lblDelCode As System.Windows.Forms.Label
	Public WithEvents lblDelName As System.Windows.Forms.Label
	Public WithEvents fraInfo As System.Windows.Forms.GroupBox
	Public WithEvents lblMlCode As System.Windows.Forms.Label
	Public WithEvents lblDspMLDesc As System.Windows.Forms.Label
	Public WithEvents lblPrcCode As System.Windows.Forms.Label
	Public WithEvents lblDspPrcDesc As System.Windows.Forms.Label
	Public WithEvents lblPayCode As System.Windows.Forms.Label
	Public WithEvents lblDspPayDesc As System.Windows.Forms.Label
	Public WithEvents lblSaleCode As System.Windows.Forms.Label
	Public WithEvents lblDspSaleDesc As System.Windows.Forms.Label
	Public WithEvents fraCode As System.Windows.Forms.GroupBox
	Public WithEvents chkWorkOrder As System.Windows.Forms.CheckBox
	Public WithEvents txtExcr As System.Windows.Forms.TextBox
	Public WithEvents medDocDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblRefDocNo As System.Windows.Forms.Label
	Public WithEvents lblVdrCode As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	Public WithEvents lblDocDate As System.Windows.Forms.Label
	Public WithEvents lblDspVdrName As System.Windows.Forms.Label
	Public WithEvents LblCurr As System.Windows.Forms.Label
	Public WithEvents lblExcr As System.Windows.Forms.Label
	Public WithEvents lblDspVdrTel As System.Windows.Forms.Label
	Public WithEvents lblVdrName As System.Windows.Forms.Label
	Public WithEvents lblDspVdrFax As System.Windows.Forms.Label
	Public WithEvents lblVdrFax As System.Windows.Forms.Label
	Public WithEvents lblVdrTel As System.Windows.Forms.Label
	Public WithEvents fraKey As System.Windows.Forms.GroupBox
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents lblDspNetAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspDisAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspGrsAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDspTotalQty As System.Windows.Forms.Label
	Public WithEvents lblNetAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblDisAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblGrsAmtOrg As System.Windows.Forms.Label
	Public WithEvents lblTotalQty As System.Windows.Forms.Label
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblDeleteLine As System.Windows.Forms.Label
	Public WithEvents lblInsertLine As System.Windows.Forms.Label
	Public WithEvents lblComboPrompt As System.Windows.Forms.Label
	Public WithEvents lblKeyDesc As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents _cboShipCode_1 As System.Windows.Forms.ComboBox
	Public WithEvents _txtShipPer_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipName_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr1_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr2_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr3_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr4_1 As System.Windows.Forms.TextBox
	Public WithEvents _Picture1_1 As System.Windows.Forms.Panel
	Public WithEvents _txtShipFaxNo_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipTelNo_1 As System.Windows.Forms.TextBox
	Public WithEvents _lblShipAdr_1 As System.Windows.Forms.Label
	Public WithEvents _lblShipPer_1 As System.Windows.Forms.Label
	Public WithEvents _lblShipName_1 As System.Windows.Forms.Label
	Public WithEvents _lblShipCode_1 As System.Windows.Forms.Label
	Public WithEvents _lblShipFaxNo_1 As System.Windows.Forms.Label
	Public WithEvents _lblShipTelNo_1 As System.Windows.Forms.Label
	Public WithEvents _fraShip_1 As System.Windows.Forms.GroupBox
	Public WithEvents _cboShipCode_0 As System.Windows.Forms.ComboBox
	Public WithEvents _txtShipTelNo_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipFaxNo_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr4_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr3_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr2_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr1_0 As System.Windows.Forms.TextBox
	Public WithEvents _Picture1_0 As System.Windows.Forms.Panel
	Public WithEvents _txtShipName_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipPer_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblShipTelNo_0 As System.Windows.Forms.Label
	Public WithEvents _lblShipFaxNo_0 As System.Windows.Forms.Label
	Public WithEvents _lblShipCode_0 As System.Windows.Forms.Label
	Public WithEvents _lblShipName_0 As System.Windows.Forms.Label
	Public WithEvents _lblShipPer_0 As System.Windows.Forms.Label
	Public WithEvents _lblShipAdr_0 As System.Windows.Forms.Label
	Public WithEvents _fraShip_0 As System.Windows.Forms.GroupBox
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
	Public WithEvents Picture1 As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents cboShipCode As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents fraShip As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents lblShipAdr As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblShipCode As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblShipFaxNo As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblShipName As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblShipPer As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblShipTelNo As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	Public WithEvents txtRmk As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipAdr1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipAdr2 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipAdr3 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipAdr4 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipFaxNo As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipName As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipPer As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtShipTelNo As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPO001))
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
		Me._tbrProcess_Button14 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button15 = New System.Windows.Forms.ToolStripButton
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.cboRefDocNo = New System.Windows.Forms.ComboBox
		Me.cboVdrCode = New System.Windows.Forms.ComboBox
		Me.cboDelCode = New System.Windows.Forms.ComboBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.btnGetDisAmt = New System.Windows.Forms.Button
		Me.txtDisAmt = New System.Windows.Forms.TextBox
		Me.txtSpecDis = New System.Windows.Forms.TextBox
		Me.lblDisAmt = New System.Windows.Forms.Label
		Me.lblSpecDis = New System.Windows.Forms.Label
		Me.cboCurr = New System.Windows.Forms.ComboBox
		Me.cboDocNo = New System.Windows.Forms.ComboBox
		Me.cboPayCode = New System.Windows.Forms.ComboBox
		Me.cboPrcCode = New System.Windows.Forms.ComboBox
		Me.cboMLCode = New System.Windows.Forms.ComboBox
		Me.cboSaleCode = New System.Windows.Forms.ComboBox
		Me.FraDate = New System.Windows.Forms.GroupBox
		Me.medDueDate = New System.Windows.Forms.MaskedTextBox
		Me.medExpiryDate = New System.Windows.Forms.MaskedTextBox
		Me.lblExpiryDate = New System.Windows.Forms.Label
		Me.lblDueDate = New System.Windows.Forms.Label
		Me.fraInfo = New System.Windows.Forms.GroupBox
		Me.txtDelAdr4 = New System.Windows.Forms.TextBox
		Me.txtDelAdr3 = New System.Windows.Forms.TextBox
		Me.txtLcNo = New System.Windows.Forms.TextBox
		Me.txtPortNo = New System.Windows.Forms.TextBox
		Me.txtCusPo = New System.Windows.Forms.TextBox
		Me.txtDelAdr1 = New System.Windows.Forms.TextBox
		Me.txtDelAdr2 = New System.Windows.Forms.TextBox
		Me.txtDelName = New System.Windows.Forms.TextBox
		Me.lblLcNo = New System.Windows.Forms.Label
		Me.lblPortNo = New System.Windows.Forms.Label
		Me.lblCusPo = New System.Windows.Forms.Label
		Me.lblDelAdr1 = New System.Windows.Forms.Label
		Me.lblDelCode = New System.Windows.Forms.Label
		Me.lblDelName = New System.Windows.Forms.Label
		Me.fraCode = New System.Windows.Forms.GroupBox
		Me.lblMlCode = New System.Windows.Forms.Label
		Me.lblDspMLDesc = New System.Windows.Forms.Label
		Me.lblPrcCode = New System.Windows.Forms.Label
		Me.lblDspPrcDesc = New System.Windows.Forms.Label
		Me.lblPayCode = New System.Windows.Forms.Label
		Me.lblDspPayDesc = New System.Windows.Forms.Label
		Me.lblSaleCode = New System.Windows.Forms.Label
		Me.lblDspSaleDesc = New System.Windows.Forms.Label
		Me.fraKey = New System.Windows.Forms.GroupBox
		Me.chkWorkOrder = New System.Windows.Forms.CheckBox
		Me.txtExcr = New System.Windows.Forms.TextBox
		Me.medDocDate = New System.Windows.Forms.MaskedTextBox
		Me.lblRefDocNo = New System.Windows.Forms.Label
		Me.lblVdrCode = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.lblDocDate = New System.Windows.Forms.Label
		Me.lblDspVdrName = New System.Windows.Forms.Label
		Me.LblCurr = New System.Windows.Forms.Label
		Me.lblExcr = New System.Windows.Forms.Label
		Me.lblDspVdrTel = New System.Windows.Forms.Label
		Me.lblVdrName = New System.Windows.Forms.Label
		Me.lblDspVdrFax = New System.Windows.Forms.Label
		Me.lblVdrFax = New System.Windows.Forms.Label
		Me.lblVdrTel = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.lblDspNetAmtOrg = New System.Windows.Forms.Label
		Me.lblDspDisAmtOrg = New System.Windows.Forms.Label
		Me.lblDspGrsAmtOrg = New System.Windows.Forms.Label
		Me.lblDspTotalQty = New System.Windows.Forms.Label
		Me.lblNetAmtOrg = New System.Windows.Forms.Label
		Me.lblDisAmtOrg = New System.Windows.Forms.Label
		Me.lblGrsAmtOrg = New System.Windows.Forms.Label
		Me.lblTotalQty = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblDeleteLine = New System.Windows.Forms.Label
		Me.lblInsertLine = New System.Windows.Forms.Label
		Me.lblComboPrompt = New System.Windows.Forms.Label
		Me.lblKeyDesc = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage2 = New System.Windows.Forms.TabPage
		Me._cboShipCode_1 = New System.Windows.Forms.ComboBox
		Me._fraShip_1 = New System.Windows.Forms.GroupBox
		Me._txtShipPer_1 = New System.Windows.Forms.TextBox
		Me._txtShipName_1 = New System.Windows.Forms.TextBox
		Me._Picture1_1 = New System.Windows.Forms.Panel
		Me._txtShipAdr1_1 = New System.Windows.Forms.TextBox
		Me._txtShipAdr2_1 = New System.Windows.Forms.TextBox
		Me._txtShipAdr3_1 = New System.Windows.Forms.TextBox
		Me._txtShipAdr4_1 = New System.Windows.Forms.TextBox
		Me._txtShipFaxNo_1 = New System.Windows.Forms.TextBox
		Me._txtShipTelNo_1 = New System.Windows.Forms.TextBox
		Me._lblShipAdr_1 = New System.Windows.Forms.Label
		Me._lblShipPer_1 = New System.Windows.Forms.Label
		Me._lblShipName_1 = New System.Windows.Forms.Label
		Me._lblShipCode_1 = New System.Windows.Forms.Label
		Me._lblShipFaxNo_1 = New System.Windows.Forms.Label
		Me._lblShipTelNo_1 = New System.Windows.Forms.Label
		Me._cboShipCode_0 = New System.Windows.Forms.ComboBox
		Me._fraShip_0 = New System.Windows.Forms.GroupBox
		Me._txtShipTelNo_0 = New System.Windows.Forms.TextBox
		Me._txtShipFaxNo_0 = New System.Windows.Forms.TextBox
		Me._Picture1_0 = New System.Windows.Forms.Panel
		Me._txtShipAdr4_0 = New System.Windows.Forms.TextBox
		Me._txtShipAdr3_0 = New System.Windows.Forms.TextBox
		Me._txtShipAdr2_0 = New System.Windows.Forms.TextBox
		Me._txtShipAdr1_0 = New System.Windows.Forms.TextBox
		Me._txtShipName_0 = New System.Windows.Forms.TextBox
		Me._txtShipPer_0 = New System.Windows.Forms.TextBox
		Me._lblShipTelNo_0 = New System.Windows.Forms.Label
		Me._lblShipFaxNo_0 = New System.Windows.Forms.Label
		Me._lblShipCode_0 = New System.Windows.Forms.Label
		Me._lblShipName_0 = New System.Windows.Forms.Label
		Me._lblShipPer_0 = New System.Windows.Forms.Label
		Me._lblShipAdr_0 = New System.Windows.Forms.Label
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
		Me.Picture1 = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.cboShipCode = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.fraShip = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.lblShipAdr = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblShipCode = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblShipFaxNo = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblShipName = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblShipPer = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lblShipTelNo = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.txtRmk = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipAdr1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipAdr2 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipAdr3 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipAdr4 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipFaxNo = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipName = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipPer = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtShipTelNo = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.FraDate.SuspendLayout()
		Me.fraInfo.SuspendLayout()
		Me.fraCode.SuspendLayout()
		Me.fraKey.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me._tabDetailInfo_TabPage2.SuspendLayout()
		Me._fraShip_1.SuspendLayout()
		Me._Picture1_1.SuspendLayout()
		Me._fraShip_0.SuspendLayout()
		Me._Picture1_0.SuspendLayout()
		Me.fraRmk.SuspendLayout()
		Me.picRmk.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cboShipCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraShip, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipAdr, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipFaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipPer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipTelNo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRmk, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipAdr1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipAdr2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipAdr3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipAdr4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipFaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipPer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipTelNo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "訂貨單"
		Me.ClientSize = New System.Drawing.Size(792, 597)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmPO001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPO001"
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
		Me.tblCommon.Location = New System.Drawing.Point(760, 32)
		Me.tblCommon.TabIndex = 54
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
		Me.tbrProcess.TabIndex = 55
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
		Me._tbrProcess_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button15.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button15.AutoSize = False
		Me._tbrProcess_Button15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button15.Name = "Exit"
		Me._tbrProcess_Button15.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button15.ImageIndex = 8
		Me._tbrProcess_Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tabDetailInfo.Size = New System.Drawing.Size(793, 537)
		Me.tabDetailInfo.Location = New System.Drawing.Point(0, 56)
		Me.tabDetailInfo.TabIndex = 56
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.SelectedIndex = 1
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "Header Information"
		Me.cboRefDocNo.Size = New System.Drawing.Size(137, 20)
		Me.cboRefDocNo.Location = New System.Drawing.Point(352, 52)
		Me.cboRefDocNo.TabIndex = 2
		Me.cboRefDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboRefDocNo.BackColor = System.Drawing.SystemColors.Window
		Me.cboRefDocNo.CausesValidation = True
		Me.cboRefDocNo.Enabled = True
		Me.cboRefDocNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboRefDocNo.IntegralHeight = True
		Me.cboRefDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboRefDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboRefDocNo.Sorted = False
		Me.cboRefDocNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboRefDocNo.TabStop = True
		Me.cboRefDocNo.Visible = True
		Me.cboRefDocNo.Name = "cboRefDocNo"
		Me.cboVdrCode.Size = New System.Drawing.Size(129, 20)
		Me.cboVdrCode.Location = New System.Drawing.Point(120, 52)
		Me.cboVdrCode.TabIndex = 1
		Me.cboVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrCode.CausesValidation = True
		Me.cboVdrCode.Enabled = True
		Me.cboVdrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrCode.IntegralHeight = True
		Me.cboVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrCode.Sorted = False
		Me.cboVdrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrCode.TabStop = True
		Me.cboVdrCode.Visible = True
		Me.cboVdrCode.Name = "cboVdrCode"
		Me.cboDelCode.Size = New System.Drawing.Size(118, 20)
		Me.cboDelCode.Location = New System.Drawing.Point(416, 288)
		Me.cboDelCode.TabIndex = 15
		Me.cboDelCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDelCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboDelCode.CausesValidation = True
		Me.cboDelCode.Enabled = True
		Me.cboDelCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDelCode.IntegralHeight = True
		Me.cboDelCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDelCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDelCode.Sorted = False
		Me.cboDelCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDelCode.TabStop = True
		Me.cboDelCode.Visible = True
		Me.cboDelCode.Name = "cboDelCode"
		Me.Frame2.Size = New System.Drawing.Size(265, 152)
		Me.Frame2.Location = New System.Drawing.Point(8, 337)
		Me.Frame2.TabIndex = 111
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.btnGetDisAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnGetDisAmt.Text = "Command1"
		Me.btnGetDisAmt.Size = New System.Drawing.Size(129, 25)
		Me.btnGetDisAmt.Location = New System.Drawing.Point(120, 88)
		Me.btnGetDisAmt.Image = CType(resources.GetObject("btnGetDisAmt.Image"), System.Drawing.Image)
		Me.btnGetDisAmt.TabIndex = 14
		Me.btnGetDisAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGetDisAmt.BackColor = System.Drawing.SystemColors.Control
		Me.btnGetDisAmt.CausesValidation = True
		Me.btnGetDisAmt.Enabled = True
		Me.btnGetDisAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnGetDisAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnGetDisAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnGetDisAmt.TabStop = True
		Me.btnGetDisAmt.Name = "btnGetDisAmt"
		Me.txtDisAmt.AutoSize = False
		Me.txtDisAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDisAmt.Size = New System.Drawing.Size(137, 20)
		Me.txtDisAmt.Location = New System.Drawing.Point(120, 64)
		Me.txtDisAmt.Maxlength = 20
		Me.txtDisAmt.TabIndex = 13
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
		Me.txtSpecDis.AutoSize = False
		Me.txtSpecDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtSpecDis.Size = New System.Drawing.Size(81, 20)
		Me.txtSpecDis.Location = New System.Drawing.Point(120, 40)
		Me.txtSpecDis.Maxlength = 20
		Me.txtSpecDis.TabIndex = 12
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
		Me.lblDisAmt.Text = "EXCR"
		Me.lblDisAmt.Size = New System.Drawing.Size(96, 33)
		Me.lblDisAmt.Location = New System.Drawing.Point(16, 64)
		Me.lblDisAmt.TabIndex = 124
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
		Me.lblSpecDis.Text = "SPECDIS"
		Me.lblSpecDis.Size = New System.Drawing.Size(103, 17)
		Me.lblSpecDis.Location = New System.Drawing.Point(16, 44)
		Me.lblSpecDis.TabIndex = 112
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
		Me.cboCurr.Size = New System.Drawing.Size(89, 20)
		Me.cboCurr.Location = New System.Drawing.Point(632, 76)
		Me.cboCurr.TabIndex = 4
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
		Me.cboPayCode.Size = New System.Drawing.Size(158, 20)
		Me.cboPayCode.Location = New System.Drawing.Point(120, 188)
		Me.cboPayCode.TabIndex = 7
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
		Me.cboPrcCode.Location = New System.Drawing.Point(120, 212)
		Me.cboPrcCode.TabIndex = 8
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
		Me.cboMLCode.Location = New System.Drawing.Point(120, 236)
		Me.cboMLCode.TabIndex = 9
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
		Me.cboSaleCode.Location = New System.Drawing.Point(120, 164)
		Me.cboSaleCode.TabIndex = 6
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
		Me.FraDate.Size = New System.Drawing.Size(265, 65)
		Me.FraDate.Location = New System.Drawing.Point(8, 272)
		Me.FraDate.TabIndex = 64
		Me.FraDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraDate.BackColor = System.Drawing.SystemColors.Control
		Me.FraDate.Enabled = True
		Me.FraDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraDate.Visible = True
		Me.FraDate.Padding = New System.Windows.Forms.Padding(0)
		Me.FraDate.Name = "FraDate"
		Me.medDueDate.AllowPromptAsInput = False
		Me.medDueDate.Size = New System.Drawing.Size(81, 19)
		Me.medDueDate.Location = New System.Drawing.Point(120, 16)
		Me.medDueDate.TabIndex = 10
		Me.medDueDate.MaxLength = 10
		Me.medDueDate.Mask = "##/##/####"
		Me.medDueDate.PromptChar = "_"
		Me.medDueDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDueDate.Name = "medDueDate"
		Me.medExpiryDate.AllowPromptAsInput = False
		Me.medExpiryDate.Size = New System.Drawing.Size(81, 19)
		Me.medExpiryDate.Location = New System.Drawing.Point(120, 40)
		Me.medExpiryDate.TabIndex = 11
		Me.medExpiryDate.MaxLength = 10
		Me.medExpiryDate.Mask = "##/##/####"
		Me.medExpiryDate.PromptChar = "_"
		Me.medExpiryDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medExpiryDate.Name = "medExpiryDate"
		Me.lblExpiryDate.Text = "ETADATE"
		Me.lblExpiryDate.Size = New System.Drawing.Size(99, 17)
		Me.lblExpiryDate.Location = New System.Drawing.Point(16, 44)
		Me.lblExpiryDate.TabIndex = 66
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
		Me.lblDueDate.Text = "DUEDATE"
		Me.lblDueDate.Size = New System.Drawing.Size(103, 17)
		Me.lblDueDate.Location = New System.Drawing.Point(16, 20)
		Me.lblDueDate.TabIndex = 65
		Me.lblDueDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDueDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDueDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDueDate.Enabled = True
		Me.lblDueDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDueDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDueDate.UseMnemonic = True
		Me.lblDueDate.Visible = True
		Me.lblDueDate.AutoSize = False
		Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDueDate.Name = "lblDueDate"
		Me.fraInfo.Size = New System.Drawing.Size(505, 241)
		Me.fraInfo.Location = New System.Drawing.Point(280, 272)
		Me.fraInfo.TabIndex = 57
		Me.fraInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraInfo.Enabled = True
		Me.fraInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraInfo.Visible = True
		Me.fraInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraInfo.Name = "fraInfo"
		Me.txtDelAdr4.AutoSize = False
		Me.txtDelAdr4.Enabled = False
		Me.txtDelAdr4.Size = New System.Drawing.Size(351, 20)
		Me.txtDelAdr4.Location = New System.Drawing.Point(136, 136)
		Me.txtDelAdr4.TabIndex = 20
		Me.txtDelAdr4.Text = "0123456789012345789"
		Me.txtDelAdr4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDelAdr4.AcceptsReturn = True
		Me.txtDelAdr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDelAdr4.BackColor = System.Drawing.SystemColors.Window
		Me.txtDelAdr4.CausesValidation = True
		Me.txtDelAdr4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDelAdr4.HideSelection = True
		Me.txtDelAdr4.ReadOnly = False
		Me.txtDelAdr4.Maxlength = 0
		Me.txtDelAdr4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDelAdr4.MultiLine = False
		Me.txtDelAdr4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDelAdr4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDelAdr4.TabStop = True
		Me.txtDelAdr4.Visible = True
		Me.txtDelAdr4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDelAdr4.Name = "txtDelAdr4"
		Me.txtDelAdr3.AutoSize = False
		Me.txtDelAdr3.Enabled = False
		Me.txtDelAdr3.Size = New System.Drawing.Size(351, 20)
		Me.txtDelAdr3.Location = New System.Drawing.Point(136, 112)
		Me.txtDelAdr3.TabIndex = 19
		Me.txtDelAdr3.Text = "0123456789012345789"
		Me.txtDelAdr3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDelAdr3.AcceptsReturn = True
		Me.txtDelAdr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDelAdr3.BackColor = System.Drawing.SystemColors.Window
		Me.txtDelAdr3.CausesValidation = True
		Me.txtDelAdr3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDelAdr3.HideSelection = True
		Me.txtDelAdr3.ReadOnly = False
		Me.txtDelAdr3.Maxlength = 0
		Me.txtDelAdr3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDelAdr3.MultiLine = False
		Me.txtDelAdr3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDelAdr3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDelAdr3.TabStop = True
		Me.txtDelAdr3.Visible = True
		Me.txtDelAdr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDelAdr3.Name = "txtDelAdr3"
		Me.txtLcNo.AutoSize = False
		Me.txtLcNo.Enabled = False
		Me.txtLcNo.Size = New System.Drawing.Size(351, 20)
		Me.txtLcNo.Location = New System.Drawing.Point(136, 192)
		Me.txtLcNo.TabIndex = 22
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
		Me.txtPortNo.Location = New System.Drawing.Point(136, 216)
		Me.txtPortNo.TabIndex = 23
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
		Me.txtCusPo.Location = New System.Drawing.Point(136, 168)
		Me.txtCusPo.TabIndex = 21
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
		Me.txtDelAdr1.AutoSize = False
		Me.txtDelAdr1.Enabled = False
		Me.txtDelAdr1.Size = New System.Drawing.Size(351, 20)
		Me.txtDelAdr1.Location = New System.Drawing.Point(136, 64)
		Me.txtDelAdr1.TabIndex = 17
		Me.txtDelAdr1.Text = "0123456789012345789"
		Me.txtDelAdr1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDelAdr1.AcceptsReturn = True
		Me.txtDelAdr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDelAdr1.BackColor = System.Drawing.SystemColors.Window
		Me.txtDelAdr1.CausesValidation = True
		Me.txtDelAdr1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDelAdr1.HideSelection = True
		Me.txtDelAdr1.ReadOnly = False
		Me.txtDelAdr1.Maxlength = 0
		Me.txtDelAdr1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDelAdr1.MultiLine = False
		Me.txtDelAdr1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDelAdr1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDelAdr1.TabStop = True
		Me.txtDelAdr1.Visible = True
		Me.txtDelAdr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDelAdr1.Name = "txtDelAdr1"
		Me.txtDelAdr2.AutoSize = False
		Me.txtDelAdr2.Enabled = False
		Me.txtDelAdr2.Size = New System.Drawing.Size(351, 20)
		Me.txtDelAdr2.Location = New System.Drawing.Point(136, 88)
		Me.txtDelAdr2.TabIndex = 18
		Me.txtDelAdr2.Text = "0123456789012345789"
		Me.txtDelAdr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDelAdr2.AcceptsReturn = True
		Me.txtDelAdr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDelAdr2.BackColor = System.Drawing.SystemColors.Window
		Me.txtDelAdr2.CausesValidation = True
		Me.txtDelAdr2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDelAdr2.HideSelection = True
		Me.txtDelAdr2.ReadOnly = False
		Me.txtDelAdr2.Maxlength = 0
		Me.txtDelAdr2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDelAdr2.MultiLine = False
		Me.txtDelAdr2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDelAdr2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDelAdr2.TabStop = True
		Me.txtDelAdr2.Visible = True
		Me.txtDelAdr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDelAdr2.Name = "txtDelAdr2"
		Me.txtDelName.AutoSize = False
		Me.txtDelName.Enabled = False
		Me.txtDelName.Size = New System.Drawing.Size(351, 20)
		Me.txtDelName.Location = New System.Drawing.Point(136, 40)
		Me.txtDelName.TabIndex = 16
		Me.txtDelName.Text = "0123456789012345789"
		Me.txtDelName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDelName.AcceptsReturn = True
		Me.txtDelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDelName.BackColor = System.Drawing.SystemColors.Window
		Me.txtDelName.CausesValidation = True
		Me.txtDelName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDelName.HideSelection = True
		Me.txtDelName.ReadOnly = False
		Me.txtDelName.Maxlength = 0
		Me.txtDelName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDelName.MultiLine = False
		Me.txtDelName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDelName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDelName.TabStop = True
		Me.txtDelName.Visible = True
		Me.txtDelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDelName.Name = "txtDelName"
		Me.lblLcNo.Text = "LCNO"
		Me.lblLcNo.Size = New System.Drawing.Size(127, 16)
		Me.lblLcNo.Location = New System.Drawing.Point(8, 196)
		Me.lblLcNo.TabIndex = 63
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
		Me.lblPortNo.Size = New System.Drawing.Size(124, 16)
		Me.lblPortNo.Location = New System.Drawing.Point(8, 220)
		Me.lblPortNo.TabIndex = 62
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
		Me.lblCusPo.Size = New System.Drawing.Size(124, 16)
		Me.lblCusPo.Location = New System.Drawing.Point(8, 172)
		Me.lblCusPo.TabIndex = 61
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
		Me.lblDelAdr1.Text = "SHIPTO"
		Me.lblDelAdr1.Size = New System.Drawing.Size(124, 16)
		Me.lblDelAdr1.Location = New System.Drawing.Point(8, 68)
		Me.lblDelAdr1.TabIndex = 60
		Me.lblDelAdr1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDelAdr1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDelAdr1.BackColor = System.Drawing.SystemColors.Control
		Me.lblDelAdr1.Enabled = True
		Me.lblDelAdr1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDelAdr1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDelAdr1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDelAdr1.UseMnemonic = True
		Me.lblDelAdr1.Visible = True
		Me.lblDelAdr1.AutoSize = False
		Me.lblDelAdr1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDelAdr1.Name = "lblDelAdr1"
		Me.lblDelCode.Text = "SHIPVIA"
		Me.lblDelCode.Size = New System.Drawing.Size(124, 16)
		Me.lblDelCode.Location = New System.Drawing.Point(8, 16)
		Me.lblDelCode.TabIndex = 59
		Me.lblDelCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDelCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDelCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblDelCode.Enabled = True
		Me.lblDelCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDelCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDelCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDelCode.UseMnemonic = True
		Me.lblDelCode.Visible = True
		Me.lblDelCode.AutoSize = False
		Me.lblDelCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDelCode.Name = "lblDelCode"
		Me.lblDelName.Text = "SHIPFROM"
		Me.lblDelName.Size = New System.Drawing.Size(124, 16)
		Me.lblDelName.Location = New System.Drawing.Point(8, 44)
		Me.lblDelName.TabIndex = 58
		Me.lblDelName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDelName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDelName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDelName.Enabled = True
		Me.lblDelName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDelName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDelName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDelName.UseMnemonic = True
		Me.lblDelName.Visible = True
		Me.lblDelName.AutoSize = False
		Me.lblDelName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDelName.Name = "lblDelName"
		Me.fraCode.Size = New System.Drawing.Size(777, 137)
		Me.fraCode.Location = New System.Drawing.Point(8, 132)
		Me.fraCode.TabIndex = 75
		Me.fraCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCode.BackColor = System.Drawing.SystemColors.Control
		Me.fraCode.Enabled = True
		Me.fraCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCode.Visible = True
		Me.fraCode.Padding = New System.Windows.Forms.Padding(0)
		Me.fraCode.Name = "fraCode"
		Me.lblMlCode.Text = "MLCODE"
		Me.lblMlCode.Size = New System.Drawing.Size(103, 16)
		Me.lblMlCode.Location = New System.Drawing.Point(8, 108)
		Me.lblMlCode.TabIndex = 83
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
		Me.lblDspMLDesc.Location = New System.Drawing.Point(272, 104)
		Me.lblDspMLDesc.TabIndex = 82
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
		Me.lblPrcCode.Location = New System.Drawing.Point(8, 84)
		Me.lblPrcCode.TabIndex = 81
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
		Me.lblDspPrcDesc.Location = New System.Drawing.Point(272, 80)
		Me.lblDspPrcDesc.TabIndex = 80
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
		Me.lblPayCode.Location = New System.Drawing.Point(8, 60)
		Me.lblPayCode.TabIndex = 79
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
		Me.lblDspPayDesc.Location = New System.Drawing.Point(272, 56)
		Me.lblDspPayDesc.TabIndex = 78
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
		Me.lblSaleCode.Location = New System.Drawing.Point(8, 36)
		Me.lblSaleCode.TabIndex = 77
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
		Me.lblDspSaleDesc.Location = New System.Drawing.Point(272, 32)
		Me.lblDspSaleDesc.TabIndex = 76
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
		Me.fraKey.Size = New System.Drawing.Size(729, 121)
		Me.fraKey.Location = New System.Drawing.Point(8, 8)
		Me.fraKey.TabIndex = 94
		Me.fraKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraKey.BackColor = System.Drawing.SystemColors.Control
		Me.fraKey.Enabled = True
		Me.fraKey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraKey.Visible = True
		Me.fraKey.Padding = New System.Windows.Forms.Padding(0)
		Me.fraKey.Name = "fraKey"
		Me.chkWorkOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkWorkOrder.Text = "WORKORDER"
		Me.chkWorkOrder.Size = New System.Drawing.Size(153, 12)
		Me.chkWorkOrder.Location = New System.Drawing.Point(488, 24)
		Me.chkWorkOrder.TabIndex = 125
		Me.chkWorkOrder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkWorkOrder.BackColor = System.Drawing.SystemColors.Control
		Me.chkWorkOrder.CausesValidation = True
		Me.chkWorkOrder.Enabled = True
		Me.chkWorkOrder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkWorkOrder.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkWorkOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkWorkOrder.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkWorkOrder.TabStop = True
		Me.chkWorkOrder.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkWorkOrder.Visible = True
		Me.chkWorkOrder.Name = "chkWorkOrder"
		Me.txtExcr.AutoSize = False
		Me.txtExcr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtExcr.Size = New System.Drawing.Size(89, 20)
		Me.txtExcr.Location = New System.Drawing.Point(624, 92)
		Me.txtExcr.Maxlength = 20
		Me.txtExcr.TabIndex = 5
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
		Me.medDocDate.Location = New System.Drawing.Point(624, 44)
		Me.medDocDate.TabIndex = 3
		Me.medDocDate.MaxLength = 10
		Me.medDocDate.Mask = "##/##/####"
		Me.medDocDate.PromptChar = "_"
		Me.medDocDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDocDate.Name = "medDocDate"
		Me.lblRefDocNo.Text = "REFDOCNO"
		Me.lblRefDocNo.Size = New System.Drawing.Size(89, 17)
		Me.lblRefDocNo.Location = New System.Drawing.Point(256, 48)
		Me.lblRefDocNo.TabIndex = 123
		Me.lblRefDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRefDocNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRefDocNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblRefDocNo.Enabled = True
		Me.lblRefDocNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRefDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRefDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRefDocNo.UseMnemonic = True
		Me.lblRefDocNo.Visible = True
		Me.lblRefDocNo.AutoSize = False
		Me.lblRefDocNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRefDocNo.Name = "lblRefDocNo"
		Me.lblVdrCode.Text = "VDRCODE"
		Me.lblVdrCode.Size = New System.Drawing.Size(105, 17)
		Me.lblVdrCode.Location = New System.Drawing.Point(8, 47)
		Me.lblVdrCode.TabIndex = 105
		Me.lblVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrCode.Enabled = True
		Me.lblVdrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrCode.UseMnemonic = True
		Me.lblVdrCode.Visible = True
		Me.lblVdrCode.AutoSize = False
		Me.lblVdrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrCode.Name = "lblVdrCode"
		Me.lblDocNo.Text = "DOCNO"
		Me.lblDocNo.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDocNo.Size = New System.Drawing.Size(105, 17)
		Me.lblDocNo.Location = New System.Drawing.Point(8, 24)
		Me.lblDocNo.TabIndex = 104
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
		Me.lblDocDate.Location = New System.Drawing.Point(491, 48)
		Me.lblDocDate.TabIndex = 103
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
		Me.lblDspVdrName.Size = New System.Drawing.Size(369, 20)
		Me.lblDspVdrName.Location = New System.Drawing.Point(112, 68)
		Me.lblDspVdrName.TabIndex = 102
		Me.lblDspVdrName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspVdrName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrName.Enabled = True
		Me.lblDspVdrName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrName.UseMnemonic = True
		Me.lblDspVdrName.Visible = True
		Me.lblDspVdrName.AutoSize = False
		Me.lblDspVdrName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrName.Name = "lblDspVdrName"
		Me.LblCurr.Text = "CURR"
		Me.LblCurr.Size = New System.Drawing.Size(112, 17)
		Me.LblCurr.Location = New System.Drawing.Point(491, 72)
		Me.LblCurr.TabIndex = 101
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
		Me.lblExcr.Location = New System.Drawing.Point(491, 96)
		Me.lblExcr.TabIndex = 100
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
		Me.lblDspVdrTel.Size = New System.Drawing.Size(129, 20)
		Me.lblDspVdrTel.Location = New System.Drawing.Point(112, 92)
		Me.lblDspVdrTel.TabIndex = 99
		Me.lblDspVdrTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspVdrTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrTel.Enabled = True
		Me.lblDspVdrTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrTel.UseMnemonic = True
		Me.lblDspVdrTel.Visible = True
		Me.lblDspVdrTel.AutoSize = False
		Me.lblDspVdrTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrTel.Name = "lblDspVdrTel"
		Me.lblVdrName.Text = "VDRNAME"
		Me.lblVdrName.Size = New System.Drawing.Size(105, 17)
		Me.lblVdrName.Location = New System.Drawing.Point(8, 72)
		Me.lblVdrName.TabIndex = 98
		Me.lblVdrName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrName.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrName.Enabled = True
		Me.lblVdrName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrName.UseMnemonic = True
		Me.lblVdrName.Visible = True
		Me.lblVdrName.AutoSize = False
		Me.lblVdrName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrName.Name = "lblVdrName"
		Me.lblDspVdrFax.Size = New System.Drawing.Size(137, 20)
		Me.lblDspVdrFax.Location = New System.Drawing.Point(344, 92)
		Me.lblDspVdrFax.TabIndex = 97
		Me.lblDspVdrFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspVdrFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrFax.Enabled = True
		Me.lblDspVdrFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrFax.UseMnemonic = True
		Me.lblDspVdrFax.Visible = True
		Me.lblDspVdrFax.AutoSize = False
		Me.lblDspVdrFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrFax.Name = "lblDspVdrFax"
		Me.lblVdrFax.Text = "VDRFAX"
		Me.lblVdrFax.Size = New System.Drawing.Size(81, 17)
		Me.lblVdrFax.Location = New System.Drawing.Point(256, 96)
		Me.lblVdrFax.TabIndex = 96
		Me.lblVdrFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrFax.Enabled = True
		Me.lblVdrFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrFax.UseMnemonic = True
		Me.lblVdrFax.Visible = True
		Me.lblVdrFax.AutoSize = False
		Me.lblVdrFax.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrFax.Name = "lblVdrFax"
		Me.lblVdrTel.Text = "VDRTEL"
		Me.lblVdrTel.Size = New System.Drawing.Size(105, 17)
		Me.lblVdrTel.Location = New System.Drawing.Point(8, 96)
		Me.lblVdrTel.TabIndex = 95
		Me.lblVdrTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrTel.Enabled = True
		Me.lblVdrTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrTel.UseMnemonic = True
		Me.lblVdrTel.Visible = True
		Me.lblVdrTel.AutoSize = False
		Me.lblVdrTel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrTel.Name = "lblVdrTel"
		Me._tabDetailInfo_TabPage1.Text = "Shipment "
		Me.lblDspNetAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspNetAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspNetAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspNetAmtOrg.ForeColor = System.Drawing.Color.Blue
		Me.lblDspNetAmtOrg.Size = New System.Drawing.Size(214, 23)
		Me.lblDspNetAmtOrg.Location = New System.Drawing.Point(464, 28)
		Me.lblDspNetAmtOrg.TabIndex = 67
		Me.lblDspNetAmtOrg.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspNetAmtOrg.Enabled = True
		Me.lblDspNetAmtOrg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspNetAmtOrg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspNetAmtOrg.UseMnemonic = True
		Me.lblDspNetAmtOrg.Visible = True
		Me.lblDspNetAmtOrg.AutoSize = False
		Me.lblDspNetAmtOrg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspNetAmtOrg.Name = "lblDspNetAmtOrg"
		Me.lblDspDisAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspDisAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspDisAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspDisAmtOrg.Size = New System.Drawing.Size(158, 23)
		Me.lblDspDisAmtOrg.Location = New System.Drawing.Point(304, 28)
		Me.lblDspDisAmtOrg.TabIndex = 68
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
		Me.lblDspGrsAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspGrsAmtOrg.Text = "9.999.999.999.99"
		Me.lblDspGrsAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspGrsAmtOrg.Size = New System.Drawing.Size(166, 23)
		Me.lblDspGrsAmtOrg.Location = New System.Drawing.Point(136, 28)
		Me.lblDspGrsAmtOrg.TabIndex = 69
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
		Me.lblDspTotalQty.Size = New System.Drawing.Size(126, 23)
		Me.lblDspTotalQty.Location = New System.Drawing.Point(8, 28)
		Me.lblDspTotalQty.TabIndex = 70
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
		Me.lblNetAmtOrg.Size = New System.Drawing.Size(221, 17)
		Me.lblNetAmtOrg.Location = New System.Drawing.Point(464, 4)
		Me.lblNetAmtOrg.TabIndex = 71
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
		Me.lblDisAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDisAmtOrg.Text = "DISAMTORG"
		Me.lblDisAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisAmtOrg.Size = New System.Drawing.Size(157, 25)
		Me.lblDisAmtOrg.Location = New System.Drawing.Point(304, 4)
		Me.lblDisAmtOrg.TabIndex = 72
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
		Me.lblGrsAmtOrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblGrsAmtOrg.Text = "GRSAMTORG"
		Me.lblGrsAmtOrg.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrsAmtOrg.Size = New System.Drawing.Size(165, 17)
		Me.lblGrsAmtOrg.Location = New System.Drawing.Point(136, 4)
		Me.lblGrsAmtOrg.TabIndex = 73
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
		Me.lblTotalQty.Size = New System.Drawing.Size(117, 17)
		Me.lblTotalQty.Location = New System.Drawing.Point(16, 4)
		Me.lblTotalQty.TabIndex = 74
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
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(769, 425)
		Me.tblDetail.Location = New System.Drawing.Point(8, 52)
		Me.tblDetail.TabIndex = 24
		Me.tblDetail.Name = "tblDetail"
		Me.Frame1.Size = New System.Drawing.Size(409, 30)
		Me.Frame1.Location = New System.Drawing.Point(8, 480)
		Me.Frame1.TabIndex = 106
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
		Me.lblDeleteLine.TabIndex = 110
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
		Me.lblInsertLine.TabIndex = 109
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
		Me.lblComboPrompt.TabIndex = 108
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
		Me.lblKeyDesc.TabIndex = 107
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
		Me._cboShipCode_1.Size = New System.Drawing.Size(134, 20)
		Me._cboShipCode_1.Location = New System.Drawing.Point(512, 24)
		Me._cboShipCode_1.TabIndex = 34
		Me._cboShipCode_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboShipCode_1.BackColor = System.Drawing.SystemColors.Window
		Me._cboShipCode_1.CausesValidation = True
		Me._cboShipCode_1.Enabled = True
		Me._cboShipCode_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboShipCode_1.IntegralHeight = True
		Me._cboShipCode_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboShipCode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboShipCode_1.Sorted = False
		Me._cboShipCode_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboShipCode_1.TabStop = True
		Me._cboShipCode_1.Visible = True
		Me._cboShipCode_1.Name = "_cboShipCode_1"
		Me._fraShip_1.Size = New System.Drawing.Size(377, 233)
		Me._fraShip_1.Location = New System.Drawing.Point(400, 8)
		Me._fraShip_1.TabIndex = 115
		Me._fraShip_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraShip_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraShip_1.Enabled = True
		Me._fraShip_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraShip_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraShip_1.Visible = True
		Me._fraShip_1.Padding = New System.Windows.Forms.Padding(0)
		Me._fraShip_1.Name = "_fraShip_1"
		Me._txtShipPer_1.AutoSize = False
		Me._txtShipPer_1.Enabled = False
		Me._txtShipPer_1.Size = New System.Drawing.Size(239, 20)
		Me._txtShipPer_1.Location = New System.Drawing.Point(112, 40)
		Me._txtShipPer_1.TabIndex = 35
		Me._txtShipPer_1.Text = "01234567890123457890"
		Me._txtShipPer_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipPer_1.AcceptsReturn = True
		Me._txtShipPer_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipPer_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipPer_1.CausesValidation = True
		Me._txtShipPer_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipPer_1.HideSelection = True
		Me._txtShipPer_1.ReadOnly = False
		Me._txtShipPer_1.Maxlength = 0
		Me._txtShipPer_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipPer_1.MultiLine = False
		Me._txtShipPer_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipPer_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipPer_1.TabStop = True
		Me._txtShipPer_1.Visible = True
		Me._txtShipPer_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipPer_1.Name = "_txtShipPer_1"
		Me._txtShipName_1.AutoSize = False
		Me._txtShipName_1.Enabled = False
		Me._txtShipName_1.Size = New System.Drawing.Size(239, 20)
		Me._txtShipName_1.Location = New System.Drawing.Point(112, 64)
		Me._txtShipName_1.TabIndex = 36
		Me._txtShipName_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipName_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipName_1.AcceptsReturn = True
		Me._txtShipName_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipName_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipName_1.CausesValidation = True
		Me._txtShipName_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipName_1.HideSelection = True
		Me._txtShipName_1.ReadOnly = False
		Me._txtShipName_1.Maxlength = 0
		Me._txtShipName_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipName_1.MultiLine = False
		Me._txtShipName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipName_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipName_1.TabStop = True
		Me._txtShipName_1.Visible = True
		Me._txtShipName_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipName_1.Name = "_txtShipName_1"
		Me._Picture1_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me._Picture1_1.Size = New System.Drawing.Size(241, 89)
		Me._Picture1_1.Location = New System.Drawing.Point(112, 88)
		Me._Picture1_1.TabIndex = 116
		Me._Picture1_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Picture1_1.Dock = System.Windows.Forms.DockStyle.None
		Me._Picture1_1.CausesValidation = True
		Me._Picture1_1.Enabled = True
		Me._Picture1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Picture1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Picture1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Picture1_1.TabStop = True
		Me._Picture1_1.Visible = True
		Me._Picture1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._Picture1_1.Name = "_Picture1_1"
		Me._txtShipAdr1_1.AutoSize = False
		Me._txtShipAdr1_1.Enabled = False
		Me._txtShipAdr1_1.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr1_1.Location = New System.Drawing.Point(0, 0)
		Me._txtShipAdr1_1.TabIndex = 37
		Me._txtShipAdr1_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr1_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr1_1.AcceptsReturn = True
		Me._txtShipAdr1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr1_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr1_1.CausesValidation = True
		Me._txtShipAdr1_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr1_1.HideSelection = True
		Me._txtShipAdr1_1.ReadOnly = False
		Me._txtShipAdr1_1.Maxlength = 0
		Me._txtShipAdr1_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr1_1.MultiLine = False
		Me._txtShipAdr1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr1_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr1_1.TabStop = True
		Me._txtShipAdr1_1.Visible = True
		Me._txtShipAdr1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr1_1.Name = "_txtShipAdr1_1"
		Me._txtShipAdr2_1.AutoSize = False
		Me._txtShipAdr2_1.Enabled = False
		Me._txtShipAdr2_1.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr2_1.Location = New System.Drawing.Point(0, 24)
		Me._txtShipAdr2_1.TabIndex = 38
		Me._txtShipAdr2_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr2_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr2_1.AcceptsReturn = True
		Me._txtShipAdr2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr2_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr2_1.CausesValidation = True
		Me._txtShipAdr2_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr2_1.HideSelection = True
		Me._txtShipAdr2_1.ReadOnly = False
		Me._txtShipAdr2_1.Maxlength = 0
		Me._txtShipAdr2_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr2_1.MultiLine = False
		Me._txtShipAdr2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr2_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr2_1.TabStop = True
		Me._txtShipAdr2_1.Visible = True
		Me._txtShipAdr2_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr2_1.Name = "_txtShipAdr2_1"
		Me._txtShipAdr3_1.AutoSize = False
		Me._txtShipAdr3_1.Enabled = False
		Me._txtShipAdr3_1.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr3_1.Location = New System.Drawing.Point(0, 48)
		Me._txtShipAdr3_1.TabIndex = 39
		Me._txtShipAdr3_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr3_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr3_1.AcceptsReturn = True
		Me._txtShipAdr3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr3_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr3_1.CausesValidation = True
		Me._txtShipAdr3_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr3_1.HideSelection = True
		Me._txtShipAdr3_1.ReadOnly = False
		Me._txtShipAdr3_1.Maxlength = 0
		Me._txtShipAdr3_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr3_1.MultiLine = False
		Me._txtShipAdr3_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr3_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr3_1.TabStop = True
		Me._txtShipAdr3_1.Visible = True
		Me._txtShipAdr3_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr3_1.Name = "_txtShipAdr3_1"
		Me._txtShipAdr4_1.AutoSize = False
		Me._txtShipAdr4_1.Enabled = False
		Me._txtShipAdr4_1.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr4_1.Location = New System.Drawing.Point(0, 72)
		Me._txtShipAdr4_1.TabIndex = 40
		Me._txtShipAdr4_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr4_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr4_1.AcceptsReturn = True
		Me._txtShipAdr4_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr4_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr4_1.CausesValidation = True
		Me._txtShipAdr4_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr4_1.HideSelection = True
		Me._txtShipAdr4_1.ReadOnly = False
		Me._txtShipAdr4_1.Maxlength = 0
		Me._txtShipAdr4_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr4_1.MultiLine = False
		Me._txtShipAdr4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr4_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr4_1.TabStop = True
		Me._txtShipAdr4_1.Visible = True
		Me._txtShipAdr4_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr4_1.Name = "_txtShipAdr4_1"
		Me._txtShipFaxNo_1.AutoSize = False
		Me._txtShipFaxNo_1.Enabled = False
		Me._txtShipFaxNo_1.Size = New System.Drawing.Size(127, 20)
		Me._txtShipFaxNo_1.Location = New System.Drawing.Point(112, 208)
		Me._txtShipFaxNo_1.TabIndex = 42
		Me._txtShipFaxNo_1.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipFaxNo_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipFaxNo_1.AcceptsReturn = True
		Me._txtShipFaxNo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipFaxNo_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipFaxNo_1.CausesValidation = True
		Me._txtShipFaxNo_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipFaxNo_1.HideSelection = True
		Me._txtShipFaxNo_1.ReadOnly = False
		Me._txtShipFaxNo_1.Maxlength = 0
		Me._txtShipFaxNo_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipFaxNo_1.MultiLine = False
		Me._txtShipFaxNo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipFaxNo_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipFaxNo_1.TabStop = True
		Me._txtShipFaxNo_1.Visible = True
		Me._txtShipFaxNo_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipFaxNo_1.Name = "_txtShipFaxNo_1"
		Me._txtShipTelNo_1.AutoSize = False
		Me._txtShipTelNo_1.Enabled = False
		Me._txtShipTelNo_1.Size = New System.Drawing.Size(125, 20)
		Me._txtShipTelNo_1.Location = New System.Drawing.Point(112, 184)
		Me._txtShipTelNo_1.TabIndex = 41
		Me._txtShipTelNo_1.Text = "01234567890123457890"
		Me._txtShipTelNo_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipTelNo_1.AcceptsReturn = True
		Me._txtShipTelNo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipTelNo_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipTelNo_1.CausesValidation = True
		Me._txtShipTelNo_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipTelNo_1.HideSelection = True
		Me._txtShipTelNo_1.ReadOnly = False
		Me._txtShipTelNo_1.Maxlength = 0
		Me._txtShipTelNo_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipTelNo_1.MultiLine = False
		Me._txtShipTelNo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipTelNo_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipTelNo_1.TabStop = True
		Me._txtShipTelNo_1.Visible = True
		Me._txtShipTelNo_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipTelNo_1.Name = "_txtShipTelNo_1"
		Me._lblShipAdr_1.Text = "SHIPADR"
		Me._lblShipAdr_1.Size = New System.Drawing.Size(100, 16)
		Me._lblShipAdr_1.Location = New System.Drawing.Point(8, 88)
		Me._lblShipAdr_1.TabIndex = 122
		Me._lblShipAdr_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipAdr_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipAdr_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipAdr_1.Enabled = True
		Me._lblShipAdr_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipAdr_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipAdr_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipAdr_1.UseMnemonic = True
		Me._lblShipAdr_1.Visible = True
		Me._lblShipAdr_1.AutoSize = False
		Me._lblShipAdr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipAdr_1.Name = "_lblShipAdr_1"
		Me._lblShipPer_1.Text = "SHIPPER"
		Me._lblShipPer_1.Size = New System.Drawing.Size(100, 16)
		Me._lblShipPer_1.Location = New System.Drawing.Point(8, 40)
		Me._lblShipPer_1.TabIndex = 121
		Me._lblShipPer_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipPer_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipPer_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipPer_1.Enabled = True
		Me._lblShipPer_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipPer_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipPer_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipPer_1.UseMnemonic = True
		Me._lblShipPer_1.Visible = True
		Me._lblShipPer_1.AutoSize = False
		Me._lblShipPer_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipPer_1.Name = "_lblShipPer_1"
		Me._lblShipName_1.Text = "SHIPNAME"
		Me._lblShipName_1.Size = New System.Drawing.Size(92, 16)
		Me._lblShipName_1.Location = New System.Drawing.Point(8, 64)
		Me._lblShipName_1.TabIndex = 120
		Me._lblShipName_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipName_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipName_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipName_1.Enabled = True
		Me._lblShipName_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipName_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipName_1.UseMnemonic = True
		Me._lblShipName_1.Visible = True
		Me._lblShipName_1.AutoSize = False
		Me._lblShipName_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipName_1.Name = "_lblShipName_1"
		Me._lblShipCode_1.Text = "SHIPCODE"
		Me._lblShipCode_1.Size = New System.Drawing.Size(100, 16)
		Me._lblShipCode_1.Location = New System.Drawing.Point(8, 16)
		Me._lblShipCode_1.TabIndex = 119
		Me._lblShipCode_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipCode_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipCode_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipCode_1.Enabled = True
		Me._lblShipCode_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipCode_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipCode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipCode_1.UseMnemonic = True
		Me._lblShipCode_1.Visible = True
		Me._lblShipCode_1.AutoSize = False
		Me._lblShipCode_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipCode_1.Name = "_lblShipCode_1"
		Me._lblShipFaxNo_1.Text = "SHIPNAME"
		Me._lblShipFaxNo_1.Size = New System.Drawing.Size(92, 16)
		Me._lblShipFaxNo_1.Location = New System.Drawing.Point(8, 208)
		Me._lblShipFaxNo_1.TabIndex = 118
		Me._lblShipFaxNo_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipFaxNo_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipFaxNo_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipFaxNo_1.Enabled = True
		Me._lblShipFaxNo_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipFaxNo_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipFaxNo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipFaxNo_1.UseMnemonic = True
		Me._lblShipFaxNo_1.Visible = True
		Me._lblShipFaxNo_1.AutoSize = False
		Me._lblShipFaxNo_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipFaxNo_1.Name = "_lblShipFaxNo_1"
		Me._lblShipTelNo_1.Text = "SHIPPER"
		Me._lblShipTelNo_1.Size = New System.Drawing.Size(100, 16)
		Me._lblShipTelNo_1.Location = New System.Drawing.Point(8, 184)
		Me._lblShipTelNo_1.TabIndex = 117
		Me._lblShipTelNo_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipTelNo_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipTelNo_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipTelNo_1.Enabled = True
		Me._lblShipTelNo_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipTelNo_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipTelNo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipTelNo_1.UseMnemonic = True
		Me._lblShipTelNo_1.Visible = True
		Me._lblShipTelNo_1.AutoSize = False
		Me._lblShipTelNo_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipTelNo_1.Name = "_lblShipTelNo_1"
		Me._cboShipCode_0.Size = New System.Drawing.Size(134, 20)
		Me._cboShipCode_0.Location = New System.Drawing.Point(120, 24)
		Me._cboShipCode_0.TabIndex = 25
		Me._cboShipCode_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboShipCode_0.BackColor = System.Drawing.SystemColors.Window
		Me._cboShipCode_0.CausesValidation = True
		Me._cboShipCode_0.Enabled = True
		Me._cboShipCode_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboShipCode_0.IntegralHeight = True
		Me._cboShipCode_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboShipCode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboShipCode_0.Sorted = False
		Me._cboShipCode_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboShipCode_0.TabStop = True
		Me._cboShipCode_0.Visible = True
		Me._cboShipCode_0.Name = "_cboShipCode_0"
		Me._fraShip_0.Text = "CCC"
		Me._fraShip_0.Size = New System.Drawing.Size(385, 233)
		Me._fraShip_0.Location = New System.Drawing.Point(8, 8)
		Me._fraShip_0.TabIndex = 84
		Me._fraShip_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraShip_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraShip_0.Enabled = True
		Me._fraShip_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fraShip_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraShip_0.Visible = True
		Me._fraShip_0.Padding = New System.Windows.Forms.Padding(0)
		Me._fraShip_0.Name = "_fraShip_0"
		Me._txtShipTelNo_0.AutoSize = False
		Me._txtShipTelNo_0.Enabled = False
		Me._txtShipTelNo_0.Size = New System.Drawing.Size(125, 20)
		Me._txtShipTelNo_0.Location = New System.Drawing.Point(112, 184)
		Me._txtShipTelNo_0.TabIndex = 32
		Me._txtShipTelNo_0.Text = "01234567890123457890"
		Me._txtShipTelNo_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipTelNo_0.AcceptsReturn = True
		Me._txtShipTelNo_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipTelNo_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipTelNo_0.CausesValidation = True
		Me._txtShipTelNo_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipTelNo_0.HideSelection = True
		Me._txtShipTelNo_0.ReadOnly = False
		Me._txtShipTelNo_0.Maxlength = 0
		Me._txtShipTelNo_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipTelNo_0.MultiLine = False
		Me._txtShipTelNo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipTelNo_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipTelNo_0.TabStop = True
		Me._txtShipTelNo_0.Visible = True
		Me._txtShipTelNo_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipTelNo_0.Name = "_txtShipTelNo_0"
		Me._txtShipFaxNo_0.AutoSize = False
		Me._txtShipFaxNo_0.Enabled = False
		Me._txtShipFaxNo_0.Size = New System.Drawing.Size(127, 20)
		Me._txtShipFaxNo_0.Location = New System.Drawing.Point(112, 208)
		Me._txtShipFaxNo_0.TabIndex = 33
		Me._txtShipFaxNo_0.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipFaxNo_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipFaxNo_0.AcceptsReturn = True
		Me._txtShipFaxNo_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipFaxNo_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipFaxNo_0.CausesValidation = True
		Me._txtShipFaxNo_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipFaxNo_0.HideSelection = True
		Me._txtShipFaxNo_0.ReadOnly = False
		Me._txtShipFaxNo_0.Maxlength = 0
		Me._txtShipFaxNo_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipFaxNo_0.MultiLine = False
		Me._txtShipFaxNo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipFaxNo_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipFaxNo_0.TabStop = True
		Me._txtShipFaxNo_0.Visible = True
		Me._txtShipFaxNo_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipFaxNo_0.Name = "_txtShipFaxNo_0"
		Me._Picture1_0.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me._Picture1_0.Size = New System.Drawing.Size(241, 89)
		Me._Picture1_0.Location = New System.Drawing.Point(112, 88)
		Me._Picture1_0.TabIndex = 85
		Me._Picture1_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Picture1_0.Dock = System.Windows.Forms.DockStyle.None
		Me._Picture1_0.CausesValidation = True
		Me._Picture1_0.Enabled = True
		Me._Picture1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Picture1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Picture1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Picture1_0.TabStop = True
		Me._Picture1_0.Visible = True
		Me._Picture1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._Picture1_0.Name = "_Picture1_0"
		Me._txtShipAdr4_0.AutoSize = False
		Me._txtShipAdr4_0.Enabled = False
		Me._txtShipAdr4_0.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr4_0.Location = New System.Drawing.Point(0, 72)
		Me._txtShipAdr4_0.TabIndex = 31
		Me._txtShipAdr4_0.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr4_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr4_0.AcceptsReturn = True
		Me._txtShipAdr4_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr4_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr4_0.CausesValidation = True
		Me._txtShipAdr4_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr4_0.HideSelection = True
		Me._txtShipAdr4_0.ReadOnly = False
		Me._txtShipAdr4_0.Maxlength = 0
		Me._txtShipAdr4_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr4_0.MultiLine = False
		Me._txtShipAdr4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr4_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr4_0.TabStop = True
		Me._txtShipAdr4_0.Visible = True
		Me._txtShipAdr4_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr4_0.Name = "_txtShipAdr4_0"
		Me._txtShipAdr3_0.AutoSize = False
		Me._txtShipAdr3_0.Enabled = False
		Me._txtShipAdr3_0.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr3_0.Location = New System.Drawing.Point(0, 48)
		Me._txtShipAdr3_0.TabIndex = 30
		Me._txtShipAdr3_0.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr3_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr3_0.AcceptsReturn = True
		Me._txtShipAdr3_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr3_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr3_0.CausesValidation = True
		Me._txtShipAdr3_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr3_0.HideSelection = True
		Me._txtShipAdr3_0.ReadOnly = False
		Me._txtShipAdr3_0.Maxlength = 0
		Me._txtShipAdr3_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr3_0.MultiLine = False
		Me._txtShipAdr3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr3_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr3_0.TabStop = True
		Me._txtShipAdr3_0.Visible = True
		Me._txtShipAdr3_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr3_0.Name = "_txtShipAdr3_0"
		Me._txtShipAdr2_0.AutoSize = False
		Me._txtShipAdr2_0.Enabled = False
		Me._txtShipAdr2_0.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr2_0.Location = New System.Drawing.Point(0, 24)
		Me._txtShipAdr2_0.TabIndex = 29
		Me._txtShipAdr2_0.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr2_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr2_0.AcceptsReturn = True
		Me._txtShipAdr2_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr2_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr2_0.CausesValidation = True
		Me._txtShipAdr2_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr2_0.HideSelection = True
		Me._txtShipAdr2_0.ReadOnly = False
		Me._txtShipAdr2_0.Maxlength = 0
		Me._txtShipAdr2_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr2_0.MultiLine = False
		Me._txtShipAdr2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr2_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr2_0.TabStop = True
		Me._txtShipAdr2_0.Visible = True
		Me._txtShipAdr2_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr2_0.Name = "_txtShipAdr2_0"
		Me._txtShipAdr1_0.AutoSize = False
		Me._txtShipAdr1_0.Enabled = False
		Me._txtShipAdr1_0.Size = New System.Drawing.Size(231, 20)
		Me._txtShipAdr1_0.Location = New System.Drawing.Point(0, 0)
		Me._txtShipAdr1_0.TabIndex = 28
		Me._txtShipAdr1_0.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipAdr1_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr1_0.AcceptsReturn = True
		Me._txtShipAdr1_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr1_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr1_0.CausesValidation = True
		Me._txtShipAdr1_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr1_0.HideSelection = True
		Me._txtShipAdr1_0.ReadOnly = False
		Me._txtShipAdr1_0.Maxlength = 0
		Me._txtShipAdr1_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr1_0.MultiLine = False
		Me._txtShipAdr1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr1_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr1_0.TabStop = True
		Me._txtShipAdr1_0.Visible = True
		Me._txtShipAdr1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr1_0.Name = "_txtShipAdr1_0"
		Me._txtShipName_0.AutoSize = False
		Me._txtShipName_0.Enabled = False
		Me._txtShipName_0.Size = New System.Drawing.Size(239, 20)
		Me._txtShipName_0.Location = New System.Drawing.Point(112, 64)
		Me._txtShipName_0.TabIndex = 27
		Me._txtShipName_0.Text = "012345678901234578901234567890123457890123456789"
		Me._txtShipName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipName_0.AcceptsReturn = True
		Me._txtShipName_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipName_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipName_0.CausesValidation = True
		Me._txtShipName_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipName_0.HideSelection = True
		Me._txtShipName_0.ReadOnly = False
		Me._txtShipName_0.Maxlength = 0
		Me._txtShipName_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipName_0.MultiLine = False
		Me._txtShipName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipName_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipName_0.TabStop = True
		Me._txtShipName_0.Visible = True
		Me._txtShipName_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipName_0.Name = "_txtShipName_0"
		Me._txtShipPer_0.AutoSize = False
		Me._txtShipPer_0.Enabled = False
		Me._txtShipPer_0.Size = New System.Drawing.Size(239, 20)
		Me._txtShipPer_0.Location = New System.Drawing.Point(112, 40)
		Me._txtShipPer_0.TabIndex = 26
		Me._txtShipPer_0.Text = "01234567890123457890"
		Me._txtShipPer_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipPer_0.AcceptsReturn = True
		Me._txtShipPer_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipPer_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipPer_0.CausesValidation = True
		Me._txtShipPer_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipPer_0.HideSelection = True
		Me._txtShipPer_0.ReadOnly = False
		Me._txtShipPer_0.Maxlength = 0
		Me._txtShipPer_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipPer_0.MultiLine = False
		Me._txtShipPer_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipPer_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipPer_0.TabStop = True
		Me._txtShipPer_0.Visible = True
		Me._txtShipPer_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtShipPer_0.Name = "_txtShipPer_0"
		Me._lblShipTelNo_0.Text = "SHIPPER"
		Me._lblShipTelNo_0.Size = New System.Drawing.Size(100, 16)
		Me._lblShipTelNo_0.Location = New System.Drawing.Point(8, 184)
		Me._lblShipTelNo_0.TabIndex = 114
		Me._lblShipTelNo_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipTelNo_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipTelNo_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipTelNo_0.Enabled = True
		Me._lblShipTelNo_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipTelNo_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipTelNo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipTelNo_0.UseMnemonic = True
		Me._lblShipTelNo_0.Visible = True
		Me._lblShipTelNo_0.AutoSize = False
		Me._lblShipTelNo_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipTelNo_0.Name = "_lblShipTelNo_0"
		Me._lblShipFaxNo_0.Text = "SHIPNAME"
		Me._lblShipFaxNo_0.Size = New System.Drawing.Size(92, 16)
		Me._lblShipFaxNo_0.Location = New System.Drawing.Point(8, 208)
		Me._lblShipFaxNo_0.TabIndex = 113
		Me._lblShipFaxNo_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipFaxNo_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipFaxNo_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipFaxNo_0.Enabled = True
		Me._lblShipFaxNo_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipFaxNo_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipFaxNo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipFaxNo_0.UseMnemonic = True
		Me._lblShipFaxNo_0.Visible = True
		Me._lblShipFaxNo_0.AutoSize = False
		Me._lblShipFaxNo_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipFaxNo_0.Name = "_lblShipFaxNo_0"
		Me._lblShipCode_0.Text = "SHIPCODE"
		Me._lblShipCode_0.Size = New System.Drawing.Size(100, 16)
		Me._lblShipCode_0.Location = New System.Drawing.Point(8, 16)
		Me._lblShipCode_0.TabIndex = 89
		Me._lblShipCode_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipCode_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipCode_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipCode_0.Enabled = True
		Me._lblShipCode_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipCode_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipCode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipCode_0.UseMnemonic = True
		Me._lblShipCode_0.Visible = True
		Me._lblShipCode_0.AutoSize = False
		Me._lblShipCode_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipCode_0.Name = "_lblShipCode_0"
		Me._lblShipName_0.Text = "SHIPNAME"
		Me._lblShipName_0.Size = New System.Drawing.Size(92, 16)
		Me._lblShipName_0.Location = New System.Drawing.Point(8, 64)
		Me._lblShipName_0.TabIndex = 88
		Me._lblShipName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipName_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipName_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipName_0.Enabled = True
		Me._lblShipName_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipName_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipName_0.UseMnemonic = True
		Me._lblShipName_0.Visible = True
		Me._lblShipName_0.AutoSize = False
		Me._lblShipName_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipName_0.Name = "_lblShipName_0"
		Me._lblShipPer_0.Text = "SHIPPER"
		Me._lblShipPer_0.Size = New System.Drawing.Size(100, 16)
		Me._lblShipPer_0.Location = New System.Drawing.Point(8, 40)
		Me._lblShipPer_0.TabIndex = 87
		Me._lblShipPer_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipPer_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipPer_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipPer_0.Enabled = True
		Me._lblShipPer_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipPer_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipPer_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipPer_0.UseMnemonic = True
		Me._lblShipPer_0.Visible = True
		Me._lblShipPer_0.AutoSize = False
		Me._lblShipPer_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipPer_0.Name = "_lblShipPer_0"
		Me._lblShipAdr_0.Text = "SHIPADR"
		Me._lblShipAdr_0.Size = New System.Drawing.Size(100, 16)
		Me._lblShipAdr_0.Location = New System.Drawing.Point(8, 88)
		Me._lblShipAdr_0.TabIndex = 86
		Me._lblShipAdr_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblShipAdr_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblShipAdr_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblShipAdr_0.Enabled = True
		Me._lblShipAdr_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblShipAdr_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblShipAdr_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblShipAdr_0.UseMnemonic = True
		Me._lblShipAdr_0.Visible = True
		Me._lblShipAdr_0.AutoSize = False
		Me._lblShipAdr_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblShipAdr_0.Name = "_lblShipAdr_0"
		Me.cboRmkCode.Size = New System.Drawing.Size(126, 20)
		Me.cboRmkCode.Location = New System.Drawing.Point(120, 256)
		Me.cboRmkCode.TabIndex = 43
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
		Me.fraRmk.Size = New System.Drawing.Size(769, 273)
		Me.fraRmk.Location = New System.Drawing.Point(8, 240)
		Me.fraRmk.TabIndex = 90
		Me.fraRmk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraRmk.BackColor = System.Drawing.SystemColors.Control
		Me.fraRmk.Enabled = True
		Me.fraRmk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraRmk.Visible = True
		Me.fraRmk.Padding = New System.Windows.Forms.Padding(0)
		Me.fraRmk.Name = "fraRmk"
		Me.picRmk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.picRmk.Size = New System.Drawing.Size(633, 225)
		Me.picRmk.Location = New System.Drawing.Point(112, 40)
		Me.picRmk.TabIndex = 91
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
		Me._txtRmk_2.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_2.Location = New System.Drawing.Point(0, 24)
		Me._txtRmk_2.TabIndex = 45
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
		Me._txtRmk_1.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_1.Location = New System.Drawing.Point(0, 0)
		Me._txtRmk_1.TabIndex = 44
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
		Me._txtRmk_3.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_3.Location = New System.Drawing.Point(0, 46)
		Me._txtRmk_3.TabIndex = 46
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
		Me._txtRmk_6.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_6.Location = New System.Drawing.Point(0, 116)
		Me._txtRmk_6.TabIndex = 49
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
		Me._txtRmk_4.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_4.Location = New System.Drawing.Point(0, 69)
		Me._txtRmk_4.TabIndex = 47
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
		Me._txtRmk_5.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_5.Location = New System.Drawing.Point(0, 93)
		Me._txtRmk_5.TabIndex = 48
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
		Me._txtRmk_7.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_7.Location = New System.Drawing.Point(0, 139)
		Me._txtRmk_7.TabIndex = 50
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
		Me._txtRmk_8.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_8.Location = New System.Drawing.Point(0, 162)
		Me._txtRmk_8.TabIndex = 51
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
		Me._txtRmk_9.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_9.Location = New System.Drawing.Point(0, 185)
		Me._txtRmk_9.TabIndex = 52
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
		Me._txtRmk_10.Size = New System.Drawing.Size(599, 20)
		Me._txtRmk_10.Location = New System.Drawing.Point(0, 208)
		Me._txtRmk_10.TabIndex = 53
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
		Me.lblRmkCode.Size = New System.Drawing.Size(92, 24)
		Me.lblRmkCode.Location = New System.Drawing.Point(8, 40)
		Me.lblRmkCode.TabIndex = 93
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
		Me.lblRmk.Size = New System.Drawing.Size(100, 23)
		Me.lblRmk.Location = New System.Drawing.Point(8, 16)
		Me.lblRmk.TabIndex = 92
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
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage2)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboRefDocNo)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboVdrCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboDelCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(Frame2)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboCurr)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboDocNo)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboPayCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboPrcCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboMLCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboSaleCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(FraDate)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraInfo)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(fraKey)
		Me.Frame2.Controls.Add(btnGetDisAmt)
		Me.Frame2.Controls.Add(txtDisAmt)
		Me.Frame2.Controls.Add(txtSpecDis)
		Me.Frame2.Controls.Add(lblDisAmt)
		Me.Frame2.Controls.Add(lblSpecDis)
		Me.FraDate.Controls.Add(medDueDate)
		Me.FraDate.Controls.Add(medExpiryDate)
		Me.FraDate.Controls.Add(lblExpiryDate)
		Me.FraDate.Controls.Add(lblDueDate)
		Me.fraInfo.Controls.Add(txtDelAdr4)
		Me.fraInfo.Controls.Add(txtDelAdr3)
		Me.fraInfo.Controls.Add(txtLcNo)
		Me.fraInfo.Controls.Add(txtPortNo)
		Me.fraInfo.Controls.Add(txtCusPo)
		Me.fraInfo.Controls.Add(txtDelAdr1)
		Me.fraInfo.Controls.Add(txtDelAdr2)
		Me.fraInfo.Controls.Add(txtDelName)
		Me.fraInfo.Controls.Add(lblLcNo)
		Me.fraInfo.Controls.Add(lblPortNo)
		Me.fraInfo.Controls.Add(lblCusPo)
		Me.fraInfo.Controls.Add(lblDelAdr1)
		Me.fraInfo.Controls.Add(lblDelCode)
		Me.fraInfo.Controls.Add(lblDelName)
		Me.fraCode.Controls.Add(lblMlCode)
		Me.fraCode.Controls.Add(lblDspMLDesc)
		Me.fraCode.Controls.Add(lblPrcCode)
		Me.fraCode.Controls.Add(lblDspPrcDesc)
		Me.fraCode.Controls.Add(lblPayCode)
		Me.fraCode.Controls.Add(lblDspPayDesc)
		Me.fraCode.Controls.Add(lblSaleCode)
		Me.fraCode.Controls.Add(lblDspSaleDesc)
		Me.fraKey.Controls.Add(chkWorkOrder)
		Me.fraKey.Controls.Add(txtExcr)
		Me.fraKey.Controls.Add(medDocDate)
		Me.fraKey.Controls.Add(lblRefDocNo)
		Me.fraKey.Controls.Add(lblVdrCode)
		Me.fraKey.Controls.Add(lblDocNo)
		Me.fraKey.Controls.Add(lblDocDate)
		Me.fraKey.Controls.Add(lblDspVdrName)
		Me.fraKey.Controls.Add(LblCurr)
		Me.fraKey.Controls.Add(lblExcr)
		Me.fraKey.Controls.Add(lblDspVdrTel)
		Me.fraKey.Controls.Add(lblVdrName)
		Me.fraKey.Controls.Add(lblDspVdrFax)
		Me.fraKey.Controls.Add(lblVdrFax)
		Me.fraKey.Controls.Add(lblVdrTel)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspNetAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspDisAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspGrsAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDspTotalQty)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblNetAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblDisAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblGrsAmtOrg)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblTotalQty)
		Me._tabDetailInfo_TabPage1.Controls.Add(tblDetail)
		Me._tabDetailInfo_TabPage1.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(lblDeleteLine)
		Me.Frame1.Controls.Add(lblInsertLine)
		Me.Frame1.Controls.Add(lblComboPrompt)
		Me.Frame1.Controls.Add(lblKeyDesc)
		Me._tabDetailInfo_TabPage2.Controls.Add(_cboShipCode_1)
		Me._tabDetailInfo_TabPage2.Controls.Add(_fraShip_1)
		Me._tabDetailInfo_TabPage2.Controls.Add(_cboShipCode_0)
		Me._tabDetailInfo_TabPage2.Controls.Add(_fraShip_0)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboRmkCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(fraRmk)
		Me._fraShip_1.Controls.Add(_txtShipPer_1)
		Me._fraShip_1.Controls.Add(_txtShipName_1)
		Me._fraShip_1.Controls.Add(_Picture1_1)
		Me._fraShip_1.Controls.Add(_txtShipFaxNo_1)
		Me._fraShip_1.Controls.Add(_txtShipTelNo_1)
		Me._fraShip_1.Controls.Add(_lblShipAdr_1)
		Me._fraShip_1.Controls.Add(_lblShipPer_1)
		Me._fraShip_1.Controls.Add(_lblShipName_1)
		Me._fraShip_1.Controls.Add(_lblShipCode_1)
		Me._fraShip_1.Controls.Add(_lblShipFaxNo_1)
		Me._fraShip_1.Controls.Add(_lblShipTelNo_1)
		Me._Picture1_1.Controls.Add(_txtShipAdr1_1)
		Me._Picture1_1.Controls.Add(_txtShipAdr2_1)
		Me._Picture1_1.Controls.Add(_txtShipAdr3_1)
		Me._Picture1_1.Controls.Add(_txtShipAdr4_1)
		Me._fraShip_0.Controls.Add(_txtShipTelNo_0)
		Me._fraShip_0.Controls.Add(_txtShipFaxNo_0)
		Me._fraShip_0.Controls.Add(_Picture1_0)
		Me._fraShip_0.Controls.Add(_txtShipName_0)
		Me._fraShip_0.Controls.Add(_txtShipPer_0)
		Me._fraShip_0.Controls.Add(_lblShipTelNo_0)
		Me._fraShip_0.Controls.Add(_lblShipFaxNo_0)
		Me._fraShip_0.Controls.Add(_lblShipCode_0)
		Me._fraShip_0.Controls.Add(_lblShipName_0)
		Me._fraShip_0.Controls.Add(_lblShipPer_0)
		Me._fraShip_0.Controls.Add(_lblShipAdr_0)
		Me._Picture1_0.Controls.Add(_txtShipAdr4_0)
		Me._Picture1_0.Controls.Add(_txtShipAdr3_0)
		Me._Picture1_0.Controls.Add(_txtShipAdr2_0)
		Me._Picture1_0.Controls.Add(_txtShipAdr1_0)
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
		Me.Picture1.SetIndex(_Picture1_1, CType(1, Short))
		Me.Picture1.SetIndex(_Picture1_0, CType(0, Short))
		Me.cboShipCode.SetIndex(_cboShipCode_1, CType(1, Short))
		Me.cboShipCode.SetIndex(_cboShipCode_0, CType(0, Short))
		Me.fraShip.SetIndex(_fraShip_1, CType(1, Short))
		Me.fraShip.SetIndex(_fraShip_0, CType(0, Short))
		Me.lblShipAdr.SetIndex(_lblShipAdr_1, CType(1, Short))
		Me.lblShipAdr.SetIndex(_lblShipAdr_0, CType(0, Short))
		Me.lblShipCode.SetIndex(_lblShipCode_1, CType(1, Short))
		Me.lblShipCode.SetIndex(_lblShipCode_0, CType(0, Short))
		Me.lblShipFaxNo.SetIndex(_lblShipFaxNo_1, CType(1, Short))
		Me.lblShipFaxNo.SetIndex(_lblShipFaxNo_0, CType(0, Short))
		Me.lblShipName.SetIndex(_lblShipName_1, CType(1, Short))
		Me.lblShipName.SetIndex(_lblShipName_0, CType(0, Short))
		Me.lblShipPer.SetIndex(_lblShipPer_1, CType(1, Short))
		Me.lblShipPer.SetIndex(_lblShipPer_0, CType(0, Short))
		Me.lblShipTelNo.SetIndex(_lblShipTelNo_1, CType(1, Short))
		Me.lblShipTelNo.SetIndex(_lblShipTelNo_0, CType(0, Short))
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
		Me.txtShipAdr1.SetIndex(_txtShipAdr1_1, CType(1, Short))
		Me.txtShipAdr1.SetIndex(_txtShipAdr1_0, CType(0, Short))
		Me.txtShipAdr2.SetIndex(_txtShipAdr2_1, CType(1, Short))
		Me.txtShipAdr2.SetIndex(_txtShipAdr2_0, CType(0, Short))
		Me.txtShipAdr3.SetIndex(_txtShipAdr3_1, CType(1, Short))
		Me.txtShipAdr3.SetIndex(_txtShipAdr3_0, CType(0, Short))
		Me.txtShipAdr4.SetIndex(_txtShipAdr4_1, CType(1, Short))
		Me.txtShipAdr4.SetIndex(_txtShipAdr4_0, CType(0, Short))
		Me.txtShipFaxNo.SetIndex(_txtShipFaxNo_1, CType(1, Short))
		Me.txtShipFaxNo.SetIndex(_txtShipFaxNo_0, CType(0, Short))
		Me.txtShipName.SetIndex(_txtShipName_1, CType(1, Short))
		Me.txtShipName.SetIndex(_txtShipName_0, CType(0, Short))
		Me.txtShipPer.SetIndex(_txtShipPer_1, CType(1, Short))
		Me.txtShipPer.SetIndex(_txtShipPer_0, CType(0, Short))
		Me.txtShipTelNo.SetIndex(_txtShipTelNo_1, CType(1, Short))
		Me.txtShipTelNo.SetIndex(_txtShipTelNo_0, CType(0, Short))
		CType(Me.txtShipTelNo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipPer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipFaxNo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipAdr4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipAdr3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipAdr2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipAdr1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRmk, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipTelNo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipPer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipFaxNo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipAdr, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraShip, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cboShipCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPopUp})
		mnuPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuPopUpSub_0})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.FraDate.ResumeLayout(False)
		Me.fraInfo.ResumeLayout(False)
		Me.fraCode.ResumeLayout(False)
		Me.fraKey.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me._tabDetailInfo_TabPage2.ResumeLayout(False)
		Me._fraShip_1.ResumeLayout(False)
		Me._Picture1_1.ResumeLayout(False)
		Me._fraShip_0.ResumeLayout(False)
		Me._Picture1_0.ResumeLayout(False)
		Me.fraRmk.ResumeLayout(False)
		Me.picRmk.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class