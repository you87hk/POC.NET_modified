Option Strict Off
Option Explicit On
Friend Class frmSYS001
	Inherits System.Windows.Forms.Form
	
	Private wsFormCaption As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	
	Private wiAction As Short
	
	Private wcCombo As System.Windows.Forms.Control
	
	Private wsActNam(4) As String
	'Row Lock Variable
	
	Private Const wsKeyType As String = "SysDocNo"
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsFormID As String
	Private wsConnTime As String
	
	Private Sub frmSYS001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F6
				Call cmdOpen()
				
			Case System.Windows.Forms.Keys.F2
				If wiAction = DefaultPage Then Call cmdNew()
				
			Case System.Windows.Forms.Keys.F5
				If wiAction = DefaultPage Then Call cmdEdit()
				
			Case System.Windows.Forms.Keys.F3
				If wiAction = DefaultPage Then Call cmdDel()
				
			Case System.Windows.Forms.Keys.F9
				If tbrProcess.Items.Item(tcFind).Enabled = True Then
					Call cmdFind()
				End If
				
			Case System.Windows.Forms.Keys.F10
				If tbrProcess.Items.Item(tcSave).Enabled = True Then
					Call cmdSave()
				End If
				
			Case System.Windows.Forms.Keys.F11
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
		End Select
	End Sub
	
	Private Sub frmSYS001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	'UPGRADE_WARNING: Event frmSYS001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmSYS001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'-- Resize, not maximum and minimax.
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(4575)
			Me.Width = VB6.TwipsToPixelsX(8700)
		End If
	End Sub
	
	'-- Set toolbar buttons status in different mode, Default, AddEdit, None.
	Public Sub SetButtonStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				With tbrProcess
					.Items.Item(tcSave).Enabled = True
					.Items.Item(tcCancel).Enabled = True
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
					.Items.Item(tcFind).Enabled = False
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "AfrActEdit"
				With tbrProcess
					.Items.Item(tcSave).Enabled = True
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "AfrKey"
				With tbrProcess
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
					.Items.Item(tcFind).Enabled = True
					.Items.Item(tcExit).Enabled = True
					
				End With
		End Select
	End Sub
	
	'-- Set field status, Default, Add, Edit.
	Public Sub SetFieldStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				Me.txtSyPHisLog.Enabled = True
				Me.medSyPMinDte.Enabled = True
				Me.medSyPMaxDte.Enabled = True
				Me.optSyPStkVal(0).Enabled = True
				Me.optSyPStkVal(1).Enabled = True
				Me.optSyPStkVal(2).Enabled = True
				
				Me.txtSyPRecID.Enabled = False
				
			Case "AfrActAdd"
				
			Case "AfrActEdit"
				Me.txtSyPRecID.Enabled = False
				
				Me.txtSyPHisLog.Enabled = True
				Me.medSyPMinDte.Enabled = True
				Me.medSyPMaxDte.Enabled = True
				Me.optSyPStkVal(0).Enabled = True
				Me.optSyPStkVal(1).Enabled = True
				Me.optSyPStkVal(2).Enabled = True
				
			Case "AfrKey"
				Me.txtSyPRecID.Enabled = False
				
				Me.txtSyPHisLog.Enabled = True
				Me.medSyPMinDte.Enabled = True
				Me.medSyPMaxDte.Enabled = True
				Me.optSyPStkVal(0).Enabled = True
				Me.optSyPStkVal(1).Enabled = True
				Me.optSyPStkVal(2).Enabled = True
		End Select
	End Sub
	
	'-- Input validation checking.
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_DateRange() = False Then
			Exit Function
		End If
		
		If Chk_txtSyPHisLog() = False Then
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	Public Function LoadRecord() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		wsSQL = "SELECT * "
		wsSQL = wsSQL & "From SysConst "
		wsSQL = wsSQL & "WHERE (((SysConst.SyPRecID)='01'))"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtSyPRecID.Text = ReadRs(rsRcd, "SyPRecID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtSyPHisLog.Text = ReadRs(rsRcd, "SyPHisLog")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.medSyPMinDte.Text = VB6.Format(ReadRs(rsRcd, "SyPMinDte"), "YYYY/MM/DD")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.medSyPMaxDte.Text = VB6.Format(ReadRs(rsRcd, "SyPMaxDte"), "YYYY/MM/DD")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspSyPLUpUsr.Text = ReadRs(rsRcd, "SyPLUpUsr")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspSyPLUpDte.Text = ReadRs(rsRcd, "SyPLUpDte")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SetStkVal(ReadRs(rsRcd, "SyPStkVal"))
			
			LoadRecord = True
		End If
		
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Private Sub frmSYS001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Exit Sub
		End If
		Call UnLockAll(wsConnTime, wsFormID)
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object frmSYS001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
	End Sub
	
	Private Sub optSyPStkVal_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optSyPStkVal.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optSyPStkVal.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            medSyPMinDte.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case tcOpen
                Call cmdOpen()

            Case tcAdd
                Call cmdNew()

            Case tcEdit
                Call cmdEdit()

            Case tcDelete

                Call cmdDel()

            Case tcSave

                Call cmdSave()

            Case tcCancel

                If tbrProcess.Items.Item(tcSave).Enabled = True Then
                    gsMsg = "你是否確定儲存現時之變更而離開?"
                    If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                        Call cmdCancel()
                    End If
                Else
                    Call cmdCancel()
                End If

            Case tcFind

                Call cmdFind()

            Case tcExit

                Me.Close()

        End Select
    End Sub

    Private Sub IniForm()
        Me.KeyPreview = True
        '  Me.Left = 0
        '  Me.Top = 0
        '  Me.Width = Screen.Width
        '  Me.Height = Screen.Height


        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "SYS001"
        wsTrnCd = ""

    End Sub


    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblSyPRecID.Text = Get_Caption(waScrItm, "SYPRECID")
        FraSyPStkVal.Text = Get_Caption(waScrItm, "SYPSTKVAL")
        lblSyPHisLog.Text = Get_Caption(waScrItm, "SYPHISLOG")
        lblSyPMinDte.Text = Get_Caption(waScrItm, "SYPMINDTE")
        lblSyPMaxDte.Text = Get_Caption(waScrItm, "SYPMAXDTE")

        lblSyPLUpUsr.Text = Get_Caption(waScrItm, "SYPLUPUSR")
        lblSyPLUpDte.Text = Get_Caption(waScrItm, "SYPLUPDTE")

        fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")

        optSyPStkVal(0).Text = Get_Caption(waScrItm, "SYPSTKVAL01")
        optSyPStkVal(1).Text = Get_Caption(waScrItm, "SYPSTKVAL02")
        optSyPStkVal(2).Text = Get_Caption(waScrItm, "SYPSTKVAL03")

        'tbrProcess.Buttons(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        'tbrProcess.Buttons(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        'tbrProcess.Buttons(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        'tbrProcess.Buttons(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        'tbrProcess.Buttons(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        wsActNam(1) = Get_Caption(waScrItm, "SYSADD")
        wsActNam(2) = Get_Caption(waScrItm, "SYSEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "SYSDELETE")

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub

    Private Sub Ini_Scr()
        Dim MyControl As System.Windows.Forms.Control

        For Each MyControl In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            Select Case TypeName(MyControl)
                Case "ComboBox"
                    'UPGRADE_WARNING: Couldn't resolve default property of object MyControl.Clear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.Clear()
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

        wiAction = DefaultPage

        Call SetDateMask(medSyPMinDte)
        Call SetDateMask(medSyPMaxDte)

        Call SetFieldStatus("Default")
        Call SetButtonStatus("Default")
        tblCommon.Visible = False
        Me.Text = wsFormCaption

        If LoadRecord() = False Then
            gsMsg = "存取記錄失敗! 請聯絡系統管理員或無限系統顧問!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Sub
        Else
            If RowLock(wsConnTime, wsKeyType, txtSyPRecID.Text, wsFormID, wsUsrId) = False Then
                gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            End If
        End If
        wiAction = CorRec
        Ini_Scr_AfrAct()
        'Call SetFieldStatus("AfrKey")
        'Call SetButtonStatus("AfrKey")
        'txtSyPHisLog.SetFocus
    End Sub

    Private Sub Ini_Scr_AfrAct()
        Select Case wiAction
            Case AddRec

            Case CorRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                'txtSyPHisLog.SetFocus

            Case DelRec

        End Select

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
    End Sub



    Private Sub cmdOpen()
        Dim newForm As New frmSYS001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
        newForm.Show()
    End Sub

    Private Sub cmdNew()
        wiAction = AddRec
        Ini_Scr_AfrAct()
    End Sub

    Private Sub cmdEdit()
        wiAction = CorRec
        Ini_Scr_AfrAct()
    End Sub

    Private Sub cmdDel()
        wiAction = DelRec
        Ini_Scr_AfrAct()
    End Sub

    Private Sub cmdCancel()
        If tbrProcess.Items.Item(tcSave).Enabled = True Then
            Select Case wiAction
                Case AddRec
                    Call Ini_Scr()
                    Call cmdNew()

                Case CorRec
                    Call UnLockAll(wsConnTime, wsFormID)
                    Call Ini_Scr()
                    Call cmdEdit()

                Case DelRec
                    Call UnLockAll(wsConnTime, wsFormID)
                    Call Ini_Scr()
                    Call cmdDel()
            End Select
        Else
            Call Ini_Scr()
        End If
    End Sub

    Private Function cmdSave() As Boolean
        Dim wsGenDte As String
        Dim wsNo As String
        Dim adcmdSave As New ADODB.Command

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = VB6.Format(Today, "YYYY/MM/DD")

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, txtSyPRecID.Text, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If wiAction = DelRec Then
            If MsgBox("你是否確定要刪除此記錄?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                cmdCancel()
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        Else
            If InputValidation() = False Then
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If


        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_SYS001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, txtSyPRecID)
        Call SetSPPara(adcmdSave, 3, GetStkVal())
        Call SetSPPara(adcmdSave, 4, txtSyPHisLog)
        Call SetSPPara(adcmdSave, 5, medSyPMinDte)
        Call SetSPPara(adcmdSave, 6, medSyPMaxDte)
        Call SetSPPara(adcmdSave, 7, gsUserID)
        Call SetSPPara(adcmdSave, 8, wsGenDte)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 9)

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - SYS001!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        Else
            If wiAction = DelRec Then
                gsMsg = "已成功刪除!"
            Else
                gsMsg = "已成功儲存!"
            End If

            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        End If

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

    Private Sub cmdFind()

    End Sub

    Private Function SaveData() As Boolean
        SaveData = False

        If (wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec) And tbrProcess.Items.Item(tcSave).Enabled = True Then
            gsMsg = "你是否確定要儲存現時之作業?"
            If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                Exit Function
            Else
                If cmdSave = True Then
                    Exit Function
                End If
            End If
            SaveData = True
        Else
            SaveData = False
        End If
    End Function



    Private Function Chk_txtSyPHisLog() As Boolean
        Chk_txtSyPHisLog = False

        If Trim(txtSyPHisLog.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtSyPHisLog.Focus()
            Exit Function
        End If

        If Not (CDbl(txtSyPHisLog.Text) >= 0 And CDbl(txtSyPHisLog.Text) <= 12) Then
            gsMsg = "長度必須少於十二!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtSyPHisLog.Focus()
            Exit Function
        End If

        Chk_txtSyPHisLog = True
    End Function

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





    Private Sub SetStkVal(ByVal inCode As String)
        Select Case inCode
            Case "1"
                optSyPStkVal(0).Checked = True

            Case "3"
                optSyPStkVal(1).Checked = True

            Case "4"
                optSyPStkVal(2).Checked = True
        End Select
    End Sub

    Private Function GetStkVal() As String
        Dim iCounter As Short

        For iCounter = 0 To 2
            If optSyPStkVal(iCounter).Checked = True Then
                Exit For
            End If
        Next

        Select Case iCounter
            Case 0
                GetStkVal = "1"

            Case 1
                GetStkVal = "3"

            Case 2
                GetStkVal = "4"

        End Select
    End Function

    Private Sub txtSyPHisLog_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSyPHisLog.Enter
        FocusMe(txtSyPHisLog)
    End Sub

    Private Sub txtSyPHisLog_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSyPHisLog.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim iCounter As Short

        Call Chk_InpNum(KeyAscii, txtSyPHisLog.Text, False, False)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtSyPHisLog() = True Then
                For iCounter = 0 To 5
                    If optSyPStkVal(iCounter).Checked = True Then
                        Exit For
                    End If
                Next

                optSyPStkVal(iCounter).Checked = True
                optSyPStkVal(iCounter).Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtSyPHisLog_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSyPHisLog.Leave
		FocusMe(txtSyPHisLog, True)
	End Sub
	
	Private Sub medSyPMinDte_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medSyPMinDte.Enter
		FocusMe(medSyPMinDte)
	End Sub
	
	Private Sub medSyPMinDte_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medSyPMinDte.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			If Chk_medSyPMinDte Then
				medSyPMaxDte.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub medSyPMinDte_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medSyPMinDte.Leave
		FocusMe(medSyPMinDte, True)
	End Sub
	
	Private Function Chk_medSyPMinDte() As Boolean
		Chk_medSyPMinDte = False
		
		If Trim(medSyPMinDte.Text) = "/  /" Then
			gsMsg = "日期錯誤!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medSyPMinDte.Focus()
			Exit Function
		End If
		
		If Chk_Date(medSyPMinDte) = False Then
			gsMsg = "日期錯誤!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medSyPMinDte.Focus()
			Exit Function
		End If
		
		Chk_medSyPMinDte = True
	End Function
	
	Private Sub medSyPMaxDte_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medSyPMaxDte.Enter
		FocusMe(medSyPMaxDte)
	End Sub
	
	Private Sub medSyPMaxDte_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medSyPMaxDte.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			If Chk_medSyPMaxDte Then
				txtSyPHisLog.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub medSyPMaxDte_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medSyPMaxDte.Leave
		FocusMe(medSyPMaxDte, True)
	End Sub
	
	Private Function Chk_medSyPMaxDte() As Boolean
		Chk_medSyPMaxDte = False
		
		If Trim(medSyPMaxDte.Text) = "/  /" Then
			gsMsg = "日期錯誤!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medSyPMaxDte.Focus()
			Exit Function
		End If
		
		If Chk_Date(medSyPMaxDte) = False Then
			gsMsg = "日期錯誤!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medSyPMaxDte.Focus()
			Exit Function
		End If
		
		Chk_medSyPMaxDte = True
	End Function
	
	Private Function Chk_DateRange() As Boolean
		Chk_DateRange = False
		
		If medSyPMinDte.Text > medSyPMaxDte.Text Then
			gsMsg = "最小日期大於最大日期!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medSyPMinDte.Focus()
			Exit Function
		End If
		
		Chk_DateRange = True
	End Function
End Class