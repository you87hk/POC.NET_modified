<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCHGPWD
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
	Public WithEvents txtNewPassword As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents lblDspUserID As System.Windows.Forms.Label
	Public WithEvents lblNewPassword As System.Windows.Forms.Label
	Public WithEvents lblPassword As System.Windows.Forms.Label
	Public WithEvents lblUser As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCHGPWD))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtNewPassword = New System.Windows.Forms.TextBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOK = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.lblDspUserID = New System.Windows.Forms.Label
		Me.lblNewPassword = New System.Windows.Forms.Label
		Me.lblPassword = New System.Windows.Forms.Label
		Me.lblUser = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Chang Pasword"
		Me.ClientSize = New System.Drawing.Size(440, 225)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmCHGPWD.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Tag = "Login"
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCHGPWD"
		Me.txtNewPassword.AutoSize = False
		Me.txtNewPassword.Size = New System.Drawing.Size(155, 20)
		Me.txtNewPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtNewPassword.Location = New System.Drawing.Point(184, 104)
		Me.txtNewPassword.PasswordChar = ChrW(42)
		Me.txtNewPassword.TabIndex = 1
		Me.txtNewPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNewPassword.AcceptsReturn = True
		Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNewPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtNewPassword.CausesValidation = True
		Me.txtNewPassword.Enabled = True
		Me.txtNewPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNewPassword.HideSelection = True
		Me.txtNewPassword.ReadOnly = False
		Me.txtNewPassword.Maxlength = 0
		Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNewPassword.MultiLine = False
		Me.txtNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNewPassword.TabStop = True
		Me.txtNewPassword.Visible = True
		Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNewPassword.Name = "txtNewPassword"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(108, 48)
		Me.cmdCancel.Location = New System.Drawing.Point(232, 152)
		Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
		Me.cmdCancel.TabIndex = 3
		Me.cmdCancel.Tag = "Cancel"
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOK.Text = "OK"
		Me.cmdOK.Size = New System.Drawing.Size(108, 48)
		Me.cmdOK.Location = New System.Drawing.Point(120, 152)
		Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
		Me.cmdOK.TabIndex = 2
		Me.cmdOK.Tag = "OK"
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Size = New System.Drawing.Size(155, 20)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(183, 77)
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 0
		Me.txtPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me.lblDspUserID.Size = New System.Drawing.Size(151, 20)
		Me.lblDspUserID.Location = New System.Drawing.Point(184, 48)
		Me.lblDspUserID.TabIndex = 7
		Me.lblDspUserID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspUserID.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspUserID.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspUserID.Enabled = True
		Me.lblDspUserID.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspUserID.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspUserID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspUserID.UseMnemonic = True
		Me.lblDspUserID.Visible = True
		Me.lblDspUserID.AutoSize = False
		Me.lblDspUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspUserID.Name = "lblDspUserID"
		Me.lblNewPassword.Text = "&Password:"
		Me.lblNewPassword.Size = New System.Drawing.Size(72, 17)
		Me.lblNewPassword.Location = New System.Drawing.Point(104, 105)
		Me.lblNewPassword.TabIndex = 6
		Me.lblNewPassword.Tag = "&Password:"
		Me.lblNewPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNewPassword.BackColor = System.Drawing.SystemColors.Control
		Me.lblNewPassword.Enabled = True
		Me.lblNewPassword.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNewPassword.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNewPassword.UseMnemonic = True
		Me.lblNewPassword.Visible = True
		Me.lblNewPassword.AutoSize = False
		Me.lblNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNewPassword.Name = "lblNewPassword"
		Me.lblPassword.Text = "&Password:"
		Me.lblPassword.Size = New System.Drawing.Size(72, 17)
		Me.lblPassword.Location = New System.Drawing.Point(103, 78)
		Me.lblPassword.TabIndex = 4
		Me.lblPassword.Tag = "&Password:"
		Me.lblPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPassword.BackColor = System.Drawing.SystemColors.Control
		Me.lblPassword.Enabled = True
		Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPassword.UseMnemonic = True
		Me.lblPassword.Visible = True
		Me.lblPassword.AutoSize = False
		Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPassword.Name = "lblPassword"
		Me.lblUser.Text = "&User ID:"
		Me.lblUser.Size = New System.Drawing.Size(72, 17)
		Me.lblUser.Location = New System.Drawing.Point(103, 52)
		Me.lblUser.TabIndex = 5
		Me.lblUser.Tag = "&User Name:"
		Me.lblUser.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUser.BackColor = System.Drawing.SystemColors.Control
		Me.lblUser.Enabled = True
		Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUser.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUser.UseMnemonic = True
		Me.lblUser.Visible = True
		Me.lblUser.AutoSize = False
		Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUser.Name = "lblUser"
		Me.Controls.Add(txtNewPassword)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtPassword)
		Me.Controls.Add(lblDspUserID)
		Me.Controls.Add(lblNewPassword)
		Me.Controls.Add(lblPassword)
		Me.Controls.Add(lblUser)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class