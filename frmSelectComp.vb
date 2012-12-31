Option Strict Off
Option Explicit On
Friend Class frmSelectComp
	Inherits System.Windows.Forms.Form
	
	
	Public ctlKey As String
	Public wsCmpCode As String
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	'variable for new property
	
	Private Sub frmSelectComp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		
		wsCmpCode = Get_CompanyFlag("CMPCODE")
		
		Select Case wsCmpCode
			Case "FR"
				OptComp(0).Checked = True
			Case "CF"
				OptComp(1).Checked = True
			Case "CY"
				OptComp(2).Checked = True
		End Select
		
		
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub frmSelectComp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If Chk_txtKeyNo() = False Then
			
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Exit Sub
			
		Else
			ctlKey = UCase(wsCmpCode)
			
		End If
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmSelectComp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
		Me.Text = "Copy Quotation"
		
		fraSelect.Text = "Company Select"
		
		OptComp(0).Text = "Fair Rack (½÷°ì)"
		OptComp(1).Text = "Chung Fai (©¾½÷)"
		OptComp(2).Text = "Cyber Fortune (¬ÕºÖ)"
		
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Function Chk_txtKeyNo() As Boolean
		
		Dim wsMsg As String
		
		Chk_txtKeyNo = False
		
		If OptComp(0).Checked Then
			wsCmpCode = "FR"
		ElseIf OptComp(1).Checked Then 
			wsCmpCode = "CF"
		Else
			wsCmpCode = "CY"
		End If
		
		
		If Trim(wsCmpCode) = "" Then
			wsMsg = "Company Code Must Input!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		
		If UCase(wsCmpCode) <> "FR" And UCase(wsCmpCode) <> "CF" And UCase(wsCmpCode) <> "CY" Then
			
			wsMsg = "Company Coode Not Exist!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
			
		End If
		
		
		Chk_txtKeyNo = True
		
	End Function
End Class