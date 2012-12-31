Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmLogin
	Inherits System.Windows.Forms.Form
	Private wsWSID As String
	Private wsCPID As String
	Private wsINIFile As String
	
	
	
	Private Sub cboCompany_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCompany.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtUserID.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub



    Private Sub cboLangID_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLangID.Enter
        FocusMe(cboLangID)
    End Sub

    Private Sub cboLangID_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboLangID.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            cmdOK.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cboLangID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboLangID.Leave
        FocusMe(cboLangID, True)
    End Sub

    Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim sBuffer As String
        Dim lSize As Integer
        Dim wiCtr As Integer


        ' If App.PrevInstance = True Then
        '     End
        ' End If

        ' frmSplash.Show
        ' frmSplash.Refresh

        ' For wiCtr = 0 To 200000
        '     DoEvents
        ' Next

        ' Unload frmSplash

        sBuffer = Space(255)
        lSize = Len(sBuffer)
        Call GetUserName(sBuffer, lSize)
        If lSize > 0 Then
            txtUserID.Text = VB.Left(sBuffer, lSize)
        Else
            txtUserID.Text = vbNullString
        End If

        Call Ini_Scr()

        Call GetCompanyList()
        Call GetLanugaeList()

    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        End
    End Sub


    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'To Do - create test for correct password
        'check for correct password

        Dim Chk_Login_Result As Short

        Dim wiIndex As Short

        If cboCompany.SelectedIndex = -1 Then
            For wiIndex = 0 To cboCompany.Items.Count - 1
                If Trim(UCase(cboCompany.Text)) = UCase(VB6.GetItemString(cboCompany, wiIndex)) Then
                    cboCompany.SelectedIndex = wiIndex
                    Exit For
                End If
            Next
        End If

        Call Get_Selected_INI((cboCompany.SelectedIndex))

        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(wsINIFile) = "" Or Trim(wsINIFile) = "" Then
            MsgBox("Can't Find ini File!")
            End
        Else
            Call Read_Debug_Ini(wsINIFile)
        End If

        If cboLangID.SelectedIndex = -1 Then
            For wiIndex = 0 To cboLangID.Items.Count - 1
                If Trim(UCase(cboLangID.Text)) = UCase(VB6.GetItemString(cboLangID, wiIndex)) Then
                    cboLangID.SelectedIndex = wiIndex
                    Exit For
                End If
            Next
        End If

        Call Get_Selected_Lang((cboLangID.SelectedIndex))

        If Connect_Database() = False Then End

        Chk_Login_Result = Chk_Login((txtUserID.Text), (txtPassword.Text))

        Select Case Chk_Login_Result
            '  Case 0
            '      Me.Hide
            Case 1
                gsMsg = "�S�����Τ�!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
                txtUserID.Focus()
                GoTo Login_Err
            Case 2
                gsMsg = "�K�X���~!"
                MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly)
                txtPassword.Focus()
                GoTo Login_Err
        End Select

        '   If UCase(txtUserID.Text) = "NBASE" Then
        '       gsWorkStationID = "01"
        '   Else
        '        Call GetSystemData
        '   End If

        '   Call Get_Company_Info

        '  Call Write_Login_File

        ' frmInfo.Show
        Me.Close()
        Exit Sub

Login_Err:
        Call Disconnect_Database()

    End Sub

    Private Sub Ini_Scr()

        Me.Text = "Log In"
        lblCompany.Text = "Company :"
        lblUser.Text = "User Name :"
        lblPassword.Text = "Password: "
        lblLanguage.Text = "Language :"
        cmdOK.Text = "OK"
        cmdCancel.Text = "Cancel"


    End Sub
    Private Sub GetCompanyList()

        Dim sBuffer As String
        Dim lSize As Integer
        Dim SystemPath As String
        Dim CompanyEntries As String

        On Error GoTo Err_GetCompanyList

        SystemPath = My.Application.Info.DirectoryPath

        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(SystemPath & "\COMPANY.LST") = "" Then
            MsgBox("My.Resources.str113")
            End
        Else
            FileOpen(1, SystemPath & "\COMPANY.LST", OpenMode.Input)
            cboCompany.Items.Clear()
            Do While Not EOF(1)
                Input(1, CompanyEntries)
                If InStr(1, CompanyEntries, ";") > 0 Then
                    cboCompany.Items.Add(VB.Left(CompanyEntries, InStr(1, CompanyEntries, ";") - 1))
                End If
            Loop
            FileClose(1)
            cboCompany.SelectedIndex = 0
        End If

        Exit Sub

Err_GetCompanyList:

        gsMsg = "�䤣�줽�q�M��!"
        MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly)

    End Sub

    Private Sub GetLanugaeList()

        Dim sBuffer As String
        Dim lSize As Integer
        Dim SystemPath As String
        Dim LangEntries As String

        On Error GoTo Err_GetLanugaeList

        SystemPath = My.Application.Info.DirectoryPath

        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(SystemPath & "\LANG.LST") = "" Then
            MsgBox("My.Resources.str113")
            End
        Else
            FileOpen(1, SystemPath & "\LANG.LST", OpenMode.Input)
            cboLangID.Items.Clear()
            Do While Not EOF(1)
                Input(1, LangEntries)
                If InStr(1, LangEntries, ";") > 0 Then
                    cboLangID.Items.Add(VB.Left(LangEntries, InStr(1, LangEntries, ";") - 1))
                End If
            Loop
            FileClose(1)
            cboLangID.SelectedIndex = 0
        End If

        Exit Sub

