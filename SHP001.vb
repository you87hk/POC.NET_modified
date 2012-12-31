Option Strict Off
Option Explicit On
Friend Class frmSHP001
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
	Private wlCardID As Integer
	
	Private wcCombo As System.Windows.Forms.Control
	
	Private wsActNam(4) As String
	'Row Lock Variable
	
	Private Const wsKeyType As String = "MstShip"
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsFormID As String
	Private wsConnTime As String
	
	Private Sub cboCardCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCardCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCardCode
		
		If optCard(0).Checked = True Then
			wsSQL = "SELECT VdrCode, VdrName FROM MstVendor WHERE VdrStatus = '1'"
			wsSQL = wsSQL & " AND VdrInactive = 'N' "
			wsSQL = wsSQL & " AND VdrCode LIKE '%" & IIf(cboCardCode.SelectionLength > 0, "", Set_Quote(cboCardCode.Text)) & "%' "
			wsSQL = wsSQL & "ORDER BY VdrCode "
		ElseIf optCard(1).Checked = True Then 
			wsSQL = "SELECT CusCode, CusName FROM MstCustomer WHERE CusStatus = '1'"
			wsSQL = wsSQL & " AND CusInactive = 'N' "
			wsSQL = wsSQL & " AND CusCode LIKE '%" & IIf(cboCardCode.SelectionLength > 0, "", Set_Quote(cboCardCode.Text)) & "%' "
			wsSQL = wsSQL & "ORDER BY CusCode "
		End If
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCardCode.Left)), VB6.PixelsToTwipsY(cboCardCode.Top) + VB6.PixelsToTwipsY(cboCardCode.Height), tblCommon, "SHP001", "TBLC", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCardCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCardCode.Enter
		FocusMe(cboCardCode)
	End Sub
	
	Private Sub cboCardCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCardCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCardCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCardCode() = True Then
                If wiAction = AddRec Then
                    txtShipCode.Focus()
                Else
                    cboShipCode.Focus()
                End If
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCardCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCardCode.Leave
        FocusMe(cboCardCode, True)
    End Sub

    Private Sub cboShipCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.Leave
        FocusMe(cboShipCode, True)
    End Sub

    Private Sub frmSHP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmSHP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        IniForm()
        Ini_Caption()
        Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    'UPGRADE_WARNING: Event frmSHP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmSHP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        '-- Resize, not maximum and minimax.
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(5910)
            Me.Width = VB6.TwipsToPixelsX(9015)
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
                txtShipCode.Enabled = False
                cboShipCode.Enabled = False

                txtShipName.Enabled = False
                picShipAdr.Enabled = False

                txtShipTelNo.Enabled = False
                txtShipFaxNo.Enabled = False
                txtShipPer.Enabled = False
                txtShipRemark.Enabled = False

                Me.cboShipCode.Visible = False
                Me.txtShipCode.Visible = True

                optCard(1).Enabled = False
                optCard(0).Enabled = False

                cboCardCode.Enabled = False

            Case "AfrActAdd"
                cboShipCode.Enabled = False
                cboShipCode.Visible = False

                txtShipCode.Enabled = True
                txtShipCode.Visible = True

                optCard(1).Enabled = True
                optCard(0).Enabled = True

                cboCardCode.Enabled = True

            Case "AfrActEdit"
                cboShipCode.Enabled = True
                cboShipCode.Visible = True

                txtShipCode.Enabled = False
                txtShipCode.Visible = False

                optCard(1).Enabled = True
                optCard(0).Enabled = True

                cboCardCode.Enabled = True

            Case "AfrKey"
                cboShipCode.Enabled = False
                txtShipCode.Enabled = False

                txtShipName.Enabled = True
                picShipAdr.Enabled = True

                txtShipTelNo.Enabled = True
                txtShipFaxNo.Enabled = True
                txtShipPer.Enabled = True
                txtShipRemark.Enabled = True

                If optCard(0).Checked = True Then
                    optCard(1).Enabled = False
                    optCard(0).Enabled = False
                Else
                    optCard(0).Enabled = False
                    optCard(1).Enabled = False
                End If

                cboCardCode.Enabled = False
        End Select
    End Sub

    '-- Input validation checking.
    Private Function InputValidation() As Boolean

        InputValidation = False

        If Chk_txtShipName = False Then
            Exit Function
        End If

        InputValidation = True
    End Function

    Public Function LoadRecord() As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset
        Dim iCounter As Short
        Dim wiCardClass As Short
        Dim wlCardID As Integer

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "From MstShip "
        wsSQL = wsSQL & "WHERE (((MstShip.ShipCode)='" & Set_Quote(cboShipCode.Text) & "' AND ShipStatus = '1'))"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount = 0 Then
            LoadRecord = False

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboShipCode.Text = ReadRs(rsRcd, "ShipCode")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipName.Text = ReadRs(rsRcd, "ShipName")

            For iCounter = 1 To 4
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, ShipAdr & iCounter). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                txtShipAdr(iCounter).Text = ReadRs(rsRcd, "ShipAdr" & iCounter)
            Next iCounter

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipTelNo.Text = ReadRs(rsRcd, "ShipTelNo")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipFaxNo.Text = ReadRs(rsRcd, "ShipFaxNo")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipPer.Text = ReadRs(rsRcd, "Shipper")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipRemark.Text = ReadRs(rsRcd, "ShipRemark")

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            lblDspShipLastUpd.Text = ReadRs(rsRcd, "ShipLastUpd")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            lblDspShipLastUpdDate.Text = ReadRs(rsRcd, "ShipLastUpdDate")

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wiCardClass = ReadRs(rsRcd, "ShipCardClass")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wlCardID = ReadRs(rsRcd, "ShipCardID")

            If wiCardClass = 1 Then
                optCard(0).Checked = True

                wsSQL = "SELECT  VdrCode CardCode "
                wsSQL = wsSQL & "FROM MstVendor "
                wsSQL = wsSQL & "WHERE (MstVendor.VdrID)=" & CStr(wlCardID)
            Else
                optCard(1).Checked = True

                wsSQL = "SELECT  CusCode CardCode "
                wsSQL = wsSQL & "From MstCustomer "
                wsSQL = wsSQL & "WHERE (MstCustomer.CusID)=" & CStr(wlCardID)
            End If

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing

            rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

            If rsRcd.RecordCount <> 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                cboCardCode.Text = ReadRs(rsRcd, "CardCode")
            End If

            LoadRecord = True
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub frmSHP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        'UPGRADE_NOTE: Object frmSHP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        '   Me.Left = 0
        '   Me.Top = 0
        '   Me.Width = Screen.Width
        '   Me.Height = Screen.Height

        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "SHP001"
        wsTrnCd = ""
    End Sub

    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblShipCode.Text = Get_Caption(waScrItm, "SHIPCODE")
        lblShipName.Text = Get_Caption(waScrItm, "SHIPNAME")
        lblShipAdr.Text = Get_Caption(waScrItm, "SHIPADR")
        lblShipTelNo.Text = Get_Caption(waScrItm, "SHIPTELNO")
        lblShipFaxNo.Text = Get_Caption(waScrItm, "SHIPFAXNO")
        lblShipPer.Text = Get_Caption(waScrItm, "SHIPPER")
        lblShipRemark.Text = Get_Caption(waScrItm, "SHIPREMARK")
        lblShipLastUpd.Text = Get_Caption(waScrItm, "SHIPLASTUPD")
        lblShipLastUpdDate.Text = Get_Caption(waScrItm, "SHIPLASTUPDDATE")
        lblCardCode.Text = Get_Caption(waScrItm, "CARDCODE")

        tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        optCard(0).Text = Get_Caption(waScrItm, "OPTCARD0")
        optCard(1).Text = Get_Caption(waScrItm, "OPTCARD1")

        fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")

        wsActNam(1) = Get_Caption(waScrItm, "SHPADD")
        wsActNam(2) = Get_Caption(waScrItm, "SHPEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "SHPDELETE")

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
                cboCardCode.Focus()

            Case CorRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboCardCode.Focus()

            Case DelRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboShipCode.Focus()
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
                    If RowLock(wsConnTime, wsKeyType, cboShipCode.Text, wsFormID, wsUsrId) = False Then
                        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                End If
        End Select

        Call SetFieldStatus("AfrKey")
        Call SetButtonStatus("AfrKey")
        txtShipName.Focus()
    End Sub

    Private Function Chk_ShipCode(ByVal inCode As String, ByRef outCode As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_ShipCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT ShipStatus "
        wsSQL = wsSQL & " FROM MstShip WHERE ShipCode = '" & Set_Quote(inCode) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            outCode = ""
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        outCode = ReadRs(rsRcd, "ShipStatus")

        Chk_ShipCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_txtShipCode() As Boolean
        Dim wsStatus As String

        Chk_txtShipCode = False

        If Trim(cboCardCode.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboCardCode.Focus()
            Exit Function
        End If

        Call GetCardID(cboCardCode.Text, wlCardID)

        If wlCardID = 0 Then
            gsMsg = "沒有輸入正確之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboCardCode.Focus()
            Exit Function
        End If

        If Trim(txtShipCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtShipCode.Focus()
            Exit Function
        End If

        If Chk_ShipCode(txtShipCode.Text, wsStatus) = True Then

            If wsStatus = "2" Then
                gsMsg = "貨運編碼已存在但已無效!"
            Else
                gsMsg = "貨運編碼已存在!"
            End If

            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtShipCode.Focus()
            Exit Function

        End If

        Chk_txtShipCode = True
    End Function

    Private Function Chk_cboShipCode() As Boolean
        Dim wsStatus As String

        Chk_cboShipCode = False

        If Trim(cboShipCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboShipCode.Focus()
            Exit Function
        End If

        If Chk_ShipCode(cboShipCode.Text, wsStatus) = False Then

            gsMsg = "貨運編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboShipCode.Focus()
            Exit Function

        Else

            If wsStatus = "2" Then
                gsMsg = "貨運編碼已存在但已無效!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboShipCode.Focus()
                Exit Function
            End If

        End If

        Chk_cboShipCode = True
    End Function

    Private Sub cmdOpen()
        Dim newForm As New frmSHP001

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
            If ReadOnlyMode(wsConnTime, wsKeyType, cboShipCode.Text, wsFormID) Then
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

        GetCardID(cboCardCode.Text, wlCardID)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_SHP001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wlCardID)
        Call SetSPPara(adcmdSave, 3, IIf(optCard(0).Checked = True, 1, 2))
        Call SetSPPara(adcmdSave, 4, IIf(wiAction = AddRec, txtShipCode.Text, cboShipCode.Text))
        Call SetSPPara(adcmdSave, 5, txtShipName)
        Call SetSPPara(adcmdSave, 6, txtShipAdr(1))
        Call SetSPPara(adcmdSave, 7, txtShipAdr(2))
        Call SetSPPara(adcmdSave, 8, txtShipAdr(3))
        Call SetSPPara(adcmdSave, 9, txtShipAdr(4))
        Call SetSPPara(adcmdSave, 10, txtShipTelNo)
        Call SetSPPara(adcmdSave, 11, txtShipFaxNo)
        Call SetSPPara(adcmdSave, 12, txtShipPer)
        Call SetSPPara(adcmdSave, 13, txtShipRemark)
        Call SetSPPara(adcmdSave, 14, gsUserID)
        Call SetSPPara(adcmdSave, 15, wsGenDte)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 16)

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - SHP001!"
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
        vFilterAry(1, 1) = "貨運編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 2) = "ShipCode"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "名稱"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "ShipName"

        Dim vAry(2, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "貨運編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "ShipCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "名稱"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "ShipName"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "5000"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            wsSQL = "SELECT MstShip.ShipCode, MstShip.ShipName "
            wsSQL = wsSQL & "FROM MstShip "
            .sBindSQL = wsSQL
            .sBindWhereSQL = "WHERE MstShip.ShipStatus = '1' "
            .sBindOrderSQL = "ORDER BY MstShip.ShipCode"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmSHP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

        If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboShipCode.Text Then
            cboShipCode.Text = Trim(frmShareSearch.Tag)
            cboShipCode.Focus()
            System.Windows.Forms.SendKeys.Send("{Enter}")
        End If
        frmShareSearch.Close()

    End Sub

    Private Sub txtShipAdr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr.Enter
        Dim Index As Short = txtShipAdr.GetIndex(eventSender)
        FocusMe(txtShipAdr(Index))
    End Sub

    Private Sub txtShipAdr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipAdr.GetIndex(eventSender)
        Call chk_InpLen(txtShipAdr(Index), 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Index = 4 Then
                txtShipTelNo.Focus()
            Else
                txtShipAdr(Index + 1).Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr.Leave
        Dim Index As Short = txtShipAdr.GetIndex(eventSender)
        FocusMe(txtShipAdr(Index), True)
    End Sub

    Private Sub txtShipCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipCode.Enter
        FocusMe(txtShipCode)
    End Sub

    Private Sub txtShipCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtShipCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipCode.Leave
        FocusMe(txtShipCode, True)
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

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub

    Private Sub cboShipCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboShipCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboShipCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboShipCode() = True Then
                Call Ini_Scr_AfrKey()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboShipCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboShipCode


        If optCard(0).Checked = True Then

            wsSQL = "SELECT ShipCode, VdrCode, ShipName  FROM MstShip, MstVendor"
            wsSQL = wsSQL & " WHERE ShipStatus = '1' "
            wsSQL = wsSQL & " AND ShipCardClass = 1 "
            wsSQL = wsSQL & " AND ShipCardID = VdrID "
            wsSQL = wsSQL & " AND VdrCode LIKE '%" & IIf(cboCardCode.SelectionLength > 0, "", Set_Quote(cboCardCode.Text)) & "%' "
            wsSQL = wsSQL & " AND ShipCode LIKE '%" & IIf(cboShipCode.SelectionLength > 0, "", Set_Quote(cboShipCode.Text)) & "%' "
            wsSQL = wsSQL & " ORDER BY ShipCode "

        Else

            wsSQL = "SELECT ShipCode, CusCode, ShipName  FROM MstShip, MstCustomer"
            wsSQL = wsSQL & " WHERE ShipStatus = '1' "
            wsSQL = wsSQL & " AND ShipCardClass = 2 "
            wsSQL = wsSQL & " AND ShipCardID = CusID "
            wsSQL = wsSQL & " AND CusCode LIKE '%" & IIf(cboCardCode.SelectionLength > 0, "", Set_Quote(cboCardCode.Text)) & "%' "
            wsSQL = wsSQL & " AND ShipCode LIKE '%" & IIf(cboShipCode.SelectionLength > 0, "", Set_Quote(cboShipCode.Text)) & "%' "
            wsSQL = wsSQL & " ORDER BY ShipCode "

        End If

        Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboShipCode.Left)), VB6.PixelsToTwipsY(cboShipCode.Top) + VB6.PixelsToTwipsY(cboShipCode.Height), tblCommon, "SHP001", "TBLSHP", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboShipCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.Enter
        FocusMe(cboShipCode)
    End Sub

    Private Function Chk_KeyExist() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT ShipStatus FROM MstShip WHERE ShipCode = '" & Set_Quote(txtShipCode.Text) & "'"
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
            .TableKey = "ShipCode"
            .KeyLen = 10
            .ctlKey = txtShipCode
            .ShowDialog()
        End With

        'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Newfrm = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txtShipName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipName.Enter
        FocusMe(txtShipName)
    End Sub

    Private Sub txtShipName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtShipName, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtShipName() = True Then
                txtShipAdr(1).Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipName.Leave
        FocusMe(txtShipName, True)
    End Sub

    Private Function Chk_txtShipName() As Boolean
        Chk_txtShipName = False

        If Len(Trim(txtShipName.Text)) <= 0 Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtShipName.Focus()
            Exit Function
        End If

        Chk_txtShipName = True
    End Function

    Private Sub txtShipTelNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipTelNo.Enter
        FocusMe(txtShipTelNo)
    End Sub

    Private Sub txtShipTelNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipTelNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtShipTelNo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtShipFaxNo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipTelNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipTelNo.Leave
        FocusMe(txtShipTelNo, True)
    End Sub

    Private Sub txtShipFaxNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipFaxNo.Enter
        FocusMe(txtShipFaxNo)
    End Sub

    Private Sub txtShipFaxNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipFaxNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtShipFaxNo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtShipPer.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipFaxNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipFaxNo.Leave
        FocusMe(txtShipFaxNo, True)
    End Sub

    Private Sub txtShipPer_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipPer.Enter
        FocusMe(txtShipPer)
    End Sub

    Private Sub txtShipPer_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipPer.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtShipPer, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtShipRemark.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipPer_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipPer.Leave
        FocusMe(txtShipPer, True)
    End Sub

    Private Sub txtShipRemark_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipRemark.Enter
        FocusMe(txtShipRemark)
    End Sub

    Private Sub txtShipRemark_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipRemark.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtShipRemark, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtShipName.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtShipRemark_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipRemark.Leave
		FocusMe(txtShipRemark, True)
	End Sub
	
	Private Function Chk_cboCardCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboCardCode = False
		
		If Trim(cboCardCode.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboCardCode.Focus()
			Exit Function
		End If
		
		If optCard(0).Checked = True Then
			If Chk_VdrCode(cboCardCode.Text) = False Then
				gsMsg = "商戶不存在!"
				
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboCardCode.Focus()
				Exit Function
			End If
		ElseIf optCard(1).Checked = True Then 
			If Chk_CusCode(cboCardCode.Text) = False Then
				gsMsg = "商戶不存在!"
				
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboCardCode.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboCardCode = True
	End Function
	
	Private Function Chk_VdrCode(ByVal inCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_VdrCode = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSQL = "SELECT VdrStatus "
		wsSQL = wsSQL & " FROM MstVendor WHERE VdrCode = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		Chk_VdrCode = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Function Chk_CusCode(ByVal inCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_CusCode = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSQL = "SELECT CusStatus "
		wsSQL = wsSQL & " FROM MstCustomer WHERE CusCode = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		Chk_CusCode = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Sub GetCardID(ByVal inCode As String, ByRef outCode As Integer)
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		If Trim(inCode) = "" Then
			Exit Sub
		End If
		
		If optCard(0).Checked = True Then
			wsSQL = "SELECT VdrID CardID"
			wsSQL = wsSQL & " FROM MstVendor WHERE VdrCode = '" & Set_Quote(inCode) & "'"
		ElseIf optCard(1).Checked = True Then 
			wsSQL = "SELECT CusID CardID"
			wsSQL = wsSQL & " FROM MstCustomer WHERE CusCode = '" & Set_Quote(inCode) & "'"
		End If
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Sub
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "CardID")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Sub
End Class