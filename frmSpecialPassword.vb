Option Strict Off
Option Explicit On
Friend Class frmSpecialPassword
	Inherits System.Windows.Forms.Form
	
	
	
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	'variable for new property
	Private mbResult As Boolean
	Private msDocNo As String
	
	
	WriteOnly Property DocNo() As String
		Set(ByVal Value As String)
			
			msDocNo = Value
			
		End Set
	End Property
	
	ReadOnly Property Result() As Boolean
		Get
			
			Result = mbResult
			
		End Get
	End Property
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		mbResult = False
		Me.Close()
	End Sub
	
	Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
		
		If Chk_txtPassword() = False Then Exit Sub
		
		mbResult = True
		Me.Close()
		
	End Sub
	
	Private Sub frmSpecialPassword_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		
		mbResult = False
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub frmSpecialPassword_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmSpecialPassword may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub txtPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Enter
		FocusMe(txtPassword)
	End Sub
	
	Private Sub txtPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		' Call chk_InpLenA(txtPassword, 30, KeyAscii, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtPassword() = False Then GoTo EventExitSub
			
			btnOK.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtPassword_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Leave
		FocusMe(txtPassword, True)
	End Sub
	
	Private Sub Ini_Form()
		
		Me.KeyPreview = True
		txtPassword.PasswordChar = CChar("*")
		wsFormID = "SpecPwd"
		
		
	End Sub
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		Me.Text = Get_Caption(waScrItm, "SCRHDR")
		lblPassword.Text = Get_Caption(waScrItm, "Password") & " (" & msDocNo & ")"
		btnOK.Text = Get_Caption(waScrItm, "OK")
		btnCancel.Text = Get_Caption(waScrItm, "CANCEL")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Function Chk_txtPassword() As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsMsg As String
		
		Chk_txtPassword = False
		
		If Trim(txtPassword.Text) = "" Then
			wsMsg = "請輸入特定密碼!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_txtPassword = False
			Exit Function
		End If
		
		
		If Chk_SpecialPassword(txtPassword.Text) = False Then
			wsMsg = "密碼錯誤!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtPassword.Text = ""
			Chk_txtPassword = False
		Else
			Chk_txtPassword = True
		End If
		
		
		
	End Function
End Class