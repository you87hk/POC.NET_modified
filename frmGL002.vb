Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmGL002
	Inherits System.Windows.Forms.Form
	
	
	Private wsConnTime As String
	Dim wsFormID As String
	Private Const wsKeyType As String = "BNKREC"
	
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	
	Dim wsMsg1 As String
	Dim wsMsg2 As String
	Dim wsMsg3 As String
	
	Private wsFormCaption As String
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcRefresh As String = "Refresh"
	Private Const tcFont As String = "Font"
	Private Const tcExit As String = "Exit"
	
	
	
	Private Const GTYPE As Short = 0
	Private Const GCHQID As Short = 1
	Private Const GCHQNO As Short = 2
	Private Const GCHQDATE As Short = 3
	Private Const GCURR As Short = 4
	Private Const GCHQAMT As Short = 5
	Private Const GSTATUS As Short = 6
	Private Const GDATECLEAN As Short = 7
	
	
	
	
	Private Sub cmdFont()
		
		Dim wfFont As System.Drawing.Font
		
		On Error GoTo FontErr
		
        Dim dr As Integer = cdFontFont.ShowDialog()
		With lstData
			.Font = VB6.FontChangeName(.Font, cdFontFont.Font.Name)
			.Font = VB6.FontChangeBold(.Font, cdFontFont.Font.Bold)
			.Font = VB6.FontChangeItalic(.Font, cdFontFont.Font.Italic)
			.Font = VB6.FontChangeSize(.Font, cdFontFont.Font.Size)
			.Refresh()
		End With
		
		
		
		
		System.Windows.Forms.Application.DoEvents()
		
		
		
		Exit Sub
		
