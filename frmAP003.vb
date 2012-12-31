Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAP003
	Inherits System.Windows.Forms.Form
	
	
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waInvoice As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	
	
	
	Private wsOldVdrNo As String
	Private wsOldCurCd As String
	Private wsTmpMl As String
	Private wbLocked As Boolean
	Private wsCtlDte As String
	
	Private wbReadOnly As Boolean
	
	Private Const IINVNO As Short = 0
	Private Const ILINE As Short = 1
	Private Const ICURR As Short = 2
	Private Const IOSAMT As Short = 3
	Private Const ISETAMTORG As Short = 4
	Private Const ISETAMTLOC As Short = 5
	Private Const IEXCR As Short = 6
	Private Const IIPDTID As Short = 7
	Private Const IDummy As Short = 8
	
	
	
	
	Private Const OMLCODE As Short = 0
	Private Const OCURR As Short = 1
	Private Const OEXCR As Short = 2
	Private Const OOTHAMTORG As Short = 3
	Private Const OOTHAMTLOC As Short = 4
	Private Const ODummy As Short = 5
	
	
	
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
	Private wlVdrID As Integer
	Private wlSaleID As Integer
	
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "APSTHD"
	Private Const wsInvKeyType As String = "APIPHD" 'Use for the locking
	
	Private wsFormID As String
	Private wsUsrId As String
	
	Private wsSrcCd As String
	
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	Private wsBaseExcr As String
	
	
	
	
	
	Private wsFormCaption As String
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waInvoice.ReDim(0, -1, IINVNO, IIPDTID)
		tblInvoice.Array = waInvoice
		tblInvoice.ReBind()
		tblInvoice.Bookmark = 0
		
		waResult.ReDim(0, -1, OMLCODE, OOTHAMTLOC)
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
		Call SetFieldStatus("RemFalse")
		
		
		Call SetDateMask(medDocDate)
		
		wsCtlDte = getCtrlMth("AP")
		
		
		wsOldVdrNo = ""
		wsOldCurCd = ""
		wsTmpMl = ""
		
		wlKey = 0
		wlVdrID = 0
		wbReadOnly = False
		
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
					cboMLCode.Focus()
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
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCurr
		
		wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE WHERE EXCCURR LIKE '%" & IIf(cboCurr.SelectionLength > 0, "", Set_Quote(cboCurr.Text)) & "%' "
		wsSQL = wsSQL & " AND EXCMN = '" & To_Value(VB.Right(wsCtlDte, 2)) & "' "
		wsSQL = wsSQL & " AND EXCYR = '" & Set_Quote(VB.Left(wsCtlDte, 4)) & "' "
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
		
		
		wsSQL = "SELECT APSHDOCNO, APSHDOCDATE "
		wsSQL = wsSQL & " FROM APSTHD "
		wsSQL = wsSQL & " WHERE APSHDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
		'    wsSql = wsSql & " AND APSHUPDFLG = 'N'"
		'    wsSql = wsSql & " AND APSHSTATUS = '1'"
		'    wsSql = wsSql & " AND APSHPGMNO = '" & wsFormID & "' "
		wsSQL = wsSQL & " ORDER BY APSHDOCNO, APSHDOCDATE "
		
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboDocNo.Left)), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Dim wsPgmNo As String
		
		Chk_cboDocNo = False
		
		If Trim(cboDocNo.Text) = "" And Chk_AutoGen("PV") = "N" Then
			gsMsg = "必需輸入文件號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNo.Focus()
			Exit Function
		End If
		
		
		If Chk_DocNo(cboDocNo.Text, wsStatus, wsUpdFlg, wsPgmNo) = True Then
			
			If wsPgmNo <> wsFormID Then
				gsMsg = "This is not a valid form code!"
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
			
			
			
		Else
			
			wsSQL = "SELECT APCQCHQID FROM APCHEQUE "
			wsSQL = wsSQL & " WHERE APCQCHQNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND APCQPGMNO <> '" & wsFormID & "' "
			
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				gsMsg = "Document No has been already used by Cheque!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			
			wsSQL = "SELECT IPHDDOCNO FROM APIPHD "
			wsSQL = wsSQL & " WHERE IPHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND IPHDPGMNO <> '" & wsFormID & "' "
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				gsMsg = "Document No has been already used by Invoice!"
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
			medDocDate.Text = Dsp_Date(Now)
			Call SetButtonStatus("AfrKeyAdd")
			Call SetFieldStatus("AfrKeyAdd")
		Else
			wiAction = CorRec
			wbLocked = False
			If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
				gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				tblDetail.ReBind()
				wbLocked = True
			End If
			wsOldVdrNo = cboVdrCode.Text
			wsOldCurCd = cboCurr.Text
			
			
			If UCase(cboCurr.Text) = UCase(wsBaseCurCd) Then
				txtExcr.Text = VB6.Format("1", gsExrFmt)
				txtExcr.Enabled = False
			Else
				txtExcr.Enabled = True
			End If
			Call SetButtonStatus("AfrKeyEdit")
			Call SetFieldStatus("AfrKeyEdit")
			
		End If
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		
		Call SetFieldStatus("AfrKey")
		
		If cboVdrCode.Enabled = False Then
			cboCurr.Focus()
		Else
			cboVdrCode.Focus()
		End If
		
	End Sub
	
	
	
	
	
	
	
	
	
	
	'UPGRADE_WARNING: Form event frmAP003.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmAP003_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboDocNo
			Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
		End If
		
	End Sub
	
	
	Private Sub frmAP003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmAP003_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
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
		
		
		wsSQL = "SELECT APSHDOCID, APSHDOCNO, APSHVDRID, VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, "
		wsSQL = wsSQL & "APSHDOCDATE, APSHCURR, APSHEXCR, APSHCATCODE, APSHMLCODE, "
		wsSQL = wsSQL & "APSHCHQAMT, APSHCHQAMTL, APSHREMARK "
		wsSQL = wsSQL & "FROM  APSTHD, mstVENDOR "
		wsSQL = wsSQL & "WHERE APSHDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
		wsSQL = wsSQL & "AND APSHVDRID = VDRID "
		wsSQL = wsSQL & "AND APSHPGMNO = '" & wsFormID & "'"
		wsSQL = wsSQL & "AND APSHSTATUS <> '2'"
		
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = ReadRs(rsRcd, "APSHDOCID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		medDocDate.Text = ReadRs(rsRcd, "APSHDOCDATE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlVdrID = ReadRs(rsRcd, "VDRID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboVdrCode.Text = ReadRs(rsRcd, "VDRCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspVdrName.Text = ReadRs(rsRcd, "VDRNAME")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspVdrTel.Text = ReadRs(rsRcd, "VDRTEL")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspVdrFax.Text = ReadRs(rsRcd, "VDRFAX")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboCurr.Text = ReadRs(rsRcd, "APSHCURR")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtExcr.Text = VB6.Format(ReadRs(rsRcd, "APSHEXCR"), gsExrFmt)
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtChqAmtOrg.Text = NBRnd(ReadRs(rsRcd, "APSHCHQAMT"), giAmtDp)
		If To_Value((txtChqAmtOrg.Text)) > 0 Then Call SetFieldStatus("RemTrue")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		LblDspChqAmtLoc.Text = NBRnd(ReadRs(rsRcd, "APSHCHQAMTL"), giAmtDp)
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboMLCode.Text = ReadRs(rsRcd, "APSHMLCODE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRmk.Text = ReadRs(rsRcd, "APSHREMARK")
		lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")
		
		rsRcd.Close()
		
		
		wsSQL = " SELECT IPDTID, IPHDDOCNO, IPDTDOCLINE, APSDCURR, IPDTBALAMT AS BAL, "
		wsSQL = wsSQL & " APSDTRNAMT * -1 AS TRNAMT, APSDTRNAMTL * -1 AS TRNAMTL, IPHDEXCR "
		wsSQL = wsSQL & " FROM  APSTDT, APIPDT, APIPHD "
		wsSQL = wsSQL & " WHERE APSDDOCID  = " & wlKey
		wsSQL = wsSQL & " AND   APSDLNTYP  = 'I' "
		wsSQL = wsSQL & " AND   APSDIPDTID = IPDTID "
		wsSQL = wsSQL & " AND   IPHDDOCID = IPDTDOCID "
		wsSQL = wsSQL & " ORDER BY APSDDOCLINE "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			
			rsRcd.MoveFirst()
			With waInvoice
				.ReDim(0, -1, IINVNO, IIPDTID)
				Do While Not rsRcd.EOF
					.AppendRows()
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waInvoice.get_Value(.get_UpperBound(1), IINVNO) = ReadRs(rsRcd, "IPHDDOCNO")
					waInvoice.get_Value(.get_UpperBound(1), ILINE) = VB6.Format(To_Value(ReadRs(rsRcd, "IPDTDOCLINE")), "000")
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waInvoice.get_Value(.get_UpperBound(1), ICURR) = ReadRs(rsRcd, "APSDCURR")
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waInvoice.get_Value(.get_UpperBound(1), IEXCR) = ReadRs(rsRcd, "IPHDEXCR")
					waInvoice.get_Value(.get_UpperBound(1), IOSAMT) = NBRnd(To_Value(ReadRs(rsRcd, "BAL")) + To_Value(ReadRs(rsRcd, "TRNAMT")), giAmtDp)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waInvoice.get_Value(.get_UpperBound(1), ISETAMTORG) = VB6.Format(ReadRs(rsRcd, "TRNAMT"), gsAmtFmt)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waInvoice.get_Value(.get_UpperBound(1), ISETAMTLOC) = VB6.Format(ReadRs(rsRcd, "TRNAMTL"), gsAmtFmt)
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waInvoice.get_Value(.get_UpperBound(1), IIPDTID) = ReadRs(rsRcd, "IPDTID")
					
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If NoMoreInvNo(waInvoice, ReadRs(rsRcd, "IPHDDOCNO"), .get_UpperBound(1)) Then
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If RowLock(wsConnTime, wsInvKeyType, ReadRs(rsRcd, "IPHDDOCNO"), wsFormID, wsUsrId) = False Then
							gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
							MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
						End If
					End If
					
					rsRcd.MoveNext()
				Loop 
			End With
			tblInvoice.ReBind()
			tblInvoice.FirstRow = 0
			
		End If
		rsRcd.Close()
		
		
		wsSQL = " SELECT APSDMLCODE, APSDDOCLINE, APSDCURR, APSDEXCR, "
		wsSQL = wsSQL & " APSDTRNAMT, APSDTRNAMTL "
		wsSQL = wsSQL & " FROM  APSTDT "
		wsSQL = wsSQL & " WHERE APSDDOCID  = " & wlKey
		wsSQL = wsSQL & " AND   APSDLNTYP  = 'O' "
		wsSQL = wsSQL & " ORDER BY APSDDOCLINE "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			
			rsRcd.MoveFirst()
			With waResult
				.ReDim(0, -1, OMLCODE, OOTHAMTLOC)
				Do While Not rsRcd.EOF
					.AppendRows()
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waResult.get_Value(.get_UpperBound(1), OMLCODE) = ReadRs(rsRcd, "APSDMLCODE")
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waResult.get_Value(.get_UpperBound(1), OCURR) = ReadRs(rsRcd, "APSDCURR")
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waResult.get_Value(.get_UpperBound(1), OEXCR) = ReadRs(rsRcd, "APSDEXCR")
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					waResult.get_Value(.get_UpperBound(1), OOTHAMTORG) = VB6.Format(To_Value(ReadRs(rsRcd, "APSDTRNAMT") * -1), gsAmtFmt)
					waResult.get_Value(.get_UpperBound(1), OOTHAMTLOC) = VB6.Format(To_Value(ReadRs(rsRcd, "APSDTRNAMTL")) * -1, gsAmtFmt)
					
					rsRcd.MoveNext()
				Loop 
			End With
			tblDetail.ReBind()
			tblDetail.FirstRow = 0
			
		End If
		
		rsRcd.Close()
		
		
		wsSQL = " SELECT APSDMLCODE, IPHDMLCODE, "
		wsSQL = wsSQL & " APSDTRNAMT, APSDTRNAMTL "
		wsSQL = wsSQL & " FROM  APSTHD, APSTDT, APIPHD "
		wsSQL = wsSQL & " WHERE APSDDOCID  = " & wlKey
		wsSQL = wsSQL & " AND APSDLNTYP  = 'R' "
		wsSQL = wsSQL & " AND APSHDOCID  = APSDDOCID "
		wsSQL = wsSQL & " AND APSHDOCNO  = IPHDDOCNO "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtRemAmt.Text = NBRnd(0 - CDbl(NBRnd(ReadRs(rsRcd, "APSDTRNAMT"), giAmtDp)), giAmtDp)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblDspRemAmtl.Text = NBRnd(0 - CDbl(NBRnd(ReadRs(rsRcd, "APSDTRNAMTL"), giAmtDp)), giAmtDp)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboTMPML.Text = ReadRs(rsRcd, "IPHDMLCODE")
			LblDspRemDte.Text = medDocDate.Text
			
		Else
			txtRemAmt.Text = NBRnd(CDbl("0"), giAmtDp)
			cboTMPML.Text = ""
			
		End If
		
		lblDspTmpMlDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboTMPML.Text) & "'", "MLDESC")
		
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Call Calc_ChargeTotal()
		Call Calc_InvTotal()
		
		
		LoadRecord = True
		
	End Function
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
		lblVdrCode.Text = Get_Caption(waScrItm, "VDRCODE")
		lblVdrName.Text = Get_Caption(waScrItm, "VDRNAME")
		lblVdrTel.Text = Get_Caption(waScrItm, "VDRTEL")
		lblVdrFax.Text = Get_Caption(waScrItm, "VDRFAX")
		lblCurr.Text = Get_Caption(waScrItm, "CURR")
		lblExcr.Text = Get_Caption(waScrItm, "EXCR")
		
		lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
		lblTmpMl.Text = Get_Caption(waScrItm, "TMPML")
		
		lblChqAmtOrg.Text = Get_Caption(waScrItm, "CHQAMTORG")
		lblChqAmtLoc.Text = Get_Caption(waScrItm, "CHQAMTLOC")
		lblRemAmtOrg.Text = Get_Caption(waScrItm, "REMAMTORG")
		lblRemAmtLoc.Text = Get_Caption(waScrItm, "REMAMTLOC")
		lblChqDte.Text = Get_Caption(waScrItm, "CHQDATE")
		
		lblInvAmt.Text = Get_Caption(waScrItm, "INVAMT")
		lblUnInvAmt.Text = Get_Caption(waScrItm, "UNINVAMT")
		lblOthAmt.Text = Get_Caption(waScrItm, "OTHAMT")
		lblUnOthAmt.Text = Get_Caption(waScrItm, "UNOTHAMT")
		
		With tblInvoice
			.Columns(IINVNO).Caption = Get_Caption(waScrItm, "IINVNO")
			.Columns(ILINE).Caption = Get_Caption(waScrItm, "ILINE")
			.Columns(ICURR).Caption = Get_Caption(waScrItm, "ICURR")
			.Columns(IOSAMT).Caption = Get_Caption(waScrItm, "IOSAMT")
			.Columns(ISETAMTORG).Caption = Get_Caption(waScrItm, "ISETAMTORG")
			.Columns(ISETAMTLOC).Caption = Get_Caption(waScrItm, "ISETAMTLOC")
		End With
		
		
		With tblDetail
			.Columns(OMLCODE).Caption = Get_Caption(waScrItm, "OMLCODE")
			.Columns(OCURR).Caption = Get_Caption(waScrItm, "OCURR")
			.Columns(OEXCR).Caption = Get_Caption(waScrItm, "OEXCR")
			.Columns(OOTHAMTORG).Caption = Get_Caption(waScrItm, "OOTHAMTORG")
			.Columns(OOTHAMTLOC).Caption = Get_Caption(waScrItm, "OOTHAMTLOC")
		End With
		
		tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO01")
		tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO02")
		
		lblRmk.Text = Get_Caption(waScrItm, "RMK")
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "ARADD")
		wsActNam(2) = Get_Caption(waScrItm, "AREDIT")
		wsActNam(3) = Get_Caption(waScrItm, "ARELETE")
		
		Call Ini_PopMenu(mnuIPopUpSub, "POPUP", waPopUpSub)
		Call Ini_PopMenu(mnuOPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	
	Private Sub frmAP003_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		'    If Button = 2 Then
		'        PopupMenu mnuMaster
		'    End If
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event frmAP003.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmAP003_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(7020)
			Me.Width = VB6.TwipsToPixelsX(9915)
		End If
	End Sub
	
	Private Sub frmAP003_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waInvoice = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        '    Set waPgmItm = Nothing
        'UPGRADE_NOTE: Object frmAP003 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() '  = Nothing

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








    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then

            If tblInvoice.Enabled Then
                tblInvoice.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 1 Then

            If tblDetail.Enabled Then
                tblDetail.Focus()
            End If


        End If
        PreviousTab = tabDetailInfo.SelectedIndex()
    End Sub



    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        If wcCombo.Name = tblDetail.Name Then
            tblDetail.EditActive = True
            wcCombo.Text = tblCommon.Columns(0).Text

        ElseIf wcCombo.Name = tblInvoice.Name Then
            tblInvoice.EditActive = True
            wcCombo.Text = tblCommon.Columns(0).Text

            If tblInvoice.Col = IINVNO Then
                tblInvoice.Columns(ILINE).Text = tblCommon.Columns(1).Text
            End If
        Else
            wcCombo.Text = tblCommon.Columns(0).Text
        End If

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
            If wcCombo.Name = tblDetail.Name Then
                tblDetail.EditActive = True
                wcCombo.Text = tblCommon.Columns(0).Text

            ElseIf wcCombo.Name = tblInvoice.Name Then
                tblInvoice.EditActive = True
                wcCombo.Text = tblCommon.Columns(0).Text

                If tblInvoice.Col = IINVNO Then
                    tblInvoice.Columns(ILINE).Text = tblCommon.Columns(1).Text
                End If
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






    Private Function Chk_KeyExist() As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String


        wsSQL = "SELECT APSHSTATUS FROM APSTHD WHERE APSHDOCNO = '" & Set_Quote(cboDocNo.Text) & "'"
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
        tblInvoice.Enabled = True

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

        'check each detail line
        If Chk_LockedRecords Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
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

        adcmdSave.CommandText = "USP_AP003A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wlKey)
        Call SetSPPara(adcmdSave, 3, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 4, wlVdrID)
        Call SetSPPara(adcmdSave, 5, medDocDate.Text)
        Call SetSPPara(adcmdSave, 6, cboCurr.Text)
        Call SetSPPara(adcmdSave, 7, txtExcr.Text)
        Call SetSPPara(adcmdSave, 8, To_Value((txtChqAmtOrg.Text)))
        Call SetSPPara(adcmdSave, 9, NBRnd(To_Value((txtExcr.Text)) * To_Value((txtChqAmtOrg.Text)), giAmtDp))
        Call SetSPPara(adcmdSave, 10, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 11, "")
        Call SetSPPara(adcmdSave, 12, txtRmk.Text)
        Call SetSPPara(adcmdSave, 13, wsFormID)
        Call SetSPPara(adcmdSave, 14, gsUserID)
        Call SetSPPara(adcmdSave, 15, wsGenDte)
        Call SetSPPara(adcmdSave, 16, wsDteTim)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 17)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 18)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        If waInvoice.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_AP003B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waInvoice.get_UpperBound(1)
                If IsEmptyInvRow(wiCtr) = False Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, waInvoice.get_Value(wiCtr, IIPDTID))
                    Call SetSPPara(adcmdSave, 4, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 5, cboMLCode.Text)
                    Call SetSPPara(adcmdSave, 6, "")
                    Call SetSPPara(adcmdSave, 7, "")
                    Call SetSPPara(adcmdSave, 8, "")
                    Call SetSPPara(adcmdSave, 9, waInvoice.get_Value(wiCtr, ICURR))
                    Call SetSPPara(adcmdSave, 10, "")
                    Call SetSPPara(adcmdSave, 11, waInvoice.get_Value(wiCtr, ISETAMTORG))
                    Call SetSPPara(adcmdSave, 12, waInvoice.get_Value(wiCtr, ISETAMTLOC))
                    Call SetSPPara(adcmdSave, 13, "")
                    Call SetSPPara(adcmdSave, 14, medDocDate.Text)
                    Call SetSPPara(adcmdSave, 15, waInvoice.get_Value(wiCtr, IEXCR))
                    Call SetSPPara(adcmdSave, 16, "I")
                    Call SetSPPara(adcmdSave, 17, wsFormID)
                    Call SetSPPara(adcmdSave, 18, gsUserID)
                    Call SetSPPara(adcmdSave, 19, wsGenDte)

                    adcmdSave.Execute()
                End If
            Next
        End If

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_AP003B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If IsEmptyRow(wiCtr) = False Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, "")
                    Call SetSPPara(adcmdSave, 4, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, OMLCODE))
                    Call SetSPPara(adcmdSave, 6, "")
                    Call SetSPPara(adcmdSave, 7, "")
                    Call SetSPPara(adcmdSave, 8, "")
                    Call SetSPPara(adcmdSave, 9, waResult.get_Value(wiCtr, OCURR))
                    Call SetSPPara(adcmdSave, 10, waResult.get_Value(wiCtr, OEXCR))
                    Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, OOTHAMTORG))
                    Call SetSPPara(adcmdSave, 12, NBRnd(To_Value(waResult.get_Value(wiCtr, OOTHAMTORG) * To_Value(waResult.get_Value(wiCtr, OEXCR))), giAmtDp))
                    Call SetSPPara(adcmdSave, 13, "")
                    Call SetSPPara(adcmdSave, 14, medDocDate.Text)
                    Call SetSPPara(adcmdSave, 15, "")
                    Call SetSPPara(adcmdSave, 16, "O")
                    Call SetSPPara(adcmdSave, 17, wsFormID)
                    Call SetSPPara(adcmdSave, 18, gsUserID)
                    Call SetSPPara(adcmdSave, 19, wsGenDte)

                    adcmdSave.Execute()
                End If
            Next
        End If



        If To_Value((txtRemAmt.Text)) <> 0 Then

            adcmdSave.CommandText = "USP_AP003B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            Call SetSPPara(adcmdSave, 1, wiAction)
            Call SetSPPara(adcmdSave, 2, wlKey)
            Call SetSPPara(adcmdSave, 3, "")
            Call SetSPPara(adcmdSave, 4, 1)
            Call SetSPPara(adcmdSave, 5, cboTMPML.Text)
            Call SetSPPara(adcmdSave, 6, "")
            Call SetSPPara(adcmdSave, 7, "")
            Call SetSPPara(adcmdSave, 8, "")
            Call SetSPPara(adcmdSave, 9, cboCurr.Text)
            Call SetSPPara(adcmdSave, 10, txtExcr.Text)
            Call SetSPPara(adcmdSave, 11, txtRemAmt.Text)
            Call SetSPPara(adcmdSave, 12, lblDspRemAmtl)
            Call SetSPPara(adcmdSave, 13, "")
            Call SetSPPara(adcmdSave, 14, medDocDate.Text)
            Call SetSPPara(adcmdSave, 15, "")
            Call SetSPPara(adcmdSave, 16, "R")
            Call SetSPPara(adcmdSave, 17, wsFormID)
            Call SetSPPara(adcmdSave, 18, gsUserID)
            Call SetSPPara(adcmdSave, 19, wsGenDte)

            adcmdSave.Execute()

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


        If To_Value((lblDspUnInvAmt.Text)) <> 0 Then
            gsMsg = "Undistributed Amount must equal 0!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        If Not Chk_medDocDate Then Exit Function
        If Not chk_cboVdrCode() Then Exit Function
        If Not getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) Then Exit Function
        If Not chk_txtExcr Then Exit Function

        If Not Chk_cboMLCode Then Exit Function
        If Not Chk_txtChqAmtOrg((txtChqAmtOrg.Text)) Then Exit Function
        If Not Chk_txtRemAmt((txtRemAmt.Text)) Then Exit Function
        If To_Value((txtRemAmt.Text)) <> 0 Then
            If Not Chk_cboTmpML Then Exit Function
        End If

        tabDetailInfo.SelectedIndex = 0

        If waInvoice.get_UpperBound(1) < 0 Then
            gsMsg = "No Invoice Information!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tblInvoice.Focus()
            Exit Function
        End If

        With tblInvoice
            If .EditActive = True Then Exit Function
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
            If Chk_InvGrdRow(.FirstRow + .Row) = False Then
                .Focus()
                Exit Function
            End If
        End With



        If Chk_NoDup(To_Value((tblInvoice.Bookmark))) = False Then
            tblInvoice.FirstRow = tblInvoice.Row
            tblInvoice.Col = IINVNO
            tblInvoice.Focus()
            Exit Function
        End If

        With tblDetail
            If .EditActive = True Then Exit Function
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
            If Chk_GrdRow(To_Value(.FirstRow) + .Row) = False Then
                tabDetailInfo.SelectedIndex = 1
                .Focus()
                Exit Function
            End If
        End With


        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function



    Private Sub cmdNew()

        Dim newForm As New frmAP003

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmAP003

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
        wsFormID = "AP003"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        If getExcRate(wsBaseCurCd, wsConnTime, wsBaseExcr, "") = False Then
            wsBaseExcr = VB6.Format(1, gsExrFmt)
        End If
        wsSrcCd = "AP"





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


    Private Sub tblDetail_OnAddNew(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblDetail.OnAddNew

        With tblDetail
            If Trim(.Columns(OCURR).Text) = "" Then
                .Columns(OCURR).Text = wsBaseCurCd
                .Columns(OEXCR).Text = wsBaseExcr
            End If
        End With

        Call chk_BaseCurr()
    End Sub

    Private Sub tblInvoice_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblInvoice.AfterColUpdate

        On Error GoTo tblInvoice_AfterColUpdate_Err

        With tblInvoice
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

        Exit Sub

tblInvoice_AfterColUpdate_Err:
        MsgBox("tblInvoice_AfterColUpdate_Err")

    End Sub
    Private Sub tblInvoice_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblInvoice.BeforeColUpdate

        Dim wsExcr As String

        On Error GoTo Tbl_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblInvoice.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblInvoice
            Select Case eventArgs.ColIndex
                Case IINVNO
                    If To_Value((tblInvoice.Columns(ILINE).Text)) <> 0 Then
                        If Chk_InvNo(tblInvoice.Columns(IINVNO).Text, CStr(To_Value((tblInvoice.Columns(ILINE).Text))), True) = False Then
                            tblInvoice.Col = IINVNO
                            tblInvoice.Focus()
                            GoTo Tbl_BeforeColUpdate_Err
                            Exit Sub
                        End If
                    End If


                    'unlock the old value if no longer exist in lock table
                    'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                    If Not IsNothing(eventArgs.OldValue) Or eventArgs.OldValue <> "" Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If NoMoreInvNo(waInvoice, eventArgs.OldValue, .Bookmark) Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Call RowUnLock(wsConnTime, wsInvKeyType, eventArgs.OldValue, wsFormID)
                        End If
                    End If

                    'Lock the new value
                    'if same inv no has been locked, then no need to lock again
                    If NoMoreInvNo(waInvoice, .Columns(IINVNO).Text) Then
                        If RowLock(wsConnTime, wsInvKeyType, .Columns(IINVNO).Text, wsFormID, wsUsrId) = False Then
                            gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        End If
                    End If

                Case ILINE
                    If Not Chk_NoDup(.Row + .FirstRow) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_InvNo(.Columns(IINVNO).Text, .Columns(ILINE).Text, True) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case ICURR

                    If Chk_Curr((.Columns(ICURR).Text), medDocDate.Text) = False Then
                        gsMsg = "No Such Currency Code!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If getExcRate((.Columns(ICURR).Text), (medDocDate.Text), wsExcr, "") = False Then
                        gsMsg = "No Exchange Rate at this period!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        wsExcr = VB6.Format(0, gsExrFmt)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If

                    tblInvoice.Columns(IEXCR).Text = wsExcr
                    Call Calc_InvTotal()
                    Call Calc_ChargeTotal()


                Case ISETAMTORG

                    If To_Value(.Columns(ISETAMTORG)) < 0 Then
                        .Columns(ISETAMTORG).Text = NBRnd(System.Math.Abs(CDbl(.Columns(ISETAMTORG).Text)) * -1, giAmtDp)
                    End If

                    If Chk_Amount((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If System.Math.Abs(To_Value((.Columns(ISETAMTORG).Text))) > System.Math.Abs(To_Value((.Columns(IOSAMT).Text))) Then
                        gsMsg = "Settlement Amount cannot greater than Outstanding Amt!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(ISETAMTORG).Text = NBRnd(CDbl(.Columns(ISETAMTORG).Text), giAmtDp)
                    .Columns(ISETAMTLOC).Text = NBRnd(CDbl(NBRnd(To_Value((.Columns(ISETAMTORG).Text)) * To_Value((.Columns(IEXCR).Text)), giAmtDp)), giAmtDp)
                    Call Calc_InvTotal()
                    Call Calc_ChargeTotal()

            End Select

        End With

        Exit Sub

Tbl_BeforeColUpdate_Err:

        'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tblInvoice.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
        eventArgs.cancel = True

    End Sub
    Private Sub tblInvoice_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblInvoice.BeforeRowColChange
        On Error GoTo tblInvoice_BeforeRowColChange_Err
        With tblInvoice
            'UPGRADE_WARNING: Couldn't resolve default property of object tblInvoice.DestinationRow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tblInvoice.Bookmark. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If .Bookmark <> .DestinationRow Then
                If Chk_InvGrdRow(To_Value(.Bookmark)) = False Then
                    eventArgs.cancel = True
                    Exit Sub
                End If
            End If
        End With
        Exit Sub

tblInvoice_BeforeRowColChange_Err:
        MsgBox("tblInvoice_BeforeRowColChange_Err!")
        eventArgs.cancel = True
    End Sub

    Private Sub tblInvoice_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent) Handles tblInvoice.ButtonClick

        Dim wsSQL As String
        Dim wiCtr As Short

        On Error GoTo tblInvoice_ButtonClick_Err

        With tblInvoice
            wcCombo = tblInvoice

            Select Case eventArgs.ColIndex
                Case IINVNO

                    wsSQL = "SELECT IPHDDOCNO ,"
                    wsSQL = wsSQL & " CONVERT(NVARCHAR(5), REPLICATE('0',3 - LEN(LTRIM(CONVERT(NVARCHAR(3),IPDTDOCLINE))))  + CONVERT(NVARCHAR(3),IPDTDOCLINE)), "
                    wsSQL = wsSQL & " IPHDJOBNO, "
                    wsSQL = wsSQL & " IPDTINVAMT, "
                    wsSQL = wsSQL & " IPDTBALAMT FROM APIPHD, APIPDT "
                    wsSQL = wsSQL & " WHERE IPHDDOCNO LIKE '%" & IIf(Trim(.SelText) <> "", "", Set_Quote(.Columns(IINVNO).Text)) & "%'"
                    wsSQL = wsSQL & " AND IPHDDOCDATE <= '" & Set_Quote(medDocDate.Text) & "'"
                    wsSQL = wsSQL & " AND IPHDVDRID = " & wlVdrID
                    wsSQL = wsSQL & " AND IPDTBALAMT <> 0  "
                    wsSQL = wsSQL & " AND IPHDSTATUS <> '2' "
                    wsSQL = wsSQL & " AND IPHDDOCID = IPDTDOCID "

                    If waInvoice.get_UpperBound(1) > -1 Then
                        wsSQL = wsSQL & " AND IPHDDOCNO + CONVERT(NVARCHAR(5), REPLICATE('0',3 - LEN(LTRIM(CONVERT(NVARCHAR(3),IPDTDOCLINE))))  + CONVERT(NVARCHAR(3),IPDTDOCLINE)) NOT IN ( "
                        For wiCtr = 0 To waInvoice.get_UpperBound(1)
                            wsSQL = wsSQL & " '" & waInvoice.get_Value(wiCtr, IINVNO) & waInvoice.get_Value(wiCtr, ILINE) & IIf(wiCtr = waInvoice.get_UpperBound(1), "' )", "' ,")
                        Next
                    End If
                    wsSQL = wsSQL & " ORDER BY IPHDDOCNO, CONVERT(NVARCHAR(5), REPLICATE('0',3 - LEN(LTRIM(CONVERT(NVARCHAR(3),IPDTDOCLINE))))  + CONVERT(NVARCHAR(3),IPDTDOCLINE))"

                    Call Ini_Combo(5, wsSQL, VB6.PixelsToTwipsX(tabDetailInfo.Left) + .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLINVNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))


                    tblCommon.Visible = True
                    tblCommon.Focus()

                Case ICURR

                    wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE WHERE EXCCURR LIKE '%" & IIf(Len(.Columns(ICURR).Text) > 0, Set_Quote(.Columns(ICURR).Text), "") & "%'"
                    wsSQL = wsSQL & " AND EXCMN = '" & To_Value(VB.Right(wsCtlDte, 2)) & "' "
                    wsSQL = wsSQL & " AND EXCYR = '" & Set_Quote(VB.Left(wsCtlDte, 4)) & "' "
                    wsSQL = wsSQL & " AND EXCSTATUS = '1' "
                    wsSQL = wsSQL & "ORDER BY EXCCURR "

                    Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(tabDetailInfo.Left) + .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLCURCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
            End Select
        End With

        Exit Sub

tblInvoice_ButtonClick_Err:
        MsgBox("tblInvoice_ButtonClick_Err!")
    End Sub

    Private Sub tblInvoice_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblInvoice.KeyDownEvent

        Dim wlRet As Short
        Dim wlRow As Integer

        On Error GoTo tblInvoice_KeyDown_Err

        With tblInvoice
            Select Case eventArgs.KeyCode
                Case System.Windows.Forms.Keys.F4 ' CALL COMBO BOX
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Call tblInvoice_ButtonClick(tblInvoice, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))

                Case System.Windows.Forms.Keys.F5 ' INSERT LINE
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Bookmark = waInvoice.get_UpperBound(1) Then Exit Sub
                    If IsEmptyRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waInvoice.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
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
                        Case IINVNO, ILINE, ICURR, IOSAMT
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                        Case ISETAMTORG, ISETAMTLOC
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = IINVNO
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> IINVNO Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> ISETAMTLOC Then
                        .Col = .Col + 1
                    End If

            End Select
        End With

        Exit Sub

