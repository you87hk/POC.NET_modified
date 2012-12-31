Option Strict Off
Option Explicit On
Friend Class frmDocAppendix
	Inherits System.Windows.Forms.Form
	
	
	
	Private wsFormID As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	'variable for new property
	Private msDocID As String
	Private msRmkID As String
	Private msRmkType As String
	
	Private wsRmkPrint As String
	Private Const wsPhotoPath As String = "..\Photo\"
	
	Private wbExit As Boolean
	Private wsOldRmk As String
	
	
	
	Property DocID() As String
		Get
			
			DocID = msDocID
			
		End Get
		Set(ByVal Value As String)
			
			msDocID = Value
			
		End Set
	End Property
	
	
	
	Property RmkID() As String
		Get
			
			RmkID = msRmkID
			
		End Get
		Set(ByVal Value As String)
			
			msRmkID = Value
			
		End Set
	End Property
	WriteOnly Property RmkType() As String
		Set(ByVal Value As String)
			
			msRmkType = Value
			
		End Set
	End Property
	
	
	
	
	
	
	
	Private Sub btnClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClear.Click
		Call Clear_Cover()
		Me.txtItmDir.Text = ""
		
	End Sub
	
	Private Sub btnDelTemp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDelTemp.Click
		Call cmdSaveAs(1)
	End Sub
	
	Private Sub btnItmDir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnItmDir.Click
		Dim wsFilePath As String
		
		
		cdlgDirOpen.InitialDirectory = wsPhotoPath
		cdlgDirOpen.FileName = ""
		cdlgDirOpen.ShowDialog()
		wsFilePath = cdlgDirOpen.FileName
		
		If Trim(wsFilePath) = "" Then Exit Sub
		
		If Chk_Load_Cover(wsFilePath) Then
			txtItmDir.Text = wsFilePath
			'tabDetailInfo.Tab = 1
			'txtR
		End If
		
	End Sub
	
	Private Sub btnSaveAs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSaveAs.Click
		Call cmdSaveAs(0)
	End Sub
	
	Private Sub frmDocAppendix_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub frmDocAppendix_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If wbExit = False Then
			
			Call cmdSave()
			wbExit = True
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			Me.Hide()
			Exit Sub
			
		End If
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmDocAppendix may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	
	
	
	Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
		Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
		
		If tabDetailInfo.SelectedIndex = 0 Then
			
			'      If txtRmk.Enabled Then
			'          txtRmk.SetFocus
			'      End If
			
		ElseIf tabDetailInfo.SelectedIndex = 1 Then 
			
			' If Me.tblCusItem.Enabled Then
			'     tblCusItem.SetFocus
		End If
		
		
		PreviousTab = tabDetailInfo.SelectedIndex()
	End Sub
	
	
	
	Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick
		
		wcCombo.Text = tblCommon.Columns(0).Text
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
	
	
	Private Sub txtItmDir_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDir.Enter
		FocusMe(txtItmDir)
	End Sub
	
	Private Sub txtItmDir_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItmDir.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtItmDir, 50, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 1
            If Trim(txtItmDir.Text) = "" Then
                Clear_Cover()
                btnItmDir.Focus()
            Else
                If Chk_Load_Cover(txtItmDir.Text) Then
                    btnItmDir.Focus()
                End If
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtItmDir_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtItmDir.Leave
        FocusMe(txtItmDir, True)
    End Sub


    Private Sub txtRmk_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Enter
        '    FocusMe txtRmk
    End Sub

    Private Sub txtRmk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtRmk.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'Call chk_InpLen(txtRmk, KeyLen, KeyAscii)


        '   If Len(txtRmk.Text) Mod 50 = 0 And KeyAscii <> vbKeyReturn And KeyAscii <> vbKeyBack Then
        '       KeyAscii = vbKeyReturn
        '   End If


        '  If KeyAscii = vbKeyReturn Then
        '        KeyAscii = vbDefault

        '        If Chk_txtRmk() = False Then Exit Sub



        '  End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtRmk_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRmk.Leave
        FocusMe(txtRmk, True)
    End Sub

    Private Sub Ini_Form()

        Me.KeyPreview = True
        wsFormID = "DOCAPP"


    End Sub

    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err

        Call Get_Scr_Item(wsFormID, waScrItm)

        Me.Text = Get_Caption(waScrItm, "SCRHDR")

        lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
        btnSaveAs.Text = Get_Caption(waScrItm, "SAVEAS")
        btnDelTemp.Text = Get_Caption(waScrItm, "DELTEMP")



        tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO01")
        tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO02")

        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub

    Private Function Chk_txtRmk() As Boolean

        Dim wsMsg As String

        Chk_txtRmk = False

        If Trim(txtRmk.Text) = "" Then
            wsMsg = "Remark Must Input!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
            txtRmk.Focus()
            Exit Function
        End If

        Chk_txtRmk = True

    End Function

    Private Sub Ini_Scr()



        wbExit = False

        tabDetailInfo.SelectedIndex = 0

        Call LoadRecord()


    End Sub

    Public Function LoadRecord() As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset


        Select Case msRmkType
            Case "SO"
                wsSQL = "SELECT DAID, DARemark, DAName, DAPATH "
                wsSQL = wsSQL & "FROM mstDocAppendix "
                wsSQL = wsSQL & "WHERE DADOCID = " & msDocID

                lblDspDocNo.Text = Get_TableInfo("SOASOHD", "SOHDDOCID =" & msDocID, "SOHDDOCNO")

            Case "SN"
                wsSQL = "SELECT DAID, DARemark, DAName, DAPATH "
                wsSQL = wsSQL & "FROM mstDocAppendix "
                wsSQL = wsSQL & "WHERE DADOCID = " & msDocID

                lblDspDocNo.Text = Get_TableInfo("SOASNHD", "SNHDDOCID =" & msDocID, "SNHDDOCNO")


            Case Else

                wsSQL = "SELECT DAID, ARemark, DAName "
                wsSQL = wsSQL & "FROM mstDocAppendix "
                wsSQL = wsSQL & "WHERE DAID = " & msRmkID

        End Select


        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount = 0 Then
            '  Me.txtSaveAs = lblDspDocNo.Caption
            LoadRecord = False
        Else
            '  Me.txtSaveAs = ReadRs(rsRcd, "DAName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msRmkID = ReadRs(rsRcd, "DAID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtRmk.Text = ReadRs(rsRcd, "DARemark")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtItmDir.Text = ReadRs(rsRcd, "DAPATH")
            wsOldRmk = txtRmk.Text

            '        Call LoadItemImg(msRmkID)

            LoadRecord = True
        End If
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        Call Clear_Cover()

        If Trim(txtItmDir.Text) <> "" Then
            Call Load_Cover(Trim(txtItmDir.Text))
        End If

    End Function

    Public Function LoadTemplete() As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset


        wsSQL = "SELECT DAID, DANAME, DARemark, DAPATH "
        wsSQL = wsSQL & "FROM mstDocAppendix "
        wsSQL = wsSQL & "WHERE DANAME = '" & Set_Quote(cboTemplete.Text) & "'"



        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount = 0 Then
            LoadTemplete = False
        Else
            '    Me.txtSaveAs = ReadRs(rsRcd, "DAName")

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            msRmkID = ReadRs(rsRcd, "DAID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtRmk.Text = ReadRs(rsRcd, "DARemark")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtItmDir.Text = ReadRs(rsRcd, "DAPATH")
            wsOldRmk = txtRmk.Text

            ' Call LoadItemImg(msRmkID)
            LoadTemplete = True
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


        Call Clear_Cover()

        If Trim(txtItmDir.Text) <> "" Then
            Call Load_Cover(Trim(txtItmDir.Text))
        End If

    End Function


    Private Function cmdSave() As Boolean

        Dim wsGenDte As String
        Dim iDel As Short
        Dim adcmdSave As New ADODB.Command

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        If Trim(txtRmk.Text) = "" Then
            iDel = 1
        Else
            iDel = 0
        End If

        If wsOldRmk = txtRmk.Text Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If

        Call cmdReplace()

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_DA001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, msDocID)
        Call SetSPPara(adcmdSave, 2, iDel)
        Call SetSPPara(adcmdSave, 3, msRmkType)
        Call SetSPPara(adcmdSave, 4, txtSaveAs.Text)
        Call SetSPPara(adcmdSave, 5, Trim(txtRmk.Text))
        Call SetSPPara(adcmdSave, 6, wsRmkPrint)
        Call SetSPPara(adcmdSave, 7, txtItmDir.Text)
        Call SetSPPara(adcmdSave, 8, gsUserID)
        Call SetSPPara(adcmdSave, 9, wsGenDte)
        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msRmkID = GetSPPara(adcmdSave, 10)

        cnCon.CommitTrans()

        If Trim(msRmkID) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - DOCAPPENDIX!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        Else

            ' Call InsItemImg(txtItmDir.Text, msRmkID)

            gsMsg = "已成功儲存!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        End If


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


    Private Function cmdSaveAs(ByRef iDel As Short) As Boolean
        Dim wsGenDte As String

        Dim adcmdSaveAs As New ADODB.Command

        On Error GoTo cmdSaveAs_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate


        If iDel = 0 Then

            If Trim(txtSaveAs.Text) = "" Then
                gsMsg = "範本名稱沒有輸入!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If

        Else

            If Trim(cboTemplete.Text) = "" Then
                gsMsg = "範本名稱沒有輸入!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If


        End If

        If Trim(txtRmk.Text) = "" Then
            gsMsg = "內容沒有輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If



        cnCon.BeginTrans()
        adcmdSaveAs.ActiveConnection = cnCon

        adcmdSaveAs.CommandText = "USP_DA001"
        adcmdSaveAs.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSaveAs.Parameters.Refresh()

        Call SetSPPara(adcmdSaveAs, 1, "")
        Call SetSPPara(adcmdSaveAs, 2, iDel)
        Call SetSPPara(adcmdSaveAs, 3, "SM")
        Call SetSPPara(adcmdSaveAs, 4, IIf(iDel = 1, cboTemplete.Text, txtSaveAs.Text))
        Call SetSPPara(adcmdSaveAs, 5, txtRmk.Text)
        Call SetSPPara(adcmdSaveAs, 6, wsRmkPrint)
        Call SetSPPara(adcmdSaveAs, 7, txtItmDir.Text)
        Call SetSPPara(adcmdSaveAs, 8, gsUserID)
        Call SetSPPara(adcmdSaveAs, 9, wsGenDte)
        adcmdSaveAs.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        msRmkID = GetSPPara(adcmdSaveAs, 10)

        cnCon.CommitTrans()

        If Trim(msRmkID) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - DOCAPPENDIX!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        Else

            '   Call InsItemImg(txtItmDir.Text, msRmkID)

            gsMsg = "已成功儲存!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        End If


        'UPGRADE_NOTE: Object adcmdSaveAs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSaveAs = Nothing
        cmdSaveAs = True

        Cursor = System.Windows.Forms.Cursors.Default

        Exit Function

