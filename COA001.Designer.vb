<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCOA001
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
	Public WithEvents cboCOAAccCode As System.Windows.Forms.ComboBox
	Public WithEvents txtCOACDesc As System.Windows.Forms.TextBox
	Public WithEvents txtCOAConsCode As System.Windows.Forms.TextBox
	Public WithEvents _optCOAClass_5 As System.Windows.Forms.RadioButton
	Public WithEvents _optCOAClass_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optCOAClass_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optCOAClass_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optCOAClass_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optCOAClass_0 As System.Windows.Forms.RadioButton
	Public WithEvents FRAACCTYPE As System.Windows.Forms.GroupBox
	Public WithEvents txtCOADesc As System.Windows.Forms.TextBox
	Public WithEvents txtCOAAccCode As System.Windows.Forms.TextBox
	Public WithEvents lblCOAcDesc As System.Windows.Forms.Label
	Public WithEvents lblCOAConsCode As System.Windows.Forms.Label
	Public WithEvents lblCOAAccCode As System.Windows.Forms.Label
	Public WithEvents lblCOALastUpd As System.Windows.Forms.Label
	Public WithEvents lblCOaLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspCOALastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspCOALastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblCOADesc As System.Windows.Forms.Label
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
	Public WithEvents optCOAClass As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCOA001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboCOAAccCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.txtCOACDesc = New System.Windows.Forms.TextBox
		Me.txtCOAConsCode = New System.Windows.Forms.TextBox
		Me.FRAACCTYPE = New System.Windows.Forms.GroupBox
		Me._optCOAClass_5 = New System.Windows.Forms.RadioButton
		Me._optCOAClass_4 = New System.Windows.Forms.RadioButton
		Me._optCOAClass_3 = New System.Windows.Forms.RadioButton
		Me._optCOAClass_2 = New System.Windows.Forms.RadioButton
		Me._optCOAClass_1 = New System.Windows.Forms.RadioButton
		Me._optCOAClass_0 = New System.Windows.Forms.RadioButton
		Me.txtCOADesc = New System.Windows.Forms.TextBox
		Me.txtCOAAccCode = New System.Windows.Forms.TextBox
		Me.lblCOAcDesc = New System.Windows.Forms.Label
		Me.lblCOAConsCode = New System.Windows.Forms.Label
		Me.lblCOAAccCode = New System.Windows.Forms.Label
		Me.lblCOALastUpd = New System.Windows.Forms.Label
		Me.lblCOaLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspCOALastUpd = New System.Windows.Forms.Label
		Me.lblDspCOALastUpdDate = New System.Windows.Forms.Label
		Me.lblCOADesc = New System.Windows.Forms.Label
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
		Me.optCOAClass = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.FRAACCTYPE.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optCOAClass, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "COA001"
		Me.ClientSize = New System.Drawing.Size(593, 367)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmCOA001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmCOA001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 18
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboCOAAccCode.Size = New System.Drawing.Size(182, 20)
		Me.cboCOAAccCode.Location = New System.Drawing.Point(160, 64)
		Me.cboCOAAccCode.TabIndex = 1
		Me.cboCOAAccCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCOAAccCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCOAAccCode.CausesValidation = True
		Me.cboCOAAccCode.Enabled = True
		Me.cboCOAAccCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCOAAccCode.IntegralHeight = True
		Me.cboCOAAccCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCOAAccCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCOAAccCode.Sorted = False
		Me.cboCOAAccCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCOAAccCode.TabStop = True
		Me.cboCOAAccCode.Visible = True
		Me.cboCOAAccCode.Name = "cboCOAAccCode"
		Me.fraDetailInfo.Text = "FRADETAILINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(581, 337)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 11
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.txtCOACDesc.AutoSize = False
		Me.txtCOACDesc.Enabled = False
		Me.txtCOACDesc.Size = New System.Drawing.Size(414, 20)
		Me.txtCOACDesc.Location = New System.Drawing.Point(152, 200)
		Me.txtCOACDesc.TabIndex = 9
		Me.txtCOACDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCOACDesc.AcceptsReturn = True
		Me.txtCOACDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCOACDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtCOACDesc.CausesValidation = True
		Me.txtCOACDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCOACDesc.HideSelection = True
		Me.txtCOACDesc.ReadOnly = False
		Me.txtCOACDesc.Maxlength = 0
		Me.txtCOACDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCOACDesc.MultiLine = False
		Me.txtCOACDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCOACDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCOACDesc.TabStop = True
		Me.txtCOACDesc.Visible = True
		Me.txtCOACDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCOACDesc.Name = "txtCOACDesc"
		Me.txtCOAConsCode.AutoSize = False
		Me.txtCOAConsCode.Enabled = False
		Me.txtCOAConsCode.Size = New System.Drawing.Size(182, 20)
		Me.txtCOAConsCode.Location = New System.Drawing.Point(152, 232)
		Me.txtCOAConsCode.TabIndex = 10
		Me.txtCOAConsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCOAConsCode.AcceptsReturn = True
		Me.txtCOAConsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCOAConsCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtCOAConsCode.CausesValidation = True
		Me.txtCOAConsCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCOAConsCode.HideSelection = True
		Me.txtCOAConsCode.ReadOnly = False
		Me.txtCOAConsCode.Maxlength = 0
		Me.txtCOAConsCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCOAConsCode.MultiLine = False
		Me.txtCOAConsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCOAConsCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCOAConsCode.TabStop = True
		Me.txtCOAConsCode.Visible = True
		Me.txtCOAConsCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCOAConsCode.Name = "txtCOAConsCode"
		Me.FRAACCTYPE.Text = "ACCTYPE"
		Me.FRAACCTYPE.Size = New System.Drawing.Size(561, 89)
		Me.FRAACCTYPE.Location = New System.Drawing.Point(8, 72)
		Me.FRAACCTYPE.TabIndex = 20
		Me.FRAACCTYPE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FRAACCTYPE.BackColor = System.Drawing.SystemColors.Control
		Me.FRAACCTYPE.Enabled = True
		Me.FRAACCTYPE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FRAACCTYPE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FRAACCTYPE.Visible = True
		Me.FRAACCTYPE.Padding = New System.Windows.Forms.Padding(0)
		Me.FRAACCTYPE.Name = "FRAACCTYPE"
		Me._optCOAClass_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_5.Text = "SUSPEND"
		Me._optCOAClass_5.Size = New System.Drawing.Size(89, 17)
		Me._optCOAClass_5.Location = New System.Drawing.Point(392, 56)
		Me._optCOAClass_5.TabIndex = 7
		Me._optCOAClass_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCOAClass_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_5.BackColor = System.Drawing.SystemColors.Control
		Me._optCOAClass_5.CausesValidation = True
		Me._optCOAClass_5.Enabled = True
		Me._optCOAClass_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCOAClass_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCOAClass_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCOAClass_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCOAClass_5.TabStop = True
		Me._optCOAClass_5.Checked = False
		Me._optCOAClass_5.Visible = True
		Me._optCOAClass_5.Name = "_optCOAClass_5"
		Me._optCOAClass_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_4.Text = "EXPENSE"
		Me._optCOAClass_4.Size = New System.Drawing.Size(89, 17)
		Me._optCOAClass_4.Location = New System.Drawing.Point(192, 56)
		Me._optCOAClass_4.TabIndex = 6
		Me._optCOAClass_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCOAClass_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_4.BackColor = System.Drawing.SystemColors.Control
		Me._optCOAClass_4.CausesValidation = True
		Me._optCOAClass_4.Enabled = True
		Me._optCOAClass_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCOAClass_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCOAClass_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCOAClass_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCOAClass_4.TabStop = True
		Me._optCOAClass_4.Checked = False
		Me._optCOAClass_4.Visible = True
		Me._optCOAClass_4.Name = "_optCOAClass_4"
		Me._optCOAClass_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_3.Text = "REVENUE"
		Me._optCOAClass_3.Size = New System.Drawing.Size(81, 17)
		Me._optCOAClass_3.Location = New System.Drawing.Point(16, 56)
		Me._optCOAClass_3.TabIndex = 5
		Me._optCOAClass_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCOAClass_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_3.BackColor = System.Drawing.SystemColors.Control
		Me._optCOAClass_3.CausesValidation = True
		Me._optCOAClass_3.Enabled = True
		Me._optCOAClass_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCOAClass_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCOAClass_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCOAClass_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCOAClass_3.TabStop = True
		Me._optCOAClass_3.Checked = False
		Me._optCOAClass_3.Visible = True
		Me._optCOAClass_3.Name = "_optCOAClass_3"
		Me._optCOAClass_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_2.Text = "CAPITAL"
		Me._optCOAClass_2.Size = New System.Drawing.Size(89, 17)
		Me._optCOAClass_2.Location = New System.Drawing.Point(392, 24)
		Me._optCOAClass_2.TabIndex = 4
		Me._optCOAClass_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCOAClass_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_2.BackColor = System.Drawing.SystemColors.Control
		Me._optCOAClass_2.CausesValidation = True
		Me._optCOAClass_2.Enabled = True
		Me._optCOAClass_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCOAClass_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCOAClass_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCOAClass_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCOAClass_2.TabStop = True
		Me._optCOAClass_2.Checked = False
		Me._optCOAClass_2.Visible = True
		Me._optCOAClass_2.Name = "_optCOAClass_2"
		Me._optCOAClass_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_1.Text = "LIABILITY"
		Me._optCOAClass_1.Size = New System.Drawing.Size(89, 17)
		Me._optCOAClass_1.Location = New System.Drawing.Point(192, 24)
		Me._optCOAClass_1.TabIndex = 3
		Me._optCOAClass_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCOAClass_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_1.BackColor = System.Drawing.SystemColors.Control
		Me._optCOAClass_1.CausesValidation = True
		Me._optCOAClass_1.Enabled = True
		Me._optCOAClass_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCOAClass_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCOAClass_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCOAClass_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCOAClass_1.TabStop = True
		Me._optCOAClass_1.Checked = False
		Me._optCOAClass_1.Visible = True
		Me._optCOAClass_1.Name = "_optCOAClass_1"
		Me._optCOAClass_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_0.Text = "ASSET"
		Me._optCOAClass_0.Size = New System.Drawing.Size(81, 17)
		Me._optCOAClass_0.Location = New System.Drawing.Point(16, 24)
		Me._optCOAClass_0.TabIndex = 2
		Me._optCOAClass_0.Checked = True
		Me._optCOAClass_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCOAClass_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCOAClass_0.BackColor = System.Drawing.SystemColors.Control
		Me._optCOAClass_0.CausesValidation = True
		Me._optCOAClass_0.Enabled = True
		Me._optCOAClass_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCOAClass_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCOAClass_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCOAClass_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCOAClass_0.TabStop = True
		Me._optCOAClass_0.Visible = True
		Me._optCOAClass_0.Name = "_optCOAClass_0"
		Me.txtCOADesc.AutoSize = False
		Me.txtCOADesc.Enabled = False
		Me.txtCOADesc.Size = New System.Drawing.Size(414, 20)
		Me.txtCOADesc.Location = New System.Drawing.Point(152, 176)
		Me.txtCOADesc.TabIndex = 8
		Me.txtCOADesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCOADesc.AcceptsReturn = True
		Me.txtCOADesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCOADesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtCOADesc.CausesValidation = True
		Me.txtCOADesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCOADesc.HideSelection = True
		Me.txtCOADesc.ReadOnly = False
		Me.txtCOADesc.Maxlength = 0
		Me.txtCOADesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCOADesc.MultiLine = False
		Me.txtCOADesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCOADesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCOADesc.TabStop = True
		Me.txtCOADesc.Visible = True
		Me.txtCOADesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCOADesc.Name = "txtCOADesc"
		Me.txtCOAAccCode.AutoSize = False
		Me.txtCOAAccCode.Enabled = False
		Me.txtCOAAccCode.Size = New System.Drawing.Size(182, 20)
		Me.txtCOAAccCode.Location = New System.Drawing.Point(152, 40)
		Me.txtCOAAccCode.TabIndex = 0
		Me.txtCOAAccCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCOAAccCode.AcceptsReturn = True
		Me.txtCOAAccCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCOAAccCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtCOAAccCode.CausesValidation = True
		Me.txtCOAAccCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCOAAccCode.HideSelection = True
		Me.txtCOAAccCode.ReadOnly = False
		Me.txtCOAAccCode.Maxlength = 0
		Me.txtCOAAccCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCOAAccCode.MultiLine = False
		Me.txtCOAAccCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCOAAccCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCOAAccCode.TabStop = True
		Me.txtCOAAccCode.Visible = True
		Me.txtCOAAccCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCOAAccCode.Name = "txtCOAAccCode"
		Me.lblCOAcDesc.Text = "COADESC"
		Me.lblCOAcDesc.Size = New System.Drawing.Size(137, 17)
		Me.lblCOAcDesc.Location = New System.Drawing.Point(8, 204)
		Me.lblCOAcDesc.TabIndex = 22
		Me.lblCOAcDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCOAcDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOAcDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOAcDesc.Enabled = True
		Me.lblCOAcDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOAcDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOAcDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOAcDesc.UseMnemonic = True
		Me.lblCOAcDesc.Visible = True
		Me.lblCOAcDesc.AutoSize = False
		Me.lblCOAcDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOAcDesc.Name = "lblCOAcDesc"
		Me.lblCOAConsCode.Text = "COACONSCODE"
		Me.lblCOAConsCode.Size = New System.Drawing.Size(145, 17)
		Me.lblCOAConsCode.Location = New System.Drawing.Point(8, 236)
		Me.lblCOAConsCode.TabIndex = 21
		Me.lblCOAConsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCOAConsCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOAConsCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOAConsCode.Enabled = True
		Me.lblCOAConsCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOAConsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOAConsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOAConsCode.UseMnemonic = True
		Me.lblCOAConsCode.Visible = True
		Me.lblCOAConsCode.AutoSize = False
		Me.lblCOAConsCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOAConsCode.Name = "lblCOAConsCode"
		Me.lblCOAAccCode.Text = "COAACCCODE"
		Me.lblCOAAccCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblCOAAccCode.Size = New System.Drawing.Size(140, 16)
		Me.lblCOAAccCode.Location = New System.Drawing.Point(8, 45)
		Me.lblCOAAccCode.TabIndex = 19
		Me.lblCOAAccCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOAAccCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOAAccCode.Enabled = True
		Me.lblCOAAccCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOAAccCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOAAccCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOAAccCode.UseMnemonic = True
		Me.lblCOAAccCode.Visible = True
		Me.lblCOAAccCode.AutoSize = False
		Me.lblCOAAccCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOAAccCode.Name = "lblCOAAccCode"
		Me.lblCOALastUpd.Text = "COALASTUPD"
		Me.lblCOALastUpd.Size = New System.Drawing.Size(124, 16)
		Me.lblCOALastUpd.Location = New System.Drawing.Point(24, 307)
		Me.lblCOALastUpd.TabIndex = 17
		Me.lblCOALastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCOALastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOALastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOALastUpd.Enabled = True
		Me.lblCOALastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOALastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOALastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOALastUpd.UseMnemonic = True
		Me.lblCOALastUpd.Visible = True
		Me.lblCOALastUpd.AutoSize = False
		Me.lblCOALastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOALastUpd.Name = "lblCOALastUpd"
		Me.lblCOaLastUpdDate.Text = "COALASTUPDDATE"
		Me.lblCOaLastUpdDate.Size = New System.Drawing.Size(132, 16)
		Me.lblCOaLastUpdDate.Location = New System.Drawing.Point(288, 307)
		Me.lblCOaLastUpdDate.TabIndex = 16
		Me.lblCOaLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCOaLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOaLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOaLastUpdDate.Enabled = True
		Me.lblCOaLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOaLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOaLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOaLastUpdDate.UseMnemonic = True
		Me.lblCOaLastUpdDate.Visible = True
		Me.lblCOaLastUpdDate.AutoSize = False
		Me.lblCOaLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOaLastUpdDate.Name = "lblCOaLastUpdDate"
		Me.lblDspCOALastUpd.Size = New System.Drawing.Size(127, 20)
		Me.lblDspCOALastUpd.Location = New System.Drawing.Point(152, 304)
		Me.lblDspCOALastUpd.TabIndex = 15
		Me.lblDspCOALastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCOALastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCOALastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCOALastUpd.Enabled = True
		Me.lblDspCOALastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCOALastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCOALastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCOALastUpd.UseMnemonic = True
		Me.lblDspCOALastUpd.Visible = True
		Me.lblDspCOALastUpd.AutoSize = False
		Me.lblDspCOALastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCOALastUpd.Name = "lblDspCOALastUpd"
		Me.lblDspCOALastUpdDate.Size = New System.Drawing.Size(111, 20)
		Me.lblDspCOALastUpdDate.Location = New System.Drawing.Point(432, 304)
		Me.lblDspCOALastUpdDate.TabIndex = 14
		Me.lblDspCOALastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCOALastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCOALastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCOALastUpdDate.Enabled = True
		Me.lblDspCOALastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCOALastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCOALastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCOALastUpdDate.UseMnemonic = True
		Me.lblDspCOALastUpdDate.Visible = True
		Me.lblDspCOALastUpdDate.AutoSize = False
		Me.lblDspCOALastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCOALastUpdDate.Name = "lblDspCOALastUpdDate"
		Me.lblCOADesc.Text = "COADESC"
		Me.lblCOADesc.Size = New System.Drawing.Size(145, 17)
		Me.lblCOADesc.Location = New System.Drawing.Point(8, 180)
		Me.lblCOADesc.TabIndex = 13
		Me.lblCOADesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCOADesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCOADesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblCOADesc.Enabled = True
		Me.lblCOADesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCOADesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCOADesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCOADesc.UseMnemonic = True
		Me.lblCOADesc.Visible = True
		Me.lblCOADesc.AutoSize = False
		Me.lblCOADesc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCOADesc.Name = "lblCOADesc"
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
		Me.tbrProcess.Size = New System.Drawing.Size(593, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 12
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
		Me.Controls.Add(cboCOAAccCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(txtCOACDesc)
		Me.fraDetailInfo.Controls.Add(txtCOAConsCode)
		Me.fraDetailInfo.Controls.Add(FRAACCTYPE)
		Me.fraDetailInfo.Controls.Add(txtCOADesc)
		Me.fraDetailInfo.Controls.Add(txtCOAAccCode)
		Me.fraDetailInfo.Controls.Add(lblCOAcDesc)
		Me.fraDetailInfo.Controls.Add(lblCOAConsCode)
		Me.fraDetailInfo.Controls.Add(lblCOAAccCode)
		Me.fraDetailInfo.Controls.Add(lblCOALastUpd)
		Me.fraDetailInfo.Controls.Add(lblCOaLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspCOALastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspCOALastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblCOADesc)
		Me.FRAACCTYPE.Controls.Add(_optCOAClass_5)
		Me.FRAACCTYPE.Controls.Add(_optCOAClass_4)
		Me.FRAACCTYPE.Controls.Add(_optCOAClass_3)
		Me.FRAACCTYPE.Controls.Add(_optCOAClass_2)
		Me.FRAACCTYPE.Controls.Add(_optCOAClass_1)
		Me.FRAACCTYPE.Controls.Add(_optCOAClass_0)
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
		Me.optCOAClass.SetIndex(_optCOAClass_5, CType(5, Short))
		Me.optCOAClass.SetIndex(_optCOAClass_4, CType(4, Short))
		Me.optCOAClass.SetIndex(_optCOAClass_3, CType(3, Short))
		Me.optCOAClass.SetIndex(_optCOAClass_2, CType(2, Short))
		Me.optCOAClass.SetIndex(_optCOAClass_1, CType(1, Short))
		Me.optCOAClass.SetIndex(_optCOAClass_0, CType(0, Short))
		CType(Me.optCOAClass, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.FRAACCTYPE.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class