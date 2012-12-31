<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGLP003
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
	Public WithEvents _cmdFilePath_0 As System.Windows.Forms.Button
	Public WithEvents _txtFilePath_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblFilePath_0 As System.Windows.Forms.Label
	Public WithEvents _fmeFilePath_0 As System.Windows.Forms.GroupBox
	Public WithEvents picStatus As System.Windows.Forms.PictureBox
	Public WithEvents chkPrint As System.Windows.Forms.CheckBox
	Public WithEvents _txtFilePath_1 As System.Windows.Forms.TextBox
	Public WithEvents _cmdFilePath_1 As System.Windows.Forms.Button
	Public WithEvents _lblFilePath_1 As System.Windows.Forms.Label
	Public WithEvents _fmeFilePath_1 As System.Windows.Forms.GroupBox
	Public cdFilePathOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents medPrdFr As System.Windows.Forms.MaskedTextBox
	Public WithEvents lblPrdFr As System.Windows.Forms.Label
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Public WithEvents cmdFilePath As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents fmeFilePath As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents lblFilePath As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtFilePath As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGLP003))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._fmeFilePath_0 = New System.Windows.Forms.GroupBox
		Me._cmdFilePath_0 = New System.Windows.Forms.Button
		Me._txtFilePath_0 = New System.Windows.Forms.TextBox
		Me._lblFilePath_0 = New System.Windows.Forms.Label
		Me.picStatus = New System.Windows.Forms.PictureBox
		Me._fmeFilePath_1 = New System.Windows.Forms.GroupBox
		Me.chkPrint = New System.Windows.Forms.CheckBox
		Me._txtFilePath_1 = New System.Windows.Forms.TextBox
		Me._cmdFilePath_1 = New System.Windows.Forms.Button
		Me._lblFilePath_1 = New System.Windows.Forms.Label
		Me.cdFilePathOpen = New System.Windows.Forms.OpenFileDialog
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.medPrdFr = New System.Windows.Forms.MaskedTextBox
		Me.lblPrdFr = New System.Windows.Forms.Label
		Me.lblStatus = New System.Windows.Forms.Label
		Me.cmdFilePath = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.fmeFilePath = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.lblFilePath = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtFilePath = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me._fmeFilePath_0.SuspendLayout()
		Me._fmeFilePath_1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.cmdFilePath, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fmeFilePath, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFilePath, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFilePath, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Upload Stock Balance "
		Me.ClientSize = New System.Drawing.Size(618, 312)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.Icon = CType(resources.GetObject("frmGLP003.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmGLP003"
		Me._fmeFilePath_0.Text = "Input Path"
		Me._fmeFilePath_0.Size = New System.Drawing.Size(582, 73)
		Me._fmeFilePath_0.Location = New System.Drawing.Point(16, 56)
		Me._fmeFilePath_0.TabIndex = 11
		Me._fmeFilePath_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fmeFilePath_0.BackColor = System.Drawing.SystemColors.Control
		Me._fmeFilePath_0.Enabled = True
		Me._fmeFilePath_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fmeFilePath_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fmeFilePath_0.Visible = True
		Me._fmeFilePath_0.Padding = New System.Windows.Forms.Padding(0)
		Me._fmeFilePath_0.Name = "_fmeFilePath_0"
		Me._cmdFilePath_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdFilePath_0.Text = "..."
		Me._cmdFilePath_0.Size = New System.Drawing.Size(20, 20)
		Me._cmdFilePath_0.Location = New System.Drawing.Point(544, 35)
		Me._cmdFilePath_0.TabIndex = 2
		Me._cmdFilePath_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdFilePath_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdFilePath_0.CausesValidation = True
		Me._cmdFilePath_0.Enabled = True
		Me._cmdFilePath_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdFilePath_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdFilePath_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdFilePath_0.TabStop = True
		Me._cmdFilePath_0.Name = "_cmdFilePath_0"
		Me._txtFilePath_0.AutoSize = False
		Me._txtFilePath_0.Size = New System.Drawing.Size(381, 20)
		Me._txtFilePath_0.Location = New System.Drawing.Point(160, 32)
		Me._txtFilePath_0.TabIndex = 1
		Me._txtFilePath_0.Text = "ABCDEFGHIJKLMNOPQRS-"
		Me._txtFilePath_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtFilePath_0.AcceptsReturn = True
		Me._txtFilePath_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFilePath_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtFilePath_0.CausesValidation = True
		Me._txtFilePath_0.Enabled = True
		Me._txtFilePath_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFilePath_0.HideSelection = True
		Me._txtFilePath_0.ReadOnly = False
		Me._txtFilePath_0.Maxlength = 0
		Me._txtFilePath_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFilePath_0.MultiLine = False
		Me._txtFilePath_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFilePath_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFilePath_0.TabStop = True
		Me._txtFilePath_0.Visible = True
		Me._txtFilePath_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFilePath_0.Name = "_txtFilePath_0"
		Me._lblFilePath_0.Text = "Input Sheet Path:"
		Me._lblFilePath_0.Size = New System.Drawing.Size(145, 19)
		Me._lblFilePath_0.Location = New System.Drawing.Point(16, 32)
		Me._lblFilePath_0.TabIndex = 12
		Me._lblFilePath_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblFilePath_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFilePath_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblFilePath_0.Enabled = True
		Me._lblFilePath_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFilePath_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFilePath_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFilePath_0.UseMnemonic = True
		Me._lblFilePath_0.Visible = True
		Me._lblFilePath_0.AutoSize = False
		Me._lblFilePath_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFilePath_0.Name = "_lblFilePath_0"
		Me.picStatus.BackColor = System.Drawing.Color.White
		Me.picStatus.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatus.Size = New System.Drawing.Size(571, 28)
		Me.picStatus.Location = New System.Drawing.Point(24, 272)
		Me.picStatus.TabIndex = 9
		Me.picStatus.TabStop = False
		Me.picStatus.Dock = System.Windows.Forms.DockStyle.None
		Me.picStatus.CausesValidation = True
		Me.picStatus.Enabled = True
		Me.picStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.picStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picStatus.Visible = True
		Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picStatus.Name = "picStatus"
		Me._fmeFilePath_1.Text = "Output Path"
		Me._fmeFilePath_1.Size = New System.Drawing.Size(577, 100)
		Me._fmeFilePath_1.Location = New System.Drawing.Point(18, 142)
		Me._fmeFilePath_1.TabIndex = 7
		Me._fmeFilePath_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fmeFilePath_1.BackColor = System.Drawing.SystemColors.Control
		Me._fmeFilePath_1.Enabled = True
		Me._fmeFilePath_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._fmeFilePath_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fmeFilePath_1.Visible = True
		Me._fmeFilePath_1.Padding = New System.Windows.Forms.Padding(0)
		Me._fmeFilePath_1.Name = "_fmeFilePath_1"
		Me.chkPrint.Text = "New Page with Each Customer:"
		Me.chkPrint.Size = New System.Drawing.Size(185, 12)
		Me.chkPrint.Location = New System.Drawing.Point(160, 24)
		Me.chkPrint.TabIndex = 3
		Me.chkPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkPrint.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkPrint.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkPrint.BackColor = System.Drawing.SystemColors.Control
		Me.chkPrint.CausesValidation = True
		Me.chkPrint.Enabled = True
		Me.chkPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkPrint.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkPrint.TabStop = True
		Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkPrint.Visible = True
		Me.chkPrint.Name = "chkPrint"
		Me._txtFilePath_1.AutoSize = False
		Me._txtFilePath_1.Size = New System.Drawing.Size(380, 20)
		Me._txtFilePath_1.Location = New System.Drawing.Point(160, 40)
		Me._txtFilePath_1.TabIndex = 4
		Me._txtFilePath_1.Text = "ABCDEFGHIJKLMNOPQRS-"
		Me._txtFilePath_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtFilePath_1.AcceptsReturn = True
		Me._txtFilePath_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtFilePath_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtFilePath_1.CausesValidation = True
		Me._txtFilePath_1.Enabled = True
		Me._txtFilePath_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtFilePath_1.HideSelection = True
		Me._txtFilePath_1.ReadOnly = False
		Me._txtFilePath_1.Maxlength = 0
		Me._txtFilePath_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtFilePath_1.MultiLine = False
		Me._txtFilePath_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtFilePath_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtFilePath_1.TabStop = True
		Me._txtFilePath_1.Visible = True
		Me._txtFilePath_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtFilePath_1.Name = "_txtFilePath_1"
		Me._cmdFilePath_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdFilePath_1.Text = "..."
		Me._cmdFilePath_1.Size = New System.Drawing.Size(20, 20)
		Me._cmdFilePath_1.Location = New System.Drawing.Point(544, 40)
		Me._cmdFilePath_1.TabIndex = 5
		Me._cmdFilePath_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdFilePath_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdFilePath_1.CausesValidation = True
		Me._cmdFilePath_1.Enabled = True
		Me._cmdFilePath_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdFilePath_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdFilePath_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdFilePath_1.TabStop = True
		Me._cmdFilePath_1.Name = "_cmdFilePath_1"
		Me._lblFilePath_1.Text = "Export Sheet Path:"
		Me._lblFilePath_1.Size = New System.Drawing.Size(146, 19)
		Me._lblFilePath_1.Location = New System.Drawing.Point(11, 40)
		Me._lblFilePath_1.TabIndex = 8
		Me._lblFilePath_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblFilePath_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFilePath_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblFilePath_1.Enabled = True
		Me._lblFilePath_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFilePath_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFilePath_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFilePath_1.UseMnemonic = True
		Me._lblFilePath_1.Visible = True
		Me._lblFilePath_1.AutoSize = False
		Me._lblFilePath_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFilePath_1.Name = "_lblFilePath_1"
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
		Me.tbrProcess.Size = New System.Drawing.Size(618, 24)
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
		Me.medPrdFr.AllowPromptAsInput = False
		Me.medPrdFr.Size = New System.Drawing.Size(73, 19)
		Me.medPrdFr.Location = New System.Drawing.Point(176, 32)
		Me.medPrdFr.TabIndex = 0
		Me.medPrdFr.MaxLength = 7
		Me.medPrdFr.Mask = "####/##"
		Me.medPrdFr.PromptChar = "_"
		Me.medPrdFr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medPrdFr.Name = "medPrdFr"
		Me.lblPrdFr.Text = "Period From"
		Me.lblPrdFr.Size = New System.Drawing.Size(134, 14)
		Me.lblPrdFr.Location = New System.Drawing.Point(24, 32)
		Me.lblPrdFr.TabIndex = 13
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
		Me.lblStatus.Text = "Progress:"
		Me.lblStatus.Size = New System.Drawing.Size(559, 17)
		Me.lblStatus.Location = New System.Drawing.Point(31, 252)
		Me.lblStatus.TabIndex = 6
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
		Me.lblStatus.Enabled = True
		Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStatus.UseMnemonic = True
		Me.lblStatus.Visible = True
		Me.lblStatus.AutoSize = False
		Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStatus.Name = "lblStatus"
		Me.Controls.Add(_fmeFilePath_0)
		Me.Controls.Add(picStatus)
		Me.Controls.Add(_fmeFilePath_1)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(medPrdFr)
		Me.Controls.Add(lblPrdFr)
		Me.Controls.Add(lblStatus)
		Me._fmeFilePath_0.Controls.Add(_cmdFilePath_0)
		Me._fmeFilePath_0.Controls.Add(_txtFilePath_0)
		Me._fmeFilePath_0.Controls.Add(_lblFilePath_0)
		Me._fmeFilePath_1.Controls.Add(chkPrint)
		Me._fmeFilePath_1.Controls.Add(_txtFilePath_1)
		Me._fmeFilePath_1.Controls.Add(_cmdFilePath_1)
		Me._fmeFilePath_1.Controls.Add(_lblFilePath_1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.cmdFilePath.SetIndex(_cmdFilePath_0, CType(0, Short))
		Me.cmdFilePath.SetIndex(_cmdFilePath_1, CType(1, Short))
		Me.fmeFilePath.SetIndex(_fmeFilePath_0, CType(0, Short))
		Me.fmeFilePath.SetIndex(_fmeFilePath_1, CType(1, Short))
		Me.lblFilePath.SetIndex(_lblFilePath_0, CType(0, Short))
		Me.lblFilePath.SetIndex(_lblFilePath_1, CType(1, Short))
		Me.txtFilePath.SetIndex(_txtFilePath_0, CType(0, Short))
		Me.txtFilePath.SetIndex(_txtFilePath_1, CType(1, Short))
		CType(Me.txtFilePath, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFilePath, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fmeFilePath, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdFilePath, System.ComponentModel.ISupportInitialize).EndInit()
		Me._fmeFilePath_0.ResumeLayout(False)
		Me._fmeFilePath_1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class