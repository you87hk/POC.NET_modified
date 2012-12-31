<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPURGE
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
	Public WithEvents cmdSelectAll As System.Windows.Forms.Button
	Public WithEvents cmdUnSelect As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdRecycle As System.Windows.Forms.Button
	Public WithEvents cmdPurge As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cboTblName As System.Windows.Forms.ComboBox
	Public WithEvents lblTblName As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPURGE))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdSelectAll = New System.Windows.Forms.Button
		Me.cmdUnSelect = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdRecycle = New System.Windows.Forms.Button
		Me.cmdPurge = New System.Windows.Forms.Button
		Me.cboTblName = New System.Windows.Forms.ComboBox
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me.lblTblName = New System.Windows.Forms.Label
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
		Me.Text = "Purge Data"
		Me.ClientSize = New System.Drawing.Size(794, 571)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmPURGE.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPURGE"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 129)
		Me.tblCommon.Location = New System.Drawing.Point(520, 24)
		Me.tblCommon.TabIndex = 3
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.Frame2.Size = New System.Drawing.Size(121, 121)
		Me.Frame2.Location = New System.Drawing.Point(672, 288)
		Me.Frame2.TabIndex = 10
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
		Me.cmdSelectAll.TabIndex = 12
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
		Me.cmdUnSelect.TabIndex = 11
		Me.cmdUnSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUnSelect.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUnSelect.CausesValidation = True
		Me.cmdUnSelect.Enabled = True
		Me.cmdUnSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUnSelect.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUnSelect.TabStop = True
		Me.cmdUnSelect.Name = "cmdUnSelect"
		Me.Frame1.Size = New System.Drawing.Size(121, 129)
		Me.Frame1.Location = New System.Drawing.Point(672, 112)
		Me.Frame1.TabIndex = 8
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmdRecycle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdRecycle.Text = "Recycle"
		Me.cmdRecycle.Size = New System.Drawing.Size(105, 49)
		Me.cmdRecycle.Location = New System.Drawing.Point(8, 64)
		Me.cmdRecycle.Image = CType(resources.GetObject("cmdRecycle.Image"), System.Drawing.Image)
		Me.cmdRecycle.TabIndex = 13
		Me.cmdRecycle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRecycle.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRecycle.CausesValidation = True
		Me.cmdRecycle.Enabled = True
		Me.cmdRecycle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRecycle.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRecycle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRecycle.TabStop = True
		Me.cmdRecycle.Name = "cmdRecycle"
		Me.cmdPurge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPurge.Text = "Purge"
		Me.cmdPurge.Size = New System.Drawing.Size(105, 49)
		Me.cmdPurge.Location = New System.Drawing.Point(8, 16)
		Me.cmdPurge.Image = CType(resources.GetObject("cmdPurge.Image"), System.Drawing.Image)
		Me.cmdPurge.TabIndex = 9
		Me.cmdPurge.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPurge.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPurge.CausesValidation = True
		Me.cmdPurge.Enabled = True
		Me.cmdPurge.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPurge.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPurge.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPurge.TabStop = True
		Me.cmdPurge.Name = "cmdPurge"
		Me.cboTblName.Size = New System.Drawing.Size(161, 20)
		Me.cboTblName.Location = New System.Drawing.Point(168, 56)
		Me.cboTblName.TabIndex = 0
		Me.cboTblName.Text = "Combo1"
		Me.cboTblName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTblName.BackColor = System.Drawing.SystemColors.Window
		Me.cboTblName.CausesValidation = True
		Me.cboTblName.Enabled = True
		Me.cboTblName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTblName.IntegralHeight = True
		Me.cboTblName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTblName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTblName.Sorted = False
		Me.cboTblName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboTblName.TabStop = True
		Me.cboTblName.Visible = True
		Me.cboTblName.Name = "cboTblName"
		Me.fraSelect.Text = "Selection Criteria"
		Me.fraSelect.Size = New System.Drawing.Size(769, 57)
		Me.fraSelect.Location = New System.Drawing.Point(8, 32)
		Me.fraSelect.TabIndex = 6
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me.lblTblName.Text = "Table Name"
		Me.lblTblName.Size = New System.Drawing.Size(126, 15)
		Me.lblTblName.Location = New System.Drawing.Point(32, 26)
		Me.lblTblName.TabIndex = 7
		Me.lblTblName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTblName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTblName.BackColor = System.Drawing.SystemColors.Control
		Me.lblTblName.Enabled = True
		Me.lblTblName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTblName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTblName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTblName.UseMnemonic = True
		Me.lblTblName.Visible = True
		Me.lblTblName.AutoSize = False
		Me.lblTblName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTblName.Name = "lblTblName"
		Me.picStatus.BackColor = System.Drawing.Color.White
		Me.picStatus.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatus.Size = New System.Drawing.Size(771, 20)
		Me.picStatus.Location = New System.Drawing.Point(8, 552)
		Me.picStatus.TabIndex = 4
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
		Me.tbrProcess.TabIndex = 2
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
		Me.lstData.TabIndex = 1
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
		Me.lblSummary.TabIndex = 5
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
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cboTblName)
		Me.Controls.Add(fraSelect)
		Me.Controls.Add(picStatus)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lstData)
		Me.Controls.Add(lblSummary)
		Me.Frame2.Controls.Add(cmdSelectAll)
		Me.Frame2.Controls.Add(cmdUnSelect)
		Me.Frame1.Controls.Add(cmdRecycle)
		Me.Frame1.Controls.Add(cmdPurge)
		Me.fraSelect.Controls.Add(lblTblName)
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