<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmARPE000
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
	Public WithEvents chkGL As System.Windows.Forms.CheckBox
	Public WithEvents chkAP As System.Windows.Forms.CheckBox
	Public WithEvents chkAR As System.Windows.Forms.CheckBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspAPCtlPrd As System.Windows.Forms.Label
	Public WithEvents lblDspGLCtlPrd As System.Windows.Forms.Label
	Public WithEvents lblDspARCtlPrd As System.Windows.Forms.Label
	Public WithEvents lblCtlPrd As System.Windows.Forms.Label
	Public WithEvents lblWarning As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmARPE000))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.chkGL = New System.Windows.Forms.CheckBox
		Me.chkAP = New System.Windows.Forms.CheckBox
		Me.chkAR = New System.Windows.Forms.CheckBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me.lblDspAPCtlPrd = New System.Windows.Forms.Label
		Me.lblDspGLCtlPrd = New System.Windows.Forms.Label
		Me.lblDspARCtlPrd = New System.Windows.Forms.Label
		Me.lblCtlPrd = New System.Windows.Forms.Label
		Me.lblWarning = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Period End Process"
		Me.ClientSize = New System.Drawing.Size(613, 319)
		Me.Location = New System.Drawing.Point(3, 18)
		Me.Icon = CType(resources.GetObject("frmARPE000.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmARPE000"
		Me.chkGL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkGL.Text = "General Ledger Transaction"
		Me.chkGL.Size = New System.Drawing.Size(129, 28)
		Me.chkGL.Location = New System.Drawing.Point(464, 208)
		Me.chkGL.TabIndex = 2
		Me.chkGL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkGL.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkGL.BackColor = System.Drawing.SystemColors.Control
		Me.chkGL.CausesValidation = True
		Me.chkGL.Enabled = True
		Me.chkGL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkGL.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkGL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkGL.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkGL.TabStop = True
		Me.chkGL.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkGL.Visible = True
		Me.chkGL.Name = "chkGL"
		Me.chkAP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkAP.Text = "Account Payable Transaction"
		Me.chkAP.Size = New System.Drawing.Size(129, 28)
		Me.chkAP.Location = New System.Drawing.Point(272, 208)
		Me.chkAP.TabIndex = 1
		Me.chkAP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAP.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAP.BackColor = System.Drawing.SystemColors.Control
		Me.chkAP.CausesValidation = True
		Me.chkAP.Enabled = True
		Me.chkAP.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAP.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAP.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAP.TabStop = True
		Me.chkAP.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAP.Visible = True
		Me.chkAP.Name = "chkAP"
		Me.chkAR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkAR.Text = "Account Receiable Transaction"
		Me.chkAR.Size = New System.Drawing.Size(129, 28)
		Me.chkAR.Location = New System.Drawing.Point(80, 208)
		Me.chkAR.TabIndex = 0
		Me.chkAR.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAR.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAR.BackColor = System.Drawing.SystemColors.Control
		Me.chkAR.CausesValidation = True
		Me.chkAR.Enabled = True
		Me.chkAR.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAR.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAR.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAR.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAR.TabStop = True
		Me.chkAR.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAR.Visible = True
		Me.chkAR.Name = "chkAR"
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
		Me.tbrProcess.TabIndex = 3
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
		Me.lblDspAPCtlPrd.Size = New System.Drawing.Size(65, 20)
		Me.lblDspAPCtlPrd.Location = New System.Drawing.Point(272, 184)
		Me.lblDspAPCtlPrd.TabIndex = 8
		Me.lblDspAPCtlPrd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAPCtlPrd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAPCtlPrd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAPCtlPrd.Enabled = True
		Me.lblDspAPCtlPrd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAPCtlPrd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAPCtlPrd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAPCtlPrd.UseMnemonic = True
		Me.lblDspAPCtlPrd.Visible = True
		Me.lblDspAPCtlPrd.AutoSize = False
		Me.lblDspAPCtlPrd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAPCtlPrd.Name = "lblDspAPCtlPrd"
		Me.lblDspGLCtlPrd.Size = New System.Drawing.Size(65, 20)
		Me.lblDspGLCtlPrd.Location = New System.Drawing.Point(472, 184)
		Me.lblDspGLCtlPrd.TabIndex = 7
		Me.lblDspGLCtlPrd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspGLCtlPrd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspGLCtlPrd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspGLCtlPrd.Enabled = True
		Me.lblDspGLCtlPrd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspGLCtlPrd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspGLCtlPrd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspGLCtlPrd.UseMnemonic = True
		Me.lblDspGLCtlPrd.Visible = True
		Me.lblDspGLCtlPrd.AutoSize = False
		Me.lblDspGLCtlPrd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspGLCtlPrd.Name = "lblDspGLCtlPrd"
		Me.lblDspARCtlPrd.Size = New System.Drawing.Size(65, 20)
		Me.lblDspARCtlPrd.Location = New System.Drawing.Point(88, 184)
		Me.lblDspARCtlPrd.TabIndex = 6
		Me.lblDspARCtlPrd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspARCtlPrd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspARCtlPrd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspARCtlPrd.Enabled = True
		Me.lblDspARCtlPrd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspARCtlPrd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspARCtlPrd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspARCtlPrd.UseMnemonic = True
		Me.lblDspARCtlPrd.Visible = True
		Me.lblDspARCtlPrd.AutoSize = False
		Me.lblDspARCtlPrd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspARCtlPrd.Name = "lblDspARCtlPrd"
		Me.lblCtlPrd.Text = "CUSFAX"
		Me.lblCtlPrd.Size = New System.Drawing.Size(89, 17)
		Me.lblCtlPrd.Location = New System.Drawing.Point(0, 184)
		Me.lblCtlPrd.TabIndex = 5
		Me.lblCtlPrd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCtlPrd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCtlPrd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCtlPrd.Enabled = True
		Me.lblCtlPrd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCtlPrd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCtlPrd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCtlPrd.UseMnemonic = True
		Me.lblCtlPrd.Visible = True
		Me.lblCtlPrd.AutoSize = False
		Me.lblCtlPrd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCtlPrd.Name = "lblCtlPrd"
		Me.lblWarning.Text = "Period From"
		Me.lblWarning.Font = New System.Drawing.Font("·s²Ó©úÅé", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblWarning.Size = New System.Drawing.Size(310, 87)
		Me.lblWarning.Location = New System.Drawing.Point(176, 80)
		Me.lblWarning.TabIndex = 4
		Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWarning.BackColor = System.Drawing.SystemColors.Control
		Me.lblWarning.Enabled = True
		Me.lblWarning.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWarning.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWarning.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWarning.UseMnemonic = True
		Me.lblWarning.Visible = True
		Me.lblWarning.AutoSize = False
		Me.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWarning.Name = "lblWarning"
		Me.Controls.Add(chkGL)
		Me.Controls.Add(chkAP)
		Me.Controls.Add(chkAR)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspAPCtlPrd)
		Me.Controls.Add(lblDspGLCtlPrd)
		Me.Controls.Add(lblDspARCtlPrd)
		Me.Controls.Add(lblCtlPrd)
		Me.Controls.Add(lblWarning)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class