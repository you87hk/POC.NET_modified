Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAP100
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
		Dim wsSql As String
		Dim adcmdSave As New ADODB.Command
		
		On Error GoTo cmdSave_Err
		
		wsDteTim = gsSystemDate
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		If chkAR.CheckState = 1 Then
			
			
			adcmdSave.CommandText = "USP_AP100A"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			Call SetSPPara(adcmdSave, 1, gsUserID)
			Call SetSPPara(adcmdSave, 2, Change_SQLDate(wsDteTim))
			Call SetSPPara(adcmdSave, 3, wsDteTim)
			Call SetSPPara(adcmdSave, 4, cboDocNoFr.Text)
			Call SetSPPara(adcmdSave, 5, IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), cboDocNoTo.Text))
			Call SetSPPara(adcmdSave, 6, cboVdrNoFr.Text)
			Call SetSPPara(adcmdSave, 7, IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), cboVdrNoTo.Text))
			Call SetSPPara(adcmdSave, 8, medPrdFr.Text)
			Call SetSPPara(adcmdSave, 9, medPrdTo.Text)
			Call SetSPPara(adcmdSave, 10, "")
			
			
			adcmdSave.Execute()
			
		End If
		
		If chkSettle.CheckState = 1 Then
			
			
			adcmdSave.CommandText = "USP_AP100B"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			Call SetSPPara(adcmdSave, 1, gsUserID)
			Call SetSPPara(adcmdSave, 2, Change_SQLDate(wsDteTim))
			Call SetSPPara(adcmdSave, 3, wsDteTim)
			Call SetSPPara(adcmdSave, 4, cboChqNoFr.Text)
			Call SetSPPara(adcmdSave, 5, IIf(Trim(cboChqNoTo.Text) = "", New String("z", 15), cboChqNoTo.Text))
			Call SetSPPara(adcmdSave, 6, cboVdrNoFr2.Text)
			Call SetSPPara(adcmdSave, 7, IIf(Trim(cboVdrNoTo2.Text) = "", New String("z", 10), cboVdrNoTo2.Text))
			Call SetSPPara(adcmdSave, 8, medPrdFr2.Text)
			Call SetSPPara(adcmdSave, 9, medPrdTo2.Text)
			
			
			adcmdSave.Execute()
			
		End If
		
		cnCon.CommitTrans() 'Create Stored Procedure String
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		gsMsg = "Update Process is completed!"
		MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		
		Call cmdCancel()
		
		Exit Sub
		