Err_GetLanugaeList:

        gsMsg = "�䤣��y�زM��!"
        MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly)

    End Sub

    Private Function Get_Selected_INI(ByRef inListindex As Short) As String

        Dim compLine As String
        Dim Counter As Short
        Dim EndofFirstPart As Short

        Counter = 0
        Get_Selected_INI = ""

        FileOpen(1, My.Application.Info.DirectoryPath & "\COMPANY.LST", OpenMode.Input)
        Do While Not EOF(1) And Counter <= inListindex
            compLine = LineInput(1)
            If Counter = inListindex Then
                EndofFirstPart = InStr(1, compLine, ";")
                Get_Selected_INI = My.Application.Info.DirectoryPath & "\" & Mid(compLine, EndofFirstPart + 1)
            End If
            Counter = Counter + 1
        Loop
        FileClose(1)
        wsINIFile = Get_Selected_INI

    End Function

    Private Function Get_Selected_Lang(ByRef inListindex As Short) As String

        Dim compLine As String
        Dim Counter As Short
        Dim EndofFirstPart As Short

        Counter = 0
        Get_Selected_Lang = ""

        FileOpen(1, My.Application.Info.DirectoryPath & "\LANG.LST", OpenMode.Input)
        Do While Not EOF(1) And Counter <= inListindex
            compLine = LineInput(1)
            If Counter = inListindex Then
                EndofFirstPart = InStr(1, compLine, ";")
                Get_Selected_Lang = Mid(compLine, EndofFirstPart + 1)
            End If
            Counter = Counter + 1
        Loop
        FileClose(1)
        gsLangID = Get_Selected_Lang

    End Function

    Private Function Chk_Login(ByRef inUser As Object, ByRef inPassword As Object) As Short

        Dim rsLogin As New ADODB.Recordset
        Dim Criteria As String

        Chk_Login = 0

        'UPGRADE_WARNING: Couldn't resolve default property of object inUser. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Criteria = "SELECT USRPWD, USRNAME FROM MSTUSER WHERE USRCODE = '" & Set_Quote(inUser) & "' "

        rsLogin.Open(Criteria, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        If rsLogin.RecordCount > 0 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object inPassword. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Encrypt(rsLogin.Fields("USRPWD").Value) <> UCase(inPassword) Then
                rsLogin.Close()
                Chk_Login = 2
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object inUser. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                gsUserID = inUser
            End If
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object inPassword. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object inUser. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If UCase(inUser) = "NBASE" And UCase(inPassword) = "NBTEL" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object inUser. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                gsUserID = UCase(inUser)
            Else
                Chk_Login = 1
            End If
        End If

        'rsLogin.Close()

    End Function



    Private Sub GetSystemData()


        Dim sBuffer As String
        Dim lSize As Integer
        Dim WindowsPath As String
        Dim LoginFilePath As String
        Dim Mystring As New VB6.FixedLengthString(100)
        Dim LineCount As Short

        sBuffer = Space(255)
        lSize = Len(sBuffer)
        Call GetWindowsDirectory(sBuffer, lSize)
        If lSize > 0 Then
            WindowsPath = VB.Left(sBuffer, InStr(sBuffer, Chr(0)) - 1)
        Else
            WindowsPath = vbNullString
        End If


        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(WindowsPath & "\NBASE.DAT") = "" Then
            MsgBox("No System File!")
            End
        Else
            FileOpen(1, WindowsPath & "\NBASE.DAT", OpenMode.Binary, OpenAccess.Read)
            LineCount = 1
            Do While Not EOF(1) And LineCount < 3
                'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                FileGet(1, Mystring.Value)
                Select Case LineCount
                    Case 1
                        wsCPID = Trim(Encrypt(Mystring.Value))
                    Case 2
                        wsWSID = Trim(Encrypt(Mystring.Value))
                End Select
                LineCount = LineCount + 1
            Loop
            FileClose(1)
        End If

        If UCase(VB.Right(wsCPID, 2)) <> UCase(wsWSID) Then
            MsgBox("Non-authorize User!")
            End
        End If

        gsWorkStationID = wsWSID

    End Sub



    Private Sub txtPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Enter
        Call FocusMe(txtPassword)
    End Sub

    Private Sub txtPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            cmdOK_Click(cmdOK, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtPassword_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Leave
        Call FocusMe(txtPassword, True)
    End Sub

    Private Sub txtUserID_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUserID.Enter
        Call FocusMe(txtUserID)
    End Sub

    Private Sub txtUserID_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            txtPassword.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub txtUserID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUserID.Leave
		Call FocusMe(txtUserID, True)
	End Sub
End Class