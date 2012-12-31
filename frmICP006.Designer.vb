<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmICP006
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
	Public WithEvents cboItmAccTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmAccTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboWhsCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboWhsCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents lblItmAccTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmAccTypeCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmTypeCodeTo As System.Windows.Forms.Label
	Public WithEvents lblWhsCodeFr As System.Windows.Forms.Label
	Public WithEvents lblWhsCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeTo As System.Windows.Forms.Label
	Public WithEvents lblItmCodeFr As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmICP006))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItmAccTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmAccTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmTypeCodeFr = New System.Windows.Forms.ComboBox
		Me.cboWhsCodeFr = New System.Windows.Forms.ComboBox
		Me.cboWhsCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeTo = New System.Windows.Forms.ComboBox
		Me.cboItmCodeFr = New System.Windows.Forms.ComboBox
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.lblItmAccTypeCodeTo = New System.Windows.Forms.Label
		Me.lblItmAccTypeCodeFr = New System.Windows.Forms.Label
		Me.lblItmTypeCodeFr = New System.Windows.Forms.Label
		Me.lblItmTypeCodeTo = New System.Windows.Forms.Label
		Me.lblWhsCodeFr = New System.Windows.Forms.Label
		Me.lblWhsCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeTo = New System.Windows.Forms.Label
		Me.lblItmCodeFr = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "ICP003"
		Me.ClientSize = New System.Drawing.Size(613, 229)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.KeyPreview = True
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
		Me.Name = "frmICP006"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(600, 40)
		Me.tblCommon.TabIndex = 3
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItmAccTypeCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmAccTypeCodeTo.Location = New System.Drawing.Point(368, 104)
		Me.cboItmAccTypeCodeTo.TabIndex = 19
		Me.cboItmAccTypeCodeTo.Text = "Combo1"
		Me.cboItmAccTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmAccTypeCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmAccTypeCodeTo.CausesValidation = True
		Me.cboItmAccTypeCodeTo.Enabled = True
		Me.cboItmAccTypeCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmAccTypeCodeTo.IntegralHeight = True
		Me.cboItmAccTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmAccTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmAccTypeCodeTo.Sorted = False
		Me.cboItmAccTypeCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmAccTypeCodeTo.TabStop = True
		Me.cboItmAccTypeCodeTo.Visible = True
		Me.cboItmAccTypeCodeTo.Name = "cboItmAccTypeCodeTo"
		Me.cboItmAccTypeCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmAccTypeCodeFr.Location = New System.Drawing.Point(184, 104)
		Me.cboItmAccTypeCodeFr.TabIndex = 18
		Me.cboItmAccTypeCodeFr.Text = "Combo1"
		Me.cboItmAccTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmAccTypeCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmAccTypeCodeFr.CausesValidation = True
		Me.cboItmAccTypeCodeFr.Enabled = True
		Me.cboItmAccTypeCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmAccTypeCodeFr.IntegralHeight = True
		Me.cboItmAccTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmAccTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmAccTypeCodeFr.Sorted = False
		Me.cboItmAccTypeCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmAccTypeCodeFr.TabStop = True
		Me.cboItmAccTypeCodeFr.Visible = True
		Me.cboItmAccTypeCodeFr.Name = "cboItmAccTypeCodeFr"
		Me.cboItmTypeCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCodeTo.Location = New System.Drawing.Point(368, 128)
		Me.cboItmTypeCodeTo.TabIndex = 17
		Me.cboItmTypeCodeTo.Text = "Combo1"
		Me.cboItmTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeCodeTo.CausesValidation = True
		Me.cboItmTypeCodeTo.Enabled = True
		Me.cboItmTypeCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeCodeTo.IntegralHeight = True
		Me.cboItmTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeCodeTo.Sorted = False
		Me.cboItmTypeCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeCodeTo.TabStop = True
		Me.cboItmTypeCodeTo.Visible = True
		Me.cboItmTypeCodeTo.Name = "cboItmTypeCodeTo"
		Me.cboItmTypeCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeCodeFr.Location = New System.Drawing.Point(184, 128)
		Me.cboItmTypeCodeFr.TabIndex = 16
		Me.cboItmTypeCodeFr.Text = "Combo1"
		Me.cboItmTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeCodeFr.CausesValidation = True
		Me.cboItmTypeCodeFr.Enabled = True
		Me.cboItmTypeCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeCodeFr.IntegralHeight = True
		Me.cboItmTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeCodeFr.Sorted = False
		Me.cboItmTypeCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeCodeFr.TabStop = True
		Me.cboItmTypeCodeFr.Visible = True
		Me.cboItmTypeCodeFr.Name = "cboItmTypeCodeFr"
		Me.cboWhsCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboWhsCodeFr.Location = New System.Drawing.Point(184, 152)
		Me.cboWhsCodeFr.TabIndex = 15
		Me.cboWhsCodeFr.Text = "Combo1"
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
		Me.cboWhsCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboWhsCodeTo.Location = New System.Drawing.Point(368, 152)
		Me.cboWhsCodeTo.TabIndex = 14
		Me.cboWhsCodeTo.Text = "Combo1"
		Me.cboWhsCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWhsCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboWhsCodeTo.CausesValidation = True
		Me.cboWhsCodeTo.Enabled = True
		Me.cboWhsCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWhsCodeTo.IntegralHeight = True
		Me.cboWhsCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWhsCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWhsCodeTo.Sorted = False
		Me.cboWhsCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWhsCodeTo.TabStop = True
		Me.cboWhsCodeTo.Visible = True
		Me.cboWhsCodeTo.Name = "cboWhsCodeTo"
		Me.cboItmCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeTo.Location = New System.Drawing.Point(368, 80)
		Me.cboItmCodeTo.TabIndex = 2
		Me.cboItmCodeTo.Text = "Combo1"
		Me.cboItmCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCodeTo.CausesValidation = True
		Me.cboItmCodeTo.Enabled = True
		Me.cboItmCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCodeTo.IntegralHeight = True
		Me.cboItmCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCodeTo.Sorted = False
		Me.cboItmCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCodeTo.TabStop = True
		Me.cboItmCodeTo.Visible = True
		Me.cboItmCodeTo.Name = "cboItmCodeTo"
		Me.cboItmCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeFr.Location = New System.Drawing.Point(184, 80)
		Me.cboItmCodeFr.TabIndex = 1
		Me.cboItmCodeFr.Text = "Combo1"
		Me.cboItmCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCodeFr.CausesValidation = True
		Me.cboItmCodeFr.Enabled = True
		Me.cboItmCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCodeFr.IntegralHeight = True
		Me.cboItmCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCodeFr.Sorted = False
		Me.cboItmCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCodeFr.TabStop = True
		Me.cboItmCodeFr.Visible = True
		Me.cboItmCodeFr.Name = "cboItmCodeFr"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(186, 48)
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
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
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
		Me.tbrProcess.Size = New System.Drawing.Size(613, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 5
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
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(184, 176)
		Me.medPrdFr.TabIndex = 20
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(126, 22)
		Me.lblPrdFr.Location = New System.Drawing.Point(56, 179)
		Me.lblPrdFr.TabIndex = 21
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
		Me.lblItmAccTypeCodeTo.Text = "ACCTYPECODETO"
		Me.lblItmAccTypeCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmAccTypeCodeTo.Location = New System.Drawing.Point(328, 106)
		Me.lblItmAccTypeCodeTo.TabIndex = 13
		Me.lblItmAccTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmAccTypeCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmAccTypeCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmAccTypeCodeTo.Enabled = True
		Me.lblItmAccTypeCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmAccTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmAccTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmAccTypeCodeTo.UseMnemonic = True
		Me.lblItmAccTypeCodeTo.Visible = True
		Me.lblItmAccTypeCodeTo.AutoSize = False
		Me.lblItmAccTypeCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmAccTypeCodeTo.Name = "lblItmAccTypeCodeTo"
		Me.lblItmAccTypeCodeFr.Text = "ACCTYPECODEFR"
		Me.lblItmAccTypeCodeFr.Size = New System.Drawing.Size(110, 15)
		Me.lblItmAccTypeCodeFr.Location = New System.Drawing.Point(56, 106)
		Me.lblItmAccTypeCodeFr.TabIndex = 12
		Me.lblItmAccTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmAccTypeCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmAccTypeCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmAccTypeCodeFr.Enabled = True
		Me.lblItmAccTypeCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmAccTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmAccTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmAccTypeCodeFr.UseMnemonic = True
		Me.lblItmAccTypeCodeFr.Visible = True
		Me.lblItmAccTypeCodeFr.AutoSize = False
		Me.lblItmAccTypeCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmAccTypeCodeFr.Name = "lblItmAccTypeCodeFr"
		Me.lblItmTypeCodeFr.Text = "ITMTYPECODEFR"
		Me.lblItmTypeCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmTypeCodeFr.Location = New System.Drawing.Point(56, 129)
		Me.lblItmTypeCodeFr.TabIndex = 11
		Me.lblItmTypeCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeCodeFr.Enabled = True
		Me.lblItmTypeCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeCodeFr.UseMnemonic = True
		Me.lblItmTypeCodeFr.Visible = True
		Me.lblItmTypeCodeFr.AutoSize = False
		Me.lblItmTypeCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeCodeFr.Name = "lblItmTypeCodeFr"
		Me.lblItmTypeCodeTo.Text = "ITMTYPECODETO"
		Me.lblItmTypeCodeTo.Size = New System.Drawing.Size(73, 15)
		Me.lblItmTypeCodeTo.Location = New System.Drawing.Point(328, 129)
		Me.lblItmTypeCodeTo.TabIndex = 10
		Me.lblItmTypeCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeCodeTo.Enabled = True
		Me.lblItmTypeCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeCodeTo.UseMnemonic = True
		Me.lblItmTypeCodeTo.Visible = True
		Me.lblItmTypeCodeTo.AutoSize = False
		Me.lblItmTypeCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeCodeTo.Name = "lblItmTypeCodeTo"
		Me.lblWhsCodeFr.Text = "WHSCODEFR"
		Me.lblWhsCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblWhsCodeFr.Location = New System.Drawing.Point(56, 155)
		Me.lblWhsCodeFr.TabIndex = 9
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
		Me.lblWhsCodeTo.Text = "WHSCODETO"
		Me.lblWhsCodeTo.Size = New System.Drawing.Size(41, 15)
		Me.lblWhsCodeTo.Location = New System.Drawing.Point(328, 155)
		Me.lblWhsCodeTo.TabIndex = 8
		Me.lblWhsCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhsCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsCodeTo.Enabled = True
		Me.lblWhsCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsCodeTo.UseMnemonic = True
		Me.lblWhsCodeTo.Visible = True
		Me.lblWhsCodeTo.AutoSize = False
		Me.lblWhsCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsCodeTo.Name = "lblWhsCodeTo"
		Me.lblItmCodeTo.Text = "ITMCODETO"
		Me.lblItmCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmCodeTo.Location = New System.Drawing.Point(328, 83)
		Me.lblItmCodeTo.TabIndex = 7
		Me.lblItmCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCodeTo.Enabled = True
		Me.lblItmCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCodeTo.UseMnemonic = True
		Me.lblItmCodeTo.Visible = True
		Me.lblItmCodeTo.AutoSize = False
		Me.lblItmCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCodeTo.Name = "lblItmCodeTo"
		Me.lblItmCodeFr.Text = "ITMCODEFR"
		Me.lblItmCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmCodeFr.Location = New System.Drawing.Point(56, 83)
		Me.lblItmCodeFr.TabIndex = 6
		Me.lblItmCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCodeFr.Enabled = True
		Me.lblItmCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCodeFr.UseMnemonic = True
		Me.lblItmCodeFr.Visible = True
		Me.lblItmCodeFr.AutoSize = False
		Me.lblItmCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCodeFr.Name = "lblItmCodeFr"
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(58, 51)
		Me.lblTitle.TabIndex = 4
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
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboItmAccTypeCodeTo)
		Me.Controls.Add(cboItmAccTypeCodeFr)
		Me.Controls.Add(cboItmTypeCodeTo)
		Me.Controls.Add(cboItmTypeCodeFr)
		Me.Controls.Add(cboWhsCodeFr)
		Me.Controls.Add(cboWhsCodeTo)
		Me.Controls.Add(cboItmCodeTo)
		Me.Controls.Add(cboItmCodeFr)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(lblPrdFr)
		Me.Controls.Add(lblItmAccTypeCodeTo)
		Me.Controls.Add(lblItmAccTypeCodeFr)
		Me.Controls.Add(lblItmTypeCodeFr)
		Me.Controls.Add(lblItmTypeCodeTo)
		Me.Controls.Add(lblWhsCodeFr)
		Me.Controls.Add(lblWhsCodeTo)
		Me.Controls.Add(lblItmCodeTo)
		Me.Controls.Add(lblItmCodeFr)
		Me.Controls.Add(lblTitle)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class