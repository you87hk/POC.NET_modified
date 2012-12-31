Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSOP030
	Inherits System.Windows.Forms.Form
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private Const FRPRICE As Short = 0
	Private Const TOPRICE As Short = 1
	Private Const GDummy As Short = 2
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private wiAction As Short
	Private wbUpdate As Boolean
	Private wbErr As Boolean
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	Private Sub cmdCancel()
		Ini_Scr()
		medPrdFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim adcmdSave As New ADODB.Command
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim sFrPrd As String
		Dim sToPrd As String
		Dim wiCtr As Short
		Dim iPos As Short
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(1)
		'wsSelection(1) = medPrdFr.Caption & " " & Set_Quote(cboCusNoFr.Text)
		
		wsDteTim = CStr(Now)
		
		iPos = InStr(1, medPrdFr.Text, "/", CompareMethod.Text)
		sFrPrd = VB.Left(medPrdFr.Text, iPos - 1) & VB.Right(medPrdFr.Text, Len(medPrdFr.Text) - iPos)
		sToPrd = VB.Left(medPrdTo.Text, iPos - 1) & VB.Right(medPrdTo.Text, Len(medPrdTo.Text) - iPos)
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		If waResult.get_UpperBound(1) >= 0 Then
			adcmdSave.CommandText = "USP_RPTSOP030A"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, FRPRICE)) <> "" Then
					Call SetSPPara(adcmdSave, 1, gsUserID)
					Call SetSPPara(adcmdSave, 2, Change_SQLDate(wsDteTim))
					Call SetSPPara(adcmdSave, 3, Set_Quote(txtTitle.Text))
					Call SetSPPara(adcmdSave, 4, Set_Quote(medPrdFr.Text))
					Call SetSPPara(adcmdSave, 5, Set_Quote(medPrdTo.Text))
					Call SetSPPara(adcmdSave, 6, Set_Quote(sFrPrd))
					Call SetSPPara(adcmdSave, 7, Set_Quote(sToPrd))
					Call SetSPPara(adcmdSave, 8, To_Value(waResult.get_Value(wiCtr, FRPRICE)))
					Call SetSPPara(adcmdSave, 9, To_Value(waResult.get_Value(wiCtr, TOPRICE)))
					Call SetSPPara(adcmdSave, 10, IIf(wiCtr = waResult.get_UpperBound(1), "Y", "N"))
					Call SetSPPara(adcmdSave, 11, gsLangID)
					adcmdSave.Execute()
				End If
			Next 
		End If
		cnCon.CommitTrans()
		
		'Create Stored Procedure String
		wsSQL = "EXEC usp_RPTSOP030 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "'"
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSOP030"
		Else
			wsRptName = "RPTSOP030"
		End If
		
		NewfrmPrint.ReportID = "SOP030"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "SOP030"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmSOP030_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmSOP030_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		Call Ini_Grid()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "SOP030"
		
	End Sub
	
	Private Sub Ini_Scr()
		Me.Text = wsFormCaption
		
		waResult.ReDim(0, -1, FRPRICE, TOPRICE)
		tblDetail.Array = waResult
		'tblDetail.ReBind
		tblDetail.Bookmark = 0
		wiAction = DefaultPage
		
		tblCommon.Visible = False
		Call SetPeriodMask(medPrdFr)
		Call SetPeriodMask(medPrdTo)
		
		Dim iCounter As Short
		
		With waResult
			.ReDim(0, -1, FRPRICE, TOPRICE)
			For iCounter = 0 To 9
				.AppendRows()
				waResult.get_Value(.get_UpperBound(1), FRPRICE) = iCounter * 10 + 1
				waResult.get_Value(.get_UpperBound(1), TOPRICE) = (iCounter + 1) * 10
			Next 
		End With
		
		tblDetail.Enabled = True
		tblDetail.ReBind()
		'tblDetail.FirstRow = 0
		
		wgsTitle = "Sales Quantity/Amount History Report"
	End Sub
	
	Private Function InputValidation() As Boolean
		InputValidation = False
		
		If chk_medPrdFr = False Then
			Me.medPrdFr.Focus()
			Exit Function
		End If
		
		If chk_medPrdTo = False Then
			Me.medPrdTo.Focus()
			Exit Function
		End If
		
		Dim wiEmptyGrid As Boolean
		Dim wlCtr As Integer
		
		wiEmptyGrid = True
		With waResult
			For wlCtr = 0 To .get_UpperBound(1)
				If Trim(waResult.get_Value(wlCtr, FRPRICE)) <> "" Then
					wiEmptyGrid = False
					If Chk_GrdRow(wlCtr) = False Then
						tblDetail.Col = FRPRICE
						tblDetail.Focus()
						Exit Function
					End If
					
					If Chk_NoDup2(wlCtr, waResult.get_Value(wlCtr, FRPRICE), waResult.get_Value(wlCtr, TOPRICE)) = False Then
						tblDetail.Row = wlCtr - 1
						tblDetail.Col = FRPRICE
						tblDetail.Focus()
						Exit Function
					End If
					
				End If
			Next 
		End With
		
		If wiEmptyGrid = True Then
			gsMsg = "定價範圍沒有來源資料!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			If tblDetail.Enabled Then
				tblDetail.Col = FRPRICE
				tblDetail.Focus()
			End If
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	'UPGRADE_WARNING: Event frmSOP030.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmSOP030_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(5250)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmSOP030_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmSOP030 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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

        With tblDetail
            .Columns(FRPRICE).Caption = Get_Caption(waScrItm, "FRPRICE")
            .Columns(TOPRICE).Caption = Get_Caption(waScrItm, "TOPRICE")
        End With

        lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
        lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
        lblPrice.Text = Get_Caption(waScrItm, "PRICE")

        Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)

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

            medPrdFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
        FocusMe(txtTitle, True)
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

            tblDetail.Focus()
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

    Private Function chk_medPrdFr() As Boolean
        chk_medPrdFr = False

        If Trim(medPrdFr.Text) = "/" Then
            gsMsg = "Must Input Period!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function
        End If

        If Chk_Period(medPrdFr) = False Then
            gsMsg = "Invalid Period!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medPrdFr.Focus()
            Exit Function
        End If

        chk_medPrdFr = True
    End Function

    Private Sub Ini_Grid()
        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            '   .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = FRPRICE To GDummy
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case FRPRICE
                        .Columns(wiCtr).Width = 1710
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = False
                    Case TOPRICE
                        .Columns(wiCtr).Width = 1710
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = False
                    Case GDummy
                        .Columns(wiCtr).Width = 100
                        .Columns(wiCtr).DataWidth = 0
                End Select
            Next
            '  .Styles("EvenRow").BackColor = &H8000000F
        End With
    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With
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
                Case FRPRICE, TOPRICE
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If eventArgs.ColIndex = FRPRICE Then
                        If Chk_grdFrPrice((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If
                    ElseIf eventArgs.ColIndex = TOPRICE Then
                        If Chk_grdToPrice((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If
                    End If
            End Select

            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If .Columns(eventArgs.ColIndex).Text <> eventArgs.OldValue Then
                wbUpdate = True
            End If
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

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            '  If .Bookmark <> .DestinationRow Then
            If Chk_GrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
            '  End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub

    Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent

        Dim wlRet As Short
        Dim wlRow As Integer

        On Error GoTo tblDetail_KeyDown_Err

        With tblDetail
            Select Case eventArgs.KeyCode
                Case System.Windows.Forms.Keys.F4 ' CALL COMBO BOX
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    'Call tblDetail_ButtonClick(.Col)

                Case System.Windows.Forms.Keys.F5 ' INSERT LINE
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case System.Windows.Forms.Keys.F8 ' DELETE LINE
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(.Bookmark) Then Exit Sub
                    If .EditActive = True Then Exit Sub
                    gsMsg = "你是否確定要刪除此列?"
                    If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then Exit Sub
                    .Delete()
                    'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()
                    If .Row = -1 Then
                        .Row = 0
                    End If
                    'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Refresh()
                    .Focus()

                Case System.Windows.Forms.Keys.Return
                    Select Case .Col
                        Case TOPRICE
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = FRPRICE
                        Case FRPRICE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = TOPRICE
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case TOPRICE
                            .Col = FRPRICE
                    End Select
                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case FRPRICE
                            .Col = TOPRICE
                    End Select
            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
        Select Case tblDetail.Col
            Case FRPRICE, TOPRICE
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, True)

        End Select

    End Sub

    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail
            If IsEmptyRow() Then
                .Col = FRPRICE
            End If

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case FRPRICE
                        Call Chk_grdFrPrice((.Columns(FRPRICE).Text))

                    Case TOPRICE
                        Call Chk_grdToPrice((.Columns(TOPRICE).Text))
                        'Case DisPer
                        '    Call Chk_grdDisPer(.Columns(DisPer).Text)

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub

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

            If IsEmptyRow(To_Value(LastRow)) = True Then
                .Delete()
                'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                .Refresh()
                .Focus()
                Chk_GrdRow = False
                Exit Function
            End If

            If Chk_grdFrPrice(waResult.get_Value(LastRow, FRPRICE)) = False Then
                .Col = FRPRICE
                Exit Function
            End If

            If Chk_grdToPrice(waResult.get_Value(LastRow, TOPRICE), waResult.get_Value(LastRow, FRPRICE)) = False Then
                .Col = TOPRICE
                Exit Function
            End If

        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function

    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmSOP030.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If


    End Sub

    Public Sub mnuPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopUpSub.Click
        Dim Index As Short = mnuPopUpSub.GetIndex(eventSender)
        Call Call_PopUpMenu(waPopUpSub, Index)
    End Sub

    Private Sub Call_PopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)

        Dim wsAct As String

        wsAct = inArray.get_Value(inMnuIdx, 0)

        With tblDetail
            Select Case wsAct
                Case "DELETE"
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(.Bookmark) Then Exit Sub
                    If .EditActive = True Then Exit Sub

                    gsMsg = "你是否確定要刪除此列?"
                    If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then Exit Sub

                    .Delete()
                    'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()

                    If .Row = -1 Then
                        .Row = 0
                    End If
                    'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Refresh()
                    .Focus()


                Case "INSERT"

                    If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyRow Then Exit Sub

                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case Else
                    Exit Sub

            End Select

        End With
    End Sub
	
	Private Function Chk_NoDup2(ByRef inRow As Integer, ByVal wsCurRec As String, ByVal wsCurRec1 As String) As Boolean
		Dim wlCtr As Integer
		
		Chk_NoDup2 = False
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If (wsCurRec = waResult.get_Value(wlCtr, FRPRICE)) And (wsCurRec1 = waResult.get_Value(wlCtr, TOPRICE)) Then
					inRow = wlCtr
					gsMsg = "重覆項目!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup2 = True
	End Function
	
	Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean
		IsEmptyRow = True
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inRow) Then
			With tblDetail
				If Trim(.Columns(FRPRICE).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				If Trim(waResult.get_Value(inRow, FRPRICE)) = "" And Trim(waResult.get_Value(inRow, TOPRICE)) = "" Then
					Exit Function
				End If
			End If
		End If
		
		IsEmptyRow = False
		
	End Function
	
	Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean
		Dim wlCtr As Integer
		Dim wsCurRec As String
		
		Chk_NoDup = False
		
		wsCurRec = VB6.Format(tblDetail.Columns(FRPRICE).Text, gsAmtFmt)
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = VB6.Format(waResult.get_Value(wlCtr, FRPRICE), gsAmtFmt) Then
					gsMsg = "'由' 之定價與 '由' 之定價有重覆!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = VB6.Format(waResult.get_Value(wlCtr, TOPRICE), gsAmtFmt) Then
					gsMsg = "'由' 之定價與 '至到' 之定價有重覆!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		wsCurRec = VB6.Format(tblDetail.Columns(TOPRICE).Text, gsAmtFmt)
		
		'For wlCtr = 0 To waResult.UpperBound(1)
		'    If inRow <> wlCtr Then
		'        If wsCurRec = Format(waResult(wlCtr, FRPRICE), gsAmtFmt) Then
		'            gsMsg = "'由' 之定價與 '至到' 之定價有重覆!"
		'            MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
		'            Exit Function
		'        End If
		'    End If
		'Next
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = VB6.Format(waResult.get_Value(wlCtr, TOPRICE), gsAmtFmt) Then
					gsMsg = "'至到' 之定價與 '至到' 之定價有重覆!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup = True
	End Function
	
	Private Function Chk_grdFrPrice(ByRef inCode As String) As Boolean
		Chk_grdFrPrice = True
		
		If Trim(inCode) = "" Then
			gsMsg = "必需輸入範圍 '由' 定價之值!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdFrPrice = False
			tblDetail.Col = FRPRICE
			Exit Function
		End If
	End Function
	
	Private Function Chk_grdToPrice(ByRef inCode As String, Optional ByRef inFrPrice As String = "") As Boolean
		Chk_grdToPrice = True
		
		If Trim(inCode) = "" Then
			gsMsg = "必需輸入範圍 '至' 定價之值!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdToPrice = False
			Exit Function
		End If
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inFrPrice) Then
			Exit Function
		End If
		
		If To_Value(inFrPrice) > To_Value(inCode) Then
			gsMsg = "範圍 '至' 定價之值大於 '由' 定價之值!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdToPrice = False
			tblDetail.Col = TOPRICE
			Exit Function
		End If
	End Function
End Class