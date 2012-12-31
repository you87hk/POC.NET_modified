<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSYS001
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
	Public WithEvents _optSyPStkVal_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optSyPStkVal_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optSyPStkVal_2 As System.Windows.Forms.RadioButton
	Public WithEvents FraSyPStkVal As System.Windows.Forms.GroupBox
	Public WithEvents txtSyPRecID As System.Windows.Forms.TextBox
	Public WithEvents txtSyPHisLog As System.Windows.Forms.TextBox
	Public WithEvents medSyPMinDte As System.Windows.Forms.MaskedTextBox
	Public WithEvents medSyPMaxDte As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblDspSyPLUpDte As System.Windows.Forms.Label
	Public WithEvents lblDspSyPLUpUsr As System.Windows.Forms.Label
	Public WithEvents lblSyPLUpDte As System.Windows.Forms.Label
	Public WithEvents lblSyPLUpUsr As System.Windows.Forms.Label
	Public WithEvents lblSyPMaxDte As System.Windows.Forms.Label
	Public WithEvents lblSyPMinDte As System.Windows.Forms.Label
	Public WithEvents lblSyPRecID As System.Windows.Forms.Label
	Public WithEvents lblSyPHisLog As System.Windows.Forms.Label
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
	Public WithEvents optSyPStkVal As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSYS001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.FraSyPStkVal = New System.Windows.Forms.GroupBox
		Me._optSyPStkVal_0 = New System.Windows.Forms.RadioButton
		Me._optSyPStkVal_1 = New System.Windows.Forms.RadioButton
		Me._optSyPStkVal_2 = New System.Windows.Forms.RadioButton
		Me.txtSyPRecID = New System.Windows.Forms.TextBox
		Me.txtSyPHisLog = New System.Windows.Forms.TextBox
		Me.medSyPMinDte = New System.Windows.Forms.MaskedTextBox
		Me.medSyPMaxDte = New System.Windows.Forms.MaskedTextBox
		Me.lblDspSyPLUpDte = New System.Windows.Forms.Label
		Me.lblDspSyPLUpUsr = New System.Windows.Forms.Label
		Me.lblSyPLUpDte = New System.Windows.Forms.Label
		Me.lblSyPLUpUsr = New System.Windows.Forms.Label
		Me.lblSyPMaxDte = New System.Windows.Forms.Label
		Me.lblSyPMinDte = New System.Windows.Forms.Label
		Me.lblSyPRecID = New System.Windows.Forms.Label
		Me.lblSyPHisLog = New System.Windows.Forms.Label
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
		Me.optSyPStkVal = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.FraSyPStkVal.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optSyPStkVal, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "系統設定"
		Me.ClientSize = New System.Drawing.Size(572, 278)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmSYS001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSYS001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 11
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.fraDetailInfo.Text = "系統設定"
		Me.fraDetailInfo.Size = New System.Drawing.Size(557, 249)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 7
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.FraSyPStkVal.Text = "SYPSTKVAL"
		Me.FraSyPStkVal.Size = New System.Drawing.Size(497, 57)
		Me.FraSyPStkVal.Location = New System.Drawing.Point(16, 96)
		Me.FraSyPStkVal.TabIndex = 14
		Me.FraSyPStkVal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FraSyPStkVal.BackColor = System.Drawing.SystemColors.Control
		Me.FraSyPStkVal.Enabled = True
		Me.FraSyPStkVal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FraSyPStkVal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FraSyPStkVal.Visible = True
		Me.FraSyPStkVal.Padding = New System.Windows.Forms.Padding(0)
		Me.FraSyPStkVal.Name = "FraSyPStkVal"
		Me._optSyPStkVal_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSyPStkVal_0.Text = "AVERAGECOST"
		Me._optSyPStkVal_0.Size = New System.Drawing.Size(105, 17)
		Me._optSyPStkVal_0.Location = New System.Drawing.Point(16, 24)
		Me._optSyPStkVal_0.TabIndex = 2
		Me._optSyPStkVal_0.Checked = True
		Me._optSyPStkVal_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSyPStkVal_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSyPStkVal_0.BackColor = System.Drawing.SystemColors.Control
		Me._optSyPStkVal_0.CausesValidation = True
		Me._optSyPStkVal_0.Enabled = True
		Me._optSyPStkVal_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSyPStkVal_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSyPStkVal_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSyPStkVal_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSyPStkVal_0.TabStop = True
		Me._optSyPStkVal_0.Visible = True
		Me._optSyPStkVal_0.Name = "_optSyPStkVal_0"
		Me._optSyPStkVal_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSyPStkVal_1.Text = "LASTPOCOST"
		Me._optSyPStkVal_1.Size = New System.Drawing.Size(113, 17)
		Me._optSyPStkVal_1.Location = New System.Drawing.Point(192, 24)
		Me._optSyPStkVal_1.TabIndex = 3
		Me._optSyPStkVal_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSyPStkVal_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSyPStkVal_1.BackColor = System.Drawing.SystemColors.Control
		Me._optSyPStkVal_1.CausesValidation = True
		Me._optSyPStkVal_1.Enabled = True
		Me._optSyPStkVal_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSyPStkVal_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSyPStkVal_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSyPStkVal_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSyPStkVal_1.TabStop = True
		Me._optSyPStkVal_1.Checked = False
		Me._optSyPStkVal_1.Visible = True
		Me._optSyPStkVal_1.Name = "_optSyPStkVal_1"
		Me._optSyPStkVal_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSyPStkVal_2.Text = "BYLOT"
		Me._optSyPStkVal_2.Size = New System.Drawing.Size(89, 17)
		Me._optSyPStkVal_2.Location = New System.Drawing.Point(392, 24)
		Me._optSyPStkVal_2.TabIndex = 4
		Me._optSyPStkVal_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optSyPStkVal_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optSyPStkVal_2.BackColor = System.Drawing.SystemColors.Control
		Me._optSyPStkVal_2.CausesValidation = True
		Me._optSyPStkVal_2.Enabled = True
		Me._optSyPStkVal_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optSyPStkVal_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optSyPStkVal_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optSyPStkVal_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optSyPStkVal_2.TabStop = True
		Me._optSyPStkVal_2.Checked = False
		Me._optSyPStkVal_2.Visible = True
		Me._optSyPStkVal_2.Name = "_optSyPStkVal_2"
		Me.txtSyPRecID.AutoSize = False
		Me.txtSyPRecID.Enabled = False
		Me.txtSyPRecID.Size = New System.Drawing.Size(182, 20)
		Me.txtSyPRecID.Location = New System.Drawing.Point(112, 40)
		Me.txtSyPRecID.TabIndex = 0
		Me.txtSyPRecID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSyPRecID.AcceptsReturn = True
		Me.txtSyPRecID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSyPRecID.BackColor = System.Drawing.SystemColors.Window
		Me.txtSyPRecID.CausesValidation = True
		Me.txtSyPRecID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSyPRecID.HideSelection = True
		Me.txtSyPRecID.ReadOnly = False
		Me.txtSyPRecID.Maxlength = 0
		Me.txtSyPRecID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSyPRecID.MultiLine = False
		Me.txtSyPRecID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSyPRecID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSyPRecID.TabStop = True
		Me.txtSyPRecID.Visible = True
		Me.txtSyPRecID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSyPRecID.Name = "txtSyPRecID"
		Me.txtSyPHisLog.AutoSize = False
		Me.txtSyPHisLog.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtSyPHisLog.Enabled = False
		Me.txtSyPHisLog.Size = New System.Drawing.Size(182, 20)
		Me.txtSyPHisLog.Location = New System.Drawing.Point(112, 64)
		Me.txtSyPHisLog.TabIndex = 1
		Me.txtSyPHisLog.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSyPHisLog.AcceptsReturn = True
		Me.txtSyPHisLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSyPHisLog.CausesValidation = True
		Me.txtSyPHisLog.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSyPHisLog.HideSelection = True
		Me.txtSyPHisLog.ReadOnly = False
		Me.txtSyPHisLog.Maxlength = 0
		Me.txtSyPHisLog.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSyPHisLog.MultiLine = False
		Me.txtSyPHisLog.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSyPHisLog.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSyPHisLog.TabStop = True
		Me.txtSyPHisLog.Visible = True
		Me.txtSyPHisLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSyPHisLog.Name = "txtSyPHisLog"
		Me.medSyPMinDte.AllowPromptAsInput = False
		Me.medSyPMinDte.Size = New System.Drawing.Size(81, 19)
		Me.medSyPMinDte.Location = New System.Drawing.Point(112, 160)
		Me.medSyPMinDte.TabIndex = 5
		Me.medSyPMinDte.MaxLength = 10
		Me.medSyPMinDte.Mask = "##/##/####"
		Me.medSyPMinDte.PromptChar = "_"
		Me.medSyPMinDte.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medSyPMinDte.Name = "medSyPMinDte"
		Me.medSyPMaxDte.AllowPromptAsInput = False
		Me.medSyPMaxDte.Size = New System.Drawing.Size(81, 19)
		Me.medSyPMaxDte.Location = New System.Drawing.Point(112, 184)
		Me.medSyPMaxDte.TabIndex = 6
		Me.medSyPMaxDte.MaxLength = 10
		Me.medSyPMaxDte.Mask = "##/##/####"
		Me.medSyPMaxDte.PromptChar = "_"
		Me.medSyPMaxDte.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medSyPMaxDte.Name = "medSyPMaxDte"
		Me.lblDspSyPLUpDte.Size = New System.Drawing.Size(151, 20)
		Me.lblDspSyPLUpDte.Location = New System.Drawing.Point(376, 216)
		Me.lblDspSyPLUpDte.TabIndex = 18
		Me.lblDspSyPLUpDte.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspSyPLUpDte.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspSyPLUpDte.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspSyPLUpDte.Enabled = True
		Me.lblDspSyPLUpDte.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspSyPLUpDte.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspSyPLUpDte.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspSyPLUpDte.UseMnemonic = True
		Me.lblDspSyPLUpDte.Visible = True
		Me.lblDspSyPLUpDte.AutoSize = False
		Me.lblDspSyPLUpDte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspSyPLUpDte.Name = "lblDspSyPLUpDte"
		Me.lblDspSyPLUpUsr.Size = New System.Drawing.Size(151, 20)
		Me.lblDspSyPLUpUsr.Location = New System.Drawing.Point(112, 216)
		Me.lblDspSyPLUpUsr.TabIndex = 17
		Me.lblDspSyPLUpUsr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspSyPLUpUsr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspSyPLUpUsr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspSyPLUpUsr.Enabled = True
		Me.lblDspSyPLUpUsr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspSyPLUpUsr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspSyPLUpUsr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspSyPLUpUsr.UseMnemonic = True
		Me.lblDspSyPLUpUsr.Visible = True
		Me.lblDspSyPLUpUsr.AutoSize = False
		Me.lblDspSyPLUpUsr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspSyPLUpUsr.Name = "lblDspSyPLUpUsr"
		Me.lblSyPLUpDte.Text = "SYPLUPDTE"
		Me.lblSyPLUpDte.Size = New System.Drawing.Size(92, 16)
		Me.lblSyPLUpDte.Location = New System.Drawing.Point(280, 219)
		Me.lblSyPLUpDte.TabIndex = 16
		Me.lblSyPLUpDte.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSyPLUpDte.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSyPLUpDte.BackColor = System.Drawing.SystemColors.Control
		Me.lblSyPLUpDte.Enabled = True
		Me.lblSyPLUpDte.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSyPLUpDte.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSyPLUpDte.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSyPLUpDte.UseMnemonic = True
		Me.lblSyPLUpDte.Visible = True
		Me.lblSyPLUpDte.AutoSize = False
		Me.lblSyPLUpDte.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSyPLUpDte.Name = "lblSyPLUpDte"
		Me.lblSyPLUpUsr.Text = "SYPLUPUSR"
		Me.lblSyPLUpUsr.Size = New System.Drawing.Size(92, 16)
		Me.lblSyPLUpUsr.Location = New System.Drawing.Point(24, 219)
		Me.lblSyPLUpUsr.TabIndex = 15
		Me.lblSyPLUpUsr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSyPLUpUsr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSyPLUpUsr.BackColor = System.Drawing.SystemColors.Control
		Me.lblSyPLUpUsr.Enabled = True
		Me.lblSyPLUpUsr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSyPLUpUsr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSyPLUpUsr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSyPLUpUsr.UseMnemonic = True
		Me.lblSyPLUpUsr.Visible = True
		Me.lblSyPLUpUsr.AutoSize = False
		Me.lblSyPLUpUsr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSyPLUpUsr.Name = "lblSyPLUpUsr"
		Me.lblSyPMaxDte.Text = "SYPMAXDTE"
		Me.lblSyPMaxDte.Size = New System.Drawing.Size(92, 16)
		Me.lblSyPMaxDte.Location = New System.Drawing.Point(24, 188)
		Me.lblSyPMaxDte.TabIndex = 13
		Me.lblSyPMaxDte.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSyPMaxDte.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSyPMaxDte.BackColor = System.Drawing.SystemColors.Control
		Me.lblSyPMaxDte.Enabled = True
		Me.lblSyPMaxDte.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSyPMaxDte.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSyPMaxDte.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSyPMaxDte.UseMnemonic = True
		Me.lblSyPMaxDte.Visible = True
		Me.lblSyPMaxDte.AutoSize = False
		Me.lblSyPMaxDte.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSyPMaxDte.Name = "lblSyPMaxDte"
		Me.lblSyPMinDte.Text = "SYPMINDTE"
		Me.lblSyPMinDte.Size = New System.Drawing.Size(92, 16)
		Me.lblSyPMinDte.Location = New System.Drawing.Point(24, 164)
		Me.lblSyPMinDte.TabIndex = 12
		Me.lblSyPMinDte.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSyPMinDte.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSyPMinDte.BackColor = System.Drawing.SystemColors.Control
		Me.lblSyPMinDte.Enabled = True
		Me.lblSyPMinDte.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSyPMinDte.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSyPMinDte.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSyPMinDte.UseMnemonic = True
		Me.lblSyPMinDte.Visible = True
		Me.lblSyPMinDte.AutoSize = False
		Me.lblSyPMinDte.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSyPMinDte.Name = "lblSyPMinDte"
		Me.lblSyPRecID.Text = "SYPRECID"
		Me.lblSyPRecID.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblSyPRecID.Size = New System.Drawing.Size(84, 16)
		Me.lblSyPRecID.Location = New System.Drawing.Point(24, 44)
		Me.lblSyPRecID.TabIndex = 10
		Me.lblSyPRecID.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSyPRecID.BackColor = System.Drawing.SystemColors.Control
		Me.lblSyPRecID.Enabled = True
		Me.lblSyPRecID.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSyPRecID.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSyPRecID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSyPRecID.UseMnemonic = True
		Me.lblSyPRecID.Visible = True
		Me.lblSyPRecID.AutoSize = False
		Me.lblSyPRecID.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSyPRecID.Name = "lblSyPRecID"
		Me.lblSyPHisLog.Text = "SYPHISLOG"
		Me.lblSyPHisLog.Size = New System.Drawing.Size(92, 16)
		Me.lblSyPHisLog.Location = New System.Drawing.Point(24, 68)
		Me.lblSyPHisLog.TabIndex = 9
		Me.lblSyPHisLog.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSyPHisLog.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSyPHisLog.BackColor = System.Drawing.SystemColors.Control
		Me.lblSyPHisLog.Enabled = True
		Me.lblSyPHisLog.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSyPHisLog.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSyPHisLog.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSyPHisLog.UseMnemonic = True
		Me.lblSyPHisLog.Visible = True
		Me.lblSyPHisLog.AutoSize = False
		Me.lblSyPHisLog.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSyPHisLog.Name = "lblSyPHisLog"
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
		Me.tbrProcess.TabIndex = 8
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
		Me._tbrProcess_Button2.Visible = 0
		Me._tbrProcess_Button2.Name = "Open"
		Me._tbrProcess_Button2.ToolTipText = "開新視窗 (F6)"
		Me._tbrProcess_Button2.ImageIndex = 11
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Visible = 0
		Me._tbrProcess_Button3.Name = "Add"
		Me._tbrProcess_Button3.ToolTipText = "新增 (F2)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Visible = 0
		Me._tbrProcess_Button4.Name = "Edit"
		Me._tbrProcess_Button4.ToolTipText = "修改 (F5)"
		Me._tbrProcess_Button4.ImageIndex = 1
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Visible = 0
		Me._tbrProcess_Button5.Name = "Delete"
		Me._tbrProcess_Button5.ToolTipText = "刪除 (F3)"
		Me._tbrProcess_Button5.ImageIndex = 2
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Visible = 0
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
		Me._tbrProcess_Button9.Visible = 0
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.Visible = 0
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
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(FraSyPStkVal)
		Me.fraDetailInfo.Controls.Add(txtSyPRecID)
		Me.fraDetailInfo.Controls.Add(txtSyPHisLog)
		Me.fraDetailInfo.Controls.Add(medSyPMinDte)
		Me.fraDetailInfo.Controls.Add(medSyPMaxDte)
		Me.fraDetailInfo.Controls.Add(lblDspSyPLUpDte)
		Me.fraDetailInfo.Controls.Add(lblDspSyPLUpUsr)
		Me.fraDetailInfo.Controls.Add(lblSyPLUpDte)
		Me.fraDetailInfo.Controls.Add(lblSyPLUpUsr)
		Me.fraDetailInfo.Controls.Add(lblSyPMaxDte)
		Me.fraDetailInfo.Controls.Add(lblSyPMinDte)
		Me.fraDetailInfo.Controls.Add(lblSyPRecID)
		Me.fraDetailInfo.Controls.Add(lblSyPHisLog)
		Me.FraSyPStkVal.Controls.Add(_optSyPStkVal_0)
		Me.FraSyPStkVal.Controls.Add(_optSyPStkVal_1)
		Me.FraSyPStkVal.Controls.Add(_optSyPStkVal_2)
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
		Me.optSyPStkVal.SetIndex(_optSyPStkVal_0, CType(0, Short))
		Me.optSyPStkVal.SetIndex(_optSyPStkVal_1, CType(1, Short))
		Me.optSyPStkVal.SetIndex(_optSyPStkVal_2, CType(2, Short))
		CType(Me.optSyPStkVal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.FraSyPStkVal.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class