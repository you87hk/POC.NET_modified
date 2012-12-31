<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmV002
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
	Public WithEvents chkActive As System.Windows.Forms.CheckBox
	Public WithEvents cboVdrNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboVdrNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblActive As System.Windows.Forms.Label
	Public WithEvents lblVdrNoFr As System.Windows.Forms.Label
	Public WithEvents lblVdrNoTo As System.Windows.Forms.Label
	Public WithEvents lblSaleCode As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmV002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.chkActive = New System.Windows.Forms.CheckBox
		Me.cboVdrNoFr = New System.Windows.Forms.ComboBox
		Me.cboVdrNoTo = New System.Windows.Forms.ComboBox
		Me.cboSaleCode = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblActive = New System.Windows.Forms.Label
		Me.lblVdrNoFr = New System.Windows.Forms.Label
		Me.lblVdrNoTo = New System.Windows.Forms.Label
		Me.lblSaleCode = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "V002"
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
		Me.Name = "frmV002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 6
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
		Me.chkActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkActive.Size = New System.Drawing.Size(25, 12)
		Me.chkActive.Location = New System.Drawing.Point(176, 131)
		Me.chkActive.TabIndex = 4
		Me.chkActive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkActive.BackColor = System.Drawing.SystemColors.Control
		Me.chkActive.Text = ""
		Me.chkActive.CausesValidation = True
		Me.chkActive.Enabled = True
		Me.chkActive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkActive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkActive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkActive.TabStop = True
		Me.chkActive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkActive.Visible = True
		Me.chkActive.Name = "chkActive"
		Me.cboVdrNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoFr.Location = New System.Drawing.Point(186, 74)
		Me.cboVdrNoFr.TabIndex = 1
		Me.cboVdrNoFr.Text = "Combo1"
		Me.cboVdrNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoFr.CausesValidation = True
		Me.cboVdrNoFr.Enabled = True
		Me.cboVdrNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoFr.IntegralHeight = True
		Me.cboVdrNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoFr.Sorted = False
		Me.cboVdrNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoFr.TabStop = True
		Me.cboVdrNoFr.Visible = True
		Me.cboVdrNoFr.Name = "cboVdrNoFr"
		Me.cboVdrNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboVdrNoTo.Location = New System.Drawing.Point(372, 74)
		Me.cboVdrNoTo.TabIndex = 2
		Me.cboVdrNoTo.Text = "Combo1"
		Me.cboVdrNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboVdrNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboVdrNoTo.CausesValidation = True
		Me.cboVdrNoTo.Enabled = True
		Me.cboVdrNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboVdrNoTo.IntegralHeight = True
		Me.cboVdrNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboVdrNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboVdrNoTo.Sorted = False
		Me.cboVdrNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboVdrNoTo.TabStop = True
		Me.cboVdrNoTo.Visible = True
		Me.cboVdrNoTo.Name = "cboVdrNoTo"
		Me.cboSaleCode.Size = New System.Drawing.Size(121, 20)
		Me.cboSaleCode.Location = New System.Drawing.Point(186, 101)
		Me.cboSaleCode.TabIndex = 3
		Me.cboSaleCode.Text = "Combo1"
		Me.cboSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboSaleCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboSaleCode.CausesValidation = True
		Me.cboSaleCode.Enabled = True
		Me.cboSaleCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSaleCode.IntegralHeight = True
		Me.cboSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSaleCode.Sorted = False
		Me.cboSaleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboSaleCode.TabStop = True
		Me.cboSaleCode.Visible = True
		Me.cboSaleCode.Name = "cboSaleCode"
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
		Me.tbrProcess.TabIndex = 9
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
		Me.lblTitle.TabIndex = 11
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
		Me.lblActive.Text = "ACTIVE"
		Me.lblActive.Size = New System.Drawing.Size(118, 15)
		Me.lblActive.Location = New System.Drawing.Point(58, 131)
		Me.lblActive.TabIndex = 10
		Me.lblActive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblActive.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblActive.BackColor = System.Drawing.SystemColors.Control
		Me.lblActive.Enabled = True
		Me.lblActive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblActive.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblActive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblActive.UseMnemonic = True
		Me.lblActive.Visible = True
		Me.lblActive.AutoSize = False
		Me.lblActive.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblActive.Name = "lblActive"
		Me.lblVdrNoFr.Text = "VDRNOFR"
		Me.lblVdrNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblVdrNoFr.Location = New System.Drawing.Point(58, 77)
		Me.lblVdrNoFr.TabIndex = 8
		Me.lblVdrNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoFr.Enabled = True
		Me.lblVdrNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoFr.UseMnemonic = True
		Me.lblVdrNoFr.Visible = True
		Me.lblVdrNoFr.AutoSize = False
		Me.lblVdrNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoFr.Name = "lblVdrNoFr"
		Me.lblVdrNoTo.Text = "VDRNOTO"
		Me.lblVdrNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblVdrNoTo.Location = New System.Drawing.Point(348, 77)
		Me.lblVdrNoTo.TabIndex = 7
		Me.lblVdrNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVdrNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVdrNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblVdrNoTo.Enabled = True
		Me.lblVdrNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVdrNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVdrNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVdrNoTo.UseMnemonic = True
		Me.lblVdrNoTo.Visible = True
		Me.lblVdrNoTo.AutoSize = False
		Me.lblVdrNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVdrNoTo.Name = "lblVdrNoTo"
		Me.lblSaleCode.Text = "SALECODE"
		Me.lblSaleCode.Size = New System.Drawing.Size(126, 15)
		Me.lblSaleCode.Location = New System.Drawing.Point(58, 103)
		Me.lblSaleCode.TabIndex = 5
		Me.lblSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSaleCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSaleCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblSaleCode.Enabled = True
		Me.lblSaleCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSaleCode.UseMnemonic = True
		Me.lblSaleCode.Visible = True
		Me.lblSaleCode.AutoSize = False
		Me.lblSaleCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSaleCode.Name = "lblSaleCode"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(chkActive)
		Me.Controls.Add(cboVdrNoFr)
		Me.Controls.Add(cboVdrNoTo)
		Me.Controls.Add(cboSaleCode)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblActive)
		Me.Controls.Add(lblVdrNoFr)
		Me.Controls.Add(lblVdrNoTo)
		Me.Controls.Add(lblSaleCode)
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