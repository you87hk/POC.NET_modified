Option Strict Off
Option Explicit On
Friend Class frmSTKCNT
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
	
	
	Private Const tcOK As String = "OK"
	Private Const tcPrint As String = "Print"
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	Private Const SSEL As Short = 0
	Private Const SITMCODE As Short = 1
	Private Const SITMNAME As Short = 2
	Private Const SWHSCODE As Short = 3
	Private Const SLOTNO As Short = 4
	Private Const SSOH As Short = 5
	Private Const SCOUNTED As Short = 6
	Private Const SQTYDIFF As Short = 7
	Private Const SDUMMY As Short = 8
	Private Const SID As Short = 9
	
	
	
	Private Sub cboItmBarCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		wsSQL = "SELECT SCHDDOCNO, SCHDDOCDATE "
		wsSQL = wsSQL & " FROM ICSTKCNT "
		wsSQL = wsSQL & " WHERE SCHDDOCNO LIKE '%" & IIf(cboItmBarCodeFr.SelectionLength > 0, "", Set_Quote(cboItmBarCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " AND SCHDSTATUS IN ('1','4') "
		wsSQL = wsSQL & " AND SCHDTRNCODE  = 'SC' "
		wsSQL = wsSQL & " ORDER BY SCHDDOCNO "
		
		
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmBarCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmBarCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmBarCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmBarCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboItmBarCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeFr.Enter
		FocusMe(cboItmBarCodeFr)
		wcCombo = cboItmBarCodeFr
	End Sub
	
	Private Sub cboItmBarCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmBarCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmBarCodeFr, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboItmBarCodeFr.Text) <> "" And Trim(cboItmBarCodeTo.Text) = "" Then
                cboItmBarCodeTo.Text = cboItmBarCodeFr.Text
            End If
            cboItmBarCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub cboItmBarCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeFr.Leave
        FocusMe(cboItmBarCodeFr, True)
    End Sub

    Private Sub cboItmBarCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


        wsSQL = "SELECT SCHDDOCNO, SCHDDOCDATE "
        wsSQL = wsSQL & " FROM ICSTKCNT "
        wsSQL = wsSQL & " WHERE SCHDDOCNO LIKE '%" & IIf(cboItmBarCodeTo.SelectionLength > 0, "", Set_Quote(cboItmBarCodeTo.Text)) & "%' "
        wsSQL = wsSQL & " AND SCHDSTATUS IN ('1','4') "
        wsSQL = wsSQL & " AND SCHDTRNCODE  = 'SC' "
        wsSQL = wsSQL & " ORDER BY SCHDDOCNO "

        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmBarCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmBarCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmBarCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmBarCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboItmBarCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeTo.Enter
        FocusMe(cboItmBarCodeTo)
        wcCombo = cboItmBarCodeTo
    End Sub

    Private Sub cboItmBarCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmBarCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmBarCodeTo, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmBarCodeTo = False Then
                GoTo EventExitSub
            End If

            cboWhsCodeFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub



    Private Sub cboItmBarCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeTo.Leave
        FocusMe(cboItmBarCodeTo, True)
    End Sub








    'UPGRADE_WARNING: Event frmSTKCNT.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmSTKCNT_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub



    Private Sub cboItmCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCodeFr

        wsSQL = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " "
        wsSQL = wsSQL & " FROM mstItem "
        wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
        wsSQL = wsSQL & " AND ItmSTATUS = '1' "
        wsSQL = wsSQL & " ORDER BY ItmCode "
        Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboItmCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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

        wsSQL = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " "
        wsSQL = wsSQL & " FROM mstItem "
        wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
        wsSQL = wsSQL & " AND ItmSTATUS = '1' "
        wsSQL = wsSQL & " ORDER BY ItmCode "
        Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboItmCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
                Call cboItmCodeTo_Enter(cboItmCodeTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            cboItmBarCodeFr.Focus()


        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Leave
        FocusMe(cboItmCodeTo, True)
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

    Private Function chk_cboItmBarCodeTo() As Boolean
        chk_cboItmBarCodeTo = False

        If UCase(cboItmBarCodeFr.Text) > UCase(cboItmBarCodeTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboItmBarCodeTo.Focus()
            Exit Function
        End If

        chk_cboItmBarCodeTo = True
    End Function



    Private Sub cboWhsCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboWhsCodeFr

        wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
        wsSQL = wsSQL & " WHERE WhsStatus = '1'"
        wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeFr.SelectionLength > 0, "", Set_Quote(cboWhsCodeFr.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY WhsCode "

        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboWhsCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboWhsCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboWhsCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboWhsCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Enter
        FocusMe(cboWhsCodeFr)
        wcCombo = cboWhsCodeFr
    End Sub

    Private Sub cboWhsCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboWhsCodeFr, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboWhsCodeFr.Text) <> "" And Trim(cboWhsCodeTo.Text) = "" Then
                cboWhsCodeTo.Text = cboWhsCodeFr.Text
            End If
            cboWhsCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboWhsCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Leave
        FocusMe(cboWhsCodeFr, True)
    End Sub

    Private Sub cboWhsCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboWhsCodeTo

        wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
        wsSQL = wsSQL & " WHERE WhsStatus = '1'"
        wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeTo.SelectionLength > 0, "", Set_Quote(cboWhsCodeTo.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY WhsCode "
        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboWhsCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboWhsCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboWhsCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboWhsCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.Enter
        FocusMe(cboWhsCodeTo)
        wcCombo = cboWhsCodeTo
    End Sub

    Private Sub cboWhsCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboWhsCodeTo, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboWhsCodeTo = False Then
                Call cboWhsCodeTo_Enter(cboWhsCodeTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            Call Opt_Setfocus(optShow, 2, 0)


        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboWhsCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.Leave
        FocusMe(cboWhsCodeTo, True)
    End Sub
    Private Function chk_cboWhsCodeTo() As Boolean
        chk_cboWhsCodeTo = False

        If UCase(cboWhsCodeFr.Text) > UCase(cboWhsCodeTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboWhsCodeTo = True
    End Function


    Private Sub frmSTKCNT_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F6
                Call cmdSave(1)

            Case System.Windows.Forms.Keys.F11
                Call cmdPrint()

            Case System.Windows.Forms.Keys.F3
                Call cmdCancel()

            Case System.Windows.Forms.Keys.F12
                Me.Close()

            Case System.Windows.Forms.Keys.F9
                Call cmdSelect(1)

            Case System.Windows.Forms.Keys.F10
                Call cmdSelect(0)

            Case System.Windows.Forms.Keys.F5
                Call LoadRecord()


        End Select
    End Sub

    Private Sub frmSTKCNT_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


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

        For Each MyControl In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            Select Case TypeName(MyControl)
                Case "ComboBox"
                    'UPGRADE_WARNING: Couldn't resolve default property of object MyControl.Clear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.Clear()
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

        optShow(0).Checked = True



    End Sub

    Private Sub frmSTKCNT_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmSTKCNT may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing


    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "STKCNT"
    End Sub

    Private Sub Ini_Caption()
        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblItmCodeFr.Text = Get_Caption(waScrItm, "ItmCodeFR")
        lblItmCodeTo.Text = Get_Caption(waScrItm, "ItmCodeTO")
        lblItmBarCodeFr.Text = Get_Caption(waScrItm, "ItmBarCodeFR")
        lblItmBarCodeTo.Text = Get_Caption(waScrItm, "ItmBarCodeTO")
        lblWhsCodeFr.Text = Get_Caption(waScrItm, "WhsCodeFR")
        lblWhsCodeTo.Text = Get_Caption(waScrItm, "WhsCodeTO")


        optShow(0).Text = Get_Caption(waScrItm, "SHOW0")
        optShow(1).Text = Get_Caption(waScrItm, "SHOW1")




        With tblDetail
            .Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
            .Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SItmCode")
            .Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SItmNAME")
            .Columns(SWHSCODE).Caption = Get_Caption(waScrItm, "SWHSCODE")
            .Columns(SCOUNTED).Caption = Get_Caption(waScrItm, "SCOUNTED")
            .Columns(SSOH).Caption = Get_Caption(waScrItm, "SSOH")
            .Columns(SLOTNO).Caption = Get_Caption(waScrItm, "SLOTNO")
            .Columns(SQTYDIFF).Caption = Get_Caption(waScrItm, "SQTYDIFF")

        End With




        tbrProcess.Items.Item(tcOK).ToolTipText = Get_Caption(waScrToolTip, tcOK) & "(F6)"
        tbrProcess.Items.Item(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint) & "(F11)"

        tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F5)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F3)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
        tbrProcess.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrToolTip, tcSAll) & "(F9)"
        tbrProcess.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrToolTip, tcDAll) & "(F10)"



    End Sub













    Private Sub optShow_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optShow.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optShow.GetIndex(eventSender)
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
	
	
	
	
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		Dim wlRet As Short
		Dim wlRow As Integer
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				
				
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						Case SQTYDIFF
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
                        Case SQTYDIFF
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

                    Case SITMCODE
                        lblDspItmDesc.Text = ""
                        lblDspItmDesc.Text = .Columns(SITMNAME).Text

                    Case SITMNAME
                        lblDspItmDesc.Text = ""
                        lblDspItmDesc.Text = .Columns(SITMNAME).Text




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
            Case tcOK
                Call cmdSave(1)

            Case tcPrint

                Call cmdPrint()

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
						.Columns(wiCtr).Visible = False
					Case SITMCODE
						.Columns(wiCtr).DataWidth = 30
						.Columns(wiCtr).Width = 1500
					Case SITMNAME
						.Columns(wiCtr).DataWidth = 50
						.Columns(wiCtr).Width = 3500
					Case SWHSCODE
						.Columns(wiCtr).DataWidth = 10
						.Columns(wiCtr).Width = 1200
					Case SSOH
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
					Case SCOUNTED
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
					Case SLOTNO
						.Columns(wiCtr).Width = 1200
						.Columns(wiCtr).DataWidth = 20
					Case SQTYDIFF
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsQtyFmt
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
		Dim adcmdSave As New ADODB.Command
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsDteTim As String
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		wsDteTim = CStr(Now)
		wsDteTim = Change_SQLDate(wsDteTim)
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		
		adcmdSave.CommandText = "USP_RPTSTKCNT"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, gsUserID)
		Call SetSPPara(adcmdSave, 2, Change_SQLDate(wsDteTim))
		Call SetSPPara(adcmdSave, 3, "盤點數目報表")
		Call SetSPPara(adcmdSave, 4, Opt_Getfocus(optShow, 2, 0))
		Call SetSPPara(adcmdSave, 5, cboItmCodeFr)
		Call SetSPPara(adcmdSave, 6, IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), cboItmCodeTo.Text))
		Call SetSPPara(adcmdSave, 7, cboItmBarCodeFr)
		Call SetSPPara(adcmdSave, 8, IIf(Trim(cboItmBarCodeTo.Text) = "", New String("z", 13), cboItmBarCodeTo.Text))
		Call SetSPPara(adcmdSave, 9, cboWhsCodeFr)
		Call SetSPPara(adcmdSave, 10, IIf(Trim(cboWhsCodeTo.Text) = "", New String("z", 10), cboWhsCodeTo.Text))
		Call SetSPPara(adcmdSave, 11, gsLangID)
		
		adcmdSave.Execute()
		
		
		cnCon.CommitTrans()
		
		wsSQL = "SELECT RPTITMID, RPTITMCODE, RPTITMNAM , RPTBARCODE, RPTSOH, RPTCOUNTED, RPTWHSCODE, RPTLOTNO, "
		wsSQL = wsSQL & " RPTQTYDIFF "
		wsSQL = wsSQL & " FROM RPTSTKCNT "
		wsSQL = wsSQL & " WHERE RPTDTETIM = '" & wsDteTim & "' "
		wsSQL = wsSQL & " AND RPTUSRID = '" & gsUserID & "' "
		
		If optShow(1).Checked = True Then
			wsSQL = wsSQL & " AND RPTSTKFLG = 'Y' "
		End If
		wsSQL = wsSQL & " ORDER BY RPTITMCODE "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			waResult.ReDim(0, -1, SSEL, SID)
			tblDetail.ReBind()
			tblDetail.Bookmark = 0
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmSTKCNT.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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
                waResult.get_Value(.get_UpperBound(1), SITMCODE) = ReadRs(rsRcd, "RPTITMCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SITMNAME) = ReadRs(rsRcd, "RPTITMNAM")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SWHSCODE) = ReadRs(rsRcd, "RPTWHSCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SLOTNO) = ReadRs(rsRcd, "RPTLOTNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SSOH) = VB6.Format(ReadRs(rsRcd, "RPTSOH"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SCOUNTED) = VB6.Format(ReadRs(rsRcd, "RPTCOUNTED"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SQTYDIFF) = VB6.Format(ReadRs(rsRcd, "RPTQTYDIFF"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SID) = ReadRs(rsRcd, "RPTITMID")



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
        'UPGRADE_ISSUE: Form property frmSTKCNT.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

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


        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function




    Private Sub cmdSave(ByVal inActFlg As Short)



    End Sub

    Private Function InputValidation() As Boolean
        Dim wiEmptyGrid As Boolean
        Dim wlCtr As Integer

        InputValidation = False

        On Error GoTo InputValidation_Err

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
                    wiEmptyGrid = False
                    'If Chk_GrdRow(wlCtr) = False Then
                    '    tblDetail.SetFocus
                    '    Exit Function
                    'End If
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
        'UPGRADE_ISSUE: Form property frmSTKCNT.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Sub
	Private Function Chk_grdQty(ByRef inCode As String) As Boolean
		
		Chk_grdQty = True
		
		If Trim(inCode) = "" Then
			gsMsg = "必需輸入數量!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdQty = False
			Exit Function
		End If
		
		If To_Value(inCode) = 0 Then
			gsMsg = "數量必需大於零!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Chk_grdQty = False
			Exit Function
		End If
		
	End Function
	
	
	Private Sub cmdPrint()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		' If InputValidation() = False Then
		'   MousePointer = vbDefault
		'   Exit Sub
		'End If
		
		
		
		'Create Selection Criteria
		ReDim wsSelection(4)
		wsSelection(1) = ""
		wsSelection(2) = ""
		wsSelection(3) = ""
		wsSelection(4) = ""
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTSTKCNT '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'盤點數目報表', "
		wsSQL = wsSQL & "'" & Opt_Getfocus(optShow, 2, 0) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), Set_Quote(cboItmCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmBarCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmBarCodeTo.Text) = "", New String("z", 15), Set_Quote(cboItmBarCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboWhsCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboWhsCodeTo.Text) = "", New String("z", 10), Set_Quote(cboWhsCodeTo.Text)) & "', "
		'wsSql = wsSql & "'" & IIf(Trim(medPrdFr.Text) = "/", "0000/00", medPrdFr.Text) & "', "
		'wsSql = wsSql & "'" & IIf(Trim(medPrdTo.Text) = "/", "9999/99", medPrdTo.Text) & "', "
		'wsSql = wsSql & "" & To_Value(txtQtyLvlFr) & ", "
		'wsSql = wsSql & "" & IIf(To_Value(txtQtyLvlTo.Text) = 0, "999999999.99", To_Value(txtQtyLvlTo.Text)) & ", "
		wsSQL = wsSQL & gsLangID
		
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTSTKCNT"
		Else
			wsRptName = "RPTSTKCNT"
		End If
		
		NewfrmPrint.ReportID = "STKCNT"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "STKCNT"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		
		
	End Sub
End Class