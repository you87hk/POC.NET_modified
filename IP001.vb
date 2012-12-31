Option Strict Off
Option Explicit On
Friend Class frmIP001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waCusResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	
	Private wcCombo As System.Windows.Forms.Control
	
	Private wsOldCusNo As String
	Private wsOldCurCd As String
	Private wsOldShipCd As String
	Private wsOldRmkCd As String
	Private wsOldPayCd As String
	
	Private Const VDRCODE As Short = 0
	Private Const VDRNAME As Short = 1
	Private Const VDRCURR As Short = 2
	Private Const Price As Short = 3
	Private Const DISCOUNT As Short = 4
	Private Const CNVFACTOR As Short = 5
	Private Const UOMCODE As Short = 6
	Private Const COST As Short = 7
	Private Const PRICEL As Short = 8
	Private Const COSTL As Short = 9
	Private Const VDRID As Short = 10
	
	Private Const CusCode As Short = 0
	Private Const CUSNAME As Short = 1
	Private Const CUSCURR As Short = 2
	Private Const CUSPRICE As Short = 3
	Private Const CUSCNVFACTOR As Short = 4
	Private Const CUSUOMCODE As Short = 5
	Private Const CUSPRICEL As Short = 6
	Private Const CUSID As Short = 7
	
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
	Private Const wsKeyType As String = "MstVdrItem"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	Private wsITMCODE As String
	Private wsItmExcr As String
	
	Private Sub Ini_Scr()
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, VDRCODE, VDRID)
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		waCusResult.ReDim(0, -1, CusCode, CUSID)
		tblCusItem.Array = waCusResult
		tblCusItem.ReBind()
		tblCusItem.Bookmark = 0
		
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
                    'MyControl.ClearFields()
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
		wsItmExcr = "0"
		
		tblCommon.Visible = False
		
		Me.Text = wsFormCaption
		
		FocusMe(cboITMCODE)
		
		tabDetailInfo.TabPages.Item(0).Visible = False
		tabDetailInfo.SelectedIndex = 1
		
	End Sub
	
	Private Function Chk_cboItmCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboItmCode = False
		
		If Trim(cboITMCODE.Text) = "" Then
			gsMsg = "必需輸入物料號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboITMCODE.Focus()
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
	
	
	
	Private Sub Ini_Scr_AfrKey()
		
		If LoadRecord = False Then Exit Sub
		
		
		wiAction = CorRec
		If RowLock(wsConnTime, wsKeyType, cboITMCODE.Text, wsFormID, wsUsrId) = False Then
			gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tblDetail.ReBind()
			tblCusItem.ReBind()
		End If
		
		Call SetButtonStatus("AfrKeyEdit")
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		Call SetFieldStatus("AfrKey")
		
		If tabDetailInfo.SelectedIndex = 0 Then
			If tblCusItem.Enabled = True Then
				tblCusItem.Focus()
			End If
		Else
			If tblDetail.Enabled = True Then
				tblDetail.Focus()
			End If
		End If
	End Sub
	
	Private Sub cboItmCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboITMCODE
		
		wsSQL = "SELECT ItmCode, ItmChiName "
		wsSQL = wsSQL & " FROM MstItem "
		wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboITMCODE.SelectionLength > 0, "", Set_Quote(cboITMCODE.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmStatus <> '2' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboITMCODE.Left)), VB6.PixelsToTwipsY(cboITMCODE.Top) + VB6.PixelsToTwipsY(cboITMCODE.Height), tblCommon, "IP001", "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Enter
		FocusMe(cboITMCODE)
	End Sub
	
	Private Sub cboItmCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboITMCODE, 30, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			
			If Chk_cboItmCode() = False Then GoTo EventExitSub
			
			Call Ini_Scr_AfrKey()
			
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
	
	'UPGRADE_WARNING: Form event frmIP001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmIP001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboITMCODE
		End If
	End Sub
	
	Private Sub frmIP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.PageDown
				KeyCode = 0
				If tabDetailInfo.SelectedIndex < tabDetailInfo.TabPages.Count() - 1 Then
					tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex + 1
					Exit Sub
				End If
			Case System.Windows.Forms.Keys.PageUp
				KeyCode = 0
				If tabDetailInfo.SelectedIndex > 0 Then
					tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex - 1
					Exit Sub
				End If
				
			Case System.Windows.Forms.Keys.F6
				Call cmdOpen()
				
				
				'Case vbKeyF2
				'    If wiAction = DefaultPage Then Call cmdNew
				
				
				'Case vbKeyF5
				'    If wiAction = DefaultPage Then Call cmdEdit
				
				
				'Case vbKeyF3
				'    If wiAction = DefaultPage Then Call cmdDel
				
			Case System.Windows.Forms.Keys.F9
				
				If tbrProcess.Items.Item(tcFind).Enabled = True Then
					Call cmdFind()
				End If
				
			Case System.Windows.Forms.Keys.F10
				
				If tbrProcess.Items.Item(tcSave).Enabled = True Then Call cmdSave()
				
			Case System.Windows.Forms.Keys.F11
				
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub frmIP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Grid()
		Call Ini_CusGrid()
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
			
			wsSQL = "SELECT ItmID, ItmEngName ItmName, ItmUomCode, ItmUnitPrice, ItmCurr "
			wsSQL = wsSQL & "FROM MstItem "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND ItmCode='" & Set_Quote(cboITMCODE.Text) & "' "
		Else
			wsSQL = "SELECT ItmID, ItmChiName ItmName, ItmUomCode, ItmUnitPrice, ItmCurr "
			wsSQL = wsSQL & "FROM MstItem "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND ItmCode='" & Set_Quote(cboITMCODE.Text) & "' "
			
		End If
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			lblDspItmName.Text = ""
			lblDspUOMCode.Text = ""
			lblDspCurr.Text = ""
			lblDspPrice.Text = ""
			
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlItmID = ReadRs(rsRcd, "ItmID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspItmName.Text = ReadRs(rsRcd, "ItmName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspUOMCode.Text = ReadRs(rsRcd, "ItmUOMCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspCurr.Text = ReadRs(rsRcd, "ItmCurr")
			lblDspPrice.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmUnitPrice")), gsUprFmt)
			
			If getExcPRate((lblDspCurr.Text), gsSystemDate, wsItmExcr, "") = False Then
				gsMsg = "沒有此貨幣!"
				wsItmExcr = "1"
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Call LoadCusRecord()
		Call LoadVdrRecord()
		
		LoadRecord = True
		
	End Function
	
	Private Function LoadVdrRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		
		LoadVdrRecord = False
		
		If gsLangID = "1" Then
			wsSQL = "SELECT VdrCode, VdrItemEngName VdrItmName, VdrItemUOMCODE, "
			wsSQL = wsSQL & "VdrItemCurr, VdrItemPrice,VdrItemPricel, VdrItemCnvFactor, VdrItemDiscount, "
			wsSQL = wsSQL & "VdrItemCost, VdrItemCostl, VdrItemID, VdrItemVdrID, VdrName "
			wsSQL = wsSQL & "FROM MstItem, MstVdrItem, MstVendor "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND VdrItemStatus = '1' "
			wsSQL = wsSQL & "AND VdrItemItmID = ItmID AND VdrItemItmID = " & wlItmID & " "
			wsSQL = wsSQL & "AND VdrItemVdrID = VdrID "
			wsSQL = wsSQL & "ORDER BY VdrCode "
		Else
			wsSQL = "SELECT VdrCode, VdrItemChiName VdrItmName, VdrItemUOMCODE, "
			wsSQL = wsSQL & "VdrItemCurr, VdrItemPrice, VdrItemPricel, VdrItemCnvFactor, VdrItemDiscount, "
			wsSQL = wsSQL & "VdrItemCost, VdrItemCostl, VdrItemID, VdrItemVdrID, VdrName "
			wsSQL = wsSQL & "FROM MstItem, MstVdrItem, MstVendor "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND VdrItemStatus = '1' "
			wsSQL = wsSQL & "AND VdrItemItmID = ItmID AND VdrItemItmID = " & wlItmID & " "
			wsSQL = wsSQL & "AND VdrItemVdrID = VdrID "
			wsSQL = wsSQL & "ORDER BY VdrCode "
		End If
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		rsRcd.MoveFirst()
		With waResult
			.ReDim(0, -1, VDRCODE, VDRID)
			Do While Not rsRcd.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), VDRCODE) = ReadRs(rsRcd, "VdrCode")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), VDRNAME) = ReadRs(rsRcd, "VdrName")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), VDRCURR) = ReadRs(rsRcd, "VdrItemCurr")
				waResult.get_Value(.get_UpperBound(1), Price) = VB6.Format(To_Value(ReadRs(rsRcd, "VdrItemPrice")), gsUprFmt)
				waResult.get_Value(.get_UpperBound(1), PRICEL) = To_Value(ReadRs(rsRcd, "VdrItemPricel"))
				waResult.get_Value(.get_UpperBound(1), CNVFACTOR) = VB6.Format(To_Value(ReadRs(rsRcd, "VdrItemCnvFactor")), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), DISCOUNT) = VB6.Format(To_Value(ReadRs(rsRcd, "VdrItemDiscount")), gsUprFmt)
				waResult.get_Value(.get_UpperBound(1), COST) = VB6.Format(To_Value(ReadRs(rsRcd, "VdrItemCost")), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), COSTL) = VB6.Format(To_Value(ReadRs(rsRcd, "VdrItemCostl")), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), UOMCODE) = ReadRs(rsRcd, "VdrItemUOMCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), VDRID) = ReadRs(rsRcd, "VdrItemVdrID")
				rsRcd.MoveNext()
			Loop 
		End With
		tblDetail.ReBind()
		tblDetail.FirstRow = 0
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadVdrRecord = True
	End Function
	
	
	Private Function LoadCusRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		
		LoadCusRecord = False
		
		If gsLangID = "1" Then
			wsSQL = "SELECT CusCode, CusItemEngName CusItmName, CusItemUOMCODE, "
			wsSQL = wsSQL & "CusItemCurr, CusItemPrice, CusItemPriceL, CusItemCnvFactor, "
			wsSQL = wsSQL & "CusItemID, CusItemCusID, CusName "
			wsSQL = wsSQL & "FROM MstItem, MstCusItem, MstCustomer "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND CusItemStatus = '1' "
			wsSQL = wsSQL & "AND CusItemItmID = ItmID AND CusItemItmID = " & wlItmID & " "
			wsSQL = wsSQL & "AND CusItemCusID = CusID "
			wsSQL = wsSQL & "ORDER BY CusCode "
		Else
			wsSQL = "SELECT CusCode, CusItemChiName CusItmName, CusItemUOMCODE, "
			wsSQL = wsSQL & "CusItemCurr, CusItemPrice, CusItemPriceL, CusItemCnvFactor, "
			wsSQL = wsSQL & "CusItemID, CusItemCusID, CusName "
			wsSQL = wsSQL & "FROM MstItem, MstCusItem, MstCustomer "
			wsSQL = wsSQL & "WHERE ItmStatus =  '1' AND CusItemStatus = '1' "
			wsSQL = wsSQL & "AND CusItemItmID = ItmID AND CusItemItmID = " & wlItmID & " "
			wsSQL = wsSQL & "AND CusItemCusID = CusID "
			wsSQL = wsSQL & "ORDER BY CusCode "
		End If
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		rsRcd.MoveFirst()
		With waCusResult
			.ReDim(0, -1, CusCode, CUSID)
			Do While Not rsRcd.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waCusResult.get_Value(.get_UpperBound(1), CusCode) = ReadRs(rsRcd, "CusCode")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waCusResult.get_Value(.get_UpperBound(1), CUSNAME) = ReadRs(rsRcd, "CusName")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waCusResult.get_Value(.get_UpperBound(1), CUSCURR) = ReadRs(rsRcd, "CusItemCurr")
				waCusResult.get_Value(.get_UpperBound(1), CUSPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "CusItemPrice")), gsAmtFmt)
				waCusResult.get_Value(.get_UpperBound(1), CUSPRICEL) = VB6.Format(To_Value(ReadRs(rsRcd, "CusItemPriceL")), gsAmtFmt)
				waCusResult.get_Value(.get_UpperBound(1), CUSCNVFACTOR) = VB6.Format(To_Value(ReadRs(rsRcd, "CUsItemCnvFactor")), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waCusResult.get_Value(.get_UpperBound(1), CUSUOMCODE) = ReadRs(rsRcd, "CusItemUOMCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waCusResult.get_Value(.get_UpperBound(1), CUSID) = ReadRs(rsRcd, "CusItemCusID")
				rsRcd.MoveNext()
			Loop 
		End With
		tblCusItem.ReBind()
		tblCusItem.FirstRow = 0
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadCusRecord = True
	End Function
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblItmCode.Text = Get_Caption(waScrItm, "ITEMCODE")
		lblVdrItemChiName.Text = Get_Caption(waScrItm, "ITEMNAME")
		lblUOMCode.Text = Get_Caption(waScrItm, "UOMCODE")
		lblCurr.Text = Get_Caption(waScrItm, "ITMCURR")
		lblPrice.Text = Get_Caption(waScrItm, "ITMPRICE")
		
		With tblDetail
			.Columns(VDRCODE).Caption = Get_Caption(waScrItm, "VDRCODE")
			.Columns(VDRNAME).Caption = Get_Caption(waScrItm, "VDRNAME")
			.Columns(VDRCURR).Caption = Get_Caption(waScrItm, "VDRCURR")
			.Columns(Price).Caption = Get_Caption(waScrItm, "PRICE")
			.Columns(CNVFACTOR).Caption = Get_Caption(waScrItm, "CNVFACTOR")
			.Columns(DISCOUNT).Caption = Get_Caption(waScrItm, "DISCOUNT")
			.Columns(COST).Caption = Get_Caption(waScrItm, "COST")
			.Columns(COSTL).Caption = Get_Caption(waScrItm, "COSTL")
			.Columns(UOMCODE).Caption = Get_Caption(waScrItm, "VDRUOMCODE")
			.Columns(VDRID).Caption = Get_Caption(waScrItm, "VDRID")
		End With
		
		With tblCusItem
			.Columns(CusCode).Caption = Get_Caption(waScrItm, "CUSCODE")
			.Columns(CUSNAME).Caption = Get_Caption(waScrItm, "CUSNAME")
			.Columns(CUSCURR).Caption = Get_Caption(waScrItm, "CUSCURR")
			.Columns(CUSPRICE).Caption = Get_Caption(waScrItm, "CUSPRICE")
			.Columns(CUSPRICEL).Caption = Get_Caption(waScrItm, "CUSPRICEL")
			.Columns(CUSCNVFACTOR).Caption = Get_Caption(waScrItm, "CUSCNVFACTOR")
			.Columns(CUSUOMCODE).Caption = Get_Caption(waScrItm, "CUSUOMCODE")
			.Columns(CUSID).Caption = Get_Caption(waScrItm, "CUSID")
		End With
		
		tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO01")
		tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO02")
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "IPADD")
		wsActNam(2) = Get_Caption(waScrItm, "IPEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "IPDELETE")
		
		Call Ini_PopMenu(mnuCPopUpSub, "POPUP", waPopUpSub)
		Call Ini_PopMenu(mnuVPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	'UPGRADE_WARNING: Event frmIP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmIP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(7305)
			Me.Width = VB6.TwipsToPixelsX(9915)
		End If
	End Sub
	
	Private Sub frmIP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waCusResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waCusResult = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        'UPGRADE_NOTE: Object frmIP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
    End Sub

    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then

            If tblDetail.Enabled Then
                tblDetail.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 1 Then

            If Me.tblCusItem.Enabled Then
                tblCusItem.Focus()
            End If
        End If
        PreviousTab = tabDetailInfo.SelectedIndex()
    End Sub

    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        If wcCombo.Name = tblDetail.Name Then
            tblDetail.EditActive = True
            wcCombo.Text = tblCommon.Columns(0).Text
        ElseIf wcCombo.Name = tblCusItem.Name Then
            tblCusItem.EditActive = True
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
            ElseIf wcCombo.Name = tblCusItem.Name Then
                tblCusItem.EditActive = True
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
            If ReadOnlyMode(wsConnTime, wsKeyType, cboITMCODE.Text, wsFormID) Then
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
            adcmdSave.CommandText = "USP_IP001V"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, VDRCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlItmID)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, VDRID))
                    Call SetSPPara(adcmdSave, 4, "")
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, UOMCODE))
                    Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, VDRCURR))
                    Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, Price))
                    Call SetSPPara(adcmdSave, 8, waResult.get_Value(wiCtr, CNVFACTOR))
                    Call SetSPPara(adcmdSave, 9, waResult.get_Value(wiCtr, DISCOUNT))
                    Call SetSPPara(adcmdSave, 10, waResult.get_Value(wiCtr, COST))
                    Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, COSTL))
                    Call SetSPPara(adcmdSave, 12, wiCtr)
                    Call SetSPPara(adcmdSave, 13, gsUserID)
                    Call SetSPPara(adcmdSave, 14, wsGenDte)

                    adcmdSave.Execute()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wlKey = GetSPPara(adcmdSave, 15)
                End If
            Next
        End If
        cnCon.CommitTrans()

        If wiAction = CorRec And CDbl(Trim(CStr(wlKey))) <> 0 Then
            bResult = True
        Else
            bResult = False
        End If

        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing
        cmdSave = True

        wlRowCtr = waCusResult.get_UpperBound(1)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        If waCusResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_IP001C"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waCusResult.get_UpperBound(1)
                If Trim(waCusResult.get_Value(wiCtr, CusCode)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlItmID)
                    Call SetSPPara(adcmdSave, 3, waCusResult.get_Value(wiCtr, CUSID))
                    Call SetSPPara(adcmdSave, 4, "")
                    Call SetSPPara(adcmdSave, 5, waCusResult.get_Value(wiCtr, CUSUOMCODE))
                    Call SetSPPara(adcmdSave, 6, waCusResult.get_Value(wiCtr, CUSCURR))
                    Call SetSPPara(adcmdSave, 7, waCusResult.get_Value(wiCtr, CUSPRICE))
                    Call SetSPPara(adcmdSave, 8, waCusResult.get_Value(wiCtr, CUSPRICEL))
                    Call SetSPPara(adcmdSave, 9, waCusResult.get_Value(wiCtr, CUSCNVFACTOR))
                    Call SetSPPara(adcmdSave, 10, wiCtr)
                    Call SetSPPara(adcmdSave, 11, gsUserID)
                    Call SetSPPara(adcmdSave, 12, wsGenDte)

                    adcmdSave.Execute()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wlKey = GetSPPara(adcmdSave, 13)
                End If
            Next
        End If
        cnCon.CommitTrans()

        If wiAction = CorRec And CDbl(Trim(CStr(wlKey))) <> 0 And bResult = True Then
            gsMsg = "物料價已儲存!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        Else
            gsMsg = "客戶或供應商物料價儲存失敗!"
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
        Dim wlCtr1 As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, VDRCODE)) <> "" Then

                    wiEmptyGrid = False
                    If Chk_VdrGrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If

                    For wlCtr1 = 0 To .get_UpperBound(1)
                        If wlCtr <> wlCtr1 Then
                            If waResult.get_Value(wlCtr, VDRCODE) = waResult.get_Value(wlCtr1, VDRCODE) And waResult.get_Value(wlCtr, VDRCURR) = waResult.get_Value(wlCtr1, VDRCURR) Then
                                gsMsg = "供應商或貨幣已重覆!"
                                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                                Exit Function
                            End If
                        End If
                    Next



                End If
            Next
        End With

        If wiEmptyGrid = True Then
            gsMsg = "沒有設定供應商物料價!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tblDetail.Focus()
            End If
            Exit Function
        End If


        'If Chk_NoVdrDup(To_Value(tblDetail.Bookmark)) = False Then
        '    tblDetail.FirstRow = tblDetail.Row
        '    tblDetail.Col = VDRCODE
        '    tblDetail.SetFocus
        '    Exit Function
        'End If

        '   With waCusResult
        '       For wlCtr = 0 To .UpperBound(1)
        '           If Trim(waCusResult(wlCtr, VDRCODE)) <> "" Then
        '               wiEmptyGrid = False
        '               If Chk_CusGrdRow(wlCtr) = False Then
        '                   tblCusItem.SetFocus
        '                   Exit Function
        '               End If
        '           End If
        '       Next
        '   End With

        '   If wiEmptyGrid = True Then
        '       gsMsg = "沒有設定客戶物料價!"
        '       MsgBox gsMsg, vbOKOnly, gsTitle
        '       If tblCusItem.Enabled Then
        '       tblCusItem.SetFocus
        '       End If
        '       Exit Function
        '   End If
        '
        '   If Chk_NoCusDup(To_Value(tblCusItem.Bookmark)) = False Then
        '       tblCusItem.FirstRow = tblCusItem.Row
        '       tblCusItem.Col = CusCode
        '       tblCusItem.SetFocus
        '       Exit Function
        '   End If


        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function

    Private Sub cmdNew()

        Dim newForm As New frmIP001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()
    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmIP001

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
        wsFormID = "IP001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsTrnCd = "IP"
    End Sub

    Private Sub cmdCancel()
        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("AfrActEdit")
        Call SetButtonStatus("AfrActEdit")

        cboITMCODE.Focus()
    End Sub

    Private Sub cmdFind()
        Call OpenPromptForm()
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

    Private Sub tblCusItem_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblCusItem.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmIP001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuCPopUp)
        End If
    End Sub

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            If Chk_VdrGrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub

    Private Sub tblCusItem_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblCusItem.BeforeRowColChange

        On Error GoTo tblCusItem_BeforeRowColChange_Err
        With tblCusItem
            If Chk_CusGrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
        End With

        Exit Sub

