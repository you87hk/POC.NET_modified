Option Strict Off
Option Explicit On
Module NBFunc
	
	Public Function Check_LoginStatus() As Short
		
		Dim wsLogin As String
		
		Check_LoginStatus = False
		
		On Error GoTo Login_Err
		
		'wsLogin = Trim(gsUsrID) & " " & LoadResString(119)
		wsLogin = "ABC"
		AppActivate(wsLogin)
		
		Check_LoginStatus = True
		
		Exit Function
		
Login_Err: 
		Exit Function
		
	End Function
	
	
	Public Sub chk_InpLen(ByRef Cnl As System.Windows.Forms.Control, ByRef Num As Short, ByRef KeyAscii As Short)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Cnl.SelLength. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Cnl.SelLength > 0 Then
        '    Exit Sub
        'End If
		
		If Len(Cnl.Text) > Num - 1 And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back Then
			KeyAscii = 0
		End If
		
	End Sub
	Public Sub chk_InpLenA(ByRef Cnl As System.Windows.Forms.Control, ByRef Num As Short, ByRef KeyAscii As Short, ByRef isUpper As Boolean)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Cnl.SelLength. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Cnl.SelLength > 0 Then
        '	Exit Sub
        'End If
		
		If Len(Cnl.Text) > Num - 1 And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back Then
			KeyAscii = 0
		End If
		
		
		If KeyAscii < 0 And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back Then
			KeyAscii = 0
		End If
		
		
		'  If (KeyAscii < vbKey0 Or KeyAscii > vbKey9) And _
		''    (KeyAscii < 65 Or KeyAscii > 90) And _
		''     (KeyAscii < 97 Or KeyAscii > 122) And KeyAscii <> vbKeyReturn And KeyAscii <> vbKeyBack And KeyAscii <> vbKeySpace Then
		'          KeyAscii = 0
		'  End If
		
		If isUpper Then
			If KeyAscii >= 97 And KeyAscii <= 122 Then
				KeyAscii = KeyAscii - 32
			End If
		End If
		
		
	End Sub
	
	Public Sub chk_InpLenC(ByRef Cnl As System.Windows.Forms.Control, ByRef Num As Short, ByRef KeyAscii As Short, ByRef isUpper As Boolean, ByRef onlyEng As Boolean)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Cnl.SelLength. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Cnl.SelLength > 0 Then
        '	Exit Sub
        'End If
		
		If Len(Cnl.Text) > Num - 1 And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back Then
			KeyAscii = 0
		End If
		
		
		If isUpper Then
			If KeyAscii >= 97 And KeyAscii <= 122 Then
				KeyAscii = KeyAscii - 32
			End If
		End If
		
		If onlyEng Then
			
			If (KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9) And (KeyAscii < 65 Or KeyAscii > 90) And (KeyAscii < 97 Or KeyAscii > 122) And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back And KeyAscii <> System.Windows.Forms.Keys.Space Then
				KeyAscii = 0
			End If
			
			If KeyAscii < 0 And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back Then
				KeyAscii = 0
			End If
		End If
		
		
		
	End Sub
	
    Public Sub Chk_InpNum(ByRef KeyAscii As Short, ByRef inText As String, ByRef inSign As Short, ByRef inDot As Short)

        Dim iCtr As Integer
        Dim iDotCtr As Integer

        If inSign = True Then
            If KeyAscii = 45 Then
                'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                If TypeName(VB6.GetActiveControl()) = "TDBGrid" Then
                    'UPGRADE_ISSUE: Control EditActive could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    'If VB6.GetActiveControl().EditActive = True Then
                    '    If InStr(inText, "-") <> 0 Then
                    '        KeyAscii = 0
                    '    Else
                    '        If Len(inText) > 0 Then
                    '            KeyAscii = 0
                    '        End If
                    '    End If
                    'End If
                Else
                    'UPGRADE_ISSUE: Control SelLength could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    'If VB6.GetActiveControl().SelLength <> Len(inText) Then
                    '	If Len(inText) > 0 Then
                    '		KeyAscii = 0
                    '	End If
                    'End If
                End If
                Exit Sub
            End If
        End If

        If inDot = True Then
            iDotCtr = 0
            For iCtr = 1 To Len(inText)
                If Mid(inText, iCtr, 1) = "." Then
                    iDotCtr = iDotCtr + 1
                End If
            Next
            If KeyAscii = 46 Then
                iDotCtr = iDotCtr + 1
            End If

            If (KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9) And KeyAscii <> Asc(".") And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back And KeyAscii <> System.Windows.Forms.Keys.Escape Then
                KeyAscii = 0
            End If
            If iDotCtr > 1 Then
                KeyAscii = 0
            End If
        Else
            If (KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9) And KeyAscii <> System.Windows.Forms.Keys.Return And KeyAscii <> System.Windows.Forms.Keys.Back And KeyAscii <> System.Windows.Forms.Keys.Escape Then
                KeyAscii = 0
            End If
        End If

    End Sub
	Public Sub FocusMe(ByRef ctl As System.Windows.Forms.Control, Optional ByRef UnBlock As Object = Nothing)
		
		'Usage: Use to Block a text/mask field when got focus
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(UnBlock) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object UnBlock. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			UnBlock = False
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ctl.SelStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ctl.SelStart = 0
		If Not UnBlock Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ctl.SelLength. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'ctl.SelLength = Len(ctl.Text)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ctl.SelLength. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'ctl.SelLength = 0
		End If
		
	End Sub
	
	Public Sub Get_Company_Info()
		
		Dim rsCompany As New ADODB.Recordset
		Dim Criteria As String
		
		Select Case gsLangID
			Case "1"
				Criteria = "SELECT CmpEngName COMNAM "
			Case "2"
				Criteria = "SELECT CmpChiName COMNAM "
			Case Else
				Criteria = "SELECT CmpEngName COMNAM "
				
		End Select
		Criteria = Criteria & " FROM mstCompany WHERE CmpID = 1 "
		
		rsCompany.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsCompany.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gsComNam = ReadRs(rsCompany, "COMNAM")
		Else
			MsgBox("Can't Access Company Info!")
		End If
		rsCompany.Close()
		'UPGRADE_NOTE: Object rsCompany may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCompany = Nothing
		
	End Sub
	
	Public Sub Get_Login_File()
		
		Dim sBuffer As String
		Dim lSize As Integer
		Dim WindowsPath As String
		Dim LoginFilePath As String
		Dim LineCount As Short
		Dim Mystring As New VB6.FixedLengthString(100)
		
		sBuffer = Space(255)
		lSize = Len(sBuffer)
		Call GetWindowsDirectory(sBuffer, lSize)
		If lSize > 0 Then
			WindowsPath = Left(sBuffer, InStr(sBuffer, Chr(0)) - 1)
		Else
			WindowsPath = vbNullString
		End If
		
		LoginFilePath = WindowsPath & "\Nbase.DAT"
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(LoginFilePath) = "" Or Trim(LoginFilePath) = "" Then
            MsgBox("My.Resources.str115")
			End
		Else
			FileOpen(1, LoginFilePath, OpenMode.Binary, OpenAccess.Read)
			LineCount = 1
			Do While Not EOF(1) And LineCount < 7
				'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FileGet(1, Mystring.Value)
				Select Case LineCount
					Case 1
						'L000813 - remark for compile EXE
						'gsConnectionString = Trim(Encrypt(Mystring))
					Case 2
						'L000813 - remark for compile EXE
						'gsMODULE = Trim(Encrypt(Mystring))
					Case 3
						'L000813 - remark for compile EXE
						'gsExcPath = Trim(Encrypt(Mystring))
					Case 4
						'L000813 - remark for compile EXE
						'gsRptPath = Trim(Encrypt(Mystring))
					Case 5
						'L000813 - remark for compile EXE
						'gsLngTyp = Trim(Encrypt(Mystring))
					Case 6
						'L000813 - remark for compile EXE
						'gsUsrID = Trim(Encrypt(Mystring))
				End Select
				LineCount = LineCount + 1
			Loop 
			FileClose(1)
		End If
		
	End Sub
	Public Sub getHostLogin()
		
		Dim cmdHost As New ADODB.Command
		
		
		cmdHost.ActiveConnection = cnCon
		
		cmdHost.CommandText = "USP_HOSTNAME"
		cmdHost.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		cmdHost.Parameters.Refresh() 'Must set up the activeconnection before refresh
		cmdHost.Execute()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gsHostName = GetSPPara(cmdHost, 1)
        gsHostLogin = Dsp_Date(GetSPPara(cmdHost, 2), True)
        MsgBox(gsHostName)
        MsgBox(gsHostLogin)
		
		'UPGRADE_NOTE: Object cmdHost may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cmdHost = Nothing
		
		
	End Sub
	Public Sub Opt_Setfocus(ByRef inOpt As Object, Optional ByRef inSz As Object = Nothing, Optional ByRef inStart As Object = Nothing)
		Dim wiCtr As Short
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inStart) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object inStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			inStart = 0
		End If
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inSz) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object inSz. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			inSz = 2
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object inSz. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object inStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For wiCtr = inStart To (inStart + inSz - 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object inOpt(wiCtr). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If inOpt(wiCtr) = True Then
				'UPGRADE_WARNING: Couldn't resolve default property of object inOpt().SetFocus. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				inOpt(wiCtr).SetFocus()
				Exit For
			End If
		Next 
		
	End Sub
	
	Public Function Opt_Getfocus(ByRef inOpt As Object, ByVal inSz As Short, Optional ByRef inStart As Object = Nothing) As Short
		Dim wiCtr As Short
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inStart) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object inStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			inStart = 0
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For wiCtr = inStart To (inStart + inSz - 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object inOpt(wiCtr). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If inOpt(wiCtr) = True Then
				Opt_Getfocus = wiCtr
				Exit For
			End If
		Next 
		
	End Function
	Public Function Set_Quote(ByVal inText As String) As String
		Dim strPos As Short
		Dim iCtr As Short
		Dim outText As String
		Dim TmpChar As String
		
		strPos = InStr(inText, "'")
		If strPos <> 0 Then
			outText = Left(inText, strPos - 1)
			For iCtr = strPos To Len(inText)
				TmpChar = Mid(inText, iCtr, 1)
				If TmpChar = "'" Then
					outText = outText & "''"
				Else
					outText = outText & TmpChar
				End If
			Next 
			
		Else
			outText = inText
		End If
		
		Set_Quote = outText
		
	End Function
	
	
	
	Public Function To_Value(ByRef inText As Object) As Double
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(inText) = True Then
			To_Value = 0
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		To_Value = Val(VB6.Format(Trim(inText), "############.########"))
		
	End Function
	
	
	
	Public Function Dsp_MedDate(ByRef inText As String) As String
		
		If Trim(inText) = "" Then
			Dsp_MedDate = "    /  /  "
		Else
			If IsDate(inText) Then
				Dsp_MedDate = VB6.Format(inText, "yyyy/mm/dd")
				Dsp_MedDate = Left(Dsp_MedDate, 4) & "/" & Mid(Dsp_MedDate, 6, 2) & "/" & Right(Dsp_MedDate, 2)
			Else
				Dsp_MedDate = "    /  /  "
			End If
		End If
		
	End Function
	
	
	Public Function Dsp_PeriodDate(ByRef inText As String) As String
		
		If Trim(inText) = "" Then
			Dsp_PeriodDate = "    /  "
		Else
			If IsDate(inText) Then
				Dsp_PeriodDate = VB6.Format(inText, "yyyy/mm")
				Dsp_PeriodDate = Left(Dsp_PeriodDate, 4) & "/" & Right(Dsp_PeriodDate, 2)
			Else
				Dsp_PeriodDate = "    /  "
			End If
		End If
		
	End Function
	
	Public Function Set_MedDate(ByRef inText As String) As String
		
		If Trim(inText) = "/  /" Then
			Set_MedDate = ""
		Else
			Set_MedDate = inText
		End If
		
		If Len(Trim(inText)) = 8 Then
			Set_MedDate = Left(inText, 4) & "/" & Mid(inText, 5, 2) & "/" & Right(inText, 2)
		End If
		
	End Function
	
	Public Function NBRnd(ByVal InValue As Double, Optional ByRef dLen As Short = 0) As String
		
		'Required parameter : NBRnd(Given-Figure, No-of-Decimal-Places)
		
		Dim i As Double
		Dim Sign As Short
		Dim Pos As Short
		Dim TmpVal As Double
		
		Dim TmpDec As Integer
		Dim J As Short
		Dim TmpStr As String
		Dim wsstrfmt As String
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(dLen) Then
			dLen = 2
		End If
		
		InValue = To_Value(InValue)
		
		If InValue >= 0 Then
			Sign = 1
		Else
			Sign = -1
		End If
		
		InValue = System.Math.Abs(InValue)
		Pos = InStr(VB6.Format(InValue), ".")
		
		If Pos = 0 Then
			Pos = Len(VB6.Format(InValue)) + 1
		End If
		If dLen >= 0 Then
			If Val(Mid(VB6.Format(InValue), Pos + dLen + 1, 1)) >= 5 Then
				TmpVal = 10 ^ (-1 * dLen)
				i = CDbl(Mid(VB6.Format(InValue), 1, Pos + dLen)) + TmpVal
			Else
				i = CDbl(Mid(VB6.Format(InValue), 1, Pos + dLen))
			End If
		Else
			TmpVal = 10 ^ (-1 * dLen)
			If Val(Mid(VB6.Format(InValue), Pos + dLen, 1)) >= 5 Then
				i = CDbl(Mid(VB6.Format(InValue), 1, Pos + dLen - 1)) * TmpVal + TmpVal
			Else
				i = CDbl(Mid(VB6.Format(InValue), 1, Pos + dLen - 1)) * TmpVal
			End If
		End If
		
		i = i * Sign
		
		If dLen = 0 Then
			wsstrfmt = "#,##0"
		Else
			wsstrfmt = "#,##0." & New String("0", dLen)
		End If
		
		NBRnd = VB6.Format(i, wsstrfmt)
		
	End Function
	
	Public Sub Read_Debug_Ini(ByVal TmpFilNam As String)
		
		Dim TmpAppNam As String
		Dim TmpRetNam As New VB6.FixedLengthString(100)
		Dim TmpKeyNam As String
		Dim TmpRetSiz As Short
		
		Dim TmpStr As String
		Dim tmplen As Short
		Dim TmpNum As Short
		
		Dim wsLogin As String
		Dim wsPwd As String
		Dim wsServer As String
		Dim wsDatabase As String
		
		
		TmpAppNam = "SYSENV"
		TmpRetNam.Value = "100"
		
		TmpKeyNam = "UID"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		wsLogin = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "PWD"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		wsPwd = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "RPTPATH"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsRptPath = Mid(TmpStr, 1, tmplen - 1)
		
		
		TmpKeyNam = "DBNAME"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsDBName = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "MODULE"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsMODULE = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "EXCPATH"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsExcPath = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "SQLDB"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		wsDatabase = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "SQLSRV"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		wsServer = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "USER"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsUserID = Mid(TmpStr, 1, tmplen - 1)
		
		
		TmpKeyNam = "WSID"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsWorkStationID = Mid(TmpStr, 1, tmplen - 1)
		
		
		TmpKeyNam = "RTACCESS"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsRTAccess = Mid(TmpStr, 1, tmplen - 1)
		
		TmpKeyNam = "RTPATH"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsRTPath = Mid(TmpStr, 1, tmplen - 1)
		
		'' Tom 090210
		
		TmpKeyNam = "HHPATH"
		TmpNum = GetPrivateProfileString(TmpAppNam, TmpKeyNam, "", TmpRetNam.Value, Len(TmpRetNam.Value), TmpFilNam)
		TmpStr = Left(TmpRetNam.Value, InStr(TmpRetNam.Value, Chr(0)))
		tmplen = Len(TmpStr)
		gsHHPath = Mid(TmpStr, 1, tmplen - 1)
		
        gsConnectString = "Data Source=" & wsServer & ";Initial Catalog=" & wsDatabase & ";User ID=" & wsLogin & ";Password=" & wsPwd
		
	End Sub
	
	
	Public Function Dsp_Date(ByVal inDate As Object, Optional ByRef ShowTime As Object = Nothing, Optional ByRef NoSlash As Object = Nothing) As String
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(ShowTime) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ShowTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ShowTime = False
		End If
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(NoSlash) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object NoSlash. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			NoSlash = False
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(inDate) Or Trim(inDate) = "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object NoSlash. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If NoSlash = True Then
				Dsp_Date = ""
			Else
				Select Case gsDteFmt
					Case "DMY", "MDY"
						Dsp_Date = "  /  /    "
					Case Else
						Dsp_Date = "    /  /  "
				End Select
			End If
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ShowTime. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ShowTime = False Then
			Select Case gsDteFmt
				Case "MDY"
					'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dsp_Date = VB6.Format(inDate, "mm/dd/yyyy")
				Case "YMD"
					'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dsp_Date = VB6.Format(inDate, "yyyy/mm/dd")
				Case Else
					'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dsp_Date = VB6.Format(inDate, "dd/mm/yyyy")
			End Select
		Else
			Select Case gsDteFmt
				Case "MDY"
					'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dsp_Date = VB6.Format(inDate, "mm/dd/yyyy HH:MM:SS")
				Case "YMD"
					'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dsp_Date = VB6.Format(inDate, "yyyy/mm/dd HH:MM:SS")
				Case Else
					'UPGRADE_WARNING: Couldn't resolve default property of object inDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Dsp_Date = VB6.Format(inDate, "dd/mm/yyyy HH:MM:SS")
			End Select
		End If
		
	End Function
	
	Public Sub Get_Date_Fmt()
		Dim LOCALE_IDATE As Object
		
		Dim Symbol As String
		Dim iRet1 As Integer
		Dim iRet2 As Integer
		Dim lpLCDataVar As String
		Dim Pos As Short
		Dim Locale As Integer
		
		Locale = GetUserDefaultLCID()
		'UPGRADE_WARNING: Couldn't resolve default property of object LOCALE_IDATE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iRet1 = GetLocaleInfo(Locale, LOCALE_IDATE, lpLCDataVar, 0)
		Symbol = New String(Chr(0), iRet1)
		'UPGRADE_WARNING: Couldn't resolve default property of object LOCALE_IDATE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iRet2 = GetLocaleInfo(Locale, LOCALE_IDATE, Symbol, iRet1)
		Pos = InStr(Symbol, Chr(0))
		
		If Pos > 0 Then
			Symbol = Left(Symbol, Pos - 1)
		End If
		
		Select Case Symbol
			Case CStr(0)
				gsDteFmt = "MDY"
			Case CStr(1)
				gsDteFmt = "DMY"
			Case CStr(2)
				gsDteFmt = "YMD"
		End Select
		
	End Sub
	
	
	Public Function Chk_AutoGen(ByVal inDocTyp As String) As String
		
		Dim rst As New ADODB.Recordset
		Dim Criteria As String
		
		Chk_AutoGen = "N"
		
		Criteria = "SELECT DocLastKey FROM sysDocNo "
		Criteria = Criteria & " WHERE DocType = '" & Set_Quote(inDocTyp) & "'"
        rst.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rst.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Chk_AutoGen = ReadRs(rst, "DocLastKey")
		End If
		
		rst.Close()
		'UPGRADE_NOTE: Object rst may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rst = Nothing
		
	End Function
	
	Public Function Get_CheckValue(ByRef Cnl As System.Windows.Forms.Control) As String
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Cnl.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Cnl.Value = 0 Then
        '    Get_CheckValue = "N"
        'Else
        '    Get_CheckValue = "Y"
        'End If
		
	End Function
	
	Public Sub Set_CheckValue(ByRef Cnl As System.Windows.Forms.Control, ByRef InValue As String)
		
		
        If InValue = "Y" Or InValue = "y" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Cnl.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Cnl.Value = 1
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Cnl.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Cnl.Value = 0
        End If
		
	End Sub
	
	
	Public Function Change_SQLDate(ByVal inDate As String) As String
		
		' Parameters :
		' inDate          - The Date in win system date format
		'                   (e.g. 09/01/1997 or 09/01/1999 12:31:14)
		' Chg_SQL_Date    - in SQL Server date format
		
		' Description: Convert date from win system date format to
		'              SQL Server date format
		
		On Error GoTo Change_SQLDate_Err
		
		Change_SQLDate = ""
		
		'CHECK VALID DATE
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		If IsDbNull(inDate) Or Trim(inDate) = "" Then
			'Call Dsp_Err("E0048")
			Exit Function
		End If
		
		Select Case Left(inDate, 10)
			' For Report Date Range
			Case "00/00/0000", "0000/00/00"
				Change_SQLDate = "1950/01/01 00:00:00"
				
				' For Report Date Range
			Case "99/99/9999", "9999/99/99"
				Change_SQLDate = "3000/12/31 00:00:00"
				
			Case Else
				Change_SQLDate = VB6.Format(inDate, "YYYY/MM/DD HH:MM:SS")
				
		End Select
		
		Exit Function
		
Change_SQLDate_Err: 
		MsgBox(Err.Description)
		
	End Function
	
	Public Sub SetDateMask(ByRef inMed As System.Windows.Forms.MaskedTextBox)
		
		inMed.PromptChar = " "
		
		Select Case gsDteFmt
			Case "YMD"
				'UPGRADE_ISSUE: MSMask.MaskEdBox property inMed.Format was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'inMed.Format = ""
				inMed.mask = "####/##/##"
				inMed.Text = New String(" ", 4) & "/" & New String(" ", 2) & "/" & New String(" ", 2)
			Case Else
				'UPGRADE_ISSUE: MSMask.MaskEdBox property inMed.Format was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'inMed.Format = ""
				inMed.mask = "##/##/####"
				inMed.Text = New String(" ", 2) & "/" & New String(" ", 2) & "/" & New String(" ", 4)
		End Select
		
	End Sub
	
	Public Sub SetPasswordChar(ByRef inTextBox As System.Windows.Forms.TextBox, ByRef inPasswordChar As String)
		If Len(Trim(inPasswordChar)) <> 1 Then
			inTextBox.PasswordChar = CChar("*")
		Else
			inTextBox.PasswordChar = CChar(Trim(inPasswordChar))
		End If
		inTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
	End Sub
	
	Public Sub Ini_Combo(ByRef inNoOfCol As Short, ByRef inCriteria As String, ByRef Xpos As Integer, ByRef Ypos As Integer, ByRef inGrid As AxTrueDBGrid60.AxTDBGrid, ByRef InPgmID As String, ByRef inKey As String, ByRef FrmWidth As Integer, ByRef FrmHeight As Integer)
		
		'inNoOfCol = No. of Columns in the drop down grid
		'inCriteria = Searching Criteria for filling the results to the grid
		'XPos = The left position for displaying the grid
		'YPos = The top position for displaying the grid
		'inGrid = The Grid object needed to be initialized
		'inPgmID = The Program ID for search the description in the SPC table
		'inKey = The key code for search the description in the SPC table
		
		Dim rsCommon As New ADODB.Recordset
		Dim rsSPC As New ADODB.Recordset
		Dim Criteria As String
		Dim myColumn As TrueDBGrid60.Column
		Dim waCommon As New XArrayDBObject.XArrayDB
		Dim wiCol As Short
		Dim wiCtr As Short
		Dim wlRecCtr As Integer
		Dim wlWidth As Integer
		Dim colC As TrueDBGrid60.Column
		
		System.Windows.Forms.Application.DoEvents() 'DoEvents is to let the got_focus trigger first
		inGrid.ClearFields()
		
		With inGrid
			.Height = VB6.TwipsToPixelsY(2000)
			.Width = VB6.TwipsToPixelsX(3500)
			.EmptyRows = True
			.AllowColMove = False
			.AllowColSelect = False
			.AllowUpdate = False
			.MarqueeStyle = 3
			
			.RecordSelectors = False
			
			For wiCtr = 0 To .Columns.Count - 1
				.Columns.Remove(0)
			Next 
			
			For wiCtr = 0 To inNoOfCol - 1
				colC = .Columns.Add(wiCtr)
				.Columns(wiCtr).Visible = True
			Next 
			
			For wiCtr = 0 To inNoOfCol - 1
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				'.Columns(wiCtr).Locked = True
			Next 
			
			'Initialize the caption in the drop down grid
			Criteria = "SELECT SCRFLDID, SCRFLDNAME "
			Criteria = Criteria & " FROM SYSSCRCAPTION WHERE SCRTYPE = 'SCR' "
			Criteria = Criteria & " AND SCRPGMID = '" & InPgmID & "' "
			Criteria = Criteria & " AND SCRLANGID = '" & gsLangID & "' "
			Criteria = Criteria & " AND SCRFLDID LIKE '" & inKey & "%' "
			Criteria = Criteria & " ORDER BY SCRSEQNO "
			
			
			rsSPC.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			
			wiCol = 0
			
			If rsSPC.RecordCount > 0 Then
				rsSPC.MoveFirst()
				wlWidth = 0
				Do While Not rsSPC.EOF
					If wiCol < inNoOfCol Then
						.Columns(wiCol).Width = (Len(ReadRs(rsSPC, "SCRFLDNAME")) * 120)
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.Columns(wiCol).Caption = ReadRs(rsSPC, "SCRFLDNAME")
						wlWidth = wlWidth + .Columns(wiCol).Width
					End If
					wiCol = wiCol + 1
					rsSPC.MoveNext()
				Loop 
				.Width = VB6.TwipsToPixelsX(wlWidth)
			End If
			
			rsSPC.Close()
			'UPGRADE_NOTE: Object rsSPC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsSPC = Nothing
			
			rsCommon.Open(inCriteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
			waCommon.ReDim(0, -1, 0, inNoOfCol - 1)
			
			If rsCommon.RecordCount > 0 Then
				wlRecCtr = 0
				rsCommon.MoveFirst()
				Do While Not rsCommon.EOF
					waCommon.AppendRows()
					wlRecCtr = wlRecCtr + 1
					'If wlRecCtr = 1 Then inGrid.Bookmark = inGrid.Row
					For wiCtr = 0 To inNoOfCol - 1
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						waCommon.get_Value(waCommon.get_UpperBound(1), wiCtr) = ReadRs(rsCommon, wiCtr)
					Next 
					rsCommon.MoveNext()
				Loop 
				.Bookmark = 0
				
				'Resize the combo
				rsCommon.MoveFirst()
				wlWidth = 0
				For wiCtr = 0 To inNoOfCol - 1
					If .Columns(wiCtr).Width < (rsCommon.Fields(wiCtr).DefinedSize * 120) Then
						.Columns(wiCtr).Width = (rsCommon.Fields(wiCtr).DefinedSize * 120)
					End If
					wlWidth = wlWidth + .Columns(wiCtr).Width
					Select Case rsCommon.Fields(wiCtr).Type
						Case ADODB.DataTypeEnum.adBinary, ADODB.DataTypeEnum.adCurrency, ADODB.DataTypeEnum.adDecimal, ADODB.DataTypeEnum.adDouble, ADODB.DataTypeEnum.adInteger, ADODB.DataTypeEnum.adNumeric, ADODB.DataTypeEnum.adSingle, ADODB.DataTypeEnum.adSmallInt, ADODB.DataTypeEnum.adTinyInt
							.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
							.Columns(wiCtr).NumberFormat = "#,##0.00########"
						Case Else
							.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
					End Select
				Next wiCtr
				
				If rsCommon.RecordCount > 7 Then
					.Width = VB6.TwipsToPixelsX(wlWidth + 220)
				Else
					.Width = VB6.TwipsToPixelsX(wlWidth)
				End If
				
				If VB6.PixelsToTwipsX(.Width) > FrmWidth - 300 Then
					.Width = VB6.TwipsToPixelsX(FrmWidth - 300)
				End If
				
			End If
			inGrid.Array = waCommon
			.ReBind()
			
			rsCommon.Close()
			'UPGRADE_NOTE: Object rsCommon may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsCommon = Nothing
			
			If Xpos + VB6.PixelsToTwipsX(.Width) > FrmWidth Then
				Xpos = FrmWidth - VB6.PixelsToTwipsX(.Width) - 100
			End If
			
			.Left = VB6.TwipsToPixelsX(Xpos)
			
			If Ypos + VB6.PixelsToTwipsY(.Height) > FrmHeight Then
				'Amended by Lewis at 01082001
				'Ypos = FrmHeight - .Height - 100
				Ypos = Ypos - VB6.PixelsToTwipsY(.Height) - 300
			End If
			
			.Top = VB6.TwipsToPixelsY(Ypos)
			
			'UPGRADE_NOTE: Object waCommon may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			waCommon = Nothing
		End With

    End Sub
	
	Public Function getExcRate(ByRef inCurrCd As String, ByRef inDocDte As String, ByRef outRate As String, ByRef OutDesc As String) As Boolean
		
		Dim rsEXCRATE As New ADODB.Recordset
		Dim Criteria As String
		Dim tmpRate As Double
		Dim tmpDte As String
		Dim CtlYr As String
		Dim CtlMon As String
		
		If Not IsDate(inDocDte) Then
			inDocDte = Dsp_Date(gsDateFrom)
		End If
		tmpDte = CStr(CDate(inDocDte))
		CtlYr = VB6.Format(tmpDte, "yyyy")
		CtlMon = VB6.Format(tmpDte, "mm")
		
		Criteria = ""
		
		Criteria = Criteria & "SELECT EXCRATE, EXCBRATE, EXCDESC FROM mstEXCHANGERATE "
		Criteria = Criteria & "WHERE EXCCURR = '" & Set_Quote(inCurrCd) & "' "
		Criteria = Criteria & "AND EXCYR = '" & Set_Quote(CtlYr) & "' "
		Criteria = Criteria & "AND EXCMN = '" & To_Value(CtlMon) & "' "
		
		rsEXCRATE.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsEXCRATE.RecordCount > 0 Then
			tmpRate = System.Math.Round(To_Value(ReadRs(rsEXCRATE, "EXCRATE")), giExrDp)
			outRate = CStr(tmpRate)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutDesc = ReadRs(rsEXCRATE, "EXCDESC")
			getExcRate = True
		Else
			outRate = CStr(0)
			OutDesc = ""
			getExcRate = False
		End If
		
		rsEXCRATE.Close()
		'UPGRADE_NOTE: Object rsEXCRATE may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsEXCRATE = Nothing
		
	End Function
	
	Public Function getExcPRate(ByRef inCurrCd As String, ByRef inDocDte As String, ByRef outRate As String, ByRef OutDesc As String) As Boolean
		
		Dim rsEXCRATE As New ADODB.Recordset
		Dim Criteria As String
		Dim tmpRate As Double
		Dim tmpDte As String
		Dim CtlYr As String
		Dim CtlMon As String
		
		If Not IsDate(inDocDte) Then
			inDocDte = Dsp_Date(gsDateFrom)
		End If
		tmpDte = CStr(CDate(inDocDte))
		CtlYr = VB6.Format(tmpDte, "yyyy")
		CtlMon = VB6.Format(tmpDte, "mm")
		
		Criteria = ""
		
		Criteria = Criteria & "SELECT EXCRATE, EXCBRATE, EXCDESC FROM mstEXCHANGERATE "
		Criteria = Criteria & "WHERE EXCCURR = '" & Set_Quote(inCurrCd) & "' "
		Criteria = Criteria & "AND EXCYR = '" & Set_Quote(CtlYr) & "' "
		Criteria = Criteria & "AND EXCMN = '" & To_Value(CtlMon) & "' "
		
		rsEXCRATE.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsEXCRATE.RecordCount > 0 Then
			tmpRate = System.Math.Round(To_Value(ReadRs(rsEXCRATE, "EXCBRATE")), giExrDp)
			outRate = CStr(tmpRate)
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			OutDesc = ReadRs(rsEXCRATE, "EXCDESC")
			getExcPRate = True
		Else
			outRate = CStr(0)
			OutDesc = ""
			getExcPRate = False
		End If
		
		rsEXCRATE.Close()
		'UPGRADE_NOTE: Object rsEXCRATE may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsEXCRATE = Nothing
		
	End Function
	
	
	Public Function Chk_Date(ByRef inDteCtl As System.Windows.Forms.Control, Optional ByRef inCol As Object = Nothing) As Short
		
		'inDteCtl : The control which needed to check
		'inCol    : If the control is a Grid, inCol is to indicate the column no.
		
		Dim inDate As String
		Dim wsDay As String
		Dim wsMth As String
		Dim wsYear As String
		Dim FirstSlash As Short
		Dim SecondSlash As Short
		
		Chk_Date = False
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inCol) Then
			inDate = inDteCtl.Text
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object inDteCtl.Columns. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'inDate = inDteCtl.Columns(inCol).Text
		End If
		
		If Len(Trim(inDate)) = 8 Then
			inDate = Left(inDate, 4) & "/" & Mid(inDate, 5, 2) & "/" & Right(inDate, 2)
		End If
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If Not IsNothing(inCol) Then
			' Check the slash exists
			If Not inDate Like "*/*/*" Then
				If inDate Like "*/*" Then
					FirstSlash = InStr(1, inDate, "/")
					'if lenght is 7, assume 2 character is for year
					Select Case Len(inDate)
						Case 7
							Select Case FirstSlash
								Case 3
									inDate = Left(inDate, 5) & "/" & Right(inDate, 2)
								Case 5
									inDate = Left(inDate, 2) & "/" & Right(inDate, 5)
								Case Else
									'wrong position of the slash
									Exit Function
							End Select
						Case 9
							Select Case gsDteFmt
								Case "YMD"
									Select Case FirstSlash
										Case 5
											inDate = Left(inDate, 7) & "/" & Right(inDate, 2)
										Case 7
											inDate = Left(inDate, 4) & "/" & Right(inDate, 5)
										Case Else
											'wrong position of the slash
											Exit Function
									End Select
								Case "MDY", "DMY"
									Select Case FirstSlash
										Case 3
											inDate = Left(inDate, 5) & "/" & Right(inDate, 4)
										Case 5
											inDate = Left(inDate, 2) & "/" & Right(inDate, 7)
										Case Else
											'wrong position of the slash
											Exit Function
									End Select
							End Select
						Case Else
							'wrong length of the date
							Exit Function
					End Select
				Else
					'no slash in the date
					'if lenght is 6, assume 2 character is for year
					Select Case Len(inDate)
						Case 6
							inDate = Left(inDate, 2) & "/" & Mid(inDate, 3, 2) & "/" & Right(inDate, 2)
						Case 9
							Select Case gsDteFmt
								Case "YMD"
									inDate = Left(inDate, 4) & "/" & Mid(inDate, 5, 2) & "/" & Right(inDate, 2)
								Case "MDY", "DMY"
									inDate = Left(inDate, 2) & "/" & Mid(inDate, 3, 2) & "/" & Right(inDate, 4)
							End Select
						Case Else
							'wrong length of the date
							Exit Function
					End Select
				End If
			End If
		End If
		
		If Trim(inDate) = "/  /" Or Trim(inDate) = "" Then Exit Function
		
		FirstSlash = InStr(1, inDate, "/")
		SecondSlash = InStr(FirstSlash + 1, inDate, "/")
		
		Select Case gsDteFmt
			Case "DMY"
				wsDay = Trim(Mid(inDate, 1, FirstSlash - 1))
				wsMth = Trim(Mid(inDate, FirstSlash + 1, 2))
				wsYear = Trim(Mid(inDate, SecondSlash + 1))
			Case "MDY"
				wsMth = Trim(Mid(inDate, 1, FirstSlash - 1))
				wsDay = Trim(Mid(inDate, FirstSlash + 1, 2))
				wsYear = Trim(Mid(inDate, SecondSlash + 1))
			Case "YMD"
				wsYear = Trim(Mid(inDate, 1, FirstSlash - 1))
				wsMth = Trim(Mid(inDate, FirstSlash + 1, 2))
				wsDay = Trim(Mid(inDate, SecondSlash + 1))
		End Select
		
		If Val(wsDay) < 1 Or Val(wsDay) > 31 Or Val(wsMth) < 1 Or Val(wsMth) > 12 Or Len(wsYear) = 1 Or Len(wsYear) = 3 Then
			Exit Function
		Else
			If Val(wsMth) <> 12 Then
				If Val(wsDay) > Val(CStr(System.Date.FromOADate(DateSerial(Val(wsYear), Val(wsMth) + 1, 1).ToOADate - DateSerial(Val(wsYear), Val(wsMth), 1).ToOADate))) Then
					Exit Function
				End If
			End If
		End If
		
		If Len(wsYear) = 2 Then
			If Val(wsYear) >= 50 Then
				wsYear = "19" & wsYear
			Else
				wsYear = "20" & wsYear
			End If
		End If
		
		wsDay = New String("0", 2 - Len(wsDay)) & wsDay
		wsMth = New String("0", 2 - Len(wsMth)) & wsMth
		
		If Trim(wsDay) = "" Or Trim(wsMth) = "" Or Trim(wsYear) = "" Then Exit Function
		
		Select Case gsDteFmt
			Case "DMY"
				inDate = wsDay & "/" & wsMth & "/" & wsYear
			Case "MDY"
				inDate = wsMth & "/" & wsDay & "/" & wsYear
			Case "YMD"
				inDate = wsYear & "/" & wsMth & "/" & wsDay
		End Select
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(inCol) Then
			inDteCtl.Text = inDate
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object inDteCtl.Columns. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'inDteCtl.Columns(inCol).Text = inDate
		End If
		
		Chk_Date = True
		
	End Function
	
	Public Function Get_CompanyFlag(ByVal inCompInfo As String) As String
		' Usage : will get the specified info from the Company Profile
		' inCompInfo  - Column name
		' outCompInfo - Column value in the table
		
		Dim rsCOMFIX As New ADODB.Recordset
		Dim Criteria As String
		
		Get_CompanyFlag = ""
		
		If Trim(inCompInfo) = "" Then Exit Function
		
		Criteria = "SELECT " & Set_Quote(inCompInfo) & " COMPINFO "
		Criteria = Criteria & " FROM mstCompany WHERE CMPID = " & gsCompID
		rsCOMFIX.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsCOMFIX.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Get_CompanyFlag = ReadRs(rsCOMFIX, "COMPINFO")
		Else
			'MsgBox "Can't Get Company Info"
			MsgBox("找不到公司資料")
		End If
		
		rsCOMFIX.Close()
		'UPGRADE_NOTE: Object rsCOMFIX may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCOMFIX = Nothing
		
	End Function
    Public Sub Get_Scr_Item(ByVal InPgmID As String, ByRef inArray As System.Data.DataTable)

        Dim Criteria As String
        Dim rsCaption As New ADODB.Recordset
        Dim adapter As New System.Data.OleDb.OleDbDataAdapter

        Criteria = "SELECT SCRFLDID, SCRFLDNAME "
        Criteria = Criteria & " FROM SYSSCRCAPTION WHERE SCRTYPE = 'SCR' "
        Criteria = Criteria & " AND SCRPGMID = '" & InPgmID & "' "
        Criteria = Criteria & " AND SCRLANGID = '" & gsLangID & "' "

        rsCaption.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        adapter.Fill(inArray, rsCaption)
        'inArray.ReDim(0, -1, 0, 1)

        'If rsCaption.RecordCount > 0 Then
        '    rsCaption.MoveFirst()

        '    inArray.AppendRows()
        '    inArray.get_Value(inArray.get_UpperBound(1), 0) = InPgmID & " "
        '    inArray.get_Value(inArray.get_UpperBound(1), 1) = "ID"

        '    Do While Not rsCaption.EOF
        '        inArray.AppendRows()
        '        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        inArray.get_Value(inArray.get_UpperBound(1), 0) = ReadRs(rsCaption, "SCRFLDNAME")
        '        'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        inArray.get_Value(inArray.get_UpperBound(1), 1) = ReadRs(rsCaption, "SCRFLDID")
        '        rsCaption.MoveNext()
        '    Loop
        'End If

        rsCaption.Close()

        'UPGRADE_NOTE: Object rsCaption may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsCaption = Nothing

    End Sub
    Public Function Get_Caption(ByVal inArray As System.Data.DataTable, ByVal inCode As String) As String

        Dim wlFound As Integer

        On Error GoTo Err_Handler

        Get_Caption = ""

        Dim dr As DataRow
        For Each dr In inArray.Rows
            If dr.Item(0) = inCode Then
                Get_Caption = dr.Item(1)
                Exit For
            End If
        Next
        Return (Get_Caption)

        'If inCode = "SCRHDR" Then
        '    wlFound = inArray.Find(0, 1, "ID")
        '    If wlFound < inArray.get_LowerBound(1) Then
        '        Get_Caption = ""
        '    Else
        '        Get_Caption = inArray.get_Value(wlFound, 0)
        '    End If
        'End If

        'wlFound = inArray.Find(0, 1, inCode)


        'If wlFound < inArray.get_LowerBound(1) Then
        '    Exit Function
        'Else
        '    Get_Caption = Get_Caption & inArray.get_Value(wlFound, 0)
        'End If

Err_Handler:
        Exit Function

    End Function
	
	Public Function Chk_Period(ByRef inControl As System.Windows.Forms.Control) As Boolean
		
		Dim wiMth As Short
		Dim wiYear As Short
		
		Chk_Period = False
		
		If InStr(inControl.Text, "/") = 0 Then
			MsgBox("Missing / !")
			Exit Function
		End If
		
		wiYear = To_Value(Left(inControl.Text, InStr(inControl.Text, "/") - 1))
		wiMth = To_Value(Mid(inControl.Text, InStr(inControl.Text, "/") + 1))
		
		'check month
		If wiMth < 1 Or wiMth > 12 Then
			MsgBox("Month out of Range!")
			Exit Function
		End If
		
		'check year
		If wiYear < 100 And wiYear > 80 Then
			wiYear = wiYear + 1999
		Else
			If wiYear < 80 Then
				wiYear = wiYear + 2000
			End If
		End If
		
		If wiYear < DatePart(Microsoft.VisualBasic.DateInterval.Year, CDate(gsDateFrom)) Then
			MsgBox("Year out of control year!")
			Exit Function
		End If
		
		If wiYear > DatePart(Microsoft.VisualBasic.DateInterval.Year, CDate(gsDateTo)) Then
			MsgBox("Year out of control year!")
			Exit Function
		End If
		
		'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If TypeName(inControl) = "MaskEdBox" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object inControl.mask. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If inControl.mask = "##/####" Then
            '	inControl.Text = VB6.Format(wiMth, "00") & "/" & VB6.Format(wiYear, "0000")
            '	'UPGRADE_WARNING: Couldn't resolve default property of object inControl.mask. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'ElseIf inControl.mask = "####/##" Then 
            '	inControl.Text = VB6.Format(wiYear, "0000") & "/" & VB6.Format(wiMth, "00")
            'End If
		End If
		
		Chk_Period = True
		
	End Function
	Public Sub SetPeriodMask(ByRef inMed As System.Windows.Forms.MaskedTextBox)
		
		inMed.PromptChar = " "
		
		Select Case gsDteFmt
			Case "YMD"
				'UPGRADE_ISSUE: MSMask.MaskEdBox property inMed.Format was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'inMed.Format = ""
				inMed.mask = "####/##"
				inMed.Text = New String(" ", 4) & "/" & New String(" ", 2)
			Case Else
				'UPGRADE_ISSUE: MSMask.MaskEdBox property inMed.Format was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'inMed.Format = ""
				inMed.mask = "##/####"
				inMed.Text = New String(" ", 2) & "/" & New String(" ", 4)
		End Select
		
	End Sub
	
	
	
	Public Sub IniDateRange(ByRef inDateFrom As System.Windows.Forms.MaskedTextBox, ByRef inDateTo As System.Windows.Forms.MaskedTextBox)
		
		SetDateMask(inDateFrom)
		SetDateMask(inDateTo)
		inDateFrom.Text = gsDateFrom
		inDateTo.Text = gsDateTo
		
	End Sub
	
	Public Sub Get_Company_Default()
		
		Dim rsSysDef As New ADODB.Recordset
		Dim Criteria As String
		
		Criteria = "SELECT SYPMINDTE, SYPMAXDTE "
		Criteria = Criteria & " FROM SYSCONST WHERE SYPRECID = '01' "
		
		rsSysDef.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsSysDef.RecordCount > 0 Then
			gsDateFrom = Dsp_Date(ReadRs(rsSysDef, "SYPMINDTE"))
			gsDateTo = Dsp_Date(ReadRs(rsSysDef, "SYPMAXDTE"))
		Else
			MsgBox("Missing System Profile!")
		End If
		rsSysDef.Close()
		'UPGRADE_NOTE: Object rsSysDef may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsSysDef = Nothing
		
	End Sub
	Public Function Get_SystemFlag(ByVal inColumnName As String) As String
		'Usage       : Read the Control Flag of the System Profile Table and returns the value
		'Parameters  : Column Name
		'Return Value: Column Value in the Database
		
		Dim rsSYSCONST As New ADODB.Recordset
		Dim Criteria As String
		
		Get_SystemFlag = ""
		
		Criteria = "SELECT " & Set_Quote(inColumnName)
		Criteria = Criteria & " FROM SYSCONST "
		rsSYSCONST.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsSYSCONST.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Get_SystemFlag = ReadRs(rsSYSCONST, inColumnName)
		End If
		
		rsSYSCONST.Close()
		'UPGRADE_NOTE: Object rsSYSCONST may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsSYSCONST = Nothing
		
	End Function
	
	
	Public Function ReadOnlyMode(ByVal inTStamp As String, ByVal inKeyTyp As String, ByVal inKey As String, ByVal inPrgID As String) As Short
		
		Dim Criteria As String
		Dim rsSysLock As New ADODB.Recordset
		
		ReadOnlyMode = True
		
		On Error GoTo ReadOnlyMode_Err
		
		Criteria = "Select LocUsrID FROM sysLock "
		Criteria = Criteria & " WHERE LocHost = '" & Set_Quote(gsHostName) & "' "
		Criteria = Criteria & " AND LocKeyTyp = '" & Set_Quote(inKeyTyp) & "' "
		Criteria = Criteria & " AND LocKey = '" & Set_Quote(inKey) & "' "
		Criteria = Criteria & " AND LocUsrID = '" & Set_Quote(gsUserID) & "' "
		Criteria = Criteria & " AND LocPgmID = '" & inPrgID & "' "
		Criteria = Criteria & " AND LocLupDte = '" & Change_SQLDate(inTStamp) & "' "
		rsSysLock.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsSysLock.RecordCount > 0 Then
			ReadOnlyMode = False
		End If
		rsSysLock.Close()
		'UPGRADE_NOTE: Object rsSysLock may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsSysLock = Nothing
		
		Exit Function
		
ReadOnlyMode_Err: 
		MsgBox("ReadOnlyMode Error!")
		'UPGRADE_NOTE: Object rsSysLock may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsSysLock = Nothing
		
	End Function
	
	Public Function RowLock(ByVal inTStamp As String, ByVal inKeyTyp As String, ByVal inKey As String, ByVal inPrgID As String, ByRef outUsrID As String) As Short
		Dim gsUsrID As Object
		
		' inTStamp    - THE DATETIME STRING OF USER LOAD THE PROGRAM. E.G. 01/09/1998 12:53:00
		' inKeyTyp  - THE KEY NAME FOR LOCKING. E.G. CUSNO, DOCNO, INVNO
		' inKey     - THE KEY VALUE FOR LOCKING. E.G. 091230, DOC-00000148
		' inPrgID    - THE PROGRAM ID WHICH LOCK THE TABLE. E.G. MM06, S010
		' outUsrID  - THE USER ID WHICH LOCKED THE RECORD. E.G. TRESTEP
		
		Dim rsSysLock As New ADODB.Recordset
		Dim rsCmd As New ADODB.Command
		
		Dim Criteria As String
		
		RowLock = False
		outUsrID = ""
		
		On Error GoTo RowLock_Err
		
		'CHECK WHETHER THE RECORD IS LOCKED BY OTHER USER
		Criteria = " SELECT LocUsrID, LocLupDte "
		Criteria = Criteria & " FROM sysLock, MASTER.DBO.SYSPROCESSES "
		Criteria = Criteria & " WHERE LocKEYTYP = '" & Set_Quote(inKeyTyp) & "' "
		Criteria = Criteria & " AND LocKEY = '" & Set_Quote(inKey) & "' "
		Criteria = Criteria & " AND CONVERT(VARCHAR, LocLOGIN, 120) = CONVERT(VARCHAR, LOGIN_TIME, 120) "
		Criteria = Criteria & " AND LocHOST = HOSTNAME "
		
		rsSysLock.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		
		If rsSysLock.RecordCount > 0 Then
			'IF THE USRID AND TSTAMP IS SAME AS PARAMETER PASSED, LOCK RECORD IS SUCCESS
			'UPGRADE_WARNING: Couldn't resolve default property of object gsUsrID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Trim(ReadRs(rsSysLock, "LocUSRID")) = Trim(gsUsrID) And Dsp_Date(ReadRs(rsSysLock, "LocLupDte"), True) = inTStamp Then
				RowLock = True
			Else
				'OTHER USER LOCKS THE RECORD
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				outUsrID = ReadRs(rsSysLock, "LocUsrID")
			End If
			
			rsSysLock.Close()
			'UPGRADE_NOTE: Object rsSysLock may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsSysLock = Nothing
			
			Exit Function
		End If
		
		rsSysLock.Close()
		'UPGRADE_NOTE: Object rsSysLock may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsSysLock = Nothing
		
		
		rsCmd.let_ActiveConnection(cnCon)
		rsCmd.CommandType = ADODB.CommandTypeEnum.adCmdText
		
		'IF NO ONE LOCKS THE FILE OR THE USER ARE ALREADY GONE, THEN LOCK THE RECORD
		Criteria = " INSERT INTO sysLock (LocHOST, LocUSRID, LocLOGIN, "
		Criteria = Criteria & " LocPGMID, LocKEYTYP, LocKEY, LocLupDte)"
		Criteria = Criteria & " VALUES ( '" & Set_Quote(gsHostName) & "', "
		Criteria = Criteria & "'" & Set_Quote(gsUserID) & "', "
		Criteria = Criteria & "'" & Change_SQLDate(gsHostLogin) & "', "
		Criteria = Criteria & "'" & inPrgID & "', "
		Criteria = Criteria & "'" & inKeyTyp & "', "
		Criteria = Criteria & "'" & Set_Quote(inKey) & "', "
		Criteria = Criteria & "'" & Change_SQLDate(inTStamp) & "') "
		
		rsCmd.CommandText = Criteria
		rsCmd.Execute()
		
		'UPGRADE_NOTE: Object rsCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCmd = Nothing
		
		RowLock = True
		
		Exit Function
		
RowLock_Err: 
		MsgBox("RowLock Error!")
		'UPGRADE_NOTE: Object rsCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCmd = Nothing
		
	End Function
	
	
	Public Function RowUnLock(ByVal inTStamp As String, ByVal inKeyTyp As String, ByVal inKey As String, ByVal inPrgID As String) As Short
		
		Dim Criteria As String
		Dim rsCmd As New ADODB.Command
		
		RowUnLock = False
		On Error GoTo RowUnLock_Err
		
		Criteria = " DELETE FROM sysLock "
		Criteria = Criteria & " WHERE LocHOST = '" & Set_Quote(gsHostName) & "' "
		Criteria = Criteria & " AND LocUSRID = '" & Set_Quote(gsUserID) & "' "
		Criteria = Criteria & " AND LocLOGIN = '" & Change_SQLDate(gsHostLogin) & "' "
		Criteria = Criteria & " AND LocPGMID = '" & inPrgID & "' "
		Criteria = Criteria & " AND LocKEYTYP = '" & inKeyTyp & "' "
		Criteria = Criteria & " AND LocKEY = '" & inKey & "' "
		Criteria = Criteria & " AND LocLupdte = '" & Change_SQLDate(inTStamp) & "' "
		With rsCmd
			.let_ActiveConnection(cnCon)
			.CommandType = ADODB.CommandTypeEnum.adCmdText
			.CommandText = Criteria
			.Execute()
		End With
		
		RowUnLock = True
		'UPGRADE_NOTE: Object rsCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCmd = Nothing
		Exit Function
		
RowUnLock_Err: 
		MsgBox("RowLock Err!")
		'UPGRADE_NOTE: Object rsCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCmd = Nothing
		
	End Function
	
	Public Function UnLockAll(ByVal inTStamp As String, ByVal inPrgID As String) As Short
		
		Dim Criteria As String
		Dim rsCmd As New ADODB.Command
		
		UnLockAll = False
		On Error GoTo UnLockAll_Err
		
		Criteria = "DELETE FROM sysLOCK "
		Criteria = Criteria & " WHERE LocHOST = '" & Set_Quote(gsHostName) & "' "
		Criteria = Criteria & " AND LocLOGIN = '" & Change_SQLDate(gsHostLogin) & "' "
		Criteria = Criteria & " AND LocUSRID = '" & Set_Quote(gsUserID) & "' "
		Criteria = Criteria & " AND LocPGMID = '" & inPrgID & "' "
		Criteria = Criteria & " AND LocLupdte = '" & Change_SQLDate(inTStamp) & "' "
		With rsCmd
			.let_ActiveConnection(cnCon)
			.CommandType = ADODB.CommandTypeEnum.adCmdText
			.CommandText = Criteria
			.Execute()
		End With
		
		
		UnLockAll = True
		'UPGRADE_NOTE: Object rsCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCmd = Nothing
		
		Exit Function
		
UnLockAll_Err: 
		MsgBox("UnLockAll Err!")
		'UPGRADE_NOTE: Object rsCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsCmd = Nothing
		
	End Function
	
	
	
	
	
	Public Function Get_TableInfo(ByVal inTable As String, ByVal inCrt As String, ByVal inColumnName As String) As String
		'Usage       : Read the Control Flag of the System Profile Table and returns the value
		'Parameters  : Column Name
		'Return Value: Column Value in the Database
		
		Dim rsRcd As New ADODB.Recordset
		Dim Criteria As String
		
		Get_TableInfo = ""
		
		Criteria = "SELECT " & Set_Quote(inColumnName)
		Criteria = Criteria & " FROM " & inTable
		Criteria = Criteria & " WHERE " & inCrt
		
		rsRcd.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Get_TableInfo = ReadRs(rsRcd, inColumnName)
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	
	Public Function Chk_MedDate(ByRef inDte As String) As Short
		
		'inDteCtl : The control which needed to check
		'inCol    : If the control is a Grid, inCol is to indicate the column no.
		
		Dim inDate As String
		Dim wsDay As String
		Dim wsMth As String
		Dim wsYear As String
		Dim FirstSlash As Short
		Dim SecondSlash As Short
		
		Chk_MedDate = False
		
		inDate = inDte
		
		
		If Len(Trim(inDate)) = 8 Then
			inDate = Left(inDate, 4) & "/" & Mid(inDate, 5, 2) & "/" & Right(inDate, 2)
		End If
		
		
		If Trim(inDate) = "/  /" Or Trim(inDate) = "" Then Exit Function
		
		FirstSlash = InStr(1, inDate, "/")
		SecondSlash = InStr(FirstSlash + 1, inDate, "/")
		
		Select Case gsDteFmt
			Case "DMY"
				wsDay = Trim(Mid(inDate, 1, FirstSlash - 1))
				wsMth = Trim(Mid(inDate, FirstSlash + 1, 2))
				wsYear = Trim(Mid(inDate, SecondSlash + 1))
			Case "MDY"
				wsMth = Trim(Mid(inDate, 1, FirstSlash - 1))
				wsDay = Trim(Mid(inDate, FirstSlash + 1, 2))
				wsYear = Trim(Mid(inDate, SecondSlash + 1))
			Case "YMD"
				wsYear = Trim(Mid(inDate, 1, FirstSlash - 1))
				wsMth = Trim(Mid(inDate, FirstSlash + 1, 2))
				wsDay = Trim(Mid(inDate, SecondSlash + 1))
		End Select
		
		If Val(wsDay) < 1 Or Val(wsDay) > 31 Or Val(wsMth) < 1 Or Val(wsMth) > 12 Or Len(wsYear) = 1 Or Len(wsYear) = 3 Then
			Exit Function
		Else
			If Val(wsMth) <> 12 Then
				If Val(wsDay) > Val(CStr(System.Date.FromOADate(DateSerial(Val(wsYear), Val(wsMth) + 1, 1).ToOADate - DateSerial(Val(wsYear), Val(wsMth), 1).ToOADate))) Then
					Exit Function
				End If
			End If
		End If
		
		If Len(wsYear) = 2 Then
			If Val(wsYear) >= 50 Then
				wsYear = "19" & wsYear
			Else
				wsYear = "20" & wsYear
			End If
		End If
		
		wsDay = New String("0", 2 - Len(wsDay)) & wsDay
		wsMth = New String("0", 2 - Len(wsMth)) & wsMth
		
		If Trim(wsDay) = "" Or Trim(wsMth) = "" Or Trim(wsYear) = "" Then Exit Function
		
		Select Case gsDteFmt
			Case "DMY"
				inDate = wsDay & "/" & wsMth & "/" & wsYear
			Case "MDY"
				inDate = wsMth & "/" & wsDay & "/" & wsYear
			Case "YMD"
				inDate = wsYear & "/" & wsMth & "/" & wsDay
		End Select
		
		
		inDte = inDate
		
		
		
		Chk_MedDate = True
		
	End Function
	
	Public Sub UpdStatusBar(ByRef pic As System.Windows.Forms.PictureBox, ByVal sngPercent As Single, Optional ByVal fBorderCase As Object = Nothing)
		'-----------------------------------------------------------
		' SUB: UpdStatusBar
		'
		' "Fill" (by percentage) inside the PictureBox and also
		' display the percentage filled
		'
		' IN: [pic] - PictureBox used to bound "fill" region
		'     [sngPercent] - Percentage of the shape to fill
		'     [fBorderCase] - Indicates whether the percentage
		'        specified is a "border case", i.e. exactly 0%
		'        or exactly 100%.  Unless fBorderCase is True,
		'        the values 0% and 100% will be assumed to be
		'        "close" to these values, and 1% and 99% will
		'        be used instead.
		'
		' Notes: Set AutoRedraw property of the PictureBox to True
		'        so that the status bar and percentage can be auto-
		'        matically repainted if necessary
		'-----------------------------------------------------------
		'
		Dim intPercent As Double
		Dim strPercent As String
		Dim intX As Short
		Dim intY As Short
		Dim intWidth As Short
		Dim intHeight As Short
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fBorderCase. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If IsNothing(fBorderCase) Then fBorderCase = False
		
		'For this to work well, we need a white background and any color foreground (blue)
		Const colBackground As Integer = &HFFFFFF ' white
		Const colForeground As Integer = &HFF0000 ' blue
		
		pic.ForeColor = System.Drawing.ColorTranslator.FromOle(colForeground)
		pic.BackColor = System.Drawing.ColorTranslator.FromOle(colBackground)
		
		'
		'Format percentage and get attributes of text
		'
		intPercent = sngPercent
		
		'Never allow the percentage to be 0 or 100 unless it is exactly that value.  This
		'prevents, for instance, the status bar from reaching 100% until we are entirely done.
		If intPercent = 0 Then
			If Not fBorderCase Then
				intPercent = 1
			End If
		ElseIf intPercent = 100 Then 
			If Not fBorderCase Then
				intPercent = 99
			End If
		End If
		If sngPercent <> 0 Then
			strPercent = VB6.Format(intPercent) & "%"
		Else
			strPercent = ""
		End If
		'UPGRADE_ISSUE: PictureBox method pic.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'intWidth = pic.TextWidth(strPercent)
		'UPGRADE_ISSUE: PictureBox method pic.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'intHeight = pic.TextHeight(strPercent)
		
		'
		'Now set intX and intY to the starting location for printing the percentage
		'
		intX = VB6.PixelsToTwipsX(pic.Width) / 2 - intWidth / 2
		intY = VB6.PixelsToTwipsY(pic.Height) / 2 - intHeight / 2
		
		'
		'Need to draw a filled box with the pics background color to wipe out previous
		'percentage display (if any)
		'
		'UPGRADE_ISSUE: PictureBox property pic.DrawMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.DrawMode = 13 ' Copy Pen
		'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.Line (intX, intY) - Step(intWidth, intHeight), System.Drawing.ColorTranslator.ToOle(pic.BackColor), BF
		
		'
		'Back to the center print position and print the text
		'
		'UPGRADE_ISSUE: PictureBox property pic.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.CurrentX = intX
		'UPGRADE_ISSUE: PictureBox property pic.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.CurrentY = intY
		'UPGRADE_ISSUE: PictureBox method pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.Print(strPercent)
		
		'
		'Now fill in the box with the ribbon color to the desired percentage
		'If percentage is 0, fill the whole box with the background color to clear it
		'Use the "Not XOR" pen so that we change the color of the text to white
		'wherever we touch it, and change the color of the background to blue
		'wherever we touch it.
		'
		'UPGRADE_ISSUE: PictureBox property pic.DrawMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.DrawMode = 10 ' Not XOR Pen
		If sngPercent > 0 Then
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'pic.Line (0, 0) - (VB6.PixelsToTwipsX(pic.Width) * (sngPercent / 100), VB6.PixelsToTwipsY(pic.Height)), System.Drawing.ColorTranslator.ToOle(pic.ForeColor), BF
		Else
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'pic.Line (0, 0) - (VB6.PixelsToTwipsX(pic.Width), VB6.PixelsToTwipsY(pic.Height)), System.Drawing.ColorTranslator.ToOle(pic.BackColor), BF
		End If
		
		pic.Refresh()
		
	End Sub
	Public Function Encrypt(ByRef inVal As String) As String
		
		' inVal = the string you wish to encrypt or decrypt.
		' PassWord = the password with which to encrypt the string.
		' pass a string for encryption.  Use the return string and call again, it will decrypt.
		
		Dim PassWord As String
		'UPGRADE_NOTE: Char was upgraded to Char_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Char_Renamed As String
		Dim L As Short
		Dim X As Short
		
		PassWord = "NBASE2000"
		
		L = Len(PassWord)
		For X = 1 To Len(inVal)
			Char_Renamed = CStr(Asc(Mid(PassWord, (X Mod L) - L * CShort((X Mod L) = 0), 1)))
			Mid(inVal, X, 1) = Chr(Asc(Mid(inVal, X, 1)) Xor Char_Renamed)
		Next 
		
		Encrypt = inVal
		
	End Function
	Public Sub Ini_PgmMenu(ByRef inMenuCtl As Object, ByRef InPgmID As String, Optional ByRef inArray As Object = Nothing)
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		Dim wiMenuItem As Short
		Dim wiCtr As Short
		Dim wiStop As Short
		
		wiStop = False
		wiCtr = 0
		
		On Error GoTo Err_Handler
		
		Do While Not wiStop
			If wiCtr = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				inMenuCtl.Caption = ""
			Else
				'UPGRADE_ISSUE: Unload inMenuCtl() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
                'Unload(inMenuCtl(wiCtr))
			End If
			wiCtr = wiCtr + 1
		Loop 
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inArray.ReDim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		inArray.ReDim(0, -1, 0, 2)
		
		
		wsSQL = "SELECT SCRFLDID, SCRFLDNAME "
		wsSQL = wsSQL & " FROM SYSSCRCAPTION WHERE SCRTYPE = 'MNU' "
		wsSQL = wsSQL & " AND SCRPGMID = '" & InPgmID & "' "
		wsSQL = wsSQL & " AND SCRLANGID = '" & gsLangID & "' "
		wsSQL = wsSQL & " ORDER BY SCRSEQNO "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		wiMenuItem = 0
		
		If rsRcd.RecordCount > 0 Then
			rsRcd.MoveFirst()
			Do While Not rsRcd.EOF
				'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
				If Not IsNothing(inArray) Then
					If wiMenuItem > 0 Then inMenuCtl.Load(wiMenuItem)
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Enabled = True
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl(wiMenuItem).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Caption = ReadRs(rsRcd, "SCRFLDNAME")
					With inArray
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray.AppendRows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.AppendRows()
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inArray(.UpperBound(1), 0) = ReadRs(rsRcd, "SCRFLDID")
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inArray(.UpperBound(1), 1) = ReadRs(rsRcd, "SCRFLDNAME")
						
						'If ReadRs(rsRcd, "SPCMNUSPA") = "Y" Then
						'    Load inMenuCtl(wiMenuItem + 1)
						'    inMenuCtl(wiMenuItem + 1).Enabled = True
						'    inMenuCtl(wiMenuItem + 1).Caption = "-"
						'    .AppendRows
						'    inArray(.UpperBound(1), 0) = "-"
						'End If
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If Chk_UserRight(gsUserID, ReadRs(rsRcd, "SCRFLDID")) = False Then
							'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inMenuCtl(wiMenuItem).Enabled = False
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inArray(.UpperBound(1), 2) = "N"
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inMenuCtl(wiMenuItem).Enabled = True
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inArray(.UpperBound(1), 2) = "Y"
						End If
					End With
				Else
					If wiMenuItem > 0 Then inMenuCtl.Load(wiMenuItem)
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Enabled = True
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl(wiMenuItem).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Caption = ReadRs(rsRcd, "SCRFLDNAME")
					'If ReadRs(rsRcd, "SPCMNUSPA") = "Y" Then
					'    Load inMenuCtl(wiMenuItem + 1)
					'    inMenuCtl(wiMenuItem + 1).Enabled = True
					'    inMenuCtl(wiMenuItem + 1).Caption = "-"
					'End If
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Enabled = True
				End If
				wiMenuItem = wiMenuItem + 1
				rsRcd.MoveNext()
			Loop 
		End If
		
		Exit Sub
		
Err_Handler: 
		wiStop = True
		Resume Next
		
	End Sub
	
	Public Function Chk_UserRight(ByRef inUsrId As String, ByRef InPgmID As String) As Short
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_UserRight = False
		
        If inUsrId = "NBASE" Then
            Chk_UserRight = True
        Else
            wsSQL = "SELECT URPGMID FROM sysUserRight, mstUser "
            wsSQL = wsSQL & " WHERE USRGRPCODE = URGRPCODE "
            wsSQL = wsSQL & " AND URPGMID = '" & InPgmID & "' "
            wsSQL = wsSQL & " AND USRCODE = '" & inUsrId & "' "

            rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

            If rsRcd.RecordCount > 0 Then
                Chk_UserRight = True
            End If

            rsRcd.Close()
        End If
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Public Function Chk_GrpRight(ByRef inGrpId As String, ByRef InPgmID As String) As Short
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_GrpRight = False
		
		wsSQL = "SELECT * FROM sysUserRight "
		wsSQL = wsSQL & " WHERE URGRPCODE = '" & Set_Quote(inGrpId) & "' "
		wsSQL = wsSQL & " AND URPGMID = '" & Set_Quote(InPgmID) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			Chk_GrpRight = True
		End If
		
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	Public Function Chk_PgmExist(ByRef InPgmID As String) As Short
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		
		Chk_PgmExist = False
		
		wsSQL = "SELECT * FROM sysScrCaption "
		wsSQL = wsSQL & " WHERE ScrFldID = 'SCRHDR'"
		wsSQL = wsSQL & " AND ScrPgmID = '" & Set_Quote(InPgmID) & "' "
		wsSQL = wsSQL & " AND ScrType = 'SCR' "
		wsSQL = wsSQL & " AND ScrLangID = '" & gsLangID & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			Chk_PgmExist = True
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	Public Function SkipA(ByVal inText As String) As String
		Dim strPos As Short
		Dim iCtr As Short
		Dim outText As String
		Dim TmpChar As String
		
		strPos = InStr(inText, "&")
		If strPos <> 0 And Trim(inText) <> "" Then
			outText = Left(inText, strPos - 1) & Right(inText, Len(inText) - strPos)
		Else
			outText = inText
		End If
		
		SkipA = outText
		
	End Function
	
	
	Public Function Get_ErrMsg(ByVal InPgmNo As Integer, ByVal InFLdID As Integer) As String
		
		Dim adCmd As New ADODB.Command
		
		On Error GoTo Get_ErrMsg_Err
		
		adCmd.ActiveConnection = cnCon
		
		adCmd.CommandText = "USP_GETERRMSG"
		adCmd.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adCmd.Parameters.Refresh()
		
		Call SetSPPara(adCmd, 1, InPgmNo)
		Call SetSPPara(adCmd, 2, "ERR")
		Call SetSPPara(adCmd, 3, gsLangID)
		Call SetSPPara(adCmd, 4, InFLdID)
		
		adCmd.Execute()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSPPara(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Get_ErrMsg = GetSPPara(adCmd, 5)
		
		'UPGRADE_NOTE: Object adCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adCmd = Nothing
		
		Exit Function
		
Get_ErrMsg_Err: 
		MsgBox("Get_ErrMsg_Err!")
		'UPGRADE_NOTE: Object adCmd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adCmd = Nothing
		
	End Function
	
	Public Function Chk_ValidDocDate(ByVal inDate As String, ByVal inSysCode As String) As Boolean
		Dim wsCtlMth As Object
		'Usage     : This function will validate if the user input a
		'            valid date (the date must be greater than or equal to
		'            the current control period
		'Parameters: inDate    - a valid Document Date
		'            inSysCode - the system code e.g. AR, AP, GL
		
		Dim wsCtrlMth As String
		Dim wsInValue As String
		
		Chk_ValidDocDate = False
		
		wsCtrlMth = getCtrlMth(inSysCode)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object wsCtlMth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If wsCtlMth = "0" Then Exit Function
		
		
		wsInValue = Left(inDate, 4) & Mid(inDate, 6, 2)
		
		If To_Value(wsInValue) < To_Value(wsCtrlMth) Then
			If Chk_ClosedMth(inSysCode, inDate) = False Then
				gsMsg = "Document Date Invalid! Month has Closed!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				Exit Function
			End If
		End If
		
		Chk_ValidDocDate = True
		
	End Function
	
	Public Function getCtrlMth(ByVal inCtlMdl As String, Optional ByRef outStartDte As String = "", Optional ByRef outEndDte As String = "") As String
		
		' control Month in YYYYMM format
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wsCtlMth As String
		
		wsSQL = "SELECT MCCTLPRD, CONVERT(DATETIME, MCCTLYR + '/' + MCCTLMN + '/01') STRDTE, "
		wsSQL = wsSQL & "DATEADD(DAY, -1, DATEADD(MONTH, 1, MCCTLYR + '/' + MCCTLMN + '/01')) ENDDTE "
		wsSQL = wsSQL & " FROM sysMonCtl WHERE MCMODNO = '" & Set_Quote(inCtlMdl) & "' "
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			wsCtlMth = ReadRs(rsRcd, "MCCTLPRD")
			outStartDte = Dsp_Date(ReadRs(rsRcd, "STRDTE"))
			outEndDte = Dsp_Date(ReadRs(rsRcd, "ENDDTE"))
		Else
			wsCtlMth = "0"
			gsMsg = "No Month Control!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		getCtrlMth = wsCtlMth
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
	End Function
	
	
	Public Function Chk_ClosedMth(ByRef inModNo As String, ByRef inDocDate As String) As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim CtlYr As String
		Dim CtlMon As String
		
		
		Chk_ClosedMth = False
		
		CtlYr = Left(inDocDate, 4)
		CtlMon = Mid(inDocDate, 6, 2)
		
		wsSQL = ""
		wsSQL = wsSQL & "SELECT RMCRELFLG FROM sysRelMonCtl "
		wsSQL = wsSQL & "WHERE RMCMODNO = '" & Set_Quote(inModNo) & "' "
		wsSQL = wsSQL & "AND RMCRELYR = '" & Set_Quote(CtlYr) & "' "
		wsSQL = wsSQL & "AND RMCRELMN = '" & Set_Quote(CtlMon) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(rsRcd, RMCRELFLG). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If ReadRs(rsRcd, "RMCRELFLG") = "Y" Then
				Chk_ClosedMth = True
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
	End Function
	
	
	Public Sub Ini_PopMenu(ByRef inMenuCtl As Object, ByRef InPgmID As String, Optional ByRef inArray As Object = Nothing)
		
		Dim wsSQL As String
		Dim rsRcd As New ADODB.Recordset
		Dim wiMenuItem As Short
		Dim wiCtr As Short
		Dim wiStop As Short
		
		wiStop = False
		wiCtr = 0
		
		On Error GoTo Err_Handler
		
		Do While Not wiStop
			If wiCtr = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				inMenuCtl.Caption = ""
			Else
				'UPGRADE_ISSUE: Unload inMenuCtl() was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
                'Unload(inMenuCtl(wiCtr))
			End If
			wiCtr = wiCtr + 1
		Loop 
		
		'UPGRADE_WARNING: Couldn't resolve default property of object inArray.ReDim. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		inArray.ReDim(0, -1, 0, 2)
		
		
		wsSQL = "SELECT SCRFLDID, SCRFLDNAME "
		wsSQL = wsSQL & " FROM SYSSCRCAPTION WHERE SCRTYPE = 'PMU' "
		wsSQL = wsSQL & " AND SCRPGMID = '" & InPgmID & "' "
		wsSQL = wsSQL & " AND SCRLANGID = '" & gsLangID & "' "
		wsSQL = wsSQL & " ORDER BY SCRSEQNO "
		
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		wiMenuItem = 0
		
		If rsRcd.RecordCount > 0 Then
			rsRcd.MoveFirst()
			Do While Not rsRcd.EOF
				'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
				If Not IsNothing(inArray) Then
					If wiMenuItem > 0 Then inMenuCtl.Load(wiMenuItem)
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Enabled = True
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl(wiMenuItem).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Caption = ReadRs(rsRcd, "SCRFLDNAME")
					With inArray
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray.AppendRows. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						.AppendRows()
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inArray(.UpperBound(1), 0) = ReadRs(rsRcd, "SCRFLDID")
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						inArray(.UpperBound(1), 1) = ReadRs(rsRcd, "SCRFLDNAME")
						
						'If ReadRs(rsRcd, "SPCMNUSPA") = "Y" Then
						'    Load inMenuCtl(wiMenuItem + 1)
						'    inMenuCtl(wiMenuItem + 1).Enabled = True
						'    inMenuCtl(wiMenuItem + 1).Caption = "-"
						'    .AppendRows
						'    inArray(.UpperBound(1), 0) = "-"
						'End If
						'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If Chk_UserRight(gsUserID, ReadRs(rsRcd, "SCRFLDID")) = False Then
							'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inMenuCtl(wiMenuItem).Enabled = False
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inArray(.UpperBound(1), 2) = "N"
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inMenuCtl(wiMenuItem).Enabled = True
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray.UpperBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object inArray(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							inArray(.UpperBound(1), 2) = "Y"
						End If
					End With
				Else
					If wiMenuItem > 0 Then inMenuCtl.Load(wiMenuItem)
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Enabled = True
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl(wiMenuItem).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Caption = ReadRs(rsRcd, "SCRFLDNAME")
					'If ReadRs(rsRcd, "SPCMNUSPA") = "Y" Then
					'    Load inMenuCtl(wiMenuItem + 1)
					'    inMenuCtl(wiMenuItem + 1).Enabled = True
					'    inMenuCtl(wiMenuItem + 1).Caption = "-"
					'End If
					'UPGRADE_WARNING: Couldn't resolve default property of object inMenuCtl().Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					inMenuCtl(wiMenuItem).Enabled = True
				End If
				wiMenuItem = wiMenuItem + 1
				rsRcd.MoveNext()
			Loop 
		End If
		
		Exit Sub
		
Err_Handler: 
		wiStop = True
		Resume Next
		
	End Sub
	
	Public Function Replace_Str(ByVal inText As String, ByVal FromStr As String, ByVal ToStr As String) As String
		Dim strPos As Short
		Dim iCtr As Short
		Dim outText As String
		Dim leftText As String
		Dim rightText As String
		
		strPos = InStr(inText, FromStr)
		outText = inText
		
		Do While (strPos <> 0)
			
			leftText = Left(outText, strPos - 1)
			rightText = Right(outText, Len(outText) - strPos - Len(FromStr) + 1)
			outText = leftText & ToStr & rightText
			
			strPos = InStr(outText, FromStr)
			
		Loop 
		
		
		Replace_Str = outText
		
	End Function
End Module