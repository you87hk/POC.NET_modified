Option Strict Off
Option Explicit On
Friend Class frmPR002
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
		cboPrcCodeFr.Focus()
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
		wsSelection(1) = lblPrcCodeFr.Text & " " & Set_Quote(cboPrcCodeFr.Text) & " " & lblPrcCodeTo.Text & " " & Set_Quote(cboPrcCodeTo.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSql = "EXEC usp_RPTPR002 '" & Set_Quote(gsUserID) & "', "
		wsSql = wsSql & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSql = wsSql & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSql = wsSql & "'" & Set_Quote(cboPrcCodeFr.Text) & "', "
		wsSql = wsSql & "'" & IIf(Trim(cboPrcCodeTo.Text) = "", New String("z", 10), Set_Quote(cboPrcCodeTo.Text)) & "', "
		wsSql = wsSql & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTPR002"
		Else
			wsRptName = "RPTPR002"
		End If
		
		NewfrmPrint.ReportID = "PR002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "PR002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSql
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboPrcCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCodeFr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboPrcCodeFr
		
		Select Case gsLangID
			Case "1"
				wsSql = "SELECT PrcCode, PrcDesc FROM MstPriceTerm WHERE PrcCode LIKE '%" & IIf(cboPrcCodeFr.SelectionLength > 0, "", Set_Quote(cboPrcCodeFr.Text)) & "%' AND PrcStatus <>'2' "
			Case "2"
				wsSql = "SELECT PrcCode, PrcDesc FROM MstPriceTerm WHERE PrcCode LIKE '%" & IIf(cboPrcCodeFr.SelectionLength > 0, "", Set_Quote(cboPrcCodeFr.Text)) & "%' AND PrcStatus <>'2' "
			Case Else
				
		End Select
		
		wsSql = wsSql & " ORDER BY PrcCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboPrcCodeFr.Left)), VB6.PixelsToTwipsY(cboPrcCodeFr.Top) + VB6.PixelsToTwipsY(cboPrcCodeFr.Height), tblCommon, wsFormID, "TBLPrcCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboPrcCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCodeFr.Enter
		FocusMe(cboPrcCodeFr)
		wcCombo = cboPrcCodeFr
	End Sub
	
	Private Sub cboPrcCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPrcCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboPrcCodeFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboPrcCodeFr.Text) <> "" And Trim(cboPrcCodeTo.Text) = "" Then

                cboPrcCodeTo.Text = cboPrcCodeFr.Text
            End If
            cboPrcCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboPrcCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCodeFr.Leave
        FocusMe(cboPrcCodeFr, True)
    End Sub

    Private Sub cboPrcCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCodeTo.DropDown
        Dim wsSql As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboPrcCodeTo

        Select Case gsLangID
            Case "1"
                wsSql = "SELECT PrcCode, PrcDesc FROM MstPriceTerm WHERE PrcCode LIKE '%" & IIf(cboPrcCodeTo.SelectionLength > 0, "", Set_Quote(cboPrcCodeTo.Text)) & "%' AND PrcStatus <>'2' "
            Case "2"
                wsSql = "SELECT PrcCode, PrcDesc FROM MstPriceTerm WHERE PrcCode LIKE '%" & IIf(cboPrcCodeTo.SelectionLength > 0, "", Set_Quote(cboPrcCodeTo.Text)) & "%' AND PrcStatus <>'2' "
            Case Else

        End Select

        wsSql = wsSql & " ORDER BY PrcCode "
        Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboPrcCodeTo.Left)), VB6.PixelsToTwipsY(cboPrcCodeTo.Top) + VB6.PixelsToTwipsY(cboPrcCodeTo.Height), tblCommon, wsFormID, "TBLPrcCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboPrcCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCodeTo.Enter
        FocusMe(cboPrcCodeTo)
        wcCombo = cboPrcCodeTo
    End Sub

    Private Sub cboPrcCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPrcCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboPrcCodeTo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboPrcCodeTo = False Then
                cboPrcCodeTo.Focus()
                GoTo EventExitSub
            End If

            cboPrcCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboPrcCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCodeTo.Leave
        FocusMe(cboPrcCodeTo, True)
    End Sub

    Private Sub frmPR002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmPR002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "PR002"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboPrcCodeFr.Text = ""
        cboPrcCodeTo.Text = ""

        wgsTitle = "Prc Term List"

    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboPrcCodeTo = False Then
            cboPrcCodeTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmPR002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmPR002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmPR002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmPR002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        lblPrcCodeFr.Text = Get_Caption(waScrItm, "PRCCODEFR")
        lblPrcCodeTo.Text = Get_Caption(waScrItm, "PRCCODETO")

    End Sub

    Private Function chk_cboPrcCodeTo() As Boolean
        chk_cboPrcCodeTo = False

        If UCase(cboPrcCodeFr.Text) > UCase(cboPrcCodeTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboPrcCodeTo = True
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

            cboPrcCodeFr.Focus()
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