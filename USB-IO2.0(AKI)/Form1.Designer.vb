<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnSendRecv = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.pnlRunning = New System.Windows.Forms.Panel
        Me.btnIoJ17 = New System.Windows.Forms.Button
        Me.lblIoJ1 = New System.Windows.Forms.Label
        Me.lblIoJ2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnIoJ23 = New System.Windows.Forms.Button
        Me.btnIoJ22 = New System.Windows.Forms.Button
        Me.btnIoJ21 = New System.Windows.Forms.Button
        Me.btnIoJ20 = New System.Windows.Forms.Button
        Me.btnIoJ16 = New System.Windows.Forms.Button
        Me.btnIoJ15 = New System.Windows.Forms.Button
        Me.btnIoJ14 = New System.Windows.Forms.Button
        Me.btnIoJ13 = New System.Windows.Forms.Button
        Me.btnIoJ12 = New System.Windows.Forms.Button
        Me.btnIoJ11 = New System.Windows.Forms.Button
        Me.btnIoJ10 = New System.Windows.Forms.Button
        Me.pnlStting = New System.Windows.Forms.Panel
        Me.lblPullUp = New System.Windows.Forms.Label
        Me.chkPullUpStop = New System.Windows.Forms.CheckBox
        Me.btnSetting = New System.Windows.Forms.Button
        Me.lblStInJ1 = New System.Windows.Forms.Label
        Me.lblStInJ2 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnStInJ23 = New System.Windows.Forms.Button
        Me.btnStInJ22 = New System.Windows.Forms.Button
        Me.btnStInJ21 = New System.Windows.Forms.Button
        Me.btnStInJ20 = New System.Windows.Forms.Button
        Me.btnStInJ17 = New System.Windows.Forms.Button
        Me.btnStInJ16 = New System.Windows.Forms.Button
        Me.btnStInJ15 = New System.Windows.Forms.Button
        Me.btnStInJ14 = New System.Windows.Forms.Button
        Me.btnStInJ13 = New System.Windows.Forms.Button
        Me.btnStInJ12 = New System.Windows.Forms.Button
        Me.btnStInJ11 = New System.Windows.Forms.Button
        Me.btnStInJ10 = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.tmrSendRecv = New System.Windows.Forms.Timer(Me.components)
        Me.btnKm2Net = New System.Windows.Forms.Button
        Me.pnlRunning.SuspendLayout()
        Me.pnlStting.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSendRecv
        '
        Me.btnSendRecv.Location = New System.Drawing.Point(12, 176)
        Me.btnSendRecv.Name = "btnSendRecv"
        Me.btnSendRecv.Size = New System.Drawing.Size(59, 27)
        Me.btnSendRecv.TabIndex = 35
        Me.btnSendRecv.Text = "送受信"
        Me.btnSendRecv.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 3)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(59, 27)
        Me.btnConnect.TabIndex = 34
        Me.btnConnect.Text = "接続"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'pnlRunning
        '
        Me.pnlRunning.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlRunning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRunning.Controls.Add(Me.btnIoJ17)
        Me.pnlRunning.Controls.Add(Me.lblIoJ1)
        Me.pnlRunning.Controls.Add(Me.lblIoJ2)
        Me.pnlRunning.Controls.Add(Me.Label14)
        Me.pnlRunning.Controls.Add(Me.Label13)
        Me.pnlRunning.Controls.Add(Me.Label10)
        Me.pnlRunning.Controls.Add(Me.Label9)
        Me.pnlRunning.Controls.Add(Me.btnIoJ23)
        Me.pnlRunning.Controls.Add(Me.btnIoJ22)
        Me.pnlRunning.Controls.Add(Me.btnIoJ21)
        Me.pnlRunning.Controls.Add(Me.btnIoJ20)
        Me.pnlRunning.Controls.Add(Me.btnIoJ16)
        Me.pnlRunning.Controls.Add(Me.btnIoJ15)
        Me.pnlRunning.Controls.Add(Me.btnIoJ14)
        Me.pnlRunning.Controls.Add(Me.btnIoJ13)
        Me.pnlRunning.Controls.Add(Me.btnIoJ12)
        Me.pnlRunning.Controls.Add(Me.btnIoJ11)
        Me.pnlRunning.Controls.Add(Me.btnIoJ10)
        Me.pnlRunning.ForeColor = System.Drawing.Color.Yellow
        Me.pnlRunning.Location = New System.Drawing.Point(12, 209)
        Me.pnlRunning.Name = "pnlRunning"
        Me.pnlRunning.Size = New System.Drawing.Size(290, 123)
        Me.pnlRunning.TabIndex = 36
        '
        'btnIoJ17
        '
        Me.btnIoJ17.BackColor = System.Drawing.Color.Red
        Me.btnIoJ17.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ17.Location = New System.Drawing.Point(254, 63)
        Me.btnIoJ17.Name = "btnIoJ17"
        Me.btnIoJ17.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ17.TabIndex = 19
        Me.btnIoJ17.Text = "7"
        Me.btnIoJ17.UseVisualStyleBackColor = False
        '
        'lblIoJ1
        '
        Me.lblIoJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIoJ1.Font = New System.Drawing.Font("ＭＳ 明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblIoJ1.Location = New System.Drawing.Point(46, 96)
        Me.lblIoJ1.Name = "lblIoJ1"
        Me.lblIoJ1.Size = New System.Drawing.Size(130, 21)
        Me.lblIoJ1.TabIndex = 18
        Me.lblIoJ1.Text = "I:&&hFF O:&&hFF"
        '
        'lblIoJ2
        '
        Me.lblIoJ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIoJ2.Font = New System.Drawing.Font("ＭＳ 明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblIoJ2.Location = New System.Drawing.Point(153, 2)
        Me.lblIoJ2.Name = "lblIoJ2"
        Me.lblIoJ2.Size = New System.Drawing.Size(130, 21)
        Me.lblIoJ2.TabIndex = 17
        Me.lblIoJ2.Text = "I:&&h0F O:&&h0F"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "J1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(127, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "J2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "入出力状態"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "USB-IO 2.0"
        '
        'btnIoJ23
        '
        Me.btnIoJ23.BackColor = System.Drawing.Color.ForestGreen
        Me.btnIoJ23.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ23.Location = New System.Drawing.Point(146, 25)
        Me.btnIoJ23.Name = "btnIoJ23"
        Me.btnIoJ23.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ23.TabIndex = 12
        Me.btnIoJ23.Text = "3"
        Me.btnIoJ23.UseVisualStyleBackColor = False
        '
        'btnIoJ22
        '
        Me.btnIoJ22.BackColor = System.Drawing.Color.ForestGreen
        Me.btnIoJ22.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ22.Location = New System.Drawing.Point(182, 25)
        Me.btnIoJ22.Name = "btnIoJ22"
        Me.btnIoJ22.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ22.TabIndex = 11
        Me.btnIoJ22.Text = "2"
        Me.btnIoJ22.UseVisualStyleBackColor = False
        '
        'btnIoJ21
        '
        Me.btnIoJ21.BackColor = System.Drawing.Color.ForestGreen
        Me.btnIoJ21.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ21.Location = New System.Drawing.Point(218, 25)
        Me.btnIoJ21.Name = "btnIoJ21"
        Me.btnIoJ21.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ21.TabIndex = 10
        Me.btnIoJ21.Text = "1"
        Me.btnIoJ21.UseVisualStyleBackColor = False
        '
        'btnIoJ20
        '
        Me.btnIoJ20.BackColor = System.Drawing.Color.ForestGreen
        Me.btnIoJ20.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ20.Location = New System.Drawing.Point(254, 25)
        Me.btnIoJ20.Name = "btnIoJ20"
        Me.btnIoJ20.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ20.TabIndex = 9
        Me.btnIoJ20.Text = "0"
        Me.btnIoJ20.UseVisualStyleBackColor = False
        '
        'btnIoJ16
        '
        Me.btnIoJ16.BackColor = System.Drawing.Color.Red
        Me.btnIoJ16.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ16.Location = New System.Drawing.Point(218, 63)
        Me.btnIoJ16.Name = "btnIoJ16"
        Me.btnIoJ16.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ16.TabIndex = 7
        Me.btnIoJ16.Text = "6"
        Me.btnIoJ16.UseVisualStyleBackColor = False
        '
        'btnIoJ15
        '
        Me.btnIoJ15.BackColor = System.Drawing.Color.Red
        Me.btnIoJ15.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ15.Location = New System.Drawing.Point(182, 63)
        Me.btnIoJ15.Name = "btnIoJ15"
        Me.btnIoJ15.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ15.TabIndex = 6
        Me.btnIoJ15.Text = "5"
        Me.btnIoJ15.UseVisualStyleBackColor = False
        '
        'btnIoJ14
        '
        Me.btnIoJ14.BackColor = System.Drawing.Color.Red
        Me.btnIoJ14.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ14.Location = New System.Drawing.Point(146, 63)
        Me.btnIoJ14.Name = "btnIoJ14"
        Me.btnIoJ14.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ14.TabIndex = 5
        Me.btnIoJ14.Text = "4"
        Me.btnIoJ14.UseVisualStyleBackColor = False
        '
        'btnIoJ13
        '
        Me.btnIoJ13.BackColor = System.Drawing.Color.Red
        Me.btnIoJ13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ13.Location = New System.Drawing.Point(110, 63)
        Me.btnIoJ13.Name = "btnIoJ13"
        Me.btnIoJ13.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ13.TabIndex = 4
        Me.btnIoJ13.Text = "3"
        Me.btnIoJ13.UseVisualStyleBackColor = False
        '
        'btnIoJ12
        '
        Me.btnIoJ12.BackColor = System.Drawing.Color.Red
        Me.btnIoJ12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ12.Location = New System.Drawing.Point(74, 63)
        Me.btnIoJ12.Name = "btnIoJ12"
        Me.btnIoJ12.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ12.TabIndex = 3
        Me.btnIoJ12.Text = "2"
        Me.btnIoJ12.UseVisualStyleBackColor = False
        '
        'btnIoJ11
        '
        Me.btnIoJ11.BackColor = System.Drawing.Color.Red
        Me.btnIoJ11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ11.Location = New System.Drawing.Point(38, 63)
        Me.btnIoJ11.Name = "btnIoJ11"
        Me.btnIoJ11.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ11.TabIndex = 2
        Me.btnIoJ11.Text = "1"
        Me.btnIoJ11.UseVisualStyleBackColor = False
        '
        'btnIoJ10
        '
        Me.btnIoJ10.BackColor = System.Drawing.Color.Red
        Me.btnIoJ10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnIoJ10.Location = New System.Drawing.Point(2, 63)
        Me.btnIoJ10.Name = "btnIoJ10"
        Me.btnIoJ10.Size = New System.Drawing.Size(30, 30)
        Me.btnIoJ10.TabIndex = 1
        Me.btnIoJ10.Text = "0"
        Me.btnIoJ10.UseVisualStyleBackColor = False
        '
        'pnlStting
        '
        Me.pnlStting.BackColor = System.Drawing.SystemColors.Control
        Me.pnlStting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlStting.Controls.Add(Me.lblPullUp)
        Me.pnlStting.Controls.Add(Me.chkPullUpStop)
        Me.pnlStting.Controls.Add(Me.btnSetting)
        Me.pnlStting.Controls.Add(Me.lblStInJ1)
        Me.pnlStting.Controls.Add(Me.lblStInJ2)
        Me.pnlStting.Controls.Add(Me.Label19)
        Me.pnlStting.Controls.Add(Me.Label20)
        Me.pnlStting.Controls.Add(Me.Label21)
        Me.pnlStting.Controls.Add(Me.Label22)
        Me.pnlStting.Controls.Add(Me.btnStInJ23)
        Me.pnlStting.Controls.Add(Me.btnStInJ22)
        Me.pnlStting.Controls.Add(Me.btnStInJ21)
        Me.pnlStting.Controls.Add(Me.btnStInJ20)
        Me.pnlStting.Controls.Add(Me.btnStInJ17)
        Me.pnlStting.Controls.Add(Me.btnStInJ16)
        Me.pnlStting.Controls.Add(Me.btnStInJ15)
        Me.pnlStting.Controls.Add(Me.btnStInJ14)
        Me.pnlStting.Controls.Add(Me.btnStInJ13)
        Me.pnlStting.Controls.Add(Me.btnStInJ12)
        Me.pnlStting.Controls.Add(Me.btnStInJ11)
        Me.pnlStting.Controls.Add(Me.btnStInJ10)
        Me.pnlStting.ForeColor = System.Drawing.Color.Black
        Me.pnlStting.Location = New System.Drawing.Point(12, 36)
        Me.pnlStting.Name = "pnlStting"
        Me.pnlStting.Size = New System.Drawing.Size(290, 109)
        Me.pnlStting.TabIndex = 37
        '
        'lblPullUp
        '
        Me.lblPullUp.AutoSize = True
        Me.lblPullUp.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPullUp.Location = New System.Drawing.Point(240, 21)
        Me.lblPullUp.Name = "lblPullUp"
        Me.lblPullUp.Size = New System.Drawing.Size(43, 26)
        Me.lblPullUp.TabIndex = 45
        Me.lblPullUp.Text = "PullUp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "無効"
        '
        'chkPullUpStop
        '
        Me.chkPullUpStop.AutoSize = True
        Me.chkPullUpStop.Location = New System.Drawing.Point(226, 29)
        Me.chkPullUpStop.Name = "chkPullUpStop"
        Me.chkPullUpStop.Size = New System.Drawing.Size(15, 14)
        Me.chkPullUpStop.TabIndex = 44
        Me.chkPullUpStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkPullUpStop.UseVisualStyleBackColor = True
        '
        'btnSetting
        '
        Me.btnSetting.Location = New System.Drawing.Point(243, 56)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(39, 44)
        Me.btnSetting.TabIndex = 38
        Me.btnSetting.Text = "設定変更"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'lblStInJ1
        '
        Me.lblStInJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStInJ1.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStInJ1.Location = New System.Drawing.Point(38, 82)
        Me.lblStInJ1.Name = "lblStInJ1"
        Me.lblStInJ1.Size = New System.Drawing.Size(54, 21)
        Me.lblStInJ1.TabIndex = 18
        Me.lblStInJ1.Text = "&&h0f"
        '
        'lblStInJ2
        '
        Me.lblStInJ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStInJ2.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStInJ2.Location = New System.Drawing.Point(144, 1)
        Me.lblStInJ2.Name = "lblStInJ2"
        Me.lblStInJ2.Size = New System.Drawing.Size(54, 21)
        Me.lblStInJ2.TabIndex = 17
        Me.lblStInJ2.Text = "&&h0f"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "J1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(118, 2)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "J2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 16)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "入力設定"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 5)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 16)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "USB-IO 2.0"
        '
        'btnStInJ23
        '
        Me.btnStInJ23.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ23.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ23.Location = New System.Drawing.Point(114, 24)
        Me.btnStInJ23.Name = "btnStInJ23"
        Me.btnStInJ23.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ23.TabIndex = 12
        Me.btnStInJ23.Text = "3"
        Me.btnStInJ23.UseVisualStyleBackColor = False
        '
        'btnStInJ22
        '
        Me.btnStInJ22.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ22.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ22.Location = New System.Drawing.Point(142, 24)
        Me.btnStInJ22.Name = "btnStInJ22"
        Me.btnStInJ22.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ22.TabIndex = 11
        Me.btnStInJ22.Text = "2"
        Me.btnStInJ22.UseVisualStyleBackColor = False
        '
        'btnStInJ21
        '
        Me.btnStInJ21.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ21.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ21.Location = New System.Drawing.Point(170, 24)
        Me.btnStInJ21.Name = "btnStInJ21"
        Me.btnStInJ21.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ21.TabIndex = 10
        Me.btnStInJ21.Text = "1"
        Me.btnStInJ21.UseVisualStyleBackColor = False
        '
        'btnStInJ20
        '
        Me.btnStInJ20.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ20.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ20.Location = New System.Drawing.Point(198, 24)
        Me.btnStInJ20.Name = "btnStInJ20"
        Me.btnStInJ20.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ20.TabIndex = 9
        Me.btnStInJ20.Text = "0"
        Me.btnStInJ20.UseVisualStyleBackColor = False
        '
        'btnStInJ17
        '
        Me.btnStInJ17.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ17.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ17.Location = New System.Drawing.Point(198, 56)
        Me.btnStInJ17.Name = "btnStInJ17"
        Me.btnStInJ17.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ17.TabIndex = 8
        Me.btnStInJ17.Text = "7"
        Me.btnStInJ17.UseVisualStyleBackColor = False
        '
        'btnStInJ16
        '
        Me.btnStInJ16.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ16.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ16.Location = New System.Drawing.Point(170, 56)
        Me.btnStInJ16.Name = "btnStInJ16"
        Me.btnStInJ16.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ16.TabIndex = 7
        Me.btnStInJ16.Text = "6"
        Me.btnStInJ16.UseVisualStyleBackColor = False
        '
        'btnStInJ15
        '
        Me.btnStInJ15.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ15.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ15.Location = New System.Drawing.Point(142, 56)
        Me.btnStInJ15.Name = "btnStInJ15"
        Me.btnStInJ15.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ15.TabIndex = 6
        Me.btnStInJ15.Text = "5"
        Me.btnStInJ15.UseVisualStyleBackColor = False
        '
        'btnStInJ14
        '
        Me.btnStInJ14.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ14.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ14.Location = New System.Drawing.Point(114, 56)
        Me.btnStInJ14.Name = "btnStInJ14"
        Me.btnStInJ14.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ14.TabIndex = 5
        Me.btnStInJ14.Text = "4"
        Me.btnStInJ14.UseVisualStyleBackColor = False
        '
        'btnStInJ13
        '
        Me.btnStInJ13.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ13.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ13.Location = New System.Drawing.Point(86, 56)
        Me.btnStInJ13.Name = "btnStInJ13"
        Me.btnStInJ13.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ13.TabIndex = 4
        Me.btnStInJ13.Text = "3"
        Me.btnStInJ13.UseVisualStyleBackColor = False
        '
        'btnStInJ12
        '
        Me.btnStInJ12.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ12.Location = New System.Drawing.Point(58, 56)
        Me.btnStInJ12.Name = "btnStInJ12"
        Me.btnStInJ12.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ12.TabIndex = 3
        Me.btnStInJ12.Text = "2"
        Me.btnStInJ12.UseVisualStyleBackColor = False
        '
        'btnStInJ11
        '
        Me.btnStInJ11.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ11.Location = New System.Drawing.Point(30, 56)
        Me.btnStInJ11.Name = "btnStInJ11"
        Me.btnStInJ11.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ11.TabIndex = 2
        Me.btnStInJ11.Text = "1"
        Me.btnStInJ11.UseVisualStyleBackColor = False
        '
        'btnStInJ10
        '
        Me.btnStInJ10.BackColor = System.Drawing.Color.Lime
        Me.btnStInJ10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStInJ10.Location = New System.Drawing.Point(2, 56)
        Me.btnStInJ10.Name = "btnStInJ10"
        Me.btnStInJ10.Size = New System.Drawing.Size(22, 23)
        Me.btnStInJ10.TabIndex = 1
        Me.btnStInJ10.Text = "0"
        Me.btnStInJ10.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(88, 176)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(59, 27)
        Me.btnStop.TabIndex = 39
        Me.btnStop.Text = "停止"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'tmrSendRecv
        '
        '
        'btnKm2Net
        '
        Me.btnKm2Net.FlatAppearance.BorderSize = 0
        Me.btnKm2Net.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKm2Net.Font = New System.Drawing.Font("Century", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKm2Net.ForeColor = System.Drawing.Color.Blue
        Me.btnKm2Net.Location = New System.Drawing.Point(173, 1)
        Me.btnKm2Net.Name = "btnKm2Net"
        Me.btnKm2Net.Size = New System.Drawing.Size(129, 26)
        Me.btnKm2Net.TabIndex = 41
        Me.btnKm2Net.Text = "Km2Net Inc."
        Me.btnKm2Net.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 340)
        Me.Controls.Add(Me.btnKm2Net)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.pnlStting)
        Me.Controls.Add(Me.pnlRunning)
        Me.Controls.Add(Me.btnSendRecv)
        Me.Controls.Add(Me.btnConnect)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "USB-IO2.0(AKI) サンプル"
        Me.pnlRunning.ResumeLayout(False)
        Me.pnlRunning.PerformLayout()
        Me.pnlStting.ResumeLayout(False)
        Me.pnlStting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSendRecv As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents pnlRunning As System.Windows.Forms.Panel
    Friend WithEvents btnIoJ23 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ22 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ21 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ20 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ16 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ15 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ14 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ13 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ12 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ11 As System.Windows.Forms.Button
    Friend WithEvents btnIoJ10 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblIoJ2 As System.Windows.Forms.Label
    Friend WithEvents lblIoJ1 As System.Windows.Forms.Label
    Friend WithEvents pnlStting As System.Windows.Forms.Panel
    Friend WithEvents lblStInJ1 As System.Windows.Forms.Label
    Friend WithEvents lblStInJ2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnStInJ23 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ22 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ21 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ20 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ17 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ16 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ15 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ14 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ13 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ12 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ11 As System.Windows.Forms.Button
    Friend WithEvents btnStInJ10 As System.Windows.Forms.Button
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnKm2Net As System.Windows.Forms.Button
    Friend WithEvents tmrSendRecv As System.Windows.Forms.Timer
    Friend WithEvents btnIoJ17 As System.Windows.Forms.Button
    Friend WithEvents lblPullUp As System.Windows.Forms.Label
    Friend WithEvents chkPullUpStop As System.Windows.Forms.CheckBox

End Class
