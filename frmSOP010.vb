Option Strict Off
Option Explicit On
Friend Class frmSOP010
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
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(1)
		wsSelection(1) = lblItmCodeFr.Text & " " & Set_Quote(cboItmCodeFr.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTSOP010 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboItmCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), Set_Quote(cboItmCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & To_Value(txtYear) & "', "
		wsSql = wsSql & "'" & To_Value(txtYear) - 1 & "', "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSOP010"
		Else
			wsRptName = "RPTSOP010"
		End If
		
		NewfrmPrint.ReportID = "SOP010"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "SOP010"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmSOP010_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmSOP010_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "SOP010"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboItmCodeFr.Text = ""
		cboItmCodeTo.Text = ""
		txtYear.Text = VB6.Format(gsSystemDate, "YYYY")
		
		wgsTitle = "Sales Profitability Report"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		InputValidation = False
		
		If chk_txtYear = False Then
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	'UPGRADE_WARNING: Event frmSOP010.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmSOP010_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmSOP010_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmSOP010 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
		
		lblItmCodeFr.Text = Get_Caption(waScrItm, "ITMCODEFR")
		lblItmCodeTo.Text = Get_Caption(waScrItm, "ITMCODETO")
		lblYear.Text = Get_Caption(waScrItm, "YEAR")
		
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
	
	Private Sub txtYear_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.Enter
		FocusMe(txtYear)
	End Sub
	
	Private Sub txtYear_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtYear.Text, False, False)
		Call chk_InpLen(txtYear, 4, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_txtYear Then
                cboItmCodeFr.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtYear_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtYear.Leave
        FocusMe(txtYear, True)
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

        wsSql = "SELECT ITMCODE, ITMBARCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", ITMITMTYPECODE "
        wsSql = wsSql & " FROM MstItem "
        wsSql = wsSql & " WHERE ITMCODE LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
        wsSql = wsSql & " AND ITMSTATUS  <> '2' "
        wsSql = wsSql & " ORDER BY ITMCODE "
        Call Ini_Combo(4, wsSql, (VB6.PixelsToTwipsX(cboItmCodeFr.Left)), VB6.PixelsToTwipsY(cboItmCodeFr.Top) + VB6.PixelsToTwipsY(cboItmCodeFr.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Call chk_InpLen(cboItmCodeFr, 30, KeyAscii)

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

        wsSql = "SELECT ITMCODE, ITMBARCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", ITMITMTYPECODE "
        wsSql = wsSql & " FROM MstItem "
        wsSql = wsSql & " WHERE ITMCODE LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
        wsSql = wsSql & " AND ITMSTATUS  <> '2' "
        wsSql = wsSql & " ORDER BY ITMCODE "
        Call Ini_Combo(4, wsSql, (VB6.PixelsToTwipsX(cboItmCodeTo.Left)), VB6.PixelsToTwipsY(cboItmCodeTo.Top) + VB6.PixelsToTwipsY(cboItmCodeTo.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Call chk_InpLen(cboItmCodeTo, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmCodeTo = False Then
                cboItmCodeTo.Focus()
                GoTo EventExitSub
            End If

            txtYear.Focus()
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
	
	Private Function chk_txtYear() As Boolean
		chk_txtYear = False
		
		If Trim(txtYear.Text) = "" Then
			wsMsg = "沒有輸入年份!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtYear.Focus()
			Exit Function
		End If
		
		If Len(Trim(txtYear.Text)) <> 4 Then
			wsMsg = "輸入年份錯誤!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtYear.Focus()
			Exit Function
		End If
		
		chk_txtYear = True
	End Function
End Class