FontErr: 
		'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdFont.CancelError was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If dr = DialogResult.Cancel Then
            Exit Sub
        End If
		
	End Sub
	
	
	
	Private Sub cmdCancel()
		
		' Call UnLockAll(wsConnTime, wsFormID)
		Ini_Scr()
		
	End Sub
	
	
	
	
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		'lblSummary.Caption = ""
		
		
		Call SetDateMask(medDocFr)
		Call SetDateMask(medDocTo)
		Call SetDateMask(medChqDate)
		
		cboBankAcc.Text = ""
		lblDspBankAcc.Text = ""
		medDocFr.Text = VB.Left(gsSystemDate, 8) & "01"
		medDocTo.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(medDocFr.Text))), "YYYY/MM/DD")
		medChqDate.Text = gsSystemDate
		optBy(0).Checked = True
		
		UpdStatusBar(picStatus, 0)
		
		IniColHeader()
		
		'DoEvents
		
		
	End Sub
	
	
	
	
	Private Sub cmdDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.Click
		
		Call cmdSave()
		
	End Sub
	
	Private Sub cmdSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectAll.Click
		Dim i As Short
		If lstData.Items.Count > 0 Then
			With lstData
				For i = 1 To .Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					.Items.Item(i).Checked = True
				Next i
			End With
		End If
	End Sub
	
	Private Sub cmdUnSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUnSelect.Click
		Dim i As Short
		
		If lstData.Items.Count > 0 Then
			With lstData
				For i = 1 To .Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					.Items.Item(i).Checked = False
				Next i
			End With
		End If
		
	End Sub
	
	Private Sub frmGL002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			
			
			
			Case System.Windows.Forms.Keys.F9
				
				Ini_Scr_AfrKey()
				
			Case System.Windows.Forms.Keys.F11
				
				cmdCancel()
				
			Case System.Windows.Forms.Keys.F5
				
				
				
			Case System.Windows.Forms.Keys.F6
				
				cmdFont()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
		
		' KeyCode = vbDefault
	End Sub
	
	
	
	Private Sub frmGL002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Form()
		
		Ini_Caption()
		
		Ini_Scr()
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub frmGL002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		
		Call UnLockAll(wsConnTime, wsFormID)
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmGL002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	Private Sub IniColHeader()
		
		Dim clmX As System.Windows.Forms.ColumnHeader
		
		On Error GoTo IniColHeader_Err
		
		lstData.Items.Clear()
		lstData.Columns.Clear()
		
		
		
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GTYPE"), CInt(VB6.TwipsToPixelsX(1000)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		clmX = lstData.Columns.Add("", "KEY", CInt(VB6.TwipsToPixelsX(0)))
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GCHQNO"), CInt(VB6.TwipsToPixelsX(2000)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GCHQDATE"), CInt(VB6.TwipsToPixelsX(1500)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GCURR"), CInt(VB6.TwipsToPixelsX(1000)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GCHQAMT"), CInt(VB6.TwipsToPixelsX(2000)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GSTATUS"), CInt(VB6.TwipsToPixelsX(1000)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		clmX = lstData.Columns.Add("", Get_Caption(waScrItm, "GDATECLEAN"), CInt(VB6.TwipsToPixelsX(1000)))
		clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		
		
		
		With lstData
			'UPGRADE_ISSUE: MSComctlLib.ListView method lstData.DragMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            '.DragMode = 0
			'UPGRADE_ISSUE: MSComctlLib.ListView property lstData.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '.Sorted = False
		End With
		
		'UPGRADE_NOTE: Object clmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		clmX = Nothing
		
		Exit Sub
IniColHeader_Err: 
		'DISPLAY ERROR FUNCTION
		MsgBox("IniColHeader Err!")
		MsgBox(Err.Description)
IniColHeader_Exit: 
		On Error Resume Next
		'UPGRADE_NOTE: Object clmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		clmX = Nothing
		
		
	End Sub
	
	
	
	
	
	Private Function LoadRecord() As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim wiCol As Short
		Dim NoOfRecord As Integer
		Dim wiStatus As Short
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		LoadRecord = False
		
		If InputValidation = False Then
			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
			'UPGRADE_ISSUE: Form property frmGL002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If

        lstData.Items.Clear()

        'Create ARCHEQUE sql
        wsSQL = " SELECT ARCQCHQID, ARCQCHQNO, ARCQCHQDATE, ARCQCURR, ARCQCHQAMT, ARCQBNKFLG, ARCQBNKDATE "
        wsSQL = wsSQL & " FROM ARCHEQUE "
        wsSQL = wsSQL & " WHERE ARCQCHQDATE BETWEEN '" & Set_Quote(medDocFr.Text) & "' AND '" & Set_Quote(medDocTo.Text) & "'"
        wsSQL = wsSQL & " AND ARCQSTATUS <> '2' "
        wsSQL = wsSQL & " AND ARCQBANKML = '" & Set_Quote(cboBankAcc.Text) & "' "

        If Opt_Getfocus(optBy, 2, 0) = 1 Then
            wsSQL = wsSQL & " AND ARCQBNKFLG <> 'U' "
        End If

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsRcd.RecordCount > 0 Then
            NoOfRecord = rsRcd.RecordCount
            rsRcd.MoveFirst()
            Do While Not rsRcd.EOF

                'UPGRADE_WARNING: Lower bound of collection lstData.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Image property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="D94970AE-02E7-43BF-93EF-DCFCD10D27B5"'
                itmX = lstData.Items.Add("AR", "book1")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQID, , ReadRs(rsRcd, "ARCQCHQID"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQNO, , ReadRs(rsRcd, "ARCQCHQNO"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQDATE, , ReadRs(rsRcd, "ARCQCHQDATE"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCURR, , ReadRs(rsRcd, "ARCQCURR"))
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQAMT, , VB6.Format(To_Value(ReadRs(rsRcd, "ARCQCHQAMT")), gsAmtFmt))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GSTATUS, , ReadRs(rsRcd, "ARCQBNKFLG"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GDATECLEAN, , ReadRs(rsRcd, "ARCQBNKDATE"))

                wiStatus = wiStatus + Fix((1 / NoOfRecord) * (100))
                UpdStatusBar(picStatus, wiStatus)

                rsRcd.MoveNext()
            Loop
        End If
        rsRcd.Close()

        UpdStatusBar(picStatus, 100, True)

        'Create ARCHEQUE sql
        wsSQL = " SELECT APCQCHQID, APCQCHQNO, APCQCHQDATE, APCQCURR, APCQCHQAMT, APCQBNKFLG, APCQBNKDATE "
        wsSQL = wsSQL & " FROM APCHEQUE "
        wsSQL = wsSQL & " WHERE APCQCHQDATE BETWEEN '" & Set_Quote(medDocFr.Text) & "' AND '" & Set_Quote(medDocTo.Text) & "'"
        wsSQL = wsSQL & " AND APCQSTATUS <> '2' "
        wsSQL = wsSQL & " AND APCQBANKML = '" & Set_Quote(cboBankAcc.Text) & "' "

        If Opt_Getfocus(optBy, 2, 0) = 1 Then
            wsSQL = wsSQL & " AND APCQBNKFLG <> 'U' "
        End If

        rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)


        If rsRcd.RecordCount > 0 Then
            NoOfRecord = rsRcd.RecordCount
            rsRcd.MoveFirst()
            Do While Not rsRcd.EOF


                'UPGRADE_WARNING: Lower bound of collection lstData.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Image property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="D94970AE-02E7-43BF-93EF-DCFCD10D27B5"'
                itmX = lstData.Items.Add("AP", "book1")
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQID, , ReadRs(rsRcd, "APCQCHQID"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQNO, , ReadRs(rsRcd, "APCQCHQNO"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQDATE, , ReadRs(rsRcd, "APCQCHQDATE"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCURR, , ReadRs(rsRcd, "APCQCURR"))
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GCHQAMT, , VB6.Format(To_Value(ReadRs(rsRcd, "APCQCHQAMT")), gsAmtFmt))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GSTATUS, , ReadRs(rsRcd, "APCQBNKFLG"))
                'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'subX = itmX.SubItems.Add(GDATECLEAN, , ReadRs(rsRcd, "APCQBNKDATE"))

                wiStatus = wiStatus + Fix((1 / NoOfRecord) * (100))
                UpdStatusBar(picStatus, wiStatus)

                rsRcd.MoveNext()
            Loop

        End If

        UpdStatusBar(picStatus, 100, True)
        rsRcd.Close()
        LoadRecord = True
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmGL002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
        'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        itmX = Nothing
        'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        subX = Nothing


        Exit Function

LoadRecord_Err:
        MsgBox(Err.Description)
        On Error Resume Next
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property frmGL002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
        rsRcd.Close()
        'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsRcd = Nothing
        'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        itmX = Nothing
        'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        subX = Nothing

    End Function


    Private Sub lstData_BeforeLabelEdit(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.LabelEditEventArgs) Handles lstData.BeforeLabelEdit
        Dim Cancel As Boolean = eventArgs.CancelEdit

        'Cancel = True

    End Sub

    Private Sub lstData_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs) Handles lstData.ColumnClick
        Dim columnheader As System.Windows.Forms.ColumnHeader = lstData.Columns(eventArgs.Column)

        Dim wiSortIdx As Short
        Dim wlItem As Integer
        Dim strName As String
        Dim dDate As Date

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        lstData.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'DoEvents

        wiSortIdx = columnheader.Index - 1
        With lstData
            Select Case columnheader.Tag
                Case "C", "T"
                    'UPGRADE_ISSUE: MSComctlLib.ListView property lstData.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                    '.SortKey = wiSortIdx

                    'If wiSortIdx = ColumnHeader.Index - 1 Then
                    If .Sorting = System.Windows.Forms.SortOrder.Ascending Then
                        .Sorting = System.Windows.Forms.SortOrder.Descending
                    Else
                        .Sorting = System.Windows.Forms.SortOrder.Ascending
                    End If
                    'End If

                    wiSortIdx = columnheader.Index - 1
                    .Sort()
                Case "D"
                    'UPGRADE_ISSUE: MSComctlLib.ListView property lstData.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
                    '.Sorted = False 'User clicked on the Date header
                    'Use our sort routine to sort
                    'by date
                    'SendMessage lstData.hWnd, LVM_SORTITEMS, lstData.hWnd, _
                    'AddressOf CompareDates
                    'lstData.Refresh

                    'For wlItem = 0 To lstData.ListItems.Count - 1
                    '   ListView_GetListItem wlItem, lstData.hWnd, strName, dDate, wiSortIdx + 1
                    'Next



                Case Else
                    'UPGRADE_ISSUE: MSComctlLib.ListView property lstData.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
                    '.Sorted = False


            End Select


            '  lblSummary.Caption = columnheader.Text & " : " & wxSummary(1, columnheader.Index)
        End With

        Cursor = System.Windows.Forms.Cursors.Default
        lstData.Cursor = System.Windows.Forms.Cursors.Default

    End Sub




    Private Sub Ini_Caption()

        Call Get_Scr_Item(wsFormID, waScrItm)
        Call Get_Scr_Item("TOOLTIP", waScrToolTip)

        wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
        lblBankAcc.Text = Get_Caption(waScrItm, "BANKACC")
        lblDocFr.Text = Get_Caption(waScrItm, "DOCFR")
        lblDocTo.Text = Get_Caption(waScrItm, "DOCTO")
        optBy(0).Text = Get_Caption(waScrItm, "OPT0")
        optBy(1).Text = Get_Caption(waScrItm, "OPT1")
        lblChqDate.Text = Get_Caption(waScrItm, "CHQDATE")


        fraSelect.Text = Get_Caption(waScrItm, "SELECT")

        tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
        tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
        tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F5)"
        tbrProcess.Items.Item(tcFont).ToolTipText = Get_Caption(waScrToolTip, tcFont) & "(F6)"
        tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"

        cmdDelete.Text = Get_Caption(waScrItm, "CMDDELETE")
        cmdSelectAll.Text = Get_Caption(waScrItm, "CMDSELECTALL")
        cmdUnSelect.Text = Get_Caption(waScrItm, "CMDUNSELECT")

        wsMsg1 = "1"
        wsMsg2 = "2"
        wsMsg3 = Get_Caption(waScrItm, "MSG3")

    End Sub





    Private Sub medDocFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDocFr.Enter
        FocusMe(medDocFr)
    End Sub


    Private Sub medDocFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medDocFr.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_medDocFr = False Then
                GoTo EventExitSub
            End If

            medDocTo.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_medDocFr() As Boolean

        chk_medDocFr = False

        If Trim(medDocFr.Text) = "/  /" Then
            gsMsg = "Must input Date!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medDocFr.Focus()
            Exit Function
        End If

        If Chk_Date(medDocFr) = False Then
            gsMsg = "Invalid Date Format!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medDocFr.Focus()
            Exit Function
        End If


        chk_medDocFr = True

    End Function
    Private Sub medDocFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDocFr.Leave
        FocusMe(medDocFr, True)
    End Sub

    Private Sub medDocTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDocTo.Enter
        FocusMe(medDocTo)
    End Sub


    Private Sub medDocTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medDocTo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_medDocTo = False Then
                GoTo EventExitSub
            End If

            Call Opt_Setfocus(optBy, 2, 0)

        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Function chk_medDocTo() As Boolean

        chk_medDocTo = False

        If Trim(medDocTo.Text) = "/  /" Then
            gsMsg = "Must input Date!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medDocTo.Focus()
            Exit Function
        End If

        If Chk_Date(medDocTo) = False Then
            gsMsg = "Invalid Date Format!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medDocTo.Focus()
            Exit Function
        End If


        chk_medDocTo = True

    End Function

    Private Sub medDocTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medDocTo.Leave
        FocusMe(medDocTo, True)
    End Sub


    Private Sub medChqDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medChqDate.Enter
        FocusMe(medChqDate)
    End Sub


    Private Sub medChqDate_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medChqDate.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_medChqDate = False Then
                GoTo EventExitSub
            End If

            cboBankAcc.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Function chk_medChqDate() As Boolean

        chk_medChqDate = False

        If Trim(medChqDate.Text) = "/  /" Then
            gsMsg = "Must input Date!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medChqDate.Focus()
            Exit Function
        End If

        If Chk_Date(medChqDate) = False Then
            gsMsg = "Invalid Date Format!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            medChqDate.Focus()
            Exit Function
        End If


        chk_medChqDate = True

    End Function


    Private Sub medChqDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medChqDate.Leave
        FocusMe(medChqDate, True)
    End Sub






    Private Sub optBy_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optBy.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim Index As Short = optBy.GetIndex(eventSender)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            Ini_Scr_AfrKey()
            medChqDate.Focus()

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name

            Case tcGo
                Ini_Scr_AfrKey()

            Case tcRefresh


            Case tcCancel
                cmdCancel()

            Case tcFont
                cmdFont()

            Case tcExit

                Me.Close()
        End Select

    End Sub

    Private Sub Ini_Form()

        Me.KeyPreview = True
        Me.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        Me.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        wsFormID = "GL002"
        wsConnTime = Dsp_Date(Now, True)

        lstData.SmallImageList = iglProcess
        lstData.CheckBoxes = True

        ' Dim lStyle As Long
        ' lStyle = SendMessage(lstData.hwnd, _
        ''    LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0)

        ' lStyle = LVS_EX_FULLROWSELECT
        ' Call SendMessage(lstData.hwnd, LVM_SETEXTENDEDLISTVIEWSTYLE, _
        ''    0, ByVal lStyle)



        'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        With cdFontFont
            'UPGRADE_ISSUE: Constant cdlCFBoth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
            'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdFont.flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            '.Flags = MSComDlg.FontsConstants.cdlCFBoth
            'UPGRADE_WARNING: MSComDlg.CommonDialog property cdFont.Flags was upgraded to cdFontFont.ScriptsOnly which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
            .ScriptsOnly = True
            'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
            '.CancelError = True
        End With





    End Sub

    Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick

        wcCombo.Text = tblCommon.Columns(0).Text
        wcCombo.Focus()
        tblCommon.Visible = False
        System.Windows.Forms.SendKeys.Send("{Enter}")


    End Sub

    Private Sub tblCommon_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCommon.KeyDownEvent

        If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
            eventArgs.keyCode = 0 ' System.Windows.Forms.Cursors.Default
            tblCommon.Visible = False
            wcCombo.Focus()

        ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then
            wcCombo.Text = tblCommon.Columns(0).Text
            tblCommon.Visible = False
            wcCombo.Focus()
            System.Windows.Forms.SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub tblCommon_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.Leave

        tblCommon.Visible = False
        If wcCombo.Enabled = True Then
            wcCombo.Focus()
        Else
            'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            wcCombo = Nothing
        End If

    End Sub







    Private Function chk_cboBankAcc() As Boolean
        Dim wsDesc As String
        chk_cboBankAcc = False

        If Trim(cboBankAcc.Text) = "" Then
            gsMsg = "Must input Bank Code!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboBankAcc.Focus()
            Exit Function
        End If

        If Chk_MLClass(cboBankAcc.Text, "B", wsDesc) = False Then
            gsMsg = "No Such Bank Account#"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            lblDspBankAcc.Text = ""
            cboBankAcc.Focus()
            Exit Function
        End If

        lblDspBankAcc.Text = wsDesc

        chk_cboBankAcc = True
    End Function
    Private Sub cboBankAcc_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBankAcc.DropDown
        Dim wsSQL As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        wcCombo = cboBankAcc

        wsSQL = "SELECT MLCODE, MLDESC "
        wsSQL = wsSQL & " FROM MSTMERCHCLASS "
        wsSQL = wsSQL & " WHERE MLCODE LIKE '%" & IIf(cboBankAcc.SelectionLength > 0, "", Set_Quote(cboBankAcc.Text)) & "%' "
        wsSQL = wsSQL & " AND MLSTATUS <> '2' "
        wsSQL = wsSQL & " AND MLTYPE = 'B' "
        Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboBankAcc.Left)), VB6.PixelsToTwipsY(cboBankAcc.Top) + VB6.PixelsToTwipsY(cboBankAcc.Height), tblCommon, wsFormID, "TBLBANKACC", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))

        tblCommon.Visible = True
        tblCommon.Focus()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cboBankAcc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBankAcc.Enter
        FocusMe(cboBankAcc)
        wcCombo = cboBankAcc
    End Sub

    Private Sub cboBankAcc_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboBankAcc.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Call chk_InpLen(cboBankAcc, 10, KeyAscii)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default

            If chk_cboBankAcc = False Then GoTo EventExitSub

            Ini_Scr_AfrKey()
            medDocFr.Focus()
        End If
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboBankAcc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBankAcc.Leave
        FocusMe(cboBankAcc, True)
    End Sub




    Private Function InputValidation() As Boolean

        InputValidation = False

        If chk_cboBankAcc = False Then
            Exit Function
        End If

        If chk_medDocFr = False Then
            Exit Function
        End If

        If chk_medDocTo = False Then
            Exit Function
        End If




        InputValidation = True

    End Function

    Private Function cmdSave() As Boolean

        Dim wsGenDte As String
        Dim adcmdSave As New ADODB.Command
        Dim wiCtr As Short
        Dim wsDocNo As String
        Dim wiRow As Short
        Dim wiCnt As Short

        On Error GoTo cmdSave_Err

        wiRow = 0
        If lstData.Items.Count <= 0 Then
            gsMsg = "No Record for process!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboBankAcc.Focus()
            Exit Function
        End If

        For wiCnt = 1 To lstData.Items.Count
            'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If lstData.Items.Item(wiCnt).Checked = True Then
                wiRow = wiRow + 1
            End If
        Next wiCnt

        If wiRow <= 0 Then
            gsMsg = "No Record for process!"
            MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
            cboBankAcc.Focus()
            Exit Function
        End If

        '    If ReadOnlyMode(wsConnTime, wsKeyType, cboBankAcc.Text, wsFormID) Then
        '           gsMsg = "記錄已被鎖定, 現在以唯讀模式開啟!"
        '           MsgBox gsMsg, vbOKOnly, gsTitle
        '           Exit Function
        '   End If

        Cursor = System.Windows.Forms.Cursors.WaitCursor


        '' Last Check when Add
        If chk_medChqDate = False Then
            'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
            'UPGRADE_ISSUE: Form property frmGL002.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
            Exit Function
        End If


        cnCon.BeginTrans()

        With lstData
            adcmdSave.ActiveConnection = cnCon

            adcmdSave.CommandText = "USP_GL002"
            adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            adcmdSave.Parameters.Refresh()

            For wiCnt = 1 To .Items.Count
                'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If .Items.Item(wiCnt).Checked = True Then

                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    Call SetSPPara(adcmdSave, 1, .Items.Item(wiCnt).Text)
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    Call SetSPPara(adcmdSave, 2, .Items.Item(wiCnt).SubItems(GCHQID).Text)
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    Call SetSPPara(adcmdSave, 3, .Items.Item(wiCnt).SubItems(GCHQNO).Text)
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    Call SetSPPara(adcmdSave, 4, IIf(.Items.Item(wiCnt).SubItems(GSTATUS).Text = "U", "R", "U"))
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    Call SetSPPara(adcmdSave, 5, IIf(.Items.Item(wiCnt).SubItems(GSTATUS).Text = "U", medChqDate.Text, ""))
                    Call SetSPPara(adcmdSave, 6, IIf(wiCnt = wiRow, "Y", "N"))
                    Call SetSPPara(adcmdSave, 7, wsFormID)
                    Call SetSPPara(adcmdSave, 8, gsUserID)
                    Call SetSPPara(adcmdSave, 9, Change_SQLDate(CStr(Now)))
                    adcmdSave.Execute()

                End If
            Next wiCnt

        End With

        cnCon.CommitTrans()

        gsMsg = "Bank Record Updated!"
        MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)

        'Call UnLockAll(wsConnTime, wsFormID)
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing
        cmdSave = True

        Cursor = System.Windows.Forms.Cursors.Default

        Call cmdCancel()

        Exit Function

cmdSave_Err:
        MsgBox(Err.Description)
        Cursor = System.Windows.Forms.Cursors.Default
        cnCon.RollbackTrans()
        'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        adcmdSave = Nothing

    End Function
	
	Private Sub Ini_Scr_AfrKey()
		Dim wsUsrId As String
		
		
		If LoadRecord() = True Then
			'    If RowLock(wsConnTime, wsKeyType, cboBankAcc.Text, wsFormID, wsUsrId) = False Then
			'        gsMsg = "記錄已被以下使用者鎖定 : " & wsUsrId
			'        MsgBox gsMsg, vbOKOnly, gsTitle
			'    End If
			cmdDelete.Focus()
			
		End If
		
		
		
	End Sub
End Class