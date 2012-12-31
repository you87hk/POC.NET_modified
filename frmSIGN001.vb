Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmSIGN001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wiActFlg As Short
	Private wsTrnCd As String
	Private wiActRow As Short
	
	Private wiSort As Short
	Private wsSortBy As String
	
	Private Const tcSign As String = "Sign"
	Private Const tcCan As String = "Can"
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	Private Const SSEL As Short = 0
	Private Const SDOCDATE As Short = 1
	Private Const SDOCNO As Short = 2
	Private Const STRNCODE As Short = 3
	Private Const SJOBNO As Short = 4
	Private Const SCTLPRD As Short = 5
	Private Const SUPDUSR As Short = 6
	Private Const SUPDDATE As Short = 7
	Private Const SJOURNO As Short = 8
	Private Const SDUMMY As Short = 9
	Private Const SID As Short = 10
	
	
	
	Private Sub frmSIGN001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F10
				If tbrProcess.Items.Item(tcSign).Enabled = False Then Exit Sub
				Call cmdSave(1)
				
			Case System.Windows.Forms.Keys.F3
				If tbrProcess.Items.Item(tcCan).Enabled = False Then Exit Sub
				
				Call cmdSave(2)
				
				
				
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
			Case System.Windows.Forms.Keys.F5
				Call cmdSelect(1)
				
			Case System.Windows.Forms.Keys.F6
				Call cmdSelect(0)
				
			Case System.Windows.Forms.Keys.F7
				Call LoadRecord()
				
				
		End Select
	End Sub
	
	Private Sub frmSIGN001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Grid()
		Ini_Scr()
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	Private Sub cmdCancel()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, SSEL, SID)
		
		
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		For	Each MyControl In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			Select Case TypeName(MyControl)
				'         Case "ComboBox"
				'             MyControl.Clear
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
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		wiExit = False
		
		optDocType(0).Checked = True
		optInOut(0).Checked = True
		
		wiSort = 0
		wsSortBy = "ASC"
		
		Call SetPeriodMask(medPrdFr)
		Call SetPeriodMask(medPrdTo)
		
		
		medPrdFr.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))
		medPrdTo.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))
		
		Call LoadRecord()
		
		
	End Sub
	
	Private Sub frmSIGN001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmSIGN001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "SIGN001"
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		
		
		optInOut(0).Text = Get_Caption(waScrItm, "OPT0")
		optInOut(1).Text = Get_Caption(waScrItm, "OPT1")
		optInOut(2).Text = Get_Caption(waScrItm, "OPT2")
		optInOut(3).Text = Get_Caption(waScrItm, "OPT3")
		optInOut(4).Text = Get_Caption(waScrItm, "OPT4")
		optDocType(0).Text = Get_Caption(waScrItm, "STS1")
		optDocType(1).Text = Get_Caption(waScrItm, "STS2")
		
		
		
		
		With tblDetail
			.Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
			.Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
			.Columns(STRNCODE).Caption = Get_Caption(waScrItm, "STRNCODE")
			.Columns(SDOCDATE).Caption = Get_Caption(waScrItm, "SDOCDATE")
			.Columns(SJOBNO).Caption = Get_Caption(waScrItm, "SJOBNO")
			.Columns(SCTLPRD).Caption = Get_Caption(waScrItm, "SCTLPRD")
			.Columns(SUPDUSR).Caption = Get_Caption(waScrItm, "SUPDUSR")
			.Columns(SUPDDATE).Caption = Get_Caption(waScrItm, "SUPDDATE")
			.Columns(SJOURNO).Caption = Get_Caption(waScrItm, "SJOURNO")
			
			
		End With
		
		
		tbrProcess.Items.Item(tcSign).ToolTipText = Get_Caption(waScrToolTip, tcSign) & "(F10)"
		tbrProcess.Items.Item(tcCan).ToolTipText = Get_Caption(waScrToolTip, tcCan) & "(F3)"
		
		tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F7)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		tbrProcess.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrToolTip, tcSAll) & "(F5)"
		tbrProcess.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrToolTip, tcDAll) & "(F6)"
		
		
		
	End Sub
	
	
	
	
	
	'UPGRADE_WARNING: Event optDocType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optDocType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDocType.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optDocType.GetIndex(eventSender)
			Call LoadRecord()
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optInOut.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optInOut_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optInOut.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optInOut.GetIndex(eventSender)
			Call LoadRecord()
		End If
	End Sub
	
	Private Sub optInOut_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optInOut.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optInOut.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call LoadRecord()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        With tblDetail
            'UPGRADE_NOTE: UPDATE was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With
    End Sub




    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsBookID As String
        Dim wsBookCode As String
        Dim wsBarCode As String
        Dim wsBookName As String
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


        On Error GoTo tblDetail_ButtonClick_Err


        With tblDetail
            Select Case eventArgs.ColIndex
                Case SDOCNO
                    Call getTrnCd()
                    Select Case wsTrnCd
                        Case "IV"

                            frmAPR0012.InDocID = CInt(.Columns(SID).Text)
                            frmAPR0012.InCusNo = ""
                            frmAPR0012.TrnCd = wsTrnCd
                            frmAPR0012.FormID = "APR0051"
                            frmAPR0012.ShowDialog()

                        Case "SW"

                            frmAPR0011.InDocID = CInt(.Columns(SID).Text)
                            frmAPR0011.InCusNo = ""
                            frmAPR0011.TrnCd = wsTrnCd
                            frmAPR0011.FormID = "APR0061"
                            frmAPR0011.UpdFlg = False
                            frmAPR0011.ShowDialog()

                        Case "PV"
                            frmAPV0011.InDocID = CInt(.Columns(SID).Text)
                            frmAPV0011.InVdrNo = ""
                            frmAPV0011.TrnCd = .Columns(STRNCODE).Text
                            frmAPV0011.FormID = "APV0021"
                            frmAPV0011.UpdFlg = False
                            frmAPV0011.ShowDialog()

                        Case "PR"
                            frmAPV0011.InDocID = CInt(.Columns(SID).Text)
                            frmAPV0011.InVdrNo = ""
                            frmAPV0011.TrnCd = wsTrnCd
                            frmAPV0011.FormID = "APV0031"
                            frmAPV0011.UpdFlg = False
                            frmAPV0011.ShowDialog()

                        Case "IC"

                            frmAPS0011.InDocID = CInt(.Columns(SID).Text)
                            frmAPS0011.InCusNo = ""
                            frmAPS0011.FormID = "APS0011"
                            frmAPS0011.ShowDialog()

                    End Select


            End Select
        End With

        Exit Sub

