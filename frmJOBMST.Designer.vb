<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmJOBMST
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
	Public WithEvents txtJobCost As System.Windows.Forms.TextBox
	Public WithEvents cboJobNo As System.Windows.Forms.ComboBox
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
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblJobCost As System.Windows.Forms.Label
	Public WithEvents lblJobNo As System.Windows.Forms.Label
	Public WithEvents mnuPopUpSub As Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmJOBMST))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mnuPopUp = New System.Windows.Forms.ToolStripMenuItem
		Me._mnuPopUpSub_0 = New System.Windows.Forms.ToolStripMenuItem
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtJobCost = New System.Windows.Forms.TextBox
		Me.cboJobNo = New System.Windows.Forms.ComboBox
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
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripButton
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.lblJobCost = New System.Windows.Forms.Label
		Me.lblJobNo = New System.Windows.Forms.Label
		Me.mnuPopUpSub = New Microsoft.VisualBasic.Compatibility.VB6.ToolStripMenuItemArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPopUpSub, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "書本對換價"
		Me.ClientSize = New System.Drawing.Size(424, 425)
		Me.Location = New System.Drawing.Point(13110, 18)
		Me.Icon = CType(resources.GetObject("frmJOBMST.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmJOBMST"
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
		Me.tblCommon.Location = New System.Drawing.Point(304, 88)
		Me.tblCommon.TabIndex = 4
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.txtJobCost.AutoSize = False
		Me.txtJobCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtJobCost.Size = New System.Drawing.Size(113, 20)
		Me.txtJobCost.Location = New System.Drawing.Point(112, 88)
		Me.txtJobCost.Maxlength = 20
		Me.txtJobCost.TabIndex = 1
		Me.txtJobCost.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtJobCost.AcceptsReturn = True
		Me.txtJobCost.BackColor = System.Drawing.SystemColors.Window
		Me.txtJobCost.CausesValidation = True
		Me.txtJobCost.Enabled = True
		Me.txtJobCost.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtJobCost.HideSelection = True
		Me.txtJobCost.ReadOnly = False
		Me.txtJobCost.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtJobCost.MultiLine = False
		Me.txtJobCost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtJobCost.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtJobCost.TabStop = True
		Me.txtJobCost.Visible = True
		Me.txtJobCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtJobCost.Name = "txtJobCost"
		Me.cboJobNo.Size = New System.Drawing.Size(233, 20)
		Me.cboJobNo.Location = New System.Drawing.Point(112, 56)
		Me.cboJobNo.TabIndex = 0
		Me.cboJobNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboJobNo.BackColor = System.Drawing.SystemColors.Window
		Me.cboJobNo.CausesValidation = True
		Me.cboJobNo.Enabled = True
		Me.cboJobNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboJobNo.IntegralHeight = True
		Me.cboJobNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboJobNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboJobNo.Sorted = False
		Me.cboJobNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboJobNo.TabStop = True
		Me.cboJobNo.Visible = True
		Me.cboJobNo.Name = "cboJobNo"
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
		Me.tbrProcess.Size = New System.Drawing.Size(424, 24)
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
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.Name = "Exit"
		Me._tbrProcess_Button11.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button11.ImageIndex = 8
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(409, 297)
		Me.tblDetail.Location = New System.Drawing.Point(8, 120)
		Me.tblDetail.TabIndex = 2
		Me.tblDetail.Name = "tblDetail"
		Me.lblJobCost.Text = "PORTNO"
		Me.lblJobCost.Size = New System.Drawing.Size(100, 16)
		Me.lblJobCost.Location = New System.Drawing.Point(8, 88)
		Me.lblJobCost.TabIndex = 6
		Me.lblJobCost.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobCost.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblJobCost.BackColor = System.Drawing.SystemColors.Control
		Me.lblJobCost.Enabled = True
		Me.lblJobCost.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblJobCost.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblJobCost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblJobCost.UseMnemonic = True
		Me.lblJobCost.Visible = True
		Me.lblJobCost.AutoSize = False
		Me.lblJobCost.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblJobCost.Name = "lblJobCost"
		Me.lblJobNo.Text = "ITMCODE"
		Me.lblJobNo.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblJobNo.Size = New System.Drawing.Size(97, 17)
		Me.lblJobNo.Location = New System.Drawing.Point(8, 60)
		Me.lblJobNo.TabIndex = 3
		Me.lblJobNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblJobNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblJobNo.Enabled = True
		Me.lblJobNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblJobNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblJobNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblJobNo.UseMnemonic = True
		Me.lblJobNo.Visible = True
		Me.lblJobNo.AutoSize = False
		Me.lblJobNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblJobNo.Name = "lblJobNo"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtJobCost)
		Me.Controls.Add(cboJobNo)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(lblJobCost)
		Me.Controls.Add(lblJobNo)
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