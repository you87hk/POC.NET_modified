Option Strict Off
Option Explicit On
Friend Class frmJOBMST
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	
	Private wcCombo As System.Windows.Forms.Control
	
	Private Const GSONO As Short = 0
	Private Const GNETAMTL As Short = 1
	Private Const GDOCID As Short = 2
	
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	
	Private wiOpenDoc As Short
	Private wiAction As Short
	
	Private wlCusID As Integer
	Private wsActNam(4) As String
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "MstJobNo"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	
	Private Sub Ini_Scr()
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, GSONO, GDOCID)
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		wiAction = DefaultPage
		
		For	Each MyControl In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			Select Case TypeName(MyControl)
				Case "ComboBox"
					'UPGRADE_WARNING: Couldn't resolve default property of object MyControl.Clear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.Clear()
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
		
		Call SetButtonStatus("AfrActEdit")
		Call SetFieldStatus("Default")
		Call SetFieldStatus("AfrActEdit")
		
		wlCusID = 0
		
		tblCommon.Visible = False
		
		Me.Text = wsFormCaption
		
		FocusMe(cboJobNo)
		
		
	End Sub
	
	
	Private Sub Ini_Scr_AfrKey()
		
		If LoadRecord = False Then Exit Sub
		
		
		wiAction = CorRec
		If RowLock(wsConnTime, wsKeyType, cboJobNo.Text, wsFormID, wsUsrId) = False Then
			gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tblDetail.ReBind()
			
		End If
		
		Call SetButtonStatus("AfrKeyEdit")
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		Call SetFieldStatus("AfrKey")
		
		txtJobCost.Focus()
		
		'If tblDetail.Enabled = True Then
		'    tblDetail.SetFocus
		'End If
		
	End Sub
	
	Private Sub cboJobNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboJobNo
		
		wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
		wsSQL = wsSQL & " FROM SOASOHD, MSTCUSTOMER "
		wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboJobNo.SelectionLength > 0, "", Set_Quote(cboJobNo.Text)) & "%' "
		wsSQL = wsSQL & " AND SOHDSTATUS IN ('1','4') "
		wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
		wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboJobNo.Left)), VB6.PixelsToTwipsY(cboJobNo.Top) + VB6.PixelsToTwipsY(cboJobNo.Height), tblCommon, "JOBMST", "TBLJOBNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboJobNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.Enter
		FocusMe(cboJobNo)
	End Sub
	
	Private Sub cboJobNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboJobNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboJobNo, 20, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			
			If Chk_cboJobNo() = False Then GoTo EventExitSub
			
			Call Ini_Scr_AfrKey()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboJobNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.Leave
		FocusMe(cboJobNo, True)
	End Sub
	
	Private Function Chk_cboJobNo() As Boolean
		Dim wsStatus As String
		
		Chk_cboJobNo = False
		
		If Trim(cboJobNo.Text) = "" Then
			gsMsg = "必需輸入工程編號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboJobNo.Focus()
			Exit Function
		End If
		
		If Chk_JobNo(cboJobNo.Text) = False Then
			gsMsg = "工程編號不存在!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboJobNo.Focus()
			Exit Function
		End If
		
		Chk_cboJobNo = True
	End Function
	
	
	Public Function Chk_JobNo(ByVal inJobNo As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		wsSQL = "Select SOHDDOCNO "
		wsSQL = wsSQL & " From SOASOHD "
		wsSQL = wsSQL & " Where SOHDDOCNO = '" & Set_Quote(inJobNo) & "'"
		wsSQL = wsSQL & " AND SOHDSTATUS IN ('1','4') "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			Chk_JobNo = True
		Else
			Chk_JobNo = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	
	
	
	Public Sub mnuPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopUpSub.Click
		Dim Index As Short = mnuPopUpSub.GetIndex(eventSender)
		Call Call_PopUpMenu(waPopUpSub, Index)
	End Sub
	
	Private Sub txtJobCost_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtJobCost.Enter
		
		FocusMe(txtJobCost)
		
	End Sub
	
	Private Sub txtJobCost_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtJobCost.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtJobCost.Text), False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If chk_txtJobCost Then
				
				If tblDetail.Enabled = True Then
					tblDetail.Focus()
				End If
				
			End If
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function chk_txtJobCost() As Boolean
		
		chk_txtJobCost = False
		
		
		If To_Value((txtJobCost.Text)) <= 0 Then
			gsMsg = "錯誤!一定大於零"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtJobCost.Focus()
			Exit Function
		End If
		
		txtJobCost.Text = VB6.Format(txtJobCost.Text, gsAmtFmt)
		
		chk_txtJobCost = True
		
	End Function
	
	Private Sub txtJobCost_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtJobCost.Leave
		txtJobCost.Text = VB6.Format(txtJobCost.Text, gsAmtFmt)
		FocusMe(txtJobCost, True)
	End Sub
	
	
	
	'UPGRADE_WARNING: Form event frmJOBMST.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmJOBMST_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboJobNo
		End If
	End Sub
	
	Private Sub frmJOBMST_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			
			Case System.Windows.Forms.Keys.F6
				Call cmdOpen()
				
				
				'Case vbKeyF2
				'    If wiAction = DefaultPage Then Call cmdNew
				
				
				'Case vbKeyF5
				'    If wiAction = DefaultPage Then Call cmdEdit
				
				
				'Case vbKeyF3
				'    If wiAction = DefaultPage Then Call cmdDel
				
			Case System.Windows.Forms.Keys.F9
				
				'If tbrProcess.Buttons(tcFind).Enabled = True Then
				'    Call cmdFind
				'End If
				
			Case System.Windows.Forms.Keys.F10
				
				If tbrProcess.Items.Item(tcSave).Enabled = True Then Call cmdSave()
				
			Case System.Windows.Forms.Keys.F11
				
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub frmJOBMST_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Grid()
		Call Ini_Caption()
		Call Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		
		LoadRecord = False
		
		
		wsSQL = "SELECT SOHDDOCID, SOHDDOCNO, SOHDNETAMTL, JOBCOST, SOHDCUSID "
		wsSQL = wsSQL & "FROM SOASOHD, MSTJOBNO "
		wsSQL = wsSQL & "WHERE SOHDJOBNO = '" & Set_Quote(cboJobNo.Text) & "' "
		wsSQL = wsSQL & "AND SOHDJOBNO *= JOBNO "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			txtJobCost.Text = VB6.Format("0", gsAmtFmt)
			
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlCusID = ReadRs(rsRcd, "SOHDCUSID")
		txtJobCost.Text = VB6.Format(To_Value(ReadRs(rsRcd, "JOBCOST")), gsAmtFmt)
		
		
		rsRcd.MoveFirst()
		With waResult
			.ReDim(0, -1, GSONO, GDOCID)
			Do While Not rsRcd.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GSONO) = ReadRs(rsRcd, "SOHDDOCNO")
				waResult.get_Value(.get_UpperBound(1), GNETAMTL) = VB6.Format(To_Value(ReadRs(rsRcd, "SOHDNETAMTL")), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GDOCID) = ReadRs(rsRcd, "SOHDDOCID")
				rsRcd.MoveNext()
			Loop 
		End With
		tblDetail.ReBind()
		tblDetail.FirstRow = 0
		
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadRecord = True
		
	End Function
	
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblJobNo.Text = Get_Caption(waScrItm, "JOBNO")
		lblJobCost.Text = Get_Caption(waScrItm, "JOBCOST")
		
		With tblDetail
			.Columns(GSONO).Caption = Get_Caption(waScrItm, "GSONO")
			.Columns(GNETAMTL).Caption = Get_Caption(waScrItm, "GNETAMTL")
		End With
		
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "IPADD")
		wsActNam(2) = Get_Caption(waScrItm, "IPEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "IPDELETE")
		
		Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	'UPGRADE_WARNING: Event frmJOBMST.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmJOBMST_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(6420)
			Me.Width = VB6.TwipsToPixelsX(6480)
		End If
	End Sub
	
	Private Sub frmJOBMST_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        'UPGRADE_NOTE: Object frmJOBMST may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
    End Sub


    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        If wcCombo.Name = tblDetail.Name Then
            tblDetail.EditActive = True
            wcCombo.Text = tblCommon.Columns(0).Text
        Else
            wcCombo.Text = tblCommon.Columns(0).Text
        End If

        tblCommon.Visible = False
        wcCombo.Focus()
        System.Windows.Forms.SendKeys.Send("{Enter}")

    End Sub

    Private Sub tblCommon_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCommon.KeyDownEvent

        If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
            tblCommon.Visible = False
            wcCombo.Focus()
        ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then
            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
            If wcCombo.Name = tblDetail.Name Then
                tblDetail.EditActive = True
                wcCombo.Text = tblCommon.Columns(0).Text
            Else
                wcCombo.Text = tblCommon.Columns(0).Text
            End If
            tblCommon.Visible = False
            wcCombo.Focus()
            System.Windows.Forms.SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub tblCommon_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.Leave

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub

    Private Function cmdSave() As Boolean
        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wlRowCtr As Integer

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, cboJobNo.Text, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If

        wlRowCtr = waResult.get_UpperBound(1)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_JOBMST"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, GSONO)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, cboJobNo)
                    Call SetSPPara(adcmdSave, 3, txtJobCost)
                    Call SetSPPara(adcmdSave, 4, wiCtr)
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, GDOCID))
                    Call SetSPPara(adcmdSave, 6, gsUserID)
                    Call SetSPPara(adcmdSave, 7, wsGenDte)

                    adcmdSave.Execute()

                End If
            Next
        End If
        cnCon.CommitTrans()

        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing
        cmdSave = True

        gsMsg = "工程已儲存!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

        Call cmdCancel()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing
        cmdSave = True


        Cursor = System.Windows.Forms.Cursors.Default

        Exit Function

