Option Strict Off
Option Explicit On

Imports Microsoft.Office.Interop

Module modHH
	Public Function ExportToHHFile(ByVal inPath As String, ByVal InTrnCd As String, ByVal InDocID As String, ByVal inMode As Short, ByVal wsWhs As String) As Boolean
		Dim wsGenDte As Object
		Dim wsSQL As Object
		'inID - Document ID
		'inPath - File Path for file to export to
		'inMode - Mode: 1 - Overwrite, 2 - Append
		
		Dim adExport As New ADODB.Recordset
		Dim adUpdFlg As New ADODB.Command
		Dim sBuffer As String
		
		
		Dim wiDocID As Short
		Dim wsDefWhs As String
		
		
		
		
		'wsDefWhs = Get_WorkStation_Info("WSWHSCODE")
		wsDefWhs = wsWhs
		
		ExportToHHFile = False
		
		Select Case InTrnCd
			Case "PO"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT 'GRN' AS TYPE ,POHDDOCNO AS DOCNO, POHDREFNO AS JOBNO, ITMBINNO LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " ITMCODE, (PODTQTY- PODTSCHQTY) * PODTCF AS QTY, 0 LINE "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " FROM POPPOHD, POPPODT, MSTITEM "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " WHERE POHDDOCID = PODTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND POHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND PODTQTY > PODTSCHQTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " ORDER BY POHDDOCNO, ITMCODE "
				
			Case "GR"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT 'GRN' AS TYPE ,GRHDDOCNO AS DOCNO, POHDREFNO AS JOBNO, ITMBINNO LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " ITMCODE, GRDTQTY * GRDTCF AS QTY, 0 LINE "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " FROM POPGRHD, POPGRDT, POPPOHD, MSTITEM "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " WHERE GRHDDOCID = GRDTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND GRHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND GRHDREFDOCID = POHDDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND GRDTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " ORDER BY GRHDDOCNO, ITMCODE "
				
				
			Case "SP"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT 'PCK' AS TYPE ,SOHDDOCNO AS DOCNO, SOHDDOCNO AS JOBNO, SPDTWHSCODE LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " SOPTJDOCLINE LINE, ITMCODE, SUM(SPDTQTY - SPDTOUTQTY) QTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " From SOASOHD, SOASPHD, SOASPDT, MSTITEM, SOASODT, SOASOPTJ "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " Where SPHDDOCID = SPDTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SPHDREFDOCID = SOHDDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SOHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SPDTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SPDTQTY > SPDTOUTQTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SPDTSODTID = SODTID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SPDTSOID = SODTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SODTPTJID  = SOPTJID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " GROUP BY SOHDDOCNO, SOPTJDOCLINE, SPDTWHSCODE, ITMCODE "
				
			Case "SW"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT 'PCK' AS TYPE ,SOHDDOCNO AS DOCNO, SOHDDOCNO AS JOBNO, SWDTWHSCODE LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " SOPTJDOCLINE LINE, ITMCODE, SUM(SWDTQTY - SWDTOUTQTY) QTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " From SOASOHD, SOASWHD, SOASWDT, MSTITEM, SOASODT, SOASOPTJ "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " Where SWHDDOCID = SWDTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SWHDREFDOCID = SOHDDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SOHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SWDTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SWDTQTY > SWDTOUTQTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SWDTSODTID = SODTID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SWDTSOID = SODTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SODTPTJID  = SOPTJID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " GROUP BY SOHDDOCNO, SOPTJDOCLINE, SWDTWHSCODE, ITMCODE "
				
			Case "SO"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT 'PCK' AS TYPE ,SOHDDOCNO AS DOCNO, SOHDDOCNO AS JOBNO, SODTWHSCODE LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " SOPTJDOCLINE LINE, ITMCODE, SUM(SODTTOTQTY - SODTSCHQTY) QTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " FROM SOASOHD, SOASOPTJ, SOASODT, MSTITEM "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " WHERE SOHDDOCID = SOPTJDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SOPTJID = SODTPTJID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SOHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SODTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SODTTOTQTY > SODTSCHQTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " GROUP BY SOHDDOCNO, SODTWHSCODE, SOPTJDOCLINE, ITMCODE "
				
				
			Case "TR"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT CASE WHEN SJDTTRNTYPE = 'STKIN' THEN 'TRI' ELSE 'TRO' END AS TYPE ,SJHDDOCNO AS DOCNO, SJHDJOBNO AS JOBNO, SJDTWHSCODE LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " ITMCODE, SJDTQTY QTY, 0 LINE "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " FROM ICSTKADJ, ICSTKADJDT, MSTITEM "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " WHERE SJHDDOCID = SJDTDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SJHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SJDTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SJDTWHSCODE = '" & wsDefWhs & "' "
				
				
			Case "DN"
				
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = "SELECT 'DN' AS TYPE ,SOHDDOCNO AS DOCNO, SOHDDOCNO AS JOBNO, SODTWHSCODE LOC, "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " SOPTJDOCLINE LINE, ITMCODE, SUM(SODTTOTQTY) QTY "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " FROM SOASOHD, SOASOPTJ, SOASODT, MSTITEM "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " WHERE SOHDDOCID = SOPTJDOCID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SOPTJID = SODTPTJID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SOHDDOCID = " & To_Value(InDocID) & " "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " AND SODTITEMID = ITMID "
				'UPGRADE_WARNING: Couldn't resolve default property of object wsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				wsSQL = wsSQL & " GROUP BY SOHDDOCNO, SODTWHSCODE, SOPTJDOCLINE, ITMCODE "
				
				
		End Select
		
		
		adExport.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If adExport.RecordCount <= 0 Then
			gsMsg = "No Record can be匯出!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			adExport.Close()
			'UPGRADE_NOTE: Object adExport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			adExport = Nothing
			Exit Function
		End If
		
		adExport.MoveFirst()
		
		If inMode = 1 Then
			FileOpen(1, inPath, OpenMode.Output)
		Else
			FileOpen(1, inPath, OpenMode.Append)
		End If
		Do While Not adExport.EOF
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sBuffer = Set_FixLenStr(ReadRs(adExport, "TYPE"), 3)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sBuffer = sBuffer & Set_FixLenStr(ReadRs(adExport, "DOCNO"), 15)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sBuffer = sBuffer & Set_FixLenStr(ReadRs(adExport, "JOBNO"), 15)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sBuffer = sBuffer & Set_FixLenStr(ReadRs(adExport, "LOC"), 10)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sBuffer = sBuffer & Set_FixLenStr(ReadRs(adExport, "ITMCODE"), 30)
			sBuffer = sBuffer & Set_FixLenInt(0, 8) 'HHT Qty
			'  sBuffer = sBuffer & Set_FixLenInt(To_Value(ReadRs(adExport, "QTY")), 8)
			sBuffer = sBuffer & Set_FixLenLong(To_Value(ReadRs(adExport, "QTY")), 8)
			
			sBuffer = sBuffer & Set_FixLenStr("", 1) 'Match Flag
			sBuffer = sBuffer & Set_FixLenStr("", 10) 'Staff ID
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sBuffer = sBuffer & Set_FixLineNo(ReadRs(adExport, "JOBNO"), To_Value(ReadRs(adExport, "LINE")))
			sBuffer = sBuffer & Set_FixLenStr("", 1) 'ABC Flag
			
			
			'Write #1, sBuffer
			PrintLine(1, sBuffer)
			
			
			adExport.MoveNext()
		Loop 
		FileClose(1)
		
		adExport.Close()
		'UPGRADE_NOTE: Object adExport may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adExport = Nothing
		
		'UPGRADE_WARNING: Couldn't resolve default property of object wsGenDte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wsGenDte = gsSystemDate
		
		'  cnCon.BeginTrans
		'  wsSql = "UPDATE soaLXHD SET LXHDUPDFLG = 'Y' "
		'  wsSql = wsSql & " WHERE LXHDDOCID = " & wiDocID
		
		' cnCon.Execute wsSql
		'    cnCon.CommitTrans
		
		ExportToHHFile = True
	End Function
	
	
	Public Function ImportFromHH(ByVal InUserID As String, ByVal inDteTim As String, ByVal inPath As String) As Boolean
		'inUserID - User ID
		'inDteTim - Date time
		'inPath - File Path for file to import from
		
		Dim sfile As String
		Dim sFileName As String
		Dim sExt As String
		
		
		Dim SDATE As String
		Dim iNum As Short
		Dim sType As String
		
		Dim sBuffer As String
		
		Dim wsTrnCd As String
		Dim wsDocNo As String
		Dim wsJobNo As String
		Dim wsLoc As String
		Dim wsItem As String
		Dim wiHHQty As String
		Dim wiQty As String
		Dim wsMatch As String
		Dim wsFirst As String
		Dim wsStaff As String
		Dim wsLine As String
		Dim wsABC As String
		
		
		Dim adCmd As New ADODB.Command
		
		ImportFromHH = False
		
		On Error GoTo ImportFromHH_Err
		
		
		
		
		sfile = Right(inPath, Len(inPath) - InStrRev(inPath, "\"))
		sFileName = Left(sfile, InStr(sfile, ".") - 1)
		sExt = Right(sfile, Len(sfile) - InStr(sfile, "."))
		wsFirst = "Y"
		
		If UCase(sExt) = "TXT" Or UCase(sExt) = "XLS" Or UCase(sExt) = "DOC" Or UCase(sExt) = "BAK" Or UCase(sExt) = "FLD" Then
			Exit Function
		End If
		
		SDATE = Year(Now) & "/" & Left(sFileName, 2) & "/" & Mid(sFileName, 3, 2)
		iNum = To_Value(Mid(sFileName, 5, 2))
		sType = Right(sFileName, 1)
		
		cnCon.BeginTrans()
		adCmd.ActiveConnection = cnCon
		
		
		FileOpen(1, inPath, OpenMode.Input)
		Do While Not EOF(1) ' Loop until end of file.
			sBuffer = LineInput(1) ' Read data into two variables.
			
			Select Case sType
				
				Case "D"
					
					wsTrnCd = Left(sBuffer, 3)
					wsDocNo = Mid(sBuffer, 4, 15)
					wsJobNo = Mid(sBuffer, 19, 15)
					wsLoc = Mid(sBuffer, 34, 10)
					wsItem = Mid(sBuffer, 44, 30)
					wiHHQty = CStr(To_Value(Mid(sBuffer, 74, 8)))
					wiQty = CStr(To_Value(Mid(sBuffer, 82, 8)))
					wsMatch = Mid(sBuffer, 90, 1)
					
					wsStaff = Mid(sBuffer, 91, 10)
					wsLine = CStr(To_Value(Mid(sBuffer, 101, 3)))
					wsABC = CStr(To_Value(Mid(sBuffer, 104, 1)))
					
					
					adCmd.CommandText = "USP_HHIM001"
					adCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
					adCmd.Parameters.Refresh()
					
					Call SetSPPara(adCmd, 1, InUserID)
					Call SetSPPara(adCmd, 2, inDteTim)
					Call SetSPPara(adCmd, 3, sFileName & sExt)
					Call SetSPPara(adCmd, 4, sExt)
					Call SetSPPara(adCmd, 5, SDATE)
					Call SetSPPara(adCmd, 6, iNum)
					
					Call SetSPPara(adCmd, 7, wsTrnCd)
					Call SetSPPara(adCmd, 8, Trim(wsDocNo))
					Call SetSPPara(adCmd, 9, wsJobNo)
					Call SetSPPara(adCmd, 10, wsLoc)
					Call SetSPPara(adCmd, 11, Trim(wsItem))
					Call SetSPPara(adCmd, 12, wiHHQty)
					Call SetSPPara(adCmd, 13, wiQty)
					Call SetSPPara(adCmd, 14, wsMatch)
					Call SetSPPara(adCmd, 15, wsFirst)
					
					Call SetSPPara(adCmd, 16, wsStaff)
					Call SetSPPara(adCmd, 17, wsLine)
					Call SetSPPara(adCmd, 18, wsABC)
					
					adCmd.Execute()
					
					wsFirst = "N"
					
					
				Case "S"
					
					wsTrnCd = "STK"
					wsDocNo = ""
					wsJobNo = ""
					wsLoc = Left(sBuffer, 10)
					wsItem = Mid(sBuffer, 11, 30)
					wiHHQty = CStr(To_Value(Mid(sBuffer, 41, 8)))
					wiQty = CStr(0)
					wsMatch = ""
					
					wsStaff = ""
					wsLine = CStr(0)
					wsABC = ""
					
					
					adCmd.CommandText = "USP_HHIM001"
					adCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
					adCmd.Parameters.Refresh()
					
					Call SetSPPara(adCmd, 1, InUserID)
					Call SetSPPara(adCmd, 2, inDteTim)
					Call SetSPPara(adCmd, 3, sFileName & sExt)
					Call SetSPPara(adCmd, 4, sExt)
					Call SetSPPara(adCmd, 5, SDATE)
					Call SetSPPara(adCmd, 6, iNum)
					
					Call SetSPPara(adCmd, 7, wsTrnCd)
					Call SetSPPara(adCmd, 8, Trim(wsDocNo))
					Call SetSPPara(adCmd, 9, wsJobNo)
					Call SetSPPara(adCmd, 10, wsLoc)
					Call SetSPPara(adCmd, 11, Trim(wsItem))
					Call SetSPPara(adCmd, 12, wiHHQty)
					Call SetSPPara(adCmd, 13, wiQty)
					Call SetSPPara(adCmd, 14, wsMatch)
					Call SetSPPara(adCmd, 15, wsFirst)
					
					Call SetSPPara(adCmd, 16, wsStaff)
					Call SetSPPara(adCmd, 17, wsLine)
					Call SetSPPara(adCmd, 18, wsABC)
					
					adCmd.Execute()
					
					wsFirst = "N"
					
					
				Case "U"
					
					wsTrnCd = "USR"
					wsDocNo = ""
					wsJobNo = ""
					wsLoc = ""
					wsItem = ""
					wiHHQty = CStr(0)
					wiQty = CStr(0)
					wsMatch = ""
					wsStaff = Left(sBuffer, 10)
					wsLine = CStr(0)
					wsABC = ""
					
					
					adCmd.CommandText = "USP_HHIM001"
					adCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
					adCmd.Parameters.Refresh()
					
					Call SetSPPara(adCmd, 1, InUserID)
					Call SetSPPara(adCmd, 2, inDteTim)
					Call SetSPPara(adCmd, 3, sFileName & sExt)
					Call SetSPPara(adCmd, 4, sExt)
					Call SetSPPara(adCmd, 5, SDATE)
					Call SetSPPara(adCmd, 6, iNum)
					
					Call SetSPPara(adCmd, 7, wsTrnCd)
					Call SetSPPara(adCmd, 8, Trim(wsDocNo))
					Call SetSPPara(adCmd, 9, wsJobNo)
					Call SetSPPara(adCmd, 10, wsLoc)
					Call SetSPPara(adCmd, 11, Trim(wsItem))
					Call SetSPPara(adCmd, 12, wiHHQty)
					Call SetSPPara(adCmd, 13, wiQty)
					Call SetSPPara(adCmd, 14, wsMatch)
					Call SetSPPara(adCmd, 15, wsFirst)
					
					Call SetSPPara(adCmd, 16, wsStaff)
					Call SetSPPara(adCmd, 17, wsLine)
					Call SetSPPara(adCmd, 18, wsABC)
					
					adCmd.Execute()
					
					wsFirst = "N"
					
			End Select
		Loop 
		FileClose(1)
		
		cnCon.CommitTrans()
		'UPGRADE_NOTE: Object adCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adCmd = Nothing
		
		'If wsFirst = "Y" Then
		'    gsMsg = sFileName & " 沒有紀錄匯入!"
		'    MsgBox gsMsg, vbOKOnly, gsTitle
		'End If
		
		
		ImportFromHH = True
		Exit Function
		
ImportFromHH_Err: 
		
		
		MsgBox("ImportFromHH_Err!" & Err.Description)
		cnCon.RollbackTrans()
		
		'UPGRADE_NOTE: Object adCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adCmd = Nothing
		
	End Function
	
	
	Public Function Chk_HHNo(ByVal InHHNo As String, ByRef OutUpdFlg As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT HHUPDFLG "
		wsSQL = wsSQL & "FROM SYSHHIM001 "
		wsSQL = wsSQL & "WHERE HHNO = '" & Set_Quote(InHHNo) & "' "
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutUpdFlg = ReadRs(rsRcd, "HHUPDFLG")
			Chk_HHNo = True
		Else
			OutUpdFlg = ""
			Chk_HHNo = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
	End Function
	Public Function SendToHH(ByVal inPath As String) As Boolean
		
		Dim X As Integer
		Dim DosCmd As String
		
		
		
		On Error GoTo SendToHH_Err
		
		
		DosCmd = gsHHPath & "\IT3CW32.EXE +B115200 +P1 " & inPath & " +E +V"
		X = Shell(DosCmd, AppWinStyle.MaximizedFocus)
		
		SendToHH = True
		
		Exit Function
		
SendToHH_Err: 
		
		
		MsgBox("SendToHH_Err!" & Err.Description)
		SendToHH = False
		
	End Function
	
	Public Function ReceiveFromHH(ByVal inPath As String) As Boolean
		
		Dim X As Integer
		Dim DosCmd As String
		
		
		On Error GoTo ReceiveFromHH_Err
		
		
		DosCmd = gsHHPath & "\IT3CW32.EXE +RC +B115200 +P1 +V +E +L0 " & inPath & "(FILE)"
		
		X = Shell(DosCmd, AppWinStyle.MaximizedFocus)
		
		ReceiveFromHH = True
		
		
		Exit Function
		
ReceiveFromHH_Err: 
		
		MsgBox("ReceiveFromHH_Err!" & Err.Description)
		ReceiveFromHH = False
		
		
		
	End Function
	
	
	Public Function Init_Excel_BC(ByRef woExcelSheet1 As Object, ByRef xlApp2 As Object) As Short
		Dim xlLandscape As Object
		
		Dim xlSheet2 As Object
		
		' Variables used to format the selection criteria
		' within the MS Excel Header and Footer
		Dim wsLeftHdr As String
		Dim wsCenterHdr As String
		Dim wsRightHdr As String
		Dim wsLeftFtr As String
		Dim wsRightFtr As String
		Dim wsTxt As String
		Dim wsLeftTxt As String
		Dim wsMid As String
		Dim wiLenHdr As Short
		Dim wiLenFtr As Short
		Dim wiFor As Short
		Dim wiCtr As Short
		Dim wiOldCtr As Short
		Dim wbOk As Boolean
		Dim wbDot As Boolean
		Dim wbTxtEmpty As Boolean
		Dim wsTitle As String
		
		' End of variables
		
		Init_Excel_BC = False
		
		'GET THE REQUIRED DATA FROM RPTHDR
		On Error GoTo Excel_Err
		'woExcelSheet1.PageSetup.PrintTitleRows = woExcelSheet1.Rows(1).Address
		'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		woExcelSheet1.PageSetup.PrintTitleRows = "$1:$2"
		'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		woExcelSheet1.PageSetup.PrintTitleColumns = "$A:$A"
		
		' ************************** WORKSHEET (DATA) ************************** '
		'PAGE SETUP
		'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		With woExcelSheet1.PageSetup
			'CREATE FOOTER
			wsLeftFtr = "&""Times New Roman""&6"
			wsRightFtr = "&""Times New Roman""&8Page &P of &N"
			wiLenFtr = Len(wsLeftFtr) + Len(wsRightFtr)
			
			'CREATE HEADER
			wsRightHdr = "&""Times New Roman""&8USER: " & gsUserID & vbLf & "   DATE: " & Change_SQLDate(gsSystemDate)
			wsCenterHdr = "&""Times New Roman,Bold""&10" & wsTitle
			wsLeftHdr = "&""Times New Roman""&8" & wsTitle & "&6" & vbLf & vbLf
			wiLenHdr = Len(wsRightHdr) + Len(wsCenterHdr) + Len(wsLeftHdr)
			
			
			'SET HEADER
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.LeftHeader = wsLeftHdr
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterHeader = wsCenterHdr
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.RightHeader = wsRightHdr
			
			'SET FOOTER
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.LeftFooter = wsLeftFtr & IIf(wbDot = True, New String(".", 10), "")
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterFooter = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.RightFooter = wsRightFtr
			
			'SET ALIGNMENT
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterHorizontally = True
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CenterVertically = False
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.TopMargin = xlApp2.InchesToPoints(0.78)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.BottomMargin = xlApp2.InchesToPoints(0.35)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.LeftMargin = xlApp2.InchesToPoints(0.2)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.RightMargin = xlApp2.InchesToPoints(0.2)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.HeaderMargin = xlApp2.InchesToPoints(0.2)
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp2.InchesToPoints. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.FooterMargin = xlApp2.InchesToPoints(0.2)
			
			'SET PAGE ORIENTATION
			'UPGRADE_WARNING: Couldn't resolve default property of object woExcelSheet1.PageSetup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xlLandscape. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Orientation = xlLandscape
			
		End With
		
		''GENERAL CELL/S SETUP
		'With woExcelSheet1
		'   .Cells.Select
		'   .Cells.Font.FontStyle = "Regular"
		'   .Cells.Font.Name = "Times New Roman"
		'   .Cells.Font.Size = 8
		'   .Cells.Borders.Weight = xlThin
		'   .Range("A1").Select
		'End With
		
		
		'UPGRADE_NOTE: Object xlSheet2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet2 = Nothing
		Init_Excel_BC = True
		
		Exit Function
		
Excel_Err: 
		MsgBox("Exel_err")
		On Error Resume Next
		'UPGRADE_NOTE: Object xlSheet2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet2 = Nothing
		
	End Function
	
	
	
	Public Sub LoadExcel_BC(ByVal inFilePath As String)
		Dim MousePointer As Object
		Dim Excel As Object
		
		Dim xlApp As Excel.Application
		
		On Error GoTo LoadExcel_BC_Err
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If UCase(inFilePath) Like "*" & UCase(Dir(inFilePath)) & "*" And Trim(Dir(inFilePath)) <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object MousePointer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MousePointer = System.Windows.Forms.Cursors.WaitCursor
			xlApp = CreateObject("Excel.Application")
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xlApp.Visible = False
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'xlApp.Workbooks.Open(Trim(inFilePath), ReadOnly_Renamed:=True)
			'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xlApp.Visible = True
		Else
			gsMsg = "File Not Existing!"
			MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		End If
		
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		'UPGRADE_WARNING: Couldn't resolve default property of object MousePointer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MousePointer = System.Windows.Forms.Cursors.Default
		
		Exit Sub
		
LoadExcel_BC_Err: 
		MsgBox("Can't Display: LoadExcel_BC_err!")
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		
	End Sub
	
	Public Function PrintExcel_BC(ByVal InTrnCd As String, ByVal InDocID As String) As Boolean
		
		
		Dim xlApp As Object
		Dim xlBook As Object
		Dim xlSheet1 As Object
		Dim rsRcd As New ADODB.Recordset
		Dim rsItmRcd As New ADODB.Recordset
		
		Dim OldCusCd As String
		
		Dim wsSQL As String 'SQL statement
		Dim wlCtr As Integer
		Dim NoOfRecord As Integer 'Number of Record
		Dim TotRow As Integer
		Dim CurRow As Integer
		Dim CurCol As Short
		Dim NoOfLabal As Short
		Dim i As Short
		
		
		Dim wsExcelName As String
		
		
		On Error GoTo Excel_Print_Err1
		
		'Load Rcd
		PrintExcel_BC = False
		
		
		Select Case InTrnCd
			Case "ITM"
				
				wsSQL = "SELECT ITMCODE CODE, ITMCHINAME INAME, SUM((PODTQTY- PODTSCHQTY) * PODTCF) AS QTY "
				wsSQL = wsSQL & " FROM POPPODT, MSTITEM "
				wsSQL = wsSQL & " WHERE PODTDOCID IN (" & InDocID & ") "
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				wsSQL = wsSQL & " AND PODTQTY > PODTSCHQTY "
				wsSQL = wsSQL & " GROUP BY ITMCODE, ITMCHINAME "
				wsSQL = wsSQL & " ORDER BY ITMCODE, ITMCHINAME "
				
				
				wsExcelName = gsHHPath & "barcode\ITMCODE.XLS"
				
			Case "JOB"
				
				wsSQL = "SELECT POHDREFNO CODE, '' INAME, SUM((PODTQTY- PODTSCHQTY) * PODTCF) AS QTY "
				wsSQL = wsSQL & " FROM POPPOHD, POPPODT, MSTITEM "
				wsSQL = wsSQL & " WHERE POHDDOCID = PODTDOCID "
				wsSQL = wsSQL & " AND PODTDOCID IN (" & InDocID & ") "
				wsSQL = wsSQL & " AND PODTITEMID = ITMID "
				wsSQL = wsSQL & " AND PODTQTY > PODTSCHQTY "
				wsSQL = wsSQL & " AND ISNULL(POHDREFNO,'') <> '' "
				wsSQL = wsSQL & " GROUP BY POHDREFNO "
				wsSQL = wsSQL & " ORDER BY POHDREFNO "
				
				wsExcelName = gsHHPath & "barcode\JOBNO.XLS"
				
		End Select
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			' gsMsg = IIf(gsLangID = "1", "No Data at this period or selection!", "沒有數據在此選擇!")
			' MsgBox gsMsg, vbOKOnly, gsTitle
			PrintExcel_BC = True
			Exit Function
		End If
		
		'CONSTRUCT THE SELECT FIELDS STRING AND SUMMARY STRING
		
		On Error GoTo Excel_Print_Err2
		
		xlApp = CreateObject("EXCEL.Application")
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Visible. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Visible = False
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.SheetsInNewWorkbook. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.SheetsInNewWorkbook = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlBook = xlApp.Workbooks.Add
		'Set xlSheet1 = xlApp.Workbooks(1).Worksheets(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object xlBook.Sheets. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlSheet1 = xlBook.Sheets.Add
		
		'   If Init_Excel_BC(xlSheet1, xlApp) = False Then GoTo Excel_Print_Err1
		
		
		
		'Construct the summary select statement
		NoOfRecord = rsRcd.RecordCount
		wlCtr = 0
		TotRow = 0
		CurCol = 1
		CurRow = 1
		
		
		rsRcd.MoveFirst()
		Do While Not rsRcd.EOF
			
			NoOfLabal = To_Value(ReadRs(rsRcd, "QTY"))
			
			If CurCol >= 200 Then
				CurCol = 2
				wlCtr = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object xlBook.Sheets. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1 = xlBook.Sheets.Add
				'     If Init_Excel_BC(xlSheet1, xlApp) = False Then GoTo Excel_Print_Err1
			End If
			
			If wlCtr = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Name = InTrnCd
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Cells(CurRow, 1) = IIf(InTrnCd = "ITM", "ITEM", "JOB NO")
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Cells(CurRow, 1).Interior.ColorIndex = 15
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Cells(CurRow, 2) = IIf(InTrnCd = "ITM", "DESCRIPTION", "")
				'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xlSheet1.Cells(CurRow, 2).Interior.ColorIndex = 15
				
				CurRow = CurRow + 1
			End If
			
			If NoOfLabal > 0 Then
				For i = 1 To NoOfLabal
					'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlSheet1.Cells(CurRow, 1).Value = ReadRs(rsRcd, "CODE")
					'UPGRADE_WARNING: Couldn't resolve default property of object xlSheet1.Cells. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					xlSheet1.Cells(CurRow, 2).Value = ReadRs(rsRcd, "INAME")
					CurRow = CurRow + 1
				Next i
			End If
			
			
			'            With xlSheet1.Range(xlSheet1.Cells(1, 2).Address, xlSheet1.Cells(CurRow - 1, CurCol + 2).Address)
			'            .Interior.ColorIndex = 15
			'            .WrapText = True
			'            .Borders(xlTop).Weight = xlMedium
			'            .Borders(xlRight).Weight = xlMedium
			'            .Borders(xlLeft).Weight = xlMedium
			'            .Borders(xlBottom).Weight = xlMedium
			'.AutoFit
			'            End With
			
			'            xlSheet1.Cells(CurRow, CurCol).NumberFormat = gsAmtFmt
			'            xlSheet1.Cells(CurRow, CurCol + 2).Borders(xlRight).Weight = xlMedium
			
			
			
			wlCtr = wlCtr + 1
			TotRow = TotRow + 1
			rsRcd.MoveNext()
		Loop 
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		
PrintExcel_BC_Save: 
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Workbooks(1).Worksheets(1).SaveAs(wsExcelName)
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Quit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Quit()
		'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet1 = Nothing
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		MsgBox(wsExcelName & " Finish")
		PrintExcel_BC = True
		
		'      Call LoadExcel(txtFilePath.Text)
		
		
		Exit Function
		
Excel_Print_Err1: 
		MsgBox("Excel_Print_Err1")
		On Error Resume Next
		'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet1 = Nothing
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		
		Exit Function
		
Excel_Print_Err2: 
		If Err.Number = 1004 Then
			PrintExcel_BC = True
		Else
			MsgBox(Err.Number & " Excel_Print_Err2")
		End If
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Workbooks("BOOK1").Saved = True
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Workbooks. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Workbooks.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object xlApp.Quit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xlApp.Quit()
		'UPGRADE_NOTE: Object xlSheet1 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlSheet1 = Nothing
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		
	End Function
	Public Function Set_FixLenStr(ByVal inText As String, ByVal inLen As Short) As String
		Dim iCtr As Short
		Dim outText As String
		
		outText = Trim(inText)
		
		If Len(inText) < inLen Then
			For iCtr = 1 To inLen - Len(outText)
				outText = outText & " "
				
			Next iCtr
		Else
			outText = Left(outText, inLen)
		End If
		Set_FixLenStr = outText
		
	End Function
	
	Public Function Set_FixLenInt(ByVal inNum As Short, ByVal inLen As Short) As String
		Dim iCtr As Short
		Dim outText As String
		
		
		
		outText = CStr(inNum)
		
		If Len(outText) < inLen Then
			For iCtr = 1 To inLen - Len(outText)
				' outText = " " + outText
				outText = outText & " "
				
			Next iCtr
		Else
			outText = Right(outText, inLen)
		End If
		Set_FixLenInt = outText
		
	End Function
	
	Public Function Set_FixLenLong(ByVal inNum As Integer, ByVal inLen As Short) As String
		Dim iCtr As Short
		Dim outText As String
		
		
		
		outText = CStr(inNum)
		
		If Len(outText) < inLen Then
			For iCtr = 1 To inLen - Len(outText)
				' outText = " " + outText
				outText = outText & " "
				
			Next iCtr
		Else
			outText = Right(outText, inLen)
		End If
		Set_FixLenLong = outText
		
	End Function
	
	
	Public Function Set_FixLineNo(ByVal inJob As String, ByVal inNum As Short) As String
		Dim iCtr As Short
		Dim outText As String
		
		If Trim(inJob) = "" Then
			outText = Set_FixLenStr("", 3)
		Else
			If inNum = 0 Then
				outText = Set_FixLenInt(0, 3)
			Else
				outText = VB6.Format(inNum, "000")
			End If
			
		End If
		
		Set_FixLineNo = outText
		
	End Function
End Module