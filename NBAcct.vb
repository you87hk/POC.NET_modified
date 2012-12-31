Option Strict Off
Option Explicit On
Module NBAcct
	
	Public Function Chk_MLClass(ByVal inCode As String, ByVal inType As String, ByRef OutDesc As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT MLDesc FROM mstMerchClass WHERE MLCode = '" & Set_Quote(inCode) & "' "
		wsSQL = wsSQL & "And MLStatus = '1' "
		wsSQL = wsSQL & "And MLType = '" & inType & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutDesc = ReadRs(rsRcd, "MLDesc")
			Chk_MLClass = True
			
		Else
			
			OutDesc = ""
			Chk_MLClass = False
			
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
	Public Function Get_DueDte(ByVal inPayCode As String, ByVal inDocDate As String) As String
		
		Dim adDueDte As New ADODB.Command
		
		On Error GoTo Get_DueDte_Err
		
		adDueDte.ActiveConnection = cnCon
		
		adDueDte.CommandText = "USP_PAYDUE"
		adDueDte.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adDueDte.Parameters.Refresh()
		
		Call SetSPPara(adDueDte, 1, inPayCode)
		Call SetSPPara(adDueDte, 2, Change_SQLDate(inDocDate))
		adDueDte.Execute()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Get_DueDte = GetSPPara(adDueDte, 3)
		
		'UPGRADE_NOTE: Object adDueDte may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adDueDte = Nothing
		
		Exit Function
		
Get_DueDte_Err: 
		MsgBox("Get_DueDte Error!")
		'UPGRADE_NOTE: Object adDueDte may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adDueDte = Nothing
		
	End Function
	
	Public Function Get_FiscalPeriod(ByVal inDate As Object) As String
		
		Dim adCommand As New ADODB.Command
		
		On Error GoTo Get_FiscalPeriod_Err
		
		adCommand.ActiveConnection = cnCon
		
		adCommand.CommandText = "USP_getFiscalPeriod"
		adCommand.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adCommand.Parameters.Refresh()
		
		Call SetSPPara(adCommand, 1, inDate)
		adCommand.Execute()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(adCommand, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Get_FiscalPeriod = GetSPPara(adCommand, 2) & GetSPPara(adCommand, 3)
		
		'UPGRADE_NOTE: Object adCommand may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adCommand = Nothing
		
		Exit Function
		
Get_FiscalPeriod_Err: 
		MsgBox("Get_FiscalPeriod Error!")
		'UPGRADE_NOTE: Object adCommand may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adCommand = Nothing
		
	End Function
	
	Public Function Chk_VouPrefix(ByVal inCode As String) As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		
		wsSQL = "SELECT * FROM sysVouNo WHERE VouPrefix = '" & Set_Quote(inCode) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			Chk_VouPrefix = True
		Else
			Chk_VouPrefix = False
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
	
	
	Public Function Chk_AutoVou(ByVal inDocTyp As String) As String
		
		Dim rst As New ADODB.Recordset
		Dim Criteria As String
		
		Chk_AutoVou = "N"
		
		Criteria = "SELECT VouLastKey FROM sysVouNo "
		Criteria = Criteria & " WHERE VouPrefix = '" & Set_Quote(inDocTyp) & "'"
		rst.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rst.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Chk_AutoVou = ReadRs(rst, "VouLastKey")
		End If
		
		rst.Close()
		'UPGRADE_NOTE: Object rst may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst = Nothing
		
	End Function
	
	Public Function Chk_CurrInMod(ByRef InCurr As String, ByRef inMod As String) As Boolean
		
		Dim rsCurCod As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_CurrInMod = False
		
		wsSQL = "SELECT EXCCURR, EXCDESC FROM mstEXCHANGERATE, SYSMONCTL "
		wsSQL = wsSQL & " WHERE EXCMN = CONVERT(INTEGER, MCCTLMN) "
		wsSQL = wsSQL & " AND EXCYR = MCCTLYR "
		wsSQL = wsSQL & " AND EXCSTATUS = '1' "
		wsSQL = wsSQL & " AND MCMODNO = '" & inMod & "' "
		wsSQL = wsSQL & "ORDER BY EXCCURR "
		
		
		rsCurCod.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsCurCod.RecordCount <= 0 Then
			rsCurCod.Close()
			'UPGRADE_NOTE: Object rsCurCod may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsCurCod = Nothing
			Exit Function
		End If
		
		Chk_CurrInMod = True
		
		rsCurCod.Close()
		'UPGRADE_NOTE: Object rsCurCod may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCurCod = Nothing
		
	End Function
End Module