<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDocRemark
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
	Public WithEvents txtRmk As System.Windows.Forms.TextBox
	Public WithEvents lblRmk As System.Windows.Forms.Label
	Public WithEvents fraHeader As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocRemark))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraHeader = New System.Windows.Forms.GroupBox
		Me.txtRmk = New System.Windows.Forms.TextBox
		Me.lblRmk = New System.Windows.Forms.Label
		Me.fraHeader.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "New Key"
		Me.ClientSize = New System.Drawing.Size(382, 390)
		Me.Location = New System.Drawing.Point(66, 161)
		Me.Icon = CType(resources.GetObject("frmDocRemark.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmDocRemark"
		Me.fraHeader.Size = New System.Drawing.Size(365, 368)
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
		Me.txtRmk.AutoSize = False
		Me.txtRmk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRmk.Size = New System.Drawing.Size(341, 325)
		Me.txtRmk.Location = New System.Drawing.Point(8, 32)
		Me.txtRmk.MultiLine = True
		Me.txtRmk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtRmk.TabIndex = 1
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
		Me.lblRmk.Text = "NEW KEY:"
		Me.lblRmk.Size = New System.Drawing.Size(121, 16)
		Me.lblRmk.Location = New System.Drawing.Point(8, 16)
		Me.lblRmk.TabIndex = 2
		Me.lblRmk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRmk.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRmk.BackColor = System.Drawing.SystemColors.Control
		Me.lblRmk.Enabled = True
		Me.lblRmk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRmk.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRmk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRmk.UseMnemonic = True
		Me.lblRmk.Visible = True
		Me.lblRmk.AutoSize = False
		Me.lblRmk.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRmk.Name = "lblRmk"
		Me.Controls.Add(fraHeader)
		Me.fraHeader.Controls.Add(txtRmk)
		Me.fraHeader.Controls.Add(lblRmk)
		Me.fraHeader.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class