tblInvoice_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblInvoice_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblInvoice.KeyPressEvent
        Select Case tblInvoice.Col

            Case ISETAMTORG

                Call Chk_InpNum(eventArgs.KeyAscii, (tblInvoice.Text), True, True)

            Case ILINE
                Call Chk_InpNum(eventArgs.KeyAscii, (tblInvoice.Text), False, False)



        End Select
    End Sub



    Private Sub tblInvoice_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblInvoice.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmAP003.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuIPopUp)
        End If

    End Sub

    Private Sub tblInvoice_OnAddNew(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblInvoice.OnAddNew
        On Error GoTo tblInvoice_OnAddNew_Err

        Call Calc_InvTotal()
        Call Calc_ChargeTotal()

        Exit Sub

tblInvoice_OnAddNew_Err:

        MsgBox("tblInvoice_OnAddNew_Err!")

    End Sub

    Private Sub tblInvoice_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblInvoice.RowColChange

        Dim wsCurrDes As String
        Dim chkRow As Object

        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblInvoice.Name Then Exit Sub

        With tblInvoice

            If IsEmptyInvRow Then
                .Col = IINVNO
                'Else
                '    cmdInv.Enabled = False
                '    optStlMtd(0).Enabled = False
                '    optStlMtd(1).Enabled = False
            End If


            'if the row is empty, set to the first column
            If Trim(.Columns(IINVNO).Text) <> "" Then
                .Columns(ISETAMTLOC).Text = NBRnd(To_Value((.Columns(ISETAMTORG).Text)) * To_Value((.Columns(IEXCR).Text)), giAmtDp)
                'Modified May 09 2000 added .update to fix problem
                'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                .Update()
            End If

            Call Chk_Curr((.Columns(ICURR).Text), medDocDate.Text)
            If .Col = ICURR Then
            End If

            If eventArgs.LastCol = ICURR Or eventArgs.LastCol = ISETAMTORG Or waInvoice.get_UpperBound(1) = -1 Or waInvoice.get_UpperBound(1) >= 0 Then
                Call Calc_InvTotal()
                Call Calc_ChargeTotal()
            End If


        End With

        lblDspUnInvAmt.Text = NBRnd(To_Value(LblDspChqAmtLoc) - (To_Value(lblDspInvAmt) + To_Value(lblDspOthAmt) + To_Value(lblDspRemAmtl)), giAmtDp)
        lblDspUnOthAmt.Text = lblDspUnInvAmt.Text

        Exit Sub

RowColChange_Err:

        MsgBox("RowColChange_Err!")

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





    Private Sub txtChqAmtOrg_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChqAmtOrg.Enter
        Call FocusMe(txtChqAmtOrg)
    End Sub
    Private Sub txtChqAmtOrg_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChqAmtOrg.Leave
        If Trim(txtChqAmtOrg.Text) <> "" Then
            txtChqAmtOrg.Text = NBRnd(CDbl(txtChqAmtOrg.Text), giAmtDp)
        End If
    End Sub
    Private Sub txtChqAmtOrg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtChqAmtOrg.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, (txtChqAmtOrg.Text), False, True)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(txtChqAmtOrg.Text) = "" Then
                txtChqAmtOrg.Text = NBRnd(CDbl("0"), giAmtDp)
            End If

            If Chk_txtChqAmtOrg((txtChqAmtOrg.Text)) = False Then
                GoTo EventExitSub
            End If


            txtChqAmtOrg.Text = NBRnd(CDbl(txtChqAmtOrg.Text), giAmtDp)

            LblDspRemDte.Text = medDocDate.Text
            LblDspChqAmtLoc.Text = NBRnd(To_Value((txtChqAmtOrg.Text)) * To_Value((txtExcr.Text)), giAmtDp)
            Call Calc_InvTotal()
            Call Calc_ChargeTotal()

            If To_Value((txtChqAmtOrg.Text)) = 0 Then
                Call SetFieldStatus("RemFalse")
                txtRemAmt.Text = NBRnd(CDbl("0"), giAmtDp)
                lblDspRemAmtl.Text = NBRnd(CDbl("0"), giAmtDp)
                LblDspRemDte.Text = ""
                cboTMPML.Text = ""
                tabDetailInfo.SelectedIndex = 0
                If Chk_KeyFld Then
                    tblInvoice.Focus()
                End If
            Else
                Call SetFieldStatus("RemTrue")
                txtRemAmt.Focus()
            End If

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
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
                    cboMLCode.Focus()
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



    Private Sub cboVdrCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrCode

        If gsLangID = "1" Then
            wsSQL = "SELECT VDRCODE, VDRNAME FROM mstVENDOR "
            wsSQL = wsSQL & "WHERE VDRCODE LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
            wsSQL = wsSQL & "AND VDRSTATUS = '1' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & "ORDER BY VDRCODE "
        Else
            wsSQL = "SELECT VDRCODE, VDRNAME FROM mstVENDOR "
            wsSQL = wsSQL & "WHERE VDRCODE LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
            wsSQL = wsSQL & "AND VDRSTATUS = '1' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & "ORDER BY VDRCODE "
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

            cboCurr.Focus()

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
        wsSQL = wsSQL & "FROM  mstVENDOR "
        wsSQL = wsSQL & "WHERE VDRID = " & wlVdrID
        rsDefVal.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDefVal.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboCurr.Text = ReadRs(rsDefVal, "VDRCURR")
        Else
            cboCurr.Text = ""
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




        'get Due Date Payment Term

    End Sub



    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblInvoice
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = IINVNO To IDummy
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case IINVNO
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 15
                    Case ILINE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 3
                    Case ICURR
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 3
                    Case IEXCR
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case IOSAMT
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True
                    Case ISETAMTORG
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case ISETAMTLOC
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True
                    Case IIPDTID
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case IDummy
                        .Columns(wiCtr).DataWidth = 0
                        .Columns(wiCtr).Locked = True

                End Select
            Next
            .Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
        End With

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

            For wiCtr = OMLCODE To ODummy
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case OMLCODE
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10
                    Case OCURR
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 3
                    Case OEXCR
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsExrFmt
                    Case OOTHAMTORG
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case OOTHAMTLOC
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True
                    Case ODummy
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
        Dim wsDes As String
        Dim wsExcr As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case OMLCODE

                    If Chk_grdMLClass(.Columns(eventArgs.ColIndex).Text, "G", wsDes) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Trim(.Columns(OCURR).Text) = "" Then
                        .Columns(OCURR).Text = wsBaseCurCd
                        .Columns(OEXCR).Text = wsBaseExcr
                    End If
                    Call chk_BaseCurr()

                Case OCURR

                    If Chk_Curr((.Columns(OCURR).Text), medDocDate.Text) = False Then
                        gsMsg = "No Such Currency Code!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If getExcRate((.Columns(OCURR).Text), (medDocDate.Text), wsExcr, "") = False Then
                        gsMsg = "No Exchange Rate at this period!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        wsExcr = VB6.Format(0, gsExrFmt)
                        GoTo Tbl_BeforeColUpdate_Err
                        Exit Sub
                    End If


                    .Columns(OEXCR).Text = wsExcr
                    Call chk_BaseCurr()

                Case OEXCR
                    If To_Value((.Columns(eventArgs.ColIndex).Text)) > CDbl("99999.9999") Or To_Value((.Columns(eventArgs.ColIndex).Text)) <= 0 Then

                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(OOTHAMTLOC).Text = NBRnd(To_Value(.Columns(OOTHAMTORG)) * To_Value(.Columns(OEXCR)), giAmtDp)
                    Call Calc_ChargeTotal()
                    Call Calc_InvTotal()

                Case OOTHAMTORG

                    If Chk_Amount((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(OOTHAMTORG).Text = NBRnd(CDbl(.Columns(OOTHAMTORG).Text), giAmtDp)
                    .Columns(OOTHAMTLOC).Text = NBRnd(To_Value(.Columns(OOTHAMTORG)) * To_Value(.Columns(OEXCR)), giAmtDp)
                    Call Calc_ChargeTotal()
                    Call Calc_InvTotal()


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
				Case OMLCODE
					
					wsSQL = "SELECT MLCODE, MLDESC FROM mstMerchClass "
					wsSQL = wsSQL & " WHERE MLSTATUS <> '2' "
					wsSQL = wsSQL & " AND MLCODE LIKE '%" & Set_Quote(.Columns(OMLCODE).Text) & "%' "
					wsSQL = wsSQL & " AND MLTYPE = 'G' "
					wsSQL = wsSQL & " ORDER BY MLCODE "
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLMLCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
				Case OCURR
					
					
					wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE WHERE EXCCURR LIKE '%" & IIf(Len(.Columns(OCURR).Text) > 0, Set_Quote(.Columns(OCURR).Text), "") & "%'"
					wsSQL = wsSQL & " AND EXCMN = '" & To_Value(VB.Right(wsCtlDte, 2)) & "' "
					wsSQL = wsSQL & " AND EXCYR = '" & Set_Quote(VB.Left(wsCtlDte, 4)) & "' "
					wsSQL = wsSQL & " AND EXCSTATUS = '1' "
					wsSQL = wsSQL & "ORDER BY EXCCURR "
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLCURCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
						Case OMLCODE, OEXCR
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
						Case OOTHAMTORG, OOTHAMTLOC
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = OMLCODE
						Case OCURR
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							If UCase(Trim(.Columns(OCURR).Text)) = UCase(wsBaseCurCd) Then
								.Col = OOTHAMTORG
							Else
								.Col = OEXCR
							End If
					End Select
				Case System.Windows.Forms.Keys.Left
					
					Select Case .Col
						Case OCURR, OEXCR, OOTHAMTLOC
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col - 1
						Case OOTHAMTORG
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							If UCase(Trim(.Columns(OCURR).Text)) = UCase(wsBaseCurCd) Then
								.Col = OCURR
							Else
								.Col = OEXCR
							End If
					End Select
					
				Case System.Windows.Forms.Keys.Right
					
					Select Case .Col
						Case OMLCODE, OEXCR, OOTHAMTORG
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
						Case OCURR
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							If UCase(Trim(.Columns(OCURR).Text)) = UCase(wsBaseCurCd) Then
								.Col = OOTHAMTORG
							Else
								.Col = OEXCR
							End If
					End Select
					
			End Select
		End With
		
		Exit Sub
		
tblDetail_KeyDown_Err: 
		MsgBox("Check tblDeiail KeyDown")
		
	End Sub
	
	Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
		
		Select Case tblDetail.Col
			
			Case OOTHAMTORG
				
				Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), True, True)
				
			Case OEXCR
				
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
				.Col = OMLCODE
			End If
			
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					Case OMLCODE
						If Trim(.Columns(.Col).Text) <> "" Then
							Call Chk_grdMLClass(.Columns(.Col).Text, "G", "")
						End If
						
					Case OCURR
						
						If Chk_Curr((.Columns(.Col).Text), medDocDate.Text) = False Then
							gsMsg = "No Such Currency Code!"
							MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
						End If
						
						
						
				End Select
			End If
			Call Calc_ChargeTotal()
			Call Calc_InvTotal()
			If Trim(.Columns(OMLCODE).Text) <> "" Then .Columns(OOTHAMTLOC).Text = NBRnd(To_Value(.Columns(OOTHAMTORG)) * To_Value(.Columns(OEXCR)), giAmtDp)
			
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
		wsSQL = wsSQL & " AND MLTYPE = 'G' "
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
				If Trim(.Columns(OMLCODE).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				If Trim(waResult.get_Value(inRow, OMLCODE)) = "" And Trim(waResult.get_Value(inRow, OCURR)) = "" And Trim(waResult.get_Value(inRow, OEXCR)) = "" And Trim(waResult.get_Value(inRow, OOTHAMTORG)) = "" And Trim(waResult.get_Value(inRow, OOTHAMTLOC)) = "" Then
					Exit Function
				End If
			End If
		End If
		
		IsEmptyRow = False
		
	End Function
	
	
	Private Function IsEmptyInvRow(Optional ByRef inRow As Object = Nothing) As Boolean
		
		IsEmptyInvRow = True
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inRow) Then
			With tblInvoice
				If Trim(.Columns(IINVNO).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waInvoice.get_UpperBound(1) >= 0 Then
				If Trim(waInvoice.get_Value(inRow, IINVNO)) = "" And Trim(waInvoice.get_Value(inRow, ILINE)) = "" And Trim(waInvoice.get_Value(inRow, ICURR)) = "" And Trim(waInvoice.get_Value(inRow, IOSAMT)) = "" And Trim(waInvoice.get_Value(inRow, ISETAMTORG)) = "" And Trim(waInvoice.get_Value(inRow, ISETAMTLOC)) = "" Then
					Exit Function
				End If
			End If
		End If
		
		IsEmptyInvRow = False
		
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
			
			If Chk_MLClass(waResult.get_Value(LastRow, OMLCODE), "G", wsDes) = False Then
				.Col = OMLCODE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_Curr(waResult.get_Value(LastRow, OCURR), medDocDate.Text) = False Then
				.Col = OCURR
				.Row = LastRow
				Exit Function
			End If
			
			If To_Value(waResult.get_Value(LastRow, OEXCR)) > CDbl("99999.9999") Or To_Value(waResult.get_Value(LastRow, OEXCR)) <= 0 Then
				.Col = OEXCR
				.Row = LastRow
				Exit Function
			End If
			
			
			If Chk_Amount(waResult.get_Value(LastRow, OOTHAMTORG)) = False Then
				.Col = OOTHAMTORG
				.Row = LastRow
				Exit Function
			End If
			
			
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
	
	
	Private Sub Calc_InvTotal()
		
		Dim wdStlTot As Double
		Dim wdStlTotL As Double
		Dim wlCtr As Integer
		
		On Error GoTo Calc_InvTotal_Err
		
		wdStlTot = 0
		wdStlTotL = 0
		
		wlCtr = To_Value((tblInvoice.FirstRow)) + tblInvoice.Row
		
		If waInvoice.get_UpperBound(1) = -1 Then
			lblDspInvAmt.Text = NBRnd(CDbl("0"), giAmtDp)
			lblDspUnInvAmt.Text = NBRnd(CDbl("0"), giAmtDp)
			Exit Sub
		End If
		
		If wlCtr > waInvoice.get_UpperBound(1) Then Exit Sub
		
		If Not IsEmptyInvRow(wlCtr) Then
			waInvoice.get_Value(wlCtr, ISETAMTORG) = tblInvoice.Columns(ISETAMTORG).Text
			waInvoice.get_Value(wlCtr, ISETAMTLOC) = tblInvoice.Columns(ISETAMTLOC).Text
			waInvoice.get_Value(wlCtr, IEXCR) = tblInvoice.Columns(IEXCR).Text
		End If
		
		For wlCtr = 0 To waInvoice.get_UpperBound(1)
			wdStlTot = CDbl(NBRnd(wdStlTot + (To_Value(waInvoice.get_Value(wlCtr, ISETAMTLOC)) / IIf(To_Value(waInvoice.get_Value(wlCtr, IEXCR)) = 0, 1, To_Value(waInvoice.get_Value(wlCtr, IEXCR)))), giAmtDp))
			wdStlTotL = CDbl(NBRnd(wdStlTotL + (To_Value(waInvoice.get_Value(wlCtr, ISETAMTLOC))), giAmtDp))
		Next 
		
		lblDspInvAmt.Text = NBRnd(wdStlTotL, giAmtDp)
		lblDspUnInvAmt.Text = NBRnd(To_Value(LblDspChqAmtLoc) - (To_Value(lblDspInvAmt) + To_Value(lblDspOthAmt) + To_Value(lblDspRemAmtl)), giAmtDp)
		lblDspUnOthAmt.Text = lblDspUnInvAmt.Text
		
		'Modified 09 May to remove problem of not appearing in the grid
		'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        tblInvoice.Update()
		
		Exit Sub
		
Calc_InvTotal_Err: 
		MsgBox("Calc_InvTotal")
		
	End Sub
	
	
	
	
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
		'check each detail line
		If Chk_LockedRecords Then
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
		
		adcmdDelete.CommandText = "USP_AP003A"
		adcmdDelete.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdDelete.Parameters.Refresh()
		
		Call SetSPPara(adcmdDelete, 1, wiAction)
		Call SetSPPara(adcmdDelete, 2, wlKey)
		Call SetSPPara(adcmdDelete, 3, Trim(cboDocNo.Text))
		Call SetSPPara(adcmdDelete, 4, wlVdrID)
		Call SetSPPara(adcmdDelete, 5, medDocDate.Text)
		Call SetSPPara(adcmdDelete, 6, cboCurr.Text)
		Call SetSPPara(adcmdDelete, 7, txtExcr.Text)
		Call SetSPPara(adcmdDelete, 8, To_Value((txtChqAmtOrg.Text)))
		Call SetSPPara(adcmdDelete, 9, NBRnd(To_Value((txtExcr.Text)) * To_Value((txtChqAmtOrg.Text)), giAmtDp))
		Call SetSPPara(adcmdDelete, 10, cboMLCode.Text)
		Call SetSPPara(adcmdDelete, 11, "")
		Call SetSPPara(adcmdDelete, 12, txtRmk.Text)
		Call SetSPPara(adcmdDelete, 13, wsFormID)
		Call SetSPPara(adcmdDelete, 14, gsUserID)
		Call SetSPPara(adcmdDelete, 15, wsGenDte)
		Call SetSPPara(adcmdDelete, 16, wsDteTim)
		
		adcmdDelete.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = GetSPPara(adcmdDelete, 17)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdDelete, 18)
		
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
				Me.medDocDate.Enabled = False
				Me.cboCurr.Enabled = False
				Me.txtExcr.Enabled = False
				Me.cboMLCode.Enabled = False
				Me.txtRmk.Enabled = False
				Me.txtChqAmtOrg.Enabled = False
				
				
				Me.tblInvoice.Enabled = False
				Me.tblDetail.Enabled = False
				
			Case "AfrActEdit"
				
				Me.cboDocNo.Enabled = True
				
				
			Case "AfrKeyAdd"
				
				Me.cboDocNo.Enabled = False
				Me.cboVdrCode.Enabled = True
				
			Case "AfrKeyEdit"
				
				Me.cboDocNo.Enabled = False
				Me.cboVdrCode.Enabled = False
				
			Case "AfrKey"
				'    Me.cboDocNo.Enabled = False
				'    Me.cboVdrCode.Enabled = True
				
				
				Me.medDocDate.Enabled = True
				Me.cboCurr.Enabled = True
				Me.txtExcr.Enabled = True
				
				Me.cboMLCode.Enabled = True
				Me.txtRmk.Enabled = True
				Me.txtChqAmtOrg.Enabled = True
				
				
				If wiAction <> AddRec Then
					Me.tblDetail.Enabled = True
					Me.tblInvoice.Enabled = True
				End If
				
			Case "RemFalse"
				Me.cboTMPML.Enabled = False
				Me.txtRemAmt.Enabled = False
				
			Case "RemTrue"
				Me.cboTMPML.Enabled = True
				Me.txtRemAmt.Enabled = True
				
				
		End Select
	End Sub
	
	Private Sub GetNewKey()
		Dim Newfrm As New frmKeyInput
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		With Newfrm
			
			.TableID = wsKeyType
			.TableType = wsSrcCd
			.TableKey = "APSHDocNo"
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
		vFilterAry(1, 2) = "APSHDocNo"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "Doc. Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "APSHDocDate"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 1) = "Vendor #"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 2) = "VdrCode"
		
		Dim vAry(4, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "Doc No."
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "APSHDocNo"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "APSHDocDate"
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
			wsSQL = "SELECT APSHDocNo, APSHDocDate, mstVendor.VdrCode,  mstVendor.VdrName "
			wsSQL = wsSQL & "FROM MstVendor, ArStHd "
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE APSHStatus = '1' And APSHVdrID = VdrID "
			.sBindOrderSQL = "ORDER BY APSHDocNo"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmAP003.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboDocNo.Text Then
			cboDocNo.Text = Trim(frmShareSearch.Tag)
			cboDocNo.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		frmShareSearch.Close()
		
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
			
			If Chk_cboMLCode = False Then
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
		wsSQL = wsSQL & " AND MLTYPE = 'B' "
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
		
		
		If Chk_MLClass(cboMLCode.Text, "B", wsDesc) = False Then
			gsMsg = "沒有此會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboMLCode.Focus()
			lblDspMLDesc.Text = ""
			Exit Function
		End If
		
		lblDspMLDesc.Text = wsDesc
		
		Chk_cboMLCode = True
		
	End Function
	
	
	
	
	
	Private Sub cboTmpML_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTmpML.Enter
		FocusMe(cboTMPML)
	End Sub
	
	Private Sub cboTmpML_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTmpML.Leave
		FocusMe(cboTMPML, True)
	End Sub
	
	
	Private Sub cboTmpML_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboTmpML.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsDesc As String
		
		Call chk_InpLen(cboTMPML, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboTmpML = False Then
				GoTo EventExitSub
			End If
			
			
			tabDetailInfo.SelectedIndex = 0
			If Chk_KeyFld Then
				tblInvoice.Focus()
			End If
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboTmpML_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTmpML.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboTMPML
		
		wsSQL = "SELECT MLCode, MLDESC FROM mstMerchClass "
		wsSQL = wsSQL & " WHERE MLCode LIKE '%" & IIf(cboTMPML.SelectionLength > 0, "", Set_Quote(cboTMPML.Text)) & "%' "
		wsSQL = wsSQL & " AND MLSTATUS = '1' "
		wsSQL = wsSQL & " AND MLTYPE = 'R' "
		wsSQL = wsSQL & "ORDER BY MLCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboTMPML.Left)), VB6.PixelsToTwipsY(cboTMPML.Top) + VB6.PixelsToTwipsY(cboTMPML.Height), tblCommon, wsFormID, "TBLMLCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Function Chk_cboTmpML() As Boolean
		Dim wsDesc As String
		
		Chk_cboTmpML = False
		
		If To_Value(txtRemAmt) = 0 Then
			cboTMPML.Text = ""
			Chk_cboTmpML = True
			Exit Function
		End If
		
		If Trim(cboTMPML.Text) = "" Then
			gsMsg = "必需輸入會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboTMPML.Focus()
			Exit Function
		End If
		
		
		If Chk_MLClass(cboTMPML.Text, "R", wsDesc) = False Then
			gsMsg = "沒有此會計分類!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboTMPML.Focus()
			lblDspTmpMlDesc.Text = ""
			Exit Function
		End If
		
		lblDspTmpMlDesc.Text = wsDesc
		
		Chk_cboTmpML = True
		
	End Function
	
	
	
	
	
	
	Private Sub txtRemAmt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRemAmt.Enter
		FocusMe(txtRemAmt)
	End Sub
	
	Private Sub txtRemAmt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRemAmt.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call Chk_InpNum(KeyAscii, (txtRemAmt.Text), True, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Trim(txtRemAmt.Text) = "" Then
				txtRemAmt.Text = NBRnd(CDbl("0"), giAmtDp)
				cboTMPML.Focus()
				GoTo EventExitSub
			End If
			
			If Chk_txtRemAmt((txtRemAmt.Text)) = False Then
				GoTo EventExitSub
			End If
			
			lblDspRemAmtl.Text = VB6.Format(NBRnd(To_Value((txtRemAmt.Text)) * To_Value((txtExcr.Text)), giAmtDp), gsAmtFmt)
			txtRemAmt.Text = NBRnd(To_Value((txtRemAmt.Text)), giAmtDp)
			lblDspUnInvAmt.Text = NBRnd(To_Value(LblDspChqAmtLoc) - (To_Value(lblDspInvAmt) + To_Value(lblDspOthAmt) + To_Value(lblDspRemAmtl)), giAmtDp)
			lblDspUnOthAmt.Text = lblDspUnInvAmt.Text
			
			cboTMPML.Focus()
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub txtRemAmt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRemAmt.Leave
		FocusMe(txtRemAmt, True)
		If Trim(txtRemAmt.Text) <> "" Then
			txtRemAmt.Text = NBRnd(CDbl(txtRemAmt.Text), giAmtDp)
		End If
		
	End Sub
	
	Private Sub txtRmk_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Enter
		
		
		FocusMe(txtRmk)
		
	End Sub
	
	Private Sub txtRmk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLen(txtRmk, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			
			txtChqAmtOrg.Focus()
			
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Leave
		
		FocusMe(txtRmk, True)
		
	End Sub
	
	
	
	
	
	
	
	
	
	Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
		If eventArgs.Button = 2 Then
			'UPGRADE_ISSUE: Form method frmAP003.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuOPopUp)
		End If
		
		
	End Sub
	
	Public Sub mnuOPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOPopUpSub.Click
		Dim Index As Short = mnuOPopUpSub.GetIndex(eventSender)
		Call Call_OPopUpMenu(waPopUpSub, Index)
	End Sub
	
	Public Sub mnuIPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuIPopUpSub.Click
		Dim Index As Short = mnuIPopUpSub.GetIndex(eventSender)
		Call Call_IPopUpMenu(waPopUpSub, Index)
	End Sub
	
	Private Sub Call_IPopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)
		
		Dim wsAct As String
		
		wsAct = inArray.get_Value(inMnuIdx, 0)
		
		With tblInvoice
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
	
	Private Sub Call_OPopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)
		
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
					
					If .Bookmark = waInvoice.get_UpperBound(1) Then Exit Sub
					If IsEmptyInvRow Then Exit Sub
					'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					waInvoice.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
					.ReBind()
					.Focus()
					
				Case Else
					Exit Sub
					
					
			End Select
			
		End With
		
		
	End Sub
	Private Function Chk_DocNo(ByVal InDocNo As String, ByRef OutStatus As String, ByRef OutUpdFlg As String, ByRef OutPgmNo As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		OutStatus = ""
		OutUpdFlg = ""
		Chk_DocNo = False
		
		wsSQL = "SELECT APSHSTATUS, APSHUPDFLG, APSHPGMNO FROM APSTHD "
		wsSQL = wsSQL & " WHERE APSHDOCNO = '" & Set_Quote(InDocNo) & "' "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutStatus = ReadRs(rsRcd, "APSHSTATUS")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutUpdFlg = ReadRs(rsRcd, "APSHUPDFLG")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutPgmNo = ReadRs(rsRcd, "APSHPGMNO")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		Chk_DocNo = True
		
		
		
		
	End Function
	
	
	
	Private Function Chk_VdrCode(ByVal InVdrNo As String, ByRef OutID As Integer, ByRef OutName As String, ByRef OutTel As String, ByRef OutFax As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT VdrID, VdrName, VdrTel, VdrFax FROM mstVendor WHERE VdrCode = '" & Set_Quote(InVdrNo) & "' "
		wsSQL = wsSQL & "And VdrStatus = '1' "
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutID = ReadRs(rsRcd, "VdrID")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutName = ReadRs(rsRcd, "VdrName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutTel = ReadRs(rsRcd, "VdrTel")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutFax = ReadRs(rsRcd, "VdrFax")
			Chk_VdrCode = True
			
		Else
			
			OutID = 0
			OutName = ""
			OutTel = ""
			OutFax = ""
			Chk_VdrCode = False
			
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
	
	Private Function Chk_txtChqAmtOrg(ByRef inAmt As String) As Short
		
		Chk_txtChqAmtOrg = False
		
		
		
		If To_Value(inAmt) > CDbl(gsMaxVal) Then
			gsMsg = "數量太大!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtChqAmtOrg.Focus()
			Exit Function
		End If
		
		Chk_txtChqAmtOrg = True
		
	End Function
	
	Private Function Chk_txtRemAmt(ByRef inAmt As String) As Short
		
		Chk_txtRemAmt = False
		
		
		
		If To_Value(inAmt) > CDbl(gsMaxVal) Then
			gsMsg = "數量太大!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtRemAmt.Focus()
			Exit Function
		End If
		
		Chk_txtRemAmt = True
		
	End Function
	
	Private Sub Calc_ChargeTotal()
		
		Dim wdStlTot As Double
		Dim wdStlTotL As Double
		Dim wlCtr As Integer
		
		On Error GoTo Calc_ChargeTotal_Err
		
		wdStlTot = 0
		wdStlTotL = 0
		
		wlCtr = To_Value((tblDetail.FirstRow)) + tblDetail.Row
		
		If System.Math.Abs(wlCtr) > waResult.get_UpperBound(1) Then
			lblDspUnInvAmt.Text = NBRnd(To_Value(LblDspChqAmtLoc) - (To_Value(lblDspInvAmt) + To_Value(lblDspOthAmt) + To_Value(lblDspRemAmtl)), giAmtDp)
			lblDspUnOthAmt.Text = lblDspUnInvAmt.Text
			
			If waResult.get_UpperBound(1) = -1 Then
				lblDspOthAmt.Text = NBRnd(CDbl("0"), giAmtDp)
				lblDspUnOthAmt.Text = NBRnd(CDbl("0"), giAmtDp)
				Exit Sub
			End If
			Exit Sub
		End If
		
		If waResult.get_UpperBound(1) = -1 Then
			lblDspOthAmt.Text = NBRnd(CDbl("0"), giAmtDp)
			lblDspUnOthAmt.Text = NBRnd(CDbl("0"), giAmtDp)
			Exit Sub
		End If
		
		If Not IsEmptyRow(wlCtr) Then
			waResult.get_Value(wlCtr, OOTHAMTORG) = tblDetail.Columns(OOTHAMTORG).Text
			waResult.get_Value(wlCtr, OOTHAMTLOC) = NBRnd(To_Value((tblDetail.Columns(OOTHAMTORG).Text)) * To_Value((tblDetail.Columns(OEXCR).Text)), giAmtDp)
		End If
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			wdStlTot = CDbl(NBRnd(wdStlTot + To_Value(waResult.get_Value(wlCtr, OOTHAMTORG)), giAmtDp))
			wdStlTotL = CDbl(NBRnd(wdStlTotL + To_Value(waResult.get_Value(wlCtr, OOTHAMTLOC)), giAmtDp))
		Next 
		
		lblDspOthAmt.Text = NBRnd(wdStlTotL, giAmtDp)
		lblDspUnInvAmt.Text = NBRnd(To_Value(LblDspChqAmtLoc) - (To_Value(lblDspInvAmt) + To_Value(lblDspOthAmt) + To_Value(lblDspRemAmtl)), giAmtDp)
		lblDspUnOthAmt.Text = lblDspUnInvAmt.Text
		
		Exit Sub
		
Calc_ChargeTotal_Err: 
		MsgBox("Calc_ChargeTotal_Err")
		
	End Sub
	
	Private Function Chk_InvNo(ByVal inInvNo As String, ByVal inInvLn As String, Optional ByRef inDtl As Boolean = False) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		Dim wsExcRat As String
		Dim wlCtr As Integer
		
		On Error GoTo Chk_InvNo_Err
		
		Chk_InvNo = False
		
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inDtl) Then inDtl = False
		
		wsSQL = "SELECT IPDTID, IPHDDOCNO , REPLICATE('0',3 - LEN(LTRIM(CONVERT(NVARCHAR(3),IPDTDOCLINE))))  + CONVERT(NVARCHAR(3),IPDTDOCLINE) AS LN, "
		wsSQL = wsSQL & " IPHDCURR, IPDTBALAMT, IPDTBALAMTL, IPHDEXCR FROM APIPHD, APIPDT "
		wsSQL = wsSQL & " WHERE IPHDDOCNO = '" & Set_Quote(inInvNo) & "'"
		wsSQL = wsSQL & " AND  REPLICATE('0',3 - LEN(LTRIM(CONVERT(NVARCHAR(3),IPDTDOCLINE))))  + CONVERT(NVARCHAR(3),IPDTDOCLINE) = '" & Set_Quote(VB6.Format(inInvLn, "00#")) & "'"
		wsSQL = wsSQL & " AND IPHDVDRID = " & wlVdrID
		wsSQL = wsSQL & " AND IPHDDOCID = IPDTDOCID AND IPDTBALAMT <> 0"
		wsSQL = wsSQL & " AND IPHDSTATUS <> '2'"
		
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			
			gsMsg = "No Such Invoice No!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		Chk_InvNo = True
		
		If Not inDtl Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		With tblInvoice
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(IINVNO).Text = ReadRs(rsRcd, "IPHDDOCNO")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(ILINE).Text = ReadRs(rsRcd, "LN")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(ICURR).Text = ReadRs(rsRcd, "IPHDCURR")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(IOSAMT).Text = NBRnd(ReadRs(rsRcd, "IPDTBALAMT"), giAmtDp)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(ISETAMTORG).Text = NBRnd(ReadRs(rsRcd, "IPDTBALAMT"), giAmtDp)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(ISETAMTLOC).Text = NBRnd(ReadRs(rsRcd, "IPDTBALAMTL"), giAmtDp)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(IEXCR).Text = ReadRs(rsRcd, "IPHDEXCR")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Columns(IIPDTID).Text = ReadRs(rsRcd, "IPDTID")
			
			
			
			
			Call Chk_Curr((.Columns(ICURR).Text), medDocDate.Text)
			'tblInvoice.Columns(Tab1StlAmt).Locked = False
			
		End With
		
		
		
		Chk_InvNo = True
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Exit Function
		
Chk_InvNo_Err: 
		MsgBox("Chk_InvNo_Err!")
		
	End Function
	Private Function NoMoreInvNo(ByVal inArray As XArrayDBObject.XArrayDB, ByVal inInvNo As String, Optional ByRef inLnNo As Object = Nothing) As Boolean
		'contents of inarray before new value is updated
		'content of inInvNo is the new inv no entered
		
		On Error GoTo NoMoreInvNo_Err
		Dim wiRowCtr As Short
		NoMoreInvNo = True
		For wiRowCtr = 0 To inArray.get_UpperBound(1)
			'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
			If IsNothing(inLnNo) Then
				If inInvNo = inArray.get_Value(wiRowCtr, IINVNO) Then
					NoMoreInvNo = False
					Exit Function
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object inLnNo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If inInvNo = inArray.get_Value(wiRowCtr, IINVNO) And wiRowCtr <> inLnNo Then
					NoMoreInvNo = False
					Exit Function
				Else
					If inInvNo <> inArray.get_Value(wiRowCtr, IINVNO) And inArray.get_UpperBound(1) = 0 Then
						NoMoreInvNo = False
						Exit Function
					End If
				End If
				
			End If
		Next wiRowCtr
		Exit Function
		
NoMoreInvNo_Err: 
		MsgBox("NoMoreInvNo_Err!")
		
	End Function
	
	Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean
		
		Dim wlCtr As Integer
		Dim wsCurRec As String
		Dim wsCurRecLn As String
		Chk_NoDup = False
		
		wsCurRec = tblInvoice.Columns(IINVNO).Text
		wsCurRecLn = VB6.Format(tblInvoice.Columns(ILINE).Text, "00#")
		
		For wlCtr = 0 To waInvoice.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = waInvoice.get_Value(wlCtr, IINVNO) And wsCurRecLn = waInvoice.get_Value(wlCtr, ILINE) Then
					gsMsg = "Duplicate Invoice Line !"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		
		Chk_NoDup = True
		
	End Function
	Private Function Chk_InvGrdRow(ByVal LastRow As Integer) As Boolean
		
		Chk_InvGrdRow = False
		Dim wlCtr As Integer
		Dim wsDes As String
		Dim wsExcRat As String
		
		'added 09 May
		If To_Value(LastRow) > waInvoice.get_UpperBound(1) Then
			Chk_InvGrdRow = True
			Exit Function
		End If
		
		If IsEmptyInvRow(To_Value(LastRow)) = True Then
			Chk_InvGrdRow = True
			Exit Function
		End If
		
		With tblInvoice
			'added 09 May
			'If Chk_InvNo(waInvoice(wlCtr, Tab1InvNo), waInvoice(wlCtr, Tab1InvLn), False, True) = False Then
			'    .Col = Tab1InvNo
			'    Exit Function
			'End If
			
			'added 09 May
			
			If Chk_Curr(waInvoice.get_Value(LastRow, ICURR), medDocDate.Text) = False Then
				gsMsg = "No Such Currency Code!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				.Col = ICURR
				Exit Function
			End If
			
			
			If Chk_Amount(waInvoice.get_Value(LastRow, ISETAMTORG)) = False Then
				.Col = ISETAMTORG
				Exit Function
			End If
			
			If System.Math.Abs(To_Value(waInvoice.get_Value(LastRow, ISETAMTORG))) > System.Math.Abs(To_Value(waInvoice.get_Value(LastRow, IOSAMT))) Then
				gsMsg = "Settlement Amount cannot greater than Outstanding Amt!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				.Col = ISETAMTORG
				Exit Function
			End If
			
		End With
		Chk_InvGrdRow = True
		
	End Function
	
	Private Sub chk_BaseCurr()
		
		With tblDetail
			
			If UCase(Trim(wsBaseCurCd)) = UCase(tblDetail.Columns(OCURR).Text) Then
				.Columns(OEXCR).Text = NBRnd(CDbl("1"), giExrDp)
				.Columns(OEXCR).Locked = True
			Else
				.Columns(OEXCR).Locked = False
			End If
			
		End With
	End Sub
	
	
	Private Function Chk_LockedRecords() As Boolean
		Dim wiRowCtr As Short
		Chk_LockedRecords = True
		
		For wiRowCtr = 0 To waInvoice.get_UpperBound(1)
			If waInvoice.get_Value(wiRowCtr, IINVNO) <> "" Then
				If ReadOnlyMode(wsConnTime, wsInvKeyType, waInvoice.get_Value(wiRowCtr, IINVNO), wsFormID) Then
					gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
					MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					tabDetailInfo.SelectedIndex = 0
					tblInvoice.Focus()
					tblInvoice.Bookmark = wiRowCtr
					tblInvoice.Col = IINVNO
					Cursor = System.Windows.Forms.Cursors.Default
					Exit Function
				End If
			End If
		Next wiRowCtr
		
		Chk_LockedRecords = False
	End Function
	Public Function Chk_grdMLClass(ByVal inCode As String, ByVal inType As String, ByRef OutDesc As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT MLDesc FROM mstMerchClass WHERE MLCode = '" & Set_Quote(inCode) & "' "
		wsSQL = wsSQL & "And MLStatus = '1' "
		wsSQL = wsSQL & "And MLType = '" & inType & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutDesc = ReadRs(rsRcd, "MLDesc")
			Chk_grdMLClass = True
			
		Else
			gsMsg = "No Such A/C Class!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			OutDesc = ""
			Chk_grdMLClass = False
			
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
End Class