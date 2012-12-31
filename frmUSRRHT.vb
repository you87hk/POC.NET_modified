Option Strict Off
Option Explicit On
Friend Class frmUSRRHT
	Inherits System.Windows.Forms.Form
	
	
	
	Dim NoOfRecord As Integer
	Dim wxSummary As New XArrayDBObject.XArrayDB
	Dim wxData As New XArrayDBObject.XArrayDB
	Dim wsField As New XArrayDBObject.XArrayDB
	Dim NoOfCol As Short
	
	
	
	
	
	Dim wsFormID As String
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
		
		
		Ini_Scr()
		
	End Sub
	
	
	
	
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		lblSummary.Text = ""
		
		cboGrpCode.Text = ""
		cboPgmID.Text = ""
		
		UpdStatusBar(picStatus, 0)
		
		IniColHeader()
		'  LoadRecord
		
		'DoEvents
		
		
	End Sub
	
	
	
	
	
	Private Sub cmdConvert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConvert.Click
		Dim i As Short
		
		
		If InputValidation = False Then Exit Sub
		
		If lstData.Items.Count > 0 Then
			With lstData
				For i = 1 To .Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If .Items.Item(i).Checked = True Then
						'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						Call cmdSave(.Items.Item(i).SubItems(1).Text, 1)
					Else
						'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						Call cmdSave(.Items.Item(i).SubItems(1).Text, 2)
					End If
				Next i
			End With
		End If
		
		
		Call cmdCancel()
		
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
	
	Private Sub frmUSRRHT_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F9
				LoadRecord()
				
			Case System.Windows.Forms.Keys.F11
				cmdCancel()
				
			Case System.Windows.Forms.Keys.F5
				RefreshListView()
				
			Case System.Windows.Forms.Keys.F6
				cmdFont()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
				
		End Select
		' KeyCode = vbDefault
	End Sub
	
	
	
	Private Sub frmUSRRHT_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Form()
		
		Ini_Caption()
		
		Ini_Scr()
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub frmUSRRHT_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object wxSummary may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wxSummary = Nothing
		'UPGRADE_NOTE: Object wxData may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wxData = Nothing
		'UPGRADE_NOTE: Object wsField may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wsField = Nothing
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmUSRRHT may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub LoadField()
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		
		
		On Error GoTo LoadField_Err
		
		'   wsSQL = " SELECT ScrFldID, ScrFldName, "
		'   wsSQL = wsSQL & " CASE WHEN USERTYPE IN (5, 6, 7, 8, 10, 11, 21, 24) THEN 'N' "
		'   wsSQL = wsSQL & " WHEN USERTYPE IN (12, 22, 80) THEN 'D' "
		'   wsSQL = wsSQL & " WHEN USERTYPE IN (19) THEN 'T' "
		'   wsSQL = wsSQL & " ELSE 'C' END AS ScrFldType FROM sysScrCaption, SYSCOLUMNS "
		'   wsSQL = wsSQL & " WHERE ScrType = 'FIL' "
		'   wsSQL = wsSQL & " AND SYSCOLUMNS.NAME = ScrFldID "
		'   wsSQL = wsSQL & " AND ScrPgmID = '" & Set_Quote(wsFormID) & "' "
		'   wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
		'   wsSQL = wsSQL & " AND ISNULL(RTRIM(ScrFldID), '') <> '' "
		'   wsSQL = wsSQL & " AND SYSCOLUMNS.Language = 0 "
		'   wsSQL = wsSQL & " ORDER BY ScrSeqNo "
		
		wsSQL = " SELECT ScrFldID, ScrFldName, "
		wsSQL = wsSQL & " 'C'AS ScrFldType FROM sysScrCaption "
		wsSQL = wsSQL & " WHERE ScrType = 'FIL' "
		wsSQL = wsSQL & " AND ScrPgmID = '" & Set_Quote(wsFormID) & "' "
		wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
		wsSQL = wsSQL & " AND ISNULL(RTRIM(ScrFldID), '') <> '' "
		wsSQL = wsSQL & " ORDER BY ScrSeqNo "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			MsgBox("No " & wsFormID & "in System")
			GoTo LoadField_Exit
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
		End If
		
		wsField.ReDim(1, 0, 0, 2)
		
		Do While Not rsRcd.EOF
			wsField.AppendRows()
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsField.get_Value(wsField.get_UpperBound(1), 0) = Trim(ReadRs(rsRcd, "ScrFldID"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsField.get_Value(wsField.get_UpperBound(1), 1) = Trim(ReadRs(rsRcd, "ScrFldName"))
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsField.get_Value(wsField.get_UpperBound(1), 2) = Trim(ReadRs(rsRcd, "ScrFldType"))
			rsRcd.MoveNext()
		Loop 
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		Exit Sub
		
LoadField_Err: 
		'DISPLAY ERROR FUNCTION
		MsgBox("LoadField Err!")
		
LoadField_Exit: 
		On Error Resume Next
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		
	End Sub
	Private Sub IniColHeader()
		
		Dim wiCtr As Short
		Dim clmX As System.Windows.Forms.ColumnHeader
		Dim ColWidth As Short
		
		On Error GoTo IniColHeader_Err
		
		lstData.Items.Clear()
		lstData.Columns.Clear()
		
		NoOfRecord = 0
		NoOfCol = wsField.get_UpperBound(1)
		wxSummary.ReDim(1, 2, 1, NoOfCol)
		wxData.ReDim(1, 0, 1, NoOfCol)
		
		
		ColWidth = IIf(NoOfCol > 10, VB6.PixelsToTwipsX(lstData.Width) / 10, VB6.PixelsToTwipsX(lstData.Width) / NoOfCol)
		For wiCtr = 1 To NoOfCol
			clmX = lstData.Columns.Add("", wsField.get_Value(wiCtr, 1), CInt(VB6.TwipsToPixelsX(IIf(wiCtr = 1, 1500, ColWidth))))
			If wsField.get_Value(wiCtr, 2) = "N" Then
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Else
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			End If
			clmX.Tag = wsField.get_Value(wiCtr, 2)
			wxSummary.get_Value(1, wiCtr) = 0
			wxSummary.get_Value(2, wiCtr) = "DESC"
		Next 
		
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
	
	
	
	
	
	Private Sub LoadData()
		
		Dim wiCtr As Short
		Dim wsSQL As String
		Dim wsText As String
		Dim inpParent As Object
		Dim wsDate As String
		Dim i As Integer
		Dim wsMid As String
		Dim wiRow As Integer
		Dim rsRcd As New ADODB.Recordset
		Dim wiStatus As Short
		
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		wsSQL = "SELECT ScrPgmID, SCRFLDID, SCRFLDNAME "
		wsSQL = wsSQL & " FROM SYSSCRCAPTION WHERE SCRTYPE = 'MNU' "
		wsSQL = wsSQL & " AND SCRFLDNAME <> '-' "
		' wsSql = wsSql & " AND SCRPGMID <> 'FILE' "
		wsSQL = wsSQL & " AND SCRLANGID = '" & gsLangID & "' "
		wsSQL = wsSQL & " AND SCRPGMID BETWEEN " & "'" & Set_Quote(cboPgmID.Text) & "'" & " AND " & "'" & IIf(Trim(cboPgmID.Text) = "", New String("z", 10), Set_Quote(cboPgmID.Text)) & "'"
		wsSQL = wsSQL & " ORDER BY SCRSEQNO "
		
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount = 0 Then
			rsRcd.Close()
			NoOfRecord = 0
			IniColHeader()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Me.Cursor = System.Windows.Forms.Cursors.Default
			Exit Sub
		Else
			NoOfRecord = rsRcd.RecordCount
			wxSummary.ReDim(1, 2, 1, NoOfCol)
			wxData.ReDim(1, NoOfRecord, 1, NoOfCol)
		End If
		
		
		
		With lstData
			For wiCtr = 1 To NoOfCol
				'UPGRADE_WARNING: Lower bound of collection lstData.ColumnHeaders has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				Select Case .Columns.Item(wiCtr).Tag
					Case "D", "T", "C"
						wxSummary.get_Value(1, wiCtr) = NoOfRecord
					Case Else
						wxSummary.get_Value(1, wiCtr) = 0
				End Select
				wxSummary.get_Value(2, wiCtr) = "DESC"
			Next 
			wiRow = 1
			Do Until rsRcd.EOF
				For wiCtr = 1 To NoOfCol
					'UPGRADE_WARNING: Lower bound of collection lstData.ColumnHeaders has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					Select Case .Columns.Item(wiCtr).Tag
						Case "N" 'NUMBER FIELD
							'inpParent = rsRcd(wiCtr - 1).Value
							wxSummary.get_Value(1, wiCtr) = To_Value(wxSummary.get_Value(1, wiCtr)) + To_Value(ReadRs(rsRcd, wsField.get_Value(wiCtr, 0)))
							wxData.get_Value(wiRow, wiCtr) = To_Value(ReadRs(rsRcd, wsField.get_Value(wiCtr, 0)))
						Case "T" 'TEXT FIELD
							'UPGRADE_WARNING: Couldn't resolve default property of object rsRcd().GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inpParent = Trim(rsRcd.Fields(wsField.get_Value(wiCtr, 0)).GetChunk(2048))
							wsText = ""
							'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
							If IsDbNull(inpParent) = False Then
								For i = 1 To Len(inpParent)
									'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
									wsMid = Mid(inpParent, i, 1)
									If wsMid = Chr(13) Then
										wsText = wsText & " "
									Else
										wsText = wsText & wsMid
									End If
								Next i
							End If
							wxData.get_Value(wiRow, wiCtr) = wsText
						Case "D"
							'inpParent = rsRcd(wiCtr - 1).Value
							'If IsNull(inpParent) Then
							'   wsDate = ""
							'Else
							'   wsDate = inpParent
							'   wsDate = Dsp_Date(wsDate)
							'End If
							wxData.get_Value(wiRow, wiCtr) = Dsp_Date(ReadRs(rsRcd, wsField.get_Value(wiCtr, 0)),  , True)
						Case "C"
							'inpParent = rsRcd(wiCtr - 1).Value
							'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							wxData.get_Value(wiRow, wiCtr) = ReadRs(rsRcd, wsField.get_Value(wiCtr, 0))
					End Select
				Next 
				wiRow = wiRow + 1
				If wiRow Mod 500 = 0 Then
					.Refresh()
					lblSummary.Text = wsMsg1 & CStr(wiRow)
					System.Windows.Forms.Application.DoEvents()
				End If
				rsRcd.MoveNext()
				wiStatus = wiStatus + Fix((1 / NoOfRecord) * (100))
				UpdStatusBar(picStatus, wiStatus)
			Loop 
		End With
		
		UpdStatusBar(picStatus, 100, True)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		
		
		
		RefreshListView()
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Exit Sub
		
LoadData_Err: 
		MsgBox(Err.Description)
		On Error Resume Next
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Sub
	
	
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
					
					If wxSummary.get_Value(2, wiSortIdx + 1) = "DESC" Then
						wxData.QuickSort(1, NoOfRecord, wiSortIdx + 1, XArrayDBObject.XORDER.XORDER_ASCEND, XArrayDBObject.XTYPE.XTYPE_DATE)
						wxSummary.get_Value(2, wiSortIdx + 1) = "ASC"
					Else
						wxData.QuickSort(1, NoOfRecord, wiSortIdx + 1, XArrayDBObject.XORDER.XORDER_DESCEND, XArrayDBObject.XTYPE.XTYPE_DATE)
						wxSummary.get_Value(2, wiSortIdx + 1) = "DESC"
					End If
					RefreshListView()
					
				Case Else
					'UPGRADE_ISSUE: MSComctlLib.ListView property lstData.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
                    '.Sorted = False
					If wxSummary.get_Value(2, wiSortIdx + 1) = "DESC" Then
						wxData.QuickSort(1, NoOfRecord, wiSortIdx + 1, XArrayDBObject.XORDER.XORDER_ASCEND, XArrayDBObject.XTYPE.XTYPE_DOUBLE)
						wxSummary.get_Value(2, wiSortIdx + 1) = "ASC"
					Else
						wxData.QuickSort(1, NoOfRecord, wiSortIdx + 1, XArrayDBObject.XORDER.XORDER_DESCEND, XArrayDBObject.XTYPE.XTYPE_DOUBLE)
						wxSummary.get_Value(2, wiSortIdx + 1) = "DESC"
					End If
					RefreshListView()
					
			End Select
			
			
			lblSummary.Text = columnheader.Text & " : " & wxSummary.get_Value(1, columnheader.Index)
		End With
		
		Cursor = System.Windows.Forms.Cursors.Default
		lstData.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	
	Private Sub RefreshListView()
		
		Dim wiRow As Integer
		Dim wiCol As Short
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim subX As System.Windows.Forms.ListViewItem.ListViewSubItem
		Dim wsImage As String
		
		
		wsImage = "book"
		
		
		With lstData
			.Items.Clear()
			For wiRow = 1 To NoOfRecord
				For wiCol = 1 To NoOfCol
					If wiCol = 1 Then
						'UPGRADE_WARNING: Lower bound of collection lstData.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						'UPGRADE_WARNING: Image property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="D94970AE-02E7-43BF-93EF-DCFCD10D27B5"'
						itmX = .Items.Add(wxData.get_Value(wiRow, wiCol), wsImage)
					Else
						'UPGRADE_ISSUE: MSComctlLib.ListSubItems method ListSubItems.Add was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'subX = itmX.SubItems.Add(wiCol - 1,  , wxData.get_Value(wiRow, wiCol))
					End If
				Next 
				If wiRow Mod 500 = 0 Then
					.Refresh()
					lblSummary.Text = wsMsg2 & CStr(wiRow)
					System.Windows.Forms.Application.DoEvents()
				End If
			Next 
		End With
		lblSummary.Text = wsMsg3
		'UPGRADE_NOTE: Object itmX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		itmX = Nothing
		'UPGRADE_NOTE: Object subX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		subX = Nothing
		
		
		UpdCheckBox()
		
	End Sub
	
	
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblGrpCode.Text = Get_Caption(waScrItm, "GRPCODE")
		lblPgmID.Text = Get_Caption(waScrItm, "PGMID")
		
		
		cmdConvert.Text = Get_Caption(waScrItm, "CMDCONVERT")
		cmdSelectAll.Text = Get_Caption(waScrItm, "CMDSELECTALL")
		cmdUnSelect.Text = Get_Caption(waScrItm, "CMDUNSELECT")
		
		fraSelect.Text = Get_Caption(waScrItm, "SELECT")
		
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
		tbrProcess.Items.Item(tcRefresh).ToolTipText = Get_Caption(waScrToolTip, tcRefresh) & "(F5)"
		tbrProcess.Items.Item(tcFont).ToolTipText = Get_Caption(waScrToolTip, tcFont) & "(F6)"
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		wsMsg1 = "1"
		wsMsg2 = "2"
		wsMsg3 = Get_Caption(waScrItm, "MSG3")
		
	End Sub
	
	
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click, _tbrProcess_Button5.Click, _tbrProcess_Button6.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		Select Case Button.Name
			
			Case tcGo
				LoadRecord()
				
			Case tcRefresh
				RefreshListView()
				
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
		wsFormID = "USRRHT"
		
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
		
		LoadField()
		
		
		
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
	
	Private Function LoadRecord() As Boolean
		
		
		LoadRecord = False
		
		If InputValidation = False Then Exit Function
		
		
		Call LoadData()
		
		
		LoadRecord = True
		
	End Function
	
	
	Private Sub cboGrpCode_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCode.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboGrpCode
		
		wsSQL = "SELECT DISTINCT USRGRPCODE "
		wsSQL = wsSQL & " FROM mstUser "
		wsSQL = wsSQL & " WHERE USRGRPCODE LIKE '%" & IIf(cboGrpCode.SelectionLength > 0, "", Set_Quote(cboGrpCode.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY USRGRPCODE "
		Call Ini_Combo(1, wsSQL, (VB6.PixelsToTwipsX(cboGrpCode.Left)), VB6.PixelsToTwipsY(cboGrpCode.Top) + VB6.PixelsToTwipsY(cboGrpCode.Height), tblCommon, wsFormID, "TBLGRPCODE", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboGrpCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCode.Enter
		FocusMe(cboGrpCode)
		wcCombo = cboGrpCode
	End Sub
	
	Private Sub cboGrpCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboGrpCode.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboGrpCode, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboGrpCode = False Then GoTo EventExitSub
			
			LoadRecord()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboGrpCode_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrpCode.Leave
		FocusMe(cboGrpCode, True)
	End Sub
	
	
	Private Sub cboPgmID_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPgmID.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboPgmID
		
		
		wsSQL = "select ScrPgmID , min(ScrSeqNo) Seq from sysScrCaption "
		wsSQL = wsSQL & " WHERE ScrType = 'MNU' "
		wsSQL = wsSQL & " AND ScrPgmID <> 'FILE' "
		wsSQL = wsSQL & " AND ScrType = 'MNU' "
		wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
		wsSQL = wsSQL & " AND ScrPgmID LIKE '%" & IIf(cboPgmID.SelectionLength > 0, "", Set_Quote(cboPgmID.Text)) & "%' "
		wsSQL = wsSQL & " Group By ScrPgmID "
		wsSQL = wsSQL & " Order By Seq "
		
		
		Call Ini_Combo(1, wsSQL, (VB6.PixelsToTwipsX(cboPgmID.Left)), VB6.PixelsToTwipsY(cboPgmID.Top) + VB6.PixelsToTwipsY(cboPgmID.Height), tblCommon, wsFormID, "TBLPgmID", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboPgmID_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPgmID.Enter
		FocusMe(cboPgmID)
		wcCombo = cboPgmID
	End Sub
	
	Private Sub cboPgmID_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboPgmID.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboPgmID, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			LoadRecord()
			
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboPgmID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPgmID.Leave
		FocusMe(cboPgmID, True)
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_cboGrpCode = False Then
			Exit Function
		End If
		
		
		InputValidation = True
		
	End Function
	
	Private Function cmdSave(ByVal InPgmID As String, ByVal inAction As Short) As Boolean
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wiCtr As Short
		Dim wsBatchNo As String
		
		On Error GoTo cmdSave_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		wsGenDte = gsSystemDate
		
		'' Last Check when Add
		
		
		
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_USRRHT"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		Call SetSPPara(adcmdSave, 1, inAction)
		Call SetSPPara(adcmdSave, 2, cboGrpCode.Text)
		Call SetSPPara(adcmdSave, 3, InPgmID)
		Call SetSPPara(adcmdSave, 4, gsUserID)
		Call SetSPPara(adcmdSave, 5, wsGenDte)
		adcmdSave.Execute()
		
		
		cnCon.CommitTrans()
		
		
		'Call UnLockAll(wsConnTime, wsFormID)
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
	
	Private Function Chk_cboGrpCode() As Boolean
		Dim wsStatus As String
		
		Chk_cboGrpCode = False
		
		If Trim(cboGrpCode.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboGrpCode.Focus()
			Exit Function
		End If
		
		If Chk_GrpCode(cboGrpCode.Text) = False Then
			gsMsg = "群組不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboGrpCode.Focus()
			Exit Function
		End If
		
		Chk_cboGrpCode = True
		
	End Function
	
	
	Private Sub UpdCheckBox()
		Dim i As Short
		If lstData.Items.Count > 0 Then
			With lstData
				For i = 1 To .Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If Chk_GrpRight((cboGrpCode.Text), .Items.Item(i).SubItems(1).Text) = True Then
						'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						.Items.Item(i).Checked = True
					End If
				Next i
			End With
		End If
	End Sub
End Class