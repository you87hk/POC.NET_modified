Option Strict Off
Option Explicit On
Friend Class frmQTN002
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	
	Private waPopUpSub As New XArrayDBObject.XArrayDB
	
	Dim waInvDoc As New XArrayDBObject.XArrayDB
	Dim wlHLineNo As Integer
	Dim wlLineNo As Integer
	Dim wsHCurr As String
	Dim wdHExcr As Double
	
	
	
	Private wbErr As Boolean
	
	Private wiExit As Boolean
	
	Private wsFormCaption As String
	Private wsFormID As String
	
	Private Const tcGo As String = "Go"
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcBOM As String = "BOM"
	
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
	Private Const SVDRID As Short = 14
	Private Const SITMID As Short = 15
	
	
	
	
	Public Property InvDoc() As XArrayDBObject.XArrayDB
		Get
			InvDoc = waInvDoc
		End Get
		Set(ByVal Value As XArrayDBObject.XArrayDB)
			waInvDoc = Value
		End Set
	End Property
	
	Public WriteOnly Property inLineNo() As Integer
		Set(ByVal Value As Integer)
			wlHLineNo = Value
		End Set
	End Property
	
	Public WriteOnly Property InCurr() As String
		Set(ByVal Value As String)
			wsHCurr = Value
		End Set
	End Property
	
	Public WriteOnly Property InExcr() As Double
		Set(ByVal Value As Double)
			wdHExcr = Value
		End Set
	End Property
	
	Private Sub frmQTN002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F2
				Call cmdOK()
				
			Case System.Windows.Forms.Keys.F3
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Hide()
				
			Case System.Windows.Forms.Keys.F5
				Call LoadRecord()
				
			Case System.Windows.Forms.Keys.F9
				Call cmdBOM()
				
				' Case vbKeyEscape
				'     Unload Me
		End Select
	End Sub
	
	Private Sub frmQTN002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
	
	Private Sub cmdOK()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.Close()
		Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	Private Sub Ini_Scr()
		
		Dim MyControl As System.Windows.Forms.Control
		
		waResult.ReDim(0, -1, SLINENO, SITMID)
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
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		wiExit = False
		
		
		Call LoadRecord()
		
	End Sub
	
	Private Sub frmQTN002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If wiExit = False Then
			If waResult.get_UpperBound(1) >= 0 Then
				With tblDetail
					'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()
                    If Chk_GrdRow(.FirstRow + .Row) = False Then
                        .Focus()
                        Exit Sub
                    End If
                End With
            End If

            'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Call UpdateRecord()
            wiExit = True
            Me.Hide()
            Exit Sub
        End If

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object waInvDoc may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waInvDoc = Nothing
        'UPGRADE_NOTE: Object waPopUpSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPopUpSub = Nothing

    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "QTN002"
    End Sub

    Private Sub Ini_Caption()
        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP_A", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        With tblDetail
            .Columns(SLINENO).Caption = Get_Caption(waScrItm, "SLINENO")
            .Columns(SINDENT).Caption = Get_Caption(waScrItm, "SINDENT")
            .Columns(SITMTYPE).Caption = Get_Caption(waScrItm, "SITMTYPE")
            .Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SITMCODE")
            .Columns(SVDRCODE).Caption = Get_Caption(waScrItm, "SVDRCODE")
            .Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SITMNAME")
            .Columns(SUNITPRICE).Caption = Get_Caption(waScrItm, "SUNITPRICE")
            .Columns(SUCST).Caption = Get_Caption(waScrItm, "SUCST")
            .Columns(SDISPER).Caption = Get_Caption(waScrItm, "SDISPER")
            .Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
            .Columns(SAMT).Caption = Get_Caption(waScrItm, "SAMT")
            .Columns(SNET).Caption = Get_Caption(waScrItm, "SNET")
            .Columns(SCST).Caption = Get_Caption(waScrItm, "SCST")

        End With

        Call Ini_PopMenu(mnuPopUpSub, "POPUP", waPopUpSub)

        tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F2)"
        tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F5)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F3)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
        tbrProcess.Items.Item(tcBOM).ToolTipText = Get_Caption(waScrToolTip, tcBOM) & "(F9)"



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
                    'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Update()
                    If .Row = -1 Then
                        .Row = 0
                    End If
                    'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    .Refresh()
                    .Focus()


                Case "INSERT"

                    If .Bookmark = waResult.get_UpperBound(2) Then Exit Sub
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

    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        If eventArgs.Button = 2 Then
            'UPGRADE_ISSUE: Form method frmQTN002.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'PopupMenu(mnuPopUp)
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case tcGo
                Call cmdOK()

            Case tcCancel

                Call cmdCancel()

            Case tcBOM
                Call cmdBOM()

            Case tcExit
                Me.Hide()

            Case tcRefresh
                Call LoadRecord()

        End Select
    End Sub



    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        'If wcCombo.Name = tblDetail.Name Then
        '    tblDetail.EditActive = True
        '    'UPGRADE_WARNING: Couldn't resolve default property of object wcCombo.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    Select Case wcCombo.Col
        '        Case SITMTYPE
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
            '        Case SITMTYPE
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

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub


    Private Function LoadRecord() As Boolean
        Dim wiRow As Integer

        LoadRecord = False

        wlLineNo = 1

        If waInvDoc.get_UpperBound(1) >= 0 Then
            With waResult
                .ReDim(0, -1, SLINENO, SITMID)

                For wiRow = 0 To waInvDoc.get_UpperBound(1)

                    If waInvDoc.get_Value(wiRow, SLN_Renamed) = wlHLineNo Then
                        .AppendRows()
                        waResult.get_Value(.get_UpperBound(1), SLINENO) = waInvDoc.get_Value(wiRow, SLINENO)
                        waResult.get_Value(.get_UpperBound(1), SLN_Renamed) = wlHLineNo
                        waResult.get_Value(.get_UpperBound(1), SINDENT) = waInvDoc.get_Value(wiRow, SINDENT)
                        waResult.get_Value(.get_UpperBound(1), SITMTYPE) = waInvDoc.get_Value(wiRow, SITMTYPE)
                        waResult.get_Value(.get_UpperBound(1), SITMCODE) = waInvDoc.get_Value(wiRow, SITMCODE)
                        waResult.get_Value(.get_UpperBound(1), SVDRCODE) = waInvDoc.get_Value(wiRow, SVDRCODE)
                        waResult.get_Value(.get_UpperBound(1), SITMNAME) = waInvDoc.get_Value(wiRow, SITMNAME)
                        waResult.get_Value(.get_UpperBound(1), SUNITPRICE) = VB6.Format(waInvDoc.get_Value(wiRow, SUNITPRICE), gsAmtFmt)
                        waResult.get_Value(.get_UpperBound(1), SUCST) = VB6.Format(waInvDoc.get_Value(wiRow, SUCST), gsAmtFmt)

                        waResult.get_Value(.get_UpperBound(1), SDISPER) = VB6.Format(waInvDoc.get_Value(wiRow, SDISPER), gsAmtFmt)
                        waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(waInvDoc.get_Value(wiRow, SQTY), gsQtyFmt)
                        waResult.get_Value(.get_UpperBound(1), SAMT) = VB6.Format(waInvDoc.get_Value(wiRow, SAMT), gsAmtFmt)
                        waResult.get_Value(.get_UpperBound(1), SNET) = VB6.Format(waInvDoc.get_Value(wiRow, SNET), gsAmtFmt)
                        waResult.get_Value(.get_UpperBound(1), SCST) = VB6.Format(waInvDoc.get_Value(wiRow, SCST), gsAmtFmt)

                        waResult.get_Value(.get_UpperBound(1), SITMID) = To_Value(waInvDoc.get_Value(wiRow, SITMID))
                        waResult.get_Value(.get_UpperBound(1), SVDRID) = To_Value(waInvDoc.get_Value(wiRow, SVDRID))
                        wlLineNo = wlLineNo + 1
                    End If



                Next wiRow
            End With

            tblDetail.ReBind()
            'tblDetail.FirstRow = 0
            tblDetail.Bookmark = 0

        End If



        LoadRecord = True

    End Function

    Private Function UpdateRecord() As Boolean
        Dim wiCtr As Integer

        UpdateRecord = False

        With waInvDoc

            If waInvDoc.get_UpperBound(1) >= 0 Then
                '  .ReDim 0, waInvDoc.UpperBound(1), STYPE, SSTATUS
                For wiCtr = 0 To waInvDoc.get_UpperBound(1)
                    If waInvDoc.get_Value(wiCtr, SLN_Renamed) = wlHLineNo Then
                        waInvDoc.get_Value(wiCtr, SLN_Renamed) = "0"
                    End If
                Next wiCtr
            End If

            If waResult.get_UpperBound(1) >= 0 Then

                For wiCtr = 0 To waResult.get_UpperBound(1)
                    If Trim(waResult.get_Value(wiCtr, SLINENO)) <> "" Then
                        .AppendRows()
                        waInvDoc.get_Value(.get_UpperBound(1), SLINENO) = waResult.get_Value(wiCtr, SLINENO)
                        waInvDoc.get_Value(.get_UpperBound(1), SINDENT) = waResult.get_Value(wiCtr, SINDENT)
                        waInvDoc.get_Value(.get_UpperBound(1), SITMTYPE) = waResult.get_Value(wiCtr, SITMTYPE)
                        waInvDoc.get_Value(.get_UpperBound(1), SITMCODE) = waResult.get_Value(wiCtr, SITMCODE)
                        waInvDoc.get_Value(.get_UpperBound(1), SVDRCODE) = waResult.get_Value(wiCtr, SVDRCODE)
                        waInvDoc.get_Value(.get_UpperBound(1), SITMNAME) = waResult.get_Value(wiCtr, SITMNAME)
                        waInvDoc.get_Value(.get_UpperBound(1), SUNITPRICE) = VB6.Format(waResult.get_Value(wiCtr, SUNITPRICE), gsAmtFmt)
                        waInvDoc.get_Value(.get_UpperBound(1), SUCST) = VB6.Format(waResult.get_Value(wiCtr, SUCST), gsAmtFmt)

                        waInvDoc.get_Value(.get_UpperBound(1), SDISPER) = VB6.Format(waResult.get_Value(wiCtr, SDISPER), gsAmtFmt)

                        waInvDoc.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(waResult.get_Value(wiCtr, SQTY), gsQtyFmt)
                        waInvDoc.get_Value(.get_UpperBound(1), SAMT) = VB6.Format(waResult.get_Value(wiCtr, SAMT), gsAmtFmt)
                        waInvDoc.get_Value(.get_UpperBound(1), SNET) = VB6.Format(waResult.get_Value(wiCtr, SNET), gsAmtFmt)
                        waInvDoc.get_Value(.get_UpperBound(1), SCST) = VB6.Format(waResult.get_Value(wiCtr, SCST), gsAmtFmt)

                        waInvDoc.get_Value(.get_UpperBound(1), SLN_Renamed) = wlHLineNo
                        waInvDoc.get_Value(.get_UpperBound(1), SITMID) = To_Value(waResult.get_Value(wiCtr, SITMID))
                        waInvDoc.get_Value(.get_UpperBound(1), SVDRID) = To_Value(waResult.get_Value(wiCtr, SVDRID))
                    End If
                Next wiCtr
            End If

        End With

        UpdateRecord = True

    End Function


    Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean

        IsEmptyRow = True

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblDetail
                If Trim(.Columns(SITMTYPE).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, SLINENO)) = "" And Trim(waResult.get_Value(inRow, SITMTYPE)) = "" And Trim(waResult.get_Value(inRow, SITMCODE)) = "" And Trim(waResult.get_Value(inRow, SVDRCODE)) = "" And Trim(waResult.get_Value(inRow, SITMNAME)) = "" And Trim(waResult.get_Value(inRow, SQTY)) = "" And Trim(waResult.get_Value(inRow, SUNITPRICE)) = "" And Trim(waResult.get_Value(inRow, SUCST)) = "" And Trim(waResult.get_Value(inRow, SNET)) = "" And Trim(waResult.get_Value(inRow, SCST)) = "" And Trim(waResult.get_Value(inRow, SDISPER)) = "" And Trim(waResult.get_Value(inRow, SAMT)) = "" And Trim(waResult.get_Value(inRow, SITMID)) = "" And Trim(waResult.get_Value(inRow, SVDRID)) = "" Then
                    Exit Function
                End If
            End If
        End If

        IsEmptyRow = False

    End Function

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        Dim sTemp As String

        With tblDetail
            sTemp = .Columns(eventArgs.ColIndex).Text
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With


        '   If ColIndex = ItmCode Then
        '       Call LoadBookGroup(sTemp)
        '   End If
    End Sub

    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim wsITMID As String
        Dim wsITMCODE As String
        Dim wsVdrID As String
        Dim wsVdrCODE As String
        Dim wsITMTYPE As String
        Dim wsITMNAME As String
        Dim wsBookDefaultPrice As String
        Dim wsPub As String
        Dim wdPrice As Double
        Dim wdDisPer As Double
        Dim wsBookCurr As String

        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex

                Case SITMTYPE
                    If Chk_grdItmType((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If


                    If Trim(.Columns(SITMCODE).Text) <> "" Then

                        If Chk_grdITMCODE(.Columns(SITMCODE).Text, .Columns(SITMTYPE).Text, wsITMID, wsITMCODE, wsITMNAME, wsVdrID, wsVdrCODE) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If
                        .Columns(SLINENO).Text = CStr(wlLineNo)
                        .Columns(SITMID).Text = wsITMID
                        .Columns(SVDRID).Text = wsVdrID
                        .Columns(SITMNAME).Text = wsITMNAME
                        .Columns(SVDRCODE).Text = wsVdrCODE
                        .Columns(SQTY).Text = "0"
                        .Columns(SUNITPRICE).Text = CStr(get_ItemSalePrice((.Columns(SITMID).Text), (.Columns(SVDRID).Text), wsHCurr, wdHExcr))
                        .Columns(SUCST).Text = CStr(get_ItemVdrCost((.Columns(SITMID).Text), (.Columns(SVDRID).Text), wsHCurr, wdHExcr))

                        .Columns(SLN_Renamed).Text = CStr(wlHLineNo)
                        .Columns(SDISPER).Text = VB6.Format("0", gsAmtFmt)

                        wlLineNo = wlLineNo + 1

                        If Trim(.Columns(SITMCODE).Text) <> wsITMCODE Then
                            .Columns(SITMCODE).Text = wsITMCODE
                        End If

                    End If


                Case SITMCODE
                    ' If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                    '    GoTo Tbl_BeforeColUpdate_Err
                    'End If

                    If Chk_grdITMCODE(.Columns(SITMCODE).Text, .Columns(SITMTYPE).Text, wsITMID, wsITMCODE, wsITMNAME, wsVdrID, wsVdrCODE) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If
                    .Columns(SLINENO).Text = CStr(wlLineNo)
                    .Columns(SITMID).Text = wsITMID
                    .Columns(SVDRID).Text = wsVdrID
                    .Columns(SITMNAME).Text = wsITMNAME
                    .Columns(SVDRCODE).Text = wsVdrCODE
                    .Columns(SQTY).Text = "0"
                    .Columns(SUNITPRICE).Text = CStr(get_ItemSalePrice((.Columns(SITMID).Text), (.Columns(SVDRID).Text), wsHCurr, wdHExcr))
                    .Columns(SUCST).Text = CStr(get_ItemVdrCost((.Columns(SITMID).Text), (.Columns(SVDRID).Text), wsHCurr, wdHExcr))

                    .Columns(SDISPER).Text = VB6.Format("0", gsAmtFmt)

                    wlLineNo = wlLineNo + 1

                    If Trim(.Columns(SITMCODE).Text) <> wsITMCODE Then
                        .Columns(SITMCODE).Text = wsITMCODE
                    End If

                Case SVDRCODE

                    If Chk_grdVdrCode(.Columns(eventArgs.ColIndex).Text, wsVdrID) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(SVDRID).Text = wsVdrID
                    .Columns(SUNITPRICE).Text = CStr(get_ItemSalePrice((.Columns(SITMID).Text), (.Columns(SVDRID).Text), wsHCurr, wdHExcr))
                    .Columns(SUCST).Text = CStr(get_ItemVdrCost((.Columns(SITMID).Text), (.Columns(SVDRID).Text), wsHCurr, wdHExcr))


                Case SUNITPRICE, SQTY, SDISPER

                    If eventArgs.ColIndex = SUNITPRICE Then

                        If Chk_grdUNITPRICE((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    End If

                    If eventArgs.ColIndex = SQTY Then

                        If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    End If

                    If eventArgs.ColIndex = SDISPER Then

                        If Chk_grdDisPer((.Columns(eventArgs.ColIndex).Text)) = False Then
                            GoTo Tbl_BeforeColUpdate_Err
                        End If

                    End If

                    If Trim(.Columns(SUNITPRICE).Text) <> "" And Trim(.Columns(SQTY).Text) <> "" And Trim(.Columns(SDISPER).Text) <> "" Then
                        .Columns(SAMT).Text = VB6.Format(To_Value(.Columns(SUNITPRICE)) * To_Value(.Columns(SQTY)), gsAmtFmt)
                    End If

                    If Trim(.Columns(SUNITPRICE).Text) <> "" And Trim(.Columns(SQTY).Text) <> "" And Trim(.Columns(SDISPER).Text) <> "" Then
                        .Columns(SNET).Text = VB6.Format(To_Value(.Columns(SUNITPRICE)) * To_Value(.Columns(SQTY)) * (1 - To_Value(.Columns(SDISPER))), gsAmtFmt)
                    End If

                    If Trim(.Columns(SUCST).Text) <> "" And Trim(.Columns(SQTY).Text) <> "" Then
                        .Columns(SCST).Text = VB6.Format(To_Value(.Columns(SUCST)) * To_Value(.Columns(SQTY)), gsAmtFmt)
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
        Dim wsSql As String
        Dim wiTop As Integer
        Dim wiCtr As Short

        On Error GoTo tblDetail_ButtonClick_Err
        With tblDetail
            Select Case eventArgs.ColIndex
                Case SITMCODE

                    If CDbl(gsLangID) = 1 Then
                        wsSql = "SELECT ITMCODE, ITMITMTYPECODE, ITMENGNAME ITNAME, STR(ITMDEFAULTPRICE,13,2) FROM mstITEM "
                        wsSql = wsSql & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(.Columns(SITMCODE).Text) & "%' "
                        wsSql = wsSql & " AND ITMITMTYPECODE =  '" & Set_Quote(.Columns(SITMTYPE).Text) & "' "

                        ' If waResult.UpperBound(1) > -1 Then
                        '     wsSql = wsSql & " AND ITMCODE NOT IN ( "
                        '     For wiCtr = 0 To waResult.UpperBound(1)
                        '         wsSql = wsSql & " '" & waResult(wiCtr, SITMCODE) & IIf(wiCtr = waResult.UpperBound(1), "' )", "' ,")
                        '     Next
                        ' End If

                        wsSql = wsSql & " ORDER BY ITMCODE "
                    Else
                        wsSql = "SELECT ITMCODE, ITMITMTYPECODE, ITMCHINAME ITNAME, STR(ITMDEFAULTPRICE,13,2) FROM mstITEM "
                        wsSql = wsSql & " WHERE ITMSTATUS <> '2' AND ITMCODE LIKE '%" & Set_Quote(.Columns(SITMCODE).Text) & "%' "
                        wsSql = wsSql & " AND ITMITMTYPECODE =  '" & Set_Quote(.Columns(SITMTYPE).Text) & "' "

                        '  If waResult.UpperBound(1) > -1 Then
                        '      wsSql = wsSql & " AND ITMCODE NOT IN ( "
                        '      For wiCtr = 0 To waResult.UpperBound(1)
                        '          wsSql = wsSql & " '" & waResult(wiCtr, SITMCODE) & IIf(wiCtr = waResult.UpperBound(1), "' )", "' ,")
                        '      Next
                        '  End If

                        wsSql = wsSql & " ORDER BY ITMCODE "
                    End If

                    Call Ini_Combo(4, wsSql, .Columns(eventArgs.ColIndex).Left + VB6.FromPixelsUserX(.Left, 0, 11923.8, 794) + .Columns(eventArgs.ColIndex).Top, VB6.FromPixelsUserY(.Top, 0, 7406.11, 494) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLITMCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case SITMTYPE


                    If gsLangID = "2" Then

                        wsSql = "SELECT ITMTYPECODE, ITMTYPECHIDESC "
                        wsSql = wsSql & " FROM MSTITEMTYPE "
                        wsSql = wsSql & " WHERE ITMTYPECODE LIKE '%" & Set_Quote(.Columns(SITMTYPE).Text) & "%' "
                        wsSql = wsSql & " AND ITMTYPESTATUS  <> '2' "
                        wsSql = wsSql & " ORDER BY ITMTYPECODE "

                    Else

                        wsSql = "SELECT ITMTYPECODE, ITMTYPEENGDESC "
                        wsSql = wsSql & " FROM MSTITEMTYPE "
                        wsSql = wsSql & " WHERE ITMTYPECODE LIKE '%" & Set_Quote(.Columns(SITMTYPE).Text) & "%' "
                        wsSql = wsSql & " AND ITMTYPESTATUS  <> '2' "
                        wsSql = wsSql & " ORDER BY ITMTYPECODE "

                    End If


                    '    wsSql = "SELECT ITMITMTYPECODE, ITMCODE FROM mstItem "
                    '    wsSql = wsSql & " WHERE ITMSTATUS <> '2' AND ITMITMTYPECODE LIKE '%" & Set_Quote(.Columns(SITMTYPE).Text) & "%' "
                    '    wsSql = wsSql & " ORDER BY ITMITMTYPECODE "

                    Call Ini_Combo(2, wsSql, .Columns(eventArgs.ColIndex).Left + VB6.FromPixelsUserX(.Left, 0, 11923.8, 794) + .Columns(eventArgs.ColIndex).Top, VB6.FromPixelsUserY(.Top, 0, 7406.11, 494) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLITMTYPE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail

                Case SVDRCODE

                    wsSql = "SELECT VDRCODE, VDRNAME FROM mstVENDOR "
                    wsSql = wsSql & " WHERE VDRSTATUS <> '2' AND VDRCODE LIKE '%" & Set_Quote(.Columns(SVDRCODE).Text) & "%' "
                    wsSql = wsSql & " ORDER BY VDRCODE "

                    Call Ini_Combo(2, wsSql, .Columns(eventArgs.ColIndex).Left + VB6.FromPixelsUserX(.Left, 0, 11923.8, 794) + .Columns(eventArgs.ColIndex).Top, VB6.FromPixelsUserY(.Top, 0, 7406.11, 494) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLVDRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
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
                    If .Bookmark = waResult.get_UpperBound(2) Then Exit Sub
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
                        Case SINDENT
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SITMTYPE
                        Case SITMTYPE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SITMCODE
                        Case SITMCODE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SQTY
                        Case SVDRCODE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SITMNAME
                        Case SITMNAME
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SQTY
                        Case SQTY
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SUNITPRICE
                        Case SUNITPRICE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SDISPER
                        Case SDISPER
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SITMTYPE

                    End Select

                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case SITMTYPE
                            .Col = SINDENT
                        Case SITMCODE
                            .Col = SITMTYPE
                        Case SVDRCODE
                            .Col = SITMCODE
                        Case SITMNAME
                            .Col = SVDRCODE
                        Case SQTY
                            .Col = SITMNAME
                        Case SUCST
                            .Col = SQTY
                        Case SCST
                            .Col = SUCST
                        Case SUNITPRICE
                            .Col = SCST
                        Case SDISPER
                            .Col = SUNITPRICE
                        Case SAMT
                            .Col = SDISPER
                        Case SNET
                            .Col = SAMT

                    End Select

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    Select Case .Col
                        Case SINDENT
                            .Col = SITMTYPE
                        Case SITMTYPE
                            .Col = SITMCODE
                        Case SITMCODE
                            .Col = SVDRCODE
                        Case SVDRCODE
                            .Col = SITMNAME
                        Case SITMNAME
                            .Col = SQTY
                        Case SQTY
                            .Col = SUCST
                        Case SUCST
                            .Col = SCST
                        Case SCST
                            .Col = SUNITPRICE
                        Case SUNITPRICE
                            .Col = SDISPER
                        Case SDISPER
                            .Col = SAMT
                        Case SAMT
                            .Col = SNET
                    End Select
            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub

    Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
        Select Case tblDetail.Col
            Case SUNITPRICE
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, True)

            Case SDISPER
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, True)

            Case SQTY
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, False)

        End Select
    End Sub

    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange

        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail
            If IsEmptyRow() Then
                .Col = SITMTYPE
            End If

            'Call Calc_Total

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    Case SITMCODE
                        Call Chk_grdITMCODE(.Columns(SITMCODE).Text, .Columns(SITMTYPE).Text, "", "", "", "", "")
                    Case SITMTYPE
                        Call Chk_grdItmType((.Columns(SITMTYPE).Text))
                    Case SVDRCODE
                        Call Chk_grdVdrCode(.Columns(SVDRCODE).Text, "")
                    Case SDISPER
                        Call Chk_grdDisPer((.Columns(SDISPER).Text))
                        'Case QTY
                        '    Call Chk_grdQTY(.Columns(QTY).Text)
                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub

    Private Function Chk_grdITMCODE(ByVal inAccNo As String, ByVal inITMTYPE As String, ByRef outAccID As String, ByRef outAccNo As String, ByRef OutName As String, ByRef OutVdrID As String, ByRef OutVdrCode As String) As Boolean
        Dim wsSql As String
        Dim rsDes As New ADODB.Recordset
        Dim wsCurr As String
        Dim wsExcr As String
        Dim wdPrice As Double
        Dim wlVdrID As Integer



        If Trim(inAccNo) = "" Then
            gsMsg = "沒有輸入書號!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
            Exit Function
        End If

        wlVdrID = 0

        wsSql = "SELECT ITMID, ITMCODE, ITMCHINAME ITNAME, ITMPVDRID, ITMBOTTOMPRICE, ITMCURR FROM MSTITEM"
        wsSql = wsSql & " WHERE ITMCODE = '" & Set_Quote(inAccNo) & "' AND ITMITMTYPECODE = '" & Set_Quote(inITMTYPE) & "' "

        rsDes.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccID = ReadRs(rsDes, "ITMID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccNo = ReadRs(rsDes, "ITMCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsDes, "ITNAME")
            wlVdrID = To_Value(ReadRs(rsDes, "ITMPVDRID"))

            Chk_grdITMCODE = True
        Else
            outAccID = ""
            OutName = ""
            gsMsg = "沒有此書!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdITMCODE = False
            rsDes.Close()
            'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsDes = Nothing
            Exit Function
        End If

        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing

        If wlVdrID = 0 Then

            wsSql = "SELECT VdrItemVdrID VID, VdrCode "
            wsSql = wsSql & " FROM MstVdrItem, MstVendor "
            wsSql = wsSql & " WHERE VdrItemItmID = " & outAccID
            wsSql = wsSql & " AND VdrItemStatus = '1' "
            wsSql = wsSql & " AND VdrItemVdrID = VdrID "
            wsSql = wsSql & " Order By VdrItemCostl "

        Else

            wsSql = "SELECT VdrID VID, VdrCode "
            wsSql = wsSql & " FROM MstVendor "
            wsSql = wsSql & " WHERE VdrID = " & wlVdrID

        End If
        rsDes.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutVdrID = ReadRs(rsDes, "VID")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutVdrCode = ReadRs(rsDes, "VdrCode")

        Else

            OutVdrID = ""
            OutVdrCode = ""

        End If

        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing



    End Function


    Private Function Chk_grdItmType(ByRef inAccNo As String) As Boolean
        Dim wsSql As String
        Dim rsDes As New ADODB.Recordset
        Dim wsCurr As String
        Dim wsExcr As String
        Dim wdPrice As Double


        If Trim(inAccNo) = "" Then
            gsMsg = "沒有輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdItmType = False
            Exit Function
        End If


        wsSql = "SELECT * FROM MSTITEMTYPE"
        wsSql = wsSql & " WHERE ITMTYPECODE = '" & Set_Quote(inAccNo) & "'"

        rsDes.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then
            Chk_grdItmType = True
        Else
            gsMsg = "沒有此分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdItmType = False
        End If

        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing
    End Function
    Private Function Chk_grdVdrCode(ByVal inAccNo As String, ByRef outAccID As String) As Boolean
        Dim wsSql As String
        Dim rsDes As New ADODB.Recordset


        If Trim(inAccNo) = "" Then
            gsMsg = "沒有輸入!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdVdrCode = False
            Exit Function
        End If


        wsSql = "SELECT VDRID FROM MSTVENDOR "
        wsSql = wsSql & " WHERE VdrCode = '" & Set_Quote(inAccNo) & "'"

        rsDes.Open(wsSql, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsDes.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            outAccID = ReadRs(rsDes, "VdrID")
            Chk_grdVdrCode = True

        Else
            outAccID = ""
            gsMsg = "沒有此分類!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdVdrCode = False
        End If

        rsDes.Close()
        'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDes = Nothing

    End Function
    Private Function Chk_grdQty(ByRef inQty As String) As Boolean
        Chk_grdQty = False

        If Trim(inQty) = "" Then
            gsMsg = "沒有輸入書本數量!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        If CDbl(inQty) < 1 Then
            gsMsg = "書本數量不可小於一本!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        Chk_grdQty = True
    End Function

    Private Function Chk_grdUNITPRICE(ByRef inUnitPrice As String) As Boolean
        Chk_grdUNITPRICE = False

        If Trim(inUnitPrice) = "" Then
            gsMsg = "沒有輸入價格!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If


        If To_Value(inUnitPrice) < 0 Then
            gsMsg = "價格不可小於零!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        Chk_grdUNITPRICE = True
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
			
			If Chk_grdItmType(waResult.get_Value(LastRow, SITMTYPE)) = False Then
				.Col = SITMTYPE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdITMCODE(waResult.get_Value(LastRow, SITMCODE), waResult.get_Value(LastRow, SITMTYPE), "", "", "", "", "") = False Then
				.Col = SITMCODE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdVdrCode(waResult.get_Value(LastRow, SVDRCODE), "") = False Then
				.Col = SVDRCODE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdUNITPRICE(waResult.get_Value(LastRow, SUNITPRICE)) = False Then
				.Col = SUNITPRICE
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdDisPer(waResult.get_Value(LastRow, SDISPER)) = False Then
				.Col = SDISPER
				.Row = LastRow
				Exit Function
			End If
			
			If Chk_grdQty(waResult.get_Value(LastRow, SQTY)) = False Then
				.Col = SQTY
				.Row = LastRow
				Exit Function
			End If
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
			.MultipleLines = 1
			.AllowAddNew = True
			.AllowUpdate = True
			.AllowDelete = True
			'   .AlternatingRowStyle = True
			.RecordSelectors = False
			.AllowColMove = False
			.AllowColSelect = False
			
			For wiCtr = SLINENO To SITMID
				.Columns(wiCtr).AllowSizing = False
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = False
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case SLINENO
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).DataWidth = 5
						.Columns(wiCtr).Locked = True
					Case SLN_Renamed
						.Columns(wiCtr).DataWidth = 5
						.Columns(wiCtr).Visible = False
					Case SINDENT
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).DataWidth = 2
					Case SITMCODE
						.Columns(wiCtr).Width = 2000
						.Columns(wiCtr).Button = True
						.Columns(wiCtr).DataWidth = 30
					Case SITMTYPE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Button = True
					Case SVDRCODE
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).Button = True
						.Columns(wiCtr).DataWidth = 10
					Case SITMNAME
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).DataWidth = 60
						
					Case SUNITPRICE
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 6
						.Columns(wiCtr).NumberFormat = gsAmtFmt
						.Columns(wiCtr).Locked = True
					Case SUCST
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 6
						.Columns(wiCtr).NumberFormat = gsAmtFmt
						.Columns(wiCtr).Locked = True
					Case SDISPER
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).DataWidth = 6
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SQTY
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Locked = False
					Case SAMT
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Locked = False
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SNET
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Locked = False
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SCST
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Locked = False
						.Columns(wiCtr).NumberFormat = gsAmtFmt
						
					Case SITMID
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Visible = False
					Case SVDRID
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Visible = False
						
				End Select
			Next 
			'  .Styles("EvenRow").BackColor = &H8000000F
		End With
		
	End Sub
	
	Private Function Chk_NoDup(ByRef inRow As Integer) As Boolean
		
		Dim wlCtr As Integer
		Dim wsCurRec As String
		Dim wsCurRecLn As String
		Chk_NoDup = False
		
		wsCurRec = tblDetail.Columns(SITMCODE).Text
		'       wsCurRecLn = tblDetail.Columns(wsWhsCode)
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If inRow <> wlCtr Then
				If wsCurRec = waResult.get_Value(wlCtr, SITMCODE) Then
					gsMsg = "重覆於第 " & waResult.get_Value(wlCtr, SLINENO) & " 行!"
					MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
					Exit Function
				End If
			End If
		Next 
		
		Chk_NoDup = True
		
	End Function
	
	
	Private Sub cmdBOM()
		
		'  With frmITMLST
		'      .inCurr = wsHCurr
		'      .inExcr = wdHExcr
		'      .InvDoc = waResult
		'      .InvItem = waItem
		'      .inLineNo = wlLineNo
		'      .Show vbModal
		'      waResult.ReDim 0, .InvDoc.UpperBound(1), GLINENO, GDESC4
		'      waItem.ReDim 0, .InvItem.UpperBound(1), SLINENO, SITMID
		'      Set waResult = .InvDoc
		'      Set waItem = .InvItem
		'      wlLineNo = .inLineNo
		'  End With
		
		'  Unload frmITMLST
		'  tblDetail.ReBind
		'  tblDetail.Bookmark = 0
		
		'Call Calc_Total
		'Call cmdCstRefresh
		
		
	End Sub
	Private Function Chk_grdDisPer(ByRef inCode As String) As Boolean
		
		Chk_grdDisPer = True
		
		
		If To_Value(inCode) < 0 Then
			gsMsg = "單價必需大為零!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdDisPer = False
			Exit Function
		End If
		
	End Function
End Class