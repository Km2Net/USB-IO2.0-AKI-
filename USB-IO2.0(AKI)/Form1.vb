Option Explicit On

Imports System.Runtime.InteropServices

Public Class Form1
    Public Const DIGCF_PRESENT = &H2
    Public Const DIGCF_DEVICEINTERFACE = &H10

    Public Const FORMAT_MESSAGE_FROM_SYSTEM = &H1000
    Public Const GENERIC_READ = &H80000000
    Public Const GENERIC_WRITE = &H40000000
    Public Const FILE_SHARE_READ = &H1
    Public Const FILE_SHARE_WRITE = &H2
    Public Const OPEN_EXISTING = 3
    Public Const INVALID_HANDLE_VALUE = -1

    Public Const MyVendorID = &H1352        'Km2Net
    Public Const MyProductID = &H120        'USB-IO2.0
    Public Const MyProductID2 = &H121       'USB-IO2.0(AKI)

    <StructLayout(LayoutKind.Sequential, Pack:=1, CharSet:=CharSet.Ansi)>
    Private Structure GUID
        Dim Data1 As UInt32
        Dim Data2 As UInt16
        Dim Data3 As UInt16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim Data4() As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Private Structure HIDD_ATTRIBUTES
        Dim Size As UInt32
        Dim VendorID As UInt16
        Dim ProductID As UInt16
        Dim VersionNumber As UInt16
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Private Structure HIDP_CAPS
        Dim Usage As UInt16
        Dim UsagePage As UInt16
        Dim InputReportByteLength As UInt16
        Dim OutputReportByteLength As UInt16
        Dim FeatureReportByteLength As UInt16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim Reserved() As UInt16
        Dim NumberLinkCollectionNodes As UInt16
        Dim NumberInputButtonCaps As UInt16
        Dim NumberInputValueCaps As UInt16
        Dim NumberInputDataIndices As UInt16
        Dim NumberOutputButtonCaps As UInt16
        Dim NumberOutputValueCaps As UInt16
        Dim NumberOutputDataIndices As UInt16
        Dim NumberFeatureButtonCaps As UInt16
        Dim NumberFeatureValueCaps As UInt16
        Dim NumberFeatureDataIndices As UInt16
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Private Structure SECURITY_ATTRIBUTES
        Dim nLength As Integer
        Dim lpSecurityDescriptor As IntPtr
        Dim bInheritHandle As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1, CharSet:=CharSet.Ansi)>
    Private Structure SP_DEVICE_INTERFACE_DATA
        Dim cbSize As UInt32
        Dim InterfaceClassGuid As GUID
        Dim Flags As UInt32
        Dim Reserved As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1, CharSet:=CharSet.Ansi)>
    Private Structure SP_DEVINFO_DATA
        Dim cbSize As Integer
        Dim ClassGuid As GUID
        Dim DevInst As Integer
        Dim Reserved As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Private Structure SP_DEVICE_INTERFACE_DETAIL_DATA
        Dim cbSize As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim DevicePath() As Byte
    End Structure




    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As IntPtr) As IntPtr

    Private Declare Function CreateFile _
        Lib "kernel32" _
        Alias "CreateFileA" _
        (ByVal lpFileName As String,
        ByVal dwDesiredAccess As Integer,
        ByVal dwShareMode As Integer,
        ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES,
        ByVal dwCreationDisposition As Integer,
        ByVal dwFlagsAndAttributes As Integer,
        ByVal hTemplateFile As Integer) _
    As Integer

    Private Declare Function FormatMessage _
        Lib "kernel32" _
        Alias "FormatMessageA" _
        (ByVal dwFlags As Integer,
        ByRef lpSource As Integer,
        ByVal dwMessageId As Integer,
        ByVal dwLanguageZId As Integer,
        ByVal lpBuffer As String,
        ByVal nSize As Integer,
        ByVal Arguments As Integer) _
    As Integer

    Private Declare Function HidD_FreePreparsedData _
        Lib "hid.dll" _
        (ByRef PreparsedData As Integer) _
    As Integer

    Private Declare Function HidD_GetAttributes _
        Lib "hid.dll" _
        (ByVal HidDeviceObject As Integer,
        ByRef Attributes As HIDD_ATTRIBUTES) _
    As Integer

    Private Declare Function HidD_GetHidGuid _
        Lib "hid.dll" _
        (ByRef HidGuid As GUID) _
    As Integer

    Private Declare Function HidD_GetPreparsedData _
        Lib "hid.dll" _
        (ByVal HidDeviceObject As IntPtr,
        ByRef PreparsedData As IntPtr) _
    As IntPtr

    Private Declare Function HidP_GetCaps _
        Lib "hid.dll" _
        (ByVal PreparsedData As IntPtr,
        ByRef Capabilities As HIDP_CAPS) _
    As IntPtr

    Private Declare Function HidP_GetValueCaps _
        Lib "hid.dll" _
        (ByVal ReportType As Short,
        ByRef ValueCaps As Byte,
        ByRef ValueCapsLength As Short,
        ByVal PreparsedData As Integer) _
    As Integer

    Private Declare Function lstrcpy _
        Lib "kernel32" _
        Alias "lstrcpyA" _
        (ByVal dest As String,
        ByVal source As Integer) _
    As String

    Private Declare Function lstrlen _
        Lib "kernel32" _
        Alias "lstrlenA" _
        (ByVal source As Integer) _
    As Integer

    Private Declare Function ReadFile _
        Lib "kernel32" _
        (ByVal hFile As Integer,
        ByRef lpBuffer As Byte,
        ByVal nNumberOfBytesToRead As Integer,
        ByRef lpNumberOfBytesRead As Integer,
        ByVal lpOverlapped As Integer) _
    As Integer

    Private Declare Sub RtlMoveMemory Lib "kernel32" (ByRef Destination As Byte, ByVal Source As IntPtr, ByVal Length As Short)

    Private Declare Function SetupDiCreateDeviceInfoList _
        Lib "setupapi.dll" _
        (ByRef ClassGuid As GUID,
        ByVal hwndParent As Integer) _
    As Integer

    Private Declare Function SetupDiDestroyDeviceInfoList _
        Lib "setupapi.dll" _
        (ByVal DeviceInfoSet As Integer) _
    As Integer

    Private Declare Function SetupDiEnumDeviceInterfaces _
        Lib "setupapi.dll" _
        (ByVal DeviceInfoSet As IntPtr,
        ByVal DeviceInfoData As IntPtr,
        ByRef InterfaceClassGuid As GUID,
        ByVal MemberIndex As UInt32,
        ByRef DeviceInterfaceData As SP_DEVICE_INTERFACE_DATA) _
    As IntPtr

    Private Declare Function SetupDiGetClassDevs _
        Lib "setupapi.dll" _
        Alias "SetupDiGetClassDevsA" _
        (ByRef ClassGuid As GUID,
        ByVal Enumerator As String,
        ByVal hwndParent As IntPtr,
        ByVal Flags As Integer) _
    As IntPtr

    Private Declare Function SetupDiGetDeviceInterfaceDetail _
       Lib "setupapi.dll" _
       Alias "SetupDiGetDeviceInterfaceDetailA" _
       (ByVal DeviceInfoSet As IntPtr,
       ByRef DeviceInterfaceData As SP_DEVICE_INTERFACE_DATA,
       ByVal DeviceInterfaceDetailData As IntPtr,
       ByVal DeviceInterfaceDetailDataSize As UInt32,
       ByRef RequiredSize As UInt32,
       ByVal DeviceInfoData As IntPtr) _
    As IntPtr

    Private Declare Function WriteFile _
        Lib "kernel32" _
        (ByVal hFile As Integer,
        ByRef lpBuffer As Byte,
        ByVal nNumberOfBytesToWrite As Integer,
        ByRef lpNumberOfBytesWritten As Integer,
        ByVal lpOverlapped As Integer) _
    As Integer

    Private Declare Function GetTickCount Lib "kernel32" () As Integer


    Private HidDevice As Integer = INVALID_HANDLE_VALUE
    Private Capabilities As HIDP_CAPS

    Dim byteStInJ1 As Byte
    Dim byteStInJ2 As Byte
    Dim byteOutJ1 As Byte = 0
    Dim byteOutJ2 As Byte = 0
    Dim byteInJ1 As Byte = 0
    Dim byteInJ2 As Byte = 0

    Dim btnStInJ1() As System.Windows.Forms.Button
    Dim btnStInJ2() As System.Windows.Forms.Button
    Dim btnIoJ1() As System.Windows.Forms.Button
    Dim btnIoJ2() As System.Windows.Forms.Button

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnStInJ1 = New System.Windows.Forms.Button() {btnStInJ10, BtnStInJ11, BtnStInJ12, BtnStInJ13, BtnStInJ14, BtnStInJ15, BtnStInJ16, BtnStInJ17}
        btnStInJ2 = New System.Windows.Forms.Button() {btnStInJ20, BtnStInJ21, BtnStInJ22, BtnStInJ23}
        btnIoJ1 = New System.Windows.Forms.Button() {BtnIoJ10, BtnIoJ11, BtnIoJ12, BtnIoJ13, BtnIoJ14, BtnIoJ15, BtnIoJ16, btnIoJ17}
        btnIoJ2 = New System.Windows.Forms.Button() {btnIoJ20, BtnIoJ21, BtnIoJ22, BtnIoJ23}

        For i = 0 To 7
            AddHandler DirectCast(btnStInJ1(i), Button).Click, AddressOf btnStIn_Click
            AddHandler DirectCast(btnIoJ1(i), Button).Click, AddressOf BtnIO_Click
        Next
        For i = 0 To 3
            AddHandler DirectCast(btnStInJ2(i), Button).Click, AddressOf btnStIn_Click
            AddHandler DirectCast(btnIoJ2(i), Button).Click, AddressOf BtnIO_Click
        Next

        pnlStting.ForeColor = Color.Silver
        pnlRunning.ForeColor = Color.Silver
        btnSetting.Enabled = False
        BtnSendRecv.Enabled = False
        btnStop.Enabled = False
    End Sub

    Private Sub BtnKm2Net_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKm2Net.Click
        System.Diagnostics.Process.Start("http://km2net.com")
    End Sub

    Private Sub BtnConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnConnect.Click
        If OpenDevice() = True Then
            Dim sendData(63) As Byte
            Dim recvData(63) As Byte

            BtnConnect.Enabled = False
            BtnSendRecv.Enabled = True
            BtnSetting.Enabled = True

            sendData(0) = &HF8              'コマンド ：システム設定用フラッシュロム読込み
            sendData(63) = &H0              'シーケンス

            SendRecv(sendData, recvData)    '送受信
            'プルアップ無効　Bit0 ON
            If (recvData(2) And &H1) Then
                chkPullUpStop.Checked = True
            Else
                chkPullUpStop.Checked = False
            End If

            byteStInJ1 = recvData(5)        '入力ピン設定 ビットONが入力ピン
            byteStInJ2 = recvData(6)        '入力ピン設定 ビットONが入力ピン

            byteInJ1 = &HFF
            byteInJ2 = &HF
            byteOutJ1 = &HFF
            byteOutJ2 = &HF
            PnlStting.Enabled = True
            pnlRunning.Enabled = True
            PnlStting.ForeColor = Color.Black
            ChgStInColor()
            ChgIoColor()
        Else
            MsgBox("デバイスが見つかりません。")
        End If
    End Sub

    Private Sub BtnStIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnConnect.Enabled = True Then
            Return
        End If

        Dim strBtnName As String = DirectCast(sender, Button).Name
        If strBtnName.Substring(strBtnName.Length - 2, 1) = "1" Then
            byteStInJ1 = byteStInJ1 Xor (2 ^ Integer.Parse(strBtnName.Substring(strBtnName.Length - 1, 1)))
        Else
            byteStInJ2 = byteStInJ2 Xor (2 ^ Integer.Parse(strBtnName.Substring(strBtnName.Length - 1, 1)))
        End If
        ChgStInColor()
        ChgIoColor()
    End Sub

    Private Sub BtnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetting.Click
        Dim sendData(63) As Byte
        Dim recvData(63) As Byte

        sendData(0) = &HF9              'コマンド ：システム設定用フラッシュロム書き込み
        sendData(1) = 0                 '未使用
        'プルアップ無効
        If chkPullUpStop.Checked = True Then
            sendData(2) = &H1           'プルアップ　1:無効　0:有効
        Else
            sendData(2) = &H0
        End If
        sendData(3) = 0                 '未使用
        sendData(4) = 0                 '未使用
        sendData(5) = byteStInJ1        '入力ピン設定 ビットONが入力ピン
        sendData(6) = byteStInJ2        '入力ピン設定 ビットONが入力ピン
        'シーケンス
        sendData(63) = &H0              'シーケンス

        SendRecv(sendData, recvData)    '送受信

        MessageBox.Show("入力設定しました。" & vbCrLf & "USB-IO2.0を抜差してください")
        CloseDevice()

        tmrSendRecv.Enabled = False
        PnlStting.ForeColor = Color.Silver
        pnlRunning.ForeColor = Color.Silver
        BtnSetting.Enabled = False
        BtnSendRecv.Enabled = False
        btnStop.Enabled = False
        BtnConnect.Enabled = True

    End Sub

    Private Sub BtnIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnConnect.Enabled = True Then
            Return
        End If

        Dim strBtnName As String = DirectCast(sender, Button).Name
        If strBtnName.Substring(strBtnName.Length - 2, 1) = "1" Then
            byteOutJ1 = byteOutJ1 Xor (2 ^ Integer.Parse(strBtnName.Substring(strBtnName.Length - 1, 1)))
        Else
            byteOutJ2 = byteOutJ2 Xor (2 ^ Integer.Parse(strBtnName.Substring(strBtnName.Length - 1, 1)))
        End If
        ChgIoColor()
    End Sub

    Private Sub BtnSendRecv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendRecv.Click
        PnlStting.Enabled = False
        BtnSetting.Enabled = False
        BtnSendRecv.Enabled = False
        tmrSendRecv.Enabled = True
        btnStop.Enabled = True
        PnlStting.ForeColor = Color.Black
        pnlRunning.ForeColor = Color.Yellow
    End Sub

    Private Sub TmrSendRecv_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSendRecv.Tick
        Dim sendData(63) As Byte
        Dim recvData(63) As Byte

        sendData(0) = &H20              'コマンド ：デジタル入出力
        sendData(1) = &H1               '出力１：Ｊ１
        sendData(2) = byteOutJ1         '値
        sendData(3) = &H2               '出力２：Ｊ２
        sendData(4) = byteOutJ2         '値
        sendData(63) = &H0              'シーケンス

        SendRecv(sendData, recvData)    '送受信

        byteInJ1 = recvData(1)          'Ｊ１入力値
        byteInJ2 = recvData(2)          'Ｊ２入力値
        ChgIoColor()
    End Sub

    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        BtnSendRecv.Enabled = True
        tmrSendRecv.Enabled = False
        btnStop.Enabled = False
        pnlRunning.ForeColor = Color.Silver
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CloseDevice()
    End Sub

    Private Sub ChgStInColor()
        Dim i As Integer
        For i = 0 To 7
            If byteStInJ1 And 2 ^ i Then
                btnStInJ1(i).FlatStyle = FlatStyle.Standard
                btnIoJ1(i).BackColor = Color.ForestGreen
            Else
                btnStInJ1(i).FlatStyle = FlatStyle.System
                btnIoJ1(i).BackColor = Color.Red
            End If
        Next
        lblStInJ1.Text = "0" & Hex$(byteStInJ1)
        lblStInJ1.Text = "&&h" & lblStInJ1.Text.Substring(lblStInJ1.Text.Length - 2, 2)
        For i = 0 To 3
            If byteStInJ2 And 2 ^ i Then
                btnStInJ2(i).FlatStyle = FlatStyle.Standard
                btnIoJ2(i).BackColor = Color.ForestGreen
            Else
                btnStInJ2(i).FlatStyle = FlatStyle.System
                btnIoJ2(i).BackColor = Color.Red
            End If
        Next
        lblStInJ2.Text = "0" & Hex$(byteStInJ2)
        lblStInJ2.Text = "&&h" & lblStInJ2.Text.Substring(lblStInJ2.Text.Length - 2, 2)
    End Sub

    Private Sub ChgIoColor()
        Dim i As Integer
        Dim s As String
        For i = 0 To 7
            If ((byteStInJ1 And (2 ^ i)) And (byteInJ1 And (2 ^ i))) _
            Or ((Not (byteStInJ1 And (2 ^ i))) And (byteOutJ1 And (2 ^ i))) Then
                btnIoJ1(i).FlatStyle = FlatStyle.Standard
            Else
                btnIoJ1(i).FlatStyle = FlatStyle.System
            End If
        Next
        s = "0" & Hex$(byteInJ1)
        lblIoJ1.Text = "I:&&h" & s.Substring(s.Length - 2, 2)
        s = "0" & Hex$(byteOutJ1)
        lblIoJ1.Text = lblIoJ1.Text & " O:&&h" & s.Substring(s.Length - 2, 2)
        For i = 0 To 3
            If ((byteStInJ2 And (2 ^ i)) And (byteInJ2 And (2 ^ i))) _
            Or ((Not (byteStInJ2 And (2 ^ i))) And (byteOutJ2 And (2 ^ i))) Then
                btnIoJ2(i).FlatStyle = FlatStyle.Standard
            Else
                btnIoJ2(i).FlatStyle = FlatStyle.System
            End If
        Next
        s = "0" & Hex$(byteInJ2)
        lblIoJ2.Text = "I:&&h" & s.Substring(s.Length - 2, 2)
        s = "0" & Hex$(byteOutJ2)
        lblIoJ2.Text = lblIoJ2.Text & " O:&&h" & s.Substring(s.Length - 2, 2)
    End Sub


    Private Function OpenDevice() As Boolean
        Dim HidGuid As GUID = Nothing
        Dim DeviceInfoSet As IntPtr
        Dim MyDeviceInterfaceData As SP_DEVICE_INTERFACE_DATA = Nothing
        Dim MemberIndex As Integer
        Dim MyDeviceInfoData As SP_DEVINFO_DATA = Nothing
        Dim Needed As UInt32
        Dim DetailData As UInt32
        Dim MyDeviceInterfaceDetailData As SP_DEVICE_INTERFACE_DETAIL_DATA = Nothing
        Dim DetailDataBuffer() As Byte
        Dim gch As GCHandle
        Dim address As IntPtr
        Dim DevicePathName As String
        Dim sa As SECURITY_ATTRIBUTES
        Dim DeviceAttributes As HIDD_ATTRIBUTES
        Dim PreparsedData As IntPtr

        Dim ipt As IntPtr
        Dim Result As IntPtr

        OpenDevice = False

        Result = HidD_GetHidGuid(HidGuid)
        DeviceInfoSet = SetupDiGetClassDevs _
            (HidGuid, vbNullString, 0, (DIGCF_PRESENT Or DIGCF_DEVICEINTERFACE))

        MemberIndex = 0

        Do
            MyDeviceInterfaceData.cbSize = Marshal.SizeOf(MyDeviceInterfaceData)
            Result = SetupDiEnumDeviceInterfaces _
                (DeviceInfoSet, 0, HidGuid, MemberIndex, MyDeviceInterfaceData)

            If Result <> 0 Then
                MyDeviceInfoData.cbSize = Marshal.SizeOf(MyDeviceInfoData)
                Result = SetupDiGetDeviceInterfaceDetail _
                   (DeviceInfoSet, MyDeviceInterfaceData, 0, 0, Needed, 0)

                DetailData = Needed
                MyDeviceInterfaceDetailData.cbSize = Marshal.SizeOf(MyDeviceInterfaceDetailData)
                ReDim DetailDataBuffer(Needed)
                ipt = Marshal.AllocHGlobal(Marshal.SizeOf(MyDeviceInterfaceDetailData))
                Marshal.StructureToPtr(MyDeviceInterfaceDetailData, ipt, False)
                Call RtlMoveMemory(DetailDataBuffer(0), ipt, Marshal.SizeOf(MyDeviceInterfaceDetailData))

                gch = GCHandle.Alloc(DetailDataBuffer, GCHandleType.Pinned)
                address = gch.AddrOfPinnedObject()

                Result = SetupDiGetDeviceInterfaceDetail _
                   (DeviceInfoSet, MyDeviceInterfaceData, address, DetailData, Needed, 0)

                gch.Free()

                DevicePathName = System.Text.Encoding.ASCII.GetString(DetailDataBuffer)
                DevicePathName = DevicePathName.Substring(4)

                sa.nLength = 12
                sa.lpSecurityDescriptor = 0
                sa.bInheritHandle = 0

                HidDevice = CreateFile(DevicePathName, GENERIC_READ Or GENERIC_WRITE, (FILE_SHARE_READ Or FILE_SHARE_WRITE),
                                        sa, OPEN_EXISTING, 0, 0)

                If HidDevice <> INVALID_HANDLE_VALUE Then
                    DeviceAttributes.Size = Marshal.SizeOf(DeviceAttributes)
                    Result = HidD_GetAttributes(HidDevice, DeviceAttributes)

                    If (DeviceAttributes.VendorID = MyVendorID) _
                    And (DeviceAttributes.ProductID = MyProductID Or DeviceAttributes.ProductID = MyProductID2) Then

                        HidD_GetPreparsedData(HidDevice, PreparsedData)
                        HidP_GetCaps(PreparsedData, Capabilities)

                        OpenDevice = True
                        Exit Do
                    Else
                        Result = CloseHandle(HidDevice)
                    End If

                End If
            Else
                Exit Do
            End If
            MemberIndex += 1
        Loop

    End Function

    Private Sub CloseDevice()
        If HidDevice <> INVALID_HANDLE_VALUE Then
            CloseHandle(HidDevice)
        End If
    End Sub

    Private Sub SendRecv(ByVal sendData() As Byte, ByRef recvData() As Byte)
        Dim i As Integer
        Dim s As String
        Dim NumberOfBytesWritten As Integer
        Dim NumberOfBytesRead As Integer

        Dim wrtData(Capabilities.OutputReportByteLength - 1) As Byte
        Dim readData(Capabilities.InputReportByteLength - 1) As Byte

        On Error GoTo errJump

        wrtData(0) = &H0
        For i = 0 To 63
            wrtData(i + 1) = sendData(i)
        Next
        WriteFile(HidDevice, wrtData(0), Capabilities.OutputReportByteLength, NumberOfBytesWritten, 0)

        Do
            ReadFile(HidDevice, readData(0), Capabilities.InputReportByteLength, NumberOfBytesRead, 0)
            If wrtData(64) = readData(64) Then
                Exit Do
            End If
        Loop

        For i = 0 To 63
            recvData(i) = readData(i + 1)
        Next

        Exit Sub
errJump:
        MsgBox(Err.Description)
    End Sub

End Class
