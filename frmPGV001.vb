Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmPGV001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	Private wsOldVdrNo As String
	Private wsOldCurCd As String
	Private wsOldShipCd As String
	Private wsOldRmkCd As String
	Private wsOldPayCd As String
	Private wbReadOnly As Boolean
	Private wgsTitle As String
	Private wsOldRefDocNo As String
	Private wbUpdCstOnly As Boolean
	
	Private Const LINENO As Short = 0
	Private Const ITMCODE As Short = 1
	Private Const ITMTYPE As Short = 2
	Private Const WHSCODE As Short = 3
	Private Const LOTNO As Short = 4
	Private Const ITMNAME As Short = 5
	Private Const PUBLISHER As Short = 6
	Private Const QTY As Short = 7
	Private Const PRICE As Short = 8
	Private Const DisPer As Short = 9
	Private Const Dis As Short = 10
	Private Const Amt As Short = 11
	Private Const NET As Short = 12
	Private Const Netl As Short = 13
	Private Const Disl As Short = 14
	Private Const Amtl As Short = 15
	Private Const ITMID As Short = 16
	Private Const POID As Short = 17
	
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
	Private wlRefDocID As Integer
	Private wlLineNo As Integer
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "popPvHd"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, LINENO, POID)
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
		Call SetDateMask(medETADate)
		
		wsOldRefDocNo = ""
		wsOldVdrNo = ""
		wsOldCurCd = ""
		wsOldShipCd = ""
		wsOldRmkCd = ""
		wsOldPayCd = ""
		
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
		
		' wbUpdCstOnly = False
		' Call Ini_UnLockGrid
		
		FocusMe(cboDocNo)
		tabDetailInfo.SelectedIndex = 0
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

        wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
        wsSQL = wsSQL & " FROM popPvHd, MstVendor "
        wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
        wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
        wsSQL = wsSQL & " AND PVHDSTATUS IN ('1','4')"
        wsSQL = wsSQL & " ORDER BY PVHDDOCNO DESC "
        Call Ini_Combo(3, wsSQL, VB6.PixelsToTwipsX(cboDocNo.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
            tabDetailInfo.SelectedIndex = 0
            cboDocNo.Focus()
            Exit Function
        End If


        If Chk_TrnHdDocNo(wsTrnCd, cboDocNo.Text, wsStatus) = True Then

            If wsStatus = "4" Then
                gsMsg = "文件已入數, 祇可以更新基本資料!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                wbReadOnly = True
            End If

            ' If wsStatus = "4" Then
            '     gsMsg = "文件已入數!現在以更正成本"
            '     MsgBox gsMsg, vbOKOnly, gsTitle
            '     Call Ini_LockGrid
            '     wbUpdCstOnly = True
            ' End If

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
            wiRevNo = CShort(VB6.Format(0, "##0"))
            medDocDate.Text = Dsp_Date(Now)

            Call SetButtonStatus("AfrKeyAdd")
            Call SetFieldStatus("AfrKey")
            cboRefDocNo.Focus()
        Else
            wiAction = CorRec
            If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
                gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                tblDetail.ReBind()
            End If

            wsOldVdrNo = cboVdrCode.Text
            wsOldCurCd = cboCurr.Text
            wsOldShipCd = cboShipCode.Text
            wsOldRmkCd = cboRmkCode.Text
            wsOldPayCd = cboPayCode.Text


            Call SetButtonStatus("AfrKeyEdit")
            Call SetFieldStatus("AfrKey")
            cboVdrCode.Focus()
        End If

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)

        If UCase(cboCurr.Text) = UCase(wsBaseCurCd) Then
            txtExcr.Text = VB6.Format("1", gsExrFmt)
            txtExcr.Enabled = False
        Else
            txtExcr.Enabled = True
        End If


        tabDetailInfo.SelectedIndex = 0


    End Sub

    'UPGRADE_WARNING: Form event frmPGV001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmPGV001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated

        If OpenDoc = True Then
            OpenDoc = False
            wcCombo = cboDocNo
            Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
        End If

    End Sub

    Private Sub frmPGV001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmPGV001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

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

        wsSQL = "SELECT PVHDDOCID, PVHDDOCNO, PVHDREFDOCID, PVHDVDRID, VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, "
        wsSQL = wsSQL & "PVHDDOCDATE, PVHDREVNO, PVHDCURR, PVHDEXCR, PVDTDOCLINE, "
        wsSQL = wsSQL & "PVHDDUEDATE, PVHDETADATE, PVHDDEPNO, PVHDDEPAMT, PVHDDEPML, PVHDPAYCODE, PVHDPRCCODE, PVHDSALEID, PVHDMLCODE, "
        wsSQL = wsSQL & "PVHDCUSPO, PVHDLCNO, PVHDPORTNO, PVHDSHIPPER, PVHDSHIPFROM, PVHDSHIPTO, PVHDSHIPVIA, PVHDSHIPNAME, "
        wsSQL = wsSQL & "PVHDSHIPCODE, PVHDSHIPADR1,  PVHDSHIPADR2,  PVHDSHIPADR3,  PVHDSHIPADR4, "
        wsSQL = wsSQL & "PVHDRMKCODE, PVHDRMK1,  PVHDRMK2,  PVHDRMK3,  PVHDRMK4, PVHDRMK5, "
        wsSQL = wsSQL & "PVHDRMK6,  PVHDRMK7,  PVHDRMK8,  PVHDRMK9, PVHDRMK10, "
        wsSQL = wsSQL & "PVHDGRSAMT , PVHDGRSAMTL, PVHDDISAMT, PVHDDISAMTL, PVHDNETAMT, PVHDNETAMTL, "
        wsSQL = wsSQL & "PVDTITEMID, ITMCODE, PVDTWHSCODE, PVDTLOTNO, ITMITMTYPECODE, PVDTITEMDESC ITNAME,  PVDTQTY, PVDTUPRICE, PVDTDISPER, PVDTAMT, PVDTAMTL, PVDTDIS, PVDTDISL, PVDTNET, PVDTNETL, "
        wsSQL = wsSQL & "PVDTPOID, PVHDSPECDIS "
        wsSQL = wsSQL & "FROM  popPVHd, popPVDT, MstVendor, mstITEM "
        wsSQL = wsSQL & "WHERE PVHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
        wsSQL = wsSQL & "AND PVHDDOCID = PVDTDOCID "
        wsSQL = wsSQL & "AND PVHDVDRID = VDRID "
        wsSQL = wsSQL & "AND PVDTITEMID = ITMID "
        wsSQL = wsSQL & "ORDER BY PVDTDOCLINE "

        rsInvoice.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsInvoice.RecordCount <= 0 Then
            rsInvoice.Close()
            'UPGRADE_NOTE: Object rsInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsInvoice = Nothing
            Exit Function
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = ReadRs(rsInvoice, "PVHDDOCID")
        wiRevNo = To_Value(ReadRs(rsInvoice, "PVHDREVNO"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medDocDate.Text = ReadRs(rsInvoice, "PVHDDOCDATE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlRefDocID = ReadRs(rsInvoice, "PVHDREFDOCID")
        cboRefDocNo.Text = Get_TableInfo("popPOHD", "POHDDOCID =" & wlRefDocID, "POHDDOCNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlVdrID = ReadRs(rsInvoice, "VDRID")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboVdrCode.Text = ReadRs(rsInvoice, "VDRCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrName.Text = ReadRs(rsInvoice, "VDRNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrTel.Text = ReadRs(rsInvoice, "VDRTEL")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrFax.Text = ReadRs(rsInvoice, "VDRFAX")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboCurr.Text = ReadRs(rsInvoice, "PVHDCURR")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtExcr.Text = VB6.Format(ReadRs(rsInvoice, "PVHDEXCR"), gsExrFmt)

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medDueDate.Text = Dsp_MedDate(ReadRs(rsInvoice, "PVHDDUEDATE"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medETADate.Text = Dsp_MedDate(ReadRs(rsInvoice, "PVHDETADATE"))

        wlSaleID = To_Value(ReadRs(rsInvoice, "PVHDSALEID"))

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPayCode.Text = ReadRs(rsInvoice, "PVHDPAYCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPrcCode.Text = ReadRs(rsInvoice, "PVHDPRCCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboMLCode.Text = ReadRs(rsInvoice, "PVHDMLCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboShipCode.Text = ReadRs(rsInvoice, "PVHDSHIPCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboRmkCode.Text = ReadRs(rsInvoice, "PVHDRMKCODE")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtCusPo.Text = ReadRs(rsInvoice, "PVHDCUSPO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtLcNo.Text = ReadRs(rsInvoice, "PVHDLCNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtPortNo.Text = ReadRs(rsInvoice, "PVHDPORTNO")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtSpecDis.Text = VB6.Format(ReadRs(rsInvoice, "PVHDSPECDIS"), gsExrFmt)
        txtDisAmt.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "PVHDDISAMT")), gsAmtFmt)


        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipFrom.Text = ReadRs(rsInvoice, "PVHDSHIPFROM")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipTo.Text = ReadRs(rsInvoice, "PVHDSHIPTO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipVia.Text = ReadRs(rsInvoice, "PVHDSHIPVIA")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipName.Text = ReadRs(rsInvoice, "PVHDSHIPNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipPer.Text = ReadRs(rsInvoice, "PVHDSHIPPER")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr1.Text = ReadRs(rsInvoice, "PVHDSHIPADR1")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr2.Text = ReadRs(rsInvoice, "PVHDSHIPADR2")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr3.Text = ReadRs(rsInvoice, "PVHDSHIPADR3")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr4.Text = ReadRs(rsInvoice, "PVHDSHIPADR4")

        Dim i As Short

        For i = 1 To 10
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, PVHDRMK & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtRmk(i).Text = ReadRs(rsInvoice, "PVHDRMK" & i)
        Next i


        cboSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
        lblDspSaleDesc.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")

        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")
        lblDspPrcDesc.Text = Get_TableInfo("mstPriceTerm", "PrcCode ='" & Set_Quote(cboPrcCode.Text) & "'", "PRCDESC")
        lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")

        rsInvoice.MoveFirst()
        With waResult
            .ReDim(0, -1, LINENO, POID)
            Do While Not rsInvoice.EOF
                wiCtr = wiCtr + 1
                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), LINENO) = ReadRs(rsInvoice, "PVDTDOCLINE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsInvoice, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMTYPE) = ReadRs(rsInvoice, "ITMITMTYPECODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMNAME) = ReadRs(rsInvoice, "ITNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), WHSCODE) = ReadRs(rsInvoice, "PVDTWHSCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), LOTNO) = ReadRs(rsInvoice, "PVDTLOTNO")
                waResult.get_Value(.get_UpperBound(1), PUBLISHER) = ""
                'waResult(.UpperBound(1), Qty) = Format(ReadRs(rsInvoice, "PVDTQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), QTY) = VB6.Format(ReadRs(rsInvoice, "PVDTQTY"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), PRICE) = VB6.Format(ReadRs(rsInvoice, "PVDTUPRICE"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), DisPer) = VB6.Format(ReadRs(rsInvoice, "PVDTDISPER"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Amt) = VB6.Format(ReadRs(rsInvoice, "PVDTAMT"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Amtl) = VB6.Format(ReadRs(rsInvoice, "PVDTAMTL"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Dis) = VB6.Format(ReadRs(rsInvoice, "PVDTDIS"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Disl) = VB6.Format(ReadRs(rsInvoice, "PVDTDISL"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), NET) = VB6.Format(ReadRs(rsInvoice, "PVDTNET"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), Netl) = VB6.Format(ReadRs(rsInvoice, "PVDTNETL"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsInvoice, "PVDTITEMID")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), POID) = ReadRs(rsInvoice, "PVDTPOID")

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
        Call Get_Scr_Item("TOOLTIP_M", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
        lblRefDocNo.Text = Get_Caption(waScrItm, "REFNO")
        lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
        lblVdrCode.Text = Get_Caption(waScrItm, "VDRCODE")
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
        lblETADate.Text = Get_Caption(waScrItm, "ETADATE")

        lblGrsAmtOrg.Text = Get_Caption(waScrItm, "GRSAMTORG")
        lblNetAmtOrg.Text = Get_Caption(waScrItm, "NETAMTORG")
        lblDisAmtOrg.Text = Get_Caption(waScrItm, "DISAMTORG")
        lblTotalQty.Text = Get_Caption(waScrItm, "TOTALQTY")

        With tblDetail
            .Columns(LINENO).Caption = Get_Caption(waScrItm, "LINENO")
            .Columns(ITMCODE).Caption = Get_Caption(waScrItm, "ITMCODE")
            .Columns(ITMTYPE).Caption = Get_Caption(waScrItm, "ITMTYPE")
            .Columns(WHSCODE).Caption = Get_Caption(waScrItm, "WHSCODE")
            .Columns(LOTNO).Caption = Get_Caption(waScrItm, "LOTNO")
            .Columns(ITMNAME).Caption = Get_Caption(waScrItm, "ITMNAME")
            .Columns(PUBLISHER).Caption = Get_Caption(waScrItm, "PUBLISHER")
            .Columns(QTY).Caption = Get_Caption(waScrItm, "QTY")
            .Columns(PRICE).Caption = Get_Caption(waScrItm, "PRICE")
            .Columns(DisPer).Caption = Get_Caption(waScrItm, "DISPER")
            .Columns(Dis).Caption = Get_Caption(waScrItm, "DIS")
            .Columns(NET).Caption = Get_Caption(waScrItm, "NET")
            .Columns(Amt).Caption = Get_Caption(waScrItm, "AMT")
        End With

        tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO01")
        tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO02")
        tabDetailInfo.TabPages.Item(2).Text = Get_Caption(waScrItm, "TABDETAILINFO03")

        lblShipFrom.Text = Get_Caption(waScrItm, "SHIPFROM")
        lblShipTo.Text = Get_Caption(waScrItm, "SHIPTO")
        lblShipVia.Text = Get_Caption(waScrItm, "SHIPVIA")
        lblShipCode.Text = Get_Caption(waScrItm, "SHIPCODE")
        lblShipPer.Text = Get_Caption(waScrItm, "SHIPPER")
        lblShipAdr.Text = Get_Caption(waScrItm, "SHIPADR")
        lblCusPo.Text = Get_Caption(waScrItm, "CUSPO")
        lblLcNo.Text = Get_Caption(waScrItm, "LCNO")
        lblPortNo.Text = Get_Caption(waScrItm, "PORTNO")
        lblShipName.Text = Get_Caption(waScrItm, "SHIPNAME")
        lblRmkCode.Text = Get_Caption(waScrItm, "RMKCODE")
        lblRmk.Text = Get_Caption(waScrItm, "RMK")

        lblSpecDis.Text = Get_Caption(waScrItm, "SPECDIS")
        lblDisAmt.Text = Get_Caption(waScrItm, "DISAMTORG")
        btnGetDisAmt.Text = Get_Caption(waScrItm, "GETDISAMT")

        '  btnSOLST.Caption = Get_Caption(waScrItm, "POLIST")

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

        wsActNam(1) = Get_Caption(waScrItm, "PVADD")
        wsActNam(2) = Get_Caption(waScrItm, "PVEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "PVDELETE")
        wgsTitle = Get_Caption(waScrItm, "TITLE")


        Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub

    Private Sub frmPGV001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        '    If Button = 2 Then
        '        PopupMenu mnuMaster
        '    End If

    End Sub

    'UPGRADE_WARNING: Event frmPGV001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmPGV001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub

    Private Sub frmPGV001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

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
        'UPGRADE_NOTE: Object frmPGV001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
                medETADate.Focus()
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

    Private Function Chk_medETADate() As Boolean
        Chk_medETADate = False

        If Trim(medETADate.Text) = "/  /" Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medETADate.Focus()
            Exit Function
        End If

        If Chk_Date(medETADate) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medETADate.Focus()
            Exit Function
        End If

        Chk_medETADate = True

    End Function

    Private Sub medETADate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medETADate.Enter
        FocusMe(medETADate)
    End Sub

    Private Sub medETADate_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medETADate.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Chk_medETADate Then
                tabDetailInfo.SelectedIndex = 0
                Me.txtSpecDis.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub medETADate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medETADate.Leave
        FocusMe(medETADate, True)
    End Sub

    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then

            If cboVdrCode.Enabled Then
                cboVdrCode.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 1 Then

            If tblDetail.Enabled Then
                tblDetail.Col = ITMCODE
                tblDetail.Focus()
            End If

        ElseIf tabDetailInfo.SelectedIndex = 2 Then

            If cboShipCode.Enabled Then
                cboShipCode.Focus()
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

        Dim rspopPVHd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT PVHDSTATUS FROM popPvHd WHERE PVHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "'"
        rspopPVHd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rspopPVHd.RecordCount > 0 Then

            Chk_KeyExist = True

        Else

            Chk_KeyExist = False

        End If

        rspopPVHd.Close()
        'UPGRADE_NOTE: Object rspopPVHd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rspopPVHd = Nothing
    End Function

    Private Function Chk_KeyFld() As Boolean
        Chk_KeyFld = False

        If Chk_cboRefDocNo = False Then
            Exit Function
        End If

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
            If ReadOnlyMode(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID) Or wbReadOnly Then
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
        '    gsMsg = "已超過信貸額!"
        '    MsgBox gsMsg, vbOKOnly, gsTitle
        '    MousePointer = vbDefault
        '    Exit Function
        'End If

        wlRowCtr = waResult.get_UpperBound(1)
        wsCtlPrd = VB.Left(medDocDate.Text, 4) & Mid(medDocDate.Text, 6, 2)

        'If wbReadOnly = True Then
        'wiAction = CorRO
        'End If

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_PGV001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wlKey)
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, wlVdrID)
        Call SetSPPara(adcmdSave, 6, medDocDate.Text)
        Call SetSPPara(adcmdSave, 7, wiRevNo)
        Call SetSPPara(adcmdSave, 8, cboCurr.Text)
        Call SetSPPara(adcmdSave, 9, txtExcr.Text)
        Call SetSPPara(adcmdSave, 10, wsCtlPrd)

        Call SetSPPara(adcmdSave, 11, Set_MedDate((medDueDate.Text)))
        Call SetSPPara(adcmdSave, 12, Set_MedDate((medETADate.Text)))

        Call SetSPPara(adcmdSave, 13, wlSaleID)

        Call SetSPPara(adcmdSave, 14, cboPayCode.Text)
        Call SetSPPara(adcmdSave, 15, cboPrcCode.Text)
        Call SetSPPara(adcmdSave, 16, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 17, cboShipCode.Text)
        Call SetSPPara(adcmdSave, 18, cboRmkCode.Text)

        Call SetSPPara(adcmdSave, 19, txtCusPo.Text)
        Call SetSPPara(adcmdSave, 20, txtLcNo.Text)
        Call SetSPPara(adcmdSave, 21, txtPortNo.Text)

        Call SetSPPara(adcmdSave, 22, "")
        Call SetSPPara(adcmdSave, 23, txtSpecDis.Text)
        Call SetSPPara(adcmdSave, 24, "")

        Call SetSPPara(adcmdSave, 25, txtShipFrom.Text)
        Call SetSPPara(adcmdSave, 26, txtShipTo.Text)
        Call SetSPPara(adcmdSave, 27, txtShipVia.Text)
        Call SetSPPara(adcmdSave, 28, txtShipPer.Text)
        Call SetSPPara(adcmdSave, 29, txtShipName.Text)
        Call SetSPPara(adcmdSave, 30, txtShipAdr1.Text)
        Call SetSPPara(adcmdSave, 31, txtShipAdr2.Text)
        Call SetSPPara(adcmdSave, 32, txtShipAdr3.Text)
        Call SetSPPara(adcmdSave, 33, txtShipAdr4.Text)

        For i = 1 To 10
            Call SetSPPara(adcmdSave, 34 + i - 1, txtRmk(i).Text)
        Next

        Call SetSPPara(adcmdSave, 44, lblDspGrsAmtOrg)
        Call SetSPPara(adcmdSave, 45, lblDspDisAmtOrg)
        Call SetSPPara(adcmdSave, 46, lblDspNetAmtOrg)
        Call SetSPPara(adcmdSave, 47, wlRefDocID)

        Call SetSPPara(adcmdSave, 48, wsFormID)

        Call SetSPPara(adcmdSave, 49, gsUserID)
        Call SetSPPara(adcmdSave, 50, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 51)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 52)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        ' If wbReadOnly = False Then

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_PGV001B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, cboRefDocNo.Text)
                    Call SetSPPara(adcmdSave, 4, To_Value(waResult.get_Value(wiCtr, POID)))
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, ITMID))
                    Call SetSPPara(adcmdSave, 6, wiCtr + 1)
                    Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, ITMNAME))
                    Call SetSPPara(adcmdSave, 8, waResult.get_Value(wiCtr, QTY))
                    Call SetSPPara(adcmdSave, 9, waResult.get_Value(wiCtr, PRICE))
                    Call SetSPPara(adcmdSave, 10, waResult.get_Value(wiCtr, DisPer))
                    Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, WHSCODE))
                    Call SetSPPara(adcmdSave, 12, waResult.get_Value(wiCtr, LOTNO))
                    Call SetSPPara(adcmdSave, 13, waResult.get_Value(wiCtr, Amt))
                    Call SetSPPara(adcmdSave, 14, waResult.get_Value(wiCtr, Amtl))
                    Call SetSPPara(adcmdSave, 15, waResult.get_Value(wiCtr, Dis))
                    Call SetSPPara(adcmdSave, 16, waResult.get_Value(wiCtr, Disl))
                    Call SetSPPara(adcmdSave, 17, waResult.get_Value(wiCtr, NET))
                    Call SetSPPara(adcmdSave, 18, waResult.get_Value(wiCtr, Netl))
                    Call SetSPPara(adcmdSave, 19, IIf(wlRowCtr = wiCtr, "Y", "N"))
                    Call SetSPPara(adcmdSave, 20, gsUserID)
                    Call SetSPPara(adcmdSave, 21, wsGenDte)
                    adcmdSave.Execute()



                End If
            Next
        End If
        ' End If
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


        InputValidation = False

        On Error GoTo InputValidation_Err



        If Not Chk_medDocDate Then Exit Function
        If Not Chk_cboRefDocNo Then Exit Function

        If Not chk_cboVdrCode() Then Exit Function
        If Not getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) Then Exit Function
        If Not chk_txtExcr Then Exit Function

        If Not Chk_cboSaleCode Then Exit Function
        If Not Chk_cboPayCode Then Exit Function
        If Not Chk_cboPrcCode Then Exit Function
        If Not Chk_cboMLCode Then Exit Function

        If Not Chk_medDueDate Then Exit Function

        If Not Chk_txtSpecDis Then Exit Function
        If Not chk_txtDisAmt Then Exit Function

        If Not Chk_cboShipCode Then Exit Function
        If Not Chk_cboRmkCode Then Exit Function


        If Not Chk_txtCusPo Then Exit Function

        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, ITMCODE)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tabDetailInfo.SelectedIndex = 1
                        tblDetail.Col = ITMCODE
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
            gsMsg = "沒有詳細資料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tabDetailInfo.SelectedIndex = 1
                tblDetail.Col = ITMCODE
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

        Dim newForm As New frmPGV001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmPGV001

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
        wsFormID = "PGV001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsTrnCd = "PV"
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


    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click, _tbrProcess_Button15.Click, _tbrProcess_Button16.Click
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

    Private Sub cboRefDocNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboRefDocNo.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboRefDocNo

        wsSQL = "SELECT POHDDOCNO, POHDDOCDATE , VDRCODE, VDRNAME FROM popPOHd, mstVendor "
        wsSQL = wsSQL & " WHERE POHDSTATUS = '1' "
        wsSQL = wsSQL & " AND POHDVDRID = VDRID "
        wsSQL = wsSQL & " AND POHDDOCNO LIKE '%" & IIf(cboRefDocNo.SelectionLength > 0, "", Set_Quote(cboRefDocNo.Text)) & "%' "
        wsSQL = wsSQL & " AND POHDPGMNO <> 'PN001' "
        wsSQL = wsSQL & " ORDER BY POHDDOCNO "

        Call Ini_Combo(4, wsSQL, VB6.PixelsToTwipsX(cboRefDocNo.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboRefDocNo.Top) + VB6.PixelsToTwipsY(cboRefDocNo.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLPONO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

            If wiAction = AddRec And wsOldRefDocNo <> cboRefDocNo.Text Then Call Get_RefDoc()
            If Trim(cboVdrCode.Text) = "" Then
                tabDetailInfo.SelectedIndex = 0
                cboVdrCode.Focus()
                GoTo EventExitSub
            End If
            If Chk_KeyFld Then
                tabDetailInfo.SelectedIndex = 0
                cboSaleCode.Focus()
            End If
        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_cboRefDocNo() As Boolean

        Dim wsStatus As String
        Dim wsPgmNo As String

        Chk_cboRefDocNo = False

        If Trim(cboRefDocNo.Text) = "" Then
            Chk_cboRefDocNo = True
            wlRefDocID = 0
            Exit Function
        End If

        If Chk_PoHdDocNo(cboRefDocNo.Text, wsStatus, wsPgmNo) = True Then

            '    If wsStatus = "4" Then
            '        gsMsg = "文件已入數!"
            '        MsgBox gsMsg, vbOKOnly, gsTitle
            '        Exit Function
            '    End If

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



            If wsPgmNo = "PN001" Then
                gsMsg = "文件類別不同!不能開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                tabDetailInfo.SelectedIndex = 0
                cboRefDocNo.Focus()
                wlRefDocID = 0
                Exit Function
            End If

        End If

        Chk_cboRefDocNo = True

    End Function

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
                cboCurr.Focus()
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
            gsMsg = "必需輸入供應商編碼!"
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
        wsSQL = wsSQL & "FROM MstVendor "
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
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipName.Text = ReadRs(rsDefVal, "VDRSHIPTO")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipPer.Text = ReadRs(rsDefVal, "VDRSHIPCONTACTPERSON")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr1.Text = ReadRs(rsDefVal, "VDRSHIPADD1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr2.Text = ReadRs(rsDefVal, "VDRSHIPADD2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr3.Text = ReadRs(rsDefVal, "VDRSHIPADD3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr4.Text = ReadRs(rsDefVal, "VDRSHIPADD4")

        Else
            cboCurr.Text = ""
            cboPayCode.Text = ""
            cboMLCode.Text = ""
            wlSaleID = 0
            txtShipName.Text = ""
            txtShipPer.Text = ""
            txtShipAdr1.Text = ""
            txtShipAdr2.Text = ""
            txtShipAdr3.Text = ""
            txtShipAdr4.Text = ""

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

        cboSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
        lblDspSaleDesc.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")
        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")

        'get Due Date Payment Term
        medDueDate.Text = Dsp_Date(Get_DueDte(cboPayCode.Text, medDocDate.Text))

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
        Dim wsWhsCode As String
        Dim wdQty As Double
        Dim wsPoId As String

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
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Chk_grdITMCODE((.Columns(eventArgs.ColIndex).Text), wsITMID, wsITMCODE, wsITMTYPE, wsITMNAME, wsPub, wdPrice, wdDisPer, wsWhsCode, wsLotNo, wdQty) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If
                    .Columns(LINENO).Text = CStr(wlLineNo)
                    .Columns(ITMID).Text = wsITMID
                    .Columns(ITMNAME).Text = wsITMNAME
                    .Columns(ITMTYPE).Text = wsITMTYPE
                    .Columns(PUBLISHER).Text = wsPub
                    .Columns(WHSCODE).Text = wsWhsCode
                    .Columns(LOTNO).Text = wsLotNo
                    .Columns(PRICE).Text = VB6.Format(wdPrice, gsAmtFmt)
                    .Columns(QTY).Text = VB6.Format(wdQty, gsQtyFmt)
                    .Columns(DisPer).Text = VB6.Format(wdDisPer, gsAmtFmt)
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

                Case WHSCODE
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    '    If Chk_grdWhsCode(.Columns(ColIndex).Text) = False Then
                    '            GoTo Tbl_BeforeColUpdate_Err
                    '    End If
                Case LOTNO
                    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    '   If Chk_grdLotNo(.Columns(ColIndex).Text) = False Then
                    '           GoTo Tbl_BeforeColUpdate_Err
                    '   End If


                Case QTY, PRICE, DisPer

                    If eventArgs.ColIndex = QTY Then
                        If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
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

        On Error GoTo tblDetail_ButtonClick_Err


        With tblDetail
            Select Case eventArgs.ColIndex

                Case ITMCODE

                    If Trim(cboRefDocNo.Text) = "" Then


                        wsSQL = "SELECT ITMCODE, ITMITMTYPECODE, ITMENGNAME, ITMCHINAME "
                        wsSQL = wsSQL & " FROM mstITEM, mstVdrItem "
                        wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' "
                        wsSQL = wsSQL & " AND VDRITEMSTATUS <> '2' "
                        wsSQL = wsSQL & " AND ITMINACTIVE = 'N' "
                        wsSQL = wsSQL & " AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
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

                        '    wsSQL = "SELECT ITMCODE, ITMITMTYPECODE, ITMENGNAME, ITMCHINAME "
                        '    wsSQL = wsSQL & "FROM mstITEM "
                        '    wsSQL = wsSQL & "WHERE ITMSTATUS <> '2' "
                        '    wsSQL = wsSQL & "AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
                        '    wsSQL = wsSQL & " ORDER BY ITMCODE "

                    Else

                        wsSQL = "SELECT ITMCODE, ITMITMTYPECODE, ITMENGNAME, ITMCHINAME "
                        wsSQL = wsSQL & "FROM mstITEM, popPODT "
                        wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(.Columns(ITMCODE).Text) & "%' "
                        wsSQL = wsSQL & " AND PODTDOCID = " & wlRefDocID & " "
                        wsSQL = wsSQL & " AND PODTITEMID = ITMID "
                        wsSQL = wsSQL & " ORDER BY ITMCODE "

                    End If

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
                    ' If wbUpdCstOnly = True Then Exit Sub
                    If .Bookmark = waResult.get_UpperBound(1) Then Exit Sub
                    If IsEmptyRow Then Exit Sub
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    waResult.InsertRows(IIf(IsDbNull(.Bookmark), 0, .Bookmark))
                    .ReBind()
                    .Focus()

                Case System.Windows.Forms.Keys.F8 ' DELETE LINE
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    '  If wbUpdCstOnly = True Then Exit Sub
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
                        Case LINENO
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = ITMCODE
                        Case ITMCODE
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
                        Case NET
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = ITMCODE
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case ITMTYPE
                            .Col = ITMCODE
                        Case ITMNAME
                            .Col = ITMTYPE
                        Case QTY
                            .Col = ITMNAME
                        Case PRICE
                            .Col = QTY
                        Case DisPer
                            .Col = PRICE
                        Case NET
                            .Col = DisPer
                    End Select

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case LINENO
                            .Col = ITMCODE
                        Case ITMCODE
                            .Col = ITMTYPE
                        Case ITMTYPE
                            .Col = ITMNAME
                        Case ITMNAME
                            .Col = QTY
                        Case QTY
                            .Col = PRICE
                        Case PRICE
                            .Col = DisPer
                        Case DisPer
                            .Col = NET
                    End Select
            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent

        Select Case tblDetail.Col

            '   Case Qty
            '       Call Chk_InpNum(KeyAscii, tblDetail.Text, False, False)

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
                .Col = ITMCODE
            End If

            Call Calc_Total()

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case ITMCODE
                        Call Chk_grdITMCODE((.Columns(ITMCODE).Text), "", "", "", "", "", 0, 0, "", "", 0)
                    Case WHSCODE
                        '   Call Chk_grdWhsCode(.Columns(WHSCODE).Text)
                    Case LOTNO
                        '   Call Chk_grdLotNo(.Columns(LOTNO).Text)
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

    Private Function Chk_grdITMCODE(ByRef inAccNo As String, ByRef outAccID As String, ByRef outAccNo As String, ByRef OutItmType As String, ByRef OutName As String, ByRef outPub As String, ByRef outPrice As Double, ByRef outDisPer As Double, ByRef outWhsCode As String, ByRef outLotNo As String, ByRef outQty As Double) As Boolean
        Dim wsSQL As String
        Dim rsDes As New ADODB.Recordset
        Dim wsCurr As String
        Dim wsExcr As String


        If Trim(inAccNo) = "" Then
            gsMsg = "沒有輸入物料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
            Exit Function
        End If

        If wlRefDocID = 0 Then

            'wsSQL = "SELECT ITMID ITEMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME, ITMITMTYPECODE, ITMBOTTOMPRICE PRICE, ITMUNITPRICE UPRICE, ITMCURR CURR, 0 DISPER, ITMPVDRID VDRID "
            'wsSQL = wsSQL & " FROM mstITEM "
            'wsSQL = wsSQL & " WHERE ITMCODE = '" & Set_Quote(inAccNo) & "' "
            'wsSQL = wsSQL & " AND ITMSTATUS <> '2' "

            wsSQL = "SELECT ITMID ITEMID, ITMCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME, ITMITMTYPECODE, VDRITEMCOST PRICE, 1 BALQTY, 0 DISPER, VDRITEMCURR CURR "
            wsSQL = wsSQL & " FROM mstITEM, mstVdrItem "
            wsSQL = wsSQL & " WHERE ITMSTATUS <> '2' "
            wsSQL = wsSQL & " AND VDRITEMSTATUS <> '2' "
            wsSQL = wsSQL & " AND ITMINACTIVE = 'N' "
            wsSQL = wsSQL & " AND ITMCODE = '" & Set_Quote(inAccNo) & "' "
            wsSQL = wsSQL & " AND ITMID = VDRITEMITMID "
            wsSQL = wsSQL & " AND VDRITEMCURR = '" & Set_Quote(cboCurr.Text) & "' "
            wsSQL = wsSQL & " AND VDRITEMVDRID = " & To_Value(wlVdrID) & " "


        Else

            wsSQL = "SELECT PODTITEMID ITEMID, ITMCODE, PODTITEMDESC ITNAME, ITMITMTYPECODE, PODTUPRICE PRICE, ITMUNITPRICE UPRICE, POHDCURR CURR, PODTDISPER DISPER, POHDVDRID VDRID, PODTBALQTY BALQTY "
            wsSQL = wsSQL & " FROM mstITEM, popPOHD, popPODT "
            wsSQL = wsSQL & " WHERE POHDDOCID = PODTDOCID "
            wsSQL = wsSQL & " AND PODTITEMID = ITMID "
            wsSQL = wsSQL & " AND POHDDOCID = " & wlRefDocID & " "
            wsSQL = wsSQL & " AND ITMCODE = '" & Set_Quote(inAccNo) & "' "

        End If
        rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccID = ReadRs(rsDes, "ITEMID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccNo = ReadRs(rsDes, "ITMCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsDes, "ITNAME")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutItmType = ReadRs(rsDes, "ITMITMTYPECODE")
            outPub = ""
            outPrice = To_Value(ReadRs(rsDes, "PRICE"))

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wsCurr = ReadRs(rsDes, "CURR")

            outWhsCode = ""
            outLotNo = ""
            outQty = To_Value(ReadRs(rsDes, "BALQTY"))

            If cboCurr.Text <> wsCurr Then
                If getExcRate(wsCurr, medDocDate.Text, wsExcr, "") = True Then
                    outPrice = CDbl(NBRnd(outPrice * To_Value(wsExcr) / CDbl(txtExcr.Text), giUprDp))
                End If
            End If

            outDisPer = To_Value(ReadRs(rsDes, "DISPER"))

            Chk_grdITMCODE = True
        Else
            outAccID = ""
            OutName = ""
            OutItmType = ""
            outPub = ""
            outPrice = 0
            outDisPer = 0
            outLotNo = ""
            outWhsCode = ""
            outQty = 0
            gsMsg = "沒有此物料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
        End If
        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing

    End Function
    Private Function Chk_grdOrdItm(ByRef inPoNo As Integer, ByRef inItmNo As String, ByRef inWhsCode As String, ByRef InLotNo As String) As Boolean

        Dim wsSQL As String
        Dim rsDes As New ADODB.Recordset


        If To_Value(inPoNo) = 0 Then
            Chk_grdOrdItm = True
            Exit Function
        End If

        wsSQL = "SELECT PODTITEMID "
        wsSQL = wsSQL & " FROM mstITEM, popPOHD, popPODT "
        wsSQL = wsSQL & " WHERE POHDDOCID = PODTDOCID "
        wsSQL = wsSQL & " AND PODTITEMID = ITMID "
        wsSQL = wsSQL & " AND POHDDOCID = " & To_Value(inPoNo) & " "
        wsSQL = wsSQL & " AND ITMCODE = '" & Set_Quote(inItmNo) & "' "
        wsSQL = wsSQL & " AND POHDSTATUS NOT IN ('2' , '3')"

        rsDes.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            Chk_grdOrdItm = True
        Else
            gsMsg = "沒有此書!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdOrdItm = False
        End If
        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing

    End Function

    Private Function Chk_grdPoNo(ByRef inPoNo As String, ByRef outPoID As String) As Boolean

        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset

        Chk_grdPoNo = False

        outPoID = "0"

        wsSQL = "SELECT POHDDOCID, POHDDOCNO, POHDDOCDATE FROM popPOHD "
        wsSQL = wsSQL & " WHERE POHDSTATUS = '1' "
        wsSQL = wsSQL & " AND POHDDOCNO = '" & inPoNo & "' "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            gsMsg = "沒有此訂單!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        outPoID = CStr(To_Value(ReadRs(rsRcd, "POHDDOCID")))

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        Chk_grdPoNo = True

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

        ' If To_Value(inCode) = 0 Then
        '     gsMsg = "單價必需大於零!"
        '     MsgBox gsMsg, vbOKOnly, gsTitle
        '     Chk_grdUPrice = False
        '     Exit Function
        ' End If

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
                If Trim(.Columns(ITMCODE).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, ITMCODE)) = "" And Trim(waResult.get_Value(inRow, ITMNAME)) = "" And Trim(waResult.get_Value(inRow, PUBLISHER)) = "" And Trim(waResult.get_Value(inRow, QTY)) = "" And Trim(waResult.get_Value(inRow, PRICE)) = "" And Trim(waResult.get_Value(inRow, DisPer)) = "" And Trim(waResult.get_Value(inRow, Amt)) = "" And Trim(waResult.get_Value(inRow, Amtl)) = "" And Trim(waResult.get_Value(inRow, Dis)) = "" And Trim(waResult.get_Value(inRow, Disl)) = "" And Trim(waResult.get_Value(inRow, NET)) = "" And Trim(waResult.get_Value(inRow, Netl)) = "" And Trim(waResult.get_Value(inRow, ITMID)) = "" Then
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


            If Chk_grdITMCODE(waResult.get_Value(LastRow, ITMCODE), "", "", "", "", "", 0, 0, "", "", 0) = False Then
                .Col = ITMCODE
                .Row = LastRow
                Exit Function
            End If

            ' If Chk_grdWhsCode(waResult(LastRow, WHSCODE)) = False Then
            '         .Col = WHSCODE
            '         .Row = LastRow
            '         Exit Function
            ' End If

            ' If Chk_grdLotNo(waResult(LastRow, LOTNO)) = False Then
            '         .Col = LOTNO
            '         .Row = LastRow
            '         Exit Function
            ' End If


            If Chk_grdQty(waResult.get_Value(LastRow, QTY)) = False Then
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

            If Chk_grdOrdItm(wlRefDocID, waResult.get_Value(LastRow, ITMCODE), waResult.get_Value(LastRow, WHSCODE), waResult.get_Value(LastRow, LOTNO)) = False Then
                .Col = ITMCODE
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
            '   wiTotalDis = wiTotalDis
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
        Dim adcmdDelete As New ADODB.Command
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
        adcmdDelete.ActiveConnection = cnCon

        adcmdDelete.CommandText = "USP_PGV001A"
        adcmdDelete.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdDelete.Parameters.Refresh()

        Call SetSPPara(adcmdDelete, 1, wiAction)
        Call SetSPPara(adcmdDelete, 2, wsTrnCd)
        Call SetSPPara(adcmdDelete, 3, wlKey)
        Call SetSPPara(adcmdDelete, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdDelete, 5, wlVdrID)
        Call SetSPPara(adcmdDelete, 6, medDocDate.Text)
        Call SetSPPara(adcmdDelete, 7, wiRevNo)
        Call SetSPPara(adcmdDelete, 8, cboCurr.Text)
        Call SetSPPara(adcmdDelete, 9, txtExcr.Text)
        Call SetSPPara(adcmdDelete, 10, "")

        Call SetSPPara(adcmdDelete, 11, Set_MedDate((medDueDate.Text)))
        Call SetSPPara(adcmdDelete, 12, Set_MedDate((medETADate.Text)))

        Call SetSPPara(adcmdDelete, 13, wlSaleID)

        Call SetSPPara(adcmdDelete, 14, cboPayCode.Text)
        Call SetSPPara(adcmdDelete, 15, cboPrcCode.Text)
        Call SetSPPara(adcmdDelete, 16, cboMLCode.Text)
        Call SetSPPara(adcmdDelete, 17, cboShipCode.Text)
        Call SetSPPara(adcmdDelete, 18, cboRmkCode.Text)

        Call SetSPPara(adcmdDelete, 19, txtCusPo.Text)
        Call SetSPPara(adcmdDelete, 20, txtLcNo.Text)
        Call SetSPPara(adcmdDelete, 21, txtPortNo.Text)

        Call SetSPPara(adcmdDelete, 22, "")
        Call SetSPPara(adcmdDelete, 23, txtSpecDis.Text)
        Call SetSPPara(adcmdDelete, 24, "")


        Call SetSPPara(adcmdDelete, 25, txtShipFrom.Text)
        Call SetSPPara(adcmdDelete, 26, txtShipTo.Text)
        Call SetSPPara(adcmdDelete, 27, txtShipVia.Text)
        Call SetSPPara(adcmdDelete, 28, txtShipPer.Text)
        Call SetSPPara(adcmdDelete, 29, txtShipName.Text)
        Call SetSPPara(adcmdDelete, 30, txtShipAdr1.Text)
        Call SetSPPara(adcmdDelete, 31, txtShipAdr2.Text)
        Call SetSPPara(adcmdDelete, 32, txtShipAdr3.Text)
        Call SetSPPara(adcmdDelete, 33, txtShipAdr4.Text)

        For i = 1 To 10
            Call SetSPPara(adcmdDelete, 34 + i - 1, txtRmk(i).Text)
        Next

        Call SetSPPara(adcmdDelete, 44, lblDspGrsAmtOrg)
        Call SetSPPara(adcmdDelete, 45, lblDspDisAmtOrg)
        Call SetSPPara(adcmdDelete, 46, lblDspNetAmtOrg)
        Call SetSPPara(adcmdDelete, 47, wlRefDocID)

        Call SetSPPara(adcmdDelete, 48, wsFormID)

        Call SetSPPara(adcmdDelete, 49, gsUserID)
        Call SetSPPara(adcmdDelete, 50, wsGenDte)
        adcmdDelete.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdDelete, 51)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdDelete, 52)

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




    '-- Set field status, Default, Add, Edit.
    Public Sub SetFieldStatus(ByVal sStatus As String)
        Select Case sStatus
            Case "Default"

                Me.cboDocNo.Enabled = False
                Me.cboRefDocNo.Enabled = False
                Me.cboVdrCode.Enabled = False

                Me.medDocDate.Enabled = False
                Me.cboCurr.Enabled = False
                Me.txtExcr.Enabled = False

                Me.medDueDate.Enabled = False
                Me.medETADate.Enabled = False

                Me.cboSaleCode.Enabled = False
                Me.cboPayCode.Enabled = False
                Me.cboPrcCode.Enabled = False
                Me.cboMLCode.Enabled = False
                Me.cboShipCode.Enabled = False
                Me.cboRmkCode.Enabled = False
                Me.txtShipFrom.Enabled = False
                Me.txtShipTo.Enabled = False
                Me.txtShipPer.Enabled = False
                Me.txtShipVia.Enabled = False
                Me.txtShipName.Enabled = False
                Me.txtShipAdr1.Enabled = False
                Me.txtShipAdr2.Enabled = False
                Me.txtShipAdr3.Enabled = False
                Me.txtShipAdr4.Enabled = False


                Me.txtCusPo.Enabled = False
                Me.txtLcNo.Enabled = False
                Me.txtPortNo.Enabled = False

                Me.picRmk.Enabled = False

                Me.tblDetail.Enabled = False

                Me.txtSpecDis.Enabled = False
                Me.txtDisAmt.Enabled = False
                Me.btnGetDisAmt.Enabled = False

            Case "AfrActAdd"

                Me.cboDocNo.Enabled = True
                Me.cboRefDocNo.Enabled = True

            Case "AfrActEdit"

                Me.cboDocNo.Enabled = True


            Case "AfrKey"
                Me.cboDocNo.Enabled = False

                If wiAction = AddRec Then
                    Me.cboRefDocNo.Enabled = True
                Else
                    Me.cboRefDocNo.Enabled = False
                End If


                Me.cboVdrCode.Enabled = True

                Me.medDocDate.Enabled = True
                Me.cboCurr.Enabled = True
                Me.txtExcr.Enabled = True

                Me.medDueDate.Enabled = True
                Me.medETADate.Enabled = True

                Me.cboSaleCode.Enabled = True
                Me.cboPayCode.Enabled = True
                Me.cboPrcCode.Enabled = True
                Me.cboMLCode.Enabled = True
                Me.cboShipCode.Enabled = True
                Me.cboRmkCode.Enabled = True
                Me.txtShipFrom.Enabled = True
                Me.txtShipTo.Enabled = True
                Me.txtShipPer.Enabled = True
                Me.txtShipVia.Enabled = True
                Me.txtShipName.Enabled = True
                Me.txtShipAdr1.Enabled = True
                Me.txtShipAdr2.Enabled = True
                Me.txtShipAdr3.Enabled = True
                Me.txtShipAdr4.Enabled = True

                Me.txtCusPo.Enabled = True
                Me.txtLcNo.Enabled = True
                Me.txtPortNo.Enabled = True



                Me.picRmk.Enabled = True

                Me.txtSpecDis.Enabled = True
                Me.txtDisAmt.Enabled = True
                Me.btnGetDisAmt.Enabled = True

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
            .TableKey = "IVHDDocNo"
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
        vFilterAry(1, 2) = "IVHDDocNo"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "Doc. Date"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "IVHDDocDate"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "Vendor #"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "VdrCode"

        Dim vAry(4, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "Doc No."
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "IVHDDocNo"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "Date"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "IVHDDocDate"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 1) = "Vendor #"
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
            wsSQL = "SELECT popPvHd.PVHDDocNo, popPvHd.PVHDDocDate, MstVendor.VdrCode,  MstVendor.VdrName "
            wsSQL = wsSQL & "FROM MstVendor, popPvHd "
            .sBindSQL = wsSQL
            .sBindWhereSQL = "WHERE popPvHd.PVHDStatus = '1' And popPvHD.PVHDVdrID = MstVendor.VdrID "
            .sBindOrderSQL = "ORDER BY popPvHD.PVHDDocNo"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmPGV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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



    Private Sub txtShipFrom_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipFrom.Enter
        FocusMe(txtShipFrom)
    End Sub

    Private Sub txtShipFrom_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipFrom.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipFrom, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtShipTo.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipFrom_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipFrom.Leave
        FocusMe(txtShipFrom, True)
    End Sub

    Private Sub txtShipTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipTo.Enter
        FocusMe(txtShipTo)
    End Sub

    Private Sub txtShipTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipTo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 0
            txtShipVia.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipTo.Leave
        FocusMe(txtShipTo, True)
    End Sub

    Private Sub txtShipVia_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipVia.Enter
        FocusMe(txtShipVia)
    End Sub

    Private Sub txtShipVia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipVia.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipVia, 20, KeyAscii)

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

    Private Sub txtShipVia_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipVia.Leave
        FocusMe(txtShipVia, True)
    End Sub

    Private Sub txtCusPo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCusPo.Enter
        FocusMe(txtCusPo)
    End Sub

    Private Sub txtCusPo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCusPo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtCusPo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtCusPo = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0
            txtLcNo.Focus()

        End If

