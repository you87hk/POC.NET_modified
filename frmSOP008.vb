Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSOP008
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboCusNoFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wsYYYY As String
		Dim wsMM As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsYYYY = VB.Left(medPrdFr.Text, 4)
		wsMM = VB.Right(medPrdFr.Text, 2)
		
		'Create Selection Criteria
		ReDim wsSelection(2)
		wsSelection(1) = lblCusNoFr.Text & " " & Set_Quote(cboCusNoFr.Text) & " " & lblCusNoTo.Text & " " & Set_Quote(cboCusNoTo.Text)
		wsSelection(1) = lblPrdFr.Text & " " & medPrdFr.Text
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTSOP008 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSQL = wsSQL & IIf(Trim(txtCreditLimitFr.Text) = "", 0, To_Value((txtCreditLimitFr.Text))) & ", "
		wsSQL = wsSQL & IIf(Trim(txtCreditLimitTo.Text) = "", 0, To_Value((txtCreditLimitTo.Text))) & ", "
		wsSQL = wsSQL & "'" & Set_Quote(wsYYYY) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(wsMM) & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSOP008"
		Else
			wsRptName = "RPTSOP008"
		End If
		
		NewfrmPrint.ReportID = "SOP008"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "SOP008"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmSOP008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmSOP008_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "SOP008"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboCusNoFr.Text = ""
		cboCusNoTo.Text = ""
		txtCreditLimitFr.Text = ""
		txtCreditLimitTo.Text = ""
		
		Call SetPeriodMask(medPrdFr)
		
		medPrdFr.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))
		
		'txtCreditLimitFr.Text = Format("0", "##0.00")
		'txtCreditLimitTo.Text = Format(gsMaxVal, "##0.00")
		
		
		
		wgsTitle = "Customer Credit Check List"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		InputValidation = False
		
		'If chk_cboMethodCodeTo = False Then
		'    cboMethodCodeTo.SetFocus
		'    Exit Function
		'End If
		If Not chk_txtCreditLimitTo Then Exit Function
		If Not chk_medPrdFr Then Exit Function
		
		InputValidation = True
	End Function
	
	'UPGRADE_WARNING: Event frmSOP008.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmSOP008_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmSOP008_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmSOP008 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
		
		lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		lblCreditLimitFr.Text = Get_Caption(waScrItm, "CREDITLIMITFR")
		lblCreditLimitTo.Text = Get_Caption(waScrItm, "CREDITLIMITTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		
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
	
	Private Sub txtCreditLimitFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCreditLimitFr.Enter
		FocusMe(txtCreditLimitFr)
	End Sub
	
	Private Sub txtCreditLimitFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditLimitFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtCreditLimitFr.Text, False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_txtCreditLimitFr() Then
				txtCreditLimitTo.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtCreditLimitFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCreditLimitFr.Leave
		FocusMe(txtCreditLimitFr, True)
	End Sub
	
	Private Sub txtCreditLimitTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCreditLimitTo.Enter
		FocusMe(txtCreditLimitTo)
	End Sub
	
	Private Sub txtCreditLimitTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditLimitTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtCreditLimitTo.Text, False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_txtCreditLimitTo() = True Then
				medPrdFr.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtCreditLimitTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCreditLimitTo.Leave
		FocusMe(txtCreditLimitTo, True)
	End Sub
	
	Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
		FocusMe(txtTitle)
	End Sub
	
	Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtTitle, 60, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			cboCusNoFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
	
	Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCusNoFr
		
		If gsLangID = "1" Then
			wsSQL = "SELECT CUSCODE, CUSNAME, CUSTEL, CUSFAX "
			wsSQL = wsSQL & " FROM MstCustomer "
			wsSQL = wsSQL & " WHERE CUSCODE LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
			wsSQL = wsSQL & " AND CUSSTATUS  <> '2' "
			wsSQL = wsSQL & " AND CusInactive = 'N' "
			wsSQL = wsSQL & " ORDER BY CUSCODE "
		Else
			wsSQL = "SELECT CUSCODE, CUSNAME, CUSTEL, CUSFAX "
			wsSQL = wsSQL & " FROM MstCustomer "
			wsSQL = wsSQL & " WHERE CUSCODE LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
			wsSQL = wsSQL & " AND CUSSTATUS  <> '2' "
			wsSQL = wsSQL & " AND CusInactive = 'N' "
			wsSQL = wsSQL & " ORDER BY CUSCODE "
		End If
		Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboCusNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.Enter
		FocusMe(cboCusNoFr)
		wcCombo = cboCusNoFr
	End Sub
	
	Private Sub cboCusNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusNoFr, 15, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboCusNoFr.Text) <> "" And Trim(cboCusNoTo.Text) = "" Then
				cboCusNoTo.Text = cboCusNoFr.Text
			End If
			
			cboCusNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboCusNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.Leave
		FocusMe(cboCusNoFr, True)
	End Sub
	
	Private Sub cboCusNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCusNoTo
		
		If gsLangID = "1" Then
			wsSQL = "SELECT CUSCODE, CUSNAME, CUSTEL, CUSFAX "
			wsSQL = wsSQL & " FROM MstCustomer "
			wsSQL = wsSQL & " WHERE CUSCODE LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
			wsSQL = wsSQL & " AND CUSSTATUS  <> '2' "
			wsSQL = wsSQL & " AND CusInactive = 'N' "
			wsSQL = wsSQL & " ORDER BY CUSCODE "
		Else
			wsSQL = "SELECT CUSCODE, CUSNAME, CUSTEL, CUSFAX "
			wsSQL = wsSQL & " FROM MstCustomer "
			wsSQL = wsSQL & " WHERE CUSCODE LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
			wsSQL = wsSQL & " AND CUSSTATUS  <> '2' "
			wsSQL = wsSQL & " AND CusInactive = 'N' "
			wsSQL = wsSQL & " ORDER BY CUSCODE "
		End If
		Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboCusNoTo.Left)), VB6.PixelsToTwipsY(cboCusNoTo.Top) + VB6.PixelsToTwipsY(cboCusNoTo.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboCusNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Enter
		FocusMe(cboCusNoTo)
		wcCombo = cboCusNoTo
	End Sub
	
	Private Sub cboCusNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusNoTo, 15, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboCusNoTo = False Then
				cboCusNoTo.Focus()
				GoTo EventExitSub
			End If
			
			txtCreditLimitFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboCusNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Leave
		FocusMe(cboCusNoTo, True)
	End Sub
	
	Private Function chk_cboCusNoTo() As Boolean
		chk_cboCusNoTo = False
		
		If UCase(cboCusNoFr.Text) > UCase(cboCusNoTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboCusNoTo = True
	End Function
	
	Private Function chk_txtCreditLimitFr() As Boolean
		chk_txtCreditLimitFr = False
		
		If Trim(txtCreditLimitFr.Text) = "" Then
			chk_txtCreditLimitFr = True
			Exit Function
		End If
		
		If Len(txtCreditLimitFr.Text) > 8 Then
			wsMsg = "Credit Limit too large!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtCreditLimitFr.Focus()
			Exit Function
		End If
		
		chk_txtCreditLimitFr = True
	End Function
	
	Private Function chk_txtCreditLimitTo() As Boolean
		chk_txtCreditLimitTo = False
		
		If Trim(txtCreditLimitTo.Text) = "" Then
			'  wsMsg = "Credit Limit must not be zero!"
			'  MsgBox wsMsg, vbOKOnly, gsTitle
			'  txtCreditLimitTo.SetFocus
			chk_txtCreditLimitTo = True
			Exit Function
		End If
		
		If Len(txtCreditLimitTo.Text) > 8 Then
			wsMsg = "Credit Limit too large!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtCreditLimitTo.Focus()
			Exit Function
		End If
		
		If To_Value((txtCreditLimitFr.Text)) > To_Value((txtCreditLimitTo.Text)) Then
			wsMsg = "From > To!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtCreditLimitTo.Focus()
			Exit Function
		End If
		
		chk_txtCreditLimitTo = True
	End Function
	
	Private Sub medPrdFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Enter
		FocusMe(medPrdFr)
	End Sub
	
	Private Sub medPrdFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_medPrdFr = False Then
				medPrdFr.Focus()
				GoTo EventExitSub
			End If
			
			cboCusNoFr.Focus()
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
		
		If Trim(medPrdFr.Text) = "/" Then
			gsMsg = "Must Input Period!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If Chk_Period(medPrdFr) = False Then
			gsMsg = "Wrong Period!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medPrdFr = True
	End Function
End Class