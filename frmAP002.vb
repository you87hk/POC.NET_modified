Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAP002
	Inherits System.Windows.Forms.Form
	
	
	
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	
	
	
	Private wsOldCusNo As String
	Private wsOldCurCd As String
	Private wsTmpMl As String
	Private wsCtlDte As String
	Private wbReadOnly As Boolean
	
	
	
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
	
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "APCHEQUE"
	
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsSrcCd As String
	
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	Private wsBaseExcr As String
	
	
	
	
	
	Private wsFormCaption As String
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		
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
		
		wsCtlDte = getCtrlMth("AP")
		
		
		wsOldCusNo = ""
		wsOldCurCd = ""
		wsTmpMl = ""
		
		wlKey = 0
		wlVdrID = 0
		wbReadOnly = False
		
		tblCommon.Visible = False
		
		
		Me.Text = wsFormCaption
		
		FocusMe(cboDocNo)
		
		
		
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
				
				cboMLCode.Focus()
				
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
		
		
		wsSQL = "SELECT APCQCHQNO, APCQCHQDATE, APCQCURR, APCQCHQAMT "
		wsSQL = wsSQL & " FROM APCHEQUE "
		wsSQL = wsSQL & " WHERE APCQCHQNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
		'   wsSql = wsSql & " AND APCQUPDFLG = 'N'"
		'   wsSql = wsSql & " AND APCQSTATUS = '1'"
		wsSQL = wsSQL & " AND APCQPGMNO = '" & wsFormID & "' "
		wsSQL = wsSQL & " ORDER BY APCQCHQNO, APCQCHQDATE "
		
		
		Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboDocNo.Left)), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
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
		Dim wsDocDate As String
		
		Chk_cboDocNo = False
		
		If Trim(cboDocNo.Text) = "" And Chk_AutoGen("PV") = "N" Then
			gsMsg = "必需輸入文件號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNo.Focus()
			Exit Function
		End If
		
		
		If Chk_DocNo(cboDocNo.Text, wsStatus, wsUpdFlg, wsDocDate, wsPgmNo) = True Then
			
			
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
			
			
			
			If Chk_ValidDocDate(wsDocDate, "AP") = False Then
				cboDocNo.Focus()
				Exit Function
			End If
			
			wsSQL = "SELECT APCQCHQID FROM APCHEQUE "
			wsSQL = wsSQL & " WHERE APCQCHQNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND APCQPGMNO <> '" & wsFormID & "' "
			
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				gsMsg = "Document No has been already used!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			
			
		Else
			
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
			
			wsSQL = "SELECT IPHDDOCNO FROM APIPHD "
			wsSQL = wsSQL & " WHERE IPHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
			wsSQL = wsSQL & " AND IPHDPGMNO <> '" & wsFormID & "' "
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount > 0 Then
				gsMsg = "Document No has been already used by Invocie!"
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
		Else
			wiAction = CorRec
			If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
				gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			End If
			wsOldCusNo = cboVdrCode.Text
			wsOldCurCd = cboCurr.Text
			
			
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
	
	
	'UPGRADE_WARNING: Form event frmAP002.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmAP002_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboDocNo
			Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
		End If
		
	End Sub
	
	
	Private Sub frmAP002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			
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
	
	Private Sub frmAP002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
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
		
		
		wsSQL = "SELECT APCQCHQID, APCQCHQNO, APCQVdrID, VdrID, VdrCode, VdrName, VdrTel, VdrFax, "
		wsSQL = wsSQL & "APCQCHQDATE, APCQCURR, APCQEXCR, APCQBANKML, APCQTMPML, "
		wsSQL = wsSQL & "APCQCHQAMT, APCQREMARK "
		wsSQL = wsSQL & "FROM  APCHEQUE, mstVendor "
		wsSQL = wsSQL & "WHERE APCQCHQNO = '" & Set_Quote(cboDocNo.Text) & "' "
		wsSQL = wsSQL & "AND APCQVdrID = VdrID "
		wsSQL = wsSQL & "AND APCQPGMNO = '" & wsFormID & "'"
		wsSQL = wsSQL & "AND APCQSTATUS <> '2'"
		
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = ReadRs(rsRcd, "APCQCHQID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		medDocDate.Text = ReadRs(rsRcd, "APCQCHQDATE")
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
		cboCurr.Text = ReadRs(rsRcd, "APCQCURR")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtExcr.Text = VB6.Format(ReadRs(rsRcd, "APCQEXCR"), gsExrFmt)
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtChqAmtOrg.Text = NBRnd(ReadRs(rsRcd, "APCQCHQAMT"), giAmtDp)
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboMLCode.Text = ReadRs(rsRcd, "APCQBANKML")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cboTMPML.Text = ReadRs(rsRcd, "APCQTMPML")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRmk.Text = ReadRs(rsRcd, "APCQREMARK")
		lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")
		
		rsRcd.Close()
		
		
		wsSQL = " SELECT IPHDMLCODE "
		wsSQL = wsSQL & " FROM  APCHEQUE, APIPHD "
		wsSQL = wsSQL & " WHERE APCQCHQID  = " & wlKey
		wsSQL = wsSQL & " AND IPHDDOCNO  = APCQCHQNO "
		wsSQL = wsSQL & " AND IPHDPGMNO  = '" & wsFormID & "' "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cboTMPML.Text = ReadRs(rsRcd, "IPHDMLCODE")
		Else
			cboTMPML.Text = cboMLCode.Text
		End If
		
		lblDspTmpMlDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboTMPML.Text) & "'", "MLDESC")
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadRecord = True
		
	End Function
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
		lblVdrCode.Text = Get_Caption(waScrItm, "VdrCode")
		lblVdrName.Text = Get_Caption(waScrItm, "VdrName")
		lblVdrTel.Text = Get_Caption(waScrItm, "VdrTel")
		lblVdrFax.Text = Get_Caption(waScrItm, "VdrFax")
		lblCurr.Text = Get_Caption(waScrItm, "CURR")
		lblExcr.Text = Get_Caption(waScrItm, "EXCR")
		
		lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
		lblTmpMl.Text = Get_Caption(waScrItm, "TMPML")
		
		lblChqAmtOrg.Text = Get_Caption(waScrItm, "CHQAMTORG")
		
		
		
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
		
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	
	Private Sub frmAP002_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		'    If Button = 2 Then
		'        PopupMenu mnuMaster
		'    End If
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event frmAP002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmAP002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(4560)
			Me.Width = VB6.TwipsToPixelsX(9915)
		End If
	End Sub
	
	Private Sub frmAP002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Exit Sub
		End If
		Call UnLockAll(wsConnTime, wsFormID)
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmAP002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
		
		
		wsSQL = "SELECT APCQSTATUS FROM APCHEQUE WHERE APCQCHQNO = '" & Set_Quote(cboDocNo.Text) & "'"
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
		
		
		
		
		wsCtlPrd = VB.Left(medDocDate.Text, 4) & Mid(medDocDate.Text, 6, 2)
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_AP002"
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
		Call SetSPPara(adcmdSave, 11, cboTMPML.Text)
		Call SetSPPara(adcmdSave, 12, "")
		Call SetSPPara(adcmdSave, 13, txtRmk.Text)
		Call SetSPPara(adcmdSave, 14, wsFormID)
		Call SetSPPara(adcmdSave, 15, gsUserID)
		Call SetSPPara(adcmdSave, 16, wsGenDte)
		Call SetSPPara(adcmdSave, 17, wsDteTim)
		adcmdSave.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = GetSPPara(adcmdSave, 18)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdSave, 19)
		
		If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo
		
		
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
		
		
		
		If Not Chk_medDocDate Then Exit Function
		If Not chk_cboVdrCode() Then Exit Function
		If Not getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) Then Exit Function
		If Not chk_txtExcr Then Exit Function
		
		If Not Chk_cboMLCode Then Exit Function
		If Not Chk_txtChqAmtOrg((txtChqAmtOrg.Text)) Then Exit Function
		If Not Chk_cboTmpML Then Exit Function
		
		
		InputValidation = True
		
		Exit Function
		
