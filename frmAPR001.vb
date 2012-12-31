Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAPR001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	'Private waScrToolTip As New XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	
	Private wiSort As Short
	Private wsSortBy As String
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wiActFlg As Short
	Private wsMark As String
	Private wsTrnCd As String
	Private wsTitle As String
	
	Private Const tcConvert As String = "Convert"
	Private Const tcCan As String = "Can"
	Private Const tcCopy As String = "Copy"
	Private Const tcFinish As String = "Finish"
	Private Const tcComplete As String = "Complete"
	Private Const tcPrint As String = "Print"
	Private Const tcLock As String = "Lock"
	Private Const tcExport As String = "Export"
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	
	Private Const SSEL As Short = 0
	Private Const SDOCDATE As Short = 1
	Private Const SDOCNO As Short = 2
	Private Const SCUSCODE As Short = 3
	Private Const SCUSNAME As Short = 4
	Private Const SFROMDATE As Short = 5
	Private Const STODATE As Short = 6
	Private Const SQTY As Short = 7
	Private Const SNET As Short = 8
	Private Const SORI As Short = 9
	Private Const SREADY As Short = 10
	Private Const SID As Short = 11
	
	
	
	Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND CusStatus <> '2' "
		wsSQL = wsSQL & " AND CusInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY Cuscode "
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboCusNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboCusNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboCusNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
        wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
        wsSQL = wsSQL & " AND CusStatus <> '2' "
        wsSQL = wsSQL & " AND CusInactive = 'N' "
        wsSQL = wsSQL & " ORDER BY Cuscode "
        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboCusNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboCusNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboCusNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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




    'UPGRADE_WARNING: Event frmAPR001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmAPR001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
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

    Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
        FocusMe(medPrdFr, True)
    End Sub

    Private Sub medPrdTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_medPrdTo = False Then
                GoTo EventExitSub
            End If

            If LoadRecord = True Then
                tblDetail.Focus()
            End If

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
                wsSQL = wsSQL & " AND SNHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SNHDDOCNO "

            Case "SO"

                wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SOHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SOHDDOCNO "

            Case "SP"

                wsSQL = "SELECT SPHDDOCNO, CUSCODE, SPHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSPHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SPHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SPHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SPHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SPHDDOCNO "

            Case "SW"

                wsSQL = "SELECT SWHDDOCNO, CUSCODE, SWHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSWHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SWHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SWHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SWHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SWHDDOCNO "

            Case "SD"

                wsSQL = "SELECT SDHDDOCNO, CUSCODE, SDHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSDHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SDHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND SDHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SDHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SDHDDOCNO "

            Case "IV"

                wsSQL = "SELECT IVHDDOCNO, CUSCODE, IVHDDOCDATE "
                wsSQL = wsSQL & " FROM soaIVHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE IVHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND IVHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND IVHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY IVHDDOCNO "

            Case "VQ"

                wsSQL = "SELECT VQHDDOCNO, CUSCODE, VQHDDOCDATE "
                wsSQL = wsSQL & " FROM soaVQHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE VQHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND VQHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND VQHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY VQHDDOCNO "


        End Select
        Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboDocNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboDocNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
                wsSQL = wsSQL & " AND SNHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SNHDDOCNO "

            Case "SO"

                wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SOHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SOHDDOCNO "

            Case "SP"

                wsSQL = "SELECT SPHDDOCNO, CUSCODE, SPHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSPHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SPHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SPHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SPHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SPHDDOCNO "

            Case "SW"

                wsSQL = "SELECT SWHDDOCNO, CUSCODE, SWHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSWHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SWHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SWHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SWHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SWHDDOCNO "

            Case "SD"

                wsSQL = "SELECT SDHDDOCNO, CUSCODE, SDHDDOCDATE "
                wsSQL = wsSQL & " FROM soaSDHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE SDHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND SDHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND SDHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY SDHDDOCNO "

            Case "IV"

                wsSQL = "SELECT IVHDDOCNO, CUSCODE, IVHDDOCDATE "
                wsSQL = wsSQL & " FROM soaIVHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE IVHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND IVHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND IVHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY IVHDDOCNO "

            Case "VQ"

                wsSQL = "SELECT VQHDDOCNO, CUSCODE, VQHDDOCDATE "
                wsSQL = wsSQL & " FROM soaVQHD, mstCUSTOMER "
                wsSQL = wsSQL & " WHERE VQHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND VQHDCUSID  = CUSID "
                wsSQL = wsSQL & " AND VQHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY VQHDDOCNO "


        End Select

        Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboDocNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboDocNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

    Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
        FocusMe(cboDocNoTo, True)
    End Sub
    Private Function chk_cboDocNoTo() As Boolean
        chk_cboDocNoTo = False

        If UCase(cboDocNoFr.Text) > UCase(cboDocNoTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboDocNoTo = True
    End Function

    Private Function chk_cboCusNoTo() As Boolean
        chk_cboCusNoTo = False

        If UCase(cboCusNoFr.Text) > UCase(cboCusNoTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboCusNoTo.Focus()
            Exit Function
        End If

        chk_cboCusNoTo = True
    End Function
    Private Function chk_medPrdFr() As Boolean
        chk_medPrdFr = False

        If Trim(medPrdFr.Text) = "/" Then
            chk_medPrdFr = True
            Exit Function
        End If

        If Chk_Period(medPrdFr) = False Then
            gsMsg = "Wrong Period!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function

        End If

        chk_medPrdFr = True
    End Function

    Private Function chk_medPrdTo() As Boolean
        chk_medPrdTo = False

        If UCase(medPrdFr.Text) > UCase(medPrdTo.Text) Then
            gsMsg = "To must > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdTo.Focus()
            Exit Function
        End If

        If Trim(medPrdTo.Text) = "/" Then
            chk_medPrdTo = True
            Exit Function
        End If

        If Chk_Period(medPrdTo) = False Then
            gsMsg = "Wrong Period!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdTo.Focus()
            Exit Function

        End If

        chk_medPrdTo = True
    End Function
    Private Sub Chk_Sel(ByRef inRow As Integer)

        Dim wlCtr As Integer


        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If waResult.get_Value(wlCtr, SSEL) = "-1" Then
                    waResult.get_Value(wlCtr, SSEL) = "0"
                    Exit Sub
                End If
            End If
        Next

    End Sub
    Private Sub frmAPR001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        Select Case KeyCode
            Case System.Windows.Forms.Keys.F2
                If tbrProcess.Items.Item(tcConvert).Enabled = False Then Exit Sub
                Call cmdSave(2)

            Case System.Windows.Forms.Keys.F3
                If tbrProcess.Items.Item(tcCan).Enabled = False Then Exit Sub
                Call cmdSave(3)

            Case System.Windows.Forms.Keys.F8
                If tbrProcess.Items.Item(tcCopy).Enabled = False Then Exit Sub
                Call cmdSave(4)

            Case System.Windows.Forms.Keys.F10
                If tbrProcess.Items.Item(tcFinish).Enabled = False Then Exit Sub
                Call cmdSave(5)

            Case System.Windows.Forms.Keys.F9
                If tbrProcess.Items.Item(tcComplete).Enabled = False Then Exit Sub
                Call cmdSave(8)

            Case System.Windows.Forms.Keys.F11
                Call cmdCancel()

            Case System.Windows.Forms.Keys.F12
                Me.Close()

            Case System.Windows.Forms.Keys.F5
                Call cmdSelect(1)

            Case System.Windows.Forms.Keys.F6
                Call cmdSelect(0)

            Case System.Windows.Forms.Keys.F7
                Call LoadRecord()

        End Select




    End Sub



    'UPGRADE_WARNING: Event optDocType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optDocType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDocType.CheckedChanged
        If eventSender.Checked Then
            Dim Index As Short = optDocType.GetIndex(eventSender)
            Call cmdRefresh()
        End If
    End Sub

    Private Sub optDocType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optDocType.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optDocType.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call cmdRefresh()
            tblDetail.Focus()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click, _tbrProcess_Button15.Click, _tbrProcess_Button16.Click, _tbrProcess_Button17.Click, _tbrProcess_Button18.Click, _tbrProcess_Button19.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub
		
		
		Select Case Button.Name
			Case tcConvert
				Call cmdSave(2)
				
			Case tcCan
				Call cmdSave(3)
				
			Case tcCopy
				' Call cmdSave(4)
				Call cmdCopy(4)
				
			Case tcFinish
				Call cmdSave(5)
				
			Case tcExport
				Call cmdExport()
				
				
			Case tcComplete
				Call cmdSave(8)
				
			Case tcPrint
				Call cmdPrint()
				
			Case tcLock
				Call cmdReady()
				
			Case tcCancel
				
				Call cmdCancel()
				
				
			Case tcSAll
				
				Call cmdSelect(1)
				
			Case tcDAll
				
				Call cmdSelect(0)
				
			Case tcExit
				Me.Close()
				
			Case tcRefresh
				Call cmdRefresh()
				
				
		End Select
	End Sub
	
	Private Sub frmAPR001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Grid()
		Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	Private Sub cmdCancel()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	
	
	Private Sub cmdRefresh()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		If wsSortBy = "ASC" Then
			wsSortBy = "DESC"
		Else
			wsSortBy = "ASC"
		End If
		
		
        Call Setup_tbrProcess()
        Call LoadRecord()


        Cursor = System.Windows.Forms.Cursors.Default


    End Sub

    Private Sub Ini_Scr()

        Dim MyControl As System.Windows.Forms.Control

        waResult.ReDim(0, -1, SSEL, SID)


        tblDetail.Array = waResult
        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        For Each MyControl In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            Select Case TypeName(MyControl)
                '         Case "ComboBox"
                '             MyControl.Clear
                Case "TextBox"
                    MyControl.Text = ""
                Case "TDBGrid"
                    'UPGRADE_WARNING: Couldn't resolve default property of object 'MyControl.ClearFields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.Clear()
                Case "Label"
                    If UCase(MyControl.Name) Like "LBLDSP*" Then
                        MyControl.Text = ""
                    End If
                Case "RichTextBox"
                    MyControl.Text = ""
                Case "CheckBox"
                    'UPGRADE_WARNING: Couldn't resolve default property of object 'MyControl.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.Value = 0
            End Select
        Next MyControl

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        wiExit = False

        Call SetPeriodMask(medPrdFr)
        Call SetPeriodMask(medPrdTo)


        medPrdFr.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))
        medPrdTo.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))

        cboDocNoFr.Text = ""
        cboDocNoTo.Text = ""
        cboCusNoFr.Text = ""
        cboCusNoTo.Text = ""

        wiSort = 0
        wsSortBy = "ASC"

        Call cmdRefresh()

    End Sub

    Private Sub frmAPR001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        '   Set waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmAPR001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing


    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
        optDocType(0).Checked = True



    End Sub


    Private Sub Setup_tbrProcess()

        With tbrProcess

            Select Case wsFormID

                Case "APR001"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            .Items.Item(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 1
                            .Items.Item(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 2
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                    End Select

                    ''Tom 20090203
                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcLock).Enabled = False
                    .Items.Item(tcPrint).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True

                Case "APR002"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            .Items.Item(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = True
                            .Items.Item(tcComplete).Enabled = True
                            ''Tom 20090203
                            .Items.Item(tcLock).Enabled = True
                        Case 1
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                            ''Tom 20090203
                            .Items.Item(tcLock).Enabled = False

                        Case 2
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                            ''Tom 20090203
                            .Items.Item(tcLock).Enabled = False

                    End Select

                    .Items.Item(tcExport).Enabled = True
                    .Items.Item(tcPrint).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True


                Case "APR003"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            .Items.Item(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = True
                            .Items.Item(tcComplete).Enabled = False
                        Case 1
                            .Items.Item(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 2
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                    End Select

                    ''Tom 20090203
                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcLock).Enabled = False
                    .Items.Item(tcPrint).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True

                Case "APR004"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            .Items.Item(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 1
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 2
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                    End Select

                    ''Tom 20090203
                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcLock).Enabled = False
                    .Items.Item(tcPrint).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True

                Case "APR005"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 1

                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                        Case 2
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                    End Select

                    ''Tom 20090203
                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcLock).Enabled = False
                    .Items.Item(tcPrint).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True


                Case "APR006"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = True
                            .Items.Item(tcComplete).Enabled = False
                            .Items.Item(tcPrint).Enabled = True
                        Case 1

                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                            .Items.Item(tcPrint).Enabled = True
                        Case 2
                            .Items.Item(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                            .Items.Item(tcComplete).Enabled = False
                            .Items.Item(tcPrint).Enabled = False
                    End Select

                    ''Tom 20090203
                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcLock).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True


                Case "APR007"

                    .Items.Item(tcConvert).Enabled = False
                    .Items.Item(tcCan).Enabled = False
                    .Items.Item(tcCopy).Enabled = False
                    .Items.Item(tcFinish).Enabled = False
                    .Items.Item(tcComplete).Enabled = False
                    .Items.Item(tcPrint).Enabled = False

                    ''Tom 20090203
                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcLock).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True


            End Select



        End With

    End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		'  Call Get_Scr_Item("TOOLTIP_A", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
		lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		optDocType(0).Text = Get_Caption(waScrItm, "OPT1")
		optDocType(1).Text = Get_Caption(waScrItm, "OPT2")
		optDocType(2).Text = Get_Caption(waScrItm, "OPT3")
		
		
		
		wsTitle = Get_Caption(waScrItm, "TITLE")
		
		With tblDetail
			.Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
			.Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
			.Columns(SCUSCODE).Caption = Get_Caption(waScrItm, "SCUSCODE")
			.Columns(SCUSNAME).Caption = Get_Caption(waScrItm, "SCUSNAME")
			.Columns(SDOCDATE).Caption = Get_Caption(waScrItm, "SDOCDATE")
			.Columns(SFROMDATE).Caption = Get_Caption(waScrItm, "SFROMDATE")
			.Columns(STODATE).Caption = Get_Caption(waScrItm, "STODATE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SNET).Caption = Get_Caption(waScrItm, "SNET")
			.Columns(SORI).Caption = Get_Caption(waScrItm, "SORI")
			'Tom 20090203
			If wsTrnCd = "SO" Then
				.Columns(SREADY).Caption = "Lock"
			End If
			
		End With
		
		With tbrProcess
			.Items.Item(tcConvert).ToolTipText = Get_Caption(waScrItm, tcConvert) & "(F2)"
			.Items.Item(tcCan).ToolTipText = Get_Caption(waScrItm, tcCan) & "(F3)"
			.Items.Item(tcCopy).ToolTipText = Get_Caption(waScrItm, tcCopy) & "(F8)"
			.Items.Item(tcFinish).ToolTipText = Get_Caption(waScrItm, tcFinish) & "(F10)"
			.Items.Item(tcComplete).ToolTipText = Get_Caption(waScrItm, tcComplete) & "(F9)"
			.Items.Item(tcPrint).ToolTipText = Get_Caption(waScrItm, tcPrint)
			.Items.Item(tcLock).ToolTipText = "Ready / Unlock"
			.Items.Item(tcExport).ToolTipText = Get_Caption(waScrItm, tcExport)
			
			
			.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrItm, tcRefresh) & "(F7)"
			.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrItm, tcCancel) & "(F11)"
			.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrItm, tcSAll) & "(F5)"
			.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrItm, tcDAll) & "(F6)"
			.Items.Item(tcExit).ToolTipText = Get_Caption(waScrItm, tcExit) & "(F12)"
		End With
		
	End Sub
	
	
	Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
		
		With tblDetail
			'UPGRADE_NOTE: UPDATE was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
		End With
		
		If eventArgs.ColIndex = SSEL Then
			
			'   tblDetail.ReBind
			'   tblDetail.Bookmark = 0
			
		End If
		
	End Sub
	
	
	
	
	Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
		Dim wsBookID As String
		Dim wsBookCode As String
		Dim wsBarCode As String
		Dim wsBookName As String
		Dim wsPub As String
		Dim wdPrice As Double
		Dim wdDisPer As Double
		Dim wsLotNo As String
		
		
		On Error GoTo tblDetail_BeforeColUpdate_Err
		
		If tblCommon.Visible = True Then
			eventArgs.Cancel = False
			'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
			Exit Sub
		End If
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case SSEL
					
					'   If .Columns(ColIndex).Text = "-1" Then
					'       Call Chk_Sel(.Row + To_Value(.FirstRow))
					'    End If
					
					' If Chk_grdSoNo(.Columns(ColIndex).Text) = False Then
					'    GoTo Tbl_BeforeColUpdate_Err
					' End If
					
			End Select
		End With
		
		Exit Sub
		
