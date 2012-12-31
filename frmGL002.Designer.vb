<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGL002
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
	Public WithEvents cmdSelectAll As System.Windows.Forms.Button
	Public WithEvents cmdUnSelect As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdDelete As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cboBankAcc As System.Windows.Forms.ComboBox
	Public WithEvents _optBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents medDocFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents medDocTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medChqDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblDspBankAcc As System.Windows.Forms.Label
	Public WithEvents lblChqDate As System.Windows.Forms.Label
	Public WithEvents lblDocTo As System.Windows.Forms.Label
	Public WithEvents lblDocFr As System.Windows.Forms.Label
	Public WithEvents lblBankAcc As System.Windows.Forms.Label
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents picStatus As System.Windows.Forms.PictureBox
	Public cdFontFont As System.Windows.Forms.FontDialog
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lstData As System.Windows.Forms.ListView
	Public WithEvents optBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGL002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdSelectAll = New System.Windows.Forms.Button
		Me.cmdUnSelect = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdDelete = New System.Windows.Forms.Button
		Me.cboBankAcc = New System.Windows.Forms.ComboBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me._optBy_1 = New System.Windows.Forms.RadioButton
		Me._optBy_0 = New System.Windows.Forms.RadioButton
		Me.medDocFr = New System.Windows.Forms.MaskedTextBox
		Me.medDocTo = New System.Windows.Forms.MaskedTextBox
		Me.medChqDate = New System.Windows.Forms.MaskedTextBox
		Me.lblDspBankAcc = New System.Windows.Forms.Label
		Me.lblChqDate = New System.Windows.Forms.Label
		Me.lblDocTo = New System.Windows.Forms.Label
		Me.lblDocFr = New System.Windows.Forms.Label
		Me.lblBankAcc = New System.Windows.Forms.Label
		Me.picStatus = New System.Windows.Forms.PictureBox
		Me.cdFontFont = New System.Windows.Forms.FontDialog
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me.lstData = New System.Windows.Forms.ListView
		Me.optBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraSelect.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Stock Transfer"
		Me.ClientSize = New System.Drawing.Size(794, 571)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmGL002.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "frmGL002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(744, 24)
		Me.tblCommon.TabIndex = 11
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.Frame2.Size = New System.Drawing.Size(121, 121)
		Me.Frame2.Location = New System.Drawing.Point(672, 288)
		Me.Frame2.TabIndex = 16
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cmdSelectAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSelectAll.Text = "Select All"
		Me.cmdSelectAll.Size = New System.Drawing.Size(105, 49)
		Me.cmdSelectAll.Location = New System.Drawing.Point(8, 16)
		Me.cmdSelectAll.Image = CType(resources.GetObject("cmdSelectAll.Image"), System.Drawing.Image)
		Me.cmdSelectAll.TabIndex = 8
		Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectAll.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSelectAll.CausesValidation = True
		Me.cmdSelectAll.Enabled = True
		Me.cmdSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSelectAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSelectAll.TabStop = True
		Me.cmdSelectAll.Name = "cmdSelectAll"
		Me.cmdUnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdUnSelect.Text = "Unselect All"
		Me.cmdUnSelect.Size = New System.Drawing.Size(105, 49)
		Me.cmdUnSelect.Location = New System.Drawing.Point(8, 64)
		Me.cmdUnSelect.Image = CType(resources.GetObject("cmdUnSelect.Image"), System.Drawing.Image)
		Me.cmdUnSelect.TabIndex = 9
		Me.cmdUnSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUnSelect.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUnSelect.CausesValidation = True
		Me.cmdUnSelect.Enabled = True
		Me.cmdUnSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUnSelect.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUnSelect.TabStop = True
		Me.cmdUnSelect.Name = "cmdUnSelect"
		Me.Frame1.Size = New System.Drawing.Size(121, 73)
		Me.Frame1.Location = New System.Drawing.Point(672, 184)
		Me.Frame1.TabIndex = 15
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdDelete.Text = "Delete"
		Me.cmdDelete.Size = New System.Drawing.Size(105, 49)
		Me.cmdDelete.Location = New System.Drawing.Point(8, 16)
		Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
		Me.cmdDelete.TabIndex = 7
		Me.cmdDelete.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDelete.CausesValidation = True
		Me.cmdDelete.Enabled = True
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDelete.TabStop = True
		Me.cmdDelete.Name = "cmdDelete"
		Me.cboBankAcc.Size = New System.Drawing.Size(121, 20)
		Me.cboBankAcc.Location = New System.Drawing.Point(168, 56)
		Me.cboBankAcc.TabIndex = 0
		Me.cboBankAcc.Text = "Combo1"
		Me.cboBankAcc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBankAcc.BackColor = System.Drawing.SystemColors.Window
		Me.cboBankAcc.CausesValidation = True
		Me.cboBankAcc.Enabled = True
		Me.cboBankAcc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboBankAcc.IntegralHeight = True
		Me.cboBankAcc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboBankAcc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboBankAcc.Sorted = False
		Me.cboBankAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboBankAcc.TabStop = True
		Me.cboBankAcc.Visible = True
		Me.cboBankAcc.Name = "cboBankAcc"
		Me.fraSelect.Text = "Selection Criteria"
		Me.fraSelect.Size = New System.Drawing.Size(769, 137)
		Me.fraSelect.Location = New System.Drawing.Point(8, 32)
		Me.fraSelect.TabIndex = 13
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me.Frame3.Size = New System.Drawing.Size(444, 41)
		Me.Frame3.Location = New System.Drawing.Point(32, 64)
		Me.Frame3.TabIndex = 19
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me._optBy_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.Text = "BARCODE"
		Me._optBy_1.Size = New System.Drawing.Size(201, 17)
		Me._optBy_1.Location = New System.Drawing.Point(232, 16)
		Me._optBy_1.TabIndex = 4
		Me._optBy_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBy_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.BackColor = System.Drawing.SystemColors.Control
		Me._optBy_1.CausesValidation = True
		Me._optBy_1.Enabled = True
		Me._optBy_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBy_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBy_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBy_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optBy_1.TabStop = True
		Me._optBy_1.Checked = False
		Me._optBy_1.Visible = True
		Me._optBy_1.Name = "_optBy_1"
		Me._optBy_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_0.Text = "CALLNO"
		Me._optBy_0.Size = New System.Drawing.Size(177, 17)
		Me._optBy_0.Location = New System.Drawing.Point(24, 16)
		Me._optBy_0.TabIndex = 3
		Me._optBy_0.Checked = True
		Me._optBy_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optBy_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_0.BackColor = System.Drawing.SystemColors.Control
		Me._optBy_0.CausesValidation = True
		Me._optBy_0.Enabled = True
		Me._optBy_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optBy_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optBy_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optBy_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optBy_0.TabStop = True
		Me._optBy_0.Visible = True
		Me._optBy_0.Name = "_optBy_0"
		Me.medDocFr.AllowPromptAsInput = False
		Me.medDocFr.Size = New System.Drawing.Size(65, 19)
		Me.medDocFr.Location = New System.Drawing.Point(160, 48)
		Me.medDocFr.TabIndex = 1
		Me.medDocFr.MaxLength = 10
		Me.medDocFr.Mask = "##/##/####"
		Me.medDocFr.PromptChar = "_"
		Me.medDocFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDocFr.Name = "medDocFr"
		Me.medDocTo.AllowPromptAsInput = False
		Me.medDocTo.Size = New System.Drawing.Size(65, 19)
		Me.medDocTo.Location = New System.Drawing.Point(368, 48)
		Me.medDocTo.TabIndex = 2
		Me.medDocTo.MaxLength = 10
		Me.medDocTo.Mask = "##/##/####"
		Me.medDocTo.PromptChar = "_"
		Me.medDocTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDocTo.Name = "medDocTo"
		Me.medChqDate.AllowPromptAsInput = False
		Me.medChqDate.Size = New System.Drawing.Size(65, 19)
		Me.medChqDate.Location = New System.Drawing.Point(160, 112)
		Me.medChqDate.TabIndex = 5
		Me.medChqDate.MaxLength = 10
		Me.medChqDate.Mask = "##/##/####"
		Me.medChqDate.PromptChar = "_"
		Me.medChqDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medChqDate.Name = "medChqDate"
		Me.lblDspBankAcc.Size = New System.Drawing.Size(369, 20)
		Me.lblDspBankAcc.Location = New System.Drawing.Point(280, 24)
		Me.lblDspBankAcc.TabIndex = 21
		Me.lblDspBankAcc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspBankAcc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspBankAcc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspBankAcc.Enabled = True
		Me.lblDspBankAcc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspBankAcc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspBankAcc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspBankAcc.UseMnemonic = True
		Me.lblDspBankAcc.Visible = True
		Me.lblDspBankAcc.AutoSize = False
		Me.lblDspBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspBankAcc.Name = "lblDspBankAcc"
		Me.lblChqDate.Text = "DOCDATE"
		Me.lblChqDate.Size = New System.Drawing.Size(128, 17)
		Me.lblChqDate.Location = New System.Drawing.Point(32, 116)
		Me.lblChqDate.TabIndex = 20
		Me.lblChqDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChqDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblChqDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblChqDate.Enabled = True
		Me.lblChqDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChqDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblChqDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChqDate.UseMnemonic = True
		Me.lblChqDate.Visible = True
		Me.lblChqDate.AutoSize = False
		Me.lblChqDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChqDate.Name = "lblChqDate"
		Me.lblDocTo.Text = "DOCDATE"
		Me.lblDocTo.Size = New System.Drawing.Size(80, 17)
		Me.lblDocTo.Location = New System.Drawing.Point(288, 52)
		Me.lblDocTo.TabIndex = 18
		Me.lblDocTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocTo.Enabled = True
		Me.lblDocTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocTo.UseMnemonic = True
		Me.lblDocTo.Visible = True
		Me.lblDocTo.AutoSize = False
		Me.lblDocTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocTo.Name = "lblDocTo"
		Me.lblDocFr.Text = "DOCFR"
		Me.lblDocFr.Size = New System.Drawing.Size(128, 17)
		Me.lblDocFr.Location = New System.Drawing.Point(32, 52)
		Me.lblDocFr.TabIndex = 17
		Me.lblDocFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocFr.Enabled = True
		Me.lblDocFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocFr.UseMnemonic = True
		Me.lblDocFr.Visible = True
		Me.lblDocFr.AutoSize = False
		Me.lblDocFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocFr.Name = "lblDocFr"
		Me.lblBankAcc.Text = "BANKACC"
		Me.lblBankAcc.Size = New System.Drawing.Size(126, 15)
		Me.lblBankAcc.Location = New System.Drawing.Point(32, 26)
		Me.lblBankAcc.TabIndex = 14
		Me.lblBankAcc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBankAcc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBankAcc.BackColor = System.Drawing.SystemColors.Control
		Me.lblBankAcc.Enabled = True
		Me.lblBankAcc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBankAcc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBankAcc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBankAcc.UseMnemonic = True
		Me.lblBankAcc.Visible = True
		Me.lblBankAcc.AutoSize = False
		Me.lblBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBankAcc.Name = "lblBankAcc"
		Me.picStatus.BackColor = System.Drawing.Color.White
		Me.picStatus.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatus.Size = New System.Drawing.Size(771, 20)
		Me.picStatus.Location = New System.Drawing.Point(8, 552)
		Me.picStatus.TabIndex = 12
		Me.picStatus.TabStop = False
		Me.picStatus.Dock = System.Windows.Forms.DockStyle.None
		Me.picStatus.CausesValidation = True
		Me.picStatus.Enabled = True
		Me.picStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.picStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picStatus.Visible = True
		Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picStatus.Name = "picStatus"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.iglProcess.ImageStream = CType(resources.GetObject("iglProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.iglProcess.Images.SetKeyName(0, "")
		Me.iglProcess.Images.SetKeyName(1, "")
		Me.iglProcess.Images.SetKeyName(2, "")
		Me.iglProcess.Images.SetKeyName(3, "")
		Me.iglProcess.Images.SetKeyName(4, "")
		Me.iglProcess.Images.SetKeyName(5, "book")
		Me.iglProcess.Images.SetKeyName(6, "book1")
		Me.iglProcess.Images.SetKeyName(7, "StockIn")
		Me.iglProcess.Images.SetKeyName(8, "StockOut")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
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
		Me._tbrProcess_Button2.Name = "Go"
		Me._tbrProcess_Button2.ToolTipText = "Go (F9)"
		Me._tbrProcess_Button2.ImageIndex = 1
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Cancel"
		Me._tbrProcess_Button3.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Refresh"
		Me._tbrProcess_Button4.ImageIndex = 2
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Font"
		Me._tbrProcess_Button5.ImageIndex = 4
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Exit"
		Me._tbrProcess_Button6.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button6.ImageIndex = 3
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lstData.Size = New System.Drawing.Size(662, 374)
		Me.lstData.Location = New System.Drawing.Point(8, 176)
		Me.lstData.TabIndex = 6
		Me.lstData.View = System.Windows.Forms.View.Details
		Me.lstData.LabelWrap = True
		Me.lstData.HideSelection = True
		Me.lstData.Checkboxes = True
		Me.lstData.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstData.BackColor = System.Drawing.SystemColors.Window
		Me.lstData.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstData.LabelEdit = True
		Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstData.Name = "lstData"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cboBankAcc)
		Me.Controls.Add(fraSelect)
		Me.Controls.Add(picStatus)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lstData)
		Me.Frame2.Controls.Add(cmdSelectAll)
		Me.Frame2.Controls.Add(cmdUnSelect)
		Me.Frame1.Controls.Add(cmdDelete)
		Me.fraSelect.Controls.Add(Frame3)
		Me.fraSelect.Controls.Add(medDocFr)
		Me.fraSelect.Controls.Add(medDocTo)
		Me.fraSelect.Controls.Add(medChqDate)
		Me.fraSelect.Controls.Add(lblDspBankAcc)
		Me.fraSelect.Controls.Add(lblChqDate)
		Me.fraSelect.Controls.Add(lblDocTo)
		Me.fraSelect.Controls.Add(lblDocFr)
		Me.fraSelect.Controls.Add(lblBankAcc)
		Me.Frame3.Controls.Add(_optBy_1)
		Me.Frame3.Controls.Add(_optBy_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
		Me.optBy.SetIndex(_optBy_1, CType(1, Short))
		Me.optBy.SetIndex(_optBy_0, CType(0, Short))
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraSelect.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class