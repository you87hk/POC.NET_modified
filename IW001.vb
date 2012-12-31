Option Strict Off
Option Explicit On
Friend Class frmIW001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	
	Private wcCombo As System.Windows.Forms.Control
	
	
	Private Const GITMCODE As Short = 0
	Private Const GWHSCODE As Short = 1
	Private Const GITEMNAME As Short = 2
	Private Const GLOTNO As Short = 3
	Private Const GLEAD As Short = 4
	Private Const GAVGCOST As Short = 5
	Private Const GPOCOST As Short = 6
	Private Const GLPRICE As Short = 7
	Private Const GITMID As Short = 8
	Private Const GDummy As Short = 9
	
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	
	Private wiOpenDoc As Short
	Private wiAction As Short
	Private wlItmID As Integer
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "mstWhsItem"
	Private wsFormID As String
	Private wsUsrId As String
	
	
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	Private wsITMCODE As String
	Private wsRcd As String
	Private wsKeyIn As String
	
	Private Sub Ini_Scr()
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, GITMCODE, GITMID)
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		
		wiAction = DefaultPage
		
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
		
		Call SetButtonStatus("AfrActEdit")
		Call SetFieldStatus("Default")
		Call SetFieldStatus("AfrActEdit")
		
		wlKey = 0
		wlItmID = 0
		
		tblCommon.Visible = False
		
		Me.Text = wsFormCaption
		
		FocusMe(cboITMCODE)
		
	End Sub
	
	Private Function Chk_cboItmCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboItmCode = False
		
		If Trim(cboITMCODE.Text) = "" Then
			Chk_cboItmCode = True
			Exit Function
		End If
		
		If Chk_ItmCode(cboITMCODE.Text, wsStatus) = True Then
			
			If wsStatus = "2" Then
				gsMsg = "物料已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				cboITMCODE.Focus()
				Exit Function
			End If
		Else
			gsMsg = "物料不存在!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboITMCODE.Focus()
			Exit Function
		End If
		
		Chk_cboItmCode = True
	End Function
	
	Private Function Chk_cboWhsCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboWhsCode = False
		
		If Trim(cboWhsCode.Text) = "" Then
			Chk_cboWhsCode = True
			Exit Function
		End If
		
		If Chk_WhsCode(cboWhsCode.Text) = False Then
			
			gsMsg = "倉庫不存在!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboWhsCode.Focus()
			Exit Function
		End If
		
		Chk_cboWhsCode = True
	End Function
	Private Function Chk_WhsCode(ByVal inCode As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT WhsDesc FROM mstWarehouse WHERE WhsCode = '" & Set_Quote(inCode) & "' "
		wsSQL = wsSQL & "And WhsStatus = '1' "
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			Chk_WhsCode = True
		Else
			Chk_WhsCode = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
	
	
	Private Function Chk_KeyFld() As Boolean
		
		Chk_KeyFld = False
		
		If Trim(cboITMCODE.Text) = "" And Trim(cboWhsCode.Text) = "" Then
			Exit Function
		End If
		
		
		If Trim(cboITMCODE.Text) <> "" Then
			If Chk_cboItmCode = False Then Exit Function
			wsKeyIn = "1"
			wsRcd = cboITMCODE.Text
		End If
		
		If Trim(cboWhsCode.Text) <> "" Then
			If Chk_cboWhsCode = False Then Exit Function
			wsKeyIn = "2"
			wsRcd = cboWhsCode.Text
		End If
		
		
		If Trim(cboITMCODE.Text) <> "" And Trim(cboWhsCode.Text) <> "" Then
			wsKeyIn = "3"
			wsRcd = cboITMCODE.Text & cboWhsCode.Text
		End If
		
		
		Chk_KeyFld = True
	End Function
	
	Private Sub Ini_Scr_AfrKey()
		Call LoadRecord()
		
		wiAction = CorRec
		If RowLock(wsConnTime, wsKeyType, wsRcd, wsFormID, wsUsrId) = False Then
			gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tblDetail.ReBind()
		End If
		
		Call SetButtonStatus("AfrKeyEdit")
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		Call SetFieldStatus("AfrKey")
		
		If tblDetail.Enabled = True Then
			
			tblDetail.Focus()
		End If
		
	End Sub
	
	Private Sub cboItmCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboITMCODE
		
		wsSQL = "SELECT ItmCode, ItmBarCode, ItmChiName "
		wsSQL = wsSQL & " FROM MstItem "
		wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboITMCODE.SelectionLength > 0, "", Set_Quote(cboITMCODE.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmStatus <> '2' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboITMCODE.Left)), VB6.PixelsToTwipsY(cboITMCODE.Top) + VB6.PixelsToTwipsY(cboITMCODE.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Enter
		FocusMe(cboITMCODE)
	End Sub
	
	Private Sub cboItmCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboITMCODE, 13, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			
			If Chk_cboItmCode() = False Then GoTo EventExitSub
			
			cboWhsCode.Focus()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Leave
		FocusMe(cboITMCODE, True)
	End Sub
	Private Sub cboWhsCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWhsCode
		
		wsSQL = "SELECT WhsCode, WhsDesc "
		wsSQL = wsSQL & " FROM MstWarehouse "
		wsSQL = wsSQL & " WHERE WhsCode LIKE '%" & IIf(cboWhsCode.SelectionLength > 0, "", Set_Quote(cboWhsCode.Text)) & "%' "
		wsSQL = wsSQL & " AND WhsStatus <> '2' "
		wsSQL = wsSQL & " ORDER BY WhsCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboWhsCode.Left)), VB6.PixelsToTwipsY(cboWhsCode.Top) + VB6.PixelsToTwipsY(cboWhsCode.Height), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWhsCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCode.Enter
		FocusMe(cboWhsCode)
	End Sub
	
	Private Sub cboWhsCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWhsCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			
			If Chk_cboWhsCode() = False Then GoTo EventExitSub
			
			If Chk_KeyFld = False Then GoTo EventExitSub
			
			Call Ini_Scr_AfrKey()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWhsCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCode.Leave
		FocusMe(cboWhsCode, True)
	End Sub
	'UPGRADE_WARNING: Form event frmIW001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmIW001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboITMCODE
		End If
	End Sub
	
	Private Sub frmIW001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			
			
			Case System.Windows.Forms.Keys.F6
				Call cmdOpen()
				
				
				'Case vbKeyF2
				'    If wiAction = DefaultPage Then Call cmdNew
				
				
				'Case vbKeyF5
				'    If wiAction = DefaultPage Then Call cmdEdit
				
				
				'Case vbKeyF3
				'    If wiAction = DefaultPage Then Call cmdDel
				
				'Case vbKeyF9
				
				'    If tbrProcess.Buttons(tcFind).Enabled = True Then Call cmdFind
				
			Case System.Windows.Forms.Keys.F10
				
				If tbrProcess.Items.Item(tcSave).Enabled = True Then Call cmdSave()
				
			Case System.Windows.Forms.Keys.F11
				
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub frmIW001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Grid()
		Call Ini_Caption()
		Call Ini_Scr()
		Call Ini_Data()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		
		LoadRecord = False
		
		If gsLangID = "1" Then
			
			wsSQL = "SELECT ItmID, ItmEngName ItmName "
			wsSQL = wsSQL & "FROM MstItem "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND ItmCode='" & Set_Quote(cboITMCODE.Text) & "' "
		Else
			wsSQL = "SELECT ItmID, ItmChiName ItmName "
			wsSQL = wsSQL & "FROM MstItem "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND ItmCode='" & Set_Quote(cboITMCODE.Text) & "' "
			
		End If
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			lblDspItmName.Text = ""
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlItmID = ReadRs(rsRcd, "ItmID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspItmName.Text = ReadRs(rsRcd, "ItmName")
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		Call LoadGridRecord()
		
		LoadRecord = True
		
	End Function
	
	Private Function LoadGridRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		
		LoadGridRecord = False
		
		wsSQL = "SELECT WhsItemItmID, ItmCode, ItmChiName, WhsItemWhsCode, WhsItemBinNo, "
		wsSQL = wsSQL & "WhsItemAveCost, WhsItemLPOCost,WhsItemLPrice "
		wsSQL = wsSQL & "FROM MstItem, mstWhsItem "
		wsSQL = wsSQL & "WHERE ItmStatus =  '1' "
		wsSQL = wsSQL & "AND WhsItemStatus = '1' "
		wsSQL = wsSQL & "AND WhsItemItmID = ItmID "
		If wlItmID > 0 Then
			wsSQL = wsSQL & "AND WhsItemItmID = " & wlItmID & " "
		End If
		If Trim(cboWhsCode.Text) <> "" Then
			wsSQL = wsSQL & "AND WhsItemWhsCode = '" & Set_Quote(cboWhsCode.Text) & "' "
		End If
		wsSQL = wsSQL & "ORDER BY ItmCode "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		rsRcd.MoveFirst()
		With waResult
			.ReDim(0, -1, GITMCODE, GITMID)
			Do While Not rsRcd.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GITMCODE) = ReadRs(rsRcd, "ItmCode")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GITEMNAME) = ReadRs(rsRcd, "ItmChiName")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GWHSCODE) = ReadRs(rsRcd, "WhsItemWhsCode")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GLOTNO) = ReadRs(rsRcd, "WhsItemBinNo")
				waResult.get_Value(.get_UpperBound(1), GLEAD) = VB6.Format(To_Value(ReadRs(rsRcd, "WhsItemLead")), gsQtyFmt)
				waResult.get_Value(.get_UpperBound(1), GAVGCOST) = VB6.Format(To_Value(ReadRs(rsRcd, "WhsItemAveCost")), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), GPOCOST) = VB6.Format(To_Value(ReadRs(rsRcd, "WhsItemLPOCost")), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), GLPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "WhsItemLPrice")), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), GITMID) = To_Value(ReadRs(rsRcd, "WhsItemItmID"))
				rsRcd.MoveNext()
			Loop 
		End With
		
		tblDetail.ReBind()
		tblDetail.FirstRow = 0
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		LoadGridRecord = True
		
		
	End Function
	
	
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblItmCode.Text = Get_Caption(waScrItm, "ITMCODE")
		lblItemChiName.Text = Get_Caption(waScrItm, "ITEMNAME")
		lblWhsCode.Text = Get_Caption(waScrItm, "WHSCODE")
		
		With tblDetail
			.Columns(GITMCODE).Caption = Get_Caption(waScrItm, "GITMCODE")
			.Columns(GWHSCODE).Caption = Get_Caption(waScrItm, "GWHSCODE")
			.Columns(GITEMNAME).Caption = Get_Caption(waScrItm, "GITEMNAME")
			.Columns(GLOTNO).Caption = Get_Caption(waScrItm, "GLOTNO")
			.Columns(GLEAD).Caption = Get_Caption(waScrItm, "GLEAD")
			.Columns(GAVGCOST).Caption = Get_Caption(waScrItm, "GAVGCOST")
			.Columns(GPOCOST).Caption = Get_Caption(waScrItm, "GLPOCOST")
			.Columns(GLPRICE).Caption = Get_Caption(waScrItm, "GLPRICE")
			
		End With
		
		
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "IWADD")
		wsActNam(2) = Get_Caption(waScrItm, "IWEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "IWDELETE")
		
		Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	'UPGRADE_WARNING: Event frmIW001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmIW001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(7305)
			Me.Width = VB6.TwipsToPixelsX(9915)
		End If
	End Sub
	
	Private Sub frmIW001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        'UPGRADE_NOTE: Object frmIW001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub


    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        If wcCombo.Name = tblDetail.Name Then
            tblDetail.EditActive = True
            wcCombo.Text = tblCommon.Columns(0).Text
        Else
            wcCombo.Text = tblCommon.Columns(0).Text
        End If

        tblCommon.Visible = False
        wcCombo.Focus()
        System.Windows.Forms.SendKeys.Send("{Enter}")

    End Sub

    Private Sub tblCommon_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCommon.KeyDownEvent

        If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
            tblCommon.Visible = False
            wcCombo.Focus()
        ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
            If wcCombo.Name = tblDetail.Name Then
                tblDetail.EditActive = True
                wcCombo.Text = tblCommon.Columns(0).Text
            Else
                wcCombo.Text = tblCommon.Columns(0).Text
            End If
            tblCommon.Visible = False
            wcCombo.Focus()
            System.Windows.Forms.SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub tblCommon_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.Leave

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub

    Private Function cmdSave() As Boolean
        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wlRowCtr As Integer
        Dim wsCtlPrd As String
        Dim wsSts As String
        Dim bResult As Boolean
        Dim i As Short

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, wsRcd, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If

        wlRowCtr = waResult.get_UpperBound(1)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_IW001"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, GITMCODE)) <> "" And Trim(waResult.get_Value(wiCtr, GWHSCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wsKeyIn)
                    Call SetSPPara(adcmdSave, 2, waResult.get_Value(wiCtr, GITMID))
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, GWHSCODE))
                    Call SetSPPara(adcmdSave, 4, waResult.get_Value(wiCtr, GLOTNO))
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, GLEAD))
                    Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, GAVGCOST))
                    Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, GPOCOST))
                    Call SetSPPara(adcmdSave, 8, waResult.get_Value(wiCtr, GLPRICE))
                    Call SetSPPara(adcmdSave, 9, wiCtr)
                    Call SetSPPara(adcmdSave, 10, gsUserID)
                    Call SetSPPara(adcmdSave, 11, wsGenDte)

                    adcmdSave.Execute()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wlKey = GetSPPara(adcmdSave, 12)
                End If
            Next
        End If
        cnCon.CommitTrans()


        If wiAction = CorRec And CDbl(Trim(CStr(wlKey))) <> 0 Then
            gsMsg = "已儲存!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        Else
            gsMsg = "儲存失敗!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
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

    Private Function InputValidation() As Boolean
        Dim wsExcRate As String
        Dim wsExcDesc As String


        InputValidation = False

        On Error GoTo InputValidation_Err



        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, GITMCODE)) <> "" And Trim(waResult.get_Value(wlCtr, GWHSCODE)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If
                End If
            Next
        End With

        If wiEmptyGrid = True Then
            gsMsg = "沒有設定倉庫物料價!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tblDetail.Focus()
            End If
            Exit Function
        End If


        If Chk_NoDup(To_Value((tblDetail.Bookmark))) = False Then
            tblDetail.FirstRow = tblDetail.Row
            tblDetail.Col = GITMCODE
            tblDetail.Focus()
            Exit Function
        End If




        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function

    Private Sub cmdNew()

        Dim newForm As New frmIW001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()
    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmIW001

        newForm.OpenDoc = True
        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
        newForm.Show()

    End Sub

    Private Sub Ini_Form()

        Me.KeyPreview = True
        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "IW001"

    End Sub

    Private Sub cmdCancel()
        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("AfrActEdit")
        Call SetButtonStatus("AfrActEdit")

        cboITMCODE.Focus()
    End Sub

    Private Sub cmdFind()
        ' Call OpenPromptForm
    End Sub

    Public WriteOnly Property ITMCODE() As String
        Set(ByVal Value As String)
            wsITMCODE = Value
        End Set
    End Property


    Public Property OpenDoc() As Short
        Get
            OpenDoc = wiOpenDoc
        End Get
        Set(ByVal Value As Short)
            wiOpenDoc = Value
        End Set
    End Property


    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            If Chk_GrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub




    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmIW001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case tcOpen
                Call cmdOpen()
            Case tcAdd
                Call cmdNew()
                '    Case tcEdit
                '       Call cmdEdit
                'Case tcDelete
                '    Call cmdDel
            Case tcSave
                Call cmdSave()
            Case tcCancel
                If tbrProcess.Items.Item(tcSave).Enabled = True Then
                    If MsgBox("Are you sure to cancel this operation?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
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

    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            '    .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = GITMCODE To GDummy
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case GITMCODE
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 13

                    Case GWHSCODE
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case GITEMNAME
                        .Columns(wiCtr).Width = 2400
                        .Columns(wiCtr).DataWidth = 60
                        .Columns(wiCtr).Locked = True

                    Case GLOTNO
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 20


                    Case GLEAD
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsQtyFmt
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight

                    Case GAVGCOST
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt

                    Case GPOCOST
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt

                    Case GLPRICE
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt

                    Case GITMID
                        .Columns(wiCtr).Width = 0
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False

                    Case GDummy
                        .Columns(wiCtr).Width = 10
                        .Columns(wiCtr).DataWidth = 0
                        .Columns(wiCtr).Locked = False

                End Select
            Next
            '   .Styles("EvenRow").BackColor = &H8000000F
        End With

    End Sub


    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate

        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub


    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wlItmID As Integer
        Dim wsItemName As String

        On Error GoTo tblDetail_BeforeColUpdate_Err


        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case GITMCODE
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdITMCODE((.Columns(eventArgs.ColIndex).Text), wlItmID, wsItemName) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(GITEMNAME).Text = wsItemName
                    .Columns(GLOTNO).Text = ""
                    .Columns(GLEAD).Text = VB6.Format("0", gsQtyFmt)
                    .Columns(GAVGCOST).Text = VB6.Format("0", gsAmtFmt)
                    .Columns(GPOCOST).Text = VB6.Format("0", gsAmtFmt)
                    .Columns(GLPRICE).Text = VB6.Format("0", gsAmtFmt)
                    .Columns(GITMID).Text = CStr(wlItmID)

                Case GWHSCODE
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdWhsCode((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

            End Select
        End With

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
        Dim wsSQL As String
        Dim wiTop As Integer

        On Error GoTo tblDetail_ButtonClick_Err

        With tblDetail
            Select Case eventArgs.ColIndex
                Case GITMCODE

                    If CDbl(gsLangID) = 1 Then
                        wsSQL = "SELECT ITMCODE, ITMBARCODE, ITMENGNAME ITNAME FROM mstITEM "
                        wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(cboITMCODE.Text) & "%' "
                        wsSQL = wsSQL & " ORDER BY ITMCODE "
                    Else
                        wsSQL = "SELECT ITMCODE, ITMBARCODE, ITMCHINAME ITNAME FROM mstITEM "
                        wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(cboITMCODE.Text) & "%' "
                        wsSQL = wsSQL & " ORDER BY ITMCODE "
                    End If


                    Call Ini_Combo(3, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case GWHSCODE

                    wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
                    wsSQL = wsSQL & " WHERE WhsStatus <> '2' AND WhsCode LIKE '%" & Set_Quote(cboWhsCode.Text) & "%' "
                    wsSQL = wsSQL & " ORDER BY WhsCode"

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLWHSCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail


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
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Call tblDetail_ButtonClick(tblDetail, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))

                Case System.Windows.Forms.Keys.F5 ' INSERT LINE
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case System.Windows.Forms.Keys.F8 ' DELETE LINE
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(.Bookmark) Then Exit Sub
                    If .EditActive = True Then Exit Sub
                    gsMsg = "你是否確認要刪除此列?"
                    If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then Exit Sub
                    .Delete()
                    'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()
                    If .Row = -1 Then
                        .Row = 0
                    End If
                    'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Refresh()
                    .Focus()

                Case System.Windows.Forms.Keys.Return

                    If .Col <> GLPRICE Then
                        eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                        .Col = .Col + 1
                    Else
                        eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                        .Col = GITMCODE
                    End If

                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> GITMCODE Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> GLPRICE Then
                        .Col = .Col + 1
                    End If

            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub



    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent

        Select Case tblDetail.Col

            Case GLEAD
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, False)

            Case GAVGCOST, GPOCOST, GLPRICE
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, True)

        End Select

    End Sub


    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange

        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail
            If IsEmptyRow() Then
                .Col = GITMCODE
            End If

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case GITMCODE
                        Call Chk_grdITMCODE((.Columns(GITMCODE).Text), 0, "")

                    Case GWHSCODE
                        Call Chk_grdWhsCode((.Columns(GWHSCODE).Text))


                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub
    Private Function Chk_grdITMCODE(ByRef inItmCode As String, ByRef OutID As Object, ByRef outItmName As String) As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset

        If wsKeyIn <> "2" And cboITMCODE.Text <> inItmCode Then
            gsMsg = "不同物料名!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
        End If

        wsSQL = "SELECT ItmID, ItmChiName FROM MstItem "
        wsSQL = wsSQL & " WHERE ItmCode = '" & Set_Quote(inItmCode) & "' And ItmStatus = '1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outItmName = ReadRs(rsRcd, "ItmChiName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object OutID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutID = ReadRs(rsRcd, "ItmID")

            Chk_grdITMCODE = True
        Else
            outItmName = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object OutID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutID = 0
            gsMsg = "沒有此物料名!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_grdWhsCode(ByRef inWhsCode As String) As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset

        If wsKeyIn <> "1" And cboWhsCode.Text <> inWhsCode Then
            gsMsg = "不同倉庫!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdWhsCode = False
        End If

        wsSQL = "SELECT WhsDesc FROM MstWarehouse "
        wsSQL = wsSQL & " WHERE WhsCode = '" & Set_Quote(inWhsCode) & "' And WhsStatus = '1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            Chk_grdWhsCode = True
        Else
            gsMsg = "沒有此倉庫!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdWhsCode = False
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function



    Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean

        IsEmptyRow = True

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblDetail
                If Trim(.Columns(GITMCODE).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, GITMCODE)) = "" And Trim(waResult.get_Value(inRow, GWHSCODE)) = "" And Trim(waResult.get_Value(inRow, GITEMNAME)) = "" And Trim(waResult.get_Value(inRow, GLOTNO)) = "" And Trim(waResult.get_Value(inRow, GLEAD)) = "" And Trim(waResult.get_Value(inRow, GAVGCOST)) = "" And Trim(waResult.get_Value(inRow, GPOCOST)) = "" And Trim(waResult.get_Value(inRow, GLPRICE)) = "" Then
                    Exit Function
                End If
            End If
        End If


        IsEmptyRow = False

    End Function

    Private Function Chk_GrdRow(ByVal LastRow As Integer) As Boolean
        Dim wlCtr As Integer
        Dim wsDes As String
        Dim wsExcRat As String

        Chk_GrdRow = False

        On Error GoTo Chk_GrdRow_Err

        With tblDetail
            If To_Value(LastRow) > waResult.get_UpperBound(1) Then
                Chk_GrdRow = True
                Exit Function
            End If

            If IsEmptyRow(To_Value(LastRow)) = True Then
                .Delete()
                'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                .Refresh()
                .Focus()
                Chk_GrdRow = False
                Exit Function
            End If

            If Chk_grdITMCODE(waResult.get_Value(LastRow, GITMCODE), 0, "") = False Then
                .Col = GITMCODE
                .Row = LastRow
                Exit Function
            End If

            If Chk_grdWhsCode(waResult.get_Value(LastRow, GWHSCODE)) = False Then
                .Col = GWHSCODE
                .Row = LastRow
                Exit Function
            End If


        End With


        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check chk_GrdRow")

    End Function
    Private Function SaveData() As Boolean
        Dim wiRet As Integer

        SaveData = False

        If (wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec) And tbrProcess.Items.Item(tcSave).Enabled = True Then

            gsMsg = "你是否確定要儲存現時之作業?"
            If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                Exit Function
            Else
                'If wiAction = DelRec Then
                '    If cmdDel = True Then
                '        Exit Function
                '    End If
                'Else
                If cmdSave = True Then
                    Exit Function
                End If
                'End If
            End If
            SaveData = True
        Else
            SaveData = False
        End If

    End Function

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
                    .Items.Item(tcFind).Enabled = True
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


            Case "AfrKeyAdd"
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

            Case "AfrKeyEdit"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcEdit).Enabled = False
                    .Items.Item(tcDelete).Enabled = True
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

                Me.cboITMCODE.Enabled = False
                Me.cboWhsCode.Enabled = False

                Me.tblDetail.Enabled = False

            Case "AfrActAdd"

                Me.cboITMCODE.Enabled = True
                Me.cboWhsCode.Enabled = True


            Case "AfrActEdit"

                Me.cboITMCODE.Enabled = True
                Me.cboWhsCode.Enabled = True


            Case "AfrKey"
                Me.cboITMCODE.Enabled = False
                Me.cboWhsCode.Enabled = False

                If wiAction = CorRec Then
                    tblDetail.Enabled = True
                End If

        End Select
    End Sub


    Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsCurRec As String
        Dim wsCurRecLn As String
        Chk_NoDup = False

        wsCurRec = tblDetail.Columns(GITMCODE).Text
        wsCurRecLn = tblDetail.Columns(GWHSCODE).Text

        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If wsCurRec = waResult.get_Value(wlCtr, GITMCODE) And wsCurRecLn = waResult.get_Value(wlCtr, GWHSCODE) Then
                    gsMsg = "物料名和倉庫已重覆!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    Exit Function
                End If
            End If
        Next

        Chk_NoDup = True

    End Function


    Private Sub Ini_Data()
        If wsITMCODE <> "" Then
            cboITMCODE.Text = wsITMCODE
            If cboITMCODE.Enabled = True Then
                System.Windows.Forms.SendKeys.Send("{ENTER}")
            End If
        End If
    End Sub



    Public Sub mnuPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopUpSub.Click
        Dim Index As Short = mnuPopUpSub.GetIndex(eventSender)
        Call Call_PopUpMenu(waPopUpSub, Index)
    End Sub

    Private Sub Call_PopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)

        Dim wsAct As String

        wsAct = inArray.get_Value(inMnuIdx, 0)

        With tblDetail
            Select Case wsAct
                Case "DELETE"

                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(.Bookmark) Then Exit Sub
                    If .EditActive = True Then Exit Sub
                    gsMsg = "你是否確定要刪除此列?"
                    If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then Exit Sub
                    .Delete()
                    'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()
                    If .Row = -1 Then
                        .Row = 0
                    End If
                    'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Refresh()
                    .Focus()


                Case "INSERT"

                    If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case Else
                    Exit Sub


            End Select

        End With


    End Sub
End Class