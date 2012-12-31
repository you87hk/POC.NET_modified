Option Strict Off
Option Explicit On
Friend Class frmAT001
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
	
	Private Const wsKeyType As String = "MstAccountType"
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsFormID As String
	Private wsConnTime As String
	
	Private Sub cboAccTypeCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCode.Leave
		FocusMe(cboAccTypeCode, True)
	End Sub
	
	Private Sub cboAccTypeCOSML_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCOSML.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboAccTypeCOSML
		
		wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
		wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboAccTypeCOSML.SelectionLength > 0, "", Set_Quote(cboAccTypeCOSML.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY MLCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboAccTypeCOSML.Left)), VB6.PixelsToTwipsY(cboAccTypeCOSML.Top) + VB6.PixelsToTwipsY(cboAccTypeCOSML.Height), tblCommon, "AT001", "TBLACCTYPECOSML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboAccTypeCOSML_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCOSML.Enter
		FocusMe(cboAccTypeCOSML)
	End Sub
	
	Private Sub cboAccTypeCOSML_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccTypeCOSML.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboAccTypeCOSML, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboAccTypeCOSML() = True Then
                cboAccTypeINVML.Focus()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboAccTypeCOSML_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCOSML.Leave
        FocusMe(cboAccTypeCOSML, True)
    End Sub

    Private Sub cboAccTypeINVML_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeINVML.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboAccTypeINVML

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboAccTypeINVML.SelectionLength > 0, "", Set_Quote(cboAccTypeINVML.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboAccTypeINVML.Left)), VB6.PixelsToTwipsY(cboAccTypeINVML.Top) + VB6.PixelsToTwipsY(cboAccTypeINVML.Height), tblCommon, "AT001", "TBLACCTYPEINVML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboAccTypeINVML_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeINVML.Enter
        FocusMe(cboAccTypeINVML)
    End Sub

    Private Sub cboAccTypeINVML_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccTypeINVML.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccTypeINVML, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboAccTypeINVML() = True Then
                cboAccTypeSALML.Focus()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboAccTypeINVML_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeINVML.Leave
        FocusMe(cboAccTypeINVML, True)
    End Sub

    Private Sub cboAccTypeSALML_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeSALML.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboAccTypeSALML

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboAccTypeSALML.SelectionLength > 0, "", Set_Quote(cboAccTypeSALML.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboAccTypeSALML.Left)), VB6.PixelsToTwipsY(cboAccTypeSALML.Top) + VB6.PixelsToTwipsY(cboAccTypeSALML.Height), tblCommon, "AT001", "TBLACCTYPESALML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboAccTypeSALML_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeSALML.Enter
        FocusMe(cboAccTypeSALML)
    End Sub

    Private Sub cboAccTypeSALML_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccTypeSALML.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccTypeSALML, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboAccTypeSALML() = True Then
                txtAccTypeDesc.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboAccTypeSALML_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeSALML.Leave
        FocusMe(cboAccTypeSALML, True)
    End Sub

    Private Sub frmAT001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmAT001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        IniForm()
        Ini_Caption()
        Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    'UPGRADE_WARNING: Event frmAT001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmAT001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        '-- Resize, not maximum and minimax.
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(4320)
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
                Me.txtAccTypeDesc.Enabled = False
                Me.cboAccTypeCOSML.Enabled = False
                Me.cboAccTypeINVML.Enabled = False
                Me.cboAccTypeSALML.Enabled = False

                Me.cboAccTypeCode.Enabled = False
                Me.cboAccTypeCode.Visible = False
                Me.txtAccTypeCode.Visible = True
                Me.txtAccTypeCode.Enabled = False

            Case "AfrActAdd"
                Me.cboAccTypeCode.Enabled = False
                Me.cboAccTypeCode.Visible = False

                Me.txtAccTypeCode.Enabled = True
                Me.txtAccTypeCode.Visible = True

            Case "AfrActEdit"
                Me.cboAccTypeCode.Enabled = True
                Me.cboAccTypeCode.Visible = True

                Me.txtAccTypeCode.Enabled = False
                Me.txtAccTypeCode.Visible = False

            Case "AfrKey"
                Me.cboAccTypeCode.Enabled = False
                Me.txtAccTypeCode.Enabled = False

                Me.cboAccTypeCOSML.Enabled = True
                Me.cboAccTypeINVML.Enabled = True
                Me.cboAccTypeSALML.Enabled = True
                Me.txtAccTypeDesc.Enabled = True
        End Select
    End Sub

    '-- Input validation checking.
    Private Function InputValidation() As Boolean

        InputValidation = False

        If Chk_txtAccTypeDesc = False Then
            Exit Function
        End If

        If Chk_cboAccTypeCOSML = False Then
            Exit Function
        End If

        If Chk_cboAccTypeINVML = False Then
            Exit Function
        End If

        If Chk_cboAccTypeSALML = False Then
            Exit Function
        End If

        InputValidation = True
    End Function

    Public Function LoadRecord() As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "From MstAccountType "
        wsSQL = wsSQL & "WHERE (((MstAccountType.AccTypeCode)='" & Set_Quote(cboAccTypeCode.Text) & "' AND AccTypeStatus = '1'))"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount = 0 Then
            LoadRecord = False

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboAccTypeCode.Text = ReadRs(rsRcd, "AccTypeCode")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtAccTypeDesc.Text = ReadRs(rsRcd, "AccTypeDesc")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboAccTypeCOSML.Text = ReadRs(rsRcd, "AccTypeCOSML")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboAccTypeINVML.Text = ReadRs(rsRcd, "AccTypeINVML")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboAccTypeSALML.Text = ReadRs(rsRcd, "AccTypeSALML")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.lblDspAccTypeLastUpd.Text = ReadRs(rsRcd, "AccTypeLastUpd")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.lblDspAccTypeLastUpdDate.Text = ReadRs(rsRcd, "AccTypeLastUpdDate")

            LoadRecord = True
        End If

        rsRcd.Close()

        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function

    Private Sub frmAT001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        'UPGRADE_NOTE: Object frmAT001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        wsFormID = "AT001"
        wsTrnCd = ""

    End Sub


    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblAccTypeCode.Text = Get_Caption(waScrItm, "ACCTYPECODE")
        lblAccTypeDesc.Text = Get_Caption(waScrItm, "ACCTYPEDESC")
        lblAccTypeCOSML.Text = Get_Caption(waScrItm, "ACCTYPECOSML")
        lblAccTypeINVML.Text = Get_Caption(waScrItm, "ACCTYPEINVML")
        lblAccTypeSALML.Text = Get_Caption(waScrItm, "ACCTYPESALML")
        lblAccTypeLastUpd.Text = Get_Caption(waScrItm, "ACCTYPELASTUPD")
        lblAccTypeLastUpdDate.Text = Get_Caption(waScrItm, "ACCTYPELASTUPDDATE")

        fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")

        tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        wsActNam(1) = Get_Caption(waScrItm, "ATADD")
        wsActNam(2) = Get_Caption(waScrItm, "ATEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "ATDELETE")

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


        wiAction = DefaultPage

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
                txtAccTypeCode.Focus()

            Case CorRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboAccTypeCode.Focus()

            Case DelRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboAccTypeCode.Focus()
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
                    If RowLock(wsConnTime, wsKeyType, cboAccTypeCode.Text, wsFormID, wsUsrId) = False Then
                        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                End If
        End Select

        Call SetFieldStatus("AfrKey")
        Call SetButtonStatus("AfrKey")
        txtAccTypeDesc.Focus()
    End Sub

    Private Function Chk_AccTypeCode(ByVal inCode As String, ByRef outCode As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_AccTypeCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT AccTypeStatus "
        wsSQL = wsSQL & " FROM MstAccountType WHERE AccTypeCode = '" & Set_Quote(inCode) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            outCode = ""
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        outCode = ReadRs(rsRcd, "AccTypeStatus")

        Chk_AccTypeCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_txtAccTypeCode() As Boolean
        Dim wsStatus As String

        Chk_txtAccTypeCode = False

        If Trim(txtAccTypeCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtAccTypeCode.Focus()
            Exit Function
        End If

        If Chk_AccTypeCode(txtAccTypeCode.Text, wsStatus) = True Then

            If wsStatus = "2" Then
                gsMsg = "會計版別已存在但已無效!"
            Else
                gsMsg = "會計版別已存在!"
            End If

            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtAccTypeCode.Focus()
            Exit Function

        End If

        Chk_txtAccTypeCode = True
    End Function

    Private Function Chk_cboAccTypeCode() As Boolean
        Dim wsStatus As String

        Chk_cboAccTypeCode = False

        If Trim(cboAccTypeCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboAccTypeCode.Focus()
            Exit Function
        End If

        If Chk_AccTypeCode(cboAccTypeCode.Text, wsStatus) = False Then

            gsMsg = "會計版別不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboAccTypeCode.Focus()
            Exit Function

        Else

            If wsStatus = "2" Then
                gsMsg = "會計版別已存在但已無效!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboAccTypeCode.Focus()
                Exit Function
            End If

        End If

        Chk_cboAccTypeCode = True

    End Function

    Private Sub cmdOpen()
        Dim newForm As New frmAT001

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
            If ReadOnlyMode(wsConnTime, wsKeyType, cboAccTypeCode.Text, wsFormID) Then
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

        adcmdSave.CommandText = "USP_AT001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, IIf(wiAction = AddRec, txtAccTypeCode.Text, cboAccTypeCode.Text))
        Call SetSPPara(adcmdSave, 3, txtAccTypeDesc)
        Call SetSPPara(adcmdSave, 4, cboAccTypeCOSML)
        Call SetSPPara(adcmdSave, 5, cboAccTypeINVML)
        Call SetSPPara(adcmdSave, 6, cboAccTypeSALML)
        Call SetSPPara(adcmdSave, 7, gsUserID)
        Call SetSPPara(adcmdSave, 8, wsGenDte)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 9)

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - AT001!"
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

        Dim vFilterAry(5, 2) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 1) = "會計版別編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 2) = "AccTypeCode"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "註解"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "AccTypeDesc"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "銷售成本會計級別"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "AccTypeCOSML"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(4, 1) = "存貨會計級別"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(4, 2) = "AccTypeINVML"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(5, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(5, 1) = "銷售會計級別"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(5, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(5, 2) = "AccTypeSALML"

        Dim vAry(5, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "會計版別編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "AccTypeCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "註解"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "AccTypeDesc"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "4000"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 1) = "銷售成本會計級別"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 2) = "AccTypeCOSML"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 1) = "存貨會計級別"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 2) = "AccTypeINVML"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(5, 1) = "銷售會計級別"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(5, 2) = "AccTypeSALML"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(5, 3) = "1500"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            wsSQL = "SELECT MstAccountType.AccTypeCode, MstAccountType.AccTypeDesc "
            wsSQL = wsSQL & "FROM MstAccountType "
            .sBindSQL = wsSQL
            .sBindWhereSQL = "WHERE MstAccountType.AccTypeStatus = '1' "
            .sBindOrderSQL = "ORDER BY MstAccountType.AccTypeCode"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmAT001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

        If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboAccTypeCode.Text Then
            cboAccTypeCode.Text = Trim(frmShareSearch.Tag)
            cboAccTypeCode.Focus()
            System.Windows.Forms.SendKeys.Send("{Enter}")
        End If
        frmShareSearch.Close()

    End Sub

    Private Sub txtAccTypeCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAccTypeCode.Enter
        FocusMe(txtAccTypeCode)
    End Sub

    Private Sub txtAccTypeCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAccTypeCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLenA(txtAccTypeCode, 10, KeyAscii, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            If Chk_txtAccTypeCode() = True Then
                Call Ini_Scr_AfrKey()
            End If


        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtAccTypeCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAccTypeCode.Leave
        FocusMe(txtAccTypeCode, True)
    End Sub

    Private Sub txtAccTypeDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAccTypeDesc.Leave
        FocusMe(txtAccTypeDesc, True)
    End Sub

    Private Sub txtAccTypeDesc_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAccTypeDesc.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtAccTypeDesc, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtAccTypeDesc() = True Then
                cboAccTypeCOSML.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtAccTypeDesc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAccTypeDesc.Enter
        FocusMe(txtAccTypeDesc)
    End Sub

    Private Function Chk_txtAccTypeDesc() As Boolean

        Chk_txtAccTypeDesc = False

        If Trim(txtAccTypeDesc.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtAccTypeDesc.Focus()
            Exit Function
        End If

        Chk_txtAccTypeDesc = True
    End Function

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
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub

    Private Sub cboAccTypeCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboAccTypeCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboAccTypeCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboAccTypeCode() = True Then
                Call Ini_Scr_AfrKey()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub cboAccTypeCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboAccTypeCode
		
		wsSQL = "SELECT AccTypeCode, AccTypeDesc FROM MstAccountType WHERE AccTypeStatus = '1'"
		wsSQL = wsSQL & " AND AccTypeCode LIKE '%" & IIf(cboAccTypeCode.SelectionLength > 0, "", Set_Quote(cboAccTypeCode.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY AccTypeCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboAccTypeCode.Left)), VB6.PixelsToTwipsY(cboAccTypeCode.Top) + VB6.PixelsToTwipsY(cboAccTypeCode.Height), tblCommon, "AT001", "TBLACCTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboAccTypeCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAccTypeCode.Enter
		FocusMe(cboAccTypeCode)
	End Sub
	
	Private Function Chk_KeyExist() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		wsSQL = "SELECT AccTypeStatus FROM MstAccountType WHERE AccTypeCode = '" & Set_Quote(txtAccTypeCode.Text) & "'"
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
			.TableKey = "AccTypeCode"
			.KeyLen = 10
			.ctlKey = txtAccTypeCode
			.ShowDialog()
		End With
		
		'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Newfrm = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Function Chk_cboAccTypeCOSML() As Boolean
		Dim wsStatus As String
		
		Chk_cboAccTypeCOSML = False
		
		If Trim(cboAccTypeCOSML.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboAccTypeCOSML.Focus()
			Exit Function
		End If
		
		If Chk_AccTypeML(cboAccTypeCOSML.Text, wsStatus) = False Then
			
			gsMsg = "銷售成本會計級別不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboAccTypeCOSML.Focus()
			Exit Function
			
		Else
			
			If wsStatus = "2" Then
				gsMsg = "銷售成本會計級別已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboAccTypeCOSML.Focus()
				Exit Function
			End If
			
		End If
		
		Chk_cboAccTypeCOSML = True
		
	End Function
	
	Private Function Chk_cboAccTypeINVML() As Boolean
		Dim wsStatus As String
		
		Chk_cboAccTypeINVML = False
		
		If Trim(cboAccTypeINVML.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboAccTypeINVML.Focus()
			Exit Function
		End If
		
		If Chk_AccTypeML(cboAccTypeINVML.Text, wsStatus) = False Then
			gsMsg = "存貨會計級別不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboAccTypeINVML.Focus()
			Exit Function
		Else
			If wsStatus = "2" Then
				gsMsg = "存貨會計級別已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboAccTypeINVML.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboAccTypeINVML = True
	End Function
	
	Private Function Chk_cboAccTypeSALML() As Boolean
		Dim wsStatus As String
		
		Chk_cboAccTypeSALML = False
		
		If Trim(cboAccTypeSALML.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboAccTypeSALML.Focus()
			Exit Function
		End If
		
		If Chk_AccTypeML(cboAccTypeSALML.Text, wsStatus) = False Then
			gsMsg = "銷售會計級別不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboAccTypeSALML.Focus()
			Exit Function
		Else
			If wsStatus = "2" Then
				gsMsg = "銷售會計級別已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboAccTypeSALML.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboAccTypeSALML = True
	End Function
	
	
	Private Function Chk_AccTypeML(ByVal inCode As String, ByRef outCode As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_AccTypeML = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSQL = "SELECT MLStatus "
		wsSQL = wsSQL & " FROM MstMerchClass WHERE MLCode = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			outCode = ""
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "MLStatus")
		
		Chk_AccTypeML = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
End Class