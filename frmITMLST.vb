Option Strict Off
Option Explicit On
Friend Class frmITMLST
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Dim waInvDoc As New XArrayDBObject.XArrayDB
	Private wbErr As Boolean
	Private wlLineNo As Integer
	Private wsBaseCurCd As String
	
	
	Private wiExit As Boolean
	Private wiUpdate As Boolean
	
	Private wsFormCaption As String
	Private wsFormID As String
	
	
	Private Const tcGo As String = "Go"
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	Private Const XSEL As Short = 0
	Private Const XITMTYPE As Short = 1
	Private Const XITMCODE As Short = 2
	Private Const XITMCLS As Short = 3
	Private Const XITMNAME As Short = 4
	Private Const XUNITPRICE As Short = 5
	Private Const XITMID As Short = 6
	
	
	Private Const LINENO As Short = 0
	Private Const ITMTYPE As Short = 1
	Private Const ITMCODE As Short = 2
	Private Const ITMNAME As Short = 3
	Private Const LOTNO As Short = 4
	Private Const WHSCODE As Short = 5
	Private Const SOH As Short = 6
	Private Const LOTTO As Short = 7
	Private Const PRICE As Short = 8
	Private Const QTY As Short = 9
	Private Const NET As Short = 10
	Private Const ITMID As Short = 11
	Private Const SOID As Short = 12
	
	
	
	
	Public Property InvDoc() As XArrayDBObject.XArrayDB
		Get
			InvDoc = waInvDoc
		End Get
		Set(ByVal Value As XArrayDBObject.XArrayDB)
			waInvDoc = Value
		End Set
	End Property
	
	
	
	Public Property inLineNo() As Integer
		Get
			inLineNo = wlLineNo
		End Get
		Set(ByVal Value As Integer)
			wlLineNo = Value
		End Set
	End Property
	
	
	
	Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboDocNoFr
		
		
		wsSQL = "SELECT SOHDDOCNO, CUSCODE, CUSNAME "
		wsSQL = wsSQL & " FROM SOASOHD, MSTCUSTOMER "
		wsSQL = wsSQL & " WHERE SOHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND SOHDCUSID = CUSID "
		wsSQL = wsSQL & " AND SOHDSTATUS <> '2' "
		wsSQL = wsSQL & " ORDER BY SOHDDOCNO "
		
		Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoFr.Left, 0, 10061.7, 670)), VB6.FromPixelsUserY(cboDocNoFr.Top, 0, 7406.11, 494) + VB6.FromPixelsUserHeight(cboDocNoFr.Height, 7406.11, 494), tblCommon, wsFormID, "TBLITMLIST", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboDocNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Enter
		FocusMe(cboDocNoFr)
		wcCombo = cboDocNoFr
	End Sub
	
	Private Sub cboDocNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLenA(cboDocNoFr, 15, KeyAscii, True)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			
			If chk_cboDocNoFr = False Then GoTo EventExitSub
			
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
	
	Private Sub cboDocNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Leave
		FocusMe(cboDocNoFr, True)
	End Sub
	
	
	Private Sub frmITMLST_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F10
				Call cmdOK()
				
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
			Case System.Windows.Forms.Keys.F7
				Call LoadRecord()
				
			Case System.Windows.Forms.Keys.F5
				Call cmdSelect(1)
				
				
			Case System.Windows.Forms.Keys.F6
				Call cmdSelect(0)
				
				
		End Select
	End Sub
	
	Private Sub frmITMLST_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
		
		waResult.ReDim(0, -1, XSEL, XITMID)
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
		wiUpdate = True
		
		
		cboDocNoFr.Text = ""
		
		
	End Sub
	
	Private Sub frmITMLST_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		If wiExit = False Then
			
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
			If wiUpdate = True Then Call UpdateRecord()
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
		'UPGRADE_NOTE: Object frmITMLST may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		wsBaseCurCd = Get_CompanyFlag("CMPCURR")
		
		wsFormID = "ITMLST"
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		
		
		With tblDetail
			.Columns(XSEL).Caption = Get_Caption(waScrItm, "XSEL")
			.Columns(XITMCODE).Caption = Get_Caption(waScrItm, "XITMCODE")
			.Columns(XITMTYPE).Caption = Get_Caption(waScrItm, "XITMTYPE")
			.Columns(XITMCLS).Caption = Get_Caption(waScrItm, "XITMCLS")
			.Columns(XITMNAME).Caption = Get_Caption(waScrItm, "XITMNAME")
			.Columns(XUNITPRICE).Caption = Get_Caption(waScrItm, "XUNITPRICE")
			.Columns(XITMID).Caption = Get_Caption(waScrItm, "XITMID")
			
		End With
		
		
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F10)"
		tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F7)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		tbrProcess.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrToolTip, tcSAll) & "(F5)"
		tbrProcess.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrToolTip, tcDAll) & "(F6)"
		
		
		
	End Sub
	
	
	
	Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
		With tblDetail
			'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
		End With
	End Sub
	
	
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		Dim wlRet As Short
		Dim wlRow As Integer
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						
						Case XUNITPRICE
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = XSEL
                        Case XITMTYPE, XITMCODE, XITMCLS, XITMNAME
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                    End Select

                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> XSEL Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> XUNITPRICE Then
                        .Col = .Col + 1
                    End If

            End Select
        End With

        Exit Sub