cmdSave_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
	End Sub
	
	Private Sub cboChqNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboChqNoTo.Leave
		FocusMe(cboChqNoTo, True)
	End Sub
	
	Private Sub cboVdrNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
			Case "2"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboVdrNoFr.Left)), VB6.PixelsToTwipsY(cboVdrNoFr.Top) + VB6.PixelsToTwipsY(cboVdrNoFr.Height), tblCommon, wsFormID, "TBLVdrNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVdrNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.Enter
		FocusMe(cboVdrNoFr)
		wcCombo = cboVdrNoFr
	End Sub
	
	Private Sub cboVdrNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboVdrNoFr, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboVdrNoFr.Text) <> "" And Trim(cboVdrNoTo.Text) = "" Then
				cboVdrNoTo.Text = cboVdrNoFr.Text
			End If
			cboVdrNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub cboVdrNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.Leave
		FocusMe(cboVdrNoFr, True)
	End Sub
	
	
	
	Private Sub cboVdrNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
			Case "2"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboVdrNoTo.Left)), VB6.PixelsToTwipsY(cboVdrNoTo.Top) + VB6.PixelsToTwipsY(cboVdrNoTo.Height), tblCommon, wsFormID, "TBLVdrNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVdrNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.Enter
		FocusMe(cboVdrNoTo)
		wcCombo = cboVdrNoTo
	End Sub
	
	Private Sub cboVdrNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboVdrNoTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboVdrNoTo = False Then
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
	
	
	
	Private Sub cboVdrNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.Leave
		FocusMe(cboVdrNoTo, True)
	End Sub
	
	
	
	Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
		FocusMe(cboDocNoTo, True)
	End Sub
	
	
	
	Private Sub chkAR_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkAR.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			cboDocNoFr.Focus()
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub chkSettle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkSettle.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			cboChqNoFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmAP100_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmAP100_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "AP100"
		
	End Sub
	
	Private Sub Ini_Scr()
		Dim wsFromDate As String
		Dim wsToDate As String
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		
		wsFromDate = getCtrlMth("AP")
		wsFromDate = VB.Left(wsFromDate, 4) & "/" & Mid(wsFromDate, 5, 2) & "/" & "01"
		wsToDate = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, CDate(DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(wsFromDate)))), "YYYY/MM/DD")
		
		
		chkAR.CheckState = System.Windows.Forms.CheckState.Checked
		
		cboDocNoFr.Text = ""
		cboDocNoTo.Text = ""
		cboVdrNoFr.Text = ""
		cboVdrNoTo.Text = ""
		Call SetDateMask(medPrdFr)
		Call SetDateMask(medPrdTo)
		
		cboChqNoFr.Text = ""
		cboChqNoTo.Text = ""
		cboVdrNoFr2.Text = ""
		cboVdrNoTo2.Text = ""
		Call SetDateMask(medPrdFr2)
		Call SetDateMask(medPrdTo2)
		
		chkSettle.CheckState = System.Windows.Forms.CheckState.Checked
		
		medPrdFr.Text = wsFromDate
		medPrdFr2.Text = wsFromDate
		medPrdTo.Text = wsToDate
		medPrdTo2.Text = wsToDate
		
		
	End Sub
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chkAR.CheckState = 1 Then
			
			If chk_cboDocNoTo = False Then
				Exit Function
			End If
			
			If chk_cboVdrNoTo = False Then
				Exit Function
			End If
			
			
			If chk_medPrdFr = False Then
				Exit Function
			End If
			
			If chk_medPrdTo = False Then
				Exit Function
			End If
			
		End If
		If chkSettle.CheckState = 1 Then
			
			If chk_cboChqNoTo = False Then
				Exit Function
			End If
			
			If chk_cboVdrNoTo2 = False Then
				Exit Function
			End If
			
			
			If chk_medPrdFr2 = False Then
				Exit Function
			End If
			
			If chk_medPrdTo2 = False Then
				Exit Function
			End If
			
		End If
		
		If chkAR.CheckState = 0 And chkSettle.CheckState = 0 Then
			gsMsg = "Please Select Type Of Update!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			chkAR.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	
	
	'UPGRADE_WARNING: Event frmAP100.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmAP100_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(5190)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmAP100_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmAP100 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	
	Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
		FocusMe(medPrdFr, True)
	End Sub
	
	
	
	Private Sub medPrdFr2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr2.Leave
		FocusMe(medPrdFr2, True)
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
		Call Get_Scr_Item("AP100", waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
		lblVdrNoFr.Text = Get_Caption(waScrItm, "VdrNoFR")
		lblVdrNoTo.Text = Get_Caption(waScrItm, "VdrNoTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		lblChqNoFr.Text = Get_Caption(waScrItm, "CHQNOFR")
		lblChqNoTo.Text = Get_Caption(waScrItm, "CHQNOTO")
		lblVdrNoFr2.Text = Get_Caption(waScrItm, "VdrNoFR2")
		lblVdrNoTo2.Text = Get_Caption(waScrItm, "VdrNoTO2")
		lblPrdFr2.Text = Get_Caption(waScrItm, "PRDFR2")
		lblPrdTo2.Text = Get_Caption(waScrItm, "PRDTO2")
		chkAR.Text = Get_Caption(waScrItm, "CHKAR")
		chkSettle.Text = Get_Caption(waScrItm, "CHKSETTLE")
		
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		
		
	End Sub
	
	
	
	Private Function chk_medPrdFr() As Boolean
		chk_medPrdFr = False
		
		
		
		If Chk_Date(medPrdFr) = False Then
			gsMsg = "Invalid Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr.Focus()
			Exit Function
		End If
		
		If medPrdFr.Text < gsDateFrom Or medPrdTo.Text > gsDateTo Then
			gsMsg = "Out Of date range!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr.Focus()
			Exit Function
		End If
		
		If medPrdFr.Text > medPrdTo.Text Then
			gsMsg = "To Date must greater From Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo.Focus()
			Exit Function
		End If
		
		
		chk_medPrdFr = True
		
	End Function
	
	Private Function chk_medPrdFr2() As Boolean
		chk_medPrdFr2 = False
		
		
		
		If Chk_Date(medPrdFr2) = False Then
			gsMsg = "Invalid Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr2.Focus()
			Exit Function
		End If
		
		If medPrdFr2.Text < gsDateFrom Or medPrdTo2.Text > gsDateTo Then
			gsMsg = "Out Of date range!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr2.Focus()
			Exit Function
		End If
		
		If medPrdFr2.Text > medPrdTo2.Text Then
			gsMsg = "To Date must greater From Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo2.Focus()
			Exit Function
		End If
		
		
		chk_medPrdFr2 = True
		
	End Function
	
	
	
	Private Function chk_medPrdTo() As Boolean
		chk_medPrdTo = False
		
		If Chk_Date(medPrdTo) = False Then
			gsMsg = "Invalid Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo.Focus()
			Exit Function
		End If
		
		If medPrdTo.Text < gsDateFrom Or medPrdTo.Text > gsDateTo Then
			gsMsg = "Out Of date range!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo.Focus()
			Exit Function
		End If
		
		If medPrdFr.Text > medPrdTo.Text Then
			gsMsg = "To Date must greater From Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo.Focus()
			Exit Function
		End If
		
		chk_medPrdTo = True
	End Function
	
	Private Function chk_medPrdTo2() As Boolean
		chk_medPrdTo2 = False
		
		If Chk_Date(medPrdTo2) = False Then
			gsMsg = "Invalid Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo2.Focus()
			Exit Function
		End If
		
		If medPrdTo2.Text < gsDateFrom Or medPrdTo2.Text > gsDateTo Then
			gsMsg = "Out Of date range!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo2.Focus()
			Exit Function
		End If
		
		If medPrdFr2.Text > medPrdTo2.Text Then
			gsMsg = "To Date must greater From Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo2.Focus()
			Exit Function
		End If
		
		chk_medPrdTo2 = True
	End Function
	
	Private Function chk_cboVdrNoTo() As Boolean
		chk_cboVdrNoTo = False
		
		If UCase(cboVdrNoFr.Text) > UCase(cboVdrNoTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboVdrNoFr.Focus()
			Exit Function
		End If
		
		chk_cboVdrNoTo = True
	End Function
	
	Private Function chk_cboVdrNoTo2() As Boolean
		chk_cboVdrNoTo2 = False
		
		If UCase(cboVdrNoFr2.Text) > UCase(cboVdrNoTo2.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboVdrNoFr2.Focus()
			Exit Function
		End If
		
		chk_cboVdrNoTo2 = True
	End Function
	Private Function chk_cboDocNoTo() As Boolean
		chk_cboDocNoTo = False
		
		If UCase(cboDocNoFr.Text) > UCase(cboDocNoTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNoTo.Focus()
			Exit Function
		End If
		
		chk_cboDocNoTo = True
	End Function
	
	Private Function chk_cboChqNoTo() As Boolean
		chk_cboChqNoTo = False
		
		If UCase(cboChqNoFr.Text) > UCase(cboChqNoTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboChqNoTo.Focus()
			Exit Function
		End If
		
		chk_cboChqNoTo = True
	End Function
	
	Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoFr
		
		wsSql = "SELECT IPHDDOCNO, VdrCode, IPHDDOCDATE "
		wsSql = wsSql & " FROM APIPHD, mstVendor "
		wsSql = wsSql & " WHERE IPHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
		wsSql = wsSql & " AND IPHDVDRID  = VDRID "
		wsSql = wsSql & " AND IPHDSTATUS  <> '2' "
		wsSql = wsSql & " ORDER BY IPHDDOCNO "
		Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboDocNoFr.Left)), VB6.PixelsToTwipsY(cboDocNoFr.Top) + VB6.PixelsToTwipsY(cboDocNoFr.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoTo
		
		wsSql = "SELECT IPHDDOCNO, VdrCode, IPHDDOCDATE "
		wsSql = wsSql & " FROM APIPHD, mstVendor "
		wsSql = wsSql & " WHERE IPHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
		wsSql = wsSql & " AND IPHDVDRID  = VDRID "
		wsSql = wsSql & " AND IPHDSTATUS  <> '2' "
		wsSql = wsSql & " ORDER BY IPHDDOCNO "
		
		Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboDocNoTo.Left)), VB6.PixelsToTwipsY(cboDocNoTo.Top) + VB6.PixelsToTwipsY(cboDocNoTo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
				GoTo EventExitSub
			End If
			
			cboVdrNoFr.Focus()
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
				GoTo EventExitSub
			End If
			chkSettle.Focus()
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
	
	
	Private Sub cboChqNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboChqNoFr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboChqNoFr
		
		wsSql = "SELECT APCQCHQNO, VdrCode, APCQCHQDATE "
		wsSql = wsSql & " FROM APCHEQUE, mstVendor "
		wsSql = wsSql & " WHERE APCQCHQNO LIKE '%" & IIf(cboChqNoFr.SelectionLength > 0, "", Set_Quote(cboChqNoFr.Text)) & "%' "
		wsSql = wsSql & " AND APCQVDRID  = VDRID "
		wsSql = wsSql & " AND APCQSTATUS  <> '2' "
		' wsSql = wsSql & " ORDER BY APCQCHQNO "
		wsSql = wsSql & " UNION "
		wsSql = wsSql & " SELECT APSHDOCNO, VdrCode, APSHDOCDATE "
		wsSql = wsSql & " FROM APSTHD, mstVendor "
		wsSql = wsSql & " WHERE APSHDOCNO LIKE '%" & IIf(cboChqNoFr.SelectionLength > 0, "", Set_Quote(cboChqNoFr.Text)) & "%' "
		wsSql = wsSql & " AND APSHVDRID  = VDRID "
		wsSql = wsSql & " AND APSHSTATUS  <> '2' "
		' wsSql = wsSql & " ORDER BY APSHDOCNO "
		
		Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboChqNoFr.Left)), VB6.PixelsToTwipsY(cboChqNoFr.Top) + VB6.PixelsToTwipsY(cboChqNoFr.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboChqNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboChqNoFr.Enter
		FocusMe(cboChqNoFr)
		wcCombo = cboChqNoFr
	End Sub
	
	Private Sub cboChqNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboChqNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboChqNoFr, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboChqNoFr.Text) <> "" And Trim(cboChqNoTo.Text) = "" Then
				cboChqNoTo.Text = cboChqNoFr.Text
			End If
			cboChqNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboChqNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboChqNoFr.Leave
		FocusMe(cboChqNoFr, True)
	End Sub
	
	Private Sub cboChqNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboChqNoTo.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboChqNoTo
		
		wsSql = "SELECT APCQCHQNO, VdrCode, APCQCHQDATE "
		wsSql = wsSql & " FROM APCHEQUE, mstVendor "
		wsSql = wsSql & " WHERE APCQCHQNO LIKE '%" & IIf(cboChqNoTo.SelectionLength > 0, "", Set_Quote(cboChqNoTo.Text)) & "%' "
		wsSql = wsSql & " AND APCQVDRID  = VDRID "
		wsSql = wsSql & " AND APCQSTATUS  <> '2' "
		wsSql = wsSql & " ORDER BY APCQCHQNO "
		
		Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboChqNoTo.Left)), VB6.PixelsToTwipsY(cboChqNoTo.Top) + VB6.PixelsToTwipsY(cboChqNoTo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboChqNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboChqNoTo.Enter
		FocusMe(cboChqNoTo)
		wcCombo = cboChqNoTo
	End Sub
	
	Private Sub cboChqNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboChqNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboChqNoTo, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboChqNoTo = False Then
				GoTo EventExitSub
			End If
			
			cboVdrNoFr2.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub medPrdFr2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr2.Enter
		FocusMe(medPrdFr2)
	End Sub
	
	
	Private Sub medPrdFr2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdFr2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_medPrdFr2 = False Then
				GoTo EventExitSub
			End If
			
			If Trim(medPrdFr2.Text) <> "/" And Trim(medPrdTo2.Text) = "/" Then
				medPrdTo2.Text = medPrdFr2.Text
			End If
			medPrdTo2.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub medPrdTo2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdTo2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If chk_medPrdTo2 = False Then
				GoTo EventExitSub
			End If
			chkAR.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub medPrdTo2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo2.Enter
		FocusMe(medPrdTo2)
	End Sub
	Private Sub medPrdTo2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo2.Leave
		FocusMe(medPrdTo2, True)
	End Sub
	
	
	Private Sub cboVdrNoFr2_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr2.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr2.SelectionLength > 0, "", Set_Quote(cboVdrNoFr2.Text)) & "%' "
			Case "2"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr2.SelectionLength > 0, "", Set_Quote(cboVdrNoFr2.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboVdrNoFr2.Left)), VB6.PixelsToTwipsY(cboVdrNoFr2.Top) + VB6.PixelsToTwipsY(cboVdrNoFr2.Height), tblCommon, wsFormID, "TBLVdrNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVdrNoFr2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr2.Enter
		FocusMe(cboVdrNoFr2)
		wcCombo = cboVdrNoFr2
	End Sub
	
	Private Sub cboVdrNoFr2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrNoFr2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboVdrNoFr2, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboVdrNoFr2.Text) <> "" And Trim(cboVdrNoTo2.Text) = "" Then
				cboVdrNoTo2.Text = cboVdrNoFr2.Text
			End If
			cboVdrNoTo2.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub cboVdrNoFr2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr2.Leave
		FocusMe(cboVdrNoFr2, True)
	End Sub
	
	
	
	Private Sub cboVdrNoTo2_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo2.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr2.SelectionLength > 0, "", Set_Quote(cboVdrNoFr2.Text)) & "%' "
			Case "2"
				wsSql = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboVdrNoFr2.SelectionLength > 0, "", Set_Quote(cboVdrNoFr2.Text)) & "%' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboVdrNoTo2.Left)), VB6.PixelsToTwipsY(cboVdrNoTo2.Top) + VB6.PixelsToTwipsY(cboVdrNoTo2.Height), tblCommon, wsFormID, "TBLVdrNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVdrNoTo2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo2.Enter
		FocusMe(cboVdrNoTo2)
		wcCombo = cboVdrNoTo2
	End Sub
	
	Private Sub cboVdrNoTo2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrNoTo2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboVdrNoTo2, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboVdrNoTo2 = False Then
				GoTo EventExitSub
			End If
			
			medPrdFr2.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub cboVdrNoTo2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo2.Leave
		FocusMe(cboVdrNoTo2, True)
	End Sub
End Class