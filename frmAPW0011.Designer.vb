<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAPW0011
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
	Public WithEvents cboDocLine As System.Windows.Forms.ComboBox
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboItmType As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrCode As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCode As System.Windows.Forms.ComboBox
	Public WithEvents txtQty As System.Windows.Forms.TextBox
	Public WithEvents txtNet As System.Windows.Forms.TextBox
	Public WithEvents txtAmt As System.Windows.Forms.TextBox
	Public WithEvents txtMU As System.Windows.Forms.TextBox
	Public WithEvents txtUnitPrice As System.Windows.Forms.TextBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOK As System.Windows.Forms.Button
	Public WithEvents txtItmName As System.Windows.Forms.TextBox
	Public WithEvents lblQty As System.Windows.Forms.Label
	Public WithEvents lblNet As System.Windows.Forms.Label
	Public WithEvents lblAmt As System.Windows.Forms.Label
	Public WithEvents lblMU As System.Windows.Forms.Label
	Public WithEvents lblUnitPrice As System.Windows.Forms.Label
	Public WithEvents lblItmType As System.Windows.Forms.Label
	Public WithEvents lblItmCode As System.Windows.Forms.Label
	Public WithEvents lblVdrCode As System.Windows.Forms.Label
	Public WithEvents lblDspItmType As System.Windows.Forms.Label
	Public WithEvents lblDspItmCode As System.Windows.Forms.Label
	Public WithEvents lblDspVdrCode As System.Windows.Forms.Label
	Public WithEvents lblItmName As System.Windows.Forms.Label
	Public WithEvents fraHeader As System.Windows.Forms.GroupBox
	Public WithEvents lblDocLine As System.Windows.Forms.Label
	Public WithEvents lblDspDocLine As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	Public WithEvents lblDspDocNo As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAPW0011))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboDocLine = New System.Windows.Forms.ComboBox
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboItmType = New System.Windows.Forms.ComboBox
		Me.cboVdrCode = New System.Windows.Forms.ComboBox
		Me.cboItmCode = New System.Windows.Forms.ComboBox
		Me.fraHeader = New System.Windows.Forms.GroupBox
		Me.txtQty = New System.Windows.Forms.TextBox
		Me.txtNet = New System.Windows.Forms.TextBox
		Me.txtAmt = New System.Windows.Forms.TextBox
		Me.txtMU = New System.Windows.Forms.TextBox
		Me.txtUnitPrice = New System.Windows.Forms.TextBox
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOK = New System.Windows.Forms.Button
		Me.txtItmName = New System.Windows.Forms.TextBox
		Me.lblQty = New System.Windows.Forms.Label
		Me.lblNet = New System.Windows.Forms.Label
		Me.lblAmt = New System.Windows.Forms.Label
		Me.lblMU = New System.Windows.Forms.Label
		Me.lblUnitPrice = New System.Windows.Forms.Label
		Me.lblItmType = New System.Windows.Forms.Label
		Me.lblItmCode = New System.Windows.Forms.Label
		Me.lblVdrCode = New System.Windows.Forms.Label
		Me.lblDspItmType = New System.Windows.Forms.Label
		Me.lblDspItmCode = New System.Windows.Forms.Label
		Me.lblDspVdrCode = New System.Windows.Forms.Label
		Me.lblItmName = New System.Windows.Forms.Label
		Me.lblDocLine = New System.Windows.Forms.Label
		Me.lblDspDocLine = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.lblDspDocNo = New System.Windows.Forms.Label
		Me.fraHeader.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "New Key"
		Me.ClientSize = New System.Drawing.Size(598, 340)
		Me.Location = New System.Drawing.Point(66, 161)
		Me.Icon = CType(resources.GetObject("frmAPW0011.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAPW0011"
		Me.cboDocLine.Size = New System.Drawing.Size(174, 20)
		Me.cboDocLine.Location = New System.Drawing.Point(112, 32)
		Me.cboDocLine.TabIndex = 0
		Me.cboDocLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocLine.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocLine.CausesValidation = True
		Me.cboDocLine.Enabled = True
		Me.cboDocLine.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocLine.IntegralHeight = True
		Me.cboDocLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocLine.Sorted = False
		Me.cboDocLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocLine.TabStop = True
		Me.cboDocLine.Visible = True
		Me.cboDocLine.Name = "cboDocLine"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(528, 96)
		Me.tblCommon.TabIndex = 28
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboItmType.Size = New System.Drawing.Size(158, 20)
		Me.cboItmType.Location = New System.Drawing.Point(112, 80)
		Me.cboItmType.TabIndex = 1
		Me.cboItmType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmType.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmType.CausesValidation = True
		Me.cboItmType.Enabled = True
		Me.cboItmType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmType.IntegralHeight = True
		Me.cboItmType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmType.Sorted = False
		Me.cboItmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmType.TabStop = True
		Me.cboItmType.Visible = True
		Me.cboItmType.Name = "cboItmType"
		Me.cboVdrCode.Size = New System.Drawing.Size(158, 20)
		Me.cboVdrCode.Location = New System.Drawing.Point(112, 128)
		Me.cboVdrCode.TabIndex = 3
		Me.cboVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrCode.CausesValidation = True
		Me.cboVdrCode.Enabled = True
		Me.cboVdrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrCode.IntegralHeight = True
		Me.cboVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrCode.Sorted = False
		Me.cboVdrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrCode.TabStop = True
		Me.cboVdrCode.Visible = True
		Me.cboVdrCode.Name = "cboVdrCode"
		Me.cboItmCode.Size = New System.Drawing.Size(158, 20)
		Me.cboItmCode.Location = New System.Drawing.Point(112, 104)
		Me.cboItmCode.TabIndex = 2
		Me.cboItmCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCode.CausesValidation = True
		Me.cboItmCode.Enabled = True
		Me.cboItmCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCode.IntegralHeight = True
		Me.cboItmCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCode.Sorted = False
		Me.cboItmCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCode.TabStop = True
		Me.cboItmCode.Visible = True
		Me.cboItmCode.Name = "cboItmCode"
		Me.fraHeader.Size = New System.Drawing.Size(581, 272)
		Me.fraHeader.Location = New System.Drawing.Point(8, 56)
		Me.fraHeader.TabIndex = 12
		Me.fraHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraHeader.BackColor = System.Drawing.SystemColors.Control
		Me.fraHeader.Enabled = True
		Me.fraHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraHeader.Visible = True
		Me.fraHeader.Padding = New System.Windows.Forms.Padding(0)
		Me.fraHeader.Name = "fraHeader"
		Me.txtQty.AutoSize = False
		Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtQty.Size = New System.Drawing.Size(97, 20)
		Me.txtQty.Location = New System.Drawing.Point(104, 120)
		Me.txtQty.Maxlength = 20
		Me.txtQty.TabIndex = 5
		Me.txtQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQty.AcceptsReturn = True
		Me.txtQty.BackColor = System.Drawing.SystemColors.Window
		Me.txtQty.CausesValidation = True
		Me.txtQty.Enabled = True
		Me.txtQty.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQty.HideSelection = True
		Me.txtQty.ReadOnly = False
		Me.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQty.MultiLine = False
		Me.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQty.TabStop = True
		Me.txtQty.Visible = True
		Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQty.Name = "txtQty"
		Me.txtNet.AutoSize = False
		Me.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtNet.Size = New System.Drawing.Size(97, 20)
		Me.txtNet.Location = New System.Drawing.Point(104, 216)
		Me.txtNet.Maxlength = 20
		Me.txtNet.TabIndex = 9
		Me.txtNet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNet.AcceptsReturn = True
		Me.txtNet.BackColor = System.Drawing.SystemColors.Window
		Me.txtNet.CausesValidation = True
		Me.txtNet.Enabled = True
		Me.txtNet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNet.HideSelection = True
		Me.txtNet.ReadOnly = False
		Me.txtNet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNet.MultiLine = False
		Me.txtNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNet.TabStop = True
		Me.txtNet.Visible = True
		Me.txtNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNet.Name = "txtNet"
		Me.txtAmt.AutoSize = False
		Me.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtAmt.Size = New System.Drawing.Size(97, 20)
		Me.txtAmt.Location = New System.Drawing.Point(104, 192)
		Me.txtAmt.Maxlength = 20
		Me.txtAmt.TabIndex = 8
		Me.txtAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAmt.AcceptsReturn = True
		Me.txtAmt.BackColor = System.Drawing.SystemColors.Window
		Me.txtAmt.CausesValidation = True
		Me.txtAmt.Enabled = True
		Me.txtAmt.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAmt.HideSelection = True
		Me.txtAmt.ReadOnly = False
		Me.txtAmt.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAmt.MultiLine = False
		Me.txtAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAmt.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAmt.TabStop = True
		Me.txtAmt.Visible = True
		Me.txtAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAmt.Name = "txtAmt"
		Me.txtMU.AutoSize = False
		Me.txtMU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtMU.Size = New System.Drawing.Size(97, 20)
		Me.txtMU.Location = New System.Drawing.Point(104, 168)
		Me.txtMU.Maxlength = 20
		Me.txtMU.TabIndex = 7
		Me.txtMU.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMU.AcceptsReturn = True
		Me.txtMU.BackColor = System.Drawing.SystemColors.Window
		Me.txtMU.CausesValidation = True
		Me.txtMU.Enabled = True
		Me.txtMU.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMU.HideSelection = True
		Me.txtMU.ReadOnly = False
		Me.txtMU.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMU.MultiLine = False
		Me.txtMU.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMU.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMU.TabStop = True
		Me.txtMU.Visible = True
		Me.txtMU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMU.Name = "txtMU"
		Me.txtUnitPrice.AutoSize = False
		Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtUnitPrice.Size = New System.Drawing.Size(97, 20)
		Me.txtUnitPrice.Location = New System.Drawing.Point(104, 144)
		Me.txtUnitPrice.Maxlength = 20
		Me.txtUnitPrice.TabIndex = 6
		Me.txtUnitPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUnitPrice.AcceptsReturn = True
		Me.txtUnitPrice.BackColor = System.Drawing.SystemColors.Window
		Me.txtUnitPrice.CausesValidation = True
		Me.txtUnitPrice.Enabled = True
		Me.txtUnitPrice.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUnitPrice.HideSelection = True
		Me.txtUnitPrice.ReadOnly = False
		Me.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUnitPrice.MultiLine = False
		Me.txtUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUnitPrice.TabStop = True
		Me.txtUnitPrice.Visible = True
		Me.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUnitPrice.Name = "txtUnitPrice"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(97, 49)
		Me.btnCancel.Location = New System.Drawing.Point(472, 216)
		Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
		Me.btnCancel.TabIndex = 11
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnOK.Text = "OK"
		Me.btnOK.Size = New System.Drawing.Size(97, 49)
		Me.btnOK.Location = New System.Drawing.Point(368, 216)
		Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
		Me.btnOK.TabIndex = 10
		Me.btnOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.CausesValidation = True
		Me.btnOK.Enabled = True
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.TabStop = True
		Me.btnOK.Name = "btnOK"
		Me.txtItmName.AutoSize = False
		Me.txtItmName.Size = New System.Drawing.Size(467, 21)
		Me.txtItmName.Location = New System.Drawing.Point(104, 96)
		Me.txtItmName.TabIndex = 4
		Me.txtItmName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmName.AcceptsReturn = True
		Me.txtItmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmName.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmName.CausesValidation = True
		Me.txtItmName.Enabled = True
		Me.txtItmName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmName.HideSelection = True
		Me.txtItmName.ReadOnly = False
		Me.txtItmName.Maxlength = 0
		Me.txtItmName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmName.MultiLine = False
		Me.txtItmName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmName.TabStop = True
		Me.txtItmName.Visible = True
		Me.txtItmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmName.Name = "txtItmName"
		Me.lblQty.Text = "EXCR"
		Me.lblQty.Size = New System.Drawing.Size(88, 17)
		Me.lblQty.Location = New System.Drawing.Point(8, 120)
		Me.lblQty.TabIndex = 29
		Me.lblQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblQty.Enabled = True
		Me.lblQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblQty.UseMnemonic = True
		Me.lblQty.Visible = True
		Me.lblQty.AutoSize = False
		Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblQty.Name = "lblQty"
		Me.lblNet.Text = "EXCR"
		Me.lblNet.Size = New System.Drawing.Size(88, 17)
		Me.lblNet.Location = New System.Drawing.Point(8, 216)
		Me.lblNet.TabIndex = 27
		Me.lblNet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblNet.Enabled = True
		Me.lblNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNet.UseMnemonic = True
		Me.lblNet.Visible = True
		Me.lblNet.AutoSize = False
		Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNet.Name = "lblNet"
		Me.lblAmt.Text = "EXCR"
		Me.lblAmt.Size = New System.Drawing.Size(88, 17)
		Me.lblAmt.Location = New System.Drawing.Point(8, 192)
		Me.lblAmt.TabIndex = 26
		Me.lblAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblAmt.Enabled = True
		Me.lblAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAmt.UseMnemonic = True
		Me.lblAmt.Visible = True
		Me.lblAmt.AutoSize = False
		Me.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAmt.Name = "lblAmt"
		Me.lblMU.Text = "EXCR"
		Me.lblMU.Size = New System.Drawing.Size(88, 17)
		Me.lblMU.Location = New System.Drawing.Point(8, 168)
		Me.lblMU.TabIndex = 25
		Me.lblMU.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMU.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMU.BackColor = System.Drawing.SystemColors.Control
		Me.lblMU.Enabled = True
		Me.lblMU.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMU.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMU.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMU.UseMnemonic = True
		Me.lblMU.Visible = True
		Me.lblMU.AutoSize = False
		Me.lblMU.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMU.Name = "lblMU"
		Me.lblUnitPrice.Text = "EXCR"
		Me.lblUnitPrice.Size = New System.Drawing.Size(88, 17)
		Me.lblUnitPrice.Location = New System.Drawing.Point(8, 144)
		Me.lblUnitPrice.TabIndex = 24
		Me.lblUnitPrice.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUnitPrice.BackColor = System.Drawing.SystemColors.Control
		Me.lblUnitPrice.Enabled = True
		Me.lblUnitPrice.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUnitPrice.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUnitPrice.UseMnemonic = True
		Me.lblUnitPrice.Visible = True
		Me.lblUnitPrice.AutoSize = False
		Me.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUnitPrice.Name = "lblUnitPrice"
		Me.lblItmType.Text = "SALECODE"
		Me.lblItmType.Size = New System.Drawing.Size(103, 16)
		Me.lblItmType.Location = New System.Drawing.Point(8, 24)
		Me.lblItmType.TabIndex = 19
		Me.lblItmType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmType.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmType.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmType.Enabled = True
		Me.lblItmType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmType.UseMnemonic = True
		Me.lblItmType.Visible = True
		Me.lblItmType.AutoSize = False
		Me.lblItmType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmType.Name = "lblItmType"
		Me.lblItmCode.Text = "PAYCODE"
		Me.lblItmCode.Size = New System.Drawing.Size(103, 16)
		Me.lblItmCode.Location = New System.Drawing.Point(8, 48)
		Me.lblItmCode.TabIndex = 18
		Me.lblItmCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCode.Enabled = True
		Me.lblItmCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCode.UseMnemonic = True
		Me.lblItmCode.Visible = True
		Me.lblItmCode.AutoSize = False
		Me.lblItmCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCode.Name = "lblItmCode"
		Me.lblVdrCode.Text = "PRCCODE"
		Me.lblVdrCode.Size = New System.Drawing.Size(103, 16)
		Me.lblVdrCode.Location = New System.Drawing.Point(8, 72)
		Me.lblVdrCode.TabIndex = 17
		Me.lblVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrCode.Enabled = True
		Me.lblVdrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrCode.UseMnemonic = True
		Me.lblVdrCode.Visible = True
		Me.lblVdrCode.AutoSize = False
		Me.lblVdrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrCode.Name = "lblVdrCode"
		Me.lblDspItmType.Size = New System.Drawing.Size(305, 20)
		Me.lblDspItmType.Location = New System.Drawing.Point(264, 24)
		Me.lblDspItmType.TabIndex = 16
		Me.lblDspItmType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmType.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmType.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmType.Enabled = True
		Me.lblDspItmType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmType.UseMnemonic = True
		Me.lblDspItmType.Visible = True
		Me.lblDspItmType.AutoSize = False
		Me.lblDspItmType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmType.Name = "lblDspItmType"
		Me.lblDspItmCode.Size = New System.Drawing.Size(305, 20)
		Me.lblDspItmCode.Location = New System.Drawing.Point(264, 48)
		Me.lblDspItmCode.TabIndex = 15
		Me.lblDspItmCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmCode.Enabled = True
		Me.lblDspItmCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmCode.UseMnemonic = True
		Me.lblDspItmCode.Visible = True
		Me.lblDspItmCode.AutoSize = False
		Me.lblDspItmCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmCode.Name = "lblDspItmCode"
		Me.lblDspVdrCode.Size = New System.Drawing.Size(305, 20)
		Me.lblDspVdrCode.Location = New System.Drawing.Point(264, 72)
		Me.lblDspVdrCode.TabIndex = 14
		Me.lblDspVdrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspVdrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspVdrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspVdrCode.Enabled = True
		Me.lblDspVdrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspVdrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspVdrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspVdrCode.UseMnemonic = True
		Me.lblDspVdrCode.Visible = True
		Me.lblDspVdrCode.AutoSize = False
		Me.lblDspVdrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspVdrCode.Name = "lblDspVdrCode"
		Me.lblItmName.Text = "NEW KEY:"
		Me.lblItmName.Size = New System.Drawing.Size(89, 16)
		Me.lblItmName.Location = New System.Drawing.Point(8, 96)
		Me.lblItmName.TabIndex = 13
		Me.lblItmName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmName.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmName.Enabled = True
		Me.lblItmName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmName.UseMnemonic = True
		Me.lblItmName.Visible = True
		Me.lblItmName.AutoSize = False
		Me.lblItmName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmName.Name = "lblItmName"
		Me.lblDocLine.Text = "SALECODE"
		Me.lblDocLine.Size = New System.Drawing.Size(103, 16)
		Me.lblDocLine.Location = New System.Drawing.Point(8, 32)
		Me.lblDocLine.TabIndex = 23
		Me.lblDocLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocLine.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocLine.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocLine.Enabled = True
		Me.lblDocLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocLine.UseMnemonic = True
		Me.lblDocLine.Visible = True
		Me.lblDocLine.AutoSize = False
		Me.lblDocLine.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocLine.Name = "lblDocLine"
		Me.lblDspDocLine.Size = New System.Drawing.Size(289, 20)
		Me.lblDspDocLine.Location = New System.Drawing.Point(288, 32)
		Me.lblDspDocLine.TabIndex = 22
		Me.lblDspDocLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspDocLine.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspDocLine.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspDocLine.Enabled = True
		Me.lblDspDocLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspDocLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspDocLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspDocLine.UseMnemonic = True
		Me.lblDspDocLine.Visible = True
		Me.lblDspDocLine.AutoSize = False
		Me.lblDspDocLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspDocLine.Name = "lblDspDocLine"
		Me.lblDocNo.Text = "SALECODE"
		Me.lblDocNo.Size = New System.Drawing.Size(103, 16)
		Me.lblDocNo.Location = New System.Drawing.Point(8, 8)
		Me.lblDocNo.TabIndex = 21
		Me.lblDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNo.Enabled = True
		Me.lblDocNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNo.UseMnemonic = True
		Me.lblDocNo.Visible = True
		Me.lblDocNo.AutoSize = False
		Me.lblDocNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNo.Name = "lblDocNo"
		Me.lblDspDocNo.Size = New System.Drawing.Size(177, 20)
		Me.lblDspDocNo.Location = New System.Drawing.Point(112, 8)
		Me.lblDspDocNo.TabIndex = 20
		Me.lblDspDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspDocNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspDocNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspDocNo.Enabled = True
		Me.lblDspDocNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspDocNo.UseMnemonic = True
		Me.lblDspDocNo.Visible = True
		Me.lblDspDocNo.AutoSize = False
		Me.lblDspDocNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspDocNo.Name = "lblDspDocNo"
		Me.Controls.Add(cboDocLine)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboItmType)
		Me.Controls.Add(cboVdrCode)
		Me.Controls.Add(cboItmCode)
		Me.Controls.Add(fraHeader)
		Me.Controls.Add(lblDocLine)
		Me.Controls.Add(lblDspDocLine)
		Me.Controls.Add(lblDocNo)
		Me.Controls.Add(lblDspDocNo)
		Me.fraHeader.Controls.Add(txtQty)
		Me.fraHeader.Controls.Add(txtNet)
		Me.fraHeader.Controls.Add(txtAmt)
		Me.fraHeader.Controls.Add(txtMU)
		Me.fraHeader.Controls.Add(txtUnitPrice)
		Me.fraHeader.Controls.Add(btnCancel)
		Me.fraHeader.Controls.Add(btnOK)
		Me.fraHeader.Controls.Add(txtItmName)
		Me.fraHeader.Controls.Add(lblQty)
		Me.fraHeader.Controls.Add(lblNet)
		Me.fraHeader.Controls.Add(lblAmt)
		Me.fraHeader.Controls.Add(lblMU)
		Me.fraHeader.Controls.Add(lblUnitPrice)
		Me.fraHeader.Controls.Add(lblItmType)
		Me.fraHeader.Controls.Add(lblItmCode)
		Me.fraHeader.Controls.Add(lblVdrCode)
		Me.fraHeader.Controls.Add(lblDspItmType)
		Me.fraHeader.Controls.Add(lblDspItmCode)
		Me.fraHeader.Controls.Add(lblDspVdrCode)
		Me.fraHeader.Controls.Add(lblItmName)
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraHeader.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class