Option Strict Off
Option Explicit On
Friend Class frmICP001
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
		ReDim wsSelection(4)
		wsSelection(1) = lblItmCodeFr.Text & " " & Set_Quote(cboItmCodeFr.Text) & " " & lblItmCodeTo.Text & " " & Set_Quote(cboItmCodeTo.Text)
		wsSelection(2) = lblICSrcCode.Text & " " & Set_Quote(cboICSrcCode.Text)
		wsSelection(3) = lblICTrnCode.Text & " " & Set_Quote(cboICTrnCode.Text)
		wsSelection(4) = lblICTrnType.Text & " " & Set_Quote(cboICTrnType.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTICP001 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboItmCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), Set_Quote(cboItmCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboICSrcCode.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboICTrnCode.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboICTrnType.Text) & "', "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTICP001"
		Else
			wsRptName = "RPTICP001"
		End If
		
		NewfrmPrint.ReportID = "ICP001"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "ICP001"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmICP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmICP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "ICP001"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboItmCodeFr.Text = ""
		cboItmCodeTo.Text = ""
		cboICSrcCode.Text = ""
		cboICTrnCode.Text = ""
		cboICTrnType.Text = ""
		
		wgsTitle = "Stock Transaction Register"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chk_cboICSRCCode = False Then
			cboICSrcCode.Focus()
			Exit Function
		End If
		
		If chk_cboICTrnCode = False Then
			cboICTrnCode.Focus()
			Exit Function
		End If
		
		If Chk_cboICTrnType = False Then
			cboICTrnType.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmICP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmICP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmICP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmICP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
		
		lblICSrcCode.Text = Get_Caption(waScrItm, "ICSRCCODE")
		lblICTrnCode.Text = Get_Caption(waScrItm, "ICTRNCODE")
		lblICTrnType.Text = Get_Caption(waScrItm, "ICTRNTYPE")
		
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

        wsSql = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & " "
        wsSql = wsSql & " FROM mstItem "
        wsSql = wsSql & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
        wsSql = wsSql & " AND ItmSTATUS = '1' "
        wsSql = wsSql & " ORDER BY ItmCode "

        Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboItmCodeFr.Left)), VB6.PixelsToTwipsY(cboItmCodeFr.Top) + VB6.PixelsToTwipsY(cboItmCodeFr.Height), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

        wsSql = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & " "
        wsSql = wsSql & " FROM mstItem "
        wsSql = wsSql & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
        wsSql = wsSql & " AND ItmSTATUS = '1' "
        wsSql = wsSql & " ORDER BY ItmCode "

        Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboItmCodeTo.Left)), VB6.PixelsToTwipsY(cboItmCodeTo.Top) + VB6.PixelsToTwipsY(cboItmCodeTo.Height), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
                Call cboItmCodeTo_Enter(cboItmCodeTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            cboICSrcCode.Focus()
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
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboItmCodeTo = True
    End Function

    Private Sub cboICSRCCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICSRCCode.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsSql = "SELECT ICSRCCODE, SCDDESC "
        wsSql = wsSql & " FROM ICINVENTORY, SYSCODEDESC "
        wsSql = wsSql & " WHERE SCDLANGID = " & gsLangID
        wsSql = wsSql & " AND SCDCODE = ICSRCCODE "
        wsSql = wsSql & " GROUP BY ICSRCCODE, SCDDESC "

        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboICSrcCode.Left)), VB6.PixelsToTwipsY(cboICSrcCode.Top) + VB6.PixelsToTwipsY(cboICSrcCode.Height), tblCommon, wsFormID, "TBLICSRCCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboICSRCCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICSRCCode.Enter
        FocusMe(cboICSrcCode)
        wcCombo = cboICSrcCode
    End Sub

    Private Sub cboICSRCCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboICSRCCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboICSrcCode, 10, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboICSRCCode = False Then GoTo EventExitSub

            cboICTrnCode.Text = ""
            cboICTrnCode.Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub cboICSRCCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICSRCCode.Leave
        FocusMe(cboICSrcCode, True)
    End Sub

    Private Sub cboICTrnCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICTrnCode.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboICTrnCode

        wsSql = "SELECT ICTRNCODE, SCDDESC "
        wsSql = wsSql & " FROM ICINVENTORY, SYSCODEDESC "
        wsSql = wsSql & " WHERE SCDLANGID = " & gsLangID
        wsSql = wsSql & " AND ICSRCCODE = '" & Set_Quote(cboICSrcCode.Text) & "'"
        wsSql = wsSql & " AND SCDCODE = ICTRNCODE "
        wsSql = wsSql & " GROUP BY ICTRNCODE, SCDDESC "


        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboICTrnCode.Left)), VB6.PixelsToTwipsY(cboICTrnCode.Top) + VB6.PixelsToTwipsY(cboICTrnCode.Height), tblCommon, wsFormID, "TBLICTRNCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboICTrnCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICTrnCode.Enter
        FocusMe(cboICTrnCode)
        wcCombo = cboICTrnCode
    End Sub

    Private Sub cboICTrnCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboICTrnCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboICTrnCode, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboICTrnCode = False Then GoTo EventExitSub

            cboICTrnType.Text = ""
            cboICTrnType.Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboICTrnCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICTrnCode.Leave
        FocusMe(cboICTrnCode, True)
    End Sub

    Private Function chk_cboICTrnCode() As Boolean
        chk_cboICTrnCode = False

        If Trim(cboICTrnCode.Text) = "" Then
            gsMsg = "Must Input Transaction Code!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboICTrnCode.Focus()
            Exit Function
        End If

        chk_cboICTrnCode = True
    End Function

    Private Sub cboICTrnType_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICTrnType.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboICTrnType

        wsSql = "SELECT ICTRNTYPE, SCDDESC "
        wsSql = wsSql & " FROM ICINVENTORY, SYSCODEDESC "
        wsSql = wsSql & " WHERE SCDLANGID = " & gsLangID
        wsSql = wsSql & " AND ICSRCCODE = '" & Set_Quote(cboICSrcCode.Text) & "'"
        wsSql = wsSql & " AND ICTRNCODE = '" & Set_Quote(cboICTrnCode.Text) & "'"
        wsSql = wsSql & " AND SCDCODE = ICTRNTYPE "
        wsSql = wsSql & " GROUP BY ICTRNTYPE, SCDDESC "

        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboICTrnType.Left)), VB6.PixelsToTwipsY(cboICTrnType.Top) + VB6.PixelsToTwipsY(cboICTrnType.Height), tblCommon, wsFormID, "TBLICTRNTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboICTrnType_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICTrnType.Enter
        FocusMe(cboICTrnType)
        wcCombo = cboICTrnType
    End Sub

    Private Sub cboICTrnType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboICTrnType.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboICTrnType, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboICTrnType = False Then GoTo EventExitSub

            cboItmCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub cboICTrnType_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboICTrnType.Leave
		FocusMe(cboICTrnType, True)
	End Sub
	
	Private Function Chk_cboICTrnType() As Boolean
		Chk_cboICTrnType = False
		
		If Trim(cboICTrnType.Text) = "" Then
			gsMsg = "Must Input Transaction Type!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboICTrnType.Focus()
			Exit Function
		End If
		
		Chk_cboICTrnType = True
	End Function
	
	Private Function chk_cboICSRCCode() As Boolean
		chk_cboICSRCCode = False
		
		If Trim(cboICSrcCode.Text) = "" Then
			gsMsg = "Must IC Source Code!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboICSrcCode.Focus()
			Exit Function
		End If
		
		chk_cboICSRCCode = True
	End Function
End Class