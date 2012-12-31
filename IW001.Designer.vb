<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmIW001
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
	Public WithEvents _mnuPopUpSub_0 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPopUp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents cboWhsCode As System.Windows.Forms.ComboBox
	Public WithEvents cboITMCODE As System.Windows.Forms.ComboBox
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
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
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblWhsCode As System.Windows.Forms.Label
	Public WithEvents lblDspItmName As System.Windows.Forms.Label
	Public WithEvents lblItemChiName As System.Windows.Forms.Label
	Public WithEvents lblItmCode As System.Windows.Forms.Label
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIW001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.cboWhsCode = New System.Windows.Forms.ComboBox
		Me.cboITMCODE = New System.Windows.Forms.ComboBox
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
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
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.lblWhsCode = New System.Windows.Forms.Label
		Me.lblDspItmName = New System.Windows.Forms.Label
		Me.lblItemChiName = New System.Windows.Forms.Label
		Me.lblItmCode = New System.Windows.Forms.Label
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "書本對換價"
		Me.ClientSize = New System.Drawing.Size(653, 465)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmIW001.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
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
		Me.Name = "frmIW001"
		Me.mnuPopUp.Name = "mnuPopUp"
		Me.mnuPopUp.Text = "PoP Up"
		Me.mnuPopUp.Visible = False
		Me.mnuPopUp.Checked = False
		Me.mnuPopUp.Enabled = True
		Me._mnuPopUpSub_0.Name = "_mnuPopUpSub_0"
		Me._mnuPopUpSub_0.Text = ""
		Me._mnuPopUpSub_0.Checked = False
		Me._mnuPopUpSub_0.Enabled = True
		Me._mnuPopUpSub_0.Visible = True
		Me.cboWhsCode.Size = New System.Drawing.Size(193, 20)
		Me.cboWhsCode.Location = New System.Drawing.Point(416, 56)
		Me.cboWhsCode.TabIndex = 7
		Me.cboWhsCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboWhsCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboWhsCode.CausesValidation = True
		Me.cboWhsCode.Enabled = True
		Me.cboWhsCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboWhsCode.IntegralHeight = True
		Me.cboWhsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboWhsCode.Sorted = False
		Me.cboWhsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboWhsCode.TabStop = True
		Me.cboWhsCode.Visible = True
		Me.cboWhsCode.Name = "cboWhsCode"
		Me.cboITMCODE.Size = New System.Drawing.Size(217, 20)
		Me.cboITMCODE.Location = New System.Drawing.Point(88, 56)
		Me.cboITMCODE.TabIndex = 3
		Me.cboITMCODE.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboITMCODE.BackColor = System.Drawing.SystemColors.Window
		Me.cboITMCODE.CausesValidation = True
		Me.cboITMCODE.Enabled = True
		Me.cboITMCODE.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboITMCODE.IntegralHeight = True
		Me.cboITMCODE.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboITMCODE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboITMCODE.Sorted = False
		Me.cboITMCODE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboITMCODE.TabStop = True
		Me.cboITMCODE.Visible = True
		Me.cboITMCODE.Name = "cboITMCODE"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(656, 40)
		Me.tblCommon.TabIndex = 1
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
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
		Me.tbrProcess.Size = New System.Drawing.Size(653, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 24)
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
		Me._tbrProcess_Button2.Name = "Open"
		Me._tbrProcess_Button2.ToolTipText = "Open (F6)"
		Me._tbrProcess_Button2.ImageIndex = 11
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Visible = 0
		Me._tbrProcess_Button3.Name = "Add"
		Me._tbrProcess_Button3.ToolTipText = "Add (F2)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Visible = 0
		Me._tbrProcess_Button4.Name = "Edit"
		Me._tbrProcess_Button4.ToolTipText = "Edit (F5)"
		Me._tbrProcess_Button4.ImageIndex = 1
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Visible = 0
		Me._tbrProcess_Button5.Name = "Delete"
		Me._tbrProcess_Button5.ToolTipText = "Delete (F3)"
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
		Me._tbrProcess_Button7.ToolTipText = "Save (F10)"
		Me._tbrProcess_Button7.ImageIndex = 3
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Cancel"
		Me._tbrProcess_Button8.ToolTipText = "Cancel (F11)"
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
		Me._tbrProcess_Button10.Visible = 0
		Me._tbrProcess_Button10.Name = "Find"
		Me._tbrProcess_Button10.ToolTipText = "Find (F9)"
		Me._tbrProcess_Button10.ImageIndex = 6
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Visible = 0
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "Exit"
		Me._tbrProcess_Button12.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button12.ImageIndex = 8
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(633, 337)
		Me.tblDetail.Location = New System.Drawing.Point(8, 120)
		Me.tblDetail.TabIndex = 6
		Me.tblDetail.Name = "tblDetail"
		Me.lblWhsCode.Text = "WHSCODE"
		Me.lblWhsCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblWhsCode.Size = New System.Drawing.Size(97, 17)
		Me.lblWhsCode.Location = New System.Drawing.Point(312, 60)
		Me.lblWhsCode.TabIndex = 8
		Me.lblWhsCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhsCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhsCode.Enabled = True
		Me.lblWhsCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhsCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhsCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhsCode.UseMnemonic = True
		Me.lblWhsCode.Visible = True
		Me.lblWhsCode.AutoSize = False
		Me.lblWhsCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhsCode.Name = "lblWhsCode"
		Me.lblDspItmName.Size = New System.Drawing.Size(553, 20)
		Me.lblDspItmName.Location = New System.Drawing.Point(88, 88)
		Me.lblDspItmName.TabIndex = 4
		Me.lblDspItmName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmName.Enabled = True
		Me.lblDspItmName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmName.UseMnemonic = True
		Me.lblDspItmName.Visible = True
		Me.lblDspItmName.AutoSize = False
		Me.lblDspItmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmName.Name = "lblDspItmName"
		Me.lblItemChiName.Text = "VDRITEMCHINAME"
		Me.lblItemChiName.Size = New System.Drawing.Size(81, 17)
		Me.lblItemChiName.Location = New System.Drawing.Point(8, 92)
		Me.lblItemChiName.TabIndex = 2
		Me.lblItemChiName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItemChiName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItemChiName.BackColor = System.Drawing.SystemColors.Control
		Me.lblItemChiName.Enabled = True
		Me.lblItemChiName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItemChiName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItemChiName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItemChiName.UseMnemonic = True
		Me.lblItemChiName.Visible = True
		Me.lblItemChiName.AutoSize = False
		Me.lblItemChiName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItemChiName.Name = "lblItemChiName"
		Me.lblItmCode.Text = "ITMCODE"
		Me.lblItmCode.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblItmCode.Size = New System.Drawing.Size(81, 17)
		Me.lblItmCode.Location = New System.Drawing.Point(8, 60)
		Me.lblItmCode.TabIndex = 0
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
		Me.Controls.Add(cboWhsCode)
		Me.Controls.Add(cboITMCODE)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(lblWhsCode)
		Me.Controls.Add(lblDspItmName)
		Me.Controls.Add(lblItemChiName)
		Me.Controls.Add(lblItmCode)
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
		Me.mnuPopUpSub.SetIndex(_mnuPopUpSub_0, CType(0, Short))
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mnuPopUp})
		mnuPopUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me._mnuPopUpSub_0})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class