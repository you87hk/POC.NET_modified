<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSHP001
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
	Public WithEvents cboShipCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCardCode As System.Windows.Forms.ComboBox
	Public WithEvents _optCard_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optCard_1 As System.Windows.Forms.RadioButton
	Public WithEvents txtShipRemark As System.Windows.Forms.TextBox
	Public WithEvents txtShipper As System.Windows.Forms.TextBox
	Public WithEvents txtShipFaxNo As System.Windows.Forms.TextBox
	Public WithEvents txtShipTelNo As System.Windows.Forms.TextBox
	Public WithEvents txtShipCode As System.Windows.Forms.TextBox
	Public WithEvents txtShipName As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtShipAdr_4 As System.Windows.Forms.TextBox
	Public WithEvents picShipAdr As System.Windows.Forms.Panel
	Public WithEvents lblCardCode As System.Windows.Forms.Label
	Public WithEvents lblShipRemark As System.Windows.Forms.Label
	Public WithEvents lblShipper As System.Windows.Forms.Label
	Public WithEvents lblShipFaxNo As System.Windows.Forms.Label
	Public WithEvents lblShipTelNo As System.Windows.Forms.Label
	Public WithEvents lblShipLastUpd As System.Windows.Forms.Label
	Public WithEvents lblShipLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspShipLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspShipLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblShipCode As System.Windows.Forms.Label
	Public WithEvents lblShipAdr As System.Windows.Forms.Label
	Public WithEvents lblShipName As System.Windows.Forms.Label
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
	Public WithEvents optCard As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents txtShipAdr As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSHP001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboShipCode = New System.Windows.Forms.ComboBox
		Me.fraDetailInfo = New System.Windows.Forms.GroupBox
		Me.cboCardCode = New System.Windows.Forms.ComboBox
		Me._optCard_0 = New System.Windows.Forms.RadioButton
		Me._optCard_1 = New System.Windows.Forms.RadioButton
		Me.txtShipRemark = New System.Windows.Forms.TextBox
		Me.txtShipper = New System.Windows.Forms.TextBox
		Me.txtShipFaxNo = New System.Windows.Forms.TextBox
		Me.txtShipTelNo = New System.Windows.Forms.TextBox
		Me.txtShipCode = New System.Windows.Forms.TextBox
		Me.txtShipName = New System.Windows.Forms.TextBox
		Me.picShipAdr = New System.Windows.Forms.Panel
		Me._txtShipAdr_1 = New System.Windows.Forms.TextBox
		Me._txtShipAdr_2 = New System.Windows.Forms.TextBox
		Me._txtShipAdr_3 = New System.Windows.Forms.TextBox
		Me._txtShipAdr_4 = New System.Windows.Forms.TextBox
		Me.lblCardCode = New System.Windows.Forms.Label
		Me.lblShipRemark = New System.Windows.Forms.Label
		Me.lblShipper = New System.Windows.Forms.Label
		Me.lblShipFaxNo = New System.Windows.Forms.Label
		Me.lblShipTelNo = New System.Windows.Forms.Label
		Me.lblShipLastUpd = New System.Windows.Forms.Label
		Me.lblShipLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspShipLastUpd = New System.Windows.Forms.Label
		Me.lblDspShipLastUpdDate = New System.Windows.Forms.Label
		Me.lblShipCode = New System.Windows.Forms.Label
		Me.lblShipAdr = New System.Windows.Forms.Label
		Me.lblShipName = New System.Windows.Forms.Label
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
		Me.optCard = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.txtShipAdr = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.fraDetailInfo.SuspendLayout()
		Me.picShipAdr.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optCard, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipAdr, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "SHP001"
		Me.ClientSize = New System.Drawing.Size(593, 367)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmSHP001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSHP001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(672, 32)
		Me.tblCommon.TabIndex = 23
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboShipCode.Size = New System.Drawing.Size(182, 20)
		Me.cboShipCode.Location = New System.Drawing.Point(120, 88)
		Me.cboShipCode.TabIndex = 3
		Me.cboShipCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboShipCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboShipCode.CausesValidation = True
		Me.cboShipCode.Enabled = True
		Me.cboShipCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboShipCode.IntegralHeight = True
		Me.cboShipCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboShipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboShipCode.Sorted = False
		Me.cboShipCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboShipCode.TabStop = True
		Me.cboShipCode.Visible = True
		Me.cboShipCode.Name = "cboShipCode"
		Me.fraDetailInfo.Text = "FRADETAILINFO"
		Me.fraDetailInfo.Size = New System.Drawing.Size(581, 337)
		Me.fraDetailInfo.Location = New System.Drawing.Point(8, 24)
		Me.fraDetailInfo.TabIndex = 14
		Me.fraDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraDetailInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetailInfo.Enabled = True
		Me.fraDetailInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetailInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetailInfo.Visible = True
		Me.fraDetailInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetailInfo.Name = "fraDetailInfo"
		Me.cboCardCode.Size = New System.Drawing.Size(182, 20)
		Me.cboCardCode.Location = New System.Drawing.Point(112, 40)
		Me.cboCardCode.TabIndex = 2
		Me.cboCardCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCardCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCardCode.CausesValidation = True
		Me.cboCardCode.Enabled = True
		Me.cboCardCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCardCode.IntegralHeight = True
		Me.cboCardCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCardCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCardCode.Sorted = False
		Me.cboCardCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCardCode.TabStop = True
		Me.cboCardCode.Visible = True
		Me.cboCardCode.Name = "cboCardCode"
		Me._optCard_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCard_0.Text = "CARDVDR"
		Me._optCard_0.Size = New System.Drawing.Size(81, 17)
		Me._optCard_0.Location = New System.Drawing.Point(24, 16)
		Me._optCard_0.TabIndex = 0
		Me._optCard_0.Checked = True
		Me._optCard_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCard_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCard_0.BackColor = System.Drawing.SystemColors.Control
		Me._optCard_0.CausesValidation = True
		Me._optCard_0.Enabled = True
		Me._optCard_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCard_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCard_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCard_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCard_0.TabStop = True
		Me._optCard_0.Visible = True
		Me._optCard_0.Name = "_optCard_0"
		Me._optCard_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCard_1.Text = "CARDCUS"
		Me._optCard_1.Size = New System.Drawing.Size(89, 17)
		Me._optCard_1.Location = New System.Drawing.Point(200, 16)
		Me._optCard_1.TabIndex = 1
		Me._optCard_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optCard_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCard_1.BackColor = System.Drawing.SystemColors.Control
		Me._optCard_1.CausesValidation = True
		Me._optCard_1.Enabled = True
		Me._optCard_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optCard_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optCard_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optCard_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optCard_1.TabStop = True
		Me._optCard_1.Checked = False
		Me._optCard_1.Visible = True
		Me._optCard_1.Name = "_optCard_1"
		Me.txtShipRemark.AutoSize = False
		Me.txtShipRemark.Enabled = False
		Me.txtShipRemark.Size = New System.Drawing.Size(462, 20)
		Me.txtShipRemark.Location = New System.Drawing.Point(112, 264)
		Me.txtShipRemark.TabIndex = 13
		Me.txtShipRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipRemark.AcceptsReturn = True
		Me.txtShipRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipRemark.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipRemark.CausesValidation = True
		Me.txtShipRemark.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipRemark.HideSelection = True
		Me.txtShipRemark.ReadOnly = False
		Me.txtShipRemark.Maxlength = 0
		Me.txtShipRemark.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipRemark.MultiLine = False
		Me.txtShipRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipRemark.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipRemark.TabStop = True
		Me.txtShipRemark.Visible = True
		Me.txtShipRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipRemark.Name = "txtShipRemark"
		Me.txtShipper.AutoSize = False
		Me.txtShipper.Enabled = False
		Me.txtShipper.Size = New System.Drawing.Size(182, 20)
		Me.txtShipper.Location = New System.Drawing.Point(112, 240)
		Me.txtShipper.TabIndex = 12
		Me.txtShipper.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipper.AcceptsReturn = True
		Me.txtShipper.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipper.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipper.CausesValidation = True
		Me.txtShipper.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipper.HideSelection = True
		Me.txtShipper.ReadOnly = False
		Me.txtShipper.Maxlength = 0
		Me.txtShipper.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipper.MultiLine = False
		Me.txtShipper.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipper.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipper.TabStop = True
		Me.txtShipper.Visible = True
		Me.txtShipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipper.Name = "txtShipper"
		Me.txtShipFaxNo.AutoSize = False
		Me.txtShipFaxNo.Enabled = False
		Me.txtShipFaxNo.Size = New System.Drawing.Size(182, 20)
		Me.txtShipFaxNo.Location = New System.Drawing.Point(392, 216)
		Me.txtShipFaxNo.TabIndex = 11
		Me.txtShipFaxNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipFaxNo.AcceptsReturn = True
		Me.txtShipFaxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipFaxNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipFaxNo.CausesValidation = True
		Me.txtShipFaxNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipFaxNo.HideSelection = True
		Me.txtShipFaxNo.ReadOnly = False
		Me.txtShipFaxNo.Maxlength = 0
		Me.txtShipFaxNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipFaxNo.MultiLine = False
		Me.txtShipFaxNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipFaxNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipFaxNo.TabStop = True
		Me.txtShipFaxNo.Visible = True
		Me.txtShipFaxNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipFaxNo.Name = "txtShipFaxNo"
		Me.txtShipTelNo.AutoSize = False
		Me.txtShipTelNo.Enabled = False
		Me.txtShipTelNo.Size = New System.Drawing.Size(182, 20)
		Me.txtShipTelNo.Location = New System.Drawing.Point(112, 216)
		Me.txtShipTelNo.TabIndex = 10
		Me.txtShipTelNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipTelNo.AcceptsReturn = True
		Me.txtShipTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipTelNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipTelNo.CausesValidation = True
		Me.txtShipTelNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipTelNo.HideSelection = True
		Me.txtShipTelNo.ReadOnly = False
		Me.txtShipTelNo.Maxlength = 0
		Me.txtShipTelNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipTelNo.MultiLine = False
		Me.txtShipTelNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipTelNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipTelNo.TabStop = True
		Me.txtShipTelNo.Visible = True
		Me.txtShipTelNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipTelNo.Name = "txtShipTelNo"
		Me.txtShipCode.AutoSize = False
		Me.txtShipCode.Enabled = False
		Me.txtShipCode.Size = New System.Drawing.Size(182, 20)
		Me.txtShipCode.Location = New System.Drawing.Point(112, 64)
		Me.txtShipCode.TabIndex = 4
		Me.txtShipCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipCode.AcceptsReturn = True
		Me.txtShipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipCode.CausesValidation = True
		Me.txtShipCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipCode.HideSelection = True
		Me.txtShipCode.ReadOnly = False
		Me.txtShipCode.Maxlength = 0
		Me.txtShipCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipCode.MultiLine = False
		Me.txtShipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipCode.TabStop = True
		Me.txtShipCode.Visible = True
		Me.txtShipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipCode.Name = "txtShipCode"
		Me.txtShipName.AutoSize = False
		Me.txtShipName.Enabled = False
		Me.txtShipName.Size = New System.Drawing.Size(182, 20)
		Me.txtShipName.Location = New System.Drawing.Point(112, 88)
		Me.txtShipName.TabIndex = 5
		Me.txtShipName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtShipName.AcceptsReturn = True
		Me.txtShipName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtShipName.BackColor = System.Drawing.SystemColors.Window
		Me.txtShipName.CausesValidation = True
		Me.txtShipName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtShipName.HideSelection = True
		Me.txtShipName.ReadOnly = False
		Me.txtShipName.Maxlength = 0
		Me.txtShipName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtShipName.MultiLine = False
		Me.txtShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtShipName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtShipName.TabStop = True
		Me.txtShipName.Visible = True
		Me.txtShipName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtShipName.Name = "txtShipName"
		Me.picShipAdr.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.picShipAdr.Size = New System.Drawing.Size(461, 97)
		Me.picShipAdr.Location = New System.Drawing.Point(112, 112)
		Me.picShipAdr.TabIndex = 24
		Me.picShipAdr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picShipAdr.Dock = System.Windows.Forms.DockStyle.None
		Me.picShipAdr.CausesValidation = True
		Me.picShipAdr.Enabled = True
		Me.picShipAdr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picShipAdr.Cursor = System.Windows.Forms.Cursors.Default
		Me.picShipAdr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picShipAdr.TabStop = True
		Me.picShipAdr.Visible = True
		Me.picShipAdr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picShipAdr.Name = "picShipAdr"
		Me._txtShipAdr_1.AutoSize = False
		Me._txtShipAdr_1.Size = New System.Drawing.Size(449, 20)
		Me._txtShipAdr_1.Location = New System.Drawing.Point(0, 0)
		Me._txtShipAdr_1.TabIndex = 6
		Me._txtShipAdr_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr_1.AcceptsReturn = True
		Me._txtShipAdr_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr_1.CausesValidation = True
		Me._txtShipAdr_1.Enabled = True
		Me._txtShipAdr_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr_1.HideSelection = True
		Me._txtShipAdr_1.ReadOnly = False
		Me._txtShipAdr_1.Maxlength = 0
		Me._txtShipAdr_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr_1.MultiLine = False
		Me._txtShipAdr_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr_1.TabStop = True
		Me._txtShipAdr_1.Visible = True
		Me._txtShipAdr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr_1.Name = "_txtShipAdr_1"
		Me._txtShipAdr_2.AutoSize = False
		Me._txtShipAdr_2.Size = New System.Drawing.Size(449, 20)
		Me._txtShipAdr_2.Location = New System.Drawing.Point(0, 23)
		Me._txtShipAdr_2.TabIndex = 7
		Me._txtShipAdr_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr_2.AcceptsReturn = True
		Me._txtShipAdr_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr_2.CausesValidation = True
		Me._txtShipAdr_2.Enabled = True
		Me._txtShipAdr_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr_2.HideSelection = True
		Me._txtShipAdr_2.ReadOnly = False
		Me._txtShipAdr_2.Maxlength = 0
		Me._txtShipAdr_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr_2.MultiLine = False
		Me._txtShipAdr_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr_2.TabStop = True
		Me._txtShipAdr_2.Visible = True
		Me._txtShipAdr_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr_2.Name = "_txtShipAdr_2"
		Me._txtShipAdr_3.AutoSize = False
		Me._txtShipAdr_3.Size = New System.Drawing.Size(449, 20)
		Me._txtShipAdr_3.Location = New System.Drawing.Point(0, 46)
		Me._txtShipAdr_3.TabIndex = 8
		Me._txtShipAdr_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr_3.AcceptsReturn = True
		Me._txtShipAdr_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr_3.CausesValidation = True
		Me._txtShipAdr_3.Enabled = True
		Me._txtShipAdr_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr_3.HideSelection = True
		Me._txtShipAdr_3.ReadOnly = False
		Me._txtShipAdr_3.Maxlength = 0
		Me._txtShipAdr_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr_3.MultiLine = False
		Me._txtShipAdr_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr_3.TabStop = True
		Me._txtShipAdr_3.Visible = True
		Me._txtShipAdr_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr_3.Name = "_txtShipAdr_3"
		Me._txtShipAdr_4.AutoSize = False
		Me._txtShipAdr_4.Size = New System.Drawing.Size(449, 20)
		Me._txtShipAdr_4.Location = New System.Drawing.Point(0, 69)
		Me._txtShipAdr_4.TabIndex = 9
		Me._txtShipAdr_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtShipAdr_4.AcceptsReturn = True
		Me._txtShipAdr_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtShipAdr_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtShipAdr_4.CausesValidation = True
		Me._txtShipAdr_4.Enabled = True
		Me._txtShipAdr_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtShipAdr_4.HideSelection = True
		Me._txtShipAdr_4.ReadOnly = False
		Me._txtShipAdr_4.Maxlength = 0
		Me._txtShipAdr_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtShipAdr_4.MultiLine = False
		Me._txtShipAdr_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtShipAdr_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtShipAdr_4.TabStop = True
		Me._txtShipAdr_4.Visible = True
		Me._txtShipAdr_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._txtShipAdr_4.Name = "_txtShipAdr_4"
		Me.lblCardCode.Text = "CARDCODE"
		Me.lblCardCode.Size = New System.Drawing.Size(84, 16)
		Me.lblCardCode.Location = New System.Drawing.Point(24, 45)
		Me.lblCardCode.TabIndex = 29
		Me.lblCardCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCardCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCardCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCardCode.Enabled = True
		Me.lblCardCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCardCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCardCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCardCode.UseMnemonic = True
		Me.lblCardCode.Visible = True
		Me.lblCardCode.AutoSize = False
		Me.lblCardCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCardCode.Name = "lblCardCode"
		Me.lblShipRemark.Text = "SHIPREMARK"
		Me.lblShipRemark.Size = New System.Drawing.Size(81, 17)
		Me.lblShipRemark.Location = New System.Drawing.Point(24, 268)
		Me.lblShipRemark.TabIndex = 28
		Me.lblShipRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipRemark.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipRemark.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipRemark.Enabled = True
		Me.lblShipRemark.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipRemark.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipRemark.UseMnemonic = True
		Me.lblShipRemark.Visible = True
		Me.lblShipRemark.AutoSize = False
		Me.lblShipRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipRemark.Name = "lblShipRemark"
		Me.lblShipper.Text = "SHIPPER"
		Me.lblShipper.Size = New System.Drawing.Size(81, 17)
		Me.lblShipper.Location = New System.Drawing.Point(24, 244)
		Me.lblShipper.TabIndex = 27
		Me.lblShipper.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipper.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipper.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipper.Enabled = True
		Me.lblShipper.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipper.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipper.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipper.UseMnemonic = True
		Me.lblShipper.Visible = True
		Me.lblShipper.AutoSize = False
		Me.lblShipper.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipper.Name = "lblShipper"
		Me.lblShipFaxNo.Text = "SHIPFAXNO"
		Me.lblShipFaxNo.Size = New System.Drawing.Size(81, 17)
		Me.lblShipFaxNo.Location = New System.Drawing.Point(304, 220)
		Me.lblShipFaxNo.TabIndex = 26
		Me.lblShipFaxNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipFaxNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipFaxNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipFaxNo.Enabled = True
		Me.lblShipFaxNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipFaxNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipFaxNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipFaxNo.UseMnemonic = True
		Me.lblShipFaxNo.Visible = True
		Me.lblShipFaxNo.AutoSize = False
		Me.lblShipFaxNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipFaxNo.Name = "lblShipFaxNo"
		Me.lblShipTelNo.Text = "SHIPTELNO"
		Me.lblShipTelNo.Size = New System.Drawing.Size(81, 17)
		Me.lblShipTelNo.Location = New System.Drawing.Point(24, 220)
		Me.lblShipTelNo.TabIndex = 25
		Me.lblShipTelNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipTelNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipTelNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipTelNo.Enabled = True
		Me.lblShipTelNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipTelNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipTelNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipTelNo.UseMnemonic = True
		Me.lblShipTelNo.Visible = True
		Me.lblShipTelNo.AutoSize = False
		Me.lblShipTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipTelNo.Name = "lblShipTelNo"
		Me.lblShipLastUpd.Text = "SHIPLASTUPD"
		Me.lblShipLastUpd.Size = New System.Drawing.Size(100, 16)
		Me.lblShipLastUpd.Location = New System.Drawing.Point(24, 307)
		Me.lblShipLastUpd.TabIndex = 22
		Me.lblShipLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipLastUpd.Enabled = True
		Me.lblShipLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipLastUpd.UseMnemonic = True
		Me.lblShipLastUpd.Visible = True
		Me.lblShipLastUpd.AutoSize = False
		Me.lblShipLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipLastUpd.Name = "lblShipLastUpd"
		Me.lblShipLastUpdDate.Text = "SHIPLASTUPDDATE"
		Me.lblShipLastUpdDate.Size = New System.Drawing.Size(100, 16)
		Me.lblShipLastUpdDate.Location = New System.Drawing.Point(288, 307)
		Me.lblShipLastUpdDate.TabIndex = 21
		Me.lblShipLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipLastUpdDate.Enabled = True
		Me.lblShipLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipLastUpdDate.UseMnemonic = True
		Me.lblShipLastUpdDate.Visible = True
		Me.lblShipLastUpdDate.AutoSize = False
		Me.lblShipLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipLastUpdDate.Name = "lblShipLastUpdDate"
		Me.lblDspShipLastUpd.Size = New System.Drawing.Size(151, 20)
		Me.lblDspShipLastUpd.Location = New System.Drawing.Point(128, 304)
		Me.lblDspShipLastUpd.TabIndex = 20
		Me.lblDspShipLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspShipLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspShipLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspShipLastUpd.Enabled = True
		Me.lblDspShipLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspShipLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspShipLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspShipLastUpd.UseMnemonic = True
		Me.lblDspShipLastUpd.Visible = True
		Me.lblDspShipLastUpd.AutoSize = False
		Me.lblDspShipLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspShipLastUpd.Name = "lblDspShipLastUpd"
		Me.lblDspShipLastUpdDate.Size = New System.Drawing.Size(151, 20)
		Me.lblDspShipLastUpdDate.Location = New System.Drawing.Point(392, 304)
		Me.lblDspShipLastUpdDate.TabIndex = 19
		Me.lblDspShipLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspShipLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspShipLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspShipLastUpdDate.Enabled = True
		Me.lblDspShipLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspShipLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspShipLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspShipLastUpdDate.UseMnemonic = True
		Me.lblDspShipLastUpdDate.Visible = True
		Me.lblDspShipLastUpdDate.AutoSize = False
		Me.lblDspShipLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspShipLastUpdDate.Name = "lblDspShipLastUpdDate"
		Me.lblShipCode.Text = "SHIPCODE"
		Me.lblShipCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblShipCode.Size = New System.Drawing.Size(84, 16)
		Me.lblShipCode.Location = New System.Drawing.Point(24, 68)
		Me.lblShipCode.TabIndex = 18
		Me.lblShipCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipCode.Enabled = True
		Me.lblShipCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipCode.UseMnemonic = True
		Me.lblShipCode.Visible = True
		Me.lblShipCode.AutoSize = False
		Me.lblShipCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipCode.Name = "lblShipCode"
		Me.lblShipAdr.Text = "SHIPADR"
		Me.lblShipAdr.Size = New System.Drawing.Size(92, 16)
		Me.lblShipAdr.Location = New System.Drawing.Point(24, 116)
		Me.lblShipAdr.TabIndex = 17
		Me.lblShipAdr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipAdr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipAdr.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipAdr.Enabled = True
		Me.lblShipAdr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipAdr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipAdr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipAdr.UseMnemonic = True
		Me.lblShipAdr.Visible = True
		Me.lblShipAdr.AutoSize = False
		Me.lblShipAdr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipAdr.Name = "lblShipAdr"
		Me.lblShipName.Text = "SHIPNAME"
		Me.lblShipName.Size = New System.Drawing.Size(81, 17)
		Me.lblShipName.Location = New System.Drawing.Point(24, 92)
		Me.lblShipName.TabIndex = 16
		Me.lblShipName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipName.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipName.Enabled = True
		Me.lblShipName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipName.UseMnemonic = True
		Me.lblShipName.Visible = True
		Me.lblShipName.AutoSize = False
		Me.lblShipName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipName.Name = "lblShipName"
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
		Me.Controls.Add(cboShipCode)
		Me.Controls.Add(fraDetailInfo)
		Me.Controls.Add(tbrProcess)
		Me.fraDetailInfo.Controls.Add(cboCardCode)
		Me.fraDetailInfo.Controls.Add(_optCard_0)
		Me.fraDetailInfo.Controls.Add(_optCard_1)
		Me.fraDetailInfo.Controls.Add(txtShipRemark)
		Me.fraDetailInfo.Controls.Add(txtShipper)
		Me.fraDetailInfo.Controls.Add(txtShipFaxNo)
		Me.fraDetailInfo.Controls.Add(txtShipTelNo)
		Me.fraDetailInfo.Controls.Add(txtShipCode)
		Me.fraDetailInfo.Controls.Add(txtShipName)
		Me.fraDetailInfo.Controls.Add(picShipAdr)
		Me.fraDetailInfo.Controls.Add(lblCardCode)
		Me.fraDetailInfo.Controls.Add(lblShipRemark)
		Me.fraDetailInfo.Controls.Add(lblShipper)
		Me.fraDetailInfo.Controls.Add(lblShipFaxNo)
		Me.fraDetailInfo.Controls.Add(lblShipTelNo)
		Me.fraDetailInfo.Controls.Add(lblShipLastUpd)
		Me.fraDetailInfo.Controls.Add(lblShipLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblDspShipLastUpd)
		Me.fraDetailInfo.Controls.Add(lblDspShipLastUpdDate)
		Me.fraDetailInfo.Controls.Add(lblShipCode)
		Me.fraDetailInfo.Controls.Add(lblShipAdr)
		Me.fraDetailInfo.Controls.Add(lblShipName)
		Me.picShipAdr.Controls.Add(_txtShipAdr_1)
		Me.picShipAdr.Controls.Add(_txtShipAdr_2)
		Me.picShipAdr.Controls.Add(_txtShipAdr_3)
		Me.picShipAdr.Controls.Add(_txtShipAdr_4)
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
		Me.optCard.SetIndex(_optCard_0, CType(0, Short))
		Me.optCard.SetIndex(_optCard_1, CType(1, Short))
		Me.txtShipAdr.SetIndex(_txtShipAdr_1, CType(1, Short))
		Me.txtShipAdr.SetIndex(_txtShipAdr_2, CType(2, Short))
		Me.txtShipAdr.SetIndex(_txtShipAdr_3, CType(3, Short))
		Me.txtShipAdr.SetIndex(_txtShipAdr_4, CType(4, Short))
		CType(Me.txtShipAdr, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optCard, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraDetailInfo.ResumeLayout(False)
		Me.picShipAdr.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class