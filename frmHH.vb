Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmHH
	Inherits System.Windows.Forms.Form
	
	Private wsHHPath As String
	
	
	
	Private Sub btnImport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnImport.Click
		Call cmdImport()
	End Sub
	
	Private Sub btnLoad_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLoad.Click
		
		Dim MyFile As Object
		
		
		HHList.Items.Clear()
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MyFile = Dir(wsHHPath, FileAttribute.Normal)
		'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Do While MyFile <> ""
			
			'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HHList.Items.Add(MyFile)
			
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object MyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MyFile = Dir()
		Loop 
		
		
		
	End Sub
	
	Private Sub cmdImport()
		Dim sFullFile As String
		Dim sFileName As String
		Dim sExt As String
		Dim SDOCNO As String
		Dim i As Short
		Dim bPost As Boolean
		Dim relUpdFlg As String
		
		Dim sfile As String
		Dim wsDteTim As String
		
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wsDteTim = Change_SQLDate(CStr(Now))
		gsMsg = ""
		
		For i = 0 To HHList.Items.Count - 1 'hidden ListBox
			' sFullFile = HHList.List(i)
			' sFileName = Right(sFullFile, Len(sFullFile) - InStrRev(sFullFile, "\"))
			
			sFileName = VB6.GetItemString(HHList, i)
			sFullFile = wsHHPath & VB6.GetItemString(HHList, i)
			sExt = VB.Right(sFileName, Len(sFileName) - InStr(sFileName, "."))
			
			SDOCNO = VB.Left(sFileName, InStr(sFileName, ".") - 1)
			
			
			If UCase(sExt) <> "BAK" And UCase(sExt) <> "FLD" Then
				
				If Chk_HHNo(SDOCNO, relUpdFlg) = True Then
					If relUpdFlg = "N" Then
						
						gsMsg = SDOCNO & "已匯入但未更新, 你是否確認要覆寫此文件?"
						If MsgBox(gsMsg, MsgBoxStyle.OKCancel, gsTitle) = MsgBoxResult.Cancel Then
							bPost = False
						Else
							bPost = True
						End If
						
					Else
						gsMsg = SDOCNO & " 已匯入並更新!"
						MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
						bPost = False
						' Name sFullFile As Left(sFullFile, Len(sFullFile) - 3) & "BAK"
					End If
				Else
					bPost = True
				End If
				
				If bPost Then
					If ImportFromHH(gsUserID, wsDteTim, sFullFile) = True Then
						gsMsg = gsMsg & IIf(gsMsg = "", SDOCNO, Chr(10) & Chr(13) & SDOCNO)
					End If
				End If
				
			End If
			
			Rename(sFullFile, wsHHPath & "backup\" & sFileName)
			
		Next i
		
		
		
		gsMsg = "匯入完成!"
		MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
		
		
		Cursor = System.Windows.Forms.Cursors.Default
		
		
		
	End Sub
	
	Private Sub btnReceive_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnReceive.Click
		
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call ReceiveFromHH(wsHHPath)
		Sleep((1000))
		
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmHH.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Cursor = System.Windows.Forms.Cursors.Default ' vbNormal
		
		
	End Sub
	
	Private Sub Ini_Scr()
		
		
		If Trim(gsHHPath) <> "" Then
			wsHHPath = gsHHPath & "receive\"
		Else
			wsHHPath = My.Application.Info.DirectoryPath & "receive\"
		End If
		
	End Sub
	
	Private Sub frmHH_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Call Ini_Scr()
		
	End Sub
End Class