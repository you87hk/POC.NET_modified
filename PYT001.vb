Option Strict Off
Option Explicit On
Friend Class frmPYT001
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
	Private wsFormID As String
	Private wsConnTime As String
	Private wcCombo As System.Windows.Forms.Control
	
	Private Const wsKeyType As String = "MstPayTerm"
	Private wsUsrId As String
	Private wsTrnCd As String
	
	Private Sub cboPayCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPayCode.Leave
		FocusMe(cboPayCode, True)
	End Sub
	
	Private Sub frmPYT001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmPYT001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_WARNING: Event frmPYT001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmPYT001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'-- Resize, not maximum and minimax.
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(4335)
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
				Me.txtPayDesc.Enabled = False
				
				Me.cboPayCode.Enabled = False
				Me.cboPayCode.Visible = False
				Me.txtPayCode.Visible = True
				Me.txtPayCode.Enabled = False
				
				Me.txtPayDay.Enabled = False
				
				Me.optBy(0).Enabled = False
				Me.optBy(1).Enabled = False
				
				Me.txtPayDay.Enabled = False
				Me.txtPayMonth.Enabled = False
				Me.txtPayInvDay.Enabled = False
				Me.txtPayClsDay.Enabled = False
				
				txtPayMonth.Text = "0"
				txtPayInvDay.Text = "0"
				txtPayClsDay.Text = "0"
				txtPayDay.Text = "0"
				
				
			Case "AfrActAdd"
				Me.cboPayCode.Enabled = False
				Me.cboPayCode.Visible = False
				
				Me.txtPayCode.Enabled = True
				Me.txtPayCode.Visible = True
				
			Case "AfrActEdit"
				Me.cboPayCode.Enabled = True
				Me.cboPayCode.Visible = True
				
				Me.txtPayCode.Enabled = False
				Me.txtPayCode.Visible = False
				
			Case "AfrKey"
				Me.txtPayDesc.Enabled = True
				
				Me.txtPayDay.Enabled = True
				
				Me.optBy(0).Enabled = True
				Me.optBy(1).Enabled = True
				
				Me.txtPayMonth.Enabled = False
				Me.txtPayInvDay.Enabled = False
				Me.txtPayClsDay.Enabled = False
				
				Me.cboPayCode.Enabled = False
				Me.txtPayCode.Enabled = False
				
				If optBy(0).Checked = True Then
					optBy_CheckedChanged(optBy.Item(0), New System.EventArgs())
				ElseIf optBy(1).Checked = True Then 
					optBy_CheckedChanged(optBy.Item(1), New System.EventArgs())
				End If
		End Select
	End Sub
	
	'-- Input validation checking.
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_txtPayDesc = False Then
			Exit Function
		End If
		
		If optBy(0).Checked = True Then
			If Chk_txtPayDay = False Then
				Exit Function
			End If
		ElseIf optBy(1).Checked = True Then 
			If Chk_txtPayMonth = False Then
				Exit Function
			End If
			
			If Chk_txtPayInvDay = False Then
				Exit Function
			End If
			
			If Chk_txtPayClsDay = False Then
				Exit Function
			End If
		End If
		
		InputValidation = True
	End Function
	
	Public Function LoadRecord() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		Dim sMethod As String
		
		wsSQL = "SELECT MstPayTerm.* "
		wsSQL = wsSQL & "From MstPayTerm "
		wsSQL = wsSQL & "WHERE (((MstPayTerm.PayCode)='" & Set_Quote(cboPayCode.Text) & "') "
		wsSQL = wsSQL & "AND ((MstPayTerm.PayStatus)='1'));"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboPayCode.Text = ReadRs(rsRcd, "PayCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtPayDesc.Text = ReadRs(rsRcd, "PayDesc")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sMethod = ReadRs(rsRcd, "PayMethod")
			
			'1 : Month, 2 : Day
			If CDbl(sMethod) = 1 Then
				optBy(1).Checked = True
				setOptButton(optBy(1))
			ElseIf CDbl(sMethod) = 2 Then 
				optBy(0).Checked = True
				setOptButton(optBy(0))
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtPayDay.Text = VB6.Format(ReadRs(rsRcd, "PayDay"), gsQtyFmt)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtPayMonth.Text = VB6.Format(ReadRs(rsRcd, "PayMonth"), gsQtyFmt)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtPayClsDay.Text = VB6.Format(ReadRs(rsRcd, "PayClsDay"), gsQtyFmt)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtPayInvDay.Text = VB6.Format(ReadRs(rsRcd, "PayInvDay"), gsQtyFmt)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspPayLastUpd.Text = ReadRs(rsRcd, "PayLastUpd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspPayLastUpdDate.Text = ReadRs(rsRcd, "PayLastUpdDate")
			
			LoadRecord = True
		End If
		
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Private Sub frmPYT001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
		'UPGRADE_NOTE: Object frmPYT001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
	End Sub
	
	'UPGRADE_WARNING: Event optBy.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optBy_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBy.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optBy.GetIndex(eventSender)
			If Index = 0 Then
				lblPayDay.Enabled = True
				Me.txtPayDay.Enabled = True
				
				lblPayMonth.Enabled = False
				lblPayInvDay.Enabled = False
				lblPayClsDay.Enabled = False
				Me.txtPayMonth.Enabled = False
				Me.txtPayInvDay.Enabled = False
				Me.txtPayClsDay.Enabled = False
			ElseIf Index = 1 Then 
				lblPayDay.Enabled = False
				Me.txtPayDay.Enabled = False
				
				lblPayMonth.Enabled = True
				lblPayInvDay.Enabled = True
				lblPayClsDay.Enabled = True
				Me.txtPayMonth.Enabled = True
				Me.txtPayInvDay.Enabled = True
				Me.txtPayClsDay.Enabled = True
			End If
		End If
	End Sub
	
	Private Sub optBy_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optBy.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optBy.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			optBy_CheckedChanged(optBy.Item(Index), New System.EventArgs())
			
			If Index = 0 Then
				
				If optBy(0).Checked = True Then
					txtPayDay.Focus()
				ElseIf optBy(1).Checked = True Then 
					optBy(1).Focus()
				End If
				
			ElseIf Index = 1 Then 
				If optBy(0).Checked = True Then
					optBy(1).Focus()
				ElseIf optBy(1).Checked = True Then 
					txtPayMonth.Focus()
				End If
			End If
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
		wsFormID = "PYT001"
		wsTrnCd = ""
	End Sub
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
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
				txtPayCode.Focus()
				
			Case CorRec
				
				Call SetFieldStatus("AfrActEdit")
				Call SetButtonStatus("AfrActEdit")
				cboPayCode.Focus()
				
			Case DelRec
				
				Call SetFieldStatus("AfrActEdit")
				Call SetButtonStatus("AfrActEdit")
				cboPayCode.Focus()
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
					If RowLock(wsConnTime, wsKeyType, cboPayCode.Text, wsFormID, wsUsrId) = False Then
						gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
						MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					End If
				End If
		End Select
		Call SetFieldStatus("AfrKey")
		Call SetButtonStatus("AfrKey")
		txtPayDesc.Focus()
	End Sub
	
	Private Function Chk_PayCode(ByVal inCode As String, ByRef outCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_PayCode = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSQL = "SELECT PayStatus "
		wsSQL = wsSQL & " FROM MstPayTerm WHERE PayCode = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			outCode = ""
			
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "PayStatus")
		
		Chk_PayCode = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Function Chk_cboPayCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboPayCode = False
		
		If Trim(cboPayCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboPayCode.Focus()
			Exit Function
		End If
		
		If Chk_PayCode(cboPayCode.Text, wsStatus) = False Then
			gsMsg = "付款條款編碼不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboPayCode.Focus()
			Exit Function
		Else
			If wsStatus = "2" Then
				gsMsg = "付款條款編碼已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboPayCode.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboPayCode = True
	End Function
	
	Private Function Chk_txtPayCode() As Boolean
		Dim wsStatus As String
		
		Chk_txtPayCode = False
		
		If Trim(txtPayCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayCode.Focus()
			Exit Function
		End If
		
		If Chk_PayCode(txtPayCode.Text, wsStatus) = True Then
			If wsStatus = "2" Then
				gsMsg = "付款條款編碼已存在但已無效!"
			Else
				gsMsg = "付款條款編碼已存在!"
			End If
			
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayCode.Focus()
			Exit Function
		End If
		
		Chk_txtPayCode = True
	End Function
	
	Private Sub cmdOpen()
		Dim newForm As New frmPYT001
		
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
			If ReadOnlyMode(wsConnTime, wsKeyType, cboPayCode.Text, wsFormID) Then
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
		
		adcmdSave.CommandText = "USP_PYT001"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, wiAction)
		Call SetSPPara(adcmdSave, 2, IIf(wiAction = AddRec, txtPayCode.Text, cboPayCode.Text))
		Call SetSPPara(adcmdSave, 3, txtPayDesc)
		
		If optBy(0).Checked = True Then
			Call SetSPPara(adcmdSave, 4, 2)
			Call SetSPPara(adcmdSave, 5, txtPayDay)
			Call SetSPPara(adcmdSave, 6, 0)
			Call SetSPPara(adcmdSave, 7, 0)
			Call SetSPPara(adcmdSave, 8, 0)
		ElseIf optBy(1).Checked = True Then 
			Call SetSPPara(adcmdSave, 4, 1)
			Call SetSPPara(adcmdSave, 5, 0)
			Call SetSPPara(adcmdSave, 6, txtPayMonth)
			Call SetSPPara(adcmdSave, 7, txtPayClsDay)
			Call SetSPPara(adcmdSave, 8, txtPayInvDay)
		End If
		
		Call SetSPPara(adcmdSave, 9, gsUserID)
		Call SetSPPara(adcmdSave, 10, wsGenDte)
		
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsNo = GetSPPara(adcmdSave, 11)
		
		cnCon.CommitTrans()
		
		If wiAction = AddRec And Trim(wsNo) = "" Then
			gsMsg = "儲存失敗, 請檢查 Store Procedure - PYT001!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		Else
			gsMsg = "已成功儲存!"
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
		
		Dim vFilterAry(2, 2) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 1) = "付款條款編碼"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "PayCode"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "註解"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "PayDesc"
		
		Dim vAry(2, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "付款條款編碼"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "PayCode"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "註解"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "PayDesc"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "5000"
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			sSQL = "SELECT MstPayTerm.PayCode, MstPayTerm.PayDesc "
			sSQL = sSQL & "FROM MstPayTerm "
			.sBindSQL = sSQL
			.sBindWhereSQL = "WHERE MstPayTerm.PayStatus = '1' "
			.sBindOrderSQL = "ORDER BY MstPayTerm.PayCode"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmPYT001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboPayCode.Text Then
			cboPayCode.Text = Trim(frmShareSearch.Tag)
			System.Windows.Forms.SendKeys.Send("{ENTER}")
		End If
		frmShareSearch.Close()
	End Sub
	
	Private Sub txtPayCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLenA(txtPayCode, 10, KeyAscii, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPayCode() = True Then
				Call Ini_Scr_AfrKey()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtPayCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayCode.Leave
		FocusMe(txtPayCode, True)
	End Sub
	
	Private Sub txtPayDay_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayDay.Leave
		FocusMe(txtPayDay, True)
	End Sub
	
	Private Sub txtPayDesc_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayDesc.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtPayDesc, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPayDesc = True Then
				If optBy(1).Checked = True Then
					optBy(1).Focus()
				Else
					optBy(0).Focus()
				End If
				
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtPayCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayCode.Enter
		FocusMe(txtPayCode)
	End Sub
	
	Private Sub txtPayDesc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayDesc.Enter
		FocusMe(txtPayDesc)
	End Sub
	
	Private Function Chk_txtPayDesc() As Boolean
		
		Chk_txtPayDesc = False
		
		If Trim(txtPayDesc.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayDesc.Focus()
			Exit Function
		End If
		
		Chk_txtPayDesc = True
	End Function
	
	Private Sub txtPayDay_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayDay.Enter
		FocusMe(txtPayDay)
	End Sub
	
	Private Sub txtPayDay_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayDay.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtPayDay.Text, False, False)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPayDay() = True Then
				txtPayDesc.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
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
		ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then 
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
	
	Private Sub cboPayCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPayCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboPayCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboPayCode() = True Then
				Call Ini_Scr_AfrKey()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboPayCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPayCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboPayCode
		
		wsSQL = "SELECT PayCode, PayDesc, PayMethod FROM MstPayTerm WHERE PayStatus = '1'"
		wsSQL = wsSQL & " AND PayCode LIKE '%" & IIf(cboPayCode.SelectionLength > 0, "", Set_Quote(cboPayCode.Text)) & "%' "
		
		wsSQL = wsSQL & "ORDER BY PayCode "
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboPayCode.Left)), VB6.PixelsToTwipsY(cboPayCode.Top) + VB6.PixelsToTwipsY(cboPayCode.Height), tblCommon, "PYT001", "TBLPYT", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboPayCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPayCode.Enter
		FocusMe(cboPayCode)
	End Sub
	
	
	Private Sub txtPayDesc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayDesc.Leave
		FocusMe(txtPayDesc, True)
	End Sub
	
	Private Function Chk_KeyExist() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		wsSQL = "SELECT PayStatus FROM MstPayTerm WHERE PayCode = '" & Set_Quote(txtPayCode.Text) & "'"
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
			.TableKey = "PayCode"
			.KeyLen = 10
			.ctlKey = txtPayCode
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
		
		lblPayCode.Text = Get_Caption(waScrItm, "PAYCODE")
		lblPayDesc.Text = Get_Caption(waScrItm, "PAYDESC")
		lblPayMethod.Text = Get_Caption(waScrItm, "PAYMETHOD")
		lblPayDay.Text = Get_Caption(waScrItm, "PAYDAY")
		lblPayMonth.Text = Get_Caption(waScrItm, "PAYMONTH")
		lblPayClsDay.Text = Get_Caption(waScrItm, "PAYCLSDAY")
		lblPayInvDay.Text = Get_Caption(waScrItm, "PAYINVDAY")
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		optBy(0).Text = Get_Caption(waScrItm, "BYDAY")
		optBy(1).Text = Get_Caption(waScrItm, "BYMONTH")
		
		lblPayLastUpd.Text = Get_Caption(waScrItm, "PAYLASTUPD")
		lblPayLastUpdDate.Text = Get_Caption(waScrItm, "PAYLASTUPDDATE")
		
		fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")
		
		wsActNam(1) = Get_Caption(waScrItm, "PYTADD")
		wsActNam(2) = Get_Caption(waScrItm, "PYTEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "PYTDELETE")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Sub txtPayMonth_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayMonth.Enter
		FocusMe(txtPayMonth)
	End Sub
	
	Private Sub txtPayMonth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayMonth.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtPayMonth.Text, False, False)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPayMonth() = True Then
				txtPayClsDay.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtPayMonth_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayMonth.Leave
		FocusMe(txtPayMonth, True)
	End Sub
	
	Private Sub txtPayClsDay_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayClsDay.Enter
		FocusMe(txtPayClsDay)
	End Sub
	
	Private Sub txtPayClsDay_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayClsDay.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtPayClsDay.Text, False, False)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPayClsDay() = True Then
				txtPayInvDay.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtPayClsDay_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayClsDay.Leave
		FocusMe(txtPayClsDay, True)
	End Sub
	
	Private Sub txtPayInvDay_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayInvDay.Enter
		FocusMe(txtPayInvDay)
	End Sub
	
	Private Sub txtPayInvDay_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPayInvDay.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtPayInvDay.Text, False, False)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPayInvDay() = True Then
				txtPayDesc.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtPayInvDay_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPayInvDay.Leave
		FocusMe(txtPayInvDay, True)
	End Sub
	
	Private Sub setOptButton(ByRef ctl As System.Windows.Forms.Control)
		'UPGRADE_WARNING: Couldn't resolve default property of object ctl.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ctl.Value = True
	End Sub
	
	Private Function Chk_txtPayDay() As Boolean
		Chk_txtPayDay = False
		
		If Trim(txtPayDay.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayDay.Focus()
			Exit Function
		End If
		
		Chk_txtPayDay = True
	End Function
	
	Private Function Chk_txtPayMonth() As Boolean
		Chk_txtPayMonth = False
		
		If Trim(txtPayMonth.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayMonth.Focus()
			Exit Function
		End If
		
		Chk_txtPayMonth = True
	End Function
	
	Private Function Chk_txtPayClsDay() As Boolean
		Chk_txtPayClsDay = False
		
		If Trim(txtPayClsDay.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayClsDay.Focus()
			Exit Function
		End If
		
		Chk_txtPayClsDay = True
	End Function
	
	Private Function Chk_txtPayInvDay() As Boolean
		Chk_txtPayInvDay = False
		
		If Trim(txtPayInvDay.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtPayInvDay.Focus()
			Exit Function
		End If
		
		Chk_txtPayInvDay = True
	End Function
End Class