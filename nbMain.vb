Option Strict Off
Option Explicit On
Friend Class nbMain
    Inherits System.Windows.Forms.Form
    Private mNode As System.Windows.Forms.TreeNode ' Module-level variable for Nodes'
    Private mItem As System.Windows.Forms.ListViewItem ' Module-level ListItem variable.
    Private EventFlag As Short ' To signal which event has occurred.
    Private sCurrentIndex As String
    Private mStatusBarStyle As Short ' Switches Statusbar style

    Const ROOT As Short = 1 ' For EventFlag, Signals Publisher colmunheader objects.
    Const TITLE As Short = 2 ' EventFlag, signals Title in ListView

    Private Const tcPrev As String = "toolBarPrev"
    Private Const tcNext As String = "toolBarNext"
    Private Const tcOK As String = "toolBarOK"
    Private Const tcCancel As String = "toolBarCancel"
    Private Const tcExit As String = "toolBarExit"

    Dim waFileSub As New System.Data.DataTable
    Dim waMasterSub As New System.Data.DataTable
    Dim waOperationSub As New System.Data.DataTable
    Dim waPOSub As New System.Data.DataTable
    Dim waInventorySub As New System.Data.DataTable
    Dim waACCOUNTSub As New System.Data.DataTable
    Dim waInquirySub As New System.Data.DataTable
    Dim waReportSub As New System.Data.DataTable
    Dim waUtilitySub As New System.Data.DataTable
    Dim waAccRptSub As New System.Data.DataTable
    Dim waListSub As New System.Data.DataTable
    'Dim waFileSub As New XArrayDBObject.XArrayDB
    'Dim waMasterSub As New XArrayDBObject.XArrayDB
    'Dim waOperationSub As New XArrayDBObject.XArrayDB
    'Dim waPOSub As New XArrayDBObject.XArrayDB
    'Dim waInventorySub As New XArrayDBObject.XArrayDB
    'Dim waACCOUNTSub As New XArrayDBObject.XArrayDB
    'Dim waInquirySub As New XArrayDBObject.XArrayDB
    'Dim waReportSub As New XArrayDBObject.XArrayDB
    'Dim waUtilitySub As New XArrayDBObject.XArrayDB
    'Dim waAccRptSub As New XArrayDBObject.XArrayDB
    'Dim waListSub As New XArrayDBObject.XArrayDB


    Dim waScrItm As New System.Data.DataTable
    Private waScrToolTip As New System.Data.DataTable
    'Dim waScrItm As New XArrayDBObject.XArrayDB
    'Private waScrToolTip As New XArrayDBObject.XArrayDB

    Dim wsFormID As String

    Private Sub IniForm()
        Me.KeyPreview = True
        Me.Left = 0
        Me.Top = 0
        Me.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        Me.Height = VB6.TwipsToPixelsY(900)

        wsFormID = "MAIN"

        giCurrIndex = -1

        With tbrMain
            .Items.Item(tcPrev).Enabled = False
            .Items.Item(tcNext).Enabled = False
        End With
    End Sub

    Private Sub ChgPrevPage()
        If giCurrIndex = 0 Then
            tbrMain.Items.Item(tcPrev).Enabled = False
        End If

        If giCurrIndex <> -1 Then

            'Call Call_Pgm(waFileSub, 0, UCase(VB6.GetItemString(cboCommand, giCurrIndex)), 1)
            Call Call_Pgm(waFileSub, 0, Nothing, 1)
            giCurrIndex = giCurrIndex - 1
            tbrMain.Items.Item(tcNext).Enabled = True

        End If
    End Sub

    Private Sub ChgNextPage()
        giCurrIndex = giCurrIndex + 1

        'If giCurrIndex = cboCommand.Items.Count - 1 Then
        '    tbrMain.Items.Item(tcNext).Enabled = False
        'End If

        'If giCurrIndex < cboCommand.Items.Count Then

        '    Call Call_Pgm(waFileSub, 0, UCase(VB6.GetItemString(cboCommand, giCurrIndex)), 1)
        '    tbrMain.Items.Item(tcPrev).Enabled = True

        'End If
    End Sub

    Private Sub Ini_Menu()

        ' First node with 'Root' as text.
        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        Me.Text = Get_Caption(waScrItm, "SCRHDR")
        mnuFile.Text = Get_Caption(waScrItm, "FILE")
        mnuMaster.Text = Get_Caption(waScrItm, "MASTER")
        mnuOperation.Text = Get_Caption(waScrItm, "OPERATION")
        mnuPO.Text = Get_Caption(waScrItm, "PO")
        mnuInventory.Text = Get_Caption(waScrItm, "INVENTORY")
        mnuAccount.Text = Get_Caption(waScrItm, "ACCOUNT")
        mnuInquiry.Text = Get_Caption(waScrItm, "INQUIRY")
        mnuReport.Text = Get_Caption(waScrItm, "REPORT")
        mnuUtility.Text = Get_Caption(waScrItm, "UTILITY")
        mnuACCRPT.Text = Get_Caption(waScrItm, "ACCRPT")
        mnuList.Text = Get_Caption(waScrItm, "LIST")


        tbrMain.Items.Item(tcOK).ToolTipText = Get_Caption(waScrToolTip, tcOK) & "(F10)"
        tbrMain.Items.Item(tcPrev).ToolTipText = Get_Caption(waScrToolTip, tcPrev) & "(F2)"
        tbrMain.Items.Item(tcNext).ToolTipText = Get_Caption(waScrToolTip, tcNext) & "(F3)"
        tbrMain.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrMain.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        Call Ini_PgmMenu(mnuFileSub, "FILE", waFileSub)
        Call Ini_PgmMenu(mnuMasterSub, "MASTER", waMasterSub)
        Call Ini_PgmMenu(mnuOperationSub, "OPERATION", waOperationSub)
        Call Ini_PgmMenu(mnuPOSub, "PO", waPOSub)
        Call Ini_PgmMenu(mnuInventorySub, "INVENTORY", waInventorySub)
        Call Ini_PgmMenu(mnuAccountSub, "ACCOUNT", waACCOUNTSub)
        Call Ini_PgmMenu(mnuInquirySub, "INQUIRY", waInquirySub)
        Call Ini_PgmMenu(mnuReportSub, "REPORT", waReportSub)
        Call Ini_PgmMenu(mnuUtilitySub, "UTILITY", waUtilitySub)
        Call Ini_PgmMenu(mnuACCRPTSub, "ACCRPT", waAccRptSub)
        Call Ini_PgmMenu(mnuListSub, "LIST", waListSub)



        'UPGRADE_WARNING: Lower bound of collection staMain.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        staMain.Items.Item(1).Text = gsComNam

        lvwDB.Columns.Clear()
        lvwDB.Columns.Add("", Get_Caption(waScrItm, "LST01"), CInt(VB6.TwipsToPixelsX(1500)))
        lvwDB.Columns.Add("", Get_Caption(waScrItm, "LST02"), CInt(VB6.TwipsToPixelsX(5000)))
    End Sub

    Private Sub cboCommand_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCommand.Enter
        cboCommand.Focus()
    End Sub

    Private Sub cboCommand_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCommand.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call Call_Pgm(waFileSub, 0, UCase(cboCommand.Text))
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboCommand_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCommand.Leave
        'FocusMe(cboCommand, True)
    End Sub

    'UPGRADE_WARNING: Form event nbMain.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub nbMain_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If Me.WindowState = 0 Then
        '          If My.Application.OpenForms.Count = 1 Then
        '              Me.Left = 0
        '              Me.Top = 0
        '              Me.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        '              Me.Height = VB6.TwipsToPixelsY(9000)
        '          End If
        'End If
    End Sub

    'UPGRADE_WARNING: Form event nbMain.Deactivate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub nbMain_Deactivate(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        If Me.WindowState = 0 Then
            Me.Left = 0
            Me.Top = 0
            Me.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
            Me.Height = VB6.TwipsToPixelsY(1455)
        End If
    End Sub

    Private Sub nbMain_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs)
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode



            Case System.Windows.Forms.Keys.F2


                ChgPrevPage()

            Case System.Windows.Forms.Keys.F3

                ChgNextPage()

            Case System.Windows.Forms.Keys.F10

                'Call Call_Pgm(waFileSub, 0, UCase(cboCommand.Text))

            Case System.Windows.Forms.Keys.F11

                Call cmdCancel()

            Case System.Windows.Forms.Keys.F12

                Me.Close()

        End Select
    End Sub

    Private Sub nbMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Call IniForm()
        Call Ini_Menu()
        'Call Ini_TreeView()

    End Sub


    Private Sub Ini_TreeView()

        ' lvwDB.View = lvwReport

        '= lvwReport
        ' Add three panels, and set Autosize for each

        Dim i As Short

        Dim lStyle As Integer
        lStyle = SendMessage(lvwDB.Handle.ToInt32, LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0)

        lStyle = LVS_EX_FULLROWSELECT
        Call SendMessage(lvwDB.Handle.ToInt32, LVM_SETEXTENDEDLISTVIEWSTYLE, 0, lStyle)



        ' Configure TreeView
        ' tvwDB.Sorted = True
        mNode = tvwDB.Nodes.Add("")
        mNode.Text = gsComNam
        mNode.Tag = Me.Name
        mNode.ImageKey = "closed"
        tvwDB.LabelEdit = False
        EventFlag = 0


        LoadList()
        ' If the Biblio database can't be found, open the
        ' common dialog control to let the user find it.

    End Sub
    Private Sub LoadList()
        ' Declare variables for the Data Access objects.
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset


        Dim intIndex As Object ' Variable for index of current node.
        Dim wsTmp As String

        wsSQL = "select ScrPgmID , min(ScrSeqNo) Seq from sysScrCaption "
        wsSQL = wsSQL & " WHERE ScrType = 'MNU' "
        '  wsSql = wsSql & " AND ScrPgmID <> 'FILE' "
        wsSQL = wsSQL & " AND ScrPgmID <> 'POPUP' "
        wsSQL = wsSQL & " AND ScrType = 'MNU' "
        wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
        wsSQL = wsSQL & " Group By ScrPgmID "
        wsSQL = wsSQL & " Order By Seq "


        'UPGRADE_WARNING: Cannot determine Node location Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="196D987F-2118-46D0-80D2-92FB2909C206"'
        mNode = tvwDB.Nodes.Insert(1, "ROOT", Get_Caption(waScrItm, "ROOT"), "closed")
        mNode.Tag = "Root" ' Identifies the table.
        'UPGRADE_WARNING: Couldn't resolve default property of object intIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        intIndex = mNode.Index

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            rsRcd.MoveFirst()
            Do While Not rsRcd.EOF


                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                wsTmp = Get_Caption(waScrItm, ReadRs(rsRcd, "ScrPgmID"))
                wsTmp = SkipA(wsTmp)
                'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
                mNode = tvwDB.Nodes.Find(intIndex, True)(0).Nodes.Add("")
                mNode.Text = wsTmp
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                mNode.Name = ReadRs(rsRcd, "ScrPgmID") ' Unique ID.
                mNode.Tag = "Item" ' Table name.
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: MSComctlLib.Node property mNode.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
                mNode.ImageKey = ReadRs(rsRcd, "ScrPgmID") ' Image from ImageList.

                rsRcd.MoveNext()
            Loop
        End If


        ' Sort the CardClass nodes.
        '  tvwDB.Nodes(1).Sorted = True
        ' Expand top node.
        'UPGRADE_WARNING: Lower bound of collection tvwDB.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        tvwDB.Nodes.Item(1).Expand()
        'UPGRADE_WARNING: Lower bound of collection tvwDB.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        tvwDB.Nodes.Item(2).Expand()
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

        ' configure statusbar.
        ' CardClassStatusBar
    End Sub

    Private Sub nbMain_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs)
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        Dim sMsg As String
        Dim sSQL As String
        On Error GoTo ErrHand

        sMsg = "Are you sure to exit this system?" & Chr(10) & Chr(10)
        sMsg = sMsg & "請問你是不是肯定退出這系統?"

        If MsgBox(sMsg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, gsTitle) = MsgBoxResult.No Then


            '       sSQL = "DUMP TRANSACTION CHUNGFAIDB WITH NO_LOG"
            '       cnCon.Execute sSQL
            '
            '
            '   Else
            'Cancel = True
        End If

        Exit Sub

