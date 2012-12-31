Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmARPE000
	Inherits System.Windows.Forms.Form
	
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	Private wsARToDate As String
	Private wsAPToDate As String
	Private wsGLToDate As String
	
	
	Private Sub cmdCancel()
		Ini_Scr()
		
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim adcmdSave As New ADODB.Command
		
		On Error GoTo cmdSave_Err
		
		wsDteTim = gsSystemDate
		
		' If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		If chkAR.CheckState = 1 Then
			If Chk_ARUpdFlg = True Then
				
				
				adcmdSave.CommandText = "USP_ARPE000"
				adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
				adcmdSave.Parameters.Refresh()
				
				Call SetSPPara(adcmdSave, 1, wsARToDate)
				Call SetSPPara(adcmdSave, 2, gsUserID)
				Call SetSPPara(adcmdSave, 3, wsDteTim)
				
				
				adcmdSave.Execute()
				
			End If
		End If
		
		If chkAP.CheckState = 1 Then
			If Chk_APUpdFlg = True Then
				
				adcmdSave.CommandText = "USP_APPE000"
				adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
				adcmdSave.Parameters.Refresh()
				
				Call SetSPPara(adcmdSave, 1, wsAPToDate)
				Call SetSPPara(adcmdSave, 2, gsUserID)
				Call SetSPPara(adcmdSave, 3, wsDteTim)
				
				
				adcmdSave.Execute()
				
			End If
		End If
		
		If chkGL.CheckState = 1 Then
			
			
			adcmdSave.CommandText = "USP_GLPE000"
			adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			adcmdSave.Parameters.Refresh()
			
			Call SetSPPara(adcmdSave, 1, wsGLToDate)
			Call SetSPPara(adcmdSave, 2, gsUserID)
			Call SetSPPara(adcmdSave, 3, wsDteTim)
			
			
			adcmdSave.Execute()
			
		End If
		
		cnCon.CommitTrans() 'Create Stored Procedure String
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		gsMsg = "Update Process is completed!"
		MsgBox(gsMsg, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, gsTitle)
		
		Call cmdCancel()
		
		Exit Sub
		
