Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Friend Class frmPrint
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
	Private msTableID As String
	Private msReportID As String
	Private msStoreP As String
	Private msRptDteTim As String
	Private msRptTitle As String
	Private msRptName As String
	Private msSelection As Object
	'misc. variable
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
	
	
	
	Property StoreP() As String
		Get
			
			StoreP = msStoreP
			
		End Get
		Set(ByVal Value As String)
			
			msStoreP = Value
			
		End Set
	End Property
	
	
	Property TableID() As String
		Get
			
			TableID = msTableID
			
		End Get
		Set(ByVal Value As String)
			
			msTableID = Value
			
		End Set
	End Property
	
	Property RptTitle() As String
		Get
			
			RptTitle = msRptTitle
			
		End Get
		Set(ByVal Value As String)
			
			msRptTitle = Value
			
		End Set
	End Property
	
	Property RptName() As String
		Get
			
			RptName = msRptName
			
		End Get
		Set(ByVal Value As String)
			
			msRptName = Value
			
		End Set
	End Property
	
	Property RptDteTim() As String
		Get
			
			RptDteTim = msRptDteTim
			
		End Get
		Set(ByVal Value As String)
			
			msRptDteTim = Value
			
		End Set
	End Property
	
	
	Property ReportID() As String
		Get
			
			ReportID = msReportID
			
		End Get
		Set(ByVal Value As String)
			
			msReportID = Value
			
		End Set
	End Property
	
	
	Property Selection() As Object
		Get
			
			'UPGRADE_WARNING: Couldn't resolve default property of object msSelection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Selection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Selection = msSelection
			
		End Get
		Set(ByVal Value As Object)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object NewSelection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object msSelection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			msSelection = Value
			
		End Set
	End Property
	
	Private Sub btnSavePath_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSavePath.Click
		
		On Error Resume Next
		
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With cdSaveAs
        '	.Title = "Save Excel File to "
        '	.InitialDirectory = gsExcPath
        '	.FileName = lblDspSavePath.Text
        '	'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '	.Filter = "Excel File (*.xls)|*.xls"
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	.CancelError = True
        '	.ShowDialog()

        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	If Err.Number <> DialogResult.Cancel Then
        '		lblDspSavePath.Text = .FileName
        '	End If

        'End With
		
		On Error GoTo 0
		
		
	End Sub
	
	
	
	Private Sub cmdSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelect.Click
		Dim Index As Short = cmdSelect.GetIndex(eventSender)
		
		Select Case Index
			Case MoveRight
				MoveSelectItem(PrintFrom, False)
			Case MoveRightAll
				MoveSelectItem(PrintFrom, True)
			Case MoveLeft
				MoveSelectItem(PrintTo, False)
			Case MoveLeftAll
				MoveSelectItem(PrintTo, True)
			Case MoveUp
				MovePosition(MoveUp, TabSelect)
			Case MoveDown
				MovePosition(MoveDown, TabSelect)
		End Select
		
	End Sub
	
	Private Sub cmdSort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSort.Click
		Dim Index As Short = cmdSort.GetIndex(eventSender)
		
		Select Case Index
			Case MoveRight
				MoveSortItem(PrintFrom, False)
			Case MoveRightAll
				MoveSortItem(PrintFrom, True)
			Case MoveLeft
				MoveSortItem(PrintTo, False)
			Case MoveLeftAll
				MoveSortItem(PrintTo, True)
			Case MoveUp
				MovePosition(MoveUp, TabSort)
			Case MoveDown
				MovePosition(MoveDown, TabSort)
		End Select
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmPrint.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmPrint_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Select Case wsAction
			Case cmdStart
				'Initialize Form Position
				Me.Height = VB6.TwipsToPixelsY(SummaryHeight)
				Me.Width = VB6.TwipsToPixelsX(FormWidth)
				Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - DetailHeight) / 2)
				Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
				
		End Select
		
		Me.Refresh()
		System.Windows.Forms.Application.DoEvents()
		If wiStartFlg = True Then
			wiStartFlg = False
			
			Ini_Caption()
			
			Ini_Scr()
			
			wdbCon = New ADODB.Connection
			
			With wdbCon
				.Provider = "SQLOLEDB"
				.ConnectionTimeout = 10
				.CursorLocation = ADODB.CursorLocationEnum.adUseClient
				.ConnectionString = gsConnectString
				.Open()
			End With
			
		End If
		
		Select Case wsAction
			Case cmdStart
				If RunStoredProcedure = False Then
					Me.Cursor = System.Windows.Forms.Cursors.Default
					Me.Close()
					Exit Sub
				End If
				'Case cmdFail
				'   Unload Me
		End Select
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub frmPrint_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F2
				
				If tbrProcess.Items.Item(tcPreview).Enabled = True Then
					If gsRTAccess = "Y" Then
						Access_RunTimePrint(cmdPreview)
					Else
						Access_Print(cmdPreview)
					End If
				End If
				
				
			Case System.Windows.Forms.Keys.F3
				If tbrProcess.Items.Item(tcPrint).Enabled = True Then
					Access_Print(cmdPrinter)
					If gsRTAccess = "Y" Then
						Access_RunTimePrint(cmdPrinter)
					Else
						Access_Print(cmdPrinter)
					End If
				End If
				
				
			Case System.Windows.Forms.Keys.F5
				If tbrProcess.Items.Item(tcExcel).Enabled = True Then
					PrintExcel()
				End If
				
				
			Case System.Windows.Forms.Keys.F6
				If tbrProcess.Items.Item(tcBrowse).Enabled = True Then
					PrintListView()
				End If
				
			Case System.Windows.Forms.Keys.F9
				If tbrProcess.Items.Item(tcPrinter).Enabled = True Then
					PrinterSetup()
				End If
				
				
			Case System.Windows.Forms.Keys.F10
				
				PrintDetailForm()
				
			Case System.Windows.Forms.Keys.F12
				FormExit()
				
		End Select
		
		
        KeyCode = 0 ' System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	Private Sub frmPrint_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.Visible = False
		Me.KeyPreview = True
		
		wiStartFlg = True
		wsAction = cmdStart
		'Set wdbCon = gdbStepPro
		'  optPrint(cmdPreview).Value = True
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub frmPrint_LostFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.LostFocus
		
		'Unload Me
		
	End Sub
	
	Private Sub frmPrint_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		' SaveUserDefault
		
		wdbCon.Close()
		'UPGRADE_NOTE: Object wdbCon may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wdbCon = Nothing
		
		cnCon.Execute("DELETE FROM RPT" & Me.TableID & " WHERE RPTUSRID = '" & Set_Quote(gsUserID) & "' AND RPTDTETIM = '" & Change_SQLDate(Me.RptDteTim) & "' ")
		'gdbSTEPPro.Close
		'Set gdbSTEPPro = Nothing
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object frmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Function RunStoredProcedure() As Boolean
		
		RunStoredProcedure = False
		wsAction = cmdProcess
		
		If Trim(Me.StoreP) = "" Then
			wsMsg = "No Store Procedure !Please Check!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		Timer1.Enabled = True
		wdbCon.Execute(Me.StoreP,  , ADODB.ExecuteOptionEnum.adAsyncExecute)
		
		RunStoredProcedure = True
		
	End Function
	
	Private Sub lstSelect_BeforeLabelEdit(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.LabelEditEventArgs) Handles lstSelect.BeforeLabelEdit
		Dim Cancel As Boolean = eventArgs.CancelEdit
		Dim Index As Short = lstSelect.GetIndex(eventSender)
		
        'Cancel = True

    End Sub

    Private Sub lstSelect_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstSelect.DoubleClick
        Dim Index As Short = lstSelect.GetIndex(eventSender)

        MoveSelectItem(Index, False)

    End Sub

    Private Sub lstSelect_ItemCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ItemCheckEventArgs) Handles lstSelect.ItemCheck
        Dim Index As Short = lstSelect.GetIndex(eventSender)
        Dim Item As System.Windows.Forms.ListViewItem = lstSelect.Item(Index).Items(eventArgs.Index)

        'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        If Item.SubItems.Item(ItemNumFlag).Text <> "N" Then
            Item.Checked = False
        End If

    End Sub

    Private Sub lstSort_BeforeLabelEdit(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.LabelEditEventArgs) Handles lstSort.BeforeLabelEdit
        Dim Cancel As Boolean = eventArgs.CancelEdit
        Dim Index As Short = lstSort.GetIndex(eventSender)

        'Cancel = True

    End Sub
	
	Private Sub lstSort_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstSort.DoubleClick
		Dim Index As Short = lstSort.GetIndex(eventSender)
		
		MoveSortItem(Index, False)
		
	End Sub
	
	Private Sub tabFieldSelect_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabFieldSelect.SelectedIndexChanged
		Static PreviousTab As Short = tabFieldSelect.SelectedIndex()
		
		Select Case tabFieldSelect.SelectedIndex
			Case TabSelect
				
			Case TabSort
				'UpdateListSort
				
		End Select
		
		PreviousTab = tabFieldSelect.SelectedIndex()
	End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		Select Case Button.Name
			Case tcPreview
				
				If gsRTAccess = "Y" Then
					Access_RunTimePrint(cmdPreview)
				Else
					Access_Print(cmdPreview)
				End If
			Case tcPrint
				If gsRTAccess = "Y" Then
					Access_RunTimePrint(cmdPrinter)
				Else
					Access_Print(cmdPrinter)
				End If
				
			Case tcExcel
				PrintExcel()
			Case tcBrowse
				PrintListView()
			Case tcPrinter
				PrinterSetup()
			Case tcDetail
				PrintDetailForm()
			Case tcExit
				FormExit()
		End Select
		
		
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
	
	
	Private Sub txtTopN_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTopN.Enter
		
		FocusMe(txtTopN)
		
	End Sub
	
	Private Sub txtTopN_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTopN.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtTopN.Text), False, False)
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub wdbCon_ExecuteComplete(ByVal RecordsAffected As Integer, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection) Handles wdbCon.ExecuteComplete
		
		On Error GoTo ExecuteComplete_Err
		
		Dim adReport As New ADODB.Recordset
		
		wsQuery = " SELECT * FROM RPT" & Me.TableID
		wsQuery = wsQuery & " WHERE RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsQuery = wsQuery & "   AND RPTDTETIM = '" & Change_SQLDate(Me.RptDteTim) & "' "
		
		adReport.Open(wsQuery, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adReport.RecordCount = 0 Then
			'If RecordsAffected = 0 Then
			Timer1.Enabled = False
			UpdateStatus(picStatus, 0)
			wsAction = cmdFail
			MsgBox("No Report Data!Check the Date Range!")
			Exit Sub
			'Unload Me
		Else
			wiNoOfRecords = adReport.RecordCount
			lblNoOfRecords.Text = lblNoOfRecords.Text & wiNoOfRecords
			If To_Value((txtTopN.Text)) = 0 Then
				txtTopN.Text = CStr(adReport.RecordCount)
			Else
				If To_Value((txtTopN.Text)) > adReport.RecordCount Then
					txtTopN.Text = CStr(adReport.RecordCount)
				End If
			End If
		End If
		
		'UpdateStatus picStatus, 0
		Call SetButtonStatus("All")
		'  Enable_PrintOption True
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(wsRptPath & gsDBName) = "" Then
			Call SetButtonStatus("NoPrint")
		Else
			Call SetButtonStatus("Print")
		End If
		
		LoadListView()
		
		Timer1.Enabled = False
		Dim counter As Short
		counter = wiStatus
		For wiStatus = counter To 99
			wiStatus = wiStatus + 1
			UpdateStatus(picStatus, wiStatus)
		Next 
		UpdateStatus(picStatus, 100, True)
		adReport.Close()
		'UPGRADE_NOTE: Object adReport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adReport = Nothing
		
		Exit Sub
		
ExecuteComplete_Err: 
		MsgBox("ExecuteComplete Module Error! " & Err.Number & ", " & Err.Description)
		Timer1.Enabled = False
		UpdateStatus(picStatus, 0)
		On Error Resume Next
		'adReport.Close
		'UPGRADE_NOTE: Object wdbCon may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wdbCon = Nothing
		'UPGRADE_NOTE: Object adReport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adReport = Nothing
		
		
	End Sub
	
	Private Sub Ini_Scr()
		Dim Printer As New Printer
		
		Dim wiStrPos As Short
		Dim wiSemiPos As Short
		
		Me.Visible = True
		
		' cmdSelect(MoveUp).Picture = LoadResPicture("UP-ARROW", vbResBitmap)
		'  cmdSelect(MoveDown).Picture = LoadResPicture("DOWN-ARROW", vbResBitmap)
		'  cmdSort(MoveUp).Picture = LoadResPicture("UP-ARROW", vbResBitmap)
		'  cmdSort(MoveDown).Picture = LoadResPicture("DOWN-ARROW", vbResBitmap)
		
		ToolTip1.SetToolTip(lstSelect(PrintTo), "Select Desc")
		ToolTip1.SetToolTip(lstSort(PrintTo), "Sort Desc")
		
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
		
		'Initialize Form Position
		'Me.Height = SummaryHeight
		'Me.Width = FormWidth
		'Me.Top = (Screen.Height - DetailHeight) / 2
		'Me.Left = (Screen.Width - Me.Width) / 2
		
		'Initialize enable of button and option box
		Call SetButtonStatus("None")
		'  Enable_PrintOption False
		
		tabFieldSelect.SelectedIndex = TabSelect
		
		'Initialize Printer dialog box
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With cdPrinter
        '	'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdPrinter.flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '	.Flags = &H100000 Or &H4 Or &H80 Or &H100
        '	'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdPrinter.PrinterDefault was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '	.PrinterDefault = True
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	.CancelError = True
        '	wiNoOfCopy = 1
        '	wiNoOfCopy = Printer.Copies
        'End With
		
		'With cdFont
		'   .flags = cdlCFBoth Or cdlCFANSIOnly
		'   .CancelError = True
		'End With
		
		Ini_ListView()
		
		' Create new database in Microsoft Access window.
		If InStr(gsExcPath, ":\") Or InStr(gsExcPath, "\\") Then
			wsExcPath = gsExcPath
		Else
			wsExcPath = My.Application.Info.DirectoryPath & "\" & gsExcPath
		End If
		
		
		If InStr(gsRptPath, ":\") Or InStr(gsRptPath, "\\") Then
			wsRptPath = gsRptPath
		Else
			wsRptPath = My.Application.Info.DirectoryPath & "\" & gsRptPath
		End If
		
		
		lblDspSavePath.Text = wsExcPath & Me.TableID & "_" & VB6.Format(Now, "YYYYMMDDHHMM") & ".XLS"
		
		
		
		txtTopN.Text = CStr(0)
		
	End Sub
	
	Private Sub PrintExcel()
		Dim xlMaximized As Object
		Dim xlInsideVertical As Object
		Dim xlEdgeRight As Object
		Dim xlEdgeBottom As Object
		Dim xlEdgeTop As Object
		Dim xlEdgeLeft As Object
		Dim xlThin As Object
		Dim xlBottom As Object
		Dim xlLeft As Object
		Dim xlRight As Object
		Dim xlTop As Object
		Dim xlMedium As Object
		
		Dim xlApp As Object
		Dim xlSheet1 As Object
		Dim adDetail As New ADODB.Recordset
		Dim adSummary As New ADODB.Recordset
		
		Dim wsSQL As String 'SQL statement
		Dim NoOfFields As Short 'Number of fields
		Dim NoOfSum As Short 'Number of summary fields
		Dim wsFields As String 'Select field string
		Dim wsOrder As String 'Order by field string
		Dim wsSum As String 'Sum up field string
		Dim wsGroup As String 'Grouping field string
		Dim wiCtr As Short
		Dim NoOfRecord As Integer 'Number of Record
		Dim RowPack As Short 'Number of rows copy from array to excel -> depends on no. of col
		Dim wsText As String
		Dim wsMid As String
		Dim wiStatus As Double
		Dim xlData As Object
		Dim tmpData As Object
		Dim StartRow As Integer
		Dim ArrayRow As Integer
		Dim CurRow As Integer
		Dim CurCol As Short
		Dim inpParent As Object
		Dim inpDate As String
		Dim i As Integer
		Dim J As Integer
		
		On Error GoTo Excel_Print_Err1
		
		'if no field is selected then exit
		If lstSelect(PrintTo).Items.Count = 0 Then Exit Sub
		
		UpdateStatus(picStatus, 5)
		
		'CONSTRUCT THE SELECT FIELDS STRING AND SUMMARY STRING
		wsFields = ""
		wsSum = ""
		NoOfSum = 0
		With lstSelect(PrintTo)
			NoOfFields = .Items.Count
			For wiCtr = 1 To NoOfFields
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsFields = wsFields & .Items.Item(wiCtr).SubItems.Item(ItemField).Text & ", "
				'NoOfFields = NoOfFields + 1
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(wiCtr).Checked = True Then
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If UCase(.Items.Item(wiCtr).SubItems.Item(ItemNumFlag).Text) = "N" Then
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						wsSum = wsSum & "SUM(" & .Items.Item(wiCtr).SubItems.Item(ItemField).Text & "), "
						'"COUNT(DISTINCT " & .ListItems(wiCtr).ListSubItems(ItemField).Text & "), ")
						NoOfSum = NoOfSum + 1
					End If
				End If
			Next 
		End With
		wsFields = Mid(wsFields, 1, Len(Trim(wsFields)) - 1)
		If Len(Trim(wsSum)) > 0 Then
			wsSum = Mid(wsSum, 1, Len(Trim(wsSum)) - 1)
		End If
		
		'CONSTRUCT THE SORTING STRING AND GROUPING STRING
		wsOrder = ""
		wsGroup = ""
		With lstSort(PrintTo)
			For wiCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsOrder = wsOrder & .Items.Item(wiCtr).SubItems.Item(ItemField).Text & ", "
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(wiCtr).Checked = True Then
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					wsGroup = wsGroup & .Items.Item(wiCtr).SubItems.Item(ItemField).Text & ", "
					NoOfSum = NoOfSum + 1
				End If
			Next 
		End With
		If Len(Trim(wsOrder)) > 0 Then
			wsOrder = Mid(wsOrder, 1, Len(Trim(wsOrder)) - 1)
			If Len(Trim(wsGroup)) > 0 Then
				wsGroup = Mid(wsGroup, 1, Len(Trim(wsGroup)) - 1)
			End If
		End If
		
		'Construct the detail select statement
		If To_Value((txtTopN.Text)) <> wiNoOfRecords Then
			wsSQL = " SELECT TOP " & To_Value((txtTopN.Text)) & " WITH TIES "
			wsSQL = wsSQL & wsFields & " FROM RPT" & Me.TableID
		Else
			wsSQL = " SELECT " & wsFields & " FROM RPT" & Me.TableID
		End If
		wsSQL = wsSQL & " WHERE RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsSQL = wsSQL & "   AND RPTDTETIM = '" & Change_SQLDate(Me.RptDteTim) & "' "
		If Trim(wsOrder) <> "" Then
			wsSQL = wsSQL & " ORDER BY " & wsOrder
		End If
		
		adDetail.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		UpdateStatus(picStatus, 10)
		
		'Construct the summary select statement
		If Trim(wsGroup) <> "" And Trim(wsSum) <> "" And To_Value((txtTopN.Text)) = wiNoOfRecords Then
			wsSQL = " SELECT " & wsGroup & ", " & wsSum & " FROM RPT" & Me.TableID
			wsSQL = wsSQL & " WHERE RPTUSRID = '" & Set_Quote(gsUserID) & "' "
			wsSQL = wsSQL & "   AND RPTDTETIM = '" & Change_SQLDate(Me.RptDteTim) & "' "
			wsSQL = wsSQL & " GROUP BY " & wsGroup & " WITH CUBE "
			wsSQL = wsSQL & " ORDER BY " & wsGroup
			
			adSummary.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		End If
		
		UpdateStatus(picStatus, 20)
		
		If adDetail.RecordCount > 0 Then
			NoOfRecord = adDetail.RecordCount
		Else
			Exit Sub
		End If
		
		On Error GoTo Excel_Print_Err2
		
		xlApp = CreateObject("EXCEL.Application")
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Visible = False
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.SheetsInNewWorkbook. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.SheetsInNewWorkbook = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Workbooks.Add()
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlSheet1 = xlApp.Workbooks(1).Worksheets(1)
		
		If Init_Excel(xlSheet1, xlApp) = False Then GoTo Excel_Print_Err1
		
		UpdateStatus(picStatus, 30)
		
		'POPULATE EXCEL WORKSHEET HEADER
		With xlSheet1
			For wiCtr = 1 To NoOfFields
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				.Cells(1, wiCtr).Value = lstSelect(PrintTo).Items.Item(wiCtr).Text
			Next 
		End With
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		With xlSheet1.Range(xlSheet1.Cells(1, 1).Address, xlSheet1.Cells(1, NoOfFields).Address)
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Interior.ColorIndex = 15
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.WrapText = True
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlTop).Weight = xlMedium
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlRight).Weight = xlMedium
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlLeft).Weight = xlMedium
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlBottom).Weight = xlMedium
			'.AutoFit
		End With
		
		UpdateStatus(picStatus, 35)
		
		' INSERT DETAILS
		CurRow = 2
		StartRow = 2
		ArrayRow = 0
		wiStatus = 0
		RowPack = 100
		If NoOfFields > 20 Then
			RowPack = 50
		End If
		ReDim xlData(NoOfFields, 0)
		
		Do Until adDetail.EOF
			
			wiStatus = wiStatus + ((1 / NoOfRecord) * 40)
			ArrayRow = ArrayRow + 1
			ReDim Preserve xlData(NoOfFields, ArrayRow - 1)
			
			For CurCol = 1 To NoOfFields
				
				Select Case adDetail.Fields(CurCol - 1).Type
					Case ADODB.DataTypeEnum.adDate, ADODB.DataTypeEnum.adDBDate, ADODB.DataTypeEnum.adDBTime, ADODB.DataTypeEnum.adDBTimeStamp
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = Dsp_Date(ReadRs(adDetail, CurCol - 1),  , True)
						
					Case ADODB.DataTypeEnum.adBinary, ADODB.DataTypeEnum.adCurrency, ADODB.DataTypeEnum.adDecimal, ADODB.DataTypeEnum.adDouble, ADODB.DataTypeEnum.adInteger, ADODB.DataTypeEnum.adNumeric, ADODB.DataTypeEnum.adSingle, ADODB.DataTypeEnum.adSmallInt, ADODB.DataTypeEnum.adTinyInt
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = To_Value(ReadRs(adDetail, CurCol - 1))
						
					Case ADODB.DataTypeEnum.adLongVarBinary, ADODB.DataTypeEnum.adLongVarChar, ADODB.DataTypeEnum.adLongVarWChar
						'UPGRADE_WARNING: Couldn't resolve default property of object adDetail().GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inpParent = Trim(adDetail.Fields(CurCol - 1).GetChunk(2048))
						'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inpParent = IIf(IsDbNull(inpParent) = True, "", inpParent)
						wsText = ""
						For wiCtr = 1 To Len(inpParent)
							'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							wsMid = Mid(inpParent, wiCtr, 1)
							If wsMid = Chr(13) Then
								wsText = wsText & " "
							Else
								wsText = wsText & wsMid
							End If
							'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							xlData(CurCol - 1, ArrayRow - 1) = wsText
						Next 
						
					Case Else 'string or unknown type
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = CStr("'" & "" & ReadRs(adDetail, CurCol - 1))
						
				End Select
			Next 
			
			If ArrayRow = RowPack Or CurRow = NoOfRecord + 1 Then '1 means the header row
				ReDim tmpData(UBound(xlData, 2), UBound(xlData, 1))
				For i = 0 To UBound(xlData, 1)
					For J = 0 To UBound(xlData, 2)
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object tmpData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						tmpData(J, i) = xlData(i, J)
					Next 
				Next 
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object tmpData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Range(xlSheet1.Cells(StartRow, 1).Address, xlSheet1.Cells(CurRow, NoOfFields).Address).Value = tmpData
				
				ArrayRow = 0
				StartRow = CurRow + 1
				Erase tmpData
				ReDim xlData(NoOfFields, 0)
			End If
			UpdateStatus(picStatus, CShort(wiStatus) + 35)
			adDetail.MoveNext()
			CurRow = CurRow + 1
		Loop 
		
		adDetail.Close()
		'UPGRADE_NOTE: Object adDetail may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adDetail = Nothing
		UpdateStatus(picStatus, 75)
		
		If Trim(wsGroup) = "" Or Trim(wsSum) = "" Or To_Value((txtTopN.Text)) <> wiNoOfRecords Then GoTo PrintExcel_Save
		
		'DISPLAY SUMMARY PART
		CurRow = CurRow + 4
		CurCol = 1
		With lstSort(PrintTo)
			For wiCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(wiCtr).Checked Then
					'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					xlSheet1.Cells(CurRow, CurCol).Value = .Items.Item(wiCtr).Text
					CurCol = CurCol + 1
				End If
			Next 
		End With
		
		With lstSelect(PrintTo)
			For wiCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(wiCtr).Checked Then
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If UCase(.Items.Item(wiCtr).SubItems.Item(ItemNumFlag).Text) = "N" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						xlSheet1.Cells(CurRow, CurCol).Value = .Items.Item(wiCtr).Text
						CurCol = CurCol + 1
					End If
				End If
			Next 
		End With
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		With xlSheet1.Range(xlSheet1.Cells(CurRow, 1).Address, xlSheet1.Cells(CurRow, NoOfSum).Address)
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Interior.ColorIndex = 48
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.WrapText = True
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlTop).Weight = xlMedium
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlRight).Weight = xlMedium
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlLeft).Weight = xlMedium
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMedium. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlBottom).Weight = xlMedium
			'.AutoFit
		End With
		
		UpdateStatus(picStatus, 80)
		
		' INSERT DETAILS
		CurRow = CurRow + 1
		StartRow = CurRow
		ArrayRow = 0
		wiStatus = 0
		RowPack = 100
		If NoOfSum > 20 Then
			RowPack = 50
		End If
		ReDim xlData(NoOfSum, 0)
		
		Do Until adSummary.EOF
			
			wiStatus = wiStatus + ((1 / adSummary.RecordCount) * 15)
			ArrayRow = ArrayRow + 1
			ReDim Preserve xlData(NoOfSum, ArrayRow - 1)
			
			For CurCol = 1 To NoOfSum
				
				Select Case adSummary.Fields(CurCol - 1).Type
					Case ADODB.DataTypeEnum.adDate, ADODB.DataTypeEnum.adDBDate, ADODB.DataTypeEnum.adDBTime, ADODB.DataTypeEnum.adDBTimeStamp
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = Dsp_Date(ReadRs(adSummary, CurCol - 1),  , True)
						
					Case ADODB.DataTypeEnum.adBinary, ADODB.DataTypeEnum.adCurrency, ADODB.DataTypeEnum.adDecimal, ADODB.DataTypeEnum.adDouble, ADODB.DataTypeEnum.adInteger, ADODB.DataTypeEnum.adNumeric, ADODB.DataTypeEnum.adSingle, ADODB.DataTypeEnum.adSmallInt, ADODB.DataTypeEnum.adTinyInt
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = To_Value(ReadRs(adSummary, CurCol - 1))
						
					Case ADODB.DataTypeEnum.adLongVarBinary, ADODB.DataTypeEnum.adLongVarChar, ADODB.DataTypeEnum.adLongVarWChar
						'UPGRADE_WARNING: Couldn't resolve default property of object adSummary().GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inpParent = Trim(adSummary.Fields(CurCol - 1).GetChunk(2048))
						wsText = ""
						For wiCtr = 1 To Len(inpParent)
							'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							wsMid = Mid(inpParent, wiCtr, 1)
							If wsMid = Chr(13) Then
								wsText = wsText & " "
							Else
								wsText = wsText & wsMid
							End If
						Next 
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = wsText
						
					Case Else 'string or unknown type
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlData(CurCol - 1, ArrayRow - 1) = CStr("'" & "" & ReadRs(adSummary, CurCol - 1))
						
				End Select
			Next 
			
			If ArrayRow = RowPack Or CurRow = NoOfRecord + 1 + adSummary.RecordCount + 5 Then '1 means the header row and 5 separate row between detail and summary
				ReDim tmpData(UBound(xlData, 2), UBound(xlData, 1))
				For i = 0 To UBound(xlData, 1)
					For J = 0 To UBound(xlData, 2)
						'UPGRADE_WARNING: Couldn't resolve default property of object xlData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object tmpData(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						tmpData(J, i) = xlData(i, J)
					Next 
				Next 
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object tmpData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Range(xlSheet1.Cells(StartRow, 1).Address, xlSheet1.Cells(CurRow, NoOfSum).Address).Value = tmpData
				
				ArrayRow = 0
				StartRow = CurRow + 1
				Erase tmpData
				ReDim xlData(NoOfSum, 0)
			End If
			UpdateStatus(picStatus, CShort(wiStatus) + 80)
			adSummary.MoveNext()
			CurRow = CurRow + 1
		Loop 
		
		adSummary.Close()
		'UPGRADE_NOTE: Object adSummary may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSummary = Nothing
		UpdateStatus(picStatus, 95)
		
PrintExcel_Save: 
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		With xlSheet1.Range(xlSheet1.Cells(1, 1).Address, xlSheet1.Cells(CurRow - 1, NoOfFields).Address)
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlThin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlEdgeLeft).Weight = xlThin
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlThin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlEdgeTop).Weight = xlThin
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlThin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlEdgeBottom).Weight = xlThin
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlThin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlEdgeRight).Weight = xlThin
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlThin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Borders(xlInsideVertical).Weight = xlThin
		End With
		
		If chkOnScreen.CheckState Then
			With xlApp
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Workbooks(1).Worksheets(1).Select()
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.ShowToolTips. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.ShowToolTips = False
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.LargeButtons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.LargeButtons = False
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.ColorButtons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.ColorButtons = True
				System.Windows.Forms.Application.DoEvents()
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Visible = True
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.WindowState. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object xlMaximized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.WindowState = xlMaximized
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				If Dir(lblDspSavePath.Text) <> "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Workbooks.Open(lblDspSavePath)
				End If
				UpdateStatus(picStatus, 100, True)
				'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				xlSheet1 = Nothing
				'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				xlApp = Nothing
			End With
		Else 'Output to file only / The default is no parameter
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xlApp.Workbooks(1).Worksheets(1).SaveAs(lblDspSavePath.Text)
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Quit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xlApp.Quit()
			'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			xlSheet1 = Nothing
			'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			xlApp = Nothing
			UpdateStatus(picStatus, 100, True)
			MsgBox(lblDspSavePath.Text & "")
		End If
		SaveUserDefault()
		UpdateStatus(picStatus, 0)
		
		Exit Sub
		
