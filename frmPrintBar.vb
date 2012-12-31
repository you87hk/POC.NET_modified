Option Strict Off
Option Explicit On
Friend Class frmPrintBar
	Inherits System.Windows.Forms.Form
	
	'Declare the constant value
	'Option
	Private Const cmdPreview As Short = 0
	Private Const cmdPrinter As Short = 1
	Private Const cmdExcel As Short = 2
	Private Const cmdListView As Short = 3
	'Command button for printing
	Private Const PrintOK As Short = 0
	Private Const PrintCancel As Short = 1
	Private Const PrintSave As Short = 2
	Private Const PrintPrinter As Short = 3
	Private Const PrintDetail As Short = 4
	Private Const PrintFont As Short = 5
	'Tab control
	Private Const TabSelect As Short = 0
	Private Const TabSort As Short = 1
	'Command button for listview
	Private Const MoveRight As Short = 0
	Private Const MoveRightAll As Short = 1
	Private Const MoveLeft As Short = 2
	Private Const MoveLeftAll As Short = 3
	Private Const MoveUp As Short = 4
	Private Const MoveDown As Short = 5
	'Listview for from or to
	Private Const PrintFrom As Short = 0
	Private Const PrintTo As Short = 1
	'Listview field subitem
	Private Const ItemField As Short = 1
	Private Const ItemNumFlag As Short = 2
	
	Private Const cmdStart As Short = 1
	Private Const cmdProcess As Short = 2
	Private Const cmdFail As Short = 3
	
	Private Const SummaryHeight As Integer = 3000
	Private Const DetailHeight As Integer = 8000
	Private Const FormWidth As Integer = 9816
	
	
	Private Const tcPreview As String = "Preview"
	Private Const tcPrint As String = "Print"
	Private Const tcExcel As String = "Excel"
	Private Const tcBrowse As String = "Browse"
	Private Const tcPrinter As String = "Printer"
	Private Const tcDetail As String = "Detail"
	Private Const tcExit As String = "Exit"
	
	'variable for new property
	
	Private msReportID As String
	Private msRptDteTim As String
	Private msRptTitle As String
	Private msTableID As String
	
	Dim wsServer As String
	Dim wsDatabase As String
	Dim wsUser As String
	Dim wsPassword As String
	Dim wsSavePath As String
	Dim wiStatus As Short
	Dim wiNoOfCopy As Integer
	Dim wsQuery As String
	Dim wiNoOfRecords As Integer
	Dim wsAction As Short
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Dim wiStartFlg As Boolean
	Dim wsRptPath As String
	Dim wsExcPath As String
	
	
	Private wsMsg As String
	
	'Dim gdbSTEPPro As New ADODB.Connection
	Dim WithEvents wdbCon As ADODB.Connection
	
	
	
	WriteOnly Property RptTitle() As String
		Set(ByVal Value As String)
			
			msRptTitle = Value
			
		End Set
	End Property
	
	
	
	WriteOnly Property RptDteTim() As String
		Set(ByVal Value As String)
			
			msRptDteTim = Value
			
		End Set
	End Property
	
	
	
	WriteOnly Property ReportID() As String
		Set(ByVal Value As String)
			
			msReportID = Value
			
		End Set
	End Property
	WriteOnly Property TableID() As String
		Set(ByVal Value As String)
			
			msTableID = Value
			
		End Set
	End Property
	
	
	
	'UPGRADE_WARNING: Form event frmPrintBar.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmPrintBar_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Scr()
		Ini_Caption()
		
		If gsRTAccess = "Y" Then
			Access_RunTimePrint(1)
		Else
			Access_Print(1)
		End If
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Close()
		Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub frmPrintBar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.Visible = False
		Me.KeyPreview = True
		
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		
		
		
	End Sub
	
	
	Private Sub frmPrintBar_LostFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.LostFocus
		
		'Unload Me
		
	End Sub
	
	Private Sub frmPrintBar_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'SaveUserDefault
		'UPGRADE_NOTE: Object frmPrintBar may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
		
		
	End Sub
	
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		wiStatus = 100
		If wiStatus < 100 Then
			wiStatus = wiStatus + 1
			'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			Timer1.Interval = Timer1.Interval + 200
		Else
			wiStatus = 0
			Timer1.Enabled = False
		End If
		UpdateStatus(picStatus, wiStatus)
		
	End Sub
	
	
	Private Sub Ini_Scr()
		Dim wiStrPos As Short
		Dim wiSemiPos As Short
		
		Me.Visible = True
		
		
		wiStrPos = InStr(1, gsConnectString, "Data Source=", CompareMethod.Text)
		wiSemiPos = InStr(wiStrPos, gsConnectString, ";", CompareMethod.Text)
		wsServer = Mid(gsConnectString, wiStrPos + 12, wiSemiPos - (wiStrPos + 12))
		
		wiStrPos = InStr(1, gsConnectString, "Initial Catalog=", CompareMethod.Text)
		wiSemiPos = InStr(wiStrPos, gsConnectString, ";", CompareMethod.Text)
		wsDatabase = Mid(gsConnectString, wiStrPos + 16, wiSemiPos - (wiStrPos + 16))
		
		wiStrPos = InStr(1, gsConnectString, "User ID=", CompareMethod.Text)
		wiSemiPos = InStr(wiStrPos, gsConnectString, ";", CompareMethod.Text)
		wsUser = Mid(gsConnectString, wiStrPos + 8, wiSemiPos - (wiStrPos + 8))
		
		wiStrPos = InStr(1, gsConnectString, "Password=", CompareMethod.Text)
		'wiSemiPos = InStr(wiStrPos, gsConnectionString, ";", vbTextCompare)
		wsPassword = Mid(gsConnectString, wiStrPos + 9)
		
		
		
		
		If InStr(gsRptPath, ":\") Or InStr(gsRptPath, "\\") Then
			wsRptPath = gsRptPath
		Else
			wsRptPath = My.Application.Info.DirectoryPath & "\" & gsRptPath
		End If
		
		
	End Sub
	
	
	
	
	
	Private Sub Ini_Caption()
		
		Me.Text = msRptTitle
		
	End Sub
	
	Private Sub Access_Print(ByRef inMode As Short)
		Dim acNormal As Object
		Dim acPreview As Object
		' Declare Database variable and Microsoft Access Form variable.
		Dim wsPara As String
		'    Dim appAccess As Access.Application
		Dim appAccess As Object
		Dim tmpString As String
		Dim accessHandle As Integer
		
		
		On Error GoTo Access_Print_Err
		
		UpdateStatus(picStatus, 10)
		
		' Return instance of Application object.
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		UpdateStatus(picStatus, 20)
		appAccess = CreateObject("Access.Application")
		UpdateStatus(picStatus, 30)
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.hWndAccessApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		accessHandle = appAccess.hWndAccessApp
		UpdateStatus(picStatus, 40)
		
		
		'    appAccess.OpenCurrentDatabase (gsrptpath)
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.OpenCurrentDatabase. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		appAccess.OpenCurrentDatabase(wsRptPath & gsDBName, False)
		UpdateStatus(picStatus, 50)
		
		wsQuery = "RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsQuery = wsQuery & "   AND RPTDTETIM = #" & Change_SQLDate(msRptDteTim) & "# "
		
		wsPara = "ODBC;DRIVER=SQL Server;SERVER=" & wsServer & ";UID=" & wsUser & ";PWD=" & wsPassword & ";DATABASE=" & wsDatabase & ";"
		
		
		UpdateStatus(picStatus, 60)
		
		' Print report from Microsoft Access
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Run. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		appAccess.Run("connect_report", Trim(wsPara), Trim(msTableID))
		
		Select Case inMode 'Select Print Mode
			Case 0 'Preview
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(msReportID, acPreview,  , wsQuery)
				UpdateStatus(picStatus, 70)
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.Maximize()
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
				
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.Visible = True
				Call SetWindowPos(accessHandle, HWND_TOPMOST, 0, 0, VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), SWP_SHOWWINDOW)
				
			Case 1 'Print only
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(msReportID, acNormal,  , wsQuery)
				UpdateStatus(picStatus, 70)
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
		End Select
		
		Cursor = System.Windows.Forms.Cursors.Default
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		
		Exit Sub
		
