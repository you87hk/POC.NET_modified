<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSCT001
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
	Public WithEvents cboWhsCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNo As System.Windows.Forms.ComboBox
	Public WithEvents cboSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents txtRmk As System.Windows.Forms.TextBox
	Public WithEvents medDocDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblRmk As System.Windows.Forms.Label
	Public WithEvents lblDspVoucher As System.Windows.Forms.Label
	Public WithEvents lblVoucher As System.Windows.Forms.Label
	Public WithEvents lblWhsCodeFr As System.Windows.Forms.Label
	Public WithEvents lblDocDate As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	Public WithEvents lblSaleCode As System.Windows.Forms.Label
	Public WithEvents lblDspSaleDesc As System.Windows.Forms.Label
	Public WithEvents fraKey As System.Windows.Forms.GroupBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button13 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button14 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button15 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button16 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTrnQty As System.Windows.Forms.Label
	Public WithEvents lblTrnAmt As System.Windows.Forms.Label
	Public WithEvents lblDspTrnQty As System.Windows.Forms.Label
	Public WithEvents lblDspTrnAmt As System.Windows.Forms.Label
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSCT001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboWhsCodeFr = New System.Windows.Forms.ComboBox
		Me.cboDocNo = New System.Windows.Forms.ComboBox
		Me.cboSaleCode = New System.Windows.Forms.ComboBox
		Me.fraKey = New System.Windows.Forms.GroupBox
		Me.txtRmk = New System.Windows.Forms.TextBox
		Me.medDocDate = New System.Windows.Forms.MaskedTextBox
		Me.lblRmk = New System.Windows.Forms.Label
		Me.lblDspVoucher = New System.Windows.Forms.Label
		Me.lblVoucher = New System.Windows.Forms.Label
		Me.lblWhsCodeFr = New System.Windows.Forms.Label
		Me.lblDocDate = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.lblSaleCode = New System.Windows.Forms.Label
		Me.lblDspSaleDesc = New System.Windows.Forms.Label
		Me.iglProcess = New System.Windows.Forms.ImageList
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
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button13 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button14 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button15 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button16 = New System.Windows.Forms.ToolStripButton
		Me.lblTrnQty = New System.Windows.Forms.Label
		Me.lblTrnAmt = New System.Windows.Forms.Label
		Me.lblDspTrnQty = New System.Windows.Forms.Label
		Me.lblDspTrnAmt = New System.Windows.Forms.Label
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.fraKey.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "訂貨單"
		Me.ClientSize = New System.Drawing.Size(792, 597)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmSCT001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSCT001"
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
		Me.tblCommon.Size = New System.Drawing.Size(329, 138)
		Me.tblCommon.Location = New System.Drawing.Point(480, 304)
		Me.tblCommon.TabIndex = 5
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboWhsCodeFr.Size = New System.Drawing.Size(129, 20)
		Me.cboWhsCodeFr.Location = New System.Drawing.Point(120, 119)
		Me.cboWhsCodeFr.TabIndex = 3
		Me.cboWhsCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWhsCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboWhsCodeFr.CausesValidation = True
		Me.cboWhsCodeFr.Enabled = True
		Me.cboWhsCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWhsCodeFr.IntegralHeight = True
		Me.cboWhsCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWhsCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWhsCodeFr.Sorted = False
		Me.cboWhsCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWhsCodeFr.TabStop = True
		Me.cboWhsCodeFr.Visible = True
		Me.cboWhsCodeFr.Name = "cboWhsCodeFr"
		Me.cboDocNo.Size = New System.Drawing.Size(129, 20)
		Me.cboDocNo.Location = New System.Drawing.Point(120, 69)
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
		Me.cboSaleCode.Size = New System.Drawing.Size(129, 20)
		Me.cboSaleCode.Location = New System.Drawing.Point(120, 94)
		Me.cboSaleCode.TabIndex = 2
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
		Me.fraKey.Size = New System.Drawing.Size(753, 153)
		Me.fraKey.Location = New System.Drawing.Point(16, 56)
		Me.fraKey.TabIndex = 6
		Me.fraKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraKey.BackColor = System.Drawing.SystemColors.Control
		Me.fraKey.Enabled = True
		Me.fraKey.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraKey.Visible = True
		Me.fraKey.Padding = New System.Windows.Forms.Padding(0)
		Me.fraKey.Name = "fraKey"
		Me.txtRmk.AutoSize = False
		Me.txtRmk.Enabled = False
		Me.txtRmk.Size = New System.Drawing.Size(480, 20)
		Me.txtRmk.Location = New System.Drawing.Point(104, 88)
		Me.txtRmk.TabIndex = 19
		Me.txtRmk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRmk.AcceptsReturn = True
		Me.txtRmk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRmk.BackColor = System.Drawing.SystemColors.Window
		Me.txtRmk.CausesValidation = True
		Me.txtRmk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRmk.HideSelection = True
		Me.txtRmk.ReadOnly = False
		Me.txtRmk.Maxlength = 0
		Me.txtRmk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRmk.MultiLine = False
		Me.txtRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRmk.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRmk.TabStop = True
		Me.txtRmk.Visible = True
		Me.txtRmk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRmk.Name = "txtRmk"
		Me.medDocDate.AllowPromptAsInput = False
		Me.medDocDate.Size = New System.Drawing.Size(89, 19)
		Me.medDocDate.Location = New System.Drawing.Point(656, 12)
		Me.medDocDate.TabIndex = 1
		Me.medDocDate.MaxLength = 10
		Me.medDocDate.Mask = "##/##/####"
		Me.medDocDate.PromptChar = "_"
		Me.medDocDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDocDate.Name = "medDocDate"
		Me.lblRmk.Text = "RMK"
		Me.lblRmk.Size = New System.Drawing.Size(81, 17)
		Me.lblRmk.Location = New System.Drawing.Point(8, 92)
		Me.lblRmk.TabIndex = 20
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
		Me.lblDspVoucher.Size = New System.Drawing.Size(129, 20)
		Me.lblDspVoucher.Location = New System.Drawing.Point(104, 112)
		Me.lblDspVoucher.TabIndex = 18
		Me.lblDspVoucher.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspVoucher.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVoucher.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVoucher.Enabled = True
		Me.lblDspVoucher.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVoucher.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVoucher.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVoucher.UseMnemonic = True
		Me.lblDspVoucher.Visible = True
		Me.lblDspVoucher.AutoSize = False
		Me.lblDspVoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVoucher.Name = "lblDspVoucher"
		Me.lblVoucher.Text = "MLCODE"
		Me.lblVoucher.Size = New System.Drawing.Size(103, 16)
		Me.lblVoucher.Location = New System.Drawing.Point(8, 116)
		Me.lblVoucher.TabIndex = 17
		Me.lblVoucher.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVoucher.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVoucher.BackColor = System.Drawing.SystemColors.Control
		Me.lblVoucher.Enabled = True
		Me.lblVoucher.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVoucher.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVoucher.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVoucher.UseMnemonic = True
		Me.lblVoucher.Visible = True
		Me.lblVoucher.AutoSize = False
		Me.lblVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVoucher.Name = "lblVoucher"
		Me.lblWhsCodeFr.Text = "WHSFR"
		Me.lblWhsCodeFr.Size = New System.Drawing.Size(96, 17)
		Me.lblWhsCodeFr.Location = New System.Drawing.Point(8, 65)
		Me.lblWhsCodeFr.TabIndex = 16
		Me.lblWhsCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsCodeFr.Enabled = True
		Me.lblWhsCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsCodeFr.UseMnemonic = True
		Me.lblWhsCodeFr.Visible = True
		Me.lblWhsCodeFr.AutoSize = False
		Me.lblWhsCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsCodeFr.Name = "lblWhsCodeFr"
		Me.lblDocDate.Text = "DOCDATE"
		Me.lblDocDate.Size = New System.Drawing.Size(88, 17)
		Me.lblDocDate.Location = New System.Drawing.Point(576, 16)
		Me.lblDocDate.TabIndex = 10
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
		Me.lblDocNo.Text = "DOCNO"
		Me.lblDocNo.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDocNo.Size = New System.Drawing.Size(105, 17)
		Me.lblDocNo.Location = New System.Drawing.Point(8, 16)
		Me.lblDocNo.TabIndex = 9
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
		Me.lblSaleCode.Text = "SALECODE"
		Me.lblSaleCode.Size = New System.Drawing.Size(87, 16)
		Me.lblSaleCode.Location = New System.Drawing.Point(8, 40)
		Me.lblSaleCode.TabIndex = 8
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
		Me.lblDspSaleDesc.Size = New System.Drawing.Size(129, 20)
		Me.lblDspSaleDesc.Location = New System.Drawing.Point(240, 36)
		Me.lblDspSaleDesc.TabIndex = 7
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
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(769, 333)
		Me.tblDetail.Location = New System.Drawing.Point(8, 224)
		Me.tblDetail.TabIndex = 4
		Me.tblDetail.Name = "tblDetail"
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(792, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 24)
		Me.tbrProcess.TabIndex = 15
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
		Me._tbrProcess_Button8.Name = "Post"
		Me._tbrProcess_Button8.ToolTipText = "Post"
		Me._tbrProcess_Button8.ImageIndex = 1
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
		Me._tbrProcess_Button15.Visible = 0
		Me._tbrProcess_Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button16.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button16.AutoSize = False
		Me._tbrProcess_Button16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button16.Name = "Exit"
		Me._tbrProcess_Button16.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button16.ImageIndex = 8
		Me._tbrProcess_Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblTrnQty.Text = "TRNQTY"
		Me.lblTrnQty.Size = New System.Drawing.Size(100, 16)
		Me.lblTrnQty.Location = New System.Drawing.Point(40, 571)
		Me.lblTrnQty.TabIndex = 14
		Me.lblTrnQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTrnQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTrnQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblTrnQty.Enabled = True
		Me.lblTrnQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTrnQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTrnQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTrnQty.UseMnemonic = True
		Me.lblTrnQty.Visible = True
		Me.lblTrnQty.AutoSize = False
		Me.lblTrnQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTrnQty.Name = "lblTrnQty"
		Me.lblTrnAmt.Text = "TRNAMT"
		Me.lblTrnAmt.Size = New System.Drawing.Size(100, 16)
		Me.lblTrnAmt.Location = New System.Drawing.Point(480, 571)
		Me.lblTrnAmt.TabIndex = 13
		Me.lblTrnAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTrnAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTrnAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblTrnAmt.Enabled = True
		Me.lblTrnAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTrnAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTrnAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTrnAmt.UseMnemonic = True
		Me.lblTrnAmt.Visible = True
		Me.lblTrnAmt.AutoSize = False
		Me.lblTrnAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTrnAmt.Name = "lblTrnAmt"
		Me.lblDspTrnQty.Size = New System.Drawing.Size(151, 20)
		Me.lblDspTrnQty.Location = New System.Drawing.Point(144, 568)
		Me.lblDspTrnQty.TabIndex = 12
		Me.lblDspTrnQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspTrnQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspTrnQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspTrnQty.Enabled = True
		Me.lblDspTrnQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspTrnQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspTrnQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspTrnQty.UseMnemonic = True
		Me.lblDspTrnQty.Visible = True
		Me.lblDspTrnQty.AutoSize = False
		Me.lblDspTrnQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspTrnQty.Name = "lblDspTrnQty"
		Me.lblDspTrnAmt.Size = New System.Drawing.Size(151, 20)
		Me.lblDspTrnAmt.Location = New System.Drawing.Point(584, 568)
		Me.lblDspTrnAmt.TabIndex = 11
		Me.lblDspTrnAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspTrnAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspTrnAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspTrnAmt.Enabled = True
		Me.lblDspTrnAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspTrnAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspTrnAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspTrnAmt.UseMnemonic = True
		Me.lblDspTrnAmt.Visible = True
		Me.lblDspTrnAmt.AutoSize = False
		Me.lblDspTrnAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspTrnAmt.Name = "lblDspTrnAmt"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboWhsCodeFr)
		Me.Controls.Add(cboDocNo)
		Me.Controls.Add(cboSaleCode)
		Me.Controls.Add(fraKey)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTrnQty)
		Me.Controls.Add(lblTrnAmt)
		Me.Controls.Add(lblDspTrnQty)
		Me.Controls.Add(lblDspTrnAmt)
		Me.fraKey.Controls.Add(txtRmk)
		Me.fraKey.Controls.Add(medDocDate)
		Me.fraKey.Controls.Add(lblRmk)
		Me.fraKey.Controls.Add(lblDspVoucher)
		Me.fraKey.Controls.Add(lblVoucher)
		Me.fraKey.Controls.Add(lblWhsCodeFr)
		Me.fraKey.Controls.Add(lblDocDate)
		Me.fraKey.Controls.Add(lblDocNo)
		Me.fraKey.Controls.Add(lblSaleCode)
		Me.fraKey.Controls.Add(lblDspSaleDesc)
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
		Me.mnuPopUpSub.SetIndex(_mnuPopUpSub_0, CType(0, Short))
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPopUp})
		mnuPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuPopUpSub_0})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.fraKey.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class