EventExitSub:
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
                tblDetail.Col = ITMCODE
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

    Private Sub cboShipCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.Enter

        FocusMe(cboShipCode)

    End Sub

    Private Sub cboShipCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.Leave
        FocusMe(cboShipCode, True)
    End Sub


    Private Sub cboShipCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboShipCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)



        Call chk_InpLen(cboShipCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboShipCode = False Then
                GoTo EventExitSub
            End If

            If wsOldShipCd <> cboShipCode.Text Then
                Get_ShipMark()
                wsOldShipCd = cboShipCode.Text
            End If


            tabDetailInfo.SelectedIndex = 2
            txtShipPer.Focus()
        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboShipCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboShipCode.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboShipCode

        wsSQL = "SELECT ShipCode, ShipName, ShipPer FROM mstShip WHERE ShipCode LIKE '%" & IIf(cboShipCode.SelectionLength > 0, "", Set_Quote(cboShipCode.Text)) & "%' "
        wsSQL = wsSQL & "AND ShipSTATUS = '1' "
        wsSQL = wsSQL & "AND ShipCardID = " & wlVdrID & " "
        wsSQL = wsSQL & "ORDER BY ShipCode "
        Call Ini_Combo(3, wsSQL, VB6.PixelsToTwipsX(cboShipCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboShipCode.Top) + VB6.PixelsToTwipsY(cboShipCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLSHIPCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function Chk_cboShipCode() As Boolean

        Chk_cboShipCode = False

        If Trim(cboShipCode.Text) = "" Then
            Chk_cboShipCode = True
            Exit Function
        End If


        If Chk_Ship(cboShipCode.Text) = False Then
            gsMsg = "沒有此貨運編碼!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboShipCode.Focus()
            Exit Function
        End If


        Chk_cboShipCode = True

    End Function

    Private Sub txtShipName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipName.Enter
        FocusMe(txtShipName)
    End Sub

    Private Sub txtShipName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipName, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipAdr1.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipName.Leave
        FocusMe(txtShipName, True)
    End Sub

    Private Sub txtShipPer_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipPer.Enter
        FocusMe(txtShipPer)
    End Sub

    Private Sub txtShipPer_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipPer.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipPer, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipName.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipPer_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipPer.Leave
        FocusMe(txtShipPer, True)
    End Sub

    Private Sub txtShipAdr1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr1.Enter
        FocusMe(txtShipAdr1)
    End Sub

    Private Sub txtShipAdr1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipAdr1, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipAdr2.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr1.Leave
        FocusMe(txtShipAdr1, True)
    End Sub

    Private Sub txtShipAdr2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr2.Enter
        FocusMe(txtShipAdr2)
    End Sub

    Private Sub txtShipAdr2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipAdr2, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipAdr3.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr2.Leave
        FocusMe(txtShipAdr2, True)
    End Sub

    Private Sub txtShipAdr3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr3.Enter
        FocusMe(txtShipAdr3)
    End Sub

    Private Sub txtShipAdr3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipAdr3, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            tabDetailInfo.SelectedIndex = 2
            txtShipAdr4.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr3.Leave
        FocusMe(txtShipAdr3, True)
    End Sub

    Private Sub txtShipAdr4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr4.Enter
        FocusMe(txtShipAdr4)
    End Sub

    Private Sub txtShipAdr4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtShipAdr4.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(txtShipAdr4, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            If Chk_KeyFld = True Then
                tabDetailInfo.SelectedIndex = 2
                cboRmkCode.Focus()
            End If

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtShipAdr4_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipAdr4.Leave
        FocusMe(txtShipAdr4, True)
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



    Private Sub Get_ShipMark()

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "FROM  mstShip "
        wsSQL = wsSQL & "WHERE ShipCode = '" & Set_Quote(cboShipCode.Text) & "'"
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipName.Text = ReadRs(rsRcd, "SHIPNAME")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipPer.Text = ReadRs(rsRcd, "SHIPPER")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr1.Text = ReadRs(rsRcd, "SHIPADR1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr2.Text = ReadRs(rsRcd, "SHIPADR2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr3.Text = ReadRs(rsRcd, "SHIPADR3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr4.Text = ReadRs(rsRcd, "SHIPADR4")

        Else
            txtShipName.Text = ""
            txtShipPer.Text = ""
            txtShipAdr1.Text = ""
            txtShipAdr2.Text = ""
            txtShipAdr3.Text = ""
            txtShipAdr4.Text = ""


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


    Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsCurRecLn As String
        Dim wsCurRecLn2 As String
        Dim wsCurRecLn3 As String

        Chk_NoDup = False

        wsCurRecLn = tblDetail.Columns(ITMCODE).Text
        wsCurRecLn2 = tblDetail.Columns(WHSCODE).Text
        wsCurRecLn3 = tblDetail.Columns(LOTNO).Text


        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If wsCurRecLn = waResult.get_Value(wlCtr, ITMCODE) And wsCurRecLn2 = waResult.get_Value(wlCtr, WHSCODE) And wsCurRecLn3 = waResult.get_Value(wlCtr, LOTNO) Then
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
            'UPGRADE_ISSUE: Form method frmPGV001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
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
                    ' If wbUpdCstOnly = True Then Exit Sub
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
                    ' If wbUpdCstOnly = True Then Exit Sub
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
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = False
                    .Items.Item(tcCancel).Enabled = False
                    .Items.Item(tcFind).Enabled = True
                    .Items.Item(tcExit).Enabled = True
                    .Items.Item(tcRefresh).Enabled = False
                    .Items.Item(tcPrint).Enabled = False
                    .Items.Item(tcRevise).Enabled = False
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
        wsSQL = "EXEC usp_RPTPGV002 '" & Set_Quote(gsUserID) & "', "
        wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
        wsSQL = wsSQL & "'" & wgsTitle & "', "
        wsSQL = wsSQL & "'" & wgsTitle & "', "
        wsSQL = wsSQL & "'PV', "
        wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
        wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
        wsSQL = wsSQL & "'" & "" & "', "
        wsSQL = wsSQL & "'" & New String("z", 10) & "', "
        wsSQL = wsSQL & "'" & "000000" & "', "
        wsSQL = wsSQL & "'" & "999999" & "', "
        wsSQL = wsSQL & "'" & "%" & "', "
        wsSQL = wsSQL & "'N', "
        wsSQL = wsSQL & gsLangID


        If gsLangID = "2" Then
            wsRptName = "C" & "RPTPGV002"
        Else
            wsRptName = "RPTPGV002"
        End If

        NewfrmPrint.ReportID = "PGV002"
        NewfrmPrint.RptTitle = Me.Text
        NewfrmPrint.TableID = "PGV002"
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
                    wdDisPer = waResult.get_Value(wiCtr, DisPer)
                    'wdNewDisPer = Get_SaleDiscount(cboNatureCode.Text, wlVdrID, wsITMID)
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

    Private Function Get_RefDoc() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wsExcRate As String
        Dim wsExcDesc As String
        Dim wiCtr As Integer
        Dim wdBalQty As Double

        Get_RefDoc = False

        wsSQL = "SELECT POHDDOCID, POHDDOCNO, POHDVDRID, VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, "
        wsSQL = wsSQL & "POHDDOCDATE, POHDREVNO, POHDCURR, POHDEXCR, POHDETADATE, "
        wsSQL = wsSQL & "POHDDUEDATE, POHDPRCCODE, POHDSALEID, POHDMLCODE, "
        wsSQL = wsSQL & "POHDCUSPO, POHDLCNO, POHDREFNO, POHDSHIPPER, POHDSHIPFROM, POHDSHIPTO, POHDSHIPVIA, POHDSHIPNAME, "
        wsSQL = wsSQL & "POHDSHIPCODE, POHDSHIPADR1,  POHDSHIPADR2,  POHDSHIPADR3,  POHDSHIPADR4, "
        wsSQL = wsSQL & "POHDRMKCODE, POHDRMK1,  POHDRMK2,  POHDRMK3,  POHDRMK4, POHDRMK5, "
        wsSQL = wsSQL & "POHDRMK6,  POHDRMK7,  POHDRMK8,  POHDRMK9, POHDRMK10, "
        wsSQL = wsSQL & "POHDGRSAMT , POHDGRSAMTL, POHDDISAMT, POHDDISAMTL, POHDNETAMT, POHDNETAMTL, "
        wsSQL = wsSQL & "PODTITEMID, ITMCODE, PODTWHSCODE, PODTLOTNO, ITMITMTYPECODE, PODTITEMDESC ITNAME, ITMPUBLISHER,  PODTBALQTY, PODTUPRICE, PODTDISPER, PODTAMT, PODTAMTL, PODTDIS, PODTDISL, PODTNET, PODTNETL, "
        wsSQL = wsSQL & "PODTID, PODTDOCLINE, POHDSPECDIS "
        wsSQL = wsSQL & "FROM  popPOHD, popPODT, MstVendor, mstITEM "
        wsSQL = wsSQL & "WHERE POHDDOCNO = '" & Set_Quote(cboRefDocNo.Text) & "' "
        wsSQL = wsSQL & "AND POHDDOCID = PODTDOCID "
        wsSQL = wsSQL & "AND POHDVDRID = VDRID "
        wsSQL = wsSQL & "AND PODTITEMID = ITMID "
        wsSQL = wsSQL & "ORDER BY PODTDOCLINE "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        wsOldRefDocNo = cboRefDocNo.Text
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlRefDocID = ReadRs(rsRcd, "POHDDOCID")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlVdrID = ReadRs(rsRcd, "VDRID")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboVdrCode.Text = ReadRs(rsRcd, "VDRCODE")
        wsOldVdrNo = cboVdrCode.Text
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrName.Text = ReadRs(rsRcd, "VDRNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrTel.Text = ReadRs(rsRcd, "VDRTEL")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspVdrFax.Text = ReadRs(rsRcd, "VDRFAX")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboCurr.Text = ReadRs(rsRcd, "POHDCURR")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtExcr.Text = VB6.Format(ReadRs(rsRcd, "POHDEXCR"), gsExrFmt)

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medDueDate.Text = Dsp_MedDate(ReadRs(rsRcd, "POHDDUEDATE"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medETADate.Text = Dsp_MedDate(ReadRs(rsRcd, "POHDETADATE"))

        wlSaleID = To_Value(ReadRs(rsRcd, "POHDSALEID"))

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPayCode.Text = ReadRs(rsRcd, "POHDPAYCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPrcCode.Text = ReadRs(rsRcd, "POHDPRCCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboMLCode.Text = ReadRs(rsRcd, "POHDMLCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboShipCode.Text = ReadRs(rsRcd, "POHDSHIPCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboRmkCode.Text = ReadRs(rsRcd, "POHDRMKCODE")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtCusPo.Text = ReadRs(rsRcd, "POHDCUSPO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtLcNo.Text = ReadRs(rsRcd, "POHDLCNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtPortNo.Text = ReadRs(rsRcd, "POHDREFNO")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtSpecDis.Text = VB6.Format(ReadRs(rsRcd, "POHDSPECDIS"), gsExrFmt)

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipFrom.Text = ReadRs(rsRcd, "POHDSHIPFROM")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipTo.Text = ReadRs(rsRcd, "POHDSHIPTO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipVia.Text = ReadRs(rsRcd, "POHDSHIPVIA")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipName.Text = ReadRs(rsRcd, "POHDSHIPNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipPer.Text = ReadRs(rsRcd, "POHDSHIPPER")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr1.Text = ReadRs(rsRcd, "POHDSHIPADR1")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr2.Text = ReadRs(rsRcd, "POHDSHIPADR2")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr3.Text = ReadRs(rsRcd, "POHDSHIPADR3")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr4.Text = ReadRs(rsRcd, "POHDSHIPADR4")

        Dim i As Short

        For i = 1 To 10
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, POHDRMK & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtRmk(i).Text = ReadRs(rsRcd, "POHDRMK" & i)
        Next i

        cboSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
        lblDspSaleDesc.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")

        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")
        lblDspPrcDesc.Text = Get_TableInfo("mstPriceTerm", "PrcCode ='" & Set_Quote(cboPrcCode.Text) & "'", "PRCDESC")
        lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")

        wsOldVdrNo = cboVdrCode.Text
        wsOldCurCd = cboCurr.Text
        wsOldShipCd = cboShipCode.Text
        wsOldRmkCd = cboRmkCode.Text
        wsOldPayCd = cboPayCode.Text


        rsRcd.MoveFirst()
        With waResult
            .ReDim(0, -1, LINENO, POID)
            Do While Not rsRcd.EOF
                wiCtr = wiCtr + 1

                '   wdBalQty = Get_PoBalQty(wsTrnCd, 0, ReadRs(rsRcd, "POHDDOCID"), ReadRs(rsRcd, "PODTITEMID"), ReadRs(rsRcd, "PODTWHSCODE"), ReadRs(rsRcd, "PODTLOTNO"))

                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), LINENO) = ReadRs(rsRcd, "PODTDOCLINE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsRcd, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMNAME) = ReadRs(rsRcd, "ITNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), WHSCODE) = ReadRs(rsRcd, "PODTWHSCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), LOTNO) = ReadRs(rsRcd, "PODTLOTNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), PUBLISHER) = ReadRs(rsRcd, "ITMPUBLISHER")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), QTY) = VB6.Format(ReadRs(rsRcd, "PODTBALQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), PRICE) = VB6.Format(ReadRs(rsRcd, "PODTUPRICE"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), DisPer) = VB6.Format(ReadRs(rsRcd, "PODTDISPER"), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), Amt) = VB6.Format(To_Value(ReadRs(rsRcd, "PODTUPRICE")) * To_Value(ReadRs(rsRcd, "PODTBALQTY")), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), Amtl) = VB6.Format(To_Value(ReadRs(rsRcd, "PODTUPRICE")) * To_Value(ReadRs(rsRcd, "PODTBALQTY")) * To_Value((txtExcr.Text)), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), Dis) = VB6.Format(waResult.get_Value(.get_UpperBound(1), Amt) * To_Value(ReadRs(rsRcd, "PODTDISPER")) / 100, gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), Disl) = VB6.Format(waResult.get_Value(.get_UpperBound(1), Amtl) * To_Value(ReadRs(rsRcd, "PODTDISPER")) / 100, gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), NET) = VB6.Format(waResult.get_Value(.get_UpperBound(1), Amt) * (1 - To_Value(ReadRs(rsRcd, "PODTDISPER")) / 100), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), Netl) = VB6.Format(waResult.get_Value(.get_UpperBound(1), Amtl) * (1 - To_Value(ReadRs(rsRcd, "PODTDISPER")) / 100), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsRcd, "PODTITEMID")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), POID) = ReadRs(rsRcd, "POHDDOCID")

                rsRcd.MoveNext()
            Loop

            wlLineNo = waResult.get_Value(.get_UpperBound(1), LINENO) + 1

        End With
        tblDetail.ReBind()
        tblDetail.FirstRow = 0
        rsRcd.Close()

        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        Call Calc_Total()

        Get_RefDoc = True

    End Function

    Private Function Chk_NoDup2(ByRef inRow As Integer, ByVal wsCurRecLn As String, ByVal wsCurRecLn2 As String, ByVal wsCurRecLn3 As String) As Boolean
        Dim wlCtr As Integer

        Chk_NoDup2 = False

        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If wsCurRecLn = waResult.get_Value(wlCtr, ITMCODE) And wsCurRecLn2 = waResult.get_Value(wlCtr, WHSCODE) And wsCurRecLn3 = waResult.get_Value(wlCtr, LOTNO) Then
                    gsMsg = "重覆物料於第 " & waResult.get_Value(wlCtr, LINENO) & " 行!"
                    MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                    inRow = To_Value(waResult.get_Value(wlCtr, LINENO))
                    Exit Function
                End If
            End If
        Next

        Chk_NoDup2 = True

    End Function


    Private Sub cmdRevise()


        On Error GoTo cmdRevise_Err

        If wbReadOnly Then
            gsMsg = "記錄已被鎖定, 不能改正此檔案!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Sub
        End If



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
            txtShipName.Focus()

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
	
	Private Sub Ini_Grid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = True
			.MultipleLines = 0
			.AllowAddNew = True
			.AllowUpdate = True
			.AllowDelete = True
			' .AlternatingRowStyle = True
			.RecordSelectors = False
			.AllowColMove = False
			.AllowColSelect = False
			
			For wiCtr = LINENO To POID
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
						.Columns(wiCtr).Width = 2500
						.Columns(wiCtr).Button = True
						.Columns(wiCtr).DataWidth = 30
					Case ITMTYPE
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).DataWidth = 13
						.Columns(wiCtr).Locked = True
					Case WHSCODE
						.Columns(wiCtr).Width = 1200
						.Columns(wiCtr).Button = True
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Visible = False
					Case LOTNO
						.Columns(wiCtr).Width = 1000
						'.Columns(wiCtr).Button = True
						.Columns(wiCtr).DataWidth = 20
						.Columns(wiCtr).Visible = False
					Case ITMNAME
						.Columns(wiCtr).Width = 3000
						.Columns(wiCtr).DataWidth = 60
						.Columns(wiCtr).Locked = True
					Case PUBLISHER
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).DataWidth = 50
						.Columns(wiCtr).Locked = True
						.Columns(wiCtr).Visible = False
					Case QTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
					Case PRICE
						.Columns(wiCtr).Width = 1000
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
					Case ITMID
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Visible = False
					Case POID
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Visible = False
				End Select
			Next 
			' .Styles("EvenRow").BackColor = &H8000000F
		End With
		
	End Sub
	
	
	Private Sub Ini_LockGrid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = False
			.AllowAddNew = False
			.AllowDelete = False
			
			For wiCtr = LINENO To POID
				.Columns(wiCtr).Locked = True
				
				Select Case wiCtr
					Case LINENO
						.Columns(wiCtr).Locked = True
					Case ITMCODE
						.Columns(wiCtr).Button = False
					Case ITMTYPE
						.Columns(wiCtr).Button = False
					Case ITMNAME
						.Columns(wiCtr).Locked = True
					Case NET
						.Columns(wiCtr).Locked = True
					Case PRICE
						.Columns(wiCtr).Locked = False
				End Select
			Next 
			' .Styles("EvenRow").BackColor = &H8000000F
		End With
		
	End Sub
	Private Sub Ini_UnLockGrid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = True
			.AllowAddNew = True
			.AllowDelete = True
			
			For wiCtr = LINENO To POID
				.Columns(wiCtr).Locked = False
				
				Select Case wiCtr
					Case LINENO
						.Columns(wiCtr).Locked = True
					Case ITMCODE
						.Columns(wiCtr).Button = True
					Case ITMTYPE
						.Columns(wiCtr).Button = True
					Case ITMNAME
						.Columns(wiCtr).Locked = True
					Case NET
						.Columns(wiCtr).Locked = True
				End Select
				
			Next 
			' .Styles("EvenRow").BackColor = &H8000000F
		End With
		
	End Sub
	
	
	Private Function Chk_txtCusPo() As Boolean
		
		Dim wsUsed As String
		
		Chk_txtCusPo = False
		
		If Trim(txtCusPo.Text) = "" Then
			gsMsg = "必需輸入文件號!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtCusPo.Focus()
			Exit Function
		End If
		
		
		If Chk_DupCusPO(wsTrnCd, cboDocNo.Text, txtCusPo.Text, wsUsed) = True Then
			gsMsg = wsUsed & "已用此文件號!不能使用"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			txtCusPo.Focus()
			Exit Function
		End If
		
		Chk_txtCusPo = True
		
	End Function
End Class