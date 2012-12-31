<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUSR002
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
	Public WithEvents cboGrpCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents cboGrpCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents cboUsrCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboUsrCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblGrpCodeFr As System.Windows.Forms.Label
	Public WithEvents lblGrpCodeTo As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblUsrCodeTo As System.Windows.Forms.Label
	Public WithEvents lblUsrCodeFr As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUSR002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboGrpCodeFr = New System.Windows.Forms.ComboBox
		Me.cboGrpCodeTo = New System.Windows.Forms.ComboBox
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboUsrCodeTo = New System.Windows.Forms.ComboBox
		Me.cboUsrCodeFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblGrpCodeFr = New System.Windows.Forms.Label
		Me.lblGrpCodeTo = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblUsrCodeTo = New System.Windows.Forms.Label
		Me.lblUsrCodeFr = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "USR002"
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
		Me.Name = "frmUSR002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 7
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboGrpCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboGrpCodeFr.Location = New System.Drawing.Point(186, 112)
		Me.cboGrpCodeFr.TabIndex = 3
		Me.cboGrpCodeFr.Text = "Combo1"
		Me.cboGrpCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboGrpCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboGrpCodeFr.CausesValidation = True
		Me.cboGrpCodeFr.Enabled = True
		Me.cboGrpCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboGrpCodeFr.IntegralHeight = True
		Me.cboGrpCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboGrpCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboGrpCodeFr.Sorted = False
		Me.cboGrpCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboGrpCodeFr.TabStop = True
		Me.cboGrpCodeFr.Visible = True
		Me.cboGrpCodeFr.Name = "cboGrpCodeFr"
		Me.cboGrpCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboGrpCodeTo.Location = New System.Drawing.Point(372, 112)
		Me.cboGrpCodeTo.TabIndex = 4
		Me.cboGrpCodeTo.Text = "Combo1"
		Me.cboGrpCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboGrpCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboGrpCodeTo.CausesValidation = True
		Me.cboGrpCodeTo.Enabled = True
		Me.cboGrpCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboGrpCodeTo.IntegralHeight = True
		Me.cboGrpCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboGrpCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboGrpCodeTo.Sorted = False
		Me.cboGrpCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboGrpCodeTo.TabStop = True
		Me.cboGrpCodeTo.Visible = True
		Me.cboGrpCodeTo.Name = "cboGrpCodeTo"
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
		Me.cboUsrCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboUsrCodeTo.Location = New System.Drawing.Point(372, 85)
		Me.cboUsrCodeTo.TabIndex = 2
		Me.cboUsrCodeTo.Text = "Combo1"
		Me.cboUsrCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsrCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboUsrCodeTo.CausesValidation = True
		Me.cboUsrCodeTo.Enabled = True
		Me.cboUsrCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUsrCodeTo.IntegralHeight = True
		Me.cboUsrCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUsrCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUsrCodeTo.Sorted = False
		Me.cboUsrCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUsrCodeTo.TabStop = True
		Me.cboUsrCodeTo.Visible = True
		Me.cboUsrCodeTo.Name = "cboUsrCodeTo"
		Me.cboUsrCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboUsrCodeFr.Location = New System.Drawing.Point(186, 85)
		Me.cboUsrCodeFr.TabIndex = 1
		Me.cboUsrCodeFr.Text = "Combo1"
		Me.cboUsrCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsrCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboUsrCodeFr.CausesValidation = True
		Me.cboUsrCodeFr.Enabled = True
		Me.cboUsrCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUsrCodeFr.IntegralHeight = True
		Me.cboUsrCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUsrCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUsrCodeFr.Sorted = False
		Me.cboUsrCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUsrCodeFr.TabStop = True
		Me.cboUsrCodeFr.Visible = True
		Me.cboUsrCodeFr.Name = "cboUsrCodeFr"
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
		Me.lblGrpCodeFr.Text = "GRPCODEFR"
		Me.lblGrpCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblGrpCodeFr.Location = New System.Drawing.Point(58, 114)
		Me.lblGrpCodeFr.TabIndex = 11
		Me.lblGrpCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrpCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblGrpCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblGrpCodeFr.Enabled = True
		Me.lblGrpCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGrpCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGrpCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGrpCodeFr.UseMnemonic = True
		Me.lblGrpCodeFr.Visible = True
		Me.lblGrpCodeFr.AutoSize = False
		Me.lblGrpCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGrpCodeFr.Name = "lblGrpCodeFr"
		Me.lblGrpCodeTo.Text = "GRPCODETO"
		Me.lblGrpCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblGrpCodeTo.Location = New System.Drawing.Point(348, 114)
		Me.lblGrpCodeTo.TabIndex = 10
		Me.lblGrpCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrpCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblGrpCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblGrpCodeTo.Enabled = True
		Me.lblGrpCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGrpCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGrpCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGrpCodeTo.UseMnemonic = True
		Me.lblGrpCodeTo.Visible = True
		Me.lblGrpCodeTo.AutoSize = False
		Me.lblGrpCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGrpCodeTo.Name = "lblGrpCodeTo"
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
		Me.lblUsrCodeTo.Text = "USRCODETO"
		Me.lblUsrCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblUsrCodeTo.Location = New System.Drawing.Point(348, 87)
		Me.lblUsrCodeTo.TabIndex = 6
		Me.lblUsrCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrCodeTo.Enabled = True
		Me.lblUsrCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrCodeTo.UseMnemonic = True
		Me.lblUsrCodeTo.Visible = True
		Me.lblUsrCodeTo.AutoSize = False
		Me.lblUsrCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrCodeTo.Name = "lblUsrCodeTo"
		Me.lblUsrCodeFr.Text = "USRCODEFR"
		Me.lblUsrCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblUsrCodeFr.Location = New System.Drawing.Point(58, 87)
		Me.lblUsrCodeFr.TabIndex = 5
		Me.lblUsrCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsrCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUsrCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblUsrCodeFr.Enabled = True
		Me.lblUsrCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUsrCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUsrCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUsrCodeFr.UseMnemonic = True
		Me.lblUsrCodeFr.Visible = True
		Me.lblUsrCodeFr.AutoSize = False
		Me.lblUsrCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUsrCodeFr.Name = "lblUsrCodeFr"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboGrpCodeFr)
		Me.Controls.Add(cboGrpCodeTo)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboUsrCodeTo)
		Me.Controls.Add(cboUsrCodeFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblGrpCodeFr)
		Me.Controls.Add(lblGrpCodeTo)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblUsrCodeTo)
		Me.Controls.Add(lblUsrCodeFr)
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