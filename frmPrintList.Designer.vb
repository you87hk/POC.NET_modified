<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintList
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
	Public cdFontFont As System.Windows.Forms.FontDialog
	Public WithEvents lstData As System.Windows.Forms.ListView
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblRptTitle As System.Windows.Forms.Label
	Public WithEvents lblSummary As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cdFontFont = New System.Windows.Forms.FontDialog
		Me.lstData = New System.Windows.Forms.ListView
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me.lblRptTitle = New System.Windows.Forms.Label
		Me.lblSummary = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Print List"
		Me.ClientSize = New System.Drawing.Size(785, 548)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmPrintList.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "frmPrintList"
		Me.lstData.Size = New System.Drawing.Size(766, 454)
		Me.lstData.Location = New System.Drawing.Point(8, 80)
		Me.lstData.TabIndex = 0
		Me.lstData.View = System.Windows.Forms.View.Details
		Me.lstData.LabelWrap = True
		Me.lstData.HideSelection = True
		Me.lstData.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstData.BackColor = System.Drawing.SystemColors.Window
		Me.lstData.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstData.LabelEdit = True
		Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstData.Name = "lstData"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.iglProcess.ImageStream = CType(resources.GetObject("iglProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.iglProcess.Images.SetKeyName(0, "")
		Me.iglProcess.Images.SetKeyName(1, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(785, 24)
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
		Me._tbrProcess_Button2.Name = "Font"
		Me._tbrProcess_Button2.ToolTipText = "Font (F9)"
		Me._tbrProcess_Button2.ImageIndex = 1
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Exit"
		Me._tbrProcess_Button3.ToolTipText = "Exit (F12)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblRptTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblRptTitle.Text = "Label2"
		Me.lblRptTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRptTitle.Size = New System.Drawing.Size(769, 17)
		Me.lblRptTitle.Location = New System.Drawing.Point(8, 32)
		Me.lblRptTitle.TabIndex = 2
		Me.lblRptTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblRptTitle.Enabled = True
		Me.lblRptTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRptTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRptTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRptTitle.UseMnemonic = True
		Me.lblRptTitle.Visible = True
		Me.lblRptTitle.AutoSize = False
		Me.lblRptTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRptTitle.Name = "lblRptTitle"
		Me.lblSummary.Text = "Label1"
		Me.lblSummary.Size = New System.Drawing.Size(617, 22)
		Me.lblSummary.Location = New System.Drawing.Point(8, 56)
		Me.lblSummary.TabIndex = 1
		Me.lblSummary.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSummary.BackColor = System.Drawing.SystemColors.Control
		Me.lblSummary.Enabled = True
		Me.lblSummary.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSummary.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSummary.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSummary.UseMnemonic = True
		Me.lblSummary.Visible = True
		Me.lblSummary.AutoSize = False
		Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSummary.Name = "lblSummary"
		Me.Controls.Add(lstData)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblRptTitle)
		Me.Controls.Add(lblSummary)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class