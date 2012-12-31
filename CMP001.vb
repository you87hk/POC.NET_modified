Option Strict Off
Option Explicit On
Friend Class frmCMP001
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
	Private wlKey As Integer
	'Row Lock Variable
	
	Private Const wsKeyType As String = "MstCompany"
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsFormID As String
	Private wsConnTime As String
	
	Private Sub cboCmpCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCode.Leave
		FocusMe(cboCmpCode, True)
	End Sub
	
	Private Sub frmCMP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.PageDown
				KeyCode = 0
				If tabDetailInfo.SelectedIndex < tabDetailInfo.TabPages.Count() - 1 Then
					tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex + 1
					Exit Sub
				End If
				
			Case System.Windows.Forms.Keys.PageUp
				KeyCode = 0
				If tabDetailInfo.SelectedIndex > 0 Then
					tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex - 1
					Exit Sub
				End If
				
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
	
	Private Sub frmCMP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_WARNING: Event frmCMP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmCMP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'-- Resize, not maximum and minimax.
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(6480)
			Me.Width = VB6.TwipsToPixelsX(10065)
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
				Me.txtCmpEngName.Enabled = False
				Me.txtCmpChiName.Enabled = False
				Me.picCmpAdr.Enabled = False
				Me.txtCmpTel.Enabled = False
				Me.txtCmpFax.Enabled = False
				Me.txtCmpEmail.Enabled = False
				Me.txtCmpWebSite.Enabled = False
				Me.cboCmpPayCode.Enabled = False
				Me.cboCmpCurr.Enabled = False
				Me.cboCmpRetainAC.Enabled = False
				Me.cboCmpSupMLCode.Enabled = False
				Me.cboCmpExgMLCode.Enabled = False
				Me.cboCmpExlMLCode.Enabled = False
				Me.cboCmpTiMLCode.Enabled = False
				Me.cboCmpTeMLCode.Enabled = False
				Me.cboCmpDamMLCode.Enabled = False
				Me.cboCmpSamMLCode.Enabled = False
				Me.cboCmpAdjMLCode.Enabled = False
				Me.cboCmpCurrEarn.Enabled = False
				Me.txtCmpBankAC.Enabled = False
				Me.txtCmpBankACName.Enabled = False
				Me.txtCmpRemark.Enabled = False
				Me.txtCmpRptChiAdd.Enabled = False
				Me.txtCmpRptEngAdd.Enabled = False
				
				Me.cboCmpCode.Enabled = False
				Me.cboCmpCode.Visible = False
				Me.txtCmpCode.Visible = True
				Me.txtCmpCode.Enabled = False
				
				tabDetailInfo.SelectedIndex = 0
				
			Case "AfrActAdd"
				Me.cboCmpCode.Enabled = False
				Me.cboCmpCode.Visible = False
				
				Me.txtCmpCode.Enabled = True
				Me.txtCmpCode.Visible = True
				
			Case "AfrActEdit"
				Me.cboCmpCode.Enabled = True
				Me.cboCmpCode.Visible = True
				
				Me.txtCmpCode.Enabled = False
				Me.txtCmpCode.Visible = False
				
			Case "AfrKey"
				Me.cboCmpCode.Enabled = False
				Me.txtCmpCode.Enabled = False
				
				Me.txtCmpEngName.Enabled = True
				Me.txtCmpChiName.Enabled = True
				Me.picCmpAdr.Enabled = True
				Me.txtCmpTel.Enabled = True
				Me.txtCmpFax.Enabled = True
				Me.txtCmpEmail.Enabled = True
				Me.txtCmpWebSite.Enabled = True
				Me.cboCmpPayCode.Enabled = True
				Me.cboCmpCurr.Enabled = True
				Me.cboCmpRetainAC.Enabled = True
				Me.cboCmpCurrEarn.Enabled = True
				Me.cboCmpSupMLCode.Enabled = True
				Me.cboCmpExgMLCode.Enabled = True
				Me.cboCmpExlMLCode.Enabled = True
				Me.cboCmpTiMLCode.Enabled = True
				Me.cboCmpTeMLCode.Enabled = True
				Me.cboCmpDamMLCode.Enabled = True
				Me.cboCmpSamMLCode.Enabled = True
				Me.cboCmpAdjMLCode.Enabled = True
				Me.txtCmpBankAC.Enabled = True
				Me.txtCmpBankACName.Enabled = True
				Me.txtCmpRemark.Enabled = True
				Me.txtCmpRptChiAdd.Enabled = True
				Me.txtCmpRptEngAdd.Enabled = True
		End Select
	End Sub
	
	'-- Input validation checking.
	Private Function InputValidation() As Boolean
		InputValidation = False
		
		If Chk_txtCmpEngName = False Then
			Exit Function
		End If
		
		If Chk_txtCmpChiName = False Then
			Exit Function
		End If
		
		If Chk_txtCmpRptEngAdd = False Then
			Exit Function
		End If
		
		If Chk_txtCmpRptChiAdd = False Then
			Exit Function
		End If
		
		If Chk_txtCmpTel = False Then
			Exit Function
		End If
		
		If Chk_cboCmpCurr = False Then
			Exit Function
		End If
		
		If Chk_cboCmpRetainAC = False Then
			Exit Function
		End If
		
		If Chk_cboCmpCurrEarn = False Then
			Exit Function
		End If
		
		If Chk_cboCmpSupMLCode = False Then
			Exit Function
		End If
		
		If Chk_cboCmpExgMLCode = False Then
			Exit Function
		End If
		
		If Chk_cboCmpExlMLCode = False Then
			Exit Function
		End If
		
		If Chk_cboCmpTiMLCode = False Then
			Exit Function
		End If
		
		If Chk_cboCmpTeMLCode = False Then
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	Public Function LoadRecord() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		wsSQL = "SELECT * "
		wsSQL = wsSQL & "From MstCompany "
		wsSQL = wsSQL & "WHERE (((MstCompany.CmpCode)='" & Set_Quote(cboCmpCode.Text) & "' AND CmpStatus = '1'))"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
			wlKey = 0
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlKey = ReadRs(rsRcd, "CmpID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpEngName.Text = ReadRs(rsRcd, "CmpEngName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpChiName.Text = ReadRs(rsRcd, "CmpChiName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, CmpAddress1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpAddress(1).Text = ReadRs(rsRcd, "CmpAddress1")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, CmpAddress2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpAddress(2).Text = ReadRs(rsRcd, "CmpAddress2")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, CmpAddress3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpAddress(3).Text = ReadRs(rsRcd, "CmpAddress3")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, CmpAddress4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpAddress(4).Text = ReadRs(rsRcd, "CmpAddress4")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpTel.Text = ReadRs(rsRcd, "CmpTel")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpFax.Text = ReadRs(rsRcd, "CmpFax")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpEmail.Text = ReadRs(rsRcd, "CmpEmail")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpWebSite.Text = ReadRs(rsRcd, "CmpWebSite")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpRptChiAdd.Text = ReadRs(rsRcd, "CmpRptChiAdd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpRptEngAdd.Text = ReadRs(rsRcd, "CmpRptEngAdd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpPayCode.Text = ReadRs(rsRcd, "CmpPayCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpCurr.Text = ReadRs(rsRcd, "CmpCurr")
			Me.cboCmpRetainAC.Text = LoadCmpRetainACCodeByID(ReadRs(rsRcd, "CmpRetainAC"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpSupMLCode.Text = ReadRs(rsRcd, "CmpSupMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpExgMLCode.Text = ReadRs(rsRcd, "CmpExgMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpExlMLCode.Text = ReadRs(rsRcd, "CmpExlMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpTiMLCode.Text = ReadRs(rsRcd, "CmpTiMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpTeMLCode.Text = ReadRs(rsRcd, "CmpTeMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpSamMLCode.Text = ReadRs(rsRcd, "CmpSamMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpDamMLCode.Text = ReadRs(rsRcd, "CmpDamMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpAdjMLCode.Text = ReadRs(rsRcd, "CmpAdjMLCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboCmpCurrEarn.Text = ReadRs(rsRcd, "CmpCurrEarn")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpBankAC.Text = ReadRs(rsRcd, "CmpBankAC")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpBankACName.Text = ReadRs(rsRcd, "CmpBankACName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtCmpRemark.Text = ReadRs(rsRcd, "CmpRemark")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspCmpLastUpd.Text = ReadRs(rsRcd, "CmpLastUpd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspCmpLastUpdDate.Text = ReadRs(rsRcd, "CmpLastUpdDate")
			
			LoadRecord = True
		End If
		
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Sub frmCMP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
		'UPGRADE_NOTE: Object frmCMP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
	End Sub
	
	Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
		Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
		If tabDetailInfo.SelectedIndex = 0 Then
			If txtCmpAddress(1).Enabled Then
				txtCmpAddress(1).Focus()
			End If
		ElseIf tabDetailInfo.SelectedIndex = 1 Then 
			If txtCmpTel.Enabled Then
				txtCmpTel.Focus()
			End If
		ElseIf tabDetailInfo.SelectedIndex = 2 Then 
			If cboCmpPayCode.Enabled Then
				cboCmpPayCode.Focus()
			End If
		ElseIf tabDetailInfo.SelectedIndex = 3 Then 
			If txtCmpBankAC.Enabled Then
				txtCmpBankAC.Focus()
			End If
		ElseIf tabDetailInfo.SelectedIndex = 4 Then 
			If txtCmpRemark.Enabled Then
				txtCmpRemark.Focus()
			End If
		End If
		PreviousTab = tabDetailInfo.SelectedIndex()
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
		
		wsConnTime = Dsp_Date(Now, True)
		wsFormID = "CMP001"
		wsTrnCd = ""
	End Sub
	
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblCmpCode.Text = Get_Caption(waScrItm, "CMPCODE")
		lblCmpEngName.Text = Get_Caption(waScrItm, "CMPENGNAME")
		lblCmpChiName.Text = Get_Caption(waScrItm, "CMPCHINAME")
		lblCmpAdr.Text = Get_Caption(waScrItm, "CMPADR")
		lblCmpTel.Text = Get_Caption(waScrItm, "CMPTEL")
		lblCmpFax.Text = Get_Caption(waScrItm, "CMPFAX")
		lblCmpEmail.Text = Get_Caption(waScrItm, "CMPEMAIL")
		lblCmpWebSite.Text = Get_Caption(waScrItm, "CMPWEBSITE")
		lblCmpPayCode.Text = Get_Caption(waScrItm, "CMPPAYCODE")
		lblCmpCurr.Text = Get_Caption(waScrItm, "CMPCURR")
		lblCmpRetainAC.Text = Get_Caption(waScrItm, "CMPRETAINAC")
		lblCmpSupMLCode.Text = Get_Caption(waScrItm, "CMPSUPMLCODE")
		lblCmpExgMLCode.Text = Get_Caption(waScrItm, "CMPEXGMLCODE")
		lblCmpExlMLCode.Text = Get_Caption(waScrItm, "CMPEXLMLCODE")
		lblCmpTiMLCode.Text = Get_Caption(waScrItm, "CMPTIMLCODE")
		lblCmpTeMLCode.Text = Get_Caption(waScrItm, "CMPTEMLCODE")
		lblCmpDamMLCode.Text = Get_Caption(waScrItm, "CMPDAMMLCODE")
		lblCmpSamMLCode.Text = Get_Caption(waScrItm, "CMPSAMMLCODE")
		lblCmpAdjMLCode.Text = Get_Caption(waScrItm, "CMPADJMLCODE")
		lblCmpCurrEarn.Text = Get_Caption(waScrItm, "CMPCURREARN")
		
		lblCmpBankAC.Text = Get_Caption(waScrItm, "CMPBANKAC")
		lblCmpBankACName.Text = Get_Caption(waScrItm, "CMPBANKACNAME")
		lblCmpRemark.Text = Get_Caption(waScrItm, "CMPREMARK")
		lblCmpRptChiAdd.Text = Get_Caption(waScrItm, "CMPRPTCHIADD")
		lblCmpRptEngAdd.Text = Get_Caption(waScrItm, "CMPRPTENGADD")
		
		lblCmpLastUpd.Text = Get_Caption(waScrItm, "CMPLASTUPD")
		lblCmpLastUpdDate.Text = Get_Caption(waScrItm, "CMPLASTUPDDATE")
		
		fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")
		
		tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO0")
		tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO1")
		tabDetailInfo.TabPages.Item(2).Text = Get_Caption(waScrItm, "TABDETAILINFO2")
		tabDetailInfo.TabPages.Item(3).Text = Get_Caption(waScrItm, "TABDETAILINFO3")
		tabDetailInfo.TabPages.Item(4).Text = Get_Caption(waScrItm, "TABDETAILINFO4")
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "CMPADD")
		wsActNam(2) = Get_Caption(waScrItm, "CMPEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "CMPDELETE")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
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
				txtCmpCode.Focus()
				
			Case CorRec
				
				Call SetFieldStatus("AfrActEdit")
				Call SetButtonStatus("AfrActEdit")
				cboCmpCode.Focus()
				
			Case DelRec
				
				Call SetFieldStatus("AfrActEdit")
				Call SetButtonStatus("AfrActEdit")
				cboCmpCode.Focus()
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
					If RowLock(wsConnTime, wsKeyType, cboCmpCode.Text, wsFormID, wsUsrId) = False Then
						gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
						MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					End If
				End If
		End Select
		
		Call SetFieldStatus("AfrKey")
		Call SetButtonStatus("AfrKey")
		txtCmpEngName.Focus()
	End Sub
	
	Private Function Chk_CmpCode(ByVal inCode As String, ByRef outCode As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_CmpCode = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSQL = "SELECT CmpStatus "
		wsSQL = wsSQL & " FROM MstCompany WHERE CmpCode = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			outCode = ""
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "CmpStatus")
		
		Chk_CmpCode = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Function Chk_txtCmpCode() As Boolean
		Dim wsStatus As String
		
		Chk_txtCmpCode = False
		
		If Trim(txtCmpCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtCmpCode.Focus()
			Exit Function
		End If
		
		If Chk_CmpCode(txtCmpCode.Text, wsStatus) = True Then
			If wsStatus = "2" Then
				gsMsg = "公司已存在但已無效!"
			Else
				gsMsg = "公司已存在!"
			End If
			
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtCmpCode.Focus()
			Exit Function
		End If
		
		Chk_txtCmpCode = True
	End Function
	
	Private Function Chk_cboCmpCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboCmpCode = False
		
		If Trim(cboCmpCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboCmpCode.Focus()
			Exit Function
		End If
		
		If Chk_CmpCode(cboCmpCode.Text, wsStatus) = False Then
			gsMsg = "公司不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboCmpCode.Focus()
			Exit Function
		Else
			If wsStatus = "2" Then
				gsMsg = "公司已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboCmpCode.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboCmpCode = True
	End Function
	
	Private Sub cmdOpen()
		Dim newForm As New frmCMP001
		
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
			If ReadOnlyMode(wsConnTime, wsKeyType, cboCmpCode.Text, wsFormID) Then
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
		
		adcmdSave.CommandText = "USP_CMP001"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, wiAction)
		Call SetSPPara(adcmdSave, 2, wlKey)
		Call SetSPPara(adcmdSave, 3, IIf(wiAction = AddRec, txtCmpCode.Text, cboCmpCode.Text))
		Call SetSPPara(adcmdSave, 4, txtCmpEngName)
		Call SetSPPara(adcmdSave, 5, txtCmpChiName)
		Call SetSPPara(adcmdSave, 6, txtCmpAddress(1))
		Call SetSPPara(adcmdSave, 7, txtCmpAddress(2))
		Call SetSPPara(adcmdSave, 8, txtCmpAddress(3))
		Call SetSPPara(adcmdSave, 9, txtCmpAddress(4))
		Call SetSPPara(adcmdSave, 10, txtCmpRptEngAdd)
		Call SetSPPara(adcmdSave, 11, txtCmpRptChiAdd)
		Call SetSPPara(adcmdSave, 12, txtCmpTel)
		Call SetSPPara(adcmdSave, 13, txtCmpFax)
		Call SetSPPara(adcmdSave, 14, txtCmpEmail)
		Call SetSPPara(adcmdSave, 15, txtCmpWebSite)
		Call SetSPPara(adcmdSave, 16, cboCmpPayCode)
		Call SetSPPara(adcmdSave, 17, cboCmpCurr)
		Call SetSPPara(adcmdSave, 18, LoadCmpRetainACIDByCode(cboCmpRetainAC))
		Call SetSPPara(adcmdSave, 19, cboCmpSupMLCode)
		Call SetSPPara(adcmdSave, 20, cboCmpExgMLCode)
		Call SetSPPara(adcmdSave, 21, cboCmpExlMLCode)
		Call SetSPPara(adcmdSave, 22, cboCmpTiMLCode)
		Call SetSPPara(adcmdSave, 23, cboCmpTeMLCode)
		Call SetSPPara(adcmdSave, 24, txtCmpBankAC)
		Call SetSPPara(adcmdSave, 25, txtCmpBankACName)
		Call SetSPPara(adcmdSave, 26, gsUserID)
		Call SetSPPara(adcmdSave, 27, wsGenDte)
		Call SetSPPara(adcmdSave, 28, txtCmpRemark)
		Call SetSPPara(adcmdSave, 29, cboCmpSamMLCode)
		Call SetSPPara(adcmdSave, 30, cboCmpDamMLCode)
		Call SetSPPara(adcmdSave, 31, cboCmpAdjMLCode)
		Call SetSPPara(adcmdSave, 32, cboCmpCurrEarn)
		
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsNo = GetSPPara(adcmdSave, 33)
		
		cnCon.CommitTrans()
		
		If wiAction = AddRec And Trim(wsNo) = "" Then
			gsMsg = "儲存失敗, 請檢查 Store Procedure - CMP001!"
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
		vFilterAry(1, 1) = "公司編碼"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "CmpCode"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "註解"
		If gsLangID <> "2" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vFilterAry(2, 2) = "CmpEngName"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vFilterAry(2, 2) = "CmpChiName"
		End If
		
		Dim vAry(2, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "編碼"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "CmpCode"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "註解"
		If gsLangID <> "2" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vAry(2, 2) = "CmpEngName"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			vAry(2, 2) = "CmpChiName"
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "5000"
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			If gsLangID <> "2" Then
				wsSQL = "SELECT MstCompany.CmpCode, MstCompany.CmpEngName "
			Else
				wsSQL = "SELECT MstCompany.CmpCode, MstCompany.CmpChiName "
			End If
			wsSQL = wsSQL & "FROM MstCompany "
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE MstCompany.CmpStatus = '1' "
			.sBindOrderSQL = "ORDER BY MstCompany.CmpCode"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmCMP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboCmpCode.Text Then
			cboCmpCode.Text = Trim(frmShareSearch.Tag)
			cboCmpCode.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		frmShareSearch.Close()
	End Sub
	
	Private Sub txtCmpAddress_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpAddress.Enter
		Dim Index As Short = txtCmpAddress.GetIndex(eventSender)
		If Index = 1 Then
			If tabDetailInfo.SelectedIndex <> 0 Then tabDetailInfo.SelectedIndex = 0
		End If
		FocusMe(txtCmpAddress(Index))
	End Sub
	
	Private Sub txtCmpAddress_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpAddress.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtCmpAddress.GetIndex(eventSender)
		Call chk_InpLen(txtCmpAddress(Index), 30, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Index < 4 Then
                txtCmpAddress(Index + 1).Focus()
            Else
                txtCmpRptEngAdd.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpAddress_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpAddress.Leave
        Dim Index As Short = txtCmpAddress.GetIndex(eventSender)
        FocusMe(txtCmpAddress(Index), True)
    End Sub

    Private Sub txtCmpBankAC_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpBankAC.Enter
        If tabDetailInfo.SelectedIndex <> 3 Then tabDetailInfo.SelectedIndex = 3
        FocusMe(txtCmpBankAC)
    End Sub

    Private Sub txtCmpBankAC_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpBankAC.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpBankAC, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtCmpBankACName.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpBankAC_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpBankAC.Leave
        FocusMe(txtCmpBankAC, True)
    End Sub

    Private Sub txtCmpCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpCode.Enter
        FocusMe(txtCmpCode)
    End Sub

    Private Sub txtCmpCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLenA(txtCmpCode, 10, KeyAscii, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtCmpCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpCode.Leave
        FocusMe(txtCmpCode, True)
    End Sub

    Private Sub txtCmpEngName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpEngName.Leave
        FocusMe(txtCmpEngName, True)
    End Sub

    Private Sub txtCmpChiName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpChiName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpChiName, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtCmpChiName() = True Then
                txtCmpAddress(1).Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpEngName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpEngName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpEngName, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtCmpEngName() = True Then
                txtCmpChiName.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpChiName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpChiName.Enter
        FocusMe(txtCmpChiName)
    End Sub

    Private Sub txtCmpEngName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpEngName.Enter
        FocusMe(txtCmpEngName)
    End Sub

    Private Function Chk_txtCmpEngName() As Boolean
        Chk_txtCmpEngName = False

        If Trim(txtCmpEngName.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtCmpEngName.Focus()
            Exit Function
        End If

        Chk_txtCmpEngName = True
    End Function

    Private Function Chk_txtCmpChiName() As Boolean

        Chk_txtCmpChiName = False

        If Trim(txtCmpChiName.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtCmpChiName.Focus()
            Exit Function
        End If

        Chk_txtCmpChiName = True
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

    Private Sub cboCmpCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpCode

        If CDbl(gsLangID) = 1 Then
            wsSQL = "SELECT CmpCode, CmpEngName FROM MstCompany WHERE CmpStatus = '1'"
        Else
            wsSQL = "SELECT CmpCode, CmpChiName FROM MstCompany WHERE CmpStatus = '1'"
        End If
        wsSQL = wsSQL & " AND CmpCode LIKE '%" & IIf(cboCmpCode.SelectionLength > 0, "", Set_Quote(cboCmpCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY CmpCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpCode.Left)), VB6.PixelsToTwipsY(cboCmpCode.Top) + VB6.PixelsToTwipsY(cboCmpCode.Height), tblCommon, "CMP001", "TBLCMP", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCode.Enter
        FocusMe(cboCmpCode)
    End Sub

    Private Sub txtCmpChiName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpChiName.Leave
        FocusMe(txtCmpChiName, True)
    End Sub

    Private Function Chk_KeyExist() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT CmpStatus FROM MstCompany WHERE CmpCode = '" & Set_Quote(txtCmpCode.Text) & "'"
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
            .TableKey = "CmpCode"
            .KeyLen = 10
            .ctlKey = txtCmpCode
            .ShowDialog()
        End With

        'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Newfrm = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txtCmpRemark_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpRemark.Enter
        If tabDetailInfo.SelectedIndex <> 4 Then tabDetailInfo.SelectedIndex = 4
        FocusMe(txtCmpRemark)
    End Sub

    Private Sub txtCmpRemark_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpRemark.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpRemark, 100, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtCmpEngName.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpRemark_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpRemark.Leave
        FocusMe(txtCmpRemark, True)
    End Sub

    Private Sub txtCmpTel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpTel.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtCmpTel)
    End Sub

    Private Sub txtCmpTel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpTel.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpTel, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtCmpFax.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpTel_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpTel.Leave
        FocusMe(txtCmpTel, True)
    End Sub

    Private Sub txtCmpFax_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpFax.Enter
        FocusMe(txtCmpFax)
    End Sub

    Private Sub txtCmpFax_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpFax.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpFax, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtCmpEmail.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpFax_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpFax.Leave
        FocusMe(txtCmpFax, True)
    End Sub

    Private Sub txtCmpEmail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpEmail.Enter
        FocusMe(txtCmpEmail)
    End Sub

    Private Sub txtCmpEmail_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpEmail.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpEmail, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtCmpWebSite.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpEmail_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpEmail.Leave
        FocusMe(txtCmpEmail, True)
    End Sub

    Private Sub txtCmpWebSite_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpWebSite.Enter
        FocusMe(txtCmpWebSite)
    End Sub

    Private Sub txtCmpWebSite_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpWebSite.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpWebSite, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboCmpPayCode.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpWebSite_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpWebSite.Leave
        FocusMe(txtCmpWebSite, True)
    End Sub

    Private Sub cboCmpPayCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpPayCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpPayCode

        wsSQL = "SELECT PayCode, PayDesc FROM MstPayTerm WHERE PayStatus = '1'"
        wsSQL = wsSQL & " AND PayCode LIKE '%" & IIf(cboCmpPayCode.SelectionLength > 0, "", Set_Quote(cboCmpPayCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY PayCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpPayCode.Left)), VB6.PixelsToTwipsY(cboCmpPayCode.Top) + VB6.PixelsToTwipsY(cboCmpPayCode.Height), tblCommon, "CMP001", "TBLCMPPAY", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpPayCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpPayCode.Enter
        If tabDetailInfo.SelectedIndex <> 2 Then tabDetailInfo.SelectedIndex = 2
        FocusMe(cboCmpPayCode)
    End Sub

    Private Sub cboCmpPayCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpPayCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpPayCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpPayCode() = True Then
                cboCmpCurr.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpPayCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpPayCode.Leave
        FocusMe(cboCmpPayCode, True)
    End Sub

    Private Sub cboCmpCurr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCurr.DropDown
        Dim wsSQL As String
        Dim wsCtlDte As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpCurr

        wsCtlDte = gsSystemDate
        wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE WHERE EXCCURR LIKE '%" & IIf(cboCmpCurr.SelectionLength > 0, "", Set_Quote(cboCmpCurr.Text)) & "%' "
        wsSQL = wsSQL & " AND EXCMN = '" & To_Value(VB6.Format(wsCtlDte, "MM")) & "' "
        wsSQL = wsSQL & " AND EXCYR = '" & Set_Quote(VB6.Format(wsCtlDte, "YYYY")) & "' "
        wsSQL = wsSQL & " AND EXCSTATUS = '1' "
        wsSQL = wsSQL & "ORDER BY EXCCURR "

        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpCurr.Left)), VB6.PixelsToTwipsY(cboCmpCurr.Top) + VB6.PixelsToTwipsY(cboCmpCurr.Height), tblCommon, wsFormID, "TBLCMPCURR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpCurr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCurr.Enter
        FocusMe(cboCmpCurr)
    End Sub

    Private Sub cboCmpCurr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpCurr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpCurr, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpCurr() = True Then
                cboCmpRetainAC.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpCurr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCurr.Leave
        FocusMe(cboCmpCurr, True)
    End Sub

    Private Sub cboCmpRetainAC_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpRetainAC.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpRetainAC

        wsSQL = "SELECT COAAccCode, " & IIf(gsLangID = "2", "COACDESC", "COADESC") & " FROM MstCOA WHERE COAStatus = '1'"
        wsSQL = wsSQL & " AND COAAccCode LIKE '%" & IIf(cboCmpRetainAC.SelectionLength > 0, "", Set_Quote(cboCmpRetainAC.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY COAAccCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpRetainAC.Left)), VB6.PixelsToTwipsY(cboCmpRetainAC.Top) + VB6.PixelsToTwipsY(cboCmpRetainAC.Height), tblCommon, "CMP001", "TBLCMPRETAINAC", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpRetainAC_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpRetainAC.Enter
        FocusMe(cboCmpRetainAC)
    End Sub

    Private Sub cboCmpRetainAC_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpRetainAC.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpRetainAC, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpRetainAC() = True Then
                cboCmpCurrEarn.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpRetainAC_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpRetainAC.Leave
        FocusMe(cboCmpRetainAC, True)
    End Sub

    '''
    Private Sub cboCmpCurrEarn_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCurrEarn.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpCurrEarn

        wsSQL = "SELECT COAAccCode, " & IIf(gsLangID = "2", "COACDESC", "COADESC") & " FROM MstCOA WHERE COAStatus = '1'"
        wsSQL = wsSQL & " AND COAAccCode LIKE '%" & IIf(cboCmpCurrEarn.SelectionLength > 0, "", Set_Quote(cboCmpCurrEarn.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY COAAccCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpCurrEarn.Left)), VB6.PixelsToTwipsY(cboCmpCurrEarn.Top) + VB6.PixelsToTwipsY(cboCmpCurrEarn.Height), tblCommon, "CMP001", "TBLCMPCurrEarn", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpCurrEarn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCurrEarn.Enter
        FocusMe(cboCmpCurrEarn)
    End Sub

    Private Sub cboCmpCurrEarn_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpCurrEarn.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpCurrEarn, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpCurrEarn() = True Then
                cboCmpExgMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpCurrEarn_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpCurrEarn.Leave
        FocusMe(cboCmpCurrEarn, True)
    End Sub



    Private Sub cboCmpSupMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpSupMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpSupMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpSupMLCode.SelectionLength > 0, "", Set_Quote(cboCmpSupMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpSupMLCode.Left)), VB6.PixelsToTwipsY(cboCmpSupMLCode.Top) + VB6.PixelsToTwipsY(cboCmpSupMLCode.Height), tblCommon, "CMP001", "TBLCMPSUPML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpSupMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpSupMLCode.Enter
        FocusMe(cboCmpSupMLCode)
    End Sub

    Private Sub cboCmpSupMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpSupMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpSupMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpSupMLCode() = True Then
                tabDetailInfo.SelectedIndex = 3
                txtCmpBankAC.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpSupMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpSupMLCode.Leave
        FocusMe(cboCmpSupMLCode, True)
    End Sub

    Private Sub cboCmpExgMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpExgMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpExgMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpExgMLCode.SelectionLength > 0, "", Set_Quote(cboCmpExgMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpExgMLCode.Left)), VB6.PixelsToTwipsY(cboCmpExgMLCode.Top) + VB6.PixelsToTwipsY(cboCmpExgMLCode.Height), tblCommon, "CMP001", "TBLCMPEXGML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpExgMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpExgMLCode.Enter
        FocusMe(cboCmpExgMLCode)
    End Sub

    Private Sub cboCmpExgMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpExgMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpExgMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpExgMLCode() = True Then
                cboCmpExlMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpExgMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpExgMLCode.Leave
        FocusMe(cboCmpExgMLCode, True)
    End Sub

    Private Sub cboCmpExlMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpExlMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpExlMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpExlMLCode.SelectionLength > 0, "", Set_Quote(cboCmpExlMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpExlMLCode.Left)), VB6.PixelsToTwipsY(cboCmpExlMLCode.Top) + VB6.PixelsToTwipsY(cboCmpExlMLCode.Height), tblCommon, "CMP001", "TBLCMPEXLML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpExlMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpExlMLCode.Enter
        FocusMe(cboCmpExlMLCode)
    End Sub

    Private Sub cboCmpExlMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpExlMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpExlMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpExlMLCode() = True Then
                cboCmpTiMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpExlMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpExlMLCode.Leave
        FocusMe(cboCmpExlMLCode, True)
    End Sub

    Private Sub cboCmpTiMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpTiMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpTiMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpTiMLCode.SelectionLength > 0, "", Set_Quote(cboCmpTiMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpTiMLCode.Left)), VB6.PixelsToTwipsY(cboCmpTiMLCode.Top) + VB6.PixelsToTwipsY(cboCmpTiMLCode.Height), tblCommon, "CMP001", "TBLCMPTIML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpTiMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpTiMLCode.Enter
        FocusMe(cboCmpTiMLCode)
    End Sub

    Private Sub cboCmpTiMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpTiMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpTiMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpTiMLCode() = True Then
                cboCmpTeMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpTiMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpTiMLCode.Leave
        FocusMe(cboCmpTiMLCode, True)
    End Sub

    Private Sub cboCmpTeMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpTeMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpTeMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpTeMLCode.SelectionLength > 0, "", Set_Quote(cboCmpTeMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCmpTeMLCode.Left)), VB6.PixelsToTwipsY(cboCmpTeMLCode.Top) + VB6.PixelsToTwipsY(cboCmpTeMLCode.Height), tblCommon, "CMP001", "TBLCMPTEML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpTeMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpTeMLCode.Enter
        FocusMe(cboCmpTeMLCode)
    End Sub

    Private Sub cboCmpTeMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpTeMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpTeMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpTeMLCode() = True Then
                cboCmpDamMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpTeMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpTeMLCode.Leave
        FocusMe(cboCmpTeMLCode, True)
    End Sub

    Private Sub txtCmpBankACName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpBankACName.Enter
        FocusMe(txtCmpBankACName)
    End Sub

    Private Sub txtCmpBankACName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpBankACName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpBankACName, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtCmpRemark.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpBankACName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpBankACName.Leave
        FocusMe(txtCmpBankACName, True)
    End Sub

    Private Function Chk_cboCmpPayCode() As Boolean
        Chk_cboCmpPayCode = False

        If Trim(cboCmpPayCode.Text) = "" Then
            Chk_cboCmpPayCode = True
            Exit Function
        End If

        If Chk_CmpPayCode() = False Then
            gsMsg = "付款條款不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpPayCode.Focus()
            Exit Function
        End If

        Chk_cboCmpPayCode = True
    End Function

    Private Function Chk_CmpPayCode() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpPayCode = False

        sSQL = "SELECT MstPayTerm.PayCode FROM MstPayTerm WHERE MstPayTerm.PayCode = '" & Set_Quote(cboCmpPayCode.Text) & "' And PayStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        Chk_CmpPayCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboCmpCurr() As Boolean
        Chk_cboCmpCurr = False

        If Trim(cboCmpCurr.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpCurr.Focus()
            Exit Function
        End If

        If Chk_Curr(cboCmpCurr.Text, gsSystemDate) = False Then
            gsMsg = "貨幣不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpCurr.Focus()
            Exit Function
        End If

        Chk_cboCmpCurr = True
    End Function

    Private Function Chk_cboCmpRetainAC() As Boolean
        Chk_cboCmpRetainAC = False

        If Trim(cboCmpRetainAC.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpRetainAC.Focus()
            Exit Function
        End If

        If Chk_CmpRetainAC() = False Then
            gsMsg = "盈餘帳戶不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpRetainAC.Focus()
            Exit Function
        End If

        Chk_cboCmpRetainAC = True
    End Function

    Private Function Chk_CmpRetainAC() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpRetainAC = False

        sSQL = "SELECT MstCOA.COAAccCode FROM MstCOA WHERE MstCOA.COAAccCode = '" & Set_Quote(cboCmpRetainAC.Text) & "' And COAStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        Chk_CmpRetainAC = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboCmpSupMLCode() As Boolean
        Chk_cboCmpSupMLCode = False

        If Trim(cboCmpSupMLCode.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpSupMLCode.Focus()
            Exit Function
        End If

        If Chk_CmpSupMLCode() = False Then
            gsMsg = "暫記帳戶不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpSupMLCode.Focus()
            Exit Function
        End If

        Chk_cboCmpSupMLCode = True
    End Function


    Private Function Chk_cboCmpCurrEarn() As Boolean
        Chk_cboCmpCurrEarn = False

        If Trim(cboCmpCurrEarn.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpCurrEarn.Focus()
            Exit Function
        End If

        If Chk_CmpRetainAC() = False Then
            gsMsg = "本年盈利帳戶不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpCurrEarn.Focus()
            Exit Function
        End If

        Chk_cboCmpCurrEarn = True
    End Function

    Private Function Chk_CmpSupMLCode() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpSupMLCode = False

        sSQL = "SELECT MstMerchClass.MLCode FROM MstMerchClass WHERE MstMerchClass.MLCode = '" & Set_Quote(cboCmpSupMLCode.Text) & "' And MLStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        Chk_CmpSupMLCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboCmpExgMLCode() As Boolean
        Chk_cboCmpExgMLCode = False

        If Trim(cboCmpExgMLCode.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpExgMLCode.Focus()
            Exit Function
        End If

        If Chk_CmpExgMLCode() = False Then
            gsMsg = "對換利益不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpExgMLCode.Focus()
            Exit Function
        End If

        Chk_cboCmpExgMLCode = True
    End Function

    Private Function Chk_CmpExgMLCode() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpExgMLCode = False

        sSQL = "SELECT MstMerchClass.MLCode FROM MstMerchClass WHERE MstMerchClass.MLCode = '" & Set_Quote(cboCmpExgMLCode.Text) & "' And MLStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        Chk_CmpExgMLCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboCmpExlMLCode() As Boolean
        Chk_cboCmpExlMLCode = False

        If Trim(cboCmpExlMLCode.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpExlMLCode.Focus()
            Exit Function
        End If

        If Chk_CmpExlMLCode() = False Then
            gsMsg = "對換損失不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpExlMLCode.Focus()
            Exit Function
        End If

        Chk_cboCmpExlMLCode = True
    End Function

    Private Function Chk_CmpExlMLCode() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpExlMLCode = False

        sSQL = "SELECT MstMerchClass.MLCode FROM MstMerchClass WHERE MstMerchClass.MLCode = '" & Set_Quote(cboCmpExlMLCode.Text) & "' And MLStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        Chk_CmpExlMLCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboCmpTiMLCode() As Boolean
        Chk_cboCmpTiMLCode = False

        If Trim(cboCmpTiMLCode.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpTiMLCode.Focus()
            Exit Function
        End If

        If Chk_CmpTiMLCode() = False Then
            gsMsg = "暫記收入不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpTiMLCode.Focus()
            Exit Function
        End If

        Chk_cboCmpTiMLCode = True
    End Function

    Private Function Chk_CmpTiMLCode() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpTiMLCode = False

        sSQL = "SELECT MstMerchClass.MLCode FROM MstMerchClass WHERE MstMerchClass.MLCode = '" & Set_Quote(cboCmpTiMLCode.Text) & "' And MLStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        Chk_CmpTiMLCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboCmpTeMLCode() As Boolean
        Chk_cboCmpTeMLCode = False

        If Trim(cboCmpTeMLCode.Text) = "" Then
            gsMsg = "沒有輸入資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpTeMLCode.Focus()
            Exit Function
        End If

        If Chk_CmpTeMLCode() = False Then
            gsMsg = "暫記支出不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboCmpTeMLCode.Focus()
            Exit Function
        End If

        Chk_cboCmpTeMLCode = True
    End Function

    Private Function Chk_CmpTeMLCode() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_CmpTeMLCode = False

        sSQL = "SELECT MstMerchClass.MLCode FROM MstMerchClass WHERE MstMerchClass.MLCode = '" & Set_Quote(cboCmpTeMLCode.Text) & "' And MLStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        Chk_CmpTeMLCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub txtCmpRptEngAdd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpRptEngAdd.Enter
        FocusMe(txtCmpRptEngAdd)
    End Sub

    Private Sub txtCmpRptEngAdd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpRptEngAdd.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpRptEngAdd, 100, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtCmpRptEngAdd() = True Then
                txtCmpRptChiAdd.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCmpRptChiAdd_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpRptChiAdd.Leave
        FocusMe(txtCmpRptChiAdd, True)
    End Sub

    Private Sub txtCmpRptChiAdd_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCmpRptChiAdd.Enter
        FocusMe(txtCmpRptChiAdd)
    End Sub

    Private Sub txtCmpRptChiAdd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCmpRptChiAdd.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtCmpRptChiAdd, 100, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtCmpRptChiAdd() = True Then
                txtCmpTel.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_txtCmpRptChiAdd() As Boolean
        Chk_txtCmpRptChiAdd = False

        If Trim(txtCmpRptChiAdd.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtCmpRptChiAdd.Focus()
            Exit Function
        End If

        Chk_txtCmpRptChiAdd = True
    End Function

    Private Function Chk_txtCmpRptEngAdd() As Boolean
        Chk_txtCmpRptEngAdd = False

        If Trim(txtCmpRptEngAdd.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtCmpRptEngAdd.Focus()
            Exit Function
        End If

        Chk_txtCmpRptEngAdd = True
    End Function

    Private Function Chk_txtCmpTel() As Boolean
        Chk_txtCmpTel = False

        If Trim(txtCmpTel.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtCmpTel.Focus()
            Exit Function
        End If

        Chk_txtCmpTel = True
    End Function

    Public Function LoadCmpRetainACCodeByID(ByVal inCode As Object) As String
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT COAAccCode FROM MstCOA WHERE COAAccID =" & To_Value(inCode)

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LoadCmpRetainACCodeByID = ReadRs(rsRcd, "COAAccCode")
        Else
            LoadCmpRetainACCodeByID = ""
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Public Function LoadCmpRetainACIDByCode(ByVal inCode As Object) As Integer
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        'UPGRADE_WARNING: Couldn't resolve default property of object inCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsSQL = "SELECT COAAccID FROM MstCOA WHERE COAAccCode='" & Set_Quote(inCode) & "' AND COAStatus='1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LoadCmpRetainACIDByCode = ReadRs(rsRcd, "COAAccID")
        Else
            LoadCmpRetainACIDByCode = 0
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub cboCmpDamMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpDamMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpDamMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpDamMLCode.SelectionLength > 0, "", Set_Quote(cboCmpDamMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboCmpDamMLCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboCmpDamMLCode.Top) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(cboCmpDamMLCode.Height), tblCommon, "CMP001", "TBLCMPDAMML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpDamMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpDamMLCode.Enter
        tabDetailInfo.SelectedIndex = 2
        FocusMe(cboCmpDamMLCode)
    End Sub

    Private Sub cboCmpDamMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpDamMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpDamMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpDamMLCode() = True Then
                cboCmpSamMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpDamMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpDamMLCode.Leave
        FocusMe(cboCmpDamMLCode, True)
    End Sub

    Private Sub cboCmpSamMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpSamMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpSamMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpSamMLCode.SelectionLength > 0, "", Set_Quote(cboCmpSamMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboCmpSamMLCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboCmpSamMLCode.Top) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(cboCmpSamMLCode.Height), tblCommon, "CMP001", "TBLCMPDAMML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpSamMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpSamMLCode.Enter
        tabDetailInfo.SelectedIndex = 2
        FocusMe(cboCmpSamMLCode)
    End Sub

    Private Sub cboCmpSamMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpSamMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpSamMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpSamMLCode() = True Then
                cboCmpAdjMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCmpSamMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpSamMLCode.Leave
        FocusMe(cboCmpSamMLCode, True)
    End Sub

    Private Sub cboCmpAdjMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpAdjMLCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCmpAdjMLCode

        wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
        wsSQL = wsSQL & " AND MLCode LIKE '%" & IIf(cboCmpAdjMLCode.SelectionLength > 0, "", Set_Quote(cboCmpAdjMLCode.Text)) & "%' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboCmpAdjMLCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboCmpAdjMLCode.Top) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(cboCmpAdjMLCode.Height), tblCommon, "CMP001", "TBLCMPDAMML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboCmpAdjMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpAdjMLCode.Enter
        tabDetailInfo.SelectedIndex = 2
        FocusMe(cboCmpAdjMLCode)
    End Sub

    Private Sub cboCmpAdjMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCmpAdjMLCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboCmpAdjMLCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCmpTeMLCode() = True Then
                cboCmpSupMLCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub cboCmpAdjMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCmpAdjMLCode.Leave
		FocusMe(cboCmpAdjMLCode, True)
	End Sub
	
	Private Function Chk_cboCmpDamMLCode() As Boolean
		Chk_cboCmpDamMLCode = False
		
		If Trim(cboCmpDamMLCode.Text) = "" Then
			gsMsg = "沒有輸入資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 2
			cboCmpDamMLCode.Focus()
			Exit Function
		End If
		
		If Chk_CmpMLCode(cboCmpDamMLCode.Text) = False Then
			gsMsg = "報損帳戶不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 2
			cboCmpDamMLCode.Focus()
			Exit Function
		End If
		
		Chk_cboCmpDamMLCode = True
	End Function
	
	Private Function Chk_cboCmpSamMLCode() As Boolean
		Chk_cboCmpSamMLCode = False
		
		If Trim(cboCmpSamMLCode.Text) = "" Then
			gsMsg = "沒有輸入資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 2
			cboCmpSamMLCode.Focus()
			Exit Function
		End If
		
		If Chk_CmpMLCode(cboCmpSamMLCode.Text) = False Then
			gsMsg = "樣本帳戶不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 2
			cboCmpSamMLCode.Focus()
			Exit Function
		End If
		
		Chk_cboCmpSamMLCode = True
	End Function
	
	Private Function Chk_cboCmpAdjMLCode() As Boolean
		Chk_cboCmpAdjMLCode = False
		
		If Trim(cboCmpAdjMLCode.Text) = "" Then
			gsMsg = "沒有輸入資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 2
			cboCmpAdjMLCode.Focus()
			Exit Function
		End If
		
		If Chk_CmpMLCode(cboCmpAdjMLCode.Text) = False Then
			gsMsg = "調整帳戶不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 2
			cboCmpAdjMLCode.Focus()
			Exit Function
		End If
		
		Chk_cboCmpAdjMLCode = True
	End Function
	
	Private Function Chk_CmpMLCode(ByRef sMLCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim sSQL As String
		
		Chk_CmpMLCode = False
		
		sSQL = "SELECT MstMerchClass.MLCode FROM MstMerchClass WHERE MstMerchClass.MLCode = '" & Set_Quote(sMLCode) & "' And MLStatus = '1'"
		
		rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		Chk_CmpMLCode = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
End Class