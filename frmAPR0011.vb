Option Strict Off
Option Explicit On
Friend Class frmAPR0011
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private wbErr As Boolean
	
	Private wsCusNo As String
	Private wlDocID As Integer
	Private wlLastRow As Integer
	
	Private wiExit As Boolean
	
	Private wsFormCaption As String
	Private wsFormID As String
	Private wbUpdFlg As Boolean
	Private wsTrnCd As String
	
	
	Private Const tcPick As String = "Pick"
	Private Const tcCalRsv As String = "CalRsv"
	Private Const tcRefresh As String = "Refresh"
	Private Const tcExit As String = "Exit"
	
	Private Const SSEL As Short = 0
	Private Const SDOCLINE As Short = 1
	Private Const SITMCODE As Short = 2
	Private Const SITMNAME As Short = 3
	Private Const SITMTYPE As Short = 4
	Private Const SUPRICE As Short = 5
	Private Const SQTY As Short = 6
	Private Const SSCHQTY As Short = 7
	Private Const SSOH As Short = 8
	Private Const SRSVQTY As Short = 9
	Private Const SDUMMY As Short = 10
	Private Const SID As Short = 11
	
	
	
	Public WriteOnly Property InDocID() As Integer
		Set(ByVal Value As Integer)
			wlDocID = Value
		End Set
	End Property
	
	
	Public WriteOnly Property InCusNo() As String
		Set(ByVal Value As String)
			wsCusNo = Value
		End Set
	End Property
	
	Public WriteOnly Property FormID() As String
		Set(ByVal Value As String)
			wsFormID = Value
		End Set
	End Property
	
	
	Public WriteOnly Property TrnCd() As String
		Set(ByVal Value As String)
			wsTrnCd = Value
		End Set
	End Property
	
	
	Public WriteOnly Property UpdFlg() As Boolean
		Set(ByVal Value As Boolean)
			wbUpdFlg = Value
		End Set
	End Property
	
	
	Private Sub cmdReserve()
		
		
		Call LoadRecord()
		
	End Sub
	
	
	
	Private Sub frmAPR0011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
			Case System.Windows.Forms.Keys.F7
				Call LoadRecord()
				
			Case System.Windows.Forms.Keys.F2
				If tbrProcess.Items.Item(tcCalRsv).Enabled = False Then Exit Sub
				Call cmdReserve()
				
			Case System.Windows.Forms.Keys.F3
				If tbrProcess.Items.Item(tcPick).Enabled = False Then Exit Sub
				Call cmdPick()
				
			Case System.Windows.Forms.Keys.Escape
				Me.Close()
		End Select
	End Sub
	
	Private Sub frmAPR0011_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		IniForm()
		Ini_Caption()
		Ini_Grid()
        Setup_tbrProcess()
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
		
		If wbUpdFlg = False Then tbrProcess.Items.Item(tcCalRsv).Enabled = False
		
		Select Case wsTrnCd
			Case "SN"
				lblDspDocNo.Text = Get_TableInfo("SOASNHD", "SNHDDOCID = " & wlDocID, "SNHDDOCNO")
			Case "SO"
				lblDspDocNo.Text = Get_TableInfo("SOASOHD", "SOHDDOCID = " & wlDocID, "SOHDDOCNO")
			Case "SP"
				lblDspDocNo.Text = Get_TableInfo("SOASPHD", "SPHDDOCID = " & wlDocID, "SPHDDOCNO")
			Case "SW"
				lblDspDocNo.Text = Get_TableInfo("SOASWHD", "SWHDDOCID = " & wlDocID, "SWHDDOCNO")
				lblDspReceived.Text = Get_TableInfo("SOASWDT, MSTSALESMAN", "SWDTWORKERID = SALEID AND SWDTDOCID = " & wlDocID, "SALENAME")
		End Select
		
		lblDspCusNo.Text = wsCusNo & " - " & Get_TableInfo("MSTCUSTOMER", "CUSCODE = '" & Set_Quote(wsCusNo) & "'", "CUSNAME")
		
		'  wbUpdate = False
		
		Call LoadRecord()
		
	End Sub
	
	Private Sub frmAPR0011_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmAPR0011 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		If wsFormID = "APR0061" Then
			lblReceived.Visible = True
			lblDspReceived.Visible = True
		Else
			lblReceived.Visible = False
			lblDspReceived.Visible = False
		End If
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		lblCusNo.Text = Get_Caption(waScrItm, "CUSNO")
		
		lblReceived.Text = Get_Caption(waScrItm, "RECEIVED")
		
		
		With tblDetail
			.Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
			.Columns(SDOCLINE).Caption = Get_Caption(waScrItm, "SDOCLINE")
			.Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SITMCODE")
			.Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SITMNAME")
			.Columns(SITMTYPE).Caption = Get_Caption(waScrItm, "SITMTYPE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SSOH).Caption = Get_Caption(waScrItm, "SSOH")
			.Columns(SRSVQTY).Caption = Get_Caption(waScrItm, "SRSVQTY")
			.Columns(SSCHQTY).Caption = Get_Caption(waScrItm, "SSCHQTY")
			.Columns(SUPRICE).Caption = Get_Caption(waScrItm, "SUPRICE")
		End With
		
		tbrProcess.Items.Item(tcPick).ToolTipText = Get_Caption(waScrItm, tcPick) & "(F3)"
		tbrProcess.Items.Item(tcCalRsv).ToolTipText = Get_Caption(waScrItm, tcCalRsv) & "(F2)"
		tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrItm, tcRefresh) & "(F7)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrItm, tcExit) & "(F12)"
		
		
		
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
		Dim wsLnType As String
		Dim wsDesc As String
		Dim wdPrice As Double
		Dim wdCost As Double
		
		On Error GoTo tblDetail_BeforeColUpdate_Err
		
		
		
		With tblDetail
			Select Case eventArgs.ColIndex
				
				
				
				Case SRSVQTY
					
					If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
						GoTo Tbl_BeforeColUpdate_Err
					End If
					
					If To_Value((.Columns(eventArgs.ColIndex).Text)) > 0 Then
						.Columns(SSEL).Text = "-1"
					End If
					
			End Select
			
			'  If .Columns(ColIndex).Text <> OldValue Then
			'    wbUpdate = True
			' End If
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
	
	
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		Dim wlRet As Short
		Dim wlRow As Integer
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						Case SRSVQTY
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = SRSVQTY
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
                        Case SRSVQTY
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
			
			Case SRSVQTY
				Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, False)
				
				
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
					
					Case SQTY
						
						Call Chk_grdQty((.Columns(SQTY).Text))
						
						
				End Select
				lblDspItmDesc.Text = .Columns(.Col).Text
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
		
		'   If To_Value(inCode) = 0 Then
		'       gsMsg = "數量必需大於零!"
		'       MsgBox gsMsg, vbOKOnly, gsTitle
		'       Chk_grdQty = False
		'       Exit Function
		'   End If
		
		
		
		
	End Function
	
	Private Function Chk_grdRsvQty(ByRef inCode As String) As Boolean
		
		Chk_grdRsvQty = True
		
		If Trim(inCode) = "" Then
			gsMsg = "必需輸入數量!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdRsvQty = False
			Exit Function
		End If
		
		If To_Value(inCode) = 0 Then
			gsMsg = "數量必需大於零!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdRsvQty = False
			Exit Function
		End If
		
		
	End Function
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
					Case SDOCLINE
						.Columns(wiCtr).DataWidth = 3
						.Columns(wiCtr).Width = 500
					Case SITMCODE
						.Columns(wiCtr).DataWidth = 30
						.Columns(wiCtr).Width = 2000
					Case SITMNAME
						.Columns(wiCtr).DataWidth = 50
						.Columns(wiCtr).Width = 1500
					Case SITMTYPE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
					Case SUPRICE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).NumberFormat = gsUprFmt
					Case SQTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SSOH
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SRSVQTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
						.Columns(wiCtr).Locked = False
					Case SSCHQTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
						'.Columns(wiCtr).Locked = False
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
		Dim wdQty As Double
		Dim wsItmCd As String
		
		LoadRecord = False
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Select Case wsTrnCd
			
			Case "SN"
				
				wsSQL = "SELECT SNDTID SID, SNDTDOCLINE DOCLINE, SNDTITEMID ITEMID, ITMCODE, SNDTITEMDESC ITEMDESC, ITMITMTYPECODE, SNDTUPRICE UPRICE, SNDTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " SNDTTOTQTY QTY, SNDTRSVQTY RSVQTY, SNDTSCHQTY SCHQTY "
				wsSQL = wsSQL & " FROM soaSNDT, mstITEM "
				wsSQL = wsSQL & " WHERE SNDTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND SNDTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY SNDTDOCLINE "
				
			Case "SO"
				
				wsSQL = "SELECT SODTITEMID SID, SODTITEMID ITEMID, ITMCODE, SODTITEMDESC ITEMDESC, ITMITMTYPECODE, SODTUPRICE UPRICE, 'P' LNTYPE, "
				wsSQL = wsSQL & " SUM(SODTTOTQTY) QTY, SUM(SODTRSVQTY) RSVQTY, SUM(SODTSCHQTY) SCHQTY "
				wsSQL = wsSQL & " FROM soaSODT, mstITEM "
				wsSQL = wsSQL & " WHERE SODTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND SODTITEMID = ITMID "
				wsSQL = wsSQL & " GROUP BY SODTITEMID,  SODTITEMID, ITMCODE, SODTITEMDESC, ITMITMTYPECODE, SODTUPRICE "
				
			Case "SP"
				
				wsSQL = "SELECT SPDTID SID, SPDTDOCLINE DOCLINE, SPDTITEMID ITEMID, ITMCODE, SPDTITEMDESC ITEMDESC, ITMITMTYPECODE, SPDTUPRICE UPRICE, SPDTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " SPDTQTY QTY, SPDTBALQTY RSVQTY, SPDTOUTQTY SCHQTY "
				wsSQL = wsSQL & " FROM soaSPDT, mstITEM "
				wsSQL = wsSQL & " WHERE SPDTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND SPDTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY SPDTDOCLINE "
				
			Case "SW"
				
				wsSQL = "SELECT SWDTID SID, SWDTDOCLINE DOCLINE, SWDTITEMID ITEMID, ITMCODE, SWDTITEMDESC ITEMDESC, ITMITMTYPECODE, SWDTUPRICE UPRICE, SWDTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " SWDTQTY QTY, SWDTBALQTY RSVQTY, SWDTOUTQTY SCHQTY "
				wsSQL = wsSQL & " FROM soaSWDT, mstITEM "
				wsSQL = wsSQL & " WHERE SWDTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND SWDTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY SWDTDOCLINE "
				
		End Select
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmAPR0011.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        wiCtr = 1
        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, LNTYPE). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If ReadRs(rsRcd, "LNTYPE") = "T" And wsTrnCd = "SN" Then
                    wdQty = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsItmCd = "*" & ReadRs(rsRcd, "ITMCODE")
                Else
                    wdQty = Get_StockAvailable(To_Value(ReadRs(rsRcd, "ITEMID")), "", "")
                    'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsItmCd = ReadRs(rsRcd, "ITMCODE")
                End If

                .AppendRows()
                waResult.get_Value(.get_UpperBound(1), SSEL) = "0"
                waResult.get_Value(.get_UpperBound(1), SDOCLINE) = VB6.Format(wiCtr, "000")
                waResult.get_Value(.get_UpperBound(1), SITMCODE) = wsItmCd
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMNAME) = ReadRs(rsRcd, "ITEMDESC")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
                waResult.get_Value(.get_UpperBound(1), SUPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "UPRICE")), gsUprFmt)
                waResult.get_Value(.get_UpperBound(1), SRSVQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "RSVQTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SSCHQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "SCHQTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SSOH) = VB6.Format(wdQty, gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SID) = To_Value(ReadRs(rsRcd, "SID"))
                wiCtr = wiCtr + 1

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
        'UPGRADE_ISSUE: Form property frmAPR0011.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		
	End Function
	
	
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub
		
		
		Select Case Button.Name
			
			Case tcPick
				Call cmdPick()
				
			Case tcCalRsv
				Call cmdReserve()
				
			Case tcExit
				Me.Close()
				
			Case tcRefresh
				Call LoadRecord()
				
				
		End Select
	End Sub
	
    Private Sub Setup_tbrProcess()

        With tbrProcess

            Select Case wsFormID
                Case "APR0011"

                    .Items.Item(tcCalRsv).Enabled = True
                    .Items.Item(tcPick).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcExit).Enabled = True

                Case "APR0021"

                    .Items.Item(tcCalRsv).Enabled = True
                    .Items.Item(tcPick).Enabled = True
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcExit).Enabled = True


                Case "APR0031", "APR0061"

                    .Items.Item(tcCalRsv).Enabled = False
                    .Items.Item(tcPick).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcExit).Enabled = True

            End Select

            If wbUpdFlg = False Then
                .Items.Item(tcCalRsv).Enabled = False
                .Items.Item(tcPick).Enabled = False
                .Items.Item(tcRefresh).Enabled = True
                .Items.Item(tcExit).Enabled = True
            End If

        End With

    End Sub
	
	Private Function InputValidation() As Boolean
		Dim wiEmptyGrid As Boolean
		Dim wlCtr As Integer
		
		InputValidation = False
		
		On Error GoTo InputValidation_Err
		
		wiEmptyGrid = True
		wlLastRow = 0
		With waResult
			For wlCtr = 0 To .get_UpperBound(1)
				If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
					wiEmptyGrid = False
					If Chk_GrdRow(wlCtr) = False Then
						tblDetail.Focus()
						Exit Function
					End If
					wlLastRow = wlLastRow + 1
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
			
			If Chk_grdRsvQty(waResult.get_Value(LastRow, SRSVQTY)) = False Then
				.Col = SRSVQTY
				Exit Function
			End If
			
			
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
	
	
	Private Sub cmdPick()
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wiCtr As Short
		Dim wsDocNo As String
		Dim wlLineNo As Integer
		Dim wlHDID As Integer
		
		On Error GoTo cmdPick_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		
		If InputValidation() = False Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		gsMsg = "你是否確認要轉換配貨單?"
		If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
			Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		End If
		
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		wlLineNo = 1
		wlHDID = 0
		
		If waResult.get_UpperBound(1) >= 0 Then
			adcmdSave.CommandText = "USP_CRTPICKLST"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			For wiCtr = 0 To waResult.get_UpperBound(1)
				If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
					Call SetSPPara(adcmdSave, 1, wlDocID)
					Call SetSPPara(adcmdSave, 2, waResult.get_Value(wiCtr, SID))
					Call SetSPPara(adcmdSave, 3, wlHDID)
					Call SetSPPara(adcmdSave, 4, wlLineNo)
					Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, SITMNAME))
					Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, SUPRICE))
					Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, SRSVQTY))
					Call SetSPPara(adcmdSave, 8, wsFormID)
					Call SetSPPara(adcmdSave, 9, gsUserID)
					Call SetSPPara(adcmdSave, 10, wsGenDte)
					Call SetSPPara(adcmdSave, 11, IIf(wlLastRow = wlLineNo, "Y", "N"))
					
					adcmdSave.Execute()
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wlHDID = GetSPPara(adcmdSave, 12)
					'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					wsDocNo = GetSPPara(adcmdSave, 13)
					wlLineNo = wlLineNo + 1
				End If
			Next 
		End If
		
		
		cnCon.CommitTrans()
		
		
		gsMsg = "文件 ： " & wsDocNo & " 已完成!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		
		
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		Call LoadRecord()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
cmdPick_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
	End Sub
End Class