Excel_Print_Err1: 
		MsgBox("Excel_Print_Err1")
		On Error Resume Next
		UpdateStatus(picStatus, 0)
		'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet1 = Nothing
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		
		Exit Sub
		
Excel_Print_Err2: 
		MsgBox("Excel_Print_Err2")
		On Error Resume Next
		UpdateStatus(picStatus, 0)
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Workbooks("BOOK1").Saved = True
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Workbooks.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Quit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Quit()
		'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet1 = Nothing
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		
	End Sub
	
	Private Sub PrintListView()
		
		Dim wsSQL As String
		Dim wiCtr As Short
		Dim wsFields As String
		Dim wsOrder As String
        Dim wsList(lstSelect.Count, 2) As String
		Dim NewfrmPrintList As New frmPrintList
		
		On Error GoTo PrintListView_Err
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		With lstSelect(PrintTo)
            ReDim wsList(.Items.Count, 2)
			For wiCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsFields = wsFields & .Items.Item(wiCtr).SubItems.Item(ItemField).Text & ", "
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsList(wiCtr, 1) = .Items.Item(wiCtr).Text
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsList(wiCtr, 2) = .Items.Item(wiCtr).SubItems.Item(ItemNumFlag).Text
			Next 
		End With
		
		With lstSort(PrintTo)
			For wiCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsOrder = wsOrder & .Items.Item(wiCtr).SubItems.Item(ItemField).Text & ", "
			Next 
		End With
		wsFields = Mid(wsFields, 1, Len(Trim(wsFields)) - 1)
		If Trim(wsOrder) <> "" Then
			wsOrder = Mid(wsOrder, 1, Len(Trim(wsOrder)) - 1)
		End If
		
		If To_Value((txtTopN.Text)) <> wiNoOfRecords Then
			wsSQL = " SELECT TOP " & To_Value((txtTopN.Text)) & " WITH TIES "
			wsSQL = wsSQL & wsFields & " FROM RPT" & Me.TableID
		Else
			wsSQL = " SELECT " & wsFields & " FROM RPT" & Me.TableID
		End If
		wsSQL = wsSQL & " WHERE RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsSQL = wsSQL & "   AND RPTDTETIM = '" & Change_SQLDate(Me.RptDteTim) & "' "
		If Trim(wsOrder) <> "" Then
			wsSQL = wsSQL & " ORDER BY " & wsOrder
		End If
		
		wsAction = cmdListView
		NewfrmPrintList.Fields = VB6.CopyArray(wsList)
		NewfrmPrintList.NoOfCol = lstSelect(PrintTo).Items.Count
		NewfrmPrintList.RptTitle = Me.RptTitle
		NewfrmPrintList.Query = wsSQL
		NewfrmPrintList.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrintList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrintList = Nothing
		SaveUserDefault()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
