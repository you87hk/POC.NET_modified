Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAPL004
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
		ReDim wsSelection(2)
		wsSelection(1) = lblDocNoFr.Text & " " & Set_Quote(cboDocNoFr.Text) & " " & lblDocNoTo.Text & " " & Set_Quote(cboDocNoTo.Text)
		wsSelection(2) = lblPrdFr.Text & " " & medPrdFr.Text & " " & lblPrdTo.Text & " " & medPrdTo.Text
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTAPL004 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 10), Set_Quote(cboDocNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdFr.Text) = "/  /", "0000/00/00", medPrdFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdTo.Text) = "/  /", "9999/99/99", medPrdTo.Text) & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTAPL004"
		Else
			wsRptName = "RPTAPL004"
		End If
		
		NewfrmPrint.ReportID = "APL004"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "APL004"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
		FocusMe(cboDocNoTo, True)
	End Sub
	
	Private Sub frmAPL004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmAPL004_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "APL004"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboDocNoFr.Text = ""
		cboDocNoTo.Text = ""
		SetDateMask(medPrdFr)
		SetDateMask(medPrdTo)
		
		medPrdFr.Text = VB.Left(gsSystemDate, 8) & "01"
		medPrdTo.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(medPrdFr.Text))), "yyyy/mm/dd")
		
		
		wgsTitle = "SALES LEDGER"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chk_cboDocNoTo = False Then
			cboDocNoTo.Focus()
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
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmAPL004.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmAPL004_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmAPL004_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmAPL004 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
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
	
	Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
		FocusMe(medPrdFr, True)
	End Sub
	
	Private Sub medPrdTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo.Enter
		FocusMe(medPrdTo)
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
	
	Private Sub medPrdTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo.Leave
		FocusMe(medPrdTo, True)
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
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblDocNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		
		'LblCurr.Caption = Get_Caption(waScrItm, "CURR")
		
		'lblPrtMrk.Caption = Get_Caption(waScrItm, "PRTMRK")
		
		txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
		lblTitle.Text = Get_Caption(waScrItm, "TITLE")
		
	End Sub
	
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
		
		wsSQL = "SELECT VdrCode, VdrName "
		wsSQL = wsSQL & " FROM MstVendor "
		wsSQL = wsSQL & " WHERE VdrCode LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND VdrStatus ='1' "
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboDocNoFr.Left)), VB6.PixelsToTwipsY(cboDocNoFr.Top) + VB6.PixelsToTwipsY(cboDocNoFr.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Call chk_InpLen(cboDocNoFr, 10, KeyAscii)
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
		
		wsSQL = "SELECT VdrCode, VdrName "
		wsSQL = wsSQL & " FROM MstVendor "
		wsSQL = wsSQL & " WHERE VdrCode LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
		wsSQL = wsSQL & " AND VdrStatus ='1' "
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboDocNoTo.Left)), VB6.PixelsToTwipsY(cboDocNoTo.Top) + VB6.PixelsToTwipsY(cboDocNoTo.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Call chk_InpLen(cboDocNoTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboDocNoTo = False Then
				Call cboDocNoTo_Enter(cboDocNoTo, New System.EventArgs())
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
	
	Private Function chk_medPrdFr() As Boolean
		chk_medPrdFr = False
		
		If Trim(medPrdFr.Text) = "/  /" Then
			wsMsg = "必需輸入日期!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			chk_medPrdFr = False
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
		
		If Trim(medPrdTo.Text) = "/  /" Then
			wsMsg = "必需輸入日期!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			chk_medPrdTo = False
			Exit Function
		End If
		
		If UCase(medPrdFr.Text) > UCase(medPrdTo.Text) Then
			wsMsg = "To Must > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If Chk_Date(medPrdTo) = False Then
			
			wsMsg = "Wrong Date!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		chk_medPrdTo = True
	End Function
End Class