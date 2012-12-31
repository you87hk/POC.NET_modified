Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.Office.Interop

Friend Class frmGLP003
	Inherits System.Windows.Forms.Form
	
	
	Dim xlsApp As Object
	Dim xlsWrkBook As Object
	Dim xlsSheet As Object
	
	Dim waAccItm As New XArrayDBObject.XArrayDB
	
	Dim wsFormID As String
	Dim wcCombo As System.Windows.Forms.Control
	Private wsFormCaption As String
	Private wsExcelPath As String
	
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	
	Dim wsGenDte As String
	
	'Frame
	Private Const inPath As Short = 0
	Private Const OutPath As Short = 1
	'P/O Data Upload
	
	Private Const bsCol As Short = 0
	Private Const bsRow As Short = 1
	Private Const bsCell As Short = 2
	Private Const bsAccCode As Short = 3
	
	Private Const tcGo As String = "Go"
	Private Const tcExit As String = "Exit"
	Private Const tcCancel As String = "Cancel"
	
	
	Private Sub cmdCancel()
		Cursor = System.Windows.Forms.Cursors.Default
		Ini_Scr()
		txtFilePath(inPath).Focus()
	End Sub
	
	Private Sub cmdOK()
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		On Error GoTo cmdOK_Err
		
		If InputValidation = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		Init_Excel()
		System.Windows.Forms.Application.DoEvents()
		Call LoadExcelData()
		Call Update_Excel()
		
		If chkPrint.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.PrintOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xlsSheet.PrintOut()
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.ActiveWorkbook. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlsApp.ActiveWorkbook.SaveCopyAs(txtFilePath(OutPath))
		
		gsMsg = "Balance Sheet Has been produced!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		
		Call Quit_Excel()
		
		Call Ini_Scr()
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
cmdOK_Err: 
		
		gsMsg = "cmdOK Err!"
		MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Init_Excel()
		Dim xlMinimized As Object
		
		'UPGRADE_ISSUE: Range object was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        Dim Cell As Excel.Range
		
		xlsApp = CreateObject("Excel.Application")
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlsWrkBook = xlsApp.Workbooks
		
		With xlsApp
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Visible = True
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Caption = "Printing Financial Statements"
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.WindowState. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlMinimized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.WindowState = xlMinimized
		End With
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlsWrkBook.Open. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlsWrkBook.Open(Trim(txtFilePath(inPath).Text))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.Worksheets. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlsSheet = xlsApp.Worksheets("Template")
		
		
		
		waAccItm.ReDim(0, -1, bsCol, bsAccCode)
		
		
		
	End Sub
	
	Private Sub LoadExcelData()
		
		'UPGRADE_ISSUE: Range object was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        Dim Cell As Excel.Range
		Dim wsPrtRng As String
		Dim wsAccCode As String
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		
		With xlsSheet
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Select. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Select()
			
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsPrtRng = .PageSetup.PrintArea
			If wsPrtRng = "" Then
				gsMsg = "Print Area Not Set!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				Exit Sub
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For	Each Cell In .Range(wsPrtRng)
				'UPGRADE_WARNING: Couldn't resolve default property of object Cell.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If VB.Left(Trim(Trim(Cell.Text)), 1) = "_" Then
					
					'UPGRADE_WARNING: Couldn't resolve default property of object Cell.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Range. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wsAccCode = .Range("A" & Cell.Row).Text
					System.Windows.Forms.Application.DoEvents()
					
					waAccItm.AppendRows()
					'UPGRADE_WARNING: Couldn't resolve default property of object Cell.Column. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waAccItm.get_Value(waAccItm.get_UpperBound(1), bsCol) = Cell.Column
					'UPGRADE_WARNING: Couldn't resolve default property of object Cell.Row. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waAccItm.get_Value(waAccItm.get_UpperBound(1), bsRow) = Cell.Row
					'UPGRADE_WARNING: Couldn't resolve default property of object Cell.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waAccItm.get_Value(waAccItm.get_UpperBound(1), bsCell) = Mid(Trim(Cell.Text), 2)
					waAccItm.get_Value(waAccItm.get_UpperBound(1), bsAccCode) = wsAccCode
					
				End If
			Next Cell
		End With
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Update_Excel()
		
		Dim wsColNo As String
		Dim wsRowNo As String
		Dim wsParam As String
		Dim wsAccCode As String
		Dim wsTmpDte As String
		Dim wsTmpPrd As String
		Dim wsSQL As String
		Dim wsOutput As String
		
		'UPGRADE_ISSUE: Range object was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        Dim Cell As Excel.Range
		Dim wiCtr As Short
		Dim wsAcNam As String
		Dim wsComNam As String
		Dim wsCurrEarn As String
		Dim wsRetainAC As String
		Dim wsRetainCode As String
		
		Dim adcmdSave As New ADODB.Command
		
		
		
		On Error GoTo Update_Error
		
		
		
		If waAccItm.get_UpperBound(1) < 0 Then
			gsMsg = "No Item to Print!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtFilePath(inPath).Focus()
			Exit Sub
		End If
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsTmpDte = medPrdFr.Text & "/01"
		
		wsTmpPrd = Get_FiscalPeriod(wsTmpDte)
		wsCurrEarn = Get_CompanyFlag("CMPCURREARN")
		'   wsRetainAC = Get_CompanyFlag("CMPRETAINAC")
		'   wsRetainCode = Get_TableInfo("MSTCOA", "COAACCID = " & To_Value(wsRetainAC), "COAACCCODE")
		
		
		
		For wiCtr = 0 To waAccItm.get_UpperBound(1)
			wsColNo = waAccItm.get_Value(wiCtr, bsCol)
			wsRowNo = waAccItm.get_Value(wiCtr, bsRow)
			wsParam = waAccItm.get_Value(wiCtr, bsCell)
			wsAccCode = waAccItm.get_Value(wiCtr, bsAccCode)
			
			Select Case wsParam
				Case "COMP" ' Show Company Name
					If gsLangID = "1" Then
						wsComNam = Get_TableInfo("MstCompany", "CmpID = 1", "CmpEngName")
					Else
						wsComNam = Get_TableInfo("MstCompany", "CmpID = 1", "CmpChiName")
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = wsComNam
					
				Case "ACNO" ' Show Account No
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = "'" & wsAccCode
					
				Case "ACNAME" ' Show Account Name
					wsAcNam = Get_TableInfo("MstCOA", "COAAccCode = '" & Set_Quote(wsAccCode) & "'", IIf(gsLangID = "2", "COACDESC", "COADESC"))
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = "'" & wsAcNam
					
				Case "ASAT"
					
					wsTmpDte = VB.Left(wsTmpPrd, 4) & "/" & VB.Right(wsTmpPrd, 2) & "/01"
					wsTmpDte = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(wsTmpDte))))
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = wsTmpDte
					
				Case "STRDTE"
					
					wsTmpDte = VB.Left(wsTmpPrd, 4) & "/" & VB.Right(wsTmpPrd, 2) & "/01"
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = wsTmpDte
					
				Case "STRYR"
					
					wsTmpDte = VB.Left(wsTmpPrd, 4) & "/01/01"
					'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = wsTmpDte
					
				Case Else
					wsParam = UCase(wsParam)
					
					adcmdSave.ActiveConnection = cnCon
					
					If UCase(Trim(wsCurrEarn)) = UCase(Trim(wsAccCode)) Then
						
						adcmdSave.CommandText = "USP_RPTGLP003_CURREARN"
						adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
						adcmdSave.Parameters.Refresh()
						
						Call SetSPPara(adcmdSave, 1, VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2))
						Call SetSPPara(adcmdSave, 2, wsAccCode)
						Call SetSPPara(adcmdSave, 3, wsParam)
						adcmdSave.Execute()
						
						'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						wsOutput = GetSPPara(adcmdSave, 4)
						'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = wsOutput
						
					Else
						
						adcmdSave.CommandText = "USP_RPTGLP003"
						adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
						adcmdSave.Parameters.Refresh()
						
						Call SetSPPara(adcmdSave, 1, VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2))
						Call SetSPPara(adcmdSave, 2, wsAccCode)
						Call SetSPPara(adcmdSave, 3, wsParam)
						adcmdSave.Execute()
						
						'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						wsOutput = GetSPPara(adcmdSave, 4)
						'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						xlsSheet.Cells(Val(wsRowNo), Val(wsColNo)).Value = wsOutput
						
						If To_Value(wsOutput) = 0 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object xlsSheet.Rows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							xlsSheet.Rows(Val(wsRowNo)).RowHeight = 0
						End If
						
					End If
					
			End Select
		Next 
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
Update_Error: 
		
		MsgBox("Update_Error!")
		Cursor = System.Windows.Forms.Cursors.Default
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		Exit Sub
		
		
	End Sub
	
	
	Private Sub cmdFilePath_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFilePath.Click
		Dim Index As Short = cmdFilePath.GetIndex(eventSender)
		
		On Error Resume Next
		
		If Trim(txtFilePath(Index).Text) <> "" Then
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If Dir(txtFilePath(Index).Text) <> "" Then
				'Dialog.dirDirectory.Path = txtFilePath.Text
				cdFilePathOpen.InitialDirectory = wsExcelPath
			End If
		End If
		'Dialog.Show vbModal
		' If Trim(Dialog.Tag) <> "" Then
		'     txtFilePath.Text = Dialog.Tag
		'     If chk_txtFilePath = False Then
		'         txtFilePath.SetFocus
		'     End If
		' End If
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With cdFilePath
        '	.Title = "Open A Execl File"
        '	'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '	.Filter = "Excel File (*.XLS)|*.XLS"
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	.CancelError = True
        '	.FileName = vbNullString
        '	.ShowDialog()
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	If Err.Number <> DialogResult.Cancel Then
        '		txtFilePath(Index).Text = .FileName
        '	End If
        'End With
		
		On Error GoTo 0
		
		
	End Sub
	
	Private Sub frmGLP003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.F9
				Call cmdOK()
				
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
		End Select
	End Sub
	
	Private Sub frmGLP003_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	Private Sub Ini_Form()
		
		Me.KeyPreview = True
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "GLP003"
	End Sub
	
	Private Sub Ini_Scr()
		Dim wsCtlMth As String
		
		
		Me.Text = wsFormCaption
		
		
		If InStr(gsExcPath, ":\") Or InStr(gsExcPath, "\\") Then
			wsExcelPath = gsExcPath
		Else
			wsExcelPath = My.Application.Info.DirectoryPath & "\" & gsExcPath
		End If
		
		txtFilePath(inPath).Text = wsExcelPath & "BSTemplete.xls"
		
		txtFilePath(OutPath).Text = wsExcelPath & "BS_" & VB6.Format(Now, "YYYYMMDDHHMM") & ".xls"
		
		Call SetPeriodMask(medPrdFr)
		
		wsCtlMth = getCtrlMth("GL")
		
		medPrdFr.Text = VB.Left(wsCtlMth, 4) & "/" & VB.Right(wsCtlMth, 2)
		
		chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
		
		UpdStatusBar(picStatus, 0)
		lblStatus.Text = ""
		wsGenDte = ""
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event frmGLP003.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmGLP003_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(5085)
			Me.Width = VB6.TwipsToPixelsX(9390)
		End If
	End Sub
	
	Private Sub frmGLP003_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waAccItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waAccItm = Nothing
		'UPGRADE_NOTE: Object frmGLP003 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub Ini_Caption()
		
		Call Get_Scr_Item("GLP003", waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		fmeFilePath(inPath).Text = Get_Caption(waScrItm, "FMEINPATH")
		fmeFilePath(OutPath).Text = Get_Caption(waScrItm, "FMEOUTPATH")
		
		lblFilePath(inPath).Text = Get_Caption(waScrItm, "INPATH")
		lblFilePath(OutPath).Text = Get_Caption(waScrItm, "OUTPATH")
		
		lblStatus.Text = Get_Caption(waScrItm, "STATUS")
		chkPrint.Text = Get_Caption(waScrItm, "CHKPRINT")
		
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
	End Sub
	
	
	
	Private Sub medPrdFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Enter
		FocusMe(medPrdFr)
	End Sub
	
	
	Private Sub medPrdFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_medPrdFr = False Then
                GoTo EventExitSub
            End If

            txtFilePath(0).Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
        FocusMe(medPrdFr, True)
    End Sub

    Private Function chk_medPrdFr() As Boolean
        chk_medPrdFr = False


        If Chk_Period(medPrdFr) = False Then
            gsMsg = "Wrong Period!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function

        End If

        If chk_RetPrd(CDate(medPrdFr.Text)) = False Then
            gsMsg = "Period Must > Minimin Date!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function
        End If

        chk_medPrdFr = True
    End Function

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case tcGo
                Call cmdOK()

            Case tcCancel

                Call cmdCancel()

            Case tcExit

                Me.Close()

        End Select

    End Sub



    Private Sub txtFilePath_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFilePath.DoubleClick
        Dim Index As Short = txtFilePath.GetIndex(eventSender)

        Call LoadExcel(txtFilePath(Index).Text)

    End Sub



    Private Sub txtFilePath_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFilePath.Enter
        Dim Index As Short = txtFilePath.GetIndex(eventSender)

        FocusMe(txtFilePath(Index))

    End Sub



    Private Function chk_txtFilePath(ByRef inIndex As Short) As Boolean

        chk_txtFilePath = False

        Select Case inIndex
            Case inPath

                If Trim(txtFilePath(inIndex).Text) = "" Then
                    gsMsg = "請輸入路徑!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If

                'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                If Not Trim(UCase(txtFilePath(inIndex).Text)) Like "*" & UCase(Dir(txtFilePath(inIndex).Text)) & "*" Then
                    gsMsg = "找不到檔案!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If

                If UCase(VB.Right(txtFilePath(inIndex).Text, 4)) <> ".XLS" Then
                    gsMsg = "Input Must a Excel File!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If

            Case OutPath



                If Trim(txtFilePath(inIndex).Text) = "" Then
                    gsMsg = "請輸入路徑!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If

                'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                If Trim(UCase(txtFilePath(inIndex).Text)) Like "*" & UCase(Dir(txtFilePath(inIndex).Text)) & "*" And Dir(txtFilePath(inIndex).Text) <> "" Then
                    gsMsg = "檔案已存在!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If

                If Trim(txtFilePath(0).Text) = Trim(txtFilePath(1).Text) Then
                    gsMsg = "Output file must not the same as Input !"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If

                If UCase(VB.Right(txtFilePath(inIndex).Text, 4)) <> ".XLS" Then
                    gsMsg = "Output Must a Excel File!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    txtFilePath(inIndex).Focus()
                    Exit Function
                End If


        End Select

        chk_txtFilePath = True

    End Function

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_medPrdFr = False Then
            Exit Function
        End If


        If chk_txtFilePath(inPath) = False Then
            Exit Function
        End If

        If chk_txtFilePath(OutPath) = False Then
            Exit Function
        End If

        InputValidation = True

    End Function






    Private Sub txtFilePath_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFilePath.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtFilePath.GetIndex(eventSender)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_txtFilePath(Index) = False Then
                GoTo EventExitSub
            End If
            If Index = inPath Then
                txtFilePath(OutPath).Focus()
            Else
                txtFilePath(inPath).Focus()
            End If

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtFilePath_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFilePath.Leave
		Dim Index As Short = txtFilePath.GetIndex(eventSender)
		FocusMe(txtFilePath(Index), True)
	End Sub
	
	
	
	Private Function chk_RetPrd(ByRef inMedDte As Date) As Boolean
		Dim wsStrDte As String
		Dim wsEndDte As String
		Dim wsCtlDte As String
		Dim wiRetValue As Short
		Dim wdMinDte As Date
		chk_RetPrd = False
		
		wiRetValue = CShort(Get_TableInfo("sysMonCtl", "MCMODNO = 'GL'", "MCKeepMn"))
		
		wsCtlDte = getCtrlMth("GL", wsStrDte, wsEndDte)
		wdMinDte = DateAdd(Microsoft.VisualBasic.DateInterval.Month, To_Value(wiRetValue) * -1, CDate(wsStrDte))
		If CDate(inMedDte) < wdMinDte Then Exit Function
		
		chk_RetPrd = True
	End Function
	
	
	Private Sub Quit_Excel()
		
		On Error Resume Next
		
		With xlsApp
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.ActiveWorkbook. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.ActiveWorkbook.Saved = True
			'UPGRADE_WARNING: Couldn't resolve default property of object xlsApp.Quit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Quit()
		End With
		
		'UPGRADE_NOTE: Object xlsApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlsApp = Nothing
		'UPGRADE_NOTE: Object xlsWrkBook may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlsWrkBook = Nothing
		'UPGRADE_NOTE: Object xlsSheet may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlsSheet = Nothing
		
	End Sub
End Class