cmdSave_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

    End Function

    Private Function InputValidation() As Boolean
        Dim wsExcRate As String
        Dim wsExcDesc As String


        InputValidation = False

        On Error GoTo InputValidation_Err


        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer
        Dim wlCtr1 As Integer


        If Not chk_txtJobCost Then Exit Function

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, GSONO)) <> "" Then

                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If

                    For wlCtr1 = 0 To .get_UpperBound(1)
                        If wlCtr <> wlCtr1 Then
                            If waResult.get_Value(wlCtr, GSONO) = waResult.get_Value(wlCtr1, GSONO) Then
                                gsMsg = "工程已重覆!"
                                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                                Exit Function
                            End If
                        End If
                    Next wlCtr1



                End If
            Next wlCtr
        End With


        If wiEmptyGrid = True Then
            gsMsg = "沒有設定工程!"
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

    Private Sub cmdNew()

        Dim newForm As New frmJOBMST

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()
    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmJOBMST

        newForm.OpenDoc = True
        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
        newForm.Show()

    End Sub

    Private Sub Ini_Form()

        Me.KeyPreview = True
        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "JOBMST"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsTrnCd = "JB"
    End Sub

    Private Sub cmdCancel()
        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("AfrActEdit")
        Call SetButtonStatus("AfrActEdit")

        cboJobNo.Focus()
    End Sub


    Public Property OpenDoc() As Short
        Get
            OpenDoc = wiOpenDoc
        End Get
        Set(ByVal Value As Short)
            wiOpenDoc = Value
        End Set
    End Property

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            If Chk_GrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub



    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmJOBMST.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case tcOpen
                Call cmdOpen()
            Case tcAdd
                Call cmdNew()
                '    Case tcEdit
                '       Call cmdEdit
                'Case tcDelete
                '    Call cmdDel
            Case tcSave
                Call cmdSave()
            Case tcCancel
                If tbrProcess.Items.Item(tcSave).Enabled = True Then
                    If MsgBox("Are you sure to cancel this operation?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
                        Call cmdCancel()
                    End If
                Else
                    Call cmdCancel()
                End If
            Case tcExit
                Me.Close()
        End Select

    End Sub

    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            '  .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = GSONO To GDOCID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case GSONO
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 15

                    Case GNETAMTL
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True

                    Case GDOCID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                End Select
            Next
            ' .Styles("EvenRow").BackColor = &H8000000F
        End With

    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate

        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub


    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wdNetAmtl As Double
        Dim wsSoId As String

        On Error GoTo tblDetail_BeforeColUpdate_Err



        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case GSONO
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdSoNo((.Columns(eventArgs.ColIndex).Text), wsSoId, wdNetAmtl) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(GDOCID).Text = wsSoId
                    .Columns(GNETAMTL).Text = VB6.Format(wdNetAmtl, gsAmtFmt)


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
		Dim wsSQL As String
		Dim wiCtr As Short
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case GSONO
					wsSQL = "SELECT SOHDDOCNO FROM SOASOHD "
					wsSQL = wsSQL & " WHERE SOHDSTATUS <> '2' "
					wsSQL = wsSQL & " AND SOHDCUSID = " & wlCusID & " "
					wsSQL = wsSQL & " AND SOHDDOCNO LIKE '%" & Set_Quote(.Columns(GSONO).Text) & "%' "
					If waResult.get_UpperBound(1) > -1 Then
						wsSQL = wsSQL & " AND SOHDDOCNO NOT IN ( "
						For wiCtr = 0 To waResult.get_UpperBound(1)
							wsSQL = wsSQL & " '" & Set_Quote(waResult.get_Value(wiCtr, GSONO)) & IIf(wiCtr = waResult.get_UpperBound(1), "' )", "' ,")
						Next 
					End If
					
					wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
					
					Call Ini_Combo(1, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLJOBNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
					
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
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					Call tblDetail_ButtonClick(tblDetail, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))
					
				Case System.Windows.Forms.Keys.F5 ' INSERT LINE
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
					If IsEmptyRow Then Exit Sub
					'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
					.ReBind()
					.Focus()
					
				Case System.Windows.Forms.Keys.F8 ' DELETE LINE
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					If IsDbNull(.Bookmark) Then Exit Sub
					If .EditActive = True Then Exit Sub
					gsMsg = "你是否確認要刪除此列?"
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
					If .Col <> GNETAMTL Then
                        eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
						.Col = .Col + 1
					Else
						eventArgs.KeyCode = System.Windows.Forms.Keys.Down
						.Col = GSONO
						
					End If
					
				Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Col <> GSONO Then
						.Col = .Col - 1
					End If
					
				Case System.Windows.Forms.Keys.Right
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Col <> GNETAMTL Then
						.Col = .Col + 1
					End If
					
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
			If IsEmptyRow() Then
				.Col = GSONO
			End If
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					Case GSONO
						Call Chk_grdSoNo((.Columns(GSONO).Text), "", 0)
						
						
				End Select
			End If
		End With
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
	End Sub
	
	Private Function Chk_grdSoNo(ByRef inSoNo As String, ByRef OutSoID As String, ByRef outNetAmtl As Double) As Boolean
		Dim wsSQL As String
		Dim rsDes As New ADODB.Recordset
		
		
		wsSQL = "SELECT SOHDDOCID, SOHDNETAMTL FROM SOASOHD "
		wsSQL = wsSQL & " WHERE SOHDDOCNO = '" & Set_Quote(inSoNo) & "' "
		wsSQL = wsSQL & " And SOHDSTATUS <> '2' "
		wsSQL = wsSQL & " And SOHDCUSID = " & wlCusID
		
		rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsDes.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutSoID = ReadRs(rsDes, "SOHDDOCID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			outNetAmtl = ReadRs(rsDes, "SOHDNETAMTL")
			
			Chk_grdSoNo = True
		Else
			OutSoID = ""
			outNetAmtl = 0
			gsMsg = "沒有此工程!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdSoNo = False
			
		End If
		rsDes.Close()
		'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDes = Nothing
		
		
	End Function
	
	Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean
		
		IsEmptyRow = True
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inRow) Then
			With tblDetail
				If Trim(.Columns(GSONO).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				If Trim(waResult.get_Value(inRow, GSONO)) = "" And Trim(waResult.get_Value(inRow, GNETAMTL)) = "" And Trim(waResult.get_Value(inRow, GDOCID)) = "" Then
					Exit Function
				End If
			End If
		End If
		
		
		IsEmptyRow = False
		
	End Function
	Private Function Chk_GrdRow(ByVal LastRow As Integer) As Boolean
		Dim wlCtr As Integer
		
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
			
			If Chk_grdSoNo(waResult.get_Value(LastRow, GSONO), "", 0) = False Then
				.Col = GSONO
				Exit Function
			End If
			
			
		End With
		
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
	Private Function SaveData() As Boolean
		Dim wiRet As Integer
		
		SaveData = False
		
		If (wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec) And tbrProcess.Items.Item(tcSave).Enabled = True Then
			
			gsMsg = "你是否確定要儲存現時之作業?"
			If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
				Exit Function
			Else
				'If wiAction = DelRec Then
				'    If cmdDel = True Then
				'        Exit Function
				'    End If
				'Else
				If cmdSave = True Then
					Exit Function
				End If
				'End If
			End If
			SaveData = True
		Else
			SaveData = False
		End If
		
	End Function
	
	Public Sub SetButtonStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = True
					.Items.Item(tcEdit).Enabled = True
					.Items.Item(tcDelete).Enabled = True
					.Items.Item(tcSave).Enabled = False
					.Items.Item(tcCancel).Enabled = False
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "AfrActAdd"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcEdit).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = False
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "AfrActEdit"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcEdit).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = False
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcExit).Enabled = True
				End With
				
				
			Case "AfrKeyAdd"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcEdit).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = True
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "AfrKeyEdit"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcEdit).Enabled = False
					.Items.Item(tcDelete).Enabled = True
					.Items.Item(tcSave).Enabled = True
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "ReadOnly"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = False
					.Items.Item(tcCancel).Enabled = False
					.Items.Item(tcExit).Enabled = True
					
				End With
		End Select
	End Sub
	
	'-- Set field status, Default, Add, Edit.
	Public Sub SetFieldStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				
				Me.cboJobNo.Enabled = False
				Me.txtJobCost.Enabled = False
				Me.tblDetail.Enabled = False
				
				
			Case "AfrActAdd"
				
				Me.cboJobNo.Enabled = True
				
			Case "AfrActEdit"
				
				Me.cboJobNo.Enabled = True
				
			Case "AfrKey"
				Me.cboJobNo.Enabled = False
				Me.txtJobCost.Enabled = True
				
				If wiAction = CorRec Then
					Me.tblDetail.Enabled = True
					
				End If
		End Select
	End Sub
	
	
	Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean
		
		Dim wlCtr As Integer
		Dim wsCurRec As String
		Chk_NoDup = False
		
		wsCurRec = tblDetail.Columns(GSONO).Text
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = waResult.get_Value(wlCtr, GSONO) Then
					gsMsg = "工程已重覆!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup = True
		
	End Function
	
	
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
End Class