Tbl_BeforeColUpdate_Err: 
		'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True
        Exit Sub

tblDetail_BeforeColUpdate_Err:

        MsgBox("Check tblDeiail BeforeColUpdate!")
        'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True
	End Sub
	
	
	
	Private Sub tblDetail_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent) Handles tblDetail.ButtonClick
		
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case SDOCNO
					
					If .Columns(SDOCNO).Text <> "" Then
						
						
						Select Case wsFormID
							Case "APR001", "APR002", "APR003", "APR006"
								
								frmAPR0011.InDocID = CInt(.Columns(SID).Text)
								frmAPR0011.InCusNo = .Columns(SCUSCODE).Text
								frmAPR0011.TrnCd = wsTrnCd
								frmAPR0011.FormID = wsFormID & "1"
								frmAPR0011.UpdFlg = False
								frmAPR0011.ShowDialog()
								
							Case "APR004", "APR005", "APR007"
								
								frmAPR0012.InDocID = CInt(.Columns(SID).Text)
								frmAPR0012.InCusNo = .Columns(SCUSCODE).Text
								frmAPR0012.TrnCd = wsTrnCd
								frmAPR0012.FormID = wsFormID & "1"
								frmAPR0012.ShowDialog()
								
						End Select
						
						
						
						
					End If
					
				Case SDOCDATE
					
					If .Columns(SDOCNO).Text <> "" And wsFormID = "APR002" Then
						
						frmSOLOG.InDocID = CInt(.Columns(SID).Text)
						frmSOLOG.InCusNo = .Columns(SCUSCODE).Text
						frmSOLOG.TrnCd = wsTrnCd
						frmSOLOG.FormID = "SOLOG"
						frmSOLOG.ShowDialog()
						
					End If
					
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_ButtonClick_Err: 
		MsgBox("Check tblDeiail ButtonClick!")
		
	End Sub
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		Dim wlRet As Short
		Dim wlRow As Integer
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				Case System.Windows.Forms.Keys.F4 ' CALL COMBO BOX
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Call tblDetail_ButtonClick(tblDetail, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))

                Case System.Windows.Forms.Keys.Return
                    Select Case .Col
                        Case SORI
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SSEL
                        Case Else
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> SSEL Then
                        .Col = .Col - 1
                    End If
                Case System.Windows.Forms.Keys.Right
                    Select Case .Col
                        Case SORI
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SSEL
                        Case Else
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1

                    End Select

            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub






    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail



            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col

                    Case SCUSNAME
                        lblDspItmDesc.Text = ""
                        lblDspItmDesc.Text = .Columns(SCUSNAME).Text

                    Case SFROMDATE
                        lblDspItmDesc.Text = ""
                        lblDspItmDesc.Text = .Columns(SFROMDATE).Text

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True



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
	
	
	Private Sub Ini_Grid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = True
			.MultipleLines = 0
			.AllowAddNew = False
			.AllowUpdate = True
			.AllowDelete = False
			.AlternatingRowStyle = True
			.RecordSelectors = False
			.AllowColMove = False
			.AllowColSelect = False
			
			For wiCtr = SSEL To SID
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = True
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case SSEL
						.Columns(wiCtr).DataWidth = 1
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).Locked = False
					Case SDOCNO
						.Columns(wiCtr).DataWidth = 25
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).Button = True
					Case SCUSCODE
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 10
					Case SCUSNAME
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).DataWidth = 50
					Case SDOCDATE
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Button = True
					Case SFROMDATE
						.Columns(wiCtr).Width = 2500
						.Columns(wiCtr).DataWidth = 10
					Case STODATE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Visible = False
					Case SQTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
					Case SNET
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SORI
						.Columns(wiCtr).Width = 1200
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Locked = False
					Case SREADY
						'Tom 20090203
						If wsTrnCd = "SO" Then
							.Columns(wiCtr).Width = 500
							.Columns(wiCtr).DataWidth = 1
							.Columns(wiCtr).ValueItems.Presentation = TrueDBGrid60.PresentationConstants.dbgCheckBox
						Else
							.Columns(wiCtr).Width = 100
							.Columns(wiCtr).DataWidth = 0
						End If
					Case SID
						.Columns(wiCtr).Visible = False
						.Columns(wiCtr).DataWidth = 15
				End Select
				
			Next 
			.Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
		End With
		
	End Sub
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		Dim wdCreLmt As Double
		Dim wdCreLft As Double
		Dim wsStatus As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		
		Select Case Opt_Getfocus(optDocType, 3, 0)
			Case 0
				wsStatus = "1"
			Case 1
				wsStatus = "4"
			Case 2
				wsStatus = "2"
		End Select
		
		Select Case wsTrnCd
			Case "SN"
				
				wsSQL = "SELECT CUSNAME, SNHDDOCID DOCID, SNHDDOCNO DOCNO, SNHDDOCDATE DOCDATE, SNHDSHIPFROM +' '+ SNHDSHIPTO +' '+ SNHDSHIPVIA JOBREF, SNHDCUSID, CUSCODE, SNHDREFNO REFNO, SUM(SNPTJQTY) QTY, "
				wsSQL = wsSQL & " SUM(SNPTJNET) NET "
				wsSQL = wsSQL & " FROM  SOASNHD, SOASNPTJ, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE SNHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SNHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND SNHDDOCID = SNPTJDOCID "
				wsSQL = wsSQL & " AND SNHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SNHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY CUSNAME, SNHDDOCID, SNHDDOCNO, SNHDDOCDATE, SNHDSHIPFROM, SNHDSHIPTO, SNHDSHIPVIA, SNHDCUSID, CUSCODE, SNHDREFNO "
				'wsSQL = wsSQL & " ORDER BY SNHDDOCDATE, SNHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY SNHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY SNHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY SNHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY SNHDDOCDATE, SNHDDOCNO " & wsSortBy
				End If
				
			Case "SO"
				
				wsSQL = "SELECT CUSNAME, SOHDDOCID DOCID, SOHDDOCNO DOCNO, SOHDDOCDATE DOCDATE, SOHDSHIPFROM JOBREF, SOHDCUSID, CUSCODE, SOHDCORRNO REFNO, SOHDREADY RDY, SUM(SOPTJQTY) QTY, "
				wsSQL = wsSQL & " SUM(SOPTJNET) NET "
				wsSQL = wsSQL & " FROM  SOASOHD, SOASOPTJ, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE SOHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SOHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND SOHDDOCID = SOPTJDOCID "
				wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SOHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY CUSNAME, SOHDDOCID, SOHDDOCNO, SOHDDOCDATE, SOHDSHIPFROM, SOHDCUSID, CUSCODE, SOHDCORRNO, SOHDREADY "
				'wsSQL = wsSQL & " ORDER BY SOHDDOCDATE, SOHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY SOHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY SOHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY SOHDCORRNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY SOHDDOCDATE, SOHDDOCNO " & wsSortBy
				End If
				
			Case "SP"
				
				wsSQL = "SELECT CUSNAME, SPHDDOCID DOCID, SPHDDOCNO DOCNO, SPHDDOCDATE DOCDATE, SPHDSHIPFROM JOBREF, SPHDCUSID, CUSCODE, SPHDREFNO REFNO, SUM(SPDTQTY) QTY, "
				wsSQL = wsSQL & " SUM(SPDTMERCST) NET "
				wsSQL = wsSQL & " FROM  SOASPHD, SOASPDT, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE SPHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SPHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND SPHDDOCID = SPDTDOCID "
				wsSQL = wsSQL & " AND SPHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SPHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY CUSNAME, SPHDDOCID, SPHDDOCNO, SPHDDOCDATE, SPHDSHIPFROM,  SPHDCUSID, CUSCODE, SPHDREFNO "
				'wsSQL = wsSQL & " ORDER BY SPHDDOCDATE, SPHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY SPHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY SPHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY SPHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY SPHDDOCDATE, SPHDDOCNO " & wsSortBy
				End If
				
			Case "SW"
				
				wsSQL = "SELECT CUSNAME, SWHDDOCID DOCID, SWHDDOCNO DOCNO, SWHDDOCDATE DOCDATE, SWHDSHIPFROM JOBREF, SWHDCUSID, CUSCODE, SWHDREFNO REFNO, SUM(SWDTQTY) QTY, "
				wsSQL = wsSQL & " SUM(SWDTMERCST) NET "
				wsSQL = wsSQL & " FROM  SOASWHD, SOASWDT, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE SWHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SWHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND SWHDDOCID = SWDTDOCID "
				wsSQL = wsSQL & " AND SWHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SWHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " AND SWHDUPDFLG = 'N' "
				wsSQL = wsSQL & " GROUP BY CUSNAME, SWHDDOCID, SWHDDOCNO, SWHDDOCDATE, SWHDSHIPFROM, SWHDCUSID, CUSCODE, SWHDREFNO "
				
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY SWHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY SWHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY SWHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY SWHDDOCDATE, SWHDDOCNO " & wsSortBy
				End If
				
			Case "SD"
				
				wsSQL = "SELECT CUSNAME, SDHDDOCID DOCID, SDHDDOCNO DOCNO, SDHDDOCDATE DOCDATE, SDHDSHIPFROM JOBREF, SDHDCUSID, CUSCODE, SDHDREFNO REFNO, SUM(SDPTJQTY) QTY, "
				wsSQL = wsSQL & " SUM(SDPTJNET) NET "
				wsSQL = wsSQL & " FROM  SOASDHD, SOASDPTJ, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE SDHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SDHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND SDHDDOCID = SDPTJDOCID "
				wsSQL = wsSQL & " AND SDHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SDHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY CUSNAME, SDHDDOCID, SDHDDOCNO, SDHDDOCDATE, SDHDSHIPFROM, SDHDCUSID, CUSCODE, SDHDREFNO "
				'wsSQL = wsSQL & " ORDER BY SDHDDOCDATE, SDHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY SDHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY SDHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY SDHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY SDHDDOCDATE, SDHDDOCNO " & wsSortBy
				End If
				
				
			Case "IV"
				
				wsSQL = "SELECT CUSNAME, IVHDDOCID DOCID,  LEFT(IVHDDOCNO,4) + '/' + IVHDREFNO + '/' + RIGHT(IVHDDOCNO,LEN(IVHDDOCNO)-4) DOCNO, IVHDDOCDATE DOCDATE, IVHDSHIPFROM JOBREF, IVHDCUSID, CUSCODE, IVHDCORRNO REFNO, SUM(IVDTQTY) QTY, "
				wsSQL = wsSQL & " SUM(IVDTNET) NET "
				wsSQL = wsSQL & " FROM  SOAIVHD, SOAIVDT, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE IVHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND IVHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND IVHDDOCID = IVDTDOCID "
				wsSQL = wsSQL & " AND IVHDCUSID = CUSID "
				wsSQL = wsSQL & " AND IVHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY CUSNAME, IVHDDOCID, IVHDDOCNO, IVHDDOCDATE, IVHDSHIPFROM, IVHDCUSID, CUSCODE, IVHDCORRNO, IVHDREFNO "
				' wsSQL = wsSQL & " ORDER BY IVHDDOCDATE "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY IVHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY IVHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY IVHDCORRNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY IVHDDOCDATE, IVHDDOCNO " & wsSortBy
				End If
				
				
				
			Case "VQ"
				
				wsSQL = "SELECT CUSNAME, VQHDDOCID DOCID, VQHDDOCNO DOCNO, VQHDDOCDATE DOCDATE, VQHDSHIPFROM JOBREF, VQHDCUSID, CUSCODE, SOHDDOCNO REFNO, VQHDREADY RDY, SUM(VQPTJQTY) QTY, "
				wsSQL = wsSQL & " SUM(VQPTJNET) NET "
				wsSQL = wsSQL & " FROM  SOAVQHD, SOAVQPTJ, MSTCUSTOMER, SOASOHD "
				wsSQL = wsSQL & " WHERE VQHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND VQHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND VQHDDOCID = VQPTJDOCID "
				wsSQL = wsSQL & " AND VQHDCUSID = CUSID "
				wsSQL = wsSQL & " AND VQHDREFDOCID = SOHDDOCID "
				wsSQL = wsSQL & " AND VQHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY CUSNAME, VQHDDOCID, VQHDDOCNO, VQHDDOCDATE, VQHDSHIPFROM, VQHDCUSID, CUSCODE, SOHDDOCNO, VQHDREADY "
				'wsSQL = wsSQL & " ORDER BY VQHDDOCDATE, VQHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY VQHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY VQHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY CUSCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY SOHDDOCNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY VQHDDOCDATE, VQHDDOCNO " & wsSortBy
				End If
				
		End Select
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			waResult.ReDim(0, -1, SSEL, SID)
			tblDetail.ReBind()
			tblDetail.Bookmark = 0
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmAPR001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.windows.forms.Cursors.Default ' vbNormal
            Exit Function
        End If



        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF

                '    wdCreLft = Get_CreditLimit(ReadRs(rsRcd, "SNHDCUSID"), gsSystemDate)
                wdCreLft = 0

                .AppendRows()
                waResult.get_Value(.get_UpperBound(1), SSEL) = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "DOCNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SCUSCODE) = ReadRs(rsRcd, "CUSCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SCUSNAME) = ReadRs(rsRcd, "CUSNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCDATE) = ReadRs(rsRcd, "DOCDATE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SFROMDATE) = ReadRs(rsRcd, "JOBREF")
                waResult.get_Value(.get_UpperBound(1), STODATE) = ""
                waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SNET) = VB6.Format(To_Value(ReadRs(rsRcd, "NET")), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SORI) = ReadRs(rsRcd, "REFNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "DOCID")

                If wsTrnCd = "SO" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    waResult.get_Value(.get_UpperBound(1), SREADY) = IIf(ReadRs(rsRcd, "RDY") = "Y", "-1", "0")
                End If

                rsRcd.MoveNext()
            Loop
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


        LoadRecord = True
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmAPR001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.windows.forms.Cursors.Default ' vbNormal

    End Function


    Private Function Chk_GrdRow(ByVal LastRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsDes As String
        Dim wsExcRat As String

        Chk_GrdRow = False

        On Error GoTo Chk_GrdRow_Err

        With tblDetail

            If To_Value(LastRow) > waResult.get_UpperBound(1) Then
                Chk_GrdRow = True
                Exit Function
            End If



            If wiActFlg = 2 And wsFormID = "APR001" Then
                If Chk_grdSoNo("SO", waResult.get_Value(LastRow, SORI)) = False Then
                    .Col = SORI
                    Exit Function
                End If
            End If

            If wiActFlg = 3 And wsFormID = "APR002" Then
                If DelValidation(To_Value(waResult.get_Value(LastRow, SID))) = False Then
                    .Col = SID
                    Exit Function
                End If
            End If



        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function


    Private Sub cmdSave(ByVal inActFlg As Short)

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wsCusNo As String
        Dim wsStorep As String
        Dim wsItemNo As String

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        wiActFlg = inActFlg



        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        '' Last Check when Add

        Select Case wiActFlg
            Case 2
                gsMsg = "你是否確認要轉換?"
            Case 3
                gsMsg = "你是否取消此文件?"
                If Opt_Getfocus(optDocType, 3, 0) = 2 Then
                    inActFlg = 6
                    gsMsg = "你是否完全刪除此文件?"
                End If
            Case 4
                gsMsg = "你是否拷貝此文件?"
            Case 5
                If wsFormID = "APR002" Then
                    inActFlg = 7
                    gsMsg = "你是否轉換送貨單?"
                Else
                    gsMsg = "你是否批核完成此文件?"
                End If
            Case 8
                gsMsg = "你是否完成此文件?"
        End Select



        If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        wsMark = "0"



        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon


        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_APR001A"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
                    Call SetSPPara(adcmdSave, 1, inActFlg)
                    Call SetSPPara(adcmdSave, 2, wsTrnCd)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, SID))
                    Call SetSPPara(adcmdSave, 4, IIf(wiActFlg = 2 And wsFormID = "APR001", waResult.get_Value(wiCtr, SORI), ""))
                    Call SetSPPara(adcmdSave, 5, wsFormID)
                    Call SetSPPara(adcmdSave, 6, gsUserID)
                    Call SetSPPara(adcmdSave, 7, wsGenDte)

                    wsMark = waResult.get_Value(wiCtr, SID)
                    wsCusNo = waResult.get_Value(wiCtr, SCUSCODE)
                    adcmdSave.Execute()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsDocNo = GetSPPara(adcmdSave, 8)
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsItemNo = GetSPPara(adcmdSave, 9)
                End If
            Next
        End If


        If wiActFlg = 2 And wsDocNo = "-1" Then
            gsMsg = "Item ： " & wsItemNo & " length too long!Please convert it to normal item!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            GoTo cmdSave_ItemErr

        End If

        cnCon.CommitTrans()


        Select Case wiActFlg
            Case 1
                gsMsg = "已完成!"
            Case 2, 4
                gsMsg = "文件 ： " & wsDocNo & " 已完成!"
            Case 3
                gsMsg = "文件已取消完成!"
            Case 5
                If wsFormID = "APR002" Then
                    gsMsg = "文件 ： " & wsDocNo & " 已完成!"
                Else
                    gsMsg = "已完成!"
                End If

        End Select
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)



        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

        Call LoadRecord()

        Cursor = System.Windows.Forms.Cursors.Default


        Exit Sub

