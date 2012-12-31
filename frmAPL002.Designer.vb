<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAPL002
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
	Public WithEvents _optPrn_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optPrn_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboCusNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboCusNoFr As System.Windows.Forms.ComboBox
	Public WithEvents _optBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblCusNoTo As System.Windows.Forms.Label
	Public WithEvents lblCusNoFr As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents optBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optPrn As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAPL002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._optPrn_0 = New System.Windows.Forms.RadioButton
		Me._optPrn_1 = New System.Windows.Forms.RadioButton
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboCusNoTo = New System.Windows.Forms.ComboBox
		Me.cboCusNoFr = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optBy_1 = New System.Windows.Forms.RadioButton
		Me._optBy_0 = New System.Windows.Forms.RadioButton
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblCusNoTo = New System.Windows.Forms.Label
		Me.lblCusNoFr = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.optBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optPrn = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optPrn, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "AR Update"
		Me.ClientSize = New System.Drawing.Size(613, 404)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.Icon = CType(resources.GetObject("frmAPL002.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmAPL002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(584, 56)
		Me.tblCommon.TabIndex = 14
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.Frame2.Size = New System.Drawing.Size(492, 41)
		Me.Frame2.Location = New System.Drawing.Point(56, 104)
		Me.Frame2.TabIndex = 16
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me._optPrn_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrn_0.Text = "Default"
		Me._optPrn_0.Size = New System.Drawing.Size(177, 17)
		Me._optPrn_0.Location = New System.Drawing.Point(24, 16)
		Me._optPrn_0.TabIndex = 4
		Me._optPrn_0.Checked = True
		Me._optPrn_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optPrn_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrn_0.BackColor = System.Drawing.SystemColors.Control
		Me._optPrn_0.CausesValidation = True
		Me._optPrn_0.Enabled = True
		Me._optPrn_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optPrn_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optPrn_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optPrn_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optPrn_0.TabStop = True
		Me._optPrn_0.Visible = True
		Me._optPrn_0.Name = "_optPrn_0"
		Me._optPrn_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrn_1.Text = "Key In Exchange Rate"
		Me._optPrn_1.Size = New System.Drawing.Size(185, 17)
		Me._optPrn_1.Location = New System.Drawing.Point(240, 16)
		Me._optPrn_1.TabIndex = 5
		Me._optPrn_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optPrn_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrn_1.BackColor = System.Drawing.SystemColors.Control
		Me._optPrn_1.CausesValidation = True
		Me._optPrn_1.Enabled = True
		Me._optPrn_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optPrn_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optPrn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optPrn_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optPrn_1.TabStop = True
		Me._optPrn_1.Checked = False
		Me._optPrn_1.Visible = True
		Me._optPrn_1.Name = "_optPrn_1"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(144, 38)
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
		Me.cboCusNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoTo.Location = New System.Drawing.Point(332, 61)
		Me.cboCusNoTo.TabIndex = 2
		Me.cboCusNoTo.Text = "Combo1"
		Me.cboCusNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusNoTo.CausesValidation = True
		Me.cboCusNoTo.Enabled = True
		Me.cboCusNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusNoTo.IntegralHeight = True
		Me.cboCusNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusNoTo.Sorted = False
		Me.cboCusNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusNoTo.TabStop = True
		Me.cboCusNoTo.Visible = True
		Me.cboCusNoTo.Name = "cboCusNoTo"
		Me.cboCusNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoFr.Location = New System.Drawing.Point(144, 61)
		Me.cboCusNoFr.TabIndex = 1
		Me.cboCusNoFr.Text = "Combo1"
		Me.cboCusNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusNoFr.CausesValidation = True
		Me.cboCusNoFr.Enabled = True
		Me.cboCusNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusNoFr.IntegralHeight = True
		Me.cboCusNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusNoFr.Sorted = False
		Me.cboCusNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusNoFr.TabStop = True
		Me.cboCusNoFr.Visible = True
		Me.cboCusNoFr.Name = "cboCusNoFr"
		Me.Frame1.Size = New System.Drawing.Size(492, 41)
		Me.Frame1.Location = New System.Drawing.Point(56, 136)
		Me.Frame1.TabIndex = 11
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optBy_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.Text = "Key In Exchange Rate"
		Me._optBy_1.Size = New System.Drawing.Size(185, 17)
		Me._optBy_1.Location = New System.Drawing.Point(240, 16)
		Me._optBy_1.TabIndex = 7
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
		Me._optBy_0.Text = "Default"
		Me._optBy_0.Size = New System.Drawing.Size(177, 17)
		Me._optBy_0.Location = New System.Drawing.Point(24, 16)
		Me._optBy_0.TabIndex = 6
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
		Me.medPrdFr.Location = New System.Drawing.Point(144, 88)
		Me.medPrdFr.TabIndex = 3
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(497, 217)
		Me.tblDetail.Location = New System.Drawing.Point(56, 184)
		Me.tblDetail.TabIndex = 8
		Me.tblDetail.Name = "tblDetail"
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(84, 16)
		Me.lblTitle.Location = New System.Drawing.Point(56, 41)
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
		Me.lblCusNoTo.Text = "To"
		Me.lblCusNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblCusNoTo.Location = New System.Drawing.Point(308, 64)
		Me.lblCusNoTo.TabIndex = 13
		Me.lblCusNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNoTo.Enabled = True
		Me.lblCusNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNoTo.UseMnemonic = True
		Me.lblCusNoTo.Visible = True
		Me.lblCusNoTo.AutoSize = False
		Me.lblCusNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNoTo.Name = "lblCusNoTo"
		Me.lblCusNoFr.Text = "Customer"
		Me.lblCusNoFr.Size = New System.Drawing.Size(86, 15)
		Me.lblCusNoFr.Location = New System.Drawing.Point(56, 64)
		Me.lblCusNoFr.TabIndex = 12
		Me.lblCusNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNoFr.Enabled = True
		Me.lblCusNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNoFr.UseMnemonic = True
		Me.lblCusNoFr.Visible = True
		Me.lblCusNoFr.AutoSize = False
		Me.lblCusNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNoFr.Name = "lblCusNoFr"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(86, 15)
		Me.lblPrdFr.Location = New System.Drawing.Point(56, 91)
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
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboCusNoTo)
		Me.Controls.Add(cboCusNoFr)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblCusNoTo)
		Me.Controls.Add(lblCusNoFr)
		Me.Controls.Add(lblPrdFr)
		Me.Frame2.Controls.Add(_optPrn_0)
		Me.Frame2.Controls.Add(_optPrn_1)
		Me.Frame1.Controls.Add(_optBy_1)
		Me.Frame1.Controls.Add(_optBy_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optBy.SetIndex(_optBy_1, CType(1, Short))
		Me.optBy.SetIndex(_optBy_0, CType(0, Short))
		Me.optPrn.SetIndex(_optPrn_0, CType(0, Short))
		Me.optPrn.SetIndex(_optPrn_1, CType(1, Short))
		CType(Me.optPrn, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class