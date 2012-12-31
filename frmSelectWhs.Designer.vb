<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSelectWhs
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
	Public WithEvents _OptComp_1 As System.Windows.Forms.RadioButton
	Public WithEvents _OptComp_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraSelect As System.Windows.Forms.GroupBox
	Public WithEvents OptComp As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelectWhs))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraSelect = New System.Windows.Forms.GroupBox
		Me._OptComp_1 = New System.Windows.Forms.RadioButton
		Me._OptComp_0 = New System.Windows.Forms.RadioButton
		Me.OptComp = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraSelect.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.OptComp, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "New Key"
		Me.ClientSize = New System.Drawing.Size(350, 159)
		Me.Location = New System.Drawing.Point(66, 161)
		Me.Icon = CType(resources.GetObject("frmSelectWhs.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmSelectWhs"
		Me.fraSelect.Text = "Frame1"
		Me.fraSelect.Size = New System.Drawing.Size(265, 113)
		Me.fraSelect.Location = New System.Drawing.Point(40, 24)
		Me.fraSelect.TabIndex = 0
		Me.fraSelect.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSelect.BackColor = System.Drawing.SystemColors.Control
		Me.fraSelect.Enabled = True
		Me.fraSelect.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSelect.Visible = True
		Me.fraSelect.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSelect.Name = "fraSelect"
		Me._OptComp_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptComp_1.Text = "Option1"
		Me._OptComp_1.Size = New System.Drawing.Size(161, 25)
		Me._OptComp_1.Location = New System.Drawing.Point(32, 64)
		Me._OptComp_1.TabIndex = 2
		Me._OptComp_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptComp_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptComp_1.BackColor = System.Drawing.SystemColors.Control
		Me._OptComp_1.CausesValidation = True
		Me._OptComp_1.Enabled = True
		Me._OptComp_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptComp_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptComp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptComp_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptComp_1.TabStop = True
		Me._OptComp_1.Checked = False
		Me._OptComp_1.Visible = True
		Me._OptComp_1.Name = "_OptComp_1"
		Me._OptComp_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptComp_0.Text = "Option1"
		Me._OptComp_0.Size = New System.Drawing.Size(161, 25)
		Me._OptComp_0.Location = New System.Drawing.Point(32, 16)
		Me._OptComp_0.TabIndex = 1
		Me._OptComp_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptComp_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptComp_0.BackColor = System.Drawing.SystemColors.Control
		Me._OptComp_0.CausesValidation = True
		Me._OptComp_0.Enabled = True
		Me._OptComp_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptComp_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptComp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptComp_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptComp_0.TabStop = True
		Me._OptComp_0.Checked = False
		Me._OptComp_0.Visible = True
		Me._OptComp_0.Name = "_OptComp_0"
		Me.Controls.Add(fraSelect)
		Me.fraSelect.Controls.Add(_OptComp_1)
		Me.fraSelect.Controls.Add(_OptComp_0)
		Me.OptComp.SetIndex(_OptComp_1, CType(1, Short))
		Me.OptComp.SetIndex(_OptComp_0, CType(0, Short))
		CType(Me.OptComp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraSelect.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class