Option Strict Off
Option Explicit On
Friend Class frmDocRemark
	Inherits System.Windows.Forms.Form
	
	
	
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	'variable for new property
	Private msRmkID As String
	Private msRmkType As String
	
	Private wbExit As Boolean
	Private wsOldRmk As String
	
	
	
	
	
	Property RmkID() As String
		Get
			
			RmkID = msRmkID
			
		End Get
		Set(ByVal Value As String)
			
			msRmkID = Value
			
		End Set
	End Property
	WriteOnly Property RmkType() As String
		Set(ByVal Value As String)
			
			msRmkType = Value
			
		End Set
	End Property
	
	
	
	Private Sub frmDocRemark_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub frmDocRemark_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If wbExit = False Then
			
			Call cmdSave()
			wbExit = True
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Me.Hide()
			Exit Sub
			
		End If
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmDocRemark may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub txtRmk_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Enter
		'    FocusMe txtRmk
	End Sub
	
	Private Sub txtRmk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		'Call chk_InpLen(txtRmk, KeyLen, KeyAscii)
		
		
		'   If Len(txtRmk.Text) Mod 50 = 0 And KeyAscii <> vbKeyReturn And KeyAscii <> vbKeyBack Then
		'       KeyAscii = vbKeyReturn
		'   End If
		
		
		'  If KeyAscii = vbKeyReturn Then
		'        KeyAscii = vbDefault
		
		'        If Chk_txtRmk() = False Then Exit Sub
		
		
		
		'  End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Leave
		FocusMe(txtRmk, True)
	End Sub
	
	Private Sub Ini_Form()
		
		Me.KeyPreview = True
		wsFormID = "DocRemark"
		
		
	End Sub
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		Me.Text = Get_Caption(waScrItm, "SCRHDR")
		
		lblRmk.Text = Get_Caption(waScrItm, "Rmk")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Function Chk_txtRmk() As Boolean
		
		Dim wsMsg As String
		
		Chk_txtRmk = False
		
		If Trim(txtRmk.Text) = "" Then
			wsMsg = "Remark Must Input!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtRmk.Focus()
			Exit Function
		End If
		
		Chk_txtRmk = True
		
	End Function
	
	Private Sub Ini_Scr()
		
		
		
		wbExit = False
		
		Call LoadRecord()
		
		
	End Sub
	
	Public Function LoadRecord() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		wsSQL = "SELECT DRREMARK "
		wsSQL = wsSQL & "FROM MSTDOCREMARK "
		wsSQL = wsSQL & "WHERE DRID = " & msRmkID
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtRmk.Text = ReadRs(rsRcd, "DRREMARK")
			wsOldRmk = txtRmk.Text
			LoadRecord = True
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	
	Private Function cmdSave() As Boolean
		Dim wsGenDte As String
		
		Dim adcmdSave As New ADODB.Command
		
		On Error GoTo cmdSave_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		If Trim(txtRmk.Text) = "" Then
			msRmkID = "0"
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Function
		End If
		
		If wsOldRmk = txtRmk.Text Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Function
		End If
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_DR001"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, msRmkID)
		Call SetSPPara(adcmdSave, 2, msRmkType)
		Call SetSPPara(adcmdSave, 3, txtRmk.Text)
		Call SetSPPara(adcmdSave, 4, gsUserID)
		Call SetSPPara(adcmdSave, 5, wsGenDte)
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		msRmkID = GetSPPara(adcmdSave, 6)
		
		cnCon.CommitTrans()
		
		If Trim(msRmkID) = "" Then
			gsMsg = "儲存失敗, 請檢查 Store Procedure - EXC001!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		Else
			gsMsg = "已成功儲存!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		End If
		
		
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
	
	Private Sub frmDocRemark_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.Escape
				Me.Close()
		End Select
	End Sub
End Class