cmdSave_ItemErr:
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

        Exit Sub

cmdSave_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

    End Sub

    Private Function InputValidation() As Boolean
        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        InputValidation = False

        On Error GoTo InputValidation_Err

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If
                End If
            Next
        End With

        If wiEmptyGrid = True Then
            gsMsg = "沒有詳細資料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tblDetail.Focus()
            End If
            Exit Function
        End If


        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function





    Private Sub cmdSelect(ByVal wiSelect As Short)
        Dim wiCtr As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor



        With waResult
            For wiCtr = 0 To .get_UpperBound(1)
                waResult.get_Value(wiCtr, SSEL) = IIf(wiSelect = 1, "-1", "0")
            Next wiCtr
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmAPR001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.windows.forms.Cursors.Default ' vbNormal

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
	
	
	Private Function Chk_grdSoNo(ByVal InTrnCd As String, ByVal inAccNo As String) As Boolean
		Dim wsStatus As String
		
		Chk_grdSoNo = False
		
		
		If Trim(inAccNo) = "" Then
			Chk_grdSoNo = True
			Exit Function
		End If
		
		
		If Chk_TrnHdDocNo(InTrnCd, inAccNo, wsStatus) = True Then
			
			If wsStatus = "4" Then
				gsMsg = "工程編號已入數, 不能啟用!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			End If
			
			If wsStatus = "2" Then
				gsMsg = "工程編號已刪除, 不能啟用!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			End If
			
			If wsStatus = "3" Then
				gsMsg = "工程編號已無效, 不能啟用!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			End If
			
			If wsStatus = "1" Then
				gsMsg = "工程編號已用, 不能啟用!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			End If
			
			Exit Function
		End If
		
		Chk_grdSoNo = True
		
		
	End Function
	
	
	Private Function DelValidation(ByVal InDocID As Integer) As Boolean
		Dim OutTrnCd As String
		Dim OutDocNo As String
		
		
		
		DelValidation = False
		
		On Error GoTo DelValidation_Err
		
		
		
		'   If Not chk_txtRevNo Then Exit Function
		If Chk_SoRefDoc(CStr(InDocID), OutTrnCd, OutDocNo) = True Then
			
			Select Case OutTrnCd
				Case "SP"
					gsMsg = "配貨單 : " & OutDocNo & " 是以此銷售轉為!不能刪除"
				Case "SW"
					gsMsg = "發貨單 : " & OutDocNo & " 是以此銷售轉為!不能刪除"
				Case "SR"
					gsMsg = "退貨單 : " & OutDocNo & " 是以此銷售轉為!不能刪除"
				Case "IV"
					gsMsg = "發票 : " & OutDocNo & " 是以此銷售轉為!不能刪除"
				Case "PO"
					gsMsg = "採購單 : " & OutDocNo & " 是以此銷售轉為!不能刪除"
			End Select
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
			
		End If
		
		DelValidation = True
		
		Exit Function
		
