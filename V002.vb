Option Strict Off
Option Explicit On
Friend Class frmV002
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboVdrNoFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(3)
		wsSelection(1) = lblVdrNoFr.Text & " " & Set_Quote(cboVdrNoFr.Text) & " " & lblVdrNoTo.Text & " " & Set_Quote(cboVdrNoTo.Text)
		wsSelection(2) = lblSaleCode.Text & " " & Set_Quote(cboSaleCode.Text)
		wsSelection(3) = lblActive.Text & " " & IIf(chkActive.CheckState = 1, "Y", "N")
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTV002 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Get_TableInfo("MstSalesman", "SaleCode= '" & Set_Quote(cboSaleCode.Text) & "' AND SaleStatus ='1'", "SaleID") & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboVdrNoTo.Text) = "", New String("z", 15), Get_TableInfo("MstSalesman", "SaleCode= '" & Set_Quote(cboSaleCode.Text) & "' AND SaleStatus ='1'", "SaleID")) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboSaleCode.Text) = "", "0", Get_TableInfo("MstSalesman", "SaleCode= '" & Set_Quote(cboSaleCode.Text) & "' AND SaleStatus ='1'", "SaleID")) & "', "
		wsSQL = wsSQL & "'" & IIf(chkActive.CheckState = 1, "Y", "N") & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTV002"
		Else
			wsRptName = "RPTV002"
		End If
		
		NewfrmPrint.ReportID = "V002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "V002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboSaleCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSaleCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboSaleCode
		
		Select Case gsLangID
			Case "1"
				wsSQL = "SELECT SaleCode, SaleName FROM MstSalesman WHERE SaleCode LIKE '%" & IIf(cboSaleCode.SelectionLength > 0, "", Set_Quote(cboSaleCode.Text)) & "%' AND SaleStatus <>'2' "
			Case "2"
				wsSQL = "SELECT SaleCode, SaleName FROM MstSalesman WHERE SaleCode LIKE '%" & IIf(cboSaleCode.SelectionLength > 0, "", Set_Quote(cboSaleCode.Text)) & "%' AND SaleStatus <>'2' "
			Case Else
				
		End Select
		
		wsSQL = wsSQL & " ORDER BY SaleCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboSaleCode.Left)), VB6.PixelsToTwipsY(cboSaleCode.Top) + VB6.PixelsToTwipsY(cboSaleCode.Height), tblCommon, wsFormID, "TBLSALECODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboSaleCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSaleCode.Enter
		FocusMe(cboSaleCode)
		wcCombo = cboSaleCode
	End Sub
	
	Private Sub cboSaleCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboSaleCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboSaleCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            chkActive.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboSaleCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSaleCode.Leave
        FocusMe(cboSaleCode, True)
    End Sub

    Private Sub cboVdrNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoTo.Leave
        FocusMe(cboVdrNoTo, True)
    End Sub

    Private Sub chkActive_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkActive.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboVdrNoFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmV002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.F9
                Call cmdOK()

            Case System.Windows.Forms.Keys.F11
                Call cmdCancel()

            Case System.Windows.Forms.Keys.F12
                Me.Close()

        End Select
    End Sub

    Private Sub frmV002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call Ini_Form()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Form()

        Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
        Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)

        wsFormID = "V002"

    End Sub

    Private Sub Ini_Scr()

        Me.Text = wsFormCaption

        tblCommon.Visible = False
        cboVdrNoFr.Text = ""
        cboVdrNoTo.Text = ""
        cboSaleCode.Text = ""

        wgsTitle = "Vendor List"
        chkActive.CheckState = System.Windows.Forms.CheckState.Unchecked

    End Sub

    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboVdrNoTo = False Then
            cboVdrNoTo.Focus()
            Exit Function
        End If

        InputValidation = True

    End Function

    'UPGRADE_WARNING: Event frmV002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmV002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(3840)
            Me.Width = VB6.TwipsToPixelsX(9315)
        End If
    End Sub

    Private Sub frmV002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        wcCombo = Nothing
        'UPGRADE_NOTE: Object frmV002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing

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

    Private Sub Ini_Caption()
        Call Get_Scr_Item(wsFormID, waScrItm)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        lblTitle.Text = Get_Caption(waScrItm, "TITLE")
        txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
        lblVdrNoFr.Text = Get_Caption(waScrItm, "VDRNOFR")
        lblVdrNoTo.Text = Get_Caption(waScrItm, "VDRNOTO")
        lblSaleCode.Text = Get_Caption(waScrItm, "SALECODE")
        lblActive.Text = Get_Caption(waScrItm, "ACTIVE")

    End Sub

    Private Function chk_cboVdrNoTo() As Boolean
        chk_cboVdrNoTo = False

        If UCase(cboVdrNoFr.Text) > UCase(cboVdrNoTo.Text) Then
            wsMsg = "To > From!"
            MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)

            Exit Function
        End If

        chk_cboVdrNoTo = True
    End Function

    Private Sub cboVdrNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrNoFr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrNoFr

        If gsLangID = "1" Then
            wsSQL = "SELECT VDRCODE, VDRNAME, VDRTEL, VDRFAX "
            wsSQL = wsSQL & " FROM MstVendor "
            wsSQL = wsSQL & " WHERE VDRCODE LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
            wsSQL = wsSQL & " AND VDRSTATUS  <> '2' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & " ORDER BY VDRCODE "
        Else
            wsSQL = "SELECT VDRCODE, VDRNAME, VDRTEL, VDRFAX "
            wsSQL = wsSQL & " FROM MstVendor "
            wsSQL = wsSQL & " WHERE VDRCODE LIKE '%" & IIf(cboVdrNoFr.SelectionLength > 0, "", Set_Quote(cboVdrNoFr.Text)) & "%' "
            wsSQL = wsSQL & " AND VDRSTATUS  <> '2' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & " ORDER BY VDRCODE "
        End If
        Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboVdrNoFr.Left)), VB6.PixelsToTwipsY(cboVdrNoFr.Top) + VB6.PixelsToTwipsY(cboVdrNoFr.Height), tblCommon, wsFormID, "TBLVDRNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Call chk_InpLen(cboVdrNoFr, 15, KeyAscii)

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

        wcCombo = cboVdrNoTo

        If gsLangID = "1" Then
            wsSQL = "SELECT VDRCODE, VDRNAME, VDRTEL, VDRFAX "
            wsSQL = wsSQL & " FROM MstVendor "
            wsSQL = wsSQL & " WHERE VDRCODE LIKE '%" & IIf(cboVdrNoTo.SelectionLength > 0, "", Set_Quote(cboVdrNoTo.Text)) & "%' "
            wsSQL = wsSQL & " AND VDRSTATUS  <> '2' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & " ORDER BY VDRCODE "
        Else
            wsSQL = "SELECT VDRCODE, VDRNAME, VDRTEL, VDRFAX "
            wsSQL = wsSQL & " FROM MstVendor "
            wsSQL = wsSQL & " WHERE VDRCODE LIKE '%" & IIf(cboVdrNoTo.SelectionLength > 0, "", Set_Quote(cboVdrNoTo.Text)) & "%' "
            wsSQL = wsSQL & " AND VDRSTATUS  <> '2' "
            wsSQL = wsSQL & " AND VdrInactive = 'N' "
            wsSQL = wsSQL & " ORDER BY VDRCODE "
        End If
        Call Ini_Combo(4, wsSQL, (VB6.PixelsToTwipsX(cboVdrNoTo.Left)), VB6.PixelsToTwipsY(cboVdrNoTo.Top) + VB6.PixelsToTwipsY(cboVdrNoTo.Height), tblCommon, wsFormID, "TBLVDRNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

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
        Call chk_InpLen(cboVdrNoTo, 15, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboVdrNoTo = False Then
                cboVdrNoTo.Focus()
                GoTo EventExitSub
            End If

            cboSaleCode.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case tcGo
                Call cmdOK()
            Case tcCancel
                Call cmdCancel()
            Case tcExit
                Me.Close()
        End Select

    End Sub

    Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
        FocusMe(txtTitle)
    End Sub

    Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtTitle, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboVdrNoFr.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
End Class