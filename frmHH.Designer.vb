<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHH
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
	Public WithEvents HHList As System.Windows.Forms.ListBox
	Public WithEvents btnImport As System.Windows.Forms.Button
	Public WithEvents btnLoad As System.Windows.Forms.Button
	Public WithEvents btnReceive As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHH))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.HHList = New System.Windows.Forms.ListBox
		Me.btnImport = New System.Windows.Forms.Button
		Me.btnLoad = New System.Windows.Forms.Button
		Me.btnReceive = New System.Windows.Forms.Button
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Receive from HH"
		Me.ClientSize = New System.Drawing.Size(378, 161)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmHH"
		Me.HHList.Size = New System.Drawing.Size(137, 19)
		Me.HHList.Location = New System.Drawing.Point(48, 24)
		Me.HHList.TabIndex = 3
		Me.HHList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.HHList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.HHList.BackColor = System.Drawing.SystemColors.Window
		Me.HHList.CausesValidation = True
		Me.HHList.Enabled = True
		Me.HHList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.HHList.IntegralHeight = True
		Me.HHList.Cursor = System.Windows.Forms.Cursors.Default
		Me.HHList.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.HHList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HHList.Sorted = False
		Me.HHList.TabStop = True
		Me.HHList.Visible = True
		Me.HHList.MultiColumn = False
		Me.HHList.Name = "HHList"
		Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnImport.Text = "Import"
		Me.btnImport.Size = New System.Drawing.Size(73, 25)
		Me.btnImport.Location = New System.Drawing.Point(280, 72)
		Me.btnImport.TabIndex = 2
		Me.btnImport.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnImport.BackColor = System.Drawing.SystemColors.Control
		Me.btnImport.CausesValidation = True
		Me.btnImport.Enabled = True
		Me.btnImport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnImport.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnImport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnImport.TabStop = True
		Me.btnImport.Name = "btnImport"
		Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLoad.Text = "Load"
		Me.btnLoad.Size = New System.Drawing.Size(73, 25)
		Me.btnLoad.Location = New System.Drawing.Point(280, 40)
		Me.btnLoad.TabIndex = 1
		Me.btnLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLoad.BackColor = System.Drawing.SystemColors.Control
		Me.btnLoad.CausesValidation = True
		Me.btnLoad.Enabled = True
		Me.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLoad.TabStop = True
		Me.btnLoad.Name = "btnLoad"
		Me.btnReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnReceive.Text = "Receive"
		Me.btnReceive.Size = New System.Drawing.Size(73, 25)
		Me.btnReceive.Location = New System.Drawing.Point(280, 8)
		Me.btnReceive.TabIndex = 0
		Me.btnReceive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReceive.BackColor = System.Drawing.SystemColors.Control
		Me.btnReceive.CausesValidation = True
		Me.btnReceive.Enabled = True
		Me.btnReceive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnReceive.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnReceive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnReceive.TabStop = True
		Me.btnReceive.Name = "btnReceive"
		Me.Controls.Add(HHList)
		Me.Controls.Add(btnImport)
		Me.Controls.Add(btnLoad)
		Me.Controls.Add(btnReceive)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class