DelValidation_Err: 
		gsMsg = Err.Description
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
	End Function
	
	
	Private Sub tblDetail_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_HeadClickEvent) Handles tblDetail.HeadClick
		
		
		On Error GoTo tblDetail_HeadClick_Err
		
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case SDOCNO
					wiSort = 0
					cmdRefresh()
				Case SDOCDATE
					wiSort = 1
					cmdRefresh()
				Case SCUSCODE
					wiSort = 2
					cmdRefresh()
				Case SORI
					wiSort = 3
					cmdRefresh()
			End Select
		End With
		
		
		Exit Sub
		
tblDetail_HeadClick_Err: 
		MsgBox("Check tblDeiail HeadClick!")
		
	End Sub
	Private Sub cmdPrint()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		'If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(4)
		wsSelection(1) = ""
		wsSelection(2) = ""
		wsSelection(3) = ""
		wsSelection(4) = ""
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTJOB005 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & wsTitle & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdFr.Text) = "/", "000000", VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(medPrdTo.Text) = "/", "999999", VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "', "
		wsSQL = wsSQL & "'" & Opt_Getfocus(optDocType, 3, 0) & "',"
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTJOB005"
		Else
			wsRptName = "RPTJOB005"
		End If
		
		NewfrmPrint.ReportID = "JOB005"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "JOB005"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub cmdCopy(ByVal inActFlg As Short)
		' Tom 20090203
		Dim wsGenDte As String
		Dim adcmdCopy As New ADODB.Command
		Dim wiCtr As Short
		Dim wsDocNo As String
		Dim wsCusNo As String
		Dim wsStorep As String
		Dim wsItemNo As String
		
		Dim wsCmpCd As String
		
		
		On Error GoTo cmdCopy_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		wiActFlg = inActFlg
		
		
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		'' Last Check when Add
		
		wsCmpCd = GetCompanySelect
		
		If wsCmpCd = "" Then
			gsMsg = "No company Code!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		
		Select Case wsCmpCd
			Case "FR"
				gsMsg = "你是否拷貝此文件到輝域(FR)"
			Case "CF"
				gsMsg = "你是否拷貝此文件到忠輝(CF)"
			Case "CY"
				gsMsg = "你是否拷貝此文件到盈福(CY)"
			Case Else
				gsMsg = "你是否拷貝此文件到輝域(FR)"
				wsCmpCd = "FR"
		End Select
		
		
		'gsMsg = "你是否拷貝此文件?"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		wsMark = "0"
		
		
		cnCon.BeginTrans()
		adcmdCopy.ActiveConnection = cnCon
		
		
		If waResult.get_UpperBound(1) >= 0 Then
			adcmdCopy.CommandText = "usp_APR001A_CPY"
			adcmdCopy.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdCopy.Parameters.Refresh()
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
					Call SetSPPara(adcmdCopy, 1, inActFlg)
					Call SetSPPara(adcmdCopy, 2, wsCmpCd)
					Call SetSPPara(adcmdCopy, 3, wsTrnCd)
					Call SetSPPara(adcmdCopy, 4, waResult.get_Value(wiCtr, SID))
					Call SetSPPara(adcmdCopy, 5, IIf(wiActFlg = 2 And wsFormID = "APR001", waResult.get_Value(wiCtr, SORI), ""))
					Call SetSPPara(adcmdCopy, 6, wsFormID)
					Call SetSPPara(adcmdCopy, 7, gsUserID)
					Call SetSPPara(adcmdCopy, 8, wsGenDte)
					
					wsMark = waResult.get_Value(wiCtr, SID)
					wsCusNo = waResult.get_Value(wiCtr, SCUSCODE)
					adcmdCopy.Execute()
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wsDocNo = GetSPPara(adcmdCopy, 9)
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wsItemNo = GetSPPara(adcmdCopy, 10)
				End If
			Next 
		End If
		
		cnCon.CommitTrans()
		
		gsMsg = "文件 ： " & wsDocNo & " 已完成!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		'UPGRADE_NOTE: Object adcmdCopy may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdCopy = Nothing
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
		Exit Sub
		
