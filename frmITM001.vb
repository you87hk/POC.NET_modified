Option Strict Off
Option Explicit On
Friend Class frmITM001
	Inherits System.Windows.Forms.Form
	Private wsFormCaption As String
	Private waResult As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	Private Const tcKey As String = "Key"
	Private Const tcCopy As String = "Copy"
	
	Private wsActNam(4) As String
	Private wiAction As Short
	Private wlKey As Integer
	Private wbAfrKey As Boolean
	
	Private Const ITMCODE As Short = 0
	Private Const ITMDESC As Short = 1
	Private Const QTY As Short = 2
	Private Const ITMID As Short = 3
	
	Dim wcCombo As System.Windows.Forms.Control
	
	Private Const wsKeyType As String = "MstItem"
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsFormID As String
	Private wsConnTime As String
	
	Private wdOldPrice As Double
	Private wbErr As Boolean
	Private wlVdrID As Integer
	
	Private Sub btnItemPrice_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnItemPrice.Click
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmIP001.ITMCODE = cboITMCODE.Text
		frmIP001.Show()
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmITM001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
	End Sub
	
	Private Sub btnPriceChange_Click()
		'frmB0011.InBookName = Me.txtItmChiName
		'frmB0011.inISBN = Me.cboItmCode
		'frmB0011.InItemID = wlKey
		'frmB0011.Show vbModal
	End Sub
	
	Private Sub cboItmPVdrCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmPVdrCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmPVdrCode
		
		wsSQL = "SELECT VdrCode, VdrName FROM MstVendor WHERE VdrStatus = '1'"
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " AND VdrCode LIKE '%" & IIf(cboItmPVdrCode.SelectionLength > 0, "", Set_Quote(cboItmPVdrCode.Text)) & "%' "
		
		wsSQL = wsSQL & "ORDER BY VdrCode "
		Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboItmPVdrCode.Left) + VB6.PixelsToTwipsX(Me.tabDetailInfo.Left), VB6.PixelsToTwipsY(cboItmPVdrCode.Top) + VB6.PixelsToTwipsY(cboItmPVdrCode.Height) + VB6.PixelsToTwipsY(Me.tabDetailInfo.Top), tblCommon, wsFormID, "TBLV", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmPVdrCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmPVdrCode.Enter
		FocusMe(cboItmPVdrCode)
	End Sub
	
	Private Sub cboItmPVdrCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmPVdrCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmPVdrCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If chk_cboVdrCode() = True Then
				txtItmUnitPrice.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmPVdrCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmPVdrCode.Leave
		FocusMe(cboItmPVdrCode, True)
	End Sub
	
	Private Sub cboItmUOMCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmUOMCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmUOMCode
		
		wsSQL = "SELECT UOMCode, UOMDesc FROM MstUOM WHERE UOMStatus = '1'"
		wsSQL = wsSQL & "ORDER BY UOMCode "
		Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboItmUOMCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboItmUOMCode.Top) + VB6.PixelsToTwipsY(cboItmUOMCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLUOM", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmUOMCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmUOMCode.Enter
		FocusMe(cboItmUOMCode)
	End Sub
	
	Private Sub cboItmUOMCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmUOMCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmUOMCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboItmUOMCode() = False Then
				GoTo EventExitSub
			End If
			
			tabDetailInfo.SelectedIndex = 0
			txtItmBarCode.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmUOMCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmUOMCode.Leave
		FocusMe(cboItmUOMCode, True)
	End Sub
	
	Private Sub chkItmInActive_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkItmInActive.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			tabDetailInfo.SelectedIndex = 1
			chkItmInvItemFlg.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub chkItmInvItemFlg_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkItmInvItemFlg.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			tabDetailInfo.SelectedIndex = 1
			chkItmReorderInd.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub chkItmReorderInd_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkItmReorderInd.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			tabDetailInfo.SelectedIndex = 1
			txtItmReorderQty.Focus()
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub chkOwnEdition_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkOwnEdition.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If tblDetail.Enabled = True Then
				tabDetailInfo.SelectedIndex = 2
				tblDetail.Focus()
			Else
				txtItmChiName.Focus()
			End If
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmITM001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.PageDown
				KeyCode = 0
				If tabDetailInfo.SelectedIndex < tabDetailInfo.TabPages.Count() - 1 Then
					If tabDetailInfo.TabPages.Item(tabDetailInfo.SelectedIndex + 1).Visible = True Then
						tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex + 1
					End If
					Exit Sub
				End If
			Case System.Windows.Forms.Keys.PageUp
				KeyCode = 0
				If tabDetailInfo.SelectedIndex > 0 Then
					If tabDetailInfo.TabPages.Item(tabDetailInfo.SelectedIndex - 1).Visible = True Then
						tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex - 1
					End If
					Exit Sub
				End If
				
			Case System.Windows.Forms.Keys.F7
				If tbrProcess.Items.Item(tcKey).Enabled = True Then
					Call cmdChangeKey(CorRec)
				End If
				
				
			Case System.Windows.Forms.Keys.F2
				If wiAction = DefaultPage Then Call cmdNew()
				
				
			Case System.Windows.Forms.Keys.F5
				If wiAction = DefaultPage Then Call cmdEdit()
				
				
			Case System.Windows.Forms.Keys.F3
				If wiAction = DefaultPage Then Call cmdDel()
				
			Case System.Windows.Forms.Keys.F9
				
				If tbrProcess.Items.Item(tcFind).Enabled = True Then
					Call cmdFind()
				End If
				
			Case System.Windows.Forms.Keys.F10
				If tbrProcess.Items.Item(tcSave).Enabled = True Then
					Call cmdSave()
				End If
				
			Case System.Windows.Forms.Keys.F11
				
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
	End Sub
	
	Private Sub frmITM001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim iCounter As Short
		Dim iTabs As Short
		Dim vToolTip As Object
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsFormCaption = Me.Text
		
		IniForm()
		Ini_Caption()
		Ini_Grid()
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	'UPGRADE_WARNING: Event frmITM001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmITM001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		'-- Resize, not maximum and minimax.
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(7500)
			Me.Width = VB6.TwipsToPixelsX(11000)
		End If
	End Sub
	
	'-- Set toolbar buttons status in different mode, Default, AddEdit, None.
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
					.Items.Item(tcFind).Enabled = False
					.Items.Item(tcKey).Enabled = False
					.Items.Item(tcCopy).Enabled = False
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
					.Items.Item(tcFind).Enabled = True
					.Items.Item(tcExit).Enabled = True
					.Items.Item(tcKey).Enabled = False
					.Items.Item(tcCopy).Enabled = False
					
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
					.Items.Item(tcKey).Enabled = False
					.Items.Item(tcCopy).Enabled = False
					
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
					.Items.Item(tcKey).Enabled = False
					.Items.Item(tcCopy).Enabled = False
					
				End With
				
			Case "AfrKeyEdit"
				With tbrProcess
					.Items.Item(tcOpen).Enabled = True
					.Items.Item(tcAdd).Enabled = False
					.Items.Item(tcEdit).Enabled = False
					.Items.Item(tcDelete).Enabled = False
					.Items.Item(tcSave).Enabled = True
					.Items.Item(tcCancel).Enabled = True
					.Items.Item(tcFind).Enabled = False
					.Items.Item(tcExit).Enabled = True
					.Items.Item(tcKey).Enabled = True
					.Items.Item(tcCopy).Enabled = True
					
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
					.Items.Item(tcKey).Enabled = False
					.Items.Item(tcCopy).Enabled = False
					
				End With
		End Select
	End Sub
	
	'-- Set field status, Default, Add, Edit.
	Public Sub SetFieldStatus(ByVal sStatus As String)
		Dim i As Short
		Select Case sStatus
			Case "Default"
				Me.cboITMCODE.Enabled = False
				Me.cboItemClassCode.Enabled = False
				Me.txtItmCode.Enabled = False
				Me.txtItmChiName.Enabled = False
				Me.txtItmEngName.Enabled = False
				
				'Tab 0 fields
				Me.cboItmTypeCode.Enabled = False
				Me.cboItmUOMCode.Enabled = False
				Me.txtItmBarCode.Enabled = False
				Me.txtItmSeriesNo.Enabled = False
				Me.txtItmBinNo.Enabled = False
				Me.cboItmAccTypeCode.Enabled = False
				
				Me.cboItmCurr.Enabled = False
				Me.cboItmPVdrCode.Enabled = False
				
				Me.txtItmUnitPrice.Enabled = False
				Me.txtItmDiscount.Enabled = False
				Me.txtItmBottomPrice.Enabled = False
				Me.txtItmMarkUp.Enabled = False
				Me.txtItmDefaultPrice.Enabled = False
				
				Me.btnItemPrice.Enabled = False
				
				fraInfo.Visible = True
				fraPrice.Visible = True
				cboItmAccTypeCode.Visible = True
				cboItmCurr.Visible = True
				cboItmPVdrCode.Visible = True
				cboItmTypeCode.Visible = True
				cboItmUOMCode.Visible = True
				
				'Tab 1 fields
				Me.chkItmInActive.Enabled = False
				Me.chkItmInvItemFlg.Enabled = False
				Me.chkItmReorderInd.Enabled = False
				
				Me.txtItmReorderQty.Enabled = False
				Me.txtItmMaxQty.Enabled = False
				Me.txtItmPORepuQty.Enabled = False
				
				fraContent.Visible = True
				
				'Tab 2 fields
				Me.chkOwnEdition.Enabled = False
				Me.tblDetail.Enabled = False
				
				tabDetailInfo.TabPages.Item(2).Visible = True
				
			Case "AfrActAdd"
				Me.cboITMCODE.Enabled = False
				Me.cboITMCODE.Visible = False
				
				Me.txtItmCode.Enabled = True
				Me.txtItmCode.Visible = True
				
				Me.cboItemClassCode.Enabled = True
				
				
			Case "AfrActEdit"
				Me.cboITMCODE.Enabled = True
				Me.cboITMCODE.Visible = True
				
				Me.txtItmCode.Enabled = False
				Me.txtItmCode.Visible = False
				
				'Me.cboItemClassCode.Enabled = True
				Me.cboItemClassCode.Enabled = False
				
			Case "AfrKey"
				Me.txtItmCode.Enabled = False
				Me.cboITMCODE.Enabled = False
				Me.cboItemClassCode.Enabled = False
				'    Me.cboItemClassCode.Enabled = True
				
				Me.txtItmChiName.Enabled = True
				Me.txtItmEngName.Enabled = True
				
				Select Case UCase(cboItemClassCode.Text)
					Case "P"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						
						Me.txtItmUnitPrice.Enabled = True
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = True
						Me.chkItmInvItemFlg.Enabled = True
						Me.chkItmReorderInd.Enabled = True
						
						Me.txtItmReorderQty.Enabled = True
						Me.txtItmMaxQty.Enabled = True
						Me.txtItmPORepuQty.Enabled = True
						
						fraContent.Visible = True
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
					Case "N"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						
						Me.txtItmUnitPrice.Enabled = True
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = False
						Me.chkItmInvItemFlg.Enabled = False
						Me.chkItmReorderInd.Enabled = False
						
						Me.txtItmReorderQty.Enabled = False
						Me.txtItmMaxQty.Enabled = False
						Me.txtItmPORepuQty.Enabled = False
						
						fraContent.Visible = False
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
					Case "D"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = False
						Me.cboItmUOMCode.Enabled = False
						Me.txtItmBarCode.Enabled = False
						Me.txtItmSeriesNo.Enabled = False
						Me.txtItmBinNo.Enabled = False
						Me.cboItmAccTypeCode.Enabled = False
						
						Me.cboItmCurr.Enabled = False
						Me.cboItmPVdrCode.Enabled = False
						
						Me.txtItmUnitPrice.Enabled = False
						Me.txtItmDiscount.Enabled = False
						Me.txtItmBottomPrice.Enabled = False
						Me.txtItmMarkUp.Enabled = False
						Me.txtItmDefaultPrice.Enabled = False
						
						Me.btnItemPrice.Enabled = False
						
						fraInfo.Visible = False
						fraPrice.Visible = False
						cboItmAccTypeCode.Visible = False
						cboItmCurr.Visible = False
						cboItmPVdrCode.Visible = False
						cboItmTypeCode.Visible = False
						cboItmUOMCode.Visible = False
						
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = False
						Me.chkItmInvItemFlg.Enabled = False
						Me.chkItmReorderInd.Enabled = False
						
						Me.txtItmReorderQty.Enabled = False
						Me.txtItmMaxQty.Enabled = False
						Me.txtItmPORepuQty.Enabled = False
						
						fraContent.Visible = False
						
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
					Case "S"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						
						Me.txtItmUnitPrice.Enabled = True
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = False
						Me.chkItmInvItemFlg.Enabled = False
						Me.chkItmReorderInd.Enabled = False
						
						Me.txtItmReorderQty.Enabled = False
						Me.txtItmMaxQty.Enabled = False
						Me.txtItmPORepuQty.Enabled = False
						
						fraContent.Visible = False
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
					Case "L"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						
						Me.txtItmUnitPrice.Enabled = True
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = False
						Me.chkItmInvItemFlg.Enabled = False
						Me.chkItmReorderInd.Enabled = False
						
						Me.txtItmReorderQty.Enabled = False
						Me.txtItmMaxQty.Enabled = False
						Me.txtItmPORepuQty.Enabled = False
						
						fraContent.Visible = False
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
					Case "A"
						'Tab 0 fields
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						
						Me.txtItmUnitPrice.Enabled = True
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = True
						Me.chkItmInvItemFlg.Enabled = True
						Me.chkItmReorderInd.Enabled = True
						
						Me.txtItmReorderQty.Enabled = True
						Me.txtItmMaxQty.Enabled = True
						Me.txtItmPORepuQty.Enabled = True
						
						fraContent.Visible = True
						
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = True
						Me.tblDetail.Enabled = True
						
						tabDetailInfo.TabPages.Item(2).Visible = True
						
					Case "T"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						
						Me.txtItmUnitPrice.Enabled = True
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = False
						Me.chkItmInvItemFlg.Enabled = False
						Me.chkItmReorderInd.Enabled = False
						
						Me.txtItmReorderQty.Enabled = False
						Me.txtItmMaxQty.Enabled = False
						Me.txtItmPORepuQty.Enabled = False
						
						fraContent.Visible = False
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
						
					Case "C"
						'Tab 0 fields
						Me.cboItmTypeCode.Enabled = True
						Me.cboItmUOMCode.Enabled = True
						Me.txtItmBarCode.Enabled = True
						Me.txtItmSeriesNo.Enabled = True
						Me.txtItmBinNo.Enabled = True
						Me.cboItmAccTypeCode.Enabled = True
						
						Me.cboItmCurr.Enabled = True
						Me.cboItmPVdrCode.Enabled = True
						Me.txtItmUnitPrice.Enabled = True
						
						Me.txtItmDiscount.Enabled = True
						Me.txtItmBottomPrice.Enabled = True
						Me.txtItmMarkUp.Enabled = True
						Me.txtItmDefaultPrice.Enabled = True
						
						If wiAction = CorRec Then
							Me.btnItemPrice.Enabled = True
						End If
						
						fraInfo.Visible = True
						fraPrice.Visible = True
						cboItmAccTypeCode.Visible = True
						cboItmCurr.Visible = True
						cboItmPVdrCode.Visible = True
						cboItmTypeCode.Visible = True
						cboItmUOMCode.Visible = True
						
						'Tab 1 fields
						Me.chkItmInActive.Enabled = False
						Me.chkItmInvItemFlg.Enabled = False
						Me.chkItmReorderInd.Enabled = False
						
						Me.txtItmReorderQty.Enabled = False
						Me.txtItmMaxQty.Enabled = False
						Me.txtItmPORepuQty.Enabled = False
						
						fraContent.Visible = False
						
						'Tab 2 fields
						Me.chkOwnEdition.Enabled = False
						Me.tblDetail.Enabled = False
						
						tabDetailInfo.TabPages.Item(2).Visible = False
						
						
				End Select
		End Select
	End Sub
	
	'-- Input validation checking.
	Private Function InputValidation() As Boolean
		
		On Error GoTo InputValidation_Err
		
		InputValidation = False
		
		
		If Chk_txtItmChiName = False Then
			Exit Function
		End If
		
		If Chk_cboItmTypeCode = False Then
			Exit Function
		End If
		
		
		If chk_cboVdrCode = False Then
			Exit Function
		End If
		
		If Chk_cboItmUOMCode = False Then
			Exit Function
		End If
		
		
		If Chk_cboItmCurr = False Then
			Exit Function
		End If
		
		If Chk_cboItmAccTypeCode() = False Then
			Exit Function
		End If
		
		If Chk_txtItmDiscount = False Then
			Exit Function
		End If
		
		InputValidation = True
		
		Exit Function
		
InputValidation_Err: 
		
		MsgBox("Error on InputValidation_Err " & Err.Description)
		InputValidation = False
		
		
	End Function
	
	Public Function LoadRecord() As Boolean
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		Dim wiCtr As Short
		
		wsSQL = "SELECT * "
		wsSQL = wsSQL & "From MstItem "
		wsSQL = wsSQL & "WHERE (((MstItem.ItmCode)='" & Set_Quote(cboITMCODE.Text) & "') AND ((MstItem.ItmStatus)='1'));"
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			LoadRecord = False
			wlKey = 0
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlKey = ReadRs(rsRcd, "ItmID")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboItemClassCode.Text = ReadRs(rsRcd, "ItmClass")
			Me.lblDspItemClassCode.Text = Get_TableInfo("MstItemClass", "ItemClassCode='" & cboItemClassCode.Text & "'", IIf(gsLangID = "1", "ItemClassEDesc", "ItemClassCDesc"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtItmChiName.Text = ReadRs(rsRcd, "ItmChiName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtItmEngName.Text = ReadRs(rsRcd, "ItmEngName")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspItmLastUpd.Text = ReadRs(rsRcd, "ItmLastUpd")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblDspItmLastUpdDate.Text = ReadRs(rsRcd, "ItmLastUpdDate")
			
			'Tab 0
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboItmTypeCode.Text = ReadRs(rsRcd, "ItmItmTypeCode")
			lblDspItmTypeDesc.Text = LoadDescByCode("MstItemType", "ItmTypeCode", "ItmTypeChiDesc", cboItmTypeCode.Text, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboItmUOMCode.Text = ReadRs(rsRcd, "ItmUOMCode")
			lblDspItmUomDesc.Text = LoadDescByCode("MstUOM", "UomCode", "UomDesc", cboItmUOMCode.Text, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtItmBarCode.Text = ReadRs(rsRcd, "ItmBarCode")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtItmSeriesNo.Text = ReadRs(rsRcd, "ItmSeriesNo")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.txtItmBinNo.Text = ReadRs(rsRcd, "ItmBinNo")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboItmAccTypeCode.Text = ReadRs(rsRcd, "ItmAccTypeCode")
			lblDspItmAccTypeDesc.Text = LoadDescByCode("MstAccountType", "AccTypeCode", "AccTypeDesc", cboItmAccTypeCode.Text, True)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.cboItmCurr.Text = ReadRs(rsRcd, "ItmCurr")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wlVdrID = ReadRs(rsRcd, "ItmPVdrID")
			cboItmPVdrCode.Text = Get_TableInfo("MstVendor", "VdrID=" & wlVdrID, "VdrCode")
			
			txtItmUnitPrice.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmUnitPrice")), gsUprFmt)
			txtItmDiscount.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmDiscount")), gsUprFmt)
			txtItmBottomPrice.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmBottomPrice")), gsUprFmt)
			txtItmMarkUp.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmMarkUp")), gsUprFmt)
			txtItmDefaultPrice.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmDefaultPrice")), gsUprFmt)
			
			'Tab 1 fields
			Me.lblDspStkOnHand.Text = CStr(Get_IcTrnQty("INOUT", wlKey, "", ""))
			Me.lblDspStkAllocated.Text = CStr(Get_IcTrnQty("STKALL", wlKey, "", ""))
			Me.lblDspStkOnOrder.Text = CStr(Get_IcTrnQty("STKORD", wlKey, "", ""))
			Me.lblDspStkIndent.Text = CStr(Get_IcTrnQty("STKIND", wlKey, "", ""))
			Me.lblDspStkAvailable.Text = CStr(Get_IcTrnQty("%", wlKey, "", ""))
			' Me.lblDspUnitPrice.Caption = Get_AvgCost(wlKey, "")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call Set_CheckValue(chkItmInActive, ReadRs(rsRcd, "ItmInActive"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call Set_CheckValue(chkItmInvItemFlg, ReadRs(rsRcd, "ItmInvItemFlg"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call Set_CheckValue(chkItmReorderInd, ReadRs(rsRcd, "ItmReorderInd"))
			
			Me.txtItmReorderQty.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmReorderQty")), gsQtyFmt)
			Me.txtItmMaxQty.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmMaxQty")), gsQtyFmt)
			Me.txtItmPORepuQty.Text = VB6.Format(To_Value(ReadRs(rsRcd, "ItmPORepuQty")), gsQtyFmt)
			
			'Tab 2 fields
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call Set_CheckValue(chkOwnEdition, ReadRs(rsRcd, "ItmOwnEdition"))
			rsRcd.Close()
			
			wsSQL = "SELECT MstBOM.*, MstItem.ItmCode, MstItem.ItmChiName, MstItem.ItmEngName "
			wsSQL = wsSQL & "From MstBOM, MstItem "
			wsSQL = wsSQL & "WHERE (((MstBOM.BOMItmID)=" & CStr(wlKey) & ") AND ((MstItem.ItmID)=MstBOM.BOMDTItmID));"
			
			rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			If rsRcd.RecordCount <> 0 Then
				rsRcd.MoveFirst()
				With waResult
					.ReDim(0, -1, ITMCODE, ITMID)
					Do While Not rsRcd.EOF
						wiCtr = wiCtr + 1
						.AppendRows()
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						waResult.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsRcd, "ITMCODE")
						waResult.get_Value(.get_UpperBound(1), ITMDESC) = IIf(gsLangID = "1", ReadRs(rsRcd, "ItmEngName"), ReadRs(rsRcd, "ItmChiName"))
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						waResult.get_Value(.get_UpperBound(1), QTY) = ReadRs(rsRcd, "BOMQTY")
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						waResult.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsRcd, "BOMITMID")
						rsRcd.MoveNext()
					Loop 
				End With
				
				tblDetail.ReBind()
				tblDetail.FirstRow = 0
			End If
			
			LoadRecord = True
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	
	Private Sub frmITM001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        ' Set waPgmItm = Nothing
        'UPGRADE_NOTE: Object frmITM001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub

    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then
            If cboItmCurr.Enabled = True Then
                cboItmCurr.Focus()
            End If
        ElseIf tabDetailInfo.SelectedIndex = 1 Then
            If txtItmReorderQty.Enabled = True Then
                txtItmReorderQty.Focus()
            End If
        End If
        PreviousTab = tabDetailInfo.SelectedIndex()
    End Sub

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange
        On Error GoTo tblDetail_BeforeRowColChange_Err

        With tblDetail
            ' If .Bookmark <> .DestinationRow Then
            If Chk_GrdRow(To_Value(.Bookmark)) = False Then
                eventArgs.cancel = True
                Exit Sub
            End If
            ' End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:
        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)


        Select Case Button.Name
            Case tcOpen
                Call cmdOpen()

            Case tcAdd
                Call cmdNew()

            Case tcEdit
                Call cmdEdit()

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

                Call OpenPromptForm()

            Case tcKey

                Call cmdChangeKey(CorRec)

            Case tcCopy

                Call cmdChangeKey(AddRec)

            Case tcExit

                Me.Close()

        End Select
    End Sub

    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmITM001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If
    End Sub

    Private Sub IniForm()
        Me.KeyPreview = True
        '  Me.Left = 0
        '  Me.Top = 0
        '  Me.Width = Screen.Width
        '  Me.Height = Screen.Height


        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "ITM001"
        wsTrnCd = ""
    End Sub


    Private Sub Ini_Caption()
        Dim i As Short
        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP_M", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        fraHeaderInfo.Text = Get_Caption(waScrItm, "fraHeaderInfo")
        tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO0")
        tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO1")

        'not added to insert script
        lblItmCode.Text = Get_Caption(waScrItm, "ITMCODE")
        lblItemClassCode.Text = Get_Caption(waScrItm, "ITEMCLASSCODE")
        lblItmBarCode.Text = Get_Caption(waScrItm, "ITMBARCODE")
        lblItmChiName.Text = Get_Caption(waScrItm, "ITMCHINAME")
        lblItmEngName.Text = Get_Caption(waScrItm, "ITMENGNAME")
        lblItmTypeCode.Text = Get_Caption(waScrItm, "ITMTYPECODE")
        lblItmLastUpd.Text = Get_Caption(waScrItm, "ITMLASTUPD")
        lblItmLastUpdDate.Text = Get_Caption(waScrItm, "ITMLASTUPDDATE")
        lblItmPVdrCode.Text = Get_Caption(waScrItm, "VDRCODE")
        lblItmDiscount.Text = Get_Caption(waScrItm, "ITMDISCOUNT")
        lblItmDefaultPrice.Text = Get_Caption(waScrItm, "ITMDEFAULTPRICE")

        lblItmUomCode.Text = Get_Caption(waScrItm, "ITMUOMCODE")
        lblItmSeriesNo.Text = Get_Caption(waScrItm, "ITMSERIESNO")
        chkItmInActive.Text = Get_Caption(waScrItm, "ITMINACTIVE")
        chkItmInvItemFlg.Text = Get_Caption(waScrItm, "ITMINVITEMFLG")
        chkOwnEdition.Text = Get_Caption(waScrItm, "OWNEDITION")

        lblItmCurrCode.Text = Get_Caption(waScrItm, "ITMCURRCODE")
        lblItmBottomPrice.Text = Get_Caption(waScrItm, "ITMBOTTOMPRICE")
        lblItmMarkUp.Text = Get_Caption(waScrItm, "ITMMARKUP")

        lblItmReorderQty.Text = Get_Caption(waScrItm, "ITMREORDERQTY")
        chkItmReorderInd.Text = Get_Caption(waScrItm, "ITMREORDERIND")
        lblItmMaxQty.Text = Get_Caption(waScrItm, "ITMMAXQTY")
        lblItmPORepuQty.Text = Get_Caption(waScrItm, "ITMPOREPUQTY")

        lblItmAccTypeCode.Text = Get_Caption(waScrItm, "ITMACCTYPECODE")
        lblUnitPrice.Text = Get_Caption(waScrItm, "UNITPRICE")
        lblItmBinNo.Text = Get_Caption(waScrItm, "BINNO")

        With tblDetail
            .Columns(ITMCODE).Caption = Get_Caption(waScrItm, "GDITMCODE")
            .Columns(ITMDESC).Caption = Get_Caption(waScrItm, "GDITMDESC")
            .Columns(QTY).Caption = Get_Caption(waScrItm, "GDQTY")
        End With

        btnItemPrice.Text = Get_Caption(waScrItm, "ITMPRICE")


        lblStkOnHand.Text = Get_Caption(waScrItm, "STKONHAND")
        lblStkIndent.Text = Get_Caption(waScrItm, "STKINDENT")
        lblStkOnOrder.Text = Get_Caption(waScrItm, "STKONORDER")
        lblStkAllocated.Text = Get_Caption(waScrItm, "STKALLOCATED")
        lblStkAvailable.Text = Get_Caption(waScrItm, "STKAVAILABLE")


        tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
        tbrProcess.Items.Item(tcKey).ToolTipText = Get_Caption(waScrToolTip, tcKey) & "(F7)"
        tbrProcess.Items.Item(tcCopy).ToolTipText = Get_Caption(waScrToolTip, tcCopy)


        wsActNam(1) = Get_Caption(waScrItm, "ITMADD")
        wsActNam(2) = Get_Caption(waScrItm, "ITMEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "ITMDELETE")

        lblKeyDesc.Text = Get_Caption(waScrToolTip, "KEYDESC")
        lblComboPrompt.Text = Get_Caption(waScrToolTip, "COMBOPROMPT")
        lblInsertLine.Text = Get_Caption(waScrToolTip, "INSERTLINE")
        lblDeleteLine.Text = Get_Caption(waScrToolTip, "DELETELINE")

        Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub
    Private Sub Ini_Scr()

        Dim MyControl As System.Windows.Forms.Control

        waResult.ReDim(0, -1, ITMCODE, ITMID)
        tblDetail.Array = waResult
        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        For Each MyControl In Me.Controls
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


        wiAction = DefaultPage
        wlKey = 0
        wlVdrID = 0

        Me.txtItmUnitPrice.Text = VB6.Format(0, gsUprFmt)
        Me.txtItmBottomPrice.Text = VB6.Format(0, gsUprFmt)
        Me.txtItmMarkUp.Text = VB6.Format(0, gsUprFmt)
        Me.txtItmReorderQty.Text = CStr(0)
        Me.txtItmMaxQty.Text = CStr(0)
        Me.txtItmPORepuQty.Text = CStr(0)
        Me.txtItmDiscount.Text = VB6.Format(0, gsUprFmt)
        Me.txtItmDefaultPrice.Text = VB6.Format(0, gsUprFmt)

        Call SetFieldStatus("Default")
        Call SetButtonStatus("Default")

        wbAfrKey = False
        Me.tabDetailInfo.SelectedIndex = 0
        Me.Text = wsFormCaption
        tblCommon.Visible = False

    End Sub

    Private Sub Ini_Scr_AfrAct()
        Select Case wiAction
            Case AddRec

                Me.Text = wsFormCaption & " - ADD"
                Call SetFieldStatus("AfrActAdd")
                Call SetButtonStatus("AfrActAdd")
                txtItmCode.Focus()

            Case CorRec

                Me.Text = wsFormCaption & " - EDIT"
                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboITMCODE.Focus()

            Case DelRec

                Me.Text = wsFormCaption & " - DELETE"
                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboITMCODE.Focus()

        End Select

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
    End Sub

    Private Sub Ini_Scr_AfrKey()
        Select Case wiAction
            Case CorRec, DelRec

                If LoadRecord() = False Then
                    gsMsg = "存取檔案失敗! 請聯絡系統管理員或無限系統顧問!"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    Exit Sub
                Else
                    If RowLock(wsConnTime, wsKeyType, cboITMCODE.Text, wsFormID, wsUsrId) = False Then
                        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                End If
                wbAfrKey = True
                Call SetFieldStatus("AfrKey")
                Call SetButtonStatus("AfrKeyEdit")

            Case AddRec
                wbAfrKey = True
                Call SetFieldStatus("AfrKey")
                Call SetButtonStatus("AfrKeyAdd")

        End Select

        txtItmChiName.Focus()
    End Sub

    Private Function Chk_txtItmCode() As Boolean
        Dim wsStatus As String

        Chk_txtItmCode = False

        If Trim(txtItmCode.Text) = "" Then
            Chk_txtItmCode = True
            Exit Function
        End If

        If Chk_ItmCode(txtItmCode.Text, wsStatus) = True Then

            If wsStatus = "2" Then
                gsMsg = "物料已存在但已無效!"
            Else
                gsMsg = "物料已存在!"
            End If

            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtItmCode.Focus()
            Exit Function

        End If

        Chk_txtItmCode = True
    End Function

    Private Function Chk_cboItmCode() As Boolean
        Dim wsStatus As String

        Chk_cboItmCode = False

        If Trim(cboITMCODE.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboITMCODE.Focus()
            Exit Function
        End If

        If Chk_ItmCode(cboITMCODE.Text, wsStatus) = False Then
            gsMsg = "物料不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboITMCODE.Focus()
            Exit Function
        Else
            If wsStatus = "2" Then
                gsMsg = "物料已存在但已無效!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboITMCODE.Focus()
                Exit Function
            End If
        End If

        Chk_cboItmCode = True
    End Function
    Private Sub cmdOpen()

        Dim newForm As New frmITM001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub
    Private Sub cmdNew()

        wiAction = AddRec
        Ini_Scr_AfrAct()

    End Sub
    Private Sub cmdEdit()

        wiAction = CorRec
        Ini_Scr_AfrAct()

    End Sub

    Private Sub cmdDel()

        wiAction = DelRec
        Ini_Scr_AfrAct()

    End Sub
    Private Sub cmdCancel()
        If tbrProcess.Items.Item(tcSave).Enabled = True Then
            Select Case wiAction
                Case AddRec
                    Call Ini_Scr()
                    Call cmdNew()

                Case CorRec
                    Call UnLockAll(wsConnTime, wsFormID)
                    Call Ini_Scr()
                    Call cmdEdit()

                Case DelRec
                    Call UnLockAll(wsConnTime, wsFormID)
                    Call Ini_Scr()
                    Call cmdDel()
            End Select
        Else
            Call Ini_Scr()
        End If
    End Sub
    Private Sub cmdFind()

        Call OpenPromptForm()

    End Sub

    Private Function cmdSave() As Boolean
        Dim wsGenDte As String
        Dim wsNo As String
        Dim adcmdSave As New ADODB.Command
        Dim i As Short
        Dim wiCtr As Short

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = VB6.Format(Today, "YYYY/MM/DD")

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, cboITMCODE.Text, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If wiAction = DelRec Then
            If MsgBox("你是否確定要刪除此檔案?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                cmdCancel()
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        Else
            If InputValidation() = False Then
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        '  If wiAction = AddRec Then
        '      If Chk_KeyExist() = True Then
        '          Call GetNewKey
        '      End If
        '  End If

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_ITM001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wlKey)
        Call SetSPPara(adcmdSave, 3, IIf(wiAction = AddRec, UCase(txtItmCode.Text), UCase(cboITMCODE.Text)))
        Call SetSPPara(adcmdSave, 4, txtItmBarCode.Text)
        Call SetSPPara(adcmdSave, 5, "")
        Call SetSPPara(adcmdSave, 6, "")
        Call SetSPPara(adcmdSave, 7, txtItmChiName)
        Call SetSPPara(adcmdSave, 8, "")
        Call SetSPPara(adcmdSave, 9, "")
        Call SetSPPara(adcmdSave, 10, "")
        Call SetSPPara(adcmdSave, 11, cboItmTypeCode)
        Call SetSPPara(adcmdSave, 12, "")
        Call SetSPPara(adcmdSave, 13, txtItmSeriesNo)
        Call SetSPPara(adcmdSave, 14, "")
        Call SetSPPara(adcmdSave, 15, "")
        Call SetSPPara(adcmdSave, 16, "")
        Call SetSPPara(adcmdSave, 17, "")
        Call SetSPPara(adcmdSave, 18, "")
        Call SetSPPara(adcmdSave, 19, "")
        Call SetSPPara(adcmdSave, 20, gsUserID)
        Call SetSPPara(adcmdSave, 21, wsGenDte)
        Call SetSPPara(adcmdSave, 22, "")
        Call SetSPPara(adcmdSave, 23, "")
        Call SetSPPara(adcmdSave, 24, "")
        Call SetSPPara(adcmdSave, 25, "")
        Call SetSPPara(adcmdSave, 26, "")
        Call SetSPPara(adcmdSave, 27, "")
        Call SetSPPara(adcmdSave, 28, "")
        Call SetSPPara(adcmdSave, 29, "")
        Call SetSPPara(adcmdSave, 30, txtItmBinNo)
        Call SetSPPara(adcmdSave, 31, "")
        Call SetSPPara(adcmdSave, 32, "")
        Call SetSPPara(adcmdSave, 33, "")
        Call SetSPPara(adcmdSave, 34, "")
        Call SetSPPara(adcmdSave, 35, "")
        Call SetSPPara(adcmdSave, 36, 0)
        Call SetSPPara(adcmdSave, 37, 0)
        Call SetSPPara(adcmdSave, 38, 0)
        Call SetSPPara(adcmdSave, 39, 0)
        Call SetSPPara(adcmdSave, 40, 0)
        Call SetSPPara(adcmdSave, 41, 0)
        Call SetSPPara(adcmdSave, 42, 0)
        Call SetSPPara(adcmdSave, 43, cboItmCurr)
        Call SetSPPara(adcmdSave, 44, txtItmDefaultPrice)
        Call SetSPPara(adcmdSave, 45, txtItmBottomPrice)
        Call SetSPPara(adcmdSave, 46, "")
        Call SetSPPara(adcmdSave, 47, cboItmAccTypeCode)
        Call SetSPPara(adcmdSave, 48, Get_CheckValue(chkItmInActive))
        Call SetSPPara(adcmdSave, 49, Get_CheckValue(chkItmInvItemFlg))
        Call SetSPPara(adcmdSave, 50, "N")
        Call SetSPPara(adcmdSave, 51, "N")
        Call SetSPPara(adcmdSave, 52, txtItmReorderQty)

        For i = 0 To 11
            Call SetSPPara(adcmdSave, 53 + i, "")
        Next i

        Call SetSPPara(adcmdSave, 65, Get_CheckValue(chkItmReorderInd))
        Call SetSPPara(adcmdSave, 66, txtItmPORepuQty)
        Call SetSPPara(adcmdSave, 67, "")
        Call SetSPPara(adcmdSave, 68, Get_CheckValue(chkOwnEdition))
        Call SetSPPara(adcmdSave, 69, cboItmUOMCode)
        Call SetSPPara(adcmdSave, 70, txtItmEngName)
        Call SetSPPara(adcmdSave, 71, txtItmMarkUp)
        Call SetSPPara(adcmdSave, 72, txtItmMaxQty)
        Call SetSPPara(adcmdSave, 73, txtItmUnitPrice)
        Call SetSPPara(adcmdSave, 74, txtItmDiscount)
        Call SetSPPara(adcmdSave, 75, cboItemClassCode)
        Call SetSPPara(adcmdSave, 76, wlVdrID)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 77)

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_ITM001B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 4, waResult.get_Value(wiCtr, ITMID))
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, QTY))
                    Call SetSPPara(adcmdSave, 6, gsUserID)
                    Call SetSPPara(adcmdSave, 7, wsGenDte)
                    adcmdSave.Execute()
                End If
            Next
        End If

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - ITM001!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        Else
            If wiAction = DelRec Then
                gsMsg = "已成功刪除!"
            Else
                gsMsg = "已成功儲存!"
            End If
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
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



    Private Function SaveData() As Boolean

        Dim wiRet As Integer

        SaveData = False

        If (wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec) And tbrProcess.Items.Item(tcSave).Enabled = True Then
            If MsgBox("你是否確定要儲存現時之作業?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                Exit Function
            Else
                If cmdSave = True Then
                    Exit Function
                End If
            End If
            SaveData = True
        Else
            SaveData = False
        End If

    End Function



    Private Sub OpenPromptForm()
        Dim wsOutCode As String
        Dim wsSQL As String

        Dim vFilterAry(3, 2) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 1) = "物料編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 2) = "ItmCode"

        If gsLangID = "1" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vFilterAry(2, 1) = "物料英文名稱"
            'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vFilterAry(2, 2) = "ItmEngName"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vFilterAry(2, 1) = "物料名稱"
            'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vFilterAry(2, 2) = "ItmChiName"
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "物料分類"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "ItmItmTypeCode"


        Dim vAry(3, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "物料編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "ItmCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "2500"


        If gsLangID = "1" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vAry(2, 1) = "物料英文名稱"
            'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vAry(2, 2) = "ItmEngName"
            'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vAry(2, 3) = "3500"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vAry(2, 1) = "物料名稱"
            'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vAry(2, 2) = "ItmChiName"
            'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vAry(2, 3) = "3500"
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 1) = "物料分類"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 2) = "ItmItmTypeCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 3) = "1200"





        'frmShareSearch.Show vbModal

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            wsSQL = "SELECT MstItem.ItmCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & ", MstItem.ItmItmTypeCode "
            wsSQL = wsSQL & "FROM MstItem "
            .sBindSQL = wsSQL
            .sBindWhereSQL = "WHERE MstItem.ItmStatus = '1' "
            .sBindOrderSQL = "ORDER BY MstItem.ItmCode"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmITM001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
        If Trim(frmShareSearch.Tag) <> "" And frmShareSearch.Tag <> cboITMCODE.Text Then
            cboITMCODE.Text = frmShareSearch.Tag
            If cboITMCODE.Enabled = False Then
                LoadRecord()
                txtItmBarCode.Text = ""
                txtItmCode.Focus()
            Else
                cboITMCODE.Focus()
                System.Windows.Forms.SendKeys.Send("{Enter}")
            End If
        End If
        frmShareSearch.Close()


    End Sub

    Private Sub txtItmBarCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmBarCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtItmBarCode, 13, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtItmSeriesNo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmBarCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmBarCode.Leave
        FocusMe(txtItmBarCode, True)
    End Sub

    Private Sub txtItmBinNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmBinNo.Enter
        FocusMe(txtItmBinNo)
    End Sub

    Private Sub txtItmBinNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmBinNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtItmBinNo, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 0
            cboItmAccTypeCode.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmBinNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmBinNo.Leave
        FocusMe(txtItmBinNo, True)
    End Sub



    Private Sub txtItmChiName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmChiName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtItmChiName, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtItmChiName() = True Then
                txtItmEngName.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmChiName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmChiName.Leave
        FocusMe(txtItmChiName, True)
    End Sub

    Private Sub txtItmCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        '    Call chk_InpLenA(txtItmCode, 30, KeyAscii, True)
        Call chk_InpLenC(txtItmCode, 30, KeyAscii, True, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtItmCode() = True Then
                cboItemClassCode.Focus()
                'Call Ini_Scr_AfrKey
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmCode.Leave
        FocusMe(txtItmCode, True)
    End Sub

    Private Sub txtItmDefaultPrice_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDefaultPrice.Enter
        FocusMe(txtItmDefaultPrice)
    End Sub

    Private Sub txtItmDefaultPrice_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmDefaultPrice.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmDefaultPrice.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Select Case UCase(cboItemClassCode.Text)
                Case "P"
                    tabDetailInfo.SelectedIndex = 1
                    chkItmInActive.Focus()

                Case "N"
                    txtItmChiName.Focus()

                Case "D"
                    txtItmChiName.Focus()

                Case "S"
                    txtItmChiName.Focus()

                Case "L"
                    txtItmChiName.Focus()

                Case "A"
                    tabDetailInfo.SelectedIndex = 2
                    tblDetail.Focus()

                Case "T"
                    txtItmChiName.Focus()

                Case "C"
                    txtItmChiName.Focus()

            End Select
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmDefaultPrice_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDefaultPrice.Leave
        txtItmDefaultPrice.Text = VB6.Format(txtItmDefaultPrice.Text, gsUprFmt)
        FocusMe(txtItmDefaultPrice)
    End Sub



    'UPGRADE_WARNING: Event txtItmDiscount.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtItmDiscount_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDiscount.TextChanged
        Call Calc_Price()
    End Sub

    'UPGRADE_WARNING: Event txtItmMarkUp.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtItmMarkUp_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmMarkUp.TextChanged
        Call Calc_Price()
    End Sub

    Private Sub txtItmUnitPrice_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmUnitPrice.Enter
        FocusMe(txtItmUnitPrice)
    End Sub

    Private Sub txtItmUnitPrice_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmUnitPrice.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmUnitPrice.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call Calc_Price()

            tabDetailInfo.SelectedIndex = 0
            txtItmDiscount.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmUnitPrice_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmUnitPrice.Leave
        txtItmUnitPrice.Text = VB6.Format(txtItmUnitPrice.Text, gsUprFmt)
        FocusMe(txtItmUnitPrice, True)
    End Sub

    Private Sub txtItmDiscount_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDiscount.Enter
        FocusMe(txtItmDiscount)
    End Sub

    Private Sub txtItmDiscount_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmDiscount.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmDiscount.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            If Chk_txtItmDiscount = False Then GoTo EventExitSub
            Call Calc_Price()

            tabDetailInfo.SelectedIndex = 0
            txtItmBottomPrice.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmDiscount_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDiscount.Leave
        txtItmDiscount.Text = VB6.Format(txtItmDiscount.Text, gsUprFmt)
        FocusMe(txtItmDiscount, True)
    End Sub

    Private Sub txtItmEngName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmEngName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtItmEngName, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Select Case UCase(cboItemClassCode.Text)
                Case "P"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

                Case "N"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

                Case "D"
                    txtItmChiName.Focus()

                Case "S"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

                Case "L"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

                Case "A"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

                Case "T"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

                Case "C"
                    tabDetailInfo.SelectedIndex = 0
                    cboItmTypeCode.Focus()

            End Select
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmEngName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmEngName.Leave
        FocusMe(txtItmEngName, True)
    End Sub

    Private Sub txtItmReorderQty_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmReorderQty.Enter
        FocusMe(txtItmReorderQty)
    End Sub

    Private Sub txtItmReorderQty_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmReorderQty.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmReorderQty.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 1
            txtItmMaxQty.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmReorderQty_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmReorderQty.Leave
        txtItmReorderQty.Text = VB6.Format(txtItmReorderQty.Text, gsQtyFmt)
        FocusMe(txtItmReorderQty, True)
    End Sub

    Private Sub txtItmMaxQty_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmMaxQty.Enter
        FocusMe(txtItmMaxQty)
    End Sub

    Private Sub txtItmMaxQty_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmMaxQty.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmMaxQty.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 1
            txtItmPORepuQty.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmMaxQty_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmMaxQty.Leave
        txtItmMaxQty.Text = VB6.Format(txtItmMaxQty.Text, gsQtyFmt)
        FocusMe(txtItmMaxQty, True)
    End Sub

    Private Sub txtItmPORepuQty_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmPORepuQty.Enter
        FocusMe(txtItmPORepuQty)
    End Sub

    Private Sub txtItmPORepuQty_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmPORepuQty.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmPORepuQty.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Select Case UCase(cboItemClassCode.Text)
                Case "P"
                    tabDetailInfo.SelectedIndex = 0
                    txtItmChiName.Focus()

                Case "N"
                    txtItmChiName.Focus()

                Case "D"
                    txtItmChiName.Focus()

                Case "S"
                    txtItmChiName.Focus()

                Case "L"
                    txtItmChiName.Focus()

                Case "A"
                    tabDetailInfo.SelectedIndex = 2
                    tblDetail.Focus()

                Case "T"
                    txtItmChiName.Focus()

                Case "C"
                    txtItmChiName.Focus()

            End Select
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmPORepuQty_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmPORepuQty.Leave
        txtItmPORepuQty.Text = VB6.Format(txtItmPORepuQty.Text, gsQtyFmt)
        FocusMe(txtItmPORepuQty, True)
    End Sub

    Private Sub txtItmSeriesNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmSeriesNo.Enter
        FocusMe(txtItmSeriesNo)
    End Sub

    Private Sub txtItmSeriesNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmSeriesNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtItmSeriesNo, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 0
            txtItmBinNo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmSeriesNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmSeriesNo.Leave
        FocusMe(txtItmSeriesNo, True)
    End Sub

    Private Sub txtItmBarCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmBarCode.Enter
        FocusMe(txtItmBarCode)
    End Sub

    Private Sub txtItmBottomPrice_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmBottomPrice.Enter
        FocusMe(txtItmBottomPrice)
    End Sub

    Private Sub txtItmBottomPrice_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmBottomPrice.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmBottomPrice.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 0
            txtItmMarkUp.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmBottomPrice_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmBottomPrice.Leave
        txtItmBottomPrice.Text = VB6.Format(txtItmBottomPrice.Text, gsUprFmt)
        FocusMe(txtItmBottomPrice, True)
    End Sub


    Private Sub txtItmMarkUp_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmMarkUp.Enter
        FocusMe(txtItmMarkUp)
    End Sub

    Private Sub txtItmMarkUp_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmMarkUp.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtItmMarkUp.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call Calc_Price()

            tabDetailInfo.SelectedIndex = 0
            txtItmDefaultPrice.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmMarkUp_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmMarkUp.Leave
        txtItmMarkUp.Text = VB6.Format(txtItmMarkUp.Text, gsUprFmt)
        FocusMe(txtItmMarkUp, True)
    End Sub
    Private Sub txtItmChiName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmChiName.Enter
        FocusMe(txtItmChiName)
    End Sub

    Private Sub txtItmCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmCode.Enter
        FocusMe(txtItmCode)
    End Sub

    Private Sub txtItmEngName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmEngName.Enter
        FocusMe(txtItmEngName)
    End Sub


    Private Function Chk_ItmCurr() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_ItmCurr = False

        sSQL = "SELECT ExcCurr FROM MstExchangeRate WHERE ExcCurr='" & Set_Quote(cboItmCurr.Text) & "' And ExcStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        Chk_ItmCurr = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboItmCurr() As Boolean

        Chk_cboItmCurr = False

        If UCase(cboItemClassCode.Text) = "D" Then
            Chk_cboItmCurr = True
            Exit Function
        End If

        If Trim(cboItmCurr.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            Me.tabDetailInfo.SelectedIndex = 0
            cboItmCurr.Focus()
            Exit Function
        End If

        If Chk_ItmCurr() = False Then
            gsMsg = "貨幣不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboItmCurr.Focus()
            Exit Function
        End If


        Chk_cboItmCurr = True
    End Function


    Private Function Chk_cboItmTypeCode() As Boolean
        Dim wsRetName As String

        wsRetName = ""

        If UCase(cboItemClassCode.Text) = "D" Then
            Chk_cboItmTypeCode = True
            Exit Function
        End If


        Chk_cboItmTypeCode = False

        If Trim(cboItmTypeCode.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboItmTypeCode.Focus()
            Exit Function
        End If

        If Chk_ItmTypeCode(cboItmTypeCode.Text, wsRetName) = False Then
            lblDspItmTypeDesc.Text = ""
            gsMsg = "物料類別編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboItmTypeCode.Focus()
            Exit Function
        Else
            lblDspItmTypeDesc.Text = wsRetName
        End If


        Chk_cboItmTypeCode = True

    End Function

    Private Function Chk_ItmTypeCode(ByVal inCode As String, ByRef OutName As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_ItmTypeCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT ItmTypeChiDesc "
        wsSQL = wsSQL & " FROM MstItemType WHERE MstItemType.ItmTypeCode = '" & Set_Quote(inCode) & "'  And ItmTypeStatus = '1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsRcd, "ItmTypeChiDesc")
        Else
            OutName = ""
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        Chk_ItmTypeCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_ItmUOMCode(ByVal inCode As String, ByRef OutName As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_ItmUOMCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT UomDesc "
        wsSQL = wsSQL & " FROM MstUOM WHERE MstUOM.UomCode = '" & Set_Quote(inCode) & "' And UomStatus = '1' "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsRcd, "UomDesc")
        Else
            OutName = ""
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        Chk_ItmUOMCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function


    Private Function Chk_cboItmUOMCode() As Boolean
        Dim wsRetName As String

        wsRetName = ""

        Chk_cboItmUOMCode = False

        If UCase(cboItemClassCode.Text) = "D" Then
            Chk_cboItmUOMCode = True
            Exit Function
        End If

        If Trim(cboItmUOMCode.Text) = "" Then
            Chk_cboItmUOMCode = True
            Exit Function
        End If

        If Chk_ItmUOMCode(cboItmUOMCode.Text, wsRetName) = False Then
            gsMsg = "量度單位編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboItmUOMCode.Focus()
            Exit Function
        Else
            lblDspItmUomDesc.Text = wsRetName
        End If


        Chk_cboItmUOMCode = True
    End Function


    Private Function Chk_txtItmEngName() As Boolean
        Chk_txtItmEngName = False

        If Trim(txtItmEngName.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtItmEngName.Focus()
            Exit Function
        End If

        Chk_txtItmEngName = True
    End Function

    Private Function Chk_txtItmChiName() As Boolean

        Chk_txtItmChiName = False

        If Trim(txtItmChiName.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtItmChiName.Focus()
            Exit Function
        End If

        Chk_txtItmChiName = True
    End Function

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
            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
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

    Private Sub cboItmCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboITMCODE, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboItmCode() = False Then
                GoTo EventExitSub
            Else
                'Call Chk_KeyFld
                Call Ini_Scr_AfrKey()
                'cboItemClassCode.SetFocus
            End If
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

        If gsLangID = "1" Then
            wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmEngName FROM MstItem WHERE ItmStatus = '1'"
            wsSQL = wsSQL & " AND ItmCode LIKE '%" & IIf(cboITMCODE.SelectionLength > 0, "", Set_Quote(cboITMCODE.Text)) & "%' "
            wsSQL = wsSQL & " AND ItmClass LIKE '%" & IIf(cboItemClassCode.SelectionLength > 0, "", Set_Quote(cboItemClassCode.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItmCode "
        Else
            wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmChiName FROM MstItem WHERE ItmStatus = '1'"
            wsSQL = wsSQL & " AND ItmCode LIKE '%" & IIf(cboITMCODE.SelectionLength > 0, "", Set_Quote(cboITMCODE.Text)) & "%' "
            wsSQL = wsSQL & " AND ItmClass LIKE '%" & IIf(cboItemClassCode.SelectionLength > 0, "", Set_Quote(cboItemClassCode.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItmCode "
        End If

        Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboITMCODE.Left)), VB6.PixelsToTwipsY(cboITMCODE.Top) + VB6.PixelsToTwipsY(cboITMCODE.Height), tblCommon, wsFormID, "TBLB", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboItmCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Enter

        FocusMe(cboITMCODE)
    End Sub

    Private Sub cboItmCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCode.Leave
        FocusMe(cboITMCODE, True)
    End Sub

    Private Sub cboItmTypeCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCode.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


        If wbAfrKey = False Then

            wcCombo = cboITMCODE

            If gsLangID = "1" Then

                wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmEngName FROM MstItem WHERE ItmStatus = '1'"
                wsSQL = wsSQL & " AND ItmItmTypeCode LIKE '%" & IIf(cboItmTypeCode.SelectionLength > 0, "", Set_Quote(cboItmTypeCode.Text)) & "%' "
                wsSQL = wsSQL & "ORDER BY ItmItmTypeCode "

            Else

                wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmChiName FROM MstItem WHERE ItmStatus = '1'"
                wsSQL = wsSQL & " AND ItmItmTypeCode LIKE '%" & IIf(cboItmTypeCode.SelectionLength > 0, "", Set_Quote(cboItmTypeCode.Text)) & "%' "
                wsSQL = wsSQL & "ORDER BY ItmItmTypeCode "

            End If

            Call Ini_Combo(3, wsSQL, VB6.PixelsToTwipsX(cboItmTypeCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboItmTypeCode.Top) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(cboItmTypeCode.Height), tblCommon, wsFormID, "TBLB", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))


        Else

            wcCombo = cboItmTypeCode

            If gsLangID = "1" Then
                wsSQL = "SELECT ItmTypeCode, ItmTypeEngDesc FROM MstItemType WHERE ItmTypeStatus = '1'"
                wsSQL = wsSQL & "ORDER BY ItmTypeCode "
            Else
                wsSQL = "SELECT ItmTypeCode, ItmTypeChiDesc FROM MstItemType WHERE ItmTypeStatus = '1'"
                wsSQL = wsSQL & "ORDER BY ItmTypeCode "
            End If

            Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboItmTypeCode.Left) + VB6.PixelsToTwipsX(Me.tabDetailInfo.Left), VB6.PixelsToTwipsY(cboItmTypeCode.Top) + VB6.PixelsToTwipsY(cboItmTypeCode.Height) + VB6.PixelsToTwipsY(Me.tabDetailInfo.Top), tblCommon, wsFormID, "TBLIT", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        End If



        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmTypeCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmTypeCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            'If wbAfrKey = False Then
            '   cboItmCode.SetFocus
            '   Exit Sub
            'End If

            If Chk_cboItmTypeCode() = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0
            cboItmUOMCode.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmTypeCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCode.Enter

        FocusMe(cboItmTypeCode)
    End Sub

    Private Sub cboItmTypeCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCode.Leave
        FocusMe(cboItmTypeCode, True)
    End Sub


    Private Sub cboItmCurr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCurr.DropDown

        Dim wsSQL As String


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCurr

        wsSQL = "SELECT DISTINCT ExcCurr FROM MstExchangeRate WHERE ExcStatus = '1'"
        wsSQL = wsSQL & "ORDER BY ExcCurr "
        Call Ini_Combo(1, wsSQL, VB6.PixelsToTwipsX(cboItmCurr.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboItmCurr.Top) + VB6.PixelsToTwipsY(cboItmCurr.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLCURR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboItmCurr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCurr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmCurr, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboItmCurr() = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0

            cboItmPVdrCode.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmCurr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCurr.Enter
        FocusMe(cboItmCurr)
    End Sub

    Private Sub cboItmCurr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCurr.Leave
        FocusMe(cboItmCurr, True)
    End Sub


    Private Function Chk_KeyExist() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT ItmStatus FROM MstItem WHERE ItmCode = '" & Set_Quote(txtItmCode.Text) & "'"
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

    Private Sub GetNewKey()
        Dim Newfrm As New frmKeyInput

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Create Selection wsSql
        With Newfrm
            .TableID = wsKeyType
            .TableType = wsTrnCd
            .TableKey = "ItmCode"
            .KeyLen = 15
            .ctlKey = txtItmCode
            .ShowDialog()
        End With

        'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Newfrm = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboItmAccTypeCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmAccTypeCode

        wsSQL = "SELECT AccTypeCode, AccTypeDesc FROM MstAccountType WHERE AccTypeStatus = '1'"
        wsSQL = wsSQL & "ORDER BY AccTypeCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboItmAccTypeCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboItmAccTypeCode.Top) + VB6.PixelsToTwipsY(cboItmAccTypeCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLACCTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboItmAccTypeCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmAccTypeCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmAccTypeCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboItmAccTypeCode() = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0
            cboItmCurr.Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmAccTypeCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCode.Enter
        FocusMe(cboItmAccTypeCode)
    End Sub

    Private Sub cboItmAccTypeCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmAccTypeCode.Leave
        FocusMe(cboItmAccTypeCode, True)
    End Sub

    Private Function Chk_cboItmAccTypeCode() As Boolean
        Dim wsDesc As String
        Chk_cboItmAccTypeCode = False

        If UCase(cboItemClassCode.Text) = "D" Then
            Chk_cboItmAccTypeCode = True
            Exit Function
        End If

        '   If Trim(cboItmAccTypeCode.Text) = "" Then
        '       Chk_cboItmAccTypeCode = True
        '       Exit Function
        '   End If

        If Chk_ItmAccTypeCode(wsDesc) = False Then
            gsMsg = "會計分類不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboItmAccTypeCode.Focus()
            Exit Function
        End If

        lblDspItmAccTypeDesc.Text = wsDesc
        Chk_cboItmAccTypeCode = True
    End Function

    Private Function Chk_ItmAccTypeCode(ByRef OutDesc As String) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        Chk_ItmAccTypeCode = False

        OutDesc = ""
        sSQL = "SELECT AccTypeCode, AccTypeDesc FROM MstAccountType WHERE MstAccountType.AccTypeCode = '" & Set_Quote(cboItmAccTypeCode.Text) & "' And AccTypeStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then

            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        OutDesc = ReadRs(rsRcd, "AccTypeDesc")
        Chk_ItmAccTypeCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub LoadForm(ByRef f As System.Windows.Forms.Form)
        f.WindowState = System.Windows.Forms.FormWindowState.Normal
        f.SetBounds(0, 0, VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width)), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.ClientRectangle.Height)))
        f.Show()
        'UPGRADE_WARNING: Form method f.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        f.BringToFront()

    End Sub

    Private Sub cboItemClassCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemClassCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItemClassCode

        If gsLangID = "1" Then
            wsSQL = "SELECT ItemClassCode, ItemClassEDesc FROM MstItemClass WHERE ItemClassCode LIKE '%" & IIf(cboItemClassCode.SelectionLength > 0, "", Set_Quote(cboItemClassCode.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItemClassCode "
        Else
            wsSQL = "SELECT ItemClassCode, ItemClassCDesc FROM MstItemClass WHERE ItemClassCode LIKE '%" & IIf(cboItemClassCode.SelectionLength > 0, "", Set_Quote(cboItemClassCode.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItemClassCode "
        End If

        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItemClassCode.Left)), VB6.PixelsToTwipsY(cboItemClassCode.Top) + VB6.PixelsToTwipsY(cboItemClassCode.Height), tblCommon, wsFormID, "TBLITEMCLASS", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboItemClassCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItemClassCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItemClassCode, 1, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboItemClassCode() = False Then
                GoTo EventExitSub
            End If
            'Call Chk_KeyFld
            'txtItmChiName.SetFocus
            If wiAction = AddRec Then
                Call Ini_Scr_AfrKey()
            Else
                ' cboItmCode.SetFocus
                txtItmChiName.Focus()
            End If
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItemClassCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemClassCode.Enter
        FocusMe(cboItemClassCode)
    End Sub

    Private Sub cboItemClassCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItemClassCode.Leave
        FocusMe(cboItemClassCode, True)
    End Sub

    Private Function Chk_cboItemClassCode() As Boolean
        Dim wsRetName As String

        wsRetName = ""

        Chk_cboItemClassCode = False

        If Trim(cboItemClassCode.Text) = "" Then
            If wiAction = AddRec Then
                gsMsg = "沒有輸入須要之資料!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboItemClassCode.Focus()
                Exit Function
            Else
                lblDspItemClassCode.Text = ""
                Chk_cboItemClassCode = True
                Exit Function
            End If
        End If

        If Chk_ItemClassCode(cboItemClassCode.Text, wsRetName) = False Then
            lblDspItemClassCode.Text = ""
            gsMsg = "物料分類編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboItemClassCode.Focus()
            Exit Function
        Else
            lblDspItemClassCode.Text = wsRetName
        End If

        Chk_cboItemClassCode = True

    End Function

    Private Function Chk_ItemClassCode(ByVal inCode As String, ByRef OutName As String) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_ItemClassCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        If gsLangID = "1" Then
            wsSQL = "SELECT ItemClassEDesc ItemClassDesc "
            wsSQL = wsSQL & " FROM MstItemClass WHERE MstItemClass.ItemClassCode = '" & Set_Quote(inCode) & "' "
        Else
            wsSQL = "SELECT ItemClassCDesc ItemClassDesc "
            wsSQL = wsSQL & " FROM MstItemClass WHERE MstItemClass.ItemClassCode = '" & Set_Quote(inCode) & "' "
        End If

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsRcd, "ItemClassDesc")
        Else
            OutName = ""
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        Chk_ItemClassCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_KeyFld() As Boolean
        Chk_KeyFld = False

        If Chk_cboItmCode = False Then
            Exit Function
        End If

        If Chk_cboItemClassCode = False Then
            Exit Function
        End If

        Call Ini_Scr_AfrKey()
        Chk_KeyFld = True
    End Function

    Private Function chk_cboVdrCode() As Boolean
        chk_cboVdrCode = False

        If UCase(cboItemClassCode.Text) = "D" Then
            chk_cboVdrCode = True
            Exit Function
        End If

        If Trim(cboItmPVdrCode.Text) = "" Then
            chk_cboVdrCode = True
            Exit Function
        End If

        If Chk_VdrCode(cboItmPVdrCode.Text, wlVdrID, "", "", "") = False Then
            gsMsg = "供應商編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboItmPVdrCode.Focus()
            Exit Function
        End If

        chk_cboVdrCode = True
    End Function

    Private Sub Calc_Price()
        txtItmBottomPrice.Text = VB6.Format(To_Value(txtItmUnitPrice) * To_Value(txtItmDiscount), gsUprFmt)
        txtItmDefaultPrice.Text = VB6.Format(To_Value(txtItmBottomPrice) * To_Value(txtItmMarkUp), gsUprFmt)

    End Sub


    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        Dim sTemp As String

        With tblDetail
            sTemp = .Columns(eventArgs.ColIndex).Text
            'UPGRADE_NOTE: UPDATE was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub

    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsITMCODE As String
        Dim wsItmDesc As String
        Dim wsITMID As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case ITMCODE
                    'If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                    '    GoTo Tbl_BeforeColUpdate_Err
                    'End If

                    If Chk_grdITMCODE((.Columns(eventArgs.ColIndex).Text), wsITMCODE, wsItmDesc, wsITMID) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(ITMCODE).Text = wsITMCODE
                    .Columns(ITMDESC).Text = wsItmDesc
                    .Columns(QTY).Text = CStr(0)
                    .Columns(ITMID).Text = wsITMID

                    If Trim(.Columns(eventArgs.ColIndex).Text) <> wsITMCODE Then
                        .Columns(eventArgs.ColIndex).Text = wsITMCODE
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
		Dim sEndCode As String
		
		On Error GoTo tblDetail_ButtonClick_Err
		
		If wiAction = AddRec Then
			sEndCode = "', '" & txtItmCode.Text & "' )"
		Else
			sEndCode = "', '" & cboITMCODE.Text & "' )"
		End If
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case ITMCODE
					If CDbl(gsLangID) = 1 Then
						wsSQL = "SELECT ITMCODE, ITMENGNAME FROM MSTITEM "
						wsSQL = wsSQL & " WHERE ITMSTATUS = '1' AND ITMCLASS = 'P' AND ITMINACTIVE = 'N' AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
						If waResult.get_UpperBound(1) > -1 Then
							wsSQL = wsSQL & " AND ITMCODE NOT IN ( "
							For wiCtr = 0 To waResult.get_UpperBound(1)
								wsSQL = wsSQL & " '" & Set_Quote(waResult.get_Value(wiCtr, ITMCODE)) & IIf(wiCtr = waResult.get_UpperBound(1), sEndCode, "' ,")
							Next 
						Else
							If wiAction = AddRec Then
								wsSQL = wsSQL & " AND ITMCODE <> '" & txtItmCode.Text & "' "
							Else
								wsSQL = wsSQL & " AND ITMCODE <> '" & cboITMCODE.Text & "' "
							End If
						End If
						wsSQL = wsSQL & " ORDER BY ITMCODE "
					Else
						wsSQL = "SELECT ITMCODE, ITMCHINAME FROM MSTITEM "
						wsSQL = wsSQL & " WHERE ITMSTATUS = '1' AND ITMCLASS = 'P' AND ITMINACTIVE = 'N' AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
						If waResult.get_UpperBound(1) > -1 Then
							wsSQL = wsSQL & " AND ITMCODE NOT IN ( "
							For wiCtr = 0 To waResult.get_UpperBound(1)
								wsSQL = wsSQL & " '" & Set_Quote(waResult.get_Value(wiCtr, ITMCODE)) & IIf(wiCtr = waResult.get_UpperBound(1), sEndCode, "' ,")
							Next 
						Else
							If wiAction = AddRec Then
								wsSQL = wsSQL & " AND ITMCODE <> '" & txtItmCode.Text & "' "
							Else
								wsSQL = wsSQL & " AND ITMCODE <> '" & cboITMCODE.Text & "' "
							End If
						End If
						wsSQL = wsSQL & " ORDER BY ITMCODE "
					End If
					
					Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLB", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
					tblCommon.Visible = True
					tblCommon.Focus()
					wcCombo = tblDetail
					
					'  Case WhsCode
					
					'      wsSql = "SELECT WHSCODE, WHSDESC FROM mstWareHouse "
					'      wsSql = wsSql & " WHERE WHSSTATUS <> '2' AND WHSCODE LIKE '%" & Set_Quote(.Columns(WhsCode).Text) & "%' "
					'      wsSql = wsSql & " ORDER BY WHSCODE "
					
					'      Call Ini_Combo(2, wsSql, .Columns(ColIndex).Left + .Left + .Columns(ColIndex).Top, .Top + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLWHSCODE", Me.Width, Me.Height)
					'      tblCommon.Visible = True
					'      tblCommon.SetFocus
					'      Set wcCombo = tblDetail
					
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
						Case ITMDESC, QTY
							.Col = .Col - 1
					End Select
					
				Case System.Windows.Forms.Keys.Right
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
					Select Case .Col
						Case ITMCODE, ITMDESC
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
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
				Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, False)
				
				'Case Price, DisPer
				'    Call Chk_InpNum(KeyAscii, tblDetail.Text, False, True)
				
				
		End Select
		
	End Sub
	
	Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
		wbErr = False
		On Error GoTo RowColChange_Err
		
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If ActiveControl.Name <> tblDetail.Name Then Exit Sub
		
		With tblDetail
			If IsEmptyRow() Then
				.Col = ITMCODE
			End If
			
			'Call Calc_Total
			
			If Trim(.Columns(.Col).Text) <> "" Then
				Select Case .Col
					Case ITMCODE
						Call Chk_grdITMCODE((.Columns(ITMCODE).Text), "", "", "")
						'Case UNIT
						'    Call Chk_grdQty(.Columns(UNIT).Text)
						
				End Select
			End If
		End With
		
		Exit Sub
		
RowColChange_Err: 
		
		MsgBox("Check tblDeiail RowColChange")
		wbErr = True
		
	End Sub
	
	Private Function Chk_grdITMCODE(ByRef inAccNo As String, ByRef outAccNo As String, ByRef outAccDesc As String, ByRef OutID As String) As Boolean
		Dim wsSQL As String
		Dim rsDes As New ADODB.Recordset
		Dim wsCurr As String
		Dim wsExcr As String
		Dim wdPrice As Double
		
		If Trim(inAccNo) = "" Then
			gsMsg = "沒有輸入物料號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdITMCODE = False
			Exit Function
		End If
		
		If gsLangID = "1" Then
			wsSQL = "SELECT ITMID, ITMCODE, ITMENGNAME ITMDESC FROM MstItem"
			wsSQL = wsSQL & " WHERE (ITMCODE = '" & Set_Quote(inAccNo) & "') AND ITMCLASS = 'P' AND ITMINACTIVE = 'N' "
		Else
			wsSQL = "SELECT ITMID, ITMCODE, ITMCHINAME ITMDESC FROM MstItem"
			wsSQL = wsSQL & " WHERE (ITMCODE = '" & Set_Quote(inAccNo) & "') AND ITMCLASS = 'P' AND ITMINACTIVE = 'N' "
		End If
		
		rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsDes.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			outAccNo = ReadRs(rsDes, "ITMCODE")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			outAccDesc = ReadRs(rsDes, "ITMDESC")
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutID = ReadRs(rsDes, "ITMID")
			
			Chk_grdITMCODE = True
		Else
			outAccDesc = ""
			OutID = CStr(0)
			
			gsMsg = "沒有此物料!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdITMCODE = False
		End If
		rsDes.Close()
		'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDes = Nothing
		
	End Function
	
	Private Function Chk_grdQty(ByRef inCode As String) As Boolean
		
		Chk_grdQty = True
		
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
				If Trim(.Columns(ITMCODE).Text) = "" Then
					Exit Function
				End If
			End With
		Else
			If waResult.get_UpperBound(1) >= 0 Then
				If Trim(waResult.get_Value(inRow, ITMCODE)) = "" And Trim(waResult.get_Value(inRow, ITMDESC)) = "" And Trim(waResult.get_Value(inRow, QTY)) = "" And Trim(waResult.get_Value(inRow, ITMID)) = "" Then
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
			
			If Chk_grdITMCODE(waResult.get_Value(LastRow, ITMCODE), "", "", "") = False Then
				.Col = ITMCODE
				.Row = LastRow
				Exit Function
			End If
			
			'If Chk_grdWhsCode(waResult(LastRow, WHSCODE)) = False Then
			'        .Col = WHSCODE
			'        .Row = LastRow
			'        Exit Function
			'End If
			
			'If Chk_grdWantedDate(waResult(LastRow, WANTED)) = False Then
			'        .Col = WANTED
			'        .Row = LastRow
			'        Exit Function
			'End If
			
			'If Chk_grdQty(waResult(LastRow, Qty)) = False Then
			'        .Col = Qty
			'        .Row = LastRow
			'        Exit Function
			'End If
			
			'If Chk_grdDisPer(waResult(LastRow, DisPer)) = False Then
			'        .Col = DisPer
			'        .Row = LastRow
			'        Exit Function
			'End If
			
			'If Chk_Amount(waResult(LastRow, Amt)) = False Then
			'    .Col = Amt
			'    .Row = LastRow
			'    Exit Function
			'End If
			
			
			
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
	
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
			
			For wiCtr = ITMCODE To ITMID
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = False
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case ITMCODE
						.Columns(wiCtr).Width = 2000
						.Columns(wiCtr).DataWidth = 30
						.Columns(wiCtr).Button = True
					Case ITMDESC
						.Columns(wiCtr).Width = 5000
						.Columns(wiCtr).DataWidth = 60
						.Columns(wiCtr).Locked = True
					Case QTY
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
					Case ITMID
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Visible = False
				End Select
			Next 
			'  .Styles("EvenRow").BackColor = &H8000000F
		End With
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
	
	Private Sub cmdChangeKey(ByVal wiAct As Short)
		Dim Newfrm As New frmChangeKey
		Dim outResult As Boolean
		Dim wsNew As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection wsSql
		With Newfrm
			.KeyID = wlKey
			.KeyType = cboItemClassCode.Text
			' Set .ctlKey = txtItmCode
			.ShowDialog()
			outResult = .Result
			wsNew = .NewKey
			
		End With
		
		'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Newfrm = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		If outResult = True Then
			wiAction = wiAct
			If wiAction = AddRec Then
				txtItmCode.Text = wsNew
			Else
				Call UnLockAll(wsConnTime, wsFormID)
				cboITMCODE.Text = wsNew
                If UCase(cboItemClassCode.Text) = "T" Then cboItemClassCode.Text = "P"
				If RowLock(wsConnTime, wsKeyType, cboITMCODE.Text, wsFormID, wsUsrId) = False Then
					gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
					MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
					Exit Sub
				End If
			End If
			Call cmdSave()
			
		End If
	End Sub
	
	Private Function Chk_txtItmDiscount() As Boolean
		
		Chk_txtItmDiscount = False
		
		If UCase(cboItemClassCode.Text) = "D" Then
			Chk_txtItmDiscount = True
			Exit Function
		End If
		
		If To_Value((txtItmDiscount.Text)) = 0 Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			Me.tabDetailInfo.SelectedIndex = 0
			txtItmDiscount.Focus()
			Exit Function
		End If
		
		Chk_txtItmDiscount = True
		
	End Function
End Class