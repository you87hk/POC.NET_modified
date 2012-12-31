Option Strict Off
Option Explicit On
Friend Class frmWS001
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
	
	Private wlCusID As Integer
	Private wlVdrID As Integer
	Private wlSaleID As Integer
	
	Private Const wsKeyType As String = "sysWSINFO"
	Private wsUsrId As String
	Private wsTrnCd As String
	
	Private Sub cboWsCusCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsCusCode.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWsCusCode
		
		If gsLangID = "1" Then
			wsSql = "SELECT CUSCODE, CUSNAME FROM mstCUSTOMER "
			wsSql = wsSql & "WHERE CUSCODE LIKE '%" & IIf(cboWsCusCode.SelectionLength > 0, "", Set_Quote(cboWsCusCode.Text)) & "%' "
			wsSql = wsSql & "AND CUSSTATUS = '1' "
			wsSql = wsSql & " AND CusInactive = 'N' "
			wsSql = wsSql & "ORDER BY CUSCODE "
		Else
			wsSql = "SELECT CUSCODE, CUSNAME FROM mstCUSTOMER "
			wsSql = wsSql & "WHERE CUSCODE LIKE '%" & IIf(cboWsCusCode.SelectionLength > 0, "", Set_Quote(cboWsCusCode.Text)) & "%' "
			wsSql = wsSql & "AND CUSSTATUS = '1' "
			wsSql = wsSql & " AND CusInactive = 'N' "
			wsSql = wsSql & "ORDER BY CUSCODE "
		End If
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboWsCusCode.Left)), VB6.PixelsToTwipsY(cboWsCusCode.Top) + VB6.PixelsToTwipsY(cboWsCusCode.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWsCusCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsCusCode.Enter
		FocusMe(cboWsCusCode)
	End Sub
	
	Private Sub cboWsCusCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWsCusCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWsCusCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If chk_cboWsCusCode() Then
				cboWsVdrCode.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWsCusCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsCusCode.Leave
		FocusMe(cboWsCusCode, True)
	End Sub
	
	Private Sub cboWSID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSID.Leave
		FocusMe(cboWSID, True)
	End Sub
	
	Private Sub cboWSMethodCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSMethodCode.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWSMethodCode
		
		wsSql = "SELECT MethodCode, MethodDesc FROM MstMethod WHERE MethodStatus = '1'"
		wsSql = wsSql & " AND MethodCode LIKE '%" & IIf(cboWSMethodCode.SelectionLength > 0, "", Set_Quote(cboWSMethodCode.Text)) & "%' "
		wsSql = wsSql & "ORDER BY MethodCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboWSMethodCode.Left)), VB6.PixelsToTwipsY(cboWSMethodCode.Top) + VB6.PixelsToTwipsY(cboWSMethodCode.Height), tblCommon, wsFormID, "TBLM", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWSMethodCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSMethodCode.Enter
		FocusMe(cboWSMethodCode)
	End Sub
	
	Private Sub cboWSMethodCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWSMethodCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWSMethodCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboWSMethodCode() = True Then
				cboWSWhsCode.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWSMethodCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSMethodCode.Leave
		FocusMe(cboWSMethodCode, True)
	End Sub
	
	Private Sub cboWSPayCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSPayCode.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWSPayCode
		
		wsSql = "SELECT PayCode, PayDesc, PayMethod FROM MstPayTerm WHERE PayStatus = '1'"
		wsSql = wsSql & " AND PayCode LIKE '%" & IIf(cboWSPayCode.SelectionLength > 0, "", Set_Quote(cboWSPayCode.Text)) & "%' "
		wsSql = wsSql & "ORDER BY PayCode "
		Call Ini_Combo(3, wsSql, (VB6.PixelsToTwipsX(cboWSPayCode.Left)), VB6.PixelsToTwipsY(cboWSPayCode.Top) + VB6.PixelsToTwipsY(cboWSPayCode.Height), tblCommon, wsFormID, "TBLPAY", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWSPayCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSPayCode.Enter
		FocusMe(cboWSPayCode)
	End Sub
	
	Private Sub cboWSPayCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWSPayCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWSPayCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboWSPayCode() = True Then
				cboWSMethodCode.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWSPayCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSPayCode.Leave
		FocusMe(cboWSPayCode, True)
	End Sub
	
	Private Sub cboWsSaleCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsSaleCode.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWsSaleCode
		
		wsSql = "SELECT SaleCode, SaleName FROM MstSalesman WHERE SaleStatus = '1'"
		wsSql = wsSql & " AND SaleCode LIKE '%" & IIf(cboWsSaleCode.SelectionLength > 0, "", Set_Quote(cboWsSaleCode.Text)) & "%' "
		
		wsSql = wsSql & "ORDER BY SaleCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboWsSaleCode.Left)), VB6.PixelsToTwipsY(cboWsSaleCode.Top) + VB6.PixelsToTwipsY(cboWsSaleCode.Height), tblCommon, wsFormID, "TBLSLMCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboWsSaleCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsSaleCode.Enter
		FocusMe(cboWsSaleCode)
	End Sub
	
	Private Sub cboWsSaleCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWsSaleCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWsSaleCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Chk_cboWSSaleCode() Then
				cboCurr.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWsSaleCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsSaleCode.Leave
		FocusMe(cboWsSaleCode, True)
	End Sub
	
	Private Sub cboWsVdrCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsVdrCode.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWsVdrCode
		
		If gsLangID = "1" Then
			wsSql = "SELECT VDRCODE, VDRNAME FROM MstVendor "
			wsSql = wsSql & "WHERE VDRCODE LIKE '%" & IIf(cboWsVdrCode.SelectionLength > 0, "", Set_Quote(cboWsVdrCode.Text)) & "%' "
			wsSql = wsSql & "AND VDrSTATUS = '1' "
			wsSql = wsSql & " AND VdrInactive = 'N' "
			wsSql = wsSql & "ORDER BY VDRCODE "
		Else
			wsSql = "SELECT VDRCODE, VDRNAME FROM MstVendor "
			wsSql = wsSql & "WHERE VDRCODE LIKE '%" & IIf(cboWsVdrCode.SelectionLength > 0, "", Set_Quote(cboWsVdrCode.Text)) & "%' "
			wsSql = wsSql & "AND VDRSTATUS = '1' "
			wsSql = wsSql & " AND VdrInactive = 'N' "
			wsSql = wsSql & "ORDER BY VDrCODE "
		End If
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboWsVdrCode.Left)), VB6.PixelsToTwipsY(cboWsVdrCode.Top) + VB6.PixelsToTwipsY(cboWsVdrCode.Height), tblCommon, wsFormID, "TBLVDRNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboWsVdrCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsVdrCode.Enter
		FocusMe(cboWsVdrCode)
	End Sub
	
	Private Sub cboWsVdrCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWsVdrCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWsVdrCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If chk_cboWsVdrCode() Then
				cboWsSaleCode.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWsVdrCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWsVdrCode.Leave
		FocusMe(cboWsVdrCode, True)
	End Sub
	
	Private Sub cboWSWhsCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSWhsCode.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWSWhsCode
		
		wsSql = "SELECT WhsCode, WhsDesc FROM MstWarehouse WHERE WhsStatus = '1'"
		wsSql = wsSql & " AND WhsCode LIKE '%" & IIf(cboWSWhsCode.SelectionLength > 0, "", Set_Quote(cboWSWhsCode.Text)) & "%' "
		wsSql = wsSql & "ORDER BY WhsCode "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboWSWhsCode.Left)), VB6.PixelsToTwipsY(cboWSWhsCode.Top) + VB6.PixelsToTwipsY(cboWSWhsCode.Height), tblCommon, wsFormID, "TBLWHS", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWSWhsCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSWhsCode.Enter
		FocusMe(cboWSWhsCode)
	End Sub
	
	Private Sub cboWSWhsCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWSWhsCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWSWhsCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboWSWhsCode() = True Then
				cboWsCusCode.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWSWhsCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSWhsCode.Leave
		FocusMe(cboWSWhsCode, True)
	End Sub
	
	Private Sub frmWS001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmWS001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_WARNING: Event frmWS001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmWS001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'-- Resize, not maximum and minimax.
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(6075)
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
				Me.cboWSID.Enabled = False
				Me.cboWSID.Visible = False
				Me.txtWSID.Visible = True
				Me.txtWSID.Enabled = False
				
				cboCurr.Enabled = False
				txtWSExcr.Enabled = False
				cboWSPayCode.Enabled = False
				cboWSMethodCode.Enabled = False
				cboWSWhsCode.Enabled = False
				cboWsCusCode.Enabled = False
				cboWsVdrCode.Enabled = False
				cboWsSaleCode.Enabled = False
				
			Case "AfrActAdd"
				Me.cboWSID.Enabled = False
				Me.cboWSID.Visible = False
				
				Me.txtWSID.Enabled = True
				Me.txtWSID.Visible = True
				
			Case "AfrActEdit"
				Me.cboWSID.Enabled = True
				Me.cboWSID.Visible = True
				
				Me.txtWSID.Enabled = False
				Me.txtWSID.Visible = False
				
			Case "AfrKey"
				Me.cboWSID.Enabled = False
				Me.txtWSID.Enabled = False
				
				cboCurr.Enabled = True
				txtWSExcr.Enabled = True
				cboWSPayCode.Enabled = True
				cboWSMethodCode.Enabled = True
				cboWSWhsCode.Enabled = True
				cboWsCusCode.Enabled = True
				cboWsVdrCode.Enabled = True
				cboWsSaleCode.Enabled = True
		End Select
	End Sub
	
	'-- Input validation checking.
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_cboCurr = False Then
			Exit Function
		End If
		
		If Chk_txtWSExcr = False Then
			Exit Function
		End If
		
		If Chk_cboWSPayCode = False Then
			Exit Function
		End If
		
		If Chk_cboWSMethodCode = False Then
			Exit Function
		End If
		
		If Chk_cboWSWhsCode = False Then
			Exit Function
		End If
		
		If chk_cboWsCusCode = False Then
			Exit Function
		End If
		
		If chk_cboWsVdrCode = False Then
			Exit Function
		End If
		
		If Chk_cboWSSaleCode = False Then
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	Public Function LoadRecord() As Boolean
		Dim wsSql As String
		Dim rsRcd As New ADODB.Recordset
		
		wsSql = "SELECT sysWSINFO.* "
		wsSql = wsSql & "From sysWSINFO "
		wsSql = wsSql & "WHERE (((sysWSINFO.WSID)='" & Set_Quote(cboWSID.Text) & "') "
		wsSql = wsSql & "AND ((WSStatus)='1'));"
		
		rsRcd.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboWSID.Text = ReadRs(rsRcd, "WSID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboCurr.Text = ReadRs(rsRcd, "WSCURR")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtWSExcr.Text = VB6.Format(ReadRs(rsRcd, "WSEXCR"), gsExrFmt)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboWSPayCode.Text = ReadRs(rsRcd, "WSPAYCODE")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboWSMethodCode.Text = ReadRs(rsRcd, "WSMETHODCODE")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboWSWhsCode.Text = ReadRs(rsRcd, "WSWHSCODE")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlCusID = ReadRs(rsRcd, "WSCUSID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlVdrID = ReadRs(rsRcd, "WSVDRID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlSaleID = ReadRs(rsRcd, "WSSALEID")
			
			cboWsSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
			lblDspWsSaleName.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")
			cboWsVdrCode.Text = Get_TableInfo("MstVendor", "VDRID =" & wlVdrID, "VDRCODE")
			lblDspWsVdrName.Text = Get_TableInfo("MstVendor", "VDRID =" & wlVdrID, "VDRNAME")
			cboWsCusCode.Text = Get_TableInfo("MstCustomer", "CUSID =" & wlCusID, "CUSCODE")
			lblDspWsCusName.Text = Get_TableInfo("MstCustomer", "CUSID =" & wlCusID, "CUSNAME")
			lblDspWSPayDesc.Text = Get_TableInfo("MstPayTerm", "PayCode ='" & cboWSPayCode.Text & "'", "PAYDESC")
			lblDspWSMethodDesc.Text = Get_TableInfo("MstMethod", "MethodCode ='" & cboWSMethodCode.Text & "'", "METHODDESC")
			lblDspWSWhsDesc.Text = Get_TableInfo("MstWareHouse", "WhsCode ='" & cboWSWhsCode.Text & "'", "WHSDESC")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspWSLastUpd.Text = ReadRs(rsRcd, "WSLastUpd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspWSLastUpdDate.Text = ReadRs(rsRcd, "WSLastUpdDate")
			
			LoadRecord = True
		End If
		
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Private Sub frmWS001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Exit Sub
		End If
		Call UnlockAll(wsConnTime, wsFormID)
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object frmWS001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() '  = Nothing
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
		wsFormID = "WS001"
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
		
		txtWSExcr.Text = VB6.Format(0, gsExrFmt)
		
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
				txtWSID.Focus()
				
			Case CorRec
				
				Call SetFieldStatus("AfrActEdit")
				Call SetButtonStatus("AfrActEdit")
				cboWSID.Focus()
				
			Case DelRec
				
				Call SetFieldStatus("AfrActEdit")
				Call SetButtonStatus("AfrActEdit")
				cboWSID.Focus()
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
					If RowLock(wsConnTime, wsKeyType, cboWSID.Text, wsFormID, wsUsrId) = False Then
						gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
						MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					End If
				End If
		End Select
		Call SetFieldStatus("AfrKey")
		Call SetButtonStatus("AfrKey")
		cboCurr.Focus()
	End Sub
	
	Private Function Chk_WSID(ByVal inCode As String, ByRef outCode As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSql As String
		
		Chk_WSID = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSql = "SELECT WSStatus "
		wsSql = wsSql & " FROM sysWSINFO WHERE WSID = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			outCode = ""
			
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "WSStatus")
		
		Chk_WSID = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Function Chk_Curr(ByVal inCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim sSQL As String
		
		sSQL = "SELECT ExcCurr FROM MstExchangeRate WHERE ExcCurr='" & Set_Quote(inCode) & "' And ExcStatus = '1'"
		
		rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount < 1 Then
			Chk_Curr = False
		Else
			Chk_Curr = True
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Function Chk_cboWSID() As Boolean
		Dim wsStatus As String
		
		Chk_cboWSID = False
		
		If Trim(cboWSID.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWSID.Focus()
			Exit Function
		End If
		
		If Chk_WSID(cboWSID.Text, wsStatus) = False Then
			gsMsg = "工作站編碼不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWSID.Focus()
			Exit Function
		Else
			If wsStatus = "2" Then
				gsMsg = "工作站已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboWSID.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboWSID = True
	End Function
	
	Private Function Chk_cboCurr() As Boolean
		Dim wsStatus As String
		
		Chk_cboCurr = False
		
		If Trim(cboCurr.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboCurr.Focus()
			Exit Function
		End If
		
		If Chk_Curr(cboCurr.Text) = False Then
			gsMsg = "貨幣編碼不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboCurr.Focus()
			Exit Function
		End If
		
		Chk_cboCurr = True
	End Function
	
	Private Function Chk_cboWSPayCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboWSPayCode = False
		
		If Chk_PayTerm(cboWSPayCode.Text, wsDesc) = False Then
			gsMsg = "付款條款不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWSPayCode.Focus()
			Exit Function
		End If
		
		Me.lblDspWSPayDesc.Text = wsDesc
		
		Chk_cboWSPayCode = True
	End Function
	
	Private Function Chk_txtWSID() As Boolean
		Dim wsStatus As String
		
		Chk_txtWSID = False
		
		If Trim(txtWSID.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtWSID.Focus()
			Exit Function
		End If
		
		If Chk_WSID(txtWSID.Text, wsStatus) = True Then
			If wsStatus = "2" Then
				gsMsg = "工作站編碼已存在但已無效!"
			Else
				gsMsg = "工作站編碼已存在!"
			End If
			
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtWSID.Focus()
			Exit Function
		End If
		
		Chk_txtWSID = True
	End Function
	
	Private Function Chk_txtWSExcr() As Boolean
		Dim wsStatus As String
		
		Chk_txtWSExcr = False
		
		If To_Value(txtWSExcr) < 0 Then
			gsMsg = "對換率不可少於零!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtWSExcr.Focus()
			Exit Function
		End If
		
		If To_Value(txtWSExcr) > 100 Then
			gsMsg = "對換率不可大於一百!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			txtWSExcr.Focus()
			Exit Function
		End If
		
		Chk_txtWSExcr = True
	End Function
	
	Private Sub cmdOpen()
		Dim newForm As New frmWS001
		
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
					Call UnlockAll(wsConnTime, wsFormID)
					Call Ini_Scr()
					Call cmdEdit()
					
				Case DelRec
					Call UnlockAll(wsConnTime, wsFormID)
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
			If ReadOnlyMode(wsConnTime, wsKeyType, cboWSID.Text, wsFormID) Then
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
		
		adcmdSave.CommandText = "USP_WS001"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, wiAction)
		Call SetSPPara(adcmdSave, 2, IIf(wiAction = AddRec, txtWSID.Text, cboWSID.Text))
		Call SetSPPara(adcmdSave, 3, cboCurr)
		Call SetSPPara(adcmdSave, 4, txtWSExcr)
		Call SetSPPara(adcmdSave, 5, cboWSPayCode)
		Call SetSPPara(adcmdSave, 6, cboWSMethodCode)
		Call SetSPPara(adcmdSave, 7, cboWSWhsCode)
		Call SetSPPara(adcmdSave, 8, wlCusID)
		Call SetSPPara(adcmdSave, 9, wlVdrID)
		Call SetSPPara(adcmdSave, 10, wlSaleID)
		Call SetSPPara(adcmdSave, 11, gsUserID)
		Call SetSPPara(adcmdSave, 12, wsGenDte)
		
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsNo = GetSPPara(adcmdSave, 13)
		
		cnCon.CommitTrans()
		
		If wiAction = AddRec And Trim(wsNo) = "" Then
			gsMsg = "儲存失敗, 請檢查 Store Procedure - WS001!"
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
		
		Dim vFilterAry(6, 2) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 1) = "工作站編碼"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "WSID"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "貨幣"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "WSCURR"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 1) = "對換率"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 2) = "WSEXCR"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(4, 1) = "付款條款"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(4, 2) = "WSPAYCODE"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(5, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(5, 1) = "銷售渠道"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(5, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(5, 2) = "WSMETHODCODE"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(6, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(6, 1) = "貨倉"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(6, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(6, 2) = "WSWHSCODE"
		
		Dim vAry(6, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "工作站編碼"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "WSID"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "貨幣"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "WSCURR"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 1) = "對換率"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 2) = "WSEXCR"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(4, 1) = "付款條款"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(4, 2) = "WSPAYCODE"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(4, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(5, 1) = "銷售渠道"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(5, 2) = "WSMETHODCODe"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(5, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(6, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(6, 1) = "貨倉"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(6, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(6, 2) = "WSWHSCODE"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(6, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(6, 3) = "1500"
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			sSQL = "SELECT sysWSINFO.WSID, sysWSINFO.WSCURR, sysWSINFO.WSEXCR, sysWSINFO.WSPAYCODE, sysWSINFO.WSMETHODCODE, "
			sSQL = sSQL & "sysWSINFO.WSWHSCODE "
			sSQL = sSQL & "FROM sysWSINFO "
			.sBindSQL = sSQL
			.sBindWhereSQL = "WHERE sysWSINFO.WSStatus = '1' "
			.sBindOrderSQL = "ORDER BY sysWSINFO.WSID"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmWS001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboWSID.Text Then
			cboWSID.Text = Trim(frmShareSearch.Tag)
			System.Windows.Forms.SendKeys.Send("{ENTER}")
		End If
		frmShareSearch.Close()
	End Sub
	
	Private Sub txtWSExcr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWSExcr.Enter
		FocusMe(txtWSExcr)
	End Sub
	
	Private Sub txtWSExcr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWSExcr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call Chk_InpNum(KeyAscii, txtWSID.Text, False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtWSExcr() = True Then
				cboWSPayCode.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtWSExcr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWSExcr.Leave
		txtWSExcr.Text = VB6.Format(To_Value(txtWSExcr), gsExrFmt)
		FocusMe(txtWSExcr, True)
	End Sub
	
	Private Sub txtWSID_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWSID.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtWSID, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_txtWSID() = True Then
				Call Ini_Scr_AfrKey()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtWSID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWSID.Leave
		FocusMe(txtWSID, True)
	End Sub
	
	Private Sub txtWSID_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWSID.Enter
		FocusMe(txtWSID)
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
	
	Private Sub cboWSID_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWSID.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWSID, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboWSID() = True Then
				Call Ini_Scr_AfrKey()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWSID_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSID.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWSID
		
		wsSql = "SELECT WSID FROM sysWSINFO WHERE WSStatus = '1'"
		wsSql = wsSql & " AND WSID LIKE '%" & IIf(cboWSID.SelectionLength > 0, "", Set_Quote(cboWSID.Text)) & "%' "
		wsSql = wsSql & "ORDER BY WSID "
		Call Ini_Combo(1, wsSql, (VB6.PixelsToTwipsX(cboWSID.Left)), VB6.PixelsToTwipsY(cboWSID.Top) + VB6.PixelsToTwipsY(cboWSID.Height), tblCommon, wsFormID, "TBLWS", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWSID_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWSID.Enter
		FocusMe(cboWSID)
	End Sub
	
	Private Function Chk_KeyExist() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSql As String
		
		wsSql = "SELECT WsStatus FROM sysWSINFO WHERE WSID = '" & Set_Quote(txtWSID.Text) & "'"
		rsRcd.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
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
			.TableKey = "WSID"
			.KeyLen = 10
			.ctlKey = txtWSID
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
		
		lblWSID.Text = Get_Caption(waScrItm, "WSID")
		lblCurr.Text = Get_Caption(waScrItm, "Curr")
		lblWSExcr.Text = Get_Caption(waScrItm, "WSEXCR")
		lblWSPayCode.Text = Get_Caption(waScrItm, "WSPAYCODE")
		lblWSMethodCode.Text = Get_Caption(waScrItm, "WSMETHODCODE")
		lblWSWhsCode.Text = Get_Caption(waScrItm, "WSWHSCODE")
		lblWSCus.Text = Get_Caption(waScrItm, "WSCUS")
		lblWSVdr.Text = Get_Caption(waScrItm, "WSVDR")
		lblWSSale.Text = Get_Caption(waScrItm, "WSSALE")
		
		lblWSLastUpd.Text = Get_Caption(waScrItm, "WSLASTUPD")
		lblWSLastUpdDate.Text = Get_Caption(waScrItm, "WSLASTUPDDATE")
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		fraDetailInfo.Text = Get_Caption(waScrItm, "FRADETAILINFO")
		
		wsActNam(1) = Get_Caption(waScrItm, "WSADD")
		wsActNam(2) = Get_Caption(waScrItm, "WSEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "WSDELETE")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Sub cboCurr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCurr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCurr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboCurr() = True Then
				txtWSExcr.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboCurr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCurr.DropDown
		Dim wsSql As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCurr
		
		wsSql = "SELECT ExcCurr, ExcDesc FROM MstExchangeRate WHERE ExcStatus = '1'"
		wsSql = wsSql & " AND ExcCurr LIKE '%" & IIf(cboCurr.SelectionLength > 0, "", Set_Quote(cboCurr.Text)) & "%' "
		wsSql = wsSql & " GROUP BY ExcCurr, ExcDesc "
		wsSql = wsSql & " ORDER BY ExcCurr "
		Call Ini_Combo(2, wsSql, (VB6.PixelsToTwipsX(cboCurr.Left)), VB6.PixelsToTwipsY(cboCurr.Top) + VB6.PixelsToTwipsY(cboCurr.Height), tblCommon, wsFormID, "TBLCURR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCurr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCurr.Enter
		FocusMe(cboCurr)
	End Sub
	
	Private Sub cboCurr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCurr.Leave
		FocusMe(cboCurr, True)
	End Sub
	
	Private Function Chk_cboWSMethodCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboWSMethodCode = False
		
		If Chk_Method(cboWSMethodCode.Text, wsDesc) = False Then
			gsMsg = "銷售渠道不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWSMethodCode.Focus()
			Exit Function
		End If
		
		Me.lblDspWSMethodDesc.Text = wsDesc
		
		Chk_cboWSMethodCode = True
	End Function
	
	Private Function Chk_cboWSWhsCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboWSWhsCode = False
		
		If Chk_Whs(cboWSWhsCode.Text, wsDesc) = False Then
			gsMsg = "貨倉不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWSWhsCode.Focus()
			Exit Function
		End If
		
		lblDspWSWhsDesc.Text = wsDesc
		
		Chk_cboWSWhsCode = True
	End Function
	
	Private Function chk_cboWsCusCode() As Boolean
		Dim wlID As Integer
		Dim wsName As String
		
		chk_cboWsCusCode = False
		
		If Trim(cboWsCusCode.Text) = "" Then
			gsMsg = "必需輸入客戶編碼!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWsCusCode.Focus()
			Exit Function
		End If
		
		If Chk_CusCode(cboWsCusCode.Text, wlID, wsName, "", "") Then
			wlCusID = wlID
			lblDspWsCusName.Text = wsName
		Else
			wlCusID = 0
			lblDspWsCusName.Text = ""
			gsMsg = "客戶不存在!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWsCusCode.Focus()
			Exit Function
		End If
		
		chk_cboWsCusCode = True
		
	End Function
	
	Private Function chk_cboWsVdrCode() As Boolean
		Dim wlID As Integer
		Dim wsName As String
		
		chk_cboWsVdrCode = False
		
		If Trim(cboWsVdrCode.Text) = "" Then
			gsMsg = "必需輸入供應商編碼!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWsVdrCode.Focus()
			Exit Function
		End If
		
		If Chk_VDRCODE(cboWsVdrCode.Text, wlID, wsName, "", "") Then
			wlVdrID = wlID
			lblDspWsVdrName.Text = wsName
		Else
			wlVdrID = 0
			lblDspWsVdrName.Text = ""
			gsMsg = "供應商不存在!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWsVdrCode.Focus()
			Exit Function
		End If
		
		chk_cboWsVdrCode = True
		
	End Function
	
	Private Function Chk_cboWSSaleCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboWSSaleCode = False
		
		If Trim(cboWsSaleCode.Text) = "" Then
			gsMsg = "必需輸入營業員!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWsSaleCode.Focus()
			Exit Function
		End If
		
		If Chk_Salesman(cboWsSaleCode.Text, wlSaleID, wsDesc) = False Then
			gsMsg = "沒有此營業員!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWsSaleCode.Focus()
			lblDspWsSaleName.Text = ""
			Exit Function
		End If
		
		lblDspWsSaleName.Text = wsDesc
		
		Chk_cboWSSaleCode = True
		
	End Function
End Class