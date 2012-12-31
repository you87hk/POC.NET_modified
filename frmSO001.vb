Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSO001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waItem As New XArrayDBObject.XArrayDB
	
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	Private wsOldCusNo As String
	Private wsOldCurCd As String
	Private wsOldShipCd As String
	Private wsOldRmkCd As String
	Private wsOldPayCd As String
	Private wbReadOnly As Boolean
	Private wgsTitle As String
	Private wbUpdate As Boolean
	
	Private Const GLINENO As Short = 0
	Private Const GDESC1 As Short = 1
	Private Const GMORE As Short = 2
	Private Const GQTY As Short = 3
	Private Const GUOM As Short = 4
	Private Const GBOM As Short = 5
	Private Const GPRICE As Short = 6
	Private Const GDISPER As Short = 7
	Private Const GMARKUP As Short = 8
	Private Const GAMT As Short = 9
	Private Const GNET As Short = 10
	Private Const GPRINT As Short = 11
	Private Const GUCST As Short = 12
	Private Const GCST As Short = 13
	Private Const GDRMKID As Short = 14
	Private Const GPTJID As Short = 15
	
	
	
	Private Const SLINENO As Short = 0
	'UPGRADE_NOTE: SLN was upgraded to SLN_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Const SLN_Renamed As Short = 1
	Private Const SINDENT As Short = 2
	Private Const SITMTYPE As Short = 3
	Private Const SITMCODE As Short = 4
	Private Const SVDRCODE As Short = 5
	Private Const SITMNAME As Short = 6
	Private Const SQTY As Short = 7
	Private Const SUCST As Short = 8
	Private Const SCST As Short = 9
	Private Const SUNITPRICE As Short = 10
	Private Const SDISPER As Short = 11
	Private Const SAMT As Short = 12
	Private Const SNET As Short = 13
	Private Const SDTID As Short = 14
	Private Const SVDRID As Short = 15
	Private Const SITMID As Short = 16
	Private Const SSOID As Short = 17
	
	
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
	Private Const tcAppendix As String = "Appendix"
	
	
	Private wiOpenDoc As Short
	Private wiAction As Short
	Private wiRevNo As Short
	Private wlCusID As Integer
	Private wlSaleID As Integer
	Private wlLineNo As Integer
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "SOASOHD"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, GLINENO, GPTJID)
		waItem.ReDim(0, -1, SLINENO, SSOID)
		
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
		Call SetDateMask(medReserveDate)
		Call SetDateMask(medExpiryDate)
		
		
		wsOldCusNo = ""
		wsOldCurCd = ""
		wsOldShipCd = ""
		wsOldRmkCd = ""
		wsOldPayCd = ""
		
		
		wlKey = 0
		wlCusID = 0
		wlSaleID = 0
		wlLineNo = 1
		txtSpecDis.Text = VB6.Format("0", gsAmtFmt)
		txtDisAmt.Text = VB6.Format("0", gsAmtFmt)
		wbReadOnly = False
		
		wbUpdate = False
		
		wiRevNo = CShort(VB6.Format(0, "##0"))
		tblCommon.Visible = False
		
		lblRevNo.Visible = False
		lblDspRevNo.Visible = False
		lblDspCstAmtOrg.Visible = False
		
		Me.Text = wsFormCaption
		
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
	
	Private Sub cboCusCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCode.Leave
		FocusMe(cboCusCode, True)
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

        wsSQL = "SELECT SOHDDOCNO, CUSCODE, SOHDSHIPFROM, CUSNAME, SOHDDOCDATE "
        wsSQL = wsSQL & " FROM SOASOHD, mstCUSTOMER "
        wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNo.SelectionLength > 0, "", Set_Quote(cboDocNo.Text)) & "%' "
        wsSQL = wsSQL & " AND SOHDCUSID  = CUSID "
        wsSQL = wsSQL & " AND SOHDSTATUS IN ('1','4') "
        wsSQL = wsSQL & " AND SOHDCTLPRD BETWEEN '" & Str(Val(VB.Left(gsSystemDate, 4)) - 1) & "01" & "' AND '" & VB.Left(gsSystemDate, 4) & "12" & "'"
        wsSQL = wsSQL & " ORDER BY SOHDDOCNO DESC "
        Call Ini_Combo(5, wsSQL, VB6.PixelsToTwipsX(cboDocNo.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboDocNo.Top) + VB6.PixelsToTwipsY(cboDocNo.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

            If Chk_SoReady(cboDocNo.Text) = True Then
                gsMsg = "文件已封存(Ready), 現在以唯讀模式開啟!請以密碼解封"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                wbReadOnly = True
            End If


        End If


        Chk_cboDocNo = True

    End Function




    Private Sub Ini_Scr_AfrKey()



        If LoadRecord() = False Then
            wiAction = AddRec
            lblDspRevNo.Text = VB6.Format(0, "##0")
            '  txtRevNo.Enabled = False
            medDocDate.Text = Dsp_Date(Now)
            medReserveDate.Text = medDocDate.Text
            medExpiryDate.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.WeekOfYear, 6, CDate(medDocDate.Text)), "yyyy/mm/dd")

            Call SetButtonStatus("AfrKeyAdd")
        Else
            wiAction = CorRec
            If RowLock(wsConnTime, wsKeyType, cboDocNo.Text, wsFormID, wsUsrId) = False Then
                gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                tblDetail.ReBind()
            End If
            '   txtRevNo.Enabled = True
            wsOldCusNo = cboCusCode.Text
            wsOldCurCd = cboCurr.Text
            wsOldShipCd = cboShipCode.Text
            wsOldRmkCd = cboRmkCode.Text
            wsOldPayCd = cboPayCode.Text


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
        cboCusCode.Focus()

    End Sub



    'UPGRADE_WARNING: Form event frmSO001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmSO001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated

        If OpenDoc = True Then
            OpenDoc = False
            wcCombo = cboDocNo
            Call cboDocNo_DropDown(cboDocNo, New System.EventArgs())
        End If

    End Sub


    Private Sub frmSO001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub frmSO001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

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

        wsSQL = "SELECT SOHDDOCID, SOHDDOCNO, SOHDCUSID, CUSID, CUSCODE, CUSNAME, CUSTEL, CUSFAX, CUSEMAIL, SOPTJDOCLINE,"
        wsSQL = wsSQL & "SOHDDOCDATE, SOHDREVNO, SOHDCURR, SOHDEXCR, SOHDCORRNO, "
        wsSQL = wsSQL & "SOHDRESERVEDATE, SOHDEXPIRYDATE, SOHDPAYCODE, SOHDPRCCODE, SOHDSALEID, SOHDMLCODE, SOHDSPECDIS, SOHDNATURECODE, "
        wsSQL = wsSQL & "SOHDCUSPO, SOHDLCNO, SOHDPORTNO, SOHDSHIPPER, SOHDSHIPFROM, SOHDSHIPTO, SOHDSHIPVIA, SOHDSHIPNAME, "
        wsSQL = wsSQL & "SOHDSHIPCODE, SOHDSHIPADR1,  SOHDSHIPADR2,  SOHDSHIPADR3,  SOHDSHIPADR4, "
        wsSQL = wsSQL & "SOHDRMKCODE, SOHDRMK1,  SOHDRMK2,  SOHDRMK3,  SOHDRMK4, SOHDRMK5, SOHDAPRFLG, "
        wsSQL = wsSQL & "SOHDRMK6,  SOHDRMK7,  SOHDRMK8,  SOHDRMK9, SOHDRMK10, "
        wsSQL = wsSQL & "SOHDGRSAMT , SOHDGRSAMTL, SOHDDISAMT, SOHDDISAMTL, SOHDNETAMT, SOHDNETAMTL, "
        wsSQL = wsSQL & "SOPTJID, SOPTJLNTYPE, SOPTJITEMID, SOPTJDESC1, SOPTJDESC2, SOPTJDESC3, SOPTJDESC4, SOPTJQTY, SOPTJUPRICE, SOPTJUCST, SOPTJDISPER, "
        wsSQL = wsSQL & "SOPTJAMT, SOPTJAMTL, SOPTJDIS, SOPTJDISL, SOPTJNET, SOPTJNETL, SOPTJCST, SOPTJCSTL, SOPTJMARKUP, SOPTJUOM, SOPTJDPRICE, SOPTJDRMKID, SOHDJOBNO, JOBCOST, SOPTJPRTFLG "
        wsSQL = wsSQL & "FROM  SOASOHD, SOASOPTJ, mstCUSTOMER, MSTJOBNO "
        wsSQL = wsSQL & "WHERE SOHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "' "
        wsSQL = wsSQL & "AND SOHDDOCID = SOPTJDOCID "
        wsSQL = wsSQL & "AND SOHDCUSID = CUSID "
        wsSQL = wsSQL & "AND SOHDJOBNO *= JOBNO "
        wsSQL = wsSQL & "ORDER BY SOPTJDOCLINE "

        rsInvoice.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsInvoice.RecordCount <= 0 Then
            rsInvoice.Close()
            'UPGRADE_NOTE: Object rsInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsInvoice = Nothing
            Exit Function
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = ReadRs(rsInvoice, "SOHDDOCID")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspRevNo.Text = VB6.Format(ReadRs(rsInvoice, "SOHDREVNO"), "##0")
        ' wiRevNo = To_Value(ReadRs(rsInvoice, "SOHDREVNO"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medDocDate.Text = ReadRs(rsInvoice, "SOHDDOCDATE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlCusID = ReadRs(rsInvoice, "CUSID")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboCusCode.Text = ReadRs(rsInvoice, "CUSCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspCusName.Text = ReadRs(rsInvoice, "CUSNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspCusTel.Text = ReadRs(rsInvoice, "CUSTEL")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspCusFax.Text = ReadRs(rsInvoice, "CUSFAX")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspCusEMail.Text = ReadRs(rsInvoice, "CUSEMAIL")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboCurr.Text = ReadRs(rsInvoice, "SOHDCURR")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtExcr.Text = VB6.Format(ReadRs(rsInvoice, "SOHDEXCR"), gsExrFmt)

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medReserveDate.Text = Dsp_MedDate(ReadRs(rsInvoice, "SOHDReserveDate"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        medExpiryDate.Text = Dsp_MedDate(ReadRs(rsInvoice, "SOHDExpiryDate"))

        wlSaleID = To_Value(ReadRs(rsInvoice, "SOHDSALEID"))

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPayCode.Text = ReadRs(rsInvoice, "SOHDPAYCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboPrcCode.Text = ReadRs(rsInvoice, "SOHDPRCCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboMLCode.Text = ReadRs(rsInvoice, "SOHDMLCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboCRML.Text = ReadRs(rsInvoice, "SOHDNATURECODE")


        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboShipCode.Text = ReadRs(rsInvoice, "SOHDSHIPCODE")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboRmkCode.Text = ReadRs(rsInvoice, "SOHDRMKCODE")

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtCusPo.Text = ReadRs(rsInvoice, "SOHDCUSPO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtLcNo.Text = ReadRs(rsInvoice, "SOHDLCNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtPortNo.Text = ReadRs(rsInvoice, "SOHDPORTNO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtSpecDis.Text = VB6.Format(ReadRs(rsInvoice, "SOHDSPECDIS"), gsAmtFmt)

        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipFrom.Text = ReadRs(rsInvoice, "SOHDSHIPFROM")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipTo.Text = ReadRs(rsInvoice, "SOHDSHIPTO")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipVia.Text = ReadRs(rsInvoice, "SOHDSHIPVIA")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipName.Text = ReadRs(rsInvoice, "SOHDSHIPNAME")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipPer.Text = ReadRs(rsInvoice, "SOHDSHIPPER")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr1.Text = ReadRs(rsInvoice, "SOHDSHIPADR1")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr2.Text = ReadRs(rsInvoice, "SOHDSHIPADR2")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr3.Text = ReadRs(rsInvoice, "SOHDSHIPADR3")
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShipAdr4.Text = ReadRs(rsInvoice, "SOHDSHIPADR4")



        Dim i As Short

        For i = 1 To 10
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsInvoice, SOHDRMK & i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtRmk(i).Text = ReadRs(rsInvoice, "SOHDRMK" & i)
        Next i


        cboSaleCode.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALECODE")
        lblDspSaleDesc.Text = Get_TableInfo("mstSalesman", "SaleID =" & wlSaleID, "SALENAME")

        lblDspPayDesc.Text = Get_TableInfo("mstPayTerm", "PayCode ='" & Set_Quote(cboPayCode.Text) & "'", "PAYDESC")
        lblDspPrcDesc.Text = Get_TableInfo("mstPriceTerm", "PrcCode ='" & Set_Quote(cboPrcCode.Text) & "'", "PRCDESC")
        lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")
        lblDspCRMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboCRML.Text) & "'", "MLDESC")

        lblDspGrsAmtOrg.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "SOHDGRSAMT")), gsAmtFmt)
        lblDspDisAmtOrg.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "SOHDDISAMT")), gsAmtFmt)
        lblDspNetAmtOrg.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "SOHDNETAMT")), gsAmtFmt)
        'lblDspCstAmtOrg.Caption = Format(To_Value(ReadRs(rsInvoice, "SOHDCSTAMT")), gsAmtFmt)

        txtDisAmt.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "SOHDDISAMT")), gsAmtFmt)
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblDspRefNo.Text = ReadRs(rsInvoice, "SOHDCORRNO")


        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cboJobNo.Text = ReadRs(rsInvoice, "SOHDJOBNO")
        txtJobCost.Text = VB6.Format(To_Value(ReadRs(rsInvoice, "JOBCOST")), gsAmtFmt)


        wlLineNo = 1
        rsInvoice.MoveFirst()
        With waResult
            .ReDim(0, -1, GLINENO, GPTJID)
            Do While Not rsInvoice.EOF
                wiCtr = wiCtr + 1
                .AppendRows()
                waResult.get_Value(.get_UpperBound(1), GLINENO) = wlLineNo
                '  waResult(.UpperBound(1), GLNTYPE) = ReadRs(rsInvoice, "SOPTJLNTYPE")
                '  waResult(.UpperBound(1), GITMCODE) = IIf(To_Value(ReadRs(rsInvoice, "SOPTJITEMID")) = 0, "", Get_TableInfo("MSTITEM", "ITMID = " & To_Value(ReadRs(rsInvoice, "SOPTJITEMID")), "ITMCODE"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GDESC1) = ReadRs(rsInvoice, "SOPTJDESC1")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GQTY) = VB6.Format(ReadRs(rsInvoice, "SOPTJQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GPRICE) = VB6.Format(ReadRs(rsInvoice, "SOPTJDPRICE"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GDISPER) = VB6.Format(ReadRs(rsInvoice, "SOPTJDISPER"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GMARKUP) = VB6.Format(ReadRs(rsInvoice, "SOPTJMARKUP"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GUOM) = ReadRs(rsInvoice, "SOPTJUOM")

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GUCST) = VB6.Format(ReadRs(rsInvoice, "SOPTJUCST"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GAMT) = VB6.Format(ReadRs(rsInvoice, "SOPTJUPRICE"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GNET) = VB6.Format(ReadRs(rsInvoice, "SOPTJNET"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GCST) = VB6.Format(ReadRs(rsInvoice, "SOPTJCST"), gsAmtFmt)


                If LoadQTItem(wlKey, To_Value(ReadRs(rsInvoice, "SOPTJID")), wlLineNo) = True Then
                    waResult.get_Value(.get_UpperBound(1), GBOM) = "Y"
                Else
                    waResult.get_Value(.get_UpperBound(1), GBOM) = "N"
                End If
                waResult.get_Value(.get_UpperBound(1), GDRMKID) = To_Value(ReadRs(rsInvoice, "SOPTJDRMKID"))
                waResult.get_Value(.get_UpperBound(1), GMORE) = IIf(To_Value(ReadRs(rsInvoice, "SOPTJDRMKID")) <> 0, "Y", "N")
                waResult.get_Value(.get_UpperBound(1), GPTJID) = To_Value(ReadRs(rsInvoice, "SOPTJID"))

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), GPRINT) = IIf(ReadRs(rsInvoice, "SOPTJPRTFLG") = "Y", "-1", "0")

                wlLineNo = wlLineNo + 1
                rsInvoice.MoveNext()
            Loop
            'wlLineNo = waResult(.UpperBound(1), GLINENO) + 1

        End With
        tblDetail.ReBind()
        tblDetail.FirstRow = 0
        rsInvoice.Close()

        'UPGRADE_NOTE: Object rsInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsInvoice = Nothing


        LoadRecord = True

    End Function

    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP_M", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
        lblRevNo.Text = Get_Caption(waScrItm, "REVNO")
        lblDocDate.Text = Get_Caption(waScrItm, "DOCDATE")
        lblCusCode.Text = Get_Caption(waScrItm, "CUSCODE")
        lblCusName.Text = Get_Caption(waScrItm, "CUSNAME")
        lblCusTel.Text = Get_Caption(waScrItm, "CUSTEL")
        lblCusFax.Text = Get_Caption(waScrItm, "CUSFAX")
        lblCusEMail.Text = Get_Caption(waScrItm, "CUSEMAIL")

        lblCurr.Text = Get_Caption(waScrItm, "CURR")
        lblExcr.Text = Get_Caption(waScrItm, "EXCR")

        lblSaleCode.Text = Get_Caption(waScrItm, "SALECODE")
        lblPayCode.Text = Get_Caption(waScrItm, "PAYCODE")
        lblPrcCode.Text = Get_Caption(waScrItm, "PRCCODE")
        lblMlCode.Text = Get_Caption(waScrItm, "MLCODE")
        lblCRMl.Text = Get_Caption(waScrItm, "CRML")


        lblReserveDate.Text = Get_Caption(waScrItm, "ReserveDate")
        lblExpiryDate.Text = Get_Caption(waScrItm, "ExpiryDate")
        lblSpecDis.Text = Get_Caption(waScrItm, "SPECDIS")
        lblDisAmt.Text = Get_Caption(waScrItm, "DISAMTORG")

        lblGrsAmtOrg.Text = Get_Caption(waScrItm, "GRSAMTORG")
        lblDisAmtOrg.Text = Get_Caption(waScrItm, "DISAMTORG")
        lblNetAmtOrg.Text = Get_Caption(waScrItm, "NETAMTORG")
        '  lblCstAmtOrg.Caption = Get_Caption(waScrItm, "CSTAMTORG")

        lblTotalQty.Text = Get_Caption(waScrItm, "TOTALQTY")


        lblCol(0).Text = Get_Caption(waScrItm, "GLINENO")
        lblCol(1).Text = Get_Caption(waScrItm, "GMARKUP")
        lblCol(2).Text = Get_Caption(waScrItm, "GUOM")
        lblCol(3).Text = Get_Caption(waScrItm, "GQTY")
        lblCol(4).Text = Get_Caption(waScrItm, "GPRICE")
        lblCol(5).Text = Get_Caption(waScrItm, "GDISPER")
        lblCol(6).Text = Get_Caption(waScrItm, "GAMT")
        lblCol(7).Text = Get_Caption(waScrItm, "GNET")
        lblCol(8).Text = Get_Caption(waScrItm, "GUCST")
        lblCol(9).Text = Get_Caption(waScrItm, "GMORE")
        lblCol(10).Text = Get_Caption(waScrItm, "GBOM")


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
        btnGetDisAmt.Text = Get_Caption(waScrItm, "GETDISAMT")
        lblRefNo.Text = Get_Caption(waScrItm, "REFNO")

        lblJobNo.Text = Get_Caption(waScrItm, "JOBNO")
        lblJobCost.Text = Get_Caption(waScrItm, "JOBCOST")

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

        wsActNam(1) = Get_Caption(waScrItm, "SOADD")
        wsActNam(2) = Get_Caption(waScrItm, "SOEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "SODELETE")
        wgsTitle = Get_Caption(waScrItm, "TITLE")

        Call Ini_PopMenu(mnuPopUpSub, "POPUP_T", waPopUpSub)

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub


    Private Sub frmSO001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        '    If Button = 2 Then
        '        PopupMenu mnuMaster
        '    End If

    End Sub



    'UPGRADE_WARNING: Event frmSO001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmSO001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub

    Private Sub frmSO001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If SaveData = True Then
            'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waItem = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        '    Set waPgmItm = Nothing
        'UPGRADE_NOTE: Object frmSO001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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


    Private Sub medReserveDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medReserveDate.Enter

        FocusMe(medReserveDate)

    End Sub


    Private Sub medReserveDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medReserveDate.Leave

        FocusMe(medReserveDate, True)

    End Sub


    Private Sub medReserveDate_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medReserveDate.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Chk_medReserveDate Then
                tabDetailInfo.SelectedIndex = 0
                medExpiryDate.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function Chk_medReserveDate() As Boolean


        Chk_medReserveDate = False

        If Trim(medReserveDate.Text) = "/  /" Then
            Chk_medReserveDate = True
            Exit Function
        End If

        If Chk_Date(medReserveDate) = False Then
            gsMsg = "日期錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            medReserveDate.Focus()
            Exit Function
        End If


        Chk_medReserveDate = True

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

    Private Function Chk_medExpiryDate() As Boolean


        Chk_medExpiryDate = False

        If Trim(medExpiryDate.Text) = "/  /" Then
            Chk_medExpiryDate = True
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



    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then

            If cboCusCode.Enabled Then
                cboCusCode.Focus()
            End If



        ElseIf tabDetailInfo.SelectedIndex = 1 Then

            If tblDetail.Enabled Then
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
        '        Case GDESC1
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
            '        Case GDESC1
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

        Dim rsSOASOHD As New ADODB.Recordset
        Dim wsSQL As String


        wsSQL = "SELECT SOHDSTATUS FROM SOASOHD WHERE SOHDDOCNO = '" & Set_Quote(cboDocNo.Text) & "'"
        rsSOASOHD.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsSOASOHD.RecordCount > 0 Then

            Chk_KeyExist = True

        Else

            Chk_KeyExist = False

        End If

        rsSOASOHD.Close()
        'UPGRADE_NOTE: Object rsSOASOHD may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsSOASOHD = Nothing


    End Function

    Private Function Chk_KeyFld() As Boolean


        Chk_KeyFld = False

        If chk_cboCusCode = False Then
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
        Dim wiSLN As Short
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


        '   If wiAction = CorRec Then
        '   If DelValidation(wlKey) = False Then
        '      MousePointer = vbDefault
        '      Exit Function
        '   End If
        '   End If



        If wiAction = AddRec Then
            If Chk_KeyExist() = True Then
                Call GetNewKey()
            End If
        End If




        '    If lblDspNetAmtOrg.Caption > Get_CreditLimit(wlCusID, Trim(medDocDate.Text)) Then
        '       gsMsg = "已超過信貸額!"
        '       MsgBox gsMsg, vbOKOnly, gsTitle
        '       MousePointer = vbDefault
        '       Exit Function
        '   End If



        wlRowCtr = waResult.get_UpperBound(1)
        wsCtlPrd = VB.Left(medDocDate.Text, 4) & Mid(medDocDate.Text, 6, 2)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_SO001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wlKey)
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, wlCusID)
        Call SetSPPara(adcmdSave, 6, medDocDate.Text)
        Call SetSPPara(adcmdSave, 7, lblDspRevNo.Text)
        Call SetSPPara(adcmdSave, 8, cboCurr.Text)
        Call SetSPPara(adcmdSave, 9, txtExcr.Text)
        Call SetSPPara(adcmdSave, 10, wsCtlPrd)

        Call SetSPPara(adcmdSave, 11, Set_MedDate((medReserveDate.Text)))
        Call SetSPPara(adcmdSave, 12, Set_MedDate((medExpiryDate.Text)))

        Call SetSPPara(adcmdSave, 13, wlSaleID)

        Call SetSPPara(adcmdSave, 14, cboPayCode.Text)
        Call SetSPPara(adcmdSave, 15, cboPrcCode.Text)
        Call SetSPPara(adcmdSave, 16, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 17, cboCRML.Text)
        Call SetSPPara(adcmdSave, 18, cboShipCode.Text)
        Call SetSPPara(adcmdSave, 19, cboRmkCode.Text)

        Call SetSPPara(adcmdSave, 20, txtCusPo.Text)
        Call SetSPPara(adcmdSave, 21, txtLcNo.Text)
        Call SetSPPara(adcmdSave, 22, txtPortNo.Text)

        Call SetSPPara(adcmdSave, 23, txtShipFrom.Text)
        Call SetSPPara(adcmdSave, 24, txtShipTo.Text)
        Call SetSPPara(adcmdSave, 25, txtShipVia.Text)
        Call SetSPPara(adcmdSave, 26, txtShipPer.Text)
        Call SetSPPara(adcmdSave, 27, txtShipName.Text)
        Call SetSPPara(adcmdSave, 28, txtShipAdr1.Text)
        Call SetSPPara(adcmdSave, 29, txtShipAdr2.Text)
        Call SetSPPara(adcmdSave, 30, txtShipAdr3.Text)
        Call SetSPPara(adcmdSave, 31, txtShipAdr4.Text)

        For i = 1 To 10
            Call SetSPPara(adcmdSave, 32 + i - 1, txtRmk(i).Text)
        Next

        Call SetSPPara(adcmdSave, 42, lblDspGrsAmtOrg)
        Call SetSPPara(adcmdSave, 43, lblDspDisAmtOrg)
        Call SetSPPara(adcmdSave, 44, lblDspNetAmtOrg)
        Call SetSPPara(adcmdSave, 45, txtSpecDis.Text)
        Call SetSPPara(adcmdSave, 46, cboJobNo.Text)
        Call SetSPPara(adcmdSave, 47, txtJobCost.Text)

        Call SetSPPara(adcmdSave, 48, wsFormID)

        Call SetSPPara(adcmdSave, 49, gsUserID)
        Call SetSPPara(adcmdSave, 50, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 51)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 52)

        If wiAction = AddRec And Trim(cboDocNo.Text) = "" Then cboDocNo.Text = wsDocNo

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_SO001B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, GQTY)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, GLINENO))
                    Call SetSPPara(adcmdSave, 4, "D")
                    Call SetSPPara(adcmdSave, 5, "")
                    Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, GDESC1))
                    Call SetSPPara(adcmdSave, 7, "")
                    Call SetSPPara(adcmdSave, 8, "")
                    Call SetSPPara(adcmdSave, 9, "")
                    Call SetSPPara(adcmdSave, 10, waResult.get_Value(wiCtr, GQTY))
                    Call SetSPPara(adcmdSave, 11, waResult.get_Value(wiCtr, GPRICE))
                    Call SetSPPara(adcmdSave, 12, waResult.get_Value(wiCtr, GAMT))
                    Call SetSPPara(adcmdSave, 13, waResult.get_Value(wiCtr, GDISPER))
                    Call SetSPPara(adcmdSave, 14, waResult.get_Value(wiCtr, GMARKUP))
                    Call SetSPPara(adcmdSave, 15, waResult.get_Value(wiCtr, GUOM))

                    Call SetSPPara(adcmdSave, 16, waResult.get_Value(wiCtr, GNET))
                    Call SetSPPara(adcmdSave, 17, waResult.get_Value(wiCtr, GNET))
                    Call SetSPPara(adcmdSave, 18, waResult.get_Value(wiCtr, GUCST))
                    Call SetSPPara(adcmdSave, 19, waResult.get_Value(wiCtr, GCST))
                    Call SetSPPara(adcmdSave, 20, waResult.get_Value(wiCtr, GDRMKID))
                    Call SetSPPara(adcmdSave, 21, waResult.get_Value(wiCtr, GPTJID))
                    Call SetSPPara(adcmdSave, 22, IIf(waResult.get_Value(wiCtr, GPRINT) = "-1", "Y", "N"))
                    Call SetSPPara(adcmdSave, 23, IIf(wlRowCtr = wiCtr, "Y", "N"))
                    Call SetSPPara(adcmdSave, 24, gsUserID)
                    Call SetSPPara(adcmdSave, 25, wsGenDte)
                    adcmdSave.Execute()
                End If
            Next
        End If

        wiSLN = 0
        For wiCtr = 0 To waItem.get_UpperBound(1)
            If Trim(waItem.get_Value(wiCtr, SLN_Renamed)) <> "0" And Trim(waItem.get_Value(wiCtr, SITMCODE)) <> "" And Trim(waItem.get_Value(wiCtr, SITMTYPE)) <> "" Then
                wiSLN = wiSLN + 1
            End If
        Next

        i = 1

        If waItem.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_SO001C"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waItem.get_UpperBound(1)
                If Trim(waItem.get_Value(wiCtr, SLN_Renamed)) <> "0" And Trim(waItem.get_Value(wiCtr, SITMCODE)) <> "" And Trim(waItem.get_Value(wiCtr, SITMTYPE)) <> "" Then

                    Call SetSPPara(adcmdSave, 1, wiAction)
                    Call SetSPPara(adcmdSave, 2, wlKey)
                    Call SetSPPara(adcmdSave, 3, waItem.get_Value(wiCtr, SLN_Renamed))
                    Call SetSPPara(adcmdSave, 4, waItem.get_Value(wiCtr, SITMID))
                    Call SetSPPara(adcmdSave, 5, i)
                    Call SetSPPara(adcmdSave, 6, waItem.get_Value(wiCtr, SVDRID))
                    Call SetSPPara(adcmdSave, 7, waItem.get_Value(wiCtr, SITMNAME))
                    Call SetSPPara(adcmdSave, 8, waItem.get_Value(wiCtr, SQTY))
                    Call SetSPPara(adcmdSave, 9, waItem.get_Value(wiCtr, SUNITPRICE))
                    Call SetSPPara(adcmdSave, 10, waItem.get_Value(wiCtr, SUCST))
                    Call SetSPPara(adcmdSave, 11, waItem.get_Value(wiCtr, SDISPER))
                    Call SetSPPara(adcmdSave, 12, waItem.get_Value(wiCtr, SAMT))
                    Call SetSPPara(adcmdSave, 13, waItem.get_Value(wiCtr, SNET))
                    Call SetSPPara(adcmdSave, 14, waItem.get_Value(wiCtr, SCST))
                    Call SetSPPara(adcmdSave, 15, IIf(waItem.get_Value(wiCtr, SINDENT) = "-1", "Y", "N"))
                    Call SetSPPara(adcmdSave, 16, IIf(wiSLN = i, "Y", "N"))
                    Call SetSPPara(adcmdSave, 17, waItem.get_Value(wiCtr, SDTID))



                    adcmdSave.Execute()
                    i = i + 1

                End If
            Next
        End If


        '  adcmdSave.CommandText = "USP_UPDJOB"
        '  adcmdSave.CommandType = adCmdStoredProc
        '  adcmdSave.Parameters.Refresh

        '  Call SetSPPara(adcmdSave, 1, wiAction)
        '  Call SetSPPara(adcmdSave, 2, cboJobNo.Text)
        '  Call SetSPPara(adcmdSave, 3, 0)
        '  Call SetSPPara(adcmdSave, 4, txtJobCost.Text)
        '  Call SetSPPara(adcmdSave, 5, gsUserID)
        '  Call SetSPPara(adcmdSave, 6, wsGenDte)
        '  adcmdSave.Execute


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



        '   If Not chk_txtRevNo Then Exit Function
        If Not Chk_medDocDate Then Exit Function
        If Not chk_cboCusCode() Then Exit Function
        If Not getExcRate((cboCurr.Text), (medDocDate.Text), wsExcRate, wsExcDesc) Then Exit Function
        If Not chk_txtExcr Then Exit Function

        If Not Chk_cboSaleCode Then Exit Function
        If Not Chk_cboPayCode Then Exit Function
        If Not Chk_cboPrcCode Then Exit Function
        If Not Chk_cboMLCode Then Exit Function
        If Not Chk_cboCRML Then Exit Function



        If Not Chk_medReserveDate Then Exit Function
        If Not Chk_medExpiryDate Then Exit Function
        If Not Chk_txtSpecDis Then Exit Function
        If Not chk_txtDisAmt Then Exit Function

        If Not Chk_cboJobNo Then Exit Function
        If Not chk_txtJobCost Then Exit Function

        If Not Chk_cboShipCode Then Exit Function
        If Not Chk_cboRmkCode Then Exit Function


        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, GDESC1)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tabDetailInfo.SelectedIndex = 1
                        tblDetail.Col = GDESC1
                        tblDetail.Focus()
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
                tblDetail.Col = GQTY
                tblDetail.Focus()
            End If
            Exit Function
        End If


        If ChkSoDetail = False Then
            tabDetailInfo.SelectedIndex = 1
            tblDetail.Col = GDESC1
            tblDetail.Focus()
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

        Dim newForm As New frmSO001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()

    End Sub

    Private Sub cmdOpen()

        Dim newForm As New frmSO001

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
        wsFormID = "SO001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")
        wsTrnCd = "SO"




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
            Case tcAppendix
                Call cmdAppendix()

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


    Private Sub cboCusCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCusCode

        wsSQL = "SELECT CUSCODE, CUSNAME FROM mstCUSTOMER "
        wsSQL = wsSQL & "WHERE CUSCODE LIKE '%" & IIf(cboCusCode.SelectionLength > 0, "", Set_Quote(cboCusCode.Text)) & "%' "
        wsSQL = wsSQL & "AND CUSSTATUS = '1' "
        wsSQL = wsSQL & " AND CusInactive = 'N' "
        wsSQL = wsSQL & "ORDER BY CUSCODE "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboCusCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboCusCode.Top) + VB6.PixelsToTwipsY(cboCusCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboCusCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusCode.Enter

        wcCombo = cboCusCode
        'TREtoolsbar1.ButtonEnabled(tcCusSrh) = True
        FocusMe(cboCusCode)

    End Sub

    Private Sub cboCusCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call chk_InpLen(cboCusCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_cboCusCode() = False Then GoTo EventExitSub
            If wiAction = AddRec Or wsOldCusNo <> cboCusCode.Text Then Call Get_DefVal()
            tabDetailInfo.SelectedIndex = 0
            If Chk_KeyFld Then
                cboSaleCode.Focus()
            End If

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_cboCusCode() As Boolean
        Dim wlID As Integer
        Dim wsName As String
        Dim wsTel As String
        Dim wsFax As String
        Dim wsEMail As String

        chk_cboCusCode = False


        If Trim(cboCusCode.Text) = "" Then
            gsMsg = "必需輸入客戶編碼!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboCusCode.Focus()
            Exit Function
        End If

        If Chk_CusCode(cboCusCode.Text, wlID, wsName, wsTel, wsFax, wsEMail) Then
            wlCusID = wlID
            lblDspCusName.Text = wsName
            lblDspCusTel.Text = wsTel
            lblDspCusFax.Text = wsFax
            lblDspCusEMail.Text = wsEMail
        Else
            wlCusID = 0
            lblDspCusName.Text = ""
            lblDspCusTel.Text = ""
            lblDspCusFax.Text = ""
            lblDspCusEMail.Text = ""
            gsMsg = "客戶不存在!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboCusCode.Focus()
            Exit Function
        End If

        chk_cboCusCode = True

    End Function

    Private Sub Get_DefVal()

        Dim rsDefVal As New ADODB.Recordset
        Dim wsSQL As String
        Dim wsExcDesc As String
        Dim wsExcRate As String
        Dim wsCode As String
        Dim wsName As String

        wsSQL = "SELECT * "
        wsSQL = wsSQL & "FROM  mstCUSTOMER "
        wsSQL = wsSQL & "WHERE CUSID = " & wlCusID
        rsDefVal.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDefVal.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboCurr.Text = ReadRs(rsDefVal, "CUSCURR")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboPayCode.Text = ReadRs(rsDefVal, "CUSPAYCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cboMLCode.Text = ReadRs(rsDefVal, "CUSMLCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wlSaleID = ReadRs(rsDefVal, "CUSSALEID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipName.Text = ReadRs(rsDefVal, "CUSSHIPTO")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipPer.Text = ReadRs(rsDefVal, "CUSSHIPCONTACTPERSON")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr1.Text = ReadRs(rsDefVal, "CUSSHIPADD1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr2.Text = ReadRs(rsDefVal, "CUSSHIPADD2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr3.Text = ReadRs(rsDefVal, "CUSSHIPADD3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtShipAdr4.Text = ReadRs(rsDefVal, "CUSSHIPADD4")


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
        lblDspMLDesc.Text = Get_TableInfo("mstMerchClass", "MLCode ='" & Set_Quote(cboMLCode.Text) & "'", "MLDESC")




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
            .ColumnHeaders = False
            For wiCtr = GLINENO To GPTJID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case GLINENO
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 5
                        .Columns(wiCtr).Locked = True
                        '    Case GLNTYPE
                        '        .Columns(wiCtr).Width = 1000
                        '        .Columns(wiCtr).DataWidth = 1
                        '        .Columns(wiCtr).Button = True
                        '    Case GITMCODE
                        '        .Columns(wiCtr).Width = 1500
                        '        .Columns(wiCtr).DataWidth = 30
                        '        .Columns(wiCtr).Button = True
                    Case GQTY
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                    Case GPRICE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = True
                    Case GDISPER
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GMARKUP
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GUOM
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Button = True

                    Case GAMT
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        ' .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GNET
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case GUCST
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Visible = False
                    Case GCST
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Locked = True
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Visible = False
                    Case GBOM
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 2
                        .Columns(wiCtr).Button = True

                    Case GDESC1
                        .Columns(wiCtr).Width = 3500
                        .Columns(wiCtr).DataWidth = 60
                    Case GMORE
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 2
                        .Columns(wiCtr).Button = True
                    Case GDRMKID
                        .Columns(wiCtr).Visible = False
                        .Columns(wiCtr).DataWidth = 10
                    Case GPTJID
                        .Columns(wiCtr).Visible = False
                        .Columns(wiCtr).DataWidth = 10
                    Case GPRINT
                        .Columns(wiCtr).DataWidth = 1
                        .Columns(wiCtr).Width = 300
                        .Columns(wiCtr).ValueItems.Presentation = TrueDBGrid60.PresentationConstants.dbgCheckBox

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


                Case GDESC1

                    If Chk_grdDesc((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If .Columns(GLINENO).Text = "" Then
                        .Columns(GLINENO).Text = CStr(wlLineNo)
                        wlLineNo = wlLineNo + 1
                        .Columns(GUCST).Text = "0"
                        .Columns(GCST).Text = "0"
                        .Columns(GDISPER).Text = "1"
                        .Columns(GPRICE).Text = "0"
                        .Columns(GAMT).Text = "0"
                        .Columns(GNET).Text = "0"
                        .Columns(GMARKUP).Text = "1"
                        .Columns(GUOM).Text = ""
                        .Columns(GBOM).Text = "N"
                        .Columns(GMORE).Text = "N"
                        .Columns(GQTY).Text = "1"

                    End If



                Case GQTY, GPRICE, GDISPER, GMARKUP

                    If eventArgs.ColIndex = GQTY Then

                        If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    End If

                    ' If ColIndex = GPRICE Then

                    '  If Chk_grdPrice(.Columns(ColIndex).Text) = False Then
                    '      GoTo Tbl_BeforeColUpdate_Err
                    '  End If

                    ' End If

                    If eventArgs.ColIndex = GDISPER Then

                        If Chk_grdDisPer((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    End If

                    If eventArgs.ColIndex = GMARKUP Then

                        If Chk_grdMarkUp((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    End If


                    If Trim(.Columns(GPRICE).Text) <> "" And Trim(.Columns(GQTY).Text) <> "" Then
                        .Columns(GAMT).Text = VB6.Format(To_Value((.Columns(GPRICE).Text)) * To_Value((.Columns(GDISPER).Text)) / To_Value((.Columns(GMARKUP).Text)), gsAmtFmt)
                    End If

                    If Trim(.Columns(GPRICE).Text) <> "" And Trim(.Columns(GDISPER).Text) <> "" And Trim(.Columns(GMARKUP).Text) <> "" And Trim(.Columns(GQTY).Text) <> "" Then
                        .Columns(GNET).Text = VB6.Format(To_Value((.Columns(GPRICE).Text)) * To_Value((.Columns(GQTY).Text)) * To_Value((.Columns(GDISPER).Text)) / To_Value((.Columns(GMARKUP).Text)), gsAmtFmt)
                    End If

                    If Trim(.Columns(GUCST).Text) <> "" And Trim(.Columns(GQTY).Text) <> "" Then
                        .Columns(GCST).Text = VB6.Format(To_Value((.Columns(GUCST).Text)) * To_Value((.Columns(GQTY).Text)), gsAmtFmt)
                    End If


                Case GAMT

                    If Chk_grdPrice((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    If Trim(.Columns(GAMT).Text) <> "" And Trim(.Columns(GQTY).Text) <> "" Then
                        .Columns(GNET).Text = VB6.Format(To_Value((.Columns(GAMT).Text)) * To_Value((.Columns(GQTY).Text)), gsAmtFmt)
                    End If


            End Select

            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If .Columns(eventArgs.ColIndex).Text <> eventArgs.OldValue Then
                wbUpdate = True
            End If
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
        Dim wiCtr As Integer
        Dim wbRtnResult As Boolean
        Dim wsRmkID As String

        On Error GoTo tblDetail_ButtonClick_Err


        With tblDetail
            Select Case eventArgs.ColIndex

                Case GUOM

                    wsSQL = "SELECT UOMCODE FROM MSTUOM "
                    wsSQL = wsSQL & " WHERE UOMSTATUS <> '2'"

                    Call Ini_Combo(1, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.PixelsToTwipsX(.Left) + .Columns(eventArgs.ColIndex).Top, VB6.PixelsToTwipsY(.Top) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLUOMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail


                Case GBOM

                    If wiAction = DelRec Or Trim(.Columns(GLINENO).Text) = "" Then Exit Sub


                    If waItem.get_UpperBound(1) >= 0 Then
                        frmQTN002.InvDoc.ReDim(0, waItem.get_UpperBound(1), SLINENO, SSOID)
                    End If

                    wiCtr = IIf(.Columns(GLINENO).Text = "", wlLineNo, .Columns(GLINENO).Text)
                    'UPGRADE_WARNING: Couldn't resolve default property of object frmQTN002.InTrnCd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'frmQTN002.InTrnCd = "SO"
                    frmQTN002.inLineNo = wiCtr
                    'UPGRADE_WARNING: Couldn't resolve default property of object frmQTN002.inLineDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'frmQTN002.inLineDesc = .Columns(GDESC1).Text
                    frmQTN002.InvDoc = waItem
                    frmQTN002.InCurr = cboCurr.Text
                    frmQTN002.InExcr = CDbl(txtExcr.Text)
                    frmQTN002.ShowDialog()
                    waItem.ReDim(0, frmQTN002.InvDoc.UpperBound(1), SLINENO, SSOID)
                    waItem = frmQTN002.InvDoc
                    'UPGRADE_WARNING: Couldn't resolve default property of object frmQTN002.Result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'wbRtnResult = frmQTN002.Result
                    frmQTN002.Close()

                    If wbRtnResult = True Then
                        Call cmdCstRefresh(wiCtr)
                    End If

                Case GMORE


                    frmDocRemark.RmkID = IIf(.Columns(GDRMKID).Text = "", "0", .Columns(GDRMKID).Text)
                    frmDocRemark.RmkType = "ST"
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
                    If Chk_SoExistSp(.Bookmark) = False Then Exit Sub
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
                        Case GNET
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = GDESC1
                        Case GBOM
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = GPRICE
                        Case Else
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                    End Select

                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> GLINENO Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> GNET Then
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

            Case GQTY
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, False)

            Case GPRICE, GDISPER, GMARKUP, GAMT
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
                .Col = GDESC1
            End If

            Call Calc_Total()

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case GDESC1

                        Call Chk_grdDesc((.Columns(GDESC1).Text))

                    Case GQTY

                        Call Chk_grdQty((.Columns(GQTY).Text))

                    Case GPRICE

                        '   Call Chk_grdPrice(.Columns(GPRICE).Text)


                    Case GDISPER

                        Call Chk_grdPrice((.Columns(GDISPER).Text))

                    Case GMARKUP

                        Call Chk_grdMarkUp((.Columns(GMARKUP).Text))

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub


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


    Private Function Chk_grdDesc(ByRef inCode As String) As Boolean

        Chk_grdDesc = True

        If Trim(inCode) = "" Then
            gsMsg = "必需輸入內容!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdDesc = False
            Exit Function
        End If



    End Function
    Private Function Chk_grdPrice(ByRef inCode As String) As Boolean

        Chk_grdPrice = True

        If Trim(inCode) = "" Then
            gsMsg = "必需輸入售價!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdPrice = False
            Exit Function
        End If

        If To_Value(inCode) < 0 Then
            gsMsg = "售價必需大為零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdPrice = False
            Exit Function
        End If

    End Function

    Private Function Chk_grdDisPer(ByRef inCode As String) As Boolean

        Chk_grdDisPer = True


        If To_Value(inCode) < 0 Then
            gsMsg = "折扣必需大為零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdDisPer = False
            Exit Function
        End If

    End Function


    Private Function Chk_grdMarkUp(ByRef inCode As String) As Boolean

        Chk_grdMarkUp = True


        If To_Value(inCode) < 0 Then
            gsMsg = "M/U必需大為零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdMarkUp = False
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
                If Trim(.Columns(GDESC1).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, GLINENO)) = "" And Trim(waResult.get_Value(inRow, GDESC1)) = "" And Trim(waResult.get_Value(inRow, GMORE)) = "" And Trim(waResult.get_Value(inRow, GQTY)) = "" And Trim(waResult.get_Value(inRow, GPRICE)) = "" And Trim(waResult.get_Value(inRow, GDISPER)) = "" And Trim(waResult.get_Value(inRow, GMARKUP)) = "" And Trim(waResult.get_Value(inRow, GUOM)) = "" And Trim(waResult.get_Value(inRow, GUCST)) = "" And Trim(waResult.get_Value(inRow, GCST)) = "" And Trim(waResult.get_Value(inRow, GAMT)) = "" And Trim(waResult.get_Value(inRow, GNET)) = "" Then
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




            If Chk_grdDesc(waResult.get_Value(LastRow, GDESC1)) = False Then
                .Col = GDESC1
                Exit Function
            End If

            If Chk_grdQty(waResult.get_Value(LastRow, GQTY)) = False Then
                .Col = GQTY
                Exit Function
            End If

            '  If Chk_grdPrice(waResult(LastRow, GPRICE)) = False Then
            '          .Col = GPRICE
            '          Exit Function
            '  End If

            If Chk_grdDisPer(waResult.get_Value(LastRow, GDISPER)) = False Then
                .Col = GDISPER
                Exit Function
            End If

            If Chk_grdMarkUp(waResult.get_Value(LastRow, GMARKUP)) = False Then
                .Col = GMARKUP
                Exit Function
            End If

            If Chk_Amount(waResult.get_Value(LastRow, GAMT)) = False Then
                .Col = GAMT
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
        Dim wiTotalCst As Double
        Dim wiTotalQty As Double

        Dim wiRowCtr As Short

        Calc_Total = False
        For wiRowCtr = 0 To waResult.get_UpperBound(1)
            wiTotalGrs = wiTotalGrs + To_Value(waResult.get_Value(wiRowCtr, GNET))
            'wiTotalDis = wiTotalDis + To_Value(waResult(wiRowCtr, GNET)) * To_Value(txtSpecDis.Text)
            wiTotalNet = wiTotalNet + To_Value(waResult.get_Value(wiRowCtr, GNET))
            wiTotalQty = wiTotalQty + To_Value(waResult.get_Value(wiRowCtr, GQTY))
            wiTotalCst = wiTotalCst + To_Value(waResult.get_Value(wiRowCtr, GCST))

        Next

        lblDspGrsAmtOrg.Text = VB6.Format(CStr(wiTotalGrs), gsAmtFmt)
        lblDspDisAmtOrg.Text = VB6.Format(CStr(wiTotalDis), gsAmtFmt)
        lblDspNetAmtOrg.Text = VB6.Format(CStr(wiTotalNet), gsAmtFmt)
        lblDspCstAmtOrg.Text = VB6.Format(CStr(wiTotalCst), gsAmtFmt)

        lblDspTotalQty.Text = VB6.Format(CStr(wiTotalQty), gsQtyFmt)

        btnGetDisAmt_Click(btnGetDisAmt, New System.EventArgs())

        Calc_Total = True

    End Function




    Private Function cmdDel() As Boolean

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
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

        If DelValidation(wlKey) = False Then
            wiAction = CorRec
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If


        wiAction = DelRec

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_SO001A"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wsTrnCd)
        Call SetSPPara(adcmdSave, 3, wlKey)
        Call SetSPPara(adcmdSave, 4, Trim(cboDocNo.Text))
        Call SetSPPara(adcmdSave, 5, wlCusID)
        Call SetSPPara(adcmdSave, 6, medDocDate.Text)
        Call SetSPPara(adcmdSave, 7, 0)
        Call SetSPPara(adcmdSave, 8, cboCurr.Text)
        Call SetSPPara(adcmdSave, 9, txtExcr.Text)
        Call SetSPPara(adcmdSave, 10, "")

        Call SetSPPara(adcmdSave, 11, Set_MedDate((medReserveDate.Text)))
        Call SetSPPara(adcmdSave, 12, Set_MedDate((medExpiryDate.Text)))

        Call SetSPPara(adcmdSave, 13, wlSaleID)

        Call SetSPPara(adcmdSave, 14, cboPayCode.Text)
        Call SetSPPara(adcmdSave, 15, cboPrcCode.Text)
        Call SetSPPara(adcmdSave, 16, cboMLCode.Text)
        Call SetSPPara(adcmdSave, 17, cboCRML.Text)
        Call SetSPPara(adcmdSave, 18, cboShipCode.Text)
        Call SetSPPara(adcmdSave, 19, cboRmkCode.Text)

        Call SetSPPara(adcmdSave, 20, txtCusPo.Text)
        Call SetSPPara(adcmdSave, 21, txtLcNo.Text)
        Call SetSPPara(adcmdSave, 22, txtPortNo.Text)

        Call SetSPPara(adcmdSave, 23, txtShipFrom.Text)
        Call SetSPPara(adcmdSave, 24, txtShipTo.Text)
        Call SetSPPara(adcmdSave, 25, txtShipVia.Text)
        Call SetSPPara(adcmdSave, 26, txtShipPer.Text)
        Call SetSPPara(adcmdSave, 27, txtShipName.Text)
        Call SetSPPara(adcmdSave, 28, txtShipAdr1.Text)
        Call SetSPPara(adcmdSave, 29, txtShipAdr2.Text)
        Call SetSPPara(adcmdSave, 30, txtShipAdr3.Text)
        Call SetSPPara(adcmdSave, 31, txtShipAdr4.Text)

        For i = 1 To 10
            Call SetSPPara(adcmdSave, 32 + i - 1, txtRmk(i).Text)
        Next

        Call SetSPPara(adcmdSave, 42, lblDspGrsAmtOrg)
        Call SetSPPara(adcmdSave, 43, lblDspDisAmtOrg)
        Call SetSPPara(adcmdSave, 44, lblDspNetAmtOrg)
        Call SetSPPara(adcmdSave, 45, txtSpecDis.Text)
        Call SetSPPara(adcmdSave, 46, cboJobNo.Text)
        Call SetSPPara(adcmdSave, 47, txtJobCost.Text)
        Call SetSPPara(adcmdSave, 48, wsFormID)

        Call SetSPPara(adcmdSave, 49, gsUserID)
        Call SetSPPara(adcmdSave, 50, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wlKey = GetSPPara(adcmdSave, 51)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsDocNo = GetSPPara(adcmdSave, 52)




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
                    .Items.Item(tcAppendix).Enabled = False
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
                    .Items.Item(tcAppendix).Enabled = False
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
                    .Items.Item(tcAppendix).Enabled = True
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
                    .Items.Item(tcAppendix).Enabled = False
                End With



        End Select
    End Sub



    '-- Set field status, Default, Add, Edit.
    Public Sub SetFieldStatus(ByVal sStatus As String)
        Select Case sStatus
            Case "Default"

                Me.cboDocNo.Enabled = False
                Me.cboCusCode.Enabled = False
                '    Me.txtRevNo.Enabled = False
                Me.medDocDate.Enabled = False
                Me.cboCurr.Enabled = False
                Me.txtExcr.Enabled = False

                Me.medReserveDate.Enabled = False
                Me.medExpiryDate.Enabled = False
                Me.cboSaleCode.Enabled = False
                Me.cboPayCode.Enabled = False
                Me.cboPrcCode.Enabled = False
                Me.cboMLCode.Enabled = False
                Me.cboCRML.Enabled = False

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
                Me.txtSpecDis.Enabled = False
                Me.txtDisAmt.Enabled = False

                Me.cboJobNo.Enabled = False
                Me.txtJobCost.Enabled = False


                Me.btnGetDisAmt.Enabled = False


                Me.picRmk.Enabled = False

                Me.tblDetail.Enabled = False

            Case "AfrActAdd"

                Me.cboDocNo.Enabled = True

            Case "AfrActEdit"

                Me.cboDocNo.Enabled = True

            Case "AfrKey"

                Me.cboDocNo.Enabled = False

                Me.cboCusCode.Enabled = True
                '  Me.txtRevNo.Enabled = True
                Me.medDocDate.Enabled = True
                Me.cboCurr.Enabled = True
                Me.txtExcr.Enabled = True

                Me.medReserveDate.Enabled = True
                Me.medExpiryDate.Enabled = True
                Me.cboSaleCode.Enabled = True
                Me.cboPayCode.Enabled = True
                Me.cboPrcCode.Enabled = True
                Me.cboMLCode.Enabled = True
                Me.cboCRML.Enabled = True

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
                Me.txtSpecDis.Enabled = True
                Me.txtDisAmt.Enabled = True

                Me.cboJobNo.Enabled = True
                Me.txtJobCost.Enabled = True

                Me.btnGetDisAmt.Enabled = True

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
            .TableType = wsTrnCd
            .TableKey = "SOHDDocNo"
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
        vFilterAry(1, 2) = "SOHDDocNo"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "Doc. Date"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "SOHDDocDate"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "Customer #"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "CusCode"

        Dim vAry(4, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "Doc No."
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "SOHDDocNo"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "Date"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "SOHDDocDate"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 1) = "Customer#"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 2) = "CusCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 3) = "2000"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 1) = "Customer Name"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 2) = "CusName"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 3) = "5000"


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            wsSQL = "SELECT SOASOHD.SOHDDocNo, SOASOHD.SOHDDocDate, mstCustomer.CusCode,  mstCustomer.CusName "
            wsSQL = wsSQL & "FROM MstCustomer, SOASOHD "
            .sBindSQL = wsSQL
            .sBindWhereSQL = "WHERE SOASOHD.SOHDStatus = '1' And SOASOHD.SOHDCusID = MstCustomer.CusID "
            .sBindOrderSQL = "ORDER BY SOASOHD.SOHDDocNo"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmSO001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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
        wsSQL = wsSQL & "AND SaleStatus = '1' "
        wsSQL = wsSQL & "AND SaleType = 'S' "
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
            cboCRML.Focus()

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
        wsSQL = wsSQL & "AND MLSTATUS = '1' "
        wsSQL = wsSQL & "AND MLTYPE = 'A' "
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


        If Chk_MClass(cboMLCode.Text, "A", wsDesc) = False Then
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

        Call chk_InpLen(txtShipFrom, 1000, KeyAscii)

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

        Call chk_InpLen(txtShipTo, 1000, KeyAscii)

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

        Call chk_InpLen(txtShipVia, 1000, KeyAscii)

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

        Call chk_InpLen(txtCusPo, 50, KeyAscii)

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

        Call chk_InpLen(txtLcNo, 50, KeyAscii)

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

        Call chk_InpLen(txtPortNo, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_KeyFld = True Then
                tabDetailInfo.SelectedIndex = 1
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
        wsSQL = wsSQL & "AND ShipCardID = " & wlCusID & " "
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

        Call chk_InpLen(txtShipPer, 50, KeyAscii)

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
                cboCusCode.Focus()
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


    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmSO001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If

        '' form delcare
        'Private waPopUpSub As New XArrayDB

        '' form unload
        'Set waPopUpSub = Nothing

        ''   addin ini_caption

    End Sub

    Public Sub mnuPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopUpSub.Click
        Dim Index As Short = mnuPopUpSub.GetIndex(eventSender)
        Call Call_PopUpMenu(waPopUpSub, Index)
    End Sub

    Private Sub Call_PopUpMenu(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inMnuIdx As Short)

        Dim wsAct As String
        Dim wlRow As Integer

        wsAct = inArray.get_Value(inMnuIdx, 0)

        With tblDetail
            Select Case wsAct
                Case "DELETE"

                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(.Bookmark) Then Exit Sub
                    If .EditActive = True Then Exit Sub
                    If Chk_SoExistSp(.Bookmark) = False Then Exit Sub
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

                Case "COPY"

                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If IsDbNull(.Bookmark) Then Exit Sub
                    If .EditActive = True Then Exit Sub
                    gsMsg = "你是否確定要複製此列?"
                    If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then Exit Sub
                    wlRow = cmdCopyLine(.Bookmark)
                    '.Update
                    'If .Row = -1 Then
                    '    .Row = 0
                    'End If
                    .ReBind()
                    '       .Row = wlRow - 1
                    .Focus()


                    Call Calc_Total()

                Case Else
                    Exit Sub


            End Select

        End With


    End Sub

    Private Sub cmdRefresh()
        Dim wiCtr As Short


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If waResult.get_UpperBound(1) >= 0 Then

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, GDESC1)) <> "" Then


                    waResult.get_Value(wiCtr, GAMT) = VB6.Format(To_Value(waResult.get_Value(wiCtr, GPRICE)) * To_Value(waResult.get_Value(wiCtr, GDISPER)) / To_Value(waResult.get_Value(wiCtr, GMARKUP)), gsAmtFmt)
                    waResult.get_Value(wiCtr, GNET) = VB6.Format(To_Value(waResult.get_Value(wiCtr, GPRICE)) * To_Value(waResult.get_Value(wiCtr, GQTY)) * To_Value(waResult.get_Value(wiCtr, GDISPER)) / To_Value(waResult.get_Value(wiCtr, GMARKUP)), gsAmtFmt)
                    waResult.get_Value(wiCtr, GCST) = VB6.Format(To_Value(waResult.get_Value(wiCtr, GUCST)) * To_Value(waResult.get_Value(wiCtr, GQTY)), gsAmtFmt)

                End If
            Next



            tblDetail.ReBind()
            tblDetail.FirstRow = 0

            Call Calc_Total()

        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default


    End Sub



    Private Function LoadQTItem(ByRef InDocID As Integer, ByRef inPtjID As Integer, ByRef inLineNo As Integer) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wiRow As Integer


        On Error GoTo LoadQTItem_Err

        LoadQTItem = False

        wsSQL = " SELECT SODTID, SODTDOCLINE, SODTLNTYPE, SODTITEMID, SODTVDRID, ITMCODE, ITMITMTYPECODE, VDRCODE, SODTITEMDESC, SODTUPRICE, "
        wsSQL = wsSQL & " SODTDISPER, SODTUCST, SODTQTY, SODTAMT, SODTNET, SODTCST, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITMNAME "
        wsSQL = wsSQL & " FROM soaSODT, MstItem, MstVendor "
        wsSQL = wsSQL & " WHERE SODTDocID = " & InDocID
        wsSQL = wsSQL & " AND ItmID = SODTItemID "
        wsSQL = wsSQL & " AND VdrID = SODTVdrID "
        wsSQL = wsSQL & " AND SODTPtjID = " & inPtjID
        wsSQL = wsSQL & " ORDER BY SODTDOCLINE "


        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        wiRow = 1
        '  waItem.ReDim 0, waResult.UpperBound(1), SLINENO, SITMID

        If rsRcd.RecordCount = 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If
        With waItem
            Do Until rsRcd.EOF
                .AppendRows()
                waItem.get_Value(.get_UpperBound(1), SLINENO) = wiRow
                waItem.get_Value(.get_UpperBound(1), SLN_Renamed) = inLineNo
                '' Tom 20090203
                '      waItem(.UpperBound(1), SINDENT) = IIf(ReadRs(rsRcd, "SODTLNTYPE") = "T", "-1", "0")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SINDENT) = ReadRs(rsRcd, "SODTLNTYPE")
                '      waItem(.UpperBound(1), SINDENT) = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SITMCODE) = ReadRs(rsRcd, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SVDRCODE) = ReadRs(rsRcd, "VDRCODE")
                '' Tom 20090203
                '        waItem(.UpperBound(1), SITMNAME) = IIf(ReadRs(rsRcd, "SODTLNTYPE") = "T", ReadRs(rsRcd, "SODTITEMDESC"), ReadRs(rsRcd, "ITMNAME"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SITMNAME) = IIf(ReadRs(rsRcd, "SODTLNTYPE") = "S", ReadRs(rsRcd, "SODTITEMDESC"), ReadRs(rsRcd, "ITMNAME"))

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SUNITPRICE) = VB6.Format(ReadRs(rsRcd, "SODTUPRICE"), gsUprFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SUCST) = VB6.Format(ReadRs(rsRcd, "SODTUCST"), gsUprFmt)

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SDISPER) = VB6.Format(ReadRs(rsRcd, "SODTDISPER"), gsAmtFmt)

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(ReadRs(rsRcd, "SODTQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SAMT) = VB6.Format(ReadRs(rsRcd, "SODTAMT"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SNET) = VB6.Format(ReadRs(rsRcd, "SODTNET"), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waItem.get_Value(.get_UpperBound(1), SCST) = VB6.Format(ReadRs(rsRcd, "SODTCST"), gsAmtFmt)

                waItem.get_Value(.get_UpperBound(1), SDTID) = To_Value(ReadRs(rsRcd, "SODTID"))
                waItem.get_Value(.get_UpperBound(1), SITMID) = To_Value(ReadRs(rsRcd, "SODTITEMID"))
                waItem.get_Value(.get_UpperBound(1), SVDRID) = To_Value(ReadRs(rsRcd, "SODTVDRID"))

                wiRow = wiRow + 1
                rsRcd.MoveNext()
            Loop
        End With

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        LoadQTItem = True
        Exit Function

LoadQTItem_Err:
        MsgBox("LoadQTItem Err! " & Err.Description)

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function

    Private Sub cmdCstRefresh(ByVal inLine As Integer)
        Dim wiCtr As Short
        Dim wiCtr1 As Short
        Dim wdTotCst As Double
        Dim wdTotNet As Double
        Dim wbBOM As Boolean


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If waItem.get_UpperBound(1) >= 0 Then

            For wiCtr = 0 To waResult.get_UpperBound(1)
                wdTotCst = 0
                wdTotNet = 0
                wbBOM = False

                For wiCtr1 = 0 To waItem.get_UpperBound(1)
                    If Trim(waResult.get_Value(wiCtr, GLINENO)) = Trim(waItem.get_Value(wiCtr1, SLN_Renamed)) Then

                        wdTotCst = wdTotCst + To_Value(waItem.get_Value(wiCtr1, SCST))
                        wdTotNet = wdTotNet + To_Value(waItem.get_Value(wiCtr1, SNET))
                        wbBOM = True
                    End If

                Next wiCtr1

                If wbBOM = True Then
                    If inLine = To_Value(waResult.get_Value(wiCtr, GLINENO)) Then
                        waResult.get_Value(wiCtr, GPRICE) = VB6.Format(wdTotNet, gsAmtFmt)

                        If To_Value(waResult.get_Value(wiCtr, GAMT)) = 0 Then
                            waResult.get_Value(wiCtr, GAMT) = VB6.Format(wdTotNet * To_Value(waResult.get_Value(wiCtr, GDISPER)) / To_Value(waResult.get_Value(wiCtr, GMARKUP)), gsAmtFmt)
                            waResult.get_Value(wiCtr, GNET) = VB6.Format(wdTotNet * To_Value(waResult.get_Value(wiCtr, GQTY)) * To_Value(waResult.get_Value(wiCtr, GDISPER)) / To_Value(waResult.get_Value(wiCtr, GMARKUP)), gsAmtFmt)
                        End If

                        waResult.get_Value(wiCtr, GUCST) = VB6.Format(wdTotCst, gsAmtFmt)
                        waResult.get_Value(wiCtr, GCST) = VB6.Format(wdTotCst * To_Value(waResult.get_Value(wiCtr, GQTY)), gsAmtFmt)
                    End If
                    waResult.get_Value(wiCtr, GBOM) = "Y"
                Else
                    waResult.get_Value(wiCtr, GBOM) = "N"
                End If

            Next wiCtr

            tblDetail.ReBind()
            tblDetail.Col = GDISPER
            tblDetail.Focus()
        End If

        Call Calc_Total()

        Me.Cursor = System.Windows.Forms.Cursors.Default


    End Sub


    Private Function Chk_grdItmClass(ByVal inAccNo As String) As Boolean

        Chk_grdItmClass = False


        If Trim(inAccNo) = "" Then
            gsMsg = "沒有輸入物料分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If


        If UCase(inAccNo) <> "A" And UCase(inAccNo) <> "D" Then
            gsMsg = "沒有此物料分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdItmClass = False
            Exit Function
        End If

        Chk_grdItmClass = True


    End Function





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

    Private Function Chk_txtSpecDis() As Boolean

        Chk_txtSpecDis = False


        If To_Value((txtSpecDis.Text)) > 1 Then
            gsMsg = "對換率超出範圍!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            txtSpecDis.Focus()
            Exit Function
        End If
        txtSpecDis.Text = VB6.Format(txtSpecDis.Text, gsAmtFmt)

        Chk_txtSpecDis = True

    End Function

    Private Sub txtSpecDis_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSpecDis.Leave
        FocusMe(txtSpecDis, True)
    End Sub

    Private Sub cmdPrint()
        Dim wsDteTim As String
        Dim wsSQL As String
        Dim wsSelection() As String
        Dim NewfrmPrint As New frmPrint
        Dim wsRptName As String
        Dim wsDetail As String
        Dim wsByItem As String
        Dim wsTitleCS As String



        'If InputValidation = False Then Exit Sub

        gsMsg = "你要否列印工程單之總額?"
        If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
            wsDetail = "Y"
        Else
            wsDetail = "N"
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Create Selection Criteria
        ReDim wsSelection(4)
        wsSelection(1) = ""
        wsSelection(2) = ""
        wsSelection(3) = ""
        wsSelection(4) = ""



        'Create Stored Procedure String
        wsDteTim = CStr(Now)
        wsSQL = "EXEC usp_RPTSO002 '" & Set_Quote(gsUserID) & "', "
        wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
        wsSQL = wsSQL & "'" & wgsTitle & "', "
        wsSQL = wsSQL & "'" & wgsTitle & "', "
        wsSQL = wsSQL & "'SO', "
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
            wsRptName = "C" & "RPTSO002"
        Else
            wsRptName = "RPTSO002"
        End If

        If wsDetail = "Y" Then wsRptName = wsRptName & "A"


        NewfrmPrint.ReportID = "SO002"
        NewfrmPrint.RptTitle = Me.Text
        NewfrmPrint.TableID = "SO002"
        NewfrmPrint.RptDteTim = wsDteTim
        NewfrmPrint.StoreP = wsSQL
        NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
        NewfrmPrint.RptName = wsRptName
        NewfrmPrint.ShowDialog()

        'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        NewfrmPrint = Nothing

        ' Tom 20090203
        gsMsg = "你要否列印整份BOM由行數排序?"
        If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.Yes Then
            wsByItem = "N"
        Else
            wsByItem = "Y"
        End If


        wsSQL = "EXEC usp_RPTSO002D '" & Set_Quote(gsUserID) & "', "
        wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
        wsSQL = wsSQL & "'" & wgsTitle & "', "
        wsSQL = wsSQL & "'', "
        wsSQL = wsSQL & "'SO', "
        wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
        wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
        wsSQL = wsSQL & "'" & "" & "', "
        wsSQL = wsSQL & "'" & New String("z", 10) & "', "
        wsSQL = wsSQL & "'" & "000000" & "', "
        wsSQL = wsSQL & "'" & "999999" & "', "
        wsSQL = wsSQL & "'" & "%" & "', "
        wsSQL = wsSQL & "'" & wsByItem & "', "
        wsSQL = wsSQL & gsLangID


        If wsByItem = "Y" Then
            wsRptName = "RPTSO002S"
        Else
            wsRptName = "RPTSO002N"
        End If

        If gsLangID = "2" Then
            wsRptName = "C" & wsRptName
        End If


        NewfrmPrint.ReportID = "SO002D"
        NewfrmPrint.RptTitle = Me.Text
        NewfrmPrint.TableID = "SO002D"
        NewfrmPrint.RptDteTim = wsDteTim
        NewfrmPrint.StoreP = wsSQL
        NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
        NewfrmPrint.RptName = wsRptName
        NewfrmPrint.ShowDialog()
        'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        NewfrmPrint = Nothing


        '' Print Appendix
        If Chk_DocAppendix(CStr(wlKey)) = True Then

            wsTitleCS = "CONDITION OF SALES"


            wsSQL = "EXEC usp_RPTDA002 '" & Set_Quote(gsUserID) & "', "
            wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
            wsSQL = wsSQL & "'" & wsTitleCS & "', "
            wsSQL = wsSQL & "'SO', "
            wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
            wsSQL = wsSQL & "'" & Set_Quote(cboDocNo.Text) & "', "
            wsSQL = wsSQL & "'" & "" & "', "
            wsSQL = wsSQL & "'" & New String("z", 10) & "', "
            wsSQL = wsSQL & "'" & "000000" & "', "
            wsSQL = wsSQL & "'" & "999999" & "', "
            wsSQL = wsSQL & gsLangID

            If gsLangID = "2" Then
                wsRptName = "CRPTDA002"
            Else
                wsRptName = "RPTDA002"
            End If


            NewfrmPrint.ReportID = "DA002"
            NewfrmPrint.RptTitle = Me.Text
            NewfrmPrint.TableID = "DA002"
            NewfrmPrint.RptDteTim = wsDteTim
            NewfrmPrint.StoreP = wsSQL
            NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
            NewfrmPrint.RptName = wsRptName
            NewfrmPrint.ShowDialog()
            'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            NewfrmPrint = Nothing



        End If





        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub cmdRevise()


        On Error GoTo cmdRevise_Err


        If DelValidation(wlKey) = False Then
            wiAction = CorRec
            Cursor = System.Windows.Forms.Cursors.Default
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

    Private Function cmdCopyLine(ByVal CRow As Integer) As Integer
        Dim wsLineNo As String
        Dim wiCtr As Integer
        Dim wiLn As Short

        On Error GoTo cmdCopyLine_Err

        wsLineNo = waResult.get_Value(CRow, GLINENO)

        With waResult
            .AppendRows()
            waResult.get_Value(.get_UpperBound(1), GLINENO) = wlLineNo
            waResult.get_Value(.get_UpperBound(1), GDESC1) = waResult.get_Value(CRow, GDESC1)
            waResult.get_Value(.get_UpperBound(1), GMORE) = waResult.get_Value(CRow, GMORE)
            waResult.get_Value(.get_UpperBound(1), GQTY) = VB6.Format(waResult.get_Value(CRow, GQTY), gsQtyFmt)
            waResult.get_Value(.get_UpperBound(1), GPRICE) = VB6.Format(waResult.get_Value(CRow, GPRICE), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GDISPER) = VB6.Format(waResult.get_Value(CRow, GDISPER), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GMARKUP) = VB6.Format(waResult.get_Value(CRow, GMARKUP), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GUOM) = waResult.get_Value(CRow, GUOM)
            waResult.get_Value(.get_UpperBound(1), GUCST) = VB6.Format(waResult.get_Value(CRow, GUCST), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GAMT) = VB6.Format(waResult.get_Value(CRow, GAMT), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GNET) = VB6.Format(waResult.get_Value(CRow, GNET), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GCST) = VB6.Format(waResult.get_Value(CRow, GCST), gsAmtFmt)
            waResult.get_Value(.get_UpperBound(1), GBOM) = waResult.get_Value(CRow, GBOM)
            If To_Value(waResult.get_Value(CRow, GDRMKID)) = 0 Then
                waResult.get_Value(.get_UpperBound(1), GDRMKID) = "0"
            Else
                waResult.get_Value(.get_UpperBound(1), GDRMKID) = Get_DRmkID("QT", waResult.get_Value(CRow, GDRMKID))
            End If
            waResult.get_Value(.get_UpperBound(1), GPTJID) = "0"
            cmdCopyLine = .get_UpperBound(1)

        End With


        wiLn = 1
        With waItem
            If .get_UpperBound(1) >= 0 Then
                For wiCtr = 0 To .get_UpperBound(1)
                    If To_Value(waItem.get_Value(wiCtr, SLN_Renamed)) = To_Value(wsLineNo) Then
                        .AppendRows()
                        waItem.get_Value(.get_UpperBound(1), SLINENO) = wiLn
                        waItem.get_Value(.get_UpperBound(1), SINDENT) = waItem.get_Value(wiCtr, SINDENT)
                        waItem.get_Value(.get_UpperBound(1), SITMTYPE) = waItem.get_Value(wiCtr, SITMTYPE)
                        waItem.get_Value(.get_UpperBound(1), SITMCODE) = waItem.get_Value(wiCtr, SITMCODE)
                        waItem.get_Value(.get_UpperBound(1), SVDRCODE) = waItem.get_Value(wiCtr, SVDRCODE)
                        waItem.get_Value(.get_UpperBound(1), SITMNAME) = waItem.get_Value(wiCtr, SITMNAME)
                        waItem.get_Value(.get_UpperBound(1), SUNITPRICE) = VB6.Format(waItem.get_Value(wiCtr, SUNITPRICE), gsUprFmt)
                        waItem.get_Value(.get_UpperBound(1), SUCST) = VB6.Format(waItem.get_Value(wiCtr, SUCST), gsUprFmt)

                        waItem.get_Value(.get_UpperBound(1), SDISPER) = VB6.Format(waItem.get_Value(wiCtr, SDISPER), gsAmtFmt)

                        waItem.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(waItem.get_Value(wiCtr, SQTY), gsQtyFmt)
                        waItem.get_Value(.get_UpperBound(1), SAMT) = VB6.Format(waItem.get_Value(wiCtr, SAMT), gsAmtFmt)
                        waItem.get_Value(.get_UpperBound(1), SNET) = VB6.Format(waItem.get_Value(wiCtr, SNET), gsAmtFmt)
                        waItem.get_Value(.get_UpperBound(1), SCST) = VB6.Format(waItem.get_Value(wiCtr, SCST), gsAmtFmt)

                        waItem.get_Value(.get_UpperBound(1), SLN_Renamed) = wlLineNo
                        waItem.get_Value(.get_UpperBound(1), SDTID) = "0"
                        waItem.get_Value(.get_UpperBound(1), SITMID) = To_Value(waItem.get_Value(wiCtr, SITMID))
                        waItem.get_Value(.get_UpperBound(1), SVDRID) = To_Value(waItem.get_Value(wiCtr, SVDRID))
                        wiLn = wiLn + 1
                    End If
                Next wiCtr
            End If
        End With

        wlLineNo = wlLineNo + 1


        Exit Function

cmdCopyLine_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

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
            cboJobNo.Focus()

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



    Private Function Chk_CusCode(ByVal InCusNo As String, ByRef OutID As Integer, ByRef OutName As String, ByRef OutTel As String, ByRef OutFax As String, ByRef OutEMail As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String


        wsSQL = "SELECT CusID, CusName, CusTel, CusFax, CusEMail FROM mstCustomer WHERE CusCode = '" & Set_Quote(InCusNo) & "' "
        wsSQL = wsSQL & "And CusStatus = '1' "
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsRcd.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutID = ReadRs(rsRcd, "CusID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsRcd, "CusName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutTel = ReadRs(rsRcd, "CusTel")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutFax = ReadRs(rsRcd, "CusFax")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutEMail = ReadRs(rsRcd, "CusEMail")

            Chk_CusCode = True

        Else

            OutID = 0
            OutName = ""
            OutTel = ""
            OutFax = ""
            OutEMail = ""

            Chk_CusCode = False

        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function


    Private Function DelValidation(ByVal InDocID As Integer) As Boolean
        Dim OutTrnCd As String
        Dim OutDocNo As String



        DelValidation = False

        On Error GoTo DelValidation_Err



        '   If Not chk_txtRevNo Then Exit Function
        If Chk_SoRefDoc(CStr(InDocID), OutTrnCd, OutDocNo) = True Then

            Select Case OutTrnCd
                Case "SP"
                    gsMsg = "配貨單 : " & OutDocNo & " 是以此銷售轉為!不能刪除或改正"
                Case "SW"
                    gsMsg = "發貨單 : " & OutDocNo & " 是以此銷售轉為!不能刪除或改正"
                Case "SR"
                    gsMsg = "退貨單 : " & OutDocNo & " 是以此銷售轉為!不能刪除或改正"
                Case "IV"
                    gsMsg = "發票 : " & OutDocNo & " 是以此銷售轉為!不能刪除或改正"
                Case "PO"
                    gsMsg = "採購單 : " & OutDocNo & " 是以此銷售轉為!不能刪除或改正"
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

    Private Sub cboCRML_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCRML.Enter
        FocusMe(cboCRML)
    End Sub

    Private Sub cboCRML_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCRML.Leave
        FocusMe(cboCRML, True)
    End Sub


    Private Sub cboCRML_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCRML.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim wsDesc As String

        Call chk_InpLen(cboCRML, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboCRML = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0
            medReserveDate.Focus()

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCRML_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCRML.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboCRML

        wsSQL = "SELECT MLCode, MLDESC FROM mstMerchClass WHERE MLCode LIKE '%" & IIf(cboCRML.SelectionLength > 0, "", Set_Quote(cboCRML.Text)) & "%' "
        wsSQL = wsSQL & "AND MLSTATUS = '1' "
        wsSQL = wsSQL & "AND MLTYPE = 'S' "
        wsSQL = wsSQL & "ORDER BY MLCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboCRML.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboCRML.Top) + VB6.PixelsToTwipsY(cboCRML.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLMLCOD", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function Chk_cboCRML() As Boolean
        Dim wsDesc As String

        Chk_cboCRML = False

        If Trim(cboCRML.Text) = "" Then
            gsMsg = "必需輸入會計分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboCRML.Focus()
            Exit Function
        End If


        If Chk_MClass(cboCRML.Text, "S", wsDesc) = False Then
            gsMsg = "沒有此會計分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboCRML.Focus()
            lblDspMLDesc.Text = ""
            Exit Function
        End If

        lblDspCRMLDesc.Text = wsDesc

        Chk_cboCRML = True

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
            tblDetail.Col = GQTY
            tblDetail.Focus()


        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default


    End Sub


    Private Function Chk_SoExistSp(ByVal CRow As Integer) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wsPtjID As String

        On Error GoTo Chk_SoExistSp_Err


        If wiAction <> CorRec Then
            Chk_SoExistSp = True
            Exit Function
        End If


        wsPtjID = waResult.get_Value(CRow, GPTJID)


        If wsPtjID = "0" Then
            Chk_SoExistSp = True
            Exit Function
        End If


        wsSQL = "SELECT * FROM SoaSpHd, SoaSpDt, SoaSoDt "
        wsSQL = wsSQL & " WHERE SpDtSoDtID = SoDtID "
        wsSQL = wsSQL & " AND SoDtPtjID = " & To_Value(wsPtjID) & " "
        wsSQL = wsSQL & " AND SpHDDocID = SpDtDocID "
        wsSQL = wsSQL & " AND SpHDStatus In ('1','4') "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            gsMsg = "不能刪除!物料已轉移到(B)倉!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Chk_SoExistSp = False
            Exit Function
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


        wsSQL = "SELECT * FROM SoaSwHd, SoaSwDt, SoaSoDt "
        wsSQL = wsSQL & " WHERE SwDtSoDtID = SoDtID "
        wsSQL = wsSQL & " AND SoDtPtjID = " & To_Value(wsPtjID) & " "
        wsSQL = wsSQL & " AND SwHDDocID = SwDtDocID "
        wsSQL = wsSQL & " AND SwHDStatus In ('1','4') "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            gsMsg = "不能刪除!物料已轉移到(C)倉!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Chk_SoExistSp = False
            Exit Function
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        Chk_SoExistSp = True


        Exit Function

Chk_SoExistSp_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function


    Private Function Chk_SoExistSpDtQty(ByVal wsDtlID As String, ByVal wsLineNo As String, ByVal wsItemNo As String, ByVal InHDQty As Double, ByVal InQty As Double) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        On Error GoTo Chk_SoExistSpDtQty_Err


        If wsDtlID = "0" Then
            Chk_SoExistSpDtQty = True
            Exit Function
        End If


        wsSQL = "SELECT Sum(SpDtQty) Qty FROM SoaSpHd, SoaSpDt "
        wsSQL = wsSQL & " WHERE SpDtSoDtID = " & To_Value(wsDtlID) & " "
        wsSQL = wsSQL & " AND SpHDDocID = SpDtDocID "
        wsSQL = wsSQL & " AND SpHDStatus In ('1','4') "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            If To_Value(InHDQty) * To_Value(InQty) < To_Value(ReadRs(rsRcd, "Qty")) Then
                gsMsg = wsLineNo & " : " & wsItemNo & " 數量不足!物料已轉移到(B)倉!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                rsRcd.Close()
                'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                rsRcd = Nothing
                Chk_SoExistSpDtQty = False
                Exit Function
            End If
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        Chk_SoExistSpDtQty = True


        Exit Function

Chk_SoExistSpDtQty_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function


    Private Function ChkSoDetail() As Boolean
        Dim wiCtr As Short
        Dim wiCtr1 As Short
        Dim wdHdQty As Double

        Dim wsDtlID As String
        Dim wsItemNo As String
        Dim wdQty As Double

        ChkSoDetail = True

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If waItem.get_UpperBound(1) >= 0 Then

            For wiCtr = 0 To waResult.get_UpperBound(1)
                wdHdQty = To_Value(waResult.get_Value(wiCtr, GQTY))
                For wiCtr1 = 0 To waItem.get_UpperBound(1)
                    If Trim(waResult.get_Value(wiCtr, GLINENO)) = Trim(waItem.get_Value(wiCtr1, SLN_Renamed)) Then

                        wsDtlID = CStr(To_Value(waItem.get_Value(wiCtr1, SDTID)))
                        wsItemNo = waItem.get_Value(wiCtr1, SITMCODE)
                        wdQty = To_Value(waItem.get_Value(wiCtr1, SQTY))

                        If Chk_SoExistSpDtQty(wsDtlID, waResult.get_Value(wiCtr, GLINENO), wsItemNo, wdHdQty, wdQty) = False Then
                            ChkSoDetail = False
                            Me.Cursor = System.Windows.Forms.Cursors.Default
                            Exit Function
                        End If

                    End If

                Next wiCtr1
            Next wiCtr

        End If


        Me.Cursor = System.Windows.Forms.Cursors.Default


    End Function


    Private Sub cboJobNo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.Enter
        FocusMe(cboJobNo)
    End Sub

    Private Sub cboJobNo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.Leave
        FocusMe(cboJobNo, True)
    End Sub


    Private Sub cboJobNo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboJobNo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim wdCost As Double

        Call chk_InpLen(cboJobNo, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboJobNo = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 0

            wdCost = Get_JobCost(cboJobNo.Text)
            txtJobCost.Text = VB6.Format(wdCost, gsAmtFmt)
            txtJobCost.Focus()

        End If

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboJobNo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboJobNo.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboJobNo

        wsSQL = "SELECT SOHDDOCNO FROM SOASOHD WHERE SOHDDOCNO LIKE '%" & IIf(cboJobNo.SelectionLength > 0, "", Set_Quote(cboJobNo.Text)) & "%' "
        wsSQL = wsSQL & "AND SOHDSTATUS IN ('1','4') "
        wsSQL = wsSQL & "AND SOHDCUSID = " & wlCusID & " "
        wsSQL = wsSQL & "ORDER BY SOHDDOCNO "

        Call Ini_Combo(1, wsSQL, VB6.PixelsToTwipsX(cboJobNo.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboJobNo.Top) + VB6.PixelsToTwipsY(cboJobNo.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, wsFormID, "TBLJOBNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function Chk_cboJobNo() As Boolean


        Chk_cboJobNo = False

        If Trim(cboJobNo.Text) = "" Then
            gsMsg = "必需輸入工程編號!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 0
            cboJobNo.Focus()
            Exit Function
        End If





        Chk_cboJobNo = True

    End Function



    Private Sub txtJobCost_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtJobCost.Enter

        FocusMe(txtJobCost)

    End Sub

    Private Sub txtJobCost_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtJobCost.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        Call Chk_InpNum(KeyAscii, (txtJobCost.Text), False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_txtJobCost Then

                tabDetailInfo.SelectedIndex = 0
                txtShipFrom.Focus()

            End If
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Function chk_txtJobCost() As Boolean
		
		chk_txtJobCost = False
		
		
		If To_Value((txtJobCost.Text)) < 0 Then
			gsMsg = "錯誤!一定大於零"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 0
			txtJobCost.Focus()
			Exit Function
		End If
		
		txtJobCost.Text = VB6.Format(txtJobCost.Text, gsAmtFmt)
		
		chk_txtJobCost = True
		
	End Function
	
	Private Sub txtJobCost_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtJobCost.Leave
		txtJobCost.Text = VB6.Format(txtJobCost.Text, gsAmtFmt)
		FocusMe(txtJobCost, True)
	End Sub
	
	
	Private Sub cmdAppendix()
		
		Dim newForm As System.Windows.Forms.Form
		
		newForm = New frmDocAppendix
		
		With newForm
			'UPGRADE_ISSUE: Control DocID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
            '.DocID = wlKey
			'UPGRADE_ISSUE: Control RmkID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
            '.RmkID = "0"
			'UPGRADE_ISSUE: Control RmkType could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
            '.RmkType = wsTrnCd
			.ShowDialog()
		End With
		
		newForm.Close()
		
		
	End Sub
End Class