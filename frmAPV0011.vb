Option Strict Off
Option Explicit On
Friend Class frmAPV0011
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private wbErr As Boolean
	
	Private wsVdrNo As String
	Private wlDocID As Integer
	Private wlLastRow As Integer
	
	Private wiExit As Boolean
	
	Private wsFormCaption As String
	Private wsFormID As String
	Private wbUpdFlg As Boolean
	Private wsTrnCd As String
	
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcExit As String = "Exit"
	
	Private Const SDOCLINE As Short = 0
	Private Const SITMCODE As Short = 1
	Private Const SITMNAME As Short = 2
	Private Const SITMTYPE As Short = 3
	Private Const SUPRICE As Short = 4
	Private Const SQTY As Short = 5
	Private Const SSOH As Short = 6
	Private Const SRECQTY As Short = 7
	Private Const SRELQTY As Short = 8
	Private Const SDUMMY As Short = 9
	Private Const SID As Short = 10
	
	
	
	Public WriteOnly Property InDocID() As Integer
		Set(ByVal Value As Integer)
			wlDocID = Value
		End Set
	End Property
	
	
	Public WriteOnly Property InVdrNo() As String
		Set(ByVal Value As String)
			wsVdrNo = Value
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
	
	
	
	
	
	
	Private Sub frmAPV0011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
			Case System.Windows.Forms.Keys.F7
				Call LoadRecord()
				
				
			Case System.Windows.Forms.Keys.Escape
				Me.Close()
		End Select
	End Sub
	
	Private Sub frmAPV0011_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
		
		waResult.ReDim(0, -1, SDOCLINE, SID)
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
		
		
		Select Case wsTrnCd
			Case "PO"
				lblDspDocNo.Text = Get_TableInfo("POPPOHD", "POHDDOCID = " & wlDocID, "POHDDOCNO")
				'  lblDspRefNo.Caption = Get_TableInfo("POPPOHD", "POHDDOCID = " & wlDocID, "POHDCUSPO")
				
			Case "PV"
				lblDspDocNo.Text = Get_TableInfo("POPPVHD", "PVHDDOCID = " & wlDocID, "PVHDDOCNO")
				'  lblDspRefNo.Caption = Get_TableInfo("POPPVHD", "PVHDDOCID = " & wlDocID, "PVHDCUSPO")
				
			Case "GR"
				lblDspDocNo.Text = Get_TableInfo("POPGRHD", "GRHDDOCID = " & wlDocID, "GRHDDOCNO")
				
			Case "PR"
				lblDspDocNo.Text = Get_TableInfo("POPPRHD", "PRHDDOCID = " & wlDocID, "PRHDDOCNO")
				'  lblDspRefNo.Caption = Get_TableInfo("POPPRHD", "PRHDDOCID = " & wlDocID, "PRHDCUSPO")
				
		End Select
		
		lblDspVdrNo.Text = wsVdrNo & " - " & Get_TableInfo("MSTVENDOR", "VDRCODE = '" & Set_Quote(wsVdrNo) & "'", "VDRNAME")
		
		'  wbUpdate = False
		
		Call LoadRecord()
		
	End Sub
	
	Private Sub frmAPV0011_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmAPV0011 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	
	Private Sub IniForm()
		Me.KeyPreview = True
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		' wsFormID = "APR0011"
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNo.Text = Get_Caption(waScrItm, "DOCNO")
		'   lblRefNo.Caption = Get_Caption(waScrItm, "REFNO")
		lblVdrNo.Text = Get_Caption(waScrItm, "VdrNo")
		
		With tblDetail
			.Columns(SDOCLINE).Caption = Get_Caption(waScrItm, "SDOCLINE")
			.Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SITMCODE")
			.Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SITMNAME")
			.Columns(SITMTYPE).Caption = Get_Caption(waScrItm, "SITMTYPE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SSOH).Caption = Get_Caption(waScrItm, "SSOH")
			.Columns(SRELQTY).Caption = Get_Caption(waScrItm, "SRELQTY")
			.Columns(SRECQTY).Caption = Get_Caption(waScrItm, "SRECQTY")
			.Columns(SUPRICE).Caption = Get_Caption(waScrItm, "SUPRICE")
		End With
		
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
						Case SRELQTY
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = SDOCLINE
						Case Else
                            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> SDOCLINE Then
                        .Col = .Col - 1
                    End If
                Case System.Windows.Forms.Keys.Right
                    Select Case .Col
                        Case SRELQTY
                            eventArgs.keyCode = System.Windows.Forms.Keys.Down
                            .Col = SDOCLINE
                        Case Else
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
			
			
			
		End Select
		
	End Sub
	
	Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
		
		wbErr = False
		On Error GoTo RowColChange_Err
		
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If ActiveControl.Name <> tblDetail.Name Then Exit Sub
		
		With tblDetail
			
			
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
			
			For wiCtr = SDOCLINE To SID
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = True
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case SDOCLINE
						.Columns(wiCtr).DataWidth = 3
						.Columns(wiCtr).Width = 500
					Case SITMCODE
						.Columns(wiCtr).DataWidth = 30
						.Columns(wiCtr).Width = 2000
					Case SITMNAME
						.Columns(wiCtr).DataWidth = 50
						.Columns(wiCtr).Width = 2500
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
					Case SRELQTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
						.Columns(wiCtr).Locked = False
					Case SRECQTY
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
			
			Case "PO"
				
				wsSQL = "SELECT PODTID SID, PODTDOCLINE DOCLINE, PODTITEMID ITEMID, ITMCODE, PODTITEMDESC ITEMDESC, ITMITMTYPECODE, PODTUPRICE UPRICE, PODTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " PODTQTY QTY, PODTRECQTY RECQTY, PODTRELQTY RELQTY "
				wsSQL = wsSQL & " FROM POPPODT, mstITEM "
				wsSQL = wsSQL & " WHERE PODTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY PODTDOCLINE "
				
				
			Case "PV"
				
				wsSQL = "SELECT PVDTID SID, PVDTDOCLINE DOCLINE, PVDTITEMID ITEMID, ITMCODE, PVDTITEMDESC ITEMDESC, ITMITMTYPECODE, PVDTUPRICE UPRICE, PVDTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " PVDTQTY QTY, 0 RECQTY, 0 RELQTY "
				wsSQL = wsSQL & " FROM POPPVDT, mstITEM "
				wsSQL = wsSQL & " WHERE PVDTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND PVDTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY PVDTDOCLINE "
				
			Case "GR"
				
				wsSQL = "SELECT GRDTID SID, GRDTDOCLINE DOCLINE, GRDTITEMID ITEMID, ITMCODE, GRDTITEMDESC ITEMDESC, ITMITMTYPECODE, GRDTUPRICE UPRICE, GRDTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " GRDTQTY QTY, 0 RECQTY, 0 RELQTY "
				wsSQL = wsSQL & " FROM POPGRDT, mstITEM "
				wsSQL = wsSQL & " WHERE GRDTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND GRDTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY GRDTDOCLINE "
				
			Case "PR"
				
				wsSQL = "SELECT PRDTID SID, PRDTDOCLINE DOCLINE, PRDTITEMID ITEMID, ITMCODE, PRDTITEMDESC ITEMDESC, ITMITMTYPECODE, PRDTUPRICE UPRICE, PRDTLNTYPE LNTYPE, "
				wsSQL = wsSQL & " PRDTQTY QTY, 0 RECQTY, 0 RELQTY "
				wsSQL = wsSQL & " FROM POPPRDT, mstITEM "
				wsSQL = wsSQL & " WHERE PRDTDOCID = " & wlDocID
				wsSQL = wsSQL & " AND PRDTITEMID = ITMID "
				wsSQL = wsSQL & " ORDER BY PRDTDOCLINE "
				
		End Select
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmAPV0011.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        wiCtr = 1
        With waResult
            .ReDim(0, -1, SDOCLINE, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF

                wdQty = Get_StockAvailable(To_Value(ReadRs(rsRcd, "ITEMID")), "", "")

                .AppendRows()

                waResult.get_Value(.get_UpperBound(1), SDOCLINE) = VB6.Format(wiCtr, "000")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMCODE) = ReadRs(rsRcd, "ITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMNAME) = ReadRs(rsRcd, "ITEMDESC")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMTYPE) = ReadRs(rsRcd, "ITMITMTYPECODE")
                waResult.get_Value(.get_UpperBound(1), SUPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "UPRICE")), gsUprFmt)
                waResult.get_Value(.get_UpperBound(1), SRECQTY) = IIf(wsTrnCd <> "PO", "", VB6.Format(To_Value(ReadRs(rsRcd, "RECQTY")), gsQtyFmt))
                waResult.get_Value(.get_UpperBound(1), SRELQTY) = IIf(wsTrnCd <> "PO", "", VB6.Format(To_Value(ReadRs(rsRcd, "RELQTY")), gsQtyFmt))
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
        'UPGRADE_ISSUE: Form property frmAPV0011.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		
	End Function
	
	
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub
		
		
		Select Case Button.Name
			
			Case tcExit
				Me.Close()
				
			Case tcRefresh
				Call LoadRecord()
				
				
		End Select
	End Sub
End Class