InputValidation_Err: 
		gsMsg = Err.Description
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
	End Function
	
	
	
	Private Sub cmdNew()
		
		Dim newForm As New frmAP002
		
		newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
		newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
		
		newForm.Show()
		
	End Sub
	
	Private Sub cmdOpen()
		
		Dim newForm As New frmAP002
		
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
		wsFormID = "AP002"
		wsBaseCurCd = Get_CompanyFlag("CMPCURR")
		If getExcRate(wsBaseCurCd, wsConnTime, wsBaseExcr, "") = False Then
			wsBaseExcr = VB6.Format(1, gsExrFmt)
		End If
		wsSrcCd = "AR"
		wsTrnCd = "62"
		
		
		
		
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
			
			txtRmk.Focus()
			
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
				
				cboMLCode.Focus()
				
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
			wsSQL = "SELECT VdrCode, VdrName FROM mstVendor "
			wsSQL = wsSQL & "WHERE VdrCode LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
			wsSQL = wsSQL & "AND VDRSTATUS = '1' "
			wsSQL = wsSQL & " AND VdrInactive = 'N' "
			wsSQL = wsSQL & "ORDER BY VdrCode "
		Else
			wsSQL = "SELECT VdrCode, VdrName FROM mstVendor "
			wsSQL = wsSQL & "WHERE VdrCode LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
			wsSQL = wsSQL & "AND VDRSTATUS = '1' "
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
			If wiAction = AddRec Or wsOldCusNo <> cboVdrCode.Text Then Call Get_DefVal()
			
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
		wsSQL = wsSQL & "FROM  mstVendor "
		wsSQL = wsSQL & "WHERE VdrID = " & wlVdrID
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
		
		
		gsMsg = "你是否確認要刪除此檔案?"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			wiAction = CorRec
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Function
		End If
		
		wiAction = DelRec
		
		cnCon.BeginTrans()
		adcmdDelete.ActiveConnection = cnCon
		
		adcmdDelete.CommandText = "USP_AP002"
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
		Call SetSPPara(adcmdDelete, 11, cboTMPML.Text)
		Call SetSPPara(adcmdDelete, 12, "")
		Call SetSPPara(adcmdDelete, 13, txtRmk.Text)
		Call SetSPPara(adcmdDelete, 14, wsFormID)
		Call SetSPPara(adcmdDelete, 15, gsUserID)
		Call SetSPPara(adcmdDelete, 16, wsGenDte)
		Call SetSPPara(adcmdDelete, 17, wsDteTim)
		adcmdDelete.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = GetSPPara(adcmdDelete, 18)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdDelete, 19)
		
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
				Me.cboTMPML.Enabled = False
				Me.txtRmk.Enabled = False
				Me.txtChqAmtOrg.Enabled = False
				
				
				
				
			Case "AfrActAdd"
				
				Me.cboDocNo.Enabled = True
				
			Case "AfrActEdit"
				
				Me.cboDocNo.Enabled = True
				
			Case "AfrKey"
				Me.cboDocNo.Enabled = False
				
				Me.cboVdrCode.Enabled = True
				Me.medDocDate.Enabled = True
				Me.cboCurr.Enabled = True
				Me.txtExcr.Enabled = True
				
				Me.cboMLCode.Enabled = True
				Me.cboTMPML.Enabled = True
				
				Me.txtRmk.Enabled = True
				Me.txtChqAmtOrg.Enabled = True
				
				
				
		End Select
	End Sub
	
	Private Sub GetNewKey()
		Dim Newfrm As New frmKeyInput
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		With Newfrm
			
			.TableID = wsKeyType
			.TableType = wsSrcCd
			.TableKey = "APCQCHQNO"
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
		vFilterAry(1, 2) = "APCQCHQNo"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "Doc. Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "APCQCHQDate"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 1) = "Vendor #"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(3, 2) = "VdrCode"
		
		Dim vAry(4, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "Doc No."
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "APCQCHQNo"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "APCQCHQDate"
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
			wsSQL = "SELECT APCQCHQNo, APCQCHQDate, mstVendor.VdrCode,  mstVendor.VdrName "
			wsSQL = wsSQL & "FROM MstVendor, APCHEQUE "
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE APCQStatus = '1' And APCQVdrID = VdrID "
			.sBindOrderSQL = "ORDER BY APCQDocNo"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmAP002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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
			
			
			cboTMPML.Focus()
			
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
			
			
			txtChqAmtOrg.Focus()
			
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
	
	
	Private Sub txtRmk_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Enter
		
		
		FocusMe(txtRmk)
		
	End Sub
	
	Private Sub txtRmk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLen(txtRmk, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			
			cboVdrCode.Focus()
			
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtRmk_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Leave
		
		FocusMe(txtRmk, True)
		
	End Sub
	
	
	
	
	Private Function Chk_DocNo(ByVal InDocNo As String, ByRef OutStatus As String, ByRef OutUpdFlg As String, ByRef OutDocDate As String, ByRef OutPgmNo As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		OutStatus = ""
		OutUpdFlg = ""
		Chk_DocNo = False
		
		wsSQL = "SELECT APCQCHQDATE, APCQSTATUS, APCQUPDFLG, APCQPGMNO FROM APCHEQUE "
		wsSQL = wsSQL & " WHERE APCQCHQNO = '" & Set_Quote(InDocNo) & "' "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutDocDate = ReadRs(rsRcd, "APCQCHQDATE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutStatus = ReadRs(rsRcd, "APCQSTATUS")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutUpdFlg = ReadRs(rsRcd, "APCQUPDFLG")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutPgmNo = ReadRs(rsRcd, "APCQPGMNO")
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		Chk_DocNo = True
		
		
		
		
	End Function
	
	
	
	Private Function Chk_VdrCode(ByVal InCusNo As String, ByRef OutID As Integer, ByRef OutName As String, ByRef OutTel As String, ByRef OutFax As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT VdrID, VdrName, VdrTel, VdrFax FROM mstVendor WHERE VdrCode = '" & Set_Quote(InCusNo) & "' "
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
		
		
		If To_Value(inAmt) <= 0 Then
			gsMsg = "Cheque Amount Cannot equal to 0!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtChqAmtOrg.Focus()
			Exit Function
		End If
		
		
		If To_Value(inAmt) > CDbl(gsMaxVal) Then
			gsMsg = "數量太大!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtChqAmtOrg.Focus()
			Exit Function
		End If
		
		Chk_txtChqAmtOrg = True
		
	End Function
End Class