Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAPV001
	Inherits System.Windows.Forms.Form
	
	Private waResult As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	'Private waScrToolTip As New XArrayDB
	Private wcCombo As System.Windows.Forms.Control
	Private wbErr As Boolean
	
	Private wiSort As Short
	Private wsSortBy As String
	
	Private wiExit As Boolean
	Private wsFormCaption As String
	Private wsFormID As String
	Private wiActFlg As Short
	Private wsMark As String
	Private wsTrnCd As String
	
	Private Const tcConvert As String = "Convert"
	Private Const tcCan As String = "Can"
	Private Const tcCopy As String = "Copy"
	Private Const tcFinish As String = "Finish"
	Private Const tcExport As String = "Export"
	
	Private Const tcRefresh As String = "Refresh"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	Private Const tcSAll As String = "SAll"
	Private Const tcDAll As String = "DAll"
	
	
	Private Const SSEL As Short = 0
	Private Const SDOCDATE As Short = 1
	Private Const SDOCNO As Short = 2
	Private Const SVDRCODE As Short = 3
	Private Const SVDRNAME As Short = 4
	Private Const SDUEDATE As Short = 5
	Private Const SETADATE As Short = 6
	Private Const SQTY As Short = 7
	Private Const SNET As Short = 8
	Private Const SORI As Short = 9
	Private Const SDUMMY As Short = 10
	Private Const SID As Short = 11
	
	
	
	Private Sub cboVdrNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsSQL = "SELECT VDRCODE, VDRNAME FROM MSTVENDOR WHERE VDRCODE LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND VdrStatus <> '2' "
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY VDRCODE "
		Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboVdrNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboVdrNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboVdrNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLVdrNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVdrNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.Enter
		FocusMe(cboVdrNoFr)
		wcCombo = cboVdrNoFr
	End Sub
	
	Private Sub cboVdrNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboVdrNoFr, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Trim(cboVdrNoFr.Text) <> "" And Trim(cboVdrNoTo.Text) = "" Then
                cboVdrNoTo.Text = cboVdrNoFr.Text
            End If
            cboVdrNoTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub cboVdrNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.Leave
        FocusMe(cboVdrNoFr, True)
    End Sub

    Private Sub cboVdrNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsSQL = "SELECT VDRCODE, VDRNAME FROM MSTVENDOR WHERE VDRCODE LIKE '%" & IIf(cboVdrNoTo.SelectionLength > 0, "", Set_Quote(cboVdrNoTo.Text)) & "%' "
        wsSQL = wsSQL & " AND VdrStatus <> '2' "
        wsSQL = wsSQL & " AND VdrInactive = 'N' "
        wsSQL = wsSQL & " ORDER BY VDRCODE "
        Call Ini_Combo(2, wsSQL, (VB6.FromPixelsUserX(cboVdrNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboVdrNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboVdrNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLVdrNo", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboVdrNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.Enter
        FocusMe(cboVdrNoTo)
        wcCombo = cboVdrNoTo
    End Sub

    Private Sub cboVdrNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrNoTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboVdrNoTo, 10, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboVdrNoTo = False Then
                GoTo EventExitSub
            End If

            medPrdFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub



    Private Sub cboVdrNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.Leave
        FocusMe(cboVdrNoTo, True)
    End Sub


    'UPGRADE_WARNING: Event frmAPV001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmAPV001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(9000)
            Me.Width = VB6.TwipsToPixelsX(12000)
        End If
    End Sub

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

    Private Sub cboDocNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDocNoFr

        Select Case wsTrnCd
            Case "PO"

                wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPOHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND POHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY POHDDOCNO "


            Case "PV"

                wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPVHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PVHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY PVHDDOCNO "

            Case "GR"

                wsSQL = "SELECT GRHDDOCNO, VDRCODE, GRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPGRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE GRHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND GRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND GRHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY GRHDDOCNO "

            Case "PR"

                wsSQL = "SELECT PRHDDOCNO, VDRCODE, PRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PRHDDOCNO LIKE '%" & IIf(cboDocNoFr.SelectionLength > 0, "", Set_Quote(cboDocNoFr.Text)) & "%' "
                wsSQL = wsSQL & " AND PRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PRHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY PRHDDOCNO "


        End Select
        Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoFr.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboDocNoFr.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboDocNoFr.Height, 8620.47, 575), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Call chk_InpLen(cboDocNoFr, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Trim(cboDocNoFr.Text) <> "" And Trim(cboDocNoTo.Text) = "" Then
                cboDocNoTo.Text = cboDocNoFr.Text
            End If
            cboDocNoTo.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboDocNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoFr.Leave
        FocusMe(cboDocNoFr, True)
    End Sub

    Private Sub cboDocNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboDocNoTo

        Select Case wsTrnCd
            Case "PO"

                wsSQL = "SELECT POHDDOCNO, VDRCODE, POHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPOHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE POHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND POHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND POHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY POHDDOCNO "

            Case "GR"

                wsSQL = "SELECT GRHDDOCNO, VDRCODE, GRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPGRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE GRHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND GRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND GRHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY GRHDDOCNO "

            Case "PV"

                wsSQL = "SELECT PVHDDOCNO, VDRCODE, PVHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPVHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PVHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND PVHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PVHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY PVHDDOCNO "

            Case "PR"

                wsSQL = "SELECT PRHDDOCNO, VDRCODE, PRHDDOCDATE "
                wsSQL = wsSQL & " FROM POPPRHD, MSTVENDOR "
                wsSQL = wsSQL & " WHERE PRHDDOCNO LIKE '%" & IIf(cboDocNoTo.SelectionLength > 0, "", Set_Quote(cboDocNoTo.Text)) & "%' "
                wsSQL = wsSQL & " AND PRHDVDRID  = VDRID "
                wsSQL = wsSQL & " AND PRHDSTATUS = '1' "
                wsSQL = wsSQL & " ORDER BY PRHDDOCNO "


        End Select

        Call Ini_Combo(3, wsSQL, (VB6.FromPixelsUserX(cboDocNoTo.Left, 0, 11923.8, 794)), VB6.FromPixelsUserY(cboDocNoTo.Top, 0, 8620.47, 575) + VB6.FromPixelsUserHeight(cboDocNoTo.Height, 8620.47, 575), tblCommon, wsFormID, "TBLDOCNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboDocNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Enter
        FocusMe(cboDocNoTo)
        wcCombo = cboDocNoTo
    End Sub

    Private Sub cboDocNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboDocNoTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboDocNoTo, 15, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboDocNoTo = False Then
                Call cboDocNoTo_Enter(cboDocNoTo, New System.EventArgs())
                GoTo EventExitSub
            End If

            cboVdrNoFr.Focus()


        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboDocNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDocNoTo.Leave
        FocusMe(cboDocNoTo, True)
    End Sub
    Private Function chk_cboDocNoTo() As Boolean
        chk_cboDocNoTo = False

        If UCase(cboDocNoFr.Text) > UCase(cboDocNoTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboDocNoTo = True
    End Function

    Private Function chk_cboVdrNoTo() As Boolean
        chk_cboVdrNoTo = False

        If UCase(cboVdrNoFr.Text) > UCase(cboVdrNoTo.Text) Then
            gsMsg = "To > From!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboVdrNoTo.Focus()
            Exit Function
        End If

        chk_cboVdrNoTo = True
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
    Private Sub Chk_Sel(ByRef inRow As Integer)

        Dim wlCtr As Integer


        For wlCtr = 0 To waResult.get_UpperBound(1)
            If inRow <> wlCtr Then
                If waResult.get_Value(wlCtr, SSEL) = "-1" Then
                    waResult.get_Value(wlCtr, SSEL) = "0"
                    Exit Sub
                End If
            End If
        Next

    End Sub
    Private Sub frmAPV001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        Select Case KeyCode
            '   Case vbKeyF2
            '   If tbrProcess.Buttons(tcConvert).Enabled = False Then Exit Sub
            '      Call cmdSave(2)

            Case System.Windows.Forms.Keys.F3
                If tbrProcess.Items.Item(tcCan).Enabled = False Then Exit Sub
                Call cmdSave(3)

            Case System.Windows.Forms.Keys.F9
                If tbrProcess.Items.Item(tcExport).Enabled = False Then Exit Sub
                Call cmdExport()

            Case System.Windows.Forms.Keys.F8
                If tbrProcess.Items.Item(tcCopy).Enabled = False Then Exit Sub
                Call cmdSave(4)


            Case System.Windows.Forms.Keys.F10
                If tbrProcess.Items.Item(tcFinish).Enabled = False Then Exit Sub
                Call cmdSave(5)

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



    'UPGRADE_WARNING: Event optDocType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub optDocType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDocType.CheckedChanged
        If eventSender.Checked Then
            Dim Index As Short = optDocType.GetIndex(eventSender)
            Call cmdRefresh()
        End If
    End Sub

    Private Sub optDocType_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optDocType.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optDocType.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Call cmdRefresh()
            tblDetail.Focus()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click, _tbrProcess_Button13.Click, _tbrProcess_Button14.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		If tbrProcess.Items.Item(Button.Name).Enabled = False Then Exit Sub
		
		
		Select Case Button.Name
			'     Case tcConvert
			'         Call cmdSave(2)
			
			Case tcCan
				Call cmdSave(3)
				
			Case tcCopy
				Call cmdSave(4)
				
			Case tcExport
				Call cmdExport()
				
				
			Case tcFinish
				Call cmdSave(5)
				
			Case tcCancel
				
				Call cmdCancel()
				
				
			Case tcSAll
				
				Call cmdSelect(1)
				
			Case tcDAll
				
				Call cmdSelect(0)
				
			Case tcExit
				Me.Close()
				
			Case tcRefresh
				Call cmdRefresh()
				
				
		End Select
	End Sub
	
	Private Sub frmAPV001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		
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
	
	
	
	Private Sub cmdRefresh()
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		If wsSortBy = "ASC" Then
			wsSortBy = "DESC"
		Else
			wsSortBy = "ASC"
		End If
		
        Call Setup_tbrProcess()
        Call LoadRecord()


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

        Call SetPeriodMask(medPrdFr)
        Call SetPeriodMask(medPrdTo)


        medPrdFr.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))
        medPrdTo.Text = Dsp_PeriodDate(VB.Left(gsSystemDate, 7))

        cboDocNoFr.Text = ""
        cboDocNoTo.Text = ""
        cboVdrNoFr.Text = ""
        cboVdrNoTo.Text = ""

        wiSort = 0
        wsSortBy = "ASC"

        Call cmdRefresh()

    End Sub

    Private Sub frmAPV001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        '   Set waScrToolTip = Nothing
        'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waResult = Nothing
        'UPGRADE_NOTE: Object frmAPV001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing


    End Sub



    Private Sub IniForm()
        Me.KeyPreview = True

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
        optDocType(0).Checked = True
        '   wsFormID = "APV001"
    End Sub


    Private Sub Setup_tbrProcess()

        With tbrProcess

            Select Case wsFormID
                Case "APV001"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            ' .Buttons(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = True
                        Case 1
                            '  .Buttons(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                        Case 2
                            ' .Buttons(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = True
                            .Items.Item(tcFinish).Enabled = False
                    End Select

                    .Items.Item(tcExport).Enabled = True
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True


                Case "APV002", "APV003"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            ' .Buttons(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = True
                        Case 1
                            ' .Buttons(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                        Case 2
                            ' .Buttons(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                    End Select

                    .Items.Item(tcExport).Enabled = False
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True


                Case "APV004"

                    Select Case Opt_Getfocus(optDocType, 3, 0)
                        Case 0
                            ' .Buttons(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = True
                        Case 1
                            ' .Buttons(tcConvert).Enabled = True
                            .Items.Item(tcCan).Enabled = False
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                        Case 2
                            ' .Buttons(tcConvert).Enabled = False
                            .Items.Item(tcCan).Enabled = True
                            .Items.Item(tcCopy).Enabled = False
                            .Items.Item(tcFinish).Enabled = False
                    End Select

                    .Items.Item(tcExport).Enabled = True
                    .Items.Item(tcRefresh).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcSAll).Enabled = True
                    .Items.Item(tcDAll).Enabled = True
                    .Items.Item(tcExit).Enabled = True
            End Select



        End With

    End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		'  Call Get_Scr_Item("TOOLTIP_A", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblDocNoFr.Text = Get_Caption(waScrItm, "DOCNOFR")
		lblDocNoTo.Text = Get_Caption(waScrItm, "DOCNOTO")
		lblVdrNoFr.Text = Get_Caption(waScrItm, "VdrNoFR")
		lblVdrNoTo.Text = Get_Caption(waScrItm, "VdrNoTO")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		lblPrdTo.Text = Get_Caption(waScrItm, "PRDTO")
		optDocType(0).Text = Get_Caption(waScrItm, "OPT1")
		optDocType(1).Text = Get_Caption(waScrItm, "OPT2")
		optDocType(2).Text = Get_Caption(waScrItm, "OPT3")
		
		
		
		With tblDetail
			.Columns(SSEL).Caption = Get_Caption(waScrItm, "SSEL")
			.Columns(SDOCNO).Caption = Get_Caption(waScrItm, "SDOCNO")
			.Columns(SVDRCODE).Caption = Get_Caption(waScrItm, "SVDRCODE")
			.Columns(SVDRNAME).Caption = Get_Caption(waScrItm, "SVDRNAME")
			.Columns(SDOCDATE).Caption = Get_Caption(waScrItm, "SDOCDATE")
			.Columns(SDUEDATE).Caption = Get_Caption(waScrItm, "SDUEDATE")
			.Columns(SETADATE).Caption = Get_Caption(waScrItm, "SETADATE")
			.Columns(SQTY).Caption = Get_Caption(waScrItm, "SQTY")
			.Columns(SNET).Caption = Get_Caption(waScrItm, "SNET")
			.Columns(SORI).Caption = Get_Caption(waScrItm, "SORI")
		End With
		
		With tbrProcess
			'  .Buttons(tcConvert).ToolTipText = Get_Caption(waScrItm, tcConvert) & "(F2)"
			.Items.Item(tcCan).ToolTipText = Get_Caption(waScrItm, tcCan) & "(F3)"
			.Items.Item(tcCopy).ToolTipText = Get_Caption(waScrItm, tcCopy) & "(F8)"
			.Items.Item(tcFinish).ToolTipText = Get_Caption(waScrItm, tcFinish) & "(F10)"
			.Items.Item(tcExport).ToolTipText = Get_Caption(waScrItm, tcExport) & "(F9)"
			
			.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrItm, tcRefresh) & "(F7)"
			.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrItm, tcCancel) & "(F11)"
			.Items.Item(tcSAll).ToolTipText = Get_Caption(waScrItm, tcSAll) & "(F5)"
			.Items.Item(tcDAll).ToolTipText = Get_Caption(waScrItm, tcDAll) & "(F6)"
			.Items.Item(tcExit).ToolTipText = Get_Caption(waScrItm, tcExit) & "(F12)"
		End With
		
	End Sub
	
	
	Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
		
		With tblDetail
			'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
		End With
		
		If eventArgs.ColIndex = SSEL Then
			
			'   tblDetail.ReBind
			'   tblDetail.Bookmark = 0
			
		End If
		
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
				Case SSEL
					
					'   If .Columns(ColIndex).Text = "-1" Then
					'       Call Chk_Sel(.Row + To_Value(.FirstRow))
					'    End If
					
					' If Chk_grdSoNo(.Columns(ColIndex).Text) = False Then
					'    GoTo Tbl_BeforeColUpdate_Err
					' End If
					
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
						
						
						Select Case wsFormID
							Case "APV001", "APV002", "APV003", "APV004"
								
								frmAPV0011.InDocID = CInt(.Columns(SID).Text)
								frmAPV0011.InVdrNo = .Columns(SVDRCODE).Text
								frmAPV0011.TrnCd = wsTrnCd
								frmAPV0011.FormID = wsFormID & "1"
								frmAPV0011.UpdFlg = IIf(Opt_Getfocus(optDocType, 3, 0) = 0, True, False)
								frmAPV0011.ShowDialog()
								
								
						End Select
						
						
						
						
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
                    Call tblDetail_ButtonClick(tblDetail, New AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent(.Col))

                Case System.Windows.Forms.Keys.Return
                    Select Case .Col
                        Case SORI
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
                        Case SORI
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

                    Case SVDRNAME
                        lblDspItmDesc.Text = ""
                        lblDspItmDesc.Text = .Columns(SVDRNAME).Text


                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True



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
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).Button = True
					Case SVDRCODE
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).DataWidth = 10
					Case SVDRNAME
						.Columns(wiCtr).Width = 2500
						.Columns(wiCtr).DataWidth = 50
					Case SDOCDATE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
					Case SDUEDATE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
					Case SETADATE
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).DataWidth = 10
					Case SQTY
						.Columns(wiCtr).Width = 800
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
					Case SNET
						.Columns(wiCtr).Width = 1000
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).NumberFormat = gsAmtFmt
					Case SORI
						.Columns(wiCtr).Width = 1200
						.Columns(wiCtr).DataWidth = 15
						.Columns(wiCtr).Locked = False
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
		Dim wdCreLmt As Double
		Dim wdCreLft As Double
		Dim wsStatus As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		LoadRecord = False
		
		
		Select Case Opt_Getfocus(optDocType, 3, 0)
			Case 0
				wsStatus = "1"
			Case 1
				wsStatus = "4"
			Case 2
				wsStatus = "2"
		End Select
		
		Select Case wsTrnCd
			Case "PO"
				
				Select Case Opt_Getfocus(optDocType, 3, 0)
					Case 0
						
						wsSQL = "SELECT VDRNAME, POHDDOCID DOCID, POHDDOCNO DOCNO, POHDDOCDATE DOCDATE, POHDDUEDATE DUEDATE, POHDETADATE ETADATE, POHDVDRID, VDRCODE, POHDREFNO REFNO, SUM(PODTQTY) QTY, "
						wsSQL = wsSQL & " SUM(PODTNET) NET "
						wsSQL = wsSQL & " FROM  POPPOHD, POPPODT, MSTVENDOR "
						wsSQL = wsSQL & " WHERE POHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
						wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboVdrNoFr.Text & "' AND '" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), Set_Quote(cboVdrNoTo.Text)) & "'"
						wsSQL = wsSQL & " AND POHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
						wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
						wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
						wsSQL = wsSQL & " AND POHDVDRID = VDRID "
						wsSQL = wsSQL & " AND POHDSTATUS IN ('1','4') "
						wsSQL = wsSQL & " AND POHDPGMNO <> 'PN001' "
						wsSQL = wsSQL & " GROUP BY VDRNAME, POHDDOCID, POHDDOCNO, POHDDOCDATE, POHDDUEDATE, POHDETADATE, POHDVDRID, VDRCODE, POHDREFNO "
						wsSQL = wsSQL & " HAVING SUM(PODTQTY - PODTSCHQTY) > 0 "
						
					Case 1
						
						wsSQL = "SELECT VDRNAME, POHDDOCID DOCID, POHDDOCNO DOCNO, POHDDOCDATE DOCDATE, POHDDUEDATE DUEDATE, POHDETADATE ETADATE, POHDVDRID, VDRCODE, POHDREFNO REFNO, SUM(PODTQTY) QTY, "
						wsSQL = wsSQL & " SUM(PODTNET) NET "
						wsSQL = wsSQL & " FROM  POPPOHD, POPPODT, MSTVENDOR "
						wsSQL = wsSQL & " WHERE POHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
						wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboVdrNoFr.Text & "' AND '" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), Set_Quote(cboVdrNoTo.Text)) & "'"
						wsSQL = wsSQL & " AND POHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
						wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
						wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
						wsSQL = wsSQL & " AND POHDVDRID = VDRID "
						wsSQL = wsSQL & " AND POHDSTATUS IN ('1','4') "
						wsSQL = wsSQL & " AND POHDPGMNO <> 'PN001' "
						wsSQL = wsSQL & " GROUP BY VDRNAME, POHDDOCID, POHDDOCNO, POHDDOCDATE, POHDDUEDATE, POHDETADATE, POHDVDRID, VDRCODE, POHDREFNO "
						wsSQL = wsSQL & " HAVING SUM(PODTQTY - PODTSCHQTY) <= 0 "
						
						
					Case 2
						
						wsSQL = "SELECT VDRNAME, POHDDOCID DOCID, POHDDOCNO DOCNO, POHDDOCDATE DOCDATE, POHDDUEDATE DUEDATE, POHDETADATE ETADATE, POHDVDRID, VDRCODE, POHDREFNO REFNO, SUM(PODTQTY) QTY, "
						wsSQL = wsSQL & " SUM(PODTNET) NET "
						wsSQL = wsSQL & " FROM  POPPOHD, POPPODT, MSTVENDOR "
						wsSQL = wsSQL & " WHERE POHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
						wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboVdrNoFr.Text & "' AND '" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), Set_Quote(cboVdrNoTo.Text)) & "'"
						wsSQL = wsSQL & " AND POHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
						wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
						wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
						wsSQL = wsSQL & " AND POHDVDRID = VDRID "
						wsSQL = wsSQL & " AND POHDSTATUS = '" & wsStatus & "'"
						' wsSQL = wsSQL & " AND POHDPGMNO <> 'PN001' "
						wsSQL = wsSQL & " GROUP BY VDRNAME, POHDDOCID, POHDDOCNO, POHDDOCDATE, POHDDUEDATE, POHDETADATE, POHDVDRID, VDRCODE, POHDREFNO "
						
				End Select
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY POHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY POHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY VDRCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY POHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY POHDDOCDATE, POHDDOCNO " & wsSortBy
				End If
				
				
				
			Case "PV"
				
				wsSQL = "SELECT VDRNAME, PVHDDOCID DOCID, PVHDDOCNO DOCNO, PVHDDOCDATE DOCDATE, PVHDDUEDATE DUEDATE, PVHDETADATE ETADATE, PVHDVDRID, VDRCODE, PVHDREFNO REFNO, SUM(PVDTQTY) QTY, "
				wsSQL = wsSQL & " SUM(PVDTNET) NET "
				wsSQL = wsSQL & " FROM  POPPVHD, POPPVDT, MSTVENDOR "
				wsSQL = wsSQL & " WHERE PVHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboVdrNoFr.Text & "' AND '" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), Set_Quote(cboVdrNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND PVHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND PVHDDOCID = PVDTDOCID "
				wsSQL = wsSQL & " AND PVHDVDRID = VDRID "
				wsSQL = wsSQL & " AND PVHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY VDRNAME, PVHDDOCID, PVHDDOCNO, PVHDDOCDATE, PVHDDUEDATE, PVHDETADATE, PVHDVDRID, VDRCODE, PVHDREFNO "
				'wsSQL = wsSQL & " ORDER BY PVHDDOCDATE, PVHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY PVHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY PVHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY VDRCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY PVHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY PVHDDOCDATE, PVHDDOCNO " & wsSortBy
				End If
				
				
			Case "GR"
				
				wsSQL = "SELECT VDRNAME, GRHDDOCID DOCID, GRHDDOCNO DOCNO, GRHDDOCDATE DOCDATE, GRHDDUEDATE DUEDATE, GRHDETADATE ETADATE, GRHDVDRID, VDRCODE, GRHDREFNO REFNO, SUM(GRDTQTY) QTY, "
				wsSQL = wsSQL & " SUM(GRDTNET) NET "
				wsSQL = wsSQL & " FROM  POPGRHD, POPGRDT, MSTVENDOR "
				wsSQL = wsSQL & " WHERE GRHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboVdrNoFr.Text & "' AND '" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), Set_Quote(cboVdrNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND GRHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND GRHDDOCID = GRDTDOCID "
				wsSQL = wsSQL & " AND GRHDVDRID = VDRID "
				wsSQL = wsSQL & " AND GRHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY VDRNAME, GRHDDOCID, GRHDDOCNO, GRHDDOCDATE, GRHDDUEDATE, GRHDETADATE, GRHDVDRID, VDRCODE, GRHDREFNO "
				'wsSQL = wsSQL & " ORDER BY GRHDDOCDATE, GRHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY GRHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY GRHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY VDRCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY GRHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY GRHDDOCDATE, GRHDDOCNO " & wsSortBy
				End If
				
			Case "PR"
				
				wsSQL = "SELECT VDRNAME, PRHDDOCID DOCID, PRHDDOCNO DOCNO, PRHDDOCDATE DOCDATE, PRHDDUEDATE DUEDATE, PRHDRELDATE ETADATE, PRHDVDRID, VDRCODE, PRHDREFNO REFNO, SUM(PRDTQTY) QTY, "
				wsSQL = wsSQL & " SUM(PRDTNET) NET "
				wsSQL = wsSQL & " FROM  POPPRHD, POPPRDT, MSTVENDOR "
				wsSQL = wsSQL & " WHERE PRHDDOCNO BETWEEN '" & cboDocNoFr.Text & "' AND '" & IIf(Trim(cboDocNoTo.Text) = "", New String("z", 15), Set_Quote(cboDocNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND VDRCODE BETWEEN '" & cboVdrNoFr.Text & "' AND '" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 10), Set_Quote(cboVdrNoTo.Text)) & "'"
				wsSQL = wsSQL & " AND PRHDCTLPRD BETWEEN '" & IIf(Trim(medPrdFr.Text) = "/", New String("000000", 6), VB.Left(medPrdFr.Text, 4) & VB.Right(medPrdFr.Text, 2)) & "'"
				wsSQL = wsSQL & " AND '" & IIf(Trim(medPrdTo.Text) = "/", New String("999999", 6), VB.Left(medPrdTo.Text, 4) & VB.Right(medPrdTo.Text, 2)) & "'"
				wsSQL = wsSQL & " AND PRHDDOCID = PRDTDOCID "
				wsSQL = wsSQL & " AND PRHDVDRID = VDRID "
				wsSQL = wsSQL & " AND PRHDSTATUS = '" & wsStatus & "'"
				wsSQL = wsSQL & " GROUP BY VDRNAME, PRHDDOCID, PRHDDOCNO, PRHDDOCDATE, PRHDDUEDATE, PRHDRELDATE, PRHDVDRID, VDRCODE, PRHDREFNO "
				'    wsSQL = wsSQL & " ORDER BY PRHDDOCDATE, PRHDDOCNO "
				
				If wiSort = 0 Then
					wsSQL = wsSQL & " ORDER BY PRHDDOCNO " & wsSortBy
				ElseIf wiSort = 1 Then 
					wsSQL = wsSQL & " ORDER BY PRHDDOCDATE " & wsSortBy
				ElseIf wiSort = 2 Then 
					wsSQL = wsSQL & " ORDER BY VDRCODE " & wsSortBy
				ElseIf wiSort = 3 Then 
					wsSQL = wsSQL & " ORDER BY PRHDREFNO " & wsSortBy
				Else
					wsSQL = wsSQL & " ORDER BY PRHDDOCDATE, PRHDDOCNO " & wsSortBy
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
			'UPGRADE_ISSUE: Form property frmAPV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If



        With waResult
            .ReDim(0, -1, SSEL, SID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF

                '    wdCreLft = Get_CreditLimit(ReadRs(rsRcd, "SNHDVDRID"), gsSystemDate)
                wdCreLft = 0

                .AppendRows()
                waResult.get_Value(.get_UpperBound(1), SSEL) = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCNO) = ReadRs(rsRcd, "DOCNO")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SVDRCODE) = ReadRs(rsRcd, "VDRCODE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SVDRNAME) = ReadRs(rsRcd, "VDRNAME")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDOCDATE) = ReadRs(rsRcd, "DOCDATE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SDUEDATE) = ReadRs(rsRcd, "DUEDATE")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SETADATE) = ReadRs(rsRcd, "ETADATE")
                'waResult(.UpperBound(1), SQTY) = Format(To_Value(ReadRs(rsRcd, "QTY")), gsQtyFmt)
                waResult.get_Value(.get_UpperBound(1), SQTY) = VB6.Format(To_Value(ReadRs(rsRcd, "QTY")), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), SNET) = VB6.Format(To_Value(ReadRs(rsRcd, "NET")), gsAmtFmt)
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), SORI) = ReadRs(rsRcd, "REFNO")
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
        'UPGRADE_ISSUE: Form property frmAPV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wsVdrNo As String
        Dim wsStorep As String

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
            Case 2
                gsMsg = "你是否確認要轉換成發票?"
            Case 3
                gsMsg = "你是否取消此文件?"

                If Opt_Getfocus(optDocType, 3, 0) = 2 Then
                    inActFlg = 6
                    gsMsg = "你是否完全刪除此文件?"
                End If

            Case 4
                gsMsg = "你是否拷貝此文件?"
            Case 5
                If wsFormID = "APV001" Then
                    gsMsg = "你是否確認要轉換成進貨單?"
                Else
                    gsMsg = "你是否確認要批核此文件?"
                End If
        End Select

        If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        wsMark = "0"



        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon


        If waResult.get_UpperBound(1) >= 0 Then
            adcmdSave.CommandText = "USP_APV001A"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then
                    Call SetSPPara(adcmdSave, 1, inActFlg)
                    Call SetSPPara(adcmdSave, 2, wsTrnCd)
                    Call SetSPPara(adcmdSave, 3, waResult.get_Value(wiCtr, SID))
                    Call SetSPPara(adcmdSave, 4, "")
                    Call SetSPPara(adcmdSave, 5, wsFormID)
                    Call SetSPPara(adcmdSave, 6, gsUserID)
                    Call SetSPPara(adcmdSave, 7, wsGenDte)

                    wsMark = waResult.get_Value(wiCtr, SID)
                    wsVdrNo = waResult.get_Value(wiCtr, SVDRCODE)
                    adcmdSave.Execute()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    wsDocNo = GetSPPara(adcmdSave, 8)

                    If wiActFlg = 5 And wsFormID = "APV001" Then
                        If Trim(wsDocNo) = "" Then
                            gsMsg = "採購單:" & waResult.get_Value(wiCtr, SDOCNO) & "已全進貨!不能再進"
                        Else
                            gsMsg = "進貨單:" & wsDocNo & "文件已完成!"
                        End If
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                    If wiActFlg = 5 And wsFormID = "APV003" Then
                        If Trim(wsDocNo) <> "0" Then
                            gsMsg = "物料:" & wsDocNo & "不足!不能退貨!"
                            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        End If
                    End If
                    If wiActFlg = 5 And wsFormID = "APV004" Then
                        If Trim(wsDocNo) <> "0" Then
                            gsMsg = "物料:" & wsDocNo & "沒有貨架資料!不能進貨!"
                            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                        End If
                    End If
                End If
            Next
        End If



        cnCon.CommitTrans()


        Select Case wiActFlg
            Case 1
                gsMsg = "已完成!"
            Case 2, 4
                If wsDocNo <> "" Then
                    gsMsg = "文件 ： " & wsDocNo & " 已完成!"
                Else
                    gsMsg = "沒有餘貨, 不能轉換!"
                End If
            Case 3
                gsMsg = "文件已取消完成!"
            Case 5
                gsMsg = "行動完成!"
        End Select
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)



        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

        Call LoadRecord()

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


        InputValidation = True

        Exit Function

