Option Strict Off
Option Explicit On
Friend Class frmEXC002
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Dim wsTrnCd As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboExcYr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSql As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(2)
		wsSelection(1) = lblExcYr.Text & " " & Set_Quote(cboExcYr.Text)
		wsSelection(2) = lblExcCurr.Text & " " & Set_Quote(cboExcCurr.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTEXC002 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboExcYr.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboExcCurr.Text) & "', "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTEXC002"
		Else
			wsRptName = "RPTEXC002"
		End If
		
		NewfrmPrint.ReportID = "EXC002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "EXC002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmEXC002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmEXC002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "EXC002"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboExcYr.Text = ""
		cboExcCurr.Text = ""
		
		wgsTitle = "Exchange Rate List"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_cboExcYr = False Then
			cboExcYr.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmEXC002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmEXC002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmEXC002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmEXC002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick
		
		wcCombo.Text = tblCommon.Columns(0).Text
		tblCommon.Visible = False
		wcCombo.Focus()
		System.Windows.Forms.SendKeys.Send("{Enter}")
		
	End Sub
	
	Private Sub tblCommon_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCommon.KeyDownEvent
		
		If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
			tblCommon.Visible = False
			wcCombo.Focus()
		ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then 
            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
			wcCombo.Text = tblCommon.Columns(0).Text
			tblCommon.Visible = False
			wcCombo.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		
	End Sub
	
	Private Sub tblCommon_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.Leave
		
		
		On Error GoTo tblCommon_LostFocus_Err
		
		tblCommon.Visible = False
		If wcCombo.Enabled = True Then
			wcCombo.Focus()
		Else
			'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			wcCombo = Nothing
		End If
		
		Exit Sub
tblCommon_LostFocus_Err: 
		
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblTitle.Text = Get_Caption(waScrItm, "TITLE")
		txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
		lblExcYr.Text = Get_Caption(waScrItm, "EXCYR")
		lblExcCurr.Text = Get_Caption(waScrItm, "EXCCURR")
		
	End Sub
	
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
	
	Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
		FocusMe(txtTitle)
	End Sub
	
	Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtTitle, 60, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			cboExcYr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
	
	Private Sub cboExcYr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExcYr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboExcYr
		
		wsSql = "SELECT DISTINCT ExcYr FROM MstExchangeRate WHERE ExcStatus <> '2' "
		wsSql = wsSql & "ORDER BY ExcYr"
		Call Ini_Combo(1, wsSql, (VB6.PixelsToTwipsX(cboExcYr.Left)), VB6.PixelsToTwipsY(cboExcYr.Top) + VB6.PixelsToTwipsY(cboExcYr.Height), tblCommon, wsFormID, "TBLEXCYR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboExcYr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExcYr.Enter
		FocusMe(cboExcYr)
	End Sub
	
	Private Sub cboExcYr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboExcYr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, cboExcYr.Text, False, False)
		Call chk_InpLen(cboExcYr, 4, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			cboExcCurr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboExcYr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExcYr.Leave
		FocusMe(cboExcYr, True)
	End Sub
	
	Private Function Chk_cboExcYr() As Boolean
		Chk_cboExcYr = False
		
		If Len(Trim(cboExcYr.Text)) <> 4 Then
			gsMsg = "年份錯誤! 請輸入四位數字之年份!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboExcYr.Focus()
			Exit Function
		End If
		
		Chk_cboExcYr = True
	End Function
	
	Private Sub cboExcCurr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExcCurr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboExcCurr
		
		wsSql = "SELECT DISTINCT ExcCurr FROM MstExchangeRate WHERE ExcStatus <> '2' "
		wsSql = wsSql & "ORDER BY ExcCurr"
		
		Call Ini_Combo(1, wsSql, (VB6.PixelsToTwipsX(cboExcCurr.Left)), VB6.PixelsToTwipsY(cboExcCurr.Top) + VB6.PixelsToTwipsY(cboExcCurr.Height), tblCommon, wsFormID, "TBLCURR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboExcCurr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExcCurr.Enter
		FocusMe(cboExcCurr)
	End Sub
	
	Private Sub cboExcCurr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboExcCurr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboExcCurr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboExcCurr = True Then
				cboExcYr.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboExcCurr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboExcCurr.Leave
		FocusMe(cboExcCurr, True)
	End Sub
	
	Private Function Chk_cboExcCurr() As Boolean
		Dim wsStatus As String
		
		Chk_cboExcCurr = False
		
		If Len(Trim(cboExcCurr.Text)) = 0 And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入需要資料!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboExcCurr.Focus()
			Exit Function
		End If
		
		'If Chk_ExcCurr(cboExcYr, cboExcCurr, wsStatus) = False Then
		'    gsMsg = "貨幣不存在!"
		'    MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
		'    cboExcCurr.SetFocus
		'    Exit Function
		'Else
		'    If wsStatus = "2" Then
		'        gsMsg = "貨幣已存在但已無效!"
		'        MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
		'        cboExcCurr.SetFocus
		'        Exit Function
		'    Else
		'        gsMsg = "貨幣已存在!"
		'        MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
		'        cboExcCurr.SetFocus
		'        Exit Function
		'    End If
		'
		'    If wsStatus = "2" Then
		'        gsMsg = "貨幣已存在但已無效!"
		'        MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
		'        cboExcCurr.SetFocus
		'        Exit Function
		'    End If
		'End If
		
		Chk_cboExcCurr = True
	End Function
	
	Private Function Chk_ExcCurr(ByVal inCode As String, ByVal inCode1 As String, ByRef outCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSql As String
		
		Chk_ExcCurr = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSql = "SELECT ExcStatus "
		wsSql = wsSql & " FROM MstExchangeRate WHERE ExcYr = '" & Set_Quote(inCode) & "' AND ExcCurr = '" & Set_Quote(inCode1) & "'"
		
		rsRcd.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			outCode = ""
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "ExcStatus")
		
		Chk_ExcCurr = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
End Class