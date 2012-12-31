Option Strict Off
Option Explicit On
Friend Class frmAPW0011
	Inherits System.Windows.Forms.Form
	
	
	
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	
	Private wcCombo As System.Windows.Forms.Control
	Private wlItmID As Integer
	Private wlVdrID As Integer
	Private wsJCurr As String
	Private wdJExcr As Double
	
	
	Private wsDocLine As String
	
	Private wsBaseCurCd As String
	
	'variable for new property
	Private mlKeyID As Integer
	Private wlSoPtjID As Integer
	
	Private mbResult As Boolean
	
	WriteOnly Property KeyID() As Integer
		Set(ByVal Value As Integer)
			
			mlKeyID = Value
			
		End Set
	End Property
	
	
	ReadOnly Property Result() As Boolean
		Get
			
			Result = mbResult
			
		End Get
	End Property
	
	
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
		
		
		Call Load_JobInfo()
		txtUnitPrice.Text = VB6.Format("0", gsUprFmt)
		txtQty.Text = VB6.Format("0", gsQtyFmt)
		txtMU.Text = VB6.Format("1", gsAmtFmt)
		txtAmt.Text = VB6.Format("0", gsAmtFmt)
		txtNet.Text = VB6.Format("0", gsAmtFmt)
		
		wlSoPtjID = 0
		wlItmID = 0
		wlVdrID = 0
		
		
		tblCommon.Visible = False
		txtUnitPrice.ReadOnly = True
		
		FocusMe(cboDocLine)
		
		
	End Sub
	
	
	
	
	
	
	
	
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub
	
	Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
		
		If cmdSave = False Then Exit Sub
		
		mbResult = True
		Ini_Scr()
		cboDocLine.Text = wsDocLine
		cboItmType.Focus()
		
		
	End Sub
	
	Private Sub frmAPW0011_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	
	
	Private Sub frmAPW0011_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		
		
		
	End Sub
	
	
	
	Private Sub Ini_Form()
		
		Me.KeyPreview = True
		wsFormID = "APW0011"
		wsBaseCurCd = Get_CompanyFlag("CMPCURR")
		mbResult = False
		
		
	End Sub
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		Me.Text = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		lblDocLine.Text = Get_Caption(waScrItm, "DOCLINE")
		lblItmType.Text = Get_Caption(waScrItm, "ITMTYPE")
		lblItmCode.Text = Get_Caption(waScrItm, "ITMCODE")
		lblVdrCode.Text = Get_Caption(waScrItm, "VDRCODE")
		lblItmName.Text = Get_Caption(waScrItm, "ITMNAME")
		lblQty.Text = Get_Caption(waScrItm, "QTY")
		lblUnitPrice.Text = Get_Caption(waScrItm, "UNITPRICE")
		lblMU.Text = Get_Caption(waScrItm, "MU")
		lblAmt.Text = Get_Caption(waScrItm, "AMT")
		lblNet.Text = Get_Caption(waScrItm, "NET")
		
		
		btnOK.Text = Get_Caption(waScrItm, "OK")
		btnCancel.Text = Get_Caption(waScrItm, "CANCEL")
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
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
	
	
	
	Private Sub cboDocLine_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocLine.Enter
		FocusMe(cboDocLine)
	End Sub
	
	Private Sub cboDocLine_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocLine.Leave
		FocusMe(cboDocLine, True)
	End Sub
	
	
	Private Sub cboDocLine_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocLine.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'Dim wsDesc As String
		
		Call chk_InpLen(cboDocLine, 3, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboDocLine = False Then
				GoTo EventExitSub
			End If
			
			cboItmType.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboDocLine_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocLine.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocLine
		
		wsSQL = "SELECT CONVERT(NVARCHAR(5), REPLICATE('0',3 - LEN(LTRIM(CONVERT(NVARCHAR(3),SOPTJDOCLINE))))  + CONVERT(NVARCHAR(3),SOPTJDOCLINE)), SOPTJDESC1 "
		wsSQL = wsSQL & "FROM SOASOPTJ "
		wsSQL = wsSQL & "WHERE SOPTJDOCID = " & mlKeyID & " "
		wsSQL = wsSQL & "ORDER BY SOPTJDOCLINE "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboDocLine.Left)), VB6.PixelsToTwipsY(cboDocLine.Top) + VB6.PixelsToTwipsY(cboDocLine.Height), tblCommon, wsFormID, "TBLDOCLINE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboDocLine() As Boolean
        Dim wsDesc As String = ""
		
		Chk_cboDocLine = False
		
		If Trim(cboDocLine.Text) = "" Then
			gsMsg = "必需輸入物料行列!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocLine.Focus()
			Exit Function
		End If
		
		
		If Chk_DocLine(wsDesc) = False Then
			gsMsg = "沒有此物料行列!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocLine.Focus()
			lblDspDocLine.Text = ""
			Exit Function
		End If
		
		lblDspDocLine.Text = wsDesc
		
		Chk_cboDocLine = True
		
	End Function
	
	
	
	
	Private Sub cboItmType_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmType.Enter
		FocusMe(cboItmType)
	End Sub
	
	Private Sub cboItmType_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmType.Leave
		FocusMe(cboItmType, True)
	End Sub
	
	
	Private Sub cboItmType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmType.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'Dim wsDesc As String
		
		Call chk_InpLen(cboItmType, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboItmType = False Then
				GoTo EventExitSub
			End If
			
			cboITMCODE.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmType_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmType.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmType
		
		wsSQL = "SELECT ITMTYPECODE, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC") & " FROM MSTITEMTYPE WHERE ITMTYPECODE LIKE '%" & IIf(cboItmType.SelectionLength > 0, "", Set_Quote(cboItmType.Text)) & "%' "
		wsSQL = wsSQL & "AND ITMTYPESTATUS = '1' "
		wsSQL = wsSQL & "ORDER BY ITMTYPECODE "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmType.Left)), VB6.PixelsToTwipsY(cboItmType.Top) + VB6.PixelsToTwipsY(cboItmType.Height), tblCommon, wsFormID, "TBLITMTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboItmType() As Boolean
        Dim wsDesc As String = ""
		
		Chk_cboItmType = False
		
		If Trim(cboItmType.Text) = "" Then
			gsMsg = "必需輸入物料分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboItmType.Focus()
			Exit Function
		End If
		
		
		If Chk_ItemType(cboItmType.Text, wsDesc) = False Then
			gsMsg = "沒有此物料分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboItmType.Focus()
			lblDspItmType.Text = ""
			Exit Function
		End If
		
		lblDspItmType.Text = wsDesc
		
		Chk_cboItmType = True
		
	End Function
	
	
	Private Sub cboItmCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Enter
		FocusMe(cboITMCODE)
	End Sub
	
	Private Sub cboItmCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Leave
		FocusMe(cboITMCODE, True)
	End Sub
	
	
	Private Sub cboItmCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim wsDesc As String = ""
		Dim wdPrice As Double
		
		
		Call chk_InpLen(cboITMCODE, 30, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboItmCode(wsDesc, wdPrice) = False Then
				GoTo EventExitSub
			End If
			
			txtItmName.Text = wsDesc
			wdPrice = get_ItemSalePrice(CStr(wlItmID), CStr(wlVdrID), wsJCurr, wdJExcr)
			txtUnitPrice.Text = VB6.Format(wdPrice, gsUprFmt)
			
			If Trim(cboVdrCode.Text) = "" Then
				cboVdrCode.Focus()
			Else
				txtQty.Focus()
			End If
			
			Call Cal_Total()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboITMCODE
		
		wsSQL = "SELECT ITMCODE, ITMITMTYPECODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME, STR(ITMDEFAULTPRICE,13,2) FROM mstITEM "
		wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(cboITMCODE.Text) & "%' "
		wsSQL = wsSQL & " AND ITMITMTYPECODE =  '" & Set_Quote(cboItmType.Text) & "' "
		wsSQL = wsSQL & " ORDER BY ITMCODE "
		
		
		Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboITMCODE.Left)), VB6.PixelsToTwipsY(cboITMCODE.Top) + VB6.PixelsToTwipsY(cboITMCODE.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboItmCode(ByRef OutName As String, ByRef outPrice As Double) As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		Dim wsCurr As String
        Dim wsExcr As String = ""
		
		
		If Trim(cboITMCODE.Text) = "" Then
			gsMsg = "沒有輸入物料號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_cboItmCode = False
			lblDspItmCode.Text = ""
			Exit Function
		End If
		
		
		wsSQL = "SELECT ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME, ITMPVDRID, ITMDEFAULTPRICE, ITMCURR FROM MSTITEM "
		wsSQL = wsSQL & " WHERE ITMCODE = '" & Set_Quote(cboITMCODE.Text) & "' AND ITMITMTYPECODE = '" & Set_Quote(cboItmType.Text) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlItmID = ReadRs(rsRcd, "ITMID")
			wlVdrID = To_Value(ReadRs(rsRcd, "ITMPVDRID"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspItmCode.Text = ReadRs(rsRcd, "ITNAME")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutName = ReadRs(rsRcd, "ITNAME")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsCurr = ReadRs(rsRcd, "ITMCURR")
			outPrice = To_Value(ReadRs(rsRcd, "ITMDEFAULTPRICE"))
			
			If wsCurr <> wsJCurr Then
				
				If getExcRate(wsCurr, gsSystemDate, wsExcr, "") = False Then
					wsExcr = "0"
				End If
				
				If To_Value(wdJExcr) = 0 Then
					outPrice = outPrice * To_Value(wsExcr)
				Else
					outPrice = outPrice * To_Value(wsExcr) / To_Value(wdJExcr)
				End If
				
			End If
			
			
			
			Chk_cboItmCode = True
		Else
			wlItmID = 0
			wlVdrID = 0
			lblDspItmCode.Text = ""
			wsCurr = wsBaseCurCd
			txtUnitPrice.Text = VB6.Format("0", gsUprFmt)
			OutName = ""
			gsMsg = "沒有此物料!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboITMCODE.Focus()
			Chk_cboItmCode = False
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		If wlVdrID = 0 Then
			
			wsSQL = "SELECT VdrItemVdrID VID, VdrCode, VdrName "
			wsSQL = wsSQL & " FROM MstVdrItem, MstVendor "
			wsSQL = wsSQL & " WHERE VdrItemItmID = " & wlItmID
			wsSQL = wsSQL & " AND VdrItemStatus = '1' "
			wsSQL = wsSQL & " AND VdrItemVdrID = VdrID "
			wsSQL = wsSQL & " Order By VdrItemCostl "
			
		Else
			
			wsSQL = "SELECT VdrID VID, VdrCode, VdrName "
			wsSQL = wsSQL & " FROM MstVendor "
			wsSQL = wsSQL & " WHERE VdrID = " & wlVdrID
			
		End If
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlVdrID = ReadRs(rsRcd, "VID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboVdrCode.Text = ReadRs(rsRcd, "VdrCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspVdrCode.Text = ReadRs(rsRcd, "VdrName")
			
		Else
			
			wlVdrID = 0
			cboVdrCode.Text = ""
			lblDspVdrCode.Text = ""
			
		End If
		
		
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	
	
	Private Sub cboVdrCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.Enter
		FocusMe(cboVdrCode)
	End Sub
	
	Private Sub cboVdrCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.Leave
		FocusMe(cboVdrCode, True)
	End Sub
	
	
	Private Sub cboVdrCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wdPrice As Double
		
		Call chk_InpLen(cboVdrCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboVdrCode = False Then
				GoTo EventExitSub
			End If
			
			wdPrice = get_ItemSalePrice(CStr(wlItmID), CStr(wlVdrID), wsJCurr, wdJExcr)
			txtUnitPrice.Text = VB6.Format(wdPrice, gsUprFmt)
			txtQty.Focus()
			
			Call Cal_Total()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboVdrCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboVdrCode
		
		wsSQL = "SELECT VDRCODE, VDRNAME FROM MSTVENDOR "
		wsSQL = wsSQL & " WHERE VDRSTATUS <> '2' AND VDRCODE LIKE '%" & Set_Quote(cboVdrCode.Text) & "%' "
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY VDRCODE "
		
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboVdrCode.Left)), VB6.PixelsToTwipsY(cboVdrCode.Top) + VB6.PixelsToTwipsY(cboVdrCode.Height), tblCommon, wsFormID, "TBLVDRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function chk_cboVdrCode() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		
		If Trim(cboVdrCode.Text) = "" Then
			gsMsg = "沒有輸入供應商!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			chk_cboVdrCode = False
			lblDspVdrCode.Text = ""
			Exit Function
		End If
		
		
		wsSQL = "SELECT VdrID, VdrCode, VdrName "
		wsSQL = wsSQL & " FROM MstVendor "
		wsSQL = wsSQL & " WHERE VdrCode = '" & Set_Quote(cboVdrCode.Text) & "'"
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			wlVdrID = To_Value(ReadRs(rsRcd, "VdrID"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspVdrCode.Text = ReadRs(rsRcd, "VdrName")
			chk_cboVdrCode = True
			
		Else
			wlVdrID = 0
			lblDspVdrCode.Text = ""
			gsMsg = "沒有此供應商!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboVdrCode.Focus()
			chk_cboVdrCode = False
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
	
	
	Private Sub txtItmName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmName.Enter
		FocusMe(txtItmName)
	End Sub
	
	Private Sub txtItmName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmName.Leave
		FocusMe(txtItmName, True)
	End Sub
	
	
	Private Sub txtItmName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLen(txtItmName, 60, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			txtQty.Focus()
			
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub txtQty_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQty.Enter
		
		FocusMe(txtQty)
		
	End Sub
	
	Private Sub txtQty_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtQty.Text), False, False)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Chk_txtQty Then
				
				txtMU.Focus()
				
				Call Cal_Total()
				
			End If
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function Chk_txtQty() As Boolean
		
		Chk_txtQty = False
		
		
		If To_Value((txtQty.Text)) <= 0 Then
			gsMsg = "Qty Must > 0 !"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtQty.Focus()
			Exit Function
		End If
		
		txtQty.Text = VB6.Format(txtQty.Text, gsQtyFmt)
		
		Chk_txtQty = True
		
	End Function
	
	
	Private Sub txtQty_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQty.Leave
		FocusMe(txtQty, True)
	End Sub
	
	
	Private Sub txtMU_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMU.Enter
		
		FocusMe(txtMU)
		
	End Sub
	
	Private Sub txtMU_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtMU.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtMU.Text), False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Chk_txtMU Then
				
				txtAmt.Focus()
				
				Call Cal_Total()
				
			End If
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function Chk_txtMU() As Boolean
		
		Chk_txtMU = False
		
		
		If To_Value((txtMU.Text)) < 0 Then
			gsMsg = "Qty Must > 0 !"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtMU.Focus()
			Exit Function
		End If
		
		txtMU.Text = VB6.Format(txtMU.Text, gsAmtFmt)
		
		Chk_txtMU = True
		
	End Function
	
	
	Private Sub txtMU_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMU.Leave
		FocusMe(txtMU, True)
	End Sub
	
	
	Private Sub txtAmt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAmt.Enter
		
		FocusMe(txtAmt)
		
	End Sub
	
	Private Sub txtAmt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtAmt.Text), False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			txtNet.Focus()
			
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub txtAmt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAmt.Leave
		txtAmt.Text = VB6.Format(txtAmt.Text, gsAmtFmt)
		FocusMe(txtAmt, True)
	End Sub
	
	
	Private Sub txtNet_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNet.Enter
		
		FocusMe(txtNet)
		
	End Sub
	
	Private Sub txtNet_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNet.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtNet.Text), False, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			btnOK.Focus()
			
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub txtNet_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNet.Leave
		txtNet.Text = VB6.Format(txtNet.Text, gsAmtFmt)
		FocusMe(txtNet, True)
	End Sub
	
	Private Sub Load_JobInfo()
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		wsSQL = "SELECT SOHDDOCNO, SOHDCURR, SOHDEXCR  "
		wsSQL = wsSQL & " FROM SOASOHD "
		wsSQL = wsSQL & " WHERE SOHDDOCID = " & To_Value(mlKeyID) & " "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsJCurr = ReadRs(rsRcd, "SOHDCURR")
			wdJExcr = To_Value(ReadRs(rsRcd, "SOHDEXCR"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspDocNo.Text = ReadRs(rsRcd, "SOHDDOCNO")
			'    lblDspDocLine.Caption = Format(ReadRs(rsRcd, "SOPTJDOCLINE"), "000") & ": " & ReadRs(rsRcd, "SOPTJDESC1")
			
		Else
			wsJCurr = wsBaseCurCd
			wdJExcr = 1
			lblDspDocNo.Text = ""
			'   lblDspDocLine.Caption = ""
		End If
		
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Sub
	
	
	Private Sub Cal_Total()
		
		txtAmt.Text = VB6.Format(To_Value(txtUnitPrice) * To_Value(txtQty), gsAmtFmt)
		txtNet.Text = VB6.Format(To_Value(txtUnitPrice) * To_Value(txtQty) / To_Value(txtMU), gsAmtFmt)
		
		
		
	End Sub
	
	
	Private Function InputValidation() As Boolean
		
		
		InputValidation = False
		
		On Error GoTo InputValidation_Err
		
		
		If Not Chk_cboDocLine Then Exit Function
		If Not Chk_cboItmType Then Exit Function
		If Not Chk_cboItmCode("", 0) Then Exit Function
		If Not chk_cboVdrCode Then Exit Function
		If Not Chk_txtQty Then Exit Function
		If Not Chk_txtMU Then Exit Function
		
		InputValidation = True
		
		Exit Function
		
InputValidation_Err: 
		gsMsg = Err.Description
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
	End Function
	Private Function cmdSave() As Boolean
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wsUpdFlg As String
		
		On Error GoTo cmdSave_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Function
		End If
		
		
		gsMsg = "你是否要更新項目售價?"
		If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
			wsUpdFlg = "Y"
		Else
			wsUpdFlg = "N"
		End If
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_APW0011A"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, wlSoPtjID)
		Call SetSPPara(adcmdSave, 2, wlItmID)
		Call SetSPPara(adcmdSave, 3, wlVdrID)
		Call SetSPPara(adcmdSave, 4, txtItmName)
		Call SetSPPara(adcmdSave, 5, txtUnitPrice)
		Call SetSPPara(adcmdSave, 6, txtQty)
		Call SetSPPara(adcmdSave, 7, txtMU)
		Call SetSPPara(adcmdSave, 8, txtAmt)
		Call SetSPPara(adcmdSave, 9, txtNet)
		Call SetSPPara(adcmdSave, 10, wsUpdFlg)
		
		adcmdSave.Execute()
		
		
		cnCon.CommitTrans()
		
		
		gsMsg = "物料已儲存!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		cmdSave = True
		wsDocLine = cboDocLine.Text
		
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Function
		
cmdSave_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
	End Function
	
	
	Private Function Chk_DocLine(ByRef OutName As String) As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
        'Dim wsCurr As String
        'Dim wsExcr As String
		
		
		If Trim(cboDocLine.Text) = "" Then
			gsMsg = "沒有輸入物料行列!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_DocLine = False
			wlSoPtjID = 0
			lblDspDocLine.Text = ""
			Exit Function
		End If
		
		
		wsSQL = "SELECT SOPTJID, SOPTJDESC1 FROM SOASOPTJ "
		wsSQL = wsSQL & " WHERE SOPTJDOCLINE = " & To_Value((cboDocLine.Text)) & " AND SOPTJDOCID = " & To_Value(mlKeyID) & " "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlSoPtjID = ReadRs(rsRcd, "SOPTJID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutName = ReadRs(rsRcd, "SOPTJDESC1")
			
			
			Chk_DocLine = True
		Else
			wlSoPtjID = 0
			OutName = ""
			Chk_DocLine = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
End Class