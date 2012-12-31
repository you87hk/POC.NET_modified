<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUOM002
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
	Public WithEvents cboUOMCodeTo As System.Windows.Forms.ComboBox
	Public WithEvents cboUOMCodeFr As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblUOMCodeTo As System.Windows.Forms.Label
	Public WithEvents lblUOMCodeFr As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUOM002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtTitle = New System.Windows.Forms.TextBox
		Me.cboUOMCodeTo = New System.Windows.Forms.ComboBox
		Me.cboUOMCodeFr = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblTitle = New System.Windows.Forms.Label
		Me.lblUOMCodeTo = New System.Windows.Forms.Label
		Me.lblUOMCodeFr = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "UOM002"
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
		Me.Name = "frmUOM002"
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
		Me.cboUOMCodeTo.Size = New System.Drawing.Size(121, 20)
		Me.cboUOMCodeTo.Location = New System.Drawing.Point(372, 85)
		Me.cboUOMCodeTo.TabIndex = 2
		Me.cboUOMCodeTo.Text = "Combo1"
		Me.cboUOMCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUOMCodeTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboUOMCodeTo.CausesValidation = True
		Me.cboUOMCodeTo.Enabled = True
		Me.cboUOMCodeTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUOMCodeTo.IntegralHeight = True
		Me.cboUOMCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUOMCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUOMCodeTo.Sorted = False
		Me.cboUOMCodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUOMCodeTo.TabStop = True
		Me.cboUOMCodeTo.Visible = True
		Me.cboUOMCodeTo.Name = "cboUOMCodeTo"
		Me.cboUOMCodeFr.Size = New System.Drawing.Size(121, 20)
		Me.cboUOMCodeFr.Location = New System.Drawing.Point(186, 85)
		Me.cboUOMCodeFr.TabIndex = 1
		Me.cboUOMCodeFr.Text = "Combo1"
		Me.cboUOMCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUOMCodeFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboUOMCodeFr.CausesValidation = True
		Me.cboUOMCodeFr.Enabled = True
		Me.cboUOMCodeFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboUOMCodeFr.IntegralHeight = True
		Me.cboUOMCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboUOMCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboUOMCodeFr.Sorted = False
		Me.cboUOMCodeFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboUOMCodeFr.TabStop = True
		Me.cboUOMCodeFr.Visible = True
		Me.cboUOMCodeFr.Name = "cboUOMCodeFr"
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
		Me.tbrProcess.TabIndex = 6
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
		Me.lblTitle.TabIndex = 7
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
		Me.lblUOMCodeTo.Text = "UOMCODETO"
		Me.lblUOMCodeTo.Size = New System.Drawing.Size(25, 15)
		Me.lblUOMCodeTo.Location = New System.Drawing.Point(348, 87)
		Me.lblUOMCodeTo.TabIndex = 4
		Me.lblUOMCodeTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUOMCodeTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUOMCodeTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblUOMCodeTo.Enabled = True
		Me.lblUOMCodeTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUOMCodeTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUOMCodeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUOMCodeTo.UseMnemonic = True
		Me.lblUOMCodeTo.Visible = True
		Me.lblUOMCodeTo.AutoSize = False
		Me.lblUOMCodeTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUOMCodeTo.Name = "lblUOMCodeTo"
		Me.lblUOMCodeFr.Text = "UOMCODEFR"
		Me.lblUOMCodeFr.Size = New System.Drawing.Size(126, 15)
		Me.lblUOMCodeFr.Location = New System.Drawing.Point(58, 87)
		Me.lblUOMCodeFr.TabIndex = 3
		Me.lblUOMCodeFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUOMCodeFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUOMCodeFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblUOMCodeFr.Enabled = True
		Me.lblUOMCodeFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUOMCodeFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUOMCodeFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUOMCodeFr.UseMnemonic = True
		Me.lblUOMCodeFr.Visible = True
		Me.lblUOMCodeFr.AutoSize = False
		Me.lblUOMCodeFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUOMCodeFr.Name = "lblUOMCodeFr"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtTitle)
		Me.Controls.Add(cboUOMCodeTo)
		Me.Controls.Add(cboUOMCodeFr)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblUOMCodeTo)
		Me.Controls.Add(lblUOMCodeFr)
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