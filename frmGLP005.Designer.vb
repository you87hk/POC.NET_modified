<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGLP005
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
	Public WithEvents txtTitle As System.Windows.Forms.TextBox
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboAccNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboAccNoTo As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblAccNoFr As System.Windows.Forms.Label
	Public WithEvents lblAccNoTo As System.Windows.Forms.Label
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGLP005))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboAccNoFr = New System.Windows.Forms.ComboBox
		Me.cboAccNoTo = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblAccNoFr = New System.Windows.Forms.Label
		Me.lblAccNoTo = New System.Windows.Forms.Label
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Material Master List"
		Me.ClientSize = New System.Drawing.Size(613, 229)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.Icon = CType(resources.GetObject("frmGLP005.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
		Me.Name = "frmGLP005"
		Me.txtTitle.AutoSize = False
		Me.txtTitle.Size = New System.Drawing.Size(311, 20)
		Me.txtTitle.Location = New System.Drawing.Point(192, 48)
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
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(128, 216)
		Me.tblCommon.TabIndex = 5
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboAccNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboAccNoFr.Location = New System.Drawing.Point(192, 74)
		Me.cboAccNoFr.TabIndex = 1
		Me.cboAccNoFr.Text = "Combo1"
		Me.cboAccNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccNoFr.CausesValidation = True
		Me.cboAccNoFr.Enabled = True
		Me.cboAccNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccNoFr.IntegralHeight = True
		Me.cboAccNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccNoFr.Sorted = False
		Me.cboAccNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccNoFr.TabStop = True
		Me.cboAccNoFr.Visible = True
		Me.cboAccNoFr.Name = "cboAccNoFr"
		Me.cboAccNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboAccNoTo.Location = New System.Drawing.Point(380, 74)
		Me.cboAccNoTo.TabIndex = 2
		Me.cboAccNoTo.Text = "Combo1"
		Me.cboAccNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAccNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboAccNoTo.CausesValidation = True
		Me.cboAccNoTo.Enabled = True
		Me.cboAccNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAccNoTo.IntegralHeight = True
		Me.cboAccNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAccNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAccNoTo.Sorted = False
		Me.cboAccNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAccNoTo.TabStop = True
		Me.cboAccNoTo.Visible = True
		Me.cboAccNoTo.Name = "cboAccNoTo"
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
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(192, 104)
		Me.medPrdFr.TabIndex = 3
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.lblTitle.Text = "SHIPPER"
		Me.lblTitle.Size = New System.Drawing.Size(124, 16)
		Me.lblTitle.Location = New System.Drawing.Point(64, 52)
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
		Me.lblAccNoFr.Text = "Document # From"
		Me.lblAccNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblAccNoFr.Location = New System.Drawing.Point(66, 78)
		Me.lblAccNoFr.TabIndex = 7
		Me.lblAccNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccNoFr.Enabled = True
		Me.lblAccNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccNoFr.UseMnemonic = True
		Me.lblAccNoFr.Visible = True
		Me.lblAccNoFr.AutoSize = False
		Me.lblAccNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccNoFr.Name = "lblAccNoFr"
		Me.lblAccNoTo.Text = "To"
		Me.lblAccNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblAccNoTo.Location = New System.Drawing.Point(356, 78)
		Me.lblAccNoTo.TabIndex = 6
		Me.lblAccNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAccNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAccNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblAccNoTo.Enabled = True
		Me.lblAccNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAccNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAccNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAccNoTo.UseMnemonic = True
		Me.lblAccNoTo.Visible = True
		Me.lblAccNoTo.AutoSize = False
		Me.lblAccNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAccNoTo.Name = "lblAccNoTo"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(126, 15)
		Me.lblPrdFr.Location = New System.Drawing.Point(66, 107)
		Me.lblPrdFr.TabIndex = 4
		Me.lblPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrdFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrdFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrdFr.Enabled = True
		Me.lblPrdFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrdFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrdFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrdFr.UseMnemonic = True
		Me.lblPrdFr.Visible = True
		Me.lblPrdFr.AutoSize = False
		Me.lblPrdFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrdFr.Name = "lblPrdFr"
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboAccNoFr)
		Me.Controls.Add(cboAccNoTo)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblAccNoFr)
		Me.Controls.Add(lblAccNoTo)
		Me.Controls.Add(lblPrdFr)
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