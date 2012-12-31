<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAPS0011
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
	Public WithEvents lblDspCusNo As System.Windows.Forms.Label
	Public WithEvents lblDspDocNo As System.Windows.Forms.Label
	Public WithEvents lblCusNo As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblDspItmDesc As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAPS0011))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblDspCusNo = New System.Windows.Forms.Label
		Me.lblDspDocNo = New System.Windows.Forms.Label
		Me.lblCusNo = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me.lblDspItmDesc = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.tbrProcess.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "快速搜尋"
		Me.ClientSize = New System.Drawing.Size(711, 494)
		Me.Location = New System.Drawing.Point(5, 67)
		Me.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Icon = CType(resources.GetObject("frmAPS0011.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAPS0011"
		Me.Frame1.Size = New System.Drawing.Size(697, 73)
		Me.Frame1.Location = New System.Drawing.Point(8, 24)
		Me.Frame1.TabIndex = 1
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.lblDspCusNo.Size = New System.Drawing.Size(337, 20)
		Me.lblDspCusNo.Location = New System.Drawing.Point(136, 40)
		Me.lblDspCusNo.TabIndex = 6
		Me.lblDspCusNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusNo.Enabled = True
		Me.lblDspCusNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusNo.UseMnemonic = True
		Me.lblDspCusNo.Visible = True
		Me.lblDspCusNo.AutoSize = False
		Me.lblDspCusNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusNo.Name = "lblDspCusNo"
		Me.lblDspDocNo.Size = New System.Drawing.Size(169, 20)
		Me.lblDspDocNo.Location = New System.Drawing.Point(136, 16)
		Me.lblDspDocNo.TabIndex = 5
		Me.lblDspDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspDocNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspDocNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspDocNo.Enabled = True
		Me.lblDspDocNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspDocNo.UseMnemonic = True
		Me.lblDspDocNo.Visible = True
		Me.lblDspDocNo.AutoSize = False
		Me.lblDspDocNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspDocNo.Name = "lblDspDocNo"
		Me.lblCusNo.Text = "Customer Code From"
		Me.lblCusNo.Size = New System.Drawing.Size(110, 15)
		Me.lblCusNo.Location = New System.Drawing.Point(8, 41)
		Me.lblCusNo.TabIndex = 3
		Me.lblCusNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusNo.Enabled = True
		Me.lblCusNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusNo.UseMnemonic = True
		Me.lblCusNo.Visible = True
		Me.lblCusNo.AutoSize = False
		Me.lblCusNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusNo.Name = "lblCusNo"
		Me.lblDocNo.Text = "Document # From"
		Me.lblDocNo.Size = New System.Drawing.Size(126, 15)
		Me.lblDocNo.Location = New System.Drawing.Point(8, 17)
		Me.lblDocNo.TabIndex = 2
		Me.lblDocNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDocNo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDocNo.BackColor = System.Drawing.SystemColors.Control
		Me.lblDocNo.Enabled = True
		Me.lblDocNo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDocNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDocNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDocNo.UseMnemonic = True
		Me.lblDocNo.Visible = True
		Me.lblDocNo.AutoSize = False
		Me.lblDocNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDocNo.Name = "lblDocNo"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(697, 361)
		Me.tblDetail.Location = New System.Drawing.Point(8, 104)
		Me.tblDetail.TabIndex = 0
		Me.tblDetail.Name = "tblDetail"
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
		Me.iglProcess.Images.SetKeyName(12, "")
		Me.iglProcess.Images.SetKeyName(13, "")
		Me.iglProcess.Images.SetKeyName(14, "")
		Me.iglProcess.Images.SetKeyName(15, "")
		Me.iglProcess.Images.SetKeyName(16, "")
		Me.iglProcess.Images.SetKeyName(17, "")
		Me.iglProcess.Images.SetKeyName(18, "")
		Me.iglProcess.Images.SetKeyName(19, "")
		Me.iglProcess.Images.SetKeyName(20, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(711, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 7
		Me.tbrProcess.ImageList = iglProcess
		Me.tbrProcess.Name = "tbrProcess"
		Me._tbrProcess_Button1.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button1.AutoSize = False
		Me._tbrProcess_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button1.ImageIndex = 4
		Me._tbrProcess_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button2.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button2.AutoSize = False
		Me._tbrProcess_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button2.Visible = 0
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Exit"
		Me._tbrProcess_Button3.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button3.ImageIndex = 8
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Refresh"
		Me._tbrProcess_Button5.ToolTipText = "重新整理 (F5)"
		Me._tbrProcess_Button5.ImageIndex = 7
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.lblDspItmDesc.Size = New System.Drawing.Size(657, 20)
		Me.lblDspItmDesc.Location = New System.Drawing.Point(8, 472)
		Me.lblDspItmDesc.TabIndex = 4
		Me.lblDspItmDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspItmDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspItmDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspItmDesc.Enabled = True
		Me.lblDspItmDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspItmDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspItmDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspItmDesc.UseMnemonic = True
		Me.lblDspItmDesc.Visible = True
		Me.lblDspItmDesc.AutoSize = False
		Me.lblDspItmDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspItmDesc.Name = "lblDspItmDesc"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(tblDetail)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(lblDspItmDesc)
		Me.Frame1.Controls.Add(lblDspCusNo)
		Me.Frame1.Controls.Add(lblDspDocNo)
		Me.Frame1.Controls.Add(lblCusNo)
		Me.Frame1.Controls.Add(lblDocNo)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.tbrProcess.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class