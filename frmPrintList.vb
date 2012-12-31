Option Strict Off
Option Explicit On
Friend Class frmPrintList
	Inherits System.Windows.Forms.Form
	
	Private Const PrintFrom As Short = 0
	Private Const PrintTo As Short = 1
	Private Const ItemField As Short = 1
	Private Const ItemNumFlag As Short = 2
	
	Dim msFields As Object
	Dim msNoOfCol As Short
	Dim msPgmId As String
	Dim msQuery As String
	Dim msRptTitle As String
	Dim NoOfRecord As Integer
	Dim wsMsg1 As String
	Dim wsMsg2 As String
	Dim wsMsg3 As String
	Dim wxSummary As New XArrayDBObject.XArrayDB
	Dim wxData As New XArrayDBObject.XArrayDB
	Dim waScrItm As New XArrayDBObject.XArrayDB
	
	
	Private Const tcFont As String = "Font"
	Private Const tcExit As String = "Exit"
	
	
	
	Property Fields() As Object
		Get
			
			'UPGRADE_WARNING: Couldn't resolve default property of object msFields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Fields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Fields = msFields
			
		End Get
		Set(ByVal Value As Object)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object NewFields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object msFields. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			msFields = Value
			
		End Set
	End Property
	
	
	Property NoOfCol() As Short
		Get
			
			NoOfCol = msNoOfCol
			
		End Get
		Set(ByVal Value As Short)
			
			msNoOfCol = Value
			
		End Set
	End Property
	
	
	Property RptTitle() As String
		Get
			
			RptTitle = msRptTitle
			
		End Get
		Set(ByVal Value As String)
			
			msRptTitle = Value
			
		End Set
	End Property
	
	
	Property Query() As String
		Get
			
			Query = msQuery
			
		End Get
		Set(ByVal Value As String)
			
			msQuery = Value
			
		End Set
	End Property
	
	
	
	Private Sub cmdFont()
		
		Dim wfFont As System.Drawing.Font
		
		On Error GoTo FontErr
		
        Dim dr As Integer = cdFontFont.ShowDialog()
		lstData.Font = VB6.FontChangeName(lstData.Font, cdFontFont.Font.Name)
		lstData.Font = VB6.FontChangeBold(lstData.Font, cdFontFont.Font.Bold)
		lstData.Font = VB6.FontChangeItalic(lstData.Font, cdFontFont.Font.Italic)
		lstData.Font = VB6.FontChangeSize(lstData.Font, cdFontFont.Font.Size)
		lstData.Refresh()
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
		
