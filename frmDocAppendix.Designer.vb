<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDocAppendix
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
	Public WithEvents btnDelTemp As System.Windows.Forms.Button
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents txtSaveAs As System.Windows.Forms.TextBox
	Public WithEvents cboTemplete As System.Windows.Forms.ComboBox
	Public WithEvents btnSaveAs As System.Windows.Forms.Button
	Public WithEvents txtRmk As System.Windows.Forms.TextBox
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents btnClear As System.Windows.Forms.Button
	Public WithEvents btnItmDir As System.Windows.Forms.Button
	Public WithEvents txtItmDir As System.Windows.Forms.TextBox
	Public WithEvents imgCover As System.Windows.Forms.PictureBox
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	Public cdlgDirOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents lblDspDocNo As System.Windows.Forms.Label
	Public WithEvents lblDocNo As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocAppendix))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btnDelTemp = New System.Windows.Forms.Button
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.txtSaveAs = New System.Windows.Forms.TextBox
		Me.cboTemplete = New System.Windows.Forms.ComboBox
		Me.btnSaveAs = New System.Windows.Forms.Button
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.txtRmk = New System.Windows.Forms.TextBox
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.btnClear = New System.Windows.Forms.Button
		Me.btnItmDir = New System.Windows.Forms.Button
		Me.txtItmDir = New System.Windows.Forms.TextBox
		Me.imgCover = New System.Windows.Forms.PictureBox
		Me.cdlgDirOpen = New System.Windows.Forms.OpenFileDialog
		Me.lblDspDocNo = New System.Windows.Forms.Label
		Me.lblDocNo = New System.Windows.Forms.Label
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "New Key"
		Me.ClientSize = New System.Drawing.Size(856, 603)
		Me.Location = New System.Drawing.Point(66, 161)
		Me.Icon = CType(resources.GetObject("frmDocAppendix.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmDocAppendix"
		Me.btnDelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnDelTemp.Text = "Replace"
		Me.btnDelTemp.Size = New System.Drawing.Size(89, 25)
		Me.btnDelTemp.Location = New System.Drawing.Point(552, 16)
		Me.btnDelTemp.TabIndex = 11
		Me.btnDelTemp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelTemp.BackColor = System.Drawing.SystemColors.Control
		Me.btnDelTemp.CausesValidation = True
		Me.btnDelTemp.Enabled = True
		Me.btnDelTemp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnDelTemp.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnDelTemp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnDelTemp.TabStop = True
		Me.btnDelTemp.Name = "btnDelTemp"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(632, 40)
		Me.tblCommon.TabIndex = 7
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.txtSaveAs.AutoSize = False
		Me.txtSaveAs.Size = New System.Drawing.Size(111, 20)
		Me.txtSaveAs.Location = New System.Drawing.Point(736, 16)
		Me.txtSaveAs.TabIndex = 2
		Me.txtSaveAs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaveAs.AcceptsReturn = True
		Me.txtSaveAs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSaveAs.BackColor = System.Drawing.SystemColors.Window
		Me.txtSaveAs.CausesValidation = True
		Me.txtSaveAs.Enabled = True
		Me.txtSaveAs.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSaveAs.HideSelection = True
		Me.txtSaveAs.ReadOnly = False
		Me.txtSaveAs.Maxlength = 0
		Me.txtSaveAs.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSaveAs.MultiLine = False
		Me.txtSaveAs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSaveAs.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSaveAs.TabStop = True
		Me.txtSaveAs.Visible = True
		Me.txtSaveAs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSaveAs.Name = "txtSaveAs"
		Me.cboTemplete.Size = New System.Drawing.Size(294, 20)
		Me.cboTemplete.Location = New System.Drawing.Point(248, 16)
		Me.cboTemplete.TabIndex = 0
		Me.cboTemplete.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTemplete.BackColor = System.Drawing.SystemColors.Window
		Me.cboTemplete.CausesValidation = True
		Me.cboTemplete.Enabled = True
		Me.cboTemplete.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTemplete.IntegralHeight = True
		Me.cboTemplete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTemplete.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTemplete.Sorted = False
		Me.cboTemplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboTemplete.TabStop = True
		Me.cboTemplete.Visible = True
		Me.cboTemplete.Name = "cboTemplete"
		Me.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSaveAs.Text = "Replace"
		Me.btnSaveAs.Size = New System.Drawing.Size(89, 25)
		Me.btnSaveAs.Location = New System.Drawing.Point(640, 16)
		Me.btnSaveAs.TabIndex = 1
		Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveAs.BackColor = System.Drawing.SystemColors.Control
		Me.btnSaveAs.CausesValidation = True
		Me.btnSaveAs.Enabled = True
		Me.btnSaveAs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSaveAs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSaveAs.TabStop = True
		Me.btnSaveAs.Name = "btnSaveAs"
		Me.tabDetailInfo.Size = New System.Drawing.Size(833, 553)
		Me.tabDetailInfo.Location = New System.Drawing.Point(8, 48)
		Me.tabDetailInfo.TabIndex = 4
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "Customer Pricing"
		Me.txtRmk.AutoSize = False
		Me.txtRmk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRmk.Size = New System.Drawing.Size(805, 513)
		Me.txtRmk.Location = New System.Drawing.Point(8, 8)
		Me.txtRmk.MultiLine = True
		Me.txtRmk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtRmk.TabIndex = 3
		Me.txtRmk.AcceptsReturn = True
		Me.txtRmk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRmk.BackColor = System.Drawing.SystemColors.Window
		Me.txtRmk.CausesValidation = True
		Me.txtRmk.Enabled = True
		Me.txtRmk.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRmk.HideSelection = True
		Me.txtRmk.ReadOnly = False
		Me.txtRmk.Maxlength = 0
		Me.txtRmk.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRmk.TabStop = True
		Me.txtRmk.Visible = True
		Me.txtRmk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRmk.Name = "txtRmk"
		Me._tabDetailInfo_TabPage1.Text = "Vendor Pricing"
		Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnClear.Text = "Clear"
		Me.btnClear.Size = New System.Drawing.Size(49, 21)
		Me.btnClear.Location = New System.Drawing.Point(408, 8)
		Me.btnClear.TabIndex = 10
		Me.btnClear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.BackColor = System.Drawing.SystemColors.Control
		Me.btnClear.CausesValidation = True
		Me.btnClear.Enabled = True
		Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClear.TabStop = True
		Me.btnClear.Name = "btnClear"
		Me.btnItmDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnItmDir.Text = "..."
		Me.btnItmDir.Size = New System.Drawing.Size(25, 21)
		Me.btnItmDir.Location = New System.Drawing.Point(376, 8)
		Me.btnItmDir.TabIndex = 9
		Me.btnItmDir.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnItmDir.BackColor = System.Drawing.SystemColors.Control
		Me.btnItmDir.CausesValidation = True
		Me.btnItmDir.Enabled = True
		Me.btnItmDir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnItmDir.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnItmDir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnItmDir.TabStop = True
		Me.btnItmDir.Name = "btnItmDir"
		Me.txtItmDir.AutoSize = False
		Me.txtItmDir.Size = New System.Drawing.Size(357, 20)
		Me.txtItmDir.Location = New System.Drawing.Point(16, 8)
		Me.txtItmDir.TabIndex = 8
		Me.txtItmDir.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItmDir.AcceptsReturn = True
		Me.txtItmDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtItmDir.BackColor = System.Drawing.SystemColors.Window
		Me.txtItmDir.CausesValidation = True
		Me.txtItmDir.Enabled = True
		Me.txtItmDir.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtItmDir.HideSelection = True
		Me.txtItmDir.ReadOnly = False
		Me.txtItmDir.Maxlength = 0
		Me.txtItmDir.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtItmDir.MultiLine = False
		Me.txtItmDir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtItmDir.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtItmDir.TabStop = True
		Me.txtItmDir.Visible = True
		Me.txtItmDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtItmDir.Name = "txtItmDir"
		Me.imgCover.Size = New System.Drawing.Size(785, 481)
		Me.imgCover.Location = New System.Drawing.Point(16, 32)
		Me.imgCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imgCover.Enabled = True
		Me.imgCover.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgCover.Visible = True
		Me.imgCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.imgCover.Name = "imgCover"
		Me.lblDspDocNo.Text = "NEW KEY:"
		Me.lblDspDocNo.Size = New System.Drawing.Size(137, 25)
		Me.lblDspDocNo.Location = New System.Drawing.Point(104, 16)
		Me.lblDspDocNo.TabIndex = 6
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
		Me.lblDocNo.Text = "NEW KEY:"
		Me.lblDocNo.Size = New System.Drawing.Size(81, 17)
		Me.lblDocNo.Location = New System.Drawing.Point(16, 16)
		Me.lblDocNo.TabIndex = 5
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
		Me.Controls.Add(btnDelTemp)
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(txtSaveAs)
		Me.Controls.Add(cboTemplete)
		Me.Controls.Add(btnSaveAs)
		Me.Controls.Add(tabDetailInfo)
		Me.Controls.Add(lblDspDocNo)
		Me.Controls.Add(lblDocNo)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtRmk)
		Me._tabDetailInfo_TabPage1.Controls.Add(btnClear)
		Me._tabDetailInfo_TabPage1.Controls.Add(btnItmDir)
		Me._tabDetailInfo_TabPage1.Controls.Add(txtItmDir)
		Me._tabDetailInfo_TabPage1.Controls.Add(imgCover)
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class