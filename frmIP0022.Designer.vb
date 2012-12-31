<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmIP0022
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
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboItmCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboItmCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrCode As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblItmCodeFr As System.Windows.Forms.Label
	Public WithEvents lblItmCodeTo As System.Windows.Forms.Label
	Public WithEvents lblVdrCode As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIP0022))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboItmCodeFr = New System.Windows.Forms.ComboBox
		Me.cboItmCodeTo = New System.Windows.Forms.ComboBox
		Me.cboVdrCode = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblItmCodeFr = New System.Windows.Forms.Label
		Me.lblItmCodeTo = New System.Windows.Forms.Label
		Me.lblVdrCode = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "IP0021"
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
		Me.Name = "frmIP0022"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 5
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
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
		Me.cboItmCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeFr.Location = New System.Drawing.Point(186, 74)
		Me.cboItmCodeFr.TabIndex = 1
		Me.cboItmCodeFr.Text = "Combo1"
		Me.cboItmCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCodeFr.CausesValidation = True
		Me.cboItmCodeFr.Enabled = True
		Me.cboItmCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCodeFr.IntegralHeight = True
		Me.cboItmCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCodeFr.Sorted = False
		Me.cboItmCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCodeFr.TabStop = True
		Me.cboItmCodeFr.Visible = True
		Me.cboItmCodeFr.Name = "cboItmCodeFr"
		Me.cboItmCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboItmCodeTo.Location = New System.Drawing.Point(372, 74)
		Me.cboItmCodeTo.TabIndex = 2
		Me.cboItmCodeTo.Text = "Combo1"
		Me.cboItmCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboItmCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboItmCodeTo.CausesValidation = True
		Me.cboItmCodeTo.Enabled = True
		Me.cboItmCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboItmCodeTo.IntegralHeight = True
		Me.cboItmCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboItmCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboItmCodeTo.Sorted = False
		Me.cboItmCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboItmCodeTo.TabStop = True
		Me.cboItmCodeTo.Visible = True
		Me.cboItmCodeTo.Name = "cboItmCodeTo"
		Me.cboVdrCode.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrCode.Location = New System.Drawing.Point(186, 101)
		Me.cboVdrCode.TabIndex = 3
		Me.cboVdrCode.Text = "Combo1"
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
		Me.lblTitle.Text = "TITLE"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(58, 51)
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
		Me.lblItmCodeFr.Text = "ITMCODEFR"
		Me.lblItmCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblItmCodeFr.Location = New System.Drawing.Point(58, 77)
		Me.lblItmCodeFr.TabIndex = 7
		Me.lblItmCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCodeFr.Enabled = True
		Me.lblItmCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCodeFr.UseMnemonic = True
		Me.lblItmCodeFr.Visible = True
		Me.lblItmCodeFr.AutoSize = False
		Me.lblItmCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCodeFr.Name = "lblItmCodeFr"
		Me.lblItmCodeTo.Text = "ITMCODETO"
		Me.lblItmCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblItmCodeTo.Location = New System.Drawing.Point(348, 77)
		Me.lblItmCodeTo.TabIndex = 6
		Me.lblItmCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItmCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblItmCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblItmCodeTo.Enabled = True
		Me.lblItmCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblItmCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblItmCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblItmCodeTo.UseMnemonic = True
		Me.lblItmCodeTo.Visible = True
		Me.lblItmCodeTo.AutoSize = False
		Me.lblItmCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblItmCodeTo.Name = "lblItmCodeTo"
		Me.lblVdrCode.Text = "VDRCODE"
		Me.lblVdrCode.Size = New System.Drawing.Size(126, 15)
		Me.lblVdrCode.Location = New System.Drawing.Point(58, 103)
		Me.lblVdrCode.TabIndex = 4
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
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboItmCodeFr)
		Me.Controls.Add(cboItmCodeTo)
		Me.Controls.Add(cboVdrCode)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblItmCodeFr)
		Me.Controls.Add(lblItmCodeTo)
		Me.Controls.Add(lblVdrCode)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class