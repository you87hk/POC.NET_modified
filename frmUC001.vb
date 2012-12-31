Option Strict Off
Option Explicit On
Friend Class frmUC001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbReadOnly As Boolean
	
	Private wsOldCusNo As String
	
	Private wgsTitle As String
	
	Private Const ITMCODE As Short = 0
	Private Const ITMDESC As Short = 1
	Private Const ITMWHSCODE As Short = 2
	Private Const ITMAVECOST As Short = 3
	Private Const ITMID As Short = 4
	
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
	Private wlLineNo As Integer
	
	Private wlKey As Integer
	Private wsActNam(4) As String
	
	Private wsConnTime As String
	Private Const wsKeyType As String = "MstWhsItem"
	Private wsFormID As String
	Private wsUsrId As String
	Private wsTrnCd As String
	Private wsDocNo As String
	
	Private wbErr As Boolean
	Private wsBaseCurCd As String
	
	Private wsFormCaption As String
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, ITMCODE, ITMID)
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
		
		wbReadOnly = False
		
		Call SetButtonStatus("Default")
		Call SetFieldStatus("Default")
		Call SetFieldStatus("AfrActEdit")
		
		'lblDspYear = Left(gsSystemDate, 4)
		
		wlKey = 0
		wlLineNo = 1
		wsTrnCd = ""
		
		'tblCommon.Visible = False
		
		Me.Text = wsFormCaption
		'FocusMe cboJobCode
		
		'Ini_Scr_AfrKey
		'tblDetail.Col = ITMAVECOST
		'tblDetail.ScrollBars = dbgVertical
		'cboItmCodeFr.SetFocus
		FocusMe(cboItmCodeFr)
	End Sub
	
	Private Sub Ini_Scr_AfrKey()
		If LoadRecord() = False Then
			wiAction = AddRec
			Call SetButtonStatus("AfrKeyAdd")
		Else
			wiAction = CorRec
			'If RowLock(wsConnTime, wsKeyType, cboJobCode.Text, wsFormID, wsUsrId) = False Then
			'    gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
			'    MsgBox gsMsg, vbOKOnly, gsTitle
			'    tblDetail.ReBind
			'End If
			
			Call SetButtonStatus("AfrKeyEdit")
		End If
		
		Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
		
		Call SetFieldStatus("AfrKey")
		
		'If tblDetail.Enabled = True Then
		'    tblDetail.Col = ITMWHSCODE
		'    tblDetail.SetFocus
		'End If
		
		'      wiAction = AddRec
		'      Me.Caption = wsFormCaption & " - " & wsActNam(wiAction)
		'      Call SetButtonStatus("AfrKeyAdd")
		'      Call SetFieldStatus("AfrKey")
		
		'      cboSaleCode.SetFocus
	End Sub
	
	Private Sub cboItmCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Leave
		FocusMe(cboItmCodeTo, True)
	End Sub
	
	'UPGRADE_WARNING: Form event frmUC001.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmUC001_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If OpenDoc = True Then
			OpenDoc = False
			'Set wcCombo = cboCusCode
			'Call cboCusCode_DropDown
		End If
	End Sub
	
	Private Sub frmUC001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.PageDown
				'KeyCode = 0
				'If tabDetailInfo.Tab < tabDetailInfo.Tabs - 1 Then
				'    tabDetailInfo.Tab = tabDetailInfo.Tab + 1
				'    Exit Sub
				'End If
				
			Case System.Windows.Forms.Keys.PageUp
				'KeyCode = 0
				'If tabDetailInfo.Tab > 0 Then
				'    tabDetailInfo.Tab = tabDetailInfo.Tab - 1
				'    Exit Sub
				'End If
				
			Case System.Windows.Forms.Keys.F6
				Call cmdOpen()
				
			Case System.Windows.Forms.Keys.F2
				If wiAction = DefaultPage Then Call cmdNew()
				
				'Case vbKeyF5
				'    If wiAction = DefaultPage Then Call cmdEdit
				
				'Case vbKeyF3
				'    If wiAction = DefaultPage Then Call cmdDel
				
			Case System.Windows.Forms.Keys.F7
				If tbrProcess.Items.Item(tcRefresh).Enabled = True Then Call cmdRefresh()
				
			Case System.Windows.Forms.Keys.F10
				If tbrProcess.Items.Item(tcSave).Enabled = True Then Call cmdSave()
				
			Case System.Windows.Forms.Keys.F11
				If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
		End Select
	End Sub
	
	Private Sub frmUC001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Grid()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Caption()
		
		On Error GoTo Ini_Caption_Err
		
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblItmCodeFr.Text = Get_Caption(waScrItm, "ITMCODEFR")
		lblItmCodeTo.Text = Get_Caption(waScrItm, "ITMCODETO")
		
		With tblDetail
			.Columns(ITMCODE).Caption = Get_Caption(waScrItm, "ITMCODE")
			.Columns(ITMDESC).Caption = Get_Caption(waScrItm, "ITMDESC")
			.Columns(ITMWHSCODE).Caption = Get_Caption(waScrItm, "ITMWHSCODE")
			.Columns(ITMAVECOST).Caption = Get_Caption(waScrItm, "ITMAVECOST")
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
		
		wsActNam(1) = Get_Caption(waScrItm, "UCADD")
		wsActNam(2) = Get_Caption(waScrItm, "UCEDIT")
		wsActNam(3) = Get_Caption(waScrItm, "UCDELETE")
		
		Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)
		
		Exit Sub
		