tblDetail_KeyDown_Err:
        MsgBox("Check tblDeiail KeyDown")

    End Sub






    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "Go"
                Call cmdOK()

            Case "Cancel"

                Call cmdCancel()

            Case "Exit"
                wiUpdate = False
                Me.Close()

            Case "Refresh"
                Call LoadRecord()

            Case tcSAll

                Call cmdSelect(1)

            Case tcDAll

                Call cmdSelect(0)

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
		
		tblCommon.Visible = False
		If wcCombo.Enabled = True Then
			wcCombo.Focus()
		Else
			'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			wcCombo = Nothing
		End If
		
	End Sub
	
	
	Private Sub Ini_Grid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = False
			.MultipleLines = 0
			.AllowAddNew = False
			.AllowUpdate = True
			.AllowDelete = False
			'   .AlternatingRowStyle = True
			.RecordSelectors = False
			.AllowColMove = False
			.AllowColSelect = False
			
			For wiCtr = XSEL To XITMID
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = True
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case XSEL
						.Columns(wiCtr).DataWidth = 1
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).Locked = False
					Case XITMTYPE
						.Columns(wiCtr).Width = 2000
						.Columns(wiCtr).DataWidth = 10
					Case XITMCODE
						.Columns(wiCtr).Width = 2000
						.Columns(wiCtr).DataWidth = 30
					Case XITMCLS
						.Columns(wiCtr).Width = 500
						.Columns(wiCtr).DataWidth = 1
					Case XITMNAME
						.Columns(wiCtr).Width = 3500
						.Columns(wiCtr).DataWidth = 60
					Case XUNITPRICE
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 6
						.Columns(wiCtr).NumberFormat = gsUprFmt
					Case XITMID
						.Columns(wiCtr).DataWidth = 4
						.Columns(wiCtr).Visible = False
						
				End Select
			Next 
			'  .Styles("EvenRow").BackColor = &H8000000F
		End With
		
	End Sub
	
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		Dim lstUPrice As Double
		Dim lstExcR As Double
		Dim lstCurr As String
		
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		wsSQL = "SELECT SODTID DTID, ITMCODE, ITMITMTYPECODE, ITMCLASS, SODTITEMDESC ITMNAME, "
		wsSQL = wsSQL & "SODTUPRICE UPRICE "
		wsSQL = wsSQL & "FROM  SOASOHD, SOASODT, MSTITEM "
		wsSQL = wsSQL & "WHERE SOHDDOCNO LIKE '%" & Set_Quote(Trim(cboDocNoFr.Text)) & "%'"
		wsSQL = wsSQL & "AND SOHDDOCID = SODTDOCID "
		wsSQL = wsSQL & "AND SODTITEMID = ITMID "
		wsSQL = wsSQL & "ORDER BY ITMITMTYPECODE, ITMCODE "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmITMLST.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        With waResult
            .ReDim(0, -1, XSEL, XITMID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF


                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), XITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), XITMCODE) = ReadRs(rsRcd, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), XITMCLS) = ReadRs(rsRcd, "ITMCLASS")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), XITMNAME) = ReadRs(rsRcd, "ITMNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), XUNITPRICE) = VB6.Format(ReadRs(rsRcd, "UPRICE"), gsUprFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), XITMID) = ReadRs(rsRcd, "DTID")
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
        'UPGRADE_ISSUE: Form property frmITMLST.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal


    End Function

    Private Function UpdateRecord() As Boolean
        Dim wiCtr As Integer

        UpdateRecord = False


        If waResult.get_UpperBound(1) >= 0 Then

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, XSEL)) = "-1" Then

                    Call InsRecord(waResult.get_Value(wiCtr, XITMID))
                    wlLineNo = wlLineNo + 1

                End If
            Next
        End If



        UpdateRecord = True




    End Function


    Private Function InsRecord(ByVal inItmID As String) As Boolean
        Dim wiCtr As Integer
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim lstUPrice As Double


        Dim lstExcR As String
        Dim lstCurr As String



        Dim wiRow As Integer

        InsRecord = False


        wsSQL = "SELECT SODTITEMID ITMID, ITMCODE, ITMITMTYPECODE, ITMBARCODE, ITMCURR, SODTITEMDESC ITMNAME, "
        wsSQL = wsSQL & "ITMUNITPRICE UPRICE, SODTQTY QTY "
        wsSQL = wsSQL & "FROM  SOASODT, MSTITEM "
        wsSQL = wsSQL & "WHERE SODTID = " & To_Value(inItmID)
        wsSQL = wsSQL & "AND SODTITEMID = ITMID "


        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        lstUPrice = To_Value(ReadRs(rsRcd, "UPRICE"))
        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lstCurr = ReadRs(rsRcd, "ITMCURR")

        If UCase(Trim(lstCurr)) <> UCase(wsBaseCurCd) Then

            Call getExcRate(lstCurr, gsSystemDate, lstExcR, "")
            lstUPrice = CDbl(VB6.Format(lstUPrice * To_Value(lstExcR), gsAmtFmt))

        End If




        With waInvDoc
            .AppendRows()
            waInvDoc.get_Value(.get_UpperBound(1), LINENO) = wlLineNo
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            waInvDoc.get_Value(.get_UpperBound(1), ITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            waInvDoc.get_Value(.get_UpperBound(1), ITMCODE) = ReadRs(rsRcd, "ITMCODE")
            '  waInvDoc(.UpperBound(1), BARCODE) = ReadRs(rsRcd, "ITMBARCODE")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            waInvDoc.get_Value(.get_UpperBound(1), ITMNAME) = ReadRs(rsRcd, "ITMNAME")
            waInvDoc.get_Value(.get_UpperBound(1), LOTNO) = ""
            waInvDoc.get_Value(.get_UpperBound(1), WHSCODE) = ""
            '    waInvDoc(.UpperBound(1), PUBLISHER) = ""
            waInvDoc.get_Value(.get_UpperBound(1), QTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
            waInvDoc.get_Value(.get_UpperBound(1), PRICE) = VB6.Format(lstUPrice, gsAmtFmt)
            waInvDoc.get_Value(.get_UpperBound(1), NET) = VB6.Format(lstUPrice * To_Value(ReadRs(rsRcd, "QTY")), gsAmtFmt)
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            waInvDoc.get_Value(.get_UpperBound(1), ITMID) = ReadRs(rsRcd, "ITMID")
            waInvDoc.get_Value(.get_UpperBound(1), SOID) = "0"

        End With

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing



        InsRecord = True




    End Function


    Private Function chk_cboDocNoFr() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String


        chk_cboDocNoFr = False

        wsSQL = "SELECT * FROM SOASOHD "
        wsSQL = wsSQL & "WHERE SOHDDOCNO = '" & Set_Quote(cboDocNoFr.Text) & "'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        chk_cboDocNoFr = True

    End Function
    Private Sub cmdSelect(ByVal wiSelect As Short)
        Dim wiCtr As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor



        With waResult
            For wiCtr = 0 To .get_UpperBound(1)
                waResult.get_Value(wiCtr, XSEL) = IIf(wiSelect = 1, "-1", "0")
            Next wiCtr
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmITMLST.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub
End Class