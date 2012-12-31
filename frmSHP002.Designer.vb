<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSHP002
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
	Public WithEvents _optCard_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optCard_0 As System.Windows.Forms.RadioButton
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboShipCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboShipCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblShipCodeTo As System.Windows.Forms.Label
	Public WithEvents lblShipCodeFr As System.Windows.Forms.Label
	Public WithEvents optCard As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSHP002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._optCard_1 = New System.Windows.Forms.RadioButton
		Me._optCard_0 = New System.Windows.Forms.RadioButton
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboShipCodeTo = New System.Windows.Forms.ComboBox
		Me.cboShipCodeFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblShipCodeTo = New System.Windows.Forms.Label
		Me.lblShipCodeFr = New System.Windows.Forms.Label
		Me.optCard = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optCard, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "SHP002"
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
		Me.Name = "frmSHP002"
		Me._optCard_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCard_1.Text = "CARDCUS"
		Me._optCard_1.Size = New System.Drawing.Size(89, 17)
		Me._optCard_1.Location = New System.Drawing.Point(312, 88)
		Me._optCard_1.TabIndex = 2
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
		Me._optCard_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optCard_0.Text = "CARDVDR"
		Me._optCard_0.Size = New System.Drawing.Size(81, 17)
		Me._optCard_0.Location = New System.Drawing.Point(184, 88)
		Me._optCard_0.TabIndex = 1
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
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 7
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
		Me.cboShipCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboShipCodeTo.Location = New System.Drawing.Point(376, 117)
		Me.cboShipCodeTo.TabIndex = 4
		Me.cboShipCodeTo.Text = "Combo1"
		Me.cboShipCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboShipCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboShipCodeTo.CausesValidation = True
		Me.cboShipCodeTo.Enabled = True
		Me.cboShipCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboShipCodeTo.IntegralHeight = True
		Me.cboShipCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboShipCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboShipCodeTo.Sorted = False
		Me.cboShipCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboShipCodeTo.TabStop = True
		Me.cboShipCodeTo.Visible = True
		Me.cboShipCodeTo.Name = "cboShipCodeTo"
		Me.cboShipCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboShipCodeFr.Location = New System.Drawing.Point(186, 117)
		Me.cboShipCodeFr.TabIndex = 3
		Me.cboShipCodeFr.Text = "Combo1"
		Me.cboShipCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboShipCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboShipCodeFr.CausesValidation = True
		Me.cboShipCodeFr.Enabled = True
		Me.cboShipCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboShipCodeFr.IntegralHeight = True
		Me.cboShipCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboShipCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboShipCodeFr.Sorted = False
		Me.cboShipCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboShipCodeFr.TabStop = True
		Me.cboShipCodeFr.Visible = True
		Me.cboShipCodeFr.Name = "cboShipCodeFr"
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
		Me.lblShipCodeTo.Text = "SHIPCODETO"
		Me.lblShipCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblShipCodeTo.Location = New System.Drawing.Point(348, 119)
		Me.lblShipCodeTo.TabIndex = 6
		Me.lblShipCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipCodeTo.Enabled = True
		Me.lblShipCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipCodeTo.UseMnemonic = True
		Me.lblShipCodeTo.Visible = True
		Me.lblShipCodeTo.AutoSize = False
		Me.lblShipCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipCodeTo.Name = "lblShipCodeTo"
		Me.lblShipCodeFr.Text = "SHIPCODEFR"
		Me.lblShipCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblShipCodeFr.Location = New System.Drawing.Point(58, 119)
		Me.lblShipCodeFr.TabIndex = 5
		Me.lblShipCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblShipCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblShipCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblShipCodeFr.Enabled = True
		Me.lblShipCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblShipCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblShipCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblShipCodeFr.UseMnemonic = True
		Me.lblShipCodeFr.Visible = True
		Me.lblShipCodeFr.AutoSize = False
		Me.lblShipCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblShipCodeFr.Name = "lblShipCodeFr"
		Me.Controls.Add(_optCard_1)
		Me.Controls.Add(_optCard_0)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboShipCodeTo)
		Me.Controls.Add(cboShipCodeFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblShipCodeTo)
		Me.Controls.Add(lblShipCodeFr)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optCard.SetIndex(_optCard_1, CType(1, Short))
		Me.optCard.SetIndex(_optCard_0, CType(0, Short))
		CType(Me.optCard, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class