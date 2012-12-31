<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSpecialPassword
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
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOK As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents lblPassword As System.Windows.Forms.Label
	Public WithEvents fraHeader As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSpecialPassword))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraHeader = New System.Windows.Forms.GroupBox
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOK = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.lblPassword = New System.Windows.Forms.Label
		Me.fraHeader.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "New Key"
		Me.ClientSize = New System.Drawing.Size(385, 159)
		Me.Location = New System.Drawing.Point(66, 161)
		Me.Icon = CType(resources.GetObject("frmSpecialPassword.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSpecialPassword"
		Me.fraHeader.Size = New System.Drawing.Size(365, 136)
		Me.fraHeader.Location = New System.Drawing.Point(8, 8)
		Me.fraHeader.TabIndex = 0
		Me.fraHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraHeader.BackColor = System.Drawing.SystemColors.Control
		Me.fraHeader.Enabled = True
		Me.fraHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraHeader.Visible = True
		Me.fraHeader.Padding = New System.Windows.Forms.Padding(0)
		Me.fraHeader.Name = "fraHeader"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(89, 49)
		Me.btnCancel.Location = New System.Drawing.Point(104, 80)
		Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
		Me.btnCancel.TabIndex = 4
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnOK.Text = "OK"
		Me.btnOK.Size = New System.Drawing.Size(89, 49)
		Me.btnOK.Location = New System.Drawing.Point(8, 80)
		Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
		Me.btnOK.TabIndex = 3
		Me.btnOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.CausesValidation = True
		Me.btnOK.Enabled = True
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.TabStop = True
		Me.btnOK.Name = "btnOK"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Size = New System.Drawing.Size(339, 21)
		Me.txtPassword.Location = New System.Drawing.Point(8, 48)
		Me.txtPassword.TabIndex = 1
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
		Me.lblPassword.Text = "NEW KEY:"
		Me.lblPassword.Size = New System.Drawing.Size(201, 16)
		Me.lblPassword.Location = New System.Drawing.Point(8, 24)
		Me.lblPassword.TabIndex = 2
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
		Me.Controls.Add(fraHeader)
		Me.fraHeader.Controls.Add(btnCancel)
		Me.fraHeader.Controls.Add(btnOK)
		Me.fraHeader.Controls.Add(txtPassword)
		Me.fraHeader.Controls.Add(lblPassword)
		Me.fraHeader.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class