ErrHand:
        MsgBox(Err.Description)
        'Cancel = True
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub nbMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs)

        Dim f As System.Windows.Forms.Form

        'For	Each f In My.Application.OpenForms

        '	If f.Name <> Me.Name Then
        '		MsgBox("Please Contact Nbase : Can't Close " & f.Name)
        '		f.Close()
        '		'UPGRADE_NOTE: Object f may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        '		f = Nothing
        '	End If

        'Next f

        Call Disconnect_Database()

        'UPGRADE_NOTE: Object waFileSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waFileSub = Nothing
        'UPGRADE_NOTE: Object waMasterSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waMasterSub = Nothing
        'UPGRADE_NOTE: Object waOperationSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waOperationSub = Nothing
        'UPGRADE_NOTE: Object waPOSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waPOSub = Nothing
        'UPGRADE_NOTE: Object waInventorySub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waInventorySub = Nothing
        'UPGRADE_NOTE: Object waACCOUNTSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waACCOUNTSub = Nothing
        'UPGRADE_NOTE: Object waInquirySub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waInquirySub = Nothing
        'UPGRADE_NOTE: Object waReportSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waReportSub = Nothing
        'UPGRADE_NOTE: Object waUtilitySub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waUtilitySub = Nothing
        'UPGRADE_NOTE: Object waAccRptSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waAccRptSub = Nothing
        'UPGRADE_NOTE: Object waListSub may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waListSub = Nothing
        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object nbMain may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

    End Sub

    Private Sub lvwDB_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs)
        Dim columnheader As System.Windows.Forms.ColumnHeader = lvwDB.Columns(eventArgs.Column)
        If lvwDB.Sorting = System.Windows.Forms.SortOrder.Ascending Then
            lvwDB.Sorting = System.Windows.Forms.SortOrder.Descending
        Else
            lvwDB.Sorting = System.Windows.Forms.SortOrder.Ascending
        End If
        'UPGRADE_ISSUE: MSComctlLib.ListView property lvwDB.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'lvwDB.SortKey = columnheader.Index - 1
        ' Set Sorted to True to sort the list.
        lvwDB.Sort()

    End Sub

    Private Sub lvwDB_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        Dim wsFName As String

        If lvwDB.Items.Count = 0 Then
            Exit Sub
        End If

        If lvwDB.FocusedItem Is Nothing Then
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wsFName = lvwDB.FocusedItem.Text

        Call Call_Pgm(waFileSub, 0, UCase(wsFName))



        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property nbMain.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub




    Private Sub lvwDB_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            lvwDB_DoubleClick(lvwDB, New System.EventArgs())


        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub lvwDB_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim i As Object
        For i = 1 To lvwDB.Items.Count
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Lower bound of collection lvwDB.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            lvwDB.Items.Item(i).Selected = False
        Next i

    End Sub


    Public Sub mnuACCRPTSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = mnuACCRPTSub.GetIndex(eventSender)
        Call Call_Pgm(waAccRptSub, Index)
    End Sub

    Public Sub mnuListSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = mnuListSub.GetIndex(eventSender)
        Call Call_Pgm(waListSub, Index)
    End Sub

    Public Sub mnuFileSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = mnuFileSub.GetIndex(eventSender)
        Call Call_Pgm(waFileSub, Index)
    End Sub

    Public Sub mnuMasterSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = mnuMasterSub.GetIndex(eventSender)
        Call Call_Pgm(waMasterSub, Index)
    End Sub

    Public Sub mnuOperationSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = mnuOperationSub.GetIndex(eventSender)
        Call Call_Pgm(waOperationSub, Index)
    End Sub

    Public Sub mnuInventorySub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Index As Short = mnuInventorySub.GetIndex(eventSender)
        Call Call_Pgm(waInventorySub, Index)
    End Sub
    Public Sub mnuinquirySub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInquirySub.Click
        Dim Index As Short = mnuInquirySub.GetIndex(eventSender)
        Call Call_Pgm(waInquirySub, Index)
    End Sub



    Public Sub mnuPOSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPOSub.Click
        Dim Index As Short = mnuPOSub.GetIndex(eventSender)
        Call Call_Pgm(waPOSub, Index)
    End Sub

    Public Sub mnureportSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReportSub.Click
        Dim Index As Short = mnuReportSub.GetIndex(eventSender)
        Call Call_Pgm(waReportSub, Index)
    End Sub

    Public Sub mnuACCOUNTSub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAccountSub.Click
        Dim Index As Short = mnuAccountSub.GetIndex(eventSender)
        Call Call_Pgm(waACCOUNTSub, Index)
    End Sub

    Public Sub mnuutilitySub_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUtilitySub.Click
        Dim Index As Short = mnuUtilitySub.GetIndex(eventSender)
        Call Call_Pgm(waUtilitySub, Index)
    End Sub


    Private Sub tbrMain_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrMain_Button9.Click, toolBarCancel.Click, toolBarOK.Click, _tbrMain_Button4.Click, toolBarNext.Click, toolBarPrev.Click, toolBarExit.Click, _tbrMain_Button1.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case tcPrev

                If tbrMain.Items.Item(tcPrev).Enabled = True Then

                    ChgPrevPage()

                End If

            Case tcNext

                If tbrMain.Items.Item(tcNext).Enabled = True Then

                    ChgNextPage()

                End If

            Case tcOK

                'Call Call_Pgm(waFileSub, 0, UCase(cboCommand.Text))
                Call Call_Pgm(waFileSub, 0, Nothing)

            Case tcCancel

                Call cmdCancel()

            Case tcExit


                Me.Close()

        End Select
    End Sub

    Private Sub cmdCancel()
        Dim giFormIndex As Object

        'cboCommand.Items.Clear()
        'cboCommand.Text = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object giFormIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        giFormIndex = 0
        With tbrMain
            .Items.Item(tcPrev).Enabled = False
            .Items.Item(tcNext).Enabled = False
        End With

    End Sub


    Private Sub tvwDB_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvwDB.AfterCollapse
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        If Node.Tag = "Root" Or Node.Index = 1 Then Node.ImageKey = "closed"
    End Sub

    Private Sub tvwDB_AfterExpand(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvwDB.AfterExpand
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        If Node.Tag = "Root" Or Node.Index = 1 Then
            Node.ImageKey = "open"
            '   Node.Sorted = True
        End If



    End Sub




    Private Sub GetItem(ByRef ITMID As Object, ByVal inArray As XArrayDBObject.XArrayDB, ByVal sImage As String)

        Dim wiCtr As Short
        ' Show Progress bar
        ' Clear the old titles
        lvwDB.Items.Clear()



        For wiCtr = 0 To inArray.get_UpperBound(1)

            If inArray.get_Value(wiCtr, 2) = "Y" And inArray.get_Value(wiCtr, 1) <> "-" Then

                'UPGRADE_WARNING: Lower bound of collection lvwDB.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                mItem = lvwDB.Items.Add(inArray.get_Value(wiCtr, 0), sImage)

                'UPGRADE_WARNING: Lower bound of collection mItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If mItem.SubItems.Count > 1 Then
                    mItem.SubItems(1).Text = SkipA(inArray.get_Value(wiCtr, 1))
                Else
                    mItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, SkipA(inArray.get_Value(wiCtr, 1))))
                End If
            End If

        Next wiCtr


        'UPGRADE_WARNING: Couldn't resolve default property of object ITMID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sCurrentIndex = ITMID

    End Sub


    Private Sub tvwDB_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwDB.NodeMouseClick
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        ' Check the Tag for "Publisher" and EventFlag
        ' variable to see if the ColumnHeaders
        ' have already been created. If not, then
        ' invoke the MakeColumns procedure.

        ' If the Tag is "Publisher" and the mItemCurrentIndex
        ' index isn't the same as the Node.key, then
        ' incoke the GetItem procedure.
        If Node.Tag = "Item" And sCurrentIndex <> Node.Name Then

            Select Case Node.Name
                Case "FILE"
                    GetItem((Node.Name), waFileSub, Node.Name)
                Case "MASTER"
                    GetItem((Node.Name), waMasterSub, Node.Name)
                Case "OPERATION"
                    GetItem((Node.Name), waOperationSub, Node.Name)
                Case "PO"
                    GetItem((Node.Name), waPOSub, Node.Name)
                Case "INVENTORY"
                    GetItem((Node.Name), waInventorySub, Node.Name)
                Case "ACCOUNT"
                    GetItem((Node.Name), waACCOUNTSub, Node.Name)
                Case "INQUIRY"
                    GetItem((Node.Name), waInquirySub, Node.Name)
                Case "REPORT"
                    GetItem((Node.Name), waReportSub, Node.Name)
                Case "UTILITY"
                    GetItem((Node.Name), waUtilitySub, Node.Name)
                Case "ACCRPT"
                    GetItem((Node.Name), waAccRptSub, Node.Name)
                Case "LIST"
                    GetItem((Node.Name), waListSub, Node.Name)

            End Select
        End If

    End Sub

    Private Sub FindInList()
        Dim txtOutput As Object ' FindItem method.

        Dim intSelectedOption As Short
        Dim strFindMe As String

        'UPGRADE_WARNING: Couldn't resolve default property of object txtOutput.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        strFindMe = txtOutput.Text

        'intSelectedOption = MSComctlLib.ListFindItemWhereConstants.lvwText

        'lvwSubitem
        'lvwText

        mItem = lvwDB.FindItemWithText(strFindMe, True, 0, True)
        If mItem Is Nothing Then ' If no match, inform user and exit.
            '  MsgBox "No match found"
            Exit Sub
        Else
            'UPGRADE_WARNING: MSComctlLib.ListItem method mItem.EnsureVisible has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
            mItem.EnsureVisible() ' Scroll ListView to show found ListItem.
            mItem.Selected = True ' Select the ListItem.
            lvwDB.Focus()
        End If

    End Sub



    Private Sub LoadForm(ByRef f As System.Windows.Forms.Form)
        f.WindowState = System.Windows.Forms.FormWindowState.Normal
        f.SetBounds(0, VB6.TwipsToPixelsY(500), VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width)), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.ClientRectangle.Height)))
        f.Show()
        'UPGRADE_WARNING: Form method f.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        f.BringToFront()

    End Sub


    Private Sub Call_Pgm(ByVal inArray As XArrayDBObject.XArrayDB, ByRef inPgmIdx As Short, Optional ByRef inPgmName As Object = Nothing, Optional ByRef inNotAdd As Object = Nothing)

        Dim newForm As System.Windows.Forms.Form
        Dim wsFName As String

        On Error GoTo Err_Handler

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inPgmName) Then
            wsFName = inArray.get_Value(inPgmIdx, 0)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object inPgmName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wsFName = inPgmName
        End If


        If Chk_PgmExist(wsFName) = False Then
            gsMsg = "畫面不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboCommand.Focus()
            Exit Sub
        End If


        If Chk_UserRight(gsUserID, UCase(wsFName)) = False Then
            gsMsg = "使用者權限不足!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboCommand.Focus()
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


        Select Case wsFName
            Case "EXIT"
                Me.Close()

            Case "CMP001"
                newForm = New frmCMP001
                newForm.ShowDialog()

            Case "SYS001"
                newForm = New frmSYS001
                newForm.ShowDialog()

            Case "SYS002"
                newForm = New frmSYS002
                newForm.Show()

            Case "WS001"
                newForm = New frmWS001
                newForm.ShowDialog()

            Case "VOU001"
                newForm = New frmVOU001
                newForm.Show()


            Case "OPN001"
                newForm = New frmOPN001
                newForm.ShowDialog()

            Case "OPN002"
                newForm = New frmOPN002
                newForm.ShowDialog()

            Case "UC001"
                newForm = New frmUC001
                newForm.ShowDialog()


                ''''
            Case "C001"
                newForm = New frmC001
                newForm.Show()

            Case "V001"
                newForm = New frmV001
                newForm.Show()

            Case "SLM001"
                newForm = New frmSLM001
                newForm.Show()

            Case "STF001"
                newForm = New frmSTF001
                newForm.Show()


            Case "ITM001"
                newForm = New frmITM001
                newForm.Show()



            Case "PYT001"
                newForm = New frmPYT001
                newForm.Show()

            Case "PR001"
                newForm = New frmPR001
                newForm.Show()

            Case "EXC001"
                newForm = New frmEXC001
                newForm.Show()

            Case "UOM001"
                newForm = New frmUOM001
                newForm.Show()

            Case "IP001"
                newForm = New frmIP001
                newForm.Show()

            Case "SHP001"
                newForm = New frmSHP001
                newForm.Show()

            Case "RMK001"
                newForm = New frmRmk001
                newForm.Show()

            Case "WH001"
                newForm = New frmWH001
                newForm.Show()

            Case "IT001"
                newForm = New frmIT001
                newForm.Show()

            Case "PT001"
                newForm = New frmPT001
                newForm.Show()

            Case "RGN001"
                newForm = New frmRGN001
                newForm.Show()


            Case "COA001"
                newForm = New frmCOA001
                newForm.Show()

            Case "ML001"
                newForm = New frmML001
                newForm.Show()

            Case "M001"
                newForm = New frmM001
                newForm.Show()

            Case "N001"
                newForm = New frmN001
                newForm.Show()

            Case "TERR001"
                newForm = New frmTerr001
                newForm.Show()


            Case "SHP001"
                newForm = New frmSHP001
                newForm.Show()

            Case "AT001"
                newForm = New frmAT001
                newForm.Show()

            Case "CAT001"
                newForm = New frmCAT001
                newForm.Show()

                ''''
            Case "SN001"
                newForm = New frmSN001
                newForm.Show()

            Case "SO001"
                newForm = New frmSO001
                newForm.Show()


            Case "VQ001"
                newForm = New frmVQ001
                newForm.Show()


                ''     Case "SPL001"
                ''     Set newForm = New frmSPL001
                ''       newForm.Show

            Case "SDN001"
                newForm = New frmSDN001
                newForm.Show()

            Case "INV001"
                newForm = New frmINV001
                newForm.Show()


            Case "APR001"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.FormID = "APR001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.TrnCd = "SN"
                    .Show()
                End With


            Case "APR002"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.FormID = "APR002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.TrnCd = "SO"
                    .Show()
                End With

            Case "APR003"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.FormID = "APR003"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.TrnCd = "SP"
                    .Show()
                End With

            Case "APR004"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.FormID = "APR004"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    ''.TrnCd = "SD"
                    .Show()
                End With

            Case "APR005"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APR005"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "IV"
                    .Show()
                End With


            Case "APR006"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APR006"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SW"
                    .Show()
                End With

            Case "APR007"
                newForm = New frmAPR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APR007"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "VQ"
                    .Show()
                End With

            Case "APW001"
                newForm = New frmAPW001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APW001"
                    .Show()
                End With


                '''' Purchase Order

            Case "MRP001"
                newForm = New frmMRP001
                newForm.Show()

            Case "MRP002"
                newForm = New frmMRP002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "MRP002"
                    .Show()
                End With

            Case "PO001"
                newForm = New frmPO001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "PO001"
                    .Show()
                End With

            Case "PN001"
                newForm = New frmPO001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "PN001"
                    .Show()
                End With

            Case "PGV001"
                newForm = New frmPGV001
                newForm.Show()

            Case "GRV001"
                newForm = New frmGRV001
                newForm.Show()


            Case "PGR001"
                newForm = New frmPGR001
                newForm.Show()

            Case "APV001"
                newForm = New frmAPV001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APV001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PO"
                    .Show()
                End With

            Case "APP001"
                newForm = New frmAPP001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APP001"
                    .Show()
                End With


            Case "APV002"
                newForm = New frmAPV001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APV002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PV"
                    .Show()
                End With

            Case "APV003"
                newForm = New frmAPV001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APV003"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PR"
                    .Show()
                End With


            Case "APV004"
                newForm = New frmAPV001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APV004"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "GR"
                    .Show()
                End With

                ''''''''''''Inventory


            Case "TRF001"
                newForm = New frmTRF001
                newForm.Show()

            Case "ADJ001"
                newForm = New frmADJ001
                newForm.Show()

            Case "SAM001"
                newForm = New frmSAM001
                newForm.Show()

            Case "DAM001"
                newForm = New frmDAM001
                newForm.Show()

            Case "SKT001"
                newForm = New frmSKT001
                newForm.Show()

            Case "SCT001"
                newForm = New frmSCT001
                newForm.Show()


            Case "APS001"
                newForm = New frmAPS001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APS001"
                    .Show()
                End With

                ''''''''''''

            Case "USR001"
                newForm = New frmUSR001
                newForm.Show()


            Case "CHGPWD"
                newForm = New frmCHGPWD
                newForm.ShowDialog()


            Case "USRRHT"
                newForm = New frmUSRRHT
                newForm.ShowDialog()

            Case "PURGE"
                newForm = New frmPURGE
                newForm.ShowDialog()

            Case "HHIM001"
                newForm = New frmHHIM001
                newForm.ShowDialog()


                '-----------AR

            Case "AR001"
                newForm = New frmAR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "AR001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "62"
                    .Show()
                End With

            Case "ARDN001"
                newForm = New frmAR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "ARDN001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "61"
                    .Show()
                End With

            Case "ARCN001"
                newForm = New frmAR001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "ARCN001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "60"
                    .Show()
                End With

            Case "AR002"
                newForm = New frmAR002
                newForm.Show()

            Case "AR003"
                newForm = New frmAR003
                newForm.Show()

            Case "AR003"
                newForm = New frmAR003
                newForm.Show()

            Case "AR100"
                newForm = New frmAR100
                newForm.Show()

            Case "AR101"
                newForm = New frmAR101
                newForm.Show()

            Case "ARPE000"
                newForm = New frmARPE000
                newForm.Show()

                '-----------AP

            Case "AP001"
                newForm = New frmAP001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "AP001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "20"
                    .Show()
                End With

            Case "APCN001"
                newForm = New frmAP001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "APCN001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "21"
                    .Show()
                End With

            Case "AP002"
                newForm = New frmAP002
                newForm.Show()

            Case "AP003"
                newForm = New frmAP003
                newForm.Show()

            Case "AP003"
                newForm = New frmAP003
                newForm.Show()

            Case "AP100"
                newForm = New frmAP100
                newForm.Show()

            Case "AP101"
                newForm = New frmAP101
                newForm.Show()

            Case "SIGN002"
                newForm = New frmSIGN002
                newForm.Show()

                '-----------GL

            Case "GL001"
                newForm = New frmGL001
                newForm.Show()

            Case "GL002"
                newForm = New frmGL002
                newForm.Show()

                '----------Acc Prt

            Case "VOU002"
                newForm = New frmVOU002
                newForm.ShowDialog()

            Case "COA002"
                newForm = New frmCOA002
                newForm.ShowDialog()


                '-----------

            Case "ARL001"
                newForm = New frmARL001
                newForm.ShowDialog()

            Case "ARL002"
                newForm = New frmARL002
                newForm.ShowDialog()

            Case "ARL003"
                newForm = New frmARL003
                newForm.ShowDialog()

            Case "ARL004"
                newForm = New frmARL004
                newForm.ShowDialog()

            Case "ARL005"
                newForm = New frmARL005
                newForm.ShowDialog()

            Case "ARL006"
                newForm = New frmARL006
                newForm.ShowDialog()

            Case "ARL007"
                newForm = New frmARL007
                newForm.ShowDialog()

            Case "ARL008"
                newForm = New frmARL008
                newForm.ShowDialog()

            Case "ARL009"
                newForm = New frmARL009
                newForm.ShowDialog()

            Case "ARL010"
                newForm = New frmARL010
                newForm.ShowDialog()

            Case "ARL011"
                newForm = New frmARL011
                newForm.ShowDialog()

            Case "ARL012"
                newForm = New frmARL012
                newForm.ShowDialog()
                '-----------

            Case "APL001"
                newForm = New frmAPL001
                newForm.ShowDialog()

            Case "APL002"
                newForm = New frmAPL002
                newForm.ShowDialog()

            Case "APL003"
                newForm = New frmAPL003
                newForm.ShowDialog()

            Case "APL004"
                newForm = New frmAPL004
                newForm.ShowDialog()

            Case "APL005"
                newForm = New frmAPL005
                newForm.ShowDialog()

            Case "APL006"
                newForm = New frmAPL006
                newForm.ShowDialog()

            Case "APL007"
                newForm = New frmAPL007
                newForm.ShowDialog()

            Case "APL008"
                newForm = New frmAPL008
                newForm.ShowDialog()

            Case "APL009"
                newForm = New frmAPL009
                newForm.ShowDialog()

            Case "APL010"
                newForm = New frmAPL010
                newForm.ShowDialog()

                '-----------------------
            Case "GLP001"
                newForm = New frmGLP001
                newForm.ShowDialog()

            Case "GLP002"
                newForm = New frmGLP002
                newForm.ShowDialog()

            Case "GLP003"
                newForm = New frmGLP003
                newForm.ShowDialog()

            Case "GLP004"
                newForm = New frmGLP004
                newForm.ShowDialog()

            Case "GLP005"
                newForm = New frmGLP005
                newForm.ShowDialog()

            Case "GLP006"
                newForm = New frmGLP006
                newForm.ShowDialog()
                ''' Job Cost


                '       Case "CST001"
                '           Set newForm = New frmCST001
                '           newForm.Show

                '       Case "CT001"
                '           Set newForm = New frmCT001
                '           newForm.Show

                ''' Reporting

            Case "SN002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "SN002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SN"
                    .Show()
                End With


            Case "SN002D"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "SN002D"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SN"
                    .Show()
                End With

            Case "SO002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "SO002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SO"
                    .Show()
                End With


            Case "SO002D"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "SO002D"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SO"
                    .Show()
                End With

            Case "SPL002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "SPL002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SP"
                    .Show()
                End With


            Case "SDN002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "SDN002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SD"
                    .Show()
                End With


            Case "INV002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "INV002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "IV"
                    .Show()
                End With

            Case "PO002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "PO002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PO"
                    .Show()
                End With

            Case "PGV002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "PGV002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PV"
                    .Show()
                End With

            Case "GRV002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "GRV002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "GR"
                    .Show()
                End With


            Case "PGR002"
                newForm = New frmSN002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "PGR002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PR"
                    .Show()
                End With

                ''''''''''''''''''
            Case "JOB001"
                newForm = New frmJOB002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "JOB001"
                    .Show()
                End With


            Case "JOB002"
                newForm = New frmJOB002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "JOB002"
                    .Show()
                End With


            Case "JOB003"
                newForm = New frmJOB002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "JOB003"
                    .Show()
                End With


            Case "JOB004"
                newForm = New frmJOB002
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "JOB004"
                    .Show()
                End With

                ' Case "SOP000B"
                '     Set newForm = New frmSOP000B
                '     newForm.Show

            Case "SIGN001"
                newForm = New frmSIGN001
                newForm.Show()

            Case "ITM002"
                newForm = New frmITM002
                newForm.Show()

                ''''' Sales Report

            Case "SOP000"
                newForm = New frmSOP000
                newForm.Show()

            Case "SOP003"
                newForm = New frmSOP003
                newForm.Show()

            Case "SOP004"
                newForm = New frmSOP004
                newForm.Show()

            Case "SOP006"
                newForm = New frmSOP006
                newForm.Show()

            Case "SOP008"
                newForm = New frmSOP008
                newForm.Show()

            Case "SOP010"
                newForm = New frmSOP010
                newForm.Show()

            Case "SOP020"
                newForm = New frmSOP020
                newForm.Show()

            Case "SOP030"
                newForm = New frmSOP030
                newForm.Show()

            Case "ICP001"
                newForm = New frmICP001
                newForm.Show()

            Case "ICP002"
                newForm = New frmICP002
                newForm.Show()

            Case "ICP003"
                newForm = New frmICP003
                newForm.Show()

            Case "ICP004"
                newForm = New frmICP004
                newForm.Show()

            Case "ICP005"
                newForm = New frmICP005
                newForm.Show()

            Case "ICP006"
                newForm = New frmICP006
                newForm.Show()

                '''' Inquiry

            Case "INQ001"
                newForm = New frmINQ001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "INQ001"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SO"
                    .Show()
                End With

            Case "INQ002"
                newForm = New frmINQ001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "INQ002"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "IV"
                    .Show()
                End With


            Case "INQ003"
                newForm = New frmINQ003
                newForm.Show()

            Case "INQ004"
                newForm = New frmINQ001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "INQ004"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PO"
                    .Show()
                End With

            Case "INQ005"
                newForm = New frmINQ001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "INQ005"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "PV"
                    .Show()
                End With


            Case "INQ006"
                newForm = New frmINQ006
                newForm.Show()

            Case "INQ007"
                newForm = New frmINQ007
                newForm.Show()

            Case "INQ008"
                newForm = New frmINQ008
                newForm.Show()

            Case "INQ009"
                newForm = New frmINQ009
                newForm.Show()

            Case "INQ010"
                newForm = New frmINQ010
                newForm.Show()

            Case "INQ011"
                newForm = New frmINQ001
                With newForm
                    'UPGRADE_ISSUE: Control FormID could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.FormID = "INQ011"
                    'UPGRADE_ISSUE: Control TrnCd could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '.TrnCd = "SN"
                    .Show()
                End With

            Case "INQ012"
                newForm = New frmINQ012
                newForm.Show()

            Case "INQ013"
                newForm = New frmINQ013
                newForm.Show()

            Case "STKCNT"
                newForm = New frmSTKCNT
                newForm.Show()

                '''' Master Listing
            Case "AT002"
                newForm = New frmAT002
                newForm.Show()

            Case "C002"
                newForm = New frmC002
                newForm.Show()

            Case "COA002"
                newForm = New frmCOA002
                newForm.Show()

            Case "EXC002"
                newForm = New frmEXC002
                newForm.Show()

            Case "IP0022"
                newForm = New frmIP0022
                newForm.Show()

            Case "IT002"
                newForm = New frmIT002
                newForm.Show()

            Case "ML002"
                newForm = New frmML002
                newForm.Show()

            Case "PR002"
                newForm = New frmPR002
                newForm.Show()

            Case "PT002"
                newForm = New frmPT002
                newForm.Show()

            Case "PYT002"
                newForm = New frmPYT002
                newForm.Show()

            Case "RMK002"
                newForm = New frmRMK002
                newForm.Show()

            Case "SHP002"
                newForm = New frmSHP002
                newForm.Show()

            Case "SLM002"
                newForm = New frmSLM002
                newForm.Show()

            Case "STF002"
                newForm = New frmSTF002
                newForm.Show()

            Case "UOM002"
                newForm = New frmUOM002
                newForm.Show()

            Case "USR002"
                newForm = New frmUSR002
                newForm.Show()

            Case "V002"
                newForm = New frmV002
                newForm.Show()

            Case "WH002"
                newForm = New frmWH002
                newForm.Show()

            Case Else
                'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
                'UPGRADE_ISSUE: Form property nbMain.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
                Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
                Exit Sub

        End Select


        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inNotAdd) Then
            'cboCommand.Items.Add(wsFName)
            tbrMain.Items.Item(tcPrev).Enabled = True
            giCurrIndex = giCurrIndex + 1
        End If

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property nbMain.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

        Exit Sub

Err_Handler:

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property nbMain.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal


    End Sub
End Class