PrintListView_Err: 
		Me.Cursor = System.Windows.Forms.Cursors.Default
		MsgBox("PrintListView Err")
		
		
	End Sub
	
	Private Sub LoadListView()
		
		Dim wsSQL As String
		Dim adLayout As New ADODB.Recordset
		
		On Error GoTo LoadListView_Err
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsSQL = " SELECT COUNT(*) FROM sysLAYOUT "
		wsSQL = wsSQL & " WHERE LAYUSRID = '" & Set_Quote(gsUserID) & "' "
		wsSQL = wsSQL & " AND LAYPGMID = '" & Set_Quote(Me.TableID) & "' "
		adLayout.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If To_Value((adLayout.Fields(0).Value)) > 0 Then
			adLayout.Close()
			'UPGRADE_NOTE: Object adLayout may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			adLayout = Nothing
			LoadUserDefault()
		Else
			adLayout.Close()
			'UPGRADE_NOTE: Object adLayout may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			adLayout = Nothing
			LoadSPC()
		End If
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Exit Sub
		
LoadListView_Err: 
		'DISPLAY ERROR FUNCTION
		MsgBox("LoadListView Error!")
		Me.Cursor = System.Windows.Forms.Cursors.Default
		On Error Resume Next
		adLayout.Close()
		'UPGRADE_NOTE: Object adLayout may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adLayout = Nothing
		
	End Sub
	
	
	Private Sub Ini_ListView()
		
		Dim wiCtr As Short
		Dim clmX As System.Windows.Forms.ColumnHeader
		'Dim wImg As ListImage
		
		' Get ListView Small icons
		'With ImageList.ListImages
		'   Set wImg = .Add(1, "CHECKED", LoadResPicture("CHECKED", vbResIcon))
		'   Set wImg = .Add(2, "UNCHECKED", LoadResPicture("UNCHECKED", vbResIcon))
		'End With
		
		On Error GoTo Ini_ListView_Err
		
		'Initialize select list
		For wiCtr = PrintFrom To PrintTo
			With lstSelect(wiCtr)
				clmX = .Columns.Add("", "Description", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Width) * 0.98)))
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
				
				clmX = .Columns.Add("Field", CInt(VB6.TwipsToPixelsX(0)), System.Windows.Forms.HorizontalAlignment.Center)
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
				
				clmX = .Columns.Add("Type", CInt(VB6.TwipsToPixelsX(0)), System.Windows.Forms.HorizontalAlignment.Center)
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
				
				'.Icons = ImageList
				'.SmallIcons = ImageList
				'UPGRADE_ISSUE: MSComctlLib.ListView method lstSelect.DragMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                '.DragMode = 0
				'UPGRADE_ISSUE: MSComctlLib.ListView property lstSelect.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
                '.Sorted = False
				'SHOW THE CHECK BOX for the To-listview
				If wiCtr = PrintTo Then
					.CheckBoxes = True
				End If
			End With
		Next 
		
		'Initialize sort list
		For wiCtr = PrintFrom To PrintTo
			With lstSort(wiCtr)
				clmX = .Columns.Add("", "Description", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Width) * 0.98)))
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
				
				clmX = .Columns.Add("Field", CInt(VB6.TwipsToPixelsX(0)), System.Windows.Forms.HorizontalAlignment.Center)
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
				
				'.SmallIcons = ImageList
				'.Icons = ImageList
				'UPGRADE_ISSUE: MSComctlLib.ListView method lstSort.DragMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                '.DragMode = 0
				'UPGRADE_ISSUE: MSComctlLib.ListView property lstSort.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
                '.Sorted = False
				'SHOW THE CHECK BOX for the To-listview
				If wiCtr = PrintTo Then
					.CheckBoxes = True
				End If
			End With
		Next 
		
		'UPGRADE_NOTE: Object clmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		clmX = Nothing
		'Set wImg = Nothing
		
		Exit Sub
		
