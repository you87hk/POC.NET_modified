Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmARL011
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
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
		ReDim wsSelection(5)
		wsSelection(1) = lblDocNoFr.Text & " " & Set_Quote(cboDocNoFr.Text) & " " & lblDocNoTo.Text & " " & Set_Quote(cboDocNoTo.Text)
		wsSelection(2) = lblCusNoFr.Text & " " & Set_Quote(cboCusNoFr.Text) & " " & lblCusNoTo.Text & " " & Set_Quote(cboCusNoTo.Text)
		wsSelection(3) = lblPrdFr.Text & " " & medPrdFr.Text & " " & lblPrdTo.Text & " " & medPrdTo.Text
		wsSelection(4) = lblUsrFr.Text & " " & Set_Quote(cboUsrFr.Text) & " " & lblUsrTo.Text & " " & Set_Quote(cboUsrTo.Text)
		wsSelection(5) = lblUpdFr.Text & " " & medUpdFr.Text & " " & lblUpdTo.Text & " " & medUpdTo.Text
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTARL011 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdFr.Text) = "/  /", "0000/00/00", medPrdFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdTo.Text) = "/  /", "9999/99/99", medPrdTo.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboUsrFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboUsrTo.Text) = "", New String("z", 10), Set_Quote(cboUsrTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medUpdFr.Text) = "/  /", "0000/00/00", medUpdFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medUpdTo.Text) = "/  /", "9999/99/99", medUpdTo.Text) & "', "
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTARL011"
		Else
			wsRptName = "RPTARL011"
		End If
		NewfrmPrint.ReportID = "ARL011"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "ARL011"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
        Dim wsSQL As String = ""
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case gsLangID
			Case "1"
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
			Case "2"
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSQL = wsSQL & " ORDER BY Cuscode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
		Call chk_InpLen(cboCusNoFr, 10, KeyAscii)
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
        Dim wsSQL As String = ""
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case gsLangID
			Case "1"
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
			Case "2"
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSQL = wsSQL & " ORDER BY Cuscode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoTo.Left)), VB6.PixelsToTwipsY(cboCusNoTo.Top) + VB6.PixelsToTwipsY(cboCusNoTo.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
		Call chk_InpLen(cboCusNoTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboCusNoTo = False Then
				Call cboCusNoTo_Enter(cboCusNoTo, New System.EventArgs())
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
	
	Private Sub cboCusNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Leave
		FocusMe(cboCusNoTo, True)
	End Sub
	
	Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
		FocusMe(cboDocNoTo, True)
	End Sub
	
	Private Sub chkSummary_KeyPress(ByRef KeyAscii As Short)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			cboDocNoFr.Focus()
		End If
	End Sub
	
	Private Sub cboUsrFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrFr.DropDown
        Dim wsSQL As String = ""
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboUsrFr
		
		Select Case gsLangID
			Case "1"
				wsSQL = "SELECT USRCODE, USRNAME FROM MstUser WHERE USRCODE LIKE '%" & IIf(cboUsrFr.SelectionLength > 0, "", Set_Quote(cboUsrFr.Text)) & "%' "
			Case "2"
				wsSQL = "SELECT USRCODE, USRNAME FROM MstUser WHERE USRCODE LIKE '%" & IIf(cboUsrFr.SelectionLength > 0, "", Set_Quote(cboUsrFr.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSQL = wsSQL & " ORDER BY USRCODE "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLUSR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboUsrFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrFr.Enter
		FocusMe(cboUsrFr)
	End Sub
	
	Private Sub cboUsrFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboUsrFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboUsrFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboUsrFr.Text) <> "" And Trim(cboUsrTo.Text) = "" Then
				cboUsrTo.Text = cboUsrFr.Text
			End If
			
			cboUsrTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboUsrFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrFr.Leave
		FocusMe(cboUsrFr, True)
	End Sub
	
	Private Sub cboUsrTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrTo.DropDown
        Dim wsSQL As String = ""
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboUsrTo
		
		Select Case gsLangID
			Case "1"
				wsSQL = "SELECT USRCODE, USRNAME FROM MstUser WHERE USRCODE LIKE '%" & IIf(cboUsrTo.SelectionLength > 0, "", Set_Quote(cboUsrTo.Text)) & "%' "
			Case "2"
				wsSQL = "SELECT USRCODE, USRNAME FROM MstUser WHERE USRCODE LIKE '%" & IIf(cboUsrTo.SelectionLength > 0, "", Set_Quote(cboUsrTo.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSQL = wsSQL & " ORDER BY USRCODE "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLUSR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboUsrTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrTo.Enter
		FocusMe(cboUsrTo)
	End Sub
	
	Private Sub cboUsrTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboUsrTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboUsrTo, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboUsrTo = False Then
				cboUsrTo.Focus()
				GoTo EventExitSub
			End If
			
			medUpdFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboUsrTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrTo.Leave
		FocusMe(cboUsrTo, True)
	End Sub
	
	Private Sub frmARL011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmARL011_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "ARL011"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboDocNoFr.Text = ""
		cboDocNoTo.Text = ""
		cboCusNoFr.Text = ""
		cboCusNoTo.Text = ""
		cboUsrFr.Text = ""
		cboUsrTo.Text = ""
		
		Call SetDateMask(medPrdFr)
		Call SetDateMask(medPrdTo)
		Call SetDateMask(medUpdFr)
		Call SetDateMask(medUpdTo)
		
		medPrdFr.Text = VB.Left(gsSystemDate, 8) & "01"
		medPrdTo.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(medPrdFr.Text))), "YYYY/MM/DD")
		
		' medUpdFr = Left(gsSystemDate, 8) & "01"
		' medUpdTo = Format(DateAdd("D", -1, DateAdd("M", 1, CDate(medUpdFr.Text))), "YYYY/MM/DD")
		
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chk_cboDocNoTo = False Then
			cboDocNoTo.Focus()
			Exit Function
		End If
		
		If chk_cboCusNoTo = False Then
			cboCusNoTo.Focus()
			Exit Function
		End If
		
		
		If chk_medPrdFr = False Then
			medPrdFr.Focus()
			Exit Function
		End If
		
		If chk_medPrdTo = False Then
			medPrdTo.Focus()
			Exit Function
		End If
		
		
		If chk_medUpdFr = False Then
			medUpdFr.Focus()
			Exit Function
		End If
		
		If chk_medUpdTo = False Then
			medUpdTo.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmARL011.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmARL011_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmARL011_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmARL011 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
		FocusMe(medPrdFr, True)
	End Sub
	
	Private Sub medUpdFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medUpdFr.Enter
		FocusMe(medPrdFr)
	End Sub
	
	Private Sub medUpdFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medUpdFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_medUpdFr = False Then
				medUpdFr.Focus()
				GoTo EventExitSub
			End If
			
			If Trim(medUpdFr.Text) <> "/  /" And Trim(medUpdTo.Text) = "/  /" Then
				medUpdTo.Text = medUpdFr.Text
			End If
			
			medUpdTo.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub medUpdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medUpdFr.Leave
		FocusMe(medPrdFr, True)
	End Sub
	
	Private Sub medUpdTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medUpdTo.Enter
		FocusMe(medPrdFr)
	End Sub
	
	Private Sub medUpdTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medUpdTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_medUpdTo = False Then
				medUpdTo.Focus()
				
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
	
	Private Sub medUpdTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medUpdTo.Leave
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
		
		tblCommon.Visible = False
		If wcCombo.Enabled = True Then wcCombo.Focus()
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
		lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		lblUpdFr.Text = Get_Caption(waScrItm, "UPDFR")
		lblUpdTo.Text = Get_Caption(waScrItm, "UPDTO")
		lblUsrFr.Text = Get_Caption(waScrItm, "USRFR")
		lblUsrTo.Text = Get_Caption(waScrItm, "USRTO")
		
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
		lblTitle.Text = Get_Caption(waScrItm, "TITLE")
	End Sub
	
	Private Function chk_medPrdFr() As Boolean
		chk_medPrdFr = False
		
		If Trim(medPrdFr.Text) = "/  /" Then
			chk_medPrdFr = True
			Exit Function
		End If
		
		If Chk_Date(medPrdFr) = False Then
			wsMsg = "Wrong Period!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medPrdFr = True
	End Function
	
	Private Function chk_medPrdTo() As Boolean
		chk_medPrdTo = False
		
		If UCase(medPrdFr.Text) > UCase(medPrdTo.Text) Then
			wsMsg = "To Must > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If Trim(medPrdTo.Text) = "/  /" Then
			chk_medPrdTo = True
			Exit Function
		End If
		
		If Chk_Date(medPrdTo) = False Then
			
			wsMsg = "Wrong Period!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medPrdTo = True
	End Function
	
	Private Function chk_medUpdFr() As Boolean
		chk_medUpdFr = False
		
		If Trim(medUpdFr.Text) = "/  /" Then
			chk_medUpdFr = True
			Exit Function
		End If
		
		If Chk_Date(medUpdFr) = False Then
			wsMsg = "Wrong Period!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medUpdFr = True
	End Function
	
	Private Function chk_medUpdTo() As Boolean
		chk_medUpdTo = False
		
		If UCase(medUpdFr.Text) > UCase(medUpdTo.Text) Then
			wsMsg = "To Must > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If Trim(medUpdTo.Text) = "/  /" Then
			chk_medUpdTo = True
			Exit Function
		End If
		
		If Chk_Date(medUpdTo) = False Then
			
			wsMsg = "Wrong Period!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medUpdTo = True
	End Function
	
	Private Function chk_cboCusNoTo() As Boolean
		chk_cboCusNoTo = False
		
		If UCase(cboCusNoFr.Text) > UCase(cboCusNoTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboCusNoTo = True
	End Function
	
	Private Function chk_cboUsrTo() As Boolean
		chk_cboUsrTo = False
		
		If UCase(cboUsrFr.Text) > UCase(cboUsrTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboUsrTo = True
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
	
	Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoFr
		
		wsSQL = "SELECT INHDDOCNO, INHDDOCDATE "
		wsSQL = wsSQL & "FROM ARINHD "
		wsSQL = wsSQL & "WHERE INHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY INHDDOCNO"
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboDocNoFr.Left)), VB6.PixelsToTwipsY(cboDocNoFr.Top) + VB6.PixelsToTwipsY(cboDocNoFr.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Call chk_InpLen(cboDocNoFr, 15, KeyAscii)
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
		
		wsSQL = "SELECT INHDDOCNO, INHDDOCDATE "
		wsSQL = wsSQL & "FROM ARINHD "
		wsSQL = wsSQL & "WHERE INHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY INHDDOCNO"
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboDocNoTo.Left)), VB6.PixelsToTwipsY(cboDocNoTo.Top) + VB6.PixelsToTwipsY(cboDocNoTo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Call chk_InpLen(cboDocNoTo, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboDocNoTo = False Then
				Call cboDocNoTo_Enter(cboDocNoTo, New System.EventArgs())
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
			
			If Trim(medPrdFr.Text) <> "/  /" And Trim(medPrdTo.Text) = "/  /" Then
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
			
			cboUsrFr.Focus()
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
	
	Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
		FocusMe(txtTitle)
	End Sub
	
	Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtTitle, 60, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			
			cboDocNoFr.Focus()
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
End Class