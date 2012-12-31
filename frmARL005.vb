Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmARL005
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Dim wlMonthID As Short
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboCusNoFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wsBaseCurCd As String
		
		If InputValidation = False Then Exit Sub
		
		wsBaseCurCd = Get_CompanyFlag("CMPCURR")
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(5)
		wsSelection(1) = lblCusNoFr.Text & " " & Set_Quote(cboCusNoFr.Text) & " " & lblCusNoTo.Text & " " & Set_Quote(cboCusNoTo.Text)
		wsSelection(2) = lblStartMn.Text & " " & Set_Quote(medStartMn.Text)
		wsSelection(3) = lblAsAt.Text & " " & Set_Quote(medAsAt.Text)
		wsSelection(4) = chkZero.Text & " " & IIf(chkZero.CheckState = 1, "Y", "N")
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTARL005 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSQL = wsSQL & "'', "
		wsSQL = wsSQL & "'" & Set_Quote(medStartMn.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(medAsAt.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(chkZero.CheckState = 1, "Y", "N") & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTARL005"
		Else
			wsRptName = "RPTARL005"
		End If
		
		If chkPgeBrk.CheckState = 1 Then
			wsRptName = wsRptName & "P"
		End If
		
		
		NewfrmPrint.ReportID = "ARL005"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "ARL005"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub cboCusNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Leave
		FocusMe(cboCusNoTo, True)
	End Sub
	
	Private Sub chkZero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkZero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboCusNoFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub chkPgeBrk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkPgeBrk.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboCusNoFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub frmARL005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmARL005_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "ARL005"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboCusNoFr.Text = ""
        cboCusNoTo.Text = ""

        SetDateMask(medAsAt)
        SetDateMask(medStartMn)


        medAsAt.Text = gsSystemDate
        medStartMn.Text = VB.Left(gsSystemDate, 8) & "01"
        '  chkZero.Value = 1

        wgsTitle = "CUSTOMER LEDGER"

    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboCusNoTo = False Then
            cboCusNoTo.Focus()
            Exit Function
        End If

        If Chk_medAsAt = False Then
            Exit Function
        End If

        If Chk_medStartMn = False Then
            Exit Function
        End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmARL005.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmARL005_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmARL005_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmARL005 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub

    Private Sub medAsAt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medAsAt.Enter
        FocusMe(medAsAt)
    End Sub

    Private Sub medAsAt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medAsAt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Chk_medAsAt Then
                medStartMn.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub medAsAt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medAsAt.Leave
        FocusMe(medAsAt, True)
    End Sub

    Private Function Chk_medAsAt() As Boolean
        Chk_medAsAt = False

        If Trim(medAsAt.Text) = "/  /" Then
            gsMsg = "必需輸入日期!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medAsAt.Focus()
            Exit Function
        End If

        If Chk_Date(medAsAt) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medAsAt.Focus()
            Exit Function
        End If

        Chk_medAsAt = True
    End Function

    Private Sub medStartMn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medStartMn.Enter
        FocusMe(medStartMn)
    End Sub

    Private Sub medStartMn_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medStartMn.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Chk_medStartMn Then
                chkZero.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub medStartMn_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medStartMn.Leave
        FocusMe(medStartMn, True)
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

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then wcCombo.Focus()

    End Sub

    Private Sub Ini_Caption()
        Call Get_Scr_Item(wsFormID, waScrItm)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
        lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
        lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")



        lblAsAt.Text = Get_Caption(waScrItm, "ASAT")
        lblStartMn.Text = Get_Caption(waScrItm, "STARTMN")
        chkZero.Text = Get_Caption(waScrItm, "ZERO")
        chkPgeBrk.Text = Get_Caption(waScrItm, "PGEBRK")

        txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
        lblTitle.Text = Get_Caption(waScrItm, "TITLE")

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

    Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCusNoFr

        wsSQL = "SELECT CusCode, CusName "
        wsSQL = wsSQL & " FROM MstCustomer "
        wsSQL = wsSQL & " WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
        wsSQL = wsSQL & " AND CusStatus ='1' "
        wsSQL = wsSQL & " AND CusInactive = 'N' "
        wsSQL = wsSQL & " ORDER BY CusCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCusNoTo

        wsSQL = "SELECT CusCode, CusName "
        wsSQL = wsSQL & " FROM MstCustomer "
        wsSQL = wsSQL & " WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
        wsSQL = wsSQL & " AND CusStatus ='1' "
        wsSQL = wsSQL & " AND CusInactive = 'N' "
        wsSQL = wsSQL & " ORDER BY CusCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoTo.Left)), VB6.PixelsToTwipsY(cboCusNoTo.Top) + VB6.PixelsToTwipsY(cboCusNoTo.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
                Call cboCusNoTo_Enter(cboCusNoTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            medAsAt.Focus()
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

            cboCusNoFr.Focus()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
	
	Private Function Chk_medStartMn() As Boolean
		Chk_medStartMn = False
		
		If Trim(medStartMn.Text) = "/  /" Then
			gsMsg = "必需輸入日期!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medStartMn.Focus()
			Exit Function
		End If
		
		If Chk_Date(medStartMn) = False Then
			gsMsg = "日期錯誤!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medStartMn.Focus()
			Exit Function
		End If
		
		Chk_medStartMn = True
	End Function
End Class