Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSN002
	Inherits System.Windows.Forms.Form
	
	
	Dim wsFormID As String
	Dim wsTrnCd As String
	
	Dim waScrItm As New XArrayDBObject.XArrayDB
	'Private waScrToolTip As New XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboDocNoFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wsTitle2 As String
		
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(4)
		wsSelection(1) = lblDocNoFr.Text & " " & Set_Quote(cboDocNoFr.Text) & " " & lblDocNoTo.Text & " " & Set_Quote(cboDocNoTo.Text)
		wsSelection(2) = lblCusNoFr.Text & " " & Set_Quote(cboCusNoFr.Text) & " " & lblCusNoTo.Text & " " & Set_Quote(cboCusNoTo.Text)
		wsSelection(3) = lblPrdFr.Text & " " & medPrdFr.Text & " " & lblPrdTo.Text & " " & medPrdTo.Text
		wsSelection(4) = lblPrtMrk.Text & " " & IIf(optPrtMrk(2).Checked = True, "%", IIf(optPrtMrk(0).Checked = True, "N", "Y"))
		
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPT" & wsFormID & " '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & wsTrnCd & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdFr.Text) = "/", "000000", VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdTo.Text) = "/", "999999", VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "', "
		wsSQL = wsSQL & "'" & IIf(optPrtMrk(2).Checked = True, "%", IIf(optPrtMrk(0).Checked = True, "N", "Y")) & "', "
		wsSQL = wsSQL & "'N', "
		wsSQL = wsSQL & gsLangID
		
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPT" & wsFormID
		Else
			wsRptName = "RPT" & wsFormID
		End If
		
		If wsFormID = "SN002" Then
			wsRptName = wsRptName & "A"
		End If
		
		NewfrmPrint.ReportID = wsFormID
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = wsFormID
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case wsTrnCd
			Case "PO", "PV", "PR"
				wsSQL = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
				wsSQL = wsSQL & " ORDER BY Vdrcode "
			Case Else
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
				wsSQL = wsSQL & " ORDER BY Cuscode "
				
		End Select
		
		
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
        Select Case wsTrnCd
            Case "PO", "PV", "PR"
                wsSQL = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
                wsSQL = wsSQL & " ORDER BY Vdrcode "
            Case Else
                wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
                wsSQL = wsSQL & " ORDER BY Cuscode "
        End Select


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

            medPrdFr.Focus()
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

    Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
        FocusMe(cboDocNoTo, True)
    End Sub

    Private Sub frmSN002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmSN002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        '   wsFormID = "SN002"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboDocNoFr.Text = ""
        cboDocNoTo.Text = ""
        cboCusNoFr.Text = ""
        cboCusNoTo.Text = ""
        Call SetPeriodMask(medPrdFr)
        Call SetPeriodMask(medPrdTo)

        'medPrdFr = Left(gsSystemDate, 8) & "01"
        'medPrdTo = Format(DateAdd("D", -1, DateAdd("M", 1, CDate(medPrdFr.Text))), "YYYY/MM/DD")

        optPrtMrk(2).Checked = True

    End Sub
    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboDocNoTo = False Then
            cboDocNoTo.Focus()
            Exit Function
        End If

        If chk_cboCusNoTo = False Then
            cboCusNoTo.Focus()
            Exit Function
        End If


        If chk_medPrdFr = False Then
            medPrdFr.Focus()
            Exit Function
        End If

        If chk_medPrdTo = False Then
            medPrdTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function



    'UPGRADE_WARNING: Event frmSN002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmSN002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmSN002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        '  Set waScrToolTip = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmSN002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub





    Private Sub optPrtMrk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optPrtMrk.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optPrtMrk.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            cboDocNoFr.Focus()
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
        'Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
        lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
        lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
        lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
        lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
        lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
        lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
        lblPrtMrk.Text = Get_Caption(waScrItm, "PRTMRK")
        optPrtMrk(0).Text = Get_Caption(waScrItm, "UNPRINT")
        optPrtMrk(1).Text = Get_Caption(waScrItm, "PRINTED")
        optPrtMrk(2).Text = Get_Caption(waScrItm, "ALL")

        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrItm, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrItm, tcGo) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrItm, tcExit) & "(F12)"

        txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
        lblTitle.Text = Get_Caption(waScrItm, "TITLE")

    End Sub



    Private Function chk_medPrdFr() As Boolean
        chk_medPrdFr = False

        If Trim(medPrdFr.Text) = "/" Then
            chk_medPrdFr = True
            Exit Function
        End If

        If Chk_Period(medPrdFr) = False Then
            wsMsg = "Wrong Period!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function

        End If

        chk_medPrdFr = True
    End Function

    Private Function chk_medPrdTo() As Boolean
        chk_medPrdTo = False

        If UCase(medPrdFr.Text) > UCase(medPrdTo.Text) Then
            wsMsg = "To Must > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        If Trim(medPrdTo.Text) = "/" Then
            chk_medPrdTo = True
            Exit Function
        End If

        If Chk_Period(medPrdTo) = False Then

            wsMsg = "Wrong Period!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function

        End If

        chk_medPrdTo = True
    End Function

    Private Function chk_cboCusNoTo() As Boolean
        chk_cboCusNoTo = False

        If UCase(cboCusNoFr.Text) > UCase(cboCusNoTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_cboCusNoTo = True
    End Function
    Private Function chk_cboDocNoTo() As Boolean
        chk_cboDocNoTo = False

        If UCase(cboDocNoFr.Text) > UCase(cboDocNoTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboDocNoTo = True
    End Function
    Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDocNoFr

        Select Case wsTrnCd
            Case "SN"

                wsSQL = "SELECT SNHDDOCNO, CUSCODE, SNHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSNHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SNHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SNHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SNHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY SNHDDOCNO "

            Case "SO"

                wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SOHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY SOHDDOCNO "

            Case "SP"

                wsSQL = "SELECT SPHDDOCNO, CUSCODE, SPHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSPHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SPHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SPHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SPHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY SPHDDOCNO "

            Case "SD"

                wsSQL = "SELECT SDHDDOCNO, CUSCODE, SDHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSDHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SDHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SDHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SDHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY SDHDDOCNO "

            Case "IV"

                wsSQL = "SELECT IVHDDOCNO, CUSCODE, IVHDDOCDATE "
                wsSQL = wsSQL & " FROM soaIVHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE IVHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND IVHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND IVHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY IVHDDOCNO "

            Case "PO"

                wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPOHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND POHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY POHDDOCNO "


            Case "PV"

                wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPVHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PVHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY PVHDDOCNO "

            Case "GR"

                wsSQL = "SELECT GRHDDOCNO, VDRCODE, GRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPGRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE GRHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND GRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND GRHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY GRHDDOCNO "

            Case "PR"

                wsSQL = "SELECT PRHDDOCNO, VDRCODE, PRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PRHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND PRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PRHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY PRHDDOCNO "

        End Select

        Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboDocNoFr.Left)), VB6.PixelsToTwipsY(cboDocNoFr.Top) + VB6.PixelsToTwipsY(cboDocNoFr.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboDocNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Enter
        FocusMe(cboDocNoFr)
        wcCombo = cboDocNoFr
    End Sub

    Private Sub cboDocNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboDocNoFr, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboDocNoFr.Text) <> "" And Trim(cboDocNoTo.Text) = "" Then
                cboDocNoTo.Text = cboDocNoFr.Text
            End If
            cboDocNoTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboDocNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Leave
        FocusMe(cboDocNoFr, True)
    End Sub

    Private Sub cboDocNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDocNoTo

        Select Case wsTrnCd
            Case "SN"
                wsSQL = "SELECT SNHDDOCNO, CUSCODE, SNHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSNHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SNHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SNHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SNHDSTATUS NOT IN ( '2','3') "
                wsSQL = wsSQL & " ORDER BY SNHDDOCNO "

            Case "SO"
                wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SOHDSTATUS NOT IN ( '2','3') "
                wsSQL = wsSQL & " ORDER BY SOHDDOCNO "

            Case "SP"
                wsSQL = "SELECT SPHDDOCNO, CUSCODE, SPHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSPHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SPHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SPHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SPHDSTATUS NOT IN ( '2','3') "
                wsSQL = wsSQL & " ORDER BY SPHDDOCNO "

            Case "SD"
                wsSQL = "SELECT SDHDDOCNO, CUSCODE, SDHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSDHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SDHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SDHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SDHDSTATUS NOT IN ( '2','3') "
                wsSQL = wsSQL & " ORDER BY SDHDDOCNO "

            Case "IV"
                wsSQL = "SELECT IVHDDOCNO, CUSCODE, IVHDDOCDATE "
                wsSQL = wsSQL & " FROM soaIVHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE IVHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND IVHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND IVHDSTATUS NOT IN ( '2','3') "
                wsSQL = wsSQL & " ORDER BY IVHDDOCNO "

            Case "PO"

                wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPOHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND POHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY POHDDOCNO "


            Case "PV"

                wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPVHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PVHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY PVHDDOCNO "

            Case "GR"

                wsSQL = "SELECT GRHDDOCNO, VDRCODE, GRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPGRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE GRHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND GRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND GRHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY GRHDDOCNO "

            Case "PR"

                wsSQL = "SELECT PRHDDOCNO, VDRCODE, PRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PRHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND PRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PRHDSTATUS NOT IN ('2','3') "
                wsSQL = wsSQL & " ORDER BY PRHDDOCNO "

        End Select

        Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboDocNoTo.Left)), VB6.PixelsToTwipsY(cboDocNoTo.Top) + VB6.PixelsToTwipsY(cboDocNoTo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboDocNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Enter
        FocusMe(cboDocNoTo)
        wcCombo = cboDocNoTo
    End Sub

    Private Sub cboDocNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboDocNoTo, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboDocNoTo = False Then
                Call cboDocNoTo_Enter(cboDocNoTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            cboCusNoFr.Focus()
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
                Call medPrdFr_Enter(medPrdFr, New System.EventArgs())
                GoTo EventExitSub
            End If

            If Trim(medPrdFr.Text) <> "/  /" And Trim(medPrdTo.Text) = "/  /" Then
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

    Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
        FocusMe(medPrdFr, True)
    End Sub

    Private Sub medPrdTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_medPrdTo = False Then
                Call medPrdTo_Enter(medPrdTo, New System.EventArgs())
                GoTo EventExitSub
            End If
            Call Opt_Setfocus(optPrtMrk, 3, 0)
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



    Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
        FocusMe(txtTitle)
    End Sub

    Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtTitle, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            cboDocNoFr.Focus()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
	
	
	Public WriteOnly Property FormID() As String
		Set(ByVal Value As String)
			wsFormID = Value
		End Set
	End Property
	
	
	Public WriteOnly Property TrnCd() As String
		Set(ByVal Value As String)
			wsTrnCd = Value
		End Set
	End Property
End Class