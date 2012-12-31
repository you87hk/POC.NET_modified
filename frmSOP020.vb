Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSOP020
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
		cboItmCodeFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSql As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wiSel As Short
		Dim wiBy As Short
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(7)
		wsSelection(1) = lblItmCodeFr.Text & " " & Set_Quote(cboItmCodeFr.Text) & " " & lblItmCodeTo.Text & " " & Set_Quote(cboItmCodeTo.Text)
		wsSelection(2) = lblItmTypeCodeFr.Text & " " & Set_Quote(cboItmTypeCodeFr.Text) & " " & lblItmTypeCodeTo.Text & " " & Set_Quote(cboItmTypeCodeTo.Text)
		wsSelection(3) = lblLevelCodeFr.Text & " " & Set_Quote(cboLevelCodeFr.Text) & " " & lblLevelCodeTo.Text & " " & Set_Quote(cboLevelCodeTo.Text)
		wsSelection(4) = lblAccTypeCodeFr.Text & " " & Set_Quote(cboAccTypeCodeFr.Text) & " " & lblAccTypeCodeTo.Text & " " & Set_Quote(cboAccTypeCodeTo.Text)
		wsSelection(5) = lblCusNoFr.Text & " " & Set_Quote(cboCusNoFr.Text) & " " & lblCusNoTo.Text & " " & Set_Quote(cboCusNoTo.Text)
		
		wiSel = Opt_Getfocus(optBy, 3, 0)
		
		Select Case wiBy
			Case 0
				wsSelection(6) = optBy(0).Text & " " & Set_Quote(txtPayMonth.Text)
			Case 1
				wsSelection(6) = optBy(1).Text & " " & Set_Quote(txtPayQuarter.Text)
			Case 2
				wsSelection(6) = optBy(2).Text & " " & Set_Quote(txtPayYear.Text)
		End Select
		
		
		wiBy = Opt_Getfocus(optSel, 5, 0)
		Select Case wiBy
			Case 0
				wsSelection(7) = lblItmCodeFr.Text
			Case 1
				wsSelection(7) = lblItmTypeCodeFr.Text
			Case 2
				wsSelection(7) = lblLevelCodeFr.Text
			Case 3
				wsSelection(7) = lblAccTypeCodeFr.Text
			Case 4
				wsSelection(7) = lblCusNoFr.Text
		End Select
		
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTSOP020 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboItmCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), Set_Quote(cboItmCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboItmTypeCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboItmTypeCodeTo.Text) = "", New String("z", 10), Set_Quote(cboItmTypeCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & Set_Quote(Me.cboLevelCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboLevelCodeTo.Text) = "", New String("z", 10), Set_Quote(cboLevelCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboAccTypeCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboAccTypeCodeTo.Text) = "", New String("z", 10), Set_Quote(cboAccTypeCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSql = wsSql & wiSel & ", "
		
		
		If wiSel = 2 Then
			wsSql = wsSql & Set_Quote(txtPayYear.Text) & ", "
		ElseIf wiSel = 1 Then 
			wsSql = wsSql & Set_Quote(txtPayQuarter.Text) & ", "
		ElseIf wiSel = 0 Then 
			wsSql = wsSql & Set_Quote(txtPayMonth.Text) & ", "
		End If
		
		wsSql = wsSql & wiBy & ", "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSOP020"
		Else
			wsRptName = "RPTSOP020"
		End If
		
		NewfrmPrint.ReportID = "SOP020"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "SOP020"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmSOP020_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmSOP020_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "SOP020"
		
	End Sub
	
	Private Sub Ini_Scr()
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboItmCodeFr.Text = ""
		cboItmCodeTo.Text = ""
		cboItmTypeCodeFr.Text = ""
		cboItmTypeCodeTo.Text = ""
		cboLevelCodeFr.Text = ""
		cboLevelCodeTo.Text = ""
		cboAccTypeCodeFr.Text = ""
		cboAccTypeCodeTo.Text = ""
		cboCusNoFr.Text = ""
		cboCusNoTo.Text = ""
		'txtYear = Format(gsSystemDate, "YYYY")
		
		optBy(0).Checked = True
		optSel(0).Checked = True
		
		
		txtPayMonth.Text = CStr(To_Value(Mid(gsSystemDate, 6, 2)))
		txtPayYear.Text = CStr(To_Value(VB.Left(gsSystemDate, 4)))
		
		If To_Value((txtPayMonth.Text)) < 4 Then
			txtPayQuarter.Text = "1"
		ElseIf To_Value((txtPayMonth.Text)) >= 4 And To_Value((txtPayMonth.Text)) < 7 Then 
			txtPayQuarter.Text = "2"
		ElseIf To_Value((txtPayMonth.Text)) >= 7 And To_Value((txtPayMonth.Text)) < 10 Then 
			txtPayQuarter.Text = "3"
		Else
			txtPayQuarter.Text = "4"
		End If
		
		wgsTitle = "Sales Analysis Report"
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		'If chk_cboMethodCodeTo = False Then
		'    cboMethodCodeTo.SetFocus
		'    Exit Function
		'End If
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmSOP020.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmSOP020_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(5760)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmSOP020_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmSOP020 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        ElseIf eventArgs.keyCode = System.Windows.Forms.Keys.Return Then
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
		
		lblItmCodeFr.Text = Get_Caption(waScrItm, "ITMCODEFR")
		lblItmCodeTo.Text = Get_Caption(waScrItm, "ITMCODETO")
		lblItmTypeCodeFr.Text = Get_Caption(waScrItm, "ITMTYPECODEFR")
		lblItmTypeCodeTo.Text = Get_Caption(waScrItm, "ITMTYPECODETO")
		lblAccTypeCodeFr.Text = Get_Caption(waScrItm, "ACCTYPECODEFR")
		lblAccTypeCodeTo.Text = Get_Caption(waScrItm, "ACCTYPECODETO")
		lblLevelCodeFr.Text = Get_Caption(waScrItm, "LEVELCODEFR")
		lblLevelCodeTo.Text = Get_Caption(waScrItm, "LEVELCODETO")
		lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		
		fraRange.Text = Get_Caption(waScrItm, "RANGE")
		
		optBy(0).Text = Get_Caption(waScrItm, "PAYMONTH")
		optBy(1).Text = Get_Caption(waScrItm, "PAYQUARTER")
		optBy(2).Text = Get_Caption(waScrItm, "PAYYEAR")
		
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

            cboItmCodeFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
        FocusMe(txtTitle, True)
    End Sub

    Private Sub cboItmCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCodeFr

        wsSql = "SELECT ITMCODE, ITMBARCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", ITMITMTYPECODE, ITMCLASS "
        wsSql = wsSql & " FROM MstItem "
        wsSql = wsSql & " WHERE ITMCODE LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
        wsSql = wsSql & " AND ITMSTATUS  <> '2' "
        wsSql = wsSql & " ORDER BY ITMCODE "
        Call Ini_Combo(5, wsSql, (VB6.PixelsToTwipsX(cboItmCodeFr.Left)), VB6.PixelsToTwipsY(cboItmCodeFr.Top) + VB6.PixelsToTwipsY(cboItmCodeFr.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Enter
        FocusMe(cboItmCodeFr)
        wcCombo = cboItmCodeFr
    End Sub

    Private Sub cboItmCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmCodeFr, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboItmCodeFr.Text) <> "" And Trim(cboItmCodeTo.Text) = "" Then
                cboItmCodeTo.Text = cboItmCodeFr.Text
            End If

            cboItmCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Leave
        FocusMe(cboItmCodeFr, True)
    End Sub

    Private Sub cboItmCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCodeTo

        wsSql = "SELECT ITMCODE, ITMBARCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", ITMITMTYPECODE, ITMCLASS "
        wsSql = wsSql & " FROM MstItem "
        wsSql = wsSql & " WHERE ITMCODE LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
        wsSql = wsSql & " AND ITMSTATUS  <> '2' "
        wsSql = wsSql & " ORDER BY ITMCODE "

        Call Ini_Combo(5, wsSql, (VB6.PixelsToTwipsX(cboItmCodeTo.Left)), VB6.PixelsToTwipsY(cboItmCodeTo.Top) + VB6.PixelsToTwipsY(cboItmCodeTo.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Enter
        FocusMe(cboItmCodeTo)
        wcCombo = cboItmCodeTo
    End Sub

    Private Sub cboItmCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmCodeTo, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmCodeTo = False Then
                cboItmCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboItmTypeCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Leave
        FocusMe(cboItmCodeTo, True)
    End Sub

    Private Function chk_cboItmCodeTo() As Boolean
        chk_cboItmCodeTo = False

        If UCase(cboItmCodeFr.Text) > UCase(cboItmCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboItmCodeTo = True
    End Function

    Private Sub optBy_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optBy.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optBy.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Index = 0 Then
                txtPayMonth.Focus()
            ElseIf Index = 1 Then
                txtPayQuarter.Focus()
            ElseIf Index = 2 Then
                txtPayYear.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub optSel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optSel.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optSel.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            Call Opt_Setfocus(optBy, 3, 0)

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtPayMonth_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayMonth.Enter
        FocusMe(txtPayMonth)
    End Sub

    Private Sub txtPayMonth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayMonth.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtPayMonth.Text, False, False)
        Call chk_InpLen(txtPayMonth, 2, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtPayMonth Then
                cboItmCodeFr.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_txtPayMonth() As Boolean
        Chk_txtPayMonth = False

        If Trim(txtPayMonth.Text) = "" Then
            Chk_txtPayMonth = True
            Exit Function
        End If

        If To_Value(txtPayMonth) < 1 Or To_Value(txtPayMonth) > 12 Then
            gsMsg = "月份錯誤, 請重新輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtPayMonth.Focus()
            Exit Function
        End If

        Chk_txtPayMonth = True
    End Function

    Private Sub txtPayMonth_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayMonth.Leave
        FocusMe(txtPayMonth, True)
    End Sub

    Private Sub txtPayQuarter_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayQuarter.Enter
        FocusMe(txtPayQuarter)
    End Sub

    Private Sub txtPayQuarter_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayQuarter.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtPayQuarter.Text, False, False)
        Call chk_InpLen(txtPayQuarter, 1, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtPayQuarter Then
                cboItmCodeFr.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_txtPayQuarter() As Boolean
        Chk_txtPayQuarter = False

        If Trim(txtPayQuarter.Text) = "" Then
            Chk_txtPayQuarter = True
            Exit Function
        End If

        If To_Value(txtPayQuarter) < 1 Or To_Value(txtPayQuarter) > 4 Then
            gsMsg = "季節錯誤, 請重新輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtPayQuarter.Focus()
            Exit Function
        End If

        Chk_txtPayQuarter = True
    End Function

    Private Sub txtPayQuarter_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayQuarter.Leave
        FocusMe(txtPayQuarter, True)
    End Sub

    Private Sub txtPayYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayYear.Enter
        FocusMe(txtPayYear)
    End Sub

    Private Sub txtPayYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayYear.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtPayYear.Text, False, False)
        Call chk_InpLen(txtPayYear, 4, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtPayYear Then
                cboItmCodeFr.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_txtPayYear() As Boolean
        Chk_txtPayYear = False

        If Trim(txtPayYear.Text) = "" Then
            Chk_txtPayYear = True
            Exit Function
        End If

        If Len(txtPayYear.Text) <> 4 Then
            gsMsg = "年份必須為四位數, 請重新輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtPayYear.Focus()
            Exit Function
        End If

        If CDbl(txtPayYear.Text) < To_Value(1990) Or To_Value(txtPayYear) > CDbl(VB6.Format(gsSystemDate, "YYYY")) Then
            gsMsg = "年份錯誤, 請重新輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtPayYear.Focus()
            Exit Function
        End If

        Chk_txtPayYear = True
    End Function

    Private Sub txtPayYear_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayYear.Leave
        FocusMe(txtPayYear, True)
    End Sub

    Private Sub cboItmTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmTypeCodeFr

        wsSql = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC") & " FROM MstItemType WHERE ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeFr.Text)) & "%' AND ItmTypeStatus <>'2' "
        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboItmTypeCodeFr.Left)), VB6.PixelsToTwipsY(cboItmTypeCodeFr.Top) + VB6.PixelsToTwipsY(cboItmTypeCodeFr.Height), tblCommon, wsFormID, "TBLITMTYPECODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Enter
        FocusMe(cboItmTypeCodeFr)
        wcCombo = cboItmTypeCodeFr
    End Sub

    Private Sub cboItmTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmTypeCodeFr, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboItmTypeCodeFr.Text) <> "" And Trim(cboItmTypeCodeTo.Text) = "" Then
                cboItmTypeCodeTo.Text = cboItmTypeCodeFr.Text
            End If

            cboItmTypeCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Leave
        FocusMe(cboItmTypeCodeFr, True)
    End Sub

    Private Sub cboItmTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmTypeCodeTo

        wsSql = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC") & " FROM MstItemType WHERE ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeTo.Text)) & "%' AND ItmTypeStatus <>'2' "
        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboItmTypeCodeTo.Left)), VB6.PixelsToTwipsY(cboItmTypeCodeTo.Top) + VB6.PixelsToTwipsY(cboItmTypeCodeTo.Height), tblCommon, wsFormID, "TBLITMTYPECODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Enter
        FocusMe(cboItmTypeCodeTo)
        wcCombo = cboItmTypeCodeTo
    End Sub

    Private Sub cboItmTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmTypeCodeTo, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmTypeCodeTo = False Then
                cboItmTypeCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboLevelCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Leave
        FocusMe(cboItmTypeCodeTo, True)
    End Sub

    Private Sub cboLevelCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLevelCodeFr.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboLevelCodeFr

        wsSql = "SELECT ITEMCLASSCODE, " & IIf(gsLangID = "1", "ITEMCLASSEDESC", "ITEMCLASSCDESC") & " "
        wsSql = wsSql & " FROM MSTITEMCLASS "
        wsSql = wsSql & " WHERE ITEMCLASSCODE LIKE '%" & IIf(cboLevelCodeFr.SelectionLength > 0, "", Set_Quote(cboLevelCodeFr.Text)) & "%' "

        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboLevelCodeFr.Left)), VB6.PixelsToTwipsY(cboLevelCodeFr.Top) + VB6.PixelsToTwipsY(cboLevelCodeFr.Height), tblCommon, wsFormID, "TBLLEVELCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboLevelCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLevelCodeFr.Enter
        FocusMe(cboLevelCodeFr)
        wcCombo = cboLevelCodeFr
    End Sub

    Private Sub cboLevelCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboLevelCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboLevelCodeFr, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboLevelCodeFr.Text) <> "" And Trim(cboLevelCodeTo.Text) = "" Then
                cboLevelCodeTo.Text = cboLevelCodeFr.Text
            End If

            cboLevelCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboLevelCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLevelCodeFr.Leave
        FocusMe(cboLevelCodeFr, True)
    End Sub

    Private Sub cboLevelCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLevelCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboLevelCodeTo

        wsSql = "SELECT ITEMCLASSCODE, " & IIf(gsLangID = "1", "ITEMCLASSEDESC", "ITEMCLASSCDESC") & " "
        wsSql = wsSql & " FROM MSTITEMCLASS "
        wsSql = wsSql & " WHERE ITEMCLASSCODE LIKE '%" & IIf(cboLevelCodeTo.SelectionLength > 0, "", Set_Quote(cboLevelCodeTo.Text)) & "%' "

        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboLevelCodeTo.Left)), VB6.PixelsToTwipsY(cboLevelCodeTo.Top) + VB6.PixelsToTwipsY(cboLevelCodeTo.Height), tblCommon, wsFormID, "TBLLEVELCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboLevelCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLevelCodeTo.Enter
        FocusMe(cboLevelCodeTo)
        wcCombo = cboLevelCodeTo
    End Sub

    Private Sub cboLevelCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboLevelCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboLevelCodeTo, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboLevelCodeTo = False Then
                cboLevelCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboAccTypeCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboLevelCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLevelCodeTo.Leave
        FocusMe(cboLevelCodeTo, True)
    End Sub

    Private Sub cboAccTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCodeFr.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboAccTypeCodeFr

        wsSql = "SELECT AccTypeCode, AccTypeDesc FROM MstAccountType WHERE AccTypeCode LIKE '%" & IIf(cboAccTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboAccTypeCodeFr.Text)) & "%' AND AccTypeStatus <>'2' "
        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboAccTypeCodeFr.Left)), VB6.PixelsToTwipsY(cboAccTypeCodeFr.Top) + VB6.PixelsToTwipsY(cboAccTypeCodeFr.Height), tblCommon, wsFormID, "TBLACCTYPECODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboAccTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCodeFr.Enter
        FocusMe(cboAccTypeCodeFr)
        wcCombo = cboAccTypeCodeFr
    End Sub

    Private Sub cboAccTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccTypeCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccTypeCodeFr, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboAccTypeCodeFr.Text) <> "" And Trim(cboAccTypeCodeTo.Text) = "" Then
                cboAccTypeCodeTo.Text = cboAccTypeCodeFr.Text
            End If

            cboAccTypeCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboAccTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCodeFr.Leave
        FocusMe(cboAccTypeCodeFr, True)
    End Sub

    Private Sub cboAccTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboAccTypeCodeTo

        wsSql = "SELECT AccTypeCode, AccTypeDesc FROM MstAccountType WHERE AccTypeCode LIKE '%" & IIf(cboAccTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboAccTypeCodeTo.Text)) & "%' AND AccTypeStatus <>'2' "
        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboAccTypeCodeTo.Left)), VB6.PixelsToTwipsY(cboAccTypeCodeTo.Top) + VB6.PixelsToTwipsY(cboAccTypeCodeTo.Height), tblCommon, wsFormID, "TBLACCTYPECODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboAccTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCodeTo.Enter
        FocusMe(cboAccTypeCodeTo)
        wcCombo = cboAccTypeCodeTo
    End Sub

    Private Sub cboAccTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccTypeCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccTypeCodeTo, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboAccTypeCodeTo = False Then
                cboAccTypeCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboCusNoFr.Focus()
            'Call Opt_Setfocus(optBy, 3, 0)
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboAccTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCodeTo.Leave
        FocusMe(cboAccTypeCodeTo, True)
    End Sub

    Private Function chk_cboItmTypeCodeTo() As Boolean
        chk_cboItmTypeCodeTo = False

        If UCase(cboItmTypeCodeFr.Text) > UCase(cboItmTypeCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboItmTypeCodeTo = True
    End Function

    Private Function chk_cboLevelCodeTo() As Boolean
        chk_cboLevelCodeTo = False

        If UCase(cboLevelCodeFr.Text) > UCase(cboLevelCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboLevelCodeTo = True
    End Function

    Private Function chk_cboAccTypeCodeTo() As Boolean
        chk_cboAccTypeCodeTo = False

        If UCase(cboAccTypeCodeFr.Text) > UCase(cboAccTypeCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboAccTypeCodeTo = True
    End Function

    Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wsSql = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
        wsSql = wsSql & " ORDER BY Cuscode "

        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wsSql = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
        wsSql = wsSql & " ORDER BY Cuscode "

        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboCusNoTo.Left)), VB6.PixelsToTwipsY(cboCusNoTo.Top) + VB6.PixelsToTwipsY(cboCusNoTo.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
                cboCusNoTo.Focus()
                GoTo EventExitSub
            End If

            Call Opt_Setfocus(optSel, 5, 0)
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
	
	Private Function GetOptBy() As String
		Dim iCounter As Short
		
		For iCounter = 0 To 2
			If optBy(iCounter).Checked = True Then
				Exit For
			End If
		Next 
		
		Select Case iCounter
			Case 0
				GetOptBy = "3"
				
			Case 1
				GetOptBy = "2"
				
			Case 2
				GetOptBy = "1"
		End Select
	End Function
End Class