Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAP001
	Inherits System.Windows.Forms.Form
	
	
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	
	
	
	Private wsOldVdrNo As String
	Private wsOldCurCd As String
	Private wsOldRmkCd As String
	Private wsOldPayCd As String
	Private wbReadOnly As Boolean
	
	
	
	Private Const GMLCODE As Short = 0
	Private Const GDESC As Short = 1
	Private Const GJOBNO As Short = 2
	Private Const GCUSPO As Short = 3
	Private Const GAMT As Short = 4
	Private Const GDTLID As Short = 5
	Private Const GDummy As Short = 6
	
	
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
	Private wiRevNo As Short
	Private wlVdrID As Integer
	
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "APIPHD"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsSrcCd As String
	
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	Private wsSOPFlg As String
	
	
	
	Private wsFormCaption As String
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, GMLCODE, GDTLID)
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
		
		Call SetDateMask(medDocDate)
		Call SetDateMask(medDueDate)
		
		
		
		wsOldVdrNo = ""
		wsOldCurCd = ""
		wsOldRmkCd = ""
		wsOldPayCd = ""
		
		
		wlKey = 0
		wlVdrID = 0
		wbReadOnly = False
		
		
		wiRevNo = CShort(VB6.Format(0, "##0"))
		tblCommon.Visible = False
		
		
		Me.Text = wsFormCaption
		
		FocusMe(cboDocNo)
		tabDetailInfo.SelectedIndex = 0
		
		
	End Sub
	
	Private Sub cboCurr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCurr.Enter
		FocusMe(cboCurr)
	End Sub
	
	Private Sub cboCurr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCurr.Leave
		FocusMe(cboCurr, True)
	End Sub
	
	Private Sub cboVdrCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.Leave
		FocusMe(cboVdrCode, True)
	End Sub
	
	Private Sub cboCurr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCurr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsExcRate As String
		Dim wsExcDesc As String
		
		Call chk_InpLen(cboCurr, 3, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboCurr = False Then
				GoTo EventExitSub
			End If
			
			If getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) = False Then
				gsMsg = "沒有此貨幣!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				txtExcr.Text = VB6.Format(0, gsExrFmt)
				cboCurr.Focus()
				GoTo EventExitSub
			End If
			
			If wsOldCurCd <> cboCurr.Text Then
				txtExcr.Text = VB6.Format(wsExcRate, gsExrFmt)
				wsOldCurCd = cboCurr.Text
			End If
			
			If UCase(cboCurr.Text) = UCase(wsBaseCurCd) Then
				txtExcr.Text = VB6.Format("1", gsExrFmt)
				txtExcr.Enabled = False
			Else
				txtExcr.Enabled = True
			End If
			
			If txtExcr.Enabled Then
				txtExcr.Focus()
			Else
				If Chk_KeyFld Then
					tabDetailInfo.SelectedIndex = 0
					cboPayCode.Focus()
				End If
			End If
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboCurr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCurr.DropDown
		
		Dim wsSQL As String
		Dim wsCtlDte As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCurr
		
		wsCtlDte = IIf(Trim(medDocDate.Text) = "" Or Trim(medDocDate.Text) = "/  /", gsSystemDate, medDocDate.Text)
		wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE WHERE EXCCURR LIKE '%" & IIf(cboCurr.SelectionLength > 0, "", Set_Quote(cboCurr.Text)) & "%' "
		wsSQL = wsSQL & " AND EXCMN = '" & To_Value(VB6.Format(wsCtlDte, "MM")) & "' "
		wsSQL = wsSQL & " AND EXCYR = '" & Set_Quote(VB6.Format(wsCtlDte, "YYYY")) & "' "
		wsSQL = wsSQL & " AND EXCSTATUS = '1' "
		wsSQL = wsSQL & "ORDER BY EXCCURR "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCurr.Left)), VB6.PixelsToTwipsY(cboCurr.Top) + VB6.PixelsToTwipsY(cboCurr.Height), tblCommon, wsFormID, "TBLCURCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboCurr() As Boolean
		
		Chk_cboCurr = False
		
		If Trim(cboCurr.Text) = "" Then
			gsMsg = "必需輸入貨幣!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboCurr.Focus()
			Exit Function
		End If
		
		
		If Chk_Curr(cboCurr.Text, (medDocDate.Text)) = False Then
			gsMsg = "沒有此貨幣!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboCurr.Focus()
			Exit Function
		End If
		
		
		Chk_cboCurr = True
		
	End Function
	
	
	
	Private Sub cboDocNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.Enter
		
		FocusMe(cboDocNo)
		
	End Sub
	
	Private Sub cboDocNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNo
		
		
		wsSQL = "SELECT IPHDDOCNO, IPHDJOBNO, IPHDDOCDATE, IPHDCURR, SUM(IPDTINVAMT), SUM(IPDTBALAMT) "
		wsSQL = wsSQL & " FROM APIPHD, APIPDT "
		wsSQL = wsSQL & " WHERE IPHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
		wsSQL = wsSQL & " AND IPHDDOCID  = IPDTDOCID "
		wsSQL = wsSQL & " AND IPHDTRNCODE  = '" & Set_Quote(wsTrnCd) & "' "
		'   wsSql = wsSql & " AND IPHDUPDFLG = 'N'"
		'   wsSql = wsSql & " AND IPHDSTATUS = '1'"
		'   wsSql = wsSql & " AND IPHDPGMNO = 'AP001' "
		wsSQL = wsSQL & " GROUP BY IPHDDOCNO, IPHDJOBNO, IPHDDOCDATE, IPHDCURR "
		'   wsSql = wsSql & " HAVING SUM(IPDTSTLAMT) = 0 AND SUM(IPDTSTLAMTL) = 0"
		wsSQL = wsSQL & " ORDER BY IPHDDOCNO "
		
		
		Call Ini_Combo(6, wsSQL, (VB6.PixelsToTwipsX(cboDocNo.Left)), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsStatus As String
		Dim wsUpdFlg As String
		Dim wsTrnCode As String
		Dim wsDocDate As String
		Dim wsPgmNo As String
		
		Chk_cboDocNo = False
		
		If Trim(cboDocNo.Text) = "" And Chk_AutoGen("PV") = "N" Then
			gsMsg = "必需輸入文件號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNo.Focus()
			Exit Function
		End If
		
		
		If Chk_DocNo(cboDocNo.Text, wsStatus, wsTrnCode, wsUpdFlg, wsDocDate, wsPgmNo) = True Then
			
			If wsTrnCd <> wsTrnCode Then
				gsMsg = "This is not a valid transaction code!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				cboDocNo.Focus()
				Exit Function
			End If
			
			If wsStatus = "4" Or wsUpdFlg = "Y" Then
				gsMsg = "文件已入數!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				wbReadOnly = True
				Chk_cboDocNo = True
				Exit Function
			End If
			
			If wsStatus = "2" Then
				gsMsg = "文件已刪除!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				cboDocNo.Focus()
				Exit Function
			End If
			
			If Chk_ValidDocDate(wsDocDate, "AP") = False Then
				cboDocNo.Focus()
				Exit Function
			End If
			
			
			If wsPgmNo <> wsFormID Then
				gsMsg = "This is not a valid form code!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				wbReadOnly = True
				Chk_cboDocNo = True
				Exit Function
			End If
			
			wsSQL = "SELECT SUM(IPDTSTLAMT) STLAMT FROM APIPHD, APIPDT "
			wsSQL = wsSQL & " WHERE IPHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND IPHDDOCID = IPDTDOCID "
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				If To_Value(ReadRs(rsRcd, "STLAMT")) <> 0 Then
					gsMsg = "Document has been already settled!"
					MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					rsRcd.Close()
					'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					rsRcd = Nothing
					wbReadOnly = True
					Chk_cboDocNo = True
					Exit Function
				End If
			End If
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			
			
		Else
			
			wsSQL = "SELECT APCQCHQID FROM APCHEQUE "
			wsSQL = wsSQL & " WHERE APCQCHQNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND APCQPGMNO <> '" & wsFormID & "' "
			
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				gsMsg = "Document No has been already used by cheque!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			
			wsSQL = "SELECT APSHDOCID FROM APSTHD "
			wsSQL = wsSQL & " WHERE APSHDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND APSHPGMNO <> '" & wsFormID & "' "
			
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				gsMsg = "Document No has been already used by Settlement!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			
		End If
		
		
		Chk_cboDocNo = True
		
	End Function
	
	
	
	
	Private Sub Ini_Scr_AfrKey()
		
		
		
		If LoadRecord() = False Then
			wiAction = AddRec
			txtRevNo.Text = VB6.Format(0, "##0")
			txtRevNo.Enabled = False
			medDocDate.Text = Dsp_Date(Now)
			Call SetButtonStatus("AfrKeyAdd")
		Else
			wiAction = CorRec
			If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
				gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				tblDetail.ReBind()
			End If
			txtRevNo.Enabled = True
			wsOldVdrNo = cboVdrCode.Text
			wsOldCurCd = cboCurr.Text
			wsOldRmkCd = cboRmkCode.Text
			wsOldPayCd = cboPayCode.Text
			
			
			If UCase(cboCurr.Text) = UCase(wsBaseCurCd) Then
				txtExcr.Text = VB6.Format("1", gsExrFmt)
				txtExcr.Enabled = False
			Else
				txtExcr.Enabled = True
			End If
			Call SetButtonStatus("AfrKeyEdit")
		End If
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		
		Call SetFieldStatus("AfrKey")
		
		cboVdrCode.Focus()
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Form event frmAP001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmAP001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboDocNo
			Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
		End If
		
	End Sub
	
	
	Private Sub frmAP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
				
				
			Case System.Windows.Forms.Keys.F2
				If wiAction = DefaultPage Then Call cmdNew()
				
				
				'Case vbKeyF5
				'    If wiAction = DefaultPage Then Call cmdEdit
				
				
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
	
	Private Sub frmAP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Grid()
		Call Ini_Caption()
		Call Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsExcRate As String
		Dim wsExcDesc As String
		Dim wiCtr As Integer
		
		LoadRecord = False
		
		
		wsSQL = "SELECT IPHDDOCID, IPHDDOCNO, IPHDVDRID, VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, "
		wsSQL = wsSQL & "IPHDDOCDATE, IPHDREVNO, IPHDCURR, IPHDEXCR, "
		wsSQL = wsSQL & "IPHDDUEDATE, IPHDPAYCODE, IPHDSALEID, IPHDMLCODE, IPHDJOBNO, "
		wsSQL = wsSQL & "IPHDRMKCODE, IPHDRMK1,  IPHDRMK2,  IPHDRMK3,  IPHDRMK4, IPHDRMK5, "
		wsSQL = wsSQL & "IPDTID, IPDTMLCODE, IPDTCATCODE, IPDTCUSPO, IPDTJOBNO, IPDTINVAMT, IPDTDESC "
		wsSQL = wsSQL & "FROM  APIPHD, APIPDT, mstVENDOR "
		wsSQL = wsSQL & "WHERE IPHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
		wsSQL = wsSQL & "AND IPHDDOCID = IPDTDOCID "
		wsSQL = wsSQL & "AND IPHDVdrID = VdrID "
		'    wsSql = wsSql & "AND IPHDPGMNO = '" & wsFormID & "'"
		wsSQL = wsSQL & "AND IPHDSTATUS <> '2'"
		wsSQL = wsSQL & "ORDER BY IPDTDOCLINE "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = ReadRs(rsRcd, "IPHDDOCID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRevNo.Text = VB6.Format(ReadRs(rsRcd, "IPHDREVNO") + 1, "##0")
		wiRevNo = To_Value(ReadRs(rsRcd, "IPHDREVNO"))
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		medDocDate.Text = ReadRs(rsRcd, "IPHDDOCDATE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlVdrID = ReadRs(rsRcd, "VdrID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboVdrCode.Text = ReadRs(rsRcd, "VdrCode")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspVdrName.Text = ReadRs(rsRcd, "VdrName")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspVdrTel.Text = ReadRs(rsRcd, "VdrTel")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspVdrFax.Text = ReadRs(rsRcd, "VdrFax")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboCurr.Text = ReadRs(rsRcd, "IPHDCURR")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtExcr.Text = VB6.Format(ReadRs(rsRcd, "IPHDEXCR"), gsExrFmt)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		medDueDate.Text = Dsp_MedDate(ReadRs(rsRcd, "IPHDDUEDATE"))
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboPayCode.Text = ReadRs(rsRcd, "IPHDPAYCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboMLCode.Text = ReadRs(rsRcd, "IPHDMLCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboRmkCode.Text = ReadRs(rsRcd, "IPHDRMKCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboJobNo.Text = ReadRs(rsRcd, "IPHDJOBNO")
		
		
		
		Dim i As Short
		
		For i = 1 To 5
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, IPHDRMK & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtRmk(i).Text = ReadRs(rsRcd, "IPHDRMK" & i)
		Next i
		
		
		
		lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")
		lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")
		
		
		
		rsRcd.MoveFirst()
		With waResult
			.ReDim(0, -1, GMLCODE, GDTLID)
			Do While Not rsRcd.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GMLCODE) = ReadRs(rsRcd, "IPDTMLCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GDESC) = ReadRs(rsRcd, "IPDTDESC")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GCUSPO) = ReadRs(rsRcd, "IPDTCUSPO")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GJOBNO) = ReadRs(rsRcd, "IPDTJOBNO")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GAMT) = IIf(wsTrnCd <> "20", VB6.Format(ReadRs(rsRcd, "IPDTINVAMT") * -1, gsAmtFmt), VB6.Format(ReadRs(rsRcd, "IPDTINVAMT"), gsAmtFmt))
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GDTLID) = ReadRs(rsRcd, "IPDTID")
				rsRcd.MoveNext()
			Loop 
		End With
		tblDetail.ReBind()
		tblDetail.FirstRow = 0
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Call Calc_Total()
		
		LoadRecord = True
		
	End Function
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		lblRevNo.Text = Get_Caption(waScrItm, "REVNO")
		lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
		lblVdrCode.Text = Get_Caption(waScrItm, "VdrCode")
		lblVdrName.Text = Get_Caption(waScrItm, "VdrName")
		lblVdrTel.Text = Get_Caption(waScrItm, "VdrTel")
		lblVdrFax.Text = Get_Caption(waScrItm, "VdrFax")
		lblCurr.Text = Get_Caption(waScrItm, "CURR")
		lblExcr.Text = Get_Caption(waScrItm, "EXCR")
		
		lblPayCode.Text = Get_Caption(waScrItm, "PAYCODE")
		lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
		lblDueDate.Text = Get_Caption(waScrItm, "DUEDATE")
		lblJobNo.Text = Get_Caption(waScrItm, "JOBNO")
		
		lblInvAmtOrg.Text = Get_Caption(waScrItm, "InvAmtORG")
		
		lblInvAmtLoc.Text = Get_Caption(waScrItm, "InvAmtLOC")
		
		With tblDetail
			.Columns(GMLCODE).Caption = Get_Caption(waScrItm, "GMLCODE")
			.Columns(GDESC).Caption = Get_Caption(waScrItm, "GDESC")
			.Columns(GJOBNO).Caption = Get_Caption(waScrItm, "GJOBNO")
			.Columns(GCUSPO).Caption = Get_Caption(waScrItm, "GCUSPO")
			.Columns(GAMT).Caption = Get_Caption(waScrItm, "GAMT")
		End With
		
		tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO01")
		tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO02")
		
		lblRmkCode.Text = Get_Caption(waScrItm, "RMKCODE")
		lblRmk.Text = Get_Caption(waScrItm, "RMK")
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "APADD")
		wsActNam(2) = Get_Caption(waScrItm, "APEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "APDELETE")
		
		Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	
	Private Sub frmAP001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		'    If Button = 2 Then
		'        PopupMenu mnuMaster
		'    End If
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event frmAP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmAP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(7020)
			Me.Width = VB6.TwipsToPixelsX(9915)
		End If
	End Sub
	
	Private Sub frmAP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
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
        'UPGRADE_NOTE: Object frmAP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
            If Chk_medDocDate Then cboCurr.Focus()
        End If
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


        If Chk_ValidDocDate(medDocDate.Text, "AP") = False Then
            medDocDate.Focus()
            Exit Function
        End If


        Chk_medDocDate = True

    End Function

    Private Sub medDueDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDueDate.Enter

        FocusMe(medDueDate)

    End Sub


    Private Sub medDueDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDueDate.Leave

        FocusMe(medDueDate, True)

    End Sub


    Private Sub medDueDate_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medDueDate.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Chk_medDueDate Then
                tabDetailInfo.SelectedIndex = 0
                cboRmkCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_medDueDate() As Boolean


        Chk_medDueDate = False

        If Trim(medDueDate.Text) = "/  /" Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medDueDate.Focus()
            Exit Function
        End If

        If Chk_Date(medDueDate) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medDueDate.Focus()
            Exit Function
        End If


        If Chk_ValidDocDate(medDueDate.Text, "AP") = False Then
            tabDetailInfo.SelectedIndex = 0
            medDueDate.Focus()
            Exit Function
        End If

        Chk_medDueDate = True

    End Function





    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then

            If cboPayCode.Enabled Then
                cboPayCode.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 1 Then

            If tblDetail.Enabled Then
                tblDetail.Focus()
            End If


        End If
        PreviousTab = tabDetailInfo.SelectedIndex()
    End Sub



    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        'If wcCombo.Name = tblDetail.Name Then
        '	tblDetail.EditActive = True
        '	'UPGRADE_WARNING: Couldn't resolve default property of object wcCombo.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Select Case wcCombo.Col
        '		Case GMLCODE
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
            '		Case GMLCODE
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

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub






    Private Function Chk_KeyExist() As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String


        wsSQL = "SELECT IPHDSTATUS FROM APIPHD WHERE IPHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "'"
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsRcd.RecordCount > 0 Then

            Chk_KeyExist = True

        Else

            Chk_KeyExist = False

        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


    End Function

    Private Function Chk_KeyFld() As Boolean


        Chk_KeyFld = False

        If chk_cboVdrCode = False Then
            Exit Function
        End If

        If Chk_medDocDate = False Then
            Exit Function
        End If

        If Chk_cboCurr = False Then
            Exit Function
        End If

        If txtExcr.Enabled = True Then
            If chk_txtExcr = False Then
                Exit Function
            End If
        End If

        tblDetail.Enabled = True
        Chk_KeyFld = True

    End Function
    Private Function cmdSave() As Boolean

        Dim wsGenDte As String
        Dim wsDteTim As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wlRowCtr As Integer
        Dim wsCtlPrd As String
        Dim wsSts As String
        Dim i As Short
        Dim wdTmpAmt As Double

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate
        wsDteTim = Change_SQLDate(CStr(Now))

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

        adcmdSave.CommandText = "USP_AP001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wsSrcCd)
        Call SetSPPara(adcmdSave, 4, wlKey)
        Call SetSPPara(adcmdSave, 5, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 6, wlVdrID)
        Call SetSPPara(adcmdSave, 7, medDocDate.Text)
        Call SetSPPara(adcmdSave, 8, txtRevNo.Text)
        Call SetSPPara(adcmdSave, 9, cboCurr.Text)
        Call SetSPPara(adcmdSave, 10, txtExcr.Text)

        Call SetSPPara(adcmdSave, 11, Set_MedDate((medDueDate.Text)))

        Call SetSPPara(adcmdSave, 12, 0)

        Call SetSPPara(adcmdSave, 13, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 14, cboPayCode.Text)
        Call SetSPPara(adcmdSave, 15, cboRmkCode.Text)
        Call SetSPPara(adcmdSave, 16, cboJobNo.Text)



        Call SetSPPara(adcmdSave, 17, txtRmk(1).Text)
        Call SetSPPara(adcmdSave, 18, txtRmk(2).Text)
        Call SetSPPara(adcmdSave, 19, txtRmk(3).Text)
        Call SetSPPara(adcmdSave, 20, txtRmk(4).Text)
        Call SetSPPara(adcmdSave, 21, txtRmk(5).Text)
        Call SetSPPara(adcmdSave, 22, "")
        Call SetSPPara(adcmdSave, 23, "")
        Call SetSPPara(adcmdSave, 24, "")
        Call SetSPPara(adcmdSave, 25, "")
        Call SetSPPara(adcmdSave, 26, "")



        Call SetSPPara(adcmdSave, 27, wsFormID)
        Call SetSPPara(adcmdSave, 28, gsUserID)
        Call SetSPPara(adcmdSave, 29, wsGenDte)
        Call SetSPPara(adcmdSave, 30, wsDteTim)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 31)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 32)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_AP001B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, GMLCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, GMLCODE))
                    Call SetSPPara(adcmdSave, 4, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, GDESC))
                    Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, GJOBNO))
                    Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, GCUSPO))
                    wdTmpAmt = CDbl(NBRnd(IIf(wsTrnCd <> "20", To_Value(waResult.get_Value(wiCtr, GAMT)) * -1, To_Value(waResult.get_Value(wiCtr, GAMT))), giAmtDp))
                    Call SetSPPara(adcmdSave, 8, wdTmpAmt)
                    wdTmpAmt = CDbl(NBRnd(IIf(wsTrnCd <> "20", To_Value(waResult.get_Value(wiCtr, GAMT)) * To_Value((txtExcr.Text)) * -1, To_Value(waResult.get_Value(wiCtr, GAMT)) * To_Value((txtExcr.Text))), giAmtDp))
                    Call SetSPPara(adcmdSave, 9, wdTmpAmt)
                    Call SetSPPara(adcmdSave, 10, IIf(wlRowCtr = wiCtr, "Y", "N"))
                    Call SetSPPara(adcmdSave, 11, wsFormID)
                    Call SetSPPara(adcmdSave, 12, gsUserID)
                    Call SetSPPara(adcmdSave, 13, wsGenDte)

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

    Private Function InputValidation() As Boolean

        Dim wsExcRate As String
        Dim wsExcDesc As String


        InputValidation = False

        On Error GoTo InputValidation_Err



        If Not chk_txtRevNo Then Exit Function
        If Not Chk_medDocDate Then Exit Function
        If Not chk_cboVdrCode() Then Exit Function
        If Not getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) Then Exit Function
        If Not chk_txtExcr Then Exit Function

        If Not Chk_cboPayCode Then Exit Function
        If Not Chk_cboMLCode Then Exit Function

        If Not Chk_medDueDate Then Exit Function

        If Not Chk_cboRmkCode Then Exit Function


        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, GMLCODE)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
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

        Dim newForm As New frmAP001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmAP001

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
        ' wsFormID = "AP001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsSrcCd = "AP"
        ' wsTrnCd = "20"

        wsSOPFlg = Get_SystemFlag("SYPINTSOP")


    End Sub



    Private Sub cmdCancel()

        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("AfrActEdit")
        Call SetButtonStatus("AfrActEdit")

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


    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click
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
            Case tcFind
                Call cmdFind()
            Case tcExit
                Me.Close()
        End Select

    End Sub



    Private Sub txtExcr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtExcr.Enter

        FocusMe(txtExcr)

    End Sub

    Private Sub txtExcr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtExcr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call Chk_InpNum(KeyAscii, (txtExcr.Text), False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_txtExcr Then
                If Chk_KeyFld Then
                    tabDetailInfo.SelectedIndex = 0
                    cboPayCode.Focus()
                End If
            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_txtExcr() As Boolean

        chk_txtExcr = False

        If Trim(txtExcr.Text) = "" Or CDbl(Trim(CStr(To_Value((txtExcr.Text))))) = 0 Then
            gsMsg = "必需輸入對換率!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtExcr.Focus()
            Exit Function
        End If

        If To_Value((txtExcr.Text)) > 9999.999999 Then
            gsMsg = "對換率超出範圍!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtExcr.Focus()
            Exit Function
        End If
        txtExcr.Text = VB6.Format(txtExcr.Text, gsExrFmt)

        chk_txtExcr = True

    End Function

    Private Sub txtExcr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtExcr.Leave
        FocusMe(txtExcr, True)
    End Sub

    Private Sub txtRevNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRevNo.Enter
        FocusMe(txtRevNo)
    End Sub

    Private Sub txtRevNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRevNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call Chk_InpNum(KeyAscii, (txtRevNo.Text), False, False)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_txtRevNo Then
                medDocDate.Focus()
            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_txtRevNo() As Boolean

        chk_txtRevNo = False

        If Trim(txtRevNo.Text) = "" Then
            gsMsg = "對換率超出範圍!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtRevNo.Focus()
            Exit Function
        End If

        If To_Value(txtRevNo) > wiRevNo + 1 Or To_Value(txtRevNo) < wiRevNo Then
            gsMsg = "修改號錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtRevNo.Focus()
            Exit Function
        End If

        chk_txtRevNo = True

    End Function

    Private Sub cboVdrCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrCode

        If gsLangID = "1" Then
            wsSQL = "SELECT VdrCode, VdrName FROM mstVendor "
            wsSQL = wsSQL & "WHERE VdrCode LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
            wsSQL = wsSQL & "AND VdrSTATUS = '1' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & "ORDER BY VdrCode "
        Else
            wsSQL = "SELECT VdrCode, VdrName FROM mstVendor "
            wsSQL = wsSQL & "WHERE VdrCode LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
            wsSQL = wsSQL & "AND VdrSTATUS = '1' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & "ORDER BY VdrCode "
        End If
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboVdrCode.Left)), VB6.PixelsToTwipsY(cboVdrCode.Top) + VB6.PixelsToTwipsY(cboVdrCode.Height), tblCommon, wsFormID, "TBLVDRNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboVdrCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.Enter

        wcCombo = cboVdrCode
        'TREtoolsbar1.ButtonEnabled(tcCusSrh) = True
        FocusMe(cboVdrCode)

    End Sub

    Private Sub cboVdrCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(cboVdrCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_cboVdrCode() = False Then GoTo EventExitSub
            If wiAction = AddRec Or wsOldVdrNo <> cboVdrCode.Text Then Call Get_DefVal()

            cboJobNo.Focus()

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_cboVdrCode() As Boolean
        Dim wlID As Integer
        Dim wsName As String
        Dim wsTel As String
        Dim wsFax As String


        chk_cboVdrCode = False


        If Trim(cboVdrCode.Text) = "" Then
            gsMsg = "必需輸入客戶編碼!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboVdrCode.Focus()
            Exit Function
        End If

        If Chk_VdrCode(cboVdrCode.Text, wlID, wsName, wsTel, wsFax) Then
            wlVdrID = wlID
            lblDspVdrName.Text = wsName
            lblDspVdrTel.Text = wsTel
            lblDspVdrFax.Text = wsFax
        Else
            wlVdrID = 0
            lblDspVdrName.Text = ""
            lblDspVdrTel.Text = ""
            lblDspVdrFax.Text = ""
            gsMsg = "客戶不存在!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboVdrCode.Focus()
            Exit Function
        End If

        chk_cboVdrCode = True

    End Function

    Private Sub Get_DefVal()

        Dim rsDefVal As New ADODB.Recordset
        Dim wsSQL As String
        Dim wsExcDesc As String
        Dim wsExcRate As String
        Dim wsCode As String
        Dim wsName As String

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "FROM  mstVendor "
        wsSQL = wsSQL & "WHERE VdrID = " & wlVdrID
        rsDefVal.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDefVal.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboCurr.Text = ReadRs(rsDefVal, "VDRCURR")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboPayCode.Text = ReadRs(rsDefVal, "VDRPAYCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboMLCode.Text = ReadRs(rsDefVal, "VDRMLCODE")

        Else
            cboCurr.Text = ""
            cboPayCode.Text = ""
            cboMLCode.Text = ""


        End If
        rsDefVal.Close()
        'UPGRADE_NOTE: Object rsDefVal may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDefVal = Nothing


        ' get currency code description
        If getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) = True Then
            txtExcr.Text = VB6.Format(wsExcRate, gsExrFmt)
        Else
            txtExcr.Text = VB6.Format("0", gsExrFmt)
        End If

        If UCase(cboCurr.Text) = UCase(wsBaseCurCd) Then
            txtExcr.Text = VB6.Format("1", gsExrFmt)
            txtExcr.Enabled = False
        Else
            txtExcr.Enabled = True
        End If


        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")


        'get Due Date Payment Term
        medDueDate.Text = Dsp_Date(Get_DueDte(cboPayCode.Text, medDocDate.Text))

    End Sub



    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = GMLCODE To GDummy
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case GMLCODE
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10
                    Case GDESC
                        .Columns(wiCtr).Width = 4300
                        .Columns(wiCtr).DataWidth = 100

                    Case GJOBNO
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Button = True
                        '.Columns(wiCtr).Visible = False

                    Case GCUSPO
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).DataWidth = 20

                    Case GAMT
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GDTLID

                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                    Case GDummy
                        .Columns(wiCtr).DataWidth = 0
                        .Columns(wiCtr).Locked = True

                End Select
            Next
            .Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
        End With

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

        With tblDetail
            Select Case eventArgs.ColIndex
                Case GMLCODE

                    If Chk_grdMLCode((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(GJOBNO).Text = cboJobNo.Text

                Case GJOBNO

                    If Chk_grdJobNo((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case GAMT

                    If Chk_Amount((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(eventArgs.ColIndex).Text = VB6.Format(NBRnd(CDbl(.Columns(eventArgs.ColIndex).Text), giAmtDp), gsAmtFmt)

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
				Case GMLCODE
					
					wsSQL = "SELECT MLCODE, MLDESC FROM mstMerchClass "
					wsSQL = wsSQL & " WHERE MLSTATUS <> '2' "
					wsSQL = wsSQL & " AND MLCODE LIKE '%" & Set_Quote(.Columns(GMLCODE).Text) & "%' "
					wsSQL = wsSQL & " AND MLTYPE = 'P' "
					wsSQL = wsSQL & " ORDER BY MLCODE "
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLMLCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
				Case GJOBNO
					
					If wsSOPFlg = "Y" Then
						
						wsSQL = "SELECT SOHDDOCNO, CUSCODE FROM SOASOHD, MSTCUSTOMER "
						wsSQL = wsSQL & " WHERE SOHDSTATUS IN ('1','4') "
						wsSQL = wsSQL & " AND SOHDDOCNO LIKE '%" & Set_Quote(.Columns(GJOBNO).Text) & "%' "
						wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
						wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
					Else
						wsSQL = "SELECT JOBCODE, JOBNAME FROM mstJOB "
						wsSQL = wsSQL & " WHERE JOBSTATUS <> '2' AND JOBCODE LIKE '%" & Set_Quote(.Columns(GJOBNO).Text) & "%' "
						wsSQL = wsSQL & " ORDER BY JOBCODE "
						
					End If
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLJOBCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
						Case GMLCODE, GCUSPO, GJOBNO
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
						Case GDESC
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = GJOBNO
						Case GAMT
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Keys.Down
							.Col = GMLCODE
					End Select
				Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Col <> GMLCODE Then
						.Col = .Col - 1
					End If
					
				Case System.Windows.Forms.Keys.Right
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If .Col <> GAMT Then
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
			
			Case GAMT
				Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), True, True)
				
				
				
		End Select
		
	End Sub
	
	Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
		
		wbErr = False
		On Error GoTo RowColChange_Err
		
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If ActiveControl.Name <> tblDetail.Name Then Exit Sub
		
		With tblDetail
			If IsEmptyRow() Then
				.Col = GMLCODE
			End If
			
			Call Calc_Total()
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					Case GMLCODE
						Call Chk_grdMLCode(.Columns(GMLCODE).Text)
					Case GJOBNO
						Call Chk_grdJobNo((.Columns(GJOBNO).Text))
					Case GAMT
						Call Chk_Amount((.Columns(GAMT).Text))
						
				End Select
			End If
		End With
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
	End Sub
	
	
	
	Private Function Chk_grdMLCode(ByRef inNo As String) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_grdMLCode = False
		
		If Trim(inNo) = "" Then
			Chk_grdMLCode = True
			Exit Function
		End If
		
		wsSQL = "SELECT *  FROM mstMerchClass"
		wsSQL = wsSQL & " WHERE MLCode = '" & Set_Quote(inNo) & "' "
		wsSQL = wsSQL & " AND MLTYPE = 'P' "
		wsSQL = wsSQL & " AND MLSTATUS = '1' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			gsMsg = "沒有此會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_grdMLCode = True
		
		
	End Function
	
	
	
	Private Function Chk_grdJobNo(ByRef inNo As String) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_grdJobNo = False
		
		'  If Trim(inNo) = "" Then
		Chk_grdJobNo = True
		Exit Function
		'  End If
		
		If wsSOPFlg = "Y" Then
			
			wsSQL = "SELECT * FROM SOASOHD "
			wsSQL = wsSQL & " WHERE SOHDDOCNO = '" & Set_Quote(inNo) & "' "
			wsSQL = wsSQL & " AND SOHDSTATUS = '4' "
			
		Else
			
			wsSQL = "SELECT *  FROM mstJob "
			wsSQL = wsSQL & " WHERE JobCode = '" & Set_Quote(inNo) & "' "
			wsSQL = wsSQL & " AND JOBSTATUS = '1' "
			
		End If
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			gsMsg = "沒有此工程!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_grdJobNo = True
		
		
	End Function
	
	
	
	
	
	Private Function Chk_Amount(ByRef inAmt As String) As Short
		
		Chk_Amount = False
		
		If Trim(inAmt) = "" Then
			gsMsg = "必需輸入金額!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If To_Value(inAmt) = 0 Then
			gsMsg = "數量必需大於零!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If To_Value(inAmt) > CDbl(gsMaxVal) Then
			gsMsg = "數量太大!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		Chk_Amount = True
		
	End Function
	
	Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean
		
		IsEmptyRow = True
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inRow) Then
			With tblDetail
				If Trim(.Columns(GMLCODE).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				If Trim(waResult.get_Value(inRow, GMLCODE)) = "" And Trim(waResult.get_Value(inRow, GDESC)) = "" And Trim(waResult.get_Value(inRow, GJOBNO)) = "" And Trim(waResult.get_Value(inRow, GCUSPO)) = "" And Trim(waResult.get_Value(inRow, GAMT)) = "" And Trim(waResult.get_Value(inRow, GDTLID)) = "" Then
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
			
			If Chk_grdMLCode(waResult.get_Value(LastRow, GMLCODE)) = False Then
				.Col = GMLCODE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdJobNo(waResult.get_Value(LastRow, GJOBNO)) = False Then
				.Col = GJOBNO
				.Row = LastRow
				Exit Function
			End If
			
			
			If Chk_Amount(waResult.get_Value(LastRow, GAMT)) = False Then
				.Col = GAMT
				.Row = LastRow
				Exit Function
			End If
			
			
			
			
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
	
	Private Function Calc_Total(Optional ByVal LastRow As Object = Nothing) As Boolean
		
		Dim wiTotal As Double
		
		Dim wiRowCtr As Short
		
		Calc_Total = False
		For wiRowCtr = 0 To waResult.get_UpperBound(1)
			wiTotal = wiTotal + To_Value(waResult.get_Value(wiRowCtr, GAMT))
		Next 
		
		lblDspInvAmtOrg.Text = VB6.Format(CStr(wiTotal), gsAmtFmt)
		lblDspInvAmtLoc.Text = VB6.Format(CStr(wiTotal * To_Value(txtExcr)), gsAmtFmt)
		
		Calc_Total = True
		
	End Function
	
	
	
	
	Private Function cmdDel() As Boolean
		
		Dim wsGenDte As String
		Dim wsDteTim As String
		
		Dim adcmdDelete As New ADODB.Command
		Dim wsDocNo As String
		Dim i As Short
		
		cmdDel = False
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		On Error GoTo cmdDelete_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		wsDteTim = Change_SQLDate(CStr(Now))
		
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
		adcmdDelete.ActiveConnection = cnCon
		
		adcmdDelete.CommandText = "USP_AP001A"
		adcmdDelete.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdDelete.Parameters.Refresh()
		Call SetSPPara(adcmdDelete, 1, wiAction)
		Call SetSPPara(adcmdDelete, 2, wsTrnCd)
		Call SetSPPara(adcmdDelete, 3, wsSrcCd)
		Call SetSPPara(adcmdDelete, 4, wlKey)
		Call SetSPPara(adcmdDelete, 5, Trim(cboDocNo.Text))
		Call SetSPPara(adcmdDelete, 6, wlVdrID)
		Call SetSPPara(adcmdDelete, 7, medDocDate.Text)
		Call SetSPPara(adcmdDelete, 8, txtRevNo.Text)
		Call SetSPPara(adcmdDelete, 9, cboCurr.Text)
		Call SetSPPara(adcmdDelete, 10, txtExcr.Text)
		
		Call SetSPPara(adcmdDelete, 11, Set_MedDate((medDueDate.Text)))
		
		Call SetSPPara(adcmdDelete, 12, 0)
		
		Call SetSPPara(adcmdDelete, 13, cboMLCode.Text)
		Call SetSPPara(adcmdDelete, 14, cboPayCode.Text)
		Call SetSPPara(adcmdDelete, 15, cboRmkCode.Text)
		Call SetSPPara(adcmdDelete, 16, cboJobNo.Text)
		
		
		Call SetSPPara(adcmdDelete, 17, txtRmk(1).Text)
		Call SetSPPara(adcmdDelete, 18, txtRmk(2).Text)
		Call SetSPPara(adcmdDelete, 19, txtRmk(3).Text)
		Call SetSPPara(adcmdDelete, 20, txtRmk(4).Text)
		Call SetSPPara(adcmdDelete, 21, txtRmk(5).Text)
		Call SetSPPara(adcmdDelete, 22, "")
		Call SetSPPara(adcmdDelete, 23, "")
		Call SetSPPara(adcmdDelete, 24, "")
		Call SetSPPara(adcmdDelete, 25, "")
		Call SetSPPara(adcmdDelete, 26, "")
		
		
		
		Call SetSPPara(adcmdDelete, 27, wsFormID)
		Call SetSPPara(adcmdDelete, 28, gsUserID)
		Call SetSPPara(adcmdDelete, 29, wsGenDte)
		Call SetSPPara(adcmdDelete, 30, wsDteTim)
		adcmdDelete.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = GetSPPara(adcmdDelete, 31)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdDelete, 32)
		
		
		cnCon.CommitTrans()
		
		gsMsg = wsDocNo & " 檔案已刪除!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		Call cmdCancel()
		Cursor = System.Windows.Forms.Cursors.Default
		
		'UPGRADE_NOTE: Object adcmdDelete may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdDelete = Nothing
		cmdDel = True
		
		Exit Function
		
cmdDelete_Err: 
		MsgBox("Check cmdDel")
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdDelete may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdDelete = Nothing
		
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
				
				Me.cboDocNo.Enabled = False
				Me.cboVdrCode.Enabled = False
				Me.txtRevNo.Enabled = False
				Me.medDocDate.Enabled = False
				Me.cboCurr.Enabled = False
				Me.txtExcr.Enabled = False
				
				Me.medDueDate.Enabled = False
				Me.cboPayCode.Enabled = False
				Me.cboMLCode.Enabled = False
				Me.cboRmkCode.Enabled = False
				Me.cboJobNo.Enabled = False
				
				
				Me.picRmk.Enabled = False
				
				Me.tblDetail.Enabled = False
				
			Case "AfrActAdd"
				
				Me.cboDocNo.Enabled = True
				
			Case "AfrActEdit"
				
				Me.cboDocNo.Enabled = True
				
			Case "AfrKey"
				Me.cboDocNo.Enabled = False
				
				Me.cboVdrCode.Enabled = True
				Me.txtRevNo.Enabled = True
				Me.medDocDate.Enabled = True
				Me.cboCurr.Enabled = True
				Me.txtExcr.Enabled = True
				
				Me.medDueDate.Enabled = True
				Me.cboPayCode.Enabled = True
				Me.cboMLCode.Enabled = True
				Me.cboRmkCode.Enabled = True
				Me.cboJobNo.Enabled = True
				
				Me.picRmk.Enabled = True
				
				
				If wiAction <> AddRec Then
					Me.tblDetail.Enabled = True
				End If
				
				
				
		End Select
	End Sub
	
	Private Sub GetNewKey()
		Dim Newfrm As New frmKeyInput
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		With Newfrm
			
			.TableID = wsKeyType
			.TableType = wsSrcCd
			.TableKey = "INHDDocNo"
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
		
		Dim vFilterAry(3, 2) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 1) = "Doc No."
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "IPHDDocNo"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "Doc. Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "IPHDDocDate"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 1) = "Vendor #"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 2) = "VdrCode"
		
		Dim vAry(4, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "Doc No."
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "IPHDDocNo"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "IPHDDocDate"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 1) = "Vendor#"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 2) = "VdrCode"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(3, 3) = "2000"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(4, 1) = "Vendor Name"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(4, 2) = "VdrName"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(4, 3) = "5000"
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			wsSQL = "SELECT IpHdDocNo, IphdDocDate, mstVendor.VdrCode,  mstVendor.VdrName "
			wsSQL = wsSQL & "FROM MstVendor, APIPHD "
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE IpHdStatus = '1' And IpHdVdrID = VdrID "
			.sBindOrderSQL = "ORDER BY IpHdDocNo"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmAP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboDocNo.Text Then
			cboDocNo.Text = Trim(frmShareSearch.Tag)
			cboDocNo.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		frmShareSearch.Close()
		
	End Sub
	
	Private Sub cboPayCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPayCode.Enter
		FocusMe(cboPayCode)
	End Sub
	
	Private Sub cboPayCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPayCode.Leave
		FocusMe(cboPayCode, True)
	End Sub
	
	
	Private Sub cboPayCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPayCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsDesc As String
		
		Call chk_InpLen(cboPayCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboPayCode = False Then
				GoTo EventExitSub
			End If
			
			If wsOldPayCd <> cboPayCode.Text Then
				medDueDate.Text = Dsp_Date(Get_DueDte(cboPayCode.Text, medDocDate.Text))
				wsOldPayCd = cboPayCode.Text
			End If
			
			tabDetailInfo.SelectedIndex = 0
			cboMLCode.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboPayCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPayCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboPayCode
		
		wsSQL = "SELECT PAYCODE, PAYDESC FROM mstPayTerm WHERE PAYCODE LIKE '%" & IIf(cboPayCode.SelectionLength > 0, "", Set_Quote(cboPayCode.Text)) & "%' "
		wsSQL = wsSQL & "AND PAYSTATUS = '1' "
		wsSQL = wsSQL & "ORDER BY PAYCODE "
		Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboPayCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboPayCode.Top) + VB6.PixelsToTwipsY(cboPayCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLPAYCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboPayCode() As Boolean
		Dim wsDesc As String
		
		Chk_cboPayCode = False
		
		If Trim(cboPayCode.Text) = "" Then
			gsMsg = "必需輸入付款條款!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 0
			cboPayCode.Focus()
			Exit Function
		End If
		
		
		If Chk_PayTerm(cboPayCode.Text, wsDesc) = False Then
			gsMsg = "沒有此付款條款!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 0
			cboPayCode.Focus()
			lblDspPayDesc.Text = ""
			Exit Function
		End If
		
		lblDspPayDesc.Text = wsDesc
		
		Chk_cboPayCode = True
		
	End Function
	
	
	
	
	
	
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
			
			If Chk_cboMLCode = False Then
				GoTo EventExitSub
			End If
			
			tabDetailInfo.SelectedIndex = 0
			medDueDate.Focus()
			
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
		wsSQL = wsSQL & " AND MLTYPE = 'R' "
		wsSQL = wsSQL & "ORDER BY MLCode "
		Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboMLCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboMLCode.Top) + VB6.PixelsToTwipsY(cboMLCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLMLCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
			tabDetailInfo.SelectedIndex = 0
			cboMLCode.Focus()
			Exit Function
		End If
		
		
		If Chk_MLClass(cboMLCode.Text, "R", wsDesc) = False Then
			gsMsg = "沒有此會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 0
			cboMLCode.Focus()
			lblDspMLDesc.Text = ""
			Exit Function
		End If
		
		lblDspMLDesc.Text = wsDesc
		
		Chk_cboMLCode = True
		
	End Function
	
	
	
	
	
	Private Sub txtRevNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRevNo.Leave
		FocusMe(txtRevNo, True)
	End Sub
	
	
	
	Private Sub cboRmkCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRmkCode.Enter
		FocusMe(cboRmkCode)
	End Sub
	
	Private Sub cboRmkCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRmkCode.Leave
		FocusMe(cboRmkCode, True)
	End Sub
	
	
	Private Sub cboRmkCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboRmkCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		
		Call chk_InpLen(cboRmkCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboRmkCode = False Then
				GoTo EventExitSub
			End If
			
			If wsOldRmkCd <> cboRmkCode.Text Then
				Get_Remark()
				wsOldRmkCd = cboRmkCode.Text
			End If
			
			tabDetailInfo.SelectedIndex = 0
			txtRmk(1).Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboRmkCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRmkCode.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboRmkCode
		
		wsSQL = "SELECT RmkCode FROM mstRemark WHERE RmkCode LIKE '%" & IIf(cboRmkCode.SelectionLength > 0, "", Set_Quote(cboRmkCode.Text)) & "%' "
		wsSQL = wsSQL & "AND RmkSTATUS = '1' "
		wsSQL = wsSQL & "ORDER BY RmkCode "
		Call Ini_Combo(1, wsSQL, VB6.PixelsToTwipsX(cboRmkCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboRmkCode.Top) + VB6.PixelsToTwipsY(cboRmkCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLRMKCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboRmkCode() As Boolean
		
		Chk_cboRmkCode = False
		
		If Trim(cboRmkCode.Text) = "" Then
			Chk_cboRmkCode = True
			Exit Function
		End If
		
		
		If Chk_Remark(cboRmkCode.Text) = False Then
			gsMsg = "沒有此備註!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 0
			cboRmkCode.Focus()
			Exit Function
		End If
		
		
		Chk_cboRmkCode = True
		
	End Function
	
	Private Sub txtRmk_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Enter
		Dim Index As Short = txtRmk.GetIndex(eventSender)
		
		FocusMe(txtRmk(Index))
		
	End Sub
	
	Private Sub txtRmk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtRmk.GetIndex(eventSender)
		
		Call chk_InpLen(txtRmk(Index), 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			
			If Index = 5 Then
				tabDetailInfo.SelectedIndex = 1
				tblDetail.Focus()
			Else
				tabDetailInfo.SelectedIndex = 0
				txtRmk(Index + 1).Focus()
			End If
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Leave
		Dim Index As Short = txtRmk.GetIndex(eventSender)
		
		FocusMe(txtRmk(Index), True)
		
	End Sub
	
	
	
	
	
	Private Sub Get_Remark()
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim i As Short
		
		wsSQL = "SELECT * "
		wsSQL = wsSQL & "FROM  mstReMark "
		wsSQL = wsSQL & "WHERE RmkCode = '" & Set_Quote(cboRmkCode.Text) & "'"
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			
			For i = 1 To 5
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, RmkDESC & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				txtRmk(i).Text = ReadRs(rsRcd, "RmkDESC" & i)
			Next i
			
		Else
			
			For i = 1 To 5
				txtRmk(i).Text = ""
			Next i
			
			
		End If
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Sub
	
	
	
	Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
		If eventArgs.Button = 2 Then
			'UPGRADE_ISSUE: Form method frmAP001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
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
	Private Function Chk_DocNo(ByVal InDocNo As String, ByRef OutStatus As String, ByRef OutTrnCd As String, ByRef OutUpdFlg As String, ByRef OutDocDate As String, ByRef OutPgmNo As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		OutStatus = ""
		OutTrnCd = ""
		OutUpdFlg = ""
		OutDocDate = ""
		Chk_DocNo = False
		
		wsSQL = "SELECT IPHDTRNCODE, IPHDSTATUS, IPHDUPDFLG, IPHDDOCDATE, IPHDPGMNO FROM APIPHD "
		wsSQL = wsSQL & " WHERE IPHDDOCNO = '" & Set_Quote(InDocNo) & "'"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutStatus = ReadRs(rsRcd, "IPHDSTATUS")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutTrnCd = ReadRs(rsRcd, "IPHDTRNCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutUpdFlg = ReadRs(rsRcd, "IPHDUPDFLG")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutDocDate = ReadRs(rsRcd, "IPHDDOCDATE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutPgmNo = ReadRs(rsRcd, "IPHDPGMNO")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		
		Chk_DocNo = True
		
		
	End Function
	
	
	
	Private Sub cboJobNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboJobNo
		
		wsSQL = "SELECT SOHDDOCNO, SOHDSHIPFROM FROM SOASOHD "
		wsSQL = wsSQL & "WHERE SOHDDOCNO LIKE '%" & IIf(cboJobNo.SelectionLength > 0, "", Set_Quote(cboJobNo.Text)) & "%' "
		wsSQL = wsSQL & "AND SOHDSTATUS IN ('1','4') "
		wsSQL = wsSQL & "ORDER BY SOHDDOCNO "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboJobNo.Left)), VB6.PixelsToTwipsY(cboJobNo.Top) + VB6.PixelsToTwipsY(cboJobNo.Height), tblCommon, wsFormID, "TBLJOBCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboJobNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.Enter
		
		wcCombo = cboJobNo
		FocusMe(cboJobNo)
		
	End Sub
	
	Private Sub cboJobNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.Leave
		FocusMe(cboJobNo, True)
	End Sub
	
	Private Sub cboJobNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboJobNo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLen(cboJobNo, 15, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			If Chk_cboJobNo() = False Then GoTo EventExitSub
			
			cboCurr.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function Chk_cboJobNo() As Boolean
		
		
		Chk_cboJobNo = False
		
		If Trim(cboJobNo.Text) = "" Then
			Chk_cboJobNo = True
			Exit Function
		End If
		
		
		
		Chk_cboJobNo = True
		
	End Function
End Class