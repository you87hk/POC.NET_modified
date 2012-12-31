Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmGLP001
	Inherits System.Windows.Forms.Form
	
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboAccNoFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wsCtlFr As String
		Dim wsCtlTo As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsCtlFr = Get_FiscalPeriod(medPrdFr.Text & "/01")
		wsCtlTo = Get_FiscalPeriod(medPrdTo.Text & "/01")
		
		'Create Selection Criteria
		ReDim wsSelection(3)
		wsSelection(1) = lblAccNoFr.Text & " " & Set_Quote(cboAccNoFr.Text) & " " & lblAccNoTo.Text & " " & Set_Quote(cboAccNoTo.Text)
		wsSelection(2) = lblPrdFr.Text & " " & medPrdFr.Text & " " & lblPrdTo.Text & " " & medPrdTo.Text
		wsSelection(3) = lblPrtMrk.Text & " " & IIf(chkPgeBrk.CheckState = 1, "N", "Y")
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTGLP001 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & txtTitle.Text & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboAccNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboAccNoTo.Text) = "", New String("z", 15), Set_Quote(cboAccNoTo.Text)) & "', "
		wsSQL = wsSQL & "'', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "', "
		wsSQL = wsSQL & "'" & wsCtlFr & "', "
		wsSQL = wsSQL & "'" & wsCtlTo & "', "
		wsSQL = wsSQL & "'N', "
		wsSQL = wsSQL & "'N', "
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTGLP001"
		Else
			wsRptName = "RPTGLP001"
		End If
		
		If chkPgeBrk.CheckState = 1 Then wsRptName = wsRptName & "P"
		
		NewfrmPrint.ReportID = "GLP001"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "GLP001"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	
	
	Private Sub cboAccNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccNoTo.Leave
		FocusMe(cboAccNoTo, True)
	End Sub
	
	
	
	Private Sub chkPgeBrk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkPgeBrk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            cboAccNoFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmGLP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmGLP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "GLP001"

    End Sub

    Private Sub Ini_Scr()
        Dim wsCtlPrd As String
        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboAccNoFr.Text = ""
        cboAccNoTo.Text = ""

        Call SetPeriodMask(medPrdFr)
        Call SetPeriodMask(medPrdTo)
        wsCtlPrd = getCtrlMth("GL")
        medPrdFr.Text = VB.Left(wsCtlPrd, 4) & "/" & VB.Right(wsCtlPrd, 2)
        medPrdTo.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))

        chkPgeBrk.CheckState = System.Windows.Forms.CheckState.Checked

    End Sub
    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboAccNoTo = False Then
            cboAccNoTo.Focus()
            Exit Function
        End If



        If chk_medPrdTo = False Then
            medPrdTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function



    'UPGRADE_WARNING: Event frmGLP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmGLP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmGLP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmGLP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub



    Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
        FocusMe(medPrdFr, True)
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
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
        lblAccNoFr.Text = Get_Caption(waScrItm, "ACCNoFR")
        lblAccNoTo.Text = Get_Caption(waScrItm, "ACCNoTO")

        lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
        lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
        lblPrtMrk.Text = Get_Caption(waScrItm, "PRTMRK")
        chkPgeBrk.Text = Get_Caption(waScrItm, "PGEBRK")

        lblTitle.Text = Get_Caption(waScrItm, "LBLTITLE")

        txtTitle.Text = Get_Caption(waScrItm, "TITLE")

        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
    End Sub



    Private Function chk_medPrdFr() As Boolean
        chk_medPrdFr = False


        If Chk_Period(medPrdFr) = False Then
            wsMsg = "Wrong Period!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function

        End If


        If chk_RetPrd(CDate(medPrdFr.Text)) = False Then
            wsMsg = "Period Must > Minimin Date!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function
        End If

        chk_medPrdFr = True
    End Function

    Private Function chk_RetPrd(ByRef inMedDte As Date) As Boolean
        Dim wsStrDte As String
        Dim wsEndDte As String
        Dim wsCtlDte As String
        Dim wiRetValue As Short
        Dim wdMinDte As Date
        chk_RetPrd = False

        wiRetValue = CShort(Get_TableInfo("sysMonCtl", "MCMODNO = 'GL'", "MCKeepMn"))

        wsCtlDte = getCtrlMth("GL", wsStrDte, wsEndDte)
        wdMinDte = DateAdd(Microsoft.VisualBasic.DateInterval.Month, To_Value(wiRetValue) * -1, CDate(wsStrDte))
        If CDate(inMedDte) < wdMinDte Then Exit Function

        chk_RetPrd = True
    End Function

    Private Function chk_medPrdTo() As Boolean
        chk_medPrdTo = False

        If Chk_Period(medPrdTo) = False Then
            wsMsg = "Wrong Period!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdTo.Focus()
            Exit Function
        End If

        If UCase(medPrdFr.Text) > UCase(medPrdTo.Text) Then
            wsMsg = "To must > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdTo.Focus()
            Exit Function
        End If

        If CDate(medPrdFr.Text) > CDate(gsDateTo) Then
            wsMsg = "Period Must < Max Date!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdTo.Focus()
            Exit Function
        End If



        chk_medPrdTo = True
    End Function


    Private Function chk_cboAccNoTo() As Boolean
        chk_cboAccNoTo = False

        If UCase(cboAccNoFr.Text) > UCase(cboAccNoTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboAccNoTo.Focus()
            Exit Function
        End If

        chk_cboAccNoTo = True
    End Function
    Private Sub cboAccNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboAccNoFr

        wsSQL = "SELECT COAACCCODE, " & IIf(gsLangID = "2", "COACDESC", "COADESC") & " "
        wsSQL = wsSQL & " FROM mstCOA "
        wsSQL = wsSQL & " WHERE COAAccCode LIKE '%" & IIf(cboAccNoFr.SelectionLength > 0, "", Set_Quote(cboAccNoFr.Text)) & "%' "
        wsSQL = wsSQL & " AND COASTATUS  <> '2' "
        wsSQL = wsSQL & " ORDER BY COAAccCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboAccNoFr.Left)), VB6.PixelsToTwipsY(cboAccNoFr.Top) + VB6.PixelsToTwipsY(cboAccNoFr.Height), tblCommon, wsFormID, "TBLACCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboAccNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccNoFr.Enter
        FocusMe(cboAccNoFr)
        wcCombo = cboAccNoFr
    End Sub

    Private Sub cboAccNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccNoFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccNoFr, 10, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboAccNoFr.Text) <> "" And Trim(cboAccNoTo.Text) = "" Then
                cboAccNoTo.Text = cboAccNoFr.Text
            End If
            cboAccNoTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboAccNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccNoFr.Leave
        FocusMe(cboAccNoFr, True)
    End Sub

    Private Sub cboAccNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccNoTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboAccNoTo

        wsSQL = "SELECT COAACCCODE, " & IIf(gsLangID = "2", "COACDESC", "COADESC") & " "
        wsSQL = wsSQL & " FROM mstCOA "
        wsSQL = wsSQL & " WHERE COAAccCode LIKE '%" & IIf(cboAccNoTo.SelectionLength > 0, "", Set_Quote(cboAccNoTo.Text)) & "%' "
        wsSQL = wsSQL & " AND COASTATUS  <> '2' "
        wsSQL = wsSQL & " ORDER BY COAAccCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboAccNoTo.Left)), VB6.PixelsToTwipsY(cboAccNoTo.Top) + VB6.PixelsToTwipsY(cboAccNoTo.Height), tblCommon, wsFormID, "TBLAccNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboAccNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccNoTo.Enter
        FocusMe(cboAccNoTo)
        wcCombo = cboAccNoTo
    End Sub

    Private Sub cboAccNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccNoTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccNoTo, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboAccNoTo = False Then
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
            chkPgeBrk.Focus()
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


    Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccNoFr, 50, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            cboAccNoFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
End Class