cmdSave_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
	End Sub
	
	
	
	Private Sub chkAR_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkAR.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            chkAP.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub chkAP_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkAP.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            chkGL.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub chkGL_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkGL.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0 ' System.Windows.Forms.Cursors.Default
            chkAR.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	
	Private Sub frmARPE000_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			
			
			Case System.Windows.Forms.Keys.F9
				
				Call cmdOK()
				
			Case System.Windows.Forms.Keys.F11
				
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				
				Me.Close()
				
		End Select
	End Sub
	
	Private Sub frmARPE000_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "ARPE000"
		
	End Sub
	
	Private Sub Ini_Scr()
		Dim wsFromDate As String
		Dim wsARCtlPrd As String
		Dim wsAPCtlPrd As String
		Dim wsGLCtlPrd As String
		
		Me.Text = wsFormCaption
		
		
		wsARCtlPrd = getCtrlMth("AR")
		wsFromDate = VB.Left(wsARCtlPrd, 4) & "/" & Mid(wsARCtlPrd, 5, 2) & "/" & "01"
		wsARToDate = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, CDate(DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(wsFromDate)))))
		
		
		wsAPCtlPrd = getCtrlMth("AP")
		wsFromDate = VB.Left(wsAPCtlPrd, 4) & "/" & Mid(wsAPCtlPrd, 5, 2) & "/" & "01"
		wsAPToDate = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, CDate(DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(wsFromDate)))))
		
		
		wsGLCtlPrd = getCtrlMth("GL")
		wsFromDate = VB.Left(wsGLCtlPrd, 4) & "/" & Mid(wsGLCtlPrd, 5, 2) & "/" & "01"
		wsGLToDate = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, CDate(DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(wsFromDate)))))
		
		chkAR.CheckState = System.Windows.Forms.CheckState.Checked
		chkAP.CheckState = System.Windows.Forms.CheckState.Checked
		chkGL.CheckState = System.Windows.Forms.CheckState.Checked
		
		lblDspARCtlPrd.Text = VB.Left(wsARCtlPrd, 4) & "/" & VB.Right(wsARCtlPrd, 2)
		lblDspAPCtlPrd.Text = VB.Left(wsAPCtlPrd, 4) & "/" & VB.Right(wsAPCtlPrd, 2)
		lblDspGLCtlPrd.Text = VB.Left(wsGLCtlPrd, 4) & "/" & VB.Right(wsGLCtlPrd, 2)
		
		
	End Sub
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		If chkAR.CheckState = 1 Then
			If Chk_ARUpdFlg = False Then
				Exit Function
			End If
		End If
		If chkAP.CheckState = 1 Then
			If Chk_APUpdFlg = False Then
				Exit Function
			End If
		End If
		If chkGL.CheckState = 1 Then
			'    If chk_GLUpdFlg = False Then
			'        Exit Function
			'    End If
		End If
		
		
		If chkAR.CheckState = 0 And chkAP.CheckState = 0 And chkGL.CheckState = 0 Then
			gsMsg = "Please Select Type Of Update!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			chkAR.Focus()
			Exit Function
		End If
		
		InputValidation = True
		
	End Function
	
	
	
	'UPGRADE_WARNING: Event frmARPE000.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmARPE000_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(5190)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmARPE000_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object frmARPE000 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Me.Close() ' = Nothing
		
	End Sub
	
	
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item("ARPE000", waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		chkAR.Text = Get_Caption(waScrItm, "CHKAR")
		chkAP.Text = Get_Caption(waScrItm, "CHKAP")
		chkGL.Text = Get_Caption(waScrItm, "CHKGL")
		lblWarning.Text = Get_Caption(waScrItm, "WARN1") & Chr(13) & Chr(10) & Get_Caption(waScrItm, "WARN2")
		
		lblCtlPrd.Text = Get_Caption(waScrItm, "CTLPRD")
		
		
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
		
		
		
	End Sub
	
	
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		Select Case Button.Name
			
			Case tcGo
				Call cmdOK()
			Case tcCancel
				Call cmdCancel()
			Case tcExit
				Me.Close()
		End Select
		
	End Sub
	
	Private Function Chk_ARUpdFlg() As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_ARUpdFlg = False
		
		wsSQL = "SELECT Count(*) RecCnt FROM ARINHD "
		wsSQL = wsSQL & "WHERE INHDUPDFLG = 'N' "
		wsSQL = wsSQL & "And INHDDOCDATE <= '" & wsARToDate & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			If To_Value(ReadRs(rsRcd, "RecCnt")) > 0 Then
				gsMsg = "All Invoice/Credit/Debit data must posted!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				chkAR.Focus()
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		wsSQL = "SELECT Count(*) RecCnt FROM ARCHEQUE "
		wsSQL = wsSQL & "WHERE ARCQUPDFLG = 'N' "
		wsSQL = wsSQL & "And ARCQCHQDATE <= '" & wsARToDate & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			If To_Value(ReadRs(rsRcd, "RecCnt")) > 0 Then
				gsMsg = "All Cheque data must posted!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				chkAR.Focus()
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		wsSQL = "SELECT Count(*) RecCnt FROM ARSTHD "
		wsSQL = wsSQL & "WHERE ARSHUPDFLG = 'N' "
		wsSQL = wsSQL & "And ARSHDOCDATE <= '" & wsARToDate & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			If To_Value(ReadRs(rsRcd, "RecCnt")) > 0 Then
				gsMsg = "All Settlement data must posted!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				chkAR.Focus()
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_ARUpdFlg = True
		
	End Function
	Private Function Chk_APUpdFlg() As Boolean
		
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		
		Chk_APUpdFlg = False
		
		wsSQL = "SELECT Count(*) RecCnt FROM APIPHD "
		wsSQL = wsSQL & "WHERE IPHDUPDFLG = 'N' "
		wsSQL = wsSQL & "And IPHDDOCDATE <= '" & wsAPToDate & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			If To_Value(ReadRs(rsRcd, "RecCnt")) > 0 Then
				gsMsg = "All Invoice/Credit/Debit data must posted!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				chkAP.Focus()
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		wsSQL = "SELECT Count(*) RecCnt FROM APCHEQUE "
		wsSQL = wsSQL & "WHERE APCQUPDFLG = 'N' "
		wsSQL = wsSQL & "And APCQCHQDATE <= '" & wsAPToDate & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			If To_Value(ReadRs(rsRcd, "RecCnt")) > 0 Then
				gsMsg = "All Cheque data must posted!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				chkAP.Focus()
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		wsSQL = "SELECT Count(*) RecCnt FROM APSTHD "
		wsSQL = wsSQL & "WHERE APSHUPDFLG = 'N' "
		wsSQL = wsSQL & "And APSHDOCDATE <= '" & wsAPToDate & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		If rsRcd.RecordCount > 0 Then
			If To_Value(ReadRs(rsRcd, "RecCnt")) > 0 Then
				gsMsg = "All Settlement data must posted!"
				MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
				chkAP.Focus()
				rsRcd.Close()
				'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				rsRcd = Nothing
				Exit Function
			End If
		End If
		
		rsRcd.Close()
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		Chk_APUpdFlg = True
		
	End Function
End Class