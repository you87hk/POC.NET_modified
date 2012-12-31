Option Strict Off
Option Explicit On
Friend Class frmPT002
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
		cboPackTypeCodeFr.Focus()
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
		wsSelection(1) = lblPackTypeCodeFr.Text & " " & Set_Quote(cboPackTypeCodeFr.Text) & " " & lblPackTypeCodeTo.Text & " " & Set_Quote(cboPackTypeCodeTo.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTPT002 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboPackTypeCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboPackTypeCodeTo.Text) = "", New String("z", 10), Set_Quote(cboPackTypeCodeTo.Text)) & "', "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTPT002"
		Else
			wsRptName = "RPTPT002"
		End If
		
		NewfrmPrint.ReportID = "PT002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "PT002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboPackTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPackTypeCodeFr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboPackTypeCodeFr
		
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT PackTypeCode, PackTypeDesc FROM MstPackingType WHERE PackTypeCode LIKE '%" & IIf(cboPackTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboPackTypeCodeFr.Text)) & "%' AND PackTypeStatus <>'2' "
			Case "2"
				wsSql = "SELECT PackTypeCode, PackTypeDesc FROM MstPackingType WHERE PackTypeCode LIKE '%" & IIf(cboPackTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboPackTypeCodeFr.Text)) & "%' AND PackTypeStatus <>'2' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY PackTypeCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboPackTypeCodeFr.Left)), VB6.PixelsToTwipsY(cboPackTypeCodeFr.Top) + VB6.PixelsToTwipsY(cboPackTypeCodeFr.Height), tblCommon, wsFormID, "TBLPTCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboPackTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPackTypeCodeFr.Enter
		FocusMe(cboPackTypeCodeFr)
		wcCombo = cboPackTypeCodeFr
	End Sub
	
	Private Sub cboPackTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPackTypeCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboPackTypeCodeFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboPackTypeCodeFr.Text) <> "" And Trim(cboPackTypeCodeTo.Text) = "" Then

                cboPackTypeCodeTo.Text = cboPackTypeCodeFr.Text
            End If
            cboPackTypeCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboPackTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPackTypeCodeFr.Leave
        FocusMe(cboPackTypeCodeFr, True)
    End Sub

    Private Sub cboPackTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPackTypeCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboPackTypeCodeTo

        Select Case gsLangID
            Case "1"
                wsSql = "SELECT PackTypeCode, PackTypeDesc FROM MstPackingType WHERE PackTypeCode LIKE '%" & IIf(cboPackTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboPackTypeCodeTo.Text)) & "%' AND PackTypeStatus <>'2' "
            Case "2"
                wsSql = "SELECT PackTypeCode, PackTypeDesc FROM MstPackingType WHERE PackTypeCode LIKE '%" & IIf(cboPackTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboPackTypeCodeTo.Text)) & "%' AND PackTypeStatus <>'2' "
            Case Else

        End Select

        wsSql = wsSql & " ORDER BY PackTypeCode "
        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboPackTypeCodeTo.Left)), VB6.PixelsToTwipsY(cboPackTypeCodeTo.Top) + VB6.PixelsToTwipsY(cboPackTypeCodeTo.Height), tblCommon, wsFormID, "TBLPTCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboPackTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPackTypeCodeTo.Enter
        FocusMe(cboPackTypeCodeTo)
        wcCombo = cboPackTypeCodeTo
    End Sub

    Private Sub cboPackTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPackTypeCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboPackTypeCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboPackTypeCodeTo = False Then
                cboPackTypeCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboPackTypeCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboPackTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPackTypeCodeTo.Leave
        FocusMe(cboPackTypeCodeTo, True)
    End Sub

    Private Sub frmPT002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmPT002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "PT002"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboPackTypeCodeFr.Text = ""
        cboPackTypeCodeTo.Text = ""

        wgsTitle = "Packing Type List"

    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboPackTypeCodeTo = False Then
            cboPackTypeCodeTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmPT002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmPT002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmPT002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmPT002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        Me.lblPackTypeCodeFr.Text = Get_Caption(waScrItm, "PTCODEFR")
        lblPackTypeCodeTo.Text = Get_Caption(waScrItm, "PTCODETO")

    End Sub

    Private Function chk_cboPackTypeCodeTo() As Boolean
        chk_cboPackTypeCodeTo = False

        If UCase(cboPackTypeCodeFr.Text) > UCase(cboPackTypeCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboPackTypeCodeTo = True
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

            cboPackTypeCodeFr.Focus()
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