Access_Print_Err: 
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		MsgBox("Error in Access Print!" & Err.Description & " " & wsRptPath & gsDBName)
		Exit Sub
		
	End Sub
	
	
	
	
	
	
	
	
	
	Private Sub UpdateStatus(ByRef pic As System.Windows.Forms.PictureBox, ByVal sngPercent As Single, Optional ByVal fBorderCase As Object = Nothing)
		'-----------------------------------------------------------
		' SUB: UpdStatusBar
		'
		' "Fill" (by percentage) inside the PictureBox and also
		' display the percentage filled
		'
		' IN: [pic] - PictureBox used to bound "fill" region
		'     [sngPercent] - Percentage of the shape to fill
		'     [fBorderCase] - Indicates whether the percentage
		'        specified is a "border case", i.e. exactly 0%
		'        or exactly 100%.  Unless fBorderCase is True,
		'        the values 0% and 100% will be assumed to be
		'        "close" to these values, and 1% and 99% will
		'        be used instead.
		'
		' Notes: Set AutoRedraw property of the PictureBox to True
		'        so that the status bar and percentage can be auto-
		'        matically repainted if necessary
		'-----------------------------------------------------------
		'
		Dim intPercent As Double
		Dim strPercent As String
		Dim intX As Short
		Dim intY As Short
		Dim intWidth As Short
		Dim intHeight As Short
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fBorderCase. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If IsNothing(fBorderCase) Then fBorderCase = False
		
		'For this to work well, we need a white background and any color foreground (blue)
		Const colBackground As Integer = &HFFFFFF ' white
		Const colForeground As Integer = &HFF0000 ' blue
		
		pic.ForeColor = System.Drawing.ColorTranslator.FromOle(colForeground)
		pic.BackColor = System.Drawing.ColorTranslator.FromOle(colBackground)
		
		'
		'Format percentage and get attributes of text
		'
		intPercent = sngPercent
		
		'Never allow the percentage to be 0 or 100 unless it is exactly that value.  This
		'prevents, for instance, the status bar from reaching 100% until we are entirely done.
		If intPercent = 0 Then
			If Not fBorderCase Then
				intPercent = 1
			End If
		ElseIf intPercent = 100 Then 
			If Not fBorderCase Then
				intPercent = 99
			End If
		End If
		If sngPercent <> 0 Then
			strPercent = VB6.Format(intPercent) & "%"
		Else
			strPercent = ""
		End If
		'UPGRADE_ISSUE: PictureBox method pic.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'intWidth = pic.TextWidth(strPercent)
		'UPGRADE_ISSUE: PictureBox method pic.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'intHeight = pic.TextHeight(strPercent)
		
		'
		'Now set intX and intY to the starting location for printing the percentage
		'
		intX = VB6.PixelsToTwipsX(pic.Width) / 2 - intWidth / 2
		intY = VB6.PixelsToTwipsY(pic.Height) / 2 - intHeight / 2
		
		'
		'Need to draw a filled box with the pics background color to wipe out previous
		'percentage display (if any)
		'
		'UPGRADE_ISSUE: PictureBox property pic.DrawMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.DrawMode = 13 ' Copy Pen
		'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.Line (intX, intY) - Step(intWidth, intHeight), System.Drawing.ColorTranslator.ToOle(pic.BackColor), BF
		
		'
		'Back to the center print position and print the text
		'
		'UPGRADE_ISSUE: PictureBox property pic.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.CurrentX = intX
		'UPGRADE_ISSUE: PictureBox property pic.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.CurrentY = intY
		'UPGRADE_ISSUE: PictureBox method pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.Print(strPercent)
		
		'
		'Now fill in the box with the ribbon color to the desired percentage
		'If percentage is 0, fill the whole box with the background color to clear it
		'Use the "Not XOR" pen so that we change the color of the text to white
		'wherever we touch it, and change the color of the background to blue
		'wherever we touch it.
		'
		'UPGRADE_ISSUE: PictureBox property pic.DrawMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.DrawMode = 10 ' Not XOR Pen
		If sngPercent > 0 Then
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'pic.Line (0, 0) - (VB6.PixelsToTwipsX(pic.Width) * (sngPercent / 100), VB6.PixelsToTwipsY(pic.Height)), System.Drawing.ColorTranslator.ToOle(pic.ForeColor), BF
		Else
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'pic.Line (0, 0) - (VB6.PixelsToTwipsX(pic.Width), VB6.PixelsToTwipsY(pic.Height)), System.Drawing.ColorTranslator.ToOle(pic.BackColor), BF
		End If
		
		pic.Refresh()
		
	End Sub
	Private Sub Access_RunTimePrint(ByRef inMode As Short)
		Dim acNormal As Object
		Dim acPreview As Object
		' Declare Database variable and Microsoft Access Form variable.
		Dim wsPara As String
		'    Dim appAccess As Access.Application
		Dim appAccess As Object
		Dim tmpString As String
		Dim accessHandle As Integer
		Dim X As Integer
		
		On Error GoTo Access_RunTimePrint_Err
		
		UpdateStatus(picStatus, 10)
		
		' Return instance of Application object.
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		
		UpdateStatus(picStatus, 20)
		
		X = Shell("c:\myapp\Office\msaccess.exe " & Chr(34) & wsRptPath & gsDBName & Chr(34) & "/Runtime /Wrkgrp " & Chr(34) & "c:\myapp\system.mdw" & Chr(34))
		
		UpdateStatus(picStatus, 30)
		appAccess = GetObject(wsRptPath & gsDBName)
		UpdateStatus(picStatus, 40)
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.hWndAccessApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		accessHandle = appAccess.hWndAccessApp
		UpdateStatus(picStatus, 50)
		
		
		'appAccess.OpenCurrentDatabase wsRptPath & gsDBName, False
		'UpdateStatus picStatus, 50
		
		wsQuery = "RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsQuery = wsQuery & "   AND RPTDTETIM = #" & Change_SQLDate(msRptDteTim) & "# "
		
		
		wsPara = "ODBC;DRIVER=SQL Server;SERVER=" & wsServer & ";UID=" & wsUser & ";PWD=" & wsPassword & ";DATABASE=" & wsDatabase & ";"
		
		UpdateStatus(picStatus, 60)
		
		' Print report from Microsoft Access
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Run. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		appAccess.Run("connect_report", Trim(wsPara), Trim(msTableID))
		
		
		
		Select Case inMode 'Select Print Mode
			Case 0 'Preview
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(msReportID, acPreview,  , wsQuery)
				UpdateStatus(picStatus, 70)
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.Maximize()
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
				
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.Visible = True
				Call SetWindowPos(accessHandle, HWND_TOPMOST, 0, 0, VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), SWP_SHOWWINDOW)
				
			Case 1 'Print only
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(msReportID, acNormal,  , wsQuery)
				UpdateStatus(picStatus, 70)
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
		End Select
		
		Cursor = System.Windows.Forms.Cursors.Default
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		
		Exit Sub
		
Access_RunTimePrint_Err: 
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		MsgBox("Error in Access Print! " & Err.Description)
		Exit Sub
		
	End Sub
End Class