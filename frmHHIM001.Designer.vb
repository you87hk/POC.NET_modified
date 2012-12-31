<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHHIM001
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
	Public WithEvents btnImport As System.Windows.Forms.Button
	Public WithEvents btnReceive As System.Windows.Forms.Button
	Public WithEvents HHList As System.Windows.Forms.ListBox
	Public WithEvents _optDocType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optDocType_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents medPrdTo As System.Windows.Forms.MaskedTextBox
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblPrdTo As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	Public WithEvents optDocType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHHIM001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btnImport = New System.Windows.Forms.Button
		Me.btnReceive = New System.Windows.Forms.Button
		Me.HHList = New System.Windows.Forms.ListBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me._optDocType_1 = New System.Windows.Forms.RadioButton
		Me._optDocType_0 = New System.Windows.Forms.RadioButton
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.medPrdTo = New System.Windows.Forms.MaskedTextBox
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.lblPrdTo = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.lblDspItmDesc = New System.Windows.Forms.Label
		Me.optDocType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraSelect.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optDocType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Stock Reserve"
		Me.ClientSize = New System.Drawing.Size(794, 575)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmHHIM001"
		Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnImport.Text = "Import"
		Me.btnImport.Size = New System.Drawing.Size(73, 25)
		Me.btnImport.Location = New System.Drawing.Point(360, 40)
		Me.btnImport.TabIndex = 3
		Me.btnImport.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnImport.BackColor = System.Drawing.SystemColors.Control
		Me.btnImport.CausesValidation = True
		Me.btnImport.Enabled = True
		Me.btnImport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnImport.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnImport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnImport.TabStop = True
		Me.btnImport.Name = "btnImport"
		Me.btnReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReceive.Text = "Receive"
		Me.btnReceive.Size = New System.Drawing.Size(73, 25)
		Me.btnReceive.Location = New System.Drawing.Point(280, 40)
		Me.btnReceive.TabIndex = 2
		Me.btnReceive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReceive.BackColor = System.Drawing.SystemColors.Control
		Me.btnReceive.CausesValidation = True
		Me.btnReceive.Enabled = True
		Me.btnReceive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReceive.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReceive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReceive.TabStop = True
		Me.btnReceive.Name = "btnReceive"
		Me.HHList.Size = New System.Drawing.Size(137, 20)
		Me.HHList.Location = New System.Drawing.Point(696, 24)
		Me.HHList.TabIndex = 10
		Me.HHList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.HHList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.HHList.BackColor = System.Drawing.SystemColors.Window
		Me.HHList.CausesValidation = True
		Me.HHList.Enabled = True
		Me.HHList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.HHList.IntegralHeight = True
		Me.HHList.Cursor = System.Windows.Forms.Cursors.Default
		Me.HHList.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.HHList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HHList.Sorted = False
		Me.HHList.TabStop = True
		Me.HHList.Visible = True
		Me.HHList.MultiColumn = False
		Me.HHList.Name = "HHList"
		Me.fraSelect.Size = New System.Drawing.Size(265, 35)
		Me.fraSelect.Location = New System.Drawing.Point(8, 32)
		Me.fraSelect.TabIndex = 9
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me._optDocType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_1.Text = "SO"
		Me._optDocType_1.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optDocType_1.Size = New System.Drawing.Size(89, 17)
		Me._optDocType_1.Location = New System.Drawing.Point(136, 14)
		Me._optDocType_1.TabIndex = 1
		Me._optDocType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optDocType_1.CausesValidation = True
		Me._optDocType_1.Enabled = True
		Me._optDocType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optDocType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optDocType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optDocType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optDocType_1.TabStop = True
		Me._optDocType_1.Checked = False
		Me._optDocType_1.Visible = True
		Me._optDocType_1.Name = "_optDocType_1"
		Me._optDocType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_0.Text = "SN"
		Me._optDocType_0.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._optDocType_0.Size = New System.Drawing.Size(97, 17)
		Me._optDocType_0.Location = New System.Drawing.Point(8, 14)
		Me._optDocType_0.TabIndex = 0
		Me._optDocType_0.Checked = True
		Me._optDocType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optDocType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optDocType_0.CausesValidation = True
		Me._optDocType_0.Enabled = True
		Me._optDocType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optDocType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optDocType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optDocType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optDocType_0.TabStop = True
		Me._optDocType_0.Visible = True
		Me._optDocType_0.Name = "_optDocType_0"
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
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
		Me._tbrProcess_Button2.Name = "Update"
		Me._tbrProcess_Button2.ToolTipText = "選取 (F2)"
		Me._tbrProcess_Button2.ImageIndex = 2
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Delete"
		Me._tbrProcess_Button3.ImageIndex = 3
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.ImageIndex = 1
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Cancel"
		Me._tbrProcess_Button5.ToolTipText = "取消 (F3)"
		Me._tbrProcess_Button5.ImageIndex = 16
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
		Me._tbrProcess_Button7.Name = "Exit"
		Me._tbrProcess_Button7.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button7.ImageIndex = 9
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.Name = "SAll"
		Me._tbrProcess_Button9.ImageIndex = 18
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.Name = "DAll"
		Me._tbrProcess_Button10.ImageIndex = 19
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
		Me._tbrProcess_Button12.Name = "Refresh"
		Me._tbrProcess_Button12.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
		Me.iglProcess.Images.SetKeyName(12, "")
		Me.iglProcess.Images.SetKeyName(13, "")
		Me.iglProcess.Images.SetKeyName(14, "")
		Me.iglProcess.Images.SetKeyName(15, "")
		Me.iglProcess.Images.SetKeyName(16, "")
		Me.iglProcess.Images.SetKeyName(17, "")
		Me.iglProcess.Images.SetKeyName(18, "")
		Me.iglProcess.Images.SetKeyName(19, "")
		Me.iglProcess.Images.SetKeyName(20, "")
		Me.iglProcess.Images.SetKeyName(21, "")
		Me.iglProcess.Images.SetKeyName(22, "")
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(777, 473)
		Me.tblDetail.Location = New System.Drawing.Point(8, 72)
		Me.tblDetail.TabIndex = 6
		Me.tblDetail.Name = "tblDetail"
		Me.medPrdTo.AllowPromptAsInput = False
		Me.medPrdTo.Size = New System.Drawing.Size(89, 19)
		Me.medPrdTo.Location = New System.Drawing.Point(640, 40)
		Me.medPrdTo.TabIndex = 5
		Me.medPrdTo.MaxLength = 7
		Me.medPrdTo.Mask = "####/##"
		Me.medPrdTo.PromptChar = "_"
		Me.medPrdTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdTo.Name = "medPrdTo"
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(520, 40)
		Me.medPrdFr.TabIndex = 4
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.lblPrdTo.Text = "To"
		Me.lblPrdTo.Size = New System.Drawing.Size(33, 23)
		Me.lblPrdTo.Location = New System.Drawing.Point(600, 40)
		Me.lblPrdTo.TabIndex = 12
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
		Me.lblPrdFr.Size = New System.Drawing.Size(86, 23)
		Me.lblPrdFr.Location = New System.Drawing.Point(440, 40)
		Me.lblPrdFr.TabIndex = 11
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
		Me.lblDspItmDesc.Size = New System.Drawing.Size(777, 20)
		Me.lblDspItmDesc.Location = New System.Drawing.Point(8, 552)
		Me.lblDspItmDesc.TabIndex = 7
		Me.lblDspItmDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmDesc.Enabled = True
		Me.lblDspItmDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmDesc.UseMnemonic = True
		Me.lblDspItmDesc.Visible = True
		Me.lblDspItmDesc.AutoSize = False
		Me.lblDspItmDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmDesc.Name = "lblDspItmDesc"
		Me.Controls.Add(btnImport)
		Me.Controls.Add(btnReceive)
		Me.Controls.Add(HHList)
		Me.Controls.Add(fraSelect)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(medPrdTo)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(lblPrdTo)
		Me.Controls.Add(lblPrdFr)
		Me.Controls.Add(lblDspItmDesc)
		Me.fraSelect.Controls.Add(_optDocType_1)
		Me.fraSelect.Controls.Add(_optDocType_0)
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
		Me.optDocType.SetIndex(_optDocType_1, CType(1, Short))
		Me.optDocType.SetIndex(_optDocType_0, CType(0, Short))
		CType(Me.optDocType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraSelect.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class