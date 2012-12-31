Option Strict Off
Option Explicit On
Friend Class frmUSR002
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
		cboUsrCodeFr.Focus()
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
		wsSelection(1) = lblUsrCodeFr.Text & " " & Set_Quote(cboUsrCodeFr.Text) & " " & lblUsrCodeTo.Text & " " & Set_Quote(cboUsrCodeTo.Text)
		wsSelection(2) = lblGrpCodeFr.Text & " " & Set_Quote(cboGrpCodeFr.Text) & " " & lblGrpCodeTo.Text & " " & Set_Quote(cboGrpCodeTo.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTUSR002 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboUsrCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboUsrCodeTo.Text) = "", New String("z", 10), Set_Quote(cboUsrCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboGrpCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboGrpCodeTo.Text) = "", New String("z", 10), Set_Quote(cboGrpCodeTo.Text)) & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTUSR002"
		Else
			wsRptName = "RPTUSR002"
		End If
		
		NewfrmPrint.ReportID = "USR002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "USR002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboUsrCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboUsrCodeFr
		
		wsSQL = "SELECT UsrCode, UsrName, UsrGrpCode FROM MstUser WHERE UsrCode LIKE '%" & IIf(cboUsrCodeFr.SelectionLength > 0, "", Set_Quote(cboUsrCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY UsrCode "
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboUsrCodeFr.Left)), VB6.PixelsToTwipsY(cboUsrCodeFr.Top) + VB6.PixelsToTwipsY(cboUsrCodeFr.Height), tblCommon, wsFormID, "TBLUSRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboUsrCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrCodeFr.Enter
		FocusMe(cboUsrCodeFr)
		wcCombo = cboUsrCodeFr
	End Sub
	
	Private Sub cboUsrCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboUsrCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboUsrCodeFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboUsrCodeFr.Text) <> "" And Trim(cboUsrCodeTo.Text) = "" Then

                cboUsrCodeTo.Text = cboUsrCodeFr.Text
            End If
            cboUsrCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboUsrCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrCodeFr.Leave
        FocusMe(cboUsrCodeFr, True)
    End Sub

    Private Sub cboUsrCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboUsrCodeTo

        Select Case gsLangID
            Case "1"
                wsSQL = "SELECT UsrCode, UsrName, UsrGrpCode FROM MstUser WHERE UsrCode LIKE '%" & IIf(cboUsrCodeTo.SelectionLength > 0, "", Set_Quote(cboUsrCodeTo.Text)) & "%' "
            Case "2"
                wsSQL = "SELECT UsrCode, UsrName, UsrGrpCode FROM MstUser WHERE UsrCode LIKE '%" & IIf(cboUsrCodeTo.SelectionLength > 0, "", Set_Quote(cboUsrCodeTo.Text)) & "%' "
            Case Else

        End Select

        wsSQL = wsSQL & " ORDER BY UsrCode "
        Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboUsrCodeTo.Left)), VB6.PixelsToTwipsY(cboUsrCodeTo.Top) + VB6.PixelsToTwipsY(cboUsrCodeTo.Height), tblCommon, wsFormID, "TBLUSRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboUsrCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrCodeTo.Enter
        FocusMe(cboUsrCodeTo)
        wcCombo = cboUsrCodeTo
    End Sub

    Private Sub cboUsrCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboUsrCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboUsrCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboUsrCodeTo = False Then
                cboUsrCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboGrpCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboUsrCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUsrCodeTo.Leave
        FocusMe(cboUsrCodeTo, True)
    End Sub

    Private Sub frmUSR002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmUSR002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "USR002"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboUsrCodeFr.Text = ""
        cboUsrCodeTo.Text = ""
        cboGrpCodeFr.Text = ""
        cboGrpCodeTo.Text = ""

        wgsTitle = "User List"

    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboUsrCodeTo = False Then
            cboUsrCodeTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmUSR002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmUSR002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmUSR002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmUSR002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        lblUsrCodeFr.Text = Get_Caption(waScrItm, "USRCODEFR")
        lblUsrCodeTo.Text = Get_Caption(waScrItm, "USRCODETO")
        lblGrpCodeFr.Text = Get_Caption(waScrItm, "GRPCODEFR")
        lblGrpCodeTo.Text = Get_Caption(waScrItm, "GRPCODETO")

    End Sub

    Private Function chk_cboUsrCodeTo() As Boolean
        chk_cboUsrCodeTo = False

        If UCase(cboUsrCodeFr.Text) > UCase(cboUsrCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboUsrCodeTo = True
    End Function

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

            cboUsrCodeFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
        FocusMe(txtTitle, True)
    End Sub

    Private Sub cboGrpCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCodeFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboGrpCodeFr

        wsSQL = "SELECT DISTINCT UsrGrpCode FROM MstUser WHERE UsrGrpCode LIKE '%" & IIf(cboGrpCodeFr.SelectionLength > 0, "", Set_Quote(cboGrpCodeFr.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY UsrGrpCode "

        Call Ini_Combo(1, wsSQL, (VB6.PixelsToTwipsX(cboGrpCodeFr.Left)), VB6.PixelsToTwipsY(cboGrpCodeFr.Top) + VB6.PixelsToTwipsY(cboGrpCodeFr.Height), tblCommon, wsFormID, "TBLGRPCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboGrpCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCodeFr.Enter
        FocusMe(cboGrpCodeFr)
        wcCombo = cboGrpCodeFr
    End Sub

    Private Sub cboGrpCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboGrpCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboGrpCodeFr, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboGrpCodeFr.Text) <> "" And Trim(cboGrpCodeTo.Text) = "" Then

                cboGrpCodeTo.Text = cboGrpCodeFr.Text
            End If

            cboGrpCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboGrpCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCodeFr.Leave
        FocusMe(cboGrpCodeFr, True)
    End Sub

    Private Sub cboGrpCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboGrpCodeTo

        wsSQL = "SELECT DISTINCT UsrGrpCode FROM MstUser WHERE UsrGrpCode LIKE '%" & IIf(cboGrpCodeTo.SelectionLength > 0, "", Set_Quote(cboGrpCodeTo.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY UsrGrpCode "

        Call Ini_Combo(1, wsSQL, (VB6.PixelsToTwipsX(cboGrpCodeTo.Left)), VB6.PixelsToTwipsY(cboGrpCodeTo.Top) + VB6.PixelsToTwipsY(cboGrpCodeTo.Height), tblCommon, wsFormID, "TBLGRPCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboGrpCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCodeTo.Enter
        FocusMe(cboGrpCodeTo)
        wcCombo = cboGrpCodeTo
    End Sub

    Private Sub cboGrpCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboGrpCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboGrpCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboGrpCodeTo = False Then
                cboGrpCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboUsrCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub cboGrpCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCodeTo.Leave
		FocusMe(cboGrpCodeTo, True)
	End Sub
	
	Private Function chk_cboGrpCodeTo() As Boolean
		chk_cboGrpCodeTo = False
		
		If UCase(cboGrpCodeFr.Text) > UCase(cboGrpCodeTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboGrpCodeTo = True
	End Function
End Class