cmdSaveAs_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSaveAs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSaveAs = Nothing

    End Function

    Private Sub frmDocAppendix_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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


            Case System.Windows.Forms.Keys.Escape
                wbExit = True
                Me.Close()
        End Select
    End Sub

    Private Sub cmdReplace()

        Dim inText As String
        Dim replaceTxt As String
        Dim Totxt As String


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        inText = txtRmk.Text


        Select Case msRmkType
            Case "SO"

                replaceTxt = "@NETAMT"
                Totxt = Get_TableInfo("SOASOHD", "SOHDDOCID = " & msDocID, "SOHDNETAMT")
                Totxt = VB6.Format(Totxt, gsAmtFmt)
                inText = Replace_Str(inText, replaceTxt, Totxt)

                replaceTxt = "@DOCNO"
                Totxt = Get_TableInfo("SOASOHD", "SOHDDOCID = " & msDocID, "SOHDDOCNO")
                inText = Replace_Str(inText, replaceTxt, Totxt)

                replaceTxt = "@CURR"
                Totxt = Get_TableInfo("SOASOHD", "SOHDDOCID = " & msDocID, "SOHDCURR")
                inText = Replace_Str(inText, replaceTxt, Totxt)

            Case "SN"

                replaceTxt = "@NETAMT"
                Totxt = Get_TableInfo("SOASNHD", "SNHDDOCID = " & msDocID, "SNHDNETAMT")
                Totxt = VB6.Format(Totxt, gsAmtFmt)
                inText = Replace_Str(inText, replaceTxt, Totxt)

                replaceTxt = "@DOCNO"
                Totxt = Get_TableInfo("SOASNHD", "SNHDDOCID = " & msDocID, "SNHDDOCNO")
                inText = Replace_Str(inText, replaceTxt, Totxt)

                replaceTxt = "@CURR"
                Totxt = Get_TableInfo("SOASNHD", "SNHDDOCID = " & msDocID, "SNHDCURR")
                inText = Replace_Str(inText, replaceTxt, Totxt)

        End Select



        ' txtRmk.Text = inText
        wsRmkPrint = inText

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmDocAppendix.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub


    Private Sub cboTemplete_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemplete.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboTemplete

        wsSQL = "SELECT DANAME, Cast(DARemark as char(30)) "
        wsSQL = wsSQL & " FROM mstDocAppendix "
        wsSQL = wsSQL & " WHERE DAType  = 'SM' "
        wsSQL = wsSQL & " AND DAStatus = '1' "

        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboTemplete.Left)), VB6.PixelsToTwipsY(cboTemplete.Top) + VB6.PixelsToTwipsY(cboTemplete.Height), tblCommon, wsFormID, "TBLTEMP", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboTemplete_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemplete.Enter
        FocusMe(cboTemplete)
        wcCombo = cboTemplete
    End Sub

    Private Sub cboTemplete_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboTemplete.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboTemplete.Text) <> "" Then
                Call LoadTemplete()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboTemplete_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTemplete.Leave
        FocusMe(cboTemplete, True)
    End Sub

    Private Sub txtSaveAs_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSaveAs.Enter
        FocusMe(txtSaveAs)
    End Sub




    Private Sub txtSaveAs_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSaveAs.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtSaveAs, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            btnSaveAs.Focus()

        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	
	Private Sub txtSaveAs_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSaveAs.Leave
		FocusMe(txtSaveAs, True)
	End Sub
	
	
	
	Private Function Clear_Cover() As Boolean
		On Error GoTo Clear_Cover_Err
		
		Clear_Cover = False
		imgCover.Image = Nothing
		Clear_Cover = True
		Exit Function
		
