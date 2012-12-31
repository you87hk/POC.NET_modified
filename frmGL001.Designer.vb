<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGL001
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
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents txtRemark As System.Windows.Forms.TextBox
	Public WithEvents cboPfx As System.Windows.Forms.ComboBox
	Public WithEvents txtRevNo As System.Windows.Forms.TextBox
	Public WithEvents cboDocNo As System.Windows.Forms.ComboBox
	Public WithEvents medDocDate As System.Windows.Forms.MaskedTextBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button13 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblRemark As System.Windows.Forms.Label
	Public WithEvents lblBalAmtLoc As System.Windows.Forms.Label
	Public WithEvents lblDspBalAmtLoc As System.Windows.Forms.Label
	Public WithEvents lblCtlPrd As System.Windows.Forms.Label
	Public WithEvents lblDspCtlPrd As System.Windows.Forms.Label
	Public WithEvents lblDocDate As System.Windows.Forms.Label
	Public WithEvents lblRevNo As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGL001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtRemark = New System.Windows.Forms.TextBox
		Me.cboPfx = New System.Windows.Forms.ComboBox
		Me.txtRevNo = New System.Windows.Forms.TextBox
		Me.cboDocNo = New System.Windows.Forms.ComboBox
		Me.medDocDate = New System.Windows.Forms.MaskedTextBox
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
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button13 = New System.Windows.Forms.ToolStripButton
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.lblRemark = New System.Windows.Forms.Label
		Me.lblBalAmtLoc = New System.Windows.Forms.Label
		Me.lblDspBalAmtLoc = New System.Windows.Forms.Label
		Me.lblCtlPrd = New System.Windows.Forms.Label
		Me.lblDspCtlPrd = New System.Windows.Forms.Label
		Me.lblDocDate = New System.Windows.Forms.Label
		Me.lblRevNo = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "訂貨單"
		Me.ClientSize = New System.Drawing.Size(653, 465)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmGL001.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmGL001"
		Me.mnuPopUp.Name = "mnuPopUp"
		Me.mnuPopUp.Text = "Pop Up"
		Me.mnuPopUp.Visible = False
		Me.mnuPopUp.Checked = False
		Me.mnuPopUp.Enabled = True
		Me._mnuPopUpSub_0.Name = "_mnuPopUpSub_0"
		Me._mnuPopUpSub_0.Text = ""
		Me._mnuPopUpSub_0.Checked = False
		Me._mnuPopUpSub_0.Enabled = True
		Me._mnuPopUpSub_0.Visible = True
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(656, 40)
		Me.tblCommon.TabIndex = 9
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.txtRemark.AutoSize = False
		Me.txtRemark.Enabled = False
		Me.txtRemark.Size = New System.Drawing.Size(391, 20)
		Me.txtRemark.Location = New System.Drawing.Point(88, 104)
		Me.txtRemark.TabIndex = 4
		Me.txtRemark.Text = "01234567890123457890"
		Me.txtRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRemark.AcceptsReturn = True
		Me.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRemark.BackColor = System.Drawing.SystemColors.Window
		Me.txtRemark.CausesValidation = True
		Me.txtRemark.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRemark.HideSelection = True
		Me.txtRemark.ReadOnly = False
		Me.txtRemark.Maxlength = 0
		Me.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRemark.MultiLine = False
		Me.txtRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRemark.TabStop = True
		Me.txtRemark.Visible = True
		Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRemark.Name = "txtRemark"
		Me.cboPfx.Size = New System.Drawing.Size(65, 20)
		Me.cboPfx.Location = New System.Drawing.Point(88, 56)
		Me.cboPfx.TabIndex = 0
		Me.cboPfx.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPfx.BackColor = System.Drawing.SystemColors.Window
		Me.cboPfx.CausesValidation = True
		Me.cboPfx.Enabled = True
		Me.cboPfx.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPfx.IntegralHeight = True
		Me.cboPfx.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPfx.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPfx.Sorted = False
		Me.cboPfx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPfx.TabStop = True
		Me.cboPfx.Visible = True
		Me.cboPfx.Name = "cboPfx"
		Me.txtRevNo.AutoSize = False
		Me.txtRevNo.Size = New System.Drawing.Size(28, 22)
		Me.txtRevNo.Location = New System.Drawing.Point(392, 56)
		Me.txtRevNo.Maxlength = 3
		Me.txtRevNo.TabIndex = 2
		Me.txtRevNo.Text = "12345678901234567890"
		Me.txtRevNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRevNo.AcceptsReturn = True
		Me.txtRevNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRevNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtRevNo.CausesValidation = True
		Me.txtRevNo.Enabled = True
		Me.txtRevNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRevNo.HideSelection = True
		Me.txtRevNo.ReadOnly = False
		Me.txtRevNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRevNo.MultiLine = False
		Me.txtRevNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRevNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRevNo.TabStop = True
		Me.txtRevNo.Visible = True
		Me.txtRevNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRevNo.Name = "txtRevNo"
		Me.cboDocNo.Size = New System.Drawing.Size(129, 20)
		Me.cboDocNo.Location = New System.Drawing.Point(160, 56)
		Me.cboDocNo.TabIndex = 1
		Me.cboDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNo.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNo.CausesValidation = True
		Me.cboDocNo.Enabled = True
		Me.cboDocNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNo.IntegralHeight = True
		Me.cboDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNo.Sorted = False
		Me.cboDocNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNo.TabStop = True
		Me.cboDocNo.Visible = True
		Me.cboDocNo.Name = "cboDocNo"
		Me.medDocDate.AllowPromptAsInput = False
		Me.medDocDate.Size = New System.Drawing.Size(89, 19)
		Me.medDocDate.Location = New System.Drawing.Point(88, 80)
		Me.medDocDate.TabIndex = 3
		Me.medDocDate.MaxLength = 10
		Me.medDocDate.Mask = "##/##/####"
		Me.medDocDate.PromptChar = "_"
		Me.medDocDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medDocDate.Name = "medDocDate"
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
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(653, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 24)
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
		Me._tbrProcess_Button2.Name = "Open"
		Me._tbrProcess_Button2.ToolTipText = "Open (F6)"
		Me._tbrProcess_Button2.ImageIndex = 11
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
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
		Me._tbrProcess_Button7.Name = "Print"
		Me._tbrProcess_Button7.ImageIndex = 12
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Save"
		Me._tbrProcess_Button8.ToolTipText = "Save (F10)"
		Me._tbrProcess_Button8.ImageIndex = 3
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.Name = "Cancel"
		Me._tbrProcess_Button9.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button9.ImageIndex = 4
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Visible = 0
		Me._tbrProcess_Button11.Name = "Find"
		Me._tbrProcess_Button11.ToolTipText = "Find (F9)"
		Me._tbrProcess_Button11.ImageIndex = 6
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Visible = 0
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button13.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button13.AutoSize = False
		Me._tbrProcess_Button13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button13.Name = "Exit"
		Me._tbrProcess_Button13.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button13.ImageIndex = 8
		Me._tbrProcess_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(769, 425)
		Me.tblDetail.Location = New System.Drawing.Point(8, 128)
		Me.tblDetail.TabIndex = 5
		Me.tblDetail.Name = "tblDetail"
		Me.lblRemark.Text = "REMARK"
		Me.lblRemark.Size = New System.Drawing.Size(76, 16)
		Me.lblRemark.Location = New System.Drawing.Point(8, 104)
		Me.lblRemark.TabIndex = 15
		Me.lblRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRemark.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRemark.BackColor = System.Drawing.SystemColors.Control
		Me.lblRemark.Enabled = True
		Me.lblRemark.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRemark.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRemark.UseMnemonic = True
		Me.lblRemark.Visible = True
		Me.lblRemark.AutoSize = False
		Me.lblRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRemark.Name = "lblRemark"
		Me.lblBalAmtLoc.Text = "NETAMTLOC"
		Me.lblBalAmtLoc.Size = New System.Drawing.Size(117, 17)
		Me.lblBalAmtLoc.Location = New System.Drawing.Point(568, 564)
		Me.lblBalAmtLoc.TabIndex = 14
		Me.lblBalAmtLoc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBalAmtLoc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBalAmtLoc.BackColor = System.Drawing.SystemColors.Control
		Me.lblBalAmtLoc.Enabled = True
		Me.lblBalAmtLoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBalAmtLoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBalAmtLoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBalAmtLoc.UseMnemonic = True
		Me.lblBalAmtLoc.Visible = True
		Me.lblBalAmtLoc.AutoSize = False
		Me.lblBalAmtLoc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBalAmtLoc.Name = "lblBalAmtLoc"
		Me.lblDspBalAmtLoc.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblDspBalAmtLoc.Text = "9.999.999.999.99"
		Me.lblDspBalAmtLoc.ForeColor = System.Drawing.Color.Blue
		Me.lblDspBalAmtLoc.Size = New System.Drawing.Size(86, 20)
		Me.lblDspBalAmtLoc.Location = New System.Drawing.Point(688, 564)
		Me.lblDspBalAmtLoc.TabIndex = 13
		Me.lblDspBalAmtLoc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspBalAmtLoc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspBalAmtLoc.Enabled = True
		Me.lblDspBalAmtLoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspBalAmtLoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspBalAmtLoc.UseMnemonic = True
		Me.lblDspBalAmtLoc.Visible = True
		Me.lblDspBalAmtLoc.AutoSize = False
		Me.lblDspBalAmtLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspBalAmtLoc.Name = "lblDspBalAmtLoc"
		Me.lblCtlPrd.Text = "CTLPRD"
		Me.lblCtlPrd.Size = New System.Drawing.Size(81, 17)
		Me.lblCtlPrd.Location = New System.Drawing.Point(304, 84)
		Me.lblCtlPrd.TabIndex = 12
		Me.lblCtlPrd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCtlPrd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCtlPrd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCtlPrd.Enabled = True
		Me.lblCtlPrd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCtlPrd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCtlPrd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCtlPrd.UseMnemonic = True
		Me.lblCtlPrd.Visible = True
		Me.lblCtlPrd.AutoSize = False
		Me.lblCtlPrd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCtlPrd.Name = "lblCtlPrd"
		Me.lblDspCtlPrd.Size = New System.Drawing.Size(89, 20)
		Me.lblDspCtlPrd.Location = New System.Drawing.Point(392, 80)
		Me.lblDspCtlPrd.TabIndex = 11
		Me.lblDspCtlPrd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCtlPrd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCtlPrd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCtlPrd.Enabled = True
		Me.lblDspCtlPrd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCtlPrd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCtlPrd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCtlPrd.UseMnemonic = True
		Me.lblDspCtlPrd.Visible = True
		Me.lblDspCtlPrd.AutoSize = False
		Me.lblDspCtlPrd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCtlPrd.Name = "lblDspCtlPrd"
		Me.lblDocDate.Text = "DOCDATE"
		Me.lblDocDate.Size = New System.Drawing.Size(80, 17)
		Me.lblDocDate.Location = New System.Drawing.Point(8, 84)
		Me.lblDocDate.TabIndex = 8
		Me.lblDocDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocDate.Enabled = True
		Me.lblDocDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocDate.UseMnemonic = True
		Me.lblDocDate.Visible = True
		Me.lblDocDate.AutoSize = False
		Me.lblDocDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocDate.Name = "lblDocDate"
		Me.lblRevNo.Text = "REVNO"
		Me.lblRevNo.Size = New System.Drawing.Size(81, 17)
		Me.lblRevNo.Location = New System.Drawing.Point(304, 60)
		Me.lblRevNo.TabIndex = 7
		Me.lblRevNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRevNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRevNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblRevNo.Enabled = True
		Me.lblRevNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRevNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRevNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRevNo.UseMnemonic = True
		Me.lblRevNo.Visible = True
		Me.lblRevNo.AutoSize = False
		Me.lblRevNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRevNo.Name = "lblRevNo"
		Me.lblDocNo.Text = "DOCNO"
		Me.lblDocNo.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblDocNo.Size = New System.Drawing.Size(81, 17)
		Me.lblDocNo.Location = New System.Drawing.Point(8, 60)
		Me.lblDocNo.TabIndex = 6
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
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtRemark)
		Me.Controls.Add(cboPfx)
		Me.Controls.Add(txtRevNo)
		Me.Controls.Add(cboDocNo)
		Me.Controls.Add(medDocDate)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(lblRemark)
		Me.Controls.Add(lblBalAmtLoc)
		Me.Controls.Add(lblDspBalAmtLoc)
		Me.Controls.Add(lblCtlPrd)
		Me.Controls.Add(lblDspCtlPrd)
		Me.Controls.Add(lblDocDate)
		Me.Controls.Add(lblRevNo)
		Me.Controls.Add(lblDocNo)
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
		Me.tbrProcess.Items.Add(_tbrProcess_Button13)
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