Option Strict Off
Option Explicit On
Friend Class frmML002
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
		cboMLCodeFr.Focus()
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
		ReDim wsSelection(3)
		wsSelection(1) = lblMLCodeFr.Text & " " & Set_Quote(cboMLCodeFr.Text) & " " & lblMLCodeTo.Text & " " & Set_Quote(cboMLCodeTo.Text)
		wsSelection(2) = lblCOAAccCode.Text & " " & Set_Quote(cboCOAAccCode.Text)
		wsSelection(3) = FraMLType.Text & " " & Set_Quote(CStr(Opt_Getfocus(optMLType, 6, 0)))
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTML002 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboMLCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboMLCodeTo.Text) = "", New String("z", 15), Set_Quote(cboMLCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCOAAccCode.Text) = "", "0", Get_TableInfo("MstCOA", "COAAccCode= '" & Set_Quote(cboCOAAccCode.Text) & "' AND COAStatus ='1'", "COAAccID")) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(GetMLType()) & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTML002"
		Else
			wsRptName = "RPTML002"
		End If
		
		NewfrmPrint.ReportID = "ML002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "ML002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCOAAccCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCOAAccCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCOAAccCode
		
		Select Case gsLangID
			Case "1"
				wsSQL = "SELECT COAAccCode, COADesc FROM MstCOA WHERE COAAccCode LIKE '%" & IIf(cboCOAAccCode.SelectionLength > 0, "", Set_Quote(cboCOAAccCode.Text)) & "%' AND COAStatus <>'2' "
			Case Else
				wsSQL = "SELECT COAAccCode, COACDesc FROM MstCOA WHERE COAAccCode LIKE '%" & IIf(cboCOAAccCode.SelectionLength > 0, "", Set_Quote(cboCOAAccCode.Text)) & "%' AND COAStatus <>'2' "
		End Select
		
		wsSQL = wsSQL & " ORDER BY COAAccCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCOAAccCode.Left)), VB6.PixelsToTwipsY(cboCOAAccCode.Top) + VB6.PixelsToTwipsY(cboCOAAccCode.Height), tblCommon, wsFormID, "TBLCOAACCCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCOAAccCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCOAAccCode.Enter
		FocusMe(cboCOAAccCode)
		wcCombo = cboCOAAccCode
	End Sub
	
	Private Sub cboCOAAccCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCOAAccCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCOAAccCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			Call Opt_Setfocus(optMLType, 6, 0)
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboCOAAccCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCOAAccCode.Leave
		FocusMe(cboCOAAccCode, True)
	End Sub
	
	Private Sub cboMLCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCodeTo.Leave
		FocusMe(cboMLCodeTo, True)
	End Sub
	
	Private Sub frmML002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmML002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "ML002"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboMLCodeFr.Text = ""
		cboMLCodeTo.Text = ""
		cboCOAAccCode.Text = ""
		
		optMLType(0).Checked = True
		
		wgsTitle = "Merchandise Class List"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chk_cboMLCodeTo = False Then
			cboMLCodeTo.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmML002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmML002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmML002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmML002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
		
		tblCommon.Visible = False
		If wcCombo.Enabled = True Then wcCombo.Focus()
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblTitle.Text = Get_Caption(waScrItm, "TITLE")
		txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
		lblMLCodeFr.Text = Get_Caption(waScrItm, "MLCODEFR")
		lblMLCodeTo.Text = Get_Caption(waScrItm, "MLCODETO")
		lblCOAAccCode.Text = Get_Caption(waScrItm, "COAACCCODE")
		
		optMLType(0).Text = Get_Caption(waScrItm, "OPTMLTYPE0")
		optMLType(1).Text = Get_Caption(waScrItm, "OPTMLTYPE1")
		optMLType(2).Text = Get_Caption(waScrItm, "OPTMLTYPE2")
		optMLType(3).Text = Get_Caption(waScrItm, "OPTMLTYPE3")
		optMLType(4).Text = Get_Caption(waScrItm, "OPTMLTYPE4")
		optMLType(5).Text = Get_Caption(waScrItm, "OPTMLTYPE5")
		
		FraMLType.Text = Get_Caption(waScrItm, "FRAMLTYPE")
		
	End Sub
	
	Private Function chk_cboMLCodeTo() As Boolean
		chk_cboMLCodeTo = False
		
		If UCase(cboMLCodeFr.Text) > UCase(cboMLCodeTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboMLCodeTo = True
	End Function
	
	Private Sub cboMLCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboMLCodeFr
		
		If gsLangID = "1" Then
			wsSQL = "SELECT MLCODE, MLDESC "
			wsSQL = wsSQL & " FROM MstMerchClass "
			wsSQL = wsSQL & " WHERE MLCODE LIKE '%" & IIf(cboMLCodeFr.SelectionLength > 0, "", Set_Quote(cboMLCodeFr.Text)) & "%' "
			wsSQL = wsSQL & " AND MLSTATUS  <> '2' "
			wsSQL = wsSQL & " ORDER BY MLCODE "
		Else
			wsSQL = "SELECT MLCODE, MLDESC "
			wsSQL = wsSQL & " FROM MstMerchClass "
			wsSQL = wsSQL & " WHERE MLCODE LIKE '%" & IIf(cboMLCodeTo.SelectionLength > 0, "", Set_Quote(cboMLCodeTo.Text)) & "%' "
			wsSQL = wsSQL & " AND MLSTATUS  <> '2' "
			wsSQL = wsSQL & " ORDER BY MLCODE "
		End If
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboMLCodeFr.Left)), VB6.PixelsToTwipsY(cboMLCodeFr.Top) + VB6.PixelsToTwipsY(cboMLCodeFr.Height), tblCommon, wsFormID, "TBLMLCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboMLCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCodeFr.Enter
		FocusMe(cboMLCodeFr)
		wcCombo = cboMLCodeFr
	End Sub
	
	Private Sub cboMLCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboMLCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboMLCodeFr, 15, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboMLCodeFr.Text) <> "" And Trim(cboMLCodeTo.Text) = "" Then
				cboMLCodeTo.Text = cboMLCodeFr.Text
			End If
			
			cboMLCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboMLCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCodeFr.Leave
		FocusMe(cboMLCodeFr, True)
	End Sub
	
	Private Sub cboMLCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboMLCodeTo
		
		If gsLangID = "1" Then
			wsSQL = "SELECT MLCODE, MLDESC "
			wsSQL = wsSQL & " FROM MstMerchClass "
			wsSQL = wsSQL & " WHERE MLCODE LIKE '%" & IIf(cboMLCodeTo.SelectionLength > 0, "", Set_Quote(cboMLCodeTo.Text)) & "%' "
			wsSQL = wsSQL & " AND MLSTATUS  <> '2' "
			wsSQL = wsSQL & " ORDER BY MLCODE "
		Else
			wsSQL = "SELECT MLCODE, MLDESC "
			wsSQL = wsSQL & " FROM MstMerchClass "
			wsSQL = wsSQL & " WHERE MLCODE LIKE '%" & IIf(cboMLCodeTo.SelectionLength > 0, "", Set_Quote(cboMLCodeTo.Text)) & "%' "
			wsSQL = wsSQL & " AND MLSTATUS  <> '2' "
			wsSQL = wsSQL & " ORDER BY MLCODE "
		End If
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboMLCodeTo.Left)), VB6.PixelsToTwipsY(cboMLCodeTo.Top) + VB6.PixelsToTwipsY(cboMLCodeTo.Height), tblCommon, wsFormID, "TBLMLCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboMLCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCodeTo.Enter
		FocusMe(cboMLCodeTo)
		wcCombo = cboMLCodeTo
	End Sub
	
	Private Sub cboMLCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboMLCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboMLCodeTo, 15, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboMLCodeTo = False Then
				cboMLCodeTo.Focus()
				GoTo EventExitSub
			End If
			
			cboCOAAccCode.Focus()
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
			
			cboMLCodeFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
	
	Private Sub optMLType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optMLType.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optMLType.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			cboMLCodeFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function GetMLType() As String
		Dim iCounter As Short
		
		For iCounter = 0 To 5
			If optMLType(iCounter).Checked = True Then
				Exit For
			End If
		Next 
		
		Select Case iCounter
			Case 0
				GetMLType = "S"
				
			Case 1
				GetMLType = "P"
				
			Case 2
				GetMLType = "A"
				
			Case 3
				GetMLType = "R"
				
			Case 4
				GetMLType = "G"
				
			Case 5
				GetMLType = "B"
		End Select
	End Function
End Class