Clear_Cover_Err: 
		Clear_Cover = False
	End Function
	
	
	Private Function Chk_Load_Cover(ByRef inPath As String) As Boolean
		Chk_Load_Cover = False
		
		If Load_Cover(inPath) = False Then
			gsMsg = "封面圖象不存在或錯誤!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			tabDetailInfo.SelectedIndex = 1
			txtItmDir.Focus()
			Exit Function
		End If
		
		Chk_Load_Cover = True
	End Function
	
	Private Function Load_Cover(ByRef inPath As String) As Boolean
		On Error GoTo Load_Cover_Err
		
		Load_Cover = False
		imgCover.Image = System.Drawing.Image.FromFile(inPath)
		Load_Cover = True
		Exit Function
		
Load_Cover_Err: 
		Load_Cover = False
	End Function
	
	
	Private Function InsItemImg(ByVal inFileName As String, ByVal InDAId As Integer) As Short
		
		On Error GoTo Err_Hanlder
		Dim rs As New ADODB.Recordset
		Dim stm As ADODB.Stream
		Dim wsSQL As String
		
		
		If Trim(inFileName) = "" Then
			Exit Function
		End If
		
		stm = New ADODB.Stream
		
		wsSQL = "Select * from mstDocAppendix Where DAID = " & InDAId
		
		rs.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
		
		'   rs.Open "Select * from MstItemImg Where IMItemID = " & InItmID, m_dbh.GetConnection, adOpenKeyset, adLockOptimistic
		'Read the binary files from disk.
		stm.Type = ADODB.StreamTypeEnum.adTypeBinary
		stm.Open()
		stm.LoadFromFile(inFileName)
		
		If rs.RecordCount = 0 Then
			'rs.AddNew
			'rs!IMItemID = InItmID
			'rs!IMpath = inFileName
			'rs!IMImg = stm.Read
			'Insert the binary object into the table.
			'rs.Update
			InsItemImg = 0
		Else
			rs.Fields("DaPath").Value = inFileName
			'UPGRADE_WARNING: Couldn't resolve default property of object stm.Read. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rs.Fields("DAImg").Value = stm.Read
			'Insert the binary object into the table.
			rs.UPDATE()
			
		End If
		
		
		
		rs.Close()
		stm.Close()
		
		InsItemImg = 1
		
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		'UPGRADE_NOTE: Object stm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		stm = Nothing
		
		
		'Call m_dbh.RunSQL("Update MstItem Set ItmPackingSize = '" & Set_Key(inFileName) & "' Where ItmID = " & To_Num(InItmID), Array())
		
		Exit Function
		
