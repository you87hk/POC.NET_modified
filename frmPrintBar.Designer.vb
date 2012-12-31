<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintBar
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
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents picStatus As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrintBar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.picStatus = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Report Printing"
		Me.ClientSize = New System.Drawing.Size(342, 76)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.Icon = CType(resources.GetObject("frmPrintBar.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "frmPrintBar"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1000
		Me.picStatus.BackColor = System.Drawing.Color.White
		Me.picStatus.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatus.Size = New System.Drawing.Size(307, 28)
		Me.picStatus.Location = New System.Drawing.Point(16, 24)
		Me.picStatus.TabIndex = 0
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
		Me.Controls.Add(picStatus)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class