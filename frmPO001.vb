Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmPO001
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
	
	Private wsOldDelCd As String
	Private wsOldShipCd(2) As String
	
	Private wbReadOnly As Boolean
	Private wgsTitle As String
	
	Private Const LINENO As Short = 0
	Private Const SOID As Short = 1
	Private Const ITMTYPE As Short = 2
	Private Const ITMCODE As Short = 3
	Private Const WHSCODE As Short = 4
	Private Const LOTNO As Short = 5
	Private Const ITMNAME As Short = 6
	Private Const GMORE As Short = 7
	Private Const WANTED As Short = 8
	Private Const PUBLISHER As Short = 9
	Private Const QTY As Short = 10
	Private Const PRICE As Short = 11
	Private Const DisPer As Short = 12
	Private Const Dis As Short = 13
	Private Const Amt As Short = 14
	Private Const NET As Short = 15
	Private Const Netl As Short = 16
	Private Const Disl As Short = 17
	Private Const Amtl As Short = 18
	Private Const ITMID As Short = 19
	Private Const GDRMKID As Short = 20
	
	
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
	Private Const tcRevise As String = "Revise"
	
	Private wiOpenDoc As Short
	Private wiAction As Short
	Private wiRevNo As Short
	Private wlVdrID As Integer
	Private wlSaleID As Integer
	Private wlLineNo As Integer
	Private wlRefDocID As Integer
	
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "popPOHD"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, LINENO, GDRMKID)
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
		
		Call SetButtonStatus("Default")
		Call SetFieldStatus("Default")
		Call SetFieldStatus("AfrActEdit")
		
		Call SetDateMask(medDocDate)
		Call SetDateMask(medDueDate)
		Call SetDateMask(medExpiryDate)
		'Call SetPasswordChar(txtPassword, "*")
		
		
		wsOldVdrNo = ""
		wsOldCurCd = ""
		wsOldRmkCd = ""
		wsOldPayCd = ""
		
		wsOldDelCd = ""
		wsOldShipCd(0) = ""
		wsOldShipCd(1) = ""
		wsOldShipCd(2) = ""
		
		
		wlKey = 0
		wlVdrID = 0
		wlSaleID = 0
		wlRefDocID = 0
		wlLineNo = 1
		wbReadOnly = False
		
		txtSpecDis.Text = VB6.Format("0", gsAmtFmt)
		txtDisAmt.Text = VB6.Format("0", gsAmtFmt)
		
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
	
	
	
	
	
	Private Sub cboDelCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDelCode.Enter
		FocusMe(cboDelCode)
	End Sub
	
	Private Sub cboDelCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDelCode.Leave
		FocusMe(cboDelCode, True)
	End Sub
	
	Private Sub cboDelCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDelCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		Call chk_InpLen(cboDelCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboDelCode = False Then
                GoTo EventExitSub
            End If

            If wsOldDelCd <> cboDelCode.Text Then
                Get_DelName()
                wsOldDelCd = cboDelCode.Text
            End If

            tabDetailInfo.SelectedIndex = 0
            txtDelName.Focus()

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboDelCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDelCode.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDelCode

        wsSQL = "SELECT WHSCode, WHSDESC FROM mstWarehouse WHERE WhsCode LIKE '%" & IIf(cboDelCode.SelectionLength > 0, "", Set_Quote(cboDelCode.Text)) & "%' "
        wsSQL = wsSQL & "AND WhsSTATUS = '1' "
        wsSQL = wsSQL & "ORDER BY WhsCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboDelCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboDelCode.Top) + VB6.PixelsToTwipsY(cboDelCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLWHSCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function Chk_cboDelCode() As Boolean


        Chk_cboDelCode = False

        If Trim(cboDelCode.Text) = "" Then
            Chk_cboDelCode = True
            Exit Function
        End If

        If Chk_Whs(cboDelCode.Text, "") = False Then
            gsMsg = "沒有此收貨貨倉!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboDelCode.Focus()
            Exit Function
        End If

        Chk_cboDelCode = True

    End Function




    Private Sub cboRefDocNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRefDocNo.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboRefDocNo

        wsSQL = "SELECT SOHDDOCNO, SOHDDOCDATE , CUSCODE, CUSNAME FROM SOASOHD, mstCUSTOMER "
        wsSQL = wsSQL & " WHERE SOHDSTATUS IN ('1','4') "
        wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
        wsSQL = wsSQL & " AND SOHDDOCNO LIKE '%" & IIf(cboRefDocNo.SelectionLength > 0, "", Set_Quote(cboRefDocNo.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY SOHDDOCNO "

        Call Ini_Combo(4, wsSQL, VB6.PixelsToTwipsX(cboRefDocNo.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboRefDocNo.Top) + VB6.PixelsToTwipsY(cboRefDocNo.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLSONO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboRefDocNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRefDocNo.Enter

        wcCombo = cboRefDocNo
        FocusMe(cboRefDocNo)

    End Sub
    Private Sub cboRefDocNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRefDocNo.Leave
        FocusMe(cboRefDocNo, True)
    End Sub

    Private Sub cboRefDocNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboRefDocNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(cboRefDocNo, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboRefDocNo() = False Then GoTo EventExitSub


            tabDetailInfo.SelectedIndex = 0
            cboCurr.Focus()

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_cboRefDocNo() As Boolean

        Dim wsStatus As String

        Chk_cboRefDocNo = False

        If Trim(cboRefDocNo.Text) = "" Then
            Chk_cboRefDocNo = True
            wlRefDocID = 0
            Exit Function
        End If

        If Chk_TrnHdDocNo("SO", cboRefDocNo.Text, wsStatus) = True Then

            '  If wsStatus = "4" Then
            '      gsMsg = "文件已入數!"
            '      MsgBox gsMsg, vbOKOnly, gsTitle
            '      Exit Function
            '  End If

            If wsStatus = "2" Then
                gsMsg = "文件已刪除!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Exit Function
            End If

            If wsStatus = "3" Then
                gsMsg = "文件已無效!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Exit Function
            End If
        Else
            gsMsg = "沒有此文件!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            wlRefDocID = 0
            Chk_cboRefDocNo = False
            Exit Function
        End If

        wlRefDocID = CInt(Get_TableInfo("SOASOHD", "SOHDDOCNO = '" & Set_Quote(cboRefDocNo.Text) & "'", "SOHDDOCID"))

        Chk_cboRefDocNo = True

    End Function


    Private Sub cboShipCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.DropDown
        Dim Index As Short = cboShipCode.GetIndex(eventSender)
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboShipCode(Index)

        wsSQL = "SELECT ShipCode, ShipName, ShipPer FROM mstShip WHERE ShipCode LIKE '%" & IIf(cboShipCode(Index).SelectionLength > 0, "", Set_Quote(cboShipCode(Index).Text)) & "%' "
        wsSQL = wsSQL & "AND ShipSTATUS = '1' "
        wsSQL = wsSQL & "AND ShipCardID = " & wlVdrID & " "
        wsSQL = wsSQL & "ORDER BY ShipCode "
        Call Ini_Combo(3, wsSQL, VB6.PixelsToTwipsX(cboShipCode(Index).Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboShipCode(Index).Top) + VB6.PixelsToTwipsY(cboShipCode(Index).Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLSHIPCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboShipCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.Enter
        Dim Index As Short = cboShipCode.GetIndex(eventSender)
        FocusMe(cboShipCode(Index))
    End Sub

    Private Sub cboShipCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboShipCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = cboShipCode.GetIndex(eventSender)

        Call chk_InpLen(cboShipCode(Index), 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboShipCode(Index) = False Then
                GoTo EventExitSub
            End If

            If wsOldShipCd(Index) <> cboShipCode(Index).Text Then
                Call Get_ShipMark(Index)
                wsOldShipCd(Index) = cboShipCode(Index).Text
            End If

            tabDetailInfo.SelectedIndex = 2
            txtShipPer(Index).Focus()

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboShipCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.Leave
        Dim Index As Short = cboShipCode.GetIndex(eventSender)
        FocusMe(cboShipCode(Index), True)
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
                    cboSaleCode.Focus()
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
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboCurr.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboCurr.Top) + VB6.PixelsToTwipsY(cboCurr.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLCURCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

        If wsFormID = "PN001" Then

            wsSQL = "SELECT POHDDOCNO, VDRCODE, VDRNAME, POHDDOCDATE "
            wsSQL = wsSQL & " FROM popPOHD, MstVendor "
            wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
            wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
            wsSQL = wsSQL & " AND POHDSTATUS IN ('1','4') "
            wsSQL = wsSQL & " AND POHDPGMNO  = '" & wsFormID & "' "
            wsSQL = wsSQL & " ORDER BY POHDDOCNO DESC "

        Else

            wsSQL = "SELECT POHDDOCNO, VDRCODE, VDRNAME, POHDDOCDATE "
            wsSQL = wsSQL & " FROM popPOHD, MstVendor "
            wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
            wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
            wsSQL = wsSQL & " AND POHDSTATUS IN ('1','4') "
            wsSQL = wsSQL & " AND POHDPGMNO  <> 'PN001' "
            wsSQL = wsSQL & " ORDER BY POHDDOCNO DESC "

        End If

        Call Ini_Combo(4, wsSQL, VB6.PixelsToTwipsX(cboDocNo.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Dim wsPgmNo As String

        Chk_cboDocNo = False

        If Trim(cboDocNo.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "必需輸入文件號!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboDocNo.Focus()
            Exit Function
        End If

        If Chk_PoHdDocNo(cboDocNo.Text, wsStatus, wsPgmNo) = True Then

            If wsStatus = "4" Then
                gsMsg = "文件已入數, 祇可以更新基本資料!"
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

            If wsPgmNo = "PN001" Then

                If wsFormID <> wsPgmNo Then
                    gsMsg = "文件類別不同!不能開啟!"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    tabDetailInfo.SelectedIndex = 0
                    cboDocNo.Focus()
                    Exit Function
                End If

            Else

                If wsFormID = "PN001" Then
                    gsMsg = "文件類別不同!不能開啟!"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    tabDetailInfo.SelectedIndex = 0
                    cboDocNo.Focus()
                    Exit Function
                End If

            End If


        End If

        Chk_cboDocNo = True
    End Function

    Private Sub Ini_Scr_AfrKey()

        If LoadRecord() = False Then
            wiAction = AddRec
            wiRevNo = CShort(VB6.Format(0, "##0"))
            medDocDate.Text = Dsp_Date(Now)
            'medReserveDate.Text = Format(DateAdd("d", -1, DateAdd("m", 1, CDate(medDocDate.Text))), "yyyy/mm/dd")
            medDueDate.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(medDocDate.Text))), "yyyy/mm/dd")
            medExpiryDate.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(medDocDate.Text))), "yyyy/mm/dd")

            Call SetButtonStatus("AfrKeyAdd")
        Else
            wiAction = CorRec
            If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
                gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                tblDetail.ReBind()
            End If

            wsOldVdrNo = cboVdrCode.Text
            wsOldCurCd = cboCurr.Text
            wsOldRmkCd = cboRmkCode.Text
            wsOldPayCd = cboPayCode.Text

            wsOldShipCd(0) = cboShipCode(0).Text
            wsOldShipCd(1) = cboShipCode(1).Text

            wsOldDelCd = cboDelCode.Text



            Call SetButtonStatus("AfrKeyEdit")
        End If

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)



        Call SetFieldStatus("AfrKey")

        If UCase(cboCurr.Text) = UCase(wsBaseCurCd) Then
            txtExcr.Text = VB6.Format("1", gsExrFmt)
            txtExcr.Enabled = False
        Else
            txtExcr.Enabled = True
        End If

        tabDetailInfo.SelectedIndex = 0
        cboVdrCode.Focus()





    End Sub

    'UPGRADE_WARNING: Form event frmPO001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmPO001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If OpenDoc = True Then
            OpenDoc = False
            wcCombo = cboDocNo
            Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
        End If
    End Sub

    Private Sub frmPO001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmPO001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

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

        If wsFormID = "PN001" Then


            wsSQL = "SELECT POHDDOCID, POHDDOCNO, POHDREFDOCID,  POHDVDRID, VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, PODTDOCLINE,"
            wsSQL = wsSQL & "POHDDOCDATE, POHDREVNO, POHDCURR, POHDEXCR, POHDSPECDIS, POHDETADATE, "
            wsSQL = wsSQL & "POHDDUEDATE, POHDPAYCODE, POHDPRCCODE, POHDSALEID, POHDMLCODE, "

            wsSQL = wsSQL & "POHDLCNO, POHDPORTNO, POHDCUSPO, "
            wsSQL = wsSQL & "POHDDELCODE, POHDDELNAME,  POHDDELADR1, POHDDELADR2, POHDDELADR3,  POHDDELADR4, "
            wsSQL = wsSQL & "POHDSHPFRCODE, POHDSHPFRNAME,  POHDSHPFRADR1, POHDSHPFRADR2, POHDSHPFRADR3,  POHDSHPFRADR4, POHDSHPFRTELNO, POHDSHPFRFAXNO, POHDSHPFRPER, "
            wsSQL = wsSQL & "POHDSHPTOCODE, POHDSHPTONAME,  POHDSHPTOADR1, POHDSHPTOADR2, POHDSHPTOADR3,  POHDSHPTOADR4, POHDSHPTOTELNO, POHDSHPTOFAXNO, POHDSHPTOPER, "
            wsSQL = wsSQL & "POHDSHPVIACODE, POHDSHPVIANAME,  POHDSHPVIAADR1, POHDSHPVIAADR2, POHDSHPVIAADR3,  POHDSHPVIAADR4, POHDSHPVIATELNO, POHDSHPVIAFAXNO, POHDSHPVIAPER, "

            wsSQL = wsSQL & "POHDRMKCODE, POHDRMK1,  POHDRMK2,  POHDRMK3,  POHDRMK4, POHDRMK5, "
            wsSQL = wsSQL & "POHDRMK6,  POHDRMK7,  POHDRMK8,  POHDRMK9, POHDRMK10, "
            wsSQL = wsSQL & "POHDGRSAMT , POHDGRSAMTL, POHDDISAMT, POHDDISAMTL, POHDNETAMT, POHDNETAMTL, "
            wsSQL = wsSQL & "PODTITEMID, '' ITMITMTYPECODE, PODTWHSCODE, PODTLOTNO, 'NONSTOCK' ITMCODE, PODTITEMDESC ITNAME, PODTWANTED, PODTQTY, PODTUPRICE, PODTDISPER, PODTAMT, PODTAMTL, PODTDIS, PODTDISL, PODTNET, PODTNETL, PODTDRMKID "
            wsSQL = wsSQL & "FROM  popPOHD, popPODT, MstVendor "
            wsSQL = wsSQL & "WHERE POHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
            wsSQL = wsSQL & "AND POHDDOCID = PODTDOCID "
            wsSQL = wsSQL & "AND POHDVDRID = VDRID "
            wsSQL = wsSQL & "AND POHDPGMNO = '" & wsFormID & "' "
            wsSQL = wsSQL & "ORDER BY PODTDOCLINE "

        Else

            wsSQL = "SELECT POHDDOCID, POHDDOCNO, POHDREFDOCID,  POHDVDRID, VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, PODTDOCLINE,"
            wsSQL = wsSQL & "POHDDOCDATE, POHDREVNO, POHDCURR, POHDEXCR, POHDSPECDIS, POHDETADATE, "
            wsSQL = wsSQL & "POHDDUEDATE, POHDPAYCODE, POHDPRCCODE, POHDSALEID, POHDMLCODE, "

            wsSQL = wsSQL & "POHDLCNO, POHDPORTNO, POHDCUSPO, "
            wsSQL = wsSQL & "POHDDELCODE, POHDDELNAME,  POHDDELADR1, POHDDELADR2, POHDDELADR3,  POHDDELADR4, "
            wsSQL = wsSQL & "POHDSHPFRCODE, POHDSHPFRNAME,  POHDSHPFRADR1, POHDSHPFRADR2, POHDSHPFRADR3,  POHDSHPFRADR4, POHDSHPFRTELNO, POHDSHPFRFAXNO, POHDSHPFRPER, "
            wsSQL = wsSQL & "POHDSHPTOCODE, POHDSHPTONAME,  POHDSHPTOADR1, POHDSHPTOADR2, POHDSHPTOADR3,  POHDSHPTOADR4, POHDSHPTOTELNO, POHDSHPTOFAXNO, POHDSHPTOPER, "
            wsSQL = wsSQL & "POHDSHPVIACODE, POHDSHPVIANAME,  POHDSHPVIAADR1, POHDSHPVIAADR2, POHDSHPVIAADR3,  POHDSHPVIAADR4, POHDSHPVIATELNO, POHDSHPVIAFAXNO, POHDSHPVIAPER, "

            wsSQL = wsSQL & "POHDRMKCODE, POHDRMK1,  POHDRMK2,  POHDRMK3,  POHDRMK4, POHDRMK5, "
            wsSQL = wsSQL & "POHDRMK6,  POHDRMK7,  POHDRMK8,  POHDRMK9, POHDRMK10, "
            wsSQL = wsSQL & "POHDGRSAMT , POHDGRSAMTL, POHDDISAMT, POHDDISAMTL, POHDNETAMT, POHDNETAMTL, "
            wsSQL = wsSQL & "PODTITEMID, ITMITMTYPECODE, PODTWHSCODE, PODTLOTNO, ITMCODE, PODTITEMDESC ITNAME, PODTWANTED, PODTQTY, PODTUPRICE, PODTDISPER, PODTAMT, PODTAMTL, PODTDIS, PODTDISL, PODTNET, PODTNETL, PODTDRMKID "
            wsSQL = wsSQL & "FROM  popPOHD, popPODT, MstVendor, mstITEM "
            wsSQL = wsSQL & "WHERE POHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
            wsSQL = wsSQL & "AND POHDDOCID = PODTDOCID "
            wsSQL = wsSQL & "AND POHDVDRID = VDRID "
            wsSQL = wsSQL & "AND PODTITEMID = ITMID "
            wsSQL = wsSQL & "AND POHDPGMNO <> 'PN001' "
            wsSQL = wsSQL & "ORDER BY PODTDOCLINE "

        End If

        rsInvoice.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsInvoice.RecordCount <= 0 Then
            rsInvoice.Close()
            'UPGRADE_NOTE: Object rsInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsInvoice = Nothing
            Exit Function
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = ReadRs(rsInvoice, "POHDDOCID")
        ' txtRevNo.Text = Format(ReadRs(rsInvoice, "POHDREVNO") + 1, "##0")
        wiRevNo = To_Value(ReadRs(rsInvoice, "POHDREVNO"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medDocDate.Text = ReadRs(rsInvoice, "POHDDOCDATE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlVdrID = ReadRs(rsInvoice, "VDRID")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboVdrCode.Text = ReadRs(rsInvoice, "VDRCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrName.Text = ReadRs(rsInvoice, "VDRNAME")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlRefDocID = ReadRs(rsInvoice, "POHDREFDOCID")
        cboRefDocNo.Text = Get_TableInfo("soaSOHD", "SOHDDOCID =" & wlRefDocID, "SOHDDOCNO")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrTel.Text = ReadRs(rsInvoice, "VDRTEL")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrFax.Text = ReadRs(rsInvoice, "VDRFAX")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboCurr.Text = ReadRs(rsInvoice, "POHDCURR")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtExcr.Text = VB6.Format(ReadRs(rsInvoice, "POHDEXCR"), gsExrFmt)

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medDueDate.Text = Dsp_MedDate(ReadRs(rsInvoice, "POHDDUEDATE"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medExpiryDate.Text = Dsp_MedDate(ReadRs(rsInvoice, "POHDETADATE"))

        wlSaleID = To_Value(ReadRs(rsInvoice, "POHDSALEID"))

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPayCode.Text = ReadRs(rsInvoice, "POHDPAYCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPrcCode.Text = ReadRs(rsInvoice, "POHDPRCCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboMLCode.Text = ReadRs(rsInvoice, "POHDMLCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboRmkCode.Text = ReadRs(rsInvoice, "POHDRMKCODE")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtCusPo.Text = ReadRs(rsInvoice, "POHDCUSPO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtLcNo.Text = ReadRs(rsInvoice, "POHDLCNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtPortNo.Text = ReadRs(rsInvoice, "POHDPORTNO")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtSpecDis.Text = VB6.Format(ReadRs(rsInvoice, "POHDSPECDIS"), gsExrFmt)
        txtDisAmt.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "POHDDISAMT")), gsAmtFmt)


        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboDelCode.Text = ReadRs(rsInvoice, "POHDDELCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDelName.Text = ReadRs(rsInvoice, "POHDDELName")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDelAdr1.Text = ReadRs(rsInvoice, "POHDDELADR1")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDelAdr2.Text = ReadRs(rsInvoice, "POHDDELADR2")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDelAdr3.Text = ReadRs(rsInvoice, "POHDDELADR3")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDelAdr4.Text = ReadRs(rsInvoice, "POHDDELADR4")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRCODE). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboShipCode(0).Text = ReadRs(rsInvoice, "POHDSHPFRCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRNAME). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipName(0).Text = ReadRs(rsInvoice, "POHDSHPFRNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRPER). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipPer(0).Text = ReadRs(rsInvoice, "POHDSHPFRPER")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRADR1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr1(0).Text = ReadRs(rsInvoice, "POHDSHPFRADR1")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRADR2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr2(0).Text = ReadRs(rsInvoice, "POHDSHPFRADR2")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRADR3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr3(0).Text = ReadRs(rsInvoice, "POHDSHPFRADR3")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRADR4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr4(0).Text = ReadRs(rsInvoice, "POHDSHPFRADR4")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRTELNO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipTelNo(0).Text = ReadRs(rsInvoice, "POHDSHPFRTELNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPFRFAXNO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipFaxNo(0).Text = ReadRs(rsInvoice, "POHDSHPFRFAXNO")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOCODE). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboShipCode(1).Text = ReadRs(rsInvoice, "POHDSHPTOCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTONAME). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipName(1).Text = ReadRs(rsInvoice, "POHDSHPTONAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOPER). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipPer(1).Text = ReadRs(rsInvoice, "POHDSHPTOPER")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOADR1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr1(1).Text = ReadRs(rsInvoice, "POHDSHPTOADR1")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOADR2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr2(1).Text = ReadRs(rsInvoice, "POHDSHPTOADR2")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOADR3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr3(1).Text = ReadRs(rsInvoice, "POHDSHPTOADR3")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOADR4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr4(1).Text = ReadRs(rsInvoice, "POHDSHPTOADR4")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOTELNO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipTelNo(1).Text = ReadRs(rsInvoice, "POHDSHPTOTELNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDSHPTOFAXNO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipFaxNo(1).Text = ReadRs(rsInvoice, "POHDSHPTOFAXNO")




        Dim i As Short

        For i = 1 To 10
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, POHDRMK & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtRmk(i).Text = ReadRs(rsInvoice, "POHDRMK" & i)
        Next i

        cboSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
        lblDspSaleDesc.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")

        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")
        lblDspPrcDesc.Text = Get_TableInfo("mstPriceTerm", "PrcCode ='" & Set_Quote(cboPrcCode.Text) & "'", "PRCDESC")
        lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")

        'lblDspNatureDesc = Get_TableInfo("mstNature", "NatureCode ='" & Set_Quote(cboNatureCode.Text) & "'", "NatureDESC")

        rsInvoice.MoveFirst()
        With waResult
            .ReDim(0, -1, LINENO, GDRMKID)
            Do While Not rsInvoice.EOF
                wiCtr = wiCtr + 1
                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), LINENO) = ReadRs(rsInvoice, "PODTDOCLINE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsInvoice, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMTYPE) = ReadRs(rsInvoice, "ITMITMTYPECODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMNAME) = ReadRs(rsInvoice, "ITNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), WHSCODE) = ReadRs(rsInvoice, "PODTWHSCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), LOTNO) = ReadRs(rsInvoice, "PODTLOTNO")
                waResult.get_Value(.get_UpperBound(1), PUBLISHER) = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), WANTED) = Dsp_MedDate(ReadRs(rsInvoice, "PODTWANTED"))
                ' Tom 20090203
                '   waResult(.UpperBound(1), Qty) = Format(ReadRs(rsInvoice, "PODTQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), QTY) = VB6.Format(ReadRs(rsInvoice, "PODTQTY"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), PRICE) = VB6.Format(ReadRs(rsInvoice, "PODTUPRICE"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), DisPer) = VB6.Format(ReadRs(rsInvoice, "PODTDISPER"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Amt) = VB6.Format(ReadRs(rsInvoice, "PODTAMT"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Amtl) = VB6.Format(ReadRs(rsInvoice, "PODTAMTL"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Dis) = VB6.Format(ReadRs(rsInvoice, "PODTDIS"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Disl) = VB6.Format(ReadRs(rsInvoice, "PODTDISL"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), NET) = VB6.Format(ReadRs(rsInvoice, "PODTNET"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Netl) = VB6.Format(ReadRs(rsInvoice, "PODTNETL"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsInvoice, "PODTITEMID")
                waResult.get_Value(.get_UpperBound(1), GDRMKID) = To_Value(ReadRs(rsInvoice, "PODTDRMKID"))
                waResult.get_Value(.get_UpperBound(1), GMORE) = IIf(To_Value(ReadRs(rsInvoice, "PODTDRMKID")) <> 0, "Y", "N")

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
        Dim wiCtr As Short


        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP_M", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
        'lblRevNo.Caption = Get_Caption(waScrItm, "REVNO")
        lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
        lblVdrCode.Text = Get_Caption(waScrItm, "VDRCODE")
        lblRefDocNo.Text = Get_Caption(waScrItm, "REFDOCNO")

        lblVdrName.Text = Get_Caption(waScrItm, "VDRNAME")
        lblVdrTel.Text = Get_Caption(waScrItm, "VDRTEL")
        lblVdrFax.Text = Get_Caption(waScrItm, "VDRFAX")
        LblCurr.Text = Get_Caption(waScrItm, "CURR")
        lblExcr.Text = Get_Caption(waScrItm, "EXCR")

        lblSaleCode.Text = Get_Caption(waScrItm, "SALECODE")
        lblPayCode.Text = Get_Caption(waScrItm, "PAYCODE")
        lblPrcCode.Text = Get_Caption(waScrItm, "PRCCODE")
        lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
        lblDueDate.Text = Get_Caption(waScrItm, "DUEDATE")
        lblExpiryDate.Text = Get_Caption(waScrItm, "ETADATE")

        lblGrsAmtOrg.Text = Get_Caption(waScrItm, "GRSAMTORG")
        lblNetAmtOrg.Text = Get_Caption(waScrItm, "NETAMTORG")
        lblDisAmtOrg.Text = Get_Caption(waScrItm, "DISAMTORG")
        lblTotalQty.Text = Get_Caption(waScrItm, "TOTALQTY")
        lblSpecDis.Text = Get_Caption(waScrItm, "SPECDIS")
        lblDisAmt.Text = Get_Caption(waScrItm, "DISAMTORG")
        'lblPercent.Caption = Get_Caption(waScrItm, "PERCENT")

        btnGetDisAmt.Text = Get_Caption(waScrItm, "GETDISAMT")


        With tblDetail
            .Columns(LINENO).Caption = Get_Caption(waScrItm, "LINENO")
            .Columns(SOID).Caption = Get_Caption(waScrItm, "SOID")
            .Columns(ITMCODE).Caption = Get_Caption(waScrItm, "ITMCODE")
            .Columns(ITMTYPE).Caption = Get_Caption(waScrItm, "ITMTYPE")
            .Columns(WHSCODE).Caption = Get_Caption(waScrItm, "WHSCODE")
            .Columns(LOTNO).Caption = Get_Caption(waScrItm, "LOTNO")
            .Columns(ITMNAME).Caption = Get_Caption(waScrItm, "ITMNAME")
            .Columns(WANTED).Caption = Get_Caption(waScrItm, "WANTED")
            .Columns(PUBLISHER).Caption = Get_Caption(waScrItm, "PUBLISHER")
            .Columns(QTY).Caption = Get_Caption(waScrItm, "QTY")
            .Columns(PRICE).Caption = Get_Caption(waScrItm, "PRICE")
            .Columns(DisPer).Caption = Get_Caption(waScrItm, "DISPER")
            .Columns(Dis).Caption = Get_Caption(waScrItm, "DIS")
            .Columns(NET).Caption = Get_Caption(waScrItm, "NET")
            .Columns(Amt).Caption = Get_Caption(waScrItm, "AMT")
            .Columns(GMORE).Caption = Get_Caption(waScrItm, "GMORE")
        End With

        tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO01")
        tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO02")
        tabDetailInfo.TabPages.Item(2).Text = Get_Caption(waScrItm, "TABDETAILINFO03")

        lblDelCode.Text = Get_Caption(waScrItm, "DelCode")
        lblDelName.Text = Get_Caption(waScrItm, "DelName")
        lblDelAdr1.Text = Get_Caption(waScrItm, "DelAdr1")

        fraShip(0).Text = Get_Caption(waScrItm, "SHIPFROM")
        fraShip(1).Text = Get_Caption(waScrItm, "SHIPTO")


        For wiCtr = 0 To 1

            lblShipCode(wiCtr).Text = Get_Caption(waScrItm, "SHIPCODE")
            lblShipName(wiCtr).Text = Get_Caption(waScrItm, "SHIPNAME")
            lblShipPer(wiCtr).Text = Get_Caption(waScrItm, "SHIPPER")
            lblShipAdr(wiCtr).Text = Get_Caption(waScrItm, "SHIPADR")
            lblShipTelNo(wiCtr).Text = Get_Caption(waScrItm, "SHIPTELNO")
            lblShipFaxNo(wiCtr).Text = Get_Caption(waScrItm, "SHIPFAXNO")

        Next wiCtr

        lblCusPo.Text = Get_Caption(waScrItm, "CUSPO")
        lblLcNo.Text = Get_Caption(waScrItm, "LCNO")
        lblPortNo.Text = Get_Caption(waScrItm, "PORTNO")

        lblRmkCode.Text = Get_Caption(waScrItm, "RMKCODE")
        lblRmk.Text = Get_Caption(waScrItm, "RMK")

        chkWorkOrder.Text = Get_Caption(waScrItm, "WORKORDER")

        '   btnITMLST.Caption = Get_Caption(waScrItm, "ITMLIST")

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
        tbrProcess.Items.Item(tcRevise).ToolTipText = Get_Caption(waScrToolTip, tcRevise)


        lblKeyDesc.Text = Get_Caption(waScrToolTip, "KEYDESC")
        lblComboPrompt.Text = Get_Caption(waScrToolTip, "COMBOPROMPT")
        lblInsertLine.Text = Get_Caption(waScrToolTip, "INSERTLINE")
        lblDeleteLine.Text = Get_Caption(waScrToolTip, "DELETELINE")

        wsActNam(1) = Get_Caption(waScrItm, "POADD")
        wsActNam(2) = Get_Caption(waScrItm, "POEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "PODELETE")
        wgsTitle = Get_Caption(waScrItm, "TITLE")

        Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub

    Private Sub frmPO001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        '    If Button = 2 Then
        '        PopupMenu mnuMaster
        '    End If

    End Sub

    'UPGRADE_WARNING: Event frmPO001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmPO001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub

    Private Sub frmPO001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

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
        'UPGRADE_NOTE: Object frmPO001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
            If Chk_medDocDate Then
                tabDetailInfo.SelectedIndex = 0
                cboCurr.Focus()
            End If
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
            tabDetailInfo.SelectedIndex = 0
            medDocDate.Focus()
            Exit Function
        End If

        If Chk_Date(medDocDate) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
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
                medExpiryDate.Focus()
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

        Chk_medDueDate = True

    End Function

    Private Function Chk_medExpiryDate() As Boolean
        Chk_medExpiryDate = False

        If Trim(medExpiryDate.Text) = "/  /" Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medExpiryDate.Focus()
            Exit Function
        End If

        If Chk_Date(medExpiryDate) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medExpiryDate.Focus()
            Exit Function
        End If

        Chk_medExpiryDate = True
    End Function


    Private Function Chk_medReserveDate() As Boolean

    End Function

    Private Sub medExpiryDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medExpiryDate.Enter

        FocusMe(medExpiryDate)

    End Sub

    Private Sub medExpiryDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medExpiryDate.Leave

        FocusMe(medExpiryDate, True)

    End Sub

    Private Sub medExpiryDate_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medExpiryDate.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Chk_medExpiryDate Then
                tabDetailInfo.SelectedIndex = 0
                txtSpecDis.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then

            If cboVdrCode.Enabled Then
                cboVdrCode.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 1 Then

            If tblDetail.Enabled Then
                tblDetail.Col = IIf(wsFormID = "PN001", ITMNAME, ITMTYPE)
                tblDetail.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 2 Then

            If cboShipCode(0).Enabled Then
                cboShipCode(0).Focus()
            End If

        End If
        PreviousTab = tabDetailInfo.SelectedIndex()
    End Sub

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
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
            tblCommon.Visible = False
            wcCombo.Focus()
        ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
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

        Dim rspopPOHD As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT POHDSTATUS FROM popPOHD WHERE POHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "'"
        rspopPOHD.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rspopPOHD.RecordCount > 0 Then

            Chk_KeyExist = True

        Else

            Chk_KeyExist = False

        End If

        rspopPOHD.Close()
        'UPGRADE_NOTE: Object rspopPOHD may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rspopPOHD = Nothing
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
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wlRowCtr As Integer
        Dim wsCtlPrd As String
        Dim wsSts As String
        Dim i As Short

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            If wiAction = RevRec Then wiAction = CorRec
            Exit Function
        End If

        '' Last Check when Add
        If wiAction = AddRec Then
            If Chk_KeyExist() = True Then
                Call GetNewKey()
            End If
        End If

        'If lblDspNetAmtOrg.Caption > Get_CreditLimit(wlVdrID, Trim(medDocDate.Text)) Then
        '   gsMsg = "已超過信貸額!"
        '   MsgBox gsMsg, vbOKOnly, gsTitle
        '   MousePointer = vbDefault
        '   Exit Function
        'End If

        wlRowCtr = waResult.get_UpperBound(1)
        wsCtlPrd = VB.Left(medDocDate.Text, 4) & Mid(medDocDate.Text, 6, 2)

        If wbReadOnly = True Then
            wiAction = CorRO
        End If

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_PO001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wlKey)
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, wlVdrID)
        Call SetSPPara(adcmdSave, 6, wlRefDocID)

        Call SetSPPara(adcmdSave, 7, medDocDate.Text)
        Call SetSPPara(adcmdSave, 8, wiRevNo)
        Call SetSPPara(adcmdSave, 9, cboCurr.Text)
        Call SetSPPara(adcmdSave, 10, txtExcr.Text)
        Call SetSPPara(adcmdSave, 11, wsCtlPrd)

        Call SetSPPara(adcmdSave, 12, Set_MedDate((medDueDate.Text)))
        Call SetSPPara(adcmdSave, 13, Set_MedDate((medExpiryDate.Text)))

        Call SetSPPara(adcmdSave, 14, wlSaleID)

        Call SetSPPara(adcmdSave, 15, cboPayCode.Text)
        Call SetSPPara(adcmdSave, 16, cboPrcCode.Text)
        Call SetSPPara(adcmdSave, 17, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 18, txtSpecDis.Text)
        Call SetSPPara(adcmdSave, 19, cboRmkCode.Text)

        Call SetSPPara(adcmdSave, 20, txtCusPo.Text)
        Call SetSPPara(adcmdSave, 21, txtLcNo.Text)
        Call SetSPPara(adcmdSave, 22, txtPortNo.Text)

        Call SetSPPara(adcmdSave, 23, cboDelCode.Text)
        Call SetSPPara(adcmdSave, 24, txtDelName.Text)
        Call SetSPPara(adcmdSave, 25, txtDelAdr1.Text)
        Call SetSPPara(adcmdSave, 26, txtDelAdr2.Text)
        Call SetSPPara(adcmdSave, 27, txtDelAdr3.Text)
        Call SetSPPara(adcmdSave, 28, txtDelAdr4.Text)

        For i = 0 To 1
            Call SetSPPara(adcmdSave, 29 + i * 9, cboShipCode(i).Text)
            Call SetSPPara(adcmdSave, 30 + i * 9, txtShipName(i).Text)
            Call SetSPPara(adcmdSave, 31 + i * 9, txtShipPer(i).Text)
            Call SetSPPara(adcmdSave, 32 + i * 9, txtShipAdr1(i).Text)
            Call SetSPPara(adcmdSave, 33 + i * 9, txtShipAdr2(i).Text)
            Call SetSPPara(adcmdSave, 34 + i * 9, txtShipAdr3(i).Text)
            Call SetSPPara(adcmdSave, 35 + i * 9, txtShipAdr4(i).Text)
            Call SetSPPara(adcmdSave, 36 + i * 9, txtShipTelNo(i).Text)
            Call SetSPPara(adcmdSave, 37 + i * 9, txtShipFaxNo(i).Text)
        Next i

        For i = 1 To 10
            Call SetSPPara(adcmdSave, 46 + i, "")
        Next i


        For i = 1 To 10
            Call SetSPPara(adcmdSave, 56 + i - 1, txtRmk(i).Text)
        Next

        Call SetSPPara(adcmdSave, 66, lblDspGrsAmtOrg)
        Call SetSPPara(adcmdSave, 67, lblDspDisAmtOrg)
        Call SetSPPara(adcmdSave, 68, lblDspNetAmtOrg)

        Call SetSPPara(adcmdSave, 69, wsFormID)

        Call SetSPPara(adcmdSave, 70, gsUserID)
        Call SetSPPara(adcmdSave, 71, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 72)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 73)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        If wbReadOnly = False Then

            If waResult.get_UpperBound(1) >= 0 Then
                adcmdSave.CommandText = "USP_PO001B"
                adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
                adcmdSave.Parameters.Refresh()

                For wiCtr = 0 To waResult.get_UpperBound(1)
                    If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then
                        Call SetSPPara(adcmdSave, 1, wiAction)
                        Call SetSPPara(adcmdSave, 2, wlKey)
                        Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, ITMID))
                        Call SetSPPara(adcmdSave, 4, wiCtr + 1)
                        Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, ITMNAME))
                        Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, QTY))
                        Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, PRICE))
                        Call SetSPPara(adcmdSave, 8, waResult.get_Value(wiCtr, DisPer))
                        Call SetSPPara(adcmdSave, 9, Set_MedDate(waResult.get_Value(wiCtr, WANTED)))
                        Call SetSPPara(adcmdSave, 10, waResult.get_Value(wiCtr, WHSCODE))
                        Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, LOTNO))
                        Call SetSPPara(adcmdSave, 12, waResult.get_Value(wiCtr, Amt))
                        Call SetSPPara(adcmdSave, 13, waResult.get_Value(wiCtr, Amtl))
                        Call SetSPPara(adcmdSave, 14, waResult.get_Value(wiCtr, Dis))
                        Call SetSPPara(adcmdSave, 15, waResult.get_Value(wiCtr, Disl))
                        Call SetSPPara(adcmdSave, 16, waResult.get_Value(wiCtr, NET))
                        Call SetSPPara(adcmdSave, 17, waResult.get_Value(wiCtr, Netl))
                        Call SetSPPara(adcmdSave, 18, wlRefDocID) 'SOID
                        Call SetSPPara(adcmdSave, 19, waResult.get_Value(wiCtr, GDRMKID))
                        Call SetSPPara(adcmdSave, 20, IIf(wlRowCtr = wiCtr, "Y", "N"))
                        Call SetSPPara(adcmdSave, 21, gsUserID)
                        Call SetSPPara(adcmdSave, 22, wsGenDte)
                        Call SetSPPara(adcmdSave, 23, wsFormID)
                        adcmdSave.Execute()
                    End If
                Next
            End If

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

        If wiAction = CorRO Then
            gsMsg = "基本資料已儲存!"
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
        Dim i As Short

        InputValidation = False

        On Error GoTo InputValidation_Err



        ' If Not chk_txtRevNo Then Exit Function
        If Not Chk_medDocDate Then Exit Function
        If Not chk_cboVdrCode() Then Exit Function
        If Not Chk_cboRefDocNo() Then Exit Function

        If Not getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) Then Exit Function
        If Not chk_txtExcr Then Exit Function

        If Not Chk_cboSaleCode Then Exit Function
        If Not Chk_cboPayCode Then Exit Function
        If Not Chk_cboPrcCode Then Exit Function
        If Not Chk_cboMLCode Then Exit Function

        If Not Chk_medDueDate Then Exit Function
        If Not Chk_medExpiryDate Then Exit Function

        If Not Chk_txtSpecDis Then Exit Function
        If Not chk_txtDisAmt Then Exit Function

        For i = 0 To 1
            If Not Chk_cboShipCode(i) Then Exit Function
        Next i

        If Not Chk_cboDelCode Then Exit Function

        If Not Chk_cboRmkCode Then Exit Function

        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, ITMCODE)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tabDetailInfo.SelectedIndex = 1
                        tblDetail.Col = IIf(wsFormID = "PN001", ITMNAME, ITMCODE)
                        tblDetail.Focus()
                        Exit Function
                    End If

                    If Chk_NoDup2(wlCtr, waResult.get_Value(wlCtr, ITMCODE), waResult.get_Value(wlCtr, WHSCODE), waResult.get_Value(wlCtr, LOTNO)) = False Then
                        tblDetail.Row = wlCtr - 1
                        tblDetail.Col = ITMCODE
                        tblDetail.Focus()
                        tabDetailInfo.SelectedIndex = 1
                        Exit Function
                    End If

                End If
            Next
        End With

        If wiEmptyGrid = True Then
            gsMsg = "銷售單沒有詳細資料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tabDetailInfo.SelectedIndex = 1
                tblDetail.Col = IIf(wsFormID = "PN001", ITMNAME, ITMCODE)
                tblDetail.Focus()
            End If
            Exit Function
        End If

        Call Calc_Total()

        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function

    Private Sub cmdNew()

        Dim newForm As New frmPO001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmPO001

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
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsTrnCd = "PO"

    End Sub

    Private Sub cmdCancel()

        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("Default")
        tabDetailInfo.SelectedIndex = 0
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

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            '  If .Bookmark <> .DestinationRow Then
            '    If Chk_GrdRow(To_Value(.Bookmark)) = False Then
            '        'Cancel = True
            '        Exit Sub
            '    End If
            '  End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click, _tbrProcess_Button15.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Dim wsPrtDocNo As String

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

                If MsgBox("你是否確定儲存現時之變更而列印?", MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
                    wsPrtDocNo = cboDocNo.Text
                    If cmdSave = False Then Exit Sub
                    cboDocNo.Text = wsPrtDocNo
                    Call Ini_Scr_AfrKey()
                End If

                Call cmdPrint()

            Case tcRevise
                Call cmdRevise()
            Case tcExit
                Me.Close()
        End Select

    End Sub
    Private Sub txtSpecDis_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpecDis.Enter
        FocusMe(txtSpecDis)
    End Sub

    Private Sub txtSpecDis_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSpecDis.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, (txtSpecDis.Text), False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtSpecDis Then
                tabDetailInfo.SelectedIndex = 0
                txtDisAmt.Focus()

                btnGetDisAmt_Click(btnGetDisAmt, New System.EventArgs())

            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtSpecDis_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpecDis.Leave
        txtSpecDis.Text = VB6.Format(To_Value(txtSpecDis), gsAmtFmt)
        FocusMe(txtSpecDis, True)
    End Sub

    Private Function Chk_txtSpecDis() As Boolean

        Chk_txtSpecDis = False

        If Trim(txtSpecDis.Text) = "" Then
            gsMsg = "必需輸入特別折扣!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            txtSpecDis.Focus()
            Exit Function
        End If

        If To_Value((txtSpecDis.Text)) > 1 Then
            gsMsg = "特別折扣超出範圍!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            txtSpecDis.Focus()
            Exit Function
        End If

        txtSpecDis.Text = VB6.Format(txtSpecDis.Text, gsExrFmt)

        Chk_txtSpecDis = True

    End Function


    Private Sub txtDisAmt_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDisAmt.Enter

        FocusMe(txtDisAmt)

    End Sub

    Private Sub txtDisAmt_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDisAmt.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call Chk_InpNum(KeyAscii, (txtDisAmt.Text), False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            '  If chk_txtDisAmt Then
            tabDetailInfo.SelectedIndex = 0
            cboDelCode.Focus()

            btnGetDisAmt_Click(btnGetDisAmt, New System.EventArgs())

            ' End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_txtDisAmt() As Boolean

        chk_txtDisAmt = False


        If To_Value((txtDisAmt.Text)) < 0 Then
            gsMsg = "錯誤!一定大於零"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            txtDisAmt.Focus()
            Exit Function
        End If
        txtDisAmt.Text = VB6.Format(txtDisAmt.Text, gsAmtFmt)

        chk_txtDisAmt = True

    End Function

    Private Sub txtDisAmt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDisAmt.Leave
        txtDisAmt.Text = VB6.Format(txtDisAmt.Text, gsAmtFmt)
        FocusMe(txtDisAmt, True)
    End Sub

    Private Sub btnGetDisAmt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnGetDisAmt.Click

        If To_Value((txtSpecDis.Text)) = 0 Then
            lblDspDisAmtOrg.Text = VB6.Format(To_Value((txtDisAmt.Text)), gsAmtFmt)
            lblDspNetAmtOrg.Text = VB6.Format(To_Value((lblDspGrsAmtOrg.Text)) - To_Value((txtDisAmt.Text)), gsAmtFmt)
        Else
            txtDisAmt.Text = VB6.Format(To_Value((lblDspGrsAmtOrg.Text)) * To_Value((txtSpecDis.Text)), gsAmtFmt)
            lblDspDisAmtOrg.Text = VB6.Format(To_Value((lblDspGrsAmtOrg.Text)) * To_Value((txtSpecDis.Text)), gsAmtFmt)
            lblDspNetAmtOrg.Text = VB6.Format(To_Value((lblDspGrsAmtOrg.Text)) * (1 - To_Value((txtSpecDis.Text))), gsAmtFmt)
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
                    tabDetailInfo.SelectedIndex = 0
                    cboSaleCode.Focus()
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
            tabDetailInfo.SelectedIndex = 0
            txtExcr.Focus()
            Exit Function
        End If

        If To_Value((txtExcr.Text)) > 9999.999999 Then
            gsMsg = "對換率超出範圍!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
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

        wsSQL = "SELECT VDRCODE, VDRNAME FROM MstVendor "
        wsSQL = wsSQL & "WHERE VDRCODE LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "
        wsSQL = wsSQL & "AND VDRSTATUS = '1' "
        wsSQL = wsSQL & " AND VdrInactive = 'N' "
        wsSQL = wsSQL & "ORDER BY VDRCODE "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboVdrCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboVdrCode.Top) + VB6.PixelsToTwipsY(cboVdrCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLVDRNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

            If Chk_KeyFld Then
                tabDetailInfo.SelectedIndex = 0
                cboRefDocNo.Focus()
            End If

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
            tabDetailInfo.SelectedIndex = 0
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
            gsMsg = "供應商不存在!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
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
        wsSQL = wsSQL & "FROM  MstVENDOR "
        wsSQL = wsSQL & "WHERE VDRID = " & wlVdrID
        rsDefVal.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDefVal.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboCurr.Text = ReadRs(rsDefVal, "VDRCURR")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboPayCode.Text = ReadRs(rsDefVal, "VDRPAYCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboMLCode.Text = ReadRs(rsDefVal, "VDRMLCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wlSaleID = ReadRs(rsDefVal, "VDRSALEID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsDefVal, VDRSHIPNAME). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipName(0).Text = ReadRs(rsDefVal, "VDRSHIPNAME")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsDefVal, VDRSHIPCONTACTPERSON). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipPer(0).Text = ReadRs(rsDefVal, "VDRSHIPCONTACTPERSON")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsDefVal, VDRSHIPADD1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr1(0).Text = ReadRs(rsDefVal, "VDRSHIPADD1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsDefVal, VDRSHIPADD2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr2(0).Text = ReadRs(rsDefVal, "VDRSHIPADD2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsDefVal, VDRSHIPADD3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr3(0).Text = ReadRs(rsDefVal, "VDRSHIPADD3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsDefVal, VDRSHIPADD4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr4(0).Text = ReadRs(rsDefVal, "VDRSHIPADD4")
        Else
            cboCurr.Text = ""
            cboPayCode.Text = ""
            cboMLCode.Text = ""
            wlSaleID = 0
            txtShipName(0).Text = ""
            txtShipPer(0).Text = ""
            txtShipAdr1(0).Text = ""
            txtShipAdr2(0).Text = ""
            txtShipAdr3(0).Text = ""
            txtShipAdr4(0).Text = ""

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

        cboDelCode.Text = Get_WorkStation_Info("WSWHSCODE")
        Call Get_DelName()

        cboSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
        lblDspSaleDesc.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")
        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")
        lblDspMLDesc.Text = Get_TableInfo("MstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")

        'get Due Date Payment Term
        medDueDate.Text = Dsp_Date(Get_DueDte(cboPayCode.Text, medDocDate.Text))
        medExpiryDate.Text = Dsp_Date(Get_DueDte(cboPayCode.Text, medDocDate.Text))
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


            For wiCtr = LINENO To GDRMKID
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
                    Case ITMCODE
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 30
                        .Columns(wiCtr).Visible = IIf(wsFormID = "PN001", False, True)
                    Case ITMTYPE
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 13
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).Visible = IIf(wsFormID = "PN001", False, True)
                    Case WHSCODE
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).Button = True
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Visible = False
                    Case LOTNO
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 20
                        .Columns(wiCtr).Visible = False
                    Case ITMNAME
                        .Columns(wiCtr).Width = IIf(wsFormID = "PN001", 6500, 3500)
                        ' .Columns(wiCtr).DataWidth = 60
                        .Columns(wiCtr).DataWidth = 1000
                        .Columns(wiCtr).Locked = IIf(wsFormID = "PN001", False, True)
                    Case WANTED
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).EditMask = "####/##/##"
                        .Columns(wiCtr).Visible = False
                    Case PUBLISHER
                        .Columns(wiCtr).Width = 3000
                        .Columns(wiCtr).DataWidth = 50
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).Visible = False
                    Case QTY
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt ' Tom 20090203
                    Case PRICE
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case DisPer
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        '  .Columns(wiCtr).Locked = True
                    Case NET
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case Dis
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case Amt
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case Netl
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case Disl
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case Amtl
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Visible = False
                    Case SOID
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 5
                        .Columns(wiCtr).Visible = False
                    Case ITMID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                    Case GMORE
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 2
                        .Columns(wiCtr).Button = True
                    Case GDRMKID
                        .Columns(wiCtr).Visible = False
                        .Columns(wiCtr).DataWidth = 10
                End Select
            Next
            ' .Styles("EvenRow").BackColor = &H8000000F
        End With

    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate

        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

    End Sub

    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsITMID As String
        Dim wsITMCODE As String
        Dim wsITMTYPE As String
        Dim wsITMNAME As String
        Dim wsPub As String
        Dim wdPrice As Double
        Dim wdDisPer As Double
        Dim wsLotNo As String

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

                    If Chk_PoExistGrDt(To_Value(.Bookmark)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdITMCODE((.Columns(eventArgs.ColIndex).Text), (.Columns(ITMTYPE).Text), wsITMID, wsITMCODE, wsITMNAME, wsPub, wdPrice, wdDisPer, wsLotNo) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(LINENO).Text = CStr(wlLineNo)
                    .Columns(ITMID).Text = wsITMID
                    .Columns(ITMNAME).Text = wsITMNAME
                    .Columns(PUBLISHER).Text = wsPub
                    .Columns(LOTNO).Text = wsLotNo
                    .Columns(PRICE).Text = VB6.Format(wdPrice, gsAmtFmt)
                    .Columns(QTY).Text = ""
                    .Columns(DisPer).Text = VB6.Format(wdDisPer, gsAmtFmt)
                    .Columns(WANTED).Text = medDueDate.Text
                    .Columns(WHSCODE).Text = Get_WorkStation_Info("WSWHSCODE")
                    .Columns(GMORE).Text = "N"

                    wlLineNo = wlLineNo + 1

                    If Trim(.Columns(eventArgs.ColIndex).Text) <> wsITMCODE Then
                        .Columns(eventArgs.ColIndex).Text = wsITMCODE
                    End If
                    If Trim(.Columns(PRICE).Text) <> "" Then
                        .Columns(Amt).Text = VB6.Format(To_Value((.Columns(PRICE).Text)) * To_Value((.Columns(QTY).Text)), gsAmtFmt)
                    End If
                    If Trim(txtExcr.Text) <> "" Then
                        .Columns(Amtl).Text = VB6.Format(To_Value((.Columns(PRICE).Text)) * To_Value((.Columns(QTY).Text)) * To_Value((txtExcr.Text)), gsAmtFmt)
                    End If
                    If Trim(.Columns(Amt).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Dis).Text = VB6.Format(To_Value((.Columns(Amt).Text)) * To_Value((.Columns(DisPer).Text)) / 100, gsAmtFmt)
                    End If
                    If Trim(.Columns(Amtl).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Disl).Text = VB6.Format(To_Value((.Columns(Amtl).Text)) * To_Value((.Columns(DisPer).Text)) / 100, gsAmtFmt)
                    End If
                    If Trim(.Columns(Amt).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(NET).Text = VB6.Format(To_Value((.Columns(Amt).Text)) * (1 - (To_Value((.Columns(DisPer).Text)) / 100)), gsAmtFmt)
                    End If
                    If Trim(.Columns(Amtl).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Netl).Text = VB6.Format(To_Value((.Columns(Amtl).Text)) * (1 - (To_Value((.Columns(DisPer).Text)) / 100)), gsAmtFmt)
                    End If


                Case ITMNAME

                    If Trim(.Columns(LINENO).Text) = "" Then
                        .Columns(LINENO).Text = CStr(wlLineNo)
                        .Columns(ITMID).Text = "0"
                        .Columns(PUBLISHER).Text = ""
                        .Columns(LOTNO).Text = ""
                        .Columns(ITMCODE).Text = "NONSTOCK"
                        .Columns(PRICE).Text = VB6.Format("0", gsAmtFmt)
                        .Columns(DisPer).Text = VB6.Format("0", gsAmtFmt)
                        .Columns(WANTED).Text = medDueDate.Text
                        .Columns(GMORE).Text = "N"
                        wlLineNo = wlLineNo + 1

                    End If

                Case WHSCODE
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    '  If Chk_grdWhsCode(.Columns(ColIndex).Text) = False Then
                    '          GoTo Tbl_BeforeColUpdate_Err
                    '  End If

                Case LOTNO
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    '   If Chk_grdLotNo(.Columns(ColIndex).Text) = False Then
                    '           GoTo Tbl_BeforeColUpdate_Err
                    '   End If

                Case WANTED
                    If Chk_grdWantedDate((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case QTY, PRICE, DisPer

                    If eventArgs.ColIndex = QTY Then
                        If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                        If Chk_PoExistGrDtQty(To_Value(.Bookmark), CDbl(.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If


                    ElseIf eventArgs.ColIndex = PRICE Then
                        If Chk_grdUPrice((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    ElseIf eventArgs.ColIndex = DisPer Then
                        If Chk_grdDisPer((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If
                    End If

                    If Trim(.Columns(PRICE).Text) <> "" Then
                        .Columns(Amt).Text = VB6.Format(To_Value((.Columns(PRICE).Text)) * To_Value((.Columns(QTY).Text)), gsAmtFmt)
                    End If
                    If Trim(txtExcr.Text) <> "" Then
                        .Columns(Amtl).Text = VB6.Format(To_Value((.Columns(PRICE).Text)) * To_Value((.Columns(QTY).Text)) * To_Value((txtExcr.Text)), gsAmtFmt)
                    End If
                    If Trim(.Columns(Amt).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Dis).Text = VB6.Format(To_Value((.Columns(Amt).Text)) * To_Value((.Columns(DisPer).Text)) / 100, gsAmtFmt)
                    End If
                    If Trim(.Columns(Amtl).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Disl).Text = VB6.Format(To_Value((.Columns(Amtl).Text)) * To_Value((.Columns(DisPer).Text)) / 100, gsAmtFmt)
                    End If
                    If Trim(.Columns(Amt).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(NET).Text = VB6.Format(To_Value((.Columns(Amt).Text)) * (1 - (To_Value((.Columns(DisPer).Text)) / 100)), gsAmtFmt)
                    End If
                    If Trim(.Columns(Amtl).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Netl).Text = VB6.Format(To_Value((.Columns(Amtl).Text)) * (1 - (To_Value((.Columns(DisPer).Text)) / 100)), gsAmtFmt)
                    End If

                Case Dis

                    If Trim(txtExcr.Text) <> "" Then
                        .Columns(Disl).Text = VB6.Format(To_Value((.Columns(Dis).Text)) * To_Value((txtExcr.Text)), gsAmtFmt)
                    End If
                    If Trim(.Columns(Amt).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(NET).Text = VB6.Format(To_Value((.Columns(Amt).Text)) * (1 - (To_Value((.Columns(DisPer).Text)) / 100)), gsAmtFmt)
                    End If
                    If Trim(.Columns(Amtl).Text) <> "" And Trim(.Columns(DisPer).Text) <> "" Then
                        .Columns(Netl).Text = VB6.Format(To_Value((.Columns(Amtl).Text)) * (1 - (To_Value((.Columns(DisPer).Text)) / 100)), gsAmtFmt)
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
        Dim wsRmkID As String


        On Error GoTo tblDetail_ButtonClick_Err


        With tblDetail
            Select Case eventArgs.ColIndex


                Case ITMTYPE

                    wsSQL = "SELECT ITMTYPECODE, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC") & " ITNAME "
                    wsSQL = wsSQL & " FROM MSTITEMTYPE,mstITEM, mstVdrItem "
                    wsSQL = wsSQL & " WHERE ITMTYPECODE LIKE '%" & Set_Quote(.Columns(ITMTYPE).Text) & "%' "
                    wsSQL = wsSQL & " AND ITMTYPESTATUS  <> '2' "
                    wsSQL = wsSQL & " AND ITMINACTIVE = 'N' "
                    wsSQL = wsSQL & " AND ITMID = VDRITEMITMID "
                    wsSQL = wsSQL & " AND ITMTYPECODE = ITMITMTYPECODE "
                    wsSQL = wsSQL & " AND VDRITEMCURR = '" & Set_Quote(cboCurr.Text) & "' "
                    wsSQL = wsSQL & " AND VDRITEMVDRID = " & To_Value(wlVdrID) & " "
                    wsSQL = wsSQL & " GROUP BY ITMTYPECODE, " & IIf(gsLangID = "1", "ITMTYPEENGDESC", "ITMTYPECHIDESC") & " "

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLITMTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail


                Case ITMCODE

                    wsSQL = "SELECT ITMCODE, ITMBARCODE, ITMENGNAME, ITMCHINAME "
                    wsSQL = wsSQL & " FROM mstITEM, mstVdrItem "
                    wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' "
                    wsSQL = wsSQL & " AND VDRITEMSTATUS <> '2' "
                    wsSQL = wsSQL & " AND ITMINACTIVE = 'N' "
                    wsSQL = wsSQL & " AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
                    wsSQL = wsSQL & " AND ITMITMTYPECODE = '" & Set_Quote(.Columns(ITMTYPE).Text) & "' "
                    wsSQL = wsSQL & " AND ITMID = VDRITEMITMID "
                    wsSQL = wsSQL & " AND VDRITEMCURR = '" & Set_Quote(cboCurr.Text) & "' "
                    wsSQL = wsSQL & " AND VDRITEMVDRID = " & To_Value(wlVdrID) & " "

                    If waResult.get_UpperBound(1) > -1 Then
                        wsSQL = wsSQL & " AND ITMCODE NOT IN ( "
                        For wiCtr = 0 To waResult.get_UpperBound(1)
                            wsSQL = wsSQL & " '" & Set_Quote(waResult.get_Value(wiCtr, ITMCODE)) & IIf(wiCtr = waResult.get_UpperBound(1), "' )", "' ,")
                        Next
                    End If
                    wsSQL = wsSQL & " ORDER BY ITMCODE "

                    Call Ini_Combo(4, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case WHSCODE

                    wsSQL = "SELECT WHSCODE, WHSDESC FROM mstWareHouse "
                    wsSQL = wsSQL & " WHERE WHSSTATUS <> '2' AND WHSCODE LIKE '%" & Set_Quote(.Columns(WHSCODE).Text) & "%' "
                    wsSQL = wsSQL & " ORDER BY WHSCODE "

                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLWHSCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case GMORE


                    frmDocRemark.RmkID = IIf(.Columns(GDRMKID).Text = "", "0", .Columns(GDRMKID).Text)
                    frmDocRemark.RmkType = "PO"
                    frmDocRemark.ShowDialog()
                    wsRmkID = frmDocRemark.RmkID
                    frmDocRemark.Close()


                    Call cmdRmkID(.Bookmark, wsRmkID)

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
                    If Chk_PoExistGrDt(To_Value(.Bookmark)) = False Then Exit Sub
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
                        Case LINENO
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = IIf(wsFormID = "PN001", ITMNAME, ITMTYPE)
                        Case ITMTYPE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = ITMCODE
                        Case ITMCODE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = GMORE
                        Case GMORE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = QTY
                        Case QTY
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = PRICE
                        Case PRICE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = DisPer
                        Case DisPer
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = ITMCODE
                        Case ITMNAME
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = GMORE
                        Case GMORE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = QTY
                        Case NET
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = ITMCODE
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case NET
                            .Col = DisPer
                        Case DisPer
                            .Col = PRICE
                        Case PRICE
                            .Col = QTY
                        Case QTY
                            .Col = GMORE
                        Case GMORE
                            .Col = ITMNAME
                        Case ITMNAME
                            .Col = ITMCODE
                        Case ITMCODE
                            .Col = ITMTYPE
                    End Select

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case DisPer
                            .Col = NET
                        Case PRICE
                            .Col = DisPer
                        Case QTY
                            .Col = PRICE
                        Case ITMNAME
                            .Col = GMORE
                        Case ITMNAME
                            .Col = GMORE
                        Case GMORE
                            .Col = QTY
                        Case LINENO
                            .Col = IIf(wsFormID = "PN001", ITMNAME, ITMTYPE)
                        Case ITMTYPE
                            .Col = ITMCODE

                    End Select
            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent

        Select Case tblDetail.Col
            ' Tom 20090203
            ' Case Qty
            '    Call Chk_InpNum(KeyAscii, tblDetail.Text, False, False)

            Case QTY, PRICE, DisPer, Dis
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
                .Col = IIf(wsFormID = "PN001", ITMNAME, ITMTYPE)
            End If

            Call Calc_Total()

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case ITMTYPE
                        Call Chk_grdITMTYPE(.Columns(ITMTYPE).Text)
                    Case ITMCODE
                        Call Chk_grdITMCODE((.Columns(ITMCODE).Text), (.Columns(ITMTYPE).Text), "", "", "", "", 0, 0, "")
                    Case WHSCODE
                        '  Call Chk_grdWhsCode(.Columns(WHSCODE).Text)
                    Case LOTNO
                        '  Call Chk_grdLotNo(.Columns(LOTNO).Text)
                    Case WANTED
                        Call Chk_grdWantedDate((.Columns(WANTED).Text))
                    Case QTY
                        '     Call Chk_grdQty(.Columns(Qty).Text)
                    Case PRICE
                        '    Call Chk_grdUPrice(.Columns(Price).Text)

                    Case DisPer
                        Call Chk_grdDisPer((.Columns(DisPer).Text))

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub

    Private Function Chk_grdITMCODE(ByRef inAccNo As String, ByRef inItmType As String, ByRef outAccID As String, ByRef outAccNo As String, ByRef OutName As String, ByRef outPub As String, ByRef outPrice As Double, ByRef outDisPer As Double, ByRef outLotNo As String) As Boolean

        Dim wsSQL As String
        Dim rsDes As New ADODB.Recordset


        If wsFormID = "PN001" Then
            Chk_grdITMCODE = True
            Exit Function
        End If


        If Trim(inAccNo) = "" Then
            gsMsg = "沒有輸入物料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
            Exit Function
        End If


        wsSQL = "SELECT ITMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME, VDRITEMCOST "
        wsSQL = wsSQL & " FROM mstITEM, mstVdrItem "
        wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' "
        wsSQL = wsSQL & " AND VDRITEMSTATUS <> '2' "
        wsSQL = wsSQL & " AND ITMINACTIVE = 'N' "
        wsSQL = wsSQL & " AND ITMCODE = '" & Set_Quote(inAccNo) & "' "
        wsSQL = wsSQL & " AND ITMITMTYPECODE = '" & Set_Quote(inItmType) & "' "
        wsSQL = wsSQL & " AND ITMID = VDRITEMITMID "
        wsSQL = wsSQL & " AND VDRITEMCURR = '" & Set_Quote(cboCurr.Text) & "' "
        wsSQL = wsSQL & " AND VDRITEMVDRID = " & To_Value(wlVdrID) & " "

        rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccID = ReadRs(rsDes, "ITMID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccNo = ReadRs(rsDes, "ITMCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsDes, "ITMNAME")
            outPub = ""
            outPrice = To_Value(ReadRs(rsDes, "VDRITEMCOST"))
            outLotNo = ""
            outDisPer = 0

            Chk_grdITMCODE = True
        Else
            outAccID = ""
            OutName = ""
            outPub = ""
            outPrice = 0
            outDisPer = 0
            outLotNo = ""
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

        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset

        Chk_grdLotNo = False

        If Trim(inNo) = "" Then
            gsMsg = "必需輸入版次!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        Chk_grdLotNo = True

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


    Private Function Chk_grdUPrice(ByRef inCode As String) As Boolean

        Chk_grdUPrice = True

        If Trim(inCode) = "" Then
            gsMsg = "必需輸入單價!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdUPrice = False
            Exit Function
        End If

        ' Tom 20090203
        '  If To_Value(inCode) = 0 Then
        '      gsMsg = "單價必需大於零!"
        '      MsgBox gsMsg, vbOKOnly, gsTitle
        '      Chk_grdUPrice = False
        '      Exit Function
        '  End If

    End Function
    Private Function Chk_grdDisPer(ByRef inCode As String) As Boolean

        Chk_grdDisPer = True

        If Trim(inCode) = "" Then
            gsMsg = "必需輸入折扣!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdDisPer = False
            Exit Function
        End If

        If To_Value(inCode) < 0 Or To_Value(inCode) > 100 Then
            gsMsg = "折扣必需為零至一百!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdDisPer = False
            Exit Function
        End If

    End Function








    Private Function Chk_grdWantedDate(ByRef inCode As String) As Boolean

        Chk_grdWantedDate = False

        If Trim(inCode) = "/  /" Or Trim(inCode) = "" Then
            Chk_grdWantedDate = True
            Exit Function
        End If

        If Chk_MedDate(inCode) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        Chk_grdWantedDate = True

    End Function

    Private Function Chk_Amount(ByRef inAmt As String) As Short

        Chk_Amount = False

        If Trim(inAmt) = "" Then
            gsMsg = "必需輸入金額!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        '  If To_Value(inAmt) = 0 Then
        '     gsMsg = "Amount Must not zero!"
        '      MsgBox gsMsg, vbOKOnly, gsTitle
        '     Exit Function
        '  End If
        Chk_Amount = True

    End Function

    Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean

        IsEmptyRow = True

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblDetail
                If wsFormID = "PN001" Then
                    If Trim(.Columns(ITMNAME).Text) = "" Then
                        Exit Function
                    End If
                Else
                    If Trim(.Columns(ITMTYPE).Text) = "" Then
                        Exit Function
                    End If
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, ITMTYPE)) = "" And Trim(waResult.get_Value(inRow, ITMCODE)) = "" And Trim(waResult.get_Value(inRow, ITMNAME)) = "" And Trim(waResult.get_Value(inRow, GMORE)) = "" And Trim(waResult.get_Value(inRow, PUBLISHER)) = "" And Trim(waResult.get_Value(inRow, QTY)) = "" And Trim(waResult.get_Value(inRow, PRICE)) = "" And Trim(waResult.get_Value(inRow, DisPer)) = "" And Trim(waResult.get_Value(inRow, Amt)) = "" And Trim(waResult.get_Value(inRow, Amtl)) = "" And Trim(waResult.get_Value(inRow, Dis)) = "" And Trim(waResult.get_Value(inRow, Disl)) = "" And Trim(waResult.get_Value(inRow, NET)) = "" And Trim(waResult.get_Value(inRow, Netl)) = "" And Trim(waResult.get_Value(inRow, ITMID)) = "" Then
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


            If Chk_grdITMCODE(waResult.get_Value(LastRow, ITMCODE), waResult.get_Value(LastRow, ITMTYPE), "", "", "", "", 0, 0, "") = False Then
                .Col = ITMCODE
                .Row = LastRow
                Exit Function
            End If

            '  If Chk_grdWhsCode(waResult(LastRow, WHSCODE)) = False Then
            '          .Col = WHSCODE
            '          .Row = LastRow
            '          Exit Function
            '  End If

            '  If Chk_grdLotNo(waResult(LastRow, LOTNO)) = False Then
            '          .Col = LOTNO
            '          .Row = LastRow
            '          Exit Function
            '  End If

            If Chk_grdWantedDate(waResult.get_Value(LastRow, WANTED)) = False Then
                .Col = WANTED
                .Row = LastRow
                Exit Function
            End If

            If Chk_grdQty(waResult.get_Value(LastRow, QTY)) = False Then
                .Col = QTY
                .Row = LastRow
                Exit Function
            End If

            If Chk_PoExistGrDtQty(LastRow, waResult.get_Value(LastRow, QTY)) = False Then
                .Col = QTY
                .Row = LastRow
                Exit Function
            End If


            If Chk_grdUPrice(waResult.get_Value(LastRow, PRICE)) = False Then
                .Col = PRICE
                .Row = LastRow
                Exit Function
            End If

            If Chk_grdDisPer(waResult.get_Value(LastRow, DisPer)) = False Then
                .Col = DisPer
                .Row = LastRow
                Exit Function
            End If

            If Chk_Amount(waResult.get_Value(LastRow, Amt)) = False Then
                .Col = Amt
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

        Dim wiTotalGrs As Double
        Dim wiTotalDis As Double
        Dim wiTotalNet As Double
        Dim wiTotalQty As Double

        Dim wiRowCtr As Short

        Calc_Total = False
        For wiRowCtr = 0 To waResult.get_UpperBound(1)
            wiTotalGrs = wiTotalGrs + To_Value(waResult.get_Value(wiRowCtr, Amt)) - To_Value(waResult.get_Value(wiRowCtr, Dis))
            ' wiTotalDis = wiTotalDis + To_Value(waResult(wiRowCtr, Dis))
            wiTotalNet = wiTotalNet + To_Value(waResult.get_Value(wiRowCtr, NET))
            wiTotalQty = wiTotalQty + To_Value(waResult.get_Value(wiRowCtr, QTY))
        Next

        lblDspGrsAmtOrg.Text = VB6.Format(CStr(wiTotalGrs), gsAmtFmt)
        'lblDspDisAmtOrg.Caption = Format(CStr(wiTotalDis), gsAmtFmt)
        lblDspNetAmtOrg.Text = VB6.Format(CStr(wiTotalNet), gsAmtFmt)
        lblDspTotalQty.Text = VB6.Format(CStr(wiTotalQty), gsQtyFmt)

        btnGetDisAmt_Click(btnGetDisAmt, New System.EventArgs())

        Calc_Total = True

    End Function

    Private Function cmdDel() As Boolean

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command

        Dim i As Short
        Dim wsCtlPrd As String

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

        If DelValidation(wlKey) = False Then
            wiAction = CorRec
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If

        wiAction = DelRec
        wsCtlPrd = VB.Left(medDocDate.Text, 4) & Mid(medDocDate.Text, 6, 2)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_PO001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()


        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wlKey)
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, wlVdrID)
        Call SetSPPara(adcmdSave, 6, wlRefDocID)

        Call SetSPPara(adcmdSave, 7, medDocDate.Text)
        Call SetSPPara(adcmdSave, 8, wiRevNo)
        Call SetSPPara(adcmdSave, 9, cboCurr.Text)
        Call SetSPPara(adcmdSave, 10, txtExcr.Text)
        Call SetSPPara(adcmdSave, 11, wsCtlPrd)

        Call SetSPPara(adcmdSave, 12, Set_MedDate((medDueDate.Text)))
        Call SetSPPara(adcmdSave, 13, Set_MedDate((medExpiryDate.Text)))

        Call SetSPPara(adcmdSave, 14, wlSaleID)

        Call SetSPPara(adcmdSave, 15, cboPayCode.Text)
        Call SetSPPara(adcmdSave, 16, cboPrcCode.Text)
        Call SetSPPara(adcmdSave, 17, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 18, txtSpecDis.Text)
        Call SetSPPara(adcmdSave, 19, cboRmkCode.Text)

        Call SetSPPara(adcmdSave, 20, txtCusPo.Text)
        Call SetSPPara(adcmdSave, 21, txtLcNo.Text)
        Call SetSPPara(adcmdSave, 22, txtPortNo.Text)

        Call SetSPPara(adcmdSave, 23, cboDelCode.Text)
        Call SetSPPara(adcmdSave, 24, txtDelName.Text)
        Call SetSPPara(adcmdSave, 25, txtDelAdr1.Text)
        Call SetSPPara(adcmdSave, 26, txtDelAdr2.Text)
        Call SetSPPara(adcmdSave, 27, txtDelAdr3.Text)
        Call SetSPPara(adcmdSave, 28, txtDelAdr4.Text)

        For i = 0 To 1
            Call SetSPPara(adcmdSave, 29 + i * 9, cboShipCode(i).Text)
            Call SetSPPara(adcmdSave, 30 + i * 9, txtShipName(i).Text)
            Call SetSPPara(adcmdSave, 31 + i * 9, txtShipPer(i).Text)
            Call SetSPPara(adcmdSave, 32 + i * 9, txtShipAdr1(i).Text)
            Call SetSPPara(adcmdSave, 33 + i * 9, txtShipAdr2(i).Text)
            Call SetSPPara(adcmdSave, 34 + i * 9, txtShipAdr3(i).Text)
            Call SetSPPara(adcmdSave, 35 + i * 9, txtShipAdr4(i).Text)
            Call SetSPPara(adcmdSave, 36 + i * 9, txtShipTelNo(i).Text)
            Call SetSPPara(adcmdSave, 37 + i * 9, txtShipFaxNo(i).Text)
        Next i

        For i = 1 To 10
            Call SetSPPara(adcmdSave, 46 + i, "")
        Next i

        For i = 1 To 10
            Call SetSPPara(adcmdSave, 56 + i - 1, txtRmk(i).Text)
        Next

        Call SetSPPara(adcmdSave, 66, lblDspGrsAmtOrg)
        Call SetSPPara(adcmdSave, 67, lblDspDisAmtOrg)
        Call SetSPPara(adcmdSave, 68, lblDspNetAmtOrg)

        Call SetSPPara(adcmdSave, 69, wsFormID)

        Call SetSPPara(adcmdSave, 70, gsUserID)
        Call SetSPPara(adcmdSave, 71, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 72)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 73)

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
                    .Items.Item(tcRevise).Enabled = False
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
                    .Items.Item(tcRevise).Enabled = False
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
                    .Items.Item(tcRevise).Enabled = True
                End With

            Case "ReadOnly"
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
                    .Items.Item(tcPrint).Enabled = True
                    .Items.Item(tcRevise).Enabled = False
                End With
        End Select
    End Sub

    '-- Set field status, Default, Add, Edit.
    Public Sub SetFieldStatus(ByVal sStatus As String)
        Dim i As Short

        Select Case sStatus
            Case "Default"

                Me.cboDocNo.Enabled = False
                Me.cboVdrCode.Enabled = False
                Me.cboRefDocNo.Enabled = False

                Me.medDocDate.Enabled = False
                Me.cboCurr.Enabled = False
                Me.txtExcr.Enabled = False

                Me.medDueDate.Enabled = False
                Me.medExpiryDate.Enabled = False
                Me.cboSaleCode.Enabled = False
                Me.cboPayCode.Enabled = False
                Me.cboPrcCode.Enabled = False
                Me.cboMLCode.Enabled = False
                Me.cboRmkCode.Enabled = False

                Me.cboDelCode.Enabled = False
                Me.txtDelName.Enabled = False
                Me.txtDelAdr1.Enabled = False
                Me.txtDelAdr2.Enabled = False
                Me.txtDelAdr3.Enabled = False
                Me.txtDelAdr4.Enabled = False

                For i = 0 To 1
                    Me.cboShipCode(i).Enabled = False
                    Me.txtShipName(i).Enabled = False
                    Me.txtShipAdr1(i).Enabled = False
                    Me.txtShipAdr2(i).Enabled = False
                    Me.txtShipAdr3(i).Enabled = False
                    Me.txtShipAdr4(i).Enabled = False
                    Me.txtShipPer(i).Enabled = False
                    Me.txtShipTelNo(i).Enabled = False
                    Me.txtShipFaxNo(i).Enabled = False
                Next i

                Me.txtCusPo.Enabled = False
                Me.txtLcNo.Enabled = False
                Me.txtPortNo.Enabled = False

                Me.picRmk.Enabled = False

                Me.tblDetail.Enabled = False
                Me.txtSpecDis.Enabled = False
                Me.txtDisAmt.Enabled = False
                Me.btnGetDisAmt.Enabled = False

                Me.chkWorkOrder.Enabled = False




            Case "AfrActAdd"

                Me.cboDocNo.Enabled = True

            Case "AfrActEdit"

                Me.cboDocNo.Enabled = True

            Case "AfrKey"
                Me.cboDocNo.Enabled = False

                Me.cboVdrCode.Enabled = True
                Me.cboRefDocNo.Enabled = True

                Me.medDocDate.Enabled = True
                Me.cboCurr.Enabled = True
                Me.txtExcr.Enabled = True

                Me.medDueDate.Enabled = True
                Me.medExpiryDate.Enabled = True
                Me.cboSaleCode.Enabled = True
                Me.cboPayCode.Enabled = True
                Me.cboPrcCode.Enabled = True
                Me.cboMLCode.Enabled = True
                Me.cboRmkCode.Enabled = True

                Me.cboDelCode.Enabled = True
                Me.txtDelName.Enabled = True
                Me.txtDelAdr1.Enabled = True
                Me.txtDelAdr2.Enabled = True
                Me.txtDelAdr3.Enabled = True
                Me.txtDelAdr4.Enabled = True

                For i = 0 To 1
                    Me.cboShipCode(i).Enabled = True
                    Me.txtShipName(i).Enabled = True
                    Me.txtShipAdr1(i).Enabled = True
                    Me.txtShipAdr2(i).Enabled = True
                    Me.txtShipAdr3(i).Enabled = True
                    Me.txtShipAdr4(i).Enabled = True
                    Me.txtShipPer(i).Enabled = True
                    Me.txtShipTelNo(i).Enabled = True
                    Me.txtShipFaxNo(i).Enabled = True
                Next i

                Me.txtCusPo.Enabled = True
                Me.txtLcNo.Enabled = True
                Me.txtPortNo.Enabled = True

                Me.picRmk.Enabled = True
                Me.txtSpecDis.Enabled = True
                Me.txtDisAmt.Enabled = True
                Me.btnGetDisAmt.Enabled = True

                Me.chkWorkOrder.Enabled = True

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
            .TableType = wsTrnCd
            .TableKey = "PoHdDocNo"
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
        vFilterAry(1, 2) = "PoHdDocNo"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "Doc. Date"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "PoHdDocDate"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "Vendor #"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "VdrCode"

        Dim vAry(4, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "Doc No."
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "PoHdDocNo"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "Date"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "PoHdDocDate"
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
            wsSQL = "SELECT popPOHD.PoHdDocNo, popPOHD.PoHdDocDate, MstVendor.VdrCode,  MstVendor.VdrName "
            wsSQL = wsSQL & "FROM MstVendor, popPOHD "
            .sBindSQL = wsSQL
            .sBindWhereSQL = "WHERE popPOHD.PoHdStatus = '1' And popPOHD.PoHdVdrID = MstVendor.VdrID "
            .sBindOrderSQL = "ORDER BY popPOHD.PoHdDocNo"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmPO001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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

            If Chk_cboSaleCode = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0
            cboPayCode.Focus()

        End If

EventExitSub:
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
        wsSQL = wsSQL & " AND SaleType = 'S' "
        wsSQL = wsSQL & "AND SaleStatus = '1' "
        wsSQL = wsSQL & "ORDER BY SaleCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboSaleCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboSaleCode.Top) + VB6.PixelsToTwipsY(cboSaleCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLSALECOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function Chk_cboSaleCode() As Boolean
        Dim wsDesc As String

        Chk_cboSaleCode = False

        If Trim(cboSaleCode.Text) = "" Then
            gsMsg = "必需輸入營業員!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboSaleCode.Focus()
            Exit Function
        End If

        If Chk_Salesman(cboSaleCode.Text, wlSaleID, wsDesc) = False Then
            gsMsg = "沒有此營業員!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboSaleCode.Focus()
            lblDspSaleDesc.Text = ""
            Exit Function
        End If

        lblDspSaleDesc.Text = wsDesc

        Chk_cboSaleCode = True

    End Function

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
            cboPrcCode.Focus()

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

    Private Sub cboPrcCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCode.Enter
        FocusMe(cboPrcCode)
    End Sub

    Private Sub cboPrcCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCode.Leave
        FocusMe(cboPrcCode, True)
    End Sub

    Private Sub cboPrcCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPrcCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim wsDesc As String

        Call chk_InpLen(cboPrcCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboPrcCode = False Then
                GoTo EventExitSub
            End If

            txtPortNo.Text = Get_TableInfo("MstPriceTerm", "PrcCode = '" & Set_Quote(cboPrcCode.Text) & "'", "PricePort")

            tabDetailInfo.SelectedIndex = 0
            cboMLCode.Focus()

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboPrcCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPrcCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboPrcCode

        wsSQL = "SELECT PrcCode, PRCDESC FROM mstPriceTerm WHERE PrcCode LIKE '%" & IIf(cboPrcCode.SelectionLength > 0, "", Set_Quote(cboPrcCode.Text)) & "%' "
        wsSQL = wsSQL & "AND PRCSTATUS = '1' "
        wsSQL = wsSQL & "ORDER BY PrcCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboPrcCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboPrcCode.Top) + VB6.PixelsToTwipsY(cboPrcCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLPRCCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function Chk_cboPrcCode() As Boolean
        Dim wsDesc As String

        Chk_cboPrcCode = False

        If Trim(cboPrcCode.Text) = "" Then
            lblDspPrcDesc.Text = ""
            Chk_cboPrcCode = True
            Exit Function
        End If

        If Chk_PriceTerm(cboPrcCode.Text, wsDesc) = False Then
            gsMsg = "沒有此銷售條款!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboPrcCode.Focus()
            lblDspPrcDesc.Text = ""
            Exit Function
        End If

        lblDspPrcDesc.Text = wsDesc
        Chk_cboPrcCode = True

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

        wsSQL = "SELECT MLCode, MLDESC FROM mstMerchClass WHERE MLCode LIKE '%" & IIf(cboMLCode.SelectionLength > 0, "", Set_Quote(cboMLCode.Text)) & "%' "
        wsSQL = wsSQL & "AND MLTYPE = 'R' "
        wsSQL = wsSQL & "AND MLSTATUS = '1' "
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

        If Chk_MerchClass(cboMLCode.Text, wsDesc) = False Then
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

    Private Sub txtDelName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelName.Enter
        FocusMe(txtDelName)
    End Sub

    Private Sub txtDelName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDelName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtDelName, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 0
            txtDelAdr1.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtDelName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelName.Leave
        FocusMe(txtDelName, True)
    End Sub

    Private Sub txtDelAdr1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr1.Enter
        FocusMe(txtDelAdr1)
    End Sub

    Private Sub txtDelAdr1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDelAdr1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtDelAdr1, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtDelAdr2.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtDelAdr1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr1.Leave
        FocusMe(txtDelAdr1, True)
    End Sub


    Private Sub txtDelAdr2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr2.Enter
        FocusMe(txtDelAdr2)
    End Sub

    Private Sub txtDelAdr2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDelAdr2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtDelAdr2, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtDelAdr3.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtDelAdr2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr2.Leave
        FocusMe(txtDelAdr2, True)
    End Sub


    Private Sub txtDelAdr3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr3.Enter
        FocusMe(txtDelAdr3)
    End Sub

    Private Sub txtDelAdr3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDelAdr3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtDelAdr3, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtDelAdr4.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtDelAdr3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr3.Leave
        FocusMe(txtDelAdr3, True)
    End Sub

    Private Sub txtDelAdr4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr4.Enter
        FocusMe(txtDelAdr4)
    End Sub

    Private Sub txtDelAdr4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDelAdr4.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtDelAdr4, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtCusPo.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtDelAdr4_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDelAdr4.Leave
        FocusMe(txtDelAdr4, True)
    End Sub










    Private Sub txtCusPo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCusPo.Enter
        FocusMe(txtCusPo)
    End Sub

    Private Sub txtCusPo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCusPo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtCusPo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtLcNo.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtCusPo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCusPo.Leave
        FocusMe(txtCusPo, True)
    End Sub

    Private Sub txtLcNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLcNo.Enter
        FocusMe(txtLcNo)
    End Sub

    Private Sub txtLcNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtLcNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtLcNo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 0
            txtPortNo.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtLcNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLcNo.Leave
        FocusMe(txtLcNo, True)
    End Sub

    Private Sub txtPortNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPortNo.Enter
        FocusMe(txtPortNo)
    End Sub

    Private Sub txtPortNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPortNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtPortNo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_KeyFld = True Then
                tabDetailInfo.SelectedIndex = 1
                tblDetail.Col = IIf(wsFormID = "PN001", ITMNAME, ITMCODE)
                tblDetail.Focus()
            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtPortNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPortNo.Leave
        FocusMe(txtPortNo, True)
    End Sub


    Private Function Chk_cboShipCode(ByRef inIndex As Short) As Boolean

        Chk_cboShipCode = False

        If Trim(cboShipCode(inIndex).Text) = "" Then
            Chk_cboShipCode = True
            Exit Function
        End If

        If Chk_Ship(cboShipCode(inIndex).Text) = False Then
            gsMsg = "沒有此貨運編碼!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboShipCode(inIndex).Focus()
            Exit Function
        End If

        Chk_cboShipCode = True

    End Function


    Private Sub txtShipName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipName.Enter
        Dim Index As Short = txtShipName.GetIndex(eventSender)
        FocusMe(txtShipName(Index))
    End Sub

    Private Sub txtShipName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipName.GetIndex(eventSender)

        Call chk_InpLen(txtShipName(Index), 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipAdr1(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipName.Leave
        Dim Index As Short = txtShipName.GetIndex(eventSender)
        FocusMe(txtShipName(Index), True)
    End Sub

    Private Sub txtShipPer_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipPer.Enter
        Dim Index As Short = txtShipPer.GetIndex(eventSender)
        FocusMe(txtShipPer(Index))
    End Sub

    Private Sub txtShipPer_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipPer.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipPer.GetIndex(eventSender)

        Call chk_InpLen(txtShipPer(Index), 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 2
            txtShipName(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipPer_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipPer.Leave
        Dim Index As Short = txtShipPer.GetIndex(eventSender)
        FocusMe(txtShipPer(Index), True)
    End Sub

    Private Sub txtShipAdr1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr1.Enter
        Dim Index As Short = txtShipAdr1.GetIndex(eventSender)
        FocusMe(txtShipAdr1(Index))
    End Sub

    Private Sub txtShipAdr1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipAdr1.GetIndex(eventSender)

        Call chk_InpLen(txtShipAdr1(Index), 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 2
            txtShipAdr2(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr1.Leave
        Dim Index As Short = txtShipAdr1.GetIndex(eventSender)
        FocusMe(txtShipAdr1(Index), True)
    End Sub

    Private Sub txtShipAdr2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr2.Enter
        Dim Index As Short = txtShipAdr2.GetIndex(eventSender)
        FocusMe(txtShipAdr2(Index))
    End Sub

    Private Sub txtShipAdr2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipAdr2.GetIndex(eventSender)

        Call chk_InpLen(txtShipAdr2(Index), 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 2
            txtShipAdr3(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr2.Leave
        Dim Index As Short = txtShipAdr2.GetIndex(eventSender)
        FocusMe(txtShipAdr2(Index), True)
    End Sub

    Private Sub txtShipAdr3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr3.Enter
        Dim Index As Short = txtShipAdr3.GetIndex(eventSender)
        FocusMe(txtShipAdr3(Index))
    End Sub

    Private Sub txtShipAdr3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipAdr3.GetIndex(eventSender)

        Call chk_InpLen(txtShipAdr3(Index), 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 2
            txtShipAdr4(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr3.Leave
        Dim Index As Short = txtShipAdr3.GetIndex(eventSender)
        FocusMe(txtShipAdr3(Index), True)
    End Sub

    Private Sub txtShipAdr4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr4.Enter
        Dim Index As Short = txtShipAdr4.GetIndex(eventSender)
        FocusMe(txtShipAdr4(Index))
    End Sub

    Private Sub txtShipAdr4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr4.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipAdr4.GetIndex(eventSender)

        Call chk_InpLen(txtShipAdr4(Index), 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipTelNo(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr4_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr4.Leave
        Dim Index As Short = txtShipAdr4.GetIndex(eventSender)
        FocusMe(txtShipAdr4(Index), True)
    End Sub




    Private Sub txtShipTelNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipTelNo.Enter
        Dim Index As Short = txtShipTelNo.GetIndex(eventSender)
        FocusMe(txtShipTelNo(Index))
    End Sub

    Private Sub txtShipTelNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipTelNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipTelNo.GetIndex(eventSender)

        Call chk_InpLen(txtShipTelNo(Index), 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipFaxNo(Index).Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipTelNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipTelNo.Leave
        Dim Index As Short = txtShipTelNo.GetIndex(eventSender)
        FocusMe(txtShipTelNo(Index), True)
    End Sub




    Private Sub txtShipFaxNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipFaxNo.Enter
        Dim Index As Short = txtShipFaxNo.GetIndex(eventSender)
        FocusMe(txtShipFaxNo(Index))
    End Sub

    Private Sub txtShipFaxNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipFaxNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = txtShipFaxNo.GetIndex(eventSender)

        Call chk_InpLen(txtShipFaxNo(Index), 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            If Index = 1 Then
                cboRmkCode.Focus()
            Else
                cboShipCode(Index + 1).Focus()
            End If

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipFaxNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipFaxNo.Leave
        Dim Index As Short = txtShipFaxNo.GetIndex(eventSender)
        FocusMe(txtShipFaxNo(Index), True)
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

            tabDetailInfo.SelectedIndex = 2
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
            tabDetailInfo.SelectedIndex = 2
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

        Call chk_InpLen(txtRmk(Index), 100, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Index = 10 Then
                tabDetailInfo.SelectedIndex = 0
                cboVdrCode.Focus()
            Else
                tabDetailInfo.SelectedIndex = 2
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

    Private Sub Get_ShipMark(ByRef inIndex As Short)

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "FROM  mstShip "
        wsSQL = wsSQL & "WHERE ShipCode = '" & Set_Quote(cboShipCode(inIndex).Text) & "'"
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPNAME). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipName(inIndex).Text = ReadRs(rsRcd, "SHIPNAME")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPPER). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipPer(inIndex).Text = ReadRs(rsRcd, "SHIPPER")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPADR1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr1(inIndex).Text = ReadRs(rsRcd, "SHIPADR1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPADR2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr2(inIndex).Text = ReadRs(rsRcd, "SHIPADR2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPADR3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr3(inIndex).Text = ReadRs(rsRcd, "SHIPADR3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPADR4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr4(inIndex).Text = ReadRs(rsRcd, "SHIPADR4")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPTELNO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipTelNo(inIndex).Text = ReadRs(rsRcd, "SHIPTELNO")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, SHIPFAXNO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipFaxNo(inIndex).Text = ReadRs(rsRcd, "SHIPFAXNO")

        Else
            txtShipName(inIndex).Text = ""
            txtShipPer(inIndex).Text = ""
            txtShipAdr1(inIndex).Text = ""
            txtShipAdr2(inIndex).Text = ""
            txtShipAdr3(inIndex).Text = ""
            txtShipAdr4(inIndex).Text = ""
            txtShipTelNo(inIndex).Text = ""
            txtShipFaxNo(inIndex).Text = ""

        End If
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
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

            For i = 1 To 10
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, RmkDESC & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                txtRmk(i).Text = ReadRs(rsRcd, "RmkDESC" & i)
            Next i

        Else

            For i = 1 To 10
                txtRmk(i).Text = ""
            Next i

        End If
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Sub

    Private Sub Get_DelName()

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim i As Short

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "FROM  mstWarehouse "
        wsSQL = wsSQL & "WHERE WhsCode = '" & Set_Quote(cboDelCode.Text) & "'"
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtDelName.Text = ReadRs(rsRcd, "WHSDESC")
        Else
            txtDelName.Text = ""

        End If
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Sub

    Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsCurRec As String
        Dim wsCurRecLn As String
        Dim wsCurRecLn2 As String

        Chk_NoDup = False

        wsCurRec = tblDetail.Columns(ITMCODE).Text
        wsCurRecLn = tblDetail.Columns(WHSCODE).Text
        wsCurRecLn2 = tblDetail.Columns(LOTNO).Text

        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If wsCurRec = waResult.get_Value(wlCtr, ITMCODE) And wsCurRecLn = waResult.get_Value(wlCtr, WHSCODE) And wsCurRecLn2 = waResult.get_Value(wlCtr, LOTNO) Then
                    gsMsg = "重覆物料於第 " & waResult.get_Value(wlCtr, LINENO) & " 行!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    Exit Function
                End If
            End If
        Next

        Chk_NoDup = True

    End Function

    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmPO001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
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
                    If Chk_PoExistGrDt(To_Value(.Bookmark)) = False Then Exit Sub
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
	
	Private Sub cmdPrint()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		Dim wsTitle As String
		
		
		'If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(4)
		wsSelection(1) = ""
		wsSelection(2) = ""
		wsSelection(3) = ""
		wsSelection(4) = ""
		
		If chkWorkOrder.CheckState = 1 Then
			If gsLangID = "2" Then
				wsTitle = "工作單"
			Else
				wsTitle = "WORK ORDER"
			End If
		Else
			wsTitle = wgsTitle
		End If
		
		
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTPO002 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & wsTitle & "', "
		wsSQL = wsSQL & "'" & wsTitle & "', "
		wsSQL = wsSQL & "'" & wsTrnCd & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
		wsSQL = wsSQL & "'" & "" & "', "
		wsSQL = wsSQL & "'" & New String("z", 10) & "', "
		wsSQL = wsSQL & "'" & "0000/00/00" & "', "
		wsSQL = wsSQL & "'" & "9999/99/99" & "', "
		wsSQL = wsSQL & "'" & "%" & "', "
		wsSQL = wsSQL & "'N', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTPO002"
		Else
			wsRptName = "RPTPO002"
		End If
		
		NewfrmPrint.ReportID = "PO002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "PO002"
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
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		If waResult.get_UpperBound(1) >= 0 Then
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then
					wsITMID = waResult.get_Value(wiCtr, ITMID)
					wdDisPer = waResult.get_Value(wiCtr, DisPer)
					'wdNewDisPer = Get_SaleDiscount(cboNatureCode.Text, wlVdrID, wsITMID)
					wdNewDisPer = To_Value(txtSpecDis)
					'    If wdDisPer <> wdNewDisPer Then
					waResult.get_Value(wiCtr, DisPer) = VB6.Format(wdNewDisPer, gsAmtFmt)
					waResult.get_Value(wiCtr, Dis) = VB6.Format(To_Value(waResult.get_Value(wiCtr, Amt)) * To_Value(waResult.get_Value(wiCtr, DisPer)) / 100, gsAmtFmt)
					waResult.get_Value(wiCtr, Disl) = VB6.Format(To_Value(waResult.get_Value(wiCtr, Amtl)) * To_Value(waResult.get_Value(wiCtr, DisPer)) / 100, gsAmtFmt)
					waResult.get_Value(wiCtr, NET) = VB6.Format(To_Value(waResult.get_Value(wiCtr, Amt)) * (1 - (To_Value(waResult.get_Value(wiCtr, DisPer)) / 100)), gsAmtFmt)
					waResult.get_Value(wiCtr, Netl) = VB6.Format(To_Value(waResult.get_Value(wiCtr, Amtl)) * (1 - (To_Value(waResult.get_Value(wiCtr, DisPer)) / 100)), gsAmtFmt)
					'    End If
				End If
			Next 
			
			tblDetail.ReBind()
			tblDetail.FirstRow = 0
			
			Call Calc_Total()
		End If
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	
	
	
	
	
	Private Function Chk_NoDup2(ByRef inRow As Integer, ByVal wsCurRec As String, ByVal wsCurRecLn As String, ByVal wsCurRecLn2 As String) As Boolean
		
		Dim wlCtr As Integer
		
		Chk_NoDup2 = False
		
		
		If wsFormID = "PN001" Then
			Chk_NoDup2 = True
			Exit Function
		End If
		
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = waResult.get_Value(wlCtr, ITMCODE) And wsCurRecLn = waResult.get_Value(wlCtr, WHSCODE) And wsCurRecLn2 = waResult.get_Value(wlCtr, LOTNO) Then
					gsMsg = "重覆物料於第 " & waResult.get_Value(wlCtr, LINENO) & " 行!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					inRow = To_Value(waResult.get_Value(wlCtr, LINENO))
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup2 = True
		
	End Function
	
	
	Private Function Chk_grdITMTYPE(ByRef inAccNo As String) As Boolean
		Dim wsSQL As String
		Dim rsDes As New ADODB.Recordset
		
		If wsFormID = "PN001" Then
			Chk_grdITMTYPE = True
			Exit Function
		End If
		
		
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
	Private Sub cmdRevise()
		
		
		On Error GoTo cmdRevise_Err
		
		
		'    If DelValidation(wlKey) = False Then
		'       wiAction = CorRec
		'       MousePointer = vbDefault
		'       Exit Sub
		'    End If
		
		
		gsMsg = "你是否確認要改正此檔案?"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Exit Sub
		End If
		
		wiAction = RevRec
		
		If cmdSave = True Then
			cboDocNo.Text = wsDocNo
			Call Ini_Scr_AfrKey()
		End If
		
		Exit Sub
		
cmdRevise_Err: 
		MsgBox(Err.Description)
		
	End Sub
	
	Private Function DelValidation(ByVal InDocID As Integer) As Boolean
		Dim OutTrnCd As String
		Dim OutDocNo As String
		
		
		
		DelValidation = False
		
		On Error GoTo DelValidation_Err
		
		
		
		'   If Not chk_txtRevNo Then Exit Function
		If Chk_PoRefDoc(CStr(InDocID), OutTrnCd, OutDocNo) = True Then
			
			Select Case OutTrnCd
				Case "GR"
					gsMsg = "進貨單 : " & OutDocNo & " 是以此採購轉為!不能刪除或改正"
				Case "PV"
					gsMsg = "供應商發票 : " & OutDocNo & " 是以此採購轉為!不能刪除或改正"
				Case "PR"
					gsMsg = "採購退貨單 : " & OutDocNo & " 是以此採購轉為!不能刪除或改正"
			End Select
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
			
		End If
		
		DelValidation = True
		
		Exit Function
		
DelValidation_Err: 
		gsMsg = Err.Description
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
	End Function
	Private Sub cmdRmkID(ByRef wiRow As Short, ByRef wsRmkID As String)
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		If wiRow >= 0 Then
			
			waResult.get_Value(wiRow, GDRMKID) = wsRmkID
			If To_Value(wsRmkID) = 0 Then
				waResult.get_Value(wiRow, GMORE) = "N"
			Else
				waResult.get_Value(wiRow, GMORE) = "Y"
			End If
			
			tblDetail.ReBind()
			tblDetail.Col = QTY
			tblDetail.Focus()
			
			
		End If
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	
	Private Function Chk_PoExistGrDt(ByVal CRow As Integer) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsDtID As String
		
		On Error GoTo Chk_PoExistGrDt_Err
		
		
		
		wsDtID = waResult.get_Value(CRow, ITMID)
		
		If wsDtID = "0" Then
			Chk_PoExistGrDt = True
			Exit Function
		End If
		
		
		wsSQL = "SELECT * FROM PopGrHd, PopGrDt "
		wsSQL = wsSQL & " WHERE GrDtPoID = " & To_Value(wlKey) & " "
		wsSQL = wsSQL & " AND GrDtItemID = " & To_Value(wsDtID) & " "
		wsSQL = wsSQL & " AND GrHDDocID = GrDtDocID "
		wsSQL = wsSQL & " AND GrHDStatus In ('1','4') "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			gsMsg = "不能更改或刪除!物料已進倉!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Chk_PoExistGrDt = False
			Exit Function
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		wsSQL = "SELECT * FROM PopPvHd, PopPvDt "
		wsSQL = wsSQL & " WHERE PvDtPoID = " & To_Value(wlKey) & " "
		wsSQL = wsSQL & " AND PvDtItemID = " & To_Value(wsDtID) & " "
		wsSQL = wsSQL & " AND PvHDDocID = PvDtDocID "
		wsSQL = wsSQL & " AND PvHDStatus In ('1','4') "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			gsMsg = "不能更改或刪除!物料出發票!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Chk_PoExistGrDt = False
			Exit Function
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_PoExistGrDt = True
		
		
		Exit Function
		
Chk_PoExistGrDt_Err: 
		gsMsg = Err.Description
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
	End Function
	Private Function Chk_PoExistGrDtQty(ByVal CRow As Integer, ByVal InQty As Double) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsDtID As String
		
		On Error GoTo Chk_PoExistGrDtQty_Err
		
		
		
		wsDtID = waResult.get_Value(CRow, ITMID)
		
		
		If wsDtID = "0" Then
			Chk_PoExistGrDtQty = True
			Exit Function
		End If
		
		
		wsSQL = "SELECT Sum(GrDtQty) QTY FROM PopGrHd, PopGrDt "
		wsSQL = wsSQL & " WHERE GrDtPoID = " & To_Value(wlKey) & " "
		wsSQL = wsSQL & " AND GrDtItemID = " & To_Value(wsDtID) & " "
		wsSQL = wsSQL & " AND GrHDDocID = GrDtDocID "
		wsSQL = wsSQL & " AND GrHDStatus In ('1','4') "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			If To_Value(InQty) < To_Value(ReadRs(rsRcd, "QTY")) Then
				gsMsg = "數量不足!物料已進倉!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Chk_PoExistGrDtQty = False
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_PoExistGrDtQty = True
		
		
		Exit Function
		
Chk_PoExistGrDtQty_Err: 
		gsMsg = Err.Description
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
	End Function
End Class