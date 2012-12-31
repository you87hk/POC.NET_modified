<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVOU002
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
	Public WithEvents _optPrtMrk_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optPrtMrk_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cboDocNoFr As System.Windows.Forms.ComboBox
	Public WithEvents cboDocNoTo As System.Windows.Forms.ComboBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblPrtMrk As System.Windows.Forms.Label
	Public WithEvents lblDocNoFr As System.Windows.Forms.Label
	Public WithEvents lblDocNoTo As System.Windows.Forms.Label
	Public WithEvents optPrtMrk As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVOU002))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optPrtMrk_0 = New System.Windows.Forms.RadioButton
		Me._optPrtMrk_1 = New System.Windows.Forms.RadioButton
		Me.cboDocNoFr = New System.Windows.Forms.ComboBox
		Me.cboDocNoTo = New System.Windows.Forms.ComboBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblPrtMrk = New System.Windows.Forms.Label
		Me.lblDocNoFr = New System.Windows.Forms.Label
		Me.lblDocNoTo = New System.Windows.Forms.Label
		Me.optPrtMrk = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optPrtMrk, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Material Master List"
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
		Me.Name = "frmVOU002"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(303, 98)
		Me.tblCommon.Location = New System.Drawing.Point(120, 192)
		Me.tblCommon.TabIndex = 4
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.Frame1.Size = New System.Drawing.Size(297, 33)
		Me.Frame1.Location = New System.Drawing.Point(184, 104)
		Me.Frame1.TabIndex = 8
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optPrtMrk_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrtMrk_0.Text = "UnPrint"
		Me._optPrtMrk_0.Size = New System.Drawing.Size(67, 19)
		Me._optPrtMrk_0.Location = New System.Drawing.Point(8, 10)
		Me._optPrtMrk_0.TabIndex = 2
		Me._optPrtMrk_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optPrtMrk_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrtMrk_0.BackColor = System.Drawing.SystemColors.Control
		Me._optPrtMrk_0.CausesValidation = True
		Me._optPrtMrk_0.Enabled = True
		Me._optPrtMrk_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optPrtMrk_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optPrtMrk_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optPrtMrk_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optPrtMrk_0.TabStop = True
		Me._optPrtMrk_0.Checked = False
		Me._optPrtMrk_0.Visible = True
		Me._optPrtMrk_0.Name = "_optPrtMrk_0"
		Me._optPrtMrk_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrtMrk_1.Text = "Printed"
		Me._optPrtMrk_1.Size = New System.Drawing.Size(102, 19)
		Me._optPrtMrk_1.Location = New System.Drawing.Point(168, 10)
		Me._optPrtMrk_1.TabIndex = 3
		Me._optPrtMrk_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optPrtMrk_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optPrtMrk_1.BackColor = System.Drawing.SystemColors.Control
		Me._optPrtMrk_1.CausesValidation = True
		Me._optPrtMrk_1.Enabled = True
		Me._optPrtMrk_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optPrtMrk_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optPrtMrk_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optPrtMrk_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optPrtMrk_1.TabStop = True
		Me._optPrtMrk_1.Checked = False
		Me._optPrtMrk_1.Visible = True
		Me._optPrtMrk_1.Name = "_optPrtMrk_1"
		Me.cboDocNoFr.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoFr.Location = New System.Drawing.Point(186, 74)
		Me.cboDocNoFr.TabIndex = 0
		Me.cboDocNoFr.Text = "Combo1"
		Me.cboDocNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNoFr.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNoFr.CausesValidation = True
		Me.cboDocNoFr.Enabled = True
		Me.cboDocNoFr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNoFr.IntegralHeight = True
		Me.cboDocNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNoFr.Sorted = False
		Me.cboDocNoFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNoFr.TabStop = True
		Me.cboDocNoFr.Visible = True
		Me.cboDocNoFr.Name = "cboDocNoFr"
		Me.cboDocNoTo.Size = New System.Drawing.Size(121, 20)
		Me.cboDocNoTo.Location = New System.Drawing.Point(372, 74)
		Me.cboDocNoTo.TabIndex = 1
		Me.cboDocNoTo.Text = "Combo1"
		Me.cboDocNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDocNoTo.BackColor = System.Drawing.SystemColors.Window
		Me.cboDocNoTo.CausesValidation = True
		Me.cboDocNoTo.Enabled = True
		Me.cboDocNoTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDocNoTo.IntegralHeight = True
		Me.cboDocNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDocNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDocNoTo.Sorted = False
		Me.cboDocNoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboDocNoTo.TabStop = True
		Me.cboDocNoTo.Visible = True
		Me.cboDocNoTo.Name = "cboDocNoTo"
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
		Me.tbrProcess.TabIndex = 7
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
		Me.lblPrtMrk.Text = "Print Range"
		Me.lblPrtMrk.Size = New System.Drawing.Size(120, 17)
		Me.lblPrtMrk.Location = New System.Drawing.Point(56, 112)
		Me.lblPrtMrk.TabIndex = 9
		Me.lblPrtMrk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrtMrk.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrtMrk.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrtMrk.Enabled = True
		Me.lblPrtMrk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrtMrk.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrtMrk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrtMrk.UseMnemonic = True
		Me.lblPrtMrk.Visible = True
		Me.lblPrtMrk.AutoSize = False
		Me.lblPrtMrk.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrtMrk.Name = "lblPrtMrk"
		Me.lblDocNoFr.Text = "Document # From"
		Me.lblDocNoFr.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNoFr.Location = New System.Drawing.Point(58, 75)
		Me.lblDocNoFr.TabIndex = 6
		Me.lblDocNoFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNoFr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNoFr.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNoFr.Enabled = True
		Me.lblDocNoFr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNoFr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNoFr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNoFr.UseMnemonic = True
		Me.lblDocNoFr.Visible = True
		Me.lblDocNoFr.AutoSize = False
		Me.lblDocNoFr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNoFr.Name = "lblDocNoFr"
		Me.lblDocNoTo.Text = "To"
		Me.lblDocNoTo.Size = New System.Drawing.Size(25, 15)
		Me.lblDocNoTo.Location = New System.Drawing.Point(348, 75)
		Me.lblDocNoTo.TabIndex = 5
		Me.lblDocNoTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNoTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNoTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNoTo.Enabled = True
		Me.lblDocNoTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNoTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNoTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNoTo.UseMnemonic = True
		Me.lblDocNoTo.Visible = True
		Me.lblDocNoTo.AutoSize = False
		Me.lblDocNoTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNoTo.Name = "lblDocNoTo"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cboDocNoFr)
		Me.Controls.Add(cboDocNoTo)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblPrtMrk)
		Me.Controls.Add(lblDocNoFr)
		Me.Controls.Add(lblDocNoTo)
		Me.Frame1.Controls.Add(_optPrtMrk_0)
		Me.Frame1.Controls.Add(_optPrtMrk_1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.optPrtMrk.SetIndex(_optPrtMrk_0, CType(0, Short))
		Me.optPrtMrk.SetIndex(_optPrtMrk_1, CType(1, Short))
		CType(Me.optPrtMrk, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class