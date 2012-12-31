<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPYT001
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
	Public WithEvents cboPayCode As System.Windows.Forms.ComboBox
	Public WithEvents txtPayDay As System.Windows.Forms.TextBox
	Public WithEvents _optBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents txtPayClsDay As System.Windows.Forms.TextBox
	Public WithEvents txtPayInvDay As System.Windows.Forms.TextBox
	Public WithEvents txtPayMonth As System.Windows.Forms.TextBox
	Public WithEvents txtPayCode As System.Windows.Forms.TextBox
	Public WithEvents txtPayDesc As System.Windows.Forms.TextBox
	Public WithEvents lblPayDay As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblPayMonth As System.Windows.Forms.Label
	Public WithEvents lblPayInvDay As System.Windows.Forms.Label
	Public WithEvents lblPayClsDay As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents lblPayMethod As System.Windows.Forms.Label
	Public WithEvents lblPayLastUpd As System.Windows.Forms.Label
	Public WithEvents lblPayLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspPayLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspPayLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblPayCode As System.Windows.Forms.Label
	Public WithEvents lblPayDesc As System.Windows.Forms.Label
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
	Public WithEvents optBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPYT001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboPayCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtPayDay = New System.Windows.Forms.TextBox
		Me._optBy_1 = New System.Windows.Forms.RadioButton
		Me._optBy_0 = New System.Windows.Forms.RadioButton
		Me.txtPayClsDay = New System.Windows.Forms.TextBox
		Me.txtPayInvDay = New System.Windows.Forms.TextBox
		Me.txtPayMonth = New System.Windows.Forms.TextBox
		Me.txtPayCode = New System.Windows.Forms.TextBox
		Me.txtPayDesc = New System.Windows.Forms.TextBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblPayDay = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.lblPayMonth = New System.Windows.Forms.Label
		Me.lblPayInvDay = New System.Windows.Forms.Label
		Me.lblPayClsDay = New System.Windows.Forms.Label
		Me.lblPayMethod = New System.Windows.Forms.Label
		Me.lblPayLastUpd = New System.Windows.Forms.Label
		Me.lblPayLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspPayLastUpd = New System.Windows.Forms.Label
		Me.lblDspPayLastUpdDate = New System.Windows.Forms.Label
		Me.lblPayCode = New System.Windows.Forms.Label
		Me.lblPayDesc = New System.Windows.Forms.Label
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
		Me.optBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "付款條款"
		Me.ClientSize = New System.Drawing.Size(572, 262)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmPYT001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPYT001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 17
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboPayCode.Size = New System.Drawing.Size(182, 20)
		Me.cboPayCode.Location = New System.Drawing.Point(120, 48)
		Me.cboPayCode.TabIndex = 0
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
		Me.fraDetailInfo.Text = "FRADETAILINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 233)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 9
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtPayDay.AutoSize = False
		Me.txtPayDay.Enabled = False
		Me.txtPayDay.Size = New System.Drawing.Size(59, 20)
		Me.txtPayDay.Location = New System.Drawing.Point(216, 111)
		Me.txtPayDay.TabIndex = 4
		Me.txtPayDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayDay.AcceptsReturn = True
		Me.txtPayDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayDay.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayDay.CausesValidation = True
		Me.txtPayDay.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayDay.HideSelection = True
		Me.txtPayDay.ReadOnly = False
		Me.txtPayDay.Maxlength = 0
		Me.txtPayDay.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayDay.MultiLine = False
		Me.txtPayDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayDay.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayDay.TabStop = True
		Me.txtPayDay.Visible = True
		Me.txtPayDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayDay.Name = "txtPayDay"
		Me._optBy_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optBy_1.Text = "BYMONTH"
		Me._optBy_1.Size = New System.Drawing.Size(89, 17)
		Me._optBy_1.Location = New System.Drawing.Point(16, 147)
		Me._optBy_1.TabIndex = 3
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
		Me._optBy_0.Text = "BYDAY"
		Me._optBy_0.Size = New System.Drawing.Size(81, 17)
		Me._optBy_0.Location = New System.Drawing.Point(16, 112)
		Me._optBy_0.TabIndex = 2
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
		Me.txtPayClsDay.AutoSize = False
		Me.txtPayClsDay.Enabled = False
		Me.txtPayClsDay.Size = New System.Drawing.Size(59, 20)
		Me.txtPayClsDay.Location = New System.Drawing.Point(480, 146)
		Me.txtPayClsDay.TabIndex = 6
		Me.txtPayClsDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayClsDay.AcceptsReturn = True
		Me.txtPayClsDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayClsDay.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayClsDay.CausesValidation = True
		Me.txtPayClsDay.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayClsDay.HideSelection = True
		Me.txtPayClsDay.ReadOnly = False
		Me.txtPayClsDay.Maxlength = 0
		Me.txtPayClsDay.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayClsDay.MultiLine = False
		Me.txtPayClsDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayClsDay.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayClsDay.TabStop = True
		Me.txtPayClsDay.Visible = True
		Me.txtPayClsDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayClsDay.Name = "txtPayClsDay"
		Me.txtPayInvDay.AutoSize = False
		Me.txtPayInvDay.Enabled = False
		Me.txtPayInvDay.Size = New System.Drawing.Size(59, 20)
		Me.txtPayInvDay.Location = New System.Drawing.Point(480, 170)
		Me.txtPayInvDay.TabIndex = 7
		Me.txtPayInvDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayInvDay.AcceptsReturn = True
		Me.txtPayInvDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayInvDay.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayInvDay.CausesValidation = True
		Me.txtPayInvDay.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayInvDay.HideSelection = True
		Me.txtPayInvDay.ReadOnly = False
		Me.txtPayInvDay.Maxlength = 0
		Me.txtPayInvDay.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayInvDay.MultiLine = False
		Me.txtPayInvDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayInvDay.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayInvDay.TabStop = True
		Me.txtPayInvDay.Visible = True
		Me.txtPayInvDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayInvDay.Name = "txtPayInvDay"
		Me.txtPayMonth.AutoSize = False
		Me.txtPayMonth.Enabled = False
		Me.txtPayMonth.Size = New System.Drawing.Size(59, 20)
		Me.txtPayMonth.Location = New System.Drawing.Point(216, 146)
		Me.txtPayMonth.TabIndex = 5
		Me.txtPayMonth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayMonth.AcceptsReturn = True
		Me.txtPayMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayMonth.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayMonth.CausesValidation = True
		Me.txtPayMonth.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayMonth.HideSelection = True
		Me.txtPayMonth.ReadOnly = False
		Me.txtPayMonth.Maxlength = 0
		Me.txtPayMonth.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayMonth.MultiLine = False
		Me.txtPayMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayMonth.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayMonth.TabStop = True
		Me.txtPayMonth.Visible = True
		Me.txtPayMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayMonth.Name = "txtPayMonth"
		Me.txtPayCode.AutoSize = False
		Me.txtPayCode.Size = New System.Drawing.Size(182, 20)
		Me.txtPayCode.Location = New System.Drawing.Point(112, 24)
		Me.txtPayCode.TabIndex = 8
		Me.txtPayCode.Tag = "K"
		Me.txtPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayCode.AcceptsReturn = True
		Me.txtPayCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtPayCode.CausesValidation = True
		Me.txtPayCode.Enabled = True
		Me.txtPayCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayCode.HideSelection = True
		Me.txtPayCode.ReadOnly = False
		Me.txtPayCode.Maxlength = 0
		Me.txtPayCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayCode.MultiLine = False
		Me.txtPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayCode.TabStop = True
		Me.txtPayCode.Visible = True
		Me.txtPayCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayCode.Name = "txtPayCode"
		Me.txtPayDesc.AutoSize = False
		Me.txtPayDesc.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtPayDesc.Enabled = False
		Me.txtPayDesc.Size = New System.Drawing.Size(433, 20)
		Me.txtPayDesc.Location = New System.Drawing.Point(112, 48)
		Me.txtPayDesc.TabIndex = 1
		Me.txtPayDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPayDesc.AcceptsReturn = True
		Me.txtPayDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPayDesc.CausesValidation = True
		Me.txtPayDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPayDesc.HideSelection = True
		Me.txtPayDesc.ReadOnly = False
		Me.txtPayDesc.Maxlength = 0
		Me.txtPayDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPayDesc.MultiLine = False
		Me.txtPayDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPayDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPayDesc.TabStop = True
		Me.txtPayDesc.Visible = True
		Me.txtPayDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPayDesc.Name = "txtPayDesc"
		Me.Frame1.Size = New System.Drawing.Size(540, 41)
		Me.Frame1.Location = New System.Drawing.Point(8, 96)
		Me.Frame1.TabIndex = 19
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.lblPayDay.Text = "PAYDAY"
		Me.lblPayDay.Size = New System.Drawing.Size(81, 17)
		Me.lblPayDay.Location = New System.Drawing.Point(104, 19)
		Me.lblPayDay.TabIndex = 24
		Me.lblPayDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayDay.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayDay.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayDay.Enabled = True
		Me.lblPayDay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayDay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayDay.UseMnemonic = True
		Me.lblPayDay.Visible = True
		Me.lblPayDay.AutoSize = False
		Me.lblPayDay.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayDay.Name = "lblPayDay"
		Me.Frame2.Size = New System.Drawing.Size(540, 65)
		Me.Frame2.Location = New System.Drawing.Point(8, 128)
		Me.Frame2.TabIndex = 20
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.lblPayMonth.Text = "PAYMONTH"
		Me.lblPayMonth.Size = New System.Drawing.Size(81, 17)
		Me.lblPayMonth.Location = New System.Drawing.Point(104, 21)
		Me.lblPayMonth.TabIndex = 23
		Me.lblPayMonth.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayMonth.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayMonth.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayMonth.Enabled = True
		Me.lblPayMonth.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayMonth.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayMonth.UseMnemonic = True
		Me.lblPayMonth.Visible = True
		Me.lblPayMonth.AutoSize = False
		Me.lblPayMonth.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayMonth.Name = "lblPayMonth"
		Me.lblPayInvDay.Text = "PAYINVDAY"
		Me.lblPayInvDay.Size = New System.Drawing.Size(105, 17)
		Me.lblPayInvDay.Location = New System.Drawing.Point(360, 44)
		Me.lblPayInvDay.TabIndex = 22
		Me.lblPayInvDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayInvDay.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayInvDay.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayInvDay.Enabled = True
		Me.lblPayInvDay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayInvDay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayInvDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayInvDay.UseMnemonic = True
		Me.lblPayInvDay.Visible = True
		Me.lblPayInvDay.AutoSize = False
		Me.lblPayInvDay.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayInvDay.Name = "lblPayInvDay"
		Me.lblPayClsDay.Text = "PAYCLSDAY"
		Me.lblPayClsDay.Size = New System.Drawing.Size(105, 17)
		Me.lblPayClsDay.Location = New System.Drawing.Point(360, 21)
		Me.lblPayClsDay.TabIndex = 21
		Me.lblPayClsDay.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayClsDay.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayClsDay.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayClsDay.Enabled = True
		Me.lblPayClsDay.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayClsDay.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayClsDay.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayClsDay.UseMnemonic = True
		Me.lblPayClsDay.Visible = True
		Me.lblPayClsDay.AutoSize = False
		Me.lblPayClsDay.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayClsDay.Name = "lblPayClsDay"
		Me.lblPayMethod.Text = "PAYMETHOD"
		Me.lblPayMethod.Size = New System.Drawing.Size(81, 17)
		Me.lblPayMethod.Location = New System.Drawing.Point(24, 80)
		Me.lblPayMethod.TabIndex = 18
		Me.lblPayMethod.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayMethod.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayMethod.Enabled = True
		Me.lblPayMethod.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayMethod.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayMethod.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayMethod.UseMnemonic = True
		Me.lblPayMethod.Visible = True
		Me.lblPayMethod.AutoSize = False
		Me.lblPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayMethod.Name = "lblPayMethod"
		Me.lblPayLastUpd.Text = "PAYLASTUPD"
		Me.lblPayLastUpd.Size = New System.Drawing.Size(116, 16)
		Me.lblPayLastUpd.Location = New System.Drawing.Point(24, 203)
		Me.lblPayLastUpd.TabIndex = 15
		Me.lblPayLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayLastUpd.Enabled = True
		Me.lblPayLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayLastUpd.UseMnemonic = True
		Me.lblPayLastUpd.Visible = True
		Me.lblPayLastUpd.AutoSize = False
		Me.lblPayLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayLastUpd.Name = "lblPayLastUpd"
		Me.lblPayLastUpdDate.Text = "PAYLASTUPDDATE"
		Me.lblPayLastUpdDate.Size = New System.Drawing.Size(108, 16)
		Me.lblPayLastUpdDate.Location = New System.Drawing.Point(288, 203)
		Me.lblPayLastUpdDate.TabIndex = 14
		Me.lblPayLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayLastUpdDate.Enabled = True
		Me.lblPayLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayLastUpdDate.UseMnemonic = True
		Me.lblPayLastUpdDate.Visible = True
		Me.lblPayLastUpdDate.AutoSize = False
		Me.lblPayLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayLastUpdDate.Name = "lblPayLastUpdDate"
		Me.lblDspPayLastUpd.Size = New System.Drawing.Size(135, 20)
		Me.lblDspPayLastUpd.Location = New System.Drawing.Point(144, 200)
		Me.lblDspPayLastUpd.TabIndex = 13
		Me.lblDspPayLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPayLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPayLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPayLastUpd.Enabled = True
		Me.lblDspPayLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPayLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPayLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPayLastUpd.UseMnemonic = True
		Me.lblDspPayLastUpd.Visible = True
		Me.lblDspPayLastUpd.AutoSize = False
		Me.lblDspPayLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPayLastUpd.Name = "lblDspPayLastUpd"
		Me.lblDspPayLastUpdDate.Size = New System.Drawing.Size(143, 20)
		Me.lblDspPayLastUpdDate.Location = New System.Drawing.Point(400, 200)
		Me.lblDspPayLastUpdDate.TabIndex = 12
		Me.lblDspPayLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspPayLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspPayLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspPayLastUpdDate.Enabled = True
		Me.lblDspPayLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspPayLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspPayLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspPayLastUpdDate.UseMnemonic = True
		Me.lblDspPayLastUpdDate.Visible = True
		Me.lblDspPayLastUpdDate.AutoSize = False
		Me.lblDspPayLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspPayLastUpdDate.Name = "lblDspPayLastUpdDate"
		Me.lblPayCode.Text = "PAYCODE"
		Me.lblPayCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblPayCode.Size = New System.Drawing.Size(84, 16)
		Me.lblPayCode.Location = New System.Drawing.Point(24, 28)
		Me.lblPayCode.TabIndex = 11
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
		Me.lblPayDesc.Text = "PAYDESC"
		Me.lblPayDesc.Size = New System.Drawing.Size(92, 16)
		Me.lblPayDesc.Location = New System.Drawing.Point(24, 52)
		Me.lblPayDesc.TabIndex = 10
		Me.lblPayDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPayDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPayDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblPayDesc.Enabled = True
		Me.lblPayDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPayDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPayDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPayDesc.UseMnemonic = True
		Me.lblPayDesc.Visible = True
		Me.lblPayDesc.AutoSize = False
		Me.lblPayDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPayDesc.Name = "lblPayDesc"
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
		Me.tbrProcess.Size = New System.Drawing.Size(572, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 16
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
		Me.Controls.Add(cboPayCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtPayDay)
		Me.fraDetailInfo.Controls.Add(_optBy_1)
		Me.fraDetailInfo.Controls.Add(_optBy_0)
		Me.fraDetailInfo.Controls.Add(txtPayClsDay)
		Me.fraDetailInfo.Controls.Add(txtPayInvDay)
		Me.fraDetailInfo.Controls.Add(txtPayMonth)
		Me.fraDetailInfo.Controls.Add(txtPayCode)
		Me.fraDetailInfo.Controls.Add(txtPayDesc)
		Me.fraDetailInfo.Controls.Add(Frame1)
		Me.fraDetailInfo.Controls.Add(Frame2)
		Me.fraDetailInfo.Controls.Add(lblPayMethod)
		Me.fraDetailInfo.Controls.Add(lblPayLastUpd)
		Me.fraDetailInfo.Controls.Add(lblPayLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspPayLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspPayLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblPayCode)
		Me.fraDetailInfo.Controls.Add(lblPayDesc)
		Me.Frame1.Controls.Add(lblPayDay)
		Me.Frame2.Controls.Add(lblPayMonth)
		Me.Frame2.Controls.Add(lblPayInvDay)
		Me.Frame2.Controls.Add(lblPayClsDay)
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
		Me.optBy.SetIndex(_optBy_1, CType(1, Short))
		Me.optBy.SetIndex(_optBy_0, CType(0, Short))
		CType(Me.optBy, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class