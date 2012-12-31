Option Strict Off
Option Explicit On
Friend Class frmPURGE
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
	
	Private wsPgmID As String
	Private wsStatus As String
	
	
	
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
		
		cboTblName.Text = ""
		lstData.Columns.Clear()
		lstData.Items.Clear()
		
		UpdStatusBar(picStatus, 0)
		
		'  IniColHeader
		'  LoadRecord
		
		'DoEvents
		
		
	End Sub
	
	
	
	
	
	
	
	Private Sub cmdPurge_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPurge.Click
		Dim i As Short
		Dim wsCrt As String
		
		If InputValidation = False Then Exit Sub
		
		If lstData.Items.Count > 0 Then
			With lstData
				For i = 1 To .Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If .Items.Item(i).Checked = True Then
						If wsField.get_Value(1, 2) = "N" Then
							'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							wsCrt = wsField.get_Value(1, 0) & " = " & .Items.Item(i).Text
						Else
							'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							wsCrt = wsField.get_Value(1, 0) & " = '" & .Items.Item(i).Text & "'"
						End If
						If cmdSave(wsCrt, 1) = False Then Exit Sub
					End If
				Next i
			End With
		End If
		
		gsMsg = "清除成功!"
		MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		Call cmdCancel()
		
	End Sub
	
	Private Sub cmdRecycle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRecycle.Click
		Dim i As Short
		Dim wsCrt As String
		
		If InputValidation = False Then Exit Sub
		
		If lstData.Items.Count > 0 Then
			With lstData
				For i = 1 To .Items.Count
					'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If .Items.Item(i).Checked = True Then
						If wsField.get_Value(1, 2) = "N" Then
							'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							wsCrt = wsField.get_Value(1, 0) & " = " & .Items.Item(i).Text
						Else
							'UPGRADE_WARNING: Lower bound of collection lstData.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							wsCrt = wsField.get_Value(1, 0) & " = '" & .Items.Item(i).Text & "'"
						End If
						If cmdSave(wsCrt, 2) = False Then Exit Sub
					End If
				Next i
			End With
		End If
		
		gsMsg = "再用成功!"
		MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
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
	
	Private Sub frmPURGE_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	
	
	Private Sub frmPURGE_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Ini_Form()
		
		Ini_Caption()
		
		Ini_Scr()
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub frmPURGE_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
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
		'UPGRADE_NOTE: Object frmPURGE may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	Private Function LoadField() As Boolean
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		
		
		On Error GoTo LoadField_Err
		LoadField = False
		
		wsSQL = " SELECT ScrFldID, ScrFldName, "
		wsSQL = wsSQL & " CASE WHEN USERTYPE IN (5, 6, 7, 8, 10, 11, 21, 24) THEN 'N' "
		wsSQL = wsSQL & " WHEN USERTYPE IN (12, 22, 80) THEN 'D' "
		wsSQL = wsSQL & " WHEN USERTYPE IN (19) THEN 'T' "
		wsSQL = wsSQL & " ELSE 'C' END AS ScrFldType FROM sysScrCaption, SYSCOLUMNS "
		wsSQL = wsSQL & " WHERE ScrType = 'FIL' "
		wsSQL = wsSQL & " AND SYSCOLUMNS.NAME = ScrFldID "
		wsSQL = wsSQL & " AND ScrPgmID = '" & Set_Quote(wsPgmID) & "' "
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
		
		LoadField = True
		
		Exit Function
		
LoadField_Err: 
		'DISPLAY ERROR FUNCTION
		MsgBox("LoadField Err!")
		
