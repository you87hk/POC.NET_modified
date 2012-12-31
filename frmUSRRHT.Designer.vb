<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUSRRHT
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
	Public WithEvents cboPgmID As System.Windows.Forms.ComboBox
	Public WithEvents cmdSelectAll As System.Windows.Forms.Button
	Public WithEvents cmdUnSelect As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdConvert As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboGrpCode As System.Windows.Forms.ComboBox
	Public WithEvents lblPgmID As System.Windows.Forms.Label
	Public WithEvents lblGrpCode As System.Windows.Forms.Label
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents picStatus As System.Windows.Forms.PictureBox
	Public cdFontFont As System.Windows.Forms.FontDialog
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lstData As System.Windows.Forms.ListView
	Public WithEvents lblSummary As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUSRRHT))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboPgmID = New System.Windows.Forms.ComboBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdSelectAll = New System.Windows.Forms.Button
		Me.cmdUnSelect = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdConvert = New System.Windows.Forms.Button
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboGrpCode = New System.Windows.Forms.ComboBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me.lblPgmID = New System.Windows.Forms.Label
		Me.lblGrpCode = New System.Windows.Forms.Label
		Me.picStatus = New System.Windows.Forms.PictureBox
		Me.cdFontFont = New System.Windows.Forms.FontDialog
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripButton
		Me.lstData = New System.Windows.Forms.ListView
		Me.lblSummary = New System.Windows.Forms.Label
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraSelect.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "User Right Manager"
		Me.ClientSize = New System.Drawing.Size(794, 571)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmUSRRHT.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
		Me.Name = "frmUSRRHT"
		Me.cboPgmID.Size = New System.Drawing.Size(121, 20)
		Me.cboPgmID.Location = New System.Drawing.Point(440, 56)
		Me.cboPgmID.TabIndex = 1
		Me.cboPgmID.Text = "Combo1"
		Me.cboPgmID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPgmID.BackColor = System.Drawing.SystemColors.Window
		Me.cboPgmID.CausesValidation = True
		Me.cboPgmID.Enabled = True
		Me.cboPgmID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPgmID.IntegralHeight = True
		Me.cboPgmID.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPgmID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPgmID.Sorted = False
		Me.cboPgmID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPgmID.TabStop = True
		Me.cboPgmID.Visible = True
		Me.cboPgmID.Name = "cboPgmID"
		Me.Frame2.Size = New System.Drawing.Size(121, 121)
		Me.Frame2.Location = New System.Drawing.Point(672, 288)
		Me.Frame2.TabIndex = 11
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cmdSelectAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSelectAll.Text = "Select All"
		Me.cmdSelectAll.Size = New System.Drawing.Size(105, 49)
		Me.cmdSelectAll.Location = New System.Drawing.Point(8, 16)
		Me.cmdSelectAll.Image = CType(resources.GetObject("cmdSelectAll.Image"), System.Drawing.Image)
		Me.cmdSelectAll.TabIndex = 13
		Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectAll.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSelectAll.CausesValidation = True
		Me.cmdSelectAll.Enabled = True
		Me.cmdSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSelectAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSelectAll.TabStop = True
		Me.cmdSelectAll.Name = "cmdSelectAll"
		Me.cmdUnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdUnSelect.Text = "Unselect All"
		Me.cmdUnSelect.Size = New System.Drawing.Size(105, 49)
		Me.cmdUnSelect.Location = New System.Drawing.Point(8, 64)
		Me.cmdUnSelect.Image = CType(resources.GetObject("cmdUnSelect.Image"), System.Drawing.Image)
		Me.cmdUnSelect.TabIndex = 12
		Me.cmdUnSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUnSelect.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUnSelect.CausesValidation = True
		Me.cmdUnSelect.Enabled = True
		Me.cmdUnSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUnSelect.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUnSelect.TabStop = True
		Me.cmdUnSelect.Name = "cmdUnSelect"
		Me.Frame1.Size = New System.Drawing.Size(121, 73)
		Me.Frame1.Location = New System.Drawing.Point(672, 112)
		Me.Frame1.TabIndex = 9
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmdConvert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdConvert.Text = "Save"
		Me.cmdConvert.Size = New System.Drawing.Size(105, 49)
		Me.cmdConvert.Location = New System.Drawing.Point(8, 16)
		Me.cmdConvert.Image = CType(resources.GetObject("cmdConvert.Image"), System.Drawing.Image)
		Me.cmdConvert.TabIndex = 10
		Me.cmdConvert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdConvert.BackColor = System.Drawing.SystemColors.Control
		Me.cmdConvert.CausesValidation = True
		Me.cmdConvert.Enabled = True
		Me.cmdConvert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdConvert.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdConvert.TabStop = True
		Me.cmdConvert.Name = "cmdConvert"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(744, 24)
		Me.tblCommon.TabIndex = 4
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboGrpCode.Size = New System.Drawing.Size(121, 20)
		Me.cboGrpCode.Location = New System.Drawing.Point(168, 56)
		Me.cboGrpCode.TabIndex = 0
		Me.cboGrpCode.Text = "Combo1"
		Me.cboGrpCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboGrpCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboGrpCode.CausesValidation = True
		Me.cboGrpCode.Enabled = True
		Me.cboGrpCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboGrpCode.IntegralHeight = True
		Me.cboGrpCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboGrpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboGrpCode.Sorted = False
		Me.cboGrpCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboGrpCode.TabStop = True
		Me.cboGrpCode.Visible = True
		Me.cboGrpCode.Name = "cboGrpCode"
		Me.fraSelect.Text = "Selection Criteria"
		Me.fraSelect.Size = New System.Drawing.Size(769, 57)
		Me.fraSelect.Location = New System.Drawing.Point(8, 32)
		Me.fraSelect.TabIndex = 7
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me.lblPgmID.Text = "Document # From"
		Me.lblPgmID.Size = New System.Drawing.Size(110, 15)
		Me.lblPgmID.Location = New System.Drawing.Point(320, 24)
		Me.lblPgmID.TabIndex = 14
		Me.lblPgmID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPgmID.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPgmID.BackColor = System.Drawing.SystemColors.Control
		Me.lblPgmID.Enabled = True
		Me.lblPgmID.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPgmID.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPgmID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPgmID.UseMnemonic = True
		Me.lblPgmID.Visible = True
		Me.lblPgmID.AutoSize = False
		Me.lblPgmID.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPgmID.Name = "lblPgmID"
		Me.lblGrpCode.Text = "Document # From"
		Me.lblGrpCode.Size = New System.Drawing.Size(126, 15)
		Me.lblGrpCode.Location = New System.Drawing.Point(32, 26)
		Me.lblGrpCode.TabIndex = 8
		Me.lblGrpCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrpCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblGrpCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblGrpCode.Enabled = True
		Me.lblGrpCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGrpCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGrpCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGrpCode.UseMnemonic = True
		Me.lblGrpCode.Visible = True
		Me.lblGrpCode.AutoSize = False
		Me.lblGrpCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGrpCode.Name = "lblGrpCode"
		Me.picStatus.BackColor = System.Drawing.Color.White
		Me.picStatus.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatus.Size = New System.Drawing.Size(771, 20)
		Me.picStatus.Location = New System.Drawing.Point(8, 552)
		Me.picStatus.TabIndex = 5
		Me.picStatus.TabStop = False
		Me.picStatus.Dock = System.Windows.Forms.DockStyle.None
		Me.picStatus.CausesValidation = True
		Me.picStatus.Enabled = True
		Me.picStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.picStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picStatus.Visible = True
		Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picStatus.Name = "picStatus"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.iglProcess.ImageStream = CType(resources.GetObject("iglProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.iglProcess.Images.SetKeyName(0, "")
		Me.iglProcess.Images.SetKeyName(1, "")
		Me.iglProcess.Images.SetKeyName(2, "")
		Me.iglProcess.Images.SetKeyName(3, "")
		Me.iglProcess.Images.SetKeyName(4, "")
		Me.iglProcess.Images.SetKeyName(5, "book")
		Me.iglProcess.Images.SetKeyName(6, "book1")
		Me.iglProcess.Images.SetKeyName(7, "StockIn")
		Me.iglProcess.Images.SetKeyName(8, "StockOut")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(794, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 3
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
		Me._tbrProcess_Button2.ImageIndex = 1
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Cancel"
		Me._tbrProcess_Button3.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Refresh"
		Me._tbrProcess_Button4.ImageIndex = 2
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Font"
		Me._tbrProcess_Button5.ImageIndex = 4
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.Name = "Exit"
		Me._tbrProcess_Button6.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button6.ImageIndex = 3
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lstData.Size = New System.Drawing.Size(662, 438)
		Me.lstData.Location = New System.Drawing.Point(8, 112)
		Me.lstData.TabIndex = 2
		Me.lstData.View = System.Windows.Forms.View.Details
		Me.lstData.LabelWrap = True
		Me.lstData.HideSelection = True
		Me.lstData.Checkboxes = True
		Me.lstData.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstData.BackColor = System.Drawing.SystemColors.Window
		Me.lstData.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstData.LabelEdit = True
		Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstData.Name = "lstData"
		Me.lblSummary.Text = "Label1"
		Me.lblSummary.Size = New System.Drawing.Size(785, 14)
		Me.lblSummary.Location = New System.Drawing.Point(8, 96)
		Me.lblSummary.TabIndex = 6
		Me.lblSummary.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSummary.BackColor = System.Drawing.SystemColors.Control
		Me.lblSummary.Enabled = True
		Me.lblSummary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSummary.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSummary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSummary.UseMnemonic = True
		Me.lblSummary.Visible = True
		Me.lblSummary.AutoSize = False
		Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblSummary.Name = "lblSummary"
		Me.Controls.Add(cboPgmID)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboGrpCode)
		Me.Controls.Add(fraSelect)
		Me.Controls.Add(picStatus)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lstData)
		Me.Controls.Add(lblSummary)
		Me.Frame2.Controls.Add(cmdSelectAll)
		Me.Frame2.Controls.Add(cmdUnSelect)
		Me.Frame1.Controls.Add(cmdConvert)
		Me.fraSelect.Controls.Add(lblPgmID)
		Me.fraSelect.Controls.Add(lblGrpCode)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraSelect.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class