FontErr: 
		'UPGRADE_ISSUE: MSComDlg.CommonDialog property cdFont.CancelError was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If dr = DialogResult.Cancel Then
            Exit Sub
        End If
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmPrintList.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmPrintList_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Caption()
		
		Ini_Scr()
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Ini_Scr()
		
		'Me.Width = Screen.Width
		'Me.Height = Screen.Height
		lblRptTitle.Text = Me.RptTitle
		lstData.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - 240)
		lstData.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 2000)
		lblRptTitle.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - 240)
		lblRptTitle.Left = VB6.TwipsToPixelsX(120)
		' lblRptTitle.Top = 120
		lstData.Left = VB6.TwipsToPixelsX(120)
		' lstData.Top = 240 + lblRptTitle.Height
		'   lblSummary.Top = lstData.Top + lstData.Height + 120
		'   cmdFont.Top = lblSummary.Top
		'   cmdExit.Top = lblSummary.Top
		
		lstData.Items.Clear()
		
		Dim lStyle As Integer
		lStyle = SendMessage(lstData.Handle.ToInt32, LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0)
		
		lStyle = LVS_EX_FULLROWSELECT
		Call SendMessage(lstData.Handle.ToInt32, LVM_SETEXTENDEDLISTVIEWSTYLE, 0, lStyle)
		
		
		
		
		lblSummary.Text = ""
		System.Windows.Forms.Application.DoEvents()
		
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
		
		IniColHeader()
		'DoEvents
		
		LoadData()
		
	End Sub
	
	Private Sub frmPrintList_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			
			
			Case System.Windows.Forms.Keys.F9
				
				cmdFont()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
		
		
		' KeyCode = vbDefault
	End Sub
	
	Private Sub frmPrintList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.KeyPreview = True
	End Sub
	
	Private Sub frmPrintList_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object wxSummary may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wxSummary = Nothing
		'UPGRADE_NOTE: Object wxData may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wxData = Nothing
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object frmPrintList may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Sub IniColHeader()
		
		Dim wsSQL As String
		Dim wiCtr As Short
		Dim clmX As System.Windows.Forms.ColumnHeader
		Dim ColWidth As Short
		
		ColWidth = IIf(Me.NoOfCol > 10, VB6.PixelsToTwipsX(lstData.Width) / 10, VB6.PixelsToTwipsX(lstData.Width) / Me.NoOfCol)
		For wiCtr = 1 To Me.NoOfCol
			clmX = lstData.Columns.Add("", Me.Fields(wiCtr, 1), CInt(VB6.TwipsToPixelsX(ColWidth)))
			'UPGRADE_WARNING: Couldn't resolve default property of object Me.Fields(wiCtr, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Me.Fields(wiCtr, 2) = "N" And wiCtr > 1 Then
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Else
				clmX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object Me.Fields(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			clmX.Tag = Me.Fields(wiCtr, 2)
		Next 
		
		With lstData
			'UPGRADE_ISSUE: MSComctlLib.ListView method lstData.DragMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            '.DragMode = 0
			'UPGRADE_ISSUE: MSComctlLib.ListView property lstData.Sorted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
            '.Sorted = False
		End With
		
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
		Dim adReport As New ADODB.Recordset
		
		adReport.Open(Me.Query, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adReport.RecordCount = 0 Then
			adReport.Close()
			'UPGRADE_NOTE: Object adReport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			adReport = Nothing
			Exit Sub
		Else
			NoOfRecord = adReport.RecordCount
			wxSummary.ReDim(1, 2, 1, Me.NoOfCol)
			wxData.ReDim(1, NoOfRecord, 1, Me.NoOfCol)
		End If
		
		With lstData
			For wiCtr = 1 To Me.NoOfCol
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
			Do Until adReport.EOF
				For wiCtr = 1 To Me.NoOfCol
					'UPGRADE_WARNING: Lower bound of collection lstData.ColumnHeaders has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					Select Case .Columns.Item(wiCtr).Tag
						Case "N" 'NUMBER FIELD
							'inpParent = adReport(wiCtr - 1).Value
							wxSummary.get_Value(1, wiCtr) = To_Value(wxSummary.get_Value(1, wiCtr)) + To_Value(ReadRs(adReport, wiCtr - 1))
							wxData.get_Value(wiRow, wiCtr) = To_Value(ReadRs(adReport, wiCtr - 1))
						Case "T" 'TEXT FIELD
							'UPGRADE_WARNING: Couldn't resolve default property of object adReport().GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object inpParent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inpParent = Trim(adReport.Fields(wiCtr - 1).GetChunk(2048))
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
							'inpParent = adReport(wiCtr - 1).Value
							'If IsNull(inpParent) Then
							'   wsDate = ""
							'Else
							'   wsDate = inpParent
							'   wsDate = Dsp_Date(wsDate)
							'End If
							wxData.get_Value(wiRow, wiCtr) = Dsp_Date(ReadRs(adReport, wiCtr - 1),  , True)
						Case "C"
							'inpParent = adReport(wiCtr - 1).Value
							'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							wxData.get_Value(wiRow, wiCtr) = ReadRs(adReport, wiCtr - 1)
					End Select
				Next 
				wiRow = wiRow + 1
				If wiRow Mod 500 = 0 Then
					.Refresh()
					lblSummary.Text = wsMsg1 & CStr(wiRow)
					System.Windows.Forms.Application.DoEvents()
				End If
				adReport.MoveNext()
			Loop 
		End With
		Me.Cursor = System.Windows.Forms.Cursors.Default
		RefreshListView()
		
		adReport.Close()
		'UPGRADE_NOTE: Object adReport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adReport = Nothing
		
		Exit Sub
		
LoadData_Err: 
		MsgBox(Err.Description)
		On Error Resume Next
		adReport.Close()
		'UPGRADE_NOTE: Object adReport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adReport = Nothing
		
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
		
		With lstData
			.Items.Clear()
			For wiRow = 1 To NoOfRecord
				For wiCol = 1 To Me.NoOfCol
					If wiCol = 1 Then
						itmX = .Items.Add(wxData.get_Value(wiRow, wiCol))
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
		
	End Sub
	
	Private Sub Ini_Caption()
		
		Call Get_Scr_Item("PRINTLIST", waScrItm)
		
		Me.Text = Get_Caption(waScrItm, "SCRHDR")
		'  cmdFont.Caption = Get_Caption(waScrItm, "FONT")
		'  cmdExit.Caption = Get_Caption(waScrItm, "EXIT")
		'  wsMsg1 = Get_Caption(waScrItm, "PROCESS1")
		'  wsMsg2 = Get_Caption(waScrItm, "PROCESS2")
		'  wsMsg3 = Get_Caption(waScrItm, "PROCESS3")
		wsMsg1 = "1"
		wsMsg2 = "2"
		wsMsg3 = Get_Caption(waScrItm, "MSG3")
		
	End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		Select Case Button.Name
			Case tcFont
				cmdFont()
				
			Case tcExit
				
				Me.Close()
		End Select
		
	End Sub
End Class