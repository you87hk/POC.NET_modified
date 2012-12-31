Option Strict Off
Option Explicit On
Friend Class frmCHGPWD
	Inherits System.Windows.Forms.Form
	Private wsFormCaption As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	
	
	Private Const wsKeyType As String = "MstAccountType"
	Private wsUsrId As String
	Private wsFormID As String
	Private wsConnTime As String
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblUser.Text = Get_Caption(waScrItm, "USERID")
		lblPassword.Text = Get_Caption(waScrItm, "PASSWORD")
		lblNewPassword.Text = Get_Caption(waScrItm, "NEWPASSWORD")
		
		cmdOK.Text = Get_Caption(waScrItm, "OK")
		cmdCancel.Text = Get_Caption(waScrItm, "CANCEL")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	Private Sub IniForm()
		Me.KeyPreview = True
		
		
		
		wsConnTime = Dsp_Date(Now, True)
		wsFormID = "CHGPWD"
		
		
	End Sub
	
	Private Sub Ini_Scr()
		
		lblDspUserID.Text = gsUserID
		txtPassword.Text = ""
		txtNewPassword.Text = ""
		
		Me.Text = wsFormCaption
		
	End Sub
	Private Sub frmCHGPWD_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
		
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		'To Do - create test for correct password
		'check for correct password
		
		Dim Chk_Password_Result As Short
		
		
		Chk_Password_Result = Chk_Password((lblDspUserID.Text), (txtPassword.Text))
		
		Select Case Chk_Password_Result
			'  Case 0
			'      Me.Hide
			
			Case 1
				gsMsg = "密碼錯誤!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
				txtPassword.Focus()
				Exit Sub
		End Select
		
		
		If Chk_txtNewPassword = False Then Exit Sub
		
		If cmdSave Then Me.Close()
		
		
		
		
	End Sub
	
	
	Private Function Chk_Password(ByRef inUser As Object, ByRef inPassword As Object) As Short
		
		Dim rsLogin As New ADODB.Recordset
		Dim Criteria As String
		
		Chk_Password = 1
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inUser. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Criteria = "SELECT USRPWD, USRNAME FROM MSTUSER WHERE USRCODE = '" & Set_Quote(inUser) & "' "
		
		rsLogin.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsLogin.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object inPassword. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Encrypt(rsLogin.Fields("USRPWD").Value) <> UCase(inPassword) Then
				Chk_Password = 1
				Exit Function
			End If
		Else
			Exit Function
		End If
		rsLogin.Close()
		
		Chk_Password = 0
	End Function
	
	
	
	
	
	Private Sub txtPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Enter
		Call FocusMe(txtPassword)
	End Sub
	
	Private Sub txtPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtNewPassword.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtPassword_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Leave
        Call FocusMe(txtPassword, True)
    End Sub

    Private Sub txtNewPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNewPassword.Enter
        Call FocusMe(txtNewPassword)
    End Sub

    Private Sub txtNewPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPassword.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtNewPassword Then
                cmdOK.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtNewPassword_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNewPassword.Leave
		Call FocusMe(txtNewPassword, True)
	End Sub
	
	
	Private Function Chk_txtNewPassword() As Boolean
		Dim wsTrnCd As Object
		Dim wsStatus As String
		
		Chk_txtNewPassword = False
		
		'UPGRADE_WARNING: Couldn't resolve default property of object wsTrnCd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Trim(txtNewPassword.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtNewPassword.Focus()
			Exit Function
		End If
		
		
		Chk_txtNewPassword = True
	End Function
	Private Function cmdSave() As Boolean
		Dim wsGenDte As String
		Dim wsNo As String
		Dim adcmdSave As New ADODB.Command
		
		On Error GoTo cmdSave_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = VB6.Format(Today, "YYYY/MM/DD")
		
		
		
		cmdSave = False
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_CHGPWD"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, 2)
		Call SetSPPara(adcmdSave, 2, lblDspUserID.Text)
		Call SetSPPara(adcmdSave, 3, Encrypt(UCase(Set_Quote(txtNewPassword.Text))))
		Call SetSPPara(adcmdSave, 4, gsUserID)
		Call SetSPPara(adcmdSave, 5, wsGenDte)
		
		adcmdSave.Execute()
		
		cnCon.CommitTrans()
		
		
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
End Class