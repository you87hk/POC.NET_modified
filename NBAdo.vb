Option Strict Off
Option Explicit On
Module NBAdo
	
	Public Function Connect_Database() As Short
		Dim giTimeOut As Object
		
		Connect_Database = True
		
		On Error GoTo Err_Handler
		
		With cnCon
			.Provider = "SQLOLEDB"
			'Modified by Lewis at 09152002
			'.ConnectionTimeout = 10
			'UPGRADE_WARNING: Couldn't resolve default property of object giTimeOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            .ConnectionTimeout = giTimeOut
			'UPGRADE_WARNING: Couldn't resolve default property of object giTimeOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandTimeout = giTimeOut
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			.ConnectionString = gsConnectString
			.Open()
		End With
		
		Exit Function
		
Err_Handler: 
		Connect_Database = False
		MsgBox("Err Connecting Database! " & Err.Description & " " & Err.Number)
		
	End Function
	Public Sub Disconnect_Database()
		
		cnCon.Close()
		
		'UPGRADE_NOTE: Object cnCon may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cnCon = Nothing
		
	End Sub
	
	Public Function ReadRs(ByVal inRs As ADODB.Recordset, ByRef inCol As Object) As Object
		
		'inCol is the column no (0 based) or column name
		
		Dim TmpCol As Object
		
		On Error GoTo ReadRs_Err
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object TmpCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TmpCol = inCol
		
		If inRs Is Nothing Then Exit Function
		
		If inRs.RecordCount <= 0 Then Exit Function
		
		If IsNumeric(TmpCol) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object inCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object TmpCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TmpCol = inCol
			Select Case TmpCol
				Case Is < 0
					'UPGRADE_WARNING: Couldn't resolve default property of object TmpCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TmpCol = 0
			End Select
			
			
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ReadRs = inRs.Fields(TmpCol).Value

        'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(ReadRs) Then
            Select Case inRs.Fields(TmpCol).Type
                Case ADODB.DataTypeEnum.adChar, ADODB.DataTypeEnum.adVarChar, ADODB.DataTypeEnum.adVarWChar, ADODB.DataTypeEnum.adWChar
                    'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ReadRs = ""
                Case ADODB.DataTypeEnum.adCurrency, ADODB.DataTypeEnum.adDecimal, ADODB.DataTypeEnum.adDouble, ADODB.DataTypeEnum.adInteger, ADODB.DataTypeEnum.adNumeric, ADODB.DataTypeEnum.adSingle
                    'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ReadRs = "0"
                Case Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ReadRs = ""
            End Select
        End If

        Exit Function

ReadRs_Err:
        Exit Function

    End Function
	Public Function SetSPPara(ByRef incmd As ADODB.Command, ByVal inPara As Short, ByVal InValue As Object) As Object
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(InValue) Or IsDbNull(InValue) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			InValue = ""
		End If
		
		With incmd.Parameters(inPara)
			Select Case .Type
				Case ADODB.DataTypeEnum.adChar, ADODB.DataTypeEnum.adVarChar, ADODB.DataTypeEnum.adVarWChar, ADODB.DataTypeEnum.adWChar
					If Len(InValue) > .Size Then
						'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						InValue = Left(InValue, .Size)
					End If
				Case ADODB.DataTypeEnum.adCurrency, ADODB.DataTypeEnum.adDecimal, ADODB.DataTypeEnum.adDouble, ADODB.DataTypeEnum.adInteger, ADODB.DataTypeEnum.adNumeric, ADODB.DataTypeEnum.adSingle
					If IsNumeric(InValue) Then
						'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						InValue = To_Value(InValue)
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						InValue = 0
					End If
				Case ADODB.DataTypeEnum.adDate, ADODB.DataTypeEnum.adDBDate, ADODB.DataTypeEnum.adDBTime, ADODB.DataTypeEnum.adDBTimeStamp
					'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If InValue = "" Then
						'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
						'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						InValue = System.DBNull.Value
					End If
			End Select
			
		End With
		
		'UPGRADE_WARNING: Couldn't resolve default property of object InValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		incmd.Parameters(inPara).Value = InValue
		
	End Function
	
	Public Function GetSPPara(ByRef incmd As ADODB.Command, ByVal inPara As Short) As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetSPPara = incmd.Parameters(inPara).Value
		
	End Function
End Module