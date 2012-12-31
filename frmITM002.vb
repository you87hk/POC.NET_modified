Option Strict Off
Option Explicit On
Friend Class frmITM002
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
		cboDocNoFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(4)
		wsSelection(1) = lblDocNoFr.Text & " " & Set_Quote(cboDocNoFr.Text) & " " & lblDocNoTo.Text & " " & Set_Quote(cboDocNoTo.Text)
		wsSelection(2) = lblItmTypeFr.Text & " " & Set_Quote(cboItmTypeFr.Text) & " " & lblItmTypeTo.Text & " " & Set_Quote(cboItmTypeTo.Text)
		wsSelection(3) = lblItmClassFr.Text & " " & Set_Quote(cboItmClassFr.Text) & " " & lblItmClassTo.Text & " " & Set_Quote(cboItmClassTo.Text)
		wsSelection(4) = lblPrdFr.Text & " " & medPrdFr.Text & " " & lblPrdTo.Text & " " & medPrdTo.Text
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTITM002 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & wgsTitle & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 13), Set_Quote(cboDocNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmTypeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmTypeTo.Text) = "", New String("z", 10), Set_Quote(cboItmTypeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmClassFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmClassTo.Text) = "", New String("z", 10), Set_Quote(cboItmClassTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdFr.Text) = "/  /", "", medPrdFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdTo.Text) = "/  /", "99999999", medPrdTo.Text) & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTITM002"
		Else
			wsRptName = "RPTITM002"
		End If
		
		NewfrmPrint.ReportID = "ITM002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "ITM002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmClassFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmClassFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmClassFr
		
		wsSQL = "SELECT ItemClassCode, " & IIf(gsLangID = "1", "ItemClassEDesc", "ItemClassCDesc") & " FROM MstItemClass WHERE ItemClassCode LIKE '%" & IIf(cboItmClassFr.SelectionLength > 0, "", Set_Quote(cboItmClassFr.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY ItemClassCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeFr.Left)), VB6.PixelsToTwipsY(cboItmTypeFr.Top) + VB6.PixelsToTwipsY(cboItmTypeFr.Height), tblCommon, wsFormID, "TBLItmClass", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmClassFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmClassFr.Enter
		FocusMe(cboItmClassFr)
	End Sub
	
	Private Sub cboItmClassFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmClassFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmClassFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboItmClassFr.Text) <> "" And Trim(cboItmClassTo.Text) = "" Then
				cboItmClassTo.Text = cboItmClassFr.Text
			End If
			
			cboItmClassTo.Focus()
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmClassFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmClassFr.Leave
		FocusMe(cboItmClassFr, True)
	End Sub
	
	Private Sub cboItmClassTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmClassTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmClassTo
		
		wsSQL = "SELECT ItemClassCode, " & IIf(gsLangID = "1", "ItemClassEDesc", "ItemClassCDesc") & " FROM MstItemClass WHERE ItemClassCode LIKE '%" & IIf(cboItmClassTo.SelectionLength > 0, "", Set_Quote(cboItmClassTo.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY ItemClassCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmClassTo.Left)), VB6.PixelsToTwipsY(cboItmClassTo.Top) + VB6.PixelsToTwipsY(cboItmClassTo.Height), tblCommon, wsFormID, "TBLItmClass", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmClassTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmClassTo.Enter
		FocusMe(cboItmClassTo)
	End Sub
	
	Private Sub cboItmClassTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmClassTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmClassTo, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboItmClassTo = False Then
				cboItmClassTo.Focus()
				GoTo EventExitSub
			End If
			
			medPrdFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmClassTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmClassTo.Leave
		FocusMe(cboItmClassTo, True)
	End Sub
	
	Private Sub cboItmTypeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmTypeFr
		
		wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ItmTypeEngDesc", "ItmTypeChiDesc") & " FROM MstItemType WHERE ItmTypeCode LIKE '%" & IIf(cboItmTypeFr.SelectionLength > 0, "", Set_Quote(cboItmTypeFr.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY ItmTypeCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeFr.Left)), VB6.PixelsToTwipsY(cboItmTypeFr.Top) + VB6.PixelsToTwipsY(cboItmTypeFr.Height), tblCommon, wsFormID, "TBLITMTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmTypeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeFr.Enter
		FocusMe(cboItmTypeFr)
		wcCombo = cboItmTypeFr
	End Sub
	
	Private Sub cboItmTypeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmTypeFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboItmTypeFr.Text) <> "" And Trim(cboItmTypeTo.Text) = "" Then
				cboItmTypeTo.Text = cboItmTypeFr.Text
			End If
			cboItmTypeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub cboItmTypeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeFr.Leave
		FocusMe(cboItmTypeFr, True)
	End Sub
	
	Private Sub cboItmTypeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmTypeTo
		
		wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ItmTypeEngDesc", "ItmTypeChiDesc") & " FROM MstItemType WHERE ItmTypeCode LIKE '%" & IIf(cboItmTypeTo.SelectionLength > 0, "", Set_Quote(cboItmTypeTo.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY ItmTypeCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeTo.Left)), VB6.PixelsToTwipsY(cboItmTypeTo.Top) + VB6.PixelsToTwipsY(cboItmTypeTo.Height), tblCommon, wsFormID, "TBLITMTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmTypeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeTo.Enter
		FocusMe(cboItmTypeTo)
		wcCombo = cboItmTypeTo
	End Sub
	
	Private Sub cboItmTypeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmTypeTo, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboItmTypeTo = False Then
				cboItmTypeTo.Focus()
				GoTo EventExitSub
			End If
			
			cboItmClassFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub cboItmTypeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeTo.Leave
		FocusMe(cboItmTypeTo, True)
	End Sub
	
	Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
		FocusMe(cboDocNoTo, True)
	End Sub
	
	
	
	Private Sub frmITM002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmITM002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "ITM002"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboDocNoFr.Text = ""
		cboDocNoTo.Text = ""
		cboItmTypeFr.Text = ""
		cboItmTypeTo.Text = ""
		cboItmClassFr.Text = ""
		cboItmClassTo.Text = ""
		Call SetDateMask(medPrdFr)
		Call SetDateMask(medPrdTo)
		
		
		
	End Sub
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chk_cboDocNoTo = False Then
			cboDocNoTo.Focus()
			Exit Function
		End If
		
		If chk_cboItmTypeTo = False Then
			cboItmTypeTo.Focus()
			Exit Function
		End If
		
		If chk_medPrdTo = False Then
			medPrdTo.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	
	
	'UPGRADE_WARNING: Event frmITM002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmITM002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmITM002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmITM002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
		FocusMe(medPrdFr, True)
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
		
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
		lblItmTypeFr.Text = Get_Caption(waScrItm, "TYPEFR")
		lblItmTypeTo.Text = Get_Caption(waScrItm, "TYPETO")
		lblItmClassFr.Text = Get_Caption(waScrItm, "CLASSFR")
		lblItmClassTo.Text = Get_Caption(waScrItm, "CLASSTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		wgsTitle = Get_Caption(waScrItm, "RPTTITLE")
		
	End Sub
	
	Private Function chk_medPrdFr() As Boolean
		chk_medPrdFr = False
		
		If Trim(medPrdFr.Text) = "/  /" Then
			chk_medPrdFr = True
			Exit Function
		End If
		
		If Chk_Date(medPrdFr) = False Then
			wsMsg = "Wrong Date!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medPrdFr = True
	End Function
	
	Private Function chk_medPrdTo() As Boolean
		chk_medPrdTo = False
		
		If UCase(medPrdTo.Text) > UCase(medPrdTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If Trim(medPrdTo.Text) = "/  /" Then
			chk_medPrdTo = True
			Exit Function
		End If
		
		If Chk_Date(medPrdTo) = False Then
			
			wsMsg = "Wrong Date!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medPrdTo = True
	End Function
	
	Private Function chk_cboItmTypeTo() As Boolean
		chk_cboItmTypeTo = False
		
		If UCase(cboItmTypeFr.Text) > UCase(cboItmTypeTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboItmTypeTo = True
	End Function
	
	Private Function chk_cboDocNoTo() As Boolean
		chk_cboDocNoTo = False
		
		If UCase(cboDocNoFr.Text) > UCase(cboDocNoTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboDocNoTo = True
	End Function
	
	Private Function chk_cboItmClassTo() As Boolean
		chk_cboItmClassTo = False
		
		If UCase(cboItmClassFr.Text) > UCase(cboItmClassTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboItmClassTo = True
	End Function
	
	Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoFr
		
		wsSQL = "SELECT ITMCODE, ITMBARCODE,  " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", " & IIf(gsLangID = "1", "ItmTypeEngDesc", "ItmTypeChiDesc") & ", " & IIf(gsLangID = "1", "ItemClassEDesc", "ItemClassCDesc") & " "
		wsSQL = wsSQL & " FROM MstItem, MstItemType, MstItemClass "
		wsSQL = wsSQL & " WHERE ITMCODE LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND ItemClassCODE = ITMCLASS"
		wsSQL = wsSQL & " AND ITMITMTYPECODE = ITMTYPECODE "
		wsSQL = wsSQL & " AND ITMSTATUS  <> '2' "
		wsSQL = wsSQL & " ORDER BY ITMCODE "
		Call Ini_Combo(5, wsSQL, (VB6.PixelsToTwipsX(cboDocNoFr.Left)), VB6.PixelsToTwipsY(cboDocNoFr.Top) + VB6.PixelsToTwipsY(cboDocNoFr.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboDocNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Enter
		FocusMe(cboDocNoFr)
		wcCombo = cboDocNoFr
	End Sub
	
	Private Sub cboDocNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboDocNoFr, 13, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboDocNoFr.Text) <> "" And Trim(cboDocNoTo.Text) = "" Then
				cboDocNoTo.Text = cboDocNoFr.Text
			End If
			
			cboDocNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboDocNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Leave
		FocusMe(cboDocNoFr, True)
	End Sub
	
	Private Sub cboDocNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoTo
		
		wsSQL = "SELECT ITMCODE, ITMBARCODE,  " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", " & IIf(gsLangID = "1", "ItmTypeEngDesc", "ItmTypeChiDesc") & ", " & IIf(gsLangID = "1", "ItemClassEDesc", "ItemClassCDesc") & " "
		wsSQL = wsSQL & " FROM MstItem, MstItemType, MstItemClass "
		wsSQL = wsSQL & " WHERE ITMCODE LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
		wsSQL = wsSQL & " AND ItemClassCODE = ITMCLASS"
		wsSQL = wsSQL & " AND ITMITMTYPECODE = ITMTYPECODE "
		wsSQL = wsSQL & " AND ITMSTATUS  <> '2' "
		wsSQL = wsSQL & " ORDER BY ITMCODE "
		Call Ini_Combo(5, wsSQL, (VB6.PixelsToTwipsX(cboDocNoTo.Left)), VB6.PixelsToTwipsY(cboDocNoTo.Top) + VB6.PixelsToTwipsY(cboDocNoTo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboDocNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Enter
		FocusMe(cboDocNoTo)
		wcCombo = cboDocNoTo
	End Sub
	
	Private Sub cboDocNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboDocNoTo, 13, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboDocNoTo = False Then
				Call cboDocNoTo_Enter(cboDocNoTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			cboItmTypeFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub medPrdFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Enter
		FocusMe(medPrdFr)
	End Sub
	
	
	Private Sub medPrdFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_medPrdFr = False Then
				Call medPrdFr_Enter(medPrdFr, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			If Trim(medPrdFr.Text) <> "/" And Trim(medPrdTo.Text) = "/" Then
				medPrdTo.Text = medPrdFr.Text
			End If
			medPrdTo.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub medPrdTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_medPrdTo = False Then
				medPrdTo.Focus()
				GoTo EventExitSub
			End If
			
			cboDocNoFr.Focus()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub medPrdTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo.Enter
		FocusMe(medPrdTo)
	End Sub
	
	Private Sub medPrdTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo.Leave
		FocusMe(medPrdTo, True)
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
End Class