Ini_Caption_Err: 
		
		MsgBox("Please Check ini_Caption!")
		
	End Sub
	
	Private Sub frmUC001_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		'    If Button = 2 Then
		'        PopupMenu mnuMaster
		'    End If
		
	End Sub
	
	Private Sub frmUC001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If SaveData = True Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If

        Call UnLockAll(wsConnTime, wsFormID)

        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing
        '    Set waPgmItm = Nothing
        'UPGRADE_NOTE: Object frmUC001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
    End Sub

    Private Function cmdSave() As Boolean
        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wlRowCtr As Integer
        Dim wsCtlPrd As String
        Dim wsSts As String
        Dim i As Short

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        'If wiAction <> AddRec Then
        '    If ReadOnlyMode(wsConnTime, wsKeyType, cboJobCode.Text, wsFormID) Or wbReadOnly Then
        '        gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
        '        MsgBox gsMsg, vbOKOnly, gsTitle
        '        MousePointer = vbDefault
        '        Exit Function
        '    End If
        'End If

        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Function
        End If

        '' Last Check when Add
        'If wiAction = AddRec Then
        '    If Chk_KeyExist() = True Then
        '        Call GetNewKey
        '    End If
        'End If

        ' If lblDspNetAmtOrg.Caption > Get_CreditLimit(wlCusID, wlKey, Trim(medDocDate.Text)) Then
        '    gsMsg = "已超過信貸額!"
        '    MsgBox gsMsg, vbOKOnly, gsTitle
        '    MousePointer = vbDefault
        '    Exit Function
        ' End If

        wlRowCtr = waResult.get_UpperBound(1)
        'wsCtlPrd = Left(medDocDate, 4) & Mid(medDocDate, 6, 2)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_UC001"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, ITMCODE)) <> "" Then
                    Call SetSPPara(adcmdSave, 1, waResult.get_Value(wiCtr, ITMID))
                    Call SetSPPara(adcmdSave, 2, waResult.get_Value(wiCtr, ITMWHSCODE))
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, ITMAVECOST))
                    Call SetSPPara(adcmdSave, 4, gsUserID)
                    Call SetSPPara(adcmdSave, 5, wsGenDte)
                    adcmdSave.Execute()
                End If
            Next
        End If
        cnCon.CommitTrans()

        'If wiAction = AddRec Then
        '    If Trim(wsDocNo) <> "" Then
        '        Call cmdPrint(wsDocNo)
        '        gsMsg = "文件號 : " & wsDocNo & " 已製成!"
        '        MsgBox gsMsg, vbOKOnly, gsTitle
        '    Else
        '        gsMsg = "文件儲存失敗!"
        '        MsgBox gsMsg, vbOKOnly, gsTitle
        '    End If
        'End If

        If wiAction = CorRec Then
            gsMsg = "文件已儲存!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        End If

        'Call UnLockAll(wsConnTime, wsFormID)
        Call cmdCancel()
        Call SetButtonStatus("AfrKeyEdit")
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

    Private Function cmdDel() As Boolean
        cmdDel = True
    End Function

    Private Function InputValidation() As Boolean
        InputValidation = False

        On Error GoTo InputValidation_Err

        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer
        Dim wlCtr1 As Integer

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, ITMAVECOST)) <> "" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Col = ITMAVECOST
                        tblDetail.Focus()
                        Exit Function
                    End If
                End If
                'For wlCtr1 = 0 To .UpperBound(1)
                '    If wlCtr <> wlCtr1 Then
                '        If waResult(wlCtr, BOOKCODE) = waResult(wlCtr1, BOOKCODE) Then
                '          gsMsg = "重覆物料於第 " & waResult(wlCtr, LINENO) & " 行!"
                '          MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
                '          tblDetail.Col = BOOKCODE
                '          tblDetail.SetFocus
                '          Exit Function
                '        End If
                '    End If
                'Next
            Next
        End With

        If wiEmptyGrid = True Then
            gsMsg = "沒有詳細資料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            If tblDetail.Enabled Then
                tblDetail.Col = ITMAVECOST
                tblDetail.Focus()
            End If
            Exit Function
        End If

        'If Chk_NoDup(To_Value(tblDetail.Bookmark)) = False Then
        '    tblDetail.FirstRow = tblDetail.Row
        '    tblDetail.Col = BOOKCODE
        '    tblDetail.SetFocus
        '    Exit Function
        'End If

        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function

    Private Sub cmdNew()
        Dim newForm As New frmUC001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
        newForm.Show()
    End Sub

    Private Sub cmdOpen()
        Dim newForm As New frmUC001

        newForm.OpenDoc = True
        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)
        newForm.Show()
    End Sub

    Private Sub Ini_Form()
        Me.KeyPreview = True
        '    Me.Left = (Screen.Width - Me.Width) / 2
        '    Me.Top = (Screen.Height - Me.Height) / 2

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'Me.tblDetail.Height = Me.Height - Me.tbrProcess.Height - Me.fra1.Height

        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "UC001"
        wsBaseCurCd = Get_CompanyFlag("CMPCURR")

        Call LoadWSINFO()
    End Sub

    Private Sub cmdCancel()

        Call Ini_Scr()
        Call UnLockAll(wsConnTime, wsFormID)
        Call SetButtonStatus("Default")

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

    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmUC001.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click, _tbrProcess_Button15.Click, _tbrProcess_Button16.Click
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
            .AllowAddNew = False
            .AllowUpdate = True
            .AllowDelete = False
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
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).DataWidth = 13
                        .Columns(wiCtr).Locked = True
                    Case ITMDESC
                        .Columns(wiCtr).Width = 6000
                        .Columns(wiCtr).DataWidth = 60
                        .Columns(wiCtr).Locked = True
                    Case ITMWHSCODE
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).DataWidth = 13
                        .Columns(wiCtr).Locked = True
                    Case ITMAVECOST
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                    Case ITMID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                End Select
            Next
            '  .Styles("EvenRow").BackColor = &H8000000F
        End With
    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        Dim sTemp As String

        With tblDetail
            sTemp = .Columns(eventArgs.ColIndex).Text
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With

        'If ColIndex = COSTCODE Then
        '    Call LoadJobCost(sTemp)
        'End If
    End Sub

    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsCostCode As String
        Dim wsCostDesc As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        'If tblCommon.Visible = True Then
        '    Cancel = False
        '    tblDetail.Columns(ColIndex).Text = OldValue
        '    Exit Sub
        'End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case ITMAVECOST
                    'If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                    '    GoTo Tbl_BeforeColUpdate_Err
                    'End If

                    If Chk_grdBal((.Columns(ITMAVECOST).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(ITMAVECOST).Text = VB6.Format(.Columns(ITMAVECOST).Text, gsAmtFmt)
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
                        Case ITMAVECOST
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = ITMAVECOST
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
        Select Case tblDetail.Col
            Case ITMAVECOST
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
                .Col = ITMAVECOST
            End If

            'Call Calc_Total

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case ITMAVECOST
                        Call Chk_grdBal((.Columns(ITMAVECOST).Text))

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub

    Private Function Chk_grdBal(ByRef inBal As String) As Boolean
        Chk_grdBal = False

        If Trim(inBal) = "" Then
            gsMsg = "必需輸入數值!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdBal = False
            Exit Function
        End If

        'If To_Value(inBal) < 0 Then
        '    gsMsg = "數量必需大過或等於零!"
        '    MsgBox gsMsg, vbOKOnly, gsTitle
        '    Chk_grdBal = False
        '    Exit Function
        'End If

        Chk_grdBal = True
    End Function

    Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean
        IsEmptyRow = True

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblDetail
                If Trim(.Columns(ITMAVECOST).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, ITMCODE)) = "" And Trim(waResult.get_Value(inRow, ITMAVECOST)) = "" Then
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

            If Chk_grdBal(waResult.get_Value(LastRow, ITMAVECOST)) = False Then
                .Col = ITMAVECOST
                .Row = LastRow
                Exit Function
            End If
        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function

    Private Function SaveData() As Boolean

        Dim wiRet As Integer

        SaveData = False

        If (wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec) And tbrProcess.Items.Item(tcSave).Enabled = True Then

            gsMsg = "你是否確定要儲存現時之作業?"
            If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
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

    '-- Set field status, Default, Add, Edit.
    Public Sub SetFieldStatus(ByVal sStatus As String)
        Select Case sStatus
            Case "Default"
                cboItmCodeFr.Enabled = True
                cboItmCodeTo.Enabled = True
                Me.tblDetail.Enabled = True

            Case "AfrActAdd"
                Me.tblDetail.Enabled = True

            Case "AfrActEdit"
                Me.tblDetail.Enabled = True

            Case "AfrKey"
                cboItmCodeFr.Enabled = True
                cboItmCodeTo.Enabled = True
                Me.tblDetail.Enabled = True
        End Select
    End Sub

    Private Sub LoadWSINFO()
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT * FROM sysWSINFO WHERE WSID ='" & gsWorkStationID & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            If gsLangID = "2" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                wgsTitle = ReadRs(rsRcd, "WSCTITLE")
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                wgsTitle = ReadRs(rsRcd, "WSTITLE")
            End If
        Else
            wgsTitle = ""
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Sub

    Private Function LoadRecord() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wsExcRate As String
        Dim wsExcDesc As String
        Dim wiCtr As Integer

        LoadRecord = False

        If CDbl(gsLangID) = 1 Then
            wsSQL = "SELECT WhsItemID, ItmCode, ItmEngName ITMDESC, WhsItemWhsCode, WhsItemAveCost "
            wsSQL = wsSQL & "FROM  MstItem, MstWhsItem "
            wsSQL = wsSQL & "WHERE WhsItemItmID = ItmID "
            wsSQL = wsSQL & "AND ItmCode >= '" & cboItmCodeFr.Text & "'"
            wsSQL = wsSQL & "AND ItmCode <= '" & cboItmCodeTo.Text & "'"
            wsSQL = wsSQL & "AND ItmID = WhsItemID "
            wsSQL = wsSQL & "AND WhsItemStatus = '1' "
            wsSQL = wsSQL & "ORDER BY ItmCode"
        Else
            wsSQL = "SELECT WhsItemID, ItmCode, ItmChiName ITMDESC, WhsItemWhsCode, WhsItemAveCost "
            wsSQL = wsSQL & "FROM  MstItem, MstWhsItem "
            wsSQL = wsSQL & "WHERE WhsItemItmID = ItmID "
            wsSQL = wsSQL & "AND ItmCode >= '" & cboItmCodeFr.Text & "'"
            wsSQL = wsSQL & "AND ItmCode <= '" & cboItmCodeTo.Text & "'"
            wsSQL = wsSQL & "AND ItmID = WhsItemID "
            wsSQL = wsSQL & "AND WhsItemStatus = '1' "
            wsSQL = wsSQL & "ORDER BY ItmCode"
        End If

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        rsRcd.MoveFirst()
        With waResult
            .ReDim(0, -1, ITMCODE, ITMID)
            Do While Not rsRcd.EOF
                wiCtr = wiCtr + 1
                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsRcd, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMDESC) = ReadRs(rsRcd, "ITMDESC")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMWHSCODE) = ReadRs(rsRcd, "WhsItemWhsCode")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMAVECOST) = ReadRs(rsRcd, "WhsItemAveCost")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsRcd, "WhsItemID")
                rsRcd.MoveNext()
            Loop
            'wlLineNo = waResult(.UpperBound(1), LINENO) + 1
        End With

        tblDetail.ReBind()
        tblDetail.FirstRow = 0

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        LoadRecord = True

    End Function

    Public Sub mnuPopUpSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopUpSub.Click
        Dim Index As Short = mnuPopUpSub.GetIndex(eventSender)
        'Call Call_PopUpMenu(waPopUpSub, Index)
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
    End Sub

    Private Function cmdRefresh() As Boolean
        cmdRefresh = False
        cmdRefresh = True
    End Function

    Private Sub cboItmCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCodeFr

        If gsLangID = "1" Then
            wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmEngName, ItmClass FROM MstItem WHERE ItmStatus = '1'"
            wsSQL = wsSQL & " AND ItmCode LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItmCode "
        Else
            wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmChiName, ItmClass FROM MstItem WHERE ItmStatus = '1'"
            wsSQL = wsSQL & " AND ItmCode LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItmCode "
        End If
        Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboItmCodeFr.Left)), VB6.PixelsToTwipsY(cboItmCodeFr.Top) + VB6.PixelsToTwipsY(cboItmCodeFr.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Enter
        FocusMe(cboItmCodeFr)
        wcCombo = cboItmCodeFr
    End Sub

    Private Sub cboItmCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmCodeFr, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboItmCodeFr.Text) <> "" And Trim(cboItmCodeTo.Text) = "" Then
                cboItmCodeTo.Text = cboItmCodeFr.Text
            End If

            cboItmCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Leave
        FocusMe(cboItmCodeFr, True)
    End Sub

    Private Sub cboItmCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCodeTo

        If gsLangID = "1" Then
            wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmEngName, ItmClass FROM MstItem WHERE ItmStatus = '1'"
            wsSQL = wsSQL & " AND ItmCode LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItmCode "
        Else
            wsSQL = "SELECT ItmCode, ItmItmTypeCode, ItmChiName, ItmClass FROM MstItem WHERE ItmStatus = '1'"
            wsSQL = wsSQL & " AND ItmCode LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
            wsSQL = wsSQL & "ORDER BY ItmCode "
        End If
        Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboItmCodeTo.Left)), VB6.PixelsToTwipsY(cboItmCodeTo.Top) + VB6.PixelsToTwipsY(cboItmCodeTo.Height), tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Enter
        FocusMe(cboItmCodeTo)
        wcCombo = cboItmCodeTo
    End Sub

    Private Sub cboItmCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmCodeTo, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmCodeTo = False Then
                cboItmCodeTo.Focus()
                GoTo EventExitSub
            End If

            Ini_Scr_AfrKey()

            If tblDetail.Enabled = True Then
                tblDetail.Focus()
            Else
                cboItmCodeFr.Focus()
            End If
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_cboItmCodeTo() As Boolean
        chk_cboItmCodeTo = False

        If UCase(cboItmCodeFr.Text) > UCase(cboItmCodeTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboItmCodeTo = True
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
            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
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
End Class