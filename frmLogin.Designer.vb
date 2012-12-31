<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
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
	Public WithEvents cboLangID As System.Windows.Forms.ComboBox
	Public WithEvents cboCompany As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents txtUserID As System.Windows.Forms.TextBox
	Public WithEvents lblLanguage As System.Windows.Forms.Label
	Public WithEvents lblCompany As System.Windows.Forms.Label
	Public WithEvents lblPassword As System.Windows.Forms.Label
	Public WithEvents lblUser As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboLangID = New System.Windows.Forms.ComboBox()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboLangID
        '
        Me.cboLangID.BackColor = System.Drawing.SystemColors.Window
        Me.cboLangID.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLangID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLangID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLangID.Location = New System.Drawing.Point(232, 120)
        Me.cboLangID.Name = "cboLangID"
        Me.cboLangID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLangID.Size = New System.Drawing.Size(150, 22)
        Me.cboLangID.TabIndex = 3
        '
        'cboCompany
        '
        Me.cboCompany.BackColor = System.Drawing.SystemColors.Window
        Me.cboCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCompany.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCompany.Location = New System.Drawing.Point(231, 42)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCompany.Size = New System.Drawing.Size(271, 22)
        Me.cboCompany.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(336, 160)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(108, 48)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(224, 160)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(108, 48)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Tag = "OK"
        Me.cmdOK.Text = "OK"
        Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPassword.Location = New System.Drawing.Point(231, 93)
        Me.txtPassword.MaxLength = 0
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(155, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUserID
        '
        Me.txtUserID.AcceptsReturn = True
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUserID.Location = New System.Drawing.Point(231, 66)
        Me.txtUserID.MaxLength = 0
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUserID.Size = New System.Drawing.Size(155, 20)
        Me.txtUserID.TabIndex = 1
        '
        'lblLanguage
        '
        Me.lblLanguage.BackColor = System.Drawing.Color.Transparent
        Me.lblLanguage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLanguage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLanguage.Location = New System.Drawing.Point(151, 120)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLanguage.Size = New System.Drawing.Size(72, 17)
        Me.lblLanguage.TabIndex = 9
        Me.lblLanguage.Tag = "&User Name:"
        Me.lblLanguage.Text = "&Language:"
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCompany.Location = New System.Drawing.Point(151, 42)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(72, 17)
        Me.lblCompany.TabIndex = 8
        Me.lblCompany.Tag = "&User Name:"
        Me.lblCompany.Text = "&Company:"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPassword.Location = New System.Drawing.Point(151, 94)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(72, 17)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Tag = "&Password:"
        Me.lblPassword.Text = "&Password:"
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUser.Location = New System.Drawing.Point(151, 68)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUser.Size = New System.Drawing.Size(72, 17)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Tag = "&User Name:"
        Me.lblUser.Text = "&User ID:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(510, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboLangID)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(2, 18)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class