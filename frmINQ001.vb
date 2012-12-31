Option Strict Off
Option Explicit On
Friend Class frmINQ001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	Private wsMark As String
	
	
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wiActFlg As Short
	Private wsTrnCd As String
	
	
	Private Const tcPrint As String = "Print"
	
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	
	Private Const SDOCDATE As Short = 0
	Private Const SDOCNO As Short = 1
	Private Const SCUSCODE As Short = 2
	Private Const SDOCLINE As Short = 3
	Private Const SITMCODE As Short = 4
	Private Const SWHSCODE As Short = 5
	Private Const SUPRICE As Short = 6
	Private Const SQTY As Short = 7
	Private Const SDISPER As Short = 8
	Private Const SAMT As Short = 9
	Private Const SNET As Short = 10
	Private Const SID As Short = 11
	Private Const SDUMMY As Short = 12
	
	
	Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case wsTrnCd
			Case "SO", "IV", "SN"
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND CusStatus <> '2' "
				wsSQL = wsSQL & " AND CusInactive = 'N' "
				wsSQL = wsSQL & " ORDER BY Cuscode "
				
			Case "PO", "PV"
				wsSQL = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND VdrStatus <> '2' "
				wsSQL = wsSQL & " AND VdrInactive = 'N' "
				wsSQL = wsSQL & " ORDER BY Vdrcode "
				
		End Select
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboCusNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboCusNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboCusNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCusNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.Enter
		FocusMe(cboCusNoFr)
		wcCombo = cboCusNoFr
	End Sub
	
	Private Sub cboCusNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusNoFr, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboCusNoFr.Text) <> "" And Trim(cboCusNoTo.Text) = "" Then
				cboCusNoTo.Text = cboCusNoFr.Text
			End If
			cboCusNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub cboCusNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.Leave
		FocusMe(cboCusNoFr, True)
	End Sub
	
	Private Sub cboCusNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Select Case wsTrnCd
			Case "SO", "IV", "SN"
				wsSQL = "SELECT CusCode, CusName FROM mstCustomer WHERE CusCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND CusStatus <> '2' "
				wsSQL = wsSQL & " AND CusInactive = 'N' "
				wsSQL = wsSQL & " ORDER BY Cuscode "
				
			Case "PO", "PV"
				wsSQL = "SELECT VdrCode, VdrName FROM mstVendor WHERE VdrCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND VdrStatus <> '2' "
				wsSQL = wsSQL & " AND VdrInactive = 'N' "
				wsSQL = wsSQL & " ORDER BY Vdrcode "
				
		End Select
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboCusNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboCusNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboCusNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboCusNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Enter
		FocusMe(cboCusNoTo)
		wcCombo = cboCusNoTo
	End Sub
	
	Private Sub cboCusNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusNoTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboCusNoTo = False Then
				GoTo EventExitSub
			End If
			
			cboItemNoFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub cboCusNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Leave
		FocusMe(cboCusNoTo, True)
	End Sub
	
	'''
	Private Sub cboItemNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsSQL = "SELECT ItmCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & " FROM mstItem WHERE ItmCode LIKE '%" & IIf(cboItemNoFr.SelectionLength > 0, "", Set_Quote(cboItemNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmStatus <> '2' "
		wsSQL = wsSQL & " ORDER BY Itmcode "
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItemNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItemNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItemNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItemNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItemNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemNoFr.Enter
		FocusMe(cboItemNoFr)
		wcCombo = cboItemNoFr
	End Sub
	
	Private Sub cboItemNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItemNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItemNoFr, 30, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboItemNoFr.Text) <> "" And Trim(cboItemNoTo.Text) = "" Then
				cboItemNoTo.Text = cboItemNoFr.Text
			End If
			cboItemNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub cboItemNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemNoFr.Leave
		FocusMe(cboItemNoFr, True)
	End Sub
	
	Private Sub cboItemNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemNoTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsSQL = "SELECT ItmCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & " FROM mstItem WHERE ItmCode LIKE '%" & IIf(cboItemNoTo.SelectionLength > 0, "", Set_Quote(cboItemNoTo.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmStatus <> '2' "
		wsSQL = wsSQL & " ORDER BY Itmcode "
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItemNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItemNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItemNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItemNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItemNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemNoTo.Enter
		FocusMe(cboItemNoTo)
		wcCombo = cboItemNoTo
	End Sub
	
	Private Sub cboItemNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItemNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItemNoTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboItemNoTo = False Then
				GoTo EventExitSub
			End If
			
			If LoadRecord = True Then
				tblDetail.Focus()
			End If
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItemNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemNoTo.Leave
		FocusMe(cboItemNoTo, True)
	End Sub
	
	
	'UPGRADE_WARNING: Event frmINQ001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmINQ001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(9000)
			Me.Width = VB6.TwipsToPixelsX(12000)
		End If
	End Sub
	
	
	
	Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoFr
		
		Select Case wsTrnCd
			Case "SN"
				wsSQL = "SELECT SNHDDOCNO, CUSCODE, SNHDDOCDATE "
				wsSQL = wsSQL & " FROM soaSNHD, mstCUSTOMER "
				wsSQL = wsSQL & " WHERE SNHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND SNHDCUSID  = CUSID "
				wsSQL = wsSQL & " AND SNHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY SNHDDOCNO "
			Case "SO"
				wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
				wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
				wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
				wsSQL = wsSQL & " AND SOHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
			Case "IV"
				wsSQL = "SELECT IVHDDOCNO, CUSCODE, IVHDDOCDATE "
				wsSQL = wsSQL & " FROM soaIVHD, mstCUSTOMER "
				wsSQL = wsSQL & " WHERE IVHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND IVHDCUSID  = CUSID "
				wsSQL = wsSQL & " AND IVHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY IVHDDOCNO "
			Case "PO"
				wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
				wsSQL = wsSQL & " FROM popPOHD, mstVENDOR "
				wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
				wsSQL = wsSQL & " AND POHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY POHDDOCNO "
			Case "PV"
				wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
				wsSQL = wsSQL & " FROM popPVHD, mstVENDOR "
				wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
				wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
				wsSQL = wsSQL & " AND PVHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY PVHDDOCNO "
		End Select
		
		
		Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboDocNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboDocNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboDocNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Enter
		FocusMe(cboDocNoFr)
		wcCombo = cboDocNoFr
	End Sub
	
	Private Sub cboDocNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboDocNoFr, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboDocNoFr.Text) <> "" And Trim(cboDocNoTo.Text) = "" Then
				cboDocNoTo.Text = cboDocNoFr.Text
			End If
			cboDocNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboDocNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Leave
		FocusMe(cboDocNoFr, True)
	End Sub
	
	Private Sub cboDocNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoTo
		
		Select Case wsTrnCd
			Case "SN"
				wsSQL = "SELECT SNHDDOCNO, CUSCODE, SNHDDOCDATE "
				wsSQL = wsSQL & " FROM soaSNHD, mstCUSTOMER "
				wsSQL = wsSQL & " WHERE SNHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND SNHDCUSID  = CUSID "
				wsSQL = wsSQL & " AND SNHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY SNHDDOCNO "
			Case "SO"
				wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDDOCDATE "
				wsSQL = wsSQL & " FROM soaSOHD, mstCUSTOMER "
				wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
				wsSQL = wsSQL & " AND SOHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
			Case "IV"
				wsSQL = "SELECT IVHDDOCNO, CUSCODE, IVHDDOCDATE "
				wsSQL = wsSQL & " FROM soaIVHD, mstCUSTOMER "
				wsSQL = wsSQL & " WHERE IVHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND IVHDCUSID  = CUSID "
				wsSQL = wsSQL & " AND IVHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY IVHDDOCNO "
			Case "PO"
				wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
				wsSQL = wsSQL & " FROM popPOHD, mstVENDOR "
				wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
				wsSQL = wsSQL & " AND POHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY POHDDOCNO "
			Case "PV"
				wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
				wsSQL = wsSQL & " FROM popPVHD, mstVENDOR "
				wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
				wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
				wsSQL = wsSQL & " AND PVHDSTATUS = '1' "
				wsSQL = wsSQL & " ORDER BY PVHDDOCNO "
		End Select
		Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboDocNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboDocNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboDocNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Enter
		FocusMe(cboDocNoTo)
		wcCombo = cboDocNoTo
	End Sub
	
	Private Sub cboDocNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboDocNoTo, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboDocNoTo = False Then
				Call cboDocNoTo_Enter(cboDocNoTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			cboCusNoFr.Focus()
			
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
		FocusMe(cboDocNoTo, True)
	End Sub
	Private Function chk_cboDocNoTo() As Boolean
		chk_cboDocNoTo = False
		
		If UCase(cboDocNoFr.Text) > UCase(cboDocNoTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboDocNoTo = True
	End Function
	
	Private Function chk_cboCusNoTo() As Boolean
		chk_cboCusNoTo = False
		
		If UCase(cboCusNoFr.Text) > UCase(cboCusNoTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboCusNoTo.Focus()
			Exit Function
		End If
		
		chk_cboCusNoTo = True
	End Function
	Private Function chk_cboItemNoTo() As Boolean
		chk_cboItemNoTo = False
		
		If UCase(cboItemNoFr.Text) > UCase(cboItemNoTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboItemNoTo.Focus()
			Exit Function
		End If
		
		chk_cboItemNoTo = True
	End Function
	
	
	Private Sub frmINQ001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			
			'      Case vbKeyF3
			
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
				
			Case System.Windows.Forms.Keys.F7
				Call LoadRecord()
				
				
		End Select
	End Sub
	
	
	
	'UPGRADE_WARNING: Event optDocType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optDocType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDocType.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optDocType.GetIndex(eventSender)
			Call cmdRefresh()
		End If
	End Sub
	
	Private Sub optDocType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optDocType.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optDocType.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			Call cmdRefresh()
			tblDetail.Focus()
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub
		
		
		Select Case Button.Name
			
			
			Case tcPrint
				
				
			Case tcCancel
				
				Call cmdCancel()
				
				
			Case tcExit
				Me.Close()
				
			Case tcRefresh
				Call cmdRefresh()
				
				
		End Select
	End Sub
	
	Private Sub frmINQ001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Grid()
		Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	Private Sub cmdCancel()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	
	
	Private Sub cmdRefresh()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		' Ini_Scr
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, SDOCDATE, SID)
		
		
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		For	Each MyControl In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			Select Case TypeName(MyControl)
				'         Case "ComboBox"
				'             MyControl.Clear
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
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		wiExit = False
		wsMark = "0"
		
		
		cboDocNoFr.Text = ""
		cboDocNoTo.Text = ""
		cboCusNoFr.Text = ""
		cboCusNoTo.Text = ""
		cboItemNoFr.Text = ""
		cboItemNoTo.Text = ""
		
		
		
	End Sub
	
	Private Sub frmINQ001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmINQ001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		optDocType(0).Checked = True
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
		lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		lblItemNoFr.Text = Get_Caption(waScrItm, "ITEMNOFR")
		lblItemNoTo.Text = Get_Caption(waScrItm, "ITEMNOTO")
		optDocType(0).Text = Get_Caption(waScrItm, "OPT1")
		optDocType(1).Text = Get_Caption(waScrItm, "OPT2")
		
		
		With tblDetail
			.Columns(SDOCDATE).Caption = Get_Caption(waScrItm, "SDOCDATE")
			.Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
			.Columns(SCUSCODE).Caption = Get_Caption(waScrItm, "SCUSCODE")
			.Columns(SDOCLINE).Caption = Get_Caption(waScrItm, "SDOCLINE")
			.Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SITMCODE")
			.Columns(SWHSCODE).Caption = Get_Caption(waScrItm, "SWHSCODE")
			.Columns(SUPRICE).Caption = Get_Caption(waScrItm, "SUPRICE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SDISPER).Caption = Get_Caption(waScrItm, "SDISPER")
			.Columns(SAMT).Caption = Get_Caption(waScrItm, "SAMT")
			.Columns(SNET).Caption = Get_Caption(waScrItm, "SNET")
			
		End With
		
		
		'tbrProcess.Buttons(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint) & "(F11)"
		
		
		tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F7)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		
		
	End Sub
	
	
	
	
	
	
	
	
	
	
	Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
		
		With tblDetail
			'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
		End With
		
		
		
	End Sub
	
	
	
	
	Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
		
		
		On Error GoTo tblDetail_BeforeColUpdate_Err
		
		If tblCommon.Visible = True Then
			eventArgs.Cancel = False
			'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
			Exit Sub
		End If
		
		
		
		Exit Sub
		
Tbl_BeforeColUpdate_Err: 
		'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True
        Exit Sub

tblDetail_BeforeColUpdate_Err:

        MsgBox("Check tblDeiail BeforeColUpdate!")
        'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True
	End Sub
	
	
	
	Private Sub tblDetail_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent) Handles tblDetail.ButtonClick
		
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case SDOCNO
					
					'    If .Columns(SDOCNO).Text <> "" Then
					
					'       frmINQ0011.InDocID = .Columns(SID).Text
					'       frmINQ0011.InCusNo = .Columns(SCUSCODE).Text
					'       frmINQ0011.Show vbModal
					
					'   End If
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_ButtonClick_Err: 
		MsgBox("Check tblDeiail ButtonClick!")
		
	End Sub
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		Dim wlRet As Short
		Dim wlRow As Integer
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				Case System.Windows.Forms.Keys.F4 ' CALL COMBO BOX
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					Call tblDetail_ButtonClick(tblDetail, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))
					
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						Case SNET
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = SDOCDATE
						Case Else
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
					End Select
					
				Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Col <> SDOCDATE Then
						.Col = .Col - 1
					End If
				Case System.Windows.Forms.Keys.Right
					Select Case .Col
						Case SNET
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = SDOCDATE
						Case Else
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
							
					End Select
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_KeyDown_Err: 
		MsgBox("Check tblDeiail KeyDown")
		
	End Sub
	
	
	
	
	
	
	Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
		wbErr = False
		On Error GoTo RowColChange_Err
		
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If ActiveControl.Name <> tblDetail.Name Then Exit Sub
		
		With tblDetail
			
			
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					
					Case SCUSCODE
						
						lblDspItmDesc.Text = ""
						
						Select Case wsTrnCd
							Case "SO", "IV", "SN"
								lblDspItmDesc.Text = Get_TableInfo("MSTCUSTOMER", "CUSCODE = '" & Set_Quote(.Columns(SCUSCODE).Text) & "'", "CUSNAME")
							Case "PO", "PV"
								lblDspItmDesc.Text = Get_TableInfo("MSTVENDOR", "VDRCODE = '" & Set_Quote(.Columns(SCUSCODE).Text) & "'", "VDRNAME")
						End Select
						
					Case SITMCODE
						lblDspItmDesc.Text = ""
						lblDspItmDesc.Text = Get_TableInfo("MSTITEM", "ITMCODE = '" & Set_Quote(.Columns(SITMCODE).Text) & "'", IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME"))
						
				End Select
			End If
		End With
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
		
		
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
	
	
	Private Sub Ini_Grid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = True
			.MultipleLines = 0
			.AllowAddNew = False
			.AllowUpdate = True
			.AllowDelete = False
			.AlternatingRowStyle = True
			.RecordSelectors = False
			.AllowColMove = False
			.AllowColSelect = False
			
			For wiCtr = SDOCDATE To SDUMMY
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = True
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case SDOCDATE
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Width = 1000
					Case SDOCNO
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Width = 1500
					Case SCUSCODE
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 10
					Case SDOCLINE
						.Columns(wiCtr).DataWidth = 3
						.Columns(wiCtr).Width = 500
					Case SITMCODE
						.Columns(wiCtr).Width = 2500
						.Columns(wiCtr).DataWidth = 50
					Case SWHSCODE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
					Case SUPRICE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsUprFmt
					Case SQTY
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
					Case SAMT
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SNET
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SDISPER
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SDUMMY
						.Columns(wiCtr).Width = 100
						.Columns(wiCtr).DataWidth = 0
					Case SID
						.Columns(wiCtr).Visible = False
						.Columns(wiCtr).DataWidth = 15
				End Select
				
			Next 
			.Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
		End With
		
	End Sub
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		Dim wdOutQty As Double
		Dim wsStatus As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		
		If Opt_Getfocus(optDocType, 2, 0) = 0 Then
			wsStatus = "1"
		Else
			wsStatus = "4"
		End If
		
		Select Case wsTrnCd
			Case "SN"
				wsSQL = "SELECT SNHDDOCID DOCID, SNHDDOCNO DOCNO, SNHDDOCDATE DOCDATE, CUSCODE CCODE, SNDTDOCLINE DOCLINE, ITMCODE, SNDTWHSCODE WHSCODE, "
				wsSQL = wsSQL & " SNDTUPRICE UPRICE, SNDTDISPER DISPER, SNDTTOTQTY QTY, SNDTTOTAMT AMT, SNDTTOTNET NET "
				wsSQL = wsSQL & " FROM  SOASNHD, SOASNDT, MSTCUSTOMER, MSTITEM "
				wsSQL = wsSQL & " WHERE SNHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND ITMCODE BETWEEN '" & cboItemNoFr.Text & "' AND '" & IIf(Trim(cboItemNoTo.Text) = "", New String("z", 13), Set_Quote(cboItemNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SNHDDOCID = SNDTDOCID "
				wsSQL = wsSQL & " AND SNHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SNDTITEMID = ITMID "
				wsSQL = wsSQL & " AND SNHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " ORDER BY SNHDDOCDATE, SNHDDOCNO, SNDTDOCLINE "
			Case "SO"
				wsSQL = "SELECT SOHDDOCID DOCID, SOHDDOCNO DOCNO, SOHDDOCDATE DOCDATE, CUSCODE CCODE, SODTDOCLINE DOCLINE, ITMCODE, SODTWHSCODE WHSCODE, "
				wsSQL = wsSQL & " SODTUPRICE UPRICE, SODTDISPER DISPER, SODTTOTQTY QTY, SODTTOTAMT AMT, SODTTOTNET NET "
				wsSQL = wsSQL & " FROM  SOASOHD, SOASODT, MSTCUSTOMER, MSTITEM "
				wsSQL = wsSQL & " WHERE SOHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND ITMCODE BETWEEN '" & cboItemNoFr.Text & "' AND '" & IIf(Trim(cboItemNoTo.Text) = "", New String("z", 13), Set_Quote(cboItemNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND SOHDDOCID = SODTDOCID "
				wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
				wsSQL = wsSQL & " AND SODTITEMID = ITMID "
				wsSQL = wsSQL & " AND SOHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " ORDER BY SOHDDOCDATE, SOHDDOCNO, SODTDOCLINE "
			Case "IV"
				wsSQL = "SELECT IVHDDOCID DOCID, IVHDDOCNO DOCNO, IVHDDOCDATE DOCDATE, CUSCODE CCODE, IVDTDOCLINE DOCLINE, IVDTDESC1 ITMCODE, IVDTDESC2 WHSCODE, "
				wsSQL = wsSQL & " IVDTUPRICE UPRICE, IVDTDISPER DISPER, IVDTQTY QTY, IVDTAMT AMT, IVDTNET NET "
				wsSQL = wsSQL & " FROM  SOAIVHD, SOAIVDT, MSTCUSTOMER "
				wsSQL = wsSQL & " WHERE IVHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND CUSCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND IVHDDOCID = IVDTDOCID "
				wsSQL = wsSQL & " AND IVHDCUSID = CUSID "
				wsSQL = wsSQL & " AND IVHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " ORDER BY IVHDDOCDATE, IVHDDOCNO, IVDTDOCLINE "
			Case "PO"
				wsSQL = "SELECT POHDDOCID DOCID, POHDDOCNO DOCNO, POHDDOCDATE DOCDATE, VDRCODE CCODE, PODTDOCLINE DOCLINE, ITMCODE, PODTWHSCODE WHSCODE, "
				wsSQL = wsSQL & " PODTUPRICE UPRICE, PODTDISPER DISPER, PODTQTY QTY, PODTAMT AMT, PODTNET NET "
				wsSQL = wsSQL & " FROM  POPPOHD, POPPODT, MSTVENDOR, MSTITEM "
				wsSQL = wsSQL & " WHERE POHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND ITMCODE BETWEEN '" & cboItemNoFr.Text & "' AND '" & IIf(Trim(cboItemNoTo.Text) = "", New String("z", 13), Set_Quote(cboItemNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
				wsSQL = wsSQL & " AND POHDVDRID = VDRID "
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				wsSQL = wsSQL & " AND POHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " ORDER BY POHDDOCDATE, POHDDOCNO, PODTDOCLINE "
			Case "PV"
				wsSQL = "SELECT PVHDDOCID DOCID, PVHDDOCNO DOCNO, PVHDDOCDATE DOCDATE, VDRCODE CCODE, PVDTDOCLINE DOCLINE, ITMCODE, PVDTWHSCODE WHSCODE, "
				wsSQL = wsSQL & " PVDTUPRICE UPRICE, PVDTDISPER DISPER, PVDTQTY QTY, PVDTAMT AMT, PVDTNET NET "
				wsSQL = wsSQL & " FROM  POPPVHD, POPPVDT, MSTVENDOR, MSTITEM "
				wsSQL = wsSQL & " WHERE PVHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboCusNoFr.Text & "' AND '" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND ITMCODE BETWEEN '" & cboItemNoFr.Text & "' AND '" & IIf(Trim(cboItemNoTo.Text) = "", New String("z", 13), Set_Quote(cboItemNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND PVHDDOCID = PVDTDOCID "
				wsSQL = wsSQL & " AND PVHDVDRID = VDRID "
				wsSQL = wsSQL & " AND PVDTITEMID = ITMID "
				wsSQL = wsSQL & " AND PVHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " ORDER BY PVHDDOCDATE, PVHDDOCNO, PVDTDOCLINE "
				
				
		End Select
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			waResult.ReDim(0, -1, SDOCDATE, SID)
			tblDetail.ReBind()
			tblDetail.Bookmark = 0
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmINQ001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
			Exit Function
		End If
		
		
		
		With waResult
			.ReDim(0, -1, SDOCDATE, SID)
			rsRcd.MoveFirst()
			Do Until rsRcd.EOF
				
				
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SDOCDATE) = ReadRs(rsRcd, "DOCDATE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "DOCNO")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SCUSCODE) = ReadRs(rsRcd, "CCODE")
				waResult.get_Value(.get_UpperBound(1), SDOCLINE) = VB6.Format(To_Value(ReadRs(rsRcd, "DOCLINE")), "000")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SITMCODE) = ReadRs(rsRcd, "ITMCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SWHSCODE) = ReadRs(rsRcd, "WHSCODE")
				waResult.get_Value(.get_UpperBound(1), SUPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "UPRICE")), gsUprFmt)
				waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
				waResult.get_Value(.get_UpperBound(1), SDISPER) = VB6.Format(To_Value(ReadRs(rsRcd, "DISPER")), gsQtyFmt)
				waResult.get_Value(.get_UpperBound(1), SAMT) = VB6.Format(To_Value(ReadRs(rsRcd, "AMT")), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), SNET) = VB6.Format(To_Value(ReadRs(rsRcd, "NET")), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "DOCID")
				rsRcd.MoveNext()
			Loop 
		End With
		
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		
		Call Calc_Total()
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadRecord = True
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmINQ001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
	End Function
	
	
	Private Function Calc_Total(Optional ByVal LastRow As Object = Nothing) As Boolean
		
		Dim wiTotalGrs As Double
		Dim wiTotalNet As Double
		Dim wiTotalQty As Double
		
		Dim wiRowCtr As Short
		
		
		Calc_Total = False
		
		For wiRowCtr = 0 To waResult.get_UpperBound(1)
			wiTotalGrs = wiTotalGrs + To_Value(waResult.get_Value(wiRowCtr, SAMT))
			wiTotalNet = wiTotalNet + To_Value(waResult.get_Value(wiRowCtr, SNET))
			wiTotalQty = wiTotalQty + To_Value(waResult.get_Value(wiRowCtr, SQTY))
		Next 
		
		lblDspGrsAmtOrg.Text = VB6.Format(CStr(wiTotalGrs), gsAmtFmt)
		lblDspNetAmtOrg.Text = VB6.Format(CStr(wiTotalNet), gsAmtFmt)
		lblDspTotalQty.Text = VB6.Format(CStr(wiTotalQty), gsQtyFmt)
		
		Calc_Total = True
		
	End Function
	Public WriteOnly Property FormID() As String
		Set(ByVal Value As String)
			wsFormID = Value
		End Set
	End Property
	Public WriteOnly Property TrnCd() As String
		Set(ByVal Value As String)
			wsTrnCd = Value
		End Set
	End Property
End Class