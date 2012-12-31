<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmV001
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
	Public WithEvents cboVdrRgnCode As System.Windows.Forms.ComboBox
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboVdrCode As System.Windows.Forms.ComboBox
	Public WithEvents txtVdrCode As System.Windows.Forms.TextBox
	Public WithEvents txtVdrName As System.Windows.Forms.TextBox
	Public WithEvents txtVdrTel As System.Windows.Forms.TextBox
	Public WithEvents txtVdrFax As System.Windows.Forms.TextBox
	Public WithEvents chkInActive As System.Windows.Forms.CheckBox
	Public WithEvents txtVdrContactName As System.Windows.Forms.TextBox
	Public WithEvents txtVdrEmail As System.Windows.Forms.TextBox
	Public WithEvents lblVdrTel As System.Windows.Forms.Label
	Public WithEvents lblVdrName As System.Windows.Forms.Label
	Public WithEvents lblDspVdrRgnDesc As System.Windows.Forms.Label
	Public WithEvents lblVdrRgnCode As System.Windows.Forms.Label
	Public WithEvents lblVdrCode As System.Windows.Forms.Label
	Public WithEvents lblVdrFax As System.Windows.Forms.Label
	Public WithEvents lblVdrContactName As System.Windows.Forms.Label
	Public WithEvents lblVdrEmail As System.Windows.Forms.Label
	Public WithEvents fraVdrInfo As System.Windows.Forms.GroupBox
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
	Public WithEvents txtVdrContactName1 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrAddress4 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrAddress3 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrAddress2 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrAddress1 As System.Windows.Forms.TextBox
	Public WithEvents lblVdrContactName1 As System.Windows.Forms.Label
	Public WithEvents lblVdrAddress1 As System.Windows.Forms.Label
	Public WithEvents lblDspVdrLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspVdrLastUpd As System.Windows.Forms.Label
	Public WithEvents lblVdrLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblVdrLastUpd As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents txtVdrShipAdd2 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipAdd4 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipAdd3 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipAdd1 As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipName As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipContactPerson As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipTel As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipFax As System.Windows.Forms.TextBox
	Public WithEvents txtVdrShipEmail As System.Windows.Forms.TextBox
	Public WithEvents lblVdrShipAdd As System.Windows.Forms.Label
	Public WithEvents lblVdrShipName As System.Windows.Forms.Label
	Public WithEvents lblVdrShipContactPerson As System.Windows.Forms.Label
	Public WithEvents lblVdrShipTel As System.Windows.Forms.Label
	Public WithEvents lblVdrShipEmail As System.Windows.Forms.Label
	Public WithEvents lblVdrShipFax As System.Windows.Forms.Label
	Public WithEvents fraVdrShipAddr1 As System.Windows.Forms.GroupBox
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents cboVdrSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrMLCode As System.Windows.Forms.ComboBox
	Public WithEvents txtVdrCreditLimit As System.Windows.Forms.TextBox
	Public WithEvents txtVdrPayTerm As System.Windows.Forms.TextBox
	Public WithEvents txtVdrRemark As System.Windows.Forms.TextBox
	Public WithEvents txtVdrSpecDis As System.Windows.Forms.TextBox
	Public WithEvents cboVdrCurr As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrPayCode As System.Windows.Forms.ComboBox
	Public WithEvents lblVdrSaleName As System.Windows.Forms.Label
	Public WithEvents lblDspVdrSaleName As System.Windows.Forms.Label
	Public WithEvents lblVdrMLCode As System.Windows.Forms.Label
	Public WithEvents lblDspVdrMLDesc As System.Windows.Forms.Label
	Public WithEvents lblDspVdrOpenBal As System.Windows.Forms.Label
	Public WithEvents lblVdrCreditLimit As System.Windows.Forms.Label
	Public WithEvents lblVdrPayCode As System.Windows.Forms.Label
	Public WithEvents lblVdrRemark As System.Windows.Forms.Label
	Public WithEvents lblVdrCurr As System.Windows.Forms.Label
	Public WithEvents lblVdrOpenBal As System.Windows.Forms.Label
	Public WithEvents lblVdrSpecDis As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents lblOpenBal As System.Windows.Forms.Label
	Public WithEvents lblDspOpenBal As System.Windows.Forms.Label
	Public WithEvents lblDspARBal As System.Windows.Forms.Label
	Public WithEvents lblARBal As System.Windows.Forms.Label
	Public WithEvents lblDspCloseBal As System.Windows.Forms.Label
	Public WithEvents lblCloseBal As System.Windows.Forms.Label
	Public WithEvents lblAcmMnSale As System.Windows.Forms.Label
	Public WithEvents lblDspAcmMnSaleNet As System.Windows.Forms.Label
	Public WithEvents lblDspAcmMnSaleAmt As System.Windows.Forms.Label
	Public WithEvents lblDspAcmMnSaleQty As System.Windows.Forms.Label
	Public WithEvents lblAcmYrSale As System.Windows.Forms.Label
	Public WithEvents lblDspAcmYrSaleNet As System.Windows.Forms.Label
	Public WithEvents lblDspAcmYrSaleAmt As System.Windows.Forms.Label
	Public WithEvents lblDspAcmYrSaleQty As System.Windows.Forms.Label
	Public WithEvents lblAcmSale As System.Windows.Forms.Label
	Public WithEvents lblDspAcmSaleNet As System.Windows.Forms.Label
	Public WithEvents lblDspAcmSaleAmt As System.Windows.Forms.Label
	Public WithEvents lblNet As System.Windows.Forms.Label
	Public WithEvents lblAmt As System.Windows.Forms.Label
	Public WithEvents lblDspAcmSaleQty As System.Windows.Forms.Label
	Public WithEvents lblQty As System.Windows.Forms.Label
	Public WithEvents lblVdrCrtDate As System.Windows.Forms.Label
	Public WithEvents lblDspCrtDate As System.Windows.Forms.Label
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tabDetailInfo_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmV001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboVdrRgnCode = New System.Windows.Forms.ComboBox
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboVdrCode = New System.Windows.Forms.ComboBox
		Me.fraVdrInfo = New System.Windows.Forms.GroupBox
		Me.txtVdrCode = New System.Windows.Forms.TextBox
		Me.txtVdrName = New System.Windows.Forms.TextBox
		Me.txtVdrTel = New System.Windows.Forms.TextBox
		Me.txtVdrFax = New System.Windows.Forms.TextBox
		Me.chkInActive = New System.Windows.Forms.CheckBox
		Me.txtVdrContactName = New System.Windows.Forms.TextBox
		Me.txtVdrEmail = New System.Windows.Forms.TextBox
		Me.lblVdrTel = New System.Windows.Forms.Label
		Me.lblVdrName = New System.Windows.Forms.Label
		Me.lblDspVdrRgnDesc = New System.Windows.Forms.Label
		Me.lblVdrRgnCode = New System.Windows.Forms.Label
		Me.lblVdrCode = New System.Windows.Forms.Label
		Me.lblVdrFax = New System.Windows.Forms.Label
		Me.lblVdrContactName = New System.Windows.Forms.Label
		Me.lblVdrEmail = New System.Windows.Forms.Label
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
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.txtVdrContactName1 = New System.Windows.Forms.TextBox
		Me.txtVdrAddress4 = New System.Windows.Forms.TextBox
		Me.txtVdrAddress3 = New System.Windows.Forms.TextBox
		Me.txtVdrAddress2 = New System.Windows.Forms.TextBox
		Me.txtVdrAddress1 = New System.Windows.Forms.TextBox
		Me.lblVdrContactName1 = New System.Windows.Forms.Label
		Me.lblVdrAddress1 = New System.Windows.Forms.Label
		Me.lblDspVdrLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspVdrLastUpd = New System.Windows.Forms.Label
		Me.lblVdrLastUpdDate = New System.Windows.Forms.Label
		Me.lblVdrLastUpd = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.fraVdrShipAddr1 = New System.Windows.Forms.GroupBox
		Me.txtVdrShipAdd2 = New System.Windows.Forms.TextBox
		Me.txtVdrShipAdd4 = New System.Windows.Forms.TextBox
		Me.txtVdrShipAdd3 = New System.Windows.Forms.TextBox
		Me.txtVdrShipAdd1 = New System.Windows.Forms.TextBox
		Me.txtVdrShipName = New System.Windows.Forms.TextBox
		Me.txtVdrShipContactPerson = New System.Windows.Forms.TextBox
		Me.txtVdrShipTel = New System.Windows.Forms.TextBox
		Me.txtVdrShipFax = New System.Windows.Forms.TextBox
		Me.txtVdrShipEmail = New System.Windows.Forms.TextBox
		Me.lblVdrShipAdd = New System.Windows.Forms.Label
		Me.lblVdrShipName = New System.Windows.Forms.Label
		Me.lblVdrShipContactPerson = New System.Windows.Forms.Label
		Me.lblVdrShipTel = New System.Windows.Forms.Label
		Me.lblVdrShipEmail = New System.Windows.Forms.Label
		Me.lblVdrShipFax = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage2 = New System.Windows.Forms.TabPage
		Me.cboVdrSaleCode = New System.Windows.Forms.ComboBox
		Me.cboVdrMLCode = New System.Windows.Forms.ComboBox
		Me.txtVdrCreditLimit = New System.Windows.Forms.TextBox
		Me.txtVdrPayTerm = New System.Windows.Forms.TextBox
		Me.txtVdrRemark = New System.Windows.Forms.TextBox
		Me.txtVdrSpecDis = New System.Windows.Forms.TextBox
		Me.cboVdrCurr = New System.Windows.Forms.ComboBox
		Me.cboVdrPayCode = New System.Windows.Forms.ComboBox
		Me.lblVdrSaleName = New System.Windows.Forms.Label
		Me.lblDspVdrSaleName = New System.Windows.Forms.Label
		Me.lblVdrMLCode = New System.Windows.Forms.Label
		Me.lblDspVdrMLDesc = New System.Windows.Forms.Label
		Me.lblDspVdrOpenBal = New System.Windows.Forms.Label
		Me.lblVdrCreditLimit = New System.Windows.Forms.Label
		Me.lblVdrPayCode = New System.Windows.Forms.Label
		Me.lblVdrRemark = New System.Windows.Forms.Label
		Me.lblVdrCurr = New System.Windows.Forms.Label
		Me.lblVdrOpenBal = New System.Windows.Forms.Label
		Me.lblVdrSpecDis = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage3 = New System.Windows.Forms.TabPage
		Me.lblOpenBal = New System.Windows.Forms.Label
		Me.lblDspOpenBal = New System.Windows.Forms.Label
		Me.lblDspARBal = New System.Windows.Forms.Label
		Me.lblARBal = New System.Windows.Forms.Label
		Me.lblDspCloseBal = New System.Windows.Forms.Label
		Me.lblCloseBal = New System.Windows.Forms.Label
		Me.lblAcmMnSale = New System.Windows.Forms.Label
		Me.lblDspAcmMnSaleNet = New System.Windows.Forms.Label
		Me.lblDspAcmMnSaleAmt = New System.Windows.Forms.Label
		Me.lblDspAcmMnSaleQty = New System.Windows.Forms.Label
		Me.lblAcmYrSale = New System.Windows.Forms.Label
		Me.lblDspAcmYrSaleNet = New System.Windows.Forms.Label
		Me.lblDspAcmYrSaleAmt = New System.Windows.Forms.Label
		Me.lblDspAcmYrSaleQty = New System.Windows.Forms.Label
		Me.lblAcmSale = New System.Windows.Forms.Label
		Me.lblDspAcmSaleNet = New System.Windows.Forms.Label
		Me.lblDspAcmSaleAmt = New System.Windows.Forms.Label
		Me.lblNet = New System.Windows.Forms.Label
		Me.lblAmt = New System.Windows.Forms.Label
		Me.lblDspAcmSaleQty = New System.Windows.Forms.Label
		Me.lblQty = New System.Windows.Forms.Label
		Me.lblVdrCrtDate = New System.Windows.Forms.Label
		Me.lblDspCrtDate = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.fraVdrInfo.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.fraVdrShipAddr1.SuspendLayout()
		Me._tabDetailInfo_TabPage2.SuspendLayout()
		Me._tabDetailInfo_TabPage3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "供應商資料"
		Me.ClientSize = New System.Drawing.Size(663, 405)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.Icon = CType(resources.GetObject("frmV001.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Visible = False
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
		Me.Name = "frmV001"
		Me.cboVdrRgnCode.Enabled = False
		Me.cboVdrRgnCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cboVdrRgnCode.Size = New System.Drawing.Size(61, 20)
		Me.cboVdrRgnCode.Location = New System.Drawing.Point(392, 56)
		Me.cboVdrRgnCode.TabIndex = 2
		Me.cboVdrRgnCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrRgnCode.CausesValidation = True
		Me.cboVdrRgnCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrRgnCode.IntegralHeight = True
		Me.cboVdrRgnCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrRgnCode.Sorted = False
		Me.cboVdrRgnCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrRgnCode.TabStop = True
		Me.cboVdrRgnCode.Visible = True
		Me.cboVdrRgnCode.Name = "cboVdrRgnCode"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(760, 32)
		Me.tblCommon.TabIndex = 32
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboVdrCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cboVdrCode.Size = New System.Drawing.Size(151, 20)
		Me.cboVdrCode.Location = New System.Drawing.Point(128, 56)
		Me.cboVdrCode.TabIndex = 1
		Me.cboVdrCode.Visible = False
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
		Me.cboVdrCode.Name = "cboVdrCode"
		Me.fraVdrInfo.Text = "供應商資料"
		Me.fraVdrInfo.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.fraVdrInfo.Size = New System.Drawing.Size(641, 113)
		Me.fraVdrInfo.Location = New System.Drawing.Point(16, 40)
		Me.fraVdrInfo.TabIndex = 33
		Me.fraVdrInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraVdrInfo.Enabled = True
		Me.fraVdrInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraVdrInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVdrInfo.Visible = True
		Me.fraVdrInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraVdrInfo.Name = "fraVdrInfo"
		Me.txtVdrCode.AutoSize = False
		Me.txtVdrCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrCode.Size = New System.Drawing.Size(151, 20)
		Me.txtVdrCode.Location = New System.Drawing.Point(112, 16)
		Me.txtVdrCode.TabIndex = 0
		Me.txtVdrCode.Tag = "K"
		Me.txtVdrCode.AcceptsReturn = True
		Me.txtVdrCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrCode.CausesValidation = True
		Me.txtVdrCode.Enabled = True
		Me.txtVdrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrCode.HideSelection = True
		Me.txtVdrCode.ReadOnly = False
		Me.txtVdrCode.Maxlength = 0
		Me.txtVdrCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrCode.MultiLine = False
		Me.txtVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrCode.TabStop = True
		Me.txtVdrCode.Visible = True
		Me.txtVdrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrCode.Name = "txtVdrCode"
		Me.txtVdrName.AutoSize = False
		Me.txtVdrName.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtVdrName.Enabled = False
		Me.txtVdrName.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrName.Size = New System.Drawing.Size(479, 20)
		Me.txtVdrName.Location = New System.Drawing.Point(112, 40)
		Me.txtVdrName.TabIndex = 4
		Me.txtVdrName.AcceptsReturn = True
		Me.txtVdrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrName.CausesValidation = True
		Me.txtVdrName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrName.HideSelection = True
		Me.txtVdrName.ReadOnly = False
		Me.txtVdrName.Maxlength = 0
		Me.txtVdrName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrName.MultiLine = False
		Me.txtVdrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrName.TabStop = True
		Me.txtVdrName.Visible = True
		Me.txtVdrName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrName.Name = "txtVdrName"
		Me.txtVdrTel.AutoSize = False
		Me.txtVdrTel.Enabled = False
		Me.txtVdrTel.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrTel.Size = New System.Drawing.Size(177, 20)
		Me.txtVdrTel.Location = New System.Drawing.Point(112, 64)
		Me.txtVdrTel.TabIndex = 5
		Me.txtVdrTel.AcceptsReturn = True
		Me.txtVdrTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrTel.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrTel.CausesValidation = True
		Me.txtVdrTel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrTel.HideSelection = True
		Me.txtVdrTel.ReadOnly = False
		Me.txtVdrTel.Maxlength = 0
		Me.txtVdrTel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrTel.MultiLine = False
		Me.txtVdrTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrTel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrTel.TabStop = True
		Me.txtVdrTel.Visible = True
		Me.txtVdrTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrTel.Name = "txtVdrTel"
		Me.txtVdrFax.AutoSize = False
		Me.txtVdrFax.Enabled = False
		Me.txtVdrFax.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrFax.Size = New System.Drawing.Size(231, 20)
		Me.txtVdrFax.Location = New System.Drawing.Point(360, 64)
		Me.txtVdrFax.TabIndex = 6
		Me.txtVdrFax.AcceptsReturn = True
		Me.txtVdrFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrFax.CausesValidation = True
		Me.txtVdrFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrFax.HideSelection = True
		Me.txtVdrFax.ReadOnly = False
		Me.txtVdrFax.Maxlength = 0
		Me.txtVdrFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrFax.MultiLine = False
		Me.txtVdrFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrFax.TabStop = True
		Me.txtVdrFax.Visible = True
		Me.txtVdrFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrFax.Name = "txtVdrFax"
		Me.chkInActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkInActive.Text = "有效 :"
		Me.chkInActive.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.chkInActive.Size = New System.Drawing.Size(57, 12)
		Me.chkInActive.Location = New System.Drawing.Point(528, 16)
		Me.chkInActive.TabIndex = 3
		Me.chkInActive.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkInActive.BackColor = System.Drawing.SystemColors.Control
		Me.chkInActive.CausesValidation = True
		Me.chkInActive.Enabled = True
		Me.chkInActive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkInActive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkInActive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkInActive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkInActive.TabStop = True
		Me.chkInActive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkInActive.Visible = True
		Me.chkInActive.Name = "chkInActive"
		Me.txtVdrContactName.AutoSize = False
		Me.txtVdrContactName.Enabled = False
		Me.txtVdrContactName.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrContactName.Size = New System.Drawing.Size(177, 20)
		Me.txtVdrContactName.Location = New System.Drawing.Point(112, 88)
		Me.txtVdrContactName.TabIndex = 7
		Me.txtVdrContactName.AcceptsReturn = True
		Me.txtVdrContactName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrContactName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrContactName.CausesValidation = True
		Me.txtVdrContactName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrContactName.HideSelection = True
		Me.txtVdrContactName.ReadOnly = False
		Me.txtVdrContactName.Maxlength = 0
		Me.txtVdrContactName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrContactName.MultiLine = False
		Me.txtVdrContactName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrContactName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrContactName.TabStop = True
		Me.txtVdrContactName.Visible = True
		Me.txtVdrContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrContactName.Name = "txtVdrContactName"
		Me.txtVdrEmail.AutoSize = False
		Me.txtVdrEmail.Enabled = False
		Me.txtVdrEmail.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrEmail.Size = New System.Drawing.Size(231, 20)
		Me.txtVdrEmail.Location = New System.Drawing.Point(360, 88)
		Me.txtVdrEmail.TabIndex = 8
		Me.txtVdrEmail.AcceptsReturn = True
		Me.txtVdrEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrEmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrEmail.CausesValidation = True
		Me.txtVdrEmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrEmail.HideSelection = True
		Me.txtVdrEmail.ReadOnly = False
		Me.txtVdrEmail.Maxlength = 0
		Me.txtVdrEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrEmail.MultiLine = False
		Me.txtVdrEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrEmail.TabStop = True
		Me.txtVdrEmail.Visible = True
		Me.txtVdrEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrEmail.Name = "txtVdrEmail"
		Me.lblVdrTel.Text = "電話 :"
		Me.lblVdrTel.Font = New System.Drawing.Font("細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrTel.Size = New System.Drawing.Size(92, 16)
		Me.lblVdrTel.Location = New System.Drawing.Point(16, 64)
		Me.lblVdrTel.TabIndex = 90
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
		Me.lblVdrName.Text = "名稱 :"
		Me.lblVdrName.Font = New System.Drawing.Font("細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrName.Size = New System.Drawing.Size(92, 16)
		Me.lblVdrName.Location = New System.Drawing.Point(16, 40)
		Me.lblVdrName.TabIndex = 89
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
		Me.lblDspVdrRgnDesc.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspVdrRgnDesc.Size = New System.Drawing.Size(95, 20)
		Me.lblDspVdrRgnDesc.Location = New System.Drawing.Point(424, 16)
		Me.lblDspVdrRgnDesc.TabIndex = 62
		Me.lblDspVdrRgnDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrRgnDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrRgnDesc.Enabled = True
		Me.lblDspVdrRgnDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrRgnDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrRgnDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrRgnDesc.UseMnemonic = True
		Me.lblDspVdrRgnDesc.Visible = True
		Me.lblDspVdrRgnDesc.AutoSize = False
		Me.lblDspVdrRgnDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrRgnDesc.Name = "lblDspVdrRgnDesc"
		Me.lblVdrRgnCode.Text = "VDRRGNCODE"
		Me.lblVdrRgnCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrRgnCode.Size = New System.Drawing.Size(93, 16)
		Me.lblVdrRgnCode.Location = New System.Drawing.Point(264, 20)
		Me.lblVdrRgnCode.TabIndex = 61
		Me.lblVdrRgnCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrRgnCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrRgnCode.Enabled = True
		Me.lblVdrRgnCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrRgnCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrRgnCode.UseMnemonic = True
		Me.lblVdrRgnCode.Visible = True
		Me.lblVdrRgnCode.AutoSize = False
		Me.lblVdrRgnCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrRgnCode.Name = "lblVdrRgnCode"
		Me.lblVdrCode.Text = "VDRCODE"
		Me.lblVdrCode.Font = New System.Drawing.Font("細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrCode.Size = New System.Drawing.Size(92, 16)
		Me.lblVdrCode.Location = New System.Drawing.Point(16, 20)
		Me.lblVdrCode.TabIndex = 37
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
		Me.lblVdrFax.Text = "傳真 :"
		Me.lblVdrFax.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrFax.Size = New System.Drawing.Size(60, 16)
		Me.lblVdrFax.Location = New System.Drawing.Point(296, 68)
		Me.lblVdrFax.TabIndex = 36
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
		Me.lblVdrContactName.Text = "聯絡人 :"
		Me.lblVdrContactName.Font = New System.Drawing.Font("細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrContactName.Size = New System.Drawing.Size(92, 16)
		Me.lblVdrContactName.Location = New System.Drawing.Point(16, 92)
		Me.lblVdrContactName.TabIndex = 35
		Me.lblVdrContactName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrContactName.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrContactName.Enabled = True
		Me.lblVdrContactName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrContactName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrContactName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrContactName.UseMnemonic = True
		Me.lblVdrContactName.Visible = True
		Me.lblVdrContactName.AutoSize = False
		Me.lblVdrContactName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrContactName.Name = "lblVdrContactName"
		Me.lblVdrEmail.Text = "電郵 :"
		Me.lblVdrEmail.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrEmail.Size = New System.Drawing.Size(60, 16)
		Me.lblVdrEmail.Location = New System.Drawing.Point(296, 92)
		Me.lblVdrEmail.TabIndex = 34
		Me.lblVdrEmail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrEmail.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrEmail.Enabled = True
		Me.lblVdrEmail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrEmail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrEmail.UseMnemonic = True
		Me.lblVdrEmail.Visible = True
		Me.lblVdrEmail.AutoSize = False
		Me.lblVdrEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrEmail.Name = "lblVdrEmail"
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
		Me.tbrProcess.Size = New System.Drawing.Size(663, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 31
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
		Me.tabDetailInfo.Size = New System.Drawing.Size(617, 225)
		Me.tabDetailInfo.Location = New System.Drawing.Point(16, 160)
		Me.tabDetailInfo.TabIndex = 38
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.SelectedIndex = 3
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "附加通訊資料"
		Me.txtVdrContactName1.AutoSize = False
		Me.txtVdrContactName1.Enabled = False
		Me.txtVdrContactName1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrContactName1.Size = New System.Drawing.Size(177, 20)
		Me.txtVdrContactName1.Location = New System.Drawing.Point(112, 24)
		Me.txtVdrContactName1.TabIndex = 9
		Me.txtVdrContactName1.AcceptsReturn = True
		Me.txtVdrContactName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrContactName1.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrContactName1.CausesValidation = True
		Me.txtVdrContactName1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrContactName1.HideSelection = True
		Me.txtVdrContactName1.ReadOnly = False
		Me.txtVdrContactName1.Maxlength = 0
		Me.txtVdrContactName1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrContactName1.MultiLine = False
		Me.txtVdrContactName1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrContactName1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrContactName1.TabStop = True
		Me.txtVdrContactName1.Visible = True
		Me.txtVdrContactName1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrContactName1.Name = "txtVdrContactName1"
		Me.txtVdrAddress4.AutoSize = False
		Me.txtVdrAddress4.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrAddress4.Size = New System.Drawing.Size(481, 20)
		Me.txtVdrAddress4.Location = New System.Drawing.Point(112, 120)
		Me.txtVdrAddress4.TabIndex = 13
		Me.txtVdrAddress4.AcceptsReturn = True
		Me.txtVdrAddress4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrAddress4.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrAddress4.CausesValidation = True
		Me.txtVdrAddress4.Enabled = True
		Me.txtVdrAddress4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrAddress4.HideSelection = True
		Me.txtVdrAddress4.ReadOnly = False
		Me.txtVdrAddress4.Maxlength = 0
		Me.txtVdrAddress4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrAddress4.MultiLine = False
		Me.txtVdrAddress4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrAddress4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrAddress4.TabStop = True
		Me.txtVdrAddress4.Visible = True
		Me.txtVdrAddress4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrAddress4.Name = "txtVdrAddress4"
		Me.txtVdrAddress3.AutoSize = False
		Me.txtVdrAddress3.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrAddress3.Size = New System.Drawing.Size(481, 20)
		Me.txtVdrAddress3.Location = New System.Drawing.Point(112, 96)
		Me.txtVdrAddress3.TabIndex = 12
		Me.txtVdrAddress3.AcceptsReturn = True
		Me.txtVdrAddress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrAddress3.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrAddress3.CausesValidation = True
		Me.txtVdrAddress3.Enabled = True
		Me.txtVdrAddress3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrAddress3.HideSelection = True
		Me.txtVdrAddress3.ReadOnly = False
		Me.txtVdrAddress3.Maxlength = 0
		Me.txtVdrAddress3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrAddress3.MultiLine = False
		Me.txtVdrAddress3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrAddress3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrAddress3.TabStop = True
		Me.txtVdrAddress3.Visible = True
		Me.txtVdrAddress3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrAddress3.Name = "txtVdrAddress3"
		Me.txtVdrAddress2.AutoSize = False
		Me.txtVdrAddress2.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrAddress2.Size = New System.Drawing.Size(481, 20)
		Me.txtVdrAddress2.Location = New System.Drawing.Point(112, 72)
		Me.txtVdrAddress2.TabIndex = 11
		Me.txtVdrAddress2.AcceptsReturn = True
		Me.txtVdrAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrAddress2.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrAddress2.CausesValidation = True
		Me.txtVdrAddress2.Enabled = True
		Me.txtVdrAddress2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrAddress2.HideSelection = True
		Me.txtVdrAddress2.ReadOnly = False
		Me.txtVdrAddress2.Maxlength = 0
		Me.txtVdrAddress2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrAddress2.MultiLine = False
		Me.txtVdrAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrAddress2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrAddress2.TabStop = True
		Me.txtVdrAddress2.Visible = True
		Me.txtVdrAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrAddress2.Name = "txtVdrAddress2"
		Me.txtVdrAddress1.AutoSize = False
		Me.txtVdrAddress1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrAddress1.Size = New System.Drawing.Size(481, 20)
		Me.txtVdrAddress1.Location = New System.Drawing.Point(112, 48)
		Me.txtVdrAddress1.TabIndex = 10
		Me.txtVdrAddress1.AcceptsReturn = True
		Me.txtVdrAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrAddress1.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrAddress1.CausesValidation = True
		Me.txtVdrAddress1.Enabled = True
		Me.txtVdrAddress1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrAddress1.HideSelection = True
		Me.txtVdrAddress1.ReadOnly = False
		Me.txtVdrAddress1.Maxlength = 0
		Me.txtVdrAddress1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrAddress1.MultiLine = False
		Me.txtVdrAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrAddress1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrAddress1.TabStop = True
		Me.txtVdrAddress1.Visible = True
		Me.txtVdrAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrAddress1.Name = "txtVdrAddress1"
		Me.lblVdrContactName1.Text = "VDRCONTACTNAME1"
		Me.lblVdrContactName1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrContactName1.Size = New System.Drawing.Size(100, 16)
		Me.lblVdrContactName1.Location = New System.Drawing.Point(8, 28)
		Me.lblVdrContactName1.TabIndex = 58
		Me.lblVdrContactName1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrContactName1.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrContactName1.Enabled = True
		Me.lblVdrContactName1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrContactName1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrContactName1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrContactName1.UseMnemonic = True
		Me.lblVdrContactName1.Visible = True
		Me.lblVdrContactName1.AutoSize = False
		Me.lblVdrContactName1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrContactName1.Name = "lblVdrContactName1"
		Me.lblVdrAddress1.Text = "發票地址 :"
		Me.lblVdrAddress1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrAddress1.Size = New System.Drawing.Size(73, 17)
		Me.lblVdrAddress1.Location = New System.Drawing.Point(8, 52)
		Me.lblVdrAddress1.TabIndex = 54
		Me.lblVdrAddress1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrAddress1.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrAddress1.Enabled = True
		Me.lblVdrAddress1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrAddress1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrAddress1.UseMnemonic = True
		Me.lblVdrAddress1.Visible = True
		Me.lblVdrAddress1.AutoSize = False
		Me.lblVdrAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrAddress1.Name = "lblVdrAddress1"
		Me.lblDspVdrLastUpdDate.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspVdrLastUpdDate.Size = New System.Drawing.Size(201, 20)
		Me.lblDspVdrLastUpdDate.Location = New System.Drawing.Point(392, 176)
		Me.lblDspVdrLastUpdDate.TabIndex = 49
		Me.lblDspVdrLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrLastUpdDate.Enabled = True
		Me.lblDspVdrLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrLastUpdDate.UseMnemonic = True
		Me.lblDspVdrLastUpdDate.Visible = True
		Me.lblDspVdrLastUpdDate.AutoSize = False
		Me.lblDspVdrLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrLastUpdDate.Name = "lblDspVdrLastUpdDate"
		Me.lblDspVdrLastUpd.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspVdrLastUpd.Size = New System.Drawing.Size(201, 20)
		Me.lblDspVdrLastUpd.Location = New System.Drawing.Point(80, 176)
		Me.lblDspVdrLastUpd.TabIndex = 48
		Me.lblDspVdrLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrLastUpd.Enabled = True
		Me.lblDspVdrLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrLastUpd.UseMnemonic = True
		Me.lblDspVdrLastUpd.Visible = True
		Me.lblDspVdrLastUpd.AutoSize = False
		Me.lblDspVdrLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrLastUpd.Name = "lblDspVdrLastUpd"
		Me.lblVdrLastUpdDate.Text = "最後修改日期 :"
		Me.lblVdrLastUpdDate.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrLastUpdDate.Size = New System.Drawing.Size(84, 16)
		Me.lblVdrLastUpdDate.Location = New System.Drawing.Point(304, 181)
		Me.lblVdrLastUpdDate.TabIndex = 47
		Me.lblVdrLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrLastUpdDate.Enabled = True
		Me.lblVdrLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrLastUpdDate.UseMnemonic = True
		Me.lblVdrLastUpdDate.Visible = True
		Me.lblVdrLastUpdDate.AutoSize = False
		Me.lblVdrLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrLastUpdDate.Name = "lblVdrLastUpdDate"
		Me.lblVdrLastUpd.Text = "最後修改人 :"
		Me.lblVdrLastUpd.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrLastUpd.Size = New System.Drawing.Size(71, 16)
		Me.lblVdrLastUpd.Location = New System.Drawing.Point(8, 181)
		Me.lblVdrLastUpd.TabIndex = 46
		Me.lblVdrLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrLastUpd.Enabled = True
		Me.lblVdrLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrLastUpd.UseMnemonic = True
		Me.lblVdrLastUpd.Visible = True
		Me.lblVdrLastUpd.AutoSize = False
		Me.lblVdrLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrLastUpd.Name = "lblVdrLastUpd"
		Me._tabDetailInfo_TabPage1.Text = "貨運資料"
		Me.fraVdrShipAddr1.Text = "運送資料"
		Me.fraVdrShipAddr1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.fraVdrShipAddr1.Size = New System.Drawing.Size(593, 185)
		Me.fraVdrShipAddr1.Location = New System.Drawing.Point(8, 8)
		Me.fraVdrShipAddr1.TabIndex = 39
		Me.fraVdrShipAddr1.BackColor = System.Drawing.SystemColors.Control
		Me.fraVdrShipAddr1.Enabled = True
		Me.fraVdrShipAddr1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraVdrShipAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraVdrShipAddr1.Visible = True
		Me.fraVdrShipAddr1.Padding = New System.Windows.Forms.Padding(0)
		Me.fraVdrShipAddr1.Name = "fraVdrShipAddr1"
		Me.txtVdrShipAdd2.AutoSize = False
		Me.txtVdrShipAdd2.Enabled = False
		Me.txtVdrShipAdd2.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipAdd2.Size = New System.Drawing.Size(505, 20)
		Me.txtVdrShipAdd2.Location = New System.Drawing.Point(80, 80)
		Me.txtVdrShipAdd2.TabIndex = 17
		Me.txtVdrShipAdd2.AcceptsReturn = True
		Me.txtVdrShipAdd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipAdd2.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipAdd2.CausesValidation = True
		Me.txtVdrShipAdd2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipAdd2.HideSelection = True
		Me.txtVdrShipAdd2.ReadOnly = False
		Me.txtVdrShipAdd2.Maxlength = 0
		Me.txtVdrShipAdd2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipAdd2.MultiLine = False
		Me.txtVdrShipAdd2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipAdd2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipAdd2.TabStop = True
		Me.txtVdrShipAdd2.Visible = True
		Me.txtVdrShipAdd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipAdd2.Name = "txtVdrShipAdd2"
		Me.txtVdrShipAdd4.AutoSize = False
		Me.txtVdrShipAdd4.Enabled = False
		Me.txtVdrShipAdd4.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipAdd4.Size = New System.Drawing.Size(505, 20)
		Me.txtVdrShipAdd4.Location = New System.Drawing.Point(80, 128)
		Me.txtVdrShipAdd4.TabIndex = 19
		Me.txtVdrShipAdd4.AcceptsReturn = True
		Me.txtVdrShipAdd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipAdd4.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipAdd4.CausesValidation = True
		Me.txtVdrShipAdd4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipAdd4.HideSelection = True
		Me.txtVdrShipAdd4.ReadOnly = False
		Me.txtVdrShipAdd4.Maxlength = 0
		Me.txtVdrShipAdd4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipAdd4.MultiLine = False
		Me.txtVdrShipAdd4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipAdd4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipAdd4.TabStop = True
		Me.txtVdrShipAdd4.Visible = True
		Me.txtVdrShipAdd4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipAdd4.Name = "txtVdrShipAdd4"
		Me.txtVdrShipAdd3.AutoSize = False
		Me.txtVdrShipAdd3.Enabled = False
		Me.txtVdrShipAdd3.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipAdd3.Size = New System.Drawing.Size(505, 20)
		Me.txtVdrShipAdd3.Location = New System.Drawing.Point(80, 104)
		Me.txtVdrShipAdd3.TabIndex = 18
		Me.txtVdrShipAdd3.AcceptsReturn = True
		Me.txtVdrShipAdd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipAdd3.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipAdd3.CausesValidation = True
		Me.txtVdrShipAdd3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipAdd3.HideSelection = True
		Me.txtVdrShipAdd3.ReadOnly = False
		Me.txtVdrShipAdd3.Maxlength = 0
		Me.txtVdrShipAdd3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipAdd3.MultiLine = False
		Me.txtVdrShipAdd3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipAdd3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipAdd3.TabStop = True
		Me.txtVdrShipAdd3.Visible = True
		Me.txtVdrShipAdd3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipAdd3.Name = "txtVdrShipAdd3"
		Me.txtVdrShipAdd1.AutoSize = False
		Me.txtVdrShipAdd1.Enabled = False
		Me.txtVdrShipAdd1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipAdd1.Size = New System.Drawing.Size(505, 20)
		Me.txtVdrShipAdd1.Location = New System.Drawing.Point(80, 56)
		Me.txtVdrShipAdd1.TabIndex = 16
		Me.txtVdrShipAdd1.AcceptsReturn = True
		Me.txtVdrShipAdd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipAdd1.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipAdd1.CausesValidation = True
		Me.txtVdrShipAdd1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipAdd1.HideSelection = True
		Me.txtVdrShipAdd1.ReadOnly = False
		Me.txtVdrShipAdd1.Maxlength = 0
		Me.txtVdrShipAdd1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipAdd1.MultiLine = False
		Me.txtVdrShipAdd1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipAdd1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipAdd1.TabStop = True
		Me.txtVdrShipAdd1.Visible = True
		Me.txtVdrShipAdd1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipAdd1.Name = "txtVdrShipAdd1"
		Me.txtVdrShipName.AutoSize = False
		Me.txtVdrShipName.Enabled = False
		Me.txtVdrShipName.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipName.Size = New System.Drawing.Size(209, 20)
		Me.txtVdrShipName.Location = New System.Drawing.Point(80, 32)
		Me.txtVdrShipName.TabIndex = 14
		Me.txtVdrShipName.AcceptsReturn = True
		Me.txtVdrShipName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipName.CausesValidation = True
		Me.txtVdrShipName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipName.HideSelection = True
		Me.txtVdrShipName.ReadOnly = False
		Me.txtVdrShipName.Maxlength = 0
		Me.txtVdrShipName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipName.MultiLine = False
		Me.txtVdrShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipName.TabStop = True
		Me.txtVdrShipName.Visible = True
		Me.txtVdrShipName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipName.Name = "txtVdrShipName"
		Me.txtVdrShipContactPerson.AutoSize = False
		Me.txtVdrShipContactPerson.Enabled = False
		Me.txtVdrShipContactPerson.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipContactPerson.Size = New System.Drawing.Size(225, 20)
		Me.txtVdrShipContactPerson.Location = New System.Drawing.Point(360, 32)
		Me.txtVdrShipContactPerson.TabIndex = 15
		Me.txtVdrShipContactPerson.AcceptsReturn = True
		Me.txtVdrShipContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipContactPerson.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipContactPerson.CausesValidation = True
		Me.txtVdrShipContactPerson.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipContactPerson.HideSelection = True
		Me.txtVdrShipContactPerson.ReadOnly = False
		Me.txtVdrShipContactPerson.Maxlength = 0
		Me.txtVdrShipContactPerson.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipContactPerson.MultiLine = False
		Me.txtVdrShipContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipContactPerson.TabStop = True
		Me.txtVdrShipContactPerson.Visible = True
		Me.txtVdrShipContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipContactPerson.Name = "txtVdrShipContactPerson"
		Me.txtVdrShipTel.AutoSize = False
		Me.txtVdrShipTel.Enabled = False
		Me.txtVdrShipTel.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipTel.Size = New System.Drawing.Size(95, 20)
		Me.txtVdrShipTel.Location = New System.Drawing.Point(80, 152)
		Me.txtVdrShipTel.TabIndex = 20
		Me.txtVdrShipTel.AcceptsReturn = True
		Me.txtVdrShipTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipTel.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipTel.CausesValidation = True
		Me.txtVdrShipTel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipTel.HideSelection = True
		Me.txtVdrShipTel.ReadOnly = False
		Me.txtVdrShipTel.Maxlength = 0
		Me.txtVdrShipTel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipTel.MultiLine = False
		Me.txtVdrShipTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipTel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipTel.TabStop = True
		Me.txtVdrShipTel.Visible = True
		Me.txtVdrShipTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipTel.Name = "txtVdrShipTel"
		Me.txtVdrShipFax.AutoSize = False
		Me.txtVdrShipFax.Enabled = False
		Me.txtVdrShipFax.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipFax.Size = New System.Drawing.Size(97, 20)
		Me.txtVdrShipFax.Location = New System.Drawing.Point(216, 152)
		Me.txtVdrShipFax.TabIndex = 21
		Me.txtVdrShipFax.AcceptsReturn = True
		Me.txtVdrShipFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipFax.CausesValidation = True
		Me.txtVdrShipFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipFax.HideSelection = True
		Me.txtVdrShipFax.ReadOnly = False
		Me.txtVdrShipFax.Maxlength = 0
		Me.txtVdrShipFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipFax.MultiLine = False
		Me.txtVdrShipFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipFax.TabStop = True
		Me.txtVdrShipFax.Visible = True
		Me.txtVdrShipFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipFax.Name = "txtVdrShipFax"
		Me.txtVdrShipEmail.AutoSize = False
		Me.txtVdrShipEmail.Enabled = False
		Me.txtVdrShipEmail.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrShipEmail.Size = New System.Drawing.Size(233, 20)
		Me.txtVdrShipEmail.Location = New System.Drawing.Point(352, 152)
		Me.txtVdrShipEmail.TabIndex = 22
		Me.txtVdrShipEmail.AcceptsReturn = True
		Me.txtVdrShipEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrShipEmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrShipEmail.CausesValidation = True
		Me.txtVdrShipEmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrShipEmail.HideSelection = True
		Me.txtVdrShipEmail.ReadOnly = False
		Me.txtVdrShipEmail.Maxlength = 0
		Me.txtVdrShipEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrShipEmail.MultiLine = False
		Me.txtVdrShipEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrShipEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrShipEmail.TabStop = True
		Me.txtVdrShipEmail.Visible = True
		Me.txtVdrShipEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrShipEmail.Name = "txtVdrShipEmail"
		Me.lblVdrShipAdd.Text = "送貨地址 :"
		Me.lblVdrShipAdd.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrShipAdd.Size = New System.Drawing.Size(60, 16)
		Me.lblVdrShipAdd.Location = New System.Drawing.Point(8, 60)
		Me.lblVdrShipAdd.TabIndex = 45
		Me.lblVdrShipAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrShipAdd.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrShipAdd.Enabled = True
		Me.lblVdrShipAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrShipAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrShipAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrShipAdd.UseMnemonic = True
		Me.lblVdrShipAdd.Visible = True
		Me.lblVdrShipAdd.AutoSize = False
		Me.lblVdrShipAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrShipAdd.Name = "lblVdrShipAdd"
		Me.lblVdrShipName.Text = "運貨名稱 :"
		Me.lblVdrShipName.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrShipName.Size = New System.Drawing.Size(60, 16)
		Me.lblVdrShipName.Location = New System.Drawing.Point(8, 35)
		Me.lblVdrShipName.TabIndex = 44
		Me.lblVdrShipName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrShipName.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrShipName.Enabled = True
		Me.lblVdrShipName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrShipName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrShipName.UseMnemonic = True
		Me.lblVdrShipName.Visible = True
		Me.lblVdrShipName.AutoSize = False
		Me.lblVdrShipName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrShipName.Name = "lblVdrShipName"
		Me.lblVdrShipContactPerson.Text = "聯絡人 :"
		Me.lblVdrShipContactPerson.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrShipContactPerson.Size = New System.Drawing.Size(60, 16)
		Me.lblVdrShipContactPerson.Location = New System.Drawing.Point(304, 35)
		Me.lblVdrShipContactPerson.TabIndex = 43
		Me.lblVdrShipContactPerson.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrShipContactPerson.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrShipContactPerson.Enabled = True
		Me.lblVdrShipContactPerson.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrShipContactPerson.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrShipContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrShipContactPerson.UseMnemonic = True
		Me.lblVdrShipContactPerson.Visible = True
		Me.lblVdrShipContactPerson.AutoSize = False
		Me.lblVdrShipContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrShipContactPerson.Name = "lblVdrShipContactPerson"
		Me.lblVdrShipTel.Text = "電話 :"
		Me.lblVdrShipTel.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrShipTel.Size = New System.Drawing.Size(68, 16)
		Me.lblVdrShipTel.Location = New System.Drawing.Point(8, 156)
		Me.lblVdrShipTel.TabIndex = 42
		Me.lblVdrShipTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrShipTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrShipTel.Enabled = True
		Me.lblVdrShipTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrShipTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrShipTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrShipTel.UseMnemonic = True
		Me.lblVdrShipTel.Visible = True
		Me.lblVdrShipTel.AutoSize = False
		Me.lblVdrShipTel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrShipTel.Name = "lblVdrShipTel"
		Me.lblVdrShipEmail.Text = "電郵 :"
		Me.lblVdrShipEmail.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrShipEmail.Size = New System.Drawing.Size(44, 16)
		Me.lblVdrShipEmail.Location = New System.Drawing.Point(320, 156)
		Me.lblVdrShipEmail.TabIndex = 41
		Me.lblVdrShipEmail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrShipEmail.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrShipEmail.Enabled = True
		Me.lblVdrShipEmail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrShipEmail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrShipEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrShipEmail.UseMnemonic = True
		Me.lblVdrShipEmail.Visible = True
		Me.lblVdrShipEmail.AutoSize = False
		Me.lblVdrShipEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrShipEmail.Name = "lblVdrShipEmail"
		Me.lblVdrShipFax.Text = "傳真 :"
		Me.lblVdrShipFax.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrShipFax.Size = New System.Drawing.Size(68, 16)
		Me.lblVdrShipFax.Location = New System.Drawing.Point(184, 156)
		Me.lblVdrShipFax.TabIndex = 40
		Me.lblVdrShipFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrShipFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrShipFax.Enabled = True
		Me.lblVdrShipFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrShipFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrShipFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrShipFax.UseMnemonic = True
		Me.lblVdrShipFax.Visible = True
		Me.lblVdrShipFax.AutoSize = False
		Me.lblVdrShipFax.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrShipFax.Name = "lblVdrShipFax"
		Me._tabDetailInfo_TabPage2.Text = "其他資料"
		Me.cboVdrSaleCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cboVdrSaleCode.Size = New System.Drawing.Size(85, 20)
		Me.cboVdrSaleCode.Location = New System.Drawing.Point(368, 24)
		Me.cboVdrSaleCode.TabIndex = 23
		Me.cboVdrSaleCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrSaleCode.CausesValidation = True
		Me.cboVdrSaleCode.Enabled = True
		Me.cboVdrSaleCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrSaleCode.IntegralHeight = True
		Me.cboVdrSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrSaleCode.Sorted = False
		Me.cboVdrSaleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrSaleCode.TabStop = True
		Me.cboVdrSaleCode.Visible = True
		Me.cboVdrSaleCode.Name = "cboVdrSaleCode"
		Me.cboVdrMLCode.Enabled = False
		Me.cboVdrMLCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cboVdrMLCode.Size = New System.Drawing.Size(61, 20)
		Me.cboVdrMLCode.Location = New System.Drawing.Point(80, 72)
		Me.cboVdrMLCode.TabIndex = 27
		Me.cboVdrMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrMLCode.CausesValidation = True
		Me.cboVdrMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrMLCode.IntegralHeight = True
		Me.cboVdrMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrMLCode.Sorted = False
		Me.cboVdrMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrMLCode.TabStop = True
		Me.cboVdrMLCode.Visible = True
		Me.cboVdrMLCode.Name = "cboVdrMLCode"
		Me.txtVdrCreditLimit.AutoSize = False
		Me.txtVdrCreditLimit.Enabled = False
		Me.txtVdrCreditLimit.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrCreditLimit.Size = New System.Drawing.Size(105, 20)
		Me.txtVdrCreditLimit.Location = New System.Drawing.Point(368, 48)
		Me.txtVdrCreditLimit.TabIndex = 26
		Me.txtVdrCreditLimit.AcceptsReturn = True
		Me.txtVdrCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrCreditLimit.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrCreditLimit.CausesValidation = True
		Me.txtVdrCreditLimit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrCreditLimit.HideSelection = True
		Me.txtVdrCreditLimit.ReadOnly = False
		Me.txtVdrCreditLimit.Maxlength = 0
		Me.txtVdrCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrCreditLimit.MultiLine = False
		Me.txtVdrCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrCreditLimit.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrCreditLimit.TabStop = True
		Me.txtVdrCreditLimit.Visible = True
		Me.txtVdrCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrCreditLimit.Name = "txtVdrCreditLimit"
		Me.txtVdrPayTerm.AutoSize = False
		Me.txtVdrPayTerm.Enabled = False
		Me.txtVdrPayTerm.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrPayTerm.Size = New System.Drawing.Size(140, 20)
		Me.txtVdrPayTerm.Location = New System.Drawing.Point(144, 48)
		Me.txtVdrPayTerm.TabIndex = 25
		Me.txtVdrPayTerm.AcceptsReturn = True
		Me.txtVdrPayTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrPayTerm.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrPayTerm.CausesValidation = True
		Me.txtVdrPayTerm.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrPayTerm.HideSelection = True
		Me.txtVdrPayTerm.ReadOnly = False
		Me.txtVdrPayTerm.Maxlength = 0
		Me.txtVdrPayTerm.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrPayTerm.MultiLine = False
		Me.txtVdrPayTerm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrPayTerm.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrPayTerm.TabStop = True
		Me.txtVdrPayTerm.Visible = True
		Me.txtVdrPayTerm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrPayTerm.Name = "txtVdrPayTerm"
		Me.txtVdrRemark.AutoSize = False
		Me.txtVdrRemark.Enabled = False
		Me.txtVdrRemark.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrRemark.Size = New System.Drawing.Size(511, 68)
		Me.txtVdrRemark.Location = New System.Drawing.Point(80, 120)
		Me.txtVdrRemark.MultiLine = True
		Me.txtVdrRemark.TabIndex = 30
		Me.txtVdrRemark.AcceptsReturn = True
		Me.txtVdrRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrRemark.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrRemark.CausesValidation = True
		Me.txtVdrRemark.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrRemark.HideSelection = True
		Me.txtVdrRemark.ReadOnly = False
		Me.txtVdrRemark.Maxlength = 0
		Me.txtVdrRemark.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrRemark.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrRemark.TabStop = True
		Me.txtVdrRemark.Visible = True
		Me.txtVdrRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrRemark.Name = "txtVdrRemark"
		Me.txtVdrSpecDis.AutoSize = False
		Me.txtVdrSpecDis.Enabled = False
		Me.txtVdrSpecDis.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtVdrSpecDis.Size = New System.Drawing.Size(229, 20)
		Me.txtVdrSpecDis.Location = New System.Drawing.Point(368, 96)
		Me.txtVdrSpecDis.TabIndex = 29
		Me.txtVdrSpecDis.AcceptsReturn = True
		Me.txtVdrSpecDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVdrSpecDis.BackColor = System.Drawing.SystemColors.Window
		Me.txtVdrSpecDis.CausesValidation = True
		Me.txtVdrSpecDis.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVdrSpecDis.HideSelection = True
		Me.txtVdrSpecDis.ReadOnly = False
		Me.txtVdrSpecDis.Maxlength = 0
		Me.txtVdrSpecDis.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVdrSpecDis.MultiLine = False
		Me.txtVdrSpecDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVdrSpecDis.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVdrSpecDis.TabStop = True
		Me.txtVdrSpecDis.Visible = True
		Me.txtVdrSpecDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVdrSpecDis.Name = "txtVdrSpecDis"
		Me.cboVdrCurr.Enabled = False
		Me.cboVdrCurr.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cboVdrCurr.Size = New System.Drawing.Size(201, 20)
		Me.cboVdrCurr.Location = New System.Drawing.Point(80, 96)
		Me.cboVdrCurr.TabIndex = 28
		Me.cboVdrCurr.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrCurr.CausesValidation = True
		Me.cboVdrCurr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrCurr.IntegralHeight = True
		Me.cboVdrCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrCurr.Sorted = False
		Me.cboVdrCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrCurr.TabStop = True
		Me.cboVdrCurr.Visible = True
		Me.cboVdrCurr.Name = "cboVdrCurr"
		Me.cboVdrPayCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cboVdrPayCode.Size = New System.Drawing.Size(61, 20)
		Me.cboVdrPayCode.Location = New System.Drawing.Point(80, 48)
		Me.cboVdrPayCode.TabIndex = 24
		Me.cboVdrPayCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrPayCode.CausesValidation = True
		Me.cboVdrPayCode.Enabled = True
		Me.cboVdrPayCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrPayCode.IntegralHeight = True
		Me.cboVdrPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrPayCode.Sorted = False
		Me.cboVdrPayCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrPayCode.TabStop = True
		Me.cboVdrPayCode.Visible = True
		Me.cboVdrPayCode.Name = "cboVdrPayCode"
		Me.lblVdrSaleName.Text = "VDRSALENAME"
		Me.lblVdrSaleName.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrSaleName.Size = New System.Drawing.Size(63, 16)
		Me.lblVdrSaleName.Location = New System.Drawing.Point(288, 29)
		Me.lblVdrSaleName.TabIndex = 88
		Me.lblVdrSaleName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrSaleName.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrSaleName.Enabled = True
		Me.lblVdrSaleName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrSaleName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrSaleName.UseMnemonic = True
		Me.lblVdrSaleName.Visible = True
		Me.lblVdrSaleName.AutoSize = False
		Me.lblVdrSaleName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrSaleName.Name = "lblVdrSaleName"
		Me.lblDspVdrSaleName.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspVdrSaleName.Size = New System.Drawing.Size(143, 20)
		Me.lblDspVdrSaleName.Location = New System.Drawing.Point(456, 24)
		Me.lblDspVdrSaleName.TabIndex = 87
		Me.lblDspVdrSaleName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrSaleName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrSaleName.Enabled = True
		Me.lblDspVdrSaleName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrSaleName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrSaleName.UseMnemonic = True
		Me.lblDspVdrSaleName.Visible = True
		Me.lblDspVdrSaleName.AutoSize = False
		Me.lblDspVdrSaleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrSaleName.Name = "lblDspVdrSaleName"
		Me.lblVdrMLCode.Text = "VDRMLCODE"
		Me.lblVdrMLCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrMLCode.Size = New System.Drawing.Size(61, 16)
		Me.lblVdrMLCode.Location = New System.Drawing.Point(8, 76)
		Me.lblVdrMLCode.TabIndex = 60
		Me.lblVdrMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrMLCode.Enabled = True
		Me.lblVdrMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrMLCode.UseMnemonic = True
		Me.lblVdrMLCode.Visible = True
		Me.lblVdrMLCode.AutoSize = False
		Me.lblVdrMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrMLCode.Name = "lblVdrMLCode"
		Me.lblDspVdrMLDesc.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspVdrMLDesc.Size = New System.Drawing.Size(140, 20)
		Me.lblDspVdrMLDesc.Location = New System.Drawing.Point(144, 72)
		Me.lblDspVdrMLDesc.TabIndex = 59
		Me.lblDspVdrMLDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrMLDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrMLDesc.Enabled = True
		Me.lblDspVdrMLDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrMLDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrMLDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrMLDesc.UseMnemonic = True
		Me.lblDspVdrMLDesc.Visible = True
		Me.lblDspVdrMLDesc.AutoSize = False
		Me.lblDspVdrMLDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrMLDesc.Name = "lblDspVdrMLDesc"
		Me.lblDspVdrOpenBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspVdrOpenBal.Size = New System.Drawing.Size(231, 20)
		Me.lblDspVdrOpenBal.Location = New System.Drawing.Point(368, 72)
		Me.lblDspVdrOpenBal.TabIndex = 57
		Me.lblDspVdrOpenBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrOpenBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrOpenBal.Enabled = True
		Me.lblDspVdrOpenBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrOpenBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrOpenBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrOpenBal.UseMnemonic = True
		Me.lblDspVdrOpenBal.Visible = True
		Me.lblDspVdrOpenBal.AutoSize = False
		Me.lblDspVdrOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrOpenBal.Name = "lblDspVdrOpenBal"
		Me.lblVdrCreditLimit.Text = "信用限度 :"
		Me.lblVdrCreditLimit.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrCreditLimit.Size = New System.Drawing.Size(124, 16)
		Me.lblVdrCreditLimit.Location = New System.Drawing.Point(288, 52)
		Me.lblVdrCreditLimit.TabIndex = 56
		Me.lblVdrCreditLimit.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrCreditLimit.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrCreditLimit.Enabled = True
		Me.lblVdrCreditLimit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrCreditLimit.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrCreditLimit.UseMnemonic = True
		Me.lblVdrCreditLimit.Visible = True
		Me.lblVdrCreditLimit.AutoSize = False
		Me.lblVdrCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrCreditLimit.Name = "lblVdrCreditLimit"
		Me.lblVdrPayCode.Text = "付款條款 :"
		Me.lblVdrPayCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrPayCode.Size = New System.Drawing.Size(84, 16)
		Me.lblVdrPayCode.Location = New System.Drawing.Point(8, 53)
		Me.lblVdrPayCode.TabIndex = 55
		Me.lblVdrPayCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrPayCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrPayCode.Enabled = True
		Me.lblVdrPayCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrPayCode.UseMnemonic = True
		Me.lblVdrPayCode.Visible = True
		Me.lblVdrPayCode.AutoSize = False
		Me.lblVdrPayCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrPayCode.Name = "lblVdrPayCode"
		Me.lblVdrRemark.Text = "備註 :"
		Me.lblVdrRemark.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrRemark.Size = New System.Drawing.Size(60, 16)
		Me.lblVdrRemark.Location = New System.Drawing.Point(8, 128)
		Me.lblVdrRemark.TabIndex = 53
		Me.lblVdrRemark.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrRemark.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrRemark.Enabled = True
		Me.lblVdrRemark.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrRemark.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrRemark.UseMnemonic = True
		Me.lblVdrRemark.Visible = True
		Me.lblVdrRemark.AutoSize = False
		Me.lblVdrRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrRemark.Name = "lblVdrRemark"
		Me.lblVdrCurr.Text = "貨幣 :"
		Me.lblVdrCurr.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrCurr.Size = New System.Drawing.Size(61, 16)
		Me.lblVdrCurr.Location = New System.Drawing.Point(8, 100)
		Me.lblVdrCurr.TabIndex = 52
		Me.lblVdrCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrCurr.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrCurr.Enabled = True
		Me.lblVdrCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrCurr.UseMnemonic = True
		Me.lblVdrCurr.Visible = True
		Me.lblVdrCurr.AutoSize = False
		Me.lblVdrCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrCurr.Name = "lblVdrCurr"
		Me.lblVdrOpenBal.Text = "戶口結存 :"
		Me.lblVdrOpenBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrOpenBal.Size = New System.Drawing.Size(116, 16)
		Me.lblVdrOpenBal.Location = New System.Drawing.Point(288, 76)
		Me.lblVdrOpenBal.TabIndex = 51
		Me.lblVdrOpenBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrOpenBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrOpenBal.Enabled = True
		Me.lblVdrOpenBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrOpenBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrOpenBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrOpenBal.UseMnemonic = True
		Me.lblVdrOpenBal.Visible = True
		Me.lblVdrOpenBal.AutoSize = False
		Me.lblVdrOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrOpenBal.Name = "lblVdrOpenBal"
		Me.lblVdrSpecDis.Text = "特別折扣 :"
		Me.lblVdrSpecDis.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrSpecDis.Size = New System.Drawing.Size(116, 16)
		Me.lblVdrSpecDis.Location = New System.Drawing.Point(288, 100)
		Me.lblVdrSpecDis.TabIndex = 50
		Me.lblVdrSpecDis.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrSpecDis.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrSpecDis.Enabled = True
		Me.lblVdrSpecDis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrSpecDis.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrSpecDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrSpecDis.UseMnemonic = True
		Me.lblVdrSpecDis.Visible = True
		Me.lblVdrSpecDis.AutoSize = False
		Me.lblVdrSpecDis.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrSpecDis.Name = "lblVdrSpecDis"
		Me._tabDetailInfo_TabPage3.Text = "Tab 3"
		Me.lblOpenBal.Text = "OPENBAL"
		Me.lblOpenBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblOpenBal.Size = New System.Drawing.Size(109, 16)
		Me.lblOpenBal.Location = New System.Drawing.Point(16, 132)
		Me.lblOpenBal.TabIndex = 64
		Me.lblOpenBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblOpenBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblOpenBal.Enabled = True
		Me.lblOpenBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblOpenBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblOpenBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblOpenBal.UseMnemonic = True
		Me.lblOpenBal.Visible = True
		Me.lblOpenBal.AutoSize = False
		Me.lblOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblOpenBal.Name = "lblOpenBal"
		Me.lblDspOpenBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspOpenBal.Size = New System.Drawing.Size(103, 20)
		Me.lblDspOpenBal.Location = New System.Drawing.Point(128, 128)
		Me.lblDspOpenBal.TabIndex = 65
		Me.lblDspOpenBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspOpenBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspOpenBal.Enabled = True
		Me.lblDspOpenBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspOpenBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspOpenBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspOpenBal.UseMnemonic = True
		Me.lblDspOpenBal.Visible = True
		Me.lblDspOpenBal.AutoSize = False
		Me.lblDspOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspOpenBal.Name = "lblDspOpenBal"
		Me.lblDspARBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspARBal.Size = New System.Drawing.Size(103, 20)
		Me.lblDspARBal.Location = New System.Drawing.Point(128, 176)
		Me.lblDspARBal.TabIndex = 66
		Me.lblDspARBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspARBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspARBal.Enabled = True
		Me.lblDspARBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspARBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspARBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspARBal.UseMnemonic = True
		Me.lblDspARBal.Visible = True
		Me.lblDspARBal.AutoSize = False
		Me.lblDspARBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspARBal.Name = "lblDspARBal"
		Me.lblARBal.Text = "ARBAL"
		Me.lblARBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblARBal.Size = New System.Drawing.Size(109, 16)
		Me.lblARBal.Location = New System.Drawing.Point(16, 180)
		Me.lblARBal.TabIndex = 67
		Me.lblARBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblARBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblARBal.Enabled = True
		Me.lblARBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblARBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblARBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblARBal.UseMnemonic = True
		Me.lblARBal.Visible = True
		Me.lblARBal.AutoSize = False
		Me.lblARBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblARBal.Name = "lblARBal"
		Me.lblDspCloseBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspCloseBal.Size = New System.Drawing.Size(103, 20)
		Me.lblDspCloseBal.Location = New System.Drawing.Point(128, 152)
		Me.lblDspCloseBal.TabIndex = 68
		Me.lblDspCloseBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCloseBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCloseBal.Enabled = True
		Me.lblDspCloseBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCloseBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCloseBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCloseBal.UseMnemonic = True
		Me.lblDspCloseBal.Visible = True
		Me.lblDspCloseBal.AutoSize = False
		Me.lblDspCloseBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCloseBal.Name = "lblDspCloseBal"
		Me.lblCloseBal.Text = "CLOSEBAL"
		Me.lblCloseBal.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblCloseBal.Size = New System.Drawing.Size(109, 16)
		Me.lblCloseBal.Location = New System.Drawing.Point(16, 156)
		Me.lblCloseBal.TabIndex = 69
		Me.lblCloseBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCloseBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblCloseBal.Enabled = True
		Me.lblCloseBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCloseBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCloseBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCloseBal.UseMnemonic = True
		Me.lblCloseBal.Visible = True
		Me.lblCloseBal.AutoSize = False
		Me.lblCloseBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCloseBal.Name = "lblCloseBal"
		Me.lblAcmMnSale.Text = "ACMMNSALE"
		Me.lblAcmMnSale.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblAcmMnSale.Size = New System.Drawing.Size(109, 16)
		Me.lblAcmMnSale.Location = New System.Drawing.Point(16, 108)
		Me.lblAcmMnSale.TabIndex = 70
		Me.lblAcmMnSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAcmMnSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblAcmMnSale.Enabled = True
		Me.lblAcmMnSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAcmMnSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAcmMnSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAcmMnSale.UseMnemonic = True
		Me.lblAcmMnSale.Visible = True
		Me.lblAcmMnSale.AutoSize = False
		Me.lblAcmMnSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAcmMnSale.Name = "lblAcmMnSale"
		Me.lblDspAcmMnSaleNet.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmMnSaleNet.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmMnSaleNet.Location = New System.Drawing.Point(272, 104)
		Me.lblDspAcmMnSaleNet.TabIndex = 71
		Me.lblDspAcmMnSaleNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmMnSaleNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmMnSaleNet.Enabled = True
		Me.lblDspAcmMnSaleNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmMnSaleNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmMnSaleNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmMnSaleNet.UseMnemonic = True
		Me.lblDspAcmMnSaleNet.Visible = True
		Me.lblDspAcmMnSaleNet.AutoSize = False
		Me.lblDspAcmMnSaleNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmMnSaleNet.Name = "lblDspAcmMnSaleNet"
		Me.lblDspAcmMnSaleAmt.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmMnSaleAmt.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmMnSaleAmt.Location = New System.Drawing.Point(200, 104)
		Me.lblDspAcmMnSaleAmt.TabIndex = 72
		Me.lblDspAcmMnSaleAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmMnSaleAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmMnSaleAmt.Enabled = True
		Me.lblDspAcmMnSaleAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmMnSaleAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmMnSaleAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmMnSaleAmt.UseMnemonic = True
		Me.lblDspAcmMnSaleAmt.Visible = True
		Me.lblDspAcmMnSaleAmt.AutoSize = False
		Me.lblDspAcmMnSaleAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmMnSaleAmt.Name = "lblDspAcmMnSaleAmt"
		Me.lblDspAcmMnSaleQty.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmMnSaleQty.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmMnSaleQty.Location = New System.Drawing.Point(128, 104)
		Me.lblDspAcmMnSaleQty.TabIndex = 73
		Me.lblDspAcmMnSaleQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmMnSaleQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmMnSaleQty.Enabled = True
		Me.lblDspAcmMnSaleQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmMnSaleQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmMnSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmMnSaleQty.UseMnemonic = True
		Me.lblDspAcmMnSaleQty.Visible = True
		Me.lblDspAcmMnSaleQty.AutoSize = False
		Me.lblDspAcmMnSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmMnSaleQty.Name = "lblDspAcmMnSaleQty"
		Me.lblAcmYrSale.Text = "ACMYRSALE"
		Me.lblAcmYrSale.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblAcmYrSale.Size = New System.Drawing.Size(109, 16)
		Me.lblAcmYrSale.Location = New System.Drawing.Point(16, 84)
		Me.lblAcmYrSale.TabIndex = 74
		Me.lblAcmYrSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAcmYrSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblAcmYrSale.Enabled = True
		Me.lblAcmYrSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAcmYrSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAcmYrSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAcmYrSale.UseMnemonic = True
		Me.lblAcmYrSale.Visible = True
		Me.lblAcmYrSale.AutoSize = False
		Me.lblAcmYrSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAcmYrSale.Name = "lblAcmYrSale"
		Me.lblDspAcmYrSaleNet.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmYrSaleNet.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmYrSaleNet.Location = New System.Drawing.Point(272, 80)
		Me.lblDspAcmYrSaleNet.TabIndex = 75
		Me.lblDspAcmYrSaleNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmYrSaleNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmYrSaleNet.Enabled = True
		Me.lblDspAcmYrSaleNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmYrSaleNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmYrSaleNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmYrSaleNet.UseMnemonic = True
		Me.lblDspAcmYrSaleNet.Visible = True
		Me.lblDspAcmYrSaleNet.AutoSize = False
		Me.lblDspAcmYrSaleNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmYrSaleNet.Name = "lblDspAcmYrSaleNet"
		Me.lblDspAcmYrSaleAmt.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmYrSaleAmt.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmYrSaleAmt.Location = New System.Drawing.Point(200, 80)
		Me.lblDspAcmYrSaleAmt.TabIndex = 76
		Me.lblDspAcmYrSaleAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmYrSaleAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmYrSaleAmt.Enabled = True
		Me.lblDspAcmYrSaleAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmYrSaleAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmYrSaleAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmYrSaleAmt.UseMnemonic = True
		Me.lblDspAcmYrSaleAmt.Visible = True
		Me.lblDspAcmYrSaleAmt.AutoSize = False
		Me.lblDspAcmYrSaleAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmYrSaleAmt.Name = "lblDspAcmYrSaleAmt"
		Me.lblDspAcmYrSaleQty.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmYrSaleQty.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmYrSaleQty.Location = New System.Drawing.Point(128, 80)
		Me.lblDspAcmYrSaleQty.TabIndex = 77
		Me.lblDspAcmYrSaleQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmYrSaleQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmYrSaleQty.Enabled = True
		Me.lblDspAcmYrSaleQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmYrSaleQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmYrSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmYrSaleQty.UseMnemonic = True
		Me.lblDspAcmYrSaleQty.Visible = True
		Me.lblDspAcmYrSaleQty.AutoSize = False
		Me.lblDspAcmYrSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmYrSaleQty.Name = "lblDspAcmYrSaleQty"
		Me.lblAcmSale.Text = "ACMSALE"
		Me.lblAcmSale.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblAcmSale.Size = New System.Drawing.Size(109, 16)
		Me.lblAcmSale.Location = New System.Drawing.Point(16, 60)
		Me.lblAcmSale.TabIndex = 78
		Me.lblAcmSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAcmSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblAcmSale.Enabled = True
		Me.lblAcmSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAcmSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAcmSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAcmSale.UseMnemonic = True
		Me.lblAcmSale.Visible = True
		Me.lblAcmSale.AutoSize = False
		Me.lblAcmSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAcmSale.Name = "lblAcmSale"
		Me.lblDspAcmSaleNet.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmSaleNet.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmSaleNet.Location = New System.Drawing.Point(272, 56)
		Me.lblDspAcmSaleNet.TabIndex = 79
		Me.lblDspAcmSaleNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmSaleNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmSaleNet.Enabled = True
		Me.lblDspAcmSaleNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmSaleNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmSaleNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmSaleNet.UseMnemonic = True
		Me.lblDspAcmSaleNet.Visible = True
		Me.lblDspAcmSaleNet.AutoSize = False
		Me.lblDspAcmSaleNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmSaleNet.Name = "lblDspAcmSaleNet"
		Me.lblDspAcmSaleAmt.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmSaleAmt.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmSaleAmt.Location = New System.Drawing.Point(200, 56)
		Me.lblDspAcmSaleAmt.TabIndex = 80
		Me.lblDspAcmSaleAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmSaleAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmSaleAmt.Enabled = True
		Me.lblDspAcmSaleAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmSaleAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmSaleAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmSaleAmt.UseMnemonic = True
		Me.lblDspAcmSaleAmt.Visible = True
		Me.lblDspAcmSaleAmt.AutoSize = False
		Me.lblDspAcmSaleAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmSaleAmt.Name = "lblDspAcmSaleAmt"
		Me.lblNet.Text = "NET"
		Me.lblNet.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblNet.Size = New System.Drawing.Size(37, 16)
		Me.lblNet.Location = New System.Drawing.Point(296, 40)
		Me.lblNet.TabIndex = 81
		Me.lblNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblNet.Enabled = True
		Me.lblNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNet.UseMnemonic = True
		Me.lblNet.Visible = True
		Me.lblNet.AutoSize = False
		Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNet.Name = "lblNet"
		Me.lblAmt.Text = "AMT"
		Me.lblAmt.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblAmt.Size = New System.Drawing.Size(37, 16)
		Me.lblAmt.Location = New System.Drawing.Point(224, 40)
		Me.lblAmt.TabIndex = 82
		Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblAmt.Enabled = True
		Me.lblAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAmt.UseMnemonic = True
		Me.lblAmt.Visible = True
		Me.lblAmt.AutoSize = False
		Me.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAmt.Name = "lblAmt"
		Me.lblDspAcmSaleQty.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspAcmSaleQty.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmSaleQty.Location = New System.Drawing.Point(128, 56)
		Me.lblDspAcmSaleQty.TabIndex = 83
		Me.lblDspAcmSaleQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmSaleQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmSaleQty.Enabled = True
		Me.lblDspAcmSaleQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmSaleQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmSaleQty.UseMnemonic = True
		Me.lblDspAcmSaleQty.Visible = True
		Me.lblDspAcmSaleQty.AutoSize = False
		Me.lblDspAcmSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmSaleQty.Name = "lblDspAcmSaleQty"
		Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblQty.Text = "QTY"
		Me.lblQty.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblQty.Size = New System.Drawing.Size(69, 16)
		Me.lblQty.Location = New System.Drawing.Point(128, 40)
		Me.lblQty.TabIndex = 84
		Me.lblQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblQty.Enabled = True
		Me.lblQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblQty.UseMnemonic = True
		Me.lblQty.Visible = True
		Me.lblQty.AutoSize = False
		Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblQty.Name = "lblQty"
		Me.lblVdrCrtDate.Text = "VDRCRTDATE"
		Me.lblVdrCrtDate.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblVdrCrtDate.Size = New System.Drawing.Size(109, 16)
		Me.lblVdrCrtDate.Location = New System.Drawing.Point(16, 20)
		Me.lblVdrCrtDate.TabIndex = 85
		Me.lblVdrCrtDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrCrtDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrCrtDate.Enabled = True
		Me.lblVdrCrtDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrCrtDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrCrtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrCrtDate.UseMnemonic = True
		Me.lblVdrCrtDate.Visible = True
		Me.lblVdrCrtDate.AutoSize = False
		Me.lblVdrCrtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrCrtDate.Name = "lblVdrCrtDate"
		Me.lblDspCrtDate.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDspCrtDate.Size = New System.Drawing.Size(103, 20)
		Me.lblDspCrtDate.Location = New System.Drawing.Point(128, 16)
		Me.lblDspCrtDate.TabIndex = 86
		Me.lblDspCrtDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCrtDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCrtDate.Enabled = True
		Me.lblDspCrtDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCrtDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCrtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCrtDate.UseMnemonic = True
		Me.lblDspCrtDate.Visible = True
		Me.lblDspCrtDate.AutoSize = False
		Me.lblDspCrtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCrtDate.Name = "lblDspCrtDate"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(249, 177)
		Me.tblDetail.Location = New System.Drawing.Point(352, 16)
		Me.tblDetail.TabIndex = 63
		Me.tblDetail.Name = "tblDetail"
		Me.Controls.Add(cboVdrRgnCode)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboVdrCode)
		Me.Controls.Add(fraVdrInfo)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tabDetailInfo)
		Me.fraVdrInfo.Controls.Add(txtVdrCode)
		Me.fraVdrInfo.Controls.Add(txtVdrName)
		Me.fraVdrInfo.Controls.Add(txtVdrTel)
		Me.fraVdrInfo.Controls.Add(txtVdrFax)
		Me.fraVdrInfo.Controls.Add(chkInActive)
		Me.fraVdrInfo.Controls.Add(txtVdrContactName)
		Me.fraVdrInfo.Controls.Add(txtVdrEmail)
		Me.fraVdrInfo.Controls.Add(lblVdrTel)
		Me.fraVdrInfo.Controls.Add(lblVdrName)
		Me.fraVdrInfo.Controls.Add(lblDspVdrRgnDesc)
		Me.fraVdrInfo.Controls.Add(lblVdrRgnCode)
		Me.fraVdrInfo.Controls.Add(lblVdrCode)
		Me.fraVdrInfo.Controls.Add(lblVdrFax)
		Me.fraVdrInfo.Controls.Add(lblVdrContactName)
		Me.fraVdrInfo.Controls.Add(lblVdrEmail)
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
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage2)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage3)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtVdrContactName1)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtVdrAddress4)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtVdrAddress3)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtVdrAddress2)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtVdrAddress1)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblVdrContactName1)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblVdrAddress1)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblDspVdrLastUpdDate)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblDspVdrLastUpd)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblVdrLastUpdDate)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblVdrLastUpd)
		Me._tabDetailInfo_TabPage1.Controls.Add(fraVdrShipAddr1)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipAdd2)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipAdd4)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipAdd3)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipAdd1)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipName)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipContactPerson)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipTel)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipFax)
		Me.fraVdrShipAddr1.Controls.Add(txtVdrShipEmail)
		Me.fraVdrShipAddr1.Controls.Add(lblVdrShipAdd)
		Me.fraVdrShipAddr1.Controls.Add(lblVdrShipName)
		Me.fraVdrShipAddr1.Controls.Add(lblVdrShipContactPerson)
		Me.fraVdrShipAddr1.Controls.Add(lblVdrShipTel)
		Me.fraVdrShipAddr1.Controls.Add(lblVdrShipEmail)
		Me.fraVdrShipAddr1.Controls.Add(lblVdrShipFax)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboVdrSaleCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboVdrMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtVdrCreditLimit)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtVdrPayTerm)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtVdrRemark)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtVdrSpecDis)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboVdrCurr)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboVdrPayCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrSaleName)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspVdrSaleName)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspVdrMLDesc)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspVdrOpenBal)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrCreditLimit)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrPayCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrRemark)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrCurr)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrOpenBal)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblVdrSpecDis)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblOpenBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspOpenBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspARBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblARBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspCloseBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblCloseBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAcmMnSale)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmMnSaleNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmMnSaleAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmMnSaleQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAcmYrSale)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmYrSaleNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmYrSaleAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmYrSaleQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAcmSale)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmSaleNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmSaleAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmSaleQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblVdrCrtDate)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspCrtDate)
		Me._tabDetailInfo_TabPage3.Controls.Add(tblDetail)
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraVdrInfo.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.fraVdrShipAddr1.ResumeLayout(False)
		Me._tabDetailInfo_TabPage2.ResumeLayout(False)
		Me._tabDetailInfo_TabPage3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class