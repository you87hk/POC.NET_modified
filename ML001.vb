Option Strict Off
Option Explicit On
Friend Class frmML001
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
	
	Private wsActNam(4) As String
	
	Private wiAction As Short
	Private wlMLAccID As Integer
	Private wsFormID As String
	Private wsConnTime As String
	Private wcCombo As System.Windows.Forms.Control
	
	Private Const wsKeyType As String = "MstMerchClass"
	Private wsUsrId As String
	Private wsTrnCd As String
	
	Private Sub cboMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCode.Leave
		FocusMe(cboMLCode, True)
	End Sub
	
	Private Sub frmML001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmML001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_WARNING: Event frmML001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmML001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'-- Resize, not maximum and minimax.
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(4980)
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
				Me.txtMLDesc.Enabled = False
				
				Me.cboMLCode.Enabled = False
				Me.cboMLCode.Visible = False
				Me.txtMLCode.Visible = True
				Me.txtMLCode.Enabled = False
				cboCOAAccCode.Enabled = False
				
				optMLType(0).Enabled = False
				optMLType(1).Enabled = False
				optMLType(2).Enabled = False
				optMLType(3).Enabled = False
				optMLType(4).Enabled = False
				optMLType(5).Enabled = False
				
			Case "AfrActAdd"
				Me.cboMLCode.Enabled = False
				Me.cboMLCode.Visible = False
				
				Me.txtMLCode.Enabled = True
				Me.txtMLCode.Visible = True
				
			Case "AfrActEdit"
				Me.cboMLCode.Enabled = True
				Me.cboMLCode.Visible = True
				
				Me.txtMLCode.Enabled = False
				Me.txtMLCode.Visible = False
				
			Case "AfrKey"
				Me.txtMLDesc.Enabled = True
				cboCOAAccCode.Enabled = True
				
				optMLType(0).Enabled = True
				optMLType(1).Enabled = True
				optMLType(2).Enabled = True
				optMLType(3).Enabled = True
				optMLType(4).Enabled = True
				optMLType(5).Enabled = True
				
				Me.cboMLCode.Enabled = False
				Me.txtMLCode.Enabled = False
		End Select
	End Sub
	
	'-- Input validation checking.
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_txtMLDesc = False Then
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	Public Function LoadRecord() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		wsSQL = "SELECT MstMerchClass.* "
		wsSQL = wsSQL & "From MstMerchClass "
		wsSQL = wsSQL & "WHERE (((MstMerchClass.MLCode)='" & Set_Quote(cboMLCode.Text) & "') "
		wsSQL = wsSQL & "AND ((MLStatus)='1'));"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboMLCode.Text = ReadRs(rsRcd, "MLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtMLDesc.Text = ReadRs(rsRcd, "MLDesc")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspMLLastUpd.Text = ReadRs(rsRcd, "MLLastUpd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspMLLastUpdDate.Text = ReadRs(rsRcd, "MLLastUpdDate")
			wlMLAccID = To_Value(ReadRs(rsRcd, "MLAccID"))
			cboCOAAccCode.Text = Get_TableInfo("MstCOA", "COAAccID =" & wlMLAccID, "COAAccCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SetMLType(ReadRs(rsRcd, "MLType"))
			lblDspCOADesc.Text = Get_TableInfo("MstCOA", "COAAccCode = '" & Set_Quote(cboCOAAccCode.Text) & "'", "COADesc")
			
			LoadRecord = True
		End If
		
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Private Sub frmML001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
		'UPGRADE_NOTE: Object frmML001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
	End Sub
	
	Private Sub optMLType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optMLType.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optMLType.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtMLDesc.Focus()
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
        '    Me.Left = 0
        '    Me.Top = 0
        '    Me.Width = Screen.Width
        '    Me.Height = Screen.Height

        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "ML001"
        wsTrnCd = ""
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
                txtMLCode.Focus()

            Case CorRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboMLCode.Focus()

            Case DelRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboMLCode.Focus()
        End Select

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
    End Sub

    Private Sub Ini_Scr_AfrKey()
        Dim Ctrl As System.Windows.Forms.Control

        Select Case wiAction

            Case CorRec, DelRec

                If LoadRecord() = False Then
                    gsMsg = "存取記錄失敗! 請聯絡系統管理員或無限系統顧問!"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    Exit Sub
                Else
                    If RowLock(wsConnTime, wsKeyType, cboMLCode.Text, wsFormID, wsUsrId) = False Then
                        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                End If
        End Select
        Call SetFieldStatus("AfrKey")
        Call SetButtonStatus("AfrKey")
        cboCOAAccCode.Focus()
    End Sub

    Private Function Chk_MLCode(ByVal inCode As String, ByRef outCode As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_MLCode = False

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

        Chk_MLCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_COAAccCode(ByVal inCode As String, ByRef OutID As Integer, ByRef outCode As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_COAAccCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT COAAccID, COAStatus "
        wsSQL = wsSQL & " FROM MstCOA WHERE COAAccCode = '" & Set_Quote(inCode) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            outCode = ""
            OutID = 0

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        outCode = ReadRs(rsRcd, "COAStatus")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        OutID = ReadRs(rsRcd, "COAAccID")

        Chk_COAAccCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboMLCode() As Boolean
        Dim wsStatus As String

        Chk_cboMLCode = False

        If Trim(cboMLCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboMLCode.Focus()
            Exit Function
        End If

        If Chk_MLCode(cboMLCode.Text, wsStatus) = False Then
            gsMsg = "買手編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboMLCode.Focus()
            Exit Function
        Else
            If wsStatus = "2" Then
                gsMsg = "買手已存在但已無效!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboMLCode.Focus()
                Exit Function
            End If
        End If

        Chk_cboMLCode = True
    End Function

    Private Function Chk_cboCOAAccCode() As Boolean
        Dim wsStatus As String

        Chk_cboCOAAccCode = False

        If Trim(cboCOAAccCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboCOAAccCode.Focus()
            Exit Function
        End If

        If Chk_COAAccCode(cboCOAAccCode.Text, wlMLAccID, wsStatus) = False Then
            gsMsg = "會計科目編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboCOAAccCode.Focus()
            Exit Function
        Else
            If wsStatus = "2" Then
                gsMsg = "會計科目已存在但已無效!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboCOAAccCode.Focus()
                Exit Function
            End If
        End If

        Chk_cboCOAAccCode = True
    End Function

    Private Function Chk_txtMLCode() As Boolean
        Dim wsStatus As String

        Chk_txtMLCode = False

        If Trim(txtMLCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtMLCode.Focus()
            Exit Function
        End If

        If Chk_MLCode(txtMLCode.Text, wsStatus) = True Then
            If wsStatus = "2" Then
                gsMsg = "買手編碼已存在但已無效!"
            Else
                gsMsg = "買手編碼已存在!"
            End If

            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtMLCode.Focus()
            Exit Function
        End If

        Chk_txtMLCode = True
    End Function

    Private Sub cmdOpen()
        Dim newForm As New frmML001

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

    Private Sub cmdFind()
        Call OpenPromptForm()
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
            If ReadOnlyMode(wsConnTime, wsKeyType, cboMLCode.Text, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If wiAction = DelRec Then
            gsMsg = "你是否確定要刪除此記錄?"
            If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                cmdCancel()
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If

            If Chk_MLExist(cboMLCode.Text) = True Then
                gsMsg = "記錄已用, 不能刪除!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
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

        adcmdSave.CommandText = "USP_ML001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, IIf(wiAction = AddRec, txtMLCode.Text, cboMLCode.Text))
        Call SetSPPara(adcmdSave, 3, txtMLDesc)
        Call SetSPPara(adcmdSave, 4, wlMLAccID)
        Call SetSPPara(adcmdSave, 5, GetMLType())
        Call SetSPPara(adcmdSave, 6, gsUserID)
        Call SetSPPara(adcmdSave, 7, wsGenDte)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 8)

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - ML001!"
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

    Private Function SaveData() As Boolean
        Dim wiRet As Integer

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
        Dim sSQL As String

        Dim vFilterAry(3, 2) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 1) = "買手編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 2) = "MLCode"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "會計項"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "MLType"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "註解"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "MLDesc"

        Dim vAry(3, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "買手編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "MLCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "會計項"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "MLType"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 1) = "註解"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 2) = "MLDesc"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 3) = "4000"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            sSQL = "SELECT MstMerchClass.MLCode, MstMerchClass.MLType, MstMerchClass.MLDesc "
            sSQL = sSQL & "FROM MstMerchClass "
            .sBindSQL = sSQL
            .sBindWhereSQL = "WHERE MstMerchClass.MLStatus = '1' "
            .sBindOrderSQL = "ORDER BY MstMerchClass.MLCode"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmML001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
        If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboMLCode.Text Then
            cboMLCode.Text = Trim(frmShareSearch.Tag)
            System.Windows.Forms.SendKeys.Send("{ENTER}")
        End If
        frmShareSearch.Close()
    End Sub

    Private Sub txtMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLenA(txtMLCode, 10, KeyAscii, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtMLCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMLCode.Leave
        FocusMe(txtMLCode, True)
    End Sub

    Private Sub txtMLDesc_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMLDesc.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim iCounter As Short

        Call chk_InpLen(txtMLDesc, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtMLDesc = True Then
                cboCOAAccCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMLCode.Enter
        FocusMe(txtMLCode)
    End Sub

    Private Sub txtMLDesc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMLDesc.Enter
        FocusMe(txtMLDesc)
    End Sub

    Private Function Chk_txtMLDesc() As Boolean

        Chk_txtMLDesc = False

        If Trim(txtMLDesc.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtMLDesc.Focus()
            Exit Function
        End If

        Chk_txtMLDesc = True
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

    Private Sub cboMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboMLCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboMLCode.SelectionLength > 0, "", Set_Quote(cboMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "

        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboMLCode.Left)), VB6.PixelsToTwipsY(cboMLCode.Top) + VB6.PixelsToTwipsY(cboMLCode.Height), tblCommon, "ML001", "TBLML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCode.Enter
        FocusMe(cboMLCode)
    End Sub

    Private Sub txtMLDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMLDesc.Leave
        FocusMe(txtMLDesc, True)
    End Sub

    Private Function Chk_KeyExist() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT MLStatus FROM MstMerchClass WHERE MLCode = '" & Set_Quote(txtMLCode.Text) & "'"
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
            .TableKey = "MLCode"
            .KeyLen = 10
            .ctlKey = txtMLCode
            .ShowDialog()
        End With

        'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Newfrm = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err
        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
        lblMLDesc.Text = Get_Caption(waScrItm, "MLDESC")
        lblCOAAccCode.Text = Get_Caption(waScrItm, "COAACCCODE")
        lblMLLastUpd.Text = Get_Caption(waScrItm, "MLLASTUPD")
        lblMLLastUpdDate.Text = Get_Caption(waScrItm, "MLLASTUPDDATE")

        tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        optMLType(0).Text = Get_Caption(waScrItm, "OPTMLTYPE0")
        optMLType(1).Text = Get_Caption(waScrItm, "OPTMLTYPE1")
        optMLType(2).Text = Get_Caption(waScrItm, "OPTMLTYPE2")
        optMLType(3).Text = Get_Caption(waScrItm, "OPTMLTYPE3")
        optMLType(4).Text = Get_Caption(waScrItm, "OPTMLTYPE4")
        optMLType(5).Text = Get_Caption(waScrItm, "OPTMLTYPE5")

        fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")
        FraMLType.Text = Get_Caption(waScrItm, "FRAMLTYPE")

        wsActNam(1) = Get_Caption(waScrItm, "MLADD")
        wsActNam(2) = Get_Caption(waScrItm, "MLEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "MLDELETE")

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub

    Private Sub cboCOAAccCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCOAAccCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim iCounter As Short

        Call chk_InpLen(cboCOAAccCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCOAAccCode() = True Then


                Call Opt_Setfocus(optMLType, 6, 0)
                lblDspCOADesc.Text = Get_TableInfo("MstCOA", "COAAccCode = '" & Set_Quote(cboCOAAccCode.Text) & "'", "COADesc")

            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub cboCOAAccCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCOAAccCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCOAAccCode
		
		wsSQL = "SELECT COAAccCode, COADesc FROM MstCOA WHERE COAStatus = '1'"
		wsSQL = wsSQL & " AND COAAccCode LIKE '%" & IIf(cboCOAAccCode.SelectionLength > 0, "", Set_Quote(cboCOAAccCode.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY COAAccCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCOAAccCode.Left)), VB6.PixelsToTwipsY(cboCOAAccCode.Top) + VB6.PixelsToTwipsY(cboCOAAccCode.Height), tblCommon, "ML001", "TBLCOA", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCOAAccCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCOAAccCode.Enter
		FocusMe(cboCOAAccCode)
	End Sub
	
	Private Sub cboCOAAccCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCOAAccCode.Leave
		FocusMe(cboCOAAccCode, True)
	End Sub
	
	Private Sub SetMLType(ByVal inCode As String)
		Select Case inCode
			Case "S"
				optMLType(0).Checked = True
				
			Case "P"
				optMLType(1).Checked = True
				
			Case "A"
				optMLType(2).Checked = True
				
			Case "R"
				optMLType(3).Checked = True
				
			Case "G"
				optMLType(4).Checked = True
				
			Case "B"
				optMLType(5).Checked = True
		End Select
	End Sub
	
	Private Function GetMLType() As String
		Dim iCounter As Short
		
		For iCounter = 0 To 5
			If optMLType(iCounter).Checked = True Then
				Exit For
			End If
		Next 
		
		Select Case iCounter
			Case 0
				GetMLType = "S"
				
			Case 1
				GetMLType = "P"
				
			Case 2
				GetMLType = "A"
				
			Case 3
				GetMLType = "R"
				
			Case 4
				GetMLType = "G"
				
			Case 5
				GetMLType = "B"
		End Select
	End Function
	
	
	Private Function Chk_MLExist(ByVal inCode As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT MLCODE FROM"
		wsSQL = wsSQL & " ( "
		wsSQL = wsSQL & " SELECT IPHDMLCODE MLCODE FROM APIPHD WHERE IPHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT IPDTMLCODE MLCODE FROM APIPHD, APIPDT"
		wsSQL = wsSQL & " WHERE IPHDSTATUS <> '2'"
		wsSQL = wsSQL & " AND IPHDDOCID = IPDTDOCID"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT APCQBANKML MLCODE FROM APCHEQUE"
		wsSQL = wsSQL & " WHERE APCQSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT APCQTMPML MLCODE FROM APCHEQUE"
		wsSQL = wsSQL & " WHERE APCQSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT ApShMLCODE MLCODE FROM APSTHD"
		wsSQL = wsSQL & " WHERE APSHSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT ApSDMLCODE MLCODE FROM APSTHD, APSTDT"
		wsSQL = wsSQL & " WHERE APSHSTATUS <> '2'"
		wsSQL = wsSQL & " AND APSHDOCID = APSDDOCID"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT INHDMLCODE MLCODE FROM ARINHD WHERE INHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT INDTMLCODE MLCODE FROM ARINHD, ARINDT"
		wsSQL = wsSQL & " WHERE INHDSTATUS <> '2'"
		wsSQL = wsSQL & " AND INHDDOCID = INDTDOCID"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT ARCQBANKML MLCODE FROM ARCHEQUE"
		wsSQL = wsSQL & " WHERE ARCQSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT ARCQTMPML MLCODE FROM ARCHEQUE"
		wsSQL = wsSQL & " WHERE ARCQSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT ARShMLCODE MLCODE FROM ARSTHD"
		wsSQL = wsSQL & " WHERE ARSHSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT ARSDMLCODE MLCODE FROM ARSTHD, ARSTDT"
		wsSQL = wsSQL & " WHERE ARSHSTATUS <> '2'"
		wsSQL = wsSQL & " AND ARSHDOCID = ARSDDOCID"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT IVHDMLCODE MLCODE FROM SOAIVHD"
		wsSQL = wsSQL & " WHERE IVHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT IVHDCRML MLCODE FROM SOAIVHD"
		wsSQL = wsSQL & " WHERE IVHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT GRHDMLCODE MLCODE FROM POPGRHD"
		wsSQL = wsSQL & " WHERE GRHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT GRHDCRML MLCODE FROM POPGRHD"
		wsSQL = wsSQL & " WHERE GRHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT PRHDMLCODE MLCODE FROM POPPRHD"
		wsSQL = wsSQL & " WHERE PRHDSTATUS <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT AccTypeSALML MLCODE"
		wsSQL = wsSQL & " From MSTACCOUNTTYPE"
		wsSQL = wsSQL & " WHERE AccTypeStatus <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT AccTypeCOSML MLCODE"
		wsSQL = wsSQL & " From MSTACCOUNTTYPE"
		wsSQL = wsSQL & " WHERE AccTypeStatus <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT AccTypeINVML MLCODE"
		wsSQL = wsSQL & " From MSTACCOUNTTYPE"
		wsSQL = wsSQL & " WHERE AccTypeStatus <> '2'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpSupMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpExgMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpExlMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpTIMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpTEMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpSamMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpDamMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpAdjMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " "
		wsSQL = wsSQL & " Union"
		wsSQL = wsSQL & " SELECT CmpTRMLCode MLCODE FROM MSTCOMPANY WHERE CMPID = '01'"
		wsSQL = wsSQL & " ) A"
		wsSQL = wsSQL & " WHERE ISNULL(MLCODE,'') <> ''"
		wsSQL = wsSQL & " AND MLCode = '" & Set_Quote(inCode) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			Chk_MLExist = True
		Else
			Chk_MLExist = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
End Class