cmdCopy_ItemErr: 
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdCopy may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdCopy = Nothing
		
		Exit Sub
		
cmdCopy_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdCopy may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdCopy = Nothing
		
	End Sub
	
	Private Function GetCompanySelect() As String
		
		Dim Newfrm As New frmSelectComp
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		With Newfrm
			'  Set .ctlKey = GetCompanySelect
			.ShowDialog()
			GetCompanySelect = .ctlKey
		End With
		
		'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Newfrm = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Function
	
	
	
	Private Sub cmdReady()
		' Tom 20090203
		Dim wsGenDte As String
		Dim adcmdReady As New ADODB.Command
		Dim wiCtr As Short
		Dim bPass As Boolean
		
		
		
		On Error GoTo cmdReady_Err
		
		If wsTrnCd <> "SO" Then
			Exit Sub
		End If
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		'' Last Check when Add
		
		
		gsMsg = "你是否 Ready/unlock 此文件"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		
		
		cnCon.BeginTrans()
		adcmdReady.ActiveConnection = cnCon
		
		
		If waResult.get_UpperBound(1) >= 0 Then
			adcmdReady.CommandText = "usp_APR001A_RDY"
			adcmdReady.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdReady.Parameters.Refresh()
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
					bPass = True
					
					If Trim(waResult.get_Value(wiCtr, SREADY)) = "-1" Then
						bPass = chkSpecialPassword(waResult.get_Value(wiCtr, SDOCNO))
					End If
					
					If (bPass) Then
						Call SetSPPara(adcmdReady, 1, wsTrnCd)
						Call SetSPPara(adcmdReady, 2, waResult.get_Value(wiCtr, SID))
						Call SetSPPara(adcmdReady, 3, IIf(waResult.get_Value(wiCtr, SREADY) = "-1", "N", "Y"))
						Call SetSPPara(adcmdReady, 4, wsFormID)
						Call SetSPPara(adcmdReady, 5, gsUserID)
						Call SetSPPara(adcmdReady, 6, wsGenDte)
						adcmdReady.Execute()
					End If
					
				End If
			Next wiCtr
		End If
		
		cnCon.CommitTrans()
		
		gsMsg = "已完成!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		'UPGRADE_NOTE: Object adcmdReady may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdReady = Nothing
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
		Exit Sub
		
