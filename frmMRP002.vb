Option Strict Off
Option Explicit On
Friend Class frmMRP002
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	'Private waScrToolTip As New XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	
	
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	
	Private wsMark As String
	
	Private wlKey As Integer
	Private wlStaffID As Integer
	Private wlLastRow As Short
	Private wiActFlg As Short
	
	
	Private Const tcConvert As String = "Convert"
	Private Const tcPick As String = "Pick"
	Private Const tcFinish As String = "Finish"
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	
	Private Const SSEL As Short = 0
	Private Const SDOCLINE As Short = 1
	Private Const SDOCNO As Short = 2
	Private Const SITMCODE As Short = 3
	Private Const SITMNAME As Short = 4
	Private Const SVDRCODE As Short = 5
	Private Const SQTY As Short = 6
	Private Const SOUTQTY As Short = 7
	Private Const SREM As Short = 8
	Private Const SAPRFLG As Short = 9
	Private Const SDUMMY As Short = 10
	Private Const SID As Short = 11
	
	
	
	Private Sub cboStaffNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffNo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		
		wsSQL = "SELECT SALECODE, SALENAME FROM mstSalesman WHERE SaleCode LIKE '%" & IIf(cboStaffNo.SelectionLength > 0, "", Set_Quote(cboStaffNo.Text)) & "%' "
		wsSQL = wsSQL & "AND SaleStatus = '1' "
		wsSQL = wsSQL & "AND SaleType = 'W' "
		wsSQL = wsSQL & "ORDER BY SaleCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboStaffNo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboStaffNo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboStaffNo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLSTAFFNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboStaffNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffNo.Enter
		FocusMe(cboStaffNo)
		wcCombo = cboStaffNo
	End Sub
	
	Private Sub cboStaffNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboStaffNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboStaffNo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboStaffNo = False Then GoTo EventExitSub

            tblDetail.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub cboStaffNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffNo.Leave
        FocusMe(cboStaffNo, True)
    End Sub



    'UPGRADE_WARNING: Event frmMRP002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmMRP002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub

    Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDocNoFr



        wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
        wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
        wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
        wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
        wsSQL = wsSQL & " AND SOHDSTATUS = '1' "
        wsSQL = wsSQL & " ORDER BY SOHDDOCNO "

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

            If chk_cboDocNoFr = False Then GoTo EventExitSub

            Call LoadRecord()
            cboStaffNo.Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Function chk_cboDocNoFr() As Boolean
		
		chk_cboDocNoFr = False
		
		If Chk_TrnHdDocNo("SO", cboDocNoFr.Text, "") = False Then
			gsMsg = "Job No Not Exist!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNoFr.Focus()
			Exit Function
		End If
		
		Get_RefDoc()
		
		chk_cboDocNoFr = True
	End Function
	
	Private Function chk_cboStaffNo() As Boolean
		Dim wsName As String
		
		chk_cboStaffNo = False
		
		If Chk_Salesman(cboStaffNo.Text, wlStaffID, wsName) = False Then
			gsMsg = "Worker Not Exist!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboStaffNo.Focus()
			Exit Function
		End If
		
		lblDspName.Text = wsName
		
		chk_cboStaffNo = True
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
	Private Sub frmMRP002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F10
				If tbrProcess.Items.Item(tcConvert).Enabled = False Then Exit Sub
				Call cmdSave()
				
				If tbrProcess.Items.Item(tcPick).Enabled = False Then Exit Sub
				'  Call cmdPick
				
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
			Case System.Windows.Forms.Keys.F5
				Call cmdSelect(1)
				
			Case System.Windows.Forms.Keys.F6
				Call cmdSelect(0)
				
				
				
		End Select
	End Sub
	
	
	
	
	
	
	
	Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
		Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
		
		
		
		Call cmdRefresh()
		
		
		PreviousTab = tabDetailInfo.SelectedIndex()
	End Sub
	
	
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub
		
		
		Select Case Button.Name
			Case tcConvert
				Call cmdSave()
				
			Case tcPick
				'  Call cmdPick
				
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
	
	Private Sub frmMRP002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
		
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, SSEL, SID)
		
		
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		For	Each MyControl In Me.Controls
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
		
		
		
		
		cboDocNoFr.Text = ""
		cboStaffNo.Text = ""
		
		
		
		Call LoadRecord()
		
	End Sub
	
	Private Sub frmMRP002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'   Set waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmMRP002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		'   wsFormID = "MRP002"
	End Sub
	
	
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		'  Call Get_Scr_Item("TOOLTIP_A", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblStaffNo.Text = Get_Caption(waScrItm, "StaffNo")
		lblJobRef.Text = Get_Caption(waScrItm, "JOBREF")
		
		
		
		
		With tblDetail
			.Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
			.Columns(SDOCLINE).Caption = Get_Caption(waScrItm, "SDOCLINE")
			.Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
			.Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SITMCODE")
			.Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SITMNAME")
			.Columns(SVDRCODE).Caption = Get_Caption(waScrItm, "SVDRCODE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SOUTQTY).Caption = Get_Caption(waScrItm, "SOUTQTY")
			.Columns(SREM).Caption = Get_Caption(waScrItm, "SREM")
			.Columns(SAPRFLG).Caption = Get_Caption(waScrItm, "SAPRFLG")
			
		End With
		
		tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "OPT1")
		tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "OPT2")
		
		
		
		With tbrProcess
			.Items.Item(tcConvert).ToolTipText = Get_Caption(waScrItm, tcConvert) & "(F10)"
			.Items.Item(tcPick).ToolTipText = Get_Caption(waScrItm, tcPick)
			.Items.Item(tcFinish).ToolTipText = Get_Caption(waScrItm, tcFinish)
			
			
			.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrItm, tcRefresh) & "(F7)"
			.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrItm, tcCancel) & "(F11)"
			.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrItm, tcSAll) & "(F5)"
			.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrItm, tcDAll) & "(F6)"
			.Items.Item(tcExit).ToolTipText = Get_Caption(waScrItm, tcExit) & "(F12)"
		End With
		
	End Sub
	
	
	Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
		
		With tblDetail
			'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
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
				Case SVDRCODE
					
					If Chk_grdVdrCode(.Columns(eventArgs.ColIndex).Text, .Columns(SITMCODE).Text) = False Then
						GoTo Tbl_BeforeColUpdate_Err
					End If
					
				Case SREM
					If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
						GoTo Tbl_BeforeColUpdate_Err
					End If
					
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
0: 
		Dim wsSQL As String
		Dim wiTop As Integer
		Dim wiCtr As Short
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case SVDRCODE
					
					wsSQL = "SELECT VDRCODE, VDRNAME "
					wsSQL = wsSQL & " FROM mstVENDOR, mstVDRITEM, MSTITEM "
					wsSQL = wsSQL & " WHERE ITMCODE = '" & Set_Quote(.Columns(SITMCODE).Text) & "' "
					wsSQL = wsSQL & " AND VDRID = VDRITEMVDRID "
					wsSQL = wsSQL & " AND ITMID = VDRITEMITMID "
					wsSQL = wsSQL & " AND VDRITEMSTATUS <> '2' "
					wsSQL = wsSQL & " ORDER BY VDRCODE "
					
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.FromPixelsUserX(.Left, 0, 11923.8, 794) + .Columns(eventArgs.ColIndex).Top, VB6.FromPixelsUserY(.Top, 0, 8620.47, 575) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLVDRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_ButtonClick_Err: 
		MsgBox("Check tblDetail ButtonClick!")
		
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
                        Case SREM
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SSEL
                        Case SSEL
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SREM
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
                        Case SAPRFLG
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


                    Case SVDRCODE

                        Call Chk_grdVdrCode(waResult.get_Value(eventArgs.LastRow, SVDRCODE), waResult.get_Value(eventArgs.LastRow, SITMCODE))

                    Case SREM

                        Call Chk_grdQty(waResult.get_Value(eventArgs.LastRow, SREM))

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
					Case SDOCLINE
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Width = 500
					Case SDOCNO
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Width = 1200
					Case SITMCODE
						.Columns(wiCtr).Width = 2000
						.Columns(wiCtr).DataWidth = 30
					Case SITMNAME
						.Columns(wiCtr).Width = 2500
						.Columns(wiCtr).DataWidth = 60
					Case SVDRCODE
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Locked = False
						.Columns(wiCtr).Button = True
					Case SQTY
						.Columns(wiCtr).Width = 600
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
					Case SOUTQTY
						.Columns(wiCtr).Width = 600
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
					Case SREM
						.Columns(wiCtr).Width = 600
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
						.Columns(wiCtr).Locked = False
					Case SAPRFLG
						.Columns(wiCtr).Width = 600
						.Columns(wiCtr).DataWidth = 15
					Case SDUMMY
						.Columns(wiCtr).Width = 100
						.Columns(wiCtr).DataWidth = 0
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
		Dim wiCtr As Short
		Dim wiLastNo As Short
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
        Call Setup_tbrProcess()
		
		Select Case tabDetailInfo.SelectedIndex
			Case 0
				
				wsSQL = "SELECT SODTID DTID, SOPTJDOCLINE DOCLINE, SODTDOCLINE DOCNO, ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME , ITMITMTYPECODE, "
				wsSQL = wsSQL & " SODTTOTQTY QTY, SODTSCHQTY OUTQTY, SODTUPDFLG APRFLG, VDRCODE "
				wsSQL = wsSQL & " FROM  SOASOHD, SOASOPTJ, SOASODT, MSTITEM, mstVendor "
				wsSQL = wsSQL & " WHERE SOHDDOCNO = '" & cboDocNoFr.Text & "' "
				wsSQL = wsSQL & " AND SOHDDOCID = SOPTJDOCID "
				wsSQL = wsSQL & " AND SOPTJID = SODTPTJID "
				wsSQL = wsSQL & " AND SODTITEMID = ITMID "
				wsSQL = wsSQL & " AND SODTVDRID = VDRID "
				wsSQL = wsSQL & " AND SOHDSTATUS = '1'"
				wsSQL = wsSQL & " AND (SODTTOTQTY-SODTSCHQTY) > 0 "
				wsSQL = wsSQL & " ORDER BY SOPTJDOCLINE, SODTDOCLINE "
				
			Case 1
				
				wsSQL = "SELECT PODTID DTID, PODTDOCLINE DOCLINE, POHDDOCNO DOCNO, ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME, ITMITMTYPECODE, "
				wsSQL = wsSQL & " PODTQTY QTY, PODTRECQTY OUTQTY, PODTUPDFLG APRFLG, VDRCODE "
				wsSQL = wsSQL & " FROM POPPOHD, POPPODT, SOASOHD, mstITEM, mstVendor "
				wsSQL = wsSQL & " WHERE SOHDDOCNO = '" & cboDocNoFr.Text & "'"
				wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
				wsSQL = wsSQL & " AND POHDREFDOCID = SOHDDOCID "
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				wsSQL = wsSQL & " AND POHDVDRID = VDRID "
				'  wsSql = wsSql & " AND (PODTQTY-PODTRECQTY) > 0 "
				wsSQL = wsSQL & " ORDER BY POHDDOCNO, PODTDOCLINE "
				
				
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
			'UPGRADE_ISSUE: Form property frmMRP002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If

        wiCtr = 0
        wiLastNo = 0


        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF
                .AppendRows()

                If wiLastNo <> To_Value(ReadRs(rsRcd, "DOCLINE")) Then
                    wiCtr = 1
                Else
                    wiCtr = wiCtr + 1
                End If
                wiLastNo = To_Value(ReadRs(rsRcd, "DOCLINE"))

                waResult.get_Value(.get_UpperBound(1), SSEL) = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCLINE) = VB6.Format(ReadRs(rsRcd, "DOCLINE"), "000")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "DOCNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMCODE) = ReadRs(rsRcd, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMNAME) = ReadRs(rsRcd, "ITMNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SVDRCODE) = ReadRs(rsRcd, "VDRCODE")
                waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SOUTQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "OUTQTY")), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), SREM) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")) - To_Value(ReadRs(rsRcd, "OUTQTY")), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SAPRFLG) = ReadRs(rsRcd, "APRFLG")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "DTID")


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
        'UPGRADE_ISSUE: Form property frmMRP002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.windows.Forms.Cursors.Default ' vbNormal

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


            If Chk_grdVdrCode(waResult.get_Value(LastRow, SVDRCODE), waResult.get_Value(LastRow, SITMCODE)) = False Then
                .Col = SVDRCODE
                .Row = LastRow
                Exit Function
            End If


            If Chk_grdQty(waResult.get_Value(LastRow, SREM)) = False Then
                .Col = SREM
                Exit Function
            End If

            If wiActFlg = 1 Then

                If waResult.get_Value(LastRow, SAPRFLG) = "Y" Then
                    .Col = SAPRFLG
                    gsMsg = "已採購!不能轉移採購單"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    Exit Function
                End If


            End If


        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function


    Private Function Chk_grdQty(ByRef inCode As String) As Boolean

        Chk_grdQty = True

        If Trim(inCode) = "" Then
            gsMsg = "必需輸入數量!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdQty = False
            Exit Function
        End If

        If To_Value(inCode) < 0 Then
            gsMsg = "數量必需大於零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdQty = False
            Exit Function
        End If




    End Function


    Private Function InputValidation() As Boolean
        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        InputValidation = False

        On Error GoTo InputValidation_Err
        wlLastRow = 0
        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If
                    wlLastRow = wlLastRow + 1
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

        If wiActFlg = 2 Then
            If chk_cboStaffNo = False Then
                Exit Function
            End If
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
        'UPGRADE_ISSUE: Form property frmMRP002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.windows.Forms.Cursors.Default ' vbNormal

    End Sub
	
	
	Public WriteOnly Property FormID() As String
		Set(ByVal Value As String)
			wsFormID = Value
		End Set
	End Property
	
	
	
	
	Private Function Get_RefDoc() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Get_RefDoc = False
		
		wsSQL = "SELECT SOHDDOCID, SOHDSHIPFROM, SOHDSHIPTO, SOHDSHIPVIA "
		wsSQL = wsSQL & "FROM  soaSOHD "
		wsSQL = wsSQL & "WHERE SOHDDOCNO = '" & Set_Quote(cboDocNoFr.Text) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		wlKey = To_Value(ReadRs(rsRcd, "SOHDDOCID"))
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspJobRef1.Text = ReadRs(rsRcd, "SOHDSHIPFROM")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspJobRef2.Text = ReadRs(rsRcd, "SOHDSHIPTO")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspJobRef3.Text = ReadRs(rsRcd, "SOHDSHIPVIA")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Get_RefDoc = True
		
	End Function
	
	Private Sub cmdSave()
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wiCtr As Short
		Dim wsDocNo As String
		Dim wsTrnCd As String
		Dim wsDteTim As String
		Dim wiRet As Short
		
		On Error GoTo cmdSave_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		wsDteTim = Change_SQLDate(CStr(Now))
		
		wiActFlg = 1
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		
		gsMsg = "你是否確認要轉換採購單?"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		
		If waResult.get_UpperBound(1) >= 0 Then
			adcmdSave.CommandText = "USP_MRP002A"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
					Call SetSPPara(adcmdSave, 1, wsDteTim)
					Call SetSPPara(adcmdSave, 2, waResult.get_Value(wiCtr, SID))
					Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, SVDRCODE))
					Call SetSPPara(adcmdSave, 4, waResult.get_Value(wiCtr, SREM))
					Call SetSPPara(adcmdSave, 5, wsFormID)
					Call SetSPPara(adcmdSave, 6, gsUserID)
					Call SetSPPara(adcmdSave, 7, wsGenDte)
					adcmdSave.Execute()
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wiRet = GetSPPara(adcmdSave, 8)
					
					If wiRet < 0 Then
						wsDocNo = waResult.get_Value(wiCtr, SITMCODE)
						GoTo USP_MRP002A_Err
					End If
					
				End If
			Next 
		End If
		
		
		
		adcmdSave.CommandText = "USP_MRP002B"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, gsUserID)
		Call SetSPPara(adcmdSave, 2, wsDteTim)
		Call SetSPPara(adcmdSave, 3, wlKey)
		Call SetSPPara(adcmdSave, 4, gsLangID)
		Call SetSPPara(adcmdSave, 5, wsFormID)
		Call SetSPPara(adcmdSave, 6, wsGenDte)
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdSave, 7)
		
		
		cnCon.CommitTrans()
		
		
		gsMsg = "文件 ： " & wsDocNo & " 已完成!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		
		
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
		Exit Sub
		
		
