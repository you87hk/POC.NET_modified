Option Strict Off
Option Explicit On
Friend Class frmChangeKey
	Inherits System.Windows.Forms.Form
	
	
	
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	'variable for new property
	Private mlKeyID As Integer
	Private msKeyType As String
	Private mbResult As Boolean
	Private msNewKey As String
	
	WriteOnly Property KeyID() As Integer
		Set(ByVal Value As Integer)
			
			mlKeyID = Value
			
		End Set
	End Property
	
	WriteOnly Property KeyType() As String
		Set(ByVal Value As String)
			
			msKeyType = Value
			
		End Set
	End Property
	
	
	
	ReadOnly Property Result() As Boolean
		Get
			
			Result = mbResult
			
		End Get
	End Property
	
	ReadOnly Property NewKey() As String
		Get
			
			NewKey = msNewKey
			
		End Get
	End Property
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		mbResult = False
		Me.Close()
	End Sub
	
	Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
		
		If Chk_txtKeyNo() = False Then Exit Sub
		
		mbResult = True
		msNewKey = txtKeyNo.Text
		Me.Close()
		
	End Sub
	
	Private Sub frmChangeKey_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		
		mbResult = False
		msNewKey = ""
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub frmChangeKey_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmChangeKey may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub txtKeyNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtKeyNo.Enter
		FocusMe(txtKeyNo)
	End Sub
	
	Private Sub txtKeyNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtKeyNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLenA(txtKeyNo, 30, KeyAscii, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0  ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtKeyNo() = False Then GoTo EventExitSub
			
			btnOK.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtKeyNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtKeyNo.Leave
		FocusMe(txtKeyNo, True)
	End Sub
	
	Private Sub Ini_Form()
		
		Me.KeyPreview = True
		wsFormID = "ChangeKey"
		
		
	End Sub
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		lblKeyNo.Text = Get_Caption(waScrItm, "KeyNo")
		btnOK.Text = Get_Caption(waScrItm, "OK")
		btnCancel.Text = Get_Caption(waScrItm, "CANCEL")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Function Chk_txtKeyNo() As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsMsg As String
		
		Chk_txtKeyNo = False
		
		If Trim(txtKeyNo.Text) = "" Then
			wsMsg = "物料編號由系統設定!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtKeyNo.Text = Get_ItemNo(msKeyType)
			Chk_txtKeyNo = True
			Exit Function
		End If
		
		wsSQL = "SELECT * FROM mstItem WHERE ItmCode = '" & Set_Quote(txtKeyNo.Text) & "'"
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			
			wsMsg = "物料編號已存在!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtKeyNo.Focus()
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
			
		End If
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		Chk_txtKeyNo = True
		
	End Function
End Class