cmdReady_ItemErr: 
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdReady may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdReady = Nothing
		
		Exit Sub
		
cmdReady_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdReady may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdReady = Nothing
		
	End Sub
	
	
	Private Function chkSpecialPassword(ByVal inDoc As String) As Boolean
		
		Dim Newfrm As New frmSpecialPassword
		Dim outResult As Boolean
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		outResult = False
		
		With Newfrm
			.DOCNO = inDoc
			.ShowDialog()
			outResult = .Result
		End With
		
		'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Newfrm = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		chkSpecialPassword = outResult
		
	End Function
	
	Private Sub cmdExport()
		
		Dim wsGenDte As String
		Dim wiCtr As Short
		Dim wsTrnCode As String
		Dim wsStorep As String
		Dim wiMod As Short
		Dim wsPath As String
		Dim wsDoc As String
		
		
		
		
		On Error GoTo cmdExport_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		'' Last Check when Add
		
		gsMsg = "你是否確認要匯出文件？"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		wsTrnCode = "DN"
		
		
		If Trim(gsHHPath) <> "" Then
			wsPath = gsHHPath & "send\HHTORDER.TXT"
		Else
			wsPath = My.Application.Info.DirectoryPath & "send\HHTORDER.TXT"
		End If
		
		'    cnCon.BeginTrans
		'    Set adcmdExport.ActiveConnection = cnCon
		
		wiMod = 1
		wsDoc = ""
		If waResult.get_UpperBound(1) >= 0 Then
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
					
					
					If ExportToHHFile(wsPath, wsTrnCode, waResult.get_Value(wiCtr, SID), wiMod, "") = False Then
						gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " 匯出Error!"
						MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					Else
						wiMod = 2
						wsDoc = wsDoc & IIf(wsDoc = "", waResult.get_Value(wiCtr, SID), "," & waResult.get_Value(wiCtr, SID))
						
					End If
					
				End If
			Next wiCtr
		End If
		
		
		'   cnCon.CommitTrans
		Sleep((500))
		If SendToHH(wsPath) = True Then
			
			gsMsg = "匯出文件已完成!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
		End If
		
		
		
		' Set adcmdExport = Nothing
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
cmdExport_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		'  cnCon.RollbackTrans
		'  Set adcmdExport = Nothing
		
	End Sub
End Class