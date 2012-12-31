Option Strict Off
Option Explicit On
Friend Class frmSelectWhs
	Inherits System.Windows.Forms.Form
	
	
	Public ctlKey As String
	Public wsWhsCode As String
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	'variable for new property
	
	Private Sub frmSelectWhs_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		
		wsWhsCode = Get_TableInfo("SYSWSINFO", "WSID = '01'", "WSWHSCODE")
		
		Select Case wsWhsCode
			Case "CF-HK"
				OptComp(0).Checked = True
			Case "CF-HZ"
				OptComp(1).Checked = True
			Case Else
				OptComp(0).Checked = True
		End Select
		
		
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub frmSelectWhs_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If Chk_txtKeyNo() = False Then
			
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Exit Sub
			
		Else
			ctlKey = UCase(wsWhsCode)
			
		End If
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmSelectWhs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	
	Private Sub Ini_Form()
		
		Me.KeyPreview = True
		wsFormID = "SelectComp"
		
		
	End Sub
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		'lblKeyNo.Caption = Get_Caption(waScrItm, "KeyNo")
		Me.Text = "Select Warehouse"
		
		fraSelect.Text = "Where is the location (­Ü®w¦ì¸m)"
		
		OptComp(0).Text = "Hong Kong(­»´ä­Ü)"
		OptComp(1).Text = "H.Z. (Åb¤s­Ü)"
		
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Function Chk_txtKeyNo() As Boolean
		
		Dim wsMsg As String
		
		Chk_txtKeyNo = False
		
		If OptComp(0).Checked Then
			wsWhsCode = "CF-HK"
		ElseIf OptComp(1).Checked Then 
			wsWhsCode = "CF-HZ"
		Else
			wsWhsCode = "CF-HZ"
		End If
		
		
		If Trim(wsWhsCode) = "" Then
			wsMsg = "Warehouse Code Must Input!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		
		If UCase(wsWhsCode) <> "CF-HK" And UCase(wsWhsCode) <> "CF-HZ" Then
			
			wsMsg = "Warehouse Coode Not Exist!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		
		Chk_txtKeyNo = True
		
	End Function
End Class