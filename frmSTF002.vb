Option Strict Off
Option Explicit On
Friend Class frmSTF002
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
		cboStaffCodeFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSql As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		Dim wsStaffType As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(2)
		wsSelection(1) = lblStaffCodeFr.Text & " " & Set_Quote(cboStaffCodeFr.Text) & " " & lblStaffCodeTo.Text & " " & Set_Quote(cboStaffCodeTo.Text)
		
		wsStaffType = CStr(Opt_Getfocus(optStaffType, 3, 0))
		
		If wsStaffType = "0" Then
			wsStaffType = "0"
		ElseIf wsStaffType = "1" Then 
			wsStaffType = "01"
		ElseIf wsStaffType = "2" Then 
			wsStaffType = "02"
		End If
		
		wsSelection(2) = lblStaffType.Text & " " & wsStaffType
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTSTF002 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboStaffCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboStaffCodeTo.Text) = "", New String("z", 10), Set_Quote(cboStaffCodeTo.Text)) & "', "
		wsSql = wsSql & "'" & wsStaffType & "', "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSTF002"
		Else
			wsRptName = "RPTSTF002"
		End If
		
		NewfrmPrint.ReportID = "STF002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "STF002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboStaffCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffCodeFr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboStaffCodeFr
		
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT StaffCode, StaffName, StaffType FROM MstStaff WHERE StaffCode LIKE '%" & IIf(cboStaffCodeFr.SelectionLength > 0, "", Set_Quote(cboStaffCodeFr.Text)) & "%' AND StaffStatus <>'2' "
			Case "2"
				wsSql = "SELECT StaffCode, StaffName, StaffType FROM MstStaff WHERE StaffCode LIKE '%" & IIf(cboStaffCodeFr.SelectionLength > 0, "", Set_Quote(cboStaffCodeFr.Text)) & "%' AND StaffStatus <>'2' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY StaffCode "
		Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboStaffCodeFr.Left)), VB6.PixelsToTwipsY(cboStaffCodeFr.Top) + VB6.PixelsToTwipsY(cboStaffCodeFr.Height), tblCommon, wsFormID, "TBLSTAFFCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboStaffCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffCodeFr.Enter
		FocusMe(cboStaffCodeFr)
		wcCombo = cboStaffCodeFr
	End Sub
	
	Private Sub cboStaffCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboStaffCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboStaffCodeFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboStaffCodeFr.Text) <> "" And Trim(cboStaffCodeTo.Text) = "" Then

                cboStaffCodeTo.Text = cboStaffCodeFr.Text
            End If
            cboStaffCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboStaffCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffCodeFr.Leave
        FocusMe(cboStaffCodeFr, True)
    End Sub

    Private Sub cboStaffCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboStaffCodeTo

        Select Case gsLangID
            Case "1"
                wsSql = "SELECT StaffCode, StaffName, StaffType FROM MstStaff WHERE StaffCode LIKE '%" & IIf(cboStaffCodeTo.SelectionLength > 0, "", Set_Quote(cboStaffCodeTo.Text)) & "%' AND StaffStatus <>'2' "
            Case "2"
                wsSql = "SELECT StaffCode, StaffName, StaffType FROM MstStaff WHERE StaffCode LIKE '%" & IIf(cboStaffCodeTo.SelectionLength > 0, "", Set_Quote(cboStaffCodeTo.Text)) & "%' AND StaffStatus <>'2' "
            Case Else

        End Select

        wsSql = wsSql & " ORDER BY StaffCode "
        Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboStaffCodeTo.Left)), VB6.PixelsToTwipsY(cboStaffCodeTo.Top) + VB6.PixelsToTwipsY(cboStaffCodeTo.Height), tblCommon, wsFormID, "TBLSTAFFCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboStaffCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffCodeTo.Enter
        FocusMe(cboStaffCodeTo)
        wcCombo = cboStaffCodeTo
    End Sub

    Private Sub cboStaffCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboStaffCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboStaffCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboStaffCodeTo = False Then
                cboStaffCodeTo.Focus()
                GoTo EventExitSub
            End If

            Call Opt_Setfocus(optStaffType, 3, 0)
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboStaffCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffCodeTo.Leave
        FocusMe(cboStaffCodeTo, True)
    End Sub

    Private Sub frmSTF002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmSTF002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "STF002"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboStaffCodeFr.Text = ""
        cboStaffCodeTo.Text = ""

        optStaffType(0).Checked = True

        wgsTitle = "Staff List"

    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboStaffCodeTo = False Then
            cboStaffCodeTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmSTF002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmSTF002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmSTF002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmSTF002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub

    Private Sub optStaffType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optStaffType.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optStaffType.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cboStaffCodeFr.Focus()
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
        lblStaffCodeFr.Text = Get_Caption(waScrItm, "STAFFCODEFR")
        lblStaffCodeTo.Text = Get_Caption(waScrItm, "STAFFCODETO")

        lblStaffType.Text = Get_Caption(waScrItm, "STAFFTYPE")

        optStaffType(0).Text = Get_Caption(waScrItm, "STAFFTYPE0")
        optStaffType(1).Text = Get_Caption(waScrItm, "STAFFTYPE1")
        optStaffType(2).Text = Get_Caption(waScrItm, "STAFFTYPE2")
    End Sub

    Private Function chk_cboStaffCodeTo() As Boolean
        chk_cboStaffCodeTo = False

        If UCase(cboStaffCodeFr.Text) > UCase(cboStaffCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboStaffCodeTo = True
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

            cboStaffCodeFr.Focus()
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