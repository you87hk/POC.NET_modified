Option Strict Off
Option Explicit On

Imports Microsoft.Office.Interop

Module NBRptFunc
	Public Structure POINT
		Dim X As Integer
		Dim Y As Integer
	End Structure
	
	Public Structure LV_FINDINFO
		Dim flags As Integer
		Dim psz As String
		Dim lParam As Integer
		Dim pt As POINT
		Dim vkDirection As Integer
	End Structure
	
	Public Structure LV_ITEM
		Dim mask As Integer
		Dim iItem As Integer
		Dim iSubItem As Integer
		Dim State As Integer
		Dim stateMask As Integer
		Dim pszText As Integer
		Dim cchTextMax As Integer
		Dim iImage As Integer
		Dim lParam As Integer
		Dim iIndent As Integer
	End Structure
	
	'Constants
	Public Const LVFI_PARAM As Short = 1
	Public Const LVIF_TEXT As Integer = &H1
	
	Public Const LVM_FIRST As Integer = &H1000
	Public Const LVM_FINDITEM As Decimal = LVM_FIRST + 13
	Public Const LVM_GETITEMTEXT As Decimal = LVM_FIRST + 45
	Public Const LVM_SORTITEMS As Decimal = LVM_FIRST + 48
	
	Public Const LVS_EX_FULLROWSELECT As Integer = &H20
	Public Const LVM_GETEXTENDEDLISTVIEWSTYLE As Decimal = LVM_FIRST + &H37
	Public Const LVM_SETEXTENDEDLISTVIEWSTYLE As Decimal = LVM_FIRST + &H36
	
	'API declarations
	
	Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	
	
	
	
	'Module Functions and Procedures
	
	'CompareDates: This is the sorting routine that gets passed to the
	'ListView control to provide the comparison test for date values.
	
	Public Function CompareDates(ByVal lngParam1 As Integer, ByVal lngParam2 As Integer, ByVal hwnd As Integer, ByVal SubItemPos As Integer) As Integer
		
		Dim strName1 As String
		Dim strName2 As String
		Dim dDate1 As Date
		Dim dDate2 As Date
		
		'Obtain the item names and dates corresponding to the
		'input parameters
		
		ListView_GetItemData(lngParam1, hwnd, strName1, dDate1, SubItemPos - 2)
		ListView_GetItemData(lngParam2, hwnd, strName2, dDate2, SubItemPos - 2)
		
		'Compare the dates
		'Return 0 ==> Less Than
		'       1 ==> Equal
		'       2 ==> Greater Than
		
		If dDate1 < dDate2 Then
			CompareDates = 0
		ElseIf dDate1 = dDate2 Then 
			CompareDates = 1
		Else
			CompareDates = 2
		End If
		
	End Function
	
	'GetItemData - Given Retrieves
	
	Public Sub ListView_GetItemData(ByRef lngParam As Integer, ByRef hwnd As Integer, ByRef strName As String, ByRef dDate As Date, ByRef SubItemPos As Short)
		Dim objFind As LV_FINDINFO
		Dim lngIndex As Integer
		Dim objItem As LV_ITEM
		Dim baBuffer(32) As Byte
		Dim lngLength As Integer
		
		'
		' Convert the input parameter to an index in the list view
		'
		objFind.flags = LVFI_PARAM
		objFind.lParam = lngParam
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'lngIndex = SendMessage(hwnd, LVM_FINDITEM, -1, VarPtr(objFind))
		
		'
		' Obtain the name of the specified list view item
		'
		objItem.mask = LVIF_TEXT
		objItem.iSubItem = 0
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'objItem.pszText = VarPtr(baBuffer(0))
		objItem.cchTextMax = UBound(baBuffer)
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'lngLength = SendMessage(hwnd, LVM_GETITEMTEXT, lngIndex, VarPtr(objItem))
		'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        'strName = Left(StrConv(System.Text.UnicodeEncoding.Unicode.GetString(baBuffer), vbUnicode), lngLength)
		
		'
		' Obtain the modification date of the specified list view item
		'
		objItem.mask = LVIF_TEXT
		objItem.iSubItem = SubItemPos
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'objItem.pszText = VarPtr(baBuffer(0))
		objItem.cchTextMax = UBound(baBuffer)
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'lngLength = SendMessage(hwnd, LVM_GETITEMTEXT, lngIndex, VarPtr(objItem))
		If lngLength > 0 Then
			'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
            'dDate = CDate(Left(StrConv(System.Text.UnicodeEncoding.Unicode.GetString(baBuffer), vbUnicode), lngLength))
		End If
		
	End Sub
	
	'GetListItem - This is a modified version of ListView_GetItemData
	' It takes an index into the list as a parameter and returns
	' the appropriate values in the strName and dDate parameters.
	
	Public Sub ListView_GetListItem(ByRef lngIndex As Integer, ByRef hwnd As Integer, ByRef strName As String, ByRef dDate As Date, ByRef SubItemPos As Short)
		Dim objItem As LV_ITEM
		Dim baBuffer(32) As Byte
		Dim lngLength As Integer
		
		'
		' Obtain the name of the specified list view item
		'
		objItem.mask = LVIF_TEXT
		objItem.iSubItem = 0
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'objItem.pszText = VarPtr(baBuffer(0))
		objItem.cchTextMax = UBound(baBuffer)
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'lngLength = SendMessage(hwnd, LVM_GETITEMTEXT, lngIndex, VarPtr(objItem))
		'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        'strName = Left(StrConv(System.Text.UnicodeEncoding.Unicode.GetString(baBuffer), vbUnicode), lngLength)
		
		'
		' Obtain the modification date of the specified list view item
		'
		objItem.mask = LVIF_TEXT
		objItem.iSubItem = SubItemPos - 1
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'objItem.pszText = VarPtr(baBuffer(0))
		objItem.cchTextMax = UBound(baBuffer)
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        'lngLength = SendMessage(hwnd, LVM_GETITEMTEXT, lngIndex, VarPtr(objItem))
		If lngLength > 0 Then
			'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
            'dDate = CDate(Left(StrConv(System.Text.UnicodeEncoding.Unicode.GetString(baBuffer), vbUnicode), lngLength))
		End If
		
	End Sub
	
	
	Public Sub LoadExcel(ByVal inFilePath As String)
		Dim MousePointer As Object
		Dim Excel As Object
		
        Dim xlApp As Excel.Application
		
		On Error GoTo LoadExcel_Err
		
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
		
LoadExcel_Err: 
		MsgBox("Can't Display: LoadExcel_err!")
		'UPGRADE_NOTE: Object xlApp may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		xlApp = Nothing
		
	End Sub
End Module