USP_MRP002A_Err: 
		
		gsMsg = "物料 " & wsDocNo & " 供應商價格資料不足夠!不能採購"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
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
	
	
    Private Sub Setup_tbrProcess()

        With tbrProcess

            Select Case tabDetailInfo.SelectedIndex
                Case 0

                    .Items.Item(tcConvert).Enabled = True
                    .Items.Item(tcPick).Enabled = True
                Case 1
                    .Items.Item(tcConvert).Enabled = False
                    .Items.Item(tcPick).Enabled = False

            End Select

            .Items.Item(tcRefresh).Enabled = True
            .Items.Item(tcCancel).Enabled = True
            .Items.Item(tcSAll).Enabled = True
            .Items.Item(tcDAll).Enabled = True
            .Items.Item(tcExit).Enabled = True



        End With

    End Sub
	
	Private Function Chk_grdVdrCode(ByVal inCode As String, ByVal inItmCode As String) As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		
		If Trim(inCode) = "" Then
			gsMsg = "沒有輸入供應商!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		
		wsSQL = "SELECT VdrItemCurr, VdrItemCost, VdrItemUomCode FROM MstVendor, mstVdrItem, MstItem "
		wsSQL = wsSQL & " WHERE VdrCode = '" & Set_Quote(inCode) & "' "
		wsSQL = wsSQL & " And ItmCode = '" & Set_Quote(inItmCode) & "' "
		wsSQL = wsSQL & " And VdrItemVdrID = VdrID "
		wsSQL = wsSQL & " And VdrItemItmID = ItmID "
		wsSQL = wsSQL & " And VdrItemStatus = '1'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			Chk_grdVdrCode = True
		Else
			gsMsg = "沒有此供應商價格!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdVdrCode = False
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
			
		End If
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		
	End Function
End Class