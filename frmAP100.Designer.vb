<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAP100
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
	Public WithEvents chkSettle As System.Windows.Forms.CheckBox
	Public WithEvents cboVdrNoFr2 As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrNoTo2 As System.Windows.Forms.ComboBox
	Public WithEvents cboChqNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboChqNoFr As System.Windows.Forms.ComboBox
	Public WithEvents chkAR As System.Windows.Forms.CheckBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrNoFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents medPrdTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdTo2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdFr2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblVdrNoFr2 As System.Windows.Forms.Label
	Public WithEvents lblPrdFr2 As System.Windows.Forms.Label
	Public WithEvents lblVdrNoTo2 As System.Windows.Forms.Label
	Public WithEvents lblPrdTo2 As System.Windows.Forms.Label
	Public WithEvents lblChqNoTo As System.Windows.Forms.Label
	Public WithEvents lblChqNoFr As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents lblPrdTo As System.Windows.Forms.Label
	Public WithEvents lblVdrNoTo As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents lblVdrNoFr As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAP100))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.chkSettle = New System.Windows.Forms.CheckBox
		Me.cboVdrNoFr2 = New System.Windows.Forms.ComboBox
		Me.cboVdrNoTo2 = New System.Windows.Forms.ComboBox
		Me.cboChqNoTo = New System.Windows.Forms.ComboBox
		Me.cboChqNoFr = New System.Windows.Forms.ComboBox
		Me.chkAR = New System.Windows.Forms.CheckBox
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.cboVdrNoTo = New System.Windows.Forms.ComboBox
		Me.cboVdrNoFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.medPrdTo = New System.Windows.Forms.MaskedTextBox
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.medPrdTo2 = New System.Windows.Forms.MaskedTextBox
		Me.medPrdFr2 = New System.Windows.Forms.MaskedTextBox
		Me.lblVdrNoFr2 = New System.Windows.Forms.Label
		Me.lblPrdFr2 = New System.Windows.Forms.Label
		Me.lblVdrNoTo2 = New System.Windows.Forms.Label
		Me.lblPrdTo2 = New System.Windows.Forms.Label
		Me.lblChqNoTo = New System.Windows.Forms.Label
		Me.lblChqNoFr = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.lblPrdTo = New System.Windows.Forms.Label
		Me.lblVdrNoTo = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.lblVdrNoFr = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "AR Update"
		Me.ClientSize = New System.Drawing.Size(613, 319)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.Icon = CType(resources.GetObject("frmAP100.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmAP100"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(304, 256)
		Me.tblCommon.TabIndex = 17
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.chkSettle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkSettle.Text = "Settlement"
		Me.chkSettle.Size = New System.Drawing.Size(129, 12)
		Me.chkSettle.Location = New System.Drawing.Point(56, 152)
		Me.chkSettle.TabIndex = 6
		Me.chkSettle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkSettle.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkSettle.BackColor = System.Drawing.SystemColors.Control
		Me.chkSettle.CausesValidation = True
		Me.chkSettle.Enabled = True
		Me.chkSettle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkSettle.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkSettle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkSettle.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkSettle.TabStop = True
		Me.chkSettle.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkSettle.Visible = True
		Me.chkSettle.Name = "chkSettle"
		Me.cboVdrNoFr2.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoFr2.Location = New System.Drawing.Point(186, 202)
		Me.cboVdrNoFr2.TabIndex = 9
		Me.cboVdrNoFr2.Text = "Combo1"
		Me.cboVdrNoFr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoFr2.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoFr2.CausesValidation = True
		Me.cboVdrNoFr2.Enabled = True
		Me.cboVdrNoFr2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoFr2.IntegralHeight = True
		Me.cboVdrNoFr2.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoFr2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoFr2.Sorted = False
		Me.cboVdrNoFr2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoFr2.TabStop = True
		Me.cboVdrNoFr2.Visible = True
		Me.cboVdrNoFr2.Name = "cboVdrNoFr2"
		Me.cboVdrNoTo2.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoTo2.Location = New System.Drawing.Point(372, 202)
		Me.cboVdrNoTo2.TabIndex = 10
		Me.cboVdrNoTo2.Text = "Combo1"
		Me.cboVdrNoTo2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoTo2.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoTo2.CausesValidation = True
		Me.cboVdrNoTo2.Enabled = True
		Me.cboVdrNoTo2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoTo2.IntegralHeight = True
		Me.cboVdrNoTo2.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoTo2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoTo2.Sorted = False
		Me.cboVdrNoTo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoTo2.TabStop = True
		Me.cboVdrNoTo2.Visible = True
		Me.cboVdrNoTo2.Name = "cboVdrNoTo2"
		Me.cboChqNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboChqNoTo.Location = New System.Drawing.Point(372, 178)
		Me.cboChqNoTo.TabIndex = 8
		Me.cboChqNoTo.Text = "Combo1"
		Me.cboChqNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboChqNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboChqNoTo.CausesValidation = True
		Me.cboChqNoTo.Enabled = True
		Me.cboChqNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboChqNoTo.IntegralHeight = True
		Me.cboChqNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboChqNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboChqNoTo.Sorted = False
		Me.cboChqNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboChqNoTo.TabStop = True
		Me.cboChqNoTo.Visible = True
		Me.cboChqNoTo.Name = "cboChqNoTo"
		Me.cboChqNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboChqNoFr.Location = New System.Drawing.Point(186, 178)
		Me.cboChqNoFr.TabIndex = 7
		Me.cboChqNoFr.Text = "Combo1"
		Me.cboChqNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboChqNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboChqNoFr.CausesValidation = True
		Me.cboChqNoFr.Enabled = True
		Me.cboChqNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboChqNoFr.IntegralHeight = True
		Me.cboChqNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboChqNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboChqNoFr.Sorted = False
		Me.cboChqNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboChqNoFr.TabStop = True
		Me.cboChqNoFr.Visible = True
		Me.cboChqNoFr.Name = "cboChqNoFr"
		Me.chkAR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkAR.Text = "AR Transaction"
		Me.chkAR.Size = New System.Drawing.Size(129, 12)
		Me.chkAR.Location = New System.Drawing.Point(56, 40)
		Me.chkAR.TabIndex = 21
		Me.chkAR.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAR.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAR.BackColor = System.Drawing.SystemColors.Control
		Me.chkAR.CausesValidation = True
		Me.chkAR.Enabled = True
		Me.chkAR.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAR.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAR.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAR.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAR.TabStop = True
		Me.chkAR.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAR.Visible = True
		Me.chkAR.Name = "chkAR"
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(186, 66)
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
		Me.cboDocNoTo.Location = New System.Drawing.Point(372, 66)
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
		Me.cboVdrNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoTo.Location = New System.Drawing.Point(372, 90)
		Me.cboVdrNoTo.TabIndex = 3
		Me.cboVdrNoTo.Text = "Combo1"
		Me.cboVdrNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoTo.CausesValidation = True
		Me.cboVdrNoTo.Enabled = True
		Me.cboVdrNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoTo.IntegralHeight = True
		Me.cboVdrNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoTo.Sorted = False
		Me.cboVdrNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoTo.TabStop = True
		Me.cboVdrNoTo.Visible = True
		Me.cboVdrNoTo.Name = "cboVdrNoTo"
		Me.cboVdrNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoFr.Location = New System.Drawing.Point(186, 90)
		Me.cboVdrNoFr.TabIndex = 2
		Me.cboVdrNoFr.Text = "Combo1"
		Me.cboVdrNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoFr.CausesValidation = True
		Me.cboVdrNoFr.Enabled = True
		Me.cboVdrNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoFr.IntegralHeight = True
		Me.cboVdrNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoFr.Sorted = False
		Me.cboVdrNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoFr.TabStop = True
		Me.cboVdrNoFr.Visible = True
		Me.cboVdrNoFr.Name = "cboVdrNoFr"
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
		Me.medPrdTo.AllowPromptAsInput = False
		Me.medPrdTo.Size = New System.Drawing.Size(73, 19)
		Me.medPrdTo.Location = New System.Drawing.Point(372, 112)
		Me.medPrdTo.TabIndex = 5
		Me.medPrdTo.MaxLength = 7
		Me.medPrdTo.Mask = "####/##"
		Me.medPrdTo.PromptChar = "_"
		Me.medPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdTo.Name = "medPrdTo"
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(186, 112)
		Me.medPrdFr.TabIndex = 4
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.medPrdTo2.AllowPromptAsInput = False
		Me.medPrdTo2.Size = New System.Drawing.Size(73, 19)
		Me.medPrdTo2.Location = New System.Drawing.Point(372, 224)
		Me.medPrdTo2.TabIndex = 12
		Me.medPrdTo2.MaxLength = 7
		Me.medPrdTo2.Mask = "####/##"
		Me.medPrdTo2.PromptChar = "_"
		Me.medPrdTo2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdTo2.Name = "medPrdTo2"
		Me.medPrdFr2.AllowPromptAsInput = False
		Me.medPrdFr2.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr2.Location = New System.Drawing.Point(186, 224)
		Me.medPrdFr2.TabIndex = 11
		Me.medPrdFr2.MaxLength = 7
		Me.medPrdFr2.Mask = "####/##"
		Me.medPrdFr2.PromptChar = "_"
		Me.medPrdFr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr2.Name = "medPrdFr2"
		Me.lblVdrNoFr2.Text = "Customer Code From"
		Me.lblVdrNoFr2.Size = New System.Drawing.Size(126, 15)
		Me.lblVdrNoFr2.Location = New System.Drawing.Point(58, 203)
		Me.lblVdrNoFr2.TabIndex = 27
		Me.lblVdrNoFr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoFr2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoFr2.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoFr2.Enabled = True
		Me.lblVdrNoFr2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoFr2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoFr2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoFr2.UseMnemonic = True
		Me.lblVdrNoFr2.Visible = True
		Me.lblVdrNoFr2.AutoSize = False
		Me.lblVdrNoFr2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoFr2.Name = "lblVdrNoFr2"
		Me.lblPrdFr2.Text = "Period From"
		Me.lblPrdFr2.Size = New System.Drawing.Size(126, 15)
		Me.lblPrdFr2.Location = New System.Drawing.Point(58, 227)
		Me.lblPrdFr2.TabIndex = 26
		Me.lblPrdFr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdFr2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdFr2.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdFr2.Enabled = True
		Me.lblPrdFr2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdFr2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdFr2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdFr2.UseMnemonic = True
		Me.lblPrdFr2.Visible = True
		Me.lblPrdFr2.AutoSize = False
		Me.lblPrdFr2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdFr2.Name = "lblPrdFr2"
		Me.lblVdrNoTo2.Text = "To"
		Me.lblVdrNoTo2.Size = New System.Drawing.Size(25, 15)
		Me.lblVdrNoTo2.Location = New System.Drawing.Point(348, 203)
		Me.lblVdrNoTo2.TabIndex = 25
		Me.lblVdrNoTo2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoTo2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoTo2.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoTo2.Enabled = True
		Me.lblVdrNoTo2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoTo2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoTo2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoTo2.UseMnemonic = True
		Me.lblVdrNoTo2.Visible = True
		Me.lblVdrNoTo2.AutoSize = False
		Me.lblVdrNoTo2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoTo2.Name = "lblVdrNoTo2"
		Me.lblPrdTo2.Text = "To"
		Me.lblPrdTo2.Size = New System.Drawing.Size(25, 15)
		Me.lblPrdTo2.Location = New System.Drawing.Point(348, 227)
		Me.lblPrdTo2.TabIndex = 24
		Me.lblPrdTo2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdTo2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdTo2.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdTo2.Enabled = True
		Me.lblPrdTo2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdTo2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdTo2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdTo2.UseMnemonic = True
		Me.lblPrdTo2.Visible = True
		Me.lblPrdTo2.AutoSize = False
		Me.lblPrdTo2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdTo2.Name = "lblPrdTo2"
		Me.lblChqNoTo.Text = "To"
		Me.lblChqNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblChqNoTo.Location = New System.Drawing.Point(348, 179)
		Me.lblChqNoTo.TabIndex = 23
		Me.lblChqNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChqNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblChqNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblChqNoTo.Enabled = True
		Me.lblChqNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChqNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblChqNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChqNoTo.UseMnemonic = True
		Me.lblChqNoTo.Visible = True
		Me.lblChqNoTo.AutoSize = False
		Me.lblChqNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChqNoTo.Name = "lblChqNoTo"
		Me.lblChqNoFr.Text = "Document # From"
		Me.lblChqNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblChqNoFr.Location = New System.Drawing.Point(58, 179)
		Me.lblChqNoFr.TabIndex = 22
		Me.lblChqNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChqNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblChqNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblChqNoFr.Enabled = True
		Me.lblChqNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChqNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblChqNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChqNoFr.UseMnemonic = True
		Me.lblChqNoFr.Visible = True
		Me.lblChqNoFr.AutoSize = False
		Me.lblChqNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChqNoFr.Name = "lblChqNoFr"
		Me.lblDocNoFr.Text = "Document # From"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNoFr.Location = New System.Drawing.Point(58, 67)
		Me.lblDocNoFr.TabIndex = 19
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
		Me.lblDocNoTo.Location = New System.Drawing.Point(348, 67)
		Me.lblDocNoTo.TabIndex = 18
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
		Me.lblPrdTo.Location = New System.Drawing.Point(348, 115)
		Me.lblPrdTo.TabIndex = 16
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
		Me.lblVdrNoTo.Text = "To"
		Me.lblVdrNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblVdrNoTo.Location = New System.Drawing.Point(348, 91)
		Me.lblVdrNoTo.TabIndex = 15
		Me.lblVdrNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoTo.Enabled = True
		Me.lblVdrNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoTo.UseMnemonic = True
		Me.lblVdrNoTo.Visible = True
		Me.lblVdrNoTo.AutoSize = False
		Me.lblVdrNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoTo.Name = "lblVdrNoTo"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(126, 15)
		Me.lblPrdFr.Location = New System.Drawing.Point(58, 115)
		Me.lblPrdFr.TabIndex = 14
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
		Me.lblVdrNoFr.Text = "Customer Code From"
		Me.lblVdrNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblVdrNoFr.Location = New System.Drawing.Point(58, 91)
		Me.lblVdrNoFr.TabIndex = 13
		Me.lblVdrNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoFr.Enabled = True
		Me.lblVdrNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoFr.UseMnemonic = True
		Me.lblVdrNoFr.Visible = True
		Me.lblVdrNoFr.AutoSize = False
		Me.lblVdrNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoFr.Name = "lblVdrNoFr"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(chkSettle)
		Me.Controls.Add(cboVdrNoFr2)
		Me.Controls.Add(cboVdrNoTo2)
		Me.Controls.Add(cboChqNoTo)
		Me.Controls.Add(cboChqNoFr)
		Me.Controls.Add(chkAR)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(cboVdrNoTo)
		Me.Controls.Add(cboVdrNoFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(medPrdTo)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(medPrdTo2)
		Me.Controls.Add(medPrdFr2)
		Me.Controls.Add(lblVdrNoFr2)
		Me.Controls.Add(lblPrdFr2)
		Me.Controls.Add(lblVdrNoTo2)
		Me.Controls.Add(lblPrdTo2)
		Me.Controls.Add(lblChqNoTo)
		Me.Controls.Add(lblChqNoFr)
		Me.Controls.Add(lblDocNoFr)
		Me.Controls.Add(lblDocNoTo)
		Me.Controls.Add(lblPrdTo)
		Me.Controls.Add(lblVdrNoTo)
		Me.Controls.Add(lblPrdFr)
		Me.Controls.Add(lblVdrNoFr)
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