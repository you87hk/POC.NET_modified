Option Strict Off
Option Explicit On
Friend Class frmSOLOG
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
	
	Private wsTrnCd As String
	
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcExit As String = "Exit"
	
	Private Const SDTETIM As Short = 0
	Private Const SUSRID As Short = 1
	Private Const sType As Short = 2
	Private Const SACT As Short = 3
	Private Const SDOCNO As Short = 4
	Private Const SKEY As Short = 5
	Private Const SFIELD As Short = 6
	Private Const SOLD As Short = 7
	Private Const SNEW As Short = 8
	
	
	
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
	
	
	
	
	
	Private Sub frmSOLOG_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmSOLOG_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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

        waResult.ReDim(0, -1, SDTETIM, SNEW)
        tblDetail.Array = waResult
        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        For Each MyControl In Me.Controls
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


        Select Case wsTrnCd
            Case "SO"
                lblDspDocNo.Text = Get_TableInfo("SOASOHD", "SOHDDOCID = " & wlDocID, "SOHDDOCNO")
        End Select

        lblDspCusNo.Text = wsCusNo & " - " & Get_TableInfo("MSTCUSTOMER", "CUSCODE = '" & Set_Quote(wsCusNo) & "'", "CUSNAME")

        '  wbUpdate = False

        Call LoadRecord()

    End Sub

    Private Sub frmSOLOG_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed


        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmSOLOG may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
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
        lblCusNo.Text = Get_Caption(waScrItm, "CUSNO")

        With tblDetail
            .Columns(SDTETIM).Caption = Get_Caption(waScrItm, "SDTETIM")
            .Columns(SUSRID).Caption = Get_Caption(waScrItm, "SUSRID")
            .Columns(sType).Caption = Get_Caption(waScrItm, "STYPE")
            .Columns(SACT).Caption = Get_Caption(waScrItm, "SACT")
            .Columns(SKEY).Caption = Get_Caption(waScrItm, "SKEY")
            .Columns(SFIELD).Caption = Get_Caption(waScrItm, "SFIELD")
            .Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
            .Columns(SOLD).Caption = Get_Caption(waScrItm, "SOLD")
            .Columns(SNEW).Caption = Get_Caption(waScrItm, "SNEW")
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
                        Case SNEW
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SDTETIM
                        Case Else
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = .Col + 1
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> SDTETIM Then
                        .Col = .Col - 1
                    End If
                Case System.Windows.Forms.Keys.Right
                    Select Case .Col
                        Case SNEW
                            eventArgs.KeyCode = System.Windows.Forms.Keys.Down
                            .Col = SDTETIM
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

    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange

        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail


            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col

                    Case SKEY



                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

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

            For wiCtr = SDTETIM To SNEW
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = True
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case SDTETIM
                        .Columns(wiCtr).DataWidth = 20
                        .Columns(wiCtr).Width = 2300
                    Case SUSRID
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Width = 1000
                    Case sType
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Width = 1000
                    Case SACT
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Width = 800
                    Case SDOCNO
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 15
                    Case SKEY
                        .Columns(wiCtr).Width = 1800
                        .Columns(wiCtr).DataWidth = 30
                    Case SFIELD
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 15
                    Case SOLD
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 15
                    Case SNEW
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 15
                End Select

            Next
            .Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
        End With

    End Sub
    Private Function LoadRecord() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim cmd As New ADODB.Command
        Dim wiCtr As Integer

        LoadRecord = False
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        cmd.ActiveConnection = cnCon

        cmd.CommandText = "USP_LOADSOLOG"
        cmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        cmd.Parameters.Refresh()
        Call SetSPPara(cmd, 1, wlDocID)
        Call SetSPPara(cmd, 2, "")



        rsRcd.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rsRcd.Open(cmd, , ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        ' rsRcd.Open wsSQL, cnCon, adOpenStatic, adLockOptimistic

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
            'UPGRADE_ISSUE: Form property frmSOLOG.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If


        wiCtr = 1
        With waResult
            .ReDim(0, -1, SDTETIM, SNEW)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF


                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDTETIM) = ReadRs(rsRcd, "TMPDATETIM")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SUSRID) = ReadRs(rsRcd, "TMPUSRID")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), sType) = ReadRs(rsRcd, "TMPTYPE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SACT) = ReadRs(rsRcd, "TMPACT")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "TMPDOCNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SFIELD) = ReadRs(rsRcd, "TMPFIELD")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SKEY) = ReadRs(rsRcd, "TMPKEY")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SOLD) = ReadRs(rsRcd, "TMPOLD")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SNEW) = ReadRs(rsRcd, "TMPNEW")
                wiCtr = wiCtr + 1

                rsRcd.MoveNext()
            Loop
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0

        rsRcd.Close()


        'UPGRADE_NOTE: Object cmd.ActiveConnection may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        cmd.ActiveConnection = Nothing
        'UPGRADE_NOTE: Object cmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        cmd = Nothing
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


        LoadRecord = True

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmSOLOG.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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

    Private Sub Setup_tbrProcess()

        With tbrProcess

            .Items.Item(tcRefresh).Enabled = True
            .Items.Item(tcExit).Enabled = True


        End With

    End Sub
	
	
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
			
			
			
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Check Chk_GrdRow")
		
	End Function
End Class