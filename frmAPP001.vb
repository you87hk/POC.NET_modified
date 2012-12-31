Option Strict Off
Option Explicit On
Friend Class frmAPP001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	'Private waScrToolTip As New XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	
	
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wiActFlg As Short
	Private wsMark As String
	
	Private wlKey As Integer
	Private wlStaffID As Integer
	Private wlLastRow As Short
	
	Private Const tcConvert As String = "Convert"
	Private Const tcCan As String = "Can"
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
	Private Const SITMTYPE As Short = 5
	Private Const SQTY As Short = 6
	Private Const SOUTQTY As Short = 7
	Private Const SREM As Short = 8
	Private Const SDUMMY As Short = 9
	Private Const SID As Short = 10
	
	
	
	Private Sub cboStaffNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboStaffNo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsSQL = "SELECT StaffCode, StaffName FROM mstStaff WHERE StaffCode LIKE '%" & IIf(cboStaffNo.SelectionLength > 0, "", Set_Quote(cboStaffNo.Text)) & "%' "
		wsSQL = wsSQL & " AND StaffStatus <> '2' "
		wsSQL = wsSQL & " ORDER BY Staffcode "
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



    'UPGRADE_WARNING: Event frmAPP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmAPP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub

    Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDocNoFr



        wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
        wsSQL = wsSQL & " FROM POPPOHD, mstVENDOR "
        wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
        wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
        wsSQL = wsSQL & " AND POHDSTATUS = '1' "
        wsSQL = wsSQL & " ORDER BY POHDDOCNO "

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
		
		If Chk_TrnHdDocNo("PO", cboDocNoFr.Text, "") = False Then
			gsMsg = "Purchase No Not Exist!"
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
		
		If Chk_Staff(cboStaffNo.Text, wlStaffID, wsName) = False Then
			gsMsg = "Satff Not Exist!"
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
	Private Sub frmAPP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F2
				If tbrProcess.Items.Item(tcConvert).Enabled = False Then Exit Sub
				Call cmdPick(1)
				
			Case System.Windows.Forms.Keys.F3
				If tbrProcess.Items.Item(tcCan).Enabled = False Then Exit Sub
				Call cmdPick(2)
				
			Case System.Windows.Forms.Keys.F7
				Call cmdRefresh()
				
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
				Call cmdPick(1)
				
			Case tcCan
				Call cmdPick(2)
				
				
				
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
	
	Private Sub frmAPP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
                    'MyControl.ClearFields()
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


        Call Setup_tbrProcess()
        Call LoadRecord()

    End Sub

    Private Sub frmAPP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        '   Set waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmAPP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing


    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
        '   wsFormID = "APP001"
    End Sub


    Private Sub Setup_tbrProcess()

        With tbrProcess

            Select Case tabDetailInfo.SelectedIndex
                Case 0

                    .Items.Item(tcConvert).Enabled = True
                    .Items.Item(tcCan).Enabled = False
                    .Items.Item(tcFinish).Enabled = False
                Case 1
                    .Items.Item(tcConvert).Enabled = False
                    .Items.Item(tcCan).Enabled = True
                    .Items.Item(tcFinish).Enabled = True

                Case 2

                    .Items.Item(tcConvert).Enabled = False
                    .Items.Item(tcCan).Enabled = False
                    .Items.Item(tcFinish).Enabled = True

            End Select

            .Items.Item(tcRefresh).Enabled = True
            .Items.Item(tcCancel).Enabled = True
            .Items.Item(tcSAll).Enabled = True
            .Items.Item(tcDAll).Enabled = True
            .Items.Item(tcExit).Enabled = True



        End With

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
			.Columns(SITMTYPE).Caption = Get_Caption(waScrItm, "SITMTYPE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SOUTQTY).Caption = Get_Caption(waScrItm, "SOUTQTY")
			.Columns(SREM).Caption = Get_Caption(waScrItm, "SREM")
			
		End With
		
		tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "OPT1")
		tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "OPT2")
		tabDetailInfo.TabPages.Item(2).Text = Get_Caption(waScrItm, "OPT3")
		
		
		
		With tbrProcess
			.Items.Item(tcConvert).ToolTipText = Get_Caption(waScrItm, tcConvert) & "(F2)"
			.Items.Item(tcCan).ToolTipText = Get_Caption(waScrItm, tcCan) & "(F3)"
			.Items.Item(tcFinish).ToolTipText = Get_Caption(waScrItm, tcFinish) & "(F10)"
			
			
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
				Case SSEL
					
					'   If .Columns(ColIndex).Text = "-1" Then
					'       Call Chk_Sel(.Row + To_Value(.FirstRow))
					'    End If
					
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
		
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		
		
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
                        Case SREM
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
						.Columns(wiCtr).Width = 2500
						.Columns(wiCtr).DataWidth = 30
					Case SITMNAME
						.Columns(wiCtr).Width = 2600
						.Columns(wiCtr).DataWidth = 60
					Case SITMTYPE
						.Columns(wiCtr).Width = 1800
						.Columns(wiCtr).DataWidth = 10
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
						'      .Columns(wiCtr).Locked = False
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
		Dim wiCtr As Integer
		Dim wdCreLmt As Double
		Dim wdCreLft As Double
		Dim wsStatus As String
		Dim wdQty As Double
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		
		
		Select Case tabDetailInfo.SelectedIndex
			Case 0
				
				wsSQL = "SELECT PODTID DTID, PODTDOCLINE DOCLINE, POHDDOCNO DOCNO, ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME , ITMITMTYPECODE, "
				wsSQL = wsSQL & " PODTQTY QTY, PODTRECQTY OUTQTY "
				wsSQL = wsSQL & " FROM  POPPOHD, POPPODT, MSTITEM "
				wsSQL = wsSQL & " WHERE POHDDOCNO = '" & cboDocNoFr.Text & "' "
				wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				wsSQL = wsSQL & " AND POHDSTATUS = '1'"
				wsSQL = wsSQL & " AND (PODTQTY-PODTRECQTY) > 0 "
				wsSQL = wsSQL & " ORDER BY PODTDOCLINE, POHDDOCNO "
				
			Case 1
				
				wsSQL = "SELECT PVDTID DTID, PVDTDOCLINE DOCLINE, PVHDDOCNO DOCNO, ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME, ITMITMTYPECODE, "
				wsSQL = wsSQL & " PVDTQTY QTY, PVDTQTY OUTQTY "
				wsSQL = wsSQL & " FROM POPPOHD, POPPVHD, POPPVDT, mstITEM "
				wsSQL = wsSQL & " WHERE POHDDOCNO = '" & cboDocNoFr.Text & "'"
				wsSQL = wsSQL & " AND PVHDDOCID = PVDTDOCID "
				wsSQL = wsSQL & " AND PVHDREFDOCID = POHDDOCID "
				wsSQL = wsSQL & " AND PVDTITEMID = ITMID "
				wsSQL = wsSQL & " AND PVHDAPRFLG = 'N' "
				wsSQL = wsSQL & " ORDER BY PVHDDOCNO, PVDTDOCLINE "
				
			Case 2
				
				wsSQL = "SELECT PVDTID DTID, PVDTDOCLINE DOCLINE, PVHDDOCNO DOCNO, ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME, ITMITMTYPECODE, "
				wsSQL = wsSQL & " PVDTQTY QTY, PVDTQTY OUTQTY "
				wsSQL = wsSQL & " FROM POPPOHD, POPPVHD, POPPVDT, mstITEM "
				wsSQL = wsSQL & " WHERE POHDDOCNO = '" & cboDocNoFr.Text & "'"
				wsSQL = wsSQL & " AND PVHDDOCID = PVDTDOCID "
				wsSQL = wsSQL & " AND PVHDREFDOCID = POHDDOCID "
				wsSQL = wsSQL & " AND PVDTITEMID = ITMID "
				wsSQL = wsSQL & " AND PVHDAPRFLG = 'Y' "
				wsSQL = wsSQL & " ORDER BY PVHDDOCNO, PVDTDOCLINE "
				
				
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
			'UPGRADE_ISSUE: Form property frmAPP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If



        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF


                .AppendRows()
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
                waResult.get_Value(.get_UpperBound(1), SITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
                waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SOUTQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "OUTQTY")), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), SREM) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")) - To_Value(ReadRs(rsRcd, "OUTQTY")), gsQtyFmt)
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
        'UPGRADE_ISSUE: Form property frmAPP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

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


            If Chk_grdQty(waResult.get_Value(LastRow, SREM)) = False Then
                .Col = SREM
                Exit Function
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

        If wiActFlg = 1 Then
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
        'UPGRADE_ISSUE: Form property frmAPP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

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
		
		wsSQL = "SELECT POHDDOCID, VDRCODE, VDRNAME, VDRCONTACTNAME "
		wsSQL = wsSQL & "FROM  POPPOHD, MSTVENDOR "
		wsSQL = wsSQL & "WHERE POHDDOCNO = '" & Set_Quote(cboDocNoFr.Text) & "' "
		wsSQL = wsSQL & "AND POHDVDRID = VDRID "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		wlKey = To_Value(ReadRs(rsRcd, "POHDDOCID"))
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspJobRef1.Text = ReadRs(rsRcd, "VDRCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspJobRef2.Text = ReadRs(rsRcd, "VDRNAME")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspJobRef3.Text = ReadRs(rsRcd, "VDRCONTACTNAME")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Get_RefDoc = True
		
	End Function
	
	Private Sub cmdPick(ByVal inActFlg As Short)
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wiCtr As Short
		Dim wsDocNo As String
		Dim wlLineNo As Integer
		Dim wlHDID As Integer
		Dim wsTrnCd As String
		
		On Error GoTo cmdPick_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		wiActFlg = inActFlg
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		wsTrnCd = "PV"
		
		
		If inActFlg = 1 Then
			gsMsg = "你是否確認要轉換進貨?"
		Else
			gsMsg = "你是否確認刪除物料?"
		End If
		
		
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		wlLineNo = 1
		wlHDID = 0
		
		If waResult.get_UpperBound(1) >= 0 Then
			adcmdSave.CommandText = "USP_APP001A"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
					Call SetSPPara(adcmdSave, 1, wiActFlg)
					Call SetSPPara(adcmdSave, 2, wsTrnCd)
					Call SetSPPara(adcmdSave, 3, wlKey)
					Call SetSPPara(adcmdSave, 4, wlHDID)
					Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, SID))
					Call SetSPPara(adcmdSave, 6, wlLineNo)
					Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, SREM))
					Call SetSPPara(adcmdSave, 8, wlStaffID)
					Call SetSPPara(adcmdSave, 9, wsFormID)
					Call SetSPPara(adcmdSave, 10, gsUserID)
					Call SetSPPara(adcmdSave, 11, wsGenDte)
					Call SetSPPara(adcmdSave, 12, IIf(wlLastRow = wlLineNo, "Y", "N"))
					
					adcmdSave.Execute()
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wlHDID = GetSPPara(adcmdSave, 13)
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wsDocNo = GetSPPara(adcmdSave, 14)
					wlLineNo = wlLineNo + 1
				End If
			Next 
		End If
		
		
		cnCon.CommitTrans()
		
		
		gsMsg = "文件 ： " & wsDocNo & " 已完成!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		
		
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
cmdPick_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
	End Sub
End Class