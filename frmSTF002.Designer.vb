<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSTF002
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
	Public WithEvents _optStaffType_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optStaffType_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optStaffType_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboStaffCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboStaffCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblStaffType As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblStaffCodeTo As System.Windows.Forms.Label
	Public WithEvents lblStaffCodeFr As System.Windows.Forms.Label
	Public WithEvents optStaffType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSTF002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optStaffType_2 = New System.Windows.Forms.RadioButton
		Me._optStaffType_1 = New System.Windows.Forms.RadioButton
		Me._optStaffType_0 = New System.Windows.Forms.RadioButton
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboStaffCodeTo = New System.Windows.Forms.ComboBox
		Me.cboStaffCodeFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblStaffType = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblStaffCodeTo = New System.Windows.Forms.Label
		Me.lblStaffCodeFr = New System.Windows.Forms.Label
		Me.optStaffType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optStaffType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "STF002"
		Me.ClientSize = New System.Drawing.Size(613, 229)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.KeyPreview = True
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSTF002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 8
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.Frame1.Size = New System.Drawing.Size(297, 33)
		Me.Frame1.Location = New System.Drawing.Point(184, 112)
		Me.Frame1.TabIndex = 10
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optStaffType_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStaffType_2.Text = "SALESMAN"
		Me._optStaffType_2.Size = New System.Drawing.Size(86, 19)
		Me._optStaffType_2.Location = New System.Drawing.Point(104, 12)
		Me._optStaffType_2.TabIndex = 4
		Me._optStaffType_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optStaffType_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStaffType_2.BackColor = System.Drawing.SystemColors.Control
		Me._optStaffType_2.CausesValidation = True
		Me._optStaffType_2.Enabled = True
		Me._optStaffType_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optStaffType_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optStaffType_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optStaffType_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optStaffType_2.TabStop = True
		Me._optStaffType_2.Checked = False
		Me._optStaffType_2.Visible = True
		Me._optStaffType_2.Name = "_optStaffType_2"
		Me._optStaffType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStaffType_1.Text = "WORKER"
		Me._optStaffType_1.Size = New System.Drawing.Size(89, 19)
		Me._optStaffType_1.Location = New System.Drawing.Point(8, 12)
		Me._optStaffType_1.TabIndex = 3
		Me._optStaffType_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optStaffType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStaffType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optStaffType_1.CausesValidation = True
		Me._optStaffType_1.Enabled = True
		Me._optStaffType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optStaffType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optStaffType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optStaffType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optStaffType_1.TabStop = True
		Me._optStaffType_1.Checked = False
		Me._optStaffType_1.Visible = True
		Me._optStaffType_1.Name = "_optStaffType_1"
		Me._optStaffType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStaffType_0.Text = "ALL"
		Me._optStaffType_0.Size = New System.Drawing.Size(70, 19)
		Me._optStaffType_0.Location = New System.Drawing.Point(200, 12)
		Me._optStaffType_0.TabIndex = 5
		Me._optStaffType_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optStaffType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStaffType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optStaffType_0.CausesValidation = True
		Me._optStaffType_0.Enabled = True
		Me._optStaffType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optStaffType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optStaffType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optStaffType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optStaffType_0.TabStop = True
		Me._optStaffType_0.Checked = False
		Me._optStaffType_0.Visible = True
		Me._optStaffType_0.Name = "_optStaffType_0"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(186, 48)
		Me.txtTitle.TabIndex = 0
		Me.txtTitle.Text = "01234567890123457890"
		Me.txtTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTitle.AcceptsReturn = True
		Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
		Me.txtTitle.CausesValidation = True
		Me.txtTitle.Enabled = True
		Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTitle.HideSelection = True
		Me.txtTitle.ReadOnly = False
		Me.txtTitle.Maxlength = 0
		Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTitle.MultiLine = False
		Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTitle.TabStop = True
		Me.txtTitle.Visible = True
		Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTitle.Name = "txtTitle"
		Me.cboStaffCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboStaffCodeTo.Location = New System.Drawing.Point(372, 85)
		Me.cboStaffCodeTo.TabIndex = 2
		Me.cboStaffCodeTo.Text = "Combo1"
		Me.cboStaffCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStaffCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboStaffCodeTo.CausesValidation = True
		Me.cboStaffCodeTo.Enabled = True
		Me.cboStaffCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboStaffCodeTo.IntegralHeight = True
		Me.cboStaffCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboStaffCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboStaffCodeTo.Sorted = False
		Me.cboStaffCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboStaffCodeTo.TabStop = True
		Me.cboStaffCodeTo.Visible = True
		Me.cboStaffCodeTo.Name = "cboStaffCodeTo"
		Me.cboStaffCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboStaffCodeFr.Location = New System.Drawing.Point(186, 85)
		Me.cboStaffCodeFr.TabIndex = 1
		Me.cboStaffCodeFr.Text = "Combo1"
		Me.cboStaffCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStaffCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboStaffCodeFr.CausesValidation = True
		Me.cboStaffCodeFr.Enabled = True
		Me.cboStaffCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboStaffCodeFr.IntegralHeight = True
		Me.cboStaffCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboStaffCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboStaffCodeFr.Sorted = False
		Me.cboStaffCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboStaffCodeFr.TabStop = True
		Me.cboStaffCodeFr.Visible = True
		Me.cboStaffCodeFr.Name = "cboStaffCodeFr"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
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
		Me.tbrProcess.Size = New System.Drawing.Size(613, 24)
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
		Me._tbrProcess_Button2.Name = "Go"
		Me._tbrProcess_Button2.ToolTipText = "Go (F9)"
		Me._tbrProcess_Button2.ImageIndex = 6
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Cancel"
		Me._tbrProcess_Button3.ToolTipText = "Cancel (F11)"
		Me._tbrProcess_Button3.ImageIndex = 4
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Exit"
		Me._tbrProcess_Button4.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button4.ImageIndex = 8
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblStaffType.Text = "STAFFTYPE"
		Me.lblStaffType.Size = New System.Drawing.Size(120, 17)
		Me.lblStaffType.Location = New System.Drawing.Point(56, 124)
		Me.lblStaffType.TabIndex = 11
		Me.lblStaffType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffType.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffType.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffType.Enabled = True
		Me.lblStaffType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffType.UseMnemonic = True
		Me.lblStaffType.Visible = True
		Me.lblStaffType.AutoSize = False
		Me.lblStaffType.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffType.Name = "lblStaffType"
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(58, 52)
		Me.lblTitle.TabIndex = 9
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.Enabled = True
		Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me.lblStaffCodeTo.Text = "STAFFCODETO"
		Me.lblStaffCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblStaffCodeTo.Location = New System.Drawing.Point(348, 89)
		Me.lblStaffCodeTo.TabIndex = 7
		Me.lblStaffCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffCodeTo.Enabled = True
		Me.lblStaffCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffCodeTo.UseMnemonic = True
		Me.lblStaffCodeTo.Visible = True
		Me.lblStaffCodeTo.AutoSize = False
		Me.lblStaffCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffCodeTo.Name = "lblStaffCodeTo"
		Me.lblStaffCodeFr.Text = "STAFFCODEFR"
		Me.lblStaffCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblStaffCodeFr.Location = New System.Drawing.Point(58, 89)
		Me.lblStaffCodeFr.TabIndex = 6
		Me.lblStaffCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStaffCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStaffCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblStaffCodeFr.Enabled = True
		Me.lblStaffCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStaffCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStaffCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStaffCodeFr.UseMnemonic = True
		Me.lblStaffCodeFr.Visible = True
		Me.lblStaffCodeFr.AutoSize = False
		Me.lblStaffCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStaffCodeFr.Name = "lblStaffCodeFr"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboStaffCodeTo)
		Me.Controls.Add(cboStaffCodeFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblStaffType)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblStaffCodeTo)
		Me.Controls.Add(lblStaffCodeFr)
		Me.Frame1.Controls.Add(_optStaffType_2)
		Me.Frame1.Controls.Add(_optStaffType_1)
		Me.Frame1.Controls.Add(_optStaffType_0)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optStaffType.SetIndex(_optStaffType_2, CType(2, Short))
		Me.optStaffType.SetIndex(_optStaffType_1, CType(1, Short))
		Me.optStaffType.SetIndex(_optStaffType_0, CType(0, Short))
		CType(Me.optStaffType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class