tblCusItem_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub


    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmIP001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuVPopUp)
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
            '  .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = VDRCODE To VDRID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case VDRCODE
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case VDRNAME
                        .Columns(wiCtr).Width = 3000
                        .Columns(wiCtr).DataWidth = 60

                    Case VDRCURR
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case Price
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsUprFmt
                        .Columns(wiCtr).Locked = True

                    Case PRICEL
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False

                    Case CNVFACTOR
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsExrFmt

                    Case DISCOUNT
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsUprFmt

                    Case COST
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True

                    Case COSTL
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False


                    Case UOMCODE
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case VDRID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                End Select
            Next
            ' .Styles("EvenRow").BackColor = &H8000000F
        End With

    End Sub

    Private Sub Ini_CusGrid()

        Dim wiCtr As Short

        With tblCusItem
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            '   .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = CusCode To CUSID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case CusCode
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case CUSNAME
                        .Columns(wiCtr).Width = 4500
                        .Columns(wiCtr).DataWidth = 60

                    Case CUSCURR
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case CUSPRICE
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt

                    Case CUSPRICEL
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False

                    Case CUSCNVFACTOR
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsExrFmt

                    Case CUSUOMCODE
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10

                    Case CUSID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                End Select
            Next
            '  .Styles("EvenRow").BackColor = &H8000000F
        End With

    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate

        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub

    Private Sub tblCusItem_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblCusItem.AfterColUpdate

        With tblCusItem
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub

    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsVdrID As String
        Dim wsVdrCurr As String

        Dim wsVDRNAME As String
        Dim wsUOMCode As String
        Dim wdPrice As Double
        Dim wsExcRate As String
        Dim wsExcDesc As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        wsExcRate = "0"

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case VDRCODE
                    If Not Chk_NoVdrDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdVdrCode((.Columns(eventArgs.ColIndex).Text), wsVdrID, wsVdrCurr, wsVDRNAME, wdPrice) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                        'Else
                        '    .Columns(VDRID).Text = wsVdrID
                        '    If Load_ItemPrice(cboItmCode, wsUOMCode, wdPrice) = False Then
                        '        GoTo Tbl_BeforeColUpdate_Err
                        '    End If
                    End If

                    .Columns(VDRID).Text = wsVdrID
                    .Columns(VDRNAME).Text = wsVDRNAME
                    .Columns(VDRCURR).Text = wsVdrCurr
                    .Columns(UOMCODE).Text = lblDspUOMCode.Text
                    .Columns(Price).Text = VB6.Format(wdPrice, gsUprFmt)
                    .Columns(CNVFACTOR).Text = VB6.Format("1", gsExrFmt)
                    .Columns(DISCOUNT).Text = VB6.Format("1", gsUprFmt)
                    .Columns(COST).Text = VB6.Format(wdPrice, gsAmtFmt)


                    If getExcPRate((.Columns(VDRCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                        gsMsg = "沒有此貨幣!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If

                    If Trim(.Columns(Price).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(PRICEL).Text = VB6.Format(To_Value((.Columns(Price).Text)) * To_Value(wsExcRate), gsUprFmt)
                    End If

                    If Trim(.Columns(COST).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(COSTL).Text = VB6.Format(To_Value((.Columns(COST).Text)) * To_Value(wsExcRate), gsUprFmt)
                    End If

                Case VDRCURR
                    If Not Chk_NoVdrDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdVdrCurr(.Columns(eventArgs.ColIndex).Text, wdPrice) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If To_Value((.Columns(Price).Text)) <> wdPrice Then

                        .Columns(Price).Text = CStr(wdPrice)

                        If getExcPRate((.Columns(VDRCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                            gsMsg = "沒有此貨幣!"
                            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                            GoTo Tbl_BeforeColUpdate_Err
                            Exit Sub
                        End If

                        If Trim(.Columns(Price).Text) <> "" And wsExcRate <> "0" Then
                            .Columns(PRICEL).Text = VB6.Format(To_Value((.Columns(Price).Text)) * To_Value(wsExcRate), gsUprFmt)
                        End If

                        If Trim(.Columns(COST).Text) <> "" And wsExcRate <> "0" Then
                            .Columns(COSTL).Text = VB6.Format(To_Value((.Columns(COST).Text)) * To_Value(wsExcRate), gsUprFmt)
                        End If



                    End If

                Case UOMCODE
                    If Chk_grdUOMCode((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case CNVFACTOR

                    If Chk_grdCnvFactor((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If getExcPRate((.Columns(VDRCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                        gsMsg = "沒有此貨幣!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If


                    If Trim(.Columns(Price).Text) <> "" And Trim(.Columns(DISCOUNT).Text) <> "" Then
                        .Columns(COST).Text = VB6.Format(To_Value((.Columns(Price).Text)) * To_Value((.Columns(DISCOUNT).Text)) * To_Value((.Columns(CNVFACTOR).Text)), gsAmtFmt)
                    End If

                    If Trim(.Columns(COST).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(COSTL).Text = VB6.Format(To_Value((.Columns(COST).Text)) * To_Value(wsExcRate), gsAmtFmt)
                    End If

                Case Price

                    If Chk_grdPrice((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If getExcPRate((.Columns(VDRCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                        gsMsg = "沒有此貨幣!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If

                    If Trim(.Columns(Price).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(PRICEL).Text = VB6.Format(To_Value((.Columns(Price).Text)) * To_Value(wsExcRate), gsUprFmt)
                    End If

                    If Trim(.Columns(Price).Text) <> "" And Trim(.Columns(DISCOUNT).Text) <> "" Then
                        .Columns(COST).Text = VB6.Format(To_Value((.Columns(Price).Text)) * To_Value((.Columns(DISCOUNT).Text)) * To_Value((.Columns(CNVFACTOR).Text)), gsAmtFmt)
                    End If

                    If Trim(.Columns(COST).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(COSTL).Text = VB6.Format(To_Value((.Columns(COST).Text)) * To_Value(wsExcRate), gsAmtFmt)
                    End If

                Case DISCOUNT

                    If Chk_grdPrice((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If getExcPRate((.Columns(VDRCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                        gsMsg = "沒有此貨幣!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If


                    If Trim(.Columns(Price).Text) <> "" And Trim(.Columns(DISCOUNT).Text) <> "" Then
                        .Columns(COST).Text = VB6.Format(To_Value((.Columns(Price).Text)) * To_Value((.Columns(DISCOUNT).Text)) * To_Value((.Columns(CNVFACTOR).Text)), gsAmtFmt)
                    End If

                    If Trim(.Columns(COST).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(COSTL).Text = VB6.Format(To_Value((.Columns(COST).Text)) * To_Value(wsExcRate), gsAmtFmt)
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

    Private Sub tblCusItem_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblCusItem.BeforeColUpdate
        Dim wsCusID As String
        Dim wsCusCurr As String

        Dim wsName As String
        Dim wsUOMCode As String
        Dim wdPrice As Double
        Dim wsExcRate As String
        Dim wsExcDesc As String
        Dim wsVdrID As String

        On Error GoTo tblCusItem_BeforeColUpdate_Err

        wsExcRate = "0"

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblCusItem.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblCusItem
            Select Case eventArgs.ColIndex
                Case CusCode
                    If Not Chk_NoCusDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdCusCode((.Columns(eventArgs.ColIndex).Text), wsCusID, wsCusCurr, wsName) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    Else
                        .Columns(CUSID).Text = wsCusID
                        If Load_ItemPrice(cboITMCODE.Text, wsUOMCode, wdPrice) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If
                    End If


                    .Columns(CUSNAME).Text = wsName
                    .Columns(CUSCURR).Text = wsCusCurr
                    .Columns(CUSUOMCODE).Text = wsUOMCode

                    .Columns(CUSPRICE).Text = VB6.Format(wdPrice, gsAmtFmt)
                    .Columns(CUSCNVFACTOR).Text = VB6.Format("1", gsExrFmt)

                    If getExcRate((.Columns(CUSCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                        gsMsg = "沒有此貨幣!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If

                    If Trim(.Columns(CUSPRICE).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(CUSPRICEL).Text = VB6.Format(To_Value((.Columns(CUSPRICE).Text)) * To_Value(wsExcRate), gsAmtFmt)
                    End If

                Case CUSCURR
                    If Not Chk_NoCusDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdCusCurr((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case CUSUOMCODE
                    If Chk_grdUOMCode((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case CUSCNVFACTOR, CUSPRICE

                    If eventArgs.ColIndex = CUSCNVFACTOR Then
                        If Chk_grdCnvFactor((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If
                    End If

                    If getExcPRate((.Columns(VDRCURR).Text), gsSystemDate, wsExcRate, wsExcDesc) = False Then
                        gsMsg = "沒有此貨幣!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If

                    If Trim(.Columns(Price).Text) <> "" And wsExcRate <> "0" Then
                        .Columns(CUSPRICEL).Text = VB6.Format(To_Value((.Columns(CUSPRICE).Text)) * To_Value(wsExcRate), gsAmtFmt)
                    End If
            End Select
        End With

        Exit Sub

Tbl_BeforeColUpdate_Err:
        'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tblCusItem.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True
        Exit Sub

tblCusItem_BeforeColUpdate_Err:

        MsgBox("Check tblDeiail BeforeColUpdate!")
        'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tblCusItem.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True

    End Sub

    Private Sub tblDetail_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent) Handles tblDetail.ButtonClick
        Dim wsSQL As String
        Dim wiTop As Integer

        On Error GoTo tblDetail_ButtonClick_Err

        With tblDetail
            Select Case eventArgs.ColIndex
                Case VDRCODE
                    wsSQL = "SELECT VdrCode, VdrName FROM MstVendor "
                    wsSQL = wsSQL & " WHERE VdrStatus <> '2' AND VdrCode LIKE '%" & Set_Quote(.Columns(VDRCODE).Text) & "%' "
                    wsSQL = wsSQL & " AND VdrInactive = 'N' "
                    wsSQL = wsSQL & " ORDER BY VdrCode"

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLVDRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case UOMCODE
                    wsSQL = "SELECT UOMCode, UOMDesc FROM MstUOM "
                    wsSQL = wsSQL & " WHERE UOMStatus <> '2' AND UOMCode LIKE '%" & Set_Quote(.Columns(UOMCODE).Text) & "%' "
                    wsSQL = wsSQL & " ORDER BY UOMCode"

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLUOMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case VDRCURR
                    wsSQL = "SELECT DISTINCT ExcCurr FROM MstExchangeRate "
                    wsSQL = wsSQL & " WHERE ExcStatus <> '2' AND ExcCurr LIKE '%" & Set_Quote(.Columns(VDRCURR).Text) & "%' "
                    wsSQL = wsSQL & " ORDER BY ExcCurr"

                    Call Ini_Combo(1, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLEXCR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

            End Select
        End With

        Exit Sub

tblDetail_ButtonClick_Err:
        MsgBox("Check tblDeiail ButtonClick!")


    End Sub

    Private Sub tblCusItem_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent) Handles tblCusItem.ButtonClick
        Dim wsSQL As String
        Dim wiTop As Integer

        On Error GoTo tblCusItem_ButtonClick_Err

        With tblCusItem
            Select Case eventArgs.ColIndex
                Case CusCode
                    wsSQL = "SELECT CusCode, CusName FROM MstCustomer "
                    wsSQL = wsSQL & " WHERE CusStatus <> '2' AND CusCode LIKE '%" & Set_Quote(.Columns(CusCode).Text) & "%' "
                    wsSQL = wsSQL & " AND CusInactive = 'N' "
                    wsSQL = wsSQL & " ORDER BY CusCode"

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLCUSCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblCusItem

                Case CUSUOMCODE
                    wsSQL = "SELECT UOMCode, UOMDesc FROM MstUOM "
                    wsSQL = wsSQL & " WHERE UOMStatus <> '2' AND UOMCode LIKE '%" & Set_Quote(.Columns(CUSUOMCODE).Text) & "%' "
                    wsSQL = wsSQL & " ORDER BY UOMCode"

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLUOMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblCusItem

                Case CUSCURR
                    wsSQL = "SELECT DISTINCT ExcCurr FROM MstExchangeRate "
                    wsSQL = wsSQL & " WHERE ExcStatus <> '2' AND ExcCurr LIKE '%" & Set_Quote(.Columns(CUSCURR).Text) & "%' "
                    wsSQL = wsSQL & " ORDER BY ExcCurr"

                    Call Ini_Combo(1, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLEXCR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblCusItem

            End Select
        End With

        Exit Sub

tblCusItem_ButtonClick_Err:
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
                    If IsEmptyVdrRow Then Exit Sub
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
                    Select Case .Col

                        Case VDRCODE, VDRNAME, VDRCURR, Price, CNVFACTOR, DISCOUNT, UOMCODE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1

                        Case COST
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = VDRCODE

                    End Select

                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> VDRCODE Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> UOMCODE Then
                        .Col = .Col + 1
                    End If

            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblCusItem_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCusItem.KeyDownEvent
        Dim wlRet As Short
        Dim wlRow As Integer

        On Error GoTo tblCusItem_KeyDown_Err

        With tblCusItem
            Select Case eventArgs.KeyCode
                Case System.Windows.Forms.Keys.F4 ' CALL COMBO BOX
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Call tblCusItem_ButtonClick(tblCusItem, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))

                Case System.Windows.Forms.Keys.F5 ' INSERT LINE
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Bookmark = waCusResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyCusRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waCusResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
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
                    Select Case .Col

                        Case CusCode, CUSNAME, CUSCURR, CUSPRICE, CUSCNVFACTOR
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1

                        Case CUSUOMCODE
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = CusCode

                    End Select

                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> CusCode Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> CUSUOMCODE Then
                        .Col = .Col + 1
                    End If

            End Select
        End With

        Exit Sub

tblCusItem_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
        Select Case tblDetail.Col


            Case Price, CNVFACTOR, DISCOUNT
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, True)
        End Select
    End Sub

    Private Sub tblCusItem_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblCusItem.KeyPressEvent
        Select Case tblCusItem.Col
            Case CUSPRICE, CUSCNVFACTOR
                Call Chk_InpNum(eventArgs.KeyAscii, (tblCusItem.Text), False, True)
        End Select
    End Sub

    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange

        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail
            If IsEmptyVdrRow() Then
                .Col = VDRCODE
            End If

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case VDRCODE
                        Call Chk_grdVdrCode((.Columns(VDRCODE).Text), (.Columns(VDRID).Text), "", "", 0)

                    Case UOMCODE
                        Call Chk_grdUOMCode((.Columns(UOMCODE).Text))

                    Case VDRCURR
                        Call Chk_grdVdrCurr(.Columns(VDRCURR).Text, 0)

                    Case Price
                        Call Chk_grdPrice((.Columns(Price).Text))

                    Case CNVFACTOR
                        Call Chk_grdCnvFactor((.Columns(CNVFACTOR).Text))

                    Case DISCOUNT
                        Call Chk_grdPrice((.Columns(DISCOUNT).Text))


                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub

    Private Sub tblCusItem_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblCusItem.RowColChange

        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblCusItem.Name Then Exit Sub

        With tblCusItem
            If IsEmptyCusRow() Then
                .Col = VDRCODE
            End If

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case CusCode
                        Call Chk_grdCusCode((.Columns(CusCode).Text), (.Columns(CUSID).Text), "", "")

                    Case CUSUOMCODE
                        Call Chk_grdUOMCode((.Columns(CUSUOMCODE).Text))

                    Case CUSCURR
                        Call Chk_grdCusCurr((.Columns(CUSCURR).Text))

                    Case CUSPRICE
                        Call Chk_grdPrice((.Columns(CUSPRICE).Text))

                    Case CUSCNVFACTOR
                        Call Chk_grdCnvFactor((.Columns(CUSCNVFACTOR).Text))
                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblCusItem RowColChange")
        wbErr = True

    End Sub

    Private Function Chk_grdCusCode(ByRef inCusCode As String, ByRef outCusID As String, ByRef outCusCurr As String, ByRef outCusName As String) As Boolean
        Dim wsSQL As String
        Dim rsDes As New ADODB.Recordset

        wsSQL = "SELECT CusCurr, CusID, CusName FROM MstCustomer"
        wsSQL = wsSQL & " WHERE CusCode = '" & Set_Quote(inCusCode) & "' And CusStatus = '1'"
        wsSQL = wsSQL & " AND CusInactive = 'N' "

        rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outCusCurr = ReadRs(rsDes, "CusCurr")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outCusID = ReadRs(rsDes, "CusID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outCusName = ReadRs(rsDes, "CusName")

            Chk_grdCusCode = True
        Else
            outCusCurr = ""
            outCusID = ""
            outCusName = ""

            gsMsg = "沒有此客戶!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdCusCode = False
        End If
        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing
    End Function

    Private Function Chk_grdVdrCode(ByRef inVdrCode As String, ByRef OutVdrID As String, ByRef outVdrCurr As String, ByRef outVdrName As String, ByRef outPrice As Double) As Boolean
        Dim wsSQL As String
        Dim rsDes As New ADODB.Recordset
        Dim wsExcRate As String
        Dim wdItmPrice As Double

        wsSQL = "SELECT VdrCurr, VdrID, VdrName FROM MstVendor"
        wsSQL = wsSQL & " WHERE VdrCode = '" & Set_Quote(inVdrCode) & "' And VdrStatus = '1'"

        rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outVdrCurr = ReadRs(rsDes, "VdrCurr")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutVdrID = ReadRs(rsDes, "VdrID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outVdrName = ReadRs(rsDes, "VdrName")

            Chk_grdVdrCode = True
        Else
            outVdrCurr = ""
            OutVdrID = ""
            outVdrName = ""

            gsMsg = "沒有此供應商!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdVdrCode = False
            rsDes.Close()
            'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsDes = Nothing
            Exit Function

        End If
        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing

        wdItmPrice = To_Value((lblDspPrice.Text))
        outPrice = 0

        If UCase(outVdrCurr) <> UCase(lblDspCurr.Text) Then

            If getExcPRate(outVdrCurr, gsSystemDate, wsExcRate, "") = False Then
                gsMsg = "沒有此貨幣!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Chk_grdVdrCode = False
                Exit Function
            End If


            If To_Value(wsExcRate) <> 0 Then
                outPrice = CDbl(VB6.Format(wdItmPrice * To_Value(wsItmExcr) / To_Value(wsExcRate), gsUprFmt))
            End If

        Else
            outPrice = wdItmPrice
        End If

    End Function

    Private Function Chk_grdCusCurr(ByRef InCurr As String) As Boolean
        Dim rsExcCurr As New ADODB.Recordset
        Dim Criteria As String
        Dim CtlYr As String
        Dim CtlMon As String
        Dim tmpDte As String

        tmpDte = Dsp_Date(gsSystemDate)
        CtlYr = VB6.Format(tmpDte, "yyyy")
        CtlMon = VB6.Format(tmpDte, "mm")

        Criteria = ""

        Criteria = Criteria & "SELECT ExcCurr FROM MstExchangeRate "
        Criteria = Criteria & "WHERE EXCCURR = '" & Set_Quote(InCurr) & "' "
        Criteria = Criteria & "AND EXCYR = '" & Set_Quote(CtlYr) & "' "
        Criteria = Criteria & "AND EXCMN = '" & To_Value(CtlMon) & "' "

        rsExcCurr.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsExcCurr.RecordCount > 0 Then
            Chk_grdCusCurr = True
        Else
            gsMsg = "沒有此貨幣!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdCusCurr = False
        End If

        rsExcCurr.Close()
        'UPGRADE_NOTE: Object rsExcCurr may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsExcCurr = Nothing
    End Function

    Private Function Chk_grdVdrCurr(ByVal InCurr As String, ByRef outPrice As Double) As Boolean
        Dim wsExcRate As String

        Chk_grdVdrCurr = True
        outPrice = 0

        If UCase(InCurr) <> UCase(lblDspCurr.Text) Then

            If getExcPRate(InCurr, gsSystemDate, wsExcRate, "") = False Then
                gsMsg = "沒有此貨幣!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Chk_grdVdrCurr = False
                Exit Function
            End If


            If To_Value(wsExcRate) <> 0 Then
                outPrice = CDbl(VB6.Format(To_Value((lblDspPrice.Text)) * To_Value(wsItmExcr) / To_Value(wsExcRate), gsUprFmt))
            End If

        Else
            outPrice = To_Value((lblDspPrice.Text))
        End If

    End Function

    Private Function Chk_grdUOMCode(ByRef inUOM As String) As Boolean
        Dim rsUOM As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = ""

        wsSQL = wsSQL & "SELECT UOMCode FROM MstUOM "
        wsSQL = wsSQL & "WHERE UOMCode = '" & Set_Quote(inUOM) & "' AND UOMStatus ='1'"

        rsUOM.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsUOM.RecordCount > 0 Then
            Chk_grdUOMCode = True
        Else
            gsMsg = "沒有此單位!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdUOMCode = False
        End If

        rsUOM.Close()
        'UPGRADE_NOTE: Object rsUOM may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsUOM = Nothing
    End Function

    Private Function Chk_grdCnvFactor(ByRef inCode As String) As Boolean
        Chk_grdCnvFactor = True

        If Trim(inCode) = "" Then
            gsMsg = "沒有輸入轉換數!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdCnvFactor = False
            Exit Function
        End If

        If To_Value(inCode) = 0 Then
            gsMsg = "轉換數不可以為零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdCnvFactor = False
            Exit Function
        End If
    End Function



    Private Function Chk_grdPrice(ByRef inCode As String) As Boolean
        Chk_grdPrice = True

        If Trim(inCode) = "" Then
            gsMsg = "沒有輸入價錢!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdPrice = False
            Exit Function
        End If
    End Function


    Private Function IsEmptyCusRow(Optional ByRef inRow As Object = Nothing) As Boolean

        IsEmptyCusRow = True


        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblCusItem
                If Trim(.Columns(CusCode).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waCusResult.get_UpperBound(1) >= 0 Then
                If Trim(waCusResult.get_Value(inRow, CusCode)) = "" And Trim(waCusResult.get_Value(inRow, CUSNAME)) = "" And Trim(waCusResult.get_Value(inRow, CUSCURR)) = "" And Trim(waCusResult.get_Value(inRow, CUSPRICE)) = "" And Trim(waCusResult.get_Value(inRow, CUSPRICEL)) = "" And Trim(waCusResult.get_Value(inRow, CUSCNVFACTOR)) = "" And Trim(waCusResult.get_Value(inRow, CUSUOMCODE)) = "" And Trim(waCusResult.get_Value(inRow, CUSID)) = "" Then
                    Exit Function
                End If
            End If
        End If

        IsEmptyCusRow = False

    End Function
    Private Function IsEmptyVdrRow(Optional ByRef inRow As Object = Nothing) As Boolean

        IsEmptyVdrRow = True

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblDetail
                If Trim(.Columns(VDRCODE).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, VDRCODE)) = "" And Trim(waResult.get_Value(inRow, VDRNAME)) = "" And Trim(waResult.get_Value(inRow, VDRCURR)) = "" And Trim(waResult.get_Value(inRow, Price)) = "" And Trim(waResult.get_Value(inRow, PRICEL)) = "" And Trim(waResult.get_Value(inRow, CNVFACTOR)) = "" And Trim(waResult.get_Value(inRow, DISCOUNT)) = "" And Trim(waResult.get_Value(inRow, COST)) = "" And Trim(waResult.get_Value(inRow, COSTL)) = "" And Trim(waResult.get_Value(inRow, UOMCODE)) = "" And Trim(waResult.get_Value(inRow, VDRID)) = "" Then
                    Exit Function
                End If
            End If
        End If


        IsEmptyVdrRow = False

    End Function
    Private Function Chk_CusGrdRow(ByVal LastRow As Integer) As Boolean
        Dim wlCtr As Integer
        Dim wsDes As String
        Dim wsExcRat As String

        Chk_CusGrdRow = False

        On Error GoTo Chk_CusGrdRow_Err


        With tblCusItem
            If To_Value(LastRow) > waCusResult.get_UpperBound(1) Then
                Chk_CusGrdRow = True
                Exit Function
            End If

            If IsEmptyCusRow(To_Value(LastRow)) = True Then
                .Delete()
                'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                .Refresh()
                .Focus()
                Chk_CusGrdRow = False
                Exit Function
            End If

            If Chk_grdCusCode(waCusResult.get_Value(LastRow, CusCode), CStr(0), "", "") = False Then
                .Col = CusCode
                Exit Function
            End If

            If Chk_grdUOMCode(waCusResult.get_Value(LastRow, CUSUOMCODE)) = False Then
                .Col = CUSUOMCODE
                Exit Function
            End If

            If Chk_grdCusCurr(waCusResult.get_Value(LastRow, CUSCURR)) = False Then
                .Col = CUSCURR
                Exit Function
            End If

            If Chk_grdPrice(waCusResult.get_Value(LastRow, CUSPRICE)) = False Then
                .Col = CUSPRICE
                Exit Function
            End If

            If Chk_grdCnvFactor(waCusResult.get_Value(LastRow, CUSCNVFACTOR)) = False Then
                .Col = CUSCNVFACTOR
                Exit Function
            End If

        End With

        Chk_CusGrdRow = True

        Exit Function

Chk_CusGrdRow_Err:
        MsgBox("Check Chk_CusGrdRow")

    End Function
    Private Function Chk_VdrGrdRow(ByVal LastRow As Integer) As Boolean
        Dim wlCtr As Integer
        Dim wsDes As String
        Dim wsExcRat As String

        Chk_VdrGrdRow = False

        On Error GoTo Chk_VdrGrdRow_Err

        With tblDetail
            If To_Value(LastRow) > waResult.get_UpperBound(1) Then
                Chk_VdrGrdRow = True
                Exit Function
            End If

            If IsEmptyVdrRow(To_Value(LastRow)) = True Then
                .Delete()
                'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                .Refresh()
                .Focus()
                Chk_VdrGrdRow = False
                Exit Function
            End If

            If Chk_grdVdrCode(waResult.get_Value(LastRow, VDRCODE), CStr(0), "", "", 0) = False Then
                .Col = VDRCODE
                Exit Function
            End If

            If Chk_grdUOMCode(waResult.get_Value(LastRow, UOMCODE)) = False Then
                .Col = UOMCODE
                Exit Function
            End If

            If Chk_grdVdrCurr(waResult.get_Value(LastRow, VDRCURR), 0) = False Then
                .Col = VDRCURR
                Exit Function
            End If

            If Chk_grdPrice(waResult.get_Value(LastRow, Price)) = False Then
                .Col = Price
                Exit Function
            End If

            If Chk_grdCnvFactor(waResult.get_Value(LastRow, CNVFACTOR)) = False Then
                .Col = CNVFACTOR
                Exit Function
            End If

            If Chk_grdPrice(waResult.get_Value(LastRow, DISCOUNT)) = False Then
                .Col = DISCOUNT
                Exit Function
            End If


        End With


        Chk_VdrGrdRow = True

        Exit Function

Chk_VdrGrdRow_Err:
        MsgBox("Check Chk_VdrGrdRow")

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

                Me.tblDetail.Enabled = False
                Me.tblCusItem.Enabled = False

            Case "AfrActAdd"

                Me.cboITMCODE.Enabled = True

            Case "AfrActEdit"

                Me.cboITMCODE.Enabled = True

            Case "AfrKey"
                Me.cboITMCODE.Enabled = False

                If wiAction = CorRec Then
                    Me.tblDetail.Enabled = True
                    Me.tblCusItem.Enabled = True
                End If
        End Select
    End Sub

    Private Function Load_ItemPrice(ByRef inItmCode As String, ByRef outUOMCode As String, ByRef outPrice As Double) As Boolean
        Dim wsSQL As String
        Dim rsDes As New ADODB.Recordset


        wsSQL = "SELECT ItmUOMCode, ItmUnitPrice FROM MstItem"
        wsSQL = wsSQL & " WHERE ItmCode = '" & Set_Quote(inItmCode) & "'"

        rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outUOMCode = ReadRs(rsDes, "ItmUOMCode")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outPrice = ReadRs(rsDes, "ItmUnitPrice")


            Load_ItemPrice = True
        Else
            outUOMCode = ""
            outPrice = 0

            gsMsg = "沒有此物料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Load_ItemPrice = False
        End If
        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing
    End Function

    Private Function Chk_NoVdrDup(ByRef inRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsCurRec As String
        Dim wsCurRecLn As String
        Chk_NoVdrDup = False

        wsCurRec = tblDetail.Columns(VDRCODE).Text
        wsCurRecLn = tblDetail.Columns(VDRCURR).Text

        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If wsCurRec = waResult.get_Value(wlCtr, VDRCODE) And wsCurRecLn = waResult.get_Value(wlCtr, VDRCURR) Then
                    gsMsg = "供應商或貨幣已重覆!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    Exit Function
                End If
            End If
        Next

        Chk_NoVdrDup = True

    End Function

    Private Function Chk_NoCusDup(ByRef inRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsCurRec As String
        Dim wsCurRecLn As String
        Chk_NoCusDup = False

        wsCurRec = tblCusItem.Columns(CusCode).Text
        wsCurRecLn = tblCusItem.Columns(CUSCURR).Text

        For wlCtr = 0 To waCusResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If wsCurRec = waCusResult.get_Value(wlCtr, CusCode) And wsCurRecLn = waCusResult.get_Value(wlCtr, CUSCURR) Then
                    gsMsg = "客戶或貨幣已重覆!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    Exit Function
                End If
            End If
        Next

        Chk_NoCusDup = True

    End Function

    Private Sub Ini_Data()
        If wsITMCODE <> "" Then
            cboITMCODE.Text = wsITMCODE
            If cboITMCODE.Enabled = True Then
                System.Windows.Forms.SendKeys.Send("{ENTER}")
            End If
        End If
    End Sub


    Public Sub mnuCPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCPopUpSub.Click
        Dim Index As Short = mnuCPopUpSub.GetIndex(eventSender)
        Call Call_CPopUpMenu(waPopUpSub, Index)
    End Sub

    Public Sub mnuVPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuVPopUpSub.Click
        Dim Index As Short = mnuVPopUpSub.GetIndex(eventSender)
        Call Call_VPopUpMenu(waPopUpSub, Index)
    End Sub

    Private Sub Call_CPopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)

        Dim wsAct As String

        wsAct = inArray.get_Value(inMnuIdx, 0)

        With tblCusItem
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

                    If .Bookmark = waCusResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyCusRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waCusResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case Else
                    Exit Sub


            End Select

        End With


    End Sub

    Private Sub Call_VPopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)

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
                    If IsEmptyVdrRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case Else
                    Exit Sub


            End Select

        End With


    End Sub
	
	
	
	Private Sub OpenPromptForm()
		Dim wsOutCode As String
		Dim wsSQL As String
		
		Dim vFilterAry(3, 2) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 1) = IIf(gsLangID = "1", "Item Code", "物料編碼")
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "ItmCode"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = IIf(gsLangID = "1", "Description", "物料名稱")
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = IIf(gsLangID = "1", "ItmEngName", "ItmChiName")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 1) = IIf(gsLangID = "1", "Item Type", "物料分類")
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 2) = "ItmItmTypeCode"
		
		
		Dim vAry(3, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = IIf(gsLangID = "1", "Item Code", "物料編碼")
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "ItmCode"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "2500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = IIf(gsLangID = "1", "Description", "物料名稱")
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = IIf(gsLangID = "1", "ItmEngName", "ItmChiName")
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "2500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 1) = IIf(gsLangID = "1", "Item Type", "物料分類")
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 2) = "ItmItmTypeCode"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 3) = "2500"
		
		
		wsSQL = "SELECT ItmCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & ", ItmItmTypeCode "
		wsSQL = wsSQL & "FROM MstItem, MstVdrItem, MstVendor "
		
		
		'frmShareSearch.Show vbModal
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE ItmStatus = '1' AND VdrItemStatus = '1' AND VdrItemItmID = ItmID AND VdrItemVdrID = VdrID "
			.sBindOrderSQL = "ORDER BY ItmCode, VdrCode "
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmIP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		If Trim(frmShareSearch.Tag) <> "" And frmShareSearch.Tag <> cboITMCODE.Text Then
			cboITMCODE.Text = frmShareSearch.Tag
			If cboITMCODE.Enabled = False Then
				LoadRecord()
				'txtItmBarCode.Text = ""
				'txtItmCode.SetFocus
			Else
				cboITMCODE.Focus()
				System.Windows.Forms.SendKeys.Send("{Enter}")
			End If
		End If
		frmShareSearch.Close()
		
	End Sub
End Class