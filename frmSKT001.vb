Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSKT001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	Private wbReadOnly As Boolean
	Private wgsTitle As String
	Private wsSrcCode As String
	Private wsTrnType As String
	
	Private Const LINENO As Short = 0
	Private Const ITMTYPE As Short = 1
	Private Const ITMCODE As Short = 2
	Private Const BARCODE As Short = 3
	Private Const ITMNAME As Short = 4
	Private Const LOTNO As Short = 5
	Private Const WHSCODE As Short = 6
	Private Const SOH As Short = 7
	Private Const PRICE As Short = 8
	Private Const QTY As Short = 9
	Private Const ADJ As Short = 10
	Private Const ITMID As Short = 11
	Private Const SOID As Short = 12
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	Private Const tcRefresh As String = "Refresh"
	Private Const tcPrint As String = "Print"
	
	Private wiOpenDoc As Short
	Private wiAction As Short
	Private wlCusID As Integer
	Private wlSaleID As Integer
	Private wlLineNo As Integer
	
	Private wgsSMTitle As String
	Private wgsDMTitle As String
	Private wgsTRTitle As String
	Private wgsAJTitle As String
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "icSTKADJ"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, LINENO, SOID)
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
		
		Call SetButtonStatus("Default")
		Call SetFieldStatus("Default")
		Call SetFieldStatus("AfrActEdit")
		
		Call SetDateMask(medDocDate)
		
		
		
		wlKey = 0
		wlSaleID = 0
		wlLineNo = 1
		wbReadOnly = False
		tblCommon.Visible = False
		
		Me.Text = wsFormCaption
	End Sub
	
	Private Sub cboDocNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.Enter
		FocusMe(cboDocNo)
	End Sub
	
	Private Sub cboDocNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNo
		
		wsSQL = "SELECT SJHDDOCNO, SJHDREMARK, SJHDDOCDATE "
		wsSQL = wsSQL & " FROM ICSTKADJ "
		wsSQL = wsSQL & " WHERE SJHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
		wsSQL = wsSQL & " AND SJHDSTATUS = '1' "
		wsSQL = wsSQL & " AND SJHDTRNCODE  = '" & wsTrnCd & "' "
		wsSQL = wsSQL & " ORDER BY SJHDDOCNO DESC "
		
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboDocNo.Left)), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboDocNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.Leave
		FocusMe(cboDocNo, True)
	End Sub
	
	Private Sub cboDocNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLenA(cboDocNo, 15, KeyAscii, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			
			If Chk_cboDocNo() = False Then GoTo EventExitSub
			
			Call Ini_Scr_AfrKey()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function Chk_cboDocNo() As Boolean
		Dim wsStatus As String
		
		Chk_cboDocNo = False
		
		If Trim(cboDocNo.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
			gsMsg = "必需輸入文件號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNo.Focus()
			Exit Function
		End If
		
		If Chk_TrnHdDocNo(wsTrnCd, cboDocNo.Text, wsStatus) = True Then
			
			If wsStatus = "4" Then
				gsMsg = "文件已入數, 現在以唯讀模式開啟!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				wbReadOnly = True
			End If
			
			If wsStatus = "2" Then
				gsMsg = "文件已刪除, 現在以唯讀模式開啟!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				wbReadOnly = True
			End If
			
			If wsStatus = "3" Then
				gsMsg = "文件已無效, 現在以唯讀模式開啟!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				wbReadOnly = True
			End If
		End If
		
		Chk_cboDocNo = True
		
	End Function
	
	Private Sub Ini_Scr_AfrKey()
		
		If LoadRecord() = False Then
			wiAction = AddRec
			medDocDate.Text = Dsp_Date(Now)
			
			Call SetButtonStatus("AfrKeyAdd")
			Call SetFieldStatus("AfrKey")
			cboMLCode.Text = Get_CompanyFlag("CmpAdjMLCode")
			cboSaleCode.Focus()
		Else
			wiAction = CorRec
			If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
				gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				tblDetail.ReBind()
			End If
			
			Call SetButtonStatus("AfrKeyEdit")
			Call SetFieldStatus("AfrKey")
			cboSaleCode.Focus()
		End If
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
	End Sub
	
	
	
	Private Sub cboMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCode.Enter
		FocusMe(cboMLCode)
	End Sub
	
	Private Sub cboMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCode.Leave
		FocusMe(cboMLCode, True)
	End Sub
	
	
	Private Sub cboMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboMLCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsDesc As String
		
		Call chk_InpLen(cboMLCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_KeyFld = False Then
				GoTo EventExitSub
			End If
			
			txtRmk.Focus()
			
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMLCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboMLCode
		
		wsSQL = "SELECT MLCode, MLDESC FROM mstMerchClass "
		wsSQL = wsSQL & " WHERE MLCode LIKE '%" & IIf(cboMLCode.SelectionLength > 0, "", Set_Quote(cboMLCode.Text)) & "%' "
		wsSQL = wsSQL & " AND MLSTATUS = '1' "
		wsSQL = wsSQL & " AND MLTYPE = 'G' "
		wsSQL = wsSQL & "ORDER BY MLCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboMLCode.Left)), VB6.PixelsToTwipsY(cboMLCode.Top) + VB6.PixelsToTwipsY(cboMLCode.Height), tblCommon, wsFormID, "TBLMLCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboMLCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboMLCode = False
		
		If Trim(cboMLCode.Text) = "" Then
			gsMsg = "必需輸入會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboMLCode.Focus()
			Exit Function
		End If
		
		
		If Chk_MLClass(cboMLCode.Text, "G", wsDesc) = False Then
			gsMsg = "沒有此會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboMLCode.Focus()
			lblDspMLDesc.Text = ""
			Exit Function
		End If
		
		lblDspMLDesc.Text = wsDesc
		
		Chk_cboMLCode = True
		
	End Function
	
	Private Sub cboWhsCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWhsCodeFr
		
		wsSQL = "SELECT WhsCode , WhsDesc FROM MstWareHouse WHERE WhsStatus = '1' "
		wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeFr.SelectionLength > 0, "", Set_Quote(cboWhsCodeFr.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY WhsCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboWhsCodeFr.Left)), VB6.PixelsToTwipsY(cboWhsCodeFr.Top) + VB6.PixelsToTwipsY(cboWhsCodeFr.Height), tblCommon, wsFormID, "TBLWHSCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboWhsCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Enter
		FocusMe(cboWhsCodeFr)
	End Sub
	
	Private Sub cboWhsCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWhsCodeFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboWhsCodeFr() = False Then
				GoTo EventExitSub
			End If
			
			cboScNo.Focus()
			
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWhsCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Leave
		FocusMe(cboWhsCodeFr, True)
	End Sub
	
	'UPGRADE_WARNING: Form event frmSKT001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmSKT001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboDocNo
			Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
		End If
		
	End Sub
	
	Private Sub frmSKT001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.PageDown
				KeyCode = 0
			Case System.Windows.Forms.Keys.PageUp
				KeyCode = 0
			Case System.Windows.Forms.Keys.F6
				Call cmdOpen()
				
			Case System.Windows.Forms.Keys.F2
				If wiAction = DefaultPage Then Call cmdNew()
				
			Case System.Windows.Forms.Keys.F7
				
				If tbrProcess.Items.Item(tcRefresh).Enabled = True Then Call cmdRefresh()
				
			Case System.Windows.Forms.Keys.F3
				If wiAction = DefaultPage Then Call cmdDel()
				
			Case System.Windows.Forms.Keys.F9
				
				If tbrProcess.Items.Item(tcFind).Enabled = True Then Call cmdFind()
				
			Case System.Windows.Forms.Keys.F10
				
				If tbrProcess.Items.Item(tcSave).Enabled = True Then Call cmdSave()
				
			Case System.Windows.Forms.Keys.F11
				
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub frmSKT001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Grid()
		Call Ini_Caption()
		Call Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function LoadRecord() As Boolean
		Dim rsInvoice As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsExcRate As String
		Dim wsExcDesc As String
		Dim wiCtr As Integer
		
		LoadRecord = False
		
		wsSQL = "SELECT SJHDDOCID, SJHDDOCNO, SJHDDOCDATE, SJDTDOCLINE, SJHDSTAFFID, SJHDREMARK, SJHDREMARK2,SJHDREMARK3, "
		wsSQL = wsSQL & "SJDTITEMID, ITMCODE, SJDTWHSCODE, SJDTLOTNO, ITMITMTYPECODE, ITMBARCODE, SJHDMLCODE, "
		wsSQL = wsSQL & "ITMCHINAME ITNAME, SJDTUPRICE, SJDTQTY, SJDTTRNQTY, SJDTAMT, "
		wsSQL = wsSQL & "SJDTTRNAMT, SALECODE, SALENAME, SJHDTRNCODE, SJDTTRNTYPE, SJDTONHAND, SJDTCOUNTED, "
		wsSQL = wsSQL & "SCHDDOCNO "
		wsSQL = wsSQL & "FROM ICSTKADJ, ICSTKADJDT, MSTSALESMAN, MSTITEM, ICSTKCNT "
		wsSQL = wsSQL & "WHERE SJHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
		wsSQL = wsSQL & "AND SJHDDOCID = SJDTDOCID "
		wsSQL = wsSQL & "AND SJHDSTAFFID *= SALEID "
		wsSQL = wsSQL & "AND SJDTITEMID = ITMID "
		wsSQL = wsSQL & "AND SJHDSCID *= SCHDDOCID "
		wsSQL = wsSQL & "AND SJHDTRNCODE  = '" & wsTrnCd & "' "
		wsSQL = wsSQL & "ORDER BY SJDTTRNTYPE, SJDTDOCLINE "
		'wsSQL = wsSQL & "ORDER BY ITMCODE, SJDTWHSCODE, SJDTLOTNO "
		
		
		rsInvoice.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsInvoice.RecordCount <= 0 Then
			rsInvoice.Close()
			'UPGRADE_NOTE: Object rsInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsInvoice = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = ReadRs(rsInvoice, "SJHDDOCID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		medDocDate.Text = ReadRs(rsInvoice, "SJHDDOCDATE")
		
		wlSaleID = To_Value(ReadRs(rsInvoice, "SJHDSTAFFID"))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboSaleCode.Text = ReadRs(rsInvoice, "SALECODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspSaleDesc.Text = ReadRs(rsInvoice, "SALENAME")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboWhsCodeFr.Text = ReadRs(rsInvoice, "SJDTWHSCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboMLCode.Text = ReadRs(rsInvoice, "SJHDMLCODE")
		lblDspMLDesc.Text = Get_TableInfo("MstMerchClass", "MLCODE = '" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRmk.Text = ReadRs(rsInvoice, "SJHDREMARK")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRmk2.Text = ReadRs(rsInvoice, "SJHDREMARK2")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRmk3.Text = ReadRs(rsInvoice, "SJHDREMARK3")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboScNo.Text = ReadRs(rsInvoice, "SCHDDOCNO")
		
		
		rsInvoice.MoveFirst()
		
		With waResult
			.ReDim(0, -1, LINENO, SOID)
			Do While Not rsInvoice.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), LINENO) = ReadRs(rsInvoice, "SJDTDOCLINE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsInvoice, "ITMCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), BARCODE) = ReadRs(rsInvoice, "ITMBARCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), ITMNAME) = ReadRs(rsInvoice, "ITNAME")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), ITMTYPE) = ReadRs(rsInvoice, "ITMITMTYPECODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), LOTNO) = ReadRs(rsInvoice, "SJDTLOTNO")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), SOH) = VB6.Format(ReadRs(rsInvoice, "SJDTONHAND"), gsQtyFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), QTY) = VB6.Format(ReadRs(rsInvoice, "SJDTCOUNTED"), gsQtyFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), PRICE) = VB6.Format(ReadRs(rsInvoice, "SJDTUPRICE"), gsUprFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), ADJ) = VB6.Format(ReadRs(rsInvoice, "SJDTTRNQTY"), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsInvoice, "SJDTITEMID")
				rsInvoice.MoveNext()
			Loop 
			wlLineNo = waResult.get_Value(.get_UpperBound(1), LINENO) + 1
		End With
		
		tblDetail.ReBind()
		tblDetail.FirstRow = 0
		rsInvoice.Close()
		
		'UPGRADE_NOTE: Object rsInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsInvoice = Nothing
		
		Call Calc_Total()
		
		LoadRecord = True
		
	End Function
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
		lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
		lblSaleCode.Text = Get_Caption(waScrItm, "SALECODE")
		lblRmk.Text = Get_Caption(waScrItm, "REMARK")
		lblScNo.Text = Get_Caption(waScrItm, "SCNO")
		
		
		lblTrnAmt.Text = Get_Caption(waScrItm, "TRNAMT")
		lblTrnQty.Text = Get_Caption(waScrItm, "TRNQTY")
		
		
		
		'FRADOCTYPE.Caption = Get_Caption(waScrItm, "DOCTYPE")
		lblWhsCodeFr.Text = Get_Caption(waScrItm, "WHSCODEFR")
		
		With tblDetail
			.Columns(LINENO).Caption = Get_Caption(waScrItm, "LINENO")
			.Columns(ITMCODE).Caption = Get_Caption(waScrItm, "ITMCODE")
			.Columns(BARCODE).Caption = Get_Caption(waScrItm, "BARCODE")
			.Columns(ITMNAME).Caption = Get_Caption(waScrItm, "ITMNAME")
			.Columns(LOTNO).Caption = Get_Caption(waScrItm, "LOTNO")
			.Columns(SOH).Caption = Get_Caption(waScrItm, "SOH")
			.Columns(ITMTYPE).Caption = Get_Caption(waScrItm, "ITMTYPE")
			.Columns(PRICE).Caption = Get_Caption(waScrItm, "PRICE")
			.Columns(QTY).Caption = Get_Caption(waScrItm, "QTY")
			.Columns(ADJ).Caption = Get_Caption(waScrItm, "ADJ")
		End With
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F7)"
		tbrProcess.Items.Item(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint)
		
		wsActNam(1) = Get_Caption(waScrItm, "ADJADD")
		wsActNam(2) = Get_Caption(waScrItm, "ADJEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "ADJDELETE")
		
		wgsTitle = Get_Caption(waScrItm, "TITLE")
		wgsTRTitle = Get_Caption(waScrItm, "AJTITLE")
		
		Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Sub frmSKT001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		'    If Button = 2 Then
		'        PopupMenu mnuMaster
		'    End If
		
	End Sub
	
	'UPGRADE_WARNING: Event frmSKT001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmSKT001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(9000)
			Me.Width = VB6.TwipsToPixelsX(12000)
		End If
	End Sub
	
	Private Sub frmSKT001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        '    Set waPgmItm = Nothing
        'UPGRADE_NOTE: Object frmSKT001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub

    Private Sub medDocDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDocDate.Enter

        FocusMe(medDocDate)

    End Sub

    Private Sub medDocDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDocDate.Leave

        FocusMe(medDocDate, True)

    End Sub

    Private Sub medDocDate_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medDocDate.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then

            If Chk_medDocDate = False Then
                GoTo EventExitSub
            End If

            cboSaleCode.Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_medDocDate() As Boolean

        Chk_medDocDate = False

        If Trim(medDocDate.Text) = "/  /" Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medDocDate.Focus()
            Exit Function
        End If

        If Chk_Date(medDocDate) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medDocDate.Focus()
            Exit Function
        End If

        Chk_medDocDate = True

    End Function



    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        'If wcCombo.Name = tblDetail.Name Then
        '    tblDetail.EditActive = True
        '    'UPGRADE_WARNING: Couldn't resolve default property of object wcCombo.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    Select Case wcCombo.Col
        '        Case ITMCODE
        '            wcCombo.Text = tblCommon.Columns(0).Text
        '        Case Else
        '            wcCombo.Text = tblCommon.Columns(0).Text
        '    End Select
        'Else
        '    wcCombo.Text = tblCommon.Columns(0).Text
        'End If

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
            'If wcCombo.Name = tblDetail.Name Then
            '	tblDetail.EditActive = True
            '	'UPGRADE_WARNING: Couldn't resolve default property of object wcCombo.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	Select Case wcCombo.Col
            '		Case ITMCODE
            '			wcCombo.Text = tblCommon.Columns(0).Text
            '		Case Else
            '			wcCombo.Text = tblCommon.Columns(0).Text
            '	End Select
            'Else
            '	wcCombo.Text = tblCommon.Columns(0).Text
            'End If
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

    Private Function Chk_KeyExist() As Boolean

        Dim rsicStHD As New ADODB.Recordset
        Dim wsSQL As String


        wsSQL = "SELECT SJHDSTATUS FROM icStkAdj WHERE SJHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' AND SJHDTRNCODE  = '" & wsTrnCd & "' "
        rsicStHD.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsicStHD.RecordCount > 0 Then

            Chk_KeyExist = True

        Else

            Chk_KeyExist = False

        End If

        rsicStHD.Close()
        'UPGRADE_NOTE: Object rsicStHD may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsicStHD = Nothing

    End Function

    Private Function Chk_KeyFld() As Boolean

        Chk_KeyFld = False

        '   If Chk_cboSaleCode = False Then
        '       Exit Function
        '   End If

        If Chk_cboWhsCodeFr = False Then
            Exit Function
        End If

        If Chk_cboScNo = False Then
            Exit Function
        End If

        If Chk_medDocDate = False Then
            Exit Function
        End If

        If Chk_cboMLCode = False Then
            Exit Function
        End If

        tblDetail.Enabled = True
        Chk_KeyFld = True

    End Function

    Private Function cmdSave() As Boolean

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wlRowCtr As Integer
        Dim wsCtlPrd As String
        Dim wsSts As String
        Dim i As Short
        Dim wsTrnType As String
        Dim wdQty As Double


        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID) Or wbReadOnly Then
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

        '' Last Check when Add

        If wiAction = AddRec Then
            If Chk_KeyExist() = True Then
                Call GetNewKey()
            End If
        End If

        wlRowCtr = waResult.get_UpperBound(1)
        wsCtlPrd = VB.Left(medDocDate.Text, 4) & Mid(medDocDate.Text, 6, 2)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_IAJ001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wlKey)
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, Set_MedDate(medDocDate.Text))
        Call SetSPPara(adcmdSave, 6, wsCtlPrd)
        Call SetSPPara(adcmdSave, 7, wlCusID)
        Call SetSPPara(adcmdSave, 8, wlSaleID)

        Call SetSPPara(adcmdSave, 9, wsSrcCode)
        Call SetSPPara(adcmdSave, 10, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 11, txtRmk.Text)
        Call SetSPPara(adcmdSave, 12, txtRmk2.Text)
        Call SetSPPara(adcmdSave, 13, txtRmk3.Text)
        Call SetSPPara(adcmdSave, 14, wsFormID)

        Call SetSPPara(adcmdSave, 15, gsUserID)
        Call SetSPPara(adcmdSave, 16, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 17)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 18)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_IAJ001C"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then


                    If To_Value(waResult.get_Value(wiCtr, QTY)) > To_Value(waResult.get_Value(wiCtr, SOH)) Then
                        wsTrnType = "STKIN"
                        wdQty = To_Value(waResult.get_Value(wiCtr, QTY)) - To_Value(waResult.get_Value(wiCtr, SOH))
                    Else
                        wsTrnType = "STKOUT"
                        wdQty = To_Value(waResult.get_Value(wiCtr, SOH)) - To_Value(waResult.get_Value(wiCtr, QTY))

                    End If

                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, ITMID))
                    Call SetSPPara(adcmdSave, 4, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 5, To_Value(waResult.get_Value(wiCtr, QTY)))
                    Call SetSPPara(adcmdSave, 6, wdQty)
                    Call SetSPPara(adcmdSave, 7, cboWhsCodeFr)
                    Call SetSPPara(adcmdSave, 8, waResult.get_Value(wiCtr, LOTNO))
                    Call SetSPPara(adcmdSave, 9, wsTrnType)
                    Call SetSPPara(adcmdSave, 10, cboMLCode.Text)
                    Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, SOH))

                    Call SetSPPara(adcmdSave, 12, IIf(wlRowCtr = wiCtr, "Y", "N"))
                    Call SetSPPara(adcmdSave, 13, gsUserID)
                    Call SetSPPara(adcmdSave, 14, wsGenDte)
                    adcmdSave.Execute()
                End If
            Next
        End If
        cnCon.CommitTrans()

        If wiAction = AddRec Then
            If Trim(wsDocNo) <> "" Then
                gsMsg = "文件號 : " & wsDocNo & " 已製作!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Else
                gsMsg = "文件儲存件敗!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            End If
        End If

        If wiAction = CorRec Then
            gsMsg = "文件已儲存!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        End If


        'Call UnLockAll(wsConnTime, wsFormID)
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

    Private Function Chk_TransferQty() As Boolean
        Chk_TransferQty = False

        If CDbl(lblDspTrnAmt.Text) <> 0 Or CDbl(lblDspTrnQty.Text) <> 0 Then
            gsMsg = "文件類別為轉倉時, 更正數量及更正實價必須為零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tblDetail.Col = ITMCODE
                tblDetail.Focus()
            End If
            Exit Function
        End If

        Chk_TransferQty = True
    End Function

    Private Function InputValidation() As Boolean
        Dim wsExcRate As String
        Dim wsExcDesc As String

        InputValidation = False

        On Error GoTo InputValidation_Err

        If Not Chk_medDocDate Then Exit Function

        '  If Not Chk_cboSaleCode Then Exit Function

        If Not Chk_cboWhsCodeFr Then Exit Function

        If Not Chk_cboScNo Then Exit Function

        If Chk_MLClass(cboMLCode.Text, "G", "") = False Then
            gsMsg = "沒有此會計分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboMLCode.Focus()
            Exit Function
        End If


        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, ITMTYPE)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Col = ITMTYPE
                        tblDetail.Focus()
                        Exit Function
                    End If

                    If Chk_NoDup2(wlCtr, waResult.get_Value(wlCtr, LINENO), waResult.get_Value(wlCtr, ITMCODE), waResult.get_Value(wlCtr, WHSCODE), waResult.get_Value(wlCtr, LOTNO)) = False Then
                        tblDetail.Row = wlCtr - 1
                        tblDetail.Col = ITMCODE
                        tblDetail.Focus()
                        Exit Function
                    End If

                End If
            Next
        End With

        If wiEmptyGrid = True Then
            gsMsg = "沒有詳細資料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tblDetail.Col = ITMTYPE
                tblDetail.Focus()
            End If
            Exit Function
        End If

        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function

    Private Sub cmdNew()

        Dim newForm As New frmSKT001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmSKT001

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
        wsFormID = "SKT001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsTrnCd = "SK"
        wsSrcCode = "ICP"
    End Sub

    Private Sub cmdCancel()

        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("Default")
        cboDocNo.Focus()

    End Sub

    Private Sub cmdFind()

        Call OpenPromptForm()

    End Sub


    Public Property OpenDoc() As Short
        Get
            OpenDoc = wiOpenDoc
        End Get
        Set(ByVal Value As Short)
            wiOpenDoc = Value
        End Set
    End Property


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

    Public WriteOnly Property SrcCode() As String
        Set(ByVal Value As String)
            wsSrcCode = Value
        End Set
    End Property
    Public WriteOnly Property TrnType() As String
        Set(ByVal Value As String)
            wsTrnType = Value
        End Set
    End Property

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            '  If .Bookmark <> .DestinationRow Then
            If Chk_GrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
            '  End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub



    Private Sub tblDetail_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblDetail.ClickEvent

        If Chk_KeyFld = False Then
            Exit Sub
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click, _tbrProcess_Button15.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case tcOpen
                Call cmdOpen()
            Case tcAdd
                Call cmdNew()
                '    Case tcEdit
                '       Call cmdEdit
            Case tcDelete
                Call cmdDel()
            Case tcSave
                Call cmdSave()
            Case tcCancel
                If tbrProcess.Items.Item(tcSave).Enabled = True Then
                    If MsgBox("你是否確定儲存現時之變更而離開?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                        Call cmdCancel()
                    End If
                Else
                    Call cmdCancel()
                End If
            Case tcRefresh
                Call cmdRefresh()
            Case tcPrint
                Call cmdPrint()
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

            For wiCtr = LINENO To SOID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case LINENO
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 5
                        .Columns(wiCtr).Locked = True
                    Case ITMTYPE
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 13
                        .Columns(wiCtr).Button = True
                    Case ITMCODE
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 30
                    Case BARCODE
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 13
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).Visible = False
                    Case WHSCODE
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Visible = False
                    Case LOTNO
                        .Columns(wiCtr).Width = 800
                        '.Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 20
                        ' .Columns(wiCtr).Visible = False
                    Case ITMNAME
                        .Columns(wiCtr).Width = 3000
                        .Columns(wiCtr).DataWidth = 60
                        .Columns(wiCtr).Locked = True
                    Case SOH
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                        '                    .Columns(wiCtr).Visible = False
                    Case PRICE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsUprFmt
                    Case QTY
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                    Case ADJ
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        ' .Columns(wiCtr).Visible = False
                    Case ITMID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                    Case SOID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                End Select
            Next
            ' .Styles("EvenRow").BackColor = &H8000000F
        End With

    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate

        With tblDetail
            'UPGRADE_NOTE: UPDATE was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub

    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsITMID As String
        Dim wsITMCODE As String
        Dim wsBarCode As String
        Dim wsITMNAME As String
        Dim wsPub As String
        Dim wdPrice As Double
        Dim wdDisPer As Double
        Dim wsLotNo As String
        Dim wsWhsCode As String
        Dim wdQty As Double
        Dim wsSoId As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex

                Case ITMTYPE
                    If Chk_grdITMTYPE((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Trim(.Columns(ITMCODE).Text) = "" Then
                        Call tblDetail_ButtonClick(tblDetail, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(ITMCODE))
                    End If

                Case ITMCODE
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdITMCODE((.Columns(eventArgs.ColIndex).Text), (.Columns(ITMTYPE).Text), wsITMID, wsITMCODE, wsBarCode, wsITMNAME, wsPub, wdPrice, wdDisPer, wsWhsCode, wsLotNo, wdQty) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If
                    .Columns(LINENO).Text = CStr(wlLineNo)
                    .Columns(ITMID).Text = wsITMID
                    .Columns(BARCODE).Text = wsBarCode
                    .Columns(ITMNAME).Text = wsITMNAME
                    .Columns(SOH).Text = CStr(Get_IcTrnQty("STKQTY", CInt(wsITMID), cboWhsCodeFr.Text, ""))
                    '.Columns(WHSCODE).Text = wsWhsCode
                    .Columns(LOTNO).Text = wsLotNo
                    .Columns(SOID).Text = CStr(0)
                    .Columns(QTY).Text = ""
                    .Columns(PRICE).Text = CStr(wdPrice)
                    wlLineNo = wlLineNo + 1

                    If Trim(.Columns(eventArgs.ColIndex).Text) <> wsITMCODE Then
                        .Columns(eventArgs.ColIndex).Text = wsITMCODE
                    End If

                    'Case WHSCODE
                    '   If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                    '       GoTo Tbl_BeforeColUpdate_Err
                    '   End If
                    '
                    '   If Chk_grdWhsCode(.Columns(ColIndex).Text) = False Then
                    '           GoTo Tbl_BeforeColUpdate_Err
                    '   End If
                Case LOTNO
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdLotNo((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If


                    If Chk_LotEnabled(cboWhsCodeFr.Text) = True Then
                        .Columns(SOH).Text = CStr(Get_IcTrnQty("STKQTY", CInt(.Columns(ITMID).Text), cboWhsCodeFr.Text, .Columns(eventArgs.ColIndex).Text))
                    End If



                Case QTY

                    If eventArgs.ColIndex = QTY Then
                        If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        Else
                            .Columns(ADJ).Text = VB6.Format(To_Value((.Columns(QTY).Text)) - To_Value((.Columns(SOH).Text)), gsAmtFmt)
                        End If
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
		Dim wiCtr As Short
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case ITMTYPE
					
					wsSQL = "SELECT ITMTYPECODE, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC") & " ITNAME "
					wsSQL = wsSQL & " FROM MSTITEMTYPE "
					wsSQL = wsSQL & " WHERE ITMTYPECODE LIKE '%" & Set_Quote(.Columns(ITMTYPE).Text) & "%' "
					wsSQL = wsSQL & " AND ITMTYPESTATUS  <> '2' "
					wsSQL = wsSQL & " ORDER BY ITMTYPECODE "
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLITMTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
					
				Case ITMCODE
					
					wsSQL = "SELECT ITMCODE, ITMBARCODE, ITMENGNAME, ITMCHINAME "
					wsSQL = wsSQL & " FROM mstITEM "
					wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
					wsSQL = wsSQL & " AND ITMITMTYPECODE = '" & Set_Quote(.Columns(ITMTYPE).Text) & "' "
					wsSQL = wsSQL & " ORDER BY ITMCODE "
					
					Call Ini_Combo(4, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
					'Case WHSCODE
					'
					'    wsSql = "SELECT WHSCODE, WHSDESC FROM mstWareHouse "
					'    wsSql = wsSql & " WHERE WHSSTATUS <> '2' AND WHSCODE LIKE '%" & Set_Quote(.Columns(WHSCODE).Text) & "%' "
					'    wsSql = wsSql & " ORDER BY WHSCODE "
					'
					'    Call Ini_Combo(2, wsSql, .Columns(ColIndex).Left + .Left + .Columns(ColIndex).Top, .Top + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLWHSCODE", Me.Width, Me.Height)
					'    tblCommon.Visible = True
					'    tblCommon.SetFocus
					'    Set wcCombo = tblDetail
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_ButtonClick_Err: 
		MsgBox("Check tblDetail ButtonClick!")
		
		
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
					
				Case System.Windows.Forms.Keys.F5 ' INSERT LINE
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
					If IsEmptyRow Then Exit Sub
					'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
					.ReBind()
					.Focus()
					
				Case System.Windows.Forms.Keys.F8 ' DELETE LINE
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					If IsDbNull(.Bookmark) Then Exit Sub
					If .EditActive = True Then Exit Sub
					gsMsg = "你是否確定要刪除此列?"
					If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then Exit Sub
					.Delete()
					'UPGRADE_NOTE: UPDATE was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()
					If .Row = -1 Then
						.Row = 0
					End If
					'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Refresh()
					.Focus()
					
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						Case LINENO
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
						Case ITMTYPE
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = ITMCODE
						Case ITMCODE
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = QTY
						Case QTY
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = ITMCODE
					End Select
				Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					Select Case .Col
						Case QTY
							.Col = ITMCODE
						Case ITMCODE
							.Col = ITMTYPE
						Case ITMTYPE
							.Col = LINENO
					End Select
				Case System.Windows.Forms.Keys.Right
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					Select Case .Col
						Case ITMTYPE
							.Col = ITMCODE
						Case ITMCODE
							.Col = QTY
						Case LINENO
							.Col = .Col + 1
					End Select
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_KeyDown_Err: 
		MsgBox("Check tblDeiail KeyDown")
		
	End Sub
	
	Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
		
		Select Case tblDetail.Col
			
			Case QTY
				Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), True, False)
		End Select
		
	End Sub
	
	Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
		
		wbErr = False
		On Error GoTo RowColChange_Err
		
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If ActiveControl.Name <> tblDetail.Name Then Exit Sub
		
		With tblDetail
			If IsEmptyRow() Then
				.Col = ITMTYPE
			End If
			
			Call Calc_Total()
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					Case ITMTYPE
						Call Chk_grdITMTYPE(.Columns(ITMTYPE).Text)
					Case ITMCODE
						Call Chk_grdITMCODE((.Columns(ITMCODE).Text), (.Columns(ITMTYPE).Text), "", "", "", "", "", 0, 0, "", "", 0)
					Case LOTNO
						Call Chk_grdLotNo((.Columns(LOTNO).Text))
					Case QTY
						Call Chk_grdQty((.Columns(QTY).Text))
						
				End Select
			End If
		End With
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
	End Sub
	
	Private Function Chk_grdITMCODE(ByRef inAccNo As String, ByRef inItmType As String, ByRef outAccID As String, ByRef outAccNo As String, ByRef OutBarCode As String, ByRef OutName As String, ByRef outPub As String, ByRef outPrice As Double, ByRef outDisPer As Double, ByRef outWhsCode As String, ByRef outLotNo As String, ByRef outQty As Double) As Boolean
		
		Dim wsSQL As String
		Dim rsDes As New ADODB.Recordset
		
		If Trim(inAccNo) = "" Then
			gsMsg = "沒有輸入物料!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdITMCODE = False
			Exit Function
		End If
		
		wsSQL = "SELECT ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME, ITMBARCODE, ITMUNITPRICE "
		wsSQL = wsSQL & " FROM mstITEM "
		wsSQL = wsSQL & " WHERE ITMCODE = '" & Set_Quote(inAccNo) & "' "
		wsSQL = wsSQL & " AND ITMITMTYPECODE = '" & Set_Quote(inItmType) & "' "
		
		
		rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsDes.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			outAccID = ReadRs(rsDes, "ITMID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			outAccNo = ReadRs(rsDes, "ITMCODE")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutName = ReadRs(rsDes, "ITMNAME")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutBarCode = ReadRs(rsDes, "ITMBARCODE")
			outPub = ""
			outPrice = Get_AvgCost(CInt(outAccID), cboWhsCodeFr.Text)
			outLotNo = ""
			outQty = CDbl(VB6.Format(0, gsAmtFmt))
			Chk_grdITMCODE = True
			
		Else
			outAccID = ""
			OutName = ""
			OutBarCode = ""
			outPub = ""
			outLotNo = ""
			outQty = CDbl(VB6.Format(0, gsAmtFmt))
			outPrice = CDbl(VB6.Format(0, gsAmtFmt))
			gsMsg = "沒有此物料!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdITMCODE = False
		End If
		rsDes.Close()
		'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDes = Nothing
		
	End Function
	
	
	
	Private Function Chk_grdWhsCode(ByRef inNo As String) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_grdWhsCode = False
		
		If Trim(inNo) = "" Then
			gsMsg = "必需輸入貨倉!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		wsSQL = "SELECT *  FROM mstWareHouse"
		wsSQL = wsSQL & " WHERE WHSCODE = '" & Set_Quote(inNo) & "' "
		wsSQL = wsSQL & " AND WHSSTATUS = '1' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			Chk_grdWhsCode = True
		Else
			gsMsg = "沒有此貨倉!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdWhsCode = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Private Function Chk_grdLotNo(ByRef inNo As String) As Boolean
		
		
		Chk_grdLotNo = False
		
		If Chk_LotEnabled(cboWhsCodeFr.Text) = False Then
			Chk_grdLotNo = True
			Exit Function
		End If
		
		If Chk_LotB(cboWhsCodeFr.Text, inNo) = False Then
			gsMsg = "不能輸入 " & inNo & " 貨架!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		
		
		If Trim(inNo) = "" Then
			gsMsg = "必需輸入貨架!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		Chk_grdLotNo = True
		
	End Function
	
	Private Function Chk_grdQty(ByRef inCode As String) As Boolean
		Chk_grdQty = True
		Exit Function
		
		If Trim(inCode) = "" Then
			gsMsg = "必需輸入數量!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdQty = False
			Exit Function
		End If
		
		If To_Value(inCode) = 0 Then
			gsMsg = "數量必需大於零!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdQty = False
			Exit Function
		End If
	End Function
	
	Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean
		
		IsEmptyRow = True
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inRow) Then
			With tblDetail
				If Trim(.Columns(ITMTYPE).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				
				If Trim(waResult.get_Value(inRow, ITMTYPE)) = "" And Trim(waResult.get_Value(inRow, ITMCODE)) = "" And Trim(waResult.get_Value(inRow, ITMNAME)) = "" And Trim(waResult.get_Value(inRow, SOH)) = "" And Trim(waResult.get_Value(inRow, QTY)) = "" And Trim(waResult.get_Value(inRow, ITMID)) = "" Then
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
			
			If Chk_grdITMTYPE(waResult.get_Value(LastRow, ITMTYPE)) = False Then
				.Col = ITMTYPE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdITMCODE(waResult.get_Value(LastRow, ITMCODE), waResult.get_Value(LastRow, ITMTYPE), "", "", "", "", "", 0, 0, "", "", 0) = False Then
				.Col = ITMCODE
				.Row = LastRow
				Exit Function
			End If
			
			'If Chk_grdWhsCode(waResult(LastRow, WHSCODE)) = False Then
			'        .Col = WHSCODE
			'        .Row = LastRow
			'        Exit Function
			'End If
			
			If Chk_grdLotNo(waResult.get_Value(LastRow, LOTNO)) = False Then
				.Col = LOTNO
				.Row = LastRow
				Exit Function
			End If
			
			
			If Chk_grdQty(waResult.get_Value(LastRow, QTY)) = False Then
				.Col = QTY
				.Row = LastRow
				Exit Function
				'Else
				'    .Columns(NET).Text = Format(To_Value(.Columns(PRICE).Text) * To_Value(.Columns(QTY).Text), gsAmtFmt)
			End If
			
			
			
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
	
	Private Function cmdDel() As Boolean
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wsDocNo As String
		Dim i As Short
		
		cmdDel = False
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		On Error GoTo cmdDelete_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		If ReadOnlyMode(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID) Or wbReadOnly Then
			gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Function
		End If
		
		gsMsg = "你是否確認要刪除此檔案?"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			wiAction = CorRec
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Function
		End If
		
		wiAction = DelRec
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_IAJ001A"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, wiAction)
		Call SetSPPara(adcmdSave, 2, wsTrnCd)
		Call SetSPPara(adcmdSave, 3, wlKey)
		Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
		Call SetSPPara(adcmdSave, 5, Set_MedDate(medDocDate.Text))
		Call SetSPPara(adcmdSave, 6, "")
		Call SetSPPara(adcmdSave, 7, 0)
		Call SetSPPara(adcmdSave, 8, wlSaleID)
		
		Call SetSPPara(adcmdSave, 9, wsSrcCode)
		Call SetSPPara(adcmdSave, 10, cboMLCode.Text)
		Call SetSPPara(adcmdSave, 11, txtRmk.Text)
		Call SetSPPara(adcmdSave, 12, txtRmk2.Text)
		Call SetSPPara(adcmdSave, 13, txtRmk3.Text)
		Call SetSPPara(adcmdSave, 14, wsFormID)
		
		Call SetSPPara(adcmdSave, 15, gsUserID)
		Call SetSPPara(adcmdSave, 16, wsGenDte)
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = GetSPPara(adcmdSave, 17)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdSave, 18)
		
		cnCon.CommitTrans()
		
		gsMsg = wsDocNo & " 檔案已刪除!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		Call cmdCancel()
		Cursor = System.Windows.Forms.Cursors.Default
		
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		cmdDel = True
		
		Exit Function
		
cmdDelete_Err: 
		MsgBox("Check cmdDel")
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
				If wiAction = DelRec Then
					If cmdDel = True Then
						Exit Function
					End If
				Else
					If cmdSave = True Then
						Exit Function
					End If
				End If
			End If
			SaveData = True
		Else
			SaveData = False
		End If
		
	End Function
	
	'-- Set field status, Default, Add, Edit.
	Public Sub SetFieldStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				
				Me.cboDocNo.Enabled = False
				Me.medDocDate.Enabled = False
				
				Me.cboMLCode.Enabled = False
				Me.cboSaleCode.Enabled = False
				Me.cboWhsCodeFr.Enabled = False
				Me.cboScNo.Enabled = False
				
				Me.txtRmk.Enabled = False
				Me.txtRmk2.Enabled = False
				Me.txtRmk3.Enabled = False
				
				
				
				Me.tblDetail.Enabled = False
				
			Case "AfrActAdd"
				
				Me.cboDocNo.Enabled = True
				
			Case "AfrActEdit"
				
				Me.cboDocNo.Enabled = True
				
			Case "AfrKey"
				Me.cboDocNo.Enabled = False
				
				Me.medDocDate.Enabled = True
				Me.cboMLCode.Enabled = True
				Me.cboSaleCode.Enabled = True
				Me.cboScNo.Enabled = True
				
				Me.cboWhsCodeFr.Enabled = True
				Me.txtRmk.Enabled = True
				Me.txtRmk2.Enabled = True
				Me.txtRmk3.Enabled = True
				
				
				'     If wiAction <> AddRec Then
				Me.tblDetail.Enabled = True
				'     End If
		End Select
	End Sub
	
	Private Sub GetNewKey()
		Dim Newfrm As New frmKeyInput
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		With Newfrm
			
			.TableID = wsKeyType
			.TableType = wsTrnCd
			.TableKey = "SJHDDocNo"
			.KeyLen = 15
			.ctlKey = cboDocNo
			.ShowDialog()
		End With
		
		'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Newfrm = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub OpenPromptForm()
		Dim wsOutCode As String
		Dim wsSQL As String
		
		Dim vFilterAry(2, 2) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 1) = "文件號"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "SJHDDocNo"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "日期"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "SJHDDocDate"
		
		
		Dim vAry(2, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "文件號"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "SJHDDocNo"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "日期"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "SJHDDocDate"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "1500"
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			wsSQL = "SELECT icStkAdj.SJHDDocNo, icStkAdj.SJHDDocDate "
			wsSQL = wsSQL & "FROM icStkAdj "
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE icStkAdj.SJHDStatus = '1' "
			.sBindOrderSQL = "ORDER BY icStkAdj.SJHDDocNo"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmSKT001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboDocNo.Text Then
			cboDocNo.Text = Trim(frmShareSearch.Tag)
			cboDocNo.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		frmShareSearch.Close()
		
	End Sub
	
	Private Sub cboSaleCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSaleCode.Enter
		FocusMe(cboSaleCode)
	End Sub
	
	Private Sub cboSaleCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSaleCode.Leave
		FocusMe(cboSaleCode, True)
	End Sub
	
	Private Sub cboSaleCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboSaleCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsDesc As String
		
		Call chk_InpLen(cboSaleCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboSaleCode() = True Then
				cboWhsCodeFr.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboSaleCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSaleCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboSaleCode
		
		
		wsSQL = "SELECT SALECODE, SALENAME FROM mstSalesman WHERE SaleCode LIKE '%" & IIf(cboSaleCode.SelectionLength > 0, "", Set_Quote(cboSaleCode.Text)) & "%' "
		wsSQL = wsSQL & "AND SaleStatus = '1' "
		wsSQL = wsSQL & "AND SaleType = 'W' "
		wsSQL = wsSQL & "ORDER BY SaleCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboSaleCode.Left)), VB6.PixelsToTwipsY(cboSaleCode.Top) + VB6.PixelsToTwipsY(cboSaleCode.Height), tblCommon, wsFormID, "TBLSALECOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboSaleCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboSaleCode = False
		
		If Trim(cboSaleCode.Text) = "" Then
			gsMsg = "必需輸入倉務員!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboSaleCode.Focus()
			Exit Function
		End If
		
		If Chk_Salesman(cboSaleCode.Text, wlSaleID, wsDesc) = False Then
			gsMsg = "沒有此倉務員!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboSaleCode.Focus()
			lblDspSaleDesc.Text = ""
			Exit Function
		End If
		
		lblDspSaleDesc.Text = wsDesc
		
		Chk_cboSaleCode = True
		
	End Function
	
	Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean
		
		Dim wlCtr As Integer
		Dim wsCurRec As String
		Dim wsCurRecLn As String
		Dim wsCurRecLn2 As String
		Dim wsCurRecLn3 As String
		
		Chk_NoDup = False
		
		wsCurRecLn = tblDetail.Columns(ITMCODE).Text
		'wsCurRecLn2 = tblDetail.Columns(WHSCODE)
		'wsCurRecLn3 = tblDetail.Columns(LOTNO)
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				'If wsCurRecLn = waResult(wlCtr, ITMCODE) And _
				'wsCurRecLn2 = waResult(wlCtr, WhsCode) And _
				'wsCurRecLn3 = waResult(wlCtr, LOTNO) Then
				If wsCurRecLn = waResult.get_Value(wlCtr, ITMCODE) Then
					gsMsg = "重覆物料於第 " & waResult.get_Value(wlCtr, LINENO) & " 行!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup = True
		
	End Function
	
	Private Function Chk_NoDup2(ByRef inRow As Integer, ByVal wsCurRec As String, ByVal wsCurRecLn As String, ByVal wsCurRecLn2 As String, ByVal wsCurRecLn3 As String) As Boolean
		
		Dim wlCtr As Integer
		
		Chk_NoDup2 = False
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				'If wsCurRec = waResult(wlCtr, LINENO) And _
				'wsCurRecLn = waResult(wlCtr, ITMCODE) And _
				'wsCurRecLn2 = waResult(wlCtr, WhsCode) And _
				'wsCurRecLn3 = waResult(wlCtr, LOTNO) Then
				If wsCurRec = waResult.get_Value(wlCtr, ITMCODE) Then
					gsMsg = "重覆物料於第 " & waResult.get_Value(wlCtr, LINENO) & " 行!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					inRow = To_Value(waResult.get_Value(wlCtr, LINENO))
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup2 = True
		
	End Function
	
	Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
		If eventArgs.Button = 2 Then
			'UPGRADE_ISSUE: Form method frmSKT001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
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
					'UPGRADE_NOTE: UPDATE was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
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
	
	Public Sub SetButtonStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcEdit).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = False
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcFind).Enabled = False
					.Items.Item(tcExit).Enabled = True
					.Items.Item(tcRefresh).Enabled = False
					.Items.Item(tcPrint).Enabled = False
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
					.Items.Item(tcRefresh).Enabled = False
					.Items.Item(tcPrint).Enabled = False
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
					.Items.Item(tcRefresh).Enabled = True
					.Items.Item(tcPrint).Enabled = True
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
					.Items.Item(tcRefresh).Enabled = False
					.Items.Item(tcPrint).Enabled = False
					
				End With
		End Select
	End Sub
	
	Private Sub cmdPrint()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		'If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(4)
		wsSelection(1) = ""
		wsSelection(2) = ""
		wsSelection(3) = ""
		wsSelection(4) = ""
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTIAJ003 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		
		wsSQL = wsSQL & "'" & wgsTitle & "', "
		
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
		wsSQL = wsSQL & "'" & "0000/00/00" & "', "
		wsSQL = wsSQL & "'" & "9999/99/99" & "', "
		wsSQL = wsSQL & "'" & "%" & "', "
		wsSQL = wsSQL & "'" & wsTrnCd & "', "
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTIAJ002"
		Else
			wsRptName = "RPTIAJ002"
		End If
		
		NewfrmPrint.ReportID = "IAJ002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "IAJ002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cmdRefresh()
		Dim wiCtr As Short
		Dim wsITMID As String
		Dim wdDisPer As Double
		Dim wdNewDisPer As Double
		
		
		If waResult.get_UpperBound(1) >= 0 Then
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then
					wsITMID = waResult.get_Value(wiCtr, ITMID)
					'wdNewDisPer = Get_SaleDiscount(cboNatureCode.Text, wlCusID, wsITMID)
					'If wdDisPer <> wdNewDisPer Then
					'    waResult(wiCtr, DisPer) = Format(wdNewDisPer, gsAmtFmt)
					'    waResult(wiCtr, Dis) = Format(To_Value(waResult(wiCtr, Amt)) * To_Value(waResult(wiCtr, DisPer)) / 100, gsAmtFmt)
					'    waResult(wiCtr, Disl) = Format(To_Value(waResult(wiCtr, Amtl)) * To_Value(waResult(wiCtr, DisPer)) / 100, gsAmtFmt)
					'    waResult(wiCtr, Net) = Format(To_Value(waResult(wiCtr, Amt)) - To_Value(waResult(wiCtr, Dis)), gsAmtFmt)
					'    waResult(wiCtr, Netl) = Format(To_Value(waResult(wiCtr, Amtl)) - To_Value(waResult(wiCtr, Disl)), gsAmtFmt)
					'End If
				End If
			Next 
			
			tblDetail.ReBind()
			tblDetail.FirstRow = 0
			
			Call Calc_Total()
		End If
	End Sub
	
	Private Function Calc_Total(Optional ByVal LastRow As Object = Nothing) As Boolean
		Dim wdTotalQty As Double
		Dim wdTotalPrice As Double
		
		Dim wiRowCtr As Short
		
		Calc_Total = False
		
		For wiRowCtr = 0 To waResult.get_UpperBound(1)
			wdTotalQty = wdTotalQty + To_Value(waResult.get_Value(wiRowCtr, QTY))
			wdTotalPrice = wdTotalPrice + To_Value(waResult.get_Value(wiRowCtr, ADJ))
		Next 
		
		lblDspTrnAmt.Text = VB6.Format(CStr(wdTotalPrice), gsQtyFmt)
		lblDspTrnQty.Text = VB6.Format(CStr(wdTotalQty), gsQtyFmt)
		
		Calc_Total = True
		
	End Function
	
	Private Function Chk_cboWhsCodeFr() As Boolean
		Dim wsStatus As String
		
		Chk_cboWhsCodeFr = False
		
		If Trim(cboWhsCodeFr.Text) = "" Then
			gsMsg = "沒有輸入來源倉庫!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWhsCodeFr.Focus()
			Exit Function
		End If
		
		If Chk_WhsCode(cboWhsCodeFr.Text, wsStatus) = False Then
			gsMsg = "倉庫不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboWhsCodeFr.Focus()
			Exit Function
		Else
			If wsStatus = "2" Then
				gsMsg = "倉庫已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboWhsCodeFr.Focus()
				Exit Function
			End If
		End If
		
		Chk_cboWhsCodeFr = True
	End Function
	
	
	Private Function Chk_cboScNo() As Boolean
		Dim wsStatus As String
		
		Chk_cboScNo = False
		
		If Trim(cboScNo.Text) = "" Then
			gsMsg = "沒有輸盤點文件!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboScNo.Focus()
			Exit Function
		End If
		
		
		If Chk_TrnHdDocNo("SC", cboScNo.Text, wsStatus) = False Then
			
			gsMsg = "文件不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboScNo.Focus()
			Exit Function
			
		Else
			
			If wsStatus = "4" Then
				gsMsg = "文件已入數, 現在以唯讀模式開啟!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				cboScNo.Focus()
			End If
			
			If wsStatus = "2" Then
				gsMsg = "文件已存在但已無效!"
				MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
				cboScNo.Focus()
				Exit Function
			End If
			
			
			wlCusID = Get_SCID
			
		End If
		
		Chk_cboScNo = True
	End Function
	
	Private Function Chk_WhsCode(ByVal inCode As String, ByRef outCode As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_WhsCode = False
		
		If Trim(inCode) = "" Then
			Exit Function
		End If
		
		wsSQL = "SELECT WhsStatus "
		wsSQL = wsSQL & " FROM MstWareHouse WHERE WhsCode = '" & Set_Quote(inCode) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			outCode = ""
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outCode = ReadRs(rsRcd, "WhsStatus")
		
		Chk_WhsCode = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	
	
	
	Private Sub txtRmk_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Enter
		FocusMe(txtRmk)
	End Sub
	
	Private Sub txtRmk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtRmk, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			
			txtRmk2.Focus()
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Leave
		FocusMe(txtRmk, True)
	End Sub
	
	
	
	Private Sub txtRmk2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk2.Enter
		FocusMe(txtRmk2)
	End Sub
	
	Private Sub txtRmk2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtRmk2, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			
			
			txtRmk3.Focus()
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk2.Leave
		FocusMe(txtRmk2, True)
	End Sub
	
	Private Sub txtRmk3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk3.Enter
		FocusMe(txtRmk3)
	End Sub
	
	Private Sub txtRmk3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk3.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtRmk3, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			
			If Chk_KeyFld = False Then
				GoTo EventExitSub
			End If
			
			If tblDetail.Enabled = True Then
				tblDetail.Col = ITMCODE
				tblDetail.Focus()
			Else
				cboSaleCode.Focus()
			End If
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk3.Leave
		FocusMe(txtRmk3, True)
	End Sub
	
	
	Private Function Chk_grdITMTYPE(ByRef inAccNo As String) As Boolean
		Dim wsSQL As String
		Dim rsDes As New ADODB.Recordset
		
		
		If Trim(inAccNo) = "" Then
			gsMsg = "沒有輸入!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdITMTYPE = False
			Exit Function
		End If
		
		
		wsSQL = "SELECT * FROM MSTITEMTYPE"
		wsSQL = wsSQL & " WHERE ITMTYPECODE = '" & Set_Quote(inAccNo) & "'"
		
		rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsDes.RecordCount > 0 Then
			Chk_grdITMTYPE = True
		Else
			gsMsg = "沒有此分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdITMTYPE = False
		End If
		
		rsDes.Close()
		'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDes = Nothing
	End Function
	
	
	
	Private Sub cboScNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboScNo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboScNo
		
		wsSQL = "SELECT SCHDDOCNO , SCHDCTLPRD FROM ICSTKCNT WHERE SCHDStatus = '1' "
		wsSQL = wsSQL & " AND SCHDDOCNO LIKE '%" & IIf(cboScNo.SelectionLength > 0, "", Set_Quote(cboScNo.Text)) & "%' "
		wsSQL = wsSQL & "ORDER BY SCHDDOCNO "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboScNo.Left)), VB6.PixelsToTwipsY(cboScNo.Top) + VB6.PixelsToTwipsY(cboScNo.Height), tblCommon, wsFormID, "TBLSCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboScNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboScNo.Enter
		FocusMe(cboScNo)
	End Sub
	
	Private Sub cboScNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboScNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboScNo, 15, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboScNo() = False Then
				GoTo EventExitSub
			End If
			
			cboMLCode.Focus()
			
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboScNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboScNo.Leave
		FocusMe(cboScNo, True)
	End Sub
	
	Private Function Get_SCID() As Integer
		Dim wsSQL As String
		Dim rsDes As New ADODB.Recordset
		
		
		If Trim(cboScNo.Text) = "" Then
			gsMsg = "沒有輸入Counting No!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Get_SCID = 0
			Exit Function
		End If
		
		
		wsSQL = "SELECT SCHDDOCID FROM ICSTKCNT "
		wsSQL = wsSQL & " WHERE SCHDDOCNO = '" & Set_Quote(Trim(cboScNo.Text)) & "'"
		
		rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsDes.RecordCount > 0 Then
			Get_SCID = To_Value(ReadRs(rsDes, "SCHDDOCID"))
		Else
			Get_SCID = 0
		End If
		
		rsDes.Close()
		'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDes = Nothing
	End Function
End Class