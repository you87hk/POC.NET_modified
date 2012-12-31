Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmHHIM001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	Private wsDteTim As String
	
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wsTrnCd As String
	Private wiActRow As Short
	
	Private wsHHPath As String
	
	
	
	Private Const tcUpdate As String = "Update"
	Private Const tcDelete As String = "Delete"
	
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	
	Private Const SSEL As Short = 0
	Private Const SUSRID As Short = 1
	Private Const SDTETIM As Short = 2
	Private Const SDATE As Short = 3
	Private Const SHH As Short = 4
	Private Const SDOCNO As Short = 5
	Private Const SQTY As Short = 6
	Private Const SDUMMY As Short = 7
	Private Const SID As Short = 8
	
	
	
	
	Private Sub btnImport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnImport.Click
		Call cmdImport()
		
	End Sub
	
	Private Sub btnReceive_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReceive.Click
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call ReceiveFromHH(wsHHPath)
		
		MsgBox("End of Receiving")
		
		Call LoadHHList()
		
		
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmHHIM001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub

    Private Sub LoadHHList()


        Dim MyFile As Object

        HHList.Items.Clear()

        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        MyFile = Dir(wsHHPath, FileAttribute.Normal)
        'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Do While MyFile <> ""

            'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            HHList.Items.Add(MyFile)

            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            MyFile = Dir()
        Loop

        btnImport.Enabled = (HHList.Items.Count > 0)
    End Sub

    'UPGRADE_WARNING: Event frmHHIM001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmHHIM001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub


    Private Sub frmHHIM001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F6
                Call cmdSave(1)

            Case System.Windows.Forms.Keys.F7
                Call cmdSave(2)

            Case System.Windows.Forms.Keys.F8
                Call cmdImport()

            Case System.Windows.Forms.Keys.F3
                Call cmdCancel()

            Case System.Windows.Forms.Keys.F12
                Me.Close()

            Case System.Windows.Forms.Keys.F5
                Call LoadRecord()

            Case System.Windows.Forms.Keys.F9
                Call cmdSelect(1)

            Case System.Windows.Forms.Keys.F10
                Call cmdSelect(0)


        End Select
    End Sub

    Private Sub frmHHIM001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


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


    Private Sub cmdImport()
        Dim sFullFile As String
        Dim sFileName As String
        Dim sExt As String
        Dim SDOCNO As String
        Dim i As Short
        Dim bPost As Boolean
        Dim relUpdFlg As String

        Dim sfile As String
        Dim wsDteTim As String
        Dim sBKFile As String


        On Error GoTo cmdImport_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        wsDteTim = Change_SQLDate(CStr(Now))
        gsMsg = ""

        For i = 0 To HHList.Items.Count - 1 'hidden ListBox
            ' sFullFile = HHList.List(i)
            ' sFileName = Right(sFullFile, Len(sFullFile) - InStrRev(sFullFile, "\"))

            sFileName = VB6.GetItemString(HHList, i)
            sFullFile = wsHHPath & VB6.GetItemString(HHList, i)
            sExt = VB.Right(sFileName, Len(sFileName) - InStr(sFileName, "."))

            SDOCNO = VB.Left(sFileName, InStr(sFileName, ".") - 1) & sExt

            sBKFile = SDOCNO & "_" & VB6.Format(Now, "YYYYMMDDHHMMSS") & "." & sExt


            If UCase(sExt) <> "BAK" And UCase(sExt) <> "FLD" Then

                If Chk_HHNo(SDOCNO, relUpdFlg) = True Then
                    If relUpdFlg = "N" Then

                        gsMsg = SDOCNO & "已匯入但未更新, 你是否確認要覆寫此文件?"
                        If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
                            bPost = False
                        Else
                            bPost = True
                        End If

                    Else
                        gsMsg = SDOCNO & " 已匯入並更新!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        bPost = False
                        ' Name sFullFile As Left(sFullFile, Len(sFullFile) - 3) & "BAK"
                    End If
                Else
                    bPost = True
                End If

                If bPost Then
                    If ImportFromHH(gsUserID, wsDteTim, sFullFile) = True Then
                        gsMsg = gsMsg & IIf(gsMsg = "", SDOCNO, Chr(10) & Chr(13) & SDOCNO)
                    End If
                End If

            End If

            '    Name sFullFile As wsHHPath & "backup\" & sFileName
            Rename(sFullFile, wsHHPath & "backup\" & sBKFile)

        Next i



        gsMsg = "匯入完成!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

        Call LoadHHList()
        Call LoadRecord()

        Cursor = System.Windows.Forms.Cursors.Default

        Exit Sub

cmdImport_Err:
        Cursor = System.Windows.Forms.Cursors.Default
        MsgBox(Err.Description)




    End Sub


    Private Sub Ini_Scr()

        Dim MyControl As System.Windows.Forms.Control

        waResult.ReDim(0, -1, SSEL, SID)


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


        Call SetPeriodMask(medPrdFr)
        Call SetPeriodMask(medPrdTo)

        wiExit = False
        wsTrnCd = ""
        HHList.Visible = False
        medPrdFr.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))
        medPrdTo.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))



        If Trim(gsHHPath) <> "" Then
            wsHHPath = gsHHPath & "receive\"
        Else
            wsHHPath = My.Application.Info.DirectoryPath & "receive\"
        End If


        Call LoadHHList()

        Call LoadRecord()

    End Sub

    Private Sub frmHHIM001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmHHIM001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing



    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
        optDocType(0).Checked = True
        wsFormID = "HHIM001"


    End Sub

    Private Sub Ini_Caption()
        Call Get_Scr_Item(wsFormID, waScrItm)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")


        optDocType(0).Text = Get_Caption(waScrItm, "OPT1")
        optDocType(1).Text = Get_Caption(waScrItm, "OPT2")

        btnReceive.Text = Get_Caption(waScrItm, "RECEIVE")
        btnImport.Text = Get_Caption(waScrItm, "IMPORT")


        lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
        lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")



        With tblDetail
            .Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
            .Columns(SUSRID).Caption = Get_Caption(waScrItm, "SUSRID")
            .Columns(SDTETIM).Caption = Get_Caption(waScrItm, "SDTETIM")
            .Columns(SDATE).Caption = Get_Caption(waScrItm, "SDATE")
            .Columns(SHH).Caption = Get_Caption(waScrItm, "SHH")
            .Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
            .Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")

        End With


        tbrProcess.Items.Item(tcUpdate).ToolTipText = Get_Caption(waScrItm, tcUpdate) & "(F6)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrItm, tcDelete) & "(F7)"

        tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrItm, tcRefresh) & "(F5)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrItm, tcCancel) & "(F3)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrItm, tcExit) & "(F12)"
        tbrProcess.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrItm, tcSAll) & "(F9)"
        tbrProcess.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrItm, tcDAll) & "(F10)"


    End Sub




    'UPGRADE_WARNING: Event optDocType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optDocType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDocType.CheckedChanged
        If eventSender.Checked Then
            Dim Index As Short = optDocType.GetIndex(eventSender)
            Call LoadRecord()
        End If
    End Sub

    Private Sub optDocType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optDocType.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optDocType.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call LoadRecord()
            tblDetail.Focus()

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

        On Error GoTo tblDetail_BeforeColUpdate_Err



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

                    If .Columns(SDOCNO).Text <> "" Then



                        frmHHIM0011.InDocID = .Columns(SID).Text
                        frmHHIM0011.TrnCd = wsTrnCd
                        frmHHIM0011.inDteTim = .Columns(SDTETIM).Text
                        frmHHIM0011.FormID = "HHIM0011"
                        frmHHIM0011.ShowDialog()




                    End If


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

                Case System.Windows.Forms.Keys.Return
                    Select Case .Col
                        Case SQTY
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
                        Case SQTY
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






    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange
        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail



            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col



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
        Select Case Button.Name

            Case tcUpdate

                Call cmdSave(1)

            Case tcDelete

                Call cmdSave(2)




            Case tcCancel

                Call cmdCancel()

            Case tcExit

                Me.Close()

            Case tcRefresh

                Call LoadRecord()

            Case tcSAll

                Call cmdSelect(1)

            Case tcDAll

                Call cmdSelect(0)

        End Select
    End Sub




    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 1
            .AllowAddNew = False
            .AllowUpdate = True
            .AllowDelete = False
            .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = SSEL To SID
                .Columns(wiCtr).AllowSizing = False
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = True
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case SSEL
                        .Columns(wiCtr).DataWidth = 1
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).ValueItems.Presentation = TrueDBGrid60.PresentationConstants.dbgCheckBox
                        .Columns(wiCtr).Locked = False
                    Case SHH
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 10
                    Case SDATE
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 50
                    Case SUSRID
                        .Columns(wiCtr).Width = 1500
                        .Columns(wiCtr).DataWidth = 20
                    Case SDTETIM
                        .Columns(wiCtr).Width = 2500
                        .Columns(wiCtr).DataWidth = 50
                    Case SQTY
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                    Case SDOCNO
                        .Columns(wiCtr).Width = 2000
                        .Columns(wiCtr).DataWidth = 20
                        .Columns(wiCtr).Button = True
                    Case SDUMMY
                        .Columns(wiCtr).Width = 100
                        .Columns(wiCtr).DataWidth = 0
                    Case SID
                        .Columns(wiCtr).Visible = False
                        .Columns(wiCtr).DataWidth = 20
                End Select

            Next
            .Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
        End With

    End Sub
    Private Function LoadRecord() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wiCtr As Integer
        Dim wsSts As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        LoadRecord = False

        If Opt_Getfocus(optDocType, 2, 0) = 0 Then
            wsSts = "N"
        Else
            wsSts = "Y"
        End If

        '  wsDteTim = "2001-04-17 00:00:00.000"
        wsSQL = "SELECT HHUSRID, HHDTETIM, HHDATE, HHTID, HHNO, COUNT(HHNO) QTY, HHTYPE"
        wsSQL = wsSQL & " FROM SYSHHIM001 "
        wsSQL = wsSQL & " WHERE HHUPDFLG = '" & wsSts & "' "

        wsSQL = wsSQL & " AND HHDATE BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("0000/00/00", 6), VB.Left(medPrdFr.Text, 4) & "/" & VB.Right(medPrdFr.Text, 2)) & "/01" & "'"
        wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("9999/99/99", 6), VB.Left(medPrdTo.Text, 4) & "/" & VB.Right(medPrdTo.Text, 2)) & "/31" & "'"


        wsSQL = wsSQL & " GROUP BY HHUSRID, HHDTETIM, HHDATE, HHTID, HHNO, HHTYPE "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            waResult.ReDim(0, -1, SSEL, SID)
            tblDetail.ReBind()
            tblDetail.Bookmark = 0
            'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
            'UPGRADE_ISSUE: Form property frmHHIM001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If



        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF
                .AppendRows()
                waResult.get_Value(.get_UpperBound(1), SSEL) = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SUSRID) = ReadRs(rsRcd, "HHUSRID")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDTETIM) = ReadRs(rsRcd, "HHDTETIM")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SHH) = ReadRs(rsRcd, "HHTID")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDATE) = ReadRs(rsRcd, "HHDATE")
                waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "HHNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "HHNO")
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
        'UPGRADE_ISSUE: Form property frmHHIM001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Function


    Private Function Chk_GrdRow(ByVal LastRow As Integer) As Boolean

        Dim wlCtr As Integer
        Dim wsDes As String
        Dim wsExcRat As String
        Dim OutISBN As String

        Chk_GrdRow = False

        On Error GoTo Chk_GrdRow_Err

        With tblDetail

            If To_Value(LastRow) > waResult.get_UpperBound(1) Then
                Chk_GrdRow = True
                Exit Function
            End If

            If waResult.get_Value(LastRow, SQTY) <= 0 Then
                gsMsg = "沒有數量!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                .Col = SQTY
                .Row = LastRow
                Exit Function
            End If





        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow " & Err.Description)

    End Function




    Private Sub cmdSave(ByVal wiActFlg As Short)

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim i As Short
        Dim wsErr As String
        Dim wsRtn As String
        Dim wsDoc As String


        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate


        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        '' Last Check when Add
        If wiActFlg = 1 Then
            gsMsg = "你是否確認更新?"
        Else
            gsMsg = "你是否刪除匯入?"
        End If

        MsgBox(wsGenDte)

        If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        i = 1
        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon



        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_HHIM001A"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc

            'Added by Lewis at 08262002
            ' adcmdSave.Properties.Item("Command Time Out").Value = giTimeOut
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
                    Call SetSPPara(adcmdSave, 1, wiActFlg)
                    Call SetSPPara(adcmdSave, 2, waResult.get_Value(wiCtr, SDOCNO))
                    Call SetSPPara(adcmdSave, 3, wsFormID)
                    Call SetSPPara(adcmdSave, 4, gsUserID)
                    Call SetSPPara(adcmdSave, 5, gsSystemDate)
                    adcmdSave.Execute()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsErr = GetSPPara(adcmdSave, 6)
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsRtn = GetSPPara(adcmdSave, 7)
                    If wsErr = "-1" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No Such Document No: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-2" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No REMAIN QTY in: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-3" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No Such Item No: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-4" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Insufficient stock: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-5" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Greater then remaining Qty: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-6" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No Such Staff Code: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-7" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No Such Hand-Held ID: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-8" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Need to approve picking: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-9" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Different qty with Job: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-10" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Already exists in Stock Take Doc.: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    ElseIf wsErr = "-11" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Insufficent stock from C to B: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-12" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Insufficent stock from B to A: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-13" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Must specific Bin No: " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-14" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Already upated " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-15" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No Transfer Out Item, cannot transfer In~! " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-16" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " Different Qty from Transfer Out! " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    ElseIf wsErr = "-17" Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " No Active Counting Period at " & wsRtn
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        GoTo cmdSave_Err
                    End If


                    wsDoc = IIf(wsDoc = "", wsRtn, wsDoc & "," & wsRtn)
                    i = i + 1

                End If
            Next
        End If



        cnCon.CommitTrans()

        gsMsg = wsDoc & "已完成!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)


        'Call UnLockAll(wsConnTime, wsFormID)
        Call LoadRecord()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing


        Cursor = System.Windows.Forms.Cursors.Default



        Exit Sub

cmdSave_ItemErr:
        gsMsg = "書本不存在!不能完成!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

        Exit Sub

cmdSave_Err:
        gsMsg = "更新不能完成!"
        MsgBox(gsMsg & " " & Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing



    End Sub

    Private Function InputValidation() As Boolean
        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer
        Dim wlCtr1 As Integer

        InputValidation = False

        On Error GoTo InputValidation_Err



        wiActRow = 0
        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
                    wiActRow = wiActRow + 1
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If
                    wsTrnCd = Trim(waResult.get_Value(wlCtr, SDOCNO))




                End If

            Next wlCtr
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
        'UPGRADE_ISSUE: Form property frmHHIM001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub

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
End Class