LoadField_Exit: 
		On Error Resume Next
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		
	End Function
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
			If wsField.get_Value(wiCtr, 2) = "N" And wiCtr <> 1 Then
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
		
		
		
		Select Case UCase(wsPgmID)
			Case "CR001"
				wsSQL = "SELECT CRegCusID, CusCode, CRegRegNo, CRegLen, CRegPrefix, CREGLASTUPD, CREGLASTUPDDATE "
				wsSQL = wsSQL & " FROM MstCusReg, MstCustomer "
				wsSQL = wsSQL & " WHERE CRegStatus = '2' "
				wsSQL = wsSQL & " And CRegCusID = CusID "
				wsSQL = wsSQL & " ORDER BY CusCode "
				
			Case "AT001"
				
				wsSQL = "SELECT ACCTYPECODE, ACCTYPECODE, ACCTYPEDESC, ACCTYPELASTUPD, ACCTYPELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstACCOUNTTYPE "
				wsSQL = wsSQL & " WHERE ACCTYPEStatus = '2' "
				wsSQL = wsSQL & " ORDER BY ACCTYPECode "
				
			Case "ITM001"
				
				wsSQL = "SELECT ITMID, ITMCODE, ITMBARCODE, ITMCHINAME, ITMLASTUPD , ITMLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstITEM "
				wsSQL = wsSQL & " WHERE ITMStatus = '2' "
				wsSQL = wsSQL & " ORDER BY ITMCODE "
				
			Case "C001"
				
				wsSQL = "SELECT CUSID, CUSCODE, CUSNAME, CUSTEL, CUSFAX, CUSLASTUPD , CUSLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstCUSTOMER "
				wsSQL = wsSQL & " WHERE CUSStatus = '2' "
				wsSQL = wsSQL & " ORDER BY CUSCODE "
				
			Case "CAT001"
				
				wsSQL = "SELECT CATCODE, CATCODE, CATDESC, CATLASTUPD , CATLASTUPDDATE  "
				wsSQL = wsSQL & " FROM mstCategory "
				wsSQL = wsSQL & " WHERE CatStatus = '2' "
				wsSQL = wsSQL & " ORDER BY CATCODE "
				
			Case "CD001"
				
				wsSQL = "SELECT CDISCODE, CDISCODE, CDISDESC, CDISLASTUPD , CDISLASTUPDDATE  "
				wsSQL = wsSQL & " FROM mstCategoryDiscount "
				wsSQL = wsSQL & " WHERE CDISStatus = '2' "
				wsSQL = wsSQL & " ORDER BY CDISCODE "
				
				
			Case "EXC001"
				
				wsSQL = "SELECT EXCID, EXCYR, EXCMN, EXCCURR, EXCDESC, EXCRATE, EXCBRATE, EXCLASTUPD , EXCLASTUPDDATE  "
				wsSQL = wsSQL & " FROM mstEXCHANGERATE "
				wsSQL = wsSQL & " WHERE EXCStatus = '2' "
				wsSQL = wsSQL & " ORDER BY EXCYR, EXCMN, EXCCURR "
				
				
				'   Case "IP001A"
				
				'    wsSql = "SELECT CUSITEMID, ITMCODE, CUSCODE, CUSITEMCURR, CUSITEMLASTUPD , CUSITEMLASTUPDDATE  "
				'    wsSql = wsSql & " FROM mstCusItem, mstITEM, mstCustomer "
				'    wsSql = wsSql & " WHERE CUSITEMStatus = '2' "
				'    wsSql = wsSql & " And CUSITEMCUSID = CusID "
				'    wsSql = wsSql & " And CUSITEMITMID = ItmID "
				'   wsSql = wsSql & " ORDER BY ITMCODE, CUSCODE, CUSITEMCURR "
				
				
				'  Case "IP001B"
				
				'    wsSql = "SELECT VDRITEMID, ITMCODE, VDRCODE, VDRITEMCURR, VDRITEMLASTUPD , VDRITEMLASTUPDDATE  "
				'    wsSql = wsSql & " FROM mstVDRItem, mstITEM, mstVendor "
				'    wsSql = wsSql & " WHERE VDRITEMStatus = '2' "
				'    wsSql = wsSql & " And VDRITEMVDRID = VDRID "
				'    wsSql = wsSql & " And VDRITEMITMID = ItmID "
				'    wsSql = wsSql & " ORDER BY ITMCODE, VDRCODE, VDRITEMCURR "
				
				
			Case "IT001"
				
				wsSQL = "SELECT ITMTYPECODE, ITMTYPECODE, ITMTYPECHIDESC, ITMTYPEENGDESC, ITMTYPELASTUPD, ITMTYPELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstITEMTYPE "
				wsSQL = wsSQL & " WHERE ITMTYPEStatus = '2' "
				wsSQL = wsSQL & " ORDER BY ITMTYPECode "
				
			Case "L001"
				
				wsSQL = "SELECT LANGCODE, LANGCODE, LANGDESC, LANGPREFIX, LANGLASTUPD, LANGLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstLANGUAGE "
				wsSQL = wsSQL & " WHERE LANGStatus = '2' "
				wsSQL = wsSQL & " ORDER BY LANGCode "
				
				
			Case "LVL001"
				
				wsSQL = "SELECT LEVELCODE, LEVELCODE, LEVELDESC, LEVELLASTUPD, LEVELLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstLEVEL "
				wsSQL = wsSQL & " WHERE LEVELStatus = '2' "
				wsSQL = wsSQL & " ORDER BY LEVELCode "
				
				
			Case "M001"
				
				wsSQL = "SELECT METHODCODE, METHODCODE, METHODDESC, METHODLASTUPD, METHODLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstMETHOD "
				wsSQL = wsSQL & " WHERE METHODStatus = '2' "
				wsSQL = wsSQL & " ORDER BY METHODCode "
				
				
			Case "ML001"
				
				wsSQL = "SELECT MLCODE, MLCODE, MLDESC, MLLASTUPD, MLLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstMERCHCLASS "
				wsSQL = wsSQL & " WHERE MLStatus = '2' "
				wsSQL = wsSQL & " ORDER BY MLCode "
				
			Case "N001"
				
				wsSQL = "SELECT NATURECODE, NATURECODE, NATUREDESC, NATURELASTUPD, NATURELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstNATURE "
				wsSQL = wsSQL & " WHERE NATUREStatus = '2' "
				wsSQL = wsSQL & " ORDER BY NATURECode "
				
			Case "PR001"
				
				wsSQL = "SELECT PRCCODE, PRCCODE, PRCDESC, PRICEPORT, PRCLASTUPD, PRCLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstPriceTerm "
				wsSQL = wsSQL & " WHERE PRCStatus = '2' "
				wsSQL = wsSQL & " ORDER BY PRCCode "
				
			Case "PS001"
				
				wsSQL = "SELECT PRINTSIZECODE, PRINTSIZECODE, PRINTSIZEDESC, PRINTSIZELASTUPD, PRINTSIZELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstPrintSize "
				wsSQL = wsSQL & " WHERE PRINTSIZEStatus = '2' "
				wsSQL = wsSQL & " ORDER BY PRINTSIZECode "
				
			Case "PT001"
				
				wsSQL = "SELECT PACKTYPECODE, PACKTYPECODE, PACKTYPEDESC, PACKTYPELASTUPD, PACKTYPELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstPACKINGTYPE "
				wsSQL = wsSQL & " WHERE PACKTYPEStatus = '2' "
				wsSQL = wsSQL & " ORDER BY PACKTYPECode "
				
			Case "PYT001"
				
				wsSQL = "SELECT PAYCODE, PAYCODE, PAYDESC, PAYLASTUPD, PAYLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstPAYTERM "
				wsSQL = wsSQL & " WHERE PAYStatus = '2' "
				wsSQL = wsSQL & " ORDER BY PAYCode "
				
			Case "RMK001"
				
				wsSQL = "SELECT RMKCODE, RMKCODE, RMKDESC1, RMKLASTUPD, RMKLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstREMARK "
				wsSQL = wsSQL & " WHERE RMKStatus = '2' "
				wsSQL = wsSQL & " ORDER BY RMKCode "
				
			Case "S001"
				
				wsSQL = "SELECT STORECODE, STORECODE, STOREDESC, STORELASTUPD, STORELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstSTORE "
				wsSQL = wsSQL & " WHERE STOREStatus = '2' "
				wsSQL = wsSQL & " ORDER BY STORECode "
				
			Case "SD001"
				
				wsSQL = "SELECT SDID, SDMETHODCODE, SDNATURECODE, SDCDISCODE, SDDISCOUNT, SALEDISCOUNTLASTUPD, SALEDISCOUNTLASTUPDDATE  "
				wsSQL = wsSQL & " FROM mstSALEDISCOUNT "
				wsSQL = wsSQL & " WHERE SALEDISCOUNTStatus = '2' "
				wsSQL = wsSQL & " ORDER BY SDMETHODCODE, SDNATURECODE, SDCDISCODE "
				
			Case "SHP001"
				
				wsSQL = "SELECT SHIPCODE, SHIPNAME, SHIPADR1, SHIPADR2, SHIPADR3, SHIPADR4, SHIPTELNO, SHIPFAXNO, SHIPPER, SHIPREMARK, SHIPLASTUPD, SHIPLASTUPDDATE  "
				wsSQL = wsSQL & " FROM mstSHIP "
				wsSQL = wsSQL & " WHERE SHIPStatus = '2' "
				wsSQL = wsSQL & " ORDER BY SHIPCODE "
				
			Case "SLM001"
				
				wsSQL = "SELECT SALECODE, SALECODE, SALENAME, SALELASTUPD, SALELASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstSALESMAN "
				wsSQL = wsSQL & " WHERE SALEStatus = '2' "
				wsSQL = wsSQL & " ORDER BY SALECode "
				
			Case "TERR001"
				
				wsSQL = "SELECT TERRCODE, TERRCODE, TERRDESC, TERRLASTUPD, TERRLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstTerritory "
				wsSQL = wsSQL & " WHERE TERRStatus = '2' "
				wsSQL = wsSQL & " ORDER BY TERRCode "
				
			Case "UOM001"
				
				wsSQL = "SELECT UOMCODE, UOMCODE, UOMDESC, UOMLASTUPD, UOMLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstUOM "
				wsSQL = wsSQL & " WHERE UOMStatus = '2' "
				wsSQL = wsSQL & " ORDER BY UOMCode "
				
				
			Case "V001"
				
				wsSQL = "SELECT VDRID, VDRCODE, VDRNAME, VDRTEL, VDRFAX, VDRLASTUPD , VDRLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstVENDOR "
				wsSQL = wsSQL & " WHERE VDRStatus = '2' "
				wsSQL = wsSQL & " ORDER BY VDRCODE "
				
				
			Case "WH001"
				
				wsSQL = "SELECT WHSCODE, WHSCODE, WHSDESC, WHSLASTUPD, WHSLASTUPDDATE  "
				wsSQL = wsSQL & " FROM MstWAREHOUSE "
				wsSQL = wsSQL & " WHERE WHSStatus = '2' "
				wsSQL = wsSQL & " ORDER BY WHSCode "
				
			Case "COA001"
				
				wsSQL = "SELECT COAACCID, COAACCCODE, COAACCCODE, COADesc, COALastUpd, COALastUpdDate  "
				wsSQL = wsSQL & " FROM Mstcoa "
				wsSQL = wsSQL & " WHERE COAStatus = '2' "
				wsSQL = wsSQL & " ORDER BY COAACCCODE "
				
				
			Case Else
				GoTo LoadData_Err
		End Select
		
		
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
		
		
		
		
	End Sub
	
	
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblTblName.Text = Get_Caption(waScrItm, "TABLENAME")
		
		
		cmdPurge.Text = Get_Caption(waScrItm, "cmdPurge")
		cmdRecycle.Text = Get_Caption(waScrItm, "cmdRecycle")
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
		wsFormID = "PURGE"
		
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
		
		' LoadField
		
		
		
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
		
		If LoadField Then
			Call IniColHeader()
			Call LoadData()
		End If
		
		LoadRecord = True
		
	End Function
	
	
	Private Sub cboTblName_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTblName.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboTblName
		
		If gsLangID = "2" Then
			wsSQL = "SELECT TblTableID, TblTableNameChinese "
		Else
			wsSQL = "SELECT TblTableID, TblTableName "
		End If
		wsSQL = wsSQL & " FROM sysMstTable "
		wsSQL = wsSQL & " WHERE TblTableID LIKE '%" & IIf(cboTblName.SelectionLength > 0, "", Set_Quote(cboTblName.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY TblTableID "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboTblName.Left)), VB6.PixelsToTwipsY(cboTblName.Top) + VB6.PixelsToTwipsY(cboTblName.Height), tblCommon, wsFormID, "TBLTblName", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboTblName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTblName.Enter
		FocusMe(cboTblName)
		wcCombo = cboTblName
	End Sub
	
	Private Sub cboTblName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboTblName.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboTblName, 10, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
			
			If Chk_cboTblName = False Then GoTo EventExitSub
			
			LoadRecord()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboTblName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTblName.Leave
		FocusMe(cboTblName, True)
	End Sub
	
	
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If Chk_cboTblName = False Then
			Exit Function
		End If
		
		
		InputValidation = True
		
	End Function
	
	Private Function cmdSave(ByVal inCrt As String, ByVal inAction As Short) As Boolean
		
		Dim wsGenDte As String
		Dim adcmdSave As New ADODB.Command
		Dim wiCtr As Short
		Dim wsSQL As String
		
		On Error GoTo cmdSave_Err
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		cmdSave = False
		cnCon.BeginTrans()
		
		If inAction = 1 Then
			
			wsSQL = "DELETE FROM " & Set_Quote(cboTblName.Text) & " Where " & Set_Quote(wsStatus) & " = '2' And " & inCrt
			cnCon.Execute(wsSQL)
			
			wsSQL = "UPDATE sysMstTable SET TblLastPurgeDate = '" & gsSystemDate & "' Where TblTableID = '" & Set_Quote(cboTblName.Text) & "'"
			cnCon.Execute(wsSQL)
			
			
			
		Else
			
			wsSQL = "UPDATE " & Set_Quote(cboTblName.Text) & " Set " & Set_Quote(wsStatus) & " = '1' Where " & inCrt
			cnCon.Execute(wsSQL)
			
			
		End If
		
		
		cnCon.CommitTrans()
		
		
		'Call UnLockAll(wsConnTime, wsFormID)
		
		cmdSave = True
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		Exit Function
		
cmdSave_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		
		
	End Function
	
	Private Function Chk_cboTblName() As Boolean
		
		
		Chk_cboTblName = False
		
		If Trim(cboTblName.Text) = "" Then
			gsMsg = "沒有輸入須要之資料!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboTblName.Focus()
			Exit Function
		End If
		
		If Chk_TblName(cboTblName.Text, wsPgmID, wsStatus) = False Then
			gsMsg = "Table不存在!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
			cboTblName.Focus()
			Exit Function
		End If
		
		Chk_cboTblName = True
		
	End Function
End Class