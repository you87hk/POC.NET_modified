Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSOP003
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
		cboCusCode.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wiSel As Short
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(3)
		wsSelection(1) = lblCusCode.Text & " " & Set_Quote(cboCusCode.Text) & " " & lblCusCodeTo.Text & " " & Set_Quote(cboCusCodeTo.Text)
		wsSelection(2) = lblItmTypeCode.Text & " " & Set_Quote(cboItmTypeCode.Text) & " " & lblCusCodeTo.Text & " " & Set_Quote(cboItmTypeCodeTo.Text)
		
		wiSel = Opt_Getfocus(optBy, 3, 0)
		
		If wiSel = 2 Then
			wsSelection(3) = optBy(2).Text & " " & Set_Quote(txtPayYear.Text)
		ElseIf wiSel = 1 Then 
			wsSelection(3) = optBy(1).Text & " " & Set_Quote(txtPayQuarter.Text)
		ElseIf wiSel = 0 Then 
			wsSelection(3) = optBy(0).Text & " " & Set_Quote(txtPayMonth.Text)
		End If
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTSOP003 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusCode.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusCodeTo.Text) = "", New String("z", 10), Set_Quote(cboCusCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmTypeCode.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmTypeCodeTo.Text) = "", New String("z", 10), Set_Quote(cboItmTypeCodeTo.Text)) & "', "
		wsSQL = wsSQL & wiSel & ", "
		If wiSel = 2 Then
			wsSQL = wsSQL & Set_Quote(txtPayYear.Text) & ", "
		ElseIf wiSel = 1 Then 
			wsSQL = wsSQL & Set_Quote(txtPayQuarter.Text) & ", "
		ElseIf wiSel = 0 Then 
			wsSQL = wsSQL & Set_Quote(txtPayMonth.Text) & ", "
		End If
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSOP003"
		Else
			wsRptName = "RPTSOP003"
		End If
		
		NewfrmPrint.ReportID = "SOP003"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "SOP003"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCusCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCusCode
		
		wsSQL = "SELECT CusCode, CusName FROM MstCustomer WHERE CusCode LIKE '%" & IIf(cboCusCode.SelectionLength > 0, "", Set_Quote(cboCusCode.Text)) & "%' AND CusStatus <>'2' "
		wsSQL = wsSQL & " AND CusInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY CusCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusCode.Left)), VB6.PixelsToTwipsY(cboCusCode.Top) + VB6.PixelsToTwipsY(cboCusCode.Height), tblCommon, wsFormID, "TBLCusCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCusCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCode.Enter
		FocusMe(cboCusCode)
		wcCombo = cboCusCode
	End Sub
	
	Private Sub cboCusCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboCusCode.Text) <> "" And Trim(cboCusCodeTo.Text) = "" Then

                cboCusCodeTo.Text = cboCusCode.Text
            End If

            cboCusCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCusCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCode.Leave
        FocusMe(cboCusCode, True)
    End Sub

    Private Sub cboCusCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCusCodeTo

        wsSQL = "SELECT CusCode, CusName FROM MstCustomer WHERE CusCode LIKE '%" & IIf(cboCusCodeTo.SelectionLength > 0, "", Set_Quote(cboCusCodeTo.Text)) & "%' AND CusStatus <>'2' "
        wsSQL = wsSQL & " AND CusInactive = 'N' "
        wsSQL = wsSQL & " ORDER BY CusCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusCodeTo.Left)), VB6.PixelsToTwipsY(cboCusCodeTo.Top) + VB6.PixelsToTwipsY(cboCusCodeTo.Height), tblCommon, wsFormID, "TBLCusCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCusCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCodeTo.Enter
        FocusMe(cboCusCodeTo)
        wcCombo = cboCusCodeTo
    End Sub

    Private Sub cboCusCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCusCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboCusCodeTo = False Then
                cboCusCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboItmTypeCode.Focus()
            ' Call Opt_Setfocus(optBy, 3, 0)
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCusCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCodeTo.Leave
        FocusMe(cboCusCodeTo, True)
    End Sub

    Private Function chk_cboCusCodeTo() As Boolean
        chk_cboCusCodeTo = False

        If UCase(cboCusCode.Text) > UCase(cboCusCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboCusCodeTo = True
    End Function

    Private Sub frmSOP003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmSOP003_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "SOP003"

    End Sub

    Private Sub Ini_Scr()
        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboCusCode.Text = ""
        cboCusCodeTo.Text = ""
        cboItmTypeCode.Text = ""
        cboItmTypeCodeTo.Text = ""


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

        optBy(0).Checked = True

        wgsTitle = "Sales Report"
    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        'If chk_cboCusCodeTo = False Then
        '    cboCusCodeTo.SetFocus
        '    Exit Function
        'End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmSOP003.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmSOP003_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(4275)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmSOP003_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmSOP003 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub

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

    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        wcCombo.Text = tblCommon.Columns(0).Text
        tblCommon.Visible = False
        wcCombo.Focus()
        System.Windows.Forms.SendKeys.Send("{Enter}")

    End Sub

    Private Sub tblCommon_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCommon.KeyDownEvent

        If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
            tblCommon.Visible = False
            wcCombo.Focus()
        ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
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
        lblCusCode.Text = Get_Caption(waScrItm, "CusCodefr")
        lblCusCodeTo.Text = Get_Caption(waScrItm, "CusCodeTO")
        lblItmTypeCode.Text = Get_Caption(waScrItm, "ItmTypeCodefr")
        lblItmTypeCodeTo.Text = Get_Caption(waScrItm, "ItmTypeCodeTO")

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
                cboCusCode.Focus()
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

    Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
        FocusMe(txtTitle)
    End Sub

    Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtTitle, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboCusCode.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
        FocusMe(txtTitle, True)
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
                cboCusCode.Focus()
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
                cboCusCode.Focus()
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

    Private Function GetPrd() As String
        Dim iCounter As Short

        For iCounter = 0 To 2
            If Me.optBy(iCounter).Checked = True Then
                Exit For
            End If
        Next

        Select Case iCounter
            Case 0
                GetPrd = "3"

            Case 1
                GetPrd = "2"

            Case 2
                GetPrd = "1"
        End Select

    End Function

    Private Sub cboItmTypeCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmTypeCode

        wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC")
        wsSQL = wsSQL & " FROM MstItemType WHERE ItmTypeCode LIKE '%" & IIf(cboItmTypeCode.SelectionLength > 0, "", Set_Quote(cboItmTypeCode.Text)) & "%' AND ItmTypeStatus <>'2' "
        wsSQL = wsSQL & " ORDER BY ItmTypeCode "

        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeCode.Left)), VB6.PixelsToTwipsY(cboItmTypeCode.Top) + VB6.PixelsToTwipsY(cboItmTypeCode.Height), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmTypeCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCode.Enter
        FocusMe(cboItmTypeCode)
        wcCombo = cboItmTypeCode
    End Sub

    Private Sub cboItmTypeCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmTypeCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboItmTypeCode.Text) <> "" And Trim(cboItmTypeCodeTo.Text) = "" Then

                cboItmTypeCodeTo.Text = cboItmTypeCode.Text
            End If

            cboItmTypeCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmTypeCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCode.Leave
        FocusMe(cboItmTypeCode, True)
    End Sub

    Private Sub cboItmTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmTypeCodeTo

        wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC")
        wsSQL = wsSQL & " FROM MstItemType WHERE ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeTo.Text)) & "%' AND ItmTypeStatus <>'2' "
        wsSQL = wsSQL & " ORDER BY ItmTypeCode "

        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeCodeTo.Left)), VB6.PixelsToTwipsY(cboItmTypeCodeTo.Top) + VB6.PixelsToTwipsY(cboItmTypeCodeTo.Height), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
        Call chk_InpLen(cboItmTypeCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmTypeCodeTo = False Then
                cboItmTypeCodeTo.Focus()
                GoTo EventExitSub
            End If

            Call Opt_Setfocus(optBy, 3, 0)
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
	
	Private Function chk_cboItmTypeCodeTo() As Boolean
		chk_cboItmTypeCodeTo = False
		
		If UCase(cboItmTypeCode.Text) > UCase(cboItmTypeCodeTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboItmTypeCodeTo = True
	End Function
End Class