Err_Hanlder: 
		
		InsItemImg = 0
		MsgBox(Err.Description & " -> Insert Photo Failed!")
		rs.Close()
		stm.Close()
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		'UPGRADE_NOTE: Object stm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		stm = Nothing
		
	End Function
	
	
	
	Private Sub LoadItemImg(ByVal InDAId As Integer)
		Dim Buffer As Object
		
		On Error GoTo Err_Hanlder
		Dim rs As New ADODB.Recordset
		Dim wsSQL As String
		Dim DataFile, Chunks As Short
		Dim Fl As Integer
		Dim Fragment, i As Short
		Dim Chunk() As Byte
		Dim FileName As String
		Dim ChunkSize, conChunkSize As Short
		
		ChunkSize = 16384
		conChunkSize = 100
		
		Call Clear_Cover()
		
		wsSQL = "Select * from mstDocAppendix Where DAID = " & InDAId
		
		rs.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If rs.RecordCount <> 0 Then
			
			DataFile = 1
			FileOpen(DataFile, "pictemp", OpenMode.Binary, OpenAccess.Write)
			Fl = rs.Fields("DAImg").ActualSize ' Length of data in file
			If Fl = 0 Then FileClose(DataFile) : Exit Sub
			Chunks = Fl \ ChunkSize
			Fragment = Fl Mod ChunkSize
			ReDim Chunk(Fragment)
			'UPGRADE_WARNING: Couldn't resolve default property of object rs!DAImg.GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Chunk = rs.Fields("DAImg").GetChunk(Fragment)
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FilePut(DataFile, Chunk)
			For i = 1 To Chunks
				ReDim Buffer(ChunkSize)
				'UPGRADE_WARNING: Couldn't resolve default property of object rs!DAImg.GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Chunk = rs.Fields("DAImg").GetChunk(ChunkSize)
				'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FilePut(DataFile, Chunk)
			Next i
			FileClose(DataFile)
			FileName = "pictemp"
			imgCover.Image = System.Drawing.Image.FromFile(FileName)
			
			
		End If
		
		
		rs.Close()
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		
		Exit Sub
		
Err_Hanlder: 
		
		
		MsgBox(Err.Description & " -> Insert Photo Failed!")
		rs.Close()
		'UPGRADE_NOTE: Object rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		
	End Sub
End Class