InputValidation_Err:
        gsMsg = Err.Description
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

    End Function

    Private Sub cmdExport()

        Dim wsGenDte As String
        'Dim adcmdExport As New ADODB.Command
        Dim wiCtr As Short
        Dim wsTrnCode As String
        Dim wsVdrNo As String
        Dim wsStorep As String
        Dim wiMod As Short
        Dim wsPath As String
        Dim wsDoc As String




        On Error GoTo cmdExport_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = gsSystemDate

        If InputValidation() = False Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        '' Last Check when Add

        gsMsg = "你是否確認要匯出文件？"
        If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        If wsFormID = "APV001" Then
            wsTrnCode = "PO"
        Else
            wsTrnCode = "GR"
        End If


        If Trim(gsHHPath) <> "" Then
            wsPath = gsHHPath & "send\HHTORDER.TXT"
        Else
            wsPath = My.Application.Info.DirectoryPath & "send\HHTORDER.TXT"
        End If

        '    cnCon.BeginTrans
        '    Set adcmdExport.ActiveConnection = cnCon

        wiMod = 1
        wsDoc = ""
        If waResult.get_UpperBound(1) >= 0 Then

            For wiCtr = 0 To waResult.get_UpperBound(1)
                If Trim(waResult.get_Value(wiCtr, SSEL)) = "-1" Then



                    If ExportToHHFile(wsPath, wsTrnCode, waResult.get_Value(wiCtr, SID), wiMod, "") = False Then
                        gsMsg = waResult.get_Value(wiCtr, SDOCNO) & " 匯出Error!"
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    Else
                        wiMod = 2
                        wsDoc = wsDoc & IIf(wsDoc = "", waResult.get_Value(wiCtr, SID), "," & waResult.get_Value(wiCtr, SID))

                    End If

                End If
            Next wiCtr
        End If

        If PrintExcel_BC("ITM", wsDoc) = False Then
            gsMsg = " 匯出BarCode Error!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        End If

        If PrintExcel_BC("JOB", wsDoc) = False Then
            gsMsg = " 匯出Job Error!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
        End If



        '   cnCon.CommitTrans
        Sleep((500))
        If SendToHH(wsPath) = True Then

            gsMsg = "匯出文件已完成!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

        End If



        ' Set adcmdExport = Nothing

        Call LoadRecord()

        Cursor = System.Windows.Forms.Cursors.Default

        Exit Sub

cmdExport_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        '  cnCon.RollbackTrans
        '  Set adcmdExport = Nothing

    End Sub





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
        'UPGRADE_ISSUE: Form property frmAPV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
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
				Case SVDRCODE
					wiSort = 2
					cmdRefresh()
				Case SORI
					wiSort = 3
					cmdRefresh()
			End Select
		End With
		
		
		Exit Sub
		
tblDetail_HeadClick_Err: 
		MsgBox("Check tblDeiail HeadClick!")
		
	End Sub
End Class