tblDetail_ButtonClick_Err:
        MsgBox("Check tblDeiail ButtonClick!")

    End Sub

    Private Sub tblDetail_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_HeadClickEvent) Handles tblDetail.HeadClick


        On Error GoTo tblDetail_HeadClick_Err


        With tblDetail
            Select Case eventArgs.ColIndex
                Case SDOCNO
                    wiSort = 0
                    cmdRefresh()
                Case SDOCDATE
                    wiSort = 1
                    cmdRefresh()
                Case SJOBNO
                    wiSort = 2
                    cmdRefresh()
            End Select
        End With


        Exit Sub

tblDetail_HeadClick_Err:
        MsgBox("Check tblDeiail HeadClick!")

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

                Case System.Windows.Forms.Keys.Return
                    Select Case .Col
                        Case SJOURNO
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SSEL
                        Case Else
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> SSEL Then
                        .Col = .Col - 1
                    End If
                Case System.Windows.Forms.Keys.Right
                    Select Case .Col
                        Case SJOURNO
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SSEL
                        Case Else
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
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

            Case SJOURNO
                Call chk_InpLenC(tblDetail, 15, eventArgs.KeyAscii, True, True)



        End Select
    End Sub

    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail



            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col

                    Case STRNCODE
                        lblDspItmDesc.Text = ""
                        lblDspItmDesc.Text = Get_TableInfo("SYSCODEDESC", "SCDCODE = '" & Set_Quote(.Columns(STRNCODE).Text) & "' AND SCDLANGID = '" & gsLangID & "'", "SCDDESC")

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True



    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub

        Select Case Button.Name
            Case tcSign
                Call cmdSave(1)



            Case tcCan
                Call cmdSave(2)

            Case tcCancel

                Call cmdCancel()

            Case tcSAll
                Call cmdSelect(1)

            Case tcDAll
                Call cmdSelect(0)

            Case tcExit
                Me.Close()

            Case tcRefresh
                Call LoadRecord()

        End Select
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


    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = False
            .AllowUpdate = True
            .AllowDelete = False
            .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = SSEL To SID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = True
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case SSEL
                        .Columns(wiCtr).DataWidth = 1
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).Locked = False
                    Case SDOCNO
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).Button = True
                    Case STRNCODE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 10
                    Case SDOCDATE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 10
                    Case SJOBNO
                        .Columns(wiCtr).Width = 2500
                        .Columns(wiCtr).DataWidth = 20
                    Case SCTLPRD
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 6
                    Case SUPDUSR
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 20
                    Case SUPDDATE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 10
                    Case SJOURNO
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 15
                    Case SDUMMY
                        .Columns(wiCtr).Width = 100
                        .Columns(wiCtr).DataWidth = 0
                    Case SID
                        .Columns(wiCtr).Visible = False
                        .Columns(wiCtr).DataWidth = 15
                End Select

            Next
            .Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
        End With

    End Sub

    Private Function LoadRecord() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wiCtr As Integer
        Dim wsUpdFlg As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        LoadRecord = False

        Call Setup_tbrProcess()
        Call getTrnCd()

        If Opt_Getfocus(optDocType, 2, 0) = 0 Then
            wsUpdFlg = "N"
        Else
            wsUpdFlg = "Y"
        End If



        Select Case wsTrnCd
            Case "IV"

                wsSQL = "SELECT IVHDDOCID DOCID, IVHDDOCNO DOCNO, IVHDDOCDATE DOCDATE, IVHDTRNCODE TRNCODE, IVHDREFNO JOBNO, IVHDCTLPRD CTLPRD, IVHDUPDUSR UPDUSR, IVHDUPDDATE UPDDATE, IVHDJOURNO JOURNO "
                wsSQL = wsSQL & " FROM  SOAIVHD "
                wsSQL = wsSQL & " WHERE IVHDSTATUS = '" & IIf(wsUpdFlg = "N", "1", "4") & "' "
                wsSQL = wsSQL & " AND IVHDUPDFLG = '" & wsUpdFlg & "' "
                wsSQL = wsSQL & " AND IVHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"

                If wiSort = 0 Then
                    wsSQL = wsSQL & " ORDER BY IVHDDOCNO " & wsSortBy
                ElseIf wiSort = 1 Then
                    wsSQL = wsSQL & " ORDER BY IVHDDOCDATE " & wsSortBy
                ElseIf wiSort = 2 Then
                    wsSQL = wsSQL & " ORDER BY IVHDREFNO " & wsSortBy
                Else
                    wsSQL = wsSQL & " ORDER BY IVHDDOCNO, IVHDDOCDATE " & wsSortBy
                End If


            Case "SW"

                wsSQL = "SELECT SWHDDOCID DOCID, SWHDDOCNO DOCNO, SWHDDOCDATE DOCDATE, SWHDTRNCODE TRNCODE, SWHDREFNO JOBNO, SWHDCTLPRD CTLPRD, SWHDUPDUSR UPDUSR, SWHDUPDDATE UPDDATE, SWHDJOURNO JOURNO "
                wsSQL = wsSQL & " FROM SOASWHD "
                wsSQL = wsSQL & " WHERE SWHDSTATUS = '4' "
                wsSQL = wsSQL & " AND SWHDUPDFLG = '" & wsUpdFlg & "' "
                wsSQL = wsSQL & " AND SWHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"

                If wiSort = 0 Then
                    wsSQL = wsSQL & " ORDER BY SWHDDOCNO " & wsSortBy
                ElseIf wiSort = 1 Then
                    wsSQL = wsSQL & " ORDER BY SWHDDOCDATE " & wsSortBy
                ElseIf wiSort = 2 Then
                    wsSQL = wsSQL & " ORDER BY SWHDREFNO " & wsSortBy
                Else
                    wsSQL = wsSQL & " ORDER BY SWHDDOCNO, SWHDDOCDATE " & wsSortBy
                End If



            Case "PV"

                '    wsSQL = "SELECT PVHDDOCID DOCID, PVHDDOCNO DOCNO, PVHDDOCDATE DOCDATE, PVHDTRNCODE TRNCODE, POHDREFNO JOBNO, PVHDCTLPRD CTLPRD, PVHDUPDUSR UPDUSR, PVHDUPDDATE UPDDATE, PVHDCUSPO JOURNO "
                '    wsSQL = wsSQL & " FROM  POPPVHD, POPPOHD "
                '    wsSQL = wsSQL & " WHERE PVHDREFDOCID = POHDDOCID "
                '    wsSQL = wsSQL & " AND PVHDSTATUS = '4' "
                '    wsSQL = wsSQL & " AND PVHDUPDFLG = '" & wsUpdFlg & "' "
                '    If wiSort = 0 Then
                '    wsSQL = wsSQL & " ORDER BY PVHDDOCNO " & wsSortBy
                '    ElseIf wiSort = 1 Then
                '    wsSQL = wsSQL & " ORDER BY PVHDDOCDATE " & wsSortBy
                '    ElseIf wiSort = 2 Then
                '    wsSQL = wsSQL & " ORDER BY PVHDREFNO " & wsSortBy
                '    Else
                '    wsSQL = wsSQL & " ORDER BY PVHDDOCNO, PVHDDOCDATE " & wsSortBy
                '    End If


                If wsUpdFlg = "N" Then

                    wsSQL = "SELECT GRHDDOCID DOCID, GRHDDOCNO DOCNO, GRHDDOCDATE DOCDATE, GRHDTRNCODE TRNCODE, POHDREFNO JOBNO, GRHDCTLPRD CTLPRD, GRHDUPDUSR UPDUSR, GRHDUPDDATE UPDDATE, GRHDCUSPO JOURNO "
                    wsSQL = wsSQL & " FROM  POPGRHD, POPPOHD "
                    wsSQL = wsSQL & " WHERE GRHDREFDOCID = POHDDOCID "
                    wsSQL = wsSQL & " AND GRHDSTATUS = '4' "
                    wsSQL = wsSQL & " AND GRHDUPDFLG = '" & wsUpdFlg & "' "
                    wsSQL = wsSQL & " AND GRHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                    wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "' "

                    If wiSort = 0 Then
                        wsSQL = wsSQL & " ORDER BY GRHDDOCNO " & wsSortBy
                    ElseIf wiSort = 1 Then
                        wsSQL = wsSQL & " ORDER BY GRHDDOCDATE " & wsSortBy
                    ElseIf wiSort = 2 Then
                        wsSQL = wsSQL & " ORDER BY GRHDREFNO " & wsSortBy
                    Else
                        wsSQL = wsSQL & " ORDER BY GRHDDOCNO, GRHDDOCDATE " & wsSortBy
                    End If

                Else


                    wsSQL = "SELECT PVHDDOCID DOCID, PVHDDOCNO DOCNO, PVHDDOCDATE DOCDATE, PVHDTRNCODE TRNCODE, POHDREFNO JOBNO, PVHDCTLPRD CTLPRD, PVHDUPDUSR UPDUSR, PVHDUPDDATE UPDDATE, PVHDCUSPO JOURNO "
                    wsSQL = wsSQL & " FROM  POPPVHD, POPPOHD "
                    wsSQL = wsSQL & " WHERE PVHDREFDOCID = POHDDOCID "
                    wsSQL = wsSQL & " AND PVHDSTATUS = '4' "
                    wsSQL = wsSQL & " AND PVHDUPDFLG = '" & wsUpdFlg & "' "
                    wsSQL = wsSQL & " AND PVHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                    wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "' "

                    wsSQL = wsSQL & " UNION "
                    wsSQL = wsSQL & " SELECT GRHDDOCID DOCID, GRHDDOCNO DOCNO, GRHDDOCDATE DOCDATE, GRHDTRNCODE TRNCODE, POHDREFNO JOBNO, GRHDCTLPRD CTLPRD, GRHDUPDUSR UPDUSR, GRHDUPDDATE UPDDATE, GRHDCUSPO JOURNO "
                    wsSQL = wsSQL & " FROM  POPGRHD, POPPOHD "
                    wsSQL = wsSQL & " WHERE GRHDREFDOCID = POHDDOCID "
                    wsSQL = wsSQL & " AND GRHDSTATUS = '4' "
                    wsSQL = wsSQL & " AND GRHDUPDFLG = '" & wsUpdFlg & "' "
                    wsSQL = wsSQL & " AND GRHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                    wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"

                    ' If wiSort = 0 Then
                    ' wsSQL = wsSQL & " ORDER BY GRHDDOCNO " & wsSortBy
                    ' ElseIf wiSort = 1 Then
                    ' wsSQL = wsSQL & " ORDER BY GRHDDOCDATE " & wsSortBy
                    ' ElseIf wiSort = 2 Then
                    ' wsSQL = wsSQL & " ORDER BY GRHDREFNO " & wsSortBy
                    ' Else
                    ' wsSQL = wsSQL & " ORDER BY GRHDDOCNO, GRHDDOCDATE " & wsSortBy
                    ' End If

                    If wiSort = 0 Then
                        wsSQL = wsSQL & " ORDER BY DOCNO " & wsSortBy
                    ElseIf wiSort = 1 Then
                        wsSQL = wsSQL & " ORDER BY DOCDATE " & wsSortBy
                    ElseIf wiSort = 2 Then
                        wsSQL = wsSQL & " ORDER BY JOBNO " & wsSortBy
                    Else
                        wsSQL = wsSQL & " ORDER BY DOCNO, DOCDATE " & wsSortBy
                    End If

                End If

            Case "PR"

                wsSQL = "SELECT PRHDDOCID DOCID, PRHDDOCNO DOCNO, PRHDDOCDATE DOCDATE, PRHDTRNCODE TRNCODE, POHDREFNO JOBNO, PRHDCTLPRD CTLPRD, PRHDUPDUSR UPDUSR, PRHDUPDDATE UPDDATE, PRHDCUSPO JOURNO "
                wsSQL = wsSQL & " FROM  POPPRHD, POPPOHD "
                wsSQL = wsSQL & " WHERE PRHDREFDOCID = POHDDOCID "
                wsSQL = wsSQL & " AND PRHDSTATUS = '4' "
                wsSQL = wsSQL & " AND PRHDUPDFLG = '" & wsUpdFlg & "' "
                wsSQL = wsSQL & " AND PRHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"

                If wiSort = 0 Then
                    wsSQL = wsSQL & " ORDER BY PRHDDOCNO " & wsSortBy
                ElseIf wiSort = 1 Then
                    wsSQL = wsSQL & " ORDER BY PRHDDOCDATE " & wsSortBy
                ElseIf wiSort = 2 Then
                    wsSQL = wsSQL & " ORDER BY PRHDREFNO " & wsSortBy
                Else
                    wsSQL = wsSQL & " ORDER BY PRHDDOCNO, PRHDDOCDATE " & wsSortBy
                End If

            Case "IC"

                wsSQL = "SELECT SJHDDOCID DOCID, SJHDDOCNO DOCNO, SJHDDOCDATE DOCDATE,  SJHDTRNCODE TRNCODE, '' JOBNO, SJHDCTLPRD CTLPRD, SJHDUPDUSR UPDUSR, SJHDUPDDATE UPDDATE, SJHDJOURNO JOURNO "
                wsSQL = wsSQL & " FROM  ICSTKADJ"
                wsSQL = wsSQL & " WHERE SJHDSTATUS = '4' "
                wsSQL = wsSQL & " AND SJHDUPDFLG = '" & wsUpdFlg & "' "
                wsSQL = wsSQL & " AND SJHDTRNCODE <> 'TR' "
                wsSQL = wsSQL & " AND SJHDTRNCODE <> 'SK' "
                wsSQL = wsSQL & " AND SJHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
                wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"

                If wiSort = 0 Then
                    wsSQL = wsSQL & " ORDER BY SJHDDOCNO " & wsSortBy
                ElseIf wiSort = 1 Then
                    wsSQL = wsSQL & " ORDER BY SJHDDOCDATE " & wsSortBy
                ElseIf wiSort = 2 Then
                    wsSQL = wsSQL & " ORDER BY SJHDDOCNO, SJHDDOCDATE " & wsSortBy
                End If



        End Select


        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            waResult.ReDim(0, -1, SSEL, SID)
            tblDetail.ReBind()
            tblDetail.Bookmark = 0
            'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
            'UPGRADE_ISSUE: Form property frmSIGN001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If


        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF

                '   wdCreLft = Get_CreditLimit(ReadRs(rsRcd, "IVHDCUSID"), gsSystemDate)


                .AppendRows()
                waResult.get_Value(.get_UpperBound(1), SSEL) = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "DOCNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), STRNCODE) = ReadRs(rsRcd, "TRNCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SJOBNO) = ReadRs(rsRcd, "JOBNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCDATE) = ReadRs(rsRcd, "DOCDATE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SCTLPRD) = ReadRs(rsRcd, "CTLPRD")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SUPDUSR) = ReadRs(rsRcd, "UPDUSR")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SUPDDATE) = ReadRs(rsRcd, "UPDDATE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SJOURNO) = ReadRs(rsRcd, "JOURNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "DOCID")
                rsRcd.MoveNext()
            Loop
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


        LoadRecord = True
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmSIGN001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Function


    Private Function Chk_GrdRow(ByVal LastRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsDes As String
        Dim wsExcRat As String
        Dim wsAccType As String

        Chk_GrdRow = False

        On Error GoTo Chk_GrdRow_Err

        With tblDetail

            If To_Value(LastRow) > waResult.get_UpperBound(1) Then
                Chk_GrdRow = True
                Exit Function
            End If

            Select Case wsTrnCd
                Case "IV"
                    wsAccType = "AR"
                Case "SW", "IC"
                    wsAccType = "GL"
                Case "PV", "PR"
                    wsAccType = "AP"
            End Select

            If Chk_ValidDocDate(waResult.get_Value(LastRow, SDOCDATE), wsAccType) = False Then
                .Col = SDOCDATE
                Exit Function
            End If

            If Opt_Getfocus(optInOut, 5, 0) = 2 Or Opt_Getfocus(optInOut, 5, 0) = 3 Then
                If Chk_JourNo(waResult.get_Value(LastRow, SJOURNO), waResult.get_Value(LastRow, STRNCODE)) = False Then
                    .Col = SJOURNO
                    Exit Function
                End If
            End If



        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function




    Private Sub cmdSave(ByVal inActFlg As Short)

        Dim wsGenDte As String
        Dim wsDteTim As String

        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wiRetKey As Short
        Dim i As Short

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate
        wsDteTim = Change_SQLDate(CStr(Now))

        wiActFlg = inActFlg

        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        '' Last Check when Add

        Select Case wiActFlg
            Case 1
                gsMsg = "你是否確認此文件?"
            Case 2
                gsMsg = "你是否取消此文件?"
        End Select

        If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        Call getTrnCd()

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon


        If wsTrnCd = "SW" Then
            i = 1
            If waResult.get_UpperBound(1) >= 0 Then
                adcmdSave.CommandText = "USP_SOP000A_SW"
                adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
                adcmdSave.Parameters.Refresh()

                For wiCtr = 0 To waResult.get_UpperBound(1)
                    If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
                        Call SetSPPara(adcmdSave, 1, wiActFlg)
                        Call SetSPPara(adcmdSave, 2, waResult.get_Value(wiCtr, SID))
                        Call SetSPPara(adcmdSave, 3, gsUserID)
                        Call SetSPPara(adcmdSave, 4, wsGenDte)
                        Call SetSPPara(adcmdSave, 5, wsDteTim)
                        Call SetSPPara(adcmdSave, 6, IIf(i = wiActRow, "Y", "N"))
                        adcmdSave.Execute()
                        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        wiRetKey = GetSPPara(adcmdSave, 7)
                        i = i + 1

                        If wiRetKey = -1 Then
                            gsMsg = waResult.get_Value(wiCtr, SDOCNO) & ": 平均成本不能小於零!"
                            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        End If

                    End If
                Next
            End If


        Else

            If waResult.get_UpperBound(1) >= 0 Then
                adcmdSave.CommandText = "USP_SOP000A"
                adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
                adcmdSave.Parameters.Refresh()

                For wiCtr = 0 To waResult.get_UpperBound(1)
                    If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
                        Call SetSPPara(adcmdSave, 1, wiActFlg)
                        Call SetSPPara(adcmdSave, 2, IIf(wsTrnCd = "PV", wsTrnCd, waResult.get_Value(wiCtr, STRNCODE)))
                        Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, SID))
                        Call SetSPPara(adcmdSave, 4, Trim(waResult.get_Value(wiCtr, SJOURNO)))
                        Call SetSPPara(adcmdSave, 5, gsUserID)
                        Call SetSPPara(adcmdSave, 6, wsGenDte)
                        Call SetSPPara(adcmdSave, 7, wsDteTim)
                        Call SetSPPara(adcmdSave, 8, gsLangID)
                        adcmdSave.Execute()
                        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        wiRetKey = GetSPPara(adcmdSave, 9)

                        If wiRetKey = -1 Then
                            gsMsg = waResult.get_Value(wiCtr, SDOCNO) & ": 平均成本不能小於零!"
                            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        End If


                    End If
                Next
            End If

        End If

        cnCon.CommitTrans()

        gsMsg = "已完成!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)


        'Call UnLockAll(wsConnTime, wsFormID)
        Call LoadRecord()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing


        Cursor = System.Windows.Forms.Cursors.Default

        Exit Sub