Ini_ListView_Err: 
		MsgBox("Listview Error")
		
	End Sub
	
	
	Private Sub LoadSPC()
		
		Dim wsSQL As String
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim itmY As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim subY As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim adSPC As New ADODB.Recordset
		
		On Error GoTo LoadSPC_Err
		
		wsSQL = " SELECT ScrFldID, ScrFldName, "
		wsSQL = wsSQL & " CASE WHEN USERTYPE IN (5, 6, 7, 8, 10, 11, 21, 24) THEN 'N' "
		wsSQL = wsSQL & " WHEN USERTYPE IN (12, 22, 80) THEN 'D' "
		wsSQL = wsSQL & " WHEN USERTYPE IN (19) THEN 'T' "
		wsSQL = wsSQL & " ELSE 'C' END AS ScrFldType FROM sysScrCaption, SYSCOLUMNS "
		wsSQL = wsSQL & " WHERE ScrType = 'FIL' "
		wsSQL = wsSQL & " AND SYSCOLUMNS.ID = OBJECT_ID('RPT" & Me.TableID & "') "
		wsSQL = wsSQL & " AND SYSCOLUMNS.NAME = ScrFldID "
		wsSQL = wsSQL & " AND ScrPgmID = '" & Set_Quote(Me.TableID) & "' "
		wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
		wsSQL = wsSQL & " AND ISNULL(RTRIM(ScrFldID), '') <> '' "
		wsSQL = wsSQL & " ORDER BY ScrSeqNo "
		adSPC.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adSPC.RecordCount = 0 Then
			wsSQL = " SELECT SYSCOLUMNS.NAME AS ScrFldID, SYSCOLUMNS.NAME AS ScrFldName, "
			wsSQL = wsSQL & " CASE WHEN USERTYPE IN (5, 6, 7, 8, 10, 11, 21, 24) THEN 'N' "
			wsSQL = wsSQL & " WHEN USERTYPE IN (12, 22, 80) THEN 'D' "
			wsSQL = wsSQL & " WHEN USERTYPE IN (19) THEN 'T' "
			wsSQL = wsSQL & " ELSE 'C' END AS ScrFldType FROM SYSCOLUMNS "
			wsSQL = wsSQL & " WHERE SYSCOLUMNS.ID = OBJECT_ID('RPT" & Me.TableID & "') "
			wsSQL = wsSQL & " ORDER BY SYSCOLUMNS.NAME "
			adSPC.Close()
			adSPC.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If adSPC.RecordCount = 0 Then
				MsgBox("No " & "RPT" & Me.TableID & "in System")
				GoTo LoadSPC_Exit
			End If
		End If
		
		Do Until adSPC.EOF
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Trim(ReadRs(adSPC, "ScrFldName")) = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				itmX = lstSelect(PrintTo).Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				itmY = lstSort(PrintFrom).Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				itmX = lstSelect(PrintTo).Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				itmY = lstSort(PrintFrom).Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
			End If
			
			With itmX
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFldID")))
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subY = itmX.SubItems.Add(ItemNumFlag,  , Trim(ReadRs(adSPC, "ScrFldType")))
				'.SubItems(ItemField) = adSPC("SPCFLDID").Value
				'.SubItems(ItemNumFlag) = adSPC("SPCMNUSPA").Value
				'.SmallIcon = 2
				'.Icon = 2
			End With
			'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			subY = Nothing
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'subY = itmY.SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFLDID")))
			'itmY.SubItems(ItemField) = adSPC("SPCFLDID").Value
			
			adSPC.MoveNext()
		Loop 
		
		adSPC.Close()
		'UPGRADE_NOTE: Object adSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSPC = Nothing
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object itmY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmY = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subY = Nothing
		
		Exit Sub
		
