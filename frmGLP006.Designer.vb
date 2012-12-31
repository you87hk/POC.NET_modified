<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGLP006
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
	Public WithEvents chkPgeBrk As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cboPfx As System.Windows.Forms.ComboBox
	Public WithEvents cboUsrFr As System.Windows.Forms.ComboBox
	Public WithEvents cboUsrTo As System.Windows.Forms.ComboBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents medPrdTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents medUpdTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medUpdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblPrtMrk As System.Windows.Forms.Label
	Public WithEvents lblPfx As System.Windows.Forms.Label
	Public WithEvents lblUsrFr As System.Windows.Forms.Label
	Public WithEvents lblUpdFr As System.Windows.Forms.Label
	Public WithEvents lblUsrTo As System.Windows.Forms.Label
	Public WithEvents lblUpdTo As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents lblPrdTo As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGLP006))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkPgeBrk = New System.Windows.Forms.CheckBox
		Me.cboPfx = New System.Windows.Forms.ComboBox
		Me.cboUsrFr = New System.Windows.Forms.ComboBox
		Me.cboUsrTo = New System.Windows.Forms.ComboBox
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.medPrdTo = New System.Windows.Forms.MaskedTextBox
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.medUpdTo = New System.Windows.Forms.MaskedTextBox
		Me.medUpdFr = New System.Windows.Forms.MaskedTextBox
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblPrtMrk = New System.Windows.Forms.Label
		Me.lblPfx = New System.Windows.Forms.Label
		Me.lblUsrFr = New System.Windows.Forms.Label
		Me.lblUpdFr = New System.Windows.Forms.Label
		Me.lblUsrTo = New System.Windows.Forms.Label
		Me.lblUpdTo = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.lblPrdTo = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Material Master List"
		Me.ClientSize = New System.Drawing.Size(613, 229)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.Icon = CType(resources.GetObject("frmGLP006.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmGLP006"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(520, 160)
		Me.tblCommon.TabIndex = 12
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.Frame1.Size = New System.Drawing.Size(297, 33)
		Me.Frame1.Location = New System.Drawing.Point(190, 184)
		Me.Frame1.TabIndex = 22
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.chkPgeBrk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkPgeBrk.Text = "New Page with Each Customer:"
		Me.chkPgeBrk.Size = New System.Drawing.Size(209, 12)
		Me.chkPgeBrk.Location = New System.Drawing.Point(24, 16)
		Me.chkPgeBrk.TabIndex = 23
		Me.chkPgeBrk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkPgeBrk.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkPgeBrk.BackColor = System.Drawing.SystemColors.Control
		Me.chkPgeBrk.CausesValidation = True
		Me.chkPgeBrk.Enabled = True
		Me.chkPgeBrk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkPgeBrk.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkPgeBrk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkPgeBrk.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkPgeBrk.TabStop = True
		Me.chkPgeBrk.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkPgeBrk.Visible = True
		Me.chkPgeBrk.Name = "chkPgeBrk"
		Me.cboPfx.Size = New System.Drawing.Size(121, 20)
		Me.cboPfx.Location = New System.Drawing.Point(192, 64)
		Me.cboPfx.TabIndex = 1
		Me.cboPfx.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPfx.BackColor = System.Drawing.SystemColors.Window
		Me.cboPfx.CausesValidation = True
		Me.cboPfx.Enabled = True
		Me.cboPfx.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPfx.IntegralHeight = True
		Me.cboPfx.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPfx.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPfx.Sorted = False
		Me.cboPfx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPfx.TabStop = True
		Me.cboPfx.Visible = True
		Me.cboPfx.Name = "cboPfx"
		Me.cboUsrFr.Size = New System.Drawing.Size(121, 20)
		Me.cboUsrFr.Location = New System.Drawing.Point(192, 139)
		Me.cboUsrFr.TabIndex = 6
		Me.cboUsrFr.Text = "Combo1"
		Me.cboUsrFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsrFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboUsrFr.CausesValidation = True
		Me.cboUsrFr.Enabled = True
		Me.cboUsrFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUsrFr.IntegralHeight = True
		Me.cboUsrFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUsrFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUsrFr.Sorted = False
		Me.cboUsrFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUsrFr.TabStop = True
		Me.cboUsrFr.Visible = True
		Me.cboUsrFr.Name = "cboUsrFr"
		Me.cboUsrTo.Size = New System.Drawing.Size(121, 20)
		Me.cboUsrTo.Location = New System.Drawing.Point(380, 139)
		Me.cboUsrTo.TabIndex = 7
		Me.cboUsrTo.Text = "Combo1"
		Me.cboUsrTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsrTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboUsrTo.CausesValidation = True
		Me.cboUsrTo.Enabled = True
		Me.cboUsrTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUsrTo.IntegralHeight = True
		Me.cboUsrTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUsrTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUsrTo.Sorted = False
		Me.cboUsrTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUsrTo.TabStop = True
		Me.cboUsrTo.Visible = True
		Me.cboUsrTo.Name = "cboUsrTo"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(192, 40)
		Me.txtTitle.TabIndex = 0
		Me.txtTitle.Text = "01234567890123457890"
		Me.txtTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTitle.AcceptsReturn = True
		Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtTitle.CausesValidation = True
		Me.txtTitle.Enabled = True
		Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTitle.HideSelection = True
		Me.txtTitle.ReadOnly = False
		Me.txtTitle.Maxlength = 0
		Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTitle.MultiLine = False
		Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTitle.TabStop = True
		Me.txtTitle.Visible = True
		Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTitle.Name = "txtTitle"
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(192, 90)
		Me.cboDocNoFr.TabIndex = 2
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
		Me.cboDocNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoTo.Location = New System.Drawing.Point(380, 90)
		Me.cboDocNoTo.TabIndex = 3
		Me.cboDocNoTo.Text = "Combo1"
		Me.cboDocNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNoTo.CausesValidation = True
		Me.cboDocNoTo.Enabled = True
		Me.cboDocNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNoTo.IntegralHeight = True
		Me.cboDocNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNoTo.Sorted = False
		Me.cboDocNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNoTo.TabStop = True
		Me.cboDocNoTo.Visible = True
		Me.cboDocNoTo.Name = "cboDocNoTo"
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
		Me.medPrdTo.AllowPromptAsInput = False
		Me.medPrdTo.Size = New System.Drawing.Size(73, 19)
		Me.medPrdTo.Location = New System.Drawing.Point(380, 115)
		Me.medPrdTo.TabIndex = 5
		Me.medPrdTo.MaxLength = 7
		Me.medPrdTo.Mask = "####/##"
		Me.medPrdTo.PromptChar = "_"
		Me.medPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdTo.Name = "medPrdTo"
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(192, 115)
		Me.medPrdFr.TabIndex = 4
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.medUpdTo.AllowPromptAsInput = False
		Me.medUpdTo.Size = New System.Drawing.Size(73, 19)
		Me.medUpdTo.Location = New System.Drawing.Point(380, 163)
		Me.medUpdTo.TabIndex = 9
		Me.medUpdTo.MaxLength = 7
		Me.medUpdTo.Mask = "####/##"
		Me.medUpdTo.PromptChar = "_"
		Me.medUpdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medUpdTo.Name = "medUpdTo"
		Me.medUpdFr.AllowPromptAsInput = False
		Me.medUpdFr.Size = New System.Drawing.Size(73, 19)
		Me.medUpdFr.Location = New System.Drawing.Point(192, 163)
		Me.medUpdFr.TabIndex = 8
		Me.medUpdFr.MaxLength = 7
		Me.medUpdFr.Mask = "####/##"
		Me.medUpdFr.PromptChar = "_"
		Me.medUpdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medUpdFr.Name = "medUpdFr"
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(613, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 20
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
		Me._tbrProcess_Button2.ImageIndex = 6
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Cancel"
		Me._tbrProcess_Button3.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button3.ImageIndex = 4
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Exit"
		Me._tbrProcess_Button4.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button4.ImageIndex = 8
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblPrtMrk.Text = "Print Range"
		Me.lblPrtMrk.Size = New System.Drawing.Size(120, 17)
		Me.lblPrtMrk.Location = New System.Drawing.Point(64, 200)
		Me.lblPrtMrk.TabIndex = 24
		Me.lblPrtMrk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrtMrk.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrtMrk.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrtMrk.Enabled = True
		Me.lblPrtMrk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrtMrk.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrtMrk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrtMrk.UseMnemonic = True
		Me.lblPrtMrk.Visible = True
		Me.lblPrtMrk.AutoSize = False
		Me.lblPrtMrk.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrtMrk.Name = "lblPrtMrk"
		Me.lblPfx.Text = "DOCNO"
		Me.lblPfx.Size = New System.Drawing.Size(81, 17)
		Me.lblPfx.Location = New System.Drawing.Point(64, 68)
		Me.lblPfx.TabIndex = 21
		Me.lblPfx.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPfx.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPfx.BackColor = System.Drawing.SystemColors.Control
		Me.lblPfx.Enabled = True
		Me.lblPfx.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPfx.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPfx.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPfx.UseMnemonic = True
		Me.lblPfx.Visible = True
		Me.lblPfx.AutoSize = False
		Me.lblPfx.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPfx.Name = "lblPfx"
		Me.lblUsrFr.Text = "USRFR"
		Me.lblUsrFr.Size = New System.Drawing.Size(126, 15)
		Me.lblUsrFr.Location = New System.Drawing.Point(66, 144)
		Me.lblUsrFr.TabIndex = 19
		Me.lblUsrFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrFr.Enabled = True
		Me.lblUsrFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrFr.UseMnemonic = True
		Me.lblUsrFr.Visible = True
		Me.lblUsrFr.AutoSize = False
		Me.lblUsrFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrFr.Name = "lblUsrFr"
		Me.lblUpdFr.Text = "UPDFR"
		Me.lblUpdFr.Size = New System.Drawing.Size(126, 15)
		Me.lblUpdFr.Location = New System.Drawing.Point(66, 169)
		Me.lblUpdFr.TabIndex = 18
		Me.lblUpdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUpdFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUpdFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblUpdFr.Enabled = True
		Me.lblUpdFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUpdFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUpdFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUpdFr.UseMnemonic = True
		Me.lblUpdFr.Visible = True
		Me.lblUpdFr.AutoSize = False
		Me.lblUpdFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUpdFr.Name = "lblUpdFr"
		Me.lblUsrTo.Text = "To"
		Me.lblUsrTo.Size = New System.Drawing.Size(25, 15)
		Me.lblUsrTo.Location = New System.Drawing.Point(356, 144)
		Me.lblUsrTo.TabIndex = 17
		Me.lblUsrTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrTo.Enabled = True
		Me.lblUsrTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrTo.UseMnemonic = True
		Me.lblUsrTo.Visible = True
		Me.lblUsrTo.AutoSize = False
		Me.lblUsrTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrTo.Name = "lblUsrTo"
		Me.lblUpdTo.Text = "To"
		Me.lblUpdTo.Size = New System.Drawing.Size(25, 15)
		Me.lblUpdTo.Location = New System.Drawing.Point(356, 169)
		Me.lblUpdTo.TabIndex = 16
		Me.lblUpdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUpdTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUpdTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblUpdTo.Enabled = True
		Me.lblUpdTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUpdTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUpdTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUpdTo.UseMnemonic = True
		Me.lblUpdTo.Visible = True
		Me.lblUpdTo.AutoSize = False
		Me.lblUpdTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUpdTo.Name = "lblUpdTo"
		Me.lblTitle.Text = "SHIPPER"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(66, 43)
		Me.lblTitle.TabIndex = 15
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.Enabled = True
		Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me.lblDocNoFr.Text = "Document # From"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNoFr.Location = New System.Drawing.Point(66, 94)
		Me.lblDocNoFr.TabIndex = 14
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
		Me.lblDocNoTo.Text = "To"
		Me.lblDocNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblDocNoTo.Location = New System.Drawing.Point(356, 94)
		Me.lblDocNoTo.TabIndex = 13
		Me.lblDocNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNoTo.Enabled = True
		Me.lblDocNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNoTo.UseMnemonic = True
		Me.lblDocNoTo.Visible = True
		Me.lblDocNoTo.AutoSize = False
		Me.lblDocNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNoTo.Name = "lblDocNoTo"
		Me.lblPrdTo.Text = "To"
		Me.lblPrdTo.Size = New System.Drawing.Size(25, 15)
		Me.lblPrdTo.Location = New System.Drawing.Point(356, 119)
		Me.lblPrdTo.TabIndex = 11
		Me.lblPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdTo.Enabled = True
		Me.lblPrdTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdTo.UseMnemonic = True
		Me.lblPrdTo.Visible = True
		Me.lblPrdTo.AutoSize = False
		Me.lblPrdTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdTo.Name = "lblPrdTo"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(126, 15)
		Me.lblPrdFr.Location = New System.Drawing.Point(66, 119)
		Me.lblPrdFr.TabIndex = 10
		Me.lblPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdFr.Enabled = True
		Me.lblPrdFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdFr.UseMnemonic = True
		Me.lblPrdFr.Visible = True
		Me.lblPrdFr.AutoSize = False
		Me.lblPrdFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdFr.Name = "lblPrdFr"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cboPfx)
		Me.Controls.Add(cboUsrFr)
		Me.Controls.Add(cboUsrTo)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(medPrdTo)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(medUpdTo)
		Me.Controls.Add(medUpdFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblPrtMrk)
		Me.Controls.Add(lblPfx)
		Me.Controls.Add(lblUsrFr)
		Me.Controls.Add(lblUpdFr)
		Me.Controls.Add(lblUsrTo)
		Me.Controls.Add(lblUpdTo)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblDocNoFr)
		Me.Controls.Add(lblDocNoTo)
		Me.Controls.Add(lblPrdTo)
		Me.Controls.Add(lblPrdFr)
		Me.Frame1.Controls.Add(chkPgeBrk)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class