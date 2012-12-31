<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmC002
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
	Public WithEvents chkBadList As System.Windows.Forms.CheckBox
	Public WithEvents cboCusNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboCusNoTo As System.Windows.Forms.ComboBox
	Public WithEvents cboSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblActive As System.Windows.Forms.Label
	Public WithEvents lblBadList As System.Windows.Forms.Label
	Public WithEvents lblCusNoFr As System.Windows.Forms.Label
	Public WithEvents lblCusNoTo As System.Windows.Forms.Label
	Public WithEvents lblSaleCode As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmC002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.chkActive = New System.Windows.Forms.CheckBox
		Me.chkBadList = New System.Windows.Forms.CheckBox
		Me.cboCusNoFr = New System.Windows.Forms.ComboBox
		Me.cboCusNoTo = New System.Windows.Forms.ComboBox
		Me.cboSaleCode = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblActive = New System.Windows.Forms.Label
		Me.lblBadList = New System.Windows.Forms.Label
		Me.lblCusNoFr = New System.Windows.Forms.Label
		Me.lblCusNoTo = New System.Windows.Forms.Label
		Me.lblSaleCode = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "C002"
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
		Me.Name = "frmC002"
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
		Me.chkActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkActive.Size = New System.Drawing.Size(25, 12)
		Me.chkActive.Location = New System.Drawing.Point(176, 153)
		Me.chkActive.TabIndex = 5
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
		Me.chkBadList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkBadList.Size = New System.Drawing.Size(25, 12)
		Me.chkBadList.Location = New System.Drawing.Point(176, 131)
		Me.chkBadList.TabIndex = 4
		Me.chkBadList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkBadList.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkBadList.BackColor = System.Drawing.SystemColors.Control
		Me.chkBadList.Text = ""
		Me.chkBadList.CausesValidation = True
		Me.chkBadList.Enabled = True
		Me.chkBadList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkBadList.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkBadList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkBadList.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkBadList.TabStop = True
		Me.chkBadList.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkBadList.Visible = True
		Me.chkBadList.Name = "chkBadList"
		Me.cboCusNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoFr.Location = New System.Drawing.Point(186, 74)
		Me.cboCusNoFr.TabIndex = 1
		Me.cboCusNoFr.Text = "Combo1"
		Me.cboCusNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusNoFr.CausesValidation = True
		Me.cboCusNoFr.Enabled = True
		Me.cboCusNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusNoFr.IntegralHeight = True
		Me.cboCusNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusNoFr.Sorted = False
		Me.cboCusNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusNoFr.TabStop = True
		Me.cboCusNoFr.Visible = True
		Me.cboCusNoFr.Name = "cboCusNoFr"
		Me.cboCusNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboCusNoTo.Location = New System.Drawing.Point(372, 74)
		Me.cboCusNoTo.TabIndex = 2
		Me.cboCusNoTo.Text = "Combo1"
		Me.cboCusNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusNoTo.CausesValidation = True
		Me.cboCusNoTo.Enabled = True
		Me.cboCusNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusNoTo.IntegralHeight = True
		Me.cboCusNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusNoTo.Sorted = False
		Me.cboCusNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusNoTo.TabStop = True
		Me.cboCusNoTo.Visible = True
		Me.cboCusNoTo.Name = "cboCusNoTo"
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
		Me.lblTitle.TabIndex = 13
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
		Me.lblActive.Location = New System.Drawing.Point(58, 153)
		Me.lblActive.TabIndex = 12
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
		Me.lblBadList.Text = "BADLIST"
		Me.lblBadList.Size = New System.Drawing.Size(118, 15)
		Me.lblBadList.Location = New System.Drawing.Point(58, 131)
		Me.lblBadList.TabIndex = 11
		Me.lblBadList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBadList.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBadList.BackColor = System.Drawing.SystemColors.Control
		Me.lblBadList.Enabled = True
		Me.lblBadList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBadList.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBadList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBadList.UseMnemonic = True
		Me.lblBadList.Visible = True
		Me.lblBadList.AutoSize = False
		Me.lblBadList.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBadList.Name = "lblBadList"
		Me.lblCusNoFr.Text = "CUSNOFR"
		Me.lblCusNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblCusNoFr.Location = New System.Drawing.Point(58, 77)
		Me.lblCusNoFr.TabIndex = 9
		Me.lblCusNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNoFr.Enabled = True
		Me.lblCusNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNoFr.UseMnemonic = True
		Me.lblCusNoFr.Visible = True
		Me.lblCusNoFr.AutoSize = False
		Me.lblCusNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNoFr.Name = "lblCusNoFr"
		Me.lblCusNoTo.Text = "CUSNOTO"
		Me.lblCusNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblCusNoTo.Location = New System.Drawing.Point(348, 77)
		Me.lblCusNoTo.TabIndex = 8
		Me.lblCusNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNoTo.Enabled = True
		Me.lblCusNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNoTo.UseMnemonic = True
		Me.lblCusNoTo.Visible = True
		Me.lblCusNoTo.AutoSize = False
		Me.lblCusNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNoTo.Name = "lblCusNoTo"
		Me.lblSaleCode.Text = "SALECODE"
		Me.lblSaleCode.Size = New System.Drawing.Size(126, 15)
		Me.lblSaleCode.Location = New System.Drawing.Point(58, 103)
		Me.lblSaleCode.TabIndex = 6
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
		Me.Controls.Add(chkBadList)
		Me.Controls.Add(cboCusNoFr)
		Me.Controls.Add(cboCusNoTo)
		Me.Controls.Add(cboSaleCode)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblActive)
		Me.Controls.Add(lblBadList)
		Me.Controls.Add(lblCusNoFr)
		Me.Controls.Add(lblCusNoTo)
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