Option Strict Off
Option Explicit On
Friend Class frmINQ013
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wiActFlg As Short
	Private wsDteTim As String
	
	Private Const tcPrint As String = "Print"
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private Const SITMCODE As Short = 0
	Private Const SITMNAME As Short = 1
	Private Const SITMTYPE As Short = 2
	Private Const SWHSCODE As Short = 3
	Private Const SLOTNO As Short = 4
	Private Const SSTKQTY As Short = 5
	Private Const SAMTL As Short = 6
	Private Const SID As Short = 7
	Private Const SDUMMY As Short = 8
	
	
	
	
	Private Sub cboItmAccTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsSQL = "SELECT ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " "
		wsSQL = wsSQL & " FROM mstItem "
		wsSQL = wsSQL & " WHERE ItmBarCode LIKE '%" & IIf(cboItmAccTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboItmAccTypeCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " AND ITMSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmBarCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmAccTypeCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmAccTypeCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmAccTypeCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmAccTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmAccTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCodeFr.Enter
		FocusMe(cboItmAccTypeCodeFr)
		wcCombo = cboItmAccTypeCodeFr
	End Sub
	
	Private Sub cboItmAccTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmAccTypeCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmAccTypeCodeFr, 13, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(cboItmAccTypeCodeFr.Text) <> "" And Trim(cboItmAccTypeCodeTo.Text) = "" Then
				cboItmAccTypeCodeTo.Text = cboItmAccTypeCodeFr.Text
			End If
			cboItmAccTypeCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub cboItmAccTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCodeFr.Leave
		FocusMe(cboItmAccTypeCodeFr, True)
	End Sub
	
	Private Sub cboItmAccTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsSQL = "SELECT ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " "
		wsSQL = wsSQL & " FROM mstItem "
		wsSQL = wsSQL & " WHERE ItmBarCode LIKE '%" & IIf(cboItmAccTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboItmAccTypeCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " AND ITMSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmBarCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmAccTypeCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmAccTypeCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmAccTypeCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmAccTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmAccTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCodeTo.Enter
		FocusMe(cboItmAccTypeCodeTo)
		wcCombo = cboItmAccTypeCodeTo
	End Sub
	
	Private Sub cboItmAccTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmAccTypeCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmAccTypeCodeTo, 13, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboItmAccTypeCodeTo = False Then
				GoTo EventExitSub
			End If
			
			cboItmTypeCodeFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub cboItmAccTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCodeTo.Leave
		FocusMe(cboItmAccTypeCodeTo, True)
	End Sub
	
	
	
	
	
	'UPGRADE_WARNING: Event frmINQ013.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmINQ013_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(9000)
			Me.Width = VB6.TwipsToPixelsX(12000)
		End If
	End Sub
	
	
	
	Private Sub cboItmCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmCodeFr
		
		wsSQL = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " "
		wsSQL = wsSQL & " FROM mstItem "
		wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboItmCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Enter
		FocusMe(cboItmCodeFr)
		wcCombo = cboItmCodeFr
	End Sub
	
	Private Sub cboItmCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmCodeFr, 30, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboItmCodeFr.Text) <> "" And Trim(cboItmCodeTo.Text) = "" Then
				cboItmCodeTo.Text = cboItmCodeFr.Text
			End If
			cboItmCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Leave
		FocusMe(cboItmCodeFr, True)
	End Sub
	
	Private Sub cboItmCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmCodeTo
		
		wsSQL = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " "
		wsSQL = wsSQL & " FROM mstItem "
		wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboItmCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Enter
		FocusMe(cboItmCodeTo)
		wcCombo = cboItmCodeTo
	End Sub
	
	Private Sub cboItmCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmCodeTo, 30, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboItmCodeTo = False Then
				Call cboItmCodeTo_Enter(cboItmCodeTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			cboItmAccTypeCodeFr.Focus()
			
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Leave
		FocusMe(cboItmCodeTo, True)
	End Sub
	Private Function chk_cboItmCodeTo() As Boolean
		chk_cboItmCodeTo = False
		
		If UCase(cboItmCodeFr.Text) > UCase(cboItmCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboItmCodeTo = True
	End Function
	
	Private Function chk_cboItmAccTypeCodeTo() As Boolean
		chk_cboItmAccTypeCodeTo = False
		
		If UCase(cboItmAccTypeCodeFr.Text) > UCase(cboItmAccTypeCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboItmAccTypeCodeTo.Focus()
			Exit Function
		End If
		
		chk_cboItmAccTypeCodeTo = True
	End Function
	
	
	
	Private Sub cboItmTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmTypeCodeFr
		
		wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ItmTypeEngDesc", "ItmTypeChiDesc") & " FROM MstItemType "
		wsSQL = wsSQL & " WHERE ItmTypeStatus = '1'"
		wsSQL = wsSQL & " AND ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY ItmTypeCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmTypeCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmTypeCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmTypeCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Enter
		FocusMe(cboItmTypeCodeFr)
		wcCombo = cboItmTypeCodeFr
	End Sub
	
	Private Sub cboItmTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmTypeCodeFr, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboItmTypeCodeFr.Text) <> "" And Trim(cboItmTypeCodeTo.Text) = "" Then
				cboItmTypeCodeTo.Text = cboItmTypeCodeFr.Text
			End If
			cboItmTypeCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Leave
		FocusMe(cboItmTypeCodeFr, True)
	End Sub
	
	Private Sub cboItmTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmTypeCodeTo
		
		wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", "ItmTypeEngDesc", "ItmTypeChiDesc") & " FROM MstItemType "
		wsSQL = wsSQL & " WHERE ItmTypeStatus = '1'"
		wsSQL = wsSQL & " AND ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY ItmTypeCode "
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmTypeCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmTypeCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmTypeCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Enter
		FocusMe(cboItmTypeCodeTo)
		wcCombo = cboItmTypeCodeTo
	End Sub
	
	Private Sub cboItmTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmTypeCodeTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboItmTypeCodeTo = False Then
				Call cboItmTypeCodeTo_Enter(cboItmTypeCodeTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			cboWhsCodeFr.Focus()
			
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Leave
		FocusMe(cboItmTypeCodeTo, True)
	End Sub
	Private Function chk_cboItmTypeCodeTo() As Boolean
		chk_cboItmTypeCodeTo = False
		
		If UCase(cboItmTypeCodeFr.Text) > UCase(cboItmTypeCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboItmTypeCodeTo = True
	End Function
	
	
	Private Sub frmINQ013_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
				
			Case System.Windows.Forms.Keys.F7
				Call LoadRecord()
				
				
		End Select
	End Sub
	
	Private Sub frmINQ013_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, SITMCODE, SID)
		
		
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
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
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		wiExit = False
		
		
		
		cboItmCodeFr.Text = ""
		cboItmCodeTo.Text = ""
		cboItmAccTypeCodeFr.Text = ""
		cboItmAccTypeCodeTo.Text = ""
		cboItmTypeCodeFr.Text = ""
		cboItmTypeCodeTo.Text = ""
		cboWhsCodeFr.Text = ""
		cboWhsCodeTo.Text = ""
		
	End Sub
	
	Private Sub frmINQ013_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		cnCon.Execute("DELETE FROM RPTINQ013 WHERE RPTUSRID = '" & gsUserID & "' AND RPTDTETIM = '" & wsDteTim & "' ")
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmINQ013 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
		
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "INQ013"
		
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblItmCodeFr.Text = Get_Caption(waScrItm, "ItmCodeFR")
		lblItmCodeTo.Text = Get_Caption(waScrItm, "ItmCodeTO")
		lblItmAccTypeCodeFr.Text = Get_Caption(waScrItm, "ItmAccTypeCodeFR")
		lblItmAccTypeCodeTo.Text = Get_Caption(waScrItm, "ItmAccTypeCodeTO")
		lblItmTypeCodeFr.Text = Get_Caption(waScrItm, "ItmTypeCodeFR")
		lblItmTypeCodeTo.Text = Get_Caption(waScrItm, "ItmTypeCodeTO")
		lblWhsCodeFr.Text = Get_Caption(waScrItm, "WhsCodeFr")
		lblWhsCodeTo.Text = Get_Caption(waScrItm, "WhsCodeTO")
		
		
		
		
		
		With tblDetail
			.Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SITMCODE")
			.Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SITMNAME")
			.Columns(SWHSCODE).Caption = Get_Caption(waScrItm, "SWHSCODE")
			.Columns(SITMTYPE).Caption = Get_Caption(waScrItm, "SITMTYPE")
			.Columns(SLOTNO).Caption = Get_Caption(waScrItm, "SLOTNO")
			.Columns(SSTKQTY).Caption = Get_Caption(waScrItm, "SSTKQTY")
			.Columns(SAMTL).Caption = Get_Caption(waScrItm, "SAMTL")
		End With
		
		
		
		
		'    tbrProcess.Buttons(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint) & "(F11)"
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
	
	
	
	
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		Dim wlRet As Short
		Dim wlRow As Integer
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				
				
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						Case SAMTL
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = SITMCODE
						Case Else
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
					End Select
				Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Col <> SITMCODE Then
						.Col = .Col - 1
					End If
				Case System.Windows.Forms.Keys.Right
					Select Case .Col
						Case SAMTL
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = SITMCODE
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
		
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
		
		
	End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		Select Case Button.Name
			
			Case tcPrint
				
				Call cmdPrint()
				
			Case tcCancel
				
				Call cmdCancel()
				
				
			Case tcExit
				Me.Close()
				
			Case tcRefresh
				Call LoadRecord()
				
		End Select
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
			
			For wiCtr = SITMCODE To SDUMMY
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = True
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case SITMCODE
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Width = 2000
					Case SITMNAME
						.Columns(wiCtr).Width = 4000
						.Columns(wiCtr).DataWidth = 60
					Case SWHSCODE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
					Case SITMTYPE
						.Columns(wiCtr).Width = 1200
						.Columns(wiCtr).DataWidth = 10
					Case SLOTNO
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 20
					Case SSTKQTY
						.Columns(wiCtr).Width = 1200
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
					Case SAMTL
						.Columns(wiCtr).Width = 1200
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
		Dim wdStkQty As Double
		Dim wsMth As String
		Dim wdRdrQty As Double
		
		wsMth = Mid(gsSystemDate, 6, 2)
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		
		wsDteTim = Change_SQLDate(CStr(Now))
		
		Call cmdSave()
		
		wsSQL = "SELECT RPTITMID, RPTITMCODE, RPTITMNAME, RPTUPRICE, RPTITMTYPECODE, RPTWHSCODE, RPTLOCCODE, RPTSTKQTY, RPTAMTL "
		wsSQL = wsSQL & " From RPTINQ013 "
		wsSQL = wsSQL & " WHERE RPTUSRID = '" & gsUserID & "' "
		wsSQL = wsSQL & " AND RPTDTETIM = '" & wsDteTim & "' "
		wsSQL = wsSQL & " ORDER BY RPTITMCODE "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			waResult.ReDim(0, -1, SITMCODE, SID)
			tblDetail.ReBind()
			tblDetail.Bookmark = 0
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmINQ013.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
			Exit Function
		End If
		
		
		
		With waResult
			.ReDim(0, -1, SITMCODE, SID)
			rsRcd.MoveFirst()
			Do Until rsRcd.EOF
				
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SITMCODE) = ReadRs(rsRcd, "RPTITMCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SITMNAME) = ReadRs(rsRcd, "RPTITMNAME")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SITMTYPE) = ReadRs(rsRcd, "RPTITMTYPECODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SWHSCODE) = ReadRs(rsRcd, "RPTWHSCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SLOTNO) = ReadRs(rsRcd, "RPTLOCCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SSTKQTY) = VB6.Format(ReadRs(rsRcd, "RPTSTKQTY"), gsQtyFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SAMTL) = VB6.Format(ReadRs(rsRcd, "RPTAMTL"), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "RPTITMID")
				
				'End If
				
				
				rsRcd.MoveNext()
			Loop 
		End With
		
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadRecord = True
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmINQ013.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
	End Function
	
	Private Sub cmdPrint()
		
		
	End Sub
	Private Sub cboWhsCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWhsCodeFr
		
		wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
		wsSQL = wsSQL & " WHERE WhsStatus = '1'"
		wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeFr.SelectionLength > 0, "", Set_Quote(cboWhsCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY WhsCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboWhsCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboWhsCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboWhsCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboWhsCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Enter
		FocusMe(cboWhsCodeFr)
		wcCombo = cboWhsCodeFr
	End Sub
	
	Private Sub cboWhsCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWhsCodeFr, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Trim(cboWhsCodeFr.Text) <> "" And Trim(cboWhsCodeTo.Text) = "" Then
				cboWhsCodeTo.Text = cboWhsCodeFr.Text
			End If
			cboWhsCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWhsCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Leave
		FocusMe(cboWhsCodeFr, True)
	End Sub
	
	Private Sub cboWhsCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWhsCodeTo
		
		wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
		wsSQL = wsSQL & " WHERE WhsStatus = '1'"
		wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeTo.SelectionLength > 0, "", Set_Quote(cboWhsCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY WhsCode "
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboWhsCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboWhsCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboWhsCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboWhsCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.Enter
		FocusMe(cboWhsCodeTo)
		wcCombo = cboWhsCodeTo
	End Sub
	
	Private Sub cboWhsCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWhsCodeTo, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboWhsCodeTo = False Then
				Call cboWhsCodeTo_Enter(cboWhsCodeTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			If LoadRecord Then
				tblDetail.Focus()
			End If
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWhsCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.Leave
		FocusMe(cboWhsCodeTo, True)
	End Sub
	Private Function chk_cboWhsCodeTo() As Boolean
		chk_cboWhsCodeTo = False
		
		If UCase(cboWhsCodeFr.Text) > UCase(cboWhsCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboWhsCodeTo = True
	End Function
	
	
	
	
	Private Sub cmdSave()
		Dim adcmdSave As New ADODB.Command
		
		
		On Error GoTo cmdSave_Err
		
		'MousePointer = vbHourglass
		
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		
		adcmdSave.CommandText = "USP_RPTINQ013"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, gsUserID)
		Call SetSPPara(adcmdSave, 2, wsDteTim)
		Call SetSPPara(adcmdSave, 3, cboItmCodeFr)
		Call SetSPPara(adcmdSave, 4, cboItmCodeTo)
		Call SetSPPara(adcmdSave, 5, cboItmAccTypeCodeFr)
		Call SetSPPara(adcmdSave, 6, cboItmAccTypeCodeTo)
		Call SetSPPara(adcmdSave, 7, cboItmTypeCodeFr)
		Call SetSPPara(adcmdSave, 8, cboItmTypeCodeTo)
		Call SetSPPara(adcmdSave, 9, cboWhsCodeFr)
		Call SetSPPara(adcmdSave, 10, cboWhsCodeTo)
		Call SetSPPara(adcmdSave, 11, gsLangID)
		
		adcmdSave.Execute()
		
		cnCon.CommitTrans()
		
		
		
		'Call UnLockAll(wsConnTime, wsFormID)
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		
		'  MousePointer = vbDefault
		
		Exit Sub
		
cmdSave_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
	End Sub
End Class