cmdSave_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

    End Sub

    Private Function InputValidation() As Boolean
        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        InputValidation = False

        On Error GoTo InputValidation_Err
        wiActRow = 0
        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If
                    wiActRow = wiActRow + 1

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

    Private Sub cmdSelect(ByVal wiSelect As Short)
        Dim wiCtr As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor



        With waResult
            For wiCtr = 0 To .get_UpperBound(1)
                waResult.get_Value(wiCtr, SSEL) = IIf(wiSelect = 1, "-1", "0")
            Next wiCtr
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmSIGN001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub


    Private Sub getTrnCd()

        Select Case Opt_Getfocus(optInOut, 5, 0)

            Case 0
                wsTrnCd = "IV"
            Case 1
                wsTrnCd = "SW"
            Case 2
                wsTrnCd = "PV"
            Case 3
                wsTrnCd = "PR"
            Case 4
                wsTrnCd = "IC"

        End Select


    End Sub

    Private Sub Setup_tbrProcess()

        With tbrProcess


            If Opt_Getfocus(optDocType, 2, 0) = 0 Then
                .Items.Item(tcCan).Enabled = False
                .Items.Item(tcSign).Enabled = True
            Else
                .Items.Item(tcCan).Enabled = True
                .Items.Item(tcSign).Enabled = False
            End If



            .Items.Item(tcRefresh).Enabled = True
            .Items.Item(tcCancel).Enabled = True
            .Items.Item(tcSAll).Enabled = True
            .Items.Item(tcDAll).Enabled = True
            .Items.Item(tcExit).Enabled = True



        End With


        With tblDetail

            Select Case Opt_Getfocus(optInOut, 5, 0)
                Case 1, 4
                    .Columns(SJOURNO).Locked = False
                Case Else
                    .Columns(SJOURNO).Locked = True
            End Select


        End With

    End Sub


    Private Sub cmdRefresh()


        If wsSortBy = "ASC" Then
            wsSortBy = "DESC"
        Else
            wsSortBy = "ASC"
        End If
        LoadRecord()

    End Sub


    Private Function Chk_JourNo(ByVal inJourNo As String, ByVal inTrnCode As String) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_JourNo = False

        If Trim(inJourNo) = "" Then
            Chk_JourNo = True
            Exit Function
        End If


        wsSQL = "SELECT * FROM APIPHD "
        wsSQL = wsSQL & " WHERE IPHDDOCNO = '" & Set_Quote(inJourNo) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Chk_JourNo = True
            Exit Function
        End If


        gsMsg = "AP Invoice has been used!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


    End Function
    Private Sub medPrdFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Enter
        FocusMe(medPrdFr)
    End Sub


    Private Sub medPrdFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_medPrdFr = False Then
                GoTo EventExitSub
            End If

            If Trim(medPrdFr.Text) <> "/" And Trim(medPrdTo.Text) = "/" Then
                medPrdTo.Text = medPrdFr.Text
            End If
            medPrdTo.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
        FocusMe(medPrdFr, True)
    End Sub

    Private Sub medPrdTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If chk_medPrdTo = False Then
                GoTo EventExitSub
            End If

            If LoadRecord = True Then
                tblDetail.Focus()
            End If

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub medPrdTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo.Enter
		FocusMe(medPrdTo)
	End Sub
	Private Sub medPrdTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdTo.Leave
		FocusMe(medPrdTo, True)
	End Sub
	
	Private Function chk_medPrdFr() As Boolean
		chk_medPrdFr = False
		
		If Trim(medPrdFr.Text) = "/" Then
			chk_medPrdFr = True
			Exit Function
		End If
		
		If Chk_Period(medPrdFr) = False Then
			gsMsg = "Wrong Period!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr.Focus()
			Exit Function
			
		End If
		
		chk_medPrdFr = True
	End Function
	Private Function chk_medPrdTo() As Boolean
		chk_medPrdTo = False
		
		If UCase(medPrdFr.Text) > UCase(medPrdTo.Text) Then
			gsMsg = "To must > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo.Focus()
			Exit Function
		End If
		
		If Trim(medPrdTo.Text) = "/" Then
			chk_medPrdTo = True
			Exit Function
		End If
		
		If Chk_Period(medPrdTo) = False Then
			gsMsg = "Wrong Period!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdTo.Focus()
			Exit Function
			
		End If
		
		chk_medPrdTo = True
	End Function
End Class