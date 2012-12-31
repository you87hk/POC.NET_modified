Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmV001
	Inherits System.Windows.Forms.Form
	
	Private wsFormCaption As String
	Private waScrItm As New XArrayDBObject.XArrayDB
	Private waResult As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	
	Private Const tcOpen As String = "Open"
	Private Const tcAdd As String = "Add"
	Private Const tcEdit As String = "Edit"
	Private Const tcDelete As String = "Delete"
	Private Const tcSave As String = "Save"
	Private Const tcCancel As String = "Cancel"
	Private Const tcFind As String = "Find"
	Private Const tcExit As String = "Exit"
	
	Private Const PERIOD As Short = 0
	Private Const SALES As Short = 1
	Private Const DEPOSIT As Short = 2
	Private Const BALID As Short = 3
	
	Private wbErr As Boolean
	
	Private wsActNam(4) As String
	
	Private wiAction As Short
	Private wlKey As Integer
	Private wsFormID As String
	Private wsConnTime As String
	Private wcCombo As System.Windows.Forms.Control
	Private wsOldSaleCode As String
	Private wlSalesmanID As Integer
	
	Private Const wsKeyType As String = "MstVendor"
	Private wsUsrId As String
	Private wsTrnCd As String
	
	Private wsOldTerrCode As String
	Private wsOldPayCode As String
	
	Private Sub cboVdrMLCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrMLCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboVdrMLCode
		
		wsSQL = "SELECT MLCode, MLDesc FROM MstMerchClass WHERE MLStatus = '1'"
		wsSQL = wsSQL & "ORDER BY MLCode "
		Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboVdrMLCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboVdrMLCode.Top) + VB6.PixelsToTwipsY(cboVdrMLCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top), tblCommon, "V001", "TBLVDRML", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cboVdrMLCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrMLCode.Enter
		FocusMe(cboVdrMLCode)
	End Sub
	
	Private Sub cboVdrMLCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrMLCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim wsDesc As String
		
		Call chk_InpLen(cboVdrMLCode, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboVdrMLCode = False Then
                GoTo EventExitSub
            End If

            tabDetailInfo.SelectedIndex = 2
            cboVdrCurr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVdrMLCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrMLCode.Leave
        FocusMe(cboVdrMLCode, True)
    End Sub

    Private Sub cboVdrRgnCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrRgnCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrRgnCode

        wsSQL = "SELECT RgnCode, RgnDesc FROM MstRegion WHERE RgnStatus = '1'"
        wsSQL = wsSQL & "ORDER BY RgnCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboVdrRgnCode.Left)), VB6.PixelsToTwipsY(cboVdrRgnCode.Top) + VB6.PixelsToTwipsY(cboVdrRgnCode.Height), tblCommon, "V001", "TBLVDRRGN", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboVdrRgnCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrRgnCode.Enter
        FocusMe(cboVdrRgnCode)
    End Sub

    Private Sub cboVdrRgnCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrRgnCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim wsDesc As String

        Call chk_InpLen(cboVdrRgnCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboVdrRgnCode = False Then
                GoTo EventExitSub
            End If

            chkInActive.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVdrRgnCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrRgnCode.Leave
        FocusMe(cboVdrRgnCode, True)
    End Sub

    Private Sub cboVdrSaleCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrSaleCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrSaleCode

        wsSQL = "SELECT SaleCode, SaleName FROM MstSalesman WHERE SaleStatus = '1'"
        wsSQL = wsSQL & " and SaleType = 'S' "
        wsSQL = wsSQL & "ORDER BY SaleCode "
        Call Ini_Combo(2, wsSQL, VB6.PixelsToTwipsX(cboVdrSaleCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboVdrSaleCode.Top) + VB6.PixelsToTwipsY(cboVdrSaleCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(tbrProcess.Height), tblCommon, "V001", "TBLSLM", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboVdrSaleCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrSaleCode.Enter
        FocusMe(cboVdrSaleCode)
    End Sub

    Private Sub cboVdrSaleCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrSaleCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim sSalesName As String

        Call chk_InpLen(cboVdrSaleCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboVdrSaleCode(sSalesName) = True Then
                If wsOldSaleCode <> cboVdrSaleCode.Text Then
                    lblDspVdrSaleName.Text = sSalesName
                    wsOldSaleCode = cboVdrSaleCode.Text
                End If
                Me.tabDetailInfo.SelectedIndex = 2
                cboVdrPayCode.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVdrSaleCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrSaleCode.Leave
        FocusMe(cboVdrSaleCode, True)
    End Sub

    Private Sub frmV001_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        Select Case KeyCode
            Case System.Windows.Forms.Keys.PageDown
                KeyCode = 0
                If tabDetailInfo.SelectedIndex < tabDetailInfo.TabPages.Count() - 1 Then
                    tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex + 1
                    Exit Sub
                End If
            Case System.Windows.Forms.Keys.PageUp
                KeyCode = 0
                If tabDetailInfo.SelectedIndex > 0 Then
                    tabDetailInfo.SelectedIndex = tabDetailInfo.SelectedIndex - 1
                    Exit Sub
                End If

            Case System.Windows.Forms.Keys.F6
                Call cmdOpen()


            Case System.Windows.Forms.Keys.F2
                If wiAction = DefaultPage Then Call cmdNew()


            Case System.Windows.Forms.Keys.F5
                If wiAction = DefaultPage Then Call cmdEdit()


            Case System.Windows.Forms.Keys.F3
                If wiAction = DefaultPage Then Call cmdDel()

            Case System.Windows.Forms.Keys.F9

                If tbrProcess.Items.Item(tcFind).Enabled = True Then
                    Call cmdFind()
                End If

            Case System.Windows.Forms.Keys.F10

                If tbrProcess.Items.Item(tcSave).Enabled = True Then
                    If tbrProcess.Items.Item(tcSave).Enabled = True Then
                        Call cmdSave()
                    End If
                End If

            Case System.Windows.Forms.Keys.F11

                If wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec Then Call cmdCancel()

            Case System.Windows.Forms.Keys.F12

                Me.Close()

        End Select
    End Sub

    Private Sub frmV001_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call IniForm()
        Call Ini_Grid()
        Call Ini_Caption()
        Call Ini_Scr()

        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    'UPGRADE_WARNING: Event frmV001.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmV001_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        '-- Resize, not maximum and minimax.
        If Me.WindowState = 0 Then
            Me.Height = VB6.TwipsToPixelsY(6660)
            Me.Width = VB6.TwipsToPixelsX(10020)
        End If
    End Sub

    '-- Set toolbar buttons status in different mode, Default, AddEdit, None.
    Public Sub SetButtonStatus(ByVal sStatus As String)
        Select Case sStatus
            Case "Default"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = True
                    .Items.Item(tcEdit).Enabled = True
                    .Items.Item(tcDelete).Enabled = True
                    .Items.Item(tcSave).Enabled = False
                    .Items.Item(tcCancel).Enabled = False
                    .Items.Item(tcFind).Enabled = False
                    .Items.Item(tcExit).Enabled = True
                End With

            Case "AfrActAdd"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcEdit).Enabled = False
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = False
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcFind).Enabled = False
                    .Items.Item(tcExit).Enabled = True
                End With

            Case "AfrActEdit"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcEdit).Enabled = False
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = False
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcFind).Enabled = True
                    .Items.Item(tcExit).Enabled = True
                End With


            Case "AfrKey"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcEdit).Enabled = False
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = True
                    .Items.Item(tcCancel).Enabled = True
                    .Items.Item(tcFind).Enabled = False
                    .Items.Item(tcExit).Enabled = True
                End With


            Case "ReadOnly"
                With tbrProcess
                    .Items.Item(tcOpen).Enabled = True
                    .Items.Item(tcAdd).Enabled = False
                    .Items.Item(tcDelete).Enabled = False
                    .Items.Item(tcSave).Enabled = False
                    .Items.Item(tcCancel).Enabled = False
                    .Items.Item(tcFind).Enabled = True
                    .Items.Item(tcExit).Enabled = True

                End With



        End Select
    End Sub



    '-- Set field status, Default, Add, Edit.
    Public Sub SetFieldStatus(ByVal sStatus As String)
        Select Case sStatus
            Case "Default"
                Me.txtVdrCode.Enabled = False
                Me.cboVdrCode.Enabled = False
                Me.txtVdrName.Enabled = False
                Me.txtVdrContactName.Enabled = False
                Me.txtVdrTel.Enabled = False
                Me.txtVdrFax.Enabled = False
                Me.txtVdrEmail.Enabled = False
                Me.txtVdrAddress1.Enabled = False
                Me.txtVdrAddress2.Enabled = False
                Me.txtVdrAddress3.Enabled = False
                Me.txtVdrAddress4.Enabled = False
                Me.chkInActive.Enabled = False
                Me.txtVdrPayTerm.Enabled = False

                Me.cboVdrCurr.Enabled = False
                Me.txtVdrCreditLimit.Enabled = False
                Me.txtVdrShipName.Enabled = False
                Me.txtVdrShipAdd1.Enabled = False
                Me.txtVdrShipAdd2.Enabled = False
                Me.txtVdrShipAdd3.Enabled = False
                Me.txtVdrShipAdd4.Enabled = False
                Me.txtVdrShipContactPerson.Enabled = False
                Me.txtVdrShipTel.Enabled = False
                Me.txtVdrShipFax.Enabled = False
                Me.txtVdrShipEmail.Enabled = False
                Me.txtVdrSpecDis.Enabled = False
                Me.txtVdrRemark.Enabled = False

                Me.cboVdrPayCode.Enabled = False
                Me.cboVdrMLCode.Enabled = False
                Me.txtVdrContactName1.Enabled = False
                Me.cboVdrRgnCode.Enabled = False
                Me.cboVdrSaleCode.Enabled = False

            Case "AfrActAdd"
                Me.txtVdrCode.Enabled = True
                Me.txtVdrCode.Visible = True

                Me.cboVdrCode.Enabled = False
                Me.cboVdrCode.Visible = False

            Case "AfrActEdit"
                Me.txtVdrCode.Enabled = False
                Me.txtVdrCode.Visible = False

                Me.cboVdrCode.Enabled = True
                Me.cboVdrCode.Visible = True


            Case "AfrKey"
                Me.txtVdrCode.Enabled = False
                Me.cboVdrCode.Enabled = False

                Me.txtVdrName.Enabled = True
                Me.txtVdrContactName.Enabled = True
                Me.txtVdrTel.Enabled = True
                Me.txtVdrFax.Enabled = True
                Me.txtVdrEmail.Enabled = True
                Me.txtVdrAddress1.Enabled = True
                Me.txtVdrAddress2.Enabled = True
                Me.txtVdrAddress3.Enabled = True
                Me.txtVdrAddress4.Enabled = True
                Me.chkInActive.Enabled = True

                Me.txtVdrPayTerm.Enabled = True
                Me.cboVdrCurr.Enabled = True
                Me.txtVdrCreditLimit.Enabled = True
                Me.txtVdrShipName.Enabled = True
                Me.txtVdrShipAdd1.Enabled = True
                Me.txtVdrShipAdd2.Enabled = True
                Me.txtVdrShipAdd3.Enabled = True
                Me.txtVdrShipAdd4.Enabled = True
                Me.txtVdrShipContactPerson.Enabled = True
                Me.txtVdrShipTel.Enabled = True
                Me.txtVdrShipFax.Enabled = True
                Me.txtVdrShipEmail.Enabled = True
                Me.txtVdrSpecDis.Enabled = True
                Me.txtVdrRemark.Enabled = True

                Me.cboVdrMLCode.Enabled = True
                Me.txtVdrContactName1.Enabled = True
                Me.cboVdrPayCode.Enabled = True
                Me.cboVdrRgnCode.Enabled = True
                Me.cboVdrSaleCode.Enabled = True
        End Select
    End Sub

    '-- Input validation checking.
    Private Function InputValidation() As Boolean
        InputValidation = False

        If Chk_txtVdrName = False Then
            Exit Function
        End If

        If Chk_cboVdrMLCode = False Then
            Exit Function
        End If

        If Chk_cboVdrRgnCode = False Then
            Exit Function
        End If

        If Chk_cboVdrSaleCode("") = False Then
            Exit Function
        End If

        If Chk_cboVdrCurr = False Then
            Exit Function
        End If

        If Chk_cboVdrPayCode("") = False Then
            Exit Function
        End If

        InputValidation = True
    End Function

    Public Function LoadRecord() As Boolean
        Dim wsSQL As String
        Dim wsSaleName As String
        Dim wsSaleCode As String
        Dim rsRcd As New ADODB.Recordset

        wsSQL = "SELECT MstVendor.VdrCode, MstVendor.* "
        wsSQL = wsSQL & "From MstVendor "
        wsSQL = wsSQL & "WHERE (((MstVendor.VdrCode)='" & Set_Quote(cboVdrCode.Text) & "') AND ((MstVendor.VdrStatus)='1'));"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount = 0 Then
            LoadRecord = False
            wlKey = 0
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wlKey = ReadRs(rsRcd, "VdrID")

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrName.Text = ReadRs(rsRcd, "VdrName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrContactName.Text = ReadRs(rsRcd, "VdrContactName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrContactName1.Text = ReadRs(rsRcd, "VdrContactName1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrTel.Text = ReadRs(rsRcd, "VdrTel")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrFax.Text = ReadRs(rsRcd, "VdrFax")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrEmail.Text = ReadRs(rsRcd, "VdrEmail")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrAddress1.Text = ReadRs(rsRcd, "VdrAddress1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrAddress2.Text = ReadRs(rsRcd, "VdrAddress2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrAddress3.Text = ReadRs(rsRcd, "VdrAddress3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrAddress4.Text = ReadRs(rsRcd, "VdrAddress4")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Call Set_CheckValue(chkInActive, ReadRs(rsRcd, "VdrInActive"))
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboVdrPayCode.Text = ReadRs(rsRcd, "VdrPayCode")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrPayTerm.Text = ReadRs(rsRcd, "VdrPayTerm")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboVdrCurr.Text = ReadRs(rsRcd, "VdrCurr")
            Me.txtVdrCreditLimit.Text = VB6.Format(To_Value(ReadRs(rsRcd, "VdrCreditLimit")), gsAmtFmt)
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipName.Text = ReadRs(rsRcd, "VdrShipName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipAdd1.Text = ReadRs(rsRcd, "VdrShipAdd1")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipAdd2.Text = ReadRs(rsRcd, "VdrShipAdd2")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipAdd3.Text = ReadRs(rsRcd, "VdrShipAdd3")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipAdd4.Text = ReadRs(rsRcd, "VdrShipAdd4")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipContactPerson.Text = ReadRs(rsRcd, "VdrShipContactPerson")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipTel.Text = ReadRs(rsRcd, "VdrShipTel")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipFax.Text = ReadRs(rsRcd, "VdrShipFax")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrShipEmail.Text = ReadRs(rsRcd, "VdrShipEmail")
            Me.txtVdrSpecDis.Text = VB6.Format(To_Value(ReadRs(rsRcd, "VdrSpecDis")), gsAmtFmt)
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtVdrRemark.Text = ReadRs(rsRcd, "VdrRemark")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboVdrRgnCode.Text = ReadRs(rsRcd, "VdrRgnCode")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.cboVdrMLCode.Text = ReadRs(rsRcd, "VdrMLCode")
            Me.lblDspCrtDate.Text = Dsp_Date(ReadRs(rsRcd, "VdrCrtDate"))

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.lblDspVdrLastUpd.Text = ReadRs(rsRcd, "VdrLastUpd")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.lblDspVdrLastUpdDate.Text = ReadRs(rsRcd, "VdrLastUpdDate")
            Me.lblDspVdrOpenBal.Text = VB6.Format(To_Value(ReadRs(rsRcd, "VdrOpenBal")), gsAmtFmt)

            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            wlSalesmanID = ReadRs(rsRcd, "VdrSaleID")
            LoadSaleByID(wsSaleCode, wsSaleName, wlSalesmanID)
            cboVdrSaleCode.Text = wsSaleCode
            lblDspVdrSaleName.Text = wsSaleName

            lblDspVdrRgnDesc.Text = LoadDescByCode("MstRegion", "RgnCode", "RgnDesc", cboVdrRgnCode.Text, True)
            lblDspVdrMLDesc.Text = LoadDescByCode("MstMerchClass", "MLCode", "MLDesc", cboVdrMLCode.Text, True)

            wsOldPayCode = cboVdrPayCode.Text
            Call LoadSaleInfo()
            LoadRecord = True
        End If

        rsRcd.Close()

        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function


    Private Sub frmV001_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If SaveData = True Then
            'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = True
            Exit Sub
        End If
        Call UnLockAll(wsConnTime, wsFormID)

        'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrItm = Nothing
        'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        waScrToolTip = Nothing
        'UPGRADE_NOTE: Object frmV001 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
    End Sub

    Private Sub tabDetailInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabDetailInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabDetailInfo.SelectedIndex()
        If tabDetailInfo.SelectedIndex = 0 Then
            If txtVdrAddress1.Enabled And txtVdrAddress1.Visible Then
                txtVdrContactName1.Focus()
            End If
        ElseIf tabDetailInfo.SelectedIndex = 1 Then
            If txtVdrShipName.Enabled And txtVdrShipName.Visible Then
                txtVdrShipName.Focus()
            End If
        ElseIf tabDetailInfo.SelectedIndex = 2 Then
            If txtVdrCreditLimit.Enabled And txtVdrCreditLimit.Visible Then
                cboVdrSaleCode.Focus()
            End If
        End If
        PreviousTab = tabDetailInfo.SelectedIndex()
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click, _tbrProcess_Button7.Click, _tbrProcess_Button8.Click, _tbrProcess_Button9.Click, _tbrProcess_Button10.Click, _tbrProcess_Button11.Click, _tbrProcess_Button12.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case tcOpen
                Call cmdOpen()

            Case tcAdd
                Call cmdNew()

            Case tcEdit
                Call cmdEdit()

            Case tcDelete

                Call cmdDel()

            Case tcSave

                Call cmdSave()

            Case tcCancel

                If tbrProcess.Items.Item(tcSave).Enabled = True Then
                    gsMsg = "你是否確定儲存現時之變更而離開?"
                    If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                        Call cmdCancel()
                    End If
                Else
                    Call cmdCancel()
                End If

            Case tcFind

                Call OpenPromptForm()

            Case tcExit

                Me.Close()

        End Select
    End Sub

    Private Sub IniForm()
        Me.KeyPreview = True
        '   Me.Left = 0
        '   Me.Top = 0
        '   Me.Width = Screen.Width
        '   Me.Height = Screen.Height


        wsConnTime = Dsp_Date(Now, True)
        wsFormID = "V001"
    End Sub

    Private Sub Ini_Scr()

        Dim MyControl As System.Windows.Forms.Control

        For Each MyControl In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            Select Case TypeName(MyControl)
                Case "ComboBox"
                    'UPGRADE_WARNING: Couldn't resolve default property of object MyControl.Clear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.Clear()
                Case "TextBox"
                    'UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
                    MyControl.Font = VB6.FontChangeName(MyControl.Font, "MS Sans Serif")
                    MyControl.Text = ""
                Case "TDBGrid"
                    'UPGRADE_WARNING: Couldn't resolve default property of object 'MyControl.ClearFields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MyControl.ClearFields()
                Case "SSTab"
                    'UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
                    MyControl.Font = VB6.FontChangeName(MyControl.Font, "MS Sans Serif")
                Case "Label"
                    'UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
                    MyControl.Font = VB6.FontChangeName(MyControl.Font, "MS Sans Serif")
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

        wiAction = DefaultPage
        wlKey = 0
        wlSalesmanID = 0
        wsTrnCd = "VDR"
        wsOldTerrCode = ""
        wsOldPayCode = ""


        Call SetFieldStatus("Default")
        Call SetButtonStatus("Default")
        tblCommon.Visible = False
        Me.tabDetailInfo.SelectedIndex = 0
        Me.Text = wsFormCaption
    End Sub

    Private Sub Ini_Scr_AfrAct()
        Select Case wiAction
            Case AddRec

                Call SetFieldStatus("AfrActAdd")
                Call SetButtonStatus("AfrActAdd")
                txtVdrCode.Focus()

            Case CorRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboVdrCode.Focus()

            Case DelRec

                Call SetFieldStatus("AfrActEdit")
                Call SetButtonStatus("AfrActEdit")
                cboVdrCode.Focus()
        End Select

        Me.Text = wsFormCaption & " - " & wsActNam(wiAction)
    End Sub
    Private Sub Ini_Scr_AfrKey()
        Dim Ctrl As System.Windows.Forms.Control

        Select Case wiAction

            Case CorRec, DelRec

                If LoadRecord() = False Then
                    gsMsg = "存取記錄失敗! 請聯絡系統管理員或無限系統顧問!"
                    MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    Exit Sub
                Else
                    If RowLock(wsConnTime, wsKeyType, cboVdrCode.Text, wsFormID, wsUsrId) = False Then
                        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
                        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                    End If
                End If
        End Select
        Call SetFieldStatus("AfrKey")
        Call SetButtonStatus("AfrKey")
        cboVdrRgnCode.Focus()
    End Sub

    Private Function Chk_VdrCode(ByVal inCode As String, ByRef outCode As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_VdrCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT VdrCode "
        wsSQL = wsSQL & " FROM MstVendor WHERE VdrCode = '" & Set_Quote(inCode) & "' AND VdrStatus = '1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            Exit Function
        End If


        Chk_VdrCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function

    Private Function Chk_VdrPayCode(ByVal inCode As String, ByRef OutName As String) As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_VdrPayCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT PayDesc "
        wsSQL = wsSQL & " FROM MstPayTerm WHERE PayCode = '" & Set_Quote(inCode) & "' AND PayStatus = '1'"

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsRcd, "PayDesc")
        Else
            OutName = ""
            rsRcd.Close()
            Exit Function
        End If

        Chk_VdrPayCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Function Chk_cboVdrPayCode(ByRef OutName As String) As Boolean
        Dim sRetName As String

        sRetName = ""

        Chk_cboVdrPayCode = False

        If Trim(cboVdrPayCode.Text) <> "" Then
            If Chk_VdrPayCode(cboVdrPayCode.Text, sRetName) = False Then
                tabDetailInfo.SelectedIndex = 2
                gsMsg = "付款條款編碼不存在!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboVdrPayCode.Focus()
                Exit Function
            Else
                OutName = sRetName
            End If
        End If

        Chk_cboVdrPayCode = True
    End Function

    Private Function chk_cboVdrCode() As Boolean
        Dim wsStatus As String

        chk_cboVdrCode = False

        If Trim(cboVdrCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVdrCode.Focus()
            Exit Function
        End If

        If Chk_VdrCode(cboVdrCode.Text, wsStatus) = False Then
            gsMsg = "供應商編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVdrCode.Focus()
            Exit Function
        Else
            If wsStatus = "2" Then
                gsMsg = "供應商編碼已存在但已無效!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboVdrCode.Focus()
                Exit Function
            End If
        End If

        chk_cboVdrCode = True
    End Function

    Private Function Chk_txtVdrCode() As Boolean
        Dim wsStatus As String

        Chk_txtVdrCode = False

        If Trim(txtVdrCode.Text) = "" And Chk_AutoGen(wsTrnCd) = "N" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVdrCode.Focus()
            Exit Function
        End If

        If Chk_VdrCode(txtVdrCode.Text, wsStatus) = True Then
            If wsStatus = "2" Then
                gsMsg = "供應商編碼已存在但已無效!"
            Else
                gsMsg = "供應商編碼已存在!"
            End If

            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVdrCode.Focus()
            Exit Function
        End If

        Chk_txtVdrCode = True
    End Function

    Private Function Chk_txtVdrName() As Boolean
        Chk_txtVdrName = False

        If Trim(txtVdrName.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVdrName.Focus()
            Exit Function
        End If

        Chk_txtVdrName = True
    End Function
    Private Function Chk_txtVdrSpecDis() As Boolean
        Chk_txtVdrSpecDis = False

        If To_Value(Trim(txtVdrSpecDis.Text)) < 0 Or To_Value(Trim(txtVdrSpecDis.Text)) > 100 Then
            gsMsg = "特別折扣必需為零至一百!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            txtVdrSpecDis.Focus()
            Exit Function
        End If

        Chk_txtVdrSpecDis = True
    End Function

    Private Sub cmdOpen()
        Dim newForm As New frmV001

        newForm.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 200)
        newForm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 200)

        newForm.Show()
    End Sub

    Private Sub cmdNew()

        wiAction = AddRec
        Ini_Scr_AfrAct()

    End Sub

    Private Sub cmdEdit()

        wiAction = CorRec
        Ini_Scr_AfrAct()

    End Sub

    Private Sub cmdFind()
        Call OpenPromptForm()
    End Sub

    Private Sub cmdDel()

        wiAction = DelRec
        Ini_Scr_AfrAct()

    End Sub

    Private Sub cmdCancel()
        If tbrProcess.Items.Item(tcSave).Enabled = True Then
            Select Case wiAction
                Case AddRec
                    Call Ini_Scr()
                    Call cmdNew()

                Case CorRec
                    Call UnLockAll(wsConnTime, wsFormID)
                    Call Ini_Scr()
                    Call cmdEdit()

                Case DelRec
                    Call UnLockAll(wsConnTime, wsFormID)
                    Call Ini_Scr()
                    Call cmdDel()
            End Select
        Else
            Call Ini_Scr()
        End If
    End Sub

    Private Function cmdSave() As Boolean

        Dim wsGenDte As String
        Dim wsNo As String
        Dim adcmdSave As New ADODB.Command
        Dim gsMsg As String
        Dim wsCode As String

        On Error GoTo cmdSave_Err

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        wsGenDte = VB6.Format(Today, "YYYY/MM/DD")

        If wiAction <> AddRec Then
            If ReadOnlyMode(wsConnTime, wsKeyType, cboVdrCode.Text, wsFormID) Then
                gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
                MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If wiAction = DelRec Then
            gsMsg = "你是否確定要刪除此記錄?"
            If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                cmdCancel()
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        Else
            If InputValidation() = False Then
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Function
            End If
        End If

        If wiAction = AddRec Then
            If Chk_KeyExist() = True Then
                Call GetNewKey()
            End If
        End If

        cnCon.BeginTrans()
        adcmdSave.ActiveConnection = cnCon

        adcmdSave.CommandText = "USP_V001"
        adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        adcmdSave.Parameters.Refresh()

        Call SetSPPara(adcmdSave, 1, wiAction)
        Call SetSPPara(adcmdSave, 2, wlKey)
        Call SetSPPara(adcmdSave, 3, IIf(wiAction = AddRec, UCase(txtVdrCode.Text), UCase(cboVdrCode.Text)))
        Call SetSPPara(adcmdSave, 4, txtVdrName)
        Call SetSPPara(adcmdSave, 5, txtVdrContactName)
        Call SetSPPara(adcmdSave, 6, txtVdrContactName1)
        Call SetSPPara(adcmdSave, 7, txtVdrTel)

        Call SetSPPara(adcmdSave, 8, txtVdrFax)
        Call SetSPPara(adcmdSave, 9, txtVdrEmail)
        Call SetSPPara(adcmdSave, 10, txtVdrAddress1)
        Call SetSPPara(adcmdSave, 11, txtVdrAddress2)
        Call SetSPPara(adcmdSave, 12, txtVdrAddress3)
        Call SetSPPara(adcmdSave, 13, txtVdrAddress4)

        Call SetSPPara(adcmdSave, 14, Get_CheckValue(chkInActive))
        Call SetSPPara(adcmdSave, 15, cboVdrPayCode)
        Call SetSPPara(adcmdSave, 16, txtVdrPayTerm)
        Call SetSPPara(adcmdSave, 17, cboVdrRgnCode)
        Call SetSPPara(adcmdSave, 18, cboVdrMLCode)

        Call SetSPPara(adcmdSave, 19, cboVdrCurr)
        Call SetSPPara(adcmdSave, 20, txtVdrCreditLimit)
        Call SetSPPara(adcmdSave, 21, lblDspVdrOpenBal.Text)
        Call SetSPPara(adcmdSave, 22, txtVdrShipName)
        Call SetSPPara(adcmdSave, 23, txtVdrShipAdd1)
        Call SetSPPara(adcmdSave, 24, txtVdrShipAdd2)

        Call SetSPPara(adcmdSave, 25, txtVdrShipAdd3)
        Call SetSPPara(adcmdSave, 26, txtVdrShipAdd4)
        Call SetSPPara(adcmdSave, 27, txtVdrShipContactPerson)
        Call SetSPPara(adcmdSave, 28, txtVdrShipTel)
        Call SetSPPara(adcmdSave, 29, txtVdrShipFax)
        Call SetSPPara(adcmdSave, 30, txtVdrShipEmail)
        Call SetSPPara(adcmdSave, 31, txtVdrSpecDis)
        Call SetSPPara(adcmdSave, 32, txtVdrRemark)
        Call SetSPPara(adcmdSave, 33, wlSalesmanID)
        Call SetSPPara(adcmdSave, 34, gsUserID)
        Call SetSPPara(adcmdSave, 35, wsGenDte)
        Call SetSPPara(adcmdSave, 36, wsTrnCd)


        adcmdSave.Execute()
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsNo = GetSPPara(adcmdSave, 37)
        'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        wsCode = GetSPPara(adcmdSave, 38)

        cnCon.CommitTrans()

        If wiAction = AddRec And Trim(wsNo) = "" Then
            gsMsg = "儲存失敗, 請檢查 Store Procedure - V001!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        Else
            gsMsg = "已成功儲存!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
        End If

        Call cmdCancel()

        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing
        cmdSave = True

        Cursor = System.Windows.Forms.Cursors.Default

        Exit Function

cmdSave_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

    End Function

    Private Function SaveData() As Boolean

        Dim wiRet As Integer

        SaveData = False

        If (wiAction = AddRec Or wiAction = CorRec Or wiAction = DelRec) And tbrProcess.Items.Item(tcSave).Enabled = True Then
            gsMsg = "你是否確定要儲存現時之作業?"
            If MsgBox(gsMsg, MsgBoxStyle.YesNo, gsTitle) = MsgBoxResult.No Then
                Exit Function
            Else
                If cmdSave = True Then
                    Exit Function
                End If
            End If
            SaveData = True
        Else
            SaveData = False
        End If

    End Function

    Private Sub txtVdrAddress1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress1.Leave
        FocusMe(txtVdrAddress1, True)
    End Sub

    Private Sub txtVdrAddress2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress2.Leave
        FocusMe(txtVdrAddress2, True)
    End Sub

    Private Sub txtVdrAddress3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress3.Leave
        FocusMe(txtVdrAddress3, True)
    End Sub

    Private Sub txtVdrAddress4_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress4.Leave
        FocusMe(txtVdrAddress4, True)
    End Sub

    Private Sub txtVdrCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrCode.Enter
        FocusMe(txtVdrCode)
    End Sub

    Private Sub txtVdrCode_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtVdrCode.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = System.Windows.Forms.Keys.F4 And wiAction <> AddRec Then
            KeyCode = 0
        End If
    End Sub

    Private Sub txtVdrCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLenA(txtVdrCode, 10, KeyAscii, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtVdrCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrCode.Leave
        FocusMe(txtVdrCode, True)
    End Sub

    Private Sub txtVdrContactName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrContactName.Leave
        FocusMe(txtVdrContactName, True)
    End Sub

    Private Sub txtVdrContactName1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrContactName1.Enter
        FocusMe(txtVdrContactName1)
    End Sub

    Private Sub txtVdrContactName1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrContactName1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrContactName1, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            tabDetailInfo.SelectedIndex = 0
            txtVdrAddress1.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrContactName1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrContactName1.Leave
        FocusMe(txtVdrContactName1, True)
    End Sub

    Private Sub txtVdrCreditLimit_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrCreditLimit.Leave
        txtVdrCreditLimit.Text = VB6.Format(txtVdrCreditLimit.Text, gsAmtFmt)
        FocusMe(txtVdrCreditLimit, True)
    End Sub

    Private Sub txtVdrEmail_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrEmail.Leave
        FocusMe(txtVdrEmail, True)
    End Sub

    Private Sub txtVdrFax_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrFax.Leave
        FocusMe(txtVdrFax, True)
    End Sub

    Private Sub txtVdrName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrName.Enter
        FocusMe(txtVdrName)
    End Sub

    Private Sub txtVdrName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrName, 60, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_txtVdrName() = True Then
                txtVdrTel.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrName.Leave
        FocusMe(txtVdrName, True)
    End Sub






    Private Sub txtVdrPayTerm_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrPayTerm.Leave
        FocusMe(txtVdrPayTerm)
    End Sub

    Private Sub txtVdrRemark_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrRemark.Leave
        FocusMe(txtVdrRemark, True)
    End Sub

    Private Sub txtVdrShipAdd1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd1.Leave
        FocusMe(txtVdrShipAdd1, True)
    End Sub

    Private Sub txtVdrShipAdd2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd2.Leave
        FocusMe(txtVdrShipAdd2, True)
    End Sub

    Private Sub txtVdrShipAdd3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd3.Leave
        FocusMe(txtVdrShipAdd3, True)
    End Sub

    Private Sub txtVdrShipAdd4_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd4.Leave
        FocusMe(txtVdrShipAdd4, True)
    End Sub

    Private Sub txtVdrShipContactPerson_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipContactPerson.Leave
        FocusMe(txtVdrShipContactPerson, True)
    End Sub

    Private Sub txtVdrShipEmail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipEmail.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipEmail)
    End Sub

    Private Sub txtVdrShipEmail_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipEmail.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipEmail, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 2
            cboVdrSaleCode.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipEmail_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipEmail.Leave
        FocusMe(txtVdrShipEmail, True)
    End Sub

    Private Sub txtVdrShipFax_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipFax.Leave
        FocusMe(txtVdrShipFax, True)
    End Sub

    Private Sub txtVdrShipName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipName.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipName)
    End Sub

    Private Sub txtVdrShipName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipName, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtVdrShipContactPerson.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipName.Leave
        FocusMe(txtVdrShipName, True)
    End Sub

    Private Sub txtVdrShipTel_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipTel.Leave
        FocusMe(txtVdrShipTel, True)
    End Sub

    Private Sub txtVdrSpecDis_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrSpecDis.Enter
        FocusMe(txtVdrSpecDis)
    End Sub

    Private Sub txtVdrSpecDis_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrSpecDis.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtVdrSpecDis.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_txtVdrSpecDis Then
                tabDetailInfo.SelectedIndex = 2
                txtVdrRemark.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrSpecDis_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrSpecDis.Leave
        txtVdrSpecDis.Text = VB6.Format(txtVdrSpecDis.Text, gsAmtFmt)
        FocusMe(txtVdrSpecDis, True)
    End Sub

    Private Sub txtVdrTel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrTel.Enter
        FocusMe(txtVdrTel)
    End Sub

    Private Sub txtVdrTel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrTel.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrTel, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtVdrFax.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrFax_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrFax.Enter
        FocusMe(txtVdrFax)
    End Sub

    Private Sub txtVdrFax_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrFax.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrFax, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtVdrContactName.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrContactName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrContactName.Enter
        FocusMe(txtVdrContactName)
    End Sub

    Private Sub txtVdrContactName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrContactName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrContactName, 30, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtVdrEmail.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrEmail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrEmail.Enter
        FocusMe(txtVdrEmail)
    End Sub

    Private Sub txtVdrEmail_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrEmail.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrEmail, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 0
            txtVdrContactName1.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub chkInActive_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkInActive.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtVdrName.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrAddress1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress1.Enter
        If tabDetailInfo.SelectedIndex <> 0 Then tabDetailInfo.SelectedIndex = 0
        FocusMe(txtVdrAddress1)
    End Sub

    Private Sub txtVdrAddress1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrAddress1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrAddress1, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 0
            txtVdrAddress2.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrAddress2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress2.Enter
        If tabDetailInfo.SelectedIndex <> 0 Then tabDetailInfo.SelectedIndex = 0
        FocusMe(txtVdrAddress2)
    End Sub

    Private Sub txtVdrAddress2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrAddress2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrAddress2, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 0
            txtVdrAddress3.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrAddress3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress3.Enter
        If tabDetailInfo.SelectedIndex <> 0 Then tabDetailInfo.SelectedIndex = 0
        FocusMe(txtVdrAddress3)
    End Sub

    Private Sub txtVdrAddress3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrAddress3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrAddress3, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 0
            txtVdrAddress4.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrAddress4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrAddress4.Enter
        If tabDetailInfo.SelectedIndex <> 0 Then tabDetailInfo.SelectedIndex = 0
        FocusMe(txtVdrAddress4)
    End Sub

    Private Sub txtVdrAddress4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrAddress4.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrAddress4, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 0
            txtVdrShipName.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrTel_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrTel.Leave
        FocusMe(txtVdrTel, True)
    End Sub

    Private Sub txtVdrShipAdd1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd1.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipAdd1)
    End Sub

    Private Sub txtVdrShipAdd1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipAdd1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipAdd1, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 1
            txtVdrShipAdd2.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipAdd2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd2.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipAdd2)
    End Sub

    Private Sub txtVdrShipAdd2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipAdd2.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipAdd2, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 1
            txtVdrShipAdd3.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipAdd3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd3.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipAdd3)
    End Sub

    Private Sub txtVdrShipAdd3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipAdd3.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipAdd3, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 1
            txtVdrShipAdd4.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipAdd4_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipAdd4.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipAdd4)
    End Sub

    Private Sub txtVdrShipAdd4_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipAdd4.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipAdd4, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtVdrShipTel.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipContactPerson_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipContactPerson.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipContactPerson)
    End Sub

    Private Sub txtVdrShipContactPerson_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipContactPerson.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipContactPerson, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 1
            txtVdrShipAdd1.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipTel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipTel.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipTel)
    End Sub

    Private Sub txtVdrShipTel_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipTel.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipTel, 50, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtVdrShipFax.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrShipFax_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrShipFax.Enter
        If tabDetailInfo.SelectedIndex <> 1 Then tabDetailInfo.SelectedIndex = 1
        FocusMe(txtVdrShipFax)
    End Sub

    Private Sub txtVdrShipFax_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrShipFax.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrShipFax, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            txtVdrShipEmail.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrPayTerm_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrPayTerm.Enter
        If tabDetailInfo.SelectedIndex <> 2 Then tabDetailInfo.SelectedIndex = 2
        FocusMe(txtVdrPayTerm)
    End Sub

    Private Sub txtVdrPayTerm_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrPayTerm.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrPayTerm, 20, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 2
            txtVdrCreditLimit.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrCreditLimit_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrCreditLimit.Enter
        If tabDetailInfo.SelectedIndex <> 2 Then tabDetailInfo.SelectedIndex = 2
        FocusMe(txtVdrCreditLimit)
    End Sub

    Private Sub txtVdrCreditLimit_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrCreditLimit.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call Chk_InpNum(KeyAscii, txtVdrCreditLimit.Text, False, True)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            tabDetailInfo.SelectedIndex = 2
            cboVdrMLCode.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtVdrRemark_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVdrRemark.Enter
        If tabDetailInfo.SelectedIndex <> 2 Then tabDetailInfo.SelectedIndex = 2
        FocusMe(txtVdrRemark)
    End Sub

    Private Sub txtVdrRemark_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtVdrRemark.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(txtVdrRemark, 100, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            cboVdrRgnCode.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub OpenPromptForm()
        Dim wsOutCode As String
        Dim sSQL As String

        Dim vFilterAry(8, 2) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 1) = "編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(1, 2) = "VdrCode"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 1) = "名稱"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(2, 2) = "VdrName"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 1) = "有效"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(3, 2) = "VdrInActive"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(4, 1) = "聯絡人"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(4, 2) = "VdrContactName"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(5, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(5, 1) = "電話"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(5, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(5, 2) = "VdrTel"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(6, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(6, 1) = "傳真"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(6, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(6, 2) = "VdrFax"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(7, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(7, 1) = "電郵"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(7, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(7, 2) = "VdrEmail"

        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(8, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(8, 1) = "地區"
        'UPGRADE_WARNING: Couldn't resolve default property of object vFilterAry(8, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vFilterAry(8, 2) = "VdrTerritory"


        Dim vAry(8, 3) As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 1) = "編碼"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 2) = "VdrCode"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(1, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(1, 3) = "800"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 1) = "名稱"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 2) = "VdrName"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(2, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(2, 3) = "2000"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 1) = "有效"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 2) = "VdrInActive"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(3, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(3, 3) = "2000"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 1) = "聯絡人"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 2) = "VdrContactName"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(4, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(4, 3) = "1000"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(5, 1) = "電話"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(5, 2) = "VdrTel"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(5, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(5, 3) = "1000"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(6, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(6, 1) = "傳真"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(6, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(6, 2) = "VdrFax"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(6, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(6, 3) = "0"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(7, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(7, 1) = "電郵"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(7, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(7, 2) = "VdrEmail"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(7, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(7, 3) = "1500"

        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(8, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(8, 1) = "地區"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(8, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(8, 2) = "VdrTerritory"
        'UPGRADE_WARNING: Couldn't resolve default property of object vAry(8, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vAry(8, 3) = "1600"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With frmShareSearch
            sSQL = "SELECT MstVendor.VdrCode, MstVendor.VdrName, "
            sSQL = sSQL & "MstVendor.VdrContactName, MstVendor.VdrTel, MstVendor.VdrFax, MstVendor.VdrEmail, "
            sSQL = sSQL & "MstVendor.VdrTerritory, MstVendor.VdrInActive "
            sSQL = sSQL & "FROM MstVendor WHERE VdrStatus='1'"
            .sBindSQL = sSQL
            .sBindWhereSQL = ""
            .sBindOrderSQL = "ORDER BY MstVendor.VdrName"
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vHeadDataAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vHeadDataAry = VB6.CopyArray(vAry)
            'UPGRADE_WARNING: Couldn't resolve default property of object frmShareSearch.vFilterAry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .vFilterAry = VB6.CopyArray(vFilterAry)
            .ShowDialog()
        End With
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
        If Trim(frmShareSearch.Tag) <> "" And Trim(frmShareSearch.Tag) <> cboVdrCode.Text Then
            cboVdrCode.Text = Trim(frmShareSearch.Tag)
            System.Windows.Forms.SendKeys.Send("{ENTER}")
        End If
        frmShareSearch.Close()
    End Sub

    Public Function Chk_cboVdrCurr() As Boolean
        Chk_cboVdrCurr = False

        If Trim(cboVdrCurr.Text) = "" Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg)
            tabDetailInfo.SelectedIndex = 2
            cboVdrCurr.Focus()
            Exit Function
        End If

        If Chk_VdrCurr = False Then
            gsMsg = "沒有輸入須要之資料!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboVdrCurr.Focus()
            Exit Function
        End If

        Chk_cboVdrCurr = True
    End Function

    Private Function Chk_VdrCurr() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim sSQL As String

        sSQL = "SELECT ExcCurr FROM MstExchangeRate WHERE ExcCurr='" & Set_Quote(cboVdrCurr.Text) & "' And ExcStatus = '1'"

        rsRcd.Open(sSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount < 1 Then
            Chk_VdrCurr = False
        Else
            Chk_VdrCurr = True
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick
        wcCombo.Text = tblCommon.Columns(0).Text
        wcCombo.Focus()
        tblCommon.Visible = False
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

    Private Sub cboVdrCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.DropDown

        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrCode

        wsSQL = "SELECT VdrCode, VdrName FROM MstVendor WHERE VdrStatus = '1'"
        wsSQL = wsSQL & " AND VdrInactive = 'N' "
        wsSQL = wsSQL & " AND VdrCode LIKE '%" & IIf(cboVdrCode.SelectionLength > 0, "", Set_Quote(cboVdrCode.Text)) & "%' "

        wsSQL = wsSQL & "ORDER BY VdrCode "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboVdrCode.Left)), VB6.PixelsToTwipsY(cboVdrCode.Top) + VB6.PixelsToTwipsY(cboVdrCode.Height), tblCommon, wsFormID, "TBLV", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboVdrCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim wsExcRate As String
        Dim wsExcDesc As String

        Call chk_InpLen(cboVdrCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboVdrCode() = True Then
                Call Ini_Scr_AfrKey()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVdrCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.Enter
        FocusMe(cboVdrCode)
    End Sub

    Private Sub cboVdrCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCode.Leave
        FocusMe(cboVdrCode, True)
    End Sub

    Private Sub cboVdrCurr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCurr.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrCurr

        wsSQL = "SELECT DISTINCT ExcCurr FROM MstExchangeRate WHERE ExcStatus = '1'"
        wsSQL = wsSQL & "ORDER BY ExcCurr "
        Call Ini_Combo(1, wsSQL, VB6.PixelsToTwipsX(cboVdrCurr.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboVdrCurr.Top) + VB6.PixelsToTwipsY(cboVdrCurr.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(tbrProcess.Height), tblCommon, wsFormID, "TBLCURR", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboVdrCurr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrCurr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboVdrCurr, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            If Chk_cboVdrCurr() = True Then
                tabDetailInfo.SelectedIndex = 2
                txtVdrSpecDis.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVdrCurr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCurr.Enter
        FocusMe(cboVdrCurr)
    End Sub

    Private Sub cboVdrCurr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrCurr.Leave
        FocusMe(cboVdrCurr, True)
    End Sub

    Private Sub cboVdrPayCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrPayCode.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboVdrPayCode

        wsSQL = "SELECT PayCode, PayDesc, PayDay FROM MstPayTerm WHERE PayStatus = '1'"
        wsSQL = wsSQL & "ORDER BY PayCode "
        Call Ini_Combo(3, wsSQL, VB6.PixelsToTwipsX(cboVdrPayCode.Left) + VB6.PixelsToTwipsX(tabDetailInfo.Left), VB6.PixelsToTwipsY(cboVdrPayCode.Top) + VB6.PixelsToTwipsY(cboVdrPayCode.Height) + VB6.PixelsToTwipsY(tabDetailInfo.Top) + VB6.PixelsToTwipsY(tbrProcess.Height), tblCommon, wsFormID, "TBLPYT", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cboVdrPayCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboVdrPayCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim sPayTerm As String

        Call chk_InpLen(cboVdrPayCode, 10, KeyAscii)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If Chk_cboVdrPayCode(sPayTerm) = True Then
                If wsOldPayCode <> cboVdrPayCode.Text Then
                    txtVdrPayTerm.Text = sPayTerm
                    wsOldPayCode = cboVdrPayCode.Text
                End If
                tabDetailInfo.SelectedIndex = 2
                txtVdrPayTerm.Focus()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboVdrPayCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrPayCode.Enter
        FocusMe(cboVdrPayCode)
    End Sub

    Private Sub cboVdrPayCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboVdrPayCode.Leave
        FocusMe(cboVdrPayCode, True)
    End Sub

    Private Function Chk_KeyExist() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        wsSQL = "SELECT VdrStatus FROM MstVendor WHERE VdrCode = '" & Set_Quote(txtVdrCode.Text) & "'"
        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            Chk_KeyExist = True
        Else
            Chk_KeyExist = False
        End If

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
    End Function

    Private Sub GetNewKey()
        Dim Newfrm As New frmKeyInput

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Create Selection Criteria
        With Newfrm
            .TableID = wsKeyType
            .TableType = wsTrnCd
            .TableKey = "VdrCode"
            .KeyLen = 10
            .ctlKey = txtVdrCode
            .ShowDialog()
        End With

        'UPGRADE_NOTE: Object Newfrm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Newfrm = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Ini_Caption()

        On Error GoTo Ini_Caption_Err
        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")

        fraVdrInfo.Text = Get_Caption(waScrItm, "FRAVDRINFO")

        chkInActive.Text = Get_Caption(waScrItm, "INACTIVE")
        lblVdrCode.Text = Get_Caption(waScrItm, "VDRCODE")
        lblVdrName.Text = Get_Caption(waScrItm, "VDRNAME")
        lblVdrTel.Text = Get_Caption(waScrItm, "VDRTEL")
        lblVdrFax.Text = Get_Caption(waScrItm, "VDRFAX")
        lblVdrContactName.Text = Get_Caption(waScrItm, "VDRCONTACTNAME")
        lblVdrEmail.Text = Get_Caption(waScrItm, "VDREMAIL")
        lblVdrCreditLimit.Text = Get_Caption(waScrItm, "VDRCREDITLIMIT")
        lblVdrOpenBal.Text = Get_Caption(waScrItm, "VDROPENBAL")
        lblVdrCurr.Text = Get_Caption(waScrItm, "VDRCURR")
        lblVdrSpecDis.Text = Get_Caption(waScrItm, "VDRSPECDIS")
        lblVdrPayCode.Text = Get_Caption(waScrItm, "VDRPAYCODE")
        lblVdrRemark.Text = Get_Caption(waScrItm, "VDRREMARK")
        lblVdrAddress1.Text = Get_Caption(waScrItm, "VDRADDRESS1")
        lblVdrLastUpd.Text = Get_Caption(waScrItm, "VDRLASTUPD")
        lblVdrLastUpdDate.Text = Get_Caption(waScrItm, "VDRLASTUPDDATE")
        lblVdrMLCode.Text = Get_Caption(waScrItm, "VDRMLCODE")
        lblVdrContactName1.Text = Get_Caption(waScrItm, "VDRCONTACTPERSON1")
        lblVdrRgnCode.Text = Get_Caption(waScrItm, "VDRRGNCODE")

        tbrProcess.Items.Item(tcOpen).ToolTipText = Get_Caption(waScrToolTip, tcOpen) & "(F6)"
        tbrProcess.Items.Item(tcAdd).ToolTipText = Get_Caption(waScrToolTip, tcAdd) & "(F2)"
        tbrProcess.Items.Item(tcEdit).ToolTipText = Get_Caption(waScrToolTip, tcEdit) & "(F5)"
        tbrProcess.Items.Item(tcDelete).ToolTipText = Get_Caption(waScrToolTip, tcDelete) & "(F3)"
        tbrProcess.Items.Item(tcSave).ToolTipText = Get_Caption(waScrToolTip, tcSave) & "(F10)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcFind).ToolTipText = Get_Caption(waScrToolTip, tcFind) & "(F9)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        fraVdrShipAddr1.Text = Get_Caption(waScrItm, "FRAVDRSHIPADDR1")

        lblVdrShipName.Text = Get_Caption(waScrItm, "VDRSHIPNAME")
        lblVdrShipContactPerson.Text = Get_Caption(waScrItm, "VDRSHIPCONTACTPERSON")
        lblVdrShipAdd.Text = Get_Caption(waScrItm, "VDRSHIPADD")
        lblVdrSaleName.Text = Get_Caption(waScrItm, "VDRSALENAME")

        lblVdrShipTel.Text = Get_Caption(waScrItm, "VDRSHIPTEL")
        lblVdrShipFax.Text = Get_Caption(waScrItm, "VDRSHIPFAX")
        lblVdrShipEmail.Text = Get_Caption(waScrItm, "VDRSHIPEMAIL")

        tabDetailInfo.TabPages.Item(0).Text = Get_Caption(waScrItm, "TABDETAILINFO0")
        tabDetailInfo.TabPages.Item(1).Text = Get_Caption(waScrItm, "TABDETAILINFO1")
        tabDetailInfo.TabPages.Item(2).Text = Get_Caption(waScrItm, "TABDETAILINFO2")
        tabDetailInfo.TabPages.Item(3).Text = Get_Caption(waScrItm, "TABDETAILINFO3")

        lblAcmSale.Text = Get_Caption(waScrItm, "ACMSALE")
        lblAcmYrSale.Text = Get_Caption(waScrItm, "ACMYRSALE")
        lblAcmMnSale.Text = Get_Caption(waScrItm, "ACMMNSALE")
        lblOpenBal.Text = Get_Caption(waScrItm, "OPENBAL")
        lblCloseBal.Text = Get_Caption(waScrItm, "CLOSEBAL")
        lblARBal.Text = Get_Caption(waScrItm, "ARBAL")
        lblQty.Text = Get_Caption(waScrItm, "QTY")
        lblAmt.Text = Get_Caption(waScrItm, "AMT")
        lblNet.Text = Get_Caption(waScrItm, "NET")
        lblVdrCrtDate.Text = Get_Caption(waScrItm, "VDRCRTDATE")

        With tblDetail
            .Columns(PERIOD).Caption = Get_Caption(waScrItm, "PERIOD")
            .Columns(SALES).Caption = Get_Caption(waScrItm, "SALES")
            .Columns(DEPOSIT).Caption = Get_Caption(waScrItm, "DEPOSIT")
        End With

        wsActNam(1) = Get_Caption(waScrItm, "VADD")
        wsActNam(2) = Get_Caption(waScrItm, "VEDIT")
        wsActNam(3) = Get_Caption(waScrItm, "VDELETE")
        Exit Sub

Ini_Caption_Err:

        MsgBox("Please Check ini_Caption!")

    End Sub

    Private Function Chk_cboVdrMLCode() As Boolean
        Dim wsDesc As String
        Chk_cboVdrMLCode = False

        If Trim(cboVdrMLCode.Text) = "" Then
            gsMsg = "必須輸入會計號!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboVdrMLCode.Focus()
            Exit Function
        End If


        If Chk_MerchClass(cboVdrMLCode.Text, wsDesc) = False Then
            gsMsg = "無此會計號!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            tabDetailInfo.SelectedIndex = 2
            cboVdrMLCode.Focus()
            lblDspVdrMLDesc.Text = ""
            Exit Function
        End If

        lblDspVdrMLDesc.Text = wsDesc

        Chk_cboVdrMLCode = True
    End Function

    Private Function Chk_cboVdrRgnCode() As Boolean
        Dim wsDesc As String
        Chk_cboVdrRgnCode = False

        If Trim(cboVdrRgnCode.Text) = "" Then
            gsMsg = "必須輸入採購區域!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboVdrRgnCode.Focus()
            Exit Function
        End If

        If Chk_Region(cboVdrRgnCode.Text, wsDesc) = False Then
            gsMsg = "無此採購區域!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboVdrRgnCode.Focus()
            lblDspVdrRgnDesc.Text = ""
            Exit Function
        End If

        lblDspVdrRgnDesc.Text = wsDesc

        Chk_cboVdrRgnCode = True
    End Function

    Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
        With tblDetail
            'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            .Update()
        End With
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
        Dim wsWhsCode As String
        Dim wdQty As Double

        On Error GoTo tblDetail_BeforeColUpdate_Err

        If tblCommon.Visible = True Then
            eventArgs.Cancel = False
            'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
            Exit Sub
        End If

        With tblDetail
            Select Case eventArgs.ColIndex
                'Case SONO
                '    If Not Chk_NoDup(.Row + To_Value(.FirstRow)) Then
                '        GoTo Tbl_BeforeColUpdate_Err
                '    End If
                '
                '    If Chk_grdSoNo(.Columns(ColIndex).Text) = False Then
                '       GoTo Tbl_BeforeColUpdate_Err
                '    End If
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

    Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange

        On Error GoTo tblDetail_BeforeRowColChange_Err
        With tblDetail
            '  If .Bookmark <> .DestinationRow Then
            '      If Chk_GrdRow(To_Value(.Bookmark)) = False Then
            '          'Cancel = True
            '          Exit Sub
            '      End If
            '  End If
        End With

        Exit Sub

tblDetail_BeforeRowColChange_Err:

        MsgBox("Check tblDeiail BeforeRowColChange!")
        eventArgs.cancel = True

    End Sub

    Private Sub tblDetail_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_ButtonClickEvent) Handles tblDetail.ButtonClick

        Dim wsSQL As String
        Dim wiTop As Integer

        On Error GoTo tblDetail_ButtonClick_Err


        With tblDetail
            Select Case eventArgs.ColIndex
                'Case SONO
                '
                '    wsSql = "SELECT SOHDDOCNO, SOHDDOCDATE FROM soaSOHD "
                '    wsSql = wsSql & " WHERE SOHDSTATUS = '1' "
                '    wsSql = wsSql & " AND SOHDDOCNO LIKE '%" & Set_Quote(.Columns(SONO).Text) & "%' "
                '    wsSql = wsSql & " AND SOHDCUSID = " & wlCusID
                '    wsSql = wsSql & " ORDER BY SOHDDOCNO "
                '
                '    Call Ini_Combo(2, wsSql, .Columns(ColIndex).Left + .Left + .Columns(ColIndex).Top + tabDetailInfo.Left, .Top + .RowTop(.Row) + .RowHeight + tabDetailInfo.Top, tblCommon, wsFormID, "TBLSONO", Me.Width, Me.Height)
                '    tblCommon.Visible = True
                '    tblCommon.SetFocus
                '    Set wcCombo = tblDetail
                '
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
                        'Case sono
                        '    KeyCode = vbDefault
                        '       .Col = BOOKCODE
                        'Case SALES
                        '    KeyCode = vbDefault
                        '       .Col = WhsCode
                        ' KeyCode = vbKeyDown
                        ' .Col = BOOKCODE
                        'Case BOOKNAME, BARCODE, WhsCode, LOTNO, PUBLISHER, Qty, DisPer, Amt, Dis
                        '    KeyCode = vbDefault
                        '    .Col = .Col + 1
                        'Case Price, Net, Amtl
                        '    KeyCode = vbKeyDown
                        '    .Col = BOOKCODE
                    End Select
                Case System.Windows.Forms.Keys.Left
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> PERIOD Then
                        .Col = .Col - 1
                    End If

                Case System.Windows.Forms.Keys.Right
                    eventArgs.KeyCode = 0 ' System.Windows.Forms.Cursors.Default
                    If .Col <> DEPOSIT Then
                        .Col = .Col + 1
                    End If

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

    Private Sub tblDetail_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_MouseUpEvent) Handles tblDetail.MouseUpEvent
        'If Button = 2 Then
        '    PopupMenu mnuPopUp
        'End If
    End Sub

    Private Sub tblDetail_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_RowColChangeEvent) Handles tblDetail.RowColChange

        wbErr = False
        On Error GoTo RowColChange_Err

        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name <> tblDetail.Name Then Exit Sub

        With tblDetail
            If IsEmptyRow() Then
                .Col = PERIOD
            End If

            If Trim(.Columns(.Col).Text) <> "" Then
                Select Case .Col
                    'Case SONO
                    '    Call Chk_grdSoNo(.Columns(SONO).Text)
                    'Case BOOKCODE
                    '    Call Chk_grdBookCode(.Columns(SONO).Text, .Columns(BOOKCODE).Text, "", "", "", "", "", 0, 0, "", "", 0)
                    'Case WhsCode
                    '    Call Chk_grdWhsCode(.Columns(WhsCode).Text)
                    ' Case LOTNO
                    '    Call Chk_grdLotNo(.Columns(LOTNO).Text)
                    'Case Qty
                    '    Call Chk_grdQty(.Columns(Qty).Text)
                    'Case DisPer
                    '    Call Chk_grdDisPer(.Columns(DisPer).Text)

                End Select
            End If
        End With

        Exit Sub

RowColChange_Err:

        MsgBox("Check tblDeiail RowColChange")
        wbErr = True

    End Sub

    Private Function IsEmptyRow(Optional ByRef inRow As Object = Nothing) As Boolean

        IsEmptyRow = True

        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If IsNothing(inRow) Then
            With tblDetail
                If Trim(.Columns(PERIOD).Text) = "" Then
                    Exit Function
                End If
            End With
        Else
            If waResult.get_UpperBound(1) >= 0 Then
                If Trim(waResult.get_Value(inRow, PERIOD)) = "" And Trim(waResult.get_Value(inRow, SALES)) = "" And Trim(waResult.get_Value(inRow, DEPOSIT)) = "" And Trim(waResult.get_Value(inRow, BALID)) = "" Then
                    Exit Function
                End If
            End If
        End If

        IsEmptyRow = False

    End Function

    Private Sub Ini_Grid()

        Dim wiCtr As Short

        With tblDetail
            .EmptyRows = True
            .MultipleLines = 0
            .AllowAddNew = True
            .AllowUpdate = True
            .AllowDelete = True
            .AlternatingRowStyle = True
            .RecordSelectors = False
            .AllowColMove = False
            .AllowColSelect = False

            For wiCtr = PERIOD To BALID
                .Columns(wiCtr).AllowSizing = True
                .Columns(wiCtr).Visible = True
                .Columns(wiCtr).Locked = False
                .Columns(wiCtr).Button = False
                .Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
                .Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft

                Select Case wiCtr
                    Case PERIOD
                        .Columns(wiCtr).Width = 1000
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                    Case SALES
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                    Case DEPOSIT
                        .Columns(wiCtr).Width = 1200
                        .Columns(wiCtr).DataWidth = 15
                        .Columns(wiCtr).Locked = True
                    Case BALID
                        .Columns(wiCtr).DataWidth = 4
                        .Columns(wiCtr).Visible = False
                End Select
            Next
            .Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
        End With

    End Sub

    Private Function Chk_cboVdrSaleCode(ByRef sOutName As Object) As Boolean
        Dim sRetName As String

        sRetName = ""

        Chk_cboVdrSaleCode = False

        If Trim(cboVdrSaleCode.Text) <> "" Then
            If Chk_VdrSaleCode(cboVdrSaleCode.Text, wlSalesmanID, sRetName) = False Then
                Me.tabDetailInfo.SelectedIndex = 2
                gsMsg = "採購員編碼不存在!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
                cboVdrSaleCode.Focus()
                Exit Function
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object sOutName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sOutName = sRetName
                Chk_cboVdrSaleCode = True
            End If
        Else
            Me.tabDetailInfo.SelectedIndex = 2
            gsMsg = "採購員編碼不存在!"
            MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
            cboVdrSaleCode.Focus()
            Exit Function
        End If

    End Function

    Private Function Chk_VdrSaleCode(ByVal inCode As String, ByRef OutID As Integer, ByRef OutName As String) As Boolean

        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String

        Chk_VdrSaleCode = False

        If Trim(inCode) = "" Then
            Exit Function
        End If

        wsSQL = "SELECT SaleID, SaleName "
        wsSQL = wsSQL & " FROM MstSalesman WHERE SaleCode = '" & Set_Quote(inCode) & "' "
        wsSQL = wsSQL & " AND SaleStatus = '1' "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutName = ReadRs(rsRcd, "SaleName")
            'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutID = ReadRs(rsRcd, "SaleID")
        Else
            OutName = ""
            OutID = 0
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            Exit Function
        End If

        Chk_VdrSaleCode = True

        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing

    End Function

    Private Function LoadSaleInfo() As Boolean
        Dim rsRcd As New ADODB.Recordset
        Dim wsSQL As String
        Dim wiCtr As Integer
        Dim wsYYYY As String
        Dim wsMM As String

        Dim wdARBal As Double
        Dim wdOpnBal As Double
        Dim wdTotBal As Double
        Dim wdCMQty As Double
        Dim wdCYQty As Double
        Dim wdTotQty As Double
        Dim wdCMSal As Double
        Dim wdCYSal As Double
        Dim wdTotSal As Double
        Dim wdCMNet As Double
        Dim wdCYNet As Double
        Dim wdTotNet As Double
        Dim wdAmt As Double


        wsYYYY = VB.Left(gsSystemDate, 4)
        wsMM = Mid(gsSystemDate, 6, 2)


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        LoadSaleInfo = False

        Call Get_VdrSaleInfo(wlKey, wsYYYY, wsMM, 0, 0, wdOpnBal, wdTotBal, wdCMQty, wdCYQty, wdTotQty, wdCMSal, wdCYSal, wdTotSal, wdCMNet, wdCYNet, wdTotNet)

        lblDspARBal.Text = VB6.Format(wdTotBal, gsAmtFmt)
        lblDspOpenBal.Text = VB6.Format(wdOpnBal, gsAmtFmt)
        lblDspCloseBal.Text = VB6.Format(wdTotBal, gsAmtFmt)

        lblDspAcmSaleQty.Text = VB6.Format(wdTotQty, gsQtyFmt)
        lblDspAcmSaleNet.Text = VB6.Format(wdTotNet, gsAmtFmt)
        lblDspAcmSaleAmt.Text = VB6.Format(wdTotSal, gsAmtFmt)

        lblDspAcmYrSaleQty.Text = VB6.Format(wdCYQty, gsQtyFmt)
        lblDspAcmYrSaleNet.Text = VB6.Format(wdCYNet, gsAmtFmt)
        lblDspAcmYrSaleAmt.Text = VB6.Format(wdCYSal, gsAmtFmt)

        lblDspAcmMnSaleQty.Text = VB6.Format(wdCMQty, gsQtyFmt)
        lblDspAcmMnSaleNet.Text = VB6.Format(wdCMNet, gsAmtFmt)
        lblDspAcmMnSaleAmt.Text = VB6.Format(wdCMSal, gsAmtFmt)


        wsSQL = "SELECT POHDCTLPRD, SUM(PODTNETL) NETL "
        wsSQL = wsSQL & " FROM POPPOHD, POPPODT "
        wsSQL = wsSQL & " WHERE POHDVDRID = " & wlKey
        wsSQL = wsSQL & " AND POHDDOCID = PODTDOCID "
        wsSQL = wsSQL & " AND POHDSTATUS IN ('1','4') "
        wsSQL = wsSQL & " AND POHDCTLPRD >= '" & wsYYYY & "01" & "'"
        wsSQL = wsSQL & " GROUP BY POHDCTLPRD "
        wsSQL = wsSQL & " ORDER BY POHDCTLPRD "

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount <= 0 Then
            rsRcd.Close()
            'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsRcd = Nothing
            waResult.ReDim(0, -1, PERIOD, BALID)
            tblDetail.ReBind()
            tblDetail.Bookmark = 0
            'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
            'UPGRADE_ISSUE: Form property frmV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If


        With waResult
            .ReDim(0, -1, PERIOD, BALID)
            rsRcd.MoveFirst()
            Do Until rsRcd.EOF

                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                wdAmt = Get_VdrDebitAmt(wlKey, ReadRs(rsRcd, "POHDCTLPRD"))

                .AppendRows()
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), PERIOD) = ReadRs(rsRcd, "POHDCTLPRD")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                waResult.get_Value(.get_UpperBound(1), BALID) = ReadRs(rsRcd, "POHDCTLPRD")
                waResult.get_Value(.get_UpperBound(1), SALES) = VB6.Format(To_Value(ReadRs(rsRcd, "NETL")), gsAmtFmt)
                waResult.get_Value(.get_UpperBound(1), DEPOSIT) = VB6.Format(wdAmt, gsAmtFmt)
                rsRcd.MoveNext()
            Loop
        End With

        tblDetail.ReBind()
        tblDetail.Bookmark = 0




        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing


        LoadSaleInfo = True
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmV001.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal

    End Function
End Class