LoadSPC_Err: 
		'DISPLAY ERROR FUNCTION
		MsgBox("LoadSPC Err!")
		
LoadSPC_Exit: 
		On Error Resume Next
		adSPC.Close()
		'UPGRADE_NOTE: Object adSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSPC = Nothing
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		
	End Sub
	
	Private Sub LoadUserDefault()
		
		'Load the user default (previous) fields selection for list and index
		
		Dim wsSQL As String
		Dim wsSql2 As String
		Dim wsSql3 As String
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim subY As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim adSPC As New ADODB.Recordset
		
		On Error GoTo LoadDefault_Err
		
		
		wsSQL = " SELECT ScrFldID, ScrFldName, "
		wsSQL = wsSQL & "CASE WHEN USERTYPE IN (5, 6, 7, 8, 10, 11, 21, 24) THEN 'N' "
		wsSQL = wsSQL & " WHEN USERTYPE IN (12, 22, 80) THEN 'D' "
		wsSQL = wsSQL & " WHEN USERTYPE IN (19) THEN 'T' "
		wsSQL = wsSQL & " ELSE 'C' END AS ScrFldType, "
		wsSql3 = wsSQL
		wsSQL = wsSQL & " LayTotal, LayGroup, LaySelect, LaySort, LayOnScreen "
		wsSQL = wsSQL & " FROM sysScrCaption, sysLayout, SYSCOLUMNS "
		wsSQL = wsSQL & " WHERE ScrType = 'FIL' "
		wsSQL = wsSQL & " AND SYSCOLUMNS.ID = OBJECT_ID('RPT" & Me.TableID & "') "
		wsSQL = wsSQL & " AND SYSCOLUMNS.NAME = ScrFLDID "
		wsSQL = wsSQL & " AND ScrPgmID = '" & Set_Quote(Me.TableID) & "' "
		wsSQL = wsSQL & " AND LayUsrID = '" & Set_Quote(gsUserID) & "' "
		wsSQL = wsSQL & " AND ScrPgmID = LayPgmID "
		wsSQL = wsSQL & " AND LayFldID = ScrFLDID "
		wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
		wsSQL = wsSQL & " AND ISNULL(RTRIM(ScrFLDID), '') <> '' "
		wsSql2 = wsSQL & " AND LaySelect <> 999 "
		wsSql2 = wsSql2 & " ORDER BY LaySort, LaySelect " 'USED FOR LSTSORT
		wsSQL = wsSQL & " ORDER BY LaySelect, ScrSeqNo " 'USED FOR LSTSELECT
		adSPC.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adSPC.RecordCount = 0 Then
			LoadSPC()
			GoTo LoadDefault_Exit
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		chkOnScreen.CheckState = ReadRs(adSPC, "LayOnScreen")
		'   wiIndex = 0
		Do Until adSPC.EOF
			'IF THE VALUE IS 999 THEN PUT INTO LISTVIEW FROM
			If To_Value(ReadRs(adSPC, "LaySelect")) = 999 Then
				With lstSelect(PrintFrom)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Trim(ReadRs(adSPC, "ScrFldName")) = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
					End If
					
					With itmX
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = .SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFldID")))
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subY = .SubItems.Add(ItemNumFlag,  , Trim(ReadRs(adSPC, "ScrFldType")))
						'.SubItems(ItemField) = adSPC("SPCFLDID").Value
						'.SubItems(ItemNumFlag) = adSPC("SPCMNUSPA").Value
					End With
					
				End With
			Else 'ELSE PUT INTO LISTVIEW TO
				With lstSelect(PrintTo)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Trim(ReadRs(adSPC, "ScrFldName")) = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
					End If
					
					With itmX
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If UCase(ReadRs(adSPC, "LayTotal")) = "Y" Then
							.Checked = True
						Else
							.Checked = False
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = .SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFldID")))
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subY = .SubItems.Add(ItemNumFlag,  , Trim(ReadRs(adSPC, "ScrFldType")))
						'.SubItems(ItemField) = adSPC("SPCFLDID").Value
						'.SubItems(ItemNumFlag) = adSPC("SPCMNUSPA").Value
					End With
				End With
			End If
			adSPC.MoveNext()
		Loop 
		adSPC.Close()
		'UPGRADE_NOTE: Object adSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSPC = Nothing
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subY = Nothing
		
		adSPC.Open(wsSql2, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adSPC.RecordCount = 0 Then
			GoTo LoadDefault_Exit
		End If
		
		'   wiIndex = 0
		Do Until adSPC.EOF
			'IF THE TO POSITION VALUE IS 999 THEN PUT INTO LISTVIEW FROM
			If To_Value(adSPC.Fields("LaySort")) = 999 Then
				With lstSort(PrintFrom)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Trim(ReadRs(adSPC, "ScrFldName")) = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
					End If
					
					With itmX
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = .SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFldID")))
						'.SubItems(ItemField) = adSPC("SPCFLDID").Value
					End With
					
				End With
			Else 'ELSE PUT INTO LISTVIEW TO
				With lstSort(PrintTo)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Trim(ReadRs(adSPC, "ScrFldName")) = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
					End If
					
					With itmX
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If UCase(ReadRs(adSPC, "LayGroup")) = "Y" Then
							.Checked = True
						Else
							.Checked = False
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = .SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFldID")))
						'.SubItems(ItemField) = adSPC("SPCFLDID").Value
					End With
				End With
			End If
			adSPC.MoveNext()
		Loop 
		adSPC.Close()
		'UPGRADE_NOTE: Object adSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSPC = Nothing
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subY = Nothing
		
		wsSql3 = wsSql3 & " ScrSeqNo FROM sysScrCaption, SYSCOLUMNS "
		wsSql3 = wsSql3 & " WHERE ScrType = 'FIL' "
		wsSql3 = wsSql3 & " AND SYSCOLUMNS.ID = OBJECT_ID('RPT" & Me.TableID & "') "
		wsSql3 = wsSql3 & " AND SYSCOLUMNS.NAME = ScrFLDID "
		wsSql3 = wsSql3 & " AND ScrPgmID = '" & Set_Quote(Me.TableID) & "' "
		wsSql3 = wsSql3 & " AND NOT EXISTS ( SELECT NULL FROM sysLAYOUT"
		wsSql3 = wsSql3 & " WHERE ScrPGMID = LAYPGMID "
		wsSql3 = wsSql3 & " AND ScrFLDID = LAYFLDID "
		wsSql3 = wsSql3 & " AND LAYUSRid = '" & Set_Quote(gsUserID) & "') "
		wsSql3 = wsSql3 & " ORDER BY Scrseqno "
		
		adSPC.Open(wsSql3, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adSPC.RecordCount = 0 Then GoTo LoadDefault_Exit
		
		Do Until adSPC.EOF
			With lstSelect(PrintFrom)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Trim(ReadRs(adSPC, "ScrFldName")) = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldID")))
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					itmX = .Items.Add(Trim(ReadRs(adSPC, "ScrFldName")))
				End If
				
				With itmX
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                    'subX = .SubItems.Add(ItemField,  , Trim(ReadRs(adSPC, "ScrFldID")))
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                    'subY = .SubItems.Add(ItemNumFlag,  , Trim(ReadRs(adSPC, "ScrFldType")))
					'.SubItems(ItemField) = adSPC("SPCFLDID").Value
				End With
			End With
			adSPC.MoveNext()
		Loop 
		adSPC.Close()
		'UPGRADE_NOTE: Object adSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSPC = Nothing
		
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		
		Exit Sub
		
LoadDefault_Err: 
		MsgBox("LoadDeafult Err!")
		
LoadDefault_Exit: 
		On Error Resume Next
		adSPC.Close()
		'UPGRADE_NOTE: Object adSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adSPC = Nothing
		
	End Sub
	
	
	Private Sub MoveSelectItem(ByVal Index As Short, ByVal wiAll As Boolean)
		
		Dim wiCtr As Short
		Dim wiFrom As Short
		Dim wiTo As Short
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim itmY As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim subY As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim wiCtr2 As Short
		Dim wiSelected As Short
		Dim wiDeleted As Short
		Dim wiIndex As Short
		Dim wsField As String
		
		On Error GoTo MoveSelectItem_Err
		
		If Index = PrintFrom Then
			wiFrom = PrintFrom
			wiTo = PrintTo
		Else
			wiTo = PrintFrom
			wiFrom = PrintTo
		End If
		
		wiSelected = False
		With lstSelect(wiFrom)
			For wiCtr = 1 To .Items.Count
				
				'Add the selected or all items to the another list view
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(wiCtr).Selected Or wiAll = True Then
					
					wiSelected = True
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					wsField = .Items.Item(wiCtr).Text
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					itmX = lstSelect(wiTo).Items.Add(.Items.Item(wiCtr).Text)
					
					With itmX
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = .SubItems.Add(ItemField,  , lstSelect(wiFrom).Items.Item(wiCtr).SubItems.Item(ItemField).Text)
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subY = .SubItems.Add(ItemNumFlag,  , lstSelect(wiFrom).Items.Item(wiCtr).SubItems.Item(ItemNumFlag).Text)
						'.SubItems(ItemField) = lstSelect(wiFrom).ListItems(wiCtr).SubItems(ItemField)
						'.SubItems(ItemNumFlag) = lstSelect(wiFrom).ListItems(wiCtr).SubItems(ItemNumFlag)
					End With
					'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					subX = Nothing
					'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					subY = Nothing
					
					'if the adding listview is PrintTo, add the item to the lstSort also.
					If wiTo = PrintTo Then
						'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						itmY = lstSort(PrintFrom).Items.Add(.Items.Item(wiCtr).Text)
						
						With itmY
							'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                            'subY = .SubItems.Add(ItemField,  , lstSelect(wiFrom).Items.Item(wiCtr).SubItems.Item(ItemField).Text)
							'.SubItems(ItemField) = lstSelect(wiFrom).ListItems(wiCtr).SubItems(ItemField)
						End With
						'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
						subY = Nothing
						'else remove the item
					Else
						' locate the lstsort index
						If wiAll = True Then
							lstSort(PrintFrom).Items.Clear()
							lstSort(PrintTo).Items.Clear()
						Else
							With lstSort(PrintFrom)
								wiDeleted = False
								For wiCtr2 = 1 To .Items.Count
									'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
									If .Items.Item(wiCtr2).Text = wsField Then
										wiDeleted = True
										.Items.RemoveAt(wiCtr2)
										Exit For
									End If
								Next 
							End With
							'if not found at from listview, find that item at to list view
							If wiDeleted = False Then
								With lstSort(PrintTo)
									For wiCtr2 = 1 To .Items.Count
										'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
										If .Items.Item(wiCtr2).Text = wsField Then
											.Items.RemoveAt(wiCtr2)
											Exit For
										End If
									Next 
								End With
							End If
						End If
					End If
					
				End If
			Next 
			'Remove selected or all items from the current list view
			If wiAll = True Then
				.Items.Clear()
			Else
				If wiSelected = False Then Exit Sub
				.Items.RemoveAt(.FocusedItem.Index)
			End If
			
		End With
		
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object itmY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmY = Nothing
		
		Exit Sub
		
MoveSelectItem_Err: 
		MsgBox("Error in MoveSelectItem!")
		
	End Sub
	
	Private Sub MoveSortItem(ByVal Index As Short, ByVal wiAll As Boolean)
		
		Dim wiCtr As Short
		Dim wiFrom As Short
		Dim wiTo As Short
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim itmY As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim wiCtr2 As Short
		Dim wiSelected As Short
		Dim wiDeleted As Short
		Dim wiIndex As Short
		Dim wsField As String
		
		On Error GoTo MoveSortItem_Err
		
		If Index = PrintFrom Then
			wiFrom = PrintFrom
			wiTo = PrintTo
		Else
			wiTo = PrintFrom
			wiFrom = PrintTo
		End If
		
		wiSelected = False
		With lstSort(wiFrom)
			For wiCtr = 1 To .Items.Count
				
				'Add the selected or all items to the another list view
				'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(wiCtr).Selected Or wiAll = True Then
					
					wiSelected = True
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					wsField = .Items.Item(wiCtr).Text
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					itmX = lstSort(wiTo).Items.Add(.Items.Item(wiCtr).Text)
					
					With itmX
						'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = .SubItems.Add(ItemField,  , lstSort(wiFrom).Items.Item(wiCtr).SubItems.Item(ItemField).Text)
						'.SubItems(ItemField) = lstSort(wiFrom).ListItems(wiCtr).SubItems(ItemField)
					End With
					
				End If
			Next 
			'Remove selected or all items from the current list view
			If wiAll = True Then
				.Items.Clear()
			Else
				If wiSelected = False Then Exit Sub
				.Items.RemoveAt(.FocusedItem.Index)
			End If
			
		End With
		
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object itmY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmY = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		
		Exit Sub
		
MoveSortItem_Err: 
		MsgBox("Error in MOveSortItem!")
		
	End Sub
	
	Private Sub MovePosition(ByVal inDirection As Short, ByVal inListView As Short)
		
		Dim woList As System.Windows.Forms.ListView
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim subY As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim wiCtr As Short
		Dim Index As Short
		Dim wsDesc As String
		Dim wsField As String
		Dim wsNumFlag As String
		Dim wiChecked As Short
		
		On Error GoTo MovePosition_Err
		
		If inListView = TabSelect Then
			woList = lstSelect(PrintTo)
		Else
			woList = lstSort(PrintTo)
		End If
		
		With woList
			'locate the 1st item's position, if no selected item found then exit
			Index = .FocusedItem.Index
			If Index < 1 Or Index > .Items.Count Then GoTo MovePosition_Exit
			
			'if the index = top of the list and move up and vice versa => exit
			If (Index = 1 And inDirection = MoveUp) Or (Index = .Items.Count And inDirection = MoveDown) Then
				GoTo MovePosition_Exit
			End If
			
			'Move the position
			'UPGRADE_WARNING: Lower bound of collection woList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			wsDesc = .Items.Item(Index).Text
			'UPGRADE_WARNING: Lower bound of collection woList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			'UPGRADE_WARNING: Lower bound of collection woList.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			wsField = .Items.Item(Index).SubItems.Item(ItemField).Text
			If inListView = TabSelect Then
				'UPGRADE_WARNING: Lower bound of collection woList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection woList.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				wsNumFlag = .Items.Item(Index).SubItems.Item(ItemNumFlag).Text
			End If
			'UPGRADE_WARNING: Lower bound of collection woList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			wiChecked = .Items.Item(Index).Checked
			.Items.RemoveAt(Index)
			If inDirection = MoveUp Then
				Index = Index - 1
			Else
				Index = Index + 1
			End If
			'UPGRADE_WARNING: Lower bound of collection woList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			itmX = .Items.Insert(Index, wsDesc)
			
			With itmX
				.Checked = wiChecked
				'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = .SubItems.Add(ItemField,  , wsField)
				If inListView = TabSelect Then
					'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                    'subY = .SubItems.Add(ItemNumFlag,  , wsNumFlag)
				End If
				'.Icon = 1
				'.SmallIcon = 1
			End With
			
			'UPGRADE_WARNING: Lower bound of collection woList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			.Items.Item(Index).Selected = True
			.Focus()
			
		End With
		
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subY = Nothing
		'UPGRADE_NOTE: Object woList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		woList = Nothing
		Exit Sub
		
MovePosition_Err: 
		MsgBox("Error in MovePosition!")
MovePosition_Exit: 
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		'UPGRADE_NOTE: Object subY may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subY = Nothing
		'UPGRADE_NOTE: Object woList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		woList = Nothing
		Exit Sub
		
	End Sub
	
	Private Sub SaveUserDefault()
		
		Dim wsSQL As String
		Dim Index As Short
		Dim wiCtr As Short
		Dim wiCtr2 As Short
		Dim wiIdxPst As Short
		Dim wsLupDte As String
		Dim cmdSPC As New ADODB.Command
		Dim adSPC As New ADODB.Recordset
		
		On Error GoTo SaveUserDefault_Err
		
		cmdSPC.ActiveConnection = cnCon
		cmdSPC.CommandText = "USP_SysLayout"
		cmdSPC.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		cmdSPC.Parameters.Refresh()
		
		'  wsLupDte = Change_SQLDate(Me.RptDteTim)
		wsLupDte = Change_SQLDate(CStr(Now))
		
		Index = 1
		With lstSelect(PrintFrom)
			For wiCtr = 1 To .Items.Count
				wsLupDte = wsLupDte
				SetSPPara(cmdSPC, 1, Index)
				SetSPPara(cmdSPC, 2, gsUserID)
				SetSPPara(cmdSPC, 3, wsLupDte)
				SetSPPara(cmdSPC, 4, Me.TableID)
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				SetSPPara(cmdSPC, 5, .Items.Item(wiCtr).SubItems.Item(ItemField).Text)
				SetSPPara(cmdSPC, 6, 999)
				SetSPPara(cmdSPC, 7, 999)
				SetSPPara(cmdSPC, 8, "N")
				SetSPPara(cmdSPC, 9, "N")
				SetSPPara(cmdSPC, 10, chkOnScreen.CheckState)
				'SetSPPara cmdSPC, 11, "RPT" & Me.TableID
				cmdSPC.Execute()
				Index = Index + 1
			Next 
		End With
		
		With lstSelect(PrintTo)
			For wiCtr = 1 To .Items.Count
				SetSPPara(cmdSPC, 1, Index)
				SetSPPara(cmdSPC, 2, gsUserID)
				SetSPPara(cmdSPC, 3, wsLupDte)
				SetSPPara(cmdSPC, 4, Me.TableID)
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				SetSPPara(cmdSPC, 5, .Items.Item(wiCtr).SubItems.Item(ItemField).Text)
				SetSPPara(cmdSPC, 6, wiCtr)
				'find the field position in lstSort(to)
				wiIdxPst = 999
				For wiCtr2 = 1 To lstSort(PrintTo).Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If lstSort(PrintTo).Items.Item(wiCtr2).SubItems.Item(ItemField).Text = .Items.Item(wiCtr).SubItems.Item(ItemField).Text Then
						wiIdxPst = wiCtr2
						Exit For
					End If
				Next 
				SetSPPara(cmdSPC, 7, wiIdxPst)
				'UPGRADE_WARNING: Lower bound of collection lstSelect().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				SetSPPara(cmdSPC, 8, IIf(.Items.Item(wiCtr).Checked, "Y", "N"))
				If wiIdxPst = 999 Then
					SetSPPara(cmdSPC, 9, "N")
				Else
					'UPGRADE_WARNING: Lower bound of collection lstSort().ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					SetSPPara(cmdSPC, 9, IIf(lstSort(PrintTo).Items.Item(wiIdxPst).Checked, "Y", "N"))
				End If
				SetSPPara(cmdSPC, 10, chkOnScreen.CheckState)
				'SetSPPara cmdSPC, 11, "RPT" & Me.TableID
				cmdSPC.Execute()
				Index = Index + 1
			Next 
		End With
		
		Exit Sub
		
SaveUserDefault_Err: 
		MsgBox("Error in SaveUserDefault!")
		MsgBox(Err.Description)
	End Sub
	
	Private Function Init_Excel(ByRef woExcelSheet1 As Object, ByRef xlApp2 As Object) As Short
		Dim xlThin As Object
		Dim xlLandscape As Object
		
		Dim xlSheet2 As Object
		
		' Variables used to format the selection criteria
		' within the MS Excel Header and Footer
		Dim wsLeftHdr As String
		Dim wsCenterHdr As String
		Dim wsRightHdr As String
		Dim wsLeftFtr As String
		Dim wsRightFtr As String
		Dim wsTxt As String
		Dim wsLeftTxt As String
		Dim wsMid As String
		Dim wiLenHdr As Short
		Dim wiLenFtr As Short
		Dim wiFor As Short
		Dim wiCtr As Short
		Dim wiOldCtr As Short
		Dim wbOk As Boolean
		Dim wbDot As Boolean
		Dim wbTxtEmpty As Boolean
		' End of variables
		
		Init_Excel = False
		
		'GET THE REQUIRED DATA FROM RPTHDR
		On Error GoTo Excel_Err
		'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		woExcelSheet1.PageSetup.PrintTitleRows = woExcelSheet1.Rows(1).Address
		
		' ************************** WORKSHEET (DATA) ************************** '
		'PAGE SETUP
		'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		With woExcelSheet1.PageSetup
			'CREATE FOOTER
			wsLeftFtr = "&""Times New Roman""&6"
			wsRightFtr = "&""Times New Roman""&8Page &P of &N"
			wiLenFtr = Len(wsLeftFtr) + Len(wsRightFtr)
			
			'CREATE HEADER
			wsRightHdr = "&""Times New Roman""&8USER: " & gsUserID & vbLf & "   DATE: " & Change_SQLDate(Me.RptDteTim)
			wsCenterHdr = "&""Times New Roman,Bold""&10" & Me.RptTitle
			wsLeftHdr = "&""Times New Roman""&8" & gsComNam & "&6" & vbLf & vbLf
			wiLenHdr = Len(wsRightHdr) + Len(wsCenterHdr) + Len(wsLeftHdr)
			
			'wbDot = False
			'wbTxtEmpty = True
			'wiCtr = 0
			'wiOldCtr = 0
			'wsLeftTxt = ""
			'wsTxt = Trim(lblSel01.Tag)
			'If wsTxt <> "" Then
			'   For wiFor = 1 To Len(wsTxt)
			'      wsMid = Mid(wsTxt, wiFor, 1)
			'      wbOk = False
			'
			'      ' Check linefeed
			'      If wsMid <> vbLf Then
			'         wsLeftTxt = wsLeftTxt & wsMid
			'         wiCtr = wiCtr + 1
			'      Else
			'         If Trim(wsLeftTxt) <> "" Then
			'            wbTxtEmpty = False
			'            ' Concatenate to Left Header
			'            If wiLenHdr + wiCtr <= 240 Then
			'               wsLeftHdr = wsLeftHdr & wsLeftTxt & Space(5)
			'               wiOldCtr = wiCtr + 5
			'               wbOk = True
			'            Else
			'               ' Concatenate to Left Footer
			'               If wiLenFtr + (wiCtr - wiOldCtr) <= 230 Then
			'                  wsLeftFtr = wsLeftFtr & wsLeftTxt & Space(5)
			'                  wbOk = True
			'               Else
			'                  wbDot = True
			'                  Exit For
			'               End If
			'            End If
			'
			'            ' New Selection Criteria
			'            If wbOk Then
			'               wiCtr = wiCtr + 5
			'               wsLeftTxt = ""
			'            End If
			'         Else
			'            wiCtr = wiCtr - Len(wsLeftTxt)
			'         End If
			'      End If
			'   Next wiFor
			'End If
			
			'SET HEADER
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.LeftHeader = wsLeftHdr
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterHeader = wsCenterHdr
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.RightHeader = wsRightHdr
			
			'SET FOOTER
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.LeftFooter = wsLeftFtr & IIf(wbDot = True, New String(".", 10), "")
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterFooter = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.RightFooter = wsRightFtr
			
			'SET ALIGNMENT
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterHorizontally = True
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterVertically = False
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TopMargin = xlApp2.InchesToPoints(0.78)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.BottomMargin = xlApp2.InchesToPoints(0.35)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.LeftMargin = xlApp2.InchesToPoints(0.2)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.RightMargin = xlApp2.InchesToPoints(0.2)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.HeaderMargin = xlApp2.InchesToPoints(0.2)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.FooterMargin = xlApp2.InchesToPoints(0.2)
			
			'SET PAGE ORIENTATION
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlLandscape. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Orientation = xlLandscape
			
		End With
		
		''GENERAL CELL/S SETUP
		'With woExcelSheet1
		'   .Cells.Select
		'   .Cells.Font.FontStyle = "Regular"
		'   .Cells.Font.Name = "Times New Roman"
		'   .Cells.Font.Size = 8
		'   .Cells.Borders.Weight = xlThin
		'   .Range("A1").Select
		'End With
		
		' ******************* WORKSHEET (SELECTION CRITERIA) ******************* '
		
		'If Not wbTxtEmpty Then
		If UBound(Me.Selection) > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			With xlApp2.Workbooks(1)
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Worksheets.Add.Move(AFTER:=.Worksheets(.Worksheets.Count))
				'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet2 = .Worksheets(.Worksheets.Count)
			End With
			
			'PAGE SETUP
			'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			With xlSheet2.PageSetup
				'SET HEADER
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.LeftHeader = "&""Times New Roman""&8" & gsComNam
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CenterHeader = woExcelSheet1.PageSetup.CenterHeader & vbLf & vbLf
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CenterHeader = .CenterHeader & "&""Times New Roman,Bold""&9" & "SELECTION CRITERIA"
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.RightHeader = woExcelSheet1.PageSetup.RightHeader
				
				'SET FOOTER
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.LeftFooter = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CenterFooter = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.RightFooter = "&""Times New Roman""&8Page &P of &N"
				
				'SET ALIGNMENT
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CenterHorizontally = woExcelSheet1.PageSetup.CenterHorizontally
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CenterVertically = woExcelSheet1.PageSetup.CenterVertically
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.TopMargin = woExcelSheet1.PageSetup.TopMargin
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.BottomMargin = woExcelSheet1.PageSetup.BottomMargin
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.LeftMargin = woExcelSheet1.PageSetup.LeftMargin
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.RightMargin = woExcelSheet1.PageSetup.RightMargin
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.HeaderMargin = woExcelSheet1.PageSetup.HeaderMargin
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.FooterMargin = woExcelSheet1.PageSetup.FooterMargin
				
				'SET PAGE ORIENTATION
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Orientation = woExcelSheet1.PageSetup.Orientation
			End With
			
			'wiCtr = 0
			'wsLeftTxt = ""
			'      wsTxt = Trim(lblSel01.Tag)
			For wiCtr = 1 To UBound(Me.Selection)
				'         wsMid = Mid(wsTxt, wiFor, 1)
				
				' Check linefeed
				'If wsMid <> vbLf Then
				'   wsLeftTxt = wsLeftTxt & wsMid
				'Else
				'   If Trim(wsLeftTxt) <> "" Then
				'      wiCtr = wiCtr + 1
				With xlSheet2
					'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Me.Selection(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Cells(wiCtr, 1).Value = Me.Selection(wiCtr)
					'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					.Cells(wiCtr, 1).EntireColumn.AutoFit()
				End With
				'      wsLeftTxt = ""
				'   End If
				'End If
			Next 
			
			If To_Value((txtTopN.Text)) <> wiNoOfRecords Then
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet2.Cells(wiCtr + 1, 1).Value = "'" & lblTopN.Text & " " & To_Value((txtTopN.Text))
			End If
			
			'GENERAL CELL/S SETUP
			With xlSheet2
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Cells.Font.FontStyle = "Regular"
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Cells.Font.Name = "Times New Roman"
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Cells.Font.Size = 8
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object xlThin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Cells.Borders.Weight = xlThin
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet2.Protect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Protect()
			End With
		End If
		
		'UPGRADE_NOTE: Object xlSheet2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet2 = Nothing
		Init_Excel = True
		
		Exit Function
		
Excel_Err: 
		MsgBox("Exel_err")
		On Error Resume Next
		'UPGRADE_NOTE: Object xlSheet2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet2 = Nothing
		
	End Function
	
	Private Sub Ini_Caption()
		
		Call Get_Scr_Item("FRMPRINT", waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		'Me.Caption = Get_Caption(waScrItm, "SCRHDR") & " - " & Me.RptTitle
		
		'fmePrnOpt.Caption = Get_Caption(waScrItm, "PRINTOPT")
		'optPrint(cmdPreview).Caption = Get_Caption(waScrItm, "CMDPREVIEW")
		'optPrint(cmdPrinter).Caption = Get_Caption(waScrItm, "CMDPRINTER")
		'optPrint(cmdExcel).Caption = Get_Caption(waScrItm, "CMDEXCEL")
		'optPrint(cmdListView).Caption = Get_Caption(waScrItm, "CMDLISTVIEW")
		'cmdPrint(PrintOK).Caption = Get_Caption(waScrItm, "PRINTOK")
		'cmdPrint(PrintCancel).Caption = Get_Caption(waScrItm, "PRINTCANCEL")
		'cmdPrint(PrintSave).Caption = Get_Caption(waScrItm, "PRINTSAVE")
		'cmdPrint(PrintPrinter).Caption = Get_Caption(waScrItm, "PRINTPRINTER")
		'cmdPrint(PrintDetail).Caption = Get_Caption(waScrItm, "PRINTDETAIL")
		'lblSavePath.Caption = Get_Caption(waScrItm, "LBLSAVEPATH")
		'lblNoOfRecords.Caption = Get_Caption(waScrItm, "LBLNOOFRECORDS")
		'tabFieldSelect.TabCaption(TabSelect) = Get_Caption(waScrItm, "TABSELECT")
		'tabFieldSelect.TabCaption(TabSort) = Get_Caption(waScrItm, "TABSORT")
		'cmdSort(MoveRight).Caption = Get_Caption(waScrItm, "MOVERIGHT")
		'cmdSort(MoveRightAll).Caption = Get_Caption(waScrItm, "MOVERIGHTALL")
		'cmdSort(MoveLeft).Caption = Get_Caption(waScrItm, "MOVELEFT")
		'cmdSort(MoveLeftAll).Caption = Get_Caption(waScrItm, "MOVELEFTALL")
		'lblTopN.Caption = Get_Caption(waScrItm, "TOPN")
		'chkOnScreen.Caption = Get_Caption(waScrItm, "ONSCREEN")
		
		Me.Text = Get_Caption(waScrItm, "SCRHDR") & " - " & Me.RptTitle
		lblSavePath.Text = Get_Caption(waScrItm, "SAVEPATH")
		lblNoOfRecords.Text = Get_Caption(waScrItm, "NOOFRECORDS")
		tabFieldSelect.TabPages.Item(TabSelect).Text = Get_Caption(waScrItm, "TABSELECT")
		tabFieldSelect.TabPages.Item(TabSort).Text = Get_Caption(waScrItm, "TABSORT")
		cmdSort(MoveRight).Text = Get_Caption(waScrItm, "MOVERIGHT")
		cmdSort(MoveRightAll).Text = Get_Caption(waScrItm, "MOVERIGHTALL")
		cmdSort(MoveLeft).Text = Get_Caption(waScrItm, "MOVELEFT")
		cmdSort(MoveLeftAll).Text = Get_Caption(waScrItm, "MOVELEFTALL")
		cmdSort(MoveUp).Text = Get_Caption(waScrItm, "MOVEUP")
		cmdSort(MoveDown).Text = Get_Caption(waScrItm, "MOVEDOWN")
		cmdSelect(MoveUp).Text = Get_Caption(waScrItm, "SELECTMOVEUP")
		cmdSelect(MoveDown).Text = Get_Caption(waScrItm, "SELECTMOVEDOWN")
		lblTopN.Text = Get_Caption(waScrItm, "TOPN")
		chkOnScreen.Text = Get_Caption(waScrItm, "ONSCREEN")
		
		tbrProcess.Items.Item(tcPreview).ToolTipText = Get_Caption(waScrToolTip, tcPreview) & "(F2)"
		tbrProcess.Items.Item(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint) & "(F3)"
		tbrProcess.Items.Item(tcExcel).ToolTipText = Get_Caption(waScrToolTip, tcExcel) & "(F5)"
		tbrProcess.Items.Item(tcBrowse).ToolTipText = Get_Caption(waScrToolTip, tcBrowse) & "(F6)"
		tbrProcess.Items.Item(tcPrinter).ToolTipText = Get_Caption(waScrToolTip, tcPrinter) & "(F9)"
		tbrProcess.Items.Item(tcDetail).ToolTipText = Get_Caption(waScrToolTip, tcDetail) & "(F10)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
	End Sub
	
	
	
	Public Sub SetButtonStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "None"
				With tbrProcess
					.Items.Item(tcPreview).Enabled = False
					.Items.Item(tcPrint).Enabled = False
					.Items.Item(tcExcel).Enabled = False
					.Items.Item(tcBrowse).Enabled = False
					.Items.Item(tcPrinter).Enabled = False
				End With
				
			Case "All"
				With tbrProcess
					.Items.Item(tcPreview).Enabled = True
					.Items.Item(tcPrint).Enabled = True
					.Items.Item(tcExcel).Enabled = True
					.Items.Item(tcBrowse).Enabled = True
					.Items.Item(tcPrinter).Enabled = True
				End With
				
				
			Case "NoPrint"
				With tbrProcess
					.Items.Item(tcPreview).Enabled = False
					.Items.Item(tcPrint).Enabled = False
					.Items.Item(tcPrinter).Enabled = False
				End With
				
			Case "Print"
				With tbrProcess
					.Items.Item(tcPreview).Enabled = True
					.Items.Item(tcPrint).Enabled = True
					.Items.Item(tcPrinter).Enabled = True
				End With
				
		End Select
	End Sub
	
	Private Sub FormExit()
		If tbrProcess.Items.Item(tcPrint).Enabled = True Then
			Me.Close()
			Exit Sub
			'Me.Hide
		Else
			If wsAction = cmdFail Then
				Me.Close()
				Exit Sub
			Else
				wdbCon.Cancel()
				UpdateStatus(picStatus, 0)
				Me.Close()
				Exit Sub
			End If
			'Me.Hide
		End If
		
	End Sub
	
	
	Private Sub PrinterSetup()
		
		On Error GoTo PrintErr
		
        Dim dr As Integer = cdPrinterPrint.ShowDialog()
		
PrintErr: 
		Me.Cursor = System.Windows.Forms.Cursors.Default
		'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdPrinter.CancelError was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If dr = DialogResult.Cancel Then
            Exit Sub
        End If
		
	End Sub
	
	
	Private Sub PrintDetailForm()
		
		If Me.WindowState = 2 Then Exit Sub ' if maximize no need to change the screen size
		If VB6.PixelsToTwipsY(Me.Height) = SummaryHeight Then
			Me.Height = VB6.TwipsToPixelsY(DetailHeight)
		Else
			Me.Height = VB6.TwipsToPixelsY(SummaryHeight)
		End If
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
	
	
	Private Sub Access_Print(ByRef inMode As Short)
		Dim acNormal As Object
		Dim acPreview As Object
		'   Declare Database variable and Microsoft Access Form variable.
		Dim wsPara As String
		'   Dim appAccess As Access.Application
		Dim appAccess As Object
		Dim tmpString As String
		Dim accessHandle As Integer
		
		On Error GoTo Access_Print_Err
		
		UpdateStatus(picStatus, 10)
		
		'   Return instance of Application object.
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		UpdateStatus(picStatus, 20)
		Call Write_ErrLog_File("Set appAccess = CreateObject('Access.Application')")
		appAccess = CreateObject("Access.Application")
		
		
		
		UpdateStatus(picStatus, 30)
		Call Write_ErrLog_File("accessHandle = appAccess.hWndAccessApp")
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.hWndAccessApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		accessHandle = appAccess.hWndAccessApp
		
		
		UpdateStatus(picStatus, 40)
		
		'   appAccess.OpenCurrentDatabase (gsrptpath)
		Call Write_ErrLog_File("appAccess.OpenCurrentDatabase" & wsRptPath & gsDBName)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.OpenCurrentDatabase. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		appAccess.OpenCurrentDatabase(wsRptPath & gsDBName, False)
		
		
		
		UpdateStatus(picStatus, 50)
		
		wsQuery = "RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsQuery = wsQuery & "   AND RPTDTETIM = #" & Change_SQLDate(Me.RptDteTim) & "# "
		
		
		wsPara = "ODBC;DRIVER=SQL Server;SERVER=" & wsServer & ";UID=" & wsUser & ";PWD=" & wsPassword & ";DATABASE=" & wsDatabase & ";"
		
		UpdateStatus(picStatus, 60)
		
		'   Print report from Microsoft Access
		Call Write_ErrLog_File("appAccess.Run connect_report" & Trim(wsPara) & "," & Trim(Me.TableID))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Run. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		appAccess.Run("connect_report", Trim(wsPara), Trim(Me.TableID))
		
		
		
		
		Select Case inMode 'Select Print Mode
			Case 0 'Preview
				
				Call Write_ErrLog_File("appAccess.DoCmd.OpenReport " & Me.RptName & "," & wsQuery)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(Me.RptName, acPreview,  , wsQuery)
				UpdateStatus(picStatus, 70)
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.Maximize()
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
				
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.Visible = True
				
				'  Call ShowAccess(appAccess, SW_MAXIMIZE)
				
				Call SetWindowPos(accessHandle, HWND_TOPMOST, 0, 0, VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), SWP_SHOWWINDOW)
				
			Case 1 'Print only
				
				Call Write_ErrLog_File("appAccess.DoCmd.OpenReport " & Me.RptName & "," & wsQuery)
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(Me.RptName, acNormal,  , wsQuery)
				UpdateStatus(picStatus, 70)
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
		End Select
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		'This is here to stop the code so you can see the report...hit F5 to
		' continue
		'   Debug.Assert 1 = 3
		
		'   appAccess.Quit acExit
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		
		Exit Sub
		
Access_Print_Err: 
		
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		MsgBox("Error in Access Print! " & Err.Description)
		Call Write_ErrLog_File(Err.Description)
		
		Exit Sub
		
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
		Dim x As Integer
		
		On Error GoTo Access_RunTimePrint_Err
		
		UpdateStatus(picStatus, 10)
		
		' Return instance of Application object.
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		UpdateStatus(picStatus, 20)
		
		x = Shell(gsRTPath & "msaccess.exe " & Chr(34) & wsRptPath & gsDBName & Chr(34) & "/Runtime /Wrkgrp " & Chr(34) & gsRTPath & "system.mdw" & Chr(34), AppWinStyle.MaximizedFocus)
		
		UpdateStatus(picStatus, 30)
		Call Write_ErrLog_File("Set appAccess = GetObject(" & wsRptPath & gsDBName & ")")
		appAccess = GetObject(wsRptPath & gsDBName)
		UpdateStatus(picStatus, 40)
		
		
		Call Write_ErrLog_File("accessHandle = appAccess.hWndAccessApp")
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.hWndAccessApp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		accessHandle = appAccess.hWndAccessApp
		UpdateStatus(picStatus, 50)
		
		
		'appAccess.OpenCurrentDatabase wsRptPath & gsDBName, False
		'UpdateStatus picStatus, 50
		
		wsQuery = "RPTUSRID = '" & Set_Quote(gsUserID) & "' "
		wsQuery = wsQuery & "   AND RPTDTETIM = #" & Change_SQLDate(Me.RptDteTim) & "# "
		
		
		wsPara = "ODBC;DRIVER=SQL Server;SERVER=" & wsServer & ";UID=" & wsUser & ";PWD=" & wsPassword & ";DATABASE=" & wsDatabase & ";"
		
		UpdateStatus(picStatus, 60)
		
		' Print report from Microsoft Access
		Call Write_ErrLog_File("appAccess.Run connect_report" & Trim(wsPara) & "," & Trim(Me.TableID))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.Run. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		appAccess.Run("connect_report", Trim(wsPara), Trim(Me.TableID))
		
		
		
		Select Case inMode 'Select Print Mode
			Case 0 'Preview
				
				Call Write_ErrLog_File("appAccess.DoCmd.OpenReport " & Me.RptName & "," & wsQuery)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(Me.RptName, acPreview,  , wsQuery)
				UpdateStatus(picStatus, 70)
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.Maximize()
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
				
				'  appAccess.Visible = True
				Call SetWindowPos(accessHandle, HWND_TOPMOST, 0, 0, VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height), SWP_SHOWWINDOW)
				
			Case 1 'Print only
				
				
				Call Write_ErrLog_File("appAccess.DoCmd.OpenReport " & Me.RptName & "," & wsQuery)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object appAccess.DoCmd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				appAccess.DoCmd.OpenReport(Me.RptName, acNormal,  , wsQuery)
				UpdateStatus(picStatus, 70)
				UpdateStatus(picStatus, 80)
				UpdateStatus(picStatus, 90)
				UpdateStatus(picStatus, 100, True)
				
		End Select
		
		
		' Debug.Assert 1 = 3
		
		'appAccess.Quit acExit
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
Access_RunTimePrint_Err: 
		'UPGRADE_NOTE: Object appAccess may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		appAccess = Nothing
		
		Call Write_ErrLog_File(Err.Description)
		
		MsgBox("Error in Access Print! " & Err.Description)
		Exit Sub
		
	End Sub
End Class