Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmGL001
	Inherits System.Windows.Forms.Form
	
	
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	
	
	
	Private wsOldCusNo As String
	Private wsOldCurCd As String
	Private wsOldRmkCd As String
	Private wsOldPayCd As String
	
	
	
	
	Private Const GACCCODE As Short = 0
	Private Const GACCNAME As Short = 1
	Private Const GJOBNO As Short = 2
	Private Const GCURR As Short = 3
	Private Const GEXCR As Short = 4
	Private Const GDAMT As Short = 5
	Private Const GCAMT As Short = 6
	Private Const GTAMT As Short = 7
	Private Const GCHQNO As Short = 8
	Private Const GCHQDATE As Short = 9
	Private Const GRMK As Short = 10
	Private Const GACCID As Short = 11
	
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	Private Const tcPrint As String = "Print"
	
	Private wiOpenDoc As Short
	Private wiAction As Short
	Private wiRevNo As Short
	
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "GLVOHD"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsSrcCd As String
	
	Private wsDocNo As String
	
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	Private wsBaseExcr As String
	Private wsCurrFlg As Boolean
	Private wsSOPFlg As String
	Private wsTitle As String
	
	Private wbLock As Boolean
	Private wbReadOnly As Boolean
	
	
	
	Private wsFormCaption As String
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, GACCCODE, GACCID)
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
		
		wlKey = 0
		
		wiRevNo = CShort(VB6.Format(0, "##0"))
		tblCommon.Visible = False
		
		
		Me.Text = wsFormCaption
		
		wbLock = False
		wbReadOnly = False
		Call Ini_UnLockGrid()
		
		FocusMe(cboPfx)
		
		
		
	End Sub
	
	Private Sub txtRemark_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRemark.Enter
		FocusMe(txtRemark)
	End Sub
	
	Private Sub txtRemark_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRemark.Leave
		FocusMe(txtRemark, True)
	End Sub
	
	
	
	Private Sub txtRemark_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRemark.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsExcRate As String
		Dim wsExcDesc As String
		
		Call chk_InpLen(txtRemark, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			
			If Chk_KeyFld Then
				tblDetail.Focus()
			End If
			
			
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	
	Private Sub cboDocNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.Enter
		
		FocusMe(cboDocNo)
		
	End Sub
	
	Private Sub cboDocNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNo.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNo
		
		
		wsSQL = "SELECT VOHDDOCNO, VOHDDOCDATE "
		wsSQL = wsSQL & " FROM GLVOHD "
		wsSQL = wsSQL & " WHERE VOHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
		wsSQL = wsSQL & " AND VOHDPFX LIKE '%" & IIf(cboPfx.SelectionLength > 0, "", Set_Quote(cboPfx.Text)) & "%' "
		wsSQL = wsSQL & " AND VOHDSTATUS = '1'"
		wsSQL = wsSQL & " ORDER BY VOHDDOCNO DESC "
		
		
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
			
			If Chk_cboPfx() = False Then GoTo EventExitSub
			
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
		Dim wsPgmNo As String
		Dim wsDocDate As String
		
		Chk_cboDocNo = False
		
		If Trim(cboDocNo.Text) = "" And Chk_AutoVou(cboPfx.Text) = "N" Then
			gsMsg = "必需輸入文件號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboDocNo.Focus()
			Exit Function
		End If
		
		
		If Chk_DocNo(cboDocNo.Text, cboPfx.Text, wsStatus, wsPgmNo, wsDocDate) = True Then
			
			If wsStatus = "4" Then
				gsMsg = "文件已入數!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				cboDocNo.Focus()
				Exit Function
			End If
			
			If wsStatus = "2" Then
				gsMsg = "文件已刪除!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				cboDocNo.Focus()
				Exit Function
			End If
			
			If Chk_ValidDocDate(wsDocDate, "GL") = False Then
				wbReadOnly = True
			End If
			
			'  If wsPgmNo <> wsFormID Then
			'  Call Ini_LockGrid
			'  wbLock = True
			'  End If
			
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
			
			Call SetButtonStatus("AfrKeyEdit")
		End If
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		
		Call SetFieldStatus("AfrKey")
		
		medDocDate.Focus()
		
	End Sub
	
	
	
	
	
	
	
	
	'UPGRADE_WARNING: Form event frmGL001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmGL001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		If OpenDoc = True Then
			OpenDoc = False
			wcCombo = cboDocNo
			Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
		End If
		
	End Sub
	
	
	Private Sub frmGL001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
				
				If tbrProcess.Items.Item(tcPrint).Enabled = True Then Call cmdPrint()
				
			Case System.Windows.Forms.Keys.F10
				
				If tbrProcess.Items.Item(tcSave).Enabled = True Then Call cmdSave()
				
			Case System.Windows.Forms.Keys.F11
				
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub frmGL001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
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
		
		
		wsSQL = "SELECT VOHDDOCID, VOHDDOCNO, VOHDDOCDATE, VOHDREVNO, "
		wsSQL = wsSQL & "VOHDREMARK, VODTACCID, VOHDCTLPRD, VODTREMARK, VODTCHQDATE, VODTCHQNO,"
		wsSQL = wsSQL & "COAACCCODE, VODTDESC, VODTJOBNO, VODTCURR, VODTEXCR, VODTDRAMT, VODTCRAMT, VODTTRNAMTL "
		wsSQL = wsSQL & "FROM  GLVOHD, GLVODT, mstCOA "
		wsSQL = wsSQL & "WHERE VOHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
		wsSQL = wsSQL & "AND VOHDPFX = '" & Set_Quote(cboPfx.Text) & "' "
		wsSQL = wsSQL & "AND VOHDDOCID = VODTDOCID "
		wsSQL = wsSQL & "AND VODTACCID = COAACCID "
		wsSQL = wsSQL & "AND VOHDSTATUS <> '2'"
		wsSQL = wsSQL & "ORDER BY VODTDOCLINE "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = ReadRs(rsRcd, "VOHDDOCID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRevNo.Text = VB6.Format(ReadRs(rsRcd, "VOHDREVNO") + 1, "##0")
		wiRevNo = To_Value(ReadRs(rsRcd, "VOHDREVNO"))
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		medDocDate.Text = ReadRs(rsRcd, "VOHDDOCDATE")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtRemark.Text = ReadRs(rsRcd, "VOHDREMARK")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblDspCtlPrd.Text = VB.Right(ReadRs(rsRcd, "VOHDCTLPRD"), 2) & "/" & VB.Left(ReadRs(rsRcd, "VOHDCTLPRD"), 4)
		
		rsRcd.MoveFirst()
		With waResult
			.ReDim(0, -1, GACCCODE, GACCID)
			Do While Not rsRcd.EOF
				wiCtr = wiCtr + 1
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GACCCODE) = ReadRs(rsRcd, "COAACCCODE")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GACCNAME) = ReadRs(rsRcd, "VODTDESC")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GJOBNO) = ReadRs(rsRcd, "VODTJOBNO")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GCURR) = ReadRs(rsRcd, "VODTCURR")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GEXCR) = VB6.Format(ReadRs(rsRcd, "VODTEXCR"), gsExrFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GDAMT) = VB6.Format(ReadRs(rsRcd, "VODTDRAMT"), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GCAMT) = VB6.Format(ReadRs(rsRcd, "VODTCRAMT"), gsAmtFmt)
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GTAMT) = VB6.Format(ReadRs(rsRcd, "VODTTRNAMTL"), gsAmtFmt)
				waResult.get_Value(.get_UpperBound(1), GACCID) = To_Value(ReadRs(rsRcd, "VODTACCID"))
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GRMK) = ReadRs(rsRcd, "VODTREMARK")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GCHQNO) = ReadRs(rsRcd, "VODTCHQNO")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), GCHQDATE) = ReadRs(rsRcd, "VODTCHQDATE")
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
		lblRemark.Text = Get_Caption(waScrItm, "REMARK")
		lblCtlPrd.Text = Get_Caption(waScrItm, "CTLPRD")
		lblBalAmtLoc.Text = Get_Caption(waScrItm, "BALAMTLOC")
		wsTitle = Get_Caption(waScrItm, "RPTTITLE")
		
		With tblDetail
			.Columns(GACCCODE).Caption = Get_Caption(waScrItm, "GACCCODE")
			.Columns(GACCNAME).Caption = Get_Caption(waScrItm, "GACCNAME")
			.Columns(GJOBNO).Caption = Get_Caption(waScrItm, "GJOBNO")
			.Columns(GCURR).Caption = Get_Caption(waScrItm, "GCURR")
			.Columns(GEXCR).Caption = Get_Caption(waScrItm, "GEXCR")
			.Columns(GDAMT).Caption = Get_Caption(waScrItm, "GDAMT")
			.Columns(GCAMT).Caption = Get_Caption(waScrItm, "GCAMT")
			.Columns(GTAMT).Caption = Get_Caption(waScrItm, "GTAMT")
			.Columns(GRMK).Caption = Get_Caption(waScrItm, "GRMK")
			.Columns(GCHQNO).Caption = Get_Caption(waScrItm, "GCHQNO")
			.Columns(GCHQDATE).Caption = Get_Caption(waScrItm, "GCHQDATE")
		End With
		
		
		tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
		tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
		tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
		tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
		tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsActNam(1) = Get_Caption(waScrItm, "GLADD")
		wsActNam(2) = Get_Caption(waScrItm, "GLEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "GLDELETE")
		
		Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	
	Private Sub frmGL001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		'    If Button = 2 Then
		'        PopupMenu mnuMaster
		'    End If
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event frmGL001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmGL001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'   If Me.WindowState = 0 Then
		'       Me.Height = 9000
		'       Me.Width = 12000
		'   End If
	End Sub
	
	Private Sub frmGL001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
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
        'UPGRADE_NOTE: Object frmGL001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
            If Chk_medDocDate Then txtRemark.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_medDocDate() As Boolean
        Dim wsCtrlPrd As String

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


        If Chk_ValidDocDate(medDocDate.Text, "GL") = False Then
            medDocDate.Focus()
            Exit Function
        End If

        wsCtrlPrd = Get_FiscalPeriod(medDocDate.Text)
        lblDspCtlPrd.Text = VB.Right(wsCtrlPrd, 2) & "/" & VB.Left(wsCtrlPrd, 4)


        Chk_medDocDate = True

    End Function




    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        'If wcCombo.Name = tblDetail.Name Then
        '	tblDetail.EditActive = True
        '	'UPGRADE_WARNING: Couldn't resolve default property of object wcCombo.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Select Case wcCombo.Col
        '		Case GACCCODE
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
            '		Case GACCCODE
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


        wsSQL = "SELECT VOHDSTATUS FROM GLVOHD WHERE VOHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' AND VOHDPFX = '" & Set_Quote(cboPfx.Text) & "'"
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


        If Chk_medDocDate = False Then
            Exit Function
        End If

        tblDetail.Enabled = True
        Chk_KeyFld = True

    End Function
    Private Function cmdSave() As Boolean
        Dim wsDteTim As String
        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wlRowCtr As Integer
        Dim wsCtlPrd As String
        Dim wsSts As String
        Dim i As Short
        Dim wdTmpAmt As Double

        On Error GoTo cmdSave_Err

        wsDteTim = Change_SQLDate(CStr(Now))

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

        adcmdSave.CommandText = "USP_GL001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wlKey)
        Call SetSPPara(adcmdSave, 3, Trim(cboPfx.Text))
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, medDocDate.Text)
        Call SetSPPara(adcmdSave, 6, txtRevNo.Text)
        Call SetSPPara(adcmdSave, 7, txtRemark.Text)
        Call SetSPPara(adcmdSave, 8, wsFormID)
        Call SetSPPara(adcmdSave, 9, gsUserID)
        Call SetSPPara(adcmdSave, 10, wsGenDte)
        Call SetSPPara(adcmdSave, 11, wsDteTim)

        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 12)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 13)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_GL001B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, GACCCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, GACCID))
                    Call SetSPPara(adcmdSave, 4, waResult.get_Value(wiCtr, GACCNAME))
                    Call SetSPPara(adcmdSave, 5, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, GJOBNO))
                    Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, GCURR))
                    Call SetSPPara(adcmdSave, 8, waResult.get_Value(wiCtr, GEXCR))
                    Call SetSPPara(adcmdSave, 9, waResult.get_Value(wiCtr, GDAMT))
                    Call SetSPPara(adcmdSave, 10, waResult.get_Value(wiCtr, GCAMT))
                    Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, GTAMT))
                    Call SetSPPara(adcmdSave, 12, waResult.get_Value(wiCtr, GRMK))
                    Call SetSPPara(adcmdSave, 13, waResult.get_Value(wiCtr, GCHQNO))
                    Call SetSPPara(adcmdSave, 14, waResult.get_Value(wiCtr, GCHQDATE))
                    Call SetSPPara(adcmdSave, 15, wsFormID)
                    Call SetSPPara(adcmdSave, 16, gsUserID)
                    Call SetSPPara(adcmdSave, 17, wsGenDte)

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


        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, GACCCODE)) <> "" Then
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


        If To_Value((lblDspBalAmtLoc.Text)) <> 0 Then
            gsMsg = "Balance Amount must equal to zero!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function



    Private Sub cmdNew()

        Dim newForm As New frmGL001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmGL001

        newForm.OpenDoc = True
        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
        newForm.Show()

    End Sub

    Private Sub Ini_Form()

        Me.KeyPreview = True
        '  Me.Left = (Screen.Width - Me.Width) / 2
        '  Me.Top = (Screen.Height - Me.Height) / 2

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "GL001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        Call getExcRate(wsBaseCurCd, gsSystemDate, wsBaseExcr, "")

        wsSrcCd = "GL"
        wsTrnCd = "62"

        If wsBaseCurCd <> "" Then
            wsCurrFlg = False
        Else
            wsCurrFlg = True
        End If

        wsSOPFlg = Get_SystemFlag("SYPINTSOP")

    End Sub



    Private Sub cmdCancel()

        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("AfrActEdit")
        Call SetButtonStatus("AfrActEdit")

        cboPfx.Focus()

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


    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Dim wsPrtDocNo As String
        Dim wsPrtPfx As String

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
            Case tcPrint
                If MsgBox("你是否確定儲存現時之變更而列印?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
                    wsPrtDocNo = cboDocNo.Text
                    wsPrtPfx = cboPfx.Text
                    If cmdSave = False Then Exit Sub
                    cboDocNo.Text = wsPrtDocNo
                    cboPfx.Text = wsPrtPfx
                    Call Ini_Scr_AfrKey()
                End If
                Call cmdPrint()
            Case tcExit
                Me.Close()
        End Select

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


    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 1
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = GACCCODE To GACCID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case GACCCODE
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10
                    Case GACCNAME
                        .Columns(wiCtr).Width = 3000
                        .Columns(wiCtr).DataWidth = 50
                    Case GJOBNO
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Button = True
                    Case GCURR
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 3
                        .Columns(wiCtr).Visible = wsCurrFlg
                    Case GEXCR
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsExrFmt
                        .Columns(wiCtr).Visible = wsCurrFlg
                    Case GDAMT
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GCAMT
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GTAMT
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True
                    Case GRMK
                        .Columns(wiCtr).Width = 6000
                        .Columns(wiCtr).DataWidth = 50
                    Case GCHQNO
                        .Columns(wiCtr).Width = 4000
                        .Columns(wiCtr).DataWidth = 15
                    Case GCHQDATE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 10

                    Case GACCID
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False

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
        Dim wlAccID As Integer
        Dim wsDes As String
        Dim wsExcRat As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case GACCCODE

                    If Chk_Lock Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdAccCode((.Columns(eventArgs.ColIndex).Text), wlAccID, wsDes) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If
                    .Columns(GACCID).Text = CStr(wlAccID)
                    .Columns(GACCNAME).Text = wsDes
                    .Columns(GCURR).Text = wsBaseCurCd
                    .Columns(GEXCR).Text = CStr(To_Value(wsBaseExcr))


                Case GCURR

                    If Chk_grdCurr((.Columns(eventArgs.ColIndex).Text), wsExcRat) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(GEXCR).Text = NBRnd(To_Value(wsExcRat), giExrDp)

                Case GEXCR

                    If chk_grdExcRat((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case GJOBNO

                    If Chk_grdJobNo((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case GCAMT, GDAMT

                    If Chk_Lock Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_Amount((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If
                    If eventArgs.ColIndex = GDAMT Then
                        .Columns(GDAMT).Text = VB6.Format(.Columns(GDAMT).Text, "#,##0." & New String("0", giAmtDp))
                        .Columns(GCAMT).Text = ""
                    Else
                        .Columns(GCAMT).Text = VB6.Format(.Columns(GCAMT).Text, "#,##0." & New String("0", giAmtDp))
                        .Columns(GDAMT).Text = ""
                    End If

            End Select

            '            If To_Value(.Columns(GDAMT).Text) > 0 Then
            '            .Columns(GTAMT).Text = NBRnd(To_Value(.Columns(GDAMT).Text) * _
            ''                                             To_Value(.Columns(GEXCR).Text), giAmtDp)
            '            ElseIf To_Value(.Columns(GCAMT).Text) > 0 Then
            '            .Columns(GTAMT).Text = NBRnd(0 - (To_Value(.Columns(GCAMT).Text) * _
            ''                                             To_Value(.Columns(GEXCR).Text)), giAmtDp)
            '            Else
            '            .Columns(GTAMT).Text = Format(To_Value(.Columns(GTAMT).Text), "#,##0." & String(giAmtDp, "0"))
            '            End If

            .Columns(GTAMT).Text = NBRnd((To_Value((.Columns(GDAMT).Text)) - To_Value((.Columns(GCAMT).Text))) * To_Value((.Columns(GEXCR).Text)), giAmtDp)


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
		Dim wsCtlDte As String
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case GACCCODE
					
					wsSQL = "SELECT COAACCCODE, " & IIf(gsLangID = "2", "COACDESC", "COADESC") & " FROM mstCOA "
					wsSQL = wsSQL & " WHERE COASTATUS <> '2' "
					wsSQL = wsSQL & " AND COAACCCODE LIKE '%" & IIf(Trim(.SelText) <> "", "", Set_Quote(.Columns(GACCCODE).Text)) & "%' "
					wsSQL = wsSQL & " AND COAACCID NOT IN ( "
					wsSQL = wsSQL & " SELECT COAACCID ACCID FROM MSTCOMPANY, MSTCOA WHERE CMPID = '01' AND COAACCCODE = CMPCURREARN "
					wsSQL = wsSQL & " ) "
					
					wsSQL = wsSQL & " ORDER BY COAACCCODE "
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLCOA", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
				Case GCURR
					
					wsCtlDte = IIf(Trim(medDocDate.Text) = "" Or Trim(medDocDate.Text) = "/  /", gsSystemDate, medDocDate.Text)
					wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE WHERE EXCCURR LIKE '%" & IIf(Trim(.SelText) <> "", "", Set_Quote(.Columns(GCURR).Text)) & "%' "
					wsSQL = wsSQL & " AND EXCMN = '" & To_Value(VB6.Format(wsCtlDte, "MM")) & "' "
					wsSQL = wsSQL & " AND EXCYR = '" & Set_Quote(VB6.Format(wsCtlDte, "YYYY")) & "' "
					wsSQL = wsSQL & " AND EXCSTATUS = '1' "
					wsSQL = wsSQL & "ORDER BY EXCCURR "
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLCURCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
				Case GJOBNO
					
					If wsSOPFlg = "Y" Then
						
						wsSQL = "SELECT SOHDDOCNO, CUSCODE FROM SOASOHD, MSTCUSTOMER "
						wsSQL = wsSQL & " WHERE SOHDSTATUS = '4' "
						wsSQL = wsSQL & " AND SOHDDOCNO LIKE '%" & Set_Quote(.Columns(GJOBNO).Text) & "%' "
						wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
						wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
					Else
						wsSQL = "SELECT JOBCODE, JOBNAME FROM mstJOB "
						wsSQL = wsSQL & " WHERE JOBSTATUS <> '2' AND JOBCODE LIKE '%" & Set_Quote(.Columns(GJOBNO).Text) & "%' "
						wsSQL = wsSQL & " ORDER BY JOBCODE "
						
					End If
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLJOBCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
					If Chk_Lock Then Exit Sub
					If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
					If IsEmptyRow Then Exit Sub
					'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
					.ReBind()
					.Focus()
					
				Case System.Windows.Forms.Keys.F8 ' DELETE LINE
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					If Chk_Lock Then Exit Sub
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
						Case GACCCODE, GACCNAME, GCURR, GEXCR, GDAMT, GCAMT, GTAMT, GCHQNO, GCHQDATE
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
						Case GJOBNO
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							
							If wsCurrFlg = False Then
								.Col = GDAMT
							Else
								.Col = GCURR
							End If
							
						Case GRMK
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = GACCCODE
					End Select
				Case System.Windows.Forms.Keys.Left
					Select Case .Col
						Case GACCNAME, GJOBNO, GCURR, GEXCR, GCAMT, GTAMT, GCHQNO, GCHQDATE, GRMK
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col - 1
						Case GDAMT
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							
							If wsCurrFlg = False Then
								.Col = GJOBNO
							Else
								.Col = GEXCR
							End If
							
					End Select
					
				Case System.Windows.Forms.Keys.Right
					Select Case .Col
						Case GACCCODE, GACCNAME, GCURR, GEXCR, GDAMT, GCAMT, GTAMT, GCHQNO, GCHQDATE
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							.Col = .Col + 1
						Case GJOBNO
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
							
							If wsCurrFlg = False Then
								.Col = GDAMT
							Else
								.Col = GCURR
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
			
			Case GDAMT, GCAMT
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
				.Col = GACCCODE
			End If
			
			Call Calc_Total()
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					Case GACCCODE
						Call Chk_grdAccCode(.Columns(GACCCODE).Text, 0, "")
					Case GCURR
						Call Chk_grdCurr((.Columns(GCURR).Text), "")
					Case GEXCR
						Call chk_grdExcRat((.Columns(GEXCR).Text))
					Case GJOBNO
						Call Chk_grdJobNo((.Columns(GJOBNO).Text))
					Case GCAMT, GDAMT
						Call Chk_Amount((.Columns(.Col).Text))
						
				End Select
			End If
		End With
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
	End Sub
	
	
	
	Private Function Chk_grdAccCode(ByRef inNo As String, ByRef outAccID As Integer, ByRef OutDesc As String) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_grdAccCode = False
		
		If Trim(inNo) = "" Then
			Chk_grdAccCode = True
			Exit Function
		End If
		
		wsSQL = "SELECT COAACCID, " & IIf(gsLangID = "2", "COACDESC", "COADESC") & " DES FROM mstCOA"
		wsSQL = wsSQL & " WHERE COAAccCode = '" & Set_Quote(inNo) & "' "
		wsSQL = wsSQL & " AND COASTATUS = '1' "
		wsSQL = wsSQL & " AND COAACCID NOT IN ( "
		wsSQL = wsSQL & " SELECT COAACCID ACCID FROM MSTCOMPANY, MSTCOA WHERE CMPID = '01' AND COAACCCODE = CMPCURREARN "
		wsSQL = wsSQL & " ) "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			gsMsg = "No Such Account Code!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		outAccID = ReadRs(rsRcd, "COAACCID")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutDesc = ReadRs(rsRcd, "DES")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_grdAccCode = True
		
		
	End Function
	
	
	
	Private Function Chk_grdCurr(ByRef inNo As String, ByRef outExcr As String) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_grdCurr = False
		
		If Trim(inNo) = "" Then
			gsMsg = "Curreny Must Input!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If getExcRate(inNo, (medDocDate.Text), outExcr, "") = False Then
			gsMsg = "No Such Curreny in This Month!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		
		Chk_grdCurr = True
		
		
	End Function
	
	
	Private Function chk_grdExcRat(ByRef inRate As String) As Boolean
		
		chk_grdExcRat = False
		
		If To_Value(inRate) = 0 Then
			gsMsg = "Can not equal to Zero!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If To_Value(inRate) > To_Value(gsMaxVal) Then
			gsMsg = "數量太大!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_grdExcRat = True
		
	End Function
	
	
	Private Function Chk_Amount(ByRef inAmt As String) As Short
		
		Chk_Amount = False
		
		If Trim(inAmt) = "" Then
			Chk_Amount = True
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
				If Trim(.Columns(GACCCODE).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				If Trim(waResult.get_Value(inRow, GACCCODE)) = "" And Trim(waResult.get_Value(inRow, GACCNAME)) = "" And Trim(waResult.get_Value(inRow, GJOBNO)) = "" And Trim(waResult.get_Value(inRow, GCURR)) = "" And Trim(waResult.get_Value(inRow, GEXCR)) = "" And Trim(waResult.get_Value(inRow, GDAMT)) = "" And Trim(waResult.get_Value(inRow, GCAMT)) = "" And Trim(waResult.get_Value(inRow, GTAMT)) = "" And Trim(waResult.get_Value(inRow, GRMK)) = "" And Trim(waResult.get_Value(inRow, GCHQNO)) = "" And Trim(waResult.get_Value(inRow, GCHQDATE)) = "" And Trim(waResult.get_Value(inRow, GACCID)) = "" Then
					Exit Function
				End If
			End If
		End If
		
		IsEmptyRow = False
		
	End Function
	
	
	Private Function Chk_grdJobNo(ByRef inNo As String) As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_grdJobNo = False
		
		'If Trim(inNo) = "" Then
		Chk_grdJobNo = True
		Exit Function
		'End If
		
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
			
			If Chk_grdAccCode(waResult.get_Value(LastRow, GACCCODE), 0, "") = False Then
				.Col = GACCCODE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdCurr(waResult.get_Value(LastRow, GCURR), "") = False Then
				.Col = GCURR
				.Row = LastRow
				Exit Function
			End If
			
			
			
			If chk_grdExcRat(waResult.get_Value(LastRow, GEXCR)) = False Then
				.Col = GEXCR
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdJobNo(waResult.get_Value(LastRow, GJOBNO)) = False Then
				.Col = GJOBNO
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_Amount(waResult.get_Value(LastRow, GDAMT)) = False Then
				.Col = GDAMT
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_Amount(waResult.get_Value(LastRow, GCAMT)) = False Then
				.Col = GCAMT
				.Row = LastRow
				Exit Function
			End If
			
			If To_Value(waResult.get_Value(LastRow, GCAMT)) = 0 And To_Value(waResult.get_Value(LastRow, GDAMT)) = 0 Then
				gsMsg = "Must Have Amount in CR or DR side!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				.Col = GDAMT
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
			wiTotal = wiTotal + To_Value(waResult.get_Value(wiRowCtr, GTAMT))
		Next 
		
		lblDspBalAmtLoc.Text = VB6.Format(CStr(wiTotal), gsAmtFmt)
		
		Calc_Total = True
		
	End Function
	
	
	
	
	Private Function cmdDel() As Boolean
		Dim wsDteTim As String
		Dim wsGenDte As String
		Dim adcmdDelete As New ADODB.Command
		Dim wsDocNo As String
		Dim i As Short
		
		cmdDel = False
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		On Error GoTo cmdDelete_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		wsDteTim = Change_SQLDate(CStr(Now))
		
		If ReadOnlyMode(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID) Or wbLock Or wbReadOnly Then
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
		
		adcmdDelete.CommandText = "USP_GL001A"
		adcmdDelete.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdDelete.Parameters.Refresh()
		Call SetSPPara(adcmdDelete, 1, wiAction)
		Call SetSPPara(adcmdDelete, 2, wlKey)
		Call SetSPPara(adcmdDelete, 3, Trim(cboPfx.Text))
		Call SetSPPara(adcmdDelete, 4, Trim(cboDocNo.Text))
		Call SetSPPara(adcmdDelete, 5, medDocDate.Text)
		Call SetSPPara(adcmdDelete, 6, txtRevNo.Text)
		Call SetSPPara(adcmdDelete, 7, txtRemark.Text)
		Call SetSPPara(adcmdDelete, 8, wsFormID)
		Call SetSPPara(adcmdDelete, 9, gsUserID)
		Call SetSPPara(adcmdDelete, 10, wsGenDte)
		Call SetSPPara(adcmdDelete, 11, wsDteTim)
		
		adcmdDelete.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wlKey = GetSPPara(adcmdDelete, 12)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsDocNo = GetSPPara(adcmdDelete, 13)
		
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
					.Items.Item(tcPrint).Enabled = False
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
					.Items.Item(tcPrint).Enabled = False
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
					.Items.Item(tcPrint).Enabled = False
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
					.Items.Item(tcPrint).Enabled = False
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
					.Items.Item(tcPrint).Enabled = True
					.Items.Item(tcExit).Enabled = True
				End With
				
			Case "ReadOnly"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = False
					.Items.Item(tcCancel).Enabled = False
					.Items.Item(tcPrint).Enabled = True
					.Items.Item(tcExit).Enabled = True
					
				End With
				
				
				
		End Select
	End Sub
	
	
	
	'-- Set field status, Default, Add, Edit.
	Public Sub SetFieldStatus(ByVal sStatus As String)
		Select Case sStatus
			Case "Default"
				
				Me.cboPfx.Enabled = False
				Me.cboDocNo.Enabled = False
				Me.txtRevNo.Enabled = False
				Me.medDocDate.Enabled = False
				Me.txtRemark.Enabled = False
				
				Me.tblDetail.Enabled = False
				
			Case "AfrActAdd"
				
				Me.cboPfx.Enabled = True
				Me.cboDocNo.Enabled = True
				
			Case "AfrActEdit"
				
				Me.cboPfx.Enabled = True
				Me.cboDocNo.Enabled = True
				
			Case "AfrKey"
				Me.cboPfx.Enabled = False
				Me.cboDocNo.Enabled = False
				
				Me.txtRevNo.Enabled = True
				Me.medDocDate.Enabled = True
				Me.txtRemark.Enabled = True
				
				
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
			.TableType = cboPfx.Text
			.TableKey = "VOHDDOCNO"
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
		vFilterAry(1, 1) = "Doc No."
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(1, 2) = "vohdDocNo"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 1) = "Doc. Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vFilterAry(2, 2) = "vohdDocDate"
		
		
		Dim vAry(2, 3) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 1) = "Doc No."
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 2) = "vohdDocNo"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(1, 3) = "1500"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 1) = "Date"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 2) = "voHdDocDate"
		'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		vAry(2, 3) = "1500"
		
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		With frmShareSearch
			wsSQL = "SELECT INHdDocNo, InHdDocDate "
			wsSQL = wsSQL & "FROM GLVOHD "
			.sBindSQL = wsSQL
			.sBindWhereSQL = "WHERE InHdStatus = '1' "
			.sBindOrderSQL = "ORDER BY voHdDocNo"
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vHeadDataAry = VB6.CopyArray(vAry)
			'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.vFilterAry = VB6.CopyArray(vFilterAry)
			.ShowDialog()
		End With
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmGL001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboDocNo.Text Then
			cboDocNo.Text = Trim(frmShareSearch.Tag)
			cboDocNo.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		frmShareSearch.Close()
		
	End Sub
	
	
	
	Private Sub txtRevNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRevNo.Leave
		FocusMe(txtRevNo, True)
	End Sub
	
	
	
	
	
	
	Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
		If eventArgs.Button = 2 Then
			'UPGRADE_ISSUE: Form method frmGL001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
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
					If Chk_Lock Then Exit Sub
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
					If Chk_Lock Then Exit Sub
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
	Private Function Chk_DocNo(ByVal InDocNo As String, ByVal InPfx As String, ByRef OutStatus As String, ByRef OutPgmNo As String, ByRef OutDocDate As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		OutStatus = ""
		OutPgmNo = ""
		Chk_DocNo = False
		
		wsSQL = "SELECT VOHDDOCDATE, VOHDSTATUS, VOHDPGMNO FROM GLVOHD "
		wsSQL = wsSQL & " WHERE VOHDDOCNO = '" & Set_Quote(InDocNo) & "'"
		wsSQL = wsSQL & " AND VOHDPFX = '" & Set_Quote(InPfx) & "'"
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutStatus = ReadRs(rsRcd, "VOHDSTATUS")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutPgmNo = ReadRs(rsRcd, "VOHDPGMNO")
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		OutDocDate = ReadRs(rsRcd, "VOHDDOCDATE")
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		
		Chk_DocNo = True
		
		
	End Function
	
	
	
	Private Sub cboPfx_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPfx.Enter
		
		FocusMe(cboPfx)
		
	End Sub
	
	Private Sub cboPfx_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPfx.DropDown
		
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboPfx
		
		
		wsSQL = "SELECT VOUPREFIX, VOUDESC "
		wsSQL = wsSQL & " FROM SYSVOUNO "
		wsSQL = wsSQL & " WHERE VOUPREFIX LIKE '%" & IIf(cboPfx.SelectionLength > 0, "", Set_Quote(cboPfx.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY VOUPREFIX "
		
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboPfx.Left)), VB6.PixelsToTwipsY(cboPfx.Top) + VB6.PixelsToTwipsY(cboPfx.Height), tblCommon, wsFormID, "TBLPFX", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub cboPfx_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPfx.Leave
		FocusMe(cboPfx, True)
	End Sub
	
	Private Sub cboPfx_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPfx.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLenC(cboPfx, 3, KeyAscii, True, True)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			
			If Chk_cboPfx() = False Then GoTo EventExitSub
			
			cboDocNo.Focus()
			
		End If
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function Chk_cboPfx() As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsStatus As String
		Dim wsUpdFlg As String
		Dim wsTrnCode As String
		Dim wsDocDate As String
		Dim wsPgmNo As String
		
		Chk_cboPfx = False
		
		If Trim(cboPfx.Text) = "" Then
			gsMsg = "Must Input Voucher Prefix!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			cboPfx.Focus()
			Exit Function
		End If
		
		
		'  If Chk_VouPrefix(cboPfx.Text) = False Then
		'           gsMsg = "This is not a valid prefix!"
		'           MsgBox gsMsg, vbOKOnly, gsTitle
		'           cboPfx.SetFocus
		'           Exit Function
		'  End If
		Chk_cboPfx = True
		
	End Function
	
	Private Sub cmdPrint()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(5)
		wsSelection(1) = lblDocNo.Text & " " & Set_Quote(cboDocNo.Text)
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTGLP006 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & wsTitle & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboPfx.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
		wsSQL = wsSQL & "'000000', "
		wsSQL = wsSQL & "'999999', "
		wsSQL = wsSQL & "'', "
		wsSQL = wsSQL & "'" & New String("z", 10) & "', "
		wsSQL = wsSQL & "'0000/00/00', "
		wsSQL = wsSQL & "'9999/99/99', "
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTGLP006P"
		Else
			wsRptName = "RPTGLP006P"
		End If
		
		NewfrmPrint.ReportID = "GLP006"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "GLP006"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	Private Sub Ini_LockGrid()
		
		
		With tblDetail
			.EmptyRows = False
			.AllowAddNew = False
			.AllowDelete = False
			
			
		End With
		
	End Sub
	
	Private Sub Ini_UnLockGrid()
		
		
		With tblDetail
			.EmptyRows = True
			.AllowAddNew = True
			.AllowDelete = True
		End With
		
	End Sub
	
	Private Function Chk_Lock() As Boolean
		
		If wbLock Then
			gsMsg = "不能更改或刪除!文件由倉庫入數!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		End If
		
		Chk_Lock = wbLock
		
	End Function
End Class