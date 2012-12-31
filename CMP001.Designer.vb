<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCMP001
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
	Public WithEvents cboCmpCode As System.Windows.Forms.ComboBox
	Public WithEvents txtCmpRptEngAdd As System.Windows.Forms.TextBox
	Public WithEvents txtCmpRptChiAdd As System.Windows.Forms.TextBox
	Public WithEvents _txtCmpAddress_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtCmpAddress_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtCmpAddress_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtCmpAddress_4 As System.Windows.Forms.TextBox
	Public WithEvents picCmpAdr As System.Windows.Forms.Panel
	Public WithEvents lblCmpRptEngAdd As System.Windows.Forms.Label
	Public WithEvents lblCmpRptChiAdd As System.Windows.Forms.Label
	Public WithEvents lblCmpAdr As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents txtCmpFax As System.Windows.Forms.TextBox
	Public WithEvents txtCmpTel As System.Windows.Forms.TextBox
	Public WithEvents txtCmpEmail As System.Windows.Forms.TextBox
	Public WithEvents txtCmpWebSite As System.Windows.Forms.TextBox
	Public WithEvents lblCmpFax As System.Windows.Forms.Label
	Public WithEvents lblCmpTel As System.Windows.Forms.Label
	Public WithEvents lblCmpEmail As System.Windows.Forms.Label
	Public WithEvents lblCmpWebSite As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents lblCmpPayCode As System.Windows.Forms.Label
	Public WithEvents lblCmpRetainAC As System.Windows.Forms.Label
	Public WithEvents lblCmpExgMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpTiMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpCurr As System.Windows.Forms.Label
	Public WithEvents lblCmpSupMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpExlMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpTeMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpSamMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpDamMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpAdjMLCode As System.Windows.Forms.Label
	Public WithEvents lblCmpCurrEarn As System.Windows.Forms.Label
	Public WithEvents cboCmpPayCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpRetainAC As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpExgMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpTiMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpCurr As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpSupMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpExlMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpTeMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpSamMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpDamMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpAdjMLCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCmpCurrEarn As System.Windows.Forms.ComboBox
	Public WithEvents _tabDetailInfo_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents txtCmpBankAC As System.Windows.Forms.TextBox
	Public WithEvents txtCmpBankACName As System.Windows.Forms.TextBox
	Public WithEvents lblCmpBankAC As System.Windows.Forms.Label
	Public WithEvents lblCmpBankACName As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents txtCmpRemark As System.Windows.Forms.TextBox
	Public WithEvents lblCmpRemark As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage4 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	Public WithEvents txtCmpCode As System.Windows.Forms.TextBox
	Public WithEvents txtCmpChiName As System.Windows.Forms.TextBox
	Public WithEvents txtCmpEngName As System.Windows.Forms.TextBox
	Public WithEvents lblCmpLastUpd As System.Windows.Forms.Label
	Public WithEvents lblCmpLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspCmpLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspCmpLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblCmpCode As System.Windows.Forms.Label
	Public WithEvents lblCmpChiName As System.Windows.Forms.Label
	Public WithEvents lblCmpEngName As System.Windows.Forms.Label
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
	Public WithEvents txtCmpAddress As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCMP001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboCmpCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.txtCmpRptEngAdd = New System.Windows.Forms.TextBox
		Me.txtCmpRptChiAdd = New System.Windows.Forms.TextBox
		Me.picCmpAdr = New System.Windows.Forms.Panel
		Me._txtCmpAddress_1 = New System.Windows.Forms.TextBox
		Me._txtCmpAddress_2 = New System.Windows.Forms.TextBox
		Me._txtCmpAddress_3 = New System.Windows.Forms.TextBox
		Me._txtCmpAddress_4 = New System.Windows.Forms.TextBox
		Me.lblCmpRptEngAdd = New System.Windows.Forms.Label
		Me.lblCmpRptChiAdd = New System.Windows.Forms.Label
		Me.lblCmpAdr = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.txtCmpFax = New System.Windows.Forms.TextBox
		Me.txtCmpTel = New System.Windows.Forms.TextBox
		Me.txtCmpEmail = New System.Windows.Forms.TextBox
		Me.txtCmpWebSite = New System.Windows.Forms.TextBox
		Me.lblCmpFax = New System.Windows.Forms.Label
		Me.lblCmpTel = New System.Windows.Forms.Label
		Me.lblCmpEmail = New System.Windows.Forms.Label
		Me.lblCmpWebSite = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage2 = New System.Windows.Forms.TabPage
		Me.lblCmpPayCode = New System.Windows.Forms.Label
		Me.lblCmpRetainAC = New System.Windows.Forms.Label
		Me.lblCmpExgMLCode = New System.Windows.Forms.Label
		Me.lblCmpTiMLCode = New System.Windows.Forms.Label
		Me.lblCmpCurr = New System.Windows.Forms.Label
		Me.lblCmpSupMLCode = New System.Windows.Forms.Label
		Me.lblCmpExlMLCode = New System.Windows.Forms.Label
		Me.lblCmpTeMLCode = New System.Windows.Forms.Label
		Me.lblCmpSamMLCode = New System.Windows.Forms.Label
		Me.lblCmpDamMLCode = New System.Windows.Forms.Label
		Me.lblCmpAdjMLCode = New System.Windows.Forms.Label
		Me.lblCmpCurrEarn = New System.Windows.Forms.Label
		Me.cboCmpPayCode = New System.Windows.Forms.ComboBox
		Me.cboCmpRetainAC = New System.Windows.Forms.ComboBox
		Me.cboCmpExgMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpTiMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpCurr = New System.Windows.Forms.ComboBox
		Me.cboCmpSupMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpExlMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpTeMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpSamMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpDamMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpAdjMLCode = New System.Windows.Forms.ComboBox
		Me.cboCmpCurrEarn = New System.Windows.Forms.ComboBox
		Me._tabDetailInfo_TabPage3 = New System.Windows.Forms.TabPage
		Me.txtCmpBankAC = New System.Windows.Forms.TextBox
		Me.txtCmpBankACName = New System.Windows.Forms.TextBox
		Me.lblCmpBankAC = New System.Windows.Forms.Label
		Me.lblCmpBankACName = New System.Windows.Forms.Label
		Me._tabDetailInfo_TabPage4 = New System.Windows.Forms.TabPage
		Me.txtCmpRemark = New System.Windows.Forms.TextBox
		Me.lblCmpRemark = New System.Windows.Forms.Label
		Me.txtCmpCode = New System.Windows.Forms.TextBox
		Me.txtCmpChiName = New System.Windows.Forms.TextBox
		Me.txtCmpEngName = New System.Windows.Forms.TextBox
		Me.lblCmpLastUpd = New System.Windows.Forms.Label
		Me.lblCmpLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspCmpLastUpd = New System.Windows.Forms.Label
		Me.lblDspCmpLastUpdDate = New System.Windows.Forms.Label
		Me.lblCmpCode = New System.Windows.Forms.Label
		Me.lblCmpChiName = New System.Windows.Forms.Label
		Me.lblCmpEngName = New System.Windows.Forms.Label
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
		Me.txtCmpAddress = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me.picCmpAdr.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me._tabDetailInfo_TabPage2.SuspendLayout()
		Me._tabDetailInfo_TabPage3.SuspendLayout()
		Me._tabDetailInfo_TabPage4.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCmpAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "CMP001"
		Me.ClientSize = New System.Drawing.Size(663, 405)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmCMP001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmCMP001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 38
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboCmpCode.Size = New System.Drawing.Size(134, 20)
		Me.cboCmpCode.Location = New System.Drawing.Point(168, 48)
		Me.cboCmpCode.TabIndex = 0
		Me.cboCmpCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpCode.CausesValidation = True
		Me.cboCmpCode.Enabled = True
		Me.cboCmpCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpCode.IntegralHeight = True
		Me.cboCmpCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpCode.Sorted = False
		Me.cboCmpCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpCode.TabStop = True
		Me.cboCmpCode.Visible = True
		Me.cboCmpCode.Name = "cboCmpCode"
		Me.fraDetailInfo.Text = "FRADETAILINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(649, 377)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 29
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.tabDetailInfo.Size = New System.Drawing.Size(633, 227)
		Me.tabDetailInfo.Location = New System.Drawing.Point(8, 104)
		Me.tabDetailInfo.TabIndex = 39
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.SelectedIndex = 2
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "Address"
		Me.txtCmpRptEngAdd.AutoSize = False
		Me.txtCmpRptEngAdd.Enabled = False
		Me.txtCmpRptEngAdd.Size = New System.Drawing.Size(485, 20)
		Me.txtCmpRptEngAdd.Location = New System.Drawing.Point(136, 120)
		Me.txtCmpRptEngAdd.TabIndex = 7
		Me.txtCmpRptEngAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpRptEngAdd.AcceptsReturn = True
		Me.txtCmpRptEngAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpRptEngAdd.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpRptEngAdd.CausesValidation = True
		Me.txtCmpRptEngAdd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpRptEngAdd.HideSelection = True
		Me.txtCmpRptEngAdd.ReadOnly = False
		Me.txtCmpRptEngAdd.Maxlength = 0
		Me.txtCmpRptEngAdd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpRptEngAdd.MultiLine = False
		Me.txtCmpRptEngAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpRptEngAdd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpRptEngAdd.TabStop = True
		Me.txtCmpRptEngAdd.Visible = True
		Me.txtCmpRptEngAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpRptEngAdd.Name = "txtCmpRptEngAdd"
		Me.txtCmpRptChiAdd.AutoSize = False
		Me.txtCmpRptChiAdd.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCmpRptChiAdd.Enabled = False
		Me.txtCmpRptChiAdd.Size = New System.Drawing.Size(485, 20)
		Me.txtCmpRptChiAdd.Location = New System.Drawing.Point(136, 160)
		Me.txtCmpRptChiAdd.TabIndex = 8
		Me.txtCmpRptChiAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpRptChiAdd.AcceptsReturn = True
		Me.txtCmpRptChiAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpRptChiAdd.CausesValidation = True
		Me.txtCmpRptChiAdd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpRptChiAdd.HideSelection = True
		Me.txtCmpRptChiAdd.ReadOnly = False
		Me.txtCmpRptChiAdd.Maxlength = 0
		Me.txtCmpRptChiAdd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpRptChiAdd.MultiLine = False
		Me.txtCmpRptChiAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpRptChiAdd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpRptChiAdd.TabStop = True
		Me.txtCmpRptChiAdd.Visible = True
		Me.txtCmpRptChiAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpRptChiAdd.Name = "txtCmpRptChiAdd"
		Me.picCmpAdr.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.picCmpAdr.Size = New System.Drawing.Size(485, 97)
		Me.picCmpAdr.Location = New System.Drawing.Point(136, 16)
		Me.picCmpAdr.TabIndex = 54
		Me.picCmpAdr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCmpAdr.Dock = System.Windows.Forms.DockStyle.None
		Me.picCmpAdr.CausesValidation = True
		Me.picCmpAdr.Enabled = True
		Me.picCmpAdr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCmpAdr.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCmpAdr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCmpAdr.TabStop = True
		Me.picCmpAdr.Visible = True
		Me.picCmpAdr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCmpAdr.Name = "picCmpAdr"
		Me._txtCmpAddress_1.AutoSize = False
		Me._txtCmpAddress_1.Size = New System.Drawing.Size(474, 20)
		Me._txtCmpAddress_1.Location = New System.Drawing.Point(0, 0)
		Me._txtCmpAddress_1.TabIndex = 3
		Me._txtCmpAddress_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtCmpAddress_1.AcceptsReturn = True
		Me._txtCmpAddress_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtCmpAddress_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtCmpAddress_1.CausesValidation = True
		Me._txtCmpAddress_1.Enabled = True
		Me._txtCmpAddress_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtCmpAddress_1.HideSelection = True
		Me._txtCmpAddress_1.ReadOnly = False
		Me._txtCmpAddress_1.Maxlength = 0
		Me._txtCmpAddress_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtCmpAddress_1.MultiLine = False
		Me._txtCmpAddress_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtCmpAddress_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtCmpAddress_1.TabStop = True
		Me._txtCmpAddress_1.Visible = True
		Me._txtCmpAddress_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtCmpAddress_1.Name = "_txtCmpAddress_1"
		Me._txtCmpAddress_2.AutoSize = False
		Me._txtCmpAddress_2.Size = New System.Drawing.Size(474, 20)
		Me._txtCmpAddress_2.Location = New System.Drawing.Point(0, 23)
		Me._txtCmpAddress_2.TabIndex = 4
		Me._txtCmpAddress_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtCmpAddress_2.AcceptsReturn = True
		Me._txtCmpAddress_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtCmpAddress_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtCmpAddress_2.CausesValidation = True
		Me._txtCmpAddress_2.Enabled = True
		Me._txtCmpAddress_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtCmpAddress_2.HideSelection = True
		Me._txtCmpAddress_2.ReadOnly = False
		Me._txtCmpAddress_2.Maxlength = 0
		Me._txtCmpAddress_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtCmpAddress_2.MultiLine = False
		Me._txtCmpAddress_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtCmpAddress_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtCmpAddress_2.TabStop = True
		Me._txtCmpAddress_2.Visible = True
		Me._txtCmpAddress_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtCmpAddress_2.Name = "_txtCmpAddress_2"
		Me._txtCmpAddress_3.AutoSize = False
		Me._txtCmpAddress_3.Size = New System.Drawing.Size(474, 20)
		Me._txtCmpAddress_3.Location = New System.Drawing.Point(0, 46)
		Me._txtCmpAddress_3.TabIndex = 5
		Me._txtCmpAddress_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtCmpAddress_3.AcceptsReturn = True
		Me._txtCmpAddress_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtCmpAddress_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtCmpAddress_3.CausesValidation = True
		Me._txtCmpAddress_3.Enabled = True
		Me._txtCmpAddress_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtCmpAddress_3.HideSelection = True
		Me._txtCmpAddress_3.ReadOnly = False
		Me._txtCmpAddress_3.Maxlength = 0
		Me._txtCmpAddress_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtCmpAddress_3.MultiLine = False
		Me._txtCmpAddress_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtCmpAddress_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtCmpAddress_3.TabStop = True
		Me._txtCmpAddress_3.Visible = True
		Me._txtCmpAddress_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtCmpAddress_3.Name = "_txtCmpAddress_3"
		Me._txtCmpAddress_4.AutoSize = False
		Me._txtCmpAddress_4.Size = New System.Drawing.Size(474, 20)
		Me._txtCmpAddress_4.Location = New System.Drawing.Point(0, 69)
		Me._txtCmpAddress_4.TabIndex = 6
		Me._txtCmpAddress_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtCmpAddress_4.AcceptsReturn = True
		Me._txtCmpAddress_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtCmpAddress_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtCmpAddress_4.CausesValidation = True
		Me._txtCmpAddress_4.Enabled = True
		Me._txtCmpAddress_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtCmpAddress_4.HideSelection = True
		Me._txtCmpAddress_4.ReadOnly = False
		Me._txtCmpAddress_4.Maxlength = 0
		Me._txtCmpAddress_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtCmpAddress_4.MultiLine = False
		Me._txtCmpAddress_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtCmpAddress_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtCmpAddress_4.TabStop = True
		Me._txtCmpAddress_4.Visible = True
		Me._txtCmpAddress_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtCmpAddress_4.Name = "_txtCmpAddress_4"
		Me.lblCmpRptEngAdd.Text = "CMPRPTENGADD"
		Me.lblCmpRptEngAdd.Size = New System.Drawing.Size(116, 25)
		Me.lblCmpRptEngAdd.Location = New System.Drawing.Point(16, 124)
		Me.lblCmpRptEngAdd.TabIndex = 58
		Me.lblCmpRptEngAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpRptEngAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpRptEngAdd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpRptEngAdd.Enabled = True
		Me.lblCmpRptEngAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpRptEngAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpRptEngAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpRptEngAdd.UseMnemonic = True
		Me.lblCmpRptEngAdd.Visible = True
		Me.lblCmpRptEngAdd.AutoSize = False
		Me.lblCmpRptEngAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpRptEngAdd.Name = "lblCmpRptEngAdd"
		Me.lblCmpRptChiAdd.Text = "CMPRPTCHIADD"
		Me.lblCmpRptChiAdd.Size = New System.Drawing.Size(116, 32)
		Me.lblCmpRptChiAdd.Location = New System.Drawing.Point(16, 160)
		Me.lblCmpRptChiAdd.TabIndex = 57
		Me.lblCmpRptChiAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpRptChiAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpRptChiAdd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpRptChiAdd.Enabled = True
		Me.lblCmpRptChiAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpRptChiAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpRptChiAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpRptChiAdd.UseMnemonic = True
		Me.lblCmpRptChiAdd.Visible = True
		Me.lblCmpRptChiAdd.AutoSize = False
		Me.lblCmpRptChiAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpRptChiAdd.Name = "lblCmpRptChiAdd"
		Me.lblCmpAdr.Text = "CMPADR"
		Me.lblCmpAdr.Size = New System.Drawing.Size(116, 32)
		Me.lblCmpAdr.Location = New System.Drawing.Point(16, 24)
		Me.lblCmpAdr.TabIndex = 55
		Me.lblCmpAdr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpAdr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpAdr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpAdr.Enabled = True
		Me.lblCmpAdr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpAdr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpAdr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpAdr.UseMnemonic = True
		Me.lblCmpAdr.Visible = True
		Me.lblCmpAdr.AutoSize = False
		Me.lblCmpAdr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpAdr.Name = "lblCmpAdr"
		Me._tabDetailInfo_TabPage1.Text = "General Info"
		Me.txtCmpFax.AutoSize = False
		Me.txtCmpFax.Enabled = False
		Me.txtCmpFax.Size = New System.Drawing.Size(195, 20)
		Me.txtCmpFax.Location = New System.Drawing.Point(400, 24)
		Me.txtCmpFax.TabIndex = 10
		Me.txtCmpFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpFax.AcceptsReturn = True
		Me.txtCmpFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpFax.CausesValidation = True
		Me.txtCmpFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpFax.HideSelection = True
		Me.txtCmpFax.ReadOnly = False
		Me.txtCmpFax.Maxlength = 0
		Me.txtCmpFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpFax.MultiLine = False
		Me.txtCmpFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpFax.TabStop = True
		Me.txtCmpFax.Visible = True
		Me.txtCmpFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpFax.Name = "txtCmpFax"
		Me.txtCmpTel.AutoSize = False
		Me.txtCmpTel.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCmpTel.Enabled = False
		Me.txtCmpTel.Size = New System.Drawing.Size(195, 20)
		Me.txtCmpTel.Location = New System.Drawing.Point(96, 24)
		Me.txtCmpTel.TabIndex = 9
		Me.txtCmpTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpTel.AcceptsReturn = True
		Me.txtCmpTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpTel.CausesValidation = True
		Me.txtCmpTel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpTel.HideSelection = True
		Me.txtCmpTel.ReadOnly = False
		Me.txtCmpTel.Maxlength = 0
		Me.txtCmpTel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpTel.MultiLine = False
		Me.txtCmpTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpTel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpTel.TabStop = True
		Me.txtCmpTel.Visible = True
		Me.txtCmpTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpTel.Name = "txtCmpTel"
		Me.txtCmpEmail.AutoSize = False
		Me.txtCmpEmail.Enabled = False
		Me.txtCmpEmail.Size = New System.Drawing.Size(499, 20)
		Me.txtCmpEmail.Location = New System.Drawing.Point(96, 48)
		Me.txtCmpEmail.TabIndex = 11
		Me.txtCmpEmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpEmail.AcceptsReturn = True
		Me.txtCmpEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpEmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpEmail.CausesValidation = True
		Me.txtCmpEmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpEmail.HideSelection = True
		Me.txtCmpEmail.ReadOnly = False
		Me.txtCmpEmail.Maxlength = 0
		Me.txtCmpEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpEmail.MultiLine = False
		Me.txtCmpEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpEmail.TabStop = True
		Me.txtCmpEmail.Visible = True
		Me.txtCmpEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpEmail.Name = "txtCmpEmail"
		Me.txtCmpWebSite.AutoSize = False
		Me.txtCmpWebSite.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCmpWebSite.Enabled = False
		Me.txtCmpWebSite.Size = New System.Drawing.Size(499, 20)
		Me.txtCmpWebSite.Location = New System.Drawing.Point(96, 72)
		Me.txtCmpWebSite.TabIndex = 12
		Me.txtCmpWebSite.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpWebSite.AcceptsReturn = True
		Me.txtCmpWebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpWebSite.CausesValidation = True
		Me.txtCmpWebSite.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpWebSite.HideSelection = True
		Me.txtCmpWebSite.ReadOnly = False
		Me.txtCmpWebSite.Maxlength = 0
		Me.txtCmpWebSite.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpWebSite.MultiLine = False
		Me.txtCmpWebSite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpWebSite.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpWebSite.TabStop = True
		Me.txtCmpWebSite.Visible = True
		Me.txtCmpWebSite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpWebSite.Name = "txtCmpWebSite"
		Me.lblCmpFax.Text = "CMPFAX"
		Me.lblCmpFax.Size = New System.Drawing.Size(81, 17)
		Me.lblCmpFax.Location = New System.Drawing.Point(320, 28)
		Me.lblCmpFax.TabIndex = 53
		Me.lblCmpFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpFax.Enabled = True
		Me.lblCmpFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpFax.UseMnemonic = True
		Me.lblCmpFax.Visible = True
		Me.lblCmpFax.AutoSize = False
		Me.lblCmpFax.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpFax.Name = "lblCmpFax"
		Me.lblCmpTel.Text = "CMPTEL"
		Me.lblCmpTel.Size = New System.Drawing.Size(92, 16)
		Me.lblCmpTel.Location = New System.Drawing.Point(16, 28)
		Me.lblCmpTel.TabIndex = 52
		Me.lblCmpTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpTel.Enabled = True
		Me.lblCmpTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpTel.UseMnemonic = True
		Me.lblCmpTel.Visible = True
		Me.lblCmpTel.AutoSize = False
		Me.lblCmpTel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpTel.Name = "lblCmpTel"
		Me.lblCmpEmail.Text = "CMPEMAIL"
		Me.lblCmpEmail.Size = New System.Drawing.Size(81, 17)
		Me.lblCmpEmail.Location = New System.Drawing.Point(16, 52)
		Me.lblCmpEmail.TabIndex = 51
		Me.lblCmpEmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpEmail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpEmail.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpEmail.Enabled = True
		Me.lblCmpEmail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpEmail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpEmail.UseMnemonic = True
		Me.lblCmpEmail.Visible = True
		Me.lblCmpEmail.AutoSize = False
		Me.lblCmpEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpEmail.Name = "lblCmpEmail"
		Me.lblCmpWebSite.Text = "CMPWEBSITE"
		Me.lblCmpWebSite.Size = New System.Drawing.Size(92, 16)
		Me.lblCmpWebSite.Location = New System.Drawing.Point(16, 76)
		Me.lblCmpWebSite.TabIndex = 50
		Me.lblCmpWebSite.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpWebSite.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpWebSite.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpWebSite.Enabled = True
		Me.lblCmpWebSite.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpWebSite.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpWebSite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpWebSite.UseMnemonic = True
		Me.lblCmpWebSite.Visible = True
		Me.lblCmpWebSite.AutoSize = False
		Me.lblCmpWebSite.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpWebSite.Name = "lblCmpWebSite"
		Me._tabDetailInfo_TabPage2.Text = "Accounting Info"
		Me.lblCmpPayCode.Text = "CMPPAYCODE"
		Me.lblCmpPayCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpPayCode.Location = New System.Drawing.Point(8, 29)
		Me.lblCmpPayCode.TabIndex = 42
		Me.lblCmpPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpPayCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpPayCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpPayCode.Enabled = True
		Me.lblCmpPayCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpPayCode.UseMnemonic = True
		Me.lblCmpPayCode.Visible = True
		Me.lblCmpPayCode.AutoSize = False
		Me.lblCmpPayCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpPayCode.Name = "lblCmpPayCode"
		Me.lblCmpRetainAC.Text = "CMPRETAINAC"
		Me.lblCmpRetainAC.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpRetainAC.Location = New System.Drawing.Point(8, 53)
		Me.lblCmpRetainAC.TabIndex = 43
		Me.lblCmpRetainAC.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpRetainAC.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpRetainAC.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpRetainAC.Enabled = True
		Me.lblCmpRetainAC.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpRetainAC.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpRetainAC.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpRetainAC.UseMnemonic = True
		Me.lblCmpRetainAC.Visible = True
		Me.lblCmpRetainAC.AutoSize = False
		Me.lblCmpRetainAC.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpRetainAC.Name = "lblCmpRetainAC"
		Me.lblCmpExgMLCode.Text = "CMPEXGMLCODE"
		Me.lblCmpExgMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpExgMLCode.Location = New System.Drawing.Point(8, 77)
		Me.lblCmpExgMLCode.TabIndex = 44
		Me.lblCmpExgMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpExgMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpExgMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpExgMLCode.Enabled = True
		Me.lblCmpExgMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpExgMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpExgMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpExgMLCode.UseMnemonic = True
		Me.lblCmpExgMLCode.Visible = True
		Me.lblCmpExgMLCode.AutoSize = False
		Me.lblCmpExgMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpExgMLCode.Name = "lblCmpExgMLCode"
		Me.lblCmpTiMLCode.Text = "CMPTIMLCODE"
		Me.lblCmpTiMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpTiMLCode.Location = New System.Drawing.Point(8, 101)
		Me.lblCmpTiMLCode.TabIndex = 45
		Me.lblCmpTiMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpTiMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpTiMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpTiMLCode.Enabled = True
		Me.lblCmpTiMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpTiMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpTiMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpTiMLCode.UseMnemonic = True
		Me.lblCmpTiMLCode.Visible = True
		Me.lblCmpTiMLCode.AutoSize = False
		Me.lblCmpTiMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpTiMLCode.Name = "lblCmpTiMLCode"
		Me.lblCmpCurr.Text = "CMPCURR"
		Me.lblCmpCurr.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpCurr.Location = New System.Drawing.Point(304, 29)
		Me.lblCmpCurr.TabIndex = 46
		Me.lblCmpCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpCurr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpCurr.Enabled = True
		Me.lblCmpCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpCurr.UseMnemonic = True
		Me.lblCmpCurr.Visible = True
		Me.lblCmpCurr.AutoSize = False
		Me.lblCmpCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpCurr.Name = "lblCmpCurr"
		Me.lblCmpSupMLCode.Text = "CMPSUPMLCODE"
		Me.lblCmpSupMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpSupMLCode.Location = New System.Drawing.Point(304, 149)
		Me.lblCmpSupMLCode.TabIndex = 47
		Me.lblCmpSupMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpSupMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpSupMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpSupMLCode.Enabled = True
		Me.lblCmpSupMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpSupMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpSupMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpSupMLCode.UseMnemonic = True
		Me.lblCmpSupMLCode.Visible = True
		Me.lblCmpSupMLCode.AutoSize = False
		Me.lblCmpSupMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpSupMLCode.Name = "lblCmpSupMLCode"
		Me.lblCmpExlMLCode.Text = "CMPEXLMLCODE"
		Me.lblCmpExlMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpExlMLCode.Location = New System.Drawing.Point(304, 77)
		Me.lblCmpExlMLCode.TabIndex = 48
		Me.lblCmpExlMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpExlMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpExlMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpExlMLCode.Enabled = True
		Me.lblCmpExlMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpExlMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpExlMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpExlMLCode.UseMnemonic = True
		Me.lblCmpExlMLCode.Visible = True
		Me.lblCmpExlMLCode.AutoSize = False
		Me.lblCmpExlMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpExlMLCode.Name = "lblCmpExlMLCode"
		Me.lblCmpTeMLCode.Text = "CMPTEMLCODE"
		Me.lblCmpTeMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpTeMLCode.Location = New System.Drawing.Point(304, 101)
		Me.lblCmpTeMLCode.TabIndex = 49
		Me.lblCmpTeMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpTeMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpTeMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpTeMLCode.Enabled = True
		Me.lblCmpTeMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpTeMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpTeMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpTeMLCode.UseMnemonic = True
		Me.lblCmpTeMLCode.Visible = True
		Me.lblCmpTeMLCode.AutoSize = False
		Me.lblCmpTeMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpTeMLCode.Name = "lblCmpTeMLCode"
		Me.lblCmpSamMLCode.Text = "CMPSAMMLCODE"
		Me.lblCmpSamMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpSamMLCode.Location = New System.Drawing.Point(304, 125)
		Me.lblCmpSamMLCode.TabIndex = 59
		Me.lblCmpSamMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpSamMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpSamMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpSamMLCode.Enabled = True
		Me.lblCmpSamMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpSamMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpSamMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpSamMLCode.UseMnemonic = True
		Me.lblCmpSamMLCode.Visible = True
		Me.lblCmpSamMLCode.AutoSize = False
		Me.lblCmpSamMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpSamMLCode.Name = "lblCmpSamMLCode"
		Me.lblCmpDamMLCode.Text = "CMPDAMMLCODE"
		Me.lblCmpDamMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpDamMLCode.Location = New System.Drawing.Point(8, 125)
		Me.lblCmpDamMLCode.TabIndex = 60
		Me.lblCmpDamMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpDamMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpDamMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpDamMLCode.Enabled = True
		Me.lblCmpDamMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpDamMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpDamMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpDamMLCode.UseMnemonic = True
		Me.lblCmpDamMLCode.Visible = True
		Me.lblCmpDamMLCode.AutoSize = False
		Me.lblCmpDamMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpDamMLCode.Name = "lblCmpDamMLCode"
		Me.lblCmpAdjMLCode.Text = "CMPADJMLCODE"
		Me.lblCmpAdjMLCode.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpAdjMLCode.Location = New System.Drawing.Point(8, 149)
		Me.lblCmpAdjMLCode.TabIndex = 61
		Me.lblCmpAdjMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpAdjMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpAdjMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpAdjMLCode.Enabled = True
		Me.lblCmpAdjMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpAdjMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpAdjMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpAdjMLCode.UseMnemonic = True
		Me.lblCmpAdjMLCode.Visible = True
		Me.lblCmpAdjMLCode.AutoSize = False
		Me.lblCmpAdjMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpAdjMLCode.Name = "lblCmpAdjMLCode"
		Me.lblCmpCurrEarn.Text = "CMPRETAINAC"
		Me.lblCmpCurrEarn.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpCurrEarn.Location = New System.Drawing.Point(304, 53)
		Me.lblCmpCurrEarn.TabIndex = 62
		Me.lblCmpCurrEarn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpCurrEarn.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpCurrEarn.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpCurrEarn.Enabled = True
		Me.lblCmpCurrEarn.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpCurrEarn.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpCurrEarn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpCurrEarn.UseMnemonic = True
		Me.lblCmpCurrEarn.Visible = True
		Me.lblCmpCurrEarn.AutoSize = False
		Me.lblCmpCurrEarn.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpCurrEarn.Name = "lblCmpCurrEarn"
		Me.cboCmpPayCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpPayCode.Location = New System.Drawing.Point(184, 24)
		Me.cboCmpPayCode.TabIndex = 13
		Me.cboCmpPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpPayCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpPayCode.CausesValidation = True
		Me.cboCmpPayCode.Enabled = True
		Me.cboCmpPayCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpPayCode.IntegralHeight = True
		Me.cboCmpPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpPayCode.Sorted = False
		Me.cboCmpPayCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpPayCode.TabStop = True
		Me.cboCmpPayCode.Visible = True
		Me.cboCmpPayCode.Name = "cboCmpPayCode"
		Me.cboCmpRetainAC.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpRetainAC.Location = New System.Drawing.Point(184, 48)
		Me.cboCmpRetainAC.TabIndex = 15
		Me.cboCmpRetainAC.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpRetainAC.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpRetainAC.CausesValidation = True
		Me.cboCmpRetainAC.Enabled = True
		Me.cboCmpRetainAC.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpRetainAC.IntegralHeight = True
		Me.cboCmpRetainAC.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpRetainAC.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpRetainAC.Sorted = False
		Me.cboCmpRetainAC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpRetainAC.TabStop = True
		Me.cboCmpRetainAC.Visible = True
		Me.cboCmpRetainAC.Name = "cboCmpRetainAC"
		Me.cboCmpExgMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpExgMLCode.Location = New System.Drawing.Point(184, 72)
		Me.cboCmpExgMLCode.TabIndex = 17
		Me.cboCmpExgMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpExgMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpExgMLCode.CausesValidation = True
		Me.cboCmpExgMLCode.Enabled = True
		Me.cboCmpExgMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpExgMLCode.IntegralHeight = True
		Me.cboCmpExgMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpExgMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpExgMLCode.Sorted = False
		Me.cboCmpExgMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpExgMLCode.TabStop = True
		Me.cboCmpExgMLCode.Visible = True
		Me.cboCmpExgMLCode.Name = "cboCmpExgMLCode"
		Me.cboCmpTiMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpTiMLCode.Location = New System.Drawing.Point(184, 96)
		Me.cboCmpTiMLCode.TabIndex = 19
		Me.cboCmpTiMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpTiMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpTiMLCode.CausesValidation = True
		Me.cboCmpTiMLCode.Enabled = True
		Me.cboCmpTiMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpTiMLCode.IntegralHeight = True
		Me.cboCmpTiMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpTiMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpTiMLCode.Sorted = False
		Me.cboCmpTiMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpTiMLCode.TabStop = True
		Me.cboCmpTiMLCode.Visible = True
		Me.cboCmpTiMLCode.Name = "cboCmpTiMLCode"
		Me.cboCmpCurr.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpCurr.Location = New System.Drawing.Point(512, 24)
		Me.cboCmpCurr.TabIndex = 14
		Me.cboCmpCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpCurr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpCurr.CausesValidation = True
		Me.cboCmpCurr.Enabled = True
		Me.cboCmpCurr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpCurr.IntegralHeight = True
		Me.cboCmpCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpCurr.Sorted = False
		Me.cboCmpCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpCurr.TabStop = True
		Me.cboCmpCurr.Visible = True
		Me.cboCmpCurr.Name = "cboCmpCurr"
		Me.cboCmpSupMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpSupMLCode.Location = New System.Drawing.Point(512, 144)
		Me.cboCmpSupMLCode.TabIndex = 24
		Me.cboCmpSupMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpSupMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpSupMLCode.CausesValidation = True
		Me.cboCmpSupMLCode.Enabled = True
		Me.cboCmpSupMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpSupMLCode.IntegralHeight = True
		Me.cboCmpSupMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpSupMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpSupMLCode.Sorted = False
		Me.cboCmpSupMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpSupMLCode.TabStop = True
		Me.cboCmpSupMLCode.Visible = True
		Me.cboCmpSupMLCode.Name = "cboCmpSupMLCode"
		Me.cboCmpExlMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpExlMLCode.Location = New System.Drawing.Point(512, 72)
		Me.cboCmpExlMLCode.TabIndex = 18
		Me.cboCmpExlMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpExlMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpExlMLCode.CausesValidation = True
		Me.cboCmpExlMLCode.Enabled = True
		Me.cboCmpExlMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpExlMLCode.IntegralHeight = True
		Me.cboCmpExlMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpExlMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpExlMLCode.Sorted = False
		Me.cboCmpExlMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpExlMLCode.TabStop = True
		Me.cboCmpExlMLCode.Visible = True
		Me.cboCmpExlMLCode.Name = "cboCmpExlMLCode"
		Me.cboCmpTeMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpTeMLCode.Location = New System.Drawing.Point(512, 96)
		Me.cboCmpTeMLCode.TabIndex = 20
		Me.cboCmpTeMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpTeMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpTeMLCode.CausesValidation = True
		Me.cboCmpTeMLCode.Enabled = True
		Me.cboCmpTeMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpTeMLCode.IntegralHeight = True
		Me.cboCmpTeMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpTeMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpTeMLCode.Sorted = False
		Me.cboCmpTeMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpTeMLCode.TabStop = True
		Me.cboCmpTeMLCode.Visible = True
		Me.cboCmpTeMLCode.Name = "cboCmpTeMLCode"
		Me.cboCmpSamMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpSamMLCode.Location = New System.Drawing.Point(512, 120)
		Me.cboCmpSamMLCode.TabIndex = 22
		Me.cboCmpSamMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpSamMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpSamMLCode.CausesValidation = True
		Me.cboCmpSamMLCode.Enabled = True
		Me.cboCmpSamMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpSamMLCode.IntegralHeight = True
		Me.cboCmpSamMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpSamMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpSamMLCode.Sorted = False
		Me.cboCmpSamMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpSamMLCode.TabStop = True
		Me.cboCmpSamMLCode.Visible = True
		Me.cboCmpSamMLCode.Name = "cboCmpSamMLCode"
		Me.cboCmpDamMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpDamMLCode.Location = New System.Drawing.Point(184, 120)
		Me.cboCmpDamMLCode.TabIndex = 21
		Me.cboCmpDamMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpDamMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpDamMLCode.CausesValidation = True
		Me.cboCmpDamMLCode.Enabled = True
		Me.cboCmpDamMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpDamMLCode.IntegralHeight = True
		Me.cboCmpDamMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpDamMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpDamMLCode.Sorted = False
		Me.cboCmpDamMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpDamMLCode.TabStop = True
		Me.cboCmpDamMLCode.Visible = True
		Me.cboCmpDamMLCode.Name = "cboCmpDamMLCode"
		Me.cboCmpAdjMLCode.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpAdjMLCode.Location = New System.Drawing.Point(184, 144)
		Me.cboCmpAdjMLCode.TabIndex = 23
		Me.cboCmpAdjMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpAdjMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpAdjMLCode.CausesValidation = True
		Me.cboCmpAdjMLCode.Enabled = True
		Me.cboCmpAdjMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpAdjMLCode.IntegralHeight = True
		Me.cboCmpAdjMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpAdjMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpAdjMLCode.Sorted = False
		Me.cboCmpAdjMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpAdjMLCode.TabStop = True
		Me.cboCmpAdjMLCode.Visible = True
		Me.cboCmpAdjMLCode.Name = "cboCmpAdjMLCode"
		Me.cboCmpCurrEarn.Size = New System.Drawing.Size(102, 20)
		Me.cboCmpCurrEarn.Location = New System.Drawing.Point(512, 48)
		Me.cboCmpCurrEarn.TabIndex = 16
		Me.cboCmpCurrEarn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCmpCurrEarn.BackColor = System.Drawing.SystemColors.Window
		Me.cboCmpCurrEarn.CausesValidation = True
		Me.cboCmpCurrEarn.Enabled = True
		Me.cboCmpCurrEarn.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCmpCurrEarn.IntegralHeight = True
		Me.cboCmpCurrEarn.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCmpCurrEarn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCmpCurrEarn.Sorted = False
		Me.cboCmpCurrEarn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCmpCurrEarn.TabStop = True
		Me.cboCmpCurrEarn.Visible = True
		Me.cboCmpCurrEarn.Name = "cboCmpCurrEarn"
		Me._tabDetailInfo_TabPage3.Text = "Bank Info"
		Me.txtCmpBankAC.AutoSize = False
		Me.txtCmpBankAC.Enabled = False
		Me.txtCmpBankAC.Size = New System.Drawing.Size(499, 20)
		Me.txtCmpBankAC.Location = New System.Drawing.Point(96, 24)
		Me.txtCmpBankAC.TabIndex = 25
		Me.txtCmpBankAC.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpBankAC.AcceptsReturn = True
		Me.txtCmpBankAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpBankAC.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpBankAC.CausesValidation = True
		Me.txtCmpBankAC.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpBankAC.HideSelection = True
		Me.txtCmpBankAC.ReadOnly = False
		Me.txtCmpBankAC.Maxlength = 0
		Me.txtCmpBankAC.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpBankAC.MultiLine = False
		Me.txtCmpBankAC.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpBankAC.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpBankAC.TabStop = True
		Me.txtCmpBankAC.Visible = True
		Me.txtCmpBankAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpBankAC.Name = "txtCmpBankAC"
		Me.txtCmpBankACName.AutoSize = False
		Me.txtCmpBankACName.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCmpBankACName.Enabled = False
		Me.txtCmpBankACName.Size = New System.Drawing.Size(499, 20)
		Me.txtCmpBankACName.Location = New System.Drawing.Point(96, 48)
		Me.txtCmpBankACName.TabIndex = 26
		Me.txtCmpBankACName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpBankACName.AcceptsReturn = True
		Me.txtCmpBankACName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpBankACName.CausesValidation = True
		Me.txtCmpBankACName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpBankACName.HideSelection = True
		Me.txtCmpBankACName.ReadOnly = False
		Me.txtCmpBankACName.Maxlength = 0
		Me.txtCmpBankACName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpBankACName.MultiLine = False
		Me.txtCmpBankACName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpBankACName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpBankACName.TabStop = True
		Me.txtCmpBankACName.Visible = True
		Me.txtCmpBankACName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpBankACName.Name = "txtCmpBankACName"
		Me.lblCmpBankAC.Text = "CMPBANKAC"
		Me.lblCmpBankAC.Size = New System.Drawing.Size(81, 17)
		Me.lblCmpBankAC.Location = New System.Drawing.Point(16, 28)
		Me.lblCmpBankAC.TabIndex = 41
		Me.lblCmpBankAC.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpBankAC.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpBankAC.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpBankAC.Enabled = True
		Me.lblCmpBankAC.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpBankAC.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpBankAC.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpBankAC.UseMnemonic = True
		Me.lblCmpBankAC.Visible = True
		Me.lblCmpBankAC.AutoSize = False
		Me.lblCmpBankAC.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpBankAC.Name = "lblCmpBankAC"
		Me.lblCmpBankACName.Text = "CMPBANKACNAME"
		Me.lblCmpBankACName.Size = New System.Drawing.Size(92, 16)
		Me.lblCmpBankACName.Location = New System.Drawing.Point(16, 52)
		Me.lblCmpBankACName.TabIndex = 40
		Me.lblCmpBankACName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpBankACName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpBankACName.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpBankACName.Enabled = True
		Me.lblCmpBankACName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpBankACName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpBankACName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpBankACName.UseMnemonic = True
		Me.lblCmpBankACName.Visible = True
		Me.lblCmpBankACName.AutoSize = False
		Me.lblCmpBankACName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpBankACName.Name = "lblCmpBankACName"
		Me._tabDetailInfo_TabPage4.Text = "Remark"
		Me.txtCmpRemark.AutoSize = False
		Me.txtCmpRemark.Enabled = False
		Me.txtCmpRemark.Size = New System.Drawing.Size(511, 116)
		Me.txtCmpRemark.Location = New System.Drawing.Point(80, 24)
		Me.txtCmpRemark.MultiLine = True
		Me.txtCmpRemark.TabIndex = 27
		Me.txtCmpRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpRemark.AcceptsReturn = True
		Me.txtCmpRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpRemark.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpRemark.CausesValidation = True
		Me.txtCmpRemark.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpRemark.HideSelection = True
		Me.txtCmpRemark.ReadOnly = False
		Me.txtCmpRemark.Maxlength = 0
		Me.txtCmpRemark.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpRemark.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpRemark.TabStop = True
		Me.txtCmpRemark.Visible = True
		Me.txtCmpRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpRemark.Name = "txtCmpRemark"
		Me.lblCmpRemark.Text = "CMPREMARK"
		Me.lblCmpRemark.Size = New System.Drawing.Size(60, 16)
		Me.lblCmpRemark.Location = New System.Drawing.Point(8, 24)
		Me.lblCmpRemark.TabIndex = 56
		Me.lblCmpRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpRemark.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpRemark.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpRemark.Enabled = True
		Me.lblCmpRemark.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpRemark.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpRemark.UseMnemonic = True
		Me.lblCmpRemark.Visible = True
		Me.lblCmpRemark.AutoSize = False
		Me.lblCmpRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpRemark.Name = "lblCmpRemark"
		Me.txtCmpCode.AutoSize = False
		Me.txtCmpCode.Enabled = False
		Me.txtCmpCode.Size = New System.Drawing.Size(134, 20)
		Me.txtCmpCode.Location = New System.Drawing.Point(160, 24)
		Me.txtCmpCode.TabIndex = 28
		Me.txtCmpCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpCode.AcceptsReturn = True
		Me.txtCmpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpCode.CausesValidation = True
		Me.txtCmpCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpCode.HideSelection = True
		Me.txtCmpCode.ReadOnly = False
		Me.txtCmpCode.Maxlength = 0
		Me.txtCmpCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpCode.MultiLine = False
		Me.txtCmpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpCode.TabStop = True
		Me.txtCmpCode.Visible = True
		Me.txtCmpCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpCode.Name = "txtCmpCode"
		Me.txtCmpChiName.AutoSize = False
		Me.txtCmpChiName.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCmpChiName.Enabled = False
		Me.txtCmpChiName.Size = New System.Drawing.Size(473, 20)
		Me.txtCmpChiName.Location = New System.Drawing.Point(160, 72)
		Me.txtCmpChiName.TabIndex = 2
		Me.txtCmpChiName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpChiName.AcceptsReturn = True
		Me.txtCmpChiName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpChiName.CausesValidation = True
		Me.txtCmpChiName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpChiName.HideSelection = True
		Me.txtCmpChiName.ReadOnly = False
		Me.txtCmpChiName.Maxlength = 0
		Me.txtCmpChiName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpChiName.MultiLine = False
		Me.txtCmpChiName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpChiName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpChiName.TabStop = True
		Me.txtCmpChiName.Visible = True
		Me.txtCmpChiName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpChiName.Name = "txtCmpChiName"
		Me.txtCmpEngName.AutoSize = False
		Me.txtCmpEngName.Enabled = False
		Me.txtCmpEngName.Size = New System.Drawing.Size(472, 20)
		Me.txtCmpEngName.Location = New System.Drawing.Point(160, 48)
		Me.txtCmpEngName.TabIndex = 1
		Me.txtCmpEngName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCmpEngName.AcceptsReturn = True
		Me.txtCmpEngName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCmpEngName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCmpEngName.CausesValidation = True
		Me.txtCmpEngName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCmpEngName.HideSelection = True
		Me.txtCmpEngName.ReadOnly = False
		Me.txtCmpEngName.Maxlength = 0
		Me.txtCmpEngName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCmpEngName.MultiLine = False
		Me.txtCmpEngName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCmpEngName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCmpEngName.TabStop = True
		Me.txtCmpEngName.Visible = True
		Me.txtCmpEngName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCmpEngName.Name = "txtCmpEngName"
		Me.lblCmpLastUpd.Text = "最後修改人 :"
		Me.lblCmpLastUpd.Size = New System.Drawing.Size(164, 16)
		Me.lblCmpLastUpd.Location = New System.Drawing.Point(8, 347)
		Me.lblCmpLastUpd.TabIndex = 37
		Me.lblCmpLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpLastUpd.Enabled = True
		Me.lblCmpLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpLastUpd.UseMnemonic = True
		Me.lblCmpLastUpd.Visible = True
		Me.lblCmpLastUpd.AutoSize = False
		Me.lblCmpLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpLastUpd.Name = "lblCmpLastUpd"
		Me.lblCmpLastUpdDate.Text = "最後修改日期 :"
		Me.lblCmpLastUpdDate.Size = New System.Drawing.Size(172, 16)
		Me.lblCmpLastUpdDate.Location = New System.Drawing.Point(304, 347)
		Me.lblCmpLastUpdDate.TabIndex = 36
		Me.lblCmpLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpLastUpdDate.Enabled = True
		Me.lblCmpLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpLastUpdDate.UseMnemonic = True
		Me.lblCmpLastUpdDate.Visible = True
		Me.lblCmpLastUpdDate.AutoSize = False
		Me.lblCmpLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpLastUpdDate.Name = "lblCmpLastUpdDate"
		Me.lblDspCmpLastUpd.Size = New System.Drawing.Size(95, 20)
		Me.lblDspCmpLastUpd.Location = New System.Drawing.Point(200, 344)
		Me.lblDspCmpLastUpd.TabIndex = 35
		Me.lblDspCmpLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCmpLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCmpLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCmpLastUpd.Enabled = True
		Me.lblDspCmpLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCmpLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCmpLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCmpLastUpd.UseMnemonic = True
		Me.lblDspCmpLastUpd.Visible = True
		Me.lblDspCmpLastUpd.AutoSize = False
		Me.lblDspCmpLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCmpLastUpd.Name = "lblDspCmpLastUpd"
		Me.lblDspCmpLastUpdDate.Size = New System.Drawing.Size(103, 20)
		Me.lblDspCmpLastUpdDate.Location = New System.Drawing.Point(480, 344)
		Me.lblDspCmpLastUpdDate.TabIndex = 34
		Me.lblDspCmpLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCmpLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCmpLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCmpLastUpdDate.Enabled = True
		Me.lblDspCmpLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCmpLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCmpLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCmpLastUpdDate.UseMnemonic = True
		Me.lblDspCmpLastUpdDate.Visible = True
		Me.lblDspCmpLastUpdDate.AutoSize = False
		Me.lblDspCmpLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCmpLastUpdDate.Name = "lblDspCmpLastUpdDate"
		Me.lblCmpCode.Text = "CMPCODE"
		Me.lblCmpCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblCmpCode.Size = New System.Drawing.Size(148, 16)
		Me.lblCmpCode.Location = New System.Drawing.Point(8, 28)
		Me.lblCmpCode.TabIndex = 33
		Me.lblCmpCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpCode.Enabled = True
		Me.lblCmpCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpCode.UseMnemonic = True
		Me.lblCmpCode.Visible = True
		Me.lblCmpCode.AutoSize = False
		Me.lblCmpCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpCode.Name = "lblCmpCode"
		Me.lblCmpChiName.Text = "CMPCHINAME"
		Me.lblCmpChiName.Size = New System.Drawing.Size(148, 16)
		Me.lblCmpChiName.Location = New System.Drawing.Point(8, 76)
		Me.lblCmpChiName.TabIndex = 32
		Me.lblCmpChiName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpChiName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpChiName.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpChiName.Enabled = True
		Me.lblCmpChiName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpChiName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpChiName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpChiName.UseMnemonic = True
		Me.lblCmpChiName.Visible = True
		Me.lblCmpChiName.AutoSize = False
		Me.lblCmpChiName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpChiName.Name = "lblCmpChiName"
		Me.lblCmpEngName.Text = "CMPENGNAME"
		Me.lblCmpEngName.Size = New System.Drawing.Size(148, 17)
		Me.lblCmpEngName.Location = New System.Drawing.Point(8, 52)
		Me.lblCmpEngName.TabIndex = 31
		Me.lblCmpEngName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCmpEngName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCmpEngName.BackColor = System.Drawing.SystemColors.Control
		Me.lblCmpEngName.Enabled = True
		Me.lblCmpEngName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCmpEngName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCmpEngName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCmpEngName.UseMnemonic = True
		Me.lblCmpEngName.Visible = True
		Me.lblCmpEngName.AutoSize = False
		Me.lblCmpEngName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCmpEngName.Name = "lblCmpEngName"
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
		Me.Controls.Add(cboCmpCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(tabDetailInfo)
		Me.fraDetailInfo.Controls.Add(txtCmpCode)
		Me.fraDetailInfo.Controls.Add(txtCmpChiName)
		Me.fraDetailInfo.Controls.Add(txtCmpEngName)
		Me.fraDetailInfo.Controls.Add(lblCmpLastUpd)
		Me.fraDetailInfo.Controls.Add(lblCmpLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspCmpLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspCmpLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblCmpCode)
		Me.fraDetailInfo.Controls.Add(lblCmpChiName)
		Me.fraDetailInfo.Controls.Add(lblCmpEngName)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage2)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage3)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage4)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtCmpRptEngAdd)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtCmpRptChiAdd)
		Me._tabDetailInfo_TabPage0.Controls.Add(picCmpAdr)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblCmpRptEngAdd)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblCmpRptChiAdd)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblCmpAdr)
		Me.picCmpAdr.Controls.Add(_txtCmpAddress_1)
		Me.picCmpAdr.Controls.Add(_txtCmpAddress_2)
		Me.picCmpAdr.Controls.Add(_txtCmpAddress_3)
		Me.picCmpAdr.Controls.Add(_txtCmpAddress_4)
		Me._tabDetailInfo_TabPage1.Controls.Add(txtCmpFax)
		Me._tabDetailInfo_TabPage1.Controls.Add(txtCmpTel)
		Me._tabDetailInfo_TabPage1.Controls.Add(txtCmpEmail)
		Me._tabDetailInfo_TabPage1.Controls.Add(txtCmpWebSite)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblCmpFax)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblCmpTel)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblCmpEmail)
		Me._tabDetailInfo_TabPage1.Controls.Add(lblCmpWebSite)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpPayCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpRetainAC)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpExgMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpTiMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpCurr)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpSupMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpExlMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpTeMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpSamMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpDamMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpAdjMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCmpCurrEarn)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpPayCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpRetainAC)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpExgMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpTiMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpCurr)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpSupMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpExlMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpTeMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpSamMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpDamMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpAdjMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCmpCurrEarn)
		Me._tabDetailInfo_TabPage3.Controls.Add(txtCmpBankAC)
		Me._tabDetailInfo_TabPage3.Controls.Add(txtCmpBankACName)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblCmpBankAC)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblCmpBankACName)
		Me._tabDetailInfo_TabPage4.Controls.Add(txtCmpRemark)
		Me._tabDetailInfo_TabPage4.Controls.Add(lblCmpRemark)
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
		Me.txtCmpAddress.SetIndex(_txtCmpAddress_1, CType(1, Short))
		Me.txtCmpAddress.SetIndex(_txtCmpAddress_2, CType(2, Short))
		Me.txtCmpAddress.SetIndex(_txtCmpAddress_3, CType(3, Short))
		Me.txtCmpAddress.SetIndex(_txtCmpAddress_4, CType(4, Short))
		CType(Me.txtCmpAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me.picCmpAdr.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me._tabDetailInfo_TabPage2.ResumeLayout(False)
		Me._tabDetailInfo_TabPage3.ResumeLayout(False)
		Me._tabDetailInfo_TabPage4.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class