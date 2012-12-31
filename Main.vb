Option Strict Off
Option Explicit On
Module basMain
	
	'UPGRADE_WARNING: Application will terminate when Sub Main() finishes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E08DDC71-66BA-424F-A612-80AF11498FF8"'
	Public Sub Main()
		'        Call Get_Login_File
		'        frmOpn.ZOrder 1
        'frmOpn.Show vbModal
		frmLogin.ShowDialog()
		
		'  Call Read_Debug_Ini(App.Path & "\" & "HH_HZ.ini")
		'  gsUserID = "HHUSR"
		'  Call Connect_Database
		
		gsDteFmt = "YMD"
		Call getHostLogin()
		Call Get_Date_Fmt()
		Call Get_Company_Info()
		Call Get_Company_Default()
		
		gsWhsCode = "1"
		gsCompID = "1"
		gsSystemDate = VB6.Format(Today, "yyyy/mm/dd")
		gsTitle = gsComNam
		
        'UPGRADE_WARNING: Form method nbMain.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        'Form1.Show()
        nbMain.Show()
        'nbMain.BringToFront()

    End Sub
	
	'-- Center form in center for the screen.
	Public Sub CenterForm(ByRef oForm As System.Windows.Forms.Form)
		oForm.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(oForm.Height)) / 2)
		oForm.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(oForm.Width)) / 2)
	End Sub
	
	Public Sub Write_ErrLog_File(ByRef Mystring As Object)
		
		' Dim sBuffer As String
		' Dim lSize As Long
		Dim WindowsPath As String
		Dim LoginFilePath As String
		' Dim Mystring As String * 100
		
		On Error GoTo Err_Handler
		
		Exit Sub
		
		
		'  sBuffer = Space$(255)
		'  lSize = Len(sBuffer)
		'  Call GetWindowsDirectory(sBuffer, lSize)
		'  If lSize > 0 Then
		'      WindowsPath = Left$(sBuffer, InStr(sBuffer, Chr(0)) - 1)
		'  Else
		'      WindowsPath = vbNullString
		'  End If
		
		WindowsPath = "C:"
		LoginFilePath = WindowsPath & "\Errlog.TXT"
		
		'   If Dir(LoginFilePath) <> "" Then
		'       Kill LoginFilePath
		'   End If
		FileOpen(1, LoginFilePath, OpenMode.Append)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Mystring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteLine(1, Now & "-" & Mystring)
		FileClose(1)
		
		
		Exit Sub
		
Err_Handler: 
		MsgBox(Err.Description & " in Write_ErrLog_File")
		
		
	End Sub
End Module