<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmITM002
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
	Public WithEvents cboItmClassFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmClassTo As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboItmTypeFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents medPrdTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblItmClassFr As System.Windows.Forms.Label
	Public WithEvents lblItmClassTo As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents lblPrdTo As System.Windows.Forms.Label
	Public WithEvents lblItmTypeTo As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents lblItmTypeFr As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmITM002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItmClassFr = New System.Windows.Forms.ComboBox
		Me.cboItmClassTo = New System.Windows.Forms.ComboBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.cboItmTypeTo = New System.Windows.Forms.ComboBox
		Me.cboItmTypeFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.medPrdTo = New System.Windows.Forms.MaskedTextBox
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.lblItmClassFr = New System.Windows.Forms.Label
		Me.lblItmClassTo = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.lblPrdTo = New System.Windows.Forms.Label
		Me.lblItmTypeTo = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.lblItmTypeFr = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Material Master List"
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
		Me.Name = "frmITM002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 12
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItmClassFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmClassFr.Location = New System.Drawing.Point(186, 104)
		Me.cboItmClassFr.TabIndex = 4
		Me.cboItmClassFr.Text = "Combo1"
		Me.cboItmClassFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmClassFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmClassFr.CausesValidation = True
		Me.cboItmClassFr.Enabled = True
		Me.cboItmClassFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmClassFr.IntegralHeight = True
		Me.cboItmClassFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmClassFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmClassFr.Sorted = False
		Me.cboItmClassFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmClassFr.TabStop = True
		Me.cboItmClassFr.Visible = True
		Me.cboItmClassFr.Name = "cboItmClassFr"
		Me.cboItmClassTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmClassTo.Location = New System.Drawing.Point(372, 104)
		Me.cboItmClassTo.TabIndex = 5
		Me.cboItmClassTo.Text = "Combo1"
		Me.cboItmClassTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmClassTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmClassTo.CausesValidation = True
		Me.cboItmClassTo.Enabled = True
		Me.cboItmClassTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmClassTo.IntegralHeight = True
		Me.cboItmClassTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmClassTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmClassTo.Sorted = False
		Me.cboItmClassTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmClassTo.TabStop = True
		Me.cboItmClassTo.Visible = True
		Me.cboItmClassTo.Name = "cboItmClassTo"
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(186, 50)
		Me.cboDocNoFr.TabIndex = 0
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
		Me.cboDocNoTo.Location = New System.Drawing.Point(372, 50)
		Me.cboDocNoTo.TabIndex = 1
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
		Me.cboItmTypeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeTo.Location = New System.Drawing.Point(372, 77)
		Me.cboItmTypeTo.TabIndex = 3
		Me.cboItmTypeTo.Text = "Combo1"
		Me.cboItmTypeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeTo.CausesValidation = True
		Me.cboItmTypeTo.Enabled = True
		Me.cboItmTypeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeTo.IntegralHeight = True
		Me.cboItmTypeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeTo.Sorted = False
		Me.cboItmTypeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeTo.TabStop = True
		Me.cboItmTypeTo.Visible = True
		Me.cboItmTypeTo.Name = "cboItmTypeTo"
		Me.cboItmTypeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmTypeFr.Location = New System.Drawing.Point(186, 77)
		Me.cboItmTypeFr.TabIndex = 2
		Me.cboItmTypeFr.Text = "Combo1"
		Me.cboItmTypeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmTypeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmTypeFr.CausesValidation = True
		Me.cboItmTypeFr.Enabled = True
		Me.cboItmTypeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmTypeFr.IntegralHeight = True
		Me.cboItmTypeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmTypeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmTypeFr.Sorted = False
		Me.cboItmTypeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmTypeFr.TabStop = True
		Me.cboItmTypeFr.Visible = True
		Me.cboItmTypeFr.Name = "cboItmTypeFr"
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
		Me.medPrdTo.AllowPromptAsInput = False
		Me.medPrdTo.Size = New System.Drawing.Size(73, 19)
		Me.medPrdTo.Location = New System.Drawing.Point(372, 128)
		Me.medPrdTo.TabIndex = 7
		Me.medPrdTo.MaxLength = 7
		Me.medPrdTo.Mask = "####/##"
		Me.medPrdTo.PromptChar = "_"
		Me.medPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdTo.Name = "medPrdTo"
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(186, 128)
		Me.medPrdFr.TabIndex = 6
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.lblItmClassFr.Text = "Item Category Code From"
		Me.lblItmClassFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmClassFr.Location = New System.Drawing.Point(58, 108)
		Me.lblItmClassFr.TabIndex = 17
		Me.lblItmClassFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmClassFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmClassFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmClassFr.Enabled = True
		Me.lblItmClassFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmClassFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmClassFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmClassFr.UseMnemonic = True
		Me.lblItmClassFr.Visible = True
		Me.lblItmClassFr.AutoSize = False
		Me.lblItmClassFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmClassFr.Name = "lblItmClassFr"
		Me.lblItmClassTo.Text = "To"
		Me.lblItmClassTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmClassTo.Location = New System.Drawing.Point(348, 108)
		Me.lblItmClassTo.TabIndex = 16
		Me.lblItmClassTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmClassTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmClassTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmClassTo.Enabled = True
		Me.lblItmClassTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmClassTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmClassTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmClassTo.UseMnemonic = True
		Me.lblItmClassTo.Visible = True
		Me.lblItmClassTo.AutoSize = False
		Me.lblItmClassTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmClassTo.Name = "lblItmClassTo"
		Me.lblDocNoFr.Text = "ISBN # From"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 16)
		Me.lblDocNoFr.Location = New System.Drawing.Point(58, 54)
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
		Me.lblDocNoTo.Size = New System.Drawing.Size(25, 16)
		Me.lblDocNoTo.Location = New System.Drawing.Point(348, 54)
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
		Me.lblPrdTo.Location = New System.Drawing.Point(348, 132)
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
		Me.lblItmTypeTo.Text = "To"
		Me.lblItmTypeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmTypeTo.Location = New System.Drawing.Point(348, 79)
		Me.lblItmTypeTo.TabIndex = 10
		Me.lblItmTypeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeTo.Enabled = True
		Me.lblItmTypeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeTo.UseMnemonic = True
		Me.lblItmTypeTo.Visible = True
		Me.lblItmTypeTo.AutoSize = False
		Me.lblItmTypeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeTo.Name = "lblItmTypeTo"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(126, 15)
		Me.lblPrdFr.Location = New System.Drawing.Point(58, 132)
		Me.lblPrdFr.TabIndex = 9
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
		Me.lblItmTypeFr.Text = "Item Type Code From"
		Me.lblItmTypeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmTypeFr.Location = New System.Drawing.Point(58, 79)
		Me.lblItmTypeFr.TabIndex = 8
		Me.lblItmTypeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmTypeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmTypeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmTypeFr.Enabled = True
		Me.lblItmTypeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmTypeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmTypeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmTypeFr.UseMnemonic = True
		Me.lblItmTypeFr.Visible = True
		Me.lblItmTypeFr.AutoSize = False
		Me.lblItmTypeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmTypeFr.Name = "lblItmTypeFr"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboItmClassFr)
		Me.Controls.Add(cboItmClassTo)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(cboItmTypeTo)
		Me.Controls.Add(cboItmTypeFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(medPrdTo)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(lblItmClassFr)
		Me.Controls.Add(lblItmClassTo)
		Me.Controls.Add(lblDocNoFr)
		Me.Controls.Add(lblDocNoTo)
		Me.Controls.Add(lblPrdTo)
		Me.Controls.Add(lblItmTypeTo)
		Me.Controls.Add(lblPrdFr)
		Me.Controls.Add(lblItmTypeFr)
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