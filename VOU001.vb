Option Strict Off
Option Explicit On
Friend Class frmVOU001
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
	
	Private Const wsKeyType As String = "sysVouNo"
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsFormID As String
	Private wsConnTime As String
	
	Private Sub cboVouPrefix_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVouPrefix.Leave
		FocusMe(cboVouPrefix, True)
	End Sub
	
	Private Sub cboVouType_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVouType.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboVouType
		
		wsSQL = "SELECT MCModNo FROM sysMonCtl "
		wsSQL = wsSQL & "ORDER BY MCModNo"
		Call Ini_Combo(1, wsSQL, (VB6.PixelsToTwipsX(cboVouType.Left)), VB6.PixelsToTwipsY(cboVouType.Top) + VB6.PixelsToTwipsY(cboVouType.Height), tblCommon, wsFormID, "TBLVOUTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVouType_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVouType.Enter
		FocusMe(cboVouType)
	End Sub
	
	Private Sub cboVouType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVouType.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboVouType, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboVouType() = False Then
                GoTo EventExitSub
            End If

            txtVouDesc.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVouType_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVouType.Leave
        FocusMe(cboVouType, True)
    End Sub

    Private Sub chkVouMnFlg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkVouMnFlg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            txtVouSpa.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub chkVouSpa_KeyPress(ByRef KeyAscii As Short)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cboVouType.Focus()
        End If
    End Sub

    Private Sub chkVouYrFlg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkVouYrFlg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            chkVouMnFlg.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmVOU001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmVOU001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        IniForm()
        Ini_Caption()
        Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    'UPGRADE_WARNING: Event frmVOU001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmVOU001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        '-- Resize, not maximum and minimax.
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(4845)
            Me.Width = VB6.TwipsToPixelsX(8700)
        End If
    End Sub

    '-- Set toolbar buttons status in different mode, Default, AddEdit, None.
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
                    .Items.Item(tcFind).Enabled = False
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
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcEdit).Enabled = False
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = False
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcFind).Enabled = True
                    .Items.Item(tcExit).Enabled = True
                End With

            Case "AfrKey"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcEdit).Enabled = False
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcFind).Enabled = False
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
                Me.txtVouPrefix.Enabled = False
                Me.txtVouDesc.Enabled = False
                Me.txtVouLen.Enabled = False
                Me.txtVouLastKey.Enabled = False

                Me.cboVouPrefix.Enabled = False
                Me.cboVouPrefix.Visible = False
                Me.txtVouPrefix.Visible = True
                Me.txtVouPrefix.Enabled = False

                chkVouYrFlg.Enabled = False
                chkVouMnFlg.Enabled = False
                txtVouSpa.Enabled = False
                cboVouType.Enabled = False


            Case "AfrActAdd"
                Me.cboVouPrefix.Enabled = False
                Me.cboVouPrefix.Visible = False

                Me.txtVouPrefix.Enabled = True
                Me.txtVouPrefix.Visible = True

            Case "AfrActEdit"
                Me.cboVouPrefix.Enabled = True
                Me.cboVouPrefix.Visible = True

                Me.txtVouPrefix.Enabled = False
                Me.txtVouPrefix.Visible = False

            Case "AfrKey"
                Me.cboVouPrefix.Enabled = False
                Me.txtVouPrefix.Enabled = False


                Me.txtVouPrefix.Enabled = True
                Me.txtVouDesc.Enabled = True

                Me.txtVouLen.Enabled = True
                Me.txtVouLastKey.Enabled = True

                chkVouYrFlg.Enabled = True
                chkVouMnFlg.Enabled = True
                txtVouSpa.Enabled = True
                cboVouType.Enabled = True
        End Select
    End Sub

    '-- Input validation checking.
    Private Function InputValidation() As Boolean

        InputValidation = False

        'If Chk_txtVouPrefix() = False Then
        '    Exit Function
        'End If

        InputValidation = True
    End Function

    Public Function LoadRecord() As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "From sysVouNo "
        wsSQL = wsSQL & "WHERE (((sysVouNo.VouPrefix)='" & Set_Quote(cboVouPrefix.Text) & "'))"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount = 0 Then
            LoadRecord = False

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboVouPrefix.Text = ReadRs(rsRcd, "VouPrefix")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVouLen.Text = ReadRs(rsRcd, "VouLen")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVouLastKey.Text = ReadRs(rsRcd, "VouLastKey")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVouDesc.Text = ReadRs(rsRcd, "VouDesc")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboVouType.Text = ReadRs(rsRcd, "VouType")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVouSpa.Text = ReadRs(rsRcd, "VouSpa")

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, VouYrFlg). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If ReadRs(rsRcd, "VouYrFlg") = "Y" Then
                chkVouYrFlg.CheckState = System.Windows.Forms.CheckState.Checked
            End If

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, VouMnFlg). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If ReadRs(rsRcd, "VouMnFlg") = "Y" Then
                chkVouMnFlg.CheckState = System.Windows.Forms.CheckState.Checked
            End If

            LoadRecord = True
        End If

        rsRcd.Close()

        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function

    Private Sub frmVOU001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        'UPGRADE_NOTE: Object frmVOU001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
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
        wsFormID = "VOU001"
        wsTrnCd = ""

    End Sub

    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblVouPrefix.Text = Get_Caption(waScrItm, "VOUPREFIX")
        lblVouLen.Text = Get_Caption(waScrItm, "VOULEN")
        lblVouLastKey.Text = Get_Caption(waScrItm, "VOULASTKEY")
        lblVouDesc.Text = Get_Caption(waScrItm, "VOUDESC")
        lblVouType.Text = Get_Caption(waScrItm, "VOUTYPE")

        chkVouYrFlg.Text = Get_Caption(waScrItm, "YRFLG")
        chkVouMnFlg.Text = Get_Caption(waScrItm, "MNFLG")
        lblVouSpa.Text = Get_Caption(waScrItm, "SPA")

        fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")

        tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        wsActNam(1) = Get_Caption(waScrItm, "VOUADD")
        wsActNam(2) = Get_Caption(waScrItm, "VOUEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "VOUDELETE")

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

        chkVouYrFlg.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkVouMnFlg.CheckState = System.Windows.Forms.CheckState.Unchecked

        Call SetFieldStatus("Default")
        Call SetButtonStatus("Default")
        tblCommon.Visible = False
        Me.Text = wsFormCaption
    End Sub

    Private Sub Ini_Scr_AfrAct()
        Select Case wiAction
            Case AddRec

                Call SetFieldStatus("AfrActAdd")
                Call SetButtonStatus("AfrActAdd")
                txtVouPrefix.Focus()

            Case CorRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboVouPrefix.Focus()

            Case DelRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboVouPrefix.Focus()
        End Select

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
    End Sub

    Private Sub Ini_Scr_AfrKey()
        Select Case wiAction

            Case CorRec, DelRec

                If LoadRecord() = False Then
                    gsMsg = "存取記錄失敗! 請聯絡系統管理員或無限系統顧問!"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    Exit Sub
                Else
                    If RowLock(wsConnTime, wsKeyType, cboVouPrefix.Text, wsFormID, wsUsrId) = False Then
                        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                End If
        End Select

        Call SetFieldStatus("AfrKey")
        Call SetButtonStatus("AfrKey")
        txtVouDesc.Focus()
    End Sub

    Private Function Chk_VouPrefix(ByVal inCode As String, ByRef outCode As String) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_VouPrefix = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT VouPrefix "
        wsSQL = wsSQL & " FROM sysVouNo WHERE VouPrefix = '" & Set_Quote(inCode) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            outCode = ""
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        outCode = ReadRs(rsRcd, "VouPrefix")

        Chk_VouPrefix = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_txtVouPrefix() As Boolean
        Dim wsStatus As String

        Chk_txtVouPrefix = False

        If Trim(txtVouPrefix.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVouPrefix.Focus()
            Exit Function
        End If

        If Chk_VouPrefix(txtVouPrefix.Text, wsStatus) = True Then
            gsMsg = "文件號已存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVouPrefix.Focus()
            Exit Function
        End If

        Chk_txtVouPrefix = True
    End Function

    Private Function Chk_cboVouPrefix() As Boolean
        Dim wsStatus As String

        Chk_cboVouPrefix = False

        If Trim(cboVouPrefix.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVouPrefix.Focus()
            Exit Function
        End If

        If Chk_VouPrefix(cboVouPrefix.Text, wsStatus) = False Then
            gsMsg = "文件號不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVouPrefix.Focus()
            Exit Function
        End If

        Chk_cboVouPrefix = True
    End Function

    Private Sub cmdOpen()
        Dim newForm As New frmVOU001

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
            If ReadOnlyMode(wsConnTime, wsKeyType, cboVouPrefix.Text, wsFormID) Then
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

        If wiAction = AddRec Then
            If Chk_KeyExist() = True Then
                Call GetNewKey()
            End If
        End If

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_VOU001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, IIf(wiAction = AddRec, txtVouPrefix.Text, cboVouPrefix.Text))
        Call SetSPPara(adcmdSave, 3, txtVouDesc)
        Call SetSPPara(adcmdSave, 4, txtVouLen)
        Call SetSPPara(adcmdSave, 5, txtVouLastKey)
        Call SetSPPara(adcmdSave, 6, IIf(chkVouYrFlg.CheckState = 0, "N", "Y"))
        Call SetSPPara(adcmdSave, 7, IIf(chkVouMnFlg.CheckState = 0, "N", "Y"))
        Call SetSPPara(adcmdSave, 8, txtVouSpa)
        Call SetSPPara(adcmdSave, 9, cboVouType)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 10)

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - VOU001!"
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
        Call OpenPromptForm()
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

    Private Sub OpenPromptForm()
        Dim wsOutCode As String
        Dim wsSQL As String

        Dim vFilterAry(2, 2) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 1) = "文件號編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 2) = "VouPrefix"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "長度"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "VouLen"

        Dim vAry(2, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "文件號編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "VouPrefix"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "長度"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "VouLen"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "5000"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            wsSQL = "SELECT sysVouNo.VouPrefix, sysVouNo.VouLen "
            wsSQL = wsSQL & "FROM sysVouNo "
            .sBindSQL = wsSQL
            .sBindWhereSQL = ""
            .sBindOrderSQL = "ORDER BY sysVouNo.VouPrefix"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmVOU001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

        If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboVouPrefix.Text Then
            cboVouPrefix.Text = Trim(frmShareSearch.Tag)
            cboVouPrefix.Focus()
            System.Windows.Forms.SendKeys.Send("{Enter}")
        End If
        frmShareSearch.Close()
    End Sub

    Private Sub txtVouDesc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouDesc.Enter
        FocusMe(txtVouDesc)
    End Sub

    Private Sub txtVouDesc_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVouDesc.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVouDesc, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtVouLen.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVouDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouDesc.Leave
        FocusMe(txtVouDesc, True)
    End Sub

    Private Sub txtVouLastKey_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouLastKey.Enter
        FocusMe(txtVouLastKey)
    End Sub

    Private Sub txtVouLastKey_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVouLastKey.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtVouLastKey.Text, False, False)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            chkVouYrFlg.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVouLastKey_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouLastKey.Leave
        FocusMe(txtVouLastKey, True)
    End Sub

    Private Sub txtVouLen_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouLen.Enter
        FocusMe(txtVouLen)
    End Sub

    Private Sub txtVouLen_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVouLen.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtVouLen.Text, False, False)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtVouLen() = True Then
                txtVouLastKey.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVouLen_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouLen.Leave
        FocusMe(txtVouLen, True)
    End Sub

    Private Sub txtVouPrefix_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouPrefix.Enter
        FocusMe(txtVouPrefix)
    End Sub

    Private Sub txtVouPrefix_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouPrefix.Leave
        FocusMe(txtVouPrefix, True)
    End Sub

    Private Sub txtVouPrefix_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVouPrefix.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVouPrefix, 3, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtVouPrefix() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_txtVouLen() As Boolean
        Chk_txtVouLen = False

        If Trim(txtVouLen.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVouLen.Focus()
            Exit Function
        End If

        If Not (CDbl(txtVouLen.Text) >= 0 And CDbl(txtVouLen.Text) <= 12) Then
            gsMsg = "長度必須少於十二!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVouLen.Focus()
            Exit Function
        End If

        Chk_txtVouLen = True
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

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub

    Private Sub cboVouPrefix_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVouPrefix.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLenA(cboVouPrefix, 3, KeyAscii, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboVouPrefix() = True Then
                Call Ini_Scr_AfrKey()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVouPrefix_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVouPrefix.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVouPrefix

        wsSQL = "SELECT VouPrefix, VouDesc FROM sysVouNo WHERE "
        wsSQL = wsSQL & " VouPrefix LIKE '%" & IIf(cboVouPrefix.SelectionLength > 0, "", Set_Quote(cboVouPrefix.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY VouPrefix "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboVouPrefix.Left)), VB6.PixelsToTwipsY(cboVouPrefix.Top) + VB6.PixelsToTwipsY(cboVouPrefix.Height), tblCommon, wsFormID, "TBLVOUPREFIX", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboVouPrefix_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVouPrefix.Enter
        FocusMe(cboVouPrefix)
    End Sub

    Private Function Chk_KeyExist() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT VouPrefix FROM SysVouNo WHERE VouPrefix = '" & Set_Quote(txtVouPrefix.Text) & "'"
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            Chk_KeyExist = True
        Else
            Chk_KeyExist = False
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub GetNewKey()
        Dim Newfrm As New frmKeyInput

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Create Selection Criteria
        With Newfrm
            .TableID = wsKeyType
            .TableType = wsTrnCd
            .TableKey = "VouPrefix"
            .KeyLen = 10
            .ctlKey = txtVouPrefix
            .ShowDialog()
        End With

        'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Newfrm = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Function Chk_cboVouType() As Boolean
        Chk_cboVouType = False

        If UCase(cboVouType.Text) = "" Then
            gsMsg = "必需輸入文件類別!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVouType.Focus()
            Exit Function
        End If

        If Chk_VouType(cboVouType.Text) = False Then
            gsMsg = "文件類別不正確!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVouType.Focus()
            Exit Function
        End If

        Chk_cboVouType = True
    End Function

    Private Function Chk_VouType(ByVal inCode As String) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_VouType = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT MCModNo "
        wsSQL = wsSQL & " FROM sysMonCtl WHERE sysMonCtl.MCModNo = '" & Set_Quote(inCode) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            Chk_VouType = True
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub txtVouSpa_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouSpa.Enter
        FocusMe(txtVouSpa)
    End Sub

    Private Sub txtVouSpa_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVouSpa.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVouSpa, 1, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboVouType.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtVouSpa_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVouSpa.Leave
		FocusMe(txtVouSpa, True)
	End Sub
End Class