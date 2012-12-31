Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMRP001
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
	Private wsDte As String
	
	
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
	Private Const SITMTYPE As Short = 3
	Private Const SUPRICE As Short = 4
	Private Const SSTKUOM As Short = 5
	Private Const SSTKQTY As Short = 6
	Private Const SRDRQTY As Short = 7
	Private Const SVDRCODE As Short = 8
	Private Const SCURR As Short = 9
	Private Const SPOPRICE As Short = 10
	Private Const SPRCUOM As Short = 11
	Private Const SPOQTY As Short = 12
	Private Const SDUMMY As Short = 13
	Private Const SID As Short = 14
	
	
	
	Private Sub cboItmBarCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmBarCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsSQL = "SELECT ITMBARCODE, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME "
		wsSQL = wsSQL & " FROM MSTITEM "
		wsSQL = wsSQL & " WHERE ITMBARCODE LIKE '%" & IIf(cboItmBarCodeFr.SelectionLength > 0, "", Set_Quote(cboItmBarCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		
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
		Call chk_InpLen(cboItmBarCodeFr, 10, KeyAscii)
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
        wsSQL = "SELECT ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME "
        wsSQL = wsSQL & " FROM mstItem "
        wsSQL = wsSQL & " WHERE ItmBarCode LIKE '%" & IIf(cboItmBarCodeTo.SelectionLength > 0, "", Set_Quote(cboItmBarCodeTo.Text)) & "%' "
        wsSQL = wsSQL & " AND ItmSTATUS = '1' "
        wsSQL = wsSQL & " ORDER BY ItmCode "
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
        Call chk_InpLen(cboItmBarCodeTo, 10, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmBarCodeTo = False Then
                GoTo EventExitSub
            End If

            cboItmTypeCodeFr.Focus()
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


    'UPGRADE_WARNING: Event frmMRP001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmMRP001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub



    Private Sub cboItmCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmCodeFr

        wsSQL = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME "
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

        wsSQL = "SELECT ItmCode, ItmBarCode, " & IIf(gsLangID = "1", "ITMENGNAME", "ITMCHINAME") & " ITNAME "
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



    Private Sub cboItmTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmTypeCodeFr

        wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", " ItmTypeEngDesc", " ItmTypeChiDesc") & " FROM MstItemType "
        wsSQL = wsSQL & " WHERE ItmTypeStatus = '1'"
        wsSQL = wsSQL & " AND ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeFr.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY ItmTypeCode "

        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmTypeCodeFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmTypeCodeFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmTypeCodeFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Enter
        FocusMe(cboItmTypeCodeFr)
        wcCombo = cboItmTypeCodeFr
    End Sub

    Private Sub cboItmTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmTypeCodeFr, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboItmTypeCodeFr.Text) <> "" And Trim(cboItmTypeCodeTo.Text) = "" Then
                cboItmTypeCodeTo.Text = cboItmTypeCodeFr.Text
            End If
            cboItmTypeCodeTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Leave
        FocusMe(cboItmTypeCodeFr, True)
    End Sub

    Private Sub cboItmTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboItmTypeCodeTo

        wsSQL = "SELECT ItmTypeCode, " & IIf(gsLangID = "1", " ItmTypeEngDesc", " ItmTypeChiDesc") & " FROM MstItemType "
        wsSQL = wsSQL & " WHERE ItmTypeStatus = '1'"
        wsSQL = wsSQL & " AND ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeTo.Text)) & "%' "
        wsSQL = wsSQL & " ORDER BY ItmTypeCode "
        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboItmTypeCodeTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboItmTypeCodeTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboItmTypeCodeTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboItmTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Enter
        FocusMe(cboItmTypeCodeTo)
        wcCombo = cboItmTypeCodeTo
    End Sub

    Private Sub cboItmTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboItmTypeCodeTo, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboItmTypeCodeTo = False Then
                Call cboItmTypeCodeTo_Enter(cboItmTypeCodeTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            Call Opt_Setfocus(optType, 2, 0)


        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboItmTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Leave
        FocusMe(cboItmTypeCodeTo, True)
    End Sub
    Private Function chk_cboItmTypeCodeTo() As Boolean
        chk_cboItmTypeCodeTo = False

        If UCase(cboItmTypeCodeFr.Text) > UCase(cboItmTypeCodeTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboItmTypeCodeTo = True
    End Function


    Private Sub frmMRP001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F10
                If tbrProcess.Items.Item(tcOK).Enabled = False Then Exit Sub
                Call cmdSave(1)

            Case System.Windows.Forms.Keys.F9
                Call cmdPrint()

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

    Private Sub frmMRP001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


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


        optType(0).Checked = True

        txtQtyLvlFr.Enabled = False
        txtQtyLvlTo.Enabled = False
        '   cboItmCodeFr.Text = ""
        '   cboItmCodeTo.Text = ""
        '   cboItmBarCodeFr.Text = ""
        '   cboItmBarCodeTo.Text = ""

    End Sub

    Private Sub frmMRP001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmMRP001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing


    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "MRP001"
        wsDte = Change_SQLDate(CStr(Now))
    End Sub

    Private Sub Ini_Caption()
        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblItmCodeFr.Text = Get_Caption(waScrItm, "ItmCodeFR")
        lblItmCodeTo.Text = Get_Caption(waScrItm, "ItmCodeTO")
        lblItmBarCodeFr.Text = Get_Caption(waScrItm, "ItmBarCodeFR")
        lblItmBarCodeTo.Text = Get_Caption(waScrItm, "ItmBarCodeTO")
        lblItmTypeCodeFr.Text = Get_Caption(waScrItm, "ItmTypeCodeFR")
        lblItmTypeCodeTo.Text = Get_Caption(waScrItm, "ItmTypeCodeTO")



        optType(0).Text = Get_Caption(waScrItm, "OPT0")
        optType(1).Text = Get_Caption(waScrItm, "OPT2")

        lblQtyLvlTo.Text = Get_Caption(waScrItm, "QTYLVLTO")



        With tblDetail
            .Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
            .Columns(SITMCODE).Caption = Get_Caption(waScrItm, "SItmCode")
            .Columns(SITMNAME).Caption = Get_Caption(waScrItm, "SItmNAME")
            .Columns(SITMTYPE).Caption = Get_Caption(waScrItm, "SITMTYPE")
            .Columns(SUPRICE).Caption = Get_Caption(waScrItm, "SUPRICE")
            .Columns(SSTKUOM).Caption = Get_Caption(waScrItm, "SSTKUOM")
            .Columns(SSTKQTY).Caption = Get_Caption(waScrItm, "SSTKQTY")
            .Columns(SRDRQTY).Caption = Get_Caption(waScrItm, "SRDRQTY")
            .Columns(SPOQTY).Caption = Get_Caption(waScrItm, "SPOQTY")
            .Columns(SVDRCODE).Caption = Get_Caption(waScrItm, "SVDRCODE")
            .Columns(SCURR).Caption = Get_Caption(waScrItm, "SCURR")
            .Columns(SPOPRICE).Caption = Get_Caption(waScrItm, "SPOPRICE")
            .Columns(SPRCUOM).Caption = Get_Caption(waScrItm, "SPRCUOM")

        End With




        tbrProcess.Items.Item(tcOK).ToolTipText = Get_Caption(waScrToolTip, tcOK) & "(F10)"
        tbrProcess.Items.Item(tcPrint).ToolTipText = Get_Caption(waScrToolTip, tcPrint) & "(F9)"
        tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F7)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
        tbrProcess.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrToolTip, tcSAll) & "(F5)"
        tbrProcess.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrToolTip, tcDAll) & "(F6)"



    End Sub










    'UPGRADE_WARNING: Event optType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optType.CheckedChanged
        If eventSender.Checked Then
            Dim Index As Short = optType.GetIndex(eventSender)
            If optType(1).Checked = True Then
                txtQtyLvlFr.Enabled = True
                txtQtyLvlTo.Enabled = True
            Else
                txtQtyLvlFr.Enabled = False
                txtQtyLvlTo.Enabled = False
            End If

        End If
    End Sub

    Private Sub optType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optType.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optType.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Index <> 1 Then
                If LoadRecord = True Then
                    tblDetail.Focus()
                End If
            Else
                txtQtyLvlFr.Focus()
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With
    End Sub




    Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
        Dim RetCurr As String
        Dim RetUom As String
        Dim RetCost As Double


        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                Case SPOQTY

                    If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                Case SVDRCODE

                    If Chk_grdVdrCode(.Columns(eventArgs.ColIndex).Text, .Columns(SITMCODE).Text, RetCurr, RetUom, RetCost) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
                    End If

                    .Columns(SCURR).Text = RetCurr
                    .Columns(SPRCUOM).Text = RetUom
                    .Columns(SPOPRICE).Text = CStr(RetCost)


                Case SPOPRICE

                    If Chk_grdQty((.Columns(eventArgs.ColIndex).Text)) = False Then
                        GoTo Tbl_BeforeColUpdate_Err
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

        Dim wsSQL As String
        Dim wiTop As Integer
        Dim wiCtr As Short

        On Error GoTo tblDetail_ButtonClick_Err

        With tblDetail
            Select Case eventArgs.ColIndex
                Case SVDRCODE

                    wsSQL = "SELECT VDRCODE, VDRNAME "
                    wsSQL = wsSQL & " FROM mstVENDOR, mstVDRITEM, MSTITEM "
                    wsSQL = wsSQL & " WHERE ITMCODE = '" & Set_Quote(.Columns(SITMCODE).Text) & "' "
                    wsSQL = wsSQL & " AND VDRID = VDRITEMVDRID "
                    wsSQL = wsSQL & " AND ITMID = VDRITEMITMID "
                    wsSQL = wsSQL & " AND VDRITEMSTATUS <> '2' "
                    wsSQL = wsSQL & " ORDER BY VDRCODE "


                    Call Ini_Combo(2, wsSQL, .Columns(eventArgs.ColIndex).Left + VB6.FromPixelsUserX(.Left, 0, 11923.8, 794) + .Columns(eventArgs.ColIndex).Top, VB6.FromPixelsUserY(.Top, 0, 8620.47, 575) + .RowTop(.Row) + .RowHeight, tblCommon, wsFormID, "TBLVDRCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
                    tblCommon.Visible = True
                    tblCommon.Focus()
                    wcCombo = tblDetail


            End Select
        End With

        Exit Sub

tblDetail_ButtonClick_Err:
        MsgBox("Check tblDetail ButtonClick!")

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
                        Case SSEL
                            eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                            .Col = SPOQTY
                        Case SPOQTY
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
                        Case SPOQTY
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

            Case SPOQTY
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, False)

            Case SPOPRICE
                Call Chk_InpNum(eventArgs.KeyAscii, (tblDetail.Text), False, True)


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


                    Case SPOQTY

                        '  Call Chk_grdQty(waResult(LastRow, SPOQTY))

                    Case SVDRCODE

                        Call Chk_grdVdrCode(waResult.get_Value(eventArgs.LastRow, SVDRCODE), waResult.get_Value(eventArgs.LastRow, SITMCODE), "", "", 0)

                    Case SPOPRICE

                        Call Chk_grdQty(waResult.get_Value(eventArgs.LastRow, SPOPRICE))

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

        'If wcCombo.Name = tblDetail.Name Then
        '    tblDetail.EditActive = True
        '    'UPGRADE_WARNING: Couldn't resolve default property of object wcCombo.Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    Select Case wcCombo.Col
        '        Case SVDRCODE
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
            '        Case SVDRCODE
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
                    Case SITMCODE
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Width = 2000
                    Case SITMNAME
                        .Columns(wiCtr).DataWidth = 50
                        .Columns(wiCtr).Width = 1500
                    Case SUPRICE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsUprFmt
                    Case SITMTYPE
                        .Columns(wiCtr).Width = 1300
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Visible = False
                    Case SSTKUOM
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 10
                    Case SSTKQTY
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsQtyFmt
                    Case SRDRQTY
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsQtyFmt
                    Case SPOQTY
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsQtyFmt
                        .Columns(wiCtr).Locked = False
                    Case SVDRCODE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 10
                        .Columns(wiCtr).Locked = False
                        .Columns(wiCtr).Button = True
                    Case SPOPRICE
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).NumberFormat = gsAmtFmt
                        .Columns(wiCtr).Locked = False
                    Case SPRCUOM
                        .Columns(wiCtr).Width = 800
                        .Columns(wiCtr).DataWidth = 10
                    Case SCURR
                        .Columns(wiCtr).Width = 500
                        .Columns(wiCtr).DataWidth = 3
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
        Dim wdStkQty As Double
        Dim wsMth As String
        Dim wdRdrQty As Double

        wsMth = Mid(gsSystemDate, 6, 2)

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        LoadRecord = False


        Call cmdCrtRecord()


        wsSQL = "SELECT RPTITMID, RPTITMCODE, RPTITMNAM, RPTITMTYPE, RPTUPRICE, RPTVDRID, RPTSTKUOM, "
        wsSQL = wsSQL & " RPTPOQTY,  RPTRDRLVL, RPTNEEDQTY, RPTVDRCODE, RPTCURR, RPTPOPRICE, RPTPRCUOM "
        wsSQL = wsSQL & " FROM  RPTMRP001 "
        wsSQL = wsSQL & " WHERE RPTUSRID  = '" & gsUserID & "' "
        wsSQL = wsSQL & " AND RPTDTETIM  = '" & wsDte & "' "
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
            'UPGRADE_ISSUE: Form property frmMRP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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
                waResult.get_Value(.get_UpperBound(1), SITMTYPE) = ReadRs(rsRcd, "RPTITMTYPE")
                waResult.get_Value(.get_UpperBound(1), SUPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "RPTUPRICE")), gsUprFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SSTKUOM) = ReadRs(rsRcd, "RPTSTKUOM")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SSTKQTY) = VB6.Format(ReadRs(rsRcd, "RPTNEEDQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SRDRQTY) = VB6.Format(ReadRs(rsRcd, "RPTRDRLVL"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SPOQTY) = VB6.Format(ReadRs(rsRcd, "RPTPOQTY"), gsQtyFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SVDRCODE) = ReadRs(rsRcd, "RPTVDRCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SCURR) = ReadRs(rsRcd, "RPTCURR")
                waResult.get_Value(.get_UpperBound(1), SPOPRICE) = VB6.Format(To_Value(ReadRs(rsRcd, "RPTPOPRICE")), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SPRCUOM) = ReadRs(rsRcd, "RPTPRCUOM")
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
        'UPGRADE_ISSUE: Form property frmMRP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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

            If Chk_grdQty(waResult.get_Value(LastRow, SPOQTY)) = False Then
                .Col = SPOQTY
                .Row = LastRow
                Exit Function
            End If

            If Chk_grdVdrCode(waResult.get_Value(LastRow, SVDRCODE), waResult.get_Value(LastRow, SITMCODE), "", "", 0) = False Then
                .Col = SVDRCODE
                .Row = LastRow
                Exit Function
            End If

            If Chk_grdQty(waResult.get_Value(LastRow, SPOPRICE)) = False Then
                .Col = SPOPRICE
                .Row = LastRow
                Exit Function
            End If

        End With

        Chk_GrdRow = True

        Exit Function

Chk_GrdRow_Err:
        MsgBox("Check Chk_GrdRow")

    End Function




    Private Sub cmdSave(ByVal inActFlg As Short)

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsFirstFlg As String
        Dim wiLine As Short
        Dim wsCtlPrd As String
        Dim wsDteTim As String
        Dim wiflg As Short

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

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

        wsDteTim = Change_SQLDate(CStr(Now))
        wsCtlPrd = VB.Left(gsSystemDate, 4) & Mid(gsSystemDate, 6, 2)

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon


        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_MRP001A"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then

                    Call SetSPPara(adcmdSave, 1, wsDteTim)
                    Call SetSPPara(adcmdSave, 2, wsCtlPrd)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, SID))
                    Call SetSPPara(adcmdSave, 4, waResult.get_Value(wiCtr, SVDRCODE))
                    Call SetSPPara(adcmdSave, 5, waResult.get_Value(wiCtr, SCURR))
                    Call SetSPPara(adcmdSave, 6, waResult.get_Value(wiCtr, SPOQTY))
                    Call SetSPPara(adcmdSave, 7, waResult.get_Value(wiCtr, SPOPRICE))
                    Call SetSPPara(adcmdSave, 8, wsFormID)
                    Call SetSPPara(adcmdSave, 9, gsUserID)
                    Call SetSPPara(adcmdSave, 10, wsGenDte)
                    adcmdSave.Execute()

                End If
            Next wiCtr

            adcmdSave.CommandText = "USP_MRP001B"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()
            Call SetSPPara(adcmdSave, 1, gsUserID)
            Call SetSPPara(adcmdSave, 2, wsDteTim)
            Call SetSPPara(adcmdSave, 3, gsLangID)
            Call SetSPPara(adcmdSave, 4, wsFormID)
            Call SetSPPara(adcmdSave, 5, wsGenDte)
            adcmdSave.Execute()

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

        wiEmptyGrid = True
        With waResult
            For wlCtr = 0 To .get_UpperBound(1)
                If Trim(waResult.get_Value(wlCtr, SSEL)) = "-1" Then
                    wiEmptyGrid = False
                    If Chk_GrdRow(wlCtr) = False Then
                        tblDetail.Focus()
                        Exit Function
                    End If
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


        If Not chk_txtQtyLvlTo Then
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
        'UPGRADE_ISSUE: Form property frmMRP001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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

    Private Function Chk_grdVdrCode(ByVal inCode As String, ByVal inItmCode As String, ByRef OutCurr As String, ByRef OutUOM As String, ByRef OutCost As Double) As Boolean
        Dim wsSQL As String
        Dim rsRcd As New ADODB.Recordset


        If Trim(inCode) = "" Then
            gsMsg = "沒有輸入供應商!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If


        wsSQL = "SELECT VdrItemCurr, VdrItemCost, VdrItemUomCode FROM MstVendor, mstVdrItem, MstItem "
        wsSQL = wsSQL & " WHERE VdrCode = '" & Set_Quote(inCode) & "' "
        wsSQL = wsSQL & " And ItmCode = '" & Set_Quote(inItmCode) & "' "
        wsSQL = wsSQL & " And VdrItemVdrID = VdrID "
        wsSQL = wsSQL & " And VdrItemItmID = ItmID "
        wsSQL = wsSQL & " And VdrItemStatus = '1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutCurr = ReadRs(rsRcd, "VdrItemCurr")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutUOM = ReadRs(rsRcd, "VdrItemUomCode")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutCost = CDbl(VB6.Format(ReadRs(rsRcd, "VdrItemCost"), gsAmtFmt))

            Chk_grdVdrCode = True
        Else
            OutCurr = ""
            OutUOM = ""
            OutCost = 0

            gsMsg = "沒有此供應商價格!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Chk_grdVdrCode = False
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function

        End If
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing



    End Function
    Private Sub cmdPrint()

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

        wsSQL = "EXEC usp_RPTMRP001 '" & Set_Quote(gsUserID) & "', "
        wsSQL = wsSQL & "'" & wsDte & "', "
        wsSQL = wsSQL & "'物料再訂購告示', "
        wsSQL = wsSQL & "'" & Opt_Getfocus(optType, 2, 0) & "', "
        wsSQL = wsSQL & "'" & Set_Quote(cboItmCodeFr.Text) & "', "
        wsSQL = wsSQL & "'" & IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), Set_Quote(cboItmCodeTo.Text)) & "', "
        wsSQL = wsSQL & "'" & Set_Quote(cboItmBarCodeFr.Text) & "', "
        wsSQL = wsSQL & "'" & IIf(Trim(cboItmBarCodeTo.Text) = "", New String("z", 13), Set_Quote(cboItmBarCodeTo.Text)) & "', "
        wsSQL = wsSQL & "'" & Set_Quote(cboItmTypeCodeFr.Text) & "', "
        wsSQL = wsSQL & "'" & IIf(Trim(cboItmTypeCodeTo.Text) = "", New String("z", 10), Set_Quote(cboItmTypeCodeTo.Text)) & "', "
        wsSQL = wsSQL & "" & To_Value(txtQtyLvlFr) & ", "
        wsSQL = wsSQL & "" & IIf(To_Value((txtQtyLvlTo.Text)) = 0, "999999999.99", To_Value((txtQtyLvlTo.Text))) & ", "
        wsSQL = wsSQL & gsLangID



        If gsLangID = "2" Then
            wsRptName = "C" & "RPTMRP001"
        Else
            wsRptName = "RPTMRP001"
        End If

        NewfrmPrint.ReportID = "MRP001"
        NewfrmPrint.RptTitle = Me.Text
        NewfrmPrint.TableID = "MRP001"
        NewfrmPrint.RptDteTim = wsDte
        NewfrmPrint.StoreP = wsSQL
        NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
        NewfrmPrint.RptName = wsRptName
        NewfrmPrint.ShowDialog()


        'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        NewfrmPrint = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default



    End Sub

    Private Function chk_txtQtyLvlTo() As Boolean
        chk_txtQtyLvlTo = False

        If To_Value((txtQtyLvlFr.Text)) > To_Value((txtQtyLvlTo.Text)) Then
            gsMsg = "範圍錯誤!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            Exit Function
        End If

        chk_txtQtyLvlTo = True
    End Function
    Private Sub txtQtyLvlFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQtyLvlFr.Enter
        FocusMe(txtQtyLvlFr)
    End Sub

    Private Sub txtQtyLvlFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtQtyLvlFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtQtyLvlFr.Text, True, False)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default


            txtQtyLvlTo.Focus()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtQtyLvlFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQtyLvlFr.Leave
        FocusMe(txtQtyLvlFr, True)
    End Sub

    Private Sub txtQtyLvlTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQtyLvlTo.Enter
        FocusMe(txtQtyLvlTo)
    End Sub

    Private Sub txtQtyLvlTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtQtyLvlTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtQtyLvlTo.Text, True, False)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_txtQtyLvlTo() = False Then
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
	
	Private Sub txtQtyLvlTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQtyLvlTo.Leave
		FocusMe(txtQtyLvlTo, True)
	End Sub
	
	Private Sub cmdCrtRecord()
		
		Dim adcmdSave As New ADODB.Command
		Dim wiCtr As Short
		
		On Error GoTo cmdCrtRecord_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		
		adcmdSave.CommandText = "USP_RPTMRP001"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		Call SetSPPara(adcmdSave, 1, gsUserID)
		Call SetSPPara(adcmdSave, 2, wsDte)
		Call SetSPPara(adcmdSave, 3, "")
		Call SetSPPara(adcmdSave, 4, Opt_Getfocus(optType, 2, 0))
		Call SetSPPara(adcmdSave, 5, cboItmCodeFr)
		Call SetSPPara(adcmdSave, 6, IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), cboItmCodeTo.Text))
		Call SetSPPara(adcmdSave, 7, cboItmBarCodeFr)
		Call SetSPPara(adcmdSave, 8, IIf(Trim(cboItmBarCodeTo.Text) = "", New String("z", 30), cboItmBarCodeTo.Text))
		Call SetSPPara(adcmdSave, 9, cboItmTypeCodeFr)
		Call SetSPPara(adcmdSave, 10, IIf(Trim(cboItmTypeCodeTo.Text) = "", New String("z", 10), cboItmTypeCodeTo.Text))
		Call SetSPPara(adcmdSave, 11, txtQtyLvlFr.Text)
		Call SetSPPara(adcmdSave, 12, IIf(To_Value((txtQtyLvlTo.Text)) = 0, "999999999.99", txtQtyLvlTo.Text))
		Call SetSPPara(adcmdSave, 13, gsLangID)
		adcmdSave.Execute()
		
		
		cnCon.CommitTrans()
		
		
		
		
		'Call UnLockAll(wsConnTime, wsFormID)
